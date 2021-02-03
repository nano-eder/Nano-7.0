Imports Nano.clsFuncoes
Imports System
Imports System.Drawing
Imports System.Data
Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class frmMigrarAutomotivo

    Dim strTabela As String
    Dim strNomeBanco As String

    Public Shared Sub Main()
        Application.Run(New frmMigracao())
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.rtbMens.ResetText()
        Dim strUsarNfe As String = Me.rgpNfe.SelectedIndex.ToString
        Dim strBoleto As String = Me.rgpBoleto.SelectedIndex.ToString

        Me.Cursor = Cursors.WaitCursor
        Dim dt As DataTable = Nothing
        Dim I, B As Integer
        B = 1

        If strNomeBanco = "" Then
            MsgBox("SELECIONE UM BANCO!", MsgBoxStyle.Information)
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        Dim Query As String = ""
        Dim bolPassou As Boolean = False
        Dim count As Integer = 0


        '**********CLIENTE**********
        Me.lblTabAtual.Text = "Cliente"
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Cliente order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString
            Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
            Dim strCPF As String = dt.Rows.Item(I).Item("CPF").ToString

            If strCPF <> "000.000.000-00" Then

                Dim strRG As String = dt.Rows.Item(I).Item("RG").ToString
                Dim strEnd As String = dt.Rows.Item(I).Item("Endereco").ToString
                Dim strNum As String = dt.Rows.Item(I).Item("Numero").ToString
                Dim strComp As String = dt.Rows.Item(I).Item("Complemento").ToString
                Dim strBairro As String = dt.Rows.Item(I).Item("Bairro").ToString
                Dim strCep As String = dt.Rows.Item(I).Item("Cep").ToString
                Dim strCidade As String = dt.Rows.Item(I).Item("Cidade").ToString
                Dim strUF As String = dt.Rows.Item(I).Item("Estado").ToString
                Dim strTel As String = dt.Rows.Item(I).Item("Telefone").ToString.Replace("*", "").Replace(" ", "").Trim()
                Dim strFax As String = dt.Rows.Item(I).Item("Fax").ToString.Replace("*", "").Replace(" ", "").Trim()
                Dim strCel As String = dt.Rows.Item(I).Item("Celular").ToString.Replace("*", "").Replace(" ", "").Trim()
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
                Dim strP1 As String = strCodigo '""
                Dim strP2 As String = ""
                Dim strRG1 As String = ""
                Dim strRG2 As String = ""
                Dim bolInativo As Boolean = False
                Dim strSuframa As String = ""
                Dim strCodMunicipio As String = dt.Rows.Item(I).Item("CodMunicipio").ToString
                Dim strCodPais As String = dt.Rows.Item(I).Item("CodPais").ToString
                Dim strNomePais As String = dt.Rows.Item(I).Item("NomePais").ToString

                Dim strCadastro As String = ""
                Try
                    strCadastro = CodUser & " " & NomeComputador.ToUpper & " " & Format(My.Computer.Clock.LocalTime, "dd/MM/yyyy HH:mm:ss")
                Catch ex As Exception
                    strCadastro = CodUser & " " & NomeComputador.ToUpper & " " & Date.Today.Day & "/" & Date.Today.Month & "/" & Date.Today.Year & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now)
                End Try



                If bolPassou = False Then
                    Query = "INSERT INTO Cliente (Nome, RGIE, CPF, Endereco, Telefone, Fax, Celular, Email, " & _
                    "Data, Numero, Complemento, Bairro, Cep, Cidade, Estado, Fantasia, Inadimplente, Observacao, " & _
                    "Status, Nascimento, Sexo, Limite, Empresa, TelEmpresa, Salario, Credito, Marcas, CodConfig, " & _
                    "Pessoa1, Pessoa2, RG1, RG2, Inativo, Suframa, CodMunicipio, CodPais, NomePais, Desconto, Agencia, " & _
                    "ContaCorrente, Banco, Contato, Cadastro) VALUES (" & _
                    "'" & strNome.Replace("'", "´") & "','" & strRG & "','" & strCPF & "'," & _
                    "'" & strEnd.Replace("'", "´") & "','" & strTel & "','" & strFax & "','" & strCel & "'," & _
                    "'" & strEmail & "','" & strData & "','" & strNum & "','" & strComp.Replace("'", "´") & "'," & _
                    "'" & strBairro.Replace("'", "´") & "','" & strCep & "','" & strCidade.Replace("'", "´") & "'," & _
                    "'" & strUF & "','" & strFant.Replace("'", "´") & "','" & bolIna & "','" & strObs.Replace("'", "´") & "'," & _
                    "'" & strStatus & "','" & strNasc & "','" & strSexo & "','" & strLimite & "','" & strEmpresa.Replace("'", "´") & "'," & _
                    "'" & strTelEmp & "','" & strSalario & "','" & strCredito & "','" & strMarca & "'," & strCodConfig & "," & _
                    "'" & strP1 & "','" & strP2 & "','" & strRG1 & "','" & strRG2 & "','" & bolInativo & "'," & _
                    "'" & strSuframa & "','" & strCodMunicipio & "'," & _
                    "'" & strCodPais & "','" & strNomePais & "',0,'','','','','" & strCadastro.Trim & "');"

                    'Inserir(Query)
                    bolPassou = True
                Else
                    'System.Threading.Thread.Sleep(20)
                    Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Cliente (Nome, RGIE, CPF, Endereco, Telefone, Fax, Celular, Email, " & _
                    "Data, Numero, Complemento, Bairro, Cep, Cidade, Estado, Fantasia, Inadimplente, Observacao, " & _
                    "Status, Nascimento, Sexo, Limite, Empresa, TelEmpresa, Salario, Credito, Marcas, CodConfig, " & _
                    "Pessoa1, Pessoa2, RG1, RG2, Inativo, Suframa, CodMunicipio, CodPais, NomePais, Desconto, Agencia, " & _
                    "ContaCorrente, Banco, Contato, Cadastro) VALUES (" & _
                    "'" & strNome.Replace("'", "´") & "','" & strRG & "','" & strCPF & "'," & _
                    "'" & strEnd.Replace("'", "´") & "','" & strTel & "','" & strFax & "','" & strCel & "'," & _
                    "'" & strEmail & "','" & strData & "','" & strNum & "','" & strComp.Replace("'", "´") & "'," & _
                    "'" & strBairro.Replace("'", "´") & "','" & strCep & "','" & strCidade.Replace("'", "´") & "'," & _
                    "'" & strUF & "','" & strFant.Replace("'", "´") & "','" & bolIna & "','" & strObs.Replace("'", "´") & "'," & _
                    "'" & strStatus & "','" & strNasc & "','" & strSexo & "','" & strLimite & "','" & strEmpresa.Replace("'", "´") & "'," & _
                    "'" & strTelEmp & "','" & strSalario & "','" & strCredito & "','" & strMarca & "'," & strCodConfig & "," & _
                    "'" & strP1 & "','" & strP2 & "','" & strRG1 & "','" & strRG2 & "','" & bolInativo & "'," & _
                    "'" & strSuframa & "','" & strCodMunicipio & "'," & _
                    "'" & strCodPais & "','" & strNomePais & "',0,'','','','','" & strCadastro.Trim & "');"
                End If

                count = count + 1
                If count = 500 Then
                    Inserir(Query)
                    System.Threading.Thread.Sleep(40)


                    Query = ""
                    count = 0
                End If

                LogDeErro()
            End If
            B += 1

        Next
        strTabela = "Cliente"
        Me.lblTabAtual.Text = "Carro"
        BarraProdgresso()


        If Query <> "" Then
            Inserir(Query)
        End If

        Query = ""
        bolPassou = False
        count = 0


        '**********CARRO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Carro order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1

            Dim Codigo As String = dt.Rows.Item(I).Item("Codigo").ToString
            Dim strPlaca As String = dt.Rows.Item(I).Item("Placa").ToString
            Dim strModelo As String = dt.Rows.Item(I).Item("Modelo").ToString.Replace("'", "´")
            Dim strCor As String = dt.Rows.Item(I).Item("Cor").ToString.Replace("'", "´")
            Dim strAno As String = dt.Rows.Item(I).Item("Ano").ToString
            Dim strKM As String = dt.Rows.Item(I).Item("KM").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strFabricante As String = dt.Rows.Item(I).Item("Fabricante").ToString.Replace("'", "´")
            Dim strCombustivel As String = dt.Rows.Item(I).Item("Combustivel").ToString.Replace("'", "´")
            Dim strMotor As String = dt.Rows.Item(I).Item("Motor").ToString.Replace("'", "´")
            Dim strCilindros As String = dt.Rows.Item(I).Item("Cilindros").ToString.Replace("'", "´")
            Dim strValvulas As String = dt.Rows.Item(I).Item("Valvulas").ToString.Replace("'", "´")
            Dim strChassi As String = dt.Rows.Item(I).Item("CPFCliente").ToString
            Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString.Replace("'", "´")
            Dim strOpcionais As String = dt.Rows.Item(I).Item("Opcionais").ToString.Replace("'", "´")
            Dim strKMMes As String = dt.Rows.Item(I).Item("KMMes").ToString.Replace("'", "´")
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString



            If bolPassou = False Then
                Query = "INSERT INTO Carro (Placa, Modelo, Cor, Ano, KM, Data, Fabricante, Combustivel, " & _
                "Motor, Cilindros, Valvulas, Chassi, Obs, Opcionais, KMMes, CodConfig) " & _
                "VALUES ('" & strPlaca & "','" & strModelo & "','" & strCor & "','" & strAno & "'," & _
                "'" & strKM & "','" & strData & "','" & strFabricante & "','" & strCombustivel & "'," & _
                "'" & strMotor & "','" & strCilindros & "','" & strValvulas & "','" & strChassi & "'," & _
                "'" & strObs & "','" & strOpcionais & "','" & strKMMes & "','" & strCodConfig & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Carro (Placa, Modelo, Cor, Ano, " & _
                "KM, Data, Fabricante, Combustivel, " & _
                "Motor, Cilindros, Valvulas, Chassi, Obs, Opcionais, KMMes, CodConfig) " & _
                "VALUES ('" & strPlaca & "','" & strModelo & "','" & strCor & "','" & strAno & "'," & _
                "'" & strKM & "','" & strData & "','" & strFabricante & "','" & strCombustivel & "'," & _
                "'" & strMotor & "','" & strCilindros & "','" & strValvulas & "','" & strChassi & "'," & _
                "'" & strObs & "','" & strOpcionais & "','" & strKMMes & "','" & strCodConfig & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)


                Query = ""
                count = 0
            End If

            LogDeErro()
            B += 1
        Next

        If Query <> "" Then
            Inserir(Query)
        End If
        Inserir("Update Carro set CodCli=Cliente.Codigo From Carro left Join Cliente on Carro.Chassi=Cliente.CPF")
        Inserir("Update Carro set Chassi='' Where CodCli is not null")
        strTabela = "Carro"
        Me.lblTabAtual.Text = "Fornecedor"
        BarraProdgresso()

        Query = ""
        bolPassou = False
        count = 0


        '**********FORNECEDOR**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Fornecedor order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString.Replace("'", "´")
            Dim strCPF As String = dt.Rows.Item(I).Item("CPF").ToString
            Dim strEnd As String = dt.Rows.Item(I).Item("Endereco").ToString
            Dim strNum As String = dt.Rows.Item(I).Item("Numero").ToString
            Dim strComp As String = dt.Rows.Item(I).Item("Complemento").ToString
            Dim strBairro As String = dt.Rows.Item(I).Item("Bairro").ToString
            Dim strCep As String = dt.Rows.Item(I).Item("Cep").ToString
            Dim strCidade As String = dt.Rows.Item(I).Item("Cidade").ToString
            Dim strUF As String = dt.Rows.Item(I).Item("Estado").ToString
            Dim strTelefone As String = dt.Rows.Item(I).Item("Telefone").ToString.Replace("*", "").Replace(" ", "").Trim()
            Dim strFax As String = dt.Rows.Item(I).Item("Fax").ToString.Replace("*", "").Replace(" ", "").Trim()
            Dim strCelular As String = dt.Rows.Item(I).Item("Celular").ToString.Replace("*", "").Replace(" ", "").Trim()
            Dim strEmail As String = dt.Rows.Item(I).Item("Email").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString

            Dim strIE As String = dt.Rows.Item(I).Item("IE").ToString
            Dim strContato As String = strCodigo 'dt.Rows.Item(I).Item("Contato").ToString

            Dim strSite As String = dt.Rows.Item(I).Item("Site").ToString
            Dim strFantasia As String = dt.Rows.Item(I).Item("Fantasia").ToString
            Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
            Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString

            Dim strCodConfig As String = "1"
            Dim strTipo As String = dt.Rows.Item(I).Item("Tipo").ToString
            Dim strCodMunicipio As String = dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strCodPais As String = dt.Rows.Item(I).Item("CodPais").ToString
            Dim strNomePais As String = dt.Rows.Item(I).Item("NomePais").ToString
            Dim strNasc As String = dt.Rows.Item(I).Item("Nascimento").ToString



            If bolPassou = False Then
                Query = "INSERT INTO Fornecedor (Nome, CPF, Endereco, Numero, Complemento, Bairro, Cep, Cidade, " & _
                "Estado, Telefone, Fax, Celular, Email, Data, IE, Contato, Site, Fantasia, Status, Obs, CodConfig, " & _
                "Tipo, CodMunicipio, CodPais, NomePais, Inativo, Nascimento) VALUES ('" & strNome & "','" & strCPF & "','" & strEnd & "'," & _
                "'" & strNum & "','" & strComp & "','" & strBairro & "','" & strCep & "','" & strCidade & "'," & _
                "'" & strUF & "','" & strTelefone & "','" & strFax & "','" & strCelular & "','" & strEmail & "'," & _
                "'" & strData & "','" & strIE & "','" & strContato & "','" & strSite & "','" & strFantasia & "'," & _
                "'" & strStatus & "','" & strObs & "'," & strCodConfig & ",'" & strTipo & "','" & strCodMunicipio & "'," & _
                "'" & strCodPais & "','" & strNomePais & "','False','" & strNasc & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Fornecedor (Nome, CPF, Endereco, Numero, " & _
                "Complemento, Bairro, Cep, Cidade, Estado, Telefone, Fax, Celular, Email, Data, IE, Contato, " & _
                "Site, Fantasia, Status, Obs, CodConfig, Tipo, CodMunicipio, CodPais, NomePais, Inativo, " & _
                "Nascimento) VALUES ('" & strNome & "','" & strCPF & "','" & strEnd & "'," & _
                "'" & strNum & "','" & strComp & "','" & strBairro & "','" & strCep & "','" & strCidade & "'," & _
                "'" & strUF & "','" & strTelefone & "','" & strFax & "','" & strCelular & "','" & strEmail & "'," & _
                "'" & strData & "','" & strIE & "','" & strContato & "','" & strSite & "','" & strFantasia & "'," & _
                "'" & strStatus & "','" & strObs & "'," & strCodConfig & ",'" & strTipo & "','" & strCodMunicipio & "'," & _
                "'" & strCodPais & "','" & strNomePais & "','False','" & strNasc & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)


                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "Fornecedor"
        Me.lblTabAtual.Text = "Grupo"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********GRUPO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Grupo Where Tipo <> 'U' And Nome <> '' order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString
            Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString

            Dim Result As Integer = 0
            If strNome = "DIVERSOS" Then
                Dim dtGrup As DataTable = CarregarDataTable("Select Count(*) as Result From Grupo Where Nome='" & strNome & "'")

                If dtGrup.Rows.Count > 0 Then
                    Result = dtGrup.Rows.Item(0).Item("Result").ToString
                End If
            End If

            Dim strTipo As String = dt.Rows.Item(I).Item("Tipo").ToString '"G"
            If strTipo = "M" Then
                strTipo = "S"
            End If

            Dim strPortaImpressora As String = ""
            Dim strImpressora As String = ""



            If Result = 0 Then
                If bolPassou = False Then
                    Query = "INSERT INTO Grupo (Nome, Tipo, PortaImpressora, Impressora) Values('" & strNome & "'," & _
                    "'" & strTipo & "','" & strPortaImpressora & "','" & strImpressora & "');"

                    bolPassou = True
                Else
                    Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Grupo (Nome, Tipo, PortaImpressora, Impressora) " & _
                    "Values('" & strNome & "','" & strTipo & "','" & strPortaImpressora & "','" & strImpressora & "');"

                End If

                count = count + 1
                If count = 500 Then
                    Inserir(Query)
                    System.Threading.Thread.Sleep(40)


                    Query = ""
                    count = 0
                End If

            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "Grupo"
        Me.lblTabAtual.Text = "Produto"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********PRODUTO**********
        B = 1
        'dt = CarregarDataTable2("SELECT * FROM Produto Where CodConfig=1 order by CodigoAut", strNomeBanco)
        dt = CarregarDataTable2("SELECT * FROM Produto order by CodigoAut", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As String = dt.Rows.Item(I).Item("Codigo").ToString


            Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString.Replace("'", "´").Trim
            Dim strUnidadeMedida As String = dt.Rows.Item(I).Item("UnidadeMedida").ToString
            If strUnidadeMedida = "UNIDADE" Then
                strUnidadeMedida = "UN"
            ElseIf strUnidadeMedida = "JOGO" Then
                strUnidadeMedida = "JG"
            ElseIf strUnidadeMedida = "KIT" Then
                strUnidadeMedida = "KT"
            ElseIf strUnidadeMedida = "PESO" Then
                strUnidadeMedida = "PS"
            ElseIf strUnidadeMedida = "LÍTRO" Then
                strUnidadeMedida = "LT"
            ElseIf strUnidadeMedida = "METRO" Then
                strUnidadeMedida = "MT"
            ElseIf strUnidadeMedida = "HORA" Then
                strUnidadeMedida = "HR"
            ElseIf strUnidadeMedida = "PAR" Then
                strUnidadeMedida = "PR"
            End If

            Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
            Dim strValorCusto As String = dt.Rows.Item(I).Item("ValorCusto").ToString
            Dim strLocacao As String = dt.Rows.Item(I).Item("CodigoAut").ToString
            Dim strCodigoInterno As String = dt.Rows.Item(I).Item("CodigoPeca").ToString

            Dim vetPor As Array
            Dim strPorcentagens As String
            If dt.Rows.Item(I).Item("Porcentagens").ToString.Contains("|") = True Then
                vetPor = Split(dt.Rows.Item(I).Item("Porcentagens").ToString, "|")
                If vetPor(0).ToString.ToUpper.Contains("NÃO") = True Then
                    strPorcentagens = 0
                Else
                    strPorcentagens = vetPor(0)
                End If
            Else
                strPorcentagens = dt.Rows.Item(I).Item("Porcentagens").ToString()
            End If

            Dim strFabricante As String = dt.Rows.Item(I).Item("Fabricante").ToString.Replace("'", "´").Trim

            Dim strGrupo As String = dt.Rows.Item(I).Item("Grupo").ToString
            If strGrupo = "" Then
                strGrupo = "DIVERSOS"
            End If

            Dim strObs As String = dt.Rows.Item(I).Item("Aplicacao").ToString.Replace("'", "´").Trim
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strCodigoBarra As String = dt.Rows.Item(I).Item("CodigoBarra").ToString
            Dim strNivelComboCodCF As String = dt.Rows.Item(I).Item("NivelComboCodCF").ToString
            Dim strDesconto As String = ""

            Dim strSetor As String = dt.Rows.Item(I).Item("Marca").ToString.Replace("'", "´").Trim
            Dim strTipo As String = dt.Rows.Item(I).Item("TipoProduto").ToString
            If strTipo = "PEÇA" Then
                strTipo = "VENDA"
            End If
            If strTipo = "INTERNO" Then
                strTipo = "CONSUMO"
            End If

            Dim strCodProdFor As String = dt.Rows.Item(I).Item("CodProdFor").ToString.Replace("'", "")
            Dim strComissao As String = 0
            Dim strLocacao2 As String = strCodigo
            Dim strFamilia As String = dt.Rows.Item(I).Item("Qtd").ToString
            Dim strTributacaoPadrao As String = 0
            Dim strAlterarPreco As String = 0

            Dim strPeso As String = 0
            Dim strCodigoFabricante As String = dt.Rows.Item(I).Item("CodigoFabricante").ToString.Replace("'", "´").Trim
            Dim strGarantia As String = dt.Rows.Item(I).Item("Garantia").ToString
            Dim strKM As String = dt.Rows.Item(I).Item("KM").ToString
            Dim strPesoBruto As String = 0

            Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
            Dim strQtdMinima As String = dt.Rows.Item(I).Item("QtdMinima").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strInativo As String = dt.Rows.Item(I).Item("Inativo").ToString


            If bolPassou = False Then
                Query = "INSERT INTO Produto (Nome, UnidadeMedida, Valor, ValorCusto, Locacao, CodigoInterno, " & _
                "Porcentagens, Fabricante, Grupo, Obs, Data, CodigoBarra, NivelComboCodCF, Desconto, Setor, Tipo, " & _
                "Inativo, Validade, CodProdFor, Comissao, Locacao2, Familia, TributacaoPadrao, AlterarPreco, Peso, " & _
                "CodigoFabricante, Garantia, KM, PesoBruto) " & _
                "VALUES ('" & strNome.Replace("'", "´") & "','" & strUnidadeMedida & "'," & Num(strValor) & "," & _
                "" & Num(strValorCusto) & ",'" & strLocacao & "','" & strCodigoInterno & "','" & strPorcentagens & "'," & _
                "'" & strFabricante.Replace("'", "´") & "','" & strGrupo & "','" & strObs.Replace("'", "´") & "'," & _
                "'" & strData & "','" & strCodigoBarra & "','" & strNivelComboCodCF & "'," & Num(strDesconto) & "," & _
                "'" & strSetor & "','" & strTipo & "','" & strInativo & "','01-01-2050','" & strCodProdFor & "'," & Num(strComissao) & "," & _
                "'" & strLocacao2 & "','" & strFamilia & "','" & strTributacaoPadrao & "','" & strAlterarPreco & "'," & _
                "'" & strPeso & "','" & strCodigoFabricante & "','" & strGarantia & "','" & strKM & "','" & strPesoBruto & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Produto (Nome, UnidadeMedida, Valor, " & _
                "ValorCusto, Locacao, CodigoInterno, Porcentagens, Fabricante, Grupo, Obs, Data, CodigoBarra, " & _
                "NivelComboCodCF, Desconto, Setor, Tipo, Inativo, Validade, CodProdFor, Comissao, Locacao2, " & _
                "Familia, TributacaoPadrao, AlterarPreco, Peso, CodigoFabricante, Garantia, KM, PesoBruto) " & _
                "VALUES ('" & strNome.Replace("'", "´") & "','" & strUnidadeMedida & "'," & Num(strValor) & "," & _
                "" & Num(strValorCusto) & ",'" & strLocacao & "','" & strCodigoInterno & "','" & strPorcentagens & "'," & _
                "'" & strFabricante.Replace("'", "´") & "','" & strGrupo & "','" & strObs.Replace("'", "´") & "'," & _
                "'" & strData & "','" & strCodigoBarra & "','" & strNivelComboCodCF & "'," & Num(strDesconto) & "," & _
                "'" & strSetor & "','" & strTipo & "','" & strInativo & "','01-01-2050','" & strCodProdFor & "'," & Num(strComissao) & "," & _
                "'" & strLocacao2 & "','" & strFamilia & "','" & strTributacaoPadrao & "','" & strAlterarPreco & "'," & _
                "'" & strPeso & "','" & strCodigoFabricante & "','" & strGarantia & "','" & strKM & "','" & strPesoBruto & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)


                Query = ""
                count = 0
            End If

            'Dim dtQtd As DataTable = CarregarDataTable("Select Codigo From Produto Where Locacao2='" & strLocacao2 & "'")
            'Dim cod As String
            'If dtQtd.Rows.Count > 0 Then
            '    cod = dtQtd.Rows.Item(0).Item("Codigo").ToString
            '    Inserir("INSERT INTO Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, ValorCusto, Emfalta, " & _
            '    "Acabou, CodConfig, DataFim) Values (" & cod & ",'U'," & Num(strQtdMinima) & "," & Num(strQtd) & "," & _
            '    "'U'," & Num(strValorCusto) & ",0,0," & strCodConfig & ",'01-01-1900')")
            'End If


            B += 1
            LogDeErro()
        Next

        If Query <> "" Then
            Inserir(Query)
        End If
        Inserir("Update Produto set CodigoInterno='00' + CONVERT(varchar(50), Codigo) + '001' Where CodigoInterno ='';")

        Dim intConfig As Integer = Me.ComboBoxEdit1.Properties.Items.Count
        Dim bolPassouQtd As Boolean = False
        Dim strDataQtde As String = Date.Now().ToString("yyyy-dd-MM HH:mm:ss")
        For J As Integer = 0 To intConfig - 1
            If bolPassouQtd = False Then
                Inserir("INSERT INTO Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, ValorCusto, Emfalta, " & _
                "Acabou, CodConfig, DataFim) Select Codigo as CodProd, 'U' as Tamanho, 0 as QtdMinima, " & _
                "case when Familia <> '' then Convert(Numeric(15,3), Replace(Familia, ',','.')) else 0 end as Qtd, " & _
                "'U' As Lote, ValorCusto, 0 as Emfalta, 0 as Acabou, 1 As CodConfig, 1 as CodUser From Produto")

                'Inserir("Insert Into AjusteQtde (CodProd, Qtd, Data, Tabela, CodConfig, CodUser)" & _
                '"Select CodProd, Qtd, '" & strDataQtde & "' As Data, 'QTDE' As Tabela, 1 As CodConfig, " & _
                '"1 as CodUser From Qtde Where CodConfig=1")

                bolPassouQtd = True
            Else
                Dim Con As Integer = J + 1
                Inserir("INSERT INTO Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, ValorCusto, Emfalta, " & _
                "Acabou, CodConfig, DataFim) Select Codigo as CodProd, 'U' as Tamanho, 0 as QtdMinima, " & _
                "0 as Qtd, 'U' As Lote, ValorCusto, 0 as Emfalta, 0 as Acabou, " & Con & " As CodConfig, " & _
                "1 as CodUser From Produto")

                'Inserir("Insert Into AjusteQtde (CodProd, Qtd, Data, Tabela, CodConfig, CodUser)" & _
                '"Select CodProd, 0 as Qtd, '" & strDataQtde & "' As Data, 'QTDE' As Tabela, " & _
                '"" & Con & " As CodConfig, 1 as CodUser From Qtde Where CodConfig=" & Con & "")
            End If
        Next
        strTabela = "Produto"
        Me.lblTabAtual.Text = "AjusteQtde"
        'Me.lblTabAtual.Text = "ImpostoProduto"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        Dim dtConfigAjuste As DataTable = CarregarDataTable2("SELECT * FROM Config order by Codigo", strNomeBanco)
        If dtConfigAjuste.Rows.Count > 0 Then
            Dim strEstoqueSomado As String = dtConfigAjuste.Rows.Item(0).Item("EstoqueSomado").ToString
            If strEstoqueSomado = "True" Then
                '**********AJUSTEQTDE**********
                B = 1
                dt = CarregarDataTable2("SELECT * FROM AjusteQtde order by Codigo", strNomeBanco)
                For I = 0 To dt.Rows.Count - 1

                    Dim strCodProd As Integer = dt.Rows.Item(I).Item("CodProd").ToString
                    Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
                    Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
                    Dim strTabela As String = dt.Rows.Item(I).Item("Tabela").ToString
                    Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
                    Dim strCodUser As String = dt.Rows.Item(I).Item("CodUser").ToString


                    If bolPassou = False Then
                        Query = "INSERT INTO AjusteQtde (CodProd, Qtd, Data, Tabela, CodConfig, CodUser) Values('" & strCodProd & "'," & _
                        "" & Num(strQtd) & ",'" & strData & "','" & strTabela & "'," & strCodConfig & "," & strCodUser & ");"

                        bolPassou = True
                    Else
                        Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO AjusteQtde (CodProd, Qtd, Data, Tabela, " & _
                        "CodConfig, CodUser) Values('" & strCodProd & "'," & _
                        "" & Num(strQtd) & ",'" & strData & "','" & strTabela & "'," & strCodConfig & "," & strCodUser & ");"

                    End If

                    count = count + 1
                    If count = 500 Then
                        Inserir(Query)
                        System.Threading.Thread.Sleep(40)


                        Query = ""
                        count = 0
                    End If

                    B += 1
                    LogDeErro()
                Next
                If Query <> "" Then
                    Inserir(Query)
                End If
                Inserir("Update AjusteQtde Set CodProd=case when Produto.Codigo is not null then Produto.Codigo else 0 end " & _
                "From AjusteQtde Left Join Produto on AjusteQtde.CodProd = Produto.Locacao")
                strTabela = "AjusteQtde"
                Me.lblTabAtual.Text = "ImpostoProduto"
                BarraProdgresso()


                Query = ""
                bolPassou = False
                count = 0
            End If
        End If



        '**********IMPOSTOPRODUTO**********
        B = 1
        'dt = CarregarDataTable2("SELECT * FROM ImpostoProduto Where CodConfig=1 order by Codigo", strNomeBanco)
        dt = CarregarDataTable2("SELECT ImpostoProduto.Codigo, ImpostoProduto.CodProduto, ImpostoProduto.ICMS, " & _
        " ImpostoProduto.IPI, ImpostoProduto.Tributacao, ImpostoProduto.Cst, ImpostoProduto.OrigemICMS, " & _
        " ImpostoProduto.IPPT, ImpostoProduto.Pesavel, ImpostoProduto.TipoFIA from ImpostoProduto Left Join " & _
        " Produto on Produto.CodigoAut=ImpostoProduto.CodProduto Where Produto.CodConfig=1 order by ImpostoProduto.Codigo", strNomeBanco)

        For I = 0 To dt.Rows.Count - 1

            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString
            Dim strCodProd As String = dt.Rows.Item(I).Item("CodProduto").ToString
            Dim strICMS As String = dt.Rows.Item(I).Item("ICMS").ToString
            Dim strIPI As String = dt.Rows.Item(I).Item("IPI").ToString
            Dim strTributacao As String = dt.Rows.Item(I).Item("Tributacao").ToString
            Dim strCst As String = dt.Rows.Item(I).Item("Cst").ToString
            Dim strOrigemICMS As String = dt.Rows.Item(I).Item("OrigemICMS").ToString
            Dim strIPPT As String = dt.Rows.Item(I).Item("IPPT").ToString
            Dim strPesavel As String = dt.Rows.Item(I).Item("Pesavel").ToString
            Dim strTipoFIA As String = dt.Rows.Item(I).Item("TipoFIA").ToString


            Dim dt1 As DataTable = CarregarDataTable("SELECT Codigo FROM Produto where Locacao = " & strCodProd)
            If dt1.Rows.Count > 0 Then
                strCodProd = dt1.Rows.Item(0).Item("Codigo").ToString
            End If


            If bolPassou = False Then
                Query = "INSERT INTO ImpostoProduto (CodProd, ICMS, IPI, Tributacao, Cst, OrigemIcms, " & _
                "IPPT, Pesavel, TipoFIA) Values(" & strCodProd & "," & Num(strICMS) & "," & Num(strIPI) & "," & _
                "'" & strTributacao & "','" & strCst & "','" & strOrigemICMS & "','" & strIPPT & "'," & _
                "'" & strPesavel & "','" & strTipoFIA & "')"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO ImpostoProduto (CodProd, ICMS, IPI, " & _
                "Tributacao, Cst, OrigemIcms, IPPT, Pesavel, TipoFIA) Values(" & strCodProd & "," & _
                "" & Num(strICMS) & "," & Num(strIPI) & ",'" & strTributacao & "','" & strCst & "'," & _
                "'" & strOrigemICMS & "','" & strIPPT & "','" & strPesavel & "','" & strTipoFIA & "')"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If


            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        'Inserir("Update ImpostoProduto Set CodProd=case when Produto.Codigo is not null then Produto.Codigo else 0 end " & _
        '"From ImpostoProduto Left Join Produto on ImpostoProduto.CodProd = Produto.Locacao")
        strTabela = "ImpostoProduto"
        Me.lblTabAtual.Text = "Tributos"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********TRIBUTOS**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Tributos order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString
            Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
            Dim strCSTIPI As String = dt.Rows.Item(I).Item("CSTIPI").ToString
            Dim strPerIPI As String = dt.Rows.Item(I).Item("PerIPI").ToString
            Dim strCodEnq As String = dt.Rows.Item(I).Item("CodEnq").ToString
            Dim strCSTPIS As String = dt.Rows.Item(I).Item("CSTPIS").ToString
            Dim strPerPIS As String = dt.Rows.Item(I).Item("PerPIS").ToString
            Dim strCSTCOFINS As String = dt.Rows.Item(I).Item("CSTCOFINS").ToString
            Dim strPerCOFINS As String = dt.Rows.Item(I).Item("PerCOFINS").ToString
            Dim strRegime As String = "SIMPLES NACIONAL" 'dt.Rows.Item(I).Item("Regime").ToString


            If bolPassou = False Then
                Query = "INSERT INTO Tributos (CodProd, CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, " & _
                "PerCOFINS, Regime) Values(" & strCodProd & ",'" & strCSTIPI & "','" & strPerIPI & "','" & strCodEnq & "'," & _
                "'" & strCSTPIS & "','" & strPerPIS & "','" & strCSTCOFINS & "','" & strPerCOFINS & "','" & strRegime & "')"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Tributos (CodProd, CSTIPI, PerIPI, CodEnq, " & _
                "CSTPIS, PerPIS, CSTCOFINS, PerCOFINS, Regime) Values(" & strCodProd & ",'" & strCSTIPI & "'," & _
                "'" & strPerIPI & "','" & strCodEnq & "','" & strCSTPIS & "','" & strPerPIS & "','" & strCSTCOFINS & "'," & _
                "'" & strPerCOFINS & "','" & strRegime & "')"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If


            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        Inserir("Update Tributos Set CodProd=case when Produto.Codigo is not null then Produto.Codigo else 0 end " & _
        "From Tributos Left Join Produto on Tributos.CodProd = Produto.Locacao")
        strTabela = "Tributos"
        Me.lblTabAtual.Text = "NFE"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********NFE**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Nfe order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString
            'Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
            'Dim strCST As String = dt.Rows.Item(I).Item("CST").ToString
            'Dim strOrigem As String = dt.Rows.Item(I).Item("Origem").ToString
            'Dim strCFOP As String = dt.Rows.Item(I).Item("CFOP").ToString
            'Dim strNCM As String = dt.Rows.Item(I).Item("NCM").ToString
            'Dim strRegime As String = dt.Rows.Item(I).Item("Regime").ToString
            'Dim strCalculoCred As String = dt.Rows.Item(I).Item("CalculoCred").ToString

            Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
            Dim strEXTIPI As String = dt.Rows.Item(I).Item("EXTIPI").ToString
            Dim strGenero As String = dt.Rows.Item(I).Item("Genero").ToString
            Dim strUnidTrib As String = dt.Rows.Item(I).Item("UnidTrib").ToString
            Dim strValTrib As String = dt.Rows.Item(I).Item("ValTrib").ToString
            Dim strQtdTrib As String = dt.Rows.Item(I).Item("QtdTrib").ToString
            Dim strMIPI As String = dt.Rows.Item(I).Item("MIPI").ToString
            Dim strQtdN As String = dt.Rows.Item(I).Item("QtdN").ToString
            Dim strCST As String = dt.Rows.Item(I).Item("CST").ToString
            Dim strOrigem As String = dt.Rows.Item(I).Item("Origem").ToString
            Dim strModBC As String = dt.Rows.Item(I).Item("ModBC").ToString
            Dim strICMS As String = dt.Rows.Item(I).Item("ICMS").ToString
            Dim strRedBC As String = dt.Rows.Item(I).Item("RedBC").ToString
            Dim strModBCST As String = dt.Rows.Item(I).Item("ModBCST").ToString
            Dim strRedBCST As String = dt.Rows.Item(I).Item("RedBCST").ToString
            Dim strMVaST As String = dt.Rows.Item(I).Item("MVaST").ToString
            Dim strICMSST As String = dt.Rows.Item(I).Item("ICMSST").ToString
            Dim strNCM As String = dt.Rows.Item(I).Item("NCM").ToString
            Dim strRegime As String = dt.Rows.Item(I).Item("Regime").ToString
            Dim strCalculoCred As String = dt.Rows.Item(I).Item("CalculoCred").ToString
            Dim strUnidCom As String = dt.Rows.Item(I).Item("UnidCom").ToString
            Dim strValCom As String = dt.Rows.Item(I).Item("ValCom").ToString
            Dim strCFOP As String = dt.Rows.Item(I).Item("CFOP").ToString
            Dim strCodigoANP As String = dt.Rows.Item(I).Item("CodigoANP").ToString.Replace("| ÓLEO COMBUSTÍVEL A2", "")
            Dim strUFComb As String = dt.Rows.Item(I).Item("UFComb").ToString
            Dim strTributacao As String = "" 'dt.Rows.Item(I).Item("Tributacao").ToString
            Dim strAliquotaICMS As String = "" 'dt.Rows.Item(I).Item("AliquotaICMS").ToString
            Dim strCest As String = dt.Rows.Item(I).Item("Cest").ToString
            Dim strPerFCPUF As String = dt.Rows.Item(I).Item("PerFCPUF").ToString
            Dim strPerICMSUF As String = dt.Rows.Item(I).Item("PerICMSUF").ToString



            If bolPassou = False Then
                Query = "INSERT INTO Nfe (CodProd, EXTIPI, Genero, UnidTrib, ValTrib, QtdTrib, MIPI, QtdN, " & _
                "CST, Origem, ModBC, ICMS, RedBC, ModBCST, RedBCST, MVaST, ICMSST, NCM, Regime, CalculoCred, " & _
                "UnidCom, ValCom, CFOP, CodigoANP, UFComb, Tributacao, AliquotaICMS, Cest, PerFCPUF, PerICMSUF) " & _
                "Values(" & strCodProd & ",'" & strEXTIPI & "','" & strGenero & "','" & strUnidTrib & "'," & _
                "'" & strValTrib & "','" & strQtdTrib & "','" & strMIPI & "','" & strQtdN & "','" & strCST & "'," & _
                "'" & strOrigem & "','" & strModBC & "','" & strICMS & "','" & strRedBC & "','" & strModBCST & "'," & _
                "'" & strRedBCST & "','" & strMVaST & "','" & strICMSST & "','" & strNCM & "','" & strRegime & "'," & _
                "'" & strCalculoCred & "','" & strUnidCom & "','" & strValCom & "','" & strCFOP & "'," & _
                "'" & strCodigoANP & "','" & strUFComb & "','" & strTributacao & "','" & strAliquotaICMS & "'," & _
                "'" & strCest & "','" & strPerFCPUF & "','" & strPerICMSUF & "')"
                'Inserir(Query)

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Nfe (CodProd, EXTIPI, Genero, UnidTrib, " & _
                "ValTrib, QtdTrib, MIPI, QtdN, CST, Origem, ModBC, ICMS, RedBC, ModBCST, RedBCST, MVaST, ICMSST, " & _
                "NCM, Regime, CalculoCred, UnidCom, ValCom, CFOP, CodigoANP, UFComb, Tributacao, AliquotaICMS, " & _
                "Cest, PerFCPUF, PerICMSUF) Values(" & strCodProd & ",'" & strEXTIPI & "','" & strGenero & "'," & _
                "'" & strUnidTrib & "','" & strValTrib & "','" & strQtdTrib & "','" & strMIPI & "'," & _
                "'" & strQtdN & "','" & strCST & "','" & strOrigem & "','" & strModBC & "','" & strICMS & "'," & _
                "'" & strRedBC & "','" & strModBCST & "','" & strRedBCST & "','" & strMVaST & "','" & strICMSST & "'," & _
                "'" & strNCM & "','" & strRegime & "','" & strCalculoCred & "','" & strUnidCom & "','" & strValCom & "'," & _
                "'" & strCFOP & "','" & strCodigoANP & "','" & strUFComb & "','" & strTributacao & "'," & _
                "'" & strAliquotaICMS & "','" & strCest & "','" & strPerFCPUF & "','" & strPerICMSUF & "')"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        Inserir("Update Nfe Set CodProd=case when Produto.Codigo is not null then Produto.Codigo else 0 end " & _
        "From Nfe Left Join Produto on Nfe.CodProd = Produto.Locacao")
        strTabela = "NFE"
        If strUsarNfe = "0" Then
            Me.lblTabAtual.Text = "ConfigNFE"
        Else
            Me.lblTabAtual.Text = "Pagamento"
        End If
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0


        If strUsarNfe = "0" Then
            '**********COFINGNFE**********
            B = 1
            dt = CarregarDataTable2("SELECT * FROM ConfigNfe order by Codigo", strNomeBanco)
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

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
                Dim strTipoAmb As String = dt.Rows.Item(I).Item("TipoAmbCce").ToString
                Dim strFinNfe As String = dt.Rows.Item(I).Item("FinNfe").ToString
                Dim strProcEmi As String = dt.Rows.Item(I).Item("ProcEmi").ToString
                Dim strVerProc As String = dt.Rows.Item(I).Item("VerProc").ToString
                Dim strModFrete As String = dt.Rows.Item(I).Item("ModFrete").ToString
                Dim strObsCont As String = dt.Rows.Item(I).Item("ObsCont").ToString
                Dim strVersaoCce As String = dt.Rows.Item(I).Item("VersaoCce").ToString
                Dim strTZDCce As String = dt.Rows.Item(I).Item("TZDCce").ToString
                Dim strTipoEventoCce As String = dt.Rows.Item(I).Item("TipoEventoCce").ToString
                Dim strDescEventoCce As String = dt.Rows.Item(I).Item("DescEventoCce").ToString
                Dim strCondUsoCce As String = dt.Rows.Item(I).Item("CondUsoCce").ToString
                Dim strTipoAmbCce As String = dt.Rows.Item(I).Item("TipoAmbCce").ToString
                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
                Dim strVerProcCTe As String = dt.Rows.Item(I).Item("VerProcCTe").ToString
                Dim strPorValorAproximado As String = dt.Rows.Item(I).Item("PorValorAproximado").ToString
                Dim strComplemento As String = dt.Rows.Item(I).Item("Complemento").ToString
                Dim strIM As String = dt.Rows.Item(I).Item("IM").ToString
                Dim strCNAE As String = dt.Rows.Item(I).Item("CNAE").ToString
                Dim strCSC As String = dt.Rows.Item(I).Item("CSC").ToString
                Dim strImpDireto As String = dt.Rows.Item(I).Item("ImpDireto").ToString
                Dim strMensImpCupom As String = dt.Rows.Item(I).Item("MensImpCupom").ToString
                Dim strImpressora As String = dt.Rows.Item(I).Item("Impressora").ToString
                Dim strPortaImpressora As String = dt.Rows.Item(I).Item("PortaImpressora").ToString
                Dim strPastaBackupNFCe As String = dt.Rows.Item(I).Item("PastaBackupNFCe").ToString
                Dim strPadrao As String = dt.Rows.Item(I).Item("Padrao").ToString
                Dim strVersaoXml As String = dt.Rows.Item(I).Item("VersaoXml").ToString
                Dim strAutXml As String = dt.Rows.Item(I).Item("AutXml").ToString
                Dim strSerialName As String = dt.Rows.Item(I).Item("SerialName").ToString
                Dim strEmail As String = dt.Rows.Item(I).Item("Email").ToString
                Dim strPastaBackup As String = dt.Rows.Item(I).Item("PastaBackup").ToString
                Dim strCertificadoDigital As String = dt.Rows.Item(I).Item("CertificadoDigital").ToString
                Dim strVencimentoCertificado As String = dt.Rows.Item(I).Item("VencimentoCertificado").ToString
                Dim strIndFinal As String = dt.Rows.Item(I).Item("IndFinal").ToString
                Dim strIndPres As String = dt.Rows.Item(I).Item("IndPres").ToString
                Dim strIdDest As String = dt.Rows.Item(I).Item("IdDest").ToString
                'Dim strLogoTipo As String = dt.Rows.Item(I).Item("TipoAmbCce").ToString
                Dim strTokenNFCe As String = dt.Rows.Item(I).Item("TokenNFCe").ToString
                Dim strVolumeAut As String = dt.Rows.Item(I).Item("VolumeAut").ToString



                If bolPassou = False Then
                    'Query = "INSERT INTO ConfigNfe (Razao, Fantasia, CNPJ, IE, Endereco, Bairro, Numero, Cidade, CodMun, " & _
                    '"Cep, UF, CodUF, Pais, CodPais, CRT, Telefone, NatOp, Mod, Serie, TipoNF, TipoImp, TipoEmi, TipoAmb, " & _
                    '"FinNfe, ProcEmi, VerProc, ModFrete, ObsCont, VersaoCce, TZDCce, TipoEventoCce, DescEventoCce, CondUsoCce, " & _
                    '"TipoAmbCce, CodConfig, VerProcCTe, PorValorAproximado, Complemento, IM, CNAE, CSC, ImpDireto, " & _
                    '"MensImpCupom, Impressora, PortaImpressora, PastaBackupNFCe, Padrao, VersaoXml, AutXml, SerialName, " & _
                    '"Email, PastaBackup, CertificadoDigital, VencimentoCertificado, IndFinal, IndPres, IdDest, TokenNFCe) " & _
                    '"Values('" & strRazao & "','" & strFantasia & "','" & strCNPJ & "','" & strIE & "','" & strEndereco & "'," & _
                    '"'" & strBairro & "','" & strNumero & "','" & strCidade & "','" & strCodMun & "','" & strCep & "'," & _
                    '"'" & strUF & "','" & strCodUF & "','" & strPais & "','" & strCodPais & "','" & strCRT & "'," & _
                    '"'" & strTelefone & "','" & strNatOp & "','" & strMod & "','" & strSerie & "','" & strTipoNF & "'," & _
                    '"'" & strTipoImp & "','" & strTipoEmi & "','" & strTipoAmb & "','" & strFinNfe & "'," & _
                    '"'" & strProcEmi & "','" & strVerProc & "','" & strModFrete & "','" & strObsCont & "','" & strVersaoCce & "'," & _
                    '"'" & strTZDCce & "','" & strTipoEventoCce & "','" & strDescEventoCce & "','" & strCondUsoCce & "'," & _
                    '"'" & strTipoAmbCce & "','" & strCodConfig & "','" & strVerProcCTe & "','" & strPorValorAproximado & "'," & _
                    '"'" & strComplemento & "','" & strIM & "','" & strCNAE & "','" & strCSC & "','" & strImpDireto & "'," & _
                    '"'" & strMensImpCupom & "','" & strImpressora & "','" & strPortaImpressora & "','" & strPastaBackupNFCe & "'," & _
                    '"'" & strPadrao & "','" & strVersaoXml & "','" & strAutXml & "','" & strSerialName & "','" & strEmail & "'," & _
                    '"'" & strPastaBackup & "','" & strCertificadoDigital & "','" & strVencimentoCertificado & "'," & _
                    '"'" & strIndFinal & "','" & strIndPres & "','" & strIdDest & "','" & strTokenNFCe & "');"

                    Query = "UPDATE ConfigNfe set Razao='" & strRazao & "', Fantasia='" & strFantasia & "', CNPJ='" & strCNPJ & "', " & _
                    "IE='" & strIE & "', Endereco='" & strEndereco & "', Bairro='" & strBairro & "', Numero='" & strNumero & "', " & _
                    "Cidade='" & strCidade & "', CodMun='" & strCodMun & "', Cep='" & strCep & "', UF='" & strUF & "', " & _
                    "CodUF='" & strCodUF & "', Pais='" & strPais & "', CodPais='" & strCodPais & "', CRT='" & strCRT & "', " & _
                    "Telefone='" & strTelefone & "', NatOp='" & strNatOp & "', Mod='" & strMod & "', Serie='" & strSerie & "', " & _
                    "TipoNF='" & strTipoNF & "', TipoImp='" & strTipoImp & "', TipoEmi='" & strTipoEmi & "', TipoAmb='" & strTipoAmb & "', " & _
                    "FinNfe='" & strFinNfe & "', ProcEmi='" & strProcEmi & "', VerProc='" & strVerProc & "', ModFrete='" & strModFrete & "', " & _
                    "ObsCont='" & strObsCont & "', VersaoCce='" & strVersaoCce & "', TZDCce='" & strTZDCce & "', " & _
                    "TipoEventoCce='" & strTipoEventoCce & "', DescEventoCce='" & strDescEventoCce & "', CondUsoCce='" & strCondUsoCce & "', " & _
                    "TipoAmbCce='" & strTipoAmbCce & "', CodConfig='" & strCodConfig & "', VerProcCTe='" & strVerProcCTe & "', " & _
                    "PorValorAproximado='" & strPorValorAproximado & "', Complemento='" & strComplemento & "', IM='" & strIM & "', " & _
                    "CNAE='" & strCNAE & "', CSC='" & strCSC & "', ImpDireto='" & strImpDireto & "', MensImpCupom='" & strMensImpCupom & "', " & _
                    "Impressora='" & strImpressora & "', PortaImpressora='" & strPortaImpressora & "', " & _
                    "PastaBackupNFCe='" & strPastaBackupNFCe & "', Padrao='" & strPadrao & "', VersaoXml='" & strVersaoXml & "', " & _
                    "AutXml='" & strAutXml & "', SerialName='" & strSerialName & "', Email='" & strEmail & "', " & _
                    "PastaBackup='" & strPastaBackup & "', CertificadoDigital='" & strCertificadoDigital & "', " & _
                    "VencimentoCertificado='" & strVencimentoCertificado & "', IndFinal='" & strIndFinal & "', IndPres='" & strIndPres & "', " & _
                    "IdDest='" & strIdDest & "', TokenNFCe='" & strTokenNFCe & "', VolumeAut = '" & strVolumeAut & "';"

                    bolPassou = True
                Else
                    Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO ConfigNfe (Razao, Fantasia, CNPJ, IE, Endereco, Bairro, " & _
                    "Numero, Cidade, CodMun, " & _
                    "Cep, UF, CodUF, Pais, CodPais, CRT, Telefone, NatOp, Mod, Serie, TipoNF, TipoImp, TipoEmi, TipoAmb, " & _
                    "FinNfe, ProcEmi, VerProc, ModFrete, ObsCont, VersaoCce, TZDCce, TipoEventoCce, DescEventoCce, CondUsoCce, " & _
                    "TipoAmbCce, CodConfig, VerProcCTe, PorValorAproximado, Complemento, IM, CNAE, CSC, ImpDireto, " & _
                    "MensImpCupom, Impressora, PortaImpressora, PastaBackupNFCe, Padrao, VersaoXml, AutXml, SerialName, " & _
                    "Email, PastaBackup, CertificadoDigital, VencimentoCertificado, IndFinal, IndPres, IdDest, TokenNFCe, VolumeAut) " & _
                    "Values('" & strRazao & "','" & strFantasia & "','" & strCNPJ & "','" & strIE & "','" & strEndereco & "'," & _
                    "'" & strBairro & "','" & strNumero & "','" & strCidade & "','" & strCodMun & "','" & strCep & "'," & _
                    "'" & strUF & "','" & strCodUF & "','" & strPais & "','" & strCodPais & "','" & strCRT & "'," & _
                    "'" & strTelefone & "','" & strNatOp & "','" & strMod & "','" & strSerie & "','" & strTipoNF & "'," & _
                    "'" & strTipoImp & "','" & strTipoEmi & "','" & strTipoAmb & "','" & strFinNfe & "'," & _
                    "'" & strProcEmi & "','" & strVerProc & "','" & strModFrete & "','" & strObsCont & "','" & strVersaoCce & "'," & _
                    "'" & strTZDCce & "','" & strTipoEventoCce & "','" & strDescEventoCce & "','" & strCondUsoCce & "'," & _
                    "'" & strTipoAmbCce & "','" & strCodConfig & "','" & strVerProcCTe & "','" & strPorValorAproximado & "'," & _
                    "'" & strComplemento & "','" & strIM & "','" & strCNAE & "','" & strCSC & "','" & strImpDireto & "'," & _
                    "'" & strMensImpCupom & "','" & strImpressora & "','" & strPortaImpressora & "','" & strPastaBackupNFCe & "'," & _
                    "'" & strPadrao & "','" & strVersaoXml & "','" & strAutXml & "','" & strSerialName & "','" & strEmail & "'," & _
                    "'" & strPastaBackup & "','" & strCertificadoDigital & "','" & strVencimentoCertificado & "'," & _
                    "'" & strIndFinal & "','" & strIndPres & "','" & strIdDest & "','" & strTokenNFCe & "','" & strVolumeAut & "');"

                End If

                count = count + 1
                If count = 500 Then
                    Inserir(Query)
                    System.Threading.Thread.Sleep(40)

                    Query = ""
                    count = 0
                End If

                B += 1
                LogDeErro()
            Next
            If Query <> "" Then
                Inserir(Query)
            End If
            strTabela = "ConfigNFE"
            Me.lblTabAtual.Text = "Pagamento"
            BarraProdgresso()


            Query = ""
            bolPassou = False
            count = 0
        End If


        '**********PAGAMENTO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Pagamento order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString
            Dim strDescricao As String = dt.Rows.Item(I).Item("Descricao").ToString
            Dim strDias As String = dt.Rows.Item(I).Item("Dias").ToString
            Dim strDesconto As String = dt.Rows.Item(I).Item("Desconto").ToString
            Dim bolPrazo As Boolean = dt.Rows.Item(I).Item("Prazo").ToString
            Dim strFormaPagamento As String = dt.Rows.Item(I).Item("FormaPagamento").ToString
            Dim strIrCaixa As String = dt.Rows.Item(I).Item("IrCaixa").ToString
            Dim strCodBanco As String = dt.Rows.Item(I).Item("CodBanco").ToString
            Dim strNumDias As String = dt.Rows.Item(I).Item("NumDias").ToString
            Dim strUsaTEF As String = "False" 'dt.Rows.Item(I).Item("UsaTEF").ToString


            If bolPassou = False Then
                Query = "INSERT INTO Pagamento(Descricao, Dias, Desconto, Prazo, FormaPagamento, IrCaixa, CodBanco, " & _
                "NumDias, UsaTEF) VALUES ('" & strDescricao & "','" & strDias & "','" & strDesconto & "','" & bolPrazo & "'," & _
                "'" & strFormaPagamento & "','" & strIrCaixa & "','" & strCodBanco & "','" & strNumDias & "','" & strUsaTEF & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Pagamento(Descricao, Dias, Desconto, Prazo, " & _
                "FormaPagamento, IrCaixa, CodBanco, NumDias, UsaTEF) VALUES ('" & strDescricao & "','" & strDias & "'," & _
                "'" & strDesconto & "','" & bolPrazo & "','" & strFormaPagamento & "','" & strIrCaixa & "'," & _
                "'" & strCodBanco & "','" & strNumDias & "','" & strUsaTEF & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "Pagamento"
        Me.lblTabAtual.Text = "Banco"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********BANCO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Banco order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
            Dim strSaldo As String = dt.Rows.Item(I).Item("Saldo").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strVersao As String = dt.Rows.Item(I).Item("Versao").ToString
            Dim strPadrao As String = dt.Rows.Item(I).Item("Padrao").ToString
            Dim strCodigoTransmissao As String = strCodigo 'dt.Rows.Item(I).Item("CodigoTransmissao").ToString
            Dim strAgencia As String = dt.Rows.Item(I).Item("Agencia").ToString
            Dim strCodigoCedente As String = dt.Rows.Item(I).Item("CodigoCedente").ToString
            Dim strCodigoBanco As String = dt.Rows.Item(I).Item("CodigoBanco").ToString
            Dim strNomeBanco As String = dt.Rows.Item(I).Item("NomeBanco").ToString
            Dim strContaCorrente As String = dt.Rows.Item(I).Item("ContaCorrente").ToString
            Dim strCedente As String = dt.Rows.Item(I).Item("Cedente").ToString
            Dim strCPF As String = dt.Rows.Item(I).Item("CPF").ToString
            Dim strPerMulta As String = dt.Rows.Item(I).Item("PerMulta").ToString
            Dim strCodigoCarteira As String = dt.Rows.Item(I).Item("CodigoCarteira").ToString
            Dim strCodigoOcorrencia As String = dt.Rows.Item(I).Item("CodigoOcorrencia").ToString
            Dim strSeuNumero As String = dt.Rows.Item(I).Item("SeuNumero").ToString
            Dim strEspecie As String = dt.Rows.Item(I).Item("Especie").ToString
            Dim strTipoAceite As String = dt.Rows.Item(I).Item("TipoAceite").ToString
            Dim strPrimeiraInstrucao As String = dt.Rows.Item(I).Item("PrimeiraInstrucao").ToString
            Dim strSegundaInstrucao As String = dt.Rows.Item(I).Item("SegundaInstrucao").ToString
            Dim strDiasMora As String = dt.Rows.Item(I).Item("DiasMora").ToString
            Dim strValorMora As String = dt.Rows.Item(I).Item("ValorMora").ToString
            Dim strValorIOF As String = dt.Rows.Item(I).Item("ValorIOF").ToString
            Dim strDiasProtesto As String = dt.Rows.Item(I).Item("DiasProtesto").ToString

            Dim strInstrucao As String = "" 'dt.Rows.Item(I).Item("DiasProtesto").ToString
            Dim strRecibo As String = "" 'dt.Rows.Item(I).Item("DiasProtesto").ToString
            Dim strInstrucao2 As String = "" 'dt.Rows.Item(I).Item("DiasProtesto").ToString
            Dim strCodigoVinculacao As String = "" 'dt.Rows.Item(I).Item("DiasProtesto").ToString
            Dim strCodigoIdentificador As String = "" 'dt.Rows.Item(I).Item("DiasProtesto").ToString
            Dim strTipoAmbiente As String = "" 'dt.Rows.Item(I).Item("DiasProtesto").ToString

            If strBoleto = "0" Then
                strInstrucao = dt.Rows.Item(I).Item("Instrucao").ToString
                strRecibo = dt.Rows.Item(I).Item("Recibo").ToString
                strInstrucao2 = dt.Rows.Item(I).Item("Instrucao2").ToString
                strCodigoVinculacao = dt.Rows.Item(I).Item("CodigoVinculacao").ToString
                strCodigoIdentificador = dt.Rows.Item(I).Item("CodigoIdentificador").ToString
                strTipoAmbiente = dt.Rows.Item(I).Item("TipoAmbiente").ToString

                If bolPassou = False Then
                    Query = "INSERT INTO Banco(Nome, Saldo, CodConfig, Versao, Padrao, CodigoTransmissao, " & _
                    "Agencia, CodigoCedente, CodigoBanco, NomeBanco, ContaCorrente, Cedente, CPF, PerMulta, CodigoCarteira, " & _
                    "CodigoOcorrencia, SeuNumero, Especie, TipoAceite, PrimeiraInstrucao, SegundaInstrucao, DiasMora, " & _
                    "ValorMora, ValorIOF, DiasProtesto, Instrucao, Recibo, Instrucao2, CodigoVinculacao, " & _
                    "CodigoIdentificador, TipoAmbiente) Values('" & strNome & "'," & Num(strSaldo) & ",'" & strCodConfig & "'," & _
                    "'" & strVersao & "','" & strPadrao & "','" & strCodigoTransmissao & "','" & strAgencia & "'," & _
                    "'" & strCodigoCedente & "','" & strCodigoBanco & "','" & strNomeBanco & "','" & strContaCorrente & "'," & _
                    "'" & strCedente & "','" & strCPF & "','" & strPerMulta & "','" & strCodigoCarteira & "'," & _
                    "'" & strCodigoOcorrencia & "','" & strSeuNumero & "','" & strEspecie & "','" & strTipoAceite & "'," & _
                    "'" & strPrimeiraInstrucao & "','" & strSegundaInstrucao & "','" & strDiasMora & "','" & strValorMora & "'," & _
                    "'" & strValorIOF & "','" & strDiasProtesto & "','" & strInstrucao & "','" & strRecibo & "'," & _
                    "'" & strInstrucao2 & "','" & strCodigoVinculacao & "','" & strCodigoIdentificador & "','" & strTipoAmbiente & "');"

                    bolPassou = True
                Else
                    Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Banco(Nome, Saldo, CodConfig, Versao, Padrao, CodigoTransmissao, " & _
                    "Agencia, CodigoCedente, CodigoBanco, NomeBanco, ContaCorrente, Cedente, CPF, PerMulta, CodigoCarteira, " & _
                    "CodigoOcorrencia, SeuNumero, Especie, TipoAceite, PrimeiraInstrucao, SegundaInstrucao, DiasMora, " & _
                    "ValorMora, ValorIOF, DiasProtesto, Instrucao, Recibo, Instrucao2, CodigoVinculacao, CodigoIdentificador, " & _
                    "TipoAmbiente) Values('" & strNome & "'," & Num(strSaldo) & ",'" & strCodConfig & "'," & _
                    "'" & strVersao & "','" & strPadrao & "','" & strCodigoTransmissao & "','" & strAgencia & "'," & _
                    "'" & strCodigoCedente & "','" & strCodigoBanco & "','" & strNomeBanco & "','" & strContaCorrente & "'," & _
                    "'" & strCedente & "','" & strCPF & "','" & strPerMulta & "','" & strCodigoCarteira & "'," & _
                    "'" & strCodigoOcorrencia & "','" & strSeuNumero & "','" & strEspecie & "','" & strTipoAceite & "'," & _
                    "'" & strPrimeiraInstrucao & "','" & strSegundaInstrucao & "','" & strDiasMora & "','" & strValorMora & "'," & _
                    "'" & strValorIOF & "','" & strDiasProtesto & "','" & strInstrucao & "','" & strRecibo & "'," & _
                    "'" & strInstrucao2 & "','" & strCodigoVinculacao & "','" & strCodigoIdentificador & "','" & strTipoAmbiente & "');"
                End If
            Else
                If bolPassou = False Then
                    Query = "INSERT INTO Banco(Nome, Saldo, CodConfig, Versao, Padrao, CodigoTransmissao, " & _
                    "Agencia, CodigoCedente, CodigoBanco, NomeBanco, ContaCorrente, Cedente, CPF, PerMulta, CodigoCarteira, " & _
                    "CodigoOcorrencia, SeuNumero, Especie, TipoAceite, PrimeiraInstrucao, SegundaInstrucao, DiasMora, " & _
                    "ValorMora, ValorIOF, DiasProtesto) Values('" & strNome & "'," & Num(strSaldo) & ",'" & strCodConfig & "'," & _
                    "'" & strVersao & "','" & strPadrao & "','" & strCodigoTransmissao & "','" & strAgencia & "'," & _
                    "'" & strCodigoCedente & "','" & strCodigoBanco & "','" & strNomeBanco & "','" & strContaCorrente & "'," & _
                    "'" & strCedente & "','" & strCPF & "','" & strPerMulta & "','" & strCodigoCarteira & "'," & _
                    "'" & strCodigoOcorrencia & "','" & strSeuNumero & "','" & strEspecie & "','" & strTipoAceite & "'," & _
                    "'" & strPrimeiraInstrucao & "','" & strSegundaInstrucao & "','" & strDiasMora & "','" & strValorMora & "'," & _
                    "'" & strValorIOF & "','" & strDiasProtesto & "');"

                    bolPassou = True
                Else
                    Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Banco(Nome, Saldo, CodConfig, Versao, Padrao, CodigoTransmissao, " & _
                    "Agencia, CodigoCedente, CodigoBanco, NomeBanco, ContaCorrente, Cedente, CPF, PerMulta, CodigoCarteira, " & _
                    "CodigoOcorrencia, SeuNumero, Especie, TipoAceite, PrimeiraInstrucao, SegundaInstrucao, DiasMora, " & _
                    "ValorMora, ValorIOF, DiasProtesto) Values('" & strNome & "'," & Num(strSaldo) & ",'" & strCodConfig & "'," & _
                    "'" & strVersao & "','" & strPadrao & "','" & strCodigoTransmissao & "','" & strAgencia & "'," & _
                    "'" & strCodigoCedente & "','" & strCodigoBanco & "','" & strNomeBanco & "','" & strContaCorrente & "'," & _
                    "'" & strCedente & "','" & strCPF & "','" & strPerMulta & "','" & strCodigoCarteira & "'," & _
                    "'" & strCodigoOcorrencia & "','" & strSeuNumero & "','" & strEspecie & "','" & strTipoAceite & "'," & _
                    "'" & strPrimeiraInstrucao & "','" & strSegundaInstrucao & "','" & strDiasMora & "','" & strValorMora & "'," & _
                    "'" & strValorIOF & "','" & strDiasProtesto & "');"
                End If
            End If

            'If bolPassou = False Then
            '    Query = "INSERT INTO Banco(Nome, Saldo, CodConfig, Versao, Padrao, CodigoTransmissao, " & _
            '    "Agencia, CodigoCedente, CodigoBanco, NomeBanco, ContaCorrente, Cedente, CPF, PerMulta, CodigoCarteira, " & _
            '    "CodigoOcorrencia, SeuNumero, Especie, TipoAceite, PrimeiraInstrucao, SegundaInstrucao, DiasMora, " & _
            '    "ValorMora, ValorIOF, DiasProtesto) Values('" & strNome & "'," & Num(strSaldo) & ",'" & strCodConfig & "'," & _
            '    "'" & strVersao & "','" & strPadrao & "','" & strCodigoTransmissao & "','" & strAgencia & "'," & _
            '    "'" & strCodigoCedente & "','" & strCodigoBanco & "','" & strNomeBanco & "','" & strContaCorrente & "'," & _
            '    "'" & strCedente & "','" & strCPF & "','" & strPerMulta & "','" & strCodigoCarteira & "'," & _
            '    "'" & strCodigoOcorrencia & "','" & strSeuNumero & "','" & strEspecie & "','" & strTipoAceite & "'," & _
            '    "'" & strPrimeiraInstrucao & "','" & strSegundaInstrucao & "','" & strDiasMora & "','" & strValorMora & "'," & _
            '    "'" & strValorIOF & "','" & strDiasProtesto & "');"
            '    bolPassou = True
            'Else
            '    Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Banco(Nome, Saldo, CodConfig, Versao, Padrao, CodigoTransmissao, " & _
            '    "Agencia, CodigoCedente, CodigoBanco, NomeBanco, ContaCorrente, Cedente, CPF, PerMulta, CodigoCarteira, " & _
            '    "CodigoOcorrencia, SeuNumero, Especie, TipoAceite, PrimeiraInstrucao, SegundaInstrucao, DiasMora, " & _
            '    "ValorMora, ValorIOF, DiasProtesto) Values('" & strNome & "'," & Num(strSaldo) & ",'" & strCodConfig & "'," & _
            '    "'" & strVersao & "','" & strPadrao & "','" & strCodigoTransmissao & "','" & strAgencia & "'," & _
            '    "'" & strCodigoCedente & "','" & strCodigoBanco & "','" & strNomeBanco & "','" & strContaCorrente & "'," & _
            '    "'" & strCedente & "','" & strCPF & "','" & strPerMulta & "','" & strCodigoCarteira & "'," & _
            '    "'" & strCodigoOcorrencia & "','" & strSeuNumero & "','" & strEspecie & "','" & strTipoAceite & "'," & _
            '    "'" & strPrimeiraInstrucao & "','" & strSegundaInstrucao & "','" & strDiasMora & "','" & strValorMora & "'," & _
            '    "'" & strValorIOF & "','" & strDiasProtesto & "');"
            'End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "Banco"
        If strBoleto = "0" Then
            Me.lblTabAtual.Text = "Boleto"
        Else
            Me.lblTabAtual.Text = "Caixa"
        End If
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0


        '**********BOLETO**********
        If strBoleto = "0" Then
            B = 1
            dt = CarregarDataTable2("SELECT * FROM Boleto order by Codigo", strNomeBanco)
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
                Dim strCodBanco As String = dt.Rows.Item(I).Item("CodBanco").ToString
                Dim strDataGravacao As String = dt.Rows.Item(I).Item("DataGravacao").ToString
                'Dim strCodCli As String = dt.Rows.Item(I).Item("CodCli").ToString

                Dim dtCodCli As DataTable = CarregarDataTable("Select Codigo From Cliente Where Pessoa1='" & dt.Rows.Item(I).Item("CodCli").ToString & "'")

                Dim strCodCli As String = ""
                If dtCodCli.Rows.Count Then
                    strCodCli = dtCodCli.Rows.Item(0).Item("Codigo").ToString()
                End If
                If strCodCli = "" Then
                    strCodCli = 1
                End If

                Dim strCodFor As String = dt.Rows.Item(I).Item("CodFor").ToString
                Dim strNossoNumero As String = dt.Rows.Item(I).Item("NossoNumero").ToString
                Dim strPerMulta As String = dt.Rows.Item(I).Item("PerMulta").ToString
                Dim strCodigoCarteira As String = dt.Rows.Item(I).Item("CodigoCarteira").ToString
                Dim strCodigoOcorrencia As String = dt.Rows.Item(I).Item("CodigoOcorrencia").ToString
                Dim strSeuNumero As String = dt.Rows.Item(I).Item("SeuNumero").ToString
                Dim strEspecie As String = dt.Rows.Item(I).Item("Especie").ToString
                Dim strTipoAceite As String = dt.Rows.Item(I).Item("TipoAceite").ToString
                Dim strPrimeiraInstrucao As String = dt.Rows.Item(I).Item("PrimeiraInstrucao").ToString
                Dim strSegundaInstrucao As String = dt.Rows.Item(I).Item("SegundaInstrucao").ToString
                Dim strValorMora As String = dt.Rows.Item(I).Item("ValorMora").ToString
                Dim strValorIOF As String = dt.Rows.Item(I).Item("ValorIOF").ToString
                Dim strDataSegDesc As String = dt.Rows.Item(I).Item("DataSegDesc").ToString
                Dim strVencimento As String = dt.Rows.Item(I).Item("Vencimento").ToString
                Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
                Dim strDataEmissao As String = dt.Rows.Item(I).Item("DataEmissao").ToString
                Dim strDataLimite As String = dt.Rows.Item(I).Item("DataLimite").ToString
                Dim strValorDesconto As String = dt.Rows.Item(I).Item("ValorDesconto").ToString
                Dim strDiasProtesto As String = dt.Rows.Item(I).Item("DiasProtesto").ToString
                Dim strNumeroDocumento As String = dt.Rows.Item(I).Item("NumeroDocumento").ToString
                Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
                Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
                Dim strDiasMora As String = dt.Rows.Item(I).Item("DiasMora").ToString
                Dim strCodigoBarras As String = dt.Rows.Item(I).Item("CodigoBarras").ToString
                Dim strLinhaDigitavel As String = dt.Rows.Item(I).Item("LinhaDigitavel").ToString
                Dim strCodBarra As String = dt.Rows.Item(I).Item("CodBarra").ToString
                Dim strStatusRetorno As String = dt.Rows.Item(I).Item("StatusRetorno").ToString
                Dim strDataRecebimento As String = dt.Rows.Item(I).Item("DataRecebimento").ToString
                Dim strCodigoConta As String = dt.Rows.Item(I).Item("CodigoConta").ToString
                Dim strInstrucao As String = dt.Rows.Item(I).Item("Instrucao").ToString
                Dim strInstrucao2 As String = dt.Rows.Item(I).Item("Instrucao2").ToString

                If bolPassou = False Then
                    Query = "INSERT INTO Boleto(CodConfig, CodBanco, DataGravacao, CodCli, CodFor, " & _
                    "NossoNumero, PerMulta, CodigoCarteira, CodigoOcorrencia, SeuNumero, Especie, TipoAceite, " & _
                    "PrimeiraInstrucao, SegundaInstrucao, ValorMora, ValorIOF, DataSegDesc, Vencimento, Valor, " & _
                    "DataEmissao, DataLimite, ValorDesconto, DiasProtesto, NumeroDocumento, CodOrdem, Status, " & _
                    "DiasMora, CodigoBarras, LinhaDigitavel, CodBarra, StatusRetorno, DataRecebimento, CodigoConta, " & _
                    "Instrucao, Instrucao2) Values('" & strCodConfig & "','" & strCodBanco & "','" & strDataGravacao & "'," & _
                    "'" & strCodCli & "','" & strCodFor & "','" & strNossoNumero & "'," & Num(strPerMulta) & "," & _
                    "'" & strCodigoCarteira & "','" & strCodigoOcorrencia & "','" & strSeuNumero & "','" & strEspecie & "','" & strTipoAceite & "'," & _
                    "'" & strPrimeiraInstrucao & "','" & strSegundaInstrucao & "'," & Num(strValorMora) & "," & _
                    "" & Num(strValorIOF) & ",'" & strDataSegDesc & "','" & strVencimento & "'," & Num(strValor) & "," & _
                    "'" & strDataEmissao & "','" & strDataLimite & "'," & Num(strValorDesconto) & "," & _
                    "'" & strDiasProtesto & "','" & strNumeroDocumento & "','" & strCodOrdem & "'," & _
                    "'" & strStatus & "','" & strDiasMora & "','" & strCodigoBarras & "','" & strLinhaDigitavel & "'," & _
                    "'" & strCodBarra & "','" & strStatusRetorno & "','" & strDataRecebimento & "','" & strCodigoConta & "'," & _
                    "'" & strInstrucao & "','" & strInstrucao2 & "');"

                    bolPassou = True
                Else
                    Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Boleto(CodConfig, CodBanco, " & _
                    "DataGravacao, CodCli, CodFor, NossoNumero, PerMulta, CodigoCarteira, CodigoOcorrencia, " & _
                    "SeuNumero, Especie, TipoAceite, PrimeiraInstrucao, SegundaInstrucao, ValorMora, ValorIOF, " & _
                    "DataSegDesc, Vencimento, Valor, DataEmissao, DataLimite, ValorDesconto, DiasProtesto, " & _
                    "NumeroDocumento, CodOrdem, Status, DiasMora, CodigoBarras, LinhaDigitavel, CodBarra, " & _
                    "StatusRetorno, DataRecebimento, CodigoConta, Instrucao, Instrucao2) Values('" & strCodConfig & "'," & _
                    "'" & strCodBanco & "','" & strDataGravacao & "','" & strCodCli & "','" & strCodFor & "'," & _
                    "'" & strNossoNumero & "'," & Num(strPerMulta) & ",'" & strCodigoCarteira & "','" & strCodigoOcorrencia & "'," & _
                    "'" & strSeuNumero & "','" & strEspecie & "','" & strTipoAceite & "','" & strPrimeiraInstrucao & "'," & _
                    "'" & strSegundaInstrucao & "'," & Num(strValorMora) & "," & Num(strValorIOF) & "," & _
                    "'" & strDataSegDesc & "','" & strVencimento & "'," & Num(strValor) & "," & _
                    "'" & strDataEmissao & "','" & strDataLimite & "'," & Num(strValorDesconto) & "," & _
                    "'" & strDiasProtesto & "','" & strNumeroDocumento & "','" & strCodOrdem & "'," & _
                    "'" & strStatus & "','" & strDiasMora & "','" & strCodigoBarras & "','" & strLinhaDigitavel & "'," & _
                    "'" & strCodBarra & "','" & strStatusRetorno & "','" & strDataRecebimento & "','" & strCodigoConta & "'," & _
                    "'" & strInstrucao & "','" & strInstrucao2 & "');"

                End If

                count = count + 1
                If count = 500 Then
                    Inserir(Query)
                    System.Threading.Thread.Sleep(40)

                    Query = ""
                    count = 0
                End If

                B += 1
                LogDeErro()
            Next
            If Query <> "" Then
                Inserir(Query)
            End If
            strTabela = "Boleto"
            Me.lblTabAtual.Text = "Caixa"
            BarraProdgresso()


            Query = ""
            bolPassou = False
            count = 0
        End If


        '**********CAIXA**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Caixa order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strMotivo As String = dt.Rows.Item(I).Item("Motivo").ToString
            Dim strCaixa As String = "" 'dt.Rows.Item(I).Item("Caixa").ToString
            Dim strCredito As String = dt.Rows.Item(I).Item("Credito").ToString
            Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
            Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strCentroCusto As String = dt.Rows.Item(I).Item("CentroCusto").ToString
            Dim strAuxiliar As String = "" 'dt.Rows.Item(I).Item("Auxiliar").ToString
            Dim strBandeira As String = "" 'dt.Rows.Item(I).Item("Bandeira").ToString


            If bolPassou = False Then
                Query = "INSERT INTO Caixa(Motivo, Caixa, Credito, Pagamento, Valor, Data, CodConfig, " & _
                "CentroCusto, Auxiliar, Bandeira) Values('" & strMotivo & "','" & strCaixa & "'," & _
                "'" & strCredito & "','" & strPagamento & "'," & Num(strValor) & ",'" & strData & "'," & _
                "'" & strCodConfig & "','" & strCentroCusto & "','" & strAuxiliar & "','" & strBandeira & "');"
                'Inserir(Query)
                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Caixa(Motivo, Caixa, Credito, " & _
                "Pagamento, Valor, Data, CodConfig, CentroCusto, Auxiliar, Bandeira) Values('" & strMotivo & "'," & _
                "'" & strCaixa & "','" & strCredito & "','" & strPagamento & "'," & Num(strValor) & ",'" & strData & "'," & _
                "'" & strCodConfig & "','" & strCentroCusto & "','" & strAuxiliar & "','" & strBandeira & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "Caixa"
        Me.lblTabAtual.Text = "Cheque"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********CHEQUE**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Cheque order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strCodPed As String = dt.Rows.Item(I).Item("CodPed").ToString
            Dim strCliente As String = dt.Rows.Item(I).Item("Cliente").ToString
            Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
            Dim strVencimento As String = dt.Rows.Item(I).Item("Vencimento").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strDocumento As String = dt.Rows.Item(I).Item("Documento").ToString
            Dim strBanco As String = dt.Rows.Item(I).Item("Banco").ToString
            Dim strQuem As String = dt.Rows.Item(I).Item("Quem").ToString
            Dim strRecebidoOK As String = dt.Rows.Item(I).Item("RecebidoOK").ToString
            Dim strRecebimento As String = dt.Rows.Item(I).Item("Recebimento").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strObservacao As String = dt.Rows.Item(I).Item("Observacao").ToString
            Dim strCodigoPedido As String = "" 'dt.Rows.Item(I).Item("CodigoPedido").ToString


            If bolPassou = False Then
                Query = "INSERT INTO Cheque(CodPed, Cliente, Valor, Vencimento, Data, Documento, Banco, Quem, " & _
                "RecebidoOK, Recebimento, CodConfig, Observacao, CodigoPedido) Values('" & strCodPed & "'," & _
                "'" & strCliente & "'," & Num(strValor) & ",'" & strVencimento & "','" & strData & "'," & _
                "'" & strDocumento & "','" & strBanco & "','" & strQuem & "','" & strRecebidoOK & "'," & _
                "'" & strRecebimento & "','" & strCodConfig & "','" & strObservacao & "','" & strCodigoPedido & "')"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Cheque(CodPed, Cliente, Valor, Vencimento, " & _
                "Data, Documento, Banco, Quem, RecebidoOK, Recebimento, CodConfig, Observacao, CodigoPedido) " & _
                "Values('" & strCodPed & "','" & strCliente & "'," & Num(strValor) & ",'" & strVencimento & "'," & _
                "'" & strData & "','" & strDocumento & "','" & strBanco & "','" & strQuem & "','" & strRecebidoOK & "'," & _
                "'" & strRecebimento & "','" & strCodConfig & "','" & strObservacao & "','" & strCodigoPedido & "')"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "Cheque"
        Me.lblTabAtual.Text = "ContaPagar"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********CONTAPAGAR**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM ContaPagar order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strNome As String = dt.Rows.Item(I).Item("Fornecedor").ToString

            Dim strCNPJ As String = dt.Rows.Item(I).Item("CNPJ").ToString
            Dim dtfor As DataTable = CarregarDataTable("Select Codigo From Fornecedor Where CPF='" & strCNPJ & "'")
            Dim strCodFor As String = ""
            If dtfor.Rows.Count > 0 Then
                strCodFor = dtfor.Rows.Item(0).Item("Codigo").ToString
            End If

            If strCodFor = "" Then
                dtfor = CarregarDataTable("Select Codigo From Fornecedor Where Nome='FORNECEDOR'")
                If dtfor.Rows.Count > 0 Then
                    strCodFor = dtfor.Rows.Item(0).Item("Codigo").ToString
                End If
            End If


            Dim strTipoConta As String = dt.Rows.Item(I).Item("TipoConta").ToString
            Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
            Dim strFormaPagamento As String = dt.Rows.Item(I).Item("FormaPagamento").ToString
            Dim strParcelas As String = dt.Rows.Item(I).Item("Parcelas").ToString
            Dim strValorParcela As String = dt.Rows.Item(I).Item("ValorParcela").ToString
            Dim strVencimento As String = dt.Rows.Item(I).Item("Vencimento").ToString
            Dim strDataPagamento As String = dt.Rows.Item(I).Item("DataPagamento").ToString
            Dim strValorPago As String = dt.Rows.Item(I).Item("ValorPago").ToString

            Dim strDescricao As String = "" 'dt.Rows.Item(I).Item("Descricao").ToString & vbCrLf & dt.Rows.Item(I).Item("Fornecedor").ToString
            If strCodFor = 1 Then
                If dt.Rows.Item(I).Item("Descricao").ToString <> "" Then
                    strDescricao = dt.Rows.Item(I).Item("Descricao").ToString & vbCrLf & dt.Rows.Item(I).Item("Fornecedor").ToString
                Else
                    strDescricao = dt.Rows.Item(I).Item("Fornecedor").ToString
                End If
            Else
                strDescricao = dt.Rows.Item(I).Item("Descricao").ToString
            End If

            Dim strPagoOK As String = dt.Rows.Item(I).Item("PagoOK").ToString
            Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
            Dim strNumeroDocumento As String = dt.Rows.Item(I).Item("NumeroDocumento").ToString
            Dim strTipoCusto As String = dt.Rows.Item(I).Item("TipoCusto").ToString
            Dim strBanco As String = dt.Rows.Item(I).Item("Banco").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strCentroCusto As String = dt.Rows.Item(I).Item("CentroCusto").ToString
            Dim strData As String = "" 'dt.Rows.Item(I).Item("Data").ToString


            If bolPassou = False Then
                Query = "INSERT INTO ContaPagar(CodFor, TipoConta, Valor, FormaPagamento, Parcelas, " & _
                "ValorParcela, Vencimento, DataPagamento, ValorPago, Descricao, PagoOK, Pagamento, NumeroDocumento, " & _
                "TipoCusto, Banco, CodConfig, CentroCusto, Data) Values('" & strCodFor & "','" & strTipoConta & "'," & _
                "" & Num(strValor) & ",'" & strFormaPagamento & "','" & strParcelas & "'," & Num(strValorParcela) & "," & _
                "'" & strVencimento & "','" & strDataPagamento & "'," & Num(strValorPago) & ",'" & strDescricao & "'," & _
                "'" & strPagoOK & "','" & strPagamento & "','" & strNumeroDocumento & "','" & strTipoCusto & "'," & _
                "'" & strBanco & "','" & strCodConfig & "','" & strCentroCusto & "','" & strData & "');"
                'Inserir(Query)
                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO ContaPagar(CodFor, TipoConta, Valor, " & _
                "FormaPagamento, Parcelas, ValorParcela, Vencimento, DataPagamento, ValorPago, Descricao, PagoOK, " & _
                "Pagamento, NumeroDocumento, TipoCusto, Banco, CodConfig, CentroCusto, Data) Values('" & strCodFor & "'," & _
                "'" & strTipoConta & "'," & Num(strValor) & ",'" & strFormaPagamento & "','" & strParcelas & "'," & _
                "" & Num(strValorParcela) & ",'" & strVencimento & "','" & strDataPagamento & "'," & Num(strValorPago) & "," & _
                "'" & strDescricao & "','" & strPagoOK & "','" & strPagamento & "','" & strNumeroDocumento & "'," & _
                "'" & strTipoCusto & "','" & strBanco & "','" & strCodConfig & "','" & strCentroCusto & "','" & strData & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "ContaPagar"
        Me.lblTabAtual.Text = "MovimentoBancario"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********MOVIMENTOBANCARIO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM MovimentoBancario order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim dtBanc As DataTable = CarregarDataTable("Select Codigo From Banco Where CodigoTransmissao=" & dt.Rows.Item(I).Item("CodBanco").ToString)

            Dim strCodBanco As String
            If dtBanc.Rows.Count > 0 Then
                strCodBanco = dtBanc.Rows.Item(0).Item("Codigo").ToString
            End If

            Dim strTipoMovimento As String = dt.Rows.Item(I).Item("TipoMovimento").ToString
            Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strObservacao As String = dt.Rows.Item(I).Item("Observacao").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


            If bolPassou = False Then
                Query = "INSERT INTO MovimentoBancario(CodBanco, TipoMovimento, Valor, Data, Observacao, CodConfig) " & _
                "Values('" & strCodBanco & "','" & strTipoMovimento & "'," & Num(strValor) & ",'" & strData & "'," & _
                "'" & strObservacao.Trim & "','" & strCodConfig & "');"

                'Inserir(Query)
                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO MovimentoBancario(CodBanco, TipoMovimento, " & _
                "Valor, Data, Observacao, CodConfig) Values('" & strCodBanco & "','" & strTipoMovimento & "'," & _
                "" & Num(strValor) & ",'" & strData & "','" & strObservacao.Trim & "','" & strCodConfig & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "MovimentoBancario"
        Me.lblTabAtual.Text = "Funcionario"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********FUNCIONARIO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Funcionario order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
            Dim strCPF As String = dt.Rows.Item(I).Item("CPF").ToString
            Dim strRG As String = dt.Rows.Item(I).Item("RG").ToString
            Dim strTelefone As String = dt.Rows.Item(I).Item("Telefone").ToString
            Dim strCelular As String = dt.Rows.Item(I).Item("Celular").ToString
            Dim strEndereco As String = dt.Rows.Item(I).Item("Endereco").ToString
            Dim strBairro As String = dt.Rows.Item(I).Item("Bairro").ToString
            Dim strCidade As String = dt.Rows.Item(I).Item("Cidade").ToString
            Dim strNascimento As String = dt.Rows.Item(I).Item("Nascimento").ToString
            Dim strObs As String = dt.Rows.Item(I).Item("Observacao").ToString
            Dim strPorcComissao As String = dt.Rows.Item(I).Item("PorcentagemPeca").ToString
            Dim strFuncao As String = dt.Rows.Item(I).Item("Funcao").ToString
            Dim strDataAdmissao As String = dt.Rows.Item(I).Item("DataAdmissao").ToString
            Dim strDataDemissao As String = dt.Rows.Item(I).Item("DataDemissao").ToString
            Dim strEmail As String = dt.Rows.Item(I).Item("Email").ToString
            Dim strAtivo As String = dt.Rows.Item(I).Item("Ativo").ToString
            Dim strSangue As String = dt.Rows.Item(I).Item("Sangue").ToString
            Dim strAlergia As String = dt.Rows.Item(I).Item("Alergia").ToString

            Dim strCEP As String = "" 'dt.Rows.Item(I).Item("CEP").ToString
            Dim strUF As String = "" 'dt.Rows.Item(I).Item("UF").ToString
            Dim strComplemento As String = "" 'dt.Rows.Item(I).Item("Complemento").ToString
            Dim strNum As String = "" 'dt.Rows.Item(I).Item("Num").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strMeta As Integer = 0 'dt.Rows.Item(I).Item("Meta").ToString
            Dim strBanco As String = dt.Rows.Item(I).Item("Cod").ToString
            Dim strAgencia As String = "" 'dt.Rows.Item(I).Item("Agencia").ToString
            Dim strContaCorrente As String = "" 'dt.Rows.Item(I).Item("ContaCorrente").ToString
            Dim strCodUser As Integer = 0 'dt.Rows.Item(I).Item("CodUser").ToString
            Dim strComServ As String = dt.Rows.Item(I).Item("Porcentagem").ToString


            If bolPassou = False Then
                Query = "INSERT INTO Funcionario(Nome, CPF, RG, Telefone, Celular, Endereco, Bairro, Cidade, " & _
                "Nascimento, Obs, PorcComissao, Funcao, DataAdmissao, DataDemissao, Email, Ativo, Sangue, Alergia, " & _
                "CEP, UF, Complemento, Num, CodConfig, Meta, Banco, Agencia, ContaCorrente, CodUser, ComServ) " & _
                "Values('" & strNome & "','" & strCPF & "','" & strRG & "','" & strTelefone & "','" & strCelular & "'," & _
                "'" & strEndereco & "','" & strBairro & "','" & strCidade & "','" & strNascimento & "'," & _
                "'" & strObs & "','" & strPorcComissao & "','" & strFuncao & "','" & strDataAdmissao & "'," & _
                "'" & strDataDemissao & "','" & strEmail & "','" & strAtivo & "','" & strSangue & "','" & strAlergia & "'," & _
                "'" & strCEP & "','" & strUF & "','" & strComplemento & "','" & strNum & "','" & strCodConfig & "'," & _
                "" & strMeta & ",'" & strBanco & "','" & strAgencia & "','" & strContaCorrente & "'," & strCodUser & "," & _
                "'" & strComServ & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Funcionario(Nome, CPF, RG, Telefone, Celular, " & _
                "Endereco, Bairro, Cidade, Nascimento, Obs, PorcComissao, Funcao, DataAdmissao, DataDemissao, Email, " & _
                "Ativo, Sangue, Alergia, CEP, UF, Complemento, Num, CodConfig, Meta, Banco, Agencia, ContaCorrente, " & _
                "CodUser, ComServ) Values('" & strNome & "','" & strCPF & "','" & strRG & "','" & strTelefone & "'," & _
                "'" & strCelular & "','" & strEndereco & "','" & strBairro & "','" & strCidade & "','" & strNascimento & "'," & _
                "'" & strObs & "','" & strPorcComissao & "','" & strFuncao & "','" & strDataAdmissao & "'," & _
                "'" & strDataDemissao & "','" & strEmail & "','" & strAtivo & "','" & strSangue & "','" & strAlergia & "'," & _
                "'" & strCEP & "','" & strUF & "','" & strComplemento & "','" & strNum & "','" & strCodConfig & "'," & _
                "" & strMeta & ",'" & strBanco & "','" & strAgencia & "','" & strContaCorrente & "'," & strCodUser & "," & _
                "'" & strComServ & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "Funcionario"
        Me.lblTabAtual.Text = "Total"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********TOTAL**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM TOTAL Where Status = 'Faturado' And CodConfig is not null order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString
            Dim strCodOrdem As String = dt.Rows.Item(I).Item("Cod").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString


            Dim dtCodCli As DataTable = CarregarDataTable("Select Codigo From Cliente Where CPF='" & dt.Rows.Item(I).Item("CPF").ToString & "'")

            Dim strCodCli As String = ""
            If dtCodCli.Rows.Count Then
                strCodCli = dtCodCli.Rows.Item(0).Item("Codigo").ToString()
            End If

            Dim strTotal As String = dt.Rows.Item(I).Item("Total").ToString
            Dim strRecebido As String = dt.Rows.Item(I).Item("Recebido").ToString
            Dim strTroco As String = dt.Rows.Item(I).Item("Troco").ToString
            Dim strPorDesc As String = 0 'dt.Rows.Item(I).Item("PorDesc").ToString
            Dim strValDesc As String = 0 'dt.Rows.Item(I).Item("ValDesc").ToString
            Dim strPorAcre As String = 0 'dt.Rows.Item(I).Item("PorAcre").ToString
            Dim strValAcre As String = 0 'dt.Rows.Item(I).Item("ValAcre").ToString
            Dim strCusto As String = dt.Rows.Item(I).Item("Custo").ToString

            Dim strEmitirCupom As String = dt.Rows.Item(I).Item("EmitirCupom").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            'Dim strHora As String = dt.Rows.Item(I).Item("Hora").ToString
            Dim strStatusDAV As String = dt.Rows.Item(I).Item("StatusDAV").ToString
            Dim strNumDAV As String = dt.Rows.Item(I).Item("NumDAV").ToString
            Dim strNFP As String = dt.Rows.Item(I).Item("NFP").ToString
            Dim strCPFCliente As String = dt.Rows.Item(I).Item("CPFCliente").ToString
            Dim strCodPedido As String = strCodOrdem 'dt.Rows.Item(I).Item("CodPedido").ToString
            Dim strAuxiliar As String = "" 'dt.Rows.Item(I).Item("Auxiliar").ToString
            'Dim strCodNFe As String = dt.Rows.Item(I).Item("CodNFe").ToString
            Dim strCodOrdensTEF As String = "" 'dt.Rows.Item(I).Item("CodOrdensTEF").ToString
            Dim strPlaca As String = dt.Rows.Item(I).Item("Placa").ToString
            Dim strModelo As String = dt.Rows.Item(I).Item("Modelo").ToString

            Dim dtKM As DataTable = CarregarDataTable2("Select KmSaida, Prisma From EntradaSaida Where CodigoPedido=" & strCodOrdem & " And CodConfig=" & strCodConfig & "", strNomeBanco)

            Dim strKM As String = ""
            Dim strHora As String = ""
            If dtKM.Rows.Count Then
                strKM = dtKM.Rows.Item(0).Item("KmSaida").ToString()
                strHora = Date.Now.ToString("HH:mm")
            End If

            Dim strCodNFe As String = ""
            If strUsarNfe = "0" Then
                strCodNFe = dt.Rows.Item(I).Item("CodNFe").ToString()
            End If

            If bolPassou = False Then
                Query = "INSERT INTO Total(CodOrdem, Data, CodCli, Total, Recebido, Troco, PorDesc, ValDesc, " & _
                "PorAcre, ValAcre, Custo, EmitirCupom, CodConfig, Hora, StatusDAV, NumDAV, NFP, CPFCliente, " & _
                "CodPedido, Auxiliar, CodOrdensTEF, Placa, Modelo, KM, CodNFe) Values('" & strCodOrdem & "'," & _
                "'" & strData & "','" & strCodCli & "'," & Num(strTotal) & "," & Num(strRecebido) & "," & Num(strTroco) & "," & _
                "" & Num(strPorDesc) & "," & Num(strValDesc) & "," & Num(strPorAcre) & "," & Num(strValAcre) & "," & _
                "" & Num(strCusto) & ",'" & strEmitirCupom & "','" & strCodConfig & "','" & strHora & "'," & _
                "'" & strStatusDAV & "','" & strNumDAV & "','" & strNFP & "','" & strCPFCliente & "'," & _
                "'" & strCodPedido & "','" & strAuxiliar & "','" & strCodOrdensTEF & "'," & _
                "'" & strPlaca & "','" & strModelo & "','" & strKM & "','" & strCodNFe & "');"
                'Inserir(Query)
                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Total(CodOrdem, Data, CodCli, Total, " & _
                "Recebido, Troco, PorDesc, ValDesc, PorAcre, ValAcre, Custo, EmitirCupom, CodConfig, Hora, " & _
                "StatusDAV, NumDAV, NFP, CPFCliente, CodPedido, Auxiliar, CodOrdensTEF, Placa, Modelo, KM, CodNFe) " & _
                "Values('" & strCodOrdem & "','" & strData & "','" & strCodCli & "'," & Num(strTotal) & "," & _
                "" & Num(strRecebido) & "," & Num(strTroco) & "," & Num(strPorDesc) & "," & Num(strValDesc) & "," & _
                "" & Num(strPorAcre) & "," & Num(strValAcre) & "," & Num(strCusto) & ",'" & strEmitirCupom & "'," & _
                "'" & strCodConfig & "','" & strHora & "','" & strStatusDAV & "','" & strNumDAV & "','" & strNFP & "'," & _
                "'" & strCPFCliente & "','" & strCodPedido & "','" & strAuxiliar & "'," & _
                "'" & strCodOrdensTEF & "','" & strPlaca & "','" & strModelo & "','" & strKM & "','" & strCodNFe & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "Total"
        Me.lblTabAtual.Text = "Pedido"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********PEDIDO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Pedido Where Status = 'Faturado' And CodConfig is not null order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString
            Dim strCodOrdem As String = dt.Rows.Item(I).Item("Cod").ToString

            Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString.Replace(":", ",")
            Dim strProduto As String = dt.Rows.Item(I).Item("Produto").ToString.Replace("'", "´").Trim
            Dim strValorUnitario As String = dt.Rows.Item(I).Item("ValorUnitario").ToString
            Dim strValorTotal As String = dt.Rows.Item(I).Item("ValorTotal").ToString
            Dim strCodProdInterno As String = dt.Rows.Item(I).Item("CodigoPeca").ToString
            Dim strUM As String = dt.Rows.Item(I).Item("UM").ToString

            Dim dtCodProd As DataTable = CarregarDataTable("Select Codigo From Produto Where Locacao2='" & dt.Rows.Item(I).Item("CodigoProduto").ToString & "'")
            Dim strCodProd As String = "" 'dt.Rows.Item(I).Item("CodigoProduto").ToString

            If dtCodProd.Rows.Count > 0 Then
                strCodProd = dtCodProd.Rows.Item(0).Item("Codigo").ToString
            End If

            If strCodProd = "" Then
                Dim dtCodProd2 As DataTable = CarregarDataTable("Select Codigo From Produto Where CodigoInterno='" & strCodProdInterno & "'")

                If dtCodProd2.Rows.Count > 0 Then
                    strCodProd = dtCodProd2.Rows.Item(0).Item("Codigo").ToString
                End If
            End If

            If strCodProd = "" Then
                dtCodProd = CarregarDataTable("Select Codigo, CodigoInterno, UnidadeMedida From Produto Where Nome='PRODUTO DIGITADO'")
                If dtCodProd.Rows.Count > 0 Then
                    strCodProd = dtCodProd.Rows.Item(0).Item("Codigo").ToString
                    strCodProdInterno = dtCodProd.Rows.Item(0).Item("CodigoInterno").ToString
                    strUM = dtCodProd.Rows.Item(0).Item("UnidadeMedida").ToString
                End If
            End If
            If strUM = "" Then
                strUM = "UN"
            End If

            Dim dtCodFunc As DataTable = CarregarDataTable("Select Codigo From Funcionario " & _
            "Where Banco='" & dt.Rows.Item(I).Item("CodigoFuncionario").ToString & "'")
            Dim strCodFunc As String = "" 'dt.Rows.Item(I).Item("CodigoFuncionario").ToString

            If dtCodFunc.Rows.Count > 0 Then
                strCodFunc = dtCodFunc.Rows.Item(0).Item("Codigo").ToString
            End If

            Dim strCusto As String = dt.Rows.Item(I).Item("Custo").ToString
            Dim strTamanho As String = "U" 'dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strDevolvido As String = "False" 'dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strLote As String = "U" 'dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strTipoItens As String = dt.Rows.Item(I).Item("TipoProduto").ToString
            If strTipoItens = "PEÇA" Then
                strTipoItens = "VENDA"
            End If
            If strTipoItens = "INTERNO" Then
                strTipoItens = "CONSUMO"
            End If
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strCodMecanico As String = 0 'dt.Rows.Item(I).Item("CodigoFuncionario").ToString
            Dim strDesconto As String = 0 'dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strUniSemDesc As String = dt.Rows.Item(I).Item("UniSemDesc").ToString
            Dim strAuxiliar As String = "" 'dt.Rows.Item(I).Item("CodMunicipio").ToString

            'If strCodOrdem Then
            If bolPassou = False Then
                Query = "INSERT INTO Pedido(CodOrdem, Qtd, CodProd, Produto, ValorUnitario, ValorTotal, " & _
                "CodProdInterno, CodFunc, Custo, Tamanho, UM, Devolvido, Lote, TipoItens, CodConfig, CodMecanico, " & _
                "Desconto, UniSemDesc, Auxiliar) Values('" & strCodOrdem & "'," & Num(strQtd) & ",'" & strCodProd & "'," & _
                "'" & strProduto & "'," & Num(strValorUnitario) & "," & Num(strValorTotal) & ",'" & strCodProdInterno & "'," & _
                "'" & strCodFunc & "'," & Num(strCusto) & ",'" & strTamanho & "','" & strUM & "','" & strDevolvido & "'," & _
                "'" & strLote & "','" & strTipoItens & "'," & strCodConfig & "," & strCodMecanico & "," & strDesconto & "," & _
                "" & Num(strUniSemDesc) & ",'" & strAuxiliar & "');"
                'Inserir(Query)
                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Pedido(CodOrdem, Qtd, CodProd, Produto, ValorUnitario, " & _
                "ValorTotal, CodProdInterno, CodFunc, Custo, Tamanho, UM, Devolvido, Lote, TipoItens, CodConfig, CodMecanico, " & _
                "Desconto, UniSemDesc, Auxiliar) Values('" & strCodOrdem & "'," & Num(strQtd) & ",'" & strCodProd & "'," & _
                "'" & strProduto & "'," & Num(strValorUnitario) & "," & Num(strValorTotal) & ",'" & strCodProdInterno & "'," & _
                "'" & strCodFunc & "'," & Num(strCusto) & ",'" & strTamanho & "','" & strUM & "','" & strDevolvido & "'," & _
                "'" & strLote & "','" & strTipoItens & "'," & strCodConfig & "," & strCodMecanico & "," & strDesconto & "," & _
                "" & Num(strUniSemDesc) & ",'" & strAuxiliar & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If
            'End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        'Inserir("Update Pedido Set CodProd=case when Produto.Codigo is not null then Produto.Codigo else 0 end " & _
        '       "From Pedido Left Join Produto on Pedido.CodigoInterno = Produto.CodigoInterno")

        'Inserir("Update Pedido Set CodFunc=case when Funcionario.Codigo is not null then Funcionario.Codigo else 0 end " & _
        '        "From Pedido Left Join Funcionario on Pedido.CodFunc = Funcionario.Banco")
        strTabela = "Pedido"
        Me.lblTabAtual.Text = "TotalConsig"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********TOTALCONSIG**********
        B = 1
        'dt = CarregarDataTable2("SELECT * FROM Total Where Status <> 'Faturado' order by Codigo", strNomeBanco)
        dt = CarregarDataTable2("SELECT * FROM Total Where CodConfig is not null order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strCodOrdens As String = dt.Rows.Item(I).Item("Cod").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString

            Dim dtCodCli As DataTable = CarregarDataTable("Select Codigo From Cliente Where CPF='" & dt.Rows.Item(I).Item("CPF").ToString & "'")

            Dim strCodCli As String = ""
            If dtCodCli.Rows.Count Then
                strCodCli = dtCodCli.Rows.Item(0).Item("Codigo").ToString()
            End If


            Dim strTotal As String = dt.Rows.Item(I).Item("Total").ToString
            Dim strDescricao As String = dt.Rows.Item(I).Item("Descricao").ToString
            Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
            Dim strCusto As String = dt.Rows.Item(I).Item("Custo").ToString

            Dim strDesconto As String = 0 'dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strEntrega As String = "" 'dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strCodFunc As String = 1 'dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strDataVenda As String = "" 'dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strCodAnimal As String = 0 'dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strAcrescimo As String = 0 'dt.Rows.Item(I).Item("CodMunicipio").ToString

            Dim strDataRetirada As String = "" 'dt.Rows.Item(I).Item("Entrada").ToString
            Try
                Dim dt2 As Date = dt.Rows.Item(I).Item("Entrada").ToString()
                strDataRetirada = dt2.ToString("dd/MM/yy")
            Catch ex As Exception
                strDataRetirada = strData
            End Try
            If strDataRetirada <> "" Then
                If strDataRetirada.Length = 8 Then
                    Dim vetDataR As Array = strDataRetirada.Split("/")
                    Dim strDiaR, strMesR, strAnoR As String
                    strDiaR = vetDataR(0).ToString
                    strMesR = vetDataR(1).ToString
                    strAnoR = vetDataR(2).ToString
                    strAnoR = "20" + strAnoR

                    strDataRetirada = strDiaR & "/" & strMesR & "/" & strAnoR
                End If
            End If
            If strDataRetirada.Length < 10 Then
                strDataRetirada = strData
            End If

            Dim strDataEntrega As String = "" 'dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strComanda As String = "" 'dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strStatusPedido As String = "" 'dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strPlaca As String = dt.Rows.Item(I).Item("Placa").ToString
            Dim strSinistro As String = dt.Rows.Item(I).Item("Sinistro").ToString
            Dim strModelo As String = dt.Rows.Item(I).Item("Modelo").ToString

            Dim dtCarro As DataTable = CarregarDataTable2("SELECT Ano, Modelo, Motor, Cor FROM Carro Where Placa='" & strPlaca & "'", strNomeBanco)

            Dim strAno As String = ""
            'Dim strModelo As String = ""
            Dim strMotor As String = ""
            Dim strCor As String = ""
            If dtCarro.Rows.Count > 0 Then
                strAno = dtCarro.Rows.Item(0).Item("Ano").ToString
                'strModelo = dtCarro.Rows.Item(0).Item("Modelo").ToString
                strMotor = dtCarro.Rows.Item(0).Item("Motor").ToString
                strCor = dtCarro.Rows.Item(0).Item("Cor").ToString
            End If
            If strCodOrdens = "16047" Then
                strCodOrdens = strCodOrdens
            End If

            Dim dtEntrada As DataTable = CarregarDataTable2("SELECT * FROM EntradaSaida Where CodigoPedido='" & strCodOrdens & "' And CodConfig=" & strCodConfig & "", strNomeBanco)

            Dim strNivelCombustivel As String = ""
            Dim strKMSaida As String = ""
            Dim strKMEntrada As String = ""
            If dtEntrada.Rows.Count > 0 Then
                strNivelCombustivel = dtEntrada.Rows.Item(0).Item("NivelCombustivel").ToString
                strKMSaida = dtEntrada.Rows.Item(0).Item("KMSaida").ToString
                strKMEntrada = dtEntrada.Rows.Item(0).Item("KMEntrada").ToString
                'strDataEntrega = "" 'dtEntrada.Rows.Item(0).Item("Saida").ToString
                Try
                    Dim dt3 As Date = dtEntrada.Rows.Item(0).Item("Saida").ToString
                    'If strCodOrdens = "13936" Then
                    strDataEntrega = dt3.ToString("dd/MM/yy")
                    'Else
                    'strDataEntrega = dt3.ToString("dd/MM/yyyy")
                    'End If
                Catch ex As Exception
                    If strStatus = "Faturado" Then
                        strDataEntrega = strData
                    End If
                End Try
                'If strCodOrdens = "13936" Then
                If strDataEntrega <> "" Then
                    If strDataEntrega.Length = 8 Then
                        Dim vetDataE As Array = strDataEntrega.Split("/")
                        Dim strDiaE, strMesE, strAnoE As String
                        strDiaE = vetDataE(0).ToString
                        strMesE = vetDataE(1).ToString
                        strAnoE = vetDataE(2).ToString
                        strAnoE = "20" + strAnoE

                        strDataEntrega = strDiaE & "/" & strMesE & "/" & strAnoE
                    End If
                End If
                'End If
                If strDataEntrega.Length < 10 Then
                    If strStatus = "Faturado" Then
                        strDataEntrega = strData
                    End If
                End If
            End If

            Dim strSeguro As String = ""


            If bolPassou = False Then
                Query = "INSERT INTO TotalConsig(CodOrdens, Data, CodCli, Total, Descricao, Status, Custo, Desconto, Entrega, CodFunc, " & _
                "CodConfig, DataVenda, CodAnimal, Acrescimo, DataRetirada, DataEntrega, Comanda, StatusPedido, Placa, Modelo, " & _
                "Cor, Ano, Motor, NivelCombustivel, KMSaida, KMEntrada, Seguro, Sinistro) Values('" & strCodOrdens & "','" & strData & "'," & _
                "'" & strCodCli & "'," & Num(strTotal) & ",'" & strDescricao & "','" & strStatus & "'," & Num(strCusto) & "," & _
                "" & Num(strDesconto) & ",'" & strEntrega & "'," & strCodFunc & "," & strCodConfig & ",'" & strDataVenda & "'," & _
                "" & strCodAnimal & "," & Num(strAcrescimo) & ",'" & strDataRetirada & "','" & strDataEntrega & "','" & strComanda & "'," & _
                "'" & strStatusPedido & "','" & strPlaca & "','" & strModelo & "','" & strCor & "','" & strAno & "','" & strMotor & "'," & _
                "'" & strNivelCombustivel & "','" & strKMSaida & "','" & strKMEntrada & "','" & strSeguro & "','" & strSinistro & "');"
                'Inserir(Query)
                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO TotalConsig(CodOrdens, Data, CodCli, Total, Descricao, " & _
                "Status, Custo, Desconto, Entrega, CodFunc, CodConfig, DataVenda, CodAnimal, Acrescimo, DataRetirada, DataEntrega, " & _
                "Comanda, StatusPedido, Placa, Modelo, Cor, Ano, Motor, NivelCombustivel, KMSaida, KMEntrada, Seguro, Sinistro) " & _
                "Values('" & strCodOrdens & "','" & strData & "','" & strCodCli & "'," & Num(strTotal) & ",'" & strDescricao & "'," & _
                "'" & strStatus & "'," & Num(strCusto) & "," & Num(strDesconto) & ",'" & strEntrega & "'," & strCodFunc & "," & _
                "" & strCodConfig & ",'" & strDataVenda & "'," & strCodAnimal & "," & Num(strAcrescimo) & ",'" & strDataRetirada & "'," & _
                "'" & strDataEntrega & "','" & strComanda & "','" & strStatusPedido & "','" & strPlaca & "','" & strModelo & "'," & _
                "'" & strCor & "','" & strAno & "','" & strMotor & "','" & strNivelCombustivel & "','" & strKMSaida & "'," & _
                "'" & strKMEntrada & "','" & strSeguro & "','" & strSinistro & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "TotalConsig"
        Me.lblTabAtual.Text = "ItensConsig"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********ITENSCONSIG**********
        B = 1
        'dt = CarregarDataTable2("SELECT * FROM Pedido Where Status <> 'Faturado' order by Codigo", strNomeBanco)
        dt = CarregarDataTable2("SELECT * FROM Pedido Where CodConfig is not null order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strCodOrdens As String = dt.Rows.Item(I).Item("Cod").ToString
            Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString.Replace(":", ",")
            Dim strProduto As String = dt.Rows.Item(I).Item("Produto").ToString
            Dim strValorUnitario As String = dt.Rows.Item(I).Item("ValorUnitario").ToString
            Dim strValorTotal As String = dt.Rows.Item(I).Item("ValorTotal").ToString
            Dim strCodigoInterno As String = dt.Rows.Item(I).Item("CodigoPeca").ToString
            Dim strUM As String = dt.Rows.Item(I).Item("UM").ToString

            Dim dtCodProd As DataTable = CarregarDataTable("Select Codigo From Produto Where CodigoInterno='" & strCodigoInterno & "'")
            Dim strCodigoProduto As String = "" 'dt.Rows.Item(I).Item("CodigoProduto").ToString

            If dtCodProd.Rows.Count > 0 Then
                strCodigoProduto = dtCodProd.Rows.Item(0).Item("Codigo").ToString
            End If

            If strCodigoProduto = "" Then
                dtCodProd = CarregarDataTable("Select Codigo, CodigoInterno, UnidadeMedida " & _
                "From Produto Where Nome='PRODUTO DIGITADO'")
                If dtCodProd.Rows.Count > 0 Then
                    strCodigoProduto = dtCodProd.Rows.Item(0).Item("Codigo").ToString
                    strCodigoInterno = dtCodProd.Rows.Item(0).Item("CodigoInterno").ToString
                    strUM = dtCodProd.Rows.Item(0).Item("UnidadeMedida").ToString
                End If
            End If

            If strUM = "" Then
                strUM = "UN"
            End If

            Dim strCusto As String = dt.Rows.Item(I).Item("Custo").ToString
            Dim strTamanho As String = "U" 'dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString

            Dim strUniSemDesc As String = dt.Rows.Item(I).Item("UniSemDesc").ToString
            Dim strPromocao As String = "False" 'dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strDesconto As String = 0 'dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strRetorno As String = "" 'dt.Rows.Item(I).Item("Retorno").ToString
            Dim strMedidaA As String = 0 'dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strMedidaB As String = 0 'dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strQtdMedida As String = 0 'dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strDataAdd As String = dt.Rows.Item(I).Item("Data").ToString

            Dim dtCodFunc As DataTable = CarregarDataTable("Select Codigo From Funcionario " & _
            "Where Banco='" & dt.Rows.Item(I).Item("CodigoFuncionario").ToString & "'")

            Dim strCodigoFuncionario As String = "" 'dt.Rows.Item(I).Item("CodigoFuncionario").ToString
            If dtCodFunc.Rows.Count > 0 Then
                strCodigoFuncionario = dtCodFunc.Rows.Item(0).Item("Codigo").ToString
            End If

            If strCodigoFuncionario = "" Then
                strCodigoFuncionario = 0
            End If

            Dim strAutorizado As String = "True" 'dt.Rows.Item(I).Item("CodMunicipio").ToString


            If strCodOrdens <> "" Then
                If bolPassou = False Then
                    Query = "INSERT INTO ItensConsig(CodOrdens, Qtd, CodigoProduto, Produto, ValorUnitario, ValorTotal, " & _
                    "CodigoInterno, Custo, UM, Tamanho, CodConfig, UniSemDesc, Promocao, Desconto, Retorno, MedidaA, " & _
                    "MedidaB, QtdMedida, DataAdd, CodigoFuncionario, Autorizado) Values('" & strCodOrdens & "'," & _
                    "" & Num(strQtd) & ",'" & strCodigoProduto & "','" & strProduto & "'," & Num(strValorUnitario) & "," & _
                    "" & Num(strValorTotal) & ",'" & strCodigoInterno & "'," & Num(strCusto) & ",'" & strUM & "'," & _
                    "'" & strTamanho & "'," & strCodConfig & "," & Num(strUniSemDesc) & ",'" & Num(strPromocao) & "'," & _
                    "" & Num(strDesconto) & ",'" & strRetorno & "'," & Num(strMedidaA) & "," & Num(strMedidaB) & "," & _
                    "" & Num(strQtdMedida) & ",'" & strDataAdd & "'," & strCodigoFuncionario & ",'" & strAutorizado & "');"

                    bolPassou = True
                Else
                    Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO ItensConsig(CodOrdens, Qtd, CodigoProduto, " & _
                    "Produto, ValorUnitario, ValorTotal, CodigoInterno, Custo, UM, Tamanho, CodConfig, UniSemDesc, Promocao, " & _
                    "Desconto, Retorno, MedidaA, MedidaB, QtdMedida, DataAdd, CodigoFuncionario, Autorizado) " & _
                    "Values('" & strCodOrdens & "'," & Num(strQtd) & ",'" & strCodigoProduto & "','" & strProduto & "'," & _
                    "" & Num(strValorUnitario) & "," & Num(strValorTotal) & ",'" & strCodigoInterno & "'," & Num(strCusto) & "," & _
                    "'" & strUM & "','" & strTamanho & "'," & strCodConfig & "," & Num(strUniSemDesc) & ",'" & Num(strPromocao) & "'," & _
                    "" & Num(strDesconto) & ",'" & strRetorno & "'," & Num(strMedidaA) & "," & Num(strMedidaB) & "," & _
                    "" & Num(strQtdMedida) & ",'" & strDataAdd & "'," & strCodigoFuncionario & ",'" & strAutorizado & "');"

                End If

                count = count + 1
                If count = 500 Then
                    Inserir(Query)
                    System.Threading.Thread.Sleep(40)

                    Query = ""
                    count = 0
                End If
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        'Inserir("Update ItensConsig Set CodigoProduto=case when Produto.Codigo is not null then Produto.Codigo else 0 end " & _
        '       "From ItensConsig Left Join Produto on ItensConsig.CodigoProduto = Produto.Locacao2")

        'Inserir("Update ItensConsig Set CodigoFuncionario=case when Funcionario.Codigo is not null then Funcionario.Codigo else '' end " & _
        '        "From ItensConsig Left Join Funcionario on ItensConsig.CodigoFuncionario = Funcionario.Banco")
        strTabela = "ItensConsig"
        Me.lblTabAtual.Text = "ContaReceber"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********CONTARECEBER**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM ContaReceber order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strCodOrdem As String = dt.Rows.Item(I).Item("Cod").ToString
            Dim strDataVenda As String = dt.Rows.Item(I).Item("DataServiço").ToString

            Dim dtCodCli As DataTable = CarregarDataTable("Select Codigo From Cliente Where Pessoa1='" & dt.Rows.Item(I).Item("CodCli").ToString & "'")
            Dim strCodCli As String = "" 'dt.Rows.Item(I).Item("CodCli").ToString
            If dtCodCli.Rows.Count > 0 Then
                strCodCli = dtCodCli.Rows.Item(0).Item("Codigo").ToString
            End If

            If strCodCli = "" Then
                strCodCli = 1
            End If

            Dim strObs As String = "" 'dt.Rows.Item(I).Item("Obs").ToString
            Dim strFormaPagamento As String = dt.Rows.Item(I).Item("FormaPagamento").ToString
            Dim strParcelas As String = dt.Rows.Item(I).Item("Parcelas").ToString
            Dim strValorParcela As String = dt.Rows.Item(I).Item("ValorParcela").ToString
            Dim strVencimento As String = dt.Rows.Item(I).Item("Vencimeto").ToString
            Dim strValorVenda As String = dt.Rows.Item(I).Item("Valor").ToString
            Dim strValorRecebido As String = dt.Rows.Item(I).Item("ValorRecebido").ToString
            Dim strRecebimento As String = dt.Rows.Item(I).Item("Recebimento").ToString
            Dim strRecebidoOK As String = dt.Rows.Item(I).Item("RecebidoOK").ToString
            Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
            Dim strNumeroDocumento As String = dt.Rows.Item(I).Item("NumeroDocumento").ToString
            Dim strTipoCusto As String = dt.Rows.Item(I).Item("TipoCusto").ToString
            Dim strBanco As String = dt.Rows.Item(I).Item("Banco").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strCodLojaBaixa As String = "" 'dt.Rows.Item(I).Item("CodLojaBaixa").ToString
            Dim strComissao As String = 0 'dt.Rows.Item(I).Item("Comissao").ToString
            Dim strCodigoPedido As String = "" 'dt.Rows.Item(I).Item("CodigoPedido").ToString
            Dim strCentroCusto As String = dt.Rows.Item(I).Item("CentroCusto").ToString
            Dim strAuxiliar As String = "" 'dt.Rows.Item(I).Item("Auxiliar").ToString



            If bolPassou = False Then
                Query = "INSERT INTO ContaReceber(CodOrdem, DataVenda, CodCli, Obs, FormaPagamento, Parcelas, " & _
                "ValorParcela, Vencimento, ValorVenda, ValorRecebido, Recebimento, RecebidoOK, Pagamento, " & _
                "NumeroDocumento, TipoCusto, Banco, CodConfig, CodLojaBaixa, Comissao, CodigoPedido, CentroCusto, " & _
                "Auxiliar) Values('" & strCodOrdem & "','" & strDataVenda & "','" & strCodCli & "','" & strObs & "'," & _
                "'" & strFormaPagamento & "','" & strParcelas & "'," & Num(strValorParcela) & ",'" & strVencimento & "'," & _
                "" & Num(strValorVenda) & "," & Num(strValorRecebido) & ",'" & strRecebimento & "','" & strRecebidoOK & "'," & _
                "'" & strPagamento & "','" & strNumeroDocumento & "','" & strTipoCusto & "','" & strBanco & "'," & _
                "'" & strCodConfig & "','" & strCodLojaBaixa & "'," & strComissao & ",'" & strCodigoPedido & "'," & _
                "'" & strCentroCusto & "','" & strAuxiliar & "');"
                'Inserir(Query)
                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO ContaReceber(CodOrdem, DataVenda, CodCli, Obs, " & _
                "FormaPagamento, Parcelas, ValorParcela, Vencimento, ValorVenda, ValorRecebido, Recebimento, RecebidoOK, " & _
                "Pagamento, NumeroDocumento, TipoCusto, Banco, CodConfig, CodLojaBaixa, Comissao, CodigoPedido, CentroCusto, " & _
                "Auxiliar) Values('" & strCodOrdem & "','" & strDataVenda & "','" & strCodCli & "','" & strObs & "'," & _
                "'" & strFormaPagamento & "','" & strParcelas & "'," & Num(strValorParcela) & ",'" & strVencimento & "'," & _
                "" & Num(strValorVenda) & "," & Num(strValorRecebido) & ",'" & strRecebimento & "','" & strRecebidoOK & "'," & _
                "'" & strPagamento & "','" & strNumeroDocumento & "','" & strTipoCusto & "','" & strBanco & "'," & _
                "'" & strCodConfig & "','" & strCodLojaBaixa & "'," & strComissao & ",'" & strCodigoPedido & "'," & _
                "'" & strCentroCusto & "','" & strAuxiliar & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        'Inserir("Update ContaReceber set CodCli=Cliente.Codigo From ContaReceber Left Join Cliente on " & _
        '"ContaReceber.CodCli = Cliente.Pessoa1")
        strTabela = "ContaReceber"
        Me.lblTabAtual.Text = "Config"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********CONFIG**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Config order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strEmpresa As String = dt.Rows.Item(I).Item("Empresa").ToString
            Dim strTelefone As String = dt.Rows.Item(I).Item("Telefone").ToString
            Dim strEndereco As String = dt.Rows.Item(I).Item("Endereco").ToString
            Dim strCNPJ As String = dt.Rows.Item(I).Item("CNPJ").ToString
            Dim strOrigemRelease As String = "" 'dt.Rows.Item(I).Item("OrigemRelease").ToString
            'Dim strLogo As String = dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strVersaoNano As String = "3.8.5" 'dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strEmiteCupom As String = dt.Rows.Item(I).Item("EmiteCupom").ToString
            Dim strUsaTEF As String = 0 'dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strCaminhoRemessa As String = "" 'dt.Rows.Item(I).Item("CaminhoDaPastaRemessa").ToString
            Dim strNumArqRM As String = dt.Rows.Item(I).Item("NumArqRM").ToString
            Dim strTemImpressora As String = dt.Rows.Item(I).Item("TemImpressora").ToString
            Dim strCidade As String = "" 'dt.Rows.Item(I).Item("Cidade").ToString
            Dim strModeloCarne As String = 0 'dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strTipoNano As String = 5 'dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strPastaSinc As String = "" 'dt.Rows.Item(I).Item("PastaSinc").ToString
            Dim strDescricao As String = dt.Rows.Item(I).Item("Descricao").ToString

            Dim strGerarComissao As String = dt.Rows.Item(I).Item("TipoComissao").ToString
            If strGerarComissao <> "N" Then
                strGerarComissao = "True"
            Else
                strGerarComissao = "False"
            End If

            Dim strValidarCPF As String = dt.Rows.Item(I).Item("ValidarCPF").ToString
            If strValidarCPF = "VALIDAR" Then
                strValidarCPF = "True"
            Else
                strValidarCPF = "False"
            End If

            Dim strTemGuilhotina As String = dt.Rows.Item(I).Item("TemGuilhotina").ToString
            Dim strNomePCImpressora As String = "" 'dt.Rows.Item(I).Item("NomePCImpressora").ToString
            Dim strTolerancia As String = dt.Rows.Item(I).Item("Tolerancia").ToString
            Dim strJuros As String = dt.Rows.Item(I).Item("Juros").ToString
            Dim strEstoqueZerado As String = dt.Rows.Item(I).Item("EstoqueZerado").ToString
            Dim strAlterarParcelas As String = "False" 'dt.Rows.Item(I).Item("AlterarParcelas").ToString
            Dim strImpressora As String = "" 'dt.Rows.Item(I).Item("Impressora").ToString
            Dim strPorta As String = dt.Rows.Item(I).Item("Porta").ToString
            Dim strJurosParcela As String = dt.Rows.Item(I).Item("JurosParcela").ToString
            Dim strTipoDesc As String = "" 'dt.Rows.Item(I).Item("TipoDesc").ToString
            Dim strImpCodBarra As String = "" 'dt.Rows.Item(I).Item("ImpCodBarra").ToString
            Dim strValidarCep As String = dt.Rows.Item(I).Item("ValidarCep").ToString
            Dim strCredito As String = "" 'dt.Rows.Item(I).Item("Credito").ToString
            Dim strPortaImpCodBarra As String = "" 'dt.Rows.Item(I).Item("PortaImpCodBarra").ToString
            Dim strTemGaveta As String = dt.Rows.Item(I).Item("TemGaveta").ToString
            Dim strDescontoMaximo As String = dt.Rows.Item(I).Item("DescontoMaximo").ToString
            Dim strMensalista As String = dt.Rows.Item(I).Item("Mensalista").ToString
            Dim strUsaNfe As String = dt.Rows.Item(I).Item("UsaNfe").ToString
            Dim strCaminhoPastaNfe As String = dt.Rows.Item(I).Item("CaminhoPastaNfe").ToString
            Dim strImpostoPorItem As String = dt.Rows.Item(I).Item("ImpostoPorItem").ToString
            Dim strImportarNfe As String = dt.Rows.Item(I).Item("ImportarNfe").ToString
            Dim strCaminhoPastaNotaNfe As String = dt.Rows.Item(I).Item("CaminhoPastaNotaNfe").ToString
            Dim strSegViaRecibo As String = "False" 'dt.Rows.Item(I).Item("SegViaRecibo").ToString
            Dim strCaminhoPastaXML As String = "" 'dt.Rows.Item(I).Item("CaminhoPastaXML").ToString
            Dim strCaminhoPastaPDF As String = "" 'dt.Rows.Item(I).Item("CaminhoPastaPDF").ToString
            Dim strPafEcfNano As String = dt.Rows.Item(I).Item("PafEcfNano").ToString
            Dim strZeroCodProd As String = "False" 'dt.Rows.Item(I).Item("ZeroCodProd").ToString
            Dim strValorAproximado As String = dt.Rows.Item(I).Item("ValorAproximado").ToString
            Dim strBalancaPor As String = "" 'dt.Rows.Item(I).Item("BalancaPor").ToString
            Dim strAltPrecoPedido As String = "False" 'dt.Rows.Item(I).Item("AltPrecoPedido").ToString
            Dim strDescricaoPedido As String = dt.Rows.Item(I).Item("DescricaoPedido").ToString
            Dim strAltNomePedido As String = dt.Rows.Item(I).Item("AltNomePedido").ToString
            Dim strTrocoCaixa As String = "False" 'dt.Rows.Item(I).Item("TrocoCaixa").ToString
            Dim strPedidoCompleto As String = "False" 'dt.Rows.Item(I).Item("PedidoCompleto").ToString

            Dim strOcultarAutorizacao As String = dt.Rows.Item(I).Item("OcultarAutorizacao").ToString

            If strOcultarAutorizacao = "NÃO" Then
                strOcultarAutorizacao = "False"
            Else
                strOcultarAutorizacao = "True"
            End If

            Dim strEstoqueSomado As String = dt.Rows.Item(I).Item("EstoqueSomado").ToString
            Dim strBaixaPorLote As String = ""

            If strEstoqueSomado = "True" Then
                strBaixaPorLote = "False"
            Else
                strBaixaPorLote = "False"
                strEstoqueSomado = "False"
            End If
            'Dim strEstoqueSomado As String = "True"
            'Dim strBaixaPorLote As String = "False"

            Dim strPorValorAproximado As String = dt.Rows.Item(I).Item("PorValorAproximado").ToString
            Dim strNfeNano As String = dt.Rows.Item(I).Item("NfeNano").ToString
            Dim strImprimirDireto As String = "False" 'dt.Rows.Item(I).Item("ImprimirDireto").ToString
            Dim strCodigoBarraCupom As String = "False" 'dt.Rows.Item(I).Item("CodigoBarraCupom").ToString
            Dim strAutorizacaoPedido As String = "False" 'dt.Rows.Item(I).Item("AutorizacaoPedido").ToString
            Dim strDezPorcento As String = "False" 'dt.Rows.Item(I).Item("DezPorcento").ToString
            Dim strUsaBoleto As String = dt.Rows.Item(I).Item("UsaBoleto").ToString
            Dim strCaminhoPastaBoleto As String = dt.Rows.Item(I).Item("CaminhoPastaBoleto").ToString
            Dim strComissaoProduto As String = "False" 'dt.Rows.Item(I).Item("ComissaoProduto").ToString
            Dim strAtuPreCusto As String = dt.Rows.Item(I).Item("AtuPreCusto").ToString
            Dim strUF As String = dt.Rows.Item(I).Item("UF").ToString
            Dim strSimplesNacional As String = "False" 'dt.Rows.Item(I).Item("SimplesNacional").ToString
            Dim strBuscaCpfCnpj As String = dt.Rows.Item(I).Item("BuscaCpfCnpj").ToString
            Dim strObsProduto As String = "True" 'dt.Rows.Item(I).Item("ObsProduto").ToString
            Dim strSATFiscal As String = dt.Rows.Item(I).Item("SATFiscal").ToString
            Dim strSepararEstoqueSetor As String = "" 'dt.Rows.Item(I).Item("SepararEstoqueSetor").ToString
            Dim strImprimeComanda As String = "False" 'dt.Rows.Item(I).Item("ImprimeComanda").ToString
            Dim strValorMinimoGaxeta As String = 0 'dt.Rows.Item(I).Item("ValorMinimoGaxeta").ToString
            Dim strModeloSAT As String = dt.Rows.Item(I).Item("ModeloSAT").ToString
            Dim strManterPorcProd As String = "False" 'dt.Rows.Item(I).Item("ManterPorcProd").ToString
            Dim strTresCasasDecimais As String = "True" 'dt.Rows.Item(I).Item("TresCasasDecimais").ToString
            Dim strEmitentePadrao As String = dt.Rows.Item(I).Item("EmitentePadrao").ToString
            Dim strComandaPedido As String = "False" 'dt.Rows.Item(I).Item("DescricaoVenda").ToString
            Dim strDescricaoVenda As String = "" 'dt.Rows.Item(I).Item("DescricaoVenda").ToString
            Dim strImpObsPedidoVenda As String = "False" 'dt.Rows.Item(I).Item("ImpObsPedidoVenda").ToString
            Dim strVisualizarCobranca As String = dt.Rows.Item(I).Item("VisualizarCobranca").ToString
            Dim strAgruparProdutoVenda As String = "False" 'dt.Rows.Item(I).Item("AgruparProdutoVenda").ToString
            Dim strCompararFornecedor As String = "False" 'dt.Rows.Item(I).Item("CompararFornecedor").ToString
            Dim strMontarKit As String = "False" 'dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strMediaCusto As String = dt.Rows.Item(I).Item("MediaCusto").ToString
            Dim strObsClientePedido As String = "False" 'dt.Rows.Item(I).Item("ObsClientePedido").ToString
            Dim strImprimeContaPagar As String = "False" 'dt.Rows.Item(I).Item("ImprimeContaPagar").ToString
            Dim strNANONFCe As String = dt.Rows.Item(I).Item("NANONFCe").ToString
            Dim strCaminhoPastaNFCe As String = dt.Rows.Item(I).Item("CaminhoPastaNFCe").ToString
            Dim strPDV As String = "False" 'dt.Rows.Item(I).Item("PDV").ToString
            Dim strTabelaPreco As String = "" 'dt.Rows.Item(I).Item("TabelaPreco").ToString
            Dim strTEF As String = "False" 'dt.Rows.Item(I).Item("TEF").ToString
            Dim strSenhaAdm As String = "False" 'dt.Rows.Item(I).Item("SenhaAdm").ToString
            Dim strTemBalanca As String = "False" 'dt.Rows.Item(I).Item("TemBalanca").ToString
            Dim strEmailArquivo As String = dt.Rows.Item(I).Item("EmailArquivo").ToString
            Dim strCompServidor As String = dt.Rows.Item(I).Item("CompServidor").ToString
            Dim strTipoBalanca As String = "" 'dt.Rows.Item(I).Item("TipoBalanca").ToString
            Dim strAlterarDataCaixa As String = "False" 'dt.Rows.Item(I).Item("AlterarDataCaixa").ToString
            Dim strVincularUser As String = "False" 'dt.Rows.Item(I).Item("VincularUser").ToString
            Dim strTotalEconomizado As String = "False" 'dt.Rows.Item(I).Item("TotalEconomizado").ToString
            Dim strCasaDecimal As String = "3" 'dt.Rows.Item(I).Item("CasaDecimal").ToString
            Dim strImpressaoPadrao As String = "False" 'dt.Rows.Item(I).Item("ImpressaoPadrao").ToString

            Dim strFunilaria As String = dt.Rows.Item(I).Item("TipoNano").ToString
            If strFunilaria = 1 Then
                strFunilaria = "True"
            Else
                strFunilaria = "False"
            End If

            Dim strMoto As String = dt.Rows.Item(I).Item("TipoNano").ToString
            If strMoto = 2 Then
                strMoto = "True"
            Else
                strMoto = "False"
            End If

            Dim strSemCarro As String = dt.Rows.Item(I).Item("SemCarro").ToString


            If bolPassou = False Then
                Query = "UPDATE Config set Empresa='" & strEmpresa & "', Telefone='" & strTelefone & "', Endereco='" & strEndereco & "', " & _
                "CNPJ='" & strCNPJ & "', OrigemRelease='" & strOrigemRelease & "', VersaoNano='" & strVersaoNano & "', " & _
                "EmiteCupom='" & strEmiteCupom & "', UsaTEF='" & strUsaTEF & "', CaminhoDaPastaRemessa='" & strCaminhoRemessa & "', " & _
                "NumArqRM='" & strNumArqRM & "', TemImpressora='" & strTemImpressora & "', Cidade='" & strCidade & "', " & _
                "ModeloCarne='" & strModeloCarne & "', TipoNano='" & strTipoNano & "', PastaSinc='" & strPastaSinc & "', " & _
                "Descricao='" & strDescricao & "', GerarComissao='" & strGerarComissao & "', ValidarCPF='" & strValidarCPF & "', " & _
                "TemGuilhotina='" & strTemGuilhotina & "', NomePCImpressora='" & strNomePCImpressora & "', " & _
                "Tolerancia=" & Num(strTolerancia) & ", Juros=" & Num(strJuros) & ", EstoqueZerado='" & strEstoqueZerado & "', " & _
                "AlterarParcelas='" & strAlterarParcelas & "', Impressora='" & strImpressora & "', Porta='" & strPorta & "', " & _
                "JurosParcela=" & Num(strJurosParcela) & ", TipoDesc='" & strTipoDesc & "', ImpCodBarra='" & strImpCodBarra & "', " & _
                "ValidarCep='" & strValidarCep & "', Credito='" & strCredito & "', PortaImpCodBarra='" & strPortaImpCodBarra & "', " & _
                "TemGaveta='" & strTemGaveta & "', DescontoMaximo='" & strDescontoMaximo & "', Mensalista='" & strMensalista & "', " & _
                "UsaNfe='" & strUsaNfe & "', CaminhoPastaNfe='" & strCaminhoPastaNfe & "', ImpostoPorItem='" & strImpostoPorItem & "', " & _
                "ImportarNfe='" & strImportarNfe & "', CaminhoPastaNotaNfe='" & strCaminhoPastaNotaNfe & "', " & _
                "SegViaRecibo='" & strSegViaRecibo & "', BaixaPorLote='" & strBaixaPorLote & "', CaminhoPastaXML='" & strCaminhoPastaXML & "', " & _
                "CaminhoPastaPDF='" & strCaminhoPastaPDF & "', PafEcfNano='" & strPafEcfNano & "', ZeroCodProd='" & strZeroCodProd & "', " & _
                "ValorAproximado='" & strValorAproximado & "', BalancaPor='" & strBalancaPor & "', AltPrecoPedido='" & strAltPrecoPedido & "', " & _
                "DescricaoPedido='" & strDescricaoPedido & "', AltNomePedido='" & strAltNomePedido & "', TrocoCaixa='" & strTrocoCaixa & "', " & _
                "PedidoCompleto='" & strPedidoCompleto & "', OcultarAutorizacao='" & strOcultarAutorizacao & "', " & _
                "EstoqueSomado='" & strEstoqueSomado & "', PorValorAproximado='" & strPorValorAproximado & "', NfeNano='" & strNfeNano & "', " & _
                "ImprimirDireto='" & strImprimirDireto & "', CodigoBarraCupom='" & strCodigoBarraCupom & "', " & _
                "AutorizacaoPedido='" & strAutorizacaoPedido & "', DezPorcento='" & strDezPorcento & "', UsaBoleto='" & strUsaBoleto & "', " & _
                "CaminhoPastaBoleto='" & strCaminhoPastaBoleto & "', ComissaoProduto='" & strComissaoProduto & "', " & _
                "AtuPreCusto='" & strAtuPreCusto & "', UF='" & strUF & "', SimplesNacional='" & strSimplesNacional & "', " & _
                "BuscaCpfCnpj='" & strBuscaCpfCnpj & "', ObsProduto='" & strObsProduto & "', SATFiscal='" & strSATFiscal & "', " & _
                "SepararEstoqueSetor='" & strSepararEstoqueSetor & "', ImprimeComanda='" & strImprimeComanda & "', " & _
                "ValorMinimoGaxeta='" & strValorMinimoGaxeta & "', ModeloSAT='" & strModeloSAT & "', ManterPorcProd='" & strManterPorcProd & "', " & _
                "TresCasasDecimais='" & strTresCasasDecimais & "', EmitentePadrao='" & strEmitentePadrao & "',ComandaPedido='" & strComandaPedido & "'," & _
                "DescricaoVenda='" & strDescricaoVenda & "',ImpObsPedidoVenda='" & strImpObsPedidoVenda & "',VisualizarCobranca='" & strVisualizarCobranca & "', " & _
                "AgruparProdutoVenda='" & strAgruparProdutoVenda & "', CompararFornecedor='" & strCompararFornecedor & "', MontarKit='" & strMontarKit & "', " & _
                "MediaCusto='" & strMediaCusto & "', ObsClientePedido='" & strObsClientePedido & "', ImprimeContaPagar='" & strImprimeContaPagar & "', " & _
                "NANONFCe='" & strNANONFCe & "', CaminhoPastaNFCe='" & strCaminhoPastaNFCe & "', PDV='" & strPDV & "', TabelaPreco='" & strTabelaPreco & "', " & _
                "TEF='" & strTEF & "',SenhaAdm='" & strSenhaAdm & "',TemBalanca='" & strTemBalanca & "',EmailArquivo='" & strEmailArquivo & "', " & _
                "CompServidor='" & strCompServidor & "', TipoBalanca='" & strTipoBalanca & "', AlterarDataCaixa='" & strAlterarDataCaixa & "', " & _
                "VincularUser='" & strVincularUser & "', TotalEconomizado='" & strTotalEconomizado & "', CasaDecimal='" & strCasaDecimal & "'," & _
                "ImpressaoPadrao='" & strImpressaoPadrao & "', Funilaria='" & strFunilaria & "', Moto='" & strMoto & "', SemCarro='" & strSemCarro & "';"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Config(Empresa, Telefone, Endereco, CNPJ, OrigemRelease, " & _
                "VersaoNano, EmiteCupom, UsaTEF, CaminhoDaPastaRemessa, NumArqRM, TemImpressora, Cidade, ModeloCarne, " & _
                "TipoNano, PastaSinc, Descricao, GerarComissao, ValidarCPF, TemGuilhotina, NomePCImpressora, Tolerancia, Juros, " & _
                "EstoqueZerado, AlterarParcelas, Impressora, Porta, JurosParcela, TipoDesc, ImpCodBarra, ValidarCep, Credito, " & _
                "PortaImpCodBarra, TemGaveta, DescontoMaximo, Mensalista, UsaNfe, CaminhoPastaNfe, ImpostoPorItem, ImportarNfe, " & _
                "CaminhoPastaNotaNfe, SegViaRecibo, BaixaPorLote, CaminhoPastaXML, CaminhoPastaPDF, PafEcfNano, ZeroCodProd, " & _
                "ValorAproximado, BalancaPor, AltPrecoPedido, DescricaoPedido, AltNomePedido, TrocoCaixa, PedidoCompleto, " & _
                "OcultarAutorizacao, EstoqueSomado, PorValorAproximado, NfeNano, ImprimirDireto, CodigoBarraCupom, AutorizacaoPedido, " & _
                "DezPorcento, UsaBoleto, CaminhoPastaBoleto, ComissaoProduto, AtuPreCusto, UF, SimplesNacional, BuscaCpfCnpj, " & _
                "ObsProduto, SATFiscal, SepararEstoqueSetor, ImprimeComanda, ValorMinimoGaxeta, ModeloSAT, ManterPorcProd, " & _
                "TresCasasDecimais, EmitentePadrao, ComandaPedido, DescricaoVenda, ImpObsPedidoVenda, VisualizarCobranca, " & _
                "AgruparProdutoVenda, CompararFornecedor, MontarKit, MediaCusto, ObsClientePedido, ImprimeContaPagar, " & _
                "NANONFCe, CaminhoPastaNFCe, PDV, TabelaPreco, TEF, SenhaAdm, TemBalanca, EmailArquivo, CompServidor, " & _
                "TipoBalanca, AlterarDataCaixa, VincularUser, TotalEconomizado, CasaDecimal, ImpressaoPadrao, Funilaria, " & _
                "Moto, SemCarro) Values('" & strEmpresa & "','" & strTelefone & "','" & strEndereco & "','" & strCNPJ & "', " & _
                "'" & strOrigemRelease & "','" & strVersaoNano & "','" & strEmiteCupom & "','" & strUsaTEF & "','" & strCaminhoRemessa & "'," & _
                "'" & strNumArqRM & "','" & strTemImpressora & "','" & strCidade & "','" & strModeloCarne & "','" & strTipoNano & "'," & _
                "'" & strPastaSinc & "','" & strDescricao & "','" & strGerarComissao & "','" & strValidarCPF & "','" & strTemGuilhotina & "'," & _
                "'" & strNomePCImpressora & "'," & Num(strTolerancia) & "," & Num(strJuros) & ",'" & strEstoqueZerado & "','" & strAlterarParcelas & "'," & _
                "'" & strImpressora & "','" & strPorta & "'," & Num(strJurosParcela) & ",'" & strTipoDesc & "','" & strImpCodBarra & "', " & _
                "'" & strValidarCep & "','" & strCredito & "','" & strPortaImpCodBarra & "','" & strTemGaveta & "','" & strDescontoMaximo & "'," & _
                "'" & strMensalista & "','" & strUsaNfe & "','" & strCaminhoPastaNfe & "','" & strImpostoPorItem & "', " & _
                "'" & strImportarNfe & "','" & strCaminhoPastaNotaNfe & "','" & strSegViaRecibo & "','" & strBaixaPorLote & "','" & strCaminhoPastaXML & "', " & _
                "'" & strCaminhoPastaPDF & "','" & strPafEcfNano & "','" & strZeroCodProd & "','" & strValorAproximado & "','" & strBalancaPor & "'," & _
                "'" & strAltPrecoPedido & "','" & strDescricaoPedido & "','" & strAltNomePedido & "','" & strTrocoCaixa & "', " & _
                "'" & strPedidoCompleto & "','" & strOcultarAutorizacao & "','" & strEstoqueSomado & "','" & strPorValorAproximado & "'," & _
                "'" & strNfeNano & "','" & strImprimirDireto & "','" & strCodigoBarraCupom & "','" & strAutorizacaoPedido & "'," & _
                "'" & strDezPorcento & "','" & strUsaBoleto & "','" & strCaminhoPastaBoleto & "','" & strComissaoProduto & "', " & _
                "'" & strAtuPreCusto & "','" & strUF & "','" & strSimplesNacional & "','" & strBuscaCpfCnpj & "','" & strObsProduto & "'," & _
                "'" & strSATFiscal & "','" & strSepararEstoqueSetor & "','" & strImprimeComanda & "','" & strValorMinimoGaxeta & "'," & _
                "'" & strModeloSAT & "','" & strManterPorcProd & "','" & strTresCasasDecimais & "','" & strEmitentePadrao & "','" & strComandaPedido & "'," & _
                "'" & strDescricaoVenda & "','" & strImpObsPedidoVenda & "','" & strVisualizarCobranca & "','" & strAgruparProdutoVenda & "'," & _
                "'" & strCompararFornecedor & "','" & strMontarKit & "','" & strMediaCusto & "','" & strObsClientePedido & "','" & strImprimeContaPagar & "', " & _
                "'" & strNANONFCe & "','" & strCaminhoPastaNFCe & "','" & strPDV & "','" & strTabelaPreco & "','" & strTEF & "','" & strSenhaAdm & "'," & _
                "'" & strTemBalanca & "','" & strEmailArquivo & "','" & strCompServidor & "','" & strTipoBalanca & "','" & strAlterarDataCaixa & "', " & _
                "'" & strVincularUser & "','" & strTotalEconomizado & "','" & strCasaDecimal & "','" & strImpressaoPadrao & "'," & _
                "'" & strFunilaria & "','" & strMoto & "','" & strSemCarro & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "Config"
        Me.lblTabAtual.Text = "Usuario"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********USUARIO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Usuario order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1

            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString
            Dim strSenha As String = dt.Rows.Item(I).Item("Senha").ToString

            If strSenha <> "SPFC" And strCodigo <> 1 Then

                Dim strLogin As String = dt.Rows.Item(I).Item("Login").ToString
                Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
                Dim strNivel As String = dt.Rows.Item(I).Item("Nivel").ToString
                Dim strPrincipal As String = dt.Rows.Item(I).Item("Principal").ToString
                Dim strConsultas As String = dt.Rows.Item(I).Item("Consultas").ToString
                Dim strRelatorios As String = dt.Rows.Item(I).Item("Relatorios").ToString
                Dim strSkin As String = strCodigo 'dt.Rows.Item(I).Item("Skin").ToString
                Dim bolFundoPadrao As Boolean = dt.Rows.Item(I).Item("FundoPadrao").ToString
                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
                Dim strExibicao As String = dt.Rows.Item(I).Item("Exibicao").ToString
                'Dim strPlanoFundo As String = dt.Rows.Item(I).Item("PlanoFundo").ToString
                Dim strInativo As String = "False" 'dt.Rows.Item(I).Item("Inativo").ToString


                If strCodConfig = 3 Then
                    strCodConfig = 2
                End If

                If bolPassou = False Then
                    Query = "INSERT INTO Usuario(Login, Nome, Nivel, Senha, Principal, Consultas, Relatorios, " & _
                    "Skin, FundoPadrao, Exibicao, CodConfig, Inativo) VALUES('" & strLogin & "'," & _
                    "'" & strNome & "','" & strNivel & "','" & strSenha & "','" & strPrincipal & "'," & _
                    "'" & strConsultas & "','" & strRelatorios & "','" & strSkin & "'," & _
                    "'" & bolFundoPadrao & "','" & strExibicao & "','" & strCodConfig & "','" & strInativo & "');"

                    bolPassou = True
                Else
                    Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Usuario(Login, Nome, Nivel, Senha, " & _
                    "Principal, Consultas, Relatorios, Skin, FundoPadrao, Exibicao, CodConfig, Inativo) " & _
                    "VALUES('" & strLogin & "','" & strNome & "','" & strNivel & "','" & strSenha & "'," & _
                    "'" & strPrincipal & "','" & strConsultas & "','" & strRelatorios & "','" & strSkin & "'," & _
                    "'" & bolFundoPadrao & "','" & strExibicao & "','" & strCodConfig & "'," & _
                    "'" & strInativo & "');"

                End If

                count = count + 1
                If count = 500 Then
                    Inserir(Query)
                    System.Threading.Thread.Sleep(40)

                    Query = ""
                    count = 0
                End If

                LogDeErro()
            End If

            B += 1

        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "Usuario"
        Me.lblTabAtual.Text = "Ordem"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********ORDEM**********
        B = 1
        Dim intConfigOrdem As Integer = Me.ComboBoxEdit1.Properties.Items.Count
        If intConfigOrdem > 0 Then

            For J As Integer = 0 To intConfigOrdem - 1
                Dim Con As Integer = J + 1

                'ORDEM
                Dim dtOrdem As DataTable = CarregarDataTable("Select Max(CodOrdem) as Ordem From Total Where CodConfig=" & Con)

                Dim strOrdem As String = ""
                If dtOrdem.Rows.Count > 0 Then
                    strOrdem = dtOrdem.Rows.Item(0).Item("Ordem").ToString

                    If strOrdem <> "" Then
                        Inserir("Insert Into Ordem (Codigo, CodConfig) Values(" & strOrdem & ", " & Con & ");")
                    Else
                        If Con <> 1 Then
                            Inserir("Insert Into Ordem (Codigo, CodConfig) Values(99, " & Con & ");")
                        End If
                    End If
                End If


                'ORDENS
                Dim dtOrdens As DataTable = CarregarDataTable("select Max(CodOrdens) as Ordens From TotalConsig Where CodConfig=" & Con)

                Dim strOrdens As String = ""
                If dtOrdens.Rows.Count > 0 Then
                    strOrdens = dtOrdens.Rows.Item(0).Item("Ordens").ToString

                    If strOrdens <> "" Then
                        Inserir("Insert Into Ordens (Cod, Tabela, CodConfig) Values(" & strOrdens & ",'TotalConsig'," & Con & ");")
                    Else
                        If Con <> 1 Then
                            Inserir("Insert Into Ordens (Cod, Tabela, CodConfig) Values(99,'TotalConsig'," & Con & ");")
                        End If
                    End If
                End If

                B += 1
            Next
        End If
        strTabela = "Ordem"
        Me.lblTabAtual.Text = "Ordens"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********ORDENS**********
        B = 1
        Dim intConfigOrdens As Integer = Me.ComboBoxEdit1.Properties.Items.Count
        If intConfigOrdens > 0 Then

            For J As Integer = 0 To intConfigOrdens - 1

                Dim Con As Integer = 1 + J
                Dim dtTabelas As DataTable = CarregarDataTable2("Select Tabela From Ordens Group by Tabela", strNomeBanco)

                Dim strTabela As String = ""
                If dtTabelas.Rows.Count > 0 Then
                    For a As Integer = 0 To dtTabelas.Rows.Count - 1
                        strTabela = dtTabelas.Rows.Item(a).Item("Tabela").ToString

                        Dim dtOrdens As DataTable = CarregarDataTable2("Select Max(Cod) as Ordens From Ordens " & _
                        "Where Tabela='" & strTabela & "' And CodConfig=" & Con & "", strNomeBanco)

                        Dim strOrdens As String = ""
                        If dtOrdens.Rows.Count > 0 Then
                            strOrdens = dtOrdens.Rows.Item(0).Item("Ordens").ToString

                            If strOrdens <> "" Then
                                If strTabela = "Transferencia" Then
                                    Inserir("Insert Into OrdemTrans (Codigo, CodConfig) Values(" & strOrdens & "," & Con & ");")
                                Else
                                    If strTabela = "Nfe" Then
                                        Dim dtNfe As DataTable = CarregarDataTable2("Select CodEmitente, StatusEmitente From Ordens " & _
                                        "Where Tabela='" & strTabela & "' And Cod='" & strOrdens & "' And CodConfig=" & Con & "", strNomeBanco)

                                        Dim strCodEmitente As String = ""
                                        Dim strStatusEmitente As String = ""
                                        If dtNfe.Rows.Count > 0 Then
                                            strCodEmitente = dtNfe.Rows.Item(0).Item("CodEmitente").ToString
                                            strStatusEmitente = dtNfe.Rows.Item(0).Item("StatusEmitente").ToString
                                        End If

                                        Inserir("Insert Into Ordens (Cod, Tabela, CodConfig, CodEmitente, StatusEmitente) " & _
                                        "Values(" & strOrdens & ",'" & strTabela & "'," & Con & ",'" & strCodEmitente & "','" & strStatusEmitente & "');")
                                    ElseIf strTabela = "Sat" Then
                                        Dim dtSat As DataTable = CarregarDataTable2("Select CodEmitente From Ordens " & _
                                        "Where Tabela='" & strTabela & "' And Cod='" & strOrdens & "' And CodConfig=" & Con & "", strNomeBanco)

                                        Dim strCodEmitente As String = ""
                                        If dtSat.Rows.Count > 0 Then
                                            strCodEmitente = dtSat.Rows.Item(0).Item("CodEmitente").ToString
                                        End If

                                        Inserir("Insert Into Ordens (Cod, Tabela, CodConfig, CodEmitente) " & _
                                        "Values(" & strOrdens & ",'" & strTabela & "'," & Con & ",'" & strCodEmitente & "');")
                                    Else
                                        Inserir("Insert Into Ordens (Cod, Tabela, CodConfig) Values(" & strOrdens & ",'" & strTabela & "'," & Con & ");")
                                    End If
                                End If
                            End If
                        End If
                    Next
                End If

                B += 1
            Next

        End If
        strTabela = "Ordens"
        Me.lblTabAtual.Text = "Agenda"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********AGENDA**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Agendamento order by CodOrdem", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            'Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
            Dim strType As String = dt.Rows.Item(I).Item("Type").ToString
            Dim strStartDate As String = dt.Rows.Item(I).Item("StartDate").ToString
            Dim strEndDate As String = dt.Rows.Item(I).Item("EndDate").ToString
            Dim strAllDay As String = dt.Rows.Item(I).Item("AllDay").ToString
            Dim strSubject As String = dt.Rows.Item(I).Item("Subject").ToString.Replace("'", "")
            Dim strLocation As String = dt.Rows.Item(I).Item("Location").ToString.Replace("'", "")
            Dim strDescription As String = dt.Rows.Item(I).Item("Description").ToString.Replace("'", "")
            Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
            Dim strLabel As String = dt.Rows.Item(I).Item("Label").ToString
            Dim strResourceID As String = dt.Rows.Item(I).Item("ResourceID").ToString
            Dim strResourceIDs As String = dt.Rows.Item(I).Item("ResourceIDs").ToString
            Dim strReminderInfo As String = dt.Rows.Item(I).Item("ReminderInfo").ToString
            Dim strRecurrenceInfo As String = dt.Rows.Item(I).Item("RecurrenceInfo").ToString
            Dim strCustomField1 As String = dt.Rows.Item(I).Item("CustomField1").ToString
            Dim strConta As String = dt.Rows.Item(I).Item("Conta").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


            If bolPassou = False Then
                Query = "INSERT INTO Agenda(CodOrdem, Type, StartDate, EndDate, AllDay, Subject, Location, Description, " & _
                "Status, Label, ResourceID, ResourceIDs, ReminderInfo, RecurrenceInfo, CustomField1, Conta, CodConfig) " & _
                "Values('" & strCodOrdem & "','" & strType & "','" & strStartDate & "','" & strEndDate & "','" & strAllDay & "'," & _
                "'" & strSubject & "','" & strLocation & "','" & strDescription & "','" & strStatus & "','" & strLabel & "'," & _
                "'" & strResourceID & "','" & strResourceIDs & "','" & strReminderInfo & "','" & strRecurrenceInfo & "'," & _
                "'" & strCustomField1 & "','" & strConta & "','" & strCodConfig & "');"
                'Inserir(Query)
                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Agenda(CodOrdem, Type, StartDate, EndDate, AllDay, Subject, Location, Description, " & _
                "Status, Label, ResourceID, ResourceIDs, ReminderInfo, RecurrenceInfo, CustomField1, Conta, CodConfig) " & _
                "Values('" & strCodOrdem & "','" & strType & "','" & strStartDate & "','" & strEndDate & "','" & strAllDay & "'," & _
                "'" & strSubject & "','" & strLocation & "','" & strDescription & "','" & strStatus & "','" & strLabel & "'," & _
                "'" & strResourceID & "','" & strResourceIDs & "','" & strReminderInfo & "','" & strRecurrenceInfo & "'," & _
                "'" & strCustomField1 & "','" & strConta & "','" & strCodConfig & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "Agenda"
        Me.lblTabAtual.Text = "Cce"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********CCE**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Cce order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
            Dim strVersao As String = dt.Rows.Item(I).Item("Versao").ToString
            Dim strId As String = dt.Rows.Item(I).Item("Id").ToString
            Dim strCUF As String = dt.Rows.Item(I).Item("CUF").ToString
            Dim strTipoAmb As String = dt.Rows.Item(I).Item("TipoAmb").ToString
            Dim strChave As String = dt.Rows.Item(I).Item("Chave").ToString
            Dim strDEmi As String = dt.Rows.Item(I).Item("DEmi").ToString
            Dim strHEmi As String = dt.Rows.Item(I).Item("HEmi").ToString
            Dim strTZD As String = dt.Rows.Item(I).Item("TZD").ToString
            Dim strTipoEvento As String = dt.Rows.Item(I).Item("TipoEvento").ToString
            Dim strNumSeqEvento As String = dt.Rows.Item(I).Item("NumSeqEvento").ToString
            Dim strCNPJ As String = dt.Rows.Item(I).Item("CNPJ").ToString
            Dim strDescEvento As String = dt.Rows.Item(I).Item("DescEvento").ToString
            Dim strCorrecao As String = dt.Rows.Item(I).Item("Correcao").ToString
            Dim strCondUso As String = dt.Rows.Item(I).Item("CondUso").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strCodEmitente As String = dt.Rows.Item(I).Item("CodEmitente").ToString
            Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
            Dim strStatusEmitente As String = dt.Rows.Item(I).Item("StatusEmitente").ToString



            If bolPassou = False Then
                Query = "INSERT INTO Cce(CodOrdem, Versao, Id, CUF, TipoAmb, Chave, DEmi, HEmi, TZD, TipoEvento, " & _
                "NumSeqEvento, CNPJ, DescEvento, Correcao, CondUso, CodConfig, CodEmitente, Status, StatusEmitente) " & _
                "Values('" & strCodOrdem & "','" & strVersao & "','" & strId & "','" & strCUF & "','" & strTipoAmb & "'," & _
                "'" & strChave & "','" & strDEmi & "','" & strHEmi & "','" & strTZD & "','" & strTipoEvento & "'," & _
                "'" & strNumSeqEvento & "','" & strCNPJ & "','" & strDescEvento & "','" & strCorrecao & "','" & strCondUso & "'," & _
                "'" & strCodConfig & "','" & strCodEmitente & "','" & strStatus & "','" & strStatusEmitente & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Cce(CodOrdem, Versao, Id, CUF, TipoAmb, Chave, " & _
                "DEmi, HEmi, TZD, TipoEvento, NumSeqEvento, CNPJ, DescEvento, Correcao, CondUso, CodConfig, CodEmitente, " & _
                "Status, StatusEmitente) Values('" & strCodOrdem & "','" & strVersao & "','" & strId & "','" & strCUF & "'," & _
                "'" & strTipoAmb & "','" & strChave & "','" & strDEmi & "','" & strHEmi & "','" & strTZD & "','" & strTipoEvento & "'," & _
                "'" & strNumSeqEvento & "','" & strCNPJ & "','" & strDescEvento & "','" & strCorrecao & "','" & strCondUso & "'," & _
                "'" & strCodConfig & "','" & strCodEmitente & "','" & strStatus & "','" & strStatusEmitente & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "Cce"
        Me.lblTabAtual.Text = "Comissao"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********COMISSAO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Comissao Where CodConfig is not null order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodigoPedido").ToString.Replace("~", "").Replace("'", "").Replace("´", "")
            If strCodOrdem = "" Then
                strCodOrdem = 0
            End If

            Dim strFuncionario As String = dt.Rows.Item(I).Item("Funcionario").ToString
            Dim strValorProduto As String = dt.Rows.Item(I).Item("ValorServico").ToString
            Dim strPorcentagem As String = dt.Rows.Item(I).Item("Porcentagem").ToString
            Dim strValorComissao As String = dt.Rows.Item(I).Item("Comissao").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strMotivo As String = dt.Rows.Item(I).Item("Motivo").ToString
            Dim strTipo As String = dt.Rows.Item(I).Item("Tipo").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


            Dim dtFunc As DataTable = CarregarDataTable("Select Codigo From Funcionario Where Nome='" & strFuncionario & "' And CodConfig=" & strCodConfig)

            Dim strCodFunc As String = ""
            If dtFunc.Rows.Count > 0 Then
                strCodFunc = dtFunc.Rows.Item(0).Item("Codigo").ToString
            End If


            Dim strPago As String = "True" 'dt.Rows.Item(I).Item("Pago").ToString
            Dim strAuxiliar As String = "" 'dt.Rows.Item(I).Item("Auxiliar").ToString
            Dim strTipoProduto As String = dt.Rows.Item(I).Item("TipoProduto").ToString


            If bolPassou = False Then
                Query = "INSERT INTO Comissao(CodOrdem, CodFunc, Funcionario, ValorProduto, Porcentagem, " & _
                "ValorComissao, Data, Motivo, Tipo, CodConfig, Pago, Auxiliar, TipoProduto) " & _
                "Values('" & strCodOrdem & "','" & strCodFunc & "','" & strFuncionario & "'," & _
                "" & Num(strValorProduto) & "," & Num(strPorcentagem) & "," & Num(strValorComissao) & "," & _
                "'" & strData & "','" & strMotivo & "','" & strTipo & "','" & strCodConfig & "'," & _
                "'" & strPago & "','" & strAuxiliar & "','" & strTipoProduto & "');"
                'Inserir(Query)
                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Comissao(CodOrdem, CodFunc, Funcionario, " & _
                "ValorProduto, Porcentagem, ValorComissao, Data, Motivo, Tipo, CodConfig, Pago, Auxiliar, TipoProduto) " & _
                "Values('" & strCodOrdem & "','" & strCodFunc & "','" & strFuncionario & "'," & _
                "" & Num(strValorProduto) & "," & Num(strPorcentagem) & "," & Num(strValorComissao) & "," & _
                "'" & strData & "','" & strMotivo & "','" & strTipo & "','" & strCodConfig & "'," & _
                "'" & strPago & "','" & strAuxiliar & "','" & strTipoProduto & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        'Inserir("Update Comissao Set CodFunc=case when Funcionario.Codigo is not null then Funcionario.Codigo else 0 end " & _
        '        "From Comissao Left Join Funcionario on Comissao.CodFunc = Funcionario.Banco")
        strTabela = "Comissao"
        Me.lblTabAtual.Text = "ConfigECf"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********CONFIGECF**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM ConfigECf order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strCNPJ As String = dt.Rows.Item(I).Item("CNPJ").ToString
            Dim strIE As String = dt.Rows.Item(I).Item("IE").ToString
            Dim strCliche As String = dt.Rows.Item(I).Item("Cliche").ToString
            Dim strTipo As String = dt.Rows.Item(I).Item("Tipo").ToString
            Dim strModelo As String = dt.Rows.Item(I).Item("Modelo").ToString
            Dim strMarca As String = dt.Rows.Item(I).Item("Marca").ToString
            Dim strNumeroSerie As String = dt.Rows.Item(I).Item("NumeroSerie").ToString
            Dim strNumeroECF As String = dt.Rows.Item(I).Item("NumeroECF").ToString
            Dim strVersaoSB As String = dt.Rows.Item(I).Item("VersaoSB").ToString
            Dim strDataSB As String = dt.Rows.Item(I).Item("DataSB").ToString
            Dim strMFAdicional As String = dt.Rows.Item(I).Item("MFAdicional").ToString
            Dim strChavePublica As String = dt.Rows.Item(I).Item("ChavePublica").ToString
            Dim strChavePrivada As String = dt.Rows.Item(I).Item("ChavePrivada").ToString
            Dim strCodigoEquipamento As String = dt.Rows.Item(I).Item("CodigoEquipamento").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strImpressora As String = dt.Rows.Item(I).Item("Impressora").ToString
            Dim strComputador As String = dt.Rows.Item(I).Item("Computador").ToString
            Dim strAssinatura As String = dt.Rows.Item(I).Item("Assinatura").ToString
            Dim strModeloImpSAT As String = dt.Rows.Item(I).Item("ModeloImpSAT").ToString
            Dim strCaminhoPastaSAT As String = dt.Rows.Item(I).Item("CaminhoPastaSAT").ToString
            Dim strNomeImpSAT As String = dt.Rows.Item(I).Item("NomeImpSAT").ToString
            Dim strImpDiretoSAT As String = dt.Rows.Item(I).Item("ImpDiretoSAT").ToString
            Dim strVersaoXmlSAT As String = dt.Rows.Item(I).Item("VersaoXmlSAT").ToString
            Dim strMensImpCupomSAT As String = "True" 'dt.Rows.Item(I).Item("MensImpCupomSAT").ToString
            Dim strModeloSAT As String = "" 'dt.Rows.Item(I).Item("ModeloSAT").ToString
            Dim strRegime As String = "" 'dt.Rows.Item(I).Item("Regime").ToString



            If bolPassou = False Then
                Query = "INSERT INTO ConfigECf(CNPJ, IE, Cliche, Tipo, Modelo, Marca, NumeroSerie, NumeroECF, " & _
                "VersaoSB, DataSB, MFAdicional, ChavePublica, ChavePrivada, CodigoEquipamento, CodConfig, Impressora, " & _
                "Computador, Assinatura, ModeloImpSAT, CaminhoPastaSAT, NomeImpSAT, ImpDiretoSAT, VersaoXmlSAT, MensImpCupomSAT, " & _
                "ModeloSAT, Regime) Values('" & strCNPJ & "','" & strIE & "','" & strCliche & "','" & strTipo & "'," & _
                "'" & strModelo & "','" & strMarca & "','" & strNumeroSerie & "','" & strNumeroECF & "','" & strVersaoSB & "'," & _
                "'" & strDataSB & "','" & strMFAdicional & "','" & strChavePublica & "','" & strChavePrivada & "'," & _
                "'" & strCodigoEquipamento & "','" & strCodConfig & "','" & strImpressora & "','" & strComputador & "'," & _
                "'" & strAssinatura & "','" & strModeloImpSAT & "','" & strCaminhoPastaSAT & "','" & strNomeImpSAT & "'," & _
                "'" & strImpDiretoSAT & "','" & strVersaoXmlSAT & "','" & strMensImpCupomSAT & "','" & strModeloSAT & "'," & _
                "'" & strRegime & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO ConfigECf(CNPJ, IE, Cliche, Tipo, Modelo, Marca, " & _
                "NumeroSerie, NumeroECF, VersaoSB, DataSB, MFAdicional, ChavePublica, ChavePrivada, CodigoEquipamento, CodConfig, " & _
                "Impressora, Computador, Assinatura, ModeloImpSAT, CaminhoPastaSAT, NomeImpSAT, ImpDiretoSAT, VersaoXmlSAT, " & _
                "MensImpCupomSAT, ModeloSAT, Regime) Values('" & strCNPJ & "','" & strIE & "','" & strCliche & "','" & strTipo & "'," & _
                "'" & strModelo & "','" & strMarca & "','" & strNumeroSerie & "','" & strNumeroECF & "','" & strVersaoSB & "'," & _
                "'" & strDataSB & "','" & strMFAdicional & "','" & strChavePublica & "','" & strChavePrivada & "'," & _
                "'" & strCodigoEquipamento & "','" & strCodConfig & "','" & strImpressora & "','" & strComputador & "'," & _
                "'" & strAssinatura & "','" & strModeloImpSAT & "','" & strCaminhoPastaSAT & "','" & strNomeImpSAT & "'," & _
                "'" & strImpDiretoSAT & "','" & strVersaoXmlSAT & "','" & strMensImpCupomSAT & "','" & strModeloSAT & "'," & _
                "'" & strRegime & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "ConfigECf"
        Me.lblTabAtual.Text = "Cotacao"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0


        '**********COTACAO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Cotacao order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
            Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
            Dim strCodFor As String = dt.Rows.Item(I).Item("CodFor").ToString
            Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


            If bolPassou = False Then
                Query = "INSERT INTO Cotacao(CodOrdem, CodProd, CodFor, Valor, Data, CodConfig) " & _
                "Values('" & strCodOrdem & "','" & strCodProd & "','" & strCodFor & "'," & _
                "" & Num(strValor) & ",'" & strData & "','" & strCodConfig & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Cotacao(CodOrdem, CodProd, CodFor, Valor, " & _
                "Data, CodConfig) Values('" & strCodOrdem & "','" & strCodProd & "'," & _
                "'" & strCodFor & "'," & Num(strValor) & ",'" & strData & "','" & strCodConfig & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        Inserir("Update Cotacao set CodFor=Fornecedor.Codigo From Cotacao Left Join Fornecedor on Cotacao.CodFor = Fornecedor.Contato")
        strTabela = "Cotacao"
        Me.lblTabAtual.Text = "DuplicataNfe"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********DUPLICATANFE**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM DuplicataNfe order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
            Dim strNumero As String = dt.Rows.Item(I).Item("Numero").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            'Dim strCodEmitente As String = dt.Rows.Item(I).Item("CodEmitente").ToString
            'Dim strStatusEmitente As String = dt.Rows.Item(I).Item("StatusEmitente").ToString

            If bolPassou = False Then
                Query = "INSERT INTO DuplicataNfe(CodOrdem, Numero, Data, Valor, CodConfig) " & _
                "Values('" & strCodOrdem & "','" & strNumero & "','" & strData & "'," & Num(strValor) & "," & _
                "'" & strCodConfig & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO DuplicataNfe(CodOrdem, Numero, Data, Valor, " & _
                "CodConfig) Values('" & strCodOrdem & "','" & strNumero & "','" & strData & "'," & _
                "" & Num(strValor) & ",'" & strCodConfig & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "DuplicataNfe"
        Me.lblTabAtual.Text = "Email"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********EMAIL**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Email order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strServidor As String = dt.Rows.Item(I).Item("Servidor").ToString
            Dim strEmail As String = dt.Rows.Item(I).Item("Email").ToString
            Dim strSenha As String = dt.Rows.Item(I).Item("Senha").ToString
            Dim strPorta As String = dt.Rows.Item(I).Item("Porta").ToString
            Dim strServico As String = dt.Rows.Item(I).Item("Servico").ToString

            If bolPassou = False Then
                Query = "UPDATE Email set Servidor='" & strServidor & "', Email='" & strEmail & "', " & _
                "Senha='" & strSenha & "', Porta='" & strPorta & "', Servico='" & strServico & "';"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Email(Servidor, Email, " & _
                "Senha, Porta, Servico) Values('" & strServidor & "','" & strEmail & "','" & strSenha & "'," & _
                "'" & strPorta & "','" & strServico & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "Email"
        Me.lblTabAtual.Text = "TotalEntradaNF"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********TOTALENTRADANF**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM TotalEntradaNF order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strNumeroNF As String = dt.Rows.Item(I).Item("NumeroNF").ToString
            Dim strCNPJ As String = dt.Rows.Item(I).Item("CPF").ToString

            Dim dtFor As DataTable = CarregarDataTable("Select Codigo From Fornecedor Where CPF='" & strCNPJ & "'")

            Dim strCodFor As String = "" 'dt.Rows.Item(I).Item("CodFor").ToString
            If dtFor.Rows.Count > 0 Then
                strCodFor = dtFor.Rows.Item(0).Item("Codigo").ToString
            End If

            Dim strTotal As String = dt.Rows.Item(I).Item("Total").ToString
            Dim strObs As String = dt.Rows.Item(I).Item("Descricao").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strEstoqueOK As String = dt.Rows.Item(I).Item("EstoqueOK").ToString
            Dim strLote As String = "" 'dt.Rows.Item(I).Item("Lote").ToString
            Dim strDesconto As String = dt.Rows.Item(I).Item("Desconto").ToString
            Dim strTipo As String = dt.Rows.Item(I).Item("Tipo").ToString
            Dim strSerie As String = dt.Rows.Item(I).Item("Serie").ToString
            Dim strValorFrete As String = dt.Rows.Item(I).Item("ValorFrete").ToString
            Dim strValorSeguro As String = dt.Rows.Item(I).Item("ValorSeguro").ToString
            Dim strOutrasDespesas As String = dt.Rows.Item(I).Item("OutrasDespesas").ToString
            Dim strICMS As String = dt.Rows.Item(I).Item("ICMS").ToString
            Dim strIPI As String = dt.Rows.Item(I).Item("IPI").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strCodPedido As String = "" 'dt.Rows.Item(I).Item("CodPedido").ToString


            If bolPassou = False Then
                Query = "INSERT INTO TotalEntradaNF(NumeroNF, CodFor, Total, Obs, Data, EstoqueOK, Lote, Desconto, Tipo, Serie, " & _
                "ValorFrete, ValorSeguro, OutrasDespesas, ICMS, IPI, CodConfig, CodPedido) Values('" & strNumeroNF & "'," & _
                "'" & strCodFor & "'," & Num(strTotal) & ",'" & strObs & "','" & strData & "','" & strEstoqueOK & "'," & _
                "'" & strLote & "','" & strDesconto & "','" & strTipo & "','" & strSerie & "'," & Num(strValorFrete) & "," & _
                "" & Num(strValorSeguro) & ",'" & strOutrasDespesas & "','" & strICMS & "','" & strIPI & "'," & _
                "'" & strCodConfig & "','" & strCodPedido & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO TotalEntradaNF(NumeroNF, CodFor, Total, Obs, Data, " & _
                "EstoqueOK, Lote, Desconto, Tipo, Serie, ValorFrete, ValorSeguro, OutrasDespesas, ICMS, IPI, CodConfig, " & _
                "CodPedido) Values('" & strNumeroNF & "','" & strCodFor & "'," & Num(strTotal) & ",'" & strObs & "'," & _
                "'" & strData & "','" & strEstoqueOK & "','" & strLote & "','" & strDesconto & "','" & strTipo & "'," & _
                "'" & strSerie & "'," & Num(strValorFrete) & "," & Num(strValorSeguro) & ",'" & strOutrasDespesas & "'," & _
                "'" & strICMS & "','" & strIPI & "','" & strCodConfig & "','" & strCodPedido & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "TotalEntradaNF"
        Me.lblTabAtual.Text = "EntradaNF"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********ENTRADANF**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM EntradaNF order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim str As String = dt.Rows.Item(I).Item("NumeroNF").ToString
            Dim dtCodNF As DataTable = CarregarDataTable("Select Codigo From TotalEntradaNF " & _
            "Where NumeroNF='" & dt.Rows.Item(I).Item("NumeroNF").ToString & "'")

            Dim strCodTotNF As String = "" 'dt.Rows.Item(I).Item("NumeroNF").ToString
            If dtCodNF.Rows.Count > 0 Then
                strCodTotNF = dtCodNF.Rows.Item(0).Item("Codigo").ToString
            End If

            Dim strCodProdInterno As String = dt.Rows.Item(I).Item("CodigoPeca").ToString

            Dim strCodigoPeca As String = dt.Rows.Item(I).Item("CodigoProduto").ToString
            'Dim dtProd As DataTable = CarregarDataTable("Select Codigo, UnidadeMedida, Setor, Grupo, CodProdFor " & _
            '"From Produto Where CodigoInterno='" & strCodProdInterno & "'")

            Dim dtProd As DataTable = CarregarDataTable("Select Codigo, UnidadeMedida, Setor, Grupo, CodProdFor " & _
            "From Produto Where Locacao='" & strCodigoPeca & "'")

            Dim strCodProd As String = ""
            Dim strUM As String = ""
            Dim strSetor As String = ""
            Dim strGrupo As String = ""
            Dim strCodProdFor As String = ""
            If dtProd.Rows.Count > 0 Then
                strCodProd = dtProd.Rows.Item(0).Item("Codigo").ToString
                strUM = dtProd.Rows.Item(0).Item("UnidadeMedida").ToString
                strSetor = dtProd.Rows.Item(0).Item("Setor").ToString
                strGrupo = dtProd.Rows.Item(0).Item("Grupo").ToString
                strCodProdFor = dtProd.Rows.Item(0).Item("CodProdFor").ToString
            Else
                Dim dtProd2 As DataTable = CarregarDataTable("Select Codigo, UnidadeMedida, Setor, Grupo, CodProdFor " & _
                "From Produto Where CodigoInterno='" & strCodProdInterno & "'")

                If dtProd2.Rows.Count > 0 Then
                    strCodProd = dtProd2.Rows.Item(0).Item("Codigo").ToString
                    strUM = dtProd2.Rows.Item(0).Item("UnidadeMedida").ToString
                    strSetor = dtProd2.Rows.Item(0).Item("Setor").ToString
                    strGrupo = dtProd2.Rows.Item(0).Item("Grupo").ToString
                    strCodProdFor = dtProd2.Rows.Item(0).Item("CodProdFor").ToString
                End If
            End If

            Dim strTamanho As String = "U" 'dt.Rows.Item(I).Item("Tamanho").ToString
            Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
            Dim strValorUnitario As String = dt.Rows.Item(I).Item("ValorUnitario").ToString
            Dim strValorTotal As String = dt.Rows.Item(I).Item("ValorTotal").ToString
            Dim strProduto As String = dt.Rows.Item(I).Item("Produto").ToString.Replace("'", "´").Replace("&", "E")

            Dim strICMS As String = dt.Rows.Item(I).Item("ICMS").ToString
            Dim strDesconto As String = dt.Rows.Item(I).Item("Desconto").ToString
            Dim strIPI As String = dt.Rows.Item(I).Item("IPI").ToString
            Dim strUnitarioImposto As String = dt.Rows.Item(I).Item("UnitarioImposto").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strQtdTotal As String = strQtd 'dt.Rows.Item(I).Item("QtdTotal").ToString
            Dim strValProd As String = dt.Rows.Item(I).Item("ValProd").ToString
            Dim strPorProd As String = dt.Rows.Item(I).Item("PorProd").ToString
            Dim strMVaST As String = dt.Rows.Item(I).Item("MVaST").ToString
            Dim strPorICMS As String = dt.Rows.Item(I).Item("PorICMS").ToString
            Dim strTipoProduto As String = dt.Rows.Item(I).Item("TipoProduto").ToString
            If strTipoProduto = "PEÇA" Then
                strTipoProduto = "VENDA"
            End If
            If strTipoProduto = "INTERNO" Then
                strTipoProduto = "CONSUMO"
            End If
            Dim strUMProd As String = strUM 'dt.Rows.Item(I).Item("UMProd").ToString
            Dim strQtdProd As String = strQtd 'dt.Rows.Item(I).Item("QtdProd").ToString
            Dim strValorCusto As String = dt.Rows.Item(I).Item("ValorCusto").ToString
            Dim strCST As String = "" 'dt.Rows.Item(I).Item("CST").ToString
            Dim strOrigem As String = "" 'dt.Rows.Item(I).Item("Origem").ToString
            Dim strModBC As String = "" 'dt.Rows.Item(I).Item("ModBC").ToString
            Dim strAliquotaICMS As String = "" 'dt.Rows.Item(I).Item("AliquotaICMS").ToString
            Dim strValICMS As String = "" 'dt.Rows.Item(I).Item("ValICMS").ToString
            Dim strRedBC As String = "" 'dt.Rows.Item(I).Item("RedBC").ToString
            Dim strModBCST As String = "" 'dt.Rows.Item(I).Item("ModBCST").ToString
            Dim strRedBCST As String = "" 'dt.Rows.Item(I).Item("RedBCST").ToString
            Dim strMVaSTEnt As String = "" 'dt.Rows.Item(I).Item("MVaSTEnt").ToString
            Dim strAliquotaICMSST As String = "" 'dt.Rows.Item(I).Item("AliquotaICMSST").ToString
            Dim strValICMSST As String = "" 'dt.Rows.Item(I).Item("ValICMSST").ToString
            Dim strNCM As String = "" 'dt.Rows.Item(I).Item("NCM").ToString
            Dim strRegime As String = "" 'dt.Rows.Item(I).Item("Regime").ToString
            Dim strCalculoCred As String = "" 'dt.Rows.Item(I).Item("CalculoCred").ToString
            Dim strValCalculoCred As String = "" 'dt.Rows.Item(I).Item("ValCalculoCred").ToString
            Dim strCFOP As String = "" 'dt.Rows.Item(I).Item("CFOP").ToString
            Dim strCSTIPI As String = "" 'dt.Rows.Item(I).Item("CSTIPI").ToString
            Dim strCodEnq As String = "" 'dt.Rows.Item(I).Item("CodEnq").ToString
            Dim strAliquotaIPI As String = "" 'dt.Rows.Item(I).Item("AliquotaIPI").ToString
            Dim strValIPI As String = "" 'dt.Rows.Item(I).Item("ValIPI").ToString
            Dim strCSTPIS As String = "" 'dt.Rows.Item(I).Item("CSTPIS").ToString
            Dim strAliquotaPIS As String = "" 'dt.Rows.Item(I).Item("AliquotaPIS").ToString
            Dim strValPIS As String = "" 'dt.Rows.Item(I).Item("ValPIS").ToString
            Dim strCSTCOFINS As String = "" 'dt.Rows.Item(I).Item("CSTCOFINS").ToString
            Dim strAliquotaCOFINS As String = "" 'dt.Rows.Item(I).Item("AliquotaCOFINS").ToString
            Dim strValCOFINS As String = "" 'dt.Rows.Item(I).Item("ValCOFINS").ToString
            Dim strCodigoANPEnt As String = "" 'dt.Rows.Item(I).Item("CodigoANPEnt").ToString
            Dim strUFCombEnt As String = "" 'dt.Rows.Item(I).Item("UFCombEnt").ToString


            If strCodTotNF <> "" Then
                If bolPassou = False Then
                    Query = "INSERT INTO EntradaNF(CodTotNF, CodProd, Tamanho, Qtd, ValorUnitario, ValorTotal, Produto, " & _
                    "CodProdInterno, ICMS, Desconto, IPI, UnitarioImposto, CodConfig, QtdTotal, UM, ValProd, PorProd, " & _
                    "Setor, Grupo, MVaST, PorICMS, TipoProduto, UMProd, QtdProd, CodProdFor, ValorCusto, CST, Origem, " & _
                    "ModBC, AliquotaICMS, ValICMS, RedBC, ModBCST, RedBCST, MVaSTEnt, AliquotaICMSST, ValICMSST, NCM, " & _
                    "Regime, CalculoCred, ValCalculoCred, CFOP, CSTIPI, CodEnq, AliquotaIPI, ValIPI, CSTPIS, AliquotaPIS, " & _
                    "ValPIS, CSTCOFINS, AliquotaCOFINS, ValCOFINS, CodigoANPEnt, UFCombEnt) Values('" & strCodTotNF & "'," & _
                    "'" & strCodProd & "','" & strTamanho & "'," & Num(strQtd) & "," & Num(strValorUnitario) & "," & _
                    "" & Num(strValorTotal) & ",'" & strProduto & "','" & strCodProdInterno & "','" & strICMS & "'," & _
                    "'" & strDesconto & "','" & strIPI & "'," & Num(strUnitarioImposto) & ",'" & strCodConfig & "'," & _
                    "'" & Num(strQtdTotal) & "','" & strUM & "'," & Num(strValProd) & "," & Num(strPorProd) & "," & _
                    "'" & strSetor & "','" & strGrupo & "','" & strMVaST & "','" & strPorICMS & "'," & _
                    "'" & strTipoProduto & "','" & strUMProd & "'," & Num(strQtdProd) & ",'" & strCodProdFor & "'," & _
                    "" & Num(strValorCusto) & ",'" & strCST & "','" & strOrigem & "','" & strModBC & "'," & _
                    "'" & strAliquotaICMS & "','" & strValICMS & "','" & strRedBC & "','" & strModBCST & "'," & _
                    "'" & strRedBCST & "','" & strMVaSTEnt & "','" & strAliquotaICMSST & "','" & strValICMSST & "'," & _
                    "'" & strNCM & "','" & strRegime & "','" & strCalculoCred & "','" & strValCalculoCred & "'," & _
                    "'" & strCFOP & "','" & strCSTIPI & "','" & strCodEnq & "','" & strAliquotaIPI & "'," & _
                    "'" & strValIPI & "','" & strCSTPIS & "','" & strAliquotaPIS & "','" & strValPIS & "'," & _
                    "'" & strCSTCOFINS & "','" & strAliquotaCOFINS & "','" & strValCOFINS & "','" & strCodigoANPEnt & "'," & _
                    "'" & strUFCombEnt & "');"
                    'Inserir(Query)
                    bolPassou = True
                Else
                    Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO EntradaNF(CodTotNF, CodProd, Tamanho, Qtd, " & _
                    "ValorUnitario, ValorTotal, Produto, " & _
                    "CodProdInterno, ICMS, Desconto, IPI, UnitarioImposto, CodConfig, QtdTotal, UM, ValProd, PorProd, " & _
                    "Setor, Grupo, MVaST, PorICMS, TipoProduto, UMProd, QtdProd, CodProdFor, ValorCusto, CST, Origem, " & _
                    "ModBC, AliquotaICMS, ValICMS, RedBC, ModBCST, RedBCST, MVaSTEnt, AliquotaICMSST, ValICMSST, NCM, " & _
                    "Regime, CalculoCred, ValCalculoCred, CFOP, CSTIPI, CodEnq, AliquotaIPI, ValIPI, CSTPIS, AliquotaPIS, " & _
                    "ValPIS, CSTCOFINS, AliquotaCOFINS, ValCOFINS, CodigoANPEnt, UFCombEnt) Values('" & strCodTotNF & "'," & _
                    "'" & strCodProd & "','" & strTamanho & "'," & Num(strQtd) & "," & Num(strValorUnitario) & "," & _
                    "" & Num(strValorTotal) & ",'" & strProduto & "','" & strCodProdInterno & "','" & strICMS & "'," & _
                    "'" & strDesconto & "','" & strIPI & "'," & Num(strUnitarioImposto) & ",'" & strCodConfig & "'," & _
                    "'" & Num(strQtdTotal) & "','" & strUM & "'," & Num(strValProd) & "," & Num(strPorProd) & "," & _
                    "'" & strSetor & "','" & strGrupo & "','" & strMVaST & "','" & strPorICMS & "'," & _
                    "'" & strTipoProduto & "','" & strUMProd & "'," & Num(strQtdProd) & ",'" & strCodProdFor & "'," & _
                    "" & Num(strValorCusto) & ",'" & strCST & "','" & strOrigem & "','" & strModBC & "'," & _
                    "'" & strAliquotaICMS & "','" & strValICMS & "','" & strRedBC & "','" & strModBCST & "'," & _
                    "'" & strRedBCST & "','" & strMVaSTEnt & "','" & strAliquotaICMSST & "','" & strValICMSST & "'," & _
                    "'" & strNCM & "','" & strRegime & "','" & strCalculoCred & "','" & strValCalculoCred & "'," & _
                    "'" & strCFOP & "','" & strCSTIPI & "','" & strCodEnq & "','" & strAliquotaIPI & "'," & _
                    "'" & strValIPI & "','" & strCSTPIS & "','" & strAliquotaPIS & "','" & strValPIS & "'," & _
                    "'" & strCSTCOFINS & "','" & strAliquotaCOFINS & "','" & strValCOFINS & "','" & strCodigoANPEnt & "'," & _
                    "'" & strUFCombEnt & "');"

                End If
            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "EntradaNF"
        Me.lblTabAtual.Text = "Estado"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********ESTADO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Estado order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strNome As Integer = dt.Rows.Item(I).Item("Nome").ToString
            Dim strUF As Integer = dt.Rows.Item(I).Item("UF").ToString


            If bolPassou = False Then
                Query = "INSERT INTO Estado(Nome, UF) Values('" & strNome & "','" & strUF & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Estado(Nome, UF) " & _
                "Values('" & strNome & "','" & strUF & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "Estado"
        Me.lblTabAtual.Text = "Futuro"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********FUTURO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Futuro order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodigoRecebimento").ToString
            Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
            Dim strTotal As String = dt.Rows.Item(I).Item("Total").ToString
            Dim strTotalDesconto As String = dt.Rows.Item(I).Item("TotalDesconto").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strRecebido As String = dt.Rows.Item(I).Item("Recebido").ToString
            Dim strCodigoPedido As String = dt.Rows.Item(I).Item("Pedido").ToString
            Dim strAuxiliar As String = "" 'dt.Rows.Item(I).Item("Auxiliar").ToString
            Dim strBandeira As String = "" 'dt.Rows.Item(I).Item("Bandeira").ToString
            Dim strNumTransacao As String = "" 'dt.Rows.Item(I).Item("NumTransacao").ToString
            Dim strStatus As String = "" 'dt.Rows.Item(I).Item("Status").ToString


            If bolPassou = False Then
                Query = "INSERT INTO Futuro(Data, CodOrdem, Pagamento, Total, TotalDesconto, CodConfig, " & _
                "Recebido, CodigoPedido, Auxiliar, Bandeira, NumTransacao, Status) Values('" & strData & "'," & _
                "'" & strCodOrdem & "','" & strPagamento & "'," & Num(strTotal) & "," & Num(strTotalDesconto) & "," & _
                "'" & strCodConfig & "','" & strRecebido & "','" & strCodigoPedido & "','" & strAuxiliar & "'," & _
                "'" & strBandeira & "','" & strNumTransacao & "','" & strStatus & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Futuro(Data, CodOrdem, Pagamento, Total, " & _
                "TotalDesconto, CodConfig, Recebido, CodigoPedido, Auxiliar, Bandeira, NumTransacao, Status) " & _
                "Values('" & strData & "','" & strCodOrdem & "','" & strPagamento & "'," & Num(strTotal) & "," & _
                "" & Num(strTotalDesconto) & ",'" & strCodConfig & "','" & strRecebido & "','" & strCodigoPedido & "'," & _
                "'" & strAuxiliar & "','" & strBandeira & "','" & strNumTransacao & "','" & strStatus & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "Futuro"
        Me.lblTabAtual.Text = "Inutilizacao"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********INUTILIZACAO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Inutilizacao order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strNumInicial As String = dt.Rows.Item(I).Item("NumInicial").ToString
            Dim strNumFinal As String = dt.Rows.Item(I).Item("NumFinal").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strSerie As String = dt.Rows.Item(I).Item("Serie").ToString
            Dim strMotivo As String = dt.Rows.Item(I).Item("Motivo").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strChave As String = dt.Rows.Item(I).Item("Chave").ToString
            Dim strCodEmitente As String = dt.Rows.Item(I).Item("CodEmitente").ToString
            Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
            Dim strStatusEmitente As String = dt.Rows.Item(I).Item("StatusEmitente").ToString


            If bolPassou = False Then
                Query = "INSERT INTO Inutilizacao(NumInicial, NumFinal, Data, Serie, Motivo, CodConfig, " & _
                "Chave, CodEmitente, Status, StatusEmitente) Values('" & strNumInicial & "','" & strNumFinal & "'," & _
                "'" & strData & "','" & strSerie & "','" & strMotivo & "','" & strCodConfig & "','" & strChave & "'," & _
                "'" & strCodEmitente & "','" & strStatus & "','" & strStatusEmitente & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Inutilizacao(NumInicial, NumFinal, Data, Serie, " & _
                "Motivo, CodConfig, Chave, CodEmitente, Status, StatusEmitente) Values('" & strNumInicial & "'," & _
                "'" & strNumFinal & "','" & strData & "','" & strSerie & "','" & strMotivo & "','" & strCodConfig & "'," & _
                "'" & strChave & "','" & strCodEmitente & "','" & strStatus & "','" & strStatusEmitente & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "Inutilizacao"
        Me.lblTabAtual.Text = "Inventario"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********INVENTARIO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Inventario order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
            Dim strQtdAntiga As String = dt.Rows.Item(I).Item("QtdAntiga").ToString
            Dim strValorCusto As String = dt.Rows.Item(I).Item("ValorCusto").ToString
            Dim strTamanho As String = dt.Rows.Item(I).Item("Tamanho").ToString
            Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString



            If bolPassou = False Then
                Query = "INSERT INTO Inventario(CodProd, CodConfig, Qtd, QtdAntiga, ValorCusto, Tamanho, Status, Data) " & _
                "Values('" & strCodProd & "','" & strCodConfig & "'," & Num(strQtd) & "," & Num(strQtdAntiga) & "," & _
                "" & Num(strValorCusto) & ",'" & strTamanho & "','" & strStatus & "','" & strData & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Inventario(CodProd, CodConfig, Qtd, QtdAntiga, " & _
                "ValorCusto, Tamanho, Status, Data) Values('" & strCodProd & "','" & strCodConfig & "'," & Num(strQtd) & "," & _
                "" & Num(strQtdAntiga) & "," & Num(strValorCusto) & ",'" & strTamanho & "','" & strStatus & "','" & strData & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        Inserir("Update Inventario Set CodProd=case when Produto.Codigo is not null then Produto.Codigo else 0 end " & _
               "From Inventario Left Join Produto on Inventario.CodProd = Produto.Locacao")
        strTabela = "Inventario"
        If strUsarNfe = "0" Then
            Me.lblTabAtual.Text = "Totalnfe"
        Else
            Me.lblTabAtual.Text = "Log"
        End If
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0


        If strUsarNfe = "0" Then
            '**********TOTALNFE**********
            B = 1
            dt = CarregarDataTable2("SELECT * FROM Totalnfe order by Codigo", strNomeBanco)
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

                Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
                Dim strCodNF As String = dt.Rows.Item(I).Item("CodNF").ToString
                Dim strNumNF As String = dt.Rows.Item(I).Item("NumNF").ToString
                Dim strChave As String = dt.Rows.Item(I).Item("Chave").ToString
                Dim strIndPag As String = dt.Rows.Item(I).Item("IndPag").ToString
                Dim strDEmi As String = dt.Rows.Item(I).Item("DEmi").ToString
                Dim strDEntSai As String = dt.Rows.Item(I).Item("DEntSai").ToString
                Dim strHEntSai As String = dt.Rows.Item(I).Item("HEntSai").ToString
                Dim strDCont As String = dt.Rows.Item(I).Item("DCont").ToString
                Dim strHCont As String = dt.Rows.Item(I).Item("HCont").ToString
                Dim strJustCont As String = dt.Rows.Item(I).Item("JustCont").ToString
                Dim strCDV As String = dt.Rows.Item(I).Item("CDV").ToString
                Dim strCodCli As String = dt.Rows.Item(I).Item("CodCli").ToString
                Dim strVBC As String = dt.Rows.Item(I).Item("VBC").ToString
                Dim strVICMS As String = dt.Rows.Item(I).Item("VICMS").ToString
                Dim strVBCST As String = dt.Rows.Item(I).Item("VBCST").ToString
                Dim strVST As String = dt.Rows.Item(I).Item("VST").ToString
                Dim strVProd As String = dt.Rows.Item(I).Item("VProd").ToString
                Dim strVFrete As String = dt.Rows.Item(I).Item("VFrete").ToString
                Dim strVSeg As String = dt.Rows.Item(I).Item("VSeg").ToString
                Dim strVDesc As String = dt.Rows.Item(I).Item("VDesc").ToString
                Dim strVII As String = dt.Rows.Item(I).Item("VII").ToString
                Dim strVIPI As String = dt.Rows.Item(I).Item("VIPI").ToString
                Dim strVPIS As String = dt.Rows.Item(I).Item("VPIS").ToString
                Dim strVCOFINS As String = dt.Rows.Item(I).Item("VCOFINS").ToString
                Dim strVOutro As String = dt.Rows.Item(I).Item("VOutro").ToString
                Dim strVNF As String = dt.Rows.Item(I).Item("VNF").ToString
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
                Dim strCodForn As String = dt.Rows.Item(I).Item("CodForn").ToString
                Dim strPlaca As String = dt.Rows.Item(I).Item("Placa").ToString
                Dim strUFVei As String = dt.Rows.Item(I).Item("UFVei").ToString
                Dim strRNTC As String = dt.Rows.Item(I).Item("RNTC").ToString
                Dim strNomeTrans As String = dt.Rows.Item(I).Item("NomeTrans").ToString
                Dim strCNPJTrans As String = dt.Rows.Item(I).Item("CNPJTrans").ToString
                Dim strIETrans As String = dt.Rows.Item(I).Item("IETrans").ToString
                Dim strEndTrans As String = dt.Rows.Item(I).Item("EndTrans").ToString
                Dim strBairroTrans As String = dt.Rows.Item(I).Item("BairroTrans").ToString
                Dim strNumTrans As String = dt.Rows.Item(I).Item("NumTrans").ToString
                Dim strUFTrans As String = dt.Rows.Item(I).Item("UFTrans").ToString
                Dim strCidadeTrans As String = dt.Rows.Item(I).Item("CidadeTrans").ToString
                Dim strCodVenda As String = dt.Rows.Item(I).Item("CodVenda").ToString
                Dim strSerie As String = dt.Rows.Item(I).Item("Serie").ToString
                Dim strNumFatura As String = dt.Rows.Item(I).Item("NumFatura").ToString
                Dim strValOrigFatura As String = dt.Rows.Item(I).Item("ValOrigFatura").ToString
                Dim strValDescFatura As String = dt.Rows.Item(I).Item("ValDescFatura").ToString
                Dim strValLiqFatura As String = dt.Rows.Item(I).Item("ValLiqFatura").ToString
                Dim strDesconto As String = dt.Rows.Item(I).Item("Desconto").ToString
                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
                Dim strCodEmitente As String = dt.Rows.Item(I).Item("CodEmitente").ToString
                Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
                Dim strIndFinal As String = dt.Rows.Item(I).Item("IndFinal").ToString
                Dim strIndPres As String = dt.Rows.Item(I).Item("IndPres").ToString
                Dim strIdDest As String = dt.Rows.Item(I).Item("IdDest").ToString
                Dim strIndIEDest As String = dt.Rows.Item(I).Item("IndIEDest").ToString
                Dim strAutXml As String = dt.Rows.Item(I).Item("AutXml").ToString
                Dim strValFCPUFDest As String = dt.Rows.Item(I).Item("ValFCPUFDest").ToString
                Dim strValICMSUFDest As String = dt.Rows.Item(I).Item("ValICMSUFDest").ToString
                Dim strValICMSUFRemet As String = dt.Rows.Item(I).Item("ValICMSUFRemet").ToString
                Dim strNomeDest As String = dt.Rows.Item(I).Item("NomeDest").ToString
                Dim strIEDest As String = dt.Rows.Item(I).Item("IEDest").ToString
                Dim strCPFDest As String = dt.Rows.Item(I).Item("CPFDest").ToString
                Dim strEnderecoDest As String = dt.Rows.Item(I).Item("EnderecoDest").ToString
                Dim strNumeroDest As String = dt.Rows.Item(I).Item("NumeroDest").ToString
                Dim strComplementoDest As String = dt.Rows.Item(I).Item("ComplementoDest").ToString
                Dim strBairroDest As String = dt.Rows.Item(I).Item("BairroDest").ToString
                Dim strCidadeDest As String = dt.Rows.Item(I).Item("CidadeDest").ToString
                Dim strCodMunicipioDest As String = dt.Rows.Item(I).Item("CodMunicipioDest").ToString
                Dim strUFDest As String = dt.Rows.Item(I).Item("UFDest").ToString
                Dim strCepDest As String = dt.Rows.Item(I).Item("CepDest").ToString
                Dim strCodPaisDest As String = dt.Rows.Item(I).Item("CodPaisDest").ToString
                Dim strNomePaisDest As String = dt.Rows.Item(I).Item("NomePaisDest").ToString
                Dim strTelefoneDest As String = dt.Rows.Item(I).Item("TelefoneDest").ToString
                Dim strEmailDest As String = dt.Rows.Item(I).Item("EmailDest").ToString
                Dim strStatusEmitente As String = dt.Rows.Item(I).Item("StatusEmitente").ToString
                Dim strCodOrdemPed As String = dt.Rows.Item(I).Item("CodOrdemPed").ToString
                Dim strUFEmbarque As String = dt.Rows.Item(I).Item("UFEmbarque").ToString
                Dim strLocalEmbarque As String = dt.Rows.Item(I).Item("LocalEmbarque").ToString
                Dim strLocalDespacho As String = dt.Rows.Item(I).Item("LocalDespacho").ToString
                Dim strTrocoPag As String = "" 'dt.Rows.Item(I).Item("TrocoPag").ToString
                Dim strTotalFCP As String = "" 'dt.Rows.Item(I).Item("TotalFCP").ToString
                Dim strTotalFCPST As String = "" 'dt.Rows.Item(I).Item("TotalFCPST").ToString
                Dim strTotalFCPSTRet As String = "" 'dt.Rows.Item(I).Item("TotalFCPSTRet").ToString
                Dim strTotalIPIDevol As String = "" 'dt.Rows.Item(I).Item("TotalIPIDevol").ToString



                If bolPassou = False Then
                    Query = "INSERT INTO Totalnfe(CodOrdem, CodNF, NumNF, Chave, IndPag, DEmi, DEntSai, HEntSai, DCont, " & _
                    "HCont, JustCont, CDV, CodCli, VBC, VICMS, VBCST, VST, VProd, VFrete, VSeg, VDesc, VII, VIPI, VPIS, " & _
                    "VCOFINS, VOutro, VNF, NatOp, TipoNF, TipoImp, TipoEmi, TipoAmb, FinNfe, ProcEmi, VerProc, ModFrete, " & _
                    "ObsFisco, ObsCont, CodForn, Placa, UFVei, RNTC, NomeTrans, CNPJTrans, IETrans, EndTrans, BairroTrans, " & _
                    "NumTrans, UFTrans, CidadeTrans, CodVenda, Serie, NumFatura, ValOrigFatura, ValDescFatura, ValLiqFatura, " & _
                    "Desconto, CodConfig, CodEmitente, Status, IndFinal, IndPres, IdDest, IndIEDest, AutXml, ValFCPUFDest, " & _
                    "ValICMSUFDest, ValICMSUFRemet, NomeDest, IEDest, CPFDest, EnderecoDest, NumeroDest, ComplementoDest, " & _
                    "BairroDest, CidadeDest, CodMunicipioDest, UFDest, CepDest, CodPaisDest, NomePaisDest, TelefoneDest, EmailDest, " & _
                    "StatusEmitente, CodOrdemPed, UFEmbarque, LocalEmbarque, LocalDespacho, TrocoPag, TotalFCP, TotalFCPST, " & _
                    "TotalFCPSTRet, TotalIPIDevol) Values('" & strCodOrdem & "','" & strCodNF & "','" & strNumNF & "'," & _
                    "'" & strChave & "','" & strIndPag & "','" & strDEmi & "','" & strDEntSai & "','" & strHEntSai & "'," & _
                    "'" & strDCont & "','" & strHCont & "','" & strJustCont & "','" & strCDV & "','" & strCodCli & "'," & _
                    "" & Num(strVBC) & "," & Num(strVICMS) & "," & Num(strVBCST) & "," & Num(strVST) & "," & Num(strVProd) & "," & _
                    "" & Num(strVFrete) & "," & Num(strVSeg) & "," & Num(strVDesc) & "," & Num(strVII) & "," & Num(strVIPI) & "," & _
                    "" & Num(strVPIS) & "," & _
                    "" & Num(strVCOFINS) & "," & Num(strVOutro) & "," & Num(strVNF) & ",'" & strNatOp & "','" & strTipoNF & "'," & _
                    "'" & strTipoImp & "','" & strTipoEmi & "','" & strTipoAmb & "','" & strFinNfe & "','" & strProcEmi & "'," & _
                    "'" & strVerProc & "','" & strModFrete & "','" & strObsFisco & "','" & strObsCont & "','" & strCodForn & "'," & _
                    "'" & strPlaca & "','" & strUFVei & "','" & strRNTC & "','" & strNomeTrans & "','" & strCNPJTrans & "'," & _
                    "'" & strIETrans & "','" & strEndTrans & "','" & strBairroTrans & "','" & strNumTrans & "','" & strUFTrans & "'," & _
                    "'" & strCidadeTrans & "','" & strCodVenda & "','" & strSerie & "','" & strNumFatura & "','" & strValOrigFatura & "'," & _
                    "'" & strValDescFatura & "','" & strValLiqFatura & "','" & strDesconto & "','" & strCodConfig & "'," & _
                    "'" & strCodEmitente & "','" & strStatus & "','" & strIndFinal & "','" & strIndPres & "','" & strIdDest & "'," & _
                    "'" & strIndIEDest & "','" & strAutXml & "','" & strValFCPUFDest & "','" & strValICMSUFDest & "'," & _
                    "'" & strValICMSUFRemet & "','" & strNomeDest & "','" & strIEDest & "','" & strCPFDest & "','" & strEnderecoDest & "'," & _
                    "'" & strNumeroDest & "','" & strComplementoDest & "','" & strBairroDest & "','" & strCidadeDest & "'," & _
                    "'" & strCodMunicipioDest & "','" & strUFDest & "','" & strCepDest & "','" & strCodPaisDest & "'," & _
                    "'" & strNomePaisDest & "','" & strTelefoneDest & "','" & strEmailDest & "','" & strStatusEmitente & "'," & _
                    "'" & strCodOrdemPed & "','" & strUFEmbarque & "','" & strLocalEmbarque & "','" & strLocalDespacho & "'," & _
                    "'" & strTrocoPag & "','" & strTotalFCP & "','" & strTotalFCPST & "','" & strTotalFCPSTRet & "','" & strTotalIPIDevol & "');"

                    bolPassou = True
                Else
                    Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Totalnfe(CodOrdem, CodNF, NumNF, Chave, IndPag, DEmi, DEntSai, HEntSai, DCont, " & _
                    "HCont, JustCont, CDV, CodCli, VBC, VICMS, VBCST, VST, VProd, VFrete, VSeg, VDesc, VII, VIPI, VPIS, " & _
                    "VCOFINS, VOutro, VNF, NatOp, TipoNF, TipoImp, TipoEmi, TipoAmb, FinNfe, ProcEmi, VerProc, ModFrete, " & _
                    "ObsFisco, ObsCont, CodForn, Placa, UFVei, RNTC, NomeTrans, CNPJTrans, IETrans, EndTrans, BairroTrans, " & _
                    "NumTrans, UFTrans, CidadeTrans, CodVenda, Serie, NumFatura, ValOrigFatura, ValDescFatura, ValLiqFatura, " & _
                    "Desconto, CodConfig, CodEmitente, Status, IndFinal, IndPres, IdDest, IndIEDest, AutXml, ValFCPUFDest, " & _
                    "ValICMSUFDest, ValICMSUFRemet, NomeDest, IEDest, CPFDest, EnderecoDest, NumeroDest, ComplementoDest, " & _
                    "BairroDest, CidadeDest, CodMunicipioDest, UFDest, CepDest, CodPaisDest, NomePaisDest, TelefoneDest, EmailDest, " & _
                    "StatusEmitente, CodOrdemPed, UFEmbarque, LocalEmbarque, LocalDespacho, TrocoPag, TotalFCP, TotalFCPST, " & _
                    "TotalFCPSTRet, TotalIPIDevol) Values('" & strCodOrdem & "','" & strCodNF & "','" & strNumNF & "'," & _
                    "'" & strChave & "','" & strIndPag & "','" & strDEmi & "','" & strDEntSai & "','" & strHEntSai & "'," & _
                    "'" & strDCont & "','" & strHCont & "','" & strJustCont & "','" & strCDV & "','" & strCodCli & "'," & _
                    "" & Num(strVBC) & "," & Num(strVICMS) & "," & Num(strVBCST) & "," & Num(strVST) & "," & Num(strVProd) & "," & _
                    "" & Num(strVFrete) & "," & Num(strVSeg) & "," & Num(strVDesc) & "," & Num(strVII) & "," & Num(strVIPI) & "," & _
                    "" & Num(strVPIS) & "," & _
                    "" & Num(strVCOFINS) & "," & Num(strVOutro) & "," & Num(strVNF) & ",'" & strNatOp & "','" & strTipoNF & "'," & _
                    "'" & strTipoImp & "','" & strTipoEmi & "','" & strTipoAmb & "','" & strFinNfe & "','" & strProcEmi & "'," & _
                    "'" & strVerProc & "','" & strModFrete & "','" & strObsFisco & "','" & strObsCont & "','" & strCodForn & "'," & _
                    "'" & strPlaca & "','" & strUFVei & "','" & strRNTC & "','" & strNomeTrans & "','" & strCNPJTrans & "'," & _
                    "'" & strIETrans & "','" & strEndTrans & "','" & strBairroTrans & "','" & strNumTrans & "','" & strUFTrans & "'," & _
                    "'" & strCidadeTrans & "','" & strCodVenda & "','" & strSerie & "','" & strNumFatura & "','" & strValOrigFatura & "'," & _
                    "'" & strValDescFatura & "','" & strValLiqFatura & "','" & strDesconto & "','" & strCodConfig & "'," & _
                    "'" & strCodEmitente & "','" & strStatus & "','" & strIndFinal & "','" & strIndPres & "','" & strIdDest & "'," & _
                    "'" & strIndIEDest & "','" & strAutXml & "','" & strValFCPUFDest & "','" & strValICMSUFDest & "'," & _
                    "'" & strValICMSUFRemet & "','" & strNomeDest & "','" & strIEDest & "','" & strCPFDest & "','" & strEnderecoDest & "'," & _
                    "'" & strNumeroDest & "','" & strComplementoDest & "','" & strBairroDest & "','" & strCidadeDest & "'," & _
                    "'" & strCodMunicipioDest & "','" & strUFDest & "','" & strCepDest & "','" & strCodPaisDest & "'," & _
                    "'" & strNomePaisDest & "','" & strTelefoneDest & "','" & strEmailDest & "','" & strStatusEmitente & "'," & _
                    "'" & strCodOrdemPed & "','" & strUFEmbarque & "','" & strLocalEmbarque & "','" & strLocalDespacho & "'," & _
                    "'" & strTrocoPag & "','" & strTotalFCP & "','" & strTotalFCPST & "','" & strTotalFCPSTRet & "','" & strTotalIPIDevol & "');"

                End If

                count = count + 1
                If count = 500 Then
                    Inserir(Query)
                    System.Threading.Thread.Sleep(40)

                    Query = ""
                    count = 0
                End If

                B += 1
                LogDeErro()
            Next
            If Query <> "" Then
                Inserir(Query)
            End If
            Inserir("Update Totalnfe set CodCli=Cliente.Codigo From Totalnfe Left Join Cliente on Totalnfe.CodCli = Cliente.Pessoa1")
            strTabela = "Totalnfe"
            Me.lblTabAtual.Text = "ItensNfe"
            BarraProdgresso()


            Query = ""
            bolPassou = False
            count = 0



            '**********ITENSNFE**********
            B = 1
            dt = CarregarDataTable2("SELECT * FROM ItensNfe order by Codigo", strNomeBanco)
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

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
                Dim strVCBCOFINS As String = dt.Rows.Item(I).Item("VCBCOFINS").ToString
                Dim strPerCOFINS As String = dt.Rows.Item(I).Item("PerCOFINS").ToString
                Dim strValCOFINS As String = dt.Rows.Item(I).Item("ValCOFINS").ToString
                Dim strVCalcCred As String = dt.Rows.Item(I).Item("VCalcCred").ToString
                Dim strValAprox As String = dt.Rows.Item(I).Item("ValAprox").ToString
                Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
                Dim strCodigoANP As String = dt.Rows.Item(I).Item("CodigoANP").ToString
                Dim strUFComb As String = dt.Rows.Item(I).Item("UFComb").ToString
                Dim strBCFCP As String = "" 'dt.Rows.Item(I).Item("BCFCP").ToString
                Dim strPerFCP As String = "" 'dt.Rows.Item(I).Item("PerFCP").ToString
                Dim strValFCP As String = "" 'dt.Rows.Item(I).Item("ValFCP").ToString
                Dim strBCFCPST As String = "" 'dt.Rows.Item(I).Item("BCFCPST").ToString
                Dim strPerFCPST As String = "" 'dt.Rows.Item(I).Item("PerFCPST").ToString
                Dim strValFCPST As String = "" 'dt.Rows.Item(I).Item("ValFCPST").ToString
                Dim strPerIPIDevol As String = "" 'dt.Rows.Item(I).Item("PerIPIDevol").ToString
                Dim strValIPIDevol As String = "" 'dt.Rows.Item(I).Item("ValIPIDevol").ToString
                Dim strCodBarra2 As String = "" 'dt.Rows.Item(I).Item("CodBarra2").ToString
                Dim strQTrib As String = "" 'dt.Rows.Item(I).Item("QTrib").ToString
                Dim strUTrib As String = "" 'dt.Rows.Item(I).Item("UTrib").ToString
                Dim strVUnTrib As String = "" 'dt.Rows.Item(I).Item("VUnTrib").ToString
                Dim strDescANP As String = "" 'dt.Rows.Item(I).Item("DescANP").ToString
                Dim strFreteProd As String = "" 'dt.Rows.Item(I).Item("FreteProd").ToString
                Dim strDespesasProd As String = "" 'dt.Rows.Item(I).Item("DespesasProd").ToString
                Dim strCodEmitente As String = dt.Rows.Item(I).Item("CodEmitente").ToString
                Dim strUniSemDesc As String = dt.Rows.Item(I).Item("UniSemDesc").ToString
                Dim strCest As String = dt.Rows.Item(I).Item("Cest").ToString
                Dim strValBCUFDest As String = dt.Rows.Item(I).Item("ValBCUFDest").ToString
                Dim strPerFCPUFDest As String = dt.Rows.Item(I).Item("PerFCPUFDest").ToString
                Dim strPerICMSUFDest As String = dt.Rows.Item(I).Item("PerICMSUFDest").ToString
                Dim strPerICMSInter As String = dt.Rows.Item(I).Item("PerICMSInter").ToString
                Dim strPerICMSInterPart As String = dt.Rows.Item(I).Item("PerICMSInterPart").ToString
                Dim strValFCPUFDest As String = dt.Rows.Item(I).Item("ValFCPUFDest").ToString
                Dim strValICMSUFDest As String = dt.Rows.Item(I).Item("ValICMSUFDest").ToString
                Dim strValICMSUFRemet As String = dt.Rows.Item(I).Item("ValICMSUFRemet").ToString
                Dim strPedCompra As String = dt.Rows.Item(I).Item("PedCompra").ToString
                Dim strNumItemCompra As String = dt.Rows.Item(I).Item("NumItemCompra").ToString
                Dim strStatusEmitente As String = dt.Rows.Item(I).Item("StatusEmitente").ToString
                Dim strNumDocImp As String = dt.Rows.Item(I).Item("NumDocImp").ToString
                Dim strDataDocImp As String = dt.Rows.Item(I).Item("DataDocImp").ToString
                Dim strLocalDesemImp As String = dt.Rows.Item(I).Item("LocalDesemImp").ToString
                Dim strUFDesemImp As String = dt.Rows.Item(I).Item("UFDesemImp").ToString
                Dim strDataDesemImp As String = dt.Rows.Item(I).Item("DataDesemImp").ToString
                Dim strViaTranspImp As String = dt.Rows.Item(I).Item("ViaTranspImp").ToString
                Dim strTipoInterImp As String = dt.Rows.Item(I).Item("TipoInterImp").ToString
                Dim strCodExpImp As String = dt.Rows.Item(I).Item("CodExpImp").ToString
                Dim strNumAdicImp As String = dt.Rows.Item(I).Item("NumAdicImp").ToString
                Dim strNumSeqImp As String = dt.Rows.Item(I).Item("NumSeqImp").ToString
                Dim strCodFabriImp As String = dt.Rows.Item(I).Item("CodFabriImp").ToString
                Dim strValBCImp As String = dt.Rows.Item(I).Item("ValBCImp").ToString
                Dim strValDespImp As String = dt.Rows.Item(I).Item("ValDespImp").ToString
                Dim strValIOFImp As String = dt.Rows.Item(I).Item("ValIOFImp").ToString
                Dim strValImp As String = dt.Rows.Item(I).Item("ValImp").ToString
                Dim strvICMSOp As String = dt.Rows.Item(I).Item("vICMSOp").ToString
                Dim strpDif As String = dt.Rows.Item(I).Item("pDif").ToString
                Dim strvICMSDif As String = dt.Rows.Item(I).Item("vICMSDif").ToString



                If bolPassou = False Then
                    Query = "INSERT INTO ItensNfe(CodOrdem, CodProd, CodInterno, CodBarra, Produto, NCM, CFOP, EXTIPI, " & _
                    "UCom, QCom, VUnCom, VProd, Origem, CSTICMS, ModBC, VBCICMS, RedBC, ICMS, ValICMS, ModBCST, RedBCST, " & _
                    "VBCST, ICMSST, ValICMSST, MVaST, CalcCred, CodEnq, CSTIPI, VBCIPI, PerIPI, ValIPI, CSTPIS, VBCPIS, " & _
                    "PerPIS, ValPIS, CSTCOFINS, VCBCOFINS, PerCOFINS, ValCOFINS, VCalcCred, ValAprox, CodConfig, CodigoANP, " & _
                    "UFComb, BCFCP, PerFCP, ValFCP, BCFCPST, PerFCPST, ValFCPST, PerIPIDevol, ValIPIDevol, CodBarra2, QTrib, " & _
                    "UTrib, VUnTrib, DescANP, FreteProd, DespesasProd, CodEmitente, UniSemDesc, Cest, ValBCUFDest, PerFCPUFDest, " & _
                    "PerICMSUFDest, PerICMSInter, PerICMSInterPart, ValFCPUFDest, ValICMSUFDest, ValICMSUFRemet, PedCompra, " & _
                    "NumItemCompra, StatusEmitente, NumDocImp, DataDocImp, LocalDesemImp, UFDesemImp, DataDesemImp, ViaTranspImp, " & _
                    "TipoInterImp, CodExpImp, NumAdicImp, NumSeqImp, CodFabriImp, ValBCImp, ValDespImp, ValIOFImp, ValImp, " & _
                    "vICMSOp, pDif, vICMSDif) Values('" & strCodOrdem & "','" & strCodProd & "','" & strCodInterno & "'," & _
                    "'" & strCodBarra & "','" & strProduto & "','" & strNCM & "','" & strCFOP & "','" & strEXTIPI & "'," & _
                    "'" & strUCom & "'," & Num(strQCom) & "," & Num(strVUnCom) & "," & Num(strVProd) & ",'" & strOrigem & "'," & _
                    "'" & strCSTICMS & "','" & strModBC & "','" & strVBCICMS & "','" & strRedBC & "','" & strICMS & "'," & _
                    "'" & strValICMS & "','" & strModBCST & "','" & strRedBCST & "','" & strVBCST & "','" & strICMSST & "'," & _
                    "'" & strValICMSST & "','" & strMVaST & "','" & strCalcCred & "','" & strCodEnq & "','" & strCSTIPI & "'," & _
                    "'" & strVBCIPI & "','" & strPerIPI & "','" & strValIPI & "','" & strCSTPIS & "','" & strVBCPIS & "'," & _
                    "'" & strPerPIS & "','" & strValPIS & "','" & strCSTCOFINS & "','" & strVCBCOFINS & "','" & strPerCOFINS & "'," & _
                    "'" & strValCOFINS & "','" & strVCalcCred & "','" & strValAprox & "','" & strCodConfig & "'," & _
                    "'" & strCodigoANP & "','" & strUFComb & "','" & strBCFCP & "','" & strPerFCP & "','" & strValFCP & "'," & _
                    "'" & strBCFCPST & "','" & strPerFCPST & "','" & strValFCPST & "','" & strPerIPIDevol & "','" & strValIPIDevol & "'," & _
                    "'" & strCodBarra2 & "'," & Num(strQTrib) & ",'" & strUTrib & "'," & Num(strVUnTrib) & ",'" & strDescANP & "'," & _
                    "'" & strFreteProd & "','" & strDespesasProd & "','" & strCodEmitente & "'," & Num(strUniSemDesc) & "," & _
                    "'" & strCest & "','" & strValBCUFDest & "','" & strPerFCPUFDest & "','" & strPerICMSUFDest & "'," & _
                    "'" & strPerICMSInter & "','" & strPerICMSInterPart & "','" & strValFCPUFDest & "','" & strValICMSUFDest & "'," & _
                    "'" & strValICMSUFRemet & "','" & strPedCompra & "','" & strNumItemCompra & "','" & strStatusEmitente & "'," & _
                    "'" & strNumDocImp & "','" & strDataDocImp & "','" & strLocalDesemImp & "','" & strUFDesemImp & "'," & _
                    "'" & strDataDesemImp & "','" & strViaTranspImp & "','" & strTipoInterImp & "','" & strCodExpImp & "'," & _
                    "'" & strNumAdicImp & "','" & strNumSeqImp & "','" & strCodFabriImp & "','" & strValBCImp & "'," & _
                    "'" & strValDespImp & "','" & strValIOFImp & "','" & strValImp & "','" & strvICMSOp & "','" & strpDif & "'," & _
                    "'" & strvICMSDif & "');"

                    bolPassou = True
                Else
                    Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO ItensNfe(CodOrdem, CodProd, CodInterno, " & _
                    "CodBarra, Produto, NCM, CFOP, EXTIPI, " & _
                    "UCom, QCom, VUnCom, VProd, Origem, CSTICMS, ModBC, VBCICMS, RedBC, ICMS, ValICMS, ModBCST, RedBCST, " & _
                    "VBCST, ICMSST, ValICMSST, MVaST, CalcCred, CodEnq, CSTIPI, VBCIPI, PerIPI, ValIPI, CSTPIS, VBCPIS, " & _
                    "PerPIS, ValPIS, CSTCOFINS, VCBCOFINS, PerCOFINS, ValCOFINS, VCalcCred, ValAprox, CodConfig, CodigoANP, " & _
                    "UFComb, BCFCP, PerFCP, ValFCP, BCFCPST, PerFCPST, ValFCPST, PerIPIDevol, ValIPIDevol, CodBarra2, QTrib, " & _
                    "UTrib, VUnTrib, DescANP, FreteProd, DespesasProd, CodEmitente, UniSemDesc, Cest, ValBCUFDest, PerFCPUFDest, " & _
                    "PerICMSUFDest, PerICMSInter, PerICMSInterPart, ValFCPUFDest, ValICMSUFDest, ValICMSUFRemet, PedCompra, " & _
                    "NumItemCompra, StatusEmitente, NumDocImp, DataDocImp, LocalDesemImp, UFDesemImp, DataDesemImp, ViaTranspImp, " & _
                    "TipoInterImp, CodExpImp, NumAdicImp, NumSeqImp, CodFabriImp, ValBCImp, ValDespImp, ValIOFImp, ValImp, " & _
                    "vICMSOp, pDif, vICMSDif) Values('" & strCodOrdem & "','" & strCodProd & "','" & strCodInterno & "'," & _
                    "'" & strCodBarra & "','" & strProduto & "','" & strNCM & "','" & strCFOP & "','" & strEXTIPI & "'," & _
                    "'" & strUCom & "'," & Num(strQCom) & "," & Num(strVUnCom) & "," & Num(strVProd) & ",'" & strOrigem & "'," & _
                    "'" & strCSTICMS & "','" & strModBC & "','" & strVBCICMS & "','" & strRedBC & "','" & strICMS & "'," & _
                    "'" & strValICMS & "','" & strModBCST & "','" & strRedBCST & "','" & strVBCST & "','" & strICMSST & "'," & _
                    "'" & strValICMSST & "','" & strMVaST & "','" & strCalcCred & "','" & strCodEnq & "','" & strCSTIPI & "'," & _
                    "'" & strVBCIPI & "','" & strPerIPI & "','" & strValIPI & "','" & strCSTPIS & "','" & strVBCPIS & "'," & _
                    "'" & strPerPIS & "','" & strValPIS & "','" & strCSTCOFINS & "','" & strVCBCOFINS & "','" & strPerCOFINS & "'," & _
                    "'" & strValCOFINS & "','" & strVCalcCred & "','" & strValAprox & "','" & strCodConfig & "'," & _
                    "'" & strCodigoANP & "','" & strUFComb & "','" & strBCFCP & "','" & strPerFCP & "','" & strValFCP & "'," & _
                    "'" & strBCFCPST & "','" & strPerFCPST & "','" & strValFCPST & "','" & strPerIPIDevol & "','" & strValIPIDevol & "'," & _
                    "'" & strCodBarra2 & "'," & Num(strQTrib) & ",'" & strUTrib & "'," & Num(strVUnTrib) & ",'" & strDescANP & "'," & _
                    "'" & strFreteProd & "','" & strDespesasProd & "','" & strCodEmitente & "'," & Num(strUniSemDesc) & "," & _
                    "'" & strCest & "','" & strValBCUFDest & "','" & strPerFCPUFDest & "','" & strPerICMSUFDest & "'," & _
                    "'" & strPerICMSInter & "','" & strPerICMSInterPart & "','" & strValFCPUFDest & "','" & strValICMSUFDest & "'," & _
                    "'" & strValICMSUFRemet & "','" & strPedCompra & "','" & strNumItemCompra & "','" & strStatusEmitente & "'," & _
                    "'" & strNumDocImp & "','" & strDataDocImp & "','" & strLocalDesemImp & "','" & strUFDesemImp & "'," & _
                    "'" & strDataDesemImp & "','" & strViaTranspImp & "','" & strTipoInterImp & "','" & strCodExpImp & "'," & _
                    "'" & strNumAdicImp & "','" & strNumSeqImp & "','" & strCodFabriImp & "','" & strValBCImp & "'," & _
                    "'" & strValDespImp & "','" & strValIOFImp & "','" & strValImp & "','" & strvICMSOp & "','" & strpDif & "'," & _
                    "'" & strvICMSDif & "');"

                End If

                count = count + 1
                If count = 500 Then
                    Inserir(Query)
                    System.Threading.Thread.Sleep(40)

                    Query = ""
                    count = 0
                End If

                B += 1
                LogDeErro()
            Next
            If Query <> "" Then
                Inserir(Query)
            End If
            Inserir("Update ItensNFe Set CodProd=case when Produto.Codigo is not null then Produto.Codigo else 0 end " & _
            "From ItensNFe Left Join Produto on ItensNFe.CodProd = Produto.Locacao")
            strTabela = "ItensNfe"
            Me.lblTabAtual.Text = "Log"
            BarraProdgresso()


            Query = ""
            bolPassou = False
            count = 0
        End If



        '**********LOG**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Log order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString

            Dim dtUser As DataTable = CarregarDataTable("Select Codigo From Usuario Where Skin='" & dt.Rows.Item(I).Item("CodUser").ToString & "'")
            Dim strCodUser As String = "" 'dt.Rows.Item(I).Item("CodUser").ToString
            If dtUser.Rows.Count > 0 Then
                strCodUser = dtUser.Rows.Item(0).Item("Codigo").ToString
            Else
                strCodUser = dt.Rows.Item(I).Item("CodUser").ToString
            End If

            Dim strAntigo As String = dt.Rows.Item(I).Item("Antigo").ToString.Replace("'", "´").Replace("&", "E")
            Dim strNovo As String = dt.Rows.Item(I).Item("Novo").ToString.Replace("'", "´").Replace("&", "E")
            Dim strColuna As String = dt.Rows.Item(I).Item("Coluna").ToString.Replace("'", "´").Replace("&", "E")
            Dim strTabela As String = dt.Rows.Item(I).Item("Tabela").ToString.Replace("'", "´").Replace("&", "E")
            Dim strMotivo As String = dt.Rows.Item(I).Item("Motivo").ToString.Replace("'", "´").Replace("&", "E")
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString.Replace("'", "´").Replace("&", "E")


            If bolPassou = False Then
                Query = "INSERT INTO Log(Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) " & _
                "Values('" & strData & "','" & strCodUser & "','" & strAntigo & "','" & strNovo & "'," & _
                "'" & strColuna & "','" & strTabela & "','" & strMotivo & "','" & strCodConfig & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Log(Data, CodUser, Antigo, Novo, " & _
                "Coluna, Tabela, Motivo, CodConfig) " & _
                "Values('" & strData & "','" & strCodUser & "','" & strAntigo & "','" & strNovo & "'," & _
                "'" & strColuna & "','" & strTabela & "','" & strMotivo & "','" & strCodConfig & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "Log"
        Me.lblTabAtual.Text = "NFCe"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********NFCE**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM NFCe order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
            Dim strChave As String = dt.Rows.Item(I).Item("Chave").ToString
            Dim strNumNF As String = dt.Rows.Item(I).Item("NumNF").ToString
            Dim strCodNF As String = dt.Rows.Item(I).Item("CodNF").ToString
            Dim strChaveCancelamento As String = dt.Rows.Item(I).Item("ChaveCancelamento").ToString
            Dim strCNPJ As String = dt.Rows.Item(I).Item("CNPJ").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strValorTotal As String = dt.Rows.Item(I).Item("ValorTotal").ToString
            Dim strCFPDest As String = dt.Rows.Item(I).Item("CFPDest").ToString
            Dim strStatusEmitente As String = dt.Rows.Item(I).Item("StatusEmitente").ToString
            Dim strCodEmitente As String = dt.Rows.Item(I).Item("CodEmitente").ToString
            Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


            If bolPassou = False Then
                Query = "INSERT INTO NFCe(CodOrdem, Chave, NumNF, CodNF, ChaveCancelamento, CNPJ, Data, ValorTotal, " & _
                "CFPDest, StatusEmitente, CodEmitente, Status, CodConfig) Values('" & strCodOrdem & "','" & strChave & "'," & _
                "'" & strNumNF & "','" & strCodNF & "','" & strChaveCancelamento & "','" & strCNPJ & "','" & strData & "'," & _
                "" & Num(strValorTotal) & "," & _
                "'" & strCFPDest & "','" & strStatusEmitente & "','" & strCodEmitente & "','" & strStatus & "','" & strCodConfig & "');"
                'Inserir(Query)
                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO NFCe(CodOrdem, Chave, NumNF, CodNF, ChaveCancelamento, " & _
                "CNPJ, Data, ValorTotal, CFPDest, StatusEmitente, CodEmitente, Status, CodConfig) Values('" & strCodOrdem & "'," & _
                "'" & strChave & "','" & strNumNF & "','" & strCodNF & "','" & strChaveCancelamento & "','" & strCNPJ & "'," & _
                "'" & strData & "'," & Num(strValorTotal) & ",'" & strCFPDest & "','" & strStatusEmitente & "','" & strCodEmitente & "'," & _
                "'" & strStatus & "','" & strCodConfig & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "NFCe"
        Me.lblTabAtual.Text = "Operador"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********OPERADOR**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Operador order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString


            Dim strOperador As String = dt.Rows.Item(I).Item("Operador").ToString
            Dim strTipo As String = dt.Rows.Item(I).Item("Tipo").ToString
            Dim strEntrada As String = dt.Rows.Item(I).Item("Entrada").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strCodConfigECF As String = dt.Rows.Item(I).Item("CodConfigECF").ToString


            If bolPassou = False Then
                Query = "INSERT INTO Operador(Operador, Tipo, Entrada, Data, CodConfig, CodConfigECF) " & _
                "Values('" & strOperador & "','" & strTipo & "'," & Num(strEntrada) & ",'" & strData & "'," & _
                "'" & strCodConfig & "','" & strCodConfigECF & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Operador(Operador, Tipo, Entrada, Data, " & _
                "CodConfig, CodConfigECF) Values('" & strOperador & "','" & strTipo & "'," & Num(strEntrada) & "," & _
                "'" & strData & "','" & strCodConfig & "','" & strCodConfigECF & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "Operador"
        Me.lblTabAtual.Text = "TotalPedCompra"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********TOTALPEDCOMPRA**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM TotalPedCompra order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strCodOrdens As String = dt.Rows.Item(I).Item("CodOrdens").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString


            Dim dtCPFFor As DataTable = CarregarDataTable2("Select CPF From Fornecedor Where Codigo=" & dt.Rows.Item(I).Item("CodFor").ToString & "", strNomeBanco)
            Dim strCPFFor As String = ""
            If dtCPFFor.Rows.Count > 0 Then
                strCPFFor = dtCPFFor.Rows.Item(0).Item("CPF").ToString
            End If


            Dim dtCodFor As DataTable = CarregarDataTable("Select Codigo From Fornecedor Where CPF='" & strCPFFor & "'")
            Dim strCodFor As String = "" 'dt.Rows.Item(I).Item("CodFor").ToString
            If dtCodFor.Rows.Count > 0 Then
                strCodFor = dtCodFor.Rows.Item(0).Item("Codigo").ToString
            End If

            Dim strTotal As String = dt.Rows.Item(I).Item("Total").ToString
            Dim strDescricao As String = dt.Rows.Item(I).Item("Descricao").ToString
            Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
            Dim strCusto As String = dt.Rows.Item(I).Item("Custo").ToString
            Dim strDesconto As String = dt.Rows.Item(I).Item("Desconto").ToString
            Dim strEntrega As String = dt.Rows.Item(I).Item("Entrega").ToString
            Dim strCodFunc As String = dt.Rows.Item(I).Item("CodFunc").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strDataVenda As String = "" 'dt.Rows.Item(I).Item("DataRetirada").ToString
            Dim strCodAnimal As String = 0 'dt.Rows.Item(I).Item("CodAnimal").ToString
            Dim strAcrescimo As String = dt.Rows.Item(I).Item("Acrescimo").ToString
            Dim strDataRetirada As String = dt.Rows.Item(I).Item("DataRetirada").ToString
            Dim strDataEntrega As String = dt.Rows.Item(I).Item("DataEntrega").ToString
            Dim strNumeroNF As String = dt.Rows.Item(I).Item("NumeroNF").ToString



            If bolPassou = False Then
                Query = "INSERT INTO TotalPedCompra(CodOrdens, Data, CodFor, Total, Descricao, Status, Custo, " & _
                "Desconto, Entrega, CodFunc, CodConfig, Acrescimo, DataRetirada, DataEntrega " & _
                ") Values('" & strCodOrdens & "','" & strData & "','" & strCodFor & "'," & Num(strTotal) & "," & _
                "'" & strDescricao & "','" & strStatus & "'," & Num(strCusto) & ",'" & strDesconto & "'," & _
                "'" & strEntrega & "','" & strCodFunc & "','" & strCodConfig & "'," & _
                "'" & strAcrescimo & "','" & strDataRetirada & "','" & strDataEntrega & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO TotalPedCompra(CodOrdens, Data, CodFor, Total, " & _
                "Descricao, Status, Custo, Desconto, Entrega, CodFunc, CodConfig, Acrescimo, " & _
                "DataRetirada, DataEntrega) Values('" & strCodOrdens & "','" & strData & "','" & strCodFor & "'," & _
                "" & Num(strTotal) & ",'" & strDescricao & "','" & strStatus & "'," & Num(strCusto) & ",'" & strDesconto & "'," & _
                "'" & strEntrega & "','" & strCodFunc & "','" & strCodConfig & "'," & _
                "'" & strAcrescimo & "','" & strDataRetirada & "','" & strDataEntrega & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "TotalPedCompra"
        Me.lblTabAtual.Text = "PedCompra"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********PEDCOMPRA**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM PedCompra order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strCodOrdens As String = dt.Rows.Item(I).Item("CodOrdens").ToString
            Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
            Dim strCodigoProduto As String = dt.Rows.Item(I).Item("CodigoProduto").ToString
            Dim strProduto As String = dt.Rows.Item(I).Item("Produto").ToString
            Dim strValorUnitario As String = dt.Rows.Item(I).Item("ValorUnitario").ToString
            Dim strValorTotal As String = dt.Rows.Item(I).Item("ValorTotal").ToString
            Dim strCodigoInterno As String = dt.Rows.Item(I).Item("CodigoInterno").ToString
            Dim strCusto As String = dt.Rows.Item(I).Item("Custo").ToString
            Dim strUM As String = dt.Rows.Item(I).Item("UM").ToString

            If strUM = "UNIDADE" Then
                strUM = "UN"
            ElseIf strUM = "JOGO" Then
                strUM = "JG"
            ElseIf strUM = "KIT" Then
                strUM = "KT"
            ElseIf strUM = "PESO" Then
                strUM = "PS"
            ElseIf strUM = "LÍTRO" Then
                strUM = "LT"
            ElseIf strUM = "METRO" Then
                strUM = "MT"
            ElseIf strUM = "HORA" Then
                strUM = "HR"
            End If

            Dim strTamanho As String = "U" 'dt.Rows.Item(I).Item("Tamanho").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strUniSemDesc As String = dt.Rows.Item(I).Item("UniSemDesc").ToString
            Dim strPromocao As String = dt.Rows.Item(I).Item("Promocao").ToString
            Dim strDesconto As String = dt.Rows.Item(I).Item("Desconto").ToString
            Dim strRetorno As String = "" 'dt.Rows.Item(I).Item("Retorno").ToString
            Dim strMedidaA As String = 0 'dt.Rows.Item(I).Item("MedidaA").ToString
            Dim strMedidaB As String = 0 'dt.Rows.Item(I).Item("MedidaB").ToString
            Dim strQtdMedida As String = 0 'dt.Rows.Item(I).Item("QtdMedida").ToString


            If bolPassou = False Then
                Query = "INSERT INTO PedCompra(CodOrdens, Qtd, CodigoProduto, Produto, ValorUnitario, " & _
                "ValorTotal, CodigoInterno, Custo, UM, Tamanho, CodConfig, UniSemDesc, Promocao, Desconto, " & _
                "MedidaA, MedidaB, QtdMedida) Values('" & strCodOrdens & "'," & Num(strQtd) & ",'" & strCodigoProduto & "'," & _
                "'" & strProduto & "'," & Num(strValorUnitario) & "," & Num(strValorTotal) & ",'" & strCodigoInterno & "'," & _
                "" & Num(strCusto) & ",'" & strUM & "','" & strTamanho & "','" & strCodConfig & "'," & Num(strUniSemDesc) & "," & _
                "'" & strPromocao & "'," & Num(strDesconto) & "," & Num(strMedidaA) & "," & _
                "" & Num(strMedidaB) & "," & Num(strQtdMedida) & ");"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO PedCompra(CodOrdens, Qtd, CodigoProduto, Produto, " & _
                "ValorUnitario, ValorTotal, CodigoInterno, Custo, UM, Tamanho, CodConfig, UniSemDesc, Promocao, Desconto, " & _
                "MedidaA, MedidaB, QtdMedida) Values('" & strCodOrdens & "'," & Num(strQtd) & ",'" & strCodigoProduto & "'," & _
                "'" & strProduto & "'," & Num(strValorUnitario) & "," & Num(strValorTotal) & ",'" & strCodigoInterno & "'," & _
                "" & Num(strCusto) & ",'" & strUM & "','" & strTamanho & "','" & strCodConfig & "'," & Num(strUniSemDesc) & "," & _
                "'" & strPromocao & "'," & Num(strDesconto) & "," & Num(strMedidaA) & "," & _
                "" & Num(strMedidaB) & "," & Num(strQtdMedida) & ");"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "PedCompra"
        Me.lblTabAtual.Text = "Recebimento"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********RECEBIMENTO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Recebimento order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodigoPedido").ToString.Replace("~", "").Replace("'", "").Replace("´", "")
            If strCodOrdem = "" Then
                strCodOrdem = 0
            End If

            Dim strFormaPagamento As String = dt.Rows.Item(I).Item("FormaPagamento").ToString
            Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
            Dim strDocumento As String = dt.Rows.Item(I).Item("Documento").ToString
            Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strCodigoPedido As String = dt.Rows.Item(I).Item("CodigoPedido").ToString
            Dim strAuxiliar As String = "" 'dt.Rows.Item(I).Item("Auxiliar").ToString
            Dim strBandeira As String = "" 'dt.Rows.Item(I).Item("Bandeira").ToString


            If bolPassou = False Then
                Query = "INSERT INTO Recebimento(CodOrdem, FormaPagamento, Pagamento, Documento, Valor, Data, Obs, " & _
                "CodConfig, CodigoPedido, Auxiliar, Bandeira) Values('" & strCodOrdem & "','" & strFormaPagamento & "'," & _
                "'" & strPagamento & "','" & strDocumento & "'," & Num(strValor) & ",'" & strData & "','" & strObs & "'," & _
                "'" & strCodConfig & "','" & strCodigoPedido & "','" & strAuxiliar & "','" & strBandeira & "');"
                'Inserir(Query)
                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Recebimento(CodOrdem, FormaPagamento, Pagamento, " & _
                "Documento, Valor, Data, Obs, CodConfig, CodigoPedido, Auxiliar, Bandeira) Values('" & strCodOrdem & "'," & _
                "'" & strFormaPagamento & "','" & strPagamento & "','" & strDocumento & "'," & Num(strValor) & "," & _
                "'" & strData & "','" & strObs & "','" & strCodConfig & "','" & strCodigoPedido & "','" & strAuxiliar & "'," & _
                "'" & strBandeira & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "Recebimento"
        Me.lblTabAtual.Text = "RefNfe"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********REFNFE**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM RefNfe order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
            Dim strTipo As String = dt.Rows.Item(I).Item("Tipo").ToString
            Dim strChave As String = dt.Rows.Item(I).Item("Chave").ToString
            Dim strUF As String = dt.Rows.Item(I).Item("UF").ToString
            Dim strEmissao As String = dt.Rows.Item(I).Item("Emissao").ToString
            Dim strCNPJ As String = dt.Rows.Item(I).Item("CNPJ").ToString
            Dim strModelo As String = dt.Rows.Item(I).Item("Modelo").ToString
            Dim strSerie As String = dt.Rows.Item(I).Item("Serie").ToString
            Dim strNumero As String = dt.Rows.Item(I).Item("Numero").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strCodEmitente As String = dt.Rows.Item(I).Item("CodEmitente").ToString
            Dim strNumECF As String = dt.Rows.Item(I).Item("NumECF").ToString
            Dim strNumCOO As String = dt.Rows.Item(I).Item("NumCOO").ToString
            Dim strStatusEmitente As String = dt.Rows.Item(I).Item("StatusEmitente").ToString


            If bolPassou = False Then
                Query = "INSERT INTO RefNfe(CodOrdem, Tipo, Chave, UF, Emissao, CNPJ, Modelo, Serie, Numero, " & _
                "CodConfig, CodEmitente, NumECF, NumCOO, StatusEmitente) Values('" & strCodOrdem & "','" & strTipo & "'," & _
                "'" & strChave & "','" & strUF & "','" & strEmissao & "','" & strCNPJ & "','" & strModelo & "'," & _
                "'" & strSerie & "','" & strNumero & "','" & strCodConfig & "','" & strCodEmitente & "','" & strNumECF & "'," & _
                "'" & strNumCOO & "','" & strStatusEmitente & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO RefNfe(CodOrdem, Tipo, Chave, UF, Emissao, CNPJ, " & _
                "Modelo, Serie, Numero, CodConfig, CodEmitente, NumECF, NumCOO, StatusEmitente) Values('" & strCodOrdem & "'," & _
                "'" & strTipo & "','" & strChave & "','" & strUF & "','" & strEmissao & "','" & strCNPJ & "','" & strModelo & "'," & _
                "'" & strSerie & "','" & strNumero & "','" & strCodConfig & "','" & strCodEmitente & "','" & strNumECF & "'," & _
                "'" & strNumCOO & "','" & strStatusEmitente & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "RefNfe"
        Me.lblTabAtual.Text = "Registro"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********REGISTRO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Registro order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strComputador As String = dt.Rows.Item(I).Item("Computador").ToString


            If bolPassou = False Then
                Query = "INSERT INTO Registro(Computador) Values('" & strComputador & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Registro(Computador) Values('" & strComputador & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "Registro"
        Me.lblTabAtual.Text = "Representante"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********REPRESENTANTE**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Representante order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim dtFor As DataTable = CarregarDataTable("Select Codigo From Fornecedor Where " & _
            "CPF='" & dt.Rows.Item(I).Item("CPFFor").ToString & "'")

            Dim strCodFor As String = "" 'dt.Rows.Item(I).Item("CodFor").ToString
            If dtFor.Rows.Count > 0 Then
                strCodFor = dtFor.Rows.Item(0).Item("Codigo").ToString
            End If

            Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
            Dim strTel1 As String = dt.Rows.Item(I).Item("Tel1").ToString
            Dim strTel2 As String = dt.Rows.Item(I).Item("Tel2").ToString
            Dim strWeb As String = dt.Rows.Item(I).Item("Web").ToString


            If bolPassou = False Then
                Query = "INSERT INTO Representante(CodFor, Nome, Tel1, Tel2, Web) Values('" & strCodFor & "','" & strNome & "'," & _
                "'" & strTel1 & "','" & strTel2 & "','" & strWeb & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Representante(CodFor, Nome, Tel1, Tel2, Web) " & _
                "Values('" & strCodFor & "','" & strNome & "','" & strTel1 & "','" & strTel2 & "','" & strWeb & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "Representante"
        Me.lblTabAtual.Text = "Revisao"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********REVISAO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Revisao order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodigoPedido").ToString
            Dim strPlaca As String = dt.Rows.Item(I).Item("Placa").ToString
            Dim strProduto As String = dt.Rows.Item(I).Item("Produto").ToString
            Dim strRevisao As String = dt.Rows.Item(I).Item("Revisao").ToString
            Dim strUltimoKM As String = dt.Rows.Item(I).Item("UltimoKM").ToString
            Dim strProximoKM As String = dt.Rows.Item(I).Item("ProximoKM").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


            If bolPassou = False Then
                Query = "INSERT INTO Revisao(CodOrdem, Placa, Produto, Revisao, UltimoKM, ProximoKM, CodConfig) " & _
                "Values('" & strCodOrdem & "','" & strPlaca & "','" & strProduto & "','" & strRevisao & "'," & _
                "'" & strUltimoKM & "','" & strProximoKM & "','" & strCodConfig & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Revisao(CodOrdem, Placa, Produto, Revisao, " & _
                "UltimoKM, ProximoKM, CodConfig) Values('" & strCodOrdem & "','" & strPlaca & "','" & strProduto & "'," & _
                "'" & strRevisao & "','" & strUltimoKM & "','" & strProximoKM & "','" & strCodConfig & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "Revisao"
        Me.lblTabAtual.Text = "SATFiscal"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********SATFISCAL**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM SATFiscal order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString


            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
            Dim strChave As String = dt.Rows.Item(I).Item("Chave").ToString
            Dim strNumeroSerie As String = dt.Rows.Item(I).Item("NumeroSerie").ToString
            Dim strNumeroCaixa As String = dt.Rows.Item(I).Item("NumeroCaixa").ToString
            Dim strChaveCancelamento As String = dt.Rows.Item(I).Item("ChaveCancelamento").ToString
            Dim strCNPJ As String = dt.Rows.Item(I).Item("CNPJ").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strNumeroCupom As String = dt.Rows.Item(I).Item("NumeroCupom").ToString
            Dim strNumeroCupomCancelado As String = dt.Rows.Item(I).Item("NumeroCupomCancelado").ToString
            Dim strValorTotal As String = dt.Rows.Item(I).Item("ValorTotal").ToString
            Dim strCFPDest As String = dt.Rows.Item(I).Item("CFPDest").ToString
            Dim strAssinaturaQrCode As String = dt.Rows.Item(I).Item("AssinaturaQrCode").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strCodOrdem2 As String = dt.Rows.Item(I).Item("CodOrdem2").ToString


            If bolPassou = False Then
                Query = "INSERT INTO SATFiscal(CodOrdem, Chave, NumeroSerie, NumeroCaixa, ChaveCancelamento, CNPJ, " & _
                "Data, NumeroCupom, NumeroCupomCancelado, ValorTotal, CFPDest, AssinaturaQrCode, CodConfig, CodOrdem2) " & _
                "Values('" & strCodOrdem & "','" & strChave & "','" & strNumeroSerie & "','" & strNumeroCaixa & "'," & _
                "'" & strChaveCancelamento & "','" & strCNPJ & "','" & strData & "','" & strNumeroCupom & "'," & _
                "'" & strNumeroCupomCancelado & "'," & Num(strValorTotal) & ",'" & strCFPDest & "','" & strAssinaturaQrCode & "'," & _
                "'" & strCodConfig & "','" & strCodOrdem2 & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO SATFiscal(CodOrdem, Chave, NumeroSerie, NumeroCaixa, " & _
                "ChaveCancelamento, CNPJ, Data, NumeroCupom, NumeroCupomCancelado, ValorTotal, CFPDest, AssinaturaQrCode, " & _
                "CodConfig, CodOrdem2) Values('" & strCodOrdem & "','" & strChave & "','" & strNumeroSerie & "','" & strNumeroCaixa & "'," & _
                "'" & strChaveCancelamento & "','" & strCNPJ & "','" & strData & "','" & strNumeroCupom & "'," & _
                "'" & strNumeroCupomCancelado & "'," & Num(strValorTotal) & ",'" & strCFPDest & "','" & strAssinaturaQrCode & "'," & _
                "'" & strCodConfig & "','" & strCodOrdem2 & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "SATFiscal"
        Me.lblTabAtual.Text = "Transferencia"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********TRANSFERENCIA**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Transferencia order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
            Dim strCodLoja As String = dt.Rows.Item(I).Item("CodLoja").ToString

            Dim strCodUserSaida As String = ""
            If dt.Rows.Item(I).Item("CodUserSaida").ToString <> 1 Then
                Dim dtCodUserS As DataTable = CarregarDataTable("Select Codigo From Usuario Where " & _
                            "Skin='" & dt.Rows.Item(I).Item("CodUserSaida").ToString & "'")

                'Dim strCodUserSaida As String = "" 'dt.Rows.Item(I).Item("CodUserSaida").ToString
                If dtCodUserS.Rows.Count > 0 Then
                    strCodUserSaida = dtCodUserS.Rows.Item(0).Item("Codigo").ToString
                End If
            Else
                strCodUserSaida = dt.Rows.Item(I).Item("CodUserSaida").ToString
            End If


            Dim dtCodUserE As DataTable = CarregarDataTable("Select Codigo From Usuario Where " & _
                        "Skin='" & dt.Rows.Item(I).Item("CodUserEntrada").ToString & "'")

            Dim strCodUserEntrada As String = "" 'dt.Rows.Item(I).Item("CodUserEntrada").ToString
            If dtCodUserE.Rows.Count > 0 Then
                strCodUserEntrada = dtCodUserE.Rows.Item(0).Item("Codigo").ToString
            End If


            Dim dtCodProd As DataTable = CarregarDataTable("Select Codigo From Produto Where " & _
                                    "Locacao='" & dt.Rows.Item(I).Item("CodProd").ToString & "'")

            Dim strCodProd As String = "" 'dt.Rows.Item(I).Item("CodProd").ToString
            If dtCodProd.Rows.Count > 0 Then
                strCodProd = dtCodProd.Rows.Item(0).Item("Codigo").ToString
            End If

            Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
            Dim strTamanho As String = "U" 'dt.Rows.Item(I).Item("Tamanho").ToString
            Dim strValorCusto As String = dt.Rows.Item(I).Item("ValorCusto").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
            Dim strEntSai As String = dt.Rows.Item(I).Item("EntSai").ToString
            Dim strLote As String = "U" 'dt.Rows.Item(I).Item("Lote").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strAuxiliar As String = "" 'dt.Rows.Item(I).Item("Auxiliar").ToString


            If bolPassou = False Then
                Query = "INSERT INTO Transferencia(CodOrdem, CodLoja, CodUserSaida, CodProd, CodUserEntrada, " & _
                "Qtd, Tamanho, ValorCusto, Data, Status, EntSai, Lote, CodConfig, Auxiliar) Values('" & strCodOrdem & "'," & _
                "'" & strCodLoja & "','" & strCodUserSaida & "','" & strCodProd & "','" & strCodUserEntrada & "'," & _
                "" & Num(strQtd) & ",'" & strTamanho & "'," & Num(strValorCusto) & ",'" & strData & "','" & strStatus & "'," & _
                "'" & strEntSai & "','" & strLote & "','" & strCodConfig & "','" & strAuxiliar & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Transferencia(CodOrdem, CodLoja, CodUserSaida, CodProd, " & _
                "CodUserEntrada, Qtd, Tamanho, ValorCusto, Data, Status, EntSai, Lote, CodConfig, Auxiliar) Values('" & strCodOrdem & "'," & _
                "'" & strCodLoja & "','" & strCodUserSaida & "','" & strCodProd & "','" & strCodUserEntrada & "'," & Num(strQtd) & "," & _
                "'" & strTamanho & "'," & Num(strValorCusto) & ",'" & strData & "','" & strStatus & "','" & strEntSai & "'," & _
                "'" & strLote & "','" & strCodConfig & "','" & strAuxiliar & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "Transferencia"
        Me.lblTabAtual.Text = "VolumeNfe"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********VOLUMENFE**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM VolumeNfe order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
            Dim strQtde As String = dt.Rows.Item(I).Item("Qtde").ToString
            Dim strEspecie As String = dt.Rows.Item(I).Item("Especie").ToString
            Dim strMarca As String = dt.Rows.Item(I).Item("Marca").ToString
            Dim strNumero As String = dt.Rows.Item(I).Item("Numero").ToString
            Dim strPesoLiq As String = dt.Rows.Item(I).Item("PesoLiq").ToString
            Dim strPesoBruto As String = dt.Rows.Item(I).Item("PesoBruto").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strCodEmitente As String = dt.Rows.Item(I).Item("CodEmitente").ToString
            Dim strStatusEmitente As String = dt.Rows.Item(I).Item("StatusEmitente").ToString


            If bolPassou = False Then
                Query = "INSERT INTO VolumeNfe(CodOrdem, Qtde, Especie, Marca, Numero, PesoLiq, PesoBruto, CodConfig, " & _
                "CodEmitente, StatusEmitente) Values('" & strCodOrdem & "','" & strQtde & "','" & strEspecie & "'," & _
                "'" & strMarca & "','" & strNumero & "','" & strPesoLiq & "','" & strPesoBruto & "','" & strCodConfig & "'," & _
                "'" & strCodEmitente & "','" & strStatusEmitente & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO VolumeNfe(CodOrdem, Qtde, Especie, Marca, Numero, " & _
                "PesoLiq, PesoBruto, CodConfig, CodEmitente, StatusEmitente) Values('" & strCodOrdem & "','" & strQtde & "'," & _
                "'" & strEspecie & "','" & strMarca & "','" & strNumero & "','" & strPesoLiq & "','" & strPesoBruto & "'," & _
                "'" & strCodConfig & "','" & strCodEmitente & "','" & strStatusEmitente & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "VolumeNfe"
        Me.lblTabAtual.Text = "TabelaPreco"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        Inserir("Insert Into Grupo(Nome, Tipo) Values('VALOR2','T');")
        Inserir("Insert Into Grupo(Nome, Tipo) Values('VALOR3','T');")
        '**********TABELAPRECO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Produto order by CodigoAut", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigoAut As Integer = dt.Rows.Item(I).Item("CodigoAut").ToString
            Dim strCodigo As String = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strCusto As String = dt.Rows.Item(I).Item("ValorCusto").ToString

            Dim strPor2 As String = ""
            Dim strPor3 As String = ""
            Dim str As String = ""
            Dim dblLucro, dblValVenda, dblValCusto, dblMargem As Double

            Dim strValor2 As String = dt.Rows.Item(I).Item("Valor2").ToString
            Dim dblVal2 As Double
            If strValor2 = "" Then
                strValor2 = 0
            End If
            dblVal2 = strValor2
            Dim dblVal3 As Double
            Dim strValor3 As String = dt.Rows.Item(I).Item("Valor3").ToString
            If strValor3 = "" Then
                strValor3 = 0
            End If
            dblVal3 = strValor3
            If dblVal2 > 0 Or dblVal3 > 0 Then
                Dim dtCodProd As DataTable = CarregarDataTable("Select Codigo From Produto " & _
                   "Where Locacao='" & strCodigoAut & "'")

                Dim strCodProd As String = "" 'dt.Rows.Item(I).Item("Codigo").ToString
                If dtCodProd.Rows.Count > 0 Then
                    strCodProd = dtCodProd.Rows.Item(0).Item("Codigo").ToString
                End If


                If dblVal2 > 0 Then
                    Dim dtCodTabVal2 As DataTable = CarregarDataTable("Select Codigo From Grupo Where Nome='VALOR2' And Tipo='T'")

                    Dim strCodTabVal2 As String = "" 'dt.Rows.Item(I).Item("Valor2").ToString
                    If dtCodTabVal2.Rows.Count > 0 Then
                        strCodTabVal2 = dtCodTabVal2.Rows.Item(0).Item("Codigo").ToString
                    End If

                    dblValVenda = strValor2
                    dblValCusto = strCusto
                    dblLucro = dblValVenda - dblValCusto

                    dblMargem = (dblLucro * 100) / dblValCusto
                    str = dblMargem

                    If str <> "+Infinito" And str <> "NaN (Não é um número)" Then
                        If TresCasasDecimais = True Then
                            strPor2 = dblMargem.ToString("0.000")
                        Else
                            strPor2 = dblMargem.ToString("0.00")
                        End If
                    Else
                        If TresCasasDecimais = True Then
                            strPor2 = "0,000"
                        Else
                            strPor2 = "0,00"
                        End If
                    End If

                    If bolPassou = False Then
                        Query = "INSERT INTO TabelaPreco(CodProd, CodTabela, Valor, Porcentagem) " & _
                        "Values('" & strCodProd & "','" & strCodTabVal2 & "'," & Num(strValor2) & "," & Num(strPor2) & ");" & vbCrLf

                        count = count + 1
                        bolPassou = True
                    Else
                        Query = Query & vbCrLf & "INSERT INTO TabelaPreco(CodProd, CodTabela, Valor, Porcentagem) " & _
                        "Values('" & strCodProd & "','" & strCodTabVal2 & "'," & Num(strValor2) & "," & Num(strPor2) & ");" & vbCrLf

                        count = count + 1
                    End If

                End If



                If dblVal3 > 0 Then

                    Dim dtCodTabVal3 As DataTable = CarregarDataTable("Select Codigo From Grupo Where Nome='VALOR3' And Tipo='T'")

                    Dim strCodTabVal3 As String = "" 'dt.Rows.Item(I).Item("Valor2").ToString
                    If dtCodTabVal3.Rows.Count > 0 Then
                        strCodTabVal3 = dtCodTabVal3.Rows.Item(0).Item("Codigo").ToString
                    End If

                    dblValVenda = strValor3
                    dblValCusto = strCusto
                    dblLucro = dblValVenda - dblValCusto

                    dblMargem = (dblLucro * 100) / dblValCusto
                    str = dblMargem

                    If str <> "+Infinito" And str <> "NaN (Não é um número)" Then
                        If TresCasasDecimais = True Then
                            strPor3 = dblMargem.ToString("0.000")
                        Else
                            strPor3 = dblMargem.ToString("0.00")
                        End If
                    Else
                        If TresCasasDecimais = True Then
                            strPor3 = "0,000"
                        Else
                            strPor3 = "0,00"
                        End If
                    End If

                    If bolPassou = False Then
                        Query = "INSERT INTO TabelaPreco(CodProd, CodTabela, Valor, Porcentagem) " & _
                        "Values('" & strCodProd & "','" & strCodTabVal3 & "'," & Num(strValor3) & "," & Num(strPor3) & ");"

                        count = count + 1
                        bolPassou = True
                    Else
                        Query = Query & vbCrLf & "INSERT INTO TabelaPreco(CodProd, CodTabela, Valor, Porcentagem) " & _
                        "Values('" & strCodProd & "','" & strCodTabVal3 & "'," & Num(strValor3) & "," & Num(strPor3) & ");"

                        count = count + 1
                    End If


                End If



            End If

            Inserir(Query)
            Query = ""


            'If count = 500 Then
            'Inserir(Query)
            'System.Threading.Thread.Sleep(40)

            'Query = ""
            'count = 0
            'End If


            'If bolPassou = False Then
            '    Query = "INSERT INTO TabelaPreco(CodProd, CodTabela, Valor, Porcentagem) " & _
            '    "Values('" & strCodProd & "','" & strCodTabVal2 & "'," & Num(strValor2) & "," & Num(strPor2) & ");" & _
            '    "" & vbCrLf & "SET DATEFORMAT dmy INSERT INTO TabelaPreco(CodProd, CodTabela, Valor, Porcentagem) " & _
            '    "Values('" & strCodProd & "','" & strCodTabVal3 & "'," & Num(strValor3) & "," & Num(strPor3) & ");"

            '    bolPassou = True
            'Else
            '    Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO TabelaPreco(CodProd, CodTabela, Valor, Porcentagem) " & _
            '    "Values('" & strCodProd & "','" & strCodTabVal2 & "'," & Num(strValor2) & "," & Num(strPor2) & ");" & _
            '    "" & vbCrLf & "SET DATEFORMAT dmy INSERT INTO TabelaPreco(CodProd, CodTabela, Valor, Porcentagem) " & _
            '    "Values('" & strCodProd & "','" & strCodTabVal3 & "'," & Num(strValor3) & "," & Num(strPor3) & ");"

            'End If




            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            'Inserir(Query)
        End If
        strTabela = "TabelaPreco"
        Me.lblTabAtual.Text = "Locacao"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********LOCACAO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Locacao order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
            Dim strLocacao As String = dt.Rows.Item(I).Item("Locacao").ToString
            Dim strQtdMinima As String = dt.Rows.Item(I).Item("QtdMinima").ToString
            Dim strCodConfig As String = dt.Rows.Item(I).Item("CodConfig").ToString


            If bolPassou = False Then
                Query = "INSERT INTO Locacao(CodProd, Locacao, QtdMinima, CodConfig) " & _
                "Values('" & strCodProd & "','" & strLocacao & "'," & Num(strQtdMinima) & ",'" & strCodConfig & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO Locacao(CodProd, Locacao, QtdMinima, CodConfig) " & _
                "Values('" & strCodProd & "','" & strLocacao & "'," & Num(strQtdMinima) & ",'" & strCodConfig & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        Inserir("Update Locacao Set CodProd=case when Produto.Codigo is not null then Produto.Codigo else 0 end " & _
        "From Locacao Left Join Produto on Locacao.CodProd = Produto.Locacao")
        strTabela = "Locacao"
        Me.lblTabAtual.Text = "Agenda"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0



        '**********AGENDATELEFONE**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Agenda order by Codigo", strNomeBanco)
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
            Dim strContato As String = dt.Rows.Item(I).Item("Contato").ToString
            Dim strTel1 As String = dt.Rows.Item(I).Item("Tel1").ToString
            Dim strTel2 As String = dt.Rows.Item(I).Item("Tel2").ToString
            Dim strTel3 As String = dt.Rows.Item(I).Item("Tel3").ToString
            Dim strID As String = dt.Rows.Item(I).Item("ID").ToString
            Dim strEmail As String = dt.Rows.Item(I).Item("Email").ToString
            Dim strGrupo As String = dt.Rows.Item(I).Item("Grupo").ToString


            If bolPassou = False Then
                Query = "INSERT INTO AgendaTelefone(Nome, Contato, Tel1, Tel2, Tel3, ID, Email, Grupo) " & _
                "Values('" & strNome & "','" & strContato & "','" & strTel1 & "','" & strTel2 & "'," & _
                "'" & strTel3 & "','" & strID & "','" & strEmail & "','" & strGrupo & "');"

                bolPassou = True
            Else
                Query = Query & vbCrLf & "SET DATEFORMAT dmy INSERT INTO AgendaTelefone(Nome, Contato, Tel1, Tel2, " & _
                "Tel3, ID, Email, Grupo) Values('" & strNome & "','" & strContato & "','" & strTel1 & "','" & strTel2 & "'," & _
                "'" & strTel3 & "','" & strID & "','" & strEmail & "','" & strGrupo & "');"

            End If

            count = count + 1
            If count = 500 Then
                Inserir(Query)
                System.Threading.Thread.Sleep(40)

                Query = ""
                count = 0
            End If

            B += 1
            LogDeErro()
        Next
        If Query <> "" Then
            Inserir(Query)
        End If
        strTabela = "AgendaTelefone"
        BarraProdgresso()


        Query = ""
        bolPassou = False
        count = 0


        MsgBox("Dados migrados com sucesso!", MsgBoxStyle.Information)
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub MigrarAutomotivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblTabAtual.Text = ""
        Dim dt As DataTable = CarregarDataTable2("SELECT Name FROM SYSDATABASES", "Master")

        Dim I As Integer
        Me.cboBanco.Properties.Items.Clear()
        Me.cboBanco.Properties.Items.Add("")
        For I = 0 To dt.Rows.Count - 1
            Dim strBanco As String = dt.Rows.Item(I).Item("Name").ToString
            Me.cboBanco.Properties.Items.Add(strBanco)
        Next
    End Sub

    Private Sub cboBanco_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBanco.EditValueChanged
        Dim cboStatus1 As DevExpress.XtraEditors.ComboBoxEdit = CType(sender, DevExpress.XtraEditors.ComboBoxEdit)
        strNomeBanco = cboStatus1.Text.ToString

        Dim dt As DataTable = CarregarDataTable2("SELECT Codigo FROM Config order by Codigo", strNomeBanco)

        Dim I As Integer
        Me.ComboBoxEdit1.Properties.Items.Clear()
        For I = 0 To dt.Rows.Count - 1
            Dim strBanco As String = dt.Rows.Item(I).Item("Codigo").ToString
            Me.ComboBoxEdit1.Properties.Items.Add(strBanco)
        Next
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
End Class