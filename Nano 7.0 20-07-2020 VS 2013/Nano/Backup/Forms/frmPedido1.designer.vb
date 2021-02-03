<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedido1
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
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedido1))
        Me.colOk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkAcompanhamento = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colOk2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkProduto = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colOk3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkSabor = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colOk1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkRecheio = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnCancelar = New DevExpress.XtraBars.BarButtonItem
        Me.btnOk = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.btnSuco = New DevExpress.XtraBars.BarButtonItem
        Me.btnVitaminas = New DevExpress.XtraBars.BarButtonItem
        Me.btnAgua = New DevExpress.XtraBars.BarButtonItem
        Me.btnBebidas = New DevExpress.XtraEditors.DropDownButton
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsProd = New System.Data.DataSet
        Me.tbProd = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.tbRecheio = New System.Data.DataTable
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.tbProduto = New System.Data.DataTable
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.tbSabor = New System.Data.DataTable
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.grd3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAcompanhamentos = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.btnLanches = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.btnSobremesa = New DevExpress.XtraEditors.SimpleButton
        Me.btnSaladas = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colProduto2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtProdutos = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.grpSabor = New DevExpress.XtraEditors.GroupControl
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl
        Me.grd4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colProduto3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtSabor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.grpRecheio = New DevExpress.XtraEditors.GroupControl
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.grd2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colProduto1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtRecheios = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtValorTotal = New Campos.NanoCampo
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtAcrescimo = New Campos.NanoCampo
        Me.txtValor = New Campos.NanoCampo
        Me.txtQtd = New Campos.NanoCampo
        CType(Me.chkAcompanhamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSabor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRecheio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbRecheio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSabor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAcompanhamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.grpSabor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSabor.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSabor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpRecheio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRecheio.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecheios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.txtValorTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAcrescimo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colOk
        '
        Me.colOk.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colOk.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colOk.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colOk.AppearanceCell.Options.UseBackColor = True
        Me.colOk.Caption = "Selecionar"
        Me.colOk.ColumnEdit = Me.chkAcompanhamento
        Me.colOk.FieldName = "Ok"
        Me.colOk.Name = "colOk"
        Me.colOk.Visible = True
        Me.colOk.VisibleIndex = 0
        Me.colOk.Width = 100
        '
        'chkAcompanhamento
        '
        Me.chkAcompanhamento.AutoHeight = False
        Me.chkAcompanhamento.Name = "chkAcompanhamento"
        '
        'colOk2
        '
        Me.colOk2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colOk2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colOk2.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colOk2.AppearanceCell.Options.UseBackColor = True
        Me.colOk2.Caption = "Selecionar"
        Me.colOk2.ColumnEdit = Me.chkProduto
        Me.colOk2.FieldName = "Ok"
        Me.colOk2.Name = "colOk2"
        Me.colOk2.Visible = True
        Me.colOk2.VisibleIndex = 0
        Me.colOk2.Width = 87
        '
        'chkProduto
        '
        Me.chkProduto.AutoHeight = False
        Me.chkProduto.Name = "chkProduto"
        '
        'colOk3
        '
        Me.colOk3.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colOk3.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colOk3.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colOk3.AppearanceCell.Options.UseBackColor = True
        Me.colOk3.Caption = "Selecionar"
        Me.colOk3.ColumnEdit = Me.chkSabor
        Me.colOk3.FieldName = "Ok"
        Me.colOk3.Name = "colOk3"
        Me.colOk3.Visible = True
        Me.colOk3.VisibleIndex = 0
        Me.colOk3.Width = 100
        '
        'chkSabor
        '
        Me.chkSabor.AutoHeight = False
        Me.chkSabor.Name = "chkSabor"
        '
        'colOk1
        '
        Me.colOk1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colOk1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colOk1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.colOk1.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colOk1.AppearanceCell.Options.UseBackColor = True
        Me.colOk1.AppearanceCell.Options.UseFont = True
        Me.colOk1.Caption = "Selecionar"
        Me.colOk1.ColumnEdit = Me.chkRecheio
        Me.colOk1.FieldName = "Ok"
        Me.colOk1.Name = "colOk1"
        Me.colOk1.Visible = True
        Me.colOk1.VisibleIndex = 0
        Me.colOk1.Width = 100
        '
        'chkRecheio
        '
        Me.chkRecheio.AutoHeight = False
        Me.chkRecheio.Name = "chkRecheio"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.picLogo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(283, 181)
        Me.Panel1.TabIndex = 11
        '
        'picLogo
        '
        Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picLogo.ImageLocation = ""
        Me.picLogo.Location = New System.Drawing.Point(5, 6)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(269, 167)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.btnCancelar, Me.btnOk, Me.btnSuco, Me.btnVitaminas, Me.btnAgua, Me.btnFechar})
        Me.BarManager1.MaxItemId = 7
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnCancelar), New DevExpress.XtraBars.LinkPersistInfo(Me.btnOk), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFechar)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.MultiLine = True
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Caption = "Cancelar"
        Me.btnCancelar.Glyph = Global.Nano.My.Resources.Resources.cancel
        Me.btnCancelar.Id = 1
        Me.btnCancelar.Name = "btnCancelar"
        '
        'btnOk
        '
        Me.btnOk.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnOk.Caption = "Ok"
        Me.btnOk.Glyph = Global.Nano.My.Resources.Resources.apply50
        Me.btnOk.Id = 2
        Me.btnOk.Name = "btnOk"
        '
        'btnFechar
        '
        Me.btnFechar.Caption = "Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar50
        Me.btnFechar.Id = 6
        Me.btnFechar.Name = "btnFechar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "OK"
        Me.BarButtonItem1.Glyph = Global.Nano.My.Resources.Resources.apply50
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'btnSuco
        '
        Me.btnSuco.Caption = "&Sucos"
        Me.btnSuco.Glyph = Global.Nano.My.Resources.Resources.Copo_40
        Me.btnSuco.Id = 3
        Me.btnSuco.Name = "btnSuco"
        '
        'btnVitaminas
        '
        Me.btnVitaminas.Caption = "&Vitaminas"
        Me.btnVitaminas.Glyph = Global.Nano.My.Resources.Resources.Copo_40
        Me.btnVitaminas.Id = 4
        Me.btnVitaminas.Name = "btnVitaminas"
        '
        'btnAgua
        '
        Me.btnAgua.Caption = "&Água"
        Me.btnAgua.Glyph = Global.Nano.My.Resources.Resources.Copo_40
        Me.btnAgua.Id = 5
        Me.btnAgua.Name = "btnAgua"
        '
        'btnBebidas
        '
        Me.btnBebidas.Appearance.Font = New System.Drawing.Font("Lucida Calligraphy", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBebidas.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnBebidas.Appearance.Options.UseFont = True
        Me.btnBebidas.Appearance.Options.UseForeColor = True
        Me.btnBebidas.DropDownControl = Me.PopupMenu1
        Me.btnBebidas.Image = Global.Nano.My.Resources.Resources.Copo_40
        Me.btnBebidas.Location = New System.Drawing.Point(7, 138)
        Me.btnBebidas.Name = "btnBebidas"
        Me.BarManager1.SetPopupContextMenu(Me.btnBebidas, Me.PopupMenu1)
        Me.btnBebidas.Size = New System.Drawing.Size(229, 68)
        Me.btnBebidas.TabIndex = 1
        Me.btnBebidas.Text = "Bebidas"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSuco), New DevExpress.XtraBars.LinkPersistInfo(Me.btnVitaminas), New DevExpress.XtraBars.LinkPersistInfo(Me.btnAgua)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbProd"
        Me.GridControl1.DataSource = Me.dsProd
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 26)
        Me.GridControl1.MainView = Me.grd3
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkAcompanhamento, Me.txtAcompanhamentos})
        Me.GridControl1.Size = New System.Drawing.Size(385, 167)
        Me.GridControl1.TabIndex = 16
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd3})
        '
        'dsProd
        '
        Me.dsProd.DataSetName = "NewDataSet"
        Me.dsProd.Tables.AddRange(New System.Data.DataTable() {Me.tbProd, Me.tbRecheio, Me.tbProduto, Me.tbSabor})
        '
        'tbProd
        '
        Me.tbProd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2})
        Me.tbProd.TableName = "tbProd"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Ok"
        Me.DataColumn1.DataType = GetType(Boolean)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Produto"
        '
        'tbRecheio
        '
        Me.tbRecheio.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn3, Me.DataColumn4})
        Me.tbRecheio.TableName = "tbRecheio"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Ok"
        Me.DataColumn3.DataType = GetType(Boolean)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Produto"
        '
        'tbProduto
        '
        Me.tbProduto.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn5, Me.DataColumn6})
        Me.tbProduto.TableName = "tbProduto"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Ok"
        Me.DataColumn5.DataType = GetType(Boolean)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Produto"
        '
        'tbSabor
        '
        Me.tbSabor.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn7, Me.DataColumn8})
        Me.tbSabor.TableName = "tbSabor"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Ok"
        Me.DataColumn7.DataType = GetType(Boolean)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Produto"
        '
        'grd3
        '
        Me.grd3.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.grd3.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grd3.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd3.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grd3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.grd3.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grd3.Appearance.Preview.ForeColor = System.Drawing.Color.Black
        Me.grd3.Appearance.Preview.Options.UseForeColor = True
        Me.grd3.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd3.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grd3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOk, Me.colProduto})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition1.Appearance.Options.HighPriority = True
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colOk
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        Me.grd3.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.grd3.GridControl = Me.GridControl1
        Me.grd3.Name = "grd3"
        Me.grd3.OptionsView.ShowGroupPanel = False
        '
        'colProduto
        '
        Me.colProduto.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colProduto.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colProduto.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.colProduto.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colProduto.AppearanceCell.Options.UseBackColor = True
        Me.colProduto.AppearanceCell.Options.UseFont = True
        Me.colProduto.Caption = "Produto"
        Me.colProduto.ColumnEdit = Me.txtAcompanhamentos
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 1
        Me.colProduto.Width = 264
        '
        'txtAcompanhamentos
        '
        Me.txtAcompanhamentos.AutoHeight = False
        Me.txtAcompanhamentos.Name = "txtAcompanhamentos"
        '
        'btnLanches
        '
        Me.btnLanches.Appearance.Font = New System.Drawing.Font("Lucida Calligraphy", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLanches.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnLanches.Appearance.Options.UseFont = True
        Me.btnLanches.Appearance.Options.UseForeColor = True
        Me.btnLanches.Image = Global.Nano.My.Resources.Resources.lanche
        Me.btnLanches.Location = New System.Drawing.Point(7, 46)
        Me.btnLanches.Name = "btnLanches"
        Me.btnLanches.Size = New System.Drawing.Size(229, 68)
        Me.btnLanches.TabIndex = 17
        Me.btnLanches.Text = "Lanches"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GroupControl2)
        Me.PanelControl1.Controls.Add(Me.Panel1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(283, 602)
        Me.PanelControl1.TabIndex = 18
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.btnBebidas)
        Me.GroupControl2.Controls.Add(Me.btnLanches)
        Me.GroupControl2.Controls.Add(Me.btnSobremesa)
        Me.GroupControl2.Controls.Add(Me.btnSaladas)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 181)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(283, 421)
        Me.GroupControl2.TabIndex = 20
        Me.GroupControl2.Text = "OPÇÕES"
        '
        'btnSobremesa
        '
        Me.btnSobremesa.Appearance.Font = New System.Drawing.Font("Lucida Calligraphy", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSobremesa.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnSobremesa.Appearance.Options.UseFont = True
        Me.btnSobremesa.Appearance.Options.UseForeColor = True
        Me.btnSobremesa.Image = Global.Nano.My.Resources.Resources.sorvete
        Me.btnSobremesa.Location = New System.Drawing.Point(7, 316)
        Me.btnSobremesa.Name = "btnSobremesa"
        Me.btnSobremesa.Size = New System.Drawing.Size(229, 68)
        Me.btnSobremesa.TabIndex = 21
        Me.btnSobremesa.Text = "Sobremesas"
        '
        'btnSaladas
        '
        Me.btnSaladas.Appearance.Font = New System.Drawing.Font("Lucida Calligraphy", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaladas.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnSaladas.Appearance.Options.UseFont = True
        Me.btnSaladas.Appearance.Options.UseForeColor = True
        Me.btnSaladas.Image = Global.Nano.My.Resources.Resources.salada40
        Me.btnSaladas.Location = New System.Drawing.Point(7, 228)
        Me.btnSaladas.Name = "btnSaladas"
        Me.btnSaladas.Size = New System.Drawing.Size(229, 68)
        Me.btnSaladas.TabIndex = 20
        Me.btnSaladas.Text = "Saladas"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.GridControl3)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl1.Location = New System.Drawing.Point(283, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(336, 531)
        Me.GroupControl1.TabIndex = 19
        Me.GroupControl1.Text = "PRODUTOS"
        '
        'GridControl3
        '
        Me.GridControl3.DataMember = "tbProduto"
        Me.GridControl3.DataSource = Me.dsProd
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.EmbeddedNavigator.Name = ""
        Me.GridControl3.Location = New System.Drawing.Point(2, 26)
        Me.GridControl3.MainView = Me.grd1
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkProduto, Me.txtProdutos})
        Me.GridControl3.Size = New System.Drawing.Size(332, 503)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'grd1
        '
        Me.grd1.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.grd1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grd1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grd1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.grd1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grd1.Appearance.Preview.ForeColor = System.Drawing.Color.Black
        Me.grd1.Appearance.Preview.Options.UseForeColor = True
        Me.grd1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOk2, Me.colProduto2})
        StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition4.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition4.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition4.Appearance.Options.HighPriority = True
        StyleFormatCondition4.Appearance.Options.UseBackColor = True
        StyleFormatCondition4.ApplyToRow = True
        StyleFormatCondition4.Column = Me.colOk2
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition4.Value1 = True
        Me.grd1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition4})
        Me.grd1.GridControl = Me.GridControl3
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colProduto2
        '
        Me.colProduto2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colProduto2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colProduto2.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.colProduto2.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colProduto2.AppearanceCell.Options.UseBackColor = True
        Me.colProduto2.AppearanceCell.Options.UseFont = True
        Me.colProduto2.Caption = "Produto"
        Me.colProduto2.ColumnEdit = Me.txtProdutos
        Me.colProduto2.FieldName = "Produto"
        Me.colProduto2.Name = "colProduto2"
        Me.colProduto2.OptionsColumn.ReadOnly = True
        Me.colProduto2.Visible = True
        Me.colProduto2.VisibleIndex = 1
        Me.colProduto2.Width = 224
        '
        'txtProdutos
        '
        Me.txtProdutos.AutoHeight = False
        Me.txtProdutos.Name = "txtProdutos"
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.Controls.Add(Me.GridControl1)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 336)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(389, 195)
        Me.GroupControl3.TabIndex = 20
        Me.GroupControl3.Text = "COMPLEMENTOS"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.GroupControl3)
        Me.PanelControl2.Controls.Add(Me.grpSabor)
        Me.PanelControl2.Controls.Add(Me.grpRecheio)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(619, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(389, 531)
        Me.PanelControl2.TabIndex = 21
        '
        'grpSabor
        '
        Me.grpSabor.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.grpSabor.AppearanceCaption.Options.UseFont = True
        Me.grpSabor.Controls.Add(Me.GridControl4)
        Me.grpSabor.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpSabor.Location = New System.Drawing.Point(0, 191)
        Me.grpSabor.Name = "grpSabor"
        Me.grpSabor.Size = New System.Drawing.Size(389, 145)
        Me.grpSabor.TabIndex = 22
        Me.grpSabor.Text = "SABOR"
        '
        'GridControl4
        '
        Me.GridControl4.DataMember = "tbSabor"
        Me.GridControl4.DataSource = Me.dsProd
        Me.GridControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl4.EmbeddedNavigator.Name = ""
        Me.GridControl4.Location = New System.Drawing.Point(2, 26)
        Me.GridControl4.MainView = Me.grd4
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkSabor, Me.txtSabor})
        Me.GridControl4.Size = New System.Drawing.Size(385, 117)
        Me.GridControl4.TabIndex = 16
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd4})
        '
        'grd4
        '
        Me.grd4.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.grd4.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grd4.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd4.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grd4.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.grd4.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grd4.Appearance.Preview.ForeColor = System.Drawing.Color.Black
        Me.grd4.Appearance.Preview.Options.UseForeColor = True
        Me.grd4.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd4.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grd4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOk3, Me.colProduto3})
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition2.Appearance.Options.HighPriority = True
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colOk3
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = True
        Me.grd4.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
        Me.grd4.GridControl = Me.GridControl4
        Me.grd4.Name = "grd4"
        Me.grd4.OptionsView.ShowGroupPanel = False
        '
        'colProduto3
        '
        Me.colProduto3.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colProduto3.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colProduto3.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.colProduto3.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colProduto3.AppearanceCell.Options.UseBackColor = True
        Me.colProduto3.AppearanceCell.Options.UseFont = True
        Me.colProduto3.Caption = "Produto"
        Me.colProduto3.ColumnEdit = Me.txtSabor
        Me.colProduto3.FieldName = "Produto"
        Me.colProduto3.Name = "colProduto3"
        Me.colProduto3.OptionsColumn.ReadOnly = True
        Me.colProduto3.Visible = True
        Me.colProduto3.VisibleIndex = 1
        Me.colProduto3.Width = 264
        '
        'txtSabor
        '
        Me.txtSabor.AutoHeight = False
        Me.txtSabor.Name = "txtSabor"
        '
        'grpRecheio
        '
        Me.grpRecheio.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.grpRecheio.AppearanceCaption.Options.UseFont = True
        Me.grpRecheio.Controls.Add(Me.GridControl2)
        Me.grpRecheio.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpRecheio.Location = New System.Drawing.Point(0, 0)
        Me.grpRecheio.Name = "grpRecheio"
        Me.grpRecheio.Size = New System.Drawing.Size(389, 191)
        Me.grpRecheio.TabIndex = 21
        Me.grpRecheio.Text = "RECHEIOS"
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "tbRecheio"
        Me.GridControl2.DataSource = Me.dsProd
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(2, 26)
        Me.GridControl2.MainView = Me.grd2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkRecheio, Me.txtRecheios})
        Me.GridControl2.Size = New System.Drawing.Size(385, 163)
        Me.GridControl2.TabIndex = 16
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd2})
        '
        'grd2
        '
        Me.grd2.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.grd2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grd2.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grd2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.grd2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grd2.Appearance.Preview.ForeColor = System.Drawing.Color.Black
        Me.grd2.Appearance.Preview.Options.UseForeColor = True
        Me.grd2.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grd2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOk1, Me.colProduto1})
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition3.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition3.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition3.Appearance.Options.HighPriority = True
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.colOk1
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = True
        Me.grd2.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition3})
        Me.grd2.GridControl = Me.GridControl2
        Me.grd2.Name = "grd2"
        Me.grd2.OptionsView.ShowGroupPanel = False
        '
        'colProduto1
        '
        Me.colProduto1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colProduto1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colProduto1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.colProduto1.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colProduto1.AppearanceCell.Options.UseBackColor = True
        Me.colProduto1.AppearanceCell.Options.UseFont = True
        Me.colProduto1.Caption = "Produto"
        Me.colProduto1.ColumnEdit = Me.txtRecheios
        Me.colProduto1.FieldName = "Produto"
        Me.colProduto1.Name = "colProduto1"
        Me.colProduto1.OptionsColumn.ReadOnly = True
        Me.colProduto1.Visible = True
        Me.colProduto1.VisibleIndex = 1
        Me.colProduto1.Width = 264
        '
        'txtRecheios
        '
        Me.txtRecheios.AutoHeight = False
        Me.txtRecheios.Name = "txtRecheios"
        '
        'GroupControl4
        '
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 40.0!)
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl4.Controls.Add(Me.LabelControl4)
        Me.GroupControl4.Controls.Add(Me.LabelControl2)
        Me.GroupControl4.Controls.Add(Me.LabelControl3)
        Me.GroupControl4.Controls.Add(Me.txtValorTotal)
        Me.GroupControl4.Controls.Add(Me.LabelControl1)
        Me.GroupControl4.Controls.Add(Me.txtAcrescimo)
        Me.GroupControl4.Controls.Add(Me.txtValor)
        Me.GroupControl4.Controls.Add(Me.txtQtd)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl4.Location = New System.Drawing.Point(283, 531)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(725, 71)
        Me.GroupControl4.TabIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(570, 5)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(137, 23)
        Me.LabelControl4.TabIndex = 24
        Me.LabelControl4.Text = "Valor Total R$"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(18, 5)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(46, 23)
        Me.LabelControl2.TabIndex = 16
        Me.LabelControl2.Text = "Qtde"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(385, 5)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(130, 23)
        Me.LabelControl3.TabIndex = 23
        Me.LabelControl3.Text = "Acrescimo R$"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorTotal.CasasDecimais = 2
        Me.txtValorTotal.EnterMoveNextControl = True
        Me.txtValorTotal.Location = New System.Drawing.Point(570, 28)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Numerico = True
        Me.txtValorTotal.Properties.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtValorTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotal.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtValorTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtValorTotal.Properties.Appearance.Options.UseFont = True
        Me.txtValorTotal.Properties.Appearance.Options.UseForeColor = True
        Me.txtValorTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValorTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValorTotal.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValorTotal.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtValorTotal.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValorTotal.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtValorTotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtValorTotal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtValorTotal.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtValorTotal.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtValorTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txtValorTotal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValorTotal.Properties.ReadOnly = True
        Me.txtValorTotal.Size = New System.Drawing.Size(150, 37)
        Me.txtValorTotal.TabIndex = 5
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(203, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(120, 23)
        Me.LabelControl1.TabIndex = 22
        Me.LabelControl1.Text = "Valor Un. R$"
        '
        'txtAcrescimo
        '
        Me.txtAcrescimo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAcrescimo.CasasDecimais = 2
        Me.txtAcrescimo.EnterMoveNextControl = True
        Me.txtAcrescimo.Location = New System.Drawing.Point(385, 30)
        Me.txtAcrescimo.Name = "txtAcrescimo"
        Me.txtAcrescimo.Numerico = True
        Me.txtAcrescimo.Properties.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtAcrescimo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcrescimo.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtAcrescimo.Properties.Appearance.Options.UseBackColor = True
        Me.txtAcrescimo.Properties.Appearance.Options.UseFont = True
        Me.txtAcrescimo.Properties.Appearance.Options.UseForeColor = True
        Me.txtAcrescimo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAcrescimo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAcrescimo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAcrescimo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtAcrescimo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtAcrescimo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtAcrescimo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtAcrescimo.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtAcrescimo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtAcrescimo.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtAcrescimo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txtAcrescimo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAcrescimo.Size = New System.Drawing.Size(150, 37)
        Me.txtAcrescimo.TabIndex = 4
        '
        'txtValor
        '
        Me.txtValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValor.CasasDecimais = 2
        Me.txtValor.EnterMoveNextControl = True
        Me.txtValor.Location = New System.Drawing.Point(203, 30)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Numerico = True
        Me.txtValor.Properties.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtValor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtValor.Properties.Appearance.Options.UseBackColor = True
        Me.txtValor.Properties.Appearance.Options.UseFont = True
        Me.txtValor.Properties.Appearance.Options.UseForeColor = True
        Me.txtValor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValor.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValor.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtValor.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValor.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtValor.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtValor.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtValor.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtValor.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtValor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txtValor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValor.Size = New System.Drawing.Size(150, 37)
        Me.txtValor.TabIndex = 3
        '
        'txtQtd
        '
        Me.txtQtd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQtd.CasasDecimais = 0
        Me.txtQtd.EnterMoveNextControl = True
        Me.txtQtd.Location = New System.Drawing.Point(18, 30)
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.Numerico = True
        Me.txtQtd.Properties.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtQtd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtd.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtQtd.Properties.Appearance.Options.UseBackColor = True
        Me.txtQtd.Properties.Appearance.Options.UseFont = True
        Me.txtQtd.Properties.Appearance.Options.UseForeColor = True
        Me.txtQtd.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtd.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtd.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtd.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtQtd.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtd.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtQtd.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtQtd.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtQtd.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtQtd.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtQtd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txtQtd.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQtd.Size = New System.Drawing.Size(150, 37)
        Me.txtQtd.TabIndex = 2
        '
        'frmPedido1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPedido1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedido"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.chkAcompanhamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSabor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRecheio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbRecheio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSabor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAcompanhamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.grpSabor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSabor.ResumeLayout(False)
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSabor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpRecheio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRecheio.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecheios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.txtValorTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAcrescimo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnLanches As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaladas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSobremesa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOk As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dsProd As System.Data.DataSet
    Friend WithEvents tbProd As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents tbRecheio As System.Data.DataTable
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents colOk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grpRecheio As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOk1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btnBebidas As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents btnSuco As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVitaminas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAgua As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents tbProduto As System.Data.DataTable
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOk2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkProduto As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents chkRecheio As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtValorTotal As Campos.NanoCampo
    Friend WithEvents txtAcrescimo As Campos.NanoCampo
    Friend WithEvents txtValor As Campos.NanoCampo
    Friend WithEvents txtQtd As Campos.NanoCampo
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkAcompanhamento As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtProdutos As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtAcompanhamentos As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtRecheios As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents tbSabor As System.Data.DataTable
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents grpSabor As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOk3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkSabor As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colProduto3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtSabor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
