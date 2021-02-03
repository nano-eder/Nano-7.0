<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmissaoCce
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
        Dim Label6 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmissaoCce))
        Me.dtData = New DevExpress.XtraEditors.DateEdit
        Me.memCorrecao = New DevExpress.XtraEditors.MemoEdit
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtChave = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtNumSeqEvento = New DevExpress.XtraEditors.TextEdit
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.memCondUso = New DevExpress.XtraEditors.MemoEdit
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnDetalhar = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvar1 = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.btnConsulta = New DevExpress.XtraEditors.SimpleButton
        Me.lblCodPed = New DevExpress.XtraEditors.LabelControl
        Me.txtCodPed = New DevExpress.XtraEditors.TextEdit
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsCce = New System.Data.DataSet
        Me.tbCce = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHora = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCorrecao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumSeq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.txtNumNF = New DevExpress.XtraEditors.TextEdit
        Label6 = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memCorrecao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtChave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumSeqEvento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.memCondUso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodPed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtNumNF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.Color.Blue
        Label6.Location = New System.Drawing.Point(23, 149)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(61, 14)
        Label6.TabIndex = 108
        Label6.Text = "Correção"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Blue
        Label1.Location = New System.Drawing.Point(23, 35)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(108, 14)
        Label1.TabIndex = 109
        Label1.Text = "Condição de Uso"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Blue
        Label2.Location = New System.Drawing.Point(23, 344)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(61, 14)
        Label2.TabIndex = 115
        Label2.Text = "Histórico"
        '
        'dtData
        '
        Me.dtData.EditValue = Nothing
        Me.dtData.Location = New System.Drawing.Point(61, 40)
        Me.dtData.Name = "dtData"
        Me.dtData.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dtData.Properties.Appearance.Options.UseFont = True
        Me.dtData.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.dtData.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.dtData.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.dtData.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.dtData.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtData.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtData.Size = New System.Drawing.Size(100, 20)
        Me.dtData.TabIndex = 0
        '
        'memCorrecao
        '
        Me.memCorrecao.Location = New System.Drawing.Point(61, 66)
        Me.memCorrecao.Name = "memCorrecao"
        Me.memCorrecao.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.memCorrecao.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.memCorrecao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.memCorrecao.Size = New System.Drawing.Size(650, 105)
        Me.memCorrecao.TabIndex = 2
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txtChave)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtNumSeqEvento)
        Me.PanelControl1.Controls.Add(Me.dtData)
        Me.PanelControl1.Controls.Add(Me.memCorrecao)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 157)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(725, 180)
        Me.PanelControl1.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(24, 17)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl5.TabIndex = 7
        Me.LabelControl5.Text = "Chave"
        '
        'txtChave
        '
        Me.txtChave.Enabled = False
        Me.txtChave.Location = New System.Drawing.Point(61, 14)
        Me.txtChave.Name = "txtChave"
        Me.txtChave.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtChave.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtChave.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtChave.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtChave.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtChave.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtChave.Size = New System.Drawing.Size(428, 20)
        Me.txtChave.TabIndex = 6
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(11, 68)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Correção"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(32, 43)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Data"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(324, 43)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Seq. Evento"
        '
        'txtNumSeqEvento
        '
        Me.txtNumSeqEvento.Enabled = False
        Me.txtNumSeqEvento.Location = New System.Drawing.Point(389, 40)
        Me.txtNumSeqEvento.Name = "txtNumSeqEvento"
        Me.txtNumSeqEvento.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtNumSeqEvento.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNumSeqEvento.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNumSeqEvento.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNumSeqEvento.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtNumSeqEvento.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNumSeqEvento.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtNumSeqEvento.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNumSeqEvento.Size = New System.Drawing.Size(100, 20)
        Me.txtNumSeqEvento.TabIndex = 1
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Controls.Add(Me.memCondUso)
        Me.PanelControl2.Location = New System.Drawing.Point(12, 43)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(725, 100)
        Me.PanelControl2.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(11, 13)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Condição"
        '
        'memCondUso
        '
        Me.memCondUso.Enabled = False
        Me.memCondUso.Location = New System.Drawing.Point(61, 11)
        Me.memCondUso.Name = "memCondUso"
        Me.memCondUso.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.memCondUso.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.memCondUso.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.memCondUso.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.memCondUso.Properties.AppearanceDisabled.Options.UseFont = True
        Me.memCondUso.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.memCondUso.Size = New System.Drawing.Size(650, 80)
        Me.memCondUso.TabIndex = 6
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSalvar, Me.btnFechar, Me.btnSalvar1, Me.btnDetalhar})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnDetalhar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnDetalhar
        '
        Me.btnDetalhar.Caption = "&Detalhar"
        Me.btnDetalhar.Glyph = Global.Nano.My.Resources.Resources.playlist
        Me.btnDetalhar.Id = 3
        Me.btnDetalhar.Name = "btnDetalhar"
        '
        'btnSalvar1
        '
        Me.btnSalvar1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar1.Caption = "&Salvar"
        Me.btnSalvar1.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvar1.Id = 2
        Me.btnSalvar1.Name = "btnSalvar1"
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
        'btnConsulta
        '
        Me.btnConsulta.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.btnConsulta.Location = New System.Drawing.Point(174, 8)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(21, 21)
        Me.btnConsulta.TabIndex = 112
        Me.btnConsulta.ToolTipTitle = "Consulta de Pedido"
        '
        'lblCodPed
        '
        Me.lblCodPed.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodPed.Appearance.Options.UseFont = True
        Me.lblCodPed.Location = New System.Drawing.Point(13, 12)
        Me.lblCodPed.Name = "lblCodPed"
        Me.lblCodPed.Size = New System.Drawing.Size(54, 13)
        Me.lblCodPed.TabIndex = 111
        Me.lblCodPed.Text = "Nº Ordem"
        '
        'txtCodPed
        '
        Me.txtCodPed.EnterMoveNextControl = True
        Me.txtCodPed.Location = New System.Drawing.Point(73, 8)
        Me.txtCodPed.Name = "txtCodPed"
        Me.txtCodPed.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPed.Properties.Appearance.Options.UseFont = True
        Me.txtCodPed.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodPed.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCodPed.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtCodPed.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPed.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodPed.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCodPed.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtCodPed.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodPed.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCodPed.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCodPed.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCodPed.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCodPed.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodPed.Size = New System.Drawing.Size(78, 21)
        Me.txtCodPed.TabIndex = 110
        Me.txtCodPed.Tag = "Nº Pedido"
        Me.txtCodPed.Visible = False
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbCce"
        Me.GridControl1.DataSource = Me.dsCce
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 9)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(721, 157)
        Me.GridControl1.TabIndex = 113
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsCce
        '
        Me.dsCce.DataSetName = "NewDataSet"
        Me.dsCce.Tables.AddRange(New System.Data.DataTable() {Me.tbCce})
        '
        'tbCce
        '
        Me.tbCce.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4})
        Me.tbCce.TableName = "tbCce"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Data"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Hora"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Correcao"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "NumSeq"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colData, Me.colHora, Me.colCorrecao, Me.colNumSeq})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
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
        Me.colData.VisibleIndex = 0
        Me.colData.Width = 88
        '
        'colHora
        '
        Me.colHora.AppearanceCell.Options.UseTextOptions = True
        Me.colHora.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHora.Caption = "Hora"
        Me.colHora.FieldName = "Hora"
        Me.colHora.Name = "colHora"
        Me.colHora.OptionsColumn.ReadOnly = True
        Me.colHora.Visible = True
        Me.colHora.VisibleIndex = 1
        Me.colHora.Width = 83
        '
        'colCorrecao
        '
        Me.colCorrecao.Caption = "Correção"
        Me.colCorrecao.FieldName = "Correcao"
        Me.colCorrecao.Name = "colCorrecao"
        Me.colCorrecao.OptionsColumn.ReadOnly = True
        Me.colCorrecao.Visible = True
        Me.colCorrecao.VisibleIndex = 2
        Me.colCorrecao.Width = 455
        '
        'colNumSeq
        '
        Me.colNumSeq.AppearanceCell.Options.UseTextOptions = True
        Me.colNumSeq.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumSeq.Caption = "Núm. Seq."
        Me.colNumSeq.FieldName = "NumSeq"
        Me.colNumSeq.Name = "colNumSeq"
        Me.colNumSeq.OptionsColumn.ReadOnly = True
        Me.colNumSeq.Visible = True
        Me.colNumSeq.VisibleIndex = 3
        Me.colNumSeq.Width = 74
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Location = New System.Drawing.Point(12, 352)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(725, 168)
        Me.PanelControl3.TabIndex = 114
        '
        'txtNumNF
        '
        Me.txtNumNF.EnterMoveNextControl = True
        Me.txtNumNF.Location = New System.Drawing.Point(73, 8)
        Me.txtNumNF.Name = "txtNumNF"
        Me.txtNumNF.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumNF.Properties.Appearance.Options.UseFont = True
        Me.txtNumNF.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNumNF.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNumNF.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtNumNF.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumNF.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNumNF.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNumNF.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtNumNF.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNumNF.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtNumNF.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtNumNF.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNumNF.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNumNF.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumNF.Size = New System.Drawing.Size(100, 21)
        Me.txtNumNF.TabIndex = 116
        Me.txtNumNF.Tag = "Nº Pedido"
        '
        'frmEmissaoCce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 564)
        Me.Controls.Add(Me.txtNumNF)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.lblCodPed)
        Me.Controls.Add(Me.txtCodPed)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEmissaoCce"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emissão da CC-e"
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memCorrecao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtChave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumSeqEvento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.memCondUso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodPed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.txtNumNF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtData As DevExpress.XtraEditors.DateEdit
    Friend WithEvents memCorrecao As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSalvar1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumSeqEvento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents memCondUso As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnConsulta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblCodPed As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodPed As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtChave As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dsCce As System.Data.DataSet
    Friend WithEvents tbCce As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCorrecao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumSeq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnDetalhar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtNumNF As DevExpress.XtraEditors.TextEdit
End Class
