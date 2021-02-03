<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConProdTam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConProdTam))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btnPadrao = New DevExpress.XtraEditors.SimpleButton
        Me.btnManter = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsProd = New System.Data.DataSet
        Me.tbProd = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigoInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTamanho = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLocacao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoBarra = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGrupo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem
        Me.btnVisualizar = New DevExpress.XtraBars.BarButtonItem
        Me.btnRelCust = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSetor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUnidadeMedida = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFornecedor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colObs = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodProdFor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl1.Controls.Add(Me.btnPadrao)
        Me.GroupControl1.Controls.Add(Me.btnManter)
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1008, 626)
        Me.GroupControl1.TabIndex = 0
        '
        'btnPadrao
        '
        Me.btnPadrao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPadrao.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnPadrao.Appearance.Options.UseFont = True
        Me.btnPadrao.Enabled = False
        Me.btnPadrao.Location = New System.Drawing.Point(932, 20)
        Me.btnPadrao.Name = "btnPadrao"
        Me.btnPadrao.Size = New System.Drawing.Size(54, 16)
        Me.btnPadrao.TabIndex = 109
        Me.btnPadrao.Text = "Padrão"
        Me.btnPadrao.ToolTip = "Configurações da grid padrão"
        '
        'btnManter
        '
        Me.btnManter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManter.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnManter.Appearance.Options.UseFont = True
        Me.btnManter.Location = New System.Drawing.Point(932, 5)
        Me.btnManter.Name = "btnManter"
        Me.btnManter.Size = New System.Drawing.Size(54, 16)
        Me.btnManter.TabIndex = 108
        Me.btnManter.Text = "Manter"
        Me.btnManter.ToolTip = "Manter as configurações da grid"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbProd"
        Me.GridControl1.DataSource = Me.dsProd
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1004, 589)
        Me.GridControl1.TabIndex = 5
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsProd
        '
        Me.dsProd.DataSetName = "NewDataSet"
        Me.dsProd.Tables.AddRange(New System.Data.DataTable() {Me.tbProd})
        '
        'tbProd
        '
        Me.tbProd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16})
        Me.tbProd.TableName = "tbProd"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Produto"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Tamanho"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Qtd"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Locacao"
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "Código"
        Me.DataColumn5.ColumnName = "CodigoInterno"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "CodigoBarra"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Grupo"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoInterno, Me.colProduto, Me.colTamanho, Me.colQtd, Me.colLocacao, Me.colCodigoBarra, Me.colGrupo, Me.colValor, Me.colValorCusto, Me.colSetor, Me.colUnidadeMedida, Me.colFornecedor, Me.colData, Me.colTipo, Me.colObs, Me.colCodProdFor})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qtd", Me.colQtd, "{0:0.000}")})
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ColumnAutoWidth = False
        Me.grd1.OptionsView.EnableAppearanceEvenRow = True
        Me.grd1.OptionsView.EnableAppearanceOddRow = True
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowFooter = True
        '
        'colCodigoInterno
        '
        Me.colCodigoInterno.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodigoInterno.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoInterno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoInterno.Caption = "Código"
        Me.colCodigoInterno.FieldName = "CodigoInterno"
        Me.colCodigoInterno.Name = "colCodigoInterno"
        Me.colCodigoInterno.OptionsColumn.ReadOnly = True
        Me.colCodigoInterno.Visible = True
        Me.colCodigoInterno.VisibleIndex = 0
        Me.colCodigoInterno.Width = 102
        '
        'colProduto
        '
        Me.colProduto.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colProduto.Caption = "Produto"
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 1
        Me.colProduto.Width = 432
        '
        'colTamanho
        '
        Me.colTamanho.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colTamanho.AppearanceCell.Options.UseTextOptions = True
        Me.colTamanho.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTamanho.Caption = "Tamanho"
        Me.colTamanho.FieldName = "Tamanho"
        Me.colTamanho.Name = "colTamanho"
        Me.colTamanho.OptionsColumn.ReadOnly = True
        Me.colTamanho.Visible = True
        Me.colTamanho.VisibleIndex = 3
        Me.colTamanho.Width = 146
        '
        'colQtd
        '
        Me.colQtd.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colQtd.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtd.Caption = "Qtd"
        Me.colQtd.FieldName = "Qtd"
        Me.colQtd.Name = "colQtd"
        Me.colQtd.OptionsColumn.ReadOnly = True
        Me.colQtd.SummaryItem.DisplayFormat = "{0:0.000}"
        Me.colQtd.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colQtd.Visible = True
        Me.colQtd.VisibleIndex = 4
        Me.colQtd.Width = 154
        '
        'colLocacao
        '
        Me.colLocacao.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colLocacao.AppearanceCell.Options.UseTextOptions = True
        Me.colLocacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLocacao.Caption = "Locacao"
        Me.colLocacao.FieldName = "Locacao"
        Me.colLocacao.Name = "colLocacao"
        Me.colLocacao.OptionsColumn.ReadOnly = True
        Me.colLocacao.Visible = True
        Me.colLocacao.VisibleIndex = 2
        Me.colLocacao.Width = 149
        '
        'colCodigoBarra
        '
        Me.colCodigoBarra.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodigoBarra.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoBarra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoBarra.Caption = "Código Barras"
        Me.colCodigoBarra.FieldName = "CodigoBarra"
        Me.colCodigoBarra.Name = "colCodigoBarra"
        Me.colCodigoBarra.OptionsColumn.ReadOnly = True
        '
        'colGrupo
        '
        Me.colGrupo.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colGrupo.AppearanceCell.Options.UseTextOptions = True
        Me.colGrupo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGrupo.Caption = "Grupo"
        Me.colGrupo.FieldName = "Grupo"
        Me.colGrupo.Name = "colGrupo"
        Me.colGrupo.OptionsColumn.ReadOnly = True
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnFechar, Me.BarSubItem1, Me.btnVisualizar, Me.btnRelCust})
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "&Visualizar"
        Me.BarSubItem1.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.BarSubItem1.Id = 1
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnVisualizar), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCust)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Caption = "&Relatório de Tamanhos"
        Me.btnVisualizar.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnVisualizar.Id = 2
        Me.btnVisualizar.Name = "btnVisualizar"
        '
        'btnRelCust
        '
        Me.btnRelCust.Caption = "Relatório C&ustomizado"
        Me.btnRelCust.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnRelCust.Id = 3
        Me.btnRelCust.Name = "btnRelCust"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 0
        Me.btnFechar.Name = "btnFechar"
        '
        'colValor
        '
        Me.colValor.AppearanceCell.Options.UseTextOptions = True
        Me.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor.Caption = "Valor R$"
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.OptionsColumn.ReadOnly = True
        '
        'colValorCusto
        '
        Me.colValorCusto.AppearanceCell.Options.UseTextOptions = True
        Me.colValorCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorCusto.Caption = "Valor Custo R$"
        Me.colValorCusto.FieldName = "ValorCusto"
        Me.colValorCusto.Name = "colValorCusto"
        Me.colValorCusto.OptionsColumn.ReadOnly = True
        '
        'colSetor
        '
        Me.colSetor.Caption = "Setor"
        Me.colSetor.FieldName = "Setor"
        Me.colSetor.Name = "colSetor"
        Me.colSetor.OptionsColumn.ReadOnly = True
        '
        'colUnidadeMedida
        '
        Me.colUnidadeMedida.Caption = "U.M."
        Me.colUnidadeMedida.FieldName = "UnidadeMedida"
        Me.colUnidadeMedida.Name = "colUnidadeMedida"
        Me.colUnidadeMedida.OptionsColumn.ReadOnly = True
        '
        'colFornecedor
        '
        Me.colFornecedor.Caption = "Fornecedor"
        Me.colFornecedor.FieldName = "Fornecedor"
        Me.colFornecedor.Name = "colFornecedor"
        Me.colFornecedor.OptionsColumn.ReadOnly = True
        '
        'colData
        '
        Me.colData.Caption = "Data"
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.OptionsColumn.ReadOnly = True
        '
        'colTipo
        '
        Me.colTipo.Caption = "Tipo"
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.OptionsColumn.ReadOnly = True
        '
        'colObs
        '
        Me.colObs.Caption = "Obs"
        Me.colObs.FieldName = "Obs"
        Me.colObs.Name = "colObs"
        Me.colObs.OptionsColumn.ReadOnly = True
        '
        'colCodProdFor
        '
        Me.colCodProdFor.Caption = "Cód. Forn."
        Me.colCodProdFor.FieldName = "CodProdFor"
        Me.colCodProdFor.Name = "colCodProdFor"
        Me.colCodProdFor.OptionsColumn.ReadOnly = True
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Valor"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "ValorCusto"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Setor"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "UnidadeMedida"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "CodProdFor"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "Fornecedor"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "Data"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "Tipo"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "Obs"
        '
        'frmConProdTam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmConProdTam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Tamanho"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnVisualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRelCust As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dsProd As System.Data.DataSet
    Friend WithEvents tbProd As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTamanho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocacao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents colCodigoInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents colCodigoBarra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrupo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnPadrao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnManter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSetor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidadeMedida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFornecedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodProdFor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
End Class
