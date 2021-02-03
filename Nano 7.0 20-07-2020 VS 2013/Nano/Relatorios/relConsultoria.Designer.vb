<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relConsultoria
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
        Me.PedidoGridControl = New DevExpress.XtraGrid.GridControl
        Me.dsCon = New System.Data.DataSet
        Me.tbCon = New System.Data.DataTable
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
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtRetorna = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colTelefone = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipoProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPlaca = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNascimento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOrdem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCadastro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorUnitario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCPF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEndereco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueLoja = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.lueFunc = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.DataColumn15 = New System.Data.DataColumn
        CType(Me.PedidoGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRetorna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.WinControlContainer1})
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.Location = New System.Drawing.Point(0, 0)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.Size = New System.Drawing.Size(1108, 92)
        Me.WinControlContainer1.WinControl = Me.PedidoGridControl
        '
        'PedidoGridControl
        '
        Me.PedidoGridControl.DataMember = "tbCon"
        Me.PedidoGridControl.DataSource = Me.dsCon
        Me.PedidoGridControl.EmbeddedNavigator.Name = ""
        Me.PedidoGridControl.Location = New System.Drawing.Point(0, 24)
        Me.PedidoGridControl.MainView = Me.grd1
        Me.PedidoGridControl.Name = "PedidoGridControl"
        Me.PedidoGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtRetorna, Me.lueLoja, Me.lueFunc, Me.RepositoryItemCheckEdit2})
        Me.PedidoGridControl.Size = New System.Drawing.Size(1064, 88)
        Me.PedidoGridControl.TabIndex = 3
        Me.PedidoGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1, Me.GridView2})
        '
        'dsCon
        '
        Me.dsCon.DataSetName = "NewDataSet"
        Me.dsCon.Tables.AddRange(New System.Data.DataTable() {Me.tbCon})
        '
        'tbCon
        '
        Me.tbCon.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15})
        Me.tbCon.TableName = "tbCon"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Cliente"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Telefone"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Nascimento"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Data"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Placa"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Produto"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "TipoProduto"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Qtd"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Ordem"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Cadastro"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "ValorUnitario"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "ValorTotal"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "CPF"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "Cep"
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
        Me.grd1.AppearancePrint.GroupRow.BackColor = System.Drawing.Color.AliceBlue
        Me.grd1.AppearancePrint.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.AppearancePrint.GroupRow.Options.UseBackColor = True
        Me.grd1.AppearancePrint.GroupRow.Options.UseFont = True
        Me.grd1.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.grd1.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.AppearancePrint.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseBackColor = True
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseForeColor = True
        Me.grd1.AppearancePrint.Row.BackColor = System.Drawing.Color.White
        Me.grd1.AppearancePrint.Row.Options.UseBackColor = True
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCliente, Me.colTelefone, Me.colQtd, Me.colProduto, Me.colTipoProduto, Me.colPlaca, Me.colData, Me.colNascimento, Me.colOrdem, Me.colCadastro, Me.colValorUnitario, Me.colValorTotal, Me.colCPF, Me.colEndereco, Me.colCep})
        Me.grd1.GridControl = Me.PedidoGridControl
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCliente
        '
        Me.colCliente.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.ColumnEdit = Me.txtRetorna
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.ReadOnly = True
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 0
        Me.colCliente.Width = 155
        '
        'txtRetorna
        '
        Me.txtRetorna.AutoHeight = False
        Me.txtRetorna.Name = "txtRetorna"
        '
        'colTelefone
        '
        Me.colTelefone.Caption = "Telefone"
        Me.colTelefone.ColumnEdit = Me.txtRetorna
        Me.colTelefone.FieldName = "Telefone"
        Me.colTelefone.Name = "colTelefone"
        Me.colTelefone.OptionsColumn.ReadOnly = True
        Me.colTelefone.Visible = True
        Me.colTelefone.VisibleIndex = 2
        Me.colTelefone.Width = 66
        '
        'colQtd
        '
        Me.colQtd.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colQtd.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtd.Caption = "Qtde"
        Me.colQtd.ColumnEdit = Me.txtRetorna
        Me.colQtd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtd.FieldName = "Qtd"
        Me.colQtd.Name = "colQtd"
        Me.colQtd.OptionsColumn.ReadOnly = True
        Me.colQtd.Visible = True
        Me.colQtd.VisibleIndex = 10
        Me.colQtd.Width = 40
        '
        'colProduto
        '
        Me.colProduto.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colProduto.Caption = "Produto"
        Me.colProduto.ColumnEdit = Me.txtRetorna
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 8
        Me.colProduto.Width = 164
        '
        'colTipoProduto
        '
        Me.colTipoProduto.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colTipoProduto.AppearanceCell.Options.UseTextOptions = True
        Me.colTipoProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipoProduto.Caption = "Tip. Prod."
        Me.colTipoProduto.ColumnEdit = Me.txtRetorna
        Me.colTipoProduto.FieldName = "TipoProduto"
        Me.colTipoProduto.Name = "colTipoProduto"
        Me.colTipoProduto.OptionsColumn.ReadOnly = True
        Me.colTipoProduto.Visible = True
        Me.colTipoProduto.VisibleIndex = 9
        Me.colTipoProduto.Width = 61
        '
        'colPlaca
        '
        Me.colPlaca.Caption = "Placa"
        Me.colPlaca.FieldName = "Placa"
        Me.colPlaca.Name = "colPlaca"
        Me.colPlaca.OptionsColumn.ReadOnly = True
        Me.colPlaca.Visible = True
        Me.colPlaca.VisibleIndex = 7
        Me.colPlaca.Width = 71
        '
        'colData
        '
        Me.colData.AppearanceCell.Options.UseTextOptions = True
        Me.colData.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData.Caption = "Data"
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.OptionsColumn.ReadOnly = True
        Me.colData.Visible = True
        Me.colData.VisibleIndex = 6
        Me.colData.Width = 66
        '
        'colNascimento
        '
        Me.colNascimento.AppearanceCell.Options.UseTextOptions = True
        Me.colNascimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNascimento.Caption = "Nascimento"
        Me.colNascimento.FieldName = "Nascimento"
        Me.colNascimento.Name = "colNascimento"
        Me.colNascimento.OptionsColumn.ReadOnly = True
        Me.colNascimento.Visible = True
        Me.colNascimento.VisibleIndex = 3
        Me.colNascimento.Width = 66
        '
        'colOrdem
        '
        Me.colOrdem.Caption = "Ordem"
        Me.colOrdem.FieldName = "Ordem"
        Me.colOrdem.Name = "colOrdem"
        Me.colOrdem.Visible = True
        Me.colOrdem.VisibleIndex = 5
        Me.colOrdem.Width = 66
        '
        'colCadastro
        '
        Me.colCadastro.Caption = "Cadastro"
        Me.colCadastro.FieldName = "Cadastro"
        Me.colCadastro.Name = "colCadastro"
        Me.colCadastro.Visible = True
        Me.colCadastro.VisibleIndex = 4
        Me.colCadastro.Width = 66
        '
        'colValorUnitario
        '
        Me.colValorUnitario.AppearanceCell.Options.UseTextOptions = True
        Me.colValorUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorUnitario.Caption = "Valor Unit. R$"
        Me.colValorUnitario.FieldName = "ValorUnitario"
        Me.colValorUnitario.Name = "colValorUnitario"
        Me.colValorUnitario.Visible = True
        Me.colValorUnitario.VisibleIndex = 11
        Me.colValorUnitario.Width = 66
        '
        'colValorTotal
        '
        Me.colValorTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colValorTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorTotal.Caption = "Valor Total R$"
        Me.colValorTotal.FieldName = "ValorTotal"
        Me.colValorTotal.Name = "colValorTotal"
        Me.colValorTotal.Visible = True
        Me.colValorTotal.VisibleIndex = 12
        Me.colValorTotal.Width = 66
        '
        'colCPF
        '
        Me.colCPF.Caption = "CPF/CNPJ"
        Me.colCPF.FieldName = "CPF"
        Me.colCPF.Name = "colCPF"
        Me.colCPF.Visible = True
        Me.colCPF.VisibleIndex = 1
        Me.colCPF.Width = 72
        '
        'colEndereco
        '
        Me.colEndereco.Caption = "Endereço"
        Me.colEndereco.FieldName = "Endereco"
        Me.colEndereco.Name = "colEndereco"
        Me.colEndereco.Visible = True
        Me.colEndereco.VisibleIndex = 13
        Me.colEndereco.Width = 90
        '
        'colCep
        '
        Me.colCep.Caption = "CEP"
        Me.colCep.FieldName = "Cep"
        Me.colCep.Name = "colCep"
        Me.colCep.Visible = True
        Me.colCep.VisibleIndex = 14
        Me.colCep.Width = 59
        '
        'lueLoja
        '
        Me.lueLoja.AutoHeight = False
        Me.lueLoja.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLoja.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 35, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descrição", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueLoja.DisplayMember = "Codigo"
        Me.lueLoja.Name = "lueLoja"
        Me.lueLoja.NullText = ""
        Me.lueLoja.ValueMember = "Codigo"
        '
        'lueFunc
        '
        Me.lueFunc.AutoHeight = False
        Me.lueFunc.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueFunc.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 52, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueFunc.DisplayMember = "Codigo"
        Me.lueFunc.Name = "lueFunc"
        Me.lueFunc.NullText = ""
        Me.lueFunc.ValueMember = "Codigo"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.PedidoGridControl
        Me.GridView2.Name = "GridView2"
        '
        'PageHeader
        '
        Me.PageHeader.Height = 30
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageFooter
        '
        Me.PageFooter.Height = 30
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "Endereco"
        '
        'relConsultoria
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(30, 30, 30, 30)
        Me.PageHeight = 827
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Version = "8.2"
        CType(Me.PedidoGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRetorna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueFunc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents WinControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents PedidoGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtRetorna As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colTelefone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNascimento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueLoja As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lueFunc As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dsCon As System.Data.DataSet
    Friend WithEvents tbCon As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents colOrdem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCadastro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents colCPF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndereco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
End Class
