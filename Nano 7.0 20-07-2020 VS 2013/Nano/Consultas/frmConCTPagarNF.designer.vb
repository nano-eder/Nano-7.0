<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConCTPagarNF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConCTPagarNF))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsNF = New System.Data.DataSet
        Me.tbNF = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFornecedor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkOk = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnOK = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtValNota = New DevExpress.XtraEditors.TextEdit
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsNF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbNF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtValNota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbNF"
        Me.GridControl1.DataSource = Me.dsNF
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkOk})
        Me.GridControl1.Size = New System.Drawing.Size(548, 256)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1, Me.GridView2})
        '
        'dsNF
        '
        Me.dsNF.DataSetName = "NewDataSet"
        Me.dsNF.Tables.AddRange(New System.Data.DataTable() {Me.tbNF})
        '
        'tbNF
        '
        Me.tbNF.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4})
        Me.tbNF.TableName = "tbNF"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "NF"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Fornecedor"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Valor"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Ok"
        Me.DataColumn4.DataType = GetType(Boolean)
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNF, Me.colFornecedor, Me.colValor, Me.colOk})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colNF
        '
        Me.colNF.AppearanceCell.Options.UseTextOptions = True
        Me.colNF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNF.Caption = "Número NF"
        Me.colNF.FieldName = "NF"
        Me.colNF.Name = "colNF"
        Me.colNF.OptionsColumn.ReadOnly = True
        Me.colNF.Visible = True
        Me.colNF.VisibleIndex = 0
        Me.colNF.Width = 79
        '
        'colFornecedor
        '
        Me.colFornecedor.Caption = "Fornecedor"
        Me.colFornecedor.FieldName = "Fornecedor"
        Me.colFornecedor.Name = "colFornecedor"
        Me.colFornecedor.OptionsColumn.ReadOnly = True
        Me.colFornecedor.Visible = True
        Me.colFornecedor.VisibleIndex = 1
        Me.colFornecedor.Width = 278
        '
        'colValor
        '
        Me.colValor.AppearanceCell.Options.UseTextOptions = True
        Me.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor.Caption = "Valor R$"
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.OptionsColumn.ReadOnly = True
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 2
        Me.colValor.Width = 104
        '
        'colOk
        '
        Me.colOk.Caption = "Ok"
        Me.colOk.ColumnEdit = Me.chkOk
        Me.colOk.FieldName = "Ok"
        Me.colOk.Name = "colOk"
        Me.colOk.Visible = True
        Me.colOk.VisibleIndex = 3
        Me.colOk.Width = 70
        '
        'chkOk
        '
        Me.chkOk.AutoHeight = False
        Me.chkOk.Name = "chkOk"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnOK, Me.btnFechar})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnOK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnOK
        '
        Me.btnOK.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnOK.Caption = "&Ok"
        Me.btnOK.Glyph = Global.Nano.My.Resources.Resources.apply
        Me.btnOK.Id = 0
        Me.btnOK.Name = "btnOK"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 1
        Me.btnFechar.Name = "btnFechar"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtValNota)
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(552, 293)
        Me.GroupControl1.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(273, 267)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(107, 18)
        Me.LabelControl3.TabIndex = 57
        Me.LabelControl3.Text = "Valor Total R$"
        '
        'txtValNota
        '
        Me.txtValNota.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValNota.EnterMoveNextControl = True
        Me.txtValNota.Location = New System.Drawing.Point(386, 262)
        Me.txtValNota.Name = "txtValNota"
        Me.txtValNota.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtValNota.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValNota.Properties.Appearance.Options.UseBackColor = True
        Me.txtValNota.Properties.Appearance.Options.UseFont = True
        Me.txtValNota.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValNota.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValNota.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtValNota.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtValNota.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValNota.Properties.MaxLength = 19
        Me.txtValNota.Properties.ReadOnly = True
        Me.txtValNota.Size = New System.Drawing.Size(161, 27)
        Me.txtValNota.TabIndex = 56
        Me.txtValNota.Tag = "Preço R$"
        '
        'frmConCTPagarNF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 335)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConCTPagarNF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Notas Fiscais a Pagar"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsNF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbNF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtValNota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnOK As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents dsNF As System.Data.DataSet
    Friend WithEvents tbNF As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents colNF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFornecedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkOk As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValNota As DevExpress.XtraEditors.TextEdit
End Class
