<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConNfeTotal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConNfeTotal))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.dtInicial = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.dtFinal = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.btnFiltrar = New DevExpress.XtraBars.BarButtonItem
        Me.btnVisualizar = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.lblChave = New DevExpress.XtraEditors.LabelControl
        Me.btnCalcular = New DevExpress.XtraEditors.SimpleButton
        Me.TotalNfeGridControl = New DevExpress.XtraGrid.GridControl
        Me.TotalNfeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNumNF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colChave = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDEmi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodCli = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVICMS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVIPI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVNF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNatOp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodVenda = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSerie = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodNF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.txtTotGer = New DevExpress.XtraEditors.TextEdit
        Me.lblTotGer = New DevExpress.XtraEditors.LabelControl
        Me.TotalNfeTableAdapter = New Nano.dsNanoCommerceTableAdapters.TotalNfeTableAdapter
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TotalNfeGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalNfeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotGer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.dtInicial, Me.dtFinal, Me.btnFiltrar, Me.btnVisualizar, Me.btnFechar})
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtInicial, "", False, True, True, 108, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtFinal, "", True, True, True, 102, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFiltrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnVisualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
        'btnFiltrar
        '
        Me.btnFiltrar.Caption = "F&iltrar"
        Me.btnFiltrar.Glyph = Global.Nano.My.Resources.Resources.Filter
        Me.btnFiltrar.Id = 2
        Me.btnFiltrar.Name = "btnFiltrar"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnVisualizar.Caption = "&Visualizar"
        Me.btnVisualizar.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnVisualizar.Id = 3
        Me.btnVisualizar.Name = "btnVisualizar"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 4
        Me.btnFechar.Name = "btnFechar"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl1.Controls.Add(Me.lblChave)
        Me.GroupControl1.Controls.Add(Me.btnCalcular)
        Me.GroupControl1.Controls.Add(Me.TotalNfeGridControl)
        Me.GroupControl1.Controls.Add(Me.txtTotGer)
        Me.GroupControl1.Controls.Add(Me.lblTotGer)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1055, 626)
        Me.GroupControl1.TabIndex = 5
        '
        'lblChave
        '
        Me.lblChave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblChave.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChave.Appearance.Options.UseFont = True
        Me.lblChave.Location = New System.Drawing.Point(15, 605)
        Me.lblChave.Name = "lblChave"
        Me.lblChave.Size = New System.Drawing.Size(95, 13)
        Me.lblChave.TabIndex = 12
        Me.lblChave.Text = "Chave de Acesso"
        Me.lblChave.Visible = False
        '
        'btnCalcular
        '
        Me.btnCalcular.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalcular.Image = Global.Nano.My.Resources.Resources.Calculator2
        Me.btnCalcular.Location = New System.Drawing.Point(666, 597)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(96, 26)
        Me.btnCalcular.TabIndex = 11
        Me.btnCalcular.Text = "Calcular"
        '
        'TotalNfeGridControl
        '
        Me.TotalNfeGridControl.DataSource = Me.TotalNfeBindingSource
        Me.TotalNfeGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalNfeGridControl.EmbeddedNavigator.Name = ""
        Me.TotalNfeGridControl.Location = New System.Drawing.Point(2, 2)
        Me.TotalNfeGridControl.MainView = Me.grd1
        Me.TotalNfeGridControl.Name = "TotalNfeGridControl"
        Me.TotalNfeGridControl.Size = New System.Drawing.Size(1051, 589)
        Me.TotalNfeGridControl.TabIndex = 0
        Me.TotalNfeGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1, Me.GridView2})
        '
        'TotalNfeBindingSource
        '
        Me.TotalNfeBindingSource.DataMember = "TotalNfe"
        Me.TotalNfeBindingSource.DataSource = Me.DsNanoCommerce
        '
        'DsNanoCommerce
        '
        Me.DsNanoCommerce.DataSetName = "dsNanoCommerce"
        Me.DsNanoCommerce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumNF, Me.colChave, Me.colDEmi, Me.colCodCli, Me.colVICMS, Me.colVST, Me.colVProd, Me.colVIPI, Me.colVNF, Me.colCliente, Me.colNatOp, Me.colCodVenda, Me.colSerie, Me.colCodNF})
        Me.grd1.GridControl = Me.TotalNfeGridControl
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowFooter = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colNumNF
        '
        Me.colNumNF.AppearanceCell.Options.UseTextOptions = True
        Me.colNumNF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumNF.Caption = "Nº NF"
        Me.colNumNF.FieldName = "NumNF"
        Me.colNumNF.Name = "colNumNF"
        Me.colNumNF.OptionsColumn.ReadOnly = True
        Me.colNumNF.Visible = True
        Me.colNumNF.VisibleIndex = 0
        Me.colNumNF.Width = 66
        '
        'colChave
        '
        Me.colChave.Caption = "Chave"
        Me.colChave.FieldName = "Chave"
        Me.colChave.Name = "colChave"
        Me.colChave.OptionsColumn.ReadOnly = True
        Me.colChave.Width = 165
        '
        'colDEmi
        '
        Me.colDEmi.Caption = "Data"
        Me.colDEmi.FieldName = "DEmi"
        Me.colDEmi.Name = "colDEmi"
        Me.colDEmi.OptionsColumn.ReadOnly = True
        Me.colDEmi.Visible = True
        Me.colDEmi.VisibleIndex = 1
        Me.colDEmi.Width = 73
        '
        'colCodCli
        '
        Me.colCodCli.Caption = "CodCli"
        Me.colCodCli.FieldName = "CodCli"
        Me.colCodCli.Name = "colCodCli"
        Me.colCodCli.OptionsColumn.ReadOnly = True
        Me.colCodCli.Width = 124
        '
        'colVICMS
        '
        Me.colVICMS.Caption = "Val. ICMS R$"
        Me.colVICMS.DisplayFormat.FormatString = "c"
        Me.colVICMS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVICMS.FieldName = "VICMS"
        Me.colVICMS.Name = "colVICMS"
        Me.colVICMS.OptionsColumn.ReadOnly = True
        Me.colVICMS.SummaryItem.DisplayFormat = "{0:c}"
        Me.colVICMS.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colVICMS.Visible = True
        Me.colVICMS.VisibleIndex = 6
        Me.colVICMS.Width = 84
        '
        'colVST
        '
        Me.colVST.Caption = "Val. ST R$"
        Me.colVST.DisplayFormat.FormatString = "c"
        Me.colVST.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVST.FieldName = "VST"
        Me.colVST.Name = "colVST"
        Me.colVST.OptionsColumn.ReadOnly = True
        Me.colVST.SummaryItem.DisplayFormat = "{0:c}"
        Me.colVST.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colVST.Visible = True
        Me.colVST.VisibleIndex = 7
        Me.colVST.Width = 71
        '
        'colVProd
        '
        Me.colVProd.Caption = "Val. Prod. R$"
        Me.colVProd.DisplayFormat.FormatString = "c"
        Me.colVProd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVProd.FieldName = "VProd"
        Me.colVProd.Name = "colVProd"
        Me.colVProd.OptionsColumn.ReadOnly = True
        Me.colVProd.SummaryItem.DisplayFormat = "{0:c}"
        Me.colVProd.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colVProd.Visible = True
        Me.colVProd.VisibleIndex = 5
        Me.colVProd.Width = 85
        '
        'colVIPI
        '
        Me.colVIPI.Caption = "Val. IPI R$"
        Me.colVIPI.DisplayFormat.FormatString = "c"
        Me.colVIPI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVIPI.FieldName = "VIPI"
        Me.colVIPI.Name = "colVIPI"
        Me.colVIPI.OptionsColumn.ReadOnly = True
        Me.colVIPI.SummaryItem.DisplayFormat = "{0:c}"
        Me.colVIPI.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colVIPI.Visible = True
        Me.colVIPI.VisibleIndex = 8
        Me.colVIPI.Width = 73
        '
        'colVNF
        '
        Me.colVNF.Caption = "Val. NF R$"
        Me.colVNF.DisplayFormat.FormatString = "c"
        Me.colVNF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVNF.FieldName = "VNF"
        Me.colVNF.Name = "colVNF"
        Me.colVNF.OptionsColumn.ReadOnly = True
        Me.colVNF.SummaryItem.DisplayFormat = "{0:c}"
        Me.colVNF.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colVNF.Visible = True
        Me.colVNF.VisibleIndex = 9
        Me.colVNF.Width = 72
        '
        'colCliente
        '
        Me.colCliente.Caption = "Destinatário"
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.ReadOnly = True
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 4
        Me.colCliente.Width = 224
        '
        'colNatOp
        '
        Me.colNatOp.Caption = "Nat. Op."
        Me.colNatOp.FieldName = "NatOp"
        Me.colNatOp.Name = "colNatOp"
        Me.colNatOp.OptionsColumn.ReadOnly = True
        Me.colNatOp.Visible = True
        Me.colNatOp.VisibleIndex = 10
        Me.colNatOp.Width = 77
        '
        'colCodVenda
        '
        Me.colCodVenda.AppearanceCell.Options.UseTextOptions = True
        Me.colCodVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodVenda.Caption = "Cód. Venda"
        Me.colCodVenda.FieldName = "CodVenda"
        Me.colCodVenda.Name = "colCodVenda"
        Me.colCodVenda.OptionsColumn.ReadOnly = True
        Me.colCodVenda.Visible = True
        Me.colCodVenda.VisibleIndex = 11
        Me.colCodVenda.Width = 79
        '
        'colSerie
        '
        Me.colSerie.AppearanceCell.Options.UseTextOptions = True
        Me.colSerie.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSerie.Caption = "Série"
        Me.colSerie.FieldName = "Serie"
        Me.colSerie.Name = "colSerie"
        Me.colSerie.OptionsColumn.ReadOnly = True
        Me.colSerie.Visible = True
        Me.colSerie.VisibleIndex = 2
        Me.colSerie.Width = 51
        '
        'colCodNF
        '
        Me.colCodNF.AppearanceCell.Options.UseTextOptions = True
        Me.colCodNF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodNF.Caption = "Cód. NF"
        Me.colCodNF.FieldName = "CodNF"
        Me.colCodNF.Name = "colCodNF"
        Me.colCodNF.OptionsColumn.ReadOnly = True
        Me.colCodNF.Visible = True
        Me.colCodNF.VisibleIndex = 3
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.TotalNfeGridControl
        Me.GridView2.Name = "GridView2"
        '
        'txtTotGer
        '
        Me.txtTotGer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotGer.Location = New System.Drawing.Point(881, 597)
        Me.txtTotGer.Name = "txtTotGer"
        Me.txtTotGer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotGer.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtTotGer.Properties.Appearance.Options.UseFont = True
        Me.txtTotGer.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotGer.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotGer.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotGer.Size = New System.Drawing.Size(162, 26)
        Me.txtTotGer.TabIndex = 8
        '
        'lblTotGer
        '
        Me.lblTotGer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotGer.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotGer.Appearance.Options.UseFont = True
        Me.lblTotGer.Location = New System.Drawing.Point(812, 605)
        Me.lblTotGer.Name = "lblTotGer"
        Me.lblTotGer.Size = New System.Drawing.Size(63, 13)
        Me.lblTotGer.TabIndex = 7
        Me.lblTotGer.Text = "Total NF R$"
        '
        'TotalNfeTableAdapter
        '
        Me.TotalNfeTableAdapter.ClearBeforeFill = True
        '
        'frmConNfeTotal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 662)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmConNfeTotal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Notas Fiscais"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TotalNfeGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalNfeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotGer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dtInicial As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtFinal As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnFiltrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVisualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents TotalNfeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents TotalNfeTableAdapter As Nano.dsNanoCommerceTableAdapters.TotalNfeTableAdapter
    Friend WithEvents TotalNfeGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumNF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChave As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodCli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVICMS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVNF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnCalcular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTotGer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTotGer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colNatOp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblChave As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colSerie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodNF As DevExpress.XtraGrid.Columns.GridColumn
End Class
