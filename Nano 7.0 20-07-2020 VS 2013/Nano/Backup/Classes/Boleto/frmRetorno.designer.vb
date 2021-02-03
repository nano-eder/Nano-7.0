<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetorno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRetorno))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsRetorno = New System.Data.DataSet
        Me.tbRetorno = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigoBanco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAgencia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoCedente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNossoNumero = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPagoOk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colOcorrencia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataRecebimento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNomeBanco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSacado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodOrdem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVencimento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtCaminhoRetorno = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem
        Me.btnVisualizar = New DevExpress.XtraBars.BarButtonItem
        Me.btnRelCust = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvar1 = New DevExpress.XtraBars.BarButtonItem
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.ofdRetorno = New System.Windows.Forms.OpenFileDialog
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtCarteira = New Campos.NanoCampo
        Me.txtCedente = New DevExpress.XtraEditors.ButtonEdit
        Me.txtContaCorrente = New Campos.NanoCampo
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtCodCedente = New Campos.NanoCampo
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtAgencia = New Campos.NanoCampo
        Me.txtCPFCedente = New Campos.NanoCampo
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl45 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl
        Me.lueBanco = New DevExpress.XtraEditors.LookUpEdit
        Me.BancoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.BancoTableAdapter = New Nano.dsNanoCommerceTableAdapters.BancoTableAdapter
        Me.DataColumn13 = New System.Data.DataColumn
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsRetorno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbRetorno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCaminhoRetorno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCarteira.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCedente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContaCorrente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodCedente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAgencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCPFCedente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueBanco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 86)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(905, 452)
        Me.GroupControl1.TabIndex = 118
        Me.GroupControl1.Text = "Cobranças"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl2.Controls.Add(Me.GridControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(2, 20)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(901, 430)
        Me.GroupControl2.TabIndex = 1
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbRetorno"
        Me.GridControl1.DataSource = Me.dsRetorno
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(897, 393)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsRetorno
        '
        Me.dsRetorno.DataSetName = "NewDataSet"
        Me.dsRetorno.Tables.AddRange(New System.Data.DataTable() {Me.tbRetorno})
        '
        'tbRetorno
        '
        Me.tbRetorno.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13})
        Me.tbRetorno.TableName = "tbRetorno"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "CodigoBanco"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Agencia"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "CodigoCedente"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "NossoNumero"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "PagoOk"
        Me.DataColumn5.DataType = GetType(Boolean)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Ocorrencia"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "ValorTotal"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "DataRecebimento"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "NomeBanco"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Sacado"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "CodOrdem"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "Vencimento"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoBanco, Me.colAgencia, Me.colCodigoCedente, Me.colNossoNumero, Me.colPagoOk, Me.colOcorrencia, Me.colValorTotal, Me.colDataRecebimento, Me.colNomeBanco, Me.colSacado, Me.colCodOrdem, Me.colVencimento, Me.colStatus})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowFooter = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodigoBanco
        '
        Me.colCodigoBanco.Caption = "CodigoBanco"
        Me.colCodigoBanco.FieldName = "CodigoBanco"
        Me.colCodigoBanco.Name = "colCodigoBanco"
        Me.colCodigoBanco.OptionsColumn.ReadOnly = True
        Me.colCodigoBanco.Width = 84
        '
        'colAgencia
        '
        Me.colAgencia.Caption = "Agencia"
        Me.colAgencia.FieldName = "Agencia"
        Me.colAgencia.Name = "colAgencia"
        Me.colAgencia.OptionsColumn.ReadOnly = True
        Me.colAgencia.Width = 109
        '
        'colCodigoCedente
        '
        Me.colCodigoCedente.Caption = "CodigoCedente"
        Me.colCodigoCedente.FieldName = "CodigoCedente"
        Me.colCodigoCedente.Name = "colCodigoCedente"
        Me.colCodigoCedente.OptionsColumn.ReadOnly = True
        Me.colCodigoCedente.Width = 109
        '
        'colNossoNumero
        '
        Me.colNossoNumero.Caption = "Nosso Número"
        Me.colNossoNumero.FieldName = "NossoNumero"
        Me.colNossoNumero.Name = "colNossoNumero"
        Me.colNossoNumero.OptionsColumn.ReadOnly = True
        Me.colNossoNumero.Visible = True
        Me.colNossoNumero.VisibleIndex = 0
        Me.colNossoNumero.Width = 152
        '
        'colPagoOk
        '
        Me.colPagoOk.AppearanceCell.Options.UseTextOptions = True
        Me.colPagoOk.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPagoOk.Caption = "Pago Ok"
        Me.colPagoOk.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colPagoOk.FieldName = "PagoOk"
        Me.colPagoOk.Name = "colPagoOk"
        Me.colPagoOk.OptionsColumn.ReadOnly = True
        Me.colPagoOk.Visible = True
        Me.colPagoOk.VisibleIndex = 6
        Me.colPagoOk.Width = 84
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colOcorrencia
        '
        Me.colOcorrencia.AppearanceCell.Options.UseTextOptions = True
        Me.colOcorrencia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOcorrencia.Caption = "Ocorrência"
        Me.colOcorrencia.FieldName = "Ocorrencia"
        Me.colOcorrencia.Name = "colOcorrencia"
        Me.colOcorrencia.OptionsColumn.ReadOnly = True
        Me.colOcorrencia.Visible = True
        Me.colOcorrencia.VisibleIndex = 3
        Me.colOcorrencia.Width = 103
        '
        'colValorTotal
        '
        Me.colValorTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colValorTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorTotal.Caption = "Valor Fatura R$"
        Me.colValorTotal.FieldName = "ValorTotal"
        Me.colValorTotal.Name = "colValorTotal"
        Me.colValorTotal.OptionsColumn.ReadOnly = True
        Me.colValorTotal.SummaryItem.DisplayFormat = "{0:c}"
        Me.colValorTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colValorTotal.Visible = True
        Me.colValorTotal.VisibleIndex = 5
        Me.colValorTotal.Width = 104
        '
        'colDataRecebimento
        '
        Me.colDataRecebimento.AppearanceCell.Options.UseTextOptions = True
        Me.colDataRecebimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataRecebimento.Caption = "Recebimento"
        Me.colDataRecebimento.FieldName = "DataRecebimento"
        Me.colDataRecebimento.Name = "colDataRecebimento"
        Me.colDataRecebimento.OptionsColumn.ReadOnly = True
        Me.colDataRecebimento.Visible = True
        Me.colDataRecebimento.VisibleIndex = 4
        Me.colDataRecebimento.Width = 97
        '
        'colNomeBanco
        '
        Me.colNomeBanco.Caption = "Nome Banco"
        Me.colNomeBanco.FieldName = "NomeBanco"
        Me.colNomeBanco.Name = "colNomeBanco"
        Me.colNomeBanco.OptionsColumn.ReadOnly = True
        Me.colNomeBanco.Width = 109
        '
        'colSacado
        '
        Me.colSacado.Caption = "Sacado"
        Me.colSacado.FieldName = "Sacado"
        Me.colSacado.Name = "colSacado"
        Me.colSacado.OptionsColumn.ReadOnly = True
        Me.colSacado.Visible = True
        Me.colSacado.VisibleIndex = 2
        Me.colSacado.Width = 206
        '
        'colCodOrdem
        '
        Me.colCodOrdem.AppearanceCell.Options.UseTextOptions = True
        Me.colCodOrdem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodOrdem.Caption = "Nº Doc."
        Me.colCodOrdem.FieldName = "CodOrdem"
        Me.colCodOrdem.Name = "colCodOrdem"
        Me.colCodOrdem.OptionsColumn.ReadOnly = True
        Me.colCodOrdem.Visible = True
        Me.colCodOrdem.VisibleIndex = 1
        Me.colCodOrdem.Width = 130
        '
        'colVencimento
        '
        Me.colVencimento.AppearanceCell.Options.UseTextOptions = True
        Me.colVencimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimento.Caption = "Vencimento"
        Me.colVencimento.FieldName = "Vencimento"
        Me.colVencimento.Name = "colVencimento"
        Me.colVencimento.OptionsColumn.ReadOnly = True
        Me.colVencimento.Width = 107
        '
        'txtCaminhoRetorno
        '
        Me.txtCaminhoRetorno.EnterMoveNextControl = True
        Me.txtCaminhoRetorno.Location = New System.Drawing.Point(318, 8)
        Me.txtCaminhoRetorno.Name = "txtCaminhoRetorno"
        Me.txtCaminhoRetorno.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCaminhoRetorno.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCaminhoRetorno.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCaminhoRetorno.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCaminhoRetorno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.txtCaminhoRetorno.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtCaminhoRetorno.Size = New System.Drawing.Size(573, 20)
        Me.txtCaminhoRetorno.TabIndex = 2
        Me.txtCaminhoRetorno.Tag = "Nome Cliente"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(238, 11)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl1.TabIndex = 116
        Me.LabelControl1.Text = "Origem Arquivo"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSalvar, Me.btnFechar, Me.btnSalvar1, Me.btnLimpar, Me.BarSubItem1, Me.btnVisualizar, Me.btnRelCust})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "&Visualizar"
        Me.BarSubItem1.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.BarSubItem1.Id = 4
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnVisualizar), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCust)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Caption = "&Relatório de Retorno"
        Me.btnVisualizar.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnVisualizar.Id = 5
        Me.btnVisualizar.Name = "btnVisualizar"
        '
        'btnRelCust
        '
        Me.btnRelCust.Caption = "Relatório C&ustomizado"
        Me.btnRelCust.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnRelCust.Id = 6
        Me.btnRelCust.Name = "btnRelCust"
        '
        'btnSalvar1
        '
        Me.btnSalvar1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar1.Caption = "&Baixar"
        Me.btnSalvar1.Glyph = Global.Nano.My.Resources.Resources.apply
        Me.btnSalvar1.Id = 2
        Me.btnSalvar1.Name = "btnSalvar1"
        '
        'btnLimpar
        '
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
        Me.btnFechar.Id = 1
        Me.btnFechar.Name = "btnFechar"
        '
        'btnSalvar
        '
        Me.btnSalvar.Caption = "&Salvar"
        Me.btnSalvar.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvar.Id = 0
        Me.btnSalvar.Name = "btnSalvar"
        '
        'ofdRetorno
        '
        Me.ofdRetorno.FileName = "OpenFileDialog1"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(706, 63)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl2.TabIndex = 117
        Me.LabelControl2.Text = "Carteira"
        '
        'txtCarteira
        '
        Me.txtCarteira.CasasDecimais = 0
        Me.txtCarteira.Enabled = False
        Me.txtCarteira.EnterMoveNextControl = True
        Me.txtCarteira.Location = New System.Drawing.Point(751, 60)
        Me.txtCarteira.Name = "txtCarteira"
        Me.txtCarteira.Numerico = True
        Me.txtCarteira.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCarteira.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCarteira.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCarteira.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCarteira.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCarteira.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCarteira.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCarteira.Properties.MaxLength = 10
        Me.txtCarteira.Size = New System.Drawing.Size(140, 20)
        Me.txtCarteira.TabIndex = 116
        Me.txtCarteira.Tag = "Número"
        '
        'txtCedente
        '
        Me.txtCedente.Enabled = False
        Me.txtCedente.EnterMoveNextControl = True
        Me.txtCedente.Location = New System.Drawing.Point(318, 34)
        Me.txtCedente.Name = "txtCedente"
        Me.txtCedente.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCedente.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCedente.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCedente.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCedente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12)})
        Me.txtCedente.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtCedente.Size = New System.Drawing.Size(573, 20)
        Me.txtCedente.TabIndex = 115
        Me.txtCedente.Tag = "Nome Cliente"
        '
        'txtContaCorrente
        '
        Me.txtContaCorrente.CasasDecimais = 0
        Me.txtContaCorrente.Enabled = False
        Me.txtContaCorrente.EnterMoveNextControl = True
        Me.txtContaCorrente.Location = New System.Drawing.Point(549, 60)
        Me.txtContaCorrente.Name = "txtContaCorrente"
        Me.txtContaCorrente.Numerico = True
        Me.txtContaCorrente.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtContaCorrente.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtContaCorrente.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtContaCorrente.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtContaCorrente.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtContaCorrente.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtContaCorrente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContaCorrente.Properties.MaxLength = 10
        Me.txtContaCorrente.Size = New System.Drawing.Size(140, 20)
        Me.txtContaCorrente.TabIndex = 110
        Me.txtContaCorrente.Tag = "Número Banco"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(468, 63)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl11.TabIndex = 111
        Me.LabelControl11.Text = "Conta Corrente"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(245, 63)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl8.TabIndex = 103
        Me.LabelControl8.Text = "Cód. Cedente"
        '
        'txtCodCedente
        '
        Me.txtCodCedente.CasasDecimais = 0
        Me.txtCodCedente.Enabled = False
        Me.txtCodCedente.EnterMoveNextControl = True
        Me.txtCodCedente.Location = New System.Drawing.Point(318, 60)
        Me.txtCodCedente.Name = "txtCodCedente"
        Me.txtCodCedente.Numerico = True
        Me.txtCodCedente.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCodCedente.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodCedente.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCodCedente.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodCedente.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodCedente.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCodCedente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodCedente.Properties.MaxLength = 10
        Me.txtCodCedente.Size = New System.Drawing.Size(140, 20)
        Me.txtCodCedente.TabIndex = 102
        Me.txtCodCedente.Tag = "Número"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(44, 63)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl7.TabIndex = 101
        Me.LabelControl7.Text = "Agência"
        '
        'txtAgencia
        '
        Me.txtAgencia.CasasDecimais = 0
        Me.txtAgencia.Enabled = False
        Me.txtAgencia.EnterMoveNextControl = True
        Me.txtAgencia.Location = New System.Drawing.Point(88, 60)
        Me.txtAgencia.Name = "txtAgencia"
        Me.txtAgencia.Numerico = True
        Me.txtAgencia.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtAgencia.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtAgencia.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtAgencia.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtAgencia.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAgencia.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtAgencia.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAgencia.Properties.MaxLength = 10
        Me.txtAgencia.Size = New System.Drawing.Size(140, 20)
        Me.txtAgencia.TabIndex = 100
        Me.txtAgencia.Tag = "Número"
        '
        'txtCPFCedente
        '
        Me.txtCPFCedente.CasasDecimais = 0
        Me.txtCPFCedente.Enabled = False
        Me.txtCPFCedente.EnterMoveNextControl = True
        Me.txtCPFCedente.Location = New System.Drawing.Point(88, 34)
        Me.txtCPFCedente.Name = "txtCPFCedente"
        Me.txtCPFCedente.Numerico = False
        Me.txtCPFCedente.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCPFCedente.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCPFCedente.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCPFCedente.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCPFCedente.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCPFCedente.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCPFCedente.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCPFCedente.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCPFCedente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCPFCedente.Properties.MaxLength = 20
        Me.txtCPFCedente.Size = New System.Drawing.Size(140, 20)
        Me.txtCPFCedente.TabIndex = 1
        Me.txtCPFCedente.Tag = "CPF/CNPJ"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(34, 37)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl16.TabIndex = 99
        Me.LabelControl16.Text = "CPF/CNPJ"
        '
        'LabelControl45
        '
        Me.LabelControl45.Location = New System.Drawing.Point(271, 37)
        Me.LabelControl45.Name = "LabelControl45"
        Me.LabelControl45.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl45.TabIndex = 94
        Me.LabelControl45.Text = "Cedente"
        '
        'LabelControl43
        '
        Me.LabelControl43.Location = New System.Drawing.Point(23, 11)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl43.TabIndex = 122
        Me.LabelControl43.Text = "Nome Banco"
        '
        'lueBanco
        '
        Me.lueBanco.EnterMoveNextControl = True
        Me.lueBanco.Location = New System.Drawing.Point(88, 8)
        Me.lueBanco.Name = "lueBanco"
        Me.lueBanco.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lueBanco.Properties.Appearance.Options.UseFont = True
        Me.lueBanco.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.lueBanco.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.lueBanco.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lueBanco.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.lueBanco.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueBanco.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 20, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueBanco.Properties.DataSource = Me.BancoBindingSource
        Me.lueBanco.Properties.DisplayMember = "Nome"
        Me.lueBanco.Properties.NullText = ""
        Me.lueBanco.Properties.ValueMember = "Codigo"
        Me.lueBanco.Size = New System.Drawing.Size(140, 20)
        Me.lueBanco.TabIndex = 123
        Me.lueBanco.Tag = "Vendedor"
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
        'BancoTableAdapter
        '
        Me.BancoTableAdapter.ClearBeforeFill = True
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "Status"
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.OptionsColumn.ReadOnly = True
        '
        'frmRetorno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 572)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.lueBanco)
        Me.Controls.Add(Me.txtCarteira)
        Me.Controls.Add(Me.txtCaminhoRetorno)
        Me.Controls.Add(Me.txtContaCorrente)
        Me.Controls.Add(Me.txtCedente)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl43)
        Me.Controls.Add(Me.txtCodCedente)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txtAgencia)
        Me.Controls.Add(Me.txtCPFCedente)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.LabelControl45)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRetorno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retorno"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsRetorno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbRetorno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCaminhoRetorno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCarteira.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCedente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContaCorrente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodCedente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAgencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCPFCedente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueBanco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSalvar1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dsRetorno As System.Data.DataSet
    Friend WithEvents tbRetorno As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtCaminhoRetorno As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigoBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAgencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoCedente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNossoNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagoOk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOcorrencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataRecebimento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents colNomeBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ofdRetorno As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCedente As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtContaCorrente As Campos.NanoCampo
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodCedente As Campos.NanoCampo
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAgencia As Campos.NanoCampo
    Friend WithEvents txtCPFCedente As Campos.NanoCampo
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents colSacado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodOrdem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencimento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnVisualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRelCust As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCarteira As Campos.NanoCampo
    Friend WithEvents lueBanco As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents BancoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BancoTableAdapter As Nano.dsNanoCommerceTableAdapters.BancoTableAdapter
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
End Class
