<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComandas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComandas))
        Me.ComandaGridControl = New DevExpress.XtraGrid.GridControl
        Me.dsCom = New System.Data.DataSet
        Me.tbCom = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodComanda = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtRetorno = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colSelecao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnOk = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        CType(Me.ComandaGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRetorno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComandaGridControl
        '
        Me.ComandaGridControl.DataMember = "tbCom"
        Me.ComandaGridControl.DataSource = Me.dsCom
        Me.ComandaGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComandaGridControl.EmbeddedNavigator.Name = ""
        Me.ComandaGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ComandaGridControl.MainView = Me.grd1
        Me.ComandaGridControl.Name = "ComandaGridControl"
        Me.ComandaGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtRetorno, Me.RepositoryItemCheckEdit1})
        Me.ComandaGridControl.Size = New System.Drawing.Size(279, 428)
        Me.ComandaGridControl.TabIndex = 1
        Me.ComandaGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsCom
        '
        Me.dsCom.DataSetName = "NewDataSet"
        Me.dsCom.Tables.AddRange(New System.Data.DataTable() {Me.tbCom})
        '
        'tbCom
        '
        Me.tbCom.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2})
        Me.tbCom.TableName = "tbCom"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "CodComanda"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Selecao"
        Me.DataColumn2.DataType = GetType(Boolean)
        '
        'grd1
        '
        Me.grd1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grd1.Appearance.Row.Options.UseFont = True
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodComanda, Me.colSelecao})
        Me.grd1.GridControl = Me.ComandaGridControl
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodComanda
        '
        Me.colCodComanda.AppearanceCell.Options.UseTextOptions = True
        Me.colCodComanda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodComanda.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCodComanda.AppearanceHeader.Options.UseFont = True
        Me.colCodComanda.Caption = "Comandas/Pedidos"
        Me.colCodComanda.ColumnEdit = Me.txtRetorno
        Me.colCodComanda.FieldName = "CodComanda"
        Me.colCodComanda.Name = "colCodComanda"
        Me.colCodComanda.Visible = True
        Me.colCodComanda.VisibleIndex = 0
        Me.colCodComanda.Width = 160
        '
        'txtRetorno
        '
        Me.txtRetorno.AutoHeight = False
        Me.txtRetorno.Name = "txtRetorno"
        '
        'colSelecao
        '
        Me.colSelecao.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.colSelecao.AppearanceHeader.Options.UseFont = True
        Me.colSelecao.Caption = "Selecionar"
        Me.colSelecao.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colSelecao.FieldName = "Selecao"
        Me.colSelecao.Name = "colSelecao"
        Me.colSelecao.Visible = True
        Me.colSelecao.VisibleIndex = 1
        Me.colSelecao.Width = 98
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 250
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
        Me.btnOk.Glyph = Global.Nano.My.Resources.Resources.apply
        Me.btnOk.Id = 0
        Me.btnOk.Name = "btnOk"
        '
        'btnFechar
        '
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 1
        Me.btnFechar.Name = "btnFechar"
        '
        'frmComandas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 470)
        Me.Controls.Add(Me.ComandaGridControl)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmComandas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comandas"
        CType(Me.ComandaGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRetorno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComandaGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodComanda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtRetorno As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colSelecao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnOk As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents dsCom As System.Data.DataSet
    Friend WithEvents tbCom As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
End Class
