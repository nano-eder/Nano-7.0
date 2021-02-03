<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relContaReceber
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
        Me.lblTotCom = New DevExpress.XtraReports.UI.XRLabel
        Me.lblCom = New DevExpress.XtraReports.UI.XRLabel
        Me.lblTotal = New DevExpress.XtraReports.UI.XRLabel
        Me.lblRelTotal = New DevExpress.XtraReports.UI.XRLabel
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsRec = New System.Data.DataSet
        Me.tbRec = New System.Data.DataTable
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCod = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colParcelas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorParcela = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVencimento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorRecebido = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRecebimento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCPF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCentroCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.lblPeriodo = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsRec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbRec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblTotCom, Me.lblCom, Me.lblTotal, Me.lblRelTotal, Me.WinControlContainer1})
        Me.Detail.Height = 151
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblTotCom
        '
        Me.lblTotCom.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotCom.Location = New System.Drawing.Point(925, 117)
        Me.lblTotCom.Name = "lblTotCom"
        Me.lblTotCom.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTotCom.Size = New System.Drawing.Size(158, 25)
        Me.lblTotCom.StylePriority.UseFont = False
        Me.lblTotCom.StylePriority.UseTextAlignment = False
        Me.lblTotCom.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblTotCom.Visible = False
        '
        'lblCom
        '
        Me.lblCom.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCom.Location = New System.Drawing.Point(742, 117)
        Me.lblCom.Name = "lblCom"
        Me.lblCom.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblCom.Size = New System.Drawing.Size(183, 25)
        Me.lblCom.StylePriority.UseFont = False
        Me.lblCom.StylePriority.UseTextAlignment = False
        Me.lblCom.Text = "Total Comissão R$"
        Me.lblCom.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblCom.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(925, 92)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTotal.Size = New System.Drawing.Size(158, 25)
        Me.lblTotal.StylePriority.UseFont = False
        Me.lblTotal.StylePriority.UseTextAlignment = False
        Me.lblTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblRelTotal
        '
        Me.lblRelTotal.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRelTotal.Location = New System.Drawing.Point(742, 92)
        Me.lblRelTotal.Name = "lblRelTotal"
        Me.lblRelTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblRelTotal.Size = New System.Drawing.Size(183, 25)
        Me.lblRelTotal.StylePriority.UseFont = False
        Me.lblRelTotal.StylePriority.UseTextAlignment = False
        Me.lblRelTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.Location = New System.Drawing.Point(0, 0)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.Size = New System.Drawing.Size(1083, 75)
        Me.WinControlContainer1.WinControl = Me.GridControl1
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbRec"
        Me.GridControl1.DataSource = Me.dsRec
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1040, 72)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'dsRec
        '
        Me.dsRec.DataSetName = "NewDataSet"
        Me.dsRec.Tables.AddRange(New System.Data.DataTable() {Me.tbRec})
        '
        'tbRec
        '
        Me.tbRec.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13})
        Me.tbRec.TableName = "tbRec"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Cod"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Data"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Cliente"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Placa"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Modelo"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Valor"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Parcelas"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "ValorParcela"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Vencimento"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "ValorRecebido"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Recebimento"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "CPF"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "CentroCusto"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCod, Me.colData, Me.colCliente, Me.colValor, Me.colParcelas, Me.colValorParcela, Me.colVencimento, Me.colValorRecebido, Me.colRecebimento, Me.colCPF, Me.colCentroCusto})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupedColumns = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCod
        '
        Me.colCod.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colCod.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCod.AppearanceCell.Options.UseBackColor = True
        Me.colCod.AppearanceCell.Options.UseTextOptions = True
        Me.colCod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCod.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCod.AppearanceHeader.BackColor2 = System.Drawing.Color.Black
        Me.colCod.AppearanceHeader.BorderColor = System.Drawing.Color.Black
        Me.colCod.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCod.AppearanceHeader.Options.UseBackColor = True
        Me.colCod.AppearanceHeader.Options.UseBorderColor = True
        Me.colCod.AppearanceHeader.Options.UseFont = True
        Me.colCod.Caption = "Nº Venda"
        Me.colCod.FieldName = "Cod"
        Me.colCod.Name = "colCod"
        Me.colCod.OptionsColumn.ReadOnly = True
        Me.colCod.Visible = True
        Me.colCod.VisibleIndex = 0
        Me.colCod.Width = 69
        '
        'colData
        '
        Me.colData.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colData.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colData.AppearanceCell.Options.UseBackColor = True
        Me.colData.AppearanceCell.Options.UseTextOptions = True
        Me.colData.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colData.AppearanceHeader.BackColor2 = System.Drawing.Color.Black
        Me.colData.AppearanceHeader.BorderColor = System.Drawing.Color.Black
        Me.colData.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colData.AppearanceHeader.Options.UseBackColor = True
        Me.colData.AppearanceHeader.Options.UseBorderColor = True
        Me.colData.AppearanceHeader.Options.UseFont = True
        Me.colData.Caption = "Data"
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.OptionsColumn.ReadOnly = True
        Me.colData.Width = 55
        '
        'colCliente
        '
        Me.colCliente.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colCliente.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCliente.AppearanceCell.Options.UseBackColor = True
        Me.colCliente.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCliente.AppearanceHeader.BackColor2 = System.Drawing.Color.Black
        Me.colCliente.AppearanceHeader.BorderColor = System.Drawing.Color.Black
        Me.colCliente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCliente.AppearanceHeader.Options.UseBackColor = True
        Me.colCliente.AppearanceHeader.Options.UseBorderColor = True
        Me.colCliente.AppearanceHeader.Options.UseFont = True
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.ReadOnly = True
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 1
        Me.colCliente.Width = 280
        '
        'colValor
        '
        Me.colValor.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colValor.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colValor.AppearanceCell.Options.UseBackColor = True
        Me.colValor.AppearanceCell.Options.UseTextOptions = True
        Me.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValor.AppearanceHeader.BackColor2 = System.Drawing.Color.Black
        Me.colValor.AppearanceHeader.BorderColor = System.Drawing.Color.Black
        Me.colValor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValor.AppearanceHeader.Options.UseBackColor = True
        Me.colValor.AppearanceHeader.Options.UseBorderColor = True
        Me.colValor.AppearanceHeader.Options.UseFont = True
        Me.colValor.Caption = "Valor Total R$"
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.OptionsColumn.ReadOnly = True
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 4
        Me.colValor.Width = 101
        '
        'colParcelas
        '
        Me.colParcelas.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colParcelas.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colParcelas.AppearanceCell.Options.UseBackColor = True
        Me.colParcelas.AppearanceCell.Options.UseTextOptions = True
        Me.colParcelas.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colParcelas.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colParcelas.AppearanceHeader.BackColor2 = System.Drawing.Color.Black
        Me.colParcelas.AppearanceHeader.BorderColor = System.Drawing.Color.Black
        Me.colParcelas.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colParcelas.AppearanceHeader.Options.UseBackColor = True
        Me.colParcelas.AppearanceHeader.Options.UseBorderColor = True
        Me.colParcelas.AppearanceHeader.Options.UseFont = True
        Me.colParcelas.Caption = "Nº Parc."
        Me.colParcelas.FieldName = "Parcelas"
        Me.colParcelas.Name = "colParcelas"
        Me.colParcelas.OptionsColumn.ReadOnly = True
        Me.colParcelas.Visible = True
        Me.colParcelas.VisibleIndex = 5
        Me.colParcelas.Width = 68
        '
        'colValorParcela
        '
        Me.colValorParcela.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colValorParcela.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colValorParcela.AppearanceCell.Options.UseBackColor = True
        Me.colValorParcela.AppearanceCell.Options.UseTextOptions = True
        Me.colValorParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorParcela.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValorParcela.AppearanceHeader.BackColor2 = System.Drawing.Color.Black
        Me.colValorParcela.AppearanceHeader.BorderColor = System.Drawing.Color.Black
        Me.colValorParcela.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValorParcela.AppearanceHeader.Options.UseBackColor = True
        Me.colValorParcela.AppearanceHeader.Options.UseBorderColor = True
        Me.colValorParcela.AppearanceHeader.Options.UseFont = True
        Me.colValorParcela.Caption = "Vlr Parc. R$"
        Me.colValorParcela.FieldName = "ValorParcela"
        Me.colValorParcela.Name = "colValorParcela"
        Me.colValorParcela.OptionsColumn.ReadOnly = True
        Me.colValorParcela.Visible = True
        Me.colValorParcela.VisibleIndex = 6
        Me.colValorParcela.Width = 97
        '
        'colVencimento
        '
        Me.colVencimento.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colVencimento.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colVencimento.AppearanceCell.Options.UseBackColor = True
        Me.colVencimento.AppearanceCell.Options.UseTextOptions = True
        Me.colVencimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimento.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colVencimento.AppearanceHeader.BackColor2 = System.Drawing.Color.Black
        Me.colVencimento.AppearanceHeader.BorderColor = System.Drawing.Color.Black
        Me.colVencimento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVencimento.AppearanceHeader.Options.UseBackColor = True
        Me.colVencimento.AppearanceHeader.Options.UseBorderColor = True
        Me.colVencimento.AppearanceHeader.Options.UseFont = True
        Me.colVencimento.Caption = "Vencimento"
        Me.colVencimento.FieldName = "Vencimento"
        Me.colVencimento.Name = "colVencimento"
        Me.colVencimento.OptionsColumn.ReadOnly = True
        Me.colVencimento.Visible = True
        Me.colVencimento.VisibleIndex = 7
        Me.colVencimento.Width = 104
        '
        'colValorRecebido
        '
        Me.colValorRecebido.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colValorRecebido.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colValorRecebido.AppearanceCell.Options.UseBackColor = True
        Me.colValorRecebido.AppearanceCell.Options.UseTextOptions = True
        Me.colValorRecebido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorRecebido.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValorRecebido.AppearanceHeader.BackColor2 = System.Drawing.Color.Black
        Me.colValorRecebido.AppearanceHeader.BorderColor = System.Drawing.Color.Black
        Me.colValorRecebido.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValorRecebido.AppearanceHeader.Options.UseBackColor = True
        Me.colValorRecebido.AppearanceHeader.Options.UseBorderColor = True
        Me.colValorRecebido.AppearanceHeader.Options.UseFont = True
        Me.colValorRecebido.Caption = "Vlr Rec. R$"
        Me.colValorRecebido.FieldName = "ValorRecebido"
        Me.colValorRecebido.Name = "colValorRecebido"
        Me.colValorRecebido.OptionsColumn.ReadOnly = True
        Me.colValorRecebido.Visible = True
        Me.colValorRecebido.VisibleIndex = 8
        Me.colValorRecebido.Width = 104
        '
        'colRecebimento
        '
        Me.colRecebimento.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colRecebimento.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colRecebimento.AppearanceCell.Options.UseBackColor = True
        Me.colRecebimento.AppearanceCell.Options.UseTextOptions = True
        Me.colRecebimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRecebimento.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colRecebimento.AppearanceHeader.BackColor2 = System.Drawing.Color.Black
        Me.colRecebimento.AppearanceHeader.BorderColor = System.Drawing.Color.Black
        Me.colRecebimento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colRecebimento.AppearanceHeader.Options.UseBackColor = True
        Me.colRecebimento.AppearanceHeader.Options.UseBorderColor = True
        Me.colRecebimento.AppearanceHeader.Options.UseFont = True
        Me.colRecebimento.Caption = "Recebimento"
        Me.colRecebimento.FieldName = "Recebimento"
        Me.colRecebimento.Name = "colRecebimento"
        Me.colRecebimento.OptionsColumn.ReadOnly = True
        Me.colRecebimento.Visible = True
        Me.colRecebimento.VisibleIndex = 9
        Me.colRecebimento.Width = 112
        '
        'colCPF
        '
        Me.colCPF.AppearanceCell.Options.UseTextOptions = True
        Me.colCPF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCPF.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCPF.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCPF.AppearanceHeader.Options.UseBackColor = True
        Me.colCPF.AppearanceHeader.Options.UseFont = True
        Me.colCPF.Caption = "CPF/CNPJ"
        Me.colCPF.FieldName = "CPF"
        Me.colCPF.Name = "colCPF"
        Me.colCPF.Visible = True
        Me.colCPF.VisibleIndex = 2
        Me.colCPF.Width = 137
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
        Me.colCentroCusto.Width = 102
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblPeriodo, Me.lblTitulo, Me.XrLine3, Me.XrLine2, Me.picLogo})
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(175, 25)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitulo.Size = New System.Drawing.Size(908, 25)
        Me.lblTitulo.StylePriority.UseFont = False
        Me.lblTitulo.StylePriority.UseTextAlignment = False
        Me.lblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine3
        '
        Me.XrLine3.LineWidth = 2
        Me.XrLine3.Location = New System.Drawing.Point(0, 0)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.Size = New System.Drawing.Size(1083, 8)
        '
        'XrLine2
        '
        Me.XrLine2.LineWidth = 2
        Me.XrLine2.Location = New System.Drawing.Point(0, 92)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(1083, 8)
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
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodo.Location = New System.Drawing.Point(175, 50)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPeriodo.Size = New System.Drawing.Size(908, 25)
        Me.lblPeriodo.StylePriority.UseFont = False
        Me.lblPeriodo.StylePriority.UseTextAlignment = False
        Me.lblPeriodo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'relContaReceber
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.GroupFooter1})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(40, 40, 40, 40)
        Me.PageHeight = 827
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ShowPreviewMarginLines = False
        Me.Version = "8.2"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsRec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbRec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents lblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents picLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents dsRec As System.Data.DataSet
    Friend WithEvents tbRec As System.Data.DataTable
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
    Friend WithEvents WinControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParcelas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorParcela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencimento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorRecebido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecebimento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblRelTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents colCPF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblTotCom As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblCom As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents colCentroCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents lblPeriodo As DevExpress.XtraReports.UI.XRLabel
End Class
