<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTabelaPreco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTabelaPreco))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnOk = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.grpCad = New DevExpress.XtraEditors.GroupControl
        Me.GridControl = New DevExpress.XtraGrid.GridControl
        Me.dsPreco = New System.Data.DataSet
        Me.tbPreco = New System.Data.DataTable
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodTabela = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtValor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colPorcent = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtPor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colCodPreco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtValor2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.btnTabPreco = New DevExpress.XtraEditors.SimpleButton
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpCad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCad.SuspendLayout()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsPreco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbPreco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnOk, Me.btnFechar})
        Me.BarManager1.MaxItemId = 6
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
        Me.btnOk.Id = 1
        Me.btnOk.Name = "btnOk"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = CType(resources.GetObject("btnFechar.Glyph"), System.Drawing.Image)
        Me.btnFechar.Id = 2
        Me.btnFechar.Name = "btnFechar"
        '
        'grpCad
        '
        Me.grpCad.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCad.AppearanceCaption.Options.UseFont = True
        Me.grpCad.Controls.Add(Me.GridControl)
        Me.grpCad.Controls.Add(Me.btnTabPreco)
        Me.grpCad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpCad.Location = New System.Drawing.Point(0, 0)
        Me.grpCad.Name = "grpCad"
        Me.grpCad.Size = New System.Drawing.Size(523, 318)
        Me.grpCad.TabIndex = 5
        Me.grpCad.Text = "Valores Cadastrados"
        '
        'GridControl
        '
        Me.GridControl.DataMember = "tbPreco"
        Me.GridControl.DataSource = Me.dsPreco
        Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl.EmbeddedNavigator.Name = ""
        Me.GridControl.Location = New System.Drawing.Point(2, 21)
        Me.GridControl.MainView = Me.grd1
        Me.GridControl.Name = "GridControl"
        Me.GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtValor2, Me.txtPor, Me.txtValor})
        Me.GridControl.Size = New System.Drawing.Size(519, 295)
        Me.GridControl.TabIndex = 0
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsPreco
        '
        Me.dsPreco.DataSetName = "NewDataSet"
        Me.dsPreco.Tables.AddRange(New System.Data.DataTable() {Me.tbPreco})
        '
        'tbPreco
        '
        Me.tbPreco.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn1})
        Me.tbPreco.TableName = "tbPreco"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "CodTabela"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Valor"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Porcent"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Nome"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "CodPreco"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodTabela, Me.colNome, Me.colValor, Me.colPorcent, Me.colCodPreco})
        Me.grd1.CustomizationFormBounds = New System.Drawing.Rectangle(523, 278, 216, 204)
        Me.grd1.GridControl = Me.GridControl
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodTabela
        '
        Me.colCodTabela.Caption = "CodTabela"
        Me.colCodTabela.FieldName = "CodTabela"
        Me.colCodTabela.Name = "colCodTabela"
        '
        'colNome
        '
        Me.colNome.Caption = "Nome Tabela"
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.OptionsColumn.ReadOnly = True
        Me.colNome.Visible = True
        Me.colNome.VisibleIndex = 0
        Me.colNome.Width = 289
        '
        'colValor
        '
        Me.colValor.AppearanceCell.Options.UseTextOptions = True
        Me.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor.Caption = "Valor"
        Me.colValor.ColumnEdit = Me.txtValor
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 1
        Me.colValor.Width = 106
        '
        'txtValor
        '
        Me.txtValor.AutoHeight = False
        Me.txtValor.Name = "txtValor"
        '
        'colPorcent
        '
        Me.colPorcent.AppearanceCell.Options.UseTextOptions = True
        Me.colPorcent.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPorcent.Caption = "Porcentagem %"
        Me.colPorcent.ColumnEdit = Me.txtPor
        Me.colPorcent.FieldName = "Porcent"
        Me.colPorcent.Name = "colPorcent"
        Me.colPorcent.Visible = True
        Me.colPorcent.VisibleIndex = 2
        Me.colPorcent.Width = 103
        '
        'txtPor
        '
        Me.txtPor.AutoHeight = False
        Me.txtPor.Name = "txtPor"
        Me.txtPor.Tag = ""
        '
        'colCodPreco
        '
        Me.colCodPreco.Caption = "CodPreco"
        Me.colCodPreco.FieldName = "CodPreco"
        Me.colCodPreco.Name = "colCodPreco"
        '
        'txtValor2
        '
        Me.txtValor2.AutoHeight = False
        Me.txtValor2.Name = "txtValor2"
        '
        'btnTabPreco
        '
        Me.btnTabPreco.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnTabPreco.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnTabPreco.Location = New System.Drawing.Point(501, 0)
        Me.btnTabPreco.Name = "btnTabPreco"
        Me.btnTabPreco.Size = New System.Drawing.Size(20, 20)
        Me.btnTabPreco.TabIndex = 1
        Me.btnTabPreco.Text = "SimpleButton1"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'frmTabelaPreco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 352)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpCad)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTabelaPreco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Valores"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpCad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCad.ResumeLayout(False)
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsPreco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbPreco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnOk As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grpCad As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodTabela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPorcent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dsPreco As System.Data.DataSet
    Friend WithEvents tbPreco As System.Data.DataTable
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents txtValor2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnTabPreco As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtValor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents colCodPreco As DevExpress.XtraGrid.Columns.GridColumn
End Class
