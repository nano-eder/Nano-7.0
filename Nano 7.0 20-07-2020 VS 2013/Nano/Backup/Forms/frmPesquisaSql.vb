Imports Nano.clsFuncoes
Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Public Class frmPesquisaSql
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
        Me.cboTabela.SelectedIndex = -1
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
        Dim dt As DataTable = CarregarDataTable("SELECT Table_Name from information_schema.tables order by Table_Name")
        If dt.Rows.Count > 0 Then
            Dim I As Integer
            Me.cboTabela.Properties.Items.Clear()
            Me.cboTabela.Properties.Items.Add("")
            For I = 0 To dt.Rows.Count - 1
                Me.cboTabela.Properties.Items.Add(dt.Rows.Item(I).ItemArray(0))
            Next

        End If
    End Sub

    Private Sub cboTabela_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTabela.SelectedIndexChanged
        Select Case Me.cboTabela.SelectedIndex
            Case Else
                Dim strTabela As String = Me.cboTabela.Text

                Me.rtbQuery.AppendText("SELECT * FROM " & strTabela & ";" & vbCrLf)
                Dim strPalavra As String = "SELECT|*|FROM"
                Dim vet As Array = Split(strPalavra, "|")
                Dim I As Integer
                For I = 0 To vet.Length - 1
                    If vet(I) <> "" And vet(I) <> "*" Then
                        CorDoTexto(rtbQuery, vet(I), Color.Blue, 1)
                    End If
                Next

        End Select
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnAcres_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAcres.ItemClick
        Dim data1, data2, strColuna As String
        data1 = dtInicial.EditValue
        data2 = dtFinal.EditValue
        strColuna = txtColuna.EditValue
        If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Sub
        If data2 = "" Then MsgBox("Selecione a Data Final!", MsgBoxStyle.Information) : Exit Sub
        If strColuna = "" Then
            strColuna = "Data"
        End If
        Dim dataFim, dataIni As Date
        dataIni = data1
        dataFim = data2

        If dataIni > dataFim Then MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information) : Exit Sub

        Dim strData As String
        strData = String.Format(strColuna & " >= '{0:dd/MM/yyyy}' AND " & strColuna & " <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue)
        Me.rtbQuery.AppendText(strData)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.cboTabela.SelectedIndex = 0
        Me.rtbQuery.ResetText()
        Me.rtbQuery.Focus()
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub
End Class