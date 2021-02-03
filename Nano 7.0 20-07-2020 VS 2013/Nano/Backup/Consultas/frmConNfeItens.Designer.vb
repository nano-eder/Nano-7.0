<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConNfeItens
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConNfeItens))
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
        Me.ItensNfeGridControl = New DevExpress.XtraGrid.GridControl
        Me.ItensNfeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodBarra = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQCom = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVUnCom = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCSTICMS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValICMS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValICMSST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCSTIPI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValIPI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVCalcCred = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumNF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ItensNfeTableAdapter = New Nano.dsNanoCommerceTableAdapters.ItensNfeTableAdapter
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.ItensNfeGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItensNfeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnFiltrar, Me.dtInicial, Me.dtFinal, Me.btnVisualizar, Me.btnFechar})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtInicial, "", False, True, True, 104, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtFinal, "", True, True, True, 106, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFiltrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnVisualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'dtInicial
        '
        Me.dtInicial.Caption = "Data Inicial"
        Me.dtInicial.Edit = Me.RepositoryItemDateEdit1
        Me.dtInicial.Id = 1
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
        Me.dtFinal.Id = 2
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
        Me.btnFiltrar.Id = 0
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
        Me.GroupControl1.Controls.Add(Me.ItensNfeGridControl)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1008, 626)
        Me.GroupControl1.TabIndex = 4
        '
        'ItensNfeGridControl
        '
        Me.ItensNfeGridControl.DataSource = Me.ItensNfeBindingSource
        Me.ItensNfeGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItensNfeGridControl.EmbeddedNavigator.Name = ""
        Me.ItensNfeGridControl.Location = New System.Drawing.Point(2, 2)
        Me.ItensNfeGridControl.MainView = Me.grd1
        Me.ItensNfeGridControl.Name = "ItensNfeGridControl"
        Me.ItensNfeGridControl.Size = New System.Drawing.Size(1004, 589)
        Me.ItensNfeGridControl.TabIndex = 0
        Me.ItensNfeGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'ItensNfeBindingSource
        '
        Me.ItensNfeBindingSource.DataMember = "ItensNfe"
        Me.ItensNfeBindingSource.DataSource = Me.DsNanoCommerce
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
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodProd, Me.colCodInterno, Me.colCodBarra, Me.colProduto, Me.colQCom, Me.colVUnCom, Me.colVProd, Me.colCSTICMS, Me.colValICMS, Me.colValICMSST, Me.colCSTIPI, Me.colValIPI, Me.colVCalcCred, Me.colNumNF, Me.colData})
        Me.grd1.GridControl = Me.ItensNfeGridControl
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowFooter = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodProd
        '
        Me.colCodProd.Caption = "CodProd"
        Me.colCodProd.FieldName = "CodProd"
        Me.colCodProd.Name = "colCodProd"
        Me.colCodProd.OptionsColumn.ReadOnly = True
        '
        'colCodInterno
        '
        Me.colCodInterno.AppearanceCell.Options.UseTextOptions = True
        Me.colCodInterno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodInterno.Caption = "Cód. Prod."
        Me.colCodInterno.FieldName = "CodInterno"
        Me.colCodInterno.Name = "colCodInterno"
        Me.colCodInterno.OptionsColumn.ReadOnly = True
        Me.colCodInterno.Visible = True
        Me.colCodInterno.VisibleIndex = 2
        Me.colCodInterno.Width = 74
        '
        'colCodBarra
        '
        Me.colCodBarra.Caption = "Cód. Barra"
        Me.colCodBarra.FieldName = "CodBarra"
        Me.colCodBarra.Name = "colCodBarra"
        Me.colCodBarra.OptionsColumn.ReadOnly = True
        Me.colCodBarra.Width = 80
        '
        'colProduto
        '
        Me.colProduto.Caption = "Produto"
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 3
        Me.colProduto.Width = 224
        '
        'colQCom
        '
        Me.colQCom.Caption = "Qtde"
        Me.colQCom.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQCom.FieldName = "QCom"
        Me.colQCom.Name = "colQCom"
        Me.colQCom.OptionsColumn.ReadOnly = True
        Me.colQCom.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colQCom.Visible = True
        Me.colQCom.VisibleIndex = 4
        Me.colQCom.Width = 50
        '
        'colVUnCom
        '
        Me.colVUnCom.Caption = "V. Unit. R$"
        Me.colVUnCom.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVUnCom.FieldName = "VUnCom"
        Me.colVUnCom.Name = "colVUnCom"
        Me.colVUnCom.OptionsColumn.ReadOnly = True
        Me.colVUnCom.SummaryItem.DisplayFormat = "{0:c}"
        Me.colVUnCom.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colVUnCom.Visible = True
        Me.colVUnCom.VisibleIndex = 5
        Me.colVUnCom.Width = 74
        '
        'colVProd
        '
        Me.colVProd.Caption = "V. Total R$"
        Me.colVProd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVProd.FieldName = "VProd"
        Me.colVProd.Name = "colVProd"
        Me.colVProd.OptionsColumn.ReadOnly = True
        Me.colVProd.SummaryItem.DisplayFormat = "{0:c}"
        Me.colVProd.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colVProd.Visible = True
        Me.colVProd.VisibleIndex = 6
        '
        'colCSTICMS
        '
        Me.colCSTICMS.AppearanceCell.Options.UseTextOptions = True
        Me.colCSTICMS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCSTICMS.Caption = "CST ICMS"
        Me.colCSTICMS.FieldName = "CSTICMS"
        Me.colCSTICMS.Name = "colCSTICMS"
        Me.colCSTICMS.OptionsColumn.ReadOnly = True
        Me.colCSTICMS.Visible = True
        Me.colCSTICMS.VisibleIndex = 7
        Me.colCSTICMS.Width = 69
        '
        'colValICMS
        '
        Me.colValICMS.AppearanceCell.Options.UseTextOptions = True
        Me.colValICMS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValICMS.Caption = "V. ICMS R$"
        Me.colValICMS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValICMS.FieldName = "ValICMS"
        Me.colValICMS.Name = "colValICMS"
        Me.colValICMS.OptionsColumn.ReadOnly = True
        Me.colValICMS.SummaryItem.DisplayFormat = "{0:c}"
        Me.colValICMS.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colValICMS.Visible = True
        Me.colValICMS.VisibleIndex = 8
        Me.colValICMS.Width = 76
        '
        'colValICMSST
        '
        Me.colValICMSST.AppearanceCell.Options.UseTextOptions = True
        Me.colValICMSST.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValICMSST.Caption = "V. ST R$"
        Me.colValICMSST.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValICMSST.FieldName = "ValICMSST"
        Me.colValICMSST.Name = "colValICMSST"
        Me.colValICMSST.OptionsColumn.ReadOnly = True
        Me.colValICMSST.SummaryItem.DisplayFormat = "{0:c}"
        Me.colValICMSST.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colValICMSST.Visible = True
        Me.colValICMSST.VisibleIndex = 9
        Me.colValICMSST.Width = 63
        '
        'colCSTIPI
        '
        Me.colCSTIPI.AppearanceCell.Options.UseTextOptions = True
        Me.colCSTIPI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCSTIPI.Caption = "CST IPI"
        Me.colCSTIPI.FieldName = "CSTIPI"
        Me.colCSTIPI.Name = "colCSTIPI"
        Me.colCSTIPI.OptionsColumn.ReadOnly = True
        Me.colCSTIPI.Visible = True
        Me.colCSTIPI.VisibleIndex = 10
        Me.colCSTIPI.Width = 58
        '
        'colValIPI
        '
        Me.colValIPI.AppearanceCell.Options.UseTextOptions = True
        Me.colValIPI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValIPI.Caption = "V. IPI R$"
        Me.colValIPI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValIPI.FieldName = "ValIPI"
        Me.colValIPI.Name = "colValIPI"
        Me.colValIPI.OptionsColumn.ReadOnly = True
        Me.colValIPI.SummaryItem.DisplayFormat = "{0:c}"
        Me.colValIPI.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colValIPI.Visible = True
        Me.colValIPI.VisibleIndex = 11
        Me.colValIPI.Width = 63
        '
        'colVCalcCred
        '
        Me.colVCalcCred.Caption = "VCalcCred"
        Me.colVCalcCred.FieldName = "VCalcCred"
        Me.colVCalcCred.Name = "colVCalcCred"
        Me.colVCalcCred.OptionsColumn.ReadOnly = True
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
        Me.colNumNF.Width = 81
        '
        'colData
        '
        Me.colData.AppearanceCell.Options.UseTextOptions = True
        Me.colData.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData.Caption = "Data"
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.OptionsColumn.ReadOnly = True
        Me.colData.Visible = True
        Me.colData.VisibleIndex = 1
        Me.colData.Width = 76
        '
        'ItensNfeTableAdapter
        '
        Me.ItensNfeTableAdapter.ClearBeforeFill = True
        '
        'frmConNfeItens
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
        Me.Name = "frmConNfeItens"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Itens de Notas Fiscais"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.ItensNfeGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItensNfeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ItensNfeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents ItensNfeTableAdapter As Nano.dsNanoCommerceTableAdapters.ItensNfeTableAdapter
    Friend WithEvents ItensNfeGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodBarra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQCom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVUnCom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCSTICMS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValICMS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValICMSST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCSTIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVCalcCred As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumNF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnFiltrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtInicial As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtFinal As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnVisualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
End Class
