Imports Nano.clsFuncoes
Public Class frmCampanha

    Dim bolAlterar As Boolean = False

    Dim IndexGrid As Integer
    Dim strCodProdAlterar As String
    Dim strCodigoProduto As String
    Dim strValorAnt As String
    Dim strValorCusto As String

    Dim strNomeCampanha As String = ""
    Dim strDataCampanha As String = ""
    Dim strDataFinalCampanha As String = ""
    Dim strCodigoCampanha As String = ""

    Dim strLocal As String = ""
    Dim strStatusCampanha As String = ""
    Private Sub frmCampanha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Me.Tag = "CONSULTA" Then
            Me.tabProd.Visible = True
            Me.GroupControl1.Width = 489
            Me.Text = "Consulta Campanha"
            Me.txtCampanha.Properties.ReadOnly = True
            Me.txtCampanha.Size = New System.Drawing.Size(540, 20)

            Me.btnAdd.Enabled = False

            Me.btnConsulta.Visible = True

            Me.colExcluir.Visible = False

            Me.dtData.Properties.ReadOnly = True

            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            Me.btnDelete.Enabled = False

            Me.tabProd.Enabled = False
            Me.btnFinalizar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnExcel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.BarButtonItem5.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.colCodProd.Visible = False

            Timer1.Start()
        ElseIf Me.Tag = "ALTERA" Then
            Me.tabProd.Visible = True
            Me.GroupControl1.Width = 489
            Me.Text = "Alteração de Campanha"
            Me.txtCampanha.Properties.ReadOnly = True
            Me.txtCampanha.Size = New System.Drawing.Size(540, 20)
            Me.btnConsulta.Visible = True
            Me.dtData.Properties.ReadOnly = True
            Me.btnFinalizar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnExcel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.BarButtonItem5.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.colCodProd.Visible = False

        ElseIf Me.Tag = "FINALIZAR" Then
            Me.tabProd.Visible = True
            Me.GroupControl1.Width = 489
            Me.Text = "Finalizar Campanha"
            Me.txtCampanha.Properties.ReadOnly = True
            Me.txtCampanha.Size = New System.Drawing.Size(540, 20)
            Me.btnConsulta.Visible = True
            Me.dtData.Properties.ReadOnly = True
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnAdd.Enabled = False
            Me.colExcluir.Visible = False
            Me.dtData.Properties.ReadOnly = True
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnDelete.Enabled = False
            Me.tabProd.Enabled = False
            Me.btnExcel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.BarButtonItem5.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.colCodProd.Visible = False

        ElseIf Me.Tag = "EXCEL" Then
            Me.btnExcel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.BarButtonItem5.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnLimpar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnFinalizar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.tabProd.Visible = False
            Me.GroupControl1.Height = 575
            Me.pb1.Location = New Point(2, 528)
            Me.btnConsulta.Visible = False
            Me.txtCampanha.Size = New System.Drawing.Size(561, 20)
            Me.colCodProd.BestFit()
            Me.colCodProd.Visible = True
            Me.colCodigoInterno.VisibleIndex = 1
            Me.GridView1.ClearSorting()
            Me.colCodProd.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

        ElseIf Me.Tag = "ANDAMENTO" Then
            Me.tabProd.Visible = True
            Me.GroupControl1.Width = 489
            Me.Text = "Campanhas em Andamento"
            Me.txtCampanha.Properties.ReadOnly = True
            Me.txtCampanha.Size = New System.Drawing.Size(540, 20)

            Me.btnAdd.Enabled = False
            Me.btnConsulta.Visible = True
            Me.dtData.Properties.ReadOnly = True
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.tabProd.Enabled = False
            Me.btnFinalizar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnExcel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.BarButtonItem5.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.colCodProd.Visible = False
        Else
            Me.tabProd.Visible = True
            Me.GroupControl1.Width = 489
            Me.txtCampanha.Size = New System.Drawing.Size(561, 20)
            Me.btnConsulta.Visible = False
            Me.btnFinalizar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.BarButtonItem5.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnExcel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            Me.colCodigoInterno.VisibleIndex = 0
            Me.colCodigo.Visible = False

        End If

        Me.dtData.EditValue = Date.Today
        Me.dtFinal.EditValue = Date.Today
    End Sub

    Private Sub txtCampanha_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtCampanha.EditValueChanging

    End Sub

    Private Sub txtCampanha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCampanha.KeyDown
        If Me.Tag = "CADASTRA" Then Exit Sub
        If e.KeyCode = Keys.F10 Then
            Conslutar()
        End If
    End Sub

    Private Sub txtCampanha_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCampanha.Leave
        If Me.Tag = "CONSULTA" Then Exit Sub
        VerificarCampanha()
        If Me.Tag = "ALTERA" Then
            If Me.txtCampanha.Text = "" And strNomeCampanha <> "" Then
                MsgBox("Nome da campanha é obrigatório!", MsgBoxStyle.Information)
                Me.txtCampanha.Focus()
            End If
        Else
            If Me.txtCampanha.Text <> "" Then
                Me.txtCodPro.Focus()
            End If
        End If

    End Sub
    Private Sub VerificarCampanha()
        If Me.txtCampanha.Text = "" Then Exit Sub

        Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM Campanha where NomeCampanha = '" & Me.txtCampanha.Text & "' and CodConfig = " & CodConfig)

        If dt.Rows.Count > 0 Then
            'If Me.Tag = "ALTERA" Then
            If Me.txtCampanha.Text = strNomeCampanha Then
                Exit Sub
            End If
            'Else

            'End If
            MsgBox("Nome da campanha já utilizado!", MsgBoxStyle.Information)
            Me.txtCampanha.ResetText()
            Me.txtCampanha.Focus()
        End If
        'If Me.Tag = "ALTERA" Then
        If strNomeCampanha <> "" Then
            Atualizar("UPDATE Campanha set NomeCampanha = '" & Me.txtCampanha.Text & "' where NomeCampanha = '" & strNomeCampanha & "' and CodConfig = " & CodConfig)
        End If
        strNomeCampanha = Me.txtCampanha.Text
        'End If
    End Sub

    Private Sub InserirProduto(ByVal parPesquisaPorNome As Boolean)
        If Validar(Me.dtData) = False Then Exit Sub

        Dim dtProd As DataTable

        If parPesquisaPorNome = False Then
            If Me.txtCodPro.Text = "" Then Exit Sub

            Dim strTamanhoCod As String = ""

            Dim vetCod As Array = Split(Me.txtCodPro.Text.Trim, "-")
            Dim strCodProTam As String = vetCod(0).ToString
            Me.txtCodPro.Text = strCodProTam
            If vetCod.Length > 1 Then
                strTamanhoCod = vetCod(1).ToString
            End If

            dtProd = CarregarDataTable("Select Produto.Codigo, Produto.Nome, Produto.CodigoInterno, Valor, Inativo, ValorCusto from Produto where CodigoInterno ='" & Me.txtCodPro.Text.Trim & "' or CodigoBarra = '" & Me.txtCodPro.Text.Trim & "'")
            If dtProd.Rows.Count = 0 Then
                Dim dtCodBarra As DataTable = CarregarDataTable("SELECT CodProd FROM CodigoBarra where CodigoBarra = '" & Me.txtCodPro.Text & "' and Produto = '' or CodigoBarra = '" & Me.txtCodPro.Text & "' and Produto is null")
                If dtCodBarra.Rows.Count > 0 Then
                    CodigoDoProduto = dtCodBarra.Rows.Item(0).Item("CodProd").ToString
                    dtProd = CarregarDataTable("Select Produto.Codigo, Produto.Nome, Produto.CodigoInterno, Valor, Inativo, ValorCusto from Produto where Codigo=" & CodigoDoProduto)
                End If
            End If
        Else
            dtProd = CarregarDataTable("Select Produto.Codigo, Produto.Nome, Produto.CodigoInterno, Valor, Inativo, ValorCusto from Produto where Codigo=" & CodigoDoProduto)

        End If

        If dtProd.Rows.Count > 0 Then

            With dtProd.Rows.Item(0)
                If dtProd.Rows.Item(0).Item("Inativo") = True Then
                    MsgBox("Produto Inativo!", MsgBoxStyle.Information)
                    Me.txtCodPro.ResetText()
                    'Me.txtCodPro.Focus()
                    Exit Sub
                End If

                Me.txtValor.Text = dtProd.Rows.Item(0).Item("Valor")
                Me.txtValorAnt.Text = dtProd.Rows.Item(0).Item("Valor")


                strCodigoProduto = dtProd.Rows.Item(0).Item("Codigo")
                Dim dtCamp As DataTable = CarregarDataTable("SELECT ValorAnt FROM Campanha where codprod = " & strCodigoProduto & " and Status = 'Lancado'")
                If dtCamp.Rows.Count > 0 Then
                    If dtCamp.Rows.Item(0).Item("ValorAnt").ToString <> "" Then
                        Me.txtValorAnt.Text = dtCamp.Rows.Item(0).Item("ValorAnt")

                    End If
                End If
              
                Me.txtCodigoInterno.Text = .Item("CodigoInterno").ToString
                Me.txtCodPro.Text = dtProd.Rows.Item(0).Item("CodigoInterno")

                Me.txtNomePro.Text = dtProd.Rows.Item(0).Item("Nome").ToString
              
                strValorCusto = dtProd.Rows.Item(0).Item("ValorCusto")
                Me.txtValor.Focus()
            End With
        Else
            MsgBox("Produto não cadastrado!", MsgBoxStyle.Information)
            strValorCusto = ""
            Me.txtValorAnt.ResetText()
            Me.txtCodPro.ResetText()
            Me.txtValor.ResetText()
            Me.txtNomePro.ResetText()
            Me.txtCodPro.Focus()
        End If
    End Sub

    Private Sub txtCodPro_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodPro.ButtonClick
        Dim frm As New frmConProduto
        frm.Tag = "VENDA"
        CodigoDoProduto = -1
        frm.ShowDialog()
        If CodigoDoProduto = -1 Then Exit Sub
        InserirProduto(True)
    End Sub

    Private Sub txtCodPro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodPro.KeyDown
        If e.KeyCode = Keys.F10 Then
            Dim frm As New frmConProduto
            frm.Tag = "VENDA"
            CodigoDoProduto = -1
            frm.ShowDialog()
            If CodigoDoProduto = -1 Then Exit Sub
            InserirProduto(True)
        End If
    End Sub

    Private Sub txtCodPro_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPro.Leave
        If Me.txtCodPro.Text.Trim = "" Then Exit Sub

        InserirProduto(False)


    End Sub
    Private Sub AtualizaGrid(ByVal parCampanha As String)
        CarregarDados("SELECT Campanha.Codigo, CodProd, Campanha.CodigoInterno, CodInternoAnt, Campanha.Valor, ValorAnt, " & _
        "convert(bit,'False') as Excluir, Produto.Nome as Produto, Produto.ValorCusto FROM Campanha left join Produto on " & _
        "Campanha.CodProd = Produto.Codigo where NomeCampanha = '" & parCampanha & "' and CodConfig = " & CodConfig, Me.GridControl1)

    End Sub


    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Validar(Me.txtCampanha) = False Then Exit Sub
        If Validar(Me.dtData) = False Then Exit Sub
        If Validar(Me.dtFinal) = False Then Exit Sub
        If Validar(Me.txtCodPro) = False Then Exit Sub
        If Validar(Me.txtNomePro) = False Then Exit Sub
        If Validar(Me.txtValor) = False Then Exit Sub
        If Validar(Me.txtValorAnt) = False Then Exit Sub

        Me.txtValor.Focus()

        If VerificarProduto() = True Then Exit Sub


        ' VerificarCampanha()


        Me.picFundo.Visible = False
        With Me.tbProd.Rows

            If bolAlterar = False Then
                '.Add()
                'Dim Index As Integer = .Count - 1

                '.Item(Index).Item("CodProd") = strCodigoProduto
                '.Item(Index).Item("CodigoInterno") = Me.txtCodigoInterno.Text
                '.Item(Index).Item("Produto") = Me.txtNomePro.Text
                '.Item(Index).Item("Valor") = Me.txtValor.Text
                '.Item(Index).Item("ValorAnt") = strValorAnt
                '.Item(Index).Item("CodInternoAnt") = Me.txtCodPro.Text

                '.Item(Index).Item("ValorCusto") = strValorCusto

                '.Item(Index).Item("Excluir") = False

                Dim strStatus As String = "Pendente"
                If strStatusCampanha = "Lancado" Then
                    strStatus = "Lancado"
                End If


                Inserir("INSERT INTO Campanha (CodProd, CodigoInterno, Valor, NomeCampanha, Data, ValorAnt, " & _
                "CodInternoAnt, CodConfig, Status, DataFinal) VALUES (" & strCodigoProduto & ",'" & Me.txtCodigoInterno.Text & "'," & Num(Me.txtValor.Text) & "," & _
                "'" & Me.txtCampanha.Text & "','" & Me.dtData.Text & "'," & Num(Me.txtValorAnt.Text) & ",'" & Me.txtCodPro.Text & "'," & CodConfig & ",'" & strStatus & "','" & Me.dtFinal.Text & "')")

                If strStatusCampanha = "Lancado" Then
                    Dim dblValCusto As Double = strValorCusto
                    Dim dblVal As Double = Me.txtValor.Text
                    Dim dblLucro As Double = dblVal - dblValCusto
                    Dim dblMargem As Double = (dblLucro * 100) / dblValCusto
                    Dim strPor As String = dblMargem
                    If strPor <> "+Infinito" And strPor <> "NaN (Não é um número)" Then
                        If TresCasasDecimais = True Then
                            strPor = dblMargem.ToString("0.000")
                        Else
                            strPor = dblMargem.ToString("0.00")
                        End If
                    Else
                        strPor = ""
                    End If
                    Atualizar("UPDATE Produto set CodigoInterno = '" & Me.txtCodigoInterno.Text & "', Valor = " & Num(Me.txtValor.Text) & ", " & _
                    "Porcentagens = '" & strPor & "' FROM Produto where Codigo = " & strCodigoProduto)
                End If

            Else

                'grd1.SetRowCellValue(IndexGrid, Me.colProduto, Me.txtNomePro.Text)
                'grd1.SetRowCellValue(IndexGrid, Me.colCodProd, strCodigoProduto)
                'grd1.SetRowCellValue(IndexGrid, Me.colCodigoInterno, Me.txtCodigoInterno.Text.Trim)
                'grd1.SetRowCellValue(IndexGrid, Me.colValor, Me.txtValor.Text.Trim)

                'grd1.SetRowCellValue(IndexGrid, Me.colValorAnt, strValorAnt)
                'grd1.SetRowCellValue(IndexGrid, Me.colCodInternoAnt, Me.txtCodPro.Text)

                'grd1.SetRowCellValue(IndexGrid, Me.colValorCusto, strValorCusto)

                Atualizar("UPDATE Campanha set CodProd = " & strCodigoProduto & ", CodigoInterno = '" & Me.txtCodigoInterno.Text & "', " & _
                "Valor = " & Num(Me.txtValor.Text) & ", ValorAnt = " & Num(Me.txtValorAnt.Text) & ", CodInternoAnt = '" & Me.txtCodPro.Text & "' " & _
                "where Codigo = " & strCodigoCampanha)

            End If
            Me.txtValorAnt.BackColor = Color.White
            Me.txtNomePro.BackColor = Color.White
            Me.txtCodPro.BackColor = Color.White
            Me.txtCodigoInterno.BackColor = Color.White
            Me.txtValor.BackColor = Color.White
            Me.btnAdd.Text = "Adicionar"
            Me.btnAdd.Image = My.Resources.edit_add
            bolAlterar = False
        End With

        AtualizaGrid(Me.txtCampanha.Text)
        strCodigoCampanha = ""
        Me.grpItens.Text = "Nº Itens : " & Me.grd1.RowCount & " "
        Me.txtValor.ResetText()
        Me.txtCodPro.ResetText()
        Me.txtValorAnt.ResetText()
        txtNomePro.ResetText()
        Me.txtCodPro.Tag = ""
        Me.txtCodigoInterno.ResetText()
        strValorAnt = ""
        strValorCusto = ""
        Me.txtCodPro.Focus()
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        Me.txtCodPro.Focus()
    End Sub

    Private Function VerificarProduto() As Boolean
        Dim I As Integer
        If bolAlterar = True Then
            If strCodigoProduto = strCodProdAlterar Then
                Return False
                Exit Function
            End If
        End If
        For I = 0 To Me.grd1.RowCount - 1
            Dim strCodProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodProd)

            If strCodProd = strCodigoProduto Then

                MsgBox("Produto já adicionado!", MsgBoxStyle.Information)
                Return True
                Exit Function
            End If
        Next

        Return False

    End Function

    Private Sub txtAlt_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlt.DoubleClick
        If grd1.FocusedRowHandle < 0 Then Exit Sub

        If Me.Tag = "CONSULTA" Then Exit Sub
        If strStatusCampanha = "Lancado" Then Exit Sub
        bolAlterar = True
        IndexGrid = grd1.FocusedRowHandle
        Me.grd1.OptionsView.ShowAutoFilterRow = False
        Me.grd1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.txtValorAnt.BackColor = Color.Bisque
        Me.txtNomePro.BackColor = Color.Bisque
        Me.txtCodigoInterno.BackColor = Color.Bisque
        Me.txtCodPro.BackColor = Color.Bisque
        Me.txtValor.BackColor = Color.Bisque
        Me.btnAdd.Text = "Alterar"
        Me.btnAdd.Image = My.Resources.Alterar

        With grd1
            strCodigoCampanha = .GetRowCellDisplayText(IndexGrid, Me.colCodigo)
            Me.txtNomePro.Text = .GetRowCellDisplayText(IndexGrid, Me.colProduto)
            strCodigoProduto = .GetRowCellDisplayText(IndexGrid, Me.colCodProd)
            Me.txtCodPro.Text = .GetRowCellDisplayText(IndexGrid, Me.colCodInternoAnt)
            Me.txtValor.Text = .GetRowCellDisplayText(IndexGrid, Me.colValor)
            strCodProdAlterar = .GetRowCellDisplayText(IndexGrid, Me.colCodProd)

            Me.txtCodigoInterno.Text = .GetRowCellDisplayText(IndexGrid, Me.colCodigoInterno)
            Me.txtValorAnt.Text = .GetRowCellDisplayText(IndexGrid, Me.colValorAnt)

            strValorCusto = .GetRowCellDisplayText(IndexGrid, Me.colValorCusto)
        End With


    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If bolAlterar = True Then MsgBox("Existe um item sendo alterado, conclua a alteração antes de excluir algum item!", MsgBoxStyle.Information) : Exit Sub
        If grd1.RowCount = 0 Then Exit Sub

        Dim I As Integer
        Dim bolExcluirVarios As Boolean = False
        For I = 0 To Me.grd1.RowCount - 1
            If I <= Me.grd1.RowCount - 1 Then
                If Me.grd1.GetRowCellValue(I, Me.colExcluir) = True Then
                    If bolExcluirVarios = False Then
                        If MsgBox("Deseja realmente excluir estes items?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            bolExcluirVarios = True
                            'Me.grd1.DeleteRow(I)
                            'I = I - 1




                            Excluir("DELETE FROM Campanha where Codigo = " & Me.grd1.GetRowCellValue(I, Me.colCodigo))
                            If Me.Tag = "ALTERA" Or Me.Tag = "ANDAMENTO" Then
                                If strStatusCampanha = "Lancado" Then
                                    Dim strValAnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colValorAnt)
                                    Dim dblValCusto As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto)
                                    Dim dblLucro As Double = strValAnt - dblValCusto
                                    Dim dblMargem As Double = (dblLucro * 100) / dblValCusto
                                    Dim strPor As String = dblMargem
                                    If strPor <> "+Infinito" And strPor <> "NaN (Não é um número)" Then
                                        If TresCasasDecimais = True Then
                                            strPor = dblMargem.ToString("0.000")
                                        Else
                                            strPor = dblMargem.ToString("0.00")
                                        End If
                                    Else
                                        strPor = ""
                                    End If
                                    Dim strCodProd As String = Me.grd1.GetRowCellValue(grd1.FocusedRowHandle, Me.colCodProd)
                                    Atualizar("UPDATE Produto set  Valor = " & Num(strValAnt) & ", " & _
                                    "Porcentagens = '" & strPor & "' FROM Produto where Codigo = " & strCodProd)

                                End If

                            End If

                        Else
                            Exit Sub
                        End If

                    Else
                        Excluir("DELETE FROM Campanha where Codigo = " & Me.grd1.GetRowCellValue(I, Me.colCodigo))
                        If Me.Tag = "ALTERA" Or Me.Tag = "ANDAMENTO" Then
                            If strStatusCampanha = "Lancado" Then
                                Dim strValAnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colValorAnt)
                                Dim dblValCusto As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto)
                                Dim dblLucro As Double = strValAnt - dblValCusto
                                Dim dblMargem As Double = (dblLucro * 100) / dblValCusto
                                Dim strPor As String = dblMargem
                                If strPor <> "+Infinito" And strPor <> "NaN (Não é um número)" Then
                                    If TresCasasDecimais = True Then
                                        strPor = dblMargem.ToString("0.000")
                                    Else
                                        strPor = dblMargem.ToString("0.00")
                                    End If
                                Else
                                    strPor = ""
                                End If
                                Dim strCodProd As String = Me.grd1.GetRowCellValue(grd1.FocusedRowHandle, Me.colCodProd)
                                Atualizar("UPDATE Produto set  Valor = " & Num(strValAnt) & ", " & _
                                "Porcentagens = '" & strPor & "' FROM Produto where Codigo = " & strCodProd)

                            End If

                        End If
                        'Me.grd1.DeleteRow(I)
                        'I = I - 1
                    End If
                End If
            End If

        Next


        If bolExcluirVarios = False Then
            If MsgBox("Deseja realmente excluir este item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                'Me.grd1.DeleteRow(grd1.FocusedRowHandle)
                Excluir("DELETE FROM Campanha where Codigo = " & Me.grd1.GetRowCellValue(grd1.FocusedRowHandle, Me.colCodigo))
                If Me.Tag = "ALTERA" Or Me.Tag = "ANDAMENTO" Then
                    If strStatusCampanha = "Lancado" Then
                        Dim strValAnt As String = Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colValorAnt)
                        Dim dblValCusto As Double = Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colValorCusto)
                        Dim dblLucro As Double = strValAnt - dblValCusto
                        Dim dblMargem As Double = (dblLucro * 100) / dblValCusto
                        Dim strPor As String = dblMargem
                        If strPor <> "+Infinito" And strPor <> "NaN (Não é um número)" Then
                            If TresCasasDecimais = True Then
                                strPor = dblMargem.ToString("0.000")
                            Else
                                strPor = dblMargem.ToString("0.00")
                            End If
                        Else
                            strPor = ""
                        End If
                        Dim strCodProd As String = Me.grd1.GetRowCellValue(grd1.FocusedRowHandle, Me.colCodProd)
                        Atualizar("UPDATE Produto set  Valor = " & Num(strValAnt) & ", " & _
                        "Porcentagens = '" & strPor & "' FROM Produto where Codigo = " & strCodProd)

                    End If
                End If
            End If
        End If
        AtualizaGrid(Me.txtCampanha.Text)
        If Me.grd1.RowCount = 0 Then
            Me.picFundo.Visible = True
        End If
        Me.grpItens.Text = "Nº Itens : " & Me.grd1.RowCount & " "
    End Sub
    Private Sub Limpar()
        If Me.Tag = "ALTERA" Then
            Me.txtCampanha.Properties.ReadOnly = True
            Me.dtData.Properties.ReadOnly = True
        End If
        AtualizaGrid("LIMPAR GRID")
        strNomeCampanha = ""
        strDataCampanha = ""
        Me.txtCampanha.ResetText()
        Me.dtData.EditValue = Date.Today

        Me.txtCodPro.ResetText()
        Me.txtNomePro.ResetText()
        Me.txtValor.ResetText()
        Me.txtCodigoInterno.ResetText()
        Me.txtValorAnt.ResetText()
        strValorCusto = ""
        Me.tbProd.Rows.Clear()
        strCodigoCampanha = ""
        Me.grpItens.Text = "Nº Itens : 0 "
        Me.picFundo.Visible = True
        Me.txtCampanha.Focus()
    End Sub
    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        If Validar(Me.dtData) = False Then Exit Sub
        If Validar(Me.txtCampanha) = False Then Exit Sub

        If Me.grd1.RowCount = 0 Then Exit Sub


        If MsgBox("Deseja realmente concluir a campanha?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            'VerificarCampanha()
            If MsgBox("Deseja realmente concluir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

            Dim I As Integer

            For I = 0 To Me.grd1.RowCount - 1
                Dim strCodProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodProd)
                Dim strCodigoInterno As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)

                Dim strValAnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colValorAnt)
                Dim strCodIntAnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodInternoAnt)

                Dim dblValCusto As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto)
                Dim dblVal As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValor)

                Dim dblLucro As Double = dblVal - dblValCusto
                Dim dblMargem As Double = (dblLucro * 100) / dblValCusto
                Dim strPor As String = dblMargem

                If strPor <> "+Infinito" And strPor <> "NaN (Não é um número)" Then
                    If TresCasasDecimais = True Then
                        strPor = dblMargem.ToString("0.000")
                    Else
                        strPor = dblMargem.ToString("0.00")
                    End If
                Else
                    strPor = ""
                End If


                'Inserir("INSERT INTO Campanha (CodProd, CodigoInterno, Valor, NomeCampanha, Data, ValorAnt, " & _
                '"CodInternoAnt, CodConfig) VALUES (" & strCodProd & ",'" & strCodigoInterno & "'," & Num(dblVal) & "," & _
                '"'" & Me.txtCampanha.Text & "','" & Me.dtData.Text & "'," & Num(strValAnt) & ",'" & strCodIntAnt & "'," & CodConfig & ")")

                Atualizar("UPDATE Produto set CodigoInterno = '" & strCodigoInterno & "', Valor = " & Num(dblVal) & ", " & _
                "Porcentagens = '" & strPor & "' FROM Produto where Codigo = " & strCodProd)

            Next

            Atualizar("UPDATE Campanha set Status = 'Lancado' where NomeCampanha = '" & Me.txtCampanha.Text & "' and CodConfig = " & CodConfig)


            MsgBox("Campanha concluída com sucesso!", MsgBoxStyle.Information)

            Limpar()
        End If



    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If MsgBox("Deseja realmente limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Limpar()
        End If
    End Sub

    Private Sub txtCodigoInterno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoInterno.Leave
        If Me.txtCodigoInterno.Text = "" Then Exit Sub

        If Me.txtCodigoInterno.Text = Me.txtCodPro.Text Then Exit Sub
        PesquisarProduto(txtCodigoInterno, "CodigoInterno")
        If Me.txtCodigoInterno.Text = "" Then Exit Sub
        PesquisarProduto(txtCodigoInterno, "CodigoBarra")
    End Sub

    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click
        Conslutar()
    End Sub
    Private Sub Conslutar()
        ConsultaPedido = ""
        Dim frm As New frmConPed
        frm.Tag = "CAMPANHA" & Me.Tag
        frm.ShowDialog()

        If ConsultaPedido <> "" Then
            CarregaForm()
            CarregaForm()
        End If

        If strStatusCampanha = "Lancado" Then
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Else
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If
    End Sub

    Private Sub CarregaForm()
        Dim dt As DataTable = CarregarDataTable("SELECT Campanha.Codigo, Campanha.CodProd, Campanha.CodigoInterno, " & _
        "CodInternoAnt, Produto.Nome, Campanha.Valor, Campanha.ValorAnt, convert(varchar(10),Campanha.Data,103) as Data, " & _
        "NomeCampanha, ValorCusto, Campanha.Status, convert(varchar(10),Campanha.DataFinal,103) as DataFinal FROM Campanha left join Produto on Campanha.CodProd = Produto.Codigo " & _
        "where Campanha.CodConfig = " & CodConfig & " and Campanha.NomeCampanha = '" & ConsultaPedido & "'")

        If dt.Rows.Count > 0 Then
            If Me.Tag = "ALTERA" Or Me.Tag = "FINALIZAR" Then
                Me.txtCampanha.Properties.ReadOnly = False
                Me.dtData.Properties.ReadOnly = False
            End If
            Me.dtData.Text = dt.Rows.Item(0).Item("Data").ToString
            Me.dtFinal.Text = dt.Rows.Item(0).Item("DataFinal").ToString
            Me.txtCampanha.Text = dt.Rows.Item(0).Item("NomeCampanha").ToString
            strNomeCampanha = dt.Rows.Item(0).Item("NomeCampanha").ToString
            strDataCampanha = dt.Rows.Item(0).Item("Data").ToString
            strDataFinalCampanha = dt.Rows.Item(0).Item("DataFinal").ToString

            strStatusCampanha = dt.Rows.Item(0).Item("Status").ToString
            Dim I As Integer
            'With Me.tbProd.Rows
            '    .Clear()
            '    For I = 0 To dt.Rows.Count - 1
            '        .Add()
            '        .Item(I).Item("Codigo") = dt.Rows.Item(I).Item("Codigo").ToString
            '        .Item(I).Item("CodProd") = dt.Rows.Item(I).Item("CodProd").ToString
            '        .Item(I).Item("CodigoInterno") = dt.Rows.Item(I).Item("CodigoInterno").ToString
            '        .Item(I).Item("Produto") = dt.Rows.Item(I).Item("Nome").ToString
            '        .Item(I).Item("Valor") = dt.Rows.Item(I).Item("Valor").ToString
            '        .Item(I).Item("ValorAnt") = dt.Rows.Item(I).Item("ValorAnt").ToString
            '        .Item(I).Item("CodInternoAnt") = dt.Rows.Item(I).Item("CodInternoAnt").ToString
            '        .Item(I).Item("ValorCusto") = dt.Rows.Item(I).Item("ValorCusto").ToString
            '        .Item(I).Item("Excluir") = False
            '    Next
            'End With

            AtualizaGrid(ConsultaPedido)
            Me.grpItens.Text = "Nº Itens : " & Me.grd1.RowCount & " "

            Me.picFundo.Visible = False
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Bar3.ItemLinks(3).BeginGroup = False
        Timer1.Stop()
    End Sub

    Private Sub btnRemover_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemover.Click
        If Validar(Me.txtCodPro2) = False Then Exit Sub
        If Validar(txtNomePro2) = False Then Exit Sub


        Dim I As Integer


        Dim bolTem As Boolean = False


        For I = 0 To grd1.RowCount - 1
            Dim strProduto As String = Me.grd1.GetRowCellDisplayText(I, Me.colProduto).Trim
            If strProduto = Me.txtNomePro2.Text Then
                Excluir("DELETE FROM Campanha where Codigo = " & Me.grd1.GetRowCellValue(I, Me.colCodigo))
                'Me.grd1.DeleteRow(I)
                bolTem = True
                Exit For
            End If
        Next

        AtualizaGrid(Me.txtCampanha.Text)

        txtNomePro2.ResetText()

        Me.txtCodPro2.Tag = ""

        Me.txtCodPro2.ResetText()
        Me.txtCodPro2.Focus()

        If bolTem = False Then
            MsgBox("Produto não localizado no pedido!", MsgBoxStyle.Information)
        Else
            Me.grpItens.Text = "Nº Itens : " & Me.grd1.RowCount & " "

        End If
    End Sub
    Private Sub InserirProduto2(ByVal parPesquisaPorNome As Boolean)
        Dim dtProd As DataTable

        If parPesquisaPorNome = False Then
            If Me.txtCodPro2.Text = "" Then Exit Sub

            Dim strTamanhoCod As String = ""

            Dim vetCod As Array = Split(Me.txtCodPro2.Text.Trim, "-")
            Dim strCodProTam As String = vetCod(0).ToString
            Me.txtCodPro2.Text = strCodProTam
            If vetCod.Length > 1 Then
                strTamanhoCod = vetCod(1).ToString
            End If

            dtProd = CarregarDataTable("Select Produto.Codigo, Produto.Nome, Produto.CodigoInterno, Valor, Inativo, ValorCusto from Produto where CodigoInterno ='" & Me.txtCodPro2.Text.Trim & "' or CodigoBarra = '" & Me.txtCodPro2.Text.Trim & "'")
            If dtProd.Rows.Count = 0 Then
                Dim dtCodBarra As DataTable = CarregarDataTable("SELECT CodProd FROM CodigoBarra where CodigoBarra = '" & Me.txtCodPro.Text & "' and Produto = '' or CodigoBarra = '" & Me.txtCodPro.Text & "' and Produto is null")
                If dtCodBarra.Rows.Count > 0 Then
                    CodigoDoProduto = dtCodBarra.Rows.Item(0).Item("CodProd").ToString
                    dtProd = CarregarDataTable("Select  Produto.Codigo, Produto.Nome, Produto.CodigoInterno, Valor, Inativo, ValorCusto from Produto where Codigo=" & CodigoDoProduto)
                End If
            End If
        Else
            dtProd = CarregarDataTable("Select Produto.Codigo, Produto.Nome, Produto.CodigoInterno, Valor, Inativo, ValorCusto from Produto where Codigo=" & CodigoDoProduto)

        End If

        If dtProd.Rows.Count > 0 Then

            With dtProd.Rows.Item(0)
                If dtProd.Rows.Item(0).Item("Inativo") = True Then
                    MsgBox("Produto Inativo!", MsgBoxStyle.Information)
                    Me.txtCodPro.ResetText()
                    'Me.txtCodPro.Focus()
                    Exit Sub
                End If



                strCodigoProduto = dtProd.Rows.Item(0).Item("Codigo")

                Me.txtCodPro2.Text = dtProd.Rows.Item(0).Item("CodigoInterno")

                Me.txtNomePro2.Text = dtProd.Rows.Item(0).Item("Nome").ToString

                Me.btnRemover.Focus()
            End With
        Else
            MsgBox("Produto não cadastrado!", MsgBoxStyle.Information)

            Me.txtCodPro2.ResetText()

            Me.txtNomePro2.ResetText()
            Me.txtCodPro2.Focus()
        End If
    End Sub

    Private Sub txtCodPro2_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodPro2.ButtonClick
        Dim frm As New frmConProduto
        frm.Tag = "VENDA"
        CodigoDoProduto = -1
        frm.ShowDialog()
        If CodigoDoProduto = -1 Then Exit Sub
        InserirProduto2(True)
    End Sub

    Private Sub txtCodPro2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodPro2.KeyDown
        If e.KeyCode = Keys.F10 Then
            Dim frm As New frmConProduto
            frm.Tag = "VENDA"
            CodigoDoProduto = -1
            frm.ShowDialog()
            If CodigoDoProduto = -1 Then Exit Sub
            InserirProduto2(True)
        End If
    End Sub

    Private Sub txtCodPro2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPro2.Leave
        If Me.txtCodPro2.Text.Trim = "" Then Exit Sub

        InserirProduto2(False)


    End Sub

    Private Sub dtData_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtData.Leave
        If Me.Tag = "ALTERA" Then
            Dim strData As String = Me.dtData.Text

            If strData <> strDataCampanha And strDataCampanha <> "" Then
                Atualizar("UPDATE Campanha set Data = '" & strData & "' where NomeCampanha = '" & Me.txtCampanha.Text & "' and CodConfig = " & CodConfig)

            End If
        End If
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relCampanha

        rel.picLogo.Image = LogoTipo

        Dim I As Integer

        For I = 0 To Me.grd1.RowCount - 1
            With rel.tbProd.Rows
                .Add()
                .Item(I).Item("Produto") = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                .Item(I).Item("CodigoInterno") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)
                .Item(I).Item("Valor") = Me.grd1.GetRowCellDisplayText(I, Me.colValor)

            End With
        Next


        rel.lblQtd.Text = Me.grd1.RowCount

        rel.lblCampanha.Text = Me.txtCampanha.Text
        rel.lblData.Text = Me.dtData.Text

        rel.ShowPreview()
    End Sub

    Private Sub dtFinal_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtFinal.Leave
        If Me.Tag = "ALTERA" Then
            Dim strData As String = Me.dtFinal.Text

            If strData <> strDataFinalCampanha And strDataFinalCampanha <> "" Then
                Atualizar("UPDATE Campanha set DataFinal = '" & strData & "' where NomeCampanha = '" & Me.txtCampanha.Text & "' and CodConfig = " & CodConfig)

            End If
        End If
    End Sub

    Private Sub btnFinalizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFinalizar.ItemClick
        If Validar(Me.dtData) = False Then Exit Sub
        If Validar(Me.txtCampanha) = False Then Exit Sub
        If Me.grd1.RowCount = 0 Then Exit Sub
        If MsgBox("Deseja realmente finalizar a campanha?" & vbCrLf & "Ao finalizar a campanha os preços dos produtos voltarão aos valores anteriores à campanha.", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            'VerificarCampanha()
            If MsgBox("Deseja realmente finalizar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub


            Dim I As Integer

            For I = 0 To Me.grd1.RowCount - 1
                Dim strCodProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodProd)
                Dim strValAnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colValorAnt)
                Dim dblValCusto As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto)
                Dim dblLucro As Double = strValAnt - dblValCusto
                Dim dblMargem As Double = (dblLucro * 100) / dblValCusto
                Dim strPor As String = dblMargem
                If strPor <> "+Infinito" And strPor <> "NaN (Não é um número)" Then
                    If TresCasasDecimais = True Then
                        strPor = dblMargem.ToString("0.000")
                    Else
                        strPor = dblMargem.ToString("0.00")
                    End If
                Else
                    strPor = ""
                End If
                'Inserir("INSERT INTO Campanha (CodProd, CodigoInterno, Valor, NomeCampanha, Data, ValorAnt, " & _
                '"CodInternoAnt, CodConfig) VALUES (" & strCodProd & ",'" & strCodigoInterno & "'," & Num(dblVal) & "," & _
                '"'" & Me.txtCampanha.Text & "','" & Me.dtData.Text & "'," & Num(strValAnt) & ",'" & strCodIntAnt & "'," & CodConfig & ")")
                Atualizar("UPDATE Produto set  Valor = " & Num(strValAnt) & ", " & _
                "Porcentagens = '" & strPor & "' FROM Produto where Codigo = " & strCodProd)
            Next
            Atualizar("UPDATE Campanha set Status = 'Finalizado' where NomeCampanha = '" & Me.txtCampanha.Text & "' and CodConfig = " & CodConfig)
            MsgBox("Campanha finalizada com sucesso!", MsgBoxStyle.Information)
            Limpar()
        End If

    End Sub

    Private Sub txtValor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValor.Leave
        Me.btnAdd.Focus()
    End Sub

    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcel.ItemClick
        Me.ofd.Filter = "Excel Worksheets|*.xls"
        Me.ofd.FileName = ""
        If Me.ofd.ShowDialog() = DialogResult.OK Then
            strLocal = Me.ofd.FileName

            Try
                'CARREGA EXCEL NO DATATABLE
                Dim vetNome As Array = strLocal.Split("\")
                Dim intVetNome As Integer = vetNome.Length
                intVetNome = intVetNome - 1
                Dim strArquivo As String = vetNome(intVetNome).ToString.Replace(".xls", "")

                Dim vetLocal As Array
                vetLocal = Split(strLocal, strArquivo & ".")

                Dim dtExcel As DataTable = CarregarDataTableExcel(vetLocal(0), strArquivo)


                'CARREGA EXCEL NA GRID
                Dim CodInterno, Valor As String
                Dim intCount As Integer = 0
                Dim dtProduto As DataTable

                Me.tbProd.Rows.Clear()
                Me.picFundo.Visible = True
                Me.grpItens.Text = "" '"Nº Itens : " & Me.grd1.RowCount & " "

                pb1.Value = 0
                pb1.Maximum = dtExcel.Rows.Count
                Me.pb1.Visible = True

                For I As Integer = 0 To dtExcel.Rows.Count - 1
                    CodInterno = dtExcel.Rows.Item(I).Item("LINENUMBER").ToString.Trim
                    dtProduto = CarregarDataTable("Select Codigo, CodigoInterno, Nome, CodigoInterno, Valor, " & _
                    "ValorCusto From Produto Where CodigoInterno='" & CodInterno & "'")

                    If dtProduto.Rows.Count > 0 Then

                        Me.tbProd.Rows.Add()
                        Dim Index As Integer = Me.tbProd.Rows.Count - 1

                        Me.tbProd.Rows.Item(Index).Item("CodProd") = dtProduto.Rows.Item(0).Item("Codigo").ToString
                        Me.tbProd.Rows.Item(Index).Item("CodigoInterno") = dtProduto.Rows.Item(0).Item("CodigoInterno").ToString
                        Me.tbProd.Rows.Item(Index).Item("Produto") = dtProduto.Rows.Item(0).Item("Nome").ToString

                        Dim dlbValor As Double = dtExcel.Rows.Item(I).Item("PREÇO").ToString
                        Valor = dlbValor.ToString("0.000")
                        Me.tbProd.Rows.Item(Index).Item("Valor") = Valor
                        Me.tbProd.Rows.Item(Index).Item("ValorAnt") = dtProduto.Rows.Item(0).Item("Valor").ToString
                        Me.tbProd.Rows.Item(Index).Item("CodInternoAnt") = dtProduto.Rows.Item(0).Item("CodigoInterno").ToString

                        Me.tbProd.Rows.Item(Index).Item("ValorCusto") = dtProduto.Rows.Item(0).Item("ValorCusto").ToString

                        Me.tbProd.Rows.Item(Index).Item("Excluir") = False
                        intCount = intCount + 1
                    Else

                        Me.tbProd.Rows.Add()
                        Dim Index As Integer = Me.tbProd.Rows.Count - 1

                        Me.tbProd.Rows.Item(Index).Item("CodProd") = "" 'dtProduto.Rows.Item(0).Item("Codigo").ToString
                        Me.tbProd.Rows.Item(Index).Item("CodigoInterno") = dtExcel.Rows.Item(I).Item("LINENUMBER").ToString
                        Me.tbProd.Rows.Item(Index).Item("Produto") = dtExcel.Rows.Item(I).Item("DESCRIÇÃO").ToString.ToUpper.Trim

                        Dim dlbValor As Double = dtExcel.Rows.Item(I).Item("PREÇO").ToString
                        Valor = dlbValor.ToString("0.000")
                        Me.tbProd.Rows.Item(Index).Item("Valor") = Valor
                        Me.tbProd.Rows.Item(Index).Item("ValorAnt") = "" 'Valor
                        Me.tbProd.Rows.Item(Index).Item("CodInternoAnt") = dtExcel.Rows.Item(I).Item("LINENUMBER").ToString

                        Me.tbProd.Rows.Item(Index).Item("ValorCusto") = "0,000"

                        Me.tbProd.Rows.Item(Index).Item("Excluir") = False
                    End If


                    pb1.Value = pb1.Value + 1
                    Application.DoEvents()
                    System.Threading.Thread.Sleep(10)

                Next

                Me.picFundo.Visible = False
                Me.pb1.Visible = False
                Me.grpItens.Text = "Nº Itens Excel: " & Me.grd1.RowCount & " | " & "Nº Itens Cadastrados: " & intCount & ""
                Me.grd1.FocusedRowHandle = 0
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Me.GroupControl1.Focus()
        If Validar(Me.txtCampanha) = False Then Exit Sub
        If Validar(Me.dtData) = False Then Exit Sub
        If Validar(Me.dtFinal) = False Then Exit Sub

        If Me.grd1.RowCount = 0 Then Exit Sub


        If MsgBox("Deseja realmente salvar a campanha?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If MsgBox("Deseja realmente salvar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

            Dim index As Integer = -999997
            Me.grd1.FocusedRowHandle = index

            For I As Integer = 0 To Me.grd1.RowCount - 1
                Dim strCodProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodProd)

                If strCodProd <> "" Then

                    Dim strCodigoInterno As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)

                    Dim strValAnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colValorAnt)
                    Dim strCodIntAnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodInternoAnt)

                    Dim dblValCusto As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto)
                    Dim dblVal As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValor)

                    Dim dblLucro As Double = dblVal - dblValCusto
                    Dim dblMargem As Double = (dblLucro * 100) / dblValCusto
                    Dim strPor As String = dblMargem

                    If strPor <> "+Infinito" And strPor <> "NaN (Não é um número)" Then
                        If TresCasasDecimais = True Then
                            strPor = dblMargem.ToString("0.000")
                        Else
                            strPor = dblMargem.ToString("0.00")
                        End If
                    Else
                        strPor = ""
                    End If


                    Inserir("INSERT INTO Campanha (CodProd, CodigoInterno, Valor, NomeCampanha, Data, ValorAnt, " & _
                    "CodInternoAnt, CodConfig, Status, DataFinal) VALUES (" & strCodProd & ",'" & strCodigoInterno & "'," & Num(dblVal) & "," & _
                    "'" & Me.txtCampanha.Text & "','" & Me.dtData.Text & "'," & Num(strValAnt) & ",'" & strCodIntAnt & "'," & CodConfig & ",'Pendente','" & Me.dtFinal.Text & "')")

                End If
            Next

            MsgBox("Campanha salva com sucesso!", MsgBoxStyle.Information)

            Me.Close()
        End If
    End Sub
End Class