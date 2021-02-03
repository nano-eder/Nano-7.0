<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonitor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonitor))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.marquee = New DevExpress.XtraEditors.MarqueeProgressBarControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnCalcel = New DevExpress.XtraEditors.SimpleButton
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton
        Me.lstLojas = New DevExpress.XtraEditors.ListBoxControl
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.marquee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstLojas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'marquee
        '
        Me.marquee.EditValue = 0
        Me.marquee.Location = New System.Drawing.Point(8, 188)
        Me.marquee.Name = "marquee"
        Me.marquee.Size = New System.Drawing.Size(345, 21)
        Me.marquee.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Location = New System.Drawing.Point(8, 218)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(344, 5)
        Me.PanelControl1.TabIndex = 1
        '
        'btnCalcel
        '
        Me.btnCalcel.Location = New System.Drawing.Point(278, 230)
        Me.btnCalcel.Name = "btnCalcel"
        Me.btnCalcel.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcel.TabIndex = 2
        Me.btnCalcel.Text = "&Cancelar"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(278, 230)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "&OK"
        Me.btnOK.Visible = False
        '
        'lstLojas
        '
        Me.lstLojas.Location = New System.Drawing.Point(8, 4)
        Me.lstLojas.Name = "lstLojas"
        Me.lstLojas.Size = New System.Drawing.Size(345, 176)
        Me.lstLojas.TabIndex = 4
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'frmMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 265)
        Me.ControlBox = False
        Me.Controls.Add(Me.lstLojas)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCalcel)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.marquee)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMonitor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sincronizando Sistemas"
        CType(Me.marquee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstLojas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents marquee As DevExpress.XtraEditors.MarqueeProgressBarControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCalcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lstLojas As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
