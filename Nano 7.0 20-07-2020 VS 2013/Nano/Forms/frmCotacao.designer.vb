<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCotacao
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
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCotacao))
        Me.btnConsulta = New DevExpress.XtraEditors.LookUpEdit
        Me.lblCodPed = New DevExpress.XtraEditors.LabelControl
        Me.txtCodTab = New DevExpress.XtraEditors.TextEdit
        Me.txtNomePro = New DevExpress.XtraEditors.TextEdit
        Me.txtCodPro = New DevExpress.XtraEditors.ButtonEdit
        Me.btnAddFor = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsCusto = New System.Data.DataSet
        Me.tbCusto = New System.Data.DataTable
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoPeca = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtValor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.picImagem = New DevExpress.XtraEditors.PictureEdit
        Me.btnRemover = New DevExpress.XtraEditors.SimpleButton
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnVisualizar = New DevExpress.XtraBars.BarButtonItem
        Me.btnRelVenc = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.txtFor = New DevExpress.XtraEditors.ButtonEdit
        Me.dtData = New DevExpress.XtraEditors.DateEdit
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnAddProd = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Label4 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label8 = New System.Windows.Forms.Label
        CType(Me.btnConsulta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodTab.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomePro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodPro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCusto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCusto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.picImagem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(225, 15)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(45, 13)
        Label4.TabIndex = 121
        Label4.Text = "Produto"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(10, 17)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(59, 13)
        Label3.TabIndex = 120
        Label3.Text = "Cód. Prod."
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(9, 15)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(68, 13)
        Label2.TabIndex = 127
        Label2.Text = "Nome/Razão"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(860, 15)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(30, 13)
        Label8.TabIndex = 129
        Label8.Text = "Data"
        '
        'btnConsulta
        '
        Me.btnConsulta.EnterMoveNextControl = True
        Me.btnConsulta.Location = New System.Drawing.Point(202, 12)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsulta.Properties.Appearance.Options.UseFont = True
        Me.btnConsulta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, CType(resources.GetObject("btnConsulta.Properties.Buttons"), System.Drawing.Image), Nothing)})
        Me.btnConsulta.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Placa", "Placa", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modelo", "Modelo", 90, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cor", "Cor", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ano", "Ano", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NomeCliente", "Cliente", 150)})
        Me.btnConsulta.Properties.DisplayMember = "Placa"
        Me.btnConsulta.Properties.NullText = ""
        Me.btnConsulta.Properties.PopupWidth = 700
        Me.btnConsulta.Properties.ValueMember = "Placa"
        Me.btnConsulta.Size = New System.Drawing.Size(22, 21)
        Me.btnConsulta.TabIndex = 115
        '
        'lblCodPed
        '
        Me.lblCodPed.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodPed.Appearance.Options.UseFont = True
        Me.lblCodPed.Location = New System.Drawing.Point(12, 16)
        Me.lblCodPed.Name = "lblCodPed"
        Me.lblCodPed.Size = New System.Drawing.Size(62, 13)
        Me.lblCodPed.TabIndex = 114
        Me.lblCodPed.Text = "Nº Cotação"
        '
        'txtCodTab
        '
        Me.txtCodTab.Enabled = False
        Me.txtCodTab.EnterMoveNextControl = True
        Me.txtCodTab.Location = New System.Drawing.Point(80, 12)
        Me.txtCodTab.Name = "txtCodTab"
        Me.txtCodTab.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodTab.Properties.Appearance.Options.UseFont = True
        Me.txtCodTab.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodTab.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCodTab.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtCodTab.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodTab.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodTab.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCodTab.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtCodTab.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodTab.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCodTab.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCodTab.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCodTab.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCodTab.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodTab.Size = New System.Drawing.Size(123, 21)
        Me.txtCodTab.TabIndex = 113
        '
        'txtNomePro
        '
        Me.txtNomePro.EnterMoveNextControl = True
        Me.txtNomePro.Location = New System.Drawing.Point(276, 14)
        Me.txtNomePro.Name = "txtNomePro"
        Me.txtNomePro.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtNomePro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomePro.Properties.Appearance.Options.UseBackColor = True
        Me.txtNomePro.Properties.Appearance.Options.UseFont = True
        Me.txtNomePro.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtNomePro.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNomePro.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNomePro.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNomePro.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomePro.Properties.MaxLength = 149
        Me.txtNomePro.Size = New System.Drawing.Size(266, 20)
        Me.txtNomePro.TabIndex = 117
        Me.txtNomePro.Tag = "Produto"
        '
        'txtCodPro
        '
        Me.txtCodPro.EnterMoveNextControl = True
        Me.txtCodPro.Location = New System.Drawing.Point(80, 64)
        Me.txtCodPro.Name = "txtCodPro"
        Me.txtCodPro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPro.Properties.Appearance.Options.UseFont = True
        Me.txtCodPro.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtCodPro.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodPro.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCodPro.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodPro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, CType(resources.GetObject("txtCodPro.Properties.Buttons"), System.Drawing.Image), Nothing)})
        Me.txtCodPro.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodPro.Size = New System.Drawing.Size(144, 20)
        Me.txtCodPro.TabIndex = 116
        '
        'btnAddFor
        '
        Me.btnAddFor.Image = CType(resources.GetObject("btnAddFor.Image"), System.Drawing.Image)
        Me.btnAddFor.Location = New System.Drawing.Point(338, 38)
        Me.btnAddFor.Name = "btnAddFor"
        Me.btnAddFor.Size = New System.Drawing.Size(100, 23)
        Me.btnAddFor.TabIndex = 119
        Me.btnAddFor.Text = "Adicionar"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataMember = "tbCusto"
        Me.GridControl1.DataSource = Me.dsCusto
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 20)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtValor})
        Me.GridControl1.Size = New System.Drawing.Size(1004, 454)
        Me.GridControl1.TabIndex = 123
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsCusto
        '
        Me.dsCusto.DataSetName = "NewDataSet"
        Me.dsCusto.Tables.AddRange(New System.Data.DataTable() {Me.tbCusto})
        '
        'tbCusto
        '
        Me.tbCusto.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn2, Me.DataColumn1, Me.DataColumn3, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7})
        Me.tbCusto.TableName = "tbCusto"
        '
        'DataColumn2
        '
        Me.DataColumn2.Caption = "CodProd"
        Me.DataColumn2.ColumnName = "CodProd"
        '
        'DataColumn1
        '
        Me.DataColumn1.Caption = "Produto"
        Me.DataColumn1.ColumnName = "Produto"
        '
        'DataColumn3
        '
        Me.DataColumn3.Caption = "CodFor"
        Me.DataColumn3.ColumnName = "CodFor"
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "Valor"
        Me.DataColumn5.ColumnName = "Valor"
        '
        'DataColumn6
        '
        Me.DataColumn6.Caption = "Codigo"
        Me.DataColumn6.ColumnName = "Codigo"
        '
        'DataColumn7
        '
        Me.DataColumn7.Caption = "CodigoPeca"
        Me.DataColumn7.ColumnName = "CodigoPeca"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodProd, Me.colProduto, Me.colCodigo, Me.colCodigoPeca})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ColumnAutoWidth = False
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodProd
        '
        Me.colCodProd.Caption = "CodProd"
        Me.colCodProd.FieldName = "CodProd"
        Me.colCodProd.Name = "colCodProd"
        '
        'colProduto
        '
        Me.colProduto.Caption = "Produto"
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 0
        Me.colProduto.Width = 184
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        '
        'colCodigoPeca
        '
        Me.colCodigoPeca.Caption = "Código Peça"
        Me.colCodigoPeca.FieldName = "CodigoPeca"
        Me.colCodigoPeca.Name = "colCodigoPeca"
        '
        'txtValor
        '
        Me.txtValor.AutoHeight = False
        Me.txtValor.Name = "txtValor"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.picImagem)
        Me.GroupControl1.Controls.Add(Me.btnRemover)
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(0, 120)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1008, 500)
        Me.GroupControl1.TabIndex = 124
        '
        'picImagem
        '
        Me.picImagem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picImagem.EditValue = CType(resources.GetObject("picImagem.EditValue"), Object)
        Me.picImagem.Location = New System.Drawing.Point(2, 20)
        Me.picImagem.Name = "picImagem"
        Me.picImagem.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.picImagem.Size = New System.Drawing.Size(1004, 455)
        Me.picImagem.TabIndex = 125
        '
        'btnRemover
        '
        Me.btnRemover.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnRemover.Image = Global.Nano.My.Resources.Resources.Remove_Item
        Me.btnRemover.Location = New System.Drawing.Point(2, 475)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(1004, 23)
        Me.btnRemover.TabIndex = 124
        Me.btnRemover.Text = "&Remover"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnFechar, Me.btnSalvar, Me.btnVisualizar, Me.btnLimpar, Me.btnRelVenc})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnVisualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnRelVenc, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.btnVisualizar.Caption = "Visualizar"
        Me.btnVisualizar.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnVisualizar.Id = 2
        Me.btnVisualizar.Name = "btnVisualizar"
        '
        'btnRelVenc
        '
        Me.btnRelVenc.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.btnRelVenc.Caption = "Vencedores"
        Me.btnRelVenc.Glyph = CType(resources.GetObject("btnRelVenc.Glyph"), System.Drawing.Image)
        Me.btnRelVenc.Id = 4
        Me.btnRelVenc.Name = "btnRelVenc"
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar.Caption = "Salvar"
        Me.btnSalvar.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvar.Id = 1
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnLimpar
        '
        Me.btnLimpar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnLimpar.Caption = "Limpar"
        Me.btnLimpar.Glyph = Global.Nano.My.Resources.Resources.Comando_Limpar_32x32
        Me.btnLimpar.Id = 3
        Me.btnLimpar.Name = "btnLimpar"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 0
        Me.btnFechar.Name = "btnFechar"
        '
        'txtFor
        '
        Me.txtFor.EnterMoveNextControl = True
        Me.txtFor.Location = New System.Drawing.Point(83, 12)
        Me.txtFor.Name = "txtFor"
        Me.txtFor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFor.Properties.Appearance.Options.UseFont = True
        Me.txtFor.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtFor.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtFor.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtFor.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtFor.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtFor.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFor.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtFor.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtFor.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtFor.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtFor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, CType(resources.GetObject("txtFor.Properties.Buttons"), System.Drawing.Image), Nothing)})
        Me.txtFor.Properties.ReadOnly = True
        Me.txtFor.Size = New System.Drawing.Size(355, 20)
        Me.txtFor.TabIndex = 126
        '
        'dtData
        '
        Me.dtData.EditValue = ""
        Me.dtData.EnterMoveNextControl = True
        Me.dtData.Location = New System.Drawing.Point(896, 13)
        Me.dtData.Name = "dtData"
        Me.dtData.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtData.Properties.Appearance.Options.UseFont = True
        Me.dtData.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.dtData.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.dtData.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.dtData.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.dtData.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtData.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtData.Size = New System.Drawing.Size(100, 20)
        Me.dtData.TabIndex = 128
        Me.dtData.Tag = "Data"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtNomePro)
        Me.PanelControl1.Controls.Add(Me.btnAddProd)
        Me.PanelControl1.Controls.Add(Label3)
        Me.PanelControl1.Controls.Add(Label4)
        Me.PanelControl1.Location = New System.Drawing.Point(5, 50)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(547, 66)
        Me.PanelControl1.TabIndex = 130
        '
        'btnAddProd
        '
        Me.btnAddProd.Image = CType(resources.GetObject("btnAddProd.Image"), System.Drawing.Image)
        Me.btnAddProd.Location = New System.Drawing.Point(442, 38)
        Me.btnAddProd.Name = "btnAddProd"
        Me.btnAddProd.Size = New System.Drawing.Size(100, 23)
        Me.btnAddProd.TabIndex = 132
        Me.btnAddProd.Text = "Adicionar"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(13, 41)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(57, 14)
        Me.LabelControl4.TabIndex = 131
        Me.LabelControl4.Text = "Produtos"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(567, 41)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(81, 14)
        Me.LabelControl1.TabIndex = 134
        Me.LabelControl1.Text = "Fornecedores"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.txtFor)
        Me.PanelControl2.Controls.Add(Me.btnAddFor)
        Me.PanelControl2.Controls.Add(Label2)
        Me.PanelControl2.Location = New System.Drawing.Point(558, 50)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(448, 66)
        Me.PanelControl2.TabIndex = 133
        '
        'frmCotacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtCodPro)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.dtData)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.lblCodPed)
        Me.Controls.Add(Me.txtCodTab)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCotacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro Cotação"
        CType(Me.btnConsulta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodTab.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomePro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodPro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCusto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCusto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.picImagem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConsulta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblCodPed As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodTab As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNomePro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodPro As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents btnAddFor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents txtFor As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents dtData As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dsCusto As System.Data.DataSet
    Friend WithEvents tbCusto As System.Data.DataTable
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents colCodProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents txtValor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRemover As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddProd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colCodigoPeca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnVisualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents picImagem As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnRelVenc As DevExpress.XtraBars.BarButtonItem
End Class
