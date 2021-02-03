<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relDRE
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblDataInicial = New DevExpress.XtraReports.UI.XRLabel
        Me.lblDataFinal = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.WinControlContainer4 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.dsDre = New System.Data.DataSet
        Me.tbFor = New System.Data.DataTable
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn62 = New System.Data.DataColumn
        Me.DataColumn63 = New System.Data.DataColumn
        Me.tbContaV = New System.Data.DataTable
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        Me.DataColumn52 = New System.Data.DataColumn
        Me.DataColumn53 = New System.Data.DataColumn
        Me.DataColumn54 = New System.Data.DataColumn
        Me.DataColumn55 = New System.Data.DataColumn
        Me.tbContaF = New System.Data.DataTable
        Me.DataColumn56 = New System.Data.DataColumn
        Me.DataColumn57 = New System.Data.DataColumn
        Me.DataColumn58 = New System.Data.DataColumn
        Me.DataColumn59 = New System.Data.DataColumn
        Me.DataColumn60 = New System.Data.DataColumn
        Me.DataColumn61 = New System.Data.DataColumn
        Me.tbReceitas = New System.Data.DataTable
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn64 = New System.Data.DataColumn
        Me.DataColumn65 = New System.Data.DataColumn
        Me.DataColumn66 = New System.Data.DataColumn
        Me.tbDespesas = New System.Data.DataTable
        Me.DataColumn68 = New System.Data.DataColumn
        Me.DataColumn69 = New System.Data.DataColumn
        Me.DataColumn70 = New System.Data.DataColumn
        Me.DataColumn71 = New System.Data.DataColumn
        Me.DataColumn72 = New System.Data.DataColumn
        Me.tbInvest = New System.Data.DataTable
        Me.DataColumn74 = New System.Data.DataColumn
        Me.DataColumn75 = New System.Data.DataColumn
        Me.DataColumn76 = New System.Data.DataColumn
        Me.DataColumn77 = New System.Data.DataColumn
        Me.DataColumn78 = New System.Data.DataColumn
        Me.DataColumn79 = New System.Data.DataColumn
        Me.tbRLucros = New System.Data.DataTable
        Me.DataColumn80 = New System.Data.DataColumn
        Me.DataColumn81 = New System.Data.DataColumn
        Me.DataColumn82 = New System.Data.DataColumn
        Me.DataColumn83 = New System.Data.DataColumn
        Me.DataColumn84 = New System.Data.DataColumn
        Me.DataColumn85 = New System.Data.DataColumn
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn49 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine6 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.WinControlContainer3 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colTipoConta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumeroDocumento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVencimento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataPagamento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XrLine7 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine9 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.WinControlContainer2 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colTipoConta1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumeroDocumento1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNome1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVencimento1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataPagamento1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.WinControlContainer5 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colObs = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNomeBanco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine8 = New DevExpress.XtraReports.UI.XRLine
        Me.WinControlContainer6 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colTipoConta3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumeroDocumento3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNome3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVencimento3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine10 = New DevExpress.XtraReports.UI.XRLine
        Me.WinControlContainer7 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl5 = New DevExpress.XtraGrid.GridControl
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colTipoConta4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumeroDocumento4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNome4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVencimento4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataPagamento4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine12 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.WinControlContainer8 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl8 = New DevExpress.XtraGrid.GridControl
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colTipoConta5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumeroDocumento5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNome5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVencimento5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataPagamento5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine13 = New DevExpress.XtraReports.UI.XRLine
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.GridControl7 = New DevExpress.XtraGrid.GridControl
        Me.GridView13 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView14 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridControl6 = New DevExpress.XtraGrid.GridControl
        Me.GridView31 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView32 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsDre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbContaV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbContaF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbReceitas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbDespesas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbInvest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbRLucros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.GridColumn5.AppearanceCell.Options.UseFont = True
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn5.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.GridColumn5.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn5.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn5.AppearanceHeader.Options.UseBackColor = True
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn5.Caption = "1. VENDAS TOTAIS"
        Me.GridColumn5.FieldName = "Grupo"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Width = 50
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceCell.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn13.AppearanceCell.Options.UseFont = True
        Me.GridColumn13.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn13.Caption = "GridColumn1"
        Me.GridColumn13.FieldName = "Pagamento"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 0
        Me.GridColumn13.Width = 132
        '
        'GridColumn31
        '
        Me.GridColumn31.AppearanceCell.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn31.AppearanceCell.Options.UseFont = True
        Me.GridColumn31.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn31.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn31.Caption = "GridColumn1"
        Me.GridColumn31.FieldName = "Pagamento"
        Me.GridColumn31.Name = "GridColumn31"
        Me.GridColumn31.Visible = True
        Me.GridColumn31.VisibleIndex = 0
        Me.GridColumn31.Width = 132
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel22, Me.XrLabel20, Me.lblDataInicial, Me.lblDataFinal, Me.XrLine1, Me.WinControlContainer4, Me.XrLabel1, Me.XrLine6, Me.XrLabel3, Me.XrLabel2, Me.WinControlContainer3, Me.XrLine7, Me.XrLabel4, Me.XrLabel5, Me.XrLine9, Me.XrLine4, Me.XrLabel6, Me.XrLabel7, Me.WinControlContainer2, Me.XrLabel8, Me.XrLabel9, Me.XrLine5, Me.XrLabel12, Me.XrLabel10, Me.XrLabel11, Me.WinControlContainer5, Me.XrLabel13, Me.XrLine8, Me.WinControlContainer6, Me.XrLabel14, Me.XrLabel15, Me.XrLine10, Me.WinControlContainer7, Me.XrLabel16, Me.XrLine12, Me.XrLabel17, Me.WinControlContainer8, Me.XrLabel18, Me.XrLine13})
        Me.Detail.Height = 1153
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel22
        '
        Me.XrLabel22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel22.Location = New System.Drawing.Point(375, 1125)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.Size = New System.Drawing.Size(367, 17)
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "Total R$"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel20
        '
        Me.XrLabel20.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel20.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.XrLabel20.Location = New System.Drawing.Point(0, 1092)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.Size = New System.Drawing.Size(600, 25)
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseForeColor = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "10. Lucro Líquido (5+6-8-9-7):"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblDataInicial
        '
        Me.lblDataInicial.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataInicial.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDataInicial.Location = New System.Drawing.Point(0, 17)
        Me.lblDataInicial.Name = "lblDataInicial"
        Me.lblDataInicial.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblDataInicial.Size = New System.Drawing.Size(358, 25)
        Me.lblDataInicial.StylePriority.UseFont = False
        Me.lblDataInicial.StylePriority.UseForeColor = False
        Me.lblDataInicial.StylePriority.UseTextAlignment = False
        Me.lblDataInicial.Text = "Valores referentes ao período de "
        Me.lblDataInicial.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblDataFinal
        '
        Me.lblDataFinal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataFinal.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDataFinal.Location = New System.Drawing.Point(358, 17)
        Me.lblDataFinal.Name = "lblDataFinal"
        Me.lblDataFinal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblDataFinal.Size = New System.Drawing.Size(233, 25)
        Me.lblDataFinal.StylePriority.UseFont = False
        Me.lblDataFinal.StylePriority.UseForeColor = False
        Me.lblDataFinal.StylePriority.UseTextAlignment = False
        Me.lblDataFinal.Text = "até "
        Me.lblDataFinal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine1
        '
        Me.XrLine1.Location = New System.Drawing.Point(0, 42)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(742, 8)
        '
        'WinControlContainer4
        '
        Me.WinControlContainer4.Location = New System.Drawing.Point(0, 92)
        Me.WinControlContainer4.Name = "WinControlContainer4"
        Me.WinControlContainer4.Size = New System.Drawing.Size(742, 45)
        Me.WinControlContainer4.WinControl = Me.Grid1
        '
        'Grid1
        '
        Me.Grid1.DataMember = "tbFor"
        Me.Grid1.DataSource = Me.dsDre
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(10, 15)
        Me.Grid1.MainView = Me.GridView5
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(712, 43)
        Me.Grid1.TabIndex = 6
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5, Me.GridView6})
        '
        'dsDre
        '
        Me.dsDre.DataSetName = "NewDataSet"
        Me.dsDre.Tables.AddRange(New System.Data.DataTable() {Me.tbFor, Me.tbContaV, Me.tbContaF, Me.tbReceitas, Me.tbDespesas, Me.tbInvest, Me.tbRLucros})
        '
        'tbFor
        '
        Me.tbFor.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn62, Me.DataColumn63})
        Me.tbFor.TableName = "tbFor"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "Fornecedor"
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "CodFor"
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "Total"
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "Documento"
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "Grupo"
        '
        'tbContaV
        '
        Me.tbContaV.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55})
        Me.tbContaV.TableName = "tbContaV"
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "TipoConta"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "NumeroDocumento"
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "Nome"
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "Vencimento"
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "Valor"
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "DataPagamento"
        '
        'tbContaF
        '
        Me.tbContaF.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61})
        Me.tbContaF.TableName = "tbContaF"
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "TipoContaF"
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "NumeroDocumentoF"
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "NomeF"
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "VencimentoF"
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "ValorF"
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "DataPagamentoF"
        '
        'tbReceitas
        '
        Me.tbReceitas.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn45, Me.DataColumn46, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66})
        Me.tbReceitas.TableName = "tbReceitas"
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "Observacao"
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "Codigo"
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "NomeBanco"
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "Data"
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "Valor"
        '
        'tbDespesas
        '
        Me.tbDespesas.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn68, Me.DataColumn69, Me.DataColumn70, Me.DataColumn71, Me.DataColumn72})
        Me.tbDespesas.TableName = "tbDespesas"
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "Observacao"
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "Codigo"
        '
        'DataColumn70
        '
        Me.DataColumn70.ColumnName = "NomeBanco"
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "Data"
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "Valor"
        '
        'tbInvest
        '
        Me.tbInvest.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn74, Me.DataColumn75, Me.DataColumn76, Me.DataColumn77, Me.DataColumn78, Me.DataColumn79})
        Me.tbInvest.TableName = "tbInvest"
        '
        'DataColumn74
        '
        Me.DataColumn74.ColumnName = "TipoConta"
        '
        'DataColumn75
        '
        Me.DataColumn75.ColumnName = "NumeroDocumento"
        '
        'DataColumn76
        '
        Me.DataColumn76.ColumnName = "Nome"
        '
        'DataColumn77
        '
        Me.DataColumn77.ColumnName = "Vencimento"
        '
        'DataColumn78
        '
        Me.DataColumn78.ColumnName = "Valor"
        '
        'DataColumn79
        '
        Me.DataColumn79.ColumnName = "DataPagamento"
        '
        'tbRLucros
        '
        Me.tbRLucros.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn80, Me.DataColumn81, Me.DataColumn82, Me.DataColumn83, Me.DataColumn84, Me.DataColumn85})
        Me.tbRLucros.TableName = "tbRLucros"
        '
        'DataColumn80
        '
        Me.DataColumn80.ColumnName = "TipoConta"
        '
        'DataColumn81
        '
        Me.DataColumn81.ColumnName = "NumeroDocumento"
        '
        'DataColumn82
        '
        Me.DataColumn82.ColumnName = "Nome"
        '
        'DataColumn83
        '
        Me.DataColumn83.ColumnName = "Vencimento"
        '
        'DataColumn84
        '
        Me.DataColumn84.ColumnName = "Valor"
        '
        'DataColumn85
        '
        Me.DataColumn85.ColumnName = "DataPagamento"
        '
        'GridView5
        '
        Me.GridView5.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.GridView5.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView5.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent
        Me.GridView5.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView5.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridView5.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.White
        Me.GridView5.Appearance.FooterPanel.BorderColor = System.Drawing.Color.White
        Me.GridView5.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView5.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView5.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.GridView5.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.White
        Me.GridView5.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.White
        Me.GridView5.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.GridView5.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView5.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView5.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView5.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.GridView5.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView5.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent
        Me.GridView5.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView5.AppearancePrint.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridView5.AppearancePrint.FooterPanel.BackColor2 = System.Drawing.Color.White
        Me.GridView5.AppearancePrint.FooterPanel.BorderColor = System.Drawing.Color.White
        Me.GridView5.AppearancePrint.FooterPanel.Options.UseBackColor = True
        Me.GridView5.AppearancePrint.FooterPanel.Options.UseBorderColor = True
        Me.GridView5.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.GridView5.AppearancePrint.HeaderPanel.Options.UseBackColor = True
        Me.GridView5.AppearancePrint.Lines.BackColor = System.Drawing.Color.White
        Me.GridView5.AppearancePrint.Lines.Options.UseBackColor = True
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6, Me.GridColumn49, Me.GridColumn1})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Blue
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.GridColumn5
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "Total R$"
        Me.GridView5.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GridView5.GridControl = Me.Grid1
        Me.GridView5.GroupCount = 1
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsView.ShowDetailButtons = False
        Me.GridView5.OptionsView.ShowHorzLines = False
        Me.GridView5.OptionsView.ShowIndicator = False
        Me.GridView5.OptionsView.ShowPreviewLines = False
        Me.GridView5.OptionsView.ShowVertLines = False
        Me.GridView5.RowHeight = 19
        Me.GridView5.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn5, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.GridColumn6.AppearanceCell.Options.UseFont = True
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn6.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.GridColumn6.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn6.AppearanceHeader.Options.UseBackColor = True
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn6.Caption = "Razão"
        Me.GridColumn6.FieldName = "Fornecedor"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 901
        '
        'GridColumn49
        '
        Me.GridColumn49.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn49.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn49.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.GridColumn49.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.GridColumn49.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn49.AppearanceHeader.Options.UseBackColor = True
        Me.GridColumn49.AppearanceHeader.Options.UseFont = True
        Me.GridColumn49.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn49.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn49.Caption = "Vlr Total R$ "
        Me.GridColumn49.FieldName = "Total"
        Me.GridColumn49.Name = "GridColumn49"
        Me.GridColumn49.Visible = True
        Me.GridColumn49.VisibleIndex = 2
        Me.GridColumn49.Width = 136
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.GridColumn1.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn1.AppearanceHeader.Options.UseBackColor = True
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn1.Caption = "Cód."
        Me.GridColumn1.FieldName = "Documento"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 154
        '
        'GridView6
        '
        Me.GridView6.GridControl = Me.Grid1
        Me.GridView6.Name = "GridView6"
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.Location = New System.Drawing.Point(367, 142)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(375, 17)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Total R$"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLine6
        '
        Me.XrLine6.Location = New System.Drawing.Point(0, 167)
        Me.XrLine6.Name = "XrLine6"
        Me.XrLine6.Size = New System.Drawing.Size(742, 8)
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.XrLabel3.Location = New System.Drawing.Point(0, 183)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.Size = New System.Drawing.Size(600, 25)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "2. Custos Variáveis:"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.Location = New System.Drawing.Point(375, 267)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.Size = New System.Drawing.Size(367, 17)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Total R$"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'WinControlContainer3
        '
        Me.WinControlContainer3.Location = New System.Drawing.Point(0, 217)
        Me.WinControlContainer3.Name = "WinControlContainer3"
        Me.WinControlContainer3.Size = New System.Drawing.Size(742, 42)
        Me.WinControlContainer3.WinControl = Me.GridControl1
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbContaV"
        Me.GridControl1.DataSource = Me.dsDre
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(712, 40)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.AppearancePrint.Lines.BackColor = System.Drawing.Color.White
        Me.GridView1.AppearancePrint.Lines.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTipoConta, Me.colNumeroDocumento, Me.colNome, Me.colVencimento, Me.colValor, Me.colDataPagamento})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowHorzLines = False
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.OptionsView.ShowPreviewLines = False
        Me.GridView1.OptionsView.ShowVertLines = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTipoConta, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colTipoConta
        '
        Me.colTipoConta.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colTipoConta.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colTipoConta.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colTipoConta.AppearanceHeader.Options.UseBackColor = True
        Me.colTipoConta.AppearanceHeader.Options.UseFont = True
        Me.colTipoConta.Caption = "TIPO DE CONTA"
        Me.colTipoConta.FieldName = "TipoConta"
        Me.colTipoConta.Name = "colTipoConta"
        Me.colTipoConta.Visible = True
        Me.colTipoConta.VisibleIndex = 0
        '
        'colNumeroDocumento
        '
        Me.colNumeroDocumento.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNumeroDocumento.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colNumeroDocumento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumeroDocumento.AppearanceHeader.Options.UseBackColor = True
        Me.colNumeroDocumento.AppearanceHeader.Options.UseFont = True
        Me.colNumeroDocumento.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumeroDocumento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colNumeroDocumento.Caption = "Doc."
        Me.colNumeroDocumento.FieldName = "NumeroDocumento"
        Me.colNumeroDocumento.Name = "colNumeroDocumento"
        Me.colNumeroDocumento.Visible = True
        Me.colNumeroDocumento.VisibleIndex = 0
        Me.colNumeroDocumento.Width = 172
        '
        'colNome
        '
        Me.colNome.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNome.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colNome.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNome.AppearanceHeader.Options.UseBackColor = True
        Me.colNome.AppearanceHeader.Options.UseFont = True
        Me.colNome.AppearanceHeader.Options.UseTextOptions = True
        Me.colNome.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colNome.Caption = "Razão"
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.Visible = True
        Me.colNome.VisibleIndex = 1
        Me.colNome.Width = 535
        '
        'colVencimento
        '
        Me.colVencimento.AppearanceCell.Options.UseTextOptions = True
        Me.colVencimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimento.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colVencimento.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colVencimento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVencimento.AppearanceHeader.Options.UseBackColor = True
        Me.colVencimento.AppearanceHeader.Options.UseFont = True
        Me.colVencimento.AppearanceHeader.Options.UseTextOptions = True
        Me.colVencimento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimento.Caption = "Vencimento"
        Me.colVencimento.FieldName = "Vencimento"
        Me.colVencimento.Name = "colVencimento"
        Me.colVencimento.Visible = True
        Me.colVencimento.VisibleIndex = 2
        Me.colVencimento.Width = 183
        '
        'colValor
        '
        Me.colValor.AppearanceCell.Options.UseTextOptions = True
        Me.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValor.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colValor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValor.AppearanceHeader.Options.UseBackColor = True
        Me.colValor.AppearanceHeader.Options.UseFont = True
        Me.colValor.AppearanceHeader.Options.UseTextOptions = True
        Me.colValor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colValor.Caption = "Vlr Total R$"
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 4
        Me.colValor.Width = 129
        '
        'colDataPagamento
        '
        Me.colDataPagamento.AppearanceCell.Options.UseTextOptions = True
        Me.colDataPagamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataPagamento.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colDataPagamento.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colDataPagamento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDataPagamento.AppearanceHeader.Options.UseBackColor = True
        Me.colDataPagamento.AppearanceHeader.Options.UseFont = True
        Me.colDataPagamento.AppearanceHeader.Options.UseTextOptions = True
        Me.colDataPagamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataPagamento.Caption = "Dt. Conta"
        Me.colDataPagamento.FieldName = "DataPagamento"
        Me.colDataPagamento.Name = "colDataPagamento"
        Me.colDataPagamento.Visible = True
        Me.colDataPagamento.VisibleIndex = 3
        Me.colDataPagamento.Width = 155
        '
        'XrLine7
        '
        Me.XrLine7.Location = New System.Drawing.Point(0, 292)
        Me.XrLine7.Name = "XrLine7"
        Me.XrLine7.Size = New System.Drawing.Size(742, 8)
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.XrLabel4.Location = New System.Drawing.Point(0, 317)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.Size = New System.Drawing.Size(600, 25)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "3. Margem de Contribuição (1-2):"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.Location = New System.Drawing.Point(375, 350)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.Size = New System.Drawing.Size(367, 17)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Total R$"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLine9
        '
        Me.XrLine9.Location = New System.Drawing.Point(0, 375)
        Me.XrLine9.Name = "XrLine9"
        Me.XrLine9.Size = New System.Drawing.Size(742, 8)
        '
        'XrLine4
        '
        Me.XrLine4.Location = New System.Drawing.Point(0, 500)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.Size = New System.Drawing.Size(742, 8)
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.Location = New System.Drawing.Point(375, 475)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.Size = New System.Drawing.Size(367, 17)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Total R$"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.XrLabel7.Location = New System.Drawing.Point(0, 392)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.Size = New System.Drawing.Size(600, 25)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseForeColor = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "4. Custos Fixos:"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'WinControlContainer2
        '
        Me.WinControlContainer2.Location = New System.Drawing.Point(0, 425)
        Me.WinControlContainer2.Name = "WinControlContainer2"
        Me.WinControlContainer2.Size = New System.Drawing.Size(742, 42)
        Me.WinControlContainer2.WinControl = Me.GridControl2
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "tbContaF"
        Me.GridControl2.DataSource = Me.dsDre
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(712, 40)
        Me.GridControl2.TabIndex = 8
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.AppearancePrint.Lines.BackColor = System.Drawing.Color.White
        Me.GridView2.AppearancePrint.Lines.Options.UseBackColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTipoConta1, Me.colNumeroDocumento1, Me.colNome1, Me.colVencimento1, Me.colValor1, Me.colDataPagamento1})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupCount = 1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowDetailButtons = False
        Me.GridView2.OptionsView.ShowHorzLines = False
        Me.GridView2.OptionsView.ShowIndicator = False
        Me.GridView2.OptionsView.ShowPreviewLines = False
        Me.GridView2.OptionsView.ShowVertLines = False
        Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTipoConta1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colTipoConta1
        '
        Me.colTipoConta1.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colTipoConta1.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colTipoConta1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTipoConta1.AppearanceHeader.Options.UseBackColor = True
        Me.colTipoConta1.AppearanceHeader.Options.UseFont = True
        Me.colTipoConta1.Caption = "TIPO DE CONTA"
        Me.colTipoConta1.FieldName = "TipoContaF"
        Me.colTipoConta1.Name = "colTipoConta1"
        Me.colTipoConta1.Visible = True
        Me.colTipoConta1.VisibleIndex = 0
        '
        'colNumeroDocumento1
        '
        Me.colNumeroDocumento1.AppearanceCell.Options.UseTextOptions = True
        Me.colNumeroDocumento1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colNumeroDocumento1.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNumeroDocumento1.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colNumeroDocumento1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumeroDocumento1.AppearanceHeader.Options.UseBackColor = True
        Me.colNumeroDocumento1.AppearanceHeader.Options.UseFont = True
        Me.colNumeroDocumento1.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumeroDocumento1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colNumeroDocumento1.Caption = "Doc."
        Me.colNumeroDocumento1.FieldName = "NumeroDocumentoF"
        Me.colNumeroDocumento1.Name = "colNumeroDocumento1"
        Me.colNumeroDocumento1.Visible = True
        Me.colNumeroDocumento1.VisibleIndex = 0
        Me.colNumeroDocumento1.Width = 172
        '
        'colNome1
        '
        Me.colNome1.AppearanceCell.Options.UseTextOptions = True
        Me.colNome1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colNome1.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNome1.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colNome1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNome1.AppearanceHeader.Options.UseBackColor = True
        Me.colNome1.AppearanceHeader.Options.UseFont = True
        Me.colNome1.AppearanceHeader.Options.UseTextOptions = True
        Me.colNome1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colNome1.Caption = "Razão"
        Me.colNome1.FieldName = "NomeF"
        Me.colNome1.Name = "colNome1"
        Me.colNome1.Visible = True
        Me.colNome1.VisibleIndex = 1
        Me.colNome1.Width = 541
        '
        'colVencimento1
        '
        Me.colVencimento1.AppearanceCell.Options.UseTextOptions = True
        Me.colVencimento1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimento1.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colVencimento1.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colVencimento1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVencimento1.AppearanceHeader.Options.UseBackColor = True
        Me.colVencimento1.AppearanceHeader.Options.UseFont = True
        Me.colVencimento1.AppearanceHeader.Options.UseTextOptions = True
        Me.colVencimento1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimento1.Caption = "Vencimento"
        Me.colVencimento1.FieldName = "VencimentoF"
        Me.colVencimento1.Name = "colVencimento1"
        Me.colVencimento1.Visible = True
        Me.colVencimento1.VisibleIndex = 2
        Me.colVencimento1.Width = 175
        '
        'colValor1
        '
        Me.colValor1.AppearanceCell.Options.UseTextOptions = True
        Me.colValor1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor1.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValor1.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colValor1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValor1.AppearanceHeader.Options.UseBackColor = True
        Me.colValor1.AppearanceHeader.Options.UseFont = True
        Me.colValor1.AppearanceHeader.Options.UseTextOptions = True
        Me.colValor1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colValor1.Caption = "Vlr. Total R$"
        Me.colValor1.FieldName = "ValorF"
        Me.colValor1.Name = "colValor1"
        Me.colValor1.Visible = True
        Me.colValor1.VisibleIndex = 4
        Me.colValor1.Width = 157
        '
        'colDataPagamento1
        '
        Me.colDataPagamento1.AppearanceCell.Options.UseTextOptions = True
        Me.colDataPagamento1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataPagamento1.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colDataPagamento1.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colDataPagamento1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDataPagamento1.AppearanceHeader.Options.UseBackColor = True
        Me.colDataPagamento1.AppearanceHeader.Options.UseFont = True
        Me.colDataPagamento1.AppearanceHeader.Options.UseTextOptions = True
        Me.colDataPagamento1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataPagamento1.Caption = "Dt. Conta"
        Me.colDataPagamento1.FieldName = "DataPagamentoF"
        Me.colDataPagamento1.Name = "colDataPagamento1"
        Me.colDataPagamento1.Visible = True
        Me.colDataPagamento1.VisibleIndex = 3
        Me.colDataPagamento1.Width = 146
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.XrLabel8.Location = New System.Drawing.Point(0, 517)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.Size = New System.Drawing.Size(600, 25)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseForeColor = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "5. Lucro Operacional (3-4):"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.Location = New System.Drawing.Point(375, 550)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.Size = New System.Drawing.Size(367, 17)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Total R$"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLine5
        '
        Me.XrLine5.Location = New System.Drawing.Point(0, 575)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.Size = New System.Drawing.Size(742, 8)
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.XrLabel12.Location = New System.Drawing.Point(0, 58)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.Size = New System.Drawing.Size(600, 25)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseForeColor = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "1. Vendas:"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.XrLabel10.Location = New System.Drawing.Point(0, 592)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.Size = New System.Drawing.Size(600, 25)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseForeColor = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "6. Receitas Não Operacionais:"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.Location = New System.Drawing.Point(375, 675)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.Size = New System.Drawing.Size(367, 17)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Total R$"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'WinControlContainer5
        '
        Me.WinControlContainer5.Location = New System.Drawing.Point(0, 625)
        Me.WinControlContainer5.Name = "WinControlContainer5"
        Me.WinControlContainer5.Size = New System.Drawing.Size(742, 42)
        Me.WinControlContainer5.WinControl = Me.GridControl3
        '
        'GridControl3
        '
        Me.GridControl3.DataMember = "tbReceitas"
        Me.GridControl3.DataSource = Me.dsDre
        Me.GridControl3.EmbeddedNavigator.Name = ""
        Me.GridControl3.Location = New System.Drawing.Point(0, 0)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(712, 40)
        Me.GridControl3.TabIndex = 9
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.AppearancePrint.Lines.BackColor = System.Drawing.Color.White
        Me.GridView3.AppearancePrint.Lines.BackColor2 = System.Drawing.Color.White
        Me.GridView3.AppearancePrint.Lines.Options.UseBackColor = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colObs, Me.colCodigo, Me.colNomeBanco, Me.colData2, Me.colValor2})
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.GroupCount = 1
        Me.GridView3.Name = "GridView3"
        Me.GridView3.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colObs, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colObs
        '
        Me.colObs.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colObs.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colObs.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colObs.AppearanceHeader.Options.UseBackColor = True
        Me.colObs.AppearanceHeader.Options.UseFont = True
        Me.colObs.Caption = "TIPO DE RECEITA"
        Me.colObs.FieldName = "Observacao"
        Me.colObs.Name = "colObs"
        Me.colObs.Visible = True
        Me.colObs.VisibleIndex = 0
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodigo.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colCodigo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigo.AppearanceHeader.Options.UseBackColor = True
        Me.colCodigo.AppearanceHeader.Options.UseFont = True
        Me.colCodigo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colCodigo.Caption = "Cód."
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 168
        '
        'colNomeBanco
        '
        Me.colNomeBanco.AppearanceCell.Options.UseTextOptions = True
        Me.colNomeBanco.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colNomeBanco.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNomeBanco.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colNomeBanco.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNomeBanco.AppearanceHeader.Options.UseBackColor = True
        Me.colNomeBanco.AppearanceHeader.Options.UseFont = True
        Me.colNomeBanco.AppearanceHeader.Options.UseTextOptions = True
        Me.colNomeBanco.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colNomeBanco.Caption = "Razão"
        Me.colNomeBanco.FieldName = "NomeBanco"
        Me.colNomeBanco.Name = "colNomeBanco"
        Me.colNomeBanco.Visible = True
        Me.colNomeBanco.VisibleIndex = 1
        Me.colNomeBanco.Width = 547
        '
        'colData2
        '
        Me.colData2.AppearanceCell.Options.UseTextOptions = True
        Me.colData2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData2.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colData2.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colData2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colData2.AppearanceHeader.Options.UseBackColor = True
        Me.colData2.AppearanceHeader.Options.UseFont = True
        Me.colData2.AppearanceHeader.Options.UseTextOptions = True
        Me.colData2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData2.Caption = "Data"
        Me.colData2.FieldName = "Data"
        Me.colData2.Name = "colData2"
        Me.colData2.Visible = True
        Me.colData2.VisibleIndex = 2
        Me.colData2.Width = 143
        '
        'colValor2
        '
        Me.colValor2.AppearanceCell.Options.UseTextOptions = True
        Me.colValor2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor2.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValor2.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colValor2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValor2.AppearanceHeader.Options.UseBackColor = True
        Me.colValor2.AppearanceHeader.Options.UseFont = True
        Me.colValor2.AppearanceHeader.Options.UseTextOptions = True
        Me.colValor2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colValor2.Caption = "Vlr. Total R$"
        Me.colValor2.FieldName = "Valor"
        Me.colValor2.Name = "colValor2"
        Me.colValor2.Visible = True
        Me.colValor2.VisibleIndex = 3
        Me.colValor2.Width = 174
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.XrLabel13.Location = New System.Drawing.Point(0, 717)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.Size = New System.Drawing.Size(600, 25)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseForeColor = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "7. Despesas Não Operacionais:"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine8
        '
        Me.XrLine8.Location = New System.Drawing.Point(0, 700)
        Me.XrLine8.Name = "XrLine8"
        Me.XrLine8.Size = New System.Drawing.Size(742, 8)
        '
        'WinControlContainer6
        '
        Me.WinControlContainer6.Location = New System.Drawing.Point(0, 750)
        Me.WinControlContainer6.Name = "WinControlContainer6"
        Me.WinControlContainer6.Size = New System.Drawing.Size(742, 42)
        Me.WinControlContainer6.WinControl = Me.GridControl4
        '
        'GridControl4
        '
        Me.GridControl4.DataMember = "tbDespesas"
        Me.GridControl4.DataSource = Me.dsDre
        Me.GridControl4.EmbeddedNavigator.Name = ""
        Me.GridControl4.Location = New System.Drawing.Point(0, 0)
        Me.GridControl4.MainView = Me.GridView4
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.Size = New System.Drawing.Size(712, 40)
        Me.GridControl4.TabIndex = 10
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.AppearancePrint.Lines.BackColor = System.Drawing.Color.White
        Me.GridView4.AppearancePrint.Lines.BackColor2 = System.Drawing.Color.White
        Me.GridView4.AppearancePrint.Lines.Options.UseBackColor = True
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTipoConta3, Me.colNumeroDocumento3, Me.colNome3, Me.colVencimento3, Me.colValor3})
        Me.GridView4.GridControl = Me.GridControl4
        Me.GridView4.GroupCount = 1
        Me.GridView4.Name = "GridView4"
        Me.GridView4.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTipoConta3, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colTipoConta3
        '
        Me.colTipoConta3.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colTipoConta3.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colTipoConta3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTipoConta3.AppearanceHeader.Options.UseBackColor = True
        Me.colTipoConta3.AppearanceHeader.Options.UseFont = True
        Me.colTipoConta3.Caption = "TIPO DE DESPESAS"
        Me.colTipoConta3.FieldName = "Observacao"
        Me.colTipoConta3.Name = "colTipoConta3"
        '
        'colNumeroDocumento3
        '
        Me.colNumeroDocumento3.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNumeroDocumento3.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colNumeroDocumento3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumeroDocumento3.AppearanceHeader.Options.UseBackColor = True
        Me.colNumeroDocumento3.AppearanceHeader.Options.UseFont = True
        Me.colNumeroDocumento3.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumeroDocumento3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colNumeroDocumento3.Caption = "Cód."
        Me.colNumeroDocumento3.FieldName = "Codigo"
        Me.colNumeroDocumento3.Name = "colNumeroDocumento3"
        Me.colNumeroDocumento3.Visible = True
        Me.colNumeroDocumento3.VisibleIndex = 0
        Me.colNumeroDocumento3.Width = 165
        '
        'colNome3
        '
        Me.colNome3.AppearanceCell.Options.UseTextOptions = True
        Me.colNome3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colNome3.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNome3.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colNome3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNome3.AppearanceHeader.Options.UseBackColor = True
        Me.colNome3.AppearanceHeader.Options.UseFont = True
        Me.colNome3.AppearanceHeader.Options.UseTextOptions = True
        Me.colNome3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colNome3.Caption = "Razão"
        Me.colNome3.FieldName = "NomeBanco"
        Me.colNome3.Name = "colNome3"
        Me.colNome3.Visible = True
        Me.colNome3.VisibleIndex = 1
        Me.colNome3.Width = 552
        '
        'colVencimento3
        '
        Me.colVencimento3.AppearanceCell.Options.UseTextOptions = True
        Me.colVencimento3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimento3.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colVencimento3.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colVencimento3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVencimento3.AppearanceHeader.Options.UseBackColor = True
        Me.colVencimento3.AppearanceHeader.Options.UseFont = True
        Me.colVencimento3.AppearanceHeader.Options.UseTextOptions = True
        Me.colVencimento3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimento3.Caption = "Data"
        Me.colVencimento3.FieldName = "Data"
        Me.colVencimento3.Name = "colVencimento3"
        Me.colVencimento3.Visible = True
        Me.colVencimento3.VisibleIndex = 2
        Me.colVencimento3.Width = 134
        '
        'colValor3
        '
        Me.colValor3.AppearanceCell.Options.UseTextOptions = True
        Me.colValor3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor3.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValor3.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colValor3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValor3.AppearanceHeader.Options.UseBackColor = True
        Me.colValor3.AppearanceHeader.Options.UseFont = True
        Me.colValor3.AppearanceHeader.Options.UseTextOptions = True
        Me.colValor3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colValor3.Caption = "Vlr. Total R$"
        Me.colValor3.FieldName = "Valor"
        Me.colValor3.Name = "colValor3"
        Me.colValor3.Visible = True
        Me.colValor3.VisibleIndex = 3
        Me.colValor3.Width = 184
        '
        'XrLabel14
        '
        Me.XrLabel14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel14.Location = New System.Drawing.Point(375, 800)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.Size = New System.Drawing.Size(367, 17)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "Total R$"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.XrLabel15.Location = New System.Drawing.Point(0, 842)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.Size = New System.Drawing.Size(600, 25)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseForeColor = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "8. Investimentos:"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine10
        '
        Me.XrLine10.Location = New System.Drawing.Point(0, 825)
        Me.XrLine10.Name = "XrLine10"
        Me.XrLine10.Size = New System.Drawing.Size(742, 8)
        '
        'WinControlContainer7
        '
        Me.WinControlContainer7.Location = New System.Drawing.Point(0, 875)
        Me.WinControlContainer7.Name = "WinControlContainer7"
        Me.WinControlContainer7.Size = New System.Drawing.Size(742, 42)
        Me.WinControlContainer7.WinControl = Me.GridControl5
        '
        'GridControl5
        '
        Me.GridControl5.DataMember = "tbInvest"
        Me.GridControl5.DataSource = Me.dsDre
        Me.GridControl5.EmbeddedNavigator.Name = ""
        Me.GridControl5.Location = New System.Drawing.Point(0, 0)
        Me.GridControl5.MainView = Me.GridView7
        Me.GridControl5.Name = "GridControl5"
        Me.GridControl5.Size = New System.Drawing.Size(712, 40)
        Me.GridControl5.TabIndex = 11
        Me.GridControl5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView7})
        '
        'GridView7
        '
        Me.GridView7.AppearancePrint.Lines.BackColor = System.Drawing.Color.White
        Me.GridView7.AppearancePrint.Lines.BackColor2 = System.Drawing.Color.White
        Me.GridView7.AppearancePrint.Lines.Options.UseBackColor = True
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTipoConta4, Me.colNumeroDocumento4, Me.colNome4, Me.colVencimento4, Me.colValor4, Me.colDataPagamento4})
        Me.GridView7.GridControl = Me.GridControl5
        Me.GridView7.GroupCount = 1
        Me.GridView7.Name = "GridView7"
        Me.GridView7.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTipoConta4, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colTipoConta4
        '
        Me.colTipoConta4.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colTipoConta4.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colTipoConta4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTipoConta4.AppearanceHeader.Options.UseBackColor = True
        Me.colTipoConta4.AppearanceHeader.Options.UseFont = True
        Me.colTipoConta4.Caption = "TIPO DE CONTA"
        Me.colTipoConta4.FieldName = "TipoConta"
        Me.colTipoConta4.Name = "colTipoConta4"
        '
        'colNumeroDocumento4
        '
        Me.colNumeroDocumento4.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNumeroDocumento4.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colNumeroDocumento4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumeroDocumento4.AppearanceHeader.Options.UseBackColor = True
        Me.colNumeroDocumento4.AppearanceHeader.Options.UseFont = True
        Me.colNumeroDocumento4.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumeroDocumento4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colNumeroDocumento4.Caption = "Doc."
        Me.colNumeroDocumento4.FieldName = "NumeroDocumento"
        Me.colNumeroDocumento4.Name = "colNumeroDocumento4"
        Me.colNumeroDocumento4.Visible = True
        Me.colNumeroDocumento4.VisibleIndex = 0
        Me.colNumeroDocumento4.Width = 162
        '
        'colNome4
        '
        Me.colNome4.AppearanceCell.Options.UseTextOptions = True
        Me.colNome4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colNome4.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNome4.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colNome4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNome4.AppearanceHeader.Options.UseBackColor = True
        Me.colNome4.AppearanceHeader.Options.UseFont = True
        Me.colNome4.AppearanceHeader.Options.UseTextOptions = True
        Me.colNome4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colNome4.Caption = "Razão"
        Me.colNome4.FieldName = "Nome"
        Me.colNome4.Name = "colNome4"
        Me.colNome4.Visible = True
        Me.colNome4.VisibleIndex = 1
        Me.colNome4.Width = 567
        '
        'colVencimento4
        '
        Me.colVencimento4.AppearanceCell.Options.UseTextOptions = True
        Me.colVencimento4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimento4.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colVencimento4.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colVencimento4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVencimento4.AppearanceHeader.Options.UseBackColor = True
        Me.colVencimento4.AppearanceHeader.Options.UseFont = True
        Me.colVencimento4.AppearanceHeader.Options.UseTextOptions = True
        Me.colVencimento4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimento4.Caption = "Vencimento"
        Me.colVencimento4.FieldName = "Vencimento"
        Me.colVencimento4.Name = "colVencimento4"
        Me.colVencimento4.Visible = True
        Me.colVencimento4.VisibleIndex = 2
        Me.colVencimento4.Width = 153
        '
        'colValor4
        '
        Me.colValor4.AppearanceCell.Options.UseTextOptions = True
        Me.colValor4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor4.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValor4.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colValor4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValor4.AppearanceHeader.Options.UseBackColor = True
        Me.colValor4.AppearanceHeader.Options.UseFont = True
        Me.colValor4.AppearanceHeader.Options.UseTextOptions = True
        Me.colValor4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colValor4.Caption = "Vlr. Total R$"
        Me.colValor4.FieldName = "Valor"
        Me.colValor4.Name = "colValor4"
        Me.colValor4.Visible = True
        Me.colValor4.VisibleIndex = 4
        Me.colValor4.Width = 152
        '
        'colDataPagamento4
        '
        Me.colDataPagamento4.AppearanceCell.Options.UseTextOptions = True
        Me.colDataPagamento4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataPagamento4.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colDataPagamento4.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colDataPagamento4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDataPagamento4.AppearanceHeader.Options.UseBackColor = True
        Me.colDataPagamento4.AppearanceHeader.Options.UseFont = True
        Me.colDataPagamento4.AppearanceHeader.Options.UseTextOptions = True
        Me.colDataPagamento4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataPagamento4.Caption = "Dt. Conta"
        Me.colDataPagamento4.FieldName = "DataPagamento"
        Me.colDataPagamento4.Name = "colDataPagamento4"
        Me.colDataPagamento4.Visible = True
        Me.colDataPagamento4.VisibleIndex = 3
        Me.colDataPagamento4.Width = 140
        '
        'XrLabel16
        '
        Me.XrLabel16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel16.Location = New System.Drawing.Point(375, 925)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.Size = New System.Drawing.Size(367, 17)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Total R$"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLine12
        '
        Me.XrLine12.Location = New System.Drawing.Point(0, 950)
        Me.XrLine12.Name = "XrLine12"
        Me.XrLine12.Size = New System.Drawing.Size(742, 8)
        '
        'XrLabel17
        '
        Me.XrLabel17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel17.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.XrLabel17.Location = New System.Drawing.Point(0, 967)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.Size = New System.Drawing.Size(600, 25)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseForeColor = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "9. Retirada de Lucros:"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'WinControlContainer8
        '
        Me.WinControlContainer8.Location = New System.Drawing.Point(0, 1000)
        Me.WinControlContainer8.Name = "WinControlContainer8"
        Me.WinControlContainer8.Size = New System.Drawing.Size(742, 42)
        Me.WinControlContainer8.WinControl = Me.GridControl8
        '
        'GridControl8
        '
        Me.GridControl8.DataMember = "tbRLucros"
        Me.GridControl8.DataSource = Me.dsDre
        Me.GridControl8.EmbeddedNavigator.Name = ""
        Me.GridControl8.Location = New System.Drawing.Point(0, 0)
        Me.GridControl8.MainView = Me.GridView8
        Me.GridControl8.Name = "GridControl8"
        Me.GridControl8.Size = New System.Drawing.Size(712, 40)
        Me.GridControl8.TabIndex = 12
        Me.GridControl8.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView8})
        '
        'GridView8
        '
        Me.GridView8.AppearancePrint.Lines.BackColor = System.Drawing.Color.White
        Me.GridView8.AppearancePrint.Lines.BackColor2 = System.Drawing.Color.White
        Me.GridView8.AppearancePrint.Lines.Options.UseBackColor = True
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTipoConta5, Me.colNumeroDocumento5, Me.colNome5, Me.colVencimento5, Me.colValor5, Me.colDataPagamento5})
        Me.GridView8.GridControl = Me.GridControl8
        Me.GridView8.GroupCount = 1
        Me.GridView8.Name = "GridView8"
        Me.GridView8.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTipoConta5, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colTipoConta5
        '
        Me.colTipoConta5.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colTipoConta5.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colTipoConta5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTipoConta5.AppearanceHeader.Options.UseBackColor = True
        Me.colTipoConta5.AppearanceHeader.Options.UseFont = True
        Me.colTipoConta5.Caption = "TIPO DE CONTA"
        Me.colTipoConta5.FieldName = "TipoConta"
        Me.colTipoConta5.Name = "colTipoConta5"
        '
        'colNumeroDocumento5
        '
        Me.colNumeroDocumento5.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNumeroDocumento5.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colNumeroDocumento5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumeroDocumento5.AppearanceHeader.Options.UseBackColor = True
        Me.colNumeroDocumento5.AppearanceHeader.Options.UseFont = True
        Me.colNumeroDocumento5.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumeroDocumento5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colNumeroDocumento5.Caption = "Doc."
        Me.colNumeroDocumento5.FieldName = "NumeroDocumento"
        Me.colNumeroDocumento5.Name = "colNumeroDocumento5"
        Me.colNumeroDocumento5.Visible = True
        Me.colNumeroDocumento5.VisibleIndex = 0
        Me.colNumeroDocumento5.Width = 162
        '
        'colNome5
        '
        Me.colNome5.AppearanceCell.Options.UseTextOptions = True
        Me.colNome5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colNome5.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNome5.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colNome5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNome5.AppearanceHeader.Options.UseBackColor = True
        Me.colNome5.AppearanceHeader.Options.UseFont = True
        Me.colNome5.AppearanceHeader.Options.UseTextOptions = True
        Me.colNome5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colNome5.Caption = "Razão"
        Me.colNome5.FieldName = "Nome"
        Me.colNome5.Name = "colNome5"
        Me.colNome5.Visible = True
        Me.colNome5.VisibleIndex = 1
        Me.colNome5.Width = 557
        '
        'colVencimento5
        '
        Me.colVencimento5.AppearanceCell.Options.UseTextOptions = True
        Me.colVencimento5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimento5.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colVencimento5.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colVencimento5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVencimento5.AppearanceHeader.Options.UseBackColor = True
        Me.colVencimento5.AppearanceHeader.Options.UseFont = True
        Me.colVencimento5.AppearanceHeader.Options.UseTextOptions = True
        Me.colVencimento5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimento5.Caption = "Vencimento"
        Me.colVencimento5.FieldName = "Vencimento"
        Me.colVencimento5.Name = "colVencimento5"
        Me.colVencimento5.Visible = True
        Me.colVencimento5.VisibleIndex = 2
        Me.colVencimento5.Width = 151
        '
        'colValor5
        '
        Me.colValor5.AppearanceCell.Options.UseTextOptions = True
        Me.colValor5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor5.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValor5.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colValor5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValor5.AppearanceHeader.Options.UseBackColor = True
        Me.colValor5.AppearanceHeader.Options.UseFont = True
        Me.colValor5.AppearanceHeader.Options.UseTextOptions = True
        Me.colValor5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colValor5.Caption = "Vlr. Total R$"
        Me.colValor5.FieldName = "Valor"
        Me.colValor5.Name = "colValor5"
        Me.colValor5.Visible = True
        Me.colValor5.VisibleIndex = 4
        Me.colValor5.Width = 158
        '
        'colDataPagamento5
        '
        Me.colDataPagamento5.AppearanceCell.Options.UseTextOptions = True
        Me.colDataPagamento5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataPagamento5.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colDataPagamento5.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colDataPagamento5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDataPagamento5.AppearanceHeader.Options.UseBackColor = True
        Me.colDataPagamento5.AppearanceHeader.Options.UseFont = True
        Me.colDataPagamento5.AppearanceHeader.Options.UseTextOptions = True
        Me.colDataPagamento5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataPagamento5.Caption = "Dt. Conta"
        Me.colDataPagamento5.FieldName = "DataPagamento"
        Me.colDataPagamento5.Name = "colDataPagamento5"
        Me.colDataPagamento5.Visible = True
        Me.colDataPagamento5.VisibleIndex = 3
        Me.colDataPagamento5.Width = 146
        '
        'XrLabel18
        '
        Me.XrLabel18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel18.Location = New System.Drawing.Point(375, 1050)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.Size = New System.Drawing.Size(367, 17)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "Total R$"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLine13
        '
        Me.XrLine13.Location = New System.Drawing.Point(0, 1075)
        Me.XrLine13.Name = "XrLine13"
        Me.XrLine13.Size = New System.Drawing.Size(742, 8)
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.WinControlContainer1, Me.lblTitulo, Me.XrLine3, Me.XrLine2})
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.Location = New System.Drawing.Point(8, 17)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.Size = New System.Drawing.Size(156, 62)
        Me.WinControlContainer1.WinControl = Me.picLogo
        '
        'picLogo
        '
        Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picLogo.ImageLocation = ""
        Me.picLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picLogo.Location = New System.Drawing.Point(10, 69)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(150, 60)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(208, 33)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitulo.Size = New System.Drawing.Size(508, 33)
        Me.lblTitulo.StylePriority.UseFont = False
        Me.lblTitulo.StylePriority.UseTextAlignment = False
        Me.lblTitulo.Text = "DRE - Demonstrativo de Resultado"
        Me.lblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine3
        '
        Me.XrLine3.LineWidth = 2
        Me.XrLine3.Location = New System.Drawing.Point(0, 0)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.Size = New System.Drawing.Size(742, 8)
        '
        'XrLine2
        '
        Me.XrLine2.LineWidth = 2
        Me.XrLine2.Location = New System.Drawing.Point(0, 92)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(742, 8)
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GridControl7
        '
        Me.GridControl7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl7.DataMember = "tbResumo"
        Me.GridControl7.EmbeddedNavigator.Name = ""
        Me.GridControl7.Location = New System.Drawing.Point(10, 15)
        Me.GridControl7.MainView = Me.GridView13
        Me.GridControl7.Name = "GridControl7"
        Me.GridControl7.Size = New System.Drawing.Size(230, 20)
        Me.GridControl7.TabIndex = 6
        Me.GridControl7.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView13, Me.GridView14})
        '
        'GridView13
        '
        Me.GridView13.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.GridView13.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView13.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent
        Me.GridView13.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView13.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.GridView13.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView13.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent
        Me.GridView13.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView13.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GridView13.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn13, Me.GridColumn14})
        Me.GridView13.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.GridColumn13
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "Total Pago R$"
        Me.GridView13.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
        Me.GridView13.GridControl = Me.GridControl7
        Me.GridView13.Name = "GridView13"
        Me.GridView13.OptionsView.ShowColumnHeaders = False
        Me.GridView13.OptionsView.ShowDetailButtons = False
        Me.GridView13.OptionsView.ShowGroupPanel = False
        Me.GridView13.OptionsView.ShowHorzLines = False
        Me.GridView13.OptionsView.ShowIndicator = False
        Me.GridView13.OptionsView.ShowPreviewLines = False
        Me.GridView13.OptionsView.ShowVertLines = False
        Me.GridView13.RowHeight = 19
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceCell.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn14.AppearanceCell.Options.UseFont = True
        Me.GridColumn14.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn14.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn14.Caption = "GridColumn2"
        Me.GridColumn14.FieldName = "Valor"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 1
        Me.GridColumn14.Width = 98
        '
        'GridView14
        '
        Me.GridView14.GridControl = Me.GridControl7
        Me.GridView14.Name = "GridView14"
        '
        'GridControl6
        '
        Me.GridControl6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl6.DataMember = "tbResumo"
        Me.GridControl6.EmbeddedNavigator.Name = ""
        Me.GridControl6.Location = New System.Drawing.Point(10, 15)
        Me.GridControl6.MainView = Me.GridView31
        Me.GridControl6.Name = "GridControl6"
        Me.GridControl6.Size = New System.Drawing.Size(230, 20)
        Me.GridControl6.TabIndex = 6
        Me.GridControl6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView31, Me.GridView32})
        '
        'GridView31
        '
        Me.GridView31.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.GridView31.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView31.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent
        Me.GridView31.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView31.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.GridView31.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView31.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent
        Me.GridView31.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView31.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GridView31.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn31, Me.GridColumn32})
        Me.GridView31.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition3.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition3.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Appearance.Options.UseFont = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.GridColumn31
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = "Total Pago R$"
        Me.GridView31.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition3})
        Me.GridView31.GridControl = Me.GridControl6
        Me.GridView31.Name = "GridView31"
        Me.GridView31.OptionsView.ShowColumnHeaders = False
        Me.GridView31.OptionsView.ShowDetailButtons = False
        Me.GridView31.OptionsView.ShowGroupPanel = False
        Me.GridView31.OptionsView.ShowHorzLines = False
        Me.GridView31.OptionsView.ShowIndicator = False
        Me.GridView31.OptionsView.ShowPreviewLines = False
        Me.GridView31.OptionsView.ShowVertLines = False
        Me.GridView31.RowHeight = 19
        '
        'GridColumn32
        '
        Me.GridColumn32.AppearanceCell.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn32.AppearanceCell.Options.UseFont = True
        Me.GridColumn32.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn32.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn32.Caption = "GridColumn2"
        Me.GridColumn32.FieldName = "Valor"
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.Visible = True
        Me.GridColumn32.VisibleIndex = 1
        Me.GridColumn32.Width = 98
        '
        'GridView32
        '
        Me.GridView32.GridControl = Me.GridControl6
        Me.GridView32.Name = "GridView32"
        '
        'relDRE
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Margins = New System.Drawing.Printing.Margins(40, 40, 40, 40)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ShowPreviewMarginLines = False
        Me.Version = "8.2"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsDre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbContaV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbContaF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbReceitas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbDespesas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbInvest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbRLucros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents lblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lblDataFinal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblDataInicial As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents WinControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents WinControlContainer4 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl7 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl6 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView31 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView32 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dsDre As System.Data.DataSet
    Friend WithEvents tbFor As System.Data.DataTable
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents GridColumn49 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents tbContaV As System.Data.DataTable
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents WinControlContainer3 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents colTipoConta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencimento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataPagamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XrLine6 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine7 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine9 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents WinControlContainer2 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents tbContaF As System.Data.DataTable
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents colTipoConta1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroDocumento1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencimento1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataPagamento1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn63 As System.Data.DataColumn
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents WinControlContainer6 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XrLine8 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents WinControlContainer5 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine12 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents WinControlContainer7 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XrLine10 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine13 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents WinControlContainer8 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl8 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents tbReceitas As System.Data.DataTable
    Friend WithEvents tbDespesas As System.Data.DataTable
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn64 As System.Data.DataColumn
    Friend WithEvents DataColumn65 As System.Data.DataColumn
    Friend WithEvents DataColumn66 As System.Data.DataColumn
    Friend WithEvents DataColumn68 As System.Data.DataColumn
    Friend WithEvents DataColumn69 As System.Data.DataColumn
    Friend WithEvents DataColumn70 As System.Data.DataColumn
    Friend WithEvents DataColumn71 As System.Data.DataColumn
    Friend WithEvents tbInvest As System.Data.DataTable
    Friend WithEvents tbRLucros As System.Data.DataTable
    Friend WithEvents DataColumn72 As System.Data.DataColumn
    Friend WithEvents DataColumn74 As System.Data.DataColumn
    Friend WithEvents DataColumn75 As System.Data.DataColumn
    Friend WithEvents DataColumn76 As System.Data.DataColumn
    Friend WithEvents DataColumn77 As System.Data.DataColumn
    Friend WithEvents DataColumn78 As System.Data.DataColumn
    Friend WithEvents DataColumn79 As System.Data.DataColumn
    Friend WithEvents DataColumn80 As System.Data.DataColumn
    Friend WithEvents DataColumn81 As System.Data.DataColumn
    Friend WithEvents DataColumn82 As System.Data.DataColumn
    Friend WithEvents DataColumn83 As System.Data.DataColumn
    Friend WithEvents DataColumn84 As System.Data.DataColumn
    Friend WithEvents DataColumn85 As System.Data.DataColumn
    Friend WithEvents colObs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNomeBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoConta3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroDocumento3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencimento3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoConta4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroDocumento4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencimento4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataPagamento4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoConta5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroDocumento5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencimento5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataPagamento5 As DevExpress.XtraGrid.Columns.GridColumn
End Class
