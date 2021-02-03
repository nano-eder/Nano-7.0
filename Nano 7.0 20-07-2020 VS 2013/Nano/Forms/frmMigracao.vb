Imports Nano.clsFuncoes
Imports System
Imports System.Drawing
Imports System.Data
Imports System.IO
Imports Microsoft.VisualBasic

Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Public Class frmMigracao
    Dim strTabela As String
    Public Shared Sub Main()
        Application.Run(New frmMigracao())
    End Sub

    Private Sub frmImigracao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsNanoCommerce.Usuario' table. You can move, or remove it, as needed.
        Me.UsuarioTableAdapter.Fill(Me.DsNanoCommerce.Usuario)

    End Sub

    Private Sub btnOk_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOk.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Dim dt As DataTable = Nothing
        Dim I, B As Integer
        B = 1
        If Me.Tag = "Casella" Then
            '**********CLIENTE**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Cliente order by Codigo")
            For I = 0 To dt.Rows.Count - 1

                Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString.Replace("'", "")
                Dim strRG As String = dt.Rows.Item(I).Item("RG").ToString
                If dt.Rows.Item(I).Item("RG").ToString = "" Then
                    strRG = dt.Rows.Item(I).Item("IE").ToString
                End If

                Dim strCPF As String = dt.Rows.Item(I).Item("CPF").ToString
                Dim strEnd As String = dt.Rows.Item(I).Item("Endereco").ToString.Replace("'", "")

                Dim strTel As String = dt.Rows.Item(I).Item("Telefone").ToString
                Dim strFax As String = dt.Rows.Item(I).Item("Fax").ToString
                Dim strCel As String = dt.Rows.Item(I).Item("Celular").ToString
                Dim strEmail As String = dt.Rows.Item(I).Item("Email").ToString

                Dim vetTel As Array = Split(strTel, "|")

                If vetTel.Length > 1 Then
                    strTel = vetTel(1)
                Else
                    strTel = vetTel(0)
                End If

                Dim vetFax As Array = Split(strFax, "|")

                If vetFax.Length > 1 Then
                    strFax = vetFax(1)
                Else
                    strFax = vetFax(0)
                End If

                Dim vetCel As Array = Split(strCel, "|")
                If vetCel.Length > 1 Then
                    strCel = vetCel(1)
                Else
                    strCel = vetCel(0)
                End If


                Dim vetMail1 As Array = Split(strEmail, "|")
                If vetMail1.Length > 1 Then
                    strEmail = vetMail1(1)

                Else
                    strEmail = vetMail1(0)
                End If
                If strEmail = "" Then
                    Dim vetSite As Array = Split(dt.Rows.Item(I).Item("Site").ToString, "|")
                    If vetSite.Length > 1 Then
                        strEmail = vetSite(1)
                    Else
                        strEmail = vetSite(0)
                    End If
                End If
             

                Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
                Dim strNum As String = dt.Rows.Item(I).Item("Numero").ToString
                Dim strComp As String = dt.Rows.Item(I).Item("Complemento").ToString.Replace("'", "")
                Dim strBairro As String = dt.Rows.Item(I).Item("Bairro").ToString.Replace("'", "")
                Dim strCep As String = dt.Rows.Item(I).Item("Cep").ToString
                Dim strCidade As String = dt.Rows.Item(I).Item("Cidade").ToString.Replace("'", "")
                Dim strUF As String = dt.Rows.Item(I).Item("Estado").ToString

                Select Case strUF

                    Case "Acre", "ACRE"
                        strUF = "AC"

                    Case "Alagoas", "ALAGOAS"
                        strUF = "AL"

                    Case "Amapá"
                        strUF = "AP"

                    Case "Amazonas", "AMAZONAS"
                        strUF = "AM"

                    Case "Bahia", "BAHIA"
                        strUF = "BA"

                    Case "Ceará", "CEARÁ"
                        strUF = "CE"

                    Case "Distrito Federal", "DISTRITO FEDERAL"
                        strUF = "DF"

                    Case "Espírito Santo", "ESPÍRITO SANTO"
                        strUF = "ES"

                    Case "Goiás", "GOIÁS"
                        strUF = "GO"

                    Case "Maranhão", "MARANHÃO"
                        strUF = "MA"

                    Case "Mato Grosso", "MATO GROSSO"
                        strUF = "MT"

                    Case "Mato Grosso do Sul", "MATO GROSSO DO SUL"
                        strUF = "MS"

                    Case "Minas Gerais", "MINAS GERAIS"
                        strUF = "MG"

                    Case "Pará", "PARÁ"
                        strUF = "PA"

                    Case "Paraíba", "PARAÍBA"
                        strUF = "PB"

                    Case "Paraná", "PARANÁ"
                        strUF = "PR"

                    Case "Pernambuco", "PERNAMBUCO"
                        strUF = "PE"

                    Case "Piauí", "PIAUÍ"
                        strUF = "PI"

                    Case "Rio de Janeiro", "RIO DE JANEIRO"
                        strUF = "RJ"

                    Case "Rio Grande do Norte", "RIO GRANDE DO NORTE"
                        strUF = "RN"

                    Case "Rio Grande do Sul", "RIO GRANDE DO SUL"
                        strUF = "RS"

                    Case "Rondônia", "RONDÔNIA"
                        strUF = "RO"

                    Case "Roraima", "RORAIMA"
                        strUF = "RR"

                    Case "Santa Catarina", "SANTA CATARINA"
                        strUF = "SC"

                    Case "São Paulo", "SÃO PAULO"
                        strUF = "SP"

                    Case "Sergipe", "SERGIPE"
                        strUF = "SE"

                    Case "Tocantins", "TOCANTINS"
                        strUF = "TO"

                End Select
                Dim strFant As String = dt.Rows.Item(I).Item("Fantasia").ToString.Replace("'", "")

                Dim bolIna As Boolean = False
                Dim strObs As String = dt.Rows.Item(I).Item("Observacao").ToString.Replace("'", "")
                Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
                Dim strNasc As String
                If dt.Rows.Item(I).Item("Nascimento").ToString.Contains("/0974") Then
                    strNasc = dt.Rows.Item(I).Item("Nascimento").ToString.Replace("0974", "1974")
                Else

                    strNasc = dt.Rows.Item(I).Item("Nascimento").ToString
                End If

                Dim strSexo As String = dt.Rows.Item(I).Item("Sexo").ToString
                Dim strLimite As String = dt.Rows.Item(I).Item("Limite").ToString
                Dim strEmpresa As String = ""
                Dim strSalario As String = ""
                Dim strTelEmp As String = ""
                Dim strCredito As String = ""
                Dim strMarca As String = ""
                Dim strCodConfig As String = "1"
                Dim strP1 As String = ""
                Dim strP2 As String = ""
                Dim strRG1 As String = ""
                Dim strRG2 As String = ""
                Dim bolInativo As Boolean = False
                Inserir("INSERT INTO Cliente (Nome, RGIE, CPF, Endereco, Telefone, Fax, Celular, Email, Data, Numero, Complemento, Bairro, Cep, Cidade, Estado, Fantasia, Inadimplente, Observacao, Status, Nascimento, Sexo, Limite, Empresa, TelEmpresa, Salario, Credito, Marcas, CodConfig, Pessoa1, Pessoa2, RG1, RG2, Inativo) VALUES ('" & strNome.Replace("'", "´") & "','" & strRG & "','" & strCPF & "','" & strEnd.Replace("'", "´") & "','" & strTel & "','" & strFax & "','" & strCel & "','" & strEmail & "','" & strData & "','" & strNum & "','" & strComp & "','" & strBairro.Replace("'", "´") & "','" & strCep & "','" & strCidade.Replace("'", "´") & "','" & strUF & "','" & strFant & "','" & bolIna & "','" & strObs.Replace("'", "´") & "','" & strStatus & "','" & strNasc & "','" & strSexo & "','" & strLimite & "','" & strEmpresa & "','" & strTelEmp & "','" & strSalario & "','" & strCredito & "','" & strMarca & "'," & strCodConfig & ",'" & strP1 & "','" & strP2 & "','" & strRG1 & "','" & strRG2 & "','" & bolInativo & "')")

                LogDeErro()
                B += 1
            Next

            strTabela = "Cliente"
            BarraProdgresso()

            '**********CONTA RECEBER**********
            B = 1
            dt = CarregarAccess("SELECT * FROM ContaReceber order by Codigo")
            For I = 0 To dt.Rows.Count - 1
               
                Dim strCodOrdem As String = "0" & dt.Rows.Item(I).Item("Cod").ToString
                Dim strDataVenda As String = dt.Rows.Item(I).Item("DataServiço").ToString


                Dim strObs As String = dt.Rows.Item(I).Item("Servico").ToString.Replace("'", "")
                Dim strFormaPagamento As String = dt.Rows.Item(I).Item("FormaPagamento").ToString
                Dim strParcelas As String = dt.Rows.Item(I).Item("Parcelas").ToString
                Dim strValorParcela As String = dt.Rows.Item(I).Item("ValorParcela").ToString
                Dim strVencimento As String = dt.Rows.Item(I).Item("Vencimeto").ToString

                Dim strValorVenda As String = dt.Rows.Item(I).Item("Valor").ToString

                Dim strValorRecebido As String = dt.Rows.Item(I).Item("ValorRecebido").ToString
                Dim strRecebimento As String = dt.Rows.Item(I).Item("Recebimento").ToString
                Dim strRecebidoOK As Boolean = dt.Rows.Item(I).Item("RecebidoOK").ToString
                Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
                Dim strNumeroDocumento As String = dt.Rows.Item(I).Item("NumeroDocumento").ToString.Replace("'", "")
                Dim strTipoCusto As String = dt.Rows.Item(I).Item("TipoCusto").ToString
                Dim strBanco As String = ""

                Dim strCodConfig As String = "1"
                Dim strNome As String = dt.Rows.Item(I).Item("Cliente").ToString
                Dim strCodCli As String = "NULL"
                Dim dtCli As DataTable = CarregarDataTable("SELECT Codigo FROM Cliente where Nome = '" & strNome & "'")
                If dtCli.Rows.Count > 0 Then
                    strCodCli = dtCli.Rows.Item(0).Item("Codigo").ToString
                End If
                Inserir("INSERT INTO ContaReceber (CodOrdem, DataVenda, CodCli, Obs, FormaPagamento, Parcelas, ValorParcela, Vencimento, ValorVenda, ValorRecebido, Recebimento, RecebidoOK, Pagamento, NumeroDocumento, TipoCusto, Banco, CodConfig) VALUES (" & strCodOrdem & ",'" & strDataVenda & "'," & strCodCli & ",'" & strObs & "','" & strFormaPagamento & "','" & strParcelas & "'," & Num(strValorParcela) & ",'" & strVencimento & "'," & Num(strValorVenda) & "," & Num(strValorRecebido) & ",'" & strRecebimento & "','" & strRecebidoOK & "','" & strPagamento & "','" & strNumeroDocumento & "','" & strTipoCusto & "','" & strBanco & "'," & strCodConfig & ")")
                B += 1
                LogDeErro()
            Next
          
            strTabela = "ContaReceber"
            BarraProdgresso()
            '**********FORNECEDOR**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Fornecedor order by Codigo")
            For I = 0 To dt.Rows.Count - 1
               
                Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString.Replace("'", "´")
                Dim strCPF As String = dt.Rows.Item(I).Item("CPF").ToString
                Dim strEnd As String = dt.Rows.Item(I).Item("Endereco").ToString.Replace("'", "")
                Dim strNum As String = dt.Rows.Item(I).Item("Numero").ToString
                Dim strComplemento As String = dt.Rows.Item(I).Item("Complemento").ToString.Replace("'", "")
                Dim strBairro As String = dt.Rows.Item(I).Item("Bairro").ToString.Replace("'", "")
                Dim strCep As String = dt.Rows.Item(I).Item("Cep").ToString
                Dim strCidade As String = dt.Rows.Item(I).Item("Cidade").ToString.Replace("'", "")
                Dim strUF As String = dt.Rows.Item(I).Item("Estado").ToString
                Select Case strUF

                    Case "Acre", "ACRE"
                        strUF = "AC"

                    Case "Alagoas", "ALAGOAS"
                        strUF = "AL"

                    Case "Amapá"
                        strUF = "AP"

                    Case "Amazonas", "AMAZONAS"
                        strUF = "AM"

                    Case "Bahia", "BAHIA"
                        strUF = "BA"

                    Case "Ceará", "CEARÁ"
                        strUF = "CE"

                    Case "Distrito Federal", "DISTRITO FEDERAL"
                        strUF = "DF"

                    Case "Espírito Santo", "ESPÍRITO SANTO"
                        strUF = "ES"

                    Case "Goiás", "GOIÁS"
                        strUF = "GO"

                    Case "Maranhão", "MARANHÃO"
                        strUF = "MA"

                    Case "Mato Grosso", "MATO GROSSO"
                        strUF = "MT"

                    Case "Mato Grosso do Sul", "MATO GROSSO DO SUL"
                        strUF = "MS"

                    Case "Minas Gerais", "MINAS GERAIS"
                        strUF = "MG"

                    Case "Pará", "PARÁ"
                        strUF = "PA"

                    Case "Paraíba", "PARAÍBA"
                        strUF = "PB"

                    Case "Paraná", "PARANÁ"
                        strUF = "PR"

                    Case "Pernambuco", "PERNAMBUCO"
                        strUF = "PE"

                    Case "Piauí", "PIAUÍ"
                        strUF = "PI"

                    Case "Rio de Janeiro", "RIO DE JANEIRO"
                        strUF = "RJ"

                    Case "Rio Grande do Norte", "RIO GRANDE DO NORTE"
                        strUF = "RN"

                    Case "Rio Grande do Sul", "RIO GRANDE DO SUL"
                        strUF = "RS"

                    Case "Rondônia", "RONDÔNIA"
                        strUF = "RO"

                    Case "Roraima", "RORAIMA"
                        strUF = "RR"

                    Case "Santa Catarina", "SANTA CATARINA"
                        strUF = "SC"

                    Case "São Paulo", "SÃO PAULO"
                        strUF = "SP"

                    Case "Sergipe", "SERGIPE"
                        strUF = "SE"

                    Case "Tocantins", "TOCANTINS"
                        strUF = "TO"

                End Select
                Dim strTelefone As String = dt.Rows.Item(I).Item("Telefone").ToString
                Dim strFax As String = dt.Rows.Item(I).Item("Fax").ToString
                Dim strCelular As String = dt.Rows.Item(I).Item("Celular").ToString
                Dim strEmail As String = dt.Rows.Item(I).Item("Email").ToString.Replace("'", "")
                Dim strData As String = dt.Rows.Item(I).Item("Data").ToString

                Dim strIE As String = dt.Rows.Item(I).Item("IE").ToString
                Dim strContato As String = dt.Rows.Item(I).Item("Contato").ToString
                Dim strSite As String = dt.Rows.Item(I).Item("Site").ToString
                Dim strFantasia As String = dt.Rows.Item(I).Item("Fantasia").ToString.Replace("'", "")
                Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
                Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString.Replace("'", "")

                Dim strCodConfig As String = "1"

                Dim vetTel As Array = Split(strTelefone, "|")

                If vetTel.Length > 1 Then
                    strTelefone = vetTel(1)
                Else
                    strTelefone = vetTel(0)
                End If

                Dim vetFax As Array = Split(strFax, "|")

                If vetFax.Length > 1 Then
                    strFax = vetFax(1)
                Else
                    strFax = vetFax(0)
                End If

                Dim vetCel As Array = Split(strCelular, "|")
                If vetCel.Length > 1 Then
                    strCelular = vetCel(1)
                Else
                    strCelular = vetCel(0)
                End If


                Dim vetMail1 As Array = Split(strEmail, "|")
                If vetMail1.Length > 1 Then
                    strEmail = vetMail1(1)

                Else
                    strEmail = vetMail1(0)
                End If

                Dim vetSite As Array = Split(dt.Rows.Item(I).Item("Site").ToString, "|")
                If vetSite.Length > 1 Then
                    strSite = vetSite(1)
                Else
                    strSite = vetSite(0)
                End If


                Inserir("INSERT INTO Fornecedor (Nome, CPF, Endereco, Numero, Complemento, Bairro, Cep, Cidade, Estado, Telefone, Fax, Celular, Email, Data, IE, Contato, Site, Fantasia, Status, Obs, CodConfig) VALUES ('" & strNome & "','" & strCPF & "','" & strEnd & "','" & strNum & "','" & strComplemento & "','" & strBairro & "','" & strCep & "','" & strCidade & "','" & strUF & "','" & strTelefone & "','" & strFax & "','" & strCelular & "','" & strEmail & "','" & strData & "','" & strIE & "','" & strContato & "','" & strSite & "','" & strFantasia & "','" & strStatus & "','" & strObs & "'," & strCodConfig & ")")
                B += 1
                LogDeErro()
            Next

            strTabela = "Fornecedor"
            BarraProdgresso()

            '**********CONTA PAGAR**********
            'B = 1
            'dt = CarregarAccess("SELECT * FROM ContaPagar order by Codigo")
            'For I = 0 To dt.Rows.Count - 1

            '    Dim strTipoConta As String = dt.Rows.Item(I).Item("TipoConta").ToString
            '    Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
            '    Dim strFormaPagamento As String = dt.Rows.Item(I).Item("FormaPagamento").ToString
            '    Dim strParcelas As String = dt.Rows.Item(I).Item("Parcelas").ToString
            '    Dim strValorParcela As String = dt.Rows.Item(I).Item("ValorParcela").ToString
            '    Dim strVencimento As String = dt.Rows.Item(I).Item("Vencimento").ToString
            '    Dim strDataPagamento As String = dt.Rows.Item(I).Item("DataPagamento").ToString
            '    Dim strValorPago As String = dt.Rows.Item(I).Item("ValorPago").ToString
            '    Dim strDescricao As String = dt.Rows.Item(I).Item("Descricao").ToString
            '    Dim strPagoOK As Boolean = dt.Rows.Item(I).Item("PagoOK").ToString
            '    Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
            '    Dim strNumeroDocumento As String = dt.Rows.Item(I).Item("NumeroDocumento").ToString.Replace("'", "")
            '    Dim strTipoCusto As String = dt.Rows.Item(I).Item("TipoCusto").ToString

            '    Dim strBanco As String = ""

            '    Dim strCodConfig As String = "1"


            '    Dim strCodFor As String = "NULL"

            '    Dim strNome As String = dt.Rows.Item(I).Item("Fornecedor").ToString

            '    Dim dtFor As DataTable = CarregarDataTable("SELECT Codigo FROM Fornecedor where Nome = '" & strNome & "'")
            '    If dtFor.Rows.Count > 0 Then
            '        strCodFor = dtFor.Rows.Item(0).Item("Codigo").ToString
            '    Else
            '        Dim strCPF As String
            '        strCodFor = GerarCodigo("Fornecedor", "Codigo", 1)
            '        strCPF = "000" & strCodFor

            '        Inserir("INSERT INTO Fornecedor (Nome, CPF, CodConfig) VALUES ('" & strNome & "','" & strCPF & "'," & strCodConfig & ")")
            '    End If

            '    Inserir("INSERT INTO ContaPagar (CodFor, TipoConta, Valor, FormaPagamento, Parcelas, ValorParcela, Vencimento, Pagamento, ValorPago, Descricao, PagoOK, NumeroDocumento, TipoCusto, Banco, CodConfig) VALUES (" & strCodFor & ",'" & strTipoConta & "'," & Num(strValor) & ",'" & strFormaPagamento & "','" & strParcelas & "'," & Num(strValorParcela) & ",'" & strVencimento & "','" & strPagamento & "'," & Num(strValorPago) & ",'" & strDescricao & "','" & strPagoOK & "','" & strNumeroDocumento & "','" & strTipoCusto & "','" & strBanco & "'," & strCodConfig & ")")
            '    B += 1
            '    LogDeErro()
            'Next

            'strTabela = "ContaPagar"
            'BarraProdgresso()

            '**********GRUPO**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Grupo order by Codigo")

            For I = 0 To dt.Rows.Count - 1
              
                
                Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString

                Inserir("Insert into Grupo (Nome, Tipo) values('" & strNome & "','G')")
                B += 1
                LogDeErro()
            Next
           
            strTabela = "Grupo"
            BarraProdgresso()
            '**********PRODUTO**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Produto order by Codigo")
            For I = 0 To dt.Rows.Count - 1
           

                Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString.Replace("'", "")
                Dim strUnidadeMedida As String = dt.Rows.Item(I).Item("UnidadeMedida").ToString
                Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
                Dim strValorCusto As String = dt.Rows.Item(I).Item("ValorCusto").ToString
                Dim strLocacao As String = dt.Rows.Item(I).Item("Locacao").ToString
                Dim strCodigoInterno As String = dt.Rows.Item(I).Item("CodigoPeca").ToString
                Dim strPorcentagens As String = ""

                Dim dblValVenda, dblValCusto, dblLucro, dblMargem As Double

                dblValVenda = strValor
                dblValCusto = strValorCusto

                dblLucro = dblValVenda - dblValCusto

                dblMargem = (dblLucro * 100) / dblValCusto
                Dim str As String = dblMargem
                strPorcentagens = "0"
                If str <> "+Infinito" Then
                    If str <> "NaN (Não é um número)" Then
                        strPorcentagens = dblMargem.ToString("0.00")
                    End If
                End If

               
                Dim strFabricante As String = dt.Rows.Item(I).Item("Fabricante").ToString.Replace("'", "´")
                Dim strGrupo As String = dt.Rows.Item(I).Item("Grupo").ToString
                Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString.Replace("'", "")
                Dim strData As String = dt.Rows.Item(I).Item("Data").ToString

                Dim strCodigoBarra As String = dt.Rows.Item(I).Item("CodigoBarra").ToString
                Dim strNivelComboCodCF As String = "0"
                Dim strDesconto As String = "0"


                Dim strSetor As String = ""
                Dim strTipo As String = "VENDA"

                Inserir("INSERT INTO Produto (Nome, UnidadeMedida, Valor, ValorCusto, Locacao,  CodigoInterno, Porcentagens, Fabricante, Grupo, Obs, Data, CodigoBarra, NivelComboCodCF, Desconto, Setor, Tipo) VALUES ('" & strNome.Replace("'", "´") & "','" & strUnidadeMedida & "'," & Num(strValor) & "," & Num(strValorCusto) & ",'" & strLocacao & "','" & strCodigoInterno & "','" & strPorcentagens & "','" & strFabricante.Replace("'", "´") & "','" & strGrupo & "','" & strObs.Replace("'", "´") & "','" & strData & "','" & strCodigoBarra & "','" & strNivelComboCodCF & "'," & Num(strDesconto) & ",'" & strSetor & "','" & strTipo & "')")

                Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
                Dim strQtdMinima As String = dt.Rows.Item(I).Item("QtdMinima").ToString

                Dim strCodProd As String = GerarCodigo("Produto", "Codigo", 0) - 1

                Dim dblQt As Double = 0
                If strQtd <> "" Then
                    dblQt = strQtd
                End If
                Dim dblQtMin As Double = 0
                If strQtdMinima <> "" Then
                    dblQtMin = strQtdMinima
                End If


                Dim intFalta As Integer = 0

                If dblQtMin >= dblQt Then
                    intFalta = 1
                End If
                Inserir("INSERT INTO Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, ValorCusto, EmFalta, CodConfig, Acabou, DataFim) VALUES (" & strCodProd & ",'U'," & Num(dblQtMin) & "," & Num(dblQt) & ",'U'," & Num(strValorCusto) & ",'" & intFalta & "',1,'False','01/01/1900')")


                B += 1
                LogDeErro()
            Next

            strTabela = "Produto"
            BarraProdgresso()
        Else

            '**********ORDEM**********

            dt = CarregarAccess("SELECT Max(Codigo) as Codigo FROM Ordem")
            If dt.Rows.Item(I).Item("Codigo").ToString <> "" Then
                Dim strCodigoOrdemMAX As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                Inserir("INSERT INTO Ordem (Codigo, CodConfig) VALUES (" & strCodigoOrdemMAX & "," & "1" & ")")
                LogDeErro()
            End If



            strTabela = "Ordem"

            BarraProdgresso()
            '**********BANCO**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Banco order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO Ordem (Nome) VALUES ('SQL SERVER')")
                        B += 1
                        LogDeErro()
                    Next


                End If
                Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
                Dim strSaldo As String = dt.Rows.Item(I).Item("Saldo").ToString
                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString

                Inserir("INSERT INTO Banco (Nome, Saldo, CodConfig) VALUES ('" & strNome & "'," & Num(strSaldo) & "," & strCodConfig & ")")
                LogDeErro()
                B += 1
            Next
            Excluir("DELETE FROM Banco where Nome = 'SQL SERVER'")

            strTabela = "Banco"

            BarraProdgresso()

            '**********CAIXA**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Caixa order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer

                    For J = 0 To int - 1
                        Inserir("INSERT INTO Caixa (Motivo) VALUES ('SQL SERVER')")
                        B += 1
                        LogDeErro()
                    Next
                End If

                Dim strMotivo As String = dt.Rows.Item(I).Item("Motivo").ToString
                Dim strCaixa As String = dt.Rows.Item(I).Item("Caixa").ToString
                Dim strCredito As String = dt.Rows.Item(I).Item("Credito").ToString
                Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
                Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
                Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString

                Inserir("INSERT INTO Caixa (Motivo, Caixa, Credito, Pagamento, Valor, Data, CodConfig) VALUES ('" & strMotivo & "','" & strCaixa & "','" & strCredito & "','" & strPagamento & "'," & Num(strValor) & ",'" & strData & "'," & strCodConfig & ")")
                LogDeErro()
                B += 1
            Next
            Excluir("DELETE FROM Caixa where Motivo = 'SQL SERVER'")
            strTabela = "Caixa"
            BarraProdgresso()
            '**********CLIENTE**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Cliente order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString
                Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString

                If strCodigo <> "1" Then
                    If strCodigo <> B Then

                        Dim int As Integer = strCodigo - B
                        Dim J As Integer


                        For J = 0 To int - 1
                            Inserir("INSERT INTO Cliente (Nome) VALUES ('SQL SERVER')")
                            B += 1
                            LogDeErro()
                        Next


                    End If

                    Dim strRG As String = dt.Rows.Item(I).Item("RGIE").ToString
                    Dim strCPF As String = dt.Rows.Item(I).Item("CPF").ToString
                    Dim strEnd As String = dt.Rows.Item(I).Item("Endereco").ToString
                    Dim strTel As String = dt.Rows.Item(I).Item("Telefone").ToString
                    Dim strFax As String = dt.Rows.Item(I).Item("Fax").ToString
                    Dim strCel As String = dt.Rows.Item(I).Item("Celular").ToString
                    Dim strEmail As String = dt.Rows.Item(I).Item("Email").ToString
                    Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
                    Dim strNum As String = dt.Rows.Item(I).Item("Numero").ToString
                    Dim strComp As String = dt.Rows.Item(I).Item("Complemento").ToString
                    Dim strBairro As String = dt.Rows.Item(I).Item("Bairro").ToString
                    Dim strCep As String = dt.Rows.Item(I).Item("Cep").ToString
                    Dim strCidade As String = dt.Rows.Item(I).Item("Cidade").ToString
                    Dim strUF As String = dt.Rows.Item(I).Item("Estado").ToString
                    Dim strFant As String = dt.Rows.Item(I).Item("Fantasia").ToString
                    Dim bolIna As Boolean = dt.Rows.Item(I).Item("Inadimplente").ToString
                    Dim strObs As String = dt.Rows.Item(I).Item("Observacao").ToString
                    Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
                    Dim strNasc As String
                    If dt.Rows.Item(I).Item("Nascimento").ToString.Contains("/0974") Then
                        strNasc = dt.Rows.Item(I).Item("Nascimento").ToString.Replace("0974", "1974")
                    Else

                        strNasc = dt.Rows.Item(I).Item("Nascimento").ToString
                    End If

                    Dim strSexo As String = dt.Rows.Item(I).Item("Sexo").ToString
                    Dim strLimite As String = dt.Rows.Item(I).Item("Limite").ToString
                    Dim strEmpresa As String = dt.Rows.Item(I).Item("Empresa").ToString
                    Dim strSalario As String = dt.Rows.Item(I).Item("Salario").ToString
                    Dim strTelEmp As String = dt.Rows.Item(I).Item("TelEmpresa").ToString
                    Dim strCredito As String = dt.Rows.Item(I).Item("Credito").ToString
                    Dim strMarca As String = dt.Rows.Item(I).Item("Marcas").ToString
                    Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
                    Dim strP1 As String = dt.Rows.Item(I).Item("Pessoa1").ToString
                    Dim strP2 As String = dt.Rows.Item(I).Item("Pessoa2").ToString
                    Dim strRG1 As String = dt.Rows.Item(I).Item("RG1").ToString
                    Dim strRG2 As String = dt.Rows.Item(I).Item("RG2").ToString
                    Dim bolInativo As Boolean = dt.Rows.Item(I).Item("Inativo").ToString
                    Inserir("INSERT INTO Cliente (Nome, RGIE, CPF, Endereco, Telefone, Fax, Celular, Email, Data, Numero, Complemento, Bairro, Cep, Cidade, Estado, Fantasia, Inadimplente, Observacao, Status, Nascimento, Sexo, Limite, Empresa, TelEmpresa, Salario, Credito, Marcas, CodConfig, Pessoa1, Pessoa2, RG1, RG2, Inativo) VALUES ('" & strNome.Replace("'", "´") & "','" & strRG & "','" & strCPF & "','" & strEnd.Replace("'", "´") & "','" & strTel & "','" & strFax & "','" & strCel & "','" & strEmail & "','" & strData & "','" & strNum & "','" & strComp & "','" & strBairro.Replace("'", "´") & "','" & strCep & "','" & strCidade.Replace("'", "´") & "','" & strUF & "','" & strFant & "','" & bolIna & "','" & strObs.Replace("'", "´") & "','" & strStatus & "','" & strNasc & "','" & strSexo & "','" & strLimite & "','" & strEmpresa & "','" & strTelEmp & "','" & strSalario & "','" & strCredito & "','" & strMarca & "'," & strCodConfig & ",'" & strP1 & "','" & strP2 & "','" & strRG1 & "','" & strRG2 & "','" & bolInativo & "')")
                    LogDeErro()

                End If
                B += 1
            Next
            Excluir("DELETE FROM Cliente where Nome = 'SQL SERVER'")
            strTabela = "Cliente"
            BarraProdgresso()

            '**********CONTA RECEBER**********
            B = 1
            dt = CarregarAccess("SELECT * FROM ContaReceber order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO ContaReceber (Banco) VALUES ('SQL SERVER')")
                        B += 1
                        LogDeErro()
                    Next


                End If

                Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
                Dim strDataVenda As String = dt.Rows.Item(I).Item("DataVenda").ToString
                Dim strCodCli As String = dt.Rows.Item(I).Item("CodCli").ToString
                Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString
                Dim strFormaPagamento As String = dt.Rows.Item(I).Item("FormaPagamento").ToString
                Dim strParcelas As String = dt.Rows.Item(I).Item("Parcelas").ToString
                Dim strValorParcela As String = dt.Rows.Item(I).Item("ValorParcela").ToString
                Dim strVencimento As String = dt.Rows.Item(I).Item("Vencimento").ToString
                Dim strValorVenda As String = dt.Rows.Item(I).Item("ValorVenda").ToString
                Dim strValorRecebido As String = dt.Rows.Item(I).Item("ValorRecebido").ToString
                Dim strRecebimento As String = dt.Rows.Item(I).Item("Recebimento").ToString
                Dim strRecebidoOK As Boolean = dt.Rows.Item(I).Item("RecebidoOK").ToString
                Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
                Dim strNumeroDocumento As String = dt.Rows.Item(I).Item("NumeroDocumento").ToString
                Dim strTipoCusto As String = dt.Rows.Item(I).Item("TipoCusto").ToString
                Dim strBanco As String = dt.Rows.Item(I).Item("Banco").ToString

                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


                Inserir("INSERT INTO ContaReceber (CodOrdem, DataVenda, CodCli, Obs, FormaPagamento, Parcelas, ValorParcela, Vencimento, ValorVenda, ValorRecebido, Recebimento, RecebidoOK, Pagamento, NumeroDocumento, TipoCusto, Banco, CodConfig) VALUES (" & strCodOrdem & ",'" & strDataVenda & "'," & strCodCli & ",'" & strObs & "','" & strFormaPagamento & "','" & strParcelas & "'," & Num(strValorParcela) & ",'" & strVencimento & "'," & Num(strValorVenda) & "," & Num(strValorRecebido) & ",'" & strRecebimento & "','" & strRecebidoOK & "','" & strPagamento & "','" & strNumeroDocumento & "','" & strTipoCusto & "','" & strBanco & "'," & strCodConfig & ")")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM ContaReceber where Banco = 'SQL SERVER'")

            strTabela = "ContaReceber"
            BarraProdgresso()
            '**********FORNECEDOR**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Fornecedor order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO Fornecedor (Nome) VALUES ('SQL SERVER')")
                        B += 1
                        LogDeErro()
                    Next


                End If
                Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString.Replace("'", "´")
                Dim strCPF As String = dt.Rows.Item(I).Item("CPF").ToString
                Dim strEnd As String = dt.Rows.Item(I).Item("Endereco").ToString
                Dim strNum As String = dt.Rows.Item(I).Item("Numero").ToString
                Dim strComp As String = dt.Rows.Item(I).Item("Complemento").ToString
                Dim strBairro As String = dt.Rows.Item(I).Item("Bairro").ToString
                Dim strCep As String = dt.Rows.Item(I).Item("Cep").ToString
                Dim strCidade As String = dt.Rows.Item(I).Item("Cidade").ToString
                Dim strUF As String = dt.Rows.Item(I).Item("Estado").ToString
                Dim strTelefone As String = dt.Rows.Item(I).Item("Telefone").ToString
                Dim strFax As String = dt.Rows.Item(I).Item("Fax").ToString
                Dim strCelular As String = dt.Rows.Item(I).Item("Celular").ToString
                Dim strEmail As String = dt.Rows.Item(I).Item("Email").ToString
                Dim strData As String = dt.Rows.Item(I).Item("Data").ToString

                Dim strIE As String = dt.Rows.Item(I).Item("IE").ToString
                Dim strContato As String = dt.Rows.Item(I).Item("Contato").ToString
                Dim strSite As String = dt.Rows.Item(I).Item("Site").ToString
                Dim strFantasia As String = dt.Rows.Item(I).Item("Fantasia").ToString
                Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
                Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString

                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


                Inserir("INSERT INTO Fornecedor (Nome, CPF, Endereco, Numero, Complemento, Bairro, Cep, Cidade, Estado, Telefone, Fax, Celular, Email, Data, IE, Contato, Site, Fantasia, Status, Obs, CodConfig) VALUES ('" & strNome & "','" & strCPF & "','" & strEnd & "','" & strNum & "','" & strComp & "','" & strBairro & "','" & strCep & "','" & strCidade & "','" & strUF & "','" & strTelefone & "','" & strFax & "','" & strCelular & "','" & strEmail & "','" & strData & "','" & strIE & "','" & strContato & "','" & strSite & "','" & strFantasia & "','" & strStatus & "','" & strObs & "'," & strCodConfig & ")")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM Fornecedor where Nome = 'SQL SERVER'")
            strTabela = "Fornecedor"
            BarraProdgresso()

            '**********CONTA PAGAR**********
            B = 1
            dt = CarregarAccess("SELECT * FROM ContaPagar order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO ContaPagar (Banco) VALUES ('SQL SERVER')")
                        B += 1
                        LogDeErro()
                    Next


                End If

                Dim strCodFor As String = dt.Rows.Item(I).Item("CodFor").ToString
                Dim strTipoConta As String = dt.Rows.Item(I).Item("TipoConta").ToString
                Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
                Dim strFormaPagamento As String = dt.Rows.Item(I).Item("FormaPagamento").ToString
                Dim strParcelas As String = dt.Rows.Item(I).Item("Parcelas").ToString
                Dim strValorParcela As String = dt.Rows.Item(I).Item("ValorParcela").ToString
                Dim strVencimento As String = dt.Rows.Item(I).Item("Vencimento").ToString
                Dim strDataPagamento As String = dt.Rows.Item(I).Item("DataPagamento").ToString
                Dim strValorPago As String = dt.Rows.Item(I).Item("ValorPago").ToString
                Dim strDescricao As String = dt.Rows.Item(I).Item("Descricao").ToString
                Dim strPagoOK As Boolean = dt.Rows.Item(I).Item("PagoOK").ToString
                Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
                Dim strNumeroDocumento As String = dt.Rows.Item(I).Item("NumeroDocumento").ToString
                Dim strTipoCusto As String = dt.Rows.Item(I).Item("TipoCusto").ToString
                Dim strBanco As String = dt.Rows.Item(I).Item("Banco").ToString

                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString

                Inserir("INSERT INTO ContaPagar (CodFor, TipoConta, Valor, FormaPagamento, Parcelas, ValorParcela, Vencimento, Pagamento, ValorPago, Descricao, PagoOK, NumeroDocumento, TipoCusto, Banco, CodConfig) VALUES (" & strCodFor & ",'" & strTipoConta & "'," & Num(strValor) & ",'" & strFormaPagamento & "','" & strParcelas & "'," & Num(strValorParcela) & ",'" & strVencimento & "','" & strPagamento & "'," & Num(strValorPago) & ",'" & strDescricao & "','" & strPagoOK & "','" & strNumeroDocumento & "','" & strTipoCusto & "','" & strBanco & "'," & strCodConfig & ")")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM ContaPagar where Banco = 'SQL SERVER'")

            strTabela = "ContaPagar"
            BarraProdgresso()
            '**********TOTAL ENTRADA NF**********
            B = 1
            dt = CarregarAccess("SELECT * FROM TotalEntradaNF order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO TotalEntradaNF (Lote) VALUES ('SQL SERVER')")
                        B += 1
                        LogDeErro()
                    Next


                End If

                Dim strNumeroNF As String = dt.Rows.Item(I).Item("NumeroNF").ToString
                Dim strCodFor As String = dt.Rows.Item(I).Item("CodFor").ToString
                Dim strTotal As String = dt.Rows.Item(I).Item("Total").ToString
                Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString
                Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
                Dim strEstoqueOK As Boolean = dt.Rows.Item(I).Item("EstoqueOK").ToString
                Dim strLote As String = dt.Rows.Item(I).Item("Lote").ToString
                Dim strDesconto As String = dt.Rows.Item(I).Item("Desconto").ToString
                Dim strTipo As String = dt.Rows.Item(I).Item("Tipo").ToString
                Dim strSerie As String = dt.Rows.Item(I).Item("Serie").ToString
                Dim strValorFrete As String = dt.Rows.Item(I).Item("ValorFrete").ToString
                Dim strValorSeguro As String = dt.Rows.Item(I).Item("ValorSeguro").ToString

                Dim strOutrasDespesas As String = dt.Rows.Item(I).Item("OutrasDespesas").ToString
                Dim strICMS As String = dt.Rows.Item(I).Item("ICMS").ToString
                Dim strIPI As String = dt.Rows.Item(I).Item("IPI").ToString


                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString

                Inserir("INSERT INTO TotalEntradaNF (NumeroNF, CodFor, Total, Obs, Data, EstoqueOK, Desconto, Tipo, Serie, ValorFrete, ValorSeguro, OutrasDespesas, ICMS, IPI, CodConfig) VALUES ('" & strNumeroNF & "'," & strCodFor & "," & Num(strTotal) & ",'" & strObs & "','" & strData & "','" & strEstoqueOK & "','" & strDesconto & "','" & strTipo & "','" & strSerie & "','" & strValorFrete & "','" & strValorSeguro & "','" & strOutrasDespesas & "','" & strICMS & "','" & strIPI & "'," & strCodConfig & ")")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM TotalEntradaNF where Lote = 'SQL SERVER'")

            strTabela = "TotalEntradaNF"
            BarraProdgresso()
            '**********REPRESENTANTE**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Representante order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO Representante (Nome) VALUES ('SQL SERVER')")
                        B += 1
                        LogDeErro()
                    Next


                End If
                Dim strCodFor As String = dt.Rows.Item(I).Item("CodFor").ToString
                Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
                Dim strTel1 As String = dt.Rows.Item(I).Item("Tel1").ToString
                Dim strTel2 As String = dt.Rows.Item(I).Item("Tel2").ToString
                Dim strWeb As String = dt.Rows.Item(I).Item("Web").ToString


                Inserir("INSERT INTO Representante (CodFor, Nome, Tel1, Tel2, Web) VALUES (" & strCodFor & ",'" & strNome & "','" & strTel1 & "','" & strTel2 & "','" & strWeb & "')")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM Representante where Nome = 'SQL SERVER'")

            strTabela = "Representante"
            BarraProdgresso()


            '**********FUNCIONARIO**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Funcionario order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO Funcionario (Nome) VALUES ('SQL SERVER')")
                        B += 1
                        LogDeErro()
                    Next


                End If


                Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
                Dim strCPF As String = dt.Rows.Item(I).Item("CPF").ToString
                Dim strRG As String = dt.Rows.Item(I).Item("RG").ToString
                Dim strTelefone As String = dt.Rows.Item(I).Item("Telefone").ToString
                Dim strCelular As String = dt.Rows.Item(I).Item("Celular").ToString
                Dim strEnd As String = dt.Rows.Item(I).Item("Endereco").ToString
                Dim strBairro As String = dt.Rows.Item(I).Item("Bairro").ToString
                Dim strCidade As String = dt.Rows.Item(I).Item("Cidade").ToString
                Dim strNascimento As String = dt.Rows.Item(I).Item("Nascimento").ToString
                Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString

                Dim strPorcComissao As String = dt.Rows.Item(I).Item("PorcComissao").ToString

                Dim strFuncao As String = dt.Rows.Item(I).Item("Funcao").ToString
                Dim strDataAdmissao As String = dt.Rows.Item(I).Item("DataAdmissao").ToString
                Dim strDataDemissao As String = dt.Rows.Item(I).Item("DataDemissao").ToString
                Dim strEmail As String = dt.Rows.Item(I).Item("Email").ToString

                Dim bolAtivo As Boolean = dt.Rows.Item(I).Item("Ativo").ToString

                Dim strSangue As String = dt.Rows.Item(I).Item("Sangue").ToString
                Dim strAlergia As String = dt.Rows.Item(I).Item("Alergia").ToString
                Dim strCEP As String = dt.Rows.Item(I).Item("CEP").ToString

                Dim strUF As String = dt.Rows.Item(I).Item("UF").ToString
                Dim strComplemento As String = dt.Rows.Item(I).Item("Complemento").ToString
                Dim strNum As String = dt.Rows.Item(I).Item("Num").ToString

                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString

                Inserir("INSERT INTO Funcionario (Nome, CPF, RG, Telefone, Celular, Endereco, Bairro, Cidade, Nascimento, Obs, PorcComissao, Funcao, DataAdmissao, DataDemissao, Email, Ativo, Sangue, Alergia, CEP, UF, Complemento, Num, CodConfig) VALUES ('" & strNome & "','" & strCPF & "','" & strRG & "','" & strTelefone & "','" & strCelular & "','" & strEnd & "','" & strBairro & "','" & strCidade & "','" & strNascimento & "','" & strObs & "','" & strPorcComissao & "','" & strFuncao & "','" & strDataAdmissao & "','" & strDataDemissao & "','" & strEmail & "','" & bolAtivo & "','" & strSangue & "','" & strAlergia & "','" & strCEP & "','" & strUF & "','" & strComplemento & "','" & strNum & "'," & strCodConfig & ")")
                LogDeErro()
                B += 1
            Next
            Excluir("DELETE FROM Funcionario where Nome = 'SQL SERVER'")
            strTabela = "Funcionario"
            BarraProdgresso()
            '**********COMISSAO**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Comissao order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO Comissao (Funcionario) VALUES ('SQL SERVER')")
                        B += 1
                        LogDeErro()
                    Next


                End If

                Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
                Dim strCodFunc As String = dt.Rows.Item(I).Item("CodFunc").ToString
                Dim strFuncionario As String = dt.Rows.Item(I).Item("Funcionario").ToString
                Dim strValorProduto As String = dt.Rows.Item(I).Item("ValorProduto").ToString
                Dim strPorcentagem As String = dt.Rows.Item(I).Item("Porcentagem").ToString
                Dim strValorComissao As String = dt.Rows.Item(I).Item("ValorComissao").ToString
                Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
                Dim strMotivo As String = dt.Rows.Item(I).Item("Motivo").ToString
                Dim strTipo As String = dt.Rows.Item(I).Item("Tipo").ToString
                Dim strCodConfig As String = "1"

                Inserir("INSERT INTO Comissao (CodOrdem, CodFunc, Funcionario, ValorProduto, Porcentagem, ValorComissao, Data, Motivo, Tipo, CodConfig) VALUES ('" & strCodOrdem & "','" & strCodFunc & "','" & strFuncionario & "'," & Num(strValorProduto) & "," & Num(strPorcentagem) & "," & Num(strValorComissao) & ",'" & strData & "','" & strMotivo & "','" & strTipo & "'," & strCodConfig & ")")

                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM Comissao where Funcionario = 'SQL SERVER'")
            strTabela = "Comissao"
            BarraProdgresso()
            '**********RECEBIMENTO**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Recebimento order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO Recebimento (FormaPagamento) VALUES ('SQL SERVER')")
                        B += 1
                        LogDeErro()
                    Next


                End If

                Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
                Dim strFormaPagamento As String = dt.Rows.Item(I).Item("FormaPagamento").ToString
                Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
                Dim strDocumento As String = dt.Rows.Item(I).Item("Documento").ToString
                Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
                Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
                Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString

                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString

                Inserir("Insert into Recebimento (CodOrdem, FormaPagamento, Pagamento, Valor, Documento, Data, Obs, CodConfig) Values(" & strCodOrdem & ",'" & strFormaPagamento & "','" & strPagamento & "'," & Num(strValor) & ",'" & strDocumento & "','" & strData & "','" & strObs & "'," & strCodConfig & ")")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM Recebimento where FormaPagamento = 'SQL SERVER'")

            strTabela = "Recebimento"
            BarraProdgresso()
            '**********FUTURO**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Futuro order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO Futuro (Pagamento) VALUES ('SQL SERVER')")
                        B += 1
                        LogDeErro()
                    Next


                End If
                Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
                Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
                Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
                Dim strTotal As String = dt.Rows.Item(I).Item("Total").ToString
                Dim strTotalDesconto As String = dt.Rows.Item(I).Item("TotalDesconto").ToString
                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString

                Inserir("Insert into Futuro (Data, CodOrdem, Pagamento, Total, TotalDesconto, CodConfig) Values('" & strData & "'," & strCodOrdem & ",'" & strPagamento & "'," & Num(strTotal) & "," & Num(strTotalDesconto) & "," & strCodConfig & ")")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM Futuro where Pagamento = 'SQL SERVER'")

            strTabela = "Futuro"
            BarraProdgresso()
            '**********GRUPO**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Grupo order by Codigo")

            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Dim strN As String = J + strCodigo
                        Inserir("INSERT INTO Grupo (Nome, Tipo) VALUES ('" & strN & "','Q')")
                        B += 1
                        LogDeErro()
                    Next


                End If
                Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
                Dim strTipo As String = dt.Rows.Item(I).Item("Tipo").ToString


                Inserir("Insert into Grupo (Nome, Tipo) values('" & strNome & "','" & strTipo & "')")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM Grupo where Tipo = 'Q'")

            strTabela = "Grupo"
            BarraProdgresso()
            '**********PRODUTO**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Produto order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO Produto (Nome) VALUES ('SQL SERVER')")
                        B += 1
                        LogDeErro()
                    Next


                End If

                Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
                Dim strUnidadeMedida As String = dt.Rows.Item(I).Item("UnidadeMedida").ToString
                Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
                Dim strValorCusto As String = dt.Rows.Item(I).Item("ValorCusto").ToString
                Dim strLocacao As String = dt.Rows.Item(I).Item("Locacao").ToString
                Dim strCodigoInterno As String = dt.Rows.Item(I).Item("CodigoInterno").ToString
                Dim strPorcentagens As String = dt.Rows.Item(I).Item("Porcentagens").ToString
                Dim strFabricante As String = dt.Rows.Item(I).Item("Fabricante").ToString.Replace("'", "´")
                Dim strGrupo As String = dt.Rows.Item(I).Item("Grupo").ToString
                Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString
                Dim strData As String = dt.Rows.Item(I).Item("Data").ToString

                Dim strCodigoBarra As String = dt.Rows.Item(I).Item("CodigoBarra").ToString
                Dim strNivelComboCodCF As String = dt.Rows.Item(I).Item("NivelComboCodCF").ToString
                Dim strDesconto As String = dt.Rows.Item(I).Item("Desconto").ToString


                Dim strSetor As String = dt.Rows.Item(I).Item("Setor").ToString
                Dim strTipo As String = dt.Rows.Item(I).Item("Tipo").ToString

                Inserir("INSERT INTO Produto (Nome, UnidadeMedida, Valor, ValorCusto, Locacao,  CodigoInterno, Porcentagens, Fabricante, Grupo, Obs, Data, CodigoBarra, NivelComboCodCF, Desconto, Setor, Tipo) VALUES ('" & strNome.Replace("'", "´") & "','" & strUnidadeMedida & "'," & Num(strValor) & "," & Num(strValorCusto) & ",'" & strLocacao & "','" & strCodigoInterno & "','" & strPorcentagens & "','" & strFabricante.Replace("'", "´") & "','" & strGrupo & "','" & strObs.Replace("'", "´") & "','" & strData & "','" & strCodigoBarra & "','" & strNivelComboCodCF & "'," & Num(strDesconto) & ",'" & strSetor & "','" & strTipo & "')")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM Produto where Nome = 'SQL SERVER'")


            strTabela = "Produto"
            BarraProdgresso()
            '**********ENTRADA NF**********
            B = 1
            dt = CarregarAccess("SELECT * FROM EntradaNF order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO EntradaNF (Produto) VALUES ('SQL SERVER')")
                        B += 1
                        LogDeErro()
                    Next


                End If

                Dim strCodTotNF As String = dt.Rows.Item(I).Item("CodTotNF").ToString
                Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
                Dim strTamanho As String = dt.Rows.Item(I).Item("Tamanho").ToString
                Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
                Dim strValorUnitario As String = dt.Rows.Item(I).Item("ValorUnitario").ToString
                Dim strValorTotal As String = dt.Rows.Item(I).Item("ValorTotal").ToString
                Dim strProduto As String = dt.Rows.Item(I).Item("Produto").ToString
                Dim strCodProdInterno As String = dt.Rows.Item(I).Item("CodProdInterno").ToString
                Dim strICMS As String = dt.Rows.Item(I).Item("ICMS").ToString
                Dim strDesconto As String = dt.Rows.Item(I).Item("Desconto").ToString
                Dim strIPI As String = dt.Rows.Item(I).Item("IPI").ToString

                Dim strUnitarioImposto As String = dt.Rows.Item(I).Item("UnitarioImposto").ToString
                Dim strQtdTotal As String = dt.Rows.Item(I).Item("QtdTotal").ToString
                Dim strUM As String = dt.Rows.Item(I).Item("UM").ToString


                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString

                Inserir("INSERT INTO EntradaNF (CodTotNF, CodProd, Qtd, ValorUnitario, ValorTotal, Produto, CodProdInterno, ICMS, Desconto, IPI, UnitarioImposto, Tamanho, CodConfig, QtdTotal, UM) VALUES (" & strCodTotNF & "," & strCodProd & "," & Num(strQtd) & "," & Num(strValorUnitario) & "," & Num(strValorTotal) & ",'" & strProduto & "','" & strCodProdInterno & "','" & strICMS & "','" & strDesconto & "','" & strIPI & "'," & Num(strUnitarioImposto) & ",'" & strTamanho & "'," & strCodConfig & ",'" & strQtdTotal & "','" & strUM & "')")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM EntradaNF where Produto = 'SQL SERVER'")
            strTabela = "EntradaNF"
            BarraProdgresso()
            '**********IMPOSTOPRODUTO**********
            B = 1
            dt = CarregarAccess("SELECT * FROM ImpostoProduto order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO ImpostoProduto (Cst) VALUES ('SQ')")
                        B += 1
                        LogDeErro()
                    Next


                End If

                Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
                Dim strICMS As String = dt.Rows.Item(I).Item("ICMS").ToString
                Dim strIPI As String = dt.Rows.Item(I).Item("IPI").ToString
                Dim strTributacao As String = dt.Rows.Item(I).Item("Tributacao").ToString
                Dim strCst As String = dt.Rows.Item(I).Item("Cst").ToString
                Dim strOrigemICMS As String = dt.Rows.Item(I).Item("OrigemICMS").ToString
                Dim strIPPT As String = dt.Rows.Item(I).Item("IPPT").ToString

                Dim strPesavel As String = dt.Rows.Item(I).Item("Pesavel").ToString
                Dim strTipoFIA As String = dt.Rows.Item(I).Item("TipoFIA").ToString

                Inserir("Insert into ImpostoProduto (CodProd, ICMS, IPI, Tributacao, Cst, OrigemIcms, IPPT, Pesavel, TipoFIA) Values(" & strCodProd & "," & Num(strICMS) & "," & Num(strIPI) & ",'" & strTributacao & "','" & strCst & "','" & strOrigemICMS & "','" & strIPPT & "','" & strPesavel & "','" & strTipoFIA & "')")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM ImpostoProduto where Cst = 'SQ'")

            strTabela = "ImpostoProduto"
            BarraProdgresso()
            '**********PAGAMENTO**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Pagamento order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO Pagamento (Descricao) VALUES ('SQL SERVER')")
                        B += 1
                        LogDeErro()
                    Next


                End If

                Dim strDescricao As String = dt.Rows.Item(I).Item("Descricao").ToString
                Dim strDias As String = dt.Rows.Item(I).Item("Dias").ToString
                Dim strDesconto As String = dt.Rows.Item(I).Item("Desconto").ToString
                Dim bolPrazo As Boolean = dt.Rows.Item(I).Item("Prazo").ToString
                Dim strFormaPagamento As String = dt.Rows.Item(I).Item("FormaPagamento").ToString
                Dim strIrCaixa As String = dt.Rows.Item(I).Item("IrCaixa").ToString

                Inserir("INSERT INTO Pagamento(Descricao, Dias, Desconto, Prazo, FormaPagamento, IrCaixa) VALUES ('" & strDescricao & "','" & strDias & "','" & strDesconto & "','" & bolPrazo & "','" & strFormaPagamento & "','" & strIrCaixa & "')")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM Pagamento where Descricao = 'SQL SERVER'")
            strTabela = "Pagamento"
            BarraProdgresso()

            '**********PEDIDO**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Pedido order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO Pedido (Produto) VALUES ('SQL SERVER')")
                        B += 1
                        LogDeErro()
                    Next


                End If
                Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
                Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
                Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
                Dim strProduto As String = dt.Rows.Item(I).Item("Produto").ToString
                Dim strValorUnitario As String = dt.Rows.Item(I).Item("ValorUnitario").ToString

                Dim strValorTotal As String = dt.Rows.Item(I).Item("ValorTotal").ToString

                Dim strCodProdInterno As String = dt.Rows.Item(I).Item("CodProdInterno").ToString
                Dim strCodFunc As String = dt.Rows.Item(I).Item("CodFunc").ToString
                Dim strCusto As String = dt.Rows.Item(I).Item("Custo").ToString
                Dim strTamanho As String = dt.Rows.Item(I).Item("Tamanho").ToString
                Dim strUM As String = dt.Rows.Item(I).Item("UM").ToString

                Dim bolDevolvido As Boolean = dt.Rows.Item(I).Item("Devolvido").ToString
                Dim strLote As String = dt.Rows.Item(I).Item("Lote").ToString
                Dim strTipoItens As String = dt.Rows.Item(I).Item("TipoItens").ToString


                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


                Inserir("Insert into Pedido (CodOrdem, Qtd, CodProd, Produto, ValorUnitario, ValorTotal, CodProdInterno, CodFunc, Custo, Um, Tamanho, Lote, TipoItens, CodConfig, Devolvido) Values(" & strCodOrdem & "," & Num(strQtd) & "," & strCodProd & ",'" & strProduto & "'," & Num(strValorUnitario) & "," & Num(strValorTotal) & ",'" & strCodProdInterno & "'," & strCodFunc & "," & Num(strCusto) & ",'" & strUM & "','" & strTamanho & "','" & strLote & "','" & strTipoItens & "'," & strCodConfig & ",'" & bolDevolvido & "')")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM Pedido where Produto = 'SQL SERVER'")
            strTabela = "Pedido"
            BarraProdgresso()
            '**********TOTAL**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Total order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO Total (Total) VALUES (150000.000)")
                        B += 1
                        LogDeErro()
                    Next


                End If

                Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
                Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
                Dim strCodCli As String = dt.Rows.Item(I).Item("CodCli").ToString
                Dim strTotal As String = dt.Rows.Item(I).Item("Total").ToString
                Dim strRecebido As String = dt.Rows.Item(I).Item("Recebido").ToString



                Dim strTroco As String = dt.Rows.Item(I).Item("Troco").ToString
                Dim strCusto As String = dt.Rows.Item(I).Item("Custo").ToString


                Dim strPorDesc As String = dt.Rows.Item(I).Item("PorDesc").ToString
                Dim strValDesc As String = dt.Rows.Item(I).Item("ValDesc").ToString
                Dim strPorAcre As String = dt.Rows.Item(I).Item("PorAcre").ToString
                Dim strValAcre As String = dt.Rows.Item(I).Item("ValAcre").ToString

                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


                Inserir("Insert Into Total (CodOrdem, Data, CodCli, Total, Recebido, Troco, Custo, PorDesc, ValDesc, PorAcre, ValAcre, CodConfig) Values(" & strCodOrdem & ",'" & strData & "'," & strCodCli & "," & Num(strTotal) & "," & Num(strRecebido) & "," & Num(strTroco) & "," & Num(strCusto) & "," & Num(strPorDesc) & "," & Num(strValDesc) & "," & Num(strPorAcre) & "," & Num(strValAcre) & "," & strCodConfig & ")")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM Total where Total = 150000.000")

            strTabela = "Total"
            BarraProdgresso()
            '**********USUARIO**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Usuario order by Codigo")
            For I = 0 To dt.Rows.Count - 1

                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString
                Dim strSenha As String = dt.Rows.Item(I).Item("Senha").ToString
                If strSenha <> "SPFC" Then
                    If strCodigo <> B Then

                        Dim int As Integer = strCodigo - B
                        Dim J As Integer


                        For J = 0 To int - 1
                            Inserir("INSERT INTO Usuario (Nome) VALUES ('SQL SERVER')")
                            B += 1
                            LogDeErro()
                        Next


                    End If

                    Dim strLogin As String = dt.Rows.Item(I).Item("Login").ToString
                    Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
                    Dim strNivel As String = dt.Rows.Item(I).Item("Nivel").ToString

                    Dim strPrincipal As String = dt.Rows.Item(I).Item("Principal").ToString

                    Dim strConsultas As String = dt.Rows.Item(I).Item("Consultas").ToString

                    Dim strRelatorios As String = dt.Rows.Item(I).Item("Relatorios").ToString
                    Dim strSkin As String = dt.Rows.Item(I).Item("Skin").ToString
                    Dim bolFundoPadrao As Boolean = dt.Rows.Item(I).Item("FundoPadrao").ToString
                    Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
                    Dim strExibicao As String = dt.Rows.Item(I).Item("Exibicao").ToString
                    With Me.DsNanoCommerce.Usuario

                        .Rows.Add()
                        .Rows.Item(.Rows.Count - 1).Item("Nome") = strNome
                        .Rows.Item(.Rows.Count - 1).Item("Login") = strLogin
                        .Rows.Item(.Rows.Count - 1).Item("Nivel") = strNivel
                        .Rows.Item(.Rows.Count - 1).Item("Senha") = strSenha
                        .Rows.Item(.Rows.Count - 1).Item("FundoPadrao") = bolFundoPadrao
                        .Rows.Item(.Rows.Count - 1).Item("CodConfig") = strCodConfig
                        .Rows.Item(.Rows.Count - 1).Item("PlanoFundo") = dt.Rows.Item(I).Item("PlanoFundo")
                        .Rows.Item(.Rows.Count - 1).Item("Exibicao") = strExibicao

                        .Rows.Item(.Rows.Count - 1).Item("Principal") = strPrincipal
                        .Rows.Item(.Rows.Count - 1).Item("Consultas") = strConsultas
                        .Rows.Item(.Rows.Count - 1).Item("Relatorios") = strRelatorios
                        .Rows.Item(.Rows.Count - 1).Item("Skin") = strSkin

                    End With
                    Me.Validate()
                    Me.UsuarioBindingSource.EndEdit()
                    Me.UsuarioTableAdapter.Update(Me.DsNanoCommerce.Usuario)
                    LogDeErro()
                End If

                B += 1


            Next
            Excluir("DELETE FROM Usuario where Nome = 'SQL SERVER'")


            strTabela = "Usuario"
            BarraProdgresso()
            '**********MOVIMENTO BANCARIO**********
            B = 1
            dt = CarregarAccess("SELECT * FROM MovimentoBancario order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO MovimentoBancario (TipoMovimento) VALUES ('SQL SERVER')")
                        B += 1
                        LogDeErro()
                    Next


                End If

                Dim strCodBanco As String = dt.Rows.Item(I).Item("CodBanco").ToString
                Dim strTipoMovimento As String = dt.Rows.Item(I).Item("TipoMovimento").ToString
                Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
                Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
                Dim strObservacao As String = dt.Rows.Item(I).Item("Observacao").ToString

                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


                Inserir("INSERT INTO MovimentoBancario (CodBanco, TipoMovimento, Valor, Data, Observacao, CodConfig)VALUES(" & strCodBanco & ",'" & strTipoMovimento & "'," & Num(strValor) & ",'" & strData & "','" & strObservacao & "'," & strCodConfig & ")")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM MovimentoBancario where TipoMovimento = 'SQL SERVER'")

            strTabela = "MovimentoBancario"
            BarraProdgresso()
            '**********QTDE**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Qtde order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO Qtde (Tamanho) VALUES ('SQL')")
                        B += 1
                        LogDeErro()
                    Next


                End If


                Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
                Dim strTamanho As String = dt.Rows.Item(I).Item("Tamanho").ToString
                Dim strQtdMinima As String = dt.Rows.Item(I).Item("QtdMinima").ToString
                Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
                Dim strLote As String = dt.Rows.Item(I).Item("Lote").ToString
                Dim strValorCusto As String = dt.Rows.Item(I).Item("ValorCusto").ToString
                Dim strEmFalta As String = dt.Rows.Item(I).Item("EmFalta").ToString

                Dim bolAcabou As Boolean = dt.Rows.Item(I).Item("Acabou").ToString

                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


                Inserir("INSERT INTO Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, ValorCusto, EmFalta, CodConfig, Acabou) VALUES (" & strCodProd & ",'" & strTamanho & "'," & Num(strQtdMinima) & "," & Num(strQtd) & ",'" & strLote & "'," & Num(strValorCusto) & ",'" & strEmFalta & "'," & strCodConfig & ",'" & bolAcabou & "')")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM Qtde where Tamanho = 'SQL'")
            strTabela = "Qtde"
            BarraProdgresso()
            '**********DEVOLUCAO**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Devolucao order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO Devolucao (Motivo) VALUES ('SQL')")
                        B += 1
                        LogDeErro()
                    Next


                End If

                Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
                Dim strQtde As String = dt.Rows.Item(I).Item("Qtde").ToString
                Dim strCodCli As String = dt.Rows.Item(I).Item("CodCli").ToString

                Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
                Dim strCodFunc As String = dt.Rows.Item(I).Item("CodFunc").ToString
                Dim strMotivo As String = dt.Rows.Item(I).Item("Motivo").ToString

                Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString

                Dim strTamanho As String = dt.Rows.Item(I).Item("Tamanho").ToString
                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


                Inserir("INSERT INTO Devolucao (CodProd, Qtde, CodCli, Data, CodFunc, Motivo, Tamanho, Valor, CodConfig) VALUES (" & strCodProd & "," & Num(strQtde) & ",'" & strCodCli & "','" & strData & "','" & strCodFunc & "','" & strMotivo & "','" & strTamanho & "'," & Num(strValor) & "," & strCodConfig & ")")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM Devolucao where Motivo = 'SQL'")
            strTabela = "Devolucao"
            BarraProdgresso()
            '**********LOG**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Log order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO Log (Antigo) VALUES ('SQL')")
                        B += 1
                        LogDeErro()
                    Next


                End If
                Dim strCodUser As String = dt.Rows.Item(I).Item("CodUser").ToString
                Dim strAntigo As String = dt.Rows.Item(I).Item("Antigo").ToString
                Dim strNovo As String = dt.Rows.Item(I).Item("Novo").ToString

                Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
                Dim strColuna As String = dt.Rows.Item(I).Item("Coluna").ToString
                Dim strTabela As String = dt.Rows.Item(I).Item("Tabela").ToString

                Dim strMotivo As String = dt.Rows.Item(I).Item("Motivo").ToString

                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & strData & "'," & strCodUser & ",'" & strAntigo & "','" & strNovo & "','" & strColuna & "','" & strTabela & "','" & strMotivo & "'," & strCodConfig & ")")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM Log where Antigo = 'SQL'")

            strTabela = "Log"
            BarraProdgresso()
            '**********REGISTRO**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Registro order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO Registro (Computador) VALUES ('SQL')")
                        B += 1
                        LogDeErro()
                    Next


                End If
                Dim strComputador As String = dt.Rows.Item(I).Item("Computador").ToString

                Inserir("INSERT INTO Registro (Computador) VALUES ('" & strComputador & "')")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM Registro where Computador = 'SQL'")


            strTabela = "Registro"
            BarraProdgresso()
            '**********DESCARTE**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Descarte order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO Descarte (Motivo) VALUES ('SQL')")
                        B += 1
                        LogDeErro()
                    Next


                End If

                Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
                Dim strQtde As String = dt.Rows.Item(I).Item("Qtde").ToString
                Dim strValorUnitario As String = dt.Rows.Item(I).Item("ValorUnitario").ToString
                Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
                Dim strCodFunc As String = dt.Rows.Item(I).Item("CodFunc").ToString
                Dim strMotivo As String = dt.Rows.Item(I).Item("Motivo").ToString

                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


                Inserir("INSERT INTO Descarte (CodProd, Qtde, ValorUnitario, Motivo, Data, CodFunc, CodConfig) VALUES (" & strCodProd & "," & Num(strQtde) & "," & Num(strValorUnitario) & ",'" & strMotivo & "','" & strData & "','" & strCodFunc & "'," & strCodConfig & ")")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM Descarte where Motivo = 'SQL'")

            strTabela = "Descarte"
            BarraProdgresso()

            '**********ITENS RECEITA**********
            B = 1
            dt = CarregarAccess("SELECT * FROM ItensReceita order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO ItensReceita (CodigoInterno) VALUES ('SQL')")
                        B += 1
                        LogDeErro()
                    Next


                End If

                Dim strCodigoInterno As String = dt.Rows.Item(I).Item("CodigoInterno").ToString
                Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
                Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
                Dim strCodProdInterno As String = dt.Rows.Item(I).Item("CodProdInterno").ToString
                Dim strCusto As String = dt.Rows.Item(I).Item("Custo").ToString
                Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString


                Inserir("Insert into ItensReceita (CodigoInterno, CodProd, CodProdInterno, Custo, Qtd, Valor) Values('" & strCodigoInterno & "'," & strCodProd & ",'" & strCodProdInterno & "'," & Num(strCusto) & "," & Num(strQtd) & "," & Num(strValor) & ")")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM ItensReceita where CodigoInterno = 'SQL'")
            strTabela = "ItensReceita"
            BarraProdgresso()

            '**********RECEITA**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Receita order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO Receita (CodigoInterno) VALUES ('SQL')")
                        B += 1
                        LogDeErro()
                    Next


                End If

                Dim strCodigoInterno As String = dt.Rows.Item(I).Item("CodigoInterno").ToString
                Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
                Dim strValorVenda As String = dt.Rows.Item(I).Item("ValorVenda").ToString
                Dim strValorCusto As String = dt.Rows.Item(I).Item("ValorCusto").ToString
                Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString
                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


                Inserir("Insert into Receita(CodigoInterno, Nome, ValorCusto, ValorVenda, Obs, CodConfig) Values('" & strCodigoInterno & "','" & strNome & "'," & Num(strValorCusto) & "," & Num(strValorVenda) & ",'" & strObs & "'," & strCodConfig & ")")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM Receita where CodigoInterno = 'SQL'")
            strTabela = "Receita"
            BarraProdgresso()

            '**********ORDENS**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Ordens order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO Ordens (Tabela) VALUES ('SQL')")
                        B += 1
                        LogDeErro()
                    Next


                End If

                Dim strCod As String = dt.Rows.Item(I).Item("Cod").ToString
                Dim strTabela As String = dt.Rows.Item(I).Item("Tabela").ToString
                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


                Inserir("Insert into Ordens(Cod, Tabela, CodConfig) Values('" & strCod & "','" & strTabela & "'," & strCodConfig & ")")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM Ordens where Tabela = 'SQL'")

            strTabela = "Ordens"
            BarraProdgresso()
            '**********TOTAL CONSIG**********
            B = 1
            dt = CarregarAccess("SELECT * FROM TotalConsig order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO TotalConsig (Desconto) VALUES ('SQL')")
                        B += 1
                        LogDeErro()
                    Next


                End If

                Dim strCodOrdens As String = dt.Rows.Item(I).Item("CodOrdens").ToString
                Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
                Dim strCodCli As String = dt.Rows.Item(I).Item("CodCli").ToString
                Dim strTotal As String = dt.Rows.Item(I).Item("Total").ToString
                Dim strDescricao As String = dt.Rows.Item(I).Item("Descricao").ToString

                Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
                Dim strCusto As String = dt.Rows.Item(I).Item("Custo").ToString
                Dim strDesconto As String = dt.Rows.Item(I).Item("Desconto").ToString



                Dim strEntrega As String = dt.Rows.Item(I).Item("Entrega").ToString
                Dim strCodFunc As String = dt.Rows.Item(I).Item("CodFunc").ToString
                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


                Inserir("Insert into TotalConsig(Data, CodCli, CodFunc, Total, Descricao, Desconto, Status, Custo, Entrega, CodConfig, CodOrdens) Values('" & strData & "'," & strCodCli & "," & strCodFunc & "," & Num(strTotal) & ",'" & strDescricao & "','" & strDesconto & "','" & strStatus & "'," & Num(strCusto) & ",'" & strEntrega & "'," & strCodConfig & "," & strCodOrdens & ")")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM TotalConsig where Desconto = 'SQL'")

            strTabela = "TotalConsig"
            BarraProdgresso()
            '**********ITENS CONSIG**********
            B = 1
            dt = CarregarAccess("SELECT * FROM ItensConsig order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO ItensConsig (Produto) VALUES ('SQL SERVER')")
                        B += 1
                        LogDeErro()
                    Next


                End If

                Dim strCodOrdens As String = dt.Rows.Item(I).Item("CodOrdens").ToString
                Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
                Dim strCodigoProduto As String = dt.Rows.Item(I).Item("CodigoProduto").ToString
                Dim strProduto As String = dt.Rows.Item(I).Item("Produto").ToString
                Dim strValorUnitario As String = dt.Rows.Item(I).Item("ValorUnitario").ToString

                Dim strValorTotal As String = dt.Rows.Item(I).Item("ValorTotal").ToString

                Dim strCodigoInterno As String = dt.Rows.Item(I).Item("CodigoInterno").ToString

                Dim strCusto As String = dt.Rows.Item(I).Item("Custo").ToString
                Dim strTamanho As String = dt.Rows.Item(I).Item("Tamanho").ToString
                Dim strUM As String = dt.Rows.Item(I).Item("UM").ToString

                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


                Inserir("Insert into ItensConsig (CodOrdens, Qtd, CodigoProduto, Produto, ValorUnitario, ValorTotal, CodigoInterno, Custo, UM, Tamanho, CodConfig) Values(" & strCodOrdens & "," & Num(strQtd) & ",'" & strCodigoProduto & "','" & strProduto & "'," & Num(strValorUnitario) & "," & Num(strValorTotal) & ",'" & strCodigoInterno & "'," & Num(strCusto) & ",'" & strUM & "','" & strTamanho & "'," & strCodConfig & ")")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM ItensConsig where Produto = 'SQL SERVER'")
            strTabela = "ItensConsig"
            BarraProdgresso()
            '**********COMANDA**********
            B = 1
            dt = CarregarAccess("SELECT * FROM Comanda order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO Comanda (CodComanda) VALUES ('SQL SERVER')")
                        B += 1
                        LogDeErro()
                    Next


                End If

                Dim strCodOrdens As String = dt.Rows.Item(I).Item("CodOrdens").ToString
                Dim strCodComanda As String = dt.Rows.Item(I).Item("CodComanda").ToString
                Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
                Dim strCodProdInterno As String = dt.Rows.Item(I).Item("CodProdInterno").ToString
                Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
                Dim strValorUnitario As String = dt.Rows.Item(I).Item("ValorUnitario").ToString
                Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
                Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


                Inserir("INSERT INTO Comanda (CodOrdens, CodComanda, CodProd, CodProdInterno, Qtd, ValorUnitario, Data, Status, CodConfig) VALUES (" & strCodOrdens & ",'" & strCodComanda & "'," & strCodProd & ",'" & strCodProdInterno & "'," & Num(strQtd) & "," & Num(strValorUnitario) & ",'" & strData & "','" & strStatus & "'," & strCodConfig & ")")
                B += 1
                LogDeErro()
            Next
            Excluir("DELETE FROM Comanda where CodComanda = 'SQL SERVER'")

            strTabela = "Comanda"
            BarraProdgresso()



            '**********CONFIG**********
            dt = CarregarAccess("SELECT * FROM Config order by Codigo")
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                Dim strEmpresa As String = dt.Rows.Item(I).Item("Empresa").ToString
                If strEmpresa <> "" Then


                    Dim strTelefone As String = dt.Rows.Item(I).Item("Telefone").ToString
                    Dim strEndereco As String = dt.Rows.Item(I).Item("Endereco").ToString
                    Dim strCNPJ As String = dt.Rows.Item(I).Item("CNPJ").ToString
                    Dim strOrigemRelease As String = dt.Rows.Item(I).Item("OrigemRelease").ToString
                    Dim strVersaoNano As String = dt.Rows.Item(I).Item("VersaoNano").ToString
                    Dim strEmiteCupom As String = dt.Rows.Item(I).Item("EmiteCupom").ToString
                    Dim strUsaTEF As String = dt.Rows.Item(I).Item("UsaTEF").ToString
                    Dim strCaminhoDaPastaRemessa As String = dt.Rows.Item(I).Item("CaminhoDaPastaRemessa").ToString

                    Dim strNumArqRM As String = dt.Rows.Item(I).Item("NumArqRM").ToString
                    If strNumArqRM = "" Then
                        strNumArqRM = "NULL"
                    End If
                    Dim strTemImpressora As String = dt.Rows.Item(I).Item("TemImpressora").ToString
                    Dim strCidade As String = dt.Rows.Item(I).Item("Cidade").ToString
                    Dim strModeloCarne As String = dt.Rows.Item(I).Item("ModeloCarne").ToString
                    Dim strTipoNano As String = dt.Rows.Item(I).Item("TipoNano").ToString
                    Dim strPastaSinc As String = dt.Rows.Item(I).Item("PastaSinc").ToString
                    Dim strDescricao As String = dt.Rows.Item(I).Item("Descricao").ToString
                    Dim strGerarComissao As String = dt.Rows.Item(I).Item("GerarComissao").ToString
                    Dim strValidarCPF As String = dt.Rows.Item(I).Item("ValidarCPF").ToString

                    Dim strTemGuilhotina As String = dt.Rows.Item(I).Item("TemGuilhotina").ToString
                    Dim strNomePCImpressora As String = dt.Rows.Item(I).Item("NomePCImpressora").ToString
                    Dim strTolerancia As String = dt.Rows.Item(I).Item("Tolerancia").ToString
                    Dim strJuros As String = dt.Rows.Item(I).Item("Juros").ToString
                    Dim strEstoqueZerado As String = dt.Rows.Item(I).Item("EstoqueZerado").ToString
                    Dim strAlterarParcelas As String = dt.Rows.Item(I).Item("AlterarParcelas").ToString
                    Dim strImpressora As String = dt.Rows.Item(I).Item("Impressora").ToString
                    Dim strPorta As String = dt.Rows.Item(I).Item("Porta").ToString
                    Dim strJurosParcela As String = dt.Rows.Item(I).Item("JurosParcela").ToString

                    Dim strTipoDesc As String = dt.Rows.Item(I).Item("TipoDesc").ToString
                    Dim strImpCodBarra As String = dt.Rows.Item(I).Item("ImpCodBarra").ToString
                    Dim strValidarCep As String = "True"
                    If I = 0 Then
                        Atualizar("UPDATE Config SET Empresa = '" & strEmpresa & "', Telefone = '" & strTelefone & "', Endereco = '" & strEndereco & "', CNPJ = '" & strCNPJ & "', OrigemRelease = '" & strOrigemRelease & "', VersaoNano = '" & strVersaoNano & "', EmiteCupom = '" & strEmiteCupom & "', UsaTEF = '" & strUsaTEF & "', CaminhoDaPastaRemessa = '" & strCaminhoDaPastaRemessa & "', NumArqRM = " & strNumArqRM & ", TemImpressora = '" & strTemImpressora & "', Cidade = '" & strCidade & "', ModeloCarne = '" & strModeloCarne & "', TipoNano = '" & strTipoNano & "', PastaSinc = '" & strPastaSinc & "', Descricao = '" & strDescricao & "', GerarComissao = '" & strGerarComissao & "', ValidarCPF = '" & strValidarCPF & "', TemGuilhotina = '" & strTemGuilhotina & "', " & _
                                   "NomePCImpressora = '" & strNomePCImpressora & "', Tolerancia = " & Num(strTolerancia) & ", Juros = " & Num(strJuros) & ", EstoqueZerado = '" & strEstoqueZerado & "', AlterarParcelas = '" & strAlterarParcelas & "', Impressora = '" & strImpressora & "', Porta = '" & strPorta & "', JurosParcela = " & Num(strJurosParcela) & ", TipoDesc = '" & strTipoDesc & "', ImpCodBarra = '" & strImpCodBarra & "', ValidarCep = '" & strValidarCep & "' where Codigo = " & strCodigo)
                    Else

                        Atualizar("INSERT INTO Config (Empresa, Telefone, Endereco, CNPJ, OrigemRelease, VersaoNano, EmiteCupom, UsaTEF, CaminhoDaPastaRemessa, NumArqRM, TemImpressora, Cidade, ModeloCarne, TipoNano, PastaSinc, Descricao, GerarComissao, ValidarCPF, TemGuilhotina, NomePCImpressora, Tolerancia, Juros, EstoqueZerado, AlterarParcelas, Impressora, Porta, JurosParcela, TipoDesc, ImpCodBarra, ValidarCep) VALUES ('" & strEmpresa & "','" & strTelefone & "','" & strEndereco & "','" & strCNPJ & "','" & strOrigemRelease & "','" & strVersaoNano & "','" & strEmiteCupom & "','" & strUsaTEF & "','" & strCaminhoDaPastaRemessa & "'," & strNumArqRM & ",'" & strTemImpressora & "','" & strCidade & "','" & strModeloCarne & "','" & strTipoNano & "','" & strPastaSinc & "','" & strDescricao & "','" & strGerarComissao & "','" & strValidarCPF & "','" & strTemGuilhotina & "'," & _
                                                   "'" & strNomePCImpressora & "'," & Num(strTolerancia) & "," & Num(strJuros) & ",'" & strEstoqueZerado & "','" & strAlterarParcelas & "','" & strImpressora & "','" & strPorta & "'," & Num(strJurosParcela) & ",'" & strTipoDesc & "','" & strImpCodBarra & "','" & strValidarCep & "')")

                    End If

                    LogDeErro()
                End If
            Next

            strTabela = "Config"
            BarraProdgresso()




        End If

        Me.Cursor = Cursors.Default
        Me.rtbMens.AppendText(vbCrLf & "Tabelas migradas com sucesso!")
        Me.btnOk.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'Dim limite As Integer = 10000
        'Dim cntr As Integer = 0
        'Dim F As Integer
        'pb.Value = 0
        'pb.Step = 1

        'For F = 0 To limite
        '    cntr = cntr + 1
        '    If cntr Mod 100 = 0 Then
        '        lbl.Text = cntr.ToString()

        '        pb.PerformStep()
        '        Application.DoEvents()
        '        System.Threading.Thread.Sleep(40)
        '    End If
        'Next

        'Dim dt As DataTable = CarregarDataTable("SELECT * FROM OPENROWSET ('Microsoft.Jet.OleDB.4.0','ACCESS 8.0;Database=C:\NANO\dbNanoCommerce.mdb',Cliente.accdb)")
        'Inserir("INSERT INTO Cliente SELECT * FROM OPENROWSET ('Microsoft.Jet.OleDB.4.0','EXCEL 8.0;Database=C:\Cliente.xls',Cliente$)")
       
    End Sub

    Private Sub BarraProdgresso()
        If pb.Value < 320 Then
            pb.Value = pb.Value + 10
        End If
        Clipboard.SetImage(Me.ImageList1.Images.Item(0))
        Me.rtbMens.Paste()
        Me.rtbMens.AppendText(" Tabela " & strTabela & " migrada com sucesso!" & vbCrLf)

        Application.DoEvents()
        System.Threading.Thread.Sleep(40)
    End Sub

    Private Sub LogDeErro()
        If MensagemDeErro <> "" Then
            Clipboard.SetImage(Me.ImageList1.Images.Item(1))
            Me.rtbMens.Paste()
            Me.rtbMens.AppendText(" " & MensagemDeErro & vbCrLf)
            MensagemDeErro = ""
            Application.DoEvents()
            System.Threading.Thread.Sleep(40)
        End If

    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    'Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
    '    Dim dt As DataTable
    '    Dim I As Integer
    '    dt = CarregarAccess("SELECT * FROM Cliente order by Codigo")
    '    For I = 0 To dt.Rows.Count - 1
    '        Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString
    '        Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString



    '        Dim strRG As String = dt.Rows.Item(I).Item("RGIE").ToString
    '        Dim strCPF As String = dt.Rows.Item(I).Item("CPF").ToString


    '        Dim strEnd As String = ""
    '        Dim strNum As String = ""
    '        If dt.Rows.Item(I).Item("Endereco").ToString <> "" Then
    '            Dim vetEnd As Array = Split(dt.Rows.Item(I).Item("Endereco").ToString, ",")
    '            If vetEnd.Length > 1 Then
    '                strEnd = vetEnd(0)
    '                If vetEnd(1).ToString <> "" Then
    '                    Dim vetNum As Array = Split(vetEnd(1), " ")
    '                    strNum = vetNum(0)
    '                End If

    '            Else
    '                strEnd = vetEnd(0)
    '            End If

    '        End If
    '        Dim strTel As String = dt.Rows.Item(I).Item("Telefone").ToString
    '        Dim strFax As String = dt.Rows.Item(I).Item("Fax").ToString
    '        Dim strCel As String = dt.Rows.Item(I).Item("Celular").ToString
    '        Dim strEmail As String = dt.Rows.Item(I).Item("Email").ToString
    '        Dim strData As String = dt.Rows.Item(I).Item("Data").ToString

    '        Dim strComp As String = ""
    '        Dim strBairro As String = dt.Rows.Item(I).Item("Bairro").ToString
    '        Dim strCep As String = dt.Rows.Item(I).Item("Cep").ToString
    '        Dim strCidade As String = dt.Rows.Item(I).Item("Cidade").ToString
    '        Dim strUF As String = dt.Rows.Item(I).Item("Estado").ToString
    '        Dim strFant As String = ""
    '        Dim bolIna As Boolean = False
    '        Dim strObs As String = ""
    '        Dim strStatus As String = "3"
    '        Dim strNasc As String
    '        If dt.Rows.Item(I).Item("Nascimento").ToString.Contains("/0974") Then
    '            strNasc = dt.Rows.Item(I).Item("Nascimento").ToString.Replace("0974", "1974")
    '        Else

    '            strNasc = dt.Rows.Item(I).Item("Nascimento").ToString
    '        End If

    '        Dim strSexo As String = dt.Rows.Item(I).Item("Sexo").ToString
    '        Dim strLimite As String = "1000,00"
    '        Dim strEmpresa As String = ""
    '        Dim strSalario As String = ""
    '        Dim strTelEmp As String = ""
    '        Dim strCredito As String = ""
    '        Dim strMarca As String = ""
    '        Dim strCodConfig As String = "1"
    '        Dim strP1 As String = ""
    '        Dim strP2 As String = ""
    '        Dim strRG1 As String = ""
    '        Dim strRG2 As String = ""
    '        Dim bolInativo As Boolean = False
    '        Inserir("INSERT INTO Cliente (Nome, RGIE, CPF, Endereco, Telefone, Fax, Celular, Email, Data, Numero, Complemento, Bairro, Cep, Cidade, Estado, Fantasia, Inadimplente, Observacao, Status, Nascimento, Sexo, Limite, Empresa, TelEmpresa, Salario, Credito, Marcas, CodConfig, Pessoa1, Pessoa2, RG1, RG2, Inativo) VALUES ('" & strNome.Replace("'", "´") & "','" & strRG & "','" & strCPF & "','" & strEnd.Replace("'", "´").Trim & "','" & strTel.Replace("'", "") & "','" & strFax.Replace("'", "") & "','" & strCel.Replace("'", "") & "','" & strEmail.Replace("'", "") & "','" & strData & "','" & strNum.Trim & "','" & strComp & "','" & strBairro.Replace("'", "´") & "','" & strCep & "','" & strCidade.Replace("'", "´") & "','" & strUF & "','" & strFant & "','" & bolIna & "','" & strObs.Replace("'", "´") & "','" & strStatus & "','" & strNasc & "','" & strSexo & "','" & strLimite & "','" & strEmpresa & "','" & strTelEmp & "','" & strSalario & "','" & strCredito & "','" & strMarca & "'," & strCodConfig & ",'" & strP1 & "','" & strP2 & "','" & strRG1 & "','" & strRG2 & "','" & bolInativo & "')")

    '    Next




    '    dt = CarregarAccess("SELECT * FROM Fornecedor order by Codigo")

    '    For I = 0 To dt.Rows.Count - 1
    '        Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString
    '        Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString.Replace("'", "´")
    '        Dim strCPF As String = dt.Rows.Item(I).Item("CPF").ToString
    '        Dim strEnd As String = ""
    '        Dim strNum As String = ""
    '        If dt.Rows.Item(I).Item("Endereco").ToString <> "" Then
    '            Dim vetEnd As Array = Split(dt.Rows.Item(I).Item("Endereco").ToString, ",")
    '            If vetEnd.Length > 1 Then
    '                strEnd = vetEnd(0)
    '                If vetEnd(1).ToString <> "" Then
    '                    Dim vetNum As Array = Split(vetEnd(1), " ")
    '                    strNum = vetNum(0)
    '                End If

    '            Else
    '                strEnd = vetEnd(0)
    '            End If


    '        End If
    '        Dim strComp As String = ""
    '        Dim strBairro As String = dt.Rows.Item(I).Item("Bairro").ToString
    '        Dim strCep As String = dt.Rows.Item(I).Item("Cep").ToString
    '        Dim strCidade As String = dt.Rows.Item(I).Item("Cidade").ToString
    '        Dim strUF As String = dt.Rows.Item(I).Item("Estado").ToString
    '        Dim strTelefone As String = dt.Rows.Item(I).Item("Telefone").ToString
    '        Dim strFax As String = dt.Rows.Item(I).Item("Fax").ToString
    '        Dim strCelular As String = dt.Rows.Item(I).Item("Celular").ToString
    '        Dim strEmail As String = dt.Rows.Item(I).Item("Email").ToString
    '        Dim strData As String = dt.Rows.Item(I).Item("Data").ToString

    '        Dim strIE As String = dt.Rows.Item(I).Item("IE").ToString
    '        Dim strContato As String = ""
    '        Dim strSite As String = dt.Rows.Item(I).Item("Site").ToString
    '        Dim strFantasia As String = ""
    '        Dim strStatus As String = "3"
    '        Dim strObs As String = ""

    '        Dim strCodConfig As String = "1"
    '        Dim strCodFor As String = dt.Rows.Item(I).Item("CodFor").ToString

    '        Inserir("INSERT INTO Fornecedor (Nome, CPF, Endereco, Numero, Complemento, Bairro, Cep, Cidade, Estado, Telefone, Fax, Celular, Email, Data, IE, Contato, Site, Fantasia, Status, Obs, CodConfig) VALUES ('" & strNome & "','" & strCPF & "','" & strEnd.Trim & "','" & strNum.Trim & "','" & strComp & "','" & strBairro & "','" & strCep & "','" & strCidade & "','" & strUF & "','" & strTelefone & "','" & strFax & "','" & strCelular & "','" & strEmail & "','" & strData & "','" & strIE & "','" & strContato & "','" & strSite & "','" & strFantasia & "','" & strStatus & "','" & strObs & "'," & strCodConfig & ")")
    '        InserirAccess("UPDATE Produto SET Fabricante = '" & strNome & "' where CodFor = '" & strCodFor.Trim & "'")
    '    Next



    '    dt = CarregarAccess("SELECT * FROM Grupo order by Codigo")

    '    For I = 0 To dt.Rows.Count - 1
    '        Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '        Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
    '        Dim strTipo As String = "G"
    '        Dim strCodGrupo As String = dt.Rows.Item(I).Item("CodGrupo").ToString

    '        Inserir("Insert into Grupo (Nome, Tipo) values('" & strNome & "','" & strTipo & "')")
    '        InserirAccess("UPDATE Produto SET Grupo = '" & strNome & "' where CodGrupo = '" & strCodGrupo.Trim & "'")

    '    Next


    '    dt = CarregarAccess("SELECT * FROM Produto order by Codigo")
    '    For I = 0 To dt.Rows.Count - 1
    '        Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '        Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
    '        Dim strUnidadeMedida As String = dt.Rows.Item(I).Item("UnidadeMedida").ToString
    '        Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
    '        Dim strValorCusto As String = dt.Rows.Item(I).Item("ValorCusto").ToString
    '        Dim strLocacao As String = ""
    '        Dim strCodigoInterno As String = dt.Rows.Item(I).Item("CodigoInterno").ToString
    '        Dim strPorcentagens As String = dt.Rows.Item(I).Item("Porcentagens").ToString
    '        Dim strFabricante As String = dt.Rows.Item(I).Item("Fabricante").ToString.Replace("'", "´")
    '        Dim strGrupo As String = dt.Rows.Item(I).Item("Grupo").ToString
    '        Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString
    '        Dim strData As String = dt.Rows.Item(I).Item("Data").ToString

    '        Dim strCodigoBarra As String = ""
    '        Dim strNivelComboCodCF As String = ""
    '        Dim strDesconto As String = ""


    '        Dim strSetor As String = ""
    '        Dim strTipo As String = "VENDA"

    '        Dim strQtd As Double = dt.Rows.Item(I).Item("Qtd").ToString
    '        Dim strQtdMin As Double = dt.Rows.Item(I).Item("QtdMin").ToString
    '        Dim strQtdMax As String = dt.Rows.Item(I).Item("QtdMax").ToString
    '        Dim strEmFalta As String
    '        If strQtdMin > strQtd Then
    '            strEmFalta = 1
    '        Else
    '            strEmFalta = 0
    '        End If

    '        Inserir("INSERT INTO Produto (Nome, UnidadeMedida, Valor, ValorCusto, Locacao,  CodigoInterno, Porcentagens, Fabricante, Grupo, Obs, Data, CodigoBarra, NivelComboCodCF, Desconto, Setor, Tipo) VALUES ('" & strNome.Replace("'", "´") & "','" & strUnidadeMedida & "'," & Num(strValor) & "," & Num(strValorCusto) & ",'" & strLocacao & "','" & strCodigoInterno & "','" & strPorcentagens & "','" & strFabricante.Replace("'", "´") & "','" & strGrupo & "','" & strObs.Replace("'", "´") & "','" & strData & "','" & strCodigoBarra & "','" & strNivelComboCodCF & "'," & Num(strDesconto) & ",'" & strSetor & "','" & strTipo & "')")
    '        If strQtd > 0 Then
    '            Inserir("INSERT INTO Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, ValorCusto, EmFalta, CodConfig, Acabou) VALUES (" & strCodigo & ",'U'," & Num(strQtdMin) & "," & Num(strQtd) & ",'" & "" & "'," & Num(strValorCusto) & ",'" & strEmFalta & "'," & "1" & ",'False')")
    '        End If

    '    Next
    'End Sub

    'Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
    '    Me.Cursor = Cursors.WaitCursor
    '    Dim dt As DataTable = Nothing
    '    Dim I, B As Integer
    '    B = 1

    '    Dim dtData As String = Format(Me.dtData.EditValue, "MM/dd/yyyy")

    '    '**********ORDEM**********

    '    'dt = CarregarOutroBD("SELECT Max(Codigo) as Codigo FROM Ordem where CodConfig =" & Me.txtCodLoja.EditValue)
    '    'If dt.Rows.Item(I).Item("Codigo").ToString <> "" Then
    '    '    Dim strCodigoOrdemMAX As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '    '    Inserir("INSERT INTO Ordem (Codigo, CodConfig) VALUES (" & strCodigoOrdemMAX & "," & Me.txtCodLoja.EditValue & ")")
    '    '    LogDeErro()
    '    'End If



    '    strTabela = "Ordem"

    '    BarraProdgresso()
    '    '**********BANCO**********
    '    'B = 1
    '    'dt = CarregarOutroBD("SELECT * FROM Banco order by Codigo")
    '    'For I = 0 To dt.Rows.Count - 1
    '    '    Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '    '    If strCodigo <> B Then

    '    '        Dim int As Integer = strCodigo - B
    '    '        Dim J As Integer


    '    '        For J = 0 To int - 1
    '    '            Inserir("INSERT INTO Ordem (Nome) VALUES ('SQL SERVER')")
    '    '            B += 1
    '    '            LogDeErro()
    '    '        Next


    '    '    End If
    '    '    Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
    '    '    Dim strSaldo As String = dt.Rows.Item(I).Item("Saldo").ToString
    '    '    Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString

    '    '    Inserir("INSERT INTO Banco (Nome, Saldo, CodConfig) VALUES ('" & strNome & "'," & Num(strSaldo) & "," & strCodConfig & ")")
    '    '    LogDeErro()
    '    '    B += 1
    '    'Next
    '    'Excluir("DELETE FROM Banco where Nome = 'SQL SERVER'")

    '    strTabela = "Banco"

    '    BarraProdgresso()

    '    '**********CAIXA**********

    '    Excluir("DELETE FROM Caixa where Data > '" & dtData & "' and CodConfig =" & Me.txtCodLoja.EditValue)

    '    B = 1
    '    dt = CarregarOutroBD("SELECT * FROM Caixa where Data >'" & Me.dtData.EditValue & "' and CodConfig =" & Me.txtCodLoja.EditValue & " order by Codigo")
    '    For I = 0 To dt.Rows.Count - 1
    '        Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '        'If strCodigo <> B Then

    '        '    Dim int As Integer = strCodigo - B
    '        '    Dim J As Integer

    '        '    For J = 0 To int - 1
    '        '        Inserir("INSERT INTO Caixa (Motivo) VALUES ('SQL SERVER')")
    '        '        B += 1
    '        '        LogDeErro()
    '        '    Next
    '        'End If

    '        Dim strMotivo As String = dt.Rows.Item(I).Item("Motivo").ToString
    '        Dim strCaixa As String = dt.Rows.Item(I).Item("Caixa").ToString
    '        Dim strCredito As String = dt.Rows.Item(I).Item("Credito").ToString
    '        Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
    '        Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
    '        Dim strData As String = Format(dt.Rows.Item(I).Item("Data"), "dd/MM/yyyy")
    '        Dim strCentroCusto As String = dt.Rows.Item(I).Item("CentroCusto").ToString


    '        Inserir("INSERT INTO Caixa (Motivo, Caixa, Credito, Pagamento, Valor, Data, CodConfig, CentroCusto) VALUES ('" & strMotivo & "','" & strCaixa & "','" & strCredito & "','" & strPagamento & "'," & Num(strValor) & ",'" & strData & "'," & Me.txtCodLoja.EditValue & ",'" & strCentroCusto & "')")
    '        LogDeErro()
    '        B += 1
    '    Next
    '    'Excluir("DELETE FROM Caixa where Motivo = 'SQL SERVER'")
    '    strTabela = "Caixa"
    '    BarraProdgresso()
    '    '**********CLIENTE**********
    '    B = 1
    '    dt = CarregarOutroBD("SELECT * FROM Cliente where Convert(SmallDateTime, Data) >'" & Me.dtData.EditValue & "'")
    '    For I = 0 To dt.Rows.Count - 1
    '        Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString
    '        Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString

    '        If strCodigo <> "1" Then
    '            'If strCodigo <> B Then

    '            '    Dim int As Integer = strCodigo - B
    '            '    Dim J As Integer


    '            '    For J = 0 To int - 1
    '            '        Inserir("INSERT INTO Cliente (Nome) VALUES ('SQL SERVER')")
    '            '        B += 1
    '            '        LogDeErro()
    '            '    Next


    '            'End If

    '            Dim strRG As String = dt.Rows.Item(I).Item("RGIE").ToString
    '            Dim strCPF As String = dt.Rows.Item(I).Item("CPF").ToString
    '            Dim strEnd As String = dt.Rows.Item(I).Item("Endereco").ToString
    '            Dim strTel As String = dt.Rows.Item(I).Item("Telefone").ToString
    '            Dim strFax As String = dt.Rows.Item(I).Item("Fax").ToString
    '            Dim strCel As String = dt.Rows.Item(I).Item("Celular").ToString
    '            Dim strEmail As String = dt.Rows.Item(I).Item("Email").ToString
    '            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
    '            Dim strNum As String = dt.Rows.Item(I).Item("Numero").ToString
    '            Dim strComp As String = dt.Rows.Item(I).Item("Complemento").ToString
    '            Dim strBairro As String = dt.Rows.Item(I).Item("Bairro").ToString
    '            Dim strCep As String = dt.Rows.Item(I).Item("Cep").ToString
    '            Dim strCidade As String = dt.Rows.Item(I).Item("Cidade").ToString
    '            Dim strUF As String = dt.Rows.Item(I).Item("Estado").ToString
    '            Dim strFant As String = dt.Rows.Item(I).Item("Fantasia").ToString
    '            Dim bolIna As Boolean = dt.Rows.Item(I).Item("Inadimplente").ToString
    '            Dim strObs As String = dt.Rows.Item(I).Item("Observacao").ToString
    '            Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
    '            Dim strNasc As String
    '            If dt.Rows.Item(I).Item("Nascimento").ToString.Contains("/0974") Then
    '                strNasc = dt.Rows.Item(I).Item("Nascimento").ToString.Replace("0974", "1974")
    '            Else

    '                strNasc = Format(dt.Rows.Item(I).Item("Nascimento"), "dd/MM/yyyy")
    '            End If

    '            Dim strSexo As String = dt.Rows.Item(I).Item("Sexo").ToString
    '            Dim strLimite As String = dt.Rows.Item(I).Item("Limite").ToString
    '            Dim strEmpresa As String = dt.Rows.Item(I).Item("Empresa").ToString
    '            Dim strSalario As String = dt.Rows.Item(I).Item("Salario").ToString
    '            Dim strTelEmp As String = dt.Rows.Item(I).Item("TelEmpresa").ToString
    '            Dim strCredito As String = dt.Rows.Item(I).Item("Credito").ToString
    '            Dim strMarca As String = dt.Rows.Item(I).Item("Marcas").ToString
    '            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
    '            Dim strP1 As String = dt.Rows.Item(I).Item("Pessoa1").ToString
    '            Dim strP2 As String = dt.Rows.Item(I).Item("Pessoa2").ToString
    '            Dim strRG1 As String = dt.Rows.Item(I).Item("RG1").ToString
    '            Dim strRG2 As String = dt.Rows.Item(I).Item("RG2").ToString
    '            Dim bolInativo As Boolean = dt.Rows.Item(I).Item("Inativo").ToString
    '            Inserir("INSERT INTO Cliente (Nome, RGIE, CPF, Endereco, Telefone, Fax, Celular, Email, Data, Numero, Complemento, Bairro, Cep, Cidade, Estado, Fantasia, Inadimplente, Observacao, Status, Nascimento, Sexo, Limite, Empresa, TelEmpresa, Salario, Credito, Marcas, CodConfig, Pessoa1, Pessoa2, RG1, RG2, Inativo) VALUES ('" & strNome.Replace("'", "´") & "','" & strRG & "','" & strCPF & "','" & strEnd.Replace("'", "´") & "','" & strTel & "','" & strFax & "','" & strCel & "','" & strEmail & "','" & strData & "','" & strNum & "','" & strComp & "','" & strBairro.Replace("'", "´") & "','" & strCep & "','" & strCidade.Replace("'", "´") & "','" & strUF & "','" & strFant & "','" & bolIna & "','" & strObs.Replace("'", "´") & "','" & strStatus & "','" & strNasc & "','" & strSexo & "','" & strLimite & "','" & strEmpresa & "','" & strTelEmp & "','" & strSalario & "','" & strCredito & "','" & strMarca & "'," & strCodConfig & ",'" & strP1 & "','" & strP2 & "','" & strRG1 & "','" & strRG2 & "','" & bolInativo & "')")
    '            LogDeErro()

    '        End If
    '        B += 1
    '    Next
    '    'Excluir("DELETE FROM Cliente where Nome = 'SQL SERVER'")
    '    strTabela = "Cliente"
    '    BarraProdgresso()

    '    '**********CONTA RECEBER**********

    '    'Excluir("DELETE FROM ContaReceber where Recebimento > '" & Me.dtData.EditValue & "' and CodConfig =" & Me.txtCodLoja.EditValue)


    '    B = 1
    '    dt = CarregarOutroBD("SELECT * FROM ContaReceber where Recebimento >'10/07/2012'")
    '    For I = 0 To dt.Rows.Count - 1
    '        Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '        'If strCodigo <> B Then

    '        '    Dim int As Integer = strCodigo - B
    '        '    Dim J As Integer


    '        '    For J = 0 To int - 1
    '        '        Inserir("INSERT INTO ContaReceber (Banco) VALUES ('SQL SERVER')")
    '        '        B += 1
    '        '        LogDeErro()
    '        '    Next


    '        'End If

    '        Excluir("Delete from ContaReceber where Codigo =" & strCodigo)

    '        Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
    '        Dim strDataVenda As String = dt.Rows.Item(I).Item("DataVenda").ToString
    '        Dim strCodCli As String = dt.Rows.Item(I).Item("CodCli").ToString
    '        Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString
    '        Dim strFormaPagamento As String = dt.Rows.Item(I).Item("FormaPagamento").ToString
    '        Dim strParcelas As String = dt.Rows.Item(I).Item("Parcelas").ToString
    '        Dim strValorParcela As String = dt.Rows.Item(I).Item("ValorParcela").ToString
    '        Dim strVencimento As String = dt.Rows.Item(I).Item("Vencimento").ToString
    '        Dim strValorVenda As String = dt.Rows.Item(I).Item("ValorVenda").ToString
    '        Dim strValorRecebido As String = dt.Rows.Item(I).Item("ValorRecebido").ToString
    '        Dim strRecebimento As String = dt.Rows.Item(I).Item("Recebimento").ToString
    '        Dim strRecebidoOK As Boolean = dt.Rows.Item(I).Item("RecebidoOK").ToString
    '        Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
    '        Dim strNumeroDocumento As String = dt.Rows.Item(I).Item("NumeroDocumento").ToString
    '        Dim strTipoCusto As String = dt.Rows.Item(I).Item("TipoCusto").ToString
    '        Dim strBanco As String = dt.Rows.Item(I).Item("Banco").ToString

    '        Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


    '        Inserir("INSERT INTO ContaReceber (CodOrdem, DataVenda, CodCli, Obs, FormaPagamento, Parcelas, ValorParcela, Vencimento, ValorVenda, ValorRecebido, Recebimento, RecebidoOK, Pagamento, NumeroDocumento, TipoCusto, Banco, CodConfig) VALUES (" & strCodOrdem & ",'" & strDataVenda & "'," & strCodCli & ",'" & strObs & "','" & strFormaPagamento & "','" & strParcelas & "'," & Num(strValorParcela) & ",'" & strVencimento & "'," & Num(strValorVenda) & "," & Num(strValorRecebido) & ",'" & strRecebimento & "','" & strRecebidoOK & "','" & strPagamento & "','" & strNumeroDocumento & "','" & strTipoCusto & "','" & strBanco & "'," & strCodConfig & ")")
    '        B += 1
    '        LogDeErro()
    '    Next

    '    Excluir("Delete From ContaReceber where CodOrdem > 2048 and CodConfig =2")


    '    dt = CarregarOutroBD("SELECT * FROM ContaReceber where Convert(SmallDateTime, DataVenda) > '09/07/2012' and CodConfig =2")
    '    For I = 0 To dt.Rows.Count - 1
    '        Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '        'If strCodigo <> B Then

    '        '    Dim int As Integer = strCodigo - B
    '        '    Dim J As Integer


    '        '    For J = 0 To int - 1
    '        '        Inserir("INSERT INTO ContaReceber (Banco) VALUES ('SQL SERVER')")
    '        '        B += 1
    '        '        LogDeErro()
    '        '    Next


    '        'End If

    '        ' Excluir("Delete from ContaReceber where Codigo =" & strCodigo)

    '        Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
    '        Dim strDataVenda As String = dt.Rows.Item(I).Item("DataVenda").ToString
    '        Dim strCodCli As String = dt.Rows.Item(I).Item("CodCli").ToString
    '        Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString
    '        Dim strFormaPagamento As String = dt.Rows.Item(I).Item("FormaPagamento").ToString
    '        Dim strParcelas As String = dt.Rows.Item(I).Item("Parcelas").ToString
    '        Dim strValorParcela As String = dt.Rows.Item(I).Item("ValorParcela").ToString
    '        Dim strVencimento As String = dt.Rows.Item(I).Item("Vencimento").ToString
    '        Dim strValorVenda As String = dt.Rows.Item(I).Item("ValorVenda").ToString
    '        Dim strValorRecebido As String = dt.Rows.Item(I).Item("ValorRecebido").ToString
    '        Dim strRecebimento As String = dt.Rows.Item(I).Item("Recebimento").ToString
    '        Dim strRecebidoOK As Boolean = dt.Rows.Item(I).Item("RecebidoOK").ToString
    '        Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
    '        Dim strNumeroDocumento As String = dt.Rows.Item(I).Item("NumeroDocumento").ToString
    '        Dim strTipoCusto As String = dt.Rows.Item(I).Item("TipoCusto").ToString
    '        Dim strBanco As String = dt.Rows.Item(I).Item("Banco").ToString

    '        Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


    '        Inserir("INSERT INTO ContaReceber (CodOrdem, DataVenda, CodCli, Obs, FormaPagamento, Parcelas, ValorParcela, Vencimento, ValorVenda, ValorRecebido, Recebimento, RecebidoOK, Pagamento, NumeroDocumento, TipoCusto, Banco, CodConfig) VALUES (" & strCodOrdem & ",'" & strDataVenda & "'," & strCodCli & ",'" & strObs & "','" & strFormaPagamento & "','" & strParcelas & "'," & Num(strValorParcela) & ",'" & strVencimento & "'," & Num(strValorVenda) & "," & Num(strValorRecebido) & ",'" & strRecebimento & "','" & strRecebidoOK & "','" & strPagamento & "','" & strNumeroDocumento & "','" & strTipoCusto & "','" & strBanco & "'," & strCodConfig & ")")
    '        B += 1
    '        LogDeErro()
    '    Next

    '    strTabela = "ContaReceber"
    '    BarraProdgresso()
    '    '**********FORNECEDOR**********
    '    'B = 1
    '    'dt = CarregarAccess("SELECT * FROM Fornecedor order by Codigo")
    '    'For I = 0 To dt.Rows.Count - 1
    '    '    Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '    '    If strCodigo <> B Then

    '    '        Dim int As Integer = strCodigo - B
    '    '        Dim J As Integer


    '    '        For J = 0 To int - 1
    '    '            Inserir("INSERT INTO Fornecedor (Nome) VALUES ('SQL SERVER')")
    '    '            B += 1
    '    '            LogDeErro()
    '    '        Next


    '    '    End If
    '    '    Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString.Replace("'", "´")
    '    '    Dim strCPF As String = dt.Rows.Item(I).Item("CPF").ToString
    '    '    Dim strEnd As String = dt.Rows.Item(I).Item("Endereco").ToString
    '    '    Dim strNum As String = dt.Rows.Item(I).Item("Numero").ToString
    '    '    Dim strComp As String = dt.Rows.Item(I).Item("Complemento").ToString
    '    '    Dim strBairro As String = dt.Rows.Item(I).Item("Bairro").ToString
    '    '    Dim strCep As String = dt.Rows.Item(I).Item("Cep").ToString
    '    '    Dim strCidade As String = dt.Rows.Item(I).Item("Cidade").ToString
    '    '    Dim strUF As String = dt.Rows.Item(I).Item("Estado").ToString
    '    '    Dim strTelefone As String = dt.Rows.Item(I).Item("Telefone").ToString
    '    '    Dim strFax As String = dt.Rows.Item(I).Item("Fax").ToString
    '    '    Dim strCelular As String = dt.Rows.Item(I).Item("Celular").ToString
    '    '    Dim strEmail As String = dt.Rows.Item(I).Item("Email").ToString
    '    '    Dim strData As String = dt.Rows.Item(I).Item("Data").ToString

    '    '    Dim strIE As String = dt.Rows.Item(I).Item("IE").ToString
    '    '    Dim strContato As String = dt.Rows.Item(I).Item("Contato").ToString
    '    '    Dim strSite As String = dt.Rows.Item(I).Item("Site").ToString
    '    '    Dim strFantasia As String = dt.Rows.Item(I).Item("Fantasia").ToString
    '    '    Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
    '    '    Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString

    '    '    Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


    '    '    Inserir("INSERT INTO Fornecedor (Nome, CPF, Endereco, Numero, Complemento, Bairro, Cep, Cidade, Estado, Telefone, Fax, Celular, Email, Data, IE, Contato, Site, Fantasia, Status, Obs, CodConfig) VALUES ('" & strNome & "','" & strCPF & "','" & strEnd & "','" & strNum & "','" & strComp & "','" & strBairro & "','" & strCep & "','" & strCidade & "','" & strUF & "','" & strTelefone & "','" & strFax & "','" & strCelular & "','" & strEmail & "','" & strData & "','" & strIE & "','" & strContato & "','" & strSite & "','" & strFantasia & "','" & strStatus & "','" & strObs & "'," & strCodConfig & ")")
    '    '    B += 1
    '    '    LogDeErro()
    '    'Next
    '    'Excluir("DELETE FROM Fornecedor where Nome = 'SQL SERVER'")
    '    strTabela = "Fornecedor"
    '    BarraProdgresso()

    '    '**********CONTA PAGAR**********
    '    'B = 1
    '    'dt = CarregarAccess("SELECT * FROM ContaPagar order by Codigo")
    '    'For I = 0 To dt.Rows.Count - 1
    '    '    Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '    '    If strCodigo <> B Then

    '    '        Dim int As Integer = strCodigo - B
    '    '        Dim J As Integer


    '    '        For J = 0 To int - 1
    '    '            Inserir("INSERT INTO ContaPagar (Banco) VALUES ('SQL SERVER')")
    '    '            B += 1
    '    '            LogDeErro()
    '    '        Next


    '    '    End If

    '    '    Dim strCodFor As String = dt.Rows.Item(I).Item("CodFor").ToString
    '    '    Dim strTipoConta As String = dt.Rows.Item(I).Item("TipoConta").ToString
    '    '    Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
    '    '    Dim strFormaPagamento As String = dt.Rows.Item(I).Item("FormaPagamento").ToString
    '    '    Dim strParcelas As String = dt.Rows.Item(I).Item("Parcelas").ToString
    '    '    Dim strValorParcela As String = dt.Rows.Item(I).Item("ValorParcela").ToString
    '    '    Dim strVencimento As String = dt.Rows.Item(I).Item("Vencimento").ToString
    '    '    Dim strDataPagamento As String = dt.Rows.Item(I).Item("DataPagamento").ToString
    '    '    Dim strValorPago As String = dt.Rows.Item(I).Item("ValorPago").ToString
    '    '    Dim strDescricao As String = dt.Rows.Item(I).Item("Descricao").ToString
    '    '    Dim strPagoOK As Boolean = dt.Rows.Item(I).Item("PagoOK").ToString
    '    '    Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
    '    '    Dim strNumeroDocumento As String = dt.Rows.Item(I).Item("NumeroDocumento").ToString
    '    '    Dim strTipoCusto As String = dt.Rows.Item(I).Item("TipoCusto").ToString
    '    '    Dim strBanco As String = dt.Rows.Item(I).Item("Banco").ToString

    '    '    Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString

    '    '    Inserir("INSERT INTO ContaPagar (CodFor, TipoConta, Valor, FormaPagamento, Parcelas, ValorParcela, Vencimento, Pagamento, ValorPago, Descricao, PagoOK, NumeroDocumento, TipoCusto, Banco, CodConfig) VALUES (" & strCodFor & ",'" & strTipoConta & "'," & Num(strValor) & ",'" & strFormaPagamento & "','" & strParcelas & "'," & Num(strValorParcela) & ",'" & strVencimento & "','" & strPagamento & "'," & Num(strValorPago) & ",'" & strDescricao & "','" & strPagoOK & "','" & strNumeroDocumento & "','" & strTipoCusto & "','" & strBanco & "'," & strCodConfig & ")")
    '    '    B += 1
    '    '    LogDeErro()
    '    'Next
    '    'Excluir("DELETE FROM ContaPagar where Banco = 'SQL SERVER'")

    '    strTabela = "ContaPagar"
    '    BarraProdgresso()
    '    '**********TOTAL ENTRADA NF**********
    '    B = 1
    '    'dt = CarregarAccess("SELECT * FROM TotalEntradaNF order by Codigo")
    '    'For I = 0 To dt.Rows.Count - 1
    '    '    Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '    '    If strCodigo <> B Then

    '    '        Dim int As Integer = strCodigo - B
    '    '        Dim J As Integer


    '    '        For J = 0 To int - 1
    '    '            Inserir("INSERT INTO TotalEntradaNF (Lote) VALUES ('SQL SERVER')")
    '    '            B += 1
    '    '            LogDeErro()
    '    '        Next


    '    '    End If

    '    '    Dim strNumeroNF As String = dt.Rows.Item(I).Item("NumeroNF").ToString
    '    '    Dim strCodFor As String = dt.Rows.Item(I).Item("CodFor").ToString
    '    '    Dim strTotal As String = dt.Rows.Item(I).Item("Total").ToString
    '    '    Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString
    '    '    Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
    '    '    Dim strEstoqueOK As Boolean = dt.Rows.Item(I).Item("EstoqueOK").ToString
    '    '    Dim strLote As String = dt.Rows.Item(I).Item("Lote").ToString
    '    '    Dim strDesconto As String = dt.Rows.Item(I).Item("Desconto").ToString
    '    '    Dim strTipo As String = dt.Rows.Item(I).Item("Tipo").ToString
    '    '    Dim strSerie As String = dt.Rows.Item(I).Item("Serie").ToString
    '    '    Dim strValorFrete As String = dt.Rows.Item(I).Item("ValorFrete").ToString
    '    '    Dim strValorSeguro As String = dt.Rows.Item(I).Item("ValorSeguro").ToString

    '    '    Dim strOutrasDespesas As String = dt.Rows.Item(I).Item("OutrasDespesas").ToString
    '    '    Dim strICMS As String = dt.Rows.Item(I).Item("ICMS").ToString
    '    '    Dim strIPI As String = dt.Rows.Item(I).Item("IPI").ToString


    '    '    Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString

    '    '    Inserir("INSERT INTO TotalEntradaNF (NumeroNF, CodFor, Total, Obs, Data, EstoqueOK, Desconto, Tipo, Serie, ValorFrete, ValorSeguro, OutrasDespesas, ICMS, IPI, CodConfig) VALUES ('" & strNumeroNF & "'," & strCodFor & "," & Num(strTotal) & ",'" & strObs & "','" & strData & "','" & strEstoqueOK & "','" & strDesconto & "','" & strTipo & "','" & strSerie & "','" & strValorFrete & "','" & strValorSeguro & "','" & strOutrasDespesas & "','" & strICMS & "','" & strIPI & "'," & strCodConfig & ")")
    '    '    B += 1
    '    '    LogDeErro()
    '    'Next
    '    'Excluir("DELETE FROM TotalEntradaNF where Lote = 'SQL SERVER'")

    '    strTabela = "TotalEntradaNF"
    '    BarraProdgresso()
    '    '**********REPRESENTANTE**********
    '    B = 1
    '    'dt = CarregarAccess("SELECT * FROM Representante order by Codigo")
    '    'For I = 0 To dt.Rows.Count - 1
    '    '    Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '    '    If strCodigo <> B Then

    '    '        Dim int As Integer = strCodigo - B
    '    '        Dim J As Integer


    '    '        For J = 0 To int - 1
    '    '            Inserir("INSERT INTO Representante (Nome) VALUES ('SQL SERVER')")
    '    '            B += 1
    '    '            LogDeErro()
    '    '        Next


    '    '    End If
    '    '    Dim strCodFor As String = dt.Rows.Item(I).Item("CodFor").ToString
    '    '    Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
    '    '    Dim strTel1 As String = dt.Rows.Item(I).Item("Tel1").ToString
    '    '    Dim strTel2 As String = dt.Rows.Item(I).Item("Tel2").ToString
    '    '    Dim strWeb As String = dt.Rows.Item(I).Item("Web").ToString


    '    '    Inserir("INSERT INTO Representante (CodFor, Nome, Tel1, Tel2, Web) VALUES (" & strCodFor & ",'" & strNome & "','" & strTel1 & "','" & strTel2 & "','" & strWeb & "')")
    '    '    B += 1
    '    '    LogDeErro()
    '    'Next
    '    'Excluir("DELETE FROM Representante where Nome = 'SQL SERVER'")

    '    strTabela = "Representante"
    '    BarraProdgresso()


    '    '**********FUNCIONARIO**********
    '    B = 1
    '    'dt = CarregarAccess("SELECT * FROM Funcionario order by Codigo")
    '    'For I = 0 To dt.Rows.Count - 1
    '    '    Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '    '    If strCodigo <> B Then

    '    '        Dim int As Integer = strCodigo - B
    '    '        Dim J As Integer


    '    '        For J = 0 To int - 1
    '    '            Inserir("INSERT INTO Funcionario (Nome) VALUES ('SQL SERVER')")
    '    '            B += 1
    '    '            LogDeErro()
    '    '        Next


    '    '    End If


    '    '    Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
    '    '    Dim strCPF As String = dt.Rows.Item(I).Item("CPF").ToString
    '    '    Dim strRG As String = dt.Rows.Item(I).Item("RG").ToString
    '    '    Dim strTelefone As String = dt.Rows.Item(I).Item("Telefone").ToString
    '    '    Dim strCelular As String = dt.Rows.Item(I).Item("Celular").ToString
    '    '    Dim strEnd As String = dt.Rows.Item(I).Item("Endereco").ToString
    '    '    Dim strBairro As String = dt.Rows.Item(I).Item("Bairro").ToString
    '    '    Dim strCidade As String = dt.Rows.Item(I).Item("Cidade").ToString
    '    '    Dim strNascimento As String = dt.Rows.Item(I).Item("Nascimento").ToString
    '    '    Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString

    '    '    Dim strPorcComissao As String = dt.Rows.Item(I).Item("PorcComissao").ToString

    '    '    Dim strFuncao As String = dt.Rows.Item(I).Item("Funcao").ToString
    '    '    Dim strDataAdmissao As String = dt.Rows.Item(I).Item("DataAdmissao").ToString
    '    '    Dim strDataDemissao As String = dt.Rows.Item(I).Item("DataDemissao").ToString
    '    '    Dim strEmail As String = dt.Rows.Item(I).Item("Email").ToString

    '    '    Dim bolAtivo As Boolean = dt.Rows.Item(I).Item("Ativo").ToString

    '    '    Dim strSangue As String = dt.Rows.Item(I).Item("Sangue").ToString
    '    '    Dim strAlergia As String = dt.Rows.Item(I).Item("Alergia").ToString
    '    '    Dim strCEP As String = dt.Rows.Item(I).Item("CEP").ToString

    '    '    Dim strUF As String = dt.Rows.Item(I).Item("UF").ToString
    '    '    Dim strComplemento As String = dt.Rows.Item(I).Item("Complemento").ToString
    '    '    Dim strNum As String = dt.Rows.Item(I).Item("Num").ToString

    '    '    Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString

    '    '    Inserir("INSERT INTO Funcionario (Nome, CPF, RG, Telefone, Celular, Endereco, Bairro, Cidade, Nascimento, Obs, PorcComissao, Funcao, DataAdmissao, DataDemissao, Email, Ativo, Sangue, Alergia, CEP, UF, Complemento, Num, CodConfig) VALUES ('" & strNome & "','" & strCPF & "','" & strRG & "','" & strTelefone & "','" & strCelular & "','" & strEnd & "','" & strBairro & "','" & strCidade & "','" & strNascimento & "','" & strObs & "','" & strPorcComissao & "','" & strFuncao & "','" & strDataAdmissao & "','" & strDataDemissao & "','" & strEmail & "','" & bolAtivo & "','" & strSangue & "','" & strAlergia & "','" & strCEP & "','" & strUF & "','" & strComplemento & "','" & strNum & "'," & strCodConfig & ")")
    '    '    LogDeErro()
    '    '    B += 1
    '    'Next
    '    'Excluir("DELETE FROM Funcionario where Nome = 'SQL SERVER'")

    '    strTabela = "Funcionario"
    '    BarraProdgresso()
    '    '**********COMISSAO**********
    '    B = 1



    '    Excluir("Delete from Comissao where Data >'" & dtData & "' and CodConfig = " & Me.txtCodLoja.EditValue)


    '    dt = CarregarOutroBD("SELECT * FROM Comissao where Data >'" & Me.dtData.EditValue & "' and CodConfig = " & Me.txtCodLoja.EditValue)
    '    For I = 0 To dt.Rows.Count - 1
    '        Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '        'If strCodigo <> B Then

    '        '    Dim int As Integer = strCodigo - B
    '        '    Dim J As Integer


    '        '    For J = 0 To int - 1
    '        '        Inserir("INSERT INTO Comissao (Funcionario) VALUES ('SQL SERVER')")
    '        '        B += 1
    '        '        LogDeErro()
    '        '    Next


    '        'End If

    '        Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
    '        Dim strCodFunc As String = dt.Rows.Item(I).Item("CodFunc").ToString
    '        Dim strFuncionario As String = dt.Rows.Item(I).Item("Funcionario").ToString
    '        Dim strValorProduto As String = dt.Rows.Item(I).Item("ValorProduto").ToString
    '        Dim strPorcentagem As String = dt.Rows.Item(I).Item("Porcentagem").ToString
    '        Dim strValorComissao As String = dt.Rows.Item(I).Item("ValorComissao").ToString
    '        Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
    '        Dim strMotivo As String = dt.Rows.Item(I).Item("Motivo").ToString
    '        Dim strTipo As String = dt.Rows.Item(I).Item("Tipo").ToString
    '        Dim strCodConfig As String = Me.txtCodLoja.EditValue

    '        Inserir("INSERT INTO Comissao (CodOrdem, CodFunc, Funcionario, ValorProduto, Porcentagem, ValorComissao, Data, Motivo, Tipo, CodConfig) VALUES ('" & strCodOrdem & "','" & strCodFunc & "','" & strFuncionario & "'," & Num(strValorProduto) & "," & Num(strPorcentagem) & "," & Num(strValorComissao) & ",'" & strData & "','" & strMotivo & "','" & strTipo & "'," & strCodConfig & ")")

    '        B += 1
    '        LogDeErro()
    '    Next
    '    'Excluir("DELETE FROM Comissao where Funcionario = 'SQL SERVER'")
    '    strTabela = "Comissao"
    '    BarraProdgresso()
    '    '**********RECEBIMENTO**********
    '    B = 1

    '    Excluir("Delete from Recebimento where Data >'" & dtData & "' and CodConfig = " & Me.txtCodLoja.EditValue)


    '    dt = CarregarOutroBD("SELECT * FROM Recebimento where Data >'" & Me.dtData.EditValue & "' and CodConfig = " & Me.txtCodLoja.EditValue)

    '    For I = 0 To dt.Rows.Count - 1
    '        Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '        'If strCodigo <> B Then

    '        '    Dim int As Integer = strCodigo - B
    '        '    Dim J As Integer


    '        '    For J = 0 To int - 1
    '        '        Inserir("INSERT INTO Recebimento (FormaPagamento) VALUES ('SQL SERVER')")
    '        '        B += 1
    '        '        LogDeErro()
    '        '    Next


    '        'End If

    '        Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
    '        Dim strFormaPagamento As String = dt.Rows.Item(I).Item("FormaPagamento").ToString
    '        Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
    '        Dim strDocumento As String = dt.Rows.Item(I).Item("Documento").ToString
    '        Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
    '        Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
    '        Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString

    '        Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString

    '        Inserir("Insert into Recebimento (CodOrdem, FormaPagamento, Pagamento, Valor, Documento, Data, Obs, CodConfig) Values(" & strCodOrdem & ",'" & strFormaPagamento & "','" & strPagamento & "'," & Num(strValor) & ",'" & strDocumento & "','" & strData & "','" & strObs & "'," & strCodConfig & ")")
    '        B += 1
    '        LogDeErro()
    '    Next
    '    ' Excluir("DELETE FROM Recebimento where FormaPagamento = 'SQL SERVER'")

    '    strTabela = "Recebimento"
    '    BarraProdgresso()
    '    '**********FUTURO**********
    '    B = 1
    '    'dt = CarregarAccess("SELECT * FROM Futuro order by Codigo")
    '    'For I = 0 To dt.Rows.Count - 1
    '    '    Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '    '    If strCodigo <> B Then

    '    '        Dim int As Integer = strCodigo - B
    '    '        Dim J As Integer


    '    '        For J = 0 To int - 1
    '    '            Inserir("INSERT INTO Futuro (Pagamento) VALUES ('SQL SERVER')")
    '    '            B += 1
    '    '            LogDeErro()
    '    '        Next


    '    '    End If
    '    '    Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
    '    '    Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
    '    '    Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
    '    '    Dim strTotal As String = dt.Rows.Item(I).Item("Total").ToString
    '    '    Dim strTotalDesconto As String = dt.Rows.Item(I).Item("TotalDesconto").ToString
    '    '    Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString

    '    '    Inserir("Insert into Futuro (Data, CodOrdem, Pagamento, Total, TotalDesconto, CodConfig) Values('" & strData & "'," & strCodOrdem & ",'" & strPagamento & "'," & Num(strTotal) & "," & Num(strTotalDesconto) & "," & strCodConfig & ")")
    '    '    B += 1
    '    '    LogDeErro()
    '    'Next
    '    'Excluir("DELETE FROM Futuro where Pagamento = 'SQL SERVER'")

    '    strTabela = "Futuro"
    '    BarraProdgresso()
    '    '**********GRUPO**********
    '    'B = 1
    '    'dt = CarregarAccess("SELECT * FROM Grupo order by Codigo")

    '    'For I = 0 To dt.Rows.Count - 1
    '    '    Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '    '    If strCodigo <> B Then

    '    '        Dim int As Integer = strCodigo - B
    '    '        Dim J As Integer


    '    '        For J = 0 To int - 1
    '    '            Dim strN As String = J + strCodigo
    '    '            Inserir("INSERT INTO Grupo (Nome, Tipo) VALUES ('" & strN & "','Q')")
    '    '            B += 1
    '    '            LogDeErro()
    '    '        Next


    '    '    End If
    '    '    Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
    '    '    Dim strTipo As String = dt.Rows.Item(I).Item("Tipo").ToString


    '    '    Inserir("Insert into Grupo (Nome, Tipo) values('" & strNome & "','" & strTipo & "')")
    '    '    B += 1
    '    '    LogDeErro()
    '    'Next
    '    'Excluir("DELETE FROM Grupo where Tipo = 'Q'")

    '    strTabela = "Grupo"
    '    BarraProdgresso()
    '    '**********PRODUTO**********
    '    B = 1
    '    'dt = CarregarAccess("SELECT * FROM Produto order by Codigo")
    '    'For I = 0 To dt.Rows.Count - 1
    '    '    Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '    '    If strCodigo <> B Then

    '    '        Dim int As Integer = strCodigo - B
    '    '        Dim J As Integer


    '    '        For J = 0 To int - 1
    '    '            Inserir("INSERT INTO Produto (Nome) VALUES ('SQL SERVER')")
    '    '            B += 1
    '    '            LogDeErro()
    '    '        Next


    '    '    End If

    '    '    Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
    '    '    Dim strUnidadeMedida As String = dt.Rows.Item(I).Item("UnidadeMedida").ToString
    '    '    Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
    '    '    Dim strValorCusto As String = dt.Rows.Item(I).Item("ValorCusto").ToString
    '    '    Dim strLocacao As String = dt.Rows.Item(I).Item("Locacao").ToString
    '    '    Dim strCodigoInterno As String = dt.Rows.Item(I).Item("CodigoInterno").ToString
    '    '    Dim strPorcentagens As String = dt.Rows.Item(I).Item("Porcentagens").ToString
    '    '    Dim strFabricante As String = dt.Rows.Item(I).Item("Fabricante").ToString.Replace("'", "´")
    '    '    Dim strGrupo As String = dt.Rows.Item(I).Item("Grupo").ToString
    '    '    Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString
    '    '    Dim strData As String = dt.Rows.Item(I).Item("Data").ToString

    '    '    Dim strCodigoBarra As String = dt.Rows.Item(I).Item("CodigoBarra").ToString
    '    '    Dim strNivelComboCodCF As String = dt.Rows.Item(I).Item("NivelComboCodCF").ToString
    '    '    Dim strDesconto As String = dt.Rows.Item(I).Item("Desconto").ToString


    '    '    Dim strSetor As String = dt.Rows.Item(I).Item("Setor").ToString
    '    '    Dim strTipo As String = dt.Rows.Item(I).Item("Tipo").ToString

    '    '    Inserir("INSERT INTO Produto (Nome, UnidadeMedida, Valor, ValorCusto, Locacao,  CodigoInterno, Porcentagens, Fabricante, Grupo, Obs, Data, CodigoBarra, NivelComboCodCF, Desconto, Setor, Tipo) VALUES ('" & strNome.Replace("'", "´") & "','" & strUnidadeMedida & "'," & Num(strValor) & "," & Num(strValorCusto) & ",'" & strLocacao & "','" & strCodigoInterno & "','" & strPorcentagens & "','" & strFabricante.Replace("'", "´") & "','" & strGrupo & "','" & strObs.Replace("'", "´") & "','" & strData & "','" & strCodigoBarra & "','" & strNivelComboCodCF & "'," & Num(strDesconto) & ",'" & strSetor & "','" & strTipo & "')")
    '    '    B += 1
    '    '    LogDeErro()
    '    'Next
    '    'Excluir("DELETE FROM Produto where Nome = 'SQL SERVER'")


    '    strTabela = "Produto"
    '    BarraProdgresso()
    '    ''**********ENTRADA NF**********
    '    'B = 1
    '    'dt = CarregarAccess("SELECT * FROM EntradaNF order by Codigo")
    '    'For I = 0 To dt.Rows.Count - 1
    '    '    Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '    '    If strCodigo <> B Then

    '    '        Dim int As Integer = strCodigo - B
    '    '        Dim J As Integer


    '    '        For J = 0 To int - 1
    '    '            Inserir("INSERT INTO EntradaNF (Produto) VALUES ('SQL SERVER')")
    '    '            B += 1
    '    '            LogDeErro()
    '    '        Next


    '    '    End If

    '    '    Dim strCodTotNF As String = dt.Rows.Item(I).Item("CodTotNF").ToString
    '    '    Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
    '    '    Dim strTamanho As String = dt.Rows.Item(I).Item("Tamanho").ToString
    '    '    Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
    '    '    Dim strValorUnitario As String = dt.Rows.Item(I).Item("ValorUnitario").ToString
    '    '    Dim strValorTotal As String = dt.Rows.Item(I).Item("ValorTotal").ToString
    '    '    Dim strProduto As String = dt.Rows.Item(I).Item("Produto").ToString
    '    '    Dim strCodProdInterno As String = dt.Rows.Item(I).Item("CodProdInterno").ToString
    '    '    Dim strICMS As String = dt.Rows.Item(I).Item("ICMS").ToString
    '    '    Dim strDesconto As String = dt.Rows.Item(I).Item("Desconto").ToString
    '    '    Dim strIPI As String = dt.Rows.Item(I).Item("IPI").ToString

    '    '    Dim strUnitarioImposto As String = dt.Rows.Item(I).Item("UnitarioImposto").ToString
    '    '    Dim strQtdTotal As String = dt.Rows.Item(I).Item("QtdTotal").ToString
    '    '    Dim strUM As String = dt.Rows.Item(I).Item("UM").ToString


    '    '    Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString

    '    '    Inserir("INSERT INTO EntradaNF (CodTotNF, CodProd, Qtd, ValorUnitario, ValorTotal, Produto, CodProdInterno, ICMS, Desconto, IPI, UnitarioImposto, Tamanho, CodConfig, QtdTotal, UM) VALUES (" & strCodTotNF & "," & strCodProd & "," & Num(strQtd) & "," & Num(strValorUnitario) & "," & Num(strValorTotal) & ",'" & strProduto & "','" & strCodProdInterno & "','" & strICMS & "','" & strDesconto & "','" & strIPI & "'," & Num(strUnitarioImposto) & ",'" & strTamanho & "'," & strCodConfig & ",'" & strQtdTotal & "','" & strUM & "')")
    '    '    B += 1
    '    '    LogDeErro()
    '    'Next
    '    'Excluir("DELETE FROM EntradaNF where Produto = 'SQL SERVER'")

    '    strTabela = "EntradaNF"
    '    BarraProdgresso()
    '    '**********IMPOSTOPRODUTO**********
    '    'B = 1
    '    'dt = CarregarAccess("SELECT * FROM ImpostoProduto order by Codigo")
    '    'For I = 0 To dt.Rows.Count - 1
    '    '    Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '    '    If strCodigo <> B Then

    '    '        Dim int As Integer = strCodigo - B
    '    '        Dim J As Integer


    '    '        For J = 0 To int - 1
    '    '            Inserir("INSERT INTO ImpostoProduto (Cst) VALUES ('SQ')")
    '    '            B += 1
    '    '            LogDeErro()
    '    '        Next


    '    '    End If

    '    '    Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
    '    '    Dim strICMS As String = dt.Rows.Item(I).Item("ICMS").ToString
    '    '    Dim strIPI As String = dt.Rows.Item(I).Item("IPI").ToString
    '    '    Dim strTributacao As String = dt.Rows.Item(I).Item("Tributacao").ToString
    '    '    Dim strCst As String = dt.Rows.Item(I).Item("Cst").ToString
    '    '    Dim strOrigemICMS As String = dt.Rows.Item(I).Item("OrigemICMS").ToString
    '    '    Dim strIPPT As String = dt.Rows.Item(I).Item("IPPT").ToString

    '    '    Dim strPesavel As String = dt.Rows.Item(I).Item("Pesavel").ToString
    '    '    Dim strTipoFIA As String = dt.Rows.Item(I).Item("TipoFIA").ToString

    '    '    Inserir("Insert into ImpostoProduto (CodProd, ICMS, IPI, Tributacao, Cst, OrigemIcms, IPPT, Pesavel, TipoFIA) Values(" & strCodProd & "," & Num(strICMS) & "," & Num(strIPI) & ",'" & strTributacao & "','" & strCst & "','" & strOrigemICMS & "','" & strIPPT & "','" & strPesavel & "','" & strTipoFIA & "')")
    '    '    B += 1
    '    '    LogDeErro()
    '    'Next
    '    'Excluir("DELETE FROM ImpostoProduto where Cst = 'SQ'")

    '    strTabela = "ImpostoProduto"
    '    BarraProdgresso()
    '    '**********PAGAMENTO**********
    '    'B = 1
    '    'dt = CarregarAccess("SELECT * FROM Pagamento order by Codigo")
    '    'For I = 0 To dt.Rows.Count - 1
    '    '    Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '    '    If strCodigo <> B Then

    '    '        Dim int As Integer = strCodigo - B
    '    '        Dim J As Integer


    '    '        For J = 0 To int - 1
    '    '            Inserir("INSERT INTO Pagamento (Descricao) VALUES ('SQL SERVER')")
    '    '            B += 1
    '    '            LogDeErro()
    '    '        Next


    '    '    End If

    '    '    Dim strDescricao As String = dt.Rows.Item(I).Item("Descricao").ToString
    '    '    Dim strDias As String = dt.Rows.Item(I).Item("Dias").ToString
    '    '    Dim strDesconto As String = dt.Rows.Item(I).Item("Desconto").ToString
    '    '    Dim bolPrazo As Boolean = dt.Rows.Item(I).Item("Prazo").ToString
    '    '    Dim strFormaPagamento As String = dt.Rows.Item(I).Item("FormaPagamento").ToString
    '    '    Dim strIrCaixa As String = dt.Rows.Item(I).Item("IrCaixa").ToString

    '    '    Inserir("INSERT INTO Pagamento(Descricao, Dias, Desconto, Prazo, FormaPagamento, IrCaixa) VALUES ('" & strDescricao & "','" & strDias & "','" & strDesconto & "','" & bolPrazo & "','" & strFormaPagamento & "','" & strIrCaixa & "')")
    '    '    B += 1
    '    '    LogDeErro()
    '    'Next
    '    'Excluir("DELETE FROM Pagamento where Descricao = 'SQL SERVER'")

    '    strTabela = "Pagamento"
    '    BarraProdgresso()

    '    '**********PEDIDO**********

    '    Excluir("Delete from Pedido where CodOrdem > 2039 and CodConfig  = " & Me.txtCodLoja.EditValue)
    '    B = 1
    '    dt = CarregarOutroBD("SELECT * FROM Pedido where CodOrdem > 2039 and CodConfig = " & Me.txtCodLoja.EditValue)
    '    For I = 0 To dt.Rows.Count - 1
    '        Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '        'If strCodigo <> B Then

    '        '    Dim int As Integer = strCodigo - B
    '        '    Dim J As Integer


    '        '    For J = 0 To int - 1
    '        '        Inserir("INSERT INTO Pedido (Produto) VALUES ('SQL SERVER')")
    '        '        B += 1
    '        '        LogDeErro()
    '        '    Next


    '        'End If
    '        Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
    '        Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
    '        Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
    '        Dim strProduto As String = dt.Rows.Item(I).Item("Produto").ToString
    '        Dim strValorUnitario As String = dt.Rows.Item(I).Item("ValorUnitario").ToString

    '        Dim strValorTotal As String = dt.Rows.Item(I).Item("ValorTotal").ToString

    '        Dim strCodProdInterno As String = dt.Rows.Item(I).Item("CodProdInterno").ToString
    '        Dim strCodFunc As String = dt.Rows.Item(I).Item("CodFunc").ToString
    '        Dim strCusto As String = dt.Rows.Item(I).Item("Custo").ToString
    '        Dim strTamanho As String = dt.Rows.Item(I).Item("Tamanho").ToString
    '        Dim strUM As String = dt.Rows.Item(I).Item("UM").ToString

    '        Dim bolDevolvido As Boolean = dt.Rows.Item(I).Item("Devolvido").ToString
    '        Dim strLote As String = dt.Rows.Item(I).Item("Lote").ToString
    '        Dim strTipoItens As String = dt.Rows.Item(I).Item("TipoItens").ToString


    '        Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


    '        Inserir("Insert into Pedido (CodOrdem, Qtd, CodProd, Produto, ValorUnitario, ValorTotal, CodProdInterno, CodFunc, Custo, Um, Tamanho, Lote, TipoItens, CodConfig, Devolvido) Values(" & strCodOrdem & "," & Num(strQtd) & "," & strCodProd & ",'" & strProduto & "'," & Num(strValorUnitario) & "," & Num(strValorTotal) & ",'" & strCodProdInterno & "'," & strCodFunc & "," & Num(strCusto) & ",'" & strUM & "','" & strTamanho & "','" & strLote & "','" & strTipoItens & "'," & strCodConfig & ",'" & bolDevolvido & "')")
    '        B += 1
    '        LogDeErro()
    '    Next
    '    'Excluir("DELETE FROM Pedido where Produto = 'SQL SERVER'")
    '    strTabela = "Pedido"
    '    BarraProdgresso()
    '    '**********TOTAL**********

    '    Excluir("Delete from Total where CodOrdem > 2039 and CodConfig  = " & Me.txtCodLoja.EditValue)

    '    B = 1
    '    dt = CarregarOutroBD("SELECT * FROM Total where CodOrdem > 2039 and CodConfig = " & Me.txtCodLoja.EditValue)

    '    For I = 0 To dt.Rows.Count - 1
    '        Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '        'If strCodigo <> B Then

    '        '    Dim int As Integer = strCodigo - B
    '        '    Dim J As Integer


    '        '    For J = 0 To int - 1
    '        '        Inserir("INSERT INTO Total (Total) VALUES (150000.000)")
    '        '        B += 1
    '        '        LogDeErro()
    '        '    Next


    '        'End If

    '        Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
    '        Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
    '        Dim strCodCli As String = dt.Rows.Item(I).Item("CodCli").ToString
    '        Dim strTotal As String = dt.Rows.Item(I).Item("Total").ToString
    '        Dim strRecebido As String = dt.Rows.Item(I).Item("Recebido").ToString



    '        Dim strTroco As String = dt.Rows.Item(I).Item("Troco").ToString
    '        Dim strCusto As String = dt.Rows.Item(I).Item("Custo").ToString


    '        Dim strPorDesc As String = dt.Rows.Item(I).Item("PorDesc").ToString
    '        Dim strValDesc As String = dt.Rows.Item(I).Item("ValDesc").ToString
    '        Dim strPorAcre As String = dt.Rows.Item(I).Item("PorAcre").ToString
    '        Dim strValAcre As String = dt.Rows.Item(I).Item("ValAcre").ToString

    '        Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


    '        Inserir("Insert Into Total (CodOrdem, Data, CodCli, Total, Recebido, Troco, Custo, PorDesc, ValDesc, PorAcre, ValAcre, CodConfig) Values(" & strCodOrdem & ",'" & strData & "'," & strCodCli & "," & Num(strTotal) & "," & Num(strRecebido) & "," & Num(strTroco) & "," & Num(strCusto) & "," & Num(strPorDesc) & "," & Num(strValDesc) & "," & Num(strPorAcre) & "," & Num(strValAcre) & "," & strCodConfig & ")")
    '        B += 1
    '        LogDeErro()
    '    Next
    '    'Excluir("DELETE FROM Total where Total = 150000.000")

    '    strTabela = "Total"
    '    BarraProdgresso()
    '    '**********USUARIO**********
    '    B = 1
    '    'dt = CarregarAccess("SELECT * FROM Usuario order by Codigo")
    '    'For I = 0 To dt.Rows.Count - 1

    '    '    Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString
    '    '    Dim strSenha As String = dt.Rows.Item(I).Item("Senha").ToString
    '    '    If strSenha <> "SPFC" Then
    '    '        If strCodigo <> B Then

    '    '            Dim int As Integer = strCodigo - B
    '    '            Dim J As Integer


    '    '            For J = 0 To int - 1
    '    '                Inserir("INSERT INTO Usuario (Nome) VALUES ('SQL SERVER')")
    '    '                B += 1
    '    '                LogDeErro()
    '    '            Next


    '    '        End If

    '    '        Dim strLogin As String = dt.Rows.Item(I).Item("Login").ToString
    '    '        Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
    '    '        Dim strNivel As String = dt.Rows.Item(I).Item("Nivel").ToString

    '    '        Dim strPrincipal As String = dt.Rows.Item(I).Item("Principal").ToString

    '    '        Dim strConsultas As String = dt.Rows.Item(I).Item("Consultas").ToString

    '    '        Dim strRelatorios As String = dt.Rows.Item(I).Item("Relatorios").ToString
    '    '        Dim strSkin As String = dt.Rows.Item(I).Item("Skin").ToString
    '    '        Dim bolFundoPadrao As Boolean = dt.Rows.Item(I).Item("FundoPadrao").ToString
    '    '        Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
    '    '        Dim strExibicao As String = dt.Rows.Item(I).Item("Exibicao").ToString
    '    '        With Me.DsNanoCommerce.Usuario

    '    '            .Rows.Add()
    '    '            .Rows.Item(.Rows.Count - 1).Item("Nome") = strNome
    '    '            .Rows.Item(.Rows.Count - 1).Item("Login") = strLogin
    '    '            .Rows.Item(.Rows.Count - 1).Item("Nivel") = strNivel
    '    '            .Rows.Item(.Rows.Count - 1).Item("Senha") = strSenha
    '    '            .Rows.Item(.Rows.Count - 1).Item("FundoPadrao") = bolFundoPadrao
    '    '            .Rows.Item(.Rows.Count - 1).Item("CodConfig") = strCodConfig
    '    '            .Rows.Item(.Rows.Count - 1).Item("PlanoFundo") = dt.Rows.Item(I).Item("PlanoFundo")
    '    '            .Rows.Item(.Rows.Count - 1).Item("Exibicao") = strExibicao

    '    '            .Rows.Item(.Rows.Count - 1).Item("Principal") = strPrincipal
    '    '            .Rows.Item(.Rows.Count - 1).Item("Consultas") = strConsultas
    '    '            .Rows.Item(.Rows.Count - 1).Item("Relatorios") = strRelatorios
    '    '            .Rows.Item(.Rows.Count - 1).Item("Skin") = strSkin

    '    '        End With
    '    '        Me.Validate()
    '    '        Me.UsuarioBindingSource.EndEdit()
    '    '        Me.UsuarioTableAdapter.Update(Me.DsNanoCommerce.Usuario)
    '    '        LogDeErro()
    '    '    End If

    '    '    B += 1


    '    'Next
    '    'Excluir("DELETE FROM Usuario where Nome = 'SQL SERVER'")


    '    strTabela = "Usuario"
    '    BarraProdgresso()
    '    '**********MOVIMENTO BANCARIO**********
    '    'B = 1
    '    'dt = CarregarAccess("SELECT * FROM MovimentoBancario order by Codigo")
    '    'For I = 0 To dt.Rows.Count - 1
    '    '    Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '    '    If strCodigo <> B Then

    '    '        Dim int As Integer = strCodigo - B
    '    '        Dim J As Integer


    '    '        For J = 0 To int - 1
    '    '            Inserir("INSERT INTO MovimentoBancario (TipoMovimento) VALUES ('SQL SERVER')")
    '    '            B += 1
    '    '            LogDeErro()
    '    '        Next


    '    '    End If

    '    '    Dim strCodBanco As String = dt.Rows.Item(I).Item("CodBanco").ToString
    '    '    Dim strTipoMovimento As String = dt.Rows.Item(I).Item("TipoMovimento").ToString
    '    '    Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
    '    '    Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
    '    '    Dim strObservacao As String = dt.Rows.Item(I).Item("Observacao").ToString

    '    '    Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


    '    '    Inserir("INSERT INTO MovimentoBancario (CodBanco, TipoMovimento, Valor, Data, Observacao, CodConfig)VALUES(" & strCodBanco & ",'" & strTipoMovimento & "'," & Num(strValor) & ",'" & strData & "','" & strObservacao & "'," & strCodConfig & ")")
    '    '    B += 1
    '    '    LogDeErro()
    '    'Next
    '    'Excluir("DELETE FROM MovimentoBancario where TipoMovimento = 'SQL SERVER'")

    '    strTabela = "MovimentoBancario"
    '    BarraProdgresso()
    '    '**********QTDE**********
    '    B = 1
    '    dt = CarregarOutroBD("SELECT * FROM Qtde where Acabou ='False' and CodConfig =" & Me.txtCodLoja.EditValue)
    '    For I = 0 To dt.Rows.Count - 1
    '        Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '        'If strCodigo <> B Then

    '        '    Dim int As Integer = strCodigo - B
    '        '    Dim J As Integer


    '        '    For J = 0 To int - 1
    '        '        Inserir("INSERT INTO Qtde (Tamanho) VALUES ('SQL')")
    '        '        B += 1
    '        '        LogDeErro()
    '        '    Next


    '        'End If

    '        Excluir("Delete from Qtde where Codigo =" & strCodigo)


    '        Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
    '        Dim strTamanho As String = dt.Rows.Item(I).Item("Tamanho").ToString
    '        Dim strQtdMinima As String = dt.Rows.Item(I).Item("QtdMinima").ToString
    '        Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
    '        Dim strLote As String = dt.Rows.Item(I).Item("Lote").ToString
    '        Dim strValorCusto As String = dt.Rows.Item(I).Item("ValorCusto").ToString
    '        Dim strEmFalta As String = dt.Rows.Item(I).Item("EmFalta").ToString

    '        Dim bolAcabou As Boolean = dt.Rows.Item(I).Item("Acabou").ToString

    '        Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


    '        Inserir("INSERT INTO Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, ValorCusto, EmFalta, CodConfig, Acabou) VALUES (" & strCodProd & ",'" & strTamanho & "'," & Num(strQtdMinima) & "," & Num(strQtd) & ",'" & strLote & "'," & Num(strValorCusto) & ",'" & strEmFalta & "'," & strCodConfig & ",'" & bolAcabou & "')")
    '        B += 1
    '        LogDeErro()
    '    Next
    '    'Excluir("DELETE FROM Qtde where Tamanho = 'SQL'")

    '    strTabela = "Qtde"
    '    BarraProdgresso()
    '    '**********DEVOLUCAO**********

    '    Excluir("Delete FROM Devolucao where Data > '" & dtData & "' and CodConfig =" & Me.txtCodLoja.EditValue)


    '    B = 1
    '    dt = CarregarOutroBD("SELECT * FROM Devolucao where Data > '" & Me.dtData.EditValue & "' and CodConfig =" & Me.txtCodLoja.EditValue)
    '    For I = 0 To dt.Rows.Count - 1
    '        Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '        'If strCodigo <> B Then

    '        '    Dim int As Integer = strCodigo - B
    '        '    Dim J As Integer


    '        '    For J = 0 To int - 1
    '        '        Inserir("INSERT INTO Devolucao (Motivo) VALUES ('SQL')")
    '        '        B += 1
    '        '        LogDeErro()
    '        '    Next


    '        'End If

    '        Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
    '        Dim strQtde As String = dt.Rows.Item(I).Item("Qtde").ToString
    '        Dim strCodCli As String = dt.Rows.Item(I).Item("CodCli").ToString

    '        Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
    '        Dim strCodFunc As String = dt.Rows.Item(I).Item("CodFunc").ToString
    '        Dim strMotivo As String = dt.Rows.Item(I).Item("Motivo").ToString

    '        Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString

    '        Dim strTamanho As String = dt.Rows.Item(I).Item("Tamanho").ToString
    '        Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


    '        Inserir("INSERT INTO Devolucao (CodProd, Qtde, CodCli, Data, CodFunc, Motivo, Tamanho, Valor, CodConfig) VALUES (" & strCodProd & "," & Num(strQtde) & ",'" & strCodCli & "','" & strData & "','" & strCodFunc & "','" & strMotivo & "','" & strTamanho & "'," & Num(strValor) & "," & strCodConfig & ")")
    '        B += 1
    '        LogDeErro()
    '    Next
    '    'Excluir("DELETE FROM Devolucao where Motivo = 'SQL'")
    '    strTabela = "Devolucao"
    '    BarraProdgresso()
    '    '**********LOG**********
    '    B = 1
    '    'dt = CarregarAccess("SELECT * FROM Log order by Codigo")
    '    'For I = 0 To dt.Rows.Count - 1
    '    '    Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '    '    'If strCodigo <> B Then

    '    '    '    Dim int As Integer = strCodigo - B
    '    '    '    Dim J As Integer


    '    '    '    For J = 0 To int - 1
    '    '    '        Inserir("INSERT INTO Log (Antigo) VALUES ('SQL')")
    '    '    '        B += 1
    '    '    '        LogDeErro()
    '    '    '    Next


    '    '    'End If
    '    '    Dim strCodUser As String = dt.Rows.Item(I).Item("CodUser").ToString
    '    '    Dim strAntigo As String = dt.Rows.Item(I).Item("Antigo").ToString
    '    '    Dim strNovo As String = dt.Rows.Item(I).Item("Novo").ToString

    '    '    Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
    '    '    Dim strColuna As String = dt.Rows.Item(I).Item("Coluna").ToString
    '    '    Dim strTabela As String = dt.Rows.Item(I).Item("Tabela").ToString

    '    '    Dim strMotivo As String = dt.Rows.Item(I).Item("Motivo").ToString

    '    '    Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


    '    '    Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & strData & "'," & strCodUser & ",'" & strAntigo & "','" & strNovo & "','" & strColuna & "','" & strTabela & "','" & strMotivo & "'," & strCodConfig & ")")
    '    '    B += 1
    '    '    LogDeErro()
    '    'Next
    '    'Excluir("DELETE FROM Log where Antigo = 'SQL'")

    '    strTabela = "Log"
    '    BarraProdgresso()
    '    '**********REGISTRO**********
    '    B = 1
    '    'dt = CarregarAccess("SELECT * FROM Registro order by Codigo")
    '    'For I = 0 To dt.Rows.Count - 1
    '    '    Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '    '    If strCodigo <> B Then

    '    '        Dim int As Integer = strCodigo - B
    '    '        Dim J As Integer


    '    '        For J = 0 To int - 1
    '    '            Inserir("INSERT INTO Registro (Computador) VALUES ('SQL')")
    '    '            B += 1
    '    '            LogDeErro()
    '    '        Next


    '    '    End If
    '    '    Dim strComputador As String = dt.Rows.Item(I).Item("Computador").ToString

    '    '    Inserir("INSERT INTO Registro (Computador) VALUES ('" & strComputador & "')")
    '    '    B += 1
    '    '    LogDeErro()
    '    'Next
    '    'Excluir("DELETE FROM Registro where Computador = 'SQL'")


    '    strTabela = "Registro"
    '    BarraProdgresso()
    '    '**********DESCARTE**********
    '    B = 1
    '    'dt = CarregarAccess("SELECT * FROM Descarte order by Codigo")
    '    'For I = 0 To dt.Rows.Count - 1
    '    '    Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '    '    If strCodigo <> B Then

    '    '        Dim int As Integer = strCodigo - B
    '    '        Dim J As Integer


    '    '        For J = 0 To int - 1
    '    '            Inserir("INSERT INTO Descarte (Motivo) VALUES ('SQL')")
    '    '            B += 1
    '    '            LogDeErro()
    '    '        Next


    '    '    End If

    '    '    Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
    '    '    Dim strQtde As String = dt.Rows.Item(I).Item("Qtde").ToString
    '    '    Dim strValorUnitario As String = dt.Rows.Item(I).Item("ValorUnitario").ToString
    '    '    Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
    '    '    Dim strCodFunc As String = dt.Rows.Item(I).Item("CodFunc").ToString
    '    '    Dim strMotivo As String = dt.Rows.Item(I).Item("Motivo").ToString

    '    '    Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


    '    '    Inserir("INSERT INTO Descarte (CodProd, Qtde, ValorUnitario, Motivo, Data, CodFunc, CodConfig) VALUES (" & strCodProd & "," & Num(strQtde) & "," & Num(strValorUnitario) & ",'" & strMotivo & "','" & strData & "','" & strCodFunc & "'," & strCodConfig & ")")
    '    '    B += 1
    '    '    LogDeErro()
    '    'Next
    '    'Excluir("DELETE FROM Descarte where Motivo = 'SQL'")

    '    strTabela = "Descarte"
    '    BarraProdgresso()

    '    '**********ITENS RECEITA**********
    '    B = 1
    '    'dt = CarregarAccess("SELECT * FROM ItensReceita order by Codigo")
    '    'For I = 0 To dt.Rows.Count - 1
    '    '    Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '    '    If strCodigo <> B Then

    '    '        Dim int As Integer = strCodigo - B
    '    '        Dim J As Integer


    '    '        For J = 0 To int - 1
    '    '            Inserir("INSERT INTO ItensReceita (CodigoInterno) VALUES ('SQL')")
    '    '            B += 1
    '    '            LogDeErro()
    '    '        Next


    '    '    End If

    '    '    Dim strCodigoInterno As String = dt.Rows.Item(I).Item("CodigoInterno").ToString
    '    '    Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
    '    '    Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
    '    '    Dim strCodProdInterno As String = dt.Rows.Item(I).Item("CodProdInterno").ToString
    '    '    Dim strCusto As String = dt.Rows.Item(I).Item("Custo").ToString
    '    '    Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString


    '    '    Inserir("Insert into ItensReceita (CodigoInterno, CodProd, CodProdInterno, Custo, Qtd, Valor) Values('" & strCodigoInterno & "'," & strCodProd & ",'" & strCodProdInterno & "'," & Num(strCusto) & "," & Num(strQtd) & "," & Num(strValor) & ")")
    '    '    B += 1
    '    '    LogDeErro()
    '    'Next
    '    'Excluir("DELETE FROM ItensReceita where CodigoInterno = 'SQL'")
    '    strTabela = "ItensReceita"
    '    BarraProdgresso()

    '    ''**********RECEITA**********
    '    'B = 1
    '    'dt = CarregarAccess("SELECT * FROM Receita order by Codigo")
    '    'For I = 0 To dt.Rows.Count - 1
    '    '    Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '    '    If strCodigo <> B Then

    '    '        Dim int As Integer = strCodigo - B
    '    '        Dim J As Integer


    '    '        For J = 0 To int - 1
    '    '            Inserir("INSERT INTO Receita (CodigoInterno) VALUES ('SQL')")
    '    '            B += 1
    '    '            LogDeErro()
    '    '        Next


    '    '    End If

    '    '    Dim strCodigoInterno As String = dt.Rows.Item(I).Item("CodigoInterno").ToString
    '    '    Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
    '    '    Dim strValorVenda As String = dt.Rows.Item(I).Item("ValorVenda").ToString
    '    '    Dim strValorCusto As String = dt.Rows.Item(I).Item("ValorCusto").ToString
    '    '    Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString
    '    '    Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


    '    '    Inserir("Insert into Receita(CodigoInterno, Nome, ValorCusto, ValorVenda, Obs, CodConfig) Values('" & strCodigoInterno & "','" & strNome & "'," & Num(strValorCusto) & "," & Num(strValorVenda) & ",'" & strObs & "'," & strCodConfig & ")")
    '    '    B += 1
    '    '    LogDeErro()
    '    'Next
    '    'Excluir("DELETE FROM Receita where CodigoInterno = 'SQL'")
    '    strTabela = "Receita"
    '    BarraProdgresso()

    '    '**********ORDENS**********
    '    B = 1
    '    'dt = CarregarAccess("SELECT * FROM Ordens order by Codigo")
    '    'For I = 0 To dt.Rows.Count - 1
    '    '    Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '    '    If strCodigo <> B Then

    '    '        Dim int As Integer = strCodigo - B
    '    '        Dim J As Integer


    '    '        For J = 0 To int - 1
    '    '            Inserir("INSERT INTO Ordens (Tabela) VALUES ('SQL')")
    '    '            B += 1
    '    '            LogDeErro()
    '    '        Next


    '    '    End If

    '    '    Dim strCod As String = dt.Rows.Item(I).Item("Cod").ToString
    '    '    Dim strTabela As String = dt.Rows.Item(I).Item("Tabela").ToString
    '    '    Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


    '    '    Inserir("Insert into Ordens(Cod, Tabela, CodConfig) Values('" & strCod & "','" & strTabela & "'," & strCodConfig & ")")
    '    '    B += 1
    '    '    LogDeErro()
    '    'Next
    '    'Excluir("DELETE FROM Ordens where Tabela = 'SQL'")

    '    strTabela = "Ordens"
    '    BarraProdgresso()
    '    '**********TOTAL CONSIG**********
    '    B = 1
    '    'dt = CarregarAccess("SELECT * FROM TotalConsig order by Codigo")
    '    'For I = 0 To dt.Rows.Count - 1
    '    '    Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '    '    If strCodigo <> B Then

    '    '        Dim int As Integer = strCodigo - B
    '    '        Dim J As Integer


    '    '        For J = 0 To int - 1
    '    '            Inserir("INSERT INTO TotalConsig (Desconto) VALUES ('SQL')")
    '    '            B += 1
    '    '            LogDeErro()
    '    '        Next


    '    '    End If

    '    '    Dim strCodOrdens As String = dt.Rows.Item(I).Item("CodOrdens").ToString
    '    '    Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
    '    '    Dim strCodCli As String = dt.Rows.Item(I).Item("CodCli").ToString
    '    '    Dim strTotal As String = dt.Rows.Item(I).Item("Total").ToString
    '    '    Dim strDescricao As String = dt.Rows.Item(I).Item("Descricao").ToString

    '    '    Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
    '    '    Dim strCusto As String = dt.Rows.Item(I).Item("Custo").ToString
    '    '    Dim strDesconto As String = dt.Rows.Item(I).Item("Desconto").ToString



    '    '    Dim strEntrega As String = dt.Rows.Item(I).Item("Entrega").ToString
    '    '    Dim strCodFunc As String = dt.Rows.Item(I).Item("CodFunc").ToString
    '    '    Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


    '    '    Inserir("Insert into TotalConsig(Data, CodCli, CodFunc, Total, Descricao, Desconto, Status, Custo, Entrega, CodConfig, CodOrdens) Values('" & strData & "'," & strCodCli & "," & strCodFunc & "," & Num(strTotal) & ",'" & strDescricao & "','" & strDesconto & "','" & strStatus & "'," & Num(strCusto) & ",'" & strEntrega & "'," & strCodConfig & "," & strCodOrdens & ")")
    '    '    B += 1
    '    '    LogDeErro()
    '    'Next
    '    'Excluir("DELETE FROM TotalConsig where Desconto = 'SQL'")

    '    strTabela = "TotalConsig"
    '    BarraProdgresso()
    '    '**********ITENS CONSIG**********
    '    B = 1
    '    'dt = CarregarAccess("SELECT * FROM ItensConsig order by Codigo")
    '    'For I = 0 To dt.Rows.Count - 1
    '    '    Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '    '    If strCodigo <> B Then

    '    '        Dim int As Integer = strCodigo - B
    '    '        Dim J As Integer


    '    '        For J = 0 To int - 1
    '    '            Inserir("INSERT INTO ItensConsig (Produto) VALUES ('SQL SERVER')")
    '    '            B += 1
    '    '            LogDeErro()
    '    '        Next


    '    '    End If

    '    '    Dim strCodOrdens As String = dt.Rows.Item(I).Item("CodOrdens").ToString
    '    '    Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
    '    '    Dim strCodigoProduto As String = dt.Rows.Item(I).Item("CodigoProduto").ToString
    '    '    Dim strProduto As String = dt.Rows.Item(I).Item("Produto").ToString
    '    '    Dim strValorUnitario As String = dt.Rows.Item(I).Item("ValorUnitario").ToString

    '    '    Dim strValorTotal As String = dt.Rows.Item(I).Item("ValorTotal").ToString

    '    '    Dim strCodigoInterno As String = dt.Rows.Item(I).Item("CodigoInterno").ToString

    '    '    Dim strCusto As String = dt.Rows.Item(I).Item("Custo").ToString
    '    '    Dim strTamanho As String = dt.Rows.Item(I).Item("Tamanho").ToString
    '    '    Dim strUM As String = dt.Rows.Item(I).Item("UM").ToString

    '    '    Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


    '    '    Inserir("Insert into ItensConsig (CodOrdens, Qtd, CodigoProduto, Produto, ValorUnitario, ValorTotal, CodigoInterno, Custo, UM, Tamanho, CodConfig) Values(" & strCodOrdens & "," & Num(strQtd) & ",'" & strCodigoProduto & "','" & strProduto & "'," & Num(strValorUnitario) & "," & Num(strValorTotal) & ",'" & strCodigoInterno & "'," & Num(strCusto) & ",'" & strUM & "','" & strTamanho & "'," & strCodConfig & ")")
    '    '    B += 1
    '    '    LogDeErro()
    '    'Next
    '    'Excluir("DELETE FROM ItensConsig where Produto = 'SQL SERVER'")
    '    strTabela = "ItensConsig"
    '    BarraProdgresso()
    '    '**********COMANDA**********
    '    B = 1
    '    'dt = CarregarAccess("SELECT * FROM Comanda order by Codigo")
    '    'For I = 0 To dt.Rows.Count - 1
    '    '    Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '    '    If strCodigo <> B Then

    '    '        Dim int As Integer = strCodigo - B
    '    '        Dim J As Integer


    '    '        For J = 0 To int - 1
    '    '            Inserir("INSERT INTO Comanda (CodComanda) VALUES ('SQL SERVER')")
    '    '            B += 1
    '    '            LogDeErro()
    '    '        Next


    '    '    End If

    '    '    Dim strCodOrdens As String = dt.Rows.Item(I).Item("CodOrdens").ToString
    '    '    Dim strCodComanda As String = dt.Rows.Item(I).Item("CodComanda").ToString
    '    '    Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
    '    '    Dim strCodProdInterno As String = dt.Rows.Item(I).Item("CodProdInterno").ToString
    '    '    Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
    '    '    Dim strValorUnitario As String = dt.Rows.Item(I).Item("ValorUnitario").ToString
    '    '    Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
    '    '    Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
    '    '    Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


    '    '    Inserir("INSERT INTO Comanda (CodOrdens, CodComanda, CodProd, CodProdInterno, Qtd, ValorUnitario, Data, Status, CodConfig) VALUES (" & strCodOrdens & ",'" & strCodComanda & "'," & strCodProd & ",'" & strCodProdInterno & "'," & Num(strQtd) & "," & Num(strValorUnitario) & ",'" & strData & "','" & strStatus & "'," & strCodConfig & ")")
    '    '    B += 1
    '    '    LogDeErro()
    '    'Next
    '    'Excluir("DELETE FROM Comanda where CodComanda = 'SQL SERVER'")

    '    strTabela = "Comanda"
    '    BarraProdgresso()



    '    '**********CONFIG**********
    '    'dt = CarregarAccess("SELECT * FROM Config order by Codigo")
    '    'For I = 0 To dt.Rows.Count - 1
    '    '    Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

    '    '    Dim strEmpresa As String = dt.Rows.Item(I).Item("Empresa").ToString
    '    '    If strEmpresa <> "" Then


    '    '        Dim strTelefone As String = dt.Rows.Item(I).Item("Telefone").ToString
    '    '        Dim strEndereco As String = dt.Rows.Item(I).Item("Endereco").ToString
    '    '        Dim strCNPJ As String = dt.Rows.Item(I).Item("CNPJ").ToString
    '    '        Dim strOrigemRelease As String = dt.Rows.Item(I).Item("OrigemRelease").ToString
    '    '        Dim strVersaoNano As String = dt.Rows.Item(I).Item("VersaoNano").ToString
    '    '        Dim strEmiteCupom As String = dt.Rows.Item(I).Item("EmiteCupom").ToString
    '    '        Dim strUsaTEF As String = dt.Rows.Item(I).Item("UsaTEF").ToString
    '    '        Dim strCaminhoDaPastaRemessa As String = dt.Rows.Item(I).Item("CaminhoDaPastaRemessa").ToString

    '    '        Dim strNumArqRM As String = dt.Rows.Item(I).Item("NumArqRM").ToString
    '    '        If strNumArqRM = "" Then
    '    '            strNumArqRM = "NULL"
    '    '        End If
    '    '        Dim strTemImpressora As String = dt.Rows.Item(I).Item("TemImpressora").ToString
    '    '        Dim strCidade As String = dt.Rows.Item(I).Item("Cidade").ToString
    '    '        Dim strModeloCarne As String = dt.Rows.Item(I).Item("ModeloCarne").ToString
    '    '        Dim strTipoNano As String = dt.Rows.Item(I).Item("TipoNano").ToString
    '    '        Dim strPastaSinc As String = dt.Rows.Item(I).Item("PastaSinc").ToString
    '    '        Dim strDescricao As String = dt.Rows.Item(I).Item("Descricao").ToString
    '    '        Dim strGerarComissao As String = dt.Rows.Item(I).Item("GerarComissao").ToString
    '    '        Dim strValidarCPF As String = dt.Rows.Item(I).Item("ValidarCPF").ToString

    '    '        Dim strTemGuilhotina As String = dt.Rows.Item(I).Item("TemGuilhotina").ToString
    '    '        Dim strNomePCImpressora As String = dt.Rows.Item(I).Item("NomePCImpressora").ToString
    '    '        Dim strTolerancia As String = dt.Rows.Item(I).Item("Tolerancia").ToString
    '    '        Dim strJuros As String = dt.Rows.Item(I).Item("Juros").ToString
    '    '        Dim strEstoqueZerado As String = dt.Rows.Item(I).Item("EstoqueZerado").ToString
    '    '        Dim strAlterarParcelas As String = dt.Rows.Item(I).Item("AlterarParcelas").ToString
    '    '        Dim strImpressora As String = dt.Rows.Item(I).Item("Impressora").ToString
    '    '        Dim strPorta As String = dt.Rows.Item(I).Item("Porta").ToString
    '    '        Dim strJurosParcela As String = dt.Rows.Item(I).Item("JurosParcela").ToString

    '    '        Dim strTipoDesc As String = dt.Rows.Item(I).Item("TipoDesc").ToString
    '    '        Dim strImpCodBarra As String = dt.Rows.Item(I).Item("ImpCodBarra").ToString
    '    '        Dim strValidarCep As String = "True"
    '    '        If I = 0 Then
    '    '            Atualizar("UPDATE Config SET Empresa = '" & strEmpresa & "', Telefone = '" & strTelefone & "', Endereco = '" & strEndereco & "', CNPJ = '" & strCNPJ & "', OrigemRelease = '" & strOrigemRelease & "', VersaoNano = '" & strVersaoNano & "', EmiteCupom = '" & strEmiteCupom & "', UsaTEF = '" & strUsaTEF & "', CaminhoDaPastaRemessa = '" & strCaminhoDaPastaRemessa & "', NumArqRM = " & strNumArqRM & ", TemImpressora = '" & strTemImpressora & "', Cidade = '" & strCidade & "', ModeloCarne = '" & strModeloCarne & "', TipoNano = '" & strTipoNano & "', PastaSinc = '" & strPastaSinc & "', Descricao = '" & strDescricao & "', GerarComissao = '" & strGerarComissao & "', ValidarCPF = '" & strValidarCPF & "', TemGuilhotina = '" & strTemGuilhotina & "', " & _
    '    '                       "NomePCImpressora = '" & strNomePCImpressora & "', Tolerancia = " & Num(strTolerancia) & ", Juros = " & Num(strJuros) & ", EstoqueZerado = '" & strEstoqueZerado & "', AlterarParcelas = '" & strAlterarParcelas & "', Impressora = '" & strImpressora & "', Porta = '" & strPorta & "', JurosParcela = " & Num(strJurosParcela) & ", TipoDesc = '" & strTipoDesc & "', ImpCodBarra = '" & strImpCodBarra & "', ValidarCep = '" & strValidarCep & "' where Codigo = " & strCodigo)
    '    '        Else

    '    '            Atualizar("INSERT INTO Config (Empresa, Telefone, Endereco, CNPJ, OrigemRelease, VersaoNano, EmiteCupom, UsaTEF, CaminhoDaPastaRemessa, NumArqRM, TemImpressora, Cidade, ModeloCarne, TipoNano, PastaSinc, Descricao, GerarComissao, ValidarCPF, TemGuilhotina, NomePCImpressora, Tolerancia, Juros, EstoqueZerado, AlterarParcelas, Impressora, Porta, JurosParcela, TipoDesc, ImpCodBarra, ValidarCep) VALUES ('" & strEmpresa & "','" & strTelefone & "','" & strEndereco & "','" & strCNPJ & "','" & strOrigemRelease & "','" & strVersaoNano & "','" & strEmiteCupom & "','" & strUsaTEF & "','" & strCaminhoDaPastaRemessa & "'," & strNumArqRM & ",'" & strTemImpressora & "','" & strCidade & "','" & strModeloCarne & "','" & strTipoNano & "','" & strPastaSinc & "','" & strDescricao & "','" & strGerarComissao & "','" & strValidarCPF & "','" & strTemGuilhotina & "'," & _
    '    '                                       "'" & strNomePCImpressora & "'," & Num(strTolerancia) & "," & Num(strJuros) & ",'" & strEstoqueZerado & "','" & strAlterarParcelas & "','" & strImpressora & "','" & strPorta & "'," & Num(strJurosParcela) & ",'" & strTipoDesc & "','" & strImpCodBarra & "','" & strValidarCep & "')")

    '    '        End If

    '    '        LogDeErro()
    '    '    End If
    '    'Next

    '    strTabela = "Config"
    '    BarraProdgresso()



    '    Me.Cursor = Cursors.Default
    '    Me.rtbMens.AppendText(vbCrLf & "Tabelas migradas com sucesso!")
    '    Me.btnOk.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    'End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Dim dt As DataTable = Nothing
        Dim I, B As Integer
        B = 1

        Dim strNomeBanco As String = Me.txtNomeBanco.EditValue

        
        '**********CLIENTE**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Cliente order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString
            Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString

            If strCodigo <> "1" Then
                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO Cliente (Nome) VALUES ('SQL SERVER')")
                        B += 1
                        LogDeErro()
                    Next


                End If

                Dim strRG As String = dt.Rows.Item(I).Item("RG").ToString
                Dim strCPF As String = dt.Rows.Item(I).Item("CPF").ToString
                Dim strEnd As String = dt.Rows.Item(I).Item("Endereco").ToString
                Dim strNum As String = dt.Rows.Item(I).Item("Numero").ToString
                Dim strComp As String = dt.Rows.Item(I).Item("Complemento").ToString
                Dim strBairro As String = dt.Rows.Item(I).Item("Bairro").ToString
                Dim strCep As String = dt.Rows.Item(I).Item("Cep").ToString
                Dim strCidade As String = dt.Rows.Item(I).Item("Cidade").ToString
                Dim strUF As String = dt.Rows.Item(I).Item("Estado").ToString
                Dim strTel As String = dt.Rows.Item(I).Item("Telefone").ToString
                Dim strFax As String = dt.Rows.Item(I).Item("Fax").ToString
                Dim strCel As String = dt.Rows.Item(I).Item("Celular").ToString
                Dim strEmail As String = dt.Rows.Item(I).Item("Email").ToString
                Dim strData As String = dt.Rows.Item(I).Item("Data").ToString

              
                Dim strFant As String = dt.Rows.Item(I).Item("Fantasia").ToString
                Dim bolIna As Boolean = dt.Rows.Item(I).Item("Inadimplente").ToString
                Dim strObs As String = dt.Rows.Item(I).Item("Observacao").ToString
                Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
                Dim strNasc As String
                If dt.Rows.Item(I).Item("Nascimento").ToString.Contains("/0974") Then
                    strNasc = dt.Rows.Item(I).Item("Nascimento").ToString.Replace("0974", "1974")
                Else

                    strNasc = dt.Rows.Item(I).Item("Nascimento").ToString
                End If

                Dim strSexo As String = dt.Rows.Item(I).Item("Sexo").ToString
                Dim strLimite As String = dt.Rows.Item(I).Item("Limite").ToString
                Dim strEmpresa As String = ""
                Dim strSalario As String = ""
                Dim strTelEmp As String = ""
                Dim strCredito As String = "0"
                Dim strMarca As String = ""
                Dim strCodConfig As String = "1"
                Dim strP1 As String = ""
                Dim strP2 As String = ""
                Dim strRG1 As String = ""
                Dim strRG2 As String = ""
                Dim bolInativo As Boolean = False
                Dim strCodMunicipio As String = dt.Rows.Item(I).Item("CodMunicipio").ToString
                Dim strCodPais As String = dt.Rows.Item(I).Item("CodPais").ToString
                Dim strNomePais As String = dt.Rows.Item(I).Item("NomePais").ToString

                Inserir("INSERT INTO Cliente (Nome, RGIE, CPF, Endereco, Telefone, Fax, Celular, Email, " & _
                "Data, Numero, Complemento, Bairro, Cep, Cidade, Estado, Fantasia, Inadimplente, Observacao, " & _
                "Status, Nascimento, Sexo, Limite, Empresa, TelEmpresa, Salario, Credito, Marcas, CodConfig, " & _
                "Pessoa1, Pessoa2, RG1, RG2, Inativo, CodMunicipio, CodPais, NomePais) VALUES (" & _
                "'" & strNome.Replace("'", "´") & "','" & strRG & "','" & strCPF & "'," & _
                "'" & strEnd.Replace("'", "´") & "','" & strTel & "','" & strFax & "','" & strCel & "'," & _
                "'" & strEmail & "','" & strData & "','" & strNum & "','" & strComp & "'," & _
                "'" & strBairro.Replace("'", "´") & "','" & strCep & "','" & strCidade.Replace("'", "´") & "'," & _
                "'" & strUF & "','" & strFant & "','" & bolIna & "','" & strObs.Replace("'", "´") & "'," & _
                "'" & strStatus & "','" & strNasc & "','" & strSexo & "','" & strLimite & "','" & strEmpresa & "'," & _
                "'" & strTelEmp & "','" & strSalario & "','" & strCredito & "','" & strMarca & "'," & strCodConfig & "," & _
                "'" & strP1 & "','" & strP2 & "','" & strRG1 & "','" & strRG2 & "','" & bolInativo & "','" & strCodMunicipio & "'," & _
                "'" & strCodPais & "','" & strNomePais & "')")
                LogDeErro()

            End If
            B += 1
        Next
        Excluir("DELETE FROM Cliente where Nome = 'SQL SERVER'")
        strTabela = "Cliente"
        BarraProdgresso()

       
        '**********FORNECEDOR**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Fornecedor order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            If strCodigo <> B Then

                Dim int As Integer = strCodigo - B
                Dim J As Integer


                For J = 0 To int - 1
                    Inserir("INSERT INTO Fornecedor (Nome) VALUES ('SQL SERVER')")
                    B += 1
                    LogDeErro()
                Next


            End If
            Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString.Replace("'", "´")
            Dim strCPF As String = dt.Rows.Item(I).Item("CPF").ToString
            Dim strEnd As String = dt.Rows.Item(I).Item("Endereco").ToString
            Dim strNum As String = dt.Rows.Item(I).Item("Numero").ToString
            Dim strComp As String = dt.Rows.Item(I).Item("Complemento").ToString
            Dim strBairro As String = dt.Rows.Item(I).Item("Bairro").ToString
            Dim strCep As String = dt.Rows.Item(I).Item("Cep").ToString
            Dim strCidade As String = dt.Rows.Item(I).Item("Cidade").ToString
            Dim strUF As String = dt.Rows.Item(I).Item("Estado").ToString
            Dim strTelefone As String = dt.Rows.Item(I).Item("Telefone").ToString
            Dim strFax As String = dt.Rows.Item(I).Item("Fax").ToString
            Dim strCelular As String = dt.Rows.Item(I).Item("Celular").ToString
            Dim strEmail As String = dt.Rows.Item(I).Item("Email").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString

            Dim strIE As String = dt.Rows.Item(I).Item("IE").ToString
            Dim strContato As String = dt.Rows.Item(I).Item("Contato").ToString

            Dim strSite As String = dt.Rows.Item(I).Item("Site").ToString
            Dim strFantasia As String = dt.Rows.Item(I).Item("Fantasia").ToString
            Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
            Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString

            Dim strCodConfig As String = "1"
            Dim strTipo As String = dt.Rows.Item(I).Item("Tipo").ToString
            Dim strCodMunicipio As String = dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strCodPais As String = dt.Rows.Item(I).Item("CodPais").ToString
            Dim strNomePais As String = dt.Rows.Item(I).Item("NomePais").ToString
            Inserir("INSERT INTO Fornecedor (Nome, CPF, Endereco, Numero, Complemento, Bairro, Cep, Cidade, " & _
            "Estado, Telefone, Fax, Celular, Email, Data, IE, Contato, Site, Fantasia, Status, Obs, CodConfig, " & _
            "Tipo, CodMunicipio, CodPais, NomePais, Inativo) VALUES ('" & strNome & "','" & strCPF & "','" & strEnd & "'," & _
            "'" & strNum & "','" & strComp & "','" & strBairro & "','" & strCep & "','" & strCidade & "'," & _
            "'" & strUF & "','" & strTelefone & "','" & strFax & "','" & strCelular & "','" & strEmail & "'," & _
            "'" & strData & "','" & strIE & "','" & strContato & "','" & strSite & "','" & strFantasia & "'," & _
            "'" & strStatus & "','" & strObs & "'," & strCodConfig & ",'" & strTipo & "','" & strCodMunicipio & "'," & _
            "'" & strCodPais & "','" & strNomePais & "','False')")
            B += 1
            LogDeErro()
        Next
        Excluir("DELETE FROM Fornecedor where Nome = 'SQL SERVER'")
        strTabela = "Fornecedor"
        BarraProdgresso()

      
        '**********GRUPO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Grupo order by Codigo", strNomeBanco)

        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            If strCodigo <> B Then

                Dim int As Integer = strCodigo - B
                Dim J As Integer


                For J = 0 To int - 1
                    Dim strN As String = J + strCodigo
                    Inserir("INSERT INTO Grupo (Nome, Tipo) VALUES ('" & strN & "','Q')")
                    B += 1
                    LogDeErro()
                Next


            End If
            Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
            Dim strTipo As String = "G"


            Inserir("Insert into Grupo (Nome, Tipo) values('" & strNome & "','" & strTipo & "')")
            B += 1
            LogDeErro()
        Next
        Excluir("DELETE FROM Grupo where Tipo = 'Q'")

        strTabela = "Grupo"
        BarraProdgresso()
        '**********PRODUTO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Produto order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            If strCodigo <> B Then

                Dim int As Integer = strCodigo - B
                Dim J As Integer


                For J = 0 To int - 1
                    Inserir("INSERT INTO Produto (Nome) VALUES ('SQL SERVER')")
                    B += 1
                    LogDeErro()
                Next


            End If

            Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
            Dim strUnidadeMedida As String = dt.Rows.Item(I).Item("UnidadeMedida").ToString
            Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
            Dim strValorCusto As String = dt.Rows.Item(I).Item("ValorCusto").ToString
            Dim strLocacao As String = ""
            Dim strCodigoInterno As String = dt.Rows.Item(I).Item("CodigoPeca").ToString

            Dim vetPor As Array = Split(dt.Rows.Item(I).Item("Porcentagens").ToString, "|")
            If vetPor(0).ToString.ToUpper.Contains("NÃO") Then
                vetPor(0) = 0
            End If
            Dim strPorcentagens As String = vetPor(0)
            Dim strFabricante As String = ""
            Dim strGrupo As String = dt.Rows.Item(I).Item("Grupo").ToString
            Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString

            Dim strCodigoBarra As String = dt.Rows.Item(I).Item("CodigoBarra").ToString
            Dim strNivelComboCodCF As String = dt.Rows.Item(I).Item("NivelComboCodCF").ToString
            Dim strDesconto As String = ""


            Dim strSetor As String = ""
            Dim strTipo As String = ""

            Inserir("INSERT INTO Produto (Nome, UnidadeMedida, Valor, ValorCusto, Locacao,  CodigoInterno, Porcentagens, Fabricante, Grupo, Obs, Data, CodigoBarra, NivelComboCodCF, Desconto, Setor, Tipo, Inativo) VALUES ('" & strNome.Replace("'", "´") & "','" & strUnidadeMedida & "'," & Num(strValor) & "," & Num(strValorCusto) & ",'" & strLocacao & "','" & strCodigoInterno & "','" & strPorcentagens & "','" & strFabricante.Replace("'", "´") & "','" & strGrupo & "','" & strObs.Replace("'", "´") & "','" & strData & "','" & strCodigoBarra & "','" & strNivelComboCodCF & "'," & Num(strDesconto) & ",'" & strSetor & "','" & strTipo & "','False')")



            B += 1
            LogDeErro()
        Next
        Excluir("DELETE FROM Produto where Nome = 'SQL SERVER'")


        strTabela = "Produto"
        BarraProdgresso()
        
        '**********IMPOSTOPRODUTO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM ImpostoProduto order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            If strCodigo <> B Then

                Dim int As Integer = strCodigo - B
                Dim J As Integer


                For J = 0 To int - 1
                    Inserir("INSERT INTO ImpostoProduto (Cst) VALUES ('SQ')")
                    B += 1
                    LogDeErro()
                Next


            End If

            Dim strCodProd As String = dt.Rows.Item(I).Item("CodProduto").ToString
            Dim strICMS As String = dt.Rows.Item(I).Item("ICMS").ToString
            Dim strIPI As String = dt.Rows.Item(I).Item("IPI").ToString
            Dim strTributacao As String = dt.Rows.Item(I).Item("Tributacao").ToString
            Dim strCst As String = dt.Rows.Item(I).Item("Cst").ToString
            Dim strOrigemICMS As String = dt.Rows.Item(I).Item("OrigemICMS").ToString
            Dim strIPPT As String = dt.Rows.Item(I).Item("IPPT").ToString

            Dim strPesavel As String = dt.Rows.Item(I).Item("Pesavel").ToString
            Dim strTipoFIA As String = dt.Rows.Item(I).Item("TipoFIA").ToString

            Dim dt1 As DataTable = CarregarDataTable("SELECT Codigo FROM Produto where Codigo = " & strCodProd)
            If dt1.Rows.Count > 0 Then
                Inserir("Insert into ImpostoProduto (CodProd, ICMS, IPI, Tributacao, Cst, OrigemIcms, IPPT, Pesavel, TipoFIA) Values(" & strCodProd & "," & Num(strICMS) & "," & Num(strIPI) & ",'" & strTributacao & "','" & strCst & "','" & strOrigemICMS & "','" & strIPPT & "','" & strPesavel & "','" & strTipoFIA & "')")

            End If

        
            B += 1
            LogDeErro()
        Next
        Excluir("DELETE FROM ImpostoProduto where Cst = 'SQ'")

        strTabela = "ImpostoProduto"
        BarraProdgresso()



        '**********TRIBUTOS**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Tributos order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            If strCodigo <> B Then

                Dim int As Integer = strCodigo - B
                Dim J As Integer


                For J = 0 To int - 1
                    Inserir("INSERT INTO Tributos (CstIPI) VALUES ('SQ')")
                    B += 1
                    LogDeErro()
                Next


            End If

            Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
            Dim strCSTIPI As String = dt.Rows.Item(I).Item("CSTIPI").ToString
            Dim strPerIPI As String = dt.Rows.Item(I).Item("PerIPI").ToString
            Dim strCodEnq As String = dt.Rows.Item(I).Item("CodEnq").ToString
            Dim strCSTPIS As String = dt.Rows.Item(I).Item("CSTPIS").ToString
            Dim strPerPIS As String = dt.Rows.Item(I).Item("PerPIS").ToString
            Dim strCSTCOFINS As String = dt.Rows.Item(I).Item("CSTCOFINS").ToString

            Dim strPerCOFINS As String = dt.Rows.Item(I).Item("PerCOFINS").ToString
           
            Inserir("Insert into Tributos (CodProd, CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, " & _
            "PerCOFINS) Values(" & strCodProd & ",'" & strCSTIPI & "','" & strPerIPI & "','" & strCodEnq & "'," & _
            "'" & strCSTPIS & "','" & strPerPIS & "','" & strCSTCOFINS & "','" & strPerCOFINS & "')")
            B += 1
            LogDeErro()
        Next
        Excluir("DELETE FROM Tributos where CstIPI = 'SQ'")

        strTabela = "Tributos"
        BarraProdgresso()


        '**********NFE**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Nfe order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            If strCodigo <> B Then

                Dim int As Integer = strCodigo - B
                Dim J As Integer


                For J = 0 To int - 1
                    Inserir("INSERT INTO Nfe (Cst) VALUES ('SQ')")
                    B += 1
                    LogDeErro()
                Next


            End If

            Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
            Dim strCST As String = dt.Rows.Item(I).Item("CST").ToString
            Dim strOrigem As String = dt.Rows.Item(I).Item("Origem").ToString
            Dim strCFOP As String = dt.Rows.Item(I).Item("CFOP").ToString
            Dim strNCM As String = dt.Rows.Item(I).Item("NCM").ToString
            Dim strRegime As String = dt.Rows.Item(I).Item("Regime").ToString
            Dim strCalculoCred As String = dt.Rows.Item(I).Item("CalculoCred").ToString

            Inserir("Insert into Nfe (CodProd, CST, Origem, CFOP, NCM, Regime, CalculoCred) Values(" & strCodProd & "," & _
            "'" & strCST & "','" & strOrigem & "','" & strCFOP & "'," & _
            "'" & strNCM & "','" & strRegime & "','" & strCalculoCred & "')")
            B += 1
            LogDeErro()
        Next
        Excluir("DELETE FROM Nfe where Cst = 'SQ'")

        strTabela = "NFE"
        BarraProdgresso()


        '**********COFINGNFE**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM ConfigNfe order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            If strCodigo <> B Then

                Dim int As Integer = strCodigo - B
                Dim J As Integer


                For J = 0 To int - 1
                    Inserir("INSERT INTO ConfigNfe (Razao) VALUES ('SQ')")
                    B += 1
                    LogDeErro()
                Next


            End If

            Dim strRazao As String = dt.Rows.Item(I).Item("Razao").ToString
            Dim strFantasia As String = dt.Rows.Item(I).Item("Fantasia").ToString
            Dim strCNPJ As String = dt.Rows.Item(I).Item("CNPJ").ToString
            Dim strIE As String = dt.Rows.Item(I).Item("IE").ToString
            Dim strEndereco As String = dt.Rows.Item(I).Item("Endereco").ToString
            Dim strBairro As String = dt.Rows.Item(I).Item("Bairro").ToString
            Dim strNumero As String = dt.Rows.Item(I).Item("Numero").ToString

            Dim strCidade As String = dt.Rows.Item(I).Item("Cidade").ToString
            Dim strCodMun As String = dt.Rows.Item(I).Item("CodMun").ToString
            Dim strCep As String = dt.Rows.Item(I).Item("Cep").ToString
            Dim strUF As String = dt.Rows.Item(I).Item("UF").ToString
            Dim strCodUF As String = dt.Rows.Item(I).Item("CodUF").ToString
            Dim strPais As String = dt.Rows.Item(I).Item("Pais").ToString
            Dim strCodPais As String = dt.Rows.Item(I).Item("CodPais").ToString

            Dim strCRT As String = dt.Rows.Item(I).Item("CRT").ToString
            Dim strTelefone As String = dt.Rows.Item(I).Item("Telefone").ToString
            Dim strNatOp As String = dt.Rows.Item(I).Item("NatOp").ToString
            Dim strMod As String = dt.Rows.Item(I).Item("Mod").ToString
            Dim strSerie As String = dt.Rows.Item(I).Item("Serie").ToString
            Dim strTipoNF As String = dt.Rows.Item(I).Item("TipoNF").ToString
            Dim strTipoImp As String = dt.Rows.Item(I).Item("TipoImp").ToString

            Dim strTipoEmi As String = dt.Rows.Item(I).Item("TipoEmi").ToString
            Dim strTipoAmb As String = dt.Rows.Item(I).Item("TipoAmb").ToString
            Dim strFinNfe As String = dt.Rows.Item(I).Item("FinNfe").ToString
            Dim strProcEmi As String = dt.Rows.Item(I).Item("ProcEmi").ToString
            Dim strVerProc As String = dt.Rows.Item(I).Item("VerProc").ToString
            Dim strModFrete As String = dt.Rows.Item(I).Item("ModFrete").ToString
            Dim strObsCont As String = dt.Rows.Item(I).Item("ObsCont").ToString

            Dim strVersaoCce As String = dt.Rows.Item(I).Item("VersaoCce").ToString
            Dim strTZDCce As String = dt.Rows.Item(I).Item("TZDCce").ToString
            Dim strTipoEventoCce As String = dt.Rows.Item(I).Item("TipoEventoCce").ToString
            Dim strDescEventoCce As String = dt.Rows.Item(I).Item("DescEventoCce").ToString
            Dim strCondUsoCCe As String = dt.Rows.Item(I).Item("CondUsoCCe").ToString
            Dim strTipoAmbCce As String = dt.Rows.Item(I).Item("TipoAmbCce").ToString
            Dim strCodConfig As String = "1"

            Inserir("INSERT INTO ConfigNfe (Razao, Fantasia, CNPJ, IE, Endereco, Bairro, Numero, Cidade, CodMun, Cep, UF, CodUF, Pais, CodPais, CRT, " & _
            "Telefone, NatOp, Mod, Serie, TipoNF, TipoImp, TipoEmi, TipoAmb, FinNfe, ProcEmi, VerProc, ModFrete, ObsCont, VersaoCce, TZDCce, " & _
            "TipoEventoCce, DescEventoCce, CondUsoCCe, TipoAmbCce, CodConfig) VALUES ('" & strRazao & "','" & strFantasia & "','" & strCNPJ & "'," & _
            "'" & strIE & "','" & strEndereco & "','" & strBairro & "','" & strNumero & "','" & strCidade & "'," & _
            "'" & strCodMun & "','" & strCep & "','" & strUF & "','" & strCodUF & "','" & strPais & "'," & _
            "'" & strCodPais & "','" & strCRT & "','" & strTelefone & "','" & strNatOp & "','" & strMod & "'," & _
            "'" & strSerie & "','" & strTipoNF & "','" & strTipoImp & "','" & strTipoEmi & "','" & strTipoAmb & "','" & strFinNfe & "'," & _
            "'" & strProcEmi & "','" & strVerProc & "','" & strModFrete & "','" & strObsCont & "'," & _
            "'" & strVersaoCce & "','" & strTZDCce & "','" & strTipoEventoCce & "','" & strDescEventoCce & "'," & _
            "'" & strCondUsoCCe & "','" & strTipoAmbCce & "'," & CodConfig & ")")

            
            B += 1
            LogDeErro()
        Next
        Excluir("DELETE FROM ConfigNfe where Razao = 'SQ'")

        strTabela = "ConfigNFE"
        BarraProdgresso()

        '**********PAGAMENTO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Pagamento order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            If strCodigo <> B Then

                Dim int As Integer = strCodigo - B
                Dim J As Integer


                For J = 0 To int - 1
                    Inserir("INSERT INTO Pagamento (Descricao) VALUES ('SQL SERVER')")
                    B += 1
                    LogDeErro()
                Next


            End If

            Dim strDescricao As String = dt.Rows.Item(I).Item("Descricao").ToString
            Dim strDias As String = dt.Rows.Item(I).Item("Dias").ToString
            Dim strDesconto As String = dt.Rows.Item(I).Item("Desconto").ToString
            Dim bolPrazo As Boolean = dt.Rows.Item(I).Item("Prazo").ToString
            Dim strFormaPagamento As String = dt.Rows.Item(I).Item("FormaPagamento").ToString
            Dim strIrCaixa As String = dt.Rows.Item(I).Item("IrCaixa").ToString

            Inserir("INSERT INTO Pagamento(Descricao, Dias, Desconto, Prazo, FormaPagamento, IrCaixa) VALUES ('" & strDescricao & "','" & strDias & "','" & strDesconto & "','" & bolPrazo & "','" & strFormaPagamento & "','" & strIrCaixa & "')")
            B += 1
            LogDeErro()
        Next
        Excluir("DELETE FROM Pagamento where Descricao = 'SQL SERVER'")
        strTabela = "Pagamento"
        BarraProdgresso()

       
        '**********USUARIO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Usuario order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1

            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString
            Dim strSenha As String = dt.Rows.Item(I).Item("Senha").ToString
            If strSenha <> "SPFC" Then
                If strCodigo <> B Then

                    Dim int As Integer = strCodigo - B
                    Dim J As Integer


                    For J = 0 To int - 1
                        Inserir("INSERT INTO Usuario (Nome) VALUES ('SQL SERVER')")
                        B += 1
                        LogDeErro()
                    Next


                End If

                Dim strLogin As String = dt.Rows.Item(I).Item("Login").ToString
                Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
                Dim strNivel As String = dt.Rows.Item(I).Item("Nivel").ToString

                Dim strPrincipal As String = dt.Rows.Item(I).Item("Principal").ToString

                Dim strConsultas As String = dt.Rows.Item(I).Item("Consultas").ToString

                Dim strRelatorios As String = dt.Rows.Item(I).Item("Relatorios").ToString
                Dim strSkin As String = dt.Rows.Item(I).Item("Skin").ToString
                Dim bolFundoPadrao As Boolean = dt.Rows.Item(I).Item("FundoPadrao").ToString
                Dim strCodConfig As String = "1"
                Dim strExibicao As String = dt.Rows.Item(I).Item("Exibicao").ToString
                With Me.DsNanoCommerce.Usuario

                    .Rows.Add()
                    .Rows.Item(.Rows.Count - 1).Item("Nome") = strNome
                    .Rows.Item(.Rows.Count - 1).Item("Login") = strLogin
                    .Rows.Item(.Rows.Count - 1).Item("Nivel") = strNivel
                    .Rows.Item(.Rows.Count - 1).Item("Senha") = strSenha
                    .Rows.Item(.Rows.Count - 1).Item("FundoPadrao") = bolFundoPadrao
                    .Rows.Item(.Rows.Count - 1).Item("CodConfig") = strCodConfig
                    .Rows.Item(.Rows.Count - 1).Item("PlanoFundo") = dt.Rows.Item(I).Item("PlanoFundo")
                    .Rows.Item(.Rows.Count - 1).Item("Exibicao") = strExibicao

                    .Rows.Item(.Rows.Count - 1).Item("Principal") = strPrincipal
                    .Rows.Item(.Rows.Count - 1).Item("Consultas") = strConsultas
                    .Rows.Item(.Rows.Count - 1).Item("Relatorios") = strRelatorios
                    .Rows.Item(.Rows.Count - 1).Item("Skin") = strSkin

                End With
                Me.Validate()
                Me.UsuarioBindingSource.EndEdit()
                Me.UsuarioTableAdapter.Update(Me.DsNanoCommerce.Usuario)
                LogDeErro()
            End If

            B += 1


        Next
        Excluir("DELETE FROM Usuario where Nome = 'SQL SERVER'")


        strTabela = "Usuario"
        BarraProdgresso()
        
        '**********LOG**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Log order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            If strCodigo <> B Then

                Dim int As Integer = strCodigo - B
                Dim J As Integer


                For J = 0 To int - 1
                    Inserir("INSERT INTO Log (Antigo) VALUES ('SQL')")
                    B += 1
                    LogDeErro()
                Next


            End If
            Dim strCodUser As String = dt.Rows.Item(I).Item("CodUser").ToString
            Dim strAntigo As String = dt.Rows.Item(I).Item("Antigo").ToString
            Dim strNovo As String = dt.Rows.Item(I).Item("Novo").ToString

            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strColuna As String = dt.Rows.Item(I).Item("Coluna").ToString
            Dim strTabela As String = dt.Rows.Item(I).Item("Tabela").ToString

            Dim strMotivo As String = dt.Rows.Item(I).Item("Motivo").ToString

            Dim strCodConfig As String = "1"


            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & strData & "'," & strCodUser & ",'" & strAntigo & "','" & strNovo & "','" & strColuna & "','" & strTabela & "','" & strMotivo & "'," & strCodConfig & ")")
            B += 1
            LogDeErro()
        Next
        Excluir("DELETE FROM Log where Antigo = 'SQL'")

        strTabela = "Log"
        BarraProdgresso()
        '**********REGISTRO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Registro order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            If strCodigo <> B Then

                Dim int As Integer = strCodigo - B
                Dim J As Integer


                For J = 0 To int - 1
                    Inserir("INSERT INTO Registro (Computador) VALUES ('SQL')")
                    B += 1
                    LogDeErro()
                Next


            End If
            Dim strComputador As String = dt.Rows.Item(I).Item("Computador").ToString

            Inserir("INSERT INTO Registro (Computador) VALUES ('" & strComputador & "')")
            B += 1
            LogDeErro()
        Next
        Excluir("DELETE FROM Registro where Computador = 'SQL'")


        strTabela = "Registro"
        BarraProdgresso()
        
        '**********ORDENS**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Ordens order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            If strCodigo <> B Then

                Dim int As Integer = strCodigo - B
                Dim J As Integer


                For J = 0 To int - 1
                    Inserir("INSERT INTO Ordens (Tabela) VALUES ('SQL')")
                    B += 1
                    LogDeErro()
                Next


            End If

            Dim strCod As String = dt.Rows.Item(I).Item("Cod").ToString
            Dim strTabela As String = dt.Rows.Item(I).Item("Tabela").ToString
            Dim strCodConfig As String = "1"


            Inserir("Insert into Ordens(Cod, Tabela, CodConfig) Values('" & strCod & "','" & strTabela & "'," & strCodConfig & ")")
            B += 1
            LogDeErro()
        Next
        Excluir("DELETE FROM Ordens where Tabela = 'SQL'")

        strTabela = "Ordens"
        BarraProdgresso()
        



        '**********CONFIG**********
        dt = CarregarDataTable2("SELECT * FROM Config order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strEmpresa As String = dt.Rows.Item(I).Item("Empresa").ToString
            If strEmpresa <> "" Then


                Dim strTelefone As String = dt.Rows.Item(I).Item("Telefone").ToString
                Dim strEndereco As String = dt.Rows.Item(I).Item("Endereco").ToString
                Dim strCNPJ As String = dt.Rows.Item(I).Item("CNPJ").ToString
                Dim strOrigemRelease As String = "C"
                Dim strVersaoNano As String = dt.Rows.Item(I).Item("VersaoNano").ToString
                Dim strEmiteCupom As String = dt.Rows.Item(I).Item("EmiteCupom").ToString
                Dim strUsaTEF As String = dt.Rows.Item(I).Item("UsaTEF").ToString
                Dim strCaminhoDaPastaRemessa As String = "C"

                Dim strNumArqRM As String = dt.Rows.Item(I).Item("NumArqRM").ToString
                If strNumArqRM = "" Then
                    strNumArqRM = "NULL"
                End If
                Dim strTemImpressora As String = dt.Rows.Item(I).Item("TemImpressora").ToString
                Dim strCidade As String = ""
                Dim strModeloCarne As String = "1"
                Dim strTipoNano As String = dt.Rows.Item(I).Item("TipoNano").ToString
                Dim strPastaSinc As String = ""
                Dim strDescricao As String = "MATRIZ"
                Dim strGerarComissao As String = "FALSE"
                Dim strValidarCPF As String = "TRUE"

                Dim strTemGuilhotina As String = "FALSE"
                Dim strNomePCImpressora As String = ""
                Dim strTolerancia As String = "0"
                Dim strJuros As String = "0"
                Dim strEstoqueZerado As String = "FALSE"
                Dim strAlterarParcelas As String = "FALSE"
                Dim strImpressora As String = "FALSE"
                Dim strPorta As String = ""
                Dim strJurosParcela As String = "0"

                Dim strTipoDesc As String = "ITENS"
                Dim strImpCodBarra As String = "FALSE"
                Dim strValidarCep As String = "True"
                If I = 0 Then
                    Atualizar("UPDATE Config SET Empresa = '" & strEmpresa & "', Telefone = '" & strTelefone & "', Endereco = '" & strEndereco & "', CNPJ = '" & strCNPJ & "', OrigemRelease = '" & strOrigemRelease & "', EmiteCupom = '" & strEmiteCupom & "', UsaTEF = '" & strUsaTEF & "', CaminhoDaPastaRemessa = '" & strCaminhoDaPastaRemessa & "', NumArqRM = " & strNumArqRM & ", TemImpressora = '" & strTemImpressora & "', Cidade = '" & strCidade & "', ModeloCarne = '" & strModeloCarne & "', TipoNano = '" & strTipoNano & "', PastaSinc = '" & strPastaSinc & "', Descricao = '" & strDescricao & "', GerarComissao = '" & strGerarComissao & "', ValidarCPF = '" & strValidarCPF & "', TemGuilhotina = '" & strTemGuilhotina & "', " & _
                               "NomePCImpressora = '" & strNomePCImpressora & "', Tolerancia = " & Num(strTolerancia) & ", Juros = " & Num(strJuros) & ", EstoqueZerado = '" & strEstoqueZerado & "', AlterarParcelas = '" & strAlterarParcelas & "', Impressora = '" & strImpressora & "', Porta = '" & strPorta & "', JurosParcela = " & Num(strJurosParcela) & ", TipoDesc = '" & strTipoDesc & "', ImpCodBarra = '" & strImpCodBarra & "', ValidarCep = '" & strValidarCep & "' where Codigo = " & strCodigo)
                Else

                    Atualizar("INSERT INTO Config (Empresa, Telefone, Endereco, CNPJ, OrigemRelease, VersaoNano, EmiteCupom, UsaTEF, CaminhoDaPastaRemessa, NumArqRM, TemImpressora, Cidade, ModeloCarne, TipoNano, PastaSinc, Descricao, GerarComissao, ValidarCPF, TemGuilhotina, NomePCImpressora, Tolerancia, Juros, EstoqueZerado, AlterarParcelas, Impressora, Porta, JurosParcela, TipoDesc, ImpCodBarra, ValidarCep) VALUES ('" & strEmpresa & "','" & strTelefone & "','" & strEndereco & "','" & strCNPJ & "','" & strOrigemRelease & "','" & strVersaoNano & "','" & strEmiteCupom & "','" & strUsaTEF & "','" & strCaminhoDaPastaRemessa & "'," & strNumArqRM & ",'" & strTemImpressora & "','" & strCidade & "','" & strModeloCarne & "','" & strTipoNano & "','" & strPastaSinc & "','" & strDescricao & "','" & strGerarComissao & "','" & strValidarCPF & "','" & strTemGuilhotina & "'," & _
                                               "'" & strNomePCImpressora & "'," & Num(strTolerancia) & "," & Num(strJuros) & ",'" & strEstoqueZerado & "','" & strAlterarParcelas & "','" & strImpressora & "','" & strPorta & "'," & Num(strJurosParcela) & ",'" & strTipoDesc & "','" & strImpCodBarra & "','" & strValidarCep & "')")

                End If

                LogDeErro()
            End If
        Next

        strTabela = "Config"
        BarraProdgresso()

        Atualizar("ALTER TABLE TotalNfe alter Column NatOp VArchar(100)")

        '**********TOTALNFE**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM TotalNfe order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            If strCodigo <> B Then

                Dim int As Integer = strCodigo - B
                Dim J As Integer


                For J = 0 To int - 1
                    Inserir("INSERT INTO TotalNfe (Chave) VALUES ('SQ')")
                    B += 1
                    LogDeErro()
                Next


            End If


            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
            Dim strCodNF As String = dt.Rows.Item(I).Item("CodNF").ToString
            Dim strNumNF As String = dt.Rows.Item(I).Item("NumNF").ToString
            Dim strChave As String = dt.Rows.Item(I).Item("Chave").ToString
            Dim strIndPag As String = dt.Rows.Item(I).Item("IndPag").ToString
            Dim strDEmi As String = dt.Rows.Item(I).Item("DEmi").ToString
            Dim strDEntSai As String = dt.Rows.Item(I).Item("DEntSai").ToString

            Dim strHEntSai As String = dt.Rows.Item(I).Item("HEntSai").ToString
            Dim strCDV As String = dt.Rows.Item(I).Item("CDV").ToString

            Dim strCodCli As String = dt.Rows.Item(I).Item("CodCli").ToString
            Dim strCodForn As String = dt.Rows.Item(I).Item("CodForn").ToString

            If strCodCli <> "" Then
                strCodForn = "NULL"
            Else
                strCodCli = "NULL"
            End If
           
            Dim strVBC As String = dt.Rows.Item(I).Item("VBC").ToString
            Dim strVICMS As String = dt.Rows.Item(I).Item("VICMS").ToString
            Dim strVBCST As String = dt.Rows.Item(I).Item("VBCST").ToString

            Dim strVST As String = dt.Rows.Item(I).Item("VST").ToString
            Dim strVProd As String = dt.Rows.Item(I).Item("VProd").ToString
            Dim strVFrete As String = dt.Rows.Item(I).Item("VFrete").ToString
            Dim strVSeg As String = dt.Rows.Item(I).Item("VSeg").ToString
            Dim strVDesc As String = dt.Rows.Item(I).Item("VDesc").ToString
            Dim strVIPI As String = dt.Rows.Item(I).Item("VIPI").ToString
            Dim strVPIS As String = dt.Rows.Item(I).Item("VPIS").ToString


            Dim strVCOFINS As String = dt.Rows.Item(I).Item("VCOFINS").ToString
            Dim strVOutro As String = dt.Rows.Item(I).Item("VOutro").ToString
            Dim strVNF As String = dt.Rows.Item(I).Item("VNF").ToString
            Dim strDCont As String = dt.Rows.Item(I).Item("DCont").ToString
            Dim strHCont As String = dt.Rows.Item(I).Item("HCont").ToString
            Dim strJustCont As String = dt.Rows.Item(I).Item("JustCont").ToString
            Dim strNatOp As String = dt.Rows.Item(I).Item("NatOp").ToString

            Dim strTipoNF As String = dt.Rows.Item(I).Item("TipoNF").ToString
            Dim strTipoImp As String = dt.Rows.Item(I).Item("TipoImp").ToString
            Dim strTipoEmi As String = dt.Rows.Item(I).Item("TipoEmi").ToString
            Dim strTipoAmb As String = dt.Rows.Item(I).Item("TipoAmb").ToString
            Dim strFinNfe As String = dt.Rows.Item(I).Item("FinNfe").ToString
            Dim strProcEmi As String = dt.Rows.Item(I).Item("ProcEmi").ToString
            Dim strVerProc As String = dt.Rows.Item(I).Item("VerProc").ToString

            Dim strModFrete As String = dt.Rows.Item(I).Item("ModFrete").ToString
            Dim strObsFisco As String = dt.Rows.Item(I).Item("ObsFisco").ToString
            Dim strObsCont As String = dt.Rows.Item(I).Item("ObsCont").ToString

            Dim strNomeTrans As String = dt.Rows.Item(I).Item("NomeTrans").ToString
            Dim strCNPJTrans As String = dt.Rows.Item(I).Item("CNPJTrans").ToString
            Dim strIETRans As String = dt.Rows.Item(I).Item("IETRans").ToString

            Dim strEndTrans As String = dt.Rows.Item(I).Item("EndTrans").ToString
            Dim strBairroTrans As String = dt.Rows.Item(I).Item("BairroTrans").ToString
            Dim strNumTrans As String = dt.Rows.Item(I).Item("NumTrans").ToString
            Dim strUFTrans As String = dt.Rows.Item(I).Item("UFTrans").ToString
            Dim strCidadeTrans As String = dt.Rows.Item(I).Item("CidadeTrans").ToString
            Dim strPlaca As String = dt.Rows.Item(I).Item("Placa").ToString
            Dim strUFVei As String = dt.Rows.Item(I).Item("UFVei").ToString

            Dim strRNTC As String = dt.Rows.Item(I).Item("RNTC").ToString
            Dim strCodVenda As String = dt.Rows.Item(I).Item("CodVenda").ToString
            Dim strSerie As String = dt.Rows.Item(I).Item("Serie").ToString
            Dim strNumFatura As String = dt.Rows.Item(I).Item("NumFatura").ToString
            Dim strValOrigFatura As String = dt.Rows.Item(I).Item("ValOrigFatura").ToString
            Dim strValDescFatura As String = dt.Rows.Item(I).Item("ValDescFatura").ToString
            Dim strValLiqFatura As String = dt.Rows.Item(I).Item("ValLiqFatura").ToString
            Dim strDesconto As String = ""
            Dim strCodConfig As String = "1"

            Inserir("INSERT INTO TotalNfe (CodOrdem, CodNF, NumNF, Chave, IndPag, DEmi, DEntSai, HEntSai, CDV, CodCli, VBC, VICMS, VBCST, " & _
            "VST, VProd, VFrete, VSeg, VDesc, VIPI, VPIS, VCOFINS, VOutro, VNF, DCont, HCont, JustCont, NatOp, TipoNF, TipoImp, TipoEmi, TipoAmb, " & _
            "FinNfe, ProcEmi, VerProc, ModFrete, ObsFisco, ObsCont, CodForn, NomeTrans, CNPJTrans, IETRans, EndTrans, BairroTrans, NumTrans, UFTrans, " & _
            "CidadeTrans, Placa, UFVei, RNTC, CodVenda, Serie, NumFatura, ValOrigFatura, ValDescFatura, ValLiqFatura, Desconto, CodConfig) VALUES (" & _
            "" & strCodOrdem & ",'" & strCodNF & "','" & strNumNF & "', " & _
             "'" & strChave & "','" & strIndPag & "','" & strDEmi & "','" & strDEntSai & "','" & strHEntSai & "','" & strCDV & "'," & strCodCli & ", " & _
             "" & Num(strVBC) & "," & Num(strVICMS) & "," & Num(strVBCST) & "," & Num(strVST) & "," & Num(strVProd) & ", " & _
             "" & Num(strVFrete) & "," & Num(strVSeg) & "," & Num(strVDesc) & "," & Num(strVIPI) & "," & Num(strVPIS) & ", " & _
             "" & Num(strVCOFINS) & "," & Num(strVOutro) & "," & Num(strVNF) & ",'" & strDCont & "','" & strHCont & "', " & _
             "'" & strJustCont & "','" & strNatOp & "','" & strTipoNF & "','" & strTipoImp & "','" & strTipoEmi & "', " & _
             "'" & strTipoAmb & "','" & strFinNfe & "','" & strProcEmi & "','" & strVerProc & "','" & strModFrete & "','" & strObsFisco & "'," & _
             "'" & strObsCont & "'," & strCodForn & ",'" & strNomeTrans & "','" & strCNPJTrans & "','" & strIETRans & "'," & _
             "'" & strEndTrans & "','" & strBairroTrans & "','" & strNumTrans & "','" & strUFTrans & "','" & strCidadeTrans & "'," & _
             "'" & strPlaca & "','" & strUFVei & "','" & strRNTC & "','" & strCodVenda & "','" & strSerie & "','" & strNumFatura & "'," & _
             "'" & strValOrigFatura & "','" & strValDescFatura & "','" & strValLiqFatura & "','" & strDesconto & "'," & strCodConfig & ")")


         
            B += 1
            LogDeErro()
        Next
        Excluir("DELETE FROM TotalNfe where Chave = 'SQ'")

        strTabela = "TotalNFE"
        BarraProdgresso()

        '**********ITENSNFE**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM ItensNfe order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            If strCodigo <> B Then

                Dim int As Integer = strCodigo - B
                Dim J As Integer


                For J = 0 To int - 1
                    Inserir("INSERT INTO ItensNfe (NCM) VALUES ('SQ')")
                    B += 1
                    LogDeErro()
                Next


            End If
            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString


            Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
            Dim strCodInterno As String = dt.Rows.Item(I).Item("CodInterno").ToString

            Dim strCodBarra As String = dt.Rows.Item(I).Item("CodBarra").ToString
            Dim strProduto As String = dt.Rows.Item(I).Item("Produto").ToString
            Dim strNCM As String = dt.Rows.Item(I).Item("NCM").ToString
            Dim strCFOP As String = dt.Rows.Item(I).Item("CFOP").ToString
            Dim strEXTIPI As String = dt.Rows.Item(I).Item("EXTIPI").ToString
            Dim strUCom As String = dt.Rows.Item(I).Item("UCom").ToString
            Dim strQCom As String = dt.Rows.Item(I).Item("QCom").ToString
            Dim strVUnCom As String = dt.Rows.Item(I).Item("VUnCom").ToString
            Dim strVProd As String = dt.Rows.Item(I).Item("VProd").ToString
            Dim strOrigem As String = dt.Rows.Item(I).Item("Origem").ToString
            Dim strCSTICMS As String = dt.Rows.Item(I).Item("CSTICMS").ToString
            Dim strModBC As String = dt.Rows.Item(I).Item("ModBC").ToString
            Dim strVBCICMS As String = dt.Rows.Item(I).Item("VBCICMS").ToString
            Dim strRedBC As String = dt.Rows.Item(I).Item("RedBC").ToString
            Dim strICMS As String = dt.Rows.Item(I).Item("ICMS").ToString
            Dim strValICMS As String = dt.Rows.Item(I).Item("ValICMS").ToString
            Dim strModBCST As String = dt.Rows.Item(I).Item("ModBCST").ToString
            Dim strRedBCST As String = dt.Rows.Item(I).Item("RedBCST").ToString
            Dim strVBCST As String = dt.Rows.Item(I).Item("VBCST").ToString
            Dim strICMSST As String = dt.Rows.Item(I).Item("ICMSST").ToString
            Dim strValICMSST As String = dt.Rows.Item(I).Item("ValICMSST").ToString

            Dim strMVaST As String = dt.Rows.Item(I).Item("MVaST").ToString

            Dim strCalcCred As String = dt.Rows.Item(I).Item("CalcCred").ToString
            Dim strVCalcCred As String = dt.Rows.Item(I).Item("VCalcCred").ToString

            Dim strCodEnq As String = dt.Rows.Item(I).Item("CodEnq").ToString

            Dim strCSTIPI As String = dt.Rows.Item(I).Item("CSTIPI").ToString
            Dim strVBCIPI As String = dt.Rows.Item(I).Item("VBCIPI").ToString
            Dim strPerIPI As String = dt.Rows.Item(I).Item("PerIPI").ToString
            Dim strValIPI As String = dt.Rows.Item(I).Item("ValIPI").ToString

            Dim strCSTPIS As String = dt.Rows.Item(I).Item("CSTPIS").ToString
            Dim strVBCPIS As String = dt.Rows.Item(I).Item("VBCPIS").ToString
            Dim strPerPIS As String = dt.Rows.Item(I).Item("PerPIS").ToString
            Dim strValPIS As String = dt.Rows.Item(I).Item("ValPIS").ToString

            Dim strCSTCOFINS As String = dt.Rows.Item(I).Item("CSTCOFINS").ToString
            Dim strVBCCOFINS As String = dt.Rows.Item(I).Item("VCBCOFINS").ToString
            Dim strPerCOFINS As String = dt.Rows.Item(I).Item("PerCOFINS").ToString
            Dim strValCOFINS As String = dt.Rows.Item(I).Item("ValCOFINS").ToString

            Dim strValAprox As String = ""

            Inserir("INSERT INTO ItensNfe (CodOrdem, CodProd, CodInterno, CodBarra, Produto, NCM, CFOP, EXTIPI, UCom, QCom, VUnCom, VProd," & _
            "Origem, CSTICMS, ModBC, VBCICMS, RedBC, ICMS, ValICMS, ModBCST, RedBCST, VBCST, ICMSST, ValICMSST, MVaST, CalcCred, CodEnq," & _
            "CSTIPI, VBCIPI, PerIPI, ValIPI, CSTPIS, VBCPIS, PerPIS, ValPIS, CSTCOFINS, VCBCOFINS, PerCOFINS, ValCOFINS, VCalcCred, ValAprox, CodConfig) VALUES (" & strCodOrdem & ", " & _
            "" & strCodProd & ",'" & strCodInterno & "','" & strCodBarra & "','" & strProduto & "','" & strNCM & "','" & strCFOP & "','" & strEXTIPI & "'," & _
            "'" & strUCom & "'," & Num(strQCom) & "," & Num(strVUnCom) & "," & Num(strVProd) & ",'" & strOrigem & "','" & strCSTICMS & "','" & strModBC & "'," & _
            "'" & strVBCICMS & "','" & strRedBC & "','" & strICMS & "','" & strValICMS & "','" & strModBCST & "','" & strRedBCST & "','" & strVBCST & "'," & _
            "'" & strICMSST & "','" & strValICMSST & "','" & strMVaST & "','" & strCalcCred & "','" & strCodEnq & "','" & strCSTIPI & "','" & strVBCIPI & "'," & _
            "'" & strPerIPI & "','" & strValIPI & "','" & strCSTPIS & "','" & strVBCPIS & "','" & strPerPIS & "','" & strValPIS & "','" & strCSTCOFINS & "'," & _
            "'" & strVBCCOFINS & "','" & strPerCOFINS & "','" & strValCOFINS & "','" & strVCalcCred & "','" & strValAprox & "',1)")


            

            B += 1
            LogDeErro()
        Next
        Excluir("DELETE FROM ItensNfe where NCM = 'SQ'")

        strTabela = "ItensNfe"
        BarraProdgresso()


        '**********VOLUMENFE**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM VolumeNfe order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            If strCodigo <> B Then

                Dim int As Integer = strCodigo - B
                Dim J As Integer


                For J = 0 To int - 1
                    Inserir("INSERT INTO VolumeNfe (Especie) VALUES ('SQ')")
                    B += 1
                    LogDeErro()
                Next


            End If
            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString

            Dim strQtde As String = dt.Rows.Item(I).Item("Qtde").ToString
            Dim strEspecie As String = dt.Rows.Item(I).Item("Especie").ToString
            Dim strMarca As String = dt.Rows.Item(I).Item("Marca").ToString

            Dim strNumero As String = dt.Rows.Item(I).Item("Numero").ToString

            Dim strPesoLiq As String = dt.Rows.Item(I).Item("PesoLiq").ToString

            Dim strPesoBruto As String = dt.Rows.Item(I).Item("PesoBruto").ToString


            Inserir("INSERT INTO VolumeNfe (CodOrdem, Qtde, Especie, Marca, Numero, PesoLiq, PesoBruto, CodConfig) VALUES (" & strCodOrdem & "," & _
            "'" & strQtde & "','" & strEspecie & "','" & strMarca & "','" & strNumero & "','" & strPesoLiq & "','" & strPesoBruto & "',1)")





            B += 1
            LogDeErro()
        Next
        Excluir("DELETE FROM VolumeNfe where Especie = 'SQ'")

        strTabela = "VolumeNfe"
        BarraProdgresso()


        '**********DUPLICATANFE**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM DuplicataNfe order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            If strCodigo <> B Then

                Dim int As Integer = strCodigo - B
                Dim J As Integer


                For J = 0 To int - 1
                    Inserir("INSERT INTO DuplicataNfe (Numero) VALUES ('SQ')")
                    B += 1
                    LogDeErro()
                Next


            End If
            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
            Dim strNumero As String = dt.Rows.Item(I).Item("Numero").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString

            Inserir("INSERT INTO DuplicataNfe (CodOrdem, Numero, Data, Valor, CodConfig) VALUES (" & strCodOrdem & "," & _
            "'" & strNumero & "','" & strData & "','" & strValor & "',1)")


            B += 1
            LogDeErro()
        Next
        Excluir("DELETE FROM DuplicataNfe where Numero = 'SQ'")

        strTabela = "DuplicataNfe"
        BarraProdgresso()

        Me.Cursor = Cursors.Default
        Me.rtbMens.AppendText(vbCrLf & "Tabelas migradas com sucesso!")
        Me.btnOk.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub
End Class