<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuTEF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuTEF))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btnInstalacao = New DevExpress.XtraEditors.SimpleButton
        Me.btnConfig = New DevExpress.XtraEditors.SimpleButton
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.picFundo = New DevExpress.XtraEditors.PictureEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.btnTestarTEF = New DevExpress.XtraEditors.SimpleButton
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.btnImprimirTEF = New DevExpress.XtraEditors.SimpleButton
        Me.btnCancelarTEF = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodOrdem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNSU = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBandeira = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCPF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodConfig = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCancelado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colPagamento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFormaPagamento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.btnCancelar = New DevExpress.XtraEditors.CheckButton
        Me.btnImprimir = New DevExpress.XtraEditors.CheckButton
        Me.btnTeste = New DevExpress.XtraEditors.CheckButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.picFundo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 100.0!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Left
        Me.GroupControl1.Controls.Add(Me.btnInstalacao)
        Me.GroupControl1.Controls.Add(Me.btnConfig)
        Me.GroupControl1.Controls.Add(Me.XtraTabControl1)
        Me.GroupControl1.Controls.Add(Me.btnCancelar)
        Me.GroupControl1.Controls.Add(Me.btnImprimir)
        Me.GroupControl1.Controls.Add(Me.btnTeste)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(671, 393)
        Me.GroupControl1.TabIndex = 1
        '
        'btnInstalacao
        '
        Me.btnInstalacao.Enabled = False
        Me.btnInstalacao.Image = Global.Nano.My.Resources.Resources.Download_2
        Me.btnInstalacao.Location = New System.Drawing.Point(12, 293)
        Me.btnInstalacao.Name = "btnInstalacao"
        Me.btnInstalacao.Size = New System.Drawing.Size(140, 43)
        Me.btnInstalacao.TabIndex = 11
        Me.btnInstalacao.Text = "Instalação"
        '
        'btnConfig
        '
        Me.btnConfig.Enabled = False
        Me.btnConfig.Image = Global.Nano.My.Resources.Resources.Produto
        Me.btnConfig.Location = New System.Drawing.Point(12, 342)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(140, 43)
        Me.btnConfig.TabIndex = 10
        Me.btnConfig.Text = "Configuração"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(166, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(503, 389)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage4})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.picFundo)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(494, 368)
        '
        'picFundo
        '
        Me.picFundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picFundo.EditValue = Global.Nano.My.Resources.Resources.NANO_COMMERCE
        Me.picFundo.Location = New System.Drawing.Point(0, 0)
        Me.picFundo.Name = "picFundo"
        Me.picFundo.Size = New System.Drawing.Size(494, 368)
        Me.picFundo.TabIndex = 0
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GroupControl2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(494, 368)
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl2.Controls.Add(Me.btnTestarTEF)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(494, 368)
        Me.GroupControl2.TabIndex = 3
        '
        'btnTestarTEF
        '
        Me.btnTestarTEF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTestarTEF.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnTestarTEF.Appearance.Options.UseBackColor = True
        Me.btnTestarTEF.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnTestarTEF.Image = Global.Nano.My.Resources.Resources.randr24x24
        Me.btnTestarTEF.Location = New System.Drawing.Point(345, 336)
        Me.btnTestarTEF.Name = "btnTestarTEF"
        Me.btnTestarTEF.Size = New System.Drawing.Size(144, 28)
        Me.btnTestarTEF.TabIndex = 7
        Me.btnTestarTEF.Text = "Testar Comunicação"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.GroupControl3)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(494, 368)
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl3.Controls.Add(Me.btnImprimirTEF)
        Me.GroupControl3.Controls.Add(Me.btnCancelarTEF)
        Me.GroupControl3.Controls.Add(Me.GridControl1)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(494, 368)
        Me.GroupControl3.TabIndex = 3
        '
        'btnImprimirTEF
        '
        Me.btnImprimirTEF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimirTEF.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnImprimirTEF.Appearance.Options.UseBackColor = True
        Me.btnImprimirTEF.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnImprimirTEF.Image = Global.Nano.My.Resources.Resources.Print24
        Me.btnImprimirTEF.Location = New System.Drawing.Point(399, 337)
        Me.btnImprimirTEF.Name = "btnImprimirTEF"
        Me.btnImprimirTEF.Size = New System.Drawing.Size(90, 28)
        Me.btnImprimirTEF.TabIndex = 4
        Me.btnImprimirTEF.Text = "Imprimir"
        '
        'btnCancelarTEF
        '
        Me.btnCancelarTEF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarTEF.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelarTEF.Appearance.Options.UseBackColor = True
        Me.btnCancelarTEF.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnCancelarTEF.Image = Global.Nano.My.Resources.Resources.cancel24
        Me.btnCancelarTEF.Location = New System.Drawing.Point(5, 336)
        Me.btnCancelarTEF.Name = "btnCancelarTEF"
        Me.btnCancelarTEF.Size = New System.Drawing.Size(92, 28)
        Me.btnCancelarTEF.TabIndex = 6
        Me.btnCancelarTEF.Text = "Cancelar"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(490, 331)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodOrdem, Me.colCliente, Me.colNSU, Me.colBandeira, Me.colData, Me.colValorTotal, Me.colCPF, Me.colCodConfig, Me.colCancelado, Me.colPagamento, Me.colFormaPagamento})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ColumnAutoWidth = False
        Me.grd1.OptionsView.EnableAppearanceEvenRow = True
        Me.grd1.OptionsView.EnableAppearanceOddRow = True
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowFooter = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodOrdem
        '
        Me.colCodOrdem.AppearanceCell.Options.UseTextOptions = True
        Me.colCodOrdem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodOrdem.Caption = "Nº Venda"
        Me.colCodOrdem.FieldName = "CodOrdem"
        Me.colCodOrdem.Name = "colCodOrdem"
        Me.colCodOrdem.OptionsColumn.ReadOnly = True
        Me.colCodOrdem.Visible = True
        Me.colCodOrdem.VisibleIndex = 0
        Me.colCodOrdem.Width = 63
        '
        'colCliente
        '
        Me.colCliente.AppearanceCell.Options.UseTextOptions = True
        Me.colCliente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.ReadOnly = True
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 3
        Me.colCliente.Width = 283
        '
        'colNSU
        '
        Me.colNSU.AppearanceCell.Options.UseTextOptions = True
        Me.colNSU.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNSU.Caption = "Nº NSU"
        Me.colNSU.FieldName = "NSU"
        Me.colNSU.Name = "colNSU"
        Me.colNSU.OptionsColumn.ReadOnly = True
        Me.colNSU.Visible = True
        Me.colNSU.VisibleIndex = 2
        Me.colNSU.Width = 70
        '
        'colBandeira
        '
        Me.colBandeira.AppearanceCell.Options.UseTextOptions = True
        Me.colBandeira.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBandeira.Caption = "Bandeira"
        Me.colBandeira.FieldName = "Bandeira"
        Me.colBandeira.Name = "colBandeira"
        Me.colBandeira.OptionsColumn.ReadOnly = True
        Me.colBandeira.Width = 80
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
        Me.colData.VisibleIndex = 1
        Me.colData.Width = 85
        '
        'colValorTotal
        '
        Me.colValorTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colValorTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorTotal.Caption = "Valor R$"
        Me.colValorTotal.DisplayFormat.FormatString = "c"
        Me.colValorTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValorTotal.FieldName = "ValorTotal"
        Me.colValorTotal.Name = "colValorTotal"
        Me.colValorTotal.OptionsColumn.ReadOnly = True
        Me.colValorTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colValorTotal.Visible = True
        Me.colValorTotal.VisibleIndex = 4
        Me.colValorTotal.Width = 86
        '
        'colCPF
        '
        Me.colCPF.AppearanceCell.Options.UseTextOptions = True
        Me.colCPF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCPF.Caption = "CPF/CNPJ"
        Me.colCPF.FieldName = "CFPDest"
        Me.colCPF.Name = "colCPF"
        Me.colCPF.OptionsColumn.ReadOnly = True
        Me.colCPF.Visible = True
        Me.colCPF.VisibleIndex = 5
        Me.colCPF.Width = 139
        '
        'colCodConfig
        '
        Me.colCodConfig.AppearanceCell.Options.UseTextOptions = True
        Me.colCodConfig.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodConfig.Caption = "Cód. Loja"
        Me.colCodConfig.FieldName = "CodConfig"
        Me.colCodConfig.Name = "colCodConfig"
        Me.colCodConfig.OptionsColumn.ReadOnly = True
        '
        'colCancelado
        '
        Me.colCancelado.Caption = "Cancelado"
        Me.colCancelado.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.colCancelado.FieldName = "Cancelado"
        Me.colCancelado.Name = "colCancelado"
        Me.colCancelado.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'colPagamento
        '
        Me.colPagamento.Caption = "Pagamento"
        Me.colPagamento.FieldName = "Pagamento"
        Me.colPagamento.Name = "colPagamento"
        Me.colPagamento.OptionsColumn.ReadOnly = True
        '
        'colFormaPagamento
        '
        Me.colFormaPagamento.Caption = "FormaPagamento"
        Me.colFormaPagamento.FieldName = "FormaPagamento"
        Me.colFormaPagamento.Name = "colFormaPagamento"
        Me.colFormaPagamento.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.Nano.My.Resources.Resources.cancel24
        Me.btnCancelar.Location = New System.Drawing.Point(12, 113)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(140, 43)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar TEF"
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.Nano.My.Resources.Resources.Impressora
        Me.btnImprimir.Location = New System.Drawing.Point(12, 64)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(140, 43)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "Re-Imprimir"
        '
        'btnTeste
        '
        Me.btnTeste.Image = Global.Nano.My.Resources.Resources.randr24x24
        Me.btnTeste.Location = New System.Drawing.Point(12, 15)
        Me.btnTeste.Name = "btnTeste"
        Me.btnTeste.Size = New System.Drawing.Size(140, 43)
        Me.btnTeste.TabIndex = 3
        Me.btnTeste.Text = "Teste Comunicação"
        '
        'frmMenuTEF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 393)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenuTEF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu TEF"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.picFundo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnInstalacao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConfig As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents picFundo As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnImprimirTEF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelarTEF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodOrdem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNSU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBandeira As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCPF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodConfig As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colCancelado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.CheckButton
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.CheckButton
    Friend WithEvents btnTeste As DevExpress.XtraEditors.CheckButton
    Friend WithEvents btnTestarTEF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colPagamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFormaPagamento As DevExpress.XtraGrid.Columns.GridColumn
End Class
