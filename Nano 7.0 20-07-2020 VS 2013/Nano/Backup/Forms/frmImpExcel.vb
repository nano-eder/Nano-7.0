Imports Nano.clsFuncoes
Imports System
Imports System.Data
Imports System.Data.OleDb
Imports DevExpress.XtraEditors.Repository
Public Class frmImpExcel
    Dim bolTimer As Boolean = True
    Public Shared Sub Main()
        Application.Run(New frmImpExcel())
    End Sub
    Private Sub txtLocal_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtLocal.ButtonClick
        Me.ofd.ShowDialog()
        Me.txtLocal.Text = Me.ofd.FileName

        Dim I As Integer
        Dim strTabela As String = ""
        For I = 0 To Me.cboTabela.Properties.Items.Count - 1
            Me.cboTabela.SelectedIndex = I
            Dim strTab As String = Me.cboTabela.Text
            If strTab <> "" Then
                If Me.txtLocal.Text.Contains(strTab) Then
                    strTabela = strTab
                End If
            End If
        Next

        Me.cboTabela.Text = strTabela
        Me.btnImportar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub

    Private Sub btnImportar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImportar.ItemClick
        If Validar(Me.cboTabela) = False Then Exit Sub
        If Validar(Me.txtLocal) = False Then Exit Sub
        Dim vetLocal As Array
        If Me.txtLocal.Text.Contains(Me.cboTabela.Text) Then
            Try
                vetLocal = Split(Me.txtLocal.Text, Me.cboTabela.Text & ".")
                Inserir("INSERT INTO " & Me.cboTabela.Text & " SELECT * FROM OPENROWSET ('Microsoft.Jet.OleDB.4.0','EXCEL 8.0;Database=" & Me.txtLocal.Text & ".xls'," & Me.cboTabela.Text & "$)")
                MsgBox("Tabela " & Me.cboTabela.Text & " importada com sucesso!", MsgBoxStyle.Information)
                Me.txtLocal.ResetText()
                Me.cboTabela.SelectedIndex = -1
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        Else
            MsgBox("O arquivo informado não corresponde com a tabela informada!", MsgBoxStyle.Information)
            Me.cboTabela.SelectedIndex = -1
        End If
     
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub frmImpExcel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dt As DataTable = CarregarDataTable("SELECT Table_Name from information_schema.tables order by Table_Name")
        If dt.Rows.Count > 0 Then
            Dim I As Integer
            Me.cboTabela.Properties.Items.Clear()
            Me.cboTabela.Properties.Items.Add("")
            For I = 0 To dt.Rows.Count - 1
                Me.cboTabela.Properties.Items.Add(dt.Rows.Item(I).ItemArray(0).ToString.ToUpper)
            Next
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Try
            Dim vetLocal As Array
            vetLocal = Split(Me.txtLocal.Text, Me.cboTabela.Text & ".")

            LimparGrid()

            CarregarDadosExecel(Me.txtLocal.Text, Me.cboTabela.Text, Me.GridControl1)


            Dim I As Integer
            Dim dtBoleto As DataTable
            dtBoleto = New DataTable
            For I = 0 To Me.GridView1.Columns.Count - 1
                dtBoleto.Columns.Add(New DataColumn(Me.GridView1.Columns.Item(I).Caption, GetType(String)))
                'Me.grd2.Columns.Add()
                'Me.grd2.Columns.Item(I).Caption = Me.GridView1.Columns.Item(I).Caption
            Next

            dtBoleto.TableName = "Boleto"
            dtBoleto.Rows.Add()
            Dim ds As New DataSet
            ds.Tables.Add(dtBoleto)
            Me.GridControl2.DataSource = ds
            Me.GridControl2.DataMember = "Boleto"

     






            Me.btnImportar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

            Me.btnInsViaFor.Visibility = DevExpress.XtraBars.BarItemVisibility.Always


            Calcular()
        Catch ex As Exception

        End Try
   
        
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim I As Integer
        Dim combo As RepositoryItemComboBox
        combo = Me.GridControl2.RepositoryItems.Add("ComboBoxEdit")
        Dim dt As DataTable = CarregarDataTable("select COLUMN_NAME, DATA_TYPE from information_schema.columns where table_name = '" & Me.cboTabela.Text & "'")
        If dt.Rows.Count > 0 Then

            combo.Items.Clear()
            combo.Items.Add("")
            For I = 0 To dt.Rows.Count - 1
                combo.Items.Add(dt.Rows.Item(I).ItemArray(0))
            Next
        End If

        For I = 0 To Me.GridView1.Columns.Count - 1
            Me.grd2.Columns.Item(I).ColumnEdit = combo
        Next
        Dim A As Integer
        'Me.grd2.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        For I = 0 To Me.GridView1.Columns.Count - 1
            Dim strColuna As String = Me.grd2.Columns.Item(I).Caption

            For A = 0 To combo.Items.Count - 1
                If strColuna = combo.Items.Item(A).ToString Then
                    Me.grd2.SetRowCellValue(0, Me.grd2.Columns.Item(I), strColuna)
                End If
            Next
        Next

        bolTimer = False
        Timer1.Stop()
    End Sub
    Private Sub LimparGrid()
        Dim A As Integer
        For A = 0 To Me.GridView1.Columns.Count - 1
            Me.GridView1.Columns.RemoveAt(0)
        Next
        For A = 0 To Me.GridView1.RowCount - 1
            Me.GridView1.DeleteRow(0)
        Next

        For A = 0 To Me.grd2.Columns.Count - 1
            Me.grd2.Columns.RemoveAt(0)
        Next
        For A = 0 To Me.grd2.RowCount - 1
            Me.grd2.DeleteRow(0)
        Next
    End Sub
    Private Sub Calcular()
        Me.lblQtd.Text = "Qtd: " & Me.GridView1.RowCount
    End Sub
    Private Function Dados(ByVal parColuna As String, ByVal parDados As String, ByVal parCont As String, ByVal parQuery As String, ByRef parOK As Boolean) As String
        Dim strDados As String = parDados
        parOK = True
        Select Case Me.cboTabela.Text
            Case "CLIENTE", "FORNECEDOR"

                Select Case parColuna
                    Case "Nome"
                        If strDados = "" Then
                            parOK = False
                            Exit Function
                        End If
                        If strDados.Length > 150 Then
                            strDados = strDados.Substring(0, 150)
                        End If
                    Case "RG"
                        strDados = strDados.Replace("_", "")
                        If strDados = "..." Then
                            strDados = ""
                        End If
                        If strDados = "..-" Then
                            strDados = ""
                        End If
                        If strDados.Length > 15 Then
                            strDados = strDados.Substring(0, 15)
                        End If
                    Case "RGIE"
                        strDados = strDados.Replace("_", "")
                        If strDados = "..." Then
                            strDados = ""
                        End If
                        If strDados = "..-" Then
                            strDados = ""
                        End If
                        If strDados.Length > 15 Then
                            strDados = strDados.Substring(0, 15)
                        End If
                    Case "CPF"
                        strDados = strDados.Replace("_", "").Replace(".", "").Replace("/", "").Replace("-", "")
                        If strDados.Trim = "" Then
                            strDados = "000" & parCont
                        Else
                            If strDados.Length = 14 Then
                                strDados = AddPonto(strDados, "J")
                            Else
                                strDados = AddPonto(strDados, "F")
                            End If
                        End If
                        If strDados.Length > 25 Then
                            strDados = strDados.Substring(0, 25)
                        End If

                        If parQuery.Contains(",'" & strDados & "',") Then
                            strDados = "000" & parCont
                        End If

                    Case "Endereco"
                        If strDados.Length > 150 Then
                            strDados = strDados.Substring(0, 150)
                        End If
                    Case "Numero"
                        If strDados.Length > 10 Then
                            strDados = strDados.Substring(0, 10)
                        End If

                    Case "Complemento"
                        If strDados.Length > 75 Then
                            strDados = strDados.Substring(0, 75)
                        End If
                    Case "Bairro", "Corretor", "Qual"
                        If strDados.Length > 100 Then
                            strDados = strDados.Substring(0, 100)
                        End If
                    Case "Cep"
                        If strDados = "_____-___" Then
                            strDados = ""
                        End If
                        If strDados.Length > 20 Then
                            strDados = strDados.Substring(0, 20)
                        End If
                    Case "Cidade", "ComoChegou", "Email", "Site"
                        If strDados.Length > 50 Then
                            strDados = strDados.Substring(0, 50)
                        End If
                    Case "Estado"
                        If strDados.Length > 40 Then
                            strDados = strDados.Substring(0, 40)
                        End If
                    Case "Telefone", "Fax", "Celular"
                        strDados = strDados.Trim.Replace("x", "")
                        If strDados.Length > 18 Then
                            strDados = strDados.Substring(0, 18)
                        End If
                    Case "Data SmallDateTime,"
                        strDados = Data(strDados)
                    Case "IE"
                        If strDados.Length > 15 Then
                            strDados = strDados.Substring(0, 15)
                        End If
                    Case "Fantasia"
                        If strDados.Length > 80 Then
                            strDados = strDados.Substring(0, 80)
                        End If
                    Case "Inadimplente"
                        If strDados.ToUpper <> "FALSE" And strDados.ToUpper <> "TRUE" And strDados <> "0" And strDados <> "1" Then
                            strDados = "False"
                        End If
                    Case "Status", "Sexo"
                        If strDados.Length > 1 Then
                            strDados = strDados.Substring(0, 1)
                        End If

                    Case "Nascimento"
                        strDados = Data(strDados)

                    Case "Limite", "TelefoneCorretor"
                        If strDados.Length > 18 Then
                            strDados = strDados.Substring(0, 18)
                        End If
                    Case "Senha"
                        If strDados.Length > 10 Then
                            strDados = strDados.Substring(0, 10)
                        End If
                    Case "Email"
                        If strDados.Length > 50 Then
                            strDados = strDados.Substring(0, 50)
                        End If
                    Case "Suframa"
                        If strDados.Length > 9 Then
                            strDados = strDados.Substring(0, 9)
                        End If
                    Case "CodMunicipio"
                        If strDados.Length > 7 Then
                            strDados = strDados.Substring(0, 7)
                        End If
                    Case "CodPais"
                        If strDados.Length > 4 Then
                            strDados = strDados.Substring(0, 4)
                        End If
                    Case "NomePais"
                        If strDados.Length > 60 Then
                            strDados = strDados.Substring(0, 60)
                        End If

                    Case "Desconto"
                        strDados = Num(strDados)
                    Case "Inativo"
                        strDados = "False"
                End Select
            Case "PRODUTO"
                Select Case parColuna
                    Case "Codigo"
                        If strDados.Length > 15 Then
                            strDados = strDados.Substring(0, 15)
                        End If
                    Case "Nome"
                        If strDados = "" Then
                            parOK = False
                            Exit Function
                        End If
                        If strDados.Length > 100 Then
                            strDados = strDados.Substring(0, 100)
                        End If
                    Case "UnidadeMedida"
                        If strDados.Length > 15 Then
                            strDados = strDados.Substring(0, 15)
                        End If
                        If strDados.ToUpper <> "UNIDADE" And strDados.ToUpper <> "JOGO" And strDados.ToUpper <> "KIT" And strDados.ToUpper <> "PESO" And strDados.ToUpper <> "LÍTRO" And strDados.ToUpper <> "METRO" And strDados.ToUpper <> "HORA" Then
                            strDados = "UNIDADE"
                        End If
                    Case "Qtd", "QtdMinima", "Valor", "Valor2", "Valor3", "ValorCusto", "Ponto", "QtdMaxima"
                        strDados = Num(strDados)
                    Case "Faltando"
                        If strDados.ToUpper <> "FALSE" And strDados.ToUpper <> "TRUE" And strDados <> "0" And strDados <> "1" Then
                            strDados = "False"
                        End If
                    Case "Locacao"
                        If strDados.Length > 10 Then
                            strDados = strDados.Substring(0, 10)
                        End If
                    Case "Tipo"
                        If strDados.Length > 25 Then
                            strDados = strDados.Substring(0, 25)
                        End If
                    Case "TipoProduto"
                        If strDados.Length > 20 Then
                            strDados = strDados.Substring(0, 20)
                        End If
                    Case "CodigoPeca"
                        If strDados.Length > 50 Then
                            strDados = strDados.Substring(0, 50)
                        End If
                        If parQuery.Contains(",'" & strDados & "',") Then
                            strDados = "0000" & parCont & "0P"
                        End If
                    Case "CodigoBarra"
                        If strDados.Length > 25 Then
                            strDados = strDados.Substring(0, 25)
                        End If
                        If parQuery.Contains(",'" & strDados & "',") Then
                            strDados = "0000" & parCont & "0B"
                        End If
                    Case "Porcentagens"
                        If strDados.Length > 50 Then
                            strDados = strDados.Substring(0, 50)
                        End If
                    Case "Aplicacao"
                        If strDados.Length > 150 Then
                            strDados = strDados.Substring(0, 150)
                        End If
                    Case "CodigoFabricante"
                        If strDados.Length > 55 Then
                            strDados = strDados.Substring(0, 55)
                        End If
                    Case "Fabricante"
                        If strDados.Length > 55 Then
                            strDados = strDados.Substring(0, 55)
                        End If
                    Case "Grupo"
                        If strDados.Length > 80 Then
                            strDados = strDados.Substring(0, 80)
                        End If
                        If strDados = "" Then
                            strDados = "DIVERSOS"
                        End If
                        Dim dtGrupo As DataTable = CarregarDataTable("SELECT Codigo FROM Grupo where Nome = '" & strDados & "'")
                        If dtGrupo.Rows.Count = 0 Then
                            Inserir("INSERT INTO Grupo(Nome,Tipo)VALUES('" & strDados & "','G')")
                        End If
                    Case "Garantia"
                        If strDados.Length > 15 Then
                            strDados = strDados.Substring(0, 15)
                        End If
                    Case "KM"
                        If strDados.Length > 6 Then
                            strDados = strDados.Substring(0, 6)
                        End If
                    Case "Desconto"
                        '  If strDados <> "" Then
                        strDados = "0"
                        ' End If

                    Case "QTM", "QT", "Comissao"
                        If strDados = "" Then
                            strDados = "0"
                        End If
                    Case "Inativo"

                        strDados = "False"

                End Select
            Case "GRUPO"


            Case Else



                Dim dtDados As DataTable = CarregarDataTable("select COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH from information_schema.columns where table_name = '" & Me.cboTabela.Text & "' and COLUMN_NAME = '" & parColuna & "'")
                If dtDados.Rows.Count > 0 Then
                    Dim strTipo As String = dtDados.Rows.Item(0).Item("DATA_TYPE").ToString
                    Dim strChar As String = dtDados.Rows.Item(0).Item("CHARACTER_MAXIMUM_LENGTH").ToString

                    Select Case strTipo
                        Case "numeric"
                            strDados = Num(strDados)
                        Case "int"
                            If strDados = "" Then
                                strDados = "0"
                            End If
                        Case "bit"
                            If strDados.ToUpper <> "FALSE" And strDados.ToUpper <> "TRUE" And strDados <> "0" And strDados <> "1" Then
                                strDados = "False"
                            End If
                        Case "smalldatetime"
                            strDados = Data(strDados)
                        Case "varchar"
                            If CInt(strChar) < 0 Then

                            Else
                                If strDados.Length > CInt(strChar) Then
                                    strDados = strDados.Substring(0, CInt(strChar))
                                End If
                            End If
                       
                    End Select

                End If



        End Select

        Return strDados

    End Function
    Private Sub btnInsViaFor_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInsViaFor.ItemClick
        Dim i As Integer
        Dim strInsert As String = ""
        Dim strUFTabela As String = ""
        If Me.GridView1.RowCount < 0 Then Exit Sub
        Try


            Dim strQuery As String = ""
            Dim strQuery2 As String = ""
            Dim strQuery3 As String = ""

            For i = 0 To Me.GridView1.Columns.Count - 1
                If Me.grd2.Columns.Item(i).Visible = True Then
                    Dim strQ As String = Me.grd2.GetRowCellDisplayText(0, Me.grd2.Columns.Item(i))
                    If Me.grd2.GetRowCellDisplayText(0, Me.grd2.Columns.Item(i)) = "" Then
                        MsgBox("Coluna vazia!", MsgBoxStyle.Information)
                        strQuery = ""
                        Exit Sub

                    End If
                    Select Case strQuery
                        Case ""
                            strQuery &= "insert into " & Me.cboTabela.Text & "(" & strQ
                        Case Else
                            strQuery &= ", " & strQ
                    End Select
                End If
            Next

            strQuery = strQuery & ")VALUES("

            For i = 0 To Me.GridView1.Columns.Count - 1
                If Me.grd2.Columns.Item(i).Visible = True Then
                    Dim strQ As String = Me.grd2.GetRowCellDisplayText(0, Me.grd2.Columns.Item(i))
                    Dim dt As DataTable = CarregarDataTable("select DATA_TYPE from information_schema.columns where table_name = '" & Me.cboTabela.Text & "' and COLUMN_NAME = '" & strQ & "'")

                    Dim strTipo As String = dt.Rows.Item(0).Item("DATA_TYPE").ToString

                    Select Case strQuery2
                        Case ""
                            If strTipo = "varchar" Or strTipo = "bit" Or strTipo = "nvarchar" Or strTipo = "smalldatetime" Then
                                strQuery2 &= "'" & "TABELA" & Me.cboTabela.Text & Me.grd2.Columns.Item(i).VisibleIndex & strQ & "'"
                            Else
                                strQuery2 &= "TABELA" & Me.cboTabela.Text & Me.grd2.Columns.Item(i).VisibleIndex & strQ
                            End If

                        Case Else
                            If strTipo = "varchar" Or strTipo = "bit" Or strTipo = "nvarchar" Or strTipo = "smalldatetime" Then
                                strQuery2 &= ",'" & "TABELA" & Me.cboTabela.Text & Me.grd2.Columns.Item(i).VisibleIndex & strQ & "'"
                            Else
                                strQuery2 &= ",TABELA" & Me.cboTabela.Text & Me.grd2.Columns.Item(i).VisibleIndex & strQ
                            End If
                    End Select
                End If
            Next

            strQuery2 = strQuery2 & ")"
            strQuery = strQuery & strQuery2

            pb1.Value = 0
            pb1.Maximum = Me.GridView1.RowCount


            Dim A As Integer

            Dim B As Integer
            Dim C As Integer
            Dim strIn As String = ""

            For i = 0 To Me.GridView1.RowCount - 1
             
                strQuery3 = strQuery
                For A = 0 To Me.GridView1.Columns.Count - 1

                    If Me.grd2.Columns.Item(A).Visible = True Then
                        Dim strQ As String = Me.grd2.GetRowCellDisplayText(0, Me.grd2.Columns.Item(A))
                        Dim strDados As String = Me.GridView1.GetRowCellDisplayText(i, Me.grd2.Columns.Item(A))
                        Dim bolOk As Boolean
                        strDados = Dados(strQ, strDados, i, strInsert, bolOk)

                        If Me.cboTabela.Text.ToUpper = "TABELAIBPT" Then
                            If strQ = "NCM" Then
                                If strDados.Length = 7 Then
                                    strDados = "0" & strDados
                                End If
                            End If

                            If strQ.ToUpper = "VERSAO" Then
                                strDados = strDados.Substring(0, 4)
                            End If
                            If strUFTabela = "" Then
                                If strQ.ToUpper = "UF" Then
                                    strUFTabela = strDados
                                End If
                            End If
                        End If

                        If bolOk = True Then
                            strQuery3 = strQuery3.Replace("TABELA" & Me.cboTabela.Text & Me.grd2.Columns.Item(A).VisibleIndex & strQ, strDados.Replace("'", "´").ToUpper)
                        End If
                    End If
                Next
                If Me.cboTabela.Text.ToUpper = "TABELAIBPT" Then
                    strInsert &= strQuery3 & vbCrLf
                Else
                    strInsert &= strQuery3 & vbCrLf & vbCrLf
                End If
            
                'strIn &= strQuery3 & vbCrLf
                'B += 1
                'If B = 500 Then
                '    B = 0
                '    C += 1
                '    Call SalvarArquivo(strIn, "C:\NANO\TabelaIBPT" & C & ".txt", False)

                '    strIn = ""
                'End If
               

                pb1.Value = pb1.Value + 1
                Application.DoEvents()
                System.Threading.Thread.Sleep(40)

            Next

            'C += 1
            'Call SalvarArquivo(strIn, "C:\NANO\TabelaIBPT" & C & ".txt", False)
            If Me.cboTabela.Text.ToUpper = "TABELAIBPT" Then
                strUFTabela = SelecionarNomeUF(strUFTabela)
                Call SalvarArquivo(strInsert, "C:\NANO\TabelaIBPT\" & strUFTabela & ".txt", False)
                MsgBox("Tabela IBPT  de " & strUFTabela & " importada com sucesso!", MsgBoxStyle.Information)
            Else
                Dim inte As Integer = strInsert.Length
                Inserir(strInsert)
                Updates()
                MsgBox("Tabela " & Me.cboTabela.Text & " importada com sucesso!", MsgBoxStyle.Information)
            End If



    
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)

        End Try


        Me.txtLocal.ResetText()
        Me.cboTabela.SelectedIndex = -1
        pb1.Value = 0
        Application.DoEvents()
        System.Threading.Thread.Sleep(40)
    End Sub
    Private Sub Updates()
        Dim strInsert As String = ""
        If Me.cboTabela.SelectedItem = "CLIENTE" Then
            strInsert &= "UPDATE Cliente set Inadimplente = 'False' where Inadimplente is null" & vbCrLf & vbCrLf
            strInsert &= "UPDATE Cliente set Inativo = 'False' where Inativo is null" & vbCrLf & vbCrLf
            strInsert &= "UPDATE Cliente set CodConfig = " & CodConfig & " where CodConfig = '' or CodConfig is null" & vbCrLf & vbCrLf
            
        ElseIf Me.cboTabela.SelectedItem = "PRODUTO" Then
            'strInsert &= "UPDATE Produto set Inativo = 'False' where Inativo is null" & vbCrLf & vbCrLf
        ElseIf Me.cboTabela.SelectedItem = "FORNECEDOR" Then
            strInsert &= "UPDATE Fornecedor set Inativo = 'False' where Inativo is null" & vbCrLf & vbCrLf
            strInsert &= "UPDATE Fornecedor set CodConfig = " & CodConfig & " where CodConfig = '' or CodConfig is null" & vbCrLf & vbCrLf
            strInsert &= "UPDATE Fornecedor set Tipo ='F' where Tipo = '' or Tipo is null" & vbCrLf & vbCrLf

        ElseIf Me.cboTabela.SelectedItem = "QTDE" Then

        End If

        Inserir(strInsert)

    End Sub
    Private Sub grd2_ColumnWidthChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles grd2.ColumnWidthChanged
        Dim A As Integer
        For A = 0 To Me.grd2.Columns.Count - 1
            Me.GridView1.Columns.Item(A).Width = Me.grd2.Columns.Item(A).Width
        Next
    End Sub

    Private Sub grd2_Layout(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd2.Layout
        Dim A As Integer
        For A = 0 To Me.grd2.Columns.Count - 1
            If Me.grd2.Columns.Item(A).Visible = False Then
                Me.GridView1.Columns.Item(A).Visible = False
            End If
            If bolTimer = False Then
                Try
                    Me.GridView1.Columns.Item(A).VisibleIndex = Me.grd2.Columns.Item(A).VisibleIndex

                Catch ex As Exception

                End Try
            End If
        Next
    End Sub

  
    Private Sub grd2_LeftCoordChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd2.LeftCoordChanged
        Dim int As Integer = Me.grd2.LeftCoord
        Me.GridView1.LeftCoord = int
    End Sub

    Private Sub GridView1_ColumnWidthChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles GridView1.ColumnWidthChanged
        Dim A As Integer
        For A = 0 To Me.GridView1.Columns.Count - 1
            Me.grd2.Columns.Item(A).Width = Me.GridView1.Columns.Item(A).Width
        Next
    End Sub

    Private Sub GridView1_Layout(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Layout
        Dim A As Integer
        For A = 0 To Me.GridView1.Columns.Count - 1
            If Me.GridView1.Columns.Item(A).Visible = False Then
                Me.grd2.Columns.Item(A).Visible = False
            End If
            If bolTimer = False Then
                Try
                    Me.grd2.Columns.Item(A).VisibleIndex = Me.GridView1.Columns.Item(A).VisibleIndex

                Catch ex As Exception

                End Try
           End If
       Next
    End Sub

    Private Sub GridView1_LeftCoordChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.LeftCoordChanged
        Dim int As Integer = Me.GridView1.LeftCoord
        Me.grd2.LeftCoord = int
    End Sub

    
    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        LimparGrid()
        Me.txtLocal.ResetText()
        Me.cboTabela.SelectedIndex = -1
        Me.btnImportar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.btnInsViaFor.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Calcular()
    End Sub
End Class