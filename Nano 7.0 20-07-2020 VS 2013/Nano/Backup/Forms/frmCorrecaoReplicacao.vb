Imports Nano.clsFuncoes
Public Class frmCorrecaoReplicacao
    Dim intPB As Integer
    Dim intMax As Integer
    Dim strTabela As String
    Public Shared Sub Main()
        Application.Run(New frmMigracao2())
    End Sub
    Private Sub frmCorrecaoReplicacao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As DataTable = CarregarDataTable2("SELECT Name FROM SYSDATABASES", "Master")
        Me.dtFinal.EditValue = Date.Today
        Dim I As Integer
        Me.cboBanco.Properties.Items.Clear()
        For I = 0 To dt.Rows.Count - 1
            Dim strBanco As String = dt.Rows.Item(I).Item("Name").ToString

            Me.cboBanco.Properties.Items.Add(strBanco)
        Next

        dt = CarregarDataTable("SELECT Codigo FROM Config")

        Me.cboLoja.Properties.Items.Clear()
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As String = dt.Rows.Item(I).Item("Codigo").ToString

            Me.cboLoja.Properties.Items.Add(strCodigo)
        Next
    End Sub

    Private Sub btnIniciar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnIniciar.ItemClick
        If MsgBox("Deseja realmente iniciar a correção da replicação?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim strBaseDeDados As String = Me.cboBanco.Text
        If strBaseDeDados = "" Then
            MsgBox("SELECIONE O BANCO!", MsgBoxStyle.Information)
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        If Me.cboLoja.Text = "" Then
            MsgBox("SELECIONE O CODIGO DA LOJA!", MsgBoxStyle.Information)
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        Dim strCodConfig As String = Me.cboLoja.Text
        Dim strCodConfigPublication As String = CodConfig
        Dim dt As DataTable = Nothing
        Dim dt1 As DataTable = Nothing
        Dim dt2 As DataTable = Nothing
        Dim B As Integer
        Dim P As Integer
        Dim I As Integer

        pb.Value = 0

        pb.Maximum = 300
        intMax = 300

        '**********BANCO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Banco where CodConfig = " & strCodConfig & " order by Nome", strBaseDeDados)
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1
            Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
            Dim strSaldo As String = dt.Rows.Item(I).Item("Saldo").ToString
            dt1 = CarregarDataTable("SELECT Codigo FROM Banco where Nome = '" & strNome.Trim & "'")
            If dt1.Rows.Count = 0 Then
                Inserir("Insert into Banco (Nome, Saldo, CodConfig) values('" & strNome & "'," & Num(strSaldo) & "," & strCodConfig & ")")
                LogDeErro()
            End If

            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "Banco"
        BarraProdgresso()


       

        '**********CAIXA**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Caixa where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
        Excluir("DELETE FROM Caixa where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig)
        LogDeErro()
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1

            Dim strMotivo As String = dt.Rows.Item(I).Item("Motivo").ToString
            Dim strCaixa As String = dt.Rows.Item(I).Item("Caixa").ToString
            Dim strCredito As String = dt.Rows.Item(I).Item("Credito").ToString
            Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
            Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strCentroCusto As String = dt.Rows.Item(I).Item("CentroCusto").ToString
            Dim strAuxiliar As String = ""
            Try
                strAuxiliar = dt.Rows.Item(I).Item("Auxiliar").ToString
            Catch ex As Exception

            End Try
            Inserir("INSERT INTO Caixa (Motivo, Caixa, Credito, Pagamento, Valor, Data, CodConfig, " & _
            "CentroCusto, Auxiliar) VALUES ('" & strMotivo & "','" & strCaixa & "','" & strCredito & "'," & _
            "'" & strPagamento & "'," & Num(strValor) & ",'" & strData & "'," & strCodConfig & "," & _
            "'" & strCentroCusto & "','" & strAuxiliar & "')")
            LogDeErro()


            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "Caixa"
        BarraProdgresso()


        '**********PAGAMENTO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Pagamento order by Descricao", strBaseDeDados)
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1
            Dim strDescricao As String = dt.Rows.Item(I).Item("Descricao").ToString
            Dim strDias As String = dt.Rows.Item(I).Item("Dias").ToString
            Dim strDesconto As String = dt.Rows.Item(I).Item("Desconto").ToString
            Dim bolPrazo As Boolean = dt.Rows.Item(I).Item("Prazo").ToString
            Dim strFormaPagamento As String = dt.Rows.Item(I).Item("FormaPagamento").ToString
            Dim strIrCaixa As String = dt.Rows.Item(I).Item("IrCaixa").ToString
            Dim strCodBanco As String = dt.Rows.Item(I).Item("CodBanco").ToString

            dt1 = CarregarDataTable("SELECT Codigo FROM Pagamento where Descricao = '" & strDescricao & "'")
            If dt1.Rows.Count = 0 Then
                If strCodBanco <> "" Then

                    dt1 = CarregarDataTable2("SELECT Nome FROM Banco where Codigo = " & strCodBanco, strBaseDeDados)
                    Dim strNomeBanco As String = ""
                    strCodBanco = "NULL"
                    If dt1.Rows.Count > 0 Then
                        strNomeBanco = dt1.Rows.Item(0).Item("Nome").ToString
                        If strNomeBanco <> "" Then
                            dt1 = CarregarDataTable("SELECT Codigo FROM Banco where Nome = '" & strNomeBanco & "'")
                            If dt1.Rows.Count > 0 Then
                                strCodBanco = dt1.Rows.Item(0).Item("Codigo").ToString
                            End If
                        End If
                    End If
                Else
                    strCodBanco = "NULL"
                End If

                Inserir("Insert into Pagamento (Descricao, Dias, Desconto, Prazo, FormaPagamento, " & _
                "IrCaixa, CodBanco) values('" & strDescricao & "','" & strDias & "','" & strDesconto & "', " & _
                "'" & bolPrazo & "','" & strFormaPagamento & "','" & strIrCaixa & "','" & strCodBanco & "')")
                LogDeErro()
            End If

            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "Pagamento"
        BarraProdgresso()

        '**********CHEQUE**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Cheque where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
        Excluir("DELETE FROM Cheque where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig)
        LogDeErro()
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1
            Dim strCodPed As String = dt.Rows.Item(I).Item("CodPed").ToString
            Dim strCliente As String = dt.Rows.Item(I).Item("Cliente").ToString
            Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
            Dim strVencimento As String = dt.Rows.Item(I).Item("Vencimento").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strDocumento As String = dt.Rows.Item(I).Item("Documento").ToString
            Dim strBanco As String = dt.Rows.Item(I).Item("Banco").ToString
            Dim strQuem As String = dt.Rows.Item(I).Item("Quem").ToString
            Dim bolRecebidoOK As Boolean = dt.Rows.Item(I).Item("RecebidoOK").ToString
            Dim strRecebimento As String = dt.Rows.Item(I).Item("Recebimento").ToString

            Inserir("INSERT INTO Cheque (CodPed, Cliente, Valor, Vencimento, Data, Documento, " & _
            "Banco, Quem, RecebidoOK, Recebimento, CodConfig) VALUES ('" & strCodPed & "'," & _
            "'" & strCliente & "'," & Num(strValor) & ",'" & strVencimento & "','" & strData & "'," & _
            "'" & strDocumento & "','" & strBanco & "','" & strQuem & "','" & bolRecebidoOK & "', " & _
            "'" & strRecebimento & "'," & strCodConfig & ")")
            LogDeErro()

            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "Cheque"
        BarraProdgresso()



        '**********FORNECEDOR**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Fornecedor where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
        Atualizar("UPDATE Fornecedor SET NomePais = ''")
        LogDeErro()
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As String = dt.Rows.Item(I).Item("Codigo").ToString
            Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
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

            Dim strRG As String = dt.Rows.Item(I).Item("IE").ToString

            Dim strContato As String = dt.Rows.Item(I).Item("Contato").ToString
            Dim strSite As String = dt.Rows.Item(I).Item("Site").ToString

            Dim strFant As String = dt.Rows.Item(I).Item("Fantasia").ToString
            Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
            Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString

         
            Dim strTipo As String = dt.Rows.Item(I).Item("Tipo").ToString

            Dim strCodMunicipio As String = dt.Rows.Item(I).Item("CodMunicipio").ToString
         
            dt1 = CarregarDataTable("SELECT Codigo FROM Fornecedor where Codigo = " & strCodigo)
            If dt1.Rows.Count = 0 Then
                Inserir("INSERT INTO Fornecedor (Nome, CPF, Endereco, Numero, Complemento, Bairro, " & _
                "Cep, Cidade, Estado, Telefone, Fax, Celular, Email, Data, IE, Contato, Site, " & _
                "Fantasia, Status, Obs, CodConfig, Tipo, CodMunicipio, CodPais, NomePais) VALUES (" & _
                "'" & strNome & "','" & strCPF & "','" & strEnd & "','" & strNum & "','" & strComp & "'," & _
                "'" & strBairro & "','" & strCep & "','" & strCidade & "','" & strUF & "','" & strTel & "'," & _
                "'" & strFax & "','" & strCel & "','" & strEmail & "','" & strData & "','" & strRG & "'," & _
                "'" & strContato & "','" & strSite & "','" & strFant & "','" & strStatus & "'," & _
                "'" & strObs & "'," & strCodConfig & ",'" & strTipo & "','" & strCodMunicipio & "'," & _
                "'1058','" & strCodigo & "')")
                LogDeErro()
            End If


            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "Fornecedor"
        BarraProdgresso()

        '**********CONTAPAGAR**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM ContaPagar where CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
     
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1

            Dim strCodigo As String = dt.Rows.Item(I).Item("Codigo").ToString
            Dim strCodFor As String = dt.Rows.Item(I).Item("CodFor").ToString

            dt1 = CarregarDataTable("SELECT Codigo FROM Fornecedor where NomePais = '" & strCodFor & "'")
            If dt1.Rows.Count > 0 Then
                strCodFor = dt.Rows.Item(0).Item("Codigo").ToString
            End If
            Dim strTipoConta As String = dt.Rows.Item(I).Item("TipoConta").ToString
            Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
            Dim strFormaPagamento As String = dt.Rows.Item(I).Item("FormaPagamento").ToString
            Dim strParcelas As String = dt.Rows.Item(I).Item("Parcelas").ToString
            Dim strValorParcela As String = dt.Rows.Item(I).Item("ValorParcela").ToString

            Dim strVencimento As String = dt.Rows.Item(I).Item("Vencimento").ToString
            Dim strDataPagamento As String = dt.Rows.Item(I).Item("DataPagamento").ToString
            Dim strValorPago As String = dt.Rows.Item(I).Item("ValorPago").ToString
            Dim strDescricao As String = dt.Rows.Item(I).Item("Descricao").ToString
            Dim bolPagoOk As Boolean = dt.Rows.Item(I).Item("PagoOk").ToString

            Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
            Dim strNumeroDocumento As String = dt.Rows.Item(I).Item("NumeroDocumento").ToString
            Dim strTipoCusto As String = dt.Rows.Item(I).Item("TipoCusto").ToString
            Dim strBanco As String = dt.Rows.Item(I).Item("Banco").ToString
            Dim strCentroCusto As String = dt.Rows.Item(I).Item("CentroCusto").ToString

            dt1 = CarregarDataTable("SELECT Codigo FROM ContaPagar where Codigo = '" & strCodigo & "'")
            If dt1.Rows.Count = 0 Then

                Inserir("Insert into ContaPagar (CodFor, TipoConta, Valor, FormaPagamento, Parcelas, " & _
                "ValorParcela, Vencimento, DataPagamento, ValorPago, Descricao, PagoOK, Pagamento, " & _
                "NumeroDocumento, TipoCusto, Banco, CodConfig, CentroCusto) values('" & strCodFor & "'," & _
                "'" & strTipoConta & "'," & Num(strValor) & ",'" & strFormaPagamento & "','" & strParcelas & "'," & _
                "" & Num(strValorParcela) & ",'" & strVencimento & "','" & strDataPagamento & "'," & _
                "" & Num(strValorPago) & ",'" & strDescricao & "','" & bolPagoOk & "','" & strPagamento & "'," & _
                "'" & strNumeroDocumento & "','" & strTipoCusto & "','" & strBanco & "'," & strCodConfig & "," & _
                "'" & strCentroCusto & "')")
                LogDeErro()
            End If

            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "ContaPagar"
        BarraProdgresso()
        Excluir("DELETE FROM Fornecedor where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and NomePais <> '' and CodConfig = " & strCodConfig)

        '**********MOVIMENTOBANCARIO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM MovimentoBancario where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
        Excluir("DELETE FROM MovimentoBancario where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig)
        LogDeErro()
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1

            Dim strCodBanco As String = dt.Rows.Item(I).Item("CodBanco").ToString
            dt1 = CarregarDataTable2("SELECT Nome FROM Banco where Codigo = " & strCodBanco, strBaseDeDados)
            Dim strNomeBanco As String = ""
            If dt1.Rows.Count > 0 Then
                strNomeBanco = dt1.Rows.Item(0).Item("Nome").ToString
                If strNomeBanco <> "" Then
                    dt1 = CarregarDataTable("SELECT Codigo FROM Banco where Nome = '" & strNomeBanco & "'")
                    If dt1.Rows.Count > 0 Then
                        strCodBanco = dt1.Rows.Item(0).Item("Codigo").ToString
                    End If
                End If
            End If

            Dim strTipoMovimento As String = dt.Rows.Item(I).Item("TipoMovimento").ToString
            Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strObservacao As String = dt.Rows.Item(I).Item("Observacao").ToString

            Inserir("INSERT INTO MovimentoBancario (CodBanco, TipoMovimento, Valor, Data, Observacao, " & _
            "CodConfig) VALUES (" & strCodBanco & ",'" & strTipoMovimento & "'," & Num(strValor) & "," & _
            "'" & strData & "','" & strObservacao & "'," & strCodConfig & ")")
            LogDeErro()

            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "MovimentoBancario"
        BarraProdgresso()


        '**********CLIENTE**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Cliente where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
        Atualizar("UPDATE Cliente SET Suframa = ''")
        LogDeErro()
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As String = dt.Rows.Item(I).Item("Codigo").ToString

            Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString

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
            Dim strNasc As String = dt.Rows.Item(I).Item("Nascimento").ToString

            Dim strSexo As String = dt.Rows.Item(I).Item("Sexo").ToString
            Dim strLimite As String = dt.Rows.Item(I).Item("Limite").ToString
            Dim strEmpresa As String = dt.Rows.Item(I).Item("Empresa").ToString
            Dim strSalario As String = dt.Rows.Item(I).Item("Salario").ToString
            Dim strTelEmp As String = dt.Rows.Item(I).Item("TelEmpresa").ToString
            Dim strCredito As String = dt.Rows.Item(I).Item("Credito").ToString
            Dim strMarca As String = dt.Rows.Item(I).Item("Marcas").ToString

            Dim strP1 As String = dt.Rows.Item(I).Item("Pessoa1").ToString
            Dim strP2 As String = dt.Rows.Item(I).Item("Pessoa2").ToString
            Dim strRG1 As String = dt.Rows.Item(I).Item("RG1").ToString
            Dim strRG2 As String = dt.Rows.Item(I).Item("RG2").ToString
            Dim bolInativo As Boolean = dt.Rows.Item(I).Item("Inativo").ToString

            Dim strTempoTrabalho As String = dt.Rows.Item(I).Item("TempoTrabalho").ToString
            Dim strMoradia As String = dt.Rows.Item(I).Item("Moradia").ToString
            Dim strNomeConjuge As String = dt.Rows.Item(I).Item("NomeConjuge").ToString
            Dim strTelConjuge As String = dt.Rows.Item(I).Item("TelConjuge").ToString
            Dim strSuframa As String = dt.Rows.Item(I).Item("Suframa").ToString
            Dim strCodMunicipio As String = dt.Rows.Item(I).Item("CodMunicipio").ToString
            Dim strCodPais As String = dt.Rows.Item(I).Item("CodPais").ToString
            Dim strNomePais As String = dt.Rows.Item(I).Item("NomePais").ToString

            dt1 = CarregarDataTable("SELECT Codigo FROM Cliente where Codigo = " & strCodigo)
            If dt1.Rows.Count = 0 Then
                Inserir("INSERT INTO Cliente (Nome, RGIE, CPF, Endereco, Telefone, Fax, Celular, " & _
                "Email, Data, Numero, Complemento, Bairro, Cep, Cidade, Estado, Fantasia, Inadimplente, " & _
                "Observacao, Status, Nascimento, Sexo, Limite, Empresa, TelEmpresa, Salario, Credito, " & _
                "Marcas, CodConfig, Pessoa1, Pessoa2, RG1, RG2, Inativo, TempoTrabalho, Moradia, " & _
                "NomeConjuge, TelConjuge, Suframa, CodMunicipio, CodPais, NomePais) VALUES (" & _
                "'" & strNome & "','" & strRG & "','" & strCPF & "','" & strEnd.Replace("'", "´") & "'," & _
                "'" & strTel & "','" & strFax & "','" & strCel & "','" & strEmail & "','" & strData & "'," & _
                "'" & strNum & "','" & strComp & "','" & strBairro & "','" & strCep & "'," & _
                "'" & strCidade & "','" & strUF & "','" & strFant & "','" & bolIna & "','" & strObs & "'," & _
                "'" & strStatus & "','" & strNasc & "','" & strSexo & "','" & strLimite & "','" & strEmpresa & "'," & _
                "'" & strTelEmp & "','" & strSalario & "','" & strCredito & "','" & strMarca & "'," & _
                "" & strCodConfig & ",'" & strP1 & "','" & strP2 & "','" & strRG1 & "','" & strRG2 & "'," & _
                "'" & bolInativo & "','" & strTempoTrabalho & "','" & strMoradia & "','" & strNomeConjuge & "'," & _
                "'" & strTelConjuge & "','" & strCodigo & "','" & strCodMunicipio & "','" & strCodPais & "'," & _
                "'" & strNomePais & "')")
                LogDeErro()
            End If


            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "Cliente"
        BarraProdgresso()


        '**********GRUPO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Grupo order by Nome", strBaseDeDados)
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1
            Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
            Dim strTipo As String = dt.Rows.Item(I).Item("Tipo").ToString
            'Dim strPortaImpressora As String = dt.Rows.Item(I).Item("PortaImpressora").ToString

            dt1 = CarregarDataTable("SELECT Codigo FROM Grupo where Nome = '" & strNome.Trim & "'")
            If dt1.Rows.Count = 0 Then
                Inserir("Insert into Grupo (Nome, Tipo) values('" & strNome & "'," & _
                "'" & strTipo & "')")
                LogDeErro()
            End If

            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "Grupo"
        BarraProdgresso()
        Atualizar("ALTER TABLE Produto ALTER COLUMN NivelComboCodCF VArchar(10)")

        '**********PRODUTO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Produto", strBaseDeDados)

        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As Integer = dt.Rows.Item(I).Item("Codigo").ToString
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

            Dim strCodProdFor As String = dt.Rows.Item(I).Item("CodProdFor").ToString
            Dim bolInativo As Boolean = False
            If dt.Rows.Item(I).Item("Inativo").ToString <> "" Then
                bolInativo = dt.Rows.Item(I).Item("Inativo").ToString

            End If

            dt1 = CarregarDataTable("SELECT Codigo FROM Produto where Codigo = " & strCodigo)
            If dt1.Rows.Count = 0 Then
                Inserir("INSERT INTO Produto (Nome, UnidadeMedida, Valor, ValorCusto, Locacao, CodigoInterno, " & _
                "Porcentagens, Fabricante, Grupo, Obs, Data, CodigoBarra, NivelComboCodCF, Desconto, Setor, " & _
                "Tipo, CodProdFor, Inativo) VALUES ('" & strNome & "','" & strUnidadeMedida & "'," & _
                "" & Num(strValor) & "," & Num(strValorCusto) & ",'" & strLocacao & "','" & strCodigoInterno & "'," & _
                "'" & strPorcentagens & "','" & strFabricante & "','" & strGrupo & "','" & strObs & "'," & _
                "'" & strData & "','" & strCodigoBarra & "','" & strCodigo & "'," & Num(strDesconto) & "," & _
                "'" & strSetor & "','" & strTipo & "','" & strCodProdFor & "','" & bolInativo & "')")
                LogDeErro()
            End If

            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "Produto"
        BarraProdgresso()


        '**********FUNCIONARIO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Funcionario where CodConfig = " & strCodConfig, strBaseDeDados)
        Atualizar("UPDATE Funcionario SET Alergia = ''")
        LogDeErro()
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
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


            dt1 = CarregarDataTable("SELECT Codigo FROM Funcionario where Codigo = " & strCodigo)
            If dt1.Rows.Count = 0 Then
                Inserir("INSERT INTO Funcionario (Nome, CPF, RG, Telefone, Celular, Endereco, Bairro, " & _
                "Cidade, Nascimento, Obs, PorcComissao, Funcao, DataAdmissao, DataDemissao, Email, Ativo, " & _
                "Sangue, Alergia, CEP, UF, Complemento, Num, CodConfig) VALUES ('" & strNome & "'," & _
                "'" & strCPF & "','" & strRG & "','" & strTelefone & "','" & strCelular & "'," & _
                "'" & strEndereco & "','" & strBairro & "','" & strCidade & "','" & strNascimento & "'," & _
                "'" & strObs & "','" & strPorcComissao & "','" & strFuncao & "','" & strDataAdmissao & "'," & _
                "'" & strDataDemissao & "','" & strEmail & "','" & bolAtivo & "','" & strSangue & "'," & _
                "'" & strCodigo & "','" & strCEP & "','" & strUF & "','" & strComplemento & "'," & _
                "'" & strNum & "','" & strCodConfig & "')")
                LogDeErro()
            End If

            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "Funcionario"
        BarraProdgresso()

        '**********DESCARTE**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Descarte where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
        Excluir("DELETE FROM Descarte where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig)
        LogDeErro()
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1

            Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString

            dt1 = CarregarDataTable("SELECT Codigo FROM Produto where NivelComboCodCF = '" & strCodProd & "'")
            If dt1.Rows.Count > 0 Then
                strCodProd = dt1.Rows.Item(0).Item("Codigo").ToString
            End If

            Dim strQtd As String = ""
            Try
                strQtd = dt.Rows.Item(I).Item("Qtd").ToString
            Catch ex As Exception
                strQtd = "0"
            End Try

            Dim strValorUnitario As String = dt.Rows.Item(I).Item("ValorUnitario").ToString
            Dim strMotivo As String = dt.Rows.Item(I).Item("Motivo").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString

            Dim strCodFunc As String = dt.Rows.Item(I).Item("CodFunc").ToString

            dt1 = CarregarDataTable("SELECT Codigo FROM Funcionario where Alergia = '" & strCodFunc & "'")
            If dt1.Rows.Count > 0 Then
                strCodFunc = dt1.Rows.Item(0).Item("Codigo").ToString
            End If


            Dim strTamanho As String = dt.Rows.Item(I).Item("Tamanho").ToString


            Inserir("INSERT INTO Descarte (CodProd, Qtde, ValorUnitario, Motivo, Data, CodFunc, " & _
            "Tamanho, CodConfig) VALUES ('" & strCodProd & "'," & Num(strQtd) & "," & Num(strValorUnitario) & "," & _
            "'" & strMotivo & "','" & strData & "'," & strCodFunc & ",'" & strTamanho & "'," & strCodConfig & ")")
            LogDeErro()

            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "Descarte"
        BarraProdgresso()


        '**********DEVOLUCAO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Devolucao where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
        Excluir("DELETE FROM Devolucao where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig)
        LogDeErro()
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1

            Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString

            dt1 = CarregarDataTable("SELECT Codigo FROM Produto where NivelComboCodCF = '" & strCodProd & "'")
            If dt1.Rows.Count > 0 Then
                strCodProd = dt1.Rows.Item(0).Item("Codigo").ToString
            End If


            Dim strQtde As String = dt.Rows.Item(I).Item("Qtde").ToString
            Dim strCodCli As String = dt.Rows.Item(I).Item("CodCli").ToString

            dt1 = CarregarDataTable("SELECT Codigo FROM Cliente where Suframa = '" & strCodCli & "'")
            If dt1.Rows.Count > 0 Then
                strCodCli = dt1.Rows.Item(0).Item("Codigo").ToString
            End If
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString



            Dim strCodFunc As String = dt.Rows.Item(I).Item("CodFunc").ToString

            dt1 = CarregarDataTable("SELECT Codigo FROM Funcionario where Alergia = '" & strCodFunc & "'")
            If dt1.Rows.Count > 0 Then
                strCodFunc = dt1.Rows.Item(0).Item("Codigo").ToString
            End If


            Dim strMotivo As String = dt.Rows.Item(I).Item("Motivo").ToString

            Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
            Dim strTamanho As String = dt.Rows.Item(I).Item("Tamanho").ToString

            Inserir("INSERT INTO Devolucao (CodProd, Qtde, CodCli, Data, CodFunc, Motivo, " & _
            "Valor, Tamanho, CodConfig) VALUES ('" & strCodProd & "'," & Num(strQtde) & ", " & _
            "" & strCodCli & ",'" & strData & "'," & strCodFunc & ",'" & strMotivo & "'," & _
            "" & Num(strValor) & ",'" & strTamanho & "'," & strCodConfig & ")")
            LogDeErro()

            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "Devolucao"
        BarraProdgresso()

        '**********CONTARECEBER**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM ContaReceber where " & String.Format("Convert(SmallDateTime,DataVenda) >= '{0:dd/MM/yyyy}' AND Convert(SmallDateTime,DataVenda) <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
        Excluir("DELETE FROM ContaReceber where " & String.Format("Convert(SmallDateTime,DataVenda) >= '{0:dd/MM/yyyy}' AND Convert(SmallDateTime,DataVenda) <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig)
        LogDeErro()
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1
            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
            Dim strDataVenda As String = dt.Rows.Item(I).Item("DataVenda").ToString

            Dim strCodCli As String = dt.Rows.Item(I).Item("CodCli").ToString
            dt1 = CarregarDataTable("SELECT Codigo FROM Cliente where Suframa = '" & strCodCli & "'")
            If dt1.Rows.Count > 0 Then
                strCodCli = dt1.Rows.Item(0).Item("Codigo").ToString
            End If
            Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString

            Dim strFormaPagamento As String = dt.Rows.Item(I).Item("FormaPagamento").ToString
            Dim strParcelas As String = dt.Rows.Item(I).Item("Parcelas").ToString
            Dim strValorParcela As String = dt.Rows.Item(I).Item("ValorParcela").ToString
            Dim strVencimento As String = dt.Rows.Item(I).Item("Vencimento").ToString
            Dim strValorVenda As String = dt.Rows.Item(I).Item("ValorVenda").ToString
            Dim strValorRecebido As String = dt.Rows.Item(I).Item("ValorRecebido").ToString
            Dim strRecebimento As String = dt.Rows.Item(I).Item("Recebimento").ToString

            Dim bolRecebidoOK As Boolean = dt.Rows.Item(I).Item("RecebidoOK").ToString

            Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
            Dim strNumeroDocumento As String = dt.Rows.Item(I).Item("NumeroDocumento").ToString
            Dim strTipoCusto As String = dt.Rows.Item(I).Item("TipoCusto").ToString
            Dim strBanco As String = dt.Rows.Item(I).Item("Banco").ToString
            Dim strCodLojaBaixa As String = "NULL"
            If dt.Rows.Item(I).Item("CodLojaBaixa").ToString <> "" Then
                strCodLojaBaixa = dt.Rows.Item(I).Item("CodLojaBaixa").ToString

            End If
            Dim strAuxiliar As String = ""
            Try
                strAuxiliar = dt.Rows.Item(I).Item("Auxiliar").ToString
            Catch ex As Exception

            End Try
            Inserir("INSERT INTO ContaReceber (CodOrdem, DataVenda, CodCli, Obs, FormaPagamento, Parcelas, " & _
            "ValorParcela, Vencimento, ValorVenda, ValorRecebido, Recebimento, RecebidoOK, Pagamento, " & _
            "NumeroDocumento, TipoCusto, Banco, CodConfig, CodLojaBaixa, Auxiliar) VALUES ('" & strCodOrdem & "'," & _
            "'" & strDataVenda & "'," & strCodCli & ",'" & strObs & "','" & strFormaPagamento & "'," & _
            "'" & strParcelas & "'," & Num(strValorParcela) & ",'" & strVencimento & "'," & Num(strValorVenda) & "," & _
            "" & Num(strValorRecebido) & ",'" & strRecebimento & "','" & bolRecebidoOK & "','" & strPagamento & "'," & _
            "'" & strNumeroDocumento & "','" & strTipoCusto & "','" & strBanco & "'," & strCodConfig & "," & _
            "" & strCodLojaBaixa & ",'" & strAuxiliar & "')")
            LogDeErro()

            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "ContaReceber"
        BarraProdgresso()


        dt = CarregarDataTable2("SELECT * FROM ContaReceber where  Recebimento >= '" & dtData.EditValue & "' and CodLojaBaixa = " & strCodConfig & " order by Codigo", strBaseDeDados)

        For I = 0 To dt.Rows.Count - 1
            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
            If strCodOrdem = "8497" Then
                strCodOrdem = "8497"
            End If
            Dim strFormaPagamento As String = dt.Rows.Item(I).Item("FormaPagamento").ToString
            Dim strValorRecebido As String = dt.Rows.Item(I).Item("ValorRecebido").ToString
            Dim strRecebimento As String = dt.Rows.Item(I).Item("Recebimento").ToString
            Dim bolRecebidoOK As Boolean = dt.Rows.Item(I).Item("RecebidoOK").ToString
            Dim strParcelas As String = dt.Rows.Item(I).Item("Parcelas").ToString
            Dim strCodConfigLoja As String = dt.Rows.Item(I).Item("CodConfig").ToString
            Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
            If bolRecebidoOK = True Then
                Atualizar("UPDATE ContaReceber Set FormaPagamento = '" & strFormaPagamento & "', " & _
                         "ValorRecebido = " & Num(strValorRecebido) & ", Recebimento = '" & strRecebimento & "', " & _
                         "RecebidoOK = 'True', Pagamento = '" & strPagamento & "', CodLojaBaixa = 2 where " & _
                         "CodOrdem = " & strCodOrdem & " and Parcelas = '" & strParcelas & "' and CodConfig = " & strCodConfigLoja)

            End If


        Next

        '**********COMANDA**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Comanda where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
        Excluir("DELETE FROM Comanda where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig)
        LogDeErro()
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1

            Dim strCodOrdens As String = dt.Rows.Item(I).Item("CodOrdens").ToString
            Dim strCodComanda As String = dt.Rows.Item(I).Item("CodComanda").ToString
            Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
            dt1 = CarregarDataTable("SELECT Codigo FROM Produto where NivelComboCodCF = '" & strCodProd & "'")
            If dt1.Rows.Count > 0 Then
                strCodProd = dt1.Rows.Item(0).Item("Codigo").ToString
            End If
            Dim strCodProdInterno As String = dt.Rows.Item(I).Item("CodProdInterno").ToString
            Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
            Dim strValorUnitario As String = dt.Rows.Item(I).Item("ValorUnitario").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
            Dim strProduto As String = dt.Rows.Item(I).Item("Produto").ToString
            Dim bolMisto As Boolean = dt.Rows.Item(I).Item("Misto").ToString
            Dim strCodFunc As String = dt.Rows.Item(I).Item("CodFunc").ToString
            dt1 = CarregarDataTable("SELECT Codigo FROM Funcionario where Alergia = '" & strCodFunc & "'")
            If dt1.Rows.Count > 0 Then
                strCodFunc = dt1.Rows.Item(0).Item("Codigo").ToString
            End If
            Dim strCodCli As String = dt.Rows.Item(I).Item("CodCli").ToString
            dt1 = CarregarDataTable("SELECT Codigo FROM Cliente where Suframa = '" & strCodCli & "'")
            If dt1.Rows.Count > 0 Then
                strCodCli = dt1.Rows.Item(0).Item("Codigo").ToString
            End If
            Dim strTipo As String = dt.Rows.Item(I).Item("Tipo").ToString
            Dim strOpcoes As String = dt.Rows.Item(I).Item("Opcoes").ToString
            Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString
            Dim strEntregador As String = dt.Rows.Item(I).Item("Entregador").ToString
            Dim strTroco As String = dt.Rows.Item(I).Item("Troco").ToString
            Dim strTempo As String = dt.Rows.Item(I).Item("Tempo").ToString

            Inserir("INSERT INTO Comanda (CodOrdens, CodComanda, CodProd, CodProdInterno, Qtd, " & _
            "ValorUnitario, Data, Status, Produto, Misto, CodFunc, CodCli, Tipo, Opcoes, Obs, " & _
            "Entregador, Troco, Tempo, CodConfig) VALUES (" & strCodOrdens & ",'" & strCodComanda & "'," & _
            "" & strCodProd & ",'" & strCodProdInterno & "'," & Num(strQtd) & "," & Num(strValorUnitario) & "," & _
            "'" & strData & "','" & strStatus & "','" & strProduto & "','" & bolMisto & "'," & _
            "" & strCodFunc & "," & strCodCli & ",'" & strTipo & "','" & strOpcoes & "','" & strObs & "'," & _
            "'" & strEntregador & "'," & Num(strTroco) & ",'" & strTempo & "'," & strCodConfig & ")")
            LogDeErro()

            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "Comanda"
        BarraProdgresso()


        '**********COMISSAO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Comissao where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
        Excluir("DELETE FROM Comissao where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig)
        LogDeErro()
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1

            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString

            Dim strCodFunc As String = dt.Rows.Item(I).Item("CodFunc").ToString
            dt1 = CarregarDataTable("SELECT Codigo FROM Funcionario where Alergia = '" & strCodFunc & "'")
            If dt1.Rows.Count > 0 Then
                strCodFunc = dt1.Rows.Item(0).Item("Codigo").ToString
            End If

            Dim strFuncionario As String = dt.Rows.Item(I).Item("Funcionario").ToString
            Dim strValorProduto As String = dt.Rows.Item(I).Item("ValorProduto").ToString
            Dim strPorcentagem As String = dt.Rows.Item(I).Item("Porcentagem").ToString
            Dim strValorComissao As String = dt.Rows.Item(I).Item("ValorComissao").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString

            Dim strMotivo As String = dt.Rows.Item(I).Item("Motivo").ToString

            Dim strTipo As String = dt.Rows.Item(I).Item("Tipo").ToString
            Dim strAuxiliar As String = ""
            Try
                strAuxiliar = dt.Rows.Item(I).Item("Auxiliar").ToString
            Catch ex As Exception

            End Try
            Inserir("INSERT INTO Comissao (CodOrdem, CodFunc, Funcionario, ValorProduto, " & _
            "Porcentagem, ValorComissao, Data, Motivo, Tipo, CodConfig, Auxiliar) VALUES (" & strCodOrdem & "," & _
            "" & strCodFunc & ",'" & strFuncionario & "'," & Num(strValorProduto) & "," & _
            "" & Num(strPorcentagem) & "," & Num(strValorComissao) & ",'" & strData & "'," & _
            "'" & strMotivo & "','" & strTipo & "'," & strCodConfig & ",'" & strAuxiliar & "')")
            LogDeErro()

            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "Comissao"
        BarraProdgresso()


        '**********QTDE**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Qtde where CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
        Excluir("DELETE FROM Qtde where CodConfig = " & strCodConfig)
        LogDeErro()
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1

            Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
            dt1 = CarregarDataTable("SELECT Codigo FROM Produto where NivelComboCodCF = '" & strCodProd & "'")
            If dt1.Rows.Count > 0 Then
                strCodProd = dt1.Rows.Item(0).Item("Codigo").ToString
            End If
            Dim strTamanho As String = dt.Rows.Item(I).Item("Tamanho").ToString
            Dim strQtdMinima As String = dt.Rows.Item(I).Item("QtdMinima").ToString
            Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString

            Dim strLote As String = dt.Rows.Item(I).Item("Lote").ToString
            Dim strValorCusto As String = dt.Rows.Item(I).Item("ValorCusto").ToString
            Dim strEmFalta As String = dt.Rows.Item(I).Item("EmFalta").ToString
            Dim bolAcabou As Boolean = dt.Rows.Item(I).Item("Acabou").ToString
            Dim strDataFim As String = dt.Rows.Item(I).Item("DataFim").ToString

            Inserir("INSERT INTO Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, ValorCusto, " & _
            "EmFalta, Acabou, DataFim, CodConfig) VALUES (" & strCodProd & ",'" & strTamanho & "'," & _
            "" & Num(strQtdMinima) & "," & Num(strQtd) & ",'" & strLote & "'," & Num(strValorCusto) & "," & _
            "'" & strEmFalta & "','" & bolAcabou & "','" & strDataFim & "'," & strCodConfig & ")")
            LogDeErro()

            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "Qtde"
        BarraProdgresso()

        '**********AJUSTE**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM AjusteQtde where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
        Excluir("DELETE FROM AjusteQtde where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig)
        LogDeErro()
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1

            Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
            Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strTabela As String = dt.Rows.Item(I).Item("Tabela").ToString
            Dim strCodUser As String = dt.Rows.Item(I).Item("CodUser").ToString

            Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, Data, Tabela, CodUser, CodConfig) VALUES (" & strCodProd & "," & Num(strQtd) & "," & _
            "'" & strData & "','" & strTabela & "'," & strCodUser & "," & strCodConfig & ")")
            LogDeErro()

            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "AjusteQtde"
        BarraProdgresso()

        '**********INVENTARIO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Inventario where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
        Excluir("DELETE FROM Inventario where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig)
        LogDeErro()
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1

            Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
            dt1 = CarregarDataTable("SELECT Codigo FROM Produto where NivelComboCodCF = '" & strCodProd & "'")
            If dt1.Rows.Count > 0 Then
                strCodProd = dt1.Rows.Item(0).Item("Codigo").ToString
            End If

            Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
            Dim strQtdAntiga As String = dt.Rows.Item(I).Item("QtdAntiga").ToString
            Dim strValorCusto As String = dt.Rows.Item(I).Item("ValorCusto").ToString
            Dim strTamanho As String = dt.Rows.Item(I).Item("Tamanho").ToString
            Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString

            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString

            Inserir("INSERT INTO Inventario (CodProd, Qtd, QtdAntiga, ValorCusto, Tamanho, " & _
            "Status, Data, CodConfig) VALUES (" & strCodProd & "," & Num(strQtd) & "," & _
            "" & Num(strQtdAntiga) & "," & Num(strValorCusto) & ",'" & strTamanho & "'," & _
            "'" & strStatus & "','" & strData & "'," & strCodConfig & ")")
            LogDeErro()

            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "Inventario"
        BarraProdgresso()

        Dim A As Integer

        '**********TOTALENTRADANF**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM TotalEntradaNF where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
        Excluir("DELETE FROM TotalEntradaNF where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig)
        LogDeErro()
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1

            Dim strCodigo As String = dt.Rows.Item(I).Item("Codigo").ToString

            Excluir("DELETE FROM EntradaNF where CodTotNF = " & strCodigo & " and CodConfig = " & strCodConfig)

            Dim strNumeroNF As String = dt.Rows.Item(I).Item("NumeroNF").ToString
            Dim strCodFor As String = dt.Rows.Item(I).Item("CodFor").ToString
            dt1 = CarregarDataTable("SELECT Codigo FROM Fornecedor where NomePais = '" & strCodFor & "'")
            If dt1.Rows.Count > 0 Then
                strCodFor = dt1.Rows.Item(0).Item("Codigo").ToString
            End If
            Dim strTotal As String = dt.Rows.Item(I).Item("Total").ToString
            Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim bolEstoqueOK As Boolean = dt.Rows.Item(I).Item("EstoqueOK").ToString
            Dim strLote As String = dt.Rows.Item(I).Item("Lote").ToString
            Dim strDesconto As String = dt.Rows.Item(I).Item("Desconto").ToString
            Dim strTipo As String = dt.Rows.Item(I).Item("Tipo").ToString
            Dim strSerie As String = dt.Rows.Item(I).Item("Serie").ToString
            Dim strValorFrete As String = dt.Rows.Item(I).Item("ValorFrete").ToString
            Dim strValorSeguro As String = dt.Rows.Item(I).Item("ValorSeguro").ToString
            Dim strOutrasDespesas As String = dt.Rows.Item(I).Item("OutrasDespesas").ToString
            Dim strICMS As String = dt.Rows.Item(I).Item("ICMS").ToString
            Dim strIPI As String = dt.Rows.Item(I).Item("IPI").ToString

            If strCodFor = "2732171" Then
                Inserir("INSERT INTO Fornecedor(Nome,Tipo,CodConfig)values('UNICOS FASHION','F',2)")
                Dim dtf As DataTable = CarregarDataTable("SELECT Codigo FROM Fornecedor where Nome = 'UNICOS FASHION'")
                If dtf.Rows.Count > 0 Then
                    strCodFor = dtf.Rows.Item(0).Item("Codigo").ToString
                    Inserir("INSERT INTO TotalEntradaNF (NumeroNF, CodFor, Total, Obs, Data, EstoqueOK, " & _
                "Lote, Desconto, Tipo, Serie, ValorFrete, ValorSeguro, OutrasDespesas, ICMS, IPI, " & _
                "CodConfig) VALUES ('" & strNumeroNF & "'," & strCodFor & "," & Num(strTotal) & ",'" & strObs & "'," & _
                "'" & strData & "','" & bolEstoqueOK & "','" & strLote & "','" & strDesconto & "'," & _
                "'" & strTipo & "','" & strSerie & "','" & strValorFrete & "','" & strValorSeguro & "'," & _
                "'" & strOutrasDespesas & "','" & strICMS & "','" & strIPI & "'," & strCodConfig & ")")
                End If
            Else
                Inserir("INSERT INTO TotalEntradaNF (NumeroNF, CodFor, Total, Obs, Data, EstoqueOK, " & _
                "Lote, Desconto, Tipo, Serie, ValorFrete, ValorSeguro, OutrasDespesas, ICMS, IPI, " & _
                "CodConfig) VALUES ('" & strNumeroNF & "'," & strCodFor & "," & Num(strTotal) & ",'" & strObs & "'," & _
                "'" & strData & "','" & bolEstoqueOK & "','" & strLote & "','" & strDesconto & "'," & _
                "'" & strTipo & "','" & strSerie & "','" & strValorFrete & "','" & strValorSeguro & "'," & _
                "'" & strOutrasDespesas & "','" & strICMS & "','" & strIPI & "'," & strCodConfig & ")")
            End If
            'Inserir("INSERT INTO TotalEntradaNF (NumeroNF, CodFor, Total, Obs, Data, EstoqueOK, " & _
            '"Lote, Desconto, Tipo, Serie, ValorFrete, ValorSeguro, OutrasDespesas, ICMS, IPI, " & _
            '"CodConfig) VALUES ('" & strNumeroNF & "'," & strCodFor & "," & Num(strTotal) & ",'" & strObs & "'," & _
            '"'" & strData & "','" & bolEstoqueOK & "','" & strLote & "','" & strDesconto & "'," & _
            '"'" & strTipo & "','" & strSerie & "','" & strValorFrete & "','" & strValorSeguro & "'," & _
            '"'" & strOutrasDespesas & "','" & strICMS & "','" & strIPI & "'," & strCodConfig & ")")
            LogDeErro()

            dt1 = CarregarDataTable("SELECT Codigo FROM TotalEntradaNF where NumeroNF = '" & strNumeroNF & "' and " & _
            "CodFor = " & strCodFor & " and CodConfig = " & strCodConfig)

            Dim strCodTotNf As String = dt1.Rows.Item(0).Item("Codigo").ToString


            dt1 = CarregarDataTable2("SELECT * FROM EntradaNF where CodTotNF = " & strCodigo & " and " & _
            "CodConfig = " & strCodConfig, strBaseDeDados)


            For A = 0 To dt1.Rows.Count - 1
                Dim strCodProd As String = dt1.Rows.Item(A).Item("CodProd").ToString
                dt2 = CarregarDataTable("SELECT Codigo FROM Produto where NivelComboCodCF = '" & strCodProd & "'")
                If dt2.Rows.Count > 0 Then
                    strCodProd = dt2.Rows.Item(0).Item("Codigo").ToString
                End If
                Dim strTamanho As String = dt1.Rows.Item(A).Item("Tamanho").ToString
                Dim strQtd As String = dt1.Rows.Item(A).Item("Qtd").ToString
                Dim strValorUnitario As String = dt1.Rows.Item(A).Item("ValorUnitario").ToString
                Dim strValorTotal As String = dt1.Rows.Item(A).Item("ValorTotal").ToString
                Dim strProduto As String = dt1.Rows.Item(A).Item("Produto").ToString
                Dim strCodProdIntero As String = dt1.Rows.Item(A).Item("CodProdInterno").ToString
                Dim strEntradaICMS As String = dt1.Rows.Item(A).Item("ICMS").ToString
                Dim strEntradaDesconto As String = dt1.Rows.Item(A).Item("Desconto").ToString
                Dim strEntradaIPI As String = dt1.Rows.Item(A).Item("IPI").ToString
                Dim strUnitarioImposto As String = dt1.Rows.Item(A).Item("UnitarioImposto").ToString
                Dim strUM As String = dt1.Rows.Item(A).Item("UM").ToString
                Dim strValProd As String = dt1.Rows.Item(A).Item("ValProd").ToString
                Dim strPorProd As String = dt1.Rows.Item(A).Item("PorProd").ToString
                Dim strSetor As String = dt1.Rows.Item(A).Item("Setor").ToString
                Dim strGrupo As String = dt1.Rows.Item(A).Item("Grupo").ToString
                Dim strMVaST As String = dt1.Rows.Item(A).Item("MVaST").ToString
                Dim strPorICMS As String = dt1.Rows.Item(A).Item("PorICMS").ToString
                Dim strTipoProduto As String = dt1.Rows.Item(A).Item("TipoProduto").ToString

                Dim strUMProd As String = dt1.Rows.Item(A).Item("UMProd").ToString
                Dim strQtdProd As String = dt1.Rows.Item(A).Item("QtdProd").ToString
                Dim strCodProdFor As String = dt1.Rows.Item(A).Item("CodProdFor").ToString
                Dim strValorCusto As String = dt1.Rows.Item(A).Item("ValorCusto").ToString


                Inserir("INSERT INTO EntradaNF (CodTotNF, CodProd, Tamanho, Qtd, ValorUnitario, " & _
                "ValorTotal, Produto, CodProdInterno, ICMS, Desconto, IPI, UnitarioImposto, UM, ValProd, " & _
                "PorProd, Setor, Grupo, MVaST, PorICMS, TipoProduto, CodConfig, UMProd, QtdProd, CodProdFor, " & _
                "ValorCusto) VALUES (" & strCodTotNf & "," & _
                "" & strCodProd & ",'" & strTamanho & "'," & Num(strQtd) & "," & Num(strValorUnitario) & "," & _
                "" & Num(strValorTotal) & ",'" & strProduto & "','" & strCodProdIntero & "'," & _
                "'" & strEntradaICMS & "','" & strEntradaDesconto & "','" & strEntradaIPI & "'," & _
                "" & Num(strUnitarioImposto) & ",'" & strUM & "'," & Num(strValProd) & "," & Num(strPorProd) & "," & _
                "'" & strSetor & "','" & strGrupo & "','" & strMVaST & "','" & strPorICMS & "'," & _
                "'" & strTipoProduto & "'," & strCodConfig & ",'" & strUMProd & "'," & Num(strQtdProd) & ",'" & strCodProdFor & "'," & _
                "" & Num(strValorCusto) & ")")
                LogDeErro()
            Next


            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "TotalEntradaNF, EntradaNF"
        BarraProdgresso()


        '**********USUARIO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Usuario where CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As String = dt.Rows.Item(I).Item("Codigo").ToString
            Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString
            Dim strLogin As String = dt.Rows.Item(I).Item("Login").ToString
            Dim strNivel As String = dt.Rows.Item(I).Item("Nivel").ToString
            Dim strSenha As String = dt.Rows.Item(I).Item("Senha").ToString
            Dim strPrincipal As String = dt.Rows.Item(I).Item("Principal").ToString
            Dim strConsultas As String = dt.Rows.Item(I).Item("Consultas").ToString
            Dim strRelatorios As String = dt.Rows.Item(I).Item("Relatorios").ToString
            Dim strSkin As String = dt.Rows.Item(I).Item("Skin").ToString

            dt1 = CarregarDataTable("SELECT Codigo FROM Usuario where Codigo = " & strCodigo)
            If dt1.Rows.Count = 0 Then
                Inserir("Insert into Usuario (Nome, Login, Nivel, Senha, Principal, Consultas, " & _
                "Relatorios, Skin, FundoPadrao, Exibicao, CodConfig) values('" & strNome & "'," & _
                "'" & strLogin & "','" & strNivel & "','" & strSenha & "','" & strPrincipal & "'," & _
                "'" & strCodigo & "','" & strRelatorios & "','" & strSkin & "','True','0'," & strCodConfig & ")")
                LogDeErro()
            End If

            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "Usuario"
        BarraProdgresso()


        '**********LOG**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Log where " & String.Format("Convert(SmallDateTime, Data) >= '{0:dd/MM/yyyy}' AND Convert(SmallDateTime, Data) <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
        Excluir("DELETE FROM Inventario where " & String.Format("Convert(SmallDateTime, Data) >= '{0:dd/MM/yyyy}' AND Convert(SmallDateTime, Data) <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig)
        LogDeErro()
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1

            Dim strCodUser As String = dt.Rows.Item(I).Item("CodUser").ToString
            dt1 = CarregarDataTable("SELECT Codigo FROM Usuario where Consultas = '" & strCodUser & "'")
            If dt1.Rows.Count > 0 Then
                strCodUser = dt1.Rows.Item(0).Item("Codigo").ToString
            End If

            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strAntigo As String = dt.Rows.Item(I).Item("Antigo").ToString
            Dim strNovo As String = dt.Rows.Item(I).Item("Novo").ToString
            Dim strColuna As String = dt.Rows.Item(I).Item("Coluna").ToString
            Dim strTabela As String = dt.Rows.Item(I).Item("Tabela").ToString

            Dim strMotivo As String = dt.Rows.Item(I).Item("Motivo").ToString

            Inserir("INSERT INTO Log (CodUser, Data, Antigo, Novo, Coluna, Tabela, Motivo, " & _
            "CodConfig) VALUES (" & strCodUser & ",'" & strData & "','" & strAntigo & "'," & _
            "'" & strNovo & "','" & strColuna & "','" & strTabela & "','" & strMotivo & "'," & _
            "" & strCodConfig & ")")
            LogDeErro()

            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "Log"
        BarraProdgresso()


        '**********TRANSFERENCIA**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Transferencia where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
        Excluir("DELETE FROM Transferencia where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig)
        LogDeErro()
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1
            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
            Dim strCodLoja As String = dt.Rows.Item(I).Item("CodLoja").ToString

            Dim strCodUserSaida As String = dt.Rows.Item(I).Item("CodUserSaida").ToString
            dt1 = CarregarDataTable("SELECT Codigo FROM Usuario where Consultas = '" & strCodUserSaida & "'")
            If dt1.Rows.Count > 0 Then
                strCodUserSaida = dt1.Rows.Item(0).Item("Codigo").ToString
            End If


            Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
            dt1 = CarregarDataTable("SELECT Codigo FROM Produto where NivelComboCodCF = '" & strCodProd & "'")
            If dt1.Rows.Count > 0 Then
                strCodProd = dt1.Rows.Item(0).Item("Codigo").ToString
            End If

            Dim strCodUserEntrada As String = dt.Rows.Item(I).Item("CodUserEntrada").ToString
            dt1 = CarregarDataTable("SELECT Codigo FROM Usuario where Consultas = '" & strCodUserEntrada & "'")
            If dt1.Rows.Count > 0 Then
                strCodUserEntrada = dt1.Rows.Item(0).Item("Codigo").ToString
            End If
            Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
            Dim strTamanho As String = dt.Rows.Item(I).Item("Tamanho").ToString
            Dim strValorCusto As String = dt.Rows.Item(I).Item("ValorCusto").ToString

            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
            Dim strEntSai As String = dt.Rows.Item(I).Item("EntSai").ToString
            Dim strLote As String = dt.Rows.Item(I).Item("Lote").ToString


            Inserir("INSERT INTO Transferencia (CodOrdem, CodLoja, CodUserSaida, CodProd, CodUserEntrada, " & _
            "Qtd, Tamanho, ValorCusto, Data, Status, EntSai, Lote, CodConfig) VALUES (" & strCodOrdem & "," & _
            "" & strCodLoja & "," & strCodUserSaida & "," & strCodProd & "," & strCodUserEntrada & "," & _
            "" & Num(strQtd) & ",'" & strTamanho & "'," & Num(strValorCusto) & ",'" & strData & "'," & _
            "'" & strStatus & "','" & strEntSai & "','" & strLote & "'," & strCodConfig & ")")

            LogDeErro()
            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "Transferencia, OrdemTrans"
        BarraProdgresso()

        '**********ORDEMTRANS**********
        dt = CarregarDataTable("SELECT MAX(CodOrdem) as CodOrdem FROM Transferencia where CodConfig = " & strCodConfig)
        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item("CodOrdem").ToString <> "" Then
                Inserir("INSERT INTO OrdemTrans (Codigo, CodConfig) VALUES (" & dt.Rows.Item(0).Item("CodOrdem") & "," & strCodConfig & ")")
                LogDeErro()
            End If
        End If

        '**********TOTALCONSIG**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM TotalConsig where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
        Excluir("DELETE FROM TotalConsig where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig)
        LogDeErro()
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1

            Dim strCodOrdens As String = dt.Rows.Item(I).Item("CodOrdens").ToString

            Excluir("DELETE FROM ItensConsig where CodOrdens = " & strCodOrdens & " and CodConfig = " & strCodConfig)
            LogDeErro()
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strCodCli As String = dt.Rows.Item(I).Item("CodCli").ToString
            dt1 = CarregarDataTable("SELECT Codigo FROM Cliente where Suframa = '" & strCodCli & "'")
            If dt1.Rows.Count > 0 Then
                strCodCli = dt1.Rows.Item(0).Item("Codigo").ToString
            End If
            Dim strTotal As String = dt.Rows.Item(I).Item("Total").ToString
            Dim strDescricao As String = dt.Rows.Item(I).Item("Descricao").ToString
            Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString
            Dim strCusto As String = dt.Rows.Item(I).Item("Custo").ToString
            Dim strDesconto As String = dt.Rows.Item(I).Item("Desconto").ToString
            Dim strEntrega As String = dt.Rows.Item(I).Item("Entrega").ToString
            Dim strCodFunc As String = dt.Rows.Item(I).Item("CodFunc").ToString
            dt1 = CarregarDataTable("SELECT Codigo FROM Funcionario where Alergia = '" & strCodFunc & "'")
            If dt1.Rows.Count > 0 Then
                strCodFunc = dt1.Rows.Item(0).Item("Codigo").ToString
            End If


            Inserir("INSERT INTO TotalConsig (CodOrdens, Data, CodCli, Total, Descricao, Status, " & _
            "Custo, Desconto, Entrega, CodFunc, CodConfig) VALUES (" & strCodOrdens & ",'" & strData & "'," & _
            "" & strCodCli & "," & Num(strTotal) & ",'" & strDescricao & "','" & strStatus & "'," & _
            "" & Num(strCusto) & ",'" & strDesconto & "','" & strEntrega & "'," & strCodFunc & "," & _
            "" & strCodConfig & ")")
            LogDeErro()

            dt1 = CarregarDataTable2("SELECT * FROM ItensConsig where CodOrdens = " & strCodOrdens & " and " & _
            "CodConfig = " & strCodConfig, strBaseDeDados)

            For A = 0 To dt1.Rows.Count - 1
                Dim strCodigoProduto As String = dt1.Rows.Item(A).Item("CodigoProduto").ToString
                dt2 = CarregarDataTable("SELECT Codigo FROM Produto where NivelComboCodCF = '" & strCodigoProduto & "'")
                If dt2.Rows.Count > 0 Then
                    strCodigoProduto = dt2.Rows.Item(0).Item("Codigo").ToString
                End If
                Dim strQtd As String = dt1.Rows.Item(A).Item("Qtd").ToString
                Dim strProduto As String = dt1.Rows.Item(A).Item("Produto").ToString
                Dim strValorUnitario As String = dt1.Rows.Item(A).Item("ValorUnitario").ToString
                Dim strValorTotal As String = dt1.Rows.Item(A).Item("ValorTotal").ToString
                Dim strCodigoInterno As String = dt1.Rows.Item(A).Item("CodigoInterno").ToString
                Dim strItensCusto As String = dt1.Rows.Item(A).Item("Custo").ToString
                Dim strUM As String = dt1.Rows.Item(A).Item("UM").ToString
                Dim strTamanho As String = dt1.Rows.Item(A).Item("Tamanho").ToString


                Inserir("INSERT INTO ItensConsig (CodOrdens, CodigoProduto, Qtd, ValorUnitario, " & _
                "ValorTotal, Produto, CodigoInterno, Custo, UM, Tamanho, CodConfig) VALUES (" & strCodOrdens & "," & _
                "" & strCodigoProduto & "," & Num(strQtd) & "," & Num(strValorUnitario) & "," & _
                "" & Num(strValorTotal) & ",'" & strProduto & "','" & strCodigoInterno & "'," & _
                "" & Num(strCusto) & ",'" & strUM & "','" & strTamanho & "'," & strCodConfig & ")")
                LogDeErro()
            Next


            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "TotalConsig, ItensConsig, Ordens"
        BarraProdgresso()

        '**********ORDENS TOTAL CONSIG**********
        dt = CarregarDataTable("SELECT MAX(CodOrdens) as CodOrdens FROM TotalConsig where CodConfig = " & strCodConfig)

        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item("CodOrdens").ToString <> "" Then
                Inserir("INSERT INTO Ordens (Cod, Tabela, CodConfig) VALUES (" & dt.Rows.Item(0).Item("CodOrdens") & "," & _
                "'TotalConsig'," & strCodConfig & ")")

                LogDeErro()
            End If
        End If



        '**********TOTAL**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Total where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
        Excluir("DELETE FROM Total where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig)
        LogDeErro()
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1

            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString

            Excluir("DELETE FROM Pedido where CodOrdem = " & strCodOrdem & " and CodConfig = " & strCodConfig)
            LogDeErro()
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strCodCli As String = dt.Rows.Item(I).Item("CodCli").ToString
            dt1 = CarregarDataTable("SELECT Codigo FROM Cliente where Suframa = '" & strCodCli & "'")
            If dt1.Rows.Count > 0 Then
                strCodCli = dt1.Rows.Item(0).Item("Codigo").ToString
            End If
            Dim strTotal As String = dt.Rows.Item(I).Item("Total").ToString
            Dim strRecebido As String = dt.Rows.Item(I).Item("Recebido").ToString
            Dim strTroco As String = dt.Rows.Item(I).Item("Troco").ToString
            Dim strPorDesc As String = dt.Rows.Item(I).Item("PorDesc").ToString
            Dim strValDesc As String = dt.Rows.Item(I).Item("ValDesc").ToString
            Dim strPorAcre As String = dt.Rows.Item(I).Item("PorAcre").ToString
            Dim strValAcre As String = dt.Rows.Item(I).Item("ValAcre").ToString
            Dim strCusto As String = dt.Rows.Item(I).Item("Custo").ToString
            Dim strHora As String = dt.Rows.Item(I).Item("Hora").ToString
            Dim strStatusDav As String = dt.Rows.Item(I).Item("StatusDav").ToString
            Dim strNumDav As String = dt.Rows.Item(I).Item("NumDav").ToString
            Dim bolNFP As Boolean = dt.Rows.Item(I).Item("NFP").ToString
            Dim strCPFCliente As String = dt.Rows.Item(I).Item("CPFCliente").ToString
            Dim strAuxiliar As String = ""
            Try
                strAuxiliar = dt.Rows.Item(I).Item("Auxiliar").ToString
            Catch ex As Exception

            End Try
            Inserir("INSERT INTO Total (CodOrdem, Data, CodCli, Total, Recebido, Troco, PorDesc, ValDesc, " & _
            "PorAcre, ValAcre, Custo, Hora, StatusDav, NumDav, NFP, CPFCliente, CodConfig, Auxiliar) VALUES (" & _
            "" & strCodOrdem & ",'" & strData & "'," & strCodCli & "," & Num(strTotal) & "," & _
            "" & Num(strRecebido) & "," & Num(strTroco) & "," & Num(strPorDesc) & "," & Num(strValDesc) & "," & _
            "" & Num(strPorAcre) & "," & Num(strValAcre) & "," & Num(strCusto) & ",'" & strHora & "'," & _
            "'" & strStatusDav & "','" & strNumDav & "','" & bolNFP & "','" & strCPFCliente & "'," & strCodConfig & ",'" & strAuxiliar & "')")
            LogDeErro()

            dt1 = CarregarDataTable2("SELECT * FROM Pedido where CodOrdem = " & strCodOrdem & " and " & _
            "CodConfig = " & strCodConfig, strBaseDeDados)

            For A = 0 To dt1.Rows.Count - 1
                Dim strCodigoPedido As String = dt1.Rows.Item(A).Item("Codigo").ToString
                Dim strCodProd As String = dt1.Rows.Item(A).Item("CodProd").ToString
                dt2 = CarregarDataTable("SELECT Codigo FROM Produto where NivelComboCodCF = '" & strCodProd & "'")
                If dt2.Rows.Count > 0 Then
                    strCodProd = dt2.Rows.Item(0).Item("Codigo").ToString
                End If
                Dim strQtd As String = dt1.Rows.Item(A).Item("Qtd").ToString
                Dim strProduto As String = dt1.Rows.Item(A).Item("Produto").ToString
                Dim strValorUnitario As String = dt1.Rows.Item(A).Item("ValorUnitario").ToString
                Dim strValorTotal As String = dt1.Rows.Item(A).Item("ValorTotal").ToString
                Dim strCodigoInterno As String = dt1.Rows.Item(A).Item("CodProdInterno").ToString
                Dim strCodFunc As String = dt1.Rows.Item(A).Item("CodFunc").ToString
                dt2 = CarregarDataTable("SELECT Codigo FROM Funcionario where Alergia = '" & strCodFunc & "'")
                If dt2.Rows.Count > 0 Then
                    strCodFunc = dt2.Rows.Item(0).Item("Codigo").ToString
                End If

                Dim strItensCusto As String = dt1.Rows.Item(A).Item("Custo").ToString
                Dim strTamanho As String = dt1.Rows.Item(A).Item("Tamanho").ToString
                Dim strUM As String = dt1.Rows.Item(A).Item("UM").ToString

                Dim bolDevolvido As Boolean = dt1.Rows.Item(A).Item("Devolvido").ToString
                Dim strLote As String = dt1.Rows.Item(A).Item("Lote").ToString
                Dim strTipoItens As String = dt1.Rows.Item(A).Item("TipoItens").ToString
                Dim strAuxiliar2 As String = ""
                Try
                    strAuxiliar2 = dt1.Rows.Item(A).Item("Auxiliar").ToString
                Catch ex As Exception

                End Try
                Inserir("INSERT INTO Pedido (CodOrdem, CodProd, Qtd, ValorUnitario, ValorTotal, " & _
                "Produto, CodProdInterno, CodFunc, Custo, UM, Tamanho, Devolvido, Lote, TipoItens, " & _
                "CodConfig, Auxiliar) VALUES (" & strCodOrdem & "," & strCodProd & "," & Num(strQtd) & "," & _
                "" & Num(strValorUnitario) & "," & Num(strValorTotal) & ",'" & strProduto & "'," & _
                "'" & strCodigoInterno & "'," & strCodFunc & "," & Num(strItensCusto) & "," & _
                "'" & strUM & "','" & strTamanho & "','" & bolDevolvido & "','" & strLote & "'," & _
                "'" & strTipoItens & "'," & strCodConfig & ",'" & strAuxiliar2 & "')")
                LogDeErro()
            Next

            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "Total, Pedido"
        BarraProdgresso()



        '**********RECEBIMENTO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Recebimento where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
        Excluir("DELETE FROM Recebimento where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig)
        LogDeErro()
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1

            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString


            Dim strFormaPagamento As String = dt.Rows.Item(I).Item("FormaPagamento").ToString
            Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
            Dim strDocumento As String = dt.Rows.Item(I).Item("Documento").ToString
            Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString
            Dim strAuxiliar As String = ""
            Try
                strAuxiliar = dt.Rows.Item(I).Item("Auxiliar").ToString
            Catch ex As Exception

            End Try
            Inserir("INSERT INTO Recebimento (CodOrdem, FormaPagamento, Pagamento, Documento, Valor, " & _
            "Data, Obs, CodConfig, Auxiliar) VALUES (" & strCodOrdem & ",'" & strFormaPagamento & "'," & _
            "'" & strPagamento & "','" & strDocumento & "'," & Num(strValor) & ",'" & strData & "'," & _
            "'" & strObs & "'," & strCodConfig & ",'" & strAuxiliar & "')")
            LogDeErro()

            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "Recebimento"
        BarraProdgresso()


        '**********FUTURO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM Futuro where " & String.Format("Data >= '{0:dd/MM/yyyy}'", dtData.EditValue) & " and CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
        Excluir("DELETE FROM Futuro where " & String.Format("Data >= '{0:dd/MM/yyyy}'", dtData.EditValue) & " and CodConfig = " & strCodConfig)
        LogDeErro()
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1

            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
            Dim strTotal As String = dt.Rows.Item(I).Item("Total").ToString

            Dim strTotalDesconto As String = dt.Rows.Item(I).Item("TotalDesconto").ToString
            Dim bolRecebido As Boolean = False
            If dt.Rows.Item(I).Item("Recebido").ToString <> "" Then
                bolRecebido = dt.Rows.Item(I).Item("Recebido").ToString

            End If
            Dim strAuxiliar As String = ""
            Try
                strAuxiliar = dt.Rows.Item(I).Item("Auxiliar").ToString()
            Catch ex As Exception

            End Try
            Inserir("INSERT INTO Futuro (CodOrdem, Data, Pagamento, Total, TotalDesconto, " & _
            "Recebido, CodConfig, Auxiliar) VALUES (" & strCodOrdem & ",'" & strData & "'," & _
            "'" & strPagamento & "'," & Num(strTotal) & "," & Num(strTotalDesconto) & "," & _
            "'" & bolRecebido & "'," & strCodConfig & ",'" & strAuxiliar & "')")

            LogDeErro()
            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "Futuro, Ordem"
        BarraProdgresso()

        '**********ORDEM**********
        dt = CarregarDataTable("SELECT MAX(CodOrdem) as CodOrdem FROM Total where CodConfig = " & strCodConfig & " group by Auxiliar")
        Inserir("INSERT INTO Ordem (Codigo, CodConfig, Auxiliar) VALUES (" & dt.Rows.Item(0).Item("CodOrdem") & "," & strCodConfig & ",'')")

        LogDeErro()

        If Me.rgpNfe.SelectedIndex = 0 Then
            '**********NFE**********
            B = 1
            dt = CarregarDataTable2("SELECT * FROM Nfe order by Codigo", strBaseDeDados)
            Excluir("DELETE FROM Nfe")
            LogDeErro()
            P = 10
            pb1.Value = 0
            intPB = dt.Rows.Count / 10
            pb1.Maximum = intPB
            For I = 0 To dt.Rows.Count - 1

                Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
                dt1 = CarregarDataTable("SELECT Codigo FROM Produto where NivelComboCodCF = '" & strCodProd & "'")
                If dt1.Rows.Count > 0 Then
                    strCodProd = dt1.Rows.Item(0).Item("Codigo").ToString
                End If
                If strCodProd <> "" Then


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

                    Inserir("INSERT INTO Nfe (CodProd, EXTIPI, Genero, UnidTrib, ValTrib, QtdTrib, MIPI, QtdN, " & _
                    "CST, Origem, ModBC, ICMS, RedBC, ModBCST, RedBCST, MVaST, ICMSST, NCM, Regime, CalculoCred, " & _
                    "UnidCom, ValCom, CFOP) VALUES (" & strCodProd & ",'" & strEXTIPI & "','" & strGenero & "'," & _
                    "'" & strUnidTrib & "','" & strValTrib & "','" & strQtdTrib & "','" & strMIPI & "'," & _
                    "'" & strQtdN & "','" & strCST & "','" & strOrigem & "','" & strModBC & "','" & strICMS & "'," & _
                    "'" & strRedBC & "','" & strModBCST & "','" & strRedBCST & "','" & strMVaST & "'," & _
                    "'" & strICMSST & "','" & strNCM & "','" & strRegime & "','" & strCalculoCred & "'," & _
                    "'" & strUnidCom & "','" & strValCom & "','" & strCFOP & "')")



                End If
                LogDeErro()
                B += 1

                If P = I Then
                    P += 10
                    BarraProgresso2()
                End If
            Next
            strTabela = "Nfe"
            BarraProdgresso()




            '**********TOTALNFE**********
            B = 1
            dt = CarregarDataTable2("SELECT * FROM TotalNfe where " & String.Format("DEmi >= '{0:dd/MM/yyyy}' AND DEmi <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
            Excluir("DELETE FROM TotalNfe where " & String.Format("DEmi >= '{0:dd/MM/yyyy}' AND DEmi <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig)
            LogDeErro()
            P = 10
            pb1.Value = 0
            intPB = dt.Rows.Count / 10
            pb1.Maximum = intPB
            For I = 0 To dt.Rows.Count - 1

                Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString

                Excluir("DELETE FROM ItensNfe where CodOrdem = " & strCodOrdem & " and CodConfig = " & strCodConfig)
                Excluir("DELETE FROM RefNfe where CodOrdem = " & strCodOrdem & " and CodConfig = " & strCodConfig)
                Excluir("DELETE FROM DuplicataNfe where CodOrdem = " & strCodOrdem & " and CodConfig = " & strCodConfig)
                Excluir("DELETE FROM VolumeNfe where CodOrdem = " & strCodOrdem & " and CodConfig = " & strCodConfig)
                LogDeErro()
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
                dt1 = CarregarDataTable("SELECT Codigo FROM Cliente where Suframa = '" & strCodCli & "'")
                If dt1.Rows.Count > 0 Then
                    strCodCli = dt1.Rows.Item(0).Item("Codigo").ToString
                End If

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
                Dim strCodForn As String = dt.Rows.Item(I).Item("CodForn").ToString
                dt1 = CarregarDataTable("SELECT Codigo FROM Fornecedor where NomePais = '" & strCodForn & "'")
                If dt1.Rows.Count > 0 Then
                    strCodForn = dt.Rows.Item(0).Item("Codigo").ToString
                End If

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
                Dim strDesconto As String = dt.Rows.Item(I).Item("Desconto").ToString


                Inserir("INSERT INTO TotalNfe (CodOrdem, CodNF, NumNF, Chave, IndPag, DEmi, DEntSai, HEntSai, " & _
                "DCont, HCont, JustCont, CDV, CodCli, VBC, VICMS, VBCST, VST, VProd, VFrete, VSeg, VDesc, " & _
                "VII, VIPI, VPIS, VCOFINS, VOutro, VNF, NatOp, TipoNF, TipoImp, TipoAmb, FinNfe, ProcEmi, " & _
                "VerProc, ModFrete, ObsFisco, CodForn, Placa, UFVei, RNTC, NomeTrans, CNPJTrans, IETrans, " & _
                "EndTrans, BairroTrans, NumTrans, UFTrans, CidadeTrans, CodVenda, Serie, NumFatura, " & _
                "ValOrigFatura, ValDescFatura, Desconto, CodConfig) VALUES (" & strCodOrdem & "," & _
                "'" & strCodNF & "','" & strNumNF & "','" & strChave & "','" & strIndPag & "','" & strDEmi & "'," & _
                "'" & strDEntSai & "','" & strHEntSai & "','" & strDCont & "','" & strHCont & "'," & _
                "'" & strJustCont & "','" & strCDV & "'," & strCodCli & "," & Num(strVBC) & "," & Num(strVICMS) & "," & _
                "" & Num(strVBCST) & "," & Num(strVST) & "," & Num(strVProd) & "," & Num(strVFrete) & "," & _
                "" & Num(strVSeg) & "," & Num(strVDesc) & "," & Num(strVII) & "," & Num(strVIPI) & "," & _
                "" & Num(strVPIS) & "," & Num(strVCOFINS) & "," & Num(strVOutro) & "," & Num(strVNF) & ",'" & strNatOp & "'," & _
                "'" & strTipoNF & "','" & strTipoImp & "','" & strTipoAmb & "','" & strFinNfe & "'," & _
                "'" & strProcEmi & "','" & strVerProc & "','" & strModFrete & "','" & strObsFisco & "'," & _
                "'" & strCodForn & "','" & strPlaca & "','" & strUFVei & "','" & strRNTC & "','" & strNomeTrans & "'," & _
                "'" & strCNPJTrans & "','" & strIETrans & "','" & strEndTrans & "','" & strBairroTrans & "'," & _
                "'" & strNumTrans & "','" & strUFTrans & "','" & strCidadeTrans & "','" & strCodVenda & "'," & _
                "'" & strSerie & "','" & strNumFatura & "','" & strValOrigFatura & "','" & strValDescFatura & "'," & _
                "'" & strDesconto & "'," & strCodConfig & ")")
                LogDeErro()

                dt1 = CarregarDataTable2("SELECT * FROM ItensNfe where CodOrdem = " & strCodOrdem & " and " & _
                "CodConfig = " & strCodConfig, strBaseDeDados)

                For A = 0 To dt1.Rows.Count - 1

                    Dim strCodProd As String = dt1.Rows.Item(A).Item("CodProd").ToString
                    dt2 = CarregarDataTable("SELECT Codigo FROM Produto where NivelComboCodCF = '" & strCodProd & "'")
                    If dt2.Rows.Count > 0 Then
                        strCodProd = dt2.Rows.Item(0).Item("Codigo").ToString
                    End If
                    Dim strCodInterno As String = dt1.Rows.Item(A).Item("CodInterno").ToString
                    Dim strCodBarra As String = dt1.Rows.Item(A).Item("CodBarra").ToString
                    Dim strProduto As String = dt1.Rows.Item(A).Item("Produto").ToString
                    Dim strNCM As String = dt1.Rows.Item(A).Item("NCM").ToString
                    Dim strCFOP As String = dt1.Rows.Item(A).Item("CFOP").ToString
                    Dim strEXTIPI As String = dt1.Rows.Item(A).Item("EXTIPI").ToString
                    Dim strUCom As String = dt1.Rows.Item(A).Item("UCom").ToString
                    Dim strQCom As String = dt1.Rows.Item(A).Item("QCom").ToString
                    Dim strVUnCom As String = dt1.Rows.Item(A).Item("VUnCom").ToString
                    Dim strVProdItens As String = dt1.Rows.Item(A).Item("VProd").ToString
                    Dim strOrigem As String = dt1.Rows.Item(A).Item("Origem").ToString

                    Dim strCSTICMS As String = dt1.Rows.Item(A).Item("CSTICMS").ToString
                    Dim strModBC As String = dt1.Rows.Item(A).Item("ModBC").ToString
                    Dim strVBCICMS As String = dt1.Rows.Item(A).Item("VBCICMS").ToString
                    Dim strRedBC As String = dt1.Rows.Item(A).Item("RedBC").ToString
                    Dim strICMS As String = dt1.Rows.Item(A).Item("ICMS").ToString
                    Dim strValICMS As String = dt1.Rows.Item(A).Item("ValICMS").ToString
                    Dim strModBCST As String = dt1.Rows.Item(A).Item("ModBCST").ToString
                    Dim strRedBCST As String = dt1.Rows.Item(A).Item("RedBCST").ToString
                    Dim strVBCSTItens As String = dt1.Rows.Item(A).Item("VBCST").ToString
                    Dim strICMSST As String = dt1.Rows.Item(A).Item("ICMSST").ToString
                    Dim strValICMSST As String = dt1.Rows.Item(A).Item("ValICMSST").ToString
                    Dim strMVaST As String = dt1.Rows.Item(A).Item("MVaST").ToString
                    Dim strCalcCred As String = dt1.Rows.Item(A).Item("CalcCred").ToString
                    Dim strCodEnq As String = dt1.Rows.Item(A).Item("CodEnq").ToString

                    Dim strCSTIPI As String = dt1.Rows.Item(A).Item("CSTIPI").ToString
                    Dim strVBCIPI As String = dt1.Rows.Item(A).Item("VBCIPI").ToString
                    Dim strPerIPI As String = dt1.Rows.Item(I).Item("PerIPI").ToString
                    Dim strValIPI As String = dt1.Rows.Item(A).Item("ValIPI").ToString
                    Dim strCSTPIS As String = dt1.Rows.Item(A).Item("CSTPIS").ToString
                    Dim strVBCPIS As String = dt1.Rows.Item(A).Item("VBCPIS").ToString
                    Dim strPerPIS As String = dt1.Rows.Item(A).Item("PerPIS").ToString
                    Dim strValPIS As String = dt1.Rows.Item(A).Item("ValPIS").ToString
                    Dim strCSTCOFINS As String = dt1.Rows.Item(A).Item("CSTCOFINS").ToString
                    Dim strVCBCOFINS As String = dt1.Rows.Item(A).Item("VCBCOFINS").ToString
                    Dim strPerCOFINS As String = dt1.Rows.Item(A).Item("PerCOFINS").ToString
                    Dim strValCOFINS As String = dt1.Rows.Item(A).Item("ValCOFINS").ToString
                    Dim strVCalcCred As String = dt1.Rows.Item(A).Item("VCalcCred").ToString
                    Dim strValAprox As String = dt1.Rows.Item(A).Item("ValAprox").ToString

                    Inserir("INSERT INTO ItensNfe (CodOrdem, CodProd, CodInterno, CodBarra, Produto, NCM, " & _
                    "CFOP, EXTIPI, UCom, QCom, VUnCom, VProd, Origem, CSTICMS, ModBC, VBCICMS, RedBC, " & _
                    "ICMS, ValICMS, ModBCST, RedBCST, VBCST, ICMSST, ValICMSST, MVaST, CalcCred, CodEnq, " & _
                    "CSTIPI, VBCIPI, PerIPI, ValIPI, CSTPIS, VBCPIS, PerPIS, ValPIS, CSTCOFINS, VCBCOFINS, " & _
                    "PerCOFINS, ValCOFINS, VCalcCred, ValAprox, CodConfig) VALUES (" & strCodOrdem & "," & _
                    "" & strCodProd & ",'" & strCodInterno & "','" & strCodBarra & "','" & strProduto & "'," & _
                    "'" & strNCM & "','" & strCFOP & "','" & strEXTIPI & "','" & strUCom & "'," & _
                    "" & Num(strQCom) & "," & Num(strVUnCom) & "," & Num(strVProdItens) & ",'" & strOrigem & "'," & _
                    "'" & strCSTICMS & "','" & strModBC & "','" & strVBCICMS & "','" & strRedBC & "'," & _
                    "'" & strICMS & "','" & strValICMS & "','" & strModBCST & "','" & strRedBCST & "'," & _
                    "'" & strVBCSTItens & "','" & strICMSST & "','" & strValICMSST & "','" & strMVaST & "'," & _
                    "'" & strCalcCred & "','" & strCodEnq & "','" & strCSTIPI & "','" & strVBCIPI & "'," & _
                    "'" & strPerIPI & "','" & strValIPI & "','" & strCSTPIS & "','" & strVBCPIS & "'," & _
                    "'" & strPerPIS & "','" & strValPIS & "','" & strCSTCOFINS & "','" & strVCBCOFINS & "'," & _
                    "'" & strPerCOFINS & "','" & strValCOFINS & "','" & strVCalcCred & "','" & strValAprox & "'," & _
                    "" & strCodConfig & ")")
                    LogDeErro()

                Next

                dt1 = CarregarDataTable2("SELECT * FROM RefNfe where CodOrdem = " & strCodOrdem & " and " & _
                "CodConfig = " & strCodConfig, strBaseDeDados)

                For A = 0 To dt1.Rows.Count - 1

                    Dim strRefTipo As String = dt1.Rows.Item(A).Item("Tipo").ToString
                    Dim strRefChave As String = dt1.Rows.Item(A).Item("Chave").ToString
                    Dim strRefUF As String = dt1.Rows.Item(A).Item("UF").ToString
                    Dim strRefEmissao As String = dt1.Rows.Item(A).Item("Emissao").ToString
                    Dim strRefCNPJ As String = dt1.Rows.Item(A).Item("CNPJ").ToString
                    Dim strRefModelo As String = dt1.Rows.Item(A).Item("Modelo").ToString
                    Dim strRefSerie As String = dt1.Rows.Item(A).Item("Serie").ToString
                    Dim strRefNumero As String = dt1.Rows.Item(A).Item("Numero").ToString


                    Inserir("INSERT INTO RefNfe (CodOrdem, Tipo, Chave, UF, Emissao, CNPJ, Modelo, " & _
                    "Serie, Numero, CodConfig) VALUES (" & strCodOrdem & ",'" & strRefTipo & "'," & _
                    "'" & strRefChave & "','" & strRefUF & "','" & strRefEmissao & "','" & strRefCNPJ & "'," & _
                    "'" & strRefModelo & "','" & strRefSerie & "','" & strRefNumero & "'," & strCodConfig & ")")
                    LogDeErro()
                Next


                dt1 = CarregarDataTable2("SELECT * FROM DuplicataNfe where CodOrdem = " & strCodOrdem & " and " & _
                "CodConfig = " & strCodConfig, strBaseDeDados)

                For A = 0 To dt1.Rows.Count - 1

                    Dim strDupNumero As String = dt1.Rows.Item(A).Item("Numero").ToString
                    Dim strDupData As String = dt1.Rows.Item(A).Item("Data").ToString
                    Dim strDupValor As String = dt1.Rows.Item(A).Item("Valor").ToString



                    Inserir("INSERT INTO DuplicataNfe (CodOrdem, Numero, Data, Valor, CodConfig) VALUES (" & _
                    "" & strCodOrdem & ",'" & strDupNumero & "','" & strDupData & "','" & strDupValor & "'," & _
                    "" & strCodConfig & ")")
                    LogDeErro()
                Next

                dt1 = CarregarDataTable2("SELECT * FROM VolumeNfe where CodOrdem = " & strCodOrdem & " and " & _
                "CodConfig = " & strCodConfig, strBaseDeDados)

                For A = 0 To dt1.Rows.Count - 1

                    Dim strVolQtde As String = dt1.Rows.Item(A).Item("Qtde").ToString
                    Dim strVolEspecie As String = dt1.Rows.Item(A).Item("Especie").ToString
                    Dim strVolMarca As String = dt1.Rows.Item(A).Item("Marca").ToString
                    Dim strVolNumero As String = dt1.Rows.Item(A).Item("Numero").ToString
                    Dim strVolPesoLiq As String = dt1.Rows.Item(A).Item("PesoLiq").ToString
                    Dim strVolPesoBruto As String = dt1.Rows.Item(A).Item("PesoBruto").ToString


                    Inserir("INSERT INTO VolumeNfe (CodOrdem, Qtde, Especie, Marca, Numero, PesoLiq, " & _
                    "PesoBruto, CodConfig) VALUES (" & strCodOrdem & ",'" & strVolQtde & "'," & _
                    "'" & strVolEspecie & "','" & strVolMarca & "','" & strVolNumero & "','" & strVolPesoLiq & "'," & _
                    "'" & strVolPesoBruto & "'," & strCodConfig & ")")
                    LogDeErro()
                Next
                B += 1

                If P = I Then
                    P += 10
                    BarraProgresso2()
                End If
            Next
            strTabela = "TotalNfe, ItensNfe, DuplicataNfe, RefNfe, VolumeNfe"
            BarraProdgresso()

            '**********CCE**********
            B = 1
            dt = CarregarDataTable2("SELECT * FROM Cce where " & String.Format("DEmi >= '{0:dd/MM/yyyy}' AND DEmi <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
            Excluir("DELETE FROM Cce where " & String.Format("DEmi >= '{0:dd/MM/yyyy}' AND DEmi <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig)
            LogDeErro()
            P = 10
            pb1.Value = 0
            intPB = dt.Rows.Count / 10
            pb1.Maximum = intPB
            For I = 0 To dt.Rows.Count - 1

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

                Inserir("INSERT INTO Cce (CodOrdem, Versao, Id, CUF, TipoAmb, Chave, DEmi, HEmi, " & _
                "TZD, TipoEvento, NumSeqEvento, CNPJ, DescEvento, Correcao, CondUso, CodConfig) VALUES (" & _
                "" & strCodOrdem & ",'" & strVersao & "','" & strId & "','" & strCUF & "'," & _
                "'" & strTipoAmb & "','" & strChave & "','" & strDEmi & "','" & strHEmi & "'," & _
                "'" & strTZD & "','" & strTipoEvento & "','" & strNumSeqEvento & "','" & strCNPJ & "'," & _
                "'" & strDescEvento & "','" & strCorrecao & "','" & strCondUso & "'," & strCodConfig & ")")
                LogDeErro()

                B += 1

                If P = I Then
                    P += 10
                    BarraProgresso2()
                End If
            Next
            strTabela = "Cce"
            BarraProdgresso()

            '**********INUTILIZACAO**********
            B = 1
            dt = CarregarDataTable2("SELECT * FROM Inutilizacao where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
            Excluir("DELETE FROM Inutilizacao where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig)
            LogDeErro()
            P = 10
            pb1.Value = 0
            intPB = dt.Rows.Count / 10
            pb1.Maximum = intPB
            For I = 0 To dt.Rows.Count - 1

                Dim strNumInicial As String = dt.Rows.Item(I).Item("NumInicial").ToString
                Dim strNumFinal As String = dt.Rows.Item(I).Item("NumFinal").ToString
                Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
                Dim strSerie As String = dt.Rows.Item(I).Item("Serie").ToString
                Dim strMotivo As String = dt.Rows.Item(I).Item("Motivo").ToString

                Inserir("INSERT INTO Inutilizacao (NumInicial, NumFinal, Data, Serie, Motivo, " & _
                "CodConfig) VALUES ('" & strNumInicial & "','" & strNumFinal & "'," & _
                "'" & strData & "','" & strSerie & "','" & strMotivo & "'," & strCodConfig & ")")

                LogDeErro()
                B += 1

                If P = I Then
                    P += 10
                    BarraProgresso2()
                End If
            Next
            strTabela = "Inutilizacao"
            BarraProdgresso()
        End If


        '**********RECEBIMENTO**********
        B = 1
        dt = CarregarDataTable2("SELECT * FROM SatFiscal where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig & " order by Codigo", strBaseDeDados)
        Excluir("DELETE FROM SatFiscal where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue, Me.dtFinal.EditValue) & " and CodConfig = " & strCodConfig)
        LogDeErro()
        P = 10
        pb1.Value = 0
        intPB = dt.Rows.Count / 10
        pb1.Maximum = intPB
        For I = 0 To dt.Rows.Count - 1

            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString


            Dim strChave As String = dt.Rows.Item(I).Item("Chave").ToString
            Dim strNumeroSerie As String = dt.Rows.Item(I).Item("NumeroSerie").ToString
            Dim strCNPJ As String = dt.Rows.Item(I).Item("CNPJ").ToString
            Dim strNumeroCupom As String = dt.Rows.Item(I).Item("NumeroCupom").ToString
            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
            Dim strNumeroCupomCancelado As String = dt.Rows.Item(I).Item("NumeroCupomCancelado").ToString
            Dim strValorTotal As String = dt.Rows.Item(I).Item("ValorTotal").ToString

            Dim strCPFDest As String = dt.Rows.Item(I).Item("CFPDest").ToString
            Dim strAssinaturaQrCode As String = dt.Rows.Item(I).Item("AssinaturaQrCode").ToString
            Dim strCodOrdem2 As String = dt.Rows.Item(I).Item("CodOrdem2").ToString

            Inserir("INSERT INTO SatFiscal (CodOrdem, Chave, NumeroSerie, CNPJ, NumeroCupom, " & _
            "Data, NumeroCupomCancelado, ValorTotal, CFPDest, AssinaturaQrCode, CodOrdem2, CodConfig) VALUES " & _
            "(" & strCodOrdem & ",'" & strChave & "'," & _
            "'" & strNumeroSerie & "','" & strCNPJ & "','" & strNumeroCupom & "','" & strData & "','" & strNumeroCupomCancelado & "'," & Num(strValorTotal) & ",'" & strCPFDest & "','" & strAssinaturaQrCode & "','" & strCodOrdem2 & "'," & strCodConfig & ")")
            LogDeErro()

            B += 1

            If P = I Then
                P += 10
                BarraProgresso2()
            End If
        Next
        strTabela = "strCodOrdem2"
        BarraProdgresso()


        'Excluir("DELETE FROM Cliente where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtData.EditValue , Me.dtFinal.EditValue) & " and Suframa <> '' and CodConfig = " & strCodConfig)
        Me.Cursor = Cursors.Default
        Me.rtbMens.AppendText(vbCrLf & "Tabelas sincronizadas com sucesso!")
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub
    Private Sub BarraProdgresso()
        If pb.Value < intMax Then
            pb.Value = pb.Value + 10
        End If

        Clipboard.SetImage(Me.ImageList1.Images.Item(0))
        Me.rtbMens.Paste()
        Me.rtbMens.AppendText(" Tabela " & strTabela & " sincronizada com sucesso!" & vbCrLf)

        Application.DoEvents()
        System.Threading.Thread.Sleep(40)
    End Sub
    Private Sub BarraProgresso2()
        If pb1.Value < intPB Then
            pb1.Value = pb1.Value + 1
        End If
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