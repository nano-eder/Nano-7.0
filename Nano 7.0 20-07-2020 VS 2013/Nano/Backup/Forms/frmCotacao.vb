Imports Nano.clsFuncoes
Imports DevExpress.XtraGrid.Views.Base

Public Class frmCotacao

    Dim bolProduto As Boolean
    Dim bolFornecedor As Boolean
    Dim strCodProd As String
    Dim strCodProdPeca As String
    Dim intCodFor As Integer

    Dim bolPassouProd As Boolean = False
    Dim bolPassouFor As Boolean = False
    Dim bolPassou As Boolean = False

    Private Sub LimparProd()
        Me.txtCodPro.ResetText()
        Me.txtNomePro.ResetText()
        Me.txtCodPro.Focus()
    End Sub

    Private Sub LimparFor()
        Me.txtFor.ResetText()
    End Sub

    Private Sub Limpar()
        LimparProd()
        LimparFor()

        Me.tbCusto.Rows.Clear()
        Me.txtCodTab.ResetText()
        Me.txtCodTab.Focus()

        Dim Resulte As String = ""
        Dim Passou As Boolean = False
        For J As Integer = 0 To Me.dsCusto.Tables(0).Columns.Count - 1
            Try
                Dim Fornecedor As String = Me.dsCusto.Tables(0).Columns(J).Caption.ToString()

                If Fornecedor.Contains("Produto") = False And Fornecedor.Contains("Codigo") = False _
                And Fornecedor.Contains("Valor") = False And Fornecedor.Contains("CodProd") = False _
                And Fornecedor.Contains("CodigoPeca") = False And Fornecedor.Contains("CodFor") = False Then

                    If Passou = False Then
                        Resulte = Fornecedor
                        Passou = True
                    Else
                        Resulte = Resulte & "|" & Fornecedor
                    End If

                End If
            Catch ex As Exception
            End Try
        Next

        Dim vet As Array = Resulte.Split("|")
        If vet(0).ToString <> "" Then
            For A As Integer = 0 To vet.Length - 1
                Me.dsCusto.Tables(0).Columns.Remove(vet(A).ToString)

                Dim Index As Integer = Me.grd1.Columns(vet(A).ToString).AbsoluteIndex
                Me.grd1.Columns.RemoveAt(Index)
            Next
        End If

        If Me.grd1.RowCount <= 0 Then
            Me.picImagem.Visible = True
        End If
    End Sub

    Private Sub ConsultarCotacao()
        ConsultaPedido = ""
        Dim frm As New frmConPed
        frm.Tag = "COTACAO"
        frm.ShowDialog()

        Limpar()
        If ConsultaPedido <> "" Then
            Me.txtCodTab.Text = ConsultaPedido
            CarregaForm()
            CarregaForm()
        Else
            Me.txtCodTab.Text = ""
            Me.txtCodTab.Focus()
        End If
    End Sub

    Private Sub CarregaForm()
        Dim Index As Integer = Nothing

        Dim dtTabela As DataTable = CarregarDataTable("Select Cotacao.Codigo, Cotacao.CodOrdem, Cotacao.CodProd, Cotacao.CodFor, Cotacao.Valor, Cotacao.Data, Fornecedor.Nome, Produto.Nome as Produto From (Cotacao Inner Join Fornecedor On Cotacao.CodFor = Fornecedor.Codigo) inner join Produto on Cotacao.CodProd = Produto.Codigo Where Cotacao.CodOrdem=" & Me.txtCodTab.Text & " And Cotacao.CodConfig=" & CodConfig & " Order By Cotacao.Codigo")
        If dtTabela.Rows.Count = 0 Then MsgBox("Cotação não cadastrada!", MsgBoxStyle.Information) : Me.txtCodTab.ResetText() : Me.txtCodTab.Focus() : Exit Sub

        Dim dt As Date = dtTabela.Rows.Item(0).Item("Data").ToString
        Me.dtData.Text = dt.ToString("dd/MM/yyyy")

        For I As Integer = 0 To dtTabela.Rows.Count - 1

            'Carregar Produto
            With Me.tbCusto.Rows
                Dim bolPassou As Boolean = False
                Dim strProduto As String = ""

                For A As Integer = 0 To Me.grd1.RowCount - 1
                    strProduto = grd1.GetRowCellValue(A, Me.colProduto)
                    If strProduto = dtTabela.Rows.Item(I).Item("Produto").ToString Then
                        bolPassou = True
                    End If
                Next

                If bolPassou = False Then
                    .Add()
                    Index = .Count - 1
                    .Item(Index).Item("Produto") = dtTabela.Rows.Item(I).Item("Produto").ToString
                    .Item(Index).Item("CodProd") = dtTabela.Rows.Item(I).Item("CodProd").ToString

                    Dim dtCodigoPeca As DataTable = CarregarDataTable("Select CodigoInterno From Produto Where Codigo=" & dtTabela.Rows.Item(I).Item("CodProd").ToString)
                    If dtCodigoPeca.Rows.Count > 0 Then
                        strCodProdPeca = dtCodigoPeca.Rows.Item(0).Item("CodigoInterno").ToString
                    End If
                    .Item(Index).Item("CodigoPeca") = strCodProdPeca
                End If


                'Carregar Coluna Fornecedor
                Dim Fornecedor As String = dtTabela.Rows.Item(I).Item("Nome").ToString()
                intCodFor = dtTabela.Rows.Item(I).Item("CodFor").ToString()

                bolPassou = False
                For J As Integer = 0 To Me.grd1.Columns.Count - 1
                    Dim strFor As String = Me.grd1.Columns.Item(J).Caption().ToString()

                    If strFor.Contains("Produto") = False And strFor.Contains("Codigo") = False And strFor.Contains("CodProd") = False And strFor.Contains("Código Peça") = False Then
                        If strFor = Fornecedor Then
                            bolPassou = True
                            Exit For
                        End If
                    End If
                Next

                If bolPassou = False Then
                    Me.grd1.Columns.AddField(Fornecedor)
                    Me.grd1.Columns.ColumnByFieldName(Fornecedor).Visible = True
                    Me.grd1.Columns.ColumnByFieldName(Fornecedor).Width = 200
                    Me.grd1.Columns.ColumnByFieldName(Fornecedor).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    Me.grd1.Columns.ColumnByFieldName(Fornecedor).Tag = intCodFor
                    Me.dsCusto.Tables(0).Columns.Add(Fornecedor, Type.GetType("System.String"))
                End If


                'Carregar Valor na linha
                For B As Integer = 0 To Me.tbCusto.Rows.Count - 1
                    Dim intFor As Integer = Me.grd1.Columns.ColumnByFieldName(Fornecedor).Tag

                    Dim intProd As Integer = dtTabela.Rows.Item(I).Item("CodProd").ToString
                    Dim intCodProd As Integer = Me.tbCusto.Rows.Item(B).Item("CodProd").ToString

                    If intFor = intCodFor And intProd = intCodProd Then
                        Dim dblvalor As Double = dtTabela.Rows.Item(I).Item("Valor").ToString()
                        .Item(B).Item(Fornecedor) = dblvalor.ToString("0.000")
                    End If
                Next

            End With
        Next

        Ajuste()
        If Me.grd1.RowCount > 0 Then
            Me.picImagem.Visible = False
        End If
    End Sub

    Private Sub XtraForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtData.Text = Date.Today

        If Me.Tag = "ALTERAR" Then
            Me.btnConsulta.Enabled = True
            Me.txtCodPro.Properties.ReadOnly = False
            Me.txtNomePro.Properties.ReadOnly = False

            Me.btnAddProd.Enabled = True
            Me.btnRemover.Enabled = True
            Me.btnAddFor.Enabled = True
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        ElseIf Me.Tag = "CONSULTAR" Then
            Me.btnConsulta.Enabled = True
            Me.txtCodPro.Enabled = False
            Me.txtNomePro.Properties.ReadOnly = True
            Me.txtFor.Enabled = False

            Me.btnAddProd.Enabled = False
            Me.btnRemover.Enabled = False
            Me.btnAddFor.Enabled = False
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Else
            Me.txtCodTab.Text = GerarCodigoOrdens("Cotacao", CodConfig)
            Me.btnConsulta.Enabled = False

            Me.txtCodPro.Properties.ReadOnly = False
            Me.txtCodPro.BackColor = Color.White
            Me.txtNomePro.Properties.ReadOnly = False
            Me.txtNomePro.BackColor = Color.White
            Me.btnAddProd.Enabled = True
            Me.btnRemover.Enabled = True
            Me.btnAddFor.Enabled = True
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If
    End Sub

    Private Sub btnAddFor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFor.Click
        If Validar(Me.txtFor) = False Then Exit Sub

        bolFornecedor = False
        For J As Integer = 0 To Me.grd1.Columns.Count - 1
            Dim Fornecedor As String = Me.grd1.Columns.Item(J).Caption().ToString()

            If Fornecedor.Contains("Produto") = False And Fornecedor.Contains("Codigo") = False And Fornecedor.Contains("CodProd") = False And Fornecedor.Contains("Código Peça") = False Then

                If Me.txtFor.Text = Fornecedor Then
                    bolFornecedor = True
                    Me.grd1.Columns.Item(J).Visible = True
                    Exit For
                End If
            End If
        Next

        If bolFornecedor = False Then
            Me.grd1.Columns.AddField(Me.txtFor.Text)
            Me.grd1.Columns.ColumnByFieldName(Me.txtFor.Text).Visible = True
            Me.grd1.Columns.ColumnByFieldName(Me.txtFor.Text).Width = 200
            Me.grd1.Columns.ColumnByFieldName(Me.txtFor.Text).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.grd1.Columns.ColumnByFieldName(Me.txtFor.Text).Tag = intCodFor

            Me.dsCusto.Tables(0).Columns.Add(Me.txtFor.Text, Type.GetType("System.String"))
        End If

        Me.grd1.Focus()
        Me.GroupControl1.Focus()
        LimparFor()
        Ajuste()
    End Sub

    Private Sub txtCodPro_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodPro.ButtonClick
        AbrirProdutos()
    End Sub

    Private Sub AbrirProdutos()
        CodigoDoProduto = -1
        Dim frm As New frmConProduto
        TipoProduto = "PEÇA"
        frm.Tag = "VENDA"

        RetornaProduto = ""

        frm.ShowDialog()
        If CodigoDoProduto = -1 Then Exit Sub

        CarregaProduto(CodigoDoProduto)

    End Sub

    Private Sub CarregaProduto(ByVal parCodProdAut As Integer)
        Dim dt As DataTable = CarregarDataTable("Select Codigo, CodigoInterno, Nome From Produto Where Codigo = " & parCodProdAut)

        If dt.Rows.Count = 0 Then
            Me.txtCodPro.ResetText()
            Me.txtCodPro.Tag = ""
            Me.txtNomePro.ResetText()
        Else
            Me.txtCodPro.Text = dt.Rows.Item(0).Item("CodigoInterno")
            Me.txtNomePro.Text = dt.Rows.Item(0).Item("Nome").ToString

            strCodProd = dt.Rows.Item(0).Item("Codigo").ToString
            strCodProdPeca = dt.Rows.Item(0).Item("CodigoInterno")
        End If
    End Sub

    Private Sub txtFor_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtFor.ButtonClick
        NomeFornecedor = ""
        CPFFornecedor = ""
        intCodFor = 0
        frmCadFornecedor.Tag = "PESQUISA"
        frmCadFornecedor.ShowDialog()

        'If NomeFornecedor.Trim = "" Then Exit Sub
        'Me.txtFor.Text = NomeFornecedor


        Dim dt As DataTable = CarregarDataTable("Select Nome, CPF from Fornecedor where Codigo =" & CodigoDoFornecedor)

        If dt.Rows.Count > 0 Then
            intCodFor = CodigoDoFornecedor
            Me.txtFor.Text = dt.Rows.Item(0).Item("Nome").ToString

        End If
   
    End Sub

    Private Sub Finalizar()
        Dim Query As String = ""
        Dim bolPassou As Boolean = False
        Me.grd1.FocusedRowHandle = 0

        If Me.Tag = "CADASTRAR" Then
            Me.txtCodTab.Text = GerarCodigoOrdens("Cotacao", CodConfig)
            Inserir("Insert into Ordens (Tabela, Cod, CodConfig) values('Cotacao'," & Me.txtCodTab.Text & "," & CodConfig & ")")
        End If

        Dim Fornecedor As String = ""
        For I As Integer = 0 To Me.grd1.VisibleColumns.Count - 1
            Fornecedor = Me.grd1.VisibleColumns.Item(I).Caption().ToString()

            If Fornecedor.Contains("Produto") = False And Fornecedor.Contains("Codigo") = False And Fornecedor.Contains("CodProd") = False And Fornecedor.Contains("Código Peça") = False Then
                intCodFor = Me.grd1.VisibleColumns.Item(I).Tag.ToString

                For J As Integer = 0 To Me.tbCusto.Rows.Count - 1
                    If Me.tbCusto.Rows.Item(J).Item(Fornecedor).ToString <> Fornecedor Then
                        Dim codProd As Integer = Me.tbCusto.Rows.Item(J).Item("CodProd").ToString
                        Dim strValor As String = Me.tbCusto.Rows.Item(J).Item(Fornecedor).ToString

                        If bolPassou = False Then
                            Query = "Insert Into Cotacao (CodOrdem, CodProd, CodFor, Valor, Data, CodConfig) Values(" & Me.txtCodTab.Text & "," & codProd & "," & intCodFor & "," & Num(strValor) & ",'" & Me.dtData.Text & "'," & CodConfig & ");"
                            bolPassou = True
                        Else
                            Query = Query & vbCrLf & "Insert Into Cotacao (CodOrdem, CodProd, CodFor, Valor, Data, CodConfig) Values(" & Me.txtCodTab.Text & "," & codProd & "," & intCodFor & "," & Num(strValor) & ",'" & Me.dtData.Text & "'," & CodConfig & ");"
                        End If
                    End If
                Next
            End If
        Next

        If Me.Tag = "ALTERAR" Then
            Inserir("Delete From Cotacao Where CodOrdem =" & Me.txtCodTab.Text & " And CodConfig=" & CodConfig & "")
            Inserir(Query)
            MsgBox("Cotação Nº " & Me.txtCodTab.Text & " Alterada com sucesso!", MsgBoxStyle.Information)

        Else
            Inserir(Query)
            MsgBox("Cotação Nº " & Me.txtCodTab.Text & " Cadastrada com sucesso!", MsgBoxStyle.Information)

        End If

        If Me.Tag = "CADASTRAR" Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        Finalizar()
    End Sub

    Private Sub grd1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grd1.CellValueChanged
        Ajuste()
    End Sub

    Private Sub Ajuste()
        For I As Integer = 0 To Me.grd1.VisibleColumns.Count - 1
            Dim Fornecedor As String = Me.grd1.VisibleColumns.Item(I).Caption().ToString()

            If Fornecedor.Contains("Produto") = False And Fornecedor.Contains("Codigo") = False And Fornecedor.Contains("CodProd") = False And Fornecedor.Contains("Código Peça") = False Then
                For J As Integer = 0 To Me.tbCusto.Rows.Count - 1
                    If Me.tbCusto.Rows.Item(J).Item(Fornecedor).ToString <> Fornecedor Then
                        Try
                            Dim dlbValor As Double = Me.tbCusto.Rows.Item(J).Item(Fornecedor).ToString.Replace(".", ",")
                            Dim Resultado As String = dlbValor.ToString("0.000")
                            Me.tbCusto.Rows.Item(J).Item(Fornecedor) = Resultado
                        Catch ex As Exception
                            Me.tbCusto.Rows.Item(J).Item(Fornecedor) = "0,000"
                        End Try
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemover.Click
        If grd1.RowCount = 0 Then Exit Sub
        If MsgBox("Deseja realmente excluir este item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.grd1.DeleteRow(grd1.FocusedRowHandle)
        End If
        Ajuste()

        If Me.grd1.RowCount <= 0 Then
            Me.picImagem.Visible = True
        End If

        Me.txtCodPro.Focus()
    End Sub

    Private Sub btnAddProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddProd.Click
        If Validar(Me.txtNomePro) = False Then Exit Sub

        bolProduto = False
        Dim strProduto As String = ""
        For I As Integer = 0 To Me.grd1.RowCount - 1
            strProduto = grd1.GetRowCellValue(I, Me.colProduto)
            If strProduto = Me.txtNomePro.Text Then
                bolProduto = True
            End If
        Next

        Dim Index As Integer = Nothing
        If bolProduto = False Then
            With Me.tbCusto.Rows
                .Add()
                Index = .Count - 1
                .Item(Index).Item("Produto") = Me.txtNomePro.Text
                .Item(Index).Item("CodProd") = strCodProd
                .Item(Index).Item("CodigoPeca") = strCodProdPeca
            End With
        End If
        LimparProd()
        Ajuste()

        If Me.grd1.RowCount > 0 Then
            Me.picImagem.Visible = False
        End If
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        If Me.grd1.RowCount > 0 Then
            Me.GridControl1.ShowPrintPreview()
        End If
    End Sub

    Private Sub btnConsulta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConsulta.Click
        ConsultarCotacao()
    End Sub

    Private Sub btnConsulta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.EditValueChanged
        ConsultarCotacao()
    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If MsgBox("Deseja realmente limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Limpar()
        End If
    End Sub

    Private Sub grd1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grd1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim Index As Integer = Me.grd1.FocusedRowHandle
            Me.grd1.FocusedRowHandle = Index + 1
        End If
    End Sub

    Private Sub btnRelVenc_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelVenc.ItemClick
        If Me.grd1.RowCount > 0 Then
            Dim rel As New relCotacao2

            Dim Index As Integer = Nothing
            Dim dblTotal As Double
            With rel

                Dim dtProduto As DataTable = CarregarDataTable("Select Cotacao.CodProd, Produto.Nome, Produto.CodigoInterno From Cotacao Left Join Produto On Cotacao.CodProd = Produto.Codigo Where CodOrdem = " & Me.txtCodTab.Text & " Group By Cotacao.CodProd, Produto.Nome, Produto.CodigoInterno")

                If dtProduto.Rows.Count > 0 Then
                    For I As Integer = 0 To dtProduto.Rows.Count - 1
                        Dim codProd As Integer = dtProduto.Rows.Item(I).Item("CodProd").ToString
                        Dim strProd As String = dtProduto.Rows.Item(I).Item("Nome").ToString
                        Dim strCodigo As String = dtProduto.Rows.Item(I).Item("CodigoInterno").ToString
                        Dim dtCotacao As DataTable = CarregarDataTable("Select Cotacao.CodProd, Cotacao.Valor, Cotacao.CodFor, Fornecedor.Nome, Fornecedor.Telefone From Cotacao Left Join Fornecedor on Cotacao.CodFor = Fornecedor.Codigo Where Valor=(Select Min(Valor) From Cotacao Where Valor > 0 And CodOrdem=" & Me.txtCodTab.Text & " And CodProd=" & codProd & " And Cotacao.CodConfig=" & CodConfig & ") And CodOrdem=" & Me.txtCodTab.Text & " And CodProd=" & codProd & " And Cotacao.CodConfig=" & CodConfig & "")

                        For J As Integer = 0 To dtCotacao.Rows.Count - 1

                            rel.tbPed.Rows.Add()
                            Index = rel.tbPed.Rows.Count - 1
                            rel.tbPed.Rows.Item(Index).Item("CodProd") = strCodigo
                            rel.tbPed.Rows.Item(Index).Item("Produto") = strProd
                            rel.tbPed.Rows.Item(Index).Item("CodFor") = dtCotacao.Rows.Item(J).Item("CodFor").ToString
                            rel.tbPed.Rows.Item(Index).Item("Valor") = dtCotacao.Rows.Item(J).Item("Valor").ToString
                            rel.tbPed.Rows.Item(Index).Item("Fornecedor") = dtCotacao.Rows.Item(J).Item("Nome").ToString
                            rel.tbPed.Rows.Item(Index).Item("Telefone") = dtCotacao.Rows.Item(J).Item("TeleFone").ToString

                            dblTotal = dblTotal + dtCotacao.Rows.Item(J).Item("Valor").ToString
                        Next

                    Next
                End If

                .lblTotal.Text = dblTotal.ToString("0.000")
                .lblTitulo.Text = .lblTitulo.Text & Space(10) & "De " & Me.dtData.Text
                .picLogo.Image = LogoTipo
                .ShowPreview()
            End With
        End If
    End Sub
End Class