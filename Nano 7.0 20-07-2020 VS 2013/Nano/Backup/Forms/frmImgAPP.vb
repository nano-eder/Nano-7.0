Imports Nano.clsFuncoes
Imports System.Drawing
Imports System.Data
Imports System.IO
Imports System.Math

Public Class frmImgAPP

    Private Sub frmImgAPP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarImagem()
    End Sub

    Private Sub picTop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picTop.Click
        Me.OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            Me.picTop.Image = System.Drawing.Bitmap.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub picBottom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picBottom.Click
        Me.OpenFileDialog2.FileName = ""
        OpenFileDialog2.ShowDialog()
        If OpenFileDialog2.FileName <> "" Then
            Me.picBottom.Image = System.Drawing.Bitmap.FromFile(OpenFileDialog2.FileName)
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        If Me.picTop.Image Is Nothing = False Then
            Dim imagem As Byte() = converteimagem(Me.picTop.Image)
            InserirImagem("UPDATE Config SET Imagem1 = @Img WHERE Codigo=" & CodConfig, imagem)

        End If
        If Me.picBottom.Image Is Nothing = False Then
            Dim imagem As Byte() = converteimagem(Me.picBottom.Image)
            InserirImagem("UPDATE Config SET Imagem2 = @Img WHERE Codigo=" & CodConfig, imagem)
        End If

        Me.Close()
    End Sub

    Public Function converteimagem(ByVal Imagem As System.Drawing.Image) As Byte()
        Dim ms As New System.IO.MemoryStream()
        Imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return ms.ToArray()
    End Function

    Private Sub CarregarImagem()
        Dim dt As DataTable = CarregarDataTable("SELECT Imagem1, Imagem2 FROM Config WHERE Codigo=" & CodConfig & ";")

        If dt.Rows.Count > 0 Then

            If dt.Rows.Item(0).Item("Imagem1").ToString <> "" Then
                Dim Imagem As Byte() = CType(dt.Rows.Item(0).Item("Imagem1"), Byte())
                Dim memorybits As New MemoryStream(Imagem)
                Dim bitmap As New Bitmap(memorybits)

                Me.picTop.Image = bitmap
            Else
                Me.picTop.Image = Nothing
            End If

            If dt.Rows.Item(0).Item("Imagem2").ToString <> "" Then
                Dim Imagem As Byte() = CType(dt.Rows.Item(0).Item("Imagem2"), Byte())
                Dim memorybits As New MemoryStream(Imagem)
                Dim bitmap As New Bitmap(memorybits)

                Me.picBottom.Image = bitmap
            Else
                Me.picBottom.Image = Nothing
            End If

        End If
    End Sub
End Class