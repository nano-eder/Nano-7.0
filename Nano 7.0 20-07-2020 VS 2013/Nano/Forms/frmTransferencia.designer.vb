<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferencia
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
        Dim Label8 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransferencia))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsItens = New System.Data.DataSet
        Me.tbItens = New System.Data.DataTable
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
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodOrdem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTamanho = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colQtd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodUserSaida = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodLoja = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodConfig = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodUserEntrada = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEntSai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLoja = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCustoTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLote = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem
        Me.btnVisualizar = New DevExpress.XtraBars.BarButtonItem
        Me.btnEnviar = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.btnAdicionar = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.txtQtde = New Campos.NanoCampo
        Me.txtProd = New Campos.NanoCampo
        Me.txtValor = New Campos.NanoCampo
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtCodProd = New DevExpress.XtraEditors.ButtonEdit
        Me.lblLoja = New DevExpress.XtraEditors.LabelControl
        Me.lueLoja = New DevExpress.XtraEditors.LookUpEdit
        Me.ConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.ConfigTableAdapter = New Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
        Me.btnConsulta = New DevExpress.XtraEditors.SimpleButton
        Me.dtData = New DevExpress.XtraEditors.DateEdit
        Me.lblCodPed = New DevExpress.XtraEditors.LabelControl
        Me.txtCodPed = New DevExpress.XtraEditors.TextEdit
        Me.chkAutoAdd = New DevExpress.XtraEditors.CheckEdit
        Label8 = New System.Windows.Forms.Label
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsItens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbItens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodProd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLoja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodPed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAutoAdd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(843, 12)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(30, 13)
        Label8.TabIndex = 127
        Label8.Text = "Data"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbItens"
        Me.GridControl1.DataSource = Me.dsItens
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterar})
        Me.GridControl1.Size = New System.Drawing.Size(1000, 473)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsItens
        '
        Me.dsItens.DataSetName = "NewDataSet"
        Me.dsItens.Tables.AddRange(New System.Data.DataTable() {Me.tbItens})
        '
        'tbItens
        '
        Me.tbItens.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18})
        Me.tbItens.TableName = "tbItens"
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
        Me.DataColumn4.ColumnName = "Tamanho"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Qtd"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "ValorCusto"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "CodUserSaida"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "CodLoja"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "CodConfig"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "CodUserEntrada"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Status"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "EntSai"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "Data"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "CodigoInterno"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "Produto"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "Loja"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "CustoTotal"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "Lote"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colCodOrdem, Me.colCodProd, Me.colTamanho, Me.colQtd, Me.colValorCusto, Me.colCodUserSaida, Me.colCodLoja, Me.colCodConfig, Me.colCodUserEntrada, Me.colStatus, Me.colEntSai, Me.colData, Me.colProduto, Me.colCodigoInterno, Me.colLoja, Me.colCustoTotal, Me.colLote})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowFooter = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        '
        'colCodOrdem
        '
        Me.colCodOrdem.Caption = "CodOrdem"
        Me.colCodOrdem.FieldName = "CodOrdem"
        Me.colCodOrdem.Name = "colCodOrdem"
        '
        'colCodProd
        '
        Me.colCodProd.Caption = "CodProd"
        Me.colCodProd.FieldName = "CodProd"
        Me.colCodProd.Name = "colCodProd"
        '
        'colTamanho
        '
        Me.colTamanho.AppearanceCell.Options.UseTextOptions = True
        Me.colTamanho.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTamanho.Caption = "Tamanho"
        Me.colTamanho.ColumnEdit = Me.txtAlterar
        Me.colTamanho.FieldName = "Tamanho"
        Me.colTamanho.Name = "colTamanho"
        Me.colTamanho.Visible = True
        Me.colTamanho.VisibleIndex = 2
        Me.colTamanho.Width = 69
        '
        'txtAlterar
        '
        Me.txtAlterar.AutoHeight = False
        Me.txtAlterar.Name = "txtAlterar"
        '
        'colQtd
        '
        Me.colQtd.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtd.Caption = "Qtd"
        Me.colQtd.ColumnEdit = Me.txtAlterar
        Me.colQtd.FieldName = "Qtd"
        Me.colQtd.Name = "colQtd"
        Me.colQtd.Visible = True
        Me.colQtd.VisibleIndex = 3
        Me.colQtd.Width = 67
        '
        'colValorCusto
        '
        Me.colValorCusto.AppearanceCell.Options.UseTextOptions = True
        Me.colValorCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorCusto.Caption = "Custo R$"
        Me.colValorCusto.ColumnEdit = Me.txtAlterar
        Me.colValorCusto.FieldName = "ValorCusto"
        Me.colValorCusto.Name = "colValorCusto"
        Me.colValorCusto.Width = 112
        '
        'colCodUserSaida
        '
        Me.colCodUserSaida.Caption = "CodUserSaida"
        Me.colCodUserSaida.FieldName = "CodUserSaida"
        Me.colCodUserSaida.Name = "colCodUserSaida"
        Me.colCodUserSaida.Width = 54
        '
        'colCodLoja
        '
        Me.colCodLoja.Caption = "CodLoja"
        Me.colCodLoja.FieldName = "CodLoja"
        Me.colCodLoja.Name = "colCodLoja"
        Me.colCodLoja.Width = 101
        '
        'colCodConfig
        '
        Me.colCodConfig.Caption = "CodConfig"
        Me.colCodConfig.FieldName = "CodConfig"
        Me.colCodConfig.Name = "colCodConfig"
        Me.colCodConfig.Width = 54
        '
        'colCodUserEntrada
        '
        Me.colCodUserEntrada.Caption = "CodUserEntrada"
        Me.colCodUserEntrada.FieldName = "CodUserEntrada"
        Me.colCodUserEntrada.Name = "colCodUserEntrada"
        Me.colCodUserEntrada.Width = 54
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Width = 54
        '
        'colEntSai
        '
        Me.colEntSai.Caption = "EntSai"
        Me.colEntSai.FieldName = "EntSai"
        Me.colEntSai.Name = "colEntSai"
        Me.colEntSai.Width = 54
        '
        'colData
        '
        Me.colData.Caption = "Data"
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.Width = 83
        '
        'colProduto
        '
        Me.colProduto.Caption = "Produto"
        Me.colProduto.ColumnEdit = Me.txtAlterar
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 1
        Me.colProduto.Width = 414
        '
        'colCodigoInterno
        '
        Me.colCodigoInterno.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoInterno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoInterno.Caption = "Código"
        Me.colCodigoInterno.ColumnEdit = Me.txtAlterar
        Me.colCodigoInterno.FieldName = "CodigoInterno"
        Me.colCodigoInterno.Name = "colCodigoInterno"
        Me.colCodigoInterno.Visible = True
        Me.colCodigoInterno.VisibleIndex = 0
        Me.colCodigoInterno.Width = 102
        '
        'colLoja
        '
        Me.colLoja.Caption = "Loja Entrada"
        Me.colLoja.ColumnEdit = Me.txtAlterar
        Me.colLoja.FieldName = "Loja"
        Me.colLoja.Name = "colLoja"
        Me.colLoja.Visible = True
        Me.colLoja.VisibleIndex = 5
        Me.colLoja.Width = 211
        '
        'colCustoTotal
        '
        Me.colCustoTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colCustoTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCustoTotal.Caption = "Custo Total R$"
        Me.colCustoTotal.ColumnEdit = Me.txtAlterar
        Me.colCustoTotal.FieldName = "CustoTotal"
        Me.colCustoTotal.Name = "colCustoTotal"
        Me.colCustoTotal.Width = 96
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
        Me.colLote.VisibleIndex = 4
        Me.colLote.Width = 116
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnExcluir, Me.btnSalvar, Me.btnFechar, Me.btnVisualizar, Me.btnEnviar})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExcluir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnVisualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnEnviar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Caption = "&Visualizar"
        Me.btnVisualizar.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnVisualizar.Id = 3
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnEnviar
        '
        Me.btnEnviar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnEnviar.Caption = "&Transferir"
        Me.btnEnviar.Glyph = Global.Nano.My.Resources.Resources.apply
        Me.btnEnviar.Id = 4
        Me.btnEnviar.Name = "btnEnviar"
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar.Caption = "&Salvar"
        Me.btnSalvar.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvar.Id = 1
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 2
        Me.btnFechar.Name = "btnFechar"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(2, 20)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1004, 510)
        Me.GroupControl1.TabIndex = 5
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Controls.Add(Me.GroupControl1)
        Me.GroupControl2.Location = New System.Drawing.Point(0, 88)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1008, 532)
        Me.GroupControl2.TabIndex = 8
        Me.GroupControl2.Text = "Itens da Tranferência"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnAdicionar.Location = New System.Drawing.Point(879, 54)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(117, 23)
        Me.btnAdicionar.TabIndex = 7
        Me.btnAdicionar.Text = "Adicionar"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(30, 36)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl3.TabIndex = 121
        Me.LabelControl3.Text = "Dados do Produto"
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Location = New System.Drawing.Point(9, 42)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(990, 5)
        Me.PanelControl2.TabIndex = 120
        '
        'txtQtde
        '
        Me.txtQtde.CasasDecimais = 3
        Me.txtQtde.EnterMoveNextControl = True
        Me.txtQtde.Location = New System.Drawing.Point(623, 58)
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.Numerico = True
        Me.txtQtde.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtde.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtde.Properties.MaxLength = 10
        Me.txtQtde.Size = New System.Drawing.Size(79, 20)
        Me.txtQtde.TabIndex = 4
        Me.txtQtde.Tag = "Qtde"
        '
        'txtProd
        '
        Me.txtProd.CasasDecimais = 0
        Me.txtProd.EnterMoveNextControl = True
        Me.txtProd.Location = New System.Drawing.Point(221, 58)
        Me.txtProd.Name = "txtProd"
        Me.txtProd.Numerico = False
        Me.txtProd.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtProd.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtProd.Size = New System.Drawing.Size(353, 20)
        Me.txtProd.TabIndex = 3
        '
        'txtValor
        '
        Me.txtValor.CasasDecimais = 2
        Me.txtValor.EnterMoveNextControl = True
        Me.txtValor.Location = New System.Drawing.Point(434, 58)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Numerico = True
        Me.txtValor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValor.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValor.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValor.Properties.MaxLength = 18
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 5
        Me.txtValor.Tag = "Valor"
        Me.txtValor.Visible = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(27, 61)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl9.TabIndex = 119
        Me.LabelControl9.Text = "Código"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(177, 61)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl8.TabIndex = 117
        Me.LabelControl8.Text = "Produto"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(593, 61)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl7.TabIndex = 115
        Me.LabelControl7.Text = "Qtde"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(357, 61)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl6.TabIndex = 114
        Me.LabelControl6.Text = "Valor Custo R$"
        Me.LabelControl6.Visible = False
        '
        'txtCodProd
        '
        Me.txtCodProd.EnterMoveNextControl = True
        Me.txtCodProd.Location = New System.Drawing.Point(66, 58)
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodProd.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCodProd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.txtCodProd.Size = New System.Drawing.Size(97, 20)
        Me.txtCodProd.TabIndex = 2
        Me.txtCodProd.Tag = "Código"
        '
        'lblLoja
        '
        Me.lblLoja.Location = New System.Drawing.Point(716, 61)
        Me.lblLoja.Name = "lblLoja"
        Me.lblLoja.Size = New System.Drawing.Size(20, 13)
        Me.lblLoja.TabIndex = 123
        Me.lblLoja.Text = "Loja"
        '
        'lueLoja
        '
        Me.lueLoja.EnterMoveNextControl = True
        Me.lueLoja.Location = New System.Drawing.Point(742, 58)
        Me.lueLoja.Name = "lueLoja"
        Me.lueLoja.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLoja.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 52, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descrição", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueLoja.Properties.DataSource = Me.ConfigBindingSource
        Me.lueLoja.Properties.DisplayMember = "Descricao"
        Me.lueLoja.Properties.NullText = ""
        Me.lueLoja.Properties.ValueMember = "Codigo"
        Me.lueLoja.Size = New System.Drawing.Size(108, 20)
        Me.lueLoja.TabIndex = 6
        Me.lueLoja.Tag = "Loja"
        '
        'ConfigBindingSource
        '
        Me.ConfigBindingSource.DataMember = "Config"
        Me.ConfigBindingSource.DataSource = Me.DsNanoCommerce
        '
        'DsNanoCommerce
        '
        Me.DsNanoCommerce.DataSetName = "dsNanoCommerce"
        Me.DsNanoCommerce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConfigTableAdapter
        '
        Me.ConfigTableAdapter.ClearBeforeFill = True
        '
        'btnConsulta
        '
        Me.btnConsulta.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.btnConsulta.Location = New System.Drawing.Point(163, 8)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(21, 21)
        Me.btnConsulta.TabIndex = 129
        Me.btnConsulta.ToolTipTitle = "Consulta de Pedido"
        '
        'dtData
        '
        Me.dtData.EditValue = ""
        Me.dtData.Enabled = False
        Me.dtData.EnterMoveNextControl = True
        Me.dtData.Location = New System.Drawing.Point(879, 9)
        Me.dtData.Name = "dtData"
        Me.dtData.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtData.Properties.Appearance.Options.UseFont = True
        Me.dtData.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtData.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtData.Size = New System.Drawing.Size(117, 20)
        Me.dtData.TabIndex = 1
        Me.dtData.Tag = "Data"
        '
        'lblCodPed
        '
        Me.lblCodPed.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodPed.Appearance.Options.UseFont = True
        Me.lblCodPed.Location = New System.Drawing.Point(4, 12)
        Me.lblCodPed.Name = "lblCodPed"
        Me.lblCodPed.Size = New System.Drawing.Size(54, 13)
        Me.lblCodPed.TabIndex = 125
        Me.lblCodPed.Text = "Nº Ordem"
        '
        'txtCodPed
        '
        Me.txtCodPed.EnterMoveNextControl = True
        Me.txtCodPed.Location = New System.Drawing.Point(66, 8)
        Me.txtCodPed.Name = "txtCodPed"
        Me.txtCodPed.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPed.Properties.Appearance.Options.UseFont = True
        Me.txtCodPed.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodPed.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCodPed.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtCodPed.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPed.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodPed.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCodPed.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtCodPed.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodPed.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCodPed.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCodPed.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCodPed.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCodPed.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodPed.Size = New System.Drawing.Size(97, 21)
        Me.txtCodPed.TabIndex = 0
        Me.txtCodPed.Tag = "Nº Pedido"
        '
        'chkAutoAdd
        '
        Me.chkAutoAdd.Location = New System.Drawing.Point(5, 58)
        Me.chkAutoAdd.Name = "chkAutoAdd"
        Me.chkAutoAdd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoAdd.Properties.Appearance.Options.UseFont = True
        Me.chkAutoAdd.Properties.Caption = ""
        Me.chkAutoAdd.Size = New System.Drawing.Size(19, 19)
        Me.chkAutoAdd.TabIndex = 130
        Me.chkAutoAdd.ToolTip = "Selecione para adicionar o produto automaticamente"
        '
        'frmTransferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.chkAutoAdd)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.dtData)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Me.lblCodPed)
        Me.Controls.Add(Me.txtCodPed)
        Me.Controls.Add(Me.lblLoja)
        Me.Controls.Add(Me.lueLoja)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.txtQtde)
        Me.Controls.Add(Me.txtProd)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtCodProd)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmTransferencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transferência de Produtos"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsItens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbItens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodProd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLoja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodPed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAutoAdd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVisualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnAdicionar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtQtde As Campos.NanoCampo
    Friend WithEvents txtProd As Campos.NanoCampo
    Friend WithEvents txtValor As Campos.NanoCampo
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodProd As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents lblLoja As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueLoja As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfigTableAdapter As Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
    Friend WithEvents btnConsulta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtData As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblCodPed As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodPed As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dsItens As System.Data.DataSet
    Friend WithEvents tbItens As System.Data.DataTable
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
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodOrdem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTamanho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodUserSaida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodLoja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodConfig As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodUserEntrada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEntSai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents colLoja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents colCustoTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnEnviar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents colLote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkAutoAdd As DevExpress.XtraEditors.CheckEdit
End Class
