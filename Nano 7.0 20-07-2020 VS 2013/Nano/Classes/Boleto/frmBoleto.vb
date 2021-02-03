Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO
Imports CrystalDecisions.Web



Public Class frmBoleto
    Public strCaminho(1) As String
    Public strEmailCliente As String
    Public strNumNf As String
    Public strCNPJ As String
    Public strTipo As String
    Dim bolEmail As Boolean
    Private DiskFileDestOpts As DiskFileDestinationOptions
    Private ExportOpts As ExportOptions
    Public intPageFinal As Integer
    Public intPageAtual As Integer
    Dim intPageInicial As Integer
    Private Sub frmDanfe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim tabFicha As Windows.Forms.TabControl
            Dim myControl As System.Windows.Forms.Control
            For Each myControl In Me.CrystalReportViewer1.Controls
                If UCase(myControl.GetType.Name) = "PAGEVIEW" Then
                    tabFicha = CType(myControl.Controls(0), TabControl)
                    With tabFicha
                        .ItemSize = New Size(0, 1)
                        .SizeMode = TabSizeMode.Fixed
                        .Appearance = TabAppearance.Buttons
                    End With
                End If
            Next
        Catch ex As Exception

        End Try


        'TraduzirCRV(Me.CrystalReportViewer1)

    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnEmail_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEmail.ItemClick
        bolEmail = True
        Enviar()
    End Sub
    Private Sub Enviar()
        Dim frm As New frmEmail

        frm.txtPara.Text = strEmailCliente.ToLower
        frm.rtbTexto.Text = "Boleto enviado pela Empresa: " & NomeEmpresa & " - CNPJ: " & strCNPJ & ""
        frm.lstAnexo.Items.Add(strCaminho(0))
        frm.nbcAnexo.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded
        frm.Tag = "BOLETO"
        frm.Show()
    End Sub


    Private Sub btnImprimir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImprimir.ItemClick
        Dim RptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        RptDoc = CType(CrystalReportViewer1.ReportSource, CrystalDecisions.CrystalReports.Engine.ReportDocument)


        PrintDialog1.Document = New Printing.PrintDocument
        PrintDialog1.AllowSelection = False
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            RptDoc.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName
            RptDoc.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, PrintDialog1.PrinterSettings.Collate, PrintDialog1.PrinterSettings.FromPage, PrintDialog1.PrinterSettings.ToPage)

            'RptDoc.Close()
            'RptDoc.Dispose()
        End If

        PrintDialog1.Dispose()
    End Sub

    '   Me.CrystalReportViewer1.Zoom(10)
    Private Sub ExportSetup()
        DiskFileDestOpts = New DiskFileDestinationOptions()
        DiskFileDestOpts.DiskFileName = sfdDanfe.FileName

        ExportOpts = New ExportOptions
        ExportOpts.ExportDestinationType = ExportDestinationType.DiskFile
        ExportOpts.DestinationOptions = DiskFileDestOpts
        ExportOpts.FormatOptions = Nothing
    End Sub

    Private Sub ExportFormat()
        Select Case sfdDanfe.FilterIndex
            Case 1
                ExportOpts.ExportFormatType = ExportFormatType.PortableDocFormat
            Case 2
                ExportOpts.ExportFormatType = ExportFormatType.Excel
            Case 3
                ExportOpts.ExportFormatType = ExportFormatType.WordForWindows
            Case 4
                ExportOpts.ExportFormatType = ExportFormatType.RichText
            Case Else
                ExportOpts.ExportFormatType = ExportFormatType.NoFormat
        End Select
    End Sub

    Private Sub Destroy()
        DiskFileDestOpts = Nothing
        ExportOpts = Nothing
    End Sub

    Private Sub BarCheckItem1_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItem1.CheckedChanged
        If Me.BarCheckItem1.Checked = True Then
            Me.BarCheckItem2.Checked = False
            Me.BarCheckItem3.Checked = False
            Me.BarCheckItem4.Checked = False
            Me.BarCheckItem5.Checked = False
            Me.BarCheckItem6.Checked = False
            Me.BarCheckItem7.Checked = False
            Me.BarCheckItem8.Checked = False
            Me.BarCheckItem9.Checked = False

            Me.CrystalReportViewer1.Zoom(1)
            Me.lblZoom.Text = Me.lblZoom.Tag & Me.BarCheckItem1.Caption
        End If



    End Sub

    Private Sub TraduzirCRV(ByVal Cntl As CrystalDecisions.Windows.Forms.CrystalReportViewer)
        For Each Ctl As Control In Cntl.Controls
            'Aqui está o dicionário para fazer a trudução, para quem quiser o texto em portugues que vai permanecer é só alterar aqui.
            Dim Traducoes As New Dictionary(Of String, String)()
            Traducoes.Add("Export Report", "Exportar")
            Traducoes.Add("Print Report", "Imprimir")
            Traducoes.Add("Refresh", "Atualizar")
            Traducoes.Add("Toggle Parameter Panel", "Mostrar/Esconder Painel de parâmetros")
            Traducoes.Add("Toggle Group Tree", "Mostrar/Esconder árvore de grupos")
            Traducoes.Add("Go to First Page", "Primeira página")
            Traducoes.Add("Go to Previous Page", "Página anterior")
            Traducoes.Add("Go to Next Page", "Próxima página")
            Traducoes.Add("Go to Last Page", "Última página")
            Traducoes.Add("Go to Page", "Ir para página")
            Traducoes.Add("Find Text", "Procurar")
            Traducoes.Add("Zoom", "Zoom")
            Traducoes.Add("Close Current View", "Fechar")
            Traducoes.Add("Page Width", "Largura da página")
            Traducoes.Add("Whole Page", "Página Inteira")
            Traducoes.Add("Customize...", "Customizar...")
            Traducoes.Add("Current Page No.", "Nr. página atual")
            Traducoes.Add("Total Page No.", "Nr. Total páginas")
            Traducoes.Add("Zoom Factor", "Nível de zoom")

            'Alterando o texto da tabpage principal(Onde está escrito Main Report).
            If Ctl.GetType.ToString() = GetType(CrystalDecisions.Windows.Forms.PageView).ToString Then
                Try
                    DirectCast(Ctl.Controls(0), TabControl).TabPages(0).Text = ""

                Catch
                End Try

                'Alterando o texto dos componente que ficam na barra superior.
            ElseIf Ctl.GetType.ToString() = GetType(System.Windows.Forms.ToolStrip).ToString Then
                For Each Ti As ToolStripItem In DirectCast(Ctl, ToolStrip).Items
                    If Ti.ToolTipText IsNot Nothing Then
                        Ti.ToolTipText = Traducoes(Ti.ToolTipText)
                        'Aqui eu escondo dois itens da barra superior que no meu contexto são irrelevantes o que mostra uma barra com os parametros
                        ' e o que mostra uma treeview com os grupos do relatório.
                        If Ti.ToolTipText = "Invisible" Then
                            Ti.Visible = False

                            'Aqui traduzindo os itens dentro do dropdown Zoom.
                        ElseIf Ti.ToolTipText = "Zoom" AndAlso Ti.GetType.ToString() = GetType(ToolStripDropDownButton).ToString Then
                            Dim ItensDD As String(,) = New String(29, 3) {}
                            For Each TiF As ToolStripItem In DirectCast(Ti, ToolStripDropDownButton).DropDownItems
                                Try
                                    TiF.Text = Traducoes(TiF.Text)
                                Catch
                                End Try
                            Next
                        End If
                    End If
                Next

                'Alterando os textos da status bar
            ElseIf Ctl.GetType.ToString() = GetType(StatusBar).ToString Then
                For Each StBrPnl As StatusBarPanel In DirectCast(Ctl, StatusBar).Panels
                    Dim Texto As String = StBrPnl.Text.Substring(0, StBrPnl.Text.IndexOf(":"))
                    StBrPnl.Text = StBrPnl.Text.Replace(Texto, Traducoes(Texto))
                Next
            End If
        Next
    End Sub

    Private Sub BarCheckItem3_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItem3.CheckedChanged
        If Me.BarCheckItem3.Checked = True Then
            Me.BarCheckItem1.Checked = False
            Me.BarCheckItem2.Checked = False
            Me.BarCheckItem4.Checked = False
            Me.BarCheckItem5.Checked = False
            Me.BarCheckItem6.Checked = False
            Me.BarCheckItem7.Checked = False
            Me.BarCheckItem8.Checked = False
            Me.BarCheckItem9.Checked = False
            Me.CrystalReportViewer1.Zoom(400)
            Me.lblZoom.Text = Me.lblZoom.Tag & Me.BarCheckItem3.Caption
        End If


    End Sub

    Private Sub BarCheckItem4_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItem4.CheckedChanged
        If Me.BarCheckItem4.Checked = True Then
            Me.BarCheckItem1.Checked = False
            Me.BarCheckItem2.Checked = False
            Me.BarCheckItem3.Checked = False
            Me.BarCheckItem5.Checked = False
            Me.BarCheckItem6.Checked = False
            Me.BarCheckItem7.Checked = False
            Me.BarCheckItem8.Checked = False
            Me.BarCheckItem9.Checked = False
            Me.CrystalReportViewer1.Zoom(300)
            Me.lblZoom.Text = Me.lblZoom.Tag & Me.BarCheckItem4.Caption
        End If

    End Sub

    Private Sub BarCheckItem5_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItem5.CheckedChanged
        If Me.BarCheckItem5.Checked = True Then
            Me.BarCheckItem1.Checked = False
            Me.BarCheckItem2.Checked = False
            Me.BarCheckItem3.Checked = False
            Me.BarCheckItem4.Checked = False
            Me.BarCheckItem6.Checked = False
            Me.BarCheckItem7.Checked = False
            Me.BarCheckItem8.Checked = False
            Me.BarCheckItem9.Checked = False
            Me.CrystalReportViewer1.Zoom(200)
            Me.lblZoom.Text = Me.lblZoom.Tag & Me.BarCheckItem5.Caption
        End If

    End Sub

    Private Sub BarCheckItem6_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItem6.CheckedChanged
        If Me.BarCheckItem6.Checked = True Then
            Me.BarCheckItem1.Checked = False
            Me.BarCheckItem2.Checked = False
            Me.BarCheckItem3.Checked = False
            Me.BarCheckItem4.Checked = False
            Me.BarCheckItem5.Checked = False
            Me.BarCheckItem7.Checked = False
            Me.BarCheckItem8.Checked = False
            Me.BarCheckItem9.Checked = False
            Me.CrystalReportViewer1.Zoom(100)
            Me.lblZoom.Text = Me.lblZoom.Tag & Me.BarCheckItem6.Caption
        End If

    End Sub

    Private Sub BarCheckItem7_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItem7.CheckedChanged
        If Me.BarCheckItem7.Checked = True Then
            Me.BarCheckItem1.Checked = False
            Me.BarCheckItem2.Checked = False
            Me.BarCheckItem3.Checked = False
            Me.BarCheckItem4.Checked = False
            Me.BarCheckItem5.Checked = False
            Me.BarCheckItem6.Checked = False
            Me.BarCheckItem8.Checked = False
            Me.BarCheckItem9.Checked = False
            Me.CrystalReportViewer1.Zoom(75)
            Me.lblZoom.Text = Me.lblZoom.Tag & Me.BarCheckItem7.Caption
        End If

    End Sub

    Private Sub BarCheckItem8_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItem8.CheckedChanged
        If Me.BarCheckItem8.Checked = True Then
            Me.BarCheckItem1.Checked = False
            Me.BarCheckItem2.Checked = False
            Me.BarCheckItem3.Checked = False
            Me.BarCheckItem4.Checked = False
            Me.BarCheckItem5.Checked = False
            Me.BarCheckItem6.Checked = False
            Me.BarCheckItem7.Checked = False
            Me.BarCheckItem9.Checked = False
            Me.CrystalReportViewer1.Zoom(50)
            Me.lblZoom.Text = Me.lblZoom.Tag & Me.BarCheckItem8.Caption
        End If

    End Sub

    Private Sub BarCheckItem9_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItem9.CheckedChanged
        If Me.BarCheckItem9.Checked = True Then
            Me.BarCheckItem1.Checked = False
            Me.BarCheckItem2.Checked = False
            Me.BarCheckItem3.Checked = False
            Me.BarCheckItem4.Checked = False
            Me.BarCheckItem5.Checked = False
            Me.BarCheckItem6.Checked = False
            Me.BarCheckItem7.Checked = False
            Me.BarCheckItem8.Checked = False
            Me.CrystalReportViewer1.Zoom(25)
            Me.lblZoom.Text = Me.lblZoom.Tag & Me.BarCheckItem9.Caption
        End If

    End Sub

    Private Sub BarCheckItem2_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItem2.CheckedChanged
        If Me.BarCheckItem2.Checked = True Then
            Me.BarCheckItem1.Checked = False
            Me.BarCheckItem3.Checked = False
            Me.BarCheckItem4.Checked = False
            Me.BarCheckItem5.Checked = False
            Me.BarCheckItem6.Checked = False
            Me.BarCheckItem7.Checked = False
            Me.BarCheckItem8.Checked = False
            Me.BarCheckItem9.Checked = False
            Me.CrystalReportViewer1.Zoom(2)
            Me.lblZoom.Text = Me.lblZoom.Tag & Me.BarCheckItem2.Caption
        End If

    End Sub

    Private Sub btnBack1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack1.ItemClick
        CrystalReportViewer1.ShowNthPage(1)
        Me.lblPaginaAtual.Text = Me.lblPaginaAtual.Tag & "1"
    End Sub

    Private Sub btnBack_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        If intPageAtual > 1 Then
            intPageAtual -= 1
            CrystalReportViewer1.ShowNthPage(intPageAtual)
            Me.lblPaginaAtual.Text = Me.lblPaginaAtual.Tag & intPageAtual
        Else
            CrystalReportViewer1.ShowNthPage(intPageAtual)
            Me.lblPaginaAtual.Text = Me.lblPaginaAtual.Tag & intPageAtual
        End If
    End Sub

    Private Sub btnNext_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNext.ItemClick
        If intPageAtual < intPageFinal Then
            intPageAtual += 1
            CrystalReportViewer1.ShowNthPage(intPageAtual)
            Me.lblPaginaAtual.Text = Me.lblPaginaAtual.Tag & intPageAtual
        Else
            CrystalReportViewer1.ShowNthPage(intPageAtual)
            Me.lblPaginaAtual.Text = Me.lblPaginaAtual.Tag & intPageAtual
        End If
    End Sub

    Private Sub btnNext1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNext1.ItemClick
        CrystalReportViewer1.ShowNthPage(intPageFinal)
        Me.lblPaginaAtual.Text = Me.lblPaginaAtual.Tag & intPageFinal
    End Sub

    Private Sub btnExportar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportar.ItemClick
        Try
            sfdDanfe.Filter = "Adobe Acrobat (*.pdf)|*.pdf|Microsoft Excel (*.xls)|*.xls|Microsoft Word (*.doc)|*.doc|Rich Text Format (*.rtf)|*.rtf"

            If sfdDanfe.ShowDialog = Windows.Forms.DialogResult.OK Then
                ExportSetup()
                ExportFormat()
                Dim RptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
                RptDoc = CType(CrystalReportViewer1.ReportSource, CrystalDecisions.CrystalReports.Engine.ReportDocument)
                RptDoc.Export(ExportOpts)
                MsgBox("Exportação completa.", MsgBoxStyle.Information, "Exportar Relatório")
                Destroy()


            End If
        Catch ex As Exception
            Destroy()
            MsgBox("Exportação falhou.", MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
End Class