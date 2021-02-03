<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relLucros
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
        Me.lblInterno = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblLucPec = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblGastos = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.lbl1 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblTotGas = New DevExpress.XtraReports.UI.XRLabel
        Me.lbl2 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblLucro = New DevExpress.XtraReports.UI.XRLabel
        Me.lblPro = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblTotal = New DevExpress.XtraReports.UI.XRLabel
        Me.lblObra = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.TotalGridControl = New DevExpress.XtraGrid.GridControl
        Me.dtTotal = New System.Data.DataSet
        Me.tbTotal = New System.Data.DataTable
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
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCod = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPlaca = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCPF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotalPecas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotalMaoDeObra = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRealizado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colModelo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAtendente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TotalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMecanica = New Nano.dsNanoCommerce
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.WinControlContainer2 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.TotalTableAdapter = New Nano.dsNanoCommerceTableAdapters.TotalTableAdapter
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        CType(Me.TotalGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMecanica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblInterno, Me.XrLabel6, Me.lblLucPec, Me.XrLabel5, Me.lblGastos, Me.XrLabel3, Me.lbl1, Me.lblTotGas, Me.lbl2, Me.lblLucro, Me.lblPro, Me.XrLabel1, Me.lblTotal, Me.lblObra, Me.XrLabel4, Me.XrLabel2, Me.WinControlContainer1})
        Me.Detail.Height = 317
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblInterno
        '
        Me.lblInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterno.Location = New System.Drawing.Point(925, 242)
        Me.lblInterno.Name = "lblInterno"
        Me.lblInterno.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblInterno.Size = New System.Drawing.Size(133, 17)
        Me.lblInterno.StylePriority.UseFont = False
        Me.lblInterno.StylePriority.UseTextAlignment = False
        Me.lblInterno.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.Location = New System.Drawing.Point(742, 242)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.Size = New System.Drawing.Size(175, 17)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Total Interno R$"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblLucPec
        '
        Me.lblLucPec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLucPec.Location = New System.Drawing.Point(925, 167)
        Me.lblLucPec.Name = "lblLucPec"
        Me.lblLucPec.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblLucPec.Size = New System.Drawing.Size(133, 17)
        Me.lblLucPec.StylePriority.UseFont = False
        Me.lblLucPec.StylePriority.UseTextAlignment = False
        Me.lblLucPec.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.Location = New System.Drawing.Point(742, 167)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.Size = New System.Drawing.Size(175, 17)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Lucro Produtos R$"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblGastos
        '
        Me.lblGastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGastos.Location = New System.Drawing.Point(925, 142)
        Me.lblGastos.Name = "lblGastos"
        Me.lblGastos.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblGastos.Size = New System.Drawing.Size(133, 17)
        Me.lblGastos.StylePriority.UseFont = False
        Me.lblGastos.StylePriority.UseTextAlignment = False
        Me.lblGastos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.Location = New System.Drawing.Point(742, 142)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.Size = New System.Drawing.Size(175, 17)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Total Custo R$"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lbl1
        '
        Me.lbl1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(750, 267)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbl1.Size = New System.Drawing.Size(167, 17)
        Me.lbl1.StylePriority.UseFont = False
        Me.lbl1.StylePriority.UseTextAlignment = False
        Me.lbl1.Text = "Total Custo R$"
        Me.lbl1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblTotGas
        '
        Me.lblTotGas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotGas.Location = New System.Drawing.Point(925, 267)
        Me.lblTotGas.Name = "lblTotGas"
        Me.lblTotGas.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTotGas.Size = New System.Drawing.Size(133, 17)
        Me.lblTotGas.StylePriority.UseFont = False
        Me.lblTotGas.StylePriority.UseTextAlignment = False
        Me.lblTotGas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lbl2
        '
        Me.lbl2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(758, 292)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbl2.Size = New System.Drawing.Size(158, 17)
        Me.lbl2.StylePriority.UseFont = False
        Me.lbl2.StylePriority.UseTextAlignment = False
        Me.lbl2.Text = "Lucro R$"
        Me.lbl2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblLucro
        '
        Me.lblLucro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLucro.Location = New System.Drawing.Point(925, 292)
        Me.lblLucro.Name = "lblLucro"
        Me.lblLucro.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblLucro.Size = New System.Drawing.Size(133, 17)
        Me.lblLucro.StylePriority.UseFont = False
        Me.lblLucro.StylePriority.UseTextAlignment = False
        Me.lblLucro.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblPro
        '
        Me.lblPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPro.Location = New System.Drawing.Point(925, 117)
        Me.lblPro.Name = "lblPro"
        Me.lblPro.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPro.Size = New System.Drawing.Size(133, 17)
        Me.lblPro.StylePriority.UseFont = False
        Me.lblPro.StylePriority.UseTextAlignment = False
        Me.lblPro.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.Location = New System.Drawing.Point(775, 217)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(142, 17)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Total Geral R$"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(925, 217)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTotal.Size = New System.Drawing.Size(133, 17)
        Me.lblTotal.StylePriority.UseFont = False
        Me.lblTotal.StylePriority.UseTextAlignment = False
        Me.lblTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblObra
        '
        Me.lblObra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObra.Location = New System.Drawing.Point(925, 192)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblObra.Size = New System.Drawing.Size(133, 17)
        Me.lblObra.StylePriority.UseFont = False
        Me.lblObra.StylePriority.UseTextAlignment = False
        Me.lblObra.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.Location = New System.Drawing.Point(775, 117)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.Size = New System.Drawing.Size(142, 17)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Total Produtos R$"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.Location = New System.Drawing.Point(742, 192)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.Size = New System.Drawing.Size(175, 17)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Total Serviços R$"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.Location = New System.Drawing.Point(0, 0)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.Size = New System.Drawing.Size(1108, 100)
        Me.WinControlContainer1.WinControl = Me.TotalGridControl
        '
        'TotalGridControl
        '
        Me.TotalGridControl.DataMember = "tbTotal"
        Me.TotalGridControl.DataSource = Me.dtTotal
        Me.TotalGridControl.EmbeddedNavigator.Name = ""
        Me.TotalGridControl.Location = New System.Drawing.Point(0, 24)
        Me.TotalGridControl.MainView = Me.grd1
        Me.TotalGridControl.Name = "TotalGridControl"
        Me.TotalGridControl.Size = New System.Drawing.Size(1064, 96)
        Me.TotalGridControl.TabIndex = 7
        Me.TotalGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dtTotal
        '
        Me.dtTotal.DataSetName = "NewDataSet"
        Me.dtTotal.Tables.AddRange(New System.Data.DataTable() {Me.tbTotal})
        '
        'tbTotal
        '
        Me.tbTotal.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14})
        Me.tbTotal.TableName = "tbTotal"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Codigo"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Cod"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Data"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Placa"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Cliente"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "CPF"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "TotalPecas"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "TotalMaoDeObra"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Total"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Realizado"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Custo"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "Modelo"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "Atendente"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "Interno"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colCod, Me.colData, Me.colPlaca, Me.colCliente, Me.colCPF, Me.colTotalPecas, Me.colTotalMaoDeObra, Me.colTotal, Me.colRealizado, Me.colInterno, Me.colCusto, Me.colModelo, Me.colAtendente})
        Me.grd1.GridControl = Me.TotalGridControl
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colCodigo.AppearanceCell.Options.UseBackColor = True
        Me.colCodigo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodigo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigo.AppearanceHeader.Options.UseBackColor = True
        Me.colCodigo.AppearanceHeader.Options.UseFont = True
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        '
        'colCod
        '
        Me.colCod.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colCod.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCod.AppearanceCell.Options.UseBackColor = True
        Me.colCod.AppearanceCell.Options.UseTextOptions = True
        Me.colCod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCod.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCod.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCod.AppearanceHeader.Options.UseBackColor = True
        Me.colCod.AppearanceHeader.Options.UseFont = True
        Me.colCod.Caption = "Pedido"
        Me.colCod.FieldName = "Cod"
        Me.colCod.Name = "colCod"
        Me.colCod.Visible = True
        Me.colCod.VisibleIndex = 0
        Me.colCod.Width = 68
        '
        'colData
        '
        Me.colData.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colData.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colData.AppearanceCell.Options.UseBackColor = True
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
        Me.colData.VisibleIndex = 1
        Me.colData.Width = 81
        '
        'colPlaca
        '
        Me.colPlaca.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colPlaca.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colPlaca.AppearanceCell.Options.UseBackColor = True
        Me.colPlaca.AppearanceCell.Options.UseTextOptions = True
        Me.colPlaca.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaca.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colPlaca.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPlaca.AppearanceHeader.Options.UseBackColor = True
        Me.colPlaca.AppearanceHeader.Options.UseFont = True
        Me.colPlaca.Caption = "Placa"
        Me.colPlaca.FieldName = "Placa"
        Me.colPlaca.Name = "colPlaca"
        Me.colPlaca.Visible = True
        Me.colPlaca.VisibleIndex = 2
        Me.colPlaca.Width = 74
        '
        'colCliente
        '
        Me.colCliente.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colCliente.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCliente.AppearanceCell.Options.UseBackColor = True
        Me.colCliente.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCliente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCliente.AppearanceHeader.Options.UseBackColor = True
        Me.colCliente.AppearanceHeader.Options.UseFont = True
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 4
        Me.colCliente.Width = 151
        '
        'colCPF
        '
        Me.colCPF.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colCPF.AppearanceCell.Options.UseBackColor = True
        Me.colCPF.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCPF.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCPF.AppearanceHeader.Options.UseBackColor = True
        Me.colCPF.AppearanceHeader.Options.UseFont = True
        Me.colCPF.Caption = "CPF"
        Me.colCPF.FieldName = "CPF"
        Me.colCPF.Name = "colCPF"
        '
        'colTotalPecas
        '
        Me.colTotalPecas.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colTotalPecas.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colTotalPecas.AppearanceCell.Options.UseBackColor = True
        Me.colTotalPecas.AppearanceCell.Options.UseTextOptions = True
        Me.colTotalPecas.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTotalPecas.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colTotalPecas.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTotalPecas.AppearanceHeader.Options.UseBackColor = True
        Me.colTotalPecas.AppearanceHeader.Options.UseFont = True
        Me.colTotalPecas.Caption = "Produtos R$"
        Me.colTotalPecas.FieldName = "TotalPecas"
        Me.colTotalPecas.Name = "colTotalPecas"
        Me.colTotalPecas.Visible = True
        Me.colTotalPecas.VisibleIndex = 5
        Me.colTotalPecas.Width = 90
        '
        'colTotalMaoDeObra
        '
        Me.colTotalMaoDeObra.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colTotalMaoDeObra.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colTotalMaoDeObra.AppearanceCell.Options.UseBackColor = True
        Me.colTotalMaoDeObra.AppearanceCell.Options.UseTextOptions = True
        Me.colTotalMaoDeObra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTotalMaoDeObra.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colTotalMaoDeObra.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTotalMaoDeObra.AppearanceHeader.Options.UseBackColor = True
        Me.colTotalMaoDeObra.AppearanceHeader.Options.UseFont = True
        Me.colTotalMaoDeObra.Caption = "Serviços R$"
        Me.colTotalMaoDeObra.FieldName = "TotalMaoDeObra"
        Me.colTotalMaoDeObra.Name = "colTotalMaoDeObra"
        Me.colTotalMaoDeObra.Visible = True
        Me.colTotalMaoDeObra.VisibleIndex = 6
        Me.colTotalMaoDeObra.Width = 93
        '
        'colTotal
        '
        Me.colTotal.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colTotal.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colTotal.AppearanceCell.Options.UseBackColor = True
        Me.colTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTotal.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colTotal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTotal.AppearanceHeader.Options.UseBackColor = True
        Me.colTotal.AppearanceHeader.Options.UseFont = True
        Me.colTotal.Caption = "Total R$"
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 7
        Me.colTotal.Width = 85
        '
        'colRealizado
        '
        Me.colRealizado.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colRealizado.AppearanceCell.Options.UseBackColor = True
        Me.colRealizado.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colRealizado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colRealizado.AppearanceHeader.Options.UseBackColor = True
        Me.colRealizado.AppearanceHeader.Options.UseFont = True
        Me.colRealizado.Caption = "Faturado?"
        Me.colRealizado.FieldName = "Realizado"
        Me.colRealizado.Name = "colRealizado"
        '
        'colInterno
        '
        Me.colInterno.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colInterno.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colInterno.AppearanceCell.Options.UseBackColor = True
        Me.colInterno.AppearanceCell.Options.UseTextOptions = True
        Me.colInterno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colInterno.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colInterno.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInterno.AppearanceHeader.Options.UseBackColor = True
        Me.colInterno.AppearanceHeader.Options.UseFont = True
        Me.colInterno.Caption = "Interno R$"
        Me.colInterno.FieldName = "Interno"
        Me.colInterno.Name = "colInterno"
        Me.colInterno.Visible = True
        Me.colInterno.VisibleIndex = 8
        Me.colInterno.Width = 90
        '
        'colCusto
        '
        Me.colCusto.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colCusto.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCusto.AppearanceCell.Options.UseBackColor = True
        Me.colCusto.AppearanceCell.Options.UseTextOptions = True
        Me.colCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCusto.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCusto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCusto.AppearanceHeader.Options.UseBackColor = True
        Me.colCusto.AppearanceHeader.Options.UseFont = True
        Me.colCusto.Caption = "Custo R$"
        Me.colCusto.FieldName = "Custo"
        Me.colCusto.Name = "colCusto"
        Me.colCusto.Visible = True
        Me.colCusto.VisibleIndex = 9
        Me.colCusto.Width = 89
        '
        'colModelo
        '
        Me.colModelo.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colModelo.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colModelo.AppearanceCell.Options.UseBackColor = True
        Me.colModelo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colModelo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colModelo.AppearanceHeader.Options.UseBackColor = True
        Me.colModelo.AppearanceHeader.Options.UseFont = True
        Me.colModelo.Caption = "Modelo"
        Me.colModelo.FieldName = "Modelo"
        Me.colModelo.Name = "colModelo"
        Me.colModelo.Visible = True
        Me.colModelo.VisibleIndex = 3
        Me.colModelo.Width = 112
        '
        'colAtendente
        '
        Me.colAtendente.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colAtendente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAtendente.AppearanceHeader.Options.UseBackColor = True
        Me.colAtendente.AppearanceHeader.Options.UseFont = True
        Me.colAtendente.Caption = "Atendente"
        Me.colAtendente.FieldName = "Atendente"
        Me.colAtendente.Name = "colAtendente"
        Me.colAtendente.Visible = True
        Me.colAtendente.VisibleIndex = 10
        Me.colAtendente.Width = 155
        '
        'TotalBindingSource
        '
        Me.TotalBindingSource.DataMember = "Total"
        Me.TotalBindingSource.DataSource = Me.DsMecanica
        '
        'DsMecanica
        '
        Me.DsMecanica.DataSetName = "dsMecanica"
        Me.DsMecanica.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.WinControlContainer2, Me.lblTitulo, Me.XrLine3, Me.XrLine2})
        Me.PageHeader.Height = 105
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'WinControlContainer2
        '
        Me.WinControlContainer2.Location = New System.Drawing.Point(0, 25)
        Me.WinControlContainer2.Name = "WinControlContainer2"
        Me.WinControlContainer2.Size = New System.Drawing.Size(156, 62)
        Me.WinControlContainer2.WinControl = Me.picLogo
        '
        'picLogo
        '
        Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picLogo.ErrorImage = Nothing
        Me.picLogo.ImageLocation = ""
        Me.picLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picLogo.InitialImage = Nothing
        Me.picLogo.Location = New System.Drawing.Point(10, 69)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(150, 60)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(283, 42)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitulo.Size = New System.Drawing.Size(592, 33)
        Me.lblTitulo.StylePriority.UseFont = False
        Me.lblTitulo.StylePriority.UseTextAlignment = False
        Me.lblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine3
        '
        Me.XrLine3.LineWidth = 2
        Me.XrLine3.Location = New System.Drawing.Point(0, 8)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.Size = New System.Drawing.Size(1100, 8)
        '
        'XrLine2
        '
        Me.XrLine2.LineWidth = 2
        Me.XrLine2.Location = New System.Drawing.Point(0, 92)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(1100, 8)
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2, Me.XrPageInfo1})
        Me.PageFooter.Height = 25
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.Location = New System.Drawing.Point(817, 8)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.Size = New System.Drawing.Size(267, 17)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'TotalTableAdapter
        '
        Me.TotalTableAdapter.ClearBeforeFill = True
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo2.Location = New System.Drawing.Point(492, 8)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.Size = New System.Drawing.Size(125, 17)
        Me.XrPageInfo2.StylePriority.UseFont = False
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'relLucros
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(30, 30, 30, 30)
        Me.PageHeight = 827
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ShowPreviewMarginLines = False
        Me.Version = "8.2"
        CType(Me.TotalGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMecanica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents WinControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents TotalGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents TotalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsMecanica As Nano.dsNanoCommerce
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCPF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalPecas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalMaoDeObra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRealizado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TotalTableAdapter As Nano.dsNanoCommerceTableAdapters.TotalTableAdapter
    Friend WithEvents lbl1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTotGas As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbl2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblLucro As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblObra As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblPro As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents colModelo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblInterno As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblLucPec As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblGastos As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents WinControlContainer2 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents colAtendente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtTotal As System.Data.DataSet
    Friend WithEvents tbTotal As System.Data.DataTable
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
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
End Class
