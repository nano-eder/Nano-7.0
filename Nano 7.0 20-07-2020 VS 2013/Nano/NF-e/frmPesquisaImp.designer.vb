<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPesquisaImp
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
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition6 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition7 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition8 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition9 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition10 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition11 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition12 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition13 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition14 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition15 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition16 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPesquisaImp))
        Me.colCFOP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colNCM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICMS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIPI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPIS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOFINS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodEnq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAliquotaICMS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAliquotaIPI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAliquotaPIS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAliquotaCOFINS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRegime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOrigem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnEditar = New DevExpress.XtraBars.BarButtonItem
        Me.btnOK = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem
        Me.btnVisualizar = New DevExpress.XtraBars.BarButtonItem
        Me.btnRelCust = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsProduto = New System.Data.DataSet
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
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colModBC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRedBC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colModBCST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRedBCST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMVaST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICMSST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCalculoCred = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoANP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUFComb = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCest = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.lblQtd = New DevExpress.XtraEditors.LabelControl
        Me.rgpTipo = New DevExpress.XtraEditors.RadioGroup
        Me.lblPesquisa = New DevExpress.XtraEditors.LabelControl
        Me.rgpDados = New DevExpress.XtraEditors.RadioGroup
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btnPesquisar = New DevExpress.XtraEditors.SimpleButton
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.rdgRegime = New DevExpress.XtraEditors.RadioGroup
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.cboTipoFiscal = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl96 = New DevExpress.XtraEditors.LabelControl
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.rgpTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgpDados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgRegime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoFiscal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colCFOP
        '
        Me.colCFOP.AppearanceCell.Options.UseTextOptions = True
        Me.colCFOP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCFOP.Caption = "CFOP"
        Me.colCFOP.ColumnEdit = Me.txtAlterar
        Me.colCFOP.FieldName = "CFOP"
        Me.colCFOP.Name = "colCFOP"
        Me.colCFOP.OptionsColumn.ReadOnly = True
        Me.colCFOP.Visible = True
        Me.colCFOP.VisibleIndex = 2
        Me.colCFOP.Width = 58
        '
        'txtAlterar
        '
        Me.txtAlterar.AutoHeight = False
        Me.txtAlterar.Name = "txtAlterar"
        '
        'colNCM
        '
        Me.colNCM.AppearanceCell.Options.UseTextOptions = True
        Me.colNCM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNCM.Caption = "NCM"
        Me.colNCM.ColumnEdit = Me.txtAlterar
        Me.colNCM.FieldName = "NCM"
        Me.colNCM.Name = "colNCM"
        Me.colNCM.OptionsColumn.ReadOnly = True
        Me.colNCM.Visible = True
        Me.colNCM.VisibleIndex = 3
        Me.colNCM.Width = 76
        '
        'colICMS
        '
        Me.colICMS.AppearanceCell.Options.UseTextOptions = True
        Me.colICMS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colICMS.Caption = "CST ICMS"
        Me.colICMS.ColumnEdit = Me.txtAlterar
        Me.colICMS.FieldName = "CST"
        Me.colICMS.Name = "colICMS"
        Me.colICMS.OptionsColumn.ReadOnly = True
        Me.colICMS.Visible = True
        Me.colICMS.VisibleIndex = 6
        Me.colICMS.Width = 76
        '
        'colIPI
        '
        Me.colIPI.AppearanceCell.Options.UseTextOptions = True
        Me.colIPI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIPI.Caption = "CST IPI"
        Me.colIPI.ColumnEdit = Me.txtAlterar
        Me.colIPI.FieldName = "IPI"
        Me.colIPI.Name = "colIPI"
        Me.colIPI.OptionsColumn.ReadOnly = True
        Me.colIPI.Visible = True
        Me.colIPI.VisibleIndex = 8
        Me.colIPI.Width = 62
        '
        'colPIS
        '
        Me.colPIS.AppearanceCell.Options.UseTextOptions = True
        Me.colPIS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPIS.Caption = "CST PIS"
        Me.colPIS.ColumnEdit = Me.txtAlterar
        Me.colPIS.FieldName = "PIS"
        Me.colPIS.Name = "colPIS"
        Me.colPIS.OptionsColumn.ReadOnly = True
        Me.colPIS.Visible = True
        Me.colPIS.VisibleIndex = 11
        Me.colPIS.Width = 60
        '
        'colCOFINS
        '
        Me.colCOFINS.AppearanceCell.Options.UseTextOptions = True
        Me.colCOFINS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCOFINS.Caption = "CST COFINS"
        Me.colCOFINS.ColumnEdit = Me.txtAlterar
        Me.colCOFINS.FieldName = "COFINS"
        Me.colCOFINS.Name = "colCOFINS"
        Me.colCOFINS.OptionsColumn.ReadOnly = True
        Me.colCOFINS.Visible = True
        Me.colCOFINS.VisibleIndex = 13
        Me.colCOFINS.Width = 82
        '
        'colCodEnq
        '
        Me.colCodEnq.AppearanceCell.Options.UseTextOptions = True
        Me.colCodEnq.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodEnq.Caption = "Cód. Enq."
        Me.colCodEnq.ColumnEdit = Me.txtAlterar
        Me.colCodEnq.FieldName = "CodEnq"
        Me.colCodEnq.Name = "colCodEnq"
        Me.colCodEnq.OptionsColumn.ReadOnly = True
        Me.colCodEnq.Visible = True
        Me.colCodEnq.VisibleIndex = 10
        Me.colCodEnq.Width = 70
        '
        'colCodProd
        '
        Me.colCodProd.AppearanceCell.Options.UseTextOptions = True
        Me.colCodProd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodProd.Caption = "Código Produto"
        Me.colCodProd.ColumnEdit = Me.txtAlterar
        Me.colCodProd.FieldName = "CodProd"
        Me.colCodProd.Name = "colCodProd"
        Me.colCodProd.OptionsColumn.ReadOnly = True
        Me.colCodProd.Visible = True
        Me.colCodProd.VisibleIndex = 0
        Me.colCodProd.Width = 96
        '
        'colProduto
        '
        Me.colProduto.Caption = "Produto"
        Me.colProduto.ColumnEdit = Me.txtAlterar
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 1
        Me.colProduto.Width = 299
        '
        'colAliquotaICMS
        '
        Me.colAliquotaICMS.AppearanceCell.Options.UseTextOptions = True
        Me.colAliquotaICMS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAliquotaICMS.Caption = "Aliq. ICMS"
        Me.colAliquotaICMS.ColumnEdit = Me.txtAlterar
        Me.colAliquotaICMS.FieldName = "AliquotaICMS"
        Me.colAliquotaICMS.Name = "colAliquotaICMS"
        Me.colAliquotaICMS.OptionsColumn.ReadOnly = True
        Me.colAliquotaICMS.Visible = True
        Me.colAliquotaICMS.VisibleIndex = 7
        Me.colAliquotaICMS.Width = 71
        '
        'colAliquotaIPI
        '
        Me.colAliquotaIPI.AppearanceCell.Options.UseTextOptions = True
        Me.colAliquotaIPI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAliquotaIPI.Caption = "Aliq. IPI"
        Me.colAliquotaIPI.ColumnEdit = Me.txtAlterar
        Me.colAliquotaIPI.FieldName = "AliquotaIPI"
        Me.colAliquotaIPI.Name = "colAliquotaIPI"
        Me.colAliquotaIPI.OptionsColumn.ReadOnly = True
        Me.colAliquotaIPI.Visible = True
        Me.colAliquotaIPI.VisibleIndex = 9
        Me.colAliquotaIPI.Width = 60
        '
        'colAliquotaPIS
        '
        Me.colAliquotaPIS.AppearanceCell.Options.UseTextOptions = True
        Me.colAliquotaPIS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAliquotaPIS.Caption = "Aliq. PIS"
        Me.colAliquotaPIS.ColumnEdit = Me.txtAlterar
        Me.colAliquotaPIS.FieldName = "AliquotaPIS"
        Me.colAliquotaPIS.Name = "colAliquotaPIS"
        Me.colAliquotaPIS.OptionsColumn.ReadOnly = True
        Me.colAliquotaPIS.Visible = True
        Me.colAliquotaPIS.VisibleIndex = 12
        Me.colAliquotaPIS.Width = 62
        '
        'colAliquotaCOFINS
        '
        Me.colAliquotaCOFINS.AppearanceCell.Options.UseTextOptions = True
        Me.colAliquotaCOFINS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAliquotaCOFINS.Caption = "Aliq. COFINS"
        Me.colAliquotaCOFINS.ColumnEdit = Me.txtAlterar
        Me.colAliquotaCOFINS.FieldName = "AliquotaCOFINS"
        Me.colAliquotaCOFINS.Name = "colAliquotaCOFINS"
        Me.colAliquotaCOFINS.OptionsColumn.ReadOnly = True
        Me.colAliquotaCOFINS.Visible = True
        Me.colAliquotaCOFINS.VisibleIndex = 14
        Me.colAliquotaCOFINS.Width = 84
        '
        'colRegime
        '
        Me.colRegime.Caption = "Regime"
        Me.colRegime.ColumnEdit = Me.txtAlterar
        Me.colRegime.FieldName = "Regime"
        Me.colRegime.Name = "colRegime"
        Me.colRegime.OptionsColumn.ReadOnly = True
        Me.colRegime.Visible = True
        Me.colRegime.VisibleIndex = 4
        Me.colRegime.Width = 100
        '
        'colOrigem
        '
        Me.colOrigem.Caption = "Origem"
        Me.colOrigem.ColumnEdit = Me.txtAlterar
        Me.colOrigem.FieldName = "Origem"
        Me.colOrigem.Name = "colOrigem"
        Me.colOrigem.OptionsColumn.ReadOnly = True
        Me.colOrigem.Visible = True
        Me.colOrigem.VisibleIndex = 5
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnVisualizar, Me.btnFechar, Me.BarSubItem1, Me.btnRelCust, Me.btnOK, Me.btnEditar})
        Me.BarManager1.MaxItemId = 6
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnEditar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnOK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnEditar
        '
        Me.btnEditar.Caption = "&Editar"
        Me.btnEditar.Glyph = Global.Nano.My.Resources.Resources.Alterar
        Me.btnEditar.Id = 5
        Me.btnEditar.Name = "btnEditar"
        '
        'btnOK
        '
        Me.btnOK.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnOK.Caption = "&OK"
        Me.btnOK.Glyph = Global.Nano.My.Resources.Resources.apply
        Me.btnOK.Id = 4
        Me.btnOK.Name = "btnOK"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarSubItem1.Caption = "&Visualizar"
        Me.BarSubItem1.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.BarSubItem1.Id = 2
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnVisualizar), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCust)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Caption = "&Relatório de Tributos"
        Me.btnVisualizar.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnVisualizar.Id = 0
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
        Me.btnFechar.Id = 1
        Me.btnFechar.Name = "btnFechar"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbProd"
        Me.GridControl1.DataSource = Me.dsProduto
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterar})
        Me.GridControl1.Size = New System.Drawing.Size(822, 469)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsProduto
        '
        Me.dsProduto.DataSetName = "NewDataSet"
        Me.dsProduto.Tables.AddRange(New System.Data.DataTable() {Me.tbProd})
        '
        'tbProd
        '
        Me.tbProd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn15, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26})
        Me.tbProd.TableName = "tbProd"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Codigo"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "CodProd"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Produto"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "CFOP"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "NCM"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "CST"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "IPI"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "PIS"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "COFINS"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "CodEnq"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "AliquotaICMS"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "AliquotaIPI"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "AliquotaPIS"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "AliquotaCOFINS"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "Origem"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "ModBC"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "RedBC"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "ModBCST"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "RedBCST"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "MVaST"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "ICMSST"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "CalculoCred"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "CodigoANP"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "UFComb"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "Regime"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "Cest"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colCodProd, Me.colProduto, Me.colCFOP, Me.colNCM, Me.colICMS, Me.colIPI, Me.colPIS, Me.colCOFINS, Me.colCodEnq, Me.colAliquotaICMS, Me.colAliquotaIPI, Me.colAliquotaPIS, Me.colAliquotaCOFINS, Me.colOrigem, Me.colModBC, Me.colRedBC, Me.colModBCST, Me.colRedBCST, Me.colMVaST, Me.colICMSST, Me.colRegime, Me.colCalculoCred, Me.colCodigoANP, Me.colUFComb, Me.colCest})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Column = Me.colCFOP
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition1.Value1 = ""
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Column = Me.colNCM
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition2.Value1 = ""
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition3.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition3.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Appearance.Options.UseFont = True
        StyleFormatCondition3.Column = Me.colICMS
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition3.Value1 = ""
        StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition4.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition4.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition4.Appearance.Options.UseBackColor = True
        StyleFormatCondition4.Appearance.Options.UseFont = True
        StyleFormatCondition4.Column = Me.colICMS
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition4.Value1 = ""
        StyleFormatCondition5.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition5.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition5.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition5.Appearance.Options.UseBackColor = True
        StyleFormatCondition5.Appearance.Options.UseFont = True
        StyleFormatCondition5.Column = Me.colIPI
        StyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition5.Value1 = ""
        StyleFormatCondition5.Value2 = "Null"
        StyleFormatCondition6.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition6.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition6.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition6.Appearance.Options.UseBackColor = True
        StyleFormatCondition6.Appearance.Options.UseFont = True
        StyleFormatCondition6.Column = Me.colPIS
        StyleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition6.Value1 = ""
        StyleFormatCondition7.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition7.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition7.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition7.Appearance.Options.UseBackColor = True
        StyleFormatCondition7.Appearance.Options.UseFont = True
        StyleFormatCondition7.Column = Me.colCOFINS
        StyleFormatCondition7.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition7.Value1 = ""
        StyleFormatCondition8.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition8.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition8.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition8.Appearance.Options.UseBackColor = True
        StyleFormatCondition8.Appearance.Options.UseFont = True
        StyleFormatCondition8.Column = Me.colCodEnq
        StyleFormatCondition8.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition8.Value1 = ""
        StyleFormatCondition9.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition9.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition9.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition9.Appearance.Options.UseBackColor = True
        StyleFormatCondition9.Appearance.Options.UseFont = True
        StyleFormatCondition9.Column = Me.colCodProd
        StyleFormatCondition9.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition9.Value1 = ""
        StyleFormatCondition10.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition10.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition10.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition10.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition10.Appearance.Options.UseBackColor = True
        StyleFormatCondition10.Appearance.Options.UseFont = True
        StyleFormatCondition10.Column = Me.colProduto
        StyleFormatCondition10.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition10.Value1 = ""
        StyleFormatCondition11.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition11.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition11.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition11.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition11.Appearance.Options.UseBackColor = True
        StyleFormatCondition11.Appearance.Options.UseFont = True
        StyleFormatCondition11.Column = Me.colAliquotaICMS
        StyleFormatCondition11.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition11.Value1 = ""
        StyleFormatCondition12.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition12.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition12.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition12.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition12.Appearance.Options.UseBackColor = True
        StyleFormatCondition12.Appearance.Options.UseFont = True
        StyleFormatCondition12.Column = Me.colAliquotaIPI
        StyleFormatCondition12.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition12.Value1 = ""
        StyleFormatCondition13.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition13.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition13.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition13.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition13.Appearance.Options.UseBackColor = True
        StyleFormatCondition13.Appearance.Options.UseFont = True
        StyleFormatCondition13.Column = Me.colAliquotaPIS
        StyleFormatCondition13.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition13.Value1 = ""
        StyleFormatCondition14.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition14.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition14.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition14.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition14.Appearance.Options.UseBackColor = True
        StyleFormatCondition14.Appearance.Options.UseFont = True
        StyleFormatCondition14.Column = Me.colAliquotaCOFINS
        StyleFormatCondition14.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition14.Value1 = ""
        StyleFormatCondition15.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition15.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition15.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StyleFormatCondition15.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition15.Appearance.Options.UseBackColor = True
        StyleFormatCondition15.Appearance.Options.UseFont = True
        StyleFormatCondition15.Column = Me.colRegime
        StyleFormatCondition15.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition15.Value1 = ""
        StyleFormatCondition16.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition16.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition16.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StyleFormatCondition16.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition16.Appearance.Options.UseBackColor = True
        StyleFormatCondition16.Appearance.Options.UseFont = True
        StyleFormatCondition16.Column = Me.colOrigem
        StyleFormatCondition16.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition16.Value1 = ""
        Me.grd1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4, StyleFormatCondition5, StyleFormatCondition6, StyleFormatCondition7, StyleFormatCondition8, StyleFormatCondition9, StyleFormatCondition10, StyleFormatCondition11, StyleFormatCondition12, StyleFormatCondition13, StyleFormatCondition14, StyleFormatCondition15, StyleFormatCondition16})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ColumnAutoWidth = False
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        '
        'colModBC
        '
        Me.colModBC.Caption = "Mod. BC"
        Me.colModBC.ColumnEdit = Me.txtAlterar
        Me.colModBC.FieldName = "ModBC"
        Me.colModBC.Name = "colModBC"
        Me.colModBC.OptionsColumn.ReadOnly = True
        Me.colModBC.Visible = True
        Me.colModBC.VisibleIndex = 15
        '
        'colRedBC
        '
        Me.colRedBC.Caption = "Red. BC"
        Me.colRedBC.ColumnEdit = Me.txtAlterar
        Me.colRedBC.FieldName = "RedBC"
        Me.colRedBC.Name = "colRedBC"
        Me.colRedBC.OptionsColumn.ReadOnly = True
        Me.colRedBC.Visible = True
        Me.colRedBC.VisibleIndex = 16
        '
        'colModBCST
        '
        Me.colModBCST.Caption = "Mod. BC ST"
        Me.colModBCST.ColumnEdit = Me.txtAlterar
        Me.colModBCST.FieldName = "ModBCST"
        Me.colModBCST.Name = "colModBCST"
        Me.colModBCST.OptionsColumn.ReadOnly = True
        Me.colModBCST.Visible = True
        Me.colModBCST.VisibleIndex = 23
        '
        'colRedBCST
        '
        Me.colRedBCST.Caption = "Red. BC ST"
        Me.colRedBCST.ColumnEdit = Me.txtAlterar
        Me.colRedBCST.FieldName = "RedBCST"
        Me.colRedBCST.Name = "colRedBCST"
        Me.colRedBCST.OptionsColumn.ReadOnly = True
        Me.colRedBCST.Visible = True
        Me.colRedBCST.VisibleIndex = 22
        '
        'colMVaST
        '
        Me.colMVaST.Caption = "M.V.A.ST"
        Me.colMVaST.ColumnEdit = Me.txtAlterar
        Me.colMVaST.FieldName = "MVaST"
        Me.colMVaST.Name = "colMVaST"
        Me.colMVaST.OptionsColumn.ReadOnly = True
        Me.colMVaST.Visible = True
        Me.colMVaST.VisibleIndex = 21
        '
        'colICMSST
        '
        Me.colICMSST.Caption = "ICMS ST"
        Me.colICMSST.ColumnEdit = Me.txtAlterar
        Me.colICMSST.FieldName = "ICMSST"
        Me.colICMSST.Name = "colICMSST"
        Me.colICMSST.OptionsColumn.ReadOnly = True
        Me.colICMSST.Visible = True
        Me.colICMSST.VisibleIndex = 20
        '
        'colCalculoCred
        '
        Me.colCalculoCred.Caption = "Calc. do Créd."
        Me.colCalculoCred.ColumnEdit = Me.txtAlterar
        Me.colCalculoCred.FieldName = "CalculoCred"
        Me.colCalculoCred.Name = "colCalculoCred"
        Me.colCalculoCred.OptionsColumn.ReadOnly = True
        Me.colCalculoCred.Visible = True
        Me.colCalculoCred.VisibleIndex = 19
        Me.colCalculoCred.Width = 91
        '
        'colCodigoANP
        '
        Me.colCodigoANP.Caption = "Cód. ANP"
        Me.colCodigoANP.FieldName = "CodigoANP"
        Me.colCodigoANP.Name = "colCodigoANP"
        Me.colCodigoANP.OptionsColumn.ReadOnly = True
        Me.colCodigoANP.Visible = True
        Me.colCodigoANP.VisibleIndex = 18
        '
        'colUFComb
        '
        Me.colUFComb.Caption = "UF Comb."
        Me.colUFComb.FieldName = "UFComb"
        Me.colUFComb.Name = "colUFComb"
        Me.colUFComb.OptionsColumn.ReadOnly = True
        Me.colUFComb.Visible = True
        Me.colUFComb.VisibleIndex = 17
        '
        'colCest
        '
        Me.colCest.Caption = "CEST"
        Me.colCest.FieldName = "Cest"
        Me.colCest.Name = "colCest"
        Me.colCest.OptionsColumn.ReadOnly = True
        Me.colCest.Visible = True
        Me.colCest.VisibleIndex = 24
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(0, 92)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(830, 528)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "Produtos Cadastrados"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl2.Controls.Add(Me.GridControl1)
        Me.GroupControl2.Controls.Add(Me.lblQtd)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(2, 20)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(826, 506)
        Me.GroupControl2.TabIndex = 6
        '
        'lblQtd
        '
        Me.lblQtd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQtd.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtd.Appearance.Options.UseFont = True
        Me.lblQtd.Location = New System.Drawing.Point(10, 480)
        Me.lblQtd.Name = "lblQtd"
        Me.lblQtd.Size = New System.Drawing.Size(127, 18)
        Me.lblQtd.TabIndex = 5
        Me.lblQtd.Text = "Nº de Registros: "
        '
        'rgpTipo
        '
        Me.rgpTipo.Location = New System.Drawing.Point(15, 23)
        Me.rgpTipo.Name = "rgpTipo"
        Me.rgpTipo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "TODOS"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "VAZIO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "PREENCHIDO")})
        Me.rgpTipo.Size = New System.Drawing.Size(298, 21)
        Me.rgpTipo.TabIndex = 7
        '
        'lblPesquisa
        '
        Me.lblPesquisa.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPesquisa.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblPesquisa.Appearance.Options.UseFont = True
        Me.lblPesquisa.Appearance.Options.UseForeColor = True
        Me.lblPesquisa.Location = New System.Drawing.Point(19, 46)
        Me.lblPesquisa.Name = "lblPesquisa"
        Me.lblPesquisa.Size = New System.Drawing.Size(105, 13)
        Me.lblPesquisa.TabIndex = 77
        Me.lblPesquisa.Text = "Dados da Pesquisa"
        '
        'rgpDados
        '
        Me.rgpDados.Location = New System.Drawing.Point(19, 65)
        Me.rgpDados.Name = "rgpDados"
        Me.rgpDados.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "CFOP"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "NCM"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "CST ICMS"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "CST IPI"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "COD ENQ"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "CST PIS"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "CST COFINS")})
        Me.rgpDados.Size = New System.Drawing.Size(658, 21)
        Me.rgpDados.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(15, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl1.TabIndex = 79
        Me.LabelControl1.Text = "Tipo da Pesquisa"
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Image = Global.Nano.My.Resources.Resources.kghostview
        Me.btnPesquisar.Location = New System.Drawing.Point(696, 65)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(112, 21)
        Me.btnPesquisar.TabIndex = 80
        Me.btnPesquisar.Text = "Pesquisar"
        '
        'Timer1
        '
        '
        'rdgRegime
        '
        Me.rdgRegime.Location = New System.Drawing.Point(332, 23)
        Me.rdgRegime.Name = "rdgRegime"
        Me.rdgRegime.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "SIMPLES NACIONAL"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "TRIBUTAÇÃO NORMAL")})
        Me.rdgRegime.Size = New System.Drawing.Size(345, 21)
        Me.rdgRegime.TabIndex = 81
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(332, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl2.TabIndex = 82
        Me.LabelControl2.Text = "Regime"
        '
        'cboTipoFiscal
        '
        Me.cboTipoFiscal.EnterMoveNextControl = True
        Me.cboTipoFiscal.Location = New System.Drawing.Point(696, 24)
        Me.cboTipoFiscal.Name = "cboTipoFiscal"
        Me.cboTipoFiscal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoFiscal.Properties.Items.AddRange(New Object() {"AMBOS", "NFE", "SAT"})
        Me.cboTipoFiscal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTipoFiscal.Size = New System.Drawing.Size(112, 20)
        Me.cboTipoFiscal.TabIndex = 84
        Me.cboTipoFiscal.Tag = "Origem"
        '
        'LabelControl96
        '
        Me.LabelControl96.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl96.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl96.Appearance.Options.UseFont = True
        Me.LabelControl96.Appearance.Options.UseForeColor = True
        Me.LabelControl96.Location = New System.Drawing.Point(696, 4)
        Me.LabelControl96.Name = "LabelControl96"
        Me.LabelControl96.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl96.TabIndex = 83
        Me.LabelControl96.Text = "Tipo"
        '
        'frmPesquisaImp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 662)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.rdgRegime)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.rgpDados)
        Me.Controls.Add(Me.rgpTipo)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.lblPesquisa)
        Me.Controls.Add(Me.cboTipoFiscal)
        Me.Controls.Add(Me.LabelControl96)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPesquisaImp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pesquisa Produto"
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.rgpTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgpDados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgRegime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoFiscal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnVisualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rgpTipo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblPesquisa As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgpDados As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPesquisar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dsProduto As System.Data.DataSet
    Friend WithEvents tbProd As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCFOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNCM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICMS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOFINS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents colCodEnq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnRelCust As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblQtd As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents colAliquotaICMS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAliquotaIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAliquotaPIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAliquotaCOFINS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents colOrigem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModBC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRedBC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModBCST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRedBCST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMVaST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICMSST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRegime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCalculoCred As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnOK As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents colCodigoANP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUFComb As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents btnEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colCest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents rdgRegime As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTipoFiscal As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl96 As DevExpress.XtraEditors.LabelControl
End Class
