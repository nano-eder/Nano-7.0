<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relImpPedidos2Paisagem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(relImpPedidos2Paisagem))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.WinControlContainer2 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsPed = New System.Data.DataSet
        Me.tbPed = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.tbServ = New System.Data.DataTable
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCampoPedidoServ = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVlUnit2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colvlTot2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFuncionario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFornecedor2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.c2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Sevicos = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel
        Me.c1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Pecas = New DevExpress.XtraReports.UI.XRTableCell
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.PedidoGridControl = New DevExpress.XtraGrid.GridControl
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCod = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPlaca = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCPF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCampoPedido = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorUnitario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRealizado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFunc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLocacao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFornecedor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.lblEndereco = New DevExpress.XtraReports.UI.XRLabel
        Me.lblFones = New DevExpress.XtraReports.UI.XRLabel
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.lblPed = New DevExpress.XtraReports.UI.XRLabel
        Me.lblPedido = New DevExpress.XtraReports.UI.XRLabel
        Me.lblData = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.lblDescricaoPedido = New DevExpress.XtraReports.UI.XRRichText
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblKMSaida = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblChassi = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblSaida = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblEntrada = New DevExpress.XtraReports.UI.XRLabel
        Me.KM = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel
        Me.Cor = New DevExpress.XtraReports.UI.XRLabel
        Me.Placa = New DevExpress.XtraReports.UI.XRLabel
        Me.Modelo = New DevExpress.XtraReports.UI.XRLabel
        Me.Ano = New DevExpress.XtraReports.UI.XRLabel
        Me.Fax = New DevExpress.XtraReports.UI.XRLabel
        Me.Telefone = New DevExpress.XtraReports.UI.XRLabel
        Me.Email = New DevExpress.XtraReports.UI.XRLabel
        Me.Nome = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.lblVendedor = New DevExpress.XtraReports.UI.XRRichText
        Me.lblLabelVendedor = New DevExpress.XtraReports.UI.XRLabel
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.lblFrete = New DevExpress.XtraReports.UI.XRTableCell
        Me.lblDefeitos = New DevExpress.XtraReports.UI.XRRichText
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblDesc = New DevExpress.XtraReports.UI.XRRichText
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.c6 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Troco = New DevExpress.XtraReports.UI.XRTableCell
        Me.c7 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Recebido = New DevExpress.XtraReports.UI.XRTableCell
        Me.c5 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.subTotal = New DevExpress.XtraReports.UI.XRTableCell
        Me.c3 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Total = New DevExpress.XtraReports.UI.XRTableCell
        Me.lblRec = New DevExpress.XtraReports.UI.XRLabel
        Me.c4 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Desconto = New DevExpress.XtraReports.UI.XRTableCell
        Me.lblGar = New DevExpress.XtraReports.UI.XRRichText
        Me.lblGarantias = New DevExpress.XtraReports.UI.XRLabel
        Me.lblAssi = New DevExpress.XtraReports.UI.XRLabel
        Me.lblAut = New DevExpress.XtraReports.UI.XRLabel
        Me.linha7 = New DevExpress.XtraReports.UI.XRLine
        Me.GroupFooter3 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.GroupFooter4 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.colCódigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colServiços = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtde = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVlUnit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colvlTot = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUMSER = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFuncServ = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLocacaoServ = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel55 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblComplemento = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel53 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel52 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel51 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel50 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel49 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel48 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel47 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel46 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel44 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblBairro = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel42 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblSaida2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblEntrada2 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblUF = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblNum = New DevExpress.XtraReports.UI.XRLabel
        Me.lblEnd = New DevExpress.XtraReports.UI.XRLabel
        Me.lblCidade = New DevExpress.XtraReports.UI.XRLabel
        Me.lblCep = New DevExpress.XtraReports.UI.XRLabel
        Me.lblFax = New DevExpress.XtraReports.UI.XRLabel
        Me.lblTelefone = New DevExpress.XtraReports.UI.XRLabel
        Me.lblEmail = New DevExpress.XtraReports.UI.XRLabel
        Me.lblNome = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblCPF = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsPed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbPed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbServ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDescricaoPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDefeitos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblGar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.WinControlContainer2, Me.c2, Me.XrLabel19, Me.c1, Me.WinControlContainer1})
        Me.Detail.Height = 215
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UseTextAlignment = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'WinControlContainer2
        '
        Me.WinControlContainer2.Location = New System.Drawing.Point(0, 117)
        Me.WinControlContainer2.Name = "WinControlContainer2"
        Me.WinControlContainer2.Size = New System.Drawing.Size(1108, 75)
        Me.WinControlContainer2.WinControl = Me.GridControl1
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbServ"
        Me.GridControl1.DataSource = Me.dsPed
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(1064, 72)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'dsPed
        '
        Me.dsPed.DataSetName = "dsPed"
        Me.dsPed.Tables.AddRange(New System.Data.DataTable() {Me.tbPed, Me.tbServ})
        '
        'tbPed
        '
        Me.tbPed.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn11, Me.DataColumn13, Me.DataColumn15, Me.DataColumn16, Me.DataColumn18, Me.DataColumn20})
        Me.tbPed.TableName = "tbPed"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Qtde"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Produto"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Descrição"
        '
        'DataColumn4
        '
        Me.DataColumn4.Caption = "Valor Unit. R$"
        Me.DataColumn4.ColumnName = "ValorUnitR"
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "Total R$"
        Me.DataColumn5.ColumnName = "Total"
        '
        'DataColumn11
        '
        Me.DataColumn11.Caption = "UM"
        Me.DataColumn11.ColumnName = "UM"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "Func"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "CodigoPeca"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "Locacao"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "CampoPedido"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "Fornecedor"
        '
        'tbServ
        '
        Me.tbServ.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn12, Me.DataColumn14, Me.DataColumn17, Me.DataColumn19, Me.DataColumn21})
        Me.tbServ.TableName = "tbServ"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Código"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Serviços"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Qtde"
        '
        'DataColumn9
        '
        Me.DataColumn9.Caption = "Valor Unit. R$"
        Me.DataColumn9.ColumnName = "VlUnit"
        '
        'DataColumn10
        '
        Me.DataColumn10.Caption = "Valor Total R$"
        Me.DataColumn10.ColumnName = "vlTot"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "UMSER"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "FUNC"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "Locacao"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "CampoPedido"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "Fornecedor"
        '
        'GridView1
        '
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.Options.UseTextOptions = True
        Me.GridView1.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.GridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FixedLine.BorderColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView1.Appearance.FixedLine.Options.UseBorderColor = True
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.White
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.Options.UseTextOptions = True
        Me.GridView1.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseTextOptions = True
        Me.GridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.White
        Me.GridView1.AppearancePrint.EvenRow.Options.UseBackColor = True
        Me.GridView1.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.GridView1.AppearancePrint.HeaderPanel.BorderColor = System.Drawing.Color.White
        Me.GridView1.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.AppearancePrint.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.AppearancePrint.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.AppearancePrint.HeaderPanel.Options.UseBorderColor = True
        Me.GridView1.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.GridView1.AppearancePrint.HeaderPanel.Options.UseForeColor = True
        Me.GridView1.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridView1.AppearancePrint.OddRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GridView1.AppearancePrint.OddRow.Options.UseBackColor = True
        Me.GridView1.AppearancePrint.Preview.BackColor = System.Drawing.Color.White
        Me.GridView1.AppearancePrint.Preview.BorderColor = System.Drawing.Color.Black
        Me.GridView1.AppearancePrint.Preview.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.GridView1.AppearancePrint.Preview.ForeColor = System.Drawing.Color.Black
        Me.GridView1.AppearancePrint.Preview.Options.UseBackColor = True
        Me.GridView1.AppearancePrint.Preview.Options.UseBorderColor = True
        Me.GridView1.AppearancePrint.Preview.Options.UseFont = True
        Me.GridView1.AppearancePrint.Preview.Options.UseForeColor = True
        Me.GridView1.AppearancePrint.Preview.Options.UseTextOptions = True
        Me.GridView1.AppearancePrint.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.GridView1.AppearancePrint.Row.BackColor = System.Drawing.Color.White
        Me.GridView1.AppearancePrint.Row.BorderColor = System.Drawing.Color.Black
        Me.GridView1.AppearancePrint.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.GridView1.AppearancePrint.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView1.AppearancePrint.Row.Options.UseBackColor = True
        Me.GridView1.AppearancePrint.Row.Options.UseBorderColor = True
        Me.GridView1.AppearancePrint.Row.Options.UseFont = True
        Me.GridView1.AppearancePrint.Row.Options.UseForeColor = True
        Me.GridView1.AppearancePrint.Row.Options.UseTextOptions = True
        Me.GridView1.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.GridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.colCampoPedidoServ, Me.GridColumn3, Me.colVlUnit2, Me.colvlTot2, Me.GridColumn6, Me.colFuncionario, Me.GridColumn7, Me.colFornecedor2})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsPrint.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsPrint.EnableAppearanceOddRow = True
        Me.GridView1.OptionsPrint.PrintHorzLines = False
        Me.GridView1.OptionsPrint.PrintVertLines = False
        Me.GridView1.OptionsPrint.UsePrintStyles = True
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowHorzLines = False
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.OptionsView.ShowPreviewLines = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.GridColumn1.AppearanceCell.Options.UseFont = True
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.GridColumn1.AppearanceHeader.BorderColor = System.Drawing.Color.White
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn1.AppearanceHeader.Options.UseBackColor = True
        Me.GridColumn1.AppearanceHeader.Options.UseBorderColor = True
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn1.Caption = "   Código"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.GridColumn1.FieldName = "Código"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 120
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.GridColumn2.AppearanceCell.Options.UseFont = True
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn2.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.GridColumn2.AppearanceHeader.BorderColor = System.Drawing.Color.White
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn2.AppearanceHeader.Options.UseBackColor = True
        Me.GridColumn2.AppearanceHeader.Options.UseBorderColor = True
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn2.Caption = "  Serviços"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.GridColumn2.FieldName = "Serviços"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 318
        '
        'colCampoPedidoServ
        '
        Me.colCampoPedidoServ.AppearanceCell.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.colCampoPedidoServ.AppearanceCell.Options.UseFont = True
        Me.colCampoPedidoServ.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCampoPedidoServ.AppearanceHeader.BorderColor = System.Drawing.Color.White
        Me.colCampoPedidoServ.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCampoPedidoServ.AppearanceHeader.Options.UseBackColor = True
        Me.colCampoPedidoServ.AppearanceHeader.Options.UseBorderColor = True
        Me.colCampoPedidoServ.AppearanceHeader.Options.UseFont = True
        Me.colCampoPedidoServ.AppearanceHeader.Options.UseTextOptions = True
        Me.colCampoPedidoServ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colCampoPedidoServ.Caption = "  CampoPedido"
        Me.colCampoPedidoServ.FieldName = "CampoPedido"
        Me.colCampoPedidoServ.Name = "colCampoPedidoServ"
        Me.colCampoPedidoServ.Visible = True
        Me.colCampoPedidoServ.VisibleIndex = 3
        Me.colCampoPedidoServ.Width = 171
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.GridColumn3.AppearanceCell.Options.UseFont = True
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn3.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.GridColumn3.AppearanceHeader.BorderColor = System.Drawing.Color.White
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn3.AppearanceHeader.Options.UseBackColor = True
        Me.GridColumn3.AppearanceHeader.Options.UseBorderColor = True
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn3.Caption = "  Qtde"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.GridColumn3.FieldName = "Qtde"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 5
        Me.GridColumn3.Width = 111
        '
        'colVlUnit2
        '
        Me.colVlUnit2.AppearanceCell.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.colVlUnit2.AppearanceCell.Options.UseFont = True
        Me.colVlUnit2.AppearanceCell.Options.UseTextOptions = True
        Me.colVlUnit2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colVlUnit2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colVlUnit2.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colVlUnit2.AppearanceHeader.BorderColor = System.Drawing.Color.White
        Me.colVlUnit2.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVlUnit2.AppearanceHeader.Options.UseBackColor = True
        Me.colVlUnit2.AppearanceHeader.Options.UseBorderColor = True
        Me.colVlUnit2.AppearanceHeader.Options.UseFont = True
        Me.colVlUnit2.AppearanceHeader.Options.UseTextOptions = True
        Me.colVlUnit2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colVlUnit2.Caption = "  Vlr Unit. R$"
        Me.colVlUnit2.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colVlUnit2.FieldName = "VlUnit"
        Me.colVlUnit2.Name = "colVlUnit2"
        Me.colVlUnit2.Visible = True
        Me.colVlUnit2.VisibleIndex = 6
        Me.colVlUnit2.Width = 139
        '
        'colvlTot2
        '
        Me.colvlTot2.AppearanceCell.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.colvlTot2.AppearanceCell.Options.UseFont = True
        Me.colvlTot2.AppearanceCell.Options.UseTextOptions = True
        Me.colvlTot2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colvlTot2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colvlTot2.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colvlTot2.AppearanceHeader.BorderColor = System.Drawing.Color.White
        Me.colvlTot2.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colvlTot2.AppearanceHeader.Options.UseBackColor = True
        Me.colvlTot2.AppearanceHeader.Options.UseBorderColor = True
        Me.colvlTot2.AppearanceHeader.Options.UseFont = True
        Me.colvlTot2.AppearanceHeader.Options.UseTextOptions = True
        Me.colvlTot2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colvlTot2.Caption = "  Vlr Total R$"
        Me.colvlTot2.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colvlTot2.FieldName = "vlTot"
        Me.colvlTot2.Name = "colvlTot2"
        Me.colvlTot2.Visible = True
        Me.colvlTot2.VisibleIndex = 7
        Me.colvlTot2.Width = 140
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.GridColumn6.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.GridColumn6.AppearanceCell.Options.UseFont = True
        Me.GridColumn6.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn6.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.GridColumn6.AppearanceHeader.BorderColor = System.Drawing.Color.White
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn6.AppearanceHeader.Options.UseBackColor = True
        Me.GridColumn6.AppearanceHeader.Options.UseBorderColor = True
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn6.Caption = "U.M."
        Me.GridColumn6.FieldName = "UMSER"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        Me.GridColumn6.Width = 73
        '
        'colFuncionario
        '
        Me.colFuncionario.AppearanceCell.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.colFuncionario.AppearanceCell.Options.UseFont = True
        Me.colFuncionario.AppearanceCell.Options.UseTextOptions = True
        Me.colFuncionario.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colFuncionario.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colFuncionario.AppearanceHeader.BorderColor = System.Drawing.Color.White
        Me.colFuncionario.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFuncionario.AppearanceHeader.Options.UseBackColor = True
        Me.colFuncionario.AppearanceHeader.Options.UseBorderColor = True
        Me.colFuncionario.AppearanceHeader.Options.UseFont = True
        Me.colFuncionario.AppearanceHeader.Options.UseTextOptions = True
        Me.colFuncionario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colFuncionario.Caption = "  Func."
        Me.colFuncionario.FieldName = "FUNC"
        Me.colFuncionario.Name = "colFuncionario"
        Me.colFuncionario.Width = 149
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.GridColumn7.AppearanceCell.Options.UseFont = True
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn7.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.GridColumn7.AppearanceHeader.BorderColor = System.Drawing.Color.White
        Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn7.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn7.AppearanceHeader.Options.UseBackColor = True
        Me.GridColumn7.AppearanceHeader.Options.UseBorderColor = True
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn7.Caption = "Loc."
        Me.GridColumn7.FieldName = "Locacao"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'colFornecedor2
        '
        Me.colFornecedor2.AppearanceCell.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.colFornecedor2.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colFornecedor2.AppearanceCell.Options.UseFont = True
        Me.colFornecedor2.AppearanceCell.Options.UseForeColor = True
        Me.colFornecedor2.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colFornecedor2.AppearanceHeader.BorderColor = System.Drawing.Color.White
        Me.colFornecedor2.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFornecedor2.AppearanceHeader.Options.UseBackColor = True
        Me.colFornecedor2.AppearanceHeader.Options.UseBorderColor = True
        Me.colFornecedor2.AppearanceHeader.Options.UseFont = True
        Me.colFornecedor2.AppearanceHeader.Options.UseTextOptions = True
        Me.colFornecedor2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colFornecedor2.Caption = "  Fornecedor"
        Me.colFornecedor2.FieldName = "Fornecedor"
        Me.colFornecedor2.Name = "colFornecedor2"
        Me.colFornecedor2.Visible = True
        Me.colFornecedor2.VisibleIndex = 2
        Me.colFornecedor2.Width = 123
        '
        'c2
        '
        Me.c2.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.c2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c2.Location = New System.Drawing.Point(958, 194)
        Me.c2.Name = "c2"
        Me.c2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.c2.Size = New System.Drawing.Size(150, 15)
        Me.c2.StylePriority.UseBorders = False
        Me.c2.StylePriority.UseFont = False
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.Sevicos})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Size = New System.Drawing.Size(150, 15)
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell2.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell2.Size = New System.Drawing.Size(75, 15)
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.Text = "Total R$"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Sevicos
        '
        Me.Sevicos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sevicos.Location = New System.Drawing.Point(75, 0)
        Me.Sevicos.Name = "Sevicos"
        Me.Sevicos.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Sevicos.Size = New System.Drawing.Size(75, 15)
        Me.Sevicos.StylePriority.UseFont = False
        Me.Sevicos.StylePriority.UseTextAlignment = False
        Me.Sevicos.Text = "0,00"
        Me.Sevicos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel19
        '
        Me.XrLabel19.BorderColor = System.Drawing.Color.Black
        Me.XrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel19.BorderWidth = 1
        Me.XrLabel19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel19.ForeColor = System.Drawing.Color.Black
        Me.XrLabel19.Location = New System.Drawing.Point(0, 99)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.Size = New System.Drawing.Size(1108, 17)
        Me.XrLabel19.StylePriority.UseBorderColor = False
        Me.XrLabel19.StylePriority.UseBorders = False
        Me.XrLabel19.StylePriority.UseBorderWidth = False
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseForeColor = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "Serviços"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'c1
        '
        Me.c1.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.c1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1.Location = New System.Drawing.Point(958, 77)
        Me.c1.Name = "c1"
        Me.c1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow8})
        Me.c1.Size = New System.Drawing.Size(150, 15)
        Me.c1.StylePriority.UseBorders = False
        Me.c1.StylePriority.UseFont = False
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell9, Me.Pecas})
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Size = New System.Drawing.Size(150, 15)
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell9.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell9.Size = New System.Drawing.Size(75, 15)
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "Total R$"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Pecas
        '
        Me.Pecas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pecas.Location = New System.Drawing.Point(75, 0)
        Me.Pecas.Name = "Pecas"
        Me.Pecas.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Pecas.Size = New System.Drawing.Size(75, 15)
        Me.Pecas.StylePriority.UseFont = False
        Me.Pecas.StylePriority.UseTextAlignment = False
        Me.Pecas.Text = "0,00"
        Me.Pecas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.Location = New System.Drawing.Point(0, 0)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.Size = New System.Drawing.Size(1108, 75)
        Me.WinControlContainer1.WinControl = Me.PedidoGridControl
        '
        'PedidoGridControl
        '
        Me.PedidoGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PedidoGridControl.DataMember = "tbPed"
        Me.PedidoGridControl.DataSource = Me.dsPed
        Me.PedidoGridControl.EmbeddedNavigator.Name = ""
        Me.PedidoGridControl.Location = New System.Drawing.Point(2, 20)
        Me.PedidoGridControl.LookAndFeel.SkinName = "Black"
        Me.PedidoGridControl.MainView = Me.grd1
        Me.PedidoGridControl.Name = "PedidoGridControl"
        Me.PedidoGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit1, Me.RepositoryItemMemoEdit2})
        Me.PedidoGridControl.Size = New System.Drawing.Size(1064, 72)
        Me.PedidoGridControl.TabIndex = 0
        Me.PedidoGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'grd1
        '
        Me.grd1.ActiveFilterEnabled = False
        Me.grd1.Appearance.FixedLine.BackColor = System.Drawing.Color.White
        Me.grd1.Appearance.FixedLine.BorderColor = System.Drawing.Color.White
        Me.grd1.Appearance.FixedLine.Options.UseBackColor = True
        Me.grd1.Appearance.FixedLine.Options.UseBorderColor = True
        Me.grd1.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.grd1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.grd1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grd1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grd1.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.grd1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grd1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grd1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grd1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grd1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.White
        Me.grd1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grd1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grd1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grd1.Appearance.HeaderPanel.Options.UseFont = True
        Me.grd1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grd1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grd1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.grd1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.grd1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grd1.Appearance.Row.Options.UseFont = True
        Me.grd1.Appearance.SelectedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.grd1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grd1.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.White
        Me.grd1.AppearancePrint.EvenRow.Options.UseBackColor = True
        Me.grd1.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grd1.AppearancePrint.HeaderPanel.BorderColor = System.Drawing.Color.White
        Me.grd1.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.AppearancePrint.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseBackColor = True
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseBorderColor = True
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseForeColor = True
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.grd1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.grd1.AppearancePrint.OddRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grd1.AppearancePrint.OddRow.Options.UseBackColor = True
        Me.grd1.AppearancePrint.Preview.BackColor = System.Drawing.Color.White
        Me.grd1.AppearancePrint.Preview.BorderColor = System.Drawing.Color.Black
        Me.grd1.AppearancePrint.Preview.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.grd1.AppearancePrint.Preview.ForeColor = System.Drawing.Color.Black
        Me.grd1.AppearancePrint.Preview.Options.UseBackColor = True
        Me.grd1.AppearancePrint.Preview.Options.UseBorderColor = True
        Me.grd1.AppearancePrint.Preview.Options.UseFont = True
        Me.grd1.AppearancePrint.Preview.Options.UseForeColor = True
        Me.grd1.AppearancePrint.Row.BackColor = System.Drawing.Color.White
        Me.grd1.AppearancePrint.Row.BorderColor = System.Drawing.Color.Black
        Me.grd1.AppearancePrint.Row.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.grd1.AppearancePrint.Row.ForeColor = System.Drawing.Color.Black
        Me.grd1.AppearancePrint.Row.Options.UseBackColor = True
        Me.grd1.AppearancePrint.Row.Options.UseBorderColor = True
        Me.grd1.AppearancePrint.Row.Options.UseFont = True
        Me.grd1.AppearancePrint.Row.Options.UseForeColor = True
        Me.grd1.AppearancePrint.Row.Options.UseTextOptions = True
        Me.grd1.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.grd1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colCod, Me.colPlaca, Me.colData, Me.colCliente, Me.colCPF, Me.colCodigoProduto, Me.colProduto, Me.colCampoPedido, Me.colQtd, Me.colValorUnitario, Me.colValorTotal, Me.colKM, Me.colRealizado, Me.colUM, Me.colFunc, Me.colLocacao, Me.colFornecedor})
        Me.grd1.GridControl = Me.PedidoGridControl
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsPrint.EnableAppearanceEvenRow = True
        Me.grd1.OptionsPrint.EnableAppearanceOddRow = True
        Me.grd1.OptionsPrint.ExpandAllGroups = False
        Me.grd1.OptionsPrint.PrintFooter = False
        Me.grd1.OptionsPrint.PrintGroupFooter = False
        Me.grd1.OptionsPrint.PrintHorzLines = False
        Me.grd1.OptionsPrint.PrintVertLines = False
        Me.grd1.OptionsPrint.UsePrintStyles = True
        Me.grd1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grd1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.grd1.OptionsView.EnableAppearanceEvenRow = True
        Me.grd1.OptionsView.EnableAppearanceOddRow = True
        Me.grd1.OptionsView.ShowDetailButtons = False
        Me.grd1.OptionsView.ShowGroupPanel = False
        Me.grd1.OptionsView.ShowHorzLines = False
        Me.grd1.OptionsView.ShowIndicator = False
        Me.grd1.OptionsView.ShowPreviewLines = False
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.colCodigo.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colCodigo.AppearanceCell.Options.UseFont = True
        Me.colCodigo.AppearanceCell.Options.UseForeColor = True
        Me.colCodigo.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCodigo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodigo.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigo.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colCodigo.AppearanceHeader.Options.UseBackColor = True
        Me.colCodigo.AppearanceHeader.Options.UseFont = True
        Me.colCodigo.AppearanceHeader.Options.UseForeColor = True
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Width = 57
        '
        'colCod
        '
        Me.colCod.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.colCod.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colCod.AppearanceCell.Options.UseFont = True
        Me.colCod.AppearanceCell.Options.UseForeColor = True
        Me.colCod.AppearanceCell.Options.UseTextOptions = True
        Me.colCod.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCod.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCod.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCod.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colCod.AppearanceHeader.Options.UseBackColor = True
        Me.colCod.AppearanceHeader.Options.UseFont = True
        Me.colCod.AppearanceHeader.Options.UseForeColor = True
        Me.colCod.Caption = "Cod"
        Me.colCod.FieldName = "Cod"
        Me.colCod.Name = "colCod"
        Me.colCod.Width = 57
        '
        'colPlaca
        '
        Me.colPlaca.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.colPlaca.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colPlaca.AppearanceCell.Options.UseFont = True
        Me.colPlaca.AppearanceCell.Options.UseForeColor = True
        Me.colPlaca.AppearanceCell.Options.UseTextOptions = True
        Me.colPlaca.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colPlaca.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colPlaca.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPlaca.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colPlaca.AppearanceHeader.Options.UseBackColor = True
        Me.colPlaca.AppearanceHeader.Options.UseFont = True
        Me.colPlaca.AppearanceHeader.Options.UseForeColor = True
        Me.colPlaca.Caption = "Placa"
        Me.colPlaca.FieldName = "Placa"
        Me.colPlaca.Name = "colPlaca"
        Me.colPlaca.Width = 57
        '
        'colData
        '
        Me.colData.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.colData.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colData.AppearanceCell.Options.UseFont = True
        Me.colData.AppearanceCell.Options.UseForeColor = True
        Me.colData.AppearanceCell.Options.UseTextOptions = True
        Me.colData.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colData.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colData.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colData.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colData.AppearanceHeader.Options.UseBackColor = True
        Me.colData.AppearanceHeader.Options.UseFont = True
        Me.colData.AppearanceHeader.Options.UseForeColor = True
        Me.colData.Caption = "Data"
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.Width = 57
        '
        'colCliente
        '
        Me.colCliente.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.colCliente.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colCliente.AppearanceCell.Options.UseFont = True
        Me.colCliente.AppearanceCell.Options.UseForeColor = True
        Me.colCliente.AppearanceCell.Options.UseTextOptions = True
        Me.colCliente.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCliente.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCliente.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCliente.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colCliente.AppearanceHeader.Options.UseBackColor = True
        Me.colCliente.AppearanceHeader.Options.UseFont = True
        Me.colCliente.AppearanceHeader.Options.UseForeColor = True
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.Width = 57
        '
        'colCPF
        '
        Me.colCPF.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.colCPF.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colCPF.AppearanceCell.Options.UseFont = True
        Me.colCPF.AppearanceCell.Options.UseForeColor = True
        Me.colCPF.AppearanceCell.Options.UseTextOptions = True
        Me.colCPF.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCPF.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCPF.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCPF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colCPF.AppearanceHeader.Options.UseBackColor = True
        Me.colCPF.AppearanceHeader.Options.UseFont = True
        Me.colCPF.AppearanceHeader.Options.UseForeColor = True
        Me.colCPF.Caption = "CPF"
        Me.colCPF.FieldName = "CPF"
        Me.colCPF.Name = "colCPF"
        Me.colCPF.Width = 57
        '
        'colCodigoProduto
        '
        Me.colCodigoProduto.AppearanceCell.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.colCodigoProduto.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colCodigoProduto.AppearanceCell.Options.UseFont = True
        Me.colCodigoProduto.AppearanceCell.Options.UseForeColor = True
        Me.colCodigoProduto.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoProduto.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCodigoProduto.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodigoProduto.AppearanceHeader.BorderColor = System.Drawing.Color.White
        Me.colCodigoProduto.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoProduto.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colCodigoProduto.AppearanceHeader.Options.UseBackColor = True
        Me.colCodigoProduto.AppearanceHeader.Options.UseBorderColor = True
        Me.colCodigoProduto.AppearanceHeader.Options.UseFont = True
        Me.colCodigoProduto.AppearanceHeader.Options.UseForeColor = True
        Me.colCodigoProduto.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colCodigoProduto.Caption = "   Código"
        Me.colCodigoProduto.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.colCodigoProduto.FieldName = "CodigoPeca"
        Me.colCodigoProduto.Name = "colCodigoProduto"
        Me.colCodigoProduto.Visible = True
        Me.colCodigoProduto.VisibleIndex = 0
        Me.colCodigoProduto.Width = 121
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'colProduto
        '
        Me.colProduto.AppearanceCell.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.colProduto.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colProduto.AppearanceCell.Options.UseFont = True
        Me.colProduto.AppearanceCell.Options.UseForeColor = True
        Me.colProduto.AppearanceCell.Options.UseTextOptions = True
        Me.colProduto.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colProduto.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colProduto.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colProduto.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colProduto.AppearanceHeader.Options.UseBackColor = True
        Me.colProduto.AppearanceHeader.Options.UseFont = True
        Me.colProduto.AppearanceHeader.Options.UseForeColor = True
        Me.colProduto.Caption = "  Produtos"
        Me.colProduto.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.colProduto.FieldName = "Descrição"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 1
        Me.colProduto.Width = 318
        '
        'colCampoPedido
        '
        Me.colCampoPedido.AppearanceCell.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.colCampoPedido.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colCampoPedido.AppearanceCell.Options.UseFont = True
        Me.colCampoPedido.AppearanceCell.Options.UseForeColor = True
        Me.colCampoPedido.AppearanceCell.Options.UseTextOptions = True
        Me.colCampoPedido.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCampoPedido.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCampoPedido.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCampoPedido.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colCampoPedido.AppearanceHeader.Options.UseBackColor = True
        Me.colCampoPedido.AppearanceHeader.Options.UseFont = True
        Me.colCampoPedido.AppearanceHeader.Options.UseForeColor = True
        Me.colCampoPedido.Caption = "  CampoPedido"
        Me.colCampoPedido.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.colCampoPedido.FieldName = "CampoPedido"
        Me.colCampoPedido.Name = "colCampoPedido"
        Me.colCampoPedido.Visible = True
        Me.colCampoPedido.VisibleIndex = 3
        Me.colCampoPedido.Width = 173
        '
        'colQtd
        '
        Me.colQtd.AppearanceCell.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.colQtd.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colQtd.AppearanceCell.Options.UseFont = True
        Me.colQtd.AppearanceCell.Options.UseForeColor = True
        Me.colQtd.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtd.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colQtd.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colQtd.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colQtd.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colQtd.AppearanceHeader.Options.UseBackColor = True
        Me.colQtd.AppearanceHeader.Options.UseFont = True
        Me.colQtd.AppearanceHeader.Options.UseForeColor = True
        Me.colQtd.Caption = "  Qtde"
        Me.colQtd.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.colQtd.FieldName = "Qtde"
        Me.colQtd.Name = "colQtd"
        Me.colQtd.OptionsColumn.ReadOnly = True
        Me.colQtd.Visible = True
        Me.colQtd.VisibleIndex = 5
        Me.colQtd.Width = 112
        '
        'colValorUnitario
        '
        Me.colValorUnitario.AppearanceCell.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.colValorUnitario.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colValorUnitario.AppearanceCell.Options.UseFont = True
        Me.colValorUnitario.AppearanceCell.Options.UseForeColor = True
        Me.colValorUnitario.AppearanceCell.Options.UseTextOptions = True
        Me.colValorUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorUnitario.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colValorUnitario.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValorUnitario.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValorUnitario.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colValorUnitario.AppearanceHeader.Options.UseBackColor = True
        Me.colValorUnitario.AppearanceHeader.Options.UseFont = True
        Me.colValorUnitario.AppearanceHeader.Options.UseForeColor = True
        Me.colValorUnitario.Caption = "  Vlr Unit. R$"
        Me.colValorUnitario.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.colValorUnitario.FieldName = "ValorUnitR"
        Me.colValorUnitario.Name = "colValorUnitario"
        Me.colValorUnitario.OptionsColumn.ReadOnly = True
        Me.colValorUnitario.Visible = True
        Me.colValorUnitario.VisibleIndex = 6
        Me.colValorUnitario.Width = 137
        '
        'colValorTotal
        '
        Me.colValorTotal.AppearanceCell.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.colValorTotal.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colValorTotal.AppearanceCell.Options.UseFont = True
        Me.colValorTotal.AppearanceCell.Options.UseForeColor = True
        Me.colValorTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colValorTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorTotal.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colValorTotal.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValorTotal.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValorTotal.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colValorTotal.AppearanceHeader.Options.UseBackColor = True
        Me.colValorTotal.AppearanceHeader.Options.UseFont = True
        Me.colValorTotal.AppearanceHeader.Options.UseForeColor = True
        Me.colValorTotal.Caption = "  Vlr Total R$"
        Me.colValorTotal.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.colValorTotal.FieldName = "Total"
        Me.colValorTotal.Name = "colValorTotal"
        Me.colValorTotal.OptionsColumn.ReadOnly = True
        Me.colValorTotal.Visible = True
        Me.colValorTotal.VisibleIndex = 7
        Me.colValorTotal.Width = 140
        '
        'colKM
        '
        Me.colKM.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.colKM.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colKM.AppearanceCell.Options.UseFont = True
        Me.colKM.AppearanceCell.Options.UseForeColor = True
        Me.colKM.AppearanceCell.Options.UseTextOptions = True
        Me.colKM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colKM.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colKM.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colKM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colKM.AppearanceHeader.Options.UseBackColor = True
        Me.colKM.AppearanceHeader.Options.UseFont = True
        Me.colKM.AppearanceHeader.Options.UseForeColor = True
        Me.colKM.Caption = "KM"
        Me.colKM.FieldName = "KM"
        Me.colKM.Name = "colKM"
        Me.colKM.Width = 83
        '
        'colRealizado
        '
        Me.colRealizado.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.colRealizado.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colRealizado.AppearanceCell.Options.UseFont = True
        Me.colRealizado.AppearanceCell.Options.UseForeColor = True
        Me.colRealizado.AppearanceCell.Options.UseTextOptions = True
        Me.colRealizado.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colRealizado.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colRealizado.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colRealizado.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colRealizado.AppearanceHeader.Options.UseBackColor = True
        Me.colRealizado.AppearanceHeader.Options.UseFont = True
        Me.colRealizado.AppearanceHeader.Options.UseForeColor = True
        Me.colRealizado.Caption = "Realizado"
        Me.colRealizado.FieldName = "Realizado"
        Me.colRealizado.Name = "colRealizado"
        '
        'colUM
        '
        Me.colUM.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.colUM.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colUM.AppearanceCell.Options.UseFont = True
        Me.colUM.AppearanceCell.Options.UseForeColor = True
        Me.colUM.AppearanceCell.Options.UseTextOptions = True
        Me.colUM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colUM.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colUM.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colUM.AppearanceHeader.Options.UseBackColor = True
        Me.colUM.AppearanceHeader.Options.UseFont = True
        Me.colUM.AppearanceHeader.Options.UseForeColor = True
        Me.colUM.Caption = "U.M."
        Me.colUM.FieldName = "UM"
        Me.colUM.Name = "colUM"
        Me.colUM.Visible = True
        Me.colUM.VisibleIndex = 4
        Me.colUM.Width = 71
        '
        'colFunc
        '
        Me.colFunc.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.colFunc.AppearanceCell.Options.UseFont = True
        Me.colFunc.AppearanceCell.Options.UseTextOptions = True
        Me.colFunc.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colFunc.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colFunc.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFunc.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colFunc.AppearanceHeader.Options.UseBackColor = True
        Me.colFunc.AppearanceHeader.Options.UseFont = True
        Me.colFunc.AppearanceHeader.Options.UseForeColor = True
        Me.colFunc.Caption = "Func."
        Me.colFunc.FieldName = "Func"
        Me.colFunc.Name = "colFunc"
        Me.colFunc.Width = 149
        '
        'colLocacao
        '
        Me.colLocacao.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.colLocacao.AppearanceCell.Options.UseFont = True
        Me.colLocacao.AppearanceCell.Options.UseTextOptions = True
        Me.colLocacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLocacao.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colLocacao.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colLocacao.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colLocacao.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colLocacao.AppearanceHeader.Options.UseBackColor = True
        Me.colLocacao.AppearanceHeader.Options.UseFont = True
        Me.colLocacao.AppearanceHeader.Options.UseForeColor = True
        Me.colLocacao.Caption = "Loc."
        Me.colLocacao.FieldName = "Locacao"
        Me.colLocacao.Name = "colLocacao"
        Me.colLocacao.Width = 88
        '
        'colFornecedor
        '
        Me.colFornecedor.AppearanceCell.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.colFornecedor.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colFornecedor.AppearanceCell.Options.UseFont = True
        Me.colFornecedor.AppearanceCell.Options.UseForeColor = True
        Me.colFornecedor.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colFornecedor.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colFornecedor.AppearanceHeader.Options.UseBackColor = True
        Me.colFornecedor.AppearanceHeader.Options.UseForeColor = True
        Me.colFornecedor.Caption = "  Fornecedor"
        Me.colFornecedor.FieldName = "Fornecedor"
        Me.colFornecedor.Name = "colFornecedor"
        Me.colFornecedor.Visible = True
        Me.colFornecedor.VisibleIndex = 2
        Me.colFornecedor.Width = 123
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.picLogo, Me.XrLine1, Me.lblEndereco, Me.lblFones, Me.lblTitulo, Me.lblPed, Me.lblPedido, Me.lblData})
        Me.PageHeader.Height = 70
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'picLogo
        '
        Me.picLogo.Location = New System.Drawing.Point(0, 4)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(158, 60)
        Me.picLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrLine1
        '
        Me.XrLine1.Location = New System.Drawing.Point(0, 67)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(1108, 3)
        '
        'lblEndereco
        '
        Me.lblEndereco.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblEndereco.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndereco.Location = New System.Drawing.Point(208, 42)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblEndereco.Size = New System.Drawing.Size(683, 12)
        Me.lblEndereco.StylePriority.UseBorders = False
        Me.lblEndereco.StylePriority.UseFont = False
        Me.lblEndereco.StylePriority.UseTextAlignment = False
        Me.lblEndereco.Text = "lblEndereco"
        Me.lblEndereco.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblFones
        '
        Me.lblFones.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblFones.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFones.Location = New System.Drawing.Point(208, 25)
        Me.lblFones.Name = "lblFones"
        Me.lblFones.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblFones.Size = New System.Drawing.Size(683, 12)
        Me.lblFones.StylePriority.UseBorders = False
        Me.lblFones.StylePriority.UseFont = False
        Me.lblFones.StylePriority.UseTextAlignment = False
        Me.lblFones.Text = "lblFones"
        Me.lblFones.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblTitulo
        '
        Me.lblTitulo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(208, 8)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitulo.Size = New System.Drawing.Size(683, 15)
        Me.lblTitulo.StylePriority.UseBorders = False
        Me.lblTitulo.StylePriority.UseFont = False
        Me.lblTitulo.StylePriority.UseTextAlignment = False
        Me.lblTitulo.Text = "lblTitulo"
        Me.lblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblPed
        '
        Me.lblPed.BackColor = System.Drawing.Color.Transparent
        Me.lblPed.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblPed.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPed.Location = New System.Drawing.Point(925, 0)
        Me.lblPed.Multiline = True
        Me.lblPed.Name = "lblPed"
        Me.lblPed.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPed.Size = New System.Drawing.Size(167, 24)
        Me.lblPed.StylePriority.UseBackColor = False
        Me.lblPed.StylePriority.UseBorders = False
        Me.lblPed.StylePriority.UseFont = False
        Me.lblPed.StylePriority.UseTextAlignment = False
        Me.lblPed.Text = "Pedido Nº"
        Me.lblPed.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.lblPed.WordWrap = False
        '
        'lblPedido
        '
        Me.lblPedido.BackColor = System.Drawing.Color.Transparent
        Me.lblPedido.BorderColor = System.Drawing.Color.Black
        Me.lblPedido.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblPedido.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPedido.ForeColor = System.Drawing.Color.Black
        Me.lblPedido.Location = New System.Drawing.Point(925, 24)
        Me.lblPedido.Name = "lblPedido"
        Me.lblPedido.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPedido.Size = New System.Drawing.Size(167, 17)
        Me.lblPedido.StylePriority.UseBackColor = False
        Me.lblPedido.StylePriority.UseBorderColor = False
        Me.lblPedido.StylePriority.UseBorders = False
        Me.lblPedido.StylePriority.UseFont = False
        Me.lblPedido.StylePriority.UseForeColor = False
        Me.lblPedido.StylePriority.UseTextAlignment = False
        Me.lblPedido.Text = "lblPedido"
        Me.lblPedido.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblData
        '
        Me.lblData.BackColor = System.Drawing.Color.Transparent
        Me.lblData.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblData.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.Location = New System.Drawing.Point(925, 41)
        Me.lblData.Name = "lblData"
        Me.lblData.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblData.Size = New System.Drawing.Size(167, 17)
        Me.lblData.StylePriority.UseBackColor = False
        Me.lblData.StylePriority.UseBorders = False
        Me.lblData.StylePriority.UseFont = False
        Me.lblData.StylePriority.UseTextAlignment = False
        Me.lblData.Text = "lblData"
        Me.lblData.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2, Me.lblDescricaoPedido, Me.XrPageInfo1})
        Me.PageFooter.Height = 51
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo2.Location = New System.Drawing.Point(500, 33)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.Size = New System.Drawing.Size(125, 17)
        Me.XrPageInfo2.StylePriority.UseFont = False
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblDescricaoPedido
        '
        Me.lblDescricaoPedido.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblDescricaoPedido.Location = New System.Drawing.Point(0, 0)
        Me.lblDescricaoPedido.Name = "lblDescricaoPedido"
        Me.lblDescricaoPedido.SerializableRtfString = resources.GetString("lblDescricaoPedido.SerializableRtfString")
        Me.lblDescricaoPedido.Size = New System.Drawing.Size(1108, 25)
        Me.lblDescricaoPedido.StylePriority.UseFont = False
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.Location = New System.Drawing.Point(825, 33)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.Size = New System.Drawing.Size(267, 17)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel24, Me.lblKMSaida, Me.XrLabel18, Me.XrLabel17, Me.XrLabel16, Me.XrLabel15, Me.XrLabel14, Me.XrLabel13, Me.XrLabel12, Me.XrLabel11, Me.XrLabel7, Me.lblChassi, Me.XrLabel9, Me.lblSaida, Me.XrLabel6, Me.lblEntrada, Me.KM, Me.XrLabel5, Me.XrLabel3, Me.XrLabel30, Me.Cor, Me.Placa, Me.Modelo, Me.Ano, Me.Fax, Me.Telefone, Me.Email, Me.Nome, Me.XrLabel1})
        Me.GroupHeader1.Height = 109
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel24
        '
        Me.XrLabel24.CanGrow = False
        Me.XrLabel24.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel24.Location = New System.Drawing.Point(908, 42)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.Size = New System.Drawing.Size(50, 13)
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.Text = "KM Saída"
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel24.WordWrap = False
        '
        'lblKMSaida
        '
        Me.lblKMSaida.CanGrow = False
        Me.lblKMSaida.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKMSaida.Location = New System.Drawing.Point(908, 52)
        Me.lblKMSaida.Name = "lblKMSaida"
        Me.lblKMSaida.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblKMSaida.Size = New System.Drawing.Size(100, 12)
        Me.lblKMSaida.StylePriority.UseFont = False
        Me.lblKMSaida.StylePriority.UseTextAlignment = False
        Me.lblKMSaida.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel18.Location = New System.Drawing.Point(625, 42)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.Size = New System.Drawing.Size(50, 12)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "Chassi"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel17
        '
        Me.XrLabel17.CanGrow = False
        Me.XrLabel17.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel17.Location = New System.Drawing.Point(1017, 17)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.Size = New System.Drawing.Size(50, 13)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "Ano"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel17.WordWrap = False
        '
        'XrLabel16
        '
        Me.XrLabel16.CanGrow = False
        Me.XrLabel16.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel16.Location = New System.Drawing.Point(908, 17)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.Size = New System.Drawing.Size(50, 13)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Cor"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel16.WordWrap = False
        '
        'XrLabel15
        '
        Me.XrLabel15.CanGrow = False
        Me.XrLabel15.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.Location = New System.Drawing.Point(717, 17)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.Size = New System.Drawing.Size(50, 13)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "Modelo"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel15.WordWrap = False
        '
        'XrLabel14
        '
        Me.XrLabel14.CanGrow = False
        Me.XrLabel14.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel14.Location = New System.Drawing.Point(0, 67)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.Size = New System.Drawing.Size(58, 13)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "E-mail"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel14.WordWrap = False
        '
        'XrLabel13
        '
        Me.XrLabel13.CanGrow = False
        Me.XrLabel13.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.Location = New System.Drawing.Point(117, 42)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.Size = New System.Drawing.Size(58, 13)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "Telefone"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel13.WordWrap = False
        '
        'XrLabel12
        '
        Me.XrLabel12.CanGrow = False
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.Location = New System.Drawing.Point(0, 42)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.Size = New System.Drawing.Size(58, 13)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Telefone"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel12.WordWrap = False
        '
        'XrLabel11
        '
        Me.XrLabel11.CanGrow = False
        Me.XrLabel11.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.Location = New System.Drawing.Point(0, 17)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.Size = New System.Drawing.Size(58, 13)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Nome"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel11.WordWrap = False
        '
        'XrLabel7
        '
        Me.XrLabel7.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel7.BorderWidth = 0
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.ForeColor = System.Drawing.Color.Black
        Me.XrLabel7.Location = New System.Drawing.Point(625, 0)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.Size = New System.Drawing.Size(375, 15)
        Me.XrLabel7.StylePriority.UseBorderColor = False
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseBorderWidth = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseForeColor = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Dados do Veículo"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblChassi
        '
        Me.lblChassi.CanGrow = False
        Me.lblChassi.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChassi.Location = New System.Drawing.Point(625, 52)
        Me.lblChassi.Name = "lblChassi"
        Me.lblChassi.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblChassi.Size = New System.Drawing.Size(192, 13)
        Me.lblChassi.StylePriority.UseFont = False
        Me.lblChassi.StylePriority.UseTextAlignment = False
        Me.lblChassi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.CanGrow = False
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.Location = New System.Drawing.Point(908, 67)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.Size = New System.Drawing.Size(58, 13)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Saída"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel9.WordWrap = False
        '
        'lblSaida
        '
        Me.lblSaida.CanGrow = False
        Me.lblSaida.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaida.Location = New System.Drawing.Point(908, 76)
        Me.lblSaida.Name = "lblSaida"
        Me.lblSaida.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblSaida.Size = New System.Drawing.Size(125, 13)
        Me.lblSaida.StylePriority.UseFont = False
        Me.lblSaida.StylePriority.UseTextAlignment = False
        Me.lblSaida.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.CanGrow = False
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.Location = New System.Drawing.Point(625, 67)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.Size = New System.Drawing.Size(58, 13)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Entrada"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel6.WordWrap = False
        '
        'lblEntrada
        '
        Me.lblEntrada.CanGrow = False
        Me.lblEntrada.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntrada.Location = New System.Drawing.Point(625, 76)
        Me.lblEntrada.Name = "lblEntrada"
        Me.lblEntrada.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblEntrada.Size = New System.Drawing.Size(192, 12)
        Me.lblEntrada.StylePriority.UseFont = False
        Me.lblEntrada.StylePriority.UseTextAlignment = False
        Me.lblEntrada.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'KM
        '
        Me.KM.CanGrow = False
        Me.KM.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KM.Location = New System.Drawing.Point(1017, 52)
        Me.KM.Name = "KM"
        Me.KM.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.KM.Size = New System.Drawing.Size(67, 12)
        Me.KM.StylePriority.UseFont = False
        Me.KM.StylePriority.UseTextAlignment = False
        Me.KM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.Location = New System.Drawing.Point(1017, 42)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.Size = New System.Drawing.Size(50, 12)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "KM"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.BorderColor = System.Drawing.Color.Black
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel3.BorderWidth = 1
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.ForeColor = System.Drawing.Color.Black
        Me.XrLabel3.Location = New System.Drawing.Point(0, 92)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.Size = New System.Drawing.Size(1108, 17)
        Me.XrLabel3.StylePriority.UseBorderColor = False
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseBorderWidth = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Produtos"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel30
        '
        Me.XrLabel30.CanGrow = False
        Me.XrLabel30.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel30.Location = New System.Drawing.Point(625, 17)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.Size = New System.Drawing.Size(50, 13)
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.Text = "Placa"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel30.WordWrap = False
        '
        'Cor
        '
        Me.Cor.CanGrow = False
        Me.Cor.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cor.Location = New System.Drawing.Point(908, 27)
        Me.Cor.Name = "Cor"
        Me.Cor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cor.Size = New System.Drawing.Size(100, 12)
        Me.Cor.StylePriority.UseFont = False
        Me.Cor.StylePriority.UseTextAlignment = False
        Me.Cor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'Placa
        '
        Me.Placa.CanGrow = False
        Me.Placa.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Placa.Location = New System.Drawing.Point(625, 27)
        Me.Placa.Name = "Placa"
        Me.Placa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Placa.Size = New System.Drawing.Size(83, 12)
        Me.Placa.StylePriority.UseFont = False
        Me.Placa.StylePriority.UseTextAlignment = False
        Me.Placa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'Modelo
        '
        Me.Modelo.CanGrow = False
        Me.Modelo.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modelo.Location = New System.Drawing.Point(717, 27)
        Me.Modelo.Name = "Modelo"
        Me.Modelo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Modelo.Size = New System.Drawing.Size(167, 12)
        Me.Modelo.StylePriority.UseFont = False
        Me.Modelo.StylePriority.UseTextAlignment = False
        Me.Modelo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'Ano
        '
        Me.Ano.CanGrow = False
        Me.Ano.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ano.Location = New System.Drawing.Point(1017, 27)
        Me.Ano.Name = "Ano"
        Me.Ano.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ano.Size = New System.Drawing.Size(67, 12)
        Me.Ano.StylePriority.UseFont = False
        Me.Ano.StylePriority.UseTextAlignment = False
        Me.Ano.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'Fax
        '
        Me.Fax.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fax.Location = New System.Drawing.Point(117, 52)
        Me.Fax.Name = "Fax"
        Me.Fax.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Fax.Size = New System.Drawing.Size(108, 13)
        Me.Fax.StylePriority.UseFont = False
        Me.Fax.StylePriority.UseTextAlignment = False
        Me.Fax.Text = " "
        Me.Fax.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'Telefone
        '
        Me.Telefone.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telefone.Location = New System.Drawing.Point(0, 52)
        Me.Telefone.Name = "Telefone"
        Me.Telefone.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Telefone.Size = New System.Drawing.Size(108, 13)
        Me.Telefone.StylePriority.UseFont = False
        Me.Telefone.StylePriority.UseTextAlignment = False
        Me.Telefone.Text = " "
        Me.Telefone.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'Email
        '
        Me.Email.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(0, 76)
        Me.Email.Name = "Email"
        Me.Email.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Email.Size = New System.Drawing.Size(367, 12)
        Me.Email.StylePriority.UseFont = False
        Me.Email.StylePriority.UseTextAlignment = False
        Me.Email.Text = " "
        Me.Email.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'Nome
        '
        Me.Nome.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome.Location = New System.Drawing.Point(0, 27)
        Me.Nome.Name = "Nome"
        Me.Nome.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nome.Size = New System.Drawing.Size(375, 13)
        Me.Nome.StylePriority.UseFont = False
        Me.Nome.StylePriority.UseTextAlignment = False
        Me.Nome.Text = "EDER"
        Me.Nome.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel1.BorderWidth = 0
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.ForeColor = System.Drawing.Color.Black
        Me.XrLabel1.Location = New System.Drawing.Point(0, 0)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(375, 15)
        Me.XrLabel1.StylePriority.UseBorderColor = False
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseBorderWidth = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Dados do Cliente"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel38
        '
        Me.XrLabel38.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel38.Location = New System.Drawing.Point(0, 8)
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel38.Size = New System.Drawing.Size(1100, 17)
        Me.XrLabel38.StylePriority.UseFont = False
        Me.XrLabel38.Text = "Dados do Cliente                               "
        '
        'XrLabel26
        '
        Me.XrLabel26.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel26.Location = New System.Drawing.Point(0, 108)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel26.Size = New System.Drawing.Size(1100, 17)
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.Text = "Dados do Veículo                              "
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.Location = New System.Drawing.Point(0, 0)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel2.Size = New System.Drawing.Size(1100, 17)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Dados do Cliente                               "
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrControlStyle1
        '
        Me.XrControlStyle1.Name = "XrControlStyle1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblVendedor, Me.lblLabelVendedor, Me.XrTable1, Me.lblDefeitos, Me.XrLabel21, Me.lblDesc, Me.XrLabel23, Me.XrLabel8, Me.c6, Me.c7, Me.c5, Me.c3, Me.lblRec, Me.c4})
        Me.GroupFooter1.Height = 138
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'lblVendedor
        '
        Me.lblVendedor.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendedor.Location = New System.Drawing.Point(0, 109)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.SerializableRtfString = resources.GetString("lblVendedor.SerializableRtfString")
        Me.lblVendedor.Size = New System.Drawing.Size(275, 17)
        Me.lblVendedor.StylePriority.UseFont = False
        Me.lblVendedor.Visible = False
        '
        'lblLabelVendedor
        '
        Me.lblLabelVendedor.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lblLabelVendedor.CanGrow = False
        Me.lblLabelVendedor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabelVendedor.Location = New System.Drawing.Point(0, 92)
        Me.lblLabelVendedor.Name = "lblLabelVendedor"
        Me.lblLabelVendedor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblLabelVendedor.Size = New System.Drawing.Size(275, 17)
        Me.lblLabelVendedor.StylePriority.UseBorders = False
        Me.lblLabelVendedor.StylePriority.UseFont = False
        Me.lblLabelVendedor.StylePriority.UseTextAlignment = False
        Me.lblLabelVendedor.Text = "Vendedor"
        Me.lblLabelVendedor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.lblLabelVendedor.Visible = False
        Me.lblLabelVendedor.WordWrap = False
        '
        'XrTable1
        '
        Me.XrTable1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTable1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTable1.Location = New System.Drawing.Point(958, 110)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow7})
        Me.XrTable1.Size = New System.Drawing.Size(150, 12)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.Visible = False
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.lblFrete})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Size = New System.Drawing.Size(150, 12)
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell7.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell7.Size = New System.Drawing.Size(75, 12)
        Me.XrTableCell7.StylePriority.UseFont = False
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        Me.XrTableCell7.Text = "Frete R$"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblFrete
        '
        Me.lblFrete.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrete.Location = New System.Drawing.Point(75, 0)
        Me.lblFrete.Name = "lblFrete"
        Me.lblFrete.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblFrete.Size = New System.Drawing.Size(75, 12)
        Me.lblFrete.StylePriority.UseFont = False
        Me.lblFrete.StylePriority.UseTextAlignment = False
        Me.lblFrete.Text = "0,00"
        Me.lblFrete.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblDefeitos
        '
        Me.lblDefeitos.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefeitos.Location = New System.Drawing.Point(0, 59)
        Me.lblDefeitos.Name = "lblDefeitos"
        Me.lblDefeitos.SerializableRtfString = resources.GetString("lblDefeitos.SerializableRtfString")
        Me.lblDefeitos.Size = New System.Drawing.Size(700, 17)
        Me.lblDefeitos.StylePriority.UseFont = False
        '
        'XrLabel21
        '
        Me.XrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel21.CanGrow = False
        Me.XrLabel21.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel21.Location = New System.Drawing.Point(0, 42)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.Size = New System.Drawing.Size(700, 17)
        Me.XrLabel21.StylePriority.UseBorders = False
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "Defeitos do Veículo"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel21.WordWrap = False
        '
        'lblDesc
        '
        Me.lblDesc.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(0, 18)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.SerializableRtfString = resources.GetString("lblDesc.SerializableRtfString")
        Me.lblDesc.Size = New System.Drawing.Size(700, 17)
        Me.lblDesc.StylePriority.UseFont = False
        '
        'XrLabel23
        '
        Me.XrLabel23.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel23.CanGrow = False
        Me.XrLabel23.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel23.Location = New System.Drawing.Point(0, 0)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.Size = New System.Drawing.Size(700, 17)
        Me.XrLabel23.StylePriority.UseBorders = False
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "Observações"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel23.WordWrap = False
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.Location = New System.Drawing.Point(733, 0)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.Size = New System.Drawing.Size(375, 15)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Totais do Pedido"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'c6
        '
        Me.c6.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.c6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.c6.Location = New System.Drawing.Point(958, 93)
        Me.c6.Name = "c6"
        Me.c6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow6})
        Me.c6.Size = New System.Drawing.Size(150, 12)
        Me.c6.StylePriority.UseBorders = False
        Me.c6.StylePriority.UseFont = False
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell6, Me.Troco})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Size = New System.Drawing.Size(150, 12)
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell6.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell6.Size = New System.Drawing.Size(75, 12)
        Me.XrTableCell6.StylePriority.UseFont = False
        Me.XrTableCell6.StylePriority.UseTextAlignment = False
        Me.XrTableCell6.Text = "Troco R$"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Troco
        '
        Me.Troco.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Troco.Location = New System.Drawing.Point(75, 0)
        Me.Troco.Name = "Troco"
        Me.Troco.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Troco.Size = New System.Drawing.Size(75, 12)
        Me.Troco.StylePriority.UseFont = False
        Me.Troco.StylePriority.UseTextAlignment = False
        Me.Troco.Text = "0,00"
        Me.Troco.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'c7
        '
        Me.c7.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.c7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.c7.Location = New System.Drawing.Point(958, 76)
        Me.c7.Name = "c7"
        Me.c7.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow5})
        Me.c7.Size = New System.Drawing.Size(150, 12)
        Me.c7.StylePriority.UseBorders = False
        Me.c7.StylePriority.UseFont = False
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell5, Me.Recebido})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Size = New System.Drawing.Size(150, 12)
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell5.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell5.Size = New System.Drawing.Size(75, 12)
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "Recebido R$"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Recebido
        '
        Me.Recebido.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Recebido.Location = New System.Drawing.Point(75, 0)
        Me.Recebido.Name = "Recebido"
        Me.Recebido.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Recebido.Size = New System.Drawing.Size(75, 12)
        Me.Recebido.StylePriority.UseFont = False
        Me.Recebido.StylePriority.UseTextAlignment = False
        Me.Recebido.Text = "0,00"
        Me.Recebido.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'c5
        '
        Me.c5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.c5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.c5.Location = New System.Drawing.Point(958, 59)
        Me.c5.Name = "c5"
        Me.c5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.c5.Size = New System.Drawing.Size(150, 12)
        Me.c5.StylePriority.UseBorders = False
        Me.c5.StylePriority.UseFont = False
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.subTotal})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Size = New System.Drawing.Size(150, 12)
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell4.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell4.Size = New System.Drawing.Size(75, 12)
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.Text = "Sub Total R$"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'subTotal
        '
        Me.subTotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subTotal.Location = New System.Drawing.Point(75, 0)
        Me.subTotal.Name = "subTotal"
        Me.subTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.subTotal.Size = New System.Drawing.Size(75, 12)
        Me.subTotal.StylePriority.UseFont = False
        Me.subTotal.StylePriority.UseTextAlignment = False
        Me.subTotal.Text = "0,00"
        Me.subTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'c3
        '
        Me.c3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.c3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.c3.Location = New System.Drawing.Point(958, 25)
        Me.c3.Name = "c3"
        Me.c3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.c3.Size = New System.Drawing.Size(150, 12)
        Me.c3.StylePriority.UseBorders = False
        Me.c3.StylePriority.UseFont = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.Total})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(150, 12)
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell1.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell1.Size = New System.Drawing.Size(75, 12)
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "Total R$"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Total
        '
        Me.Total.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(75, 0)
        Me.Total.Name = "Total"
        Me.Total.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Total.Size = New System.Drawing.Size(75, 12)
        Me.Total.StylePriority.UseFont = False
        Me.Total.StylePriority.UseTextAlignment = False
        Me.Total.Text = "0,00"
        Me.Total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblRec
        '
        Me.lblRec.Font = New System.Drawing.Font("Lucida Console", 7.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRec.Location = New System.Drawing.Point(733, 25)
        Me.lblRec.Multiline = True
        Me.lblRec.Name = "lblRec"
        Me.lblRec.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblRec.Size = New System.Drawing.Size(208, 92)
        Me.lblRec.StylePriority.UseFont = False
        Me.lblRec.StylePriority.UseTextAlignment = False
        Me.lblRec.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'c4
        '
        Me.c4.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.c4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.c4.Location = New System.Drawing.Point(958, 42)
        Me.c4.Name = "c4"
        Me.c4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.c4.Size = New System.Drawing.Size(150, 12)
        Me.c4.StylePriority.UseBorders = False
        Me.c4.StylePriority.UseFont = False
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell3, Me.Desconto})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Size = New System.Drawing.Size(150, 12)
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell3.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell3.Size = New System.Drawing.Size(75, 12)
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "Desconto R$"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Desconto
        '
        Me.Desconto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desconto.Location = New System.Drawing.Point(75, 0)
        Me.Desconto.Name = "Desconto"
        Me.Desconto.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Desconto.Size = New System.Drawing.Size(75, 12)
        Me.Desconto.StylePriority.UseFont = False
        Me.Desconto.StylePriority.UseTextAlignment = False
        Me.Desconto.Text = "0,00"
        Me.Desconto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblGar
        '
        Me.lblGar.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGar.Location = New System.Drawing.Point(0, 17)
        Me.lblGar.Name = "lblGar"
        Me.lblGar.SerializableRtfString = resources.GetString("lblGar.SerializableRtfString")
        Me.lblGar.Size = New System.Drawing.Size(1108, 25)
        Me.lblGar.StylePriority.UseFont = False
        '
        'lblGarantias
        '
        Me.lblGarantias.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lblGarantias.CanGrow = False
        Me.lblGarantias.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGarantias.Location = New System.Drawing.Point(0, 0)
        Me.lblGarantias.Name = "lblGarantias"
        Me.lblGarantias.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblGarantias.Size = New System.Drawing.Size(1108, 17)
        Me.lblGarantias.StylePriority.UseBorders = False
        Me.lblGarantias.StylePriority.UseFont = False
        Me.lblGarantias.StylePriority.UseTextAlignment = False
        Me.lblGarantias.Text = "Garantia"
        Me.lblGarantias.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.lblGarantias.Visible = False
        '
        'lblAssi
        '
        Me.lblAssi.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssi.Location = New System.Drawing.Point(775, 58)
        Me.lblAssi.Name = "lblAssi"
        Me.lblAssi.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblAssi.Size = New System.Drawing.Size(317, 17)
        Me.lblAssi.StylePriority.UseFont = False
        Me.lblAssi.StylePriority.UseTextAlignment = False
        Me.lblAssi.Text = "lblAssi"
        Me.lblAssi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblAut
        '
        Me.lblAut.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAut.Location = New System.Drawing.Point(775, 17)
        Me.lblAut.Name = "lblAut"
        Me.lblAut.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblAut.Size = New System.Drawing.Size(317, 17)
        Me.lblAut.StylePriority.UseFont = False
        Me.lblAut.StylePriority.UseTextAlignment = False
        Me.lblAut.Text = "Autorizo e concordo com os itens acima discriminados."
        Me.lblAut.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'linha7
        '
        Me.linha7.Location = New System.Drawing.Point(792, 50)
        Me.linha7.Name = "linha7"
        Me.linha7.Size = New System.Drawing.Size(283, 8)
        '
        'GroupFooter3
        '
        Me.GroupFooter3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblGarantias, Me.lblGar})
        Me.GroupFooter3.Height = 42
        Me.GroupFooter3.Level = 1
        Me.GroupFooter3.Name = "GroupFooter3"
        '
        'GroupFooter4
        '
        Me.GroupFooter4.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.linha7, Me.lblAut, Me.lblAssi})
        Me.GroupFooter4.Height = 80
        Me.GroupFooter4.Level = 2
        Me.GroupFooter4.Name = "GroupFooter4"
        '
        'colCódigo
        '
        Me.colCódigo.AppearanceCell.Options.UseTextOptions = True
        Me.colCódigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCódigo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCódigo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCódigo.AppearanceHeader.Options.UseBackColor = True
        Me.colCódigo.AppearanceHeader.Options.UseFont = True
        Me.colCódigo.Caption = "Código"
        Me.colCódigo.FieldName = "Código"
        Me.colCódigo.Name = "colCódigo"
        Me.colCódigo.Visible = True
        Me.colCódigo.VisibleIndex = 0
        Me.colCódigo.Width = 138
        '
        'colServiços
        '
        Me.colServiços.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colServiços.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colServiços.AppearanceHeader.Options.UseBackColor = True
        Me.colServiços.AppearanceHeader.Options.UseFont = True
        Me.colServiços.Caption = "Descrição dos Serviços"
        Me.colServiços.FieldName = "Serviços"
        Me.colServiços.Name = "colServiços"
        Me.colServiços.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.colServiços.Visible = True
        Me.colServiços.VisibleIndex = 1
        Me.colServiços.Width = 513
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
        Me.colQtde.VisibleIndex = 2
        Me.colQtde.Width = 97
        '
        'colVlUnit
        '
        Me.colVlUnit.AppearanceCell.Options.UseTextOptions = True
        Me.colVlUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colVlUnit.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colVlUnit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVlUnit.AppearanceHeader.Options.UseBackColor = True
        Me.colVlUnit.AppearanceHeader.Options.UseFont = True
        Me.colVlUnit.Caption = "Valor Unit. R$"
        Me.colVlUnit.FieldName = "VlUnit"
        Me.colVlUnit.Name = "colVlUnit"
        Me.colVlUnit.Visible = True
        Me.colVlUnit.VisibleIndex = 3
        Me.colVlUnit.Width = 138
        '
        'colvlTot
        '
        Me.colvlTot.AppearanceCell.Options.UseTextOptions = True
        Me.colvlTot.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colvlTot.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colvlTot.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colvlTot.AppearanceHeader.Options.UseBackColor = True
        Me.colvlTot.AppearanceHeader.Options.UseFont = True
        Me.colvlTot.Caption = "Valor Total R$"
        Me.colvlTot.FieldName = "vlTot"
        Me.colvlTot.Name = "colvlTot"
        Me.colvlTot.Visible = True
        Me.colvlTot.VisibleIndex = 4
        Me.colvlTot.Width = 146
        '
        'colUMSER
        '
        Me.colUMSER.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colUMSER.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colUMSER.AppearanceCell.Options.UseBackColor = True
        Me.colUMSER.AppearanceCell.Options.UseForeColor = True
        Me.colUMSER.AppearanceCell.Options.UseTextOptions = True
        Me.colUMSER.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUMSER.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colUMSER.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUMSER.AppearanceHeader.Options.UseBackColor = True
        Me.colUMSER.AppearanceHeader.Options.UseFont = True
        Me.colUMSER.FieldName = "UMSER"
        Me.colUMSER.Name = "colUMSER"
        '
        'colFuncServ
        '
        Me.colFuncServ.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colFuncServ.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colFuncServ.AppearanceCell.Options.UseBackColor = True
        Me.colFuncServ.AppearanceCell.Options.UseFont = True
        Me.colFuncServ.AppearanceCell.Options.UseForeColor = True
        Me.colFuncServ.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colFuncServ.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFuncServ.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colFuncServ.AppearanceHeader.Options.UseBackColor = True
        Me.colFuncServ.AppearanceHeader.Options.UseFont = True
        Me.colFuncServ.AppearanceHeader.Options.UseForeColor = True
        Me.colFuncServ.Caption = "Func."
        Me.colFuncServ.FieldName = "Func"
        Me.colFuncServ.Name = "colFuncServ"
        Me.colFuncServ.Visible = True
        Me.colFuncServ.VisibleIndex = 2
        Me.colFuncServ.Width = 159
        '
        'colLocacaoServ
        '
        Me.colLocacaoServ.AppearanceCell.Options.UseTextOptions = True
        Me.colLocacaoServ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLocacaoServ.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colLocacaoServ.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colLocacaoServ.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colLocacaoServ.AppearanceHeader.Options.UseBackColor = True
        Me.colLocacaoServ.AppearanceHeader.Options.UseFont = True
        Me.colLocacaoServ.AppearanceHeader.Options.UseForeColor = True
        Me.colLocacaoServ.Caption = "Loc."
        Me.colLocacaoServ.FieldName = "Locacao"
        Me.colLocacaoServ.Name = "colLocacaoServ"
        Me.colLocacaoServ.Width = 88
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel20, Me.lblCPF, Me.XrLabel55, Me.lblComplemento, Me.XrLabel53, Me.XrLabel52, Me.XrLabel51, Me.XrLabel50, Me.XrLabel49, Me.XrLabel48, Me.XrLabel47, Me.XrLabel46, Me.XrLabel44, Me.lblBairro, Me.XrLabel42, Me.lblSaida2, Me.XrLabel40, Me.lblEntrada2, Me.lblUF, Me.XrLabel36, Me.XrLabel35, Me.XrLabel34, Me.lblNum, Me.lblEnd, Me.lblCidade, Me.lblCep, Me.lblFax, Me.lblTelefone, Me.lblEmail, Me.lblNome, Me.XrLabel4})
        Me.GroupHeader2.Height = 110
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'XrLabel55
        '
        Me.XrLabel55.CanGrow = False
        Me.XrLabel55.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel55.Location = New System.Drawing.Point(908, 42)
        Me.XrLabel55.Name = "XrLabel55"
        Me.XrLabel55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel55.Size = New System.Drawing.Size(83, 12)
        Me.XrLabel55.StylePriority.UseFont = False
        Me.XrLabel55.StylePriority.UseTextAlignment = False
        Me.XrLabel55.Text = "Complemento"
        Me.XrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel55.WordWrap = False
        '
        'lblComplemento
        '
        Me.lblComplemento.CanGrow = False
        Me.lblComplemento.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplemento.Location = New System.Drawing.Point(908, 52)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblComplemento.Size = New System.Drawing.Size(175, 12)
        Me.lblComplemento.StylePriority.UseFont = False
        Me.lblComplemento.StylePriority.UseTextAlignment = False
        Me.lblComplemento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel53
        '
        Me.XrLabel53.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel53.Location = New System.Drawing.Point(625, 42)
        Me.XrLabel53.Name = "XrLabel53"
        Me.XrLabel53.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel53.Size = New System.Drawing.Size(50, 12)
        Me.XrLabel53.StylePriority.UseFont = False
        Me.XrLabel53.StylePriority.UseTextAlignment = False
        Me.XrLabel53.Text = "Bairro"
        Me.XrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel52
        '
        Me.XrLabel52.CanGrow = False
        Me.XrLabel52.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel52.Location = New System.Drawing.Point(1000, 17)
        Me.XrLabel52.Name = "XrLabel52"
        Me.XrLabel52.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel52.Size = New System.Drawing.Size(50, 13)
        Me.XrLabel52.StylePriority.UseFont = False
        Me.XrLabel52.StylePriority.UseTextAlignment = False
        Me.XrLabel52.Text = "Cep"
        Me.XrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel52.WordWrap = False
        '
        'XrLabel51
        '
        Me.XrLabel51.CanGrow = False
        Me.XrLabel51.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel51.Location = New System.Drawing.Point(908, 17)
        Me.XrLabel51.Name = "XrLabel51"
        Me.XrLabel51.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel51.Size = New System.Drawing.Size(50, 13)
        Me.XrLabel51.StylePriority.UseFont = False
        Me.XrLabel51.StylePriority.UseTextAlignment = False
        Me.XrLabel51.Text = "Número"
        Me.XrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel51.WordWrap = False
        '
        'XrLabel50
        '
        Me.XrLabel50.CanGrow = False
        Me.XrLabel50.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel50.Location = New System.Drawing.Point(625, 67)
        Me.XrLabel50.Name = "XrLabel50"
        Me.XrLabel50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel50.Size = New System.Drawing.Size(50, 13)
        Me.XrLabel50.StylePriority.UseFont = False
        Me.XrLabel50.StylePriority.UseTextAlignment = False
        Me.XrLabel50.Text = "Cidade"
        Me.XrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel50.WordWrap = False
        '
        'XrLabel49
        '
        Me.XrLabel49.CanGrow = False
        Me.XrLabel49.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel49.Location = New System.Drawing.Point(0, 67)
        Me.XrLabel49.Name = "XrLabel49"
        Me.XrLabel49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel49.Size = New System.Drawing.Size(58, 13)
        Me.XrLabel49.StylePriority.UseFont = False
        Me.XrLabel49.StylePriority.UseTextAlignment = False
        Me.XrLabel49.Text = "E-mail"
        Me.XrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel49.WordWrap = False
        '
        'XrLabel48
        '
        Me.XrLabel48.CanGrow = False
        Me.XrLabel48.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel48.Location = New System.Drawing.Point(117, 42)
        Me.XrLabel48.Name = "XrLabel48"
        Me.XrLabel48.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel48.Size = New System.Drawing.Size(58, 13)
        Me.XrLabel48.StylePriority.UseFont = False
        Me.XrLabel48.StylePriority.UseTextAlignment = False
        Me.XrLabel48.Text = "Telefone"
        Me.XrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel48.WordWrap = False
        '
        'XrLabel47
        '
        Me.XrLabel47.CanGrow = False
        Me.XrLabel47.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel47.Location = New System.Drawing.Point(0, 42)
        Me.XrLabel47.Name = "XrLabel47"
        Me.XrLabel47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel47.Size = New System.Drawing.Size(58, 13)
        Me.XrLabel47.StylePriority.UseFont = False
        Me.XrLabel47.StylePriority.UseTextAlignment = False
        Me.XrLabel47.Text = "Telefone"
        Me.XrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel47.WordWrap = False
        '
        'XrLabel46
        '
        Me.XrLabel46.CanGrow = False
        Me.XrLabel46.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel46.Location = New System.Drawing.Point(0, 17)
        Me.XrLabel46.Name = "XrLabel46"
        Me.XrLabel46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel46.Size = New System.Drawing.Size(58, 13)
        Me.XrLabel46.StylePriority.UseFont = False
        Me.XrLabel46.StylePriority.UseTextAlignment = False
        Me.XrLabel46.Text = "Nome"
        Me.XrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel46.WordWrap = False
        '
        'XrLabel44
        '
        Me.XrLabel44.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.XrLabel44.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel44.BorderWidth = 0
        Me.XrLabel44.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel44.ForeColor = System.Drawing.Color.Black
        Me.XrLabel44.Location = New System.Drawing.Point(625, 0)
        Me.XrLabel44.Name = "XrLabel44"
        Me.XrLabel44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel44.Size = New System.Drawing.Size(375, 15)
        Me.XrLabel44.StylePriority.UseBorderColor = False
        Me.XrLabel44.StylePriority.UseBorders = False
        Me.XrLabel44.StylePriority.UseBorderWidth = False
        Me.XrLabel44.StylePriority.UseFont = False
        Me.XrLabel44.StylePriority.UseForeColor = False
        Me.XrLabel44.StylePriority.UseTextAlignment = False
        Me.XrLabel44.Text = "Dados da Entrega"
        Me.XrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblBairro
        '
        Me.lblBairro.CanGrow = False
        Me.lblBairro.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBairro.Location = New System.Drawing.Point(625, 52)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblBairro.Size = New System.Drawing.Size(275, 12)
        Me.lblBairro.StylePriority.UseFont = False
        Me.lblBairro.StylePriority.UseTextAlignment = False
        Me.lblBairro.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel42
        '
        Me.XrLabel42.CanGrow = False
        Me.XrLabel42.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel42.Location = New System.Drawing.Point(1000, 67)
        Me.XrLabel42.Name = "XrLabel42"
        Me.XrLabel42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel42.Size = New System.Drawing.Size(58, 13)
        Me.XrLabel42.StylePriority.UseFont = False
        Me.XrLabel42.StylePriority.UseTextAlignment = False
        Me.XrLabel42.Text = "Saída"
        Me.XrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel42.WordWrap = False
        '
        'lblSaida2
        '
        Me.lblSaida2.CanGrow = False
        Me.lblSaida2.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaida2.Location = New System.Drawing.Point(1000, 76)
        Me.lblSaida2.Name = "lblSaida2"
        Me.lblSaida2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblSaida2.Size = New System.Drawing.Size(83, 12)
        Me.lblSaida2.StylePriority.UseFont = False
        Me.lblSaida2.StylePriority.UseTextAlignment = False
        Me.lblSaida2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel40
        '
        Me.XrLabel40.CanGrow = False
        Me.XrLabel40.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel40.Location = New System.Drawing.Point(908, 67)
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel40.Size = New System.Drawing.Size(58, 13)
        Me.XrLabel40.StylePriority.UseFont = False
        Me.XrLabel40.StylePriority.UseTextAlignment = False
        Me.XrLabel40.Text = "Entrada"
        Me.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel40.WordWrap = False
        '
        'lblEntrada2
        '
        Me.lblEntrada2.CanGrow = False
        Me.lblEntrada2.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntrada2.Location = New System.Drawing.Point(908, 76)
        Me.lblEntrada2.Name = "lblEntrada2"
        Me.lblEntrada2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblEntrada2.Size = New System.Drawing.Size(83, 12)
        Me.lblEntrada2.StylePriority.UseFont = False
        Me.lblEntrada2.StylePriority.UseTextAlignment = False
        Me.lblEntrada2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'lblUF
        '
        Me.lblUF.CanGrow = False
        Me.lblUF.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUF.Location = New System.Drawing.Point(858, 76)
        Me.lblUF.Name = "lblUF"
        Me.lblUF.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblUF.Size = New System.Drawing.Size(42, 12)
        Me.lblUF.StylePriority.UseFont = False
        Me.lblUF.StylePriority.UseTextAlignment = False
        Me.lblUF.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel36
        '
        Me.XrLabel36.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel36.Location = New System.Drawing.Point(858, 67)
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel36.Size = New System.Drawing.Size(42, 12)
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.StylePriority.UseTextAlignment = False
        Me.XrLabel36.Text = "UF"
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel35
        '
        Me.XrLabel35.BorderColor = System.Drawing.Color.Black
        Me.XrLabel35.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel35.BorderWidth = 1
        Me.XrLabel35.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel35.ForeColor = System.Drawing.Color.Black
        Me.XrLabel35.Location = New System.Drawing.Point(0, 92)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel35.Size = New System.Drawing.Size(1108, 17)
        Me.XrLabel35.StylePriority.UseBorderColor = False
        Me.XrLabel35.StylePriority.UseBorders = False
        Me.XrLabel35.StylePriority.UseBorderWidth = False
        Me.XrLabel35.StylePriority.UseFont = False
        Me.XrLabel35.StylePriority.UseForeColor = False
        Me.XrLabel35.StylePriority.UseTextAlignment = False
        Me.XrLabel35.Text = "Produtos"
        Me.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel34
        '
        Me.XrLabel34.CanGrow = False
        Me.XrLabel34.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel34.Location = New System.Drawing.Point(625, 17)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.Size = New System.Drawing.Size(50, 13)
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.StylePriority.UseTextAlignment = False
        Me.XrLabel34.Text = "Endereço"
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel34.WordWrap = False
        '
        'lblNum
        '
        Me.lblNum.CanGrow = False
        Me.lblNum.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.Location = New System.Drawing.Point(908, 27)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNum.Size = New System.Drawing.Size(75, 12)
        Me.lblNum.StylePriority.UseFont = False
        Me.lblNum.StylePriority.UseTextAlignment = False
        Me.lblNum.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'lblEnd
        '
        Me.lblEnd.CanGrow = False
        Me.lblEnd.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.Location = New System.Drawing.Point(625, 27)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblEnd.Size = New System.Drawing.Size(275, 12)
        Me.lblEnd.StylePriority.UseFont = False
        Me.lblEnd.StylePriority.UseTextAlignment = False
        Me.lblEnd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'lblCidade
        '
        Me.lblCidade.CanGrow = False
        Me.lblCidade.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCidade.Location = New System.Drawing.Point(625, 76)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblCidade.Size = New System.Drawing.Size(225, 12)
        Me.lblCidade.StylePriority.UseFont = False
        Me.lblCidade.StylePriority.UseTextAlignment = False
        Me.lblCidade.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'lblCep
        '
        Me.lblCep.CanGrow = False
        Me.lblCep.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCep.Location = New System.Drawing.Point(1000, 27)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblCep.Size = New System.Drawing.Size(83, 13)
        Me.lblCep.StylePriority.UseFont = False
        Me.lblCep.StylePriority.UseTextAlignment = False
        Me.lblCep.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'lblFax
        '
        Me.lblFax.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFax.Location = New System.Drawing.Point(117, 52)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblFax.Size = New System.Drawing.Size(108, 13)
        Me.lblFax.StylePriority.UseFont = False
        Me.lblFax.StylePriority.UseTextAlignment = False
        Me.lblFax.Text = " "
        Me.lblFax.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'lblTelefone
        '
        Me.lblTelefone.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefone.Location = New System.Drawing.Point(0, 52)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTelefone.Size = New System.Drawing.Size(108, 13)
        Me.lblTelefone.StylePriority.UseFont = False
        Me.lblTelefone.StylePriority.UseTextAlignment = False
        Me.lblTelefone.Text = " "
        Me.lblTelefone.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'lblEmail
        '
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(0, 76)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblEmail.Size = New System.Drawing.Size(375, 12)
        Me.lblEmail.StylePriority.UseFont = False
        Me.lblEmail.StylePriority.UseTextAlignment = False
        Me.lblEmail.Text = " "
        Me.lblEmail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'lblNome
        '
        Me.lblNome.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(0, 27)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNome.Size = New System.Drawing.Size(267, 12)
        Me.lblNome.StylePriority.UseFont = False
        Me.lblNome.StylePriority.UseTextAlignment = False
        Me.lblNome.Text = "EDER"
        Me.lblNome.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel4.BorderWidth = 0
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.ForeColor = System.Drawing.Color.Black
        Me.XrLabel4.Location = New System.Drawing.Point(0, 0)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.Size = New System.Drawing.Size(375, 15)
        Me.XrLabel4.StylePriority.UseBorderColor = False
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseBorderWidth = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Dados do Cliente"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblCPF
        '
        Me.lblCPF.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPF.Location = New System.Drawing.Point(267, 27)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblCPF.Size = New System.Drawing.Size(108, 13)
        Me.lblCPF.StylePriority.UseFont = False
        Me.lblCPF.StylePriority.UseTextAlignment = False
        Me.lblCPF.Text = " "
        Me.lblCPF.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel20
        '
        Me.XrLabel20.CanGrow = False
        Me.XrLabel20.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel20.Location = New System.Drawing.Point(267, 17)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.Size = New System.Drawing.Size(58, 13)
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "CPF/CNPJ"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel20.WordWrap = False
        '
        'relImpPedidos2Paisagem
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.GroupHeader1, Me.GroupFooter1, Me.GroupFooter3, Me.GroupFooter4, Me.GroupHeader2})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(30, 30, 30, 50)
        Me.PageHeight = 827
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.ShowPreviewMarginLines = False
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.XrControlStyle1})
        Me.Version = "8.2"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsPed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbPed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbServ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidoGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDescricaoPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDefeitos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblGar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents dsPed As System.Data.DataSet
    Friend WithEvents tbPed As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents WinControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents PedidoGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCPF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRealizado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents WinControlContainer2 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents tbServ As System.Data.DataTable
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents colUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents colFunc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblFones As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblEndereco As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblData As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblPedido As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Fax As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Telefone As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Email As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Nome As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblChassi As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblSaida As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblEntrada As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents KM As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Placa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Modelo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ano As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblGarantias As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblAssi As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblAut As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents linha7 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents c6 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Troco As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents c7 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Recebido As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents c5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents subTotal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents c3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Total As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents c2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Sevicos As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents c1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Pecas As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblRec As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents c4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Desconto As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblGar As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents lblDesc As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents GroupFooter3 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents GroupFooter4 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents colLocacao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblPed As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents colCódigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colServiços As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVlUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvlTot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUMSER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFuncServ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocacaoServ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVlUnit2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvlTot2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFuncionario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblDefeitos As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents picLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblKMSaida As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblDescricaoPedido As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents colCampoPedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents colCampoPedidoServ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents colFornecedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFornecedor2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel55 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblComplemento As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel53 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel52 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel51 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel50 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel49 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel48 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel47 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel46 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel44 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblBairro As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel42 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblSaida2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblEntrada2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblUF As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblNum As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblEnd As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblCidade As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblCep As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblFax As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTelefone As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblEmail As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblNome As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblFrete As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblVendedor As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents lblLabelVendedor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblCPF As DevExpress.XtraReports.UI.XRLabel
End Class
