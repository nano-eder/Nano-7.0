<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigSAT
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
        Dim Label13 As System.Windows.Forms.Label
        Dim Label40 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfigSAT))
        Me.Label1 = New System.Windows.Forms.Label
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnExclui = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.btnAlterar = New DevExpress.XtraBars.BarButtonItem
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsConfig = New System.Data.DataSet
        Me.tbConfig = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.tbComp = New System.Data.DataTable
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCaminhoPastaSATServ = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCnpj = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colIE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumSerie = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAssinatura = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVersaoXmlSAT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colModeloSAT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRegime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.grd2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCaminhoPastaSAT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComputador = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlt = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colNumCaixa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colModeloImpSAT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNomeImpSAT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colImpDiretoSAT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colMensImpCupomSAT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.txtIE = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl56 = New DevExpress.XtraEditors.LabelControl
        Me.txtCNPJ = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl57 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtNumSerie = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl45 = New DevExpress.XtraEditors.LabelControl
        Me.txtNumCaixa = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl53 = New DevExpress.XtraEditors.LabelControl
        Me.txtAssinatura = New DevExpress.XtraEditors.MemoEdit
        Me.txtComputador = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.cboRegime = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboModSAT = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtVersaoXml = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.btnSatServ = New DevExpress.XtraEditors.SimpleButton
        Me.txtCaminhoPastaSATServ = New DevExpress.XtraEditors.TextEdit
        Me.btnSAT = New DevExpress.XtraEditors.SimpleButton
        Me.txtPastaSAT = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.chkMensImpCupomSAT = New DevExpress.XtraEditors.CheckEdit
        Me.btnNomePc = New DevExpress.XtraEditors.SimpleButton
        Me.chkDireto = New DevExpress.XtraEditors.CheckEdit
        Me.txtNomeImp = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.cboModeloImp = New DevExpress.XtraEditors.ComboBoxEdit
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton
        Me.fbdOpen = New System.Windows.Forms.FolderBrowserDialog
        Label13 = New System.Windows.Forms.Label
        Label40 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsConfig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbConfig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbComp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCNPJ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumSerie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumCaixa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAssinatura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComputador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cboRegime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboModSAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVersaoXml.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCaminhoPastaSATServ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPastaSAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.chkMensImpCupomSAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDireto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomeImp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboModeloImp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(354, 41)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(56, 13)
        Label13.TabIndex = 118
        Label13.Text = "Mod. Imp."
        '
        'Label40
        '
        Label40.AutoSize = True
        Label40.Location = New System.Drawing.Point(25, 41)
        Label40.Name = "Label40"
        Label40.Size = New System.Drawing.Size(34, 13)
        Label40.TabIndex = 122
        Label40.Text = "Pasta"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(29, 67)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(53, 13)
        Label2.TabIndex = 130
        Label2.Text = "Mod. SAT"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(289, 67)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(42, 13)
        Label3.TabIndex = 132
        Label3.Text = "Regime"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Pasta Serv"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnExclui, Me.btnSalvar, Me.btnAlterar, Me.btnLimpar, Me.btnFechar})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExclui, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAlterar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnExclui
        '
        Me.btnExclui.Caption = "&Excluir"
        Me.btnExclui.Glyph = Global.Nano.My.Resources.Resources.delete
        Me.btnExclui.Id = 0
        Me.btnExclui.Name = "btnExclui"
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar.Caption = "&Salvar"
        Me.btnSalvar.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvar.Id = 1
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnAlterar
        '
        Me.btnAlterar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnAlterar.Caption = "&Alterar"
        Me.btnAlterar.Glyph = Global.Nano.My.Resources.Resources.Alterar
        Me.btnAlterar.Id = 2
        Me.btnAlterar.Name = "btnAlterar"
        '
        'btnLimpar
        '
        Me.btnLimpar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnLimpar.Caption = "&Limpar"
        Me.btnLimpar.Glyph = Global.Nano.My.Resources.Resources.Comando_Limpar_32x32
        Me.btnLimpar.Id = 3
        Me.btnLimpar.Name = "btnLimpar"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 4
        Me.btnFechar.Name = "btnFechar"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbConfig"
        Me.GridControl1.DataSource = Me.dsConfig
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 20)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterar})
        Me.GridControl1.Size = New System.Drawing.Size(1004, 177)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsConfig
        '
        Me.dsConfig.DataSetName = "NewDataSet"
        Me.dsConfig.Tables.AddRange(New System.Data.DataTable() {Me.tbConfig, Me.tbComp})
        '
        'tbConfig
        '
        Me.tbConfig.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn13, Me.DataColumn14})
        Me.tbConfig.TableName = "tbConfig"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Cnpj"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "IE"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "NumSerie"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Assinatura"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "ModeloSAT"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "Regime"
        '
        'tbComp
        '
        Me.tbComp.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12})
        Me.tbComp.TableName = "tbComp"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Computador"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "NumCaixa"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Codigo"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "ModeloImpSAT"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "CaminhoPastaSAT"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "NomeImpSAT"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "ImpDiretoSAT"
        Me.DataColumn11.DataType = GetType(Boolean)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "MensImpCupomSAT"
        Me.DataColumn12.DataType = GetType(Boolean)
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCaminhoPastaSATServ, Me.colCnpj, Me.colIE, Me.colNumSerie, Me.colAssinatura, Me.colVersaoXmlSAT, Me.colModeloSAT, Me.colRegime})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCaminhoPastaSATServ
        '
        Me.colCaminhoPastaSATServ.Caption = "Pasta SAT Serv."
        Me.colCaminhoPastaSATServ.FieldName = "CaminhoPastaSATServ"
        Me.colCaminhoPastaSATServ.Name = "colCaminhoPastaSATServ"
        Me.colCaminhoPastaSATServ.OptionsColumn.ReadOnly = True
        '
        'colCnpj
        '
        Me.colCnpj.AppearanceCell.Options.UseTextOptions = True
        Me.colCnpj.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCnpj.Caption = "CNPJ"
        Me.colCnpj.ColumnEdit = Me.txtAlterar
        Me.colCnpj.FieldName = "Cnpj"
        Me.colCnpj.Name = "colCnpj"
        Me.colCnpj.Visible = True
        Me.colCnpj.VisibleIndex = 0
        Me.colCnpj.Width = 150
        '
        'txtAlterar
        '
        Me.txtAlterar.AutoHeight = False
        Me.txtAlterar.Name = "txtAlterar"
        '
        'colIE
        '
        Me.colIE.AppearanceCell.Options.UseTextOptions = True
        Me.colIE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIE.Caption = "IE"
        Me.colIE.ColumnEdit = Me.txtAlterar
        Me.colIE.FieldName = "IE"
        Me.colIE.Name = "colIE"
        Me.colIE.Visible = True
        Me.colIE.VisibleIndex = 1
        Me.colIE.Width = 112
        '
        'colNumSerie
        '
        Me.colNumSerie.AppearanceCell.Options.UseTextOptions = True
        Me.colNumSerie.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumSerie.Caption = "Cód. Ativação"
        Me.colNumSerie.ColumnEdit = Me.txtAlterar
        Me.colNumSerie.FieldName = "NumSerie"
        Me.colNumSerie.Name = "colNumSerie"
        Me.colNumSerie.Visible = True
        Me.colNumSerie.VisibleIndex = 2
        Me.colNumSerie.Width = 119
        '
        'colAssinatura
        '
        Me.colAssinatura.Caption = "Assinatura"
        Me.colAssinatura.ColumnEdit = Me.txtAlterar
        Me.colAssinatura.FieldName = "Assinatura"
        Me.colAssinatura.Name = "colAssinatura"
        Me.colAssinatura.Visible = True
        Me.colAssinatura.VisibleIndex = 4
        Me.colAssinatura.Width = 368
        '
        'colVersaoXmlSAT
        '
        Me.colVersaoXmlSAT.AppearanceCell.Options.UseTextOptions = True
        Me.colVersaoXmlSAT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVersaoXmlSAT.Caption = "Versão Xml"
        Me.colVersaoXmlSAT.FieldName = "VersaoXmlSAT"
        Me.colVersaoXmlSAT.Name = "colVersaoXmlSAT"
        Me.colVersaoXmlSAT.OptionsColumn.ReadOnly = True
        Me.colVersaoXmlSAT.Visible = True
        Me.colVersaoXmlSAT.VisibleIndex = 3
        Me.colVersaoXmlSAT.Width = 88
        '
        'colModeloSAT
        '
        Me.colModeloSAT.Caption = "Mod. SAT"
        Me.colModeloSAT.FieldName = "ModeloSAT"
        Me.colModeloSAT.Name = "colModeloSAT"
        Me.colModeloSAT.OptionsColumn.ReadOnly = True
        Me.colModeloSAT.Visible = True
        Me.colModeloSAT.VisibleIndex = 5
        Me.colModeloSAT.Width = 71
        '
        'colRegime
        '
        Me.colRegime.Caption = "Regime"
        Me.colRegime.FieldName = "Regime"
        Me.colRegime.Name = "colRegime"
        Me.colRegime.OptionsColumn.ReadOnly = True
        Me.colRegime.Visible = True
        Me.colRegime.VisibleIndex = 6
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(0, 228)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1008, 199)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "Sat Configurado"
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "tbComp"
        Me.GridControl2.DataSource = Me.dsConfig
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(2, 91)
        Me.GridControl2.MainView = Me.grd2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlt, Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.GridControl2.Size = New System.Drawing.Size(518, 96)
        Me.GridControl2.TabIndex = 4
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd2})
        '
        'grd2
        '
        Me.grd2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCaminhoPastaSAT, Me.colComputador, Me.colNumCaixa, Me.colCodigo, Me.colModeloImpSAT, Me.colNomeImpSAT, Me.colImpDiretoSAT, Me.colMensImpCupomSAT})
        Me.grd2.GridControl = Me.GridControl2
        Me.grd2.Name = "grd2"
        Me.grd2.OptionsView.ColumnAutoWidth = False
        Me.grd2.OptionsView.ShowGroupPanel = False
        '
        'colCaminhoPastaSAT
        '
        Me.colCaminhoPastaSAT.Caption = "Pasta SAT"
        Me.colCaminhoPastaSAT.FieldName = "CaminhoPastaSAT"
        Me.colCaminhoPastaSAT.Name = "colCaminhoPastaSAT"
        Me.colCaminhoPastaSAT.OptionsColumn.ReadOnly = True
        Me.colCaminhoPastaSAT.Visible = True
        Me.colCaminhoPastaSAT.VisibleIndex = 4
        Me.colCaminhoPastaSAT.Width = 71
        '
        'colComputador
        '
        Me.colComputador.Caption = "Computador"
        Me.colComputador.ColumnEdit = Me.txtAlt
        Me.colComputador.FieldName = "Computador"
        Me.colComputador.Name = "colComputador"
        Me.colComputador.Visible = True
        Me.colComputador.VisibleIndex = 0
        Me.colComputador.Width = 117
        '
        'txtAlt
        '
        Me.txtAlt.AutoHeight = False
        Me.txtAlt.Name = "txtAlt"
        '
        'colNumCaixa
        '
        Me.colNumCaixa.Caption = "NumCaixa"
        Me.colNumCaixa.ColumnEdit = Me.txtAlt
        Me.colNumCaixa.FieldName = "NumCaixa"
        Me.colNumCaixa.Name = "colNumCaixa"
        Me.colNumCaixa.Visible = True
        Me.colNumCaixa.VisibleIndex = 1
        Me.colNumCaixa.Width = 69
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        '
        'colModeloImpSAT
        '
        Me.colModeloImpSAT.Caption = "Mod. Imp."
        Me.colModeloImpSAT.FieldName = "ModeloImpSAT"
        Me.colModeloImpSAT.Name = "colModeloImpSAT"
        Me.colModeloImpSAT.OptionsColumn.ReadOnly = True
        Me.colModeloImpSAT.Visible = True
        Me.colModeloImpSAT.VisibleIndex = 2
        Me.colModeloImpSAT.Width = 76
        '
        'colNomeImpSAT
        '
        Me.colNomeImpSAT.Caption = "Nome Imp."
        Me.colNomeImpSAT.FieldName = "NomeImpSAT"
        Me.colNomeImpSAT.Name = "colNomeImpSAT"
        Me.colNomeImpSAT.OptionsColumn.ReadOnly = True
        Me.colNomeImpSAT.Visible = True
        Me.colNomeImpSAT.VisibleIndex = 3
        Me.colNomeImpSAT.Width = 90
        '
        'colImpDiretoSAT
        '
        Me.colImpDiretoSAT.Caption = "Imp. Direto"
        Me.colImpDiretoSAT.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colImpDiretoSAT.FieldName = "ImpDiretoSAT"
        Me.colImpDiretoSAT.Name = "colImpDiretoSAT"
        Me.colImpDiretoSAT.OptionsColumn.ReadOnly = True
        Me.colImpDiretoSAT.Visible = True
        Me.colImpDiretoSAT.VisibleIndex = 5
        Me.colImpDiretoSAT.Width = 74
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colMensImpCupomSAT
        '
        Me.colMensImpCupomSAT.Caption = "Mens. Imp. Cupom"
        Me.colMensImpCupomSAT.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.colMensImpCupomSAT.FieldName = "MensImpCupomSAT"
        Me.colMensImpCupomSAT.Name = "colMensImpCupomSAT"
        Me.colMensImpCupomSAT.OptionsColumn.ReadOnly = True
        Me.colMensImpCupomSAT.Visible = True
        Me.colMensImpCupomSAT.VisibleIndex = 6
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'txtIE
        '
        Me.txtIE.Location = New System.Drawing.Point(337, 12)
        Me.txtIE.Name = "txtIE"
        Me.txtIE.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtIE.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtIE.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtIE.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtIE.Size = New System.Drawing.Size(119, 20)
        Me.txtIE.TabIndex = 1
        '
        'LabelControl56
        '
        Me.LabelControl56.Location = New System.Drawing.Point(321, 15)
        Me.LabelControl56.Name = "LabelControl56"
        Me.LabelControl56.Size = New System.Drawing.Size(10, 13)
        Me.LabelControl56.TabIndex = 9
        Me.LabelControl56.Text = "IE"
        '
        'txtCNPJ
        '
        Me.txtCNPJ.Location = New System.Drawing.Point(88, 12)
        Me.txtCNPJ.Name = "txtCNPJ"
        Me.txtCNPJ.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCNPJ.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCNPJ.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCNPJ.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCNPJ.Size = New System.Drawing.Size(185, 20)
        Me.txtCNPJ.TabIndex = 0
        '
        'LabelControl57
        '
        Me.LabelControl57.Location = New System.Drawing.Point(57, 15)
        Me.LabelControl57.Name = "LabelControl57"
        Me.LabelControl57.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl57.TabIndex = 7
        Me.LabelControl57.Text = "CNPJ"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(32, 93)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl3.TabIndex = 28
        Me.LabelControl3.Text = "Assinatura"
        '
        'txtNumSerie
        '
        Me.txtNumSerie.Location = New System.Drawing.Point(88, 38)
        Me.txtNumSerie.Name = "txtNumSerie"
        Me.txtNumSerie.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtNumSerie.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtNumSerie.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNumSerie.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNumSerie.Size = New System.Drawing.Size(185, 20)
        Me.txtNumSerie.TabIndex = 2
        '
        'LabelControl45
        '
        Me.LabelControl45.Location = New System.Drawing.Point(14, 41)
        Me.LabelControl45.Name = "LabelControl45"
        Me.LabelControl45.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl45.TabIndex = 32
        Me.LabelControl45.Text = "Cód. Ativação"
        '
        'txtNumCaixa
        '
        Me.txtNumCaixa.Location = New System.Drawing.Point(416, 12)
        Me.txtNumCaixa.Name = "txtNumCaixa"
        Me.txtNumCaixa.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtNumCaixa.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtNumCaixa.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNumCaixa.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNumCaixa.Properties.MaxLength = 3
        Me.txtNumCaixa.Size = New System.Drawing.Size(101, 20)
        Me.txtNumCaixa.TabIndex = 31
        '
        'LabelControl53
        '
        Me.LabelControl53.Location = New System.Drawing.Point(368, 15)
        Me.LabelControl53.Name = "LabelControl53"
        Me.LabelControl53.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl53.TabIndex = 30
        Me.LabelControl53.Text = "Nº Caixa"
        '
        'txtAssinatura
        '
        Me.txtAssinatura.Location = New System.Drawing.Point(88, 90)
        Me.txtAssinatura.Name = "txtAssinatura"
        Me.txtAssinatura.Size = New System.Drawing.Size(368, 115)
        Me.txtAssinatura.TabIndex = 5
        '
        'txtComputador
        '
        Me.txtComputador.Location = New System.Drawing.Point(65, 12)
        Me.txtComputador.Name = "txtComputador"
        Me.txtComputador.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtComputador.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtComputador.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtComputador.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtComputador.Size = New System.Drawing.Size(250, 20)
        Me.txtComputador.TabIndex = 10
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(28, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "Comp."
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnAdd.Location = New System.Drawing.Point(416, 64)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(101, 21)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "&Adicionar"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(19, 5)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(110, 13)
        Me.LabelControl2.TabIndex = 36
        Me.LabelControl2.Text = "Tipo da Impressora"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Label3)
        Me.PanelControl1.Controls.Add(Me.cboRegime)
        Me.PanelControl1.Controls.Add(Label2)
        Me.PanelControl1.Controls.Add(Me.cboModSAT)
        Me.PanelControl1.Controls.Add(Me.txtVersaoXml)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.txtAssinatura)
        Me.PanelControl1.Controls.Add(Me.btnSatServ)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.txtCaminhoPastaSATServ)
        Me.PanelControl1.Controls.Add(Me.txtCNPJ)
        Me.PanelControl1.Controls.Add(Me.LabelControl57)
        Me.PanelControl1.Controls.Add(Me.LabelControl56)
        Me.PanelControl1.Controls.Add(Me.txtNumSerie)
        Me.PanelControl1.Controls.Add(Me.txtIE)
        Me.PanelControl1.Controls.Add(Me.LabelControl45)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Location = New System.Drawing.Point(5, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(463, 210)
        Me.PanelControl1.TabIndex = 35
        '
        'cboRegime
        '
        Me.cboRegime.Location = New System.Drawing.Point(337, 64)
        Me.cboRegime.Name = "cboRegime"
        Me.cboRegime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRegime.Properties.Items.AddRange(New Object() {"SIMPLES NACIONAL", "TRIBUTAÇÃO NORMAL"})
        Me.cboRegime.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboRegime.Size = New System.Drawing.Size(119, 20)
        Me.cboRegime.TabIndex = 131
        '
        'cboModSAT
        '
        Me.cboModSAT.Location = New System.Drawing.Point(88, 64)
        Me.cboModSAT.Name = "cboModSAT"
        Me.cboModSAT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboModSAT.Properties.Items.AddRange(New Object() {"", "DIMEP", "BEMATECHDLL", "ELGIN", "ELGIN 2", "TANCA", "GERTEC", "EASYS", "EPSON", "SWEDA", "CONTROLID", "CUSTOM"})
        Me.cboModSAT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboModSAT.Size = New System.Drawing.Size(185, 20)
        Me.cboModSAT.TabIndex = 4
        '
        'txtVersaoXml
        '
        Me.txtVersaoXml.EnterMoveNextControl = True
        Me.txtVersaoXml.Location = New System.Drawing.Point(337, 38)
        Me.txtVersaoXml.Name = "txtVersaoXml"
        Me.txtVersaoXml.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtVersaoXml.Properties.Items.AddRange(New Object() {"0.06", "0.07", "0.08"})
        Me.txtVersaoXml.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtVersaoXml.Size = New System.Drawing.Size(119, 20)
        Me.txtVersaoXml.TabIndex = 3
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(279, 41)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl6.TabIndex = 128
        Me.LabelControl6.Text = "Versão Xml"
        '
        'btnSatServ
        '
        Me.btnSatServ.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.btnSatServ.Location = New System.Drawing.Point(331, 104)
        Me.btnSatServ.Name = "btnSatServ"
        Me.btnSatServ.Size = New System.Drawing.Size(20, 20)
        Me.btnSatServ.TabIndex = 124
        '
        'txtCaminhoPastaSATServ
        '
        Me.txtCaminhoPastaSATServ.Location = New System.Drawing.Point(148, 104)
        Me.txtCaminhoPastaSATServ.Name = "txtCaminhoPastaSATServ"
        Me.txtCaminhoPastaSATServ.Size = New System.Drawing.Size(183, 20)
        Me.txtCaminhoPastaSATServ.TabIndex = 123
        '
        'btnSAT
        '
        Me.btnSAT.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.btnSAT.Location = New System.Drawing.Point(315, 38)
        Me.btnSAT.Name = "btnSAT"
        Me.btnSAT.Size = New System.Drawing.Size(20, 20)
        Me.btnSAT.TabIndex = 121
        '
        'txtPastaSAT
        '
        Me.txtPastaSAT.Location = New System.Drawing.Point(65, 38)
        Me.txtPastaSAT.Name = "txtPastaSAT"
        Me.txtPastaSAT.Size = New System.Drawing.Size(250, 20)
        Me.txtPastaSAT.TabIndex = 120
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(488, 5)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(110, 13)
        Me.LabelControl4.TabIndex = 38
        Me.LabelControl4.Text = "Tipo da Impressora"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.chkMensImpCupomSAT)
        Me.PanelControl2.Controls.Add(Me.btnNomePc)
        Me.PanelControl2.Controls.Add(Me.chkDireto)
        Me.PanelControl2.Controls.Add(Me.txtNomeImp)
        Me.PanelControl2.Controls.Add(Me.LabelControl5)
        Me.PanelControl2.Controls.Add(Me.btnSAT)
        Me.PanelControl2.Controls.Add(Label13)
        Me.PanelControl2.Controls.Add(Me.cboModeloImp)
        Me.PanelControl2.Controls.Add(Label40)
        Me.PanelControl2.Controls.Add(Me.btnAdd)
        Me.PanelControl2.Controls.Add(Me.txtComputador)
        Me.PanelControl2.Controls.Add(Me.txtPastaSAT)
        Me.PanelControl2.Controls.Add(Me.GridControl2)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.LabelControl53)
        Me.PanelControl2.Controls.Add(Me.txtNumCaixa)
        Me.PanelControl2.Controls.Add(Me.btnDelete)
        Me.PanelControl2.Location = New System.Drawing.Point(474, 12)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(522, 210)
        Me.PanelControl2.TabIndex = 37
        '
        'chkMensImpCupomSAT
        '
        Me.chkMensImpCupomSAT.Location = New System.Drawing.Point(294, 64)
        Me.chkMensImpCupomSAT.Name = "chkMensImpCupomSAT"
        Me.chkMensImpCupomSAT.Properties.Caption = "Mens. Imp. Cupom?"
        Me.chkMensImpCupomSAT.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkMensImpCupomSAT.Size = New System.Drawing.Size(116, 19)
        Me.chkMensImpCupomSAT.TabIndex = 127
        '
        'btnNomePc
        '
        Me.btnNomePc.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.btnNomePc.Location = New System.Drawing.Point(315, 12)
        Me.btnNomePc.Name = "btnNomePc"
        Me.btnNomePc.Size = New System.Drawing.Size(20, 20)
        Me.btnNomePc.TabIndex = 126
        '
        'chkDireto
        '
        Me.chkDireto.Location = New System.Drawing.Point(212, 65)
        Me.chkDireto.Name = "chkDireto"
        Me.chkDireto.Properties.Caption = "Imp. Direto"
        Me.chkDireto.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkDireto.Size = New System.Drawing.Size(75, 19)
        Me.chkDireto.TabIndex = 125
        '
        'txtNomeImp
        '
        Me.txtNomeImp.Location = New System.Drawing.Point(65, 64)
        Me.txtNomeImp.Name = "txtNomeImp"
        Me.txtNomeImp.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtNomeImp.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtNomeImp.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNomeImp.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNomeImp.Size = New System.Drawing.Size(141, 20)
        Me.txtNomeImp.TabIndex = 124
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(7, 67)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl5.TabIndex = 123
        Me.LabelControl5.Text = "Nome Imp."
        '
        'cboModeloImp
        '
        Me.cboModeloImp.EnterMoveNextControl = True
        Me.cboModeloImp.Location = New System.Drawing.Point(416, 38)
        Me.cboModeloImp.Name = "cboModeloImp"
        Me.cboModeloImp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboModeloImp.Properties.Items.AddRange(New Object() {"", "TERMICA", "TERMICA MARGEM", "MP-4200 TH", "DARUMA", "EPSON", "NORMAL", "ESC/POS BEMATECH", "ESC/POS DARUMA", "ESC/POS EPSON"})
        Me.cboModeloImp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboModeloImp.Size = New System.Drawing.Size(101, 20)
        Me.cboModeloImp.TabIndex = 117
        '
        'btnDelete
        '
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnDelete.Image = Global.Nano.My.Resources.Resources.Remove_Item
        Me.btnDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(2, 187)
        Me.btnDelete.LookAndFeel.SkinName = "Money Twins"
        Me.btnDelete.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(518, 21)
        Me.btnDelete.TabIndex = 32
        Me.btnDelete.Text = "Excluir Item(ns)"
        '
        'frmConfigSAT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 463)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConfigSAT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuração SAT"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsConfig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbConfig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbComp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCNPJ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumSerie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumCaixa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAssinatura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComputador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cboRegime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboModSAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVersaoXml.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCaminhoPastaSATServ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPastaSAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.chkMensImpCupomSAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDireto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomeImp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboModeloImp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnExclui As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtIE As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl56 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCNPJ As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl57 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumSerie As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumCaixa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl53 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAssinatura As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtComputador As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dsConfig As System.Data.DataSet
    Friend WithEvents tbConfig As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents tbComp As System.Data.DataTable
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents colComputador As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumCaixa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCnpj As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumSerie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssinatura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtAlt As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboModeloImp As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnSAT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPastaSAT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNomeImp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colModeloImpSAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNomeImpSAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fbdOpen As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents colCaminhoPastaSATServ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSatServ As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCaminhoPastaSATServ As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colCaminhoPastaSAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkDireto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents colImpDiretoSAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnNomePc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtVersaoXml As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colVersaoXmlSAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkMensImpCupomSAT As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents colMensImpCupomSAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cboModSAT As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents colModeloSAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents cboRegime As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents colRegime As DevExpress.XtraGrid.Columns.GridColumn
End Class
