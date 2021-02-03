<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relPed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(relPed))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.lblNumVenda = New DevExpress.XtraReports.UI.XRLabel
        Me.lblNVenda = New DevExpress.XtraReports.UI.XRLabel
        Me.lblStatus = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblVend = New DevExpress.XtraReports.UI.XRLabel
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.tbConsig = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.colTamanho = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.colValorUnitario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUniSemDesc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLocacao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEstoque = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblWeb = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblNome = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblTel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblTel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblData = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblPed = New DevExpress.XtraReports.UI.XRLabel
        Me.lblNomePed = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.WinControlContainer2 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.dsConsig = New System.Data.DataSet
        Me.tbServico = New System.Data.DataTable
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colProduto1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.colTamanho1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtd1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorUnitario1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorTotal1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUniSemDesc1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUM1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLocacao1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.lblFones = New DevExpress.XtraReports.UI.XRLabel
        Me.lblEndereco = New DevExpress.XtraReports.UI.XRLabel
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.rtbConfigObs = New DevExpress.XtraReports.UI.XRRichText
        Me.XrLine8 = New DevExpress.XtraReports.UI.XRLine
        Me.txtTexto2 = New DevExpress.XtraReports.UI.XRRichText
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.txtTexto = New DevExpress.XtraReports.UI.XRRichText
        Me.XrLine7 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblAutorizacao = New DevExpress.XtraReports.UI.XRLabel
        Me.lblAtivo = New DevExpress.XtraReports.UI.XRLabel
        Me.linhaAtivo = New DevExpress.XtraReports.UI.XRLine
        Me.tabAtivo = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.rtbObs = New DevExpress.XtraReports.UI.XRRichText
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.tblQtd = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.tblDesc = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.tblTotal = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell
        Me.tblTotalprod = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell
        Me.tblTotalserv = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrLine6 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbConsig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsConsig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbServico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rtbConfigObs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTexto2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTexto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabAtivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rtbObs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblNumVenda, Me.lblNVenda, Me.lblStatus, Me.XrLabel8, Me.XrLabel4, Me.lblVend, Me.WinControlContainer1, Me.XrLine4, Me.XrLine1, Me.XrLabel9, Me.lblWeb, Me.XrLabel12, Me.XrLabel14, Me.lblNome, Me.XrLabel13, Me.lblTel1, Me.XrLabel11, Me.lblTel2, Me.lblData, Me.XrLabel3, Me.lblPed, Me.lblNomePed, Me.XrLabel10})
        Me.Detail.Height = 202
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblNumVenda
        '
        Me.lblNumVenda.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.lblNumVenda.Location = New System.Drawing.Point(350, 42)
        Me.lblNumVenda.Name = "lblNumVenda"
        Me.lblNumVenda.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNumVenda.Size = New System.Drawing.Size(133, 17)
        Me.lblNumVenda.StylePriority.UseFont = False
        Me.lblNumVenda.StylePriority.UseTextAlignment = False
        Me.lblNumVenda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.lblNumVenda.Visible = False
        '
        'lblNVenda
        '
        Me.lblNVenda.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblNVenda.Location = New System.Drawing.Point(267, 42)
        Me.lblNVenda.Name = "lblNVenda"
        Me.lblNVenda.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNVenda.Size = New System.Drawing.Size(75, 17)
        Me.lblNVenda.StylePriority.UseFont = False
        Me.lblNVenda.StylePriority.UseTextAlignment = False
        Me.lblNVenda.Text = "N° Venda:"
        Me.lblNVenda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblNVenda.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.lblStatus.Location = New System.Drawing.Point(650, 42)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblStatus.Size = New System.Drawing.Size(108, 17)
        Me.lblStatus.StylePriority.UseFont = False
        Me.lblStatus.StylePriority.UseTextAlignment = False
        Me.lblStatus.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.Location = New System.Drawing.Point(592, 42)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.Size = New System.Drawing.Size(50, 17)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Status:"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.Location = New System.Drawing.Point(242, 8)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.Size = New System.Drawing.Size(100, 17)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Vendedor (a):"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblVend
        '
        Me.lblVend.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.lblVend.Location = New System.Drawing.Point(350, 8)
        Me.lblVend.Name = "lblVend"
        Me.lblVend.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblVend.Size = New System.Drawing.Size(233, 17)
        Me.lblVend.StylePriority.UseFont = False
        Me.lblVend.StylePriority.UseTextAlignment = False
        Me.lblVend.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.Location = New System.Drawing.Point(0, 142)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.Size = New System.Drawing.Size(758, 58)
        Me.WinControlContainer1.WinControl = Me.GridControl1
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.tbConsig
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemMemoEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(728, 56)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'tbConsig
        '
        Me.tbConsig.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn17, Me.DataColumn19})
        Me.tbConsig.TableName = "tbConsig"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Produto"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Tamanho"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Qtd"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "ValorUnitario"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "ValorTotal"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Codigo"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "UniSemDesc"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "UM"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "Locacao"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "Estoque"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProduto, Me.colTamanho, Me.colQtd, Me.colValorUnitario, Me.colValorTotal, Me.colCodigo, Me.colUniSemDesc, Me.colUM, Me.colLocacao, Me.colEstoque})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colProduto
        '
        Me.colProduto.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colProduto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colProduto.AppearanceHeader.Options.UseBackColor = True
        Me.colProduto.AppearanceHeader.Options.UseFont = True
        Me.colProduto.Caption = "Produto"
        Me.colProduto.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.FixedWidth = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 1
        Me.colProduto.Width = 200
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
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
        Me.colTamanho.VisibleIndex = 3
        Me.colTamanho.Width = 23
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
        Me.colQtd.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.colQtd.FieldName = "Qtd"
        Me.colQtd.Name = "colQtd"
        Me.colQtd.Visible = True
        Me.colQtd.VisibleIndex = 4
        Me.colQtd.Width = 41
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'colValorUnitario
        '
        Me.colValorUnitario.AppearanceCell.Options.UseTextOptions = True
        Me.colValorUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorUnitario.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValorUnitario.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValorUnitario.AppearanceHeader.Options.UseBackColor = True
        Me.colValorUnitario.AppearanceHeader.Options.UseFont = True
        Me.colValorUnitario.Caption = "Valor Unit. R$"
        Me.colValorUnitario.FieldName = "ValorUnitario"
        Me.colValorUnitario.Name = "colValorUnitario"
        Me.colValorUnitario.OptionsColumn.FixedWidth = True
        Me.colValorUnitario.Visible = True
        Me.colValorUnitario.VisibleIndex = 6
        Me.colValorUnitario.Width = 99
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
        Me.colValorTotal.OptionsColumn.FixedWidth = True
        Me.colValorTotal.Visible = True
        Me.colValorTotal.VisibleIndex = 7
        Me.colValorTotal.Width = 99
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodigo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigo.AppearanceHeader.Options.UseBackColor = True
        Me.colCodigo.AppearanceHeader.Options.UseFont = True
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.FixedWidth = True
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 60
        '
        'colUniSemDesc
        '
        Me.colUniSemDesc.AppearanceCell.Options.UseTextOptions = True
        Me.colUniSemDesc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colUniSemDesc.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colUniSemDesc.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUniSemDesc.AppearanceHeader.Options.UseBackColor = True
        Me.colUniSemDesc.AppearanceHeader.Options.UseFont = True
        Me.colUniSemDesc.Caption = "Sem Desc. R$"
        Me.colUniSemDesc.FieldName = "UniSemDesc"
        Me.colUniSemDesc.Name = "colUniSemDesc"
        Me.colUniSemDesc.OptionsColumn.FixedWidth = True
        Me.colUniSemDesc.Visible = True
        Me.colUniSemDesc.VisibleIndex = 5
        Me.colUniSemDesc.Width = 99
        '
        'colUM
        '
        Me.colUM.AppearanceCell.Options.UseTextOptions = True
        Me.colUM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUM.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colUM.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUM.AppearanceHeader.Options.UseBackColor = True
        Me.colUM.AppearanceHeader.Options.UseFont = True
        Me.colUM.Caption = "UM"
        Me.colUM.FieldName = "UM"
        Me.colUM.Name = "colUM"
        Me.colUM.Visible = True
        Me.colUM.VisibleIndex = 2
        Me.colUM.Width = 25
        '
        'colLocacao
        '
        Me.colLocacao.AppearanceCell.Options.UseTextOptions = True
        Me.colLocacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLocacao.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colLocacao.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colLocacao.AppearanceHeader.Options.UseBackColor = True
        Me.colLocacao.AppearanceHeader.Options.UseFont = True
        Me.colLocacao.Caption = "Locação"
        Me.colLocacao.FieldName = "Locacao"
        Me.colLocacao.Name = "colLocacao"
        Me.colLocacao.Width = 70
        '
        'colEstoque
        '
        Me.colEstoque.AppearanceCell.Options.UseTextOptions = True
        Me.colEstoque.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colEstoque.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colEstoque.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colEstoque.AppearanceHeader.Options.UseBackColor = True
        Me.colEstoque.AppearanceHeader.Options.UseFont = True
        Me.colEstoque.Caption = "Qtd. Estoque"
        Me.colEstoque.FieldName = "Estoque"
        Me.colEstoque.Name = "colEstoque"
        Me.colEstoque.Width = 41
        '
        'XrLine4
        '
        Me.XrLine4.LineWidth = 2
        Me.XrLine4.Location = New System.Drawing.Point(0, 58)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.Size = New System.Drawing.Size(758, 10)
        '
        'XrLine1
        '
        Me.XrLine1.LineWidth = 2
        Me.XrLine1.Location = New System.Drawing.Point(0, 133)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(758, 10)
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.Location = New System.Drawing.Point(0, 117)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.Size = New System.Drawing.Size(100, 17)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Produtos"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblWeb
        '
        Me.lblWeb.Location = New System.Drawing.Point(100, 92)
        Me.lblWeb.Name = "lblWeb"
        Me.lblWeb.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblWeb.Size = New System.Drawing.Size(450, 17)
        Me.lblWeb.StylePriority.UseTextAlignment = False
        Me.lblWeb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.Location = New System.Drawing.Point(25, 92)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.Size = New System.Drawing.Size(67, 17)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "E-Mail:"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel14
        '
        Me.XrLabel14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.Location = New System.Drawing.Point(25, 75)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.Size = New System.Drawing.Size(67, 17)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "Nome:"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblNome
        '
        Me.lblNome.Location = New System.Drawing.Point(100, 75)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNome.Size = New System.Drawing.Size(450, 17)
        Me.lblNome.StylePriority.UseTextAlignment = False
        Me.lblNome.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel13.Location = New System.Drawing.Point(567, 75)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.Size = New System.Drawing.Size(75, 17)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "Telefone:"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblTel1
        '
        Me.lblTel1.Location = New System.Drawing.Point(650, 75)
        Me.lblTel1.Name = "lblTel1"
        Me.lblTel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTel1.Size = New System.Drawing.Size(108, 17)
        Me.lblTel1.StylePriority.UseTextAlignment = False
        Me.lblTel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.Location = New System.Drawing.Point(567, 92)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.Size = New System.Drawing.Size(75, 17)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Celular:"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblTel2
        '
        Me.lblTel2.Location = New System.Drawing.Point(650, 92)
        Me.lblTel2.Name = "lblTel2"
        Me.lblTel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTel2.Size = New System.Drawing.Size(108, 17)
        Me.lblTel2.StylePriority.UseTextAlignment = False
        Me.lblTel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblData
        '
        Me.lblData.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.lblData.Location = New System.Drawing.Point(650, 8)
        Me.lblData.Name = "lblData"
        Me.lblData.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblData.Size = New System.Drawing.Size(108, 17)
        Me.lblData.StylePriority.UseFont = False
        Me.lblData.StylePriority.UseTextAlignment = False
        Me.lblData.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.Location = New System.Drawing.Point(592, 8)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.Size = New System.Drawing.Size(50, 17)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Data:"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblPed
        '
        Me.lblPed.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.lblPed.Location = New System.Drawing.Point(100, 8)
        Me.lblPed.Name = "lblPed"
        Me.lblPed.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPed.Size = New System.Drawing.Size(117, 17)
        Me.lblPed.StylePriority.UseFont = False
        Me.lblPed.StylePriority.UseTextAlignment = False
        Me.lblPed.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblNomePed
        '
        Me.lblNomePed.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblNomePed.Location = New System.Drawing.Point(0, 8)
        Me.lblNomePed.Name = "lblNomePed"
        Me.lblNomePed.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNomePed.Size = New System.Drawing.Size(92, 17)
        Me.lblNomePed.StylePriority.UseFont = False
        Me.lblNomePed.StylePriority.UseTextAlignment = False
        Me.lblNomePed.Text = "N° Pedido:"
        Me.lblNomePed.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.Location = New System.Drawing.Point(0, 42)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.Size = New System.Drawing.Size(142, 17)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Dados do Cliente"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'WinControlContainer2
        '
        Me.WinControlContainer2.Location = New System.Drawing.Point(0, 33)
        Me.WinControlContainer2.Name = "WinControlContainer2"
        Me.WinControlContainer2.Size = New System.Drawing.Size(758, 58)
        Me.WinControlContainer2.WinControl = Me.GridControl2
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "tbServico"
        Me.GridControl2.DataSource = Me.dsConsig
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit3})
        Me.GridControl2.Size = New System.Drawing.Size(728, 56)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'dsConsig
        '
        Me.dsConsig.DataSetName = "NewDataSet"
        Me.dsConsig.Tables.AddRange(New System.Data.DataTable() {Me.tbConsig, Me.tbServico})
        '
        'tbServico
        '
        Me.tbServico.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn18})
        Me.tbServico.TableName = "tbServico"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Produto"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Tamanho"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Qtd"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "ValorUnitario"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "ValorTotal"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "Codigo"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "UniSemDesc"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "UM"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "Locacao"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProduto1, Me.colTamanho1, Me.colQtd1, Me.colValorUnitario1, Me.colValorTotal1, Me.colCodigo1, Me.colUniSemDesc1, Me.colUM1, Me.colLocacao1})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colProduto1
        '
        Me.colProduto1.AppearanceCell.Options.UseTextOptions = True
        Me.colProduto1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colProduto1.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colProduto1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colProduto1.AppearanceHeader.Options.UseBackColor = True
        Me.colProduto1.AppearanceHeader.Options.UseFont = True
        Me.colProduto1.Caption = "Produto"
        Me.colProduto1.ColumnEdit = Me.RepositoryItemMemoEdit3
        Me.colProduto1.FieldName = "Produto"
        Me.colProduto1.Name = "colProduto1"
        Me.colProduto1.OptionsColumn.FixedWidth = True
        Me.colProduto1.Visible = True
        Me.colProduto1.VisibleIndex = 1
        Me.colProduto1.Width = 200
        '
        'RepositoryItemMemoEdit3
        '
        Me.RepositoryItemMemoEdit3.Name = "RepositoryItemMemoEdit3"
        '
        'colTamanho1
        '
        Me.colTamanho1.AppearanceCell.Options.UseTextOptions = True
        Me.colTamanho1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTamanho1.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colTamanho1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTamanho1.AppearanceHeader.Options.UseBackColor = True
        Me.colTamanho1.AppearanceHeader.Options.UseFont = True
        Me.colTamanho1.Caption = "Tam."
        Me.colTamanho1.FieldName = "Tamanho"
        Me.colTamanho1.Name = "colTamanho1"
        Me.colTamanho1.Visible = True
        Me.colTamanho1.VisibleIndex = 3
        Me.colTamanho1.Width = 40
        '
        'colQtd1
        '
        Me.colQtd1.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtd1.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colQtd1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colQtd1.AppearanceHeader.Options.UseBackColor = True
        Me.colQtd1.AppearanceHeader.Options.UseFont = True
        Me.colQtd1.Caption = "Qtd"
        Me.colQtd1.FieldName = "Qtd"
        Me.colQtd1.Name = "colQtd1"
        Me.colQtd1.Visible = True
        Me.colQtd1.VisibleIndex = 4
        Me.colQtd1.Width = 71
        '
        'colValorUnitario1
        '
        Me.colValorUnitario1.AppearanceCell.Options.UseTextOptions = True
        Me.colValorUnitario1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorUnitario1.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValorUnitario1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValorUnitario1.AppearanceHeader.Options.UseBackColor = True
        Me.colValorUnitario1.AppearanceHeader.Options.UseFont = True
        Me.colValorUnitario1.Caption = "Valor Unit. R$"
        Me.colValorUnitario1.FieldName = "ValorUnitario"
        Me.colValorUnitario1.Name = "colValorUnitario1"
        Me.colValorUnitario1.OptionsColumn.FixedWidth = True
        Me.colValorUnitario1.Visible = True
        Me.colValorUnitario1.VisibleIndex = 6
        Me.colValorUnitario1.Width = 99
        '
        'colValorTotal1
        '
        Me.colValorTotal1.AppearanceCell.Options.UseTextOptions = True
        Me.colValorTotal1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorTotal1.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValorTotal1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValorTotal1.AppearanceHeader.Options.UseBackColor = True
        Me.colValorTotal1.AppearanceHeader.Options.UseFont = True
        Me.colValorTotal1.Caption = "Valor Total R$"
        Me.colValorTotal1.FieldName = "ValorTotal"
        Me.colValorTotal1.Name = "colValorTotal1"
        Me.colValorTotal1.OptionsColumn.FixedWidth = True
        Me.colValorTotal1.Visible = True
        Me.colValorTotal1.VisibleIndex = 7
        Me.colValorTotal1.Width = 99
        '
        'colCodigo1
        '
        Me.colCodigo1.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigo1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigo1.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodigo1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigo1.AppearanceHeader.Options.UseBackColor = True
        Me.colCodigo1.AppearanceHeader.Options.UseFont = True
        Me.colCodigo1.Caption = "Código"
        Me.colCodigo1.FieldName = "Codigo"
        Me.colCodigo1.Name = "colCodigo1"
        Me.colCodigo1.OptionsColumn.FixedWidth = True
        Me.colCodigo1.Visible = True
        Me.colCodigo1.VisibleIndex = 0
        Me.colCodigo1.Width = 60
        '
        'colUniSemDesc1
        '
        Me.colUniSemDesc1.AppearanceCell.Options.UseTextOptions = True
        Me.colUniSemDesc1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colUniSemDesc1.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colUniSemDesc1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUniSemDesc1.AppearanceHeader.Options.UseBackColor = True
        Me.colUniSemDesc1.AppearanceHeader.Options.UseFont = True
        Me.colUniSemDesc1.Caption = "Sem Desc. R$"
        Me.colUniSemDesc1.FieldName = "UniSemDesc"
        Me.colUniSemDesc1.Name = "colUniSemDesc1"
        Me.colUniSemDesc1.OptionsColumn.FixedWidth = True
        Me.colUniSemDesc1.Visible = True
        Me.colUniSemDesc1.VisibleIndex = 5
        Me.colUniSemDesc1.Width = 99
        '
        'colUM1
        '
        Me.colUM1.AppearanceCell.Options.UseTextOptions = True
        Me.colUM1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUM1.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colUM1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUM1.AppearanceHeader.Options.UseBackColor = True
        Me.colUM1.AppearanceHeader.Options.UseFont = True
        Me.colUM1.Caption = "UM"
        Me.colUM1.FieldName = "UM"
        Me.colUM1.Name = "colUM1"
        Me.colUM1.Visible = True
        Me.colUM1.VisibleIndex = 2
        Me.colUM1.Width = 44
        '
        'colLocacao1
        '
        Me.colLocacao1.AppearanceCell.Options.UseTextOptions = True
        Me.colLocacao1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLocacao1.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colLocacao1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colLocacao1.AppearanceHeader.Options.UseBackColor = True
        Me.colLocacao1.AppearanceHeader.Options.UseFont = True
        Me.colLocacao1.Caption = "Locação"
        Me.colLocacao1.FieldName = "Locacao"
        Me.colLocacao1.Name = "colLocacao1"
        Me.colLocacao1.Width = 70
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.lblFones, Me.lblEndereco, Me.lblTitulo, Me.XrLine3, Me.picLogo})
        Me.PageHeader.Height = 110
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine2
        '
        Me.XrLine2.LineWidth = 2
        Me.XrLine2.Location = New System.Drawing.Point(0, 100)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(758, 10)
        '
        'lblFones
        '
        Me.lblFones.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFones.Location = New System.Drawing.Point(167, 67)
        Me.lblFones.Name = "lblFones"
        Me.lblFones.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblFones.Size = New System.Drawing.Size(592, 16)
        Me.lblFones.StylePriority.UseFont = False
        Me.lblFones.StylePriority.UseTextAlignment = False
        Me.lblFones.Text = "lblFones"
        Me.lblFones.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblEndereco
        '
        Me.lblEndereco.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblEndereco.Location = New System.Drawing.Point(167, 50)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblEndereco.Size = New System.Drawing.Size(592, 16)
        Me.lblEndereco.StylePriority.UseFont = False
        Me.lblEndereco.StylePriority.UseTextAlignment = False
        Me.lblEndereco.Text = "lblEndereco"
        Me.lblEndereco.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Location = New System.Drawing.Point(167, 25)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitulo.Size = New System.Drawing.Size(592, 25)
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
        Me.XrLine3.Size = New System.Drawing.Size(758, 8)
        '
        'picLogo
        '
        Me.picLogo.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(0, 17)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(150, 75)
        Me.picLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'PageFooter
        '
        Me.PageFooter.Height = 30
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrRichText1, Me.rtbConfigObs, Me.XrLine8, Me.txtTexto2, Me.XrLabel7, Me.XrLabel6, Me.txtTexto, Me.XrLine7, Me.XrLabel1, Me.lblAutorizacao, Me.lblAtivo, Me.linhaAtivo, Me.tabAtivo, Me.rtbObs, Me.XrLabel2, Me.XrLine5, Me.XrTable1})
        Me.GroupFooter2.Height = 344
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'rtbConfigObs
        '
        Me.rtbConfigObs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbConfigObs.Location = New System.Drawing.Point(0, 283)
        Me.rtbConfigObs.Name = "rtbConfigObs"
        Me.rtbConfigObs.SerializableRtfString = resources.GetString("rtbConfigObs.SerializableRtfString")
        Me.rtbConfigObs.Size = New System.Drawing.Size(758, 25)
        Me.rtbConfigObs.StylePriority.UseFont = False
        '
        'XrLine8
        '
        Me.XrLine8.Location = New System.Drawing.Point(8, 150)
        Me.XrLine8.Name = "XrLine8"
        Me.XrLine8.Size = New System.Drawing.Size(335, 8)
        Me.XrLine8.Visible = False
        '
        'txtTexto2
        '
        Me.txtTexto2.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTexto2.Location = New System.Drawing.Point(8, 175)
        Me.txtTexto2.Name = "txtTexto2"
        Me.txtTexto2.SerializableRtfString = resources.GetString("txtTexto2.SerializableRtfString")
        Me.txtTexto2.Size = New System.Drawing.Size(350, 25)
        Me.txtTexto2.StylePriority.UseFont = False
        Me.txtTexto2.Visible = False
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.Location = New System.Drawing.Point(8, 158)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.Size = New System.Drawing.Size(350, 17)
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Parcela        Valor Parc. R$          Vencimento              Pago"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel7.Visible = False
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.Location = New System.Drawing.Point(8, 133)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.Size = New System.Drawing.Size(167, 17)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Pagamento a Prazo"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel6.Visible = False
        '
        'txtTexto
        '
        Me.txtTexto.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTexto.Location = New System.Drawing.Point(8, 100)
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.SerializableRtfString = resources.GetString("txtTexto.SerializableRtfString")
        Me.txtTexto.Size = New System.Drawing.Size(333, 25)
        Me.txtTexto.StylePriority.UseFont = False
        Me.txtTexto.Visible = False
        '
        'XrLine7
        '
        Me.XrLine7.Location = New System.Drawing.Point(8, 92)
        Me.XrLine7.Name = "XrLine7"
        Me.XrLine7.Size = New System.Drawing.Size(250, 8)
        Me.XrLine7.Visible = False
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.Location = New System.Drawing.Point(8, 75)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(167, 17)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Forma de Pagamento"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel1.Visible = False
        '
        'lblAutorizacao
        '
        Me.lblAutorizacao.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lblAutorizacao.Location = New System.Drawing.Point(442, 258)
        Me.lblAutorizacao.Name = "lblAutorizacao"
        Me.lblAutorizacao.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblAutorizacao.Size = New System.Drawing.Size(317, 17)
        Me.lblAutorizacao.StylePriority.UseBorders = False
        Me.lblAutorizacao.StylePriority.UseTextAlignment = False
        Me.lblAutorizacao.Text = "lblAutorizacao"
        Me.lblAutorizacao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'lblAtivo
        '
        Me.lblAtivo.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblAtivo.Location = New System.Drawing.Point(0, 200)
        Me.lblAtivo.Name = "lblAtivo"
        Me.lblAtivo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblAtivo.Size = New System.Drawing.Size(100, 17)
        Me.lblAtivo.StylePriority.UseFont = False
        Me.lblAtivo.StylePriority.UseTextAlignment = False
        Me.lblAtivo.Text = "Ativos"
        Me.lblAtivo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'linhaAtivo
        '
        Me.linhaAtivo.LineWidth = 2
        Me.linhaAtivo.Location = New System.Drawing.Point(0, 217)
        Me.linhaAtivo.Name = "linhaAtivo"
        Me.linhaAtivo.Size = New System.Drawing.Size(758, 10)
        '
        'tabAtivo
        '
        Me.tabAtivo.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.tabAtivo.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.tabAtivo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tabAtivo.Location = New System.Drawing.Point(0, 225)
        Me.tabAtivo.Name = "tabAtivo"
        Me.tabAtivo.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.tabAtivo.Size = New System.Drawing.Size(767, 23)
        Me.tabAtivo.StylePriority.UseBorderColor = False
        Me.tabAtivo.StylePriority.UseBorders = False
        Me.tabAtivo.StylePriority.UseFont = False
        Me.tabAtivo.StylePriority.UseTextAlignment = False
        Me.tabAtivo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell6, Me.XrTableCell2, Me.XrTableCell4, Me.XrTableCell5})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Size = New System.Drawing.Size(767, 23)
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell6.Size = New System.Drawing.Size(126, 23)
        Me.XrTableCell6.Text = "Cód. Barra"
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Location = New System.Drawing.Point(126, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell2.Size = New System.Drawing.Size(257, 23)
        Me.XrTableCell2.Text = "Descrição"
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Location = New System.Drawing.Point(383, 0)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell4.Size = New System.Drawing.Size(233, 23)
        Me.XrTableCell4.Text = "Produto"
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Location = New System.Drawing.Point(616, 0)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell5.Size = New System.Drawing.Size(151, 23)
        Me.XrTableCell5.Text = "Vencimento"
        '
        'rtbObs
        '
        Me.rtbObs.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbObs.Location = New System.Drawing.Point(0, 33)
        Me.rtbObs.Name = "rtbObs"
        Me.rtbObs.SerializableRtfString = resources.GetString("rtbObs.SerializableRtfString")
        Me.rtbObs.Size = New System.Drawing.Size(758, 33)
        Me.rtbObs.StylePriority.UseFont = False
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.Location = New System.Drawing.Point(0, 8)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.Size = New System.Drawing.Size(250, 17)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Observações"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine5
        '
        Me.XrLine5.LineWidth = 2
        Me.XrLine5.Location = New System.Drawing.Point(0, 25)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.Size = New System.Drawing.Size(758, 8)
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Location = New System.Drawing.Point(558, 83)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1, Me.XrTableRow5, Me.XrTableRow4, Me.XrTableRow2, Me.XrTableRow6, Me.XrTableRow7})
        Me.XrTable1.Size = New System.Drawing.Size(208, 102)
        Me.XrTable1.StylePriority.UseBorders = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(208, 17)
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell1.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell1.Size = New System.Drawing.Size(208, 17)
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "Totais"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell9, Me.tblQtd})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Size = New System.Drawing.Size(208, 17)
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell9.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell9.Size = New System.Drawing.Size(104, 17)
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "Qtd Itens"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'tblQtd
        '
        Me.tblQtd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tblQtd.Location = New System.Drawing.Point(104, 0)
        Me.tblQtd.Name = "tblQtd"
        Me.tblQtd.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.tblQtd.Size = New System.Drawing.Size(104, 17)
        Me.tblQtd.StylePriority.UseFont = False
        Me.tblQtd.StylePriority.UseTextAlignment = False
        Me.tblQtd.Text = "tblQtd"
        Me.tblQtd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.tblDesc})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Size = New System.Drawing.Size(208, 17)
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell7.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell7.Size = New System.Drawing.Size(104, 17)
        Me.XrTableCell7.StylePriority.UseFont = False
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        Me.XrTableCell7.Text = "Desconto R$"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'tblDesc
        '
        Me.tblDesc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tblDesc.Location = New System.Drawing.Point(104, 0)
        Me.tblDesc.Name = "tblDesc"
        Me.tblDesc.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.tblDesc.Size = New System.Drawing.Size(104, 17)
        Me.tblDesc.StylePriority.UseFont = False
        Me.tblDesc.StylePriority.UseTextAlignment = False
        Me.tblDesc.Text = "tblDesc"
        Me.tblDesc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell3, Me.tblTotal})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Size = New System.Drawing.Size(208, 17)
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell3.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell3.Size = New System.Drawing.Size(104, 17)
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "Total R$"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'tblTotal
        '
        Me.tblTotal.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tblTotal.Location = New System.Drawing.Point(104, 0)
        Me.tblTotal.Name = "tblTotal"
        Me.tblTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.tblTotal.Size = New System.Drawing.Size(104, 17)
        Me.tblTotal.StylePriority.UseFont = False
        Me.tblTotal.StylePriority.UseTextAlignment = False
        Me.tblTotal.Text = "tblTotal"
        Me.tblTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell8, Me.tblTotalprod})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Size = New System.Drawing.Size(208, 17)
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell8.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell8.Size = New System.Drawing.Size(104, 17)
        Me.XrTableCell8.StylePriority.UseFont = False
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        Me.XrTableCell8.Text = "Produto R$"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell8.Visible = False
        '
        'tblTotalprod
        '
        Me.tblTotalprod.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblTotalprod.Location = New System.Drawing.Point(104, 0)
        Me.tblTotalprod.Name = "tblTotalprod"
        Me.tblTotalprod.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.tblTotalprod.Size = New System.Drawing.Size(104, 17)
        Me.tblTotalprod.StylePriority.UseFont = False
        Me.tblTotalprod.StylePriority.UseTextAlignment = False
        Me.tblTotalprod.Text = "tblTotalprod"
        Me.tblTotalprod.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tblTotalprod.Visible = False
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell11, Me.tblTotalserv})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Size = New System.Drawing.Size(208, 17)
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell11.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell11.Size = New System.Drawing.Size(104, 17)
        Me.XrTableCell11.StylePriority.UseFont = False
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.Text = "Serviço R$"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell11.Visible = False
        '
        'tblTotalserv
        '
        Me.tblTotalserv.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblTotalserv.Location = New System.Drawing.Point(104, 0)
        Me.tblTotalserv.Name = "tblTotalserv"
        Me.tblTotalserv.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.tblTotalserv.Size = New System.Drawing.Size(104, 17)
        Me.tblTotalserv.StylePriority.UseFont = False
        Me.tblTotalserv.StylePriority.UseTextAlignment = False
        Me.tblTotalserv.Text = "tblTotalserv"
        Me.tblTotalserv.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tblTotalserv.Visible = False
        '
        'XrLine6
        '
        Me.XrLine6.LineWidth = 2
        Me.XrLine6.Location = New System.Drawing.Point(0, 25)
        Me.XrLine6.Name = "XrLine6"
        Me.XrLine6.Size = New System.Drawing.Size(758, 10)
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.Location = New System.Drawing.Point(0, 8)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.Size = New System.Drawing.Size(100, 17)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Serviços"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1})
        Me.DetailReport.Name = "DetailReport"
        Me.DetailReport.Visible = False
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine6, Me.WinControlContainer2, Me.XrLabel5})
        Me.Detail1.Height = 95
        Me.Detail1.Name = "Detail1"
        '
        'XrRichText1
        '
        Me.XrRichText1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrRichText1.Location = New System.Drawing.Point(0, 317)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.Size = New System.Drawing.Size(758, 25)
        Me.XrRichText1.StylePriority.UseFont = False
        '
        'relPed
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.GroupFooter2, Me.DetailReport})
        Me.Margins = New System.Drawing.Printing.Margins(30, 30, 30, 30)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ShowPreviewMarginLines = False
        Me.Version = "8.2"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbConsig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsConsig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbServico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rtbConfigObs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTexto2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTexto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabAtivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rtbObs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lblFones As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblEndereco As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents picLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblWeb As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblNome As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblData As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblPed As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblNomePed As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents WinControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents tbConsig As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTamanho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dsConsig As System.Data.DataSet
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents colUniSemDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents colUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WinControlContainer2 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tbServico As System.Data.DataTable
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents colProduto1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTamanho1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorUnitario1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorTotal1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUniSemDesc1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUM1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine6 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lblAutorizacao As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblAtivo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents linhaAtivo As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents tabAtivo As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents rtbConfigObs As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents rtbObs As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tblQtd As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tblDesc As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tblTotal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tblTotalprod As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tblTotalserv As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblVend As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTexto As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrLine7 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTexto2 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine8 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colLocacao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents colLocacao1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents colEstoque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblStatus As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents RepositoryItemMemoEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents lblNumVenda As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblNVenda As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrRichText1 As DevExpress.XtraReports.UI.XRRichText
End Class
