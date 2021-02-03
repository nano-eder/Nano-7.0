<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relLog
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
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsRelLog = New System.Data.DataSet
        Me.tbRelLog = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUsuario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAntigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNovo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colColuna = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTabela = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMotivo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsRelLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbRelLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.WinControlContainer1})
        Me.Detail.Height = 103
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        Me.GridControl1.DataMember = "tbRelLog"
        Me.GridControl1.DataSource = Me.dsRelLog
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1056, 72)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'dsRelLog
        '
        Me.dsRelLog.DataSetName = "NewDataSet"
        Me.dsRelLog.Tables.AddRange(New System.Data.DataTable() {Me.tbRelLog})
        '
        'tbRelLog
        '
        Me.tbRelLog.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7})
        Me.tbRelLog.TableName = "tbRelLog"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Data"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Usuario"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Antigo"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Novo"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Coluna"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Tabela"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Motivo"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colData, Me.colUsuario, Me.colAntigo, Me.colNovo, Me.colColuna, Me.colTabela, Me.colMotivo})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
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
        Me.colData.VisibleIndex = 0
        Me.colData.Width = 91
        '
        'colUsuario
        '
        Me.colUsuario.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colUsuario.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUsuario.AppearanceHeader.Options.UseBackColor = True
        Me.colUsuario.AppearanceHeader.Options.UseFont = True
        Me.colUsuario.Caption = "Nome Usuário"
        Me.colUsuario.FieldName = "Usuario"
        Me.colUsuario.Name = "colUsuario"
        Me.colUsuario.Visible = True
        Me.colUsuario.VisibleIndex = 4
        Me.colUsuario.Width = 191
        '
        'colAntigo
        '
        Me.colAntigo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colAntigo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAntigo.AppearanceHeader.Options.UseBackColor = True
        Me.colAntigo.AppearanceHeader.Options.UseFont = True
        Me.colAntigo.Caption = "Conteúdo Antigo"
        Me.colAntigo.FieldName = "Antigo"
        Me.colAntigo.Name = "colAntigo"
        Me.colAntigo.Visible = True
        Me.colAntigo.VisibleIndex = 5
        Me.colAntigo.Width = 230
        '
        'colNovo
        '
        Me.colNovo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNovo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNovo.AppearanceHeader.Options.UseBackColor = True
        Me.colNovo.AppearanceHeader.Options.UseFont = True
        Me.colNovo.Caption = "Conteúdo Novo"
        Me.colNovo.FieldName = "Novo"
        Me.colNovo.Name = "colNovo"
        Me.colNovo.Visible = True
        Me.colNovo.VisibleIndex = 6
        Me.colNovo.Width = 241
        '
        'colColuna
        '
        Me.colColuna.AppearanceCell.Options.UseTextOptions = True
        Me.colColuna.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColuna.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colColuna.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colColuna.AppearanceHeader.Options.UseBackColor = True
        Me.colColuna.AppearanceHeader.Options.UseFont = True
        Me.colColuna.Caption = "Coluna"
        Me.colColuna.FieldName = "Coluna"
        Me.colColuna.Name = "colColuna"
        Me.colColuna.Visible = True
        Me.colColuna.VisibleIndex = 2
        Me.colColuna.Width = 109
        '
        'colTabela
        '
        Me.colTabela.AppearanceCell.Options.UseTextOptions = True
        Me.colTabela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTabela.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colTabela.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTabela.AppearanceHeader.Options.UseBackColor = True
        Me.colTabela.AppearanceHeader.Options.UseFont = True
        Me.colTabela.Caption = "Tabela"
        Me.colTabela.FieldName = "Tabela"
        Me.colTabela.Name = "colTabela"
        Me.colTabela.Visible = True
        Me.colTabela.VisibleIndex = 1
        Me.colTabela.Width = 137
        '
        'colMotivo
        '
        Me.colMotivo.AppearanceCell.Options.UseTextOptions = True
        Me.colMotivo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMotivo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colMotivo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMotivo.AppearanceHeader.Options.UseBackColor = True
        Me.colMotivo.AppearanceHeader.Options.UseFont = True
        Me.colMotivo.Caption = "Motivo"
        Me.colMotivo.FieldName = "Motivo"
        Me.colMotivo.Name = "colMotivo"
        Me.colMotivo.Visible = True
        Me.colMotivo.VisibleIndex = 3
        Me.colMotivo.Width = 89
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.picLogo, Me.XrLine3, Me.lblTitulo})
        Me.PageHeader.Height = 108
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine2
        '
        Me.XrLine2.LineWidth = 2
        Me.XrLine2.Location = New System.Drawing.Point(0, 100)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(1100, 8)
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
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(300, 33)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitulo.Size = New System.Drawing.Size(783, 25)
        Me.lblTitulo.StylePriority.UseFont = False
        Me.lblTitulo.StylePriority.UseTextAlignment = False
        Me.lblTitulo.Text = "lblTitulo"
        Me.lblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'relLog
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
        CType(Me.dsRelLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbRelLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents picLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents WinControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents dsRelLog As System.Data.DataSet
    Friend WithEvents tbRelLog As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAntigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNovo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColuna As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTabela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMotivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
End Class
