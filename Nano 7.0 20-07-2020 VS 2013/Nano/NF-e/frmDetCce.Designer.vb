<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetCce
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetCce))
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.memCondUso = New DevExpress.XtraEditors.MemoEdit
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.txtNumNF = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.txtHora = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.txtVersao = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.txtCnpj = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtDescEvento = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtTZD = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtCodUF = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtTipoEvento = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtChave = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtNumSeqEvento = New DevExpress.XtraEditors.TextEdit
        Me.dtData = New DevExpress.XtraEditors.DateEdit
        Me.memCorrecao = New DevExpress.XtraEditors.MemoEdit
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Label1 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.memCondUso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtNumNF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVersao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCnpj.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescEvento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTZD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodUF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoEvento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumSeqEvento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memCorrecao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Blue
        Label1.Location = New System.Drawing.Point(23, 4)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(108, 14)
        Label1.TabIndex = 113
        Label1.Text = "Condição de Uso"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.Color.Blue
        Label6.Location = New System.Drawing.Point(23, 118)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(96, 14)
        Label6.TabIndex = 112
        Label6.Text = "Dados da CC-e"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Controls.Add(Me.memCondUso)
        Me.PanelControl2.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(742, 100)
        Me.PanelControl2.TabIndex = 111
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(18, 13)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Condição"
        '
        'memCondUso
        '
        Me.memCondUso.Enabled = False
        Me.memCondUso.Location = New System.Drawing.Point(68, 11)
        Me.memCondUso.Name = "memCondUso"
        Me.memCondUso.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.memCondUso.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.memCondUso.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.memCondUso.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.memCondUso.Properties.AppearanceDisabled.Options.UseFont = True
        Me.memCondUso.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.memCondUso.Size = New System.Drawing.Size(669, 80)
        Me.memCondUso.TabIndex = 6
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl13)
        Me.PanelControl1.Controls.Add(Me.txtNumNF)
        Me.PanelControl1.Controls.Add(Me.LabelControl12)
        Me.PanelControl1.Controls.Add(Me.txtHora)
        Me.PanelControl1.Controls.Add(Me.LabelControl11)
        Me.PanelControl1.Controls.Add(Me.txtVersao)
        Me.PanelControl1.Controls.Add(Me.LabelControl10)
        Me.PanelControl1.Controls.Add(Me.txtCnpj)
        Me.PanelControl1.Controls.Add(Me.LabelControl9)
        Me.PanelControl1.Controls.Add(Me.txtDescEvento)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.txtTZD)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.txtCodUF)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.txtTipoEvento)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txtChave)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtNumSeqEvento)
        Me.PanelControl1.Controls.Add(Me.dtData)
        Me.PanelControl1.Controls.Add(Me.memCorrecao)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 126)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(742, 233)
        Me.PanelControl1.TabIndex = 110
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(178, 43)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl13.TabIndex = 23
        Me.LabelControl13.Text = "Num. NF"
        '
        'txtNumNF
        '
        Me.txtNumNF.Enabled = False
        Me.txtNumNF.Location = New System.Drawing.Point(225, 40)
        Me.txtNumNF.Name = "txtNumNF"
        Me.txtNumNF.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNumNF.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNumNF.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNumNF.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNumNF.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtNumNF.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNumNF.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtNumNF.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNumNF.Size = New System.Drawing.Size(88, 20)
        Me.txtNumNF.TabIndex = 22
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(196, 95)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl12.TabIndex = 21
        Me.LabelControl12.Text = "Hora"
        '
        'txtHora
        '
        Me.txtHora.Enabled = False
        Me.txtHora.Location = New System.Drawing.Point(225, 92)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtHora.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtHora.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtHora.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtHora.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtHora.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtHora.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtHora.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtHora.Size = New System.Drawing.Size(88, 20)
        Me.txtHora.TabIndex = 20
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(29, 43)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl11.TabIndex = 19
        Me.LabelControl11.Text = "Versão"
        '
        'txtVersao
        '
        Me.txtVersao.Enabled = False
        Me.txtVersao.Location = New System.Drawing.Point(68, 40)
        Me.txtVersao.Name = "txtVersao"
        Me.txtVersao.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtVersao.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtVersao.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtVersao.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtVersao.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtVersao.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtVersao.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtVersao.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtVersao.Size = New System.Drawing.Size(103, 20)
        Me.txtVersao.TabIndex = 18
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(37, 17)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl10.TabIndex = 17
        Me.LabelControl10.Text = "CNPJ"
        '
        'txtCnpj
        '
        Me.txtCnpj.Enabled = False
        Me.txtCnpj.Location = New System.Drawing.Point(68, 14)
        Me.txtCnpj.Name = "txtCnpj"
        Me.txtCnpj.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCnpj.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCnpj.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCnpj.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCnpj.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtCnpj.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCnpj.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtCnpj.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCnpj.Size = New System.Drawing.Size(245, 20)
        Me.txtCnpj.TabIndex = 16
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(320, 69)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl9.TabIndex = 15
        Me.LabelControl9.Text = "Desc. Evento"
        '
        'txtDescEvento
        '
        Me.txtDescEvento.Enabled = False
        Me.txtDescEvento.Location = New System.Drawing.Point(390, 66)
        Me.txtDescEvento.Name = "txtDescEvento"
        Me.txtDescEvento.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDescEvento.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDescEvento.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtDescEvento.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtDescEvento.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtDescEvento.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtDescEvento.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtDescEvento.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDescEvento.Size = New System.Drawing.Size(347, 20)
        Me.txtDescEvento.TabIndex = 14
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(365, 95)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl8.TabIndex = 13
        Me.LabelControl8.Text = "TZD"
        '
        'txtTZD
        '
        Me.txtTZD.Enabled = False
        Me.txtTZD.Location = New System.Drawing.Point(390, 92)
        Me.txtTZD.Name = "txtTZD"
        Me.txtTZD.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTZD.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTZD.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtTZD.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtTZD.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtTZD.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtTZD.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtTZD.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTZD.Size = New System.Drawing.Size(117, 20)
        Me.txtTZD.TabIndex = 12
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(345, 17)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl7.TabIndex = 11
        Me.LabelControl7.Text = "Cód. UF"
        '
        'txtCodUF
        '
        Me.txtCodUF.Enabled = False
        Me.txtCodUF.Location = New System.Drawing.Point(390, 14)
        Me.txtCodUF.Name = "txtCodUF"
        Me.txtCodUF.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCodUF.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCodUF.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodUF.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCodUF.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtCodUF.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodUF.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtCodUF.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCodUF.Size = New System.Drawing.Size(117, 20)
        Me.txtCodUF.TabIndex = 10
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(5, 69)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl6.TabIndex = 9
        Me.LabelControl6.Text = "Tipo Evento"
        '
        'txtTipoEvento
        '
        Me.txtTipoEvento.Enabled = False
        Me.txtTipoEvento.Location = New System.Drawing.Point(68, 66)
        Me.txtTipoEvento.Name = "txtTipoEvento"
        Me.txtTipoEvento.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTipoEvento.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTipoEvento.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtTipoEvento.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtTipoEvento.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtTipoEvento.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtTipoEvento.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtTipoEvento.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTipoEvento.Size = New System.Drawing.Size(245, 20)
        Me.txtTipoEvento.TabIndex = 8
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(353, 43)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl5.TabIndex = 7
        Me.LabelControl5.Text = "Chave"
        '
        'txtChave
        '
        Me.txtChave.Enabled = False
        Me.txtChave.Location = New System.Drawing.Point(390, 40)
        Me.txtChave.Name = "txtChave"
        Me.txtChave.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtChave.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtChave.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtChave.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtChave.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtChave.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtChave.Size = New System.Drawing.Size(347, 20)
        Me.txtChave.TabIndex = 6
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(18, 120)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Correção"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(39, 95)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Data"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(562, 95)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Seq. Evento"
        '
        'txtNumSeqEvento
        '
        Me.txtNumSeqEvento.Enabled = False
        Me.txtNumSeqEvento.Location = New System.Drawing.Point(627, 92)
        Me.txtNumSeqEvento.Name = "txtNumSeqEvento"
        Me.txtNumSeqEvento.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNumSeqEvento.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNumSeqEvento.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNumSeqEvento.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNumSeqEvento.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtNumSeqEvento.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNumSeqEvento.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtNumSeqEvento.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNumSeqEvento.Size = New System.Drawing.Size(110, 20)
        Me.txtNumSeqEvento.TabIndex = 1
        '
        'dtData
        '
        Me.dtData.EditValue = Nothing
        Me.dtData.Enabled = False
        Me.dtData.Location = New System.Drawing.Point(68, 92)
        Me.dtData.Name = "dtData"
        Me.dtData.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dtData.Properties.Appearance.Options.UseFont = True
        Me.dtData.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.dtData.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.dtData.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.dtData.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.dtData.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtData.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtData.Size = New System.Drawing.Size(103, 20)
        Me.dtData.TabIndex = 0
        '
        'memCorrecao
        '
        Me.memCorrecao.Enabled = False
        Me.memCorrecao.Location = New System.Drawing.Point(68, 118)
        Me.memCorrecao.Name = "memCorrecao"
        Me.memCorrecao.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.memCorrecao.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.memCorrecao.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.memCorrecao.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.memCorrecao.Properties.AppearanceDisabled.Options.UseFont = True
        Me.memCorrecao.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.memCorrecao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.memCorrecao.Size = New System.Drawing.Size(669, 105)
        Me.memCorrecao.TabIndex = 2
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnFechar})
        Me.BarManager1.MaxItemId = 1
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 0
        Me.btnFechar.Name = "btnFechar"
        '
        'frmDetCce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 404)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDetCce"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta da CC-e"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.memCondUso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtNumNF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVersao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCnpj.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescEvento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTZD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodUF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoEvento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumSeqEvento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memCorrecao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents memCondUso As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtChave As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumSeqEvento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtData As DevExpress.XtraEditors.DateEdit
    Friend WithEvents memCorrecao As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescEvento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTZD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodUF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTipoEvento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCnpj As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtHora As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVersao As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumNF As DevExpress.XtraEditors.TextEdit
End Class
