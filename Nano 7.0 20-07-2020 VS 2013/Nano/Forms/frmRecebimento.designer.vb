<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecebimento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecebimento))
        Me.dsRec = New System.Data.DataSet
        Me.tbRec = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtValor = New DevExpress.XtraEditors.TextEdit
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.btnCancelar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFormaPagamento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPagamento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoPedido = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEntrada = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtARec = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtRec = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtTroco = New DevExpress.XtraEditors.TextEdit
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cboPag = New DevExpress.XtraEditors.LookUpEdit
        Me.PagamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.txtVez = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtData = New DevExpress.XtraEditors.TextEdit
        Me.btnPar = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.dtData = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.PagamentoTableAdapter = New Nano.dsNanoCommerceTableAdapters.PagamentoTableAdapter
        CType(Me.dsRec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbRec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtARec.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRec.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtTroco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPag.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVez.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dsRec
        '
        Me.dsRec.DataSetName = "NewDataSet"
        Me.dsRec.Tables.AddRange(New System.Data.DataTable() {Me.tbRec})
        '
        'tbRec
        '
        Me.tbRec.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7})
        Me.tbRec.TableName = "tbRec"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "FormaPagamento"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Pagamento"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Valor"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Codigo"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Data"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "CodigoPedido"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Entrada"
        Me.DataColumn7.DataType = GetType(Boolean)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(9, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Forma Pagamento"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(362, 39)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Valor R$"
        '
        'txtValor
        '
        Me.txtValor.EnterMoveNextControl = True
        Me.txtValor.Location = New System.Drawing.Point(408, 35)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Properties.Appearance.Options.UseFont = True
        Me.txtValor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValor.Properties.MaxLength = 18
        Me.txtValor.Size = New System.Drawing.Size(111, 20)
        Me.txtValor.TabIndex = 2
        Me.txtValor.Tag = "Valor R$"
        '
        'btnOk
        '
        Me.btnOk.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Appearance.Options.UseFont = True
        Me.btnOk.Image = Global.Nano.My.Resources.Resources.apply
        Me.btnOk.Location = New System.Drawing.Point(236, 72)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(110, 33)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "&Adicionar"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnFechar, Me.btnDelete, Me.btnCancelar})
        Me.BarManager1.MaxItemId = 3
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnDelete, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCancelar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnDelete
        '
        Me.btnDelete.Caption = "&Excluir"
        Me.btnDelete.Glyph = Global.Nano.My.Resources.Resources.delete
        Me.btnDelete.Id = 1
        Me.btnDelete.Name = "btnDelete"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "F5 - &Concluir"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnFechar.Id = 0
        Me.btnFechar.Name = "btnFechar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Caption = "&Cancelar"
        Me.btnCancelar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnCancelar.Id = 2
        Me.btnCancelar.Name = "btnCancelar"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 110)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(348, 339)
        Me.GroupControl1.TabIndex = 7
        Me.GroupControl1.Text = "Valores Recebidos"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbRec"
        Me.GridControl1.DataSource = Me.dsRec
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 20)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(344, 317)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFormaPagamento, Me.colPagamento, Me.colValor, Me.colCodigo, Me.colData, Me.colCodigoPedido, Me.colEntrada})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colFormaPagamento
        '
        Me.colFormaPagamento.AppearanceCell.Options.UseTextOptions = True
        Me.colFormaPagamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFormaPagamento.Caption = "Forma Pag."
        Me.colFormaPagamento.FieldName = "FormaPagamento"
        Me.colFormaPagamento.Name = "colFormaPagamento"
        Me.colFormaPagamento.OptionsColumn.ReadOnly = True
        Me.colFormaPagamento.Visible = True
        Me.colFormaPagamento.VisibleIndex = 0
        Me.colFormaPagamento.Width = 99
        '
        'colPagamento
        '
        Me.colPagamento.AppearanceCell.Options.UseTextOptions = True
        Me.colPagamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPagamento.Caption = "Pagamento"
        Me.colPagamento.FieldName = "Pagamento"
        Me.colPagamento.Name = "colPagamento"
        Me.colPagamento.OptionsColumn.ReadOnly = True
        Me.colPagamento.Visible = True
        Me.colPagamento.VisibleIndex = 1
        Me.colPagamento.Width = 100
        '
        'colValor
        '
        Me.colValor.AppearanceCell.Options.UseTextOptions = True
        Me.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor.Caption = "Valor R$"
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.OptionsColumn.ReadOnly = True
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 2
        Me.colValor.Width = 84
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        '
        'colData
        '
        Me.colData.Caption = "Data"
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.OptionsColumn.ReadOnly = True
        '
        'colCodigoPedido
        '
        Me.colCodigoPedido.Caption = "CodigoPedido"
        Me.colCodigoPedido.FieldName = "CodigoPedido"
        Me.colCodigoPedido.Name = "colCodigoPedido"
        Me.colCodigoPedido.OptionsColumn.ReadOnly = True
        '
        'colEntrada
        '
        Me.colEntrada.Caption = "Ent."
        Me.colEntrada.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colEntrada.FieldName = "Entrada"
        Me.colEntrada.Name = "colEntrada"
        Me.colEntrada.OptionsColumn.ReadOnly = True
        Me.colEntrada.Width = 40
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(7, 53)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Properties.Appearance.BackColor = System.Drawing.Color.Blue
        Me.txtTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotal.Properties.Appearance.Options.UseFont = True
        Me.txtTotal.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotal.Properties.MaxLength = 18
        Me.txtTotal.Properties.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(164, 27)
        Me.txtTotal.TabIndex = 17
        Me.txtTotal.Tag = "Valor R$"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(8, 36)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(53, 16)
        Me.LabelControl5.TabIndex = 16
        Me.LabelControl5.Text = "Total R$"
        '
        'txtARec
        '
        Me.txtARec.Location = New System.Drawing.Point(8, 116)
        Me.txtARec.Name = "txtARec"
        Me.txtARec.Properties.Appearance.BackColor = System.Drawing.Color.Blue
        Me.txtARec.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtARec.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtARec.Properties.Appearance.Options.UseBackColor = True
        Me.txtARec.Properties.Appearance.Options.UseFont = True
        Me.txtARec.Properties.Appearance.Options.UseForeColor = True
        Me.txtARec.Properties.Appearance.Options.UseTextOptions = True
        Me.txtARec.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtARec.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtARec.Properties.MaxLength = 18
        Me.txtARec.Properties.ReadOnly = True
        Me.txtARec.Size = New System.Drawing.Size(163, 26)
        Me.txtARec.TabIndex = 19
        Me.txtARec.Tag = "Valor R$"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(9, 99)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(123, 16)
        Me.LabelControl6.TabIndex = 18
        Me.LabelControl6.Text = "Total a Receber R$"
        '
        'txtRec
        '
        Me.txtRec.Location = New System.Drawing.Point(8, 180)
        Me.txtRec.Name = "txtRec"
        Me.txtRec.Properties.Appearance.BackColor = System.Drawing.Color.Blue
        Me.txtRec.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRec.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtRec.Properties.Appearance.Options.UseBackColor = True
        Me.txtRec.Properties.Appearance.Options.UseFont = True
        Me.txtRec.Properties.Appearance.Options.UseForeColor = True
        Me.txtRec.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRec.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtRec.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRec.Properties.MaxLength = 18
        Me.txtRec.Properties.ReadOnly = True
        Me.txtRec.Size = New System.Drawing.Size(162, 26)
        Me.txtRec.TabIndex = 21
        Me.txtRec.Tag = "Valor R$"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(9, 163)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(116, 16)
        Me.LabelControl7.TabIndex = 20
        Me.LabelControl7.Text = "Total Recebido R$"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.txtTroco)
        Me.GroupControl2.Controls.Add(Me.txtRec)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.txtTotal)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.txtARec)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Location = New System.Drawing.Point(352, 110)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(175, 339)
        Me.GroupControl2.TabIndex = 22
        Me.GroupControl2.Text = "Valores Totais"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(9, 227)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(57, 16)
        Me.LabelControl4.TabIndex = 22
        Me.LabelControl4.Text = "Troco R$"
        '
        'txtTroco
        '
        Me.txtTroco.Location = New System.Drawing.Point(8, 244)
        Me.txtTroco.Name = "txtTroco"
        Me.txtTroco.Properties.Appearance.BackColor = System.Drawing.Color.Blue
        Me.txtTroco.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTroco.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtTroco.Properties.Appearance.Options.UseBackColor = True
        Me.txtTroco.Properties.Appearance.Options.UseFont = True
        Me.txtTroco.Properties.Appearance.Options.UseForeColor = True
        Me.txtTroco.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTroco.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTroco.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTroco.Properties.MaxLength = 18
        Me.txtTroco.Properties.ReadOnly = True
        Me.txtTroco.Size = New System.Drawing.Size(164, 27)
        Me.txtTroco.TabIndex = 23
        Me.txtTroco.Tag = "Valor R$"
        '
        'Timer1
        '
        '
        'cboPag
        '
        Me.cboPag.EnterMoveNextControl = True
        Me.cboPag.Location = New System.Drawing.Point(102, 9)
        Me.cboPag.Name = "cboPag"
        Me.cboPag.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPag.Properties.Appearance.Options.UseFont = True
        Me.cboPag.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPag.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPag.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 52, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descrição", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FormaPagamento", "Pagamento", 60), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Dias", "Nº Dias", 45, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desconto", "% Desc.", 45, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Prazo", "Cartão?", 33, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None)})
        Me.cboPag.Properties.DataSource = Me.PagamentoBindingSource
        Me.cboPag.Properties.DisplayMember = "Descricao"
        Me.cboPag.Properties.NullText = ""
        Me.cboPag.Properties.PopupWidth = 330
        Me.cboPag.Properties.ValueMember = "Descricao"
        Me.cboPag.Size = New System.Drawing.Size(244, 20)
        Me.cboPag.TabIndex = 0
        Me.cboPag.Tag = "Forma Pagamento"
        '
        'PagamentoBindingSource
        '
        Me.PagamentoBindingSource.DataMember = "Pagamento"
        Me.PagamentoBindingSource.DataSource = Me.DsNanoCommerce
        '
        'DsNanoCommerce
        '
        Me.DsNanoCommerce.DataSetName = "dsNanoCommerce"
        Me.DsNanoCommerce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtVez
        '
        Me.txtVez.EnterMoveNextControl = True
        Me.txtVez.Location = New System.Drawing.Point(236, 35)
        Me.txtVez.Name = "txtVez"
        Me.txtVez.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVez.Properties.Appearance.Options.UseFont = True
        Me.txtVez.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVez.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtVez.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVez.Properties.MaxLength = 2
        Me.txtVez.Size = New System.Drawing.Size(110, 20)
        Me.txtVez.TabIndex = 1
        Me.txtVez.Tag = "Vezes"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(202, 39)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl8.TabIndex = 25
        Me.LabelControl8.Text = "Vezes"
        '
        'txtData
        '
        Me.txtData.EnterMoveNextControl = True
        Me.txtData.Location = New System.Drawing.Point(102, 9)
        Me.txtData.Name = "txtData"
        Me.txtData.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.Properties.Appearance.Options.UseFont = True
        Me.txtData.Properties.Appearance.Options.UseTextOptions = True
        Me.txtData.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtData.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtData.Properties.MaxLength = 18
        Me.txtData.Size = New System.Drawing.Size(128, 20)
        Me.txtData.TabIndex = 26
        Me.txtData.Tag = ""
        '
        'btnPar
        '
        Me.btnPar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPar.Appearance.Options.UseFont = True
        Me.btnPar.Image = Global.Nano.My.Resources.Resources.cal_2
        Me.btnPar.Location = New System.Drawing.Point(408, 72)
        Me.btnPar.Name = "btnPar"
        Me.btnPar.Size = New System.Drawing.Size(111, 33)
        Me.btnPar.TabIndex = 4
        Me.btnPar.Text = "&Parcelado"
        '
        'PanelControl1
        '
        Me.PanelControl1.Location = New System.Drawing.Point(4, 61)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(537, 5)
        Me.PanelControl1.TabIndex = 27
        '
        'dtData
        '
        Me.dtData.EditValue = Nothing
        Me.dtData.Location = New System.Drawing.Point(408, 9)
        Me.dtData.Name = "dtData"
        Me.dtData.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtData.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtData.Size = New System.Drawing.Size(111, 20)
        Me.dtData.TabIndex = 28
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(379, 12)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl3.TabIndex = 29
        Me.LabelControl3.Text = "Data"
        '
        'PagamentoTableAdapter
        '
        Me.PagamentoTableAdapter.ClearBeforeFill = True
        '
        'frmRecebimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 487)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.dtData)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btnPar)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.txtVez)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.cboPag)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmRecebimento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recebimento"
        CType(Me.dsRec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbRec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtARec.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRec.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtTroco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPag.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVez.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtRec As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtARec As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cboPag As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtVez As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtData As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnPar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dsRec As System.Data.DataSet
    Friend WithEvents tbRec As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFormaPagamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoPedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents colEntrada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtData As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents PagamentoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagamentoTableAdapter As Nano.dsNanoCommerceTableAdapters.PagamentoTableAdapter
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTroco As DevExpress.XtraEditors.TextEdit
End Class
