<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPmc3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPmc3))
        Me.dsEti = New System.Data.DataSet
        Me.tbEti = New System.Data.DataTable
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.col1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.col2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col11 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.dsEti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbEti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dsEti
        '
        Me.dsEti.DataSetName = "dsEti"
        Me.dsEti.Tables.AddRange(New System.Data.DataTable() {Me.tbEti})
        '
        'tbEti
        '
        Me.tbEti.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11})
        Me.tbEti.TableName = "tbEti"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "1"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "2"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "3"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "4"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "5"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "6"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "7"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "8"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "9"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "10"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "11"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbEti"
        Me.GridControl1.DataSource = Me.dsEti
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterar})
        Me.GridControl1.Size = New System.Drawing.Size(574, 662)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col1, Me.col2, Me.col3, Me.col4, Me.col5, Me.col6, Me.col7, Me.col8, Me.col9, Me.col10, Me.col11})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.RowHeight = 80
        '
        'col1
        '
        Me.col1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col1.AppearanceCell.Options.UseFont = True
        Me.col1.AppearanceCell.Options.UseTextOptions = True
        Me.col1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col1.AppearanceHeader.Options.UseFont = True
        Me.col1.AppearanceHeader.Options.UseTextOptions = True
        Me.col1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col1.Caption = "1"
        Me.col1.ColumnEdit = Me.txtAlterar
        Me.col1.FieldName = "1"
        Me.col1.Name = "col1"
        Me.col1.Visible = True
        Me.col1.VisibleIndex = 0
        '
        'txtAlterar
        '
        Me.txtAlterar.AutoHeight = False
        Me.txtAlterar.Name = "txtAlterar"
        '
        'col2
        '
        Me.col2.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col2.AppearanceCell.Options.UseFont = True
        Me.col2.AppearanceCell.Options.UseTextOptions = True
        Me.col2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col2.AppearanceHeader.Options.UseFont = True
        Me.col2.AppearanceHeader.Options.UseTextOptions = True
        Me.col2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col2.Caption = "2"
        Me.col2.ColumnEdit = Me.txtAlterar
        Me.col2.FieldName = "2"
        Me.col2.Name = "col2"
        Me.col2.Visible = True
        Me.col2.VisibleIndex = 1
        '
        'col3
        '
        Me.col3.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col3.AppearanceCell.Options.UseFont = True
        Me.col3.AppearanceCell.Options.UseTextOptions = True
        Me.col3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col3.AppearanceHeader.Options.UseFont = True
        Me.col3.AppearanceHeader.Options.UseTextOptions = True
        Me.col3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col3.Caption = "3"
        Me.col3.ColumnEdit = Me.txtAlterar
        Me.col3.FieldName = "3"
        Me.col3.Name = "col3"
        Me.col3.Visible = True
        Me.col3.VisibleIndex = 2
        '
        'col4
        '
        Me.col4.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col4.AppearanceCell.Options.UseFont = True
        Me.col4.AppearanceCell.Options.UseTextOptions = True
        Me.col4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col4.AppearanceHeader.Options.UseFont = True
        Me.col4.AppearanceHeader.Options.UseTextOptions = True
        Me.col4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col4.Caption = "4"
        Me.col4.ColumnEdit = Me.txtAlterar
        Me.col4.FieldName = "4"
        Me.col4.Name = "col4"
        Me.col4.Visible = True
        Me.col4.VisibleIndex = 3
        '
        'col5
        '
        Me.col5.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col5.AppearanceCell.Options.UseFont = True
        Me.col5.AppearanceCell.Options.UseTextOptions = True
        Me.col5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col5.AppearanceHeader.Options.UseFont = True
        Me.col5.AppearanceHeader.Options.UseTextOptions = True
        Me.col5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col5.Caption = "5"
        Me.col5.ColumnEdit = Me.txtAlterar
        Me.col5.FieldName = "5"
        Me.col5.Name = "col5"
        Me.col5.Visible = True
        Me.col5.VisibleIndex = 4
        '
        'col6
        '
        Me.col6.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col6.AppearanceCell.Options.UseFont = True
        Me.col6.AppearanceCell.Options.UseTextOptions = True
        Me.col6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col6.AppearanceHeader.Options.UseFont = True
        Me.col6.AppearanceHeader.Options.UseTextOptions = True
        Me.col6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col6.Caption = "6"
        Me.col6.ColumnEdit = Me.txtAlterar
        Me.col6.FieldName = "6"
        Me.col6.Name = "col6"
        Me.col6.Visible = True
        Me.col6.VisibleIndex = 5
        '
        'col7
        '
        Me.col7.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col7.AppearanceCell.Options.UseFont = True
        Me.col7.AppearanceCell.Options.UseTextOptions = True
        Me.col7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col7.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.col7.AppearanceHeader.Options.UseFont = True
        Me.col7.AppearanceHeader.Options.UseTextOptions = True
        Me.col7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col7.Caption = "7"
        Me.col7.ColumnEdit = Me.txtAlterar
        Me.col7.FieldName = "7"
        Me.col7.Name = "col7"
        Me.col7.Visible = True
        Me.col7.VisibleIndex = 6
        '
        'col8
        '
        Me.col8.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.col8.AppearanceCell.Options.UseFont = True
        Me.col8.AppearanceCell.Options.UseTextOptions = True
        Me.col8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col8.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.col8.AppearanceHeader.Options.UseFont = True
        Me.col8.AppearanceHeader.Options.UseTextOptions = True
        Me.col8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col8.Caption = "8"
        Me.col8.ColumnEdit = Me.txtAlterar
        Me.col8.FieldName = "8"
        Me.col8.Name = "col8"
        Me.col8.Visible = True
        Me.col8.VisibleIndex = 7
        '
        'col9
        '
        Me.col9.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.col9.AppearanceCell.Options.UseFont = True
        Me.col9.AppearanceCell.Options.UseTextOptions = True
        Me.col9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col9.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.col9.AppearanceHeader.Options.UseFont = True
        Me.col9.AppearanceHeader.Options.UseTextOptions = True
        Me.col9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col9.Caption = "9"
        Me.col9.ColumnEdit = Me.txtAlterar
        Me.col9.FieldName = "9"
        Me.col9.Name = "col9"
        Me.col9.Visible = True
        Me.col9.VisibleIndex = 8
        '
        'col10
        '
        Me.col10.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.col10.AppearanceCell.Options.UseFont = True
        Me.col10.AppearanceCell.Options.UseTextOptions = True
        Me.col10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col10.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.col10.AppearanceHeader.Options.UseFont = True
        Me.col10.AppearanceHeader.Options.UseTextOptions = True
        Me.col10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col10.Caption = "10"
        Me.col10.ColumnEdit = Me.txtAlterar
        Me.col10.FieldName = "10"
        Me.col10.Name = "col10"
        Me.col10.Visible = True
        Me.col10.VisibleIndex = 9
        '
        'col11
        '
        Me.col11.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.col11.AppearanceCell.Options.UseFont = True
        Me.col11.AppearanceCell.Options.UseTextOptions = True
        Me.col11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col11.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.col11.AppearanceHeader.Options.UseFont = True
        Me.col11.AppearanceHeader.Options.UseTextOptions = True
        Me.col11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col11.Caption = "11"
        Me.col11.ColumnEdit = Me.txtAlterar
        Me.col11.FieldName = "11"
        Me.col11.Name = "col11"
        Me.col11.Visible = True
        Me.col11.VisibleIndex = 10
        '
        'frmPmc3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 662)
        Me.Controls.Add(Me.GridControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPmc3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impressão de Etiqueta"
        CType(Me.dsEti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbEti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dsEti As System.Data.DataSet
    Friend WithEvents tbEti As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
End Class
