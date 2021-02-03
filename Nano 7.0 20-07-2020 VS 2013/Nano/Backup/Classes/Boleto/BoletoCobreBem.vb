Imports CobreBemX
Imports Nano.clsFuncoes
Public Class BoletoCobreBem
    Public Shared Function CobreBem(ByVal parCodOrdem As String, ByVal parAtualizado As Boolean)

        'Dim dt As DataTable = CarregarDataTable("SELECT Boleto.CodBanco, Boleto.CodCli, " & _
        '"Boleto.ValorMora, convert(Varchar(10),Boleto.Vencimento,103) as Vencimento, " & _
        '"Boleto.Valor, convert(Varchar(10),Boleto.DataEmissao,103) as DataEmissao, " & _
        '"Boleto.DiasMora, Boleto.NumeroDocumento, " & _
        '"Cliente.Nome, Cliente.CPF, Cliente.Endereco, Cliente.Numero, Cliente.Bairro, Cliente.Cidade, Cliente.Estado, " & _
        '"Cliente.Cep " & _
        '"FROM Boleto left join Cliente on Boleto.CodCli = Cliente.Codigo " & _
        '"where Boleto.CodOrdem = " & parCodOrdem & " and Boleto.CodConfig = " & CodConfig)

        Dim dtRec As DataTable = CarregarDataTable("SELECT ContaReceber.Parcelas, ContaReceber.CodOrdem, ContaReceber.Codigo, CodCli, Parcelas, " & _
        "Cliente.Nome, Cliente.CPF, Cliente.Endereco, Cliente.Numero, Cliente.Bairro, Cliente.Cidade, Cliente.Estado, " & _
        "Cliente.Cep, ValorParcela, Vencimento FROM ContaReceber left join Cliente on ContaReceber.CodCli = Cliente.Codigo where Pagamento like '%BOLETO%' and contareceber.codigo in(" & parCodOrdem & ") and ContaReceber.CodConfig = " & CodConfig)

        Dim CobreBemX As CobreBemX.ContaCorrente


        CobreBemX = New CobreBemX.ContaCorrente

        Dim intCodOrdem As Integer = GerarCodigoOrdensBanco("Boleto", CodBanco)

        'Inserir("INSERT INTO Ordens (Cod, CodConfig, Tabela, CodBanco) VALUES (" & intCodOrdem & "," & CodConfig & ",'Boleto'," & dt.Rows.Item(0).Item("CodBanco").ToString & ")")

        CobreBemX.ArquivoLicenca = CaminhoArquivoBoleto
       

        Select Case CodigoBancoBoleto
            Case "341"
                CobreBemX.CodigoAgencia = AgenciaBanco
                CobreBemX.NumeroContaCorrente = ContaCorrenteBanco

                CobreBemX.CodigoCedente = CodigoCedenteBanco
                CobreBemX.InicioNossoNumero = "00000001"
                CobreBemX.FimNossoNumero = "99999999"
                CobreBemX.ProximoNossoNumero = Format(intCodOrdem, "00000000")
            Case "104"
                'CobreBemX.CodigoAgencia = AgenciaBanco
                'CobreBemX.NumeroContaCorrente = ContaCorrenteBanco

                CobreBemX.CodigoCedente = AgenciaBanco & "." & CodigoCedenteBanco & "." & ContaCorrenteBanco
                CobreBemX.InicioNossoNumero = "000000001"
                CobreBemX.FimNossoNumero = "999999999"
                CobreBemX.ProximoNossoNumero = Format(intCodOrdem, "000000000")

            Case "756"
                CobreBemX.CodigoAgencia = AgenciaBanco.Replace("-", "")
                CobreBemX.NumeroContaCorrente = ContaCorrenteBanco.Replace("-", "")

                CobreBemX.CodigoCedente = CodigoCedenteBanco.Replace("-", "")
                CobreBemX.InicioNossoNumero = "0000001"
                CobreBemX.FimNossoNumero = "9999999"
                CobreBemX.ProximoNossoNumero = Format(intCodOrdem, "0000000")
                CobreBemX.OutroDadoConfiguracao1 = "01"
                CobreBemX.OutroDadoConfiguracao2 = "1"


            Case Else
                CobreBemX.CodigoAgencia = AgenciaBanco
                CobreBemX.NumeroContaCorrente = ContaCorrenteBanco

                CobreBemX.CodigoCedente = CodigoCedenteBanco
                CobreBemX.InicioNossoNumero = "00000001"
                CobreBemX.FimNossoNumero = "99999999"
                CobreBemX.ProximoNossoNumero = Format(intCodOrdem, "00000000")
        End Select

        CobreBemX.PadroesBoleto.PadroesBoletoImpresso.ArquivoLogotipo = CaminhoPastaBoleto & "\Imagens\logoEra2.png"
        CobreBemX.PadroesBoleto.PadroesBoletoImpresso.CaminhoImagensCodigoBarras = CaminhoPastaBoleto & "\Imagens\"
        CobreBemX.PadroesBoleto.PadroesBoletoImpresso.LayoutBoleto = "Padrao"
        CobreBemX.PadroesBoleto.PadroesBoletoImpresso.MargemSuperior = "5"
        CobreBemX.PadroesBoleto.IdentificacaoCedente = EnderecoEmpresa

        Dim I As Integer
        For I = 0 To dtRec.Rows.Count - 1
            If I > 0 Then
                intCodOrdem += 1 ' GerarCodigoOrdensBanco("Boleto", dt.Rows.Item(0).Item("CodBanco").ToString)
                'Inserir("INSERT INTO Ordens (Cod, CodConfig, Tabela, CodBanco) VALUES (" & intCodOrdem & "," & CodConfig & ",'Boleto'," & dt.Rows.Item(0).Item("CodBanco").ToString & ")")
            End If

            Dim Boleto As Object
            Boleto = CobreBemX.DocumentosCobranca.Add
            Boleto.NumeroControle = parCodOrdem
            Boleto.NumeroDocumento = parCodOrdem & "-" & I + 1
            Boleto.NomeSacado = dtRec.Rows.Item(I).Item("Nome").ToString
            Boleto.CPFSacado = dtRec.Rows.Item(I).Item("CPF").ToString
            Boleto.EnderecoSacado = dtRec.Rows.Item(I).Item("Endereco").ToString & " " & dtRec.Rows.Item(I).Item("Numero").ToString
            Boleto.BairroSacado = dtRec.Rows.Item(I).Item("Bairro").ToString
            Boleto.CidadeSacado = dtRec.Rows.Item(I).Item("Cidade").ToString
            Boleto.EstadoSacado = dtRec.Rows.Item(I).Item("Estado").ToString
            Boleto.CepSacado = dtRec.Rows.Item(I).Item("Cep").ToString.Replace(".", "").Replace("-", "")
            Boleto.DataDocumento = Date.Today
            Boleto.DataVencimento = dtRec.Rows.Item(I).Item("Vencimento").ToString
            Boleto.ValorDocumento = dtRec.Rows.Item(I).Item("ValorParcela").ToString

            Boleto.InstrucaoCobranca1 = PrimeiraInstrucaoBanco
            Boleto.InstrucaoCobranca2 = ""
            Select Case CodigoBancoBoleto
                Case "756"
                    Dim strParcelas As String = dtRec.Rows.Item(I).Item("Parcelas").ToString
                    If strParcelas.Contains("P") = True Then
                        strParcelas = "1"
                    Else
                        Dim vetPar As Array = Split(strParcelas, "/")
                        strParcelas = vetPar(0)
                    End If
                    Boleto.NumeroParcelaCarnet = strParcelas
            End Select

            Boleto.TipoDocumentoCobranca = "DM"
            Boleto.PercentualJurosDiaAtraso = MoraBanco
            If DiasProtestoBanco <> "" Then
                Boleto.DiasProtesto = DiasProtestoBanco
            End If

            Boleto.PercentualMultaAtraso = PerMultaBanco

            Boleto.PadroesBoleto.Demonstrativo = DemonstrativoBanco
            Boleto.PadroesBoleto.InstrucoesCaixa = InstrucaoBanco


            If PerMultaBanco <> "" Then
                Dim dblPerMulta As Double = PerMultaBanco
                If dblPerMulta > 0 Then
                    Dim MDados As Object
                    MDados = Boleto.MeusDados.Add
                    MDados.Nome = "GeraRegistroMulta"
                    MDados.Valor = "S"
                End If
            End If
        Next
      
        CobreBemX.ImprimeBoletos()

        intCodOrdem += 1
        Inserir("INSERT INTO Ordens (Cod, CodConfig, Tabela, CodBanco) VALUES (" & intCodOrdem & "," & CodConfig & ",'Boleto'," & CodBanco & ")")

        For I = 0 To dtRec.Rows.Count - 1
            Dim strCodigoBarra As String = CobreBemX.DocumentosCobranca.Item(I).CodigoBarras
            Dim strNossoNumero As String = CobreBemX.DocumentosCobranca.Item(I).NossoNumero
            Dim strParcela As String = "1"
            Select Case CodigoBancoBoleto
                Case "341"
                    strNossoNumero = Format(CInt(strNossoNumero), "00000000")

                Case "104"
                    strNossoNumero = strNossoNumero
                Case "756"
                    strNossoNumero = Format(CInt(strNossoNumero), "0000000")
                    strParcela = CobreBemX.DocumentosCobranca.Item(I).NumeroParcelaCarnet
                Case Else
                    strNossoNumero = Format(CInt(strNossoNumero), "00000")
            End Select

            Dim strLinhaDigitavel As String = CobreBemX.DocumentosCobranca.Item(I).LinhaDigitavel
            Dim strNumeroDocumento As String = CobreBemX.DocumentosCobranca.Item(I).NumeroDocumento
            Dim strSeuNumero As String = CobreBemX.DocumentosCobranca.Item(I).NumeroControle

            Dim strCodCli As String = dtRec.Rows.Item(I).Item("CodCli").ToString
            Dim dblValor As Double = dtRec.Rows.Item(I).Item("ValorParcela").ToString
            Dim strVencimento As Date = dtRec.Rows.Item(I).Item("Vencimento").ToString
            Dim strCodigoConta As String = dtRec.Rows.Item(I).Item("Codigo").ToString
            Dim strCodOrdem As String = dtRec.Rows.Item(I).Item("CodOrdem").ToString

            Inserir("INSERT INTO Boleto (CodOrdem, CodBanco, CodCli, PerMulta, " & _
            "PrimeiraInstrucao, SegundaInstrucao, ValorMora, Vencimento, Valor, DataEmissao, DiasProtesto, " & _
            "NumeroDocumento, Status, DiasMora, CodConfig, CodigoConta, Instrucao, Instrucao2, NossoNumero, " & _
            "CodigoBarras, LinhaDigitavel, SeuNumero, ValorIOF) VALUES (" & _
            "" & strCodOrdem & "," & CodBanco & "," & strCodCli & ",'" & PerMultaBanco & "'," & _
            "'" & PrimeiraInstrucaoBanco & "','" & SegundaInstrucaoBanco & "','" & MoraBanco & "'," & _
            "'" & strVencimento & "'," & Num(dblValor) & ",'" & Date.Today & "'," & _
            "'" & DiasProtestoBanco & "','" & strCodigoConta & "','Pendente','" & DiasMoraBanco & "'," & _
            "" & CodConfig & ",'" & strCodigoConta & "','" & DemonstrativoBanco & "','" & InstrucaoBanco & "'," & _
            "'" & strNossoNumero & "','" & strCodigoBarra & "','" & strLinhaDigitavel & "','" & strSeuNumero & "','" & strParcela & "')")
        Next

        CobreBemX = Nothing
    End Function
End Class
