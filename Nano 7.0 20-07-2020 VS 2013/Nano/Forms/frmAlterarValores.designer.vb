<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlterarValores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlterarValores))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnCarregar = New DevExpress.XtraBars.BarButtonItem
        Me.btnOk = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.cboGrupo = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboAlterar = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboAumentar = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblGruSet = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.pb1 = New System.Windows.Forms.ProgressBar
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtValor = New Campos.NanoCampo
        Me.txtPor = New Campos.NanoCampo
        Me.rdgAlt = New DevExpress.XtraEditors.RadioGroup
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsProd = New System.Data.DataSet
        Me.tbProd = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorAlterado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.cboCampo = New DevExpress.XtraEditors.ComboBoxEdit
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrupo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAlterar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAumentar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgAlt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCampo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnOk, Me.btnFechar, Me.btnCarregar})
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCarregar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnOk, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnCarregar
        '
        Me.btnCarregar.Caption = "&Verificar Antes"
        Me.btnCarregar.Glyph = Global.Nano.My.Resources.Resources.Alterar
        Me.btnCarregar.Id = 3
        Me.btnCarregar.Name = "btnCarregar"
        '
        'btnOk
        '
        Me.btnOk.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnOk.Caption = "&Ok"
        Me.btnOk.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnOk.Id = 0
        Me.btnOk.Name = "btnOk"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 1
        Me.btnFechar.Name = "btnFechar"
        '
        'cboGrupo
        '
        Me.cboGrupo.Enabled = False
        Me.cboGrupo.EnterMoveNextControl = True
        Me.cboGrupo.Location = New System.Drawing.Point(50, 64)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGrupo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboGrupo.Size = New System.Drawing.Size(349, 20)
        Me.cboGrupo.TabIndex = 5
        Me.cboGrupo.Visible = False
        '
        'cboAlterar
        '
        Me.cboAlterar.EnterMoveNextControl = True
        Me.cboAlterar.Location = New System.Drawing.Point(454, 38)
        Me.cboAlterar.Name = "cboAlterar"
        Me.cboAlterar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAlterar.Properties.Items.AddRange(New Object() {"TODOS", "GRUPO", "SETOR", "FORNECEDOR"})
        Me.cboAlterar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboAlterar.Size = New System.Drawing.Size(125, 20)
        Me.cboAlterar.TabIndex = 4
        '
        'cboAumentar
        '
        Me.cboAumentar.EnterMoveNextControl = True
        Me.cboAumentar.Location = New System.Drawing.Point(278, 38)
        Me.cboAumentar.Name = "cboAumentar"
        Me.cboAumentar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAumentar.Properties.Items.AddRange(New Object() {"AUMENTAR", "DIMINUIR"})
        Me.cboAumentar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboAumentar.Size = New System.Drawing.Size(121, 20)
        Me.cboAumentar.TabIndex = 3
        '
        'lblGruSet
        '
        Me.lblGruSet.Location = New System.Drawing.Point(15, 67)
        Me.lblGruSet.Name = "lblGruSet"
        Me.lblGruSet.Size = New System.Drawing.Size(0, 13)
        Me.lblGruSet.TabIndex = 9
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(415, 41)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl2.TabIndex = 10
        Me.LabelControl2.Text = "Alterar"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(222, 41)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Aum./Dim."
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(408, 15)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl4.TabIndex = 12
        Me.LabelControl4.Text = "Valor R$"
        '
        'pb1
        '
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pb1.Location = New System.Drawing.Point(0, 357)
        Me.pb1.Maximum = 320
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(591, 23)
        Me.pb1.TabIndex = 14
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(233, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl1.TabIndex = 16
        Me.LabelControl1.Text = "Porc. %"
        '
        'txtValor
        '
        Me.txtValor.CasasDecimais = 2
        Me.txtValor.Enabled = False
        Me.txtValor.EnterMoveNextControl = True
        Me.txtValor.Location = New System.Drawing.Point(454, 12)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Numerico = True
        Me.txtValor.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValor.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txtValor.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtValor.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.txtValor.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValor.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtValor.Properties.MaxLength = 150
        Me.txtValor.Size = New System.Drawing.Size(125, 20)
        Me.txtValor.TabIndex = 1
        Me.txtValor.Tag = "Valor R$"
        '
        'txtPor
        '
        Me.txtPor.CasasDecimais = 2
        Me.txtPor.EnterMoveNextControl = True
        Me.txtPor.Location = New System.Drawing.Point(278, 12)
        Me.txtPor.Name = "txtPor"
        Me.txtPor.Numerico = True
        Me.txtPor.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPor.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txtPor.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtPor.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.txtPor.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtPor.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtPor.Properties.MaxLength = 150
        Me.txtPor.Size = New System.Drawing.Size(122, 20)
        Me.txtPor.TabIndex = 0
        Me.txtPor.Tag = "Porcentagem %"
        '
        'rdgAlt
        '
        Me.rdgAlt.Location = New System.Drawing.Point(50, 12)
        Me.rdgAlt.Name = "rdgAlt"
        Me.rdgAlt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgAlt.Properties.Appearance.Options.UseFont = True
        Me.rdgAlt.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Porc. %"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Valor R$")})
        Me.rdgAlt.Size = New System.Drawing.Size(163, 20)
        Me.rdgAlt.TabIndex = 19
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(0, 90)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(591, 267)
        Me.GroupControl1.TabIndex = 20
        Me.GroupControl1.Text = "Produtos"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbProd"
        Me.GridControl1.DataSource = Me.dsProd
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 20)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(587, 245)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1, Me.GridView2})
        '
        'dsProd
        '
        Me.dsProd.DataSetName = "NewDataSet"
        Me.dsProd.Tables.AddRange(New System.Data.DataTable() {Me.tbProd})
        '
        'tbProd
        '
        Me.tbProd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4})
        Me.tbProd.TableName = "tbProd"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Produto"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Valor"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "ValorAlterado"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Codigo"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProduto, Me.colValor, Me.colValorAlterado, Me.colCodigo})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colProduto
        '
        Me.colProduto.Caption = "Produto"
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 1
        Me.colProduto.Width = 229
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
        Me.colValor.Width = 77
        '
        'colValorAlterado
        '
        Me.colValorAlterado.AppearanceCell.Options.UseTextOptions = True
        Me.colValorAlterado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorAlterado.Caption = "Valor Alt. R$"
        Me.colValorAlterado.FieldName = "ValorAlterado"
        Me.colValorAlterado.Name = "colValorAlterado"
        Me.colValorAlterado.OptionsColumn.ReadOnly = True
        Me.colValorAlterado.Visible = True
        Me.colValorAlterado.VisibleIndex = 3
        Me.colValorAlterado.Width = 82
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 59
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(24, 15)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl5.TabIndex = 21
        Me.LabelControl5.Text = "Tipo"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(11, 41)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl6.TabIndex = 23
        Me.LabelControl6.Text = "Campo"
        '
        'cboCampo
        '
        Me.cboCampo.EnterMoveNextControl = True
        Me.cboCampo.Location = New System.Drawing.Point(50, 38)
        Me.cboCampo.Name = "cboCampo"
        Me.cboCampo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCampo.Properties.Items.AddRange(New Object() {"VALOR VENDA", "VALOR CUSTO"})
        Me.cboCampo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCampo.Size = New System.Drawing.Size(163, 20)
        Me.cboCampo.TabIndex = 2
        '
        'frmAlterarValores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 416)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.cboCampo)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.rdgAlt)
        Me.Controls.Add(Me.txtPor)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.lblGruSet)
        Me.Controls.Add(Me.cboAumentar)
        Me.Controls.Add(Me.cboAlterar)
        Me.Controls.Add(Me.cboGrupo)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAlterarValores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alterar Valores"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrupo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAlterar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAumentar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgAlt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCampo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnOk As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblGruSet As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboAumentar As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboAlterar As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboGrupo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents pb1 As System.Windows.Forms.ProgressBar
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPor As Campos.NanoCampo
    Friend WithEvents txtValor As Campos.NanoCampo
    Friend WithEvents rdgAlt As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dsProd As System.Data.DataSet
    Friend WithEvents tbProd As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorAlterado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCarregar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCampo As DevExpress.XtraEditors.ComboBoxEdit
End Class
