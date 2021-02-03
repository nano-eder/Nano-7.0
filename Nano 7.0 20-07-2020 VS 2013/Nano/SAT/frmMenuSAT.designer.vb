<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuSAT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuSAT))
        Me.rtfSAT = New System.Windows.Forms.RichTextBox
        Me.btnLX = New DevExpress.XtraEditors.SimpleButton
        Me.btnReducaoZ = New DevExpress.XtraEditors.SimpleButton
        Me.btnCancelaCupom = New DevExpress.XtraEditors.SimpleButton
        Me.btnUltimasInf = New DevExpress.XtraEditors.SimpleButton
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnImprimir = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.btnRetornaSefaz = New DevExpress.XtraEditors.SimpleButton
        Me.lblFor = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.btnDados = New DevExpress.XtraEditors.SimpleButton
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.btnConfig = New DevExpress.XtraEditors.SimpleButton
        Me.ofdXml = New System.Windows.Forms.OpenFileDialog
        Me.btnAtivacao = New DevExpress.XtraEditors.SimpleButton
        Me.chkSatTeste = New DevExpress.XtraEditors.CheckEdit
        Me.btnAlterarNumeroSessao = New DevExpress.XtraEditors.SimpleButton
        Me.btnInstalar = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl
        Me.btnGerarArquivo = New DevExpress.XtraEditors.SimpleButton
        Me.btnAtualizarSW = New DevExpress.XtraEditors.SimpleButton
        Me.pnlMarquee = New DevExpress.XtraEditors.PanelControl
        Me.bpMarquee = New DevExpress.XtraEditors.MarqueeProgressBarControl
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSatTeste.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlMarquee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMarquee.SuspendLayout()
        CType(Me.bpMarquee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtfSAT
        '
        Me.rtfSAT.Location = New System.Drawing.Point(182, 23)
        Me.rtfSAT.Name = "rtfSAT"
        Me.rtfSAT.ReadOnly = True
        Me.rtfSAT.Size = New System.Drawing.Size(394, 438)
        Me.rtfSAT.TabIndex = 0
        Me.rtfSAT.Text = ""
        '
        'btnLX
        '
        Me.btnLX.Location = New System.Drawing.Point(21, 23)
        Me.btnLX.Name = "btnLX"
        Me.btnLX.Size = New System.Drawing.Size(138, 26)
        Me.btnLX.TabIndex = 1
        Me.btnLX.Text = "LX"
        '
        'btnReducaoZ
        '
        Me.btnReducaoZ.Location = New System.Drawing.Point(21, 55)
        Me.btnReducaoZ.Name = "btnReducaoZ"
        Me.btnReducaoZ.Size = New System.Drawing.Size(138, 26)
        Me.btnReducaoZ.TabIndex = 2
        Me.btnReducaoZ.Text = "Redução Z"
        '
        'btnCancelaCupom
        '
        Me.btnCancelaCupom.Location = New System.Drawing.Point(21, 87)
        Me.btnCancelaCupom.Name = "btnCancelaCupom"
        Me.btnCancelaCupom.Size = New System.Drawing.Size(138, 26)
        Me.btnCancelaCupom.TabIndex = 3
        Me.btnCancelaCupom.Text = "Cancelar Cupom"
        '
        'btnUltimasInf
        '
        Me.btnUltimasInf.Location = New System.Drawing.Point(21, 138)
        Me.btnUltimasInf.Name = "btnUltimasInf"
        Me.btnUltimasInf.Size = New System.Drawing.Size(138, 26)
        Me.btnUltimasInf.TabIndex = 4
        Me.btnUltimasInf.Text = "Ultimas Info."
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnFechar, Me.btnImprimir})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnImprimir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnImprimir
        '
        Me.btnImprimir.Caption = "&Imprimir"
        Me.btnImprimir.Glyph = Global.Nano.My.Resources.Resources.Impressora
        Me.btnImprimir.Id = 1
        Me.btnImprimir.Name = "btnImprimir"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 0
        Me.btnFechar.Name = "btnFechar"
        '
        'btnRetornaSefaz
        '
        Me.btnRetornaSefaz.Location = New System.Drawing.Point(21, 170)
        Me.btnRetornaSefaz.Name = "btnRetornaSefaz"
        Me.btnRetornaSefaz.Size = New System.Drawing.Size(138, 26)
        Me.btnRetornaSefaz.TabIndex = 10
        Me.btnRetornaSefaz.Text = "Retorna Mens. SEFAZ"
        '
        'lblFor
        '
        Me.lblFor.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFor.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblFor.Appearance.Options.UseFont = True
        Me.lblFor.Appearance.Options.UseForeColor = True
        Me.lblFor.Location = New System.Drawing.Point(30, 4)
        Me.lblFor.Name = "lblFor"
        Me.lblFor.Size = New System.Drawing.Size(105, 13)
        Me.lblFor.TabIndex = 73
        Me.lblFor.Text = "Funções Auxiliares"
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Location = New System.Drawing.Point(9, 10)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(153, 5)
        Me.PanelControl1.TabIndex = 72
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(201, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl1.TabIndex = 75
        Me.LabelControl1.Text = "Visualização"
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Location = New System.Drawing.Point(180, 10)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(395, 5)
        Me.PanelControl2.TabIndex = 74
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(30, 119)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl2.TabIndex = 77
        Me.LabelControl2.Text = "Funções SAT"
        '
        'PanelControl3
        '
        Me.PanelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl3.Location = New System.Drawing.Point(9, 125)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(154, 5)
        Me.PanelControl3.TabIndex = 76
        '
        'btnDados
        '
        Me.btnDados.Location = New System.Drawing.Point(21, 202)
        Me.btnDados.Name = "btnDados"
        Me.btnDados.Size = New System.Drawing.Size(138, 26)
        Me.btnDados.TabIndex = 78
        Me.btnDados.Text = "Dados SAT"
        '
        'PrintDocument1
        '
        '
        'btnConfig
        '
        Me.btnConfig.Enabled = False
        Me.btnConfig.Location = New System.Drawing.Point(21, 371)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(138, 26)
        Me.btnConfig.TabIndex = 86
        Me.btnConfig.Text = "Configurações"
        '
        'ofdXml
        '
        Me.ofdXml.FileName = "OpenFileDialog1"
        '
        'btnAtivacao
        '
        Me.btnAtivacao.Enabled = False
        Me.btnAtivacao.Location = New System.Drawing.Point(21, 339)
        Me.btnAtivacao.Name = "btnAtivacao"
        Me.btnAtivacao.Size = New System.Drawing.Size(138, 26)
        Me.btnAtivacao.TabIndex = 87
        Me.btnAtivacao.Text = "Ativação/Associação"
        '
        'chkSatTeste
        '
        Me.chkSatTeste.Location = New System.Drawing.Point(500, 1)
        Me.chkSatTeste.Name = "chkSatTeste"
        Me.chkSatTeste.Properties.Caption = "Sat Teste"
        Me.chkSatTeste.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkSatTeste.Size = New System.Drawing.Size(71, 19)
        Me.chkSatTeste.TabIndex = 88
        Me.chkSatTeste.Visible = False
        '
        'btnAlterarNumeroSessao
        '
        Me.btnAlterarNumeroSessao.Enabled = False
        Me.btnAlterarNumeroSessao.Location = New System.Drawing.Point(21, 403)
        Me.btnAlterarNumeroSessao.Name = "btnAlterarNumeroSessao"
        Me.btnAlterarNumeroSessao.Size = New System.Drawing.Size(138, 26)
        Me.btnAlterarNumeroSessao.TabIndex = 89
        Me.btnAlterarNumeroSessao.Text = "Alterar Número Sessão"
        '
        'btnInstalar
        '
        Me.btnInstalar.Enabled = False
        Me.btnInstalar.Location = New System.Drawing.Point(21, 307)
        Me.btnInstalar.Name = "btnInstalar"
        Me.btnInstalar.Size = New System.Drawing.Size(138, 26)
        Me.btnInstalar.TabIndex = 90
        Me.btnInstalar.Text = "Instalar"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(30, 285)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl3.TabIndex = 92
        Me.LabelControl3.Text = "Configurações"
        '
        'PanelControl4
        '
        Me.PanelControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl4.Location = New System.Drawing.Point(9, 291)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(154, 5)
        Me.PanelControl4.TabIndex = 91
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(30, 234)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(97, 13)
        Me.LabelControl4.TabIndex = 94
        Me.LabelControl4.Text = "Arquivo Contator"
        '
        'PanelControl5
        '
        Me.PanelControl5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl5.Location = New System.Drawing.Point(9, 240)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(154, 5)
        Me.PanelControl5.TabIndex = 93
        '
        'btnGerarArquivo
        '
        Me.btnGerarArquivo.Location = New System.Drawing.Point(21, 254)
        Me.btnGerarArquivo.Name = "btnGerarArquivo"
        Me.btnGerarArquivo.Size = New System.Drawing.Size(138, 26)
        Me.btnGerarArquivo.TabIndex = 95
        Me.btnGerarArquivo.Text = "Gerar Arquivo"
        '
        'btnAtualizarSW
        '
        Me.btnAtualizarSW.Enabled = False
        Me.btnAtualizarSW.Location = New System.Drawing.Point(21, 435)
        Me.btnAtualizarSW.Name = "btnAtualizarSW"
        Me.btnAtualizarSW.Size = New System.Drawing.Size(138, 26)
        Me.btnAtualizarSW.TabIndex = 96
        Me.btnAtualizarSW.Text = "Atualizar SW"
        '
        'pnlMarquee
        '
        Me.pnlMarquee.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.pnlMarquee.Controls.Add(Me.bpMarquee)
        Me.pnlMarquee.Location = New System.Drawing.Point(165, 276)
        Me.pnlMarquee.Name = "pnlMarquee"
        Me.pnlMarquee.Size = New System.Drawing.Size(21, 15)
        Me.pnlMarquee.TabIndex = 97
        Me.pnlMarquee.Visible = False
        '
        'bpMarquee
        '
        Me.bpMarquee.EditValue = 0
        Me.bpMarquee.Location = New System.Drawing.Point(5, 12)
        Me.bpMarquee.Name = "bpMarquee"
        Me.bpMarquee.Size = New System.Drawing.Size(339, 27)
        Me.bpMarquee.TabIndex = 0
        '
        'frmMenuSAT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 504)
        Me.Controls.Add(Me.pnlMarquee)
        Me.Controls.Add(Me.btnAtualizarSW)
        Me.Controls.Add(Me.btnGerarArquivo)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.PanelControl5)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.btnInstalar)
        Me.Controls.Add(Me.btnAlterarNumeroSessao)
        Me.Controls.Add(Me.chkSatTeste)
        Me.Controls.Add(Me.btnAtivacao)
        Me.Controls.Add(Me.btnConfig)
        Me.Controls.Add(Me.btnDados)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.lblFor)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.rtfSAT)
        Me.Controls.Add(Me.btnRetornaSefaz)
        Me.Controls.Add(Me.btnUltimasInf)
        Me.Controls.Add(Me.btnCancelaCupom)
        Me.Controls.Add(Me.btnReducaoZ)
        Me.Controls.Add(Me.btnLX)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenuSAT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAT Fiscal"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSatTeste.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlMarquee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMarquee.ResumeLayout(False)
        CType(Me.bpMarquee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtfSAT As System.Windows.Forms.RichTextBox
    Friend WithEvents btnLX As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReducaoZ As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelaCupom As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnUltimasInf As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnRetornaSefaz As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblFor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDados As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnConfig As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ofdXml As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnAtivacao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkSatTeste As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnAlterarNumeroSessao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnInstalar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnGerarArquivo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnAtualizarSW As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlMarquee As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bpMarquee As DevExpress.XtraEditors.MarqueeProgressBarControl
End Class
