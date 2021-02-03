<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relEnvelope
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
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblCid = New DevExpress.XtraReports.UI.XRLabel
        Me.lblCep = New DevExpress.XtraReports.UI.XRLabel
        Me.lblBai = New DevExpress.XtraReports.UI.XRLabel
        Me.lblNum = New DevExpress.XtraReports.UI.XRLabel
        Me.lblEnd = New DevExpress.XtraReports.UI.XRLabel
        Me.lblNome = New DevExpress.XtraReports.UI.XRLabel
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.lblCid, Me.lblCep, Me.lblBai, Me.lblNum, Me.lblEnd, Me.lblNome})
        Me.Detail.Height = 118
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.Location = New System.Drawing.Point(142, 92)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(50, 17)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "SP"
        '
        'lblCid
        '
        Me.lblCid.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCid.Location = New System.Drawing.Point(17, 92)
        Me.lblCid.Name = "lblCid"
        Me.lblCid.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblCid.Size = New System.Drawing.Size(117, 17)
        Me.lblCid.StylePriority.UseFont = False
        '
        'lblCep
        '
        Me.lblCep.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCep.Location = New System.Drawing.Point(200, 75)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblCep.Size = New System.Drawing.Size(92, 17)
        Me.lblCep.StylePriority.UseFont = False
        '
        'lblBai
        '
        Me.lblBai.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBai.Location = New System.Drawing.Point(17, 75)
        Me.lblBai.Name = "lblBai"
        Me.lblBai.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblBai.Size = New System.Drawing.Size(175, 17)
        Me.lblBai.StylePriority.UseFont = False
        '
        'lblNum
        '
        Me.lblNum.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.Location = New System.Drawing.Point(208, 58)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNum.Size = New System.Drawing.Size(67, 17)
        Me.lblNum.StylePriority.UseFont = False
        '
        'lblEnd
        '
        Me.lblEnd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.Location = New System.Drawing.Point(17, 58)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblEnd.Size = New System.Drawing.Size(183, 17)
        Me.lblEnd.StylePriority.UseFont = False
        '
        'lblNome
        '
        Me.lblNome.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(17, 42)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNome.Size = New System.Drawing.Size(275, 17)
        Me.lblNome.StylePriority.UseFont = False
        '
        'relEnvelope
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
        Me.Margins = New System.Drawing.Printing.Margins(35, 436, 35, 100)
        Me.Version = "8.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents lblNome As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblEnd As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblCid As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblCep As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblBai As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblNum As DevExpress.XtraReports.UI.XRLabel
End Class
