<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relAnimal
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.grid1 = New DevExpress.XtraGrid.GridControl
        Me.dsAnimal = New System.Data.DataSet
        Me.tbAnimal = New System.Data.DataTable
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodEletronico = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEspecie = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSexo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVivo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colRaca = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPelagem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNascimento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFicha = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodCli = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDono = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPeso = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTelefone = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.WinControlContainer1})
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.Location = New System.Drawing.Point(0, 0)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.Size = New System.Drawing.Size(1108, 83)
        Me.WinControlContainer1.WinControl = Me.grid1
        '
        'grid1
        '
        Me.grid1.DataMember = "tbAnimal"
        Me.grid1.DataSource = Me.dsAnimal
        Me.grid1.EmbeddedNavigator.Name = ""
        Me.grid1.Location = New System.Drawing.Point(2, 20)
        Me.grid1.MainView = Me.GridView1
        Me.grid1.Name = "grid1"
        Me.grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterar, Me.RepositoryItemCheckEdit1, Me.RepositoryItemDateEdit1})
        Me.grid1.Size = New System.Drawing.Size(1064, 80)
        Me.grid1.TabIndex = 0
        Me.grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'dsAnimal
        '
        Me.dsAnimal.DataSetName = "NewDataSet"
        Me.dsAnimal.Tables.AddRange(New System.Data.DataTable() {Me.tbAnimal})
        '
        'tbAnimal
        '
        Me.tbAnimal.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11})
        Me.tbAnimal.TableName = "tbAnimal"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Nome"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Proprietario"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Especie"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Raca"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Pelagem"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Sexo"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Nascimento"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Data"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Peso"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Id"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Vivo"
        Me.DataColumn11.DataType = GetType(Boolean)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colNome, Me.colCodEletronico, Me.colEspecie, Me.colSexo, Me.colVivo, Me.colRaca, Me.colPelagem, Me.colNascimento, Me.colData, Me.colFicha, Me.colCodCli, Me.colDono, Me.colPeso, Me.colTelefone})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(1140, 433, 216, 199)
        Me.GridView1.GridControl = Me.grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodigo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigo.AppearanceHeader.Options.UseBackColor = True
        Me.colCodigo.AppearanceHeader.Options.UseFont = True
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.ColumnEdit = Me.txtAlterar
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        '
        'txtAlterar
        '
        Me.txtAlterar.AccessibleName = ""
        Me.txtAlterar.AutoHeight = False
        Me.txtAlterar.Name = "txtAlterar"
        '
        'colNome
        '
        Me.colNome.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNome.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNome.AppearanceHeader.Options.UseBackColor = True
        Me.colNome.AppearanceHeader.Options.UseFont = True
        Me.colNome.Caption = "Nome"
        Me.colNome.ColumnEdit = Me.txtAlterar
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.OptionsColumn.ReadOnly = True
        Me.colNome.Visible = True
        Me.colNome.VisibleIndex = 0
        Me.colNome.Width = 121
        '
        'colCodEletronico
        '
        Me.colCodEletronico.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodEletronico.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodEletronico.AppearanceHeader.Options.UseBackColor = True
        Me.colCodEletronico.AppearanceHeader.Options.UseFont = True
        Me.colCodEletronico.Caption = "ID Eletrônico"
        Me.colCodEletronico.ColumnEdit = Me.txtAlterar
        Me.colCodEletronico.FieldName = "Id"
        Me.colCodEletronico.Name = "colCodEletronico"
        Me.colCodEletronico.OptionsColumn.ReadOnly = True
        Me.colCodEletronico.Visible = True
        Me.colCodEletronico.VisibleIndex = 7
        Me.colCodEletronico.Width = 90
        '
        'colEspecie
        '
        Me.colEspecie.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colEspecie.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEspecie.AppearanceHeader.Options.UseBackColor = True
        Me.colEspecie.AppearanceHeader.Options.UseFont = True
        Me.colEspecie.Caption = "Espécie"
        Me.colEspecie.ColumnEdit = Me.txtAlterar
        Me.colEspecie.FieldName = "Especie"
        Me.colEspecie.Name = "colEspecie"
        Me.colEspecie.OptionsColumn.ReadOnly = True
        Me.colEspecie.Visible = True
        Me.colEspecie.VisibleIndex = 2
        Me.colEspecie.Width = 99
        '
        'colSexo
        '
        Me.colSexo.AppearanceCell.Options.UseTextOptions = True
        Me.colSexo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSexo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colSexo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSexo.AppearanceHeader.Options.UseBackColor = True
        Me.colSexo.AppearanceHeader.Options.UseFont = True
        Me.colSexo.Caption = "Sexo"
        Me.colSexo.ColumnEdit = Me.txtAlterar
        Me.colSexo.FieldName = "Sexo"
        Me.colSexo.Name = "colSexo"
        Me.colSexo.OptionsColumn.ReadOnly = True
        Me.colSexo.Visible = True
        Me.colSexo.VisibleIndex = 5
        Me.colSexo.Width = 36
        '
        'colVivo
        '
        Me.colVivo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colVivo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVivo.AppearanceHeader.Options.UseBackColor = True
        Me.colVivo.AppearanceHeader.Options.UseFont = True
        Me.colVivo.Caption = "Vivo"
        Me.colVivo.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colVivo.FieldName = "Vivo"
        Me.colVivo.Name = "colVivo"
        Me.colVivo.OptionsColumn.ReadOnly = True
        Me.colVivo.Visible = True
        Me.colVivo.VisibleIndex = 8
        Me.colVivo.Width = 48
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colRaca
        '
        Me.colRaca.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colRaca.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colRaca.AppearanceHeader.Options.UseBackColor = True
        Me.colRaca.AppearanceHeader.Options.UseFont = True
        Me.colRaca.Caption = "Raça"
        Me.colRaca.ColumnEdit = Me.txtAlterar
        Me.colRaca.FieldName = "Raca"
        Me.colRaca.Name = "colRaca"
        Me.colRaca.OptionsColumn.ReadOnly = True
        Me.colRaca.Visible = True
        Me.colRaca.VisibleIndex = 3
        Me.colRaca.Width = 90
        '
        'colPelagem
        '
        Me.colPelagem.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colPelagem.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPelagem.AppearanceHeader.Options.UseBackColor = True
        Me.colPelagem.AppearanceHeader.Options.UseFont = True
        Me.colPelagem.Caption = "Pelagem"
        Me.colPelagem.ColumnEdit = Me.txtAlterar
        Me.colPelagem.FieldName = "Pelagem"
        Me.colPelagem.Name = "colPelagem"
        Me.colPelagem.OptionsColumn.ReadOnly = True
        Me.colPelagem.Visible = True
        Me.colPelagem.VisibleIndex = 4
        Me.colPelagem.Width = 100
        '
        'colNascimento
        '
        Me.colNascimento.AppearanceCell.Options.UseTextOptions = True
        Me.colNascimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNascimento.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNascimento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNascimento.AppearanceHeader.Options.UseBackColor = True
        Me.colNascimento.AppearanceHeader.Options.UseFont = True
        Me.colNascimento.Caption = "Nascimento"
        Me.colNascimento.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colNascimento.FieldName = "Nascimento"
        Me.colNascimento.Name = "colNascimento"
        Me.colNascimento.OptionsColumn.ReadOnly = True
        Me.colNascimento.Visible = True
        Me.colNascimento.VisibleIndex = 6
        Me.colNascimento.Width = 70
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemDateEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'colData
        '
        Me.colData.AppearanceCell.Options.UseTextOptions = True
        Me.colData.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colData.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colData.AppearanceHeader.Options.UseBackColor = True
        Me.colData.AppearanceHeader.Options.UseFont = True
        Me.colData.Caption = "Data"
        Me.colData.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.OptionsColumn.ReadOnly = True
        Me.colData.Visible = True
        Me.colData.VisibleIndex = 9
        Me.colData.Width = 70
        '
        'colFicha
        '
        Me.colFicha.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colFicha.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFicha.AppearanceHeader.Options.UseBackColor = True
        Me.colFicha.AppearanceHeader.Options.UseFont = True
        Me.colFicha.Caption = "Ficha"
        Me.colFicha.ColumnEdit = Me.txtAlterar
        Me.colFicha.FieldName = "Ficha"
        Me.colFicha.Name = "colFicha"
        Me.colFicha.OptionsColumn.ReadOnly = True
        Me.colFicha.Width = 231
        '
        'colCodCli
        '
        Me.colCodCli.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodCli.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodCli.AppearanceHeader.Options.UseBackColor = True
        Me.colCodCli.AppearanceHeader.Options.UseFont = True
        Me.colCodCli.Caption = "Código Cliente"
        Me.colCodCli.ColumnEdit = Me.txtAlterar
        Me.colCodCli.FieldName = "CodCli"
        Me.colCodCli.Name = "colCodCli"
        Me.colCodCli.OptionsColumn.ReadOnly = True
        Me.colCodCli.Width = 86
        '
        'colDono
        '
        Me.colDono.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colDono.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDono.AppearanceHeader.Options.UseBackColor = True
        Me.colDono.AppearanceHeader.Options.UseFont = True
        Me.colDono.Caption = "Proprietário"
        Me.colDono.ColumnEdit = Me.txtAlterar
        Me.colDono.FieldName = "Proprietario"
        Me.colDono.Name = "colDono"
        Me.colDono.OptionsColumn.ReadOnly = True
        Me.colDono.Visible = True
        Me.colDono.VisibleIndex = 1
        Me.colDono.Width = 159
        '
        'colPeso
        '
        Me.colPeso.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colPeso.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPeso.AppearanceHeader.Options.UseBackColor = True
        Me.colPeso.AppearanceHeader.Options.UseFont = True
        Me.colPeso.Caption = "Peso"
        Me.colPeso.FieldName = "Peso"
        Me.colPeso.Name = "colPeso"
        Me.colPeso.OptionsColumn.ReadOnly = True
        Me.colPeso.Visible = True
        Me.colPeso.VisibleIndex = 10
        Me.colPeso.Width = 60
        '
        'colTelefone
        '
        Me.colTelefone.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colTelefone.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTelefone.AppearanceHeader.Options.UseBackColor = True
        Me.colTelefone.AppearanceHeader.Options.UseFont = True
        Me.colTelefone.Caption = "Telefone"
        Me.colTelefone.FieldName = "Telefone"
        Me.colTelefone.Name = "colTelefone"
        Me.colTelefone.OptionsColumn.ReadOnly = True
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.picLogo, Me.lblTitulo, Me.XrLine3, Me.XrLine2})
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'picLogo
        '
        Me.picLogo.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.picLogo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.picLogo.ImageUrl = "C:\NANO\Logo.png"
        Me.picLogo.Location = New System.Drawing.Point(8, 17)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(150, 65)
        Me.picLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.picLogo.StylePriority.UseBorderColor = False
        Me.picLogo.StylePriority.UseBorders = False
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(167, 42)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitulo.Size = New System.Drawing.Size(925, 25)
        Me.lblTitulo.StylePriority.UseFont = False
        Me.lblTitulo.StylePriority.UseTextAlignment = False
        Me.lblTitulo.Text = "Relatório de Animais"
        Me.lblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine3
        '
        Me.XrLine3.LineWidth = 2
        Me.XrLine3.Location = New System.Drawing.Point(0, 0)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.Size = New System.Drawing.Size(1100, 8)
        '
        'XrLine2
        '
        Me.XrLine2.LineWidth = 2
        Me.XrLine2.Location = New System.Drawing.Point(0, 92)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(1100, 8)
        '
        'PageFooter
        '
        Me.PageFooter.Height = 30
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'relAnimal
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(30, 30, 30, 30)
        Me.PageHeight = 827
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ShowPreviewMarginLines = False
        Me.Version = "8.2"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents WinControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodEletronico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEspecie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSexo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colRaca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPelagem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNascimento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFicha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodCli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents picLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents dsAnimal As System.Data.DataSet
    Friend WithEvents tbAnimal As System.Data.DataTable
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
End Class
