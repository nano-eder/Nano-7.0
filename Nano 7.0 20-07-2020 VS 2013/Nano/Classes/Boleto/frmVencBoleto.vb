Imports Nano.clsFuncoes
Public Class frmVencBoleto
    Public strCodigo As String
    Public strCodOrdem As String
    Public strCodigoConta As String
    Private Sub frmVencBoleto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtVencimento.EditValue = Date.Today.AddDays(30)
    End Sub

    Private Sub btnGerar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGerar.ItemClick
        Dim dtRec As DataTable = CarregarDataTable("SELECT ContaReceber.Codigo, CodCli, Parcelas, " & _
        "Cliente.Nome, Cliente.CPF, Cliente.Endereco, Cliente.Numero, Cliente.Bairro, Cliente.Cidade, Cliente.Estado, " & _
        "Cliente.Cep, ValorParcela, Vencimento FROM ContaReceber left join Cliente on ContaReceber.CodCli = Cliente.Codigo where Pagamento like '%BOLETO%' and ContaReceber.Codigo = " & strCodigo & " and ContaReceber.CodConfig = " & CodConfig)
        If dtRec.Rows.Count = 0 Then Exit Sub
        Dim CobreBemX As CobreBemX.ContaCorrente

        CobreBemX = New CobreBemX.ContaCorrente

        Dim intCodOrdem As Integer = GerarCodigoOrdensBanco("Boleto", CodBanco)

        CobreBemX.ArquivoLicenca = CaminhoArquivoBoleto
        'CobreBemX.CodigoAgencia = AgenciaBanco
        'CobreBemX.NumeroContaCorrente = ContaCorrenteBanco
        'CobreBemX.CodigoCedente = CodigoCedenteBanco

        'Select Case CodigoBancoBoleto
        '    Case "341"
        '        CobreBemX.InicioNossoNumero = "00000001"
        '        CobreBemX.FimNossoNumero = "99999999"
        '        CobreBemX.ProximoNossoNumero = Format(intCodOrdem, "00000000")

        '    Case "756"
        '        CobreBemX.CodigoAgencia = AgenciaBanco.Replace("-", "")
        '        CobreBemX.NumeroContaCorrente = ContaCorrenteBanco.Replace("-", "")

        '        CobreBemX.CodigoCedente = CodigoCedenteBanco.Replace("-", "")
        '        CobreBemX.InicioNossoNumero = "0000001"
        '        CobreBemX.FimNossoNumero = "9999999"
        '        CobreBemX.ProximoNossoNumero = Format(intCodOrdem, "0000000")
        '        CobreBemX.OutroDadoConfiguracao1 = "01"
        '        CobreBemX.OutroDadoConfiguracao2 = "1"

        '    Case Else
        '        CobreBemX.InicioNossoNumero = "00001"
        '        CobreBemX.FimNossoNumero = "99999"
        '        CobreBemX.ProximoNossoNumero = Format(intCodOrdem, "00000")
        'End Select
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

        Dim Boleto As Object
        Boleto = CobreBemX.DocumentosCobranca.Add
        Boleto.NumeroControle = strCodOrdem
        Boleto.NumeroDocumento = strCodOrdem & "-" & 1
        Boleto.NomeSacado = dtRec.Rows.Item(0).Item("Nome").ToString
        Boleto.CPFSacado = dtRec.Rows.Item(0).Item("CPF").ToString
        Boleto.EnderecoSacado = dtRec.Rows.Item(0).Item("Endereco").ToString & " " & dtRec.Rows.Item(0).Item("Numero").ToString
        Boleto.BairroSacado = dtRec.Rows.Item(0).Item("Bairro").ToString
        Boleto.CidadeSacado = dtRec.Rows.Item(0).Item("Cidade").ToString
        Boleto.EstadoSacado = dtRec.Rows.Item(0).Item("Estado").ToString
        Boleto.CepSacado = dtRec.Rows.Item(0).Item("Cep").ToString.Replace(".", "").Replace("-", "")
        Boleto.DataDocumento = Date.Today
        Boleto.DataVencimento = Me.dtVencimento.EditValue
        Boleto.ValorDocumento = Me.txtValorConta.Text

        Boleto.InstrucaoCobranca1 = PrimeiraInstrucaoBanco
        Boleto.InstrucaoCobranca2 = ""

        Select Case CodigoBancoBoleto
            Case "756"
                Dim strParcelas As String = dtRec.Rows.Item(0).Item("Parcelas").ToString
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

        CobreBemX.ImprimeBoletos()

        intCodOrdem += 1
        Inserir("INSERT INTO Ordens (Cod, CodConfig, Tabela, CodBanco) VALUES (" & intCodOrdem & "," & CodConfig & ",'Boleto'," & CodBanco & ")")


        Dim strCodigoBarra As String = CobreBemX.DocumentosCobranca.Item(0).CodigoBarras
        Dim strNossoNumero As String = CobreBemX.DocumentosCobranca.Item(0).NossoNumero

        'Select Case CodigoBancoBoleto
        '    Case "341"
        '        strNossoNumero = Format(CInt(strNossoNumero), "00000000")

        '    Case "104"
        '        strNossoNumero = strNossoNumero

        '    Case Else
        '        strNossoNumero = Format(CInt(strNossoNumero), "00000")
        'End Select
        Dim strParcela As String = "1"
        Select Case CodigoBancoBoleto
            Case "341"
                strNossoNumero = Format(CInt(strNossoNumero), "00000000")

            Case "104"
                strNossoNumero = strNossoNumero
            Case "756"
                strNossoNumero = Format(CInt(strNossoNumero), "0000000")
                strParcela = CobreBemX.DocumentosCobranca.Item(0).NumeroParcelaCarnet
            Case Else
                strNossoNumero = Format(CInt(strNossoNumero), "00000")
        End Select
        Dim strLinhaDigitavel As String = CobreBemX.DocumentosCobranca.Item(0).LinhaDigitavel
        Dim strNumeroDocumento As String = CobreBemX.DocumentosCobranca.Item(0).NumeroDocumento
        Dim strSeuNumero As String = CobreBemX.DocumentosCobranca.Item(0).NumeroControle

        Dim strCodCli As String = dtRec.Rows.Item(0).Item("CodCli").ToString
        Dim dblValor As Double = Me.txtValorConta.Text
        Dim strVencimento As Date = Me.dtVencimento.EditValue
     
        Inserir("INSERT INTO Boleto (CodOrdem, CodBanco, CodCli, PerMulta, " & _
        "PrimeiraInstrucao, SegundaInstrucao, ValorMora, Vencimento, Valor, DataEmissao, DiasProtesto, " & _
        "NumeroDocumento, Status, DiasMora, CodConfig, CodigoConta, Instrucao, Instrucao2, NossoNumero, " & _
        "CodigoBarras, LinhaDigitavel, SeuNumero) VALUES (" & _
        "" & strCodOrdem & "," & CodBanco & "," & strCodCli & ",'" & PerMultaBanco & "'," & _
        "'" & PrimeiraInstrucaoBanco & "','" & SegundaInstrucaoBanco & "','" & MoraBanco & "'," & _
        "'" & strVencimento & "'," & Num(dblValor) & ",'" & Date.Today & "'," & _
        "'" & DiasProtestoBanco & "','" & strCodOrdem & "-1" & "','Pendente','" & DiasMoraBanco & "'," & _
        "" & CodConfig & ",'" & strCodigoConta & "','" & DemonstrativoBanco & "','" & InstrucaoBanco & "'," & _
        "'" & strNossoNumero & "','" & strCodigoBarra & "','" & strLinhaDigitavel & "','" & strSeuNumero & "')")

        CobreBemX = Nothing

        Me.Close()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub
End Class