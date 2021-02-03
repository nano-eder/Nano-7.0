<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPainelPrecos
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
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.dsProd = New System.Data.DataSet
        Me.tbProd = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAdicionar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colValorUnitario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdicionar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "tbProd"
        Me.GridControl2.DataSource = Me.dsProd
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(0, 50)
        Me.GridControl2.MainView = Me.grd1
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.txtAdicionar})
        Me.GridControl2.Size = New System.Drawing.Size(1008, 610)
        Me.GridControl2.TabIndex = 25
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1, Me.GridView4})
        '
        'dsProd
        '
        Me.dsProd.DataSetName = "NewDataSet"
        Me.dsProd.Tables.AddRange(New System.Data.DataTable() {Me.tbProd})
        '
        'tbProd
        '
        Me.tbProd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5})
        Me.tbProd.TableName = "tbProd"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "CodigoInterno"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Produto"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "UM"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "RS"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "ValorUnitario"
        '
        'grd1
        '
        Me.grd1.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grd1.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grd1.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grd1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grd1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.grd1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grd1.Appearance.HeaderPanel.Options.UseFont = True
        Me.grd1.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grd1.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grd1.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grd1.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grd1.AppearancePrint.EvenRow.Options.UseBackColor = True
        Me.grd1.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseBackColor = True
        Me.grd1.AppearancePrint.OddRow.BackColor = System.Drawing.Color.LightSkyBlue
        Me.grd1.AppearancePrint.OddRow.Options.UseBackColor = True
        Me.grd1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProduto, Me.colValorUnitario, Me.colCodigoInterno, Me.colUM, Me.colRS})
        Me.grd1.GridControl = Me.GridControl2
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.EnableAppearanceEvenRow = True
        Me.grd1.OptionsView.EnableAppearanceOddRow = True
        Me.grd1.OptionsView.ShowColumnHeaders = False
        Me.grd1.OptionsView.ShowDetailButtons = False
        Me.grd1.OptionsView.ShowGroupPanel = False
        Me.grd1.OptionsView.ShowHorzLines = False
        Me.grd1.OptionsView.ShowIndicator = False
        Me.grd1.OptionsView.ShowPreviewLines = False
        Me.grd1.OptionsView.ShowVertLines = False
        Me.grd1.RowHeight = 55
        '
        'colProduto
        '
        Me.colProduto.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 28.0!)
        Me.colProduto.AppearanceCell.Options.UseFont = True
        Me.colProduto.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colProduto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.colProduto.AppearanceHeader.Options.UseBackColor = True
        Me.colProduto.AppearanceHeader.Options.UseFont = True
        Me.colProduto.Caption = "Produto"
        Me.colProduto.ColumnEdit = Me.txtAdicionar
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.AllowFocus = False
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 1
        Me.colProduto.Width = 759
        '
        'txtAdicionar
        '
        Me.txtAdicionar.AutoHeight = False
        Me.txtAdicionar.Name = "txtAdicionar"
        '
        'colValorUnitario
        '
        Me.colValorUnitario.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 28.0!)
        Me.colValorUnitario.AppearanceCell.Options.UseFont = True
        Me.colValorUnitario.AppearanceCell.Options.UseTextOptions = True
        Me.colValorUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorUnitario.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValorUnitario.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.colValorUnitario.AppearanceHeader.Options.UseBackColor = True
        Me.colValorUnitario.AppearanceHeader.Options.UseFont = True
        Me.colValorUnitario.Caption = "Valor Unitario"
        Me.colValorUnitario.FieldName = "ValorUnitario"
        Me.colValorUnitario.Name = "colValorUnitario"
        Me.colValorUnitario.OptionsColumn.AllowFocus = False
        Me.colValorUnitario.OptionsColumn.ReadOnly = True
        Me.colValorUnitario.Visible = True
        Me.colValorUnitario.VisibleIndex = 4
        Me.colValorUnitario.Width = 150
        '
        'colCodigoInterno
        '
        Me.colCodigoInterno.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 28.0!)
        Me.colCodigoInterno.AppearanceCell.Options.UseFont = True
        Me.colCodigoInterno.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoInterno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoInterno.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodigoInterno.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.colCodigoInterno.AppearanceHeader.Options.UseBackColor = True
        Me.colCodigoInterno.AppearanceHeader.Options.UseFont = True
        Me.colCodigoInterno.Caption = "CodigoInterno"
        Me.colCodigoInterno.FieldName = "CodigoInterno"
        Me.colCodigoInterno.Name = "colCodigoInterno"
        Me.colCodigoInterno.OptionsColumn.AllowFocus = False
        Me.colCodigoInterno.OptionsColumn.ReadOnly = True
        Me.colCodigoInterno.Visible = True
        Me.colCodigoInterno.VisibleIndex = 0
        Me.colCodigoInterno.Width = 146
        '
        'colUM
        '
        Me.colUM.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 28.0!)
        Me.colUM.AppearanceCell.Options.UseFont = True
        Me.colUM.AppearanceCell.Options.UseTextOptions = True
        Me.colUM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUM.Caption = "UM"
        Me.colUM.FieldName = "UM"
        Me.colUM.Name = "colUM"
        Me.colUM.OptionsColumn.AllowFocus = False
        Me.colUM.OptionsColumn.ReadOnly = True
        Me.colUM.Visible = True
        Me.colUM.VisibleIndex = 2
        Me.colUM.Width = 73
        '
        'colRS
        '
        Me.colRS.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 28.0!)
        Me.colRS.AppearanceCell.Options.UseFont = True
        Me.colRS.AppearanceCell.Options.UseTextOptions = True
        Me.colRS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colRS.Caption = "RS"
        Me.colRS.FieldName = "RS"
        Me.colRS.Name = "colRS"
        Me.colRS.OptionsColumn.AllowFocus = False
        Me.colRS.OptionsColumn.ReadOnly = True
        Me.colRS.Visible = True
        Me.colRS.VisibleIndex = 3
        Me.colRS.Width = 67
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.RepositoryItemCheckEdit1.Appearance.Options.UseFont = True
        Me.RepositoryItemCheckEdit1.AutoWidth = True
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.GridControl2
        Me.GridView4.Name = "GridView4"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.BackColor = System.Drawing.Color.SteelBlue
        Me.SimpleButton3.Appearance.BackColor2 = System.Drawing.Color.AliceBlue
        Me.SimpleButton3.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 25.0!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton3.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.SimpleButton3.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.SimpleButton3.Appearance.Options.UseBackColor = True
        Me.SimpleButton3.Appearance.Options.UseBorderColor = True
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.Appearance.Options.UseForeColor = True
        Me.SimpleButton3.Appearance.Options.UseTextOptions = True
        Me.SimpleButton3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.SimpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.SimpleButton3.Dock = System.Windows.Forms.DockStyle.Top
        Me.SimpleButton3.Location = New System.Drawing.Point(0, 0)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(1008, 50)
        Me.SimpleButton3.TabIndex = 26
        Me.SimpleButton3.Text = "  Tabela de Preços"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.AliceBlue
        Me.SimpleButton1.Appearance.BackColor2 = System.Drawing.Color.SteelBlue
        Me.SimpleButton1.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.SimpleButton1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseBorderColor = True
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.Appearance.Options.UseTextOptions = True
        Me.SimpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.SimpleButton1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SimpleButton1.Location = New System.Drawing.Point(0, 660)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(1008, 40)
        Me.SimpleButton1.TabIndex = 27
        Me.SimpleButton1.Text = "04/05/2020 12:55"
        '
        'Timer2
        '
        '
        'frmPainelPrecos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.GridControl2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.SimpleButton3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmPainelPrecos"
        Me.Text = "frmPainelPrecos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdicionar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAdicionar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colValorUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dsProd As System.Data.DataSet
    Friend WithEvents tbProd As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
