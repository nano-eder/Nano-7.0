<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMontaProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMontaProduto))
        Me.txtCodProd = New Campos.NanoCampo
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsPed = New System.Data.DataSet
        Me.tbProd = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.tbOpc = New System.Data.DataTable
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.tbOpc2 = New System.Data.DataTable
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridOpc = New DevExpress.XtraGrid.GridControl
        Me.grd3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colDescricao1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.memObs = New DevExpress.XtraEditors.MemoEdit
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl
        Me.grd2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colDescricao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btnRem1 = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.btnRem2 = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.lstOpc = New DevExpress.XtraEditors.ListBoxControl
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl
        Me.btnCadOpc = New DevExpress.XtraEditors.SimpleButton
        Me.txtValor = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btnConcluido = New DevExpress.XtraEditors.SimpleButton
        CType(Me.txtCodProd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsPed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbOpc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbOpc2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridOpc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memObs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.lstOpc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodProd
        '
        Me.txtCodProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCodProd.CasasDecimais = 0
        Me.txtCodProd.Location = New System.Drawing.Point(12, 30)
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.Numerico = False
        Me.txtCodProd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodProd.Properties.Appearance.Options.UseFont = True
        Me.txtCodProd.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodProd.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCodProd.Properties.MaxLength = 50
        Me.txtCodProd.Size = New System.Drawing.Size(240, 32)
        Me.txtCodProd.TabIndex = 37
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(12, 5)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(106, 19)
        Me.LabelControl9.TabIndex = 38
        Me.LabelControl9.Text = "Cód. Produto"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbProd"
        Me.GridControl1.DataSource = Me.dsPed
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 21)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(611, 170)
        Me.GridControl1.TabIndex = 39
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsPed
        '
        Me.dsPed.DataSetName = "dsPed"
        Me.dsPed.Tables.AddRange(New System.Data.DataTable() {Me.tbProd, Me.tbOpc, Me.tbOpc2})
        '
        'tbProd
        '
        Me.tbProd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn8, Me.DataColumn9})
        Me.tbProd.TableName = "tbProd"
        '
        'DataColumn1
        '
        Me.DataColumn1.Caption = "Código"
        Me.DataColumn1.ColumnName = "Codigo"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Produto"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Valor"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Column1"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "CodProd"
        '
        'tbOpc
        '
        Me.tbOpc.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn4, Me.DataColumn5})
        Me.tbOpc.TableName = "tbOpc"
        '
        'DataColumn4
        '
        Me.DataColumn4.Caption = "Descrição"
        Me.DataColumn4.ColumnName = "Descricao"
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "Valor R$"
        Me.DataColumn5.ColumnName = "Valor"
        '
        'tbOpc2
        '
        Me.tbOpc2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn6, Me.DataColumn7})
        Me.tbOpc2.TableName = "tbOpc2"
        '
        'DataColumn6
        '
        Me.DataColumn6.Caption = "Descrição"
        Me.DataColumn6.ColumnName = "Descricao"
        '
        'DataColumn7
        '
        Me.DataColumn7.Caption = "Valor R$"
        Me.DataColumn7.ColumnName = "Valor"
        '
        'grd1
        '
        Me.grd1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grd1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grd1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grd1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.grd1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.grd1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grd1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grd1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grd1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grd1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colProduto, Me.colValor, Me.colCodProd})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.EnableAppearanceEvenRow = True
        Me.grd1.OptionsView.EnableAppearanceOddRow = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCodigo.AppearanceCell.Options.UseFont = True
        Me.colCodigo.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 92
        '
        'colProduto
        '
        Me.colProduto.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colProduto.AppearanceCell.Options.UseFont = True
        Me.colProduto.Caption = "Produto"
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 1
        Me.colProduto.Width = 343
        '
        'colValor
        '
        Me.colValor.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colValor.AppearanceCell.Options.UseFont = True
        Me.colValor.AppearanceCell.Options.UseTextOptions = True
        Me.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor.Caption = "Valor R$"
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.OptionsColumn.ReadOnly = True
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 2
        Me.colValor.Width = 80
        '
        'colCodProd
        '
        Me.colCodProd.Caption = "Cód. Prod."
        Me.colCodProd.FieldName = "CodProd"
        Me.colCodProd.Name = "colCodProd"
        Me.colCodProd.OptionsColumn.ReadOnly = True
        '
        'GridOpc
        '
        Me.GridOpc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridOpc.DataMember = "tbOpc2"
        Me.GridOpc.DataSource = Me.dsPed
        Me.GridOpc.EmbeddedNavigator.Name = ""
        Me.GridOpc.Location = New System.Drawing.Point(2, 21)
        Me.GridOpc.MainView = Me.grd3
        Me.GridOpc.Name = "GridOpc"
        Me.GridOpc.Size = New System.Drawing.Size(369, 322)
        Me.GridOpc.TabIndex = 41
        Me.GridOpc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd3})
        '
        'grd3
        '
        Me.grd3.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grd3.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.grd3.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grd3.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grd3.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grd3.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grd3.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grd3.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grd3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grd3.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.grd3.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grd3.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grd3.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grd3.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grd3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDescricao1, Me.colValor2})
        Me.grd3.GridControl = Me.GridOpc
        Me.grd3.Name = "grd3"
        Me.grd3.OptionsView.ShowGroupPanel = False
        '
        'colDescricao1
        '
        Me.colDescricao1.Caption = "Descrição"
        Me.colDescricao1.FieldName = "Descricao"
        Me.colDescricao1.Name = "colDescricao1"
        Me.colDescricao1.OptionsColumn.ReadOnly = True
        Me.colDescricao1.Visible = True
        Me.colDescricao1.VisibleIndex = 0
        Me.colDescricao1.Width = 245
        '
        'colValor2
        '
        Me.colValor2.AppearanceCell.Options.UseTextOptions = True
        Me.colValor2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor2.Caption = "Valor R$"
        Me.colValor2.FieldName = "Valor"
        Me.colValor2.Name = "colValor2"
        Me.colValor2.OptionsColumn.ReadOnly = True
        Me.colValor2.Visible = True
        Me.colValor2.VisibleIndex = 1
        Me.colValor2.Width = 101
        '
        'memObs
        '
        Me.memObs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.memObs.Location = New System.Drawing.Point(2, 21)
        Me.memObs.Name = "memObs"
        Me.memObs.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.memObs.Size = New System.Drawing.Size(353, 317)
        Me.memObs.TabIndex = 42
        '
        'GridControl3
        '
        Me.GridControl3.DataMember = "tbOpc"
        Me.GridControl3.DataSource = Me.dsPed
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.EmbeddedNavigator.Name = ""
        Me.GridControl3.Location = New System.Drawing.Point(2, 21)
        Me.GridControl3.MainView = Me.grd2
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(353, 170)
        Me.GridControl3.TabIndex = 43
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd2})
        '
        'grd2
        '
        Me.grd2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grd2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grd2.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grd2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grd2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grd2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.grd2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grd2.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grd2.Appearance.Row.Options.UseForeColor = True
        Me.grd2.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grd2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grd2.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grd2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDescricao, Me.colValor1})
        Me.grd2.GridControl = Me.GridControl3
        Me.grd2.Name = "grd2"
        Me.grd2.OptionsView.EnableAppearanceEvenRow = True
        Me.grd2.OptionsView.EnableAppearanceOddRow = True
        Me.grd2.OptionsView.ShowGroupPanel = False
        '
        'colDescricao
        '
        Me.colDescricao.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDescricao.AppearanceCell.Options.UseFont = True
        Me.colDescricao.Caption = "Descrição"
        Me.colDescricao.FieldName = "Descricao"
        Me.colDescricao.Name = "colDescricao"
        Me.colDescricao.OptionsColumn.ReadOnly = True
        Me.colDescricao.Visible = True
        Me.colDescricao.VisibleIndex = 0
        Me.colDescricao.Width = 247
        '
        'colValor1
        '
        Me.colValor1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colValor1.AppearanceCell.Options.UseFont = True
        Me.colValor1.AppearanceCell.Options.UseTextOptions = True
        Me.colValor1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor1.Caption = "Valor R$"
        Me.colValor1.FieldName = "Valor"
        Me.colValor1.Name = "colValor1"
        Me.colValor1.OptionsColumn.ReadOnly = True
        Me.colValor1.Visible = True
        Me.colValor1.VisibleIndex = 1
        Me.colValor1.Width = 91
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.btnRem1)
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(3, 68)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(615, 193)
        Me.GroupControl1.TabIndex = 44
        Me.GroupControl1.Text = "Produtos"
        '
        'btnRem1
        '
        Me.btnRem1.Image = Global.Nano.My.Resources.Resources.Remove_Item
        Me.btnRem1.Location = New System.Drawing.Point(529, 2)
        Me.btnRem1.Name = "btnRem1"
        Me.btnRem1.Size = New System.Drawing.Size(81, 19)
        Me.btnRem1.TabIndex = 48
        Me.btnRem1.Text = "Remover"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.btnRem2)
        Me.GroupControl2.Controls.Add(Me.GridControl3)
        Me.GroupControl2.Location = New System.Drawing.Point(624, 68)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(357, 193)
        Me.GroupControl2.TabIndex = 45
        Me.GroupControl2.Text = "Opcionais Adicionados"
        '
        'btnRem2
        '
        Me.btnRem2.Image = Global.Nano.My.Resources.Resources.Remove_Item
        Me.btnRem2.Location = New System.Drawing.Point(271, 2)
        Me.btnRem2.Name = "btnRem2"
        Me.btnRem2.Size = New System.Drawing.Size(81, 19)
        Me.btnRem2.TabIndex = 49
        Me.btnRem2.Text = "Remover"
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.Controls.Add(Me.lstOpc)
        Me.GroupControl3.Location = New System.Drawing.Point(3, 267)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(236, 393)
        Me.GroupControl3.TabIndex = 46
        Me.GroupControl3.Text = "Tipo de Opções"
        '
        'lstOpc
        '
        Me.lstOpc.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOpc.Appearance.ForeColor = System.Drawing.Color.Green
        Me.lstOpc.Appearance.Options.UseFont = True
        Me.lstOpc.Appearance.Options.UseForeColor = True
        Me.lstOpc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstOpc.Location = New System.Drawing.Point(2, 21)
        Me.lstOpc.Name = "lstOpc"
        Me.lstOpc.Size = New System.Drawing.Size(232, 370)
        Me.lstOpc.TabIndex = 42
        '
        'GroupControl4
        '
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.Controls.Add(Me.btnAdd)
        Me.GroupControl4.Controls.Add(Me.GridOpc)
        Me.GroupControl4.Location = New System.Drawing.Point(245, 267)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(373, 393)
        Me.GroupControl4.TabIndex = 47
        Me.GroupControl4.Text = "Opções"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnAdd.Image = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnAdd.Location = New System.Drawing.Point(2, 346)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(369, 45)
        Me.btnAdd.TabIndex = 53
        Me.btnAdd.Text = "Adicionar"
        '
        'GroupControl5
        '
        Me.GroupControl5.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl5.AppearanceCaption.Options.UseFont = True
        Me.GroupControl5.Controls.Add(Me.memObs)
        Me.GroupControl5.Location = New System.Drawing.Point(624, 267)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(357, 340)
        Me.GroupControl5.TabIndex = 47
        Me.GroupControl5.Text = "Observações"
        '
        'btnCadOpc
        '
        Me.btnCadOpc.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadOpc.Appearance.Options.UseFont = True
        Me.btnCadOpc.Image = Global.Nano.My.Resources.Resources.Suprimento
        Me.btnCadOpc.Location = New System.Drawing.Point(264, 28)
        Me.btnCadOpc.Name = "btnCadOpc"
        Me.btnCadOpc.Size = New System.Drawing.Size(168, 35)
        Me.btnCadOpc.TabIndex = 49
        Me.btnCadOpc.Text = "Cadastrar Opções"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(752, 30)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtValor.Properties.Appearance.Options.UseFont = True
        Me.txtValor.Properties.Appearance.Options.UseForeColor = True
        Me.txtValor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValor.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Blue
        Me.txtValor.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtValor.Properties.ReadOnly = True
        Me.txtValor.Size = New System.Drawing.Size(210, 32)
        Me.txtValor.TabIndex = 50
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(752, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(165, 19)
        Me.LabelControl1.TabIndex = 51
        Me.LabelControl1.Text = "Valor do Produto R$"
        '
        'btnConcluido
        '
        Me.btnConcluido.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConcluido.Appearance.Options.UseFont = True
        Me.btnConcluido.Image = Global.Nano.My.Resources.Resources.apply
        Me.btnConcluido.Location = New System.Drawing.Point(646, 613)
        Me.btnConcluido.Name = "btnConcluido"
        Me.btnConcluido.Size = New System.Drawing.Size(316, 45)
        Me.btnConcluido.TabIndex = 52
        Me.btnConcluido.Text = "Concluído"
        '
        'frmMontaProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.btnConcluido)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnCadOpc)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.GroupControl5)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.txtCodProd)
        Me.Controls.Add(Me.LabelControl9)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMontaProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Montar Produto"
        CType(Me.txtCodProd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsPed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbOpc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbOpc2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridOpc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memObs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.lstOpc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodProd As Campos.NanoCampo
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridOpc As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents memObs As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents dsPed As System.Data.DataSet
    Friend WithEvents tbProd As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tbOpc As System.Data.DataTable
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescricao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tbOpc2 As System.Data.DataTable
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents colDescricao1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnRem1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRem2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCadOpc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnConcluido As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lstOpc As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents colCodProd As DevExpress.XtraGrid.Columns.GridColumn
End Class
