Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.IO.File
Imports System.Collections
Imports ADOX
Imports ADODB
Imports Nano.clsFuncoes
Imports System.Data.Sql
imports System.Data.SqlClient

Public Class clsBanco

    Public Shared Function CriarBanco() As Boolean
        Dim strBanco As String
        strBanco = "CREATE DATABASE " & NomeDoBancoSql & " ON PRIMARY " & _
          "(NAME = " & NomeDoBancoSql & "_Data, " & _
          " FILENAME = 'C:\NANO\BD\" & NomeDoBancoSql & ".mdf', " & _
          " SIZE = 5MB, " & _
          " FILEGROWTH = 1MB) " & _
          " LOG ON " & _
          "(NAME = " & NomeDoBancoSql & "_Log, " & _
          " FILENAME = 'C:\NANO\BD\" & NomeDoBancoSql & ".ldf', " & _
          " SIZE = 1MB," & _
          " FILEGROWTH = 10%) "

        CriarBancoSQL(strBanco)

        strBanco = "CREATE DATABASE dbBackup ON PRIMARY " & _
               "(NAME = dbBackup_Data, " & _
               " FILENAME = 'C:\NANO\BD\dbBackup.mdf', " & _
               " SIZE = 5MB, " & _
               " FILEGROWTH = 1MB) " & _
               " LOG ON " & _
               "(NAME = dbBackup_Log, " & _
               " FILENAME = 'C:\NANO\BD\dbBackup.ldf', " & _
               " SIZE = 1MB, " & _
               " FILEGROWTH = 10%) "

        CriarBancoSQL(strBanco)
    End Function

    
    Private Shared Function ExecutaSQL(ByVal strSQL As String, Optional ByVal parMensagem As Boolean = True) As Boolean
        parMensagem = parMensagem
        Try
            Dim conexao = New SqlClient.SqlConnection(StringDeConexao)
            Dim cmd As SqlCommand
            conexao.open()
            cmd = New SqlCommand(strSQL, conexao)

            cmd.ExecuteNonQuery()
            cmd.UpdatedRowSource = UpdateRowSource.Both
            conexao.close()
            Return True
        Catch ex As Exception
            If parMensagem = True Then
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End If
            Return False
        End Try
    End Function
    Public Shared Function GerenciaTabelas() As Boolean

        Try

            If VersaoDoSistemaBanco = "1.0.0" Then
                If ExisteTabela("Ordem") = False Then
                    ExecutaSQL("CREATE TABLE Ordem (" & _
                    "Codigo INTEGER," & _
                    "CodConfig Integer);")

                    ExecutaSQL("Insert Into Ordem (Codigo, CodConfig) Values(99,1)")

                End If

                If ExisteTabela("Banco") = False Then
                    ExecutaSQL("CREATE TABLE Banco (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey PRIMARY KEY," & _
                    "Nome varchar (50)," & _
                    "Saldo NUMERIC (15,3)," & _
                    "CodConfig Integer);")
                End If

                If ExisteTabela("Bloqueios") = False Then
                    ExecutaSQL("CREATE TABLE Bloqueios (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey2 PRIMARY KEY," & _
                    "Principal varchar (60) null," & _
                    "Relatorios varchar (60) null);")
                End If

                If ExisteTabela("Caixa") = False Then
                    ExecutaSQL("CREATE TABLE Caixa (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey40 PRIMARY KEY," & _
                    "Motivo varchar (150)," & _
                    "Caixa varchar (100)," & _
                    "Credito varchar (2)," & _
                    "Pagamento varchar(25)," & _
                    "Valor NUMERIC (15,3)," & _
                    "Data SmallDateTime," & _
                    "CodConfig Integer);")
                End If

                If ExisteTabela("Config") = False Then
                    ExecutaSQL("CREATE TABLE Config (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey3 PRIMARY KEY," & _
                    "Empresa varchar (100)," & _
                    "Telefone varchar (100)," & _
                    "Endereco varchar (100)," & _
                    "CNPJ varchar (14)," & _
                    "OrigemRelease varchar (100)," & _
                    "Logo image," & _
                    "VersaoNano varchar(5)," & _
                    "EmiteCupom varchar(1)," & _
                    "UsaTEF varchar(1)," & _
                    "CaminhoDaPastaRemessa varchar(150)," & _
                    "NumArqRM INTEGER," & _
                    "TemImpressora Bit," & _
                    "Cidade varchar(80)," & _
                    "ModeloCarne varchar(1)," & _
                    "TipoNano varchar(1)," & _
                    "PastaSinc varchar(150)," & _
                    "Descricao varchar(100)," & _
                    "GerarComissao bit," & _
                    "ValidarCPF bit," & _
                    "TemGuilhotina bit," & _
                    "NomePCImpressora varchar(80)," & _
                    "Tolerancia NUMERIC (15,3)," & _
                    "Juros NUMERIC (15,3)," & _
                    "EstoqueZerado bit," & _
                    "AlterarParcelas bit," & _
                    "Impressora varchar(50)," & _
                    "Porta varchar(80)," & _
                    "JurosParcela NUMERIC (15,3)," & _
                    "TipoDesc varchar(10)," & _
                    "ImpCodBarra VARCHAR(40)," & _
                    "ValidarCep bit);")

                    ExecutaSQL("Insert Into Config (VersaoNano, TipoNano, Descricao, EstoqueZerado, AlterarParcelas, TipoDesc, JurosParcela, TemImpressora, GerarComissao, ValidarCPF, TemGuilhotina, ValidarCep) Values('1.0.0','0','MATRIZ','True','False','ITENS','0','False','False','False','False','True')")

                End If

                If ExisteTabela("Cliente") = False Then
                    ExecutaSQL("CREATE TABLE Cliente (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey4 PRIMARY KEY," & _
                    "Nome varchar (150)," & _
                    "RGIE varchar (15)," & _
                    "CPF varchar(25)," & _
                    "Endereco varchar(150)," & _
                    "Numero varchar(10)," & _
                    "Complemento varchar(75)," & _
                    "Bairro varchar(100)," & _
                    "Cep varchar(20)," & _
                    "Cidade varchar(80)," & _
                    "Estado varchar(40)," & _
                    "Telefone varchar (18)," & _
                    "Fax varchar (18)," & _
                    "Celular varchar (18)," & _
                    "Email varchar(50)," & _
                    "Data SmallDateTime," & _
                    "Fantasia varchar(80)," & _
                    "Observacao nvarchar(MAX)," & _
                    "Inadimplente Bit," & _
                    "Status varchar(1)," & _
                    "Nascimento SmallDateTime," & _
                    "Sexo varchar(1)," & _
                    "Limite varchar (18)," & _
                    "Empresa varchar(100)," & _
                    "TelEmpresa varchar (18)," & _
                    "Salario varchar (18)," & _
                    "Credito varchar (18)," & _
                    "Marcas varchar (200)," & _
                    "CodConfig Integer," & _
                    "Pessoa1 varchar(100)," & _
                    "Pessoa2 varchar(100)," & _
                    "RG1 varchar(15)," & _
                    "RG2 varchar(15)," & _
                    "Inativo bit);")

                    ExecutaSQL("Insert into Cliente (Nome, CPF, Inadimplente, Inativo) values('CONSUMIDOR','000.000.000-00','False','False')")
                End If

                If ExisteTabela("CFOP") = False Then
                    ExecutaSQL("CREATE TABLE CFOP (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey5 PRIMARY KEY," & _
                    "NatOper varchar (100)," & _
                    "CFOP varchar (10));")
                End If

                If ExisteTabela("Comissao") = False Then
                    ExecutaSQL("CREATE TABLE Comissao (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey6 PRIMARY KEY," & _
                    "CodOrdem INTEGER," & _
                    "CodFunc INTEGER," & _
                    "Funcionario varchar (100)," & _
                    "ValorProduto NUMERIC (15,3)," & _
                    "Porcentagem NUMERIC (15,3), " & _
                    "ValorComissao NUMERIC (15,3)," & _
                    "Data SmallDateTime," & _
                    "Motivo varchar(150)," & _
                    "Tipo varchar(1)," & _
                    "CodConfig Integer);")

                End If

                If ExisteTabela("ContaReceber") = False Then
                    ExecutaSQL("CREATE TABLE ContaReceber (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey7 PRIMARY KEY," & _
                    "CodOrdem INTEGER," & _
                    "DataVenda varchar (25)," & _
                    "CodCli INTEGER," & _
                    "Obs nvarchar(MAX)," & _
                    "FormaPagamento varchar (25)," & _
                    "Parcelas varchar (3)," & _
                    "ValorParcela NUMERIC (15,3)," & _
                    "Vencimento SmallDateTime," & _
                    "ValorVenda NUMERIC (15,3)," & _
                    "ValorRecebido NUMERIC (15,3)," & _
                    "Recebimento SmallDateTime," & _
                    "RecebidoOK Bit," & _
                    "Pagamento varchar (25)," & _
                    "NumeroDocumento varchar (25)," & _
                    "TipoCusto varchar (1)," & _
                    "Banco varchar (50)," & _
                    "CodConfig Integer);")

                    ExecutaSQL("ALTER TABLE ContaReceber ADD CONSTRAINT fk_CliContRec FOREIGN KEY (CodCli) REFERENCES Cliente(Codigo) ON UPDATE CASCADE;")

                End If


                If ExisteTabela("Fornecedor") = False Then
                    ExecutaSQL("CREATE TABLE Fornecedor (" & _
                        "Codigo INT IDENTITY CONSTRAINT primarykey9 PRIMARY KEY," & _
                        "Nome varchar (150)," & _
                        "CPF varchar (25)," & _
                        "Endereco varchar (150)," & _
                        "Numero varchar (10)," & _
                        "Complemento varchar (80)," & _
                        "Bairro varchar (80)," & _
                        "Cep varchar (15)," & _
                        "Cidade varchar (70)," & _
                        "Estado varchar (50)," & _
                        "Telefone varchar (18)," & _
                        "Fax varchar (18)," & _
                        "Celular varchar (18)," & _
                        "Email varchar (50)," & _
                        "Data SmallDateTime," & _
                        "IE varchar (15)," & _
                        "Contato varchar (100)," & _
                        "Site varchar (80)," & _
                        "Fantasia varchar (80)," & _
                        "Status varchar (1)," & _
                        "Obs nvarchar(MAX)," & _
                        "CodConfig Integer);")

                End If

                If ExisteTabela("ContaPagar") = False Then
                    ExecutaSQL("CREATE TABLE ContaPagar (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey10 PRIMARY KEY," & _
                    "CodFor INTEGER," & _
                    "TipoConta varchar (25)," & _
                    "Valor NUMERIC (15,3)," & _
                    "FormaPagamento varchar (25)," & _
                    "Parcelas varchar (2)," & _
                    "ValorParcela NUMERIC (15,3)," & _
                    "Vencimento SmallDateTime," & _
                    "DataPagamento SmallDateTime," & _
                    "ValorPago NUMERIC (15,3)," & _
                    "Descricao nvarchar(MAX)," & _
                    "PagoOK Bit," & _
                    "Pagamento varchar (25)," & _
                    "NumeroDocumento varchar (25)," & _
                    "TipoCusto varchar (1)," & _
                    "Banco varchar (50)," & _
                    "CodConfig Integer);")

                    ExecutaSQL("ALTER TABLE ContaPagar ADD CONSTRAINT fk_ForContaPagar FOREIGN KEY (CodFor) REFERENCES Fornecedor(Codigo) ON UPDATE CASCADE;")

                End If

                If ExisteTabela("TotalEntradaNF") = False Then
                    ExecutaSQL("CREATE TABLE TotalEntradaNF (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey11 PRIMARY KEY," & _
                    "NumeroNF varchar (15)," & _
                    "CodFor INTEGER," & _
                    "Total NUMERIC (15,3)," & _
                    "Obs nvarchar(MAX)," & _
                    "Data SmallDateTime," & _
                    "EstoqueOK Bit," & _
                    "Lote varchar (15)," & _
                    "Desconto VARCHAR (30)," & _
                    "Tipo varchar (1)," & _
                    "Serie varchar (4)," & _
                    "ValorFrete VARCHAR (18)," & _
                    "ValorSeguro VARCHAR (18)," & _
                    "OutrasDespesas VARCHAR (18)," & _
                    "ICMS VARCHAR (18)," & _
                    "IPI VARCHAR (18)," & _
                    "CodConfig Integer);")

                    ExecutaSQL("ALTER TABLE TotalEntradaNF ADD CONSTRAINT fk_Fornec FOREIGN KEY (CodFor) REFERENCES Fornecedor(Codigo) ON UPDATE CASCADE;")

                End If

                If ExisteTabela("EntradaNF") = False Then
                    ExecutaSQL("CREATE TABLE EntradaNF (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey12 PRIMARY KEY," & _
                    "CodTotNF Integer," & _
                    "CodProd INTEGER," & _
                    "Tamanho varchar (4)," & _
                    "Qtd Numeric(15,3)," & _
                    "ValorUnitario NUMERIC (15,3)," & _
                    "ValorTotal NUMERIC (15,3)," & _
                    "Produto varchar (100)," & _
                    "CodProdInterno varchar (50)," & _
                    "ICMS VARCHAR (18)," & _
                    "Desconto VARCHAR (18)," & _
                    "IPI VARCHAR (18)," & _
                    "UnitarioImposto NUMERIC (15,3)," & _
                    "CodConfig Integer," & _
                    "QtdTotal VARCHAR (18)," & _
                    "UM varchar(2));")

                    ExecutaSQL("ALTER TABLE EntradaNF ADD CONSTRAINT fk_TotNF FOREIGN KEY (CodTotNF) REFERENCES TotalEntradaNF(Codigo) ON UPDATE CASCADE ON DELETE CASCADE;")

                End If


                If ExisteTabela("Representante") = False Then
                    ExecutaSQL("CREATE TABLE Representante (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey13 PRIMARY KEY," & _
                    "CodFor INTEGER," & _
                    "Nome varchar (100)," & _
                    "Tel1 varchar (18)," & _
                    "Tel2 varchar (18)," & _
                    "Web varchar (50));")

                    ExecutaSQL("ALTER TABLE Representante ADD CONSTRAINT fk_Fornece FOREIGN KEY (CodFor) REFERENCES Fornecedor(Codigo) ON UPDATE CASCADE ON DELETE CASCADE;")

                End If

                If ExisteTabela("Funcionario") = False Then
                    ExecutaSQL("CREATE TABLE Funcionario (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey14 PRIMARY KEY," & _
                    "Nome varchar (100)," & _
                    "CPF varchar (25)," & _
                    "RG varchar (12)," & _
                    "Telefone varchar (18)," & _
                    "Celular varchar (18)," & _
                    "Endereco varchar (100)," & _
                    "Bairro varchar (80)," & _
                    "Cidade varchar (80)," & _
                    "Nascimento SmallDateTime," & _
                    "Obs nvarchar(MAX)," & _
                    "PorcComissao varchar (5)," & _
                    "Funcao varchar (25)," & _
                    "DataAdmissao varchar (18)," & _
                    "DataDemissao varchar (18)," & _
                    "Email varchar (50)," & _
                    "Ativo Bit," & _
                    "Sangue varchar (15)," & _
                    "Alergia varchar (80)," & _
                    "CEP varchar (10)," & _
                    "UF varchar (2)," & _
                    "Complemento varchar (50)," & _
                    "Num varchar (10)," & _
                    "CodConfig INTEGER);")

                End If


                If ExisteTabela("Recebimento") = False Then
                    ExecutaSQL("CREATE TABLE Recebimento (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey15 PRIMARY KEY," & _
                    "CodOrdem INTEGER," & _
                    "FormaPagamento varchar (10)," & _
                    "Pagamento varchar (25)," & _
                    "Documento varchar (80)," & _
                    "Valor NUMERIC (15,3)," & _
                    "Data SmallDateTime," & _
                    "Obs nvarchar(MAX)," & _
                    "CodConfig Integer);")

                End If

                If ExisteTabela("Futuro") = False Then
                    ExecutaSQL("CREATE TABLE Futuro (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey16 PRIMARY KEY," & _
                    "Data SmallDateTime," & _
                    "CodOrdem INTEGER," & _
                    "Pagamento varchar (70)," & _
                    "Total NUMERIC (15,3)," & _
                    "TotalDesconto NUMERIC (15,3)," & _
                    "CodConfig Integer);")

                End If

                If ExisteTabela("Grupo") = False Then
                    ExecutaSQL("CREATE TABLE Grupo (" & _
                    "Codigo INT IDENTITY, " & _
                    "Nome varchar (80) CONSTRAINT primarykey17 PRIMARY KEY," & _
                    "Tipo varchar(1));")

                End If

                If ExisteTabela("Produto") = False Then
                    ExecutaSQL("CREATE TABLE Produto (" & _
                        "Codigo INT IDENTITY CONSTRAINT primarykey18 PRIMARY KEY," & _
                        "Nome varchar (100)," & _
                        "UnidadeMedida varchar (15)," & _
                        "Valor NUMERIC (15,3)," & _
                        "ValorCusto NUMERIC (15,3)," & _
                        "Locacao varchar (10)," & _
                        "CodigoInterno varchar (50)," & _
                        "Porcentagens varchar (20)," & _
                        "Fabricante varchar (55)," & _
                        "Grupo varchar (80)," & _
                        "Obs nvarchar(MAX)," & _
                        "Data varchar (25)," & _
                        "CodigoBarra varchar (25)," & _
                        "NivelComboCodCF varchar(1)," & _
                        "Desconto NUMERIC (15,3)," & _
                        "Setor varchar(80)," & _
                        "Tipo varchar(10));")

                    ExecutaSQL("ALTER TABLE Produto ADD CONSTRAINT fk_Produto2 FOREIGN KEY (Grupo) REFERENCES Grupo(Nome) ON UPDATE CASCADE;")

                End If

                If ExisteTabela("ImpostoProduto") = False Then
                    ExecutaSQL("CREATE TABLE ImpostoProduto (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey19 PRIMARY KEY," & _
                    "CodProd INTEGER," & _
                    "ICMS NUMERIC (15,3)," & _
                    "IPI NUMERIC (15,3)," & _
                    "Tributacao varchar(1)," & _
                    "Cst varchar(2)," & _
                    "OrigemICMS varchar(1)," & _
                    "IPPT varchar(1)," & _
                    "Pesavel varchar(1)," & _
                    "TipoFIA varchar(1));")

                    ExecutaSQL("ALTER TABLE ImpostoProduto ADD CONSTRAINT fk_ImpostoProduto FOREIGN KEY (CodProd) REFERENCES Produto(Codigo) ON DELETE CASCADE;")

                End If

                If ExisteTabela("Pagamento") = False Then
                    ExecutaSQL("CREATE TABLE Pagamento (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey21 PRIMARY KEY," & _
                    "Descricao varchar (25)," & _
                    "Dias varchar (3)," & _
                    "Desconto varchar (5)," & _
                    "Prazo Bit," & _
                    "FormaPagamento varchar (15)," & _
                    "IrCaixa varchar(3));")
                End If


                If ExisteTabela("Pedido") = False Then
                    ExecutaSQL("CREATE TABLE Pedido (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey22 PRIMARY KEY," & _
                    "CodOrdem INTEGER," & _
                    "Qtd Numeric(15,3)," & _
                    "CodProd INTEGER," & _
                    "Produto varchar (80)," & _
                    "ValorUnitario NUMERIC (15,3)," & _
                    "ValorTotal NUMERIC (15,3)," & _
                    "CodProdInterno varchar (55)," & _
                    "CodFunc INTEGER," & _
                    "Custo NUMERIC (15,3)," & _
                    "Tamanho varchar (4)," & _
                    "UM varchar (5)," & _
                    "Devolvido Bit," & _
                    "Lote varchar(20)," & _
                    "TipoItens varchar(10)," & _
                    "CodConfig Integer);")

                End If

                If ExisteTabela("Total") = False Then
                    ExecutaSQL("CREATE TABLE Total (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey23 PRIMARY KEY," & _
                    "CodOrdem INTEGER," & _
                    "Data SmallDateTime," & _
                    "CodCli INTEGER," & _
                    "Total NUMERIC (15,3)," & _
                    "Recebido NUMERIC (15,3)," & _
                    "Troco NUMERIC (15,3)," & _
                    "PorDesc NUMERIC (15,3)," & _
                    "ValDesc NUMERIC (15,3)," & _
                    "PorAcre NUMERIC (15,3)," & _
                    "ValAcre NUMERIC (15,3)," & _
                    "Custo NUMERIC (15,3)," & _
                    "EmitirCupom Bit," & _
                    "CodConfig Integer);")

                    ExecutaSQL("ALTER TABLE Total ADD CONSTRAINT fk_Cliente2 FOREIGN KEY (CodCli) REFERENCES Cliente(Codigo) ON UPDATE CASCADE;")

                End If

                If ExisteTabela("Usuario") = False Then
                    ExecutaSQL("CREATE TABLE Usuario (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey24 PRIMARY KEY," & _
                    "Login varchar (20)," & _
                    "Nome varchar (80)," & _
                    "Nivel varchar (15)," & _
                    "Senha varchar (10)," & _
                    "Principal varchar (50)," & _
                    "Consultas varchar (30)," & _
                    "Relatorios varchar (50)," & _
                    "Skin varchar(20)," & _
                    "PlanoFundo image," & _
                    "FundoPadrao bit," & _
                    "Exibicao varchar(1)," & _
                    "CodConfig Integer);")

                    ExecutaSQL("Insert Into Usuario (Login, Nome, Nivel, Senha, CodConfig, FundoPadrao) Values('ADM','ADMINISTRADOR','MASTER','SPFC',1,'True')")

                    ExecutaSQL("ALTER TABLE Usuario ADD CONSTRAINT fk_CodConfig FOREIGN KEY (CodConfig) REFERENCES Config(Codigo);")
                End If

                If ExisteTabela("Cidade") = False Then
                    ExecutaSQL("CREATE TABLE Cidade (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey25 PRIMARY KEY," & _
                    "Nome varchar (50)," & _
                    "UF varchar (2));")
                End If

                If ExisteTabela("Estado") = False Then
                    ExecutaSQL("CREATE TABLE Estado (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey26 PRIMARY KEY," & _
                    "Nome varchar (50)," & _
                    "UF varchar (2));")

                End If

                If ExisteTabela("MovimentoBancario") = False Then
                    ExecutaSQL("CREATE TABLE MovimentoBancario (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey27 PRIMARY KEY," & _
                    "CodBanco INTEGER," & _
                    "TipoMovimento varchar (10)," & _
                    "Valor NUMERIC (15,3)," & _
                    "Data SmallDateTime," & _
                    "Observacao nvarchar(MAX)," & _
                    "CodConfig Integer);")

                    ExecutaSQL("ALTER TABLE MovimentoBancario ADD CONSTRAINT fk_Movimento FOREIGN KEY (CodBanco) REFERENCES Banco(Codigo) ON DELETE CASCADE;")
                End If

                If ExisteTabela("Qtde") = False Then
                    ExecutaSQL("CREATE TABLE Qtde (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey28 PRIMARY KEY," & _
                    "CodProd Integer," & _
                    "Tamanho varchar (4)," & _
                    "QtdMinima Numeric(15,3)," & _
                    "Qtd Numeric(15,3)," & _
                    "Lote varchar (20)," & _
                    "ValorCusto NUMERIC (15,3)," & _
                    "EmFalta varchar (1)," & _
                    "Acabou Bit," & _
                    "CodConfig Integer);")

                    ExecutaSQL("ALTER TABLE Qtde ADD CONSTRAINT fk_Prod FOREIGN KEY (CodProd) REFERENCES Produto(Codigo) ON DELETE CASCADE;")

                End If

                If ExisteTabela("Devolucao") = False Then
                    ExecutaSQL("CREATE TABLE Devolucao (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey29 PRIMARY KEY," & _
                    "CodProd INTEGER," & _
                    "Qtde Numeric(15,3)," & _
                    "CodCli INTEGER," & _
                    "Data SmallDateTime," & _
                    "CodFunc INTEGER," & _
                    "Motivo varchar (100)," & _
                    "Valor NUMERIC (15,3)," & _
                    "Tamanho varchar(4)," & _
                    "CodConfig Integer);")

                    ExecutaSQL("ALTER TABLE Devolucao ADD CONSTRAINT fk_Devolucao FOREIGN KEY (CodCli) REFERENCES Cliente(Codigo) ON UPDATE CASCADE;")

                End If

                If ExisteTabela("Log") = False Then
                    ExecutaSQL("CREATE TABLE Log (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey30 PRIMARY KEY," & _
                    "Data varchar (25)," & _
                    "CodUser INTEGER," & _
                    "Antigo varchar (150)," & _
                    "Novo varchar (150)," & _
                    "Coluna varchar (50)," & _
                    "Tabela varchar (30)," & _
                    "Motivo varchar (10)," & _
                    "CodConfig Integer);")

                    ExecutaSQL("ALTER TABLE Log ADD CONSTRAINT fk_Log1 FOREIGN KEY (CodUser) REFERENCES Usuario(Codigo) ON UPDATE CASCADE;")

                End If

                If ExisteTabela("Registro") = False Then
                    ExecutaSQL("CREATE TABLE Registro (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey31 PRIMARY KEY," & _
                    "Computador varchar (255));")
                End If


                If ExisteTabela("TotalConsig") = False Then
                    ExecutaSQL("CREATE TABLE TotalConsig (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey32 PRIMARY KEY," & _
                    "CodOrdens Integer," & _
                    "Data SmallDateTime," & _
                    "CodCli INTEGER," & _
                    "Total NUMERIC (15,3)," & _
                    "Descricao nvarchar(MAX)," & _
                    "Status varchar (10)," & _
                    "Custo NUMERIC (15,3)," & _
                    "Desconto varchar (30)," & _
                    "Entrega varchar (18)," & _
                    "CodFunc INTEGER," & _
                    "CodConfig Integer);")

                End If

                If ExisteTabela("ItensConsig") = False Then
                    ExecutaSQL("CREATE TABLE ItensConsig (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey33 PRIMARY KEY," & _
                    "CodOrdens INTEGER," & _
                    "Qtd Numeric(15,3)," & _
                    "CodigoProduto varchar (10)," & _
                    "Produto varchar (150)," & _
                    "ValorUnitario NUMERIC (15,3)," & _
                    "ValorTotal NUMERIC (15,3)," & _
                    "CodigoInterno varchar (50)," & _
                    "Custo NUMERIC (15,3)," & _
                    "UM varchar (2)," & _
                    "Tamanho varchar (10)," & _
                    "CodConfig Integer);")
                End If

                If ExisteTabela("Descarte") = False Then
                    ExecutaSQL("CREATE TABLE Descarte (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey34 PRIMARY KEY," & _
                    "CodProd INTEGER," & _
                    "Qtde Numeric(15,3)," & _
                    "ValorUnitario NUMERIC (15,3)," & _
                    "Motivo varchar (100)," & _
                    "Data SmallDateTime," & _
                    "CodFunc INTEGER," & _
                    "CodConfig Integer);")

                End If

                If ExisteTabela("ItensReceita") = False Then
                    ExecutaSQL("CREATE TABLE ItensReceita (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey35 PRIMARY KEY," & _
                    "CodigoInterno varchar (25)," & _
                    "Qtd Numeric(15,3)," & _
                    "CodProd INTEGER," & _
                    "CodProdInterno varchar (55)," & _
                    "Custo NUMERIC (15,3)," & _
                    "Valor NUMERIC (15,3));")

                End If

                If ExisteTabela("Receita") = False Then
                    ExecutaSQL("CREATE TABLE Receita (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey36 PRIMARY KEY," & _
                    "CodigoInterno varchar (25)," & _
                    "Nome varchar (200)," & _
                    "ValorVenda NUMERIC (15,3)," & _
                    "ValorCusto NUMERIC (15,3)," & _
                    "Obs nvarchar(MAX)," & _
                    "CodConfig Integer);")

                End If

                If ExisteTabela("Ordens") = False Then
                    ExecutaSQL("CREATE TABLE Ordens (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey37 PRIMARY KEY," & _
                    "Cod INTEGER," & _
                    "Tabela varchar (25)," & _
                    "CodConfig Integer);")

                    Inserir("Insert Into Ordens (Cod, Tabela, CodConfig) Values(99,'TotalConsig',1)")
                    Inserir("Insert Into Ordens (Cod, Tabela, CodConfig) Values(99,'Produto',1)")

                End If

                If ExisteTabela("Comanda") = False Then
                    ExecutaSQL("CREATE TABLE Comanda (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey38 PRIMARY KEY," & _
                    "CodOrdens INTEGER," & _
                    "CodComanda varchar (25)," & _
                    "CodProd INTEGER," & _
                    "CodProdInterno varchar (25)," & _
                    "Qtd Numeric(15,3)," & _
                    "ValorUnitario NUMERIC (15,3)," & _
                    "Data SmallDateTime," & _
                    "Status varchar (10)," & _
                    "CodConfig Integer);")
                End If

            End If
            Dim intVersao As Integer = VersaoDoSistemaBanco.Replace(".", "")
            If intVersao <= 119 Then
                Atualizar("Update Config set VersaoNano ='1.2.0'")
            End If
            If intVersao <= 120 Then
                Atualizar("Update Config set VersaoNano ='1.2.1'")
                ExecutaSQL("ALTER TABLE Config ADD Credito Varchar(18);")
            End If
            If intVersao <= 121 Then
                Atualizar("Update Config set VersaoNano ='1.2.2'")
            End If
            If intVersao <= 122 Then
                Atualizar("Update Config set VersaoNano ='1.2.3'")
                ExecutaSQL("ALTER TABLE Descarte ADD Tamanho Varchar(4);")
            End If

            If intVersao <= 123 Then
                Atualizar("Update Config set VersaoNano ='1.2.4'")

                'ExecutaSQL("Delete FROM Bloqueios")

                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Vender','Vendas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Cadastrar Cliente','Lucro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Cadastrar Fornecedor','Gráficos')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Cadastrar Produtos','Recebimentos Totais')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Gerenciar Funcionarios','Recebimentos Cartões')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Gerenciar Pagamentos','Contas Recebidas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Gerenciar Entrada de NF','Contas Pagas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Gerenciar Contas a Receber','Totais Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Gerenciar Contas a Pagar','Itens Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Gerenciar Caixa','Devolução')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Cadastrar Devolução','Consumo')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Cadastrar Descartes','Visão')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Saldo Atual Caixa','Descarte')")
            End If

            If intVersao <= 124 Then
                Atualizar("Update Config set VersaoNano ='1.2.5'")
                ExecutaSQL("ALTER TABLE Cliente ADD TempoTrabalho Varchar(25);")

            End If

            If intVersao <= 125 Then
                Atualizar("Update Config set VersaoNano ='1.2.6'")
                ExecutaSQL("ALTER TABLE Config ADD PortaImpCodBarra Varchar(70);")
                ExecutaSQL("Alter Table ContaReceber Alter Column Parcelas Varchar(5);")

            End If


            If intVersao <= 126 Then
                Atualizar("Update Config set VersaoNano ='1.2.7'")
                ExecutaSQL("ALTER TABLE Cliente ADD Moradia Varchar(25);")
            End If
            If intVersao <= 127 Then
                Atualizar("Update Config set VersaoNano ='1.2.8'")
                If ExisteTabela("OrdemTrans") = False Then
                    ExecutaSQL("CREATE TABLE OrdemTrans (" & _
                    "Codigo INTEGER," & _
                    "CodConfig Integer);")
                End If
                If ExisteTabela("Transferencia") = False Then
                    ExecutaSQL("CREATE TABLE Transferencia (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey39 PRIMARY KEY," & _
                    "CodOrdem INTEGER," & _
                    "CodLoja INTEGER," & _
                    "CodUserSaida INTEGER," & _
                    "CodProd INTEGER," & _
                    "CodUserEntrada INTEGER," & _
                    "Qtd Numeric(15,3)," & _
                    "Tamanho VARCHAR (5)," & _
                    "ValorCusto NUMERIC (15,3)," & _
                    "Data SmallDateTime," & _
                    "Status varchar (10)," & _
                    "EntSai Varchar (1)," & _
                    "Lote Varchar (20)," & _
                    "CodConfig Integer);")
                End If
                If ExisteTabela("SaldoInicio") = False Then
                    ExecutaSQL("CREATE TABLE SaldoInicio (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey41 PRIMARY KEY," & _
                    "CodProd INTEGER," & _
                    "Mes Varchar(2)," & _
                    "Qtd Numeric(15,3)," & _
                    "CodConfig Integer);")
                End If
            End If

            If intVersao <= 128 Then
                Atualizar("Update Config set VersaoNano ='1.2.9'")
                ExecutaSQL("ALTER TABLE Config ADD TemGaveta Bit;")
                Atualizar("Update Config set TemGaveta ='False' where TemGaveta is null")
                ExecutaSQL("ALTER TABLE Config ADD DescontoMaximo Varchar(18);")
                ExecutaSQL("ALTER TABLE Cliente ADD NomeConjuge Varchar(80);")
                ExecutaSQL("ALTER TABLE Cliente ADD TelConjuge Varchar(18);")

            End If
            If intVersao <= 129 Then
                Atualizar("Update Config set VersaoNano ='1.3.0'")

                ExecutaSQL("ALTER TABLE EntradaNF ADD ValProd Numeric(15,2);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD PorProd Numeric(15,2);")
            End If

            If intVersao <= 130 Then
                Atualizar("Update Config set VersaoNano ='1.3.1'")
                ExecutaSQL("ALTER TABLE ContaPagar ADD CentroCusto Varchar(80);")
                ExecutaSQL("ALTER TABLE Caixa ADD CentroCusto Varchar(80);")
            End If

            If intVersao <= 131 Then
                Atualizar("Update Config set VersaoNano ='1.3.2'")
                ExecutaSQL("ALTER TABLE Config ADD Mensalista Bit;")
                Atualizar("Update Config set Mensalista ='True' where Mensalista is null")

            End If

            If intVersao <= 132 Then
                'Correção do relatório Consumo, estava com erro no calculo da porcentagem de lucro.
                'Correção do relatório Giro1, estava com erro no saldo inicial.
                'Correção do relatório de Descarte, estava aparecendo o valor de venda quando deveria aparecer o valor de custo do produto.
                'Correção da Impressão de recibo quando o recebimento do crediário for parcial.
                'Implementação do Footer nos relatórios, cadastros e utilização do GroupPanel.
                'Implementação da Língua Portuguesa nos componentes da DeveXpress.

                Atualizar("Update Config set VersaoNano ='1.3.3'")
                ' '' '' ''Atualizar("Update Descarte set ValorUnitario = Produto.ValorCusto from Produto where Produto.Codigo = Descarte.CodProd")
            End If

            If intVersao <= 133 Then
                'Correção do relatório Vendas e Lucro, estava com erro no calculo do valor de custo na hora da venda.

                Atualizar("Update Config set VersaoNano ='1.3.4'")
                ' '' '' '' Atualizar("Update Pedido set Custo = (Produto.ValorCusto * Pedido.Qtd) From Pedido Left Join Produto On Pedido.CodProd = Produto.Codigo where Pedido.Qtd > 1 and Pedido.CodConfig = 1")
                ' '' '' ''Atualizar("Update Pedido set Custo = ValorUnitario / 2 where Custo is null")
               
            End If

            If intVersao <= 134 Then
                Atualizar("Update Config set VersaoNano ='1.3.5'")
                ' '' '' ''ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Excluir Venda','')")
                ' '' '' ''Atualizar("Update Usuario set Principal = Principal + '15|' where Nivel ='USUÁRIO'")

            End If

            If intVersao <= 135 Then
                Atualizar("Update Config set VersaoNano ='1.3.6'")
                ExecutaSQL("Alter Table Pedido Alter Column Produto Varchar(100);")
            End If

            If intVersao <= 136 Then
                Atualizar("Update Config set VersaoNano ='1.3.7'")
                ExecutaSQL("Alter Table Cliente Alter Column RGIE Varchar(20);")
                ExecutaSQL("Alter Table Fornecedor Alter Column IE Varchar(20);")
            End If

            If intVersao <= 137 Then
                Atualizar("Update Config set VersaoNano ='1.3.8'")


                ExecutaSQL("ALTER TABLE Cliente ADD Suframa varchar(9);")
                ExecutaSQL("ALTER TABLE Cliente ADD CodMunicipio varchar(7);")
                ExecutaSQL("ALTER TABLE Cliente ADD CodPais varchar(4);")
                ExecutaSQL("ALTER TABLE Cliente ADD NomePais varchar(60);")


                If ExisteTabela("Pais") = False Then
                    ExecutaSQL("CREATE TABLE Pais (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey45 PRIMARY KEY," & _
                    "Nome VARCHAR (50)," & _
                    "Sigla VARCHAR (2)," & _
                    "CodIBGE varchar(4));")
                End If
                ExecutaSQL("ALTER TABLE Cidade ADD CodIBGE varchar(7);")

                ExecutaSQL("ALTER TABLE Config ADD UsaNfe Bit;")
                Atualizar("UPDATE Config SET UsaNfe = 'False' where UsaNfe is null")
                ExecutaSQL("ALTER TABLE Config Add CaminhoPastaNfe varchar(150);")
                If ExisteTabela("Nfe") = False Then
                    ExecutaSQL("CREATE TABLE Nfe (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey44 PRIMARY KEY," & _
                    "CodProd INTEGER," & _
                    "EXTIPI VARCHAR (3)," & _
                    "Genero Varchar (2)," & _
                    "UnidTrib VARCHAR (6)," & _
                    "ValTrib VARCHAR (16)," & _
                    "QtdTrib VARCHAR (12)," & _
                    "MIPI VARCHAR (1)," & _
                    "QtdN VARCHAR (12)," & _
                    "CST VARCHAR (3)," & _
                    "Origem VARCHAR (1)," & _
                    "ModBC Varchar (1)," & _
                    "ICMS VARCHAR (10)," & _
                    "RedBC VARCHAR (10)," & _
                    "ModBCST VARCHAR (1)," & _
                    "RedBCST VARCHAR (10)," & _
                    "MVaST Varchar (10)," & _
                    "ICMSST varchar(10)," & _
                    "NCM varchar(8)," & _
                    "Regime varchar(30)," & _
                    "CalculoCred varchar(10)," & _
                    "UnidCom VARCHAR (6)," & _
                    "ValCom VARCHAR (16)," & _
                    "CFOP varchar(4));")
                End If


                Atualizar("Update Cliente set CodPais = '1058', NomePais = 'BRASIL'")
            End If
            If intVersao <= 138 Then
                Atualizar("Update Config set VersaoNano ='1.3.9'")


                ExecutaSQL("ALTER TABLE EntradaNF ADD Setor varchar(80);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD Grupo varchar(80);")


                ExecutaSQL("ALTER TABLE Produto ADD CodProdFor varchar(20);")

            End If

            If intVersao <= 139 Then
                Atualizar("Update Config set VersaoNano ='1.4.0'")

            End If


            If intVersao <= 140 Then
                Atualizar("Update Config set VersaoNano ='1.4.1'")
                ExecutaSQL("ALTER TABLE Config ADD ImpostoPorItem Bit;")
                Atualizar("Update Config set ImpostoPorItem ='False' where ImpostoPorItem is null")

                ExecutaSQL("ALTER TABLE Config ADD ImportarNfe Bit;")
                Atualizar("Update Config set ImportarNfe ='False' where ImportarNfe is null")
                ExecutaSQL("ALTER TABLE Config ADD CaminhoPastaNotaNfe Varchar (150);")

                If ExisteTabela("Tributos") = False Then
                    ExecutaSQL("CREATE TABLE Tributos (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey46 PRIMARY KEY," & _
                    "CodProd Integer," & _
                    "CSTIPI VARCHAR (2)," & _
                    "PerIPI VARCHAR (18)," & _
                    "CodEnq Varchar (5)," & _
                    "CSTPIS VARCHAR (2)," & _
                    "PerPIS Varchar (18)," & _
                    "CSTCOFINS Varchar(2)," & _
                    "PerCOFINS Varchar(18));")
                End If
              

                If ExisteTabela("ConfigNfe") = False Then
                    ExecutaSQL("CREATE TABLE ConfigNfe (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey47 PRIMARY KEY," & _
                    "Razao varchar(150)," & _
                    "Fantasia VARCHAR (150)," & _
                    "CNPJ Varchar (20)," & _
                    "IE VARCHAR (20)," & _
                    "Endereco VARCHAR (150)," & _
                    "Bairro VARCHAR (100)," & _
                    "Numero VARCHAR (10)," & _
                    "Cidade VARCHAR (80)," & _
                    "CodMun VARCHAR (10)," & _
                    "Cep VARCHAR (12)," & _
                    "UF Varchar (2)," & _
                    "CodUF VARCHAR (2)," & _
                    "Pais VARCHAR (50)," & _
                    "CodPais VARCHAR (10)," & _
                    "CRT VARCHAR (10)," & _
                    "Telefone Varchar (15)," & _
                    "NatOp varchar(30)," & _
                    "Mod varchar(5)," & _
                    "Serie varchar(3)," & _
                    "TipoNF varchar(1)," & _
                    "TipoImp VARCHAR (1)," & _
                    "TipoEmi VARCHAR (1)," & _
                    "TipoAmb varchar(1)," & _
                    "FinNfe VARCHAR (1)," & _
                    "ProcEmi VARCHAR (1)," & _
                    "VerProc varchar(20)," & _
                    "ModFrete Varchar(1));")
                End If

                If ExisteTabela("TotalNfe") = False Then
                    ExecutaSQL("CREATE TABLE TotalNfe (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey48 PRIMARY KEY," & _
                    "CodOrdem Integer," & _
                    "CodNF VARCHAR (10)," & _
                    "NumNF Varchar (10)," & _
                    "Chave Varchar (44)," & _
                    "IndPag VARCHAR (10)," & _
                    "DEmi SmallDateTime," & _
                    "DEntSai SmallDateTime," & _
                    "HEntSai VARCHAR (8)," & _
                    "DCont varchar (15)," & _
                    "HCont Varchar (10)," & _
                    "JustCont Varchar(max)," & _
                    "CDV VARCHAR (2)," & _
                    "CodCli Integer," & _
                    "VBC NUMERIC (15,2)," & _
                    "VICMS NUMERIC (15,2)," & _
                    "VBCST NUMERIC (15,2)," & _
                    "VST NUMERIC (15,2)," & _
                    "VProd NUMERIC (15,2)," & _
                    "VFrete NUMERIC (15,2)," & _
                    "VSeg NUMERIC (15,2)," & _
                    "VDesc NUMERIC (15,2)," & _
                    "VII NUMERIC (15,2)," & _
                    "VIPI NUMERIC (15,2)," & _
                    "VPIS NUMERIC (15,2)," & _
                    "VCOFINS NUMERIC (15,2)," & _
                    "VOutro NUMERIC (15,2)," & _
                    "VNF NUMERIC (15,2)," & _
                    "NatOp varchar(30)," & _
                    "TipoNF varchar(1)," & _
                    "TipoImp VARCHAR (1)," & _
                    "TipoEmi VARCHAR (1)," & _
                    "TipoAmb varchar(1)," & _
                    "FinNfe VARCHAR (1)," & _
                    "ProcEmi VARCHAR (1)," & _
                    "VerProc varchar(20)," & _
                    "ModFrete Varchar(1));")
                End If

                If ExisteTabela("ItensNfe") = False Then
                    ExecutaSQL("CREATE TABLE ItensNfe (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey49 PRIMARY KEY," & _
                    "CodOrdem Integer," & _
                    "CodProd Integer," & _
                    "CodInterno Varchar (20)," & _
                    "CodBarra VARCHAR (25)," & _
                    "Produto VARCHAR (100)," & _
                    "NCM VARCHAR (8)," & _
                    "CFOP VARCHAR (4)," & _
                    "EXTIPI VArchar (3)," & _
                    "UCom VARCHAR (5)," & _
                    "QCom Numeric(12,4)," & _
                    "VUnCom Numeric (12,4)," & _
                    "VProd Numeric(15,2)," & _
                    "Origem VARCHAR (1)," & _
                    "CSTICMS VARCHAR (3)," & _
                    "ModBC VARCHAR (1)," & _
                    "VBCICMS Varchar (18)," & _
                    "RedBC varchar(10)," & _
                    "ICMS Varchar(18)," & _
                    "ValICMS varchar(18)," & _
                    "ModBCST varchar(1)," & _
                    "RedBCST VARCHAR (10)," & _
                    "VBCST VARCHAR (18)," & _
                    "ICMSST varchar(18)," & _
                    "ValICMSST VARCHAR (18)," & _
                    "MVaST VARCHAR (18)," & _
                    "CalcCred varchar(18)," & _
                    "CodEnq Varchar(5)," & _
                    "CSTIPI Varchar(2)," & _
                    "VBCIPI Varchar(18)," & _
                    "PerIPI Varchar (18)," & _
                    "ValIPI varchar(18)," & _
                    "CSTPIS Varchar(3)," & _
                    "VBCPIS varchar(18)," & _
                    "PerPIS varchar(18)," & _
                    "ValPIS VARCHAR (18)," & _
                    "CSTCOFINS VARCHAR (3)," & _
                    "VCBCOFINS varchar(18)," & _
                    "PerCOFINS VARCHAR (18)," & _
                    "ValCOFINS Varchar(18)," & _
                    "VCalcCred Varchar(18));")
                End If

            End If

            If intVersao <= 141 Then
                Atualizar("Update Config set VersaoNano ='1.4.2'")

                ExecutaSQL("ALTER TABLE EntradaNF ADD MVaST Varchar (18);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD PorICMS Varchar (18);")

            End If

            'CORRIGI OS TAMANHOS DOS CAMPOS EVITANDO ASSIM FUTUROS ERROS
            If intVersao <= 142 Then
                Atualizar("Update Config set VersaoNano ='1.4.3'")

                ExecutaSQL("Alter Table Caixa Alter Column Motivo Varchar(255);")
                ExecutaSQL("Alter Table Cliente Alter Column Cidade Varchar(50);")
                ExecutaSQL("Alter Table Comanda Alter Column CodProdInterno Varchar(50);")
                ExecutaSQL("Alter Table Fornecedor Alter Column Cidade Varchar(50);")
                ExecutaSQL("Alter Table ItensNFE Alter Column CodInterno Varchar(50);")
                ExecutaSQL("Alter Table Funcionario Alter Column Cidade Varchar(50);")
                ExecutaSQL("Alter Table Fornecedor Alter Column Cidade Varchar(50);")
                ExecutaSQL("Alter Table Pedido Alter Column CodProdInterno Varchar(50);")
                ExecutaSQL("Alter Table Produto Alter Column Fabricante Varchar(150);")
                ExecutaSQL("Alter Table Comanda Alter Column CodProdInterno Varchar(50);")
                ExecutaSQL("Alter Table Receita Alter Column CodigoInterno Varchar(50);")
                ExecutaSQL("Alter Table Receita Alter Column Nome Varchar(100);")
                ExecutaSQL("Drop Table SaldoInicio;")

            End If

            If intVersao <= 143 Then
                Atualizar("Update Config set VersaoNano ='1.4.4'")

                If ExisteTabela("RefNfe") = False Then
                    ExecutaSQL("CREATE TABLE RefNfe (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey50 PRIMARY KEY," & _
                    "CodOrdem Integer," & _
                    "Tipo VARCHAR (20)," & _
                    "Chave VARCHAR (50)," & _
                    "UF Varchar (2)," & _
                    "Emissao VARCHAR (5)," & _
                    "CNPJ Varchar (18)," & _
                    "Modelo Varchar(2)," & _
                    "Serie Varchar(3)," & _
                    "Numero Varchar(9));")
                End If

                ExecutaSQL("ALTER TABLE Fornecedor ADD Tipo Varchar (1);")
                Atualizar("Update Fornecedor set Tipo ='F' where Tipo is null")
                ExecutaSQL("ALTER TABLE Fornecedor ADD CodMunicipio varchar(7);")
                ExecutaSQL("ALTER TABLE Fornecedor ADD CodPais varchar(4);")
                ExecutaSQL("ALTER TABLE Fornecedor ADD NomePais varchar(60);")
                Atualizar("Update Fornecedor set CodPais = '1058', NomePais = 'BRASIL'")

                If ExisteTabela("VolumeNfe") = False Then
                    ExecutaSQL("CREATE TABLE VolumeNfe (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey51 PRIMARY KEY," & _
                    "CodOrdem Integer," & _
                    "Qtde VARCHAR (8)," & _
                    "Especie VARCHAR (60)," & _
                    "Marca Varchar (60)," & _
                    "Numero VARCHAR (60)," & _
                    "PesoLiq Varchar (18)," & _
                    "PesoBruto Varchar(18));")
                End If

                ExecutaSQL("ALTER TABLE TotalNfe ADD ObsFisco Varchar (MAX);")
                ExecutaSQL("ALTER TABLE TotalNfe ADD ObsCont Varchar (MAX);")
                ExecutaSQL("ALTER TABLE TotalNfe ADD CodForn integer;")
                ExecutaSQL("ALTER TABLE TotalNfe ADD Placa Varchar (7);")
                ExecutaSQL("ALTER TABLE TotalNfe ADD UFVei Varchar (2);")
                ExecutaSQL("ALTER TABLE TotalNfe ADD RNTC Varchar (20);")
                ExecutaSQL("ALTER TABLE TotalNfe ADD NomeTrans Varchar(150);")
                ExecutaSQL("ALTER TABLE TotalNfe ADD CNPJTrans Varchar(18);")
                ExecutaSQL("ALTER TABLE TotalNfe ADD IETrans varchar(20);")
                ExecutaSQL("ALTER TABLE TotalNfe ADD EndTrans Varchar(150);")
                ExecutaSQL("ALTER TABLE TotalNfe ADD BairroTrans varchar(80);")
                ExecutaSQL("ALTER TABLE TotalNfe ADD NumTrans Varchar(10);")
                ExecutaSQL("ALTER TABLE TotalNfe ADD UFTrans Varchar(2);")
                ExecutaSQL("ALTER TABLE TotalNfe ADD CidadeTrans Varchar(50);")
                ExecutaSQL("ALTER TABLE TotalNfe ADD CodVenda Varchar(20);")
                ExecutaSQL("ALTER TABLE TotalNfe ADD Serie Varchar(3);")

                ExecutaSQL("ALTER TABLE ConfigNfe ADD ObsCont Varchar(MAX);")
            End If

            If intVersao <= 144 Then
                Atualizar("Update Config set VersaoNano ='1.4.5'")

                ExecutaSQL("ALTER TABLE Config ADD SegViaRecibo Bit;")
                Atualizar("Update Config set SegViaRecibo ='False' where SegViaRecibo is null")
            End If

            If intVersao <= 145 Then
                Atualizar("Update Config set VersaoNano ='1.4.6'")

                ExecutaSQL("ALTER TABLE TotalNfe ADD NumFatura Varchar (60);")
                ExecutaSQL("ALTER TABLE TotalNfe ADD ValOrigFatura varchar(18);")
                ExecutaSQL("ALTER TABLE TotalNfe ADD ValDescFatura varchar(18);")
                ExecutaSQL("ALTER TABLE TotalNfe ADD ValLiqFatura varchar(18);")

                If ExisteTabela("DuplicataNfe") = False Then
                    ExecutaSQL("CREATE TABLE DuplicataNfe (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey52 PRIMARY KEY," & _
                    "CodOrdem Integer," & _
                    "Numero VARCHAR (60)," & _
                    "Data SmallDateTime," & _
                    "Valor Varchar (18));")
                End If

                If ExisteTabela("Cce") = False Then
                    ExecutaSQL("CREATE TABLE Cce (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey53 PRIMARY KEY," & _
                    "CodOrdem Integer," & _
                    "Versao VARCHAR (4)," & _
                    "Id VARCHAR (60)," & _
                    "CUF Varchar (2)," & _
                    "TipoAmb VARCHAR (1)," & _
                    "Chave Varchar (44)," & _
                    "DEmi SmallDateTime," & _
                    "HEmi Varchar (8)," & _
                    "TZD varchar (5)," & _
                    "TipoEvento Varchar (6)," & _
                    "NumSeqEvento Varchar (3)," & _
                    "CNPJ Varchar (20)," & _
                    "DescEvento Varchar (60)," & _
                    "Correcao Varchar (MAX)," & _
                    "CondUso Varchar (MAX));")
                End If


                ExecutaSQL("ALTER TABLE ConfigNfe ADD VersaoCce Varchar(4);")
                ExecutaSQL("ALTER TABLE ConfigNfe ADD TZDCce Varchar(5);")
                ExecutaSQL("ALTER TABLE ConfigNfe ADD TipoEventoCce Varchar(6);")
                ExecutaSQL("ALTER TABLE ConfigNfe ADD DescEventoCce Varchar(60);")
                ExecutaSQL("ALTER TABLE ConfigNfe ADD CondUsoCce Varchar(MAX);")
                ExecutaSQL("ALTER TABLE ConfigNfe ADD TipoAmbCce Varchar(1);")


                If ExisteTabela("NatOpe") = False Then
                    ExecutaSQL("CREATE TABLE NatOpe (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey54 PRIMARY KEY," & _
                    "Descricao Varchar(60));")

                    ExecutaSQL("Insert Into NatOpe (Descricao) Values('VENDA')")
                    ExecutaSQL("Insert Into NatOpe (Descricao) Values('DEVOLUÇÃO')")

                End If
            End If

            If intVersao <= 146 Then
                Atualizar("Update Config set VersaoNano ='1.4.7'")

                'ExecutaSQL("Delete FROM Bloqueios")

                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Vender','Vendas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Cadastrar Cliente','Lucro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Cadastrar Fornecedor','Gráficos')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Cadastrar Produtos','Recebimentos Totais')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Gerenciar Funcionarios','Recebimentos Cartões')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Gerenciar Pagamentos','Contas Recebidas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Gerenciar Entrada de NF','Contas Pagas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Gerenciar Contas a Receber','Totais Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Gerenciar Contas a Pagar','Itens Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Gerenciar Caixa','Devolução')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Cadastrar Devolução','Consumo')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Cadastrar Descartes','Visão')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Saldo Atual Caixa','Descarte')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Gerenciar Pedidos','Giro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Banco','Inadimplência')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Gerenciar NF-e','NF-e')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values('Cadastrar Transportadora','Transferência')")
            End If

            If intVersao <= 147 Then
                Atualizar("Update Config set VersaoNano ='1.4.8'")

                ExecutaSQL("ALTER TABLE Qtde ADD DataFim SmallDateTime;")
                ' '' '' ''Atualizar("Update Qtde set DataFim ='01/01/1900'")

                ExecutaSQL("ALTER TABLE Total ADD Hora Varchar (5);")
                ' '' '' ''Atualizar("Update Total set Hora ='00:00'")

                ExecutaSQL("ALTER TABLE TotalNfe ADD Desconto Varchar (30);")

            End If

            If intVersao <= 148 Then
                Atualizar("Update Config set VersaoNano ='1.4.9'")
                ExecutaSQL("ALTER TABLE Config ADD BaixaPorLote Bit;")
                Atualizar("Update Config set BaixaPorLote ='True' where BaixaPorLote is null")
            End If

            If intVersao <= 149 Then

                Atualizar("Update Config set VersaoNano ='1.5.0'")
                ExecutaSQL("Alter Table Config Add CaminhoPastaXML Varchar(100);")
                ExecutaSQL("Alter Table Config Add CaminhoPastaPDF Varchar(100);")

                If ExisteTabela("Email") = False Then
                    ExecutaSQL("CREATE TABLE Email (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey55 PRIMARY KEY," & _
                    "Servidor VARCHAR (200)," & _
                    "Email VARCHAR (200)," & _
                    "Senha VARCHAR (15));")

                    ExecutaSQL("Insert Into Email (Servidor, Email, Senha) Values('Servidor','E-Mail','1234')")
                End If

            End If


            If intVersao <= 150 Then
                Atualizar("Update Config set VersaoNano ='1.5.1'")
                ' '' '' ''Atualizar("Update Bloqueios set Principal = 'Excluir Venda' where Principal ='Cadastrar Transportadora'")
            End If

            If intVersao <= 151 Then
                Atualizar("Update Config set VersaoNano ='1.5.2'")
                ExecutaSQL("Alter Table ImpostoProduto Alter Column Cst Varchar(4);")
            End If
            If intVersao <= 152 Then
                Atualizar("Update Config set VersaoNano ='1.5.3'")
            End If

            If intVersao <= 153 Then
                Atualizar("Update Config set VersaoNano ='1.5.4'")
            End If

            If intVersao <= 154 Then
                Atualizar("Update Config set VersaoNano ='1.5.5'")
                ExecutaSQL("Alter Table Pagamento ADD CodBanco Integer;")
                ExecutaSQL("Alter Table Futuro ADD Recebido Bit;")
                ' '' '' ''Atualizar("Update Futuro set Recebido ='True'")
                ' '' '' '' ExecutaSQL("Insert Into Bloqueios(Principal, Relatorios) Values('','Fluxo Caixa')")
            End If


            If intVersao <= 155 Then
                Atualizar("Update Config set VersaoNano ='1.5.6'")

                If ExisteTabela("Operador") = False Then
                    ExecutaSQL("CREATE TABLE Operador (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey56 PRIMARY KEY," & _
                    "Operador VARCHAR (200)," & _
                    "Tipo VARCHAR (20)," & _
                    "Entrada NUMERIC (15,2)," & _
                    "Data SmallDateTime," & _
                    "CodConfig INTEGER);")
                End If

                ExecutaSQL("Alter Table Total Add StatusDAV Varchar(20);")
                ExecutaSQL("Alter Table Total Add NumDAV Varchar(20);")
                ' '' '' '' Atualizar("UPDATE Total SET NumDav = '0'")

                If ExisteTabela("ConfigECF") = False Then
                    ExecutaSQL("CREATE TABLE ConfigECF (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey57 PRIMARY KEY," & _
                    "CNPJ VARCHAR (20)," & _
                    "IE VARCHAR (20)," & _
                    "Cliche VARCHAR (MAX)," & _
                    "Tipo VARCHAR (10)," & _
                    "Modelo VARCHAR (20)," & _
                    "Marca VARCHAR (20)," & _
                    "NumeroSerie VARCHAR (20)," & _
                    "NumeroECF VARCHAR (20)," & _
                    "VersaoSB VARCHAR (20)," & _
                    "DataSB VARCHAR (20)," & _
                    "MFAdicional VARCHAR (20)," & _
                    "ChavePublica VARCHAR (MAX)," & _
                    "ChavePrivada VARCHAR (MAX)," & _
                    "CodigoEquipamento VARCHAR (20)," & _
                    "CodConfig INTEGER);")
                End If
                'Inserir("INSERT INTO ConfigECF (ChavePublica, CodConfig)VALUES('',1)")

                If ExisteTabela("R2") = False Then
                    ExecutaSQL("CREATE TABLE R2 (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey58 PRIMARY KEY," & _
                    "CodUser Integer," & _
                    "CRZ VARCHAR (10)," & _
                    "COO VARCHAR (10)," & _
                    "CRO VARCHAR (10)," & _
                    "DataMovimentacao SmallDateTime," & _
                    "DataEmissao SmallDateTime," & _
                    "HoraEmissao VARCHAR (10)," & _
                    "VendaBruta Numeric (15,2)," & _
                    "CodConfig INTEGER);")
                End If

                If ExisteTabela("R3") = False Then
                    ExecutaSQL("CREATE TABLE R3 (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey59 PRIMARY KEY," & _
                    "CodR2 Integer," & _
                    "TotalizadorParcial VARCHAR (10)," & _
                    "ValorAcumulado Numeric(15,2)," & _
                    "CodConfig INTEGER);")
                End If

                If ExisteTabela("R4") = False Then
                    ExecutaSQL("CREATE TABLE R4 (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey60 PRIMARY KEY," & _
                    "CodOrdem Integer," & _
                    "CodUser Integer," & _
                    "CCF VARCHAR (10)," & _
                    "COO VARCHAR (10)," & _
                    "DataEmissao SmallDateTime," & _
                    "Cancelado char(1)," & _
                    "CodConfig INTEGER);")
                End If

                If ExisteTabela("R6") = False Then
                    ExecutaSQL("CREATE TABLE R6 (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey62 PRIMARY KEY," & _
                    "CodUser Integer," & _
                    "GNF Varchar (10)," & _
                    "COO VARCHAR (10)," & _
                    "GRG Varchar (10)," & _
                    "CDC Varchar (10)," & _
                    "Denominacao Char(2)," & _
                    "Data SmallDateTime," & _
                    "Hora Varchar (10)," & _
                    "CodConfig INTEGER);")
                End If

                If ExisteTabela("R7") = False Then
                    ExecutaSQL("CREATE TABLE R7 (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey61 PRIMARY KEY," & _
                    "CodUser Integer," & _
                    "COO Varchar(10)," & _
                    "CCF Varchar(10)," & _
                    "GNF Varchar(10)," & _
                    "Pagamento VARCHAR (20)," & _
                    "ValorPago Numeric (15,2)," & _
                    "Estorno char(1)," & _
                    "ValorEstorno Numeric(15,2)," & _
                    "DataEmissao SmallDateTime," & _
                    "CodConfig INTEGER);")
                End If
            End If


            If intVersao <= 156 Then
                Try
                    Dim strDestino As String = "C:\NANO\Backup" & Format(Date.Today, "dd-MM-yyyy") & ".bak"
                    BackupSql("backup database " & NomeDoBancoSql & " to disk = '" & strDestino & "'", True)

                Catch ex As Exception

                End Try
              
                Atualizar("Update Config set VersaoNano ='1.5.7'")

                ExecutaSQL("Alter Table Config ADD PafEcfNano bit;")

                Atualizar("Update Config set PafEcfNano ='False' where PafEcfNano is null")

            End If

            If intVersao <= 157 Then
                Atualizar("Update Config set VersaoNano ='1.5.8'")
            End If

            If intVersao <= 158 Then
                Atualizar("Update Config set VersaoNano ='1.5.9'")
                ExecutaSQL("Alter Table Grupo ADD PortaImpressora Varchar(80);")
                ExecutaSQL("Alter Table Comanda ADD Produto Varchar(100);")
                ExecutaSQL("Alter Table Comanda ADD Misto Bit;")
                ExecutaSQL("Alter Table Comanda ADD CodFunc Integer;")
                ExecutaSQL("Alter Table Comanda ADD CodCli Integer;")
                ExecutaSQL("Alter Table Comanda ADD Tipo Varchar(10);")
                ExecutaSQL("Alter Table Pedido Alter Column UM Varchar(6);")
            End If


            If intVersao <= 159 Then
                Atualizar("Update Config set VersaoNano ='1.6.0'")
            End If


            If intVersao <= 160 Then
                Atualizar("Update Config set VersaoNano ='1.6.1'")

                ExecutaSQL("Alter Table ItensReceita ADD TipoValor Varchar(10);")
                Atualizar("Update ItensReceita set TipoValor ='Custo' where TipoValor is null")

                ExecutaSQL("Alter Table EntradaNF ADD TipoProduto Varchar(10);")

                ExecutaSQL("Alter Table Config ADD ZeroCodProd bit;")
                Atualizar("Update Config set ZeroCodProd ='True' where ZeroCodProd is null")

                ExecutaSQL("ALTER TABLE Config ADD ValorAproximado Bit;")
                Atualizar("Update Config set ValorAproximado ='False' where ValorAproximado is null")

                ExecutaSQL("ALTER TABLE ItensNfe ADD ValAprox Varchar(18);")
                ExecutaSQL("ALTER TABLE Produto ADD Inativo Bit;")
                Atualizar("Update Produto set Inativo ='False' where Inativo is null")
                ExecutaSQL("ALTER TABLE ImpostoProduto ADD NCM varchar(10);")

                If ExisteTabela("TabelaIBPT") = False Then
                    ExecutaSQL("CREATE TABLE TabelaIBPT (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey63 PRIMARY KEY," & _
                    "NCM Varchar(10)," & _
                    "Ex Varchar (3)," & _
                    "Tipo Varchar (1)," & _
                    "AliqNac Numeric (15,2)," & _
                    "AliqImp Numeric (15,2));")
                End If
            End If

            If intVersao <= 161 Then

                Atualizar("Update Config set VersaoNano ='1.6.2'")

                If ExisteTabela("ProdOpc") = False Then
                    ExecutaSQL("CREATE TABLE ProdOpc (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey64 PRIMARY KEY," & _
                    "Produto VARCHAR (50)," & _
                    "Valor Numeric (15,2)," & _
                    "Tipo VARCHAR(30));")
                End If
            End If

            If intVersao <= 162 Then
                Atualizar("Update Config set VersaoNano ='1.6.3'")
                ExecutaSQL("ALTER TABLE Comanda ADD Opcoes NVARCHAR(MAX);")
                ExecutaSQL("ALTER TABLE Comanda ADD Obs NVARCHAR(MAX);")
            End If

            If intVersao <= 163 Then
                Atualizar("Update Config set VersaoNano ='1.6.4'")
            End If

            If intVersao <= 164 Then
                Atualizar("Update Config set VersaoNano ='1.6.5'")
                ExecutaSQL("ALTER TABLE Comanda ADD Entregador VARCHAR(100);")
                ExecutaSQL("ALTER TABLE Comanda ADD Troco Numeric(15,3);")
                ExecutaSQL("ALTER TABLE Comanda ADD Tempo VARCHAR(20);")
            End If

            If intVersao <= 165 Then
                Atualizar("Update Config set VersaoNano ='1.6.6'")
                ExecutaSQL("ALTER TABLE ConfigECF ADD Impressora VARCHAR(20);")
                Atualizar("Update ConfigECF set Impressora ='BEMATECH' where Impressora is null")
                ExecutaSQL("ALTER TABLE ConfigECF ADD Computador VARCHAR(50);")
                ExecutaSQL("ALTER TABLE Operador ADD CodConfigECF Integer;")
                ExecutaSQL("ALTER TABLE R2 ADD CodConfigECF Integer;")
                ExecutaSQL("ALTER TABLE R3 ADD CodConfigECF Integer;")
                ExecutaSQL("ALTER TABLE R4 ADD CodConfigECF Integer;")
                ExecutaSQL("ALTER TABLE R6 ADD CodConfigECF Integer;")
                ExecutaSQL("ALTER TABLE R7 ADD CodConfigECF Integer;")

                ExecutaSQL("ALTER TABLE ContaReceber ADD CodLojaBaixa Integer;")
            End If

            If intVersao <= 166 Then
                Atualizar("Update Config set VersaoNano ='1.6.7'")
                ExecutaSQL("ALTER TABLE Total ADD NFP bit;")
                Atualizar("Update Total set NFP ='False' where NFP is null")
            End If

            If intVersao <= 167 Then
                Atualizar("Update Config set VersaoNano ='1.6.8'")
                ExecutaSQL("ALTER TABLE Total ADD CPFCliente VARCHAR(25);")
            End If

            If intVersao <= 168 Then
                Atualizar("Update Config set VersaoNano ='1.6.9'")
            End If

            If intVersao <= 169 Then
                Atualizar("Update Config set VersaoNano ='1.7.0'")
            End If

            If intVersao <= 170 Then
                'Conta Receber quando altera uma conta e logo depois altera outra da erro
                'Conta Receber quando coloca a opção CAIXA no banco inseri troco 0,00 no caixa
                Atualizar("Update Config set VersaoNano ='1.7.1'")
            End If

            If intVersao <= 171 Then
                'Ao cancelar o cupom da mensagem de cupom aberto 
                Atualizar("Update Config set VersaoNano ='1.7.2'")
            End If

            If intVersao <= 172 Then
                'Dav com itens
                'Cancelar na tela Dav
                'verificar produto sem codigo
                'tirar filtro na grid qtd sem lote
                Atualizar("Update Config set VersaoNano ='1.7.3'")
            End If

            If intVersao <= 173 Then
                'Venda com cliente inativo pelo cpf
                'Nao salvar produto com os campos vazios referente a nfe e cupom 

                Atualizar("Update Config set VersaoNano ='1.7.4'")
                Atualizar("Update Cliente set Inativo = 'False' where Inativo is null")

            End If

            If intVersao <= 174 Then
                'Promoçao no pedido tambem
                'Filtro nos itens do pedido
                'Promissoria no pedido

                Atualizar("Update Config set VersaoNano ='1.7.5'")

            End If

            If intVersao <= 175 Then
                'Excluir Varios itens no pedido
                'Excluir Notas fiscais eletronicas de teste
                'Erro leave codigo interno produto
                'Colocar colunas de aliquota no pesquisa tributos
                'ncm nfe e cupom igual
                'transferencia dar mensagem se nao tiver quantidade
                'balanca por qtd ou por valor

                Atualizar("Update Config set VersaoNano ='1.7.6'")

                ExecutaSQL("ALTER TABLE Config ADD BalancaPor VARCHAR(20);")
                Atualizar("Update Config set BalancaPor ='QTDE' where BalancaPor is null")

            End If

            If intVersao <= 176 Then
                'Erro calculo com desconto na venda com cupom fiscal
                'Erro troca cupom fiscal

                Atualizar("Update Config set VersaoNano ='1.7.7'")
                ExecutaSQL("ALTER TABLE Config ADD AltPrecoPedido bit;")
                Atualizar("Update Config set AltPrecoPedido = 'False' where AltPrecoPedido is null")
                ExecutaSQL("ALTER TABLE Config ADD DescricaoPedido VARCHAR(MAX);")

            End If

            If intVersao <= 177 Then
                'Qtd Loja
                Atualizar("Update Config set VersaoNano ='1.7.8'")
            End If

            If intVersao <= 178 Then
                Atualizar("Update Config set VersaoNano ='1.7.9'")

                If ExisteTabela("Ativo") = False Then
                    ExecutaSQL("CREATE TABLE Ativo (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey65 PRIMARY KEY," & _
                    "Nome VARCHAR (100)," & _
                    "Valor Numeric (15,2)," & _
                    "CodPadrao VARCHAR(10));")
                End If

                If ExisteTabela("AtivoConsig") = False Then
                    ExecutaSQL("CREATE TABLE AtivoConsig (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey66 PRIMARY KEY," & _
                    "CodOrdens Integer," & _
                    "Nome VARCHAR (100)," & _
                    "Valor Numeric (15,2)," & _
                    "CodAtivo Integer," & _
                    "CodPadrao VARCHAR(10)," & _
                    "CodConfig Integer," & _
                    "Vencimento SmallDateTime," & _
                    "CodPedAut Integer," & _
                    "Status Varchar(15));")
                End If

                If ExisteTabela("Cheque") = False Then
                    ExecutaSQL("CREATE TABLE Cheque (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey67 PRIMARY KEY," & _
                    "CodPed VARCHAR (10)," & _
                    "Cliente VARCHAR (150)," & _
                    "Valor NUMERIC (15,3)," & _
                    "Vencimento SmallDateTime," & _
                    "Data SmallDateTime," & _
                    "Documento VARCHAR (150)," & _
                    "Banco VARCHAR (100)," & _
                    "Quem VARCHAR (150)," & _
                    "RecebidoOK Bit," & _
                    "Recebimento SmallDateTime," & _
                    "CodConfig Integer);")
                End If
        
            End If
            If intVersao <= 179 Then

                Atualizar("Update Config set VersaoNano ='1.8.0'")

            End If

            If intVersao <= 180 Then

                Atualizar("Update Config set VersaoNano ='1.8.1'")
                ExecutaSQL("ALTER TABLE Config ADD AltNomePedido bit;")
                Atualizar("Update Config set AltNomePedido = 'False' where AltNomePedido is null")

                ExecutaSQL("Alter Table Pedido Alter Column Produto Varchar(150);")
            End If

            If intVersao <= 181 Then

                Atualizar("Update Config set VersaoNano ='1.8.2'")
                ExecutaSQL("ALTER TABLE Config ADD TrocoCaixa bit;")
                Atualizar("Update Config set TrocoCaixa = 'False' where TrocoCaixa is null")

            End If


            If intVersao <= 182 Then

                Atualizar("Update Config set VersaoNano ='1.8.3'")

            End If


            If intVersao <= 183 Then

                Atualizar("Update Config set VersaoNano ='1.8.4'")

                If ExisteTabela("Inventario") = False Then
                    ExecutaSQL("CREATE TABLE Inventario (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey68 PRIMARY KEY," & _
                    "CodProd Integer," & _
                    "CodConfig Integer," & _
                    "Qtd Numeric(15,3)," & _
                    "QtdAntiga Numeric(15,3)," & _
                    "ValorCusto Numeric(15,2)," & _
                    "Tamanho VARCHAR(10)," & _
                    "Status VARCHAR(10)," & _
                    "Data SmallDateTime);")
                End If


            End If


            If intVersao <= 184 Then

                Atualizar("Update Config set VersaoNano ='1.8.5'")

            End If

            If intVersao <= 185 Then

                Atualizar("Update Config set VersaoNano ='1.8.6'")
                ExecutaSQL("ALTER TABLE Config ADD PedidoCompleto bit;")
                Atualizar("Update Config set PedidoCompleto = 'False' where PedidoCompleto is null")
                ExecutaSQL("ALTER TABLE Config ADD OcultarAutorizacao bit;")
                Atualizar("Update Config set OcultarAutorizacao = 'True' where OcultarAutorizacao is null")

       

            End If

            If intVersao <= 186 Then

                Atualizar("Update Config set VersaoNano ='1.8.7'")

            End If

            If intVersao <= 187 Then

                Atualizar("Update Config set VersaoNano ='1.8.8'")

            End If

            If intVersao <= 188 Then

                Atualizar("Update Config set VersaoNano ='1.8.9'")

            End If
            If intVersao <= 189 Then
                'Pegunta se quer imprimir o cupom da venda so na jessica
                'Comprovante no caixa
                'Relatorio de comandas
                'Imprimir etiquetas no cadastro de cliente poder selecionar qual e quantas

                Atualizar("Update Config set VersaoNano ='1.9.0'")

            End If

            If intVersao <= 190 Then
                'alteração na abertura da gaveta para imprimir com a impressora "ARQUIVO"
                'ALTERAÇÃO DA FONTE DO GRID DA TELA DE VENDA
                'ALTERAÇÃO DOS CAMPOS TOTAL E SUB TOTAL DA TELA DE VENDA PARA O NANO CAMPO

                Atualizar("Update Config set VersaoNano ='1.9.1'")

            End If


            If intVersao <= 191 Then
                'colocar inutilização de numeracao de nfe

                Atualizar("Update Config set VersaoNano ='1.9.2'")

                If ExisteTabela("Inutilizacao") = False Then
                    ExecutaSQL("CREATE TABLE Inutilizacao (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey69 PRIMARY KEY," & _
                    "NumInicial Integer," & _
                    "NumFinal Integer," & _
                    "Data SmallDateTime," & _
                    "Serie Varchar(3)," & _
                    "Motivo Varchar (MAX));")
                End If

                ' '' '' '' Atualizar("Update Total set Hora ='00:00' where Hora is null")

                ' '' '' ''Atualizar("Update Total set Hora ='00:00' where Hora = ''")

            End If

            If intVersao <= 192 Then
                'Calculo com desconto alguns nao batem com o cupom fiscal, por isso trava a impressora
                'Entrada NF erro ao atualizar estoque, por causa da unidade medida que tem mais no cadastro de 
                'produtos e na entrada esta faltando

                Atualizar("Update Config set VersaoNano ='1.9.3'")
            End If

            If intVersao <= 193 Then
                'Config na nfe

                Atualizar("Update Config set VersaoNano ='1.9.4'")

                ExecutaSQL("ALTER TABLE ConfigNfe ADD CodConfig Integer;")
                Atualizar("Update ConfigNfe set CodConfig = 1 where CodConfig is null")

                ExecutaSQL("ALTER TABLE TotalNfe ADD CodConfig Integer;")
                Atualizar("Update TotalNfe set CodConfig = 1 where CodConfig is null")

                ExecutaSQL("ALTER TABLE ItensNfe ADD CodConfig Integer;")
                Atualizar("Update ItensNfe set CodConfig = 1 where CodConfig is null")

                ExecutaSQL("ALTER TABLE RefNfe ADD CodConfig Integer;")
                Atualizar("Update RefNfe set CodConfig = 1 where CodConfig is null")

                ExecutaSQL("ALTER TABLE VolumeNfe ADD CodConfig Integer;")
                Atualizar("Update VolumeNfe set CodConfig = 1 where CodConfig is null")

                ExecutaSQL("ALTER TABLE DuplicataNfe ADD CodConfig Integer;")
                Atualizar("Update DuplicataNfe set CodConfig = 1 where CodConfig is null")

                ExecutaSQL("ALTER TABLE Cce ADD CodConfig Integer;")
                Atualizar("Update Cce set CodConfig = 1 where CodConfig is null")

                ExecutaSQL("ALTER TABLE Inutilizacao ADD CodConfig Integer;")
                Atualizar("Update Inutilizacao set CodConfig = 1 where CodConfig is null")

            End If


            If intVersao <= 194 Then
                'Estornar conta receber
                'Estornar conta pagar
                'Corrigir impressao de cupom no pedido
                'Imprimir venda impressora normal
                'Imprimir recibo impressora normal
                'Verificar erro de desconto nos itens da venda
                'CFOP cadastro de produto
                'Abrir gaveta impressora fiscal
                'Novo busca cep
                'Tirar totais do caixa se for usuario Jessica
                'Bloquear desconto Jessica
                'Corrigir xml com aspas e faltando cabeçalho
                'Correção replicação

                Atualizar("Update Config set VersaoNano ='1.9.5'")
            End If


            If intVersao <= 195 Then
                'Cidade sem aspas pelo cep
                'Alterar calculo de credito nfe
                'Corrigir ConfigNfe
                'Cfop Produto lue
                'Corrigir numeor ordem nfe

                Atualizar("Update Config set VersaoNano ='1.9.6'")

                ExecutaSQL("Alter Table ConfigNfe Alter Column TZDCce Varchar(6);")
                ExecutaSQL("Alter Table Cce Alter Column TZD Varchar(6);")
            End If

            If intVersao <= 196 Then
                'Estoque Somado
                'Entrada Nf limpar filtro antes de salvar 
                'Entrada NF limpar campo se nao existir NF 
                'Colocar imagem nano commerce nos graficos e entradanf
                'Desconto total no cupom fiscal
                'Log alteração de valor venda do produto
                'Log alteração de valor custo do produto
                'Log cadastro de produto
                'Log alteração nome fantasia do fornecedor
                'CFOP produto
                'Entrada Nf xml setar tipo do Fornecedor
                'Impressão do pedido com data de venda
                'Impressão do pedido com prazo de entrega 30 dias
                'Venda com ecf deixar puxar cliente sem cpf
                'Venda se for usuario não aparecer valor custo
                'Pedido colocar desconto por produto
                'Pedido puxar promoção
                'Pedido colocar coluna Valor sem desconto
                'Impressão do pedido aparecer valor sem desconto
                'Venda puxar o pedido com os descontos e promoção
                'Não aparecer funcionario inativo em nenhum lugar
                'Observação do produto aparecer pra lucia freitas
                'Relatório de comissão somado
                'Valor custo do pedido na correção replicação
                'Mostrar cod prod na devolução cadastro e relatorio
                'Giro com ajuste
                'Entrada Nf cadastrar produto
                'Colocar de olho no imposto fixo
                'Entrada Nf xml produtos iguais nao cadastrar duas vezes
                'Entrada Nf colocar codigo de barras

                Atualizar("Update Config set VersaoNano ='1.9.7'")

                If ExisteTabela("AjusteQtde") = False Then
                    ExecutaSQL("CREATE TABLE AjusteQtde (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey70 PRIMARY KEY," & _
                    "CodProd Integer," & _
                    "Qtd Numeric(15,3)," & _
                    "Data SmallDateTime," & _
                    "Tabela Varchar(20)," & _
                    "CodConfig Integer);")
                End If

                ExecutaSQL("ALTER TABLE Config ADD EstoqueSomado bit;")
                Atualizar("Update Config set EstoqueSomado = 'False' where EstoqueSomado is null")


                ExecutaSQL("ALTER TABLE TotalConsig ADD DataVenda SmallDateTime;")
                ExecutaSQL("ALTER TABLE ItensConsig ADD UniSemDesc Numeric(15,2);")
                ExecutaSQL("ALTER TABLE ItensConsig ADD Promocao bit;")
                Atualizar("Update ItensConsig set Promocao = 'False' where Promocao is null")

                ExecutaSQL("ALTER TABLE ItensConsig ADD Desconto Numeric(15,2);")

                ExecutaSQL("ALTER TABLE Config ADD PorValorAproximado Varchar(10);")

                Atualizar("Update Config set UsaNfe = ImportarNfe")

                ExecutaSQL("ALTER TABLE Log ALTER COLUMN Motivo Varchar(100);")
                ExecutaSQL("ALTER TABLE AjusteQtde ADD CodUser integer;")
            End If

            If intVersao <= 197 Then
                '09/06/2014
                'correção alteração item pedido
                'correção valor de custo para usuário
                'implantação do nano print

                Atualizar("Update Config set VersaoNano ='1.9.8'")
            End If


            If intVersao <= 198 Then
                '10/06/2014
                'correção alteração item pedido
                'correção entradanf xml
                'correção de olho no imposto nfe

                Atualizar("Update Config set VersaoNano ='1.9.9'")
            End If

            If intVersao <= 199 Then
                '14/06/2014
                'correção alteração item pedido de novo agora ta certo
                'Estoque somada na grid tirar tela

                Atualizar("Update Config set VersaoNano ='2.0.0'")
            End If

            If intVersao <= 200 Then
                '16/07/2014
                'correção do pedido no form de tamanho
                'Senha para excluir item na venda para Jéssica Cosméticos
                'correção nano print

                Atualizar("Update Config set VersaoNano ='2.0.1'")
            End If

            If intVersao <= 201 Then
                '17/07/2014
                'correção do pedido no form de tamanho dois where
                'correção comanda zerada ao finalizar erro por causa da consiguinacao

                Atualizar("Update Config set VersaoNano ='2.0.2'")
            End If

            If intVersao <= 202 Then
                '07/08/2014
                'Etiquetas Label Pimaco
                'NFE Nano

                Atualizar("Update Config set VersaoNano ='2.0.3'")

                ExecutaSQL("ALTER TABLE Config ADD NfeNano bit;")
                Atualizar("Update Config set NfeNano = 'False' where NfeNano is null")
                Atualizar("Update ConfigNfe set VerProc ='1.0.0'")

            End If

            If intVersao <= 203 Then
                '19/08/2014
                'Erro Crediario ao fechar a tela tem q limpar a grid
                'Inserir para todos ncm pegruntar antes
                Atualizar("Update Config set VersaoNano ='2.0.4'")
            End If

            If intVersao <= 204 Then
                '29/08/2014
                'Config TipoNano AutoPeça
                'Obs = Aplicação
                'Venda Mecanico
                'Corrigir cadastro de fornecedor alterar representante

                Atualizar("Update Config set VersaoNano ='2.0.5'")
                ExecutaSQL("ALTER TABLE Pedido ADD CodMecanico Integer;")
            End If

            If intVersao <= 205 Then
                '02/09/2014
                'Mecanico venda so no botao
                'Qtd Minima Produto erro se tiver vazio
                'rel pedido valor sem desconto
                'Qtd de itens no pedido
                'Tipo nano 2 trocar Locacao pra cod similar varchar max

                Atualizar("Update Config set VersaoNano ='2.0.6'")
                ExecutaSQL("ALTER TABLE Produto Alter Column Locacao varchar(Max);")
            End If

            If intVersao <= 206 Then
                '08/09/2014
                'Relatorios Cravo Canela
                'Codigo ANP Combustivel
                'Correções dos forms

                Atualizar("Update Config set VersaoNano ='2.0.7'")

                ExecutaSQL("ALTER TABLE Nfe Add CodigoANP varchar(10);")
                ExecutaSQL("ALTER TABLE Nfe Add UFComb varchar(2);")
                ExecutaSQL("ALTER TABLE ItensNfe Add CodigoANP varchar(10);")
                ExecutaSQL("ALTER TABLE ItensNfe Add UFComb varchar(2);")

            End If

            If intVersao <= 207 Then
                '09/09/2014
                'Nfe padrao
                'Saldo atual no relatorio de caixa pro Max denim

                Atualizar("Update Config set VersaoNano ='2.0.8'")


            End If


            If intVersao <= 208 Then
                '15/09/2014
                'Comissao funcionrio (charme)
                'segunda via da venda
                'Credito e debito funcionario

                Atualizar("Update Config set VersaoNano ='2.0.9'")

                If ExisteTabela("Representacao") = False Then
                    ExecutaSQL("CREATE TABLE Representacao (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey71 PRIMARY KEY," & _
                    "CodPed Integer," & _
                    "CodCli Integer," & _
                    "CodFunc Integer," & _
                    "Data SmallDateTime," & _
                    "Valor Numeric(15,2)," & _
                    "Porcentagem Numeric(15,2)," & _
                    "ComissaoFunc Numeric(15,2)," & _
                    "ComissaoEsc Numeric(15,2)," & _
                    "CodConfig Integer);")
                End If

                If ExisteTabela("GastosFunc") = False Then
                    ExecutaSQL("CREATE TABLE GastosFunc (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey72 PRIMARY KEY," & _
                    "CodFunc Integer," & _
                    "Valor Numeric(15,3)," & _
                    "Data SmallDateTime," & _
                    "Tipo Varchar(1)," & _
                    "Motivo Varchar(Max)," & _
                    "CodConfig Integer);")
                End If
            End If

            If intVersao <= 209 Then
                '15/09/2014
                'Erro config representacao e gasto func

                Atualizar("Update Config set VersaoNano ='2.1.0'")

            End If

            If intVersao <= 210 Then
                '22/09/2014
                'If para impressão Código Barra Cavalão Auto Peças

                Atualizar("Update Config set VersaoNano ='2.1.1'")

            End If


            If intVersao <= 211 Then
                '24/09/2014
                'If para MSG impressão Cavalão Auto Peças no pedido

                Atualizar("Update Config set VersaoNano ='2.1.2'")
                ExecutaSQL("ALTER TABLE ContaReceber Add Comissao Numeric(18,2);")

            End If

            If intVersao <= 212 Then
                '29/09/2014
                'Cravo Canela Relatorios
                'Pedido venda completo
                'Correcao ortografia giro e espelho cupom

                Atualizar("Update Config set VersaoNano ='2.1.3'")
            End If

            If intVersao <= 213 Then
                '29/09/2014
                'Erro load usuario
                'Charme nao aparece o botao

                Atualizar("Update Config set VersaoNano ='2.1.4'")
            End If

            If intVersao <= 214 Then
                '06/10/2014
                Atualizar("Update Config set VersaoNano ='2.1.5'")
                ExecutaSQL("ALTER TABLE Produto Add Validade SmallDateTime;")
                ExecutaSQL("ALTER TABLE Fornecedor Add Inativo Bit;")
                Atualizar("Update Fornecedor set Inativo ='False' where Inativo is null")
                Atualizar("Update Produto set Validade ='01/01/2050'")
                ExecutaSQL("ALTER TABLE Email Add Porta Varchar(10);")
                ExecutaSQL("ALTER TABLE Email Add Servico Varchar(30);")
                ' '' '' '' Atualizar("Update ContaReceber set Comissao = 0")
            End If

            If intVersao <= 215 Then
                '08/10/2014
                Atualizar("Update Config set VersaoNano ='2.1.6'")
            End If

            If intVersao <= 216 Then
                '21/10/2014
                'Colocar valor venda no relatorio de itens entrada nf
                'Cravo canela relatorio informativo pela comissao
                'Fornecedor codigo municipio na tela
                Atualizar("Update Config set VersaoNano ='2.1.7'")
            End If

            If intVersao <= 217 Then
                '27/10/2014
        
                Atualizar("Update Config set VersaoNano ='2.1.8'")

                If ExisteTabela("Agenda") = False Then
                    ExecutaSQL("CREATE TABLE Agenda (" & _
                    "CodOrdem Integer," & _
                    "Type INTEGER," & _
                    "StartDate SmallDateTime," & _
                    "EndDate SmallDateTime," & _
                    "AllDay Bit," & _
                    "Subject varchar (50)," & _
                    "Location varchar (50)," & _
                    "Description varchar(max)," & _
                    "Status integer," & _
                    "Label integer," & _
                    "ResourceID integer," & _
                    "ResourceIDs varchar(max)," & _
                    "ReminderInfo varchar(max)," & _
                    "RecurrenceInfo varchar(max)," & _
                    "CustomField1 varchar(max)," & _
                    "Conta Bit," & _
                    "CodConfig integer);")
                End If
            End If

            If intVersao <= 218 Then
                '30/10/2014

                Atualizar("Update Config set VersaoNano ='2.1.9'")

                'ExecutaSQL("Delete FROM Bloqueios")

                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Vender','Vendas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Cliente','Lucro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Fornecedor','Gráficos')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Produtos','Recebimentos Totais')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Funcionarios','Recebimentos Cartões')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pagamentos','Contas Recebidas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Entrada de NF','Contas Pagas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Contas a Receber','Totais Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Contas a Pagar','Itens Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Caixa','Devolução')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Devolução','Consumo')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Descartes','Visão')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Saldo Atual Caixa','Descarte')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pedidos','Giro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Banco','Inadimplência')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar NF-e','NF-e')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Transportadora','Transferência')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Controle de Cheque','Inventário')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Inventário','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Ativar Produto','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Altera Valores Produto','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('MDI Analyser','')")
            End If


            If intVersao <= 219 Then
                '12/11/2014

                Atualizar("Update Config set VersaoNano ='2.2.0'")

                ExecutaSQL("ALTER TABLE Config Add ImprimirDireto Bit;")

                Atualizar("Update Config set ImprimirDireto ='True'")


            End If

            If intVersao <= 220 Then
                '17/11/2014
                Atualizar("Update Config set VersaoNano ='2.2.1'")
            End If


            If intVersao <= 221 Then
                '17/11/2014
                Atualizar("Update Config set VersaoNano ='2.2.2'")
            End If

            If intVersao <= 222 Then
                '01/12/2014
                Atualizar("Update Config set VersaoNano ='2.2.3'")
            End If

            If intVersao <= 223 Then
                '04/12/2014
                Atualizar("Update Config set VersaoNano ='2.2.4'")
                ExecutaSQL("ALTER TABLE Config Add CodigoBarraCupom Bit;")
                Atualizar("Update Config set CodigoBarraCupom ='True' where CodigoBarraCupom is null")

                ExecutaSQL("ALTER TABLE Config Add AutorizacaoPedido Bit;")
                Atualizar("Update Config set AutorizacaoPedido ='False' where AutorizacaoPedido is null")

                ExecutaSQL("ALTER TABLE Config Add DezPorcento Bit;")
                Atualizar("Update Config set DezPorcento ='False' where DezPorcento is null")

            End If

            If intVersao <= 224 Then
                '12/12/2014
                Atualizar("Update Config set VersaoNano ='2.2.5'")
               
            End If

            If intVersao <= 225 Then
                '12/01/2015
                Atualizar("Update Config set VersaoNano ='2.2.6'")

            End If

            If intVersao <= 226 Then
                '14/01/2015
                Atualizar("Update Config set VersaoNano ='2.2.7'")

            End If

            If intVersao <= 227 Then
                '21/01/2015
                Atualizar("Update Config set VersaoNano ='2.2.8'")

            End If

            If intVersao <= 228 Then
                '02/02/2015
                Atualizar("Update Config set VersaoNano ='2.2.9'")


                ExecutaSQL("ALTER TABLE Config ADD UsaBoleto Bit;")
                Atualizar("Update Config set UsaBoleto ='False' where UsaBoleto is null")

                ExecutaSQL("ALTER TABLE Config ADD CaminhoPastaBoleto Varchar(80);")

                ExecutaSQL("ALTER TABLE Banco ADD Versao varchar(10);")
                ExecutaSQL("ALTER TABLE Banco ADD Padrao bit;")
                Atualizar("Update Banco set Versao ='1.0.1'")
                Atualizar("Update Banco set Padrao ='False' where Padrao is null")
                ExecutaSQL("ALTER TABLE Banco ADD CodigoTransmissao varchar(30);")
                ExecutaSQL("ALTER TABLE Banco ADD Agencia varchar(20);")
                ExecutaSQL("ALTER TABLE Banco ADD CodigoCedente varchar(20);")
                ExecutaSQL("ALTER TABLE Banco ADD CodigoBanco varchar(10);")
                ExecutaSQL("ALTER TABLE Banco ADD NomeBanco varchar(100);")
                ExecutaSQL("ALTER TABLE Banco ADD ContaCorrente varchar(20);")
                ExecutaSQL("ALTER TABLE Banco ADD Cedente varchar(150);")
                ExecutaSQL("ALTER TABLE Banco ADD CPF varchar(20);")
                ExecutaSQL("ALTER TABLE Banco ADD PerMulta varchar(10);")
                ExecutaSQL("ALTER TABLE Banco ADD CodigoCarteira varchar(50);")
                ExecutaSQL("ALTER TABLE Banco ADD CodigoOcorrencia varchar(50);")
                ExecutaSQL("ALTER TABLE Banco ADD SeuNumero varchar(10);")
                ExecutaSQL("ALTER TABLE Banco ADD Especie varchar(20);")
                ExecutaSQL("ALTER TABLE Banco ADD TipoAceite varchar(10);")
                ExecutaSQL("ALTER TABLE Banco ADD PrimeiraInstrucao varchar(50);")
                ExecutaSQL("ALTER TABLE Banco ADD SegundaInstrucao varchar(50);")
                ExecutaSQL("ALTER TABLE Banco ADD DiasMora varchar(10);")
                ExecutaSQL("ALTER TABLE Banco ADD ValorMora varchar(18);")
                ExecutaSQL("ALTER TABLE Banco ADD ValorIOF varchar(18);")
                ExecutaSQL("ALTER TABLE Banco ADD DiasProtesto varchar(10);")


                Atualizar("Update Banco set NomeBanco = Nome")
            End If

            If intVersao <= 229 Then
                '12/02/2015
                Atualizar("Update Config set VersaoNano ='2.3.0'")
            End If


            If intVersao <= 230 Then
                '10/02/2015

                Atualizar("Update Config set VersaoNano ='2.3.1'")

                If ExisteTabela("Animal") = False Then
                    ExecutaSQL("CREATE TABLE Animal (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey90 PRIMARY KEY," & _
                    "Nome varchar(100)," & _
                    "CodEletronico varchar(50)," & _
                    "Especie varchar(50)," & _
                    "Sexo varchar(1)," & _
                    "Vivo bit," & _
                    "Raca varchar(50)," & _
                    "Pelagem varchar(50)," & _
                    "Nascimento SmallDateTime," & _
                    "Data SmallDateTime," & _
                    "Ficha varchar(MAX)," & _
                    "Foto Image," & _
                    "CodCli int);")

                    ExecutaSQL("ALTER TABLE Animal ADD CONSTRAINT fk_DonoAnimal FOREIGN KEY (CodCli) REFERENCES Cliente(Codigo)")
                End If

                ExecutaSQL("ALTER TABLE TotalConsig ADD CodAnimal Integer;")

            End If

            If intVersao <= 231 Then
                '10/02/2015

                Atualizar("Update Config set VersaoNano ='2.3.2'")
                ExecutaSQL("ALTER TABLE Config ADD ComissaoProduto Bit;")
                Atualizar("Update Config set ComissaoProduto ='False' where ComissaoProduto is null")
                ExecutaSQL("ALTER TABLE Produto ADD Comissao Numeric(15,2);")
                Atualizar("Update Produto set Comissao =0 where Comissao is null")
            End If

            If intVersao <= 232 Then
                '11/03/2015

                Atualizar("Update Config set VersaoNano ='2.3.3'")
                ExecutaSQL("ALTER TABLE ItensConsig ADD Retorno Varchar(10);")

            End If

            If intVersao <= 233 Then
                '24/03/2015

                Atualizar("Update Config set VersaoNano ='2.3.4'")
                ExecutaSQL("ALTER TABLE Total ADD CodPedido integer;")

            End If

            If intVersao <= 234 Then
                '30/03/2015

                Atualizar("Update Config set VersaoNano ='2.3.5'")

            End If

            If intVersao <= 235 Then
                '06/04/2015

                Atualizar("Update Config set VersaoNano ='2.3.6'")

            End If
            If intVersao <= 236 Then
                '13/04/2015

                Atualizar("Update Config set VersaoNano ='2.3.7'")

            End If

            If intVersao <= 237 Then
                '15/04/2015

                Atualizar("Update Config set VersaoNano ='2.3.8'")

            End If

            If intVersao <= 238 Then
                '22/04/2015

                Atualizar("Update Config set VersaoNano ='2.3.9'")
                ExecutaSQL("ALTER TABLE Config ADD AtuPreCusto Bit;")
                Atualizar("Update Config set AtuPreCusto ='True' where AtuPreCusto is null")
                ExecutaSQL("ALTER TABLE Produto ADD Imagem1 Image;")
                ExecutaSQL("ALTER TABLE Produto ADD Imagem2 Image;")

            End If


            If intVersao <= 239 Then
                '28/04/2015

                Atualizar("Update Config set VersaoNano ='2.4.0'")
                ExecutaSQL("ALTER TABLE Config ADD UF Varchar(2);")
                Atualizar("Update Config set UF ='SP' where UF is null")
          

            End If


            If intVersao <= 240 Then
                '11/05/2015

                Atualizar("Update Config set VersaoNano ='2.4.1'")

                ExecutaSQL("ALTER TABLE Config ADD SimplesNacional Bit;")
                Atualizar("Update Config set SimplesNacional ='True' where SimplesNacional is null")
            End If


            If intVersao <= 241 Then
                '14/05/2015

                Atualizar("Update Config set VersaoNano ='2.4.2'")

                ExecutaSQL("ALTER TABLE Config ADD BuscaCpfCnpj Varchar(10);")
                Atualizar("Update Config set BuscaCpfCnpj ='CPF/CNPJ'")
            End If

            If intVersao <= 242 Then
                '18/05/2015

                Atualizar("Update Config set VersaoNano ='2.4.3'")

                ExecutaSQL("ALTER TABLE Cheque ADD Observacao Varchar(Max);")
            End If

            If intVersao <= 243 Then
                '02/06/2015

                Atualizar("Update Config set VersaoNano ='2.4.4'")

                ExecutaSQL("ALTER TABLE Animal ADD Peso Numeric(15,3);")
            End If

            If intVersao <= 244 Then
                '02/06/2015

                Atualizar("Update Config set VersaoNano ='2.4.5'")
                ExecutaSQL("ALTER TABLE Comissao ADD Pago bit;")
                Atualizar("Update Comissao set Pago ='False' where Pago is null")
                ExecutaSQL("ALTER TABLE Config ADD ObsProduto bit;")
                Atualizar("Update Config set ObsProduto ='False' where ObsProduto is null")
            End If


            If intVersao <= 245 Then
                '07/07/2015

                Atualizar("Update Config set VersaoNano ='2.4.6'")

                ExecutaSQL("Alter Table Fornecedor ADD Nascimento SmallDateTime;")

                ExecutaSQL("Alter Table Produto Alter Column Nome Varchar(200);")
                ExecutaSQL("Alter Table Comanda Alter Column Produto Varchar(200);")
                ExecutaSQL("Alter Table EntradaNF Alter Column Produto Varchar(200);")
                ExecutaSQL("Alter Table ItensConsig Alter Column Produto Varchar(200);")
                ExecutaSQL("Alter Table ItensNfe Alter Column Produto Varchar(200);")
                ExecutaSQL("Alter Table Pedido Alter Column Produto Varchar(200);")
                ExecutaSQL("Alter Table ProdOpc Alter Column Produto Varchar(200);")
                ExecutaSQL("Alter Table Receita Alter Column Nome Varchar(200);")

                ExecutaSQL("Alter Table ItensConsig Alter Column UM Varchar(15);")
                ExecutaSQL("Alter Table Log Alter Column Novo Varchar(max);")
                ExecutaSQL("Alter Table Log Alter Column Antigo Varchar(max);")


                ExecutaSQL("ALTER TABLE Config ADD SATFiscal bit;")
                Atualizar("Update Config set SATFiscal ='False' where SATFiscal is null")

                ExecutaSQL("ALTER TABLE Nfe ADD Tributacao Varchar(10);")
                ExecutaSQL("ALTER TABLE Nfe ADD AliquotaICMS Varchar(15);")

                ExecutaSQL("ALTER TABLE Recebimento ADD CodigoPedido Varchar(20);")

                ExecutaSQL("ALTER TABLE Futuro ADD CodigoPedido Varchar(20);")
                ExecutaSQL("ALTER TABLE ContaReceber ADD CodigoPedido Varchar(20);")
                ExecutaSQL("ALTER TABLE Cheque ADD CodigoPedido Varchar(20);")

                Atualizar("Update Recebimento set CodigoPedido ='' where CodigoPedido is null")
                Atualizar("Update Futuro set CodigoPedido ='' where CodigoPedido is null")
                Atualizar("Update ContaReceber set CodigoPedido ='' where CodigoPedido is null")
                Atualizar("Update Cheque set CodigoPedido ='' where CodigoPedido is null")

                ExecutaSQL("ALTER TABLE Config ADD SepararEstoqueSetor Varchar(80);")
            End If

            If intVersao <= 246 Then
                '08/07/2015

                Atualizar("Update Config set VersaoNano ='2.4.7'")

            End If

            If intVersao <= 247 Then
                '22/07/2015

                Atualizar("Update Config set VersaoNano ='2.4.8'")
                ExecutaSQL("Alter Table ContaReceber Alter Column Parcelas Varchar(8);")
                ExecutaSQL("Alter Table ContaPagar Alter Column Parcelas Varchar(8);")
            End If

            If intVersao <= 248 Then
                '22/07/2015
                Atualizar("Update Config set VersaoNano ='2.4.9'")
            End If

            If intVersao <= 249 Then
                '30/07/2015
                Atualizar("Update Config set VersaoNano ='2.5.0'")
                ExecutaSQL("ALTER TABLE ConfigECF ADD Assinatura Varchar(MAX);")

            End If

            If intVersao <= 250 Then
                '04/08/2015
                Atualizar("Update Config set VersaoNano ='2.5.1'")

            End If

            If intVersao <= 251 Then
                '10/08/2015
                Atualizar("Update Config set VersaoNano ='2.5.2'")
                ExecutaSQL("ALTER TABLE TotalConsig ADD Acrescimo Varchar(30);")
                ExecutaSQL("ALTER TABLE Usuario Alter Column Principal Varchar(250);")
                ExecutaSQL("ALTER TABLE Usuario Alter Column Relatorios Varchar(250);")

            End If

            If intVersao <= 252 Then
                '10/08/2015
                Atualizar("Update Config set VersaoNano ='2.5.3'")

                ExecutaSQL("ALTER TABLE Config ADD ImprimeComanda Bit;")
                Atualizar("Update Config set ImprimeComanda ='True' where ImprimeComanda is null")

                ExecutaSQL("ALTER TABLE EntradaNF ADD UMProd Varchar(2);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD QtdProd Numeric(15,3);")
                Atualizar("Update EntradaNF set QtdProd = Qtd where QtdProd is null")

                ExecutaSQL("ALTER TABLE EntradaNF ADD CodProdFor Varchar(20);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD ValorCusto Numeric(15,3);")


                ExecutaSQL("ALTER TABLE EntradaNF ADD CST Varchar(3);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD Origem Varchar(1);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD ModBC Varchar(1);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD AliquotaICMS Varchar(18);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD ValICMS Varchar(18);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD RedBC Varchar(10);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD ModBCST Varchar(1);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD RedBCST Varchar(10);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD MVaSTEnt Varchar(10);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD AliquotaICMSST Varchar(18);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD ValICMSST Varchar(18);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD NCM Varchar(10);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD Regime Varchar(30);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD CalculoCred Varchar(18);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD ValCalculoCred Varchar(18);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD CFOP Varchar(4);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD CSTIPI Varchar(2);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD CodEnq Varchar(5);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD AliquotaIPI Varchar(18);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD ValIPI Varchar(18);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD CSTPIS Varchar(2);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD AliquotaPIS Varchar(18);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD ValPIS Varchar(18);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD CSTCOFINS Varchar(2);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD AliquotaCOFINS Varchar(18);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD ValCOFINS Varchar(18);")

                ExecutaSQL("ALTER TABLE EntradaNF ADD CodigoANPEnt Varchar(10);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD UFCombEnt Varchar(2);")
            End If

            If intVersao <= 253 Then
                '01/09/2015
                Atualizar("Update Config set VersaoNano ='2.5.4'")
            End If

            If intVersao <= 254 Then
                '01/09/2015
                Atualizar("Update Config set VersaoNano ='2.5.5'")
                ExecutaSQL("ALTER TABLE EntradaNF Alter Column UMProd Varchar(5);")
            End If

            If intVersao <= 255 Then
                '01/09/2015
                Atualizar("Update Config set VersaoNano ='2.5.6'")
                ExecutaSQL("ALTER TABLE Cliente ADD Imagem Image;")
            End If

            If intVersao <= 256 Then
                '01/09/2015
                Atualizar("Update Config set VersaoNano ='2.5.7'")
            End If

            If intVersao <= 257 Then
                '29/09/2015
                Atualizar("Update Config set VersaoNano ='2.5.8'")
            
                'ExecutaSQL("Delete FROM Bloqueios")

                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Vender','Vendas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Cliente','Lucro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Fornecedor','Gráficos')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Produtos','Recebimentos Totais')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Funcionarios','Recebimentos Cartões')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pagamentos','Contas Recebidas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Entrada de NF','Contas Pagas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Contas a Receber','Totais Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Contas a Pagar','Itens Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Caixa','Devolução')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Devolução','Consumo')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Descartes','Visão')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Saldo Atual Caixa','Descarte')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pedidos','Giro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Banco','Inadimplência')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar NF-e','NF-e')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Transportadora','Transferência')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Controle de Cheque','Inventário')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Inventário','Fluxo de Caixa')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Ativar Produto','Pedidos')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Altera Valores Produto','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('MDI Analyser','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Consultar Produtos','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerar Boleto','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Saldo Atual Caixa Dinheiro','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Excluir Vendas','')")
            End If

            If intVersao <= 258 Then
                '30/09/2015
                Atualizar("Update Config set VersaoNano ='2.5.9'")
            End If

            If intVersao <= 259 Then
                '30/09/2015
                Atualizar("Update Config set VersaoNano ='2.6.0'")
            End If

            If intVersao <= 260 Then
                '30/09/2015
                Atualizar("Update Config set VersaoNano ='2.6.1'")
            End If

            If intVersao <= 261 Then
                '30/09/2015
                Atualizar("Update Config set VersaoNano ='2.6.2'")
            End If

            If intVersao <= 262 Then
                '30/09/2015
                Atualizar("Update Config set VersaoNano ='2.6.3'")
                ExecutaSQL("ALTER TABLE Produto ADD Locacao2 Varchar(50);")
                ExecutaSQL("ALTER TABLE TotalConsig ADD DataRetirada SmallDateTime;")
                ExecutaSQL("ALTER TABLE TotalConsig ADD DataEntrega SmallDateTime;")
            End If

            If intVersao <= 263 Then
                '30/09/2015
                Atualizar("Update Config set VersaoNano ='2.6.4'")
                ExecutaSQL("ALTER TABLE Nfe ADD Cest Varchar(10);")

                ExecutaSQL("ALTER TABLE Cliente ADD Desconto Numeric(15,2);")

            End If

            If intVersao <= 264 Then
                '05/01/2016
                Atualizar("Update Config set VersaoNano ='2.6.5'")
                ExecutaSQL("ALTER TABLE Config ADD ValorMinimoGaxeta Numeric(15,3);")
                Atualizar("Update Config set ValorMinimoGaxeta =0 where ValorMinimoGaxeta is null")

                ExecutaSQL("ALTER TABLE ItensConsig ADD MedidaA Numeric(15,3);")
                ExecutaSQL("ALTER TABLE ItensConsig ADD MedidaB Numeric(15,3);")
                ExecutaSQL("ALTER TABLE ItensConsig ADD QtdMedida Numeric(15,3);")


                ExecutaSQL("ALTER TABLE TabelaIbpt ADD AliqEst Numeric(15,2);")

            End If

            If intVersao <= 265 Then
                '02/02/2016
                Atualizar("Update Config set VersaoNano ='2.6.6'")

              
            End If
            If intVersao <= 266 Then
                '02/02/2016
                Atualizar("Update Config set VersaoNano ='2.6.7'")

                ExecutaSQL("ALTER TABLE Config ADD ModeloSAT Varchar(50);")
                Atualizar("Update Config set ModeloSAT ='BEMATECH' where ModeloSAT is null")

                ExecutaSQL("ALTER TABLE ConfigECF ADD ModeloImpSAT Varchar(50);")
                ExecutaSQL("ALTER TABLE ConfigECF ADD CaminhoPastaSAT Varchar(50);")


                ExecutaSQL("ALTER TABLE ConfigECF ADD NomeImpSAT Varchar(50);")

                If ExisteTabela("SATFiscal") = False Then
                    ExecutaSQL("CREATE TABLE SATFiscal (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey91 PRIMARY KEY," & _
                    "CodOrdem Integer," & _
                    "Chave varchar(100)," & _
                    "NumeroSerie varchar(50)," & _
                    "NumeroCaixa varchar(10)," & _
                    "ChaveCancelamento varchar(100)," & _
                    "CNPJ varchar(20)," & _
                    "Data SmallDateTime," & _
                    "NumeroCupom varchar(20)," & _
                    "NumeroCupomCancelado varchar(20)," & _
                    "ValorTotal Numeric(15,2)," & _
                    "CFPDest Varchar(20)," & _
                    "AssinaturaQrCode varchar(max)," & _
                    "CodConfig Integer);")
                End If

            End If

            If intVersao <= 267 Then
                '02/02/2016
                Atualizar("Update Config set VersaoNano ='2.6.8'")
                'ExecutaSQL("ALTER TABLE Config ADD BloquearDesconto Bit;")
                'Atualizar("Update Config set BloquearDesconto ='False'")

            End If

            If intVersao <= 268 Then
                '02/02/2016
                Atualizar("Update Config set VersaoNano ='2.6.9'")
                ExecutaSQL("ALTER TABLE ConfigECF ADD ImpDiretoSAT Bit;")
                Atualizar("Update ConfigECF set ImpDiretoSAT ='True' where ImpDiretoSAT is null")
            End If

            If intVersao <= 269 Then
                '02/02/2016
                Atualizar("Update Config set VersaoNano ='2.7.0'")
            End If

            If intVersao <= 270 Then
                '02/02/2016
                Atualizar("Update Config set VersaoNano ='2.7.1'")
            End If

            If intVersao <= 271 Then
                '11/03/2016
                Atualizar("Update Config set VersaoNano ='2.7.2'")
                ExecutaSQL("ALTER TABLE Cliente Alter Column Email Varchar(200);")

            End If

            If intVersao <= 272 Then
                '21/03/2016
                Atualizar("Update Config set VersaoNano ='2.7.3'")

            End If

            If intVersao <= 273 Then
                '21/03/2016
                Atualizar("Update Config set VersaoNano ='2.7.4'")
                ExecutaSQL("ALTER TABLE Config ADD ManterPorcProd Bit;")
                Atualizar("Update Config set ManterPorcProd ='False' where ManterPorcProd is null")

                ExecutaSQL("ALTER TABLE Config ADD TresCasasDecimais Bit;")
                Atualizar("Update Config set TresCasasDecimais ='True' where TresCasasDecimais is null")
            End If

            If intVersao <= 274 Then
                '21/03/2016
                Atualizar("Update Config set VersaoNano ='2.7.5'")
               
            End If

            If intVersao <= 275 Then
                '21/03/2016
                Atualizar("Update Config set VersaoNano ='2.7.6'")

            End If

            If intVersao <= 276 Then
                '05/04/2016
                Atualizar("Update Config set VersaoNano ='2.7.7'")

                If ExisteTabela("PedCompra") = False Then
                    ExecutaSQL("CREATE TABLE PedCompra(" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey92 PRIMARY KEY," & _
                    "CodOrdens Integer," & _
                    "Qtd numeric(15, 3)," & _
                    "CodigoProduto varchar(10)," & _
                    "Produto varchar(200)," & _
                    "ValorUnitario numeric(15, 3)," & _
                    "ValorTotal numeric(15, 3)," & _
                    "CodigoInterno varchar(50)," & _
                    "Custo numeric(15, 3)," & _
                    "UM varchar(15)," & _
                    "Tamanho varchar(10)," & _
                    "CodConfig Integer," & _
                    "UniSemDesc numeric(15, 2)," & _
                    "Promocao bit," & _
                    "Desconto numeric(15, 2)," & _
                    "Retorno varchar(10)," & _
                    "MedidaA numeric(15, 3)," & _
                    "MedidaB numeric(15, 3)," & _
                    "QtdMedida numeric(15, 3));")
                End If

                If ExisteTabela("TotalPedCompra") = False Then
                    ExecutaSQL("CREATE TABLE TotalPedCompra(" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey93 PRIMARY KEY," & _
                    "CodOrdens Integer," & _
                    "Data smalldatetime," & _
                    "CodFor Integer," & _
                    "Total numeric(15, 3)," & _
                    "Descricao nvarchar(max)," & _
                    "Status varchar(10)," & _
                    "Custo numeric(15, 3)," & _
                    "Desconto varchar(30)," & _
                    "Entrega varchar(18)," & _
                    "CodFunc Integer," & _
                    "CodConfig Integer," & _
                    "DataVenda smalldatetime," & _
                    "CodAnimal Integer," & _
                    "Acrescimo varchar(30)," & _
                    "DataRetirada smalldatetime," & _
                    "DataEntrega smalldatetime," & _
                    "NumeroNF varchar(15));")
                End If

                ExecutaSQL("ALTER TABLE TotalEntradaNF ADD CodPedido Integer;")
                ExecutaSQL("ALTER TABLE Pagamento ADD NumDias Varchar(3);")
                ExecutaSQL("ALTER TABLE ContaReceber ADD CentroCusto Varchar(80);")

            End If

            If intVersao <= 277 Then
                '21/03/2016
                Atualizar("Update Config set VersaoNano ='2.7.8'")
                ExecutaSQL("ALTER TABLE Config ADD EmitentePadrao Varchar(10);")

            End If

            If intVersao <= 278 Then
                '21/03/2016
                Atualizar("Update Config set VersaoNano ='2.7.9'")

                If ExisteTabela("TabelaPreco") = False Then
                    ExecutaSQL("CREATE TABLE dbo.TabelaPreco(" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey95 PRIMARY KEY," & _
                    "CodProd Integer," & _
                    "CodTabela Integer," & _
                    "Valor Numeric(15, 3)," & _
                    "Porcentagem Numeric(15, 3));")
                End If

            End If

            If intVersao <= 279 Then

                Atualizar("Update Config set VersaoNano ='2.8.0'")
                ExecutaSQL("ALTER TABLE Config ADD ComandaPedido bit;")
                Atualizar("Update Config set ComandaPedido ='False' where ComandaPedido is null")

                ExecutaSQL("ALTER TABLE TotalConsig ADD Comanda Varchar(10);")
                ExecutaSQL("ALTER TABLE Pedido ADD Desconto Numeric(15,3);")
            End If

            If intVersao <= 280 Then

                Atualizar("Update Config set VersaoNano ='2.8.1'")
                ExecutaSQL("ALTER TABLE Ordens ADD CodEmitente Integer;")
            End If

            If intVersao <= 281 Then

                Atualizar("Update Config set VersaoNano ='2.8.2'")

                ExecutaSQL("ALTER TABLE Usuario Alter Column Principal Varchar(250);")
                ExecutaSQL("ALTER TABLE Usuario Alter Column Relatorios Varchar(250);")
            End If


            If intVersao <= 282 Then

                Atualizar("Update Config set VersaoNano ='2.8.3'")


                'ExecutaSQL("Delete FROM Bloqueios")

                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Vender','Vendas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Cliente','Lucro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Fornecedor','Gráficos')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Produtos','Recebimentos Totais')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Funcionarios','Recebimentos Cartões')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pagamentos','Contas Recebidas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Entrada de NF','Contas Pagas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Contas a Receber','Totais Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Contas a Pagar','Itens Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Caixa','Devolução')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Devolução','Consumo')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Descartes','Visão')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Saldo Atual Caixa','Descarte')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pedidos','Giro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Banco','Inadimplência')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar NF-e','Sat')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Transportadora','Transferência')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Controle de Cheque','Inventário')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Inventário','Fluxo de Caixa')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Ativar Produto','Pedidos')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Altera Valores Produto','Pedidos de Compra')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('MDI Analyser','Campanhas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Consultar Produtos','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerar Boleto','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Saldo Atual Caixa Dinheiro','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Excluir Vendas','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Estoque Negativo','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Produtos em Fata','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Transferencia de Produto','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pedidos de Compra','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Campanhas','')")

                If ExisteTabela("Campanha") = False Then
                    ExecutaSQL("CREATE TABLE dbo.Campanha(" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey96 PRIMARY KEY," & _
                    "CodProd Integer," & _
                    "CodigoInterno Varchar(50)," & _
                    "CodInternoAnt Varchar(50)," & _
                    "Valor Numeric(15, 3)," & _
                    "ValorAnt Numeric (15,3)," & _
                    "NomeCampanha Varchar(100)," & _
                    "Data SmallDateTime," & _
                    "CodConfig integer," & _
                    "Status Varchar(15));")
                End If
            End If


            If intVersao <= 283 Then

                Atualizar("Update Config set VersaoNano ='2.8.4'")
                ExecutaSQL("ALTER TABLE Cliente ADD Agencia varchar(10);")
                ExecutaSQL("ALTER TABLE Cliente ADD ContaCorrente varchar(10);")

            End If

            If intVersao <= 284 Then
                Atualizar("Update Config set VersaoNano ='2.8.5'")
                ExecutaSQL("ALTER TABLE Pedido ADD UniSemDesc Numeric (15,3);")
                ExecutaSQL("ALTER TABLE Usuario ADD Inativo Bit;")
                Atualizar("Update Usuario set Inativo ='False' where Inativo is null")
            End If

            If intVersao <= 285 Then
                Atualizar("Update Config set VersaoNano ='2.8.6'")
            End If

            If intVersao <= 286 Then
                Atualizar("Update Config set VersaoNano ='2.8.7'")
                ExecutaSQL("ALTER TABLE Campanha ADD DataFinal smalldatetime;")
            End If

            If intVersao <= 287 Then
                Atualizar("Update Config set VersaoNano ='2.8.8'")
            End If

            If intVersao <= 288 Then
                Atualizar("Update Config set VersaoNano ='2.8.9'")
            End If

            If intVersao <= 289 Then
                Atualizar("Update Config set VersaoNano ='2.9.0'")
                ExecutaSQL("ALTER TABLE Config ADD DescricaoVenda Varchar(Max);")
                ExecutaSQL("ALTER TABLE Funcionario ADD Meta Numeric(15,2);")
                ExecutaSQL("ALTER TABLE Funcionario ADD Banco Varchar(50);")
                ExecutaSQL("ALTER TABLE Funcionario ADD Agencia varchar(10);")
                ExecutaSQL("ALTER TABLE Funcionario ADD ContaCorrente varchar(10);")
                ExecutaSQL("ALTER TABLE Cliente ADD Banco Varchar(50);")
                ExecutaSQL("ALTER TABLE Nfe ADD PerFCPUF Varchar(18);")
                ExecutaSQL("ALTER TABLE Nfe ADD PerICMSUF Varchar(18);")
            End If

            If intVersao <= 290 Then
                Atualizar("Update Config set VersaoNano ='2.9.1'")
            End If
            If intVersao <= 291 Then
                Atualizar("Update Config set VersaoNano ='2.9.2'")
            End If

            If intVersao <= 292 Then
                Atualizar("Update Config set VersaoNano ='2.9.3'")
                ExecutaSQL("ALTER TABLE Config ADD ImpObsPedidoVenda Bit;")
                Dim dt As DataTable = CarregarDataTable("SELECT TipoNano FROM Config")
                Atualizar("Update Config set ImpObsPedidoVenda ='False' where ImpObsPedidoVenda is null")
                If dt.Rows.Count > 0 Then
                    If dt.Rows.Item(0).Item("TipoNano").ToString = "2" Then
                        Atualizar("Update Config set ImpObsPedidoVenda ='True'")
                    End If
                End If
                'ExecutaSQL("Delete FROM Bloqueios")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Vender','Vendas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Cliente','Lucro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Fornecedor','Gráficos')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Produtos','Recebimentos Totais')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Funcionarios','Recebimentos Cartões')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pagamentos','Contas Recebidas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Entrada de NF','Contas Pagas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Contas a Receber','Totais Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Contas a Pagar','Itens Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Caixa','Devolução')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Devolução','Consumo')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Descartes','Visão')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Saldo Atual Caixa','Descarte')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pedidos','Giro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Banco','Inadimplência')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar NF-e','Sat')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Transportadora','Transferência')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Controle de Cheque','Inventário')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Inventário','Fluxo de Caixa')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Ativar Produto','Pedidos')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Altera Valores Produto','Pedidos de Compra')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('MDI Analyser','Campanhas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Consultar Produtos','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerar Boleto','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Saldo Atual Caixa Dinheiro','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Excluir Vendas','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Estoque Negativo','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Produtos em Falta','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Transferencia de Produto','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pedidos de Compra','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Campanhas','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Liberar Desconto por Itens','')")
            End If

            If intVersao <= 293 Then
                Atualizar("Update Config set VersaoNano ='2.9.4'")
                'ExecutaSQL("Delete FROM Bloqueios")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Vender','Vendas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Cliente','Lucro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Fornecedor','Gráficos')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Produtos','Recebimentos Totais')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Funcionarios','Recebimentos Cartões')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pagamentos','Contas Recebidas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Entrada de NF','Contas Pagas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Contas a Receber','Totais Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Contas a Pagar','Itens Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Caixa','Devolução')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Devolução','Consumo')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Descartes','Visão')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Saldo Atual Caixa','Descarte')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pedidos','Giro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Banco','Inadimplência')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar NF-e','Sat')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Transportadora','Transferência')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Controle de Cheque','Inventário')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Inventário','Fluxo de Caixa')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Ativar Produto','Pedidos')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Altera Valores Produto','Pedidos de Compra')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('MDI Analyser','Campanhas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Consultar Produtos','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerar Boleto','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Saldo Atual Caixa Dinheiro','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Excluir Vendas','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Estoque Negativo','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Produtos em Falta','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Transferencia de Produto','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pedidos de Compra','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Campanhas','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Liberar Desconto por Itens','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Relatório Vendas Tela de Venda','')")
            End If

            If intVersao <= 294 Then
                Atualizar("Update Config set VersaoNano ='2.9.5'")
                ExecutaSQL("ALTER TABLE ConfigECF ADD VersaoXmlSAT varchar(10);")
                Atualizar("Update ConfigECF set VersaoXmlSAT ='0.06'")
            End If

            If intVersao <= 295 Then
                Atualizar("Update Config set VersaoNano ='2.9.6'")

            End If

            If intVersao <= 296 Then
                Atualizar("Update Config set VersaoNano ='2.9.7'")
            End If

            If intVersao <= 297 Then
                Atualizar("Update Config set VersaoNano ='2.9.8'")
                ExecutaSQL("ALTER TABLE Produto ADD Familia Varchar(80);")
            End If

            If intVersao <= 298 Then
                Atualizar("Update Config set VersaoNano ='2.9.9'")
            End If

            If intVersao <= 299 Then
                Atualizar("Update Config set VersaoNano ='3.0.0'")
            End If

            If intVersao <= 300 Then
                Atualizar("Update Config set VersaoNano ='3.0.1'")
                ExecutaSQL("ALTER TABLE SatFiscal ADD CodOrdem2 integer;")
                Atualizar("Update SatFiscal set CodOrdem2 = CodOrdem where CodOrdem2 is null")
            End If

            If intVersao <= 301 Then
                Atualizar("Update Config set VersaoNano ='3.0.2'")
            End If

            If intVersao <= 302 Then
                Atualizar("Update Config set VersaoNano ='3.0.3'")
            End If

            If intVersao <= 303 Then
                Atualizar("Update Config set VersaoNano ='3.0.4'")

            End If

            If intVersao <= 304 Then

                Atualizar("Update Config set VersaoNano ='3.0.5'")

                ExecutaSQL("ALTER TABLE Config ADD VisualizarCobranca Bit;")
                Atualizar("Update Config set VisualizarCobranca = 'True' where VisualizarCobranca is null")

                'ExecutaSQL("Delete FROM Bloqueios")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Vender','Vendas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Cliente','Lucro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Fornecedor','Gráficos')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Produtos','Recebimentos Totais')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Funcionarios','Recebimentos Cartões')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pagamentos','Contas Recebidas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Entrada de NF','Contas Pagas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Contas a Receber','Totais Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Contas a Pagar','Itens Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Caixa','Devolução')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Devolução','Consumo')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Descartes','Visão')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Saldo Atual Caixa','Descarte')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pedidos','Giro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Banco','Inadimplência')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar NF-e','Sat')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Transportadora','Transferência')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Controle de Cheque','Inventário')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Inventário','Fluxo de Caixa')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Ativar Produto','Pedidos')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Altera Valores Produto','Pedidos de Compra')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('MDI Analyser','Campanhas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Consultar Produtos','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerar Boleto','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Saldo Atual Caixa Dinheiro','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Excluir Vendas','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Estoque Negativo','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Produtos em Falta','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Transferencia de Produto','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pedidos de Compra','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Campanhas','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Bloquear Desconto Porc. por Itens','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Relatório Vendas Tela de Venda','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Bloqueio de Usuário','')")
            End If

            If intVersao <= 305 Then
                Atualizar("Update Config set VersaoNano ='3.0.6'")
            End If

            If intVersao <= 306 Then
                Atualizar("Update Config set VersaoNano ='3.0.7'")
                ExecutaSQL("ALTER TABLE Cliente ADD Contato Varchar(50);")
            End If

            If intVersao <= 307 Then
                Atualizar("Update Config set VersaoNano ='3.0.8'")
            End If

            If intVersao <= 308 Then
                Atualizar("Update Config set VersaoNano ='3.0.9'")
            End If

            If intVersao <= 309 Then
                Atualizar("Update Config set VersaoNano ='3.1.0'")
            End If

            If intVersao <= 310 Then
                Atualizar("Update Config set VersaoNano ='3.1.1'")
                ExecutaSQL("ALTER TABLE Ordem ADD  Auxiliar Varchar(100);")
            End If

            If intVersao <= 311 Then
                Atualizar("Update Config set VersaoNano ='3.1.2'")
                ExecutaSQL("ALTER TABLE Total ADD  Auxiliar Varchar(100);")
                ExecutaSQL("ALTER TABLE Pedido ADD  Auxiliar Varchar(100);")
                ExecutaSQL("ALTER TABLE Recebimento ADD  Auxiliar Varchar(100);")
                ExecutaSQL("ALTER TABLE Futuro ADD  Auxiliar Varchar(100);")
                ExecutaSQL("ALTER TABLE Caixa ADD  Auxiliar Varchar(100);")
                ExecutaSQL("ALTER TABLE ContaReceber ADD  Auxiliar Varchar(100);")
                ExecutaSQL("ALTER TABLE Comissao ADD  Auxiliar Varchar(100);")
            End If

            If intVersao <= 312 Then
                Atualizar("Update Config set VersaoNano ='3.1.3'")
                'BLOQUEIOS
            End If

            If intVersao <= 313 Then
                Atualizar("Update Config set VersaoNano ='3.1.4'")
            End If

            '12/12/2016
            If intVersao <= 314 Then
                Atualizar("Update Config set VersaoNano ='3.1.5'")
            End If

            If intVersao <= 315 Then
                Atualizar("Update Config set VersaoNano ='3.1.6'")
                ExecutaSQL("ALTER TABLE Config ADD  AgruparProdutoVenda bit;")
                Atualizar("Update Config set AgruparProdutoVenda ='True' where AgruparProdutoVenda is null")
            End If

            If intVersao <= 316 Then
                Atualizar("Update Config set VersaoNano ='3.1.7'")
                ExecutaSQL("ALTER TABLE ConfigNFe ADD  VerProcCTe Varchar(10);", False)
            End If

            If intVersao <= 317 Then
                Atualizar("Update Config set VersaoNano ='3.1.8'")
                ExecutaSQL("ALTER TABLE ConfigNFe ADD  VerProcCTe Varchar(10);", False)
                'frmAtualizarTabelas.Tag = "TabelaIBPT"
                'frmAtualizarTabelas.ShowDialog()
            End If

            If intVersao <= 318 Then
                Atualizar("Update Config set VersaoNano ='3.1.9'")
            End If

            If intVersao <= 319 Then
                Atualizar("Update Config set VersaoNano ='3.2.0'")
            End If

            If intVersao <= 320 Then
                Atualizar("Update Config set VersaoNano ='3.2.1'")
                ExecutaSQL("ALTER TABLE Config ADD  CompararFornecedor bit;")
                Atualizar("Update Config set CompararFornecedor ='False' where CompararFornecedor is null")
            End If

            If intVersao <= 321 Then
                Atualizar("Update Config set VersaoNano ='3.2.2'")
                ExecutaSQL("ALTER TABLE Config ADD  MontarKit bit;")
                Atualizar("Update Config set MontarKit ='False' where MontarKit is null")
            End If

            If intVersao <= 322 Then
                Atualizar("Update Config set VersaoNano ='3.2.3'")
            End If

            If intVersao <= 323 Then
                Atualizar("Update Config set VersaoNano ='3.2.4'")
                ExecutaSQL("ALTER TABLE Config ADD  MediaCusto bit;")
                Atualizar("Update Config set MediaCusto ='True' where MediaCusto is null")
            End If

            If intVersao <= 324 Then
                Atualizar("Update Config set VersaoNano ='3.2.5'")
            End If

            If intVersao <= 325 Then
                Atualizar("Update Config set VersaoNano ='3.2.6'")
                ExecutaSQL("ALTER TABLE Config ADD  ObsClientePedido bit;")
                Atualizar("Update Config set ObsClientePedido ='False' where ObsClientePedido is null")
            End If

            If intVersao <= 326 Then
                Atualizar("Update Config set VersaoNano ='3.2.7'")
            End If

            If intVersao <= 327 Then
                Atualizar("Update Config set VersaoNano ='3.2.8'")
            End If

            If intVersao <= 328 Then
                Atualizar("Update Config set VersaoNano ='3.2.9'")
            End If

            If intVersao <= 329 Then
                Atualizar("Update Config set VersaoNano ='3.3.0'")
            End If

            If intVersao <= 330 Then
                Atualizar("Update Config set VersaoNano ='3.3.1'")
            End If

            If intVersao <= 331 Then
                Atualizar("Update Config set VersaoNano ='3.3.2'")
            End If

            If intVersao <= 332 Then
                Atualizar("Update Config set VersaoNano ='3.3.3'")
                ExecutaSQL("ALTER TABLE ConfigECF ADD MensImpCupomSAT Bit;")
                Atualizar("Update ConfigECF set MensImpCupomSAT ='False' where MensImpCupomSAT is null")
            End If

            If intVersao <= 333 Then
                Atualizar("Update Config set VersaoNano ='3.3.4'")
                ExecutaSQL("Alter Table Grupo ADD Impressora Varchar(80);")
                ExecutaSQL("Alter Table Comanda ADD ImpOk Bit;")
                Atualizar("Update Comanda set ImpOk ='False' where ImpOk is null")
            End If

            If intVersao <= 334 Then
                Atualizar("Update Config set VersaoNano ='3.3.5'")
            End If

            If intVersao <= 335 Then
                Atualizar("Update Config set VersaoNano ='3.3.6'")
            End If

            If intVersao <= 336 Then
                Atualizar("Update Config set VersaoNano ='3.3.7'")
                ExecutaSQL("ALTER TABLE Config ADD ImprimeContaPagar bit;")
                Atualizar("Update Config set ImprimeContaPagar ='False' where ImprimeContaPagar is null")
            End If

            If intVersao <= 337 Then
                Atualizar("Update Config set VersaoNano ='3.3.8'")
                ExecutaSQL("ALTER TABLE Comanda ADD Nome Varchar (150);")
                ExecutaSQL("ALTER TABLE Config ADD NANONFCe bit;")
                Atualizar("Update Config set NANONFCe ='False' where NANONFCe is null")
                ExecutaSQL("ALTER TABLE Config ADD CaminhoPastaNFCe Varchar(50);")
                ExecutaSQL("Alter Table ConfigNFe ADD PorValorAproximado varchar(10);", False)
                ExecutaSQL("Alter Table ConfigNFe ADD Complemento varchar(60);", False)
                ExecutaSQL("Alter Table ConfigNFe Add IM varchar(20);", False)
                ExecutaSQL("Alter Table ConfigNFe Add CNAE varchar(20);", False)

                If ExisteTabela("NFCe") = False Then
                    ExecutaSQL("CREATE TABLE NFCe (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey97 PRIMARY KEY," & _
                    "CodOrdem Integer," & _
                    "Chave varchar(100)," & _
                    "NumNF varchar(50)," & _
                    "CodNF varchar(10)," & _
                    "ChaveCancelamento varchar(100)," & _
                    "CNPJ varchar(20)," & _
                    "Data SmallDateTime," & _
                    "ValorTotal Numeric(15,2)," & _
                    "CFPDest Varchar(20)," & _
                    "StatusEmitente varchar (20)," & _
                    "CodEmitente Integer," & _
                    "Status varchar(20)," & _
                    "CodConfig Integer);")
                End If

                ExecutaSQL("Alter Table ConfigNFe ADD CSC varchar(60);", False)
                ExecutaSQL("ALTER TABLE ConfigNFe ADD ImpDireto Bit;")
                Atualizar("Update ConfigNFe set ImpDireto ='True' where ImpDireto is null")
                ExecutaSQL("ALTER TABLE ConfigNFe ADD MensImpCupom Bit;")
                Atualizar("Update ConfigNFe set MensImpCupom ='False' where MensImpCupom is null")
                ExecutaSQL("ALTER TABLE ConfigNFe ADD Impressora VArchar(20);")
                ExecutaSQL("ALTER TABLE ConfigNFe ADD PortaImpressora VArchar(50);")
                ExecutaSQL("ALTER TABLE ConfigNFe ADD PastaBackupNFCe VArchar(50);")
            End If

            If intVersao <= 338 Then
                Atualizar("Update Config set VersaoNano ='3.3.9'")
            End If

            If intVersao <= 339 Then
                Atualizar("Update Config set VersaoNano ='3.4.0'")

                If ExecutaSQL("Alter Table ConfigNFe ADD Padrao bit;", False) = True Then
                    Atualizar("Update ConfigNFe set Padrao ='False' where Padrao is null")
                End If
                If ExecutaSQL("Alter Table ConfigNfe Add VersaoXml varchar(5);", False) = True Then
                    Atualizar("Update ConfigNfe set VersaoXml ='3.10' where VersaoXml is null")
                End If
                ExecutaSQL("Alter Table ConfigNfe Add AutXml varchar(200);", False)
                ExecutaSQL("ALTER TABLE ConfigNfe ADD SerialName varchar(100);", False)
                If ExecutaSQL("ALTER TABLE ConfigNfe ADD Email bit;", False) = True Then
                    Atualizar("Update ConfigNfe set Email ='True' where Email is null")
                End If
                ExecutaSQL("ALTER TABLE ConfigNfe ADD PastaBackup varchar(100);", False)
                ExecutaSQL("ALTER TABLE ConfigNfe ADD CertificadoDigital varchar(200);", False)
                ExecutaSQL("ALTER TABLE ConfigNfe ADD VencimentoCertificado SmallDateTime;", False)
                If ExecutaSQL("Alter Table ConfigNfe Add IndFinal varchar(1);", False) = True Then
                    Atualizar("Update ConfigNfe set IndFinal ='1' where IndFinal is null")
                End If
                If ExecutaSQL("Alter Table ConfigNfe Add IndPres varchar(1);", False) = True Then
                    Atualizar("Update ConfigNfe set IndPres ='0' where IndPres is null")
                End If
                If ExecutaSQL("Alter Table ConfigNfe Add IdDest varchar(1);", False) = True Then
                    Atualizar("Update ConfigNfe set IdDest ='1' where IdDest is null")
                End If
                ExecutaSQL("Alter Table Ordens Add StatusEmitente varchar(15);", False)
                ExecutaSQL("Alter Table ConfigNfe ADD LogoTipo Image;", False)
            End If

            If intVersao <= 340 Then
                Atualizar("Update Config set VersaoNano ='3.4.1'")

                If ExecutaSQL("Alter Table Config ADD PDV bit;", False) = True Then
                    Atualizar("Update Config set PDV ='False' where PDV is null")
                End If
                ExecutaSQL("ALTER TABLE ConfigNfe ADD TokenNFCe varchar(10);", False)
            End If

            If intVersao <= 341 Then
                Atualizar("Update Config set VersaoNano ='3.4.2'")
            End If

            If intVersao <= 342 Then
                Atualizar("Update Config set VersaoNano ='3.4.3'")
            End If

            If intVersao <= 343 Then
                Atualizar("Update Config set VersaoNano ='3.4.4'")
                'frmAtualizarTabelas.Tag = "TabelaIBPT"
                'frmAtualizarTabelas.ShowDialog()
            End If

            If intVersao <= 344 Then
                Atualizar("Update Config set VersaoNano ='3.4.5'")
                ExecutaSQL("ALTER TABLE ConfigECF ADD ModeloSAT varchar(20);", False)
                Dim dt As DataTable = CarregarDataTable("SELECT ModeloSAT FROM Config")
                If dt.Rows.Count > 0 Then
                    Dim strModelo As String = dt.Rows.Item(0).Item("ModeloSAT").ToString
                    Atualizar("Update ConfigECF set ModeloSAT ='" & strModelo & "'")
                End If
            End If

            If intVersao <= 345 Then
                Atualizar("Update Config set VersaoNano ='3.4.6'")
                If ExisteTabela("CodigoBarra") = False Then
                    ExecutaSQL("CREATE TABLE CodigoBarra (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey98 PRIMARY KEY," & _
                    "CodProd Integer," & _
                    "CodigoBarra varchar(25));")
                End If
            End If

            If intVersao <= 346 Then
                Atualizar("Update Config set VersaoNano ='3.4.7'")
                ExecutaSQL("ALTER TABLE ItensConsig ADD DataAdd SmallDateTime;")
                Atualizar("Update ItensConsig set DataAdd ='01/01/1900' where DataAdd is null")
            End If

            If intVersao <= 347 Then
                Atualizar("Update Config set VersaoNano ='3.4.8'")
            End If

            If intVersao <= 348 Then
                Atualizar("Update Config set VersaoNano ='3.4.9'")
                ExecutaSQL("ALTER TABLE Config ADD TabelaPreco Varchar(80);")
            End If
        
            If intVersao <= 349 Then

                Atualizar("Update Config set VersaoNano ='3.5.0'")

                ExecutaSQL("ALTER TABLE Tributos ADD Regime Varchar(30);")
                Atualizar("Update Tributos set Regime ='SIMPLES NACIONAL' where Regime is null")

                ExecutaSQL("ALTER TABLE ConfigECF ADD Regime varchar(30);")
                Atualizar("Update ConfigECF set Regime ='SIMPLES NACIONAL' where Regime is null")

                Dim dt As DataTable = CarregarDataTable("SELECT count(Codigo), Regime FROM NFe group by Regime order by count(Codigo) DESC")
                If dt.Rows.Count > 0 Then
                    If dt.Rows.Item(0).Item("Regime").ToString <> "" Then
                        Atualizar("Update Tributos set Regime ='" & dt.Rows.Item(0).Item("Regime").ToString & "'")
                        Atualizar("Update ConfigECF set Regime ='" & dt.Rows.Item(0).Item("Regime").ToString & "'")
                    End If

                End If

                'Inserir("INSERT INTO Nfe (CodProd, EXTIPI, Genero, CST, Origem, ModBC, ICMS, RedBC, ModBCST, " & _
                '"RedBCST, MVaST, CFOP, ICMSST, NCM, Regime, CalculoCred, CodigoANP, UFComb, Cest, PerFCPUF, " & _
                '"PerICMSUF) SELECT CodProd, EXTIPI, Genero, '' as CST, '' as Origem, '' as ModBC, '' as ICMS, '' as RedBC, '' as ModBCST, " & _
                '"'' as RedBCST, '' as MVaST, CFOP, '' as ICMSST, NCM, case when Regime = 'SIMPLES NACIONAL' then 'TRIBUTAÇÃO NORMAL' " & _
                '"else 'SIMPLES NACIONAL' end as Regime, '' as CalculoCred, CodigoANP, UFComb, Cest, '' as PerFCPUF, " & _
                '"'' as PerICMSUF FROM NFe")

                'Inserir("INSERT INTO Tributos (CodProd, CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, " & _
                '"PerCOFINS, Regime) SELECT CodProd, '' as CSTIPI, '' as PerIPI, '' as CodEnq, '' as CSTPIS, '' as PerPIS, '' as CSTCOFINS, " & _
                '"'' as PerCOFINS, case when Regime = 'SIMPLES NACIONAL' then 'TRIBUTAÇÃO NORMAL' " & _
                '"else 'SIMPLES NACIONAL' end as Regime FROM Tributos")
            End If
            If intVersao <= 350 Then
                Atualizar("Update Config set VersaoNano ='3.5.1'")

            End If

            If intVersao <= 351 Then
                Atualizar("Update Config set VersaoNano ='3.5.2'")
            End If

            If intVersao <= 352 Then
                Atualizar("Update Config set VersaoNano ='3.5.3'")
                ExecutaSQL("ALTER TABLE Config ADD TEF bit;")
                Atualizar("Update Config set TEF ='False' where TEF is null")

                ExecutaSQL("ALTER TABLE Recebimento ADD Bandeira varchar(50);")
                ExecutaSQL("ALTER TABLE Futuro ADD Bandeira varchar(50);")
                ExecutaSQL("ALTER TABLE Caixa ADD Bandeira varchar(50);")
                ExecutaSQL("ALTER TABLE Futuro ADD NumTransacao varchar(20);")
                ExecutaSQL("ALTER TABLE Futuro ADD Status varchar(20);")

                If ExisteTabela("ConfigTEF") = False Then
                    ExecutaSQL("CREATE TABLE ConfigTEF (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey99 PRIMARY KEY," & _
                    "IP varchar(50)," & _
                    "NumCaixa varchar(8)," & _
                    "Computador varchar(50)," & _
                    "CodConfig integer);")
                End If
            End If
            If intVersao <= 353 Then
                Atualizar("Update Config set VersaoNano ='3.5.4'")
                'ExecutaSQL("ALTER TABLE Futuro ADD Status varchar(20);")
            End If

            If intVersao <= 354 Then
                Atualizar("Update Config set VersaoNano ='3.5.5'")
            End If

            If intVersao <= 355 Then
                Atualizar("Update Config set VersaoNano ='3.5.6'")
            End If

            If intVersao <= 356 Then
                Atualizar("Update Config set VersaoNano ='3.5.7'")
            End If

            If intVersao <= 357 Then
                Atualizar("Update Config set VersaoNano ='3.5.8'")
            End If

            If intVersao <= 358 Then
                Atualizar("Update Config set VersaoNano ='3.5.9'")
                'bloqueios
            End If

            If intVersao <= 359 Then
                Atualizar("Update Config set VersaoNano ='3.6.0'")
                ExecutaSQL("ALTER TABLE Config ADD SenhaAdm Bit;")
                Atualizar("Update Config set SenhaAdm ='True' where SenhaAdm is null")
                'BLOQUEIO'
            End If

            If intVersao <= 360 Then
                Atualizar("Update Config set VersaoNano ='3.6.1'")
                ExecutaSQL("ALTER TABLE Pagamento ADD UsaTEF Bit;")
                Atualizar("Update Pagamento set UsaTEF ='False' where UsaTEF is null")
                ExecutaSQL("ALTER TABLE Ordens ADD Auxiliar Varchar(50);")
            End If

            If intVersao <= 361 Then
                Atualizar("Update Config set VersaoNano ='3.6.2'")
                ExecutaSQL("ALTER TABLE Config ADD TemBalanca Bit;")
                Atualizar("Update Config set TemBalanca ='False' where TemBalanca is null")
                ExecutaSQL("ALTER TABLE Config ADD EmailArquivo Varchar(50);")
            End If

            If intVersao <= 362 Then
                Atualizar("Update Config set VersaoNano ='3.6.3'")
            End If
            If intVersao <= 363 Then
                Atualizar("Update Config set VersaoNano ='3.6.4'")
            End If

            If intVersao <= 364 Then
                Atualizar("Update Config set VersaoNano ='3.6.5'")
                ExecutaSQL("ALTER TABLE Config ADD CompServidor Varchar(150);")
                Atualizar("Update Config set CompServidor ='' where CompServidor is null")

                ExecutaSQL("ALTER TABLE Comanda ADD APP Bit;")

                ExecutaSQL("ALTER TABLE Config ALTER COLUMN EmailArquivo Varchar(200);")
            End If

            If intVersao <= 365 Then
                Atualizar("Update Config set VersaoNano ='3.6.6'")
            End If

            If intVersao <= 366 Then
                Atualizar("Update Config set VersaoNano ='3.6.7'")

                ExecutaSQL("ALTER TABLE Produto ADD TributacaoPadrao bit;")
                Atualizar("Update Produto set TributacaoPadrao ='False' where TributacaoPadrao is null")
            End If

            If intVersao <= 367 Then
                Atualizar("Update Config set VersaoNano ='3.6.8'")
            End If

            If intVersao <= 368 Then
                Atualizar("Update Config set VersaoNano ='3.6.9'")
            End If

            If intVersao <= 369 Then
                Atualizar("Update Config set VersaoNano ='3.7.0'")
                ExecutaSQL("ALTER TABLE Config ADD TipoBalanca Varchar(150);")
                Atualizar("Update Config set TipoBalanca ='TOLEDO SEM ZERO' where TipoBalanca is null")
                ExecutaSQL("ALTER TABLE Config ADD AlterarDataCaixa Bit;")
                Atualizar("Update Config set AlterarDataCaixa ='True' where AlterarDataCaixa is null")
            End If

            If intVersao <= 370 Then
                Atualizar("Update Config set VersaoNano ='3.7.1'")
                ExecutaSQL("ALTER TABLE Produto ADD AlterarPreco Bit;")
                Atualizar("Update Produto set AlterarPreco ='False' where AlterarPreco is null;")
                ExecutaSQL("ALTER TABLE Funcionario ADD CodUser Integer;")
                ExecutaSQL("ALTER TABLE Config ADD VincularUser Bit;")
                Atualizar("Update Config set VincularUser ='False' where VincularUser is null")
                ExecutaSQL("ALTER TABLE Config ADD TotalEconomizado Bit;")
                Atualizar("Update Config set TotalEconomizado ='False' where TotalEconomizado is null")
            End If

            If intVersao <= 371 Then
                Atualizar("Update Config set VersaoNano ='3.7.2'")
                ExecutaSQL("ALTER TABLE TotalConsig ADD StatusPedido Varchar(80);")
                Atualizar("Update TotalConsig set StatusPedido ='' where StatusPedido is null;")
            End If

            If intVersao <= 372 Then
                Atualizar("Update Config set VersaoNano ='3.7.3'")
            End If

            If intVersao <= 373 Then
                Atualizar("Update Config set VersaoNano ='3.7.4'")

                Atualizar("If not exists(Select Codigo from Grupo where Nome = 'UN' and Tipo ='U') Insert Into Grupo (Nome, Tipo) Values('UN','U')")
                Atualizar("If not exists(Select Codigo from Grupo where Nome = 'JG' and Tipo ='U') Insert Into Grupo (Nome, Tipo) Values('JG','U')")
                Atualizar("If not exists(Select Codigo from Grupo where Nome = 'KT' and Tipo ='U') Insert Into Grupo (Nome, Tipo) Values('KT','U')")
                Atualizar("If not exists(Select Codigo from Grupo where Nome = 'PS' and Tipo ='U') Insert Into Grupo (Nome, Tipo) Values('PS','U')")
                Atualizar("If not exists(Select Codigo from Grupo where Nome = 'LT' and Tipo ='U') Insert Into Grupo (Nome, Tipo) Values('LT','U')")
                Atualizar("If not exists(Select Codigo from Grupo where Nome = 'MT' and Tipo ='U') Insert Into Grupo (Nome, Tipo) Values('MT','U')")
                Atualizar("If not exists(Select Codigo from Grupo where Nome = 'CX' and Tipo ='U') Insert Into Grupo (Nome, Tipo) Values('CX','U')")
                Atualizar("If not exists(Select Codigo from Grupo where Nome = 'GL' and Tipo ='U') Insert Into Grupo (Nome, Tipo) Values('GL','U')")
                Atualizar("If not exists(Select Codigo from Grupo where Nome = 'FD' and Tipo ='U') Insert Into Grupo (Nome, Tipo) Values('FD','U')")
                Atualizar("If not exists(Select Codigo from Grupo where Nome = 'CJ' and Tipo ='U') Insert Into Grupo (Nome, Tipo) Values('CJ','U')")
                Atualizar("If not exists(Select Codigo from Grupo where Nome = 'CT' and Tipo ='U') Insert Into Grupo (Nome, Tipo) Values('CT','U')")
                Atualizar("If not exists(Select Codigo from Grupo where Nome = 'PC' and Tipo ='U') Insert Into Grupo (Nome, Tipo) Values('PC','U')")
                Atualizar("If not exists(Select Codigo from Grupo where Nome = 'DP' and Tipo ='U') Insert Into Grupo (Nome, Tipo) Values('DP','U')")
                Atualizar("If not exists(Select Codigo from Grupo where Nome = 'FR' and Tipo ='U') Insert Into Grupo (Nome, Tipo) Values('FR','U')")
                Atualizar("If not exists(Select Codigo from Grupo where Nome = 'ML' and Tipo ='U') Insert Into Grupo (Nome, Tipo) Values('ML','U')")
                Atualizar("If not exists(Select Codigo from Grupo where Nome = 'PR' and Tipo ='U') Insert Into Grupo (Nome, Tipo) Values('PR','U')")
                Atualizar("If not exists(Select Codigo from Grupo where Nome = 'GR' and Tipo ='U') Insert Into Grupo (Nome, Tipo) Values('GR','U')")

            End If

            If intVersao <= 374 Then
                Atualizar("Update Config set VersaoNano ='3.7.5'")
                ExecutaSQL("ALTER TABLE Pagamento ALTER COLUMN Desconto Varchar(7);")
                ExecutaSQL("ALTER TABLE Total ADD CodOrdensTEF Varchar(20);")
            End If

            If intVersao <= 375 Then
                Atualizar("Update Config set VersaoNano ='3.7.6'")
            End If

            If intVersao <= 376 Then
                Atualizar("Update Config set VersaoNano ='3.7.7'")
                If ExisteTabela("Carro") = False Then
                    ExecutaSQL("CREATE TABLE Carro (" & _
                                       "Codigo INT IDENTITY CONSTRAINT primarykey100 PRIMARY KEY," & _
                                       "Placa varchar(8)," & _
                                       "Modelo varchar(50)," & _
                                       "Cor varchar(30)," & _
                                       "Ano varchar(10)," & _
                                       "KM varchar(15)," & _
                                       "Data varchar(20)," & _
                                       "Fabricante varchar(50)," & _
                                       "Combustivel varchar(20)," & _
                                       "Motor varchar(30)," & _
                                       "Cilindros varchar(15)," & _
                                       "Valvulas varchar(15)," & _
                                       "Chassi varchar(30)," & _
                                       "Obs nvarchar(max)," & _
                                       "Opcionais varchar(255)," & _
                                       "KMMes varchar(10)," & _
                                       "CodConfig int," & _
                                       "Imagem1 image," & _
                                       "Imagem2 image," & _
                                       "Imagem3 image," & _
                                       "Imagem4 image," & _
                                       "Imagem5 image," & _
                                       "Imagem6 image);")
                End If

                ExecutaSQL("ALTER TABLE TotalConsig ADD Placa Varchar(8);")
                ExecutaSQL("ALTER TABLE TotalConsig ADD Modelo Varchar(50);")
                ExecutaSQL("ALTER TABLE TotalConsig ADD Cor Varchar(30);")
                ExecutaSQL("ALTER TABLE TotalConsig ADD Ano Varchar(10);")
                ExecutaSQL("ALTER TABLE TotalConsig ADD Motor Varchar(30);")
                ExecutaSQL("ALTER TABLE TotalConsig ADD NivelCombustivel Varchar(20);")
                ExecutaSQL("ALTER TABLE TotalConsig ADD KMSaida Varchar(8);")
                ExecutaSQL("ALTER TABLE TotalConsig ADD KMEntrada Varchar(8);")
                ExecutaSQL("ALTER TABLE ItensConsig ADD CodigoFuncionario Varchar(10);")
                ExecutaSQL("ALTER TABLE Produto ADD Peso Numeric(15,7);")

                ExecutaSQL("ALTER TABLE Produto ADD CodigoFabricante Varchar(100);")
                ExecutaSQL("ALTER TABLE Produto ADD Garantia Varchar(15);")
                ExecutaSQL("ALTER TABLE Produto ADD KM Varchar(6);")
                ExecutaSQL("ALTER TABLE Config ADD CasaDecimal Varchar(2);")
                Atualizar("Update Config set CasaDecimal ='3' where CasaDecimal is null")
                ExecutaSQL("ALTER TABLE Grupo ALTER COLUMN Tipo Varchar(3);")
                ExecutaSQL("ALTER TABLE TotalConsig ADD Seguro Varchar(80);")
                ExecutaSQL("ALTER TABLE TotalConsig ADD Sinistro Varchar(15);")
                ExecutaSQL("ALTER TABLE ItensConsig Add Autorizado bit;")
                Atualizar("Update ItensConsig set Autorizado ='True' where Autorizado is null")
                ExecutaSQL("ALTER TABLE Config Add ImpressaoPadrao bit;")
                Atualizar("Update Config set ImpressaoPadrao ='True' where ImpressaoPadrao is null")
                ExecutaSQL("ALTER TABLE Funcionario ADD ComServ Varchar(15);")
                ExecutaSQL("ALTER TABLE Cliente ADD Cadastro Varchar(150);")
                ExecutaSQL("ALTER TABLE Carro ADD CodCli Integer;")
                ExecutaSQL("ALTER TABLE Comissao ADD TipoProduto Varchar(20);")
                ExecutaSQL("ALTER TABLE Total ADD Placa Varchar(8);")
                ExecutaSQL("ALTER TABLE Total ADD Modelo Varchar(50);")
                ExecutaSQL("ALTER TABLE Total ADD KM Varchar(10);")
                If ExisteTabela("Cotacao") = False Then
                    ExecutaSQL("CREATE TABLE Cotacao(" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey101 PRIMARY KEY," & _
                    "CodOrdem Integer," & _
                    "CodProd Integer," & _
                    "CodFor Integer," & _
                    "Valor Numeric(15,3)," & _
                    "Data SmallDateTime," & _
                    "CodConfig Integer);")
                End If
                If ExisteTabela("Revisao") = False Then
                    ExecutaSQL("CREATE TABLE Revisao (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey102 PRIMARY KEY," & _
                    "CodOrdem Integer," & _
                    "Placa VARCHAR (7)," & _
                    "Produto VARCHAR (80)," & _
                    "Revisao SmallDateTime," & _
                    "UltimoKM VARCHAR (7)," & _
                    "ProximoKM VARCHAR (7)," & _
                    "CodConfig Integer);")
                End If
                ExecutaSQL("ALTER TABLE EntradaNF ALTER COLUMN ValorUnitario Numeric(15,7);")
                ExecutaSQL("ALTER TABLE Produto ALTER COLUMN Valor Numeric(15,7);")
                ExecutaSQL("ALTER TABLE Pedido ALTER COLUMN ValorUnitario Numeric(15,7);")
                ExecutaSQL("ALTER TABLE Pedido ALTER COLUMN UniSemDesc Numeric(15,7);")
                ExecutaSQL("ALTER TABLE ItensConsig ALTER COLUMN ValorUnitario Numeric(15,7);")
                ExecutaSQL("ALTER TABLE ItensConsig ALTER COLUMN UniSemDesc Numeric(15,7);")
            End If

            If intVersao <= 377 Then
                Atualizar("Update Config set VersaoNano ='3.7.8'")
                ExecutaSQL("ALTER TABLE Config ADD Funilaria Bit;")
                Atualizar("Update Config set Funilaria ='False' where Funilaria is null")
                ExecutaSQL("ALTER TABLE Config ADD Moto Bit;")
                Atualizar("Update Config set Moto ='False' where Moto is null")
                ExecutaSQL("ALTER TABLE Config ADD SemCarro Bit;")
                Atualizar("Update Config set SemCarro ='False' where SemCarro is null")
                ExecutaSQL("ALTER TABLE Produto ADD PesoBruto Numeric(15,7);")
                ExecutaSQL("ALTER TABLE ContaPagar ADD Data SmallDateTime;")
                Atualizar("Update ContaPagar set Data ='01/01/1900' where Data is null")
            End If

            If intVersao <= 378 Then
                Atualizar("Update Config set VersaoNano ='3.7.9'")
            End If

            If intVersao <= 379 Then
                Atualizar("Update Config set VersaoNano ='3.8.0'")
            End If

            If intVersao <= 380 Then
                Atualizar("Update Config set VersaoNano ='3.8.1'")
                ExecutaSQL("ALTER TABLE TotalConsig ADD UsuarioAlt Varchar(150);")
            End If

            If intVersao <= 381 Then
                Atualizar("Update Config set VersaoNano ='3.8.2'")
            End If

            If intVersao <= 382 Then
                Atualizar("Update Config set VersaoNano ='3.8.3'")
                Atualizar("Update ConfigNfe set TZDCce ='-02:00'")


                'ExecutaSQL("Delete FROM Bloqueios")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Vender','Vendas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Cliente','Lucro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Fornecedor','Gráficos')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Produtos','Recebimentos Totais')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Funcionarios','Recebimentos Cartões')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pagamentos','Contas Recebidas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Entrada de NF','Contas Pagas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Contas a Receber','Totais Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Contas a Pagar','Itens Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Caixa','Devolução')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Devolução','Consumo')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Descartes','Visão')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Saldo Atual Caixa','Descarte')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pedidos','Giro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Banco','Inadimplência')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar NF-e','Sat')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Transportadora','Transferência')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Controle de Cheque','Inventário')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Inventário','Fluxo de Caixa')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Ativar Produto','Pedidos')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Altera Valores Produto','Pedidos de Compra')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('MDI Analyser','Campanhas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Consultar Produtos','Desempenho')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerar Boleto','DRE')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Saldo Atual Caixa Dinheiro','Rel. Customizado')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Excluir Vendas','Comanda')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Estoque Negativo','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Produtos em Falta','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Transferencia de Produto','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pedidos de Compra','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Campanhas','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Bloquear Desconto Porc. por Itens','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Relatório Vendas Tela de Venda','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Bloqueio de Usuário','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Relatórios de Caixa','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastro de Usuários','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Pedido','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Alterar Pedido','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Consultar Pedido','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Comanda','')")
            End If

            If intVersao <= 383 Then
                Atualizar("Update Config set VersaoNano ='3.8.4'")
                ExecutaSQL("ALTER TABLE Transferencia ADD Auxiliar Varchar(200);")
                ExecutaSQL("ALTER TABLE Ordens Alter Column Auxiliar Varchar(100);")
                'ExecutaSQL("ALTER TABLE Pedido ADD Auxiliar Varchar(200);")

            End If

            If intVersao <= 384 Then
                Atualizar("Update Config set VersaoNano ='3.8.5'")
                ExecutaSQL("ALTER TABLE Pedido ADD PorcComissao Numeric(15,3);")

            End If

            If intVersao <= 385 Then

                Atualizar("Update Config set VersaoNano ='3.8.6'")
                ExecutaSQL("ALTER TABLE ConfigTEF ADD NomeAd Varchar(20);")
                'Atualizar("Update ConfigTEF set NomeAd ='REDE'")

                'ExecutaSQL("Delete FROM Bloqueios")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Vender','Vendas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Cliente','Lucro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Fornecedor','Gráficos')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Produtos','Recebimentos Totais')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Funcionarios','Recebimentos Cartões')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pagamentos','Contas Recebidas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Entrada de NF','Contas Pagas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Contas a Receber','Totais Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Contas a Pagar','Itens Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Caixa','Devolução')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Devolução','Consumo')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Descartes','Visão')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Saldo Atual Caixa','Descarte')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pedidos','Giro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Banco','Inadimplência')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar NF-e','Sat')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Transportadora','Transferência')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Controle de Cheque','Inventário')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Inventário','Fluxo de Caixa')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Ativar Produto','Pedidos')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Altera Valores Produto','Pedidos de Compra')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('MDI Analyser','Campanhas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Consultar Produtos','Desempenho')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerar Boleto','DRE')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Saldo Atual Caixa Dinheiro','Rel. Customizado')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Excluir Vendas','Comanda')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Estoque Negativo','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Produtos em Falta','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Transferencia de Produto','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pedidos de Compra','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Campanhas','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Bloquear Desconto Porc. por Itens','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Relatório Vendas Tela de Venda','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Bloqueio de Usuário','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Relatórios de Caixa','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastro de Usuários','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Pedido','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Alterar Pedido','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Consultar Pedido','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Comanda','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Botão Abrir Gaveta','')")
            End If

            If intVersao <= 386 Then
                Atualizar("Update Config set VersaoNano ='3.8.7'")
            End If

            If intVersao <= 387 Then
                Atualizar("Update Config set VersaoNano ='3.8.8'")
            End If
            'ajustaremfalta 13/12/2018
            If intVersao <= 388 Then
                Atualizar("Update Config set VersaoNano ='3.8.9'")
            End If

            If intVersao <= 389 Then
                Atualizar("Update Config set VersaoNano ='3.9.0'")
                ExecutaSQL("ALTER TABLE Cliente ADD CodFunc integer;")

                If ExisteTabela("AgendaTelefone") = False Then
                    ExecutaSQL("CREATE TABLE AgendaTelefone(" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey103 PRIMARY KEY," & _
                    "Nome varchar(150)," & _
                    "Contato varchar(50)," & _
                    "Tel1 varchar(18)," & _
                    "Tel2 varchar(18)," & _
                    "Tel3 varchar(18)," & _
                    "ID varchar(18)," & _
                    "Email varchar(80)," & _
                    "Grupo varchar(50));")
                End If
                If ExisteTabela("Locacao") = False Then
                    ExecutaSQL("CREATE TABLE Locacao(" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey104 PRIMARY KEY," & _
                    "CodProd Integer," & _
                    "Locacao varchar(50)," & _
                    "QtdMinima numeric(15, 3)," & _
                    "CodConfig Integer);")
                End If
            End If

            If intVersao <= 390 Then
                Atualizar("Update Config set VersaoNano ='3.9.1'")
                ExecutaSQL("ALTER TABLE R7 Alter Column COO Varchar(MAX);")
            End If

            If intVersao <= 391 Then
                Atualizar("Update Config set VersaoNano ='3.9.2'")
                ExecutaSQL("ALTER TABLE Nfe alter Column CodigoANP varchar(200);")
                ExecutaSQL("Alter Table TabelaIbpt ADD Versao VARCHAR(5);", False)
                ExecutaSQL("Alter Table TabelaIbpt ADD UF VARCHAR(2);", False)
            End If

            If intVersao <= 392 Then
                Atualizar("Update Config set VersaoNano ='3.9.3'")
                Atualizar("Update ConfigNfe set TZDCce ='-03:00'")
            End If

            If intVersao <= 393 Then
                Atualizar("Update Config set VersaoNano ='3.9.4'")
                ExecutaSQL("ALTER TABLE Produto alter Column CodigoFabricante varchar(Max);")
            End If

            If intVersao <= 394 Then
                Atualizar("Update Config set VersaoNano ='3.9.5'")
                ExecutaSQL("ALTER TABLE Banco add CaminhoArquivo varchar(100);")

                ExecutaSQL("ALTER TABLE CodigoBarra add CodFor integer;")
                ExecutaSQL("ALTER TABLE CodigoBarra add Produto varchar(100);")

                ExecutaSQL("ALTER TABLE Qtde Alter Column Tamanho varchar(30);")

                'ExecutaSQL("Delete FROM Bloqueios")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Vender','Vendas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Cliente','Lucro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Fornecedor','Gráficos')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Produtos','Recebimentos Totais')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Funcionarios','Recebimentos Cartões')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pagamentos','Contas Recebidas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Entrada de NF','Contas Pagas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Contas a Receber','Totais Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Contas a Pagar','Itens Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Caixa','Devolução')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Devolução','Consumo')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Descartes','Visão')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Saldo Atual Caixa','Descarte')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pedidos','Giro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Banco','Inadimplência')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar NF-e','Sat')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Transportadora','Transferência')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Controle de Cheque','Inventário')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Inventário','Fluxo de Caixa')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Ativar Produto','Pedidos')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Altera Valores Produto','Pedidos de Compra')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('MDI Analyser','Campanhas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Consultar Produtos','Desempenho')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerar Boleto','DRE')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Saldo Atual Caixa Dinheiro','Rel. Customizado')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Excluir Vendas','Comanda')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Estoque Negativo','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Produtos em Falta','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Transferencia de Produto','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pedidos de Compra','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Campanhas','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Bloquear Desconto Porc. por Itens','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Relatório Vendas Tela de Venda','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Bloqueio de Usuário','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Relatórios de Caixa','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastro de Usuários','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Pedido','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Alterar Pedido','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Consultar Pedido','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Comanda','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Botão Abrir Gaveta','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Kit','')")
            End If

            If intVersao <= 395 Then
                Atualizar("Update Config set VersaoNano ='3.9.6'")
            End If

            If intVersao <= 396 Then
                Atualizar("Update Config set VersaoNano ='3.9.7'")
                ExecutaSQL("ALTER TABLE Config add FiltroProdutoContem Bit;")
                Atualizar("Update Config set FiltroProdutoContem ='False' where FiltroProdutoContem is null")
            End If

            If intVersao <= 397 Then
                Atualizar("Update Config set VersaoNano ='3.9.8'")
                ExecutaSQL("ALTER TABLE Pedido Alter Column Tamanho varchar(30);")
            End If

            If intVersao <= 398 Then
                Atualizar("Update Config set VersaoNano ='3.9.9'")
                ExecutaSQL("ALTER TABLE Descarte ADD ValorTotal Numeric(15,3);")
                ExecutaSQL("ALTER TABLE Devolucao Alter Column Tamanho varchar(30);")
            End If

            If intVersao <= 399 Then
                Atualizar("Update Config set VersaoNano ='4.0.0'")
            End If

            If intVersao <= 400 Then
                Atualizar("Update Config set VersaoNano ='4.0.1'")
            End If

            If intVersao <= 401 Then
                Atualizar("Update Config set VersaoNano ='4.0.2'")
            End If

            If intVersao <= 402 Then
                Atualizar("Update Config set VersaoNano ='4.0.3'")
            End If

            If intVersao <= 403 Then
                Atualizar("Update Config set VersaoNano ='4.0.4'")
                ExecutaSQL("ALTER TABLE TotalEntradaNF ADD CTPagarOk Bit;")
                Atualizar("Update TotalEntradaNF set CTPagarOk ='False' where CTPagarOk is null")

                If ExisteTabela("RespostasCHL") = False Then
                    ExecutaSQL("CREATE TABLE RespostasCHL(" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey105 PRIMARY KEY," & _
                    "CodSubCat Integer," & _
                    "Resposta varchar(150)," & _
                    "Icone image," & _
                    "CodProd Integer);")
                End If
     
                If ExisteTabela("SubCategoria") = False Then
                    ExecutaSQL("CREATE TABLE SubCategoria(" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey106 PRIMARY KEY," & _
                    "CodCategoria Integer," & _
                    "Descricao varchar(150)," & _
                    "Icone image);")
                End If

                If ExisteTabela("Categoria") = False Then
                    ExecutaSQL("CREATE TABLE Categoria(" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey107 PRIMARY KEY," & _
                    "CodConfig Integer," & _
                    "Descricao varchar(150)," & _
                    "Icone image);")
                End If
                If ExisteTabela("TotalCheckList") = False Then
                    ExecutaSQL("CREATE TABLE TotalCheckList(" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey108 PRIMARY KEY," & _
                    "CodOrdens Integer," & _
                    "CodCli Integer," & _
                    "CodCarro Integer," & _
                    "Data SmallDateTime," & _
                    "CodConfig Integer," & _
                    "Foto1 image," & _
                    "Foto2 image," & _
                    "Foto3 image," & _
                    "Foto4 image," & _
                    "Foto5 image," & _
                    "Assinatura image);")
                End If
                If ExisteTabela("ItensCheckList") = False Then
                    ExecutaSQL("CREATE TABLE ItensCheckList(" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey109 PRIMARY KEY," & _
                    "CodOrdens Integer," & _
                    "CodResposta Integer," & _
                    "Foto image," & _
                    "CheckOk bit);")
                End If

                ExecutaSQL("ALTER TABLE TotalConsig ADD Assinatura image;")
                ExecutaSQL("ALTER TABLE TotalConsig ADD CheckList integer;")
            End If

            If intVersao <= 404 Then
                Atualizar("Update Config set VersaoNano ='4.0.5'")
            End If

            If intVersao <= 405 Then
                Atualizar("Update Config set VersaoNano ='4.0.6'")
            End If

            If intVersao <= 406 Then
                Atualizar("Update Config set VersaoNano ='4.0.7'")
                ExecutaSQL("ALTER TABLE ItensCheckList ADD CodConfig Integer;")
            End If

            If intVersao <= 407 Then
                Atualizar("Update Config set VersaoNano ='4.0.8'")
            End If

            If intVersao <= 408 Then
                Atualizar("Update Config set VersaoNano ='4.0.9'")
            End If

            If intVersao <= 409 Then
                Atualizar("Update Config set VersaoNano ='4.1.0'")
                ExecutaSQL("ALTER TABLE Config ADD Imagem1 image;")
                ExecutaSQL("ALTER TABLE Config ADD Imagem2 image;")
            End If

            If intVersao <= 410 Then
                Atualizar("Update Config set VersaoNano ='4.1.1'")
                ExecutaSQL("ALTER TABLE Config ADD EmailConsultoria varchar(150);")
            End If

            If intVersao <= 411 Then
                Atualizar("Update Config set VersaoNano ='4.1.2'")
            End If

            If intVersao <= 412 Then
                Atualizar("Update Config set VersaoNano ='4.1.3'")
            End If

            If intVersao <= 413 Then
                Atualizar("Update Config set VersaoNano ='4.1.4'")
                ExecutaSQL("ALTER TABLE Config ADD SaldoCaixa bit;")

                Try
                    Dim dt As DataTable = CarregarDataTable("SELECT Top 1 Codigo FROM Caixa")
                    If dt.Rows.Count > 0 Then
                        Atualizar("Update Config set SaldoCaixa ='True'")
                    Else
                        Atualizar("Update Config set SaldoCaixa ='False'")
                    End If
                Catch ex As Exception
                    Atualizar("Update Config set SaldoCaixa ='False'")
                End Try
            End If

            If intVersao <= 414 Then
                Atualizar("Update Config set VersaoNano ='4.1.5'")

                'ExecutaSQL("Delete FROM Bloqueios")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Vender','Vendas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Cliente','Lucro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Fornecedor','Gráficos')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Produtos','Recebimentos Totais')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Funcionarios','Recebimentos Cartões')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pagamentos','Contas Recebidas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Entrada de NF','Contas Pagas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Contas a Receber','Totais Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Contas a Pagar','Itens Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Caixa','Devolução')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Devolução','Consumo')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Descartes','Visão')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Saldo Atual Caixa','Descarte')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pedidos','Giro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Banco','Inadimplência')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar NF-e','Sat')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Transportadora','Transferência')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Controle de Cheque','Inventário')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Inventário','Fluxo de Caixa')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Ativar Produto','Pedidos')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Altera Valores Produto','Pedidos de Compra')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('MDI Analyser','Campanhas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Consultar Produtos','Desempenho')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerar Boleto','DRE')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Saldo Atual Caixa Dinheiro','Rel. Customizado')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Excluir Vendas','Comanda')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Estoque Negativo','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Produtos em Falta','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Transferencia de Produto','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pedidos de Compra','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Campanhas','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Bloquear Desconto Porc. por Itens','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Relatório Vendas Tela de Venda','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Bloqueio de Usuário','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Relatórios de Caixa','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastro de Usuários','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Pedido','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Alterar Pedido','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Consultar Pedido','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Comanda','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Botão Abrir Gaveta','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Kit','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Bloquear Data Caixa','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Desfaturar Pedido','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Excluir Pedido','')")

                ExecutaSQL("CREATE FUNCTION [dbo].[FuncCodigoBarra] (" & _
                "@CodigoProduto INT)" & _
                "RETURNS VARCHAR(1000) " & _
                "AS " & _
                "BEGIN " & _
                "DECLARE @result VARCHAR(1000) " & _
                "SELECT @result = ISNULL(@result + ' / ', '') + CodigoBarra " & _
                "FROM CodigoBarra WHERE CodProd = @CodigoProduto and Produto is null or " & _
                "CodProd = @CodigoProduto and Produto = '' " & _
                "RETURN @result " & _
                "END")

                ExecutaSQL("ALTER TABLE Email ADD Copia Varchar(200);")
                ExecutaSQL("ALTER TABLE Boleto Alter Column SeuNumero Varchar(200);", False)

            End If

            If intVersao <= 415 Then
                Atualizar("Update Config set VersaoNano ='4.1.6'")
            End If

            If intVersao <= 416 Then
                Atualizar("Update Config set VersaoNano ='4.1.7'")
                ExecutaSQL("ALTER TABLE Cliente ADD EnderecoEntrega Varchar(150);")
                ExecutaSQL("ALTER TABLE Cliente ADD NumeroEntrega Varchar(10);")
                ExecutaSQL("ALTER TABLE Cliente ADD ComplementoEntrega Varchar(75);")
                ExecutaSQL("ALTER TABLE Cliente ADD BairroEntrega Varchar(100);")
                ExecutaSQL("ALTER TABLE Cliente ADD CepEntrega Varchar(20);")
                ExecutaSQL("ALTER TABLE Cliente ADD CidadeEntrega Varchar(80);")
                ExecutaSQL("ALTER TABLE Cliente ADD EstadoEntrega Varchar(40);")
                ExecutaSQL("ALTER TABLE Produto ADD QtdEmb Numeric(15,7);")
                'Atualizar("Update Produto set QtdEmb=0")
            End If

            If intVersao <= 417 Then
                Atualizar("Update Config set VersaoNano ='4.1.8'")
                ExecutaSQL("ALTER TABLE Config ADD CampoPedido Varchar(30);")
                Atualizar("Update Config set CampoPedido='' where CampoPedido is null")
                ExecutaSQL("ALTER TABLE ItensConsig ADD CampoPedido Varchar(MAX);")
                Atualizar("Update ItensConsig set CampoPedido='' where CampoPedido is null")
                ExecutaSQL("ALTER TABLE TotalEntradaNF ADD Chave Varchar(50);")
                Atualizar("ALTER TABLE ConfigNFe ADD VerProcNFSe Varchar (5)")
                Atualizar("Update ConfigNFe set VerProcNFSe ='1.0.0' where VerProcNFSe is null")
                ExecutaSQL("ALTER TABLE Config ADD NfseNano bit;")
                Atualizar("Update Config set NfseNano = 'False' where NfseNano is null")
            End If

            If intVersao <= 418 Then
                Atualizar("Update Config set VersaoNano ='4.1.9'")

                'ExecutaSQL("Delete FROM Bloqueios")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Vender','Vendas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Cliente','Lucro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Fornecedor','Gráficos')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Produtos','Recebimentos Totais')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Funcionarios','Recebimentos Cartões')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pagamentos','Contas Recebidas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Entrada de NF','Contas Pagas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Contas a Receber','Totais Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Contas a Pagar','Itens Entrada NF')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Caixa','Devolução')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Devolução','Consumo')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Descartes','Visão')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Saldo Atual Caixa','Descarte')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pedidos','Giro')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Banco','Inadimplência')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar NF-e','Sat')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Transportadora','Transferência')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Controle de Cheque','Inventário')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Inventário','Fluxo de Caixa')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Ativar Produto','Pedidos')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Altera Valores Produto','Pedidos de Compra')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('MDI Analyser','Campanhas')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Consultar Produtos','Desempenho')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerar Boleto','DRE')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Saldo Atual Caixa Dinheiro','Rel. Customizado')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Excluir Vendas','Comanda')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Estoque Negativo','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Produtos em Falta','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Transferencia de Produto','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pedidos de Compra','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Campanhas','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Bloquear Desconto Porc. por Itens','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Relatório Vendas Tela de Venda','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Bloqueio de Usuário','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Relatórios de Caixa','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastro de Usuários','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Pedido','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Alterar Pedido','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Consultar Pedido','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Comanda','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Botão Abrir Gaveta','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Kit','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Bloquear Data Caixa','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Desfaturar Pedido','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Excluir Pedido','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar NFS-e','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Excluir Lançamento Bancário','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Bloqueio Movimento Bancário','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Bloqueio Transferência Bancário','')")
                'ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Bloqueio Comissão','')")
            End If

            If intVersao <= 419 Then
                Atualizar("Update Config set VersaoNano ='4.2.0'")
                ExecutaSQL("ALTER TABLE EntradaNF Alter Column Tamanho varchar(30);")
                ExecutaSQL("ALTER TABLE ItensConsig Alter Column Tamanho varchar(30);")
                ExecutaSQL("ALTER TABLE Transferencia Alter Column Tamanho varchar(30);")
            End If

            If intVersao <= 420 Then
                Atualizar("Update Config set VersaoNano ='4.2.1'")
            End If

            If intVersao <= 421 Then
                Atualizar("Update Config set VersaoNano ='4.2.2'")
            End If

            If intVersao <= 422 Then
                Atualizar("Update Config set VersaoNano ='4.2.3'")
            End If

            If intVersao <= 423 Then
                Atualizar("Update Config set VersaoNano ='4.2.4'")
                Atualizar("ALTER TABLE Config ADD CalcImpProd bit")
                Atualizar("Update Config set CalcImpProd ='True' where CalcImpProd is null")
                Atualizar("ALTER TABLE TotalEntradaNF ADD CalcImpProd bit")
                Atualizar("Update TotalEntradaNF set CalcImpProd ='False' where CalcImpProd is null")
                'Try
                '    Atualizar("Update TotalEntradaNF set CalcImpProd ='True' where Data >='28/01/2020'")
                'Catch ex As Exception
                'End Try
            End If

            If intVersao <= 424 Then
                Atualizar("Update Config set VersaoNano ='4.2.5'")
            End If

            If intVersao <= 425 Then
                Atualizar("Update Config set VersaoNano ='4.2.6'")
                'Try
                '    Atualizar("Update TotalEntradaNF set CalcImpProd ='True' where CalcImpProd is null")
                'Catch ex As Exception
                'End Try
            End If

            If intVersao <= 426 Then
                Atualizar("Update Config set VersaoNano ='4.2.7'")
                Atualizar("ALTER TABLE Config ADD ManterMargemProd bit")
                Atualizar("Update Config set ManterMargemProd ='False' where ManterMargemProd is null")
                Try
                    Atualizar("Update Funcionario set ComServ = '0' where ComServ is null or ComServ = ''")
                Catch ex As Exception
                End Try
            End If

            If intVersao <= 427 Then
                Atualizar("Update Config set VersaoNano ='4.2.8'")
            End If

            If intVersao <= 428 Then
                Atualizar("Update Config set VersaoNano ='4.2.9'")
                Atualizar("ALTER TABLE Config ADD FreteMinimo Numeric(15,3)")
                Atualizar("ALTER TABLE Config ADD PorcentagemFrete Numeric(15,3)")
                Atualizar("Update Config set FreteMinimo = 0 where FreteMinimo is null")
                Atualizar("Update Config set PorcentagemFrete = 0 where PorcentagemFrete is null")
                Atualizar("ALTER TABLE TotalConsig ADD ValorFrete Numeric(15,3)")
            End If

            If intVersao <= 429 Then
                Atualizar("Update Config set VersaoNano ='4.3.0'")
                Atualizar("ALTER TABLE Total ADD TotalFrete Numeric(15,3)")
                Atualizar("ALTER TABLE Pedido ADD ValorFrete Numeric(15,3)")
            End If

            If intVersao <= 430 Then
                Atualizar("Update Config set VersaoNano ='4.3.1'")
            End If

            If intVersao <= 431 Then
                Atualizar("Update Config set VersaoNano ='4.3.2'")
            End If

            If intVersao <= 432 Then
                Atualizar("Update Config set VersaoNano ='4.3.3'")
            End If

            If intVersao <= 433 Then
                Atualizar("Update Config set VersaoNano ='4.3.4'")
            End If

            If intVersao <= 434 Then
                Atualizar("Update Config set VersaoNano ='4.3.5'")
            End If

            If intVersao <= 435 Then
                Atualizar("Update Config set VersaoNano ='4.3.6'")
            End If

            If intVersao <= 436 Then
                Atualizar("Update Config set VersaoNano ='4.3.7'")
            End If

            If intVersao <= 437 Then
                Atualizar("Update Config set VersaoNano ='4.3.8'")
                ExecutaSQL("ALTER TABLE Comanda ADD Imagem1 Image;")
                ExecutaSQL("ALTER TABLE EntradaNF ADD VFCPST Varchar(15);")
            End If

            If intVersao <= 438 Then
                Atualizar("Update Config set VersaoNano ='4.3.9'")
                ExecutaSQL("ALTER TABLE EntradaNF ADD FreteEnt Varchar(15);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD DespesasEnt Varchar(15);")
                ExecutaSQL("ALTER TABLE EntradaNF ADD SeguroEnt Varchar(15);")

            End If

            If intVersao <= 439 Then
                Atualizar("Update Config set VersaoNano ='4.4.0'")
                If ExisteTabela("VincProdOpc") = False Then
                    ExecutaSQL("CREATE TABLE VincProdOpc(" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey110 PRIMARY KEY," & _
                    "CodProd Integer," & _
                    "CodOpc Integer);")
                End If
                ExecutaSQL("Alter Table Grupo ADD Imagem Image;")
            End If

            If intVersao <= 440 Then
                Atualizar("Update Config set VersaoNano ='4.4.1'")
            End If

            If intVersao <= 441 Then
                Atualizar("Update Config set VersaoNano ='4.4.2'")
            End If

            If intVersao <= 442 Then
                Atualizar("Update Config set VersaoNano ='4.4.3'")
                ExecutaSQL("ALTER TABLE Comanda ADD Mesa varchar(10);")
            End If

            If intVersao <= 443 Then
                Atualizar("Update Config set VersaoNano ='4.4.4'")
                ExecutaSQL("ALTER TABLE Total ADD CodNFe Integer;", False)
            End If

            If intVersao <= 444 Then
                Atualizar("Update Config set VersaoNano ='4.4.5'")
                ExecutaSQL("ALTER TABLE Config ADD AbrirFecharCaixa bit;")
                Atualizar("Update Config set AbrirFecharCaixa = 'False' where AbrirFecharCaixa is null")
                ExecutaSQL("If not exists(Select Nome from Grupo where Nome = 'ABERTURA CAIXA')  INSERT INTO Grupo(Nome, Tipo, Impressora) VALUES ('ABERTURA CAIXA','R','C')")
                ExecutaSQL("If not exists(Select Nome from Grupo where Nome = 'FECHAMENTO CAIXA')  INSERT INTO Grupo(Nome, Tipo, Impressora) VALUES ('FECHAMENTO CAIXA','R','D')")
            End If

            If intVersao <= 445 Then
                Atualizar("Update Config set VersaoNano ='4.4.6'")
            End If

            If intVersao <= 446 Then
                Atualizar("Update Config set VersaoNano ='4.4.7'")
            End If

            If intVersao <= 447 Then
                Atualizar("Update Config set VersaoNano ='4.4.8'")
                ExecutaSQL("ALTER TABLE Pedido ADD TabelaPreco varchar(80);")
                ExecutaSQL("ALTER TABLE ItensConsig ADD TabelaPreco varchar(80);")
                ExecutaSQL("ALTER TABLE Comanda ADD TabelaPreco varchar(80);")
            End If

            If intVersao <= 448 Then
                Atualizar("Update Config set VersaoNano ='4.4.9'")
            End If

            If intVersao <= 449 Then
                Atualizar("Update Config set VersaoNano ='4.5.0'")
            End If

            If intVersao <= 450 Then
                Atualizar("Update Config set VersaoNano ='4.5.1'")
                ExecutaSQL("ALTER TABLE Config ADD TabelaPrecoItem bit;")
                Atualizar("Update Config set TabelaPrecoItem = 'True' where TabelaPrecoItem is null")
                ExecutaSQL("ALTER TABLE TotalConsig ADD CodNFe Integer;", False)
                ExecutaSQL("ALTER TABLE TotalConsig ADD AuxiliarPed varchar(100);")
                ExecutaSQL("ALTER TABLE ItensConsig ADD AuxiliarPed varchar(100);")
                ExecutaSQL("ALTER TABLE Qtde ADD QtdMaxima Numeric(15,3);")
                ExecutaSQL("ALTER TABLE Total ADD Operador varchar(80);")
                ExecutaSQL("ALTER TABLE TotalConsig ADD Operador varchar(80);")
            End If

            If intVersao <= 451 Then

                Atualizar("Update Config set VersaoNano ='4.5.2'")
                ExecutaSQL("ALTER TABLE Config ADD ValePresente bit;")
                Atualizar("Update Config set ValePresente = 'False' where ValePresente is null")

                ExecutaSQL("Delete FROM Bloqueios")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Vender','Vendas')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Cliente','Lucro')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Fornecedor','Gráficos')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Produtos','Recebimentos Totais')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Funcionarios','Recebimentos Cartões')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pagamentos','Contas Recebidas')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Entrada de NF','Contas Pagas')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Contas a Receber','Totais Entrada NF')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Contas a Pagar','Itens Entrada NF')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Caixa','Devolução')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Devolução','Consumo')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Descartes','Visão')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Saldo Atual Caixa','Descarte')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pedidos','Giro')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Banco','Inadimplência')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar NF-e','Sat')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Transportadora','Transferência')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Controle de Cheque','Inventário')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Inventário','Fluxo de Caixa')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Ativar Produto','Pedidos')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Altera Valores Produto','Pedidos de Compra')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('MDI Analyser','Campanhas')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Consultar Produtos','Desempenho')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerar Boleto','DRE')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Saldo Atual Caixa Dinheiro','Rel. Customizado')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Excluir Vendas','Comanda')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Estoque Negativo','')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Produtos em Falta','')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Transferencia de Produto','')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Pedidos de Compra','')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Campanhas','')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Bloquear Desconto Porc. por Itens','')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Relatório Vendas Tela de Venda','')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Bloqueio de Usuário','')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Relatórios de Caixa','')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastro de Usuários','')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Cadastrar Pedido','')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Alterar Pedido','')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Consultar Pedido','')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Comanda','')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Botão Abrir Gaveta','')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar Kit','')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Bloquear Data Caixa','')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Desfaturar Pedido','')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Excluir Pedido','')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Gerenciar NFS-e','')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Excluir Lançamento Bancário','')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Bloqueio Movimento Bancário','')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Bloqueio Transferência Bancário','')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Bloqueio Comissão','')")
                ExecutaSQL("Insert Into Bloqueios (Principal, Relatorios) Values ('Bloqueio Não Permitir Estoque Zerado','')")
            End If

            If intVersao <= 452 Then

                Atualizar("Update Config set VersaoNano ='4.5.3'")
                ExecutaSQL("ALTER TABLE Config ADD TotalPendenciaImp bit;")
                Atualizar("Update Config set TotalPendenciaImp = 'True' where TotalPendenciaImp is null")

                ExecutaSQL("ALTER TABLE Banco ADD Instrucao2 varchar(MAX);", False)
                ExecutaSQL("ALTER TABLE Banco ADD Instrucao varchar(MAX);", False)
                ExecutaSQL("ALTER TABLE Banco ADD Recibo Bit;", False)
                Atualizar("Update Banco set Recibo ='False' where Recibo is null")
                ExecutaSQL("ALTER TABLE Banco ADD TipoAmbiente varchar(20);", False)
                Atualizar("Update Banco set TipoAmbiente ='PRODUÇÃO'")
            End If

            clsHistorico.Historico()

        Catch ex As Exception
        End Try

    End Function
End Class
