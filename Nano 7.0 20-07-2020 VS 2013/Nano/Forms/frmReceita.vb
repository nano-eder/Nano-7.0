Imports Nano.clsFuncoes
Imports Nano.clsDarBaixa
Imports Nano.clsValidar
Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Diagnostics
Public Class frmReceita
    Dim I As Integer
    Dim strNomeForm As String
    Dim bolConsulta As Boolean = False
    Dim bolDecimais As Boolean = False
    Dim bolSalvar As Boolean = False
    Dim IndexGrid As Integer
    Dim vetProd(8) As String
    Dim strTipoComissao As String
    Dim bolValida As Boolean = False
    Dim bolUsarTabela As Boolean = True
    Dim strItensDeletado As String
    Dim dblValorDeCusto, dblTotalDeCusto, dblPeso, dblTotalPeso As Double
    Dim strEstaComFocus As String
    Dim bolJaPassou As Boolean = False
    Dim bolJaSalvo As Boolean = False
    Dim bolAbriuProduto As Boolean = False
    Dim strStatus As String
    Dim strOrigemDesconto As String
    Dim intVencDias As Integer
    Dim vet(19) As String
    Dim intCodFunc As Integer
    Dim leitor As StringReader

    Dim intCodigoProduto As Integer

    Dim strCodigoReceita As String
    Dim strQtdEstoque As String
    Private Sub frmReceita_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.Tag = "CADASTRA" Or Me.Tag = "ALTERA" Then
            If grd1.RowCount > 0 Then
                If bolSalvar = False Then
                    If MsgBox("Deseja salvar os dados antes de fechar a janela?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Salvar(False)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Limpar(ByVal bolFocus As Boolean, ByVal bolGerarCodigo As Boolean)
        Me.txtNome.ResetText()
        Me.txtPorcentagem.ResetText()
        Me.txtQtd.ResetText()
        'Me.txtValorTotal.Text = "0.00"
        Me.txtTotalItens.Text = "0.00"
        Me.txtTotalCusto.Text = "0.00"
        Me.txtDesc.ResetText()
        Me.txtValorVenda.ResetText()
        Me.tbItens.Rows.Clear()
        If bolFocus = True Then
            txtCodReceita.Focus()
        End If

        If bolGerarCodigo = True Then
            txtCodReceita.ResetText()
            Me.chkAlterar.Checked = False
        End If
        Me.txtQtdKit.ResetText()
        Me.cboGrp.SelectedIndex = -1
    End Sub
    Private Sub GerCodigo()
        Dim intCodOrdem As Integer = GerarCodigoOrdens("Produto", CodConfig)

        Dim bolOk As Boolean = False
        While bolOk = False
            Me.txtCodReceita.Text = intCodOrdem
            If AcrescentarZeroCodProd = True Then

                Select Case Me.txtCodReceita.Text.Length
                    Case 1
                        Me.txtCodReceita.Text = "000" & Me.txtCodReceita.Text
                    Case 2
                        Me.txtCodReceita.Text = "00" & Me.txtCodReceita.Text
                    Case 3
                        Me.txtCodReceita.Text = "0" & Me.txtCodReceita.Text
                    Case 4
                    Case Else
                        If Not Me.txtCodReceita.Text.Length Mod 2 = 0 Then
                            Me.txtCodReceita.Text = "0" & Me.txtCodReceita.Text
                        End If
                End Select
            End If
            Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM Produto where CodigoInterno = '" & Me.txtCodReceita.Text & "'")
            If dt.Rows.Count > 0 Then
                intCodOrdem += 1
            Else
                bolOk = True
            End If

        End While

        Inserir("Insert into Ordens (Cod, Tabela, CodConfig) Values(" & Me.txtCodReceita.Text.Trim & ",'Produto'" & "," & CodConfig & ")")

    End Sub
    Private Sub Calcular()

        Dim dblLinha, dblTotCusto, dblQtd As Double

        For I = 0 To grd1.RowCount - 1

            'ESSA LINHA TEM QUE FICAR AQUI
            dblQtd = grd1.GetRowCellDisplayText(I, Me.colQtd)


            dblLinha = grd1.GetRowCellValue(I, Me.colCusto)
            dblTotCusto += dblLinha

        Next

        Me.txtTotalCusto.Text = dblTotCusto.ToString("0.00")
        dblTotalDeCusto = dblTotCusto.ToString("0.00")

        Me.txtTotalItens.Text = Me.grd1.RowCount

        CalculaPorcentagem()
    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If MsgBox("Deseja realmente limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Limpar(True, False)
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Validar(txtNomePro) = False Then Exit Sub
        If Validar(txtQtd) = False Then Exit Sub

        If txtQtd.Text = "0" Or txtQtd.Text = "0,000" Or txtQtd.Text = "0,00" Then MsgBox("Não é pertido adiconar a quantidade < " & txtQtd.Text & " > no pedido!", MsgBoxStyle.Exclamation) : txtQtd.Focus() : txtQtd.ResetText() : Exit Sub

        With Me.tbItens.Rows

            Dim dblResul, dblResulCusto, dblResulPeso As Double

            dblResul = txtQtd.Text * txtValor.Text
            dblResulCusto = dblValorDeCusto * txtQtd.Text.Trim
            dblResulPeso = dblPeso * Me.txtQtd.Text.Trim

            Dim strTipoValor As String = "Custo"
            If Me.rgpTipoValor.SelectedIndex = 1 Then
                strTipoValor = "Venda"
            End If
            If Me.chkAlterado.Checked = False Then
                .Add()
                Dim Index As Integer = .Count - 1

                .Item(Index).Item("CodPedAut") = "Inserir"
                .Item(Index).Item("Qtd") = txtQtd.Text.Trim
                .Item(Index).Item("CodigoProduto") = Me.txtCodPro.Tag
                .Item(Index).Item("CodigoInterno") = Me.txtCodPro.Text
                .Item(Index).Item("Produto") = txtNomePro.Text.Trim.Replace("'", "").Replace("&", "")

                .Item(Index).Item("Custo") = dblResulCusto.ToString("0.00")
                .Item(Index).Item("UM") = Me.txtQtd.ToolTipTitle
                .Item(Index).Item("Valor") = Me.txtValor.Text.Trim

                .Item(Index).Item("TipoValor") = strTipoValor
                .Item(Index).Item("QtdEstoque") = strQtdEstoque

            Else
                grd1.SetRowCellValue(IndexGrid, Me.colProduto, Me.txtNomePro.Text.Trim.Replace("'", "").Replace("&", ""))
                grd1.SetRowCellValue(IndexGrid, Me.colCodigoProduto, Me.txtCodPro.Tag.ToString)
                grd1.SetRowCellValue(IndexGrid, Me.colCodigoPeca, Me.txtCodPro.Text.Trim)
                grd1.SetRowCellValue(IndexGrid, Me.colQtd, Me.txtQtd.Text.Trim)

                grd1.SetRowCellValue(IndexGrid, Me.colCusto, dblResulCusto.ToString("0.00"))
                grd1.SetRowCellValue(IndexGrid, Me.colUM, Me.txtQtd.ToolTipTitle)
                grd1.SetRowCellValue(IndexGrid, Me.colValor, Me.txtValor.Text.Trim)

                grd1.SetRowCellValue(IndexGrid, Me.colTipoValor, strTipoValor)
                grd1.SetRowCellValue(IndexGrid, Me.colQtdEstoque, strQtdEstoque)
            End If

            Me.chkAlterado.Checked = False
        End With
        Me.txtValorVenda.ResetText()

        Calcular()
        strQtdEstoque = ""
        txtNomePro.ResetText()
        txtQtd.ResetText()
        txtValor.ResetText()
        Me.txtCodPro.Tag = ""
        Me.txtQtd.ToolTipTitle = ""
        Me.txtCodPro.ResetText()
        dblValorDeCusto = 0
        Me.txtCodPro.Focus()

    End Sub

    Private Sub txtKm_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtCodPro.Focus()
    End Sub

    Private Sub txtKm_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub Salvar(ByVal bolFaturar As Boolean)
        If grd1.RowCount = 0 Then MsgBox("Não existem itens no Pedido!", 64) : Exit Sub

        If Validar(Me.txtNome) = False Then Me.txtNome.Focus() : Exit Sub
        If Validar(Me.txtTotalItens) = False Then Exit Sub
        If Validar(Me.txtValorVenda) = False Then Exit Sub
        If Validar(Me.cboGrp) = False Then Me.cboGrp.Focus() : Exit Sub

        Me.txtNome.Focus()

        If Me.Tag = "CADASTRA" Then
            If Me.txtCodReceita.Text.Trim = "" Then
                GerCodigo()
            End If

            Inserir("Insert into Receita(CodigoInterno, Nome, ValorCusto, ValorVenda, Obs, CodConfig) Values('" & Me.txtCodReceita.Text.Trim & "','" & Me.txtNome.Text.Trim & "'," & Num(Me.txtTotalCusto.Text.Trim) & "," & Num(Me.txtValorVenda.Text.Trim) & ",'" & Me.txtDesc.Text.Trim.Replace("'", "").Replace("&", "") & "'," & CodConfig & ")")

            For I = 0 To grd1.RowCount - 1
                Dim strCodigo, strCodigoInterno, strQtd, strValor, strCusto, strTipoValor As String
                strCodigo = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto)
                strCodigoInterno = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoPeca)
                strQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                strCusto = Me.grd1.GetRowCellDisplayText(I, Me.colCusto)
                strValor = Me.grd1.GetRowCellDisplayText(I, Me.colValor)
                strTipoValor = Me.grd1.GetRowCellDisplayText(I, Me.colTipoValor)

                Inserir("Insert into ItensReceita (CodigoInterno, CodProd, CodProdInterno, Custo, Qtd, " & _
                "Valor, TipoValor) Values('" & Me.txtCodReceita.Text.Trim & "'," & strCodigo & "," & _
                "'" & strCodigoInterno & "'," & Num(strCusto) & "," & Num(strQtd) & "," & Num(strValor) & "," & _
                "'" & strTipoValor & "')")
            Next


            Inserir("INSERT INTO Produto (Nome, UnidadeMedida, Valor, ValorCusto, Locacao,  CodigoInterno, Porcentagens, Fabricante, Grupo, Obs, Data, CodigoBarra, NivelComboCodCF, Desconto, Setor, Tipo, Inativo, TributacaoPadrao, AlterarPreco) VALUES ('" & Me.txtNome.Text.Trim.Replace("'", "") & "','" & "UN" & "'," & Num(Me.txtValorVenda.Text.Trim) & "," & Num(Me.txtTotalCusto.Text.Trim) & ",'" & "" & "','" & Me.txtCodReceita.Text.Trim & "','" & Me.txtPorcentagem.Text.Trim & "','" & "" & "','" & Me.cboGrp.Text.Trim & "','" & "" & "','" & Date.Today & "','" & "" & "','" & "0" & "'," & "0.000" & ",'" & Me.cboSet.Text.Trim & "','" & "RECEITA" & "','False','False','False')")
            If BaixaPorLote = False Then
                Dim intCodiProd As Integer = Val(GerarCodigo("Produto", "Codigo", 0)) - 1


                Dim dtProd As DataTable = CarregarDataTable("SELECT Codigo FROM Produto where Nome = '" & Me.txtNome.Text.Trim.Replace("'", "") & "' and CodigoInterno = '" & Me.txtCodReceita.Text.Trim & "' and UnidadeMedida = 'UN' and Grupo = '" & Me.cboGrp.Text.Trim & "'")

                If dtProd.Rows.Count > 0 Then
                    intCodiProd = dtProd.Rows.Item(0).Item("Codigo").ToString
                End If

                Dim dtConfig As DataTable = CarregarDataTable("Select Codigo from Config")

                Dim intCod As Integer
                Dim P As Integer


                For P = 0 To dtConfig.Rows.Count - 1
                    intCod = dtConfig.Rows.Item(P).Item("Codigo")
                    Inserir("INSERT INTO Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, ValorCusto, EmFalta, CodConfig, Acabou, DataFim) VALUES (" & intCodiProd & ",'U',0,0,'U'," & Num(Me.txtTotalCusto.Text) & ",'1'," & intCod & ",'False','01/01/1900')")
                Next
            End If
            strCodigoReceita = txtCodReceita.Text
            MsgBox("A Receita " & txtCodReceita.Text & " foi cadastrada com sucesso!", 64)
        Else

            Dim vetDelete As Array = Split(strItensDeletado, "|")

            For I = 0 To vetDelete.Length - 1
                If vetDelete(I) = "" Then Exit For
                If vetDelete(I) <> "Inserir" Then
                    Dim strDelete As String
                    strDelete = "Delete From ItensReceita where Codigo =" & vetDelete(I)
                    Excluir(strDelete)
                End If


            Next

            Dim strStatus As String
            strStatus = "Pendente"
            For I = 0 To grd1.RowCount - 1
                Dim strCodigo, strCodigoInterno, strQtd, strCodPedAut, strCusto, strValor, strTipoValor As String
                strCodPedAut = grd1.GetRowCellDisplayText(I, Me.colCodPedAut)
                strCodigo = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto)
                strCodigoInterno = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoPeca)
                strQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                strCusto = Me.grd1.GetRowCellDisplayText(I, Me.colCusto)
                strValor = Me.grd1.GetRowCellDisplayText(I, Me.colValor)
                strTipoValor = Me.grd1.GetRowCellDisplayText(I, Me.colTipoValor)


                If strCodPedAut = "Inserir" Then
                    grd1.SetRowCellValue(I, Me.colCodPedAut, "OK")
                    Inserir("Insert into ItensReceita (CodigoInterno, CodProd, CodProdInterno, Custo, Qtd, " & _
                    "Valor, TipoValor) Values('" & Me.txtCodReceita.Text.Trim & "'," & strCodigo & "," & _
                    "'" & strCodigoInterno & "'," & Num(strCusto) & "," & Num(strQtd) & "," & Num(strValor) & "," & _
                    "'" & strTipoValor & "')")
                Else
                    If strCodPedAut <> "OK" Then
                        Atualizar("Update ItensReceita set CodProd ='" & strCodigo & "', CodProdInterno ='" & strCodigoInterno & "', " & _
                        "Custo =" & Num(strCusto) & ", Qtd =" & Num(strQtd) & ", Valor =" & Num(strValor) & ", " & _
                        "TipoValor = '" & strTipoValor & "' where Codigo =" & strCodPedAut.Trim)
                    End If
                End If
            Next
            Atualizar("Update Receita set Nome ='" & Me.txtNome.Text.Trim & "', Obs ='" & Me.txtDesc.Text.Trim.Replace("'", "").Replace("&", "E") & "', ValorCusto = " & Num(Me.txtTotalCusto.Text.Trim) & ", ValorVenda =" & Num(Me.txtValorVenda.Text.Trim) & " where CodigoInterno ='" & Me.txtCodReceita.Text.Trim & "'")
            Atualizar("UPDATE Produto SET Nome ='" & Me.txtNome.Text.Trim & "', ValorCusto =" & Num(Me.txtTotalCusto.Text.Trim) & ", Valor=" & Num(Me.txtValorVenda.Text.Trim) & ", Porcentagens='" & Me.txtPorcentagem.Text.Trim & "', Grupo = '" & Me.cboGrp.Text.Trim & "', Setor ='" & Me.cboSet.Text.Trim & "' where CodigoInterno = '" & Me.txtCodReceita.Text.Trim & "'")
            MsgBox("A Receita " & txtCodReceita.Text & " foi alterada com sucesso!", 64)
        End If

        Try

            bolSalvar = True

            If bolFaturar = False Then
                If MsgBox("Deseja imprimir a Receita?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    'Imprimir(False)
                    Visualizar()
                End If
            End If
            If Me.Tag = "CADASTRA" Then
                Limpar(True, True)
            Else
                Limpar(True, False)
            End If

        Catch ex As Exception
            MsgBox("Ocorreu algum erro ao salvar os dados, tente novamente!", MsgBoxStyle.Exclamation)
            Limpar(True, False)
        End Try
        'Me.Close()
    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        If TesteConexao() = False Then Exit Sub
        Salvar(False)

    End Sub

    Private Sub CarregaForm()
        If bolJaPassou = True Then bolJaPassou = False : Exit Sub

        If txtCodReceita.Text.Trim = "" Then Exit Sub
        Limpar(False, False)

        Dim dt As DataTable = CarregarDataTable("Select Receita.Codigo, Receita.CodigoInterno, " & _
        "Receita.Nome, Convert(Numeric(15,2), Receita.ValorCusto) as ValorCusto, " & _
        "Convert(Numeric(15,2), Receita.ValorVenda) as ValorVenda, Receita.Obs, " & _
        "case when Produto.Porcentagens <> '' then Convert(Numeric(15,2), replace(Produto.Porcentagens,',','.')) else 0 end as Porcentagens, " & _
        "Produto.Grupo, Produto.Setor, Produto.Codigo as CodigoProduto from Receita inner join Produto on Receita.CodigoInterno = Produto.CodigoInterno where Receita.CodigoInterno ='" & Me.txtCodReceita.Text.Trim & "'") 'and Receita.CodConfig =" & CodConfig)

        If dt.Rows.Count = 0 Then MsgBox("Receita não Cadastrada!", MsgBoxStyle.Information) : Me.txtCodReceita.ResetText() : Me.txtCodReceita.Focus() : Exit Sub
        Me.txtNome.Text = dt.Rows.Item(0).Item("Nome").ToString
        Me.txtTotalCusto.Text = dt.Rows.Item(0).Item("ValorCusto").ToString
        Me.txtDesc.Text = dt.Rows.Item(0).Item("Obs").ToString
        Me.txtValorVenda.Text = dt.Rows.Item(0).Item("ValorVenda").ToString
        If dt.Rows.Item(0).Item("ValorCusto").ToString <> "" Then
            dblTotalDeCusto = dt.Rows.Item(0).Item("ValorCusto").ToString
        End If
        Me.cboGrp.Text = dt.Rows.Item(0).Item("Grupo").ToString
        Me.cboSet.Text = dt.Rows.Item(0).Item("Setor").ToString

        Me.txtPorcentagem.Text = dt.Rows.Item(0).Item("Porcentagens").ToString

        intCodigoProduto = dt.Rows.Item(0).Item("CodigoProduto").ToString
        'CARREGAR DADOS DE RECEITA
        Dim dtPed As DataTable = CarregarDataTable("Select ItensReceita.Codigo, CodProd, Qtd, CodProdInterno, " & _
        "Produto.Nome as Produto, Convert(Numeric(15,2),Qtd * Produto.ValorCusto) as Custo, " & _
        "Convert(Numeric(15,2), Produto.ValorCusto) as valor, Produto.UnidadeMedida, TipoValor " & _
        "from ItensReceita inner join Produto on ItensReceita.CodProd = Produto.Codigo " & _
        "where ItensReceita.CodigoInterno ='" & Me.txtCodReceita.Text.Trim & "'")

        Me.tbItens.Rows.Clear()

        For I = 0 To dtPed.Rows.Count - 1

            With Me.tbItens.Rows
                .Add()
                .Item(I).Item("CodPedAut") = dtPed.Rows.Item(I).Item("Codigo").ToString
                .Item(I).Item("Qtd") = dtPed.Rows.Item(I).Item("Qtd").ToString
                .Item(I).Item("CodigoProduto") = dtPed.Rows.Item(I).Item("CodProd").ToString
                .Item(I).Item("Produto") = dtPed.Rows.Item(I).Item("Produto").ToString

                .Item(I).Item("CodigoInterno") = dtPed.Rows.Item(I).Item("CodProdInterno").ToString
                .Item(I).Item("UM") = dtPed.Rows.Item(I).Item("UnidadeMedida").ToString
                .Item(I).Item("Valor") = dtPed.Rows.Item(I).Item("Valor").ToString

                If dtPed.Rows.Item(I).Item("Custo").ToString <> "" Then
                    .Item(I).Item("Custo") = dtPed.Rows.Item(I).Item("Custo").ToString
                Else
                    .Item(I).Item("Custo") = "0,00"
                End If

                .Item(I).Item("TipoValor") = dtPed.Rows.Item(I).Item("TipoValor").ToString

                If EstoqueSomado = False Then
                    Dim dtQtd As DataTable = CarregarDataTable("Select sum(Qtd) as Qtd from Qtde where " & _
                    "CodProd =" & dtPed.Rows.Item(I).Item("CodProd").ToString & " and Acabou = 'False' and CodConfig =" & CodConfig)
                    If dtQtd.Rows.Count = 0 Then
                        strQtdEstoque = "0"
                    Else
                        If dtQtd.Rows(0).Item("Qtd").ToString() <> "" Then
                            .Item(I).Item("QtdEstoque") = dtQtd.Rows(0).Item("Qtd").ToString()
                        End If
                    End If
                Else
                    Dim dblResul As Double = AjusteQtde(CodConfig, dtPed.Rows.Item(I).Item("CodProd").ToString)
                    .Item(I).Item("QtdEstoque") = dblResul

                End If
            End With
        Next

        Me.txtTotalItens.Text = Me.grd1.RowCount
        Dim intCodPedido As String = Me.txtCodReceita.Text.Trim

        If Me.Tag = "ALTERA" Then
            bolJaPassou = True
            Me.txtCodPro.Focus()
        End If

        Calcular()
    End Sub

    Private Sub btnCancelar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelar.ItemClick
        Me.Close()

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Me.chkAlterado.Checked = True Then MsgBox("Existe um item sendo alterado, conclua a alteração antes de excluir algum item!", MsgBoxStyle.Information) : Exit Sub
        If grd1.RowCount = 0 Then Exit Sub
        If MsgBox("Deseja realmente excluir este item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            strItensDeletado &= grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodPedAut) & "|"
            Me.grd1.DeleteRow(grd1.FocusedRowHandle)
        End If
        Calcular()
    End Sub

    Private Sub txtQtd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQtd.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "," And e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtQtd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtd.Leave
        If txtQtd.Text.Trim = "" Then Exit Sub
        If txtQtd.ToolTipTitle = "HORA" Then
            Exit Sub
        End If
        Dim dblVal As Double
        Try
            dblVal = txtQtd.Text.Trim
        Catch ex As Exception
            MsgBox("Caracter digitado não é permitido para este campo!", MsgBoxStyle.Exclamation)
            txtQtd.ResetText()
            txtQtd.Focus()
        End Try

        txtQtd.Text = dblVal.ToString("0.000")

    End Sub

    Private Sub txtCodReceita_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodReceita.EditValueChanged
        If txtCodReceita.Text = "" Then Limpar(False, False)
    End Sub

    Private Sub Imprimir(ByVal bolVisualizar As Boolean)

        'Dim strImpressao As String
        'Dim rel As New relCupom

        'Dim dt As DataTable
        'Dim vetTexto As Array = LerArquivo()

        'rel.lblTit.Text = vetTexto(0).ToString
        'rel.lblTit2.Text = vetTexto(1).ToString

        'strImpressao = "   ------------------------------------------" & vbCrLf

        'strImpressao &= "   Orçamento Nº: " & Dir(Me.txtCodPed.Text, 15) & Esq(Me.dtData.Text.Trim, 10) & vbCrLf

        'dt = CarregarDataTable("Select nome from funcionario where cod ='" & Me.txtCodFunc.Text.Trim & "'")

        'Dim dtDate As Date = Me.dtData.Text.Trim

        'dtDate = dtDate.AddDays(intVencDias)

        'If dt.Rows.Count > 0 Then
        '    strImpressao &= "   " & Dir(dt.Rows.Item(0).Item(0).ToString, 23) & "Venc: " & Esq(dtDate, 10) & vbCrLf
        'End If

        'strImpressao &= "   ------------------------------------------" & vbCrLf

        'dt = CarregarDataTable("Select Fantasia, Endereco, Numero, Complemento, Bairro, Cidade, Nome from Cliente where CPF ='" & CpfDoCliente & "'")

        'If dt.Rows.Count > 0 Then
        '    strImpressao &= "   " & dt.Rows.Item(0).ItemArray(0).ToString & vbCrLf
        '    strImpressao &= "   " & dt.Rows.Item(0).ItemArray(6).ToString & vbCrLf
        '    strImpressao &= "   " & dt.Rows.Item(0).ItemArray(1).ToString & ", " & dt.Rows.Item(0).ItemArray(2).ToString & vbCrLf
        '    If dt.Rows.Item(0).ItemArray(3).ToString <> "" Then
        '        strImpressao &= "   " & dt.Rows.Item(0).ItemArray(3).ToString & ", " & dt.Rows.Item(0).ItemArray(4).ToString & ", " & dt.Rows.Item(0).ItemArray(5).ToString & vbCrLf
        '    Else
        '        strImpressao &= "   " & dt.Rows.Item(0).ItemArray(4).ToString & ", " & dt.Rows.Item(0).ItemArray(5).ToString & vbCrLf
        '    End If
        '    strImpressao &= "   " & Me.txtTel.Text.Trim & "  " & Me.txtFax.Text.Trim & vbCrLf
        'End If

        'strImpressao &= "   ------------------------------------------" & vbCrLf
        'strImpressao &= "   CÓDIGO   DESCRIÇÃO                         " & vbCrLf
        'strImpressao &= "   QTD.    UN.  UNITARIO  PESO      TOTAL" & vbCrLf
        'strImpressao &= "   ------------------------------------------" & vbCrLf

        'Dim L As Integer

        'For L = 0 To grd1.RowCount - 1
        '    Dim strCod, strProd, strUni, strQtd, strTot, strPeso, strUM As String

        '    strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoPeca)
        '    strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
        '    strUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
        '    strQtd = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
        '    strTot = Me.grd1.GetRowCellDisplayText(L, Me.colValorTotal)
        '    strPeso = Me.grd1.GetRowCellDisplayText(L, Me.colPeso)
        '    strUM = Me.grd1.GetRowCellDisplayText(L, Me.colUM)

        '    strImpressao &= "   " & Dir(strCod, 5) & strProd & vbCrLf
        '    Dim str As String
        '    str = "   " & Dir(strQtd, 9) & Dir(strUM, 3) & Esq(strUni, 8) & Esq(strPeso, 10) & Esq(strTot, 10)
        '    strImpressao &= str & vbCrLf & vbCrLf
        'Next

        'strImpressao &= "   ------------------------------------------" & vbCrLf

        'strImpressao &= Dir("   Peso Total: " & Me.txtTotPeso.Text.Trim, 40) & vbCrLf
        'strImpressao &= ".." & vbCrLf
        'strImpressao &= ".." & vbCrLf
        'strImpressao &= ".." & vbCrLf

        'strImpressao &= Esq("    Total do Pedido R$   " & Me.txtTotal.Text.Trim, 40) & vbCrLf


        'strImpressao &= "   ------------------------------------------" & vbCrLf & vbCrLf

        'strImpressao &= "   Recebi a mercadoria em ___/___/______" & vbCrLf
        'strImpressao &= ".." & vbCrLf
        'strImpressao &= ".." & vbCrLf
        'strImpressao &= "   Assinatura: _____________________________" & vbCrLf

        'strImpressao &= ".." & vbCrLf
        'strImpressao &= ".." & vbCrLf

        'strImpressao &= "   Observações" & vbCrLf

        'strImpressao &= "   " & Me.txtDesc.Text & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf

        'strImpressao &= ".." & vbCrLf
        'strImpressao &= ".." & vbCrLf
        'strImpressao &= ".." & vbCrLf
        'strImpressao &= ".." & vbCrLf
        'strImpressao &= ".." & vbCrLf
        'strImpressao &= ".." & vbCrLf
        'strImpressao &= ".." & vbCrLf


        'rel.Name = ""

        'rel.txtTexto.Text = strImpressao

        'If bolVisualizar = False Then
        '    rel.Print()
        'Else
        '    rel.ShowPreview()
        'End If

    End Sub

    Private Sub chkAlterado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case chkAlterado.Checked
            Case True

                Me.txtCodPro.BackColor = Color.Bisque
                Me.txtNomePro.BackColor = Color.Bisque
                Me.txtQtd.BackColor = Color.Bisque
                Me.txtValor.BackColor = Color.Bisque
                Me.btnAdd.Text = "Alterar"
                Me.btnAdd.Image = My.Resources.Alterar
            Case False

                Me.txtCodPro.BackColor = Color.White
                Me.txtNomePro.BackColor = Color.White
                Me.txtQtd.BackColor = Color.White
                Me.txtValor.BackColor = Color.White
                Me.btnAdd.Text = "Adicionar"
                Me.btnAdd.Image = My.Resources.edit_add
        End Select
    End Sub

    Private Sub txtCodPro_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodPro.ButtonClick
        AbrirProdutos()
    End Sub

    Private Sub AbrirProdutos()
        RetornaProduto = ""

        Dim frm As New frmCadProduto
        frm.Tag = "RECEITA"
        CodigoDoProduto = 0
        frm.ShowDialog()

        Dim dtProd As DataTable

        dtProd = CarregarDataTable("SELECT CodigoInterno, CodigoBarra, Nome, Valor, UnidadeMedida, ValorCusto FROM Produto where Codigo = " & CodigoDoProduto)

        If dtProd.Rows.Count > 0 Then
            Me.txtCodPro.Tag = CodigoDoProduto
            Me.txtCodPro.Text = dtProd.Rows.Item(0).Item("CodigoInterno").ToString
            Me.txtNomePro.Text = dtProd.Rows.Item(0).Item("Nome").ToString

            txtQtd.ToolTipTitle = dtProd.Rows.Item(0).Item("UnidadeMedida").ToString
            If Me.rgpTipoValor.SelectedIndex = 0 Then
                Me.txtValor.Text = dtProd.Rows.Item(0).Item("ValorCusto").ToString
                dblValorDeCusto = dtProd.Rows.Item(0).Item("ValorCusto").ToString
            Else
                Me.txtValor.Text = dtProd.Rows.Item(0).Item("Valor").ToString
                dblValorDeCusto = dtProd.Rows.Item(0).Item("Valor").ToString
            End If


        
            If EstoqueSomado = False Then
                Dim dtQtd As DataTable = CarregarDataTable("Select sum(Qtd) as Qtd from Qtde where " & _
                "CodProd =" & Me.txtCodPro.Tag & " and Acabou = 'False' and CodConfig =" & CodConfig)
                If dtQtd.Rows.Count = 0 Then
                    strQtdEstoque = "0"
                Else
                    If dtQtd.Rows(0).Item("Qtd").ToString() <> "" Then
                        strQtdEstoque = dtQtd.Rows(0).Item("Qtd").ToString()
                    End If
                End If
            Else
                Dim dblResul As Double = AjusteQtde(CodConfig, Me.txtCodPro.Tag)
                strQtdEstoque = dblResul
                
            End If


            bolDecimais = True
            bolAbriuProduto = True

            Me.txtQtd.Focus()

        Else
            strQtdEstoque = ""
            Me.txtCodPro.Tag = ""
            Me.txtCodPro.ResetText()
            Me.txtNomePro.ResetText()
            Me.txtValor.ResetText()
            txtQtd.ToolTipTitle = "QUALQUER"
            dblValorDeCusto = 0
            Me.txtCodPro.Focus()

        End If
    End Sub

    Private Sub ConsultarReceita()
        ConsultaPedido = ""
        Dim frm As New frmConPed
        frm.Tag = "RECEITA"
        frm.ShowDialog()

        If ConsultaPedido <> "" Then
            Me.txtCodReceita.Text = ConsultaPedido
            CarregaForm()
            CarregaForm()
        Else
            Me.txtCodReceita.Text = ""
            Me.txtCodReceita.Focus()
        End If
    End Sub

    Private Sub txtAlt_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlt.DoubleClick
        If Me.Tag = "CONSULTA" Then Exit Sub
        Me.chkAlterado.Checked = True
        IndexGrid = grd1.FocusedRowHandle

        With grd1
            Me.txtNomePro.Text = .GetRowCellDisplayText(IndexGrid, Me.colProduto)
            Me.txtCodPro.Tag = .GetRowCellDisplayText(IndexGrid, Me.colCodigoProduto)
            Me.txtCodPro.Text = .GetRowCellDisplayText(IndexGrid, Me.colCodigoPeca)
            Me.txtQtd.Text = .GetRowCellDisplayText(IndexGrid, Me.colQtd)
            Me.txtValor.Text = .GetRowCellDisplayText(IndexGrid, Me.colValor)
            dblValorDeCusto = .GetRowCellDisplayText(IndexGrid, colCusto) / .GetRowCellDisplayText(IndexGrid, Me.colQtd)
            Me.txtQtd.ToolTipTitle = .GetRowCellDisplayText(IndexGrid, Me.colUM)
            strQtdEstoque = .GetRowCellDisplayText(IndexGrid, Me.colQtdEstoque)
        End With
    End Sub

    Private Sub txtCodPro_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPro.Enter
        strEstaComFocus = "txtCodPro"
    End Sub

    Private Sub txtCodPro_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodPro.Leave

        If Me.txtCodPro.Text.Trim = "" Then
            Me.txtValorVenda.Focus()
            Exit Sub
        End If

        If bolAbriuProduto = True Then bolAbriuProduto = False : Exit Sub

        Dim dt As DataTable

        dt = CarregarDataTable("Select Codigo, Nome, Valor, UnidadeMedida, ValorCusto from Produto Where Tipo <> 'VENDA' and Tipo <> 'RECEITA' and CodigoInterno ='" & Me.txtCodPro.Text.Trim & "' or CodigoBarra ='" & Me.txtCodPro.Text.Trim & "'")

        If dt.Rows.Count = 0 Then
            Dim dtCodBarra As DataTable = CarregarDataTable("SELECT CodProd FROM CodigoBarra where CodigoBarra = '" & Me.txtCodPro.Text & "' and Produto = '' or CodigoBarra = '" & Me.txtCodPro.Text & "' and Produto is null")
            If dtCodBarra.Rows.Count > 0 Then
                CodigoDoProduto = dtCodBarra.Rows.Item(0).Item("CodProd").ToString
                dt = CarregarDataTable("Select Codigo, Nome, Valor, UnidadeMedida, ValorCusto from Produto where Tipo <> 'VENDA' and Tipo <> 'RECEITA' Codigo=" & CodigoDoProduto)
            End If
        End If

        If dt.Rows.Count > 0 Then
            CodigoDoProduto = dt.Rows(0).Item("Codigo").ToString
            Me.txtCodPro.Tag = CodigoDoProduto
            Me.txtNomePro.Text = dt.Rows(0).ItemArray(1).ToString

            Me.txtQtd.ToolTipTitle = dt.Rows(0).ItemArray(3).ToString

            If Me.rgpTipoValor.SelectedIndex = 0 Then
                Me.txtValor.Text = dt.Rows(0).ItemArray(4).ToString
                dblValorDeCusto = dt.Rows(0).ItemArray(4).ToString
            Else
                Me.txtValor.Text = dt.Rows(0).ItemArray(2).ToString
                dblValorDeCusto = dt.Rows(0).ItemArray(2).ToString
            End If

            If EstoqueSomado = False Then
                Dim dtQtd As DataTable = CarregarDataTable("Select sum(Qtd) as Qtd from Qtde where " & _
                "CodProd =" & Me.txtCodPro.Tag & " and Acabou = 'False' and CodConfig =" & CodConfig)
                If dtQtd.Rows.Count = 0 Then
                    strQtdEstoque = "0"
                Else
                    If dtQtd.Rows(0).Item("Qtd").ToString() <> "" Then
                        strQtdEstoque = dtQtd.Rows(0).Item("Qtd").ToString()
                    End If
                End If
            Else
                Dim dblResul As Double = AjusteQtde(CodConfig, Me.txtCodPro.Tag)
                strQtdEstoque = dblResul

            End If
            bolAbriuProduto = True
            Me.txtQtd.Focus()
        Else
            MsgBox("Produto não cadastrado ou tipo de produto invalido!", MsgBoxStyle.Information)
            strQtdEstoque = ""
            Me.txtCodPro.ResetText()
            Me.txtCodPro.Focus()
            Me.txtCodPro.Tag = ""
            Me.txtNomePro.ResetText()
            Me.txtValor.ResetText()
            Me.txtQtd.ToolTipTitle = "UNIDADE"
            dblValorDeCusto = 0
            Exit Sub
        End If

    End Sub

    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click
        ConsultarReceita()
    End Sub

    Private Sub cboTab_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtCodPro.Tag = ""
        Me.txtCodPro.ResetText()
        Me.txtNomePro.ResetText()
        Me.txtQtd.ResetText()
        Me.txtValor.ResetText()
    End Sub
    Private Sub Visualizar()
        Dim rel As New relReceita

        rel.picLogo.Image = LogoTipo

        Dim I As Integer

        For I = 0 To Me.grd1.RowCount - 1
            With rel.tbReceita.Rows
                .Add()
                .Item(I).Item("Produto") = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                .Item(I).Item("Qtde") = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                .Item(I).Item("Codigo") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoPeca)
                .Item(I).Item("Custo") = Me.grd1.GetRowCellDisplayText(I, Me.colCusto)
            End With
        Next

        If Me.txtDesc.Text <> "" Then
            rel.lblObs.Text = Me.txtDesc.Text
        Else
            rel.linha1.Visible = False
            rel.lblObservacao.Visible = False
        End If
        rel.lblPed.Text = Me.txtCodReceita.Text
        rel.lblTitulo.Text = Me.txtNome.Text
        rel.tblQtd.Text = Me.txtTotalItens.Text
        rel.tblTotal.Text = Me.txtValorVenda.Text
        rel.tblCusto.Text = Me.txtTotalCusto.Text

        rel.ShowPreview()
    End Sub
    Private Sub btnVisuImp_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisuImp.ItemClick
        Visualizar()
    End Sub

    Private Sub txtCodReceita_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodReceita.Enter
        strEstaComFocus = "txtCodPed"
    End Sub

    'Private Sub Print()

    '    Dim strTexto As String = Me.txtCupom.Text

    '    leitor = New StringReader(strTexto)

    '    Me.PrintDocument1.Print()

    'End Sub

    'Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal texto As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

    '    Dim linhasPorPagina As Single = 0

    '    Dim Posicao_Y As Single = 0

    '    Dim contador As Integer = 0

    '    Dim MargemEsquerda As Single = 3

    '    Dim MargemSuperior As Single = 3

    '    Dim linha As String = Nothing

    '    Dim FonteDeImpressao As Font = Me.txtCupom.Font

    '    Dim meupincel As New SolidBrush(Color.Black)

    '    'Calcula o numero de linhas por página usando as medidas das margens

    '    linhasPorPagina = texto.MarginBounds.Height / FonteDeImpressao.GetHeight(texto.Graphics)

    '    ' Vamos imprimiri cada linha implementando um StringReader

    '    linha = leitor.ReadLine()

    '    While contador < linhasPorPagina

    '        ' calcula a posicao da proxima linha baseado  na altura da fonte de acordo com o dispostivo de impressao

    '        Posicao_Y = (MargemSuperior + (contador * FonteDeImpressao.GetHeight(texto.Graphics)))

    '        ' desenha a proxima linha no controle richtext

    '        texto.Graphics.DrawString(linha, FonteDeImpressao, meupincel, MargemEsquerda, Posicao_Y, New StringFormat())

    '        contador += 1

    '        linha = leitor.ReadLine()

    '    End While

    '    ' se existir mais linhas imprimi outra página

    '    If Not (linha Is Nothing) Then

    '        texto.HasMorePages = True
    '    Else

    '        texto.HasMorePages = False

    '    End If

    '    meupincel.Dispose()
    'End Sub

    Private Sub txtCodReceita_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodReceita.Leave
        If Me.Tag = "CADASTRA" Then



            If txtCodReceita.Text = "" Then
                Me.chkAlterar.Checked = False
                Exit Sub
            End If
            If AcrescentarZeroCodProd = True Then

                Select Case Me.txtCodReceita.Text.Length
                    Case 1
                        Me.txtCodReceita.Text = "000" & Me.txtCodReceita.Text
                    Case 2
                        Me.txtCodReceita.Text = "00" & Me.txtCodReceita.Text
                    Case 3
                        Me.txtCodReceita.Text = "0" & Me.txtCodReceita.Text
                    Case 4
                    Case Else
                        If Not Me.txtCodReceita.Text.Length Mod 2 = 0 Then
                            Me.txtCodReceita.Text = "0" & Me.txtCodReceita.Text
                        End If
                End Select
            End If
            PesquisarProduto(txtCodReceita, "CodigoInterno")
            If txtCodReceita.Text <> "" Then
                PesquisarProduto(txtCodReceita, "CodigoBarra")
            End If
            PesquisarReceita(Me.txtCodReceita, "CodigoInterno")
        Else
            CarregaForm()
            CarregaForm()
        End If
    End Sub

    Private Sub frmReceita_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F6 Then
            Me.txtDesc.Focus()
            Salvar(False)
        End If

        If e.KeyCode = Keys.F10 Then

            If strEstaComFocus = "txtCodPed" Then
                ConsultarReceita()
            End If

            If Me.Tag = "CONSULTA" Then Exit Sub
            Select Case strEstaComFocus
                Case "txtCodPro"
                    AbrirProdutos()
            End Select
        End If
    End Sub

    Private Sub frmReceita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If TesteConexao() = False Then Exit Sub
        Me.btnSalvarMontar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.txtCodPro.Tag = ""
        'Dim vetDados As Array = LerArquivo()

        If Me.Tag = "ALTERA" Then
            Me.txtCodReceita.Properties.AppearanceDisabled.BackColor = Color.White
            Me.Text = "Alteração Receita"
            PedidoGridControl.Dock = DockStyle.Fill
            If MontarKit = True Then
                Me.bsiKit.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                Me.txtQtdKit.Visible = True
                Me.LabelControl1.Visible = True
                Me.Label1.Visible = True
                Me.PanelControl1.Visible = True
                Me.Text = "Alteração Kit"
                Me.btnSalvarMontar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Else

                Me.colQtdEstoque.Visible = False
            End If

            If Me.txtCodReceita.Text <> "" Then
                Timer1.Start()
            End If
        ElseIf Me.Tag = "CONSULTA" Then
            bolConsulta = True
            grpProd.Enabled = False
            Me.txtCodReceita.Properties.AppearanceDisabled.BackColor = Color.White
            Me.btnDelete.Visible = False
            btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.Text = "Consulta Receita"
            txtDesc.Properties.ReadOnly = True
            LabelControl2.Enabled = False
            Me.txtValorVenda.Properties.ReadOnly = True
            Me.txtPorcentagem.Properties.ReadOnly = True

            Me.txtNome.Enabled = False

            If MontarKit = True Then
                Me.Text = "Consulta Kit"
                Me.btnSalvarMontar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Else

                Me.colQtdEstoque.Visible = False
            End If
        Else
            Me.btnConsulta.Visible = False
            'GerCodigo()
            Me.Text = "Cadastro Receita"
            btnVisuImp.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            PedidoGridControl.Dock = DockStyle.Fill
            Me.txtCodReceita.Size = New System.Drawing.Size(112, 21)
            If MontarKit = True Then
                Me.Text = "Cadastro Kit"
                Me.btnSalvarMontar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Else

                Me.colQtdEstoque.Visible = False
            End If

            Me.txtCodReceita.Enabled = False
            Me.chkAlterar.Visible = True
        End If


        PreencherGrupoSetorCusto("G", Me.cboGrp)
        PreencherGrupoSetorCusto("S", Me.cboSet)
        strNomeForm = Me.Text.Trim
        txtCodReceita.Focus()
    End Sub

    'Private Sub GerCodigo()
    '    Me.txtCodReceita.Text = GerarCodigoOrdens("Produto", CodConfig)
    '    Inserir("Insert into Ordens (Cod, Tabela, CodConfig) Values(" & Me.txtCodReceita.Text.Trim & ",'Produto'" & "," & CodConfig & ")")

    'End Sub

    Private Sub txtValorVenda_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorVenda.Leave
        CalculaPorcentagem()
    End Sub

    Private Sub txtPorcentagem_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPorcentagem.Leave
        If Me.txtTotalCusto.Text.Trim = "" Then Exit Sub
        If Me.txtPorcentagem.Text.Trim = "" Then Exit Sub

        Dim dblValCus, dblResul As Double
        Dim dblPor As Double = txtPorcentagem.Text

        dblValCus = Me.txtTotalCusto.Text

        dblResul = (dblValCus * dblPor) / 100

        dblResul = dblValCus + dblResul

        Me.txtValorVenda.Text = dblResul.ToString("0.00")
        Me.txtDesc.Focus()
    End Sub

    Private Sub CalculaPorcentagem()
        If Me.txtValorVenda.Text.Trim = "" Then Exit Sub
        If Me.txtTotalCusto.Text.Trim = "" Then Exit Sub
        If Preco(Me.txtValorVenda) = False Then Exit Sub

        Dim dblValVenda, dblValCusto, dblLucro, dblMargem As Double

        dblValVenda = Me.txtValorVenda.Text.Trim
        dblValCusto = Me.txtTotalCusto.Text.Trim

        dblLucro = dblValVenda - dblValCusto

        dblMargem = (dblLucro * 100) / dblValCusto
        Dim str As String = dblMargem

        If str <> "+Infinito" Then
            Me.txtPorcentagem.Text = dblMargem.ToString("0.00")
        End If
        Me.txtDesc.Focus()
    End Sub

    Private Sub btnCadGrp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadGrp.Click
        frmGrupo.Tag = "GRUPO"
        frmGrupo.ShowDialog()
        Me.cboGrp.Properties.Items.Clear()
        PreencherGrupoSetorCusto("G", Me.cboGrp)
        Me.cboGrp.Focus()
    End Sub

    Private Sub btnCadSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadSet.Click
        frmGrupo.Tag = "SETOR"
        frmGrupo.ShowDialog()
        Me.cboSet.Properties.Items.Clear()
        PreencherGrupoSetorCusto("S", Me.cboSet)
        Me.cboSet.Focus()
    End Sub

    Private Sub txtDesc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesc.KeyPress, txtNomePro.KeyPress, txtCodReceita.KeyPress, txtCodPro.KeyPress
        If e.KeyChar = "'" Or e.KeyChar = "&" Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnMontarKit_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMontarKit.ItemClick

        If MsgBox("O kit será salvo e montado, deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SalvarReceita()

            Dim intKit As Integer = Me.txtQtdKit.Text
            Dim A As Integer


            For I = 0 To Me.grd1.RowCount - 1
                Dim strCodProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto)
                Dim strNomeProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                Dim dblQtd As Double = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                dblQtd = dblQtd * intKit
                If VerificarQtd(strCodProd, dblQtd, strNomeProd) = False Then
                    Exit Sub
                End If
            Next

            'For A = 0 To intKit - 1
            '    For I = 0 To Me.grd1.RowCount - 1
            '        Dim strCodProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto)
            '        Dim strUM As String
            '        Dim dtUM As DataTable = CarregarDataTable("SELECT UnidadeMedida FROM Produto where Codigo = " & strCodProd)
            '        If dtUM.Rows.Count > 0 Then
            '            strUM = dtUM.Rows.Item(0).Item("UnidadeMedida").ToString
            '        Else
            '            strUM = "UN"
            '        End If
            '        Dim strTamanho As String = "U"
            '        Dim strQtd As String = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)

            '        BaixarProduto(strCodProd, strQtd, strTamanho, strUM, False, False)

            '        If EstoqueSomado = True Then
            '            Dim dblQtd As Double = strQtd
            '            dblQtd = dblQtd - (dblQtd + dblQtd)
            '            Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data, " & _
            '            "CodUser) VALUES (" & strCodProd & "," & Num(dblQtd) & "," & CodConfig & ",'KIT'," & _
            '            "'" & My.Computer.Clock.LocalTime & "'," & CodUser & ")")

            '            Dim dblResul As Double = AjusteQtde(CodConfig, strCodProd)

            '            Dim dtQtde As DataTable = CarregarDataTable("SELECT QtdMinima FROM Qtde where CodProd = " & strCodProd & " and CodConfig = " & CodConfig)
            '            If dtQtde.Rows.Count > 0 Then
            '                Dim dblQtdMinima As Double = dtQtde.Rows.Item(0).Item("QtdMinima")
            '                Dim intEmFalta As Integer = 1
            '                If dblResul > dblQtdMinima Then
            '                    intEmFalta = 0
            '                End If

            '                Atualizar("UPDATE Qtde set EmFalta = " & intEmFalta & " where CodProd = " & strCodProd & " and CodConfig = " & CodConfig)

            '            End If
            '        End If
            '    Next
            'Next




            For I = 0 To Me.grd1.RowCount - 1
                Dim strCodProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto)
                Dim strUM As String
                Dim dtUM As DataTable = CarregarDataTable("SELECT UnidadeMedida FROM Produto where Codigo = " & strCodProd)
                If dtUM.Rows.Count > 0 Then
                    strUM = dtUM.Rows.Item(0).Item("UnidadeMedida").ToString
                Else
                    strUM = "UN"
                End If
                Dim strTamanho As String = "U"
                Dim strQtd As String = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)

                strQtd = strQtd * intKit

                BaixarProduto(strCodProd, strQtd, strTamanho, strUM, False, False)

                If EstoqueSomado = True Then
                    Dim dblQtd As Double = strQtd
                    dblQtd = dblQtd - (dblQtd + dblQtd)
                    Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data, " & _
                    "CodUser) VALUES (" & strCodProd & "," & Num(dblQtd) & "," & CodConfig & ",'KIT'," & _
                    "'" & My.Computer.Clock.LocalTime & "'," & CodUser & ")")

                    Dim dblResul As Double = AjusteQtde(CodConfig, strCodProd)

                    Dim dtQtde As DataTable = CarregarDataTable("SELECT QtdMinima FROM Qtde where CodProd = " & strCodProd & " and CodConfig = " & CodConfig)
                    If dtQtde.Rows.Count > 0 Then
                        Dim dblQtdMinima As Double = dtQtde.Rows.Item(0).Item("QtdMinima")
                        Dim intEmFalta As Integer = 1
                        If dblResul > dblQtdMinima Then
                            intEmFalta = 0
                        End If

                        Atualizar("UPDATE Qtde set EmFalta = " & intEmFalta & " where CodProd = " & strCodProd & " and CodConfig = " & CodConfig)

                    End If
                End If
            Next


            If BaixaPorLote = True Then
                Inserir("Insert Into Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, EmFalta, " & _
                "ValorCusto, CodConfig, Acabou, DataFim) Values(" & intCodigoProduto & ",'U'," & _
                "" & 0 & "," & Num(intKit) & ",'U','" & 0 & "'," & Num(Me.txtTotalCusto.Text) & "," & _
                "" & CodConfig & ",'False','01/01/1900')")
            Else
                Dim dtConf As DataTable = CarregarDataTable("Select Codigo from Config Order by Codigo")
                Dim Y As Integer
                For Y = 0 To dtConf.Rows.Count - 1
                    Dim intCodConfigTabQtde, intCodConfigItemNF As Integer
                    intCodConfigTabQtde = dtConf.Rows.Item(Y).Item("Codigo").ToString
                    intCodConfigItemNF = CodConfig
                    If intCodConfigTabQtde = intCodConfigItemNF Then
                        Dim dtQtd5 As DataTable = CarregarDataTable("Select Qtd, QtdMinima from Qtde where CodProd =" & intCodigoProduto & " and CodConfig=" & intCodConfigItemNF)
                        If dtQtd5.Rows.Count > 0 Then

                            Dim dblQtd5, dblQtdMin5, dblResQtd As Double
                            Dim intFalta As Integer = 0

                            dblQtd5 = dtQtd5.Rows.Item(0).Item("Qtd").ToString
                            dblQtdMin5 = dtQtd5.Rows.Item(0).Item("QtdMinima").ToString

                            dblResQtd = dblQtd5 + intKit

                            If dblQtdMin5 >= dblResQtd Then
                                intFalta = 1
                            End If
                            'MEDIA VALOR DE CUSTO - Somente Estoque Somado  
                            If EstoqueSomado = True Then

                                Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data, CodUser) VALUES (" & _
                               "" & intCodigoProduto & "," & Num(intKit) & "," & CodConfig & ",'KIT','" & My.Computer.Clock.LocalTime & "'," & CodUser & ")")
                            End If

                            Atualizar("Update Qtde set Qtd =" & Num(dblResQtd) & ", EmFalta ='" & intFalta & "', ValorCusto =" & Num(Me.txtTotalCusto.Text) & " where CodProd =" & intCodigoProduto & " and CodConfig=" & intCodConfigItemNF)
                        End If
                    End If

                Next

            End If


            MsgBox("Kit montado com sucesso!", MsgBoxStyle.Information)
            Me.txtQtdKit.ResetText()
        End If


        Limpar(True, False)

    End Sub

    Private Sub btnDesmontar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDesmontar.ItemClick

        If MsgBox("O Kit será salvo e desmontado, deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SalvarReceita()

            Dim intKit As Integer = Me.txtQtdKit.Text
            Dim A As Integer

            'For A = 0 To intKit - 1


            '    For I = 0 To Me.grd1.RowCount - 1
            '        Dim strCodProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto)
            '        Dim strUM As String
            '        Dim dtUM As DataTable = CarregarDataTable("SELECT UnidadeMedida FROM Produto where Codigo = " & strCodProd)
            '        If dtUM.Rows.Count > 0 Then
            '            strUM = dtUM.Rows.Item(0).Item("UnidadeMedida").ToString
            '        Else
            '            strUM = "UN"
            '        End If
            '        Dim strTamanho As String = "U"
            '        Dim strQtd As String = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)

            '        Dim dtQtd5 As DataTable = CarregarDataTable("Select Qtd, QtdMinima from Qtde where CodProd =" & strCodProd & " and CodConfig=" & CodConfig)
            '        If dtQtd5.Rows.Count > 0 Then

            '            Dim dblQtd5, dblQtdMin5, dblResQtd As Double
            '            Dim intFalta As Integer = 0

            '            dblQtd5 = dtQtd5.Rows.Item(0).Item("Qtd").ToString
            '            dblQtdMin5 = dtQtd5.Rows.Item(0).Item("QtdMinima").ToString

            '            dblResQtd = dblQtd5 + strQtd

            '            If dblQtdMin5 >= dblResQtd Then
            '                intFalta = 1
            '            End If


            '            Atualizar("Update Qtde set Qtd =" & Num(dblResQtd) & ", EmFalta ='" & intFalta & "' where CodProd =" & strCodProd & " and CodConfig=" & CodConfig)

            '            If EstoqueSomado = True Then
            '                Dim dblQtd As Double = strQtd
            '                'dblQtd = dblQtd - (dblQtd + dblQtd)
            '                Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data, " & _
            '                "CodUser) VALUES (" & strCodProd & "," & Num(dblQtd) & "," & CodConfig & ",'KIT'," & _
            '                "'" & My.Computer.Clock.LocalTime & "'," & CodUser & ")")

            '                Dim dblResul As Double = AjusteQtde(CodConfig, strCodProd)

            '                Dim dtQtde As DataTable = CarregarDataTable("SELECT QtdMinima FROM Qtde where CodProd = " & strCodProd & " and CodConfig = " & CodConfig)
            '                If dtQtde.Rows.Count > 0 Then

            '                    Dim dblQtdMinima As Double = dtQtde.Rows.Item(0).Item("QtdMinima")
            '                    Dim intEmFalta As Integer = 1
            '                    If dblResul > dblQtdMinima Then
            '                        intEmFalta = 0
            '                    End If

            '                    Atualizar("UPDATE Qtde set EmFalta = " & intEmFalta & " where CodProd = " & strCodProd & " and CodConfig = " & CodConfig)

            '                End If

            '            End If
            '        End If

            '    Next
            'Next

         

            For I = 0 To Me.grd1.RowCount - 1
                Dim strCodProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto)
                Dim strUM As String
                Dim dtUM As DataTable = CarregarDataTable("SELECT UnidadeMedida FROM Produto where Codigo = " & strCodProd)
                If dtUM.Rows.Count > 0 Then
                    strUM = dtUM.Rows.Item(0).Item("UnidadeMedida").ToString
                Else
                    strUM = "UN"
                End If
                Dim strTamanho As String = "U"
                Dim strQtd As String = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                strQtd = strQtd * intKit
                Dim dtQtd5 As DataTable = CarregarDataTable("Select Qtd, QtdMinima from Qtde where CodProd =" & strCodProd & " and CodConfig=" & CodConfig)
                If dtQtd5.Rows.Count > 0 Then

                    Dim dblQtd5, dblQtdMin5, dblResQtd As Double
                    Dim intFalta As Integer = 0

                    dblQtd5 = dtQtd5.Rows.Item(0).Item("Qtd").ToString
                    dblQtdMin5 = dtQtd5.Rows.Item(0).Item("QtdMinima").ToString

                    dblResQtd = dblQtd5 + strQtd

                    If dblQtdMin5 >= dblResQtd Then
                        intFalta = 1
                    End If


                    Atualizar("Update Qtde set Qtd =" & Num(dblResQtd) & ", EmFalta ='" & intFalta & "' where CodProd =" & strCodProd & " and CodConfig=" & CodConfig)

                    If EstoqueSomado = True Then
                        Dim dblQtd As Double = strQtd
                        'dblQtd = dblQtd - (dblQtd + dblQtd)
                        Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data, " & _
                        "CodUser) VALUES (" & strCodProd & "," & Num(dblQtd) & "," & CodConfig & ",'KIT'," & _
                        "'" & My.Computer.Clock.LocalTime & "'," & CodUser & ")")

                        Dim dblResul As Double = AjusteQtde(CodConfig, strCodProd)

                        Dim dtQtde As DataTable = CarregarDataTable("SELECT QtdMinima FROM Qtde where CodProd = " & strCodProd & " and CodConfig = " & CodConfig)
                        If dtQtde.Rows.Count > 0 Then

                            Dim dblQtdMinima As Double = dtQtde.Rows.Item(0).Item("QtdMinima")
                            Dim intEmFalta As Integer = 1
                            If dblResul > dblQtdMinima Then
                                intEmFalta = 0
                            End If

                            Atualizar("UPDATE Qtde set EmFalta = " & intEmFalta & " where CodProd = " & strCodProd & " and CodConfig = " & CodConfig)

                        End If

                    End If
                End If

            Next

            Dim dtUM2 As DataTable = CarregarDataTable("SELECT UnidadeMedida FROM Produto where Codigo = " & intCodigoProduto)
            Dim strUM2 As String
            If dtUM2.Rows.Count > 0 Then
                strUM2 = dtUM2.Rows.Item(0).Item("UnidadeMedida").ToString
            Else
                strUM2 = "UN"
            End If
            If BaixaPorLote = True Then

                BaixarProduto(intCodigoProduto, intKit, "U", strUM2, False, False)

            Else
                Dim dtConf As DataTable = CarregarDataTable("Select Codigo from Config Order by Codigo")
                Dim Y As Integer
                For Y = 0 To dtConf.Rows.Count - 1
                    Dim intCodConfigTabQtde, intCodConfigItemNF As Integer
                    intCodConfigTabQtde = dtConf.Rows.Item(Y).Item("Codigo").ToString
                    intCodConfigItemNF = CodConfig
                    If intCodConfigTabQtde = intCodConfigItemNF Then
                        Dim dtQtd5 As DataTable = CarregarDataTable("Select Qtd, QtdMinima from Qtde where CodProd =" & intCodigoProduto & " and CodConfig=" & intCodConfigItemNF)
                        If dtQtd5.Rows.Count > 0 Then
                            BaixarProduto(intCodigoProduto, intKit, "U", strUM2, False, False)

                            'MEDIA VALOR DE CUSTO - Somente Estoque Somado  
                            If EstoqueSomado = True Then
                                intKit = intKit - (intKit + intKit)
                                Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data, CodUser) VALUES (" & _
                               "" & intCodigoProduto & "," & Num(intKit) & "," & CodConfig & ",'KIT','" & My.Computer.Clock.LocalTime & "'," & CodUser & ")")


                                Dim dblResul As Double = AjusteQtde(CodConfig, intCodigoProduto)

                                Dim dtQtde As DataTable = CarregarDataTable("SELECT QtdMinima FROM Qtde where CodProd = " & intCodigoProduto & " and CodConfig = " & CodConfig)
                                If dtQtde.Rows.Count > 0 Then

                                    Dim dblQtdMinima As Double = dtQtde.Rows.Item(0).Item("QtdMinima")
                                    Dim intEmFalta As Integer = 1
                                    If dblResul > dblQtdMinima Then
                                        intEmFalta = 0
                                    End If

                                    Atualizar("UPDATE Qtde set EmFalta = " & intEmFalta & " where CodProd = " & intCodigoProduto & " and CodConfig = " & CodConfig)

                                End If
                            End If


                        End If
                    End If

                Next

            End If

            MsgBox("Kit desmontado com sucesso!", MsgBoxStyle.Information)
            Me.txtQtdKit.ResetText()
        End If


    End Sub

    Private Sub SalvarReceita()
        Dim vetDelete As Array = Split(strItensDeletado, "|")

        For I = 0 To vetDelete.Length - 1
            If vetDelete(I) = "" Then Exit For
            Dim strDelete As String
            strDelete = "Delete From ItensReceita where Codigo =" & vetDelete(I)
            Excluir(strDelete)
        Next

        Dim strStatus As String
        strStatus = "Pendente"
        For I = 0 To grd1.RowCount - 1
            Dim strCodigo, strCodigoInterno, strQtd, strCodPedAut, strCusto, strValor, strTipoValor As String
            strCodPedAut = grd1.GetRowCellDisplayText(I, Me.colCodPedAut)
            strCodigo = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto)
            strCodigoInterno = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoPeca)
            strQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
            strCusto = Me.grd1.GetRowCellDisplayText(I, Me.colCusto)
            strValor = Me.grd1.GetRowCellDisplayText(I, Me.colValor)
            strTipoValor = Me.grd1.GetRowCellDisplayText(I, Me.colTipoValor)


            If strCodPedAut = "Inserir" Then
                grd1.SetRowCellValue(I, Me.colCodPedAut, "OK")
                Inserir("Insert into ItensReceita (CodigoInterno, CodProd, CodProdInterno, Custo, Qtd, " & _
                "Valor, TipoValor) Values('" & Me.txtCodReceita.Text.Trim & "'," & strCodigo & "," & _
                "'" & strCodigoInterno & "'," & Num(strCusto) & "," & Num(strQtd) & "," & Num(strValor) & "," & _
                "'" & strTipoValor & "')")
            Else
                If strCodPedAut <> "OK" Then
                    Atualizar("Update ItensReceita set CodProd ='" & strCodigo & "', CodProdInterno ='" & strCodigoInterno & "', " & _
                    "Custo =" & Num(strCusto) & ", Qtd =" & Num(strQtd) & ", Valor =" & Num(strValor) & ", " & _
                    "TipoValor = '" & strTipoValor & "' where Codigo =" & strCodPedAut.Trim)
                End If
            End If
        Next
        Atualizar("Update Receita set Nome ='" & Me.txtNome.Text.Trim & "', Obs ='" & Me.txtDesc.Text.Trim.Replace("'", "").Replace("&", "E") & "', ValorCusto = " & Num(Me.txtTotalCusto.Text.Trim) & ", ValorVenda =" & Num(Me.txtValorVenda.Text.Trim) & " where CodigoInterno ='" & Me.txtCodReceita.Text.Trim & "'")
        Atualizar("UPDATE Produto SET Nome ='" & Me.txtNome.Text.Trim & "', ValorCusto =" & Num(Me.txtTotalCusto.Text.Trim) & ", Valor=" & Num(Me.txtValorVenda.Text.Trim) & ", Porcentagens='" & Me.txtPorcentagem.Text.Trim & "', Grupo = '" & Me.cboGrp.Text.Trim & "', Setor ='" & Me.cboSet.Text.Trim & "' where CodigoInterno = '" & Me.txtCodReceita.Text.Trim & "'")
        bolSalvar = True
    End Sub

    Private Sub btnSalvarMontar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvarMontar.ItemClick
        If TesteConexao() = False Then Exit Sub
        Salvar(False)

        If bolSalvar = True Then
            Me.Close()
            Dim frm As New frmReceita
            frm.Tag = "ALTERA"
            frm.txtCodReceita.Text = strCodigoReceita
            frm.txtDesc.Focus()
            frm.Show()
        End If
       
       
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.txtCodPro.Focus()
        Timer1.Stop()
    End Sub


    Private Function VerificarQtd(ByVal parCodProd As String, ByVal parQtd As Double, ByVal parNome As String) As Boolean
        If PermiteEstoqueZerado = False Then

            If EstoqueSomado = False Then
                Dim dtQtd As DataTable = CarregarDataTable("Select sum(Qtd) as Qtd from Qtde where " & _
                "CodProd =" & parCodProd & " and Acabou = 'False' and CodConfig =" & CodConfig)

                If dtQtd.Rows.Count = 0 Then
                    MsgBox("Não existe a quantidade adicionada do produto " & parNome & " em estoque!", MsgBoxStyle.Information)
                    Return False
                    Exit Function
                Else
                    Dim dtQtd2 As DataTable = CarregarDataTable("Select sum(Qtd) as Qtd from Qtde where CodProd =" & parCodProd & " and Acabou = 'False' and CodConfig =" & CodConfig)


                    Dim dblQtdTabQtde As Double = 0

                    If dtQtd2.Rows(0).Item("Qtd").ToString <> "" Then
                        dblQtdTabQtde = dtQtd2.Rows(0).Item("Qtd").ToString
                    End If

                    If parQtd > dblQtdTabQtde Then
                        MsgBox("Não existe a quantidade adicionada do produto " & parNome & " em estoque!", MsgBoxStyle.Information)
                        Me.txtCodPro.ResetText()
                        Me.txtQtd.ResetText()
                        Return False
                        Exit Function
                    End If

                End If
            Else

                Dim dblResul As Double = AjusteQtde(CodConfig, parCodProd)

                If dblResul <= 0 Then
                    MsgBox("Não existe a quantidade adicionada do produto " & parNome & " em estoque!", MsgBoxStyle.Information)
                    Me.txtCodPro.ResetText()
                    Me.txtQtd.ResetText()
                    Return False
                    Exit Function
                Else
                    If parQtd > dblResul Then
                        MsgBox("Não existe a quantidade adicionada do produto " & parNome & " em estoque!", MsgBoxStyle.Information)
                        Me.txtCodPro.ResetText()
                        Me.txtQtd.ResetText()
                        Return False
                        Exit Function
                    End If
                End If
            End If
        End If

        Return True
    End Function

   
    Private Sub chkAlterar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAlterar.CheckedChanged
        Select Case Me.chkAlterar.Checked
            Case True
                Me.chkAlterar.BackColor = Color.White
                Me.txtCodReceita.Enabled = True
                Me.chkAlterar.Tag = Me.txtCodReceita.Text.Trim
            Case False
                Me.chkAlterar.BackColor = Color.Transparent
                Me.txtCodReceita.Enabled = False
                Me.txtCodReceita.Text = Me.chkAlterar.Tag
        End Select
    End Sub
End Class