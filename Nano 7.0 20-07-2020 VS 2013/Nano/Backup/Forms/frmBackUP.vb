Imports System.io
Imports System.IO.Compression
Imports System.text
Imports Nano.clsFuncoes

Public Class frmBackUP
    Dim streamFonte As FileStream
    Dim streamDestino As FileStream
    Dim streamCompactado As GZipStream
    Dim streamDescompactado As GZipStream
    Private Sub txtLocal_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtLocal.ButtonClick
        If Not Me.Tag = "DESCOMPACTAR" Then
            Me.sfdSalvar.FileName = "Backup " & Date.Now.Day & "-" & Date.Now.Month & "-" & Date.Now.Year
            Me.sfdSalvar.ShowDialog()
            Me.txtLocal.Text = Me.sfdSalvar.FileName

        Else
            Me.ofd.ShowDialog()
            Me.txtLocal.Text = Me.ofd.FileName

        End If
    End Sub


    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If Me.txtLocal.Text.Trim = "" Then MsgBox("Informe o " & Me.lbl.Text & "!", MsgBoxStyle.Information) : Me.txtLocal.Focus() : Exit Sub

        Try
            Dim strDestino As String = Me.txtLocal.Text.Trim & ".bak"
            BackupSql("backup database " & NomeDoBancoSql & " to disk = '" & strDestino & "'", True)

            strDestino = Me.txtLocal.Text.Trim & "_MASTER.BAK"
            BackupSql("backup database master to disk = '" & strDestino & "'", True)

            strDestino = Me.txtLocal.Text.Trim & "_MSDB.BAK"
            BackupSql("backup database msdb to disk = '" & strDestino & "'", True)

            MsgBox("Backup realizado com sucesso!", MsgBoxStyle.Information)

            Me.txtLocal.ResetText()
            Me.Close()
        Catch ex As Exception
            ' MsgBox("O programa não pode localizar o arquivo de origem!", MsgBoxStyle.Information)

        End Try

    End Sub


    Public Sub compactaArquivo(ByVal arquivoOrigem As String, ByVal arquivoDestino As String)
        Try
            ' ----- Descompacta a string compactada previamente.
            '       primeiro , cria a enetra do arquivo stream
            streamFonte = New FileStream(arquivoOrigem, FileMode.Open, FileAccess.Read)

            ' ----- Cria a saida do arquivo stream
            streamDestino = New FileStream(arquivoDestino, FileMode.Create, FileAccess.Write)

            ' ----- Os bytes serão processados por um compressor de streams
            streamCompactado = New GZipStream(streamDestino, CompressionMode.Compress, True)

            ' ----- Processa os bytes de um arquivo para outro
            Const tamanhoBloco As Integer = 4096
            Dim buffer(tamanhoBloco) As Byte
            Dim bytesLidos As Integer
            Do
                bytesLidos = streamFonte.Read(buffer, 0, tamanhoBloco)
                If (bytesLidos = 0) Then Exit Do
                streamCompactado.Write(buffer, 0, bytesLidos)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ' ----- Fecha todos os streams
            streamFonte.Close()
            streamCompactado.Close()
            streamDestino.Close()
        End Try
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

    Private Sub frmBackUP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "63")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmBackUP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Tag = "DESCOMPACTAR" Then
            Me.Text = "Restauração de Backup"
            Me.lbl.Text = "Local de origem do Backup"
            Me.btnOK.Visible = False
        Else
            Me.btnOK2.Visible = False
        End If
    End Sub

    Private Sub btnOK2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK2.Click

        If TesteConexao() = False Then Exit Sub

        If Me.txtLocal.Text.Trim = "" Then MsgBox("Informe o " & Me.lbl.Text & "!", MsgBoxStyle.Information) : Me.txtLocal.Focus() : Exit Sub

        If MsgBox("Esse procedimento só deve ser efetuado caso tenha ocorrido algum erro com a sua base de dados, deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim strOrigem As String
            Try

                strOrigem = Me.txtLocal.Text.Trim

                Dim strBackup As String = "ALTER DATABASE " & NomeDoBancoSql & " SET SINGLE_USER WITH ROLLBACK IMMEDIATE " & vbCrLf & _
                "RESTORE DATABASE " & NomeDoBancoSql & " FROM  DISK = N'" & strOrigem & "' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10 " & vbCrLf & _
                "ALTER DATABASE " & NomeDoBancoSql & " SET MULTI_USER WITH ROLLBACK IMMEDIATE"

                BackupSql(strBackup, False)


                MsgBox("Backup restaurado com sucesso!", MsgBoxStyle.Information)
                MsgBox("Feche o sistema e abra-o novamente para conclusão do backup!", MsgBoxStyle.Information)



                Me.txtLocal.ResetText()
                Me.Close()
            Catch ex As Exception
                ' MsgBox("O programa não pode localizar o arquivo de origem!", MsgBoxStyle.Information)

            End Try
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class