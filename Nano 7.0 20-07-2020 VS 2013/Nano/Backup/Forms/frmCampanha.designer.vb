<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCampanha
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
        Dim Label6 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCampanha))
        Me.colCodProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnVisualizar = New DevExpress.XtraBars.BarButtonItem
        Me.btnExcel = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.btnFinalizar = New DevExpress.XtraBars.BarButtonItem
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.grpItens = New DevExpress.XtraEditors.GroupControl
        Me.pb1 = New System.Windows.Forms.ProgressBar
        Me.picFundo = New DevExpress.XtraEditors.PictureEdit
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
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigoInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlt = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExcluir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colCodInternoAnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorAnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txtCampanha = New Campos.NanoCampo
        Me.tabProd = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.txtValorAnt = New Campos.NanoCampo
        Me.txtValor = New Campos.NanoCampo
        Me.txtCodigoInterno = New Campos.NanoCampo
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton
        Me.txtNomePro = New Campos.NanoCampo
        Me.txtCodPro = New DevExpress.XtraEditors.ButtonEdit
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.btnRemover = New DevExpress.XtraEditors.SimpleButton
        Me.txtNomePro2 = New Campos.NanoCampo
        Me.txtCodPro2 = New DevExpress.XtraEditors.ButtonEdit
        Me.dtData = New DevExpress.XtraEditors.DateEdit
        Me.btnConsulta = New DevExpress.XtraEditors.SimpleButton
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dtFinal = New DevExpress.XtraEditors.DateEdit
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.ofd = New System.Windows.Forms.OpenFileDialog
        Label6 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label22 = New System.Windows.Forms.Label
        Label23 = New System.Windows.Forms.Label
        Label8 = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Label7 = New System.Windows.Forms.Label
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpItens.SuspendLayout()
        CType(Me.picFundo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtCampanha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabProd.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.txtValorAnt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoInterno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomePro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodPro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.txtNomePro2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodPro2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFinal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(842, 10)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(50, 13)
        Label6.TabIndex = 53
        Label6.Text = "Preço R$"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(32, 10)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(40, 13)
        Label3.TabIndex = 43
        Label3.Text = "Código"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(199, 10)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(45, 13)
        Label4.TabIndex = 45
        Label4.Text = "Produto"
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.Location = New System.Drawing.Point(23, 14)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(40, 13)
        Label22.TabIndex = 65
        Label22.Text = "Código"
        '
        'Label23
        '
        Label23.AutoSize = True
        Label23.Location = New System.Drawing.Point(193, 14)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(45, 13)
        Label23.TabIndex = 66
        Label23.Text = "Produto"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(662, 17)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(60, 13)
        Label8.TabIndex = 61
        Label8.Text = "Data Inicial"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(17, 17)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(58, 13)
        Label1.TabIndex = 62
        Label1.Text = "Campanha"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(650, 36)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(69, 13)
        Label2.TabIndex = 55
        Label2.Text = "Cód. Interno"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(840, 17)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(55, 13)
        Label5.TabIndex = 100
        Label5.Text = "Data Final"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(645, 10)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(74, 13)
        Label7.TabIndex = 57
        Label7.Text = "Preço Ant. R$"
        '
        'colCodProd
        '
        Me.colCodProd.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodProd.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colCodProd.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodProd.AppearanceCell.Options.UseFont = True
        Me.colCodProd.AppearanceCell.Options.UseForeColor = True
        Me.colCodProd.AppearanceCell.Options.UseTextOptions = True
        Me.colCodProd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodProd.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodProd.AppearanceHeader.Options.UseFont = True
        Me.colCodProd.Caption = "Cód. Prod."
        Me.colCodProd.FieldName = "CodProd"
        Me.colCodProd.Name = "colCodProd"
        Me.colCodProd.OptionsColumn.ReadOnly = True
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSalvar, Me.btnFechar, Me.btnLimpar, Me.btnVisualizar, Me.btnFinalizar, Me.btnExcel, Me.BarButtonItem5})
        Me.BarManager1.MaxItemId = 10
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnVisualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExcel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem5, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFinalizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Caption = "&Visualizar"
        Me.btnVisualizar.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnVisualizar.Id = 5
        Me.btnVisualizar.Name = "btnVisualizar"
        '
        'btnExcel
        '
        Me.btnExcel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnExcel.Caption = "Abrir &Excel"
        Me.btnExcel.Glyph = Global.Nano.My.Resources.Resources.excel8
        Me.btnExcel.Id = 8
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.BarButtonItem5.Caption = "Salvar"
        Me.BarButtonItem5.Glyph = Global.Nano.My.Resources.Resources.apply
        Me.BarButtonItem5.Id = 9
        Me.BarButtonItem5.Name = "BarButtonItem5"
        Me.BarButtonItem5.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar.Caption = "Con&cluir"
        Me.btnSalvar.Glyph = Global.Nano.My.Resources.Resources.apply
        Me.btnSalvar.Id = 0
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFinalizar.Caption = "Finali&zar"
        Me.btnFinalizar.Glyph = Global.Nano.My.Resources.Resources.apply
        Me.btnFinalizar.Id = 7
        Me.btnFinalizar.Name = "btnFinalizar"
        '
        'btnLimpar
        '
        Me.btnLimpar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnLimpar.Caption = "&Limpar"
        Me.btnLimpar.Glyph = Global.Nano.My.Resources.Resources.Comando_Limpar_32x32
        Me.btnLimpar.Id = 2
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 1
        Me.btnFechar.Name = "btnFechar"
        '
        'grpItens
        '
        Me.grpItens.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpItens.AppearanceCaption.Options.UseFont = True
        Me.grpItens.AppearanceCaption.Options.UseTextOptions = True
        Me.grpItens.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.grpItens.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.grpItens.Controls.Add(Me.pb1)
        Me.grpItens.Controls.Add(Me.picFundo)
        Me.grpItens.Controls.Add(Me.GridControl1)
        Me.grpItens.Controls.Add(Me.btnDelete)
        Me.grpItens.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpItens.Location = New System.Drawing.Point(2, 20)
        Me.grpItens.Name = "grpItens"
        Me.grpItens.Size = New System.Drawing.Size(1004, 467)
        Me.grpItens.TabIndex = 8
        Me.grpItens.Text = "Nº Itens : 0 "
        '
        'pb1
        '
        Me.pb1.Location = New System.Drawing.Point(2, 442)
        Me.pb1.Maximum = 320
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(999, 23)
        Me.pb1.TabIndex = 11
        Me.pb1.Visible = False
        '
        'picFundo
        '
        Me.picFundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picFundo.EditValue = Global.Nano.My.Resources.Resources.NANO_COMMERCE
        Me.picFundo.Location = New System.Drawing.Point(2, 2)
        Me.picFundo.Name = "picFundo"
        Me.picFundo.Size = New System.Drawing.Size(1000, 415)
        Me.picFundo.TabIndex = 9
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
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlt, Me.RepositoryItemCheckEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(1000, 415)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1, Me.GridView1})
        '
        'dsProd
        '
        Me.dsProd.DataSetName = "NewDataSet"
        Me.dsProd.Tables.AddRange(New System.Data.DataTable() {Me.tbProd})
        '
        'tbProd
        '
        Me.tbProd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9})
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
        Me.DataColumn3.ColumnName = "CodigoInterno"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Produto"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Valor"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Excluir"
        Me.DataColumn6.DataType = GetType(Boolean)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "ValorAnt"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "CodInternoAnt"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "ValorCusto"
        '
        'grd1
        '
        Me.grd1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grd1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grd1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grd1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.grd1.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grd1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grd1.Appearance.HideSelectionRow.Options.UseFont = True
        Me.grd1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grd1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grd1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grd1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodProd, Me.colCodigoInterno, Me.colProduto, Me.colValor, Me.colCodigo, Me.colExcluir, Me.colCodInternoAnt, Me.colValorAnt, Me.colValorCusto})
        Me.grd1.CustomizationFormBounds = New System.Drawing.Rectangle(1140, 433, 216, 199)
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition1.Appearance.Options.HighPriority = True
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colCodProd
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = ""
        Me.grd1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsNavigation.AutoFocusNewRow = True
        Me.grd1.OptionsView.EnableAppearanceEvenRow = True
        Me.grd1.OptionsView.EnableAppearanceOddRow = True
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodigoInterno
        '
        Me.colCodigoInterno.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoInterno.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colCodigoInterno.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodigoInterno.AppearanceCell.Options.UseFont = True
        Me.colCodigoInterno.AppearanceCell.Options.UseForeColor = True
        Me.colCodigoInterno.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoInterno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoInterno.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoInterno.AppearanceHeader.Options.UseFont = True
        Me.colCodigoInterno.Caption = "Código"
        Me.colCodigoInterno.ColumnEdit = Me.txtAlt
        Me.colCodigoInterno.FieldName = "CodigoInterno"
        Me.colCodigoInterno.Name = "colCodigoInterno"
        Me.colCodigoInterno.OptionsColumn.ReadOnly = True
        Me.colCodigoInterno.Visible = True
        Me.colCodigoInterno.VisibleIndex = 0
        Me.colCodigoInterno.Width = 170
        '
        'txtAlt
        '
        Me.txtAlt.AutoHeight = False
        Me.txtAlt.Name = "txtAlt"
        '
        'colProduto
        '
        Me.colProduto.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colProduto.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colProduto.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colProduto.AppearanceCell.Options.UseFont = True
        Me.colProduto.AppearanceCell.Options.UseForeColor = True
        Me.colProduto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colProduto.AppearanceHeader.Options.UseFont = True
        Me.colProduto.Caption = "Produto"
        Me.colProduto.ColumnEdit = Me.txtAlt
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 1
        Me.colProduto.Width = 643
        '
        'colValor
        '
        Me.colValor.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValor.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colValor.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colValor.AppearanceCell.Options.UseFont = True
        Me.colValor.AppearanceCell.Options.UseForeColor = True
        Me.colValor.AppearanceCell.Options.UseTextOptions = True
        Me.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValor.AppearanceHeader.Options.UseFont = True
        Me.colValor.Caption = "Valor R$"
        Me.colValor.ColumnEdit = Me.txtAlt
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.OptionsColumn.ReadOnly = True
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 2
        Me.colValor.Width = 118
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigo.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colCodigo.AppearanceCell.Options.UseFont = True
        Me.colCodigo.AppearanceCell.Options.UseForeColor = True
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        '
        'colExcluir
        '
        Me.colExcluir.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colExcluir.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colExcluir.AppearanceHeader.Options.UseFont = True
        Me.colExcluir.Caption = "Excluir"
        Me.colExcluir.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colExcluir.FieldName = "Excluir"
        Me.colExcluir.Name = "colExcluir"
        Me.colExcluir.Visible = True
        Me.colExcluir.VisibleIndex = 4
        Me.colExcluir.Width = 130
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colCodInternoAnt
        '
        Me.colCodInternoAnt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodInternoAnt.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colCodInternoAnt.AppearanceCell.Options.UseFont = True
        Me.colCodInternoAnt.AppearanceCell.Options.UseForeColor = True
        Me.colCodInternoAnt.AppearanceCell.Options.UseTextOptions = True
        Me.colCodInternoAnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodInternoAnt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodInternoAnt.AppearanceHeader.Options.UseFont = True
        Me.colCodInternoAnt.Caption = "Cód. Interno Ant."
        Me.colCodInternoAnt.FieldName = "CodInternoAnt"
        Me.colCodInternoAnt.Name = "colCodInternoAnt"
        Me.colCodInternoAnt.OptionsColumn.ReadOnly = True
        '
        'colValorAnt
        '
        Me.colValorAnt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValorAnt.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colValorAnt.AppearanceCell.Options.UseFont = True
        Me.colValorAnt.AppearanceCell.Options.UseForeColor = True
        Me.colValorAnt.AppearanceCell.Options.UseTextOptions = True
        Me.colValorAnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorAnt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValorAnt.AppearanceHeader.Options.UseFont = True
        Me.colValorAnt.Caption = "Valor Ant. R$"
        Me.colValorAnt.FieldName = "ValorAnt"
        Me.colValorAnt.Name = "colValorAnt"
        Me.colValorAnt.OptionsColumn.ReadOnly = True
        Me.colValorAnt.Visible = True
        Me.colValorAnt.VisibleIndex = 3
        Me.colValorAnt.Width = 113
        '
        'colValorCusto
        '
        Me.colValorCusto.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValorCusto.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colValorCusto.AppearanceCell.Options.UseFont = True
        Me.colValorCusto.AppearanceCell.Options.UseForeColor = True
        Me.colValorCusto.AppearanceCell.Options.UseTextOptions = True
        Me.colValorCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorCusto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValorCusto.AppearanceHeader.Options.UseFont = True
        Me.colValorCusto.Caption = "Valor Custo R$"
        Me.colValorCusto.FieldName = "ValorCusto"
        Me.colValorCusto.Name = "colValorCusto"
        Me.colValorCusto.OptionsColumn.ReadOnly = True
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodProd, Me.colCodigoInterno, Me.colProduto, Me.colValor})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'btnDelete
        '
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnDelete.Image = Global.Nano.My.Resources.Resources.Remove_Item
        Me.btnDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(2, 417)
        Me.btnDelete.LookAndFeel.SkinName = "Money Twins"
        Me.btnDelete.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(1000, 21)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Excluir Item(ns)"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.grpItens)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(0, 131)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1008, 489)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "Produtos Adicionados"
        '
        'txtCampanha
        '
        Me.txtCampanha.CasasDecimais = 2
        Me.txtCampanha.EnterMoveNextControl = True
        Me.txtCampanha.Location = New System.Drawing.Point(81, 14)
        Me.txtCampanha.Name = "txtCampanha"
        Me.txtCampanha.Numerico = False
        Me.txtCampanha.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCampanha.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCampanha.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCampanha.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCampanha.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCampanha.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCampanha.Properties.MaxLength = 50
        Me.txtCampanha.Size = New System.Drawing.Size(540, 20)
        Me.txtCampanha.TabIndex = 0
        Me.txtCampanha.Tag = "Campanha"
        '
        'tabProd
        '
        Me.tabProd.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabProd.AppearancePage.Header.Options.UseFont = True
        Me.tabProd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabProd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabProd.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.tabProd.Location = New System.Drawing.Point(0, 44)
        Me.tabProd.Name = "tabProd"
        Me.tabProd.SelectedTabPage = Me.XtraTabPage3
        Me.tabProd.Size = New System.Drawing.Size(1008, 87)
        Me.tabProd.TabIndex = 2
        Me.tabProd.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.txtValorAnt)
        Me.XtraTabPage3.Controls.Add(Me.txtValor)
        Me.XtraTabPage3.Controls.Add(Label7)
        Me.XtraTabPage3.Controls.Add(Me.txtCodigoInterno)
        Me.XtraTabPage3.Controls.Add(Label2)
        Me.XtraTabPage3.Controls.Add(Me.btnAdd)
        Me.XtraTabPage3.Controls.Add(Label6)
        Me.XtraTabPage3.Controls.Add(Label3)
        Me.XtraTabPage3.Controls.Add(Me.txtNomePro)
        Me.XtraTabPage3.Controls.Add(Label4)
        Me.XtraTabPage3.Controls.Add(Me.txtCodPro)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(999, 57)
        Me.XtraTabPage3.Text = "Adicionar Produtos"
        '
        'txtValorAnt
        '
        Me.txtValorAnt.CasasDecimais = 2
        Me.txtValorAnt.EnterMoveNextControl = True
        Me.txtValorAnt.Location = New System.Drawing.Point(725, 7)
        Me.txtValorAnt.Name = "txtValorAnt"
        Me.txtValorAnt.Numerico = True
        Me.txtValorAnt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorAnt.Properties.Appearance.Options.UseFont = True
        Me.txtValorAnt.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtValorAnt.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtValorAnt.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtValorAnt.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtValorAnt.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValorAnt.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValorAnt.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtValorAnt.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorAnt.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtValorAnt.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtValorAnt.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtValorAnt.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtValorAnt.Properties.MaxLength = 10
        Me.txtValorAnt.Size = New System.Drawing.Size(95, 20)
        Me.txtValorAnt.TabIndex = 2
        Me.txtValorAnt.Tag = "Tamanho"
        '
        'txtValor
        '
        Me.txtValor.CasasDecimais = 2
        Me.txtValor.EnterMoveNextControl = True
        Me.txtValor.Location = New System.Drawing.Point(898, 7)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Numerico = True
        Me.txtValor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValor.Properties.Appearance.Options.UseFont = True
        Me.txtValor.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtValor.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtValor.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtValor.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtValor.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValor.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValor.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtValor.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValor.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtValor.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtValor.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtValor.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtValor.Properties.MaxLength = 10
        Me.txtValor.Size = New System.Drawing.Size(95, 20)
        Me.txtValor.TabIndex = 3
        Me.txtValor.Tag = "Tamanho"
        '
        'txtCodigoInterno
        '
        Me.txtCodigoInterno.CasasDecimais = 0
        Me.txtCodigoInterno.EnterMoveNextControl = True
        Me.txtCodigoInterno.Location = New System.Drawing.Point(725, 33)
        Me.txtCodigoInterno.Name = "txtCodigoInterno"
        Me.txtCodigoInterno.Numerico = False
        Me.txtCodigoInterno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCodigoInterno.Properties.Appearance.Options.UseFont = True
        Me.txtCodigoInterno.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtCodigoInterno.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodigoInterno.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCodigoInterno.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodigoInterno.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodigoInterno.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCodigoInterno.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCodigoInterno.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCodigoInterno.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCodigoInterno.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCodigoInterno.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtCodigoInterno.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCodigoInterno.Properties.MaxLength = 10
        Me.txtCodigoInterno.Size = New System.Drawing.Size(95, 20)
        Me.txtCodigoInterno.TabIndex = 4
        Me.txtCodigoInterno.Tag = "Tamanho"
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnAdd.Location = New System.Drawing.Point(898, 33)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(95, 21)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "&Adicionar"
        '
        'txtNomePro
        '
        Me.txtNomePro.CasasDecimais = 0
        Me.txtNomePro.EnterMoveNextControl = True
        Me.txtNomePro.Location = New System.Drawing.Point(250, 7)
        Me.txtNomePro.Name = "txtNomePro"
        Me.txtNomePro.Numerico = False
        Me.txtNomePro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNomePro.Properties.Appearance.Options.UseFont = True
        Me.txtNomePro.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtNomePro.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNomePro.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNomePro.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNomePro.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomePro.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNomePro.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtNomePro.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNomePro.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtNomePro.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNomePro.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtNomePro.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNomePro.Properties.MaxLength = 200
        Me.txtNomePro.Size = New System.Drawing.Size(389, 20)
        Me.txtNomePro.TabIndex = 1
        Me.txtNomePro.Tag = "Tamanho"
        '
        'txtCodPro
        '
        Me.txtCodPro.EnterMoveNextControl = True
        Me.txtCodPro.Location = New System.Drawing.Point(78, 7)
        Me.txtCodPro.Name = "txtCodPro"
        Me.txtCodPro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPro.Properties.Appearance.Options.UseFont = True
        Me.txtCodPro.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtCodPro.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodPro.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCodPro.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodPro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.txtCodPro.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodPro.Properties.MaxLength = 50
        Me.txtCodPro.Size = New System.Drawing.Size(112, 20)
        Me.txtCodPro.TabIndex = 0
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.btnRemover)
        Me.XtraTabPage4.Controls.Add(Label22)
        Me.XtraTabPage4.Controls.Add(Me.txtNomePro2)
        Me.XtraTabPage4.Controls.Add(Label23)
        Me.XtraTabPage4.Controls.Add(Me.txtCodPro2)
        Me.XtraTabPage4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(999, 56)
        Me.XtraTabPage4.Text = "Remover Produtos"
        '
        'btnRemover
        '
        Me.btnRemover.Image = Global.Nano.My.Resources.Resources.Remove_Item
        Me.btnRemover.Location = New System.Drawing.Point(898, 10)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(95, 21)
        Me.btnRemover.TabIndex = 3
        Me.btnRemover.Text = "&Remover"
        '
        'txtNomePro2
        '
        Me.txtNomePro2.CasasDecimais = 0
        Me.txtNomePro2.EnterMoveNextControl = True
        Me.txtNomePro2.Location = New System.Drawing.Point(242, 11)
        Me.txtNomePro2.Name = "txtNomePro2"
        Me.txtNomePro2.Numerico = False
        Me.txtNomePro2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNomePro2.Properties.Appearance.Options.UseFont = True
        Me.txtNomePro2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomePro2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNomePro2.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtNomePro2.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNomePro2.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtNomePro2.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNomePro2.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtNomePro2.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNomePro2.Properties.MaxLength = 200
        Me.txtNomePro2.Size = New System.Drawing.Size(397, 20)
        Me.txtNomePro2.TabIndex = 69
        Me.txtNomePro2.Tag = "Tamanho"
        '
        'txtCodPro2
        '
        Me.txtCodPro2.EnterMoveNextControl = True
        Me.txtCodPro2.Location = New System.Drawing.Point(69, 11)
        Me.txtCodPro2.Name = "txtCodPro2"
        Me.txtCodPro2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPro2.Properties.Appearance.Options.UseFont = True
        Me.txtCodPro2.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodPro2.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodPro2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.txtCodPro2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodPro2.Properties.MaxLength = 50
        Me.txtCodPro2.Size = New System.Drawing.Size(112, 20)
        Me.txtCodPro2.TabIndex = 0
        '
        'dtData
        '
        Me.dtData.EditValue = ""
        Me.dtData.EnterMoveNextControl = True
        Me.dtData.Location = New System.Drawing.Point(728, 14)
        Me.dtData.Name = "dtData"
        Me.dtData.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtData.Properties.Appearance.Options.UseFont = True
        Me.dtData.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtData.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.dtData.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.dtData.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.dtData.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.dtData.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.dtData.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.dtData.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.dtData.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtData.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtData.Size = New System.Drawing.Size(95, 20)
        Me.dtData.TabIndex = 1
        Me.dtData.Tag = "Data"
        '
        'btnConsulta
        '
        Me.btnConsulta.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.btnConsulta.Location = New System.Drawing.Point(621, 13)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(21, 21)
        Me.btnConsulta.TabIndex = 98
        Me.btnConsulta.ToolTipTitle = "Consulta de Pedido"
        '
        'Timer1
        '
        '
        'dtFinal
        '
        Me.dtFinal.EditValue = ""
        Me.dtFinal.EnterMoveNextControl = True
        Me.dtFinal.Location = New System.Drawing.Point(901, 14)
        Me.dtFinal.Name = "dtFinal"
        Me.dtFinal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFinal.Properties.Appearance.Options.UseFont = True
        Me.dtFinal.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtFinal.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.dtFinal.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.dtFinal.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.dtFinal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.dtFinal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.dtFinal.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.dtFinal.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.dtFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFinal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtFinal.Size = New System.Drawing.Size(95, 20)
        Me.dtFinal.TabIndex = 99
        Me.dtFinal.Tag = "Data"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarButtonItem1.Caption = "La&nçar"
        Me.BarButtonItem1.Glyph = Global.Nano.My.Resources.Resources.apply
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarButtonItem2.Caption = "La&nçar"
        Me.BarButtonItem2.Glyph = Global.Nano.My.Resources.Resources.apply
        Me.BarButtonItem2.Id = 0
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarButtonItem3.Caption = "La&nçar"
        Me.BarButtonItem3.Glyph = Global.Nano.My.Resources.Resources.apply
        Me.BarButtonItem3.Id = 0
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'frmCampanha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.dtFinal)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.dtData)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Me.tabProd)
        Me.Controls.Add(Me.txtCampanha)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCampanha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Campanhas"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpItens.ResumeLayout(False)
        CType(Me.picFundo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtCampanha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabProd.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.txtValorAnt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoInterno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomePro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodPro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage4.PerformLayout()
        CType(Me.txtNomePro2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodPro2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFinal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents grpItens As DevExpress.XtraEditors.GroupControl
    Friend WithEvents picFundo As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCampanha As Campos.NanoCampo
    Friend WithEvents tabProd As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNomePro As Campos.NanoCampo
    Friend WithEvents txtCodPro As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnRemover As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNomePro2 As Campos.NanoCampo
    Friend WithEvents txtCodPro2 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents dtData As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dsProd As System.Data.DataSet
    Friend WithEvents tbProd As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents btnConsulta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtAlt As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colExcluir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents colCodInternoAnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorAnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCodigoInterno As Campos.NanoCampo
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents colValorCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnVisualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dtFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFinalizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtValorAnt As Campos.NanoCampo
    Friend WithEvents txtValor As Campos.NanoCampo
    Friend WithEvents btnExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pb1 As System.Windows.Forms.ProgressBar
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
End Class
