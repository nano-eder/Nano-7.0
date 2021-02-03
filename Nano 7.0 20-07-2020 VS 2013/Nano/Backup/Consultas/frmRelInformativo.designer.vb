<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelInformativo
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
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelInformativo))
        Me.colFornecedor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsInf = New System.Data.DataSet
        Me.tbInf = New System.Data.DataTable
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
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colJan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFev = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAbr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colJun = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colJul = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAgo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNov = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDez = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPeriodo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGrupo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.cboAno = New DevExpress.XtraBars.BarEditItem
        Me.cboAno1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.btnFiltrar = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem
        Me.btnVisualizar = New DevExpress.XtraBars.BarButtonItem
        Me.btnRelCust = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsInf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbInf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAno1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colFornecedor
        '
        Me.colFornecedor.Caption = "Fornecedor"
        Me.colFornecedor.FieldName = "Fornecedor"
        Me.colFornecedor.Name = "colFornecedor"
        Me.colFornecedor.OptionsColumn.ReadOnly = True
        Me.colFornecedor.Visible = True
        Me.colFornecedor.VisibleIndex = 0
        Me.colFornecedor.Width = 175
        '
        'colNome
        '
        Me.colNome.Caption = "Grupo"
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.OptionsColumn.ReadOnly = True
        Me.colNome.Visible = True
        Me.colNome.VisibleIndex = 0
        Me.colNome.Width = 122
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbInf"
        Me.GridControl1.DataSource = Me.dsInf
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1008, 626)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'dsInf
        '
        Me.dsInf.DataSetName = "NewDataSet"
        Me.dsInf.Tables.AddRange(New System.Data.DataTable() {Me.tbInf})
        '
        'tbInf
        '
        Me.tbInf.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16})
        Me.tbInf.TableName = "tbInf"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Nome"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "1"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "2"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "3"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "4"
        '
        'DataColumn6
        '
        Me.DataColumn6.Caption = "5"
        Me.DataColumn6.ColumnName = "5"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "6"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "7"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "8"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "9"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "10"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "11"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "12"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "Periodo"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "Grupo"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "Fornecedor"
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.Options.UseTextOptions = True
        Me.GridView1.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNome, Me.colJan, Me.colFev, Me.colMar, Me.colAbr, Me.colMai, Me.colJun, Me.colJul, Me.colAgo, Me.colSet, Me.colOut, Me.colNov, Me.colDez, Me.colPeriodo, Me.colGrupo, Me.colFornecedor})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colFornecedor
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "PA"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colFornecedor
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "TICKET MÉDIO"
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        StyleFormatCondition3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Appearance.Options.UseFont = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.colFornecedor
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = "TOTAL"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 2
        Me.GridView1.Name = "GridView1"
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPeriodo, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNome, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colJan
        '
        Me.colJan.AppearanceCell.Options.UseTextOptions = True
        Me.colJan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colJan.Caption = "Jan"
        Me.colJan.FieldName = "1"
        Me.colJan.Name = "colJan"
        Me.colJan.OptionsColumn.ReadOnly = True
        Me.colJan.Visible = True
        Me.colJan.VisibleIndex = 1
        Me.colJan.Width = 68
        '
        'colFev
        '
        Me.colFev.AppearanceCell.Options.UseTextOptions = True
        Me.colFev.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colFev.Caption = "Fev"
        Me.colFev.FieldName = "2"
        Me.colFev.Name = "colFev"
        Me.colFev.OptionsColumn.ReadOnly = True
        Me.colFev.Visible = True
        Me.colFev.VisibleIndex = 2
        Me.colFev.Width = 68
        '
        'colMar
        '
        Me.colMar.AppearanceCell.Options.UseTextOptions = True
        Me.colMar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colMar.Caption = "Mar"
        Me.colMar.FieldName = "3"
        Me.colMar.Name = "colMar"
        Me.colMar.OptionsColumn.ReadOnly = True
        Me.colMar.Visible = True
        Me.colMar.VisibleIndex = 3
        Me.colMar.Width = 68
        '
        'colAbr
        '
        Me.colAbr.AppearanceCell.Options.UseTextOptions = True
        Me.colAbr.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAbr.Caption = "Abr"
        Me.colAbr.FieldName = "4"
        Me.colAbr.Name = "colAbr"
        Me.colAbr.OptionsColumn.ReadOnly = True
        Me.colAbr.Visible = True
        Me.colAbr.VisibleIndex = 4
        Me.colAbr.Width = 68
        '
        'colMai
        '
        Me.colMai.AppearanceCell.Options.UseTextOptions = True
        Me.colMai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colMai.Caption = "Mai"
        Me.colMai.FieldName = "5"
        Me.colMai.Name = "colMai"
        Me.colMai.OptionsColumn.ReadOnly = True
        Me.colMai.Visible = True
        Me.colMai.VisibleIndex = 5
        Me.colMai.Width = 68
        '
        'colJun
        '
        Me.colJun.AppearanceCell.Options.UseTextOptions = True
        Me.colJun.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colJun.Caption = "Jun"
        Me.colJun.FieldName = "6"
        Me.colJun.Name = "colJun"
        Me.colJun.OptionsColumn.ReadOnly = True
        Me.colJun.Visible = True
        Me.colJun.VisibleIndex = 6
        Me.colJun.Width = 68
        '
        'colJul
        '
        Me.colJul.AppearanceCell.Options.UseTextOptions = True
        Me.colJul.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colJul.Caption = "Jul"
        Me.colJul.FieldName = "7"
        Me.colJul.Name = "colJul"
        Me.colJul.OptionsColumn.ReadOnly = True
        Me.colJul.Visible = True
        Me.colJul.VisibleIndex = 7
        Me.colJul.Width = 68
        '
        'colAgo
        '
        Me.colAgo.AppearanceCell.Options.UseTextOptions = True
        Me.colAgo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAgo.Caption = "Ago"
        Me.colAgo.FieldName = "8"
        Me.colAgo.Name = "colAgo"
        Me.colAgo.OptionsColumn.ReadOnly = True
        Me.colAgo.Visible = True
        Me.colAgo.VisibleIndex = 8
        Me.colAgo.Width = 68
        '
        'colSet
        '
        Me.colSet.AppearanceCell.Options.UseTextOptions = True
        Me.colSet.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSet.Caption = "Set"
        Me.colSet.FieldName = "9"
        Me.colSet.Name = "colSet"
        Me.colSet.OptionsColumn.ReadOnly = True
        Me.colSet.Visible = True
        Me.colSet.VisibleIndex = 9
        Me.colSet.Width = 68
        '
        'colOut
        '
        Me.colOut.AppearanceCell.Options.UseTextOptions = True
        Me.colOut.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colOut.Caption = "Out"
        Me.colOut.FieldName = "10"
        Me.colOut.Name = "colOut"
        Me.colOut.OptionsColumn.ReadOnly = True
        Me.colOut.Visible = True
        Me.colOut.VisibleIndex = 10
        Me.colOut.Width = 68
        '
        'colNov
        '
        Me.colNov.AppearanceCell.Options.UseTextOptions = True
        Me.colNov.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colNov.Caption = "Nov"
        Me.colNov.FieldName = "11"
        Me.colNov.Name = "colNov"
        Me.colNov.OptionsColumn.ReadOnly = True
        Me.colNov.Visible = True
        Me.colNov.VisibleIndex = 11
        Me.colNov.Width = 68
        '
        'colDez
        '
        Me.colDez.AppearanceCell.Options.UseTextOptions = True
        Me.colDez.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDez.Caption = "Dez"
        Me.colDez.FieldName = "12"
        Me.colDez.Name = "colDez"
        Me.colDez.OptionsColumn.ReadOnly = True
        Me.colDez.Visible = True
        Me.colDez.VisibleIndex = 12
        Me.colDez.Width = 64
        '
        'colPeriodo
        '
        Me.colPeriodo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colPeriodo.AppearanceCell.Options.UseFont = True
        Me.colPeriodo.Caption = "Período"
        Me.colPeriodo.FieldName = "Periodo"
        Me.colPeriodo.Name = "colPeriodo"
        '
        'colGrupo
        '
        Me.colGrupo.Caption = "Grupo"
        Me.colGrupo.FieldName = "Grupo"
        Me.colGrupo.Name = "colGrupo"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.cboAno, Me.btnFechar, Me.btnFiltrar, Me.btnVisualizar, Me.btnRelCust})
        Me.BarManager1.MaxItemId = 6
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboAno1})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.cboAno, "", False, True, True, 98, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFiltrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'cboAno
        '
        Me.cboAno.Caption = "Ano"
        Me.cboAno.Edit = Me.cboAno1
        Me.cboAno.Id = 1
        Me.cboAno.Name = "cboAno"
        '
        'cboAno1
        '
        Me.cboAno1.AutoHeight = False
        Me.cboAno1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAno1.Name = "cboAno1"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Caption = "F&iltrar"
        Me.btnFiltrar.Glyph = Global.Nano.My.Resources.Resources.Filter
        Me.btnFiltrar.Id = 3
        Me.btnFiltrar.Name = "btnFiltrar"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarSubItem1.Caption = "&Visualizar"
        Me.BarSubItem1.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.BarSubItem1.Id = 0
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnVisualizar), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCust)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Caption = "&Relatório Informativo"
        Me.btnVisualizar.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnVisualizar.Id = 4
        Me.btnVisualizar.Name = "btnVisualizar"
        '
        'btnRelCust
        '
        Me.btnRelCust.Caption = "Relatório C&ustomizado"
        Me.btnRelCust.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnRelCust.Id = 5
        Me.btnRelCust.Name = "btnRelCust"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 2
        Me.btnFechar.Name = "btnFechar"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Mais.png")
        Me.ImageList1.Images.SetKeyName(1, "Menos.png")
        '
        'frmRelInformativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRelInformativo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório Informativo"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsInf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbInf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAno1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents dsInf As System.Data.DataSet
    Friend WithEvents tbInf As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFev As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAbr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJul As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAgo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNov As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDez As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents colPeriodo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrupo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents cboAno As DevExpress.XtraBars.BarEditItem
    Friend WithEvents cboAno1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents btnFiltrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnVisualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRelCust As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents colFornecedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
