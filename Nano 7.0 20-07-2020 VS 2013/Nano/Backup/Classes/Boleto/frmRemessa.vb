Imports Nano.clsFuncoes
Imports System.IO

Imports CobreBemX
Public Class frmRemessa

    Private Sub frmConNfeItens_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CarregarGrid()
        If Me.Tag = "CONSULTA" Then
            Me.Text = "Consultar Boletos"
            Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If
    End Sub

    Private Sub CarregarGrid()
        Dim strStatus As String = ""
        If Me.Tag = "REMESSA" Then
            strStatus = "and Boleto.Status = 'Pendente'"
        End If
        Dim dt As DataTable = CarregarDataTable("SELECT Banco.Codigo as CodBanco, Banco.NomeBanco, Boleto.ValorIOF as Parcela, " & _
        "Banco.Agencia, Banco.CodigoCedente, Boleto.NumeroDocumento, convert(varchar(10),Boleto.Vencimento,103) as Vencimento, " & _
        "Boleto.Valor, Boleto.Status, Boleto.Codigo, Boleto.NossoNumero, Boleto.ValorMora as Mora, Boleto.PerMulta, " & _
        "Boleto.PrimeiraInstrucao, Boleto.Instrucao  as Demonstrativo, Boleto.Instrucao2 as Instrucao, Boleto.DiasProtesto, " & _
        "Boleto.DataEmissao, Cliente.Nome as Cliente, Cliente.CPF, Cliente.Endereco, Cliente.Numero, Cliente.Bairro, Cliente.Cidade, Cliente.Estado, " & _
        "Cliente.Cep FROM (Boleto left join Banco on Boleto.CodBanco = Banco.Codigo) left join Cliente on Boleto.CodCli = Cliente.Codigo where Padrao = 'True' and Boleto.CodConfig = " & CodConfig & strStatus)

        Dim I As Integer

        Me.tbBoleto.Rows.Clear()
        For I = 0 To dt.Rows.Count - 1
            Me.tbBoleto.Rows.Add()
            Me.tbBoleto.Rows.Item(I).Item("CodBanco") = dt.Rows.Item(I).Item("CodBanco").ToString
            Me.tbBoleto.Rows.Item(I).Item("NomeBanco") = dt.Rows.Item(I).Item("NomeBanco").ToString
            Me.tbBoleto.Rows.Item(I).Item("Agencia") = dt.Rows.Item(I).Item("Agencia").ToString
            Me.tbBoleto.Rows.Item(I).Item("CodigoCedente") = dt.Rows.Item(I).Item("CodigoCedente").ToString
            Me.tbBoleto.Rows.Item(I).Item("NumeroDocumento") = dt.Rows.Item(I).Item("NumeroDocumento").ToString
            Me.tbBoleto.Rows.Item(I).Item("Vencimento") = dt.Rows.Item(I).Item("Vencimento").ToString
            Me.tbBoleto.Rows.Item(I).Item("Valor") = dt.Rows.Item(I).Item("Valor").ToString
            Me.tbBoleto.Rows.Item(I).Item("Status") = dt.Rows.Item(I).Item("Status").ToString
            Me.tbBoleto.Rows.Item(I).Item("Codigo") = dt.Rows.Item(I).Item("Codigo").ToString
            Me.tbBoleto.Rows.Item(I).Item("NossoNumero") = dt.Rows.Item(I).Item("NossoNumero").ToString

            Me.tbBoleto.Rows.Item(I).Item("Mora") = dt.Rows.Item(I).Item("Mora").ToString
            Me.tbBoleto.Rows.Item(I).Item("PerMulta") = dt.Rows.Item(I).Item("PerMulta").ToString
            Me.tbBoleto.Rows.Item(I).Item("PrimeiraInstrucao") = dt.Rows.Item(I).Item("PrimeiraInstrucao").ToString
            Me.tbBoleto.Rows.Item(I).Item("Demonstrativo") = dt.Rows.Item(I).Item("Demonstrativo").ToString
            Me.tbBoleto.Rows.Item(I).Item("Instrucao") = dt.Rows.Item(I).Item("Instrucao").ToString
            Me.tbBoleto.Rows.Item(I).Item("DiasProtesto") = dt.Rows.Item(I).Item("DiasProtesto").ToString
            Me.tbBoleto.Rows.Item(I).Item("DataEmissao") = dt.Rows.Item(I).Item("DataEmissao").ToString
            Me.tbBoleto.Rows.Item(I).Item("Cliente") = dt.Rows.Item(I).Item("Cliente").ToString
            Me.tbBoleto.Rows.Item(I).Item("Cidade") = dt.Rows.Item(I).Item("Cidade").ToString
            Me.tbBoleto.Rows.Item(I).Item("Endereco") = dt.Rows.Item(I).Item("Endereco").ToString
            Me.tbBoleto.Rows.Item(I).Item("Numero") = dt.Rows.Item(I).Item("Numero").ToString
            Me.tbBoleto.Rows.Item(I).Item("Bairro") = dt.Rows.Item(I).Item("Bairro").ToString
            Me.tbBoleto.Rows.Item(I).Item("Estado") = dt.Rows.Item(I).Item("Estado").ToString
            Me.tbBoleto.Rows.Item(I).Item("Cep") = dt.Rows.Item(I).Item("Cep").ToString
            Me.tbBoleto.Rows.Item(I).Item("CPF") = dt.Rows.Item(I).Item("CPF").ToString
            Me.tbBoleto.Rows.Item(I).Item("Parcela") = dt.Rows.Item(I).Item("Parcela").ToString

            Me.tbBoleto.Rows.Item(I).Item("Gerar") = False
        Next
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

        Dim strData As String = String.Format("Vencimento >= '{0:dd/MM/yyyy}' AND Vencimento <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, Me.dtFinal.EditValue)

        Dim strStatus As String = ""
        If Me.Tag = "REMESSA" Then
            strStatus = "and Boleto.Status = 'Pendente'"
        End If
        Dim dt As DataTable = CarregarDataTable("SELECT Banco.Codigo as CodBanco, Banco.NomeBanco, " & _
        "Banco.Agencia, Banco.CodigoCedente, Boleto.NumeroDocumento, convert(varchar(10),Boleto.Vencimento,103) as Vencimento, Boleto.ValorIOF as Parcela, " & _
        "Boleto.Valor, Boleto.Status, Boleto.Codigo, Boleto.NossoNumero, Boleto.ValorMora as Mora, Boleto.PerMulta, " & _
        "Boleto.PrimeiraInstrucao, Boleto.Instrucao  as Demonstrativo, Boleto.Instrucao2 as Instrucao, Boleto.DiasProtesto, " & _
        "Boleto.DataEmissao, Cliente.Nome as Cliente, Cliente.CPF, Cliente.Endereco, Cliente.Numero, Cliente.Bairro, Cliente.Cidade, Cliente.Estado, " & _
        "Cliente.Cep FROM (Boleto left join Banco on Boleto.CodBanco = Banco.Codigo) left join Cliente on Boleto.CodCli = Cliente.Codigo where Padrao = 'True' and " & strData & " and Boleto.CodConfig = " & CodConfig & strStatus)

        Dim I As Integer

        Me.tbBoleto.Rows.Clear()
        For I = 0 To dt.Rows.Count - 1
            Me.tbBoleto.Rows.Add()
            Me.tbBoleto.Rows.Item(I).Item("CodBanco") = dt.Rows.Item(I).Item("CodBanco").ToString
            Me.tbBoleto.Rows.Item(I).Item("NomeBanco") = dt.Rows.Item(I).Item("NomeBanco").ToString
            Me.tbBoleto.Rows.Item(I).Item("Agencia") = dt.Rows.Item(I).Item("Agencia").ToString
            Me.tbBoleto.Rows.Item(I).Item("CodigoCedente") = dt.Rows.Item(I).Item("CodigoCedente").ToString
            Me.tbBoleto.Rows.Item(I).Item("NumeroDocumento") = dt.Rows.Item(I).Item("NumeroDocumento").ToString
            Me.tbBoleto.Rows.Item(I).Item("Vencimento") = dt.Rows.Item(I).Item("Vencimento").ToString
            Me.tbBoleto.Rows.Item(I).Item("Valor") = dt.Rows.Item(I).Item("Valor").ToString
            Me.tbBoleto.Rows.Item(I).Item("Status") = dt.Rows.Item(I).Item("Status").ToString
            Me.tbBoleto.Rows.Item(I).Item("Codigo") = dt.Rows.Item(I).Item("Codigo").ToString
            Me.tbBoleto.Rows.Item(I).Item("NossoNumero") = dt.Rows.Item(I).Item("NossoNumero").ToString

            Me.tbBoleto.Rows.Item(I).Item("Mora") = dt.Rows.Item(I).Item("Mora").ToString
            Me.tbBoleto.Rows.Item(I).Item("PerMulta") = dt.Rows.Item(I).Item("PerMulta").ToString
            Me.tbBoleto.Rows.Item(I).Item("PrimeiraInstrucao") = dt.Rows.Item(I).Item("PrimeiraInstrucao").ToString
            Me.tbBoleto.Rows.Item(I).Item("Demonstrativo") = dt.Rows.Item(I).Item("Demonstrativo").ToString
            Me.tbBoleto.Rows.Item(I).Item("Instrucao") = dt.Rows.Item(I).Item("Instrucao").ToString
            Me.tbBoleto.Rows.Item(I).Item("DiasProtesto") = dt.Rows.Item(I).Item("DiasProtesto").ToString
            Me.tbBoleto.Rows.Item(I).Item("DataEmissao") = dt.Rows.Item(I).Item("DataEmissao").ToString
            Me.tbBoleto.Rows.Item(I).Item("Cliente") = dt.Rows.Item(I).Item("Cliente").ToString
            Me.tbBoleto.Rows.Item(I).Item("Cidade") = dt.Rows.Item(I).Item("Cidade").ToString
            Me.tbBoleto.Rows.Item(I).Item("Endereco") = dt.Rows.Item(I).Item("Endereco").ToString
            Me.tbBoleto.Rows.Item(I).Item("Numero") = dt.Rows.Item(I).Item("Numero").ToString
            Me.tbBoleto.Rows.Item(I).Item("Bairro") = dt.Rows.Item(I).Item("Bairro").ToString
            Me.tbBoleto.Rows.Item(I).Item("Estado") = dt.Rows.Item(I).Item("Estado").ToString
            Me.tbBoleto.Rows.Item(I).Item("Cep") = dt.Rows.Item(I).Item("Cep").ToString
            Me.tbBoleto.Rows.Item(I).Item("CPF") = dt.Rows.Item(I).Item("CPF").ToString
            Me.tbBoleto.Rows.Item(I).Item("Parcela") = dt.Rows.Item(I).Item("Parcela").ToString

            Me.tbBoleto.Rows.Item(I).Item("Gerar") = False
        Next
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relRemessas
        If Me.Tag = "REMESSA" Then
            rel.lblTitulo.Text = "Relatório de Remessas"
        Else
            rel.lblTitulo.Text = "Relatório de Boletos"
        End If

        rel.picLogo.Image = LogoTipo

        Dim I As Integer
     
        With rel.tbBoleto.Rows
            For I = 0 To Me.grd1.RowCount - 1
                .Add()
                .Item(I).Item("CodBanco") = Me.grd1.GetRowCellDisplayText(I, Me.ColCodBanco)
                .Item(I).Item("NomeBanco") = Me.grd1.GetRowCellDisplayText(I, Me.colNomeBanco)
                .Item(I).Item("Agencia") = Me.grd1.GetRowCellDisplayText(I, Me.colAgencia)
                .Item(I).Item("CodigoCedente") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoCedente)
                .Item(I).Item("NumeroDocumento") = Me.grd1.GetRowCellDisplayText(I, Me.colNumeroDocumento)
                .Item(I).Item("Vencimento") = Me.grd1.GetRowCellDisplayText(I, Me.colVencimento)
                .Item(I).Item("Valor") = Me.grd1.GetRowCellDisplayText(I, Me.colValor)
                .Item(I).Item("Status") = Me.grd1.GetRowCellDisplayText(I, Me.colStatus)
                .Item(I).Item("Codigo") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)
                .Item(I).Item("NossoNumero") = Me.grd1.GetRowCellDisplayText(I, Me.colNossoNumero)

            Next
        End With

        rel.ShowPreview()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnGerar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGerar.ItemClick
        'Select Case Me.grd1.GetRowCellDisplayText(0, Me.colNomeBanco)
        '    Case "SANTANDER"
        '        RemessaSantander()
        '    Case "BRADESCO"
        '        RemessaBradesco()
        '    Case "CAIXA ECONÔMICA"
        '        RemessaCaixa()
        '    Case Else
        '        RemessaBB()
        'End Select

        Dim index As Integer = -999997
        grd1.FocusedRowHandle = index
        grd1.FocusedColumn = Me.colAgencia
        grd1.ShowEditor()
        Dim CobreBemX As CobreBemX.ContaCorrente


        CobreBemX = New CobreBemX.ContaCorrente

        CobreBemX.ArquivoLicenca = CaminhoArquivoBoleto
     
        Select Case CodigoBancoBoleto
            Case "341"
                CobreBemX.CodigoAgencia = AgenciaBanco
                CobreBemX.NumeroContaCorrente = ContaCorrenteBanco
                CobreBemX.CodigoCedente = CodigoCedenteBanco

            Case "104"
               CobreBemX.CodigoCedente = AgenciaBanco & "." & CodigoCedenteBanco & "." & ContaCorrenteBanco

            Case "756"
                CobreBemX.CodigoAgencia = AgenciaBanco.Replace("-", "")
                Dim vetCC As Array = Split(ContaCorrenteBanco, "-")
                Dim intCC As Integer = vetCC(0)

                Dim strConta As String = Format(intCC, "000000000") & "-" & vetCC(1)

                CobreBemX.NumeroContaCorrente = strConta
                Dim intCedente As Integer = CodigoCedenteBanco.Replace("-", "")
                Dim strCedente As String = Format(intCedente, "0000000000")

                CobreBemX.CodigoCedente = strCedente

                CobreBemX.OutroDadoConfiguracao1 = "01"
                CobreBemX.OutroDadoConfiguracao2 = "1"
            Case Else
                CobreBemX.CodigoAgencia = AgenciaBanco
                CobreBemX.NumeroContaCorrente = ContaCorrenteBanco
                CobreBemX.CodigoCedente = CodigoCedenteBanco
        End Select
        CobreBemX.PadroesBoleto.PadroesBoletoImpresso.ArquivoLogotipo = CaminhoPastaBoleto & "\Imagens\logoEra2.png"
        CobreBemX.PadroesBoleto.PadroesBoletoImpresso.CaminhoImagensCodigoBarras = CaminhoPastaBoleto & "\Imagens\"
        CobreBemX.PadroesBoleto.PadroesBoletoImpresso.LayoutBoleto = "Padrao"
        CobreBemX.PadroesBoleto.PadroesBoletoImpresso.MargemSuperior = "5"

        If Me.Tag <> "REMESSA" Then
            Select Case CodigoBancoBoleto
                Case "341"
                    CobreBemX.InicioNossoNumero = "00000001"
                    CobreBemX.FimNossoNumero = "99999999"
                    'CobreBemX.ProximoNossoNumero = Format(intCodOrdem, "00000000")

                Case "104"
                    CobreBemX.InicioNossoNumero = "000000001"
                    CobreBemX.FimNossoNumero = "999999999"
                    'CobreBemX.ProximoNossoNumero = Format(intCodOrdem, "00000000")
                Case "756"
                    CobreBemX.InicioNossoNumero = "0000001"
                    CobreBemX.FimNossoNumero = "9999999"
                Case Else
                    CobreBemX.InicioNossoNumero = "00001"
                    CobreBemX.FimNossoNumero = "99999"
                    'CobreBemX.ProximoNossoNumero = Format(intCodOrdem, "00000")

            End Select
            CobreBemX.PadroesBoleto.IdentificacaoCedente = EnderecoEmpresa
        Else
            Select Case CodigoBancoBoleto
                Case "341"
                     CobreBemX.ArquivoRemessa.Layout = "CNAB400"
                Case "104"
                    CobreBemX.ArquivoRemessa.Layout = "CNAB400"
                Case "756"
                    CobreBemX.ArquivoRemessa.Layout = "FEBRABAN240"
                Case Else
                    CobreBemX.ArquivoRemessa.Layout = "CNAB400"
            End Select


        End If
        Dim I As Integer
        For I = 0 To Me.grd1.RowCount - 1
            If Me.grd1.GetRowCellValue(I, Me.colGerar) = True Then
                If Me.Tag = "REMESSA" Then
                    Dim dtBoleto As DataTable = CarregarDataTable("SELECT Status FROM Boleto where Codigo = " & Me.grd1.GetRowCellDisplayText(I, Me.colCodigo))
                    If dtBoleto.Rows.Count > 0 Then
                        Dim strStatusBoleto As String = dtBoleto.Rows.Item(0).Item("Status").ToString
                        If strStatusBoleto = "Gerado" Then
                            MsgBox("Existem boletos que já foram gerados os arquivos, feche a tela a abra novamente!", MsgBoxStyle.Information)
                            Exit Sub
                        End If
                    End If
                End If

                Dim Boleto As Object
                Boleto = CobreBemX.DocumentosCobranca.Add
                Boleto.NumeroControle = Me.grd1.GetRowCellDisplayText(I, Me.colNumeroDocumento)

                'If Me.Tag = "REMESSA" Then
                '    Boleto.NossoNumero = Me.grd1.GetRowCellDisplayText(I, Me.colNossoNumero)
                'Else
                '    Select Case CodigoBancoBoleto
                '        Case "341"
                '            'CobreBemX.InicioNossoNumero = "00000001"
                '            'CobreBemX.FimNossoNumero = "99999999"
                '            'CobreBemX.ProximoNossoNumero = Format(intCodOrdem, "00000000")
                '            Dim strNossoNumero As String = Me.grd1.GetRowCellDisplayText(I, Me.colNossoNumero)
                '            strNossoNumero = strNossoNumero.Substring(0, strNossoNumero.Length - 1)
                '            strNossoNumero = Format(CInt(strNossoNumero), "00000000")
                '            Boleto.NossoNumero = strNossoNumero
                '        Case Else
                '            CobreBemX.InicioNossoNumero = "00001"
                '            CobreBemX.FimNossoNumero = "99999"
                '            'CobreBemX.ProximoNossoNumero = Format(intCodOrdem, "00000")

                '    End Select
                'End If

                Select Case CodigoBancoBoleto
                    Case "341"
                        'CobreBemX.InicioNossoNumero = "00000001"
                        'CobreBemX.FimNossoNumero = "99999999"
                        'CobreBemX.ProximoNossoNumero = Format(intCodOrdem, "00000000")
                        Dim strNossoNumero As String = Me.grd1.GetRowCellDisplayText(I, Me.colNossoNumero)
                        strNossoNumero = strNossoNumero.Substring(0, strNossoNumero.Length - 1)
                        strNossoNumero = Format(CInt(strNossoNumero), "00000000")
                        Boleto.NossoNumero = strNossoNumero
                    Case "104"
                        Dim strNossoNumero As String = Me.grd1.GetRowCellDisplayText(I, Me.colNossoNumero)
                        strNossoNumero = strNossoNumero.Substring(1, strNossoNumero.Length - 2)
                        strNossoNumero = Format(CInt(strNossoNumero), "000000000")
                        Boleto.NossoNumero = strNossoNumero
                    Case "756"
                        Dim strNossoNumero As String = Me.grd1.GetRowCellDisplayText(I, Me.colNossoNumero)
                        strNossoNumero = strNossoNumero.Substring(0, strNossoNumero.Length - 1)
                        strNossoNumero = Format(CInt(strNossoNumero), "0000000")
                        Boleto.NossoNumero = strNossoNumero

                        If Me.grd1.GetRowCellDisplayText(I, Me.colParcela) <> "" Then
                            Boleto.NumeroParcelaCarnet = Me.grd1.GetRowCellDisplayText(I, Me.colParcela)

                        Else
                            Boleto.NumeroParcelaCarnet = "1"

                        End If
                        
                    Case Else
                        Dim strNossoNumero As String = Me.grd1.GetRowCellDisplayText(I, Me.colNossoNumero)
                        strNossoNumero = strNossoNumero.Substring(1, strNossoNumero.Length - 2)
                        strNossoNumero = Format(CInt(strNossoNumero), "000000000")
                        Boleto.NossoNumero = strNossoNumero
                End Select

                Boleto.NumeroDocumento = Me.grd1.GetRowCellDisplayText(I, Me.colNumeroDocumento)
                Boleto.NomeSacado = Me.grd1.GetRowCellDisplayText(I, Me.colCliente)
                Boleto.CPFSacado = Me.grd1.GetRowCellDisplayText(I, Me.colCPF)
                Boleto.EnderecoSacado = Me.grd1.GetRowCellDisplayText(I, Me.colEndereco) & " " & Me.grd1.GetRowCellDisplayText(I, Me.colNumero)
                Boleto.BairroSacado = Me.grd1.GetRowCellDisplayText(I, Me.colBairro)
                Boleto.CidadeSacado = Me.grd1.GetRowCellDisplayText(I, Me.colCidade)
                Boleto.EstadoSacado = Me.grd1.GetRowCellDisplayText(I, Me.colEstado)
                Boleto.CepSacado = Me.grd1.GetRowCellDisplayText(I, Me.colCep).ToString.Replace(".", "").Replace("-", "")
                Boleto.DataDocumento = Me.grd1.GetRowCellDisplayText(I, Me.colDataEmissao)
                Boleto.DataVencimento = Me.grd1.GetRowCellDisplayText(I, Me.colVencimento)
                Boleto.ValorDocumento = Me.grd1.GetRowCellDisplayText(I, Me.colValor)

                Boleto.InstrucaoCobranca1 = Me.grd1.GetRowCellDisplayText(I, Me.colPrimeiraInstrucao)
                Boleto.InstrucaoCobranca2 = ""
                'Select Case CodigoBancoBoleto
                '    Case "756"
                '        Boleto.NumeroParcelaCarnet = I + 1
                'End Select
                Boleto.TipoDocumentoCobranca = "DM"
                Boleto.PercentualJurosDiaAtraso = Me.grd1.GetRowCellDisplayText(I, Me.colMora)

                Boleto.ProtestoDiasUteis = True
                If Me.grd1.GetRowCellDisplayText(I, Me.colDiasProtesto) <> "" Then
                    Boleto.DiasProtesto = Me.grd1.GetRowCellDisplayText(I, Me.colDiasProtesto)

                End If

                Boleto.PercentualMultaAtraso = Me.grd1.GetRowCellDisplayText(I, Me.colPerMulta)

                Boleto.PadroesBoleto.Demonstrativo = Me.grd1.GetRowCellDisplayText(I, Me.colDemonstrativo)
                Boleto.PadroesBoleto.InstrucoesCaixa = Me.grd1.GetRowCellDisplayText(I, Me.colInstrucao)

                'If Me.grd1.GetRowCellDisplayText(I, Me.colPerMulta) <> "" Then
                '    Dim dblPerMulta As Double = Me.grd1.GetRowCellDisplayText(I, Me.colPerMulta)
                '    If dblPerMulta > 0 Then
                '        Dim MDados As Object
                '        MDados = Boleto.MeusDados.Add
                '        MDados.Nome = "GeraRegistroMulta"
                '        MDados.Valor = "S"
                '    End If
                'End If
                'If Me.grd1.GetRowCellDisplayText(I, Me.colPerMulta) <> "" Then
                '    Dim dblPerMulta As Double = Me.grd1.GetRowCellDisplayText(I, Me.colPerMulta)
                '    If dblPerMulta > 0 Then
                '        Dim MDados As Object
                '        MDados = Boleto.MeusDados.Add
                '        MDados.Nome = "GeraRegistroMulta"
                '        MDados.Valor = "S"
                '    End If
                'End If
            End If
        Next
        Try
            If Me.Tag = "REMESSA" Then
                Dim strData As String = Format(My.Computer.Clock.LocalTime, "dd/MM/yy HH:mm").ToString.Replace("/", "").Replace(":", "").Replace(" ", "")
                Dim intCodOrdem As Integer = GerarCodigoOrdens("Remessa", CodBanco)
                CobreBemX.ArquivoRemessa.Arquivo = "R" & Format(intCodOrdem, "0000") & ".REM"
                CobreBemX.ArquivoRemessa.Diretorio = CaminhoPastaBoleto & "\Remessas\"
                CobreBemX.ArquivoRemessa.Sequencia = intCodOrdem
                CobreBemX.GravaArquivoRemessa()


                Select Case CodigoBancoBoleto

                    Case "756"
                        Dim reader As New StreamReader(CaminhoPastaBoleto & "\Remessas\R" & Format(intCodOrdem, "0000") & ".REM")

                        Dim linha As String = String.Empty
                        Dim strRemessa As String = ""

                        Dim strRP As String = ""

                        Do
                            linha = reader.ReadLine()
                            If linha <> "" Then
                                If linha.Length > 2 Then
                                    strRP = linha.Substring(0, 14)
                                End If

                            End If

                            If strRP.Contains("P") Then
                                strRP = linha

                                Dim strDataRecebimento As String = strRP.Substring(77, 8)
                                Dim A As Integer
                                Dim strDataVenc As String = ""
                                For A = 0 To strDataRecebimento.Length - 1
                                    Dim strD As String = strDataRecebimento.Substring(A, 2)

                                    Select Case A
                                        Case 0
                                            strDataVenc = strD
                                        Case 2
                                            strDataVenc &= "/" & strD
                                        Case 4
                                            strDataVenc &= "/" & strD
                                        Case 6
                                            strDataVenc &= strD
                                    End Select
                                    A += 1
                                Next

                                Dim dtData As Date = strDataVenc
                                strDataRecebimento = Format(dtData.AddDays(1), "ddMMyyyy")
                                Dim strAjuste As String = strRP.Substring(0, 58)
                                linha = strAjuste
                                linha &= "0"
                                strAjuste = strRP.Substring(59, 59)
                                linha &= strAjuste
                                linha &= strDataRecebimento
                                strAjuste = strRP.Substring(126, 94)
                                linha &= strAjuste

                                linha &= "1"
                                linha &= "05"
                                strAjuste = strRP.Substring(223, 17)
                                linha &= strAjuste
                            End If

                            If strRP.Contains("75699999") Then
                                strRemessa &= linha
                                Exit Do
                            Else
                                strRemessa &= linha & vbCrLf
                            End If

                            If (linha Is Nothing) Then
                                Exit Do
                            End If
                        Loop

                        reader.Close()


                        Dim SW As New StreamWriter(CaminhoPastaBoleto & "\Remessas\R" & Format(intCodOrdem, "0000") & ".REM")

                        SW.WriteLine(strRemessa)
                        SW.Close()
                        SW.Dispose()
                End Select

                For I = 0 To Me.grd1.RowCount - 1
                    If Me.grd1.GetRowCellValue(I, Me.colGerar) = True Then

                        Dim strCodigo As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)
                        Atualizar("UPDATE Boleto set Status = 'Gerado' where Codigo = " & strCodigo)

                    End If
                Next
                Inserir("Insert into Ordens (Cod, Tabela, CodConfig, CodBanco) Values(" & intCodOrdem & ",'Remessa'," & CodConfig & "," & CodBanco & ")")
                MsgBox("Arquivos gerados com sucesso!", MsgBoxStyle.Information)
                CarregarGrid()

            Else
                CobreBemX.ImprimeBoletos()

            End If


        Catch ex As Exception

        End Try

        CobreBemX = Nothing
    End Sub


    Private Sub RemessaBradesco()
        Dim index As Integer = -999997
        grd1.FocusedRowHandle = index
        grd1.FocusedColumn = Me.colAgencia
        grd1.ShowEditor()

        Dim strCodBanco As String
        Dim strCabecalho As String = ""
        Dim intSequencia As Integer
        Dim intQtdLinha As Integer
        Dim I As Integer

        Dim strTesteContagem As String
        Try


            For I = 0 To Me.grd1.RowCount - 1


                If Me.grd1.GetRowCellValue(I, Me.colGerar) = True Then

                    Dim dt As DataTable = CarregarDataTable("SELECT Codigo, NomeBanco, Cedente, CodigoBanco, Agencia, CodigoCedente, TipoAmbiente, CodigoTransmissao FROM Banco " & _
                    "where Codigo = " & Me.grd1.GetRowCellDisplayText(I, Me.ColCodBanco))


                    strCabecalho = "01"
                    strTesteContagem = strCabecalho.Length


                    strCabecalho &= "REMESSA"

                    strTesteContagem = strCabecalho.Length
                    strCabecalho &= "01"
                    strTesteContagem = strCabecalho.Length
                    strCabecalho &= Espaco("COBRANCA", 15, False)


                    strTesteContagem = strCabecalho.Length
                    strCabecalho &= Espaco(dt.Rows.Item(0).Item("CodigoTransmissao").ToString, 20, True)


                    'strTesteContagem = strCabecalho.Length

                    'strCabecalho &= Espaco(dt.Rows.Item(0).Item("Agencia").ToString, 4, True)
                    'strTesteContagem = strCabecalho.Length

                    'strCabecalho &= Espaco(dt.Rows.Item(0).Item("CodigoCedente").ToString, 6, True)
                    'strTesteContagem = strCabecalho.Length
                    'strCabecalho &= Espaco(" ", 10, False)
                    strTesteContagem = strCabecalho.Length
                    strCabecalho &= Espaco(dt.Rows.Item(0).Item("Cedente").ToString, 30, False)
                    strTesteContagem = strCabecalho.Length
                    strCabecalho &= dt.Rows.Item(0).Item("CodigoBanco").ToString
                    strTesteContagem = strCabecalho.Length
                    strCabecalho &= Espaco("BANCO BRADESCO", 15, False)
                    strTesteContagem = strCabecalho.Length
                    strCabecalho &= Format(Date.Today, "ddMMyy")
                    strTesteContagem = strCabecalho.Length

                    strCabecalho &= Espaco(" ", 8, False)
                    strTesteContagem = strCabecalho.Length

                    strCabecalho &= "MX"
                    strTesteContagem = strCabecalho.Length

                    Dim intCodOrdem As Integer = GerarCodigoOrdens("Remessa", Me.grd1.GetRowCellDisplayText(I, Me.ColCodBanco))
                    Inserir("Insert into Ordens (Cod, Tabela, CodConfig, CodBanco) Values(" & intCodOrdem & ",'Remessa'," & CodConfig & "," & Me.grd1.GetRowCellDisplayText(I, Me.ColCodBanco) & ")")

                    strCabecalho &= Format(intCodOrdem, "0000000")
                    strTesteContagem = strCabecalho.Length

                    strCabecalho &= Espaco(" ", 277, False)
                    strTesteContagem = strCabecalho.Length

                    strCodBanco = dt.Rows.Item(0).Item("Codigo").ToString
                    intSequencia = 1
                    strCabecalho &= Format(intSequencia, "000000")

                    strTesteContagem = strCabecalho.Length

                    intQtdLinha += 1
                    Exit For
                End If
            Next


            Dim strMovimento As String = ""
            Dim dblTotal As Double
            For I = 0 To Me.grd1.RowCount - 1
                If Me.grd1.GetRowCellValue(I, Me.colGerar) = True Then

                    Dim dtBoleto As DataTable = CarregarDataTable("SELECT Status FROM Boleto where Codigo = " & Me.grd1.GetRowCellDisplayText(I, Me.colCodigo))
                    If dtBoleto.Rows.Count > 0 Then
                        Dim strStatusBoleto As String = dtBoleto.Rows.Item(0).Item("Status").ToString
                        If strStatusBoleto = "Gerado" Then
                            MsgBox("Existem boletos que já foram gerados os arquivos, feche a tela a abra novamente!", MsgBoxStyle.Information)
                            Exit Sub
                        End If
                    End If

                    Dim dt As DataTable = CarregarDataTable("SELECT Boleto.CodBanco, Boleto.DataGravacao, Boleto.CodCli, Boleto.CodFor, " & _
                    "Boleto.NossoNumero, Boleto.PerMulta, Boleto.CodigoCarteira, Boleto.CodigoOcorrencia, Boleto.SeuNumero, Boleto.Especie, " & _
                    "Boleto.TipoAceite, Boleto.PrimeiraInstrucao, Boleto.SegundaInstrucao, Boleto.ValorMora, Boleto.ValorIOF, " & _
                    "Boleto.DataSegDesc, Boleto.Vencimento, Boleto.Valor, Boleto.DataEmissao, Boleto.DataLimite, Boleto.ValorDesconto, " & _
                    "Boleto.DiasProtesto, Boleto.NumeroDocumento, Banco.NomeBanco, Banco.Cedente, Banco.CodigoBanco, " & _
                    "Banco.CPF, Banco.Agencia, Banco.ContaCorrente, Banco.CodigoTransmissao, Boleto.DiasMora, " & _
                    "Banco.TipoAmbiente, Banco.CodigoCedente " & _
                    "FROM Boleto left join Banco on Boleto.CodBanco = Banco.Codigo " & _
                    "where Boleto.Codigo = " & Me.grd1.GetRowCellDisplayText(I, Me.colCodigo))

                    Dim strCpfCedente As String = dt.Rows.Item(0).Item("CPF").ToString
                    Dim strTipoCpfCendete As String = "01"
                    If strCpfCedente.Contains("/") = True Then
                        strTipoCpfCendete = "02"
                    End If
                    Dim strCodigoTransmissao As String = dt.Rows.Item(0).Item("CodigoTransmissao").ToString
                    Dim strCodigoCedente As String = dt.Rows.Item(0).Item("CodigoCedente").ToString
                    Dim strCodigoBanco As String = dt.Rows.Item(0).Item("CodigoBanco").ToString
                    Dim strAgencia As String = dt.Rows.Item(0).Item("Agencia").ToString
                    Dim strContaCorrente As String = dt.Rows.Item(0).Item("ContaCorrente").ToString
                    Dim strNossoNumero As String = dt.Rows.Item(0).Item("NossoNumero").ToString
                    Dim strPerMulta As String = dt.Rows.Item(0).Item("PerMulta").ToString
                    Dim strCodigoCarteira As String = dt.Rows.Item(0).Item("CodigoCarteira").ToString
                    Dim strCodigoOcorrencia As String = dt.Rows.Item(0).Item("CodigoOcorrencia").ToString
                    Dim strSeuNumero As String = dt.Rows.Item(0).Item("SeuNumero").ToString
                    Dim strEspecie As String = dt.Rows.Item(0).Item("Especie").ToString
                    Dim strTipoAceite As String = dt.Rows.Item(0).Item("TipoAceite").ToString
                    Dim strPrimeiraInstrucao As String = dt.Rows.Item(0).Item("PrimeiraInstrucao").ToString
                    Dim strSegundaInstrucao As String = dt.Rows.Item(0).Item("SegundaInstrucao").ToString
                    Dim strValorMora As String = dt.Rows.Item(0).Item("ValorMora").ToString

                    Dim strValorIOF As String = dt.Rows.Item(0).Item("ValorIOF").ToString
                    Dim strDataSegDesc As String = dt.Rows.Item(0).Item("DataSegDesc").ToString
                    Dim strVencimento As String = dt.Rows.Item(0).Item("Vencimento").ToString
                    Dim strValor As String = dt.Rows.Item(0).Item("Valor").ToString
                    Dim strDataEmissao As String = dt.Rows.Item(0).Item("DataEmissao").ToString
                    Dim strDataLimite As String = dt.Rows.Item(0).Item("DataLimite").ToString
                    Dim strValorDesconto As String = dt.Rows.Item(0).Item("ValorDesconto").ToString
                    Dim strDiasProtesto As String = dt.Rows.Item(0).Item("DiasProtesto").ToString
                    Dim strNumeroDocumento As String = dt.Rows.Item(0).Item("NumeroDocumento").ToString

                    Dim strDiasMora As String = dt.Rows.Item(0).Item("DiasMora").ToString
                    Dim strCodCli As String = dt.Rows.Item(0).Item("CodCli").ToString
                    Dim strCodFor As String = dt.Rows.Item(0).Item("CodFor").ToString
                    Dim dtCli As DataTable = Nothing
                    If strCodCli <> "NULL" And strCodCli <> "" Then
                        dtCli = CarregarDataTable("SELECT Nome,  CPF, Endereco, Numero, Bairro, CodMunicipio, Cidade, Estado, Cep, CodPais, NomePais, Telefone FROM Cliente where Codigo = " & strCodCli)
                    Else
                        If strCodFor <> "NULL" And strCodFor <> "" Then
                            dtCli = CarregarDataTable("SELECT Nome,  CPF, Endereco, Numero, Bairro, CodMunicipio, Cidade, Estado, Cep, CodPais, NomePais, Telefone FROM Fornecedor where Codigo = " & strCodFor)
                        End If
                    End If
                    Dim strNomeSacado As String = ""
                    Dim strEnderecoSacado As String = ""
                    Dim strNumeroSacado As String = ""
                    Dim strBairroSacado As String = ""
                    Dim strCepSacado As String = ""
                    Dim strMunicipioSacado As String = ""
                    Dim strUfSacado As String = ""
                    Dim strCpfSacado As String = ""
                    Dim strTipoCpfSacado As String = "01"
                    If dtCli.Rows.Count > 0 Then

                        strNomeSacado = dtCli.Rows.Item(0).Item("Nome").ToString

                        strCpfSacado = dtCli.Rows.Item(0).Item("CPF").ToString
                        If strCpfSacado.Contains("/") = True Then
                            strTipoCpfSacado = "02"
                        End If

                        strEnderecoSacado = dtCli.Rows.Item(0).Item("Endereco").ToString
                        strBairroSacado = dtCli.Rows.Item(0).Item("Bairro").ToString
                        strNumeroSacado = dtCli.Rows.Item(0).Item("Numero").ToString
                        strCepSacado = dtCli.Rows.Item(0).Item("Cep").ToString
                        strMunicipioSacado = dtCli.Rows.Item(0).Item("Cidade").ToString
                        strUfSacado = dtCli.Rows.Item(0).Item("Estado").ToString

                    End If



                    strMovimento &= "1"
                    strTesteContagem = strMovimento.Length
                    strMovimento &= Espaco("0", 5, True)
                    strMovimento &= " "
                    strMovimento &= Espaco("0", 5, True)
                    strMovimento &= Espaco("0", 7, True)
                    strMovimento &= " "

                    strMovimento &= "0"
                    strTesteContagem = strMovimento.Length
                    If strCodigoCarteira = "COM REGISTRO" Then
                        strCodigoCarteira = "09"
                    Else
                        strCodigoCarteira = "06"
                    End If

                    Dim strdd As String = strAgencia.Replace("-", "")
                    strMovimento &= Espaco(strCodigoCarteira, 3, True)
                    strMovimento &= Espaco(strAgencia.Substring(0, 4), 5, True)
                    strTesteContagem = strMovimento.Length

                    strMovimento &= Espaco(strContaCorrente.Replace("-", ""), 8, False)
                    strTesteContagem = strMovimento.Length
                    strMovimento &= Espaco(" ", 25, False)
                    strMovimento &= "000"


                    Dim dblMulta As Double
                    If strPerMulta <> "" Then


                        dblMulta = strPerMulta

                        If dblMulta <= 0 Then
                            dblMulta = 0
                            strMovimento &= "0"
                        Else

                            strMovimento &= "2"

                        End If

                    Else
                        dblMulta = 0
                        strMovimento &= "0"
                    End If

                    strPerMulta = dblMulta.ToString("0.00")
                    strMovimento &= Format(dblMulta * 100, "0000")
                    strTesteContagem = strMovimento.Length



                    Dim strIdNossoNumero As String = strNossoNumero.Substring(2, strNossoNumero.Length - 3)
                    strMovimento &= Espaco(strIdNossoNumero, 11, True)

                    strTesteContagem = strMovimento.Length
                    strIdNossoNumero = strNossoNumero.Substring(strNossoNumero.Length - 1, 1)

                    strMovimento &= strIdNossoNumero

                    Dim dblDesconto As Double = strValorDesconto
                    strMovimento &= Espaco(dblDesconto * 100, 10, True) '''''''''''''''''''''''''Valor Desconto
                    strTesteContagem = strMovimento.Length


                    strMovimento &= "2"
                    strTesteContagem = strMovimento.Length
                    strMovimento &= Espaco(" ", 1, False)
                    strTesteContagem = strMovimento.Length
                    strMovimento &= Espaco(" ", 10, False)
                    strTesteContagem = strMovimento.Length
                    strMovimento &= Espaco(" ", 1, False)
                    strTesteContagem = strMovimento.Length
                    strMovimento &= "2"
                    strTesteContagem = strMovimento.Length
                    strMovimento &= Espaco(" ", 2, False)
                    strTesteContagem = strMovimento.Length
                    strMovimento &= strCodigoOcorrencia.Substring(0, 2)
                    strTesteContagem = strMovimento.Length

                    strMovimento &= Espaco(strNumeroDocumento.Replace("-", ""), 10, False)
                    strTesteContagem = strMovimento.Length

                    strMovimento &= Format(CDate(strVencimento), "ddMMyy")
                    strTesteContagem = strMovimento.Length
                    Dim dblValor As Double = strValor
                    dblTotal += dblValor
                    strMovimento &= Espaco(dblValor * 100, 13, True)
                    strTesteContagem = strMovimento.Length

                    strMovimento &= "00000000"
                    strTesteContagem = strMovimento.Length


                    strMovimento &= "01"
                    strTesteContagem = strMovimento.Length
                    strMovimento &= "N"
                    strTesteContagem = strMovimento.Length

                    strMovimento &= Format(CDate(strDataEmissao), "ddMMyy")
                    strTesteContagem = strMovimento.Length

                    strMovimento &= strPrimeiraInstrucao.Substring(0, 2)
                    strTesteContagem = strMovimento.Length
                    strMovimento &= strSegundaInstrucao.Substring(0, 2)
                    strTesteContagem = strMovimento.Length


                    Dim dblMora As Double = strValorMora
                    strMovimento &= Espaco(Format(dblMora * 100, "0000"), 13, True)
                    strTesteContagem = strMovimento.Length

                    strMovimento &= "000000" 'Format(CDate(strDataLimite), "ddMMyy") ''''''''''''''''''''''''Data Limite
                    strTesteContagem = strMovimento.Length



                    strMovimento &= Espaco("0", 13, True) '''''''''''''''''''''''''Valor segundo desconto
                    strTesteContagem = strMovimento.Length

                    If strValorIOF = "" Then
                        strValorIOF = "0"
                    End If
                    Dim dblValorIOF As Double = strValorIOF
                    strMovimento &= Espaco(dblValorIOF * 100, 13, True) '''''''''''''''''''''''''Valor IOF
                    strTesteContagem = strMovimento.Length

                    strMovimento &= Espaco("0", 13, True) '''''''''''''''''''''''''Valor abatimento
                    strTesteContagem = strMovimento.Length

                    strMovimento &= strTipoCpfSacado
                    strTesteContagem = strMovimento.Length
                    strMovimento &= Espaco(strCpfSacado.Replace(".", "").Replace("/", "").Replace("-", ""), 14, True)
                    strTesteContagem = strMovimento.Length
                    strMovimento &= Espaco(strNomeSacado, 40, False)
                    strTesteContagem = strMovimento.Length
                    strMovimento &= Espaco(strEnderecoSacado, 34, False)
                    strTesteContagem = strMovimento.Length
                    strMovimento &= Espaco(strNumeroSacado, 6, False)
                    strTesteContagem = strMovimento.Length
                    strMovimento &= Espaco(" ", 12, False)
                    strTesteContagem = strMovimento.Length

                    strMovimento &= Espaco(strCepSacado.Replace("-", "").Replace(".", ""), 8, True)

                    strTesteContagem = strMovimento.Length

                    strMovimento &= Espaco(" ", 60, False)
                    strTesteContagem = strMovimento.Length


                    intQtdLinha += 1
                    intSequencia += 1
                    strMovimento &= Format(intSequencia, "000000") & vbCrLf
                    strTesteContagem = strMovimento.Length
                End If
            Next



            Dim strRodape As String = "9"
            strTesteContagem = strRodape.Length
            strRodape &= Espaco(" ", 393, False)
            strTesteContagem = strRodape.Length

            intSequencia += 1
            strRodape &= Format(intSequencia, "000000")
            strTesteContagem = strRodape.Length

            If strMovimento <> "" Then
                Dim strCaminho As String = ""

                Me.fbdCaminho.SelectedPath = ""
                Me.fbdCaminho.ShowDialog()
                strCaminho = fbdCaminho.SelectedPath
                If strCaminho <> "" Then
                    Dim strData As String = Format(My.Computer.Clock.LocalTime, "dd/MM/yy HH:mm").ToString.Replace("/", "").Replace(":", "").Replace(" ", "")
                    Dim strArquivoRemessa As String = strCabecalho & vbCrLf & strMovimento & strRodape & vbCrLf
                    strArquivoRemessa = RetiraAcentos(strArquivoRemessa)
                    'Inserir("INSERT INTO Ordens (Cod, Tabela, CodConfig) VALUES (" & intSequencia & ",'Remessa'," & strCodBanco & ")")
                    For I = 0 To Me.grd1.RowCount - 1
                        If Me.grd1.GetRowCellValue(I, Me.colGerar) = True Then
                            Atualizar("UPDATE Boleto set Status = 'Gerado' where Codigo = " & Me.grd1.GetRowCellDisplayText(I, Me.colCodigo))
                        End If
                    Next
                    Call SalvarArquivo(strArquivoRemessa, strCaminho & "\R" & strData & ".rem", False)

                    File.Copy(strCaminho & "\R" & strData & ".rem", "C:\NANOBoleto\Remessas\R" & strData & ".rem")
                End If


            End If

            CarregarGrid()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
    Function RetiraAcentos(ByVal Conteudo As String) As String
        Conteudo = Replace(Conteudo, "Ç", "C")
        Conteudo = Replace(Conteudo, "Á", "A")
        Conteudo = Replace(Conteudo, "À", "A")
        Conteudo = Replace(Conteudo, "Â", "A")
        Conteudo = Replace(Conteudo, "É", "E")
        Conteudo = Replace(Conteudo, "Ê", "E")
        Conteudo = Replace(Conteudo, "Í", "I")
        Conteudo = Replace(Conteudo, "Ã", "A")
        Conteudo = Replace(Conteudo, "&", "E")
        Conteudo = Replace(Conteudo, "Õ", "O")
        Conteudo = Replace(Conteudo, "Ó", "O")
        Conteudo = Replace(Conteudo, "Ô", "O")
        Conteudo = Replace(Conteudo, "Ä", "A")
        Conteudo = Replace(Conteudo, "Ë", "E")
        Conteudo = Replace(Conteudo, "Ï", "I")
        Conteudo = Replace(Conteudo, "Ö", "A")
        Conteudo = Replace(Conteudo, "Ü", "E")
        Conteudo = Replace(Conteudo, "Ú", "U")
        Conteudo = Replace(Conteudo, "º", " ")
        Conteudo = Replace(Conteudo, "º", " ")
        Conteudo = Replace(Conteudo, "ª", " ")
        Conteudo = Replace(Conteudo, "(", " ")
        Conteudo = Replace(Conteudo, ")", " ")
        RetiraAcentos = Conteudo
    End Function
    
    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub
    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged

        Select Case Me.chkTodos.Checked
            Case False
                Me.chkTodos.Text = "Marcar Todos"
                Me.chkTodos.Size = New System.Drawing.Size(103, 19)
                Todos(False)
            Case True
                Me.chkTodos.Text = "Desmarcar Todos"
                Me.chkTodos.Size = New System.Drawing.Size(127, 19)
                Todos(True)
        End Select
    End Sub
    Private Sub Todos(ByVal parTodos As Boolean)
        Dim I As Integer
        For I = 0 To Me.grd1.RowCount - 1
            Me.grd1.SetRowCellValue(I, Me.colGerar, parTodos)
        Next
    End Sub

    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        If grd1.RowCount = 0 Then Exit Sub
        Dim Index As Integer = grd1.FocusedRowHandle
        If Index < 0 Then Exit Sub
        Dim strNossoNumero As String = Me.grd1.GetRowCellDisplayText(Index, Me.colNossoNumero)
        If MsgBox("Deseja realmente excluir o boleto " & strNossoNumero & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim strCodigo As String = Me.grd1.GetRowCellDisplayText(Index, Me.colCodigo)
            If Excluir("DELETE FROM Boleto where Codigo = " & strCodigo) = True Then
                MsgBox("Boleto excluído com sucesso!")
                CarregarGrid()
            End If
        End If

    End Sub
    Public Shared Function Espaco(ByVal parCampo As String, ByVal parTamanho As Integer, ByVal parNumerico As Boolean) As String

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
End Class