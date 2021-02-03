Imports System
Imports System.IO
Imports System.IO.File
Imports System.IO.Compression
Imports Microsoft.Win32

Public Class frmInstalarSat
    Dim strNomeArq, strOrigem, strDestino As String
    Dim intPos, intMax As Integer
    Dim intCont As Integer
    Dim streamFonte As FileStream
    Dim streamDestino As FileStream
    Dim streamCompactado As GZipStream
    Dim streamDescompactado As GZipStream
    Dim bolOK As Boolean = False
    Dim bolErro As Boolean = False
    Public Shared Sub Main()
        Application.Run(New frmInstalarSat())
    End Sub
    Private Sub frmInstalarSat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Tag = "NFCe" Then
            Me.Text = "NFC-e"
            Me.LabelControl1.Visible = False
            Me.cboSat.Visible = False
        End If
    End Sub
    Private Sub BarraProgresso()
        If pb1.Value < 650 Then
            pb1.Value = pb1.Value + 10
        End If

        Application.DoEvents()
        System.Threading.Thread.Sleep(40)
    End Sub
    Private Sub btnIniciar_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnIniciar.ItemClick

        If MsgBox("Tem certeza que deseja iniciar a instalação?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Dim intVal As Integer = 23
                If Me.Tag = "NFCe" Then
                    intVal = 10
                End If
                Select Case Me.cboImpressora.Text
                    Case "DARUMA"
                        intVal += 22
                    Case "BEMATECH"
                        intVal += 3
                    Case "EPSON"
                        intVal += 3

                End Select
                Select Case Me.cboSat.Text
                    Case "ELGIN 2"
                        intVal += 20
                End Select
                Select Case Me.cboSat.Text
                    Case "EPSON"
                        intVal += 20
                End Select
                pb1.Maximum = intVal * 10

                Dim wc As New System.Net.WebClient()


                If Me.Tag = "SAT" Then
                    If IO.Directory.Exists("C:\SAT") = False Then
                        IO.Directory.CreateDirectory("C:\SAT")
                    End If
                    BarraProgresso()
                    If IO.Directory.Exists("C:\SAT\Autorizadas") = False Then
                        IO.Directory.CreateDirectory("C:\SAT\Autorizadas")
                    End If
                    BarraProgresso()
                    If IO.Directory.Exists("C:\SAT\Autorizadas\Cancelamento") = False Then
                        IO.Directory.CreateDirectory("C:\SAT\Autorizadas\Cancelamento")
                    End If
                    BarraProgresso()
                    If IO.Directory.Exists("C:\SAT\Backup") = False Then
                        IO.Directory.CreateDirectory("C:\SAT\Backup")
                    End If
                    BarraProgresso()
                    If IO.Directory.Exists("C:\SAT\Backup\Cancelamento") = False Then
                        IO.Directory.CreateDirectory("C:\SAT\Backup\Cancelamento")
                    End If
                    BarraProgresso()
                    If IO.Directory.Exists("C:\SAT\Notas") = False Then
                        IO.Directory.CreateDirectory("C:\SAT\Notas")
                    End If
                    BarraProgresso()
                    If IO.Directory.Exists("C:\SAT\Notas\Cancelamento") = False Then
                        IO.Directory.CreateDirectory("C:\SAT\Notas\Cancelamento")
                    End If
                    BarraProgresso()
                    If IO.Directory.Exists("C:\SAT\Remessas") = False Then
                        IO.Directory.CreateDirectory("C:\SAT\Remessas")
                    End If
                    BarraProgresso()


                    Select Case Me.cboSat.Text
                        Case "BEMATECH"

                            wc = New System.Net.WebClient()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\bemasat.xml.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/bemasat.xml.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\bemasat.xml.gz")
                            BarraProgresso()
                            wc = New System.Net.WebClient()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\BemaSAT32.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/BemaSAT32.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\BemaSAT32.dll.gz")
                            BarraProgresso()
                            wc = New System.Net.WebClient()
                            System.IO.File.Delete("C:\SAT\bematech_vcom.cat.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/bematech_vcom.cat.gz?attredirects=0&d=1", "C:\SAT\bematech_vcom.cat.gz")
                            BarraProgresso()
                            wc = New System.Net.WebClient()
                            System.IO.File.Delete("C:\SAT\bematech_vcom.inf.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/bematech_vcom.inf.gz?attredirects=0&d=1", "C:\SAT\bematech_vcom.inf.gz")
                            BarraProgresso()

                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\bemasat.xml")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\bemasat.xml.gz", My.Application.Info.DirectoryPath & "\bemasat.xml")
                            BarraProgresso()

                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\BemaSAT32.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\BemaSAT32.dll.gz", My.Application.Info.DirectoryPath & "\BemaSAT32.dll")
                            BarraProgresso()


                            System.IO.File.Delete("C:\SAT\bematech_vcom.cat")
                            descompactaArquivo("C:\SAT\bematech_vcom.cat.gz", "C:\SAT\bematech_vcom.cat")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\bematech_vcom.inf")
                            descompactaArquivo("C:\SAT\bematech_vcom.inf.gz", "C:\SAT\bematech_vcom.inf")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\bemasat.xml.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\BemaSAT32.dll.gz")
                            BarraProgresso()

                            System.IO.File.Delete("C:\SAT\bematech_vcom.cat.gz")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\bematech_vcom.inf.gz")
                            BarraProgresso()
                        Case "DIMEP"
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\discoverySAT.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/discoverySAT.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\discoverySAT.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\dllsat.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/dllsat.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\dllsat.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\zlib.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/zlib.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\zlib.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\linux-cdc-acm.inf.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/linux-cdc-acm.inf.gz?attredirects=0&d=1", "C:\SAT\linux-cdc-acm.inf.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\discoverySAT.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\discoverySAT.dll.gz", My.Application.Info.DirectoryPath & "\discoverySAT.dll")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\dllsat.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\dllsat.dll.gz", My.Application.Info.DirectoryPath & "\dllsat.dll")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\zlib.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\zlib.dll.gz", My.Application.Info.DirectoryPath & "\zlib.dll")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\linux-cdc-acm.inf")
                            descompactaArquivo("C:\SAT\linux-cdc-acm.inf.gz", "C:\SAT\linux-cdc-acm.inf")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\discoverySAT.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\dllsat.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\zlib.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\linux-cdc-acm.inf.gz")
                            BarraProgresso()
                        Case "GERTEC"
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\discoverySAT.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/discoverySAT.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\discoverySAT.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\dllsatgertec.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/dllsatgertec.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\dllsatgertec.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\zlib.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/zlib.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\zlib.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\linux-cdc-acm.inf.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/gertec_usb_cdc.inf.gz?attredirects=0&d=1", "C:\SAT\gertec_usb_cdc.inf.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\discoverySAT.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\discoverySAT.dll.gz", My.Application.Info.DirectoryPath & "\discoverySAT.dll")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\dllsatgertec.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\dllsatgertec.dll.gz", My.Application.Info.DirectoryPath & "\dllsatgertec.dll")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\zlib.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\zlib.dll.gz", My.Application.Info.DirectoryPath & "\zlib.dll")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\gertec_usb_cdc.inf")
                            descompactaArquivo("C:\SAT\gertec_usb_cdc.inf.gz", "C:\SAT\gertec_usb_cdc.inf")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\discoverySAT.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\dllsatgertec.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\zlib.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\gertec_usb_cdc.inf.gz")
                            BarraProgresso()
                        Case "EPSON"
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\discoverySAT.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/discoverySAT.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\discoverySAT.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\dllsatepson.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/dllsatepson.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\dllsatepson.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\zlib.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/zlib.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\zlib.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\SatEpson.inf.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/SatEpson.inf.gz?attredirects=0&d=1", "C:\SAT\SatEpson.inf.gz")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\SatEpson.cat.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/SatEpson.cat.gz?attredirects=0&d=1", "C:\SAT\SatEpson.cat.gz")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\usbser.sys.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/usbser.sys.gz?attredirects=0&d=1", "C:\SAT\usbser.sys.gz")
                            BarraProgresso()

                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\discoverySAT.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\discoverySAT.dll.gz", My.Application.Info.DirectoryPath & "\discoverySAT.dll")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\dllsatepson.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\dllsatepson.dll.gz", My.Application.Info.DirectoryPath & "\dllsatepson.dll")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\zlib.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\zlib.dll.gz", My.Application.Info.DirectoryPath & "\zlib.dll")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\SatEpson.inf")
                            descompactaArquivo("C:\SAT\SatEpson.inf.gz", "C:\SAT\SatEpson.inf")
                            BarraProgresso()

                            System.IO.File.Delete("C:\SAT\SatEpson.cat")
                            descompactaArquivo("C:\SAT\SatEpson.cat.gz", "C:\SAT\SatEpson.cat")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\usbser.sys")
                            descompactaArquivo("C:\SAT\usbser.sys.gz", "C:\SAT\usbser.sys")
                            BarraProgresso()

                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\discoverySAT.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\dllsatepson.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\zlib.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\SatEpson.inf.gz")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\SatEpson.cat.gz")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\usbser.sys.gz")
                            BarraProgresso()
                        Case "EASYS"
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\dllsateasys.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/dllsateasys.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\dllsateasys.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\InstaladorEasys01-00-04.exe.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/InstaladorEasys01-00-04.exe.gz?attredirects=0&d=1", "C:\SAT\InstaladorEasys01-00-04.exe.gz")
                            BarraProgresso()
              
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\dllsateasys.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\dllsateasys.dll.gz", My.Application.Info.DirectoryPath & "\dllsateasys.dll")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\InstaladorEasys01-00-04.exe")
                            descompactaArquivo("C:\SAT\InstaladorEasys01-00-04.exe.gz", "C:\SAT\InstaladorEasys01-00-04.exe")
                            BarraProgresso()
                          
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\dllsateasys.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\InstaladorEasys01-00-04.exe.gz")
                            BarraProgresso()
                        Case "ELGIN"
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\discoverySAT.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/discoverySAT.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\discoverySAT.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\dllsatelgin.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/dllsatelgin.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\dllsatelgin.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\zlib.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/zlib.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\zlib.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\linux-cdc-acm.inf.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/linux-cdc-acm.inf.gz?attredirects=0&d=1", "C:\SAT\linux-cdc-acm.inf.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\discoverySAT.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\discoverySAT.dll.gz", My.Application.Info.DirectoryPath & "\discoverySAT.dll")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\dllsatelgin.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\dllsatelgin.dll.gz", My.Application.Info.DirectoryPath & "\dllsatelgin.dll")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\zlib.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\zlib.dll.gz", My.Application.Info.DirectoryPath & "\zlib.dll")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\linux-cdc-acm.inf")
                            descompactaArquivo("C:\SAT\linux-cdc-acm.inf.gz", "C:\SAT\linux-cdc-acm.inf")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\discoverySAT.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\dllsatelgin.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\zlib.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\linux-cdc-acm.inf.gz")
                            BarraProgresso()
                        Case "ELGIN 2"
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\dllsatelgin.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/elgin2/dllsatelgin.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\dllsatelgin.dll.gz")
                            BarraProgresso()

                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\Qt5Core.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/elgin2/Qt5Core.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\Qt5Core.dll.gz")
                            BarraProgresso()

                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\Qt5Network.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/elgin2/Qt5Network.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\Qt5Network.dll.gz")
                            BarraProgresso()


                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\libgcc_s_dw2-1.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/elgin2/libgcc_s_dw2-1.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\libgcc_s_dw2-1.dll.gz")
                            BarraProgresso()


                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\libstdc6.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/elgin2/libstdc6.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\libstdc6.dll.gz")
                            BarraProgresso()

                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\libwinpthread-1.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/elgin2/libwinpthread-1.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\libwinpthread-1.dll.gz")
                            BarraProgresso()


                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\discoverySAT.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/discoverySAT.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\discoverySAT.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\zlib.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/zlib.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\zlib.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\linux-cdc-acm.inf.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/linux-cdc-acm.inf.gz?attredirects=0&d=1", "C:\SAT\linux-cdc-acm.inf.gz")
                            BarraProgresso()


                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\Qt5Core.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\Qt5Core.dll.gz", My.Application.Info.DirectoryPath & "\Qt5Core.dll")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\Qt5Network.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\Qt5Network.dll.gz", My.Application.Info.DirectoryPath & "\Qt5Network.dll")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\libgcc_s_dw2-1.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\libgcc_s_dw2-1.dll.gz", My.Application.Info.DirectoryPath & "\libgcc_s_dw2-1.dll")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\libstdc++-6.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\libstdc6.dll.gz", My.Application.Info.DirectoryPath & "\libstdc++-6.dll")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\libwinpthread-1.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\libwinpthread-1.dll.gz", My.Application.Info.DirectoryPath & "\libwinpthread-1.dll")
                            BarraProgresso()

                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\discoverySAT.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\discoverySAT.dll.gz", My.Application.Info.DirectoryPath & "\discoverySAT.dll")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\dllsatelgin.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\dllsatelgin.dll.gz", My.Application.Info.DirectoryPath & "\dllsatelgin.dll")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\zlib.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\zlib.dll.gz", My.Application.Info.DirectoryPath & "\zlib.dll")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\linux-cdc-acm.inf")
                            descompactaArquivo("C:\SAT\linux-cdc-acm.inf.gz", "C:\SAT\linux-cdc-acm.inf")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\discoverySAT.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\dllsatelgin.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\zlib.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\Qt5Core.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\Qt5Network.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\libgcc_s_dw2-1.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\libstdc6.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\libwinpthread-1.dll.gz")
                            BarraProgresso()

                            System.IO.File.Delete("C:\SAT\linux-cdc-acm.inf.gz")
                            BarraProgresso()
                        Case "TANCA"
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\discoverySAT.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/discoverySAT.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\discoverySAT.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\dllsattanca.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/dllsattanca.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\dllsattanca.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\zlib.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/zlib.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\zlib.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\TANCA_SAT.INF.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/TANCA_SAT.INF.gz?attredirects=0&d=1", "C:\SAT\TANCA_SAT.INF.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\discoverySAT.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\discoverySAT.dll.gz", My.Application.Info.DirectoryPath & "\discoverySAT.dll")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\dllsattanca.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\dllsattanca.dll.gz", My.Application.Info.DirectoryPath & "\dllsattanca.dll")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\zlib.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\zlib.dll.gz", My.Application.Info.DirectoryPath & "\zlib.dll")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\TANCA_SAT.INF")
                            descompactaArquivo("C:\SAT\TANCA_SAT.INF.gz", "C:\SAT\TANCA_SAT.INF")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\discoverySAT.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\dllsat.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\zlib.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\TANCA_SAT.INF.gz")
                            BarraProgresso()


                        Case "SWEDA"
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\dllsatsweda.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/sweda/dllsatsweda.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\dllsatsweda.dll.gz")
                            BarraProgresso()

                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\iconv.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/sweda/iconv.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\iconv.dll.gz")
                            BarraProgresso()

                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\libxml2.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/sweda/libxml2.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\libxml2.dll.gz")
                            BarraProgresso()


                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\msvcp100.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/sweda/msvcp100.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\msvcp100.dll.gz")
                            BarraProgresso()


                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\msvcr100.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/sweda/msvcr100.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\msvcr100.dll.gz")
                            BarraProgresso()

                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\zlib1.dll.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/sweda/zlib1.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\zlib1.dll.gz")
                            BarraProgresso()

                            System.IO.File.Delete("C:\SAT\satsweda.cat.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/sweda/satsweda.cat.gz?attredirects=0&d=1", "C:\SAT\satsweda.cat.gz")
                            BarraProgresso()

                            System.IO.File.Delete("C:\SAT\satsweda.inf.gz")
                            wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/sweda/satsweda.inf.gz?attredirects=0&d=1", "C:\SAT\satsweda.inf.gz")
                            BarraProgresso()

                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\dllsatsweda.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\dllsatsweda.dll.gz", My.Application.Info.DirectoryPath & "\dllsatsweda.dll")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\iconv.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\iconv.dll.gz", My.Application.Info.DirectoryPath & "\iconv.dll")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\libxml2.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\libxml2.dll.gz", My.Application.Info.DirectoryPath & "\libxml2.dll")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\msvcp100.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\msvcp100.dll.gz", My.Application.Info.DirectoryPath & "\msvcp100.dll")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\msvcr100.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\msvcr100.dll.gz", My.Application.Info.DirectoryPath & "\msvcr100.dll")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\zlib1.dll")
                            descompactaArquivo(My.Application.Info.DirectoryPath & "\zlib1.dll.gz", My.Application.Info.DirectoryPath & "\zlib1.dll")
                            BarraProgresso()

                            System.IO.File.Delete("C:\SAT\satsweda.cat")
                            descompactaArquivo("C:\SAT\satsweda.cat.gz", "C:\SAT\satsweda.cat")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\satsweda.inf")
                            descompactaArquivo("C:\SAT\satsweda.inf.gz", "C:\SAT\satsweda.inf")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\dllsatsweda.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\iconv.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\libxml2.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\msvcp100.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\msvcr100.dll.gz")
                            BarraProgresso()
                            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\zlib1.dll.gz")
                            BarraProgresso()

                            System.IO.File.Delete("C:\SAT\satsweda.cat.gz")
                            BarraProgresso()
                            System.IO.File.Delete("C:\SAT\satsweda.inf.gz")
                            BarraProgresso()
                    End Select
                Else


                    If IO.Directory.Exists("C:\NANONFCe") = False Then
                        wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos/NANONFCe.rar?attredirects=0&d=1", "C:\NANONFCe.rar")
                        UnRar("C:\", "C:\NANONFCe.rar")
                        Contador15Segundos()
                        BarraProgresso()

                    End If
                End If


                wc = New System.Net.WebClient()
                System.IO.File.Delete(My.Application.Info.DirectoryPath & "\MessagingToolkit.QRCode.dll.gz")
                wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/MessagingToolkit.QRCode.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\MessagingToolkit.QRCode.dll.gz")
                BarraProgresso()

                System.IO.File.Delete(My.Application.Info.DirectoryPath & "\MessagingToolkit.QRCode.dll")
                descompactaArquivo(My.Application.Info.DirectoryPath & "\MessagingToolkit.QRCode.dll.gz", My.Application.Info.DirectoryPath & "\MessagingToolkit.QRCode.dll")
                BarraProgresso()

                System.IO.File.Delete(My.Application.Info.DirectoryPath & "\MessagingToolkit.QRCode.dll.gz")
                BarraProgresso()



                Select Case Me.cboImpressora.Text
                    Case "BEMATECH"
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\mp2032.dll.gz")
                        wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/mp2032.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\mp2032.dll.gz")
                        BarraProgresso()
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\mp2032.dll")
                        descompactaArquivo(My.Application.Info.DirectoryPath & "\mp2032.dll.gz", My.Application.Info.DirectoryPath & "\mp2032.dll")
                        BarraProgresso()
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\mp2032.dll.gz")
                        BarraProgresso()
                    Case "DARUMA"
                        wc = New System.Net.WebClient()
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\DarumaFrameWork.dll.gz")
                        wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/DarumaFrameWork.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\DarumaFrameWork.dll.gz")
                        BarraProgresso()
                        wc = New System.Net.WebClient()
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\GNE_Framework.dll.gz")
                        wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/GNE_Framework.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\GNE_Framework.dll.gz")
                        BarraProgresso()
                        wc = New System.Net.WebClient()
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\hwinterface.sys.gz")
                        wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/hwinterface.sys.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\hwinterface.sys.gz")
                        BarraProgresso()
                        wc = New System.Net.WebClient()
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\lebin.dll.gz")
                        wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/lebin.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\lebin.dll.gz")
                        BarraProgresso()
                        wc = New System.Net.WebClient()
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\LeituraMFDBin.dll.gz")
                        wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/LeituraMFDBin.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\LeituraMFDBin.dll.gz")
                        BarraProgresso()
                        wc = New System.Net.WebClient()
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\QrCode_DarumaFramework.dll.gz")
                        wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/QrCode_DarumaFramework.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\QrCode_DarumaFramework.dll.gz")
                        BarraProgresso()
                        wc = New System.Net.WebClient()
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\WS_Framework.dll.gz")
                        wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/WS_Framework.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\WS_Framework.dll.gz")
                        BarraProgresso()

                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\DarumaFrameWork.dll")
                        descompactaArquivo(My.Application.Info.DirectoryPath & "\DarumaFrameWork.dll.gz", My.Application.Info.DirectoryPath & "\DarumaFrameWork.dll")
                        BarraProgresso()
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\GNE_Framework.dll")
                        descompactaArquivo(My.Application.Info.DirectoryPath & "\GNE_Framework.dll.gz", My.Application.Info.DirectoryPath & "\GNE_Framework.dll")
                        BarraProgresso()
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\hwinterface.sys")
                        descompactaArquivo(My.Application.Info.DirectoryPath & "\hwinterface.sys.gz", My.Application.Info.DirectoryPath & "\hwinterface.sys")
                        BarraProgresso()
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\lebin.dll")
                        descompactaArquivo(My.Application.Info.DirectoryPath & "\lebin.dll.gz", My.Application.Info.DirectoryPath & "\lebin.dll")
                        BarraProgresso()
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\LeituraMFDBin.dll")
                        descompactaArquivo(My.Application.Info.DirectoryPath & "\LeituraMFDBin.dll.gz", My.Application.Info.DirectoryPath & "\LeituraMFDBin.dll")
                        BarraProgresso()
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\QrCode_DarumaFramework.dll")
                        descompactaArquivo(My.Application.Info.DirectoryPath & "\QrCode_DarumaFramework.dll.gz", My.Application.Info.DirectoryPath & "\QrCode_DarumaFramework.dll")
                        BarraProgresso()
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\WS_Framework.dll")
                        descompactaArquivo(My.Application.Info.DirectoryPath & "\WS_Framework.dll.gz", My.Application.Info.DirectoryPath & "\WS_Framework.dll")
                        BarraProgresso()
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\DarumaFrameWork.dll.gz")
                        BarraProgresso()
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\GNE_Framework.dll.gz")
                        BarraProgresso()
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\hwinterface.sys.gz")
                        BarraProgresso()
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\lebin.dll.gz")
                        BarraProgresso()
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\LeituraMFDBin.dll.gz")
                        BarraProgresso()
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\QrCode_DarumaFramework.dll.gz")
                        BarraProgresso()
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\WS_Framework.dll.gz")
                        BarraProgresso()
                    Case "EPSON"
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\InterfaceEpsonNF.dll.gz")
                        wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos-1/InterfaceEpsonNF.dll.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\InterfaceEpsonNF.dll.gz")
                        BarraProgresso()
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\InterfaceEpsonNF.dll")
                        descompactaArquivo(My.Application.Info.DirectoryPath & "\InterfaceEpsonNF.dll.gz", My.Application.Info.DirectoryPath & "\InterfaceEpsonNF.dll")
                        BarraProgresso()
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\InterfaceEpsonNF.dll.gz")
                        BarraProgresso()
                End Select

                frmAtualizarTabelas.Tag = "Cidade-Cfop-Pais-TabelaIBPT"
                frmAtualizarTabelas.ShowDialog()


                MsgBox("Instalação finalizada com sucesso!", MsgBoxStyle.Information)

                System.IO.File.Delete("C:\NANONFCe.rar")

                Me.Close()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        End If


    End Sub
    Private Sub Contador15Segundos()
        Dim intSegundo As Integer = Second(Now)
        Dim intContador As Integer = 0
        While intContador <= 5
            If intSegundo <> Second(Now) Then
                intSegundo = Second(Now)
                intContador += 1
            End If
        End While
    End Sub
    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Public Sub descompactaArquivo(ByVal arquivoOrigem As String, ByVal arquivoDestino As String)
        ' ----- Compacata o contéudo do arquivo e
        '       guarda o resultado em um novo arquivo
        Try
            streamFonte = New FileStream(arquivoOrigem, FileMode.Open, FileAccess.Read)
            streamDestino = New FileStream(arquivoDestino, FileMode.Create, FileAccess.Write)

            ' ----- Os bytes serão processados através de um decompressor de stream
            streamDescompactado = New GZipStream(streamFonte, CompressionMode.Decompress, True)

            ' ----- Processa os bytes de um arquivo para outro
            Const tamanhoBloco As Integer = 4096
            Dim buffer(tamanhoBloco) As Byte
            Dim bytesLidos As Integer
            Do
                bytesLidos = streamDescompactado.Read(buffer, 0, tamanhoBloco)
                If (bytesLidos = 0) Then Exit Do
                streamDestino.Write(buffer, 0, bytesLidos)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ' ----- Fecha todos os arquivos
            streamFonte.Close()
            streamDescompactado.Close()
            streamDestino.Close()
        End Try
    End Sub

   
   
    Private Sub btnExcel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcel.ItemClick
        frmAtualizarTabelas.Tag = "Cidade-Cfop-Pais-TabelaIBPT"
        frmAtualizarTabelas.ShowDialog()
    End Sub



    Private Sub UnRar(ByVal destino As String, ByVal caminhoOrigem As String)

        ' Microsoft.Win32 and System.Diagnostics namespaces are imported

        Dim objRegKey As Microsoft.Win32.RegistryKey
        objRegKey = Registry.ClassesRoot.OpenSubKey("WinRAR\Shell\Open\Command")
        ' Windows 7 Registry entry for WinRAR Open Command

        Dim obj As Object = objRegKey.GetValue("")

        Dim objRarPath As String = obj.ToString()
        objRarPath = objRarPath.Substring(1, objRarPath.Length - 7)

        objRegKey.Close()

        Dim objArguments As String
        ' in the following format
        ' " X G:\Downloads\samplefile.rar G:\Downloads\sampleextractfolder\"
        objArguments = " X " & " " & caminhoOrigem & " " + " " + destino

        Dim objStartInfo As New ProcessStartInfo()
        ' Set the UseShellExecute property of StartInfo object to FALSE
        ' Otherwise the we can get the following error message
        ' The Process object must have the UseShellExecute property set to false in order to use environment variables.
        objStartInfo.UseShellExecute = False
        objStartInfo.FileName = objRarPath
        objStartInfo.Arguments = objArguments
        objStartInfo.WindowStyle = ProcessWindowStyle.Hidden
        objStartInfo.WorkingDirectory = destino & "\"

        Dim objProcess As New Process()
        objProcess.StartInfo = objStartInfo
        objProcess.Start()
    End Sub
  
End Class