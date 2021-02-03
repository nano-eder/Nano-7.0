Imports System
Imports System.IO
Imports System.IO.File
Imports System.IO.Compression
Imports Microsoft.Win32

Public Class frmVersoes
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
        Application.Run(New frmVersoes())
    End Sub
    Private Sub frmVersoes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()


    End Sub


    Private Sub Iniciar()
        Timer1.Stop()

        Try
            Dim intVal As Integer = 63
            pb1.Maximum = intVal * 10

            Dim wc As New System.Net.WebClient()
            If IO.Directory.Exists("C:\NANONFCe") = False Then
                IO.Directory.CreateDirectory("C:\NANONFCe")
            End If
            BarraProgresso()
            wc.Dispose()
            If IO.Directory.Exists("C:\NANONFCe\Schemas_4.00") = False Then
                IO.Directory.CreateDirectory("C:\NANONFCe\Schemas_4.00")
            End If
            BarraProgresso()
            If IO.Directory.Exists("C:\NANONFCe\WebServices") = False Then
                IO.Directory.CreateDirectory("C:\NANONFCe\WebServices")
            End If
            BarraProgresso()

            wc = New System.Net.WebClient()
            System.IO.File.Delete("C:\NANONFCe\WebServices\WebServices_4.00.xml.gz")
            wc.DownloadFile("https://sites.google.com/site/cotroles/nfe4/WebServices_4.00.xml.gz?attredirects=0&d=1", "C:\NANONFCe\WebServices\WebServices_4.00.xml.gz")
            BarraProgresso()
            wc.Dispose()
            System.IO.File.Delete("C:\NANONFCe\WebServices\WebServices_4.00.xml")
            descompactaArquivo("C:\NANONFCe\WebServices\WebServices_4.00.xml.gz", "C:\NANONFCe\WebServices\WebServices_4.00.xml")
            BarraProgresso()

            System.IO.File.Delete("C:\NANONFCe\WebServices\WebServices_4.00.xml.gz")
            BarraProgresso()

            wc = New System.Net.WebClient()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\consReciNFe_v4.00.xsd.gz")
            wc.DownloadFile("https://sites.google.com/site/cotroles/nfe4/consReciNFe_v4.00.xsd.gz?attredirects=0&d=1", "C:\NANONFCe\Schemas_4.00\consReciNFe_v4.00.xsd.gz")
            BarraProgresso()
            wc.Dispose()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\consReciNFe_v4.00.xsd")
            descompactaArquivo("C:\NANONFCe\Schemas_4.00\consReciNFe_v4.00.xsd.gz", "C:\NANONFCe\Schemas_4.00\consReciNFe_v4.00.xsd")
            BarraProgresso()

            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\consReciNFe_v4.00.xsd.gz")
            BarraProgresso()

            wc = New System.Net.WebClient()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\consSitNFe_v4.00.xsd.gz")
            wc.DownloadFile("https://sites.google.com/site/cotroles/nfe4/consSitNFe_v4.00.xsd.gz?attredirects=0&d=1", "C:\NANONFCe\Schemas_4.00\consSitNFe_v4.00.xsd.gz")
            BarraProgresso()
            wc.Dispose()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\consSitNFe_v4.00.xsd")
            descompactaArquivo("C:\NANONFCe\Schemas_4.00\consSitNFe_v4.00.xsd.gz", "C:\NANONFCe\Schemas_4.00\consSitNFe_v4.00.xsd")
            BarraProgresso()

            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\consSitNFe_v4.00.xsd.gz")
            BarraProgresso()

            wc = New System.Net.WebClient()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\consStatServ_v4.00.xsd.gz")
            wc.DownloadFile("https://sites.google.com/site/cotroles/nfe4/consStatServ_v4.00.xsd.gz?attredirects=0&d=1", "C:\NANONFCe\Schemas_4.00\consStatServ_v4.00.xsd.gz")
            BarraProgresso()
            wc.Dispose()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\consStatServ_v4.00.xsd")
            descompactaArquivo("C:\NANONFCe\Schemas_4.00\consStatServ_v4.00.xsd.gz", "C:\NANONFCe\Schemas_4.00\consStatServ_v4.00.xsd")
            BarraProgresso()

            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\consStatServ_v4.00.xsd.gz")
            BarraProgresso()

            wc = New System.Net.WebClient()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\enviNFe_v4.00.xsd.gz")
            wc.DownloadFile("https://sites.google.com/site/cotroles/nfe4/enviNFe_v4.00.xsd.gz?attredirects=0&d=1", "C:\NANONFCe\Schemas_4.00\enviNFe_v4.00.xsd.gz")
            BarraProgresso()
            wc.Dispose()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\enviNFe_v4.00.xsd")
            descompactaArquivo("C:\NANONFCe\Schemas_4.00\enviNFe_v4.00.xsd.gz", "C:\NANONFCe\Schemas_4.00\enviNFe_v4.00.xsd")
            BarraProgresso()

            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\enviNFe_v4.00.xsd.gz")
            BarraProgresso()

            wc = New System.Net.WebClient()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\inutNFe_v4.00.xsd.gz")
            wc.DownloadFile("https://sites.google.com/site/cotroles/nfe4/inutNFe_v4.00.xsd.gz?attredirects=0&d=1", "C:\NANONFCe\Schemas_4.00\inutNFe_v4.00.xsd.gz")
            BarraProgresso()
            wc.Dispose()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\inutNFe_v4.00.xsd")
            descompactaArquivo("C:\NANONFCe\Schemas_4.00\inutNFe_v4.00.xsd.gz", "C:\NANONFCe\Schemas_4.00\inutNFe_v4.00.xsd")
            BarraProgresso()

            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\inutNFe_v4.00.xsd.gz")
            BarraProgresso()

            wc = New System.Net.WebClient()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\leiauteConsSitNFe_v4.00.xsd.gz")
            wc.DownloadFile("https://sites.google.com/site/cotroles/nfe4/leiauteConsSitNFe_v4.00.xsd.gz?attredirects=0&d=1", "C:\NANONFCe\Schemas_4.00\leiauteConsSitNFe_v4.00.xsd.gz")
            BarraProgresso()
            wc.Dispose()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\leiauteConsSitNFe_v4.00.xsd")
            descompactaArquivo("C:\NANONFCe\Schemas_4.00\leiauteConsSitNFe_v4.00.xsd.gz", "C:\NANONFCe\Schemas_4.00\leiauteConsSitNFe_v4.00.xsd")
            BarraProgresso()

            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\leiauteConsSitNFe_v4.00.xsd.gz")
            BarraProgresso()

            wc = New System.Net.WebClient()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\leiauteConsStatServ_v4.00.xsd.gz")
            wc.DownloadFile("https://sites.google.com/site/cotroles/nfe4/leiauteConsStatServ_v4.00.xsd.gz?attredirects=0&d=1", "C:\NANONFCe\Schemas_4.00\leiauteConsStatServ_v4.00.xsd.gz")
            BarraProgresso()
            wc.Dispose()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\leiauteConsStatServ_v4.00.xsd")
            descompactaArquivo("C:\NANONFCe\Schemas_4.00\leiauteConsStatServ_v4.00.xsd.gz", "C:\NANONFCe\Schemas_4.00\leiauteConsStatServ_v4.00.xsd")
            BarraProgresso()

            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\leiauteConsStatServ_v4.00.xsd.gz")
            BarraProgresso()

            wc = New System.Net.WebClient()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\leiauteInutNFe_v4.00.xsd.gz")
            wc.DownloadFile("https://sites.google.com/site/cotroles/nfe4/leiauteInutNFe_v4.00.xsd.gz?attredirects=0&d=1", "C:\NANONFCe\Schemas_4.00\leiauteInutNFe_v4.00.xsd.gz")
            BarraProgresso()
            wc.Dispose()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\leiauteInutNFe_v4.00.xsd")
            descompactaArquivo("C:\NANONFCe\Schemas_4.00\leiauteInutNFe_v4.00.xsd.gz", "C:\NANONFCe\Schemas_4.00\leiauteInutNFe_v4.00.xsd")
            BarraProgresso()

            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\leiauteInutNFe_v4.00.xsd.gz")
            BarraProgresso()

            wc = New System.Net.WebClient()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\leiauteNFe_v4.00.xsd.gz")
            wc.DownloadFile("https://sites.google.com/site/cotroles/nfe4/leiauteNFe_v4.00.xsd.gz?attredirects=0&d=1", "C:\NANONFCe\Schemas_4.00\leiauteNFe_v4.00.xsd.gz")
            BarraProgresso()
            wc.Dispose()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\leiauteNFe_v4.00.xsd")
            descompactaArquivo("C:\NANONFCe\Schemas_4.00\leiauteNFe_v4.00.xsd.gz", "C:\NANONFCe\Schemas_4.00\leiauteNFe_v4.00.xsd")
            BarraProgresso()

            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\leiauteNFe_v4.00.xsd.gz")
            BarraProgresso()

            wc = New System.Net.WebClient()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\nfe_v4.00.xsd.gz")
            wc.DownloadFile("https://sites.google.com/site/cotroles/nfe4/nfe_v4.00.xsd.gz?attredirects=0&d=1", "C:\NANONFCe\Schemas_4.00\nfe_v4.00.xsd.gz")
            BarraProgresso()
            wc.Dispose()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\nfe_v4.00.xsd")
            descompactaArquivo("C:\NANONFCe\Schemas_4.00\nfe_v4.00.xsd.gz", "C:\NANONFCe\Schemas_4.00\nfe_v4.00.xsd")
            BarraProgresso()

            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\nfe_v4.00.xsd.gz")
            BarraProgresso()

            wc = New System.Net.WebClient()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\procInutNFe_v4.00.xsd.gz")
            wc.DownloadFile("https://sites.google.com/site/cotroles/nfe4/procInutNFe_v4.00.xsd.gz?attredirects=0&d=1", "C:\NANONFCe\Schemas_4.00\procInutNFe_v4.00.xsd.gz")
            BarraProgresso()
            wc.Dispose()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\procInutNFe_v4.00.xsd")
            descompactaArquivo("C:\NANONFCe\Schemas_4.00\procInutNFe_v4.00.xsd.gz", "C:\NANONFCe\Schemas_4.00\procInutNFe_v4.00.xsd")
            BarraProgresso()

            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\procInutNFe_v4.00.xsd.gz")
            BarraProgresso()

            wc = New System.Net.WebClient()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\procNFe_v4.00.xsd.gz")
            wc.DownloadFile("https://sites.google.com/site/cotroles/nfe4/procNFe_v4.00.xsd.gz?attredirects=0&d=1", "C:\NANONFCe\Schemas_4.00\procNFe_v4.00.xsd.gz")
            BarraProgresso()
            wc.Dispose()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\procNFe_v4.00.xsd")
            descompactaArquivo("C:\NANONFCe\Schemas_4.00\procNFe_v4.00.xsd.gz", "C:\NANONFCe\Schemas_4.00\procNFe_v4.00.xsd")
            BarraProgresso()

            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\procNFe_v4.00.xsd.gz")
            BarraProgresso()

            wc = New System.Net.WebClient()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\retConsReciNFe_v4.00.xsd.gz")
            wc.DownloadFile("https://sites.google.com/site/cotroles/nfe4/retConsReciNFe_v4.00.xsd.gz?attredirects=0&d=1", "C:\NANONFCe\Schemas_4.00\retConsReciNFe_v4.00.xsd.gz")
            BarraProgresso()
            wc.Dispose()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\retConsReciNFe_v4.00.xsd")
            descompactaArquivo("C:\NANONFCe\Schemas_4.00\retConsReciNFe_v4.00.xsd.gz", "C:\NANONFCe\Schemas_4.00\retConsReciNFe_v4.00.xsd")
            BarraProgresso()

            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\retConsReciNFe_v4.00.xsd.gz")
            BarraProgresso()

            wc = New System.Net.WebClient()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\retConsSitNFe_v4.00.xsd.gz")
            wc.DownloadFile("https://sites.google.com/site/cotroles/nfe4/retConsSitNFe_v4.00.xsd.gz?attredirects=0&d=1", "C:\NANONFCe\Schemas_4.00\retConsSitNFe_v4.00.xsd.gz")
            BarraProgresso()
            wc.Dispose()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\retConsSitNFe_v4.00.xsd")
            descompactaArquivo("C:\NANONFCe\Schemas_4.00\retConsSitNFe_v4.00.xsd.gz", "C:\NANONFCe\Schemas_4.00\retConsSitNFe_v4.00.xsd")
            BarraProgresso()

            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\retConsSitNFe_v4.00.xsd.gz")
            BarraProgresso()

            wc = New System.Net.WebClient()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\retConsStatServ_v4.00.xsd.gz")
            wc.DownloadFile("https://sites.google.com/site/cotroles/nfe4/retConsStatServ_v4.00.xsd.gz?attredirects=0&d=1", "C:\NANONFCe\Schemas_4.00\retConsStatServ_v4.00.xsd.gz")
            BarraProgresso()
            wc.Dispose()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\retConsStatServ_v4.00.xsd")
            descompactaArquivo("C:\NANONFCe\Schemas_4.00\retConsStatServ_v4.00.xsd.gz", "C:\NANONFCe\Schemas_4.00\retConsStatServ_v4.00.xsd")
            BarraProgresso()

            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\retConsStatServ_v4.00.xsd.gz")
            BarraProgresso()

            wc = New System.Net.WebClient()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\retEnviNFe_v4.00.xsd.gz")
            wc.DownloadFile("https://sites.google.com/site/cotroles/nfe4/retEnviNFe_v4.00.xsd.gz?attredirects=0&d=1", "C:\NANONFCe\Schemas_4.00\retEnviNFe_v4.00.xsd.gz")
            BarraProgresso()
            wc.Dispose()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\retEnviNFe_v4.00.xsd")
            descompactaArquivo("C:\NANONFCe\Schemas_4.00\retEnviNFe_v4.00.xsd.gz", "C:\NANONFCe\Schemas_4.00\retEnviNFe_v4.00.xsd")
            BarraProgresso()

            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\retEnviNFe_v4.00.xsd.gz")
            BarraProgresso()

            wc = New System.Net.WebClient()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\retInutNFe_v4.00.xsd.gz")
            wc.DownloadFile("https://sites.google.com/site/cotroles/nfe4/retInutNFe_v4.00.xsd.gz?attredirects=0&d=1", "C:\NANONFCe\Schemas_4.00\retInutNFe_v4.00.xsd.gz")
            BarraProgresso()
            wc.Dispose()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\retInutNFe_v4.00.xsd")
            descompactaArquivo("C:\NANONFCe\Schemas_4.00\retInutNFe_v4.00.xsd.gz", "C:\NANONFCe\Schemas_4.00\retInutNFe_v4.00.xsd")
            BarraProgresso()

            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\retInutNFe_v4.00.xsd.gz")
            BarraProgresso()

            wc = New System.Net.WebClient()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\tiposBasico_v4.00.xsd.gz")
            wc.DownloadFile("https://sites.google.com/site/cotroles/nfe4/tiposBasico_v4.00.xsd.gz?attredirects=0&d=1", "C:\NANONFCe\Schemas_4.00\tiposBasico_v4.00.xsd.gz")
            BarraProgresso()
            wc.Dispose()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\tiposBasico_v4.00.xsd")
            descompactaArquivo("C:\NANONFCe\Schemas_4.00\tiposBasico_v4.00.xsd.gz", "C:\NANONFCe\Schemas_4.00\tiposBasico_v4.00.xsd")
            BarraProgresso()

            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\tiposBasico_v4.00.xsd.gz")
            BarraProgresso()

            wc = New System.Net.WebClient()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\xmldsig-core-schema_v1.01.xsd.gz")
            wc.DownloadFile("https://sites.google.com/site/cotroles/nfe4/xmldsig-core-schema_v1.01.xsd.gz?attredirects=0&d=1", "C:\NANONFCe\Schemas_4.00\xmldsig-core-schema_v1.01.xsd.gz")
            BarraProgresso()
            wc.Dispose()
            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\xmldsig-core-schema_v1.01.xsd")
            descompactaArquivo("C:\NANONFCe\Schemas_4.00\xmldsig-core-schema_v1.01.xsd.gz", "C:\NANONFCe\Schemas_4.00\xmldsig-core-schema_v1.01.xsd")
            BarraProgresso()

            System.IO.File.Delete("C:\NANONFCe\Schemas_4.00\xmldsig-core-schema_v1.01.xsd.gz")
            BarraProgresso()




            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Entre em contato com a Era Systems!", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub BarraProgresso()
        If pb1.Value < 650 Then
            pb1.Value = pb1.Value + 10
        End If
        Select Case Me.lblAtualizando.Text
            Case "Atualizando..."
                Me.lblAtualizando.Text = "Atualizando"
            Case "Atualizando"
                Me.lblAtualizando.Text = "Atualizando."
            Case "Atualizando."
                Me.lblAtualizando.Text = "Atualizando.."
            Case "Atualizando.."
                Me.lblAtualizando.Text = "Atualizando..."
        End Select
        Application.DoEvents()
        System.Threading.Thread.Sleep(40)
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

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Iniciar()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        SimpleButton1_Click(sender, e)
        Timer1.Stop()
    End Sub
End Class