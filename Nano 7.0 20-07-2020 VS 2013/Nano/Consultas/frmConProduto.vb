Imports Nano.clsFuncoes
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Printing

Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Drawing

Public Class frmConProduto
    Public strTabPre As String
    Dim strCodProd As String
    Public strTipoProduto As String
    Public strFiltroProduto As String = ""

    Private Sub AtualizarGrid(ByVal parEstoque As Boolean)
        Dim strFiltro2 As String = ""
        Select Case Me.Tag
            Case "VENDA"
                strFiltro2 = " and Produto.Tipo <> 'CONSUMO'"
                If SepararEstoqueSetor <> "" Then
                    strFiltro2 &= " and Produto.Setor <> '" & SepararEstoqueSetor & "'"
                End If
            Case "PEDIDO"
                strFiltro2 = " and Produto.Tipo <> 'CONSUMO'"
                If SepararEstoqueSetor <> "" Then
                    strFiltro2 &= " and Produto.Setor = '" & SepararEstoqueSetor & "'"
                End If
            Case "DESCARTE"
                strFiltro2 = " and Produto.Tipo <> 'RECEITA' and Tipo <> 'SERVIÇO'"
            Case "RECEITA"
                strFiltro2 = " and Tipo <> 'VENDA' and Tipo <> 'RECEITA' and Tipo <> 'SERVIÇO'"

        End Select


        Dim strDataEntrada As String = ""
        Dim strDataPedido As String = ""
        Dim strDataAjuste As String = ""
        If parEstoque = True Then
            Dim dtDataAjuste As Date = Me.dtDataEstoque.EditValue
            strDataEntrada = " and TotalEntradaNF.Data <= '" & Me.dtDataEstoque.EditValue & "'"
            strDataPedido = " and Total.Data <= '" & Me.dtDataEstoque.EditValue & "'"
            strDataAjuste = " and AjusteQtde.Data <= '" & dtDataAjuste.AddDays(1) & "'"
        End If

        Dim strCasaDescimais As String = "Numeric(15,2)"

        If TresCasasDecimais = True Then
            strCasaDescimais = "Numeric(15,3)"
        End If

        strCasaDescimais = "Numeric(15," & CasaDecimal & ")"


        Dim strResult As String = QueryTabelaPreco(strTabPre)

        'If strTipoProduto = "P" Then
        '    If ManterMargemProd = True Then
        '        If strResult = "Produto.Valor" Then
        '            strResult = "Produto.ValorCusto + ((Produto.ValorCusto * replace(Produto.Porcentagens,',','.')) / 100)"
        '        End If
        '    End If
        '    strTipoProduto = " and Tipo <> 'SERVIÇO' "
        'ElseIf strTipoProduto = "S" Then
        '    strTipoProduto = " and Tipo = 'SERVIÇO' "
        'Else
        '    strTipoProduto = ""
        'End If


        If TipoNano = 5 Then
            If strTipoProduto = "P" Then
                If strResult = "Produto.Valor" Then
                    If ManterMargemProd = True Then

                        strResult = "Produto.ValorCusto + ((Produto.ValorCusto * replace(Produto.Porcentagens,',','.')) / 100)"
                    End If
                    strTipoProduto = " and Tipo <> 'SERVIÇO'"
                End If
                strTipoProduto = " and Tipo <> 'SERVIÇO'"
            ElseIf strTipoProduto = "S" Then

                strTipoProduto = " and Tipo = 'SERVIÇO'"

            End If
        Else
            If strResult = "Produto.Valor" Then
                If ManterMargemProd = True Then
                    strResult = "Produto.ValorCusto + ((Produto.ValorCusto * replace(Produto.Porcentagens,',','.')) / 100)"
                End If
            End If
            strTipoProduto = ""
        End If

        Dim strCodigoBarra As String '= "Produto.CodigoBarra  + isnull(' / ' + dbo.FuncCodigoBarra(Produto.Codigo),'') as CodigoBarra"

        'If NomeEmpresa.Contains("AUTO PECAS CAVALAO") Then
        strCodigoBarra = "Produto.CodigoBarra"
        'End If


        If Master = True Then

            If EstoqueSomado = False Then
                CarregarDados("SELECT '' as QtdAdd, Produto.CodigoFabricante as CodSimilar, Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, " & _
                "Convert(" & strCasaDescimais & ", " & strResult & ") as Valor, Convert(" & strCasaDescimais & ", Produto.ValorCusto) as ValorCusto, " & _
                "(select Locacao from Locacao where Locacao.CodProd = Produto.Codigo and Locacao.CodConfig  = " & CodConfig & ") as Locacao, Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Grupo, " & _
                "Produto.Obs, Produto.Data, " & strCodigoBarra & ", Sum(Qtde.QtdMinima) as QtdMinima, Sum(Qtde.QtdMaxima) as QtdMaxima, " & _
                "sum(Qtde.Qtd) as Qtd, sum(Convert(Numeric(2),Qtde.EmFalta)) as EmFalta, Produto.NivelComboCodCF, " & _
                "Produto.Desconto, Produto.Comissao, Produto.Setor, Produto.Familia, Produto.Tipo, Produto.Inativo, Produto.CodProdFor, " & _
                "Produto.Validade, Produto.Locacao2, case when Produto.Desconto > 0 then convert(Numeric(15,2)," & _
                "(Produto.Valor - ((Produto.Valor / 100) * Produto.Desconto))) else NULL end as ValPromocao, " & _
                "(SELECT Max(Total.Data) FROM Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and " & _
                "Total.CodConfig = Pedido.CodConfig where Pedido.CodProd = Produto.Codigo) as DataUltVenda, Produto.QtdEmb " & _
                "FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd " & _
                "where Produto.Inativo = 'False' " & strTipoProduto & strFiltro2 & " group by Produto.Familia, Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Produto.Valor, " & _
                "Produto.ValorCusto, Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Grupo, Produto.Obs, " & _
                "Produto.Data, Produto.CodigoBarra, Produto.NivelComboCodCF, Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo, " & _
                "Produto.CodProdFor, Produto.Validade, Produto.Comissao, Produto.CodigoFabricante, Produto.Locacao2, Produto.QtdEmb", Me.GridControl2)
            Else
                'CarregarDados("SELECT Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, " & _
                '"Convert(Numeric(15,2), Produto.Valor) as Valor, Convert(Numeric(15,2), Produto.ValorCusto) as ValorCusto, " & _
                '"Produto.Locacao, Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Grupo, " & _
                '"Produto.Obs, Produto.Data, Produto.CodigoBarra, Produto.Validade, Sum(Qtde.QtdMinima) as QtdMinima, " & _
                '"(SELECT case when sum(EntradaNf.QtdProd) is null then 0 else sum(EntradaNf.QtdProd) end FROM " & _
                '"EntradaNf left join TotalEntradaNf on EntradaNf.CodTotNf = TotalEntradaNf.Codigo where " & _
                '"EntradaNf.CodProd = Produto. Codigo and EstoqueOk = 'True'" & strData & ") - (SELECT case when " & _
                '"sum(Pedido.Qtd) is null then 0 else sum(Pedido.Qtd) end FROM Pedido left join Total on " & _
                '"PEdido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig where Pedido.CodProd = Produto.Codigo " & _
                '"and Pedido.Devolvido = 'False'" & strData & ") + (SELECT case when sum(AjusteQtde.Qtd) is null then 0 else  sum(AjusteQtde.Qtd) end " & _
                '"FROM AjusteQtde where AjusteQtde.CodProd = Produto.Codigo" & strData & ") as Qtd, (SELECT case when sum(Convert(Numeric(2),Qtde.EmFalta)) is null then 1 " & _
                '"else sum(Convert(Numeric(15,3), Qtde.EmFalta)) end FROM Qtde where Produto.Codigo = Qtde.CodProd) as EmFalta, " & _
                '"(SELECT Max(Total.Data) FROM Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and " & _
                '"Total.CodConfig = Pedido.CodConfig where Pedido.CodProd = Produto.Codigo) as DataUltVenda, " & _
                '"Produto.NivelComboCodCF, Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.CodProdFor, Produto.Comissao, Produto.Locacao2, " & _
                '"convert(bit,(SELECT case when sum(Codigo) > 0 then 'True' else 'False' end FROM Campanha where Campanha.CodProd = " & _
                '"Produto.Codigo and Status = 'Lancado')) as Campanha, " & _
                '"case when Produto.Desconto > 0 then convert(Numeric(15,2),(Produto.Valor - ((Produto.Valor / 100) * Produto.Desconto))) else NULL end as ValPromocao " & _
                '"FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where Produto.Inativo = 'False' " & strFiltro2 & "  " & _
                '"group by Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Produto.Valor, Produto.ValorCusto, Produto.Locacao, Produto.CodigoInterno, " & _
                '"Produto.Porcentagens, Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.Data, Produto.CodigoBarra, Produto.NivelComboCodCF, " & _
                '"Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.CodProdFor, Produto.Validade, Produto.Comissao, Produto.Locacao2", Me.GridControl2)

                If Me.Tag = "CONSULTA" Then
                    CarregarDados("SELECT '' as QtdAdd, Produto.CodigoFabricante as CodSimilar, Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, " & _
                                    "Convert(" & strCasaDescimais & ", " & strResult & ") as Valor, " & _
                                    "Convert(" & strCasaDescimais & ", Produto.ValorCusto) as ValorCusto, (select Locacao from Locacao where Locacao.CodProd = Produto.Codigo and Locacao.CodConfig  = " & CodConfig & ") as Locacao, " & _
                                    "Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Familia, Produto.Grupo, Produto.Obs, " & _
                                    "Produto.Data, " & strCodigoBarra & ", Produto.Validade, Sum(Qtde.QtdMinima) as QtdMinima, Sum(Qtde.QtdMaxima) as QtdMaxima, " & _
                                    "(SELECT case when sum(EntradaNf.QtdProd) is null then 0 else sum(EntradaNf.QtdProd) end " & _
                                    "FROM EntradaNf left join TotalEntradaNf on EntradaNf.CodTotNf = TotalEntradaNf.Codigo where " & _
                                    "EntradaNf.CodProd = Produto. Codigo and EstoqueOk = 'True'" & strDataEntrada & ") - (SELECT case when sum(Pedido.Qtd) " & _
                                    "is null then 0 else sum(Pedido.Qtd) end FROM Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and PEdido.CodConfig = Total.CodConfig where Pedido.CodProd = Produto.Codigo " & _
                                    "and Pedido.Devolvido = 'False'" & strDataPedido & ") + (SELECT case when sum(AjusteQtde.Qtd) is null then 0 else " & _
                                    "sum(AjusteQtde.Qtd) end FROM AjusteQtde where AjusteQtde.CodProd = Produto.Codigo" & strDataAjuste & ") as Qtd, " & _
                                    "(SELECT case when sum(Convert(Numeric(2),Qtde.EmFalta)) is null then 1 else " & _
                                    "sum(Convert(Numeric(15,3), Qtde.EmFalta)) end FROM Qtde where Produto.Codigo = Qtde.CodProd) as EmFalta, " & _
                                    "(SELECT Max(Total.Data) FROM Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and " & _
                                    "Total.CodConfig = Pedido.CodConfig where Pedido.CodProd = Produto.Codigo) as DataUltVenda, Produto.NivelComboCodCF, Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo, " & _
                                    "Produto.CodProdFor, Produto.Comissao, Produto.Locacao2, Produto.Familia, " & _
                                    "convert(bit,(SELECT case when sum(Codigo) > 0 then 'True' else 'False' end FROM Campanha where Campanha.CodProd = " & _
                                    "Produto.Codigo and Status = 'Lancado')) as Campanha, " & _
                                    "case when Produto.Desconto > 0 then convert(" & strCasaDescimais & ",(Produto.Valor - ((Produto.Valor / 100) * Produto.Desconto))) else NULL end as ValPromocao, Produto.QtdEmb " & _
                                    "FROM Produto left join " & _
                                    "Qtde on Produto.Codigo = Qtde.CodProd where Produto.Inativo = 'False' " & strTipoProduto & strFiltro2 & " " & _
                                    "group by Produto.Familia, Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Produto.Valor, Produto.ValorCusto, " & _
                                    "Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Grupo, " & _
                                    "Produto.Obs, Produto.Data, Produto.CodigoBarra, Produto.NivelComboCodCF, Produto.Desconto, " & _
                                    "Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.CodProdFor, Produto.Validade, Produto.Comissao, " & _
                                    "Produto.Locacao2,Produto.CodigoFabricante,  Produto.Familia, Produto.QtdEmb", Me.GridControl2)
                Else
                    CarregarDados("SELECT '' as QtdAdd, Produto.CodigoFabricante as CodSimilar, Produto.Codigo, Produto.Nome, " & _
                             "Produto.UnidadeMedida, Convert(" & strCasaDescimais & ", " & strResult & ") as Valor, " & _
                             "(select Locacao from Locacao where Locacao.CodProd = Produto.Codigo and Locacao.CodConfig  = " & CodConfig & ") as Locacao, " & _
                             "Produto.CodigoInterno, Produto.Fabricante, Produto.Familia, Produto.Grupo, Produto.Obs, " & _
                             "" & strCodigoBarra & ", Produto.CodProdFor, (SELECT sum(Convert(Numeric(15,3), Qtde.QtdMinima)) " & _
                             "FROM Qtde where Qtde.CodConfig = " & CodConfig & " and Produto.Codigo = Qtde.CodProd) as QtdMinima, " & _
                             "(SELECT sum(Convert(Numeric(15,3), Qtde.QtdMaxima)) " & _
                             "FROM Qtde where Qtde.CodConfig = " & CodConfig & " and Produto.Codigo = Qtde.CodProd) as QtdMaxima, (SELECT case when sum(EntradaNf.QtdProd) is null then 0 else sum(EntradaNf.QtdProd) end " & _
                             "FROM EntradaNf left join TotalEntradaNf on EntradaNf.CodTotNf = TotalEntradaNf.Codigo where " & _
                             "EntradaNf.CodProd = Produto. Codigo and EstoqueOk = 'True'" & strDataEntrada & ") - (SELECT case when sum(Pedido.Qtd) is null then 0 else " & _
                             "sum(Pedido.Qtd) end FROM Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and PEdido.CodConfig = Total.CodConfig where Pedido.CodProd = " & _
                             "Produto.Codigo and Pedido.Devolvido = 'False'" & strDataPedido & ") + (SELECT case when sum(AjusteQtde.Qtd) is null then 0 " & _
                             "else  sum(AjusteQtde.Qtd) end FROM AjusteQtde where " & _
                             "AjusteQtde.CodProd = Produto.Codigo" & strDataAjuste & ") as Qtd, Produto.Setor, Produto.Tipo, Produto.Locacao2 " & _
                             "FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where Produto.Inativo = 'False' " & _
                             "" & strTipoProduto & strFiltro2 & " group by Produto.Familia, Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Produto.Valor, " & _
                             "Produto.CodigoInterno, Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.CodigoBarra, " & _
                             "Produto.Setor, Produto.Tipo, Produto.CodProdFor, Produto.Locacao2, Produto.CodigoFabricante, Produto.ValorCusto, Produto.Porcentagens", Me.GridControl2)

                End If

            End If

        Else

            If EstoqueSomado = False Then
                CarregarDados("SELECT '' as QtdAdd, Produto.CodigoFabricante as CodSimilar, Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, " & _
                "Convert(" & strCasaDescimais & ", " & strResult & ") as Valor, " & _
                "Convert(" & strCasaDescimais & ", Produto.ValorCusto) as ValorCusto, (select Locacao from Locacao where Locacao.CodProd = Produto.Codigo and Locacao.CodConfig  = " & CodConfig & ") as Locacao, Produto.CodigoInterno, Produto.Porcentagens, " & _
                "Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.Data, Produto.Familia, " & strCodigoBarra & ", Produto.CodProdFor, Produto.Validade, " & _
                "(SELECT sum(Convert(Numeric(15,3), Qtde.QtdMinima)) FROM Qtde where Qtde.CodConfig = " & CodConfig & " and " & _
                "Produto.Codigo = Qtde.CodProd) as QtdMinima, (SELECT sum(Convert(Numeric(15,3), Qtde.QtdMaxima)) FROM Qtde where Qtde.CodConfig = " & CodConfig & " and " & _
                "Produto.Codigo = Qtde.CodProd) as QtdMaxima, (SELECT sum(Convert(Numeric(15,3), Qtde.Qtd)) FROM Qtde where " & _
                "Qtde.CodConfig = " & CodConfig & " and Produto.Codigo = Qtde.CodProd and Acabou = 'False') as Qtd, (SELECT Case when " & _
                "sum(Convert(Numeric(15,3), Qtde.EmFalta)) is Null then 1 Else sum(Convert(Numeric(15,3), Qtde.EmFalta)) End " & _
                "FROM Qtde where Qtde.Acabou = 'False' and Qtde.CodConfig = " & CodConfig & " and Produto.Codigo = Qtde.CodProd) as EmFalta, " & _
                "Produto.NivelComboCodCF, Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.Comissao, " & _
                "Produto.Locacao2, (SELECT Max(Total.Data) FROM Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and " & _
                "Total.CodConfig = Pedido.CodConfig where Pedido.CodProd = Produto.Codigo and Pedido.CodConfig = " & CodConfig & ") as DataUltVenda, " & _
                "case when Produto.Desconto > 0 then convert(" & strCasaDescimais & ",(Produto.Valor - ((Produto.Valor / 100) * Produto.Desconto))) else NULL end as ValPromocao, Produto.QtdEmb " & _
                "FROM Produto left join Qtde on " & _
                "Produto.Codigo = Qtde.CodProd where Produto.Inativo = 'False' " & strTipoProduto & strFiltro2 & " group by Produto.Familia, Produto.Codigo, Produto.Nome, " & _
                "Produto.UnidadeMedida, Produto.Valor, Produto.ValorCusto, Produto.CodigoInterno, Produto.Porcentagens, " & _
                "Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.Data, Produto.CodigoBarra, Produto.NivelComboCodCF, Produto.Desconto, " & _
                "Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.CodProdFor, Produto.Validade, Produto.Comissao, Produto.CodigoFabricante, Produto.Locacao2, Produto.QtdEmb", Me.GridControl2)

            Else
                'CarregarDados("SELECT Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Convert(Numeric(15,2), Produto.Valor) as Valor, " & _
                '"Convert(Numeric(15,2), Produto.ValorCusto) as ValorCusto, Produto.Locacao, Produto.CodigoInterno, Produto.Porcentagens, " & _
                '"Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.Data, Produto.CodigoBarra, Produto.CodProdFor, Produto.Validade, " & _
                '"(SELECT sum(Convert(Numeric(15,3), Qtde.QtdMinima)) FROM Qtde where Qtde.CodConfig = " & CodConfig & " and " & _
                '"Produto.Codigo = Qtde.CodProd) as QtdMinima, (SELECT case when sum(EntradaNf.QtdProd) is null then 0 else sum(EntradaNf.QtdProd) end " & _
                '"FROM EntradaNf left join TotalEntradaNf on EntradaNf.CodTotNf = TotalEntradaNf.Codigo where " & _
                '"EntradaNf.CodProd = Produto. Codigo and EstoqueOk = 'True' and EntradaNf.CodConfig = " & CodConfig & "" & strData & ") - (SELECT case when " & _
                '"sum(Pedido.Qtd) is null then 0 else sum(Pedido.Qtd) end FROM Pedido where Pedido.CodConfig = " & CodConfig & " and " & _
                '"Pedido.CodProd = Produto.Codigo and Pedido.Devolvido = 'False'" & strData & ") + (SELECT case when sum(AjusteQtde.Qtd) is null then 0 else  sum(AjusteQtde.Qtd) end " & _
                '"FROM AjusteQtde where AjusteQtde.CodConfig = " & CodConfig & " and AjusteQtde.CodProd = Produto.Codigo" & strData & ") as Qtd, " & _
                '"(SELECT Case when sum(Convert(Numeric(15,3), Qtde.EmFalta)) is Null then 1 else sum(Convert(Numeric(15,3), Qtde.EmFalta)) End " & _
                '"FROM Qtde where Qtde.Acabou = 'False' and Qtde.CodConfig = " & CodConfig & " and Produto.Codigo = Qtde.CodProd) as EmFalta, " & _
                '"Produto.NivelComboCodCF, Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.Comissao, " & _
                '"(SELECT Max(Total.Data) FROM Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and " & _
                '"Total.CodConfig = Pedido.CodConfig where Pedido.CodProd = Produto.Codigo and PEdido.Codconfig = " & CodConfig & ") as DataUltVenda, " & _
                '"Produto.Locacao2, convert(bit,(SELECT case when sum(Codigo) > 0 then 'True' else 'False' end FROM Campanha where Campanha.CodProd = " & _
                '"Produto.Codigo and Status = 'Lancado')) as Campanha, " & _
                '"case when Produto.Desconto > 0 then convert(Numeric(15,2),(Produto.Valor - ((Produto.Valor / 100) * Produto.Desconto))) else NULL end as ValPromocao " & _
                '"FROM Produto left join Qtde on " & _
                '"Produto.Codigo = Qtde.CodProd where Produto.Inativo = 'False' " & strFiltro2 & " group by Produto.Codigo, Produto.Nome, " & _
                '"Produto.UnidadeMedida, Produto.Valor, Produto.ValorCusto, Produto.Locacao, Produto.CodigoInterno, Produto.Porcentagens, " & _
                '"Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.Data, Produto.CodigoBarra, Produto.NivelComboCodCF, Produto.Desconto, " & _
                '"Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.CodProdFor, Produto.Validade, Produto.Comissao, Produto.Locacao2", Me.GridControl2)
                If Me.Tag = "CONSULTA" Then
                    CarregarDados("SELECT '' as QtdAdd, Produto.CodigoFabricante as CodSimilar, Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, " & _
                    "Convert(" & strCasaDescimais & ", " & strResult & ") as Valor, " & _
                    "Convert(" & strCasaDescimais & ", Produto.ValorCusto) as ValorCusto, (select Locacao from Locacao where Locacao.CodProd = Produto.Codigo and Locacao.CodConfig  = " & CodConfig & ") as Locacao, " & _
                    "Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Familia, Produto.Grupo, Produto.Obs, " & _
                    "Produto.Data, " & strCodigoBarra & ", Produto.CodProdFor, Produto.Validade, (SELECT " & _
                    "sum(Convert(Numeric(15,3), Qtde.QtdMinima)) FROM Qtde where Qtde.CodConfig = " & CodConfig & " and " & _
                    "Produto.Codigo = Qtde.CodProd) as QtdMinima, (SELECT " & _
                    "sum(Convert(Numeric(15,3), Qtde.QtdMaxima)) FROM Qtde where Qtde.CodConfig = " & CodConfig & " and " & _
                    "Produto.Codigo = Qtde.CodProd) as QtdMaxima, (SELECT case when sum(EntradaNf.QtdProd) is null then 0 " & _
                    "else sum(EntradaNf.QtdProd) end FROM EntradaNf left join TotalEntradaNf on EntradaNf.CodTotNf = " & _
                    "TotalEntradaNf.Codigo where EntradaNf.CodProd = Produto. Codigo and EstoqueOk = 'True'" & strDataEntrada & " and " & _
                    "EntradaNf.CodConfig = " & CodConfig & ") - (SELECT case when sum(Pedido.Qtd) is null then 0 else " & _
                    "sum(Pedido.Qtd) end FROM Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and PEdido.CodConfig = Total.CodConfig where Pedido.CodConfig = " & CodConfig & " and Pedido.CodProd = " & _
                    "Produto.Codigo and Pedido.Devolvido = 'False'" & strDataPedido & ") + (SELECT case when sum(AjusteQtde.Qtd) is null then 0 " & _
                    "else  sum(AjusteQtde.Qtd) end FROM AjusteQtde where AjusteQtde.CodConfig = " & CodConfig & " and " & _
                    "AjusteQtde.CodProd = Produto.Codigo" & strDataAjuste & ") as Qtd, (SELECT Case when sum(Convert(Numeric(15,3), " & _
                    "Qtde.EmFalta)) is Null then 1 else sum(Convert(Numeric(15,3), Qtde.EmFalta)) End " & _
                    "FROM Qtde where Qtde.Acabou = 'False' and Qtde.CodConfig = " & CodConfig & " and " & _
                    "Produto.Codigo = Qtde.CodProd) as EmFalta, Produto.NivelComboCodCF, Produto.Desconto, " & _
                    "(SELECT Max(Total.Data) FROM Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and " & _
                    "Total.CodConfig = Pedido.CodConfig where Pedido.CodProd = Produto.Codigo and Pedido.CodConfig = " & CodConfig & ") as DataUltVenda, " & _
                    "Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.Comissao, Produto.Locacao2, Produto.Familia, " & _
                    "convert(bit,(SELECT case when sum(Codigo) > 0 then 'True' else 'False' end FROM Campanha where " & _
                    "Campanha.CodProd = Produto.Codigo and Status = 'Lancado')) as Campanha, " & _
                    "case when Produto.Desconto > 0 then convert(" & strCasaDescimais & ",(Produto.Valor - ((Produto.Valor / 100) * Produto.Desconto))) else NULL end as ValPromocao, Produto.QtdEmb " & _
                    "FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where Produto.Inativo = 'False' " & _
                    "" & strTipoProduto & strFiltro2 & " group by Produto.Familia, Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Produto.Valor, " & _
                    "Produto.ValorCusto, Produto.CodigoInterno, Produto.Porcentagens, " & _
                    "Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.Data, Produto.CodigoBarra, " & _
                    "Produto.NivelComboCodCF, Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo, " & _
                    "Produto.CodProdFor, Produto.Validade, Produto.Comissao, Produto.Locacao2, Produto.CodigoFabricante, Produto.Familia, Produto.QtdEmb", Me.GridControl2)

                Else
                    CarregarDados("SELECT '' as QtdAdd, Produto.CodigoFabricante as CodSimilar, Produto.Codigo, Produto.Nome, " & _
                            "Produto.UnidadeMedida, Convert(" & strCasaDescimais & ", " & strResult & ") as Valor, " & _
                            "(select Locacao from Locacao where Locacao.CodProd = Produto.Codigo and Locacao.CodConfig  = " & CodConfig & ") as Locacao, " & _
                            "Produto.CodigoInterno, Produto.Fabricante, Produto.Familia, Produto.Grupo, Produto.Obs, " & _
                            "" & strCodigoBarra & ", Produto.CodProdFor, (SELECT sum(Convert(Numeric(15,3), Qtde.QtdMinima)) " & _
                            "FROM Qtde where Qtde.CodConfig = " & CodConfig & " and Produto.Codigo = Qtde.CodProd) as QtdMinima, " & _
                            "(SELECT sum(Convert(Numeric(15,3), Qtde.QtdMaxima)) " & _
                            "FROM Qtde where Qtde.CodConfig = " & CodConfig & " and Produto.Codigo = Qtde.CodProd) as QtdMaxima, (SELECT case when sum(EntradaNf.QtdProd) is null then 0 else sum(EntradaNf.QtdProd) end " & _
                            "FROM EntradaNf left join TotalEntradaNf on EntradaNf.CodTotNf = TotalEntradaNf.Codigo where " & _
                            "EntradaNf.CodProd = Produto. Codigo and EstoqueOk = 'True'" & strDataEntrada & " and " & _
                            "EntradaNf.CodConfig = " & CodConfig & ") - (SELECT case when sum(Pedido.Qtd) is null then 0 else " & _
                            "sum(Pedido.Qtd) end FROM Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and PEdido.CodConfig = Total.CodConfig where Pedido.CodConfig = " & CodConfig & " and Pedido.CodProd = " & _
                            "Produto.Codigo and Pedido.Devolvido = 'False'" & strDataPedido & ") + (SELECT case when sum(AjusteQtde.Qtd) is null then 0 " & _
                            "else  sum(AjusteQtde.Qtd) end FROM AjusteQtde where AjusteQtde.CodConfig = " & CodConfig & " and " & _
                            "AjusteQtde.CodProd = Produto.Codigo" & strDataAjuste & ") as Qtd, Produto.Setor, Produto.Tipo, Produto.Locacao2 " & _
                            "FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where Produto.Inativo = 'False' " & _
                            "" & strTipoProduto & strFiltro2 & " group by Produto.Familia, Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Produto.Valor, " & _
                            "Produto.CodigoInterno, Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.CodigoBarra, " & _
                            "Produto.Setor, Produto.Tipo, Produto.CodProdFor, Produto.Locacao2, Produto.CodigoFabricante, Produto.ValorCusto, Produto.Porcentagens", Me.GridControl2)

                End If
            End If

        End If


        Me.txtFiltroProduto.Text = strFiltroProduto
        If Me.txtFiltroProduto.Text <> "" Then
            FiltroProduto()
        End If
        Dim index As Integer = -999997
        grd1.FocusedRowHandle = index
        grd1.FocusedColumn = Me.colNome
        grd1.ShowEditor()
    End Sub

    Private Sub frmConProduto_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If NomeEmpresa.ToUpper.Contains("LDN AUTO") = True Then

            e.Cancel = True
            Me.Visible = False
            Me.Timer1.Stop()
        End If
    End Sub
    Private Sub frmConProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        If e.KeyCode = Keys.F10 Then
            CodigoDoProduto = 0
            frmCodigoBarra.Tag = "CONSULTA"
            frmCodigoBarra.ShowDialog()
            If Me.Tag = "VENDA" Or Me.Tag = "RECEITA" Or Me.Tag = "ENTRADANF" Or Me.Tag = "DESCARTE" Or Me.Tag = "PEDIDO" Then
                If CodigoDoProduto > 0 Then
                    Me.Close()
                    Exit Sub
                End If
            End If

        End If

        If e.KeyCode = Keys.F9 Then
            Me.grd1.ClearColumnsFilter()
            Me.txtFiltroProduto.ResetText()
            Me.txtFiltroProduto.Focus()
        End If

    End Sub

    Private Sub frmConProduto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TipoNano = 2 Then
            Me.colLocacao2.Visible = True
        End If

        AtualizarGrid(False)

        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)

        If ObsProduto = True Then
            Me.txtObs.Visible = True
            Me.lblObs.Visible = True
            Me.grpProd.Size = New System.Drawing.Size(1008, 358)
        End If
        If TipoNano = 2 Or TipoNano = 5 Then
            Me.txtObs.Visible = True
            Me.lblObs.Visible = True
            Me.lblObs.Text = "Aplicação"
            Me.colObs.Caption = "Aplicação"
            Me.colObs.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains

            Me.grpProd.Size = New System.Drawing.Size(1008, 358)

            Me.txtCodSimilar.Location = New System.Drawing.Point(765, 226)
            Me.LabelControl9.Location = New System.Drawing.Point(765, 205)
            'Me.txtCodSimilar.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point)

        End If

        If Me.Tag <> "CONSULTA" Then
            Me.btnCalcular.Visible = False
            Me.txtQtdTotal.Visible = False
            Me.txtCapital.Visible = False
            Me.lblCap.Visible = False
            Me.lblQtdTotal.Visible = False
            Me.cboPreco.Visible = False

            Me.colQtdEmb.Visible = False
            Me.colEmFalta1.Visible = False
            Me.colComissao.Visible = False
            Me.colValidade.Visible = False
            Me.colDesconto.Visible = False
            Me.colData.Visible = False
            Me.colCampanha.Visible = False
            Me.colDataUltVenda.Visible = False
            Me.colInativo.Visible = False
            Me.colNivelComboCodCF.Visible = False
            Me.colPorcentagens.Visible = False
            Me.colValPromocao.Visible = False
            Me.colValorCusto.Visible = False
        Else
            If Nivel = "USUÁRIO" Then
                Me.btnCalcular.Visible = False
                Me.txtQtdTotal.Visible = False
                Me.txtCapital.Visible = False
                Me.lblCap.Visible = False
                Me.lblQtdTotal.Visible = False
                Me.cboPreco.Visible = False

                Me.colValorCusto.Visible = False
            End If

            Me.colQtdAdd.Visible = False
        End If

        Me.GridQtd.Visible = BaixaPorLote


        If TipoNano = 5 Then
            Me.GridQtd.Visible = True
            If BaixaPorLote = False Then
                Me.colTamanho.Caption = "Loja"
                Me.cboGrp.Size = New System.Drawing.Size(204, 26)
            End If
        End If

        'If NomeEmpresa.Contains("SKINA") Then
        '    Me.colNome.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default
        'End If
        If BaixaPorLote = True Then
            Me.cboGrp.Size = New System.Drawing.Size(204, 26)

        End If
        If EstoqueSomado = False Then
            Me.dtDataEstoque.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnFiltrar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

        If FiltroProdutoContem = True Then
            Me.colNome.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Me.colCodSimilar.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Me.colCodigoBarra.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End If

        Timer1.Start()
    End Sub

    Private Sub Limpar()
        Me.txtObs.ResetText()
        strCodProd = ""
        Me.txtValidade.ResetText()
        Me.txtQtd.ResetText()
        Me.picImagem1.Image = Nothing
        Me.picImagem2.Image = Nothing
        Me.txtNome.ResetText()
        Me.txtVal.ResetText()
        Me.txtLoc.ResetText()
        Me.cboUniMed.SelectedIndex = -1
        Me.txtCodPc.ResetText()
        Me.txtFornecedor.ResetText()
        Me.txtSetor.ResetText()
        Me.cboGrp.SelectedIndex = -1
        Me.txtCodSimilar.ResetText()
        Me.txtEmPedido.ResetText()
        Me.txtCodBarra.ResetText()
        Me.txtFamilia.ResetText()
        Me.txtQtdEmb.ResetText()
        Me.tbQtd.Rows.Clear()
    End Sub
    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub

    Private Sub grd1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grd1.FocusedRowChanged
        If Me.grd1.FocusedRowHandle < 0 Then
            Limpar()
            Exit Sub
        End If
        strCodProd = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)
        Me.txtCodPc.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigoInterno)
        Me.txtFornecedor.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colFabricante)
        'Me.txtCodBarra.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigoBarra)
        Me.txtLoc.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colLocacao)
        Me.txtNome.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colNome)
        Me.txtSetor.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colSetor)
        Me.cboGrp.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colGrupo)
        Me.cboUniMed.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colUnidadeMedida)
        Me.txtVal.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colValor)
        Me.txtQtd.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colQtd1)
        Me.txtValidade.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colValidade)
        Me.txtObs.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colObs)
        Me.txtCodSimilar.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodSimilar)
        Me.txtFamilia.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colFamilia)
        CarregarImagem(Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo))
        If BaixaPorLote = True Then
            CarregarQtd(Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo))
        End If
        Me.txtQtdEmb.Text = CampoValor(Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colQtdEmb))
        If TipoNano = 5 Then
            If BaixaPorLote = False Then
                If Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo) <> "" Then
                    CarregarQtdeLoja(Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo))
                End If
            End If
        End If

        Dim strFiltro As String = " and ItensConsig.CodConfig = " & CodConfig
        If Me.Tag <> "VENDA" Then
            If Master = True Then
                strFiltro = ""
            End If
        End If
        Dim dtCons As DataTable = CarregarDataTable("SELECT sum(Qtd) as Pendente FROM ItensConsig inner join TotalConsig on ItensConsig.CodOrdens = TotalConsig.CodOrdens and ItensConsig.CodConfig = TotalConsig.CodConfig where CodigoProduto = '" & strCodProd & "' and TotalConsig.Status = 'Pendente' " & strFiltro)
        If dtCons.Rows.Count > 0 Then

            Me.txtEmPedido.Text = dtCons.Rows.Item(0).Item("Pendente").ToString

        End If

        CarregarComboCodigoBarra()
    End Sub
    Private Sub CarregarComboCodigoBarra()
        Dim dt As DataTable
        Dim I As Integer
        Dim strFil As String = ""
        Me.txtCodBarra.Properties.Items.Clear()
        Me.txtCodBarra.Text = ""
        If strCodProd = "" Then Exit Sub
        dt = CarregarDataTable("SELECT CodigoBarra FROM Produto where Codigo = " & strCodProd)
        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).ItemArray(0).ToString <> "" Then
                Me.txtCodBarra.Properties.Items.Add(dt.Rows.Item(0).ItemArray(0))
                strFil = " and CodigoBarra <> '" & dt.Rows.Item(0).ItemArray(0) & "'"
                Me.txtCodBarra.Text = dt.Rows.Item(0).ItemArray(0).ToString
            End If

        End If

        dt = CarregarDataTable("SELECT CodigoBarra FROM CodigoBarra where CodProd = " & strCodProd & strFil & " and Produto is null or CodProd = " & strCodProd & strFil & " and Produto =''")
        For I = 0 To dt.Rows.Count - 1
            Me.txtCodBarra.Properties.Items.Add(dt.Rows.Item(I).ItemArray(0))
        Next
    End Sub
    Private Sub CarregarImagem(ByVal parCodigo As String)
        If parCodigo = "" Then Exit Sub
        Dim dt As DataTable = CarregarDataTable("SELECT Imagem1, Imagem2 FROM Produto where Codigo = " & parCodigo)
        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item("Imagem1").ToString <> "" Then
                Dim Imagem As Byte() = CType(dt.Rows.Item(0).Item("Imagem1"), Byte())

                Dim memorybits As New MemoryStream(Imagem)

                Dim bitmap As New Bitmap(memorybits)


                Me.picImagem1.Image = bitmap
            Else

                Me.picImagem1.Image = Nothing
            End If
            If dt.Rows.Item(0).Item("Imagem2").ToString <> "" Then
                Dim Imagem As Byte() = CType(dt.Rows.Item(0).Item("Imagem2"), Byte())

                Dim memorybits As New MemoryStream(Imagem)

                Dim bitmap As New Bitmap(memorybits)


                Me.picImagem2.Image = bitmap
            Else

                Me.picImagem2.Image = Nothing

            End If
        End If
    End Sub

    Private Sub CarregarQtd(ByVal parCodigo As String)
        If parCodigo = "" Then Exit Sub
        tbQtd.Rows.Clear()

        Dim dt As DataTable

        dt = CarregarDataTable("Select Tamanho, Qtd from Qtde where CodConfig=" & CodConfig & " and Acabou ='False' and CodProd =" & parCodigo)

        Dim I As Integer

        For I = 0 To dt.Rows.Count - 1
            With tbQtd.Rows
                .Add()
                .Item(I).Item("Tamanho") = dt.Rows.Item(I).Item("Tamanho").ToString
                .Item(I).Item("Qtd") = dt.Rows.Item(I).Item("Qtd").ToString
            End With
        Next
    End Sub
    Private Sub nbcImagem_NavPaneStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nbcImagem.NavPaneStateChanged
        If nbcImagem.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed Then
            ' Me.nbgImagem.Caption = "IMAGEM"
            Me.nbgImagem.GroupClientHeight = 80
            Me.btnOcultar.Visible = False
        Else

            Me.btnOcultar.Visible = True
            ' Me.nbgImagem.Caption = ""

            Me.nbcImagem.PaintStyleName = "ExplorerBarView"

            Me.nbcImagem.Appearance.GroupBackground.BackColor = Color.Transparent
            Me.nbcImagem.Appearance.Background.BackColor = Color.Transparent
            Me.nbgImagem.GroupClientHeight = 176
            Me.nbgImagem.Appearance.BackColor = Color.Transparent

            Me.nbgImagem.Expanded = True
        End If
    End Sub
    Private Sub nbcImagem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbcImagem.Click
        Try
            If Me.nbcImagem.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed Then
                If Me.nbcImagem.NavPaneForm.ExpandedGroup.Expanded = True Then
                    Me.nbcImagem.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnOcultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOcultar.Click
        Me.nbcImagem.PaintStyleName = "SkinNavigationPane"
        Me.nbcImagem.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnDados_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDados.ItemClick

        Dim rel As New relDadosProduto
        Dim bolImagem As Boolean = True
        If Me.nbcImagem.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed Then
            rel.lblImagens.Visible = False
            rel.picImagem1.Visible = False
            rel.picImagem2.Visible = False
            rel.pnlProd.Size = New System.Drawing.Size(758, 108)
            rel.Detail.Height = 108
            bolImagem = False
        End If
        Dim I As Integer
        With rel.tbProd.Rows
            For I = 0 To Me.grd1.RowCount - 1
                .Add()
                .Item(I).Item("CodigoPeca") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)
                .Item(I).Item("Setor") = Me.grd1.GetRowCellDisplayText(I, Me.colSetor)
                .Item(I).Item("CodigoBarras") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoBarra)
                .Item(I).Item("Locacao") = Me.grd1.GetRowCellDisplayText(I, Me.colLocacao)
                .Item(I).Item("Nome") = Me.grd1.GetRowCellDisplayText(I, Me.colNome)
                .Item(I).Item("Fabricante") = Me.grd1.GetRowCellDisplayText(I, Me.colFabricante)
                .Item(I).Item("Grupo") = Me.grd1.GetRowCellDisplayText(I, Me.colGrupo)
                .Item(I).Item("Valor") = Me.grd1.GetRowCellDisplayText(I, Me.colValor)
                .Item(I).Item("Qtd") = Me.grd1.GetRowCellDisplayText(I, Me.colQtd1)
                .Item(I).Item("UM") = Me.grd1.GetRowCellDisplayText(I, Me.colUnidadeMedida)
                If bolImagem = True Then
                    Dim dtProd As DataTable = CarregarDataTable("SELECT Imagem1, Imagem2 FROM Produto where Codigo = '" & Me.grd1.GetRowCellDisplayText(I, Me.colCodigo) & "'")
                    If dtProd.Rows.Count > 0 Then
                        If dtProd.Rows.Item(0).Item("Imagem1").ToString <> "" Then
                            Dim Imagem As Byte() = CType(dtProd.Rows.Item(0).Item("Imagem1"), Byte())

                            Dim memorybits As New MemoryStream(Imagem)

                            Dim bitmap As New Bitmap(memorybits)


                            .Item(I).Item("Imagem1") = Imagem
                        Else

                            .Item(I).Item("Imagem1") = Nothing
                        End If
                        If dtProd.Rows.Item(0).Item("Imagem2").ToString <> "" Then
                            Dim Imagem As Byte() = CType(dtProd.Rows.Item(0).Item("Imagem2"), Byte())

                            Dim memorybits As New MemoryStream(Imagem)

                            Dim bitmap As New Bitmap(memorybits)


                            .Item(I).Item("Imagem2") = Imagem
                        Else

                            .Item(I).Item("Imagem2") = Nothing

                        End If
                    End If
                End If

            Next
        End With

        rel.ShowPreview()

    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relProduto

        rel.picLogo.Image = LogoTipo

        With rel.tbProd.Rows
            Dim I As Integer
            Dim A As Integer = 0

            For I = 0 To Me.grd1.RowCount - 1
                If Me.grd1.GetRowCellDisplayText(I, Me.colNome) <> "" Then
                    .Add()
                    .Item(A).Item("CodigoInterno") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)
                    .Item(A).Item("CodigoBarra") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoBarra)
                    .Item(A).Item("Nome") = Me.grd1.GetRowCellDisplayText(I, Me.colNome)
                    .Item(A).Item("Qtd") = Me.grd1.GetRowCellDisplayText(I, Me.colQtd1)
                    .Item(A).Item("ValorUnitario") = Me.grd1.GetRowCellDisplayText(I, Me.colValor)
                    .Item(A).Item("Grupo") = Me.grd1.GetRowCellDisplayText(I, Me.colGrupo)
                    A += 1
                End If
            Next
        End With

        rel.lblPro.Text = Me.txtQtdTotal.Text
        rel.lblTotal.Text = Me.txtCapital.Text

        rel.ShowPreview()
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl2.ShowPrintPreview()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Tag = "CONSULTA" Then
            Me.btnAbrir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.Bar3.ItemLinks(2).BeginGroup = False

        End If

        'If Me.Tag = "VENDA" Then
        '    If NomeEmpresa.ToUpper.Contains("LDN AUTO") = True Then
        '        AtualizarGrid(False)
        '    End If
        'End If

        Dim index As Integer = -999997
        grd1.FocusedRowHandle = index
        grd1.FocusedColumn = Me.colNome
        grd1.ShowEditor()

        txtQtdPro.Text = grd1.RowCount




        clsSizeGrid.Size(Me.grd1)

        ' EnableColumnPanelAutoHeight()

        'Dim intdd As Integer = Me.grd1.ColumnPanelRowHeight
        'Me.grd1.RowHeight = intdd
        Timer1.Stop()
    End Sub

    Private Sub btnAbrir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAbrir.ItemClick
        Me.txtFiltroProduto.Focus()
        Dim strOk As Boolean
        VerificarQtde(Me.grd1.FocusedRowHandle, strOk)
        RetornaPesquisa()
    End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        Dim strOk As Boolean
        VerificarQtde(Me.grd1.FocusedRowHandle, strOk)
        RetornaPesquisa()
    End Sub
    Private Sub RetornaPesquisa()

        If grd1.FocusedRowHandle < 0 Then Exit Sub

        If Me.Tag = "VENDA" Or Me.Tag = "RECEITA" Or Me.Tag = "ENTRADANF" Or Me.Tag = "DESCARTE" Or Me.Tag = "PEDIDO" Then


            Me.grd1.ClearColumnsFilter()

            grd1.ActiveFilter.NonColumnFilter = "[QtdAdd] <> ''"

            Dim I As Integer
            For I = 0 To Me.grd1.RowCount - 1
                If I = 0 Then
                    CodigoDoProdutoAgrupado = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo) & "%" & Me.grd1.GetRowCellDisplayText(I, Me.colQtdAdd)

                Else
                    CodigoDoProdutoAgrupado &= "|" & Me.grd1.GetRowCellDisplayText(I, Me.colCodigo) & "%" & Me.grd1.GetRowCellDisplayText(I, Me.colQtdAdd)
                End If
                Dim strOk As Boolean
                VerificarQtde(I, strOk)
                If strOk = False Then
                    CodigoDoProdutoAgrupado = ""
                    'Me.grd1.ClearColumnsFilter()
                    grd1.FocusedRowHandle = I
                    grd1.FocusedColumn = Me.colQtdAdd
                    grd1.ShowEditor()
                    Me.grd1.ClearColumnsFilter()

                    Exit Sub
                End If
            Next

            If NomeEmpresa.ToUpper.Contains("LDN AUTO") = True Then
                If Me.Tag = "VENDA" Then
                    If CodigoDoProdutoAgrupado <> "" Then

                        Dim vetProd As Array = Split(CodigoDoProdutoAgrupado, "|")

                        For I = 0 To vetProd.Length - 1
                            Dim vetCodProd As Array = Split(vetProd(I), "%")
                            CodigoDoProduto = vetCodProd(0)
                            If Me.txtQtd.Text = "" Then
                                Me.txtQtd.Text = vetCodProd(1)
                            End If

                            frmVenda.InserirProduto(True, False, "", frmVenda.lblTabela.Caption)
                            QtdeDoProduto = 0
                            CodigoDoProduto = -1
                        Next
                    Else
                        frmVenda.txtCodPro.ResetText()
                    End If

                ElseIf Me.Tag = "PEDIDO" Then
                    If CodigoDoProdutoAgrupado <> "" Then

                        Dim vetProd As Array = Split(CodigoDoProdutoAgrupado, "|")
                        If vetProd.Length = 1 Then
                            Dim vetCodProd As Array = Split(vetProd(0), "%")
                            CodigoDoProduto = vetCodProd(0)
                            frmPedido.txtQtd.Text = vetCodProd(1)
                            frmPedido.QtdEmb(CodigoDoProduto)
                            frmPedido.InserirProdutos()
                            QtdeDoProduto = 0
                            CodigoDoProduto = -1
                        Else
                            If TipoNano = 5 Then
                                If frmPedido.cboCodFunc.Text = "" Then
                                    frmPedido.InserirVendedor()
                                    If frmPedido.cboCodFunc.Text = "" Then
                                        MsgBox("Nenhum funcionário selecionado!", MsgBoxStyle.Information)
                                        CodigoDoProdutoAgrupado = ""
                                        Exit Sub
                                    End If
                                End If
                            End If

                            For I = 0 To vetProd.Length - 1
                                Dim vetCodProd As Array = Split(vetProd(I), "%")
                                CodigoDoProduto = vetCodProd(0)
                                frmPedido.txtQtd.Text = vetCodProd(1)
                                frmPedido.InserirProdutos()
                                frmPedido.Adicinar()

                                QtdeDoProduto = 0
                                CodigoDoProduto = -1
                            Next

                        End If

                    Else
                        frmPedido.txtCodPro.ResetText()

                    End If
                End If
                CodigoDoProdutoAgrupado = ""
                'Me.grd1.ClearColumnsFilter()
                Dim index As Integer = -999997
                grd1.FocusedRowHandle = index
                grd1.FocusedColumn = Me.colQtdAdd
                grd1.ShowEditor()
                For I = 0 To Me.grd1.RowCount - 1
                    Me.grd1.SetRowCellValue(0, Me.colQtdAdd, "")
                Next
                Me.grd1.ClearColumnsFilter()

                Me.Visible = False
                Me.Timer1.Stop()
                Exit Sub
            Else
                CodigoDoProduto = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)

                QtdeDoProduto = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colQtdAdd)
                Me.Close()
                Exit Sub
            End If

        End If
    End Sub

    Private Sub txtAlterar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlterar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim strOk As Boolean
            VerificarQtde(Me.grd1.FocusedRowHandle, strOk)
            RetornaPesquisa()
        End If
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        With grd1

            Dim I As Integer
            Dim dblTotCap, dblQtdTotal As Double


            For I = 0 To .RowCount - 1

                Dim dblValLinha, dblQtd As Double

                If .GetRowCellDisplayText(I, Me.colQtd1) <> "" Then
                    dblQtd = .GetRowCellDisplayText(I, Me.colQtd1)

                    If dblQtd < 0 Then
                        dblQtd = 0
                    End If
                    dblQtdTotal += dblQtd

                    Select Case Me.cboPreco.Text

                        Case "Valor Custo"

                            If .GetRowCellDisplayText(I, Me.colValorCusto) <> "" Then
                                dblValLinha = .GetRowCellDisplayText(I, Me.colValorCusto)
                            End If


                        Case "Valor Venda"
                            If .GetRowCellDisplayText(I, Me.colValor) <> "" Then
                                dblValLinha = .GetRowCellDisplayText(I, Me.colValor)
                            End If

                    End Select

                    dblTotCap += dblQtd * dblValLinha
                End If
            Next

            Me.txtCapital.Text = dblTotCap.ToString("###,###,##0.00")
            Me.txtQtdTotal.Text = dblQtdTotal
        End With
    End Sub

    Private Sub btnTabela_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTabela.ItemClick
        frmRelTabelaPreco.Show()
    End Sub

    Private Sub btnFiltrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFiltrar.ItemClick
        Dim data1, data2 As String
        data1 = Me.dtDataEstoque.EditValue

        If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Sub

        AtualizarGrid(True)
    End Sub

    Private Sub btnFonte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFonte.Click
        Dim dlg As FontDialog = New FontDialog()
        dlg.Font = Me.colNome.AppearanceCell.Font

        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim strStyle As String = dlg.Font.Style.ToString

            Dim strNome As String = dlg.Font.Name.ToString
            Dim dblSize As Single = dlg.Font.Size
            Dim fs As FontStyle = FontStyle.Regular
            Select Case strStyle
                Case "Bold"
                    fs = FontStyle.Bold
                Case "Italic"
                    fs = FontStyle.Italic
                Case "Regular"
                    fs = FontStyle.Regular
                Case "Strikeout"
                    fs = FontStyle.Strikeout
                Case "Underline"
                    fs = FontStyle.Underline
                Case "Bold, Italic"
                    fs = FontStyle.Bold Or FontStyle.Italic
            End Select

            Dim A As Integer
            For A = 0 To Me.grd1.Columns.Count - 1
                Me.grd1.Columns.Item(A).AppearanceCell.Font = New Font(strNome, dblSize, fs)
                Me.grd1.Columns.Item(A).AppearanceHeader.Font = New Font(strNome, dblSize, fs)
            Next

            Timer1.Start()
        End If
    End Sub



    'Public Sub DisableColumnPanelAutoHeight()
    '    UnsubscribeFromEvents()
    'End Sub

    'Private Sub UnsubscribeFromEvents()
    '    RemoveHandler Me.grd1.ColumnWidthChanged, AddressOf OnColumnWidthChanged
    '    RemoveHandler Me.grd1.GridControl.Resize, AddressOf OnGridControlResize
    '    RemoveHandler Me.grd1.EndSorting, AddressOf OnGridColumnEndSorting
    'End Sub
    'Public Sub EnableColumnPanelAutoHeight()
    '    SetColumnPanelHeight()
    '    SubscribeToEvents()
    'End Sub

    'Private Sub SubscribeToEvents()
    '    AddHandler Me.grd1.ColumnWidthChanged, AddressOf OnColumnWidthChanged
    '    AddHandler Me.grd1.GridControl.Resize, AddressOf OnGridControlResize
    '    AddHandler Me.grd1.EndSorting, AddressOf OnGridColumnEndSorting
    'End Sub

    'Private Sub OnGridColumnEndSorting(ByVal sender As Object, ByVal e As EventArgs)
    '    Me.grd1.GridControl.BeginInvoke(New MethodInvoker(AddressOf SetColumnPanelHeight))
    'End Sub

    'Private Sub OnGridControlResize(ByVal sender As Object, ByVal e As EventArgs)
    '    SetColumnPanelHeight()
    'End Sub

    'Private Sub OnColumnWidthChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    '    SetColumnPanelHeight()
    'End Sub
    'Private Sub SetColumnPanelHeight()
    '    Dim viewInfo As GridViewInfo = TryCast(Me.grd1.GetViewInfo(), GridViewInfo)
    '    Dim height As Integer = 0
    '    For i As Integer = 0 To Me.grd1.VisibleColumns.Count - 1
    '        height = Math.Max(GetColumnBestHeight(viewInfo, Me.grd1.VisibleColumns(i)), height)
    '    Next i
    '    Me.grd1.ColumnPanelRowHeight = height
    'End Sub
    'Private Function GetColumnBestHeight(ByVal viewInfo As GridViewInfo, ByVal column As GridColumn) As Integer
    '    Dim ex As GridColumnInfoArgs = viewInfo.ColumnsInfo(column)
    '    If ex Is Nothing Then
    '        viewInfo.GInfo.AddGraphics(Nothing)
    '        ex = New GridColumnInfoArgs(viewInfo.GInfo.Cache, Nothing)
    '        Try
    '            ex.InnerElements.Add(New DrawElementInfo(New GlyphElementPainter(), New GlyphElementInfoArgs(viewInfo.View.Images, 0, Nothing), StringAlignment.Near))
    '            If viewInfo.View.CanShowFilterButton(Nothing) Then
    '                ex.InnerElements.Add(viewInfo.Painter.ElementsPainter.FilterButton, New GridFilterButtonInfoArgs())
    '            End If
    '            ex.SetAppearance(viewInfo.PaintAppearance.HeaderPanel)
    '            ex.Caption = column.Caption
    '            ex.CaptionRect = New Rectangle(0, 0, column.Width - 20, 17)
    '        Finally
    '            viewInfo.GInfo.ReleaseGraphics()
    '        End Try
    '    End If
    '    Dim grInfo As New GraphicsInfo()
    '    grInfo.AddGraphics(Nothing)
    '    ex.Cache = grInfo.Cache
    '    Dim canDrawMore As Boolean = True
    '    Dim captionSize As Size = CalcCaptionTextSize(grInfo.Cache, TryCast(ex, HeaderObjectInfoArgs), column.Caption)
    '    Dim res As Size = ex.InnerElements.CalcMinSize(grInfo.Graphics, canDrawMore)
    '    res.Height = Math.Max(res.Height, captionSize.Height)
    '    res.Width += captionSize.Width
    '    res = viewInfo.Painter.ElementsPainter.Column.CalcBoundsByClientRectangle(ex, New Rectangle(Point.Empty, res)).Size
    '    grInfo.ReleaseGraphics()
    '    Return res.Height
    'End Function
    'Private Function CalcCaptionTextSize(ByVal cache As GraphicsCache, ByVal ee As HeaderObjectInfoArgs, ByVal caption As String) As Size
    '    Dim captionSize As Size = ee.Appearance.CalcTextSize(cache, caption, ee.CaptionRect.Width).ToSize()
    '    captionSize.Height += 1
    '    captionSize.Width += 1
    '    Return captionSize
    'End Function

    Private Sub btnCodBarra_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCodBarra.ItemClick

        CodigoDoProduto = 0
        frmCodigoBarra.Tag = "CONSULTA"
        frmCodigoBarra.ShowDialog()
        If Me.Tag = "VENDA" Or Me.Tag = "RECEITA" Or Me.Tag = "ENTRADANF" Or Me.Tag = "DESCARTE" Or Me.Tag = "PEDIDO" Then
            If CodigoDoProduto > 0 Then
                Me.Close()
                Exit Sub
            End If
        End If
    End Sub


    Private Sub CarregarQtdeLoja(ByVal parCodProd As Integer)
        Dim dt1 As DataTable
        Dim strSql As String = ""
        Dim strQtdes As String = ""

        Select Case cboUniMed.SelectedIndex

            Case 3, 4
                strQtdes = "Convert(Numeric(15,3), Qtd) as Qtd"

            Case 5, 6

                strQtdes = "Convert(Numeric(15,2), Qtd) as Qtd"
            Case Else

                strQtdes = "Convert(Numeric(15), Qtd) as Qtd"

        End Select

        Me.colQtd1.OptionsColumn.ReadOnly = True

        Me.tbQtd.Rows.Clear()

        Dim strVerificaCodConfig As String = ""
        Dim A As Integer = 0
        Dim I As Integer

        If EstoqueSomado = False Then

            If Master = True Then
                strSql = "SELECT " & strQtdes & ", CodConfig FROM Produto where Codigo = '" & parCodProd & "' order by CodConfig"
            Else
                strSql = "SELECT " & strQtdes & ", CodConfig FROM Produto where Codigo = '" & parCodProd & "' and CodConfig =" & CodConfig
            End If
            dt1 = CarregarDataTable(strSql)

            For I = 0 To dt1.Rows.Count - 1
                Dim dtConfig As DataTable = CarregarDataTable("SELECT Descricao FROM Config where Codigo = " & dt1.Rows.Item(I).Item("CodConfig").ToString)
                Me.tbQtd.Rows.Add()
                'Me.tbQtd.Rows.Item(I).Item("CodConfig") = dt1.Rows.Item(I).Item("CodConfig").ToString
                Me.tbQtd.Rows.Item(I).Item("Tamanho") = dtConfig.Rows.Item(0).Item("Descricao").ToString
                Me.tbQtd.Rows.Item(I).Item("Qtd") = dt1.Rows.Item(I).Item("Qtd").ToString
            Next
        Else
            Dim dtConfig As DataTable = CarregarDataTable("SELECT Codigo, Descricao FROM Config order by Codigo")
            Dim B As Integer
            For B = 0 To dtConfig.Rows.Count - 1

                Me.tbQtd.Rows.Add()

                'Me.tbQtd.Rows.Item(B).Item("CodConfig") = dtConfig.Rows.Item(B).Item("Codigo").ToString
                Me.tbQtd.Rows.Item(B).Item("Tamanho") = dtConfig.Rows.Item(B).Item("Descricao").ToString

                Dim dblResul As Double = AjusteQtde(dtConfig.Rows.Item(B).Item("Codigo").ToString, parCodProd)

                Dim strResul As String = dblResul
                Select Case cboUniMed.SelectedIndex
                    Case 3, 4
                        strResul = dblResul.ToString("0.000")
                    Case 5, 6
                        strResul = dblResul.ToString("0.00")
                    Case Else
                        strResul = dblResul.ToString("0")
                End Select
                Me.tbQtd.Rows.Item(B).Item("Qtd") = strResul
            Next
        End If
    End Sub

    Public Sub FiltroProduto()
        Me.grd1.ActiveFilter.Clear()


        If Me.txtFiltroProduto.Text <> "" Then

            Dim strFiltro As String = Me.txtFiltroProduto.Text
            If strFiltro.Contains(" ") Then

                Dim vetFiltro As Array = Split(strFiltro.Trim, " ")
                Select Case vetFiltro.Length
                    Case 1
                        grd1.ActiveFilter.NonColumnFilter = "[Nome] like '%" & vetFiltro(0) & "%' or [Obs] like '%" & vetFiltro(0) & "%' or [Grupo] like '%" & vetFiltro(0) & "%' or [Setor] like '%" & vetFiltro(0) & "%' or [Fabricante] like '%" & vetFiltro(0) & "%' or [CodigoInterno] like '%" & vetFiltro(0) & "%'"

                    Case 2
                        grd1.ActiveFilter.NonColumnFilter = "[Nome] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%'"

                    Case 3
                        grd1.ActiveFilter.NonColumnFilter = "[Nome] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%'" & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%'" & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%'" & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%'" & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%'" & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%'" & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Nome] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%'" & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%'" & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%'" & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%'" & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%'" & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%'" & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Obs] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%'" & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%'" & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%'" & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%'" & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%'" & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%'" & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Grupo] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%'" & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%'" & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%'" & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%'" & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%'" & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%'" & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Setor] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%'" & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%'" & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%'" & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%'" & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%'" & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%'" & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [CodigoInterno] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%'" & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Fabricante] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%'" & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Nome] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%'" & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Obs] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%'" & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Grupo] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%'" & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [Setor] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Fabricante] like '%" & vetFiltro(2) & "%'" & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Nome] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Obs] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Grupo] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [Setor] like '%" & vetFiltro(2) & "%' " & _
                        "or [Fabricante] like '%" & vetFiltro(0) & "%' and [CodigoInterno] like '%" & vetFiltro(1) & "%' and [CodigoInterno] like '%" & vetFiltro(2) & "%'" 

                    Case Else
                        grd1.ActiveFilter.NonColumnFilter = "[Nome] like '%" & strFiltro & "%' or [Obs] like '%" & strFiltro & "%' or [Grupo] like '%" & strFiltro & "%' or [Setor] like '%" & strFiltro & "%' or [Fabricante] like '%" & strFiltro & "%' or [CodigoInterno] like '%" & strFiltro & "%'"
                End Select

            Else
                'grd1.ActiveFilter.NonColumnFilter = "[Nome] like '%" & strFiltro & "%' or [CPF] like '%" & strFiltro & "%'"
                grd1.ActiveFilter.NonColumnFilter = "[Nome] like '%" & strFiltro & "%' or [Obs] like '%" & strFiltro & "%' or [Grupo] like '%" & strFiltro & "%' or [Setor] like '%" & strFiltro & "%' or [Fabricante] like '%" & strFiltro & "%' or [CodigoInterno] like '%" & strFiltro & "%'"

            End If


        End If
        'If grd1.RowCount > 1 Then
        '    Dim index As Integer = -999997
        '    'If grdCliente.FocusedRowHandle >= 0 Then
        '    grd1.FocusedRowHandle = index
        '    grd1.FocusedColumn = Me.colNome
        'End If
    End Sub
    Private Sub txtQtdAdd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQtdAdd.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim strOk As Boolean
            VerificarQtde(Me.grd1.FocusedRowHandle, strOk)
            RetornaPesquisa()
        End If
    End Sub


    Private Sub VerificarQtde(ByVal parIndex As Integer, ByRef parOK As Boolean)
        Dim intIndex As Integer = parIndex
        If intIndex < 0 Then Exit Sub
        Me.txtFiltroProduto.Focus()

        Dim dblQtdAdd As Double = 1
        If Me.grd1.GetRowCellDisplayText(intIndex, Me.colQtdAdd) <> "" Then
            dblQtdAdd = Me.grd1.GetRowCellDisplayText(intIndex, Me.colQtdAdd)
            If dblQtdAdd <= 0 Then
                Me.grd1.SetRowCellValue(intIndex, Me.colQtdAdd, "1")
            End If
        Else
            Me.grd1.SetRowCellValue(intIndex, Me.colQtdAdd, "1")
        End If


        If PermiteEstoqueZerado = False Then
            If Me.grd1.GetRowCellDisplayText(intIndex, Me.colTipo) <> "SERVIÇO" And strStatusPed = "Pendente" Then
                If Me.grd1.GetRowCellDisplayText(intIndex, Me.colQtd) <> "" Then
                    Dim dblQtd As Double = Me.grd1.GetRowCellDisplayText(intIndex, Me.colQtd)

                    If dblQtdAdd > dblQtd Then
                        MsgBox("Não existem quantidades desse produto em estoque!", MsgBoxStyle.Information)
                        parOK = False
                        Exit Sub
                    End If
                End If
            End If
        End If
        parOK = True
    End Sub
    Private Sub txtQtdAdd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQtdAdd.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFiltroProduto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFiltroProduto.GotFocus
        Me.txtFiltroProduto.BackColor = Color.FromArgb(255, 255, 192)
        Me.TextEdit1.Properties.AppearanceDisabled.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub txtFiltroProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFiltroProduto.KeyDown
        If e.KeyCode = Keys.Enter Then
            FiltroProduto()
        End If
    End Sub

    Private Sub txtFiltroProduto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFiltroProduto.LostFocus
        Me.txtFiltroProduto.BackColor = Color.White
        Me.TextEdit1.Properties.AppearanceDisabled.BackColor = Color.White
    End Sub
End Class