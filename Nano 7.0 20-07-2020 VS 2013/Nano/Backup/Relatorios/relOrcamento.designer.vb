<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relOrcamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(relOrcamento))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel
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
        Me.tbServ = New System.Data.DataTable
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colC�digo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colServi�os = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.colQtde = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVlUnit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colvlTot = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUMSER = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFuncionario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLocacaoServ = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.PedidoGridControl = New DevExpress.XtraGrid.GridControl
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCod = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPlaca = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCPF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.colValorUnitario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRealizado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFunc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLocacao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lblAssi = New DevExpress.XtraReports.UI.XRLabel
        Me.lblAut = New DevExpress.XtraReports.UI.XRLabel
        Me.linha7 = New DevExpress.XtraReports.UI.XRLine
        Me.c7 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Troco = New DevExpress.XtraReports.UI.XRTableCell
        Me.c6 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Recebido = New DevExpress.XtraReports.UI.XRTableCell
        Me.c5 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.subTotal = New DevExpress.XtraReports.UI.XRTableCell
        Me.c4 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Desconto = New DevExpress.XtraReports.UI.XRTableCell
        Me.c3 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Total = New DevExpress.XtraReports.UI.XRTableCell
        Me.c2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Sevicos = New DevExpress.XtraReports.UI.XRTableCell
        Me.c1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Pecas = New DevExpress.XtraReports.UI.XRTableCell
        Me.lblPaga = New DevExpress.XtraReports.UI.XRLabel
        Me.lblRec = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel
        Me.WinControlContainer3 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.lblEndereco = New DevExpress.XtraReports.UI.XRLabel
        Me.lblFones = New DevExpress.XtraReports.UI.XRLabel
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.lblDescricaoPedido = New DevExpress.XtraReports.UI.XRRichText
        Me.lblPedido = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblMotor = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblComb = New DevExpress.XtraReports.UI.XRLabel
        Me.lblPrisma = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblChassi = New DevExpress.XtraReports.UI.XRLabel
        Me.Fax = New DevExpress.XtraReports.UI.XRLabel
        Me.Telefone = New DevExpress.XtraReports.UI.XRLabel
        Me.Cep = New DevExpress.XtraReports.UI.XRLabel
        Me.Cidade = New DevExpress.XtraReports.UI.XRLabel
        Me.Bairro = New DevExpress.XtraReports.UI.XRLabel
        Me.Estado = New DevExpress.XtraReports.UI.XRLabel
        Me.IE = New DevExpress.XtraReports.UI.XRLabel
        Me.Num = New DevExpress.XtraReports.UI.XRLabel
        Me.Endereco = New DevExpress.XtraReports.UI.XRLabel
        Me.CPF = New DevExpress.XtraReports.UI.XRLabel
        Me.Nome = New DevExpress.XtraReports.UI.XRLabel
        Me.Email = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblKMSaida = New DevExpress.XtraReports.UI.XRLabel
        Me.lblNivComb = New DevExpress.XtraReports.UI.XRLabel
        Me.lblNivCom = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblSaida = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblEntrada = New DevExpress.XtraReports.UI.XRLabel
        Me.KM = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblData = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel
        Me.Cor = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel
        Me.Placa = New DevExpress.XtraReports.UI.XRLabel
        Me.Modelo = New DevExpress.XtraReports.UI.XRLabel
        Me.Ano = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblAtendente = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.lblDesc = New DevExpress.XtraReports.UI.XRRichText
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupFooter3 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.lblDefeitos = New DevExpress.XtraReports.UI.XRRichText
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblGar = New DevExpress.XtraReports.UI.XRRichText
        Me.lblGarantias = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupFooter4 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.GroupFooter5 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsPed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbPed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbServ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDescricaoPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDefeitos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblGar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel22, Me.WinControlContainer2, Me.WinControlContainer1})
        Me.Detail.Height = 186
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel22
        '
        Me.XrLabel22.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.XrLabel22.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel22.Location = New System.Drawing.Point(0, 85)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.Size = New System.Drawing.Size(767, 15)
        Me.XrLabel22.StylePriority.UseBorders = False
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "Servi�os do Pedido"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'WinControlContainer2
        '
        Me.WinControlContainer2.Location = New System.Drawing.Point(0, 100)
        Me.WinControlContainer2.Name = "WinControlContainer2"
        Me.WinControlContainer2.Size = New System.Drawing.Size(758, 76)
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
        Me.GridControl1.Size = New System.Drawing.Size(728, 73)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        Me.GridControl1.Visible = False
        '
        'dsPed
        '
        Me.dsPed.DataSetName = "dsPed"
        Me.dsPed.Tables.AddRange(New System.Data.DataTable() {Me.tbPed, Me.tbServ})
        '
        'tbPed
        '
        Me.tbPed.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn11, Me.DataColumn13, Me.DataColumn15, Me.DataColumn16})
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
        Me.DataColumn3.ColumnName = "Descri��o"
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
        'tbServ
        '
        Me.tbServ.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn12, Me.DataColumn14, Me.DataColumn17})
        Me.tbServ.TableName = "tbServ"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "C�digo"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Servi�os"
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
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.GridView1.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.AppearancePrint.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.AppearancePrint.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.GridView1.AppearancePrint.HeaderPanel.Options.UseForeColor = True
        Me.GridView1.AppearancePrint.Preview.BackColor = System.Drawing.Color.White
        Me.GridView1.AppearancePrint.Preview.BorderColor = System.Drawing.Color.Black
        Me.GridView1.AppearancePrint.Preview.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.GridView1.AppearancePrint.Preview.ForeColor = System.Drawing.Color.Black
        Me.GridView1.AppearancePrint.Preview.Options.UseBackColor = True
        Me.GridView1.AppearancePrint.Preview.Options.UseBorderColor = True
        Me.GridView1.AppearancePrint.Preview.Options.UseFont = True
        Me.GridView1.AppearancePrint.Preview.Options.UseForeColor = True
        Me.GridView1.AppearancePrint.Row.BackColor = System.Drawing.Color.White
        Me.GridView1.AppearancePrint.Row.BorderColor = System.Drawing.Color.Black
        Me.GridView1.AppearancePrint.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.GridView1.AppearancePrint.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView1.AppearancePrint.Row.Options.UseBackColor = True
        Me.GridView1.AppearancePrint.Row.Options.UseBorderColor = True
        Me.GridView1.AppearancePrint.Row.Options.UseFont = True
        Me.GridView1.AppearancePrint.Row.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colC�digo, Me.colServi�os, Me.colQtde, Me.colVlUnit, Me.colvlTot, Me.colUMSER, Me.colFuncionario, Me.colLocacaoServ})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsPrint.UsePrintStyles = True
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowHorzLines = False
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.OptionsView.ShowPreviewLines = False
        Me.GridView1.OptionsView.ShowVertLines = False
        '
        'colC�digo
        '
        Me.colC�digo.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colC�digo.AppearanceCell.Options.UseFont = True
        Me.colC�digo.AppearanceCell.Options.UseTextOptions = True
        Me.colC�digo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colC�digo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colC�digo.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colC�digo.AppearanceHeader.Options.UseBackColor = True
        Me.colC�digo.AppearanceHeader.Options.UseFont = True
        Me.colC�digo.Caption = "C�digo"
        Me.colC�digo.FieldName = "C�digo"
        Me.colC�digo.Name = "colC�digo"
        Me.colC�digo.Visible = True
        Me.colC�digo.VisibleIndex = 0
        Me.colC�digo.Width = 120
        '
        'colServi�os
        '
        Me.colServi�os.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colServi�os.AppearanceCell.Options.UseFont = True
        Me.colServi�os.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colServi�os.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colServi�os.AppearanceHeader.Options.UseBackColor = True
        Me.colServi�os.AppearanceHeader.Options.UseFont = True
        Me.colServi�os.Caption = "Descri��o dos Servi�os"
        Me.colServi�os.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colServi�os.FieldName = "Servi�os"
        Me.colServi�os.Name = "colServi�os"
        Me.colServi�os.Visible = True
        Me.colServi�os.VisibleIndex = 1
        Me.colServi�os.Width = 554
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'colQtde
        '
        Me.colQtde.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colQtde.AppearanceCell.Options.UseFont = True
        Me.colQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtde.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colQtde.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colQtde.AppearanceHeader.Options.UseBackColor = True
        Me.colQtde.AppearanceHeader.Options.UseFont = True
        Me.colQtde.Caption = "Qtde"
        Me.colQtde.FieldName = "Qtde"
        Me.colQtde.Name = "colQtde"
        Me.colQtde.Visible = True
        Me.colQtde.VisibleIndex = 4
        '
        'colVlUnit
        '
        Me.colVlUnit.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colVlUnit.AppearanceCell.Options.UseFont = True
        Me.colVlUnit.AppearanceCell.Options.UseTextOptions = True
        Me.colVlUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colVlUnit.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colVlUnit.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVlUnit.AppearanceHeader.Options.UseBackColor = True
        Me.colVlUnit.AppearanceHeader.Options.UseFont = True
        Me.colVlUnit.Caption = "Valor Unit. R$"
        Me.colVlUnit.FieldName = "VlUnit"
        Me.colVlUnit.Name = "colVlUnit"
        Me.colVlUnit.Visible = True
        Me.colVlUnit.VisibleIndex = 5
        Me.colVlUnit.Width = 133
        '
        'colvlTot
        '
        Me.colvlTot.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colvlTot.AppearanceCell.Options.UseFont = True
        Me.colvlTot.AppearanceCell.Options.UseTextOptions = True
        Me.colvlTot.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colvlTot.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colvlTot.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colvlTot.AppearanceHeader.Options.UseBackColor = True
        Me.colvlTot.AppearanceHeader.Options.UseFont = True
        Me.colvlTot.Caption = "Valor Total R$"
        Me.colvlTot.FieldName = "vlTot"
        Me.colvlTot.Name = "colvlTot"
        Me.colvlTot.Visible = True
        Me.colvlTot.VisibleIndex = 6
        Me.colvlTot.Width = 152
        '
        'colUMSER
        '
        Me.colUMSER.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colUMSER.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colUMSER.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colUMSER.AppearanceCell.Options.UseBackColor = True
        Me.colUMSER.AppearanceCell.Options.UseFont = True
        Me.colUMSER.AppearanceCell.Options.UseForeColor = True
        Me.colUMSER.AppearanceCell.Options.UseTextOptions = True
        Me.colUMSER.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUMSER.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colUMSER.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUMSER.AppearanceHeader.Options.UseBackColor = True
        Me.colUMSER.AppearanceHeader.Options.UseFont = True
        Me.colUMSER.Caption = "U.M."
        Me.colUMSER.FieldName = "UMSER"
        Me.colUMSER.Name = "colUMSER"
        Me.colUMSER.Visible = True
        Me.colUMSER.VisibleIndex = 2
        Me.colUMSER.Width = 43
        '
        'colFuncionario
        '
        Me.colFuncionario.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colFuncionario.AppearanceCell.Options.UseFont = True
        Me.colFuncionario.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colFuncionario.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFuncionario.AppearanceHeader.Options.UseBackColor = True
        Me.colFuncionario.AppearanceHeader.Options.UseFont = True
        Me.colFuncionario.Caption = "Func."
        Me.colFuncionario.FieldName = "FUNC"
        Me.colFuncionario.Name = "colFuncionario"
        Me.colFuncionario.Visible = True
        Me.colFuncionario.VisibleIndex = 3
        Me.colFuncionario.Width = 114
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
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.Location = New System.Drawing.Point(0, 0)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.Size = New System.Drawing.Size(758, 68)
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
        Me.PedidoGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit2})
        Me.PedidoGridControl.Size = New System.Drawing.Size(728, 65)
        Me.PedidoGridControl.TabIndex = 0
        Me.PedidoGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'grd1
        '
        Me.grd1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.grd1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grd1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grd1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grd1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.grd1.Appearance.HeaderPanel.Options.UseFont = True
        Me.grd1.Appearance.Row.Options.UseFont = True
        Me.grd1.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.grd1.AppearancePrint.EvenRow.Options.UseFont = True
        Me.grd1.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grd1.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.AppearancePrint.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseBackColor = True
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseForeColor = True
        Me.grd1.AppearancePrint.Preview.BackColor = System.Drawing.Color.White
        Me.grd1.AppearancePrint.Preview.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.grd1.AppearancePrint.Preview.ForeColor = System.Drawing.Color.Black
        Me.grd1.AppearancePrint.Preview.Options.UseBackColor = True
        Me.grd1.AppearancePrint.Preview.Options.UseFont = True
        Me.grd1.AppearancePrint.Preview.Options.UseForeColor = True
        Me.grd1.AppearancePrint.Row.BackColor = System.Drawing.Color.White
        Me.grd1.AppearancePrint.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.grd1.AppearancePrint.Row.ForeColor = System.Drawing.Color.Black
        Me.grd1.AppearancePrint.Row.Options.UseBackColor = True
        Me.grd1.AppearancePrint.Row.Options.UseFont = True
        Me.grd1.AppearancePrint.Row.Options.UseForeColor = True
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colCod, Me.colPlaca, Me.colData, Me.colCliente, Me.colCPF, Me.colQtd, Me.colCodigoProduto, Me.colProduto, Me.colValorUnitario, Me.colValorTotal, Me.colKM, Me.colRealizado, Me.colUM, Me.colFunc, Me.colLocacao})
        Me.grd1.GridControl = Me.PedidoGridControl
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsPrint.UsePrintStyles = True
        Me.grd1.OptionsView.RowAutoHeight = True
        Me.grd1.OptionsView.ShowDetailButtons = False
        Me.grd1.OptionsView.ShowGroupPanel = False
        Me.grd1.OptionsView.ShowHorzLines = False
        Me.grd1.OptionsView.ShowIndicator = False
        Me.grd1.OptionsView.ShowPreviewLines = False
        Me.grd1.OptionsView.ShowVertLines = False
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colCodigo.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colCodigo.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colCodigo.AppearanceCell.Options.UseBackColor = True
        Me.colCodigo.AppearanceCell.Options.UseFont = True
        Me.colCodigo.AppearanceCell.Options.UseForeColor = True
        Me.colCodigo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodigo.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
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
        Me.colCod.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colCod.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colCod.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colCod.AppearanceCell.Options.UseBackColor = True
        Me.colCod.AppearanceCell.Options.UseFont = True
        Me.colCod.AppearanceCell.Options.UseForeColor = True
        Me.colCod.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCod.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
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
        Me.colPlaca.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colPlaca.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colPlaca.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colPlaca.AppearanceCell.Options.UseBackColor = True
        Me.colPlaca.AppearanceCell.Options.UseFont = True
        Me.colPlaca.AppearanceCell.Options.UseForeColor = True
        Me.colPlaca.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colPlaca.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
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
        Me.colData.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colData.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colData.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colData.AppearanceCell.Options.UseBackColor = True
        Me.colData.AppearanceCell.Options.UseFont = True
        Me.colData.AppearanceCell.Options.UseForeColor = True
        Me.colData.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colData.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
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
        Me.colCliente.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colCliente.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colCliente.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colCliente.AppearanceCell.Options.UseBackColor = True
        Me.colCliente.AppearanceCell.Options.UseFont = True
        Me.colCliente.AppearanceCell.Options.UseForeColor = True
        Me.colCliente.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCliente.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
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
        Me.colCPF.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colCPF.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colCPF.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colCPF.AppearanceCell.Options.UseBackColor = True
        Me.colCPF.AppearanceCell.Options.UseFont = True
        Me.colCPF.AppearanceCell.Options.UseForeColor = True
        Me.colCPF.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCPF.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCPF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colCPF.AppearanceHeader.Options.UseBackColor = True
        Me.colCPF.AppearanceHeader.Options.UseFont = True
        Me.colCPF.AppearanceHeader.Options.UseForeColor = True
        Me.colCPF.Caption = "CPF"
        Me.colCPF.FieldName = "CPF"
        Me.colCPF.Name = "colCPF"
        Me.colCPF.Width = 57
        '
        'colQtd
        '
        Me.colQtd.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colQtd.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colQtd.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colQtd.AppearanceCell.Options.UseBackColor = True
        Me.colQtd.AppearanceCell.Options.UseFont = True
        Me.colQtd.AppearanceCell.Options.UseForeColor = True
        Me.colQtd.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtd.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colQtd.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colQtd.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colQtd.AppearanceHeader.Options.UseBackColor = True
        Me.colQtd.AppearanceHeader.Options.UseFont = True
        Me.colQtd.AppearanceHeader.Options.UseForeColor = True
        Me.colQtd.Caption = "Qtde"
        Me.colQtd.FieldName = "Qtde"
        Me.colQtd.Name = "colQtd"
        Me.colQtd.OptionsColumn.ReadOnly = True
        Me.colQtd.Visible = True
        Me.colQtd.VisibleIndex = 4
        Me.colQtd.Width = 74
        '
        'colCodigoProduto
        '
        Me.colCodigoProduto.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colCodigoProduto.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colCodigoProduto.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colCodigoProduto.AppearanceCell.Options.UseBackColor = True
        Me.colCodigoProduto.AppearanceCell.Options.UseFont = True
        Me.colCodigoProduto.AppearanceCell.Options.UseForeColor = True
        Me.colCodigoProduto.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoProduto.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodigoProduto.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoProduto.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colCodigoProduto.AppearanceHeader.Options.UseBackColor = True
        Me.colCodigoProduto.AppearanceHeader.Options.UseFont = True
        Me.colCodigoProduto.AppearanceHeader.Options.UseForeColor = True
        Me.colCodigoProduto.Caption = "C�digo"
        Me.colCodigoProduto.FieldName = "CodigoPeca"
        Me.colCodigoProduto.Name = "colCodigoProduto"
        Me.colCodigoProduto.Visible = True
        Me.colCodigoProduto.VisibleIndex = 0
        Me.colCodigoProduto.Width = 122
        '
        'colProduto
        '
        Me.colProduto.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colProduto.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colProduto.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colProduto.AppearanceCell.Options.UseBackColor = True
        Me.colProduto.AppearanceCell.Options.UseFont = True
        Me.colProduto.AppearanceCell.Options.UseForeColor = True
        Me.colProduto.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colProduto.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colProduto.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colProduto.AppearanceHeader.Options.UseBackColor = True
        Me.colProduto.AppearanceHeader.Options.UseFont = True
        Me.colProduto.AppearanceHeader.Options.UseForeColor = True
        Me.colProduto.Caption = "Descri��o das Pe�as"
        Me.colProduto.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.colProduto.FieldName = "Descri��o"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 1
        Me.colProduto.Width = 553
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'colValorUnitario
        '
        Me.colValorUnitario.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colValorUnitario.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colValorUnitario.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colValorUnitario.AppearanceCell.Options.UseBackColor = True
        Me.colValorUnitario.AppearanceCell.Options.UseFont = True
        Me.colValorUnitario.AppearanceCell.Options.UseForeColor = True
        Me.colValorUnitario.AppearanceCell.Options.UseTextOptions = True
        Me.colValorUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorUnitario.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValorUnitario.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValorUnitario.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colValorUnitario.AppearanceHeader.Options.UseBackColor = True
        Me.colValorUnitario.AppearanceHeader.Options.UseFont = True
        Me.colValorUnitario.AppearanceHeader.Options.UseForeColor = True
        Me.colValorUnitario.Caption = "Valor Unit. R$"
        Me.colValorUnitario.FieldName = "ValorUnitR"
        Me.colValorUnitario.Name = "colValorUnitario"
        Me.colValorUnitario.OptionsColumn.ReadOnly = True
        Me.colValorUnitario.Visible = True
        Me.colValorUnitario.VisibleIndex = 5
        Me.colValorUnitario.Width = 138
        '
        'colValorTotal
        '
        Me.colValorTotal.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colValorTotal.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colValorTotal.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colValorTotal.AppearanceCell.Options.UseBackColor = True
        Me.colValorTotal.AppearanceCell.Options.UseFont = True
        Me.colValorTotal.AppearanceCell.Options.UseForeColor = True
        Me.colValorTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colValorTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorTotal.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValorTotal.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValorTotal.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colValorTotal.AppearanceHeader.Options.UseBackColor = True
        Me.colValorTotal.AppearanceHeader.Options.UseFont = True
        Me.colValorTotal.AppearanceHeader.Options.UseForeColor = True
        Me.colValorTotal.Caption = "Valor Total R$"
        Me.colValorTotal.FieldName = "Total"
        Me.colValorTotal.Name = "colValorTotal"
        Me.colValorTotal.OptionsColumn.ReadOnly = True
        Me.colValorTotal.Visible = True
        Me.colValorTotal.VisibleIndex = 6
        Me.colValorTotal.Width = 149
        '
        'colKM
        '
        Me.colKM.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colKM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colKM.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colKM.AppearanceCell.Options.UseBackColor = True
        Me.colKM.AppearanceCell.Options.UseFont = True
        Me.colKM.AppearanceCell.Options.UseForeColor = True
        Me.colKM.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colKM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
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
        Me.colRealizado.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colRealizado.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colRealizado.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colRealizado.AppearanceCell.Options.UseBackColor = True
        Me.colRealizado.AppearanceCell.Options.UseFont = True
        Me.colRealizado.AppearanceCell.Options.UseForeColor = True
        Me.colRealizado.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colRealizado.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
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
        Me.colUM.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colUM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colUM.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colUM.AppearanceCell.Options.UseBackColor = True
        Me.colUM.AppearanceCell.Options.UseFont = True
        Me.colUM.AppearanceCell.Options.UseForeColor = True
        Me.colUM.AppearanceCell.Options.UseTextOptions = True
        Me.colUM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUM.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colUM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colUM.AppearanceHeader.Options.UseBackColor = True
        Me.colUM.AppearanceHeader.Options.UseFont = True
        Me.colUM.AppearanceHeader.Options.UseForeColor = True
        Me.colUM.Caption = "U.M."
        Me.colUM.FieldName = "UM"
        Me.colUM.Name = "colUM"
        Me.colUM.Visible = True
        Me.colUM.VisibleIndex = 2
        Me.colUM.Width = 42
        '
        'colFunc
        '
        Me.colFunc.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colFunc.AppearanceCell.Options.UseFont = True
        Me.colFunc.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colFunc.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFunc.AppearanceHeader.Options.UseBackColor = True
        Me.colFunc.AppearanceHeader.Options.UseFont = True
        Me.colFunc.Caption = "Func."
        Me.colFunc.FieldName = "Func"
        Me.colFunc.Name = "colFunc"
        Me.colFunc.Visible = True
        Me.colFunc.VisibleIndex = 3
        Me.colFunc.Width = 113
        '
        'colLocacao
        '
        Me.colLocacao.AppearanceCell.Options.UseTextOptions = True
        Me.colLocacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLocacao.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colLocacao.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colLocacao.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colLocacao.AppearanceHeader.Options.UseBackColor = True
        Me.colLocacao.AppearanceHeader.Options.UseFont = True
        Me.colLocacao.AppearanceHeader.Options.UseForeColor = True
        Me.colLocacao.Caption = "Loc."
        Me.colLocacao.FieldName = "Locacao"
        Me.colLocacao.Name = "colLocacao"
        Me.colLocacao.Width = 80
        '
        'lblAssi
        '
        Me.lblAssi.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblAssi.Location = New System.Drawing.Point(433, 50)
        Me.lblAssi.Name = "lblAssi"
        Me.lblAssi.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblAssi.Size = New System.Drawing.Size(317, 17)
        Me.lblAssi.StylePriority.UseFont = False
        Me.lblAssi.StylePriority.UseTextAlignment = False
        Me.lblAssi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblAut
        '
        Me.lblAut.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblAut.Location = New System.Drawing.Point(433, 8)
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
        Me.linha7.Location = New System.Drawing.Point(450, 42)
        Me.linha7.Name = "linha7"
        Me.linha7.Size = New System.Drawing.Size(283, 8)
        '
        'c7
        '
        Me.c7.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.c7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.c7.Location = New System.Drawing.Point(508, 123)
        Me.c7.Name = "c7"
        Me.c7.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow6})
        Me.c7.Size = New System.Drawing.Size(258, 15)
        Me.c7.StylePriority.UseBorders = False
        Me.c7.StylePriority.UseFont = False
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell6, Me.Troco})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Size = New System.Drawing.Size(258, 15)
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell6.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell6.Size = New System.Drawing.Size(128, 15)
        Me.XrTableCell6.StylePriority.UseFont = False
        Me.XrTableCell6.StylePriority.UseTextAlignment = False
        Me.XrTableCell6.Text = "Troco R$"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Troco
        '
        Me.Troco.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Troco.Location = New System.Drawing.Point(128, 0)
        Me.Troco.Name = "Troco"
        Me.Troco.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Troco.Size = New System.Drawing.Size(130, 15)
        Me.Troco.StylePriority.UseFont = False
        Me.Troco.StylePriority.UseTextAlignment = False
        Me.Troco.Text = "0,00"
        Me.Troco.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'c6
        '
        Me.c6.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.c6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.c6.Location = New System.Drawing.Point(508, 108)
        Me.c6.Name = "c6"
        Me.c6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow5})
        Me.c6.Size = New System.Drawing.Size(258, 15)
        Me.c6.StylePriority.UseBorders = False
        Me.c6.StylePriority.UseFont = False
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell5, Me.Recebido})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Size = New System.Drawing.Size(258, 15)
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell5.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell5.Size = New System.Drawing.Size(128, 15)
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "Recebido R$"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Recebido
        '
        Me.Recebido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Recebido.Location = New System.Drawing.Point(128, 0)
        Me.Recebido.Name = "Recebido"
        Me.Recebido.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Recebido.Size = New System.Drawing.Size(130, 15)
        Me.Recebido.StylePriority.UseFont = False
        Me.Recebido.StylePriority.UseTextAlignment = False
        Me.Recebido.Text = "0,00"
        Me.Recebido.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'c5
        '
        Me.c5.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.c5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.c5.Location = New System.Drawing.Point(508, 93)
        Me.c5.Name = "c5"
        Me.c5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.c5.Size = New System.Drawing.Size(258, 15)
        Me.c5.StylePriority.UseBorders = False
        Me.c5.StylePriority.UseFont = False
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.subTotal})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Size = New System.Drawing.Size(258, 15)
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell4.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell4.Size = New System.Drawing.Size(128, 15)
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.Text = "Sub Total R$"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'subTotal
        '
        Me.subTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.subTotal.Location = New System.Drawing.Point(128, 0)
        Me.subTotal.Name = "subTotal"
        Me.subTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.subTotal.Size = New System.Drawing.Size(130, 15)
        Me.subTotal.StylePriority.UseFont = False
        Me.subTotal.StylePriority.UseTextAlignment = False
        Me.subTotal.Text = "0,00"
        Me.subTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'c4
        '
        Me.c4.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.c4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.c4.Location = New System.Drawing.Point(508, 78)
        Me.c4.Name = "c4"
        Me.c4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.c4.Size = New System.Drawing.Size(258, 15)
        Me.c4.StylePriority.UseBorders = False
        Me.c4.StylePriority.UseFont = False
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell3, Me.Desconto})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Size = New System.Drawing.Size(258, 15)
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell3.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell3.Size = New System.Drawing.Size(128, 15)
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "Desconto R$"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Desconto
        '
        Me.Desconto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Desconto.Location = New System.Drawing.Point(128, 0)
        Me.Desconto.Name = "Desconto"
        Me.Desconto.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Desconto.Size = New System.Drawing.Size(130, 15)
        Me.Desconto.StylePriority.UseFont = False
        Me.Desconto.StylePriority.UseTextAlignment = False
        Me.Desconto.Text = "0,00"
        Me.Desconto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'c3
        '
        Me.c3.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.c3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.c3.Location = New System.Drawing.Point(508, 63)
        Me.c3.Name = "c3"
        Me.c3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.c3.Size = New System.Drawing.Size(258, 15)
        Me.c3.StylePriority.UseBorders = False
        Me.c3.StylePriority.UseFont = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.Total})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(258, 15)
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell1.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell1.Size = New System.Drawing.Size(128, 15)
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "Total R$"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Total
        '
        Me.Total.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Total.Location = New System.Drawing.Point(128, 0)
        Me.Total.Name = "Total"
        Me.Total.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Total.Size = New System.Drawing.Size(130, 15)
        Me.Total.StylePriority.UseFont = False
        Me.Total.StylePriority.UseTextAlignment = False
        Me.Total.Text = "0,00"
        Me.Total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'c2
        '
        Me.c2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.c2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.c2.Location = New System.Drawing.Point(508, 48)
        Me.c2.Name = "c2"
        Me.c2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.c2.Size = New System.Drawing.Size(258, 15)
        Me.c2.StylePriority.UseBorders = False
        Me.c2.StylePriority.UseFont = False
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.Sevicos})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Size = New System.Drawing.Size(258, 15)
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell2.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell2.Size = New System.Drawing.Size(128, 15)
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.Text = "Total Servi�os R$"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Sevicos
        '
        Me.Sevicos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Sevicos.Location = New System.Drawing.Point(128, 0)
        Me.Sevicos.Name = "Sevicos"
        Me.Sevicos.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Sevicos.Size = New System.Drawing.Size(130, 15)
        Me.Sevicos.StylePriority.UseFont = False
        Me.Sevicos.StylePriority.UseTextAlignment = False
        Me.Sevicos.Text = "0,00"
        Me.Sevicos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'c1
        '
        Me.c1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.c1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.c1.Location = New System.Drawing.Point(508, 33)
        Me.c1.Name = "c1"
        Me.c1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow8})
        Me.c1.Size = New System.Drawing.Size(258, 15)
        Me.c1.StylePriority.UseBorders = False
        Me.c1.StylePriority.UseFont = False
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell9, Me.Pecas})
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Size = New System.Drawing.Size(258, 15)
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell9.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell9.Size = New System.Drawing.Size(128, 15)
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "Total Pe�as R$"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Pecas
        '
        Me.Pecas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Pecas.Location = New System.Drawing.Point(128, 0)
        Me.Pecas.Name = "Pecas"
        Me.Pecas.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Pecas.Size = New System.Drawing.Size(130, 15)
        Me.Pecas.StylePriority.UseFont = False
        Me.Pecas.StylePriority.UseTextAlignment = False
        Me.Pecas.Text = "0,00"
        Me.Pecas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblPaga
        '
        Me.lblPaga.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lblPaga.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblPaga.Location = New System.Drawing.Point(0, 92)
        Me.lblPaga.Name = "lblPaga"
        Me.lblPaga.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPaga.Size = New System.Drawing.Size(275, 12)
        Me.lblPaga.StylePriority.UseBorders = False
        Me.lblPaga.StylePriority.UseFont = False
        Me.lblPaga.StylePriority.UseTextAlignment = False
        Me.lblPaga.Text = "Pagamento"
        Me.lblPaga.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblRec
        '
        Me.lblRec.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblRec.Location = New System.Drawing.Point(0, 106)
        Me.lblRec.Multiline = True
        Me.lblRec.Name = "lblRec"
        Me.lblRec.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblRec.Size = New System.Drawing.Size(483, 25)
        Me.lblRec.StylePriority.UseFont = False
        Me.lblRec.StylePriority.UseTextAlignment = False
        Me.lblRec.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.Location = New System.Drawing.Point(0, 7)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.Size = New System.Drawing.Size(767, 15)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Dados Adicionais"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageHeader
        '
        Me.PageHeader.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel1})
        Me.PageHeader.Height = 89
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.StylePriority.UseBorders = False
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPanel1
        '
        Me.XrPanel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.WinControlContainer3, Me.lblEndereco, Me.lblFones, Me.lblTitulo})
        Me.XrPanel1.Location = New System.Drawing.Point(0, 0)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.Size = New System.Drawing.Size(767, 80)
        Me.XrPanel1.StylePriority.UseBorders = False
        '
        'WinControlContainer3
        '
        Me.WinControlContainer3.Location = New System.Drawing.Point(17, 8)
        Me.WinControlContainer3.Name = "WinControlContainer3"
        Me.WinControlContainer3.Size = New System.Drawing.Size(158, 65)
        Me.WinControlContainer3.WinControl = Me.picLogo
        '
        'picLogo
        '
        Me.picLogo.ImageLocation = ""
        Me.picLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picLogo.Location = New System.Drawing.Point(10, 69)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(150, 60)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'lblEndereco
        '
        Me.lblEndereco.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblEndereco.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.lblEndereco.Location = New System.Drawing.Point(200, 54)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblEndereco.Size = New System.Drawing.Size(525, 18)
        Me.lblEndereco.StylePriority.UseBorders = False
        Me.lblEndereco.StylePriority.UseFont = False
        Me.lblEndereco.StylePriority.UseTextAlignment = False
        Me.lblEndereco.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblFones
        '
        Me.lblFones.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblFones.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.lblFones.Location = New System.Drawing.Point(200, 33)
        Me.lblFones.Name = "lblFones"
        Me.lblFones.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblFones.Size = New System.Drawing.Size(525, 18)
        Me.lblFones.StylePriority.UseBorders = False
        Me.lblFones.StylePriority.UseFont = False
        Me.lblFones.StylePriority.UseTextAlignment = False
        Me.lblFones.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblTitulo
        '
        Me.lblTitulo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Location = New System.Drawing.Point(200, 8)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitulo.Size = New System.Drawing.Size(525, 22)
        Me.lblTitulo.StylePriority.UseBorders = False
        Me.lblTitulo.StylePriority.UseFont = False
        Me.lblTitulo.StylePriority.UseTextAlignment = False
        Me.lblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2, Me.XrPageInfo1, Me.lblDescricaoPedido})
        Me.PageFooter.Height = 50
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo2.Location = New System.Drawing.Point(317, 33)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.Size = New System.Drawing.Size(125, 17)
        Me.XrPageInfo2.StylePriority.UseFont = False
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.Location = New System.Drawing.Point(492, 33)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.Size = New System.Drawing.Size(267, 17)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblDescricaoPedido
        '
        Me.lblDescricaoPedido.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescricaoPedido.Location = New System.Drawing.Point(0, 0)
        Me.lblDescricaoPedido.Name = "lblDescricaoPedido"
        Me.lblDescricaoPedido.SerializableRtfString = resources.GetString("lblDescricaoPedido.SerializableRtfString")
        Me.lblDescricaoPedido.Size = New System.Drawing.Size(758, 25)
        Me.lblDescricaoPedido.StylePriority.UseFont = False
        '
        'lblPedido
        '
        Me.lblPedido.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPedido.Location = New System.Drawing.Point(250, 0)
        Me.lblPedido.Name = "lblPedido"
        Me.lblPedido.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPedido.Size = New System.Drawing.Size(275, 17)
        Me.lblPedido.StylePriority.UseFont = False
        Me.lblPedido.StylePriority.UseTextAlignment = False
        Me.lblPedido.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel37, Me.lblMotor, Me.XrLabel34, Me.lblComb, Me.lblPrisma, Me.XrLabel4, Me.XrLabel35, Me.lblChassi, Me.Fax, Me.Telefone, Me.Cep, Me.Cidade, Me.Bairro, Me.Estado, Me.IE, Me.Num, Me.Endereco, Me.CPF, Me.Nome, Me.Email, Me.XrLabel28, Me.XrLabel25, Me.XrLabel24, Me.XrLabel21, Me.XrLabel20, Me.XrLabel19, Me.XrLabel18, Me.XrLabel17, Me.XrLabel15, Me.XrLabel13, Me.XrLabel11, Me.XrLabel10, Me.XrLabel14, Me.lblKMSaida, Me.lblNivComb, Me.lblNivCom, Me.XrLabel9, Me.lblSaida, Me.XrLabel5, Me.lblEntrada, Me.KM, Me.XrLabel3, Me.XrLabel7, Me.lblData, Me.XrLabel16, Me.lblPedido, Me.XrLabel30, Me.XrLabel32, Me.XrLabel33, Me.Cor, Me.XrLabel31, Me.Placa, Me.Modelo, Me.Ano, Me.XrLabel29, Me.XrLabel1})
        Me.GroupHeader1.Height = 215
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel37
        '
        Me.XrLabel37.CanGrow = False
        Me.XrLabel37.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel37.Location = New System.Drawing.Point(0, 158)
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel37.Size = New System.Drawing.Size(58, 17)
        Me.XrLabel37.StylePriority.UseFont = False
        Me.XrLabel37.StylePriority.UseTextAlignment = False
        Me.XrLabel37.Text = "Motor:"
        Me.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel37.WordWrap = False
        '
        'lblMotor
        '
        Me.lblMotor.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblMotor.Location = New System.Drawing.Point(58, 158)
        Me.lblMotor.Name = "lblMotor"
        Me.lblMotor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblMotor.Size = New System.Drawing.Size(133, 17)
        Me.lblMotor.StylePriority.UseFont = False
        Me.lblMotor.StylePriority.UseTextAlignment = False
        Me.lblMotor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel34
        '
        Me.XrLabel34.CanGrow = False
        Me.XrLabel34.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel34.Location = New System.Drawing.Point(192, 158)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.Size = New System.Drawing.Size(67, 17)
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.StylePriority.UseTextAlignment = False
        Me.XrLabel34.Text = "Comb.:"
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel34.WordWrap = False
        '
        'lblComb
        '
        Me.lblComb.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblComb.Location = New System.Drawing.Point(258, 158)
        Me.lblComb.Name = "lblComb"
        Me.lblComb.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblComb.Size = New System.Drawing.Size(133, 17)
        Me.lblComb.StylePriority.UseFont = False
        Me.lblComb.StylePriority.UseTextAlignment = False
        Me.lblComb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblPrisma
        '
        Me.lblPrisma.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblPrisma.Location = New System.Drawing.Point(650, 158)
        Me.lblPrisma.Name = "lblPrisma"
        Me.lblPrisma.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPrisma.Size = New System.Drawing.Size(108, 17)
        Me.lblPrisma.StylePriority.UseFont = False
        Me.lblPrisma.StylePriority.UseTextAlignment = False
        Me.lblPrisma.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.lblPrisma.Visible = False
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.Location = New System.Drawing.Point(575, 158)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.Size = New System.Drawing.Size(75, 17)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Motor:"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel4.Visible = False
        '
        'XrLabel35
        '
        Me.XrLabel35.CanGrow = False
        Me.XrLabel35.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel35.Location = New System.Drawing.Point(0, 175)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel35.Size = New System.Drawing.Size(58, 17)
        Me.XrLabel35.StylePriority.UseFont = False
        Me.XrLabel35.StylePriority.UseTextAlignment = False
        Me.XrLabel35.Text = "Chassi:"
        Me.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel35.WordWrap = False
        '
        'lblChassi
        '
        Me.lblChassi.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblChassi.Location = New System.Drawing.Point(58, 175)
        Me.lblChassi.Name = "lblChassi"
        Me.lblChassi.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblChassi.Size = New System.Drawing.Size(308, 17)
        Me.lblChassi.StylePriority.UseFont = False
        Me.lblChassi.StylePriority.UseTextAlignment = False
        Me.lblChassi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Fax
        '
        Me.Fax.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Fax.Location = New System.Drawing.Point(650, 75)
        Me.Fax.Name = "Fax"
        Me.Fax.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Fax.Size = New System.Drawing.Size(108, 17)
        Me.Fax.StylePriority.UseFont = False
        Me.Fax.StylePriority.UseTextAlignment = False
        Me.Fax.Text = " "
        Me.Fax.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Telefone
        '
        Me.Telefone.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Telefone.Location = New System.Drawing.Point(442, 75)
        Me.Telefone.Name = "Telefone"
        Me.Telefone.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Telefone.Size = New System.Drawing.Size(133, 17)
        Me.Telefone.StylePriority.UseFont = False
        Me.Telefone.StylePriority.UseTextAlignment = False
        Me.Telefone.Text = " "
        Me.Telefone.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Cep
        '
        Me.Cep.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Cep.Location = New System.Drawing.Point(650, 42)
        Me.Cep.Name = "Cep"
        Me.Cep.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cep.Size = New System.Drawing.Size(108, 17)
        Me.Cep.StylePriority.UseFont = False
        Me.Cep.StylePriority.UseTextAlignment = False
        Me.Cep.Text = " "
        Me.Cep.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Cidade
        '
        Me.Cidade.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Cidade.Location = New System.Drawing.Point(442, 58)
        Me.Cidade.Name = "Cidade"
        Me.Cidade.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cidade.Size = New System.Drawing.Size(133, 17)
        Me.Cidade.StylePriority.UseFont = False
        Me.Cidade.StylePriority.UseTextAlignment = False
        Me.Cidade.Text = " "
        Me.Cidade.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Bairro
        '
        Me.Bairro.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Bairro.Location = New System.Drawing.Point(59, 58)
        Me.Bairro.Name = "Bairro"
        Me.Bairro.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Bairro.Size = New System.Drawing.Size(324, 17)
        Me.Bairro.StylePriority.UseFont = False
        Me.Bairro.StylePriority.UseTextAlignment = False
        Me.Bairro.Text = " "
        Me.Bairro.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Estado
        '
        Me.Estado.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Estado.Location = New System.Drawing.Point(650, 58)
        Me.Estado.Name = "Estado"
        Me.Estado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Estado.Size = New System.Drawing.Size(108, 17)
        Me.Estado.StylePriority.UseFont = False
        Me.Estado.StylePriority.UseTextAlignment = False
        Me.Estado.Text = " "
        Me.Estado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'IE
        '
        Me.IE.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.IE.Location = New System.Drawing.Point(442, 25)
        Me.IE.Name = "IE"
        Me.IE.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.IE.Size = New System.Drawing.Size(133, 16)
        Me.IE.StylePriority.UseFont = False
        Me.IE.StylePriority.UseTextAlignment = False
        Me.IE.Text = " "
        Me.IE.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Num
        '
        Me.Num.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Num.Location = New System.Drawing.Point(442, 42)
        Me.Num.Name = "Num"
        Me.Num.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Num.Size = New System.Drawing.Size(133, 17)
        Me.Num.StylePriority.UseFont = False
        Me.Num.StylePriority.UseTextAlignment = False
        Me.Num.Text = " "
        Me.Num.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Endereco
        '
        Me.Endereco.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Endereco.Location = New System.Drawing.Point(59, 42)
        Me.Endereco.Name = "Endereco"
        Me.Endereco.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Endereco.Size = New System.Drawing.Size(324, 16)
        Me.Endereco.StylePriority.UseFont = False
        Me.Endereco.StylePriority.UseTextAlignment = False
        Me.Endereco.Text = " "
        Me.Endereco.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'CPF
        '
        Me.CPF.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.CPF.Location = New System.Drawing.Point(650, 25)
        Me.CPF.Name = "CPF"
        Me.CPF.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.CPF.Size = New System.Drawing.Size(108, 17)
        Me.CPF.StylePriority.UseFont = False
        Me.CPF.StylePriority.UseTextAlignment = False
        Me.CPF.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Nome
        '
        Me.Nome.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Nome.Location = New System.Drawing.Point(59, 25)
        Me.Nome.Name = "Nome"
        Me.Nome.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nome.Size = New System.Drawing.Size(324, 17)
        Me.Nome.StylePriority.UseFont = False
        Me.Nome.StylePriority.UseTextAlignment = False
        Me.Nome.Text = " EDER RODRIGUES DE ARA�JO"
        Me.Nome.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Email
        '
        Me.Email.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Email.Location = New System.Drawing.Point(58, 75)
        Me.Email.Name = "Email"
        Me.Email.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Email.Size = New System.Drawing.Size(325, 17)
        Me.Email.StylePriority.UseFont = False
        Me.Email.StylePriority.UseTextAlignment = False
        Me.Email.Text = " "
        Me.Email.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel28
        '
        Me.XrLabel28.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel28.Location = New System.Drawing.Point(0, 75)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.Size = New System.Drawing.Size(58, 17)
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.Text = "E-Mail:"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel25
        '
        Me.XrLabel25.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel25.Location = New System.Drawing.Point(583, 75)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.Size = New System.Drawing.Size(67, 17)
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.Text = "Tel. 2:"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel24
        '
        Me.XrLabel24.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel24.Location = New System.Drawing.Point(392, 75)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.Size = New System.Drawing.Size(50, 16)
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.Text = "Tel. 1:"
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel21
        '
        Me.XrLabel21.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel21.Location = New System.Drawing.Point(392, 42)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.Size = New System.Drawing.Size(50, 17)
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "N�:"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel20
        '
        Me.XrLabel20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel20.Location = New System.Drawing.Point(392, 58)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.Size = New System.Drawing.Size(50, 17)
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "Cidade:"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel19
        '
        Me.XrLabel19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel19.Location = New System.Drawing.Point(583, 42)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.Size = New System.Drawing.Size(67, 17)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "Cep:"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel18
        '
        Me.XrLabel18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel18.Location = New System.Drawing.Point(583, 58)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.Size = New System.Drawing.Size(67, 17)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "UF:"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel17
        '
        Me.XrLabel17.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel17.Location = New System.Drawing.Point(0, 25)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.Size = New System.Drawing.Size(58, 17)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "Nome:"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.Location = New System.Drawing.Point(583, 25)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.Size = New System.Drawing.Size(67, 17)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "CPF/CNPJ:"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel13.Location = New System.Drawing.Point(392, 25)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.Size = New System.Drawing.Size(50, 17)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "RG/I.E.:"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.Location = New System.Drawing.Point(0, 58)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.Size = New System.Drawing.Size(58, 15)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Bairro:"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.Location = New System.Drawing.Point(0, 42)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.Size = New System.Drawing.Size(58, 17)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Endere�o:"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel14
        '
        Me.XrLabel14.CanGrow = False
        Me.XrLabel14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.Location = New System.Drawing.Point(392, 142)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.Size = New System.Drawing.Size(51, 17)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "KM Sa�.:"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel14.WordWrap = False
        '
        'lblKMSaida
        '
        Me.lblKMSaida.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblKMSaida.Location = New System.Drawing.Point(442, 142)
        Me.lblKMSaida.Name = "lblKMSaida"
        Me.lblKMSaida.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblKMSaida.Size = New System.Drawing.Size(133, 17)
        Me.lblKMSaida.StylePriority.UseFont = False
        Me.lblKMSaida.StylePriority.UseTextAlignment = False
        Me.lblKMSaida.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblNivComb
        '
        Me.lblNivComb.CanGrow = False
        Me.lblNivComb.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblNivComb.Location = New System.Drawing.Point(367, 158)
        Me.lblNivComb.Name = "lblNivComb"
        Me.lblNivComb.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNivComb.Size = New System.Drawing.Size(75, 17)
        Me.lblNivComb.StylePriority.UseFont = False
        Me.lblNivComb.StylePriority.UseTextAlignment = False
        Me.lblNivComb.Text = "N�vel Comb.:"
        Me.lblNivComb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblNivComb.WordWrap = False
        '
        'lblNivCom
        '
        Me.lblNivCom.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblNivCom.Location = New System.Drawing.Point(442, 158)
        Me.lblNivCom.Name = "lblNivCom"
        Me.lblNivCom.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNivCom.Size = New System.Drawing.Size(133, 17)
        Me.lblNivCom.StylePriority.UseFont = False
        Me.lblNivCom.StylePriority.UseTextAlignment = False
        Me.lblNivCom.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.CanGrow = False
        Me.XrLabel9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.Location = New System.Drawing.Point(200, 142)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.Size = New System.Drawing.Size(58, 17)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Sa�da:"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel9.WordWrap = False
        '
        'lblSaida
        '
        Me.lblSaida.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblSaida.Location = New System.Drawing.Point(258, 142)
        Me.lblSaida.Name = "lblSaida"
        Me.lblSaida.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblSaida.Size = New System.Drawing.Size(125, 17)
        Me.lblSaida.StylePriority.UseFont = False
        Me.lblSaida.StylePriority.UseTextAlignment = False
        Me.lblSaida.Text = "16/07/1985 00:00:00"
        Me.lblSaida.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.CanGrow = False
        Me.XrLabel5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.Location = New System.Drawing.Point(0, 142)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.Size = New System.Drawing.Size(58, 17)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Entrada:"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel5.WordWrap = False
        '
        'lblEntrada
        '
        Me.lblEntrada.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblEntrada.Location = New System.Drawing.Point(58, 142)
        Me.lblEntrada.Name = "lblEntrada"
        Me.lblEntrada.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblEntrada.Size = New System.Drawing.Size(133, 17)
        Me.lblEntrada.StylePriority.UseFont = False
        Me.lblEntrada.StylePriority.UseTextAlignment = False
        Me.lblEntrada.Text = "16/07/1985 11:23:15"
        Me.lblEntrada.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'KM
        '
        Me.KM.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.KM.Location = New System.Drawing.Point(650, 142)
        Me.KM.Name = "KM"
        Me.KM.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.KM.Size = New System.Drawing.Size(108, 17)
        Me.KM.StylePriority.UseFont = False
        Me.KM.StylePriority.UseTextAlignment = False
        Me.KM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.Location = New System.Drawing.Point(583, 142)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.Size = New System.Drawing.Size(67, 17)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "KM Ent.:"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.Location = New System.Drawing.Point(0, 200)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.Size = New System.Drawing.Size(767, 15)
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Pe�as do Pedido"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblData
        '
        Me.lblData.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblData.Location = New System.Drawing.Point(650, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblData.Size = New System.Drawing.Size(108, 17)
        Me.lblData.StylePriority.UseFont = False
        Me.lblData.StylePriority.UseTextAlignment = False
        Me.lblData.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel16
        '
        Me.XrLabel16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel16.Location = New System.Drawing.Point(583, 0)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.Size = New System.Drawing.Size(67, 16)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Data:"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel30
        '
        Me.XrLabel30.CanGrow = False
        Me.XrLabel30.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel30.Location = New System.Drawing.Point(0, 125)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.Size = New System.Drawing.Size(58, 16)
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.Text = "Placa:"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel30.WordWrap = False
        '
        'XrLabel32
        '
        Me.XrLabel32.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel32.Location = New System.Drawing.Point(592, 125)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.Size = New System.Drawing.Size(58, 16)
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        Me.XrLabel32.Text = "Cor:"
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel33
        '
        Me.XrLabel33.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel33.Location = New System.Drawing.Point(392, 125)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.Size = New System.Drawing.Size(50, 17)
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.Text = "Ano:"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Cor
        '
        Me.Cor.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Cor.Location = New System.Drawing.Point(650, 125)
        Me.Cor.Name = "Cor"
        Me.Cor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cor.Size = New System.Drawing.Size(108, 17)
        Me.Cor.StylePriority.UseFont = False
        Me.Cor.StylePriority.UseTextAlignment = False
        Me.Cor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel31
        '
        Me.XrLabel31.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel31.Location = New System.Drawing.Point(200, 125)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.Size = New System.Drawing.Size(58, 17)
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        Me.XrLabel31.Text = "Modelo:"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Placa
        '
        Me.Placa.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Placa.Location = New System.Drawing.Point(58, 125)
        Me.Placa.Name = "Placa"
        Me.Placa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Placa.Size = New System.Drawing.Size(133, 17)
        Me.Placa.StylePriority.UseFont = False
        Me.Placa.StylePriority.UseTextAlignment = False
        Me.Placa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Modelo
        '
        Me.Modelo.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Modelo.Location = New System.Drawing.Point(258, 125)
        Me.Modelo.Name = "Modelo"
        Me.Modelo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Modelo.Size = New System.Drawing.Size(125, 17)
        Me.Modelo.StylePriority.UseFont = False
        Me.Modelo.StylePriority.UseTextAlignment = False
        Me.Modelo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Ano
        '
        Me.Ano.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Ano.Location = New System.Drawing.Point(442, 125)
        Me.Ano.Name = "Ano"
        Me.Ano.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ano.Size = New System.Drawing.Size(133, 17)
        Me.Ano.StylePriority.UseFont = False
        Me.Ano.StylePriority.UseTextAlignment = False
        Me.Ano.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel29
        '
        Me.XrLabel29.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel29.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel29.Location = New System.Drawing.Point(0, 101)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.Size = New System.Drawing.Size(767, 15)
        Me.XrLabel29.StylePriority.UseBorders = False
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        Me.XrLabel29.Text = "Dados do Ve�culo"
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.Location = New System.Drawing.Point(0, 0)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(767, 15)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
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
        Me.XrLabel26.Text = "Dados do Ve�culo                              "
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
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel12, Me.lblAtendente, Me.c7, Me.c6, Me.c5, Me.XrLabel8, Me.c3, Me.c2, Me.c1, Me.lblPaga, Me.lblRec, Me.c4})
        Me.GroupFooter1.Height = 139
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrLabel12
        '
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel12.CanGrow = False
        Me.XrLabel12.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrLabel12.Location = New System.Drawing.Point(0, 33)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.Size = New System.Drawing.Size(275, 17)
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Atendente"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel12.WordWrap = False
        '
        'lblAtendente
        '
        Me.lblAtendente.CanGrow = False
        Me.lblAtendente.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblAtendente.Location = New System.Drawing.Point(0, 52)
        Me.lblAtendente.Name = "lblAtendente"
        Me.lblAtendente.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblAtendente.Size = New System.Drawing.Size(333, 17)
        Me.lblAtendente.StylePriority.UseFont = False
        Me.lblAtendente.StylePriority.UseTextAlignment = False
        Me.lblAtendente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblDesc, Me.XrLabel23})
        Me.GroupFooter2.Height = 42
        Me.GroupFooter2.Level = 1
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'lblDesc
        '
        Me.lblDesc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(0, 17)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.SerializableRtfString = resources.GetString("lblDesc.SerializableRtfString")
        Me.lblDesc.Size = New System.Drawing.Size(758, 25)
        Me.lblDesc.StylePriority.UseFont = False
        '
        'XrLabel23
        '
        Me.XrLabel23.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel23.CanGrow = False
        Me.XrLabel23.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel23.Location = New System.Drawing.Point(0, 0)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.Size = New System.Drawing.Size(767, 17)
        Me.XrLabel23.StylePriority.UseBorders = False
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "Observa��es"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel23.WordWrap = False
        '
        'GroupFooter3
        '
        Me.GroupFooter3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblDefeitos, Me.XrLabel27})
        Me.GroupFooter3.Height = 44
        Me.GroupFooter3.Level = 2
        Me.GroupFooter3.Name = "GroupFooter3"
        '
        'lblDefeitos
        '
        Me.lblDefeitos.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefeitos.Location = New System.Drawing.Point(0, 17)
        Me.lblDefeitos.Name = "lblDefeitos"
        Me.lblDefeitos.SerializableRtfString = resources.GetString("lblDefeitos.SerializableRtfString")
        Me.lblDefeitos.Size = New System.Drawing.Size(758, 25)
        Me.lblDefeitos.StylePriority.UseFont = False
        '
        'XrLabel27
        '
        Me.XrLabel27.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel27.CanGrow = False
        Me.XrLabel27.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel27.Location = New System.Drawing.Point(0, 0)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.Size = New System.Drawing.Size(767, 17)
        Me.XrLabel27.StylePriority.UseBorders = False
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.Text = "Defeitos do Ve�culo"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel27.WordWrap = False
        '
        'lblGar
        '
        Me.lblGar.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGar.Location = New System.Drawing.Point(0, 17)
        Me.lblGar.Name = "lblGar"
        Me.lblGar.SerializableRtfString = resources.GetString("lblGar.SerializableRtfString")
        Me.lblGar.Size = New System.Drawing.Size(758, 25)
        Me.lblGar.StylePriority.UseFont = False
        '
        'lblGarantias
        '
        Me.lblGarantias.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lblGarantias.CanGrow = False
        Me.lblGarantias.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblGarantias.Location = New System.Drawing.Point(0, 0)
        Me.lblGarantias.Name = "lblGarantias"
        Me.lblGarantias.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblGarantias.Size = New System.Drawing.Size(758, 17)
        Me.lblGarantias.StylePriority.UseBorders = False
        Me.lblGarantias.StylePriority.UseFont = False
        Me.lblGarantias.StylePriority.UseTextAlignment = False
        Me.lblGarantias.Text = "Garantia"
        Me.lblGarantias.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.lblGarantias.Visible = False
        '
        'GroupFooter4
        '
        Me.GroupFooter4.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblGarantias, Me.lblGar})
        Me.GroupFooter4.Height = 44
        Me.GroupFooter4.Level = 3
        Me.GroupFooter4.Name = "GroupFooter4"
        '
        'GroupFooter5
        '
        Me.GroupFooter5.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrRichText1, Me.linha7, Me.lblAut, Me.lblAssi})
        Me.GroupFooter5.Height = 77
        Me.GroupFooter5.Level = 4
        Me.GroupFooter5.Name = "GroupFooter5"
        '
        'XrRichText1
        '
        Me.XrRichText1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrRichText1.Location = New System.Drawing.Point(0, 8)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.Size = New System.Drawing.Size(425, 25)
        Me.XrRichText1.StylePriority.UseFont = False
        '
        'relOrcamento
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.GroupHeader1, Me.GroupFooter1, Me.GroupFooter2, Me.GroupFooter3, Me.GroupFooter4, Me.GroupFooter5})
        Me.Margins = New System.Drawing.Printing.Margins(30, 30, 30, 50)
        Me.PageHeight = 1169
        Me.PageWidth = 827
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
        CType(Me.PedidoGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDescricaoPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDefeitos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblGar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Placa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Modelo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ano As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
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
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblFones As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblPedido As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents lblEndereco As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblData As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents WinControlContainer2 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents tbServ As System.Data.DataTable
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colC�digo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colServi�os As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVlUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvlTot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents KM As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblKMSaida As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblNivComb As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblNivCom As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblSaida As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblEntrada As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents c2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Sevicos As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents c1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Pecas As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblPaga As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblRec As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents c4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Desconto As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents c3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Total As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents c7 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Troco As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents c6 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Recebido As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents c5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents subTotal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents colUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUMSER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Fax As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Telefone As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cep As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cidade As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Bairro As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Estado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents IE As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Num As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Endereco As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CPF As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Nome As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Email As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblAut As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents linha7 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lblAssi As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblChassi As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents WinControlContainer3 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblAtendente As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents colFunc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFuncionario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents lblPrisma As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents GroupFooter3 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents GroupFooter4 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents lblDesc As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblGar As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents lblGarantias As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents colLocacaoServ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocacao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents lblDescricaoPedido As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblMotor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblComb As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter5 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents lblDefeitos As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrRichText1 As DevExpress.XtraReports.UI.XRRichText
End Class
