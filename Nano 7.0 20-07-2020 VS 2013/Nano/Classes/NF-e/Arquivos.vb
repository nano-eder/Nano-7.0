Imports System.IO
Module Arquivos
    '### Necessário para utilizar algumas classes envolvidas
    Dim DirDiretorio As DirectoryInfo
    Dim oFileInfoCollection() As FileInfo
    Dim oFileInfo As FileInfo
    Dim i As Integer
    Function VerArqDiretorio(ByVal Diretorio As String, ByVal Extensao As String) As Long
        DirDiretorio = New DirectoryInfo(Diretorio)
        oFileInfoCollection = DirDiretorio.GetFiles(Extensao)
        VerArqDiretorio = oFileInfoCollection.Length()
    End Function
    Function SalvarArquivo(ByVal Conteudo As String, ByVal Arquivo As String, Optional CaminhoPadrao As Boolean = False) As Boolean
        Try
            Dim fluxoTexto As IO.StreamWriter
            If CaminhoPadrao = True Then
                Arquivo = Application.StartupPath & "\" & Arquivo
            End If
            If Arquivo = Nothing Then
                SalvarArquivo = False
                MessageBox.Show("Arquivo Invalido", "Salvar Como", MessageBoxButtons.OK)
            Else
                If IO.File.Exists(Arquivo) Then
                    fluxoTexto = New IO.StreamWriter(Arquivo)
                    fluxoTexto.WriteLine(Conteudo)
                Else
                    fluxoTexto = New IO.StreamWriter(Arquivo)
                    fluxoTexto.Write(Conteudo)
                End If
                SalvarArquivo = True
                fluxoTexto.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            '  MessageBox.Show(ex.Message, TitleMSG, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Function AbrirArquivoData(ByVal Arquivo As String) As Date
        Try
            Dim fluxoTexto As IO.StreamReader
            Arquivo = Application.StartupPath & "\" & Arquivo
            If Arquivo = Nothing Then
                AbrirArquivoData = DateAdd(DateInterval.Day, -1, AbrirArquivoData)
            Else
                If IO.File.Exists(Arquivo) = True Then
                    fluxoTexto = File.OpenText(Arquivo)
                    AbrirArquivoData = fluxoTexto.ReadLine
                    fluxoTexto.Close()
                Else
                    AbrirArquivoData = DateAdd(DateInterval.Day, -1, Now.Date)
                End If
            End If
        Catch ex As Exception

        End Try
    End Function
    Function AbrirArquivo(ByVal Arquivo As String) As String
        Try
            Dim Texto As IO.StreamReader
            Arquivo = Application.StartupPath & "\" & Arquivo
            If Arquivo = Nothing Then
                AbrirArquivo = ""
            Else
                If IO.File.Exists(Arquivo) = True Then
                    Texto = File.OpenText(Arquivo)
                    AbrirArquivo = Texto.ReadLine
                    Texto.Close()
                Else
                    'MessageBox.Show("Arquivo Não Existente! Favor Verificar!", TitleMSG, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception

        End Try
        Return ""
    End Function
End Module
