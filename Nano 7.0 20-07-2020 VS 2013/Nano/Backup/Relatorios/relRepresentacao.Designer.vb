<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relRepresentacao
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
        Me.lblComissaoEsc = New DevExpress.XtraReports.UI.XRLabel
        Me.lblComissaoVend = New DevExpress.XtraReports.UI.XRLabel
        Me.lblValorTotal = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsRep = New System.Data.DataSet
        Me.tbRep = New System.Data.DataTable
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
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodPed = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodCli = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodFunc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFuncionario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPorcentagem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComissaoFunc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComissaoEsc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsRep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbRep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblComissaoEsc, Me.lblComissaoVend, Me.lblValorTotal, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9, Me.WinControlContainer1})
        Me.Detail.Height = 150
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblComissaoEsc
        '
        Me.lblComissaoEsc.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComissaoEsc.Location = New System.Drawing.Point(967, 133)
        Me.lblComissaoEsc.Name = "lblComissaoEsc"
        Me.lblComissaoEsc.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblComissaoEsc.Size = New System.Drawing.Size(133, 17)
        Me.lblComissaoEsc.StylePriority.UseFont = False
        Me.lblComissaoEsc.StylePriority.UseTextAlignment = False
        Me.lblComissaoEsc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblComissaoVend
        '
        Me.lblComissaoVend.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComissaoVend.Location = New System.Drawing.Point(967, 108)
        Me.lblComissaoVend.Name = "lblComissaoVend"
        Me.lblComissaoVend.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblComissaoVend.Size = New System.Drawing.Size(133, 17)
        Me.lblComissaoVend.StylePriority.UseFont = False
        Me.lblComissaoVend.StylePriority.UseTextAlignment = False
        Me.lblComissaoVend.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblValorTotal
        '
        Me.lblValorTotal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorTotal.Location = New System.Drawing.Point(967, 83)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblValorTotal.Size = New System.Drawing.Size(133, 17)
        Me.lblValorTotal.StylePriority.UseFont = False
        Me.lblValorTotal.StylePriority.UseTextAlignment = False
        Me.lblValorTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.Location = New System.Drawing.Point(792, 133)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.Size = New System.Drawing.Size(167, 17)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Comissão Esc. R$"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.Location = New System.Drawing.Point(792, 108)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.Size = New System.Drawing.Size(167, 17)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Comissão Vend. R$"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.Location = New System.Drawing.Point(792, 83)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.Size = New System.Drawing.Size(167, 17)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Valor Total R$"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.Location = New System.Drawing.Point(0, 0)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.Size = New System.Drawing.Size(1108, 75)
        Me.WinControlContainer1.WinControl = Me.GridControl1
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbRep"
        Me.GridControl1.DataSource = Me.dsRep
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1064, 72)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsRep
        '
        Me.dsRep.DataSetName = "NewDataSet"
        Me.dsRep.Tables.AddRange(New System.Data.DataTable() {Me.tbRep})
        '
        'tbRep
        '
        Me.tbRep.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11})
        Me.tbRep.TableName = "tbRep"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Codigo"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "CodPed"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "CodCli"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Cliente"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "CodFunc"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Funcionario"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Valor"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Porcentagem"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "ComissaoFunc"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "ComissaoEsc"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Data"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colCodPed, Me.colCodCli, Me.colCliente, Me.colCodFunc, Me.colFuncionario, Me.colValor, Me.colPorcentagem, Me.colComissaoFunc, Me.colComissaoEsc, Me.colData})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodigo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigo.AppearanceHeader.Options.UseBackColor = True
        Me.colCodigo.AppearanceHeader.Options.UseFont = True
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        '
        'colCodPed
        '
        Me.colCodPed.AppearanceCell.Options.UseTextOptions = True
        Me.colCodPed.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodPed.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodPed.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodPed.AppearanceHeader.Options.UseBackColor = True
        Me.colCodPed.AppearanceHeader.Options.UseFont = True
        Me.colCodPed.Caption = "Cód. Ped."
        Me.colCodPed.FieldName = "CodPed"
        Me.colCodPed.Name = "colCodPed"
        Me.colCodPed.OptionsColumn.ReadOnly = True
        Me.colCodPed.Visible = True
        Me.colCodPed.VisibleIndex = 0
        Me.colCodPed.Width = 80
        '
        'colCodCli
        '
        Me.colCodCli.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodCli.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodCli.AppearanceHeader.Options.UseBackColor = True
        Me.colCodCli.AppearanceHeader.Options.UseFont = True
        Me.colCodCli.Caption = "CodCli"
        Me.colCodCli.FieldName = "CodCli"
        Me.colCodCli.Name = "colCodCli"
        Me.colCodCli.OptionsColumn.ReadOnly = True
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
        Me.colCliente.OptionsColumn.ReadOnly = True
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 2
        Me.colCliente.Width = 232
        '
        'colCodFunc
        '
        Me.colCodFunc.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodFunc.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodFunc.AppearanceHeader.Options.UseBackColor = True
        Me.colCodFunc.AppearanceHeader.Options.UseFont = True
        Me.colCodFunc.Caption = "CodFunc"
        Me.colCodFunc.FieldName = "CodFunc"
        Me.colCodFunc.Name = "colCodFunc"
        Me.colCodFunc.OptionsColumn.ReadOnly = True
        '
        'colFuncionario
        '
        Me.colFuncionario.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colFuncionario.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFuncionario.AppearanceHeader.Options.UseBackColor = True
        Me.colFuncionario.AppearanceHeader.Options.UseFont = True
        Me.colFuncionario.Caption = "Vendedor"
        Me.colFuncionario.FieldName = "Funcionario"
        Me.colFuncionario.Name = "colFuncionario"
        Me.colFuncionario.OptionsColumn.ReadOnly = True
        Me.colFuncionario.Visible = True
        Me.colFuncionario.VisibleIndex = 3
        Me.colFuncionario.Width = 171
        '
        'colValor
        '
        Me.colValor.AppearanceCell.Options.UseTextOptions = True
        Me.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValor.AppearanceHeader.Options.UseBackColor = True
        Me.colValor.AppearanceHeader.Options.UseFont = True
        Me.colValor.Caption = "Valor R$"
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.OptionsColumn.ReadOnly = True
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 4
        Me.colValor.Width = 83
        '
        'colPorcentagem
        '
        Me.colPorcentagem.AppearanceCell.Options.UseTextOptions = True
        Me.colPorcentagem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPorcentagem.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colPorcentagem.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPorcentagem.AppearanceHeader.Options.UseBackColor = True
        Me.colPorcentagem.AppearanceHeader.Options.UseFont = True
        Me.colPorcentagem.Caption = "% Comissão"
        Me.colPorcentagem.FieldName = "Porcentagem"
        Me.colPorcentagem.Name = "colPorcentagem"
        Me.colPorcentagem.OptionsColumn.ReadOnly = True
        Me.colPorcentagem.Visible = True
        Me.colPorcentagem.VisibleIndex = 5
        Me.colPorcentagem.Width = 81
        '
        'colComissaoFunc
        '
        Me.colComissaoFunc.AppearanceCell.Options.UseTextOptions = True
        Me.colComissaoFunc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colComissaoFunc.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colComissaoFunc.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComissaoFunc.AppearanceHeader.Options.UseBackColor = True
        Me.colComissaoFunc.AppearanceHeader.Options.UseFont = True
        Me.colComissaoFunc.Caption = "Com. Vend. R$"
        Me.colComissaoFunc.FieldName = "ComissaoFunc"
        Me.colComissaoFunc.Name = "colComissaoFunc"
        Me.colComissaoFunc.OptionsColumn.ReadOnly = True
        Me.colComissaoFunc.Visible = True
        Me.colComissaoFunc.VisibleIndex = 6
        Me.colComissaoFunc.Width = 94
        '
        'colComissaoEsc
        '
        Me.colComissaoEsc.AppearanceCell.Options.UseTextOptions = True
        Me.colComissaoEsc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colComissaoEsc.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colComissaoEsc.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComissaoEsc.AppearanceHeader.Options.UseBackColor = True
        Me.colComissaoEsc.AppearanceHeader.Options.UseFont = True
        Me.colComissaoEsc.Caption = "Com. Esc. R$"
        Me.colComissaoEsc.FieldName = "ComissaoEsc"
        Me.colComissaoEsc.Name = "colComissaoEsc"
        Me.colComissaoEsc.OptionsColumn.ReadOnly = True
        Me.colComissaoEsc.Visible = True
        Me.colComissaoEsc.VisibleIndex = 7
        Me.colComissaoEsc.Width = 86
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
        Me.colData.OptionsColumn.ReadOnly = True
        Me.colData.Visible = True
        Me.colData.VisibleIndex = 1
        Me.colData.Width = 111
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.XrLine3, Me.lblTitulo, Me.picLogo})
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine2
        '
        Me.XrLine2.LineWidth = 2
        Me.XrLine2.Location = New System.Drawing.Point(0, 92)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(1108, 8)
        '
        'XrLine3
        '
        Me.XrLine3.LineWidth = 2
        Me.XrLine3.Location = New System.Drawing.Point(0, 0)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.Size = New System.Drawing.Size(1108, 8)
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(167, 33)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitulo.Size = New System.Drawing.Size(908, 25)
        Me.lblTitulo.StylePriority.UseFont = False
        Me.lblTitulo.StylePriority.UseTextAlignment = False
        Me.lblTitulo.Text = "lblTitulo"
        Me.lblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
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
        'PageFooter
        '
        Me.PageFooter.Height = 30
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'relRepresentacao
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
        CType(Me.dsRep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbRep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents picLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents WinControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodPed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodCli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodFunc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFuncionario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPorcentagem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComissaoFunc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComissaoEsc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dsRep As System.Data.DataSet
    Friend WithEvents tbRep As System.Data.DataTable
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
    Friend WithEvents lblComissaoEsc As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblComissaoVend As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblValorTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
End Class
