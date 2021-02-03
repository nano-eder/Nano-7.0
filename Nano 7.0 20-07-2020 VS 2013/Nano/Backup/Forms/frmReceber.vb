Imports Nano.clsImprimir
Imports Nano.clsFuncoes
Imports System.Globalization
Public Class frmReceber

    Dim I As Integer
    Dim bolAlterado As Boolean = False
    Dim intCod, intCodCliente As String
    Dim Index, intCodigo As Integer
    Dim dblLimCred As Double = 0
    Dim intTole As Integer
    Dim dblJurosConfig As Double
    Dim intJurosParcela As Integer
    Dim dblJurosParcela As Double
    Dim strCPFCliente As String

    Dim bolLoad As Boolean = False
    Dim strAuxiliar As String = ""

    Private Sub frmReceber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    If Me.Tag = "RECEBIDA" Then
                        Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "41")
                    Else
                        Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "19")
                    End If
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If   
    End Sub


    Private Sub frmReceber_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If TesteConexao() = False Then Exit Sub
        PreencherGrupoSetorCusto("C", Me.cboCenCus)
        Me.colValParcela.OptionsColumn.ReadOnly = BloquearParcelas
        Me.colVencimento.OptionsColumn.ReadOnly = BloquearParcelas

        CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja)

        Me.PagamentoTableAdapter.Fill(Me.DsNanoCommerce.Pagamento)
        'Me.colCodConfig.Visible = Master

        Me.grd1.OptionsView.ShowFooter = Master
        If ModeloCarne = "0" Then
            Me.btnGerarCarne.Visible = False
        End If
        If Me.Tag <> "RECEBIDA" Then
            Me.colValorRecebido.Visible = False
            Me.colRecebimento.Visible = False
        End If
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)

        If Me.Tag = "RECEBIDA" Then
            Me.colVencido.Visible = False
            Me.LabelControl3.Visible = False
            Me.cboVencimentos.Visible = False
            Me.cboCenCus.Visible = False
            Me.btnCenCus.Visible = False
            Me.lblCenCus.Visible = False
            AtualizarGrid("RecebidoOK = 'True'")
            grpRec.ShowCaption = False
            grpRec.Dock = DockStyle.Fill

            Me.btnAlterar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnLimpar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.bsiVisu.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.Text = "Consulta de Contas Recebidas"
            Me.btnRelCont.Caption = "&Relatório de Contas Recebidas"
            Me.lblTot.Text = "Total Recebido R$"
            Me.colValorRecebido.Visible = True
            Me.colRecebimento.Visible = True
            If Nivel = "ADMINISTRADOR" Or Nivel = "MASTER" Then
                Me.btnEstornar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

            End If

            Me.colReceber.Visible = True
            Me.colReceber.VisibleIndex = 11
        Else
            If UsaBoleto = True Then
                Me.btnBoleto.Visible = True
            End If
            Me.colCodLojaBaixa.Visible = False
            dtVenda.EditValue = Date.Today
            AtualizarGrid("RecebidoOK = 'False'")

            grd1.FormatConditions.Item(0).Value1 = Date.Today
            grd1.FormatConditions.Item(1).Value1 = Date.Today
            Me.colValorRecebido.Visible = False
            Me.colRecebimento.Visible = False

        End If


        If Nivel = "ADMINISTRADOR" Or Nivel = "MASTER" Then
            Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If

        PreencherOrdenado("Banco", Me.cboBanco, 1, "Nome")
        Me.cboBanco.Properties.Items.Add("")
        Dim dtConfig As DataTable = CarregarDataTable("SELECT JurosParcela, Juros FROM Config")
        If dtConfig.Rows.Count > 0 Then
            If dtConfig.Rows.Item(0).Item("JurosParcela").ToString <> "" Then
                intJurosParcela = dtConfig.Rows.Item(0).Item("JurosParcela").ToString
                If dtConfig.Rows.Item(0).Item("Juros").ToString <> "" Then
                    dblJurosParcela = dtConfig.Rows.Item(0).Item("Juros").ToString
                End If

            Else
                intJurosParcela = 0
                dblJurosParcela = 0
            End If
        Else
            intJurosParcela = 0
            dblJurosParcela = 0
        End If

        bolLoad = True
        Timer1.Start()

        'If NomeEmpresa.Trim.ToUpper.Contains("CHARME REPRESENTAÇÕES") = True Then
        '    colTipoCusto.VisibleIndex = 5
        '    colTipoCusto.Width = 150
        '    colTipoCusto.Caption = "Vendedor"
        '    Me.colBanco.Caption = "Empresa"
        '    Me.colComissao.Visible = True
        '    Me.colComissao.VisibleIndex = 9


        '    Me.lblCus.Visible = False

        '    Me.lblVen.Visible = True
        '    Me.lblEmp.Visible = True
        '    Me.lblCom.Visible = True
        '    Me.txtCom.Visible = True

        '    Me.lblTotCom.Visible = True
        '    Me.txtTotCom.Visible = True

        '    Me.cboTipCus.Properties.Items.Clear()

        '    PreencherCombo("Funcionario", Me.cboTipCus, 1, "Nome Asc")

        'End If
    End Sub

    Private Sub GerarJuros()

        Dim dblValConta As Double
        If intJurosParcela > 0 Then
            If Me.seParcela.Value > intJurosParcela Then
                Dim intPar As Integer = Me.seParcela.Value - intJurosParcela

                Dim dtParcela2 As Date
                Dim dtParcela1 As Date
                For I = 0 To Me.grd2.RowCount - 1
                    If Me.grd2.GetRowCellDisplayText(I, Me.colParcela) = intJurosParcela Then
                        dtParcela1 = Me.grd2.GetRowCellDisplayText(I, Me.colVencimento)
                    End If
                    If Me.grd2.GetRowCellDisplayText(I, Me.colParcela) = Me.grd2.RowCount Then
                        dtParcela2 = Me.grd2.GetRowCellDisplayText(I, Me.colVencimento)
                    End If
                Next
                Dim tsHora As TimeSpan
                Dim intDias As Integer
                tsHora = dtParcela2.Subtract(dtParcela1)
                intDias = tsHora.Days

                dblValConta = Me.txtValorConta.Text.Trim
                Dim dblResul As Double = (dblJurosParcela * dblValConta) / 100
                dblResul = (dblResul * intDias) + dblValConta
                dblValConta = dblResul
                Dim dblValPar As Double
                dblValPar = dblValConta / Me.seParcela.Value

                Dim dtDate As Date = Me.dtVenc.DateTime

                For I = 0 To Me.seParcela.Value - 1
                    grd2.SetRowCellValue(I, Me.colValParcela, dblValPar.ToString("0.00"))
                Next
            End If

        End If

    End Sub

    Private Sub GerarParecelas()

        If bolAlterado = True Then Exit Sub
        If Me.txtValorConta.Text.Trim = "" Then Exit Sub
        If Validar(Me.dtVenc) = False Then Exit Sub
        If Me.txtDias.Text = "" Then
            Me.txtDias.Text = "30"
        End If
        Dim I As Integer
        Dim dblValConta, dblValPar As Double
        dblValConta = Me.txtValorConta.Text.Trim
        ''''''''''
     
        ''''''''''''
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
        

        GerarJuros()
    End Sub

    Private Sub AtualizarGrid(ByVal strFiltro As String)

        Dim strFilt As String = ""
        If Master = False Then
            strFilt = " and ContaReceber.CodConfig =" & CodConfig
        End If
        If NomeEmpresa.Contains("CASTELO KIDS") = True Then
            strFilt = ""
        End If
        If NomeEmpresa.Replace("Á", "A").Contains("TAUA") = True Then
            strFilt = ""
        End If

        Dim dtData As Date = Date.Today
        Dim strData As String = dtData.ToString("dd/MM/yyyy")

        'CarregarDados("Select ContaReceber.Codigo, CodOrdem, convert(SmallDateTime, DataVenda) as DataVenda, ContaReceber.Obs as Servico, FormaPagamento, " & _
        '"Parcelas, Convert(Numeric(15,2), ValorParcela) as ValorParcela, Convert(Numeric(15,2), ValorVenda) as ValorVenda, " & _
        '"Convert(Numeric(15,2), ValorRecebido) as ValorRecebido, Recebimento, RecebidoOK, Pagamento, NumeroDocumento, " & _
        '"TipoCusto, ContaReceber.Banco, CodCli, Vencimento , Cliente.Nome, Cliente.CPF, Cliente.Cidade, ContaReceber.CodConfig , CodLojaBaixa, Comissao, " & _
        '"Cliente.Fantasia, case when datediff (month,vencimento,getdate()) >= 60 then 'CADUCADOS' else case when DATEDIFF (day,vencimento,getdate())>0 then 'ATRASADOS' " & _
        '"when DATEDIFF (day,vencimento,getdate())=0 then 'HOJE' else 'EM DIA' end end as Vencido, " & _
        '"case when Cliente.Nome like '%PROTESTADO%' then 'PROTESTADO' else '' end as Protestado, CentroCusto from ContaReceber Inner Join Cliente on ContaReceber.CodCli = Cliente.Codigo where " & strFiltro & strFilt, Me.Grid1)

        'CarregarDados("SET DATEFORMAT dmy Select ContaReceber.Codigo, ContaReceber.CodOrdem, convert(SmallDateTime, DataVenda) as DataVenda, " & _
        '"ContaReceber.Obs as Servico, FormaPagamento, Parcelas, Convert(Numeric(15,2), ValorParcela) as ValorParcela, Convert(Numeric(15,2), " & _
        '"ValorVenda) as ValorVenda, Convert(Numeric(15,2), ValorRecebido) as ValorRecebido, Recebimento, RecebidoOK, Pagamento, NumeroDocumento, " & _
        '"TipoCusto, ContaReceber.Banco, ContaReceber.CodCli, Vencimento, Cliente.Nome, Cliente.CPF, Cliente.Cidade, ContaReceber.CodConfig, " & _
        '"CodLojaBaixa, Comissao, Cliente.Fantasia, case when datediff (month,vencimento,getdate()) >= 60 then 'CADUCADOS' else case " & _
        '"when DATEDIFF (day,vencimento,getdate())>0 then 'ATRASADOS' when DATEDIFF (day,vencimento,getdate())=0 then 'HOJE' else 'EM DIA' " & _
        '"end end as Vencido, case when Cliente.Nome like '%PROTESTADO%' then 'PROTESTADO' else '' end as Protestado, CentroCusto, CodPedido, Convert(bit, 'False') as Receber " & _
        '"from (ContaReceber Inner Join Cliente on ContaReceber.CodCli = Cliente.Codigo) left join Total on ContaReceber.CodOrdem = Total.CodOrdem " & _
        '"And Total.CodConfig = ContaReceber.CodConfig where " & strFiltro & strFilt, Me.Grid1)

        CarregarDados("SET DATEFORMAT dmy Select ContaReceber.Codigo, ContaReceber.CodOrdem, convert(SmallDateTime, DataVenda) as DataVenda, " & _
       "ContaReceber.Obs as Servico, FormaPagamento, Parcelas, Convert(Numeric(15,2), ValorParcela) as ValorParcela, Convert(Numeric(15,2), " & _
       "ValorVenda) as ValorVenda, Convert(Numeric(15,2), ValorRecebido) as ValorRecebido, Recebimento, RecebidoOK, Pagamento, NumeroDocumento, " & _
       "TipoCusto, ContaReceber.Banco, ContaReceber.CodCli, Vencimento, Cliente.Nome, Cliente.CPF, Cliente.Cidade, ContaReceber.CodConfig, " & _
       "CodLojaBaixa, Comissao, Cliente.Fantasia, case when datediff (month,vencimento,getdate()) >= 60 then 'CADUCADOS' else case " & _
       "when DATEDIFF (day,vencimento,getdate())>0 then 'ATRASADOS' when DATEDIFF (day,vencimento,getdate())=0 then 'HOJE' else 'EM DIA' " & _
       "end end as Vencido, case when Cliente.Nome like '%PROTESTADO%' then 'PROTESTADO' else '' end as Protestado, CentroCusto, case when ContaReceber.CodigoPedido = '' then Total.CodPedido end as CodPedido, " & _
       "Convert(bit, 'False') as Receber, case when DATEDIFF(DAY, Convert(smalldatetime, Vencimento), Convert(smalldatetime, '" & strData & "')) > 0 Then " & _
       "Convert(Numeric(15,2), ValorParcela + ((ValorParcela * (Select Juros From Config Where Codigo=" & CodConfig & ")) / 100) * DATEDIFF(DAY, Convert(smalldatetime, " & _
       "Vencimento), Convert(smalldatetime, '" & strData & "'))) else ValorParcela End As Juros " & _
       "from (ContaReceber Inner Join Cliente on ContaReceber.CodCli = Cliente.Codigo) left join Total on ContaReceber.CodOrdem = Total.CodOrdem " & _
       "And Total.CodConfig = ContaReceber.CodConfig where " & strFiltro & strFilt, Me.Grid1)


    End Sub
    Private Sub Limpar()
        Me.dtRecib.Enabled = True
        Me.cboVencimentos.SelectedIndex = 0
        Me.txtDesc.ResetText()
        Me.cboTipCus.SelectedIndex = -1
        Me.txtValTotRec.ResetText()
        Me.txtValorConta.ResetText()
        Me.dtRecib.ResetText()
        Me.dtVenda.EditValue = Date.Today
        Me.dtVenc.ResetText()
        Me.tdCred.Rows.Clear()
        Me.seParcela.Value = 0
        Me.rdgFim.SelectedIndex = -1
        Me.rdgFim.Enabled = True
        Me.txtCliente.ResetText()
        Me.txtCliente.Focus()
        bolAlterado = False
        Me.txtCodPed.ResetText()
        Me.seParcela.Enabled = True
        Me.txtCodPed.Enabled = True
        Me.luePag.EditValue = DBNull.Value
        Me.cboBanco.SelectedIndex = -1
        Me.rdgFim.Visible = False
        Me.lblFinali.Visible = False
        Me.seParcela.Visible = True
        Me.lblNumPar.Visible = True
        Me.lblVenc.Visible = True
        Me.dtVenc.Visible = True
        dblLimCred = 0

        Me.txtTotal.ResetText()
        Me.txtComJuros.ResetText()
        Me.txtTroco.ResetText()

        Me.gridPar.Visible = True

        Me.lblRecebi.Visible = False
        Me.dtRecib.Visible = False
        Me.rdgFim.Visible = False
        Me.lblFinali.Visible = False
        Me.seParcela.Visible = True
        Me.lblNumPar.Visible = True
        Me.lblVenc.Visible = True
        Me.dtVenc.Visible = True
        Me.txtCom.ResetText()
        Me.cboCenCus.SelectedIndex = -1
        Me.txtCodPed.Focus()

    End Sub

    Private Sub Alterar(Optional ByVal parIndex As String = "")

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

        With grd1

            intCodigo = .GetRowCellDisplayText(Index, Me.colCodigo)
            Me.txtCodPed.Text = .GetRowCellValue(Index, Me.colCodOrdem)
            Me.txtCliente.Text = .GetRowCellDisplayText(Index, Me.colCliente)
            strCPFCliente = .GetRowCellDisplayText(Index, Me.colCPF)
            intCodCliente = .GetRowCellDisplayText(Index, Me.colCodCli)

            Dim dtCli As DataTable = CarregarDataTable("Select Limite from Cliente Where Codigo =" & intCodCliente)

            If dtCli.Rows.Count > 0 Then
                If dtCli.Rows.Item(0).Item("Limite").ToString.Trim <> "" Then
                    dblLimCred = dtCli.Rows.Item(0).Item("Limite").ToString.Trim
                Else
                    dblLimCred = -1
                End If
            End If
            Me.luePag.Text = .GetRowCellDisplayText(Index, Me.colFormaPagamento)
            Me.luePag.ClosePopup()
            Me.dtVenda.Text = .GetRowCellDisplayText(Index, Me.colDataVenda)
            Me.txtValorConta.Text = .GetRowCellDisplayText(Index, Me.colValor).Replace("R$ ", "").Replace(".", "")
            Me.seParcela.Enabled = False

            Dim vetPar As Array = Split(.GetRowCellDisplayText(Index, Me.colParcelas), "/")

            Me.seParcela.Value = vetPar(0)
            Me.cboCenCus.Text = .GetRowCellDisplayText(Index, Me.colCentroCusto)
            Dim dtConfig As DataTable = CarregarDataTable("SELECT Tolerancia, Juros FROM Config")
            If dtConfig.Rows.Item(0).Item("Tolerancia").ToString <> "" Then

                intTole = dtConfig.Rows.Item(0).Item("Tolerancia").ToString

            End If

            If dtConfig.Rows.Item(0).Item("Juros").ToString <> "" Then
                dblJurosConfig = dtConfig.Rows.Item(0).Item("Juros").ToString
            End If


            Dim dtVencimento, dtTole As Date
            dtVencimento = .GetRowCellDisplayText(Index, Me.colVencimento1)
            dtTole = dtVencimento.AddDays(intTole)
            Dim tsHora As TimeSpan
            Dim intDias As Integer
            tsHora = Now.Subtract(dtTole)
            intDias = tsHora.Days
            Dim dblJuros As Double
            If intDias <= 0 Then
                dblJuros = .GetRowCellDisplayText(Index, Me.colValorParcela)
            Else

                dtVencimento = .GetRowCellDisplayText(Index, Me.colVencimento1)
                tsHora = Now.Subtract(dtVencimento)
                intDias = tsHora.Days

                Dim dblResul As Double = (dblJurosConfig * .GetRowCellDisplayText(Index, Me.colValorParcela)) / 100
                dblJuros = (dblResul * intDias) + .GetRowCellDisplayText(Index, Me.colValorParcela)
            End If

            If Me.grd2.RowCount > 0 Then
                If Me.grd2.GetRowCellValue(0, Me.colCodCliente) <> intCodCliente Then
                    Me.tdCred.Rows.Clear()
                End If
            End If

            Me.tdCred.Rows.Add()
            Dim IndexCred As Integer = Me.tdCred.Rows.Count - 1
            Me.tdCred.Rows.Item(IndexCred).Item("Parcela") = vetPar(0)
            Me.tdCred.Rows.Item(IndexCred).Item("Vencimento") = .GetRowCellDisplayText(Index, Me.colVencimento1)
            Me.tdCred.Rows.Item(IndexCred).Item("Valor") = .GetRowCellDisplayText(Index, Me.colValorParcela).Replace("R$ ", "").Replace(".", "")
            Me.tdCred.Rows.Item(IndexCred).Item("Documento") = .GetRowCellDisplayText(Index, Me.colNumeroDocumento)
            Me.tdCred.Rows.Item(IndexCred).Item("Juros") = dblJuros.ToString("0.00")
            Me.tdCred.Rows.Item(IndexCred).Item("CodCliente") = .GetRowCellDisplayText(Index, Me.colCodCli)
            Me.tdCred.Rows.Item(IndexCred).Item("CodigoParcela") = intCodigo
            Me.tdCred.Rows.Item(IndexCred).Item("CodPed") = .GetRowCellValue(Index, Me.colCodOrdem)
            Me.tdCred.Rows.Item(IndexCred).Item("ParcelaImp") = .GetRowCellDisplayText(Index, Me.colParcelas)
            Me.tdCred.Rows.Item(IndexCred).Item("Pagamento") = .GetRowCellDisplayText(Index, Me.colFormaPagamento)

            CalcularJuros()

            Me.dtVenc.Text = .GetRowCellDisplayText(Index, Me.colVencimento1)
            Me.txtValTotRec.Text = .GetRowCellDisplayText(Index, Me.colValorRecebido)
            Me.txtValTotRec.Tag = .GetRowCellDisplayText(Index, Me.colValorRecebido)
            Me.dtRecib.EditValue = Date.Today
            Me.cboTipCus.Text = .GetRowCellDisplayText(Index, Me.colTipoCusto)
            Me.cboBanco.Text = .GetRowCellDisplayText(Index, Me.colBanco)
            Me.txtDesc.Text = .GetRowCellDisplayText(Index, Me.colServico)
            Me.txtCom.Text = .GetRowCellDisplayText(Index, Me.colComissao)
            Me.txtCodPed.Enabled = False

            Me.lblRecebi.Visible = True
            Me.dtRecib.Visible = True
            Me.rdgFim.Visible = True
            Me.lblFinali.Visible = True
            Me.seParcela.Visible = False
            Me.lblNumPar.Visible = False
            Me.lblVenc.Visible = False
            Me.dtVenc.Visible = False



            Me.txtValTotRec.Text = Me.txtComJuros.Text.Trim

            Me.rdgFim.SelectedIndex = -1

            If NomeEmpresa.Contains("TAUÁ") = True Then
                Me.luePag.Text = "RECBTO CREDIÁRIO"
                Me.luePag.ClosePopup()
                rdgFim.SelectedIndex = 0
                Me.rdgFim.Visible = False
                Me.lblFinali.Visible = False
            End If


            If CNPJEmpresa = "06312954000116" Then
                Me.dtRecib.Enabled = False
            Else
                Me.dtRecib.Enabled = True
            End If
            Me.txtValTotRec.Focus()

        End With
    End Sub
    Private Sub CalcularJuros()
        Dim I As Integer
        Dim dblResulTotal, dblResulTotalJuros As Double
        Dim dblTotal, dblTotalJuros As Double
        For I = 0 To Me.grd2.RowCount - 1
            If Me.grd2.GetRowCellDisplayText(I, Me.colValParcela) <> "" Then
                dblTotal += Me.grd2.GetRowCellDisplayText(I, Me.colValParcela)
            End If
            If Me.grd2.GetRowCellDisplayText(I, Me.colJuros) <> "" Then
                dblTotalJuros += Me.grd2.GetRowCellDisplayText(I, Me.colJuros)
            End If
        Next
        dblResulTotal = dblTotal
        dblResulTotalJuros = dblTotalJuros
        Me.txtTotal.Text = dblResulTotal.ToString("0.00")
        Me.txtComJuros.Text = dblResulTotalJuros.ToString("0.00")
    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If MsgBox("Deseja realmente limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Limpar()
        End If
    End Sub

    Private Sub ExcluirFuturo(ByVal parCodigo As String)
        If parCodigo <> "" Then
            Excluir("Delete from Futuro where Auxiliar='" & parCodigo & "'")
        End If
    End Sub

    Private Sub InserirFuturo(ByVal parCodPed As String)
        If Me.luePag.GetColumnValue("Prazo") = True Then

            Dim intDias, I As Integer
            Dim dblTot, dblDes, dblTotDes, dblResul As Double


            intDias = Me.luePag.GetColumnValue("Dias")
            Dim dtData As Date = Date.Today
            NumTransacao = ""

            Dim strInsert As String = ""
            Dim vet As String() = Nothing

            If parCodPed.Contains("/") = True Then

                Dim dblValor As Double = Me.txtValTotRec.Text.Trim / CInt(Me.grd2.RowCount)

                dblDes = Me.luePag.GetColumnValue("Desconto")
                dblTotDes = (dblValor / 100) * dblDes
                dblResul = dblValor - dblTotDes

                For I = 0 To Me.grd2.RowCount - 1
                    Dim Codigo As String = Me.grd2.GetRowCellDisplayText(I, Me.colCodigoParcela)
                    Dim CodPed As String = Me.grd2.GetRowCellDisplayText(I, Me.colCodPed)
                    Dim CodConfigFuturo As String = Me.grd2.GetRowCellDisplayText(I, Me.colCodConfig)

                    dtData = dtData.AddDays(intDias)

                    strInsert = strInsert & vbCrLf & vbCrLf & "Insert into Futuro (Data, CodOrdem, Pagamento, Total, TotalDesconto, CodConfig, Recebido, CodigoPedido, Auxiliar, " & _
                    "Bandeira, NumTransacao) Values('" & dtData & "'," & CodPed & ",'" & Me.luePag.Text & "'," & Num(dblValor) & "," & _
                    "" & Num(dblResul) & "," & CodConfig & ",'False','','" & Codigo & "',''," & _
                    "'" & NumTransacao & "');"
                Next

                Inserir(strInsert)
            Else
                Dim Codigo As String = Me.grd2.GetRowCellDisplayText(0, Me.colCodigoParcela)

                dblTot = Me.txtValTotRec.Text.Trim / Val(1)
                dblDes = Me.luePag.GetColumnValue("Desconto")
                

                dblTotDes = (dblTot / 100) * dblDes
                dblResul = dblTot - dblTotDes


                dtData = dtData.AddDays(intDias)

                strInsert = "Insert into Futuro (Data, CodOrdem, Pagamento, Total, TotalDesconto, CodConfig, Recebido, CodigoPedido, Auxiliar, " & _
                "Bandeira, NumTransacao) Values('" & dtData & "'," & parCodPed & ",'" & Me.luePag.Text & "'," & Num(dblTot) & "," & _
                "" & Num(dblResul) & "," & CodConfig & ",'False','','" & Codigo & "',''," & _
                "'" & NumTransacao & "')"

                Inserir(strInsert)
            End If

        End If
    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick

        If TesteConexao() = False Then Exit Sub

        'Try
        '    strAuxiliar = NomeComputador.ToUpper & " " & Format(My.Computer.Clock.LocalTime, "dd/MM/yyyy HH:mm:ss:fffff")
        'Catch ex As Exception
        '    strAuxiliar = NomeComputador.ToUpper & " " & Date.Today.Day & "/" & Date.Today.Month & "/" & Date.Today.Year & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now)
        'End Try

        Me.txtCliente.Focus()
        If Validar(Me.txtCodPed) = False Then Exit Sub
        If Validar(Me.txtCliente) = False Then Exit Sub
        If Validar(Me.dtVenda) = False Then Exit Sub
        If Validar(Me.txtValorConta) = False Then Exit Sub
        If Validar(Me.luePag) = False Then Exit Sub
        If Me.seParcela.Value = 0 Then MsgBox("Número de Nº Parcelas é obrigatório!", MsgBoxStyle.Information) : Exit Sub
        If Validar(Me.dtVenc) = False Then Exit Sub

        Dim strDate, strValPar, strNumDoc As String
        Dim intCodAutPar As Integer

        If NomeEmpresa.Contains("TAUÁ") = True Or NomeEmpresa.Contains("CONSTRUNEI") = True Or NomeEmpresa.ToUpper.Contains("CONSTRULAR") = True Then
            If bolAlterado = True Then
                If CDbl(Me.txtTotal.Text.Trim) > CDbl(Me.txtValTotRec.Text.Trim) Then
                    If NomeEmpresa.Contains("CONSTRUNEI") = True Or NomeEmpresa.ToUpper.Contains("CONSTRULAR") = True Then
                        If Me.rdgFim.SelectedIndex = 0 Then
                            MsgBox("Valor recebido é inferior ao valor da(s) parcela(s)!", MsgBoxStyle.Information)
                            Exit Sub
                        End If
                    Else
                        MsgBox("Valor recebido é inferior ao valor da(s) parcela(s)!", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                End If
            End If
        End If

        If NomeEmpresa.Trim.ToUpper.Contains("CHARME REPRESENTAÇÕES") = True Then
            Me.cboTipCus.Tag = "Vendedor"
            If Validar(Me.cboTipCus) = False Then Exit Sub
            Me.cboBanco.Tag = "Empresa"
            If Validar(Me.cboBanco) = False Then Exit Sub
            If Validar(Me.txtCom) = False Then Exit Sub
        End If

        If bolAlterado = False Then

            Dim dblComissao As Double = 0

            If Me.txtCom.Text.Trim <> "" Then
                dblComissao = Me.txtCom.Text.Trim
            End If
            Dim bolBoleto As Boolean = False
            For I = 0 To grd2.RowCount - 1

                strDate = grd2.GetRowCellDisplayText(I, Me.colVencimento)
                strValPar = grd2.GetRowCellDisplayText(I, Me.colValParcela)
                strNumDoc = grd2.GetRowCellDisplayText(I, Me.colDocumento)
                If Me.luePag.Text.Contains("BOLETO") = True Then
                    bolBoleto = True
                End If
                Inserir("INSERT INTO ContaReceber (CodOrdem, DataVenda, CodCli, Obs, FormaPagamento, Parcelas, " & _
                "ValorParcela, Vencimento, ValorVenda, ValorRecebido, RecebidoOK, Pagamento, NumeroDocumento, " & _
                "TipoCusto, Banco, CodConfig, Comissao, CodigoPedido, CentroCusto) VALUES (" & _
                "" & Me.txtCodPed.Text.Trim & ",'" & Me.dtVenda.Text.Trim & "'," & intCodCliente & "," & _
                "'" & Me.txtDesc.Text.Trim & "','" & Me.luePag.GetColumnValue("FormaPagamento").ToString.Trim & "'," & _
                "'" & I + 1 & "/" & Me.seParcela.Text.Trim & "'," & Num(strValPar) & ",'" & strDate & "'," & _
                "" & Num(Me.txtValorConta.Text.Trim) & "," & Num(Me.txtValTotRec.Text.Trim) & ",'" & False & "'," & _
                "'" & Me.luePag.Text.Trim & "','" & strNumDoc & "','" & Me.cboTipCus.Text.Trim & "'," & _
                "'" & Me.cboBanco.Text.Trim & "'," & CodConfig & "," & Num(dblComissao) & ",'','" & Me.cboCenCus.Text & "')")
            Next
            If UsaBoleto = True Then
                If bolBoleto = True Then


                    Dim strCodCli As String = intCodCliente
                    Dim strParcelas As String = Me.seParcela.Text
                    Dim strValorTotal As String = Me.txtTotal.Text


                    If MsgBox("Deseja imprimir o boleto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        If CobreBemNano = True Then
                            Dim strCodigoContaReceber As String = ""
                            Dim dt As DataTable = CarregarDataTable("SELECT Codigo, Pagamento FROM ContaReceber where CodOrdem = '" & Me.txtCodPed.Text.Trim & "' and " & _
                                                    "CodCli = " & intCodCliente & " and CodConfig = " & CodConfig)

                            For I = 0 To dt.Rows.Count - 1

                                Dim strBoleto As String = dt.Rows.Item(I).Item("Pagamento").ToString
                                If strBoleto.Contains("BOL") = False Then
                                    MsgBox("Forma de pagamento diferente de boleto!", MsgBoxStyle.Information)
                                    strCodigoContaReceber = ""
                                    Exit Sub
                                End If
                                If I = 0 Then
                                    strCodigoContaReceber = dt.Rows.Item(I).Item("Codigo").ToString
                                Else
                                    strCodigoContaReceber &= "," & dt.Rows.Item(I).Item("Codigo").ToString
                                End If
                            Next
                            If strCodigoContaReceber <> "" Then
                                BoletoCobreBem.CobreBem(strCodigoContaReceber, False)
                            End If
                        Else
                            '4244|CLIENTE|406|2|100,00
                            Dim fluxoTexto As IO.StreamWriter
                            If Not System.IO.File.Exists(CaminhoPastaBoleto & "\Boleto\" & Me.txtCodPed.Text & ".txt") Then
                                System.IO.File.Create(CaminhoPastaBoleto & "\Boleto\" & Me.txtCodPed.Text & ".txt").Dispose()

                                fluxoTexto = New IO.StreamWriter(CaminhoPastaBoleto & "\Boleto\" & Me.txtCodPed.Text & ".txt")



                                Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM ContaReceber where CodOrdem = " & Me.txtCodPed.Text.Trim & " and " & _
                                                       "CodCli = " & intCodCliente & " and CodConfig = " & CodConfig)


                                Dim strCodigos As String = ""
                                For I = 0 To dt.Rows.Count - 1
                                    If I = 0 Then
                                        strCodigos = dt.Rows.Item(I).Item("Codigo").ToString
                                    Else
                                        strCodigos &= "," & dt.Rows.Item(I).Item("Codigo").ToString
                                    End If
                                Next


                                fluxoTexto.Write("")
                                fluxoTexto.Write(strCodigos & "|CLIENTE|" & strCodCli & "|" & strParcelas & "|" & strValorTotal & "|RECEBER CADASTRO|DETALHADO")
                                fluxoTexto.Close()
                            End If
                            Dim strLogin As String = LerArquivo(CaminhoPastaBoleto & "\Arquivos\Login.txt", True)

                            fluxoTexto = New IO.StreamWriter(CaminhoPastaBoleto & "\Arquivos\Login.txt")

                            fluxoTexto.Write("")
                            fluxoTexto.Write(Login & "|" & Senha & "|000")
                            fluxoTexto.Close()
                            System.Diagnostics.Process.Start(CaminhoPastaBoleto & "\Debug\NanoBoleto.exe")
                        End If

                    End If

                End If
            End If

            MsgBox("Conta cadastrada com sucesso!", MsgBoxStyle.Information)
        Else

            If Me.rdgFim.SelectedIndex <> -1 And Me.txtValTotRec.Text.Trim = "" Then MsgBox("Informe o valor Recebido!", MsgBoxStyle.Information) : Me.txtValTotRec.Focus() : Exit Sub
            If Me.rdgFim.SelectedIndex <> -1 And Me.dtRecib.Text.Trim = "" Then MsgBox("Informe a data do recebimento!", MsgBoxStyle.Information) : Me.dtRecib.Focus() : Exit Sub
            If Me.rdgFim.SelectedIndex = -1 And Me.grd2.RowCount > 1 Then MsgBox("Não é possível alterar mais de uma parcela por vez!" & vbCrLf & "Se o que deseja é dar baixa nas parcelas, selecione uma das opções: 'Total' ou 'Parcial'.", MsgBoxStyle.Information) : Exit Sub

            Dim dtReceb As Date
            Dim bolRecebOK As Boolean
            If Me.rdgFim.SelectedIndex = -1 Then
                dtReceb = Date.Today
                bolRecebOK = False
            Else
                dtReceb = Me.dtRecib.Text.Trim
                bolRecebOK = True
            End If


            If Me.rdgFim.SelectedIndex = -1 Then

                intCodAutPar = Me.grd2.GetRowCellDisplayText(0, Me.colCodigoParcela)

                If intCodAutPar = 0 Then
                    MsgBox("Ocorreu alguma falha ao baixar a parcela, tente novamente!", MsgBoxStyle.Information)
                    Exit Sub
                End If

                Dim dblComissao As Double = 0

                If Me.txtCom.Text.Trim <> "" Then
                    dblComissao = Me.txtCom.Text.Trim
                End If

                For I = 0 To grd2.RowCount - 1
                    Atualizar("UPDATE ContaReceber SET DataVenda = '" & Me.dtVenda.Text.Trim & "', CodCli = " & intCodCliente & ", " & _
                    "Obs = '" & Me.txtDesc.Text.Trim & "', FormaPagamento = '" & Me.luePag.GetColumnValue("FormaPagamento").ToString.Trim & "', " & _
                    "ValorParcela = " & Num(Me.grd2.GetRowCellDisplayText(I, Me.colValParcela)) & ", " & _
                    "Vencimento = '" & Me.grd2.GetRowCellDisplayText(I, Me.colVencimento) & "', " & _
                    "ValorVenda = " & Num(Me.txtValorConta.Text.Trim) & ", ValorRecebido = " & Num(0) & ", " & _
                    "Recebimento = '" & dtReceb & "', RecebidoOK = '" & bolRecebOK & "', " & _
                    "Pagamento = '" & Me.luePag.Text & "', " & _
                    "NumeroDocumento = '" & Me.grd2.GetRowCellDisplayText(I, Me.colDocumento) & "', " & _
                    "TipoCusto = '" & Me.cboTipCus.Text.Trim & "', Banco = '" & Me.cboBanco.Text.Trim & "', " & _
                    "Comissao =" & Num(dblComissao) & ", CentroCusto = '" & Me.cboCenCus.Text & "' where Codigo = " & intCodAutPar)

                    Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                    "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & "," & _
                    "'Nº Venda " & Me.txtCodPed.Text & " Par. " & Me.grd2.GetRowCellDisplayText(I, Me.colParcela) & " Cód Loja " & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodConfig) & "','Valor " & Me.grd2.GetRowCellDisplayText(I, Me.colValParcela) & " Vencimento " & Me.grd2.GetRowCellDisplayText(I, Me.colVencimento) & " Não Recebido'," & _
                    "'ALTERAÇÃO','CONTA RECEBER','ALTERAÇÃO'," & CodConfig & ")")
                Next

                MsgBox("Conta Alterada com sucesso!", MsgBoxStyle.Information)


            ElseIf Me.rdgFim.SelectedIndex = 0 Then
                Dim strCodPed As String = ""
                Dim strParcela As String = ""


                If AbrirFecharCaixa = True Then
                    If VerificarCaixa("") = False Then Exit Sub
                End If

                If Me.grd2.RowCount = 1 Then

                    intCodAutPar = Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colCodigoParcela)

                    If intCodAutPar = 0 Then
                        MsgBox("Ocorreu alguma falha ao baixar a parcela, tente novamente!", MsgBoxStyle.Information)
                        Exit Sub
                    End If

                    Dim dblValRecebido As Double = Me.txtValTotRec.Text.Trim


                    If Me.txtTroco.Text.Trim <> "" Then
                        If CDbl(Me.txtTroco.Text.Trim) > 0 Then
                            dblValRecebido = dblValRecebido - CDbl(Me.txtTroco.Text.Trim)
                        End If
                    End If


                    If Atualizar("UPDATE ContaReceber SET DataVenda = '" & Me.dtVenda.Text.Trim & "', " & _
                     "CodCli = " & intCodCliente & ", Obs = '" & Me.txtDesc.Text.Trim & "', " & _
                     "FormaPagamento = '" & Me.luePag.GetColumnValue("FormaPagamento").ToString.Trim & "', " & _
                     "ValorParcela = " & Num(Me.grd2.GetRowCellDisplayText(0, Me.colValParcela)) & ", " & _
                     "Vencimento = '" & Me.grd2.GetRowCellDisplayText(0, Me.colVencimento) & "', " & _
                     "ValorVenda = " & Num(Me.txtValorConta.Text.Trim) & ", ValorRecebido = " & Num(dblValRecebido) & ", " & _
                     "Recebimento = '" & dtReceb & "', RecebidoOK = '" & bolRecebOK & "', Pagamento = '" & Me.luePag.Text & "', " & _
                     "NumeroDocumento = '" & Me.grd2.GetRowCellDisplayText(0, Me.colDocumento) & "', " & _
                     "TipoCusto = '" & Me.cboTipCus.Text.Trim & "', Banco = '" & Me.cboBanco.Text.Trim & "', " & _
                     "CodLojaBaixa = " & CodConfig & ", CentroCusto = '" & Me.cboCenCus.Text & "' where Codigo = " & intCodAutPar) = True Then

                        Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                        "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & "," & _
                        "'Nº Venda " & Me.txtCodPed.Text & " Par. " & Me.grd2.GetRowCellDisplayText(I, Me.colParcela) & " Cód. Loja " & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodConfig) & "','Data Rec. " & dtReceb & " Valor Rec. " & Me.txtValTotRec.Text.Trim & "'," & _
                        "'RECEBIMENTO','CONTA RECEBER','ALTERAÇÃO'," & CodConfig & ")")
                    Else
                        Exit Sub
                    End If

                    Atualizar("Update ContaReceber set RecebidoOK ='True' where Codigo = " & intCodAutPar)

                    strCodPed = Me.txtCodPed.Text
                    strParcela = Me.seParcela.Text


                Else
                    Dim bolDiferenca As Boolean = False
                    Dim dblValResul As Double
                    If CDbl(Me.txtValTotRec.Text) < CDbl(Me.txtComJuros.Text) Then

                        dblValResul = Me.txtComJuros.Text - Me.txtValTotRec.Text
                        bolDiferenca = True
                    End If

                    Dim I As Integer
                    Dim bolJaPassou As Boolean = False

                    Dim strQuery As String = ""
                    For I = 0 To Me.grd2.RowCount - 1
                        Dim dblValorRecebido As Double
                        If bolDiferenca = True Then
                            dblValorRecebido = Me.grd2.GetRowCellDisplayText(I, Me.colJuros) - dblValResul
                            If dblValorRecebido < 0 Then
                                dblValorRecebido = Me.grd2.GetRowCellDisplayText(I, Me.colJuros)
                            Else
                                bolDiferenca = False
                            End If
                        Else
                            dblValorRecebido = Me.grd2.GetRowCellDisplayText(I, Me.colJuros)
                        End If

                        intCodAutPar = Me.grd2.GetRowCellDisplayText(I, Me.colCodigoParcela)

                        If intCodAutPar = 0 Then
                            MsgBox("Ocorreu alguma falha ao baixar a parcela, tente novamente!", MsgBoxStyle.Information)
                            Exit Sub
                        End If

                        Dim dblValRecebido As Double = dblValorRecebido
                        'If Me.txtTroco.Text.Trim <> "" Then
                        '       If CDbl(Me.txtTroco.Text.Trim) > 0 Then
                        '           dblValRecebido = dblValRecebido - CDbl(Me.txtTroco.Text.Trim)
                        '       End If
                        '   End If


                        strQuery &= "UPDATE ContaReceber SET FormaPagamento = '" & Me.luePag.GetColumnValue("FormaPagamento").ToString.Trim & "', " & _
                          "ValorRecebido = " & Num(dblValRecebido) & ", Recebimento = '" & dtReceb & "', RecebidoOK = '" & bolRecebOK & "', " & _
                          "Pagamento = '" & Me.luePag.Text & "', NumeroDocumento = '" & Me.grd2.GetRowCellDisplayText(I, Me.colDocumento) & "', " & _
                          "Banco = '" & Me.cboBanco.Text.Trim & "', CodLojaBaixa = " & CodConfig & ", CentroCusto = '" & Me.cboCenCus.Text & "' where Codigo = " & intCodAutPar & vbCrLf & vbCrLf

                        If bolJaPassou = False Then
                            strCodPed = Me.grd2.GetRowCellValue(I, Me.colCodPed)
                            strParcela = Me.grd2.GetRowCellValue(I, Me.colParcela)
                            bolJaPassou = True
                        Else
                            strCodPed += "/" & Me.grd2.GetRowCellValue(I, Me.colCodPed)
                            strParcela += "/" & Me.grd2.GetRowCellValue(I, Me.colParcela)
                        End If
                        Dim intCodConf As Integer = CodConfig
                        Dim dtConfig As DataTable = CarregarDataTable("SELECT CodConfig FROM ContaReceber where Codigo = " & intCodAutPar)
                        If dtConfig.Rows.Count > 0 Then
                            intCodConf = dtConfig.Rows.Item(0).Item("CodConfig").ToString
                        End If
                        strQuery &= "INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                        "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & "," & _
                        "'Nº Venda " & Me.grd2.GetRowCellValue(I, Me.colCodPed) & " Par. " & Me.grd2.GetRowCellDisplayText(I, Me.colParcela) & " Cód. Loja " & intCodConf & "','Data Rec. " & dtReceb & " Valor Rec. " & dblValorRecebido & "'," & _
                        "'RECEBIMENTO','CONTA RECEBER','ALTERAÇÃO'," & CodConfig & ")" & vbCrLf & vbCrLf


                        strQuery &= "Update ContaReceber set RecebidoOK ='True' where Codigo = " & intCodAutPar & vbCrLf & vbCrLf
                    Next

                    If Atualizar(strQuery) = False Then
                        Exit Sub
                    End If

                End If

                IrCaixa(strCodPed, strParcela, Me.txtValTotRec.Text)
                InserirFuturo(strCodPed)

                If dblLimCred <> -1 Then
                    dblLimCred = dblLimCred + CDbl(txtValTotRec.Text.Trim)
                    Atualizar("Update Cliente set Limite ='" & dblLimCred.ToString("0.00") & "' where Codigo =" & intCodCliente)
                End If

                MsgBox("Conta Finalizada com sucesso!", MsgBoxStyle.Information)


                If NomeEmpresa.Trim.ToUpper.Contains("CHARME") = False Then
                    If ImprimirDireto = False Then
                        If MsgBox("Deseja imprimir o recibo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            Recibo(strCodPed, strParcela)

                            If TemImpressora = True Then
                                If SegViaRecibo = True Then
                                    If MsgBox("Deseja imprimir a 2ª via do recibo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                        Recibo(Me.txtCodPed.Text.Trim, "P/" & Me.seParcela.Text.Trim)
                                    End If
                                End If
                            End If
                        End If

                    Else
                        Recibo(strCodPed, strParcela)
                        If TemImpressora = True Then
                            If SegViaRecibo = True Then
                                If MsgBox("Deseja imprimir a 2ª via do recibo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                    Recibo(Me.txtCodPed.Text.Trim, "P/" & Me.seParcela.Text.Trim)
                                End If
                            End If
                        End If
                    End If

                End If

           

            ElseIf Me.rdgFim.SelectedIndex = 1 Then

                If AbrirFecharCaixa = True Then
                    If VerificarCaixa("") = False Then Exit Sub
                End If

                If Me.grd2.RowCount > 1 Then
                    MsgBox("Não é possível fazer o recebimento parcial de parcelas somadas, parcial somente de parcela única!", MsgBoxStyle.Information)
                    Exit Sub
                End If
                If CDbl(Me.txtValTotRec.Text) >= CDbl(Me.txtComJuros.Text) Then
                    MsgBox("Não é possível fazer o recebimento parcial já que o valor recebido é igual ao valor total a receber!", MsgBoxStyle.Information)
                    Exit Sub
                End If

                Inserir("INSERT INTO ContaReceber (CodOrdem, DataVenda, CodCli, Obs, FormaPagamento, Parcelas, " & _
                "ValorParcela, Vencimento, ValorVenda, ValorRecebido, RecebidoOK, Pagamento, NumeroDocumento, " & _
                "TipoCusto, Banco, CodConfig, Recebimento, CodLojaBaixa, Comissao, CodigoPedido, CentroCusto) VALUES (" & _
                "" & Me.txtCodPed.Text.Trim & ",'" & Me.dtVenda.Text.Trim & "'," & intCodCliente & "," & _
                "'" & Me.txtDesc.Text.Trim & "','" & Me.luePag.GetColumnValue("FormaPagamento").ToString.Trim & "'," & _
                "'" & "P" & "/" & Me.seParcela.Text.Trim & "'," & Num(Me.txtValTotRec.Text.Trim) & "," & _
                "'" & Date.Today & "'," & Num(Me.txtValorConta.Text.Trim) & "," & Num(Me.txtValTotRec.Text.Trim) & "," & _
                "'" & True & "','" & Me.luePag.Text.Trim & "','" & "" & "','" & Me.cboTipCus.Text.Trim & "'," & _
                "'" & Me.cboBanco.Text.Trim & "'," & CodConfig & ",'" & Me.dtRecib.Text & "'," & CodConfig & "," & _
                "'" & Num(Me.txtCom.Text.Trim) & "','','" & Me.cboCenCus.Text & "')")

                Dim dblDif As Double

                dblDif = CDbl(Me.txtComJuros.Text.Trim) - CDbl(Me.txtValTotRec.Text.Trim)

                dblDif = dblDif / Me.grd2.RowCount


                For I = 0 To Me.grd2.RowCount - 1
                    intCodAutPar = Me.grd2.GetRowCellDisplayText(I, Me.colCodigoParcela)

                    If intCodAutPar = 0 Then
                        MsgBox("Ocorreu alguma falha ao baixar a parcela, tente novamente!", MsgBoxStyle.Information)
                        Exit Sub
                    End If

                    Atualizar("Update ContaReceber set ValorParcela ='" & Num(dblDif.ToString("0.00")) & "', NumeroDocumento ='" & Me.grd2.GetRowCellDisplayText(I, Me.colDocumento) & "' where Codigo =" & intCodAutPar)
                    Atualizar("Update ContaReceber set RecebidoOK ='False' where Codigo = " & intCodAutPar)
                Next
                IrCaixa(Me.txtCodPed.Text.Trim, "P/" & Me.seParcela.Text.Trim, Me.txtValTotRec.Text)
                InserirFuturo(Me.txtCodPed.Text.Trim)
                'If NomeEmpresa.Trim.ToUpper.Contains("CHARME") = False Then
                '    Recibo(Me.txtCodPed.Text.Trim, "P/" & Me.seParcela.Text.Trim)
                'End If


                If NomeEmpresa.Trim.ToUpper.Contains("CHARME") = False Then
                    If ImprimirDireto = False Then
                        If MsgBox("Deseja imprimir o recibo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            Recibo(Me.txtCodPed.Text.Trim, "P/" & Me.seParcela.Text.Trim)
                            If TemImpressora = True Then
                                'Recibo(Me.txtCodPed.Text.Trim, "P/" & Me.seParcela.Text.Trim)
                                If SegViaRecibo = True Then
                                    If MsgBox("Deseja imprimir a 2ª via do recibo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                        Recibo(Me.txtCodPed.Text.Trim, "P/" & Me.seParcela.Text.Trim)
                                    End If
                                End If
                            End If
                        End If

                    Else
                        Recibo(Me.txtCodPed.Text.Trim, "P/" & Me.seParcela.Text.Trim)
                        If TemImpressora = True Then
                            'Recibo(Me.txtCodPed.Text.Trim, "P/" & Me.seParcela.Text.Trim)
                            If SegViaRecibo = True Then
                                If MsgBox("Deseja imprimir a 2ª via do recibo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                    Recibo(Me.txtCodPed.Text.Trim, "P/" & Me.seParcela.Text.Trim)
                                End If
                            End If
                        End If
                    End If

                End If


               

            End If
        End If

        Atualizar("Update Cliente set Inadimplente = 'False' where Codigo =" & intCodCliente)

        AtualizarGrid("RecebidoOK = 'False'")
        bolAlterado = False
        Limpar()

    End Sub
    Private Sub Recibo(ByVal parParcela As String, ByVal parVenda As String)

        If TemImpressora = True Then
            If Impressora = "DARUMA" Then


                Dim strImpressao As String

                strImpressao = "<tc>#</tc>" & vbCrLf

                strImpressao &= "<b><ce>" & NomeEmpresa.ToString.Trim & "</ce></b>" & vbCrLf

                strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf

                strImpressao &= "<ce>" & TelefoneEmpresa & "</ce>" & vbCrLf
                strImpressao &= "<tc>#</tc>" & vbCrLf
                strImpressao &= "<e><ce>RECIBO DE PAGAMENTO" & "</ce></e>" & vbCrLf
                strImpressao &= "<e><ce>PARCELA DE CREDIÁRIO" & "</ce></e>" & vbCrLf
                strImpressao &= "<tc>-</tc>" & vbCrLf

                If Me.txtCliente.Text <> "CONSUMIDOR" Then
                    strImpressao &= "<c><b>Cliente: " & Me.txtCliente.Text.Trim & "</b></c>" & vbCrLf
                    strImpressao &= "<c><b>CPF/CNPJ: " & strCPFCliente & "</b></c>" & vbCrLf
                    strImpressao &= "<c>Data Pagamento: " & Me.dtRecib.Text.Trim & "</c>" & vbCrLf
                    strImpressao &= "<l></l>" & vbCrLf
                End If

                Dim P As Integer

                For P = 0 To grd2.RowCount - 1
                    strImpressao &= "<c>Venda N°: " & Me.grd2.GetRowCellDisplayText(P, Me.colCodPed).Trim & "</c>" & vbCrLf
                    strImpressao &= "<c>Parcela: " & Me.grd2.GetRowCellDisplayText(P, Me.colParcelaImp) & "</c>" & vbCrLf
                    strImpressao &= "<c><b>Valor Parcela: R$ " & Me.grd2.GetRowCellDisplayText(P, Me.colValParcela) & "</b></c>" & vbCrLf
                    strImpressao &= "<l></l>" & vbCrLf
                Next

                Dim dblComJuros As Double = Me.txtComJuros.Text
                Dim dblSemJuros As Double = Me.txtTotal.Text
                If dblComJuros > dblSemJuros Then
                    strImpressao &= "<c><b>Total Com Juros: R$ " & Me.txtComJuros.Text & "</b></c>" & vbCrLf
                    strImpressao &= "<l></l>" & vbCrLf
                Else
                    strImpressao &= "<l></l>" & vbCrLf
                End If

                strImpressao &= "<c><b>Total Pago: R$ " & Me.txtValTotRec.Text.Trim & "</b></c>" & vbCrLf

                If Me.txtTroco.Text.Trim <> "0,00" Then
                    strImpressao &= "<c><b>Valor Troco: R$ " & Me.txtTroco.Text.Trim & "</b></c>" & vbCrLf
                End If

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
                strImpressao &= Cent("PARCELA DE CREDIÁRIO", intTamEsp) & vbCrLf
                strImpressao &= " " & vbCrLf
                strImpressao &= strTraço & vbCrLf
                If Me.txtCliente.Text <> "CONSUMIDOR" Then
                    strImpressao &= "Cliente: " & Me.txtCliente.Text.Trim & vbCrLf
                    strImpressao &= "CPF/CNPJ: " & strCPFCliente & vbCrLf
                    strImpressao &= "Data Pagamento: " & Me.dtRecib.Text.Trim & vbCrLf & vbCrLf
                End If

                Dim P As Integer

                For P = 0 To grd2.RowCount - 1
                    strImpressao &= "Venda N°: " & Me.grd2.GetRowCellDisplayText(P, Me.colCodPed).Trim & vbCrLf
                    strImpressao &= "Parcela: " & Me.grd2.GetRowCellDisplayText(P, Me.colParcelaImp) & vbCrLf
                    strImpressao &= "Valor Parcela: R$ " & Me.grd2.GetRowCellDisplayText(P, Me.colValParcela) & vbCrLf & vbCrLf
                Next

                Dim dblComJuros As Double = Me.txtComJuros.Text
                Dim dblSemJuros As Double = Me.txtTotal.Text
                If dblComJuros > dblSemJuros Then
                    strImpressao &= "Total Com Juros: R$ " & Me.txtComJuros.Text & vbCrLf & vbCrLf
                    strImpressao &= vbCrLf
                Else
                    strImpressao &= vbCrLf
                End If

                strImpressao &= "TOTAL PAGO: R$ " & Me.txtValTotRec.Text.Trim & vbCrLf

                If Me.txtTroco.Text.Trim <> "0,00" Then
                    strImpressao &= "Valor Troco: R$ " & Me.txtTroco.Text.Trim & vbCrLf
                End If

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
                strImpressao &= "<ce>" & "PARCELA DE CREDIÁRIO" & "</ce>" & vbCrLf
                strImpressao &= " " & vbCrLf
                strImpressao &= strTraço & vbCrLf
                If Me.txtCliente.Text <> "CONSUMIDOR" Then
                    strImpressao &= "Cliente: " & Me.txtCliente.Text.Trim & vbCrLf
                    strImpressao &= "CPF/CNPJ: " & strCPFCliente & vbCrLf
                    strImpressao &= "Data Pagamento: " & Me.dtRecib.Text.Trim & vbCrLf & vbCrLf
                End If

                Dim P As Integer

                For P = 0 To grd2.RowCount - 1
                    strImpressao &= "Venda N°: " & Me.grd2.GetRowCellDisplayText(P, Me.colCodPed).Trim & vbCrLf
                    strImpressao &= "Parcela: " & Me.grd2.GetRowCellDisplayText(P, Me.colParcelaImp) & vbCrLf
                    strImpressao &= "Valor Parcela: R$ " & Me.grd2.GetRowCellDisplayText(P, Me.colValParcela) & vbCrLf & vbCrLf
                Next


                Dim dblComJuros As Double = Me.txtComJuros.Text
                Dim dblSemJuros As Double = Me.txtTotal.Text
                If dblComJuros > dblSemJuros Then
                    strImpressao &= "Total Com Juros: R$ " & Me.txtComJuros.Text & vbCrLf & vbCrLf
                    strImpressao &= vbCrLf
                Else
                    strImpressao &= vbCrLf
                End If


                strImpressao &= "TOTAL PAGO: R$ " & Me.txtValTotRec.Text.Trim & vbCrLf

                If Me.txtTroco.Text.Trim <> "0,00" Then
                    strImpressao &= "Valor Troco: R$ " & Me.txtTroco.Text.Trim & vbCrLf
                End If

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
                strImpressao &= Centralizar(Exp("PARCELA DE CREDIÁRIO")) & vbCrLf
                strImpressao &= strTraco & vbCrLf
                If Me.txtCliente.Text <> "CONSUMIDOR" Then
                    strImpressao &= Neg(Dir("Cliente: " & Me.txtCliente.Text.Trim, 55)) & vbCrLf
                    strImpressao &= Comp(Dir("CPF/CNPJ: " & strCPFCliente, 55)) & vbCrLf
                    strImpressao &= Comp(Dir("Data Pagamento: " & Me.dtRecib.Text.Trim, 55)) & vbCrLf & vbCrLf
                End If

                Dim P As Integer

                For P = 0 To grd2.RowCount - 1
                    strImpressao &= Comp(Dir("Venda N: " & Me.grd2.GetRowCellDisplayText(P, Me.colCodPed).Trim, 55)) & vbCrLf
                    strImpressao &= Comp(Dir("Parcela: " & Me.grd2.GetRowCellDisplayText(P, Me.colParcelaImp), 55)) & vbCrLf
                    strImpressao &= Neg(Dir("Valor Parcela: R$ " & Me.grd2.GetRowCellDisplayText(P, Me.colValParcela), 55)) & vbCrLf & vbCrLf
                Next



                Dim dblComJuros As Double = Me.txtComJuros.Text
                Dim dblSemJuros As Double = Me.txtTotal.Text
                If dblComJuros > dblSemJuros Then
                    strImpressao &= Neg(Dir("Total Com Juros: R$ " & Me.txtComJuros.Text, 55)) & vbCrLf & vbCrLf
                    strImpressao &= vbCrLf
                Else
                    strImpressao &= vbCrLf
                End If

                If NomeEmpresa.Trim.ToUpper.Contains("ATUALIZADA") = False Then
                    strImpressao &= Neg(Dir("Obs: " & Me.txtDesc.Text.Trim, 55)) & vbCrLf & vbCrLf
                End If

                strImpressao &= DupLin(Dir("TOTAL PAGO: R$ " & Me.txtValTotRec.Text.Trim, 55)) & vbCrLf

                If Me.txtTroco.Text.Trim <> "0,00" Then
                    strImpressao &= Dir("VALOR TROCO: R$ " & Me.txtTroco.Text.Trim, 55) & vbCrLf
                End If

                Rodape(True, strImpressao)

            End If
        Else
            If MsgBox("Deseja imprimir o recibo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim rel As New relReciboPag
                rel.picLogo.Image = LogoTipo
                Dim dblValor As Double

                dblValor = Me.txtValTotRec.Text.Trim

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
                            .Item(I).Item("Empresa") = Me.txtCliente.Text.Trim
                            .Item(I).Item("Empresa1") = Me.txtCliente.Text.Trim
                        End If
                        .Item(I).Item("Endereco") = EnderecoEmpresa
                        .Item(I).Item("Telefone") = TelefoneEmpresa
                        .Item(I).Item("Email") = ""
                        .Item(I).Item("Valor") = dblValor.ToString("###,###,###,##0.00")
                        .Item(I).Item("Via") = I + 1 & "ª VIA"
                        .Item(I).Item("ValorExtenso") = strValorExt
                        .Item(I).Item("Cliente") = Me.txtCliente.Text
                        .Item(I).Item("CPF") = strCPFCliente
                        .Item(I).Item("Referente") = "DA PARCELA " & parParcela & " DA VENDA " & parVenda
                        .Item(I).Item("Data") = Me.dtRecib.Text.Trim

                    Next
                End With
                rel.ShowPreview()
            End If


        End If


    End Sub

    Private Sub IrCaixa(ByVal parCodPed As String, ByVal parParcela As String, ByVal parValor As Double)
        Dim strCmdInserir, strMot, strTroco As String
        strMot = Me.txtCliente.Text.Trim & ", PARCELA " & parParcela & " DA  Venda Nº " & parCodPed
        strTroco = "TROCO REFERÊNTE A PARCELA " & parParcela & " DA Venda Nº " & parCodPed

        Select Case Me.cboBanco.Text.Trim

            Case "CAIXA"

                Dim strAuxiliar As String
                strAuxiliar = NomeComputador.ToUpper & " " & Format(My.Computer.Clock.LocalTime, "dd/MM/yyyy HH:mm:ss:fffff")

                strCmdInserir = "INSERT INTO Caixa (Motivo, Credito, Pagamento, Valor, Data, CodConfig, Caixa, " & _
                "CentroCusto, Auxiliar) VALUES('" & strMot & "','" & "C" & "','" & Me.luePag.Text.Trim & "'," & _
                "" & Num(parValor) & ",'" & Me.dtRecib.Text.Trim & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now) & "'," & CodConfig & ",'" & UserNano & "','" & Me.cboCenCus.Text & "','" & strAuxiliar & "')"
                Inserir(strCmdInserir)
                'If Me.txtTroco.Text <> "0.00" Or Me.txtTroco.Text <> "" Or Me.txtTroco.Text <> "0" Then
                '    Inserir("INSERT INTO Caixa (Motivo, Credito, Pagamento, Valor, Data, CodConfig, Caixa) VALUES('" & strTroco & "','" & "D" & "','" & "DINHEIRO" & "'," & Num(Me.txtTroco.Text) & ",'" & Me.dtRecib.Text.Trim & "'," & CodConfig & ",'" & UserNano & "')")
                'End If
                If Me.txtTroco.Text <> "0,00" And Me.txtTroco.Text <> "" And Me.txtTroco.Text <> "0" Then
                    Inserir("INSERT INTO Caixa (Motivo, Credito, Pagamento, Valor, Data, CodConfig, Caixa, Auxiliar) VALUES('" & strTroco & "','" & "D" & "','" & "DINHEIRO" & "'," & Num(Me.txtTroco.Text) & ",'" & Me.dtRecib.Text.Trim & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now) & "'," & CodConfig & ",'" & UserNano & "','" & strAuxiliar & "')")
                End If

            Case ""
                Dim intCodPag As Integer
                intCodPag = Me.luePag.GetColumnValue("Codigo")
                Dim dtPag As DataTable
                dtPag = CarregarDataTable("SELECT IrCaixa FROM Pagamento where Codigo = " & intCodPag)
                If dtPag.Rows.Count > 0 Then
                    Dim strCaixa As String
                    strCaixa = dtPag.Rows.Item(0).Item("IrCaixa").ToString

                    Dim strAuxiliar As String
                    strAuxiliar = NomeComputador.ToUpper & " " & Format(My.Computer.Clock.LocalTime, "dd/MM/yyyy HH:mm:ss:fffff")

                    'TAUÁ MODAS NÃO QUER QUE SEJA FEITA A PERGUNDA DE IR PARA O CAIXA.
                    '**************************************************************************************************************
                    If NomeEmpresa.Contains("TAUÁ") = True Then
                        strCmdInserir = "INSERT INTO Caixa (Motivo, Credito, Pagamento, Valor, Data, CodConfig, Caixa, CentroCusto, Auxiliar) VALUES('" & strMot & "','" & "C" & "','" & Me.luePag.Text.Trim & "'," & Num(parValor) & ",'" & Me.dtRecib.Text.Trim & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now) & "'," & CodConfig & ",'" & UserNano & "','" & Me.cboCenCus.Text & "','" & strAuxiliar & "')"
                        Inserir(strCmdInserir)
                        If Me.txtTroco.Text <> "0,00" And Me.txtTroco.Text <> "" And Me.txtTroco.Text <> "0" Then
                            Inserir("INSERT INTO Caixa (Motivo, Credito, Pagamento, Valor, Data, CodConfig, Caixa, CentroCusto, Auxiliar) VALUES('" & strTroco & "','" & "D" & "','" & "DINHEIRO" & "'," & Num(Me.txtTroco.Text) & ",'" & Me.dtRecib.Text.Trim & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now) & "'," & CodConfig & ",'" & UserNano & "','" & Me.cboCenCus.Text & "','" & strAuxiliar & "')")
                        End If
                        Exit Sub
                    End If
                    '##############################################################################################################


                    If MsgBox("Deseja enviar o valor recebido ao Caixa do dia referente a data de recebimento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        strCmdInserir = "INSERT INTO Caixa (Motivo, Credito, Pagamento, Valor, Data, CodConfig, Caixa, CentroCusto, Auxiliar) VALUES('" & strMot & "','" & "C" & "','" & Me.luePag.Text.Trim & "'," & Num(parValor) & ",'" & Me.dtRecib.Text.Trim & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now) & "'," & CodConfig & ",'" & UserNano & "','" & Me.cboCenCus.Text & "','" & strAuxiliar & "')"
                        Inserir(strCmdInserir)
                        If Me.txtTroco.Text <> "0,00" And Me.txtTroco.Text <> "" And Me.txtTroco.Text <> "0" Then
                            Inserir("INSERT INTO Caixa (Motivo, Credito, Pagamento, Valor, Data, CodConfig, Caixa, CentroCusto, Auxiliar) VALUES('" & strTroco & "','" & "D" & "','" & "DINHEIRO" & "'," & Num(Me.txtTroco.Text) & ",'" & Me.dtRecib.Text.Trim & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now) & "'," & CodConfig & ",'" & UserNano & "','" & Me.cboCenCus.Text & "','" & strAuxiliar & "')")
                        End If
                    End If
                End If
            Case Else
                Dim dtPagamento As DataTable = CarregarDataTable("Select Prazo From Pagamento Where Descricao='" & Me.luePag.Text & "'")

                Dim bolCartao As Boolean = False
                If dtPagamento.Rows.Count > 0 Then
                    bolCartao = dtPagamento.Rows.Item(0).Item("Prazo").ToString
                End If

                If bolCartao = False Then
                    Dim strBanco As String
                    Dim dblValRecebido, dblSaldo, dblResul As Double
                    Dim intCodBanco As Integer
                    strBanco = Me.cboBanco.Text
                    dblValRecebido = parValor
                    Dim dtBanco As DataTable
                    dtBanco = CarregarDataTable("SELECT Codigo, Saldo FROM Banco where Nome = '" & strBanco & "'")
                    If dtBanco.Rows.Count > 0 Then
                        intCodBanco = dtBanco.Rows.Item(0).Item("Codigo").ToString
                        If dtBanco.Rows.Item(0).Item("Saldo").ToString = "" Then
                            dblSaldo = "0,00"
                        Else
                            dblSaldo = dtBanco.Rows.Item(0).Item("Saldo").ToString
                        End If

                        dblResul = dblSaldo + dblValRecebido
                        Inserir("INSERT INTO MovimentoBancario (CodBanco, TipoMovimento, Valor, Data, Observacao, CodConfig)VALUES(" & intCodBanco & ",'CRÉDITO'," & Num(dblValRecebido) & ",'" & Me.dtRecib.Text & "','" & strMot & "'," & CodConfig & ")")
                        Atualizar("UPDATE Banco SET Saldo = " & Num(dblResul) & " where Codigo = " & intCodBanco)
                    End If
                Else
                    Dim intCodPag As Integer
                    intCodPag = Me.luePag.GetColumnValue("Codigo")
                    Dim dtPag As DataTable
                    dtPag = CarregarDataTable("SELECT IrCaixa FROM Pagamento where Codigo = " & intCodPag)
                    If dtPag.Rows.Count > 0 Then
                        Dim strCaixa As String
                        strCaixa = dtPag.Rows.Item(0).Item("IrCaixa").ToString

                        Dim strAuxiliar As String
                        strAuxiliar = NomeComputador.ToUpper & " " & Format(My.Computer.Clock.LocalTime, "dd/MM/yyyy HH:mm:ss:fffff")

                        'TAUÁ MODAS NÃO QUER QUE SEJA FEITA A PERGUNDA DE IR PARA O CAIXA.
                        '**************************************************************************************************************
                        If NomeEmpresa.Contains("TAUÁ") = True Then
                            strCmdInserir = "INSERT INTO Caixa (Motivo, Credito, Pagamento, Valor, Data, CodConfig, Caixa, CentroCusto, Auxiliar) VALUES('" & strMot & "','" & "C" & "','" & Me.luePag.Text.Trim & "'," & Num(parValor) & ",'" & Me.dtRecib.Text.Trim & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now) & "'," & CodConfig & ",'" & UserNano & "','" & Me.cboCenCus.Text & "','" & strAuxiliar & "')"
                            Inserir(strCmdInserir)
                            If Me.txtTroco.Text <> "0,00" And Me.txtTroco.Text <> "" And Me.txtTroco.Text <> "0" Then
                                Inserir("INSERT INTO Caixa (Motivo, Credito, Pagamento, Valor, Data, CodConfig, Caixa, CentroCusto, Auxiliar) VALUES('" & strTroco & "','" & "D" & "','" & "DINHEIRO" & "'," & Num(Me.txtTroco.Text) & ",'" & Me.dtRecib.Text.Trim & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now) & "'," & CodConfig & ",'" & UserNano & "','" & Me.cboCenCus.Text & "','" & strAuxiliar & "')")
                            End If
                            Exit Sub
                        End If
                        '##############################################################################################################


                        If MsgBox("Deseja enviar o valor recebido ao Caixa do dia referente a data de recebimento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            strCmdInserir = "INSERT INTO Caixa (Motivo, Credito, Pagamento, Valor, Data, CodConfig, Caixa, CentroCusto, Auxiliar) VALUES('" & strMot & "','" & "C" & "','" & Me.luePag.Text.Trim & "'," & Num(parValor) & ",'" & Me.dtRecib.Text.Trim & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now) & "'," & CodConfig & ",'" & UserNano & "','" & Me.cboCenCus.Text & "','" & strAuxiliar & "')"
                            Inserir(strCmdInserir)
                            If Me.txtTroco.Text <> "0,00" And Me.txtTroco.Text <> "" And Me.txtTroco.Text <> "0" Then
                                Inserir("INSERT INTO Caixa (Motivo, Credito, Pagamento, Valor, Data, CodConfig, Caixa, CentroCusto, Auxiliar) VALUES('" & strTroco & "','" & "D" & "','" & "DINHEIRO" & "'," & Num(Me.txtTroco.Text) & ",'" & Me.dtRecib.Text.Trim & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now) & "'," & CodConfig & ",'" & UserNano & "','" & Me.cboCenCus.Text & "','" & strAuxiliar & "')")
                            End If
                        End If
                    End If
                End If
        End Select
    End Sub
    Private Sub seParcela_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles seParcela.Enter
        If bolAlterado = False Then
            If Validar(Me.txtValorConta) = False Then Exit Sub
            If Validar(Me.dtVenc) = False Then Exit Sub

            GerarParecelas()
        End If
    End Sub

    Private Sub txtValServ_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "," And e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtValServ_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        Preco(txtValorConta)
    End Sub

    Private Sub txtValServ_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.seParcela.ResetText()
    End Sub


    Private Sub txtValRec_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Preco(txtValTotRec)

    End Sub

    Private Sub btnCancelar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelar.ItemClick
        Me.Close()
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
        'Dim strNumPed As String = grd1.GetRowCellValue(Index, Me.colCodOrdem)
        Dim strNumPar As String = grd1.GetRowCellValue(Index, Me.colParcelas)
        'Dim strValPar As String = grd1.GetRowCellValue(Index, Me.colValorParcela)
        'Dim strAntigo As String = "VENDA " & strNumPed & ", PARCELA " & strNumPar & ", VALOR " & strValPar & ""

        If MsgBox("Deseja realmente excluir a Parcela " & strNumPar & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If SenhaEstaOK() = False Then Exit Sub

            Estornar(False, Index)

            'Dim strSql As String

            'Dim vetPar As Array = Split(strNumPar, "/")

            'Dim strPar As String = ""

            'If vetPar.Length > 0 Then
            '    strPar = vetPar(0).ToString
            'End If

            'strSql = "Delete from ContaReceber where Codigo = " & strCodi & vbCrLf

            'Excluir(strSql)
            'If Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodOrdem) <> "0" Then
            '    Dim strObs As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCliente) & ", PARCELA " & strPar & " DA  Venda Nº " & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodOrdem)

            '    strSql = "Delete from MovimentoBancario where Observacao ='" & strObs & "'"

            '    Excluir(strSql)
            'End If


            If Me.Tag = "RECEBIDA" Then
                AtualizarGrid("RecebidoOK = 'True'")
            Else
                AtualizarGrid("RecebidoOK = 'False'")
            End If
            'Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strAntigo & "','EXCLUÍDO','CONTA A RECEBER','CONTA A RECEBER','EXCLUSÃO'," & CodConfig & ")")

            'MsgBox("Parcela " & strNumPar & " excluida com sucesso!", MsgBoxStyle.Information)

        End If
    End Sub

    Private Sub rdgFim_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rdgFim.KeyPress
        If Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub ContaReceberGridControl_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        If Me.Tag = "RECEDIDA" Then Exit Sub
        Alterar()
    End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        If Me.Tag = "RECEDIDA" Then Exit Sub
        Alterar()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click


        Dim dblTotValor As Double
        Dim dblValor As Double
        Dim dblComissao, dblValorComissao As Double

        For I = 0 To grd1.RowCount - 1

            With grd1

                If Me.Tag = "RECEBIDA" Then
                    If .GetRowCellDisplayText(I, Me.colValorRecebido) <> "" Then
                        dblValor = .GetRowCellDisplayText(I, Me.colValorRecebido)
                    Else
                        dblValor = 0
                    End If

                Else
                    If .GetRowCellDisplayText(I, Me.colValorParcela).Trim <> "" Then
                        dblValor = .GetRowCellDisplayText(I, Me.colValorParcela).Trim
                    Else
                        dblValor = 0
                    End If

                End If

                If .GetRowCellDisplayText(I, Me.colComissao).Trim <> "" Then
                    dblComissao = .GetRowCellDisplayText(I, Me.colComissao).Trim
                End If

            End With


            dblValorComissao += (dblValor / 100) * dblComissao

            dblTotValor += dblValor
        Next

        Me.txtReceber.Text = dblTotValor.ToString("###,###,###,##0.00")
        'Me.txtTotCom.Text = dblValorComissao.ToString("###,###,###,##0.00")


    End Sub


    Private Sub txtCodPed_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodPed_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.txtCodPed.Text.Trim = "" Then Exit Sub
        For I = 0 To grd1.RowCount - 1
            If grd1.GetRowCellDisplayText(I, Me.colCodOrdem) = txtCodPed.Text.Trim Then
                MsgBox("Conta a receber já cadastrada para esse pedido!", MsgBoxStyle.Information)
                txtCodPed.ResetText()
                txtCodPed.Focus()
                Exit Sub
            End If
        Next
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

        Dim strFiltro As String

        If Me.Tag = "RECEBIDA" Then
            strFiltro = "RecebidoOK ='" & True & "' and " & String.Format("Recebimento >= '{0:dd/MM/yyyy}' AND Recebimento <= '{1:dd/MM/yyyy}'", dtInicial1.EditValue, dtFinal.EditValue)
            AtualizarGrid(strFiltro)
        Else
            strFiltro = "RecebidoOK ='" & False & "' and " & String.Format("Vencimento >= '{0:dd/MM/yyyy}' AND Vencimento <= '{1:dd/MM/yyyy}'", dtInicial1.EditValue, dtFinal.EditValue)
            AtualizarGrid(strFiltro)
        End If

    End Sub

    Private Sub luePag_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luePag.EditValueChanged
        If txtValorConta.Text.Trim = "" Then txtValorConta.Focus() : Exit Sub
    End Sub

    Private Sub txtCliente_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCliente.ButtonClick
        BuscarCliente()

    End Sub

    Private Sub BuscarCliente()
        Dim frm As New frmCadCliente
        frm.Tag = "PESQUISA"
        Me.txtCliente.ResetText()
        intCodCliente = 0
        frm.ShowDialog()

        Dim dt As DataTable = CarregarDataTable("Select Nome from cliente where Codigo =" & CodigoDoCliente)

        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item("Nome").ToString = "CONSUMIDOR" Then
                MsgBox("Não é possível gerar a conta a receber para o cliente 'CONSUMIDOR', informe um outro cliente!", MsgBoxStyle.Information)
                Exit Sub
            End If
            Me.txtCliente.Text = dt.Rows.Item(0).Item("Nome").ToString
            intCodCliente = CodigoDoCliente
        End If

    End Sub


    Private Sub btnCadBanco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadBanco.Click
        frmCadBanco.ShowDialog()
        Me.cboBanco.Properties.Items.Clear()
        PreencherOrdenado("Banco", Me.cboBanco, 1, "Nome")
        Me.cboBanco.Properties.Items.Add("")
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



            If Me.txtValorConta.Text = "" Then Exit Sub
            If Me.seParcela.Text = "" Then Exit Sub
            Dim dblTotal As Double
            Dim I As Integer
            For I = 0 To Me.grd2.RowCount - 1
                dblTotal += Me.grd2.GetRowCellDisplayText(I, Me.colValParcela)

            Next

            If bolAlterado = True Then Exit Sub

            Dim dblvalor As Double = Me.txtValorConta.Text
            Dim dblResul As Double = dblvalor - dblTotal
            If dblResul > "0,5" Then
                MsgBox("A soma das parcelas não batem com o valor da conta!", MsgBoxStyle.Information)
            End If


        Catch ex As Exception
            MsgBox("Caracter digitado não é permitido para este campo!", MsgBoxStyle.Exclamation)
            Me.grd2.SetFocusedValue("")
        End Try
    End Sub

    Private Sub rdgFim_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdgFim.Leave
        Me.txtDesc.Focus()
    End Sub

    Private Sub txtCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Keys.F10 Then
            BuscarCliente()
        End If
    End Sub

    Private Sub btnGerarCarne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarCarne.Click
        If MsgBox("Deseja imprimir o carnê?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then


            If ModeloCarne = "1" Then

                Dim rel As New relCred

                rel.picLogo.Image = LogoTipo

                For I = 0 To Me.grd1.RowCount - 1
                    rel.tbCred.Rows.Add()
                    rel.tbCred.Rows.Item(I).Item("Vencimento") = Me.grd1.GetRowCellDisplayText(I, Me.colVencimento1)
                    rel.tbCred.Rows.Item(I).Item("Valor") = Me.grd1.GetRowCellDisplayText(I, Me.colValorParcela)
                    rel.tbCred.Rows.Item(I).Item("CodVenda") = Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem)
                    rel.tbCred.Rows.Item(I).Item("Prest") = Me.grd1.GetRowCellDisplayText(I, Me.colParcelas)


                    rel.tbCred.Rows.Item(I).Item("Cliente") = Me.grd1.GetRowCellDisplayText(I, Me.colCliente)

                    rel.tbCred.Rows.Item(I).Item("Empresa") = NomeEmpresa
                    rel.tbCred.Rows.Item(I).Item("Endereco") = EnderecoEmpresa
                    rel.tbCred.Rows.Item(I).Item("Telefone") = TelefoneEmpresa
                    rel.tbCred.Rows.Item(I).Item("Data") = Me.grd1.GetRowCellDisplayText(I, Me.colDataVenda)

                Next

                rel.ShowPreviewDialog()

            ElseIf ModeloCarne.Trim = "2" Then

                If Impressora = "DARUMA" Then

                    If TemImpressora = False Then Exit Sub

                    Dim strImpressao As String

                    strImpressao = "<tc>#</tc>" & vbCrLf

                    strImpressao &= "<b><e><ce>" & NomeEmpresa.ToString.Trim & "</ce></e></b>" & vbCrLf

                    strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf

                    strImpressao &= "<ce>" & TelefoneEmpresa & "</ce>" & vbCrLf
                    strImpressao &= "<tc>#</tc>" & vbCrLf
                    strImpressao &= "<e><ce>CREDIÁRIO" & "</ce></e>" & vbCrLf
                    strImpressao &= "<tc>-</tc>" & vbCrLf

                    Dim dt As DataTable

                    dt = CarregarDataTable("Select Nome, CPF, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & Me.grd1.GetRowCellDisplayText(0, Me.colCodCli))

                    If dt.Rows.Count > 0 Then
                        If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                            strImpressao &= "<c>" & dt.Rows.Item(0).Item("Nome").ToString & "</c>" & vbCrLf
                        End If

                        If dt.Rows.Item(0).Item("CPF").ToString <> "" Then
                            strImpressao &= "<c>" & dt.Rows.Item(0).Item("CPF").ToString & "</c>" & vbCrLf
                        End If

                        'If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                        '    strImpressao &= "<c>" & dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & "</c>" & vbCrLf
                        'End If

                        'If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                        '    strImpressao &= "<c>" & dt.Rows.Item(0).Item("Telefone").ToString & "</c>" & vbCrLf
                        'End If

                    End If

                    strImpressao &= "<tc>-</tc>" & vbCrLf


                    For I = 0 To Me.grd1.RowCount - 1
                        strImpressao &= "<c>Venda Nº " & Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem).Trim & "</c>" & vbCrLf
                        strImpressao &= "<c>Nº Parcela: " & Me.grd1.GetRowCellDisplayText(I, Me.colParcelas).Trim & "</c>" & vbCrLf
                        strImpressao &= "<c>Vencimento: " & Me.grd1.GetRowCellDisplayText(I, Me.colVencimento).Trim & "</c>" & vbCrLf
                        strImpressao &= "<c><b>Valor Parc: R$ " & Me.grd1.GetRowCellDisplayText(I, Me.colValorParcela).Trim & "    Data Pagamento:____/____/________</b></c>" & vbCrLf
                        strImpressao &= "<l></l>" & vbCrLf
                        strImpressao &= "<c>Autenticação:_______________________________________</c>" & vbCrLf
                        strImpressao &= "<tc>-</tc>" & vbCrLf

                    Next

                    strImpressao &= "<l></l>" & vbCrLf

                    strImpressao &= "<c><b>A Parcela será considerada paga</b></c>" & vbCrLf
                    strImpressao &= "<c><b>quando conter O RECIBO DE PAGAMENTO.</b></c>" & vbCrLf

                    strImpressao &= "<l></l>" & vbCrLf

                    If NomeEmpresa.Replace("Á", "A").Contains("TAUA") = True Then
                        strImpressao &= "<c>Pague em dia e aumento seu Limite.</c>" & vbCrLf
                        strImpressao &= "<c>O seu nome é seu maior patrimônio!</c>" & vbCrLf
                    End If
                    strImpressao &= "<tc>-</tc>" & vbCrLf

                    strImpressao &= "<e><ce>DOCUMENTO NÃO FISCAL" & "</ce></e>" & vbCrLf

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
                        intTamEsp = 43
                        strEstrela = "*******************************************"
                        strTraço = "-------------------------------------------"
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
                    strImpressao &= Cent("CREDIÁRIO", intTamEsp) & vbCrLf
                    strImpressao &= strTraço & vbCrLf

                    Dim dt As DataTable

                    dt = CarregarDataTable("Select Nome, CPF, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & Me.grd1.GetRowCellDisplayText(0, Me.colCodCli))

                    If dt.Rows.Count > 0 Then
                        If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                            strImpressao &= dt.Rows.Item(0).Item("Nome").ToString & vbCrLf
                        End If

                        If dt.Rows.Item(0).Item("CPF").ToString <> "" Then
                            strImpressao &= dt.Rows.Item(0).Item("CPF").ToString & vbCrLf
                        End If

                        'If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                        '    strImpressao &= dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & vbCrLf
                        'End If

                        'If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                        '    strImpressao &= dt.Rows.Item(0).Item("Telefone").ToString & vbCrLf
                        'End If

                    End If

                    strImpressao &= strTraço & vbCrLf

                    For I = 0 To Me.grd1.RowCount - 1
                        strImpressao &= "Venda N: " & Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem).Trim & vbCrLf
                        strImpressao &= "N. Parcela: " & Me.grd1.GetRowCellDisplayText(I, Me.colParcelas).Trim & vbCrLf
                        strImpressao &= "Vencimento: " & Me.grd1.GetRowCellDisplayText(I, Me.colVencimento).Trim & vbCrLf
                        strImpressao &= "Vlr Parc: R$ " & Me.grd1.GetRowCellDisplayText(I, Me.colValorParcela).Trim & "  Dt Pag:___/___/_______" & vbCrLf
                        strImpressao &= " " & vbCrLf
                        strImpressao &= "Autenticação:______________________________" & vbCrLf
                        strImpressao &= strTraço & vbCrLf

                    Next

                    strImpressao &= " " & vbCrLf

                    strImpressao &= Cent("A Parcela será considerada paga", intTamEsp) & vbCrLf
                    strImpressao &= Cent("quando conter o RECIBO DE PAGAMENTO.", intTamEsp) & vbCrLf

                    If NomeEmpresa.Replace("Á", "A").Contains("TAUA") = True Then
                        strImpressao &= vbCrLf
                        strImpressao &= Cent("Pague em dia e aumento seu Limite.", intTamEsp) & vbCrLf
                        strImpressao &= Cent("O seu nome é seu maior patrimônio!", intTamEsp) & vbCrLf
                    End If
                    strImpressao &= strTraço & vbCrLf

                    strImpressao &= Cent("DOCUMENTO NÃO FISCAL", intTamEsp) & vbCrLf

                    strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U").Replace("Ç", "C").Replace("ç", "c")

                    If Impressora = "ARQUIVO" Then
                        'ImprimiArquivo(strImpressao, PortaImpressora)

                        clsImprimir.SendStringToPrinter(PortaImpressora, strImpressao)
                        If TemGuilhotina = True Then
                            strImpressao = clsImprimir.Avanco() & vbCrLf
                            strImpressao &= clsImprimir.Corte()
                            clsImprimir.SendStringToPrinter(PortaImpressora, strImpressao)
                        End If

                        If TemGaveta = True Then
                            strImpressao = clsImprimir.AbreGaveta() & vbCrLf
                            clsImprimir.SendStringToPrinter(PortaImpressora, strImpressao)
                        End If

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
                    Dim strImpressao As String




                    Dim strEstrela, strTraço As String

                    strEstrela = clsImprimir.Comp("************************************************")
                    strTraço = clsImprimir.Comp("------------------------------------------------")


                    strImpressao = strEstrela & vbCrLf

                    strImpressao &= "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf
                    strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf
                    strImpressao &= "<ce>" & TelefoneEmpresa & "</ce>" & vbCrLf

                    strImpressao &= strEstrela & vbCrLf
                    strImpressao &= "<ce>" & "CREDIÁRIO" & "</ce>" & vbCrLf
                    strImpressao &= strTraço & vbCrLf

                    Dim dt As DataTable

                    dt = CarregarDataTable("Select Nome, CPF, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & Me.grd1.GetRowCellDisplayText(0, Me.colCodCli))

                    If dt.Rows.Count > 0 Then
                        If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                            strImpressao &= dt.Rows.Item(0).Item("Nome").ToString & vbCrLf
                        End If

                        If dt.Rows.Item(0).Item("CPF").ToString <> "" Then
                            strImpressao &= dt.Rows.Item(0).Item("CPF").ToString & vbCrLf
                        End If

                        'If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                        '    strImpressao &= dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & vbCrLf
                        'End If

                        'If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                        '    strImpressao &= dt.Rows.Item(0).Item("Telefone").ToString & vbCrLf
                        'End If

                    End If

                    strImpressao &= strTraço & vbCrLf

                    For I = 0 To Me.grd1.RowCount - 1
                        strImpressao &= "Venda N: " & Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem).Trim & vbCrLf
                        strImpressao &= "N. Parcela: " & Me.grd1.GetRowCellDisplayText(I, Me.colParcelas).Trim & vbCrLf
                        strImpressao &= "Vencimento: " & Me.grd1.GetRowCellDisplayText(I, Me.colVencimento).Trim & vbCrLf
                        strImpressao &= "Vlr Parc: R$ " & Me.grd1.GetRowCellDisplayText(I, Me.colValorParcela).Trim & "  Dt Pag:___/___/_______" & vbCrLf
                        strImpressao &= " " & vbCrLf
                        strImpressao &= "Autenticação:______________________________" & vbCrLf
                        strImpressao &= strTraço & vbCrLf

                    Next

                    strImpressao &= " " & vbCrLf

                    strImpressao &= "<ce>" & "A Parcela será considerada paga" & "</ce>" & vbCrLf
                    strImpressao &= "<ce>" & "quando conter o RECIBO DE PAGAMENTO." & "</ce>" & vbCrLf

                    If NomeEmpresa.Replace("Á", "A").Contains("TAUA") = True Then
                        strImpressao &= vbCrLf
                        strImpressao &= "<ce>" & "Pague em dia e aumento seu Limite." & "</ce>" & vbCrLf
                        strImpressao &= "<ce>" & "O seu nome é seu maior patrimônio!" & "</ce>" & vbCrLf
                    End If
                    strImpressao &= strTraço & vbCrLf

                    strImpressao &= "<ce>" & "DOCUMENTO NÃO FISCAL" & "</ce>" & vbCrLf

                    strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U").Replace("Ç", "C").Replace("ç", "c")



                    iRetorno = clsEpson.IniciaPorta(PortaImpressora)
                    iRetorno = clsEpson.ImprimeTextoTag(strImpressao)

                    If TemGuilhotina = True Then
                        iRetorno = clsEpson.AcionaGuilhotina(1)
                    End If
                    iRetorno = clsEpson.FechaPorta()

                End If

                If Impressora.Contains("ESC/POS") = True Then

                    If TemImpressora = False Then Exit Sub

                    Dim strImpressao As String

                    strImpressao = Cabecalho()

                    strImpressao &= Centralizar(Exp("CREDIÁRIO")) & vbCrLf
                    strImpressao &= strTraco & vbCrLf

                    Dim dt As DataTable

                    dt = CarregarDataTable("Select Nome, CPF, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & Me.grd1.GetRowCellDisplayText(0, Me.colCodCli))

                    If dt.Rows.Count > 0 Then
                        If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                            strImpressao &= Neg(Dir(dt.Rows.Item(0).Item("Nome").ToString, 55)) & vbCrLf
                        End If

                        If dt.Rows.Item(0).Item("CPF").ToString <> "" Then
                            strImpressao &= Dir(dt.Rows.Item(0).Item("CPF").ToString, 55) & vbCrLf
                        End If

                    End If

                    strImpressao &= strTraco & vbCrLf


                    For I = 0 To Me.grd1.RowCount - 1
                        strImpressao &= Dir("Venda N: " & Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem).Trim, 55) & vbCrLf
                        strImpressao &= Dir("N. Parcela: " & Me.grd1.GetRowCellDisplayText(I, Me.colParcelas).Trim, 55) & vbCrLf
                        strImpressao &= Dir("Vencimento: " & Me.grd1.GetRowCellDisplayText(I, Me.colVencimento).Trim, 55) & vbCrLf
                        strImpressao &= Neg(Dir("Valor Parc: R$ " & Me.grd1.GetRowCellDisplayText(I, Me.colValorParcela).Trim & "  Data Pagamento:____/____/_______", 55)) & vbCrLf
                        strImpressao &= vbCrLf
                        strImpressao &= Dir("Autenticação:_______________________________________", 55) & vbCrLf
                        strImpressao &= strTraco & vbCrLf

                    Next

                    strImpressao &= vbCrLf

                    strImpressao &= Centralizar(Neg("A Parcela será considerada paga")) & vbCrLf
                    strImpressao &= Centralizar(Neg("quando conter O RECIBO DE PAGAMENTO.")) & vbCrLf

                    strImpressao &= vbCrLf

                    If NomeEmpresa.Replace("Á", "A").Contains("TAUA") = True Then
                        strImpressao &= Centralizar("Pague em dia e aumento seu Limite.") & vbCrLf
                        strImpressao &= Centralizar("O seu nome é seu maior patrimônio!") & vbCrLf
                    End If


                    Rodape(True, strImpressao)

                End If

            ElseIf ModeloCarne.Trim = "3" Then
                If Me.grd1.RowCount > 0 Then

                    For I = 0 To Me.grd1.RowCount - 1
                        If Impressora.Contains("ESC/POS") = True Then

                            If TemImpressora = False Then Exit Sub

                            Dim strImpressao As String

                            strImpressao = Cabecalho()

                            strImpressao &= Centralizar(Exp("CREDIÁRIO")) & vbCrLf
                            strImpressao &= strTraco & vbCrLf

                            Dim dt As DataTable

                            dt = CarregarDataTable("Select Nome, CPF, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & Me.grd1.GetRowCellDisplayText(0, Me.colCodCli))

                            If dt.Rows.Count > 0 Then
                                If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                                    strImpressao &= Neg(Dir(Exp(dt.Rows.Item(0).Item("Nome").ToString), 45)) & vbCrLf
                                End If

                                If dt.Rows.Item(0).Item("CPF").ToString <> "" Then
                                    strImpressao &= Neg(Dir(Exp(dt.Rows.Item(0).Item("CPF").ToString), 45)) & vbCrLf
                                End If

                            End If

                            strImpressao &= strTraco & vbCrLf


                            strImpressao &= Dir(Exp("Venda N: " & Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem).Trim), 45) & vbCrLf
                            strImpressao &= Dir(Exp("N. Parcela: " & Me.grd1.GetRowCellDisplayText(I, Me.colParcelas).Trim), 45) & vbCrLf
                            strImpressao &= Dir(Exp("Vencimento: " & Me.grd1.GetRowCellDisplayText(I, Me.colVencimento).Trim), 45) & vbCrLf
                            strImpressao &= Neg(Dir(Exp("Valor Parc: R$ " & Me.grd1.GetRowCellDisplayText(I, Me.colValorParcela).Trim), 45)) & vbCrLf & vbCrLf
                            strImpressao &= Neg(Centralizar(Exp("Data Pagamento:____/____/_______"))) & vbCrLf
                            strImpressao &= vbCrLf
                            strImpressao &= Dir(Exp("Autenticação:____________________________"), 45) & vbCrLf
                            strImpressao &= strTraco & vbCrLf


                            strImpressao &= vbCrLf

                            strImpressao &= Centralizar(Neg(Exp("A Parcela será considerada paga"))) & vbCrLf
                            strImpressao &= Centralizar(Neg(Exp("quando conter O RECIBO DE PAGAMENTO."))) & vbCrLf


                            strImpressao &= vbCrLf

                            Rodape(True, strImpressao)
                        End If
                    Next

                End If
            End If

        End If


        If MsgBox("Deseja imprimir a NOTA PROMISSÓRIA?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then

            Dim dtConta As DataTable = CarregarDataTable("SELECT convert(Varchar(10),Vencimento,103) as Vencimento from ContaReceber where CodOrdem = " & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodOrdem) & " and CodCli = '" & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodCli) & "' order by Codigo DESC")
            Dim strVenc As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colVencimento)
            If dtConta.Rows.Count > 0 Then
                strVenc = dtConta.Rows.Item(0).Item("Vencimento").ToString
            End If
            Dim rel As New relPromissoria
            Dim culture As New CultureInfo("pt-BR")
            Dim dtfi As DateTimeFormatInfo = culture.DateTimeFormat


            Dim dtData As Date = Nothing
            If Me.grd1.FocusedRowHandle <> "-999997" Then
                dtData = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colDataVenda)
            Else
                MsgBox("Para gerar a promissória é necessario selicionar uma parcela!", MsgBoxStyle.Information)
                Exit Sub
            End If


            Dim dia As Integer = dtData.Day
            Dim ano As Integer = dtData.Year
            Dim mes As String = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(Date.Today.Month))

            'Dim diasemana As String = culture.TextInfo.ToTitleCase(dtfi.GetDayName(dtData.DayOfWeek))

            'Dim data As String = diasemana & ", " & dia & " de " & mes & " de " & ano
            Dim vetData As Array
            vetData = Split(strVenc, "/")
            Dim intMes, intDia, intAno As Integer
            intMes = vetData(1)
            intDia = vetData(0)
            intAno = vetData(2)
            Dim strMesVenc As String = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(intMes))
            Dim strDia As String = getInteger(intDia)
            Dim strAno As String = getInteger(intAno)
            Dim dt As DataTable
            dt = CarregarDataTable("SELECT Nome, Endereco, Numero, Bairro, Cidade , Estado, CPF FROM Cliente where Codigo = " & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodCli))
            Dim strEndereco As String
            strEndereco = dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & "  " & dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & " - " & dt.Rows.Item(0).Item("Estado").ToString
            rel.lblPagavel.Text = CidadeEmpresa
            rel.lblCPF1.Text = CNPJEmpresa
            rel.lblCidade.Text = CidadeEmpresa & ","
            rel.lblDiaAtual.Text = Date.Today.Day
            rel.lblMesAtual.Text = mes.ToUpper
            rel.lblAnoAtual.Text = Date.Today.Year
            rel.lblDia.Text = intDia
            rel.lblMes.Text = strMesVenc.ToUpper
            rel.lblAno.Text = intAno
            rel.lblEmit.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCliente)
            rel.lblEnd.Text = strEndereco
            rel.lblCPF2.Text = dt.Rows.Item(0).Item("CPF").ToString
            rel.lblVia.Text = NomeEmpresa
            If dt.Rows.Item(0).Item("CPF").ToString <> "" Then
                If dt.Rows.Item(0).Item("CPF").ToString.Length > 13 Then
                    rel.lblPagar.Text = "EMOS"
                Else
                    rel.lblPagar.Text = "EI"
                End If
            Else
                rel.lblPagar.Text = "EI"
            End If
            Dim dblValorTotal As Double = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colValor)

            rel.lblNumero.Text = "01/01"
            rel.lblValor.Text = dblValorTotal.ToString("0.00")
            Dim strValorExt As String = dblValorTotal.ToString("0.00")
            Dim vetValor As Array
            vetValor = Split(strValorExt, ",")
            Dim strReais, strCentavos As String
            strReais = getInteger(vetValor(0))
            If vetValor(1) = "00" Then
                strValorExt = strReais.ToUpper & " REAIS"
            Else
                strCentavos = getInteger(vetValor(1))
                strValorExt = strReais.ToUpper & " REAIS E " & strCentavos.ToUpper & " CENTAVOS"
            End If
            rel.lblValorExt.Text = strValorExt
            rel.lblAos.Text = "DIA " & strDia.ToUpper & " DO MÊS DE " & strMesVenc.ToUpper & " DO ANO DE " & strAno.ToUpper
            rel.ShowPreviewDialog()
        End If
    End Sub

    Private Sub lueLoja_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueLoja.DoubleClick
        Alterar()
    End Sub

    Private Sub btnAbrirCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrirCliente.Click
        If grd1.RowCount = 0 Then Exit Sub
        Dim Index As Integer = grd1.FocusedRowHandle
        If Index < 0 Then Exit Sub
        CodigoDoCliente = Me.grd1.GetRowCellDisplayText(Index, Me.colCodCli)
        frmCadCliente.Tag = "Receber"
        frmCadCliente.Show()
    End Sub



    Private Sub txtValTotRec_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValTotRec.Leave
        If Me.txtValTotRec.Text = "" Then Exit Sub
        If Me.txtComJuros.Text = "" Then Exit Sub
        Dim dblValor, dblComJuros, dblTroco As Double
        dblValor = Me.txtValTotRec.Text
        dblComJuros = Me.txtComJuros.Text
        dblTroco = dblValor - dblComJuros
        If dblTroco < 0 Then
            dblTroco = 0
        End If
        Me.txtTroco.Text = dblTroco.ToString("0.00")
    End Sub
    Private Sub GerarRecibo()
        If ModeloCarne.Trim = "2" Then

            If Impressora = "DARUMA" Then

                If TemImpressora = False Then Exit Sub

                Dim strImpressao As String

                strImpressao = "<tc>#</tc>" & vbCrLf

                strImpressao &= "<b><e><ce>" & NomeEmpresa.ToString.Trim & "</ce></e></b>" & vbCrLf

                strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf

                strImpressao &= "<ce>" & TelefoneEmpresa & "</ce>" & vbCrLf
                strImpressao &= "<tc>#</tc>" & vbCrLf
                strImpressao &= "<ad>Ordem Nº " & Me.grd1.GetRowCellDisplayText(0, Me.colCodOrdem).Trim & "  <dt></dt></ad>" & vbCrLf
                strImpressao &= "<l></l>" & vbCrLf
                strImpressao &= "<e><ce>RECIBO" & "</ce></e>" & vbCrLf
                strImpressao &= "<tc>-</tc>" & vbCrLf

                Dim dt As DataTable

                dt = CarregarDataTable("Select Nome, CPF, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & Me.grd1.GetRowCellDisplayText(0, Me.colCodCli))

                If dt.Rows.Count > 0 Then
                    If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                        strImpressao &= "<c>" & dt.Rows.Item(0).Item("Nome").ToString & " CPF/CNPJ: " & dt.Rows.Item(0).Item("CPF").ToString & "</c>" & vbCrLf
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

                strImpressao &= "<tc>-</tc>" & vbCrLf


                For I = 0 To Me.grd1.RowCount - 1
                    strImpressao &= "<c>Nº Parcela: " & Me.grd1.GetRowCellDisplayText(I, Me.colParcelas).Trim & "</c>" & vbCrLf
                    strImpressao &= "<c>Vencimento: " & Me.grd1.GetRowCellDisplayText(I, Me.colVencimento).Trim & "</c>" & vbCrLf
                    strImpressao &= "<c><b>Valor Parc: R$ " & Me.grd1.GetRowCellDisplayText(I, Me.colValorParcela).Trim & "    Data Pagamento:____/____/________</b></c>" & vbCrLf
                    strImpressao &= "<l></l>" & vbCrLf
                    strImpressao &= "<c>Autenticação:_______________________________________</c>" & vbCrLf
                    strImpressao &= "<tc>-</tc>" & vbCrLf

                Next

                strImpressao &= "<l></l>" & vbCrLf

                strImpressao &= "<e><ce>DOCUMENTO NÃO FISCAL" & "</ce></e>" & vbCrLf

                strImpressao &= "<tc>-</tc>" & vbCrLf
                strImpressao &= "<ce>OBRIGADO PELA PREFERENCIA!</ce>" & vbCrLf
                strImpressao &= "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf
                strImpressao &= "<l></l>" & vbCrLf
                strImpressao &= "<l></l>" & vbCrLf
                strImpressao &= "<l></l>" & vbCrLf

                If TemGuilhotina = True Then
                    strImpressao &= "<gui></gui>" & vbCrLf
                End If

                If ImpressoraOK() = True Then
                    iRetorno = (iImprimirTexto_DUAL_DarumaFramework(strImpressao, 0))
                End If

            ElseIf Impressora.Contains("BEMATECH") Or Impressora.Contains("ARQUIVO") Or Impressora.Contains("NANO PRINT") Then
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



                strImpressao = "************************************************************" & vbCrLf

                strImpressao &= Cent(NomeEmpresa.ToString.Trim, 60) & vbCrLf
                strImpressao &= Cent(EnderecoEmpresa.Trim, 60) & vbCrLf
                strImpressao &= Cent(TelefoneEmpresa, 60) & vbCrLf

                strImpressao &= "************************************************************" & vbCrLf
                strImpressao &= Dir("Ordem N - " & Me.grd1.GetRowCellDisplayText(0, Me.colCodOrdem).Trim, 60) & vbCrLf
                strImpressao &= " " & vbCrLf
                strImpressao &= Cent("RECIBO", 60) & vbCrLf

                strImpressao &= "------------------------------------------------------------" & vbCrLf

                Dim dt As DataTable

                dt = CarregarDataTable("Select Nome, CPF, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & Me.grd1.GetRowCellDisplayText(0, Me.colCodCli))

                If dt.Rows.Count > 0 Then
                    If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                        strImpressao &= dt.Rows.Item(0).Item("Nome").ToString & " CPF/CNPJ: " & dt.Rows.Item(0).Item("CPF").ToString & vbCrLf
                    End If

                    If dt.Rows.Item(0).Item("Endereco").ToString <> "" Then
                        strImpressao &= dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & " " & dt.Rows.Item(0).Item("Complemento").ToString & vbCrLf
                    End If

                    If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                        strImpressao &= dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & vbCrLf
                    End If

                    If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                        strImpressao &= dt.Rows.Item(0).Item("Telefone").ToString & vbCrLf
                    End If

                End If

                strImpressao &= "------------------------------------------------------------" & vbCrLf


                For I = 0 To Me.grd1.RowCount - 1
                    strImpressao &= "N. Parcela: " & Me.grd1.GetRowCellDisplayText(I, Me.colParcelas).Trim & vbCrLf
                    strImpressao &= "Vencimento: " & Me.grd1.GetRowCellDisplayText(I, Me.colVencimento).Trim & vbCrLf
                    strImpressao &= "Valor Parc: R$ " & Me.grd1.GetRowCellDisplayText(I, Me.colValorParcela).Trim & "    Data Pagamento:____/____/________" & vbCrLf
                    strImpressao &= " " & vbCrLf
                    strImpressao &= "Autenticação:_______________________________________________" & vbCrLf
                    strImpressao &= "------------------------------------------------------------" & vbCrLf

                Next

                strImpressao &= Cent("DOCUMENTO NÃO FISCAL", 60) & vbCrLf

                strImpressao &= " " & vbCrLf
                strImpressao &= " " & vbCrLf
                strImpressao &= " " & vbCrLf
                strImpressao &= " " & vbCrLf
                strImpressao &= " " & vbCrLf
                strImpressao &= ". " & vbCrLf
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
                Dim strImpressao As String



                Dim strEstrela As String = clsImprimir.Comp("************************************************")
                Dim strTraço As String = clsImprimir.Comp("------------------------------------------------")


                strImpressao = strEstrela & vbCrLf

                strImpressao &= "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf
                strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf
                strImpressao &= "<ce>" & TelefoneEmpresa & "</ce>" & vbCrLf

                strImpressao &= strEstrela & vbCrLf
                strImpressao &= Dir("Ordem N - " & Me.grd1.GetRowCellDisplayText(0, Me.colCodOrdem).Trim, 48) & vbCrLf
                strImpressao &= " " & vbCrLf
                strImpressao &= "<ce>" & "RECIBO" & "</ce>" & vbCrLf

                strImpressao &= strTraço & vbCrLf

                Dim dt As DataTable

                dt = CarregarDataTable("Select Nome, CPF, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & Me.grd1.GetRowCellDisplayText(0, Me.colCodCli))

                If dt.Rows.Count > 0 Then
                    If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                        strImpressao &= dt.Rows.Item(0).Item("Nome").ToString & " CPF/CNPJ: " & dt.Rows.Item(0).Item("CPF").ToString & vbCrLf
                    End If

                    If dt.Rows.Item(0).Item("Endereco").ToString <> "" Then
                        strImpressao &= dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & " " & dt.Rows.Item(0).Item("Complemento").ToString & vbCrLf
                    End If

                    If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                        strImpressao &= dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & vbCrLf
                    End If

                    If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                        strImpressao &= dt.Rows.Item(0).Item("Telefone").ToString & vbCrLf
                    End If

                End If

                strImpressao &= strTraço & vbCrLf


                For I = 0 To Me.grd1.RowCount - 1
                    strImpressao &= "N. Parcela: " & Me.grd1.GetRowCellDisplayText(I, Me.colParcelas).Trim & vbCrLf
                    strImpressao &= "Vencimento: " & Me.grd1.GetRowCellDisplayText(I, Me.colVencimento).Trim & vbCrLf
                    strImpressao &= "Valor Parc: R$ " & Me.grd1.GetRowCellDisplayText(I, Me.colValorParcela).Trim & "    Data Pagamento:____/____/________" & vbCrLf
                    strImpressao &= " " & vbCrLf
                    strImpressao &= "Autenticação:_______________________________________________" & vbCrLf
                    strImpressao &= strTraço & vbCrLf

                Next

                strImpressao &= "<ce>" & "DOCUMENTO NÃO FISCAL" & "</ce>" & vbCrLf

                strImpressao &= " " & vbCrLf
                strImpressao &= " " & vbCrLf
                strImpressao &= " " & vbCrLf
                strImpressao &= " " & vbCrLf
                strImpressao &= " " & vbCrLf
                strImpressao &= ". " & vbCrLf
                strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")


                iRetorno = clsEpson.IniciaPorta(PortaImpressora)


                iRetorno = clsEpson.ImprimeTextoTag(strImpressao)

                If TemGuilhotina = True Then
                    iRetorno = clsEpson.AcionaGuilhotina(1)
                End If
                iRetorno = clsEpson.FechaPorta()


            End If

        End If
    End Sub

    Private Sub RepositoryItemDateEdit4_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemDateEdit4.Leave

        Timer1.Start()
    End Sub

    Private Sub RepositoryItemDateEdit4_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles RepositoryItemDateEdit4.Validating
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If bolLoad = False Then
            GerarJuros()
        Else
            Dim index As Integer = -999997
            grd1.FocusedRowHandle = index

            grd1.FocusedColumn = Me.colCodOrdem

            grd1.ShowEditor()
        End If

        Timer1.Stop()
    End Sub


    Private Sub btnRelCont_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCont.ItemClick

        Dim I As Integer
        Dim rel As New relContaReceber
        rel.picLogo.Image = LogoTipo
        With rel.tbRec.Rows
            Dim dtDataInicial As Date
            Dim dtDataFinal As Date
            Dim dtDT As Date
            Dim dblValFat, dblPor, dblComi As Double

            For I = 0 To grd1.RowCount - 1
                .Add()
                .Item(I).Item("Cod") = grd1.GetRowCellDisplayText(I, Me.colCodOrdem)
                .Item(I).Item("Cliente") = grd1.GetRowCellDisplayText(I, Me.colCliente)
                .Item(I).Item("Valor") = grd1.GetRowCellDisplayText(I, Me.colValor)
                .Item(I).Item("ValorParcela") = grd1.GetRowCellDisplayText(I, Me.colValorParcela)
                .Item(I).Item("Vencimento") = grd1.GetRowCellDisplayText(I, Me.colVencimento)
                .Item(I).Item("ValorRecebido") = grd1.GetRowCellDisplayText(I, Me.colValorRecebido)
                .Item(I).Item("Recebimento") = grd1.GetRowCellDisplayText(I, Me.colRecebimento)
                .Item(I).Item("CentroCusto") = grd1.GetRowCellDisplayText(I, Me.colCentroCusto)

                If NomeEmpresa.Contains("CHARME") = True Then
                    .Item(I).Item("Parcelas") = grd1.GetRowCellDisplayText(I, Me.colComissao)
                Else
                    .Item(I).Item("Parcelas") = grd1.GetRowCellDisplayText(I, Me.colParcelas)
                End If


                If NomeEmpresa.Contains("CHARME") = True Then
                    .Item(I).Item("CPF") = grd1.GetRowCellDisplayText(I, Me.colBanco)
                Else
                    .Item(I).Item("CPF") = grd1.GetRowCellDisplayText(I, Me.colCPF)
                End If

                If NomeEmpresa.Contains("CHARME") = True Then
                    dblValFat = grd1.GetRowCellDisplayText(I, Me.colValorRecebido)

                    If grd1.GetRowCellDisplayText(I, Me.colComissao).Trim <> "" Then
                        dblPor = grd1.GetRowCellDisplayText(I, Me.colComissao)
                    Else
                        dblPor = 0
                    End If

                    dblComi = (dblValFat / 100) * dblPor
                    .Item(I).Item("ValorParcela") = dblComi.ToString("###,###,##0.00")
                End If


                If Me.Tag = "RECEDIDA" Then
                    dtDT = grd1.GetRowCellDisplayText(I, Me.colRecebimento)
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
            If NomeEmpresa.Contains("CHARME") = True Then
                rel.colRecebimento.Caption = "Faturamento"
                rel.colVencimento.Visible = False
                rel.colValorRecebido.Caption = "Val. Fatur. R$"
                rel.colParcelas.Caption = "Comissão %"
                rel.colCPF.Caption = "Vendedor"
                rel.colCPF.Width = 180
                rel.colCliente.Width = 230
                rel.colValor.Caption = "Val. Pedido R$"
                rel.colValorParcela.Caption = "Comissão R$"
                rel.colValorRecebido.VisibleIndex = 4
                rel.lblCom.Visible = True
                rel.lblTotCom.Visible = True
                'rel.lblTotCom.Text = Me.txtTotCom.Text.Trim

                rel.colCod.Caption = "Nº Pedido"
            End If

            If Me.Tag = "RECEBIDA" Then
                rel.lblRelTotal.Text = "Total Recebido R$"
                rel.lblTitulo.Text = "Relatório de Contas Recebidas"
            Else
                If Me.colValorRecebido.Visible = False Then
                    rel.colValorRecebido.Visible = False
                End If
                If Me.colRecebimento.Visible = False Then
                    rel.colRecebimento.Visible = False
                End If
                rel.lblRelTotal.Text = "Total a Receber R$"
                rel.lblTitulo.Text = "Relatório de Contas a Receber"
            End If
            rel.lblTotal.Text = Me.txtReceber.Text.Trim
        End With

        rel.ShowPreview()
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.Grid1.ShowPrintPreview()
    End Sub

    Private Sub txtDesc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesc.KeyPress
        If e.KeyChar = "'" Or e.KeyChar = "&" Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnEstornar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstornar.ItemClick
        'If Me.grd1.FocusedRowHandle < 0 Then Exit Sub

        Dim bolPassou As Boolean = False
        If MsgBox("Deseja realmente estornar esta(s) conta(s) recebida(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim index As Integer = -999997
            grd1.FocusedRowHandle = index

            For I As Integer = 0 To Me.grd1.RowCount - 1
                If Me.grd1.GetRowCellValue(I, Me.colReceber) = True Then
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

            If Me.Tag = "RECEBIDA" Then
                AtualizarGrid("RecebidoOK = 'True'")
            Else
                AtualizarGrid("RecebidoOK = 'False'")
            End If
        End If

        'ATUALIZA VALOR NO CAIXA
        'Dim strObs As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCliente) & ", PARCELA " & strParcela & " DA  Venda Nº " & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodOrdem)
        'Excluir("Delete from MovimentoBancario where Observacao ='" & strObs & "'")

    End Sub

    Dim bolParcial As Boolean = False
    Private Sub Estornar(ByVal parEstornar As Boolean, ByVal Index As Integer)
        'Dim strCodigo As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)
        'Dim dblValPar As Double = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colValorRecebido)
        'If Me.Tag <> "RECEBIDA" Then
        '    dblValPar = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colValorParcela)
        'End If
        'Dim strCodOrdem As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodOrdem)
        'Dim strParcela As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colParcelas)

        Dim strCodigo As String = Me.grd1.GetRowCellDisplayText(Index, Me.colCodigo)
        Dim dblValPar As Double = Me.grd1.GetRowCellDisplayText(Index, Me.colValorRecebido)
        If Me.Tag <> "RECEBIDA" Then
            dblValPar = Me.grd1.GetRowCellDisplayText(Index, Me.colValorParcela)
        End If
        Dim strCodOrdem As String = Me.grd1.GetRowCellDisplayText(Index, Me.colCodOrdem)
        Dim strParcela As String = Me.grd1.GetRowCellDisplayText(Index, Me.colParcelas)

        Dim vetParcela As Array = Split(strParcela, "/")
        'strParcela = vetParcela(0)
     
        Dim strCliente As String = Me.grd1.GetRowCellDisplayText(Index, Me.colCliente)
        Dim strCodConfig As String = Me.grd1.GetRowCellDisplayText(Index, Me.colCodConfig)

        



      

        Dim strAntigo As String = "VENDA " & strCodOrdem & ", PARCELA " & strParcela & ", VALOR " & dblValPar & ""

        If Me.Tag = "RECEBIDA" Then
            Dim strData As String = Me.grd1.GetRowCellDisplayText(Index, Me.colRecebimento)
            Dim dtData As Date = strData

            If AbrirFecharCaixa = True Then

                Dim dtCaixa As DataTable = CarregarDataTable("SELECT Codigo, Motivo FROM CAIXA where Motivo " & _
                "LIKE '%Venda Nº %' and motivo like '%" & strCodOrdem & "%' and Motivo LIKE '" & strCliente & ", PARCELA%' " & _
                "and CodConfig = " & strCodConfig & " and Data >= '" & dtData & "' and Data <= '" & dtData.AddDays(1) & "'")
                If dtCaixa.Rows.Count > 0 Then
                    Dim strCodigoCaixa As String = dtCaixa.Rows.Item(0).Item("Codigo").ToString
                    Dim strMotivoCaixa As String = dtCaixa.Rows.Item(0).Item("Motivo").ToString
                    If VerificarExclusaoCaixa(strMotivoCaixa, strCodigoCaixa) = False Then Exit Sub
                End If
            End If

            Dim strPar As String = vetParcela(1) + "/" + vetParcela(1)

            If strParcela.Contains("P") = True Then
                Atualizar("UPDATE ContaReceber set Parcelas='" + strPar + "' where Codigo = " & strCodigo)

                Dim dt As DataTable = CarregarDataTable("Select Parcelas From ContaReceber Where Codigo = " & strCodigo)
                If dt.Rows.Count > 0 Then
                    strParcela = dt.Rows.Item(0).Item("Parcelas").ToString
                End If
            End If

            If parEstornar = True Then
                'If strParcela.Contains("P") = True Then MsgBox("Não é possível estornar contas parciais!", MsgBoxStyle.Information) : Exit Sub
                If strParcela.Contains("P") = True Then
                    'bolParcial = True
                    'Exit Sub
                End If
            End If

            If strParcela.Contains("P") = False Then
                'Dim strCodCliente As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodCli)
                'Dim strData As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colRecebimento)
                'Dim strCliente As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCliente)
                'Dim strCodConfig As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodConfig)

                Dim strCodCliente As String = Me.grd1.GetRowCellDisplayText(Index, Me.colCodCli)



                Dim dtCli As DataTable = CarregarDataTable("Select Limite from Cliente Where Codigo =" & strCodCliente)

                If dtCli.Rows.Count > 0 Then
                    If dtCli.Rows.Item(0).Item("Limite").ToString.Trim <> "" Then
                        dblLimCred = dtCli.Rows.Item(0).Item("Limite").ToString.Trim
                    Else
                        dblLimCred = -1
                    End If
                End If

                dblLimCred = dblLimCred - dblValPar
                Atualizar("Update Cliente set Limite ='" & dblLimCred.ToString("0.00") & "' where Codigo =" & strCodCliente)

                If strCodOrdem <> "0" Then
                    Dim dt As DataTable = CarregarDataTable("SELECT Codigo, Motivo, Valor FROM CAIXA where Motivo " & _
                    "LIKE '%Venda Nº %' and motivo like '%" & strCodOrdem & "%' and Motivo LIKE '" & strCliente & ", PARCELA%' " & _
                    "and CodConfig = " & strCodConfig & " and Data >= '" & dtData & "' and Data <= '" & dtData.AddDays(1) & "'")

                    If dt.Rows.Count > 0 Then
                        Dim strCodCaixa As String = dt.Rows.Item(0).Item("Codigo").ToString
                        Dim strMotivo As String = dt.Rows.Item(0).Item("Motivo").ToString
                        Dim vetMotivo As Array = Split(strMotivo, ",")

                        strMotivo = vetMotivo(1).ToString.Replace("PARCELA ", "")
                        If strMotivo.Contains("/") = True Then
                            vetMotivo = Split(strMotivo, "DA  Venda Nº ")
                            Dim strMot1 As String = vetMotivo(0).ToString.Trim
                            Dim strmot2 As String = vetMotivo(1).ToString.Trim

                            Dim vetPar As Array = Split(strMot1, "/")
                            Dim vetPed As Array = Split(strmot2, "/")
                            strMot1 = ""
                            strmot2 = ""
                            Dim I As Integer
                            Dim bolJaPassou As Boolean = False
                            For I = 0 To vetPar.Length - 1
                                If vetPed(0) = strCodOrdem And vetPar(I) = strParcela Then
                                    If bolJaPassou = True Then
                                        If strMot1 = "" Then
                                            strMot1 = vetPar(I)
                                            strmot2 = vetPed(I)
                                        Else
                                            strMot1 = strMot1 & "/" & vetPar(I)
                                            strmot2 = strmot2 & "/" & vetPed(0)
                                        End If
                                    End If
                                    bolJaPassou = True
                                Else
                                    If strMot1 = "" Then
                                        strMot1 = vetPar(I)
                                        strmot2 = vetPed(0)
                                    Else
                                        strMot1 = strMot1 & "/" & vetPar(I)
                                        strmot2 = strmot2 & "/" & vetPed(0)
                                    End If
                                End If
                            Next

                            Dim dblValor As Double = dt.Rows.Item(0).Item("Valor").ToString

                            dblValor = dblValor - dblValPar

                            Atualizar("UPDATE Caixa set Motivo = '" & strCliente & ", PARCELA " & strMot1 & " DA  Venda Nº " & strmot2 & "', " & _
                            "Valor = " & Num(dblValor) & " where Codigo = " & strCodCaixa)
                        Else
                            'Excluir("Delete from Caixa where Motivo LIKE '%Venda Nº " & strCodOrdem & "' " & _
                            '    "and Motivo LIKE '%" & strCliente & ", PARCELA%' and CodConfig = " & CodConfig & " and Data = '" & strData & "'")

                            Excluir("Delete from Caixa where Codigo = " & strCodCaixa)

                            Excluir("Delete from Caixa where Motivo LIKE '%TROCO REFERÊNTE A PARCELA%' " & _
                            "and Motivo LIKE '%DA Venda Nº " & strCodOrdem & "%' and CodConfig = " & CodConfig & "  and Data >= '" & dtData & "' and Data <= '" & dtData.AddDays(1) & "'")

                        End If

                    End If


                    'ATUALIZA VALOR EM MOVIMENTO BANCARIO
                    Dim dtBanco As DataTable = CarregarDataTable("SELECT Codigo, Observacao, Valor FROM MovimentoBancario where Observacao " & _
                                "LIKE '%Venda Nº%' and Observacao like '%" & strCliente & "%' and Observacao like '%" & strCodOrdem & "%' and CodConfig = " & strCodConfig & " and Data = '" & strData & "'")

                    If dtBanco.Rows.Count > 0 Then
                        Dim strCodBanco As String = dtBanco.Rows.Item(0).Item("Codigo").ToString
                        Dim strObs As String = dtBanco.Rows.Item(0).Item("Observacao").ToString
                        Dim vetObs As Array = Split(strObs, ",")


                        strObs = vetObs(1).ToString.Replace("PARCELA ", "")

                        If strObs.Contains("P/") = True Then
                            strObs = strObs.Replace("P/", "")
                        End If

                        If strObs.Contains("/") = True Then
                            vetObs = Split(strObs, "DA  Venda Nº ")
                            Dim strMot1 As String = vetObs(0).ToString.Trim
                            Dim strmot2 As String = vetObs(1).ToString.Trim

                            Dim vetPar As Array = Split(strMot1, "/")
                            Dim vetPed As Array = Split(strmot2, "/")
                            strMot1 = ""
                            strmot2 = ""
                            Dim I As Integer
                            Dim bolJaPassou As Boolean = False
                            For I = 0 To vetPar.Length - 1
                                If vetPed(I) = strCodOrdem And vetPar(I) = strParcela Then
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

                            Atualizar("UPDATE MovimentoBancario set Observacao = '" & strCliente & ", PARCELA " & strMot1 & " DA  Venda Nº " & strmot2 & "', " & _
                            "Valor = " & Num(dblValor) & " where Codigo = " & strCodBanco)
                        Else
                            'Dim vetPar As Array = strObs.Split("º")
                            'Excluir("Delete from MovimentoBancario where Observacao LIKE '%" & strObs & "%' " & _
                            '  "and CodConfig = " & CodConfig & " and Data = '" & strData & "'")
                            Excluir("Delete from MovimentoBancario where Codigo = " & strCodBanco)

                        End If

                    End If
                End If
            End If

        End If

        If parEstornar = True Then
            Atualizar("UPDATE ContaReceber set RecebidoOK = 'False' where Codigo = " & strCodigo)

            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES (" & _
           "'" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strAntigo & "','ESTORNADO','CONTA A RECEBER','CONTA A RECEBER','ESTORNO'," & CodConfig & ")")

            'EXCLUIR FUTURO
            ExcluirFuturo(strCodigo)

            'MsgBox("Conta estornada com sucesso!", MsgBoxStyle.Information)
        Else

            Excluir("Delete from ContaReceber where Codigo = " & strCodigo)

            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES (" & _
            "'" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strAntigo & "','EXCLUÍDO','CONTA A RECEBER','CONTA A RECEBER','EXCLUSÃO'," & CodConfig & ")")

            MsgBox("Parcela " & strParcela & " excluida com sucesso!", MsgBoxStyle.Information)
        End If

        'If Me.Tag = "RECEBIDA" Then
        '    AtualizarGrid("RecebidoOK = 'True'")
        'Else
        '    AtualizarGrid("RecebidoOK = 'False'")
        'End If
    End Sub

    Private Sub btnRelVen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelVen.Click
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub

        ImprimirVendaNormal(Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodOrdem), Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodConfig))

    End Sub

    Private Sub btnRemPar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemPar.Click
        If MsgBox("Deseja realmente remover a parcela selecionada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.tdCred.Rows.RemoveAt(Me.grd2.FocusedRowHandle)
        CalcularJuros()
        Me.txtValTotRec.Text = Me.txtComJuros.Text.Trim
    End Sub

    Private Sub txtAlterar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAlterar.KeyPress

        If Me.grd1.FocusedColumn.Name <> Me.colCodOrdem.Name Then Exit Sub

        If IsNumeric(e.KeyChar) = False Then
            If e.KeyChar = vbBack Then Exit Sub
            e.Handled = True
        End If
    End Sub

    Private Sub btnBoleto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoleto.Click


        ' If Me.luePag.EditValue = "BOLETO" Then

        Dim strCodCli As String = intCodCliente
        Dim strParcelas As String = "1"
        Dim strValorTotal As String = Me.txtComJuros.Text

        If MsgBox("Deseja imprimir o boleto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            '4244|CLIENTE|406|2|100,00

            If CobreBemNano = True Then
                If bolAlterado = False Then
                    Dim strCodigoContaReceber As String
                    For I = 0 To Me.grd1.RowCount - 1

                        Dim strBoleto As String = Me.grd1.GetRowCellDisplayText(I, Me.colFormaPagamento)
                        If strBoleto.Contains("BOL") = False Then
                            MsgBox("Forma de pagamento diferente de boleto!", MsgBoxStyle.Information)
                            strCodigoContaReceber = ""
                            Exit Sub
                        End If
                        If I = 0 Then
                            strCodigoContaReceber = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)
                        Else
                            strCodigoContaReceber &= "," & Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)
                        End If
                    Next
                    If strCodigoContaReceber <> "" Then
                        BoletoCobreBem.CobreBem(strCodigoContaReceber, False)
                    End If
                Else

                    If Me.luePag.EditValue.ToString.Contains("BOL") = False Then
                        MsgBox("Forma de pagamento diferente de boleto!", MsgBoxStyle.Information)
                        Exit Sub
                    End If


                    Dim strCodigoContaReceber As String
                    Me.grd2.Columns("CodigoParcela").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
                    Dim strCodConta As String = ""
                    Dim bolBoleto As Boolean = True
                    For I = 0 To Me.grd2.RowCount - 1
                        If I = 0 Then
                            strCodigoContaReceber = Me.grd2.GetRowCellDisplayText(I, Me.colCodigoParcela)
                            strCodConta = Me.grd2.GetRowCellDisplayText(I, Me.colCodigoParcela)
                        Else
                            strCodigoContaReceber &= "," & Me.grd2.GetRowCellDisplayText(I, Me.colCodigoParcela)
                        End If
                        If Me.grd2.GetRowCellDisplayText(I, Me.colPagamento2).Contains("BOL") = False Then
                            bolBoleto = False
                        End If
                    Next
                    If bolBoleto = False Then
                        If MsgBox("Algumas contas não estão com a forma de pagamento BOLETO. Deseja alterar automaticamente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            For I = 0 To Me.grd2.RowCount - 1
                                Atualizar("UPDATE ContaReceber set Pagamento = 'BOLETO', FormaPagamento = 'A PRAZO' where Codigo = " & Me.grd2.GetRowCellDisplayText(I, Me.colCodigoParcela))
                            Next
                        Else
                            Exit Sub
                        End If
                    End If
                    Me.grd2.ClearSorting()
                    If strCodigoContaReceber <> "" Then
                        frmVencBoleto.txtCliente.Text = Me.txtCliente.Text
                        frmVencBoleto.strCodOrdem = Me.txtCodPed.Text
                        frmVencBoleto.strCodigo = strCodConta
                        frmVencBoleto.strCodigoConta = strCodigoContaReceber
                        frmVencBoleto.txtValorConta.Text = Me.txtValTotRec.Text
                        frmVencBoleto.ShowDialog()
                    End If
                End If


            Else
                Dim fluxoTexto As IO.StreamWriter
                If Not System.IO.File.Exists(CaminhoPastaBoleto & "\Boleto\" & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodOrdem) & ".txt") Then

                    Dim strCodigos As String
                    Dim I As Integer


                    Dim strSomado As String = ""
                    Dim strCliente As String = ""
                    Dim strBoleto As String = ""
                    If bolAlterado = False Then



                        strSomado = "DETALHADO"
                        For I = 0 To Me.grd1.RowCount - 1

                            strBoleto = Me.grd1.GetRowCellDisplayText(I, Me.colFormaPagamento)
                            If strBoleto.Contains("BOLETO") = False Then
                                MsgBox("Forma de pagamento diferente de boleto!", MsgBoxStyle.Information)
                                strCodigos = ""
                                Exit Sub
                            End If
                            If I = 0 Then
                                strCodCli = Me.grd1.GetRowCellDisplayText(I, Me.colCodCli)
                                strCliente = Me.grd1.GetRowCellDisplayText(I, Me.colCodCli)
                                strCodigos = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)
                            Else
                                strCliente = Me.grd1.GetRowCellDisplayText(I, Me.colCodCli)
                                strCodigos &= "," & Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)
                            End If

                            'If strCodCli <> strCliente Then
                            '    MsgBox("Não é possível gerar boleto de clientes deiferentes!", MsgBoxStyle.Information)
                            '    strCodigos = ""
                            '    Exit Sub
                            'End If
                        Next
                    Else
                        If Me.luePag.EditValue.ToString.Contains("BOLETO") = False Then
                            MsgBox("Forma de pagamento diferente de boleto!", MsgBoxStyle.Information)
                            Exit Sub
                        End If
                        strSomado = "SOMADO"
                        For I = 0 To Me.grd2.RowCount - 1
                            If I = 0 Then
                                strCodigos = Me.grd2.GetRowCellDisplayText(I, Me.colCodigoParcela)
                            Else
                                strCodigos &= "," & Me.grd2.GetRowCellDisplayText(I, Me.colCodigoParcela)
                            End If
                        Next
                    End If



                    System.IO.File.Create(CaminhoPastaBoleto & "\Boleto\" & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodOrdem) & ".txt").Dispose()

                    fluxoTexto = New IO.StreamWriter(CaminhoPastaBoleto & "\Boleto\" & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodOrdem) & ".txt")


                    fluxoTexto.Write("")
                    fluxoTexto.Write(strCodigos & "|CLIENTE|" & strCodCli & "|" & strParcelas & "|" & strValorTotal & "|RECEBER ALTERACAO|" & strSomado)
                    fluxoTexto.Close()
                End If
                Dim strLogin As String = LerArquivo(CaminhoPastaBoleto & "\Arquivos\Login.txt", True)

                fluxoTexto = New IO.StreamWriter(CaminhoPastaBoleto & "\Arquivos\Login.txt")

                fluxoTexto.Write("")
                fluxoTexto.Write(Login & "|" & Senha & "|000")
                fluxoTexto.Close()
                System.Diagnostics.Process.Start(CaminhoPastaBoleto & "\Debug\NanoBoleto.exe")
            End If

        End If

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
        grd1.FocusedColumn = Me.colCodOrdem
        grd1.ShowEditor()
    End Sub

    Private Sub btnCenCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCenCus.Click
        Dim frm As New frmGrupo
        frm.Tag = "CENTROCUSTO"
        frm.ShowDialog()
        Me.cboCenCus.Properties.Items.Clear()
        PreencherGrupoSetorCusto("C", Me.cboCenCus)
        Me.cboCenCus.Focus()
    End Sub

    Private Sub lblCenCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dtVenc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtVenc.GotFocus
        If Me.dtVenc.Text = "" Then
            Me.dtVenc.EditValue = Date.Today
        End If
    End Sub

    Private Sub btnSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSel.Click
        Dim I As Integer
        Dim intCodCliPri, intCodCliLinha As Integer

        intCodCliPri = Me.grd1.GetRowCellValue(0, Me.colCodCli)

        For I = 0 To Me.grd1.RowCount - 1
            intCodCliLinha = Me.grd1.GetRowCellValue(I, Me.colCodCli)

            If intCodCliPri <> intCodCliLinha Then
                MsgBox("Não é possivel selecionar várias parcelas se o cliente for diferente!", MsgBoxStyle.Information)
                Exit Sub
            End If
        Next

        For I = 0 To Me.grd1.RowCount - 1
            Alterar(I)
        Next
    End Sub
End Class