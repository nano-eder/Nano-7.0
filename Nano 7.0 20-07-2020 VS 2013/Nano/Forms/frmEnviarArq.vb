Imports System.IO
Imports System.IO.File

Imports System.IO.Packaging


Imports Nano.clsNfeXml
Imports Nano.clsFuncoes
Public Class frmEnviarArq

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim index As Integer = -999997
        grd1.FocusedRowHandle = index
        grd1.FocusedColumn = Me.colNum
        grd1.ShowEditor()
        Try
            If Not IO.File.Exists("C:\NANO\EMail\Aquivo.zip") = False Then
                Kill("C:\NANO\EMail\Aquivo.zip")
            End If

        Catch ex As Exception
            MsgBox("Não foi possível gerar um novo arquivo de email, feche o sistema e tente novamente!" & vbCrLf & "Se a mensagem persistir entre no C:\NANO\Email e exclua todos os arquivos.", MsgBoxStyle.Information)
            Me.Close()
            Exit Sub
        End Try
        Dim I As Integer
        Dim bolOk As Boolean = False
        Dim zip As Package = Nothing
        For I = 0 To Me.grd1.RowCount - 1
            If Me.grd1.GetRowCellValue(I, Me.colOk) = True Then

                If bolOk = False Then
                    Dim zipPath As String = "C:\NANO\EMail\Aquivo.zip"

                    'Abre o arquivo zip, se ele existe, senão cria um novo 
                    zip = ZipPackage.Open(zipPath, IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite)

                End If
                bolOk = True

                AddToArchive(zip, Me.grd1.GetRowCellDisplayText(I, Me.colXml))
                If Me.Tag = "CLIENTE" Then


                    AddToArchive(zip, Me.grd1.GetRowCellDisplayText(I, Me.colPdf))
                End If
            End If
        Next

        If bolOk = True Then
            zip.Close()
            frmEmail.Tag = "NFE"
        End If

        Me.Close()

    End Sub
 
    Private Sub AddToArchive(ByVal zip As Package, ByVal fileToAdd As String)

        'Substitui os espaços por underscore (_) 
        Dim uriFileName As String = fileToAdd.Replace(" ", "_")

        'A Uri sempre começa com uma barra "/"  
        Dim zipUri As String = String.Concat("/", _
                   IO.Path.GetFileName(uriFileName))

        Dim partUri As New Uri(zipUri, UriKind.Relative)
        Dim contentType As String = _
                   Net.Mime.MediaTypeNames.Application.Zip

        'O PackagePart contém as informações:
        ' Sempre extrair o arquivo quando ele é extraído (partUri) 
        ' O tipo do conteúdo do fluxo (MIME type) - (contentType) 
        ' O tipo de compressão usado (CompressionOption.Normal)   
        Dim pkgPart As PackagePart = zip.CreatePart(partUri, _
                   contentType, CompressionOption.Normal)

        'Leia todos os bytes do arquivo para adiciona-lo ao arquivo zip 
        Dim bites As Byte() = File.ReadAllBytes(fileToAdd)

        'Comprimir e escrever os byte no arquivo zip 
        pkgPart.GetStream().Write(bites, 0, bites.Length)


    End Sub
End Class