<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceita
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
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceita))
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.txtCodReceita = New DevExpress.XtraEditors.TextEdit
        Me.lblCodPed = New DevExpress.XtraEditors.LabelControl
        Me.grpProd = New DevExpress.XtraEditors.GroupControl
        Me.rgpTipoValor = New DevExpress.XtraEditors.RadioGroup
        Me.txtNomePro = New DevExpress.XtraEditors.TextEdit
        Me.txtCodPro = New DevExpress.XtraEditors.ButtonEdit
        Me.txtQtd = New DevExpress.XtraEditors.TextEdit
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton
        Me.chkAlterado = New DevExpress.XtraEditors.CheckEdit
        Me.txtValor = New DevExpress.XtraEditors.TextEdit
        Me.grpItens = New DevExpress.XtraEditors.GroupControl
        Me.PedidoGridControl = New DevExpress.XtraGrid.GridControl
        Me.dsItens = New System.Data.DataSet
        Me.tbItens = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colQtd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlt = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colCodigoProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorUnitario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoPeca = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodPedAut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipoValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtdEstoque = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton
        Me.grdDesc = New DevExpress.XtraEditors.GroupControl
        Me.txtDesc = New DevExpress.XtraEditors.MemoEdit
        Me.bmComandos = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnVisuImp = New DevExpress.XtraBars.BarButtonItem
        Me.bsiKit = New DevExpress.XtraBars.BarSubItem
        Me.btnMontarKit = New DevExpress.XtraBars.BarButtonItem
        Me.btnDesmontar = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvarMontar = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem
        Me.btnCancelar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.grpVal = New DevExpress.XtraEditors.GroupControl
        Me.txtTotalCusto = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtQtdKit = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.lblPor = New DevExpress.XtraEditors.LabelControl
        Me.txtPorcentagem = New DevExpress.XtraEditors.TextEdit
        Me.lblValDesc = New DevExpress.XtraEditors.LabelControl
        Me.txtValorVenda = New DevExpress.XtraEditors.TextEdit
        Me.lblDesc = New System.Windows.Forms.Label
        Me.pcLinha = New DevExpress.XtraEditors.PanelControl
        Me.btnConsulta = New DevExpress.XtraEditors.SimpleButton
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.txtNome = New Campos.NanoCampo
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.btnCadGrp = New DevExpress.XtraEditors.SimpleButton
        Me.cboGrp = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.btnCadSet = New DevExpress.XtraEditors.SimpleButton
        Me.cboSet = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chkAlterar = New DevExpress.XtraEditors.CheckEdit
        Me.txtTotalItens = New DevExpress.XtraEditors.TextEdit
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        Label7 = New System.Windows.Forms.Label
        Label10 = New System.Windows.Forms.Label
        Label11 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodReceita.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProd.SuspendLayout()
        CType(Me.rgpTipoValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomePro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodPro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAlterado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpItens.SuspendLayout()
        CType(Me.PedidoGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsItens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbItens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdDesc.SuspendLayout()
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bmComandos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpVal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpVal.SuspendLayout()
        CType(Me.txtTotalCusto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtdKit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcentagem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorVenda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcLinha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAlterar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalItens.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(27, 35)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(40, 13)
        Label3.TabIndex = 43
        Label3.Text = "Código"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(194, 35)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(45, 13)
        Label4.TabIndex = 45
        Label4.Text = "Produto"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(377, 15)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(50, 13)
        Label6.TabIndex = 53
        Label6.Text = "Preço R$"
        Label6.Visible = False
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(778, 35)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(25, 13)
        Label7.TabIndex = 58
        Label7.Text = "Qtd"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(12, 25)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(142, 18)
        Label10.TabIndex = 55
        Label10.Text = "Total Produtos R$"
        Label10.Visible = False
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.Location = New System.Drawing.Point(10, 25)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(71, 18)
        Label11.TabIndex = 56
        Label11.Text = "Total R$"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(13, 302)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(89, 18)
        Label5.TabIndex = 60
        Label5.Text = "Total Itens"
        '
        'txtAlterar
        '
        Me.txtAlterar.AutoHeight = False
        Me.txtAlterar.Name = "txtAlterar"
        '
        'txtCodReceita
        '
        Me.txtCodReceita.EnterMoveNextControl = True
        Me.txtCodReceita.Location = New System.Drawing.Point(72, 10)
        Me.txtCodReceita.Name = "txtCodReceita"
        Me.txtCodReceita.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodReceita.Properties.Appearance.Options.UseFont = True
        Me.txtCodReceita.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodReceita.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCodReceita.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodReceita.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodReceita.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtCodReceita.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodReceita.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCodReceita.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCodReceita.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCodReceita.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCodReceita.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodReceita.Size = New System.Drawing.Size(90, 21)
        Me.txtCodReceita.TabIndex = 0
        Me.txtCodReceita.Tag = "Código"
        '
        'lblCodPed
        '
        Me.lblCodPed.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodPed.Appearance.Options.UseFont = True
        Me.lblCodPed.Location = New System.Drawing.Point(28, 14)
        Me.lblCodPed.Name = "lblCodPed"
        Me.lblCodPed.Size = New System.Drawing.Size(38, 13)
        Me.lblCodPed.TabIndex = 1
        Me.lblCodPed.Text = "Código"
        '
        'grpProd
        '
        Me.grpProd.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProd.AppearanceCaption.Options.UseFont = True
        Me.grpProd.Controls.Add(Me.rgpTipoValor)
        Me.grpProd.Controls.Add(Me.txtNomePro)
        Me.grpProd.Controls.Add(Me.txtCodPro)
        Me.grpProd.Controls.Add(Me.txtQtd)
        Me.grpProd.Controls.Add(Label7)
        Me.grpProd.Controls.Add(Me.btnAdd)
        Me.grpProd.Controls.Add(Label4)
        Me.grpProd.Controls.Add(Label3)
        Me.grpProd.Controls.Add(Me.chkAlterado)
        Me.grpProd.Location = New System.Drawing.Point(3, 43)
        Me.grpProd.Name = "grpProd"
        Me.grpProd.Size = New System.Drawing.Size(1001, 64)
        Me.grpProd.TabIndex = 4
        Me.grpProd.Text = "Adicionar Produtos"
        '
        'rgpTipoValor
        '
        Me.rgpTipoValor.Location = New System.Drawing.Point(139, -1)
        Me.rgpTipoValor.Name = "rgpTipoValor"
        Me.rgpTipoValor.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgpTipoValor.Properties.Appearance.Options.UseBackColor = True
        Me.rgpTipoValor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rgpTipoValor.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Custo"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Venda")})
        Me.rgpTipoValor.Size = New System.Drawing.Size(138, 20)
        Me.rgpTipoValor.TabIndex = 85
        '
        'txtNomePro
        '
        Me.txtNomePro.EnterMoveNextControl = True
        Me.txtNomePro.Location = New System.Drawing.Point(242, 32)
        Me.txtNomePro.Name = "txtNomePro"
        Me.txtNomePro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomePro.Properties.Appearance.Options.UseFont = True
        Me.txtNomePro.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtNomePro.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNomePro.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNomePro.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNomePro.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomePro.Properties.MaxLength = 200
        Me.txtNomePro.Size = New System.Drawing.Size(518, 20)
        Me.txtNomePro.TabIndex = 1
        Me.txtNomePro.Tag = "Produto"
        '
        'txtCodPro
        '
        Me.txtCodPro.EnterMoveNextControl = True
        Me.txtCodPro.Location = New System.Drawing.Point(69, 32)
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
        'txtQtd
        '
        Me.txtQtd.EnterMoveNextControl = True
        Me.txtQtd.Location = New System.Drawing.Point(805, 32)
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtQtd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtd.Properties.Appearance.Options.UseBackColor = True
        Me.txtQtd.Properties.Appearance.Options.UseFont = True
        Me.txtQtd.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtd.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtd.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtQtd.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtQtd.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtQtd.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtQtd.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQtd.Properties.MaxLength = 19
        Me.txtQtd.Size = New System.Drawing.Size(104, 20)
        Me.txtQtd.TabIndex = 2
        Me.txtQtd.Tag = "Qtd"
        Me.txtQtd.ToolTip = "Unidade de Medida"
        Me.txtQtd.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.txtQtd.ToolTipTitle = "QUALQUER"
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnAdd.Location = New System.Drawing.Point(915, 27)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(78, 30)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "&Adicionar"
        '
        'chkAlterado
        '
        Me.chkAlterado.Location = New System.Drawing.Point(541, 33)
        Me.chkAlterado.Name = "chkAlterado"
        Me.chkAlterado.Properties.Caption = "Alterado"
        Me.chkAlterado.Properties.ReadOnly = True
        Me.chkAlterado.Size = New System.Drawing.Size(87, 19)
        Me.chkAlterado.TabIndex = 84
        '
        'txtValor
        '
        Me.txtValor.EnterMoveNextControl = True
        Me.txtValor.Location = New System.Drawing.Point(433, 11)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Properties.Appearance.Options.UseFont = True
        Me.txtValor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValor.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtValor.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtValor.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtValor.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtValor.Size = New System.Drawing.Size(85, 20)
        Me.txtValor.TabIndex = 4
        Me.txtValor.Tag = "Preço R$"
        Me.txtValor.Visible = False
        '
        'grpItens
        '
        Me.grpItens.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpItens.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpItens.AppearanceCaption.ForeColor = System.Drawing.Color.Black
        Me.grpItens.AppearanceCaption.Options.UseFont = True
        Me.grpItens.AppearanceCaption.Options.UseForeColor = True
        Me.grpItens.Controls.Add(Me.PedidoGridControl)
        Me.grpItens.Controls.Add(Me.btnDelete)
        Me.grpItens.Location = New System.Drawing.Point(3, 107)
        Me.grpItens.Name = "grpItens"
        Me.grpItens.Size = New System.Drawing.Size(783, 364)
        Me.grpItens.TabIndex = 4
        Me.grpItens.Text = "Itens da Receita"
        '
        'PedidoGridControl
        '
        Me.PedidoGridControl.DataMember = "tbItens"
        Me.PedidoGridControl.DataSource = Me.dsItens
        Me.PedidoGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PedidoGridControl.EmbeddedNavigator.Name = ""
        Me.PedidoGridControl.Location = New System.Drawing.Point(2, 20)
        Me.PedidoGridControl.LookAndFeel.SkinName = "Black"
        Me.PedidoGridControl.MainView = Me.grd1
        Me.PedidoGridControl.Name = "PedidoGridControl"
        Me.PedidoGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlt})
        Me.PedidoGridControl.Size = New System.Drawing.Size(779, 321)
        Me.PedidoGridControl.TabIndex = 7
        Me.PedidoGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsItens
        '
        Me.dsItens.DataSetName = "NewDataSet"
        Me.dsItens.Tables.AddRange(New System.Data.DataTable() {Me.tbItens})
        '
        'tbItens
        '
        Me.tbItens.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn10, Me.DataColumn11, Me.DataColumn9, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16})
        Me.tbItens.TableName = "tbItens"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "CodigoProduto"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Produto"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Qtd"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "ValorUnitario"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "ValorTotal"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "TabelaPreco"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "CodigoInterno"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "CodPedAut"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Custo"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "UM"
        '
        'DataColumn9
        '
        Me.DataColumn9.Caption = "Peso"
        Me.DataColumn9.ColumnName = "Peso"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "UniSemDesc"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "Tamanho"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "Valor"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "TipoValor"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "QtdEstoque"
        '
        'grd1
        '
        Me.grd1.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.grd1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.grd1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grd1.Appearance.FocusedCell.Options.UseForeColor = True
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
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colQtd, Me.colCodigoProduto, Me.colProduto, Me.colValorUnitario, Me.colValorTotal, Me.colCodigoPeca, Me.colCodPedAut, Me.colCusto, Me.colUM, Me.colValor, Me.colTipoValor, Me.colQtdEstoque})
        Me.grd1.GridControl = Me.PedidoGridControl
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colQtd
        '
        Me.colQtd.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colQtd.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colQtd.AppearanceCell.Options.UseBackColor = True
        Me.colQtd.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtd.Caption = "Qtde"
        Me.colQtd.ColumnEdit = Me.txtAlt
        Me.colQtd.FieldName = "Qtd"
        Me.colQtd.Name = "colQtd"
        Me.colQtd.OptionsColumn.ReadOnly = True
        Me.colQtd.Visible = True
        Me.colQtd.VisibleIndex = 3
        Me.colQtd.Width = 72
        '
        'txtAlt
        '
        Me.txtAlt.AutoHeight = False
        Me.txtAlt.Name = "txtAlt"
        '
        'colCodigoProduto
        '
        Me.colCodigoProduto.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colCodigoProduto.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodigoProduto.AppearanceCell.Options.UseBackColor = True
        Me.colCodigoProduto.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoProduto.Caption = "Código"
        Me.colCodigoProduto.ColumnEdit = Me.txtAlt
        Me.colCodigoProduto.FieldName = "CodigoProduto"
        Me.colCodigoProduto.Name = "colCodigoProduto"
        Me.colCodigoProduto.OptionsColumn.ReadOnly = True
        Me.colCodigoProduto.Width = 56
        '
        'colProduto
        '
        Me.colProduto.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colProduto.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colProduto.AppearanceCell.Options.UseBackColor = True
        Me.colProduto.Caption = "Produto"
        Me.colProduto.ColumnEdit = Me.txtAlt
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 1
        Me.colProduto.Width = 342
        '
        'colValorUnitario
        '
        Me.colValorUnitario.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colValorUnitario.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colValorUnitario.AppearanceCell.Options.UseBackColor = True
        Me.colValorUnitario.AppearanceCell.Options.UseTextOptions = True
        Me.colValorUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorUnitario.Caption = "Valor Unit. R$"
        Me.colValorUnitario.ColumnEdit = Me.txtAlt
        Me.colValorUnitario.FieldName = "ValorUnitario"
        Me.colValorUnitario.Name = "colValorUnitario"
        Me.colValorUnitario.OptionsColumn.ReadOnly = True
        Me.colValorUnitario.Width = 94
        '
        'colValorTotal
        '
        Me.colValorTotal.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colValorTotal.AppearanceCell.Options.UseBackColor = True
        Me.colValorTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colValorTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorTotal.Caption = "Valor Total R$"
        Me.colValorTotal.ColumnEdit = Me.txtAlt
        Me.colValorTotal.FieldName = "ValorTotal"
        Me.colValorTotal.Name = "colValorTotal"
        Me.colValorTotal.OptionsColumn.ReadOnly = True
        Me.colValorTotal.Width = 112
        '
        'colCodigoPeca
        '
        Me.colCodigoPeca.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colCodigoPeca.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodigoPeca.AppearanceCell.Options.UseBackColor = True
        Me.colCodigoPeca.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoPeca.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoPeca.Caption = "Código"
        Me.colCodigoPeca.ColumnEdit = Me.txtAlt
        Me.colCodigoPeca.FieldName = "CodigoInterno"
        Me.colCodigoPeca.Name = "colCodigoPeca"
        Me.colCodigoPeca.OptionsColumn.ReadOnly = True
        Me.colCodigoPeca.Visible = True
        Me.colCodigoPeca.VisibleIndex = 0
        Me.colCodigoPeca.Width = 101
        '
        'colCodPedAut
        '
        Me.colCodPedAut.Caption = "CodPedAut"
        Me.colCodPedAut.ColumnEdit = Me.txtAlt
        Me.colCodPedAut.FieldName = "CodPedAut"
        Me.colCodPedAut.Name = "colCodPedAut"
        Me.colCodPedAut.OptionsColumn.ReadOnly = True
        Me.colCodPedAut.Width = 76
        '
        'colCusto
        '
        Me.colCusto.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colCusto.AppearanceCell.Options.UseBackColor = True
        Me.colCusto.AppearanceCell.Options.UseTextOptions = True
        Me.colCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCusto.Caption = "Tot. R$"
        Me.colCusto.ColumnEdit = Me.txtAlt
        Me.colCusto.FieldName = "Custo"
        Me.colCusto.Name = "colCusto"
        Me.colCusto.OptionsColumn.ReadOnly = True
        Me.colCusto.Visible = True
        Me.colCusto.VisibleIndex = 5
        Me.colCusto.Width = 93
        '
        'colUM
        '
        Me.colUM.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colUM.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colUM.AppearanceCell.Options.UseBackColor = True
        Me.colUM.AppearanceCell.Options.UseTextOptions = True
        Me.colUM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUM.Caption = "U.M."
        Me.colUM.ColumnEdit = Me.txtAlt
        Me.colUM.FieldName = "UM"
        Me.colUM.Name = "colUM"
        Me.colUM.OptionsColumn.ReadOnly = True
        Me.colUM.Visible = True
        Me.colUM.VisibleIndex = 2
        Me.colUM.Width = 51
        '
        'colValor
        '
        Me.colValor.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colValor.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colValor.AppearanceCell.Options.UseBackColor = True
        Me.colValor.AppearanceCell.Options.UseTextOptions = True
        Me.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor.Caption = "Unit. R$"
        Me.colValor.ColumnEdit = Me.txtAlt
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.OptionsColumn.ReadOnly = True
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 4
        Me.colValor.Width = 99
        '
        'colTipoValor
        '
        Me.colTipoValor.Caption = "TipoValor"
        Me.colTipoValor.FieldName = "TipoValor"
        Me.colTipoValor.Name = "colTipoValor"
        '
        'colQtdEstoque
        '
        Me.colQtdEstoque.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colQtdEstoque.AppearanceCell.Options.UseBackColor = True
        Me.colQtdEstoque.AppearanceCell.Options.UseTextOptions = True
        Me.colQtdEstoque.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtdEstoque.Caption = "Qtd Est."
        Me.colQtdEstoque.FieldName = "QtdEstoque"
        Me.colQtdEstoque.Name = "colQtdEstoque"
        Me.colQtdEstoque.OptionsColumn.ReadOnly = True
        Me.colQtdEstoque.Visible = True
        Me.colQtdEstoque.VisibleIndex = 6
        '
        'btnDelete
        '
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnDelete.Location = New System.Drawing.Point(2, 341)
        Me.btnDelete.LookAndFeel.SkinName = "Money Twins"
        Me.btnDelete.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(779, 21)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Excluir"
        '
        'grdDesc
        '
        Me.grdDesc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDesc.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdDesc.AppearanceCaption.ForeColor = System.Drawing.Color.Black
        Me.grdDesc.AppearanceCaption.Options.UseFont = True
        Me.grdDesc.AppearanceCaption.Options.UseForeColor = True
        Me.grdDesc.Controls.Add(Me.txtDesc)
        Me.grdDesc.Location = New System.Drawing.Point(3, 476)
        Me.grdDesc.Name = "grdDesc"
        Me.grdDesc.Size = New System.Drawing.Size(1001, 152)
        Me.grdDesc.TabIndex = 5
        Me.grdDesc.Text = "Modo de Preparo"
        '
        'txtDesc
        '
        Me.txtDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDesc.Location = New System.Drawing.Point(2, 20)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesc.Size = New System.Drawing.Size(997, 130)
        Me.txtDesc.TabIndex = 0
        '
        'bmComandos
        '
        Me.bmComandos.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.bmComandos.DockControls.Add(Me.barDockControlTop)
        Me.bmComandos.DockControls.Add(Me.barDockControlBottom)
        Me.bmComandos.DockControls.Add(Me.barDockControlLeft)
        Me.bmComandos.DockControls.Add(Me.barDockControlRight)
        Me.bmComandos.Form = Me
        Me.bmComandos.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSalvar, Me.btnLimpar, Me.btnCancelar, Me.btnVisuImp, Me.btnMontarKit, Me.bsiKit, Me.btnDesmontar, Me.btnSalvarMontar})
        Me.bmComandos.MaxItemId = 15
        Me.bmComandos.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.Caption Or DevExpress.XtraBars.BarLinkUserDefines.PaintStyle), DevExpress.XtraBars.BarLinkUserDefines), Me.btnVisuImp, "Visualizar", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bsiKit, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvarMontar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCancelar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnVisuImp
        '
        Me.btnVisuImp.Caption = "&Visualizar"
        Me.btnVisuImp.Glyph = Global.Nano.My.Resources.Resources.lupa
        Me.btnVisuImp.Id = 3
        Me.btnVisuImp.Name = "btnVisuImp"
        '
        'bsiKit
        '
        Me.bsiKit.Caption = "Montar/Desmontar Kit"
        Me.bsiKit.Glyph = Global.Nano.My.Resources.Resources.Alterar
        Me.bsiKit.Id = 12
        Me.bsiKit.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnMontarKit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDesmontar)})
        Me.bsiKit.Name = "bsiKit"
        Me.bsiKit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnMontarKit
        '
        Me.btnMontarKit.Caption = "&Montar"
        Me.btnMontarKit.Glyph = Global.Nano.My.Resources.Resources.Alterar
        Me.btnMontarKit.Id = 11
        Me.btnMontarKit.Name = "btnMontarKit"
        '
        'btnDesmontar
        '
        Me.btnDesmontar.Caption = "&Desmontar"
        Me.btnDesmontar.Glyph = Global.Nano.My.Resources.Resources.Alterar
        Me.btnDesmontar.Id = 13
        Me.btnDesmontar.Name = "btnDesmontar"
        '
        'btnSalvarMontar
        '
        Me.btnSalvarMontar.Caption = "&Montar Kit"
        Me.btnSalvarMontar.Glyph = Global.Nano.My.Resources.Resources.Alterar
        Me.btnSalvarMontar.Id = 14
        Me.btnSalvarMontar.Name = "btnSalvarMontar"
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar.Caption = "F6 &Salvar"
        Me.btnSalvar.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvar.Id = 0
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnLimpar
        '
        Me.btnLimpar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnLimpar.Caption = "&Limpar"
        Me.btnLimpar.Glyph = Global.Nano.My.Resources.Resources.Comando_Limpar_32x32
        Me.btnLimpar.Id = 1
        Me.btnLimpar.Name = "btnLimpar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnCancelar.Caption = "&Fechar"
        Me.btnCancelar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnCancelar.Id = 2
        Me.btnCancelar.Name = "btnCancelar"
        '
        'grpVal
        '
        Me.grpVal.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpVal.AppearanceCaption.ForeColor = System.Drawing.Color.Black
        Me.grpVal.AppearanceCaption.Options.UseFont = True
        Me.grpVal.AppearanceCaption.Options.UseForeColor = True
        Me.grpVal.Controls.Add(Me.txtTotalItens)
        Me.grpVal.Controls.Add(Me.txtTotalCusto)
        Me.grpVal.Controls.Add(Me.LabelControl1)
        Me.grpVal.Controls.Add(Me.txtQtdKit)
        Me.grpVal.Controls.Add(Me.Label1)
        Me.grpVal.Controls.Add(Me.PanelControl1)
        Me.grpVal.Controls.Add(Me.lblPor)
        Me.grpVal.Controls.Add(Me.txtPorcentagem)
        Me.grpVal.Controls.Add(Label11)
        Me.grpVal.Controls.Add(Me.lblValDesc)
        Me.grpVal.Controls.Add(Me.txtValorVenda)
        Me.grpVal.Controls.Add(Me.lblDesc)
        Me.grpVal.Controls.Add(Label5)
        Me.grpVal.Controls.Add(Me.pcLinha)
        Me.grpVal.Controls.Add(Label10)
        Me.grpVal.Location = New System.Drawing.Point(790, 107)
        Me.grpVal.Name = "grpVal"
        Me.grpVal.Size = New System.Drawing.Size(214, 364)
        Me.grpVal.TabIndex = 5
        Me.grpVal.Text = "Valores da Receita"
        '
        'txtTotalCusto
        '
        Me.txtTotalCusto.EditValue = ""
        Me.txtTotalCusto.EnterMoveNextControl = True
        Me.txtTotalCusto.Location = New System.Drawing.Point(13, 46)
        Me.txtTotalCusto.Name = "txtTotalCusto"
        Me.txtTotalCusto.Properties.Appearance.BackColor = System.Drawing.Color.Blue
        Me.txtTotalCusto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCusto.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtTotalCusto.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalCusto.Properties.Appearance.Options.UseFont = True
        Me.txtTotalCusto.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotalCusto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalCusto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalCusto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Blue
        Me.txtTotalCusto.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalCusto.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtTotalCusto.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotalCusto.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTotalCusto.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotalCusto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalCusto.Properties.MaxLength = 13
        Me.txtTotalCusto.Properties.ReadOnly = True
        Me.txtTotalCusto.Size = New System.Drawing.Size(192, 35)
        Me.txtTotalCusto.TabIndex = 80
        Me.txtTotalCusto.Tag = "Desconto %"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(18, 236)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(36, 18)
        Me.LabelControl1.TabIndex = 78
        Me.LabelControl1.Text = "Qtde"
        Me.LabelControl1.Visible = False
        '
        'txtQtdKit
        '
        Me.txtQtdKit.EditValue = ""
        Me.txtQtdKit.EnterMoveNextControl = True
        Me.txtQtdKit.Location = New System.Drawing.Point(13, 255)
        Me.txtQtdKit.Name = "txtQtdKit"
        Me.txtQtdKit.Properties.Appearance.BackColor = System.Drawing.Color.Blue
        Me.txtQtdKit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdKit.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtQtdKit.Properties.Appearance.Options.UseBackColor = True
        Me.txtQtdKit.Properties.Appearance.Options.UseFont = True
        Me.txtQtdKit.Properties.Appearance.Options.UseForeColor = True
        Me.txtQtdKit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtdKit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtdKit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Blue
        Me.txtQtdKit.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtQtdKit.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtQtdKit.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtQtdKit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQtdKit.Properties.MaxLength = 13
        Me.txtQtdKit.Size = New System.Drawing.Size(192, 35)
        Me.txtQtdKit.TabIndex = 77
        Me.txtQtdKit.Tag = "Venda %"
        Me.txtQtdKit.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(13, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 14)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Kit"
        Me.Label1.Visible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Location = New System.Drawing.Point(9, 225)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(200, 5)
        Me.PanelControl1.TabIndex = 75
        Me.PanelControl1.Visible = False
        '
        'lblPor
        '
        Me.lblPor.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPor.Appearance.Options.UseFont = True
        Me.lblPor.Location = New System.Drawing.Point(18, 159)
        Me.lblPor.Name = "lblPor"
        Me.lblPor.Size = New System.Drawing.Size(18, 18)
        Me.lblPor.TabIndex = 74
        Me.lblPor.Text = "%"
        '
        'txtPorcentagem
        '
        Me.txtPorcentagem.EditValue = ""
        Me.txtPorcentagem.EnterMoveNextControl = True
        Me.txtPorcentagem.Location = New System.Drawing.Point(13, 178)
        Me.txtPorcentagem.Name = "txtPorcentagem"
        Me.txtPorcentagem.Properties.Appearance.BackColor = System.Drawing.Color.Blue
        Me.txtPorcentagem.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcentagem.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtPorcentagem.Properties.Appearance.Options.UseBackColor = True
        Me.txtPorcentagem.Properties.Appearance.Options.UseFont = True
        Me.txtPorcentagem.Properties.Appearance.Options.UseForeColor = True
        Me.txtPorcentagem.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPorcentagem.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPorcentagem.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Blue
        Me.txtPorcentagem.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtPorcentagem.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtPorcentagem.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtPorcentagem.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPorcentagem.Properties.MaxLength = 13
        Me.txtPorcentagem.Size = New System.Drawing.Size(192, 35)
        Me.txtPorcentagem.TabIndex = 1
        Me.txtPorcentagem.Tag = "Venda %"
        '
        'lblValDesc
        '
        Me.lblValDesc.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValDesc.Appearance.Options.UseFont = True
        Me.lblValDesc.Location = New System.Drawing.Point(18, 102)
        Me.lblValDesc.Name = "lblValDesc"
        Me.lblValDesc.Size = New System.Drawing.Size(65, 18)
        Me.lblValDesc.TabIndex = 72
        Me.lblValDesc.Text = "Valor R$"
        '
        'txtValorVenda
        '
        Me.txtValorVenda.EditValue = ""
        Me.txtValorVenda.EnterMoveNextControl = True
        Me.txtValorVenda.Location = New System.Drawing.Point(13, 121)
        Me.txtValorVenda.Name = "txtValorVenda"
        Me.txtValorVenda.Properties.Appearance.BackColor = System.Drawing.Color.Blue
        Me.txtValorVenda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorVenda.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtValorVenda.Properties.Appearance.Options.UseBackColor = True
        Me.txtValorVenda.Properties.Appearance.Options.UseFont = True
        Me.txtValorVenda.Properties.Appearance.Options.UseForeColor = True
        Me.txtValorVenda.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValorVenda.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValorVenda.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Blue
        Me.txtValorVenda.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtValorVenda.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtValorVenda.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtValorVenda.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValorVenda.Properties.MaxLength = 13
        Me.txtValorVenda.Size = New System.Drawing.Size(192, 35)
        Me.txtValorVenda.TabIndex = 0
        Me.txtValorVenda.Tag = "Valor Venda"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.ForeColor = System.Drawing.Color.Blue
        Me.lblDesc.Location = New System.Drawing.Point(13, 86)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(45, 14)
        Me.lblDesc.TabIndex = 69
        Me.lblDesc.Text = "Venda"
        '
        'pcLinha
        '
        Me.pcLinha.Location = New System.Drawing.Point(9, 92)
        Me.pcLinha.Name = "pcLinha"
        Me.pcLinha.Size = New System.Drawing.Size(200, 5)
        Me.pcLinha.TabIndex = 59
        '
        'btnConsulta
        '
        Me.btnConsulta.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.btnConsulta.Location = New System.Drawing.Point(163, 10)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(21, 21)
        Me.btnConsulta.TabIndex = 83
        Me.btnConsulta.ToolTipTitle = "Consulta de Pedido"
        '
        'txtNome
        '
        Me.txtNome.CasasDecimais = 0
        Me.txtNome.EnterMoveNextControl = True
        Me.txtNome.Location = New System.Drawing.Point(245, 11)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Numerico = False
        Me.txtNome.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNome.Properties.Appearance.Options.UseFont = True
        Me.txtNome.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtNome.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNome.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNome.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNome.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtNome.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNome.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNome.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNome.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNome.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtNome.Properties.MaxLength = 100
        Me.txtNome.Size = New System.Drawing.Size(308, 20)
        Me.txtNome.TabIndex = 1
        Me.txtNome.Tag = "Produto"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(212, 14)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl2.TabIndex = 85
        Me.LabelControl2.Text = "Nome"
        '
        'btnCadGrp
        '
        Me.btnCadGrp.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnCadGrp.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCadGrp.Location = New System.Drawing.Point(975, 11)
        Me.btnCadGrp.Name = "btnCadGrp"
        Me.btnCadGrp.Size = New System.Drawing.Size(20, 20)
        Me.btnCadGrp.TabIndex = 86
        Me.btnCadGrp.Text = "SimpleButton1"
        '
        'cboGrp
        '
        Me.cboGrp.EnterMoveNextControl = True
        Me.cboGrp.Location = New System.Drawing.Point(808, 11)
        Me.cboGrp.Name = "cboGrp"
        Me.cboGrp.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboGrp.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboGrp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGrp.Properties.MaxLength = 55
        Me.cboGrp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboGrp.Size = New System.Drawing.Size(167, 20)
        Me.cboGrp.TabIndex = 3
        Me.cboGrp.Tag = "Grupo"
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(773, 14)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl20.TabIndex = 88
        Me.LabelControl20.Text = "Grupo"
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(570, 15)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl18.TabIndex = 117
        Me.LabelControl18.Text = "Setor"
        '
        'btnCadSet
        '
        Me.btnCadSet.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnCadSet.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCadSet.Location = New System.Drawing.Point(743, 11)
        Me.btnCadSet.Name = "btnCadSet"
        Me.btnCadSet.Size = New System.Drawing.Size(20, 20)
        Me.btnCadSet.TabIndex = 116
        Me.btnCadSet.Text = "SimpleButton1"
        '
        'cboSet
        '
        Me.cboSet.EnterMoveNextControl = True
        Me.cboSet.Location = New System.Drawing.Point(602, 11)
        Me.cboSet.Name = "cboSet"
        Me.cboSet.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboSet.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboSet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSet.Properties.MaxLength = 55
        Me.cboSet.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboSet.Size = New System.Drawing.Size(141, 20)
        Me.cboSet.TabIndex = 2
        Me.cboSet.Tag = "Grupo"
        '
        'Timer1
        '
        '
        'chkAlterar
        '
        Me.chkAlterar.Location = New System.Drawing.Point(161, 12)
        Me.chkAlterar.Name = "chkAlterar"
        Me.chkAlterar.Properties.Caption = ""
        Me.chkAlterar.Size = New System.Drawing.Size(18, 19)
        Me.chkAlterar.TabIndex = 118
        Me.chkAlterar.ToolTip = "Selecione para alterar o código"
        Me.chkAlterar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.chkAlterar.ToolTipTitle = "Alterar Código"
        Me.chkAlterar.Visible = False
        '
        'txtTotalItens
        '
        Me.txtTotalItens.EditValue = ""
        Me.txtTotalItens.EnterMoveNextControl = True
        Me.txtTotalItens.Location = New System.Drawing.Point(13, 323)
        Me.txtTotalItens.Name = "txtTotalItens"
        Me.txtTotalItens.Properties.Appearance.BackColor = System.Drawing.Color.Blue
        Me.txtTotalItens.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalItens.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtTotalItens.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalItens.Properties.Appearance.Options.UseFont = True
        Me.txtTotalItens.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotalItens.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalItens.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalItens.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Blue
        Me.txtTotalItens.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalItens.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtTotalItens.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotalItens.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTotalItens.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotalItens.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalItens.Properties.MaxLength = 13
        Me.txtTotalItens.Properties.ReadOnly = True
        Me.txtTotalItens.Size = New System.Drawing.Size(192, 35)
        Me.txtTotalItens.TabIndex = 81
        Me.txtTotalItens.Tag = "Desconto %"
        '
        'frmReceita
        '
        Me.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 664)
        Me.Controls.Add(Me.chkAlterar)
        Me.Controls.Add(Me.LabelControl18)
        Me.Controls.Add(Me.btnCadSet)
        Me.Controls.Add(Me.cboSet)
        Me.Controls.Add(Me.btnCadGrp)
        Me.Controls.Add(Me.cboGrp)
        Me.Controls.Add(Me.LabelControl20)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.grdDesc)
        Me.Controls.Add(Me.grpVal)
        Me.Controls.Add(Me.grpItens)
        Me.Controls.Add(Me.grpProd)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.lblCodPed)
        Me.Controls.Add(Me.txtCodReceita)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmReceita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Receita"
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodReceita.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProd.ResumeLayout(False)
        Me.grpProd.PerformLayout()
        CType(Me.rgpTipoValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomePro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodPro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAlterado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpItens.ResumeLayout(False)
        CType(Me.PedidoGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsItens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbItens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDesc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdDesc.ResumeLayout(False)
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bmComandos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpVal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpVal.ResumeLayout(False)
        Me.grpVal.PerformLayout()
        CType(Me.txtTotalCusto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtdKit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcentagem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorVenda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcLinha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAlterar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalItens.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodReceita As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCodPed As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpProd As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpItens As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bmComandos As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents grpVal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtQtd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnVisuImp As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pcLinha As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grdDesc As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDesc As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtCodPro As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtNomePro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dsItens As System.Data.DataSet
    Friend WithEvents tbItens As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents PedidoGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colQtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAlt As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colCodigoProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoPeca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodPedAut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblValDesc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValorVenda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents colCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnConsulta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents colUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents chkAlterado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtNome As Campos.NanoCampo
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPorcentagem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCadGrp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboGrp As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCadSet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboSet As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents rgpTipoValor As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents colTipoValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQtdKit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnMontarKit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsiKit As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnDesmontar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colQtdEstoque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSalvarMontar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents chkAlterar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtTotalCusto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalItens As DevExpress.XtraEditors.TextEdit
End Class
