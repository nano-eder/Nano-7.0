Imports Nano.clsFuncoes
Public Class frmRelLucro
    Dim I As Integer
    Dim strFIltro As String = ""
    Dim strCodigoFuncionario As String = ""
    Private Sub frmRelLucro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "30")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmConTotal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        If TesteConexao() = False Then Exit Sub
        CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja)
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)
        Me.colCodConfig.Visible = Master


        If Master = False Then
            strFIltro = " and Total.CodConfig =" & CodConfig
            CarregarDadosLue2("Select Codigo, Nome from Funcionario where CodConfig =" & CodConfig & " and Ativo ='True'", Me.lueFunc)
        Else
            CarregarDadosLue2("Select Codigo, Nome from Funcionario where Ativo ='True'", Me.lueFunc)
        End If

        If TipoNano <> 5 Then
            strCodigoFuncionario = "Pedido.CodFunc, "
        End If

        Dim strData As String = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", Date.Today.AddDays(-30), Date.Today)
        Me.Text = "Relatório de Lucro"
        If NomeEmpresa.Trim.ToUpper.Contains("RESTAURANTE") = True Then
            strData = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", Date.Today.AddDays(-60), Date.Today)
        End If
        If NomeEmpresa.ToUpper.Contains("CAIRO") = True Then
            CarregarDados("SELECT Total.CodOrdem, (Total.Data + Total.Hora) as Data, Total.CodCli, " & _
            "Convert(Numeric(15,2),Troco) as Troco, Convert(Numeric(15,2),PorDesc) as PorDesc, " & _
            "Convert(Numeric(15,2),ValDesc) as ValDesc, Convert(Numeric(15,2),sum(Pedido.Custo)) as Custo, " & _
            "Convert(Numeric(15,2),sum(Pedido.ValorTotal)) as Total, Convert(Numeric(15,2),sum(Pedido.ValorTotal) - sum(Pedido.Custo)) as Lucro, " & _
            "Cliente.Nome, Total.CodConfig, Pedido.CodFunc, Cliente.Fantasia FROM (Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and " & _
            "Total.CodConfig = Pedido.CodConfig) left join Cliente on Total.CodCli = Cliente.Codigo where " & _
            "Pedido.Devolvido = 'False' and Pedido.TipoItens <> 'CONSUMO' and " & strData & strFIltro & " group by Total.CodOrdem, Total.Data, Total.CodCli, " & _
            "Total.Troco, Total.PorDesc, Total.ValDesc, Cliente.Nome, Total.CodConfig, Total.Hora, Pedido.CodFunc, Cliente.Fantasia", Me.TotalGridControl)
        Else
            'CarregarDados("SELECT Total.CodOrdem, (Total.Data + Total.Hora) as Data, Total.CodCli, " & _
            '"Convert(Numeric(15,2),Troco) as Troco, Convert(Numeric(15,2),PorDesc) as PorDesc, " & _
            '"Convert(Numeric(15,2),ValDesc) as ValDesc, Convert(Numeric(15,2),sum(Pedido.Custo)) as Custo, " & _
            '"Convert(Numeric(15,2),sum(ValorTotal)) as Total, Convert(Numeric(15,2),sum(ValorTotal) - " & _
            '"sum(Pedido.Custo)) as Lucro, Cliente.Nome, Cliente.Fantasia, Total.CodConfig, Pedido.CodFunc, " & _
            '"case when sum(ValorTotal) <= 0 then 0 else case when sum(Pedido.Custo) < = 0 then 0 else " & _
            '"Convert(Numeric(15,2),((sum(ValorTotal) - sum(Pedido.Custo)) / sum(ValorTotal))*100) end end as PorcentagemDesconto " & _
            '"FROM (Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and Total.CodConfig = Pedido.CodConfig) " & _
            '"left join Cliente on Total.CodCli = Cliente.Codigo where Pedido.TipoItens = 'VENDA' and Pedido.Devolvido = 'False' and " & strData & strFIltro & " group by Total.CodOrdem, Total.Data, Total.CodCli, " & _
            '"Total.Troco, Total.PorDesc, Total.ValDesc, Cliente.Nome, Total.CodConfig, Total.Hora, Pedido.CodFunc, Cliente.Fantasia", Me.TotalGridControl)
            If EmiteNFE = False Then
             
                CarregarDados("SELECT Total.CodOrdem, (Total.Data + Total.Hora) as Data, Total.CodCli, " & _
                "Convert(Numeric(15,2),Troco) as Troco,  case when sum(Pedido.ValorTotal) > 0 then Convert(Numeric(15,4),100-((sum(Pedido.ValorTotal)*100)/sum(Pedido.Qtd * Pedido.UniSemDesc)))  else 0 end as  PorDesc, " & _
                "Convert(Numeric(15,2),sum(Pedido.Qtd * Pedido.UniSemDesc) - sum(Pedido.ValorTotal)) as ValDesc, Convert(Numeric(15,2),sum(Pedido.Custo)) as Custo, " & _
                "Convert(Numeric(15,2),sum(ValorTotal)) as Total, Convert(Numeric(15,2),sum(ValorTotal) - " & _
                "sum(Pedido.Custo)) as Lucro, Cliente.Nome, Cliente.Fantasia, Total.CodConfig, " & strCodigoFuncionario & " " & _
                "case when sum(ValorTotal) <= 0 then 0 else case when sum(Pedido.Custo) < = 0 then 0 else " & _
                "Convert(Numeric(15,2),((sum(ValorTotal) - sum(Pedido.Custo)) / sum(ValorTotal))*100) end end " & _
                "as PorcentagemDesconto, (SELECT Top 1 CodOrdens FROM TotalConsig where TotalConsig.CodOrdens = " & _
                "Total.CodPedido and TotalConsig.CodConfig = Total.Codconfig) as NumPed, (SELECT case when " & _
                "sum(ValorTotal) > 0 then sum(ValorTotal) else 0 end " & _
                "from Pedido where Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig and " & _
                "Pedido.TipoItens <> 'SERVIÇO') as Produto, (SELECT case when sum(ValorTotal) > 0 then sum(ValorTotal) else 0 end  from Pedido where " & _
                "Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig and " & _
                "Pedido.TipoItens = 'SERVIÇO') as Servico, Placa, Modelo, sum(case when TipoItens <> 'SERVIÇO' then Pedido.Custo else 0 end) as CustoProduto, Total.TotalFrete, Total.Operador FROM (Total left join Pedido on Total.CodOrdem = " & _
                "Pedido.CodOrdem and Total.CodConfig = Pedido.CodConfig) left join Cliente on Total.CodCli = " & _
                "Cliente.Codigo where Pedido.TipoItens <> 'CONSUMO' and Pedido.Devolvido = 'False' " & _
                "and " & strData & strFIltro & " group by Total.CodOrdem, Total.Data, Total.CodCli, " & _
                "Total.Troco, Total.PorDesc, Total.ValDesc, Cliente.Nome, Total.CodConfig, Total.Hora, " & _
                "" & strCodigoFuncionario & " Cliente.Fantasia, Total.CodPedido, Placa, Modelo, Total.TotalFrete, Total.Operador", Me.TotalGridControl)

            Else
                If TipoDesconto = "ITENS" Then
                    CarregarDados("SELECT Total.CodOrdem, (Total.Data + Total.Hora) as Data, Total.CodCli, " & _
                    "Convert(Numeric(15,2),Troco) as Troco, case when sum(Pedido.ValorTotal) <= 0 then 0 when sum(Pedido.Qtd * Pedido.UniSemDesc) >0 then Convert(Numeric(15,4),100-((sum(Pedido.ValorTotal)*100) / sum(Pedido.Qtd * Pedido.UniSemDesc)))else 0 end as PorDesc, " & _
                    "Convert(Numeric(15,2),sum(Pedido.Qtd * Pedido.UniSemDesc) - sum(Pedido.ValorTotal)) as ValDesc, Convert(Numeric(15,2),sum(Pedido.Custo)) as Custo, " & _
                    "Convert(Numeric(15,2),sum(ValorTotal)) as Total, Convert(Numeric(15,2),sum(ValorTotal) - " & _
                    "sum(Pedido.Custo)) as Lucro, Cliente.Nome, Cliente.Fantasia, Total.CodConfig, " & strCodigoFuncionario & " " & _
                    "case when sum(ValorTotal) <= 0 then 0 else case when sum(Pedido.Custo) < = 0 then 0 else " & _
                    "Convert(Numeric(15,2),((sum(ValorTotal) - sum(Pedido.Custo)) / sum(ValorTotal))*100) end end " & _
                    "as PorcentagemDesconto, (SELECT Top 1 CodOrdens FROM TotalConsig where TotalConsig.CodOrdens = " & _
                    "Total.CodPedido and TotalConsig.CodConfig = Total.Codconfig) as NumPed, (SELECT Top 1 CodOrdem " & _
                    "FROM TotalNfe where TotalNfe.CodOrdem = Total.CodNFe and TotalNfe.CodConfig = Total.Codconfig) " & _
                    "as NumNF, (SELECT case when sum(ValorTotal) > 0 then sum(ValorTotal) else 0 end " & _
                    "from Pedido where Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig and " & _
                    "Pedido.TipoItens <> 'SERVIÇO') as Produto, (SELECT case when sum(ValorTotal) > 0 then sum(ValorTotal) else 0 end  from Pedido where " & _
                    "Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig and " & _
                    "Pedido.TipoItens = 'SERVIÇO') as Servico, Placa, Modelo, sum(case when TipoItens <> 'SERVIÇO' then Pedido.Custo else 0 end) as CustoProduto, Total.TotalFrete, Total.Operador " & _
                    "FROM (Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and Total.CodConfig = Pedido.CodConfig) " & _
                    "left join Cliente on Total.CodCli = Cliente.Codigo where Pedido.TipoItens <> 'CONSUMO' and Pedido.Devolvido = 'False' and " & strData & strFIltro & " group by Total.CodOrdem, Total.Data, Total.CodCli, " & _
                    "Total.Troco, Total.PorDesc, Total.ValDesc, Cliente.Nome, Total.CodConfig, Total.Hora, " & strCodigoFuncionario & " Cliente.Fantasia, Total.CodPedido, Total.CodNFe, Placa, Modelo, Total.TotalFrete, Total.Operador", Me.TotalGridControl)
                Else

                    CarregarDados("SELECT Total.CodOrdem, (Total.Data + Total.Hora) as Data, Total.CodCli, " & _
                    "Convert(Numeric(15,2),Troco) as Troco, Convert(Numeric(15,2),PorDesc) as PorDesc, " & _
                    "Convert(Numeric(15,2),ValDesc) as ValDesc, Convert(Numeric(15,2),sum(Pedido.Custo)) as Custo, " & _
                    "Convert(Numeric(15,2),Total.Total) as Total, Convert(Numeric(15,2),sum(Pedido.ValorTotal)) as TotalSemDesc, Convert(Numeric(15,2),Total.Total - " & _
                    "sum(Pedido.Custo)) as Lucro, Cliente.Nome, Cliente.Fantasia, Total.CodConfig, " & strCodigoFuncionario & " " & _
                    "case when Total.Total <= 0 then 0 else case when sum(Pedido.Custo) < = 0 then 0 else " & _
                    "Convert(Numeric(15,2),((Total.Total - sum(Pedido.Custo)) / Total.Total)*100) end end " & _
                    "as PorcentagemDesconto, (SELECT Top 1 CodOrdens FROM TotalConsig where TotalConsig.CodOrdens = " & _
                    "Total.CodPedido and TotalConsig.CodConfig = Total.Codconfig) as NumPed, (SELECT Top 1 CodOrdem " & _
                    "FROM TotalNfe where TotalNfe.CodOrdem = Total.CodNFe and TotalNfe.CodConfig = Total.Codconfig) " & _
                    "as NumNF, (SELECT case when sum(ValorTotal) > 0 then sum(ValorTotal) else 0 end " & _
                    "from Pedido where Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig and " & _
                    "Pedido.TipoItens <> 'SERVIÇO') as Produto, (SELECT case when sum(ValorTotal) > 0 then sum(ValorTotal) else 0 end  from Pedido where " & _
                    "Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig and " & _
                    "Pedido.TipoItens = 'SERVIÇO') as Servico, Placa, Modelo, sum(case when TipoItens <> 'SERVIÇO' then Pedido.Custo else 0 end) as CustoProduto, Total.TotalFrete, Total.Operador " & _
                    "FROM (Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and Total.CodConfig = Pedido.CodConfig) " & _
                    "left join Cliente on Total.CodCli = Cliente.Codigo where Pedido.TipoItens <> 'CONSUMO' and Pedido.Devolvido = 'False' and " & strData & strFIltro & " group by Total.CodOrdem, Total.Data, Total.CodCli, " & _
                    "Total.Troco, Total.PorDesc, Total.ValDesc, Cliente.Nome, Total.CodConfig, Total.Total,Total.Hora, " & strCodigoFuncionario & " Cliente.Fantasia, Total.CodPedido, Total.CodNFe, Placa, Modelo, Total.TotalFrete, Total.Operador", Me.TotalGridControl)

                    'CarregarDados("SELECT Total.CodOrdem, (Total.Data + Total.Hora) as Data, Total.CodCli, " & _
                    '"Convert(Numeric(15,2),Troco) as Troco, Convert(Numeric(15,2),PorDesc) as PorDesc, " & _
                    '"Convert(Numeric(15,2),ValDesc) as ValDesc, Convert(Numeric(15,2),sum(Pedido.Custo)) as Custo, " & _
                    '"Convert(Numeric(15,2),sum(ValorTotal)) as Total, Convert(Numeric(15,2),sum(ValorTotal) - " & _
                    '"sum(Pedido.Custo)) as Lucro, Cliente.Nome, Cliente.Fantasia, Total.CodConfig, " & strCodigoFuncionario & " " & _
                    '"case when sum(ValorTotal) <= 0 then 0 else case when sum(Pedido.Custo) < = 0 then 0 else " & _
                    '"Convert(Numeric(15,2),((sum(ValorTotal) - sum(Pedido.Custo)) / sum(ValorTotal))*100) end end " & _
                    '"as PorcentagemDesconto, (SELECT Top 1 CodOrdens FROM TotalConsig where TotalConsig.CodOrdens = " & _
                    '"Total.CodPedido and TotalConsig.CodConfig = Total.Codconfig) as NumPed, (SELECT Top 1 CodOrdem " & _
                    '"FROM TotalNfe where TotalNfe.CodOrdem = Total.CodNFe and TotalNfe.CodConfig = Total.Codconfig) " & _
                    '"as NumNF, (SELECT case when sum(ValorTotal) > 0 then sum(ValorTotal) else 0 end " & _
                    '"from Pedido where Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig and " & _
                    '"Pedido.TipoItens <> 'SERVIÇO') as Produto, (SELECT case when sum(ValorTotal) > 0 then sum(ValorTotal) else 0 end  from Pedido where " & _
                    '"Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig and " & _
                    '"Pedido.TipoItens = 'SERVIÇO') as Servico, Placa, Modelo, sum(case when TipoItens <> 'SERVIÇO' then Pedido.Custo else 0 end) as CustoProduto " & _
                    '"FROM (Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and Total.CodConfig = Pedido.CodConfig) " & _
                    '"left join Cliente on Total.CodCli = Cliente.Codigo where Pedido.TipoItens <> 'CONSUMO' and Pedido.Devolvido = 'False' and " & strData & strFIltro & " group by Total.CodOrdem, Total.Data, Total.CodCli, " & _
                    '"Total.Troco, Total.PorDesc, Total.ValDesc, Cliente.Nome, Total.CodConfig, Total.Hora, " & strCodigoFuncionario & " Cliente.Fantasia, Total.CodPedido, Total.CodNFe, Placa, Modelo", Me.TotalGridControl)

                End If


            End If
         

        End If

        Me.RepositoryItemDateEdit1.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.RepositoryItemDateEdit1.EditFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.RepositoryItemDateEdit1.EditMask = "dd/MM/yyyy HH:mm"
        Me.RepositoryItemDateEdit2.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.RepositoryItemDateEdit2.EditFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.RepositoryItemDateEdit2.EditMask = "dd/MM/yyyy HH:mm"

    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Me.txtTot.ResetText()
        Me.txtTotCusto.ResetText()
        Me.txtLucro.ResetText()


        Dim dblResTot, dblTotCusto, dblTotLucro, dblCustoPeca, dblResPro, dblResServ As Double
        With grd1

            For I = 0 To .RowCount - 1
                Dim dblTot, dblCusto, dblLucro, dblCustPec, dblPro, dblServ As Double

                If .GetRowCellDisplayText(I, Me.colProduto) <> "" Then
                    dblPro = .GetRowCellDisplayText(I, Me.colProduto)
                    dblResPro += dblPro
                End If

                If .GetRowCellDisplayText(I, Me.colServico) <> "" Then
                    dblServ = .GetRowCellDisplayText(I, Me.colServico)
                    dblResServ += dblServ
                End If

                If .GetRowCellDisplayText(I, Me.colTotal) <> "" Then
                    dblTot = .GetRowCellDisplayText(I, Me.colTotal)
                    dblResTot += dblTot
                End If


                If .GetRowCellDisplayText(I, Me.colCusto) <> "" Then
                    dblCusto = .GetRowCellDisplayText(I, Me.colCusto)
                    dblTotCusto += dblCusto
                End If

                If .GetRowCellDisplayText(I, Me.colLucro) <> "" Then
                    dblLucro = .GetRowCellDisplayText(I, Me.colLucro)
                    dblTotLucro += dblLucro
                End If
                If .GetRowCellDisplayText(I, Me.colCustoProduto) <> "" Then
                    dblCustPec = .GetRowCellDisplayText(I, Me.colCustoProduto)
                    dblCustoPeca += dblCustPec
                End If
            Next
            Me.txtProduto.Text = dblResPro.ToString("###,###,##0.00")
            Me.txtServico.Text = dblResserv.ToString("###,###,##0.00")
            Me.txtCustoProd.Text = dblCustoPeca.ToString("###,###,##0.00")

            Dim dblLucroPeca As Double = dblResPro - dblCustoPeca
            Me.txtLucroProd.Text = dblLucroPeca.ToString("###,###,##0.00")


            Me.txtTot.Text = dblResTot.ToString("###,###,##0.00")

            Me.txtTotCusto.Text = dblTotCusto.ToString("###,###,##0.00")

            Me.txtLucro.Text = dblTotLucro.ToString("###,###,##0.00")


          
            Dim dblMargem As Double


            If Me.colPorcentagemDesconto.Visible = True Then

                dblMargem = ((dblResTot - dblTotCusto) / dblResTot) * 100

            Else
                dblMargem = (dblTotLucro * 100) / dblTotCusto

            End If
           

            Me.txtPorc.Text = dblMargem.ToString("0.00")
        End With
    End Sub

    Private Sub btnFiltrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFiltrar.ItemClick

        Dim data1, data2 As String
        data1 = dtInicial.EditValue
        data2 = dtFinal.EditValue

        If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Sub
        If data2 = "" Then MsgBox("Selecione a Data Final!", MsgBoxStyle.Information) : Exit Sub

        Dim dataFim, dataIni As Date
        dataIni = data1
        dataFim = data2

        If dataIni > dataFim Then MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information) : Exit Sub

        If TesteConexao() = False Then Exit Sub
        Dim strData As String = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dtFinal.EditValue)
        strData = String.Format("Total.Data + Total.Hora >= '{0:dd/MM/yyyy HH:mm}' AND Total.Data + Total.Hora <= '{1:dd/MM/yyyy HH:mm}'", dtInicial.EditValue, dtFinal.EditValue.ToString.Replace("00:00", "23:59")) & strFIltro

        ' CarregarDados("SELECT CodOrdem, Total.Data, Total.CodCli, Convert(Numeric(15,2),Custo) as Custo, Convert(Numeric(15,2),Total) as Total, Convert(Numeric(15,2),Total - Custo) as Lucro, Cliente.Nome, Total.CodConfig FROM Total, Cliente where Total.CodCli = Cliente.Codigo and " & String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dtFinal.EditValue) & strFIltro, Me.TotalGridControl)
        'CarregarDados("SELECT Total.CodOrdem, (Total.Data + Total.Hora) as Data, Total.CodCli, Convert(Numeric(15,2),Troco) as Troco, Convert(Numeric(15,2),PorDesc) as PorDesc, Convert(Numeric(15,2),ValDesc) as ValDesc, Convert(Numeric(15,2),sum(Pedido.Custo)) as Custo, Convert(Numeric(15,2),sum(ValorTotal)) as Total, Convert(Numeric(15,2),sum(ValorTotal) - sum(Pedido.Custo)) as Lucro, Cliente.Nome, Total.CodConfig FROM (Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and Total.CodConfig = Pedido.CodConfig) left join Cliente on Total.CodCli = Cliente.Codigo where Pedido.Devolvido = 'False' and " & String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dtFinal.EditValue) & strFIltro & " group by Total.CodOrdem, Total.Data, Total.CodCli, Total.Troco, Total.PorDesc, Total.ValDesc, Cliente.Nome, Total.CodConfig, Total.Hora", Me.TotalGridControl)
    

        If NomeEmpresa.ToUpper.Contains("CAIRO") = True Then
            CarregarDados("SELECT Total.CodOrdem, (Total.Data + Total.Hora) as Data, Total.CodCli, " & _
                      "Convert(Numeric(15,2),Troco) as Troco, Convert(Numeric(15,2),PorDesc) as PorDesc, " & _
                      "Convert(Numeric(15,2),ValDesc) as ValDesc, Convert(Numeric(15,2),sum(Pedido.Custo)) as Custo, " & _
                      "Convert(Numeric(15,2),sum(Pedido.ValorTotal)) as Total, Convert(Numeric(15,2),sum(Pedido.ValorTotal) - sum(Pedido.Custo)) as Lucro, " & _
                      "Cliente.Nome, Total.CodConfig, Pedido.CodFunc, Cliente.Fantasia FROM (Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and " & _
                      "Total.CodConfig = Pedido.CodConfig) left join Cliente on Total.CodCli = Cliente.Codigo where " & _
                      "Pedido.Devolvido = 'False' and Pedido.TipoItens <> 'CONSUMO' and " & strData & " group by Total.CodOrdem, Total.Data, Total.CodCli, " & _
                      "Total.Troco, Total.PorDesc, Total.ValDesc, Cliente.Nome, Total.CodConfig, Total.Hora, Pedido.CodFunc, Cliente.Fantasia", Me.TotalGridControl)
        Else
            'CarregarDados("SELECT Total.CodOrdem, (Total.Data + Total.Hora) as Data, Total.CodCli, " & _
            '"Convert(Numeric(15,2),Troco) as Troco, Convert(Numeric(15,2),PorDesc) as PorDesc, " & _
            '"Convert(Numeric(15,2),ValDesc) as ValDesc, Convert(Numeric(15,2),sum(Pedido.Custo)) as Custo, " & _
            '"Convert(Numeric(15,2),sum(ValorTotal)) as Total, Convert(Numeric(15,2),sum(ValorTotal) - " & _
            '"sum(Pedido.Custo)) as Lucro, Cliente.Nome, Cliente.Fantasia, Total.CodConfig, Pedido.CodFunc, " & _
            '"case when sum(ValorTotal) <= 0 then 0 else case when sum(Pedido.Custo) < = 0 then 0 else " & _
            '"Convert(Numeric(15,2),((sum(ValorTotal) - sum(Pedido.Custo)) / sum(ValorTotal))*100) end end as PorcentagemDesconto " & _
            '"FROM (Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and Total.CodConfig = Pedido.CodConfig) " & _
            '"left join Cliente on Total.CodCli = Cliente.Codigo where Pedido.TipoItens = 'VENDA' and Pedido.Devolvido = 'False' and " & strData & strFIltro & " group by Total.CodOrdem, Total.Data, Total.CodCli, " & _
            '"Total.Troco, Total.PorDesc, Total.ValDesc, Cliente.Nome, Total.CodConfig, Total.Hora, Pedido.CodFunc, Cliente.Fantasia", Me.TotalGridControl)
            '        If EmiteNFE = False Then
            '            CarregarDados("SELECT Total.CodOrdem, (Total.Data + Total.Hora) as Data, Total.CodCli, " & _
            '"Convert(Numeric(15,2),Troco) as Troco, Convert(Numeric(15,2),PorDesc) as PorDesc, " & _
            '"Convert(Numeric(15,2),ValDesc) as ValDesc, Convert(Numeric(15,2),sum(Pedido.Custo)) as Custo, " & _
            '"Convert(Numeric(15,2),sum(ValorTotal)) as Total, Convert(Numeric(15,2),sum(ValorTotal) - " & _
            '"sum(Pedido.Custo)) as Lucro, Cliente.Nome, Cliente.Fantasia, Total.CodConfig, Pedido.CodFunc, " & _
            '"case when sum(ValorTotal) <= 0 then 0 else case when sum(Pedido.Custo) < = 0 then 0 else " & _
            '"Convert(Numeric(15,2),((sum(ValorTotal) - sum(Pedido.Custo)) / sum(ValorTotal))*100) end end as PorcentagemDesconto, " & _
            '"(SELECT Top 1 CodOrdens FROM TotalConsig where TotalConsig.CodOrdens = Total.CodPedido and TotalConsig.CodConfig = Total.Codconfig) as NumPed, sum(case when TipoItens <> 'SERVIÇO' then Pedido.Custo else 0 end) as CustoProduto " & _
            '"FROM (Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and Total.CodConfig = Pedido.CodConfig) " & _
            '"left join Cliente on Total.CodCli = Cliente.Codigo where Pedido.TipoItens <> 'CONSUMO' and Pedido.Devolvido = 'False' and " & strData & strFIltro & " group by Total.CodOrdem, Total.Data, Total.CodCli, " & _
            '"Total.Troco, Total.PorDesc, Total.ValDesc, Cliente.Nome, Total.CodConfig, Total.Hora, Pedido.CodFunc, Cliente.Fantasia, Total.CodPedido", Me.TotalGridControl)

            '        Else
            '            CarregarDados("SELECT Total.CodOrdem, (Total.Data + Total.Hora) as Data, Total.CodCli, " & _
            '"Convert(Numeric(15,2),Troco) as Troco, Convert(Numeric(15,2),PorDesc) as PorDesc, " & _
            '"Convert(Numeric(15,2),ValDesc) as ValDesc, Convert(Numeric(15,2),sum(Pedido.Custo)) as Custo, " & _
            '"Convert(Numeric(15,2),sum(ValorTotal)) as Total, Convert(Numeric(15,2),sum(ValorTotal) - " & _
            '"sum(Pedido.Custo)) as Lucro, Cliente.Nome, Cliente.Fantasia, Total.CodConfig, Pedido.CodFunc, " & _
            '"case when sum(ValorTotal) <= 0 then 0 else case when sum(Pedido.Custo) < = 0 then 0 else " & _
            '"Convert(Numeric(15,2),((sum(ValorTotal) - sum(Pedido.Custo)) / sum(ValorTotal))*100) end end as PorcentagemDesconto, " & _
            '"(SELECT Top 1 CodOrdens FROM TotalConsig where TotalConsig.CodOrdens = Total.CodPedido and TotalConsig.CodConfig = Total.Codconfig) as NumPed, " & _
            '"(SELECT Top 1 CodOrdem FROM TotalNfe where TotalNfe.CodOrdem = Total.CodNFe and TotalNfe.CodConfig = Total.Codconfig) as NumNF, sum(case when TipoItens <> 'SERVIÇO' then Pedido.Custo else 0 end) as CustoProduto " & _
            '"FROM (Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and Total.CodConfig = Pedido.CodConfig) " & _
            '"left join Cliente on Total.CodCli = Cliente.Codigo where Pedido.TipoItens <> 'CONSUMO' and Pedido.Devolvido = 'False' and " & strData & strFIltro & " group by Total.CodOrdem, Total.Data, Total.CodCli, " & _
            '"Total.Troco, Total.PorDesc, Total.ValDesc, Cliente.Nome, Total.CodConfig, Total.Hora, Pedido.CodFunc, Cliente.Fantasia, Total.CodPedido, Total.CodNFe", Me.TotalGridControl)

            '        End If

            If EmiteNFE = False Then
                CarregarDados("SELECT Total.CodOrdem, (Total.Data + Total.Hora) as Data, Total.CodCli, " & _
                "Convert(Numeric(15,2),Troco) as Troco,   case when sum(Pedido.ValorTotal) > 0 then Convert(Numeric(15,4),100-((sum(Pedido.ValorTotal)*100)/sum(Pedido.Qtd * Pedido.UniSemDesc))) else 0 end as PorDesc, " & _
                "Convert(Numeric(15,2),sum(Pedido.Qtd * Pedido.UniSemDesc) - sum(Pedido.ValorTotal)) as ValDesc, Convert(Numeric(15,2),sum(Pedido.Custo)) as Custo, " & _
                "Convert(Numeric(15,2),sum(ValorTotal)) as Total, Convert(Numeric(15,2),sum(ValorTotal) - " & _
                "sum(Pedido.Custo)) as Lucro, Cliente.Nome, Cliente.Fantasia, Total.CodConfig, " & strCodigoFuncionario & " " & _
                "case when sum(ValorTotal) <= 0 then 0 else case when sum(Pedido.Custo) < = 0 then 0 else " & _
                "Convert(Numeric(15,2),((sum(ValorTotal) - sum(Pedido.Custo)) / sum(ValorTotal))*100) end end " & _
                "as PorcentagemDesconto, (SELECT Top 1 CodOrdens FROM TotalConsig where TotalConsig.CodOrdens = " & _
                "Total.CodPedido and TotalConsig.CodConfig = Total.Codconfig) as NumPed, (SELECT case when " & _
                "sum(ValorTotal) > 0 then sum(ValorTotal) else 0 end " & _
                "from Pedido where Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig and " & _
                "Pedido.TipoItens <> 'SERVIÇO') as Produto, (SELECT case when sum(ValorTotal) > 0 then sum(ValorTotal) else 0 end  from Pedido where " & _
                "Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig and " & _
                "Pedido.TipoItens = 'SERVIÇO') as Servico, Placa, Modelo, sum(case when TipoItens <> 'SERVIÇO' then Pedido.Custo else 0 end) as CustoProduto, Total.TotalFrete, Total.Operador FROM (Total left join Pedido on Total.CodOrdem = " & _
                "Pedido.CodOrdem and Total.CodConfig = Pedido.CodConfig) left join Cliente on Total.CodCli = " & _
                "Cliente.Codigo where Pedido.TipoItens <> 'CONSUMO' and Pedido.Devolvido = 'False' " & _
                "and " & strData & " group by Total.CodOrdem, Total.Data, Total.CodCli, " & _
                "Total.Troco, Total.PorDesc, Total.ValDesc, Cliente.Nome, Total.CodConfig, Total.Hora, " & _
                "" & strCodigoFuncionario & " Cliente.Fantasia, Total.CodPedido, Placa, Modelo, Total.TotalFrete, Total.Operador", Me.TotalGridControl)

            Else
                If TipoDesconto = "ITENS" Then
                    CarregarDados("SELECT Total.CodOrdem, (Total.Data + Total.Hora) as Data, Total.CodCli, " & _
                    "Convert(Numeric(15,2),Troco) as Troco,  case when sum(Pedido.ValorTotal) <= 0 then 0 when sum(Pedido.Qtd * Pedido.UniSemDesc) >0 then Convert(Numeric(15,4),100-((sum(Pedido.ValorTotal)*100) / sum(Pedido.Qtd * Pedido.UniSemDesc)))else 0 end as PorDesc, " & _
                    "Convert(Numeric(15,2),sum(Pedido.Qtd * Pedido.UniSemDesc) - sum(Pedido.ValorTotal)) as ValDesc, Convert(Numeric(15,2),sum(Pedido.Custo)) as Custo, " & _
                    "Convert(Numeric(15,2),sum(ValorTotal)) as Total, Convert(Numeric(15,2),sum(ValorTotal) - " & _
                    "sum(Pedido.Custo)) as Lucro, Cliente.Nome, Cliente.Fantasia, Total.CodConfig, " & strCodigoFuncionario & " " & _
                    "case when sum(ValorTotal) <= 0 then 0 else case when sum(Pedido.Custo) < = 0 then 0 else " & _
                    "Convert(Numeric(15,2),((sum(ValorTotal) - sum(Pedido.Custo)) / sum(ValorTotal))*100) end end " & _
                    "as PorcentagemDesconto, (SELECT Top 1 CodOrdens FROM TotalConsig where TotalConsig.CodOrdens = " & _
                    "Total.CodPedido and TotalConsig.CodConfig = Total.Codconfig) as NumPed, (SELECT Top 1 CodOrdem " & _
                    "FROM TotalNfe where TotalNfe.CodOrdem = Total.CodNFe and TotalNfe.CodConfig = Total.Codconfig) " & _
                    "as NumNF, (SELECT case when sum(ValorTotal) > 0 then sum(ValorTotal) else 0 end " & _
                    "from Pedido where Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig and " & _
                    "Pedido.TipoItens <> 'SERVIÇO') as Produto, (SELECT case when sum(ValorTotal) > 0 then sum(ValorTotal) else 0 end  from Pedido where " & _
                    "Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig and " & _
                    "Pedido.TipoItens = 'SERVIÇO') as Servico, Placa, Modelo, sum(case when TipoItens <> 'SERVIÇO' then Pedido.Custo else 0 end) as CustoProduto, Total.TotalFrete, Total.Operador " & _
                    "FROM (Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and Total.CodConfig = Pedido.CodConfig) " & _
                    "left join Cliente on Total.CodCli = Cliente.Codigo where Pedido.TipoItens <> 'CONSUMO' and Pedido.Devolvido = 'False' and " & strData & " group by Total.CodOrdem, Total.Data, Total.CodCli, " & _
                    "Total.Troco, Total.PorDesc, Total.ValDesc, Cliente.Nome, Total.CodConfig, Total.Hora, " & strCodigoFuncionario & " Cliente.Fantasia, Total.CodPedido, Total.CodNFe, Placa, Modelo, Total.TotalFrete, Total.Operador", Me.TotalGridControl)

                Else
                    'CarregarDados("SELECT Total.CodOrdem, (Total.Data + Total.Hora) as Data, Total.CodCli, " & _
                    '"Convert(Numeric(15,2),Troco) as Troco, Convert(Numeric(15,2),PorDesc) as PorDesc, " & _
                    '"Convert(Numeric(15,2),ValDesc) as ValDesc, Convert(Numeric(15,2),sum(Pedido.Custo)) as Custo, " & _
                    '"Convert(Numeric(15,2),sum(ValorTotal)) as Total, Convert(Numeric(15,2),sum(ValorTotal) - " & _
                    '"sum(Pedido.Custo)) as Lucro, Cliente.Nome, Cliente.Fantasia, Total.CodConfig, " & strCodigoFuncionario & " " & _
                    '"case when sum(ValorTotal) <= 0 then 0 else case when sum(Pedido.Custo) < = 0 then 0 else " & _
                    '"Convert(Numeric(15,2),((sum(ValorTotal) - sum(Pedido.Custo)) / sum(ValorTotal))*100) end end " & _
                    '"as PorcentagemDesconto, (SELECT Top 1 CodOrdens FROM TotalConsig where TotalConsig.CodOrdens = " & _
                    '"Total.CodPedido and TotalConsig.CodConfig = Total.Codconfig) as NumPed, (SELECT Top 1 CodOrdem " & _
                    '"FROM TotalNfe where TotalNfe.CodOrdem = Total.CodNFe and TotalNfe.CodConfig = Total.Codconfig) " & _
                    '"as NumNF, (SELECT case when sum(ValorTotal) > 0 then sum(ValorTotal) else 0 end " & _
                    '"from Pedido where Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig and " & _
                    '"Pedido.TipoItens <> 'SERVIÇO') as Produto, (SELECT case when sum(ValorTotal) > 0 then sum(ValorTotal) else 0 end  from Pedido where " & _
                    '"Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig and " & _
                    '"Pedido.TipoItens = 'SERVIÇO') as Servico, Placa, Modelo, sum(case when TipoItens <> 'SERVIÇO' then Pedido.Custo else 0 end) as CustoProduto " & _
                    '"FROM (Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and Total.CodConfig = Pedido.CodConfig) " & _
                    '"left join Cliente on Total.CodCli = Cliente.Codigo where Pedido.TipoItens <> 'CONSUMO' and Pedido.Devolvido = 'False' and " & strData & strFIltro & " group by Total.CodOrdem, Total.Data, Total.CodCli, " & _
                    '"Total.Troco, Total.PorDesc, Total.ValDesc, Cliente.Nome, Total.CodConfig, Total.Hora, " & strCodigoFuncionario & " Cliente.Fantasia, Total.CodPedido, Total.CodNFe, Placa, Modelo", Me.TotalGridControl)


                    CarregarDados("SELECT Total.CodOrdem, (Total.Data + Total.Hora) as Data, Total.CodCli, " & _
                   "Convert(Numeric(15,2),Troco) as Troco, Convert(Numeric(15,2),PorDesc) as PorDesc, " & _
                   "Convert(Numeric(15,2),ValDesc) as ValDesc, Convert(Numeric(15,2),sum(Pedido.Custo)) as Custo, " & _
                   "Convert(Numeric(15,2),Total.Total) as Total, Convert(Numeric(15,2),sum(Pedido.ValorTotal)) as TotalSemDesc, Convert(Numeric(15,2),Total.Total - " & _
                   "sum(Pedido.Custo)) as Lucro, Cliente.Nome, Cliente.Fantasia, Total.CodConfig, " & strCodigoFuncionario & " " & _
                   "case when Total.Total <= 0 then 0 else case when sum(Pedido.Custo) < = 0 then 0 else " & _
                   "Convert(Numeric(15,2),((Total.Total - sum(Pedido.Custo)) / Total.Total)*100) end end " & _
                   "as PorcentagemDesconto, (SELECT Top 1 CodOrdens FROM TotalConsig where TotalConsig.CodOrdens = " & _
                   "Total.CodPedido and TotalConsig.CodConfig = Total.Codconfig) as NumPed, (SELECT Top 1 CodOrdem " & _
                   "FROM TotalNfe where TotalNfe.CodOrdem = Total.CodNFe and TotalNfe.CodConfig = Total.Codconfig) " & _
                   "as NumNF, (SELECT case when sum(ValorTotal) > 0 then sum(ValorTotal) else 0 end " & _
                   "from Pedido where Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig and " & _
                   "Pedido.TipoItens <> 'SERVIÇO') as Produto, (SELECT case when sum(ValorTotal) > 0 then sum(ValorTotal) else 0 end  from Pedido where " & _
                   "Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig and " & _
                   "Pedido.TipoItens = 'SERVIÇO') as Servico, Placa, Modelo, sum(case when TipoItens <> 'SERVIÇO' then Pedido.Custo else 0 end) as CustoProduto, Total.TotalFrete, Total.Operador " & _
                   "FROM (Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and Total.CodConfig = Pedido.CodConfig) " & _
                   "left join Cliente on Total.CodCli = Cliente.Codigo where Pedido.TipoItens <> 'CONSUMO' and Pedido.Devolvido = 'False' and " & strData & " group by Total.CodOrdem, Total.Data, Total.CodCli, " & _
                   "Total.Troco, Total.PorDesc, Total.ValDesc, Cliente.Nome, Total.CodConfig, Total.Total,Total.Hora, " & strCodigoFuncionario & " Cliente.Fantasia, Total.CodPedido, Total.CodNFe, Placa, Modelo, Total.TotalFrete, Total.Operador", Me.TotalGridControl)

                End If

            End If
        End If

    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub chk1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk1.CheckedChanged
        If Me.chkTroco.EditValue = False Then
            Me.colTroco.Visible = True
        Else
            Me.colTroco.Visible = False
        End If
    End Sub

    Private Sub chk2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk2.CheckedChanged
        If Me.chkPerDesc.EditValue = False Then
            Me.colPorDesc.Visible = True
        Else
            Me.colPorDesc.Visible = False
        End If
    End Sub

    Private Sub chk3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk3.CheckedChanged
        If Me.chkDesc.EditValue = False Then
            Me.colValDesc.Visible = True
        Else
            Me.colValDesc.Visible = False
        End If
    End Sub

    Private Sub btnRelLuc_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelLuc.ItemClick
        Dim rel As New relLucro

        rel.lblTitulo.Text = Me.Text
        rel.picLogo.Image = LogoTipo

        Dim dtDataInicial As Date
        Dim dtDataFinal As Date
        Dim dtDT As Date
        With rel.tbLucro.Rows
            For I = 0 To grd1.RowCount - 1
                .Add()
                .Item(I).Item("CodOrdem") = grd1.GetRowCellDisplayText(I, Me.colCod)
                .Item(I).Item("Data") = grd1.GetRowCellDisplayText(I, Me.colData)

                .Item(I).Item("Cliente") = grd1.GetRowCellDisplayText(I, Me.colCliente)
                .Item(I).Item("Total") = grd1.GetRowCellDisplayText(I, Me.colTotal)
                .Item(I).Item("Custo") = grd1.GetRowCellDisplayText(I, Me.colCusto)
                .Item(I).Item("Lucro") = grd1.GetRowCellDisplayText(I, Me.colLucro)
                .Item(I).Item("CodConfig") = grd1.GetRowCellDisplayText(I, Me.colCodConfig)
                .Item(I).Item("Margem") = grd1.GetRowCellDisplayText(I, Me.colPorcentagemDesconto)

                dtDT = grd1.GetRowCellDisplayText(I, Me.colData)
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
            rel.colCodConfig.Visible = Me.colCodConfig.Visible
            rel.lblTotal.Text = Me.txtTot.Text
            rel.lblCusto.Text = Me.txtTotCusto.Text.Trim
            rel.lblLucro.Text = Me.txtLucro.Text.Trim
            rel.lblPorc.Text = Me.txtPorc.Text.Trim


            rel.lblCustoProd.Text = Me.txtCustoProd.Text.Trim
            rel.lblProduto.Text = Me.txtProduto.Text.Trim
            rel.lblServico.Text = Me.txtServico.Text.Trim
            rel.lblLucroProd.Text = Me.txtLucroProd.Text.Trim


            If Me.colPorcentagemDesconto.Visible = True Then
                rel.colMargem.Visible = True
            Else
                rel.colMargem.Visible = False
            End If

            rel.ShowPreview()

        End With
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.TotalGridControl.ShowPrintPreview()
    End Sub
    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub


End Class