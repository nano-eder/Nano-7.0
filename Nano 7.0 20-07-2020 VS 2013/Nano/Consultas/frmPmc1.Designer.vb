<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPmc1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPmc1))
        Me.dsEti = New System.Data.DataSet
        Me.tbEti = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.col1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.col2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col6 = New DevExpress.XtraGrid.Columns.GridColumn
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
        Me.tbEti.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6})
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
        Me.GridControl1.Size = New System.Drawing.Size(798, 662)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col1, Me.col2, Me.col3, Me.col4, Me.col5, Me.col6})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.RowHeight = 60
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
        'frmPmc1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 662)
        Me.Controls.Add(Me.GridControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPmc1"
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
End Class
