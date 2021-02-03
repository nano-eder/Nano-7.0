<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComandaItens
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Me.btnNovoProduto = New DevExpress.XtraEditors.SimpleButton
        Me.pnlTeclado = New DevExpress.XtraEditors.PanelControl
        Me.PictureEdit5 = New DevExpress.XtraEditors.PictureEdit
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.dsItens = New System.Data.DataSet
        Me.tbItens = New System.Data.DataTable
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAdicionar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colQtd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorUnitario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOpcoes = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colObservacao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.PictureEdit3 = New DevExpress.XtraEditors.PictureEdit
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.txtValorTotal = New DevExpress.XtraEditors.TextEdit
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton
        Me.btnObs = New DevExpress.XtraEditors.SimpleButton
        Me.txtObservacao = New DevExpress.XtraEditors.TextEdit
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtComanda = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtMesa = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtCliente = New DevExpress.XtraEditors.TextEdit
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.btnTransferir = New DevExpress.XtraEditors.SimpleButton
        Me.btnFechar = New DevExpress.XtraEditors.SimpleButton
        Me.lblImpressora = New DevExpress.XtraEditors.LabelControl
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cboImpressora = New DevExpress.XtraEditors.ComboBoxEdit
        Me.btnExcluirComanda = New DevExpress.XtraEditors.SimpleButton
        Me.btnFinalizar = New DevExpress.XtraEditors.SimpleButton
        Me.btnExcluirItem = New DevExpress.XtraEditors.SimpleButton
        Me.PictureEdit4 = New DevExpress.XtraEditors.PictureEdit
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pnlTeclado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTeclado.SuspendLayout()
        CType(Me.PictureEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsItens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbItens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdicionar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.txtValorTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtComanda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMesa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.cboImpressora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNovoProduto
        '
        Me.btnNovoProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovoProduto.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnNovoProduto.Appearance.Font = New System.Drawing.Font("Tahoma", 22.0!)
        Me.btnNovoProduto.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnNovoProduto.Appearance.Options.UseBackColor = True
        Me.btnNovoProduto.Appearance.Options.UseFont = True
        Me.btnNovoProduto.Appearance.Options.UseForeColor = True
        Me.btnNovoProduto.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnNovoProduto.Location = New System.Drawing.Point(1119, 10)
        Me.btnNovoProduto.Name = "btnNovoProduto"
        Me.btnNovoProduto.Size = New System.Drawing.Size(240, 90)
        Me.btnNovoProduto.TabIndex = 4
        Me.btnNovoProduto.Text = "Produto"
        '
        'pnlTeclado
        '
        Me.pnlTeclado.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlTeclado.Controls.Add(Me.PictureEdit5)
        Me.pnlTeclado.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlTeclado.Location = New System.Drawing.Point(0, 696)
        Me.pnlTeclado.Name = "pnlTeclado"
        Me.pnlTeclado.Size = New System.Drawing.Size(1360, 4)
        Me.pnlTeclado.TabIndex = 5
        Me.pnlTeclado.Visible = False
        '
        'PictureEdit5
        '
        Me.PictureEdit5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureEdit5.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit5.Name = "PictureEdit5"
        Me.PictureEdit5.Properties.AllowFocused = False
        Me.PictureEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit5.Properties.NullText = " "
        Me.PictureEdit5.Size = New System.Drawing.Size(1360, 4)
        Me.PictureEdit5.TabIndex = 42
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl5)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.PanelControl4)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1360, 696)
        Me.PanelControl1.TabIndex = 6
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GridControl2)
        Me.PanelControl3.Controls.Add(Me.SimpleButton3)
        Me.PanelControl3.Controls.Add(Me.PictureEdit3)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 103)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1360, 409)
        Me.PanelControl3.TabIndex = 45
        '
        'GridControl2
        '
        Me.GridControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl2.DataMember = "tbItens"
        Me.GridControl2.DataSource = Me.dsItens
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(2, 24)
        Me.GridControl2.MainView = Me.grd1
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.txtAdicionar})
        Me.GridControl2.Size = New System.Drawing.Size(1358, 380)
        Me.GridControl2.TabIndex = 23
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1, Me.GridView4})
        '
        'dsItens
        '
        Me.dsItens.DataSetName = "NewDataSet"
        Me.dsItens.Tables.AddRange(New System.Data.DataTable() {Me.tbItens})
        '
        'tbItens
        '
        Me.tbItens.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn2, Me.DataColumn1, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9})
        Me.tbItens.TableName = "tbItens"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Codigo"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "CodProd"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "CodigoInterno"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Produto"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Qtd"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "ValorUnitario"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "ValorTotal"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Opcoes"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Observacao"
        '
        'grd1
        '
        Me.grd1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grd1.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grd1.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grd1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grd1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grd1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grd1.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grd1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grd1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grd1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.grd1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grd1.Appearance.HeaderPanel.Options.UseFont = True
        Me.grd1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grd1.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grd1.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grd1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grd1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grd1.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grd1.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grd1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grd1.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseBackColor = True
        Me.grd1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProduto, Me.colQtd, Me.colValorUnitario, Me.colValorTotal, Me.colCodigo, Me.colCodProd, Me.colCodigoInterno, Me.colOpcoes, Me.colObservacao})
        Me.grd1.GridControl = Me.GridControl2
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.EnableAppearanceEvenRow = True
        Me.grd1.OptionsView.EnableAppearanceOddRow = True
        Me.grd1.OptionsView.ShowColumnHeaders = False
        Me.grd1.OptionsView.ShowDetailButtons = False
        Me.grd1.OptionsView.ShowGroupPanel = False
        Me.grd1.OptionsView.ShowHorzLines = False
        Me.grd1.OptionsView.ShowIndicator = False
        Me.grd1.OptionsView.ShowPreviewLines = False
        Me.grd1.OptionsView.ShowVertLines = False
        Me.grd1.RowHeight = 80
        '
        'colProduto
        '
        Me.colProduto.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 21.0!)
        Me.colProduto.AppearanceCell.Options.UseFont = True
        Me.colProduto.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colProduto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.colProduto.AppearanceHeader.Options.UseBackColor = True
        Me.colProduto.AppearanceHeader.Options.UseFont = True
        Me.colProduto.Caption = "Adicional"
        Me.colProduto.ColumnEdit = Me.txtAdicionar
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 0
        Me.colProduto.Width = 696
        '
        'txtAdicionar
        '
        Me.txtAdicionar.AutoHeight = False
        Me.txtAdicionar.Name = "txtAdicionar"
        '
        'colQtd
        '
        Me.colQtd.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 21.0!)
        Me.colQtd.AppearanceCell.Options.UseFont = True
        Me.colQtd.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtd.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colQtd.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.colQtd.AppearanceHeader.Options.UseBackColor = True
        Me.colQtd.AppearanceHeader.Options.UseFont = True
        Me.colQtd.Caption = "Qtd"
        Me.colQtd.FieldName = "Qtd"
        Me.colQtd.Name = "colQtd"
        Me.colQtd.OptionsColumn.ReadOnly = True
        Me.colQtd.Visible = True
        Me.colQtd.VisibleIndex = 1
        Me.colQtd.Width = 168
        '
        'colValorUnitario
        '
        Me.colValorUnitario.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 21.0!)
        Me.colValorUnitario.AppearanceCell.Options.UseFont = True
        Me.colValorUnitario.AppearanceCell.Options.UseTextOptions = True
        Me.colValorUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorUnitario.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValorUnitario.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.colValorUnitario.AppearanceHeader.Options.UseBackColor = True
        Me.colValorUnitario.AppearanceHeader.Options.UseFont = True
        Me.colValorUnitario.Caption = "Valor Unitario"
        Me.colValorUnitario.FieldName = "ValorUnitario"
        Me.colValorUnitario.Name = "colValorUnitario"
        Me.colValorUnitario.OptionsColumn.ReadOnly = True
        Me.colValorUnitario.Visible = True
        Me.colValorUnitario.VisibleIndex = 2
        Me.colValorUnitario.Width = 169
        '
        'colValorTotal
        '
        Me.colValorTotal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 21.0!)
        Me.colValorTotal.AppearanceCell.Options.UseFont = True
        Me.colValorTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colValorTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorTotal.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValorTotal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.colValorTotal.AppearanceHeader.Options.UseBackColor = True
        Me.colValorTotal.AppearanceHeader.Options.UseFont = True
        Me.colValorTotal.Caption = "Valor Total"
        Me.colValorTotal.FieldName = "ValorTotal"
        Me.colValorTotal.Name = "colValorTotal"
        Me.colValorTotal.OptionsColumn.ReadOnly = True
        Me.colValorTotal.Visible = True
        Me.colValorTotal.VisibleIndex = 3
        Me.colValorTotal.Width = 162
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 21.0!)
        Me.colCodigo.AppearanceCell.Options.UseFont = True
        Me.colCodigo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodigo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.colCodigo.AppearanceHeader.Options.UseBackColor = True
        Me.colCodigo.AppearanceHeader.Options.UseFont = True
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        '
        'colCodProd
        '
        Me.colCodProd.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 21.0!)
        Me.colCodProd.AppearanceCell.Options.UseFont = True
        Me.colCodProd.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodProd.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.colCodProd.AppearanceHeader.Options.UseBackColor = True
        Me.colCodProd.AppearanceHeader.Options.UseFont = True
        Me.colCodProd.Caption = "CodProd"
        Me.colCodProd.FieldName = "CodProd"
        Me.colCodProd.Name = "colCodProd"
        Me.colCodProd.OptionsColumn.ReadOnly = True
        '
        'colCodigoInterno
        '
        Me.colCodigoInterno.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 21.0!)
        Me.colCodigoInterno.AppearanceCell.Options.UseFont = True
        Me.colCodigoInterno.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodigoInterno.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.colCodigoInterno.AppearanceHeader.Options.UseBackColor = True
        Me.colCodigoInterno.AppearanceHeader.Options.UseFont = True
        Me.colCodigoInterno.Caption = "CodigoInterno"
        Me.colCodigoInterno.FieldName = "CodigoInterno"
        Me.colCodigoInterno.Name = "colCodigoInterno"
        Me.colCodigoInterno.OptionsColumn.ReadOnly = True
        '
        'colOpcoes
        '
        Me.colOpcoes.Caption = "Opções"
        Me.colOpcoes.FieldName = "Opcoes"
        Me.colOpcoes.Name = "colOpcoes"
        Me.colOpcoes.OptionsColumn.ReadOnly = True
        '
        'colObservacao
        '
        Me.colObservacao.Caption = "Observação"
        Me.colObservacao.FieldName = "Observacao"
        Me.colObservacao.Name = "colObservacao"
        Me.colObservacao.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.RepositoryItemCheckEdit1.Appearance.Options.UseFont = True
        Me.RepositoryItemCheckEdit1.AutoWidth = True
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.GridControl2
        Me.GridView4.Name = "GridView4"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.AllowFocus = False
        Me.SimpleButton3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.Appearance.BackColor = System.Drawing.Color.LightBlue
        Me.SimpleButton3.Appearance.BackColor2 = System.Drawing.Color.AliceBlue
        Me.SimpleButton3.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton3.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.SimpleButton3.Appearance.Options.UseBackColor = True
        Me.SimpleButton3.Appearance.Options.UseBorderColor = True
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.Appearance.Options.UseTextOptions = True
        Me.SimpleButton3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.SimpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.SimpleButton3.Location = New System.Drawing.Point(2, -1)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(1358, 23)
        Me.SimpleButton3.TabIndex = 24
        Me.SimpleButton3.Text = "Itens da Comanda"
        '
        'PictureEdit3
        '
        Me.PictureEdit3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureEdit3.Location = New System.Drawing.Point(2, 2)
        Me.PictureEdit3.Name = "PictureEdit3"
        Me.PictureEdit3.Properties.AllowFocused = False
        Me.PictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit3.Properties.NullText = " "
        Me.PictureEdit3.Size = New System.Drawing.Size(1356, 405)
        Me.PictureEdit3.TabIndex = 42
        '
        'PanelControl5
        '
        Me.PanelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl5.Controls.Add(Me.SimpleButton1)
        Me.PanelControl5.Controls.Add(Me.txtValorTotal)
        Me.PanelControl5.Controls.Add(Me.SimpleButton5)
        Me.PanelControl5.Controls.Add(Me.btnObs)
        Me.PanelControl5.Controls.Add(Me.txtObservacao)
        Me.PanelControl5.Controls.Add(Me.PictureEdit2)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl5.Location = New System.Drawing.Point(0, 512)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(1360, 84)
        Me.PanelControl5.TabIndex = 46
        '
        'SimpleButton1
        '
        Me.SimpleButton1.AllowFocus = False
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.LightBlue
        Me.SimpleButton1.Appearance.BackColor2 = System.Drawing.Color.AliceBlue
        Me.SimpleButton1.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseBorderColor = True
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseTextOptions = True
        Me.SimpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.SimpleButton1.Location = New System.Drawing.Point(898, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(215, 23)
        Me.SimpleButton1.TabIndex = 43
        Me.SimpleButton1.Text = "Comanda Fechada"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorTotal.Enabled = False
        Me.txtValorTotal.EnterMoveNextControl = True
        Me.txtValorTotal.Location = New System.Drawing.Point(1119, 28)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValorTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 30.0!)
        Me.txtValorTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtValorTotal.Properties.Appearance.Options.UseFont = True
        Me.txtValorTotal.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValorTotal.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 30.0!, System.Drawing.FontStyle.Bold)
        Me.txtValorTotal.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.White
        Me.txtValorTotal.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtValorTotal.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtValorTotal.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtValorTotal.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtValorTotal.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValorTotal.Size = New System.Drawing.Size(240, 55)
        Me.txtValorTotal.TabIndex = 3
        '
        'SimpleButton5
        '
        Me.SimpleButton5.AllowFocus = False
        Me.SimpleButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton5.Appearance.BackColor = System.Drawing.Color.LightBlue
        Me.SimpleButton5.Appearance.BackColor2 = System.Drawing.Color.AliceBlue
        Me.SimpleButton5.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton5.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton5.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.SimpleButton5.Appearance.Options.UseBackColor = True
        Me.SimpleButton5.Appearance.Options.UseBorderColor = True
        Me.SimpleButton5.Appearance.Options.UseFont = True
        Me.SimpleButton5.Appearance.Options.UseTextOptions = True
        Me.SimpleButton5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.SimpleButton5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.SimpleButton5.Location = New System.Drawing.Point(1119, 4)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(240, 23)
        Me.SimpleButton5.TabIndex = 1
        Me.SimpleButton5.Text = "Valor Total R$"
        '
        'btnObs
        '
        Me.btnObs.AllowFocus = False
        Me.btnObs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnObs.Appearance.BackColor = System.Drawing.Color.LightBlue
        Me.btnObs.Appearance.BackColor2 = System.Drawing.Color.AliceBlue
        Me.btnObs.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.btnObs.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnObs.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.btnObs.Appearance.Options.UseBackColor = True
        Me.btnObs.Appearance.Options.UseBorderColor = True
        Me.btnObs.Appearance.Options.UseFont = True
        Me.btnObs.Appearance.Options.UseTextOptions = True
        Me.btnObs.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btnObs.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnObs.Location = New System.Drawing.Point(2, 4)
        Me.btnObs.Name = "btnObs"
        Me.btnObs.Size = New System.Drawing.Size(1111, 23)
        Me.btnObs.TabIndex = 0
        Me.btnObs.Text = "Observações"
        '
        'txtObservacao
        '
        Me.txtObservacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacao.EnterMoveNextControl = True
        Me.txtObservacao.Location = New System.Drawing.Point(2, 28)
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 30.0!)
        Me.txtObservacao.Properties.Appearance.Options.UseFont = True
        Me.txtObservacao.Size = New System.Drawing.Size(1111, 55)
        Me.txtObservacao.TabIndex = 2
        '
        'PictureEdit2
        '
        Me.PictureEdit2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureEdit2.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.AllowFocused = False
        Me.PictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit2.Properties.NullText = " "
        Me.PictureEdit2.Size = New System.Drawing.Size(1360, 84)
        Me.PictureEdit2.TabIndex = 42
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.btnNovoProduto)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.txtComanda)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.txtMesa)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.txtCliente)
        Me.PanelControl2.Controls.Add(Me.PictureEdit1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1360, 103)
        Me.PanelControl2.TabIndex = 44
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(4, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(99, 25)
        Me.LabelControl3.TabIndex = 33
        Me.LabelControl3.Text = "Comanda"
        '
        'txtComanda
        '
        Me.txtComanda.Enabled = False
        Me.txtComanda.EnterMoveNextControl = True
        Me.txtComanda.Location = New System.Drawing.Point(4, 29)
        Me.txtComanda.Name = "txtComanda"
        Me.txtComanda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 30.0!)
        Me.txtComanda.Properties.Appearance.Options.UseFont = True
        Me.txtComanda.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtComanda.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 30.0!)
        Me.txtComanda.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtComanda.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtComanda.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtComanda.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtComanda.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtComanda.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtComanda.Size = New System.Drawing.Size(220, 55)
        Me.txtComanda.TabIndex = 34
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(230, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 25)
        Me.LabelControl1.TabIndex = 35
        Me.LabelControl1.Text = "Mesa"
        '
        'txtMesa
        '
        Me.txtMesa.Enabled = False
        Me.txtMesa.EnterMoveNextControl = True
        Me.txtMesa.Location = New System.Drawing.Point(230, 29)
        Me.txtMesa.Name = "txtMesa"
        Me.txtMesa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 30.0!)
        Me.txtMesa.Properties.Appearance.Options.UseFont = True
        Me.txtMesa.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtMesa.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 30.0!)
        Me.txtMesa.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtMesa.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtMesa.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtMesa.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtMesa.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtMesa.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMesa.Size = New System.Drawing.Size(220, 55)
        Me.txtMesa.TabIndex = 36
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(456, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(72, 25)
        Me.LabelControl2.TabIndex = 37
        Me.LabelControl2.Text = "Cliente"
        '
        'txtCliente
        '
        Me.txtCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCliente.Enabled = False
        Me.txtCliente.EnterMoveNextControl = True
        Me.txtCliente.Location = New System.Drawing.Point(456, 29)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 30.0!)
        Me.txtCliente.Properties.Appearance.Options.UseFont = True
        Me.txtCliente.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtCliente.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 30.0!)
        Me.txtCliente.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCliente.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCliente.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtCliente.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCliente.Size = New System.Drawing.Size(657, 55)
        Me.txtCliente.TabIndex = 38
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.AllowFocused = False
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.NullText = " "
        Me.PictureEdit1.Size = New System.Drawing.Size(1360, 103)
        Me.PictureEdit1.TabIndex = 42
        '
        'PanelControl4
        '
        Me.PanelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl4.Controls.Add(Me.btnTransferir)
        Me.PanelControl4.Controls.Add(Me.btnFechar)
        Me.PanelControl4.Controls.Add(Me.lblImpressora)
        Me.PanelControl4.Controls.Add(Me.btnImprimir)
        Me.PanelControl4.Controls.Add(Me.cboImpressora)
        Me.PanelControl4.Controls.Add(Me.btnExcluirComanda)
        Me.PanelControl4.Controls.Add(Me.btnFinalizar)
        Me.PanelControl4.Controls.Add(Me.btnExcluirItem)
        Me.PanelControl4.Controls.Add(Me.PictureEdit4)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl4.Location = New System.Drawing.Point(0, 596)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(1360, 100)
        Me.PanelControl4.TabIndex = 25
        '
        'btnTransferir
        '
        Me.btnTransferir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTransferir.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnTransferir.Appearance.Font = New System.Drawing.Font("Tahoma", 22.0!)
        Me.btnTransferir.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnTransferir.Appearance.Options.UseBackColor = True
        Me.btnTransferir.Appearance.Options.UseFont = True
        Me.btnTransferir.Appearance.Options.UseForeColor = True
        Me.btnTransferir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnTransferir.Location = New System.Drawing.Point(677, 4)
        Me.btnTransferir.Name = "btnTransferir"
        Me.btnTransferir.Size = New System.Drawing.Size(215, 90)
        Me.btnTransferir.TabIndex = 49
        Me.btnTransferir.Text = "Transferir"
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFechar.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnFechar.Appearance.Font = New System.Drawing.Font("Tahoma", 22.0!)
        Me.btnFechar.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnFechar.Appearance.Options.UseBackColor = True
        Me.btnFechar.Appearance.Options.UseFont = True
        Me.btnFechar.Appearance.Options.UseForeColor = True
        Me.btnFechar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnFechar.Location = New System.Drawing.Point(898, 4)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(215, 90)
        Me.btnFechar.TabIndex = 48
        Me.btnFechar.Text = "Finalizar"
        '
        'lblImpressora
        '
        Me.lblImpressora.Location = New System.Drawing.Point(232, 80)
        Me.lblImpressora.Name = "lblImpressora"
        Me.lblImpressora.Size = New System.Drawing.Size(66, 13)
        Me.lblImpressora.TabIndex = 47
        Me.lblImpressora.Text = "LabelControl4"
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 22.0!)
        Me.btnImprimir.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Appearance.Options.UseBackColor = True
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Appearance.Options.UseForeColor = True
        Me.btnImprimir.Appearance.Options.UseTextOptions = True
        Me.btnImprimir.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.btnImprimir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnImprimir.Location = New System.Drawing.Point(230, 4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(180, 90)
        Me.btnImprimir.TabIndex = 39
        Me.btnImprimir.Text = "Imprimir"
        '
        'cboImpressora
        '
        Me.cboImpressora.Location = New System.Drawing.Point(230, 4)
        Me.cboImpressora.Name = "cboImpressora"
        Me.cboImpressora.Properties.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cboImpressora.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 53.0!)
        Me.cboImpressora.Properties.Appearance.Options.UseBackColor = True
        Me.cboImpressora.Properties.Appearance.Options.UseFont = True
        Me.cboImpressora.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 25.0!)
        Me.cboImpressora.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cboImpressora.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        SerializableAppearanceObject1.BackColor = System.Drawing.Color.DarkSlateGray
        SerializableAppearanceObject1.Options.UseBackColor = True
        Me.cboImpressora.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", 40, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1)})
        Me.cboImpressora.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.cboImpressora.Size = New System.Drawing.Size(220, 90)
        Me.cboImpressora.TabIndex = 46
        '
        'btnExcluirComanda
        '
        Me.btnExcluirComanda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirComanda.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnExcluirComanda.Appearance.Font = New System.Drawing.Font("Tahoma", 22.0!)
        Me.btnExcluirComanda.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnExcluirComanda.Appearance.Options.UseBackColor = True
        Me.btnExcluirComanda.Appearance.Options.UseFont = True
        Me.btnExcluirComanda.Appearance.Options.UseForeColor = True
        Me.btnExcluirComanda.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnExcluirComanda.Location = New System.Drawing.Point(456, 4)
        Me.btnExcluirComanda.Name = "btnExcluirComanda"
        Me.btnExcluirComanda.Size = New System.Drawing.Size(215, 90)
        Me.btnExcluirComanda.TabIndex = 43
        Me.btnExcluirComanda.Text = "Comanda"
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFinalizar.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnFinalizar.Appearance.Font = New System.Drawing.Font("Tahoma", 22.0!)
        Me.btnFinalizar.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnFinalizar.Appearance.Options.UseBackColor = True
        Me.btnFinalizar.Appearance.Options.UseFont = True
        Me.btnFinalizar.Appearance.Options.UseForeColor = True
        Me.btnFinalizar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnFinalizar.Location = New System.Drawing.Point(1119, 4)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(240, 90)
        Me.btnFinalizar.TabIndex = 0
        Me.btnFinalizar.Text = "Concluir"
        '
        'btnExcluirItem
        '
        Me.btnExcluirItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirItem.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnExcluirItem.Appearance.Font = New System.Drawing.Font("Tahoma", 22.0!)
        Me.btnExcluirItem.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnExcluirItem.Appearance.Options.UseBackColor = True
        Me.btnExcluirItem.Appearance.Options.UseFont = True
        Me.btnExcluirItem.Appearance.Options.UseForeColor = True
        Me.btnExcluirItem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnExcluirItem.Location = New System.Drawing.Point(4, 4)
        Me.btnExcluirItem.Name = "btnExcluirItem"
        Me.btnExcluirItem.Size = New System.Drawing.Size(220, 90)
        Me.btnExcluirItem.TabIndex = 42
        Me.btnExcluirItem.Text = "Item"
        '
        'PictureEdit4
        '
        Me.PictureEdit4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureEdit4.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit4.Name = "PictureEdit4"
        Me.PictureEdit4.Properties.AllowFocused = False
        Me.PictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit4.Properties.NullText = " "
        Me.PictureEdit4.Size = New System.Drawing.Size(1360, 100)
        Me.PictureEdit4.TabIndex = 44
        '
        'Timer1
        '
        '
        'frmComandaItens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.pnlTeclado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmComandaItens"
        Me.Text = "frmComandaItens"
        CType(Me.pnlTeclado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTeclado.ResumeLayout(False)
        CType(Me.PictureEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsItens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbItens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdicionar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.txtValorTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtComanda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMesa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.cboImpressora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNovoProduto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlTeclado As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAdicionar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colQtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dsItens As System.Data.DataSet
    Friend WithEvents tbItens As System.Data.DataTable
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents btnFinalizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtValorTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMesa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtComanda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnExcluirComanda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExcluirItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnObs As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtObservacao As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colValorUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents colOpcoes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents colObservacao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureEdit3 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit4 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit5 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents cboImpressora As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblImpressora As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnFechar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTransferir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
