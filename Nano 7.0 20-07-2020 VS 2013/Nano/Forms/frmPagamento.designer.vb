<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagamento
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
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagamento))
        Me.colIrCaixa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colCartao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkCart = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.PagamentoGridControl = New DevExpress.XtraGrid.GridControl
        Me.BancoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescricao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDias = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDesconto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFormaPagamento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBanco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumDias = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUsaTEF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.txtDias = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.txtDes = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.cboForma = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.btnAlterar = New DevExpress.XtraBars.BarButtonItem
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem
        Me.btnCancelar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.cboPag = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtNDias = New Campos.NanoCampo
        Me.txtDescricao = New Campos.NanoCampo
        Me.txtDesconto = New Campos.NanoCampo
        Me.lueBanco = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.rdgCar = New DevExpress.XtraEditors.RadioGroup
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.rdgIr = New DevExpress.XtraEditors.RadioGroup
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btnCadBanco = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.seDias = New DevExpress.XtraEditors.SpinEdit
        Me.BancoTableAdapter = New Nano.dsNanoCommerceTableAdapters.BancoTableAdapter
        Me.rdgUsaTEF = New DevExpress.XtraEditors.RadioGroup
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagamentoGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboForma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPag.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNDias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescricao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesconto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueBanco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgCar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgIr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.seDias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgUsaTEF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colIrCaixa
        '
        Me.colIrCaixa.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colIrCaixa.AppearanceCell.Options.UseFont = True
        Me.colIrCaixa.AppearanceCell.Options.UseTextOptions = True
        Me.colIrCaixa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIrCaixa.Caption = "Ir Caixa?"
        Me.colIrCaixa.ColumnEdit = Me.txtAlterar
        Me.colIrCaixa.FieldName = "IrCaixa"
        Me.colIrCaixa.Name = "colIrCaixa"
        Me.colIrCaixa.OptionsColumn.ReadOnly = True
        Me.colIrCaixa.Visible = True
        Me.colIrCaixa.VisibleIndex = 3
        Me.colIrCaixa.Width = 64
        '
        'txtAlterar
        '
        Me.txtAlterar.AutoHeight = False
        Me.txtAlterar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAlterar.MaxLength = 15
        Me.txtAlterar.Name = "txtAlterar"
        '
        'colCartao
        '
        Me.colCartao.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCartao.AppearanceCell.Options.UseFont = True
        Me.colCartao.Caption = "Cartão?"
        Me.colCartao.ColumnEdit = Me.chkCart
        Me.colCartao.FieldName = "Prazo"
        Me.colCartao.Name = "colCartao"
        Me.colCartao.OptionsColumn.ReadOnly = True
        Me.colCartao.Visible = True
        Me.colCartao.VisibleIndex = 4
        Me.colCartao.Width = 58
        '
        'chkCart
        '
        Me.chkCart.AutoHeight = False
        Me.chkCart.Name = "chkCart"
        Me.chkCart.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'PagamentoGridControl
        '
        Me.PagamentoGridControl.DataSource = Me.BancoBindingSource
        Me.PagamentoGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PagamentoGridControl.EmbeddedNavigator.Name = ""
        Me.PagamentoGridControl.Location = New System.Drawing.Point(2, 20)
        Me.PagamentoGridControl.MainView = Me.grd1
        Me.PagamentoGridControl.Name = "PagamentoGridControl"
        Me.PagamentoGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.txtAlterar, Me.txtDias, Me.txtDes, Me.cboForma, Me.chkCart, Me.RepositoryItemCheckEdit2})
        Me.PagamentoGridControl.Size = New System.Drawing.Size(1004, 312)
        Me.PagamentoGridControl.TabIndex = 8
        Me.PagamentoGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'BancoBindingSource
        '
        Me.BancoBindingSource.DataMember = "Banco"
        Me.BancoBindingSource.DataSource = Me.DsNanoCommerce
        '
        'DsNanoCommerce
        '
        Me.DsNanoCommerce.DataSetName = "dsNanoCommerce"
        Me.DsNanoCommerce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescricao, Me.colDias, Me.colDesconto, Me.colCartao, Me.colFormaPagamento, Me.colIrCaixa, Me.colBanco, Me.colNumDias, Me.colUsaTEF})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Moccasin
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Column = Me.colIrCaixa
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "SIM"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Column = Me.colCartao
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = True
        Me.grd1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.grd1.GridControl = Me.PagamentoGridControl
        Me.grd1.Name = "grd1"
        Me.grd1.NewItemRowText = "Adicione aqui um novo registro"
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCodigo.AppearanceCell.Options.UseFont = True
        Me.colCodigo.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigo.Caption = "Código Automático"
        Me.colCodigo.ColumnEdit = Me.txtAlterar
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        Me.colCodigo.Width = 112
        '
        'colDescricao
        '
        Me.colDescricao.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDescricao.AppearanceCell.Options.UseFont = True
        Me.colDescricao.Caption = "Descrição"
        Me.colDescricao.ColumnEdit = Me.txtAlterar
        Me.colDescricao.FieldName = "Descricao"
        Me.colDescricao.Name = "colDescricao"
        Me.colDescricao.OptionsColumn.ReadOnly = True
        Me.colDescricao.Visible = True
        Me.colDescricao.VisibleIndex = 0
        Me.colDescricao.Width = 241
        '
        'colDias
        '
        Me.colDias.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDias.AppearanceCell.Options.UseFont = True
        Me.colDias.AppearanceCell.Options.UseTextOptions = True
        Me.colDias.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDias.Caption = "N° Dias em Conta"
        Me.colDias.ColumnEdit = Me.txtAlterar
        Me.colDias.FieldName = "Dias"
        Me.colDias.Name = "colDias"
        Me.colDias.OptionsColumn.ReadOnly = True
        Me.colDias.Visible = True
        Me.colDias.VisibleIndex = 5
        Me.colDias.Width = 106
        '
        'colDesconto
        '
        Me.colDesconto.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDesconto.AppearanceCell.Options.UseFont = True
        Me.colDesconto.AppearanceCell.Options.UseTextOptions = True
        Me.colDesconto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDesconto.Caption = "% Taxa Cartão"
        Me.colDesconto.ColumnEdit = Me.txtAlterar
        Me.colDesconto.FieldName = "Desconto"
        Me.colDesconto.Name = "colDesconto"
        Me.colDesconto.OptionsColumn.ReadOnly = True
        Me.colDesconto.Visible = True
        Me.colDesconto.VisibleIndex = 6
        Me.colDesconto.Width = 96
        '
        'colFormaPagamento
        '
        Me.colFormaPagamento.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colFormaPagamento.AppearanceCell.Options.UseFont = True
        Me.colFormaPagamento.AppearanceCell.Options.UseTextOptions = True
        Me.colFormaPagamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFormaPagamento.Caption = "A Vista/A Prazo"
        Me.colFormaPagamento.ColumnEdit = Me.txtAlterar
        Me.colFormaPagamento.FieldName = "FormaPagamento"
        Me.colFormaPagamento.Name = "colFormaPagamento"
        Me.colFormaPagamento.OptionsColumn.ReadOnly = True
        Me.colFormaPagamento.Visible = True
        Me.colFormaPagamento.VisibleIndex = 1
        Me.colFormaPagamento.Width = 98
        '
        'colBanco
        '
        Me.colBanco.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colBanco.AppearanceCell.Options.UseFont = True
        Me.colBanco.Caption = "Banco"
        Me.colBanco.ColumnEdit = Me.txtAlterar
        Me.colBanco.FieldName = "Nome"
        Me.colBanco.Name = "colBanco"
        Me.colBanco.Visible = True
        Me.colBanco.VisibleIndex = 7
        Me.colBanco.Width = 142
        '
        'colNumDias
        '
        Me.colNumDias.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumDias.AppearanceCell.Options.UseFont = True
        Me.colNumDias.AppearanceCell.Options.UseTextOptions = True
        Me.colNumDias.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumDias.Caption = "Dias Entre Parc."
        Me.colNumDias.ColumnEdit = Me.txtAlterar
        Me.colNumDias.FieldName = "NumDias"
        Me.colNumDias.Name = "colNumDias"
        Me.colNumDias.OptionsColumn.ReadOnly = True
        Me.colNumDias.Visible = True
        Me.colNumDias.VisibleIndex = 2
        Me.colNumDias.Width = 99
        '
        'colUsaTEF
        '
        Me.colUsaTEF.Caption = "Usa TEF?"
        Me.colUsaTEF.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.colUsaTEF.FieldName = "UsaTEF"
        Me.colUsaTEF.Name = "colUsaTEF"
        Me.colUsaTEF.OptionsColumn.ReadOnly = True
        Me.colUsaTEF.Visible = True
        Me.colUsaTEF.VisibleIndex = 8
        Me.colUsaTEF.Width = 79
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'txtDias
        '
        Me.txtDias.AutoHeight = False
        Me.txtDias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDias.MaxLength = 3
        Me.txtDias.Name = "txtDias"
        '
        'txtDes
        '
        Me.txtDes.AutoHeight = False
        Me.txtDes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDes.MaxLength = 5
        Me.txtDes.Name = "txtDes"
        '
        'cboForma
        '
        Me.cboForma.AutoHeight = False
        Me.cboForma.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboForma.Items.AddRange(New Object() {"A VISTA", "A PRAZO"})
        Me.cboForma.Name = "cboForma"
        Me.cboForma.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSalvar, Me.btnCancelar, Me.btnExcluir, Me.btnAlterar, Me.btnLimpar})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExcluir, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAlterar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCancelar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnExcluir
        '
        Me.btnExcluir.Caption = "&Excluir"
        Me.btnExcluir.Glyph = Global.Nano.My.Resources.Resources.delete
        Me.btnExcluir.Id = 2
        Me.btnExcluir.Name = "btnExcluir"
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar.Caption = "&Salvar"
        Me.btnSalvar.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvar.Id = 0
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnAlterar
        '
        Me.btnAlterar.Caption = "&Alterar"
        Me.btnAlterar.Glyph = Global.Nano.My.Resources.Resources.Alterar
        Me.btnAlterar.Id = 3
        Me.btnAlterar.Name = "btnAlterar"
        '
        'btnLimpar
        '
        Me.btnLimpar.Caption = "&Limpar"
        Me.btnLimpar.Glyph = Global.Nano.My.Resources.Resources.Comando_Limpar_32x32
        Me.btnLimpar.Id = 4
        Me.btnLimpar.Name = "btnLimpar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnCancelar.Caption = "&Fechar"
        Me.btnCancelar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnCancelar.Id = 1
        Me.btnCancelar.Name = "btnCancelar"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(8, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Descrição"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(539, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "A Vista/A Prazo"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(355, 38)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "% Taxa Cartão"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(166, 38)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "N° Dias em Conta"
        '
        'cboPag
        '
        Me.cboPag.EnterMoveNextControl = True
        Me.cboPag.Location = New System.Drawing.Point(619, 9)
        Me.cboPag.Name = "cboPag"
        Me.cboPag.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboPag.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboPag.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPag.Properties.Items.AddRange(New Object() {"A VISTA", "A PRAZO"})
        Me.cboPag.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboPag.Size = New System.Drawing.Size(90, 20)
        Me.cboPag.TabIndex = 1
        Me.cboPag.Tag = "Pagamento"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(853, 12)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "Ir Caixa?"
        '
        'txtNDias
        '
        Me.txtNDias.CasasDecimais = 0
        Me.txtNDias.Enabled = False
        Me.txtNDias.EnterMoveNextControl = True
        Me.txtNDias.Location = New System.Drawing.Point(256, 35)
        Me.txtNDias.Name = "txtNDias"
        Me.txtNDias.Numerico = True
        Me.txtNDias.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNDias.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNDias.Properties.MaxLength = 3
        Me.txtNDias.Size = New System.Drawing.Size(90, 20)
        Me.txtNDias.TabIndex = 5
        Me.txtNDias.Tag = "Nº Dias"
        '
        'txtDescricao
        '
        Me.txtDescricao.CasasDecimais = 0
        Me.txtDescricao.EnterMoveNextControl = True
        Me.txtDescricao.Location = New System.Drawing.Point(60, 9)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Numerico = False
        Me.txtDescricao.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDescricao.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDescricao.Properties.MaxLength = 20
        Me.txtDescricao.Size = New System.Drawing.Size(465, 20)
        Me.txtDescricao.TabIndex = 0
        Me.txtDescricao.Tag = "Descrição"
        '
        'txtDesconto
        '
        Me.txtDesconto.CasasDecimais = 4
        Me.txtDesconto.Enabled = False
        Me.txtDesconto.EnterMoveNextControl = True
        Me.txtDesconto.Location = New System.Drawing.Point(435, 35)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Numerico = True
        Me.txtDesconto.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDesconto.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDesconto.Properties.MaxLength = 7
        Me.txtDesconto.Size = New System.Drawing.Size(90, 20)
        Me.txtDesconto.TabIndex = 6
        Me.txtDesconto.Tag = "% Desc."
        '
        'lueBanco
        '
        Me.lueBanco.Enabled = False
        Me.lueBanco.Location = New System.Drawing.Point(619, 35)
        Me.lueBanco.Name = "lueBanco"
        Me.lueBanco.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueBanco.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 30, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueBanco.Properties.DataSource = Me.BancoBindingSource
        Me.lueBanco.Properties.DisplayMember = "Nome"
        Me.lueBanco.Properties.NullText = ""
        Me.lueBanco.Properties.ValueMember = "Codigo"
        Me.lueBanco.Size = New System.Drawing.Size(200, 20)
        Me.lueBanco.TabIndex = 7
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(584, 38)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl6.TabIndex = 19
        Me.LabelControl6.Text = "Banco"
        '
        'rdgCar
        '
        Me.rdgCar.Location = New System.Drawing.Point(60, 35)
        Me.rdgCar.Name = "rdgCar"
        Me.rdgCar.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdgCar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgCar.Properties.Appearance.Options.UseBackColor = True
        Me.rdgCar.Properties.Appearance.Options.UseFont = True
        Me.rdgCar.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Não"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Sim")})
        Me.rdgCar.Size = New System.Drawing.Size(100, 20)
        Me.rdgCar.TabIndex = 4
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(16, 38)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl7.TabIndex = 21
        Me.LabelControl7.Text = "Cartão?"
        '
        'rdgIr
        '
        Me.rdgIr.Location = New System.Drawing.Point(902, 9)
        Me.rdgIr.Name = "rdgIr"
        Me.rdgIr.Properties.Appearance.BackColor = System.Drawing.Color.Moccasin
        Me.rdgIr.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgIr.Properties.Appearance.Options.UseBackColor = True
        Me.rdgIr.Properties.Appearance.Options.UseFont = True
        Me.rdgIr.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Sim"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Não")})
        Me.rdgIr.Size = New System.Drawing.Size(94, 20)
        Me.rdgIr.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.PagamentoGridControl)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(0, 61)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1008, 334)
        Me.GroupControl1.TabIndex = 8
        Me.GroupControl1.Text = "Formas de Pagamento Cadastradas"
        '
        'btnCadBanco
        '
        Me.btnCadBanco.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnCadBanco.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCadBanco.Location = New System.Drawing.Point(817, 35)
        Me.btnCadBanco.Name = "btnCadBanco"
        Me.btnCadBanco.Size = New System.Drawing.Size(20, 20)
        Me.btnCadBanco.TabIndex = 98
        Me.btnCadBanco.Text = "SimpleButton1"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(715, 12)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl8.TabIndex = 100
        Me.LabelControl8.Text = "Dias Entre Parc."
        '
        'seDias
        '
        Me.seDias.EditValue = New Decimal(New Integer() {30, 0, 0, 0})
        Me.seDias.Enabled = False
        Me.seDias.EnterMoveNextControl = True
        Me.seDias.Location = New System.Drawing.Point(798, 9)
        Me.seDias.Name = "seDias"
        Me.seDias.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.seDias.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.seDias.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seDias.Size = New System.Drawing.Size(39, 20)
        Me.seDias.TabIndex = 2
        Me.seDias.Tag = "Nº Dias Venc."
        '
        'BancoTableAdapter
        '
        Me.BancoTableAdapter.ClearBeforeFill = True
        '
        'rdgUsaTEF
        '
        Me.rdgUsaTEF.Location = New System.Drawing.Point(902, 35)
        Me.rdgUsaTEF.Name = "rdgUsaTEF"
        Me.rdgUsaTEF.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdgUsaTEF.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgUsaTEF.Properties.Appearance.Options.UseBackColor = True
        Me.rdgUsaTEF.Properties.Appearance.Options.UseFont = True
        Me.rdgUsaTEF.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Sim"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Não")})
        Me.rdgUsaTEF.Size = New System.Drawing.Size(94, 20)
        Me.rdgUsaTEF.TabIndex = 101
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(853, 38)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl9.TabIndex = 102
        Me.LabelControl9.Text = "Usa TEF?"
        '
        'frmPagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 431)
        Me.Controls.Add(Me.rdgUsaTEF)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.seDias)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.btnCadBanco)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.rdgIr)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.rdgCar)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.lueBanco)
        Me.Controls.Add(Me.txtDesconto)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.txtNDias)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.cboPag)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmPagamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Forma de Pagamento"
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagamentoGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboForma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPag.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNDias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescricao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesconto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueBanco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgCar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgIr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.seDias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgUsaTEF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PagamentoGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescricao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colDias As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesconto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCartao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDias As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtDes As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colFormaPagamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboForma As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents chkCart As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboPag As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnAlterar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colIrCaixa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDesconto As Campos.NanoCampo
    Friend WithEvents txtDescricao As Campos.NanoCampo
    Friend WithEvents txtNDias As Campos.NanoCampo
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rdgCar As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueBanco As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdgIr As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents colBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCadBanco As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colNumDias As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents seDias As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents BancoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BancoTableAdapter As Nano.dsNanoCommerceTableAdapters.BancoTableAdapter
    Friend WithEvents colUsaTEF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents rdgUsaTEF As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
End Class
