Imports Nano.clsFuncoes
Imports Nano.clsImprimir

Public Class frmDevolucao
    Dim bolAlterado As Boolean = False
    Dim intCodProd As Integer
    Dim dblCredito As Double
    Dim strUM As String
    Dim strFoco As String
    Dim strValCusto As String
    Dim intCodOrdem As Integer
    Dim intQtdDev As Double
    Dim intCodCli As Integer
    Dim strCodigoBarra As String
    Dim strCodigoInterno As String
    Dim strUniSemDesc As String
    Private Sub Alterar()
        bolAlterado = True
        Dim intIndex As Integer = Me.grd1.FocusedRowHandle
        With Me.grd1
            CodigoDaVenda = .GetRowCellDisplayText(intIndex, Me.colCodVenda)
            Me.txtTamanho.Text = .GetRowCellDisplayText(intIndex, Me.colTamanho)
            Me.txtCodProd.Text = .GetRowCellDisplayText(intIndex, Me.colCodigo)
            Me.txtProd.Text = .GetRowCellDisplayText(intIndex, Me.colProduto)
            Me.txtQtde.Text = .GetRowCellDisplayText(intIndex, Me.colQtde)
            Me.txtValor.Text = .GetRowCellDisplayText(intIndex, Me.colValorUni)
            intCodLojaDevolucao = .GetRowCellDisplayText(intIndex, Me.colCodLoja)
            strUniSemDesc = .GetRowCellDisplayText(intIndex, Me.colUniSemDesc)
        End With

        Me.txtValor.BackColor = Color.Bisque
        Me.txtQtde.BackColor = Color.Bisque
        Me.txtProd.BackColor = Color.Bisque
        Me.txtCodProd.BackColor = Color.Bisque
        Me.txtTamanho.BackColor = Color.Bisque

    End Sub
    Private Sub Limpar()
        strUniSemDesc = ""
        Me.txtCliente.ResetText()
        Me.txtCpf.ResetText()
        Me.lueFunc.EditValue = DBNull.Value
        Me.txtMotivo.ResetText()
        Me.txtCodProd.ResetText()
        Me.txtProd.ResetText()
        Me.txtTamanho.ResetText()
        Me.txtQtde.ResetText()
        Me.txtValor.ResetText()
        Me.txtTotal.Text = ""
        Me.tbProd.Rows.Clear()
        Me.lueFunc.Focus()
        bolAlterado = False
    End Sub
    Private Sub Calcular()
        Dim I As Integer
        Dim dblVal, dblResul As Double
        For I = 0 To Me.tbProd.Rows.Count - 1
            dblVal = Me.grd1.GetRowCellDisplayText(I, Me.colValorTotal)
            dblResul += dblVal
        Next
        Me.txtTotal.Text = dblResul.ToString("###,###,###,##0.00")
    End Sub

    Private Sub frmDevolucao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "8")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmDevolucao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub
        CarregarDadosLue("SELECT Nome, Codigo FROM Funcionario where Ativo ='True' and CodConfig =" & CodConfig, Me.lueFunc)
        Tamanho(True)
        Me.lueFunc.Focus()
    End Sub

    Private Sub txtCliente_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCliente.ButtonClick
      BuscaCliente()
    End Sub

    Private Sub BuscaCliente()

        Dim frm As New frmCadCliente
        frm.Tag = "PESQUISADEVOLUCAO"
        frm.ShowDialog()

        Dim dt As DataTable
        dt = CarregarDataTable("SELECT Nome, CPF, Credito FROM Cliente where Codigo = " & CodigoDoCliente)
        If dt.Rows.Count > 0 Then
            intCodCli = CodigoDoCliente
            If dt.Rows.Item(0).Item("Nome").ToString.Contains("CONSUMIDOR") = True Then
                CodigoDoCliente = 0
                MsgBox("Não é possível fazer devoluções para o cliente CONSUMIDOR!", MsgBoxStyle.Information)
                Exit Sub
            End If

            Me.txtCliente.Text = dt.Rows.Item(0).Item("Nome").ToString
            Me.txtCpf.Text = dt.Rows.Item(0).Item("CPF").ToString
            If dt.Rows.Item(0).Item("Credito").ToString = "" Then
                dblCredito = 0
            Else
                dblCredito = dt.Rows.Item(0).Item("Credito").ToString
            End If
            Me.txtCodProd.Focus()
        End If

    End Sub

    Private Sub txtCodProd_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodProd.ButtonClick
        BuscaProduto()
    End Sub

    Private Sub BuscaProduto()
        Dim frm As New frmConPedido
        frm.Tag = "DEVOLUÇÃO"
        NomeDoCliente = Me.txtCliente.Text
        intCodLojaDevolucao = 0
        frm.ShowDialog()

        Me.txtCodProd.Text = CodigoDaVenda
        InserirProduto()
    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click
        If Validar(Me.txtCodProd) = False Then Exit Sub
        If Validar(Me.txtCliente) = False Then Exit Sub
        If Validar(Me.txtProd) = False Then Exit Sub
        If Validar(Me.txtValor) = False Then Exit Sub
        If Validar(Me.lueFunc) = False Then Exit Sub
        If Validar(Me.txtTamanho) = False Then Exit Sub

        Dim dblValorTotal, dblValorUni As Double
        Dim intQtde As Integer
        dblValorUni = Me.txtValor.Text.Trim


        If Me.txtQtde.Text.Trim = "" Then
            intQtde = 1
        Else
            intQtde = Me.txtQtde.Text.Trim
        End If

        dblValorTotal = intQtde * dblValorUni

        With Me.tbProd.Rows
            Select Case bolAlterado
                Case False
                    .Add()
                    .Item(.Count - 1).Item("Codigo") = intCodProd
                    .Item(.Count - 1).Item("CodProdInterno") = strCodigoInterno
                    .Item(.Count - 1).Item("CodigoBarra") = strCodigoBarra
                    .Item(.Count - 1).Item("Produto") = Me.txtProd.Text.Trim
                    .Item(.Count - 1).Item("Tamanho") = Me.txtTamanho.Text.Trim
                    .Item(.Count - 1).Item("Qtde") = intQtde
                    .Item(.Count - 1).Item("ValorUni") = Me.txtValor.Text.Trim
                    .Item(.Count - 1).Item("ValorCusto") = strValCusto
                    .Item(.Count - 1).Item("ValorTotal") = dblValorTotal.ToString("0.00")
                    .Item(.Count - 1).Item("CodVenda") = CodigoDaVenda
                    .Item(.Count - 1).Item("CodOrdem") = intCodOrdem
                    .Item(.Count - 1).Item("QtdDev") = intQtdDev
                    .Item(.Count - 1).Item("CodLoja") = intCodLojaDevolucao
                    If strUniSemDesc <> "" Then
                        .Item(.Count - 1).Item("UniSemDesc") = strUniSemDesc
                    Else
                        .Item(.Count - 1).Item("UniSemDesc") = Me.txtValor.Text.Trim
                    End If

                Case True
                    Dim intIndex As Integer = Me.grd1.FocusedRowHandle
                    .Item(intIndex).Item("Codigo") = intCodProd
                    .Item(intIndex).Item("CodProdInterno") = strCodigoInterno
                    .Item(intIndex).Item("CodigoBarra") = strCodigoBarra
                    .Item(intIndex).Item("Produto") = Me.txtProd.Text.Trim
                    .Item(intIndex).Item("Tamanho") = Me.txtTamanho.Text.Trim
                    .Item(intIndex).Item("Qtde") = intQtde
                    .Item(intIndex).Item("ValorUni") = Me.txtValor.Text.Trim
                    .Item(intIndex).Item("ValorCusto") = strValCusto
                    .Item(intIndex).Item("ValorTotal") = dblValorTotal.ToString("0.00")
                    .Item(intIndex).Item("CodVenda") = CodigoDaVenda
                    .Item(intIndex).Item("CodOrdem") = intCodOrdem
                    .Item(intIndex).Item("QtdDev") = intQtdDev
                    .Item(intIndex).Item("CodLoja") = intCodLojaDevolucao
                    If strUniSemDesc <> "" Then
                        .Item(intIndex).Item("UniSemDesc") = strUniSemDesc
                    Else
                        .Item(intIndex).Item("UniSemDesc") = Me.txtValor.Text.Trim
                    End If
                    Me.txtValor.BackColor = Color.White
                    Me.txtQtde.BackColor = Color.White
                    Me.txtProd.BackColor = Color.White
                    Me.txtCodProd.BackColor = Color.White
                    Me.txtTamanho.BackColor = Color.White
            End Select
        End With
        Calcular()

        bolAlterado = False

        Me.txtValor.ResetText()
        Me.txtTamanho.ResetText()
        Tamanho(True)
        Me.txtQtde.ResetText()
        Me.txtProd.ResetText()
        Me.txtCodProd.ResetText()
        Me.txtCodProd.Focus()
    End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        Alterar()
    End Sub

    Private Sub txtCodProd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodProd.Leave
        InserirProduto()
    End Sub

    Private Sub InserirProduto()
        If Me.txtCodProd.Text = "" Then Exit Sub

        Dim dt As DataTable

        dt = CarregarDataTable("SELECT CodOrdem, CodProd, Produto.CodigoInterno, CodProdInterno, Produto.CodigoBarra, " & _
        "Produto as Nome, ValorUnitario, UM, Custo, Tamanho, Qtd, UniSemDesc FROM Pedido left join Produto on Pedido.CodProd = Produto.Codigo " & _
        "where Pedido.Codigo = " & CodigoDaVenda)

        If dt.Rows.Count > 0 Then
            intQtdDev = dt.Rows.Item(0).Item("Qtd").ToString
            intCodOrdem = dt.Rows.Item(0).Item("CodOrdem").ToString
            intCodProd = dt.Rows.Item(0).Item("CodProd").ToString
            Me.txtCodProd.Text = dt.Rows.Item(0).Item("CodProdInterno").ToString
            Me.txtProd.Text = dt.Rows.Item(0).Item("Nome").ToString
            Me.txtValor.Text = dt.Rows.Item(0).Item("ValorUnitario").ToString
            strUM = dt.Rows.Item(0).Item("UM").ToString
            strValCusto = dt.Rows.Item(0).Item("Custo").ToString
            strCodigoInterno = dt.Rows.Item(0).Item("CodigoInterno").ToString
            strCodigoBarra = dt.Rows.Item(0).Item("CodigoBarra").ToString
            Me.txtTamanho.Text = dt.Rows.Item(0).Item("Tamanho").ToString

            strUniSemDesc = dt.Rows.Item(0).Item("UniSemDesc").ToString

            Me.txtQtde.Focus()
        Else
            Me.txtCodProd.ResetText()
            Me.txtCodProd.Focus()
        End If
    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick

        If TesteConexao() = False Then Exit Sub

        If Me.tbProd.Rows.Count <= 0 Then
            MsgBox("Não existem produtos a ser devolvido!", MsgBoxStyle.Information)
            Exit Sub
        End If
        If Validar(Me.lueFunc) = False Then Exit Sub
        If Validar(Me.txtCliente) = False Then Exit Sub

        Dim I, intCodigo, intCod, intCodLoja As Integer
        Dim dblValor, dblQtd, dblQtdDev, dblValorTotal, dblCustoTotal, dblCusPed As Double
        Dim strTamanho As String
        For I = 0 To Me.tbProd.Rows.Count - 1
            intCod = Me.grd1.GetRowCellDisplayText(I, Me.colCodVenda)
            intCodigo = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)
            strTamanho = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho)
            dblValorTotal = Me.grd1.GetRowCellDisplayText(I, Me.colValorTotal)
            dblValor = Me.grd1.GetRowCellDisplayText(I, Me.colValorUni)
            intCodOrdem = Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem)
            intCodLoja = Me.grd1.GetRowCellDisplayText(I, Me.colCodLoja)
            dblQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtde)
            dblQtdDev = Me.grd1.GetRowCellDisplayText(I, Me.colQtdDev)
            dblCustoTotal = CDbl(Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto)) / dblQtdDev
            Dim dblUniSemDesc As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValorUni)
            If Me.grd1.GetRowCellDisplayText(I, Me.colUniSemDesc) <> "" Then
                dblUniSemDesc = Me.grd1.GetRowCellDisplayText(I, Me.colUniSemDesc)
            End If
            dblCusPed = dblCustoTotal * (dblQtdDev - dblQtd)
            ''''''
            'If dblQtdDev > dblQtd Then
            '    Dim dblResul As Double = dblQtdDev - dblQtd
            '    Dim dblResulValor As Double = dblResul * dblValor
            '    Atualizar("UPDATE Pedido SET Qtd = " & Num(dblResul) & ", ValorTotal = " & Num(dblResulValor) & ", Custo =" & Num(dblCusPed) & " where Codigo = " & intCod)
            'ElseIf dblQtdDev = dblQtd Then
            '    Dim bolDevol As Boolean
            '    bolDevol = True
            '    Atualizar("UPDATE Pedido SET Devolvido = '" & bolDevol & "' where Codigo = " & intCod)
            'End If
            ''''''
            Dim strProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
            Dim strCodProdInt As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodProdInterno)
            Dim strCodFunc As String = Me.lueFunc.GetColumnValue("Codigo")

            Dim strMotivo As String = "DEVOLVIDO DA VENDA Nº " & intCodOrdem & ", CÓDIGO AUTOMÁTICO Nº " & Me.grd1.GetRowCellDisplayText(I, Me.colCodVenda)
            If Me.txtMotivo.Text <> "" Then
                strMotivo &= " - " & Me.txtMotivo.Text
            End If


            Inserir("INSERT INTO Devolucao (CodProd, Qtde, CodCli, Data, CodFunc, Motivo, Tamanho, Valor, " & _
            "CodConfig) VALUES (" & intCodigo & "," & Num(Me.grd1.GetRowCellDisplayText(I, Me.colQtde)) & "," & _
            "'" & intCodCli & "','" & Date.Today & "','" & Me.lueFunc.GetColumnValue("Codigo") & "','" & strMotivo & "'," & _
            "'" & strTamanho & "'," & Num(dblValor) & "," & CodConfig & ")")

            Dim dblQtde As Double = -dblQtd
            Dim dtPed As DataTable = CarregarDataTable("SELECT CodFunc FROM Pedido WHERE CodOrdem = " & intCodOrdem & " and CodConfig = " & CodConfig)
            If dtPed.Rows.Count > 0 Then
                If dtPed.Rows.Item(0).Item("CodFunc").ToString <> "" Then
                    strCodFunc = dtPed.Rows.Item(0).Item("CodFunc").ToString
                End If
            End If
            Inserir("Insert into Pedido (CodOrdem, Qtd, CodProd, Produto, ValorUnitario, ValorTotal, CodProdInterno, " & _
            "CodFunc, Custo, Um, Tamanho, Lote, TipoItens, CodConfig, Devolvido, CodMecanico, UniSemDesc) Values(" & intCodOrdem & "," & _
            "" & Num(dblQtde) & "," & intCodigo & ",'" & strProd & "'," & Num(-dblValor) & "," & Num(-dblValorTotal) & "," & _
            "'" & strCodProdInt & "'," & strCodFunc & "," & Num(0) & ",'" & strUM & "','" & strTamanho & "'," & _
            "'','VENDA'," & CodConfig & ",'False',NULL," & Num(dblUniSemDesc) & ")")
            ''''

            Atualizar("UPDATE Qtde SET DataFim = '01/01/1900' where CodProd = " & intCodigo & " and CodConfig = " & CodConfig)

            If BaixaPorLote = True Then
                Inserir("INSERT INTO Qtde (CodProd, Tamanho, Qtd, QtdMinima, Lote, EmFalta, ValorCusto, CodConfig, Acabou, DataFim) VALUES (" & intCodigo & ",'" & strTamanho & "'," & Num(Me.grd1.GetRowCellDisplayText(I, Me.colQtde)) & "," & "0" & ",'" & "DEVOLUÇÃO" & "','" & "0" & "'," & Num(Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto)) & "," & CodConfig & ",'False','01/01/1900')")

            Else

                Dim dtQtdePro As DataTable = CarregarDataTable("Select Qtd, QtdMinima from Qtde  where CodProd = " & intCodigo & " and CodConfig = " & CodConfig)

                Dim dblRes, dblQt, dblQtMin As Double

                Dim intFal As Integer = 0

                dblQt = dtQtdePro.Rows.Item(0).Item("Qtd")
                dblQtMin = dtQtdePro.Rows.Item(0).Item("QtdMinima")

                dblRes = dblQt + dblQtd

                If dblQtMin >= dblRes Then
                    intFal = 1
                End If

                Atualizar("Update Qtde set Qtd =" & Num(dblRes.ToString("0.000")) & ", EmFalta ='" & intFal & "' where CodProd = " & intCodigo & " and CodConfig = " & CodConfig)


                'If EstoqueSomado = True Then
                '    Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data) VALUES (" & intCodigo & "," & Num(dblQtd) & "," & CodConfig & ",'DEVOLUÇÃO','" & My.Computer.Clock.LocalTime & "')")
                'End If
            End If


            Dim dtTotal As DataTable
            dtTotal = CarregarDataTable("SELECT Total, Custo, PorDesc FROM Total where CodOrdem = " & intCodOrdem & " and CodConfig =" & intCodLoja)
            If dtTotal.Rows.Count > 0 Then
                Dim dblTotal, dblResulTotal, dblCusto, dblResulCusto As Double
                dblTotal = dtTotal.Rows.Item(0).Item("Total").ToString
                dblCusto = dtTotal.Rows.Item(0).Item("Custo").ToString
                If NomeEmpresa.Contains("RAISNER") Then
                    If dtTotal.Rows.Item(0).Item("PorDesc").ToString <> "" Then
                        Dim dblPorc As Double = dtTotal.Rows.Item(0).Item("PorDesc").ToString
                        dblValorTotal = dblValorTotal - ((dblValorTotal * dblPorc) / 100)
                    End If
                End If
             
                dblResulTotal = dblTotal - dblValorTotal
                dblResulCusto = dblCusto - dblCustoTotal
                Atualizar("UPDATE Total SET Total = " & Num(dblResulTotal) & ", Custo =" & Num(dblResulCusto) & " where CodOrdem = " & intCodOrdem & " and CodConfig =" & intCodLoja)
            End If
        Next

        Dim dblTot As Double = Me.txtTotal.Text

        dblTot += dblCredito

        Atualizar("UPDATE Cliente SET Credito = '" & dblTot.ToString("0.00") & "' where Codigo = " & intCodCli)
        MsgBox("Devolução concluída com sucesso!", MsgBoxStyle.Information)

        Imprimir()
        If SegViaRecibo = True Then
            If MsgBox("Deseja imprimir a 2ª via?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Imprimir()
            End If
        End If
        Limpar()
    End Sub

    Private Sub Imprimir()
        Dim strImpressao As String = ""

        If PafEcfNano = False Then

            If TemImpressora = False Then Exit Sub

            If Impressora = "DARUMA" Then

                strImpressao = "<b><e><ce>VALE TROCA</ce></e></b>" & vbCrLf

                strImpressao &= "<l></l>" & vbCrLf


                strImpressao &= "<tc>#</tc>" & vbCrLf

                strImpressao &= "<b><e><ce>" & NomeEmpresa.ToString.Trim & "</ce></e></b>" & vbCrLf

                strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf

                strImpressao &= "<ce>" & TelefoneEmpresa & "</ce>" & vbCrLf
                strImpressao &= "<tc>#</tc>" & vbCrLf
                strImpressao &= "<ad><dt></dt></ad>" & vbCrLf
                strImpressao &= " ITEM VENDA Nº  DESCRIÇÃO                    " & vbCrLf
                strImpressao &= "<ad>TM.    QTD.    VL UNIT R$           VL Total R$</ad>" & vbCrLf
                strImpressao &= "<tc>-</tc>" & vbCrLf

                Dim L As Integer
                Dim strCod, strProd, strUni, strQtd, strTot, strTM As String

                strCod = ""
                For L = 0 To Me.grd1.RowCount - 1

                    strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodOrdem)
                    strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
                    strUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUni)
                    strQtd = Me.grd1.GetRowCellDisplayText(L, Me.colQtde)
                    strTot = Me.grd1.GetRowCellDisplayText(L, Me.colValorTotal)
                    strTM = Me.grd1.GetRowCellDisplayText(L, Me.colTamanho)

                    strImpressao &= "<c><i>  " & L + 1 & "   " & strCod & "   " & strProd & "</i></c>" & vbCrLf
                    Dim str As String
                    str = " " & strTM & "    " & Dir(strQtd & "  X  " & strUni, 21) & Esq(strTot, 20)
                    strImpressao &= str & vbCrLf
                Next


                strImpressao &= "<tc>-</tc>" & vbCrLf

                strImpressao &= "<ad><b>" & "Crédito R$ " & Esq(Me.txtTotal.Text.Trim, 9) & "</b></ad>" & vbCrLf

                strImpressao &= "<l></l>" & vbCrLf


                strImpressao &= "<tc>-</tc>" & vbCrLf


                Dim dt As DataTable

                dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & intCodCli)

                If dt.Rows.Count > 0 Then
                    If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                        strImpressao &= "<c>" & dt.Rows.Item(0).Item("Nome").ToString & "</c>" & vbCrLf
                    End If

                    If dt.Rows.Item(0).Item("Endereco").ToString <> "" Then
                        strImpressao &= "<c>" & dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & " " & dt.Rows.Item(0).Item("Complemento").ToString & "</c>" & vbCrLf
                    End If

                    If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                        strImpressao &= "<c>" & dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & "</c>" & vbCrLf
                    End If

                    If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                        strImpressao &= "<c>" & dt.Rows.Item(0).Item("Telefone").ToString & "</c>" & vbCrLf
                    End If

                End If

                strImpressao &= "<l></l>" & vbCrLf

                strImpressao &= "<ce>NÃO PERDER ESSE COMPROVANTE!</ce>" & vbCrLf
                strImpressao &= "<ce>É NECESSÁRIO A APRESENTAÇÃO DESTE NA TROCA.</ce>" & vbCrLf

                strImpressao &= "<l></l>" & vbCrLf

                strImpressao &= "<e><ce>DOCUMENTO NÃO FISCAL" & "</ce></e>" & vbCrLf

                strImpressao &= "<tc>-</tc>" & vbCrLf

                strImpressao &= "<l></l>" & vbCrLf
                strImpressao &= "<l></l>" & vbCrLf
                strImpressao &= "<l></l>" & vbCrLf

                If TemGuilhotina = True Then
                    strImpressao &= "<gui></gui>" & vbCrLf
                End If

                If ImpressoraOK() = True Then
                    iRetorno = (iImprimirTexto_DUAL_DarumaFramework(strImpressao, 0))
                End If
            End If

            If Impressora = "BEMATECH MP-4000" Then

                If Impressora.Contains("MP-4000") = True Then
                    iRetorno = ConfiguraModeloImpressora(5)
                    iRetorno = SelecionaQualidadeImpressao(3)
                Else
                    iRetorno = ConfiguraModeloImpressora(1)
                End If

                iRetorno = clsBematech.IniciaPorta(PortaImpressora)

                strImpressao = Cent("VALE TROCA", 60) & vbCrLf

                strImpressao &= " " & vbCrLf

                strImpressao &= "************************************************************" & vbCrLf

                strImpressao &= Cent(NomeEmpresa.ToString.Trim, 60) & vbCrLf
                strImpressao &= Cent(EnderecoEmpresa.Trim, 60) & vbCrLf
                strImpressao &= Cent(TelefoneEmpresa.Trim, 60) & vbCrLf

                strImpressao &= "************************************************************" & vbCrLf
                strImpressao &= Esq(Date.Today, 55) & vbCrLf

                strImpressao &= " ITEM VENDA Nº  DESCRIÇÃO                    " & vbCrLf
                strImpressao &= " TM.    QTD.    VL UNIT R$           VL Total R$" & vbCrLf
                strImpressao &= "------------------------------------------------------------" & vbCrLf

                Dim L As Integer
                Dim strCod, strProd, strUni, strQtd, strTot, strTM As String

                strCod = ""
                For L = 0 To Me.grd1.RowCount - 1

                    strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodOrdem)
                    strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
                    strUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUni)
                    strQtd = Me.grd1.GetRowCellDisplayText(L, Me.colQtde)
                    strTot = Me.grd1.GetRowCellDisplayText(L, Me.colValorTotal)
                    strTM = Me.grd1.GetRowCellDisplayText(L, Me.colTamanho)

                    strImpressao &= " " & L + 1 & "   " & strCod & "   " & strProd & vbCrLf
                    Dim str As String
                    str = " " & strTM & "    " & Dir(strQtd & "  X  " & strUni, 21) & Esq(strTot, 20)
                    strImpressao &= str & vbCrLf
                Next


                strImpressao &= "------------------------------------------------------------" & vbCrLf

                strImpressao &= " Crédito R$ " & Esq(Me.txtTotal.Text.Trim, 9) & vbCrLf

                strImpressao &= " " & vbCrLf


                strImpressao &= "------------------------------------------------------------" & vbCrLf


                Dim dt As DataTable


                dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & intCodCli)

                If dt.Rows.Count > 0 Then
                    If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                        strImpressao &= " " & dt.Rows.Item(0).Item("Nome").ToString & vbCrLf
                    End If

                    If dt.Rows.Item(0).Item("Endereco").ToString <> "" Then
                        strImpressao &= " " & dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & " " & dt.Rows.Item(0).Item("Complemento").ToString & vbCrLf
                    End If

                    If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                        strImpressao &= " " & dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & vbCrLf
                    End If

                    If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                        strImpressao &= " " & dt.Rows.Item(0).Item("Telefone").ToString & vbCrLf
                    End If

                End If

                strImpressao &= " " & vbCrLf

                strImpressao &= Cent("NÃO PERDER ESSE COMPROVANTE!", 60) & vbCrLf

                strImpressao &= Cent("É NECESSÁRIO A APRESENTAÇÃO DESTE NA TROCA.", 60) & vbCrLf

                strImpressao &= " " & vbCrLf

                strImpressao &= Cent("DOCUMENTO NÃO FISCAL", 60) & vbCrLf

                strImpressao &= " " & vbCrLf
                strImpressao &= " " & vbCrLf
                strImpressao &= " " & vbCrLf

                strImpressao &= "------------------------------------------------------------" & vbCrLf
                strImpressao &= Cent(NomeEmpresa.ToString.Trim, 60) & vbCrLf

                strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")
                iRetorno = clsBematech.FormataTX(strImpressao, 1, 0, 0, 0, 1)

                If TemGuilhotina = True Then
                    iRetorno = clsBematech.AcionaGuilhotina(0)
                End If

                iRetorno = clsBematech.FechaPorta()

            End If

            If Impressora = "EPSON" Then

                Dim strEstrela As String = clsImprimir.Comp("************************************************")
                Dim strTraço As String = clsImprimir.Comp("------------------------------------------------")


                strImpressao = "<ce>" & "VALE TROCA" & "</ce>" & vbCrLf

                strImpressao &= " " & vbCrLf


                strImpressao &= strEstrela & vbCrLf

                strImpressao &= "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf
                strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf
                strImpressao &= "<ce>" & TelefoneEmpresa.Trim & "</ce>" & vbCrLf

                strImpressao &= strEstrela & vbCrLf

                strImpressao &= Esq(Date.Today, 55) & vbCrLf

                strImpressao &= " ITEM VENDA Nº  DESCRIÇÃO                    " & vbCrLf
                strImpressao &= " TM.    QTD.    VL UNIT R$           VL Total R$" & vbCrLf
                strImpressao &= strTraço & vbCrLf

                Dim L As Integer
                Dim strCod, strProd, strUni, strQtd, strTot, strTM As String

                strCod = ""
                For L = 0 To Me.grd1.RowCount - 1

                    strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodOrdem)
                    strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
                    strUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUni)
                    strQtd = Me.grd1.GetRowCellDisplayText(L, Me.colQtde)
                    strTot = Me.grd1.GetRowCellDisplayText(L, Me.colValorTotal)
                    strTM = Me.grd1.GetRowCellDisplayText(L, Me.colTamanho)

                    strImpressao &= " " & L + 1 & "   " & strCod & "   " & strProd & vbCrLf
                    Dim str As String
                    str = Dir(" " & strTM & "    " & strQtd & "  X  " & strUni, 37) & Esq(strTot, 11)
                    strImpressao &= str & vbCrLf
                Next


                strImpressao &= strTraço & vbCrLf

                strImpressao &= Dir(" Crédito R$ ", 37) & Esq(Me.txtTotal.Text.Trim, 11) & vbCrLf

                strImpressao &= " " & vbCrLf


                strImpressao &= strTraço & vbCrLf


                Dim dt As DataTable


                dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & intCodCli)

                If dt.Rows.Count > 0 Then
                    If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                        strImpressao &= " " & dt.Rows.Item(0).Item("Nome").ToString & vbCrLf
                    End If

                    If dt.Rows.Item(0).Item("Endereco").ToString <> "" Then
                        strImpressao &= " " & dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & " " & dt.Rows.Item(0).Item("Complemento").ToString & vbCrLf
                    End If

                    If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                        strImpressao &= " " & dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & vbCrLf
                    End If

                    If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                        strImpressao &= " " & dt.Rows.Item(0).Item("Telefone").ToString & vbCrLf
                    End If

                End If

                strImpressao &= " " & vbCrLf

                strImpressao &= "<ce>" & "NÃO PERDER ESSE COMPROVANTE!" & "<ce>" & vbCrLf

                strImpressao &= "<ce>" & "É NECESSÁRIO A APRESENTAÇÃO DESTE NA TROCA." & "<ce>" & vbCrLf

                strImpressao &= " " & vbCrLf

                strImpressao &= "<ce>" & "DOCUMENTO NÃO FISCAL" & "<ce>" & vbCrLf

                strImpressao &= " " & vbCrLf
                strImpressao &= " " & vbCrLf
                strImpressao &= " " & vbCrLf

                strImpressao &= strTraço & vbCrLf
                strImpressao &= "<ce>" & NomeEmpresa.ToString.Trim & "<ce>" & vbCrLf

                strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")

                iRetorno = clsEpson.IniciaPorta(PortaImpressora)

                iRetorno = clsEpson.ImprimeTextoTag(strImpressao)

                If TemGuilhotina = True Then
                    iRetorno = clsEpson.AcionaGuilhotina(1)
                End If

                iRetorno = clsEpson.FechaPorta()

            End If

            If Impressora.Contains("ESC/POS") = True Then

                strImpressao = Cabecalho()


                strImpressao &= Centralizar(Exp("VALE TROCA")) & vbCrLf

                strImpressao &= strIgual & vbCrLf

                strImpressao &= Esq(Date.Today, 55) & vbCrLf
            
                strImpressao &= Dir("N: VENDA  DESCRIÇÃO", 55) & vbCrLf
                strImpressao &= Dir("TM.  QTD.  VL UNIT R$                       VL TOTAL R$", 55) & vbCrLf
                strImpressao &= strTraco & vbCrLf

                Dim L As Integer
                Dim strCod, strProd, strUni, strQtd, strTot, strTM As String

                strCod = ""
                For L = 0 To Me.grd1.RowCount - 1

                    strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodOrdem)
                    strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
                    strUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUni)
                    strQtd = Me.grd1.GetRowCellDisplayText(L, Me.colQtde)
                    strTot = Me.grd1.GetRowCellDisplayText(L, Me.colValorTotal)
                    strTM = Me.grd1.GetRowCellDisplayText(L, Me.colTamanho)

                    Dim strItem As String

                    strItem = strCod & "   " & strProd

                    If strItem.Length > 55 Then
                        strItem = Mid(strItem, 1, 55)
                    End If

                    strImpressao &= Dir(strItem, 55) & vbCrLf
                    Dim str As String
                    str = Dir(strTM & "   " & strQtd & "  X  " & strUni, 45) & Esq(strTot, 10)
                    strImpressao &= Dir(str, 55) & vbCrLf
                Next


                strImpressao &= strTraco & vbCrLf

                strImpressao &= DupLin("CREDITO R$ " & Me.txtTotal.Text.Trim) & vbCrLf

                strImpressao &= strTraco & vbCrLf


                Dim dt As DataTable

                dt = CarregarDataTable("Select Nome, CPF, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & intCodCli)

                If dt.Rows.Count > 0 Then
                    If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                        strImpressao &= Dir(dt.Rows.Item(0).Item("Nome").ToString, 55) & vbCrLf
                    End If

                    If dt.Rows.Item(0).Item("CPF").ToString <> "" Then
                        strImpressao &= Dir(dt.Rows.Item(0).Item("CPF").ToString, 55) & vbCrLf
                    End If

                    'If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                    '    strImpressao &= "<c>" & dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & "</c>" & vbCrLf
                    'End If

                    'If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                    '    strImpressao &= "<c>" & dt.Rows.Item(0).Item("Telefone").ToString & "</c>" & vbCrLf
                    'End If

                End If

                strImpressao &= vbCrLf

                strImpressao &= Centralizar("NÃO PERDER ESSE COMPROVANTE!") & vbCrLf
                strImpressao &= Centralizar("É NECESSÁRIO A APRESENTAÇÃO DESTE NA TROCA.") & vbCrLf

                strImpressao &= vbCrLf

                Rodape(True, strImpressao)
            End If
        Else
            If TipoImpressoraFiscal = "DARUMA" Then
                DarumaFiscal.iRetorno = DarumaFiscal.iRGAbrirIndice_ECF_Daruma(1)
                DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                If DarumaFiscal.iRetorno <> 1 Then Exit Sub
            Else
                Retorno = Bematech_FI_AbreRelatorioGerencialMFD("01")
            End If

            Dim strTraco As String = "------------------------------------------------"
            strImpressao = " " & vbCrLf
            strImpressao &= Cent("VALE TROCA", 48) & vbCrLf
            strImpressao &= strTraco & vbCrLf
            strImpressao &= Esq(Date.Today, 55) & vbCrLf
            strImpressao &= " ITEM VENDA Nº  DESCRIÇÃO                    " & vbCrLf
            strImpressao &= " TM.    QTD.    VL UNIT R$           VL Total R$" & vbCrLf
            strImpressao &= strTraco & vbCrLf

            Dim L As Integer
            Dim strCod, strProd, strUni, strQtd, strTot, strTM As String

            strCod = ""
            For L = 0 To Me.grd1.RowCount - 1

                strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodOrdem)
                strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
                strUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUni)
                strQtd = Me.grd1.GetRowCellDisplayText(L, Me.colQtde)
                strTot = Me.grd1.GetRowCellDisplayText(L, Me.colValorTotal)
                strTM = Me.grd1.GetRowCellDisplayText(L, Me.colTamanho)
                Dim strProduto As String = " " & L + 1 & "   " & strCod & "   " & strProd & vbCrLf
                If strProduto.Length > 48 Then
                    strImpressao &= strProduto.Substring(0, 48) & vbCrLf
                Else
                    strImpressao &= strProduto & vbCrLf
                End If

                Dim str As String
                str = " " & strTM & "    " & Dir(strQtd & "  X  " & strUni, 21) & Esq(strTot, 20)
                strImpressao &= str & vbCrLf

                If strImpressao.Length > 400 Then
                    If TipoImpressoraFiscal = "DARUMA" Then
                        DarumaFiscal.iRetorno = DarumaFiscal.iRGImprimirTexto_ECF_Daruma(strImpressao)
                        DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                    Else
                        Retorno = Bematech_FI_UsaRelatorioGerencialMFD(strImpressao)
                    End If

                    strImpressao = ""
                End If
            Next


            strImpressao &= strTraco & vbCrLf

            strImpressao &= " Crédito R$ " & Esq(Me.txtTotal.Text.Trim, 9) & vbCrLf

            strImpressao &= " " & vbCrLf

            If strImpressao.Length > 400 Then
                If TipoImpressoraFiscal = "DARUMA" Then
                    DarumaFiscal.iRetorno = DarumaFiscal.iRGImprimirTexto_ECF_Daruma(strImpressao)
                    DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                Else
                    Retorno = Bematech_FI_UsaRelatorioGerencialMFD(strImpressao)
                End If

                strImpressao = ""
            End If
            strImpressao &= strTraco & vbCrLf


            Dim dt As DataTable


            dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & intCodCli)

            If dt.Rows.Count > 0 Then
                If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                    strImpressao &= " " & dt.Rows.Item(0).Item("Nome").ToString & vbCrLf
                End If

                If dt.Rows.Item(0).Item("Endereco").ToString <> "" Then
                    strImpressao &= " " & dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & " " & dt.Rows.Item(0).Item("Complemento").ToString & vbCrLf
                End If

                If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                    strImpressao &= " " & dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & vbCrLf
                End If

                If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                    strImpressao &= " " & dt.Rows.Item(0).Item("Telefone").ToString & vbCrLf
                End If
                If strImpressao.Length > 400 Then
                    If TipoImpressoraFiscal = "DARUMA" Then
                        DarumaFiscal.iRetorno = DarumaFiscal.iRGImprimirTexto_ECF_Daruma(strImpressao)
                        DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                    Else
                        Retorno = Bematech_FI_UsaRelatorioGerencialMFD(strImpressao)
                    End If

                    strImpressao = ""
                End If
            End If

            strImpressao &= " " & vbCrLf

            strImpressao &= Cent("NÃO PERDER ESSE COMPROVANTE!", 48) & vbCrLf

            strImpressao &= Cent("É NECESSÁRIO A APRESENTAÇÃO DESTE NA TROCA.", 48) & vbCrLf

            If NomeEmpresa.Contains("LUCIA FREITAS") = True Then
                strImpressao &= Cent("VÁLIDO POR 30 DIAS", 48) & vbCrLf
            End If
            If strImpressao.Length > 400 Then
                If TipoImpressoraFiscal = "DARUMA" Then
                    DarumaFiscal.iRetorno = DarumaFiscal.iRGImprimirTexto_ECF_Daruma(strImpressao)
                    DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                Else
                    Retorno = Bematech_FI_UsaRelatorioGerencialMFD(strImpressao)
                End If

                strImpressao = ""
            End If
          
            strImpressao &= " " & vbCrLf
            strImpressao &= " " & vbCrLf
            strImpressao &= " " & vbCrLf

            strImpressao &= "------------------------------------------------" & vbCrLf
            strImpressao &= Cent(NomeEmpresa.ToString.Trim, 48) & vbCrLf

            strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")
            If strImpressao.Length > 400 Then
                If TipoImpressoraFiscal = "DARUMA" Then
                    DarumaFiscal.iRetorno = DarumaFiscal.iRGImprimirTexto_ECF_Daruma(strImpressao)
                    DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                Else
                    Retorno = Bematech_FI_UsaRelatorioGerencialMFD(strImpressao)
                End If

                strImpressao = ""
            End If
            If TipoImpressoraFiscal = "DARUMA" Then
                DarumaFiscal.iRetorno = DarumaFiscal.iRGImprimirTexto_ECF_Daruma(strImpressao)
                DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                DarumaFiscal.iRetorno = DarumaFiscal.iRGFechar_ECF_Daruma()
                DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Else
                Retorno = Bematech_FI_UsaRelatorioGerencialMFD(strImpressao)
                Retorno = Bematech_FI_FechaRelatorioGerencial()
            End If

            clsFuncoesBematech.SalvarDocumento("RG")
        End If


    End Sub
  
    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If MsgBox("Tem certeza que deseja limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Limpar()
        End If
    End Sub

    Private Sub txtQtde_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtde.Enter
        Select Case strUM
            Case "UN", "JG", "KIT"
                Me.txtQtde.CasasDecimais = 0
            Case "KG", "LT"
                Me.txtQtde.CasasDecimais = 3
            Case "MT"
                Me.txtQtde.CasasDecimais = 2
        End Select
    End Sub


    Private Sub txtCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Keys.F10 Then
            BuscaCliente()
        End If
    End Sub

    Private Sub txtCodProd_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodProd.KeyDown
        If e.KeyCode = Keys.F10 Then
            BuscaProduto()
        End If
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        Select Case bolAlterado
            Case True
                MsgBox("Existe um item sendo alterado, conclua a alteração antes de excluir algum item!", MsgBoxStyle.Information)
                Exit Sub
            Case False
                If MsgBox("Deseja realmente excluir este produto?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    Me.grd1.DeleteRow(Me.grd1.FocusedRowHandle)
                    Calcular()
                End If
        End Select

    End Sub

    Private Sub chkTamanho_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTamanho.CheckedChanged
        Select Case Me.chkTamanho.Checked
            Case True
                Tamanho(True)
            Case False
                Tamanho(False)
        End Select
    End Sub
    Private Sub Tamanho(ByVal chk As Boolean)
        Me.chkTamanho.Checked = chk
        Select Case Me.chkTamanho.Checked
            Case True
                Me.txtTamanho.Enabled = False
                Me.txtTamanho.Text = "U"
                Me.txtQtde.Focus()
            Case False
                Me.txtTamanho.Enabled = True
                Me.txtTamanho.Text = ""
                Me.txtTamanho.Focus()
        End Select
    End Sub

 
End Class