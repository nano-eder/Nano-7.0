Imports Nano.clsFuncoes
Imports Nano.clsImprimir

Public Class frmPagar
    Dim bolAlterado As Boolean = False
    Dim I As Integer
    Dim Index, intCodConta As Integer
    Public intCodFornecedor As Integer
    Dim strVencimento As String
    Dim strCPFFornecedor As String
    Public strNumDocumento As String

    Private Sub frmPagar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    If Me.Tag = "PAGAS" Then
                        Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "42")
                    Else
                        Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "20")
                    End If
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmPagar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub

        CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja)
        PreencherGrupoSetorCusto("C", Me.cboCenCus)

        If Me.Tag <> "PAGAS" Then
            Me.colDataPagamento.Visible = False
            Me.colValorPago.Visible = False
        End If
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)
        Me.PagamentoTableAdapter.Fill(Me.DsNanoCommerce.Pagamento)

        Me.colCodConfig.Visible = Master

        Me.grd1.OptionsView.ShowFooter = Master

        If Me.Tag = "PAGAS" Then
            Me.colVencido.Visible = False
            Me.LabelControl3.Visible = False
            Me.cboVencimentos.Visible = False
          


            AtualizarGrid("PagoOK = 'True'")

            grpPag.ShowCaption = False
            grpPag.Dock = DockStyle.Fill

            Me.btnAlterar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnLimpar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.bsiVisu.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.Text = "Consulta de Contas Pagas"
            Me.btnRelConta.Caption = "&Relatório de Contas Pagas"
            Me.lblTot.Text = "Total Pago  R$"
            Me.colDataPagamento.Visible = True
            Me.colValorPago.Visible = True
            If Nivel = "ADMINISTRADOR" Or Nivel = "MASTER" Then
                Me.btnEstornar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

            End If

            Me.colEstornar.Visible = True
            Me.colEstornar.VisibleIndex = 12
        Else

            Me.colDataPagamento.Visible = False
            Me.colValorPago.Visible = False

            AtualizarGrid("PagoOK = 'False'")

            PreencherOrdenado("Banco", Me.cboBanco, 1, "Nome")
            Me.cboBanco.Properties.Items.Add("")
            grd1.FormatConditions.Item(0).Value1 = Date.Today
            grd1.FormatConditions.Item(1).Value1 = Date.Today


        End If

        If Nivel = "ADMINISTRADOR" Or Nivel = "MASTER" Then
            Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If

        'intCodFornecedor = CodigoDoFornecedor

        Me.dtConta.Text = Date.Today.ToString("dd/MM/yyyy")
    End Sub
    Private Sub AtualizarGrid(ByVal strFiltro As String)

        Dim strFilt As String = ""

        If Master = False Then
            strFilt = " and ContaPagar.CodConfig =" & CodConfig

        End If

        CarregarDados("Select ContaPagar.Codigo, CodFor, Fornecedor.Nome as Fornecedor, TipoConta, " & _
        "Convert(Numeric(15,2), Valor) as Valor, FormaPagamento, Parcelas, " & _
        "Convert(Numeric(15,2), ValorParcela) as ValorParcela, Vencimento, DataPagamento, " & _
        "Convert(Numeric(15,2), ValorPago) as ValorPago, Descricao, PagoOK, Pagamento, NumeroDocumento, " & _
        "TipoCusto, Banco, CentroCusto, ContaPagar.CodConfig, Fornecedor.Fantasia, case when datediff (month,vencimento,getdate()) >= 60 then 'CADUCADOS' else case when DATEDIFF (day,vencimento,getdate())>0 then 'ATRASADOS' " & _
        "when DATEDIFF (day,vencimento,getdate())=0 then 'HOJE' else 'EM DIA' end end as Vencido, ContaPagar.Data, Convert(bit, 'False') as Estornar from ContaPagar Inner Join Fornecedor on ContaPagar.CodFor = Fornecedor.Codigo where " & strFiltro & strFilt, Me.Grid1)

        Dim dt As DataTable = CarregarDataTable("Select TipoConta from ContaPagar group by TipoConta order by TipoConta")

        Dim I As Integer

        Me.cboTipConta.Properties.Items.Clear()

        For I = 0 To dt.Rows.Count - 1
            Me.cboTipConta.Properties.Items.Add(dt.Rows.Item(I).Item("TipoConta").ToString)
        Next

        AdicionarTipo()

    End Sub

    Private Sub AdicionarTipo()
        'ADICIONA OS TIPOS "INVESTIMENTO" E "RETIRADA DE LUCROS" PARA O USO DO RELATORIO DRE.
        Dim bolOk1 As Boolean = False
        Dim bolOk2 As Boolean = False
        For J As Integer = 0 To Me.cboTipConta.Properties.Items.Count - 1
            Dim Tipo As String = Me.cboTipConta.Properties.Items(J).ToString()

            If Tipo = "INVESTIMENTO" Then
                bolOk1 = True
            End If
            If Tipo = "RETIRADA DE LUCROS" Then
                bolOk2 = True
            End If

            If bolOk1 = True And bolOk2 = True Then
                Exit For
            End If
        Next

        If bolOk1 = False Then
            Me.cboTipConta.Properties.Items.Add("INVESTIMENTO")
        End If
        If bolOk2 = False Then
            Me.cboTipConta.Properties.Items.Add("RETIRADA DE LUCROS")
        End If
    End Sub

    Private Sub Limpar()
        Me.LabelControl8.Visible = True
        Me.txtDias.Visible = True
        Me.lblDtPag.Visible = False
        Me.lblValPag.Visible = False

        Me.cboVencimentos.SelectedIndex = 0
        Me.tdCred.Rows.Clear()

        Me.txtDesc.ResetText()
        Me.txtFornecedor.ResetText()
        Me.cboTipCus.SelectedIndex = -1
        Me.txtValTotPag.ResetText()
        Me.dtPag.ResetText()
        Me.luePag.EditValue = DBNull.Value
        strNumDocumento = ""
        Me.seParcela.ResetText()
        Me.txtValConta.ResetText()
        Me.dtVenc.ResetText()

        Me.rdgFim.SelectedIndex = -1
        Me.rdgFim.Enabled = True
        Me.txtTotal.ResetText()
        Me.cboTipConta.SelectedIndex = -1
        bolAlterado = False
        Me.seParcela.Enabled = True
        Me.txtFornecedor.Focus()


        Me.lblFimCont.Visible = False
        Me.rdgFim.Visible = False
        Me.txtValTotPag.Visible = False
        Me.dtPag.Visible = False

        Me.dtVenc.Visible = True
        Me.lblVenc.Visible = True

        Me.lblNumPar.Visible = True
        Me.seParcela.Visible = True

        Me.cboBanco.SelectedIndex = -1
        Me.cboCenCus.SelectedIndex = -1
        Me.btnCTPagarNF.Enabled = True
        NomeFornecedor = ""
        strCPFFornecedor = ""

        Me.dtConta.Text = Date.Today.ToString("dd/MM/yyyy")
    End Sub

    Private Sub Alterar(Optional ByVal parIndex As String = "")

        If grd1.RowCount = 0 Then Exit Sub
        Me.btnCTPagarNF.Enabled = False
        If parIndex = "" Then
            If grd1.FocusedRowHandle < 0 Then Exit Sub
        End If

        If parIndex = "" Then
            Index = grd1.FocusedRowHandle
        Else
            Index = parIndex
        End If

        Dim I As Integer
        For I = 0 To Me.grd2.RowCount - 1

            If Me.grd2.GetRowCellDisplayText(I, Me.colCodigoParcela) = Me.grd1.GetRowCellDisplayText(Index, Me.colCodigo) Then
                MsgBox("Não pode adicionar a mesma parcela duas vezes!", MsgBoxStyle.Information)
                Exit Sub
            End If
        Next

        bolAlterado = True

        'With grd1
        '    intCodConta = .GetRowCellDisplayText(Index, Me.colCodigo)
        '    intCodFornecedor = .GetRowCellDisplayText(Index, Me.colCodFor)
        '    Me.txtFornecedor.Text = .GetRowCellDisplayText(Index, Me.colFornecedor)
        '    Me.cboTipCus.Text = .GetRowCellDisplayText(Index, Me.colTipoCusto)
        '    Me.txtValConta.Text = .GetRowCellDisplayText(Index, Me.colValor).Replace("R$ ", "").Replace(".", "")
        '    Me.cboTipConta.Text = .GetRowCellDisplayText(Index, Me.colTipoConta)
        '    Me.seParcela.Value = .GetRowCellDisplayText(Index, Me.colParcelas)

        '    Me.tdCred.Rows.Clear()
        '    Me.tdCred.Rows.Add()
        '    Me.tdCred.Rows.Item(0).Item("Parcela") = .GetRowCellDisplayText(Index, Me.colParcelas)
        '    Me.tdCred.Rows.Item(0).Item("Valor") = .GetRowCellDisplayText(Index, Me.colValorParcela).Replace("R$ ", "").Replace(".", "")
        '    Me.tdCred.Rows.Item(0).Item("Vencimento") = .GetRowCellDisplayText(Index, Me.colVencimento)
        '    Me.tdCred.Rows.Item(0).Item("Documento") = .GetRowCellDisplayText(Index, Me.colNumeroDocumento)

        '    Me.dtVenc.Text = .GetRowCellDisplayText(Index, Me.colVencimento)
        '    Me.txtValTotPag.Text = .GetRowCellDisplayText(Index, Me.colValorPago)
        '    Me.txtValTotPag.Tag = .GetRowCellDisplayText(Index, Me.colValorPago)
        '    Me.dtPag.EditValue = Date.Today
        '    Me.luePag.Text = .GetRowCellDisplayText(Index, Me.colFormaPagamento)
        '    Me.luePag.ClosePopup()
        '    Me.txtDesc.Text = .GetRowCellDisplayText(Index, Me.colDescricao)

        '    Me.seParcela.Enabled = False
        '    Me.cboBanco.Text = .GetRowCellDisplayText(Index, Me.colBanco)
        '    Me.cboCenCus.Text = .GetRowCellDisplayText(Index, Me.colCentroCusto)
        'End With

        'Me.lblFimCont.Visible = True
        'Me.rdgFim.Visible = True

        'Me.dtVenc.Visible = False
        'Me.lblVenc.Visible = False

        'Me.lblNumPar.Visible = False
        'Me.seParcela.Visible = False

        With grd1
            intCodFornecedor = .GetRowCellDisplayText(Index, Me.colCodFor)
            strVencimento = .GetRowCellDisplayText(Index, Me.colVencimento)
            intCodConta = .GetRowCellDisplayText(Index, Me.colCodigo)
            Dim intCodFor As Integer = 0
            If .GetRowCellDisplayText(Index, Me.colCodFor) <> "" Then
                intCodFor = .GetRowCellValue(Index, Me.colCodFor)
            End If

            Dim dtCPF As DataTable = CarregarDataTable("Select CPF from Fornecedor Where Codigo=" & intCodFor)
            If dtCPF.Rows.Count > 0 Then
                strCPFFornecedor = dtCPF.Rows.Item(0).Item("CPF").ToString
            End If

            Me.txtFornecedor.Text = .GetRowCellDisplayText(Index, Me.colFornecedor)
            Me.cboTipCus.Text = .GetRowCellDisplayText(Index, Me.colTipoCusto)
            Me.txtValConta.Text = .GetRowCellDisplayText(Index, Me.colValor)
            Me.cboTipConta.Text = .GetRowCellDisplayText(Index, Me.colTipoConta)
            Me.seParcela.Value = .GetRowCellDisplayText(Index, Me.colParcelas)

            Me.dtConta.Text = .GetRowCellDisplayText(Index, Me.colConta)

            If Me.grd2.RowCount > 0 Then
                If intCodFor > 0 Then
                    Dim intFor As Integer
                    If Me.grd2.GetRowCellValue(0, Me.colCodFornecedor).ToString <> "" Then
                        intFor = Me.grd2.GetRowCellValue(0, Me.colCodFornecedor)
                    End If
                    If intFor <> intCodFor Then
                        Me.tdCred.Rows.Clear()
                    End If
                Else
                    Me.tdCred.Rows.Clear()
                End If
            End If

            Me.tdCred.Rows.Add()
            Dim IndexCred As Integer = Me.tdCred.Rows.Count - 1
            Me.tdCred.Rows.Item(IndexCred).Item("Parcela") = .GetRowCellDisplayText(Index, Me.colParcelas)
            Me.tdCred.Rows.Item(IndexCred).Item("Valor") = .GetRowCellDisplayText(Index, Me.colValorParcela)
            Me.tdCred.Rows.Item(IndexCred).Item("Vencimento") = .GetRowCellDisplayText(Index, Me.colVencimento)
            Me.tdCred.Rows.Item(IndexCred).Item("Documento") = .GetRowCellDisplayText(Index, Me.colNumeroDocumento)
            Me.tdCred.Rows.Item(IndexCred).Item("CodigoParcela") = .GetRowCellDisplayText(Index, Me.colCodigo)
            Me.tdCred.Rows.Item(IndexCred).Item("CodigoFornecedor") = .GetRowCellDisplayText(Index, Me.colCodFor)
            Calcular()
            Me.dtVenc.Text = .GetRowCellDisplayText(Index, Me.colVencimento)

            If .GetRowCellDisplayText(Index, Me.colValorPago) = "" Or .GetRowCellDisplayText(Index, Me.colValorPago) = "0,00" Then
                Me.txtValTotPag.Text = Me.txtTotal.Text
                Me.txtValTotPag.Tag = Me.txtTotal.Text
            Else
                Me.txtValTotPag.Text = .GetRowCellDisplayText(Index, Me.colValorPago)
                Me.txtValTotPag.Tag = .GetRowCellDisplayText(Index, Me.colValorPago)
            End If

            Me.dtPag.EditValue = Date.Today
            Me.luePag.Text = .GetRowCellDisplayText(Index, Me.colFormaPagamento)
            Me.luePag.ClosePopup()
            Me.txtDesc.Text = .GetRowCellDisplayText(Index, Me.colDescricao)

            Me.seParcela.Enabled = False
            Me.cboBanco.Text = .GetRowCellDisplayText(Index, Me.colBanco)
            Me.cboCenCus.Text = .GetRowCellDisplayText(Index, Me.colCentroCusto)
        End With

        Me.lblFimCont.Visible = True
        Me.rdgFim.Visible = True

        Me.lblDtPag.Visible = True
        Me.dtPag.Visible = True


        Me.lblValPag.Visible = True
        Me.txtValTotPag.Visible = True

        Me.dtVenc.Visible = False
        Me.lblVenc.Visible = False

        Me.lblNumPar.Visible = False
        Me.seParcela.Visible = False

        Me.LabelControl8.Visible = False
        Me.txtDias.Visible = False

    End Sub

    Private Sub Calcular()
        Dim I As Integer
        Dim dblResulTotal As Double
        Dim dblTotal As Double
        For I = 0 To Me.grd2.RowCount - 1
            If Me.grd2.GetRowCellDisplayText(I, Me.colValParcela) <> "" Then
                dblTotal += Me.grd2.GetRowCellDisplayText(I, Me.colValParcela)
            End If

        Next
        dblResulTotal = dblTotal

        Me.txtTotal.Text = dblResulTotal.ToString("0.00")
    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick

        If TesteConexao() = False Then Exit Sub

        Me.txtFornecedor.Focus()
        If Validar(Me.txtFornecedor) = False Then Exit Sub
        If Validar(Me.cboTipConta) = False Then Exit Sub
        If Validar(Me.txtValConta) = False Then Exit Sub
        If Validar(Me.luePag) = False Then Exit Sub
        If Validar(Me.dtVenc) = False Then Exit Sub : Exit Sub
        Dim strCodPed As String = ""
        Dim strParcela As String = ""
        If Me.seParcela.Value = 0 Then MsgBox("Número de Nº Parcelas é obrigatório!", MsgBoxStyle.Information) : Exit Sub
        If bolAlterado = False Then

            Dim strData, strValPar, strDoc As String

            For I = 0 To Me.grd2.RowCount - 1

                strData = grd2.GetRowCellDisplayText(I, Me.colVenc)
                strValPar = grd2.GetRowCellDisplayText(I, Me.colValParcela)
                strDoc = grd2.GetRowCellDisplayText(I, Me.colDocumento)

                Inserir("INSERT INTO ContaPagar (CodFor, TipoConta, Valor, FormaPagamento, Parcelas, ValorParcela, Vencimento, Pagamento, ValorPago, Descricao, PagoOK, NumeroDocumento, TipoCusto, Banco, CentroCusto, CodConfig, Data) VALUES (" & intCodFornecedor & ",'" & Me.cboTipConta.Text.Trim & "'," & Num(Me.txtValConta.Text.Trim) & ",'" & Me.luePag.Text & "','" & I + 1 & "'," & Num(strValPar) & ",'" & strData & "','" & Me.luePag.GetColumnValue("FormaPagamento").ToString & "'," & Num(Me.txtValTotPag.Text.Trim) & ",'" & Me.txtDesc.Text.Trim & "','" & False & "','" & strDoc & "','" & Me.cboTipCus.Text.Trim & "','" & Me.cboBanco.Text.Trim & "','" & Me.cboCenCus.Text.Trim & "'," & CodConfig & ",'" & Me.dtConta.EditValue & "')")
            Next

            If ValorTotalCT > 0 Then
                With frmConCTPagarNF.grd1
                    For I = 0 To .RowCount - 1
                        If .GetRowCellValue(I, frmConCTPagarNF.colOk) = True Then
                            Dim strNumeroNF As String = .GetRowCellDisplayText(I, frmConCTPagarNF.colNF)

                            Atualizar("UPDATE TotalEntradaNF set CTPagarOk = 'True' where NumeroNF = '" & strNumeroNF & "' and CodConfig = " & CodConfig)
                        End If
                    Next
                End With
            End If

            MsgBox("Conta cadastrada com sucesso!", MsgBoxStyle.Information)
            If Me.Tag = "ENTRADANF" Then
                Me.Close()
            End If

        Else
            'If Me.rdgFim.SelectedIndex = -1 Then MsgBox("Selecione se você deseja Finalizar a Conta!", MsgBoxStyle.Information) : Me.rdgFim.Focus() : Exit Sub
            'If Me.rdgFim.SelectedIndex = 1 And Me.dtPag.Text.Trim = "" Then MsgBox("Informe a data do pagamento!", MsgBoxStyle.Information) : Me.dtPag.Focus() : Exit Sub
            'If Me.rdgFim.SelectedIndex = 1 And Me.txtValTotPag.Text.Trim = "" Then MsgBox("Informe o valor pago!", MsgBoxStyle.Information) : Me.txtValTotPag.Focus() : Exit Sub
            If Me.rdgFim.SelectedIndex <> -1 And Me.txtValTotPag.Text.Trim = "" Then MsgBox("Informe o valor pago!", MsgBoxStyle.Information) : Me.txtValTotPag.Focus() : Exit Sub
            If Me.rdgFim.SelectedIndex <> -1 And Me.dtPag.Text.Trim = "" Then MsgBox("Informe a data do pagamento!", MsgBoxStyle.Information) : Me.dtPag.Focus() : Exit Sub
            If Me.rdgFim.SelectedIndex = -1 And Me.grd2.RowCount > 1 Then MsgBox("Não é possível alterar mais de uma parcela por vez!" & vbCrLf & "Se o que deseja é dar baixa nas parcelas, selecione uma das opções: 'Total' ou 'Parcial'.", MsgBoxStyle.Information) : Exit Sub

            Dim bolPago As Boolean
            If rdgFim.SelectedIndex = 0 Then
                bolPago = False
            ElseIf rdgFim.SelectedIndex = -1 Then
                bolPago = False
            Else
                bolPago = True
            End If

            ' Atualizar("UPDATE ContaPagar SET CodFor = " & intCodFornecedor & ", TipoConta =  '" & Me.cboTipConta.Text.Trim & "', Valor = " & Num(Me.txtValConta.Text.Trim) & ", FormaPagamento = '" & Me.luePag.Text.Trim & "', Parcelas = '" & Me.seParcela.Text & "', ValorParcela = " & Num(Me.grd2.GetRowCellDisplayText(0, Me.colValor)) & ", Vencimento = '" & Me.grd2.GetRowCellDisplayText(0, Me.colVenc) & "', DataPagamento = '" & Me.dtPag.Text.Trim & "', Pagamento = '" & Me.luePag.GetColumnValue("FormaPagamento").ToString & "', ValorPago = " & Num(Me.txtValTotPag.Text.Trim) & ", Descricao = '" & Me.txtDesc.Text.Trim & "', PagoOK = '" & bolPago & "', NumeroDocumento = '" & Me.grd2.GetRowCellDisplayText(0, Me.colDocumento) & "', TipoCusto = '" & Me.cboTipCus.Text.Trim & "', Banco = '" & Me.cboBanco.Text.Trim & "', CentroCusto ='" & Me.cboCenCus.Text.Trim & "' where Codigo = " & intCodConta)
            If Me.rdgFim.SelectedIndex = 0 Then
                If AbrirFecharCaixa = True Then
                    If VerificarCaixa("") = False Then Exit Sub
                End If
                If CDbl(Me.txtValTotPag.Text) >= CDbl(Me.txtTotal.Text) Then
                    MsgBox("Não é possível fazer o pagamento parcial já que o valor pago é igual ao valor total a pagar!", MsgBoxStyle.Information)
                    Exit Sub
                End If

                If Me.grd2.RowCount = 1 Then
                    Dim strData As String = grd2.GetRowCellDisplayText(0, Me.colVenc)
                    Dim strValPar As String = grd2.GetRowCellDisplayText(0, Me.colValParcela)
                    Dim strDoc As String = grd2.GetRowCellDisplayText(0, Me.colDocumento)
                    Dim strCod As String = GerarCodigo("ContaPagar", "Codigo", CodConfig).Trim
                    Dim dblValConta As String = txtValConta.Text.Replace("R$", "").Replace(".", "")
                    Dim dblValPar As String = strValPar.Replace("R$", "").Replace(".", "")
                    Dim dblValTotPag As String = Me.txtValTotPag.Text.Replace("R$", "").Replace(".", "")


                    Inserir("INSERT INTO ContaPagar (CodFor, TipoConta, Valor, FormaPagamento, Parcelas, " & _
                    "ValorParcela, Vencimento, ValorPago, Descricao, PagoOK, Pagamento, NumeroDocumento, TipoCusto, " & _
                    "Banco, CodConfig, CentroCusto, DataPagamento, Data) VALUES (" & intCodFornecedor & ", " & _
                    "'" & Me.cboTipConta.Text.Trim & "'," & Num(dblValConta) & "," & _
                    "'" & Me.luePag.Text.Trim & "','" & Me.seParcela.Text.Trim & "', " & _
                    "" & Num(dblValPar) & ",'" & strData & "'," & _
                    "" & Num(dblValTotPag) & ",'" & Me.txtDesc.Text.Trim & "','True'," & _
                    "'" & Me.luePag.GetColumnValue("FormaPagamento").ToString & "','" & strDoc & "'," & _
                    "'" & Me.cboTipCus.Text.Trim & "','" & Me.cboBanco.Text.Trim & "'," & CodConfig & ", " & _
                    "'" & Me.cboCenCus.Text & "','" & Me.dtPag.EditValue & "','" & Me.dtConta.EditValue & "')")



                    Dim dblDif As Double

                    dblDif = CDbl(Me.txtTotal.Text.Trim) - CDbl(Me.txtValTotPag.Text.Trim)

                    dblDif = dblDif / Me.grd2.RowCount

                    For I = 0 To Me.grd2.RowCount - 1
                        Atualizar("Update ContaPagar set ValorParcela =" & Num(dblDif.ToString("0.00")) & ", " & _
                        "NumeroDocumento ='" & Me.grd2.GetRowCellDisplayText(I, Me.colDocumento) & "' " & _
                        "where Codigo =" & Me.grd2.GetRowCellValue(I, Me.colCodigoParcela))
                    Next

                    IrCaixa(strCodPed, "P/" & Me.seParcela.Text.Trim, Me.txtValTotPag.Text.Trim)

                    If ImprimeContaPagar = True Then
                        If TemImpressora = True Then
                            Recibo("P/" & Me.seParcela.Text.Trim)
                            If SegViaRecibo = True Then
                                If MsgBox("Deseja imprimir a 2ª via do recibo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                    Recibo("P/" & Me.seParcela.Text.Trim)
                                End If
                            End If
                        End If
                    End If

                    'Dim strMot As String = "PARCELA " & "P/" & Me.seParcela.Text.Trim & " , " & Me.txtFornecedor.Text.Trim & " COD " & Me.grd2.GetRowCellValue(0, Me.grd1.GetRowCellValue(Index, Me.colCodigo))
                    Dim strMot As String = "PARCELA " & "P/" & Me.seParcela.Text.Trim & " , " & Me.txtFornecedor.Text.Trim & " COD " & Me.grd2.GetRowCellValue(0, Me.colCodigoParcela)
                    Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strMot & " A PAGAR','PAGO','CONTA A PAGAR','CONTA A PAGAR','PAGAMENTO'," & CodConfig & ")")
                Else

                    For I = 0 To Me.grd2.RowCount - 1
                        Dim dblDif As Double

                        dblDif = CDbl(Me.txtTotal.Text.Trim) - CDbl(Me.txtValTotPag.Text.Trim)

                        dblDif = dblDif / Me.grd2.RowCount

                        Dim strCod As String = GerarCodigo("ContaPagar", "Codigo", CodConfig).Trim
                        Dim dblValDif As Double = CDbl(Me.grd2.GetRowCellValue(I, Me.colValParcela)) - dblDif.ToString("0.00")
                        Dim strDVenc As String = Me.grd2.GetRowCellValue(I, Me.colVenc)

                        Inserir("INSERT INTO ContaPagar (CodFor, TipoConta, Valor, FormaPagamento, Parcelas, " & _
                        "ValorParcela, Vencimento, ValorPago, Descricao, PagoOK, Pagamento, NumeroDocumento, TipoCusto, " & _
                        "Banco, CodConfig, CentroCusto, DataPagamento, Data) VALUES (" & intCodFornecedor & ", " & _
                        "'" & Me.cboTipConta.Text.Trim & "'," & Num(dblValDif.ToString.Replace("R$", "").Replace(".", "")) & "," & _
                        "'" & Me.luePag.Text.Trim & "','" & Me.grd2.GetRowCellValue(I, Me.colParcela) & "', " & _
                        "" & Num(dblValDif.ToString.Replace("R$", "").Replace(".", "")) & ",'" & strDVenc & "'," & _
                        "" & Num(dblValDif.ToString.Replace("R$", "").Replace(".", "")) & ",'" & Me.txtDesc.Text.Trim & "','True'," & _
                        "'" & Me.luePag.GetColumnValue("FormaPagamento").ToString & "','" & grd2.GetRowCellDisplayText(I, Me.colDocumento) & "'," & _
                        "'" & Me.cboTipCus.Text.Trim & "','" & Me.cboBanco.Text.Trim & "'," & CodConfig & ", " & _
                        "'" & Me.cboCenCus.Text & "','" & Me.dtPag.EditValue & "','" & Me.dtConta.EditValue & "')")

                        Atualizar("Update ContaPagar set Vencimento ='" & Date.Today.AddMonths(1) & "', " & _
                        "ValorParcela ='" & Num(dblDif.ToString("0.00")) & "', " & _
                        "NumeroDocumento ='" & Me.grd2.GetRowCellDisplayText(I, Me.colDocumento) & "' " & _
                        "where Codigo =" & Me.grd2.GetRowCellValue(I, Me.colCodigoParcela))

                        Me.cboBanco.Text = "CAIXA"

                        If I = 0 Then
                            strCodPed = " CÓD " & strCod
                            strParcela = Me.grd2.GetRowCellDisplayText(I, Me.colParcela)
                        Else
                            strCodPed &= "/" & strCod
                            strParcela &= "/" & Me.grd2.GetRowCellDisplayText(I, Me.colParcela)
                        End If


                        Dim strMot As String = "PARCELA " & "P/" & Me.grd2.GetRowCellValue(I, Me.colParcela) & " , " & Me.txtFornecedor.Text.Trim & " COD " & Me.grd2.GetRowCellValue(I, Me.colCodigoParcela)
                        Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strMot & " A PAGAR','PAGO','CONTA A PAGAR','CONTA A PAGAR','PAGAMENTO'," & CodConfig & ")")

                    Next

                    IrCaixa(strCodPed, "P/" & strParcela, Me.txtValTotPag.Text.Trim)

                    If ImprimeContaPagar = True Then
                        If TemImpressora = True Then
                            Recibo("P/" & strParcela)
                            If SegViaRecibo = True Then
                                If MsgBox("Deseja imprimir a 2ª via do recibo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                    Recibo("P/" & strParcela)
                                End If
                            End If
                        End If
                    End If
                End If
                MsgBox("Pagamento parcial realizado com sucesso!", MsgBoxStyle.Information)

            ElseIf Me.rdgFim.SelectedIndex = -1 Then
                Atualizar("UPDATE ContaPagar SET CodFor = " & intCodFornecedor & ", TipoConta =  '" & Me.cboTipConta.Text.Trim & "', Valor = " & Num(Me.txtValConta.Text.Replace("R$", "").Replace(".", "")) & ", FormaPagamento = '" & Me.luePag.Text.Trim & "', Parcelas = '" & Me.seParcela.Text & "', ValorParcela = " & Num(Me.grd2.GetRowCellDisplayText(0, Me.colValor).Replace("R$", "").Replace(".", "")) & ", Vencimento = '" & Me.grd2.GetRowCellDisplayText(0, Me.colVenc) & "', DataPagamento = '" & Me.dtPag.Text.Trim & "', Pagamento = '" & Me.luePag.GetColumnValue("FormaPagamento").ToString & "', ValorPago = " & Num(Me.txtValTotPag.Text.Replace("R$", "").Replace(".", "")) & ", Descricao = '" & Me.txtDesc.Text.Trim & "', PagoOK = '" & bolPago & "', NumeroDocumento = '" & Me.grd2.GetRowCellDisplayText(0, Me.colDocumento) & "', TipoCusto = '" & Me.cboTipCus.Text.Trim & "', Banco = '" & Me.cboBanco.Text.Trim & "', CentroCusto ='" & Me.cboCenCus.Text.Trim & "', Data='" & Me.dtConta.EditValue & "' where Codigo = " & intCodConta)
                MsgBox("Conta alterada com sucesso!", MsgBoxStyle.Information)
            Else
                '    Dim bolDiferenca As Boolean = False
                '    Dim dblValResul As Double
                '    If Me.txtValTotPag.Text < Me.txtTotal.Text Then

                '        dblValResul = Me.txtTotal.Text - Me.txtValTotPag.Text
                '        bolDiferenca = True
                '    End If
                '    Dim I As Integer
                '    Dim bolJaPassou As Boolean = False
                '    For I = 0 To Me.grd2.RowCount - 1
                '        Dim dblValorPago As Double
                '        If bolDiferenca = True Then
                '            dblValorPago = Me.grd2.GetRowCellDisplayText(I, Me.colValParcela) - dblValResul
                '            If dblValorPago < 0 Then
                '                dblValorPago = Me.grd2.GetRowCellDisplayText(I, Me.colValParcela)
                '            Else
                '                bolDiferenca = False
                '            End If
                '        Else
                '            dblValorPago = Me.grd2.GetRowCellDisplayText(I, Me.colValParcela)
                '        End If
                '        Dim intCodigoParcela As Integer = Me.grd2.GetRowCellValue(I, Me.colCodigoParcela)

                '        If I = 0 Then
                '            strCodPed = ", CÓD " & intCodigoParcela & ", "
                '            strParcela = Me.grd2.GetRowCellDisplayText(I, Me.colParcela)
                '        Else
                '            strCodPed &= intCodigoParcela & ", "
                '            strParcela &= ", " & Me.grd2.GetRowCellDisplayText(I, Me.colParcela)
                '        End If

                '        Dim strCmdInserir, strMot As String
                '        strMot = "FORNECEDOR " & Me.txtFornecedor.Text.Trim & ", PARCELA " & Me.seParcela.Text.Trim
                '        Select Case Me.cboBanco.Text

                '            Case "CAIXA"
                '                strCmdInserir = "INSERT INTO Caixa (Motivo, Caixa, Credito, Pagamento, Valor, Data, CentroCusto, CodConfig) VALUES('" & strMot & "','" & UserNano & "','" & "D" & "','" & Me.luePag.Text.Trim & "'," & Num(Me.txtValTotPag.Text.Trim) & ",'" & Me.dtPag.Text.Trim & "','" & Me.cboCenCus.Text.Trim & "'," & CodConfig & ")"
                '                Inserir(strCmdInserir)
                '            Case ""
                '                Dim intCodPag As Integer
                '                intCodPag = Me.luePag.GetColumnValue("Codigo")
                '                Dim dtPag As DataTable
                '                dtPag = CarregarDataTable("SELECT IrCaixa FROM Pagamento where Codigo = " & intCodPag)
                '                If dtPag.Rows.Count > 0 Then
                '                    Dim strCaixa As String
                '                    strCaixa = dtPag.Rows.Item(0).Item("IrCaixa").ToString
                '                    If strCaixa = "SIM" Then
                '                        If MsgBox("Deseja enviar o valor pago ao Caixa do dia referente a data de pagamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                '                            strCmdInserir = "INSERT INTO Caixa (Motivo, Caixa, Credito, Pagamento, Valor, Data, CentroCusto, CodConfig) VALUES('" & strMot & "','" & UserNano & "','" & "D" & "','" & Me.luePag.Text.Trim & "'," & Num(Me.txtValTotPag.Text.Trim) & ",'" & Me.dtPag.Text.Trim & "','" & Me.cboCenCus.Text.Trim & "'," & CodConfig & ")"
                '                            Inserir(strCmdInserir)
                '                        End If
                '                    End If
                '                End If
                '            Case Else
                '                Dim strBanco As String
                '                Dim dblValPago, dblSaldo, dblResul As Double
                '                Dim intCodBanco As Integer
                '                strBanco = Me.cboBanco.Text
                '                dblValPago = Me.txtValTotPag.Text
                '                Dim dtBanco As DataTable
                '                dtBanco = CarregarDataTable("SELECT Codigo, Saldo FROM Banco where Nome = '" & strBanco & "'")
                '                If dtBanco.Rows.Count > 0 Then
                '                    intCodBanco = dtBanco.Rows.Item(0).Item("Codigo").ToString
                '                    If dtBanco.Rows.Item(0).Item("Saldo").ToString = "" Then
                '                        dblSaldo = "0,00"
                '                    Else
                '                        dblSaldo = dtBanco.Rows.Item(0).Item("Saldo").ToString
                '                    End If
                '                    dblResul = dblSaldo - dblValPago
                '                    Inserir("INSERT INTO MovimentoBancario (CodBanco, TipoMovimento, Valor, Data, Observacao, CodConfig)VALUES(" & intCodBanco & ",'DÉBITO'," & Num(dblValPago) & ",'" & Me.dtPag.Text & "','" & strMot & "'," & CodConfig & ")")
                '                    Atualizar("UPDATE Banco SET Saldo = " & Num(dblResul) & " where Codigo = " & intCodBanco)
                '                End If
                '        End Select
                '    Next

                '    MsgBox("Conta finalizada com sucesso!", MsgBoxStyle.Information)
                'End If

                If AbrirFecharCaixa = True Then
                    If VerificarCaixa("") = False Then Exit Sub
                End If

                If Me.grd2.RowCount = 1 Then
                    Dim dblValor As Double = Me.txtValConta.Text.Replace("R$", "").Replace(".", "")
                    Dim dblValorParcela As Double = Me.grd2.GetRowCellDisplayText(0, Me.colValor).Replace("R$", "").Replace(".", "")
                    Dim dblValorPago As Double = Me.txtValTotPag.Text.Replace("R$", "").Replace(".", "")
                    Atualizar("UPDATE ContaPagar SET CodFor = '" & intCodFornecedor & "', " & _
                    "TipoConta = '" & Me.cboTipConta.Text.Trim & "', Valor = " & Num(dblValor.ToString) & ", " & _
                    "FormaPagamento = '" & Me.luePag.Text.Trim & "', Parcelas = '" & Me.seParcela.Text.Trim & "', " & _
                    "ValorParcela = " & Num(dblValorParcela.ToString) & ", " & _
                    "Vencimento = '" & Me.grd2.GetRowCellDisplayText(0, Me.colVenc) & "', " & _
                    "DataPagamento = '" & Me.dtPag.Text.Trim & "', ValorPago = " & Num(dblValorPago.ToString) & ", " & _
                    "Descricao = '" & Me.txtDesc.Text.Trim & "', PagoOK = '" & bolPago & "', " & _
                    "Pagamento = '" & Me.luePag.GetColumnValue("FormaPagamento").ToString & "', " & _
                    "NumeroDocumento = '" & Me.grd2.GetRowCellDisplayText(0, Me.colDocumento) & "', " & _
                    "TipoCusto = '" & Me.cboTipCus.Text.Trim & "', Banco = '" & Me.cboBanco.Text.Trim & "', " & _
                    "CentroCusto = '" & Me.cboCenCus.Text & "', Data = '" & Me.dtConta.EditValue & "' where Codigo = " & intCodConta)
                    strCodPed = " CÓD " & intCodConta
                    strParcela = Me.seParcela.Text.Trim
                Else
                    Dim bolDiferenca As Boolean = False
                    Dim dblValResul As Double
                    If Me.txtValTotPag.Text < Me.txtTotal.Text Then

                        dblValResul = Me.txtTotal.Text - Me.txtValTotPag.Text
                        bolDiferenca = True
                    End If

                    Dim I As Integer
                    Dim bolJaPassou As Boolean = False
                    For I = 0 To Me.grd2.RowCount - 1
                        Dim dblValorPago As Double
                        If bolDiferenca = True Then
                            dblValorPago = Me.grd2.GetRowCellDisplayText(I, Me.colValParcela) - dblValResul
                            If dblValorPago < 0 Then
                                dblValorPago = Me.grd2.GetRowCellDisplayText(I, Me.colValParcela)
                            Else
                                bolDiferenca = False
                            End If
                        Else
                            dblValorPago = Me.grd2.GetRowCellDisplayText(I, Me.colValParcela)
                        End If

                        Dim intCodigoParcela As Integer = Me.grd2.GetRowCellValue(I, Me.colCodigoParcela)

                        If I = 0 Then
                            strCodPed = " CÓD " & intCodigoParcela
                            strParcela = Me.grd2.GetRowCellDisplayText(I, Me.colParcela)
                        Else
                            strCodPed &= "/" & intCodigoParcela
                            strParcela &= "/" & Me.grd2.GetRowCellDisplayText(I, Me.colParcela)
                        End If
                        Dim dblValor As Double = Me.txtValConta.Text.Replace("R$", "").Replace(".", "")
                        Dim dblValorParcela As Double = dblValorPago.ToString.Replace("R$", "").Replace(".", "")
                        Dim dblValorPagoTot As Double = Me.txtValTotPag.Text.Replace("R$", "").Replace(".", "")


                        If dblValorPagoTot > 0 Then
                            Atualizar("UPDATE ContaPagar SET CodFor = " & intCodFornecedor & ", " & _
                            "TipoConta = '" & Me.cboTipConta.Text.Trim & "', Valor = " & Num(dblValor) & ", " & _
                            "FormaPagamento = '" & Me.luePag.Text.Trim & "', Parcelas = '" & Me.grd2.GetRowCellDisplayText(I, Me.colParcela) & "', " & _
                            "ValorParcela = " & Num(dblValorParcela.ToString) & ", " & _
                            "Vencimento = '" & Me.grd2.GetRowCellDisplayText(I, Me.colVenc) & "', " & _
                            "DataPagamento = '" & Me.dtPag.Text.Trim & "', ValorPago = " & Num(dblValorParcela.ToString) & ", " & _
                            "Descricao = '" & Me.txtDesc.Text.Trim & "', PagoOK = '" & bolPago & "', " & _
                            "Pagamento = '" & Me.luePag.GetColumnValue("FormaPagamento").ToString & "', " & _
                            "NumeroDocumento = '" & Me.grd2.GetRowCellDisplayText(I, Me.colDocumento) & "', " & _
                            "TipoCusto = '" & Me.cboTipCus.Text.Trim & "', Banco = '" & Me.cboBanco.Text.Trim & "', " & _
                            "CentroCusto = '" & Me.cboCenCus.Text & "', Data = '" & Me.dtConta.EditValue & "' where Codigo = " & intCodigoParcela)
                        Else
                            Atualizar("UPDATE ContaPagar SET CodFor = " & intCodFornecedor & ", " & _
                            "TipoConta = '" & Me.cboTipConta.Text.Trim & "', Valor = " & Num(dblValor) & ", " & _
                            "FormaPagamento = '" & Me.luePag.Text.Trim & "', Parcelas = '" & Me.grd2.GetRowCellDisplayText(I, Me.colParcela) & "', " & _
                            "ValorParcela = " & Num(dblValorParcela.ToString) & ", " & _
                            "Vencimento = '" & Me.grd2.GetRowCellDisplayText(I, Me.colVenc) & "', " & _
                            "DataPagamento = '" & Me.dtPag.Text.Trim & "', ValorPago = " & Num(dblValorPagoTot.ToString) & ", " & _
                            "Descricao = '" & Me.txtDesc.Text.Trim & "', PagoOK = '" & bolPago & "', " & _
                            "Pagamento = '" & Me.luePag.GetColumnValue("FormaPagamento").ToString & "', " & _
                            "NumeroDocumento = '" & Me.grd2.GetRowCellDisplayText(I, Me.colDocumento) & "', " & _
                            "TipoCusto = '" & Me.cboTipCus.Text.Trim & "', Banco = '" & Me.cboBanco.Text.Trim & "', " & _
                            "CentroCusto = '" & Me.cboCenCus.Text & "', Data = '" & Me.dtConta.EditValue & "' where Codigo = " & intCodigoParcela)
                        End If

                    Next
                End If

                IrCaixa(strCodPed, strParcela, Me.txtValTotPag.Text)

                If ImprimeContaPagar = True Then
                    If TemImpressora = True Then
                        Recibo("P/" & strParcela)
                        If SegViaRecibo = True Then
                            If MsgBox("Deseja imprimir a 2ª via do recibo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                Recibo("P/" & strParcela)
                            End If
                        End If
                    End If
                End If

                Dim strMot As String = "PARCELA " & Me.seParcela.Text.Trim & " , " & Me.txtFornecedor.Text.Trim
                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strMot & " A PAGAR','PAGO','CONTA A PAGAR','CONTA A PAGAR','PAGAMENTO'," & CodConfig & ")")
                MsgBox("Conta finalizada com sucesso!", MsgBoxStyle.Information)
            End If
        End If


        AtualizarGrid("PagoOK = 'False'")
        bolAlterado = False
        Limpar()

    End Sub

    Private Sub Recibo(ByVal parVenda As String)
        If TemImpressora = True Then
            If Impressora = "DARUMA" Then

                Dim strImpressao As String

                strImpressao = "<tc>#</tc>" & vbCrLf

                strImpressao &= "<b><ce>" & NomeEmpresa.ToString.Trim & "</ce></b>" & vbCrLf

                strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf

                strImpressao &= "<ce>" & TelefoneEmpresa & "</ce>" & vbCrLf
                strImpressao &= "<tc>#</tc>" & vbCrLf
                strImpressao &= "<e><ce>RECIBO DE PAGAMENTO" & "</ce></e>" & vbCrLf
                strImpressao &= "<e><ce>PARCELA DE PAGAMENTO" & "</ce></e>" & vbCrLf
                strImpressao &= "<tc>-</tc>" & vbCrLf

                If Me.txtFornecedor.Text <> "CONSUMIDOR" Then
                    strImpressao &= "<c><b>Fornecedor: " & Me.txtFornecedor.Text.Trim & "</b></c>" & vbCrLf
                    strImpressao &= "<c><b>CPF/CNPJ: " & strCPFFornecedor & "</b></c>" & vbCrLf
                    strImpressao &= "<c>Data Pagamento: " & Me.dtPag.Text.Trim & "</c>" & vbCrLf
                    strImpressao &= "<l></l>" & vbCrLf
                End If

                Dim P As Integer

                For P = 0 To grd2.RowCount - 1
                    'strImpressao &= "<c>Venda N°: " & Me.grd2.GetRowCellDisplayText(P, Me.colCodPed).Trim & "</c>" & vbCrLf
                    strImpressao &= "<c>Parcela: " & Me.grd2.GetRowCellDisplayText(P, Me.colParcela) & "</c>" & vbCrLf
                    strImpressao &= "<c><b>Valor Parcela: R$ " & Me.grd2.GetRowCellDisplayText(P, Me.colValParcela) & "</b></c>" & vbCrLf
                    strImpressao &= "<l></l>" & vbCrLf
                Next

                'Dim dblComJuros As Double = Me.txtComJuros.Text
                'Dim dblSemJuros As Double = Me.txtTotal.Text
                'If dblComJuros > dblSemJuros Then
                '    'strImpressao &= "<c><b>Total Com Juros: R$ " & Me.txtComJuros.Text & "</b></c>" & vbCrLf
                '    strImpressao &= "<l></l>" & vbCrLf
                'Else
                strImpressao &= "<l></l>" & vbCrLf
                'End If

                strImpressao &= "<c><b>Total Pago: R$ " & Me.txtValTotPag.Text.Trim & "</b></c>" & vbCrLf

                'If Me.txtTroco.Text.Trim <> "0,00" Then
                '    strImpressao &= "<c><b>Valor Troco: R$ " & Me.txtTroco.Text.Trim & "</b></c>" & vbCrLf
                'End If

                strImpressao &= "<tc>-</tc>" & vbCrLf
                strImpressao &= "<ce>DOCUMENTO NÃO FISCAL" & "</ce>" & vbCrLf
                strImpressao &= "<l></l>" & vbCrLf
                strImpressao &= "<l></l>" & vbCrLf
                strImpressao &= "<l></l>" & vbCrLf

                If TemGuilhotina = True Then
                    strImpressao &= "<gui></gui>" & vbCrLf
                End If

                If ImpressoraOK() = True Then
                    iRetorno = (iImprimirTexto_DUAL_DarumaFramework(strImpressao, 0))
                End If

            ElseIf Impressora.Contains("MP") Or Impressora.Contains("ARQUIVO") Or Impressora.Contains("NANO PRINT") Then
                If TemImpressora = False Then Exit Sub
                Dim strImpressao As String
                If Impressora.Contains("MP-4000") Then
                    iRetorno = ConfiguraModeloImpressora(5)
                    iRetorno = SelecionaQualidadeImpressao(3)
                Else
                    If Impressora.Contains("BEMATECH") = True Then
                        iRetorno = ConfiguraModeloImpressora(1)
                    Else
                        Try
                            iRetorno = ConfiguraModeloImpressora(1)
                        Catch ex As Exception

                        End Try
                    End If

                End If
                If Impressora.Contains("BEMATECH") = True Then
                    iRetorno = clsBematech.IniciaPorta(PortaImpressora)

                Else
                    Try
                        iRetorno = clsBematech.IniciaPorta(PortaImpressora)

                    Catch ex As Exception

                    End Try
                End If


                Dim intTamEsp As Integer
                Dim strEstrela, strTraço As String

                If Impressora.Contains("ARQUIVO") = True Then
                    intTamEsp = 42
                    strEstrela = "******************************************"
                    strTraço = "------------------------------------------"
                Else
                    intTamEsp = 60
                    strEstrela = "************************************************************"
                    strTraço = "------------------------------------------------------------"
                End If


                strImpressao = strEstrela & vbCrLf

                strImpressao &= Cent(NomeEmpresa.ToString.Trim, intTamEsp) & vbCrLf
                strImpressao &= Cent(EnderecoEmpresa.Trim, intTamEsp) & vbCrLf
                strImpressao &= Cent(TelefoneEmpresa, intTamEsp) & vbCrLf

                strImpressao &= strEstrela & vbCrLf
                strImpressao &= " " & vbCrLf
                strImpressao &= Cent("RECIBO DE PAGAMENTO", intTamEsp) & vbCrLf
                strImpressao &= Cent("PARCELA DE PAGAMENTO", intTamEsp) & vbCrLf
                strImpressao &= " " & vbCrLf
                strImpressao &= strTraço & vbCrLf
                If Me.txtFornecedor.Text <> "CONSUMIDOR" Then
                    strImpressao &= "Fornededor: " & Me.txtFornecedor.Text.Trim & vbCrLf
                    strImpressao &= "CPF/CNPJ: " & strCPFFornecedor & vbCrLf
                    strImpressao &= "Data Pagamento: " & Me.dtPag.Text.Trim & vbCrLf & vbCrLf
                End If

                Dim P As Integer

                For P = 0 To grd2.RowCount - 1
                    'strImpressao &= "Venda N°: " & Me.grd2.GetRowCellDisplayText(P, Me.colCodPed).Trim & vbCrLf
                    strImpressao &= "Parcela: " & Me.grd2.GetRowCellDisplayText(P, Me.colParcela) & vbCrLf
                    strImpressao &= "Valor Parcela: R$ " & Me.grd2.GetRowCellDisplayText(P, Me.colValParcela) & vbCrLf & vbCrLf
                Next

                'Dim dblComJuros As Double = Me.txtComJuros.Text
                'Dim dblSemJuros As Double = Me.txtTotal.Text
                'If dblComJuros > dblSemJuros Then
                '    strImpressao &= "Total Com Juros: R$ " & Me.txtComJuros.Text & vbCrLf & vbCrLf
                '    strImpressao &= vbCrLf
                'Else
                strImpressao &= vbCrLf
                'End If

                strImpressao &= "TOTAL PAGO: R$ " & Me.txtValTotPag.Text.Trim & vbCrLf

                'If Me.txtTroco.Text.Trim <> "0,00" Then
                '    strImpressao &= "Valor Troco: R$ " & Me.txtTroco.Text.Trim & vbCrLf
                'End If

                strImpressao &= strTraço & vbCrLf

                strImpressao &= Cent("DOCUMENTO NÃO FISCAL", intTamEsp) & vbCrLf

                strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")

                If Impressora = "ARQUIVO" Then
                    ImprimiArquivo(strImpressao, PortaImpressora)
                ElseIf Impressora.Contains("NANO PRINT") = True Then
                    If Impressora = "NANO PRINT ARQUIVO DIRETO" Then
                        ImprimeArquivo(My.Application.Info.DirectoryPath & "\Cupom.txt", strImpressao)
                    Else
                        EscreveArquivo(PortaImpressora & "\Cupom.txt", strImpressao)
                    End If
                Else
                    iRetorno = clsBematech.FormataTX(strImpressao, 1, 0, 0, 0, 1)

                    If TemGuilhotina = True Then
                        iRetorno = clsBematech.AcionaGuilhotina(0)
                    End If

                End If
                If Impressora.Contains("BEMATECH") = True Then
                    iRetorno = clsBematech.FechaPorta()

                Else
                    Try
                        iRetorno = clsBematech.FechaPorta()

                    Catch ex As Exception

                    End Try
                End If

            ElseIf Impressora = "EPSON" Then

                If TemImpressora = False Then Exit Sub
                Dim strImpressao As String


                Dim intTamEsp As Integer
                Dim strEstrela, strTraço As String

                strEstrela = clsImprimir.Comp("************************************************")
                strTraço = clsImprimir.Comp("------------------------------------------------")

                strImpressao = strEstrela & vbCrLf

                strImpressao &= "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf
                strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf
                strImpressao &= "<ce>" & TelefoneEmpresa & "</ce>" & vbCrLf

                strImpressao &= strEstrela & vbCrLf
                strImpressao &= " " & vbCrLf
                strImpressao &= "<ce>" & "RECIBO DE PAGAMENTO" & "</ce>" & vbCrLf
                strImpressao &= "<ce>" & "PARCELA DE PAGAMENTO" & "</ce>" & vbCrLf
                strImpressao &= " " & vbCrLf
                strImpressao &= strTraço & vbCrLf
                If Me.txtFornecedor.Text <> "CONSUMIDOR" Then
                    strImpressao &= "Fornecedor: " & Me.txtFornecedor.Text.Trim & vbCrLf
                    strImpressao &= "CPF/CNPJ: " & strCPFFornecedor & vbCrLf
                    strImpressao &= "Data Pagamento: " & Me.dtPag.Text.Trim & vbCrLf & vbCrLf
                End If

                Dim P As Integer

                For P = 0 To grd2.RowCount - 1
                    'strImpressao &= "Venda N°: " & Me.grd2.GetRowCellDisplayText(P, Me.colCodPed).Trim & vbCrLf
                    strImpressao &= "Parcela: " & Me.grd2.GetRowCellDisplayText(P, Me.colParcela) & vbCrLf
                    strImpressao &= "Valor Parcela: R$ " & Me.grd2.GetRowCellDisplayText(P, Me.colValParcela) & vbCrLf & vbCrLf
                Next


                'Dim dblComJuros As Double = Me.txtComJuros.Text
                'Dim dblSemJuros As Double = Me.txtTotal.Text
                'If dblComJuros > dblSemJuros Then
                '    strImpressao &= "Total Com Juros: R$ " & Me.txtComJuros.Text & vbCrLf & vbCrLf
                '    strImpressao &= vbCrLf
                'Else
                strImpressao &= vbCrLf
                'End If


                strImpressao &= "TOTAL PAGO: R$ " & Me.txtValTotPag.Text.Trim & vbCrLf

                'If Me.txtTroco.Text.Trim <> "0,00" Then
                '    strImpressao &= "Valor Troco: R$ " & Me.txtTroco.Text.Trim & vbCrLf
                'End If

                strImpressao &= strTraço & vbCrLf

                strImpressao &= "<ce>" & "DOCUMENTO NÃO FISCAL" & "</ce>" & vbCrLf

                strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")


                iRetorno = clsEpson.IniciaPorta(PortaImpressora)

                iRetorno = clsEpson.ImprimeTextoTag(strImpressao)

                If TemGuilhotina = True Then
                    iRetorno = clsEpson.AcionaGuilhotina(1)
                End If
                iRetorno = clsEpson.FechaPorta()


            ElseIf Impressora.Contains("ESC/POS") = True Then

                Dim strImpressao As String

                strImpressao = Cabecalho()

                strImpressao &= Centralizar(Exp("RECIBO DE PAGAMENTO")) & vbCrLf
                strImpressao &= Centralizar(Exp("PARCELA DE PAGAMENTO")) & vbCrLf
                strImpressao &= strTraco & vbCrLf
                If Me.txtFornecedor.Text <> "CONSUMIDOR" Then
                    strImpressao &= Neg(Dir("Fornecedor: " & Me.txtFornecedor.Text.Trim, 55)) & vbCrLf
                    strImpressao &= Comp(Dir("CPF/CNPJ: " & strCPFFornecedor, 55)) & vbCrLf
                    strImpressao &= Comp(Dir("Data Pagamento: " & Me.dtPag.Text.Trim, 55)) & vbCrLf & vbCrLf
                End If

                Dim P As Integer

                For P = 0 To grd2.RowCount - 1
                    'strImpressao &= Comp(Dir("Venda N: " & Me.grd2.GetRowCellDisplayText(P, Me.colCodPed).Trim, 55)) & vbCrLf
                    strImpressao &= Comp(Dir("Parcela: " & Me.grd2.GetRowCellDisplayText(P, Me.colParcela), 55)) & vbCrLf
                    strImpressao &= Neg(Dir("Valor Parcela: R$ " & Me.grd2.GetRowCellDisplayText(P, Me.colValParcela), 55)) & vbCrLf & vbCrLf
                Next

                'Dim dblComJuros As Double = Me.txtComJuros.Text
                'Dim dblSemJuros As Double = Me.txtTotal.Text
                'If dblComJuros > dblSemJuros Then
                '    strImpressao &= Neg(Dir("Total Com Juros: R$ " & Me.txtComJuros.Text, 55)) & vbCrLf & vbCrLf
                '    strImpressao &= vbCrLf
                'Else
                strImpressao &= vbCrLf
                'End If

                If NomeEmpresa.Trim.ToUpper.Contains("ATUALIZADA") = True Then
                    strImpressao &= Neg(Dir("Obs: " & Me.txtDesc.Text.Trim, 55)) & vbCrLf & vbCrLf
                End If

                strImpressao &= DupLin(Dir("TOTAL PAGO: R$ " & Me.txtValTotPag.Text.Trim, 55)) & vbCrLf

                'If Me.txtTroco.Text.Trim <> "0,00" Then
                '    strImpressao &= Dir("VALOR TROCO: R$ " & Me.txtTroco.Text.Trim, 55) & vbCrLf
                'End If

                Rodape(True, strImpressao)
            End If
        Else
            If MsgBox("Deseja imprimir o recibo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim rel As New relReciboPag
                rel.picLogo.Image = LogoTipo
                Dim dblValor As Double

                dblValor = Me.txtValTotPag.Text.Trim

                Dim strValorExt As String = dblValor.ToString("0.00")
                Dim vetValor As Array
                vetValor = Split(strValorExt, ",")
                Dim strReais, strCentavos As String
                strReais = getInteger(vetValor(0))
                If vetValor(0) = "0" Then
                    If vetValor(1) <> "00" Then
                        strCentavos = getInteger(vetValor(1))
                        strValorExt = strCentavos.ToUpper & " CENTAVOS"
                    End If
                Else
                    If vetValor(1) = "00" Then
                        strValorExt = strReais.ToUpper & " REAIS"
                    Else
                        strCentavos = getInteger(vetValor(1))
                        strValorExt = strReais.ToUpper & " REAIS E " & strCentavos.ToUpper & " CENTAVOS"
                    End If
                End If


                Dim I As Integer
                With rel.tbRecibo.Rows
                    For I = 0 To 1
                        .Add()
                        If I = 0 Then
                            .Item(I).Item("Empresa") = NomeEmpresa
                            .Item(I).Item("Empresa1") = NomeEmpresa
                        Else
                            .Item(I).Item("Empresa") = Me.txtFornecedor.Text.Trim
                            .Item(I).Item("Empresa1") = Me.txtFornecedor.Text.Trim
                        End If
                        .Item(I).Item("Endereco") = EnderecoEmpresa
                        .Item(I).Item("Telefone") = TelefoneEmpresa
                        .Item(I).Item("Email") = ""
                        .Item(I).Item("Valor") = dblValor.ToString("###,###,###,##0.00")
                        .Item(I).Item("Via") = I + 1 & "ª VIA"
                        .Item(I).Item("ValorExtenso") = strValorExt
                        .Item(I).Item("Cliente") = Me.txtFornecedor.Text
                        .Item(I).Item("CPF") = strCPFFornecedor
                        '.Item(I).Item("Referente") = "DA PARCELA " & parParcela & " DA VENDA " & parVenda
                        .Item(I).Item("Data") = Me.dtPag.Text.Trim
                    Next
                End With
                rel.ShowPreview()
            End If
        End If
    End Sub

    Private Sub IrCaixa(ByVal parCodPed As String, ByVal parParcela As String, ByVal parValor As Double)
        Dim strCmdInserir, strMot As String
        strMot = "FORNECEDOR " & Me.txtFornecedor.Text.Trim & ", PARCELA " & parParcela & parCodPed

        Dim strAuxiliar As String
        strAuxiliar = NomeComputador.ToUpper & " " & Format(My.Computer.Clock.LocalTime, "dd/MM/yyyy HH:mm:ss:fffff")

        Select Case Me.cboBanco.Text

            Case "CAIXA"
                strCmdInserir = "INSERT INTO Caixa (Motivo, Credito, Pagamento, Valor, Data, CodConfig, CentroCusto, Caixa, Auxiliar) VALUES('" & strMot & "','" & "D" & "','" & Me.luePag.Text.Trim & "'," & Num(Me.txtValTotPag.Text.Trim) & ",'" & Me.dtPag.Text.Trim & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now) & "'," & CodConfig & ",'" & Me.cboCenCus.Text & "','" & UserNano.Trim & "','" & strAuxiliar & "')"
                Inserir(strCmdInserir)
            Case ""
                If MsgBox("Deseja enviar o valor pago ao Caixa do dia referente a data do pagamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    strCmdInserir = "INSERT INTO Caixa (Motivo, Credito, Pagamento, Valor, Data, CodConfig, CentroCusto, Caixa, Auxiliar) VALUES('" & strMot & "','" & "D" & "','" & Me.luePag.Text.Trim & "'," & Num(Me.txtValTotPag.Text.Trim) & ",'" & Me.dtPag.Text.Trim & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now) & "'," & CodConfig & ",'" & Me.cboCenCus.Text & "','" & UserNano.Trim & "','" & strAuxiliar & "')"
                    Inserir(strCmdInserir)
                End If
            Case Else
                Dim strBanco As String
                Dim dblValPago, dblSaldo, dblResul As Double
                Dim intCodBanco As Integer
                strBanco = Me.cboBanco.Text
                dblValPago = Me.txtValTotPag.Text
                Dim dtBanco As DataTable
                dtBanco = CarregarDataTable("SELECT Codigo, Saldo FROM Banco where Nome = '" & strBanco & "'")
                If dtBanco.Rows.Count > 0 Then
                    intCodBanco = dtBanco.Rows.Item(0).Item("Codigo").ToString
                    If dtBanco.Rows.Item(0).Item("Saldo").ToString = "" Then
                        dblSaldo = "0,00"
                    Else
                        dblSaldo = dtBanco.Rows.Item(0).Item("Saldo").ToString
                    End If
                    dblResul = dblSaldo - dblValPago
                    Inserir("INSERT INTO MovimentoBancario (CodBanco, TipoMovimento, Valor, Data, Observacao, CodConfig)VALUES(" & intCodBanco & ",'DÉBITO'," & Num(dblValPago) & ",'" & Me.dtPag.Text & "','" & strMot & "'," & CodConfig & ")")
                    Atualizar("UPDATE Banco SET Saldo = " & Num(dblResul) & " where Codigo = " & intCodBanco)
                End If
        End Select
    End Sub
    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If MsgBox("Deseja realmente limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Limpar()
        End If
    End Sub

    Private Sub btnAlterar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterar.ItemClick
        Alterar()
    End Sub


    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        If grd1.RowCount = 0 Then Exit Sub
        Dim Index As Integer = grd1.FocusedRowHandle
        If Index < 0 Then Exit Sub
        If bolAlterado = True Then MsgBox("Existe uma parcela sendo alterada, finalize a operação antes de excluir!", MsgBoxStyle.Information) : Exit Sub

        'Dim strCodi As String = grd1.GetRowCellValue(Index, Me.colCodigo)
        Dim strNumPar As String = grd1.GetRowCellValue(Index, Me.colParcelas)
        'Dim strFor As String = grd1.GetRowCellValue(Index, Me.colCodFor)
        'Dim strValPar As String = grd1.GetRowCellValue(Index, Me.colValorParcela)
        'Dim strAntigo As String = "FORNECEDOR " & strFor & ", PARCELA " & strNumPar & ", VALOR " & strValPar & ""

        If MsgBox("Deseja realmente excluir a Parcela " & strNumPar & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            If SenhaEstaOK() = False Then Exit Sub

            'Excluir("Delete from ContaPagar where Codigo = " & strCodi)

            'Dim strObs As String = "FORNECEDOR " & Me.grd1.GetFocusedRowCellValue(Me.colFornecedor) & ", PARCELA " & strNumPar

            'Excluir("Delete From MovimentoBancario where Data ='" & Me.grd1.GetFocusedRowCellValue(Me.colDataPagamento) & "' and Valor =" & Num(Me.grd1.GetFocusedRowCellValue(Me.colValorPago)) & " and Observacao Like '%" & strObs & "%'")
            Estornar(False, Me.grd1.FocusedRowHandle)

            If Me.Tag = "PAGAS" Then
                AtualizarGrid("PagoOK = 'True'")
            Else
                AtualizarGrid("PagoOK = 'False'")
            End If
            'Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strAntigo & "','EXCLUÍDO','CONTA A PAGAR','CONTA A PAGAR','EXCLUSÃO'," & CodConfig & ")")
            'MsgBox("Parcela " & strNumPar & " excluida com sucesso!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub rdgFim_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rdgFim.KeyPress
        If Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtValPar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "," And e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtValConta_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        Preco(txtValConta)
    End Sub

    Private Sub txtValPag_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Preco(txtValTotPag)
    End Sub

    Private Sub btnCancelar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelar.ItemClick
        Me.Close()
    End Sub

    Private Sub ContaPagarGridControl_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        If Me.Tag = "PAGAS" Then Exit Sub
        Alterar()
    End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        If Me.Tag = "PAGAS" Then Exit Sub
        Alterar()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click

        If Me.Tag = "PAGAS" Then
            Dim dblTotRecebido As Double

            For I = 0 To grd1.RowCount - 1

                Dim dblRecebido As Double

                With grd1

                    If .GetRowCellDisplayText(I, Me.colValorPago) <> "" Then
                        dblRecebido = .GetRowCellDisplayText(I, Me.colValorPago)
                    Else
                        dblRecebido = 0
                    End If

                End With

                dblTotRecebido += dblRecebido
            Next

            Me.txtRecebido.Text = dblTotRecebido.ToString("###,###,###,##0.00")
        Else
            Dim dblTotRecebido As Double

            For I = 0 To grd1.RowCount - 1

                Dim dblRecebido As Double

                With grd1

                    If .GetRowCellDisplayText(I, Me.colValorParcela) <> "" Then
                        dblRecebido = .GetRowCellDisplayText(I, Me.colValorParcela)
                    Else
                        dblRecebido = 0
                    End If

                End With

                dblTotRecebido += dblRecebido
            Next

            Me.txtRecebido.Text = dblTotRecebido.ToString("###,###,###,##0.00")

        End If



    End Sub

    Private Sub btnFiltrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFiltrar.ItemClick

        Dim data1, data2 As String
        data1 = dtInicial1.EditValue
        data2 = dtFinal.EditValue

        If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Sub
        If data2 = "" Then MsgBox("Selecione a Data Final!", MsgBoxStyle.Information) : Exit Sub

        Dim dataFim, dataIni As Date
        dataIni = data1
        dataFim = data2

        If dataIni > dataFim Then MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information) : Exit Sub

        If Me.Tag = "PAGAS" Then

            Dim strFiltro As String = "PagoOK = '" & True & "' and " & String.Format("DataPagamento >= '{0:dd/MM/yyyy}' AND DataPagamento <= '{1:dd/MM/yyyy}'", dtInicial1.EditValue, dtFinal.EditValue)

            AtualizarGrid(strFiltro)
        Else
            Dim strFiltro As String = "PagoOK = '" & False & "' and " & String.Format("Vencimento >= '{0:dd/MM/yyyy}' AND Vencimento <= '{1:dd/MM/yyyy}'", dtInicial1.EditValue, dtFinal.EditValue)
            AtualizarGrid(strFiltro)

        End If

    End Sub

    Private Sub txtFornecedor_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtFornecedor.ButtonClick
        TrazFornecedor()
    End Sub

    Private Sub TrazFornecedor()
        Try
            frmCadFornecedor.Close()
        Catch ex As Exception
        End Try
      
        'Dim frm As New frmCadFornecedor
        frmCadFornecedor.Tag = "PESQUISA"
        frmCadFornecedor.ShowDialog()

        Dim dt As DataTable = CarregarDataTable("Select Nome from Fornecedor where Codigo =" & CodigoDoFornecedor)

        If dt.Rows.Count > 0 Then
            intCodFornecedor = CodigoDoFornecedor
            Me.txtFornecedor.Text = dt.Rows.Item(0).Item("Nome").ToString
        End If

    End Sub

   
    Private Sub btnCadBanco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadBanco.Click
        frmCadBanco.ShowDialog()
        Me.cboBanco.Properties.Items.Clear()
        PreencherOrdenado("Banco", Me.cboBanco, 1, "Nome")
        Me.cboBanco.Properties.Items.Add("")
    End Sub

    Private Sub txtFornecedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFornecedor.KeyDown
        If e.KeyCode = Keys.F10 Then
            TrazFornecedor()
        End If
    End Sub

    Private Sub seParcela_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seParcela.Enter
        If bolAlterado = False Then
            GerarParecelas()
        End If
    End Sub

    Private Sub GerarParecelas()

        If bolAlterado = True Then Exit Sub

        If Me.gridPar.Visible = False Then Exit Sub

        If Validar(Me.txtValConta) = False Then Exit Sub
        If Validar(Me.dtVenc) = False Then Exit Sub
        If Me.txtDias.Text = "" Then
            Me.txtDias.Text = "30"
        End If
        Dim I As Integer
        Dim dblValConta, dblValPar As Double

        dblValConta = Me.txtValConta.Text.Trim

        dblValPar = dblValConta / Me.seParcela.Value

        Dim dtDate As Date = Me.dtVenc.DateTime

        Me.tdCred.Rows.Clear()
        Dim dblTotal As Double
        For I = 0 To Me.seParcela.Value - 1

            With Me.tdCred.Rows
                .Add()

                .Item(I).Item("Parcela") = I + 1
                .Item(I).Item("Valor") = dblValPar.ToString("0.00")
                .Item(I).Item("Vencimento") = dtDate
                .Item(I).Item("Documento") = strNumDocumento

                If Me.txtDias.Text = "30" Then
                    dtDate = dtDate.AddMonths(1)
                Else
                    dtDate = dtDate.AddDays(Me.txtDias.Text)
                End If
                dblTotal += dblValPar
            End With

        Next
        If dblTotal > 0 Then
            Dim dblResul As Double = dblValConta - dblTotal
            If dblResul > "0,5" Then
                MsgBox("A soma das parcelas não batem com o valor da conta!", MsgBoxStyle.Information)
            End If
        End If
       
    End Sub

    Private Sub seParcela_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seParcela.EditValueChanged
         GerarParecelas()
    End Sub

    Private Sub txtVal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVal.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "," And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtVal_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVal.Leave
        If Me.grd2.GetFocusedDisplayText = "" Then Exit Sub
        Try
            Dim dblVal As Double = Me.grd2.GetFocusedDisplayText
            Me.grd2.SetFocusedValue(dblVal.ToString("0.00"))


            If Me.txtValConta.Text = "" Then Exit Sub
            If Me.seParcela.Text = "" Then Exit Sub
            Dim dblTotal As Double
            Dim I As Integer
            For I = 0 To Me.grd2.RowCount - 1
                dblTotal += Me.grd2.GetRowCellDisplayText(I, Me.colValParcela)

            Next

            Dim dblvalor As Double = Me.txtValConta.Text
            Dim dblResul As Double = dblvalor - dblTotal
            If dblResul > "0,5" Then
                MsgBox("A soma das parcelas não batem com o valor da conta!", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("Caracter digitado não é permitido para este campo!", MsgBoxStyle.Exclamation)
            Me.grd2.SetFocusedValue("")
        End Try
    End Sub

    Private Sub lueLoja_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueLoja.DoubleClick
        Alterar()
    End Sub

    Private Sub btnCenCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCenCus.Click
        Dim frm As New frmGrupo
        frm.Tag = "CENTROCUSTO"
        frm.ShowDialog()
        Me.cboCenCus.Properties.Items.Clear()
        PreencherGrupoSetorCusto("C", Me.cboCenCus)
        Me.cboCenCus.Focus()
    End Sub

    Private Sub btnRelConta_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelConta.ItemClick

        Dim I As Integer
        Dim rel As New relContaPagar
        rel.picLogo.Image = LogoTipo
        Dim dtDataInicial As Date
        Dim dtDataFinal As Date
        Dim dtDT As Date
        If QtdeLoja > 1 Then
            rel.colCodConfig.Visible = True
        End If
        With rel.tbPagar.Rows

            For I = 0 To grd1.RowCount - 1
                .Add()
                .Item(I).Item("Codigo") = grd1.GetRowCellDisplayText(I, Me.colCodigo)
                .Item(I).Item("Fornecedor") = grd1.GetRowCellDisplayText(I, Me.colFornecedor)
                .Item(I).Item("TipoConta") = grd1.GetRowCellDisplayText(I, Me.colTipoConta)
                .Item(I).Item("Valor") = grd1.GetRowCellDisplayText(I, Me.colValor)
                .Item(I).Item("Parcelas") = grd1.GetRowCellDisplayText(I, Me.colParcelas)
                .Item(I).Item("ValorParcelas") = grd1.GetRowCellDisplayText(I, Me.colValorParcela)
                .Item(I).Item("Vencimento") = grd1.GetRowCellDisplayText(I, Me.colVencimento)
                .Item(I).Item("ValorPago") = grd1.GetRowCellDisplayText(I, Me.colValorPago)
                .Item(I).Item("DataPagamento") = grd1.GetRowCellDisplayText(I, Me.colDataPagamento)
                .Item(I).Item("CentroCusto") = grd1.GetRowCellDisplayText(I, Me.colCentroCusto)
                .Item(I).Item("CodConfig") = grd1.GetRowCellDisplayText(I, Me.colCodConfig)
                If Me.Tag = "PAGAS" Then
                    dtDT = grd1.GetRowCellDisplayText(I, Me.colDataPagamento)
                Else
                    dtDT = grd1.GetRowCellDisplayText(I, Me.colVencimento)
                End If

                If I = 0 Then
                    dtDataInicial = dtDT
                    dtDataFinal = dtDT
                End If
                If dtDT < dtDataInicial Then
                    dtDataInicial = dtDT
                End If
                If dtDT > dtDataFinal Then
                    dtDataFinal = dtDT
                End If
            Next
            rel.lblPeriodo.Text = "De " & Format(dtDataInicial, "dd/MM/yyyy") & " a " & Format(dtDataFinal, "dd/MM/yyyy")
            If Me.Tag = "PAGAS" Then
                rel.lblRelTotal.Text = "Total Pago R$"
                rel.lblTitulo.Text = "Relatório de Contas Pagas"
            Else
                If Me.colDataPagamento.Visible = False Then
                    rel.colDataPagamento.Visible = False
                End If
                If Me.colValorPago.Visible = False Then
                    rel.colValorPago.Visible = False
                End If
                rel.lblRelTotal.Text = "Total a Pagar R$"
                rel.lblTitulo.Text = "Relatório de Contas a Pagar"
            End If
            rel.lblTotal.Text = Me.txtRecebido.Text.Trim
        End With

        rel.ShowPreview()

    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.Grid1.ShowPrintPreview()
    End Sub

    Private Sub txtDesc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesc.KeyPress, cboTipConta.KeyPress
        If e.KeyChar = "'" Or e.KeyChar = "&" Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnEstornar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstornar.ItemClick

        'If Me.grd1.FocusedRowHandle < 0 Then Exit Sub

        'If MsgBox("Deseja realmente estorna esta conta paga?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '    Dim strCodigo As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)
        '    Dim strCodConfig As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodConfig)

        '    Dim strParcela As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colParcelas)
        '    Dim strFor As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colFornecedor)
        '    Dim strData As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colDataPagamento)

        '    Atualizar("UPDATE ContaPagar SET PagoOK = 'False' where Codigo = " & strCodigo & " and CodConfig = " & strCodConfig)

        '    Dim strObs As String = "FORNECEDOR " & Me.grd1.GetFocusedRowCellValue(Me.colFornecedor) & ", PARCELA " & strParcela

        '    Excluir("Delete From MovimentoBancario where Data ='" & Me.grd1.GetFocusedRowCellValue(Me.colDataPagamento) & "' and Valor =" & Num(Me.grd1.GetFocusedRowCellValue(Me.colValorPago)) & " and Observacao Like '%" & strObs & "%'")

        '    Excluir("DELETE FROM Caixa where Motivo = 'FORNECEDOR " & strFor & ", PARCELA " & strParcela & "' and Data = '" & strData & "' and CodConfig = " & strCodConfig)
        '    MsgBox("Conta estornada com sucesso!", MsgBoxStyle.Information)

        '    AtualizarGrid("PagoOK = 'True'")
        'End If

        'If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        'If MsgBox("Deseja realmente estorna esta conta recebida?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '    Estornar(True)
        'End If

        'If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        Dim bolPassou As Boolean = False
        If MsgBox("Deseja realmente estorna esta(s) conta(s) paga(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim index As Integer = -999997
            grd1.FocusedRowHandle = index

            For I As Integer = 0 To Me.grd1.RowCount - 1
                If Me.grd1.GetRowCellValue(I, Me.colEstornar) = True Then
                    Estornar(True, I)
                    bolPassou = True
                End If
            Next
        End If

        If bolPassou = True Then
            If bolParcial = True Then
                MsgBox("Não é possível estornar contas parciais!", MsgBoxStyle.Information)
                bolParcial = False
            Else
                MsgBox("Conta estornada com sucesso!", MsgBoxStyle.Information)
            End If

            If Me.Tag = "PAGAS" Then
                AtualizarGrid("PagoOK = 'True'")
            Else
                AtualizarGrid("PagoOK = 'False'")
            End If
        End If
    End Sub

    Dim bolParcial As Boolean = False
    Private Sub Estornar(ByVal parEstornar As Boolean, ByVal Index As Integer)
        'Dim strCodigo As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)
        'Dim strCodConfig As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodConfig)
        'Dim strParcela As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colParcelas)
        'Dim strCliente As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colFornecedor)
        'Dim dblValPar As Double = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colValorPago)

        Dim strCodigo As String = Me.grd1.GetRowCellDisplayText(Index, Me.colCodigo)
        Dim strCodConfig As String = Me.grd1.GetRowCellDisplayText(Index, Me.colCodConfig)
        Dim strParcela As String = Me.grd1.GetRowCellDisplayText(Index, Me.colParcelas)
        Dim strCliente As String = Me.grd1.GetRowCellDisplayText(Index, Me.colFornecedor)
        Dim dblValPar As Double = Me.grd1.GetRowCellDisplayText(Index, Me.colValorPago)
        If Me.Tag <> "PAGAS" Then
            dblValPar = Me.grd1.GetRowCellDisplayText(Index, Me.colValorParcela)
        End If
      


    

        Dim strAntigo As String = "FORNECEDOR " & strCliente & ", PARCELA " & strParcela & ", VALOR " & dblValPar & ""

        If Me.Tag = "PAGAS" Then

            Dim strData As String = Me.grd1.GetRowCellDisplayText(Index, Me.colDataPagamento)
            Dim dtData As Date = strData

            If AbrirFecharCaixa = True Then
                Dim dtCaixa As DataTable = CarregarDataTable("SELECT Codigo, Motivo FROM CAIXA where Motivo " & _
                "LIKE '%CÓD%' and motivo like '%" & strCodigo & "%' and Motivo LIKE '%" & strCliente & ", PARCELA%' and CodConfig = " & strCodConfig & " and Data >= '" & dtData & "' and Data <= '" & dtData.AddDays(1) & "'")
                If dtCaixa.Rows.Count > 0 Then
                    Dim strCodigoCaixa As String = dtCaixa.Rows.Item(0).Item("Codigo").ToString
                    Dim strMotivoCaixa As String = dtCaixa.Rows.Item(0).Item("Motivo").ToString
                    If VerificarExclusaoCaixa(strMotivoCaixa, strCodigoCaixa) = False Then Exit Sub
                End If
            End If

            If parEstornar = True Then
                'If strParcela.Contains("P") = True Then MsgBox("Não é possível estornar contas parciais!", MsgBoxStyle.Information) : Exit Sub
                If strParcela.Contains("P") = True Then
                    bolParcial = True
                    Exit Sub
                End If
            End If

            If strParcela.Contains("P") = False Then
                Dim vetParcela As Array = Split(strParcela, "/")

                strParcela = vetParcela(0)

                'Dim strData As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colDataPagamento)
            

                Dim dt As DataTable = CarregarDataTable("SELECT Codigo, Motivo, Valor FROM CAIXA where Motivo " & _
                "LIKE '%CÓD%' and motivo like '%" & strCodigo & "%' and Motivo LIKE '%" & strCliente & ", PARCELA%' and CodConfig = " & strCodConfig & " and Data >= '" & dtData & "' and Data <= '" & dtData.AddDays(1) & "'")

                If dt.Rows.Count > 0 Then
                    Dim strCodCaixa As String = dt.Rows.Item(0).Item("Codigo").ToString
                    Dim strMotivo As String = dt.Rows.Item(0).Item("Motivo").ToString
                    Dim vetMotivo As Array = Split(strMotivo, ",")

                    strMotivo = vetMotivo(1).ToString.Replace("PARCELA ", "")
                    If strMotivo.Contains("/") = True Then
                        vetMotivo = Split(strMotivo, "CÓD ")
                        Dim strMot1 As String = vetMotivo(0).ToString.Trim
                        Dim strmot2 As String = vetMotivo(1).ToString.Trim

                        Dim vetPar As Array = Split(strMot1, "/")
                        Dim vetPed As Array = Split(strmot2, "/")
                        strMot1 = ""
                        strmot2 = ""
                        Dim I As Integer
                        Dim bolJaPassou As Boolean = False
                        For I = 0 To vetPar.Length - 1
                            If vetPed(I) = strCodigo And vetPar(I) = strParcela Then
                                If bolJaPassou = True Then
                                    If strMot1 = "" Then
                                        strMot1 = vetPar(I)
                                        strmot2 = vetPed(I)
                                    Else
                                        strMot1 = strMot1 & "/" & vetPar(I)
                                        strmot2 = strmot2 & "/" & vetPed(I)
                                    End If
                                End If
                                bolJaPassou = True
                            Else
                                If strMot1 = "" Then
                                    strMot1 = vetPar(I)
                                    strmot2 = vetPed(I)
                                Else
                                    strMot1 = strMot1 & "/" & vetPar(I)
                                    strmot2 = strmot2 & "/" & vetPed(I)
                                End If
                            End If
                        Next

                        Dim dblValor As Double = dt.Rows.Item(0).Item("Valor").ToString

                        dblValor = dblValor - dblValPar

                        Atualizar("UPDATE Caixa set Motivo = '" & strCliente & ", PARCELA " & strMot1 & " CÓD " & strmot2 & "', " & _
                        "Valor = " & Num(dblValor) & " where Codigo = " & strCodCaixa)
                    Else

                        Excluir("Delete from Caixa where Codigo = " & strCodCaixa)

                    End If

                End If


                'ATUALIZA VALOR EM MOVIMENTO BANCARIO
                Dim dtBanco As DataTable = CarregarDataTable("SELECT Codigo, Observacao, Valor FROM MovimentoBancario where Observacao " & _
                "LIKE '%CÓD%' and Observacao like '%" & strCodigo & "%' and CodConfig = " & strCodConfig & " and Data = '" & strData & "'")

                If dtBanco.Rows.Count > 0 Then
                    Dim strCodBanco As String = dtBanco.Rows.Item(0).Item("Codigo").ToString
                    Dim strObs As String = dtBanco.Rows.Item(0).Item("Observacao").ToString
                    Dim vetObs As Array = Split(strObs, ",")


                    strObs = vetObs(1).ToString.Replace("PARCELA ", "")
                    If strObs.Contains("/") = True Then
                        vetObs = Split(strObs, "CÓD ")
                        Dim strMot1 As String = vetObs(0).ToString.Trim
                        Dim strmot2 As String = vetObs(1).ToString.Trim

                        Dim vetPar As Array = Split(strMot1, "/")
                        Dim vetPed As Array = Split(strmot2, "/")
                        strMot1 = ""
                        strmot2 = ""
                        Dim I As Integer
                        Dim bolJaPassou As Boolean = False
                        For I = 0 To vetPar.Length - 1
                            If vetPed(I) = strCodigo And vetPar(I) = strParcela Then
                                If bolJaPassou = True Then
                                    If strMot1 = "" Then
                                        strMot1 = vetPar(I)
                                        strmot2 = vetPed(I)
                                    Else
                                        strMot1 = strMot1 & "/" & vetPar(I)
                                        strmot2 = strmot2 & "/" & vetPed(I)
                                    End If
                                End If
                                bolJaPassou = True
                            Else
                                If strMot1 = "" Then
                                    strMot1 = vetPar(I)
                                    strmot2 = vetPed(I)
                                Else
                                    strMot1 = strMot1 & "/" & vetPar(I)
                                    strmot2 = strmot2 & "/" & vetPed(I)
                                End If
                            End If
                        Next

                        Dim dblValor As Double = dtBanco.Rows.Item(0).Item("Valor").ToString

                        dblValor = dblValor - dblValPar

                        Atualizar("UPDATE MovimentoBancario set Observacao = '" & strCliente & ", PARCELA " & strMot1 & " CÓD " & strmot2 & "', " & _
                        "Valor = " & Num(dblValor) & " where Codigo = " & strCodBanco)
                    Else
                        Excluir("Delete from MovimentoBancario where Codigo = " & strCodBanco)
                        'Excluir("Delete from MovimentoBancario where Observacao LIKE '%" & strObs & "%' " & _
                        '                   "and CodConfig = " & CodConfig & " and Data = '" & strData & "'")

                    End If
                End If
            End If

        End If

        If parEstornar = True Then
            Atualizar("UPDATE ContaPagar SET PagoOK = 'False' where Codigo = " & strCodigo & " and CodConfig = " & strCodConfig)

            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES (" & _
            "'" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strAntigo & "','ESTORNADO','CONTA A PAGAR','CONTA A PAGAR','ESTORNO'," & CodConfig & ")")

            'MsgBox("Conta estornada com sucesso!", MsgBoxStyle.Information)
        Else
            Excluir("Delete from ContaPagar where Codigo = " & strCodigo)

            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES (" & _
            "'" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strAntigo & "','EXCLUÍDO','CONTA A PAGAR','CONTA A PAGAR','EXCLUSÃO'," & CodConfig & ")")
            MsgBox("Parcela " & strParcela & " excluida com sucesso!", MsgBoxStyle.Information)
        End If

        'If Me.Tag = "PAGAS" Then
        '    AtualizarGrid("PagoOK = 'True'")
        'Else
        '    AtualizarGrid("PagoOK = 'False'")
        'End If
    End Sub
    Private Sub txtDias_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDias.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDias_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDias.Leave

        GerarParecelas()
    End Sub
    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub

    Private Sub cboVencimentos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVencimentos.SelectedIndexChanged
        Dim index As Integer = -999997
        grd1.FocusedColumn = Me.colVencido
        If Me.cboVencimentos.Text = "TODOS" Then
            grd1.SetRowCellValue(index, Me.colVencido, "")
        Else
            grd1.SetRowCellValue(index, Me.colVencido, Me.cboVencimentos.Text)
        End If
        grd1.FocusedColumn = Me.colFornecedor
        grd1.ShowEditor()
    End Sub

    Private Sub dtVenc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtVenc.GotFocus
        If dtVenc.Text = "" Then
            Me.dtVenc.EditValue = Date.Today
        End If
    End Sub

    Private Sub btnSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSel.Click
        Dim I As Integer
        Dim strCliPri, strCliLinha As String

        strCliPri = Me.grd1.GetRowCellValue(0, Me.colFornecedor)

        For I = 0 To Me.grd1.RowCount - 1
            strCliLinha = Me.grd1.GetRowCellValue(I, Me.colFornecedor)

            If strCliPri <> strCliLinha Then
                MsgBox("Não é possivel selecionar várias parcelas se o fornecedor for diferente!", MsgBoxStyle.Information)
                Exit Sub
            End If
        Next

        For I = 0 To Me.grd1.RowCount - 1
            Alterar(I)
        Next
    End Sub

    Private Sub btnCTPagarNF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCTPagarNF.Click
        If Me.txtFornecedor.Text <> "" Then
            ValorTotalCT = 0
            frmConCTPagarNF.strCodFor = intCodFornecedor
            frmConCTPagarNF.ShowDialog()
            Me.txtValConta.Text = ValorTotalCT.ToString("0.00")
            cboTipConta.Focus()
        End If
    End Sub
End Class