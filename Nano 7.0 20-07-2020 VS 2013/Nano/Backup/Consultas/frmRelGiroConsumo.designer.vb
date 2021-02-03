<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelGiroConsumo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelGiroConsumo))
        Me.dsGiro = New System.Data.DataSet
        Me.tbGiro = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.lblTotGer = New DevExpress.XtraEditors.LabelControl
        Me.txtTotGer = New DevExpress.XtraEditors.TextEdit
        Me.txtTotPro = New DevExpress.XtraEditors.TextEdit
        Me.btnCalcular = New DevExpress.XtraEditors.SimpleButton
        Me.lblProd = New DevExpress.XtraEditors.LabelControl
        Me.btnPadrao = New DevExpress.XtraEditors.SimpleButton
        Me.btnManter = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFornecedor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEntrada = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSaida = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGiro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSetor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGrupo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.dtInicial = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.dtFinal = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.lueLoja = New DevExpress.XtraBars.BarEditItem
        Me.lueLoj = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.btnFiltrar = New DevExpress.XtraBars.BarButtonItem
        Me.bsiVisu = New DevExpress.XtraBars.BarSubItem
        Me.btnRelGir = New DevExpress.XtraBars.BarButtonItem
        Me.btnRelCust = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.ConfigTableAdapter = New Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
        CType(Me.dsGiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbGiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotGer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotPro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLoj, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dsGiro
        '
        Me.dsGiro.DataSetName = "NewDataSet"
        Me.dsGiro.Tables.AddRange(New System.Data.DataTable() {Me.tbGiro})
        '
        'tbGiro
        '
        Me.tbGiro.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9})
        Me.tbGiro.TableName = "tbGiro"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Fornecedor"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "CodProd"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Produto"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Entrada"
        Me.DataColumn4.DataType = GetType(Double)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Saida"
        Me.DataColumn5.DataType = GetType(Double)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Giro"
        Me.DataColumn6.DataType = GetType(Double)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Saldo"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Setor"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Grupo"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.TextEdit1)
        Me.GroupControl1.Controls.Add(Me.lblTotGer)
        Me.GroupControl1.Controls.Add(Me.txtTotGer)
        Me.GroupControl1.Controls.Add(Me.txtTotPro)
        Me.GroupControl1.Controls.Add(Me.btnCalcular)
        Me.GroupControl1.Controls.Add(Me.lblProd)
        Me.GroupControl1.Controls.Add(Me.btnPadrao)
        Me.GroupControl1.Controls.Add(Me.btnManter)
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1008, 626)
        Me.GroupControl1.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(324, 605)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl1.TabIndex = 113
        Me.LabelControl1.Text = "Qtde Estoque"
        '
        'TextEdit1
        '
        Me.TextEdit1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEdit1.Location = New System.Drawing.Point(405, 597)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit1.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TextEdit1.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextEdit1.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TextEdit1.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(150, 26)
        Me.TextEdit1.TabIndex = 112
        '
        'lblTotGer
        '
        Me.lblTotGer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotGer.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotGer.Appearance.Options.UseFont = True
        Me.lblTotGer.Location = New System.Drawing.Point(754, 605)
        Me.lblTotGer.Name = "lblTotGer"
        Me.lblTotGer.Size = New System.Drawing.Size(86, 13)
        Me.lblTotGer.TabIndex = 0
        Me.lblTotGer.Text = "Total Giro% R$"
        '
        'txtTotGer
        '
        Me.txtTotGer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotGer.Location = New System.Drawing.Point(846, 597)
        Me.txtTotGer.Name = "txtTotGer"
        Me.txtTotGer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotGer.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtTotGer.Properties.Appearance.Options.UseFont = True
        Me.txtTotGer.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotGer.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotGer.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotGer.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtTotGer.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotGer.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue
        Me.txtTotGer.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotGer.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTotGer.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotGer.Properties.ReadOnly = True
        Me.txtTotGer.Size = New System.Drawing.Size(150, 26)
        Me.txtTotGer.TabIndex = 1
        '
        'txtTotPro
        '
        Me.txtTotPro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotPro.Location = New System.Drawing.Point(598, 597)
        Me.txtTotPro.Name = "txtTotPro"
        Me.txtTotPro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotPro.Properties.Appearance.Options.UseFont = True
        Me.txtTotPro.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotPro.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotPro.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtTotPro.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotPro.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotPro.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTotPro.Properties.ReadOnly = True
        Me.txtTotPro.Size = New System.Drawing.Size(150, 26)
        Me.txtTotPro.TabIndex = 5
        '
        'btnCalcular
        '
        Me.btnCalcular.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalcular.Image = Global.Nano.My.Resources.Resources.Calculator2
        Me.btnCalcular.Location = New System.Drawing.Point(222, 597)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(96, 26)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = "Calcular"
        '
        'lblProd
        '
        Me.lblProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProd.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProd.Appearance.Options.UseFont = True
        Me.lblProd.Location = New System.Drawing.Point(561, 605)
        Me.lblProd.Name = "lblProd"
        Me.lblProd.Size = New System.Drawing.Size(31, 13)
        Me.lblProd.TabIndex = 4
        Me.lblProd.Text = "Saída"
        '
        'btnPadrao
        '
        Me.btnPadrao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPadrao.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnPadrao.Appearance.Options.UseFont = True
        Me.btnPadrao.Enabled = False
        Me.btnPadrao.Location = New System.Drawing.Point(926, 20)
        Me.btnPadrao.Name = "btnPadrao"
        Me.btnPadrao.Size = New System.Drawing.Size(54, 16)
        Me.btnPadrao.TabIndex = 111
        Me.btnPadrao.Text = "Padrão"
        Me.btnPadrao.ToolTip = "Configurações da grid padrão"
        '
        'btnManter
        '
        Me.btnManter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManter.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnManter.Appearance.Options.UseFont = True
        Me.btnManter.Location = New System.Drawing.Point(926, 5)
        Me.btnManter.Name = "btnManter"
        Me.btnManter.Size = New System.Drawing.Size(54, 16)
        Me.btnManter.TabIndex = 110
        Me.btnManter.Text = "Manter"
        Me.btnManter.ToolTip = "Manter as configurações da grid"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbGiro"
        Me.GridControl1.DataSource = Me.dsGiro
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1004, 589)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'grd1
        '
        Me.grd1.AppearancePrint.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grd1.AppearancePrint.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.AppearancePrint.FooterPanel.Options.UseBackColor = True
        Me.grd1.AppearancePrint.FooterPanel.Options.UseFont = True
        Me.grd1.AppearancePrint.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grd1.AppearancePrint.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.AppearancePrint.GroupFooter.Options.UseBackColor = True
        Me.grd1.AppearancePrint.GroupFooter.Options.UseFont = True
        Me.grd1.AppearancePrint.GroupRow.BackColor = System.Drawing.Color.AliceBlue
        Me.grd1.AppearancePrint.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.AppearancePrint.GroupRow.Options.UseBackColor = True
        Me.grd1.AppearancePrint.GroupRow.Options.UseFont = True
        Me.grd1.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.grd1.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.AppearancePrint.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseBackColor = True
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseForeColor = True
        Me.grd1.AppearancePrint.Row.BackColor = System.Drawing.Color.White
        Me.grd1.AppearancePrint.Row.Options.UseBackColor = True
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFornecedor, Me.colCodProd, Me.colProduto, Me.colEntrada, Me.colSaida, Me.colGiro, Me.colSaldo, Me.colSetor, Me.colGrupo})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Entrada", Me.colEntrada, "{0:0.000}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Saida", Me.colSaida, "{0:0.000}")})
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsPrint.UsePrintStyles = True
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowFooter = True
        '
        'colFornecedor
        '
        Me.colFornecedor.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colFornecedor.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colFornecedor.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colFornecedor.AppearanceCell.Options.UseBackColor = True
        Me.colFornecedor.Caption = "Fornecedor"
        Me.colFornecedor.FieldName = "Fornecedor"
        Me.colFornecedor.Name = "colFornecedor"
        Me.colFornecedor.OptionsColumn.ReadOnly = True
        Me.colFornecedor.Visible = True
        Me.colFornecedor.VisibleIndex = 0
        Me.colFornecedor.Width = 246
        '
        'colCodProd
        '
        Me.colCodProd.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCodProd.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodProd.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodProd.AppearanceCell.Options.UseBackColor = True
        Me.colCodProd.AppearanceCell.Options.UseTextOptions = True
        Me.colCodProd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodProd.Caption = "Cód. Prod."
        Me.colCodProd.FieldName = "CodProd"
        Me.colCodProd.Name = "colCodProd"
        Me.colCodProd.OptionsColumn.ReadOnly = True
        Me.colCodProd.Visible = True
        Me.colCodProd.VisibleIndex = 1
        Me.colCodProd.Width = 91
        '
        'colProduto
        '
        Me.colProduto.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colProduto.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colProduto.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colProduto.AppearanceCell.Options.UseBackColor = True
        Me.colProduto.Caption = "Produto"
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 2
        Me.colProduto.Width = 314
        '
        'colEntrada
        '
        Me.colEntrada.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colEntrada.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colEntrada.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colEntrada.AppearanceCell.Options.UseBackColor = True
        Me.colEntrada.AppearanceCell.Options.UseTextOptions = True
        Me.colEntrada.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colEntrada.Caption = "Qtde Estoque"
        Me.colEntrada.DisplayFormat.FormatString = "{0:0.000}"
        Me.colEntrada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEntrada.FieldName = "Entrada"
        Me.colEntrada.Name = "colEntrada"
        Me.colEntrada.OptionsColumn.ReadOnly = True
        Me.colEntrada.SummaryItem.DisplayFormat = "{0:0.000}"
        Me.colEntrada.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colEntrada.Visible = True
        Me.colEntrada.VisibleIndex = 3
        Me.colEntrada.Width = 111
        '
        'colSaida
        '
        Me.colSaida.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSaida.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colSaida.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colSaida.AppearanceCell.Options.UseBackColor = True
        Me.colSaida.AppearanceCell.Options.UseTextOptions = True
        Me.colSaida.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSaida.Caption = "Saída"
        Me.colSaida.DisplayFormat.FormatString = "{0:0.000}"
        Me.colSaida.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSaida.FieldName = "Saida"
        Me.colSaida.Name = "colSaida"
        Me.colSaida.OptionsColumn.ReadOnly = True
        Me.colSaida.SummaryItem.DisplayFormat = "{0:0.000}"
        Me.colSaida.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSaida.Visible = True
        Me.colSaida.VisibleIndex = 4
        Me.colSaida.Width = 115
        '
        'colGiro
        '
        Me.colGiro.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colGiro.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colGiro.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colGiro.AppearanceCell.Options.UseBackColor = True
        Me.colGiro.AppearanceCell.Options.UseTextOptions = True
        Me.colGiro.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colGiro.Caption = "Giro %"
        Me.colGiro.FieldName = "Giro"
        Me.colGiro.Name = "colGiro"
        Me.colGiro.OptionsColumn.ReadOnly = True
        Me.colGiro.Visible = True
        Me.colGiro.VisibleIndex = 5
        Me.colGiro.Width = 106
        '
        'colSaldo
        '
        Me.colSaldo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSaldo.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colSaldo.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colSaldo.AppearanceCell.Options.UseBackColor = True
        Me.colSaldo.AppearanceCell.Options.UseTextOptions = True
        Me.colSaldo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSaldo.Caption = "Saldo"
        Me.colSaldo.FieldName = "Saldo"
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.OptionsColumn.ReadOnly = True
        Me.colSaldo.Width = 96
        '
        'colSetor
        '
        Me.colSetor.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colSetor.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colSetor.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colSetor.AppearanceCell.Options.UseBackColor = True
        Me.colSetor.Caption = "Setor"
        Me.colSetor.FieldName = "Setor"
        Me.colSetor.Name = "colSetor"
        Me.colSetor.OptionsColumn.ReadOnly = True
        '
        'colGrupo
        '
        Me.colGrupo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colGrupo.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colGrupo.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colGrupo.AppearanceCell.Options.UseBackColor = True
        Me.colGrupo.Caption = "Grupo"
        Me.colGrupo.FieldName = "Grupo"
        Me.colGrupo.Name = "colGrupo"
        Me.colGrupo.OptionsColumn.ReadOnly = True
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.dtInicial, Me.dtFinal, Me.lueLoja, Me.btnFiltrar, Me.btnFechar, Me.bsiVisu, Me.btnRelGir, Me.btnRelCust})
        Me.BarManager1.MaxItemId = 9
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.lueLoj})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtInicial, "", False, True, True, 104, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtFinal, "", True, True, True, 105, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.lueLoja, "", True, True, True, 106, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFiltrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bsiVisu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'dtInicial
        '
        Me.dtInicial.Caption = "Data Inicial"
        Me.dtInicial.Edit = Me.RepositoryItemDateEdit1
        Me.dtInicial.Id = 0
        Me.dtInicial.Name = "dtInicial"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'dtFinal
        '
        Me.dtFinal.Caption = "Data Final"
        Me.dtFinal.Edit = Me.RepositoryItemDateEdit2
        Me.dtFinal.Id = 1
        Me.dtFinal.Name = "dtFinal"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        Me.RepositoryItemDateEdit2.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'lueLoja
        '
        Me.lueLoja.Caption = "Loja"
        Me.lueLoja.Edit = Me.lueLoj
        Me.lueLoja.Id = 2
        Me.lueLoja.Name = "lueLoja"
        '
        'lueLoj
        '
        Me.lueLoj.AutoHeight = False
        Me.lueLoj.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLoj.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descrição", 90, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueLoj.DataSource = Me.ConfigBindingSource
        Me.lueLoj.DisplayMember = "Descricao"
        Me.lueLoj.Name = "lueLoj"
        Me.lueLoj.NullText = ""
        Me.lueLoj.ValueMember = "Codigo"
        '
        'ConfigBindingSource
        '
        Me.ConfigBindingSource.DataMember = "Config"
        Me.ConfigBindingSource.DataSource = Me.DsNanoCommerce
        '
        'DsNanoCommerce
        '
        Me.DsNanoCommerce.DataSetName = "dsNanoCommerce"
        Me.DsNanoCommerce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Caption = "F&iltrar"
        Me.btnFiltrar.Glyph = Global.Nano.My.Resources.Resources.Filter
        Me.btnFiltrar.Id = 3
        Me.btnFiltrar.Name = "btnFiltrar"
        '
        'bsiVisu
        '
        Me.bsiVisu.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.bsiVisu.Caption = "&Visualizar"
        Me.bsiVisu.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.bsiVisu.Id = 6
        Me.bsiVisu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelGir), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCust)})
        Me.bsiVisu.Name = "bsiVisu"
        '
        'btnRelGir
        '
        Me.btnRelGir.Caption = "Relatório de Giro"
        Me.btnRelGir.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnRelGir.Id = 7
        Me.btnRelGir.Name = "btnRelGir"
        '
        'btnRelCust
        '
        Me.btnRelCust.Caption = "Relatório Customizado"
        Me.btnRelCust.Glyph = Global.Nano.My.Resources.Resources.kghostview
        Me.btnRelCust.Id = 8
        Me.btnRelCust.Name = "btnRelCust"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 5
        Me.btnFechar.Name = "btnFechar"
        '
        'ConfigTableAdapter
        '
        Me.ConfigTableAdapter.ClearBeforeFill = True
        '
        'frmRelGiroConsumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmRelGiroConsumo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Giro"
        CType(Me.dsGiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbGiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotGer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotPro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLoj, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dsGiro As System.Data.DataSet
    Friend WithEvents tbGiro As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFornecedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEntrada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGiro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtInicial As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtFinal As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents lueLoja As DevExpress.XtraBars.BarEditItem
    Friend WithEvents lueLoj As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnFiltrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfigTableAdapter As Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
    Friend WithEvents bsiVisu As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnRelGir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRelCust As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents colSetor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnPadrao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnManter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTotGer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotGer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotPro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCalcular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblProd As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents colGrupo As DevExpress.XtraGrid.Columns.GridColumn
End Class
