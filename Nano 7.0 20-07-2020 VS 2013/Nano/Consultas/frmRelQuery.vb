Imports Nano.clsFuncoes
Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.IO
Imports System.IO.File

Imports System.Data
Imports System.Data.sql
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Text
Imports System.Configuration
Imports System.Configuration.ConfigurationSettings
Imports System.Collections.Specialized
Imports System.Diagnostics
Imports System.Configuration.ConfigurationManager
Imports System.Drawing.Printing
Imports System.Data.OleDb
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Net.mail
Imports System.Net.Mime
Imports System.Threading
Imports Nano.clsFuncoesBematech
Imports Nano.clsImprimir
Imports System.IO.Compression

Imports System.Security
Imports System.Security.Cryptography
Public Class frmRelQuery
    Private Sub LimparGrid()
        Dim A As Integer
        For A = 0 To Me.grd1.Columns.Count - 1
            Me.grd1.Columns.RemoveAt(0)
        Next
        For A = 0 To Me.grd1.RowCount - 1
            Me.grd1.DeleteRow(0)
        Next
    End Sub
    Private Sub btnSql_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSql.Click
        Executa()
    End Sub

    Private Sub Executa()

        LimparGrid()

        Dim strQuery As String = Me.rtbQuery.SelectedText

        If strQuery <> "" Then
            Dim vetTexto As Array = Split(strQuery, ";")
            Dim I As Integer
            For I = 0 To vetTexto.Length - 1
                If vetTexto(I).ToString.Trim <> "" Then
                    If strQuery.ToUpper.Contains("SELECT") Then
                        LimparGrid()
                        CarregarDadosPesquisa(vetTexto(I).Replace(";", ""), Me.GridControl1, True)
                    Else
                        BackupSql(vetTexto(I).Replace(";", ""), True)
                    End If
                End If

            Next

        Else
            Dim vetTexto As Array = Split(Me.rtbQuery.Text, ";")
            Dim I As Integer
            For I = 0 To vetTexto.Length - 1
                If vetTexto(I).ToString.Trim <> "" Then
                    If vetTexto(I).ToString.ToUpper.Contains("SELECT") Then
                        LimparGrid()
                        CarregarDadosPesquisa(vetTexto(I).ToString.Trim, Me.GridControl1, True)
                    Else
                        BackupSql(vetTexto(I).ToString.Trim, True)
                    End If
                End If

            Next
        End If

        Me.lblReg.Text = Me.grd1.RowCount

    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        Me.rtbQuery.ResetText()
        Me.cboTabela1.EditValue = ""
        LimparGrid()
        Me.rtbQuery.Focus()
    End Sub
    Private Sub SetPalavra()
        Dim strPalavra As String = CapturaUltimaPalavra(Me.rtbQuery.Text)
        strPalavra = strPalavra.Replace(";", "|").Replace(",", "|").Replace("(", "|").Replace("&", "|")
        Dim vetPalavra As Array = Split(strPalavra, "|")
        Dim I As Integer
        For I = 0 To vetPalavra.Length - 1
            strPalavra = vetPalavra(I).ToString.Trim
            If strPalavra.ToUpper = "SELECT" Or strPalavra.ToUpper = "FROM" Or strPalavra.ToUpper = "WHERE" Or strPalavra.ToUpper = "UPDATE" Or strPalavra.ToUpper = "SET" Or strPalavra.ToUpper = "INSERT" Or strPalavra.ToUpper = "INTO" Or strPalavra.ToUpper = "DELETE" Or strPalavra.ToUpper = "DISTINCT" Or strPalavra.ToUpper = "ORDER" Or strPalavra.ToUpper = "GROUP" Or strPalavra.ToUpper = "BY" Or strPalavra.ToUpper = "INNER" Or strPalavra.ToUpper = "LEFT" Or strPalavra.ToUpper = "JOIN" Or strPalavra.ToUpper = "ON" Or strPalavra.ToUpper = "CONVERT" Or strPalavra.ToUpper = "NUMERIC(15,2)" Or strPalavra.ToUpper = "NUMERIC" Or strPalavra.ToUpper = "AS" Then
                CorDoTexto(rtbQuery, strPalavra, Color.Blue, 1)
            End If
        Next
    End Sub
    Private Sub rtbQuery_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rtbQuery.KeyDown
        If e.KeyCode = Keys.Enter Then
            SetPalavra()
        End If
    End Sub

    Private Sub rtbQuery_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtbQuery.KeyPress
        If Char.IsSeparator(e.KeyChar) = True Then
            SetPalavra()
        End If

        If Me.rtbQuery.Text.Trim = "" Then
            Me.rtbQuery.Clear()
        End If
    End Sub
    Function CorDoTexto(ByVal my_rtb As RichTextBox, ByVal txt As String, ByVal mycor As System.Drawing.Color, ByVal init As Integer)
        Dim cursor_pos = my_rtb.SelectionStart
        Dim cursor_pos2 = my_rtb.SelectionLength
        Dim find_pos = 0
        Dim casos = 0
        Dim str_exists = InStr(init, my_rtb.Text, txt)

        If str_exists <> 0 Then

            With my_rtb
                If Not my_rtb.SelectedText = txt Then
                    '.SelectionFont = New Font("Verdana", 8, FontStyle.Regular)
                    '.SelectionColor = mycor
                    .SelectionStart = str_exists - 1
                    .SelectionLength = Len(txt)
                    .SelectionColor = mycor
                    '.SelectionFont = New Font("Verdana", 8, FontStyle.Regular)
                    '.SelectionColor = Color.Black
                    .SelectionStart = cursor_pos
                    .SelectionLength = cursor_pos2
                    .SelectionColor = Color.Black
                Else
                    .SelectionStart = cursor_pos
                    .SelectionLength = cursor_pos2
                    .SelectionColor = Color.Black
                End If
            End With

            init = str_exists + Len(txt)
            CorDoTexto = 1 + CorDoTexto(my_rtb, txt, mycor, init)
        End If
        cursor_pos = my_rtb.SelectionStart
        Return Nothing
    End Function
    Function CapturaUltimaPalavra(ByVal expr As String)
        'Esta função retira a última palavra de uma expressão
        Dim Temp As String
        Dim i As Integer, P As Integer
        Temp = Trim(expr)
        P = 1
        For i = Len(Temp) To 1 Step -1
            If (Mid(Temp, i, 1)) = " " Then
                P = i + 1
                Exit For
            End If
        Next i
        If P = 1 Then
            CapturaUltimaPalavra = Temp
        Else
            CapturaUltimaPalavra = Mid(Temp, P)
        End If
    End Function

    Private Sub frmPesquisaSql_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            Executa()
        End If
    End Sub

    Private Sub frmPesquisaSql_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim dt As DataTable = CarregarDataTable("SELECT Table_Name from information_schema.tables order by Table_Name")
        'If dt.Rows.Count > 0 Then
        '    Dim I As Integer
        '    Me.cboTabela.Properties.Items.Clear()
        '    Me.cboTabela.Properties.Items.Add("")
        '    For I = 0 To dt.Rows.Count - 1
        '        Me.cboTabela.Properties.Items.Add(dt.Rows.Item(I).ItemArray(0))
        '    Next
        'End If

        CarregarQuery()

        If Login = "ADM" And Senha = "SPFC" Then
            Me.btnSalvarQuery.Enabled = True
            Me.rtbQuery.ReadOnly = False
        Else
            Me.GroupControl1.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnAcres_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAcres.ItemClick
        Dim data1, data2 As String
        data1 = dtInicial.EditValue
        data2 = dtFinal.EditValue
        'If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Sub
        'If data2 = "" Then MsgBox("Selecione a Data Final!", MsgBoxStyle.Information) : Exit Sub
        Dim dataFim, dataIni As Date
        Me.rtbQuery.ResetText()

        If data1 <> "" Then
            dataIni = data1
        End If
        If data2 <> "" Then
            dataFim = data2
        End If
        If data1 <> "" And data2 <> "" Then
            If dataIni > dataFim Then MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information) : Exit Sub
        End If


      
        Dim strTabela As String = Me.cboTabela1.EditValue
        Select Case strTabela
            Case ""
            Case Else


                If IO.File.Exists(My.Application.Info.DirectoryPath & "\Relatórios\" & strTabela & ".txt") = True Then

                    Dim strQuery As String = LerArquivo(My.Application.Info.DirectoryPath & "\Relatórios\" & strTabela & ".txt", True)

                    strQuery = strQuery.Replace("DATAINICIALRELATORIO", dataIni).Replace("DATAFINALRELATORIO", dataFim)

                    'strQuery = strQuery.Replace("> ='", ">='").Replace(">= '", ">='").Replace("> = '", ">='")
                    'strQuery = strQuery.Replace("< ='", "<='").Replace("<= '", "<='").Replace("< = '", "<='")

                    'Dim strRelatorio As String = strQuery

                    'If strQuery.Contains(">='") = True Then
                    '    If data1 <> "" Then
                    '        Dim vetArray As Array = Split(strQuery, ">='")
                    '        strRelatorio = vetArray(0) & ">='" & dataIni & "'"

                    '        If strQuery.Contains("<='") = True Then
                    '            If data2 <> "" Then
                    '                Dim vetArray2 As Array = Split(vetArray(1), "<='")
                    '                strRelatorio &= vetArray2(0).ToString.Substring(11, vetArray2(0).ToString.Length - 11)

                    '                strRelatorio &= "<='" & dataFim & "'" & vetArray2(1).ToString.Substring(11, vetArray2(1).ToString.Length - 11)
                    '            End If

                    '        Else
                    '            If vetArray(1).ToString.Length > 10 Then
                    '                strRelatorio &= vetArray(1).ToString.Substring(11, vetArray(1).ToString.Length - 11)
                    '            End If
                    '        End If
                    '    Else
                    '        MsgBox("Informe a Data Inicial!", MsgBoxStyle.Information)
                    '        exit Sub 
                    '    End If

                    'Else
                    '    If data1 <> "" Then
                    '        If strQuery.Contains("<='") = True Then
                    '            Dim vetArray As Array = Split(strQuery, "<='")
                    '            strRelatorio = vetArray(0) & "<='" & dataIni & "'"

                    '            If vetArray(1).ToString.Length > 10 Then
                    '                strRelatorio &= vetArray(1).ToString.Substring(11, vetArray(1).ToString.Length - 11)
                    '            End If
                    '        End If
                    '    End If


                    'End If

                    Me.rtbQuery.AppendText(strQuery & ";" & vbCrLf)
                End If

                Dim strPalavra As String = "SELECT|*|FROM"
                Dim vet As Array = Split(strPalavra, "|")
                Dim I As Integer
                For I = 0 To vet.Length - 1
                    If vet(I) <> "" And vet(I) <> "*" Then
                        CorDoTexto(rtbQuery, vet(I), Color.Blue, 1)
                    End If
                Next
                strPalavra = "select|*|from"
                vet = Split(strPalavra, "|")
                For I = 0 To vet.Length - 1
                    If vet(I) <> "" And vet(I) <> "*" Then
                        CorDoTexto(rtbQuery, vet(I), Color.Blue, 1)
                    End If
                Next

                Executa()
                ConfigurarGridQuery(Me.grd1, Me.cboTabela1.EditValue, True, Me.btnPadrao)

        End Select
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.cboTabela1.EditValue = ""
        Me.rtbQuery.ResetText()
        Me.rtbQuery.Focus()
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        'Me.GridControl1.ShowPrintPreview()

        Dim data1, data2 As String
        data1 = dtInicial.EditValue
        data2 = dtFinal.EditValue

        Dim dataFim, dataIni As Date
        Me.rtbQuery.ResetText()

        If data1 <> "" Then
            dataIni = data1
        End If
        If data2 <> "" Then
            dataFim = data2
        End If

        If data1 <> "" And data2 <> "" Then
            ShowPrint(Me.GridControl1, Me.cboTabela1.EditValue & vbCrLf & dtInicial.EditValue & " a " & Me.dtFinal.EditValue)
        Else
            ShowPrint(Me.GridControl1, Me.cboTabela1.EditValue)
        End If

    End Sub

    Private Sub CarregarQuery()
        Me.cboTabela.Items.Clear()
        Me.cboTabela.Items.Add("")
        Dim boloo As Boolean = False

        Dim vetLista As Array = Directory.GetFiles(My.Application.Info.DirectoryPath & "\Relatórios\", "*.txt")

        Dim I As Integer
        For I = 0 To vetLista.Length - 1
            Dim strNumNf As String = vetLista(I)

            strNumNf = strNumNf.Replace(My.Application.Info.DirectoryPath & "\Relatórios\", "").Replace(".txt", "")
            Me.cboTabela.Items.Add(strNumNf)

        Next
    End Sub
    Private Sub btnSalvarQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarQuery.Click
        If Me.rtbQuery.Text = "" Then MsgBox("T-SQL não esta preenchido!", MsgBoxStyle.Information) : Exit Sub

        Dim strTabela As String = InputBox("Digite o nome do Relatório.", "Relatórios")
        If strTabela = "" Then Exit Sub
        Dim vetLista As Array = Directory.GetFiles(My.Application.Info.DirectoryPath & "\Relatórios\", "*.txt")

        Dim I As Integer
        For I = 0 To vetLista.Length - 1
            Dim strNumNf As String = vetLista(I)

            strNumNf = strNumNf.Replace(My.Application.Info.DirectoryPath & "\Relatórios\", "").Replace(".txt", "")
            If strTabela = strNumNf Then
                MsgBox("Já existe uma query com o mesmo nome.", MsgBoxStyle.Information)
                Exit Sub
            End If

        Next

        Dim fluxoTexto As IO.StreamWriter
        If Not System.IO.File.Exists(My.Application.Info.DirectoryPath & "\Relatórios\" & strTabela & ".txt") Then
            System.IO.File.Create(My.Application.Info.DirectoryPath & "\Relatórios\" & strTabela & ".txt").Dispose()

            fluxoTexto = New IO.StreamWriter(My.Application.Info.DirectoryPath & "\Relatórios\" & strTabela & ".txt")
            fluxoTexto.Write("")
            fluxoTexto.Write(Me.rtbQuery.Text)
            fluxoTexto.Close()
        End If

        CarregarQuery()

        MsgBox("Arquivo gerado com sucesso!", MsgBoxStyle.Information)

    End Sub


    Private Shared Sub ConfigurarGridQuery(ByVal parGrid As DevExpress.XtraGrid.Views.Grid.GridView, _
   ByVal parForm As String, ByVal parCarregar As Boolean, ByVal parPadrao As DevExpress.XtraEditors.SimpleButton)

        Dim I As Integer

        If parCarregar = True Then

            If IO.File.Exists(My.Application.Info.DirectoryPath & "\Relatórios\Forms\" & parForm & ".txt") = True Then
                Dim strCadProduto As String = LerArquivo(My.Application.Info.DirectoryPath & "\Relatórios\Forms\" & parForm & ".txt", False)

                If strCadProduto <> "" Then
                    parPadrao.Enabled = True
                Else
                    parPadrao.Enabled = False
                End If

                Dim vetCadProduto As Array = Split(strCadProduto, "|")

                Dim A As Integer = 0


                Dim vetColuna2(100) As String

                Dim B As Integer = 0
                Dim C As Integer = 0
                For I = 0 To vetCadProduto.Length - 1

                    Dim strColuna As String = vetCadProduto(I)
                    Dim vetColuna As Array = Split(vetCadProduto(I), ",")

                    Try

                        If vetColuna.Length > 1 Then
                            If vetColuna(1).ToString <> "" Then
                                Dim bolVisivel As Boolean = vetColuna(1)
                                parGrid.Columns(vetColuna(0)).Visible = vetColuna(1)

                                If bolVisivel = True Then
                                    C += 1
                                    If vetColuna.Length > 2 Then
                                        If vetColuna(2).ToString <> "" Then
                                            Dim intCol As Integer = vetColuna(2)
                                            vetColuna2(intCol) = strColuna
                                        End If
                                    End If
                                    If vetColuna.Length > 3 Then
                                        If vetColuna(3).ToString <> "" Then
                                        End If
                                    End If
                                    If vetColuna.Length > 4 Then
                                        If vetColuna(4).ToString <> "" Then
                                        End If
                                    End If
                                End If

                                If vetColuna.Length > 7 Then
                                    Dim strNome As String = vetColuna(5).ToString
                                    Dim dblSize As Single = vetColuna(6).ToString.Replace(".", ",")
                                    Dim strStyle As String = vetColuna(7).ToString

                                    Dim fs As FontStyle = FontStyle.Regular
                                    Select Case strStyle
                                        Case "Bold"
                                            fs = FontStyle.Bold
                                        Case "Italic"
                                            fs = FontStyle.Italic
                                        Case "Regular"
                                            fs = FontStyle.Regular
                                        Case "Strikeout"
                                            fs = FontStyle.Strikeout
                                        Case "Underline"
                                            fs = FontStyle.Underline
                                        Case "Bold, Italic"
                                            fs = FontStyle.Bold Or FontStyle.Italic
                                    End Select

                                    parGrid.Columns.Item(vetColuna(0)).AppearanceCell.Font = New Font(strNome, dblSize, fs)
                                    parGrid.Columns.Item(vetColuna(0)).AppearanceHeader.Font = New Font(strNome, dblSize, fs)

                                End If

                            End If

                        End If

                        A += 1
                    Catch ex As Exception

                    End Try

                Next
                C -= 1
                For I = 0 To vetColuna2.Length - 1
                    If C < I Then Exit For
                    If vetColuna2(C - I) = Nothing Then Exit For
                    Dim strColuna As String = vetColuna2(C - I)
                    Dim vetColuna As Array = Split(vetColuna2(C - I), ",")

                    Try

                        If vetColuna.Length > 1 Then
                            If vetColuna(1).ToString <> "" Then
                                Dim bolVisivel As Boolean = vetColuna(1)
                                parGrid.Columns(vetColuna(0)).Visible = vetColuna(1)

                                If bolVisivel = True Then
                                    If vetColuna.Length > 2 Then
                                        If vetColuna(2).ToString <> "" Then
                                            parGrid.Columns(vetColuna(0)).VisibleIndex = 0
                                            parGrid.Columns(vetColuna(0)).Visible = vetColuna(1)

                                        End If
                                    End If
                                    If vetColuna.Length > 3 Then
                                        If vetColuna(3).ToString <> "" Then
                                            parGrid.Columns(vetColuna(0)).SortOrder = vetColuna(3)
                                        End If
                                    End If
                                    If vetColuna.Length > 4 Then
                                        If vetColuna(4).ToString <> "" Then
                                            parGrid.Columns(vetColuna(0)).Width = vetColuna(4)
                                        End If
                                    End If
                                End If
                                If vetColuna.Length > 7 Then
                                    Dim strNome As String = vetColuna(5).ToString
                                    Dim dblSize As Single = vetColuna(6).ToString.Replace(".", ",")
                                    Dim strStyle As String = vetColuna(7).ToString

                                    Dim fs As FontStyle = FontStyle.Regular
                                    Select Case strStyle
                                        Case "Bold"
                                            fs = FontStyle.Bold
                                        Case "Italic"
                                            fs = FontStyle.Italic
                                        Case "Regular"
                                            fs = FontStyle.Regular
                                        Case "Strikeout"
                                            fs = FontStyle.Strikeout
                                        Case "Underline"
                                            fs = FontStyle.Underline
                                        Case "Bold, Italic"
                                            fs = FontStyle.Bold Or FontStyle.Italic
                                    End Select

                                    parGrid.Columns.Item(vetColuna(0)).AppearanceCell.Font = New Font(strNome, dblSize, fs)
                                    parGrid.Columns.Item(vetColuna(0)).AppearanceHeader.Font = New Font(strNome, dblSize, fs)

                                End If
                            End If

                        End If

                        A += 1
                    Catch ex As Exception

                    End Try


                Next

            End If

        Else
            Dim strAjuste As String = ""
            For I = 0 To parGrid.Columns.Count - 1
                Dim strName As String = parGrid.Columns.Item(I).FieldName
                Dim strShort As String = parGrid.Columns.Item(I).SortOrder
                Dim strIndesx As Integer = parGrid.Columns.Item(I).VisibleIndex
                Dim strTamanho As String = parGrid.Columns.Item(I).Width
                Dim bolVisivel As Boolean = parGrid.Columns.Item(I).Visible

                Dim strStyleFonte As String = parGrid.Columns.Item(I).AppearanceCell.Font.Style.ToString
                Dim strNomeFonte As String = parGrid.Columns.Item(I).AppearanceCell.Font.Name.ToString
                Dim strSizeFonte As String = parGrid.Columns.Item(I).AppearanceCell.Font.Size.ToString.Replace(",", ".")

                If I = 0 Then
                    strAjuste = strName & "," & bolVisivel & "," & strIndesx & "," & strShort & "," & strTamanho & "," & strNomeFonte & "," & strSizeFonte & "," & strStyleFonte
                Else
                    strAjuste &= "|" & strName & "," & bolVisivel & "," & strIndesx & "," & strShort & "," & strTamanho & "," & strNomeFonte & "," & strSizeFonte & "," & strStyleFonte
                End If

            Next

            If IO.File.Exists(My.Application.Info.DirectoryPath & "\Relatórios\Forms\" & parForm & ".txt") = True Then
                IO.File.Delete(My.Application.Info.DirectoryPath & "\Relatórios\Forms\" & parForm & ".txt")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "\Relatórios\Forms") = False Then
                IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\Relatórios\Forms")
            End If

            Dim SW As New StreamWriter(My.Application.Info.DirectoryPath & "\Relatórios\Forms\" & parForm & ".txt")
            SW.WriteLine(strAjuste)
            SW.Close()
            SW.Dispose()
            parPadrao.Enabled = True

            MsgBox("Configurações da grid salva com sucesso!", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub ConfigurarGridPadraoQuery()
        If IO.File.Exists(My.Application.Info.DirectoryPath & "\Relatórios\Forms\" & Me.cboTabela1.EditValue & ".txt") = True Then
            IO.File.Delete(My.Application.Info.DirectoryPath & "\Relatórios\Forms\" & Me.cboTabela1.EditValue & ".txt")
        End If
        Me.btnPadrao.Enabled = False
        MsgBox("Feche a tela e abre-a novamente!", MsgBoxStyle.Information)
    End Sub

    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGridQuery(Me.grd1, Me.cboTabela1.EditValue, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadraoQuery()
    End Sub
End Class