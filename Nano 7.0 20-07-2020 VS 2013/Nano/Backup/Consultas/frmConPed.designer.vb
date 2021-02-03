<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConPed
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConPed))
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtRetorno = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colTotalPecas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCPF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCod = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TotalGridControl = New DevExpress.XtraGrid.GridControl
        Me.dsProd = New System.Data.DataSet
        Me.tbProd = New System.Data.DataTable
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
        Me.colData1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colObs = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAnimal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEstoque = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colComanda = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStatusPedido = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPlaca = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colModelo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnVisu = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        CType(Me.txtRetorno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colStatus
        '
        Me.colStatus.AppearanceCell.Options.UseTextOptions = True
        Me.colStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStatus.Caption = "Status Sistema"
        Me.colStatus.ColumnEdit = Me.txtRetorno
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.OptionsColumn.ReadOnly = True
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 4
        Me.colStatus.Width = 111
        '
        'txtRetorno
        '
        Me.txtRetorno.AutoHeight = False
        Me.txtRetorno.Name = "txtRetorno"
        '
        'colTotalPecas
        '
        Me.colTotalPecas.Caption = "TotalPecas"
        Me.colTotalPecas.FieldName = "TotalPecas"
        Me.colTotalPecas.Name = "colTotalPecas"
        Me.colTotalPecas.Visible = True
        Me.colTotalPecas.VisibleIndex = 3
        Me.colTotalPecas.Width = 76
        '
        'colCPF
        '
        Me.colCPF.Caption = "CPF"
        Me.colCPF.FieldName = "CPF"
        Me.colCPF.Name = "colCPF"
        Me.colCPF.Visible = True
        Me.colCPF.VisibleIndex = 3
        Me.colCPF.Width = 56
        '
        'colData
        '
        Me.colData.Caption = "Data"
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.Visible = True
        Me.colData.VisibleIndex = 1
        Me.colData.Width = 47
        '
        'colCod
        '
        Me.colCod.Caption = "Cod"
        Me.colCod.FieldName = "Cod"
        Me.colCod.Name = "colCod"
        Me.colCod.Visible = True
        Me.colCod.VisibleIndex = 1
        Me.colCod.Width = 51
        '
        'colAut
        '
        Me.colAut.Caption = "Aut"
        Me.colAut.FieldName = "Aut"
        Me.colAut.Name = "colAut"
        Me.colAut.Visible = True
        Me.colAut.VisibleIndex = 0
        Me.colAut.Width = 79
        '
        'TotalGridControl
        '
        Me.TotalGridControl.DataMember = "tbProd"
        Me.TotalGridControl.DataSource = Me.dsProd
        Me.TotalGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalGridControl.EmbeddedNavigator.Name = ""
        Me.TotalGridControl.Location = New System.Drawing.Point(0, 0)
        Me.TotalGridControl.MainView = Me.grd1
        Me.TotalGridControl.Name = "TotalGridControl"
        Me.TotalGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtRetorno, Me.RepositoryItemCheckEdit1})
        Me.TotalGridControl.Size = New System.Drawing.Size(849, 409)
        Me.TotalGridControl.TabIndex = 1
        Me.TotalGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsProd
        '
        Me.dsProd.DataSetName = "NewDataSet"
        Me.dsProd.Tables.AddRange(New System.Data.DataTable() {Me.tbProd})
        '
        'tbProd
        '
        Me.tbProd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11})
        Me.tbProd.TableName = "tbProd"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Codigo"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Cliente"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Status"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Data"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Descricao"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Total"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Animal"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Estoque"
        Me.DataColumn8.DataType = GetType(Boolean)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "StatusPedido"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Placa"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Modelo"
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
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colData1, Me.colCliente, Me.colStatus, Me.colObs, Me.colTotal, Me.colAnimal, Me.colEstoque, Me.colComanda, Me.colStatusPedido, Me.colPlaca, Me.colModelo})
        Me.grd1.CustomizationFormBounds = New System.Drawing.Rectangle(681, 410, 216, 199)
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colStatus
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "Faturado"
        Me.grd1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.grd1.GridControl = Me.TotalGridControl
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsPrint.UsePrintStyles = True
        Me.grd1.OptionsView.AutoCalcPreviewLineCount = True
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowFooter = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigo.Caption = "Nº Ped."
        Me.colCodigo.ColumnEdit = Me.txtRetorno
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        Me.colCodigo.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 101
        '
        'colData1
        '
        Me.colData1.AppearanceCell.Options.UseTextOptions = True
        Me.colData1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData1.Caption = "Data"
        Me.colData1.FieldName = "Data"
        Me.colData1.Name = "colData1"
        Me.colData1.OptionsColumn.ReadOnly = True
        Me.colData1.Visible = True
        Me.colData1.VisibleIndex = 3
        Me.colData1.Width = 103
        '
        'colCliente
        '
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.ColumnEdit = Me.txtRetorno
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.ReadOnly = True
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 1
        Me.colCliente.Width = 338
        '
        'colObs
        '
        Me.colObs.Caption = "Observação"
        Me.colObs.FieldName = "Descricao"
        Me.colObs.Name = "colObs"
        Me.colObs.OptionsColumn.ReadOnly = True
        Me.colObs.Visible = True
        Me.colObs.VisibleIndex = 2
        Me.colObs.Width = 247
        '
        'colTotal
        '
        Me.colTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTotal.Caption = "Total R$"
        Me.colTotal.ColumnEdit = Me.txtRetorno
        Me.colTotal.DisplayFormat.FormatString = "c"
        Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.FieldName = "Total"
        Me.colTotal.GroupFormat.FormatString = """0.00"""
        Me.colTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTotal.Name = "colTotal"
        Me.colTotal.OptionsColumn.ReadOnly = True
        Me.colTotal.SummaryItem.DisplayFormat = "{0:c}"
        Me.colTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colTotal.Width = 81
        '
        'colAnimal
        '
        Me.colAnimal.Caption = "Animal"
        Me.colAnimal.FieldName = "Animal"
        Me.colAnimal.Name = "colAnimal"
        Me.colAnimal.OptionsColumn.ReadOnly = True
        Me.colAnimal.Width = 123
        '
        'colEstoque
        '
        Me.colEstoque.Caption = "Estoque OK"
        Me.colEstoque.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colEstoque.FieldName = "Estoque"
        Me.colEstoque.Name = "colEstoque"
        Me.colEstoque.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colComanda
        '
        Me.colComanda.AppearanceCell.Options.UseTextOptions = True
        Me.colComanda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComanda.Caption = "Comanda"
        Me.colComanda.ColumnEdit = Me.txtRetorno
        Me.colComanda.FieldName = "Comanda"
        Me.colComanda.Name = "colComanda"
        Me.colComanda.OptionsColumn.ReadOnly = True
        Me.colComanda.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals
        '
        'colStatusPedido
        '
        Me.colStatusPedido.AppearanceCell.Options.UseTextOptions = True
        Me.colStatusPedido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStatusPedido.Caption = "Status"
        Me.colStatusPedido.FieldName = "StatusPedido"
        Me.colStatusPedido.Name = "colStatusPedido"
        Me.colStatusPedido.OptionsColumn.ReadOnly = True
        '
        'colPlaca
        '
        Me.colPlaca.AppearanceCell.Options.UseTextOptions = True
        Me.colPlaca.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaca.Caption = "Placa"
        Me.colPlaca.FieldName = "Placa"
        Me.colPlaca.Name = "colPlaca"
        Me.colPlaca.OptionsColumn.ReadOnly = True
        Me.colPlaca.Width = 101
        '
        'colModelo
        '
        Me.colModelo.Caption = "Modelo"
        Me.colModelo.FieldName = "Modelo"
        Me.colModelo.Name = "colModelo"
        Me.colModelo.OptionsColumn.ReadOnly = True
        Me.colModelo.Width = 157
        '
        'Timer1
        '
        Me.Timer1.Interval = 250
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnVisu, Me.btnFechar})
        Me.BarManager1.MaxItemId = 2
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnVisu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnVisu
        '
        Me.btnVisu.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnVisu.Caption = "&Visualizar"
        Me.btnVisu.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnVisu.Id = 0
        Me.btnVisu.Name = "btnVisu"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 1
        Me.btnFechar.Name = "btnFechar"
        '
        'frmConPed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 445)
        Me.Controls.Add(Me.TotalGridControl)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConPed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Pedidos"
        CType(Me.txtRetorno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents colTotalPecas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCPF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TotalGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtRetorno As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents dsProd As System.Data.DataSet
    Friend WithEvents tbProd As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents colObs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnVisu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents colAnimal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents colEstoque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colComanda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatusPedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents colPlaca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModelo As DevExpress.XtraGrid.Columns.GridColumn
End Class
