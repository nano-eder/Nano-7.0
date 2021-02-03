Imports Nano.clsFuncoes
Public Class frmEmailAssinatura

    Dim strCaminhoImagem As String

    Private Sub frmEmailAssinatura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strCaminho As String = ""

        If IO.File.Exists("C:\NANO\AssinaturaEmail.png") = True Then
            strCaminho = "C:\NANO\AssinaturaEmail.png"
        Else

            If IO.File.Exists("C:\NANO\AssinaturaEmail.jpg") = True Then
                strCaminho = "C:\NANO\AssinaturaEmail.jpg"
            Else

                If IO.File.Exists("C:\NANO\AssinaturaEmail.jpeg") = True Then
                    strCaminho = "C:\NANO\AssinaturaEmail.jpeg"
                End If

            End If

        End If

        If strCaminho <> "" Then

            Dim fs As IO.FileStream = New IO.FileStream(strCaminho, IO.FileMode.Open, IO.FileAccess.Read)
            Dim br As IO.BinaryReader = New IO.BinaryReader(fs)

            Dim memorybits As New IO.MemoryStream(br.ReadBytes(CType(fs.Length, Integer)))

            Dim bitmap As New Bitmap(memorybits)
            Me.picImagem.Image = bitmap
            strCaminhoImagem = strCaminho

            br.Close()
            fs.Close()
            fs.Dispose()
        End If
    End Sub

    Private Sub picImagem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picImagem.Click
        ofdLogo.FileName = ""
        ofdLogo.ShowDialog()

        If ofdLogo.FileName <> "" Then

            Dim fs As IO.FileStream = New IO.FileStream(ofdLogo.FileName, IO.FileMode.Open, IO.FileAccess.Read)
            Dim br As IO.BinaryReader = New IO.BinaryReader(fs)

            Dim memorybits As New IO.MemoryStream(br.ReadBytes(CType(fs.Length, Integer)))

            Dim bitmap As New Bitmap(memorybits)
            Me.picImagem.Image = bitmap
            strCaminhoImagem = ofdLogo.FileName

            br.Close()
            fs.Close()
            fs.Dispose()


        End If
    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick

     
        If strCaminhoImagem <> "" And strCaminhoImagem <> "C:\NANO\AssinaturaEmail.png" And strCaminhoImagem <> "C:\NANO\AssinaturaEmail.jpg" And strCaminhoImagem <> "C:\NANO\AssinaturaEmail.jpeg" Then

            If IO.File.Exists("C:\NANO\AssinaturaEmail.png") = True Then
                IO.File.Delete("C:\NANO\AssinaturaEmail.png")
            Else
                If IO.File.Exists("C:\NANO\AssinaturaEmail.jpg") = True Then
                    IO.File.Delete("C:\NANO\AssinaturaEmail.jpg")
                Else
                    If IO.File.Exists("C:\NANO\AssinaturaEmail.jpeg") = True Then
                        IO.File.Delete("C:\NANO\AssinaturaEmail.jpeg")
                    End If
                End If
            End If

            If strCaminhoImagem.Contains(".png") = True Then
                IO.File.Copy(strCaminhoImagem, "C:\NANO\AssinaturaEmail.png")
            Else
                If strCaminhoImagem.Contains(".jpg") = True Then
                    IO.File.Copy(strCaminhoImagem, "C:\NANO\AssinaturaEmail.jpg")
                Else
                    If strCaminhoImagem.Contains(".jpeg") = True Then
                        IO.File.Copy(strCaminhoImagem, "C:\NANO\AssinaturaEmail.jpeg")
                    End If
                End If
            End If
        Else
            If IO.File.Exists("C:\NANO\AssinaturaEmail.png") = True Then
                IO.File.Delete("C:\NANO\AssinaturaEmail.png")
            Else
                If IO.File.Exists("C:\NANO\AssinaturaEmail.jpg") = True Then
                    IO.File.Delete("C:\NANO\AssinaturaEmail.jpg")
                Else
                    If IO.File.Exists("C:\NANO\AssinaturaEmail.jpeg") = True Then
                        IO.File.Delete("C:\NANO\AssinaturaEmail.jpeg")
                    End If
                End If
            End If
        End If

        MsgBox("Dados salvo com sucesso!", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        Me.picImagem.Image = Nothing
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub
End Class