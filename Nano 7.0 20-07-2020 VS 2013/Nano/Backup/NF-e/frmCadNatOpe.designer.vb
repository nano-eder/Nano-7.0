<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadNatOpe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadNatOpe))
        Me.NatOpeGridControl = New DevExpress.XtraGrid.GridControl
        Me.dsNO = New System.Data.DataSet
        Me.tbNO = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescricao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
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
        CType(Me.NatOpeGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NatOpeGridControl
        '
        Me.NatOpeGridControl.DataMember = "tbNO"
        Me.NatOpeGridControl.DataSource = Me.dsNO
        Me.NatOpeGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NatOpeGridControl.EmbeddedNavigator.Name = ""
        Me.NatOpeGridControl.Location = New System.Drawing.Point(2, 20)
        Me.NatOpeGridControl.MainView = Me.grd1
        Me.NatOpeGridControl.Name = "NatOpeGridControl"
        Me.NatOpeGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterar})
        Me.NatOpeGridControl.Size = New System.Drawing.Size(598, 309)
        Me.NatOpeGridControl.TabIndex = 1
        Me.NatOpeGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsNO
        '
        Me.dsNO.DataSetName = "NewDataSet"
        Me.dsNO.Tables.AddRange(New System.Data.DataTable() {Me.tbNO})
        '
        'tbNO
        '
        Me.tbNO.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2})
        Me.tbNO.TableName = "tbNO"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Codigo"
        '
        'DataColumn2
        '
        Me.DataColumn2.Caption = "Descrição"
        Me.DataColumn2.ColumnName = "Descricao"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescricao})
        Me.grd1.GridControl = Me.NatOpeGridControl
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.EnableAppearanceEvenRow = True
        Me.grd1.OptionsView.EnableAppearanceOddRow = True
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
        'colDescricao
        '
        Me.colDescricao.Caption = "Descrição"
        Me.colDescricao.ColumnEdit = Me.txtAlterar
        Me.colDescricao.FieldName = "Descricao"
        Me.colDescricao.Name = "colDescricao"
        Me.colDescricao.OptionsColumn.ReadOnly = True
        Me.colDescricao.Visible = True
        Me.colDescricao.VisibleIndex = 0
        '
        'txtAlterar
        '
        Me.txtAlterar.AutoHeight = False
        Me.txtAlterar.Name = "txtAlterar"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnDelete, Me.btnSave, Me.btnAlter, Me.btnClear, Me.btnClose})
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
        Me.btnAlter.Id = 2
        Me.btnAlter.Name = "btnAlter"
        '
        'btnClear
        '
        Me.btnClear.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnClear.Caption = "&Limpar"
        Me.btnClear.Glyph = Global.Nano.My.Resources.Resources.Comando_Limpar_32x32
        Me.btnClear.Id = 3
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
        Me.txtDesc.Location = New System.Drawing.Point(78, 17)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Numerico = False
        Me.txtDesc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDesc.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txtDesc.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtDesc.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.txtDesc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDesc.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesc.Properties.MaxLength = 60
        Me.txtDesc.Size = New System.Drawing.Size(512, 20)
        Me.txtDesc.TabIndex = 6
        Me.txtDesc.Tag = "Descrição"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(26, 20)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl1.TabIndex = 95
        Me.LabelControl1.Text = "Descrição"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.NatOpeGridControl)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(0, 50)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(602, 331)
        Me.GroupControl1.TabIndex = 96
        Me.GroupControl1.Text = "Natureza da Operação cadastradas"
        '
        'frmCadNatOpe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 417)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmCadNatOpe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Natureza da Operação"
        CType(Me.NatOpeGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsNO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbNO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NatOpeGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescricao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dsNO As System.Data.DataSet
    Friend WithEvents tbNO As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
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
    Friend WithEvents txtDesc As Campos.NanoCampo
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
