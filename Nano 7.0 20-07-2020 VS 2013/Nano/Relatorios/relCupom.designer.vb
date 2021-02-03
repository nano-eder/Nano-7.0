<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relCupom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(relCupom))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText
        Me.lblTexto = New DevExpress.XtraReports.UI.XRRichText
        Me.XrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTexto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.BorderWidth = 0
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrRichText1, Me.lblTexto})
        Me.Detail.Height = 492
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UseBorders = False
        Me.Detail.StylePriority.UseBorderWidth = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrRichText1
        '
        Me.XrRichText1.BackColor = System.Drawing.Color.Transparent
        Me.XrRichText1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrRichText1.BorderWidth = 1
        Me.XrRichText1.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrRichText1.Location = New System.Drawing.Point(0, 8)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.Size = New System.Drawing.Size(367, 25)
        Me.XrRichText1.StylePriority.UseBackColor = False
        Me.XrRichText1.StylePriority.UseBorders = False
        Me.XrRichText1.StylePriority.UseBorderWidth = False
        Me.XrRichText1.StylePriority.UseFont = False
        '
        'lblTexto
        '
        Me.lblTexto.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lblTexto.BorderWidth = 1
        Me.lblTexto.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.lblTexto.Location = New System.Drawing.Point(0, 42)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.SerializableRtfString = resources.GetString("lblTexto.SerializableRtfString")
        Me.lblTexto.Size = New System.Drawing.Size(367, 358)
        Me.lblTexto.StylePriority.UseBorders = False
        Me.lblTexto.StylePriority.UseBorderWidth = False
        Me.lblTexto.StylePriority.UseFont = False
        '
        'XrControlStyle1
        '
        Me.XrControlStyle1.Name = "XrControlStyle1"
        Me.XrControlStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        '
        'relCupom
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        Me.PageHeight = 500
        Me.PageWidth = 380
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.ShowPreviewMarginLines = False
        Me.ShowPrintingWarnings = False
        Me.StylePriority.UseBorders = False
        Me.StylePriority.UseBorderWidth = False
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.XrControlStyle1})
        Me.Version = "8.2"
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTexto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents lblTexto As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText1 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
End Class
