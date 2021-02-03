<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relCaixa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(relCaixa))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.lblSaldoAtual = New DevExpress.XtraReports.UI.XRLabel
        Me.lblLabelSaldoAtual = New DevExpress.XtraReports.UI.XRLabel
        Me.lblTotDeb = New DevExpress.XtraReports.UI.XRRichText
        Me.lblTotCred = New DevExpress.XtraReports.UI.XRRichText
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine6 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine
        Me.lblSaldo = New DevExpress.XtraReports.UI.XRLabel
        Me.lblDeb = New DevExpress.XtraReports.UI.XRLabel
        Me.lblCre = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.WinControlContainer2 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.dsCaixa = New System.Data.DataSet
        Me.tbCred = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.tbDeb = New System.Data.DataTable
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMotivo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPagamento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCaixa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colData1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMotivo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPagamento1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCaixa1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle
        CType(Me.lblTotDeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTotCred, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCaixa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCred, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbDeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblSaldoAtual, Me.lblLabelSaldoAtual, Me.lblTotDeb, Me.lblTotCred, Me.XrLabel5, Me.XrLabel6, Me.XrLine6, Me.XrLine5, Me.lblSaldo, Me.lblDeb, Me.lblCre, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9, Me.XrLine4, Me.XrLabel2, Me.XrLine1, Me.XrLabel1, Me.WinControlContainer2, Me.WinControlContainer1})
        Me.Detail.Height = 350
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblSaldoAtual
        '
        Me.lblSaldoAtual.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoAtual.Location = New System.Drawing.Point(608, 325)
        Me.lblSaldoAtual.Name = "lblSaldoAtual"
        Me.lblSaldoAtual.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblSaldoAtual.Size = New System.Drawing.Size(133, 17)
        Me.lblSaldoAtual.StylePriority.UseFont = False
        Me.lblSaldoAtual.StylePriority.UseTextAlignment = False
        Me.lblSaldoAtual.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblSaldoAtual.Visible = False
        '
        'lblLabelSaldoAtual
        '
        Me.lblLabelSaldoAtual.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabelSaldoAtual.Location = New System.Drawing.Point(433, 325)
        Me.lblLabelSaldoAtual.Name = "lblLabelSaldoAtual"
        Me.lblLabelSaldoAtual.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblLabelSaldoAtual.Size = New System.Drawing.Size(167, 17)
        Me.lblLabelSaldoAtual.StylePriority.UseFont = False
        Me.lblLabelSaldoAtual.StylePriority.UseTextAlignment = False
        Me.lblLabelSaldoAtual.Text = "Saldo Atual R$"
        Me.lblLabelSaldoAtual.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblLabelSaldoAtual.Visible = False
        '
        'lblTotDeb
        '
        Me.lblTotDeb.EvenStyleName = "XrControlStyle1"
        Me.lblTotDeb.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotDeb.Location = New System.Drawing.Point(217, 250)
        Me.lblTotDeb.Name = "lblTotDeb"
        Me.lblTotDeb.OddStyleName = "XrControlStyle1"
        Me.lblTotDeb.SerializableRtfString = resources.GetString("lblTotDeb.SerializableRtfString")
        Me.lblTotDeb.Size = New System.Drawing.Size(200, 92)
        Me.lblTotDeb.StyleName = "XrControlStyle1"
        '
        'lblTotCred
        '
        Me.lblTotCred.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotCred.Location = New System.Drawing.Point(8, 250)
        Me.lblTotCred.Name = "lblTotCred"
        Me.lblTotCred.SerializableRtfString = resources.GetString("lblTotCred.SerializableRtfString")
        Me.lblTotCred.Size = New System.Drawing.Size(200, 92)
        Me.lblTotCred.StylePriority.UseFont = False
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.Location = New System.Drawing.Point(217, 233)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.Size = New System.Drawing.Size(183, 17)
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Pagamentos Débitos"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.Location = New System.Drawing.Point(8, 233)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.Size = New System.Drawing.Size(183, 17)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Pagamentos Créditos"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine6
        '
        Me.XrLine6.Location = New System.Drawing.Point(608, 272)
        Me.XrLine6.Name = "XrLine6"
        Me.XrLine6.Size = New System.Drawing.Size(133, 6)
        '
        'XrLine5
        '
        Me.XrLine5.LineWidth = 2
        Me.XrLine5.Location = New System.Drawing.Point(0, 217)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.Size = New System.Drawing.Size(750, 8)
        '
        'lblSaldo
        '
        Me.lblSaldo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.Location = New System.Drawing.Point(608, 283)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblSaldo.Size = New System.Drawing.Size(133, 17)
        Me.lblSaldo.StylePriority.UseFont = False
        Me.lblSaldo.StylePriority.UseTextAlignment = False
        Me.lblSaldo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblDeb
        '
        Me.lblDeb.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeb.Location = New System.Drawing.Point(608, 250)
        Me.lblDeb.Name = "lblDeb"
        Me.lblDeb.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblDeb.Size = New System.Drawing.Size(133, 17)
        Me.lblDeb.StylePriority.UseFont = False
        Me.lblDeb.StylePriority.UseTextAlignment = False
        Me.lblDeb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblCre
        '
        Me.lblCre.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCre.Location = New System.Drawing.Point(608, 233)
        Me.lblCre.Name = "lblCre"
        Me.lblCre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblCre.Size = New System.Drawing.Size(133, 17)
        Me.lblCre.StylePriority.UseFont = False
        Me.lblCre.StylePriority.UseTextAlignment = False
        Me.lblCre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.Location = New System.Drawing.Point(433, 283)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.Size = New System.Drawing.Size(167, 17)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Saldo R$"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.Location = New System.Drawing.Point(433, 250)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.Size = New System.Drawing.Size(167, 17)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Total de Débitos R$"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.Location = New System.Drawing.Point(433, 233)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.Size = New System.Drawing.Size(167, 17)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Total de Créditos R$"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLine4
        '
        Me.XrLine4.LineWidth = 2
        Me.XrLine4.Location = New System.Drawing.Point(75, 108)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.Size = New System.Drawing.Size(675, 8)
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.Location = New System.Drawing.Point(0, 100)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.Size = New System.Drawing.Size(75, 17)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "Débitos"
        '
        'XrLine1
        '
        Me.XrLine1.LineWidth = 2
        Me.XrLine1.Location = New System.Drawing.Point(75, 8)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(675, 8)
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.Location = New System.Drawing.Point(0, 0)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(75, 17)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "Créditos"
        '
        'WinControlContainer2
        '
        Me.WinControlContainer2.Location = New System.Drawing.Point(0, 25)
        Me.WinControlContainer2.Name = "WinControlContainer2"
        Me.WinControlContainer2.Size = New System.Drawing.Size(750, 67)
        Me.WinControlContainer2.WinControl = Me.GridControl2
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "tbCred"
        Me.GridControl2.DataSource = Me.dsCaixa
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(720, 64)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'dsCaixa
        '
        Me.dsCaixa.DataSetName = "NewDataSet"
        Me.dsCaixa.Tables.AddRange(New System.Data.DataTable() {Me.tbCred, Me.tbDeb})
        '
        'tbCred
        '
        Me.tbCred.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn4, Me.DataColumn5, Me.DataColumn3})
        Me.tbCred.TableName = "tbCred"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Data"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Motivo"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Pagamento"
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "Valor R$"
        Me.DataColumn5.ColumnName = "Valor"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Caixa"
        '
        'tbDeb
        '
        Me.tbDeb.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn6, Me.DataColumn7, Me.DataColumn9, Me.DataColumn10, Me.DataColumn8})
        Me.tbDeb.TableName = "tbDeb"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Data"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Motivo"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Pagamento"
        '
        'DataColumn10
        '
        Me.DataColumn10.Caption = "Valor R$"
        Me.DataColumn10.ColumnName = "Valor"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Caixa"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colData, Me.colMotivo, Me.colPagamento, Me.colValor, Me.colCaixa})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colData
        '
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
        Me.colData.Width = 66
        '
        'colMotivo
        '
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
        Me.colMotivo.VisibleIndex = 2
        Me.colMotivo.Width = 400
        '
        'colPagamento
        '
        Me.colPagamento.AppearanceCell.Options.UseTextOptions = True
        Me.colPagamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPagamento.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colPagamento.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colPagamento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPagamento.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colPagamento.AppearanceHeader.Options.UseBackColor = True
        Me.colPagamento.AppearanceHeader.Options.UseFont = True
        Me.colPagamento.AppearanceHeader.Options.UseForeColor = True
        Me.colPagamento.Caption = "Pagamento"
        Me.colPagamento.FieldName = "Pagamento"
        Me.colPagamento.Name = "colPagamento"
        Me.colPagamento.Visible = True
        Me.colPagamento.VisibleIndex = 3
        Me.colPagamento.Width = 72
        '
        'colValor
        '
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
        Me.colValor.VisibleIndex = 4
        '
        'colCaixa
        '
        Me.colCaixa.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCaixa.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colCaixa.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCaixa.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colCaixa.AppearanceHeader.Options.UseBackColor = True
        Me.colCaixa.AppearanceHeader.Options.UseFont = True
        Me.colCaixa.AppearanceHeader.Options.UseForeColor = True
        Me.colCaixa.Caption = "Caixa"
        Me.colCaixa.FieldName = "Caixa"
        Me.colCaixa.Name = "colCaixa"
        Me.colCaixa.Visible = True
        Me.colCaixa.VisibleIndex = 1
        Me.colCaixa.Width = 85
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.Location = New System.Drawing.Point(0, 125)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.Size = New System.Drawing.Size(750, 83)
        Me.WinControlContainer1.WinControl = Me.GridControl1
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbDeb"
        Me.GridControl1.DataSource = Me.dsCaixa
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(720, 80)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colData1, Me.colMotivo1, Me.colPagamento1, Me.colValor1, Me.colCaixa1})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colData1
        '
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
        Me.colData1.Width = 66
        '
        'colMotivo1
        '
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
        Me.colMotivo1.VisibleIndex = 2
        Me.colMotivo1.Width = 400
        '
        'colPagamento1
        '
        Me.colPagamento1.AppearanceCell.Options.UseTextOptions = True
        Me.colPagamento1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPagamento1.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colPagamento1.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colPagamento1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPagamento1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colPagamento1.AppearanceHeader.Options.UseBackColor = True
        Me.colPagamento1.AppearanceHeader.Options.UseFont = True
        Me.colPagamento1.AppearanceHeader.Options.UseForeColor = True
        Me.colPagamento1.Caption = "Pagamento"
        Me.colPagamento1.FieldName = "Pagamento"
        Me.colPagamento1.Name = "colPagamento1"
        Me.colPagamento1.Visible = True
        Me.colPagamento1.VisibleIndex = 3
        Me.colPagamento1.Width = 72
        '
        'colValor1
        '
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
        Me.colValor1.VisibleIndex = 4
        '
        'colCaixa1
        '
        Me.colCaixa1.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCaixa1.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colCaixa1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCaixa1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colCaixa1.AppearanceHeader.Options.UseBackColor = True
        Me.colCaixa1.AppearanceHeader.Options.UseFont = True
        Me.colCaixa1.AppearanceHeader.Options.UseForeColor = True
        Me.colCaixa1.Caption = "Caixa"
        Me.colCaixa1.FieldName = "Caixa"
        Me.colCaixa1.Name = "colCaixa1"
        Me.colCaixa1.Visible = True
        Me.colCaixa1.VisibleIndex = 1
        Me.colCaixa1.Width = 86
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblTitulo, Me.XrLine3, Me.XrLine2, Me.picLogo})
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(158, 33)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitulo.Size = New System.Drawing.Size(533, 25)
        Me.lblTitulo.StylePriority.UseFont = False
        Me.lblTitulo.StylePriority.UseTextAlignment = False
        Me.lblTitulo.Text = "Relatório de Caixa"
        Me.lblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine3
        '
        Me.XrLine3.LineWidth = 2
        Me.XrLine3.Location = New System.Drawing.Point(0, 0)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.Size = New System.Drawing.Size(750, 8)
        '
        'XrLine2
        '
        Me.XrLine2.LineWidth = 2
        Me.XrLine2.Location = New System.Drawing.Point(0, 92)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(750, 8)
        '
        'picLogo
        '
        Me.picLogo.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.picLogo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.picLogo.ImageUrl = "C:\NANO\Logo.png"
        Me.picLogo.Location = New System.Drawing.Point(0, 17)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(150, 65)
        Me.picLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.picLogo.StylePriority.UseBorderColor = False
        Me.picLogo.StylePriority.UseBorders = False
        '
        'PageFooter
        '
        Me.PageFooter.Height = 11
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrControlStyle1
        '
        Me.XrControlStyle1.Name = "XrControlStyle1"
        Me.XrControlStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'relCaixa
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Margins = New System.Drawing.Printing.Margins(35, 35, 35, 35)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ShowPreviewMarginLines = False
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.XrControlStyle1})
        Me.Version = "8.2"
        CType(Me.lblTotDeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTotCred, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCaixa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCred, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbDeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents dsCaixa As System.Data.DataSet
    Friend WithEvents tbCred As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents tbDeb As System.Data.DataTable
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents WinControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents WinControlContainer2 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMotivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMotivo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagamento1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents picLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblSaldo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblDeb As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblCre As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine6 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTotDeb As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents lblTotCred As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents colCaixa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCaixa1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblSaldoAtual As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblLabelSaldoAtual As DevExpress.XtraReports.UI.XRLabel
End Class
