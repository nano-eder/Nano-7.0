<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmErro
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
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmErro))
        Me.lblMsg = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.txtMsg = New System.Windows.Forms.RichTextBox
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.grpTetalhe = New DevExpress.XtraEditors.GroupControl
        Me.txtDetalhes = New System.Windows.Forms.RichTextBox
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.btnMail = New DevExpress.XtraEditors.SimpleButton
        Me.btnTentar = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.btnDetails = New DevExpress.XtraEditors.SimpleButton
        Me.btnTeste = New DevExpress.XtraEditors.SimpleButton
        Me.grpEmail = New DevExpress.XtraEditors.GroupControl
        Me.txtMail = New System.Windows.Forms.RichTextBox
        Label1 = New System.Windows.Forms.Label
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grpTetalhe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTetalhe.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.grpEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEmail.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Red
        Label1.Location = New System.Drawing.Point(102, 24)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(228, 28)
        Label1.TabIndex = 103
        Label1.Text = "Atenção!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ocorreu algum erro ao salvar dados."
        '
        'lblMsg
        '
        Me.lblMsg.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblMsg.Appearance.Options.UseFont = True
        Me.lblMsg.Appearance.Options.UseForeColor = True
        Me.lblMsg.Location = New System.Drawing.Point(105, 55)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(498, 16)
        Me.lblMsg.TabIndex = 102
        Me.lblMsg.Text = "Clique em teste de conexão, para testar sua conexão com o banco de dados."
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.lblMsg)
        Me.PanelControl2.Controls.Add(Label1)
        Me.PanelControl2.Controls.Add(Me.PictureBox1)
        Me.PanelControl2.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(660, 85)
        Me.PanelControl2.TabIndex = 101
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Nano.My.Resources.Resources.aviso
        Me.PictureBox1.Location = New System.Drawing.Point(7, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.White
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.txtMsg)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 383)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(660, 45)
        Me.PanelControl1.TabIndex = 109
        '
        'txtMsg
        '
        Me.txtMsg.BackColor = System.Drawing.Color.White
        Me.txtMsg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMsg.Location = New System.Drawing.Point(2, 2)
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.ReadOnly = True
        Me.txtMsg.Size = New System.Drawing.Size(656, 41)
        Me.txtMsg.TabIndex = 0
        Me.txtMsg.Text = ""
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(15, 368)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(68, 14)
        Me.LabelControl1.TabIndex = 110
        Me.LabelControl1.Text = "Mensagens"
        '
        'grpTetalhe
        '
        Me.grpTetalhe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTetalhe.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTetalhe.AppearanceCaption.Options.UseFont = True
        Me.grpTetalhe.Controls.Add(Me.txtDetalhes)
        Me.grpTetalhe.Location = New System.Drawing.Point(12, 163)
        Me.grpTetalhe.Name = "grpTetalhe"
        Me.grpTetalhe.Size = New System.Drawing.Size(658, 195)
        Me.grpTetalhe.TabIndex = 112
        Me.grpTetalhe.Text = "Detalhes do erro"
        Me.grpTetalhe.Visible = False
        '
        'txtDetalhes
        '
        Me.txtDetalhes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDetalhes.Location = New System.Drawing.Point(2, 20)
        Me.txtDetalhes.Name = "txtDetalhes"
        Me.txtDetalhes.Size = New System.Drawing.Size(654, 173)
        Me.txtDetalhes.TabIndex = 1
        Me.txtDetalhes.Text = ""
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.SimpleButton3)
        Me.PanelControl3.Controls.Add(Me.btnMail)
        Me.PanelControl3.Controls.Add(Me.btnTentar)
        Me.PanelControl3.Location = New System.Drawing.Point(14, 447)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(660, 54)
        Me.PanelControl3.TabIndex = 113
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.Image = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.SimpleButton3.Location = New System.Drawing.Point(485, 11)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(159, 37)
        Me.SimpleButton3.TabIndex = 114
        Me.SimpleButton3.Text = "Fechar"
        '
        'btnMail
        '
        Me.btnMail.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMail.Appearance.Options.UseFont = True
        Me.btnMail.Image = Global.Nano.My.Resources.Resources.Sent_Mail
        Me.btnMail.Location = New System.Drawing.Point(251, 11)
        Me.btnMail.Name = "btnMail"
        Me.btnMail.Size = New System.Drawing.Size(159, 37)
        Me.btnMail.TabIndex = 113
        Me.btnMail.Text = "Enviar E-Mail"
        '
        'btnTentar
        '
        Me.btnTentar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTentar.Appearance.Options.UseFont = True
        Me.btnTentar.Image = Global.Nano.My.Resources.Resources.apply
        Me.btnTentar.Location = New System.Drawing.Point(15, 11)
        Me.btnTentar.Name = "btnTentar"
        Me.btnTentar.Size = New System.Drawing.Size(159, 37)
        Me.btnTentar.TabIndex = 112
        Me.btnTentar.Text = "Tentar Novamente"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(28, 440)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(36, 14)
        Me.LabelControl2.TabIndex = 114
        Me.LabelControl2.Text = "Ações"
        '
        'btnDetails
        '
        Me.btnDetails.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetails.Appearance.Options.UseFont = True
        Me.btnDetails.Image = Global.Nano.My.Resources.Resources.viewmag
        Me.btnDetails.Location = New System.Drawing.Point(461, 120)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(209, 37)
        Me.btnDetails.TabIndex = 111
        Me.btnDetails.Text = "Detalhes"
        Me.btnDetails.Visible = False
        '
        'btnTeste
        '
        Me.btnTeste.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeste.Appearance.Options.UseFont = True
        Me.btnTeste.Image = Global.Nano.My.Resources.Resources.DBSQL
        Me.btnTeste.Location = New System.Drawing.Point(12, 120)
        Me.btnTeste.Name = "btnTeste"
        Me.btnTeste.Size = New System.Drawing.Size(209, 37)
        Me.btnTeste.TabIndex = 108
        Me.btnTeste.Text = "Teste de Conexão"
        '
        'grpEmail
        '
        Me.grpEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEmail.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEmail.AppearanceCaption.Options.UseFont = True
        Me.grpEmail.Controls.Add(Me.txtMail)
        Me.grpEmail.Location = New System.Drawing.Point(13, 12)
        Me.grpEmail.Name = "grpEmail"
        Me.grpEmail.Size = New System.Drawing.Size(658, 422)
        Me.grpEmail.TabIndex = 115
        Me.grpEmail.Text = "Digite as informações que serão enviadas ao suporte do Nano Commerce"
        Me.grpEmail.Visible = False
        '
        'txtMail
        '
        Me.txtMail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMail.Location = New System.Drawing.Point(2, 20)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(654, 400)
        Me.txtMail.TabIndex = 1
        Me.txtMail.Text = ""
        '
        'frmErro
        '
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 505)
        Me.Controls.Add(Me.grpEmail)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.grpTetalhe)
        Me.Controls.Add(Me.btnDetails)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.btnTeste)
        Me.Controls.Add(Me.PanelControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmErro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aviso Nano"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.grpTetalhe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTetalhe.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.grpEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEmail.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMsg As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnTeste As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMsg As System.Windows.Forms.RichTextBox
    Friend WithEvents btnDetails As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpTetalhe As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDetalhes As System.Windows.Forms.RichTextBox
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTentar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEmail As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtMail As System.Windows.Forms.RichTextBox
End Class
