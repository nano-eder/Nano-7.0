<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBoleto
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
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBoleto))
        Me.reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnExportar = New DevExpress.XtraBars.BarButtonItem
        Me.btnImprimir = New DevExpress.XtraBars.BarButtonItem
        Me.btnBack1 = New DevExpress.XtraBars.BarButtonItem
        Me.btnBack = New DevExpress.XtraBars.BarButtonItem
        Me.btnNext = New DevExpress.XtraBars.BarButtonItem
        Me.btnNext1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem
        Me.BarCheckItem1 = New DevExpress.XtraBars.BarCheckItem
        Me.BarCheckItem2 = New DevExpress.XtraBars.BarCheckItem
        Me.BarCheckItem3 = New DevExpress.XtraBars.BarCheckItem
        Me.BarCheckItem4 = New DevExpress.XtraBars.BarCheckItem
        Me.BarCheckItem5 = New DevExpress.XtraBars.BarCheckItem
        Me.BarCheckItem6 = New DevExpress.XtraBars.BarCheckItem
        Me.BarCheckItem7 = New DevExpress.XtraBars.BarCheckItem
        Me.BarCheckItem8 = New DevExpress.XtraBars.BarCheckItem
        Me.BarCheckItem9 = New DevExpress.XtraBars.BarCheckItem
        Me.btnEmail = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.btnPdf = New DevExpress.XtraBars.BarButtonItem
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemRadioGroup1 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
        Me.sfdDanfe = New System.Windows.Forms.SaveFileDialog
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.lblZoom = New DevExpress.XtraEditors.LabelControl
        Me.lblTotalPagina = New DevExpress.XtraEditors.LabelControl
        Me.lblPaginaAtual = New DevExpress.XtraEditors.LabelControl
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayBackgroundEdge = False
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.DisplayStatusBar = False
        Me.CrystalReportViewer1.DisplayToolbar = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.EnableDrillDown = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(2, 2)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1004, 601)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnEmail, Me.btnFechar, Me.btnPdf, Me.btnImprimir, Me.btnNext, Me.btnExportar, Me.BarSubItem1, Me.BarCheckItem1, Me.BarCheckItem2, Me.BarCheckItem3, Me.btnBack, Me.btnBack1, Me.btnNext1, Me.BarCheckItem4, Me.BarCheckItem5, Me.BarCheckItem6, Me.BarCheckItem7, Me.BarCheckItem8, Me.BarCheckItem9})
        Me.BarManager1.MaxItemId = 26
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemCheckEdit1, Me.RepositoryItemRadioGroup1})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExportar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnImprimir, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btnBack1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnBack), New DevExpress.XtraBars.LinkPersistInfo(Me.btnNext), New DevExpress.XtraBars.LinkPersistInfo(Me.btnNext1), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnEmail, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnExportar
        '
        Me.btnExportar.Caption = "E&xportar"
        Me.btnExportar.Glyph = Global.Nano.My.Resources.Resources.Exportar
        Me.btnExportar.Id = 6
        Me.btnExportar.Name = "btnExportar"
        '
        'btnImprimir
        '
        Me.btnImprimir.Caption = "&Imprimir"
        Me.btnImprimir.Glyph = Global.Nano.My.Resources.Resources.Print24
        Me.btnImprimir.Id = 3
        Me.btnImprimir.Name = "btnImprimir"
        '
        'btnBack1
        '
        Me.btnBack1.Caption = "BarButtonItem1"
        Me.btnBack1.Glyph = Global.Nano.My.Resources.Resources.Prevew
        Me.btnBack1.Id = 16
        Me.btnBack1.Name = "btnBack1"
        ToolTipTitleItem1.Text = "Primeira Página"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        Me.btnBack1.SuperTip = SuperToolTip1
        '
        'btnBack
        '
        Me.btnBack.Caption = "BarButtonItem1"
        Me.btnBack.Glyph = Global.Nano.My.Resources.Resources.Back
        Me.btnBack.Id = 15
        Me.btnBack.Name = "btnBack"
        ToolTipTitleItem2.Text = "Página Anterior"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        Me.btnBack.SuperTip = SuperToolTip2
        '
        'btnNext
        '
        Me.btnNext.Caption = "Page"
        Me.btnNext.Glyph = Global.Nano.My.Resources.Resources._Next
        Me.btnNext.Id = 5
        Me.btnNext.Name = "btnNext"
        ToolTipTitleItem3.Text = "Próxima Página"
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        Me.btnNext.SuperTip = SuperToolTip3
        '
        'btnNext1
        '
        Me.btnNext1.Caption = "BarButtonItem1"
        Me.btnNext1.Glyph = Global.Nano.My.Resources.Resources.Avancar
        Me.btnNext1.Id = 17
        Me.btnNext1.Name = "btnNext1"
        ToolTipTitleItem4.Text = "Última Página"
        SuperToolTip4.Items.Add(ToolTipTitleItem4)
        Me.btnNext1.SuperTip = SuperToolTip4
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "&Zoom"
        Me.BarSubItem1.Glyph = Global.Nano.My.Resources.Resources.Zoom
        Me.BarSubItem1.Id = 7
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarCheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarCheckItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarCheckItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarCheckItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarCheckItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.BarCheckItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarCheckItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.BarCheckItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.BarCheckItem9)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarCheckItem1
        '
        Me.BarCheckItem1.Caption = "Largura da Página"
        Me.BarCheckItem1.Id = 12
        Me.BarCheckItem1.Name = "BarCheckItem1"
        '
        'BarCheckItem2
        '
        Me.BarCheckItem2.Caption = "Página Inteira"
        Me.BarCheckItem2.Id = 13
        Me.BarCheckItem2.Name = "BarCheckItem2"
        '
        'BarCheckItem3
        '
        Me.BarCheckItem3.Caption = "400 %"
        Me.BarCheckItem3.Id = 14
        Me.BarCheckItem3.Name = "BarCheckItem3"
        '
        'BarCheckItem4
        '
        Me.BarCheckItem4.Caption = "300 %"
        Me.BarCheckItem4.Id = 19
        Me.BarCheckItem4.Name = "BarCheckItem4"
        '
        'BarCheckItem5
        '
        Me.BarCheckItem5.Caption = "200 %"
        Me.BarCheckItem5.Id = 20
        Me.BarCheckItem5.Name = "BarCheckItem5"
        '
        'BarCheckItem6
        '
        Me.BarCheckItem6.Caption = "100 %"
        Me.BarCheckItem6.Id = 21
        Me.BarCheckItem6.Name = "BarCheckItem6"
        '
        'BarCheckItem7
        '
        Me.BarCheckItem7.Caption = "75 %"
        Me.BarCheckItem7.Id = 22
        Me.BarCheckItem7.Name = "BarCheckItem7"
        '
        'BarCheckItem8
        '
        Me.BarCheckItem8.Caption = "50 %"
        Me.BarCheckItem8.Id = 24
        Me.BarCheckItem8.Name = "BarCheckItem8"
        '
        'BarCheckItem9
        '
        Me.BarCheckItem9.Caption = "25 %"
        Me.BarCheckItem9.Id = 25
        Me.BarCheckItem9.Name = "BarCheckItem9"
        '
        'btnEmail
        '
        Me.btnEmail.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnEmail.Caption = "&E-mail"
        Me.btnEmail.Glyph = Global.Nano.My.Resources.Resources.NanoMail
        Me.btnEmail.Id = 0
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 1
        Me.btnFechar.Name = "btnFechar"
        '
        'btnPdf
        '
        Me.btnPdf.Caption = "PDF"
        Me.btnPdf.Id = 2
        Me.btnPdf.Name = "btnPdf"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemRadioGroup1
        '
        Me.RepositoryItemRadioGroup1.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem, New DevExpress.XtraEditors.Controls.RadioGroupItem, New DevExpress.XtraEditors.Controls.RadioGroupItem, New DevExpress.XtraEditors.Controls.RadioGroupItem, New DevExpress.XtraEditors.Controls.RadioGroupItem, New DevExpress.XtraEditors.Controls.RadioGroupItem})
        Me.RepositoryItemRadioGroup1.Name = "RepositoryItemRadioGroup1"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl1.Controls.Add(Me.lblZoom)
        Me.GroupControl1.Controls.Add(Me.lblTotalPagina)
        Me.GroupControl1.Controls.Add(Me.lblPaginaAtual)
        Me.GroupControl1.Controls.Add(Me.CrystalReportViewer1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1008, 623)
        Me.GroupControl1.TabIndex = 4
        '
        'lblZoom
        '
        Me.lblZoom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblZoom.Location = New System.Drawing.Point(840, 607)
        Me.lblZoom.Name = "lblZoom"
        Me.lblZoom.Size = New System.Drawing.Size(74, 13)
        Me.lblZoom.TabIndex = 3
        Me.lblZoom.Tag = "Nível de Zoom: "
        Me.lblZoom.Text = "Nível de Zoom: "
        '
        'lblTotalPagina
        '
        Me.lblTotalPagina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalPagina.Location = New System.Drawing.Point(443, 607)
        Me.lblTotalPagina.Name = "lblTotalPagina"
        Me.lblTotalPagina.Size = New System.Drawing.Size(101, 13)
        Me.lblTotalPagina.TabIndex = 2
        Me.lblTotalPagina.Tag = "Nº Total de Páginas: "
        Me.lblTotalPagina.Text = "Nº Total de Páginas: "
        '
        'lblPaginaAtual
        '
        Me.lblPaginaAtual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPaginaAtual.Location = New System.Drawing.Point(5, 607)
        Me.lblPaginaAtual.Name = "lblPaginaAtual"
        Me.lblPaginaAtual.Size = New System.Drawing.Size(82, 13)
        Me.lblPaginaAtual.TabIndex = 1
        Me.lblPaginaAtual.Tag = "Nº Página Atual: "
        Me.lblPaginaAtual.Text = "Nº Página Atual: "
        '
        'frmBoleto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBoleto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emissão de Boleto"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnEmail As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPdf As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sfdDanfe As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents btnNext As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExportar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemRadioGroup1 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents BarCheckItem1 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents BarCheckItem2 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents BarCheckItem3 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents btnBack1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBack As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNext1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarCheckItem4 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents BarCheckItem5 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents BarCheckItem6 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents BarCheckItem7 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents BarCheckItem8 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents BarCheckItem9 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblZoom As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotalPagina As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPaginaAtual As DevExpress.XtraEditors.LabelControl
End Class
