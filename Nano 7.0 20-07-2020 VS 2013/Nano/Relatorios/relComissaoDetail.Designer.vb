<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relComissaoDetail
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
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblTot = New DevExpress.XtraReports.UI.XRLabel
        Me.WinControlContainer3 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.DataSet1 = New System.Data.DataSet
        Me.tbCred = New System.Data.DataTable
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.tbDeb = New System.Data.DataTable
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.dtCom = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoPedido = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtCod = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colFuncionario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorServico = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPorcentagem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComissao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipoProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lblTexto1 = New DevExpress.XtraReports.UI.XRLabel
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colMotivo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.WinControlContainer2 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colMotivo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lblComis = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblCre = New DevExpress.XtraReports.UI.XRLabel
        Me.lblDeb = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblDataIni = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblDataFim = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblFunc = New DevExpress.XtraReports.UI.XRLabel
        Me.lblSaldo = New DevExpress.XtraReports.UI.XRLabel
        Me.linha1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblTitulo2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblSaldo2 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblFunc2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine6 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblCom = New DevExpress.XtraReports.UI.XRLabel
        Me.lin1 = New DevExpress.XtraReports.UI.XRLine
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCred, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbDeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5, Me.lblTot, Me.WinControlContainer3, Me.lblTexto1, Me.WinControlContainer1, Me.XrLabel2, Me.XrLine4, Me.XrLabel1, Me.XrLine1, Me.WinControlContainer2, Me.lblComis, Me.XrLabel9, Me.XrLabel10, Me.XrLabel11, Me.lblCre, Me.lblDeb, Me.XrLabel4, Me.lblDataIni, Me.XrLabel8, Me.lblDataFim, Me.XrLabel13, Me.lblFunc, Me.lblSaldo, Me.linha1, Me.XrLabel6, Me.lblTitulo2, Me.XrLabel14, Me.XrLabel15, Me.lblSaldo2, Me.lblFunc2, Me.XrLine6, Me.XrLabel12, Me.lblCom, Me.lin1})
        Me.Detail.Height = 609
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.Location = New System.Drawing.Point(8, 358)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.Size = New System.Drawing.Size(67, 17)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Total R$"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblTot
        '
        Me.lblTot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTot.Location = New System.Drawing.Point(75, 358)
        Me.lblTot.Name = "lblTot"
        Me.lblTot.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTot.Size = New System.Drawing.Size(100, 17)
        Me.lblTot.StylePriority.UseFont = False
        Me.lblTot.StylePriority.UseTextAlignment = False
        Me.lblTot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'WinControlContainer3
        '
        Me.WinControlContainer3.Location = New System.Drawing.Point(0, 67)
        Me.WinControlContainer3.Name = "WinControlContainer3"
        Me.WinControlContainer3.Size = New System.Drawing.Size(750, 50)
        Me.WinControlContainer3.WinControl = Me.Grid1
        '
        'Grid1
        '
        Me.Grid1.DataMember = "dtCom"
        Me.Grid1.DataSource = Me.DataSet1
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(2, 20)
        Me.Grid1.MainView = Me.grd1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtCod})
        Me.Grid1.Size = New System.Drawing.Size(720, 48)
        Me.Grid1.TabIndex = 8
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.tbCred, Me.tbDeb, Me.dtCom})
        '
        'tbCred
        '
        Me.tbCred.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn2, Me.DataColumn3, Me.DataColumn5})
        Me.tbCred.TableName = "tbCred"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Motivo"
        '
        'DataColumn3
        '
        Me.DataColumn3.Caption = "Valor R$"
        Me.DataColumn3.ColumnName = "Valor"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Data"
        '
        'tbDeb
        '
        Me.tbDeb.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn7, Me.DataColumn8, Me.DataColumn10})
        Me.tbDeb.TableName = "tbDeb"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Motivo"
        '
        'DataColumn8
        '
        Me.DataColumn8.Caption = "Valor R$"
        Me.DataColumn8.ColumnName = "Valor"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Data"
        '
        'dtCom
        '
        Me.dtCom.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn4, Me.DataColumn6, Me.DataColumn9, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14})
        Me.dtCom.TableName = "dtCom"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "CodigoPedido"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Data"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Funcionario"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "ValorServico"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Porcentagem"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "Comissao"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "TipoProduto"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "Cliente"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colCodigoPedido, Me.colFuncionario, Me.colValorServico, Me.colPorcentagem, Me.colComissao, Me.GridColumn1, Me.GridColumn2, Me.colTipo, Me.colTipoProduto, Me.colCliente})
        Me.grd1.GridControl = Me.Grid1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.colCodigo.AppearanceCell.Options.UseFont = True
        Me.colCodigo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodigo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigo.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colCodigo.AppearanceHeader.Options.UseBackColor = True
        Me.colCodigo.AppearanceHeader.Options.UseFont = True
        Me.colCodigo.AppearanceHeader.Options.UseForeColor = True
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        '
        'colCodigoPedido
        '
        Me.colCodigoPedido.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.colCodigoPedido.AppearanceCell.Options.UseFont = True
        Me.colCodigoPedido.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoPedido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoPedido.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodigoPedido.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoPedido.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colCodigoPedido.AppearanceHeader.Options.UseBackColor = True
        Me.colCodigoPedido.AppearanceHeader.Options.UseFont = True
        Me.colCodigoPedido.AppearanceHeader.Options.UseForeColor = True
        Me.colCodigoPedido.Caption = "Cód. Ped."
        Me.colCodigoPedido.ColumnEdit = Me.txtCod
        Me.colCodigoPedido.FieldName = "CodigoPedido"
        Me.colCodigoPedido.Name = "colCodigoPedido"
        Me.colCodigoPedido.OptionsColumn.ReadOnly = True
        Me.colCodigoPedido.Visible = True
        Me.colCodigoPedido.VisibleIndex = 0
        Me.colCodigoPedido.Width = 109
        '
        'txtCod
        '
        Me.txtCod.AutoHeight = False
        Me.txtCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCod.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCod.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCod.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Value
        Me.txtCod.Name = "txtCod"
        '
        'colFuncionario
        '
        Me.colFuncionario.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.colFuncionario.AppearanceCell.Options.UseFont = True
        Me.colFuncionario.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colFuncionario.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFuncionario.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colFuncionario.AppearanceHeader.Options.UseBackColor = True
        Me.colFuncionario.AppearanceHeader.Options.UseFont = True
        Me.colFuncionario.AppearanceHeader.Options.UseForeColor = True
        Me.colFuncionario.Caption = "Vendedor"
        Me.colFuncionario.FieldName = "Funcionario"
        Me.colFuncionario.Name = "colFuncionario"
        Me.colFuncionario.OptionsColumn.ReadOnly = True
        Me.colFuncionario.Visible = True
        Me.colFuncionario.VisibleIndex = 3
        Me.colFuncionario.Width = 248
        '
        'colValorServico
        '
        Me.colValorServico.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.colValorServico.AppearanceCell.Options.UseFont = True
        Me.colValorServico.AppearanceCell.Options.UseTextOptions = True
        Me.colValorServico.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorServico.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValorServico.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValorServico.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colValorServico.AppearanceHeader.Options.UseBackColor = True
        Me.colValorServico.AppearanceHeader.Options.UseFont = True
        Me.colValorServico.AppearanceHeader.Options.UseForeColor = True
        Me.colValorServico.Caption = "Val. Prod. R$"
        Me.colValorServico.FieldName = "ValorServico"
        Me.colValorServico.Name = "colValorServico"
        Me.colValorServico.OptionsColumn.ReadOnly = True
        Me.colValorServico.Visible = True
        Me.colValorServico.VisibleIndex = 4
        Me.colValorServico.Width = 151
        '
        'colPorcentagem
        '
        Me.colPorcentagem.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.colPorcentagem.AppearanceCell.Options.UseFont = True
        Me.colPorcentagem.AppearanceCell.Options.UseTextOptions = True
        Me.colPorcentagem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPorcentagem.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colPorcentagem.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPorcentagem.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colPorcentagem.AppearanceHeader.Options.UseBackColor = True
        Me.colPorcentagem.AppearanceHeader.Options.UseFont = True
        Me.colPorcentagem.AppearanceHeader.Options.UseForeColor = True
        Me.colPorcentagem.Caption = "Por. %"
        Me.colPorcentagem.FieldName = "Porcentagem"
        Me.colPorcentagem.Name = "colPorcentagem"
        Me.colPorcentagem.OptionsColumn.ReadOnly = True
        Me.colPorcentagem.Visible = True
        Me.colPorcentagem.VisibleIndex = 5
        Me.colPorcentagem.Width = 81
        '
        'colComissao
        '
        Me.colComissao.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.colComissao.AppearanceCell.Options.UseFont = True
        Me.colComissao.AppearanceCell.Options.UseTextOptions = True
        Me.colComissao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colComissao.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colComissao.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComissao.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colComissao.AppearanceHeader.Options.UseBackColor = True
        Me.colComissao.AppearanceHeader.Options.UseFont = True
        Me.colComissao.AppearanceHeader.Options.UseForeColor = True
        Me.colComissao.Caption = "Val. Com. R$"
        Me.colComissao.FieldName = "Comissao"
        Me.colComissao.Name = "colComissao"
        Me.colComissao.OptionsColumn.ReadOnly = True
        Me.colComissao.Visible = True
        Me.colComissao.VisibleIndex = 6
        Me.colComissao.Width = 139
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.GridColumn1.AppearanceCell.Options.UseFont = True
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn1.AppearanceHeader.Options.UseBackColor = True
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn1.Caption = "Data"
        Me.GridColumn1.FieldName = "Data"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 107
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.GridColumn2.AppearanceCell.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn2.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn2.AppearanceHeader.Options.UseBackColor = True
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn2.Caption = "Motivo"
        Me.GridColumn2.FieldName = "Motivo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Width = 320
        '
        'colTipo
        '
        Me.colTipo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.colTipo.AppearanceCell.Options.UseFont = True
        Me.colTipo.AppearanceCell.Options.UseTextOptions = True
        Me.colTipo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colTipo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTipo.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colTipo.AppearanceHeader.Options.UseBackColor = True
        Me.colTipo.AppearanceHeader.Options.UseFont = True
        Me.colTipo.AppearanceHeader.Options.UseForeColor = True
        Me.colTipo.Caption = "Tipo"
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.OptionsColumn.ReadOnly = True
        Me.colTipo.Width = 71
        '
        'colTipoProduto
        '
        Me.colTipoProduto.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.colTipoProduto.AppearanceCell.Options.UseFont = True
        Me.colTipoProduto.AppearanceCell.Options.UseTextOptions = True
        Me.colTipoProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipoProduto.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colTipoProduto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTipoProduto.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colTipoProduto.AppearanceHeader.Options.UseBackColor = True
        Me.colTipoProduto.AppearanceHeader.Options.UseFont = True
        Me.colTipoProduto.AppearanceHeader.Options.UseForeColor = True
        Me.colTipoProduto.Caption = "Tip. Prod."
        Me.colTipoProduto.FieldName = "TipoProduto"
        Me.colTipoProduto.Name = "colTipoProduto"
        Me.colTipoProduto.OptionsColumn.ReadOnly = True
        Me.colTipoProduto.Visible = True
        Me.colTipoProduto.VisibleIndex = 7
        Me.colTipoProduto.Width = 91
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
        Me.colCliente.Width = 248
        '
        'lblTexto1
        '
        Me.lblTexto1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto1.Location = New System.Drawing.Point(450, 358)
        Me.lblTexto1.Name = "lblTexto1"
        Me.lblTexto1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTexto1.Size = New System.Drawing.Size(167, 17)
        Me.lblTexto1.StylePriority.UseFont = False
        Me.lblTexto1.StylePriority.UseTextAlignment = False
        Me.lblTexto1.Text = "Total de Comissão R$"
        Me.lblTexto1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.Location = New System.Drawing.Point(0, 142)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.Size = New System.Drawing.Size(708, 100)
        Me.WinControlContainer1.WinControl = Me.GridControl1
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbCred"
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(680, 96)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMotivo, Me.colValor, Me.colData})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colMotivo
        '
        Me.colMotivo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.colMotivo.AppearanceCell.Options.UseFont = True
        Me.colMotivo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colMotivo.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colMotivo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMotivo.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colMotivo.AppearanceHeader.Options.UseBackColor = True
        Me.colMotivo.AppearanceHeader.Options.UseFont = True
        Me.colMotivo.AppearanceHeader.Options.UseForeColor = True
        Me.colMotivo.Caption = "Motivo"
        Me.colMotivo.FieldName = "Motivo"
        Me.colMotivo.Name = "colMotivo"
        Me.colMotivo.Visible = True
        Me.colMotivo.VisibleIndex = 1
        Me.colMotivo.Width = 479
        '
        'colValor
        '
        Me.colValor.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.colValor.AppearanceCell.Options.UseFont = True
        Me.colValor.AppearanceCell.Options.UseTextOptions = True
        Me.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValor.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colValor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colValor.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colValor.AppearanceHeader.Options.UseBackColor = True
        Me.colValor.AppearanceHeader.Options.UseFont = True
        Me.colValor.AppearanceHeader.Options.UseForeColor = True
        Me.colValor.Caption = "Valor R$"
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 2
        Me.colValor.Width = 60
        '
        'colData
        '
        Me.colData.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.colData.AppearanceCell.Options.UseFont = True
        Me.colData.AppearanceCell.Options.UseTextOptions = True
        Me.colData.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colData.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colData.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colData.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colData.AppearanceHeader.Options.UseBackColor = True
        Me.colData.AppearanceHeader.Options.UseFont = True
        Me.colData.AppearanceHeader.Options.UseForeColor = True
        Me.colData.Caption = "Data"
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.Visible = True
        Me.colData.VisibleIndex = 0
        Me.colData.Width = 45
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.Location = New System.Drawing.Point(0, 250)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.Size = New System.Drawing.Size(75, 17)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "Débitos"
        '
        'XrLine4
        '
        Me.XrLine4.LineWidth = 2
        Me.XrLine4.Location = New System.Drawing.Point(75, 258)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.Size = New System.Drawing.Size(675, 8)
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.Location = New System.Drawing.Point(0, 125)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(75, 17)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "Créditos"
        '
        'XrLine1
        '
        Me.XrLine1.LineWidth = 2
        Me.XrLine1.Location = New System.Drawing.Point(75, 133)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(675, 8)
        '
        'WinControlContainer2
        '
        Me.WinControlContainer2.Location = New System.Drawing.Point(0, 267)
        Me.WinControlContainer2.Name = "WinControlContainer2"
        Me.WinControlContainer2.Size = New System.Drawing.Size(708, 83)
        Me.WinControlContainer2.WinControl = Me.GridControl2
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "tbDeb"
        Me.GridControl2.DataSource = Me.DataSet1
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(680, 80)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMotivo1, Me.colValor1, Me.colData1})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colMotivo1
        '
        Me.colMotivo1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.colMotivo1.AppearanceCell.Options.UseFont = True
        Me.colMotivo1.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colMotivo1.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colMotivo1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMotivo1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colMotivo1.AppearanceHeader.Options.UseBackColor = True
        Me.colMotivo1.AppearanceHeader.Options.UseFont = True
        Me.colMotivo1.AppearanceHeader.Options.UseForeColor = True
        Me.colMotivo1.Caption = "Motivo"
        Me.colMotivo1.FieldName = "Motivo"
        Me.colMotivo1.Name = "colMotivo1"
        Me.colMotivo1.Visible = True
        Me.colMotivo1.VisibleIndex = 1
        Me.colMotivo1.Width = 479
        '
        'colValor1
        '
        Me.colValor1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.colValor1.AppearanceCell.Options.UseFont = True
        Me.colValor1.AppearanceCell.Options.UseTextOptions = True
        Me.colValor1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor1.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValor1.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colValor1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colValor1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colValor1.AppearanceHeader.Options.UseBackColor = True
        Me.colValor1.AppearanceHeader.Options.UseFont = True
        Me.colValor1.AppearanceHeader.Options.UseForeColor = True
        Me.colValor1.Caption = "Valor R$"
        Me.colValor1.FieldName = "Valor"
        Me.colValor1.Name = "colValor1"
        Me.colValor1.Visible = True
        Me.colValor1.VisibleIndex = 2
        Me.colValor1.Width = 60
        '
        'colData1
        '
        Me.colData1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.colData1.AppearanceCell.Options.UseFont = True
        Me.colData1.AppearanceCell.Options.UseTextOptions = True
        Me.colData1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData1.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colData1.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colData1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colData1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colData1.AppearanceHeader.Options.UseBackColor = True
        Me.colData1.AppearanceHeader.Options.UseFont = True
        Me.colData1.AppearanceHeader.Options.UseForeColor = True
        Me.colData1.Caption = "Data"
        Me.colData1.FieldName = "Data"
        Me.colData1.Name = "colData1"
        Me.colData1.Visible = True
        Me.colData1.VisibleIndex = 0
        Me.colData1.Width = 45
        '
        'lblComis
        '
        Me.lblComis.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComis.Location = New System.Drawing.Point(617, 358)
        Me.lblComis.Name = "lblComis"
        Me.lblComis.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblComis.Size = New System.Drawing.Size(100, 17)
        Me.lblComis.StylePriority.UseFont = False
        Me.lblComis.StylePriority.UseTextAlignment = False
        Me.lblComis.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.Location = New System.Drawing.Point(392, 400)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.Size = New System.Drawing.Size(183, 17)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Total de Créditos R$"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.Location = New System.Drawing.Point(367, 417)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.Size = New System.Drawing.Size(208, 17)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Total de Débitos R$"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.Location = New System.Drawing.Point(367, 442)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.Size = New System.Drawing.Size(208, 17)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Saldo Final R$"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblCre
        '
        Me.lblCre.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCre.Location = New System.Drawing.Point(583, 400)
        Me.lblCre.Name = "lblCre"
        Me.lblCre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblCre.Size = New System.Drawing.Size(133, 17)
        Me.lblCre.StylePriority.UseFont = False
        Me.lblCre.StylePriority.UseTextAlignment = False
        Me.lblCre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblDeb
        '
        Me.lblDeb.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeb.Location = New System.Drawing.Point(583, 417)
        Me.lblDeb.Name = "lblDeb"
        Me.lblDeb.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblDeb.Size = New System.Drawing.Size(133, 17)
        Me.lblDeb.StylePriority.UseFont = False
        Me.lblDeb.StylePriority.UseTextAlignment = False
        Me.lblDeb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.Location = New System.Drawing.Point(8, 8)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.Size = New System.Drawing.Size(333, 17)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Relatório de Créditos e Débitos referente ao período de:"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblDataIni
        '
        Me.lblDataIni.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataIni.Location = New System.Drawing.Point(350, 8)
        Me.lblDataIni.Name = "lblDataIni"
        Me.lblDataIni.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblDataIni.Size = New System.Drawing.Size(75, 17)
        Me.lblDataIni.StylePriority.UseFont = False
        Me.lblDataIni.StylePriority.UseTextAlignment = False
        Me.lblDataIni.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.Location = New System.Drawing.Point(433, 8)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.Size = New System.Drawing.Size(42, 17)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "até"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblDataFim
        '
        Me.lblDataFim.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataFim.Location = New System.Drawing.Point(483, 8)
        Me.lblDataFim.Name = "lblDataFim"
        Me.lblDataFim.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblDataFim.Size = New System.Drawing.Size(75, 17)
        Me.lblDataFim.StylePriority.UseFont = False
        Me.lblDataFim.StylePriority.UseTextAlignment = False
        Me.lblDataFim.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.Location = New System.Drawing.Point(8, 25)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.Size = New System.Drawing.Size(83, 17)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "Funcionário:"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblFunc
        '
        Me.lblFunc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunc.Location = New System.Drawing.Point(100, 25)
        Me.lblFunc.Name = "lblFunc"
        Me.lblFunc.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblFunc.Size = New System.Drawing.Size(458, 17)
        Me.lblFunc.StylePriority.UseFont = False
        Me.lblFunc.StylePriority.UseTextAlignment = False
        Me.lblFunc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblSaldo
        '
        Me.lblSaldo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.Location = New System.Drawing.Point(583, 442)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblSaldo.Size = New System.Drawing.Size(133, 17)
        Me.lblSaldo.StylePriority.UseFont = False
        Me.lblSaldo.StylePriority.UseTextAlignment = False
        Me.lblSaldo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'linha1
        '
        Me.linha1.LineWidth = 2
        Me.linha1.Location = New System.Drawing.Point(350, 383)
        Me.linha1.Name = "linha1"
        Me.linha1.Size = New System.Drawing.Size(367, 8)
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.Location = New System.Drawing.Point(75, 500)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.Size = New System.Drawing.Size(192, 17)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Confirmo ter recebido de "
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblTitulo2
        '
        Me.lblTitulo2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo2.Location = New System.Drawing.Point(267, 500)
        Me.lblTitulo2.Name = "lblTitulo2"
        Me.lblTitulo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitulo2.Size = New System.Drawing.Size(258, 17)
        Me.lblTitulo2.StylePriority.UseFont = False
        Me.lblTitulo2.StylePriority.UseTextAlignment = False
        Me.lblTitulo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel14
        '
        Me.XrLabel14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel14.Location = New System.Drawing.Point(117, 517)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.Size = New System.Drawing.Size(350, 17)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = " correspondente aos itens acima discriminados."
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.Location = New System.Drawing.Point(533, 500)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.Size = New System.Drawing.Size(92, 17)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "o valor de R$"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblSaldo2
        '
        Me.lblSaldo2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo2.Location = New System.Drawing.Point(625, 500)
        Me.lblSaldo2.Name = "lblSaldo2"
        Me.lblSaldo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblSaldo2.Size = New System.Drawing.Size(92, 17)
        Me.lblSaldo2.StylePriority.UseFont = False
        Me.lblSaldo2.StylePriority.UseTextAlignment = False
        Me.lblSaldo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblFunc2
        '
        Me.lblFunc2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunc2.Location = New System.Drawing.Point(375, 575)
        Me.lblFunc2.Name = "lblFunc2"
        Me.lblFunc2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblFunc2.Size = New System.Drawing.Size(317, 17)
        Me.lblFunc2.StylePriority.UseFont = False
        Me.lblFunc2.StylePriority.UseTextAlignment = False
        Me.lblFunc2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine6
        '
        Me.XrLine6.Location = New System.Drawing.Point(350, 567)
        Me.XrLine6.Name = "XrLine6"
        Me.XrLine6.Size = New System.Drawing.Size(367, 8)
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.Location = New System.Drawing.Point(717, 500)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.Size = New System.Drawing.Size(17, 17)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = ","
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblCom
        '
        Me.lblCom.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCom.Location = New System.Drawing.Point(0, 50)
        Me.lblCom.Name = "lblCom"
        Me.lblCom.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblCom.Size = New System.Drawing.Size(100, 17)
        Me.lblCom.StylePriority.UseFont = False
        Me.lblCom.Text = "Comissões"
        '
        'lin1
        '
        Me.lin1.LineWidth = 2
        Me.lin1.Location = New System.Drawing.Point(100, 58)
        Me.lin1.Name = "lin1"
        Me.lin1.Size = New System.Drawing.Size(650, 8)
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblTitulo, Me.XrLine3, Me.XrLine2, Me.picLogo})
        Me.PageHeader.Height = 108
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(158, 50)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitulo.Size = New System.Drawing.Size(558, 25)
        Me.lblTitulo.StylePriority.UseFont = False
        Me.lblTitulo.StylePriority.UseTextAlignment = False
        Me.lblTitulo.Text = "Relatório de Comissões e Ganhos"
        Me.lblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine3
        '
        Me.XrLine3.LineWidth = 2
        Me.XrLine3.Location = New System.Drawing.Point(0, 8)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.Size = New System.Drawing.Size(750, 8)
        '
        'XrLine2
        '
        Me.XrLine2.LineWidth = 2
        Me.XrLine2.Location = New System.Drawing.Point(0, 100)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(750, 8)
        '
        'picLogo
        '
        Me.picLogo.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.picLogo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.picLogo.ImageUrl = "C:\NANO\Logo.png"
        Me.picLogo.Location = New System.Drawing.Point(0, 25)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(150, 65)
        Me.picLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.picLogo.StylePriority.UseBorderColor = False
        Me.picLogo.StylePriority.UseBorders = False
        '
        'PageFooter
        '
        Me.PageFooter.Height = 8
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'relComissaoDetail
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Margins = New System.Drawing.Printing.Margins(45, 27, 45, 45)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ShowPreviewMarginLines = False
        Me.Version = "8.2"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCred, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbDeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents tbCred As System.Data.DataTable
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents tbDeb As System.Data.DataTable
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents lblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents picLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents WinControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMotivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WinControlContainer2 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMotivo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblDeb As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblCre As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblComis As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblDataFim As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblDataIni As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblFunc As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblSaldo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents linha1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitulo2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine6 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lblFunc2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblSaldo2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lin1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lblCom As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents WinControlContainer3 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoPedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCod As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colFuncionario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorServico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPorcentagem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComissao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtCom As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents lblTexto1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTot As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
End Class
