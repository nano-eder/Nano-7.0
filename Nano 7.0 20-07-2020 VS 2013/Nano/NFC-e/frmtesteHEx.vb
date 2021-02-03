Imports System.IO
' And System.Security.Cryptography for Hashes : MD5, SHA1, SHA256, ...
Imports System.Security
Imports System.Security.Cryptography


Imports System.IO.Compression
Imports System.text
Imports Nano.clsFuncoes

Imports Microsoft.Win32
Imports System.Diagnostics
Public Class frmtesteHEx

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        'Dim password As String
        'Dim passwordSHA As String

        'Call passwordEncryptSHA(Me.TextEdit1.Text) ' Lets call the first password encryption function for SHA1

        'passwordSHA = passwordEncryptSHA(Me.TextEdit1.Text) ' give the variable the returned SHA value

        '' finally we will display both values in the corresponding textboxes
        'Me.TextEdit2.Text = passwordSHA




        MsgBox(Me.TextEdit1.Text.Substring(0, 2) & " " & Me.TextEdit1.Text.Substring(6, 14), MsgBoxStyle.Information)
    End Sub
    Public Function passwordEncryptSHA(ByVal password As String) As String
        Dim sha As New SHA1CryptoServiceProvider ' declare sha as a new SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte ' and here is a byte variable

        bytesToHash = System.Text.Encoding.ASCII.GetBytes(password) ' covert the password into ASCII code

        bytesToHash = sha.ComputeHash(bytesToHash) ' this is where the magic starts and the encryption begins

        Dim encPassword As String = ""

        For Each b As Byte In bytesToHash
            encPassword += b.ToString("x2")
        Next

        Return encPassword ' boom there goes the encrypted password!

    End Function

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        'C:\NANONFCe\Homologação\Autorizadas\35170514566555000100650010000000021000000059-procNfe.xml
        'ImpressoraNFCe = "TERMICA MARGEM"
        ''PortaImpressoraNFCe = "EPSON"


        'Dim SR As StreamReader
        'Dim vXMLString As String
        'SR = File.OpenText("C:\NANONFCe\Homologação\Autorizadas\35170514566555000100650010000000021000000059-procNfe.xml")
        'vXMLString = SR.ReadToEnd()

        'Try



        '    SR.Close()
        '    GerarNFCe.GerarCupomNFCe("C:\NANONFCe\Homologação\Autorizadas\35170514566555000100650010000000021000000059-procNfe.xml", False)

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information)
        'End Try
        'GerarNFCe.GerarInutilizacao("C:\NANONFCe\Homologação\Autorizadas\Inut\35171456655500010065001000000022000000022-procInut.xml")
        ''GerarNFCe.GerarEvento("C:\NANONFCe\Homologação\Autorizadas\Cancelamento\1101113517061456655500010065001000000020100000023901-procEven.xml")
        ''C:\NANONFCe\Homologação\Autorizadas\Inut\35171456655500010065001000000022000000022-procInut.xml
        ''C:\NANONFCe\Homologação\Autorizadas\Cancelamento\1101113517061456655500010065001000000020100000023901-procEven.xml'

        UnRar("C:\TESTE", "C:\TESTE\NANONFCe.rar")
    End Sub
    Dim streamFonte As FileStream
    Dim streamDestino As FileStream
    Dim streamCompactado As GZipStream
    Dim streamDescompactado As GZipStream
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
End Class