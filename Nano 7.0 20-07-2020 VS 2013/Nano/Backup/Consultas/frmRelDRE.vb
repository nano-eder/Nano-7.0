Imports Nano.clsFuncoes

Imports System.IO.Packaging
Imports System.Net.mail
Imports System.Net.Mime
Imports System.IO.Compression
Public Class frmRelDRE

    Dim strFiltro As String = ""

    Private Sub CarregarRel()
        If TesteConexao() = False Then Exit Sub
        Dim data1, data2 As String
        data1 = dtInicial.EditValue
        data2 = dtFinal.EditValue


        If Master = False Then
            strFiltro = " and CodConfig = " & CodConfig
        Else
            Try
                If Me.lueLoja.EditValue.ToString <> "" Then
                    strFiltro = " and CodConfig = " & Me.lueLoja.EditValue
                Else
                    strFiltro = " and CodConfig = " & CodConfig
                End If
            Catch ex As Exception
                strFiltro = "" '" and CodConfig = " & CodConfig
            End Try
        End If
        If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Sub
        If data2 = "" Then MsgBox("Selecione a Data Final!", MsgBoxStyle.Information) : Exit Sub

        Dim dataFim, dataIni As Date
        dataIni = data1
        dataFim = data2

        If dataIni > dataFim Then MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information) : Exit Sub

        Dim strData As String
        strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro
        strData = strData.Replace("Data", "Total.Data")
        strData = strData.Replace("CodConfig", "Total.CodConfig")


        Dim rel As New relDRE
        rel.picLogo.Image = LogoTipo


        '1. CARREGAR VENDAS
        Dim dtVenda As DataTable = CarregarDataTable("Select '1.' + Convert(Varchar(100),Grupo.Codigo) + ' - RECEITA COM VENDAS DE ' + Produto.Grupo as 'GRUPO', Case When Convert(varchar(100), Fornecedor.Codigo) is not null Then Convert(varchar(100),Fornecedor.Codigo) Else '' End as Documento, Produto.Fabricante as 'Razao', Sum(Pedido.ValorTotal) as 'TOTAL' From (((Pedido Left Join Produto On Pedido.codProd = Produto.codigo) Left Join Total On Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig) Left Join Grupo On Produto.Grupo = Grupo.Nome) Left Join Fornecedor On Produto.Fabricante = Fornecedor.Nome Where  " & strData & " Group by Grupo.Codigo, Produto.Grupo, Fornecedor.Codigo, Produto.Fabricante Order by Grupo.Codigo asc")

        If dtVenda.Rows.Count > 0 Then
            For I As Integer = 0 To dtVenda.Rows.Count - 1

                Dim Grupo As String = dtVenda.Rows.Item(I).Item("Grupo").ToString
                Dim Razao As String = dtVenda.Rows.Item(I).Item("Razao").ToString
                Dim Total As String = dtVenda.Rows.Item(I).Item("Total").ToString
                Dim Doc As String = dtVenda.Rows.Item(I).Item("Documento").ToString


                rel.tbFor.Rows.Add()
                rel.tbFor.Rows.Item(rel.tbFor.Rows.Count - 1).Item("Grupo") = Grupo
                rel.tbFor.Rows.Item(rel.tbFor.Rows.Count - 1).Item("Fornecedor") = Razao
                rel.tbFor.Rows.Item(rel.tbFor.Rows.Count - 1).Item("Total") = Total
                rel.tbFor.Rows.Item(rel.tbFor.Rows.Count - 1).Item("Documento") = Doc

            Next
        End If

        '1. CALCULAR VENDAS
        Dim dblTot As Double = 0
        Dim Result As Double = 0
        For I As Integer = 0 To rel.tbFor.Rows.Count - 1

            dblTot = rel.tbFor.Rows.Item(I).Item("Total").ToString
            Result = Result + dblTot

        Next
        rel.XrLabel1.Text = "Total Calculo Vendas R$ " & Result.ToString("###,###,##0.00")


        '2. CARREGAR CONTAS VARIAVEIS
        Dim strFiltroEmpresa As String = ""

        If CNPJEmpresa = "26455835000120" Then
            strFiltroEmpresa = " and TipoConta <> 'PRODUTO PARA REVENDA'"
        End If

        strData = strData.Replace("Total.Data ", "ContaPagar.DataPagamento")
        strData = strData.Replace("Total.CodConfig", "ContaPagar.CodConfig")

        Dim dtContaV As DataTable = CarregarDataTable("Select ContaPagar.TipoConta, NumeroDocumento, Fornecedor.Nome, Vencimento, sum(ValorPago) as Valor, DataPagamento, ContaPagar.Data From Contapagar Left Join Fornecedor On ContaPagar.CodFor = Fornecedor.Codigo Where TipoConta <> 'INVESTIMENTO' and Tipoconta <> 'RETIRADA DE LUCROS' " & strFiltroEmpresa & " And TipoCusto = 'V' And " & strData & " and PagoOK='true' Group by TipoConta, Fornecedor.Nome, DataPagamento, Vencimento, NumeroDocumento, ContaPagar.Data")

        If dtContaV.Rows.Count > 0 Then
            For I As Integer = 0 To dtContaV.Rows.Count - 1

                Dim TipoConta As String = dtContaV.Rows.Item(I).Item("TipoConta").ToString
                Dim NumeroDocumento As String = dtContaV.Rows.Item(I).Item("NumeroDocumento").ToString
                Dim Nome As String = dtContaV.Rows.Item(I).Item("Nome").ToString
                Dim Vencimento As String = dtContaV.Rows.Item(I).Item("Vencimento").ToString.Replace(" 00:00:00", "")
                Dim Valor As String = dtContaV.Rows.Item(I).Item("Valor").ToString
                'Dim DataPagamento As String = dtContaV.Rows.Item(I).Item("DataPagamento").ToString.Replace(" 00:00:00", "")
                Dim Data As String = dtContaV.Rows.Item(I).Item("Data").ToString.Replace(" 00:00:00", "")

                rel.tbContaV.Rows.Add()
                rel.tbContaV.Rows.Item(rel.tbContaV.Rows.Count - 1).Item("TipoConta") = TipoConta
                rel.tbContaV.Rows.Item(rel.tbContaV.Rows.Count - 1).Item("NumeroDocumento") = NumeroDocumento
                rel.tbContaV.Rows.Item(rel.tbContaV.Rows.Count - 1).Item("Nome") = Nome
                rel.tbContaV.Rows.Item(rel.tbContaV.Rows.Count - 1).Item("Vencimento") = Vencimento
                rel.tbContaV.Rows.Item(rel.tbContaV.Rows.Count - 1).Item("Valor") = Valor
                rel.tbContaV.Rows.Item(rel.tbContaV.Rows.Count - 1).Item("DataPagamento") = Data

            Next
        End If

        If CNPJEmpresa = "26455835000120" Then
            strData = strData.Replace("ContaPagar.DataPagamento", "Total.Data")
            strData = strData.Replace("ContaPagar.CodConfig", "Total.CodConfig")

            Dim dtVendaCusto As DataTable = CarregarDataTable("Select 'PRODUTO PARA REVENDA' as TipoConta, Sum(Pedido.Custo) as Valor From Pedido Left Join Total On Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig Where  " & strData)

            If dtVendaCusto.Rows.Count > 0 Then
                For I As Integer = 0 To dtVendaCusto.Rows.Count - 1

                    Dim TipoConta As String = dtVendaCusto.Rows.Item(I).Item("TipoConta").ToString
                    Dim NumeroDocumento As String = ""
                    Dim Nome As String = ""
                    Dim Vencimento As String = ""
                    Dim Valor As String = dtVendaCusto.Rows.Item(I).Item("Valor").ToString
                    'Dim DataPagamento As String = dtContaV.Rows.Item(I).Item("DataPagamento").ToString.Replace(" 00:00:00", "")
                    Dim Data As String = ""

                    rel.tbContaV.Rows.Add()
                    rel.tbContaV.Rows.Item(rel.tbContaV.Rows.Count - 1).Item("TipoConta") = TipoConta
                    rel.tbContaV.Rows.Item(rel.tbContaV.Rows.Count - 1).Item("NumeroDocumento") = NumeroDocumento
                    rel.tbContaV.Rows.Item(rel.tbContaV.Rows.Count - 1).Item("Nome") = Nome
                    rel.tbContaV.Rows.Item(rel.tbContaV.Rows.Count - 1).Item("Vencimento") = Vencimento
                    rel.tbContaV.Rows.Item(rel.tbContaV.Rows.Count - 1).Item("Valor") = Valor
                    rel.tbContaV.Rows.Item(rel.tbContaV.Rows.Count - 1).Item("DataPagamento") = Data
                Next
            End If
        End If
        

        '2. CALCULAR CONTAS VARIAVEIS
        Dim dblTotContaV As Double = 0
        Dim ResultContaV As Double = 0
        For I As Integer = 0 To rel.tbContaV.Rows.Count - 1

            dblTotContaV = rel.tbContaV.Rows.Item(I).Item("Valor").ToString
            ResultContaV = ResultContaV + dblTotContaV

        Next
        rel.XrLabel2.Text = "Total Custo Variável R$ " & ResultContaV.ToString("###,###,##0.00")


        '3. CALCULAR MARGEM DE CONTRIBUIÇÃO
        Dim ResultMargem As Double = 0
        ResultMargem = Result - ResultContaV
        rel.XrLabel5.Text = "Total Margem R$ " & ResultMargem.ToString("###,###,##0.00")


        '4. CARREGAR CONTAS FIXAS
        strData = strData.Replace("Total.Data", "ContaPagar.DataPagamento")
        strData = strData.Replace("Total.CodConfig", "ContaPagar.CodConfig")
        Dim dtContaF As DataTable = CarregarDataTable("Select ContaPagar.TipoConta, NumeroDocumento, Fornecedor.Nome, Vencimento, sum(ValorPago) as Valor, DataPagamento, ContaPagar.Data From Contapagar Left Join Fornecedor On ContaPagar.CodFor = Fornecedor.Codigo Where TipoConta <> 'INVESTIMENTO' and Tipoconta <> 'RETIRADA DE LUCROS' And TipoCusto = 'F' And " & strData & " and PagoOk='true' Group by TipoConta, Fornecedor.Nome, DataPagamento, Vencimento, NumeroDocumento, ContaPagar.Data")

        If dtContaF.Rows.Count > 0 Then
            For I As Integer = 0 To dtContaF.Rows.Count - 1

                Dim TipoConta As String = dtContaF.Rows.Item(I).Item("TipoConta").ToString
                Dim NumeroDocumento As String = dtContaF.Rows.Item(I).Item("NumeroDocumento").ToString
                Dim Nome As String = dtContaF.Rows.Item(I).Item("Nome").ToString
                Dim Vencimento As String = dtContaF.Rows.Item(I).Item("Vencimento").ToString.Replace(" 00:00:00", "")
                Dim Valor As String = dtContaF.Rows.Item(I).Item("Valor").ToString
                'Dim DataPagamento As String = dtContaF.Rows.Item(I).Item("DataPagamento").ToString.Replace(" 00:00:00", "")
                Dim Data As String = dtContaF.Rows.Item(I).Item("Data").ToString.Replace(" 00:00:00", "")

                rel.tbContaF.Rows.Add()
                rel.tbContaF.Rows.Item(rel.tbContaF.Rows.Count - 1).Item("TipoContaF") = TipoConta
                rel.tbContaF.Rows.Item(rel.tbContaF.Rows.Count - 1).Item("NumeroDocumentoF") = NumeroDocumento
                rel.tbContaF.Rows.Item(rel.tbContaF.Rows.Count - 1).Item("NomeF") = Nome
                rel.tbContaF.Rows.Item(rel.tbContaF.Rows.Count - 1).Item("VencimentoF") = Vencimento
                rel.tbContaF.Rows.Item(rel.tbContaF.Rows.Count - 1).Item("ValorF") = Valor
                rel.tbContaF.Rows.Item(rel.tbContaF.Rows.Count - 1).Item("DataPagamentoF") = Data

            Next
        End If

        '4. CALCULAR CONTAS FIXAS
        Dim dblTotContaF As Double = 0
        Dim ResultContaF As Double = 0
        For I As Integer = 0 To rel.tbContaF.Rows.Count - 1

            dblTotContaF = rel.tbContaF.Rows.Item(I).Item("ValorF").ToString
            ResultContaF = ResultContaF + dblTotContaF

        Next
        rel.XrLabel6.Text = "Total Custo Fixo R$ " & ResultContaF.ToString("###,###,##0.00")


        '5. CALCULAR LUCRO OPERACIONAL
        Dim ResultLucro As Double = 0
        ResultLucro = ResultMargem - ResultContaF
        rel.XrLabel9.Text = "Total Lucro R$ " & ResultLucro.ToString("###,###,##0.00")



        '6. RECEITAS NÃO OPERACIONAIS
        strData = strData.Replace("ContaPagar.DataPagamento", "Data")
        strData = strData.Replace("ContaPagar.CodConfig", "MovimentoBancario.CodConfig")
        Dim dtReceitas As DataTable = CarregarDataTable("Select MovimentoBancario.Observacao, Banco.Codigo, Banco.NomeBanco, MovimentoBancario.Data, sum(MovimentoBancario.Valor) as Valor From MovimentoBancario left join Banco on MovimentoBancario.CodBanco = Banco.Codigo Where " & strData & " And TipoMovimento='RECEITAS' Group By MovimentoBancario.Observacao, MovimentoBancario.Data, Banco.Codigo, Banco.NomeBanco")

        If dtReceitas.Rows.Count > 0 Then
            For I As Integer = 0 To dtReceitas.Rows.Count - 1

                Dim TipoConta As String = dtReceitas.Rows.Item(I).Item("Observacao").ToString
                Dim NumeroDocumento As String = dtReceitas.Rows.Item(I).Item("Codigo").ToString
                Dim Nome As String = dtReceitas.Rows.Item(I).Item("NomeBanco").ToString
                Dim Vencimento As String = dtReceitas.Rows.Item(I).Item("Data").ToString.Replace(" 00:00:00", "")
                Dim Valor As String = dtReceitas.Rows.Item(I).Item("Valor").ToString


                rel.tbReceitas.Rows.Add()
                rel.tbReceitas.Rows.Item(rel.tbReceitas.Rows.Count - 1).Item("Observacao") = TipoConta
                rel.tbReceitas.Rows.Item(rel.tbReceitas.Rows.Count - 1).Item("Codigo") = NumeroDocumento
                rel.tbReceitas.Rows.Item(rel.tbReceitas.Rows.Count - 1).Item("NomeBanco") = Nome
                rel.tbReceitas.Rows.Item(rel.tbReceitas.Rows.Count - 1).Item("Data") = Vencimento
                rel.tbReceitas.Rows.Item(rel.tbReceitas.Rows.Count - 1).Item("Valor") = Valor

            Next
        End If

        '6. CALCULO RECEITAS NÃO OPERACIONAIS
        Dim dblReceitas As Double = 0
        Dim ResultReceitas As Double = 0
        For I As Integer = 0 To rel.tbReceitas.Rows.Count - 1

            dblReceitas = rel.tbReceitas.Rows.Item(I).Item("Valor").ToString
            ResultReceitas = ResultReceitas + dblReceitas

        Next
        rel.XrLabel11.Text = "Total Receitas Não Operacionais R$ " & ResultReceitas.ToString("###,###,##0.00")



        '7. DESPESAS NÃO OPERACIONAIS
        'strData = strData.Replace("Data ", "Vencimento")
        'strData = strData.Replace("MovimentoBancario.CodConfig", "ContaPagar.CodConfig")
        strData = strData.Replace("ContaPagar.DataPagamento", "Data")
        strData = strData.Replace("ContaPagar.CodConfig", "MovimentoBancario.CodConfig")
        Dim dtDespesas As DataTable = CarregarDataTable("Select MovimentoBancario.Observacao, Banco.Codigo, Banco.NomeBanco, MovimentoBancario.Data, sum(MovimentoBancario.Valor) as Valor From MovimentoBancario left join Banco on MovimentoBancario.CodBanco = Banco.Codigo Where " & strData & " And TipoMovimento='DESPESAS' Group By MovimentoBancario.Observacao, MovimentoBancario.Data, Banco.Codigo, Banco.NomeBanco")

        If dtDespesas.Rows.Count > 0 Then
            For I As Integer = 0 To dtDespesas.Rows.Count - 1

                Dim TipoConta As String = dtDespesas.Rows.Item(I).Item("Observacao").ToString
                Dim NumeroDocumento As String = dtDespesas.Rows.Item(I).Item("Codigo").ToString
                Dim Nome As String = dtDespesas.Rows.Item(I).Item("NomeBanco").ToString
                Dim Vencimento As String = dtDespesas.Rows.Item(I).Item("Data").ToString.Replace(" 00:00:00", "")
                Dim Valor As String = dtDespesas.Rows.Item(I).Item("Valor").ToString


                rel.tbDespesas.Rows.Add()
                rel.tbDespesas.Rows.Item(rel.tbDespesas.Rows.Count - 1).Item("Observacao") = TipoConta
                rel.tbDespesas.Rows.Item(rel.tbDespesas.Rows.Count - 1).Item("Codigo") = NumeroDocumento
                rel.tbDespesas.Rows.Item(rel.tbDespesas.Rows.Count - 1).Item("NomeBanco") = Nome
                rel.tbDespesas.Rows.Item(rel.tbDespesas.Rows.Count - 1).Item("Data") = Vencimento
                rel.tbDespesas.Rows.Item(rel.tbDespesas.Rows.Count - 1).Item("Valor") = Valor

            Next
        End If

        '7. CALCULO DESPESAS NÃO OPERACIONAIS
        Dim dblDespesas As Double = 0
        Dim ResultDespesas As Double = 0
        For I As Integer = 0 To rel.tbDespesas.Rows.Count - 1

            dblDespesas = rel.tbDespesas.Rows.Item(I).Item("Valor").ToString
            ResultDespesas = ResultDespesas + dblDespesas

        Next
        rel.XrLabel14.Text = "Total Despesas Não Operacionais R$ " & ResultDespesas.ToString("###,###,##0.00")



        '8. INVESTIMENTOS
        'strData = strData.Replace("Total.Data ", "Vencimento")
        'strData = strData.Replace("Total.CodConfig", "ContaPagar.CodConfig")
        strData = strData.Replace("Data", "ContaPagar.DataPagamento")
        strData = strData.Replace("MovimentoBancario.CodConfig", "ContaPagar.CodConfig")
        Dim dtInvest As DataTable = CarregarDataTable("Select ContaPagar.TipoConta, NumeroDocumento, Fornecedor.Nome, Vencimento, sum(ValorPago) as Valor, DataPagamento, ContaPagar.Data From Contapagar Left Join Fornecedor On ContaPagar.CodFor = Fornecedor.Codigo Where TipoConta='INVESTIMENTO' And " & strData & " and PagoOK='true' Group by TipoConta, Fornecedor.Nome, DataPagamento, Vencimento, NumeroDocumento, ContaPagar.Data")

        If dtInvest.Rows.Count > 0 Then
            For I As Integer = 0 To dtInvest.Rows.Count - 1

                Dim TipoConta As String = dtInvest.Rows.Item(I).Item("TipoConta").ToString
                Dim NumeroDocumento As String = dtInvest.Rows.Item(I).Item("NumeroDocumento").ToString
                Dim Nome As String = dtInvest.Rows.Item(I).Item("Nome").ToString
                Dim Vencimento As String = dtInvest.Rows.Item(I).Item("Vencimento").ToString.Replace(" 00:00:00", "")
                Dim Valor As String = dtInvest.Rows.Item(I).Item("Valor").ToString
                'Dim DataPagamento As String = dtInvest.Rows.Item(I).Item("DataPagamento").ToString.Replace(" 00:00:00", "")
                Dim Data As String = dtInvest.Rows.Item(I).Item("Data").ToString.Replace(" 00:00:00", "")

                rel.tbInvest.Rows.Add()
                rel.tbInvest.Rows.Item(rel.tbInvest.Rows.Count - 1).Item("TipoConta") = TipoConta
                rel.tbInvest.Rows.Item(rel.tbInvest.Rows.Count - 1).Item("NumeroDocumento") = NumeroDocumento
                rel.tbInvest.Rows.Item(rel.tbInvest.Rows.Count - 1).Item("Nome") = Nome
                rel.tbInvest.Rows.Item(rel.tbInvest.Rows.Count - 1).Item("Vencimento") = Vencimento
                rel.tbInvest.Rows.Item(rel.tbInvest.Rows.Count - 1).Item("Valor") = Valor
                rel.tbInvest.Rows.Item(rel.tbInvest.Rows.Count - 1).Item("DataPagamento") = Data

            Next
        End If

        '8. CALCULO INVESTIMENTOS
        Dim dblInvest As Double = 0
        Dim ResultInvest As Double = 0
        For I As Integer = 0 To rel.tbInvest.Rows.Count - 1

            dblInvest = rel.tbInvest.Rows.Item(I).Item("Valor").ToString
            ResultInvest = ResultInvest + dblInvest

        Next
        rel.XrLabel16.Text = "Total Investimentos R$ " & ResultInvest.ToString("###,###,##0.00")



        '9. RETIRADAS DE LUCRO
        'strData = strData.Replace("Total.Data ", "Vencimento")
        'strData = strData.Replace("Total.CodConfig", "ContaPagar.CodConfig")
        'strData = strData.Replace("Data", "Data")
        strData = strData.Replace("MovimentoBancario.CodConfig", "ContaPagar.CodConfig")
        Dim dtRLucros As DataTable = CarregarDataTable("Select ContaPagar.TipoConta, NumeroDocumento, Fornecedor.Nome, Vencimento, sum(ValorParcela) as Valor, DataPagamento, ContaPagar.Data From Contapagar Left Join Fornecedor On ContaPagar.CodFor = Fornecedor.Codigo Where TipoConta='RETIRADA DE LUCROS' And " & strData & " Group by TipoConta, Fornecedor.Nome, DataPagamento, Vencimento, NumeroDocumento, ContaPagar.Data")

        If dtRLucros.Rows.Count > 0 Then
            For I As Integer = 0 To dtRLucros.Rows.Count - 1

                Dim TipoConta As String = dtRLucros.Rows.Item(I).Item("TipoConta").ToString
                Dim NumeroDocumento As String = dtRLucros.Rows.Item(I).Item("NumeroDocumento").ToString
                Dim Nome As String = dtRLucros.Rows.Item(I).Item("Nome").ToString
                Dim Vencimento As String = dtRLucros.Rows.Item(I).Item("Vencimento").ToString.Replace(" 00:00:00", "")
                Dim Valor As String = dtRLucros.Rows.Item(I).Item("Valor").ToString
                'Dim DataPagamento As String = dtRLucros.Rows.Item(I).Item("DataPagamento").ToString.Replace(" 00:00:00", "")
                Dim Data As String = dtRLucros.Rows.Item(I).Item("Data").ToString.Replace(" 00:00:00", "")


                rel.tbRLucros.Rows.Add()
                rel.tbRLucros.Rows.Item(rel.tbRLucros.Rows.Count - 1).Item("TipoConta") = TipoConta
                rel.tbRLucros.Rows.Item(rel.tbRLucros.Rows.Count - 1).Item("NumeroDocumento") = NumeroDocumento
                rel.tbRLucros.Rows.Item(rel.tbRLucros.Rows.Count - 1).Item("Nome") = Nome
                rel.tbRLucros.Rows.Item(rel.tbRLucros.Rows.Count - 1).Item("Vencimento") = Vencimento
                rel.tbRLucros.Rows.Item(rel.tbRLucros.Rows.Count - 1).Item("Valor") = Valor
                rel.tbRLucros.Rows.Item(rel.tbRLucros.Rows.Count - 1).Item("DataPagamento") = Data

            Next
        End If

        '9. CALCULO RETIRADAS DE LUCRO
        Dim dblRLucros As Double = 0
        Dim ResultRLucros As Double = 0
        For I As Integer = 0 To rel.tbRLucros.Rows.Count - 1

            dblRLucros = rel.tbRLucros.Rows.Item(I).Item("Valor").ToString
            ResultRLucros = ResultRLucros + dblRLucros

        Next
        rel.XrLabel18.Text = "Total Retiradas de Lucro R$ " & ResultRLucros.ToString("###,###,##0.00")


        '10. CALCULAR LUCRO LÍQUIDO
        Dim ResultLucroL As Double = 0
        ResultLucroL = ResultLucro + ResultReceitas - ResultInvest - ResultRLucros - ResultDespesas
        rel.XrLabel22.Text = "Total Lucro Líquido R$ " & ResultLucroL.ToString("###,###,##0.00")


        ''11. CALCULAR PONTO DE EQUILIBRIO
        'Dim ResultPonto As Double = 0
        ''ResultPonto = ResultLucro + ResultReceitas - ResultInvest - ResultRLucros - ResultDespesas
        'rel.XrLabel23.Text = "Total Lucro Líquido R$ " & ResultPonto.ToString("###,###,##0.00")


        ''12. CALCULAR PONTO DE EQUILIBRIO FINANCEIRO
        'Dim ResultPontoF As Double = 0
        ''ResultPontoF = ResultLucro + ResultReceitas - ResultInvest - ResultRLucros - ResultDespesas
        'rel.XrLabel24.Text = "Total Lucro Líquido R$ " & ResultPontoF.ToString("###,###,##0.00")


        rel.lblDataInicial.Text &= Me.dtInicial.Text
        rel.lblDataFinal.Text &= Me.dtFinal.Text

        rel.ShowPreview()
    End Sub

    Private Sub CarregarRelSomado()
        If TesteConexao() = False Then Exit Sub
        Dim data1, data2 As String
        data1 = dtInicial.EditValue
        data2 = dtFinal.EditValue


        If Master = False Then
            strFiltro = " and CodConfig = " & CodConfig
        Else
            Try
                If Me.lueLoja.EditValue.ToString <> "" Then
                    strFiltro = " and CodConfig = " & Me.lueLoja.EditValue
                Else
                    strFiltro = " and CodConfig = " & CodConfig
                End If
            Catch ex As Exception
                strFiltro = "" '" and CodConfig = " & CodConfig
            End Try
        End If
        If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Sub
        If data2 = "" Then MsgBox("Selecione a Data Final!", MsgBoxStyle.Information) : Exit Sub

        Dim dataFim, dataIni As Date
        dataIni = data1
        dataFim = data2

        If dataIni > dataFim Then MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information) : Exit Sub

        Dim strData As String
        strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro

        Dim rel As New relDRESomado
        rel.picLogo.Image = LogoTipo


        '1. CARREGAR VENDAS
        strData = strData.Replace("Data", "Total.Data")
        strData = strData.Replace("CodConfig", "Total.CodConfig")
        Dim dtVenda As DataTable = CarregarDataTable("Select Case When Sum(ValorTotal) is not null Then Sum(ValorTotal) Else 0 End as 'Total' From Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig Where " & strData & "")

        Dim dblTot As Double = 0

        If dtVenda.Rows.Count > 0 Then
            dblTot = dtVenda.Rows.Item(0).Item("Total").ToString
        End If
        rel.XrLabel1.Text = dblTot.ToString("###,###,##0.00")

        Dim strFiltroEmpresa As String = ""
        If CNPJEmpresa = "26455835000120" Then
            strFiltroEmpresa = " and TipoConta <> 'PRODUTO PARA REVENDA'"
        End If

        '2. CARREGAR CONTAS VARIAVEIS
        strData = strData.Replace("Total.Data ", "ContaPagar.DataPagamento")
        strData = strData.Replace("Total.CodConfig", "ContaPagar.CodConfig")
        Dim dtContaV As DataTable = CarregarDataTable("Select Case When Sum(ValorPago) is not null Then sum(ValorPago) Else 0 End as 'Valor' From Contapagar Where TipoConta <> 'INVESTIMENTO' and Tipoconta <> 'RETIRADA DE LUCROS'  " & strFiltroEmpresa & " And TipoCusto = 'V' And " & strData & " and PagoOk='true'")

        Dim dblTotContaV As Double = 0

        If dtContaV.Rows.Count > 0 Then
            dblTotContaV = dtContaV.Rows.Item(0).Item("Valor").ToString
        End If


        If CNPJEmpresa = "26455835000120" Then
            strData = strData.Replace("ContaPagar.DataPagamento", "Total.Data")
            strData = strData.Replace("ContaPagar.CodConfig", "Total.CodConfig")

            Dim dtVendaCusto As DataTable = CarregarDataTable("Select Case When Sum(Pedido.Custo) is not null Then Sum(Pedido.Custo) else 0 end as Valor From Pedido Left Join Total On Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig Where  " & strData)

            If dtVendaCusto.Rows.Count > 0 Then
                dblTotContaV += dtVendaCusto.Rows.Item(0).Item("Valor").ToString

            End If
        End If

        rel.XrLabel2.Text = dblTotContaV.ToString("###,###,##0.00")


        '3. CALCULAR MARGEM DE CONTRIBUIÇÃO
        Dim ResultMargem As Double = 0
        ResultMargem = dblTot - dblTotContaV
        rel.XrLabel5.Text = ResultMargem.ToString("###,###,##0.00")


        '4. CARREGAR CONTAS FIXOS
        strData = strData.Replace("Total.Data", "ContaPagar.DataPagamento")
        strData = strData.Replace("Total.CodConfig", "ContaPagar.CodConfig")
        Dim dtContaF As DataTable = CarregarDataTable("Select Case When Sum(ValorPago) is not null Then sum(ValorPago) Else 0 End as 'Valor' From Contapagar Where TipoConta <> 'INVESTIMENTO' and Tipoconta <> 'RETIRADA DE LUCROS' And TipoCusto = 'F' And " & strData & " and PagoOk='true'")

        Dim dblTotContaF As Double = 0

        If dtContaF.Rows.Count > 0 Then
            dblTotContaF = dtContaF.Rows.Item(0).Item("Valor").ToString
        End If
        rel.XrLabel6.Text = dblTotContaF.ToString("###,###,##0.00")


        '5. CALCULAR LUCRO OPERACIONAL
        Dim ResultLucro As Double = 0
        ResultLucro = ResultMargem - dblTotContaF
        rel.XrLabel9.Text = ResultLucro.ToString("###,###,##0.00")


        '6. RECEITAS NÃO OPERACIONAIS
        strData = strData.Replace("ContaPagar.DataPagamento", "Data")
        strData = strData.Replace("ContaPagar.CodConfig", "MovimentoBancario.CodConfig")
        Dim dtReceitas As DataTable = CarregarDataTable("Select Case When Sum(MovimentoBancario.Valor) is not null Then sum(MovimentoBancario.Valor) Else 0 End as 'Valor' From MovimentoBancario Where TipoMovimento='RECEITAS' And " & strData & "")

        Dim dblReceitas As Double = 0

        If dtReceitas.Rows.Count > 0 Then
            dblTotContaF = dtReceitas.Rows.Item(0).Item("Valor").ToString
        End If
        rel.XrLabel16.Text = dblTotContaF.ToString("###,###,##0.00")


        '7. DESPESAS NÃO OPERACIONAIS
        strData = strData.Replace("ContaPagar.DataPagamento", "Data")
        strData = strData.Replace("ContaPagar.CodConfig", "MovimentoBancario.CodConfig")
        Dim dtDespesas As DataTable = CarregarDataTable("Select Case When Sum(MovimentoBancario.Valor) is not null Then sum(MovimentoBancario.Valor) Else 0 End as 'Valor' From MovimentoBancario Where TipoMovimento='DESPESAS' And " & strData & "")

        Dim dblDespesas As Double = 0

        If dtDespesas.Rows.Count > 0 Then
            dblDespesas = dtDespesas.Rows.Item(0).Item("Valor").ToString
        End If
        rel.XrLabel18.Text = dblDespesas.ToString("###,###,##0.00")


        '8. INVESTIMENTOS
        strData = strData.Replace("Data", "ContaPagar.DataPagamento")
        strData = strData.Replace("MovimentoBancario.CodConfig", "ContaPagar.CodConfig")
        Dim dtInvest As DataTable = CarregarDataTable("Select Case When Sum(ValorPago) is not null Then sum(ValorPago) Else 0 End as 'Valor' From Contapagar Where TipoConta = 'INVESTIMENTO' And " & strData & " and PagoOK='true'")

        Dim dblInvest As Double = 0

        If dtInvest.Rows.Count > 0 Then
            dblInvest = dtInvest.Rows.Item(0).Item("Valor").ToString
        End If
        rel.XrLabel22.Text = dblInvest.ToString("###,###,##0.00")


        '9. CALCULO RETIRADAS DE LUCRO
        'strData = strData.Replace("Data", "ContaPagar.Data")
        strData = strData.Replace("MovimentoBancario.CodConfig", "ContaPagar.CodConfig")
        Dim dtRLucros As DataTable = CarregarDataTable("Select Case When Sum(ValorParcela) is not null Then sum(ValorParcela) Else 0 End as 'Valor' From Contapagar Where Tipoconta = 'RETIRADA DE LUCROS' And " & strData & "")

        Dim dblRLucros As Double = 0

        If dtRLucros.Rows.Count > 0 Then
            dblRLucros = dtRLucros.Rows.Item(0).Item("Valor").ToString
        End If
        rel.XrLabel23.Text = dblRLucros.ToString("###,###,##0.00")


        '10. CALCULAR LUCRO LÍQUIDO
        Dim ResultLucroL As Double = 0
        ResultLucroL = ResultLucro + dblReceitas - dblInvest - dblRLucros - dblDespesas
        rel.XrLabel24.Text = ResultLucroL.ToString("###,###,##0.00")


        rel.lblDataInicial.Text &= Me.dtInicial.Text
        rel.lblDataFinal.Text &= Me.dtFinal.Text

        rel.ShowPreview()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If Me.Tag = "DETALHADO" Then
            CarregarRel()
        ElseIf Me.Tag = "SOMADO" Then
            CarregarRelSomado()
        ElseIf Me.Tag = "CONSULTORIA" Then
            VerificarConsultoria()
        End If
    End Sub

    Private Sub frmRelDRE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarDadosLue("Select Codigo, Descricao from Config", Me.lueLoja)
        If Master = False Then
            Me.lblLoja.Visible = False
            Me.lueLoja.Visible = False
        End If

        If Me.Tag = "DETALHADO" Then
            Me.Text = "Relatório DRE Analítico"
        ElseIf Me.Tag = "SOMADO" Then
            Me.Text = "Relatório DRE Sintético"
        ElseIf Me.Tag = "CONSULTORIA" Then
            Me.Text = "Arquivo Consultoria"
        End If
    End Sub

    Private Sub VerificarConsultoria()
        Dim I As Integer
        Try
            Dim data1, data2 As String
            data1 = dtInicial.EditValue
            data2 = dtFinal.EditValue


            If Master = False Then
                strFiltro = " and Total.CodConfig = " & CodConfig
            Else
                Try
                    If Me.lueLoja.EditValue.ToString <> "" Then
                        strFiltro = " and Total.CodConfig = " & Me.lueLoja.EditValue
                    Else
                        strFiltro = " and Total.CodConfig = " & CodConfig
                    End If
                Catch ex As Exception
                    strFiltro = " and Total.CodConfig = " & CodConfig
                End Try
            End If
            If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Sub
            If data2 = "" Then MsgBox("Selecione a Data Final!", MsgBoxStyle.Information) : Exit Sub

            Dim dataFim, dataIni As Date
            dataIni = data1
            dataFim = data2

            If dataIni > dataFim Then MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information) : Exit Sub

            Dim strData As String = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro

            If IO.File.Exists("C:\NANO\Consultoria\ArquivoConsultoriaP.zip") = True Then
                IO.File.Delete("C:\NANO\Consultoria\ArquivoConsultoriaP.zip")
            End If

            Dim strDataAtual As String = Format(CInt(dataFim.Day), "00") & "-" & Format(CInt(dataFim.Month), "00") & "-" & Format(CInt(dataFim.Year), "0000") & "P"

            If IO.File.Exists("C:\NANO\Consultoria\" & strDataAtual & ".xls") = True Then Exit Sub

            Dim dt As DataTable
         
            dt = CarregarDataTable("SELECT Cliente.Nome as Cliente, Cliente.Telefone, Cliente.Nascimento, " & _
            "Total.Data, Total.Placa, Pedido.Produto, Produto.Tipo as TipoProduto, Pedido.Qtd FROM ((Pedido left join Produto on Pedido.CodProd = Produto.Codigo) left join Total on " & _
            "Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig) left join Cliente on " & _
            "Total.CodCli = Cliente.Codigo where " & strData)

            If dt.Rows.Count > 0 Then
                Dim rel As New relConsultoria
                With rel.tbCon.Rows
                    For I = 0 To dt.Rows.Count - 1
                        .Add()
                        .Item(I).Item("Cliente") = dt.Rows.Item(I).Item("Cliente").ToString
                        .Item(I).Item("Telefone") = dt.Rows.Item(I).Item("Telefone").ToString
                        .Item(I).Item("Nascimento") = dt.Rows.Item(I).Item("Nascimento").ToString
                        .Item(I).Item("Data") = dt.Rows.Item(I).Item("Data").ToString
                        .Item(I).Item("Placa") = dt.Rows.Item(I).Item("Placa").ToString
                        .Item(I).Item("Produto") = dt.Rows.Item(I).Item("Produto").ToString
                        .Item(I).Item("TipoProduto") = dt.Rows.Item(I).Item("TipoProduto").ToString
                        .Item(I).Item("Qtd") = dt.Rows.Item(I).Item("Qtd").ToString
                    Next
                    rel.ExportToXls("C:\NANO\Consultoria\" & strDataAtual & ".xls")
                End With
            End If


            Dim zipPath As String = "C:\NANO\Consultoria\ArquivoConsultoriaP.zip"

            If IO.File.Exists(zipPath) = True Then
                IO.File.Delete(zipPath)
            End If

            Dim zip As Package = ZipPackage.Open(zipPath, IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite)
            AddToArchive(zip, "C:\NANO\Consultoria\" & strDataAtual & ".xls")

            zip.Close()

            Dim strServidor As String = ""
            Dim strEmail As String = ""
            Dim strSenha As String = ""
            Dim strPorta As String = ""
            Dim strServico As String = ""
            Dim dtServ As DataTable = CarregarDataTable("SELECT Servidor, Email, Senha, Porta, Servico FROM Email")

            If dtServ.Rows.Count > 0 Then
                strServidor = dtServ.Rows.Item(0).Item("Servidor").ToString
                strEmail = dtServ.Rows.Item(0).Item("Email").ToString
                strSenha = dtServ.Rows.Item(0).Item("Senha").ToString
                strPorta = dtServ.Rows.Item(0).Item("Porta").ToString
                strServico = dtServ.Rows.Item(0).Item("Servico").ToString
                If strServidor = "Servidor" Then
                    Exit Sub
                End If
            End If

            Dim strTexto As String
            Dim vet As Array = Nothing
            Dim relMail As New relMail
            Dim strTeste As String = "{\rtf1\ansi\ansicpg1252\deff0\deflang1046{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}" & _
            "\viewkind4\uc1\pard\f0\fs17 Arquivo Consultoria\par" & _
            "}"

            Dim strChar As String
            For I = 0 To strTeste.Length
                strChar = strTeste.Substring(strTeste.Length - 1)
                strTeste = strTeste.Substring(0, strTeste.Length - 1)
                If strChar = "}" Then
                    Exit For
                End If
            Next

            strTeste = strTeste & " \par" & vbCrLf & "\par" & vbCrLf & "\par" & vbCrLf & "\par" & vbCrLf
            strTeste = strTeste & "Nome do Computador: " & My.Computer.Name & " \par" & vbCrLf
            strTeste = strTeste & "_______________________________________________________________________________________________________________ \par" & vbCrLf
            strTeste = strTeste & " \par" & vbCrLf
            strTeste = strTeste & NomeEmpresa & " \par" & vbCrLf
            strTeste = strTeste & TelefoneEmpresa & " \par" & vbCrLf
            strTeste = strTeste & EnderecoEmpresa & " \par" & vbCrLf
            strTeste = strTeste & " \par" & vbCrLf & "\par" & vbCrLf & "\par" & vbCrLf & "." & vbCrLf & "}"

            relMail.rtMail.Rtf = strTeste

            relMail.ExportToHtml("C:/NANO/Consultoria/MailConsultoria.html")
            strTexto = LerArquivoMail("C:/NANO/Consultoria/MailConsultoria.html")


            Dim vetAnexo(15) As String
            vetAnexo(0) = "C:\NANO\Consultoria\ArquivoConsultoriaP.zip"

            If enviaMensagemEmail(strEmail, strSenha, EmailConsultoria, "", "", "Consultoria " & Date.Today, strTexto, strServidor, "Normal", False, "ARQUIVO", strPorta, strServico, vetAnexo) = True Then
                MsgBox("Arquivo enviado com sucesso!", MsgBoxStyle.Information)
            End If
            Try
                For I = 0 To vetAnexo.Length - 1
                    Dim strArquivo As String = vetAnexo(I)
                    If strArquivo <> "" Then
                        IO.File.Delete("C:\NANO\Consultoria\ArquivoConsultoriaP.zip")
                    End If
                Next
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
        Me.Close()
    End Sub

    Private Sub AddToArchive(ByVal zip As Package, _
                     ByVal fileToAdd As String)

        'Replace spaces with an underscore (_) 
        Dim uriFileName As String = fileToAdd.Replace(" ", "_")

        'A Uri always starts with a forward slash "/" 
        Dim zipUri As String = String.Concat("/", _
                   IO.Path.GetFileName(uriFileName))

        Dim partUri As New Uri(zipUri, UriKind.Relative)
        Dim contentType As String = _
                   Net.Mime.MediaTypeNames.Application.Zip

        'The PackagePart contains the information: 
        ' Where to extract the file when it's extracted (partUri) 
        ' The type of content stream (MIME type):  (contentType) 
        ' The type of compression:  (CompressionOption.Normal)   
        Dim pkgPart As PackagePart = zip.CreatePart(partUri, _
                   contentType, CompressionOption.Normal)

        'Read all of the bytes from the file to add to the zip file 
        Dim bites As Byte() = IO.File.ReadAllBytes(fileToAdd)

        'Compress and write the bytes to the zip file 
        pkgPart.GetStream().Write(bites, 0, bites.Length)

    End Sub
End Class