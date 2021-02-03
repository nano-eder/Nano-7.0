<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecTrans
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecTrans))
        Me.dsTrans = New System.Data.DataSet
        Me.tbTrans = New System.Data.DataTable
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
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem
        Me.btnVisualizar = New DevExpress.XtraBars.BarButtonItem
        Me.btnOk = New DevExpress.XtraBars.BarButtonItem
        Me.btnCorrigir = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodOrdem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEntSai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLoja = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTamanho = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodUserSaida = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodLoja = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUsuario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLote = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.chkSelecionarTodos = New DevExpress.XtraEditors.CheckEdit
        CType(Me.dsTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.chkSelecionarTodos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dsTrans
        '
        Me.dsTrans.DataSetName = "NewDataSet"
        Me.dsTrans.Tables.AddRange(New System.Data.DataTable() {Me.tbTrans})
        '
        'tbTrans
        '
        Me.tbTrans.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16})
        Me.tbTrans.TableName = "tbTrans"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Codigo"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "CodOrdem"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "CodProd"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "CodigoInterno"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Produto"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Qtd"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "ValorCusto"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Status"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "EntSai"
        Me.DataColumn9.DataType = GetType(Boolean)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Data"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Loja"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "Tamanho"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "CodUserSaida"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "CodLoja"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "Usuario"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "Lote"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnExcluir, Me.btnOk, Me.btnFechar, Me.btnVisualizar, Me.btnCorrigir})
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExcluir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnVisualizar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnOk, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCorrigir, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnExcluir
        '
        Me.btnExcluir.Caption = "&Excluir"
        Me.btnExcluir.Glyph = Global.Nano.My.Resources.Resources.delete
        Me.btnExcluir.Id = 0
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Caption = "&Visualizar"
        Me.btnVisualizar.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnVisualizar.Id = 3
        Me.btnVisualizar.Name = "btnVisualizar"
        '
        'btnOk
        '
        Me.btnOk.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnOk.Caption = "&Receber"
        Me.btnOk.Glyph = Global.Nano.My.Resources.Resources.apply
        Me.btnOk.Id = 1
        Me.btnOk.Name = "btnOk"
        '
        'btnCorrigir
        '
        Me.btnCorrigir.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnCorrigir.Caption = "&Devolver"
        Me.btnCorrigir.Glyph = Global.Nano.My.Resources.Resources.Alterar
        Me.btnCorrigir.Id = 4
        Me.btnCorrigir.Name = "btnCorrigir"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 2
        Me.btnFechar.Name = "btnFechar"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbTrans"
        Me.GridControl1.DataSource = Me.dsTrans
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(1004, 583)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colCodOrdem, Me.colCodProd, Me.colCodigoInterno, Me.colProduto, Me.colQtd, Me.colValorCusto, Me.colStatus, Me.colEntSai, Me.colData, Me.colLoja, Me.colTamanho, Me.colCodUserSaida, Me.colCodLoja, Me.colUsuario, Me.colLote})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsPrint.EnableAppearanceEvenRow = True
        Me.grd1.OptionsPrint.EnableAppearanceOddRow = True
        Me.grd1.OptionsView.EnableAppearanceEvenRow = True
        Me.grd1.OptionsView.EnableAppearanceOddRow = True
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowFooter = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        '
        'colCodOrdem
        '
        Me.colCodOrdem.AppearanceCell.Options.UseTextOptions = True
        Me.colCodOrdem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodOrdem.Caption = "Nº Ordem"
        Me.colCodOrdem.FieldName = "CodOrdem"
        Me.colCodOrdem.Name = "colCodOrdem"
        Me.colCodOrdem.OptionsColumn.ReadOnly = True
        Me.colCodOrdem.Visible = True
        Me.colCodOrdem.VisibleIndex = 0
        Me.colCodOrdem.Width = 68
        '
        'colCodProd
        '
        Me.colCodProd.Caption = "CodProd"
        Me.colCodProd.FieldName = "CodProd"
        Me.colCodProd.Name = "colCodProd"
        Me.colCodProd.OptionsColumn.ReadOnly = True
        '
        'colCodigoInterno
        '
        Me.colCodigoInterno.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoInterno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoInterno.Caption = "Cód. Prod."
        Me.colCodigoInterno.FieldName = "CodigoInterno"
        Me.colCodigoInterno.Name = "colCodigoInterno"
        Me.colCodigoInterno.OptionsColumn.ReadOnly = True
        Me.colCodigoInterno.Visible = True
        Me.colCodigoInterno.VisibleIndex = 2
        '
        'colProduto
        '
        Me.colProduto.Caption = "Produto"
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 3
        Me.colProduto.Width = 244
        '
        'colQtd
        '
        Me.colQtd.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtd.Caption = "Qtd"
        Me.colQtd.FieldName = "Qtd"
        Me.colQtd.Name = "colQtd"
        Me.colQtd.OptionsColumn.ReadOnly = True
        Me.colQtd.Visible = True
        Me.colQtd.VisibleIndex = 5
        Me.colQtd.Width = 60
        '
        'colValorCusto
        '
        Me.colValorCusto.AppearanceCell.Options.UseTextOptions = True
        Me.colValorCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorCusto.Caption = "Custo Total R$"
        Me.colValorCusto.FieldName = "ValorCusto"
        Me.colValorCusto.Name = "colValorCusto"
        Me.colValorCusto.OptionsColumn.ReadOnly = True
        Me.colValorCusto.Width = 93
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.OptionsColumn.ReadOnly = True
        '
        'colEntSai
        '
        Me.colEntSai.Caption = "Ok?"
        Me.colEntSai.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colEntSai.FieldName = "EntSai"
        Me.colEntSai.Name = "colEntSai"
        Me.colEntSai.Visible = True
        Me.colEntSai.VisibleIndex = 9
        Me.colEntSai.Width = 53
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
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
        Me.colData.VisibleIndex = 1
        Me.colData.Width = 86
        '
        'colLoja
        '
        Me.colLoja.Caption = "Loja"
        Me.colLoja.FieldName = "Loja"
        Me.colLoja.Name = "colLoja"
        Me.colLoja.OptionsColumn.ReadOnly = True
        Me.colLoja.Visible = True
        Me.colLoja.VisibleIndex = 7
        Me.colLoja.Width = 123
        '
        'colTamanho
        '
        Me.colTamanho.AppearanceCell.Options.UseTextOptions = True
        Me.colTamanho.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTamanho.Caption = "Tam."
        Me.colTamanho.FieldName = "Tamanho"
        Me.colTamanho.Name = "colTamanho"
        Me.colTamanho.OptionsColumn.ReadOnly = True
        Me.colTamanho.Visible = True
        Me.colTamanho.VisibleIndex = 4
        Me.colTamanho.Width = 44
        '
        'colCodUserSaida
        '
        Me.colCodUserSaida.Caption = "CodUserSaida"
        Me.colCodUserSaida.FieldName = "CodUserSaida"
        Me.colCodUserSaida.Name = "colCodUserSaida"
        Me.colCodUserSaida.OptionsColumn.ReadOnly = True
        '
        'colCodLoja
        '
        Me.colCodLoja.Caption = "CodLoja"
        Me.colCodLoja.FieldName = "CodLoja"
        Me.colCodLoja.Name = "colCodLoja"
        Me.colCodLoja.OptionsColumn.ReadOnly = True
        '
        'colUsuario
        '
        Me.colUsuario.Caption = "Usuário"
        Me.colUsuario.FieldName = "Usuario"
        Me.colUsuario.Name = "colUsuario"
        Me.colUsuario.OptionsColumn.ReadOnly = True
        Me.colUsuario.Visible = True
        Me.colUsuario.VisibleIndex = 8
        Me.colUsuario.Width = 146
        '
        'colLote
        '
        Me.colLote.AppearanceCell.Options.UseTextOptions = True
        Me.colLote.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLote.Caption = "Lote"
        Me.colLote.FieldName = "Lote"
        Me.colLote.Name = "colLote"
        Me.colLote.OptionsColumn.ReadOnly = True
        Me.colLote.Visible = True
        Me.colLote.VisibleIndex = 6
        Me.colLote.Width = 84
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl1.Controls.Add(Me.chkSelecionarTodos)
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1008, 620)
        Me.GroupControl1.TabIndex = 5
        '
        'chkSelecionarTodos
        '
        Me.chkSelecionarTodos.Location = New System.Drawing.Point(12, 593)
        Me.chkSelecionarTodos.Name = "chkSelecionarTodos"
        Me.chkSelecionarTodos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkSelecionarTodos.Properties.Appearance.Options.UseFont = True
        Me.chkSelecionarTodos.Properties.Caption = "Selecinar Todos"
        Me.chkSelecionarTodos.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkSelecionarTodos.Size = New System.Drawing.Size(117, 19)
        Me.chkSelecionarTodos.TabIndex = 5
        '
        'frmRecTrans
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
        Me.Name = "frmRecTrans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transferências a Receber"
        CType(Me.dsTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.chkSelecionarTodos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dsTrans As System.Data.DataSet
    Friend WithEvents tbTrans As System.Data.DataTable
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
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents btnVisualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnOk As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodOrdem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEntSai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLoja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents colTamanho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodUserSaida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents colCodLoja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents colUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents colLote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCorrigir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents chkSelecionarTodos As DevExpress.XtraEditors.CheckEdit
End Class
