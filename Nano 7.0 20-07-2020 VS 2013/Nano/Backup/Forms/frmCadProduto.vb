Imports Nano.clsFuncoes
Imports Nano.clsGerarArqs
Imports Nano.clsGerarArqsNfe
Imports System.Drawing
Imports System.Data
Imports System.IO
Imports System.Math

Public Class frmCadProduto
    Dim I As Integer
    Dim bolAlterado As Boolean = False
    Dim bolAlteradoQtd As Boolean = False
    Dim bolExcluir As Boolean = False
    Dim intCodPro As Integer
    Dim strExcluir As String
    Dim intCodQtd As Integer
    Dim strNome As String
    Dim strCodBarra As String
    Dim strCodInterno As String
    Dim intCont As Integer
    Dim intCodConfig As Integer
    Dim intCodProdGerado As Integer
    Dim intCodProdTabela As Integer

    Dim bolAltNfe As Boolean = False
    Dim intIndexNfe As Integer
    Dim strItensDeletado As String
    Dim strCSTAlt As String

    Dim strCfopDoProduto As String
    Dim vetQtd(QtdeLoja - 1) As String

    Dim strValorVenda As String
    Dim strValorCusto As String

    Dim IndexGrid As Integer
    Dim IndexHorGrid As Integer
    Dim IndexVerGrid As Integer
    Dim bolTipoFiscal As Boolean


    Dim bolSalvarOpc As Boolean = False
    Private Sub AtualizarGrid()
        Dim strFiltro2 As String = ""
        Select Case Me.Tag
            Case "VENDA"
                strFiltro2 = " and Produto.Tipo <> 'CONSUMO'"
                If SepararEstoqueSetor <> "" Then
                    strFiltro2 &= " and Produto.Setor = '" & SepararEstoqueSetor & "'"
                End If

            Case "DESCARTE"
                strFiltro2 = " and Produto.Tipo <> 'RECEITA'"
            Case "RECEITA"
                strFiltro2 = " and Tipo <> 'VENDA' and Tipo <> 'RECEITA'"
        End Select

        Dim strCasaDescimais As String = "Numeric(15," & CasaDecimal & ")"

        'If TresCasasDecimais = True Then
        '    strCasaDescimais = "Numeric(15,3)"
        'End If


        Dim strResult As String = QueryTabelaPreco(TabelaPreco)
        Dim strCodigoBarra As String '= "Produto.CodigoBarra  + isnull(' / ' + dbo.FuncCodigoBarra(Produto.Codigo),'') as CodigoBarra"

        'If NomeEmpresa.Contains("AUTO PECAS CAVALAO") Then
        strCodigoBarra = "Produto.CodigoBarra"
        'End If

        If TipoNano = 5 Then
            If Me.Tag <> "SERVICO" Then
                If strResult = "Produto.Valor" Then
                    If ManterMargemProd = True Then

                        strResult = "Produto.ValorCusto + ((Produto.ValorCusto * replace(Produto.Porcentagens,',','.')) / 100)"
                    End If

                End If
                strFiltro2 &= " and Tipo <> 'SERVIÇO'"
            Else
                strFiltro2 &= " and Tipo = 'SERVIÇO'"
                Me.cboTipo.Text = "SERVIÇO"
                Me.Text = "Cadastro de Serviços"
                Me.GroupControl1.Text = "Serviços Cadastrados"
            End If
        Else
            If strResult = "Produto.Valor" Then
                If ManterMargemProd = True Then
                    strResult = "Produto.ValorCusto + ((Produto.ValorCusto * replace(Produto.Porcentagens,',','.')) / 100)"
                End If
            End If
        End If


        If Master = True Then
            'Select Case Me.Tag
            '    Case "VENDA"
            '        CarregarDados("SELECT Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Convert(Numeric(15,2), Produto.Valor) as Valor, Convert(Numeric(15,2), Produto.ValorCusto) as ValorCusto, Produto.Locacao, Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.Data, Produto.CodigoBarra, Sum(Qtde.QtdMinima) as QtdMinima, sum(Qtde.Qtd) as Qtd, sum(Convert(Numeric(2),Qtde.EmFalta)) as EmFalta, Produto.NivelComboCodCF, Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.CodProdFor FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where Produto.Tipo <> 'CONSUMO' and Produto.Inativo = 'False' group by Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Produto.Valor, Produto.ValorCusto, Produto.Locacao, Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.Data, Produto.CodigoBarra, Produto.NivelComboCodCF, Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.CodProdFor", Me.GridControl2)
            '    Case "DESCARTE"
            '        CarregarDados("SELECT Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Convert(Numeric(15,2), Produto.Valor) as Valor, Convert(Numeric(15,2), Produto.ValorCusto) as ValorCusto, Produto.Locacao, Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.Data, Produto.CodigoBarra, Sum(Qtde.QtdMinima) as QtdMinima, sum(Qtde.Qtd) as Qtd, sum(Convert(Numeric(2),Qtde.EmFalta)) as EmFalta, Produto.NivelComboCodCF, Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.CodProdFor FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where Produto.Tipo <> 'RECEITA' and Produto.Inativo = 'False' group by Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Produto.Valor, Produto.ValorCusto, Produto.Locacao, Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.Data, Produto.CodigoBarra, Produto.NivelComboCodCF, Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.CodProdFor", Me.GridControl2)
            '    Case "RECEITA"
            '        CarregarDados("SELECT Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Convert(Numeric(15,2), Produto.Valor) as Valor, Convert(Numeric(15,2), Produto.ValorCusto) as ValorCusto, Produto.Locacao, Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.Data, Produto.CodigoBarra, Sum(Qtde.QtdMinima) as QtdMinima, sum(Qtde.Qtd) as Qtd, sum(Convert(Numeric(2),Qtde.EmFalta)) as EmFalta, Produto.NivelComboCodCF, Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.CodProdFor FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where Produto.Inativo = 'False' and Tipo <> 'VENDA' and Tipo <> 'RECEITA' group by Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Produto.Valor, Produto.ValorCusto, Produto.Locacao, Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.Data, Produto.CodigoBarra, Produto.NivelComboCodCF, Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.CodProdFor", Me.GridControl2)
            '    Case Else
            '        CarregarDados("SELECT Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Convert(Numeric(15,2), Produto.Valor) as Valor, Convert(Numeric(15,2), Produto.ValorCusto) as ValorCusto, Produto.Locacao, Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.Data, Produto.CodigoBarra, Sum(Qtde.QtdMinima) as QtdMinima, sum(Qtde.Qtd) as Qtd, sum(Convert(Numeric(2),Qtde.EmFalta)) as EmFalta, Produto.NivelComboCodCF, Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.CodProdFor FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where Produto.Inativo = 'False' group by Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Produto.Valor, Produto.ValorCusto, Produto.Locacao, Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.Data, Produto.CodigoBarra, Produto.NivelComboCodCF, Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.CodProdFor", Me.GridControl2)
            'End Select





            If EstoqueSomado = False Then
                CarregarDados("SELECT Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, " & _
                "Convert(" & strCasaDescimais & ", " & strResult & ") as Valor, " & _
                "Convert(" & strCasaDescimais & ", Produto.ValorCusto) as ValorCusto, " & _
                "(select Locacao from Locacao where Locacao.CodProd = Produto.Codigo and Locacao.CodConfig  = " & CodConfig & ") as Locacao, " & _
                "Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Grupo, Produto.Obs, " & _
                "convert(SmallDateTime,Produto.Data) as Data, " & strCodigoBarra & ", Sum(Qtde.QtdMinima) as QtdMinima, " & _
                "Sum(Qtde.QtdMaxima) as QtdMaxima, Sum(Qtde.Qtd) as Qtd, sum(Convert(Numeric(2),Qtde.EmFalta)) as EmFalta, " & _
                "Produto.NivelComboCodCF, Produto.Desconto, Produto.Comissao, Produto.Setor, Produto.Tipo, Produto.Inativo, " & _
                "(SELECT Max(Total.Data) FROM Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and " & _
                "Total.CodConfig = Pedido.CodConfig where Pedido.CodProd = Produto.Codigo) as DataUltVenda, Produto.CodProdFor, " & _
                "Produto.Validade, Produto.Familia, TributacaoPadrao, AlterarPreco, CodigoFabricante, Garantia, KM, " & _
                "Convert(" & strCasaDescimais & ", Peso) as Peso, Convert(" & strCasaDescimais & ", PesoBruto) as PesoBruto, " & _
                "case when Produto.Desconto > 0 then convert(" & strCasaDescimais & ",(Produto.Valor - ((Produto.Valor / 100) * Produto.Desconto))) " & _
                "else NULL end as ValPromocao, QtdEmb FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd " & _
                "where Produto.Inativo = 'False' " & strFiltro2 & " group by Produto.Codigo, Produto.Nome, " & _
                "Produto.UnidadeMedida, Produto.Valor, Produto.ValorCusto, Produto.CodigoInterno, Produto.Porcentagens, " & _
                "Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.Data, Produto.CodigoBarra, Produto.NivelComboCodCF, " & _
                "Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.CodProdFor, Produto.Validade, " & _
                "Produto.Comissao, Produto.Familia, TributacaoPadrao, AlterarPreco, CodigoFabricante, Garantia, KM, Peso, " & _
                "PesoBruto, QtdEmb", Me.GridControl2)
            Else
                CarregarDados("SELECT Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, " & _
                "Convert(" & strCasaDescimais & ", " & strResult & ") as Valor, " & _
                "Convert(" & strCasaDescimais & ", Produto.ValorCusto) as ValorCusto, " & _
                "(select Locacao from Locacao where Locacao.CodProd = Produto.Codigo and Locacao.CodConfig  = " & CodConfig & ") as Locacao, " & _
                "TributacaoPadrao, AlterarPreco, CodigoFabricante, Garantia, KM, Convert(" & strCasaDescimais & ", Peso) as Peso, " & _
                "Convert(" & strCasaDescimais & ", PesoBruto) as PesoBruto, Produto.CodigoInterno, Produto.Porcentagens, " & _
                "Produto.Fabricante, Produto.Grupo, Produto.Obs, convert(SmallDateTime,Produto.Data) as Data, " & strCodigoBarra & ", " & _
                "Produto.Validade, Sum(Qtde.QtdMinima) as QtdMinima, Sum(Qtde.QtdMaxima) as QtdMaxima, " & _
                "(SELECT case when sum(EntradaNf.QtdProd) is null then 0 else sum(EntradaNf.QtdProd) end " & _
                "FROM EntradaNf left join TotalEntradaNf on EntradaNf.CodTotNf = TotalEntradaNf.Codigo where " & _
                "EntradaNf.CodProd = Produto. Codigo and EstoqueOk = 'True') - (SELECT case when sum(Pedido.Qtd) " & _
                "is null then 0 else sum(Pedido.Qtd) end FROM Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem " & _
                "and PEdido.CodConfig = Total.CodConfig where Pedido.CodProd = Produto.Codigo " & _
                "and Pedido.Devolvido = 'False') + (SELECT case when sum(AjusteQtde.Qtd) is null then 0 else " & _
                "sum(AjusteQtde.Qtd) end FROM AjusteQtde where AjusteQtde.CodProd = Produto.Codigo) as Qtd, " & _
                "(SELECT case when sum(Convert(Numeric(2),Qtde.EmFalta)) is null then 1 else " & _
                "sum(Convert(Numeric(15,3), Qtde.EmFalta)) end FROM Qtde where Produto.Codigo = Qtde.CodProd) as EmFalta, " & _
                "(SELECT Max(Total.Data) FROM Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and " & _
                "Total.CodConfig = Pedido.CodConfig where Pedido.CodProd = Produto.Codigo) as DataUltVenda, Produto.NivelComboCodCF, " & _
                "Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.CodProdFor, Produto.Comissao, Produto.Familia, " & _
                "convert(bit,(SELECT case when sum(Codigo) > 0 then 'True' else 'False' end FROM Campanha where Campanha.CodProd = " & _
                "Produto.Codigo and Status = 'Lancado')) as Campanha, case when Produto.Desconto > 0 then " & _
                "convert(" & strCasaDescimais & ",(Produto.Valor - ((Produto.Valor / 100) * Produto.Desconto))) else NULL end as ValPromocao, " & _
                "QtdEmb FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where Produto.Inativo = 'False' " & strFiltro2 & " " & _
                "group by Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Produto.Valor, Produto.ValorCusto, " & _
                "Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Grupo, " & _
                "Produto.Obs, Produto.Data, Produto.CodigoBarra, Produto.NivelComboCodCF, Produto.Desconto, " & _
                "Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.CodProdFor, Produto.Validade, Produto.Comissao, " & _
                "Produto.Familia, TributacaoPadrao, AlterarPreco, CodigoFabricante, Garantia, KM, Peso, PesoBruto, QtdEmb", Me.GridControl2)
            End If

        Else
            'Select Case Me.Tag
            '    Case "VENDA"
            '        CarregarDados("SELECT Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Convert(Numeric(15,2), Produto.Valor) as Valor, Convert(Numeric(15,2), Produto.ValorCusto) as ValorCusto, Produto.Locacao, Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.Data, Produto.CodigoBarra, Produto.CodProdFor, (SELECT sum(Convert(Numeric(15,3), Qtde.QtdMinima)) FROM Qtde where Qtde.CodConfig = " & CodConfig & " and Produto.Codigo = Qtde.CodProd) as QtdMinima, (SELECT sum(Convert(Numeric(15,3), Qtde.Qtd)) FROM Qtde where Qtde.CodConfig = " & CodConfig & " and Produto.Codigo = Qtde.CodProd) as Qtd, (SELECT Case when sum(Convert(Numeric(15,3), Qtde.EmFalta)) is Null then 1 Else sum(Convert(Numeric(15,3), Qtde.EmFalta)) End FROM Qtde where Qtde.Acabou = 'False' and Qtde.CodConfig = " & CodConfig & " and Produto.Codigo = Qtde.CodProd) as EmFalta, Produto.NivelComboCodCF, Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where Produto.Tipo <> 'CONSUMO' and Produto.Inativo = 'False' group by Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Produto.Valor, Produto.ValorCusto, Produto.Locacao, Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.Data, Produto.CodigoBarra, Produto.NivelComboCodCF, Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.CodProdFor", Me.GridControl2)
            '    Case "DESCARTE"
            '        CarregarDados("SELECT Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Convert(Numeric(15,2), Produto.Valor) as Valor, Convert(Numeric(15,2), Produto.ValorCusto) as ValorCusto, Produto.Locacao, Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.Data, Produto.CodigoBarra, Produto.CodProdFor, (SELECT sum(Convert(Numeric(15,3), Qtde.QtdMinima)) FROM Qtde where Qtde.CodConfig = " & CodConfig & " and Produto.Codigo = Qtde.CodProd) as QtdMinima, (SELECT sum(Convert(Numeric(15,3), Qtde.Qtd)) FROM Qtde where Qtde.CodConfig = " & CodConfig & " and Produto.Codigo = Qtde.CodProd) as Qtd, (SELECT Case when sum(Convert(Numeric(15,3), Qtde.EmFalta)) is Null then 1 Else sum(Convert(Numeric(15,3), Qtde.EmFalta)) End FROM Qtde where Qtde.Acabou = 'False' and Qtde.CodConfig = " & CodConfig & " and Produto.Codigo = Qtde.CodProd) as EmFalta, Produto.NivelComboCodCF, Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where Produto.Tipo <> 'RECEITA' and Produto.Inativo = 'False' group by Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Produto.Valor, Produto.ValorCusto, Produto.Locacao, Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.Data, Produto.CodigoBarra, Produto.NivelComboCodCF, Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.CodProdFor", Me.GridControl2)
            '    Case "RECEITA"
            '        CarregarDados("SELECT Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Convert(Numeric(15,2), Produto.Valor) as Valor, Convert(Numeric(15,2), Produto.ValorCusto) as ValorCusto, Produto.Locacao, Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.Data, Produto.CodigoBarra, Produto.CodProdFor, (SELECT sum(Convert(Numeric(15,3), Qtde.QtdMinima)) FROM Qtde where Qtde.CodConfig = " & CodConfig & " and Produto.Codigo = Qtde.CodProd) as QtdMinima, (SELECT sum(Convert(Numeric(15,3), Qtde.Qtd)) FROM Qtde where Qtde.CodConfig = " & CodConfig & " and Produto.Codigo = Qtde.CodProd) as Qtd, (SELECT Case when sum(Convert(Numeric(15,3), Qtde.EmFalta)) is Null then 1 Else sum(Convert(Numeric(15,3), Qtde.EmFalta)) End FROM Qtde where Qtde.Acabou = 'False' and Qtde.CodConfig = " & CodConfig & " and Produto.Codigo = Qtde.CodProd) as EmFalta, Produto.NivelComboCodCF, Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where Produto.Inativo = 'False' and Produto.Tipo <> 'VENDA' and Produto.Tipo <> 'RECEITA' group by Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Produto.Valor, Produto.ValorCusto, Produto.Locacao, Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.Data, Produto.CodigoBarra, Produto.NivelComboCodCF, Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.CodProdFor", Me.GridControl2)
            '    Case Else
            '        CarregarDados("SELECT Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Convert(Numeric(15,2), Produto.Valor) as Valor, Convert(Numeric(15,2), Produto.ValorCusto) as ValorCusto, Produto.Locacao, Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.Data, Produto.CodigoBarra, Produto.CodProdFor, (SELECT sum(Convert(Numeric(15,3), Qtde.QtdMinima)) FROM Qtde where Qtde.CodConfig = " & CodConfig & " and Produto.Codigo = Qtde.CodProd) as QtdMinima, (SELECT sum(Convert(Numeric(15,3), Qtde.Qtd)) FROM Qtde where Qtde.CodConfig = " & CodConfig & " and Produto.Codigo = Qtde.CodProd) as Qtd, (SELECT Case when sum(Convert(Numeric(15,3), Qtde.EmFalta)) is Null then 1 Else sum(Convert(Numeric(15,3), Qtde.EmFalta)) End FROM Qtde where Qtde.Acabou = 'False' and Qtde.CodConfig = " & CodConfig & " and Produto.Codigo = Qtde.CodProd) as EmFalta, Produto.NivelComboCodCF, Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where Produto.Inativo = 'False' group by Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Produto.Valor, Produto.ValorCusto, Produto.Locacao, Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.Data, Produto.CodigoBarra, Produto.NivelComboCodCF, Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.CodProdFor", Me.GridControl2)
            'End Select


            If EstoqueSomado = False Then
                CarregarDados("SELECT Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, " & _
                "Convert(" & strCasaDescimais & ", " & strResult & ") as Valor, " & _
                "Convert(" & strCasaDescimais & ", Produto.ValorCusto) as ValorCusto, " & _
                "(select Locacao from Locacao where Locacao.CodProd = Produto.Codigo and Locacao.CodConfig  = " & CodConfig & ") as Locacao, " & _
                "TributacaoPadrao, AlterarPreco, CodigoFabricante, Garantia, KM, Convert(" & strCasaDescimais & ", Peso) as Peso, " & _
                "Convert(" & strCasaDescimais & ", PesoBruto) as PesoBruto, Produto.CodigoInterno, Produto.Porcentagens, " & _
                "Produto.Fabricante, Produto.Grupo, Produto.Obs, convert(SmallDateTime,Produto.Data) as Data, " & strCodigoBarra & ", " & _
                "Produto.CodProdFor, Produto.Validade, (SELECT sum(Convert(Numeric(15,3), Qtde.QtdMinima)) FROM Qtde " & _
                "where Qtde.CodConfig = " & CodConfig & " and Produto.Codigo = Qtde.CodProd) as QtdMinima, " & _
                "(SELECT sum(Convert(Numeric(15,3), Qtde.QtdMaxima)) FROM Qtde where Qtde.CodConfig = " & CodConfig & " and " & _
                "Produto.Codigo = Qtde.CodProd) as QtdMaxima, (SELECT sum(Convert(Numeric(15,3), Qtde.Qtd)) " & _
                "FROM Qtde where Qtde.CodConfig = " & CodConfig & " and Produto.Codigo = Qtde.CodProd and " & _
                "Acabou = 'False') as Qtd, (SELECT Case when sum(Convert(Numeric(15,3), Qtde.EmFalta)) is Null " & _
                "then 1 Else sum(Convert(Numeric(15,3), Qtde.EmFalta)) End FROM Qtde where Qtde.Acabou = 'False' " & _
                "and Qtde.CodConfig = " & CodConfig & " and Produto.Codigo = Qtde.CodProd) as EmFalta, " & _
                "(SELECT Max(Total.Data) FROM Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and " & _
                "Total.CodConfig = Pedido.CodConfig where Pedido.CodProd = Produto.Codigo and Pedido.CodConfig = " & CodConfig & ") as DataUltVenda, " & _
                "Produto.NivelComboCodCF, Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo, " & _
                "Produto.Comissao, Produto.Familia, case when Produto.Desconto > 0 then convert(" & strCasaDescimais & "," & _
                "(Produto.Valor - ((Produto.Valor / 100) * Produto.Desconto))) else NULL end as ValPromocao, " & _
                "QtdEmb FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where Produto.Inativo = 'False' " & strFiltro2 & " group by " & _
                "Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Produto.Valor, Produto.ValorCusto, " & _
                "Produto.CodigoInterno, Produto.Porcentagens, Produto.Fabricante, Produto.Grupo, " & _
                "Produto.Obs, Produto.Data, Produto.CodigoBarra, Produto.NivelComboCodCF, Produto.Desconto, " & _
                "Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.CodProdFor, Produto.Validade, " & _
                "Produto.Comissao, Produto.Familia, TributacaoPadrao, AlterarPreco, CodigoFabricante, Garantia, KM, Peso, PesoBruto, QtdEmb", Me.GridControl2)

            Else
                CarregarDados("SELECT Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, " & _
                "Convert(" & strCasaDescimais & ", " & strResult & ") as Valor, " & _
                "Convert(" & strCasaDescimais & ", Produto.ValorCusto) as ValorCusto, " & _
                "(select Locacao from Locacao where Locacao.CodProd = Produto.Codigo and Locacao.CodConfig  = " & CodConfig & ") as Locacao, " & _
                "TributacaoPadrao, AlterarPreco, CodigoFabricante, Garantia, KM, Convert(" & strCasaDescimais & ", Peso) as Peso, " & _
                "Convert(" & strCasaDescimais & ", PesoBruto) as PesoBruto, Produto.CodigoInterno, Produto.Porcentagens, " & _
                "Produto.Fabricante, Produto.Grupo, Produto.Obs, convert(SmallDateTime,Produto.Data) as Data, " & strCodigoBarra & ", " & _
                "Produto.CodProdFor, Produto.Validade, (SELECT sum(Convert(Numeric(15,3), Qtde.QtdMinima)) FROM Qtde " & _
                "where Qtde.CodConfig = " & CodConfig & " and Produto.Codigo = Qtde.CodProd) as QtdMinima, " & _
                "(SELECT sum(Convert(Numeric(15,3), Qtde.QtdMaxima)) FROM Qtde where Qtde.CodConfig = " & CodConfig & " and " & _
                "Produto.Codigo = Qtde.CodProd) as QtdMaxima, (SELECT case when sum(EntradaNf.QtdProd) is null then 0 " & _
                "else sum(EntradaNf.QtdProd) end FROM EntradaNf left join TotalEntradaNf on EntradaNf.CodTotNf = " & _
                "TotalEntradaNf.Codigo where EntradaNf.CodProd = Produto. Codigo and EstoqueOk = 'True' and " & _
                "EntradaNf.CodConfig = " & CodConfig & ") - (SELECT case when sum(Pedido.Qtd) is null then 0 else " & _
                "sum(Pedido.Qtd) end FROM Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and PEdido.CodConfig = Total.CodConfig " & _
                "where Pedido.CodConfig = " & CodConfig & " and Pedido.CodProd = Produto.Codigo and Pedido.Devolvido = 'False') + " & _
                "(SELECT case when sum(AjusteQtde.Qtd) is null then 0 else sum(AjusteQtde.Qtd) end FROM AjusteQtde where " & _
                "AjusteQtde.CodConfig = " & CodConfig & " and AjusteQtde.CodProd = Produto.Codigo) as Qtd, " & _
                "(SELECT Case when sum(Convert(Numeric(15,3), Qtde.EmFalta)) is Null then 1 else sum(Convert(Numeric(15,3), Qtde.EmFalta)) End " & _
                "FROM Qtde where Qtde.Acabou = 'False' and Qtde.CodConfig = " & CodConfig & " and " & _
                "Produto.Codigo = Qtde.CodProd) as EmFalta, Produto.NivelComboCodCF, Produto.Desconto, " & _
                "(SELECT Max(Total.Data) FROM Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and " & _
                "Total.CodConfig = Pedido.CodConfig where Pedido.CodProd = Produto.Codigo and Pedido.CodConfig = " & CodConfig & ") as DataUltVenda, " & _
                "Produto.Setor, Produto.Tipo, Produto.Inativo, Produto.Comissao, Produto.Familia, " & _
                "convert(bit,(SELECT case when sum(Codigo) > 0 then 'True' else 'False' end FROM Campanha where " & _
                "Campanha.CodProd = Produto.Codigo and Status = 'Lancado')) as Campanha, " & _
                "case when Produto.Desconto > 0 then convert(" & strCasaDescimais & ",(Produto.Valor - ((Produto.Valor / 100) * Produto.Desconto))) else NULL end as ValPromocao, " & _
                "QtdEmb FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where Produto.Inativo = 'False' " & _
                "" & strFiltro2 & " group by Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Produto.Valor, " & _
                "Produto.ValorCusto, Produto.CodigoInterno, Produto.Porcentagens, " & _
                "Produto.Fabricante, Produto.Grupo, Produto.Obs, Produto.Data, Produto.CodigoBarra, " & _
                "Produto.NivelComboCodCF, Produto.Desconto, Produto.Setor, Produto.Tipo, Produto.Inativo, " & _
                "Produto.CodProdFor, Produto.Validade, Produto.Comissao, Produto.Familia, TributacaoPadrao, " & _
                "AlterarPreco, CodigoFabricante, Garantia, KM, Peso, PesoBruto, QtdEmb", Me.GridControl2)
            End If
        End If
        Dim index As Integer = -999997
        grd1.FocusedRowHandle = index
        grd1.FocusedColumn = Me.colNome
        grd1.ShowEditor()
        If Me.chkDuplicar.Checked = False Then
            Me.txtCodBarra.Focus()
        End If
    End Sub

    Private Sub frmCadProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'Me.nbcImagem.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded
        'Me.nbcImagem.PaintStyleName = "SkinNavigationPane"
        'Me.nbcImagem.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    If Me.Tag = "CONSULTA" Then
                        Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "75")
                    Else
                        Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "7")
                    End If
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
   
    Private Sub frmCadProduto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtVal.CasasDecimais = CasaDecimal
        Me.txtPeso.CasasDecimais = CasaDecimal
        Me.txtPesoBruto.CasasDecimais = CasaDecimal
        Me.NanoCampo1.CasasDecimais = CasaDecimal
        If TipoNano = 2 Then
            Me.colLocacao2.Visible = True
        End If

        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)


        Me.nbcImagem.Size = New System.Drawing.Size(37, 237)
        Me.nbcImagem.Location = New System.Drawing.Point(962, -1)

        If TesteConexao() = False Then Exit Sub

        Me.CFOPTableAdapter.Fill(Me.DsNanoCommerce.CFOP)
        CarregarDadosLue("Select Codigo, Descricao from Config", Me.lueLoja)

        intCodConfig = CodConfig

        Me.tabImpECF.PageVisible = PafEcfNano
        Me.tabNfe.PageVisible = EmiteNFE

        If EmiteNFE = False Then
            Me.tabNfe.PageVisible = AbaSatFiscal
            If AbaSatFiscal = False Then
                Me.tabNfe.PageVisible = NANONFCe
            End If
        End If
       
        If ComissaoProduto = False Then
            'Me.lblComissao.Visible = False
            'Me.txtComissao.Visible = False
            'Me.lblFornecedor.Location = New System.Drawing.Point(15, 122)
            'Me.cboFabricante.Location = New System.Drawing.Point(76, 119)
            'Me.cboFabricante.Size = New System.Drawing.Size(432, 20)
            Me.txtComissao.Enabled = False
        End If

        If PafEcfNano = False Then
            Me.btnImpCupom.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If EmiteNFE = False Then
            If AbaSatFiscal = False Then
                Me.btnPesquisa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                If PafEcfNano = False Then
                    Me.bsiImposto.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                End If


                Me.bsiImposto.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            End If
        Else
            If SimplesNacional = True Then
                Me.cboRegime.SelectedIndex = 1

            End If
            'If NanoNfe = False Then
            '    Me.LabelControl69.Visible = False
            '    Me.LabelControl70.Visible = False
            '    Me.cboCodigoANP.Visible = False
            '    Me.cboUF.Visible = False
            'End If
        End If

        If AbaSatFiscal = True Then

            Me.tabNfe.Text = "SAT Fiscal"

            
        Else
            If NANONFCe = True Then
                Me.tabNfe.Text = "NFC-e"
            End If
        End If
        If RegimeSAT <> "" Then
            If RegimeSAT = "SIMPLES NACIONAL" Then
                Me.XtraTabControl1.SelectedTabPageIndex = 0
            Else
                Me.XtraTabControl1.SelectedTabPageIndex = 1
            End If


        End If

        If TipoFiscal = "AMBOS" Then
            Me.cboTipoFiscal.Enabled = True
        Else
            Me.cboTipoFiscal.Enabled = False
        End If

        Me.cboTipoFiscal.Text = "AMBOS"

        If Nivel = "USUÁRIO" Then
            Me.btnImposto.Visible = False
            Me.btnInsNfeTodos.Visible = False
        End If
        If Nivel = "USUÁRIO" And Me.Tag = "VENDA" Then
            Me.txtValCus.Visible = False
            Me.lblValCus.Visible = False
            Me.colValorCusto.Visible = False
            'Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If


        If QtdeLoja > 1 Then
            Me.colDescricao.Visible = Master
            Me.lblLoja.Visible = Master
            Me.lueLoja.Visible = Master
        Else
            Me.colDescricao.Visible = False
            Me.lblLoja.Visible = False
            Me.lueLoja.Visible = False

        End If

        Me.txtTamanho.Visible = BaixaPorLote
        Me.lblTam.Visible = BaixaPorLote
        Me.chkTamanho.Visible = BaixaPorLote
        Me.btnAdd.Visible = BaixaPorLote
        Me.lblQtdMin.Visible = BaixaPorLote
        Me.txtQtdeMin.Visible = BaixaPorLote
        Me.lblQtd.Visible = BaixaPorLote
        Me.txtQtde.Visible = BaixaPorLote
        Me.colQtd.OptionsColumn.ReadOnly = BaixaPorLote
        Me.colQtdMinima.OptionsColumn.ReadOnly = BaixaPorLote
        Me.colQtdMaxima.OptionsColumn.ReadOnly = BaixaPorLote
        Me.colLote.Visible = BaixaPorLote
        Me.colTamanho.Visible = BaixaPorLote
        'Me.lblTamLote.Visible = BaixaPorLote
        'Me.colPendente.Visible = BaixaPorLote
        Me.btnExcluirItem.Visible = BaixaPorLote

        If BaixaPorLote = False Then
            Me.grpQtd.Dock = DockStyle.Fill
            Me.grd2.OptionsView.ShowAutoFilterRow = False
            Me.lblLoja.Visible = False
            Me.lueLoja.Visible = False
            'Me.colQtd.OptionsColumn.ReadOnly = EstoqueSomado
        End If


        If Me.Tag = "CONSULTA" Then
            grpProd.Dock = DockStyle.Fill

            Me.Text = "Consulta de Produtos"
            Me.btnAlterar.Caption = "&Consultar"
            Me.btnAlterar.Glyph = My.Resources.viewmag
            Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnLimpar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.colValorCusto.Visible = False
            grpCalc.Visible = False
            grpProd.Text = "Consulta de Produtos"
            grpProd.AppearanceCaption.ForeColor = Color.Red
            Me.lblCap.Visible = False
            Me.btnCalcular.Visible = False
            Me.txtCapital.Visible = False
            Me.txtValCus.Visible = False
            Me.lblValCus.Visible = False
        Else

            'corrigir no Commerce sql
            '##################################################################################################################
            If bolEstoqueBloqueado = True Then
                Me.btnAlterar.Caption = "&Consultar"
                Me.btnAlterar.Glyph = My.Resources.viewmag
                Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Me.colValorCusto.Visible = False
                grpCalc.Visible = False
                Me.lblCap.Visible = False
                Me.btnCalcular.Visible = False
                Me.txtCapital.Visible = False
                Me.txtValCus.Visible = False
                Me.lblValCus.Visible = False
            End If

            PreencherGrupoSetorCusto("S", Me.cboSet)
            PreencherGrupoSetorCusto("G", Me.cboGrp)
            PreencherGrupoSetorCusto("F", Me.cboFamilia)
            Me.cboUniMed.Properties.Items.Clear()
            PreencherGrupoSetorCusto("U", Me.cboUniMed)
        End If

        If NomeEmpresa.Contains("RAISNER") = True Then
            Me.cboUniMed.Text = "UN"
        End If

        PreencherCombo("Fornecedor", Me.cboFabricante, 1, "Nome")

        Tamanho(True)

        AtualizarGrid()
        Select Case NomeImpCodigoBarra
            Case "ARGOX OS-214 PLUS"
                Me.cboMod.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

            Case "ZEBRA TLP 2844", "ZEBRA ZT"
                Me.cboMod.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Case "BEMA LB-1000"
                Me.cboMod.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

            Case "IMPRESSORA NORMAL"
                Me.cboMod.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

        End Select

        'Me.cboOrigECF.SelectedIndex = 1

        'GerCodigo()

        CarregaTributacao()
        GerarQtdeSemLote()

        If ObsProduto = True Then
            Me.txtObs.Visible = True
            Me.lblObs.Visible = True
            Me.PanelControl10.Visible = True
        Else

            Me.lblObs.Visible = True
            Me.lblObs.Text = "Validade"
            Me.PanelControl10.Visible = True
        End If
        If TipoNano = 2 Then
            Me.txtObs.Visible = True
            Me.lblObs.Visible = True
            Me.lblObs.Text = "Aplicação"
            Me.colObs.Caption = "Aplicação"
            Me.PanelControl10.Visible = True
            Me.colObs.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains

            'Me.colCodigoInterno.Visible = False
            'Me.colCodigoBarra.VisibleIndex = 0
            'Me.colNome.VisibleIndex = 1
            'Me.colObs.VisibleIndex = 2
            'Me.colFabricante.VisibleIndex = 3
            'Me.colQtd.VisibleIndex = 4
            'Me.colValor.VisibleIndex = 5
            'Me.colLocacao.VisibleIndex = 6
            Me.LabelControl18.Text = "Marca"
            Me.colSetor.Caption = "Marca"

            'Me.colLocacao.Caption = "Cód. Similar"
            'Me.colLocacao.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            'Me.lblLocacao.Text = "Cód. Similar"

            'Me.lblLocacao.Location = New System.Drawing.Point(330, 122)
            Me.PanelControl1.Size = New System.Drawing.Size(422, 192)
            'Me.txtObs.Size = New System.Drawing.Size(770, 32)
            Me.txtObs.Size = New System.Drawing.Size(343, 32)

            'Me.lblTipo.Text = "Loc."
            'Me.cboTipo.Visible = False
            'Me.txtLoc2.Visible = True

        End If


        Me.grd1.FormatConditions.Item(2).Value1 = Date.Today.AddDays(15)

        'Me.grd1.FormatConditions.Item(2).Value1 = True


        'If IO.File.Exists(My.Application.Info.DirectoryPath & "\CadProduto.txt") = True Then
        '    Dim strCadProduto As String = LerArquivo(My.Application.Info.DirectoryPath & "\CadProduto.txt", False)


        '    Dim vetCadProduto As Array = Split(strCadProduto, "|")

        '    Dim I As Integer
        '    Dim A As Integer = 0
        '    For I = 0 To vetCadProduto.Length - 1

        '        Dim strColuna As String = vetCadProduto(I)
        '        Try
        '            Me.grd1.Columns(strColuna).VisibleIndex = A
        '            A += 1
        '        Catch ex As Exception

        '        End Try

        '    Next

        'End If

        If TresCasasDecimais = True Then
            Me.txtVal.CasasDecimais = 3
            Me.txtValCus.CasasDecimais = 3
            Me.txtPor1.CasasDecimais = 3
        End If
        Me.btnSalvarTributacao.Visible = False
        Me.btnCadCodBarra.Enabled = False
        Timer1.Start()
        Me.txtCodBarra.Focus()


        ConfigurarGrid(Me.grd2, Me, True, Me.btnPadraoQtd)


        If FiltroProdutoContem = True Then
            Me.colNome.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Me.colCodFab.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Me.colCodigoBarra.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End If

        If TipoNano = 5 Then
            Me.txtObs.Visible = True
            Me.lblObs.Visible = True
            Me.lblObs.Text = "Aplicação"
            Me.colObs.Caption = "Aplicação"
            Me.PanelControl10.Visible = True
            Me.colObs.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains


            Me.nbcImagem.PaintStyleName = "SkinNavigationPane"
            Me.nbcImagem.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
            If BaixaPorLote = True Then
                Me.grpQtd.Size = New System.Drawing.Size(457, 149)
                Me.grpQtd.Dock = DockStyle.Bottom
                'Me.SimpleButton2.Location = New System.Drawing.Point(413, 100)
            End If

            Me.txtRevKM.Visible = True
            Me.txtGarantia.Visible = True
            'Me.txtCodFab.Visible = True
            Me.LabelControl92.Visible = True
            'Me.LabelControl75.Visible = True
            Me.LabelControl91.Visible = True
            Me.colCodFab.Visible = True
            Me.colGarantia.Visible = True
            Me.colKM.Visible = True
        Else

            Me.nbcImagem.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded
            If BaixaPorLote = True Then
                Me.grpQtd.Size = New System.Drawing.Size(457, 149)
                Me.grpQtd.Dock = DockStyle.Bottom
                'Me.SimpleButton2.Location = New System.Drawing.Point(413, 100)
            End If
        End If

        If Me.Tag = "ENTRADANF" And frmEntradaNF.txtCodPro.Text = "" Then
            Me.txtNome.Text = frmEntradaNF.txtNomePro.Text
            Me.txtCodBarra.Text = frmEntradaNF.txtCodBarra.Text
            Me.cboUniMed.Text = frmEntradaNF.cboUniMed.Text
            Me.txtValCus.Text = frmEntradaNF.txtValorCusto.Text
            Me.txtVal.Text = frmEntradaNF.txtVal.Text
            Me.txtCodProdFor.Text = frmEntradaNF.txtCodProdFor.Text
            Me.cboSet.Text = frmEntradaNF.cboSet.Text
            Me.cboGrp.Text = frmEntradaNF.cboGrp.Text
            Me.txtPor1.Text = frmEntradaNF.txtPor1.Text

            Me.txtNfeNCM.Text = ""
            Me.txtNCMImpProd.Text = ""
            Me.cboFabricante.Text = ""
            If frmEntradaNF.txtNomePro.Text <> "" Then
                Me.txtNfeNCM.Text = frmEntradaNF.strNCMGeral2
                Me.txtNCMImpProd.Text = frmEntradaNF.strNCMGeral2
                Me.cboFabricante.Text = frmEntradaNF.txtFor.Text
            End If
        End If

        If TipoNano = 1 Then
            Me.tabOpc.PageVisible = True
            CarregaOpc("")
        End If

        Me.picImagem3.Image = Nothing
        Me.picImagem4.Image = Nothing

    End Sub
    Private Sub CarregaOpc(ByVal parCodigo As String)
       
        bolSalvarOpc = False
        Me.grd6.ActiveFilter.Clear()
        Dim strTipoFocus As String = ""
        CarregarDados("SELECT Tipo as TipoOpc FROM ProdOpc group by Tipo", Me.GridControl6)
        Dim strAddOpc As String = " convert(bit,'False') as AddOpc "
        If parCodigo <> "" Then
            strAddOpc = " convert(bit,case when (SELECT VincProdOpc.Codigo FROM VincProdOpc where VincProdOpc.CodProd = " & parCodigo & " and VincProdOpc.CodOpc = ProdOpc.Codigo) is null then 'False' else 'True' end) as AddOpc "

            Dim dt As DataTable = CarregarDataTable("SELECT Tipo FROM ProdOpc left join VincProdOpc on VincProdOpc.CodOpc = ProdOpc.Codigo where VincProdOpc.CodProd = " & parCodigo & " group by Tipo")
            If dt.Rows.Count = 1 Then
                strTipoFocus = dt.Rows.Item(0).Item("Tipo").ToString
            End If
        End If
        CarregarDados("SELECT ProdOpc.Codigo, Tipo as TipoOpc, ProdOpc.Produto as Opcao, " & strAddOpc & " FROM ProdOpc", Me.GridControl7)



        Me.grd5.ClearColumnsFilter()
        Me.grd6.ClearColumnsFilter()

        Dim index As Integer = -999997

        If strTipoFocus <> "" Then
            Dim I As Integer
            For I = 0 To Me.grd5.RowCount - 1
                Dim strTipo As String = Me.grd5.GetRowCellDisplayText(I, Me.colTipoOpc)
                If strTipo = strTipoFocus Then
                    grd5.FocusedRowHandle = I
                    grd5.ShowEditor()
                    grd6.ActiveFilter.NonColumnFilter = "[TipoOpc] = '" & strTipo & "'"
                    Exit For
                End If
            Next
        Else
            grd5.FocusedRowHandle = index
            grd5.ShowEditor()
        End If
    

        grd6.FocusedRowHandle = index
        grd6.ShowEditor()

    End Sub


    Private Sub CarregaTributacao()
        If PafEcfNano = True Then
            If System.IO.File.Exists(My.Application.Info.DirectoryPath & "\TributacaoECF.txt") = True Then
                Dim strTexto As String

                strTexto = LerArquivo(My.Application.Info.DirectoryPath & "\TributacaoECF.txt", False)

                Dim vetTexto As Array

                vetTexto = Split(strTexto, "|")

                Me.cboTrib2.SelectedIndex = vetTexto(0).ToString.Replace("Tributacao:", "").Trim
                Me.cboCst2.SelectedIndex = vetTexto(1).ToString.Replace("CST ICMS:", "").Trim
                Me.cboOriIcm2.SelectedIndex = vetTexto(2).ToString.Replace("Origem ICMS:", "").Trim
                Me.txtIcms.Text = vetTexto(3).ToString.Replace("Aliquota %:", "").Trim
                Me.cboIPPT.SelectedIndex = vetTexto(4).ToString.Replace("IPPT:", "").Trim
                Me.cboPesa.SelectedIndex = vetTexto(5).ToString.Replace("Pesavel:", "").Trim
                Me.cboFIA.SelectedIndex = vetTexto(6).ToString.Replace("Tipo:", "").Trim
                Me.cboCodCF.SelectedIndex = vetTexto(7).ToString.Replace("Cod. C. Fiscal:", "").Trim
            End If

        End If
    End Sub

    Private Sub GerarQtdeSemLote()
        If BaixaPorLote = False Then

            Dim dt As DataTable = CarregarDataTable("Select Codigo, Descricao from Config")
            Dim I As Integer

            For I = 0 To dt.Rows.Count - 1
                Me.tbQtd.Rows.Add()
                Me.tbQtd.Rows.Item(I).Item("Tamanho") = "U"
                Me.tbQtd.Rows.Item(I).Item("QtdMinima") = 0
                Me.tbQtd.Rows.Item(I).Item("Qtd") = 0
                Me.tbQtd.Rows.Item(I).Item("Lote") = "U"
                Me.tbQtd.Rows.Item(I).Item("EmFalta") = 0
                Me.tbQtd.Rows.Item(I).Item("CodConfig") = dt.Rows.Item(I).Item("Codigo").ToString
                Me.tbQtd.Rows.Item(I).Item("Descricao") = dt.Rows.Item(I).Item("Descricao").ToString
                Me.tbQtd.Rows.Item(I).Item("QtdMaxima") = 0
            Next

        End If
    End Sub

    Private Sub GerCodigo()
        Dim intCodOrdem As Integer = GerarCodigoOrdens("Produto", CodConfig)

        Dim bolOk As Boolean = False
        While bolOk = False
            Me.txtCodInt.Text = intCodOrdem
            If AcrescentarZeroCodProd = True Then

                Select Case Me.txtCodInt.Text.Length
                    Case 1
                        Me.txtCodInt.Text = "000" & Me.txtCodInt.Text
                    Case 2
                        Me.txtCodInt.Text = "00" & Me.txtCodInt.Text
                    Case 3
                        Me.txtCodInt.Text = "0" & Me.txtCodInt.Text
                    Case 4
                    Case Else
                        If Not Me.txtCodInt.Text.Length Mod 2 = 0 Then
                            Me.txtCodInt.Text = "0" & Me.txtCodInt.Text
                        End If
                End Select
            End If
            Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM Produto where CodigoInterno = '" & Me.txtCodInt.Text & "'")
            If dt.Rows.Count > 0 Then
                intCodOrdem += 1
            Else
                bolOk = True
            End If
        
        End While
        intCodProdGerado = Me.txtCodInt.Text
        Inserir("Insert into Ordens (Cod, Tabela, CodConfig) Values(" & Me.txtCodInt.Text.Trim & ",'Produto'" & "," & CodConfig & ")")

    End Sub
  
    Private Sub Limpar()
        If TipoNano = 1 Then
            CarregaOpc("")
        End If
        bolSalvarOpc = False
        Me.cboTipoFiscal.Text = "AMBOS"

        Me.btnSalvarTributacao.Visible = False
        Me.btnCadCodBarra.Enabled = False
        Me.picImagem3.Image = Nothing
        Me.picImagem4.Image = Nothing
        strCfopDoProduto = ""
        CFOPCombustivel()
        Me.lueCFOP.EditValue = DBNull.Value

        For I = 0 To QtdeLoja - 1
            vetQtd(I) = Nothing
        Next
        Me.txtComissao.ResetText()
        Me.txtNCMImpProd.ResetText()
        Me.chkInativar.Checked = False
        Me.txtNome.ResetText()
        Me.txtCodProdFor.ResetText()
        Me.txtValCus.ResetText()
        Me.txtVal.ResetText()
        Me.txtLoc.ResetText()
        Me.cboUniMed.SelectedIndex = -1
        Me.txtCodInt.ResetText()
        Me.chkAlterar.Tag = ""
        Me.chkAlterar.Checked = False
        Me.txtCodInt.Enabled = False
        Me.txtValCus.Enabled = True
        Me.cboTipo.Enabled = True
        Me.txtPor1.ResetText()
        Me.cboFabricante.SelectedIndex = -1
        Me.cboGrp.SelectedIndex = -1
        Me.txtObs.ResetText()
        Me.txtIcms.ResetText()
        Me.txtCodBarra.ResetText()
        Me.txtIPI.ResetText()
        Me.tabProd.SelectedTabPageIndex = 0
        Me.tabProd.Size = New System.Drawing.Size(1008, 267)
        Me.tabImpostos.SelectedTabPageIndex = 0
        Me.txtTamanho.ResetText()
        Me.txtQtde.ResetText()
        Me.txtQtdeMin.Text = 0
        Me.txtQtdeMax.Text = 0
        Me.dtValidade.ResetText()
        Me.tbQtd.Rows.Clear()

        Me.cboTrib.SelectedIndex = -1
        Me.cboCst.SelectedIndex = -1
        Me.cboOriIcm.SelectedIndex = -1
        Me.cboIPPT.SelectedIndex = -1
        Me.cboPesa.SelectedIndex = -1
        Me.cboFIA.SelectedIndex = -1
        Me.txtIPI.ResetText()
        Me.txtIcms.ResetText()
        Me.cboCodCF.SelectedIndex = 0
        Me.txtDesconto.ResetText()
        Me.txtValDesconto.ResetText()
        Me.cboSet.SelectedIndex = -1
        Me.cboTipo.SelectedIndex = 0
        Me.lueLoja.EditValue = DBNull.Value
        Me.btnAdd.Image = Nano.My.Resources.Resources.edit_add
        Me.btnAdd.Text = "Adicionar"

        'GerCodigo()
        Me.chkDesc.Checked = False
        Tamanho(True)
        bolAlterado = False
        bolExcluir = False
        bolAlteradoQtd = False

        Me.txtEXTIPI.ResetText()
        Me.txtGenero.ResetText()
        Me.txtUniTrib.ResetText()
        Me.txtValTrib.ResetText()
        Me.txtQtdTrib.ResetText()
        Me.txtQtdN.ResetText()
        Me.cboMIPI.SelectedIndex = -1
        Me.txtNfeNCM.ResetText()
        Me.txtUniCom.ResetText()
        Me.txtValCom.ResetText()
        Me.txtCest.ResetText()
        Me.txtPerFCPUF.ResetText()
        Me.txtPerICMSUF.ResetText()
        Me.tbNfe.Rows.Clear()

        LimparNFE(True, "SIMPLES NACIONAL")
        LimparNFE(True, "TRIBUTAÇÃO NORMAL")

        Me.cboRegime.SelectedIndex = -1

        CarregaTributacao()
        GerarQtdeSemLote()
        Me.txtLoc2.ResetText()
        Me.txtCodBarra.Focus()
        Me.cboFamilia.SelectedIndex = -1
        intCodProdTabela = 0
        Me.chkTribPadrao.Checked = False
        'frmTabelaPreco.intCodProd = 0

        Me.chkDuplicar.Checked = False
        Me.CheckEdit1.Checked = False

        Me.txtCodFab.ResetText()
        Me.txtGarantia.ResetText()
        Me.txtRevKM.ResetText()
        Me.txtPeso.ResetText()
        Me.txtPesoBruto.ResetText()
        Me.txtQtdeEstoque.ResetText()
        Me.txtQtdeMinima.ResetText()
        Me.txtQtdMaxima.ResetText()
        If ManterMargemProd = True Then
            If Me.Tag = "SERVICO" Then
                Me.cboTipo.Text = "SERVIÇO"
            End If
        End If

        Me.NanoCampo1.ResetText()
    End Sub
    Private Sub AlterarQtd()
        If BaixaPorLote = False Then
            If EstoqueSomado = False Then Exit Sub
            If Me.Tag = "" Then
                If intCodPro = 0 Then Exit Sub

                'frmAlterarQtde.strCodProd = intCodPro
                'frmAlterarQtde.strCodigoInterno = Me.txtCodInt.Text
                'frmAlterarQtde.strLoja = grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colCodConfig)
                'frmAlterarQtde.strUM = Me.cboUniMed.SelectedIndex
                'frmAlterarQtde.strProd = Me.txtNome.Text
                'frmAlterarQtde.ShowDialog()
                'CarregarQtde()
                'AtualizarGrid()
            End If
        Else
            If bolAlteradoQtd = True Then
                If Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colCodigoQtd) <> "INSERIR" And Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colCodigoQtd) <> "" Then
                    intCodQtd = Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colCodigoQtd)
                End If
                If Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colTamanho) = "U" Then
                    Tamanho(True)
                Else
                    Tamanho(False)
                    Me.txtTamanho.Text = Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colTamanho)
                End If

                If grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colCodConfig).Trim <> "" Then
                    Dim dt As DataTable = CarregarDataTable("Select Descricao from Config where Codigo =" & grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colCodConfig))

                    If dt.Rows.Count > 0 Then
                        Me.lueLoja.Text = dt.Rows.Item(0).Item("Descricao").ToString
                        Me.lueLoja.ClosePopup()
                    End If
                End If

                Me.txtQtde.Text = Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colQtd)
                Me.txtQtdeMin.Text = Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colQtdMinima)
                Me.txtQtdeMax.Text = Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colQtdMaxima)
                Me.txtValCus.Text = Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colValorCustoQtd)
                Me.txtValCus.Enabled = True
            End If
        End If

        
    End Sub
    Private Sub CarregarQtde()
        Dim dt1 As DataTable
        Dim strSql As String = ""
        Dim strQtdes As String = ""
        Select Case cboUniMed.SelectedIndex
            Case 0, 1, 2
                strQtdes = "Convert(Numeric(15), QtdMinima) as QtdMinima, Convert(Numeric(15), Qtd) as Qtd, Convert(Numeric(15), QtdMaxima) as QtdMaxima"
            Case 3, 4, 5
                strQtdes = "Convert(Numeric(15,3), QtdMinima) as QtdMinima, Convert(Numeric(15,3), Qtd) as Qtd, Convert(Numeric(15,3), QtdMaxima) as QtdMaxima"
            Case 5
                strQtdes = "Convert(Numeric(15,3), QtdMinima) as QtdMinima, Convert(Numeric(15,3), Qtd) as Qtd, Convert(Numeric(15,3), QtdMaxima) as QtdMaxima"
            Case Else
                strQtdes = "Convert(Numeric(15,3), QtdMinima) as QtdMinima, Convert(Numeric(15,3), Qtd) as Qtd, Convert(Numeric(15,3), QtdMaxima) as QtdMaxima"
        End Select
        If EstoqueSomado = False Then
            If Master = True Then
                strSql = "SELECT Qtde.Codigo, Tamanho, " & strQtdes & ", Lote, ValorCusto, EmFalta, CodConfig, Descricao FROM Qtde left join Config on Qtde.CodConfig = Config.Codigo where CodProd = " & intCodPro & " and Acabou = 'False' order by CodConfig"
            Else
                strSql = "SELECT Qtde.Codigo, Tamanho, " & strQtdes & ", Lote, ValorCusto, EmFalta, CodConfig, Descricao FROM Qtde left join Config on Qtde.CodConfig = Config.Codigo where CodProd = " & intCodPro & " and Acabou = 'False' and CodConfig =" & CodConfig
            End If
        Else
            If Master = True Then
                strSql = "SELECT Qtde.Codigo, Tamanho, " & strQtdes & ", Lote, ValorCusto, EmFalta, CodConfig, Descricao FROM Qtde left join Config on Qtde.CodConfig = Config.Codigo where CodProd = " & intCodPro & " order by CodConfig"
            Else
                strSql = "SELECT Qtde.Codigo, Tamanho, " & strQtdes & ", Lote, ValorCusto, EmFalta, CodConfig, Descricao FROM Qtde left join Config on Qtde.CodConfig = Config.Codigo where CodProd = " & intCodPro & " and CodConfig =" & CodConfig
            End If
        End If



        dt1 = CarregarDataTable(strSql)

        'Me.colQtd.OptionsColumn.ReadOnly = True

        Me.tbQtd.Rows.Clear()

        Dim strVerificaCodConfig As String = ""
        Dim A As Integer = 0
        If dt1.Rows.Count > 0 Then

            If EstoqueSomado = False Then
                For I = 0 To dt1.Rows.Count - 1
                    Me.tbQtd.Rows.Add()
                    Me.tbQtd.Rows.Item(I).Item("Codigo") = dt1.Rows.Item(I).Item("Codigo")
                    Me.tbQtd.Rows.Item(I).Item("Tamanho") = dt1.Rows.Item(I).Item("Tamanho").ToString
                    Me.tbQtd.Rows.Item(I).Item("QtdMinima") = dt1.Rows.Item(I).Item("QtdMinima").ToString
                    Me.tbQtd.Rows.Item(I).Item("QtdMaxima") = dt1.Rows.Item(I).Item("QtdMaxima").ToString
                    Me.tbQtd.Rows.Item(I).Item("Qtd") = dt1.Rows.Item(I).Item("Qtd").ToString
                    Me.tbQtd.Rows.Item(I).Item("QtdSemAlterar") = dt1.Rows.Item(I).Item("Qtd").ToString
                    Me.tbQtd.Rows.Item(I).Item("Lote") = dt1.Rows.Item(I).Item("Lote").ToString
                    Me.tbQtd.Rows.Item(I).Item("ValorCusto") = dt1.Rows.Item(I).Item("ValorCusto").ToString
                    Me.tbQtd.Rows.Item(I).Item("EmFalta") = dt1.Rows.Item(I).Item("EmFalta").ToString
                    If dt1.Rows.Item(I).Item("Tamanho").ToString = "U" Then
                        Tamanho(False)
                    End If

                    Me.tbQtd.Rows.Item(I).Item("CodConfig") = dt1.Rows.Item(I).Item("CodConfig").ToString
                    Me.tbQtd.Rows.Item(I).Item("Descricao") = dt1.Rows.Item(I).Item("Descricao").ToString

                Next
            Else
                For I = 0 To dt1.Rows.Count - 1
                    If strVerificaCodConfig <> dt1.Rows.Item(I).Item("CodConfig").ToString Then
                        strVerificaCodConfig = dt1.Rows.Item(I).Item("CodConfig")


                        Me.tbQtd.Rows.Add()
                        Me.tbQtd.Rows.Item(A).Item("Codigo") = dt1.Rows.Item(I).Item("Codigo")
                        Me.tbQtd.Rows.Item(A).Item("Tamanho") = dt1.Rows.Item(I).Item("Tamanho").ToString
                        Me.tbQtd.Rows.Item(A).Item("QtdMinima") = dt1.Rows.Item(I).Item("QtdMinima").ToString
                        Me.tbQtd.Rows.Item(A).Item("QtdMaxima") = dt1.Rows.Item(I).Item("QtdMaxima").ToString
                        Me.tbQtd.Rows.Item(A).Item("Qtd") = dt1.Rows.Item(I).Item("Qtd").ToString
                        Me.tbQtd.Rows.Item(A).Item("QtdSemAlterar") = dt1.Rows.Item(I).Item("Qtd").ToString
                        Me.tbQtd.Rows.Item(A).Item("Lote") = dt1.Rows.Item(I).Item("Lote").ToString
                        Me.tbQtd.Rows.Item(A).Item("ValorCusto") = dt1.Rows.Item(I).Item("ValorCusto").ToString
                        Me.tbQtd.Rows.Item(A).Item("EmFalta") = dt1.Rows.Item(I).Item("EmFalta").ToString
                        If dt1.Rows.Item(A).Item("Tamanho").ToString = "U" Then
                            Tamanho(False)
                        End If

                        Me.tbQtd.Rows.Item(A).Item("CodConfig") = dt1.Rows.Item(I).Item("CodConfig").ToString
                        Me.tbQtd.Rows.Item(A).Item("Descricao") = dt1.Rows.Item(I).Item("Descricao").ToString

                        If EstoqueSomado = True Then
                            If I < QtdeLoja Then
                                vetQtd(I) = Nothing
                                vetQtd(I) = dt1.Rows.Item(I).Item("Qtd").ToString

                                Dim dblQtdMin As Double = 0
                                If dt1.Rows.Item(I).Item("QtdMinima").ToString <> "" Then
                                    dblQtdMin = dt1.Rows.Item(I).Item("QtdMinima").ToString
                                End If

                                Dim strLoja As String = dt1.Rows.Item(I).Item("CodConfig").ToString

                                

                                Dim dblResul As Double = AjusteQtde(strLoja, intCodPro)

                                Select Case cboUniMed.SelectedIndex
                                    Case 0, 1, 2
                                        dblResul = dblResul.ToString("0")
                                    Case Else
                                        dblResul = dblResul.ToString("0.000")
                                End Select

                                Me.tbQtd.Rows.Item(A).Item("Qtd") = dblResul
                                Me.tbQtd.Rows.Item(A).Item("EmFalta") = "0"
                                If dblResul = 0 Then
                                    Me.tbQtd.Rows.Item(A).Item("EmFalta") = "1"
                                Else
                                    If dblQtdMin >= dblResul Then
                                        Me.tbQtd.Rows.Item(A).Item("EmFalta") = "1"
                                    End If
                                End If

                                If strLoja = CodConfig Then
                                    Me.txtQtdeEstoque.Text = dblResul
                                    Me.txtQtdeMinima.Text = dt1.Rows.Item(I).Item("QtdMinima").ToString
                                    Me.txtQtdMaxima.Text = dt1.Rows.Item(I).Item("QtdMaxima").ToString
                                End If
                            End If

                        End If


                        If Me.colVU.Visible = True Then
                            Dim strPeriodo As String = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", Date.Today.AddDays(-30), Date.Today)

                            Dim dtPed As DataTable = CarregarDataTable("SELECT convert(Numeric(15,3),sum(Pedido.Qtd)) as Qtd FROM Pedido left join Total " & _
                            "on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig " & _
                            "where CodProd = " & intCodPro & " and " & strPeriodo & " and Devolvido = 'False' and Pedido.CodConfig = " & strVerificaCodConfig)

                            If dtPed.Rows.Count > 0 Then
                                Me.tbQtd.Rows.Item(A).Item("VU") = dtPed.Rows.Item(0).Item("Qtd").ToString
                            End If
                        End If



                        A += 1
                    End If


                Next
            End If

        End If
    End Sub
    Private Sub Alterar()
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        If Me.Tag = "RETORNAPRODUTO" Then Exit Sub
        chkDesc.Checked = False
        bolAlterado = True

        Me.chkAlterar.Tag = ""
        Me.chkAlterar.Checked = False
        Me.txtCodInt.Enabled = False

        Me.cboTipo.SelectedIndex = 0

        Me.txtPor1.ResetText()
        Tamanho(True)
        CFOPCombustivel()
        Dim Index As Integer = grd1.FocusedRowHandle
        IndexGrid = grd1.FocusedRowHandle
        Me.btnCadCodBarra.Enabled = True
        If TipoFiscal = "AMBOS" Then
            Me.btnSalvarTributacao.Visible = True
        End If

        With grd1
            intCodPro = .GetRowCellDisplayText(Index, Me.colCodigo)
            intCodProdTabela = .GetRowCellDisplayText(Index, Me.colCodigo)
            strNome = .GetRowCellDisplayText(Index, Me.colNome)
            strCodInterno = .GetRowCellDisplayText(Index, Me.colCodigoInterno)
            strCodBarra = .GetRowCellDisplayText(Index, Me.colCodigoBarra)
            strValorVenda = .GetRowCellDisplayText(Index, Me.colValor)
            strValorCusto = .GetRowCellDisplayText(Index, Me.colValorCusto)
            Me.txtCodInt.Text = .GetRowCellDisplayText(Index, Me.colCodigoInterno)
            Me.txtCodProdFor.Text = .GetRowCellDisplayText(Index, Me.colCodProdFor)
            Me.txtNome.Text = .GetRowCellDisplayText(Index, Me.colNome)
            Me.cboUniMed.Text = .GetRowCellDisplayText(Index, Me.colUnidadeMedida)
            Me.txtValCus.Text = .GetRowCellDisplayText(Index, Me.colValorCusto)
            Me.txtVal.Text = .GetRowCellDisplayText(Index, Me.colValor)


            Try
                Dim dtTabela As DataTable = CarregarDataTable("Select TabelaPreco From Config Where Codigo=" & CodConfig)

                Dim strTabela As String = ""
                Dim strCasaDescimais As String = "Numeric(15," & CasaDecimal & ")"

                If dtTabela.Rows.Count > 0 Then
                    strTabela = dtTabela.Rows.Item(0).Item("TabelaPreco")

                    If strTabela <> "" Then
                        Dim dtValor As DataTable = CarregarDataTable("Select Convert(" & strCasaDescimais & ", Valor) as Valor From Produto Where Codigo=" & intCodPro)

                        If dtValor.Rows.Count > 0 Then
                            strValorVenda = dtValor.Rows.Item(0).Item("Valor").ToString
                            Me.txtVal.Text = dtValor.Rows.Item(0).Item("Valor").ToString
                        End If
                    End If
                End If
            Catch ex As Exception
            End Try


            Me.cboFabricante.Text = .GetRowCellDisplayText(Index, Me.colFabricante)
            Me.cboGrp.Text = .GetRowCellDisplayText(Index, Me.colGrupo)
            Me.txtObs.Text = .GetRowCellDisplayText(Index, Me.colObs)
            'Me.txtCodBarra.Text = .GetRowCellDisplayText(Index, Me.colCodigoBarra)
            Me.cboSet.Text = .GetRowCellDisplayText(Index, Me.colSetor)
            Me.dtValidade.Text = .GetRowCellDisplayText(Index, Me.colValidade)

            'Me.txtdtCad.Text = .GetRowCellDisplayText(Index, Me.colData)
            Me.txtAlteracao.Text = .GetRowCellDisplayText(Index, Me.colData)
            Me.chkTribPadrao.Checked = .GetRowCellValue(Index, Me.colTributacaoPadrao)
            Me.chkInativar.Checked = .GetRowCellValue(Index, Me.colInativo)
            Me.CheckEdit1.Checked = .GetRowCellValue(Index, Me.colAlterarPreco)
            Me.txtComissao.Text = .GetRowCellDisplayText(Index, Me.colComissao)
            Me.cboFamilia.Text = .GetRowCellDisplayText(Index, Me.colFamilia)
            Me.txtLoc2.Text = .GetRowCellDisplayText(Index, Me.colLocacao2)
            If .GetRowCellDisplayText(Index, Me.colTipo).Trim <> "" Then
                Me.cboTipo.Text = .GetRowCellDisplayText(Index, Me.colTipo)
                If .GetRowCellDisplayText(Index, Me.colTipo) = "RECEITA" Then
                    Me.cboTipo.Enabled = False
                    Me.txtValCus.Enabled = False
                Else
                    Me.cboTipo.Enabled = True
                    Me.txtValCus.Enabled = True
                End If
            End If

            Me.txtCodFab.Text = .GetRowCellDisplayText(Index, Me.colCodFab)
            Me.txtGarantia.Text = .GetRowCellDisplayText(Index, Me.colGarantia)
            Me.txtRevKM.Text = .GetRowCellDisplayText(Index, Me.colKM)
            Me.txtPeso.Text = CampoValor(.GetRowCellDisplayText(Index, Me.colPeso))
            Me.txtPesoBruto.Text = CampoValor(.GetRowCellDisplayText(Index, Me.colPesoBruto))
            Me.NanoCampo1.Text = CampoValor(.GetRowCellDisplayText(Index, Me.colQtdEmb))
            If .GetRowCellDisplayText(Index, Me.colNivelComboCodCF).Trim <> "" Then
                Me.cboCodCF.SelectedIndex = .GetRowCellDisplayText(Index, Me.colNivelComboCodCF)
            End If

            If .GetRowCellDisplayText(Index, Me.colDesconto).Trim <> "" And .GetRowCellDisplayText(Index, Me.colDesconto).Trim <> "0,00" And .GetRowCellDisplayText(Index, Me.colDesconto).Trim <> "0,000" Then
                Me.chkDesc.Checked = True
                Me.txtDesconto.Text = .GetRowCellDisplayText(Index, Me.colDesconto)

                Dim dblValCus, dblResul As Double
                Dim dblPor As Double = Me.txtDesconto.Text
                dblValCus = Me.txtVal.Text
                dblResul = (dblValCus * dblPor) / 100
                Me.txtValDesconto.Text = dblResul.ToString("0.000")
            End If


            Me.txtPor1.Text = .GetRowCellDisplayText(Index, Me.colPorcentagens)

            Dim dt2 As DataTable = CarregarDataTable("Select ICMS, IPI, Tributacao, Cst, OrigemIcms, IPPT, Pesavel, TipoFIA, NCM from ImpostoProduto where CodProd = " & intCodPro)

            If dt2.Rows.Count > 0 Then
                Me.txtIcms.Text = dt2.Rows.Item(0).Item("ICMS").ToString
                Me.txtIPI.Text = dt2.Rows.Item(0).Item("IPI").ToString
                Me.cboTrib.Text = dt2.Rows.Item(0).Item("Tributacao").ToString
                Me.cboCst.Text = dt2.Rows.Item(0).Item("Cst").ToString
                Me.cboOriIcm.Text = dt2.Rows.Item(0).Item("OrigemIcms").ToString
                Me.cboIPPT.Text = dt2.Rows.Item(0).Item("IPPT").ToString
                Me.cboPesa.Text = dt2.Rows.Item(0).Item("Pesavel").ToString
                Me.cboFIA.Text = dt2.Rows.Item(0).Item("TipoFIA").ToString
                Me.txtNCMImpProd.Text = dt2.Rows.Item(0).Item("NCM").ToString

            Else
                Me.txtNCMImpProd.ResetText()
                Me.txtIcms.ResetText()
                Me.txtIPI.ResetText()
                Me.cboTrib.SelectedIndex = -1
                Me.cboCst.SelectedIndex = -1
                Me.cboOriIcm.SelectedIndex = -1
                Me.cboIPPT.SelectedIndex = -1
                Me.cboPesa.SelectedIndex = -1
                Me.cboFIA.SelectedIndex = -1

            End If
            CarregarComboCodigoBarra()

            CarregarQtde()



            'Dim dt1 As DataTable
            'Dim strSql As String = ""
            'Dim strQtdes As String = ""
            'Select Case cboUniMed.SelectedIndex
            '    Case 0, 1, 2
            '        strQtdes = "Convert(Numeric(15), QtdMinima) as QtdMinima, Convert(Numeric(15), Qtd) as Qtd"
            '    Case 3, 4
            '        strQtdes = "Convert(Numeric(15,3), QtdMinima) as QtdMinima, Convert(Numeric(15,3), Qtd) as Qtd"
            '    Case 5
            '        strQtdes = "Convert(Numeric(15,2), QtdMinima) as QtdMinima, Convert(Numeric(15,2), Qtd) as Qtd"
            '    Case Else
            '        strQtdes = "Convert(Numeric(15,3), QtdMinima) as QtdMinima, Convert(Numeric(15,3), Qtd) as Qtd"
            'End Select


            'If Master = True Then
            '    strSql = "SELECT Qtde.Codigo, Tamanho, " & strQtdes & ", Lote, ValorCusto, EmFalta, CodConfig, Descricao FROM Qtde left join Config on Qtde.CodConfig = Config.Codigo where CodProd = " & intCodPro & " and Acabou = 'False'"
            'Else
            '    strSql = "SELECT Qtde.Codigo, Tamanho, " & strQtdes & ", Lote, ValorCusto, EmFalta, CodConfig, Descricao FROM Qtde left join Config on Qtde.CodConfig = Config.Codigo where CodProd = " & intCodPro & " and Acabou = 'False' and CodConfig =" & CodConfig
            'End If

            'dt1 = CarregarDataTable(strSql)

            'Me.tbQtd.Rows.Clear()

            'If dt1.Rows.Count > 0 Then
            '    For I = 0 To dt1.Rows.Count - 1
            '        Me.tbQtd.Rows.Add()
            '        Me.tbQtd.Rows.Item(I).Item("Codigo") = dt1.Rows.Item(I).Item("Codigo")
            '        Me.tbQtd.Rows.Item(I).Item("Tamanho") = dt1.Rows.Item(I).Item("Tamanho").ToString
            '        Me.tbQtd.Rows.Item(I).Item("QtdMinima") = dt1.Rows.Item(I).Item("QtdMinima").ToString
            '        Me.tbQtd.Rows.Item(I).Item("Qtd") = dt1.Rows.Item(I).Item("Qtd").ToString
            '        Me.tbQtd.Rows.Item(I).Item("QtdSemAlterar") = dt1.Rows.Item(I).Item("Qtd").ToString
            '        Me.tbQtd.Rows.Item(I).Item("Lote") = dt1.Rows.Item(I).Item("Lote").ToString
            '        Me.tbQtd.Rows.Item(I).Item("ValorCusto") = dt1.Rows.Item(I).Item("ValorCusto").ToString
            '        Me.tbQtd.Rows.Item(I).Item("EmFalta") = dt1.Rows.Item(I).Item("EmFalta").ToString
            '        If dt1.Rows.Item(I).Item("Tamanho").ToString = "U" Then
            '            Tamanho(False)
            '        End If

            '        Me.tbQtd.Rows.Item(I).Item("CodConfig") = dt1.Rows.Item(I).Item("CodConfig").ToString
            '        Me.tbQtd.Rows.Item(I).Item("Descricao") = dt1.Rows.Item(I).Item("Descricao").ToString

            '    Next
            'End If

            Dim dtCons As DataTable
            Dim strtamanho As String
            Dim strCodConfig As String
            Dim dblQtd As Double
            Dim A As Integer
            dtCons = CarregarDataTable("SELECT sum(Qtd) as Pendente, Tamanho, TotalConsig.CodConfig FROM ItensConsig inner join TotalConsig on ItensConsig.CodOrdens = TotalConsig.CodOrdens and ItensConsig.CodConfig = TotalConsig.CodConfig where CodigoProduto = '" & intCodPro & "' and TotalConsig.Status = 'Pendente' group by Tamanho, TotalConsig.CodConfig")
            If dtCons.Rows.Count > 0 Then
                For I = 0 To dtCons.Rows.Count - 1
                    strtamanho = dtCons.Rows.Item(I).Item("Tamanho").ToString
                    dblQtd = dtCons.Rows.Item(I).Item("Pendente").ToString
                    strCodConfig = dtCons.Rows.Item(I).Item("CodConfig").ToString

                    For A = 0 To Me.grd2.RowCount - 1
                        Dim str As String = Me.grd2.GetRowCellDisplayText(A, Me.colCodConfig)
                        If Me.grd2.GetRowCellDisplayText(A, Me.colTamanho) = strtamanho And Me.grd2.GetRowCellDisplayText(A, Me.colCodConfig) = strCodConfig Then
                            Me.grd2.SetRowCellValue(A, Me.colPendente, dblQtd)
                        End If
                    Next
                Next
            End If

            Me.txtLoc.Text = .GetRowCellDisplayText(Index, Me.colLocacao)


        End With




        If EmiteNFE = True Or AbaSatFiscal = True Or NANONFCe = True Then
            CarregarTributacao()
        End If

        CarregarImagem(intCodPro)

        frmTabelaPreco.intCodProd = intCodProdTabela
        frmTabelaPreco.AtualizarGrid()

        Historico(False)

        CarregarAjuste()
        If TipoNano = 1 Then
            CarregaOpc(intCodPro)
        End If
        Me.txtQtde.ResetText()
        Me.txtQtdeMin.ResetText()
        bolAlteradoQtd = False

        Me.txtNome.Focus()
    End Sub
    Private Sub CarregarTributacao()
        Dim strUM As String = Me.cboUniMed.Text
        Select Case strUM
            Case "UNIDADE"
                strUM = "UN"
            Case "JOGO"
                strUM = "JG"

            Case "KIT"
                strUM = "KIT"

            Case "PESO"
                strUM = "KG"

            Case "LÍTRO"
                strUM = "LT"

            Case "METRO"
                strUM = "MT"
            Case "HORA"
                strUM = "HR"
        End Select


        Dim dtNfe As DataTable = CarregarDataTable("SELECT EXTIPI, Genero, CFOP, NCM, Regime FROM Nfe where CodProd = " & intCodPro & " and Regime like '%" & RegimeSAT & "%' order by Regime")
        If dtNfe.Rows.Count > 0 Then
            Me.txtEXTIPI.Text = dtNfe.Rows.Item(0).Item("EXTIPI").ToString
            Me.txtGenero.Text = dtNfe.Rows.Item(0).Item("Genero").ToString
            Me.txtNfeNCM.Text = dtNfe.Rows.Item(0).Item("NCM").ToString

            Me.lueCFOP.EditValue = DBNull.Value
            Me.lueCFOP.Text = dtNfe.Rows.Item(0).Item("CFOP").ToString
            Me.lueCFOP.EditValue = dtNfe.Rows.Item(0).Item("CFOP").ToString
            strCfopDoProduto = dtNfe.Rows.Item(0).Item("CFOP").ToString
            Me.lueCFOP.ClosePopup()

            CFOPCombustivel()
            If bolTipoFiscal = False Then
                bolTipoFiscal = True
                Select Case dtNfe.Rows.Item(0).Item("Regime").ToString
                    Case "SIMPLES NACIONAL", "", "TRIBUTAÇÃO NORMAL"
                        Me.cboTipoFiscal.Text = "AMBOS"
                    Case Else
                        Me.cboTipoFiscal.Text = dtNfe.Rows.Item(0).Item("Regime").ToString.Replace("SIMPLES NACIONAL ", "").Replace("TRIBUTAÇÃO NORMAL ", "")
                End Select
            End If
            bolTipoFiscal = False
        Else
            dtNfe = CarregarDataTable("SELECT EXTIPI, Genero, CFOP, NCM, Regime FROM Nfe where CodProd = " & intCodPro & " and CFOP <> '' order by Regime")
            If dtNfe.Rows.Count > 0 Then
                Me.txtEXTIPI.Text = dtNfe.Rows.Item(0).Item("EXTIPI").ToString
                Me.txtGenero.Text = dtNfe.Rows.Item(0).Item("Genero").ToString
                Me.txtNfeNCM.Text = dtNfe.Rows.Item(0).Item("NCM").ToString

                Me.lueCFOP.EditValue = DBNull.Value
                Me.lueCFOP.Text = dtNfe.Rows.Item(0).Item("CFOP").ToString
                Me.lueCFOP.EditValue = dtNfe.Rows.Item(0).Item("CFOP").ToString
                strCfopDoProduto = dtNfe.Rows.Item(0).Item("CFOP").ToString
                Me.lueCFOP.ClosePopup()
                CFOPCombustivel()
                If bolTipoFiscal = False Then
                    bolTipoFiscal = True
                    Select Case dtNfe.Rows.Item(0).Item("Regime").ToString
                        Case "SIMPLES NACIONAL", "", "TRIBUTAÇÃO NORMAL"
                            Me.cboTipoFiscal.Text = "AMBOS"
                        Case Else
                            Me.cboTipoFiscal.Text = dtNfe.Rows.Item(0).Item("Regime").ToString.Replace("SIMPLES NACIONAL ", "").Replace("TRIBUTAÇÃO NORMAL ", "")
                    End Select
                End If
                bolTipoFiscal = False
            Else
                Me.cboTipoFiscal.Text = "AMBOS"
                Me.txtEXTIPI.ResetText()
                Me.txtGenero.ResetText()
                Me.lueCFOP.EditValue = DBNull.Value
                Me.CFOPTableAdapter.Fill(Me.DsNanoCommerce.CFOP)
                Me.txtNfeNCM.ResetText()
            End If
        End If


        Dim strTipoFiscal As String = ""

        If TipoFiscal = "AMBOS" Then
            Select Case Me.cboTipoFiscal.Text
                Case "NFE"
                    strTipoFiscal = " NFE"

                Case "SAT"
                    strTipoFiscal = " SAT"
            End Select
        End If


        dtNfe = CarregarDataTable("SELECT Codigo, CodProd, EXTIPI, Genero, UnidTrib, ValTrib, " & _
        "QtdTrib, MIPI, QtdN, CST, Origem, ModBC, ICMS, RedBC, ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, " & _
        "Regime, CalculoCred, UnidCom, ValCom, CodigoANP, UFComb, Cest, PerFCPUF, PerICMSUF FROM Nfe where CodProd = " & intCodPro & " and Regime = 'SIMPLES NACIONAL" & strTipoFiscal & "'")

        If dtNfe.Rows.Count > 0 Then
            Me.cboRegime.Text = dtNfe.Rows.Item(0).Item("Regime").ToString.Replace(" NFE", "").Replace(" SAT", "")
            SelecionarCombo(Me.cboNfeCST, dtNfe.Rows.Item(0).Item("CST").ToString)
            CST(Me.cboRegime.Text)

            SelecionarCombo(Me.cboOrigem, dtNfe.Rows.Item(0).Item("Origem").ToString)
            SelecionarCombo(Me.cboModBC, dtNfe.Rows.Item(0).Item("ModBC").ToString)
            Me.txtNfeICMS.Text = dtNfe.Rows.Item(0).Item("ICMS").ToString
            Me.txtRedBC.Text = dtNfe.Rows.Item(0).Item("RedBC").ToString
            SelecionarCombo(Me.cboModBCST, dtNfe.Rows.Item(0).Item("ModBCST").ToString)
            Me.txtRedBCST.Text = dtNfe.Rows.Item(0).Item("RedBCST").ToString
            Me.txtMVAST.Text = dtNfe.Rows.Item(0).Item("MVaST").ToString
            Me.txtICMSST.Text = dtNfe.Rows.Item(0).Item("ICMSST").ToString
            Me.txtCalcCred.Text = dtNfe.Rows.Item(0).Item("CalculoCred").ToString
            Me.txtPerFCPUF.Text = dtNfe.Rows.Item(0).Item("PerFCPUF").ToString
            Me.txtPerICMSUF.Text = dtNfe.Rows.Item(0).Item("PerICMSUF").ToString
            Me.cboCodigoANP.Text = dtNfe.Rows.Item(0).Item("CodigoANP").ToString
            Me.cboUF.Text = dtNfe.Rows.Item(0).Item("UFComb").ToString
            Me.txtCest.Text = dtNfe.Rows.Item(0).Item("Cest").ToString
        Else
            Me.cboNfeCST.SelectedIndex = -1
            Me.cboOrigem.SelectedIndex = -1
            Me.cboModBC.SelectedIndex = -1
            Me.txtNfeICMS.ResetText()
            Me.txtRedBC.ResetText()
            Me.cboModBCST.SelectedIndex = -1
            Me.txtRedBCST.ResetText()
            Me.txtMVAST.ResetText()
            Me.txtICMSST.ResetText()

            Me.txtCalcCred.ResetText()
            Me.cboRegime.SelectedIndex = -1
            Me.txtCest.ResetText()
            Me.txtPerFCPUF.ResetText()
            Me.txtPerICMSUF.ResetText()
        End If

        dtNfe = CarregarDataTable("SELECT Codigo, CodProd, EXTIPI, Genero, UnidTrib, ValTrib, " & _
        "QtdTrib, MIPI, QtdN, CST, Origem, ModBC, ICMS, RedBC, ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, " & _
        "Regime, CalculoCred, UnidCom, ValCom, CodigoANP, UFComb, Cest, PerFCPUF, PerICMSUF FROM Nfe where CodProd = " & intCodPro & " and Regime = 'TRIBUTAÇÃO NORMAL" & strTipoFiscal & "'")

        If dtNfe.Rows.Count > 0 Then
            Me.cboRegime.Text = dtNfe.Rows.Item(0).Item("Regime").ToString.Replace(" NFE", "").Replace(" SAT", "")
            SelecionarCombo(Me.cboCstTN, dtNfe.Rows.Item(0).Item("CST").ToString)
            CST(Me.cboRegime.Text)

            SelecionarCombo(Me.cboOrigemTN, dtNfe.Rows.Item(0).Item("Origem").ToString)
            SelecionarCombo(Me.cboModBcTN, dtNfe.Rows.Item(0).Item("ModBC").ToString)
            Me.txtIcmsTN.Text = dtNfe.Rows.Item(0).Item("ICMS").ToString
            Me.txtRedBcTN.Text = dtNfe.Rows.Item(0).Item("RedBC").ToString
            SelecionarCombo(Me.cboModBcStTN, dtNfe.Rows.Item(0).Item("ModBCST").ToString)
            Me.txtRedBcStTN.Text = dtNfe.Rows.Item(0).Item("RedBCST").ToString
            Me.txtMvaStTN.Text = dtNfe.Rows.Item(0).Item("MVaST").ToString
            Me.txtIcmsStTN.Text = dtNfe.Rows.Item(0).Item("ICMSST").ToString
            Me.txtCalcCredTN.Text = dtNfe.Rows.Item(0).Item("CalculoCred").ToString
            Me.txtPercFcpTN.Text = dtNfe.Rows.Item(0).Item("PerFCPUF").ToString
            Me.txtPercIcmsTN.Text = dtNfe.Rows.Item(0).Item("PerICMSUF").ToString
        Else
            Me.cboCstTN.SelectedIndex = -1
            Me.cboOrigemTN.SelectedIndex = -1
            Me.cboModBcTN.SelectedIndex = -1
            Me.txtIcmsTN.ResetText()
            Me.txtRedBcTN.ResetText()
            Me.cboModBcStTN.SelectedIndex = -1
            Me.txtRedBcStTN.ResetText()
            Me.txtMvaStTN.ResetText()
            Me.txtIcmsStTN.ResetText()
            Me.txtCalcCredTN.ResetText()

            Me.txtPercFcpTN.ResetText()
            Me.txtPercIcmsTN.ResetText()
        End If


        Dim dtTrib As DataTable = CarregarDataTable("SELECT Regime, CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, PerCOFINS FROM Tributos where CodProd = " & intCodPro & " and Regime ='SIMPLES NACIONAL" & strTipoFiscal & "'")

        If dtTrib.Rows.Count > 0 Then
            SelecionarCombo(Me.cboCSTIPI, dtTrib.Rows.Item(0).Item("CSTIPI").ToString)
            SelecionarCombo(Me.cboCSTPIS, dtTrib.Rows.Item(0).Item("CSTPIS").ToString)
            SelecionarCombo(Me.cboCSTCOFINS, dtTrib.Rows.Item(0).Item("CSTCOFINS").ToString)

            Me.txtCodEnq.Text = dtTrib.Rows.Item(0).Item("CodEnq").ToString
            Me.txtAliquotaIPI.Text = dtTrib.Rows.Item(0).Item("PerIPI").ToString
            Me.txtAliquotaPIS.Text = dtTrib.Rows.Item(0).Item("PerPIS").ToString
            Me.txtAliquotaCOFINS.Text = dtTrib.Rows.Item(0).Item("PerCOFINS").ToString
        End If

        dtTrib = CarregarDataTable("SELECT CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, PerCOFINS FROM Tributos where CodProd = " & intCodPro & " and Regime ='TRIBUTAÇÃO NORMAL" & strTipoFiscal & "'")

        If dtTrib.Rows.Count > 0 Then
            SelecionarCombo(Me.cboCstIpiTN, dtTrib.Rows.Item(0).Item("CSTIPI").ToString)
            SelecionarCombo(Me.cboCstPisTN, dtTrib.Rows.Item(0).Item("CSTPIS").ToString)
            SelecionarCombo(Me.cboCstCofinsTN, dtTrib.Rows.Item(0).Item("CSTCOFINS").ToString)

            Me.txtCodEnqTN.Text = dtTrib.Rows.Item(0).Item("CodEnq").ToString
            Me.txtAliquotaIpiTN.Text = dtTrib.Rows.Item(0).Item("PerIPI").ToString
            Me.txtAliquotaPisTN.Text = dtTrib.Rows.Item(0).Item("PerPIS").ToString
            Me.txtAliquotaCofinsTN.Text = dtTrib.Rows.Item(0).Item("PerCOFINS").ToString

        End If
    End Sub
    Private Sub CarregarImagem(ByVal parCodigo As String)
        If parCodigo = "" Then Exit Sub
        Dim dt As DataTable = CarregarDataTable("SELECT Imagem1, Imagem2 FROM Produto where Codigo = " & parCodigo)
        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item("Imagem1").ToString <> "" Then
                Dim Imagem As Byte() = CType(dt.Rows.Item(0).Item("Imagem1"), Byte())

                Dim memorybits As New MemoryStream(Imagem)

                Dim bitmap As New Bitmap(memorybits)


                Me.picImagem3.Image = bitmap
            Else

                Me.picImagem3.Image = Nothing
            End If
            If dt.Rows.Item(0).Item("Imagem2").ToString <> "" Then
                Dim Imagem As Byte() = CType(dt.Rows.Item(0).Item("Imagem2"), Byte())

                Dim memorybits As New MemoryStream(Imagem)

                Dim bitmap As New Bitmap(memorybits)


                Me.picImagem4.Image = bitmap
            Else

                Me.picImagem4.Image = Nothing

            End If

        End If

        Dim imgImagem As New PictureBox

        imgImagem.Size = New System.Drawing.Size(300, 50)

        Dim Barcode As New BarcodeLib.Barcode(parCodigo, BarcodeLib.TYPE.CODE128)
        imgImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE128, parCodigo, 120, 19)
        imgImagem.Image.RotateFlip(RotateFlipType.RotateNoneFlipNone)

        Me.picCod.Image = imgImagem.Image


    End Sub
    Private Sub SalvarQtde(ByVal parCadastro As Boolean, ByVal parCodProd As String, ByVal parCodConfig As String, ByVal parQtd As Double)

        If parCadastro = True Then
            Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data, CodUser) VALUES (" & _
            "" & parCodProd & "," & Num(parQtd) & "," & parCodConfig & ",'QTDE','" & My.Computer.Clock.LocalTime & "'," & CodUser & ")")

            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) " & _
            "VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Qtd Antiga: 0 Ajuste: " & parQtd & "'," & _
            "'Qtd Nova: " & parQtd & " Cód. Prod.: " & Me.txtCodInt.Text & " Loja.: " & parCodConfig & "'," & _
            "'QTDE AJUSTE','PRODUTO','CADASTRO'," & CodConfig & ")")
        Else
            Dim dblResul As Double = AjusteQtde(parCodConfig, parCodProd)

            Dim dblQtd As Double = parQtd - dblResul

            If dblQtd <> 0 Then
                Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data, CodUser) VALUES (" & _
                          "" & parCodProd & "," & Num(dblQtd) & "," & parCodConfig & ",'QTDE','" & My.Computer.Clock.LocalTime & "'," & CodUser & ")")

                Atualizar("Update Qtde set Qtd =" & Num(parQtd) & " where CodProd = " & parCodProd & " and CodConfig = " & parCodConfig)

                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) " & _
                "VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Qtd Antiga: " & dblResul & " Ajuste: " & dblQtd & "'," & _
                "'Qtd Nova: " & parQtd & " Cód. Prod.: " & Me.txtCodInt.Text & " Loja.: " & parCodConfig & "'," & _
                "'QTDE AJUSTE','PRODUTO','ALTERAÇÃO'," & CodConfig & ")")
            End If
          
        End If
   

    End Sub
    Private Shared Function VerificarTribPadrao(ByVal parCodigo As String) As Boolean

        If parCodigo = "" Then
            Dim dt As DataTable = CarregarDataTable("SELECT Nome FROM Produto where TributacaoPadrao = 'True'")
            If dt.Rows.Count > 0 Then
                MsgBox("O produto " & dt.Rows.Item(0).Item("Nome").ToString & " já está marcado como padrão!" & vbCrLf & "Para marcar outro produto você precisa desmarca-lo!", MsgBoxStyle.Information)
                Return False
            End If
        Else
            Dim dt As DataTable = CarregarDataTable("SELECT Nome FROM Produto where TributacaoPadrao = 'True' and COdigo <> " & parCodigo)
            If dt.Rows.Count > 0 Then
                MsgBox("O produto " & dt.Rows.Item(0).Item("Nome").ToString & " já está marcado como padrão!" & vbCrLf & "Para marcar outro produto você precisa desmarca-lo!", MsgBoxStyle.Information)
                Return False
            End If
        End If
        Return True
    End Function


    Private Sub SalvarOpc()
        If bolSalvarOpc = False Then Exit Sub
        Dim index As Integer = -999997
        grd6.FocusedRowHandle = index
        grd6.FocusedColumn = Me.colOpcao
        grd6.ShowEditor()
        Me.grd6.ClearColumnsFilter()
        Me.grd6.ActiveFilter.Clear()
        grd6.ActiveFilter.NonColumnFilter = "[AddOpc] = 'True'"


        Dim I As Integer
        Excluir("DELETE FROM VincProdOpc Where CodProd = " & intCodPro)

        For I = 0 To Me.grd6.RowCount - 1
            Dim strCodOpc As String = Me.grd6.GetRowCellDisplayText(I, Me.colCodigo4)
            Inserir("INSERT INTO VincProdOpc (CodProd, CodOpc) VALUES (" & intCodPro & "," & strCodOpc & ")")
        Next

    End Sub
    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick

        If TesteConexao() = False Then Exit Sub

        txtNome.Focus()

        If Validar(Me.txtNome) = False Then Exit Sub
        If Validar(Me.cboUniMed) = False Then Exit Sub

        If Validar(Me.cboGrp) = False Then Exit Sub
        If Validar(Me.txtValCus) = False Then Exit Sub
        If Validar(Me.txtVal) = False Then Exit Sub

        If ManterMargemProd = True Then
            If Validar(Me.txtPor1) = False Then Exit Sub
        End If
     
        If PafEcfNano = True Then
            If Me.cboTipo.Text <> "SERVIÇO" Then

                If Validar(Me.cboTrib) = False Then
                    Me.tabProd.SelectedTabPageIndex = 1
                    Exit Sub
                End If

                'If Validar(Me.cboCst) = False Then
                '    Me.tabProd.SelectedTabPageIndex = 1
                '    Exit Sub
                'End If

                'If Validar(Me.cboOriIcm) = False Then
                '    Me.tabProd.SelectedTabPageIndex = 1
                '    Exit Sub
                'End If

                If Me.cboTrib.Text.Trim = "T" Then
                    If Validar(txtIcms) = False Then
                        Me.tabProd.SelectedTabPageIndex = 1
                        Exit Sub
                    End If
                End If

                'If Validar(Me.cboIPPT) = False Then Exit Sub
                'If Validar(Me.cboPesa) = False Then Exit Sub
                'If Validar(Me.cboFIA) = False Then Exit Sub
                If Validar(Me.txtNCMImpProd) = False Then Exit Sub

            End If
        End If

        If EmiteNFE = True Then
            If Me.cboTipo.Text <> "SERVIÇO" Then

                'If Validar(Me.cboRegime) = False Then Exit Sub
                'If Validar(Me.lueCFOP) = False Then Exit Sub
                If Validar(Me.txtNfeNCM) = False Then Exit Sub
                'If Validar(Me.cboOrigem) = False Then Exit Sub
                'If Validar(Me.cboNfeCST) = False Then Exit Sub
                'If Validar(Me.cboCSTIPI) = False Then Exit Sub
                'If Validar(Me.cboCSTPIS) = False Then Exit Sub
                'If Validar(Me.cboCSTCOFINS) = False Then Exit Sub
                'If Me.cboCSTIPI.Text <> "" Then
                '    If Validar(Me.txtCodEnq) = False Then Exit Sub
                'End If

            End If
        End If


        If ComissaoProduto = True Then
            If Validar(Me.txtComissao) = False Then Exit Sub
        End If

        Dim strCst As String = Me.cboNfeCST.Text
        If strCst <> "" Then
            'If Me.cboRegime.SelectedIndex = 0 Then
            '    strCst = strCst.Substring(0, 2)
            'Else
            strCst = strCst.Substring(0, 3)
            'End If
        End If

        Dim strCstTN As String = Me.cboCstTN.Text
        If strCstTN <> "" Then
            strCstTN = strCstTN.Substring(0, 2)
        End If

        Dim strOrig As String = Me.cboOrigem.Text
        If strOrig <> "" Then
            strOrig = strOrig.Substring(0, 1)
        End If
        Dim strOrigTN As String = Me.cboOrigemTN.Text
        If strOrigTN <> "" Then
            strOrigTN = strOrigTN.Substring(0, 1)
        End If

        Dim strModBC As String = Me.cboModBC.Text
        If strModBC <> "" Then
            strModBC = strModBC.Substring(0, 1)
        End If
        Dim strModBCTN As String = Me.cboModBcTN.Text
        If strModBCTN <> "" Then
            strModBCTN = strModBCTN.Substring(0, 1)
        End If
        Dim strModBCST As String = Me.cboModBCST.Text
        If strModBCST <> "" Then
            strModBCST = strModBCST.Substring(0, 1)
        End If

        Dim strModBCSTTN As String = Me.cboModBcStTN.Text
        If strModBCSTTN <> "" Then
            strModBCSTTN = strModBCSTTN.Substring(0, 1)
        End If

        Dim strCstIPI As String = Me.cboCSTIPI.Text
        If strCstIPI <> "" Then
            strCstIPI = strCstIPI.Substring(0, 2)
        End If
        Dim strCstIPITN As String = Me.cboCstIpiTN.Text
        If strCstIPITN <> "" Then
            strCstIPITN = strCstIPITN.Substring(0, 2)
        End If
        Dim strCstPIS As String = Me.cboCSTPIS.Text
        If strCstPIS <> "" Then
            strCstPIS = strCstPIS.Substring(0, 2)
        End If
        Dim strCstPISTN As String = Me.cboCstPisTN.Text
        If strCstPISTN <> "" Then
            strCstPISTN = strCstPISTN.Substring(0, 2)
        End If
        Dim strCstCOFINS As String = Me.cboCSTCOFINS.Text
        If strCstCOFINS <> "" Then
            strCstCOFINS = strCstCOFINS.Substring(0, 2)
        End If
        Dim strCstCOFINSTN As String = Me.cboCstCofinsTN.Text
        If strCstCOFINSTN <> "" Then
            strCstCOFINSTN = strCstCOFINSTN.Substring(0, 2)
        End If
        Me.txtCodInt.Focus()

        If Me.chkInativar.Checked = True Then
            If MsgBox("Tem certeza que deseja inativar este produto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Me.chkInativar.Checked = False
            End If
        End If

        Dim dtVal As Date

        If Me.dtValidade.Text.Trim <> "" Then
            dtVal = Me.dtValidade.Text.Trim
        Else
            dtVal = "01/01/2050"
        End If

        If bolAlterado = False Then
            If Me.chkTribPadrao.Checked = True Then
                If VerificarTribPadrao("") = False Then Exit Sub
            End If
          
            If Me.txtCodInt.Text.Trim = "" Then
                GerCodigo()
            End If

            'If AcrescentarZeroCodProd = True Then

            '    Select Case Me.txtCodInt.Text.Length
            '        Case 1
            '            Me.txtCodInt.Text = "000" & Me.txtCodInt.Text
            '        Case 2
            '            Me.txtCodInt.Text = "00" & Me.txtCodInt.Text
            '        Case 3
            '            Me.txtCodInt.Text = "0" & Me.txtCodInt.Text
            '        Case 4
            '        Case Else
            '            If Not Me.txtCodInt.Text.Length Mod 2 = 0 Then
            '                Me.txtCodInt.Text = "0" & Me.txtCodInt.Text
            '            End If
            '    End Select
            'End If

            If Inserir("INSERT INTO Produto (Nome, UnidadeMedida, Valor, ValorCusto, Locacao, CodigoInterno, " & _
            "Porcentagens, Fabricante, Grupo, Obs, Data, CodigoBarra, NivelComboCodCF, Desconto, Setor, Tipo, " & _
            "Inativo, Validade, Comissao, Locacao2, Familia, CodProdFor, TributacaoPadrao, AlterarPreco, " & _
            "CodigoFabricante, Garantia, KM, Peso, PesoBruto, QtdEmb) VALUES ('" & Me.txtNome.Text.Trim.Replace("'", "") & "'," & _
            "'" & Me.cboUniMed.Text.Trim & "'," & Num(Me.txtVal.Text.Trim) & "," & Num(Me.txtValCus.Text.Trim) & "," & _
            "'" & Me.txtLoc.Text.Trim & "','" & Me.txtCodInt.Text.Trim & "','" & Me.txtPor1.Text.Trim & "'," & _
            "'" & Me.cboFabricante.Text.Trim & "','" & Me.cboGrp.Text.Trim & "','" & Me.txtObs.Text.Trim & "'," & _
            "'" & Date.Today & "','" & Me.txtCodBarra.Text.Trim & "','" & Me.cboCodCF.SelectedIndex & "'," & _
            "" & Num(Me.txtDesconto.Text.Trim) & ",'" & Me.cboSet.Text.Trim & "','" & Me.cboTipo.Text & "'," & _
            "'" & Me.chkInativar.Checked & "','" & dtVal & "'," & Num(Me.txtComissao.Text) & "," & _
            "'" & Me.txtLoc2.Text & "','" & Me.cboFamilia.Text & "','" & Me.txtCodProdFor.Text.Trim & "'," & _
            "'" & Me.chkTribPadrao.Checked & "','" & Me.CheckEdit1.Checked & "','" & Me.txtCodFab.Text & "'," & _
            "'" & Me.txtGarantia.Text & "','" & Me.txtRevKM.Text & "'," & Num(Me.txtPeso.Text.Trim) & "," & Num(Me.txtPesoBruto.Text) & "," & Num(Me.NanoCampo1.Text) & ")") = True Then

                MsgBox("Produto " & txtNome.Text.Trim & " cadastrado com sucesso!", MsgBoxStyle.Information)

                Dim intCodiProd As Integer = Val(GerarCodigo("Produto", "Codigo", 0)) - 1
                intCodPro = intCodiProd

                Dim dtProd As DataTable = CarregarDataTable("SELECT Codigo FROM Produto where " & _
                "Nome = '" & Me.txtNome.Text.Trim.Replace("'", "") & "' and CodigoInterno = '" & Me.txtCodInt.Text.Trim & "' " & _
                "and UnidadeMedida = '" & Me.cboUniMed.Text.Trim & "' and Grupo = '" & Me.cboGrp.Text.Trim & "' " & _
                "order by Codigo Desc")

                If dtProd.Rows.Count > 0 Then
                    intCodiProd = dtProd.Rows.Item(0).Item("Codigo").ToString
                    intCodPro = intCodiProd
                End If

                Dim dtLoc As DataTable = CarregarDataTable("Select Locacao from Locacao where CodProd = " & intCodPro & " and CodConfig = " & CodConfig)
                If dtLoc.Rows.Count = 0 Then
                    Inserir("INSERT INTO Locacao (CodProd, Locacao, CodConfig) Values(" & intCodPro & ",'" & Me.txtLoc.Text.Trim & "'," & CodConfig & ")")
                Else
                    Atualizar("Update Locacao set Locacao = '" & Me.txtLoc.Text.Trim & "' where CodProd = '" & intCodPro & "' and CodConfig = " & CodConfig)
                End If


                Inserir("Insert into ImpostoProduto (CodProd, ICMS, IPI, Tributacao, Cst, OrigemIcms, IPPT, Pesavel, " & _
                "TipoFIA, NCM) Values(" & intCodiProd & "," & Num(Me.txtIcms.Text.Trim) & "," & _
                "" & Num(Me.txtIPI.Text.Trim) & ",'" & Me.cboTrib.Text.Trim & "','" & Me.cboCst.Text.Trim & "'," & _
                "'" & Me.cboOriIcm.Text.Trim & "','" & Me.cboIPPT.Text.Trim & "','" & Me.cboPesa.Text.Trim & "'," & _
                "'" & Me.cboFIA.Text.Trim & "','" & Me.txtNCMImpProd.Text & "')")

                Dim T As Integer
                Dim intCodTabela, intCodPreco As Integer
                Dim srtValor, strPorcent As String

                If frmTabelaPreco.tbPreco.Rows.Count > 0 Then
                    For T = 0 To frmTabelaPreco.tbPreco.Rows.Count - 1
                        If frmTabelaPreco.tbPreco.Rows.Item(T).Item("CodPreco").ToString() <> "" Then
                            intCodPreco = frmTabelaPreco.tbPreco.Rows.Item(T).Item("CodPreco").ToString()
                        Else
                            intCodPreco = 0
                        End If

                        intCodTabela = frmTabelaPreco.tbPreco.Rows.Item(T).Item("CodTabela").ToString()
                        srtValor = frmTabelaPreco.tbPreco.Rows.Item(T).Item("Valor").ToString()
                        strPorcent = frmTabelaPreco.tbPreco.Rows.Item(T).Item("Porcent").ToString()
                        Dim dtTab As DataTable = CarregarDataTable("SELECT Codigo FROM TabelaPreco where CodProd = " & intCodPro & " and CodTabela = " & intCodTabela)

                        If dtTab.Rows.Count = 0 Then

                            Inserir("INSERT INTO TabelaPreco (CodProd, CodTabela, Valor, Porcentagem) VALUES (" & _
                            "" & intCodiProd & "," & intCodTabela & "," & Num(srtValor) & "," & Num(strPorcent) & ")")

                        Else
                            intCodPreco = dtTab.Rows.Item(0).Item("Codigo").ToString()
                            Atualizar("UPDATE TabelaPreco SET CodTabela = " & intCodTabela & ", " & _
                            "Valor =" & Num(srtValor) & ", Porcentagem =" & Num(strPorcent) & " Where Codigo = " & intCodPreco)

                        End If
                    Next
                End If


                Dim I As Integer
                Dim dblQtdLog As Double

                For I = 0 To grd2.RowCount - 1
                    Dim strValCusto As String = Num(Me.grd2.GetRowCellDisplayText(I, Me.colValorCustoQtd))
                    Dim dblQt As Double = 0
                    If Me.grd2.GetRowCellDisplayText(I, Me.colQtd) <> "" Then
                        dblQt = Me.grd2.GetRowCellDisplayText(I, Me.colQtd)
                    End If

                    Dim dblQtMin As Double = 0
                    If Me.grd2.GetRowCellDisplayText(I, Me.colQtdMinima) <> "" Then
                        dblQtMin = Me.grd2.GetRowCellDisplayText(I, Me.colQtdMinima)
                    End If

                    Dim dblQtMax As Double = 0
                    If Me.grd2.GetRowCellDisplayText(I, Me.colQtdMaxima) <> "" Then
                        dblQtMax = Me.grd2.GetRowCellDisplayText(I, Me.colQtdMaxima)
                    End If

                    Dim intFalta As Integer = 0

                    If dblQtMin >= dblQt Then
                        intFalta = 1
                    End If

                    dblQtdLog += dblQt

                    Inserir("INSERT INTO Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, ValorCusto, EmFalta, CodConfig, " & _
                    "Acabou, DataFim, QtdMaxima) VALUES (" & intCodiProd & ",'" & grd2.GetRowCellDisplayText(I, Me.colTamanho).Trim & "'," & _
                    "" & Num(grd2.GetRowCellDisplayText(I, Me.colQtdMinima).Trim) & "," & _
                    "" & Num(grd2.GetRowCellDisplayText(I, Me.colQtd).Trim) & "," & _
                    "'" & Me.grd2.GetRowCellDisplayText(I, Me.colLote).Trim & "'," & Num(strValCusto) & ",'" & intFalta & "'," & _
                    "" & Me.grd2.GetRowCellDisplayText(I, Me.colCodConfig) & ",'False','01/01/1900'," & Num(dblQtMax) & ")")

                    If EstoqueSomado = True Then

                        SalvarQtde(True, intCodiProd, Me.grd2.GetRowCellDisplayText(I, Me.colCodConfig), dblQt)
                    End If

                Next


                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES (" & _
                "'" & My.Computer.Clock.LocalTime & "'," & CodUser & ",''," & _
                "'" & Me.txtCodInt.Text.Trim & " - " & Me.txtNome.Text & " Qtd: " & dblQtdLog & "','PRODUTO','PRODUTO'," & _
                "'CADASTRO'," & CodConfig & ")")


                If EmiteNFE = True Or AbaSatFiscal = True Or NANONFCe = True Then

                    Dim strTipoFiscal As String = ""

                    If TipoFiscal = "AMBOS" Then
                        Select Case Me.cboTipoFiscal.Text
                            Case "NFE"
                                strTipoFiscal = " NFE"
                            Case "SAT"
                                strTipoFiscal = " SAT"
                        End Select
                    End If


                    Inserir("INSERT INTO Nfe (CodProd, EXTIPI, Genero, CST, Origem, ModBC, ICMS, RedBC, ModBCST, " & _
                    "RedBCST, MVaST, CFOP, ICMSST, NCM, Regime, CalculoCred, CodigoANP, UFComb, Cest, PerFCPUF, " & _
                    "PerICMSUF) VALUES (" & intCodiProd & ",'" & Me.txtEXTIPI.Text & "','" & Me.txtGenero.Text & "'," & _
                    "'" & strCst & "','" & strOrig & "','" & strModBC & "','" & Me.txtNfeICMS.Text.Trim & "'," & _
                    "'" & Me.txtRedBC.Text.Trim & "','" & strModBCST & "','" & Me.txtRedBCST.Text.Trim & "'," & _
                    "'" & Me.txtMVAST.Text.Trim & "','" & strCfopDoProduto & "','" & Me.txtICMSST.Text.Trim & "'," & _
                    "'" & Me.txtNfeNCM.Text.Trim & "','SIMPLES NACIONAL" & strTipoFiscal & "' ,'" & Me.txtCalcCred.Text.Trim & "'," & _
                    "'" & Me.cboCodigoANP.Text & "','" & Me.cboUF.Text & "','" & Me.txtCest.Text & "'," & _
                    "'" & Me.txtPerFCPUF.Text & "','" & Me.txtPerICMSUF.Text & "')")

                    Inserir("INSERT INTO Tributos (CodProd, CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, " & _
                    "PerCOFINS, Regime) Values (" & intCodiProd & ",'" & strCstIPI & "','" & Me.txtAliquotaIPI.Text & "'," & _
                    "'" & Me.txtCodEnq.Text & "','" & strCstPIS & "','" & Me.txtAliquotaPIS.Text & "'," & _
                    "'" & strCstCOFINS & "','" & Me.txtAliquotaCOFINS.Text & "','SIMPLES NACIONAL" & strTipoFiscal & "')")

                    Inserir("INSERT INTO Nfe (CodProd, EXTIPI, Genero, CST, Origem, ModBC, ICMS, RedBC, ModBCST, " & _
                    "RedBCST, MVaST, CFOP, ICMSST, NCM, Regime, CalculoCred, CodigoANP, UFComb, Cest, PerFCPUF, " & _
                    "PerICMSUF) VALUES (" & intCodiProd & ",'" & Me.txtEXTIPI.Text & "','" & Me.txtGenero.Text & "'," & _
                    "'" & strCstTN & "','" & strOrigTN & "','" & strModBCTN & "','" & Me.txtIcmsTN.Text.Trim & "'," & _
                    "'" & Me.txtRedBcTN.Text.Trim & "','" & strModBCSTTN & "','" & Me.txtRedBcStTN.Text.Trim & "'," & _
                    "'" & Me.txtMvaStTN.Text.Trim & "','" & strCfopDoProduto & "','" & Me.txtIcmsStTN.Text.Trim & "'," & _
                    "'" & Me.txtNfeNCM.Text.Trim & "','TRIBUTAÇÃO NORMAL" & strTipoFiscal & "','" & Me.txtCalcCredTN.Text.Trim & "'," & _
                    "'" & Me.cboCodigoANP.Text & "','" & Me.cboUF.Text & "','" & Me.txtCest.Text & "'," & _
                    "'" & Me.txtPercFcpTN.Text & "','" & Me.txtPercIcmsTN.Text & "')")

                    Inserir("INSERT INTO Tributos (CodProd, CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, " & _
                    "PerCOFINS, Regime) Values (" & intCodiProd & ",'" & strCstIPITN & "','" & Me.txtAliquotaIpiTN.Text & "'," & _
                    "'" & Me.txtCodEnqTN.Text & "','" & strCstPISTN & "','" & Me.txtAliquotaPisTN.Text & "'," & _
                    "'" & strCstCOFINSTN & "','" & Me.txtAliquotaCofinsTN.Text & "','TRIBUTAÇÃO NORMAL" & strTipoFiscal & "')")
                End If

                If Me.Tag = "ENTRADANF" Then
                    CodigoDoProduto = intCodiProd
                    bolSalvo = True
                    Limpar()
                    Me.Close()
                    Exit Sub
                End If
            Else
                MsgBox("Os dados não foram salvos!", MsgBoxStyle.Information)
                Exit Sub
            End If

        Else
            If Me.chkTribPadrao.Checked = True Then
                If VerificarTribPadrao(intCodPro) = False Then Exit Sub
            End If

            If Me.chkDuplicar.Checked = False Then
                If Atualizar("UPDATE Produto SET CodigoInterno ='" & Me.txtCodInt.Text.Trim & "', " & _
                            "Nome='" & Me.txtNome.Text.Trim & "', UnidadeMedida='" & Me.cboUniMed.Text.Trim & "', " & _
                            "ValorCusto=" & Num(Me.txtValCus.Text.Trim) & ", Valor=" & Num(Me.txtVal.Text.Trim) & ", " & _
                            "Locacao='" & Me.txtLoc.Text.Trim & "', Porcentagens='" & Me.txtPor1.Text.Trim & "', " & _
                            "Fabricante = '" & Me.cboFabricante.Text.Trim & "', Grupo = '" & Me.cboGrp.Text.Trim & "', " & _
                            "Obs = '" & Me.txtObs.Text.Trim & "', Data ='" & Date.Today & "', " & _
                            "CodigoBarra ='" & Me.txtCodBarra.Text.Trim & "', NivelComboCodCF ='" & Me.cboCodCF.SelectedIndex & "', " & _
                            "Desconto =" & Num(Me.txtDesconto.Text.Trim) & ", Setor ='" & Me.cboSet.Text.Trim & "', " & _
                            "Tipo ='" & Me.cboTipo.Text.Trim & "', " & _
                            "Validade ='" & dtVal & "', Comissao = " & Num(Me.txtComissao.Text) & ", " & _
                            "Locacao2 = '" & Me.txtLoc2.Text & "', Familia = '" & Me.cboFamilia.Text & "', " & _
                            "CodProdFor = '" & Me.txtCodProdFor.Text & "', TributacaoPadrao = '" & Me.chkTribPadrao.Checked & "', " & _
                            "AlterarPreco='" & Me.CheckEdit1.Checked & "', CodigoFabricante='" & Me.txtCodFab.Text & "', " & _
                            "Garantia='" & Me.txtGarantia.Text & "', KM='" & Me.txtRevKM.Text & "', " & _
                            "Peso=" & Num(Me.txtPeso.Text.Trim) & ", PesoBruto = " & Num(Me.txtPesoBruto.Text) & ", QtdEmb=" & Num(Me.NanoCampo1.Text) & " where Codigo = " & intCodPro) = True Then

                    If Me.txtNome.Text.Trim <> strNome.Trim Then
                        Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                        "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strNome & "'," & _
                        "'" & Me.txtNome.Text.Trim & " Cód. Prod.: " & Me.txtCodInt.Text & "','NOME','PRODUTO','ALTERAÇÃO'," & CodConfig & ")")

                        If Me.cboTipo.Text = "RECEITA" Then

                            Atualizar("UPDATE Receita SET Nome = '" & Me.txtNome.Text.Trim & "' where " & _
                            "CodigoInterno = '" & strCodInterno & "'")

                        End If
                    End If

                    If Me.txtCodInt.Text.Trim <> strCodInterno.Trim Then

                        Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                        "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strCodInterno & "'," & _
                        "'Cód. Prod.: " & Me.txtCodInt.Text.Trim & "','CÓDIGO INTERNO','PRODUTO','ALTERAÇÃO'," & CodConfig & ")")

                        If Me.cboTipo.Text = "RECEITA" Then

                            Atualizar("UPDATE Receita SET CodigoInterno = '" & Me.txtCodInt.Text.Trim & "' where " & _
                            "CodigoInterno = '" & strCodInterno & "'")

                            Atualizar("UPDATE ItensReceita SET CodigoInterno = '" & Me.txtCodInt.Text.Trim & "' where " & _
                            "CodigoInterno = '" & strCodInterno & "'")

                        End If

                    End If

                    If Me.txtCodBarra.Text.Trim <> strCodBarra.Trim Then
                        Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                        "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strCodBarra & "'," & _
                        "'" & Me.txtCodBarra.Text.Trim & " Cód. Prod.: " & Me.txtCodInt.Text & "','CÓDIGO BARRA','PRODUTO','ALTERAÇÃO'," & CodConfig & ")")
                    End If

                    Dim dblValor1 As Double = Me.txtVal.Text.Trim
                    Dim dblValor2 As Double = strValorVenda.Trim

                    If dblValor1 <> dblValor2 Then
                        Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                        "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & "," & _
                        "'" & strValorVenda & " - " & Me.txtNome.Text.Trim & "'," & _
                        "'" & Me.txtVal.Text.Trim & " Cód. Prod.: " & Me.txtCodInt.Text.Trim & "','VALOR VENDA','PRODUTO'," & _
                        "'ALTERAÇÃO'," & CodConfig & ")")
                    End If

                    If Me.txtValCus.Text.Trim <> strValorCusto.Trim Then
                        Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                        "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & "," & _
                        "'" & strValorCusto & " - " & Me.txtNome.Text.Trim & "'," & _
                        "'" & Me.txtValCus.Text.Trim & " Cód. Prod.:" & Me.txtCodInt.Text.Trim & "','VALOR CUSTO','PRODUTO'," & _
                        "'ALTERAÇÃO'," & CodConfig & ")")

                        Dim dtPreco As DataTable = CarregarDataTable("SELECT Codigo, Valor, Porcentagem FROM TabelaPreco where CodProd = " & intCodPro)
                        Dim A As Integer
                        For A = 0 To dtPreco.Rows.Count - 1
                            Dim strCodPreco As String = dtPreco.Rows.Item(A).Item("Codigo").ToString
                            Dim strValPreco As String = dtPreco.Rows.Item(A).Item("Valor").ToString
                            Dim strPorPreco As String = dtPreco.Rows.Item(A).Item("Porcentagem").ToString
                            Dim dblValVenda, dblValCusto, dblLucro, dblMargem As Double

                            If ManterPorcProd = False Then

                                dblValVenda = strValPreco
                                dblValCusto = Me.txtValCus.Text.Trim

                                dblLucro = dblValVenda - dblValCusto

                                dblMargem = (dblLucro * 100) / dblValCusto
                                Dim str As String = dblMargem

                                If str <> "+Infinito" And str <> "NaN (Não é um número)" Then
                                    If TresCasasDecimais = True Then
                                        strPorPreco = dblMargem.ToString("0.000")
                                    Else
                                        strPorPreco = dblMargem.ToString("0.00")
                                    End If

                                End If

                                Atualizar("UPDATE TabelaPreco set Porcentagem = " & Num(strPorPreco) & " where Codigo = " & strCodPreco)


                            Else

                                Dim dblPor As Double = strPorPreco

                                dblValCusto = Me.txtValCus.Text

                                Dim dblResul As Double = (dblValCusto * dblPor) / 100

                                dblResul = dblValCusto + dblResul

                                If TresCasasDecimais = True Then
                                    strValPreco = dblResul.ToString("0.000")
                                Else
                                    strValPreco = dblResul.ToString("0.00")
                                End If

                                Atualizar("UPDATE TabelaPreco set Valor = " & Num(strValPreco) & " where Codigo = " & strCodPreco)


                            End If
                        Next

                    End If

                    If Me.chkInativar.Checked = True Then
                        Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                        "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Produto Ativo'," & _
                        "'" & Me.txtNome.Text.Trim & " Cód. Prod.: " & Me.txtCodInt.Text & " - INATIVO','INATIVO','PRODUTO','ALTERAÇÃO'," & CodConfig & ")")

                        Atualizar("UPDATE Produto SET Inativo = 'True'  where Codigo = " & intCodPro)

                    End If
                    MsgBox("Produto " & Me.txtNome.Text.Trim & " alterado com sucesso!", MsgBoxStyle.Information)

                    Atualizar("UPDATE Receita SET ValorVenda = " & Num(Me.txtVal.Text.Trim) & ", " & _
                    "Nome = '" & Me.txtNome.Text.Trim & "' where CodigoInterno = '" & Me.txtCodInt.Text.Trim & "'")


                    Dim dtLoc As DataTable = CarregarDataTable("Select Locacao from Locacao where CodProd = " & intCodPro & " and CodConfig = " & CodConfig)
                    If dtLoc.Rows.Count = 0 Then
                        Inserir("INSERT INTO Locacao (CodProd, Locacao, CodConfig) Values(" & intCodPro & ",'" & Me.txtLoc.Text.Trim & "'," & CodConfig & ")")
                    Else
                        Atualizar("Update Locacao set Locacao = '" & Me.txtLoc.Text.Trim & "' where CodProd = '" & intCodPro & "' and CodConfig = " & CodConfig)
                    End If



                    Dim I As Integer
                    For I = 0 To grd2.RowCount - 1
                        Dim strCodQtd As String = Me.grd2.GetRowCellDisplayText(I, Me.colCodigoQtd)
                        Dim strValCusto As String = Num(Me.grd2.GetRowCellDisplayText(I, Me.colValorCustoQtd))
                        Dim dblQt As Double = 0
                        If Me.grd2.GetRowCellDisplayText(I, Me.colQtd) <> "" Then
                            dblQt = Me.grd2.GetRowCellDisplayText(I, Me.colQtd)
                        End If

                        Dim dblQtMin As Double = 0
                        If Me.grd2.GetRowCellDisplayText(I, Me.colQtdMinima) <> "" Then
                            dblQtMin = Me.grd2.GetRowCellDisplayText(I, Me.colQtdMinima)
                        End If

                        Dim dblQtMax As Double = 0
                        If Me.grd2.GetRowCellDisplayText(I, Me.colQtdMaxima) <> "" Then
                            dblQtMax = Me.grd2.GetRowCellDisplayText(I, Me.colQtdMaxima)
                        End If

                        Dim dblQtSemAlterar As Double

                        If Me.grd2.GetRowCellDisplayText(I, Me.colQtdSemAlterar).Trim <> "" Then
                            dblQtSemAlterar = Me.grd2.GetRowCellDisplayText(I, Me.colQtdSemAlterar).Trim
                        End If

                        Me.grd2.GetRowCellDisplayText(I, Me.colQtdSemAlterar)
                        Dim intCodiLoja As Integer = Me.grd2.GetRowCellDisplayText(I, Me.colCodConfig)
                        Dim intFalta As Integer = 0

                        If dblQtMin >= dblQt Then
                            intFalta = 1
                        End If

                        If dblQtSemAlterar <> dblQt Then
                            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                            "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & "," & _
                            "'Produto: " & Me.txtCodInt.Text.Trim & ", Cód. Loja: " & intCodiLoja & ", " & _
                            "Qtd: " & dblQtSemAlterar & "','" & dblQt & "','QTD','QTDE','ALTERAÇÃO'," & CodConfig & ")")
                        End If

                        Atualizar("UPDATE Qtde SET DataFim = '01/01/1900' where CodProd = " & intCodPro & " and " & _
                        "CodConfig = " & Me.grd2.GetRowCellDisplayText(I, Me.colCodConfig))




                        If strCodQtd.Trim <> "INSERIR" Then
                            Atualizar("UPDATE Qtde SET Tamanho = '" & Me.grd2.GetRowCellDisplayText(I, Me.colTamanho).Trim & "', " & _
                            "QtdMinima = " & Num(dblQtMin) & ", Qtd = " & Num(dblQt) & ", EmFalta = '" & intFalta & "', " & _
                            "ValorCusto =" & Num(strValCusto) & ", CodConfig =" & Me.grd2.GetRowCellDisplayText(I, Me.colCodConfig) & ", " & _
                            "Acabou ='False', QtdMaxima = " & Num(dblQtMax) & " where Codigo = " & Me.grd2.GetRowCellDisplayText(I, Me.colCodigoQtd))
                        Else
                            Inserir("INSERT INTO Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, ValorCusto, EmFalta, " & _
                            "CodConfig, Acabou, DataFim, QtdMaxima) VALUES (" & intCodPro & "," & _
                            "'" & grd2.GetRowCellDisplayText(I, Me.colTamanho).Trim & "'," & _
                            "" & Num(grd2.GetRowCellDisplayText(I, Me.colQtdMinima).Trim) & "," & _
                            "" & Num(grd2.GetRowCellDisplayText(I, Me.colQtd).Trim) & "," & _
                            "'" & Me.grd2.GetRowCellDisplayText(I, Me.colLote).Trim & "'," & Num(strValCusto) & "," & _
                            "'" & Me.grd2.GetRowCellDisplayText(I, Me.colEmFalta) & "'," & _
                            "" & Me.grd2.GetRowCellDisplayText(I, Me.colCodConfig) & ",'False','01/01/1900'," & Num(dblQtMax) & ")")
                        End If

                        If EstoqueSomado = True Then
                            SalvarQtde(False, intCodPro, Me.grd2.GetRowCellDisplayText(I, Me.colCodConfig), dblQt)
                        End If
                    Next

                    Dim dt As DataTable = CarregarDataTable("Select ICMS from ImpostoProduto where CodProd = " & intCodPro)
                    If dt.Rows.Count = 0 Then
                        Inserir("Insert into ImpostoProduto (CodProd, ICMS, IPI, Tributacao, Cst, OrigemIcms, IPPT, " & _
                        "Pesavel, TipoFIA, NCM) Values(" & intCodPro & "," & Num(Me.txtIcms.Text.Trim) & "," & _
                        "" & Num(Me.txtIPI.Text.Trim) & ",'" & Me.cboTrib.Text.Trim & "','" & Me.cboCst.Text.Trim & "'," & _
                        "'" & Me.cboOriIcm.Text.Trim & "','" & Me.cboIPPT.Text.Trim & "','" & Me.cboPesa.Text.Trim & "'," & _
                        "'" & Me.cboFIA.Text.Trim & "','" & Me.txtNCMImpProd.Text & "')")
                    Else
                        Atualizar("Update ImpostoProduto set ICMS =" & Num(Me.txtIcms.Text.Trim) & ", " & _
                        "IPI =" & Num(Me.txtIPI.Text.Trim) & ", Tributacao ='" & Me.cboTrib.Text.Trim & "', " & _
                        "Cst ='" & Me.cboCst.Text.Trim & "', OrigemIcms ='" & Me.cboOriIcm.Text.Trim & "', " & _
                        "IPPT ='" & Me.cboIPPT.Text.Trim & "', Pesavel ='" & Me.cboPesa.Text.Trim & "', " & _
                        "TipoFIA ='" & Me.cboFIA.Text.Trim & "', NCM = '" & Me.txtNCMImpProd.Text & "' where CodProd = " & intCodPro)
                    End If


                    Dim T As Integer
                    Dim intCodTabela, intCodPreco As Integer
                    Dim srtValor, strPorcent As String

                    If frmTabelaPreco.tbPreco.Rows.Count > 0 Then
                        For T = 0 To frmTabelaPreco.tbPreco.Rows.Count - 1
                            If frmTabelaPreco.tbPreco.Rows.Item(T).Item("CodPreco").ToString() <> "" Then
                                intCodPreco = frmTabelaPreco.tbPreco.Rows.Item(T).Item("CodPreco").ToString()
                            Else
                                intCodPreco = 0
                            End If

                            intCodTabela = frmTabelaPreco.tbPreco.Rows.Item(T).Item("CodTabela").ToString()
                            srtValor = frmTabelaPreco.tbPreco.Rows.Item(T).Item("Valor").ToString()
                            strPorcent = frmTabelaPreco.tbPreco.Rows.Item(T).Item("Porcent").ToString()

                            Dim dtTab As DataTable = CarregarDataTable("SELECT Codigo FROM TabelaPreco where CodProd = " & intCodPro & " and CodTabela = " & intCodTabela)

                            If dtTab.Rows.Count = 0 Then
                                Inserir("INSERT INTO TabelaPreco (CodProd, CodTabela, Valor, Porcentagem) VALUES (" & _
                                "" & intCodPro & "," & intCodTabela & "," & Num(srtValor) & "," & Num(strPorcent) & ")")

                            Else
                                intCodPreco = dtTab.Rows.Item(0).Item("Codigo").ToString()
                                Atualizar("UPDATE TabelaPreco SET CodTabela = " & intCodTabela & ", " & _
                                "Valor =" & Num(srtValor) & ", Porcentagem =" & Num(strPorcent) & " Where Codigo = " & intCodPreco)

                            End If
                        Next
                    End If

                    If bolExcluir = True Then
                        Dim vetExcluir As Array
                        Dim V As Integer
                        vetExcluir = Split(strExcluir, "|")
                        For V = 0 To vetExcluir.Length - 1
                            If vetExcluir(V) <> "" And vetExcluir(V) <> "INSERIR" Then
                                Excluir("DELETE FROM Qtde where Codigo = " & vetExcluir(V))
                            End If
                        Next
                    End If

                    If EmiteNFE = True Or AbaSatFiscal = True Or NANONFCe = True Then

                        Dim strTipoFiscal As String = ""

                        If TipoFiscal = "AMBOS" Then
                            Select Case Me.cboTipoFiscal.Text
                                Case "NFE"
                                    strTipoFiscal = " NFE"

                                Case "SAT"
                                    strTipoFiscal = " SAT"
                            End Select
                        End If

                        Dim dtTrib As DataTable = CarregarDataTable("SELECT Codigo FROM Tributos where CodProd = " & intCodPro & " and Regime = 'SIMPLES NACIONAL" & strTipoFiscal & "'")


                        If dtTrib.Rows.Count = 0 Then
                            Inserir("INSERT INTO Tributos (CodProd, CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, " & _
                            "PerCOFINS, Regime) Values (" & intCodPro & ",'" & strCstIPI & "','" & Me.txtAliquotaIPI.Text & "'," & _
                            "'" & Me.txtCodEnq.Text & "','" & strCstPIS & "','" & Me.txtAliquotaPIS.Text & "'," & _
                            "'" & strCstCOFINS & "','" & Me.txtAliquotaCOFINS.Text & "','SIMPLES NACIONAL" & strTipoFiscal & "')")
                        Else
                            Atualizar("UPDATE Tributos SET CSTIPI = '" & strCstIPI & "', " & _
                            "PerIPI = '" & Me.txtAliquotaIPI.Text & "', CodEnq = '" & Me.txtCodEnq.Text & "', " & _
                            "CSTPIS = '" & strCstPIS & "', PerPIS = '" & Me.txtAliquotaPIS.Text & "', " & _
                            "CSTCOFINS = '" & strCstCOFINS & "', PerCOFINS = '" & Me.txtAliquotaCOFINS.Text & "', Regime = 'SIMPLES NACIONAL" & strTipoFiscal & "' " & _
                            "where CodProd = " & intCodPro & " and Regime = 'SIMPLES NACIONAL" & strTipoFiscal & "'")
                        End If

                        Select Case Me.cboTipoFiscal.Text
                            Case "NFE", "SAT"
                                Excluir("DELETE FROM Tributos where CodProd = " & intCodPro & " and Regime = 'SIMPLES NACIONAL'")
                            Case "AMBOS"
                                Excluir("DELETE FROM Tributos where CodProd = " & intCodPro & " and Regime = 'SIMPLES NACIONAL NFE' or CodProd = " & intCodPro & " and Regime = 'SIMPLES NACIONAL SAT'")
                        End Select

                        Dim dtNfe As DataTable = CarregarDataTable("SELECT Codigo FROM Nfe where CodProd = " & intCodPro & " and Regime = 'SIMPLES NACIONAL" & strTipoFiscal & "'")
                        If dtNfe.Rows.Count = 0 Then
                            Inserir("INSERT INTO Nfe (CodProd, EXTIPI, Genero, CST, Origem, ModBC, ICMS, RedBC, " & _
                            "ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, Regime, CalculoCred, CodigoANP, UFComb, " & _
                            "Cest, PerFCPUF, PerICMSUF) VALUES (" & intCodPro & ",'" & Me.txtEXTIPI.Text & "'," & _
                            "'" & Me.txtGenero.Text & "','" & strCst & "','" & strOrig & "','" & strModBC & "'," & _
                            "'" & Me.txtNfeICMS.Text.Trim & "','" & Me.txtRedBC.Text.Trim & "','" & strModBCST & "'," & _
                            "'" & Me.txtRedBCST.Text.Trim & "','" & Me.txtMVAST.Text.Trim & "','" & strCfopDoProduto & "'," & _
                            "'" & Me.txtICMSST.Text.Trim & "','" & Me.txtNfeNCM.Text.Trim & "','SIMPLES NACIONAL" & strTipoFiscal & "'," & _
                            "'" & Me.txtCalcCred.Text.Trim & "','" & Me.cboCodigoANP.Text & "','" & Me.cboUF.Text & "'," & _
                            "'" & Me.txtCest.Text & "','" & Me.txtPerFCPUF.Text & "','" & Me.txtPerICMSUF.Text & "')")
                        Else
                            Atualizar("UPDATE Nfe SET EXTIPI = '" & Me.txtEXTIPI.Text & "', " & _
                            "Genero = '" & Me.txtGenero.Text & "',CST = '" & strCst & "', Origem = '" & strOrig & "', " & _
                            "ModBC = '" & strModBC & "', ICMS = '" & Me.txtNfeICMS.Text.Trim & "', " & _
                            "RedBC = '" & Me.txtRedBC.Text.Trim & "', ModBCST = '" & strModBCST & "', " & _
                            "RedBCST = '" & Me.txtRedBCST.Text.Trim & "', MVaST = '" & Me.txtMVAST.Text.Trim & "', " & _
                            "CFOP = '" & strCfopDoProduto & "', ICMSST = '" & Me.txtICMSST.Text.Trim & "', " & _
                            "NCM = '" & Me.txtNfeNCM.Text.Trim & "', Regime = 'SIMPLES NACIONAL" & strTipoFiscal & "', " & _
                            "CalculoCred = '" & Me.txtCalcCred.Text.Trim & "', CodigoANP = '" & Me.cboCodigoANP.Text & "', " & _
                            "UFComb = '" & Me.cboUF.Text & "', Cest = '" & Me.txtCest.Text & "', " & _
                            "PerFCPUF = '" & Me.txtPerFCPUF.Text & "', PerICMSUF = '" & Me.txtPerICMSUF.Text & "' " & _
                            "where CodProd = " & intCodPro & " and Regime = 'SIMPLES NACIONAL" & strTipoFiscal & "'")
                        End If

                        Select Case Me.cboTipoFiscal.Text
                            Case "NFE", "SAT"
                                Excluir("DELETE FROM Nfe where CodProd = " & intCodPro & " and Regime = 'SIMPLES NACIONAL'")
                            Case "AMBOS"
                                Excluir("DELETE FROM Nfe where CodProd = " & intCodPro & " and Regime = 'SIMPLES NACIONAL NFE' or CodProd = " & intCodPro & " and Regime = 'SIMPLES NACIONAL SAT'")
                        End Select
                        dtTrib = CarregarDataTable("SELECT Codigo FROM Tributos where CodProd = " & intCodPro & " and Regime = 'TRIBUTAÇÃO NORMAL" & strTipoFiscal & "'")
                        If dtTrib.Rows.Count = 0 Then
                            Inserir("INSERT INTO Tributos (CodProd, CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, " & _
                            "PerCOFINS, Regime) Values (" & intCodPro & ",'" & strCstIPITN & "','" & Me.txtAliquotaIpiTN.Text & "'," & _
                            "'" & Me.txtCodEnqTN.Text & "','" & strCstPISTN & "','" & Me.txtAliquotaPisTN.Text & "'," & _
                            "'" & strCstCOFINSTN & "','" & Me.txtAliquotaCofinsTN.Text & "','TRIBUTAÇÃO NORMAL" & strTipoFiscal & "')")
                        Else
                            Atualizar("UPDATE Tributos SET CSTIPI = '" & strCstIPITN & "', " & _
                            "PerIPI = '" & Me.txtAliquotaIpiTN.Text & "', CodEnq = '" & Me.txtCodEnqTN.Text & "', " & _
                            "CSTPIS = '" & strCstPISTN & "', PerPIS = '" & Me.txtAliquotaPisTN.Text & "', " & _
                            "CSTCOFINS = '" & strCstCOFINSTN & "', PerCOFINS = '" & Me.txtAliquotaCofinsTN.Text & "', Regime = 'TRIBUTAÇÃO NORMAL" & strTipoFiscal & "' " & _
                            "where CodProd = " & intCodPro & " and Regime = 'TRIBUTAÇÃO NORMAL" & strTipoFiscal & "'")

                        End If
                        Select Case Me.cboTipoFiscal.Text
                            Case "NFE", "SAT"
                                Excluir("DELETE FROM Tributos where CodProd = " & intCodPro & " and Regime = 'TRIBUTAÇÃO NORMAL'")
                            Case "AMBOS"
                                Excluir("DELETE FROM Tributos where CodProd = " & intCodPro & " and Regime = 'TRIBUTAÇÃO NORMAL NFE' or CodProd = " & intCodPro & " and Regime = 'TRIBUTAÇÃO NORMAL SAT'")
                        End Select

                        dtNfe = CarregarDataTable("SELECT Codigo FROM Nfe where CodProd = " & intCodPro & " and Regime = 'TRIBUTAÇÃO NORMAL" & strTipoFiscal & "'")
                        If dtNfe.Rows.Count = 0 Then
                            Inserir("INSERT INTO Nfe (CodProd, EXTIPI, Genero, CST, Origem, ModBC, ICMS, RedBC, " & _
                            "ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, Regime, CalculoCred, CodigoANP, UFComb, " & _
                            "Cest, PerFCPUF, PerICMSUF) VALUES (" & intCodPro & ",'" & Me.txtEXTIPI.Text & "'," & _
                            "'" & Me.txtGenero.Text & "','" & strCstTN & "','" & strOrigTN & "','" & strModBCTN & "'," & _
                            "'" & Me.txtIcmsTN.Text.Trim & "','" & Me.txtRedBcTN.Text.Trim & "','" & strModBCSTTN & "'," & _
                            "'" & Me.txtRedBcStTN.Text.Trim & "','" & Me.txtMvaStTN.Text.Trim & "','" & strCfopDoProduto & "'," & _
                            "'" & Me.txtIcmsStTN.Text.Trim & "','" & Me.txtNfeNCM.Text.Trim & "','TRIBUTAÇÃO NORMAL" & strTipoFiscal & "'," & _
                            "'" & Me.txtCalcCredTN.Text.Trim & "','" & Me.cboCodigoANP.Text & "','" & Me.cboUF.Text & "'," & _
                            "'" & Me.txtCest.Text & "','" & Me.txtPercFcpTN.Text & "','" & Me.txtPercIcmsTN.Text & "')")
                        Else
                            Atualizar("UPDATE Nfe SET EXTIPI = '" & Me.txtEXTIPI.Text & "', " & _
                            "Genero = '" & Me.txtGenero.Text & "',CST = '" & strCstTN & "', Origem = '" & strOrigTN & "', " & _
                            "ModBC = '" & strModBCTN & "', ICMS = '" & Me.txtIcmsTN.Text.Trim & "', " & _
                            "RedBC = '" & Me.txtRedBcTN.Text.Trim & "', ModBCST = '" & strModBCSTTN & "', " & _
                            "RedBCST = '" & Me.txtRedBcStTN.Text.Trim & "', MVaST = '" & Me.txtMvaStTN.Text.Trim & "', " & _
                            "CFOP = '" & strCfopDoProduto & "', ICMSST = '" & Me.txtIcmsStTN.Text.Trim & "', " & _
                            "NCM = '" & Me.txtNfeNCM.Text.Trim & "', Regime = 'TRIBUTAÇÃO NORMAL" & strTipoFiscal & "', " & _
                            "CalculoCred = '" & Me.txtCalcCredTN.Text.Trim & "', CodigoANP = '" & Me.cboCodigoANP.Text & "', " & _
                            "UFComb = '" & Me.cboUF.Text & "', Cest = '" & Me.txtCest.Text & "', " & _
                            "PerFCPUF = '" & Me.txtPercFcpTN.Text & "', PerICMSUF = '" & Me.txtPercIcmsTN.Text & "' " & _
                            "where CodProd = " & intCodPro & " and Regime = 'TRIBUTAÇÃO NORMAL" & strTipoFiscal & "'")
                        End If

                        Select Case Me.cboTipoFiscal.Text
                            Case "NFE", "SAT"
                                Excluir("DELETE FROM Nfe where CodProd = " & intCodPro & " and Regime = 'TRIBUTAÇÃO NORMAL'")
                            Case "AMBOS"
                                Excluir("DELETE FROM Nfe where CodProd = " & intCodPro & " and Regime = 'TRIBUTAÇÃO NORMAL NFE' or CodProd = " & intCodPro & " and Regime = 'TRIBUTAÇÃO NORMAL SAT'")
                        End Select
                    End If

                Else
                    MsgBox("Os dados não foram salvos!", MsgBoxStyle.Information)
                    Exit Sub
                End If

            Else

                ''''''''''*********DUPLICAR PRODUTO***********''''''''
                ''''''''''*********DUPLICAR PRODUTO***********''''''''
                ''''''''''*********DUPLICAR PRODUTO***********''''''''
                Dim strCod As String = Me.txtCodInt.Text.Trim.Replace("'", "")
                GerCodigo()

                'If Me.txtCodInt.Text.Trim = "" Then
                '    GerCodigo()
                'End If

                If Me.txtCodInt.Text = "" Then
                    Me.txtCodInt.Text = "0" & intCodPro
                Else
                    Me.txtCodInt.Text = Me.txtCodInt.Text

                    'Dim strMaxCod As Integer
                    'Dim dtCod As DataTable = CarregarDataTable("SELECT Max(Codigo) as Codigo FROM Produto")
                    'If dtCod.Rows.Count > 0 Then
                    '    strMaxCod = 1 + CInt(dtCod.Rows.Item(0).Item("Codigo").ToString)
                    'End If

                    'Dim dtP As DataTable = CarregarDataTable("SELECT Codigo FROM Produto where CodigoInterno = '" & strCod & "' or CodigoBarra = '" & strCod & "'")
                    'If dtP.Rows.Count > 0 Then
                    'Me.txtCodInt.Text = Me.txtCodInt.Text '& "000" & CodConfig strCod
                    'End If
                End If

                Dim strCodBarra As String = Me.txtCodBarra.Text.Trim.Replace("'", "")
                Dim dtBarra As DataTable = CarregarDataTable("SELECT Codigo FROM Produto where CodigoInterno = '" & strCod & "' or CodigoBarra = '" & strCodBarra & "'")
                If dtBarra.Rows.Count > 0 Then
                    strCodBarra = ""
                    Me.txtCodBarra.ResetText()
                End If


                If Inserir("INSERT INTO Produto (Nome, UnidadeMedida, Valor, ValorCusto, Locacao, CodigoInterno, " & _
                "Porcentagens, Fabricante, Grupo, Obs, Data, CodigoBarra, NivelComboCodCF, Desconto, Setor, Tipo, " & _
                "Inativo, Validade, Comissao, Locacao2, Familia, TributacaoPadrao, AlterarPreco, Garantia, " & _
                "KM) VALUES ('" & Me.txtNome.Text.Trim.Replace("'", "") & "','" & Me.cboUniMed.Text.Trim & "'," & _
                "" & Num(Me.txtVal.Text.Trim) & "," & Num(Me.txtValCus.Text.Trim) & ",'" & Me.txtLoc.Text.Trim & "'," & _
                "'" & Me.txtCodInt.Text.Trim & "','" & Me.txtPor1.Text.Trim & "','" & Me.cboFabricante.Text.Trim & "'," & _
                "'" & Me.cboGrp.Text.Trim & "','" & Me.txtObs.Text.Trim & "','" & Date.Today & "','" & strCodBarra & "'," & _
                "'" & Me.cboCodCF.SelectedIndex & "'," & Num(Me.txtDesconto.Text.Trim) & ",'" & Me.cboSet.Text.Trim & "'," & _
                "'" & Me.cboTipo.Text & "','" & Me.chkInativar.Checked & "','" & dtVal & "'," & Num(Me.txtComissao.Text) & "," & _
                "'" & Me.txtLoc2.Text & "','" & Me.cboFamilia.Text & "'," & _
                "'" & Me.chkTribPadrao.Checked & "','" & Me.CheckEdit1.Checked & "','" & Me.txtGarantia.Text & "'," & _
                "'" & Me.txtRevKM.Text & "')") = True Then

                    MsgBox("Produto " & txtNome.Text.Trim & " cadastrado com sucesso!", MsgBoxStyle.Information)

                    Dim intCodiProd As Integer = Val(GerarCodigo("Produto", "Codigo", 0)) - 1
                    intCodPro = intCodiProd

                    Dim dtProd As DataTable = CarregarDataTable("SELECT Codigo FROM Produto where " & _
                    "Nome = '" & Me.txtNome.Text.Trim.Replace("'", "") & "' and CodigoInterno = '" & Me.txtCodInt.Text.Trim & "' " & _
                    "and UnidadeMedida = '" & Me.cboUniMed.Text.Trim & "' and Grupo = '" & Me.cboGrp.Text.Trim & "' " & _
                    "order by Codigo Desc")

                    If dtProd.Rows.Count > 0 Then
                        intCodiProd = dtProd.Rows.Item(0).Item("Codigo").ToString
                        intCodPro = intCodiProd
                    End If


                    Inserir("Insert into ImpostoProduto (CodProd, ICMS, IPI, Tributacao, Cst, OrigemIcms, IPPT, Pesavel, " & _
                    "TipoFIA, NCM) Values(" & intCodiProd & "," & Num(Me.txtIcms.Text.Trim) & "," & _
                    "" & Num(Me.txtIPI.Text.Trim) & ",'" & Me.cboTrib.Text.Trim & "','" & Me.cboCst.Text.Trim & "'," & _
                    "'" & Me.cboOriIcm.Text.Trim & "','" & Me.cboIPPT.Text.Trim & "','" & Me.cboPesa.Text.Trim & "'," & _
                    "'" & Me.cboFIA.Text.Trim & "','" & Me.txtNCMImpProd.Text & "')")

                    Dim T As Integer
                    Dim intCodTabela, intCodPreco As Integer
                    Dim srtValor, strPorcent As String

                    If frmTabelaPreco.tbPreco.Rows.Count > 0 Then
                        For T = 0 To frmTabelaPreco.tbPreco.Rows.Count - 1
                            If frmTabelaPreco.tbPreco.Rows.Item(T).Item("CodPreco").ToString() <> "" Then
                                intCodPreco = frmTabelaPreco.tbPreco.Rows.Item(T).Item("CodPreco").ToString()
                            Else
                                intCodPreco = 0
                            End If

                            intCodTabela = frmTabelaPreco.tbPreco.Rows.Item(T).Item("CodTabela").ToString()
                            srtValor = frmTabelaPreco.tbPreco.Rows.Item(T).Item("Valor").ToString()
                            strPorcent = frmTabelaPreco.tbPreco.Rows.Item(T).Item("Porcent").ToString()

                            If intCodPreco = 0 Then

                                Inserir("INSERT INTO TabelaPreco (CodProd, CodTabela, Valor, Porcentagem) VALUES (" & _
                                "" & intCodiProd & "," & intCodTabela & "," & Num(srtValor) & "," & Num(strPorcent) & ")")

                            Else
                                Atualizar("UPDATE TabelaPreco SET CodTabela = " & intCodTabela & ", " & _
                                "Valor =" & Num(srtValor) & ", Porcentagem =" & Num(strPorcent) & " Where Codigo = " & intCodPreco)

                            End If
                        Next
                    End If

                    Dim I As Integer
                    Dim dblQtdLog As Double
                    If EstoqueSomado = True Then
                        For I = 0 To grd2.RowCount - 1
                            Dim strValCusto As String = Num(Me.grd2.GetRowCellDisplayText(I, Me.colValorCustoQtd))
                            Dim dblQt As Double = 0
                            If Me.grd2.GetRowCellDisplayText(I, Me.colQtd) <> "" Then
                                dblQt = Me.grd2.GetRowCellDisplayText(I, Me.colQtd)
                            End If

                            Dim dblQtMin As Double = 0
                            If Me.grd2.GetRowCellDisplayText(I, Me.colQtdMinima) <> "" Then
                                dblQtMin = Me.grd2.GetRowCellDisplayText(I, Me.colQtdMinima)
                            End If


                            Dim intFalta As Integer = 0

                            If dblQtMin >= dblQt Then
                                intFalta = 1
                            End If

                            dblQtdLog += dblQt

                            Inserir("INSERT INTO Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, ValorCusto, EmFalta, CodConfig, " & _
                            "Acabou, DataFim) VALUES (" & intCodiProd & ",'" & grd2.GetRowCellDisplayText(I, Me.colTamanho).Trim & "'," & _
                            "0," & _
                            "0," & _
                            "'" & Me.grd2.GetRowCellDisplayText(I, Me.colLote).Trim & "'," & Num(strValCusto) & ",'0'," & _
                            "" & Me.grd2.GetRowCellDisplayText(I, Me.colCodConfig) & ",'False','01/01/1900')")

                            'If EstoqueSomado = True Then
                            SalvarQtde(True, intCodiProd, Me.grd2.GetRowCellDisplayText(I, Me.colCodConfig), 0)
                            'End If
                        Next

                    Else
                        'For I = 0 To grd2.RowCount - 1
                        '    Dim strValCusto As String = Num(Me.grd2.GetRowCellDisplayText(I, Me.colValorCustoQtd))
                        '    Dim dblQt As Double = 0
                        '    If Me.grd2.GetRowCellDisplayText(I, Me.colQtd) <> "" Then
                        '        dblQt = Me.grd2.GetRowCellDisplayText(I, Me.colQtd)
                        '    End If

                        '    Dim dblQtMin As Double = 0
                        '    If Me.grd2.GetRowCellDisplayText(I, Me.colQtdMinima) <> "" Then
                        '        dblQtMin = Me.grd2.GetRowCellDisplayText(I, Me.colQtdMinima)
                        '    End If


                        '    Dim intFalta As Integer = 0

                        '    If dblQtMin >= dblQt Then
                        '        intFalta = 1
                        '    End If

                        '    dblQtdLog += dblQt

                        '    Inserir("INSERT INTO Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, ValorCusto, EmFalta, CodConfig, " & _
                        '    "Acabou, DataFim) VALUES (" & intCodiProd & ",'" & grd2.GetRowCellDisplayText(I, Me.colTamanho).Trim & "'," & _
                        '    "0," & _
                        '    "0," & _
                        '    "'" & Me.grd2.GetRowCellDisplayText(I, Me.colLote).Trim & "'," & Num(strValCusto) & ",'0'," & _
                        '    "" & Me.grd2.GetRowCellDisplayText(I, Me.colCodConfig) & ",'False','01/01/1900')")

                        '    'If EstoqueSomado = True Then
                        '    '    SalvarQtde(True, intCodiProd, Me.grd2.GetRowCellDisplayText(I, Me.colCodConfig), 0)
                        '    'End If
                        'Next
                    End If


                    Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES (" & _
                    "'" & My.Computer.Clock.LocalTime & "'," & CodUser & ",''," & _
                    "'" & Me.txtCodInt.Text.Trim & " - " & Me.txtNome.Text & " Qtd: " & dblQtdLog & "','PRODUTO','PRODUTO'," & _
                    "'CADASTRO'," & CodConfig & ")")

                    If EmiteNFE = True Or AbaSatFiscal = True Or NANONFCe = True Then
                        Dim strTipoFiscal As String = ""

                        If TipoFiscal = "AMBOS" Then
                            Select Case Me.cboTipoFiscal.Text
                                Case "NFE"
                                    strTipoFiscal = " NFE"

                                Case "SAT"
                                    strTipoFiscal = " SAT"
                            End Select
                        End If
                        Inserir("INSERT INTO Nfe (CodProd, EXTIPI, Genero, CST, Origem, ModBC, ICMS, RedBC, ModBCST, " & _
                        "RedBCST, MVaST, CFOP, ICMSST, NCM, Regime, CalculoCred, CodigoANP, UFComb, Cest, PerFCPUF, " & _
                        "PerICMSUF) VALUES (" & intCodiProd & ",'" & Me.txtEXTIPI.Text & "','" & Me.txtGenero.Text & "'," & _
                        "'" & strCst & "','" & strOrig & "','" & strModBC & "','" & Me.txtNfeICMS.Text.Trim & "'," & _
                        "'" & Me.txtRedBC.Text.Trim & "','" & strModBCST & "','" & Me.txtRedBCST.Text.Trim & "'," & _
                        "'" & Me.txtMVAST.Text.Trim & "','" & strCfopDoProduto & "','" & Me.txtICMSST.Text.Trim & "'," & _
                        "'" & Me.txtNfeNCM.Text.Trim & "','SIMPLES NACIONAL" & strTipoFiscal & "','" & Me.txtCalcCred.Text.Trim & "'," & _
                        "'" & Me.cboCodigoANP.Text & "','" & Me.cboUF.Text & "','" & Me.txtCest.Text & "'," & _
                        "'" & Me.txtPerFCPUF.Text & "','" & Me.txtPerICMSUF.Text & "')")

                        Inserir("INSERT INTO Tributos (CodProd, CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, " & _
                        "PerCOFINS, Regime) Values (" & intCodiProd & ",'" & strCstIPI & "','" & Me.txtAliquotaIPI.Text & "'," & _
                        "'" & Me.txtCodEnq.Text & "','" & strCstPIS & "','" & Me.txtAliquotaPIS.Text & "'," & _
                        "'" & strCstCOFINS & "','" & Me.txtAliquotaCOFINS.Text & "','SIMPLES NACIONAL" & strTipoFiscal & "')")



                        Inserir("INSERT INTO Nfe (CodProd, EXTIPI, Genero, CST, Origem, ModBC, ICMS, RedBC, ModBCST, " & _
                        "RedBCST, MVaST, CFOP, ICMSST, NCM, Regime, CalculoCred, CodigoANP, UFComb, Cest, PerFCPUF, " & _
                        "PerICMSUF) VALUES (" & intCodiProd & ",'" & Me.txtEXTIPI.Text & "','" & Me.txtGenero.Text & "'," & _
                        "'" & strCstTN & "','" & strOrigTN & "','" & strModBCTN & "','" & Me.txtIcmsTN.Text.Trim & "'," & _
                        "'" & Me.txtRedBcTN.Text.Trim & "','" & strModBCSTTN & "','" & Me.txtRedBcStTN.Text.Trim & "'," & _
                        "'" & Me.txtMvaStTN.Text.Trim & "','" & strCfopDoProduto & "','" & Me.txtIcmsStTN.Text.Trim & "'," & _
                        "'" & Me.txtNfeNCM.Text.Trim & "','TRIBUTAÇÃO NORMAL" & strTipoFiscal & "','" & Me.txtCalcCredTN.Text.Trim & "'," & _
                        "'" & Me.cboCodigoANP.Text & "','" & Me.cboUF.Text & "','" & Me.txtCest.Text & "'," & _
                        "'" & Me.txtPercFcpTN.Text & "','" & Me.txtPercIcmsTN.Text & "')")

                        Inserir("INSERT INTO Tributos (CodProd, CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, " & _
                        "PerCOFINS, Regime) Values (" & intCodiProd & ",'" & strCstIPITN & "','" & Me.txtAliquotaIpiTN.Text & "'," & _
                        "'" & Me.txtCodEnqTN.Text & "','" & strCstPISTN & "','" & Me.txtAliquotaPisTN.Text & "'," & _
                        "'" & strCstCOFINSTN & "','" & Me.txtAliquotaCofinsTN.Text & "','TRIBUTAÇÃO NORMAL" & strTipoFiscal & "')")
                    End If

                    If Me.Tag = "ENTRADANF" Then
                        CodigoDoProduto = intCodiProd
                        bolSalvo = True
                        Limpar()
                        Me.Close()
                        Exit Sub
                    End If
                Else
                    MsgBox("Os dados não foram salvos!", MsgBoxStyle.Information)
                    Exit Sub
                End If


                AtualizarGrid()
                If bolAlterado = True Then
                    Try
                        Me.grd1.FocusedRowHandle = IndexGrid
                        Me.grd1.TopRowIndex = IndexVerGrid
                        Me.grd1.LeftCoord = IndexHorGrid
                    Catch ex As Exception
                    End Try
                End If
                txtQtdPro.Text = grd1.RowCount
                Me.txtNome.Focus()
                Me.chkDuplicar.Checked = False
                Exit Sub

            End If
        End If


        If TipoNano = 1 Then
            SalvarOpc()
        End If

        If Me.picImagem3.Image Is Nothing = False Then
            Dim imagem As Byte() = converteimagem(Me.picImagem3.Image)
            InserirImagem("UPDATE Produto set Imagem1 = @Img where Codigo = " & intCodPro, imagem)

        End If
        If Me.picImagem4.Image Is Nothing = False Then
            Dim imagem As Byte() = converteimagem(Me.picImagem4.Image)
            InserirImagem("UPDATE Produto set Imagem2 = @Img where Codigo = " & intCodPro, imagem)
        End If




        'If ImprimirCupomFiscal = True Then
        'ArqProduto("UNICO", False, intCodPro)
        'End If
        Me.txtCodInt.ResetText()
        AtualizarGrid()
        If bolAlterado = True Then
            Try
                Me.grd1.FocusedRowHandle = IndexGrid
                Me.grd1.TopRowIndex = IndexVerGrid
                Me.grd1.LeftCoord = IndexHorGrid
            Catch ex As Exception

            End Try


        End If
        Limpar()
        txtQtdPro.Text = grd1.RowCount


    End Sub
    Private Sub grd1_LeftCoordChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd1.LeftCoordChanged
        If bolAlterado = False Then
            IndexHorGrid = Me.grd1.LeftCoord
        End If

    End Sub
    Private Sub grd1_TopRowChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd1.TopRowChanged
        If bolAlterado = False Then
            IndexVerGrid = Me.grd1.TopRowIndex
        End If

    End Sub
    Public Function converteimagem(ByVal Imagem As System.Drawing.Image) As Byte()

        'Declare uma variável do Tipo MemoryStream

        Dim ms As New System.IO.MemoryStream()

        'Carrega o memory Stream

        Imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

        'retorna um array de bytes

        Return ms.ToArray()

    End Function
    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        RetornaPesquisa()
    End Sub

    Private Sub RetornaPesquisa()
        If grd1.FocusedRowHandle < 0 Then Exit Sub

        If Me.Tag = "VENDA" Or Me.Tag = "RECEITA" Or Me.Tag = "ENTRADANF" Or Me.Tag = "DESCARTE" Then
            CodigoDoProduto = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)
            Me.Close()
            Exit Sub
        Else
            Alterar()
        End If


    End Sub

    Private Sub btnAlterar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterar.ItemClick
        Alterar()
    End Sub

    Private Sub txtAlterarQtd_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterarQtd.DoubleClick
        bolAlteradoQtd = True
        Me.btnAdd.Image = Nano.My.Resources.Resources.Alterar
        Me.btnAdd.Text = "Alterar"
        AlterarQtd()
    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If MsgBox("Deseja realmente limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Limpar()
        End If
    End Sub

    Private Sub btnCancelar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick

        If grd1.RowCount = 0 Then Exit Sub
        Dim Index As Integer = grd1.FocusedRowHandle

        If Index < 0 Then Exit Sub

        intCodPro = grd1.GetRowCellDisplayText(Index, Me.colCodigo)

        Dim dtVerifica As DataTable = CarregarDataTable("Select CodOrdem from Pedido where CodProd = " & intCodPro)

        If dtVerifica.Rows.Count > 0 Then
            MsgBox("Não é possivel excluir esse Produto pois existem vendas vinculadas à ele!", MsgBoxStyle.Information)
            Exit Sub
        End If

        dtVerifica = CarregarDataTable("Select Codigo from Campanha where CodProd = " & intCodPro)

        If dtVerifica.Rows.Count > 0 Then
            MsgBox("Não é possivel excluir esse Produto pois existem campanhas vinculadas à ele!", MsgBoxStyle.Information)
            Exit Sub
        End If

        strNome = grd1.GetRowCellDisplayText(Index, Me.colNome)
        Dim strCodInterno As String = grd1.GetRowCellDisplayText(Index, Me.colCodigoInterno)
        If MsgBox("Deseja realmente excluir o Produto " & grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colNome) & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then


            If SenhaEstaOK() = False Then Exit Sub

            If Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colTipo) = "RECEITA" Then
                Excluir("DELETE FROM Receita where CodigoInterno = '" & strCodInterno & "'")
                Excluir("DELETE FROM ItensReceita where CodigoInterno = '" & strCodInterno & "'")
            End If

            If Excluir("Delete from Produto where Codigo = " & intCodPro) = True Then
                'If ImprimirCupomFiscal = True Then
                '    ArqProduto("UNICO", True, intCodPro)
                'End If
                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strNome & " Cód. Prod.: " & strCodInterno & "','EXCLUÍDO','PRODUTO','PRODUTO','EXCLUSÃO'," & CodConfig & ")")
                Excluir("DELETE FROM CodigoBarra where CodProd = " & intCodPro)

            End If

            CarregarDados("Select * from produto", Me.GridControl2)
            txtQtdPro.Text = grd1.RowCount
            Limpar()
        End If

    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Validar(Me.txtTamanho) = False Then Exit Sub
        If Validar(Me.txtQtdeMin) = False Then Exit Sub
        If Validar(Me.txtQtde) = False Then Exit Sub
        If Validar(Me.txtValCus) = False Then Exit Sub

        If Master = True Then
            If QtdeLoja > 1 Then
                If Validar(Me.lueLoja) = False Then Exit Sub
            End If

        End If

        If Validar(txtNome) = False Then Exit Sub
        If Validar(cboUniMed) = False Then Exit Sub

        If Validar(Me.cboGrp) = False Then Exit Sub
        If Validar(Me.txtValCus) = False Then Exit Sub
        If Validar(txtVal) = False Then Exit Sub

        Dim intDia, intMes, intAno, intHora, intMinuto As Integer
        Dim strLote, strEmFalta As String
        Dim dblQtdMin, dblQtd As Double

        intDia = Date.Today.Day
        intMes = Month(Now)
        intAno = Year(Now)
        intHora = Hour(Now)
        intMinuto = Minute(Now)

        strLote = intDia.ToString("00") & intMes.ToString("00") & intAno & "-" & intHora.ToString("00") & intMinuto.ToString("00")

        dblQtdMin = Me.txtQtdeMin.Text
        dblQtd = Me.txtQtde.Text
        If dblQtdMin >= dblQtd Then
            strEmFalta = 1
        Else
            strEmFalta = 0
        End If
        With Me.tbQtd.Rows

            Dim intIndex As Integer = Me.grd2.FocusedRowHandle

            If bolAlteradoQtd = False Then

                .Add()
                .Item(.Count - 1).Item("Codigo") = "INSERIR"
                .Item(.Count - 1).Item("Tamanho") = Me.txtTamanho.Text.Trim
                .Item(.Count - 1).Item("QtdMinima") = Me.txtQtdeMin.Text.Trim
                .Item(.Count - 1).Item("Qtd") = Me.txtQtde.Text.Trim
                .Item(.Count - 1).Item("Lote") = strLote
                .Item(.Count - 1).Item("EmFalta") = strEmFalta
                .Item(.Count - 1).Item("ValorCusto") = Me.txtValCus.Text.Trim
                .Item(.Count - 1).Item("CodConfig") = intCodConfig
                .Item(.Count - 1).Item("QtdMaxima") = Me.txtQtdeMax.Text

            Else
                .Item(intIndex).Item("Tamanho") = Me.txtTamanho.Text.Trim
                .Item(intIndex).Item("QtdMinima") = Me.txtQtdeMin.Text.Trim
                .Item(intIndex).Item("Qtd") = Me.txtQtde.Text.Trim
                .Item(intIndex).Item("EmFalta") = strEmFalta
                .Item(intIndex).Item("ValorCusto") = Me.txtValCus.Text.Trim
                .Item(intIndex).Item("CodConfig") = intCodConfig
                .Item(intIndex).Item("QtdMaxima") = Me.txtQtdeMax.Text

            End If
        End With

        bolAlteradoQtd = False

        Me.txtTamanho.ResetText()
        Tamanho(True)
        Me.txtQtdeMax.Text = 0
        Me.txtQtdeMin.Text = 0
        Me.txtQtde.ResetText()
        Me.btnAdd.Image = Nano.My.Resources.Resources.edit_add
        Me.btnAdd.Text = "Adicionar"
        Me.lueLoja.EditValue = DBNull.Value

        If Master = False Then
            Me.txtTamanho.Focus()
        Else
            Me.lueLoja.Focus()
        End If

    End Sub

    Private Sub btnExcluirItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirItem.Click
        If MsgBox("Deseja realmente excluir este item?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            If bolAlterado = True Then
                strExcluir += Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colCodigoQtd) & "|"
                bolExcluir = True
            End If
            Me.grd2.DeleteRow(Me.grd2.FocusedRowHandle)
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.nbcImagem.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded
        If TipoNano = 5 Then
            Me.nbcImagem.PaintStyleName = "SkinNavigationPane"
            Me.nbcImagem.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        End If
      
        txtQtdPro.Text = grd1.RowCount

        If Me.Tag = "VENDA" Then
            Dim index As Integer = -999997
            grd1.FocusedRowHandle = index
            grd1.FocusedColumn = Me.colNome
            grd1.ShowEditor()
        Else
            Dim index As Integer = -999997
            grd1.FocusedRowHandle = index
            grd1.FocusedColumn = Me.colNome
            grd1.ShowEditor()
            Me.txtCodBarra.Focus()
        End If
        Timer1.Stop()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click

        With grd1

            Dim I As Integer
            Dim dblTotCap, dblQtdTotal As Double


            For I = 0 To .RowCount - 1

                Dim dblValLinha, dblQtd As Double

                If .GetRowCellDisplayText(I, Me.colQtd) <> "" Then
                    dblQtd = .GetRowCellDisplayText(I, Me.colQtd)

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

            'Dim dblTotCap As Double

            'Dim dt As DataTable

            'Select Case Me.cboPreco.Text

            '    Case "Valor Custo"

            '        dt = CarregarDataTable("Select sum(Qtd) * sum(ValorCusto) as Total from Qtde")
            '        If dt.Rows.Count > 0 Then
            '            dblTotCap = dt.Rows.Item(0).Item("Total")
            '        Else
            '            dblTotCap = 0
            '        End If

            '    Case "Valor Venda"

            '        dt = CarregarDataTable("Select sum(Qtde.Qtd) * sum(Produto.Valor) as Total from Produto inner Join Qtde on Produto.Codigo = Qtde.CodProd")
            '        If dt.Rowsx.Count > 0 Then
            '            dblTotCap = dt.Rows.Item(0).Item("Total")
            '        Else
            '            dblTotCap = 0
            '        End If

            'End Select

            Me.txtCapital.Text = dblTotCap.ToString("###,###,##0.00")
            Me.txtQtdTotal.Text = dblQtdTotal
        End With

    End Sub
    Private Sub ExportarDados(ByVal Extensao As String)
        salvar.FileName = ""
        salvar.ShowDialog()

        If salvar.FileName <> "" Then

            Select Case Extensao
                Case ".rtf"
                    grd1.ExportToRtf(salvar.FileName + ".rtf")
                Case ".xls"
                    grd1.ExportToXls(salvar.FileName + ".xls")
                Case ".pdf"
                    grd1.ExportToPdf(salvar.FileName + ".pdf")
                Case ".html"
                    grd1.ExportToHtml(salvar.FileName + ".html")
            End Select

            MsgBox("Exportação Concluída!", MsgBoxStyle.Information)
            If MsgBox("Deseja abrir o arquivo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                System.Diagnostics.Process.Start(salvar.FileName + Extensao)
            End If
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        ExportarDados(".rtf")

    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        ExportarDados(".xls")
       
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        ExportarDados(".pdf")
       
    End Sub

    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        ExportarDados(".html")
        
    End Sub

    Private Sub btnCadGrp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadGrp.Click
        frmGrupo.Tag = "GRUPO"
        frmGrupo.ShowDialog()
        Me.cboGrp.Properties.Items.Clear()
        PreencherGrupoSetorCusto("G", Me.cboGrp)
        Me.cboGrp.Focus()
    End Sub

    Private Sub btnPrint_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        QtdeEtiqueta = ""
        TamanhoEtiqueta = ""
        Select Case NomeImpCodigoBarra

            Case ""
                Dim strImpressao As String

                iRetorno = iImprimirTexto_DUAL_DarumaFramework("<e><b>" & " " & NomeEmpresa & "</b></e><l></l>", 0)

                iRetorno = iImprimirTexto_DUAL_DarumaFramework("<code39><h80><w2><txt>" & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigoInterno).Trim & "</txt></w2></h80></code39>", 0)
                strImpressao = "  " & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colNome).Trim & vbCrLf
                strImpressao &= "<e><b>" & " R$ " & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colValor).Trim & "</b></e>"
                strImpressao &= "<l></l>"
                strImpressao &= "<l></l>"
                strImpressao &= "<l></l>"
                strImpressao &= "<l></l>"
                If TemGuilhotina = True Then
                    strImpressao &= "<l></l>"
                    strImpressao &= "<l></l>"
                    strImpressao &= "<gui></gui>" & vbCrLf
                End If
                If ImpressoraOK() = True Then
                    iRetorno = iImprimirTexto_DUAL_DarumaFramework(strImpressao, 0)
                End If

            Case "ARGOX OS-214 PLUS"
                Select Case Me.cboMod.EditValue
                    Case "DUPLA GRANDE"
                        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
                        frmImpTam.strTipoEtiqueta = Me.cboMod.EditValue
                        frmImpTam.Show()
                    Case "DUPLA MÉDIA"
                        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
                        frmImpTam.strTipoEtiqueta = Me.cboMod.EditValue
                        frmImpTam.Show()
                    Case "TRIPLA PEQUENA", "TRIPLA MINI"
                        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
                        If ProcuraForm("frmImpProd") <> "frmImpProd" Then

                            frmImpProd.strTipoEtiqueta = Me.cboMod.EditValue

                            frmImpProd.intCodProd = 0

                            If grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigoInterno).Trim <> "" Then
                                If CodigoProdutoEtiqueta = "" Then
                                    CodigoProdutoEtiqueta = grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo).Trim
                                End If
                                frmImpProd.Tag = Me.cboMod.EditValue
                                frmImpProd.Show()
                            End If
                        End If
                    Case "TRIPLA MÉDIA ARGOX"

                        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
                        If ProcuraForm("frmImpProd") <> "frmImpProd" Then

                            frmImpProd.intCodProd = 0

                            If grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigoInterno).Trim <> "" Then
                                If CodigoProdutoEtiqueta = "" Then
                                    CodigoProdutoEtiqueta = grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo).Trim
                                End If
                                frmImpProd.Tag = "TRIPLA MÉDIA ARGOX"
                                frmImpProd.Show()
                            End If
                        End If

                    Case "DUPLA MÉDIA ARGOX"

                        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
                        If ProcuraForm("frmImpProd") <> "frmImpProd" Then

                            frmImpProd.intCodProd = 0

                            If grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigoInterno).Trim <> "" Then
                                If CodigoProdutoEtiqueta = "" Then
                                    CodigoProdutoEtiqueta = grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo).Trim
                                End If
                                frmImpProd.Tag = "DUPLA MÉDIA ARGOX"
                                frmImpProd.Show()
                            End If
                        End If
                    Case Else
                        MsgBox("Selecione o modelo da etiqueta!", MsgBoxStyle.Information)
                        Exit Sub
                End Select

            Case "ZEBRA TLP 2844"
                Select Case Me.cboMod.EditValue
                    Case "DUPLA GRANDE"
                        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
                        frmImpTam.Show()

                    Case "TRIPLA PEQUENA", "GÔNDOLA"

                        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
                        If ProcuraForm("frmImpProd") <> "frmImpProd" Then

                            frmImpProd.strTipoEtiqueta = Me.cboMod.EditValue

                            frmImpProd.intCodProd = 0

                            If grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigoInterno).Trim <> "" Then
                                If CodigoProdutoEtiqueta = "" Then
                                    CodigoProdutoEtiqueta = grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo).Trim
                                End If
                                frmImpProd.Tag = Me.cboMod.EditValue
                                frmImpProd.Show()
                            End If
                        End If

                    Case "TRIPLA MINI"

                        MsgBox("Modelo de etiqueta não disponível para a impressora Zebra!", MsgBoxStyle.Information)
                        Exit Sub

                    Case Else
                        MsgBox("Selecione o modelo da etiqueta!", MsgBoxStyle.Information)
                        Exit Sub
                End Select

            Case "SMART LABEL PRINTER 440"

                If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
                If ProcuraForm("frmImpProd") <> "frmImpProd" Then

                    frmImpProd.intCodProd = 0

                    If grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigoInterno).Trim <> "" Then
                        If CodigoProdutoEtiqueta = "" Then
                            CodigoProdutoEtiqueta = grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo).Trim
                        End If
                        frmImpProd.Show()
                    End If
                End If

            Case "IMPRESSORA NORMAL"

                Select Case Me.cboMod.EditValue
                    Case "PIMACO A4348"

                        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
                        If ProcuraForm("frmImpProd") <> "frmImpProd" Then

                            frmImpProd.intCodProd = 0

                            If grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigoInterno).Trim <> "" Then
                                If CodigoProdutoEtiqueta = "" Then
                                    CodigoProdutoEtiqueta = grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo).Trim
                                End If
                                frmImpProd.Tag = "PIMACO A4348"
                                frmImpProd.Show()
                            End If
                        End If

                    Case "PIMACO A4360"
                        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
                        If ProcuraForm("frmImpProd") <> "frmImpProd" Then

                            frmImpProd.intCodProd = 0

                            If grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigoInterno).Trim <> "" Then
                                If CodigoProdutoEtiqueta = "" Then
                                    CodigoProdutoEtiqueta = grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo).Trim
                                End If
                                frmImpProd.Tag = "PIMACO A4360"
                                frmImpProd.Show()
                            End If
                        End If

                    Case "PIMACO A5Q1219"
                        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
                        If ProcuraForm("frmImpProd") <> "frmImpProd" Then

                            frmImpProd.intCodProd = 0

                            If grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigoInterno).Trim <> "" Then
                                If CodigoProdutoEtiqueta = "" Then
                                    CodigoProdutoEtiqueta = grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo).Trim
                                End If
                                frmImpProd.Tag = "PIMACO A5Q1219"
                                frmImpProd.Show()
                            End If
                        End If

                    Case "ETIQUETA CAIXA"
                        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
                        If ProcuraForm("frmImpProd") <> "frmImpProd" Then

                            frmImpProd.intCodProd = 0

                            If grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigoInterno).Trim <> "" Then
                                If CodigoProdutoEtiqueta = "" Then
                                    CodigoProdutoEtiqueta = grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo).Trim
                                End If
                                frmImpProd.Tag = "ETIQUETA CAIXA"
                                frmImpProd.Show()
                            End If
                        End If

                    Case "PROMOÇÃO"

                        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
                        If ProcuraForm("frmImpProd") <> "frmImpProd" Then

                            frmImpProd.intCodProd = 0

                            If grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigoInterno).Trim <> "" Then
                                If CodigoProdutoEtiqueta = "" Then
                                    CodigoProdutoEtiqueta = grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo).Trim
                                End If
                                frmImpProd.Tag = "PROMOÇÃO"
                                frmImpProd.Show()
                            End If
                        End If
                End Select
            Case "ZEBRA ZT"
                Select Case Me.cboMod.EditValue
                    Case "ZT 230 DUPLA"
                        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
                        If ProcuraForm("frmImpProd") <> "frmImpProd" Then

                            frmImpProd.intCodProd = 0

                            If grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigoInterno).Trim <> "" Then
                                If CodigoProdutoEtiqueta = "" Then
                                    CodigoProdutoEtiqueta = grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo).Trim
                                End If
                                frmImpProd.Tag = "ZT 230 DUPLA"
                                frmImpProd.Show()
                            End If
                        End If
                End Select

            Case "BEMA LB-1000"
                Select Case Me.cboMod.EditValue
                    Case "LB 1000 DUPLA"

                        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
                        If ProcuraForm("frmImpProd") <> "frmImpProd" Then

                            frmImpProd.intCodProd = 0

                            If grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigoInterno).Trim <> "" Then
                                If CodigoProdutoEtiqueta = "" Then
                                    CodigoProdutoEtiqueta = grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo).Trim
                                End If
                                frmImpProd.Tag = "LB 1000 DUPLA"
                                frmImpProd.Show()
                            End If
                        End If
                    Case "LB 1000 TRIPLA"

                        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
                        If ProcuraForm("frmImpProd") <> "frmImpProd" Then

                            frmImpProd.intCodProd = 0

                            If grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigoInterno).Trim <> "" Then
                                If CodigoProdutoEtiqueta = "" Then
                                    CodigoProdutoEtiqueta = grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo).Trim
                                End If
                                frmImpProd.Tag = "LB 1000 TRIPLA"
                                frmImpProd.Show()
                            End If
                        End If
                    Case "LB 1000 PEQUENA"

                        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
                        If ProcuraForm("frmImpProd") <> "frmImpProd" Then

                            frmImpProd.intCodProd = 0

                            If grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigoInterno).Trim <> "" Then
                                If CodigoProdutoEtiqueta = "" Then
                                    CodigoProdutoEtiqueta = grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo).Trim
                                End If
                                frmImpProd.Tag = "LB 1000 PEQUENA"
                                frmImpProd.Show()
                            End If
                        End If
                    Case "LB 1000 GÔNDOLA"

                        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
                        If ProcuraForm("frmImpProd") <> "frmImpProd" Then

                            frmImpProd.intCodProd = 0

                            If grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigoInterno).Trim <> "" Then
                                If CodigoProdutoEtiqueta = "" Then
                                    CodigoProdutoEtiqueta = grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo).Trim
                                End If
                                frmImpProd.Tag = "LB 1000 GÔNDOLA"
                                frmImpProd.Show()
                            End If
                        End If
                End Select
        End Select

    End Sub

    Private Sub txtQtdeMin_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtdeMin.Enter

        Select Case cboUniMed.SelectedIndex
            Case 0, 1, 2
                Me.txtQtdeMin.CasasDecimais = 0
            Case 3, 4
                Me.txtQtdeMin.CasasDecimais = 3
            Case 5
                Me.txtQtdeMin.CasasDecimais = 2
            Case Else
                Me.txtQtdeMin.CasasDecimais = 3
        End Select
    End Sub

    Private Sub txtQtdeMax_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtdeMax.Enter
        Select Case cboUniMed.SelectedIndex
            Case 0, 1, 2
                Me.txtQtdeMax.CasasDecimais = 0
            Case 3, 4
                Me.txtQtdeMax.CasasDecimais = 3
            Case 5
                Me.txtQtdeMax.CasasDecimais = 2
            Case Else
                Me.txtQtdeMax.CasasDecimais = 3
        End Select
    End Sub

    Private Sub txtQtde_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtde.Enter
        Select Case cboUniMed.SelectedIndex
            Case 0, 1, 2
                Me.txtQtde.CasasDecimais = 0
            Case 3, 4
                Me.txtQtde.CasasDecimais = 3
            Case 5
                Me.txtQtde.CasasDecimais = 2
            Case Else
                Me.txtQtdeMin.CasasDecimais = 3
        End Select
    End Sub

    Private Sub txtPor1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPor1.Leave
        If Me.txtValCus.Text.Trim = "" Then Exit Sub
        If Me.txtPor1.Text.Trim = "" Then
            Me.chkTamanho.Focus()
            Exit Sub
        End If


        Dim dblValCus, dblResul As Double
        Dim dblPor As Double = txtPor1.Text

        dblValCus = Me.txtValCus.Text

        dblResul = (dblValCus * dblPor) / 100

        dblResul = dblValCus + dblResul

        If TresCasasDecimais = True Then
            Me.txtVal.Text = dblResul.ToString("0.000")
        Else
            Me.txtVal.Text = dblResul.ToString("0.00")
        End If


        Me.chkTamanho.Focus()
    End Sub

    Private Sub txtVal_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVal.Leave
        If Me.txtVal.Text.Trim = "" Then
            Me.txtPor1.Focus()
            Exit Sub
        End If

        If Me.txtValCus.Text.Trim = "" Then Exit Sub
        If Preco(Me.txtVal) = False Then Exit Sub

        Dim dblValVenda, dblValCusto, dblLucro, dblMargem As Double

        dblValVenda = Me.txtVal.Text.Trim
        dblValCusto = Me.txtValCus.Text.Trim

        dblLucro = dblValVenda - dblValCusto

        dblMargem = (dblLucro * 100) / dblValCusto
        Dim str As String = dblMargem

        If str <> "+Infinito" And str <> "NaN (Não é um número)" Then
            If TresCasasDecimais = True Then
                Me.txtPor1.Text = dblMargem.ToString("0.000")
            Else
                Me.txtPor1.Text = dblMargem.ToString("0.00")
            End If

        End If
        Me.chkTamanho.Focus()
    End Sub

    Private Sub txtValCus_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValCus.Leave
        Preco(Me.txtValCus)
        If BaixaPorLote = False Then
            Dim I As Integer
            For I = 0 To Me.tbQtd.Rows.Count - 1
                Me.tbQtd.Rows(I).Item("ValorCusto") = Me.txtValCus.Text.Trim
            Next
        End If
        If ManterPorcProd = False Then
            Me.txtVal.Focus()
        Else
            Me.txtPor1.Focus()
        End If

    End Sub

    Private Sub chkAlterar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAlterar.CheckedChanged
        Select Case Me.chkAlterar.Checked
            Case True
                Me.chkAlterar.BackColor = Color.White
                Me.txtCodInt.Enabled = True
                Me.chkAlterar.Tag = Me.txtCodInt.Text.Trim
            Case False
                Me.chkAlterar.BackColor = Color.Transparent
                Me.txtCodInt.Enabled = False
                Me.txtCodInt.Text = Me.chkAlterar.Tag
        End Select
    End Sub

    Private Sub txtCodBarra_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodBarra.Leave
        If Me.txtCodBarra.Text.Trim = "" Then Exit Sub
        If Me.txtCodBarra.Text = strCodBarra Then Exit Sub
        If Me.txtCodInt.Text.Trim = Me.txtCodBarra.Text.Trim Then
            MsgBox("O código de barra não pode ser igual ao código interno!", MsgBoxStyle.Information)
            Me.txtCodBarra.ResetText()
            Exit Sub
        End If
        PesquisarProduto(txtCodBarra, "CodigoInterno")
        PesquisarProduto(txtCodBarra, "CodigoBarra")
        VerificarCodBarra(txtCodBarra)

    End Sub
    Private Sub VerificarCodBarra(ByVal parCodBarra As Object)

        Dim dtBarra As DataTable = CarregarDataTable("SELECT CodigoBarra, CodProd FROM CodigoBarra where CodigoBarra = '" & parCodBarra.Text.Trim & "' and Produto = '' or CodigoBarra = '" & parCodBarra.Text.Trim & "' and Produto is null")
        If dtBarra.Rows.Count > 0 Then
            If bolAlterado = True Then
                Dim intCodProdBarra As Integer = dtBarra.Rows.Item(0).Item("CodProd")
                If intCodProdBarra <> intCodPro Then
                    MsgBox("Código já cadastrado para outro Produto!", MsgBoxStyle.Information)
                    parCodBarra.ResetText()
                    parCodBarra.Focus()
                    Exit Sub
                End If
            Else
                MsgBox("Código já cadastrado para outro Produto!", MsgBoxStyle.Information)
                parCodBarra.ResetText()
                parCodBarra.Focus()
                Exit Sub
            End If
        End If
    End Sub
    'Private Sub txtCodInt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodInt.KeyPress
    '    If AcrescentarZeroCodProd = False Then
    '        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub

    Private Sub txtCodInt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodInt.Leave
        If txtCodInt.Text = "" Then
            Me.chkAlterar.Checked = False
            Exit Sub
        End If
        If AcrescentarZeroCodProd = True Then

            Select Case Me.txtCodInt.Text.Length
                Case 1
                    Me.txtCodInt.Text = "000" & Me.txtCodInt.Text
                Case 2
                    Me.txtCodInt.Text = "00" & Me.txtCodInt.Text
                Case 3
                    Me.txtCodInt.Text = "0" & Me.txtCodInt.Text
                Case 4
                Case Else
                    If Not Me.txtCodInt.Text.Length Mod 2 = 0 Then
                        Me.txtCodInt.Text = "0" & Me.txtCodInt.Text
                    End If
            End Select
        End If
        PesquisarProduto(txtCodInt, "CodigoInterno")
        If txtCodInt.Text <> "" Then
            PesquisarProduto(txtCodInt, "CodigoBarra")
            VerificarCodBarra(txtCodInt)
        End If
        
        If bolAlterado = True Then
            Me.txtNome.Focus()
        End If
    End Sub

   
    Private Sub cboTrib_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrib.SelectedIndexChanged
        If Me.cboTrib.Text = "F" Or Me.cboTrib.Text = "T" Then
            Me.txtIcms.Enabled = True
        Else
            Me.txtIcms.Text = "0,00"
            Me.txtIcms.Enabled = False
        End If
        Me.cboTrib2.SelectedIndex = cboTrib.SelectedIndex
    End Sub

    Private Sub cboCst_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCst.SelectedIndexChanged
        cboCst2.SelectedIndex = cboCst.SelectedIndex
    End Sub

    Private Sub cboOriIcm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOriIcm.SelectedIndexChanged
        cboOriIcm2.SelectedIndex = cboOriIcm.SelectedIndex
    End Sub

    Private Sub cboTrib2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrib2.SelectedIndexChanged
        Me.cboTrib.SelectedIndex = cboTrib2.SelectedIndex
    End Sub

    Private Sub cboCst2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCst2.SelectedIndexChanged
        cboCst.SelectedIndex = cboCst2.SelectedIndex
    End Sub

    Private Sub cboOriIcm2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOriIcm2.SelectedIndexChanged
        cboOriIcm.SelectedIndex = cboOriIcm2.SelectedIndex
    End Sub

    Private Sub txtAlterar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlterar.KeyDown
        If e.KeyCode = Keys.Enter Then
            RetornaPesquisa()
        End If
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
                Me.txtQtdeMin.Focus()
            Case False
                Me.txtTamanho.Enabled = True
                Me.txtTamanho.Text = ""
                Me.txtTamanho.Focus()
        End Select
    End Sub

    
    Private Sub chkDesc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDesc.CheckedChanged
        If Me.chkDesc.Checked = True Then
            Me.txtDesconto.Enabled = True
            Me.txtValDesconto.Enabled = True
            Me.txtDesconto.Focus()
        Else
            Me.txtDesconto.ResetText()
            Me.txtValDesconto.ResetText()
            Me.txtValDesconto.Enabled = False
            Me.txtDesconto.Enabled = False
        End If
    End Sub

    Private Sub btnCadSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadSet.Click
        frmGrupo.Tag = "SETOR"
        frmGrupo.ShowDialog()
        Me.cboSet.Properties.Items.Clear()
        PreencherGrupoSetorCusto("S", Me.cboSet)
        Me.cboSet.Focus()
    End Sub

    Private Sub lueLoja_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueLoja.TextChanged
        If Me.lueLoja.EditValue.ToString <> "" Then
            intCodConfig = Me.lueLoja.EditValue
        End If
    End Sub


    Private Sub btnAdic_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdic.ItemClick
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        QtdeEtiqueta = ""
        Select Case NomeImpCodigoBarra
            Case "ARGOX OS-214 PLUS"

                Select Case cboMod.EditValue

                    Case "DUPLA GRANDE", "DUPLA MÉDIA"
                        frmImpTam.CarregarProduto(Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo))

                    Case Else
                        If ProcuraForm("frmImpProd") = "frmImpProd" Then
                            CodigoProdutoEtiqueta = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)
                        Else
                            CodigoProdutoEtiqueta &= Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo) & "|"
                        End If


                End Select

             

            Case "SMART LABEL PRINTER 440"

                If ProcuraForm("frmImpProd") = "frmImpProd" Then
                    CodigoProdutoEtiqueta = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)
                Else
                    CodigoProdutoEtiqueta &= Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo) & "|"
                End If

            Case "BEMA LB-1000"

                If ProcuraForm("frmImpProd") = "frmImpProd" Then
                    CodigoProdutoEtiqueta = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)
                Else
                    CodigoProdutoEtiqueta &= Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo) & "|"
                End If

            Case "IMPRESSORA NORMAL"

                If ProcuraForm("frmImpProd") = "frmImpProd" Then
                    CodigoProdutoEtiqueta = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)
                Else
                    CodigoProdutoEtiqueta &= Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo) & "|"
                End If
            Case "ZEBRA ZT"
                Select Case cboMod.EditValue
                    Case "ZT 230 DUPLA"
                        If ProcuraForm("frmImpProd") = "frmImpProd" Then
                            CodigoProdutoEtiqueta = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)
                        Else
                            CodigoProdutoEtiqueta &= Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo) & "|"
                        End If
                End Select

            Case Else
                Select Case cboMod.EditValue

                    Case "DUPLA GRANDE", "DUPLA MÉDIA"
                        frmImpTam.CarregarProduto(Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo))

                    Case "TRIPLA PEQUENA", "TRIPLA MINI", "GÔNDOLA"
                        If ProcuraForm("frmImpProd") = "frmImpProd" Then
                            CodigoProdutoEtiqueta = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)
                        Else
                            CodigoProdutoEtiqueta &= Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo) & "|"
                        End If


                    Case ""
                        MsgBox("Selecione o modelo da etiqueta!", MsgBoxStyle.Information)

                End Select
        End Select
 
    End Sub
  

    Private Sub btnImposto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImposto.Click
        If MsgBox("Atenção!" & vbCrLf & "Ao clicar em 'Sim' você informará esses dados de impostos para todos os produtos listados abaixo." & vbCrLf & "Você tem certeza que deseja fazer isso?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim bolNCM As Boolean = False
            If MsgBox("Deseja alterar o NCM de todos os produtos listados abaixo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                bolNCM = True
            End If

            Dim I, intCodProd As Integer
            Dim dtImpos As DataTable
            For I = 0 To Me.grd1.RowCount - 1
                intCodProd = Me.grd1.GetRowCellValue(I, Me.colCodigo)
                dtImpos = CarregarDataTable("SELECT Codigo FROM ImpostoProduto where CodProd = " & intCodProd)
                If dtImpos.Rows.Count > 0 Then
                    Dim strNCMInserir As String = ""
                    If bolNCM = True Then
                        strNCMInserir = ", NCM ='" & Me.txtNCMImpProd.Text.Trim & "'"
                    End If

                    Atualizar("Update ImpostoProduto set ICMS =" & Me.txtIcms.Text.Trim.Replace(",", ".") & ", " & _
                    "IPI =" & "0.00" & ", Tributacao ='" & Me.cboTrib.Text.Trim & "', Cst ='" & Me.cboCst.Text.Trim & "', " & _
                    "OrigemIcms ='" & Me.cboOriIcm.Text.Trim & "', IPPT ='" & Me.cboIPPT.Text.Trim & "', " & _
                    "Pesavel ='" & Me.cboPesa.Text.Trim & "', TipoFIA ='" & Me.cboFIA.Text.Trim & "'" & strNCMInserir & "  where CodProd = " & intCodProd)
                Else
                    If bolNCM = True Then
                        Inserir("Insert into ImpostoProduto (CodProd, ICMS, Tributacao, Cst, OrigemIcms, IPPT, Pesavel, TipoFIA, NCM) Values(" & intCodProd & "," & Me.txtIcms.Text.Trim.Replace(",", ".") & ",'" & Me.cboTrib.Text.Trim & "','" & Me.cboCst.Text.Trim & "','" & Me.cboOriIcm.Text.Trim & "','" & Me.cboIPPT.Text.Trim & "','" & Me.cboPesa.Text.Trim & "','" & Me.cboFIA.Text.Trim & "','" & Me.txtNCMImpProd.Text.Trim & "')")

                    Else
                        Inserir("Insert into ImpostoProduto (CodProd, ICMS, Tributacao, Cst, OrigemIcms, IPPT, Pesavel, TipoFIA) Values(" & intCodProd & "," & Me.txtIcms.Text.Trim.Replace(",", ".") & ",'" & Me.cboTrib.Text.Trim & "','" & Me.cboCst.Text.Trim & "','" & Me.cboOriIcm.Text.Trim & "','" & Me.cboIPPT.Text.Trim & "','" & Me.cboPesa.Text.Trim & "','" & Me.cboFIA.Text.Trim & "')")

                    End If
                End If
            Next
            MsgBox("Dados salvo com sucesso!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnCadFor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadFor.Click
        frmCadFornecedor.Tag = "Fornecedor"
        frmCadFornecedor.ShowDialog()
        Me.cboFabricante.Properties.Items.Clear()
        PreencherCombo("Fornecedor", Me.cboFabricante, 1, "Nome")
        Me.cboFabricante.Focus()

    End Sub


    Private Sub CST(ByVal parCST As String)
        LimparNFE(False, parCST)
        If parCST = "SIMPLES NACIONAL" Then

            Dim strNFECST As String = Me.cboNfeCST.Text
           
            If strNFECST <> "" Then
                strNFECST = strNFECST.Substring(0, 3)
            End If


            Select Case strNFECST


                Case "202", "203"
                    Me.txtRedBC.Enabled = False
                    Me.cboModBC.Enabled = False
                    Me.txtNfeICMS.Enabled = False
                    Me.txtCalcCred.Enabled = False
                Case "102", "103", "300", "400", "500"
                    Me.cboModBC.Enabled = False
                    Me.txtNfeICMS.Enabled = False
                    Me.txtRedBC.Enabled = False
                    Me.cboModBCST.Enabled = False
                    Me.txtRedBCST.Enabled = False
                    Me.txtMVAST.Enabled = False
                    Me.txtICMSST.Enabled = False
                    Me.txtCalcCred.Enabled = False


                Case "101"
                    Me.cboModBC.Enabled = False
                    Me.txtNfeICMS.Enabled = False
                    Me.txtRedBC.Enabled = False
                    Me.cboModBCST.Enabled = False
                    Me.txtRedBCST.Enabled = False
                    Me.txtMVAST.Enabled = False
                    Me.txtICMSST.Enabled = False

                Case "201"
                    Me.txtRedBC.Enabled = False
                    Me.cboModBC.Enabled = False
                    Me.txtNfeICMS.Enabled = False
            End Select
        Else

            Dim strNFECST As String = Me.cboCstTN.Text

            If strNFECST <> "" Then
                strNFECST = strNFECST.Substring(0, 2)
            End If


            Select Case strNFECST
                Case "00"
                    Me.txtRedBcTN.Enabled = False
                    Me.cboModBcStTN.Enabled = False
                    Me.txtRedBcStTN.Enabled = False
                    Me.txtMvaStTN.Enabled = False
                    Me.txtIcmsStTN.Enabled = False
                    Me.txtCalcCredTN.Enabled = False
                Case "10"
                    Me.txtRedBcTN.Enabled = False
                    Me.txtCalcCredTN.Enabled = False
                Case "20", "51"
                    Me.cboModBcStTN.Enabled = False
                    Me.txtRedBcStTN.Enabled = False
                    Me.txtMvaStTN.Enabled = False
                    Me.txtIcmsStTN.Enabled = False
                    Me.txtCalcCredTN.Enabled = False
                Case "30"
                    Me.txtRedBcTN.Enabled = False
                    Me.cboModBcTN.Enabled = False
                    Me.txtIcmsTN.Enabled = False
                    Me.txtCalcCredTN.Enabled = False
                Case "40", "41", "50", "60"
                    Me.cboModBcTN.Enabled = False
                    Me.txtIcmsTN.Enabled = False
                    Me.txtRedBcTN.Enabled = False
                    Me.cboModBcStTN.Enabled = False
                    Me.txtRedBcStTN.Enabled = False
                    Me.txtMvaStTN.Enabled = False
                    Me.txtIcmsStTN.Enabled = False
                    Me.txtCalcCredTN.Enabled = False
                Case "70", "90"
                    Me.txtCalcCredTN.Enabled = False
            End Select
        End If
    End Sub
    

    Private Sub cboNfeCST_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboNfeCST.SelectedIndexChanged
        CST("SIMPLES NACIONAL")
    End Sub
    Private Sub cboCstTN_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCstTN.SelectedIndexChanged
        CST("TRIBUTAÇÃO NORMAL")
    End Sub
    Private Sub txtEXTIPI_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEXTIPI.Leave
        If Me.txtEXTIPI.Text = "" Then Exit Sub
        Dim strExtipi As String = Me.txtEXTIPI.Text
        If strExtipi.Length = 1 Then
            MsgBox("O campo EXTIPI só aceita de 2 a 3 caracteres!", MsgBoxStyle.Information)
            Me.txtEXTIPI.ResetText()
            Me.txtEXTIPI.Focus()
        End If
    End Sub

    Private Sub txtNfeNCM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNfeNCM.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNfeNCM_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNfeNCM.Leave
        If Me.txtNfeNCM.Text = "" Then Exit Sub
        Dim strNCM As String = Me.txtNfeNCM.Text
        If strNCM.Length = 1 Then
            MsgBox("O campo NCM só aceita de 2 a 8 caracteres!", MsgBoxStyle.Information)
            Me.txtNfeNCM.ResetText()
            Me.txtNfeNCM.Focus()
        End If

        If Me.txtNfeNCM.Text <> "" Then
            Dim dtTributos As DataTable = CarregarDataTable("Select CFOP, Nfe.Regime, CST, Origem, RedBC, ModBC, RedBCST, " & _
            " ModBCST, MVaST, ICMSST, CalculoCred, CodigoANP, UFComb, Cest, CSTIPI, PerIPI, CodEnq, CSTPIS, PerPis, " & _
            " CSTCOFINS, PerCOFINS, ICMS From Nfe left join Tributos on Nfe.CodProd = Tributos.CodProd and Nfe.Regime = Tributos.Regime " & _
            " Where NCM ='" & Me.txtNfeNCM.Text.Trim & "' and nfe.Regime = '" & RegimeSAT & "' And CFOP <> '' And CST <> '' And Origem <> '' " & _
            " And CSTPIS <> '' And CSTCOFINS <> '' " & _
            " Group by CFOP, Nfe.Regime, CST, Origem, CSTIPI, PerIPI, CodEnq, CSTPIS, PerPis, CSTCOFINS, " & _
            " PerCOFINS, RedBC, ModBC, RedBCST, ModBCST, MVaST, ICMSST, CalculoCred, CodigoANP, UFComb, Cest, ICMS, Nfe.CodProd order by Nfe.CodProd")

            If dtTributos.Rows.Count > 0 Then

                If dtTributos.Rows.Item(0).Item("Regime").ToString = "SIMPLES NACIONAL" Then
                    cboRegime.SelectedIndex = 1

                    lueCFOP.EditValue = dtTributos.Rows.Item(0).Item("CFOP").ToString
                    txtICMSST.Text = dtTributos.Rows.Item(0).Item("CST").ToString
                    txtAliquotaIPI.Text = dtTributos.Rows.Item(0).Item("PerIPI").ToString
                    txtAliquotaPIS.Text = dtTributos.Rows.Item(0).Item("PerPis").ToString
                    txtAliquotaCOFINS.Text = dtTributos.Rows.Item(0).Item("PerCOFINS").ToString


                    If dtTributos.Rows.Item(0).Item("CST").ToString <> "" Then
                        SelecionarCombo(cboNfeCST, dtTributos.Rows.Item(0).Item("CST").ToString)

                    End If
                    If dtTributos.Rows.Item(0).Item("Origem").ToString <> "" Then
                        SelecionarCombo(cboOrigem, dtTributos.Rows.Item(0).Item("Origem").ToString)

                    End If
                    If dtTributos.Rows.Item(0).Item("ModBC").ToString <> "" Then
                        SelecionarCombo(cboModBC, dtTributos.Rows.Item(0).Item("ModBC").ToString)

                    End If

                    txtRedBC.Text = dtTributos.Rows.Item(0).Item("RedBC").ToString
                    If dtTributos.Rows.Item(0).Item("ModBCST").ToString <> "" Then
                        SelecionarCombo(cboModBCST, dtTributos.Rows.Item(0).Item("ModBCST").ToString)
                    End If

                    txtRedBCST.Text = dtTributos.Rows.Item(0).Item("RedBCST").ToString
                    txtMVAST.Text = dtTributos.Rows.Item(0).Item("MVaST").ToString
                    txtICMSST.Text = dtTributos.Rows.Item(0).Item("ICMSST").ToString
                    txtCalcCred.Text = dtTributos.Rows.Item(0).Item("CalculoCred").ToString

                    If dtTributos.Rows.Item(0).Item("CSTIPI").ToString <> "" Then
                        SelecionarCombo(cboCSTIPI, dtTributos.Rows.Item(0).Item("CSTIPI").ToString)
                    End If
                    txtCodEnq.Text = dtTributos.Rows.Item(0).Item("CodEnq").ToString
                    txtAliquotaIPI.Text = dtTributos.Rows.Item(0).Item("PerIPI").ToString


                    If dtTributos.Rows.Item(0).Item("CSTPIS").ToString <> "" Then
                        SelecionarCombo(cboCSTPIS, dtTributos.Rows.Item(0).Item("CSTPIS").ToString)
                    End If
                    txtAliquotaPIS.Text = dtTributos.Rows.Item(0).Item("PerPis").ToString


                    If dtTributos.Rows.Item(0).Item("CSTCOFINS").ToString <> "" Then
                        SelecionarCombo(cboCSTCOFINS, dtTributos.Rows.Item(0).Item("CSTCOFINS").ToString)

                    End If
                    txtAliquotaCOFINS.Text = dtTributos.Rows.Item(0).Item("PerCOFINS").ToString


                    txtNfeICMS.Text = dtTributos.Rows.Item(0).Item("ICMS").ToString
                    cboCodigoANP.Text = dtTributos.Rows.Item(0).Item("CodigoANP").ToString
                    cboUF.Text = dtTributos.Rows.Item(0).Item("UFComb").ToString
                    txtCest.Text = dtTributos.Rows.Item(0).Item("Cest").ToString

                Else
                    cboRegime.SelectedIndex = 0

                    lueCFOP.EditValue = dtTributos.Rows.Item(0).Item("CFOP").ToString
                    txtIcmsStTN.Text = dtTributos.Rows.Item(0).Item("CST").ToString
                    txtAliquotaIpiTN.Text = dtTributos.Rows.Item(0).Item("PerIPI").ToString
                    txtAliquotaPisTN.Text = dtTributos.Rows.Item(0).Item("PerPis").ToString
                    txtAliquotaCofinsTN.Text = dtTributos.Rows.Item(0).Item("PerCOFINS").ToString


                    If dtTributos.Rows.Item(0).Item("CST").ToString <> "" Then
                        SelecionarCombo(cboCstTN, dtTributos.Rows.Item(0).Item("CST").ToString)

                    End If
                    If dtTributos.Rows.Item(0).Item("Origem").ToString <> "" Then
                        SelecionarCombo(cboOrigemTN, dtTributos.Rows.Item(0).Item("Origem").ToString)

                    End If
                    If dtTributos.Rows.Item(0).Item("ModBC").ToString <> "" Then
                        SelecionarCombo(cboModBcTN, dtTributos.Rows.Item(0).Item("ModBC").ToString)

                    End If

                    txtRedBcTN.Text = dtTributos.Rows.Item(0).Item("RedBC").ToString
                    If dtTributos.Rows.Item(0).Item("ModBCST").ToString <> "" Then
                        SelecionarCombo(cboModBcStTN, dtTributos.Rows.Item(0).Item("ModBCST").ToString)
                    End If

                    txtRedBcStTN.Text = dtTributos.Rows.Item(0).Item("RedBCST").ToString
                    txtMvaStTN.Text = dtTributos.Rows.Item(0).Item("MVaST").ToString
                    txtIcmsStTN.Text = dtTributos.Rows.Item(0).Item("ICMSST").ToString
                    txtCalcCredTN.Text = dtTributos.Rows.Item(0).Item("CalculoCred").ToString


                    If dtTributos.Rows.Item(0).Item("CSTIPI").ToString <> "" Then
                        SelecionarCombo(cboCstIpiTN, dtTributos.Rows.Item(0).Item("CSTIPI").ToString)
                    End If
                    txtCodEnqTN.Text = dtTributos.Rows.Item(0).Item("CodEnq").ToString
                    txtAliquotaIpiTN.Text = dtTributos.Rows.Item(0).Item("PerIPI").ToString


                    If dtTributos.Rows.Item(0).Item("CSTPIS").ToString <> "" Then
                        SelecionarCombo(cboCstPisTN, dtTributos.Rows.Item(0).Item("CSTPIS").ToString)
                    End If
                    txtAliquotaPisTN.Text = dtTributos.Rows.Item(0).Item("PerPis").ToString


                    If dtTributos.Rows.Item(0).Item("CSTCOFINS").ToString <> "" Then
                        SelecionarCombo(cboCstCofinsTN, dtTributos.Rows.Item(0).Item("CSTCOFINS").ToString)

                    End If
                    txtAliquotaCofinsTN.Text = dtTributos.Rows.Item(0).Item("PerCOFINS").ToString


                    txtIcmsTN.Text = dtTributos.Rows.Item(0).Item("ICMS").ToString
                    cboCodigoANP.Text = dtTributos.Rows.Item(0).Item("CodigoANP").ToString
                    cboUF.Text = dtTributos.Rows.Item(0).Item("UFComb").ToString
                    txtCest.Text = dtTributos.Rows.Item(0).Item("Cest").ToString

                End If
            End If
        End If
    End Sub
    Private Sub LimparNFE(ByVal parTudo As Boolean, ByVal parCST As String)
        If parCST = "SIMPLES NACIONAL" Then
            If parTudo = True Then
                Me.cboNfeCST.SelectedIndex = -1
            End If

            Me.cboOrigem.SelectedIndex = -1
            Me.cboModBC.SelectedIndex = -1
            Me.txtNfeICMS.ResetText()
            Me.txtRedBC.ResetText()
            Me.cboModBCST.SelectedIndex = -1
            Me.txtRedBCST.ResetText()
            Me.txtMVAST.ResetText()
            Me.txtICMSST.ResetText()
            Me.txtCalcCred.ResetText()

            Me.cboOrigem.Enabled = True
            Me.cboModBC.Enabled = True
            Me.txtNfeICMS.Enabled = True
            Me.txtRedBC.Enabled = True
            Me.cboModBCST.Enabled = True
            Me.txtRedBCST.Enabled = True
            Me.txtMVAST.Enabled = True
            Me.txtCalcCred.Enabled = True
            Me.txtICMSST.Enabled = True



            Me.cboCSTIPI.SelectedIndex = -1
            Me.txtAliquotaIPI.ResetText()
            Me.txtCodEnq.ResetText()


            Me.cboCSTPIS.SelectedIndex = -1
            Me.txtAliquotaPIS.ResetText()

            Me.cboCSTCOFINS.SelectedIndex = -1
            Me.txtAliquotaCOFINS.ResetText()
        Else
            If parTudo = True Then
                Me.cboCstTN.SelectedIndex = -1
            End If

            Me.cboOrigemTN.SelectedIndex = -1
            Me.cboModBcTN.SelectedIndex = -1
            Me.txtIcmsTN.ResetText()
            Me.txtRedBcTN.ResetText()
            Me.cboModBcStTN.SelectedIndex = -1
            Me.txtRedBcStTN.ResetText()
            Me.txtMvaStTN.ResetText()
            Me.txtIcmsStTN.ResetText()
            Me.txtCalcCredTN.ResetText()

            Me.cboOrigemTN.Enabled = True
            Me.cboModBcTN.Enabled = True
            Me.txtIcmsTN.Enabled = True
            Me.txtRedBcTN.Enabled = True
            Me.cboModBcStTN.Enabled = True
            Me.txtRedBcStTN.Enabled = True
            Me.txtMvaStTN.Enabled = True
            Me.txtCalcCredTN.Enabled = True
            Me.txtIcmsStTN.Enabled = True



            Me.cboCstIpiTN.SelectedIndex = -1
            Me.txtAliquotaIpiTN.ResetText()
            Me.txtCodEnqTN.ResetText()


            Me.cboCstPisTN.SelectedIndex = -1
            Me.txtAliquotaPisTN.ResetText()

            Me.cboCstCofinsTN.SelectedIndex = -1
            Me.txtAliquotaCofinsTN.ResetText()
        End If


    End Sub

    Private Sub cboRegime_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboRegime.SelectedIndexChanged
        'LimparNFE(True)
        'Me.cboNfeCST.Properties.Items.Clear()
        'Me.cboNfeCST.Properties.Items.Add("")
        'Select Case Me.cboRegime.SelectedIndex

        '    Case 0
        '        Me.lblCST.Visible = True
        '        Me.lblCSOSN.Visible = False
        '        Me.cboNfeCST.Properties.Items.Add("00 – Tributada integralmente")
        '        Me.cboNfeCST.Properties.Items.Add("10 - Tributada e com cobrança do ICMS por substituição tributária")
        '        Me.cboNfeCST.Properties.Items.Add("20 - Com redução de base de cálculo")
        '        Me.cboNfeCST.Properties.Items.Add("30 - Isenta ou não tributada e com cobrança do ICMS por substituição tributária")
        '        Me.cboNfeCST.Properties.Items.Add("40 - Isenta")
        '        Me.cboNfeCST.Properties.Items.Add("41 - Não tributada")
        '        Me.cboNfeCST.Properties.Items.Add("50 – Suspensão")
        '        Me.cboNfeCST.Properties.Items.Add("51 - Diferimento - A exigência do preenchimento das informações do ICMS diferido fica à critério de cada UF")
        '        Me.cboNfeCST.Properties.Items.Add("60 - ICMS cobrado anteriormente por substituição tributária")
        '        Me.cboNfeCST.Properties.Items.Add("70 - Com redução de base de cálculo e cobrança do ICMS por substituição tributária")
        '        Me.cboNfeCST.Properties.Items.Add("90 – Outros")

        '    Case 1
        '        Me.lblCST.Visible = False
        '        Me.lblCSOSN.Visible = True
        '        Me.cboNfeCST.Properties.Items.Add("101 - Tributada com permissão de crédito")
        '        Me.cboNfeCST.Properties.Items.Add("102 - Tributada sem permissão de crédito")
        '        Me.cboNfeCST.Properties.Items.Add("103 - Isenção do ICMS para faixa de receita bruta")
        '        Me.cboNfeCST.Properties.Items.Add("201 - Tributada com permissão de crédito e com cobrança do ICMS por ST")
        '        Me.cboNfeCST.Properties.Items.Add("202 - Tributada sem permissão de crédito e com cobrança do ICMS por ST")
        '        Me.cboNfeCST.Properties.Items.Add("203 - Isenção do ICMS para faixa de receita bruta e com cobrança do ICMS por ST")
        '        Me.cboNfeCST.Properties.Items.Add("300 - Imune")
        '        Me.cboNfeCST.Properties.Items.Add("400 - Não Tributada")
        '        Me.cboNfeCST.Properties.Items.Add("500 - ICMS cobrado anteriormente por ST ou por antecipação")
        '        Me.cboNfeCST.Properties.Items.Add("900 - Outros")

        'End Select
    End Sub

    Private Sub btnAddNfe_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddNfe.Click
        If Validar(Me.cboRegime) = False Then Exit Sub
        If Validar(Me.cboNfeCST) = False Then Exit Sub

        With Me.tbNfe.Rows
            Dim strCst As String = Me.cboNfeCST.Text
            If strCst <> "" Then
                If Me.cboRegime.SelectedIndex = 0 Then
                    strCst = strCst.Substring(0, 2)
                Else
                    strCst = strCst.Substring(0, 3)
                End If

            End If
            Dim strOrig As String = Me.cboOrigem.Text
            If strOrig <> "" Then
                strOrig = strOrig.Substring(0, 1)
            End If
            Dim strModBC As String = Me.cboModBC.Text
            If strModBC <> "" Then
                strModBC = strModBC.Substring(0, 1)
            End If
            Dim strModBCST As String = Me.cboModBCST.Text
            If strModBCST <> "" Then
                strModBCST = strModBCST.Substring(0, 1)
            End If

            Dim I As Integer


            If bolAltNfe = False Then
                For I = 0 To Me.grd3.RowCount - 1
                    Dim strC As String = Me.grd3.GetRowCellDisplayText(I, Me.colCST)
                    If strC = strCst Then
                        MsgBox("Não é permitido usar duas situações tributarias iguais!", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                Next
                .Add()
                Dim Index As Integer = .Count - 1

                .Item(Index).Item("CST") = strCst
                .Item(Index).Item("Regime") = Me.cboRegime.Text
                .Item(Index).Item("Origem") = strOrig
                .Item(Index).Item("CalculoCred") = Me.txtCalcCred.Text
                .Item(Index).Item("ModBC") = strModBC
                .Item(Index).Item("RedBC") = Me.txtRedBC.Text
                .Item(Index).Item("Icms") = Me.txtNfeICMS.Text
                .Item(Index).Item("ModBCST") = strModBCST
                .Item(Index).Item("RedBCST") = Me.txtRedBCST.Text
                .Item(Index).Item("MVaST") = Me.txtMVAST.Text
                .Item(Index).Item("IcmsST") = Me.txtICMSST.Text

            Else

                If strCSTAlt <> strCst Then

                    For I = 0 To Me.grd3.RowCount - 1
                        Dim strC As String = Me.grd3.GetRowCellDisplayText(I, Me.colCST)
                        If strCSTAlt <> strC Then
                            If strC = strCst Then
                                MsgBox("Não é permitido usar duas situações tributarias iguais!", MsgBoxStyle.Information)
                                Exit Sub
                            End If
                        End If
                    Next
                End If

                grd3.SetRowCellValue(intIndexNfe, Me.colCST, strCst)
                grd3.SetRowCellValue(intIndexNfe, Me.colRegime, Me.cboRegime.Text)
                grd3.SetRowCellValue(intIndexNfe, Me.colOrigem, strOrig)
                grd3.SetRowCellValue(intIndexNfe, Me.colCalculoCred, Me.txtCalcCred.Text)
                grd3.SetRowCellValue(intIndexNfe, Me.colModBC, strModBC)
                grd3.SetRowCellValue(intIndexNfe, Me.colRedBC, Me.txtRedBC.Text)
                grd3.SetRowCellValue(intIndexNfe, Me.colIcms, Me.txtNfeICMS.Text)
                grd3.SetRowCellValue(intIndexNfe, Me.colModBCST, strModBCST)
                grd3.SetRowCellValue(intIndexNfe, Me.colRedBCST, Me.txtRedBCST.Text)
                grd3.SetRowCellValue(intIndexNfe, Me.colMVaST, Me.txtMVAST.Text)
                grd3.SetRowCellValue(intIndexNfe, Me.colIcmsST, Me.txtICMSST.Text)

            End If

            bolAltNfe = False
        End With

        strCSTAlt = ""
        Me.btnAddNfe.Text = "Adicionar"
        Me.btnAddNfe.Image = My.Resources.edit_add
        'LimparNFE(True)
        Me.cboRegime.Focus()
    End Sub
    Public Sub SelecionarCombo(ByVal parCombo As Object, ByVal parTexto As String)
        Dim I As Integer
        Dim index As Integer = -1
        Dim strCombo As String
        If parTexto <> "" Then
            For I = 0 To parCombo.Properties.Items.Count - 1
                strCombo = parCombo.Properties.Items.Item(I).ToString
                If strCombo <> "" Then
                    strCombo = strCombo.Substring(0, 3)
                    If strCombo.Contains(parTexto) Then
                        index = I
                    End If
                End If
            Next
        End If

        parCombo.SelectedIndex = index
    End Sub

    Private Sub txtAltNfe_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAltNfe.DoubleClick
        bolAltNfe = True

        intIndexNfe = Me.grd3.FocusedRowHandle

        Me.cboRegime.Text = Me.grd3.GetRowCellDisplayText(intIndexNfe, Me.colRegime)
        SelecionarCombo(Me.cboNfeCST, Me.grd3.GetRowCellDisplayText(intIndexNfe, Me.colCST))
        strCSTAlt = Me.grd3.GetRowCellDisplayText(intIndexNfe, Me.colCST)
        ' CST()

        SelecionarCombo(Me.cboOrigem, Me.grd3.GetRowCellDisplayText(intIndexNfe, Me.colOrigem))
        Me.txtCalcCred.Text = Me.grd3.GetRowCellDisplayText(intIndexNfe, Me.colCalculoCred)
        SelecionarCombo(Me.cboModBC, Me.grd3.GetRowCellDisplayText(intIndexNfe, Me.colModBC))
        Me.txtRedBC.Text = Me.grd3.GetRowCellDisplayText(intIndexNfe, Me.colRedBC)
        Me.txtNfeICMS.Text = Me.grd3.GetRowCellDisplayText(intIndexNfe, Me.colIcms)
        SelecionarCombo(Me.cboModBCST, Me.grd3.GetRowCellDisplayText(intIndexNfe, Me.colModBCST))
        Me.txtRedBCST.Text = Me.grd3.GetRowCellDisplayText(intIndexNfe, Me.colRedBCST)
        Me.txtMVAST.Text = Me.grd3.GetRowCellDisplayText(intIndexNfe, Me.colMVaST)
        Me.txtICMSST.Text = Me.grd3.GetRowCellDisplayText(intIndexNfe, Me.colIcmsST)

        Me.btnAddNfe.Text = "Alterar"
        Me.btnAddNfe.Image = My.Resources.Alterar_18x18
    End Sub

    Private Sub btnExcluirNfe_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExcluirNfe.Click
        If bolAltNfe = True Then MsgBox("Existe um item sendo alterado, conclua a alteração antes de excluir algum item!", MsgBoxStyle.Information) : Exit Sub
        If grd3.RowCount = 0 Then Exit Sub
        If MsgBox("Deseja realmente excluir esta situação tributaria?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            strItensDeletado &= grd3.GetRowCellDisplayText(grd3.FocusedRowHandle, Me.colCodigo1) & "|"
            Me.grd3.DeleteRow(grd3.FocusedRowHandle)
        End If
    End Sub

    Private Sub btnInsNfeTodos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInsNfeTodos.Click
        If MsgBox("Atenção!" & vbCrLf & "Ao clicar em 'Sim' você informará esses dados de impostos para todos os produtos listados abaixo." & vbCrLf & "Você tem certeza que deseja fazer isso?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim strCst As String = Me.cboNfeCST.Text

            If strCst <> "" Then
                ''If Me.cboRegime.SelectedIndex = 0 Then
                'strCst = strCst.Substring(0, 2)
                'Else
                strCst = strCst.Substring(0, 3)
                'End If
            End If

            Dim strOrig As String = Me.cboOrigem.Text
            If strOrig <> "" Then
                strOrig = strOrig.Substring(0, 1)
            End If

            Dim strModBC As String = Me.cboModBC.Text
            If strModBC <> "" Then
                strModBC = strModBC.Substring(0, 1)
            End If

            Dim strModBCST As String = Me.cboModBCST.Text
            If strModBCST <> "" Then
                strModBCST = strModBCST.Substring(0, 1)
            End If

            Dim strCstIPI As String = Me.cboCSTIPI.Text
            If strCstIPI <> "" Then
                strCstIPI = strCstIPI.Substring(0, 2)
            End If

            Dim strCstPIS As String = Me.cboCSTPIS.Text
            If strCstPIS <> "" Then
                strCstPIS = strCstPIS.Substring(0, 2)
            End If

            Dim strCstCOFINS As String = Me.cboCSTCOFINS.Text
            If strCstCOFINS <> "" Then
                strCstCOFINS = strCstCOFINS.Substring(0, 2)
            End If


            Dim strCstTN As String = Me.cboCstTN.Text

            If strCstTN <> "" Then

                strCstTN = strCstTN.Substring(0, 2)

            End If

            Dim strOrigTN As String = Me.cboOrigemTN.Text
            If strOrigTN <> "" Then
                strOrigTN = strOrigTN.Substring(0, 1)
            End If

            Dim strModBCTN As String = Me.cboModBcTN.Text
            If strModBCTN <> "" Then
                strModBCTN = strModBCTN.Substring(0, 1)
            End If

            Dim strModBCSTTN As String = Me.cboModBcStTN.Text
            If strModBCSTTN <> "" Then
                strModBCSTTN = strModBCSTTN.Substring(0, 1)
            End If

            Dim strCstIPITN As String = Me.cboCstIpiTN.Text
            If strCstIPITN <> "" Then
                strCstIPITN = strCstIPITN.Substring(0, 2)
            End If

            Dim strCstPISTN As String = Me.cboCstPisTN.Text
            If strCstPISTN <> "" Then
                strCstPISTN = strCstPISTN.Substring(0, 2)
            End If

            Dim strCstCOFINSTN As String = Me.cboCstCofinsTN.Text
            If strCstCOFINSTN <> "" Then
                strCstCOFINSTN = strCstCOFINSTN.Substring(0, 2)
            End If
            Dim I As Integer
            Dim intCodigoAutProd As Integer
            Dim bolNCM As Boolean = False
            Dim bolCodigoAnp As Boolean = False
            If MsgBox("Deseja alterar o NCM de todos os produtos listados abaixo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                bolNCM = True
            End If
            If Me.cboCodigoANP.Text <> "" Then
                If MsgBox("Deseja alterar o Código ANP de todos os produtos listados abaixo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    bolCodigoAnp = True
                End If
            End If


            Dim intReg As Integer = Me.XtraTabControl1.SelectedTabPageIndex



            For I = 0 To Me.grd1.RowCount - 1

                intCodigoAutProd = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)
                Dim strTipoFiscal As String = ""

                If TipoFiscal = "AMBOS" Then
                    Select Case Me.cboTipoFiscal.Text
                        Case "NFE"
                            strTipoFiscal = " NFE"

                        Case "SAT"
                            strTipoFiscal = " SAT"
                    End Select
                End If
                Select Case Me.XtraTabControl1.SelectedTabPageIndex

                    Case 0


                        Dim dtTrib As DataTable = CarregarDataTable("SELECT Codigo FROM Tributos where CodProd = " & intCodigoAutProd & " and Regime = 'SIMPLES NACIONAL" & strTipoFiscal & "'")
                        If dtTrib.Rows.Count = 0 Then
                            Inserir("INSERT INTO Tributos (CodProd, CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, " & _
                            "PerCOFINS, Regime) Values (" & intCodigoAutProd & ",'" & strCstIPI & "','" & Me.txtAliquotaIPI.Text & "'," & _
                            "'" & Me.txtCodEnq.Text & "','" & strCstPIS & "','" & Me.txtAliquotaPIS.Text & "'," & _
                            "'" & strCstCOFINS & "','" & Me.txtAliquotaCOFINS.Text & "','SIMPLES NACIONAL" & strTipoFiscal & "')")
                        Else

                            Atualizar("UPDATE Tributos SET CSTIPI = '" & strCstIPI & "', " & _
                            "PerIPI = '" & Me.txtAliquotaIPI.Text & "', CodEnq = '" & Me.txtCodEnq.Text & "', " & _
                            "CSTPIS = '" & strCstPIS & "', PerPIS = '" & Me.txtAliquotaPIS.Text & "', " & _
                            "CSTCOFINS = '" & strCstCOFINS & "', PerCOFINS = '" & Me.txtAliquotaCOFINS.Text & "' " & _
                            "where CodProd = " & intCodigoAutProd & " and Regime = 'SIMPLES NACIONAL" & strTipoFiscal & "'")

                        End If

                        Select Case Me.cboTipoFiscal.Text
                            Case "NFE", "SAT"
                                Excluir("DELETE FROM Tributos where CodProd = " & intCodigoAutProd & " and Regime = 'SIMPLES NACIONAL'")
                            Case "AMBOS"
                                Excluir("DELETE FROM Tributos where CodProd = " & intCodigoAutProd & " and Regime = 'SIMPLES NACIONAL NFE' or CodProd = " & intCodigoAutProd & " and Regime = 'SIMPLES NACIONAL SAT'")
                        End Select


                        Dim dtNfe As DataTable = CarregarDataTable("SELECT Codigo FROM Nfe where CodProd = " & intCodigoAutProd & " and Regime = 'SIMPLES NACIONAL" & strTipoFiscal & "'")

                        If dtNfe.Rows.Count = 0 Then
                            If bolCodigoAnp = True Then
                                Inserir("INSERT INTO Nfe (CodProd, EXTIPI, Genero, CST, Origem, ModBC, ICMS, RedBC, " & _
                                "ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, Regime, CalculoCred, CodigoANP, UFComb, " & _
                                "Cest, PerFCPUF, PerICMSUF) VALUES (" & intCodigoAutProd & ",'" & Me.txtEXTIPI.Text & "'," & _
                                "'" & Me.txtGenero.Text & "','" & strCst & "','" & strOrig & "','" & strModBC & "'," & _
                                "'" & Me.txtNfeICMS.Text.Trim & "','" & Me.txtRedBC.Text.Trim & "','" & strModBCST & "'," & _
                                "'" & Me.txtRedBCST.Text.Trim & "','" & Me.txtMVAST.Text.Trim & "','" & strCfopDoProduto & "'," & _
                                "'" & Me.txtICMSST.Text.Trim & "','" & Me.txtNfeNCM.Text.Trim & "','SIMPLES NACIONAL" & strTipoFiscal & "'," & _
                                "'" & Me.txtCalcCred.Text.Trim & "','" & Me.cboCodigoANP.Text & "','" & Me.cboUF.Text & "'," & _
                                "'" & Me.txtCest.Text & "','" & Me.txtPerFCPUF.Text & "','" & Me.txtPerICMSUF.Text & "')")
                            Else
                                Inserir("INSERT INTO Nfe (CodProd, EXTIPI, Genero, CST, Origem, ModBC, ICMS, RedBC, " & _
                                "ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, Regime, CalculoCred, Cest, PerFCPUF, " & _
                                "PerICMSUF) VALUES (" & intCodigoAutProd & ",'" & Me.txtEXTIPI.Text & "'," & _
                                "'" & Me.txtGenero.Text & "','" & strCst & "','" & strOrig & "','" & strModBC & "'," & _
                                "'" & Me.txtNfeICMS.Text.Trim & "','" & Me.txtRedBC.Text.Trim & "','" & strModBCST & "'," & _
                                "'" & Me.txtRedBCST.Text.Trim & "','" & Me.txtMVAST.Text.Trim & "','" & strCfopDoProduto & "'," & _
                                "'" & Me.txtICMSST.Text.Trim & "','" & Me.txtNfeNCM.Text.Trim & "','SIMPLES NACIONAL" & strTipoFiscal & "'," & _
                                "'" & Me.txtCalcCred.Text.Trim & "','" & Me.txtCest.Text & "','" & Me.txtPerFCPUF.Text & "'," & _
                                "'" & Me.txtPerICMSUF.Text & "')")

                            End If
                        Else
                            Dim strNCMs As String = ""
                            Dim strCodigoAnp As String = ""
                            If bolNCM = True Then
                                strNCMs = " NCM = '" & Me.txtNfeNCM.Text.Trim & "',"
                            End If
                            If bolCodigoAnp = True Then
                                strCodigoAnp = " CodigoANP = '" & Me.cboCodigoANP.Text.Trim & "', UFComb = '" & Me.cboUF.Text & "', "
                            End If
                            Atualizar("UPDATE Nfe SET EXTIPI = '" & Me.txtEXTIPI.Text & "', " & _
                            "Genero = '" & Me.txtGenero.Text & "', CST = '" & strCst & "', Origem = '" & strOrig & "', " & _
                            "ModBC = '" & strModBC & "', ICMS = '" & Me.txtNfeICMS.Text.Trim & "', " & _
                            "RedBC = '" & Me.txtRedBC.Text.Trim & "', ModBCST = '" & strModBCST & "', " & _
                            "RedBCST = '" & Me.txtRedBCST.Text.Trim & "', MVaST = '" & Me.txtMVAST.Text.Trim & "', " & _
                            "CFOP = '" & strCfopDoProduto & "', ICMSST = '" & Me.txtICMSST.Text.Trim & "', " & _
                            "" & strCodigoAnp & strNCMs & " CalculoCred = '" & Me.txtCalcCred.Text.Trim & "', Cest = '" & Me.txtCest.Text & "', " & _
                            "PerFCPUF = '" & Me.txtPerFCPUF.Text & "', PerICMSUF = '" & Me.txtPerICMSUF.Text & "' " & _
                            "where CodProd = " & intCodigoAutProd & " and Regime = 'SIMPLES NACIONAL" & strTipoFiscal & "'")
                        End If

                        Select Case Me.cboTipoFiscal.Text
                            Case "NFE", "SAT"
                                Excluir("DELETE FROM Nfe where CodProd = " & intCodigoAutProd & " and Regime = 'SIMPLES NACIONAL'")
                            Case "AMBOS"
                                Excluir("DELETE FROM Nfe where CodProd = " & intCodigoAutProd & " and Regime = 'SIMPLES NACIONAL NFE' or CodProd = " & intCodigoAutProd & " and Regime = 'SIMPLES NACIONAL SAT'")
                        End Select
                    Case 1
                        Dim dtTrib As DataTable = CarregarDataTable("SELECT Codigo FROM Tributos where CodProd = " & intCodigoAutProd & " and Regime = 'TRIBUTAÇÃO NORMAL" & strTipoFiscal & "'")
                        If dtTrib.Rows.Count = 0 Then
                            Inserir("INSERT INTO Tributos (CodProd, CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, " & _
                            "PerCOFINS, Regime) Values (" & intCodigoAutProd & ",'" & strCstIPITN & "','" & Me.txtAliquotaIpiTN.Text & "'," & _
                            "'" & Me.txtCodEnqTN.Text & "','" & strCstPISTN & "','" & Me.txtAliquotaPisTN.Text & "'," & _
                            "'" & strCstCOFINSTN & "','" & Me.txtAliquotaCofinsTN.Text & "','TRIBUTAÇÃO NORMAL" & strTipoFiscal & "')")
                        Else

                            Atualizar("UPDATE Tributos SET CSTIPI = '" & strCstIPITN & "', " & _
                            "PerIPI = '" & Me.txtAliquotaIpiTN.Text & "', CodEnq = '" & Me.txtCodEnqTN.Text & "', " & _
                            "CSTPIS = '" & strCstPISTN & "', PerPIS = '" & Me.txtAliquotaPisTN.Text & "', " & _
                            "CSTCOFINS = '" & strCstCOFINSTN & "', PerCOFINS = '" & Me.txtAliquotaCofinsTN.Text & "' " & _
                            "where CodProd = " & intCodigoAutProd & " and Regime = 'TRIBUTAÇÃO NORMAL" & strTipoFiscal & "'")

                        End If
                        Select Case Me.cboTipoFiscal.Text
                            Case "NFE", "SAT"
                                Excluir("DELETE FROM Tributos where CodProd = " & intCodigoAutProd & " and Regime = 'TRIBUTAÇÃO NORMAL'")
                            Case "AMBOS"
                                Excluir("DELETE FROM Tributos where CodProd = " & intCodigoAutProd & " and Regime = 'TRIBUTAÇÃO NORMAL NFE' or CodProd = " & intCodigoAutProd & " and Regime = 'TRIBUTAÇÃO NORMAL SAT'")
                        End Select

                        Dim dtNfe As DataTable = CarregarDataTable("SELECT Codigo FROM Nfe where CodProd = " & intCodigoAutProd & " and Regime = 'TRIBUTAÇÃO NORMAL" & strTipoFiscal & "'")

                        If dtNfe.Rows.Count = 0 Then
                            If bolCodigoAnp = True Then
                                Inserir("INSERT INTO Nfe (CodProd, EXTIPI, Genero, CST, Origem, ModBC, ICMS, RedBC, " & _
                                "ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, Regime, CalculoCred, CodigoANP, UFComb, " & _
                                "Cest, PerFCPUF, PerICMSUF) VALUES (" & intCodigoAutProd & ",'" & Me.txtEXTIPI.Text & "'," & _
                                "'" & Me.txtGenero.Text & "','" & strCstTN & "','" & strOrigTN & "','" & strModBCTN & "'," & _
                                "'" & Me.txtIcmsTN.Text.Trim & "','" & Me.txtRedBcTN.Text.Trim & "','" & strModBCSTTN & "'," & _
                                "'" & Me.txtRedBcStTN.Text.Trim & "','" & Me.txtMvaStTN.Text.Trim & "','" & strCfopDoProduto & "'," & _
                                "'" & Me.txtIcmsStTN.Text.Trim & "','" & Me.txtNfeNCM.Text.Trim & "','TRIBUTAÇÃO NORMAL" & strTipoFiscal & "'," & _
                                "'" & Me.txtCalcCredTN.Text.Trim & "','" & Me.cboCodigoANP.Text & "','" & Me.cboUF.Text & "'," & _
                                "'" & Me.txtCest.Text & "','" & Me.txtPercFcpTN.Text & "','" & Me.txtPercIcmsTN.Text & "')")
                            Else
                                Inserir("INSERT INTO Nfe (CodProd, EXTIPI, Genero, CST, Origem, ModBC, ICMS, RedBC, " & _
                                "ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, Regime, CalculoCred, Cest, PerFCPUF, " & _
                                "PerICMSUF) VALUES (" & intCodigoAutProd & ",'" & Me.txtEXTIPI.Text & "'," & _
                                "'" & Me.txtGenero.Text & "','" & strCstTN & "','" & strOrigTN & "','" & strModBCTN & "'," & _
                                "'" & Me.txtIcmsTN.Text.Trim & "','" & Me.txtRedBcTN.Text.Trim & "','" & strModBCSTTN & "'," & _
                                "'" & Me.txtRedBcStTN.Text.Trim & "','" & Me.txtMvaStTN.Text.Trim & "','" & strCfopDoProduto & "'," & _
                                "'" & Me.txtIcmsStTN.Text.Trim & "','" & Me.txtNfeNCM.Text.Trim & "','TRIBUTAÇÃO NORMAL" & strTipoFiscal & "'," & _
                                "'" & Me.txtCalcCredTN.Text.Trim & "','" & Me.txtCest.Text & "','" & Me.txtPercFcpTN.Text & "'," & _
                                "'" & Me.txtPercIcmsTN.Text & "')")

                            End If
                        Else
                            Dim strNCMs As String = ""
                            Dim strCodigoAnp As String = ""
                            If bolNCM = True Then
                                strNCMs = " NCM = '" & Me.txtNfeNCM.Text.Trim & "',"
                            End If
                            If bolCodigoAnp = True Then
                                strCodigoAnp = " CodigoANP = '" & Me.cboCodigoANP.Text.Trim & "', UFComb = '" & Me.cboUF.Text & "', "
                            End If
                            Atualizar("UPDATE Nfe SET EXTIPI = '" & Me.txtEXTIPI.Text & "', " & _
                            "Genero = '" & Me.txtGenero.Text & "', CST = '" & strCstTN & "', Origem = '" & strOrigTN & "', " & _
                            "ModBC = '" & strModBCTN & "', ICMS = '" & Me.txtIcmsTN.Text.Trim & "', " & _
                            "RedBC = '" & Me.txtRedBcTN.Text.Trim & "', ModBCST = '" & strModBCSTTN & "', " & _
                            "RedBCST = '" & Me.txtRedBcStTN.Text.Trim & "', MVaST = '" & Me.txtMvaStTN.Text.Trim & "', " & _
                            "CFOP = '" & strCfopDoProduto & "', ICMSST = '" & Me.txtIcmsStTN.Text.Trim & "', " & _
                            "" & strCodigoAnp & strNCMs & " CalculoCred = '" & Me.txtCalcCredTN.Text.Trim & "', Cest = '" & Me.txtCest.Text & "', " & _
                            "PerFCPUF = '" & Me.txtPercFcpTN.Text & "', PerICMSUF = '" & Me.txtPercIcmsTN.Text & "' " & _
                            "where CodProd = " & intCodigoAutProd & " and Regime = 'TRIBUTAÇÃO NORMAL" & strTipoFiscal & "'")
                        End If

                        Select Case Me.cboTipoFiscal.Text
                            Case "NFE", "SAT"
                                Excluir("DELETE FROM Nfe where CodProd = " & intCodigoAutProd & " and Regime = 'TRIBUTAÇÃO NORMAL'")
                            Case "AMBOS"
                                Excluir("DELETE FROM Nfe where CodProd = " & intCodigoAutProd & " and Regime = 'TRIBUTAÇÃO NORMAL NFE' or CodProd = " & intCodigoAutProd & " and Regime = 'TRIBUTAÇÃO NORMAL SAT'")
                        End Select
                End Select

               

                
                


                
                'Excluir("DELETE FROM Nfe where CodProd =" & intCodigoAutProd)
                'Excluir("DELETE FROM Tributos where CodProd =" & intCodigoAutProd)
            Next

            MsgBox("Dados inseridos com sucesso!", MsgBoxStyle.Information)

            Limpar()

        End If
    End Sub

    Private Sub cboCSTIPI_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCSTIPI.KeyPress, txtObs.KeyPress, txtCodBarra.KeyPress, cboCstIpiTN.KeyPress
        If e.KeyChar = "'" Or e.KeyChar = "&" Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnConPed_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConPed.ItemClick

        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub

        Dim strCodProd As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)
        Dim strNomeProd As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colNome)
        Dim dt As DataTable = CarregarDataTable("SELECT ItensConsig.CodOrdens FROM ItensConsig left join TotalConsig on ItensConsig.CodOrdens = TotalConsig.CodOrdens and ItensConsig.CodConfig = TotalConsig.CodConfig where CodigoProduto = " & strCodProd & " and Status <> 'Faturado' and Status <> 'Excluído' and ItensConsig.CodConfig = " & CodConfig)

        Dim I As Integer
        If dt.Rows.Count > 0 Then
            Dim strCodOrdem As String = ""

            For I = 0 To dt.Rows.Count - 1
                strCodOrdem = strCodOrdem & dt.Rows.Item(I).Item("CodOrdens").ToString & vbNewLine
            Next
            MsgBox("O produto " & strNomeProd & " está presente no(s) seguinte(s) pedido(s) em aberto:" & vbNewLine & strCodOrdem, MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtAlterarQtd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAlterarQtd.KeyPress
        Select Case cboUniMed.Text
            Case "UN", "JG", "KIT"
                If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
                    e.Handled = True
                End If
            Case Else
                If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "," Then
                    e.Handled = True
                End If
        End Select
    End Sub

    Private Sub txtAlterarQtd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterarQtd.Leave
        If Me.grd2.FocusedRowHandle < 0 Then Exit Sub

        If Me.grd2.FocusedColumn.Name = "colQtd" Or Me.grd2.FocusedColumn.Name = "colQtdMinima" Or Me.grd2.FocusedColumn.Name = "colQtdMaxima" Then
            If Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.grd2.FocusedColumn).Trim = "" Then
                Me.grd2.SetRowCellValue(Me.grd2.FocusedRowHandle, grd2.FocusedColumn, 0)
            End If
        End If

    End Sub

    Private Sub tabProd_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles tabProd.SelectedPageChanged

        Select Case Me.tabProd.SelectedTabPageIndex
            Case 1
                If Me.txtNCMImpProd.Text = "" Then
                    If Me.txtNfeNCM.Text <> "" Then
                        Me.txtNCMImpProd.Text = Me.txtNfeNCM.Text
                    End If
                End If
                
            Case 2
                If Me.txtNfeNCM.Text = "" Then
                    If Me.txtNCMImpProd.Text <> "" Then
                        Me.txtNfeNCM.Text = Me.txtNCMImpProd.Text
                    End If
                End If
              
                Me.tabImpostos.SelectedTabPageIndex = 0
            Case 3
        End Select
    End Sub

   
    Private Sub cboOrigECF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOrigECF.SelectedIndexChanged
        Select Case Me.cboOrigECF.SelectedIndex

            Case 0

                Me.cboCst.Properties.Items.Clear()
                Me.cboCst.Properties.Items.Add("101")
                Me.cboCst.Properties.Items.Add("102")
                Me.cboCst.Properties.Items.Add("103")
                Me.cboCst.Properties.Items.Add("201")
                Me.cboCst.Properties.Items.Add("202")
                Me.cboCst.Properties.Items.Add("203")
                Me.cboCst.Properties.Items.Add("300")
                Me.cboCst.Properties.Items.Add("400")
                Me.cboCst.Properties.Items.Add("500")
                Me.cboCst.Properties.Items.Add("900")

                Me.cboCst2.Properties.Items.Clear()
                Me.cboCst2.Properties.Items.Add("101 - Tributada com permissão de crédito")
                Me.cboCst2.Properties.Items.Add("102 - Tributada sem permissão de crédito")
                Me.cboCst2.Properties.Items.Add("103 - Isenção do ICMS para faixa de receita bruta")
                Me.cboCst2.Properties.Items.Add("201 - Tributada com permissão de crédito e com cobrança do ICMS por ST")
                Me.cboCst2.Properties.Items.Add("202 - Tributada sem permissão de crédito e com cobrança do ICMS por ST")
                Me.cboCst2.Properties.Items.Add("203 - Isenção do ICMS para faixa de receita bruta e com cobrança do ICMS por ST")
                Me.cboCst2.Properties.Items.Add("300 - Imune")
                Me.cboCst2.Properties.Items.Add("400 - Não Tributada")
                Me.cboCst2.Properties.Items.Add("500 - ICMS cobrado anteriormente por ST ou por antecipação")
                Me.cboCst2.Properties.Items.Add("900 - Outros")

            Case 1

                Me.cboCst.Properties.Items.Clear()
                Me.cboCst.Properties.Items.Add("00")
                Me.cboCst.Properties.Items.Add("10")
                Me.cboCst.Properties.Items.Add("20")
                Me.cboCst.Properties.Items.Add("30")
                Me.cboCst.Properties.Items.Add("40")
                Me.cboCst.Properties.Items.Add("41")
                Me.cboCst.Properties.Items.Add("50")
                Me.cboCst.Properties.Items.Add("51")
                Me.cboCst.Properties.Items.Add("60")
                Me.cboCst.Properties.Items.Add("70")
                Me.cboCst.Properties.Items.Add("90")

                Me.cboCst2.Properties.Items.Clear()
                Me.cboCst2.Properties.Items.Add("00 - Tributado Integralmente")
                Me.cboCst2.Properties.Items.Add("10 - Tributado com cobrança do ICMS por ST")
                Me.cboCst2.Properties.Items.Add("20 - Com redução de base de cálculo")
                Me.cboCst2.Properties.Items.Add("30 - Isenta ou não tributada e com cobrança de ICMS por ST")
                Me.cboCst2.Properties.Items.Add("40 - Isenta")
                Me.cboCst2.Properties.Items.Add("41 - Não tributada")
                Me.cboCst2.Properties.Items.Add("50 - Suspensão")
                Me.cboCst2.Properties.Items.Add("51 - Diferimento")
                Me.cboCst2.Properties.Items.Add("60 - ICMS cobrado anteriormente por ST")
                Me.cboCst2.Properties.Items.Add("70 - Com redução de base de cálculo e cobrança por ST")
                Me.cboCst2.Properties.Items.Add("90 - Outros")

        End Select
    End Sub

    Private Sub btnPesquisa_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPesquisa.ItemClick
        frmPesquisaImp.Tag = "PESQUISA"
        frmPesquisaImp.Show()
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relProduto

        rel.picLogo.Image = LogoTipo
        Dim dblQtd As Double
        Dim dblTotal As Double
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
                    If CDbl(Me.grd1.GetRowCellDisplayText(I, Me.colQtd1)) > 0 Then
                        dblQtd += CDbl(Me.grd1.GetRowCellDisplayText(I, Me.colQtd1))
                        dblTotal += CDbl(Me.grd1.GetRowCellDisplayText(I, Me.colQtd1)) * CDbl(Me.grd1.GetRowCellDisplayText(I, Me.colValor))
                    End If
                   A += 1
                End If
            Next
        End With
        rel.lblPro.Text = dblQtd.ToString("###,###,##0.000")
        rel.lblTotal.Text = dblTotal.ToString("###,###,##0.00")
        rel.ShowPreview()
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl2.ShowPrintPreview()
    End Sub

    Private Sub txtNCMImpProd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNCMImpProd.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNCMImpProd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNCMImpProd.Leave
        If Me.txtNCMImpProd.Text = "" Then Exit Sub
        Dim strNCM As String = Me.txtNCMImpProd.Text

        If strNCM.Length = 1 Then
            MsgBox("O campo NCM só aceita de 2 a 8 caracteres!", MsgBoxStyle.Information)
            Me.txtNCMImpProd.ResetText()
            Me.txtNCMImpProd.Focus()
        End If
    End Sub
    Private Sub CFOPCombustivel()
        Combustivel(False)
        ' Dim strCFOP As String = Me.lueCFOP.EditValue
        Dim strCFOP As String = ""
        If Me.lueCFOP.EditValue Is DBNull.Value = False Then

            strCFOP = Me.lueCFOP.EditValue
        End If
        If strCFOP <> "Nothing" And strCFOP <> "" Then
            Dim intCFOP As Integer = Me.lueCFOP.EditValue


            If intCFOP >= 1651 And intCFOP <= 1664 Then

                Combustivel(True)
            ElseIf intCFOP >= 2651 And intCFOP <= 2664 Then
                Combustivel(True)

            ElseIf intCFOP >= 3651 And intCFOP <= 3653 Then
                Combustivel(True)

            ElseIf intCFOP >= 5651 And intCFOP <= 5667 Then
                Combustivel(True)
            ElseIf intCFOP >= 6651 And intCFOP <= 6667 Then
                Combustivel(True)
            ElseIf intCFOP >= 7651 And intCFOP <= 7667 Then
                Combustivel(True)
            Else
                Combustivel(False)
            End If
        End If
    End Sub
    Private Sub Combustivel(ByVal parCombustivel As Boolean)
        If parCombustivel = True Then
            Me.cboCodigoANP.Text = ""
            Me.cboUF.Text = "SP"
            Me.cboCodigoANP.Enabled = True
            Me.cboUF.Enabled = True
        Else
            Me.cboCodigoANP.Text = ""
            Me.cboUF.Text = "SP"
            Me.cboCodigoANP.Enabled = False
            Me.cboUF.Enabled = False
        End If
    End Sub

    Private Sub lueCFOP_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueCFOP.EditValueChanged
        CFOPCombustivel()
    End Sub
    Private Sub lueCFOP_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueCFOP.TextChanged
        If EmiteNFE = True Or AbaSatFiscal = True Or NANONFCe = True Then
            strCfopDoProduto = Me.lueCFOP.Text
        End If
    End Sub

    Private Sub btnTribPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTribPadrao.Click
        Dim frm As New frmPesquisaImp
        frm.Size = New System.Drawing.Size(900, 600)

        Dim strTipoFiscal As String = "AMBOS"
        If TipoFiscal = "AMBOS" Then
            Select Case Me.cboTipoFiscal.Text
                Case "NFE"
                    strTipoFiscal = "NFE"
                Case "SAT"
                    strTipoFiscal = "SAT"
            End Select
        End If
        frm.cboTipoFiscal.Text = strTipoFiscal
        frm.ShowDialog()
    End Sub
    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub
    Private Sub btnManterQtd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManterQtd.Click
        ConfigurarGrid(Me.grd2, Me, False, Me.btnPadraoQtd)
    End Sub

    Private Sub btnPadraoQtd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadraoQtd.Click
        ConfigurarGridPadrao(Me, Me.btnPadraoQtd)
    End Sub
    Private Sub grd1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grd1.FocusedRowChanged
        If Me.grd1.FocusedRowHandle < 0 Then
            '    Me.picImagem3.Image = Nothing
            '    Me.picImagem4.Image = Nothing
            '    'Me.txtObs.ResetText()
            Exit Sub
        End If

        'If TipoNano = 2 Then
        '    Me.txtObs.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colObs)
        'End If

        CarregarImagem(Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo))
    End Sub
    Private Sub nbcImagem_NavPaneStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nbcImagem.NavPaneStateChanged
        If nbcImagem.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed Then
            'Me.nbgImagem.Caption = "IMAGEM"
            If TipoNano = 2 Then
                'Me.txtObs.Size = New System.Drawing.Size(786, 32)
                Me.txtObs.Size = New System.Drawing.Size(770, 32)
                Me.PanelControl10.Size = New System.Drawing.Size(773, 5)
            End If

            Me.nbgImagem.GroupClientHeight = 80
            Me.nbgQuantidade.GroupClientHeight = 80
            Me.btnOcultar.Visible = False
            Me.SimpleButton2.Visible = False
            Me.nbcImagem.Size = New System.Drawing.Size(37, 237)
            Me.nbcImagem.Location = New System.Drawing.Point(962, -1)

            Me.nbcImagem.Groups.Item(0).Visible = True
            Me.nbcImagem.Groups.Item(1).Visible = True
        Else
            Me.SimpleButton2.Visible = True
            Me.nbgImagem.Caption = "Imagem"
            Me.nbgQuantidade.Caption = "Quantidade"

            Me.nbcImagem.PaintStyleName = "ExplorerBarView"
            Me.nbcImagem.Appearance.GroupBackground.BackColor = Color.Transparent
            Me.nbcImagem.Appearance.Background.BackColor = Color.Transparent
            Me.nbgImagem.Appearance.BackColor = Color.Transparent
            Me.nbgQuantidade.Appearance.BackColor = Color.Transparent
            Me.nbgImagem.GroupClientHeight = 185
            Me.nbgQuantidade.GroupClientHeight = 185
            '211
            Me.nbgQuantidade.Expanded = True
          
            'If Me.nbcImagem.ActiveGroup.Name.ToString.Trim = "nbgQuantidade" Then
            '    Me.nbcImagem.Groups.Item(0).Visible = False
            '    Me.SimpleButton2.Visible = True
            '    If TipoNano = 2 Then
            '        Me.txtObs.Size = New System.Drawing.Size(343, 32)
            '        Me.PanelControl10.Size = New System.Drawing.Size(346, 5)
            '    End If


            '    Me.nbcImagem.PaintStyleName = "ExplorerBarView"

            '    Me.nbcImagem.Appearance.GroupBackground.BackColor = Color.Transparent
            '    Me.nbcImagem.Appearance.Background.BackColor = Color.Transparent
            '    Me.nbgQuantidade.GroupClientHeight = 160

            '    Me.nbgQuantidade.Appearance.BackColor = Color.Transparent

            '    Me.nbgQuantidade.Expanded = True

            'ElseIf Me.nbcImagem.ActiveGroup.Name.ToString.Trim = "nbgImagem" Then
            '    Me.nbcImagem.Groups.Item(1).Visible = False

            '    Me.btnOcultar.Visible = True
            '    If TipoNano = 2 Then
            '        'Me.txtObs.Size = New System.Drawing.Size(357, 32)
            '        'Me.txtObs.Size = New System.Drawing.Size(348, 32)
            '        Me.txtObs.Size = New System.Drawing.Size(343, 32)
            '        Me.PanelControl10.Size = New System.Drawing.Size(346, 5)
            '    End If


            '    Me.nbcImagem.PaintStyleName = "ExplorerBarView"

            '    Me.nbcImagem.Appearance.GroupBackground.BackColor = Color.Transparent
            '    Me.nbcImagem.Appearance.Background.BackColor = Color.Transparent
            '    Me.nbgImagem.GroupClientHeight = 211
            '    Me.nbgImagem.Appearance.BackColor = Color.Transparent

            '    Me.nbgImagem.Expanded = True
            'End If

            'Me.btnOcultar.Visible = True
            'If TipoNano = 2 Then
            '    'Me.txtObs.Size = New System.Drawing.Size(357, 32)
            '    Me.txtObs.Size = New System.Drawing.Size(348, 32)
            'End If
            'Me.nbgImagem.Caption = ""
            'Me.nbcImagem.PaintStyleName = "ExplorerBarView"
            'Me.nbcImagem.Appearance.GroupBackground.BackColor = Color.Transparent
            'Me.nbcImagem.Appearance.Background.BackColor = Color.Transparent
            'Me.nbgImagem.GroupClientHeight = 211
            'Me.nbgImagem.Appearance.BackColor = Color.Transparent
            'Me.nbgImagem.Expanded = True

        End If
    End Sub
    Private Sub nbgImagem_ItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbgImagem.ItemChanged
        If Me.nbgImagem.Expanded = False Then
            Me.nbgQuantidade.Expanded = True
        Else
            'Dim ssas As String = Me.nbcImagem.Groups(0).DragDropFlags

            ' Me.nbcImagem.Groups(1).DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.AllowDrop
            'Me.nbcImagem.Groups(1).ItemLinks.Move(1, 0)

            Me.nbgQuantidade.Expanded = False
        End If
    End Sub

    Private Sub nbgQuantidade_ItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbgQuantidade.ItemChanged
        If Me.nbgQuantidade.Expanded = False Then
            Me.nbgImagem.Expanded = True

        Else
            Me.nbgImagem.Expanded = False
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

    Private Sub btnImpCupom_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImpCupom.ItemClick
        frmPesquisaImp.Tag = "CUPOM"
        frmPesquisaImp.Show()
    End Sub
    Private Sub Historico(ByVal parPeriodo As Boolean)

        Dim strFiltroEntradaNF As String = ""

        If parPeriodo = True Then

            Dim data1, data2 As String
            data1 = dtInicial.EditValue
            data2 = dtFinal.EditValue

            If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Sub
            If data2 = "" Then MsgBox("Selecione a Data Final!", MsgBoxStyle.Information) : Exit Sub

            Dim dataFim, dataIni As Date
            dataIni = data1
            dataFim = data2

            If dataIni > dataFim Then MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information) : Exit Sub
          
            strFiltroEntradaNF = " and " & String.Format("TotalEntradaNF.Data >= '{0:dd/MM/yyyy}' AND TotalEntradaNF.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue)
        End If

        Me.tbFor.Rows.Clear()
        Dim strFiltro As String = ""
        Dim dt1 As DataTable
        If Master = False Then
            strFiltro = " and EntradaNF.CodConfig = " & CodConfig
            dt1 = CarregarDataTable("SELECT NumeroNF, Qtd, ValorCusto as ValCusto, ValorUnitario, ValorTotal, Fornecedor.Nome as Fornecedor, " & _
            "EntradaNF.CodProdFor as Codigo, TotalEntradaNF.Data as Data, QtdProd FROM (EntradaNF left join TotalEntradaNF " & _
            "on EntradaNF.CodTotNF = TotalEntradaNF.Codigo and EntradaNF.CodConfig = TotalEntradaNF.CodConfig) left join " & _
            "Fornecedor on TotalEntradaNF.CodFor = Fornecedor.Codigo where CodProd = " & intCodPro & strFiltro & strFiltroEntradaNF)
        Else
            dt1 = CarregarDataTable("SELECT NumeroNF, Qtd, ValorCusto as ValCusto, ValorUnitario, ValorTotal, Fornecedor.Nome as Fornecedor, " & _
            "EntradaNF.CodProdFor as Codigo, TotalEntradaNF.Data as Data, QtdProd FROM (EntradaNF left join TotalEntradaNF " & _
            "on EntradaNF.CodTotNF = TotalEntradaNF.Codigo) left join " & _
            "Fornecedor on TotalEntradaNF.CodFor = Fornecedor.Codigo where CodProd = " & intCodPro & strFiltro & strFiltroEntradaNF)
        End If


        With Me.tbFor.Rows
            For I = 0 To dt1.Rows.Count - 1
                .Add()
                .Item(I).Item("Fornecedor") = dt1.Rows.Item(I).Item("Fornecedor").ToString
                .Item(I).Item("Data") = dt1.Rows.Item(I).Item("Data")
                .Item(I).Item("Qtd") = dt1.Rows.Item(I).Item("Qtd").ToString
                .Item(I).Item("ValorUnitario") = dt1.Rows.Item(I).Item("ValorUnitario").ToString
                .Item(I).Item("ValorTotal") = dt1.Rows.Item(I).Item("ValorTotal").ToString
                .Item(I).Item("Codigo") = dt1.Rows.Item(I).Item("Codigo").ToString
                .Item(I).Item("NumeroNF") = dt1.Rows.Item(I).Item("NumeroNF").ToString
                .Item(I).Item("QtdProd") = dt1.Rows.Item(I).Item("QtdProd").ToString
                .Item(I).Item("ValCusto") = dt1.Rows.Item(I).Item("ValCusto").ToString
            Next
        End With



        If Master = False Then
            strFiltro = " and CodConfig = " & CodConfig
        End If

        dt1 = CarregarDataTable("SELECT Convert(Numeric(15,3), Qtd) as Qtd, CodConfig FROM Qtde left join Config on Qtde.CodConfig = Config.Codigo where CodProd = " & intCodPro & " and Acabou = 'False'" & strFiltro & " order by CodConfig")
        Dim strVerificaCodConfig As String = ""
        Dim A As Integer = 0
        Dim dblQtdSomada As Double = 0
        Dim dblQtd As Double = 0
        If dt1.Rows.Count > 0 Then

            If EstoqueSomado = False Then
                For I = 0 To dt1.Rows.Count - 1
                    dblQtdSomada += dt1.Rows.Item(I).Item("Qtd").ToString
                Next
            Else
                For I = 0 To dt1.Rows.Count - 1
                    If strVerificaCodConfig <> dt1.Rows.Item(I).Item("CodConfig").ToString Then
                        strVerificaCodConfig = dt1.Rows.Item(I).Item("CodConfig")

                        If EstoqueSomado = True Then
                            If I < QtdeLoja Then
                                Dim strLoja As String = dt1.Rows.Item(I).Item("CodConfig").ToString
                                Dim dblResul As Double = AjusteQtde(strLoja, intCodPro)
                                dblQtdSomada += dblResul
                            End If
                        Else
                            dblQtdSomada += dt1.Rows.Item(I).Item("Qtd").ToString
                        End If
                        A += 1
                    End If
                Next
            End If
        End If
        Select Case cboUniMed.SelectedIndex
            Case 0, 1, 2
                dblQtd = dblQtdSomada
            Case 3, 4
                dblQtd = dblQtdSomada.ToString("0.000")
            Case 5
                dblQtd = dblQtdSomada.ToString("0.00")
            Case Else
                dblQtd = dblQtdSomada.ToString("0.000")
        End Select
        Me.txtQtdEstoque.Text = dblQtd


        Dim strQtdes As String
        Select Case cboUniMed.SelectedIndex
            Case 0, 1, 2
                strQtdes = "Convert(Numeric(15), sum(Qtd)) as Qtd"
            Case 3, 4
                strQtdes = "Convert(Numeric(15,3), sum(Qtd)) as Qtd"
            Case 5
                strQtdes = "Convert(Numeric(15,2), sum(Qtd)) as Qtd"
            Case Else
                strQtdes = "Convert(Numeric(15,3), sum(Qtd)) as Qtd"
        End Select

        If Master = False And parPeriodo = True Then
            strFiltro = " and TotalEntradaNF.CodConfig = " & CodConfig
        End If

        If parPeriodo = True Then
            Dim strPeriodo As String = String.Format("TotalEntradaNF.Data >= '{0:dd/MM/yyyy}' AND TotalEntradaNF.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue)
            dt1 = CarregarDataTable("SELECT " & strQtdes & " FROM EntradaNF left join TotalEntradaNF " & _
            "on EntradaNF.CodTotNF = TotalEntradaNF.Codigo and EntradaNF.CodConfig = TotalEntradaNF.CodConfig " & _
            "where CodProd = " & intCodPro & strFiltro & " and " & strPeriodo)

        Else
            If NomeEmpresa.Contains("JÉSSICA COSMÉTICOS") = True Then
                strQtdes = strQtdes.Replace("sum(Qtd)", "sum(QtdProd)")
                dt1 = CarregarDataTable("SELECT " & strQtdes & " FROM EntradaNF where CodProd = " & intCodPro & strFiltro)
                strQtdes = strQtdes.Replace("sum(QtdProd)", "sum(Qtd)")
            Else
                dt1 = CarregarDataTable("SELECT " & strQtdes & " FROM EntradaNF where CodProd = " & intCodPro & strFiltro)
            End If
            
        End If


        If Master = False And parPeriodo = True Then
            strFiltro = " and Total.CodConfig = " & CodConfig
        End If

        If dt1.Rows.Count > 0 Then
            If dt1.Rows.Item(0).Item("Qtd").ToString <> "" Then
                Me.txtQtdComprada.Text = dt1.Rows.Item(0).Item("Qtd").ToString
            Else
                Me.txtQtdComprada.Text = "0"
            End If

        Else
            Me.txtQtdComprada.Text = "0"
        End If
        If parPeriodo = True Then
            Dim strPeriodo As String = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue)

            dt1 = CarregarDataTable("SELECT " & strQtdes & " FROM Pedido left join Total " & _
            "on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig " & _
            "where CodProd = " & intCodPro & " and " & strPeriodo & " and Devolvido = 'False'" & strFiltro)

        Else
            dt1 = CarregarDataTable("SELECT " & strQtdes & " FROM Pedido where CodProd = " & intCodPro & " and Devolvido = 'False'" & strFiltro)

        End If

        If Master = False Then
            strFiltro = " and CodConfig = " & CodConfig
        End If
    
        If dt1.Rows.Count > 0 Then
            If dt1.Rows.Item(0).Item("Qtd").ToString <> "" Then
                Me.txtQtdVendida.Text = dt1.Rows.Item(0).Item("Qtd").ToString
            Else
                Me.txtQtdVendida.Text = "0"
            End If

        Else
            Me.txtQtdVendida.Text = "0"
        End If

        Select Case cboUniMed.SelectedIndex
            Case 0, 1, 2
                strQtdes = "Convert(Numeric(15), sum(Qtde)) as Qtd"
            Case 3, 4
                strQtdes = "Convert(Numeric(15,3), sum(Qtde)) as Qtd"
            Case 5
                strQtdes = "Convert(Numeric(15,2), sum(Qtde)) as Qtd"
            Case Else
                strQtdes = "Convert(Numeric(15,3), sum(Qtde)) as Qtd"
        End Select
        If parPeriodo = True Then
            Dim strPeriodo As String = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue)

            dt1 = CarregarDataTable("SELECT " & strQtdes & " FROM Devolucao where CodProd = " & intCodPro & strFiltro & " and " & strPeriodo)

        Else
            dt1 = CarregarDataTable("SELECT " & strQtdes & " FROM Devolucao where CodProd = " & intCodPro & strFiltro)

        End If
      
        If dt1.Rows.Count > 0 Then
            If dt1.Rows.Item(0).Item("Qtd").ToString <> "" Then
                Me.txtQtdDevolvida.Text = dt1.Rows.Item(0).Item("Qtd").ToString
            Else
                Me.txtQtdDevolvida.Text = "0"
            End If

        Else
            Me.txtQtdDevolvida.Text = "0"
        End If
        If parPeriodo = True Then
            Dim strPeriodo As String = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue)
            dt1 = CarregarDataTable("SELECT " & strQtdes & " FROM Descarte where CodProd = " & intCodPro & strFiltro & " and " & strPeriodo)
        Else
            dt1 = CarregarDataTable("SELECT " & strQtdes & " FROM Descarte where CodProd = " & intCodPro & strFiltro)
        End If


        If dt1.Rows.Count > 0 Then
            If dt1.Rows.Item(0).Item("Qtd").ToString <> "" Then
                Me.txtQtdDescarte.Text = dt1.Rows.Item(0).Item("Qtd").ToString
            Else
                Me.txtQtdDescarte.Text = "0"
            End If

        Else
            Me.txtQtdDescarte.Text = "0"
        End If



        If parPeriodo = True Then
            If Me.colVU.Visible = True Then
                Dim I As Integer

                For I = 0 To Me.grd2.RowCount - 1
                    Dim strCodLoja As String = Me.grd2.GetRowCellDisplayText(I, Me.colCodConfig)

                    Dim strPeriodo As String = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue)
                    Me.grd2.SetRowCellValue(I, Me.colVU, "")
                    Dim dtPed As DataTable = CarregarDataTable("SELECT convert(Numeric(15,3),sum(Pedido.Qtd)) as Qtd FROM Pedido left join Total " & _
                    "on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig " & _
                    "where CodProd = " & intCodPro & " and " & strPeriodo & " and Devolvido = 'False' and Pedido.CodConfig = " & strCodLoja)

                    If dtPed.Rows.Count > 0 Then
                        Me.grd2.SetRowCellValue(I, Me.colVU, dtPed.Rows.Item(0).Item("Qtd").ToString)
                    End If

                Next
            End If
            
        End If
    End Sub

    Private Sub CarregarAjuste()
        Me.tbAjuste.Rows.Clear()
        Dim strFiltro As String = ""

        If Master = False Then
            strFiltro = " and CodConfig = " & CodConfig
        End If

        Dim dt As DataTable = CarregarDataTable("SELECT AjusteQtde.Codigo, AjusteQtde.Tabela, AjusteQtde.Data, AjusteQtde.Qtd, " & _
        "AjusteQtde.CodConfig, Produto.CodigoInterno, Produto.Nome, Produto.Codigo as CodProd " & _
        "From AjusteQtde Left Join Produto on AjusteQtde.CodProd = Produto.Codigo Where CodProd = " & intCodPro & strFiltro)

        With Me.tbAjuste.Rows
            For I = 0 To dt.Rows.Count - 1
                .Add()
                .Item(I).Item("Codigo") = dt.Rows.Item(I).Item("Codigo").ToString
                .Item(I).Item("CodProd") = dt.Rows.Item(I).Item("CodProd").ToString
                .Item(I).Item("CodInterno") = dt.Rows.Item(I).Item("CodigoInterno").ToString
                .Item(I).Item("Nome") = dt.Rows.Item(I).Item("Nome").ToString
                .Item(I).Item("Tabela") = dt.Rows.Item(I).Item("Tabela").ToString
                'Dim vetData As Array = dt.Rows.Item(I).Item("Data").ToString.Split(" ")
                '.Item(I).Item("Data") = vetData(0).ToString.Trim()
                .Item(I).Item("Data") = dt.Rows.Item(I).Item("Data")
                .Item(I).Item("Qtd") = dt.Rows.Item(I).Item("Qtd").ToString
                .Item(I).Item("CodConfig") = dt.Rows.Item(I).Item("CodConfig").ToString
            Next
        End With

    End Sub
 
    Private Sub btnCarregarImagem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregarImagem1.Click
        ofdImagem.FileName = ""
        ofdImagem.ShowDialog()
        If ofdImagem.FileName <> "" Then
            Me.picImagem3.Image = System.Drawing.Bitmap.FromFile(ofdImagem.FileName)
            Dim intw As Integer = Me.picImagem3.Image.Width
            Dim inth As Integer = Me.picImagem3.Image.Height
            inth = (180 * inth) / intw

            Dim dest_image As New Bitmap(180, inth)
            Dim g As Graphics = Graphics.FromImage(dest_image)
            g.DrawImage(System.Drawing.Bitmap.FromFile(ofdImagem.FileName), 0, 0, dest_image.Width + 1, dest_image.Height + 1)
            Me.picImagem3.Image = dest_image

        End If
    End Sub

    Private Sub btnCarregarImage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregarImage2.Click
        ofdImagem.FileName = ""
        ofdImagem.ShowDialog()
        If ofdImagem.FileName <> "" Then
            Me.picImagem4.Image = System.Drawing.Bitmap.FromFile(ofdImagem.FileName)
            Dim intw As Integer = Me.picImagem4.Image.Width
            Dim inth As Integer = Me.picImagem4.Image.Height
            inth = (180 * inth) / intw

            Dim dest_image As New Bitmap(180, inth)
            Dim g As Graphics = Graphics.FromImage(dest_image)
            g.DrawImage(System.Drawing.Bitmap.FromFile(ofdImagem.FileName), 0, 0, dest_image.Width + 1, dest_image.Height + 1)
            Me.picImagem4.Image = dest_image
        End If
    End Sub

    Private Sub btnTirarImagem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTirarImagem1.Click
        frmWebCam.Tag = "PRODUTO1"

        If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\MyCam") = True Then
            Dim startInfo As New ProcessStartInfo(My.Application.Info.DirectoryPath & "\MyCam\MyCam.exe")
            startInfo.WindowStyle = ProcessWindowStyle.Hidden

            Process.Start(startInfo)
            Me.Cursor = Cursors.WaitCursor
            Timer2.Start()
        Else
            frmWebCam.ShowDialog()
        End If
    End Sub

    Private Sub btnTirarImagem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTirarImagem2.Click
        frmWebCam.Tag = "PRODUTO2"
        If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\MyCam") = True Then
            Dim startInfo As New ProcessStartInfo(My.Application.Info.DirectoryPath & "\MyCam\MyCam.exe")
            startInfo.WindowStyle = ProcessWindowStyle.Hidden

            Process.Start(startInfo)
            Me.Cursor = Cursors.WaitCursor
            Timer2.Start()
        Else
            frmWebCam.ShowDialog()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim processo As Process() = Process.GetProcessesByName("MyCam")
        Dim bolAbriu As Boolean = False
        ' While bolAbriu = False
        If processo.Length > 0 Then
            bolAbriu = True
            Timer2.Stop()
            Me.Cursor = Cursors.Default
            frmWebCam.ShowDialog()
            Timer2.Stop()
        End If
        'End While

        Timer2.Stop()
    End Sub

    Private Sub btnCadTabVal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadTabVal.Click
        If Validar(Me.txtValCus) = False Then Exit Sub
        Try
            frmTabelaPreco.intCodProd = intCodProdTabela
            frmTabelaPreco.strValorCusto = Me.txtValCus.Text.Trim
            frmTabelaPreco.ShowDialog()
        Catch ex As Exception
        End Try
        
    End Sub

    Private Sub btnCadFamilia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadFamilia.Click
        frmGrupo.Tag = "FAMILIA"
        frmGrupo.ShowDialog()
        Me.cboFamilia.Properties.Items.Clear()
        PreencherGrupoSetorCusto("F", Me.cboFamilia)
        Me.cboFamilia.Focus()
    End Sub

    Private Sub nbcVenda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbcVenda.Click
        Try
            If Me.nbcVenda.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed Then
                If Me.nbcVenda.NavPaneForm.ExpandedGroup.Expanded = True Then
                    Me.nbcVenda.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub nbcVenda_NavPaneStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbcVenda.NavPaneStateChanged
        If nbcVenda.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed Then
            Me.SimpleButton1.Visible = False

            Me.NavBarGroup1.Caption = "Ajuste"
            Me.NavBarGroup1.GroupClientHeight = 80
            Me.nbcVenda.Size = New System.Drawing.Size(37, 237)

        Else
            Me.SimpleButton1.Visible = True

            Me.nbcVenda.PaintStyleName = "ExplorerBarView"
            Me.NavBarGroup1.Caption = ""
            Me.NavBarGroup1.GroupClientHeight = 211
            Me.NavBarGroup1.Appearance.BackColor = Color.Transparent
            'Me.NavBarGroup1.Appearance.ForeColor = Color.Blue
            Me.nbcVenda.Appearance.Background.BackColor = Color.Transparent

        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.nbcVenda.PaintStyleName = "SkinNavigationPane"
        Me.nbcVenda.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
    End Sub

    Private Sub btnCadCodBarra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadCodBarra.Click
        If bolAlterado = False Then Exit Sub
        frmCodigoBarra.Tag = "CADASTRO"
        frmCodigoBarra.intCodProd = intCodPro
        frmCodigoBarra.ShowDialog()

        CarregarComboCodigoBarra()
        Me.txtCodBarra.Focus()
    End Sub
    Private Sub CarregarComboCodigoBarra()
        Dim dt As DataTable
        Dim I As Integer
        Dim strFil As String = ""
        Me.txtCodBarra.Properties.Items.Clear()
        dt = CarregarDataTable("SELECT CodigoBarra FROM Produto where Codigo = " & intCodPro)
        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).ItemArray(0).ToString <> "" Then
                Me.txtCodBarra.Properties.Items.Add(dt.Rows.Item(0).ItemArray(0))
                strFil = " and CodigoBarra <> '" & dt.Rows.Item(0).ItemArray(0) & "'"
                Me.txtCodBarra.Text = dt.Rows.Item(0).ItemArray(0).ToString
            Else
                Me.txtCodBarra.Text = ""
            End If
        End If
  
        dt = CarregarDataTable("SELECT CodigoBarra FROM CodigoBarra where CodProd = " & intCodPro & strFil & " and Produto ='' or CodProd = " & intCodPro & strFil & " and Produto is null")
        For I = 0 To dt.Rows.Count - 1
            Me.txtCodBarra.Properties.Items.Add(dt.Rows.Item(I).ItemArray(0))
        Next
    End Sub

    Private Sub btnCodBarras_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCodBarras.ItemClick
        CodigoDoProduto = 0
        frmCodigoBarra.Tag = "CONSULTA"
        frmCodigoBarra.ShowDialog()
        If CodigoDoProduto > 0 Then
            Dim index As Integer = -999997
            grd1.FocusedRowHandle = index
            grd1.FocusedColumn = Me.colNome
            grd1.SetRowCellValue(index, Me.colCodigo, CodigoDoProduto)
            grd1.FocusedRowHandle = 0
            grd1.ShowEditor()
            Alterar()

        End If
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Historico(True)
    End Sub

    Private Sub btnBalanca_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBalanca.ItemClick
        If MsgBox("Confirma a Geração do Arquivo para Atualização da Balança ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        If Me.grd1.RowCount <= 0 Then Exit Sub
        Dim caminho As String = ""

        If TipoBalanca.Contains("TOLEDO") = True Then
            If My.Computer.FileSystem.DirectoryExists("C:\Balança") = False Then
                My.Computer.FileSystem.CreateDirectory("C:\Balança")
            End If
            If TipoBalanca.Contains("MGV6") = True Then
                caminho = "C:\Balança\TENSMGV.TXT"
            Else
                caminho = "C:\Balança\TXITENS.TXT"
            End If

        Else
            If My.Computer.FileSystem.DirectoryExists("C:\FILIZOLA") = False Then
                My.Computer.FileSystem.CreateDirectory("C:\FILIZOLA")
            End If
            caminho = "C:\FILIZOLA\CADTXT.TXT"
        End If

        Dim PSLinhaDados As String = ""
        Dim PIValor As Double
        Dim PIval As Integer
        Dim PSTxt As String
        Dim txt As New String(" "c, 50)
        File.Delete(caminho)

        Dim PSSWOpen As FileStream = File.Create(caminho)
        PSSWOpen.Dispose()

        Dim I As Integer
        For I = 0 To Me.grd1.RowCount - 1
            Dim strCodProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)
            Dim strNomeProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colNome)
            Dim strUMProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colUnidadeMedida)
            Dim strCodInternoProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)

            Dim strValorProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colValor)

            If TipoBalanca.Contains("TOLEDO") = True Then
                If TipoBalanca.Contains("MGV6") = True Then
                    PSLinhaDados &= "01"
                    PSLinhaDados &= IIf(strUMProd = "KG", "0", "1")     'Tipo de Produto (venda por Peso)
                    PSLinhaDados &= Trim(strCodInternoProd).PadLeft(6, "0")     'Codigo do Produto
                    PIValor = strValorProd
                    PIValor = PIValor * 100
                    PIval = Int(PIValor)
                    PSTxt = PIval
                    PSTxt = PSTxt.ToString.PadLeft(6, "0")
                    PSLinhaDados &= PSTxt                                 'Valor Unitário
                    PSLinhaDados &= "000"                                   'Dias de Validade do Produto - Conforme Manula - Máo Imprimir
                    PSLinhaDados &= Espaco(strNomeProd, 25, False)        'Linha I do Descritivo do Produto
                    PSLinhaDados &= Mid(txt, 1, 25)                         'Linha II do Descritivo do Produto
                    PSLinhaDados &= "000000"     'Codigo do Produto
                    PSLinhaDados &= "0000"     'Codigo do Produto
                    PSLinhaDados &= "000000"   'nutricional
                    PSLinhaDados &= "0"                                     'Data VAlidade
                    PSLinhaDados &= "0"                                     'Data Embalagem
                    PSLinhaDados &= "0000"     'Codigo do fornecedor
                    PSLinhaDados &= "000000000000" 'Mid(txt, 1, 12)                         'Linha II do Descritivo do Produto
                    PSLinhaDados &= Mid(txt, 1, 11)                         'Linha II do Descritivo do Produto
                    PSLinhaDados &= Mid(txt, 1, 1)                         'Linha II do Descritivo do Produto
                    PSLinhaDados &= "0000"     'som
                    PSLinhaDados &= "0000"     'tara
                    PSLinhaDados &= "0000"     'fracionador
                    PSLinhaDados &= "0000"     'extra1
                    PSLinhaDados &= "0000"     'extra2
                    PSLinhaDados &= "0000"     'Concervasao
                    PSLinhaDados &= Mid(txt, 1, 12)                         'Linha II do Descritivo do Produto
                    PSLinhaDados &= "000000" & vbCrLf 'glaciamento

                    'PSLinhaDados &= Mid(txt, 1, 35)                         'Linha II do Descritivo do Produto
                    'PSLinhaDados &= Mid(txt, 1, 35)                         'Linha II do Descritivo do Produto
                    'PSLinhaDados &= "000000"   'glaciamento
                    'PSLinhaDados &= "000000"   'glaciamento
                    'PSLinhaDados &= "000000"   'glaciamento
                Else
                    PIValor = 0
                    PIval = 0
                    PSTxt = ""

                    PSLinhaDados &= "01"                                     'Departamento
                    PSLinhaDados &= "00"                                    'Etiqueta configurada no Departamento
                    PSLinhaDados &= IIf(strUMProd = "KG", "0", "1")     'Tipo de Produto (venda por Peso)
                    PSLinhaDados &= Trim(strCodInternoProd).PadLeft(6, "0")     'Codigo do Produto
                    PIValor = strValorProd
                    PIValor = PIValor * 100
                    PIval = Int(PIValor)
                    PSTxt = PIval
                    PSTxt = PSTxt.ToString.PadLeft(6, "0")
                    PSLinhaDados &= PSTxt                                 'Valor Unitário
                    PSLinhaDados &= "000"                                   'Dias de Validade do Produto - Conforme Manula - Máo Imprimir
                    PSLinhaDados &= Mid(strNomeProd, 1, 25)        'Linha I do Descritivo do Produto
                    PSLinhaDados &= Mid(txt, 1, 25)                         'Linha II do Descritivo do Produto
                    PSLinhaDados &= txt                                     'Linha I da informação extra/receita
                    PSLinhaDados &= txt                                     'Linha II da informação extra/receita
                    PSLinhaDados &= txt                                     'Linha III da informação extra/receita
                    PSLinhaDados &= txt                                     'Linha IV da informação extra/receita
                    PSLinhaDados &= txt & vbCrLf
                End If
               
            Else
                PSLinhaDados &= Format(CInt(strCodInternoProd), "000000")
                PSLinhaDados &= "P"

                If strNomeProd.Length > 22 Then
                    strNomeProd = strNomeProd.Substring(0, 22)
                End If
                PSLinhaDados &= Dir(strNomeProd, 22)
                Dim dblValor As Double = strValorProd
                strValorProd = dblValor.ToString("0.00")
                PSLinhaDados &= Format(CInt(strValorProd.Replace(",", "")), "0000000") & "000" & vbCrLf


            End If

        Next

        Dim fluxoTexto As IO.StreamWriter
        fluxoTexto = New IO.StreamWriter(caminho)

        fluxoTexto.Write("")
        fluxoTexto.Write(PSLinhaDados)
        fluxoTexto.Dispose()
        fluxoTexto.Close()
        'Linha V da informação extra/receita

        If TipoBalanca.Contains("TOLEDO") = True Then
            If TipoBalanca.Contains("MGV6") = True Then
                MsgBox("Arquivo ITENSMGV.txt Gerado com Sucesso na pasta C:\Balança", MsgBoxStyle.Information)
            Else
                MsgBox("Arquivo TXITENS.txt Gerado com Sucesso na pasta C:\Balança", MsgBoxStyle.Information)
            End If

        Else
            MsgBox("Arquivo CADTXT.txt Gerado com Sucesso na pasta C:\FILIZOLA", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub btnCadUni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadUni.Click
        Dim frm As New frmGrupo
        frm.Tag = "UNIDADEMEDIDA"
        frm.ShowDialog()
        Me.cboUniMed.Properties.Items.Clear()
        PreencherGrupoSetorCusto("U", Me.cboUniMed)
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.nbcImagem.PaintStyleName = "SkinNavigationPane"
        Me.nbcImagem.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
    End Sub

    Private Sub txtQtdeMinima_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQtdeMinima.EditValueChanged
        Dim I As Integer
        For I = 0 To grd2.RowCount - 1
            If Me.grd2.GetRowCellDisplayText(I, Me.colCodConfig) = CodConfig Then
                Me.grd2.SetRowCellValue(I, Me.colQtdMinima, Me.txtQtdeMinima.Text)
            End If
        Next
    End Sub

    Private Sub txtQtdeEstoque_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQtdeEstoque.EditValueChanged
        Dim I As Integer
        For I = 0 To grd2.RowCount - 1
            If Me.grd2.GetRowCellDisplayText(I, Me.colCodConfig) = CodConfig Then
                Me.grd2.SetRowCellValue(I, Me.colQtd, Me.txtQtdeEstoque.Text)
            End If
        Next
    End Sub

    Private Sub txtQtdMaxima_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQtdMaxima.EditValueChanged
        Dim I As Integer
        For I = 0 To grd2.RowCount - 1
            If Me.grd2.GetRowCellDisplayText(I, Me.colCodConfig) = CodConfig Then
                Me.grd2.SetRowCellValue(I, Me.colQtdMaxima, Me.txtQtdMaxima.Text)
            End If
        Next
    End Sub

    Private Sub grd2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grd2.CellValueChanged
    
        If Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colCodConfig) = CodConfig Then
            If Me.grd2.FocusedColumn.FieldName = "Qtd" Then
                Me.txtQtdeEstoque.Text = Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colQtd)
            End If
            If Me.grd2.FocusedColumn.FieldName = "QtdMinima" Then
                Me.txtQtdeMinima.Text = Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colQtdMinima)
            End If
            If Me.grd2.FocusedColumn.FieldName = "QtdMaxima" Then
                Me.txtQtdMaxima.Text = Me.grd2.GetRowCellDisplayText(Me.grd2.FocusedRowHandle, Me.colQtdMaxima)
            End If
        End If

    End Sub

    Private Sub txtQtdeEstoque_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtdeEstoque.Leave
        If Me.txtQtdeEstoque.Text = "" Then Me.txtQtdeEstoque.Text = "0"
        Select Case cboUniMed.SelectedIndex
            Case 0, 1, 2
                Me.txtQtdeEstoque.CasasDecimais = 0
            Case 3, 4
                Me.txtQtdeEstoque.CasasDecimais = 3
            Case 5
                Me.txtQtdeEstoque.CasasDecimais = 2
            Case Else
                Me.txtQtdeEstoque.CasasDecimais = 3
        End Select
        Dim I As Integer
        For I = 0 To grd2.RowCount - 1
            If Me.grd2.GetRowCellDisplayText(I, Me.colCodConfig) = CodConfig Then
                Me.grd2.SetRowCellValue(I, Me.colQtd, Me.txtQtdeEstoque.Text)
            End If
        Next
    End Sub

    Private Sub txtQtdeMinima_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtdeMinima.Leave
        If Me.txtQtdeMinima.Text = "" Then Me.txtQtdeMinima.Text = "0"
        Select Case cboUniMed.SelectedIndex
            Case 0, 1, 2
                Me.txtQtdeMinima.CasasDecimais = 0
            Case 3, 4
                Me.txtQtdeMinima.CasasDecimais = 3
            Case 5
                Me.txtQtdeMinima.CasasDecimais = 2
            Case Else
                Me.txtQtdeMinima.CasasDecimais = 3
        End Select
        Dim I As Integer
        For I = 0 To grd2.RowCount - 1
            If Me.grd2.GetRowCellDisplayText(I, Me.colCodConfig) = CodConfig Then
                Me.grd2.SetRowCellValue(I, Me.colQtdMinima, Me.txtQtdeMinima.Text)
            End If
        Next
    End Sub

    Private Sub txtQtdMaxima_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtdMaxima.Leave
        If Me.txtQtdMaxima.Text = "" Then Me.txtQtdMaxima.Text = "0"
        Select Case cboUniMed.SelectedIndex
            Case 0, 1, 2
                Me.txtQtdMaxima.CasasDecimais = 0
            Case 3, 4
                Me.txtQtdMaxima.CasasDecimais = 3
            Case 5
                Me.txtQtdMaxima.CasasDecimais = 2
            Case Else
                Me.txtQtdMaxima.CasasDecimais = 3
        End Select
        Dim I As Integer
        For I = 0 To grd2.RowCount - 1
            If Me.grd2.GetRowCellDisplayText(I, Me.colCodConfig) = CodConfig Then
                Me.grd2.SetRowCellValue(I, Me.colQtdMaxima, Me.txtQtdMaxima.Text)
            End If
        Next
    End Sub

    Private Sub txtPeso_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPeso.Leave
        Me.txtPeso.Text = CampoValor(Me.txtPeso.Text)
        Me.txtPesoBruto.Focus()
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        If bolAlterado = False Then Exit Sub
        frmCodigoBarra.Tag = "VINCULO"
        frmCodigoBarra.intCodProd = intCodPro
        frmCodigoBarra.ShowDialog()
    End Sub

 
    Private Sub btnSalvarTributacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarTributacao.Click


        Dim strTipoFiscal As String = ""

        If TipoFiscal = "AMBOS" Then
            Select Case Me.cboTipoFiscal.Text
                Case "NFE"
                    strTipoFiscal = " NFE"
                    If MsgBox("Deseja realmente salvar essa tributação para NF-e?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                Case "SAT"
                    strTipoFiscal = " SAT"
                    If MsgBox("Deseja realmente salvar essa tributação para Sat Fiscal?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                Case "AMBOS"
                    If MsgBox("Deseja realmente salvar essa tributação para Sat Fiscal/NF-e?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            End Select
        End If
        Dim strCst As String = Me.cboNfeCST.Text
        If strCst <> "" Then
            'If Me.cboRegime.SelectedIndex = 0 Then
            '    strCst = strCst.Substring(0, 2)
            'Else
            strCst = strCst.Substring(0, 3)
            'End If
        End If

        Dim strCstTN As String = Me.cboCstTN.Text
        If strCstTN <> "" Then
            strCstTN = strCstTN.Substring(0, 2)
        End If

        Dim strOrig As String = Me.cboOrigem.Text
        If strOrig <> "" Then
            strOrig = strOrig.Substring(0, 1)
        End If
        Dim strOrigTN As String = Me.cboOrigemTN.Text
        If strOrigTN <> "" Then
            strOrigTN = strOrigTN.Substring(0, 1)
        End If

        Dim strModBC As String = Me.cboModBC.Text
        If strModBC <> "" Then
            strModBC = strModBC.Substring(0, 1)
        End If
        Dim strModBCTN As String = Me.cboModBcTN.Text
        If strModBCTN <> "" Then
            strModBCTN = strModBCTN.Substring(0, 1)
        End If
        Dim strModBCST As String = Me.cboModBCST.Text
        If strModBCST <> "" Then
            strModBCST = strModBCST.Substring(0, 1)
        End If

        Dim strModBCSTTN As String = Me.cboModBcStTN.Text
        If strModBCSTTN <> "" Then
            strModBCSTTN = strModBCSTTN.Substring(0, 1)
        End If

        Dim strCstIPI As String = Me.cboCSTIPI.Text
        If strCstIPI <> "" Then
            strCstIPI = strCstIPI.Substring(0, 2)
        End If
        Dim strCstIPITN As String = Me.cboCstIpiTN.Text
        If strCstIPITN <> "" Then
            strCstIPITN = strCstIPITN.Substring(0, 2)
        End If
        Dim strCstPIS As String = Me.cboCSTPIS.Text
        If strCstPIS <> "" Then
            strCstPIS = strCstPIS.Substring(0, 2)
        End If
        Dim strCstPISTN As String = Me.cboCstPisTN.Text
        If strCstPISTN <> "" Then
            strCstPISTN = strCstPISTN.Substring(0, 2)
        End If
        Dim strCstCOFINS As String = Me.cboCSTCOFINS.Text
        If strCstCOFINS <> "" Then
            strCstCOFINS = strCstCOFINS.Substring(0, 2)
        End If
        Dim strCstCOFINSTN As String = Me.cboCstCofinsTN.Text
        If strCstCOFINSTN <> "" Then
            strCstCOFINSTN = strCstCOFINSTN.Substring(0, 2)
        End If
        Dim dtTrib As DataTable = CarregarDataTable("SELECT Codigo FROM Tributos where CodProd = " & intCodPro & " and Regime = 'SIMPLES NACIONAL" & strTipoFiscal & "'")


        If dtTrib.Rows.Count = 0 Then
            Inserir("INSERT INTO Tributos (CodProd, CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, " & _
            "PerCOFINS, Regime) Values (" & intCodPro & ",'" & strCstIPI & "','" & Me.txtAliquotaIPI.Text & "'," & _
            "'" & Me.txtCodEnq.Text & "','" & strCstPIS & "','" & Me.txtAliquotaPIS.Text & "'," & _
            "'" & strCstCOFINS & "','" & Me.txtAliquotaCOFINS.Text & "','SIMPLES NACIONAL" & strTipoFiscal & "')")
        Else
            Atualizar("UPDATE Tributos SET CSTIPI = '" & strCstIPI & "', " & _
            "PerIPI = '" & Me.txtAliquotaIPI.Text & "', CodEnq = '" & Me.txtCodEnq.Text & "', " & _
            "CSTPIS = '" & strCstPIS & "', PerPIS = '" & Me.txtAliquotaPIS.Text & "', " & _
            "CSTCOFINS = '" & strCstCOFINS & "', PerCOFINS = '" & Me.txtAliquotaCOFINS.Text & "', Regime = 'SIMPLES NACIONAL" & strTipoFiscal & "' " & _
            "where CodProd = " & intCodPro & " and Regime = 'SIMPLES NACIONAL" & strTipoFiscal & "'")
        End If

        Select Case Me.cboTipoFiscal.Text
            Case "NFE", "SAT"
                Excluir("DELETE FROM Tributos where CodProd = " & intCodPro & " and Regime = 'SIMPLES NACIONAL'")
            Case "AMBOS"
                Excluir("DELETE FROM Tributos where CodProd = " & intCodPro & " and Regime = 'SIMPLES NACIONAL NFE' or CodProd = " & intCodPro & " and Regime = 'SIMPLES NACIONAL SAT'")
        End Select

        Dim dtNfe As DataTable = CarregarDataTable("SELECT Codigo FROM Nfe where CodProd = " & intCodPro & " and Regime = 'SIMPLES NACIONAL" & strTipoFiscal & "'")
        If dtNfe.Rows.Count = 0 Then
            Inserir("INSERT INTO Nfe (CodProd, EXTIPI, Genero, CST, Origem, ModBC, ICMS, RedBC, " & _
            "ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, Regime, CalculoCred, CodigoANP, UFComb, " & _
            "Cest, PerFCPUF, PerICMSUF) VALUES (" & intCodPro & ",'" & Me.txtEXTIPI.Text & "'," & _
            "'" & Me.txtGenero.Text & "','" & strCst & "','" & strOrig & "','" & strModBC & "'," & _
            "'" & Me.txtNfeICMS.Text.Trim & "','" & Me.txtRedBC.Text.Trim & "','" & strModBCST & "'," & _
            "'" & Me.txtRedBCST.Text.Trim & "','" & Me.txtMVAST.Text.Trim & "','" & strCfopDoProduto & "'," & _
            "'" & Me.txtICMSST.Text.Trim & "','" & Me.txtNfeNCM.Text.Trim & "','SIMPLES NACIONAL" & strTipoFiscal & "'," & _
            "'" & Me.txtCalcCred.Text.Trim & "','" & Me.cboCodigoANP.Text & "','" & Me.cboUF.Text & "'," & _
            "'" & Me.txtCest.Text & "','" & Me.txtPerFCPUF.Text & "','" & Me.txtPerICMSUF.Text & "')")
        Else
            Atualizar("UPDATE Nfe SET EXTIPI = '" & Me.txtEXTIPI.Text & "', " & _
            "Genero = '" & Me.txtGenero.Text & "',CST = '" & strCst & "', Origem = '" & strOrig & "', " & _
            "ModBC = '" & strModBC & "', ICMS = '" & Me.txtNfeICMS.Text.Trim & "', " & _
            "RedBC = '" & Me.txtRedBC.Text.Trim & "', ModBCST = '" & strModBCST & "', " & _
            "RedBCST = '" & Me.txtRedBCST.Text.Trim & "', MVaST = '" & Me.txtMVAST.Text.Trim & "', " & _
            "CFOP = '" & strCfopDoProduto & "', ICMSST = '" & Me.txtICMSST.Text.Trim & "', " & _
            "NCM = '" & Me.txtNfeNCM.Text.Trim & "', Regime = 'SIMPLES NACIONAL" & strTipoFiscal & "', " & _
            "CalculoCred = '" & Me.txtCalcCred.Text.Trim & "', CodigoANP = '" & Me.cboCodigoANP.Text & "', " & _
            "UFComb = '" & Me.cboUF.Text & "', Cest = '" & Me.txtCest.Text & "', " & _
            "PerFCPUF = '" & Me.txtPerFCPUF.Text & "', PerICMSUF = '" & Me.txtPerICMSUF.Text & "' " & _
            "where CodProd = " & intCodPro & " and Regime = 'SIMPLES NACIONAL" & strTipoFiscal & "'")
        End If

        Select Case Me.cboTipoFiscal.Text
            Case "NFE", "SAT"
                Excluir("DELETE FROM Nfe where CodProd = " & intCodPro & " and Regime = 'SIMPLES NACIONAL'")
            Case "AMBOS"
                Excluir("DELETE FROM Nfe where CodProd = " & intCodPro & " and Regime = 'SIMPLES NACIONAL NFE' or CodProd = " & intCodPro & " and Regime = 'SIMPLES NACIONAL SAT'")
        End Select
        dtTrib = CarregarDataTable("SELECT Codigo FROM Tributos where CodProd = " & intCodPro & " and Regime = 'TRIBUTAÇÃO NORMAL" & strTipoFiscal & "'")
        If dtTrib.Rows.Count = 0 Then
            Inserir("INSERT INTO Tributos (CodProd, CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, " & _
            "PerCOFINS, Regime) Values (" & intCodPro & ",'" & strCstIPITN & "','" & Me.txtAliquotaIpiTN.Text & "'," & _
            "'" & Me.txtCodEnqTN.Text & "','" & strCstPISTN & "','" & Me.txtAliquotaPisTN.Text & "'," & _
            "'" & strCstCOFINSTN & "','" & Me.txtAliquotaCofinsTN.Text & "','TRIBUTAÇÃO NORMAL" & strTipoFiscal & "')")
        Else
            Atualizar("UPDATE Tributos SET CSTIPI = '" & strCstIPITN & "', " & _
            "PerIPI = '" & Me.txtAliquotaIpiTN.Text & "', CodEnq = '" & Me.txtCodEnqTN.Text & "', " & _
            "CSTPIS = '" & strCstPISTN & "', PerPIS = '" & Me.txtAliquotaPisTN.Text & "', " & _
            "CSTCOFINS = '" & strCstCOFINSTN & "', PerCOFINS = '" & Me.txtAliquotaCofinsTN.Text & "', Regime = 'TRIBUTAÇÃO NORMAL" & strTipoFiscal & "' " & _
            "where CodProd = " & intCodPro & " and Regime = 'TRIBUTAÇÃO NORMAL" & strTipoFiscal & "'")

        End If
        Select Case Me.cboTipoFiscal.Text
            Case "NFE", "SAT"
                Excluir("DELETE FROM Tributos where CodProd = " & intCodPro & " and Regime = 'TRIBUTAÇÃO NORMAL'")
            Case "AMBOS"
                Excluir("DELETE FROM Tributos where CodProd = " & intCodPro & " and Regime = 'TRIBUTAÇÃO NORMAL NFE' or CodProd = " & intCodPro & " and Regime = 'TRIBUTAÇÃO NORMAL SAT'")
        End Select

        dtNfe = CarregarDataTable("SELECT Codigo FROM Nfe where CodProd = " & intCodPro & " and Regime = 'TRIBUTAÇÃO NORMAL" & strTipoFiscal & "'")
        If dtNfe.Rows.Count = 0 Then
            Inserir("INSERT INTO Nfe (CodProd, EXTIPI, Genero, CST, Origem, ModBC, ICMS, RedBC, " & _
            "ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, Regime, CalculoCred, CodigoANP, UFComb, " & _
            "Cest, PerFCPUF, PerICMSUF) VALUES (" & intCodPro & ",'" & Me.txtEXTIPI.Text & "'," & _
            "'" & Me.txtGenero.Text & "','" & strCstTN & "','" & strOrigTN & "','" & strModBCTN & "'," & _
            "'" & Me.txtIcmsTN.Text.Trim & "','" & Me.txtRedBcTN.Text.Trim & "','" & strModBCSTTN & "'," & _
            "'" & Me.txtRedBcStTN.Text.Trim & "','" & Me.txtMvaStTN.Text.Trim & "','" & strCfopDoProduto & "'," & _
            "'" & Me.txtIcmsStTN.Text.Trim & "','" & Me.txtNfeNCM.Text.Trim & "','TRIBUTAÇÃO NORMAL" & strTipoFiscal & "'," & _
            "'" & Me.txtCalcCredTN.Text.Trim & "','" & Me.cboCodigoANP.Text & "','" & Me.cboUF.Text & "'," & _
            "'" & Me.txtCest.Text & "','" & Me.txtPercFcpTN.Text & "','" & Me.txtPercIcmsTN.Text & "')")
        Else
            Atualizar("UPDATE Nfe SET EXTIPI = '" & Me.txtEXTIPI.Text & "', " & _
            "Genero = '" & Me.txtGenero.Text & "',CST = '" & strCstTN & "', Origem = '" & strOrigTN & "', " & _
            "ModBC = '" & strModBCTN & "', ICMS = '" & Me.txtIcmsTN.Text.Trim & "', " & _
            "RedBC = '" & Me.txtRedBcTN.Text.Trim & "', ModBCST = '" & strModBCSTTN & "', " & _
            "RedBCST = '" & Me.txtRedBcStTN.Text.Trim & "', MVaST = '" & Me.txtMvaStTN.Text.Trim & "', " & _
            "CFOP = '" & strCfopDoProduto & "', ICMSST = '" & Me.txtIcmsStTN.Text.Trim & "', " & _
            "NCM = '" & Me.txtNfeNCM.Text.Trim & "', Regime = 'TRIBUTAÇÃO NORMAL" & strTipoFiscal & "', " & _
            "CalculoCred = '" & Me.txtCalcCredTN.Text.Trim & "', CodigoANP = '" & Me.cboCodigoANP.Text & "', " & _
            "UFComb = '" & Me.cboUF.Text & "', Cest = '" & Me.txtCest.Text & "', " & _
            "PerFCPUF = '" & Me.txtPercFcpTN.Text & "', PerICMSUF = '" & Me.txtPercIcmsTN.Text & "' " & _
            "where CodProd = " & intCodPro & " and Regime = 'TRIBUTAÇÃO NORMAL" & strTipoFiscal & "'")
        End If

        Select Case Me.cboTipoFiscal.Text
            Case "NFE", "SAT"
                Excluir("DELETE FROM Nfe where CodProd = " & intCodPro & " and Regime = 'TRIBUTAÇÃO NORMAL'")
            Case "AMBOS"
                Excluir("DELETE FROM Nfe where CodProd = " & intCodPro & " and Regime = 'TRIBUTAÇÃO NORMAL NFE' or CodProd = " & intCodPro & " and Regime = 'TRIBUTAÇÃO NORMAL SAT'")
        End Select
    End Sub

    Private Sub cboTipoFiscal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoFiscal.SelectedIndexChanged
        If bolAlterado = True Then
            If bolTipoFiscal = False Then
                bolTipoFiscal = True
                CarregarTributacao()
            End If
        End If
      
    End Sub
    Private Shared Function Espaco(ByVal parCampo As String, ByVal parTamanho As Integer, ByVal parNumerico As Boolean) As String

        Dim I As Integer

        Dim strCampo As String = ""
        For I = 0 To parCampo.Length - 1
            Dim strChar As Char = parCampo.Substring(I, 1)

            If Char.IsLetter(strChar) = False Then
                If Char.IsPunctuation(strChar) = False Then
                    If Char.IsNumber(strChar) = False Then
                        If Char.IsSeparator(strChar) = True Then
                            strCampo &= strChar
                        End If
                    Else
                        strCampo &= strChar
                    End If
                Else
                    strCampo &= strChar
                End If
            Else
                strCampo &= strChar
            End If
        Next
        Dim intQ As Integer
        parCampo = strCampo.Trim

        If parCampo.Length < parTamanho Then
            intQ = parTamanho - parCampo.Length
            If parNumerico = True Then
                For I = 0 To intQ - 1
                    parCampo = "0" & parCampo
                Next
            Else
                For I = 0 To intQ - 1
                    parCampo = parCampo & " "
                Next
            End If
            intQ = parCampo.Length
        Else
            If parNumerico = True Then
                Dim intCampo As Decimal = parCampo
                parCampo = intCampo
                intQ = parTamanho - parCampo.Length
                For I = 0 To intQ - 1
                    parCampo = "0" & parCampo
                Next
            Else

                parCampo = parCampo.Substring(0, parTamanho)

            End If
        End If
        Return parCampo
    End Function


    Private Sub grd5_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grd5.FocusedRowChanged
        grd6.ClearColumnsFilter()

        If Me.grd5.FocusedRowHandle < 0 Then
            grd6.ActiveFilter.Clear()
            Exit Sub
        End If
       
        Dim strTipo As String = Me.grd5.GetRowCellDisplayText(Me.grd5.FocusedRowHandle, Me.colTipoOpc)
        If strTipo <> "" Then

            grd6.ActiveFilter.NonColumnFilter = "[TipoOpc] = '" & strTipo & "'"

        End If
      
    End Sub

    Private Sub chkAddOpc_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAddOpc.EditValueChanged
        bolSalvarOpc = True
    End Sub

    Private Sub btnCadOpc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadOpc.Click
        frmCadOpcoes.ShowDialog()
        If bolAlterado = False Then
            CarregaOpc("")
        Else
            CarregaOpc(intCodPro)
        End If

    End Sub

    Private Sub btnInserirTodosOpc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirTodosOpc.Click
        If MsgBox("Atenção!" & vbCrLf & "Ao clicar em 'Sim' você informará esses dados para todos os produtos listados abaixo." & vbCrLf & "Você tem certeza que deseja fazer isso?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim index As Integer = -999997
            grd6.FocusedRowHandle = index
            grd6.FocusedColumn = Me.colOpcao
            grd6.ShowEditor()

            grd5.FocusedRowHandle = index
            grd5.ShowEditor()
            Me.grd6.ClearColumnsFilter()
            Me.grd6.ActiveFilter.Clear()
            grd6.ActiveFilter.NonColumnFilter = "[AddOpc] = 'True'"


            Dim I As Integer
            Dim A As Integer
            For A = 0 To Me.grd1.RowCount - 1
                Dim strCodProd As String = Me.grd1.GetRowCellDisplayText(A, Me.colCodigo)
                Excluir("DELETE FROM VincProdOpc Where CodProd = " & strCodProd)

                For I = 0 To Me.grd6.RowCount - 1
                    Dim strCodOpc As String = Me.grd6.GetRowCellDisplayText(I, Me.colCodigo4)
                    Inserir("INSERT INTO VincProdOpc (CodProd, CodOpc) VALUES (" & strCodProd & "," & strCodOpc & ")")
                Next
            Next

            Me.grd6.ActiveFilter.Clear()

            MsgBox("Dados inseridos com sucesso!", MsgBoxStyle.Information)

        End If
    End Sub

    Private Sub btnPainelPrecos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPainelPrecos.ItemClick
        'frmPainelPrecos.Show()

        ' Dim form As New frmPainelPrecos

        Dim screen As Screen

        ' We want to display a form on screen 1
        Try
            Dim intScreen As Integer = screen.AllScreens.Length
            If intScreen > 1 Then
                screen = screen.AllScreens(1)

                ' Set the StartPosition to Manual otherwise the system will assign an automatic start position

                frmPainelPrecos.StartPosition = FormStartPosition.Manual

                ' Set the form location so it appears at Location (100, 100) on the screen 1

                frmPainelPrecos.Location = screen.Bounds.Location + New Point(100, 100)

                ' Show the form

                frmPainelPrecos.Show()
            Else
                frmPainelPrecos.Show()
            End If
          
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub btnImportProd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImportProd.ItemClick
        frmImpProduto.Show()
    End Sub

    Private Sub txtDesconto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesconto.Leave
        Dim dblValCus, dblResul As Double
        If txtDesconto.Text = "" Then Exit Sub
        If Me.txtVal.Text.Trim = "" Then Exit Sub
        Dim dblPor As Double = txtDesconto.Text

        dblValCus = Me.txtVal.Text
        dblResul = (dblValCus * dblPor) / 100

        Me.txtValDesconto.Text = dblResul.ToString("0.000")
        Me.chkTamanho.Focus()
    End Sub

    Private Sub txtValDesconto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValDesconto.Leave
        If Me.txtValDesconto.Text.Trim = "" Then
            Me.txtDesconto.Focus()
            Exit Sub
        End If

        If Me.txtVal.Text.Trim = "" Then Exit Sub
        If Preco(Me.txtValDesconto) = False Then Exit Sub

        Dim dblValVenda, dblValCusto, dblMargem As Double

        dblValVenda = Me.txtValDesconto.Text.Trim
        dblValCusto = Me.txtVal.Text.Trim

       
        dblMargem = (dblValVenda * 100) / dblValCusto
        Dim str As String = dblMargem

        If str <> "+Infinito" And str <> "NaN (Não é um número)" Then

            Me.txtDesconto.Text = dblMargem.ToString("0.000")

        End If
        Me.chkTamanho.Focus()
    End Sub
End Class