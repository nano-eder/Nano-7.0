<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relCheque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(relCheque))
        Me.colVencimento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsCheque = New System.Data.DataSet
        Me.tbCheque = New System.Data.DataTable
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
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodPed = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDocumento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBanco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQuem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRecebido = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkRecebido = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colRecebimento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueLoja = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRecebido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'colVencimento
        '
        Me.colVencimento.AppearanceCell.Options.UseTextOptions = True
        Me.colVencimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimento.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colVencimento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVencimento.AppearanceHeader.Options.UseBackColor = True
        Me.colVencimento.AppearanceHeader.Options.UseFont = True
        Me.colVencimento.Caption = "Vencimento"
        Me.colVencimento.FieldName = "Vencimento"
        Me.colVencimento.Name = "colVencimento"
        Me.colVencimento.OptionsColumn.ReadOnly = True
        Me.colVencimento.Visible = True
        Me.colVencimento.VisibleIndex = 2
        Me.colVencimento.Width = 82
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
        Me.WinControlContainer1.Size = New System.Drawing.Size(1108, 75)
        Me.WinControlContainer1.WinControl = Me.GridControl1
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbCheque"
        Me.GridControl1.DataSource = Me.dsCheque
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 20)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterar, Me.chkRecebido, Me.lueLoja})
        Me.GridControl1.Size = New System.Drawing.Size(1064, 72)
        Me.GridControl1.TabIndex = 110
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsCheque
        '
        Me.dsCheque.DataSetName = "NewDataSet"
        Me.dsCheque.Tables.AddRange(New System.Data.DataTable() {Me.tbCheque})
        '
        'tbCheque
        '
        Me.tbCheque.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10})
        Me.tbCheque.TableName = "tbCheque"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "CodPed"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Cliente"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Vencimento"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Valor"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Documento"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Banco"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Data"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Quem"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Recebido"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Recebimento"
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
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodPed, Me.colCliente, Me.colVencimento, Me.colValor, Me.colDocumento, Me.colBanco, Me.colData, Me.colQuem, Me.colRecebido, Me.colRecebimento})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colVencimento
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Lime
        StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colVencimento
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        Me.grd1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
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
        Me.colCodPed.ColumnEdit = Me.txtAlterar
        Me.colCodPed.FieldName = "CodPed"
        Me.colCodPed.Name = "colCodPed"
        Me.colCodPed.OptionsColumn.ReadOnly = True
        Me.colCodPed.Visible = True
        Me.colCodPed.VisibleIndex = 0
        Me.colCodPed.Width = 68
        '
        'txtAlterar
        '
        Me.txtAlterar.AutoHeight = False
        Me.txtAlterar.Name = "txtAlterar"
        '
        'colCliente
        '
        Me.colCliente.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCliente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCliente.AppearanceHeader.Options.UseBackColor = True
        Me.colCliente.AppearanceHeader.Options.UseFont = True
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.ColumnEdit = Me.txtAlterar
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.ReadOnly = True
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 1
        Me.colCliente.Width = 222
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
        Me.colValor.ColumnEdit = Me.txtAlterar
        Me.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.OptionsColumn.ReadOnly = True
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 4
        Me.colValor.Width = 72
        '
        'colDocumento
        '
        Me.colDocumento.AppearanceCell.Options.UseTextOptions = True
        Me.colDocumento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDocumento.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colDocumento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDocumento.AppearanceHeader.Options.UseBackColor = True
        Me.colDocumento.AppearanceHeader.Options.UseFont = True
        Me.colDocumento.Caption = "Documento"
        Me.colDocumento.ColumnEdit = Me.txtAlterar
        Me.colDocumento.FieldName = "Documento"
        Me.colDocumento.Name = "colDocumento"
        Me.colDocumento.OptionsColumn.ReadOnly = True
        Me.colDocumento.Visible = True
        Me.colDocumento.VisibleIndex = 3
        Me.colDocumento.Width = 103
        '
        'colBanco
        '
        Me.colBanco.AppearanceCell.Options.UseTextOptions = True
        Me.colBanco.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBanco.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colBanco.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBanco.AppearanceHeader.Options.UseBackColor = True
        Me.colBanco.AppearanceHeader.Options.UseFont = True
        Me.colBanco.Caption = "Banco"
        Me.colBanco.ColumnEdit = Me.txtAlterar
        Me.colBanco.FieldName = "Banco"
        Me.colBanco.Name = "colBanco"
        Me.colBanco.OptionsColumn.ReadOnly = True
        Me.colBanco.Visible = True
        Me.colBanco.VisibleIndex = 5
        Me.colBanco.Width = 103
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
        Me.colData.VisibleIndex = 6
        Me.colData.Width = 84
        '
        'colQuem
        '
        Me.colQuem.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colQuem.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colQuem.AppearanceHeader.Options.UseBackColor = True
        Me.colQuem.AppearanceHeader.Options.UseFont = True
        Me.colQuem.Caption = "Quem Recebeu"
        Me.colQuem.ColumnEdit = Me.txtAlterar
        Me.colQuem.FieldName = "Quem"
        Me.colQuem.Name = "colQuem"
        Me.colQuem.OptionsColumn.ReadOnly = True
        Me.colQuem.Visible = True
        Me.colQuem.VisibleIndex = 8
        Me.colQuem.Width = 178
        '
        'colRecebido
        '
        Me.colRecebido.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colRecebido.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colRecebido.AppearanceHeader.Options.UseBackColor = True
        Me.colRecebido.AppearanceHeader.Options.UseFont = True
        Me.colRecebido.Caption = "Recebido"
        Me.colRecebido.ColumnEdit = Me.chkRecebido
        Me.colRecebido.FieldName = "Recebido"
        Me.colRecebido.Name = "colRecebido"
        Me.colRecebido.OptionsColumn.ReadOnly = True
        Me.colRecebido.Width = 64
        '
        'chkRecebido
        '
        Me.chkRecebido.AutoHeight = False
        Me.chkRecebido.Name = "chkRecebido"
        '
        'colRecebimento
        '
        Me.colRecebimento.AppearanceCell.Options.UseTextOptions = True
        Me.colRecebimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRecebimento.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colRecebimento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colRecebimento.AppearanceHeader.Options.UseBackColor = True
        Me.colRecebimento.AppearanceHeader.Options.UseFont = True
        Me.colRecebimento.Caption = "Recebimento"
        Me.colRecebimento.FieldName = "Recebimento"
        Me.colRecebimento.Name = "colRecebimento"
        Me.colRecebimento.OptionsColumn.ReadOnly = True
        Me.colRecebimento.Visible = True
        Me.colRecebimento.VisibleIndex = 7
        Me.colRecebimento.Width = 82
        '
        'lueLoja
        '
        Me.lueLoja.AutoHeight = False
        Me.lueLoja.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLoja.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 20, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descrição", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueLoja.DisplayMember = "Codigo"
        Me.lueLoja.Name = "lueLoja"
        Me.lueLoja.ValueMember = "Codigo"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.picLogo, Me.XrLine3, Me.lblTitulo})
        Me.PageHeader.Height = 91
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine2
        '
        Me.XrLine2.LineWidth = 2
        Me.XrLine2.Location = New System.Drawing.Point(0, 83)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(1108, 8)
        '
        'picLogo
        '
        Me.picLogo.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(8, 17)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(150, 60)
        Me.picLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
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
        Me.lblTitulo.Size = New System.Drawing.Size(925, 33)
        Me.lblTitulo.StylePriority.UseFont = False
        Me.lblTitulo.StylePriority.UseTextAlignment = False
        Me.lblTitulo.Text = "Relatório de Contas a Pagar"
        Me.lblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.Height = 30
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'relCheque
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
        CType(Me.dsCheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRecebido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents picLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents WinControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents dsCheque As System.Data.DataSet
    Friend WithEvents tbCheque As System.Data.DataTable
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
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodPed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencimento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecebido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkRecebido As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colRecebimento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueLoja As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
