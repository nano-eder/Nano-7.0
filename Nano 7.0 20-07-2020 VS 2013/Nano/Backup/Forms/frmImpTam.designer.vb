<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpTam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImpTam))
        Me.cboMod = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.dsEtiq = New System.Data.DataSet
        Me.tbEti = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colTamanho = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colImprimir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkImp = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.CodigoInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricante = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnOK = New DevExpress.XtraBars.BarButtonItem
        Me.btnCancelar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.chkTudo = New System.Windows.Forms.CheckBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.cboMod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsEtiq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbEti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkImp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboMod
        '
        Me.cboMod.Location = New System.Drawing.Point(12, 12)
        Me.cboMod.Name = "cboMod"
        Me.cboMod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMod.Properties.Items.AddRange(New Object() {"DUPLA GRANDE", "TRIPLA PEQUENA"})
        Me.cboMod.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboMod.Size = New System.Drawing.Size(182, 20)
        Me.cboMod.TabIndex = 0
        Me.cboMod.Tag = "Tamanho"
        Me.cboMod.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Modelo"
        Me.LabelControl1.Visible = False
        '
        'dsEtiq
        '
        Me.dsEtiq.DataSetName = "NewDataSet"
        Me.dsEtiq.Tables.AddRange(New System.Data.DataTable() {Me.tbEti})
        '
        'tbEti
        '
        Me.tbEti.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7})
        Me.tbEti.TableName = "tbEti"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Tamanho"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Qtd"
        Me.DataColumn2.DataType = GetType(Double)
        '
        'DataColumn3
        '
        Me.DataColumn3.Caption = "Imprimir?"
        Me.DataColumn3.ColumnName = "Imprimir"
        Me.DataColumn3.DataType = GetType(Boolean)
        Me.DataColumn3.DefaultValue = False
        '
        'DataColumn4
        '
        Me.DataColumn4.Caption = "Cód. Prod."
        Me.DataColumn4.ColumnName = "CodigoInterno"
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "Produto"
        Me.DataColumn5.ColumnName = "Nome"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Fabricante"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Valor"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbEti"
        Me.GridControl1.DataSource = Me.dsEtiq
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 38)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkImp})
        Me.GridControl1.Size = New System.Drawing.Size(856, 368)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTamanho, Me.colQtd, Me.colImprimir, Me.CodigoInterno, Me.colNome, Me.colFabricante, Me.colValor})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsBehavior.FocusLeaveOnTab = True
        Me.grd1.OptionsNavigation.AutoFocusNewRow = True
        Me.grd1.OptionsNavigation.EnterMoveNextColumn = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colTamanho
        '
        Me.colTamanho.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colTamanho.AppearanceCell.Options.UseFont = True
        Me.colTamanho.AppearanceCell.Options.UseTextOptions = True
        Me.colTamanho.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTamanho.Caption = "Tamanho"
        Me.colTamanho.FieldName = "Tamanho"
        Me.colTamanho.Name = "colTamanho"
        Me.colTamanho.OptionsColumn.ReadOnly = True
        Me.colTamanho.Visible = True
        Me.colTamanho.VisibleIndex = 2
        Me.colTamanho.Width = 79
        '
        'colQtd
        '
        Me.colQtd.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colQtd.AppearanceCell.Options.UseFont = True
        Me.colQtd.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtd.Caption = "Qtd"
        Me.colQtd.FieldName = "Qtd"
        Me.colQtd.Name = "colQtd"
        Me.colQtd.Visible = True
        Me.colQtd.VisibleIndex = 3
        Me.colQtd.Width = 87
        '
        'colImprimir
        '
        Me.colImprimir.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colImprimir.AppearanceCell.Options.UseFont = True
        Me.colImprimir.Caption = "Imprimir?"
        Me.colImprimir.ColumnEdit = Me.chkImp
        Me.colImprimir.FieldName = "Imprimir"
        Me.colImprimir.Name = "colImprimir"
        Me.colImprimir.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.colImprimir.Visible = True
        Me.colImprimir.VisibleIndex = 4
        Me.colImprimir.Width = 81
        '
        'chkImp
        '
        Me.chkImp.AutoHeight = False
        Me.chkImp.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Value
        Me.chkImp.Name = "chkImp"
        Me.chkImp.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.chkImp.ValueGrayed = True
        '
        'CodigoInterno
        '
        Me.CodigoInterno.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoInterno.AppearanceCell.Options.UseFont = True
        Me.CodigoInterno.AppearanceCell.Options.UseTextOptions = True
        Me.CodigoInterno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CodigoInterno.Caption = "Cód. Prod."
        Me.CodigoInterno.FieldName = "CodigoInterno"
        Me.CodigoInterno.Name = "CodigoInterno"
        Me.CodigoInterno.OptionsColumn.ReadOnly = True
        Me.CodigoInterno.Visible = True
        Me.CodigoInterno.VisibleIndex = 0
        Me.CodigoInterno.Width = 138
        '
        'colNome
        '
        Me.colNome.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNome.AppearanceCell.Options.UseFont = True
        Me.colNome.Caption = "Produto"
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.OptionsColumn.ReadOnly = True
        Me.colNome.Visible = True
        Me.colNome.VisibleIndex = 1
        Me.colNome.Width = 450
        '
        'colFabricante
        '
        Me.colFabricante.Caption = "Fabricante"
        Me.colFabricante.FieldName = "Fabricante"
        Me.colFabricante.Name = "colFabricante"
        Me.colFabricante.OptionsColumn.ReadOnly = True
        '
        'colValor
        '
        Me.colValor.Caption = "Valor"
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.OptionsColumn.ReadOnly = True
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnCancelar, Me.btnOK})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnOK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCancelar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnOK
        '
        Me.btnOK.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnOK.Caption = " &OK      "
        Me.btnOK.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnOK.Id = 1
        Me.btnOK.Name = "btnOK"
        '
        'btnCancelar
        '
        Me.btnCancelar.Caption = "&Cancelar"
        Me.btnCancelar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnCancelar.Id = 0
        Me.btnCancelar.Name = "btnCancelar"
        '
        'chkTudo
        '
        Me.chkTudo.AutoSize = True
        Me.chkTudo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTudo.Location = New System.Drawing.Point(737, 12)
        Me.chkTudo.Name = "chkTudo"
        Me.chkTudo.Size = New System.Drawing.Size(107, 17)
        Me.chkTudo.TabIndex = 7
        Me.chkTudo.Text = "Imprimir Tudo"
        Me.chkTudo.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 250
        '
        'frmImpTam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 440)
        Me.Controls.Add(Me.chkTudo)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cboMod)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmImpTam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impressão de Etiquetas"
        CType(Me.cboMod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsEtiq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbEti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkImp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboMod As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTamanho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImprimir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnOK As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents chkTudo As System.Windows.Forms.CheckBox
    Friend WithEvents chkImp As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Public WithEvents dsEtiq As System.Data.DataSet
    Public WithEvents tbEti As System.Data.DataTable
    Public WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents CodigoInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents colFabricante As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
End Class
