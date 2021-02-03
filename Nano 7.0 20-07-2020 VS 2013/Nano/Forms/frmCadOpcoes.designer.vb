<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadOpcoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadOpcoes))
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.ProdOpcBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdOpcTableAdapter = New Nano.dsNanoCommerceTableAdapters.ProdOpcTableAdapter
        Me.ProdOpcGridControl = New DevExpress.XtraGrid.GridControl
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem
        Me.btnAlter = New DevExpress.XtraBars.BarButtonItem
        Me.btnClear = New DevExpress.XtraBars.BarButtonItem
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.txtDesc = New Campos.NanoCampo
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txtValor = New Campos.NanoCampo
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.cboTipo = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdOpcBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdOpcGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsNanoCommerce
        '
        Me.DsNanoCommerce.DataSetName = "dsNanoCommerce"
        Me.DsNanoCommerce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProdOpcBindingSource
        '
        Me.ProdOpcBindingSource.DataMember = "ProdOpc"
        Me.ProdOpcBindingSource.DataSource = Me.DsNanoCommerce
        '
        'ProdOpcTableAdapter
        '
        Me.ProdOpcTableAdapter.ClearBeforeFill = True
        '
        'ProdOpcGridControl
        '
        Me.ProdOpcGridControl.DataSource = Me.ProdOpcBindingSource
        Me.ProdOpcGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProdOpcGridControl.EmbeddedNavigator.Name = ""
        Me.ProdOpcGridControl.Location = New System.Drawing.Point(2, 20)
        Me.ProdOpcGridControl.MainView = Me.grd1
        Me.ProdOpcGridControl.Name = "ProdOpcGridControl"
        Me.ProdOpcGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterar})
        Me.ProdOpcGridControl.Size = New System.Drawing.Size(634, 337)
        Me.ProdOpcGridControl.TabIndex = 1
        Me.ProdOpcGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colProduto, Me.colValor, Me.colTipo})
        Me.grd1.GridControl = Me.ProdOpcGridControl
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        '
        'colProduto
        '
        Me.colProduto.Caption = "Descrição"
        Me.colProduto.ColumnEdit = Me.txtAlterar
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 1
        Me.colProduto.Width = 322
        '
        'txtAlterar
        '
        Me.txtAlterar.AutoHeight = False
        Me.txtAlterar.Name = "txtAlterar"
        '
        'colValor
        '
        Me.colValor.Caption = "Valor"
        Me.colValor.ColumnEdit = Me.txtAlterar
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.OptionsColumn.ReadOnly = True
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 2
        Me.colValor.Width = 131
        '
        'colTipo
        '
        Me.colTipo.Caption = "Tipo"
        Me.colTipo.ColumnEdit = Me.txtAlterar
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.OptionsColumn.ReadOnly = True
        Me.colTipo.Visible = True
        Me.colTipo.VisibleIndex = 0
        Me.colTipo.Width = 117
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnDelete, Me.btnSave, Me.btnClear, Me.btnAlter, Me.btnClose})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAlter, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnClear, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnClose, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnDelete
        '
        Me.btnDelete.Caption = "&Excluir"
        Me.btnDelete.Glyph = Global.Nano.My.Resources.Resources.delete
        Me.btnDelete.Id = 0
        Me.btnDelete.Name = "btnDelete"
        '
        'btnSave
        '
        Me.btnSave.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSave.Caption = "&Salvar"
        Me.btnSave.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSave.Id = 1
        Me.btnSave.Name = "btnSave"
        '
        'btnAlter
        '
        Me.btnAlter.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnAlter.Caption = "&Alterar"
        Me.btnAlter.Glyph = Global.Nano.My.Resources.Resources.Alterar
        Me.btnAlter.Id = 3
        Me.btnAlter.Name = "btnAlter"
        '
        'btnClear
        '
        Me.btnClear.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnClear.Caption = "&Limpar"
        Me.btnClear.Glyph = Global.Nano.My.Resources.Resources.Comando_Limpar_32x32
        Me.btnClear.Id = 2
        Me.btnClear.Name = "btnClear"
        '
        'btnClose
        '
        Me.btnClose.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnClose.Caption = "&Fechar"
        Me.btnClose.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnClose.Id = 4
        Me.btnClose.Name = "btnClose"
        '
        'txtDesc
        '
        Me.txtDesc.CasasDecimais = 0
        Me.txtDesc.EnterMoveNextControl = True
        Me.txtDesc.Location = New System.Drawing.Point(64, 12)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Numerico = False
        Me.txtDesc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDesc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDesc.Properties.MaxLength = 20
        Me.txtDesc.Size = New System.Drawing.Size(563, 20)
        Me.txtDesc.TabIndex = 0
        Me.txtDesc.Tag = "Descrição"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "Descrição"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.ProdOpcGridControl)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 68)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(638, 359)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "Opcionais Cadastrados"
        '
        'txtValor
        '
        Me.txtValor.CasasDecimais = 2
        Me.txtValor.EnterMoveNextControl = True
        Me.txtValor.Location = New System.Drawing.Point(503, 38)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Numerico = True
        Me.txtValor.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValor.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValor.Properties.MaxLength = 20
        Me.txtValor.Size = New System.Drawing.Size(124, 20)
        Me.txtValor.TabIndex = 2
        Me.txtValor.Tag = "Valor"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(473, 41)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl2.TabIndex = 11
        Me.LabelControl2.Text = "Valor"
        '
        'cboTipo
        '
        Me.cboTipo.EnterMoveNextControl = True
        Me.cboTipo.Location = New System.Drawing.Point(64, 38)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboTipo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboTipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipo.Size = New System.Drawing.Size(359, 20)
        Me.cboTipo.TabIndex = 1
        Me.cboTipo.Tag = "Tipo"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(38, 41)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl3.TabIndex = 13
        Me.LabelControl3.Text = "Tipo"
        '
        'frmCadOpcoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 465)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCadOpcoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Opcionais"
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdOpcBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdOpcGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents ProdOpcBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProdOpcTableAdapter As Nano.dsNanoCommerceTableAdapters.ProdOpcTableAdapter
    Friend WithEvents ProdOpcGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClear As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents txtValor As Campos.NanoCampo
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDesc As Campos.NanoCampo
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTipo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
