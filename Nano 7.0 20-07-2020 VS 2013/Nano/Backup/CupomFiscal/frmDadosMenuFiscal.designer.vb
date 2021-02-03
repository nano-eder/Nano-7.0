<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDadosMenuFiscal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDadosMenuFiscal))
        Me.pnlBusca = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.cboBusca = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtFim = New Campos.NanoCampo
        Me.txtInicio = New Campos.NanoCampo
        Me.dtInicial = New DevExpress.XtraEditors.DateEdit
        Me.lblFim = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.lblInicio = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.dtFinal = New DevExpress.XtraEditors.DateEdit
        Me.pnlDestino = New DevExpress.XtraEditors.PanelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsPag = New System.Data.DataSet
        Me.tbPag = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescricao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.cboTipoSaida = New DevExpress.XtraEditors.ComboBoxEdit
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnOk = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        CType(Me.pnlBusca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBusca.SuspendLayout()
        CType(Me.cboBusca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtInicial.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFinal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDestino.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsPag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbPag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoSaida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBusca
        '
        Me.pnlBusca.Controls.Add(Me.LabelControl3)
        Me.pnlBusca.Controls.Add(Me.cboBusca)
        Me.pnlBusca.Controls.Add(Me.txtFim)
        Me.pnlBusca.Controls.Add(Me.txtInicio)
        Me.pnlBusca.Controls.Add(Me.dtInicial)
        Me.pnlBusca.Controls.Add(Me.lblFim)
        Me.pnlBusca.Controls.Add(Me.LabelControl1)
        Me.pnlBusca.Controls.Add(Me.lblInicio)
        Me.pnlBusca.Controls.Add(Me.LabelControl2)
        Me.pnlBusca.Controls.Add(Me.dtFinal)
        Me.pnlBusca.Location = New System.Drawing.Point(12, 61)
        Me.pnlBusca.Name = "pnlBusca"
        Me.pnlBusca.Size = New System.Drawing.Size(331, 87)
        Me.pnlBusca.TabIndex = 22
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(16, 11)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl3.TabIndex = 31
        Me.LabelControl3.Text = "Destino"
        '
        'cboBusca
        '
        Me.cboBusca.EditValue = "PERÍODO"
        Me.cboBusca.EnterMoveNextControl = True
        Me.cboBusca.Location = New System.Drawing.Point(60, 8)
        Me.cboBusca.Name = "cboBusca"
        Me.cboBusca.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBusca.Properties.Items.AddRange(New Object() {"PERÍODO", "REDUÇÃO Z"})
        Me.cboBusca.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboBusca.Size = New System.Drawing.Size(100, 20)
        Me.cboBusca.TabIndex = 30
        '
        'txtFim
        '
        Me.txtFim.CasasDecimais = 0
        Me.txtFim.EnterMoveNextControl = True
        Me.txtFim.Location = New System.Drawing.Point(216, 60)
        Me.txtFim.Name = "txtFim"
        Me.txtFim.Numerico = True
        Me.txtFim.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtFim.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtFim.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtFim.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtFim.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFim.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtFim.Properties.MaxLength = 4
        Me.txtFim.Size = New System.Drawing.Size(100, 20)
        Me.txtFim.TabIndex = 29
        Me.txtFim.Tag = "Número"
        '
        'txtInicio
        '
        Me.txtInicio.CasasDecimais = 0
        Me.txtInicio.EnterMoveNextControl = True
        Me.txtInicio.Location = New System.Drawing.Point(60, 60)
        Me.txtInicio.Name = "txtInicio"
        Me.txtInicio.Numerico = True
        Me.txtInicio.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtInicio.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtInicio.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtInicio.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtInicio.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtInicio.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtInicio.Properties.MaxLength = 4
        Me.txtInicio.Size = New System.Drawing.Size(100, 20)
        Me.txtInicio.TabIndex = 8
        Me.txtInicio.Tag = "Número"
        '
        'dtInicial
        '
        Me.dtInicial.EditValue = Nothing
        Me.dtInicial.Location = New System.Drawing.Point(60, 34)
        Me.dtInicial.Name = "dtInicial"
        Me.dtInicial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtInicial.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtInicial.Size = New System.Drawing.Size(100, 20)
        Me.dtInicial.TabIndex = 2
        '
        'lblFim
        '
        Me.lblFim.Location = New System.Drawing.Point(170, 63)
        Me.lblFim.Name = "lblFim"
        Me.lblFim.Size = New System.Drawing.Size(38, 13)
        Me.lblFim.TabIndex = 28
        Me.lblFim.Text = "RZ Final"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(25, 37)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Inicial"
        '
        'lblInicio
        '
        Me.lblInicio.Location = New System.Drawing.Point(9, 63)
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Size = New System.Drawing.Size(43, 13)
        Me.lblInicio.TabIndex = 27
        Me.lblInicio.Text = "RZ Inicial"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(186, 37)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Final"
        '
        'dtFinal
        '
        Me.dtFinal.EditValue = Nothing
        Me.dtFinal.Location = New System.Drawing.Point(216, 34)
        Me.dtFinal.Name = "dtFinal"
        Me.dtFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFinal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtFinal.Size = New System.Drawing.Size(100, 20)
        Me.dtFinal.TabIndex = 3
        '
        'pnlDestino
        '
        Me.pnlDestino.Controls.Add(Me.LabelControl8)
        Me.pnlDestino.Controls.Add(Me.cboTipoSaida)
        Me.pnlDestino.Location = New System.Drawing.Point(12, 12)
        Me.pnlDestino.Name = "pnlDestino"
        Me.pnlDestino.Size = New System.Drawing.Size(331, 43)
        Me.pnlDestino.TabIndex = 21
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbPag"
        Me.GridControl1.DataSource = Me.dsPag
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(198, 22)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(59, 18)
        Me.GridControl1.TabIndex = 32
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsPag
        '
        Me.dsPag.DataSetName = "NewDataSet"
        Me.dsPag.Tables.AddRange(New System.Data.DataTable() {Me.tbPag})
        '
        'tbPag
        '
        Me.tbPag.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4})
        Me.tbPag.TableName = "tbPag"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Data"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Descricao"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Tipo"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Valor"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colData, Me.colDescricao, Me.colTipo, Me.colValor})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colData, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDescricao, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colData
        '
        Me.colData.Caption = "Data"
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.Visible = True
        Me.colData.VisibleIndex = 0
        '
        'colDescricao
        '
        Me.colDescricao.Caption = "Descricao"
        Me.colDescricao.FieldName = "Descricao"
        Me.colDescricao.Name = "colDescricao"
        Me.colDescricao.Visible = True
        Me.colDescricao.VisibleIndex = 1
        '
        'colTipo
        '
        Me.colTipo.Caption = "Tipo"
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.Visible = True
        Me.colTipo.VisibleIndex = 2
        '
        'colValor
        '
        Me.colValor.Caption = "Valor"
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 3
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(16, 14)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl8.TabIndex = 29
        Me.LabelControl8.Text = "Destino"
        '
        'cboTipoSaida
        '
        Me.cboTipoSaida.EditValue = "IMPRESSORA"
        Me.cboTipoSaida.EnterMoveNextControl = True
        Me.cboTipoSaida.Location = New System.Drawing.Point(60, 11)
        Me.cboTipoSaida.Name = "cboTipoSaida"
        Me.cboTipoSaida.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoSaida.Properties.Items.AddRange(New Object() {"IMPRESSORA", "ARQUIVO"})
        Me.cboTipoSaida.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTipoSaida.Size = New System.Drawing.Size(100, 20)
        Me.cboTipoSaida.TabIndex = 25
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnOk, Me.btnFechar})
        Me.BarManager1.MaxItemId = 2
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnOk, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnOk
        '
        Me.btnOk.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnOk.Caption = "&Ok"
        Me.btnOk.Glyph = CType(resources.GetObject("btnOk.Glyph"), System.Drawing.Image)
        Me.btnOk.Id = 0
        Me.btnOk.Name = "btnOk"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = CType(resources.GetObject("btnFechar.Glyph"), System.Drawing.Image)
        Me.btnFechar.Id = 1
        Me.btnFechar.Name = "btnFechar"
        '
        'frmDadosMenuFiscal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 195)
        Me.Controls.Add(Me.pnlBusca)
        Me.Controls.Add(Me.pnlDestino)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDadosMenuFiscal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDadosMenuFiscal"
        CType(Me.pnlBusca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBusca.ResumeLayout(False)
        Me.pnlBusca.PerformLayout()
        CType(Me.cboBusca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtInicial.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFinal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlDestino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDestino.ResumeLayout(False)
        Me.pnlDestino.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsPag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbPag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoSaida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBusca As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dtInicial As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents pnlDestino As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnOk As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cboTipoSaida As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFim As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblInicio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFim As Campos.NanoCampo
    Friend WithEvents txtInicio As Campos.NanoCampo
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboBusca As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents dsPag As System.Data.DataSet
    Friend WithEvents tbPag As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescricao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
End Class
