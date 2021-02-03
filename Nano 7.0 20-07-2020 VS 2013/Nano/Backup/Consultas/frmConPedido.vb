Imports Nano.clsFuncoes
Public Class frmConPedido
    Dim I As Integer
    Dim strFiltro As String = ""

    Private Sub frmConPedido_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "29")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmConPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub

        CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja)
        Me.colCusto.Visible = False
        If TipoNano <> 5 Then
            Me.colPlaca.Visible = False
            Me.colModelo.Visible = False
            Me.colKM.Visible = False
            Me.colTipo.Visible = False
        End If

        'If NomeEmpresa.Contains("TAUÁ") Then
        '    Me.colTamanho.Visible = False
        'Else
        '    Me.colCodigoBarra.Visible = False
        'End If

        If Nivel = "USUÁRIO" Then
            Me.chkCus.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Else
            Me.grd1.OptionsView.ShowFooter = True
        End If

        Dim strCodNfe As String = ""
        If EmiteNFE = True Then
            strCodNfe = ", Total.CodNfe as NFe"
        End If

        'If NomeEmpresa.ToUpper.Contains("ÚNICA MODA") = False Then
        '    Me.grd1.OptionsView.ShowFooter = Master
        'End If

        If Master = False Then
            strFiltro = " and Pedido.CodConfig =" & CodConfig
            CarregarDadosLue2("Select Codigo, Nome from Funcionario where CodConfig =" & CodConfig & " and Ativo ='True'", Me.lueFunc)
        Else
            CarregarDadosLue2("Select Codigo, Nome from Funcionario where Ativo ='True'", Me.lueFunc)
        End If

     
        If Me.Tag = "DEVOLUÇÃO" Then
            Dim str As String = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", Date.Today.AddMonths(-3), Date.Today)

            If NomeEmpresa.Trim.ToUpper.Contains("O REI DOS") = True Then
                str = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", Date.Today.AddDays(-15), Date.Today) & strFiltro
            End If
            If CNPJEmpresa = "05017176000170" Then
                CarregarDados("Select Pedido.Codigo, Pedido.CodOrdem, Pedido.CodFunc, case when Devolvido = 'False' then " & _
                         "case when Qtd < 0 then 'True' else 'False' end else 'True' end as Devolvido, Pedido.CodProdInterno, " & _
                         "(Total.Data + Total.Hora) as Data, Pedido.Qtd, Pedido.Produto, Convert(Numeric(15," & CasaDecimal & "),ValorUnitario) as ValorUnitario, " & _
                         "Convert(Numeric(15,2),Pedido.ValorTotal) as ValorTotal, Convert(Numeric(15,2),Pedido.Custo) as Custo, " & _
                         "Total.CodConfig, " & _
                         "Pedido.Tamanho, Pedido.Desconto, Pedido.UniSemDesc " & _
                         "from Pedido left Join Total " & _
                         "on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig " & _
                         "where Pedido.TipoItens <> 'CONSUMO' and " & str, Me.PedidoGridControl)
            Else
                CarregarDados("Select Pedido.CodProd as CodigoProduto, Pedido.Codigo, Pedido.CodOrdem, Pedido.CodFunc, case when Devolvido = 'False' then " & _
                          "case when Qtd < 0 then 'True' else 'False' end else 'True' end as Devolvido, Pedido.CodProdInterno, " & _
                          "(Total.Data + Total.Hora) as Data, Total.CodCli, Pedido.Qtd, Pedido.Produto, Convert(Numeric(15," & CasaDecimal & "),ValorUnitario) as ValorUnitario, " & _
                          "Convert(Numeric(15,2),Pedido.ValorTotal) as ValorTotal, Convert(Numeric(15,2),Pedido.Custo) as Custo, " & _
                          "Cliente.Nome, Cliente.CPF, Total.CodConfig, Pedido.Tamanho, Produto.CodigoInterno, Produto.CodigoBarra, Cliente.Status, Pedido.Desconto, " & _
                          "Pedido.UniSemDesc, Cliente.Fantasia from ((Pedido left join Produto on Pedido.CodProd = Produto.Codigo) INNER Join Total " & _
                          "on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig) INNER Join Cliente On " & _
                          "Total.CodCli = Cliente.Codigo where Pedido.TipoItens <> 'CONSUMO' and " & str, Me.PedidoGridControl)
            End If
          

         

            Me.btnCalcular.Visible = False
            Me.txtTotGer.Visible = False
            Me.txtTotPro.Visible = False
            Me.lblTotGer.Visible = False
            Me.lblProd.Visible = False
            Me.colCodConfig.Visible = True
            Me.grd1.OptionsView.ShowFooter = False
        Else
            Dim str As String = ""
            If Me.Tag = "CLIENTE" Then
                str = " and Total.CodCli = " & CodigoDoCliente
            Else
                str = " and " & String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", Date.Today.AddDays(-30), Date.Today)
                If NomeEmpresa.Trim.ToUpper.Contains("RESTAURANTE") = True Then
                    str = " and " & String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", Date.Today.AddDays(-90), Date.Today)
                End If
            End If
            If NomeEmpresa.Contains("CRAVO CANELA") = True Then
                CarregarDados("Select Pedido.CodProd as CodigoProduto, Pedido.Codigo, Pedido.CodOrdem, Pedido.CodFunc, case when Devolvido = 'False' " & _
                        "then case when Qtd < 0 then 'True' else 'False' end else 'True' end as Devolvido, Pedido.CodProdInterno, " & _
                        "(Total.Data + Total.Hora) as Data, Total.CodCli, Pedido.Qtd, Pedido.Produto, Convert(Numeric(15," & CasaDecimal & "),ValorUnitario) as ValorUnitario, " & _
                        "Convert(Numeric(15,2),Pedido.ValorTotal) as ValorTotal, Convert(Numeric(15,2),Pedido.Custo) as Custo, " & _
                        "Cliente.Nome, Cliente.Cidade, Total.CodConfig, Pedido.Tamanho, Produto.CodigoBarra, Cliente.Status, " & _
                        "Cliente.CPF, Produto.Fabricante, Produto.Grupo, Produto.Setor, Produto.Tipo, Pedido.Desconto, " & _
                        "Pedido.UniSemDesc, case when Pedido.ValorTotal <= 0 then 0 else case when Pedido.Custo < = 0 then 0 else " & _
                        "Convert(Numeric(15,2),((Pedido.ValorTotal - Pedido.Custo) / Pedido.ValorTotal)*100) end end as Markup, Cliente.Fantasia, convert(bit,case when SATFiscal.ValorTotal > 0 then 'True' else 'False' end) as SAT  from (((Pedido left join Produto on Pedido.CodProd = Produto.Codigo) INNER Join Total on " & _
                        "Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig) left join SATFiscal on Total.CodOrdem = SatFiscal.CodOrdem and Total.CodConfig = SATFiscal.Codconfig) INNER Join Cliente On " & _
                        "Total.CodCli = Cliente.Codigo where Pedido.TipoItens <> 'CONSUMO' " & strFiltro & str, Me.PedidoGridControl)

                Me.colComissao.Visible = False
                Me.colLucro.Visible = False
                Me.colMargem.Visible = False
            Else
                'If ComissaoProduto = True Then
                '    CarregarDados("Select Pedido.CodProd as CodigoProduto, Pedido.Codigo, Pedido.CodOrdem, Pedido.CodFunc, case when Devolvido = 'False' " & _
                '            "then case when Qtd < 0 then 'True' else 'False' end else 'True' end as Devolvido, Pedido.CodProdInterno, " & _
                '            "(Total.Data + Total.Hora) as Data, Total.CodCli, Pedido.Qtd, Pedido.Produto, Convert(Numeric(15," & CasaDecimal & "),ValorUnitario) as ValorUnitario, " & _
                '            "Convert(Numeric(15,2),Pedido.ValorTotal) as ValorTotal, Convert(Numeric(15,2),Pedido.Custo) as Custo, " & _
                '            "Cliente.Nome, Cliente.Cidade, Total.CodConfig, Pedido.Tamanho, Produto.CodigoInterno, Produto.CodigoBarra, Cliente.Status, " & _
                '            "Cliente.CPF, Produto.Fabricante, Produto.Grupo, Produto.Setor, Produto.Tipo, Pedido.Desconto, " & _
                '            "Pedido.UniSemDesc, case when Pedido.ValorTotal <= 0 then 0 else case when Pedido.Custo < = 0 then 0 else " & _
                '            "Convert(Numeric(15,2),((Pedido.ValorTotal - Pedido.Custo) / Pedido.ValorTotal)*100) end end as Markup, " & _
                '            "Cliente.Fantasia, Funcionario.Nome as Vendedor, Placa, Modelo, Total.KM, Total.CodPedido, " & _
                '            "Convert(numeric(15,2), (Pedido.ValorTotal * Convert(Numeric(15,2),Replace(Convert(varchar(150), Produto.Comissao),',','.'))) / 100) as Comissao, " & _
                '            "Convert(numeric(15,2), (Pedido.ValorTotal - Pedido.Custo) - (Pedido.ValorTotal * Convert(Numeric(15,2),Replace(Convert(varchar(150), Produto.Comissao),',','.'))) / 100) as Lucro, " & _
                '            "Case When Pedido.Custo > 0 Then Convert(Numeric(15,2),((Pedido.ValorTotal - (Pedido.Custo + Convert(numeric(15,2),(Pedido.ValorTotal * Convert(Numeric(15,2),Replace(Convert(varchar(150), Produto.Comissao),',','.'))) / 100))) * 100) / (Pedido.Custo + Convert(numeric(15,2),(Pedido.ValorTotal * Convert(Numeric(15,2),Replace(Convert(varchar(150), Produto.Comissao),',','.'))) / 100))) Else 0 End as Margem " & _
                '            "from (((Pedido left join Produto on Pedido.CodProd = Produto.Codigo) " & _
                '            "left join Funcionario on Pedido.CodFunc = Funcionario.Codigo) INNER Join Total on " & _
                '            "Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig) INNER Join Cliente On " & _
                '            "Total.CodCli = Cliente.Codigo where Pedido.TipoItens <> 'CONSUMO' " & strFiltro & str, Me.PedidoGridControl)

                'Else
                'CarregarDados("Select Pedido.CodProd as CodigoProduto, Pedido.Codigo, Pedido.CodOrdem, Pedido.CodFunc, case when Devolvido = 'False' " & _
                '        "then case when Qtd < 0 then 'True' else 'False' end else 'True' end as Devolvido, Pedido.CodProdInterno, " & _
                '        "(Total.Data + Total.Hora) as Data, Total.CodCli, Pedido.Qtd, Pedido.Produto, Convert(Numeric(15," & CasaDecimal & "),ValorUnitario) as ValorUnitario, " & _
                '        "Convert(Numeric(15,2),Pedido.ValorTotal) as ValorTotal, Convert(Numeric(15,2),Pedido.Custo) as Custo, " & _
                '        "Cliente.Nome, Cliente.Cidade, Total.CodConfig, Pedido.Tamanho, Produto.CodigoInterno, Produto.CodigoBarra, Cliente.Status, " & _
                '        "Cliente.CPF, Produto.Fabricante, Produto.Grupo, Produto.Setor, Produto.Tipo, Pedido.Desconto, " & _
                '        "Pedido.UniSemDesc, case when Pedido.ValorTotal <= 0 then 0 else case when Pedido.Custo < = 0 then 0 else " & _
                '        "Convert(Numeric(15,2),((Pedido.ValorTotal - Pedido.Custo) / Pedido.ValorTotal)*100) end end as Markup, " & _
                '        "Cliente.Fantasia, Funcionario.Nome as Vendedor, Placa, Modelo, Total.KM, Total.CodPedido, " & _
                '        "Convert(numeric(15,2), (Pedido.ValorTotal * Convert(Numeric(15,2),Replace(Convert(varchar(150), Funcionario.PorcComissao),',','.'))) / 100) as Comissao, " & _
                '        "Convert(numeric(15,2), (Pedido.ValorTotal - Pedido.Custo) - (Pedido.ValorTotal * Convert(Numeric(15,2),Replace(Convert(varchar(150), Funcionario.PorcComissao),',','.'))) / 100) as Lucro, " & _
                '        "Case When Pedido.Custo > 0 Then Convert(Numeric(15,2),((Pedido.ValorTotal - (Pedido.Custo + Convert(numeric(15,2),(Pedido.ValorTotal * Convert(Numeric(15,2),Replace(Convert(varchar(150), Funcionario.PorcComissao),',','.'))) / 100))) * 100) / (Pedido.Custo + Convert(numeric(15,2),(Pedido.ValorTotal * Convert(Numeric(15,2),Replace(Convert(varchar(150), Funcionario.PorcComissao),',','.'))) / 100))) Else 0 End as Margem " & _
                '        "from (((Pedido left join Produto on Pedido.CodProd = Produto.Codigo) " & _
                '        "left join Funcionario on Pedido.CodFunc = Funcionario.Codigo) INNER Join Total on " & _
                '        "Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig) INNER Join Cliente On " & _
                '        "Total.CodCli = Cliente.Codigo where Pedido.TipoItens <> 'CONSUMO' " & strFiltro & str, Me.PedidoGridControl)


                CarregarDados("Select Pedido.CodProd as CodigoProduto, Pedido.Codigo, Pedido.CodOrdem, Pedido.CodFunc, " & _
                "case when Devolvido = 'False' then case when Qtd < 0 then 'True' else 'False' end else 'True' end as Devolvido, " & _
                "Pedido.CodProdInterno, (Total.Data + Total.Hora) as Data, Total.CodCli, Pedido.Qtd, Pedido.Produto, " & _
                "Convert(Numeric(15," & CasaDecimal & "),ValorUnitario) as ValorUnitario, convert(bit,case when StatusDav = 'Faturado' then 'True' else 'False' end) as SAT, " & _
                "Convert(Numeric(15,2),Pedido.ValorTotal) as ValorTotal, Convert(Numeric(15,2),Pedido.Custo) as Custo, " & _
                "Cliente.Nome, Cliente.Cidade, Total.CodConfig, Pedido.Tamanho, Produto.CodigoInterno, Produto.CodigoBarra, " & _
                "Cliente.Status, Cliente.CPF, Produto.Fabricante, Produto.Grupo, Produto.Setor, Produto.Tipo, Pedido.Desconto, " & _
                "Pedido.UniSemDesc, case when Pedido.ValorTotal <= 0 then 0 else case when Pedido.Custo < = 0 then 0 else " & _
                "Convert(Numeric(15,2),((Pedido.ValorTotal - Pedido.Custo) / Pedido.ValorTotal)*100) end end as Markup, " & _
                "Cliente.Fantasia, Funcionario.Nome as Vendedor, Placa, Modelo, Total.KM, Total.CodPedido" & strCodNfe & ", " & _
                "Convert(numeric(15,2), (Pedido.ValorTotal * Convert(Numeric(15,2),Replace(Convert(varchar(150), case when Produto.Tipo = 'SERVIÇO' then Funcionario.ComServ else Funcionario.PorcComissao end),',','.'))) / 100) as Comissao, " & _
                "Convert(numeric(15,2), (Pedido.ValorTotal - Pedido.Custo)) as Lucro, Pedido.Auxiliar as Computador, " & _
                "Case When Pedido.Custo > 0 Then Convert(Numeric(15,2),((Pedido.ValorTotal - Pedido.Custo) * 100) / Pedido.Custo) Else 0 End as Margem, Pedido.ValorFrete, Total.Operador " & _
                "from (((Pedido left join Produto on Pedido.CodProd = Produto.Codigo) " & _
                "left join Funcionario on Pedido.CodFunc = Funcionario.Codigo) INNER Join Total on " & _
                "Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig) INNER Join Cliente On " & _
                "Total.CodCli = Cliente.Codigo where Pedido.TipoItens <> 'CONSUMO' " & strFiltro & str, Me.PedidoGridControl)

                'End If
            End If


        End If

        If Me.Tag = "CLIENTE" Then
            Dim index As Integer = -999997
            grd1.FocusedRowHandle = index
            grd1.FocusedColumn = Me.colCliente
            grd1.SetRowCellValue(index, Me.colCliente, NomeDoCliente)
            grd1.ShowEditor()

            Calcular()
        End If

        'If AbrirFecharCaixa = True Then
        Me.RepositoryItemDateEdit3.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.RepositoryItemDateEdit3.EditFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.RepositoryItemDateEdit3.EditMask = "dd/MM/yyyy HH:mm"
        Me.RepositoryItemDateEdit4.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.RepositoryItemDateEdit4.EditFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.RepositoryItemDateEdit4.EditMask = "dd/MM/yyyy HH:mm"
        'End If
        'If NomeEmpresa.Contains("LUCIA FREITAS") = False Then
        '    Me.grd1.OptionsView.ColumnAutoWidth = True
        '    'Me.colStatus.Visible = False
        'End If

        Me.colCodConfig.Visible = Master
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)
        Timer1.Start()

    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Calcular()
    End Sub
    Private Sub Calcular()
        Me.txtTotGer.ResetText()
        Me.txtTotPro.ResetText()

        With grd1
            Dim dblResPro, dblResTot As Double
            For I = 0 To .RowCount - 1
                Dim dblPro, dblTot As Double
                Dim dtDataVenda As Date = .GetRowCellDisplayText(I, Me.colData)

                If dtDataVenda < "25/11/2015" Then
                    If Me.grd1.GetRowCellValue(I, Me.colDevolvido) = False Then
                        If Not .GetRowCellDisplayText(I, Me.colQtd).Contains(":") Then
                            dblPro = .GetRowCellDisplayText(I, Me.colQtd)
                            dblResPro += dblPro
                        End If
                        dblTot = .GetRowCellDisplayText(I, Me.colValorTotal)
                        dblResTot += dblTot
                    Else
                        dblTot = .GetRowCellDisplayText(I, Me.colValorTotal)
                        If dblTot < 0 Then
                            If Not .GetRowCellDisplayText(I, Me.colQtd).Contains(":") Then
                                dblPro = .GetRowCellDisplayText(I, Me.colQtd)
                                dblResPro += dblPro
                            End If

                            dblResTot += dblTot
                        End If
                    End If
                Else
                    If Not .GetRowCellDisplayText(I, Me.colQtd).Contains(":") Then
                        dblPro = .GetRowCellDisplayText(I, Me.colQtd)
                        dblResPro += dblPro
                    End If

                    dblTot = .GetRowCellDisplayText(I, Me.colValorTotal)
                    dblResTot += dblTot
                End If


                'If Me.grd1.GetRowCellValue(I, Me.colDevolvido) = False Then
                'Else
                'dblTot = .GetRowCellDisplayText(I, Me.colValorTotal)
                'If dblTot < 0 Then
                '    If Not .GetRowCellDisplayText(I, Me.colQtd).Contains(":") Then
                '        dblPro = .GetRowCellDisplayText(I, Me.colQtd)
                '        dblResPro += dblPro
                '    End If

                '    dblResTot += dblTot
                'End If
                'End If
            Next
            Me.txtTotPro.Text = dblResPro.ToString("###,###,##0.000")
            Me.txtTotGer.Text = dblResTot.ToString("###,###,##0.00")
        End With
    End Sub
    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
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
        Dim strCodNfe As String = ""
        If EmiteNFE = True Then
            strCodNfe = ", Total.CodNfe as NFe"
        End If

        Dim strData As String = String.Format("Total.Data + Total.Hora >= '{0:dd/MM/yyyy HH:mm}' AND Total.Data + Total.Hora <= '{1:dd/MM/yyyy HH:mm}'", dtInicial.EditValue, dtFinal.EditValue.ToString.Replace("00:00", "23:59")) & strFiltro

        'CarregarDados("Select Pedido.CodOrdem, Pedido.CodFunc, Pedido.CodProdInterno, Total.Data, Total.CodCli, Qtd, Produto, Convert(Numeric(15,2),ValorUnitario) as ValorUnitario, Convert(Numeric(15,2),ValorTotal) as ValorTotal, Cliente.Nome, Total.CodConfig from Pedido, Total, Cliente where Pedido.CodOrdem = Total.CodOrdem and Total.CodCli = Cliente.Codigo and TipoItens = 'VENDA' and " & String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro, Me.PedidoGridControl)
        'CarregarDados("Select Pedido.Codigo, Pedido.CodOrdem, Pedido.CodFunc, Pedido.Devolvido, Pedido.CodProdInterno, Total.Data, Total.CodCli, Qtd, Produto, Convert(Numeric(15,2),ValorUnitario) as ValorUnitario, Convert(Numeric(15,2),ValorTotal) as ValorTotal, Convert(Numeric(15,2),Pedido.Custo) as Custo, Cliente.Nome, Total.CodConfig, Pedido.Tamanho from (Pedido INNER Join Total on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig) INNER Join Cliente On Total.CodCli = Cliente.Codigo where Pedido.TipoItens = 'VENDA' and " & String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro, Me.PedidoGridControl)
        If NomeEmpresa.Contains("CRAVO CANELA") = True Then
            CarregarDados("Select Pedido.CodProd as CodigoProduto, Pedido.Codigo, Pedido.CodOrdem, Pedido.CodFunc, case when Devolvido = 'False' " & _
                      "then case when Qtd < 0 then 'True' else 'False' end else 'True' end as Devolvido, Pedido.CodProdInterno, " & _
                      "(Total.Data + Total.Hora) as Data, Total.CodCli, Pedido.Qtd, Pedido.Produto, Convert(Numeric(15," & CasaDecimal & "),ValorUnitario) as ValorUnitario, " & _
                      "Convert(Numeric(15,2),Pedido.ValorTotal) as ValorTotal, Convert(Numeric(15,2),Pedido.Custo) as Custo, " & _
                      "Cliente.Nome, Cliente.Cidade, Total.CodConfig, Pedido.Tamanho, Produto.CodigoInterno, Produto.CodigoBarra, Cliente.Status, " & _
                      "Cliente.CPF, Produto.Fabricante, Produto.Grupo, Produto.Setor, Produto.Tipo, Pedido.Desconto, " & _
                      "Pedido.UniSemDesc, case when Pedido.ValorTotal <= 0 then 0 else case when Pedido.Custo < = 0 then 0 else " & _
                      "Convert(Numeric(15,2),((Pedido.ValorTotal - Pedido.Custo) / Pedido.ValorTotal)*100) end end as Markup, Cliente.Fantasia, convert(bit,case when SATFiscal.ValorTotal > 0 then 'True' else 'False' end) as SAT  from (((Pedido left join Produto on Pedido.CodProd = Produto.Codigo) INNER Join Total on " & _
                      "Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig) left join SATFiscal on Total.CodOrdem = SatFiscal.CodOrdem and Total.CodConfig = SATFiscal.Codconfig) INNER Join Cliente On " & _
                      "Total.CodCli = Cliente.Codigo where Pedido.TipoItens <> 'CONSUMO' and " & String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro, Me.PedidoGridControl)
        Else
            'Dim strData As String = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro

            'If AbrirFecharCaixa = True Then
           'End If
            If ComissaoProduto = True Then
                CarregarDados("Select Pedido.CodProd as CodigoProduto, Pedido.Codigo, Pedido.CodOrdem, Pedido.CodFunc, Pedido.Devolvido, " & _
                            "Pedido.CodProdInterno, (Total.Data + Total.Hora) as Data, Total.CodCli, Pedido.Qtd, " & _
                            "Pedido.Produto, Convert(Numeric(15," & CasaDecimal & "),ValorUnitario) as ValorUnitario, Convert(Numeric(15,2),Pedido.ValorTotal) as ValorTotal, " & _
                            "Convert(Numeric(15,2),Pedido.Custo) as Custo, Cliente.Nome, Total.CodConfig, Pedido.Tamanho, " & _
                            "Produto.CodigoBarra, Cliente.Status, Cliente.CPF, Produto.Fabricante, Produto.Grupo, Produto.CodigoInterno, Produto.Setor, Produto.Tipo, " & _
                            "Cliente.Cidade, Cliente.Fantasia, Pedido.Desconto, Pedido.UniSemDesc, case when Pedido.ValorTotal <= 0 then 0 else case when Pedido.Custo < = 0 then 0 else " & _
                            "Convert(Numeric(15,2),((Pedido.ValorTotal - Pedido.Custo) / Pedido.ValorTotal)*100) end end as Markup, " & _
                            "Funcionario.Nome as Vendedor, Cliente.Fantasia, Placa, Modelo, Total.KM, Total.CodPedido, Pedido.Auxiliar as Computador, " & _
                            "Convert(numeric(15,2), (Pedido.ValorTotal * Convert(Numeric(15,2),Replace(Convert(varchar(150), Produto.Comissao),',','.'))) / 100) as Comissao" & strCodNfe & ", " & _
                            "Convert(numeric(15,2), (Pedido.ValorTotal - Pedido.Custo) - (Pedido.ValorTotal * Convert(Numeric(15,2),Replace(Convert(varchar(150), Produto.Comissao),',','.'))) / 100) as Lucro, " & _
                            "Case When Pedido.Custo > 0 Then Convert(Numeric(15,2),((Pedido.ValorTotal - (Pedido.Custo + Convert(numeric(15,2),(Pedido.ValorTotal * Convert(Numeric(15,2),Replace(Convert(varchar(150), Produto.Comissao),',','.'))) / 100))) * 100) / (Pedido.Custo + Convert(numeric(15,2),(Pedido.ValorTotal * Convert(Numeric(15,2),Replace(Convert(varchar(150), Produto.Comissao),',','.'))) / 100))) Else 0 End as Margem, Pedido.ValorFrete, Total.Operador " & _
                            "From (((Pedido left join Produto on Pedido.CodProd = Produto.Codigo) " & _
                            "left join Funcionario on Pedido.CodFunc = Funcionario.Codigo) INNER Join Total on " & _
                            "Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig) INNER Join Cliente On " & _
                            "Total.CodCli = Cliente.Codigo where Pedido.TipoItens <> 'CONSUMO' and " & strData, Me.PedidoGridControl)

            Else
                CarregarDados("Select Pedido.CodProd as CodigoProduto, Pedido.Codigo, Pedido.CodOrdem, Pedido.CodFunc, Pedido.Devolvido, " & _
                            "Pedido.CodProdInterno, (Total.Data + Total.Hora) as Data, Total.CodCli, Pedido.Qtd, " & _
                            "Pedido.Produto, Convert(Numeric(15," & CasaDecimal & "),ValorUnitario) as ValorUnitario, Convert(Numeric(15,2),Pedido.ValorTotal) as ValorTotal, " & _
                            "Convert(Numeric(15,2),Pedido.Custo) as Custo, Cliente.Nome, Total.CodConfig, Pedido.Tamanho, convert(bit,case when StatusDav = 'Faturado' then 'True' else 'False' end) as SAT, " & _
                            "Produto.CodigoBarra, Cliente.Status, Cliente.CPF, Produto.Fabricante, Produto.Grupo, Produto.CodigoInterno, Produto.Setor, Produto.Tipo, " & _
                            "Cliente.Cidade, Cliente.Fantasia, Pedido.Desconto, Pedido.UniSemDesc, case when Pedido.ValorTotal <= 0 then 0 else case when Pedido.Custo < = 0 then 0 else " & _
                            "Convert(Numeric(15,2),((Pedido.ValorTotal - Pedido.Custo) / Pedido.ValorTotal)*100) end end as Markup, " & _
                            "Funcionario.Nome as Vendedor, Cliente.Fantasia, Placa, Modelo, Total.KM, Total.CodPedido, Pedido.Auxiliar as Computador, " & _
                            "Convert(numeric(15,2), (Pedido.ValorTotal * Convert(Numeric(15,2),Replace(Convert(varchar(150), Funcionario.PorcComissao),',','.'))) / 100) as Comissao" & strCodNfe & ", " & _
                            "Convert(numeric(15,2), (Pedido.ValorTotal - Pedido.Custo) - (Pedido.ValorTotal * Convert(Numeric(15,2),Replace(Convert(varchar(150), Funcionario.PorcComissao),',','.'))) / 100) as Lucro, " & _
                            "Case When Pedido.Custo > 0 Then Convert(Numeric(15,2),((Pedido.ValorTotal - (Pedido.Custo + Convert(numeric(15,2),(Pedido.ValorTotal * Convert(Numeric(15,2),Replace(Convert(varchar(150), Funcionario.PorcComissao),',','.'))) / 100))) * 100) / (Pedido.Custo + Convert(numeric(15,2),(Pedido.ValorTotal * Convert(Numeric(15,2),Replace(Convert(varchar(150), Funcionario.PorcComissao),',','.'))) / 100))) Else 0 End as Margem, Pedido.ValorFrete, Total.Operador " & _
                            "From (((Pedido left join Produto on Pedido.CodProd = Produto.Codigo) " & _
                            "left join Funcionario on Pedido.CodFunc = Funcionario.Codigo) INNER Join Total on " & _
                            "Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig) INNER Join Cliente On " & _
                            "Total.CodCli = Cliente.Codigo where Pedido.TipoItens <> 'CONSUMO' and " & strData, Me.PedidoGridControl)

            End If
            'Placa, Modelo + ' ' + Cor as Modelo, 
        End If
    End Sub

    Private Sub txtRetorna_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRetorna.DoubleClick
        Retorna()
       
    End Sub

    Private Sub txtRetorna_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRetorna.KeyDown
        If e.KeyCode = Keys.Enter Then
            Retorna()
        End If

    End Sub

    Private Sub Retorna()
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub

        If Me.Tag = "DEVOLUÇÃO" Then
            If Me.grd1.GetRowCellValue(grd1.FocusedRowHandle, Me.colDevolvido) = True Then
                MsgBox("Produto já foi devolvido!", MsgBoxStyle.Information)
                Exit Sub
            End If
            CodigoDaVenda = Me.grd1.GetRowCellValue(Me.grd1.FocusedRowHandle, Me.colCodigo)
            intCodLojaDevolucao = Me.grd1.GetRowCellValue(Me.grd1.FocusedRowHandle, Me.colCodConfig)
            Me.Close()
        End If
    End Sub

    Private Sub lueFunc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueFunc.DoubleClick
        Retorna()
    End Sub

    Private Sub lueFunc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lueFunc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Retorna()
        End If
    End Sub

    Private Sub lueLoja_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueLoja.DoubleClick
        Retorna()
    End Sub

    Private Sub lueLoja_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lueLoja.KeyDown
        If e.KeyCode = Keys.Enter Then
            Retorna()
        End If
    End Sub

    Private Sub chkCusto_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCusto.CheckedChanged
        If Me.chkCus.EditValue = False Then
            Me.colCusto.Visible = True
        Else
            Me.colCusto.Visible = False
        End If
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.PedidoGridControl.ShowPrintPreview()
    End Sub

    Private Sub btnRelVend_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelVend.ItemClick
        Dim rel As New relPedido
        rel.picLogo.Image = LogoTipo
        Dim dtDataInicial As Date
        Dim dtDataFinal As Date
        Dim dtDT As Date

        With rel.tbPedido.Rows
            For I = 0 To grd1.RowCount - 1
                .Add()

                .Item(I).Item("CodOrdem") = grd1.GetRowCellDisplayText(I, Me.colCod)
                .Item(I).Item("Data") = grd1.GetRowCellDisplayText(I, Me.colData)
                .Item(I).Item("Cliente") = grd1.GetRowCellDisplayText(I, Me.colCliente)
                .Item(I).Item("Qtde") = grd1.GetRowCellDisplayText(I, Me.colQtd)
                .Item(I).Item("Produto") = grd1.GetRowCellDisplayText(I, Me.colProduto)
                .Item(I).Item("ValorUni") = grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                .Item(I).Item("ValorTotal") = grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                .Item(I).Item("CodProdInterno") = grd1.GetRowCellDisplayText(I, Me.colCodProdInterno)

                .Item(I).Item("CodConfig") = grd1.GetRowCellDisplayText(I, Me.colCodConfig)
                If TipoNano = 5 Then
                    .Item(I).Item("Tamanho") = grd1.GetRowCellDisplayText(I, Me.colKM)
                    .Item(I).Item("Placa") = grd1.GetRowCellDisplayText(I, Me.colPlaca)
                    .Item(I).Item("Modelo") = grd1.GetRowCellDisplayText(I, Me.colModelo)
                    .Item(I).Item("KM") = grd1.GetRowCellDisplayText(I, Me.colKM)
                Else
                    .Item(I).Item("Tamanho") = grd1.GetRowCellDisplayText(I, Me.colTamanho)
                End If
             

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
            rel.colCodConfig.Visible = Me.colCodConfig.Visible
            rel.lblPeriodo.Text = "De " & Format(dtDataInicial, "dd/MM/yyyy") & " a " & Format(dtDataFinal, "dd/MM/yyyy")
            rel.lblPro.Text = Me.txtTotPro.Text
            rel.lblTotal.Text = Me.txtTotGer.Text
            If TipoNano = 5 Then
                rel.colTamanho.Caption = "KM"
            Else
                rel.colPlaca.Visible = False
                rel.colModelo.Visible = False
            End If
            rel.ShowPreview()
        End With
    End Sub

    Private Sub chkDev_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDev.CheckedChanged
        If Me.chkDevol.EditValue = False Then
            Me.colDevolvido.Visible = True
        Else
            Me.colDevolvido.Visible = False
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim index As Integer = -999997
        grd1.FocusedRowHandle = index
        grd1.FocusedColumn = Me.colCod
        Timer1.Stop()
    End Sub

    Private Sub txtRetorna_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRetorna.KeyPress
        If Me.grd1.FocusedColumn.Name <> Me.colCod.Name Then Exit Sub
        If IsNumeric(e.KeyChar) = False Then
            If e.KeyChar = vbBack Then Exit Sub
            e.Handled = True
        End If
    End Sub

    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub
End Class

