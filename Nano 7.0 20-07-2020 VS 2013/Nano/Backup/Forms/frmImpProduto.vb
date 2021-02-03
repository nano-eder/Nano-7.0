Imports Nano.clsFuncoes

Public Class frmImpProduto

    Dim strLocal As String = ""

    Private Sub Limpar()
        Me.pb1.Value = 0
        Me.grd1.FocusedRowHandle = 0
        Me.tbProd.Rows.Clear()
        Me.grpItens.Text = "Nº Itens : 0"
        Me.picFundo.Visible = True
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnAbrir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAbrir.ItemClick
        Me.ofd.Filter = "Excel Worksheets|*.xls"
        Me.ofd.FileName = ""

        Dim strColuna As String = ""
        If Me.rgpBoleto.SelectedIndex.ToString = "0" Then
            strColuna = "CodigoInterno"
        ElseIf Me.rgpBoleto.SelectedIndex.ToString = "1" Then
            strColuna = "CodigoBarra"
        ElseIf Me.rgpBoleto.SelectedIndex.ToString = "2" Then
            strColuna = "Nome"
        End If

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
                Dim CodInterno, Valor, ValorCusto, Peso, QtdEmb As String
                Dim intCount As Integer = 0
                Dim dtProduto As DataTable = Nothing
                Dim bolPassou As Boolean = False

                Me.tbProd.Rows.Clear()
                Me.picFundo.Visible = True
                pb1.Value = 0
                pb1.Maximum = dtExcel.Rows.Count
                Me.pb1.Visible = True

                For I As Integer = 0 To dtExcel.Rows.Count - 1
                    CodInterno = dtExcel.Rows.Item(I).Item(strColuna).ToString.Trim
                    If CodInterno <> "" Then
                        dtProduto = CarregarDataTable("Select Codigo, CodigoInterno, Nome, CodigoInterno, Valor, " & _
                        "ValorCusto From Produto Where " & strColuna & "='" & CodInterno & "'")
                        bolPassou = True
                    Else
                        dtProduto = CarregarDataTable("Select Codigo, CodigoInterno, Nome, CodigoInterno, Valor, " & _
                        "ValorCusto From Produto Where Codigo=0")
                        bolPassou = False
                    End If

                    If dtProduto.Rows.Count > 0 And bolPassou = True Then
                        Me.tbProd.Rows.Add()
                        Dim Index As Integer = Me.tbProd.Rows.Count - 1

                        Me.tbProd.Rows.Item(Index).Item("Codigo") = dtProduto.Rows.Item(0).Item("Codigo").ToString
                        Me.tbProd.Rows.Item(Index).Item("CodigoInterno") = dtProduto.Rows.Item(0).Item("CodigoInterno").ToString.ToUpper
                        Me.tbProd.Rows.Item(Index).Item("Nome") = dtProduto.Rows.Item(0).Item("Nome").ToString.ToUpper
                        Me.tbProd.Rows.Item(Index).Item("UnidadeMedida") = dtExcel.Rows.Item(I).Item("UnidadeMedida").ToString.ToUpper
                        Me.tbProd.Rows.Item(Index).Item("Grupo") = dtExcel.Rows.Item(I).Item("Grupo").ToString.ToUpper

                        Dim dlbValor As Double = dtExcel.Rows.Item(I).Item("Valor").ToString.Replace("R$", "")
                        Valor = dlbValor.ToString("0.000")
                        Me.tbProd.Rows.Item(Index).Item("Valor") = Valor
                        Me.tbProd.Rows.Item(Index).Item("ValorAnt") = Valor

                        Dim dlbValorCusto As Double = dtExcel.Rows.Item(I).Item("ValorCusto").ToString.Replace("R$", "")
                        ValorCusto = dlbValorCusto.ToString("0.000")
                        Me.tbProd.Rows.Item(Index).Item("ValorCusto") = ValorCusto
                        Me.tbProd.Rows.Item(Index).Item("ValorCustoAnt") = ValorCusto

                        Me.tbProd.Rows.Item(Index).Item("Fabricante") = dtExcel.Rows.Item(I).Item("Fabricante").ToString.ToUpper
                        Me.tbProd.Rows.Item(Index).Item("CodigoBarra") = dtExcel.Rows.Item(I).Item("CodigoBarra").ToString
                        Me.tbProd.Rows.Item(Index).Item("NCM") = dtExcel.Rows.Item(I).Item("NCM").ToString
                        'Me.tbProd.Rows.Item(Index).Item("Peso") = dtExcel.Rows.Item(I).Item("Peso").ToString
                        'Me.tbProd.Rows.Item(Index).Item("QtdEmb") = dtExcel.Rows.Item(I).Item("QtdEmb").ToString

                        Dim dlbPeso As Double = dtExcel.Rows.Item(I).Item("Peso").ToString
                        Peso = dlbPeso.ToString("0.000")
                        Me.tbProd.Rows.Item(Index).Item("Peso") = Peso

                        Dim dlbQtdEmb As Double = dtExcel.Rows.Item(I).Item("QtdEmb").ToString
                        QtdEmb = dlbQtdEmb.ToString("0.000")
                        Me.tbProd.Rows.Item(Index).Item("QtdEmb") = QtdEmb

                        Me.tbProd.Rows.Item(Index).Item("Obs") = dtExcel.Rows.Item(I).Item("Obs").ToString
                        Me.tbProd.Rows.Item(Index).Item("Excluir") = False
                        If Me.chkCusto.Checked = True Then
                            Dim dlbQtd As Double = dtExcel.Rows.Item(I).Item("Qtd").ToString.Replace("R$", "")
                            Me.tbProd.Rows.Item(Index).Item("Qtd") = dlbQtd.ToString("0.000")
                        End If

                        intCount = intCount + 1
                    Else

                        Me.tbProd.Rows.Add()
                        Dim Index As Integer = Me.tbProd.Rows.Count - 1

                        Me.tbProd.Rows.Item(Index).Item("Codigo") = "" 'dtProduto.Rows.Item(0).Item("Codigo").ToString
                        Me.tbProd.Rows.Item(Index).Item("CodigoInterno") = dtExcel.Rows.Item(I).Item("CodigoInterno").ToString.ToUpper
                        Me.tbProd.Rows.Item(Index).Item("Nome") = dtExcel.Rows.Item(I).Item("Nome").ToString.ToUpper
                        Me.tbProd.Rows.Item(Index).Item("UnidadeMedida") = dtExcel.Rows.Item(I).Item("UnidadeMedida").ToString.ToUpper
                        Me.tbProd.Rows.Item(Index).Item("Grupo") = dtExcel.Rows.Item(I).Item("Grupo").ToString.ToUpper

                        Dim dlbValor As Double = dtExcel.Rows.Item(I).Item("Valor").ToString.Replace("R$", "")
                        Valor = dlbValor.ToString("0.000")
                        Me.tbProd.Rows.Item(Index).Item("Valor") = Valor
                        Me.tbProd.Rows.Item(Index).Item("ValorAnt") = Valor

                        Dim dlbValorCusto As Double = dtExcel.Rows.Item(I).Item("ValorCusto").ToString.Replace("R$", "")
                        ValorCusto = dlbValorCusto.ToString("0.000")
                        Me.tbProd.Rows.Item(Index).Item("ValorCusto") = ValorCusto
                        Me.tbProd.Rows.Item(Index).Item("ValorCustoAnt") = ValorCusto

                        Me.tbProd.Rows.Item(Index).Item("Fabricante") = dtExcel.Rows.Item(I).Item("Fabricante").ToString.ToUpper
                        Me.tbProd.Rows.Item(Index).Item("CodigoBarra") = dtExcel.Rows.Item(I).Item("CodigoBarra").ToString
                        Me.tbProd.Rows.Item(Index).Item("NCM") = dtExcel.Rows.Item(I).Item("NCM").ToString
                        'Me.tbProd.Rows.Item(Index).Item("Peso") = dtExcel.Rows.Item(I).Item("Peso").ToString
                        'Me.tbProd.Rows.Item(Index).Item("QtdEmb") = dtExcel.Rows.Item(I).Item("QtdEmb").ToString

                        Dim dlbPeso As Double = dtExcel.Rows.Item(I).Item("Peso").ToString
                        Peso = dlbPeso.ToString("0.000")
                        Me.tbProd.Rows.Item(Index).Item("Peso") = Peso

                        Dim dlbQtdEmb As Double = dtExcel.Rows.Item(I).Item("QtdEmb").ToString
                        QtdEmb = dlbQtdEmb.ToString("0.000")
                        Me.tbProd.Rows.Item(Index).Item("QtdEmb") = QtdEmb

                        Me.tbProd.Rows.Item(Index).Item("Obs") = dtExcel.Rows.Item(I).Item("Obs").ToString
                        Me.tbProd.Rows.Item(Index).Item("Excluir") = False
                        If Me.chkCusto.Checked = True Then
                            Dim dlbQtd As Double = dtExcel.Rows.Item(I).Item("Qtd").ToString.Replace("R$", "")
                            Me.tbProd.Rows.Item(Index).Item("Qtd") = dlbQtd.ToString("0.000")
                        End If

                        intCount = intCount + 1
                    End If

                    pb1.Value = pb1.Value + 1
                    Application.DoEvents()
                    System.Threading.Thread.Sleep(10)
                Next

                Me.picFundo.Visible = False
                Me.pb1.Visible = False
                Me.grpItens.Text = "Nº Itens: " & Me.grd1.RowCount
                Me.grd1.FocusedRowHandle = 0

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        Me.GroupControl1.Focus()
        If Me.grd1.RowCount = 0 Then Exit Sub

        If MsgBox("Deseja realmente salvar os produtos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim index As Integer = -999997
            Me.grd1.FocusedRowHandle = index

            Dim strCodigo, strCodigoInterno, strNome, strUnidadeMedida, strGrupo, strValorCusto, strValor As String
            Dim strFabricante, strCodigoBarra, strNCM, strPeso, strQtdEmb, strObs, strData, strQtd As String


            For I As Integer = 0 To Me.grd1.RowCount - 1
                strCodigo = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)

                If strCodigo = "" Then
                    strCodigoInterno = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)
                    strNome = Me.grd1.GetRowCellDisplayText(I, Me.colNome)
                    strUnidadeMedida = Me.grd1.GetRowCellDisplayText(I, Me.colUnidadeMedida)
                    strGrupo = Me.grd1.GetRowCellDisplayText(I, Me.colGrupo)
                    strValorCusto = Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto)
                    strValor = Me.grd1.GetRowCellDisplayText(I, Me.colValor)

                    Dim dblValCusto As Double = strValorCusto
                    Dim dblVal As Double = strValor

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
                        strPor = "0,000"
                    End If

                    strFabricante = Me.grd1.GetRowCellDisplayText(I, Me.colFabricante)
                    strCodigoBarra = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoBarra)
                    strNCM = Me.grd1.GetRowCellDisplayText(I, Me.colNCM)
                    strPeso = Me.grd1.GetRowCellDisplayText(I, Me.colPeso)
                    strQtdEmb = Me.grd1.GetRowCellDisplayText(I, Me.colQtdEmb)
                    strObs = Me.grd1.GetRowCellDisplayText(I, Me.colObs)
                    strData = Date.Now.ToString("dd/MM/yyyy")


                    Dim dtGrupo As DataTable = CarregarDataTable("Select Count(*) as Total From Grupo " & _
                    "Where Nome='" & strGrupo & "';")

                    If dtGrupo.Rows.Count > 0 Then
                        If dtGrupo.Rows.Item(0).Item("Total").ToString = "0" Then
                            Inserir("INSERT INTO Grupo (Nome, Tipo) Values('" & strGrupo & "','G');")
                        End If
                    End If


                    Inserir("INSERT INTO Produto (Nome, UnidadeMedida, Valor, ValorCusto, Locacao, CodigoInterno, " & _
                    "Porcentagens, Fabricante, Grupo, Obs, Data, CodigoBarra, NivelComboCodCF, Desconto, Setor, " & _
                    "Tipo, CodProdFor, Inativo, Validade, Comissao, Locacao2, Familia, TributacaoPadrao, " & _
                    "AlterarPreco, Peso, CodigoFabricante, Garantia, KM, PesoBruto, QtdEmb) " & _
                    "VALUES('" & strNome & "','" & strUnidadeMedida & "','" & Num(strValor) & "', " & _
                    "'" & Num(strValorCusto) & "','','" & strCodigoInterno & "','" & strPor & "', " & _
                    "'" & strFabricante & "','" & strGrupo & "','" & strObs & "','" & strData & "', " & _
                    "'" & strCodigoBarra & "','1','0','','VENDA','','False','01/01/2050','0','','', " & _
                    "'0','0','" & Num(strPeso) & "','','','','0','" & Num(strQtdEmb) & "');")


                    Dim dtProduto As DataTable = CarregarDataTable("Select Codigo From Produto " & _
                    "Where CodigoInterno='" & strCodigoInterno & "';")



                    If dtProduto.Rows.Count > 0 Then
                        Dim strCodProd As String = dtProduto.Rows.Item(0).Item("Codigo").ToString

                        Inserir("INSERT INTO Nfe (CodProd, EXTIPI, Genero, CST, Origem, ModBC, ICMS, RedBC, " & _
                        "ModBCST, RedBCST, MVaST, ICMSST, NCM, Regime, CalculoCred, CFOP, CodigoANP, UFComb, " & _
                        "Cest, PerFCPUF, PerICMSUF) VALUES(" & strCodProd & ",'','','','','','','','','','', " & _
                        "'','" & strNCM & "','SIMPLES NACIONAL','','','','SP','','','');")


                        Dim dtCodConfig As DataTable = CarregarDataTable("Select Codigo From Config")

                        If dtCodConfig.Rows.Count > 0 Then
                            For J As Integer = 0 To dtCodConfig.Rows.Count - 1
                                Dim intConfig As Integer = dtCodConfig.Rows.Item(J).Item("Codigo").ToString

                                If Me.chkCusto.Checked = True Then
                                    strQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                                    Inserir("INSERT INTO Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, ValorCusto, " & _
                                    "Emfalta, Acabou, CodConfig, DataFim) VALUES(" & strCodProd & ",'U','0'," & _
                                    "'" & Num(strQtd) & "','U', " & Num(strValorCusto) & ",'0','0'," & _
                                    "" & intConfig & ",'1900-01-01 00:00:00');")

                                    If intConfig = CodConfig Then
                                        Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, Data, Tabela, CodConfig, CodUser) " & _
                                        "Values(" & strCodProd & ", '" & Num(strQtd) & "', '" & strData & "', 'QTDE', " & _
                                        "" & CodConfig & ", " & CodUser & ")")
                                    Else
                                        Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, Data, Tabela, CodConfig, CodUser) " & _
                                        "Values(" & strCodProd & ", '0', '" & strData & "', 'QTDE', " & _
                                        "" & intConfig & ", " & CodUser & ")")
                                    End If
                                Else
                                    Inserir("INSERT INTO Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, ValorCusto, " & _
                                    "Emfalta, Acabou, CodConfig, DataFim) VALUES(" & strCodProd & ",'U','0','0','U', " & _
                                    "" & Num(strValorCusto) & ",'0','0'," & intConfig & ",'1900-01-01 00:00:00');")
                                End If
                            Next
                        End If
                    End If
                Else
                    strValorCusto = Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto)
                    strValor = Me.grd1.GetRowCellDisplayText(I, Me.colValor)

                    Dim dblValCusto As Double = strValorCusto
                    Dim dblVal As Double = strValor

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
                        strPor = "0,000"
                    End If

                    strPeso = Me.grd1.GetRowCellDisplayText(I, Me.colPeso)
                    strQtdEmb = Me.grd1.GetRowCellDisplayText(I, Me.colQtdEmb)

                    Atualizar("Update Produto set ValorCusto='" & Num(strValorCusto) & "', " & _
                    "Valor='" & Num(strValor) & "', Porcentagens='" & strPor & "', " & _
                    "Peso='" & Num(strPeso) & "', QtdEmb='" & Num(strQtdEmb) & "' Where Codigo=" & strCodigo)
                End If
            Next

            MsgBox("Importação concluída com sucesso!", MsgBoxStyle.Information)

            Me.Close()
        End If
    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        Limpar()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If grd1.RowCount = 0 Then Exit Sub

        For I As Integer = 0 To Me.grd1.RowCount - 1
            If I <= Me.grd1.RowCount - 1 Then
                If Me.grd1.GetRowCellValue(I, Me.colExcluir) = True Then
                    Me.grd1.DeleteRow(I)
                End If
            End If
        Next

        Me.grpItens.Text = "Nº Itens : " & Me.grd1.RowCount & " "
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub

    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub frmImpProduto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        CarregarDados("Select Produto.Codigo, CodigoInterno, Nome, UnidadeMedida, Grupo, ValorCusto, Convert(Numeric(15,3), Valor) as Valor, " & _
        "Fabricante, CodigoBarra, Peso, QtdEmb, Obs, Convert(bit, 'False') as Excluir From Produto Where Inativo='False'", Me.GridControl1)

        Me.picFundo.Visible = False
        Me.pb1.Visible = False
        Me.grpItens.Text = "Nº Itens: " & Me.grd1.RowCount
        Me.grd1.FocusedRowHandle = 0
    End Sub

    Private Sub chkCusto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCusto.CheckedChanged
        If Me.chkCusto.Checked = True Then
            Me.colQtd.Visible = True
        Else
            Me.colQtd.Visible = False
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Me.NanoCampo1.Text.Trim <> "" And Me.NanoCampo1.Text.Trim <> "0,00" And Me.NanoCampo1.Text.Trim <> "0" Then
            If Me.CheckEdit1.Checked = False Then
                Dim dblPerAcres As Double = Me.NanoCampo1.Text.Trim
                Dim dblValor As Double = 0.0
                Dim dblResultado As Double = 0.0

                For I As Integer = 0 To Me.grd1.RowCount - 1

                    dblValor = Me.grd1.GetRowCellDisplayText(I, Me.colValor)
                    dblResultado = dblValor + (dblValor * dblPerAcres) / 100
                    Me.grd1.SetRowCellValue(I, Me.colValor, dblResultado.ToString("0.000"))

                Next
            Else
                Dim dblPerAcres As Double = Me.NanoCampo1.Text.Trim
                Dim dblValor As Double = 0.0
                Dim dblResultado As Double = 0.0

                For I As Integer = 0 To Me.grd1.RowCount - 1

                    dblValor = Me.grd1.GetRowCellDisplayText(I, Me.colValor)
                    dblResultado = dblValor - (dblValor * dblPerAcres) / 100
                    Me.grd1.SetRowCellValue(I, Me.colValor, dblResultado.ToString("0.000"))

                Next
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If Me.NanoCampo2.Text.Trim <> "" And Me.NanoCampo2.Text.Trim <> "0,00" And Me.NanoCampo2.Text.Trim <> "0" Then
            If Me.CheckEdit1.Checked = False Then
                Dim dblPerAcres As Double = Me.NanoCampo2.Text.Trim
                Dim dblValor As Double = 0.0
                Dim dblResultado As Double = 0.0

                For I As Integer = 0 To Me.grd1.RowCount - 1

                    dblValor = Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto)
                    dblResultado = dblValor + (dblValor * dblPerAcres) / 100
                    Me.grd1.SetRowCellValue(I, Me.colValorCusto, dblResultado.ToString("0.000"))

                Next
            Else
                Dim dblPerAcres As Double = Me.NanoCampo2.Text.Trim
                Dim dblValor As Double = 0.0
                Dim dblResultado As Double = 0.0

                For I As Integer = 0 To Me.grd1.RowCount - 1

                    dblValor = Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto)
                    dblResultado = dblValor - (dblValor * dblPerAcres) / 100
                    Me.grd1.SetRowCellValue(I, Me.colValorCusto, dblResultado.ToString("0.000"))

                Next
            End If
        End If
    End Sub
End Class