Imports CobreBemX
Public Class frmBoletoCobreBem

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim CobreBemX As CobreBemX.ContaCorrente
        Dim Boleto As Object

        CobreBemX = New CobreBemX.ContaCorrente

        CobreBemX.ArquivoLicenca = "C:\BoletoCobrebem\237-09.conf"
        CobreBemX.CodigoAgencia = "1234-5"
        CobreBemX.NumeroContaCorrente = "00000123-X"
        CobreBemX.CodigoCedente = "123456"
        CobreBemX.InicioNossoNumero = "00001"
        CobreBemX.FimNossoNumero = "99999"
        CobreBemX.ProximoNossoNumero = "00015"
        CobreBemX.PadroesBoleto.PadroesBoletoImpresso.ArquivoLogotipo = "C:\BoletoCobrebem\Imagens\logoEra2.png"
        CobreBemX.PadroesBoleto.PadroesBoletoImpresso.CaminhoImagensCodigoBarras = "C:\BoletoCobrebem\Imagens\"
        CobreBemX.PadroesBoleto.PadroesBoletoImpresso.LayoutBoleto = "Padrao"

        Boleto = CobreBemX.DocumentosCobranca.Add
        Boleto.NumeroDocumento = "12345"
        Boleto.NomeSacado = "Fulano de Tal"
        Boleto.CPFSacado = "111.111.111-11"
        Boleto.EnderecoSacado = "Rua do Sacado 123"
        Boleto.BairroSacado = "Bairro do Sacado"
        Boleto.CidadeSacado = "Cidade do Sacado"
        Boleto.EstadoSacado = "SP"
        Boleto.CepSacado = "01001-001"
        Boleto.DataDocumento = "01/09/2002"
        Boleto.DataVencimento = "15/09/2002"
        Boleto.ValorDocumento = 123.45
        Boleto.PadroesBoleto.Demonstrativo = "Referente a compras na WEB<br><b>O melhor site da Internet</b>"
        Boleto.PadroesBoleto.InstrucoesCaixa = "<br><br>Não dispensar juros e multa após o vencimento"

        Dim Boleto2 As Object = CobreBemX.DocumentosCobranca.Add
        Boleto2.NumeroDocumento = "12345"
        Boleto2.NomeSacado = "Fulano de Tal"
        Boleto2.CPFSacado = "111.111.111-11"
        Boleto2.EnderecoSacado = "Rua do Sacado 123"
        Boleto2.BairroSacado = "Bairro do Sacado"
        Boleto2.CidadeSacado = "Cidade do Sacado"
        Boleto2.EstadoSacado = "SP"
        Boleto2.CepSacado = "01001-001"
        Boleto2.DataDocumento = "01/09/2002"
        Boleto2.DataVencimento = "15/09/2002"
        Boleto2.ValorDocumento = 123.45
        Boleto2.PadroesBoleto.Demonstrativo = "Referente a compras na WEB<br><b>O melhor site da Internet</b>"
        Boleto2.PadroesBoleto.InstrucoesCaixa = "<br><br>Não dispensar juros e multa após o vencimento"

        'CobreBemX.GravaArquivoRemessa()
        CobreBemX.ImprimeBoletos()
        CobreBemX = Nothing
    End Sub

    '    Dim CobreBemX As CobreBemX.ContaCorrente

    '    Private Sub PassaDadosContaCorrenteParaCobreBemX()
    '        ' Início dos parâmetros obrigatórios da conta corrente
    '        CobreBemX.ArquivoLicenca = datPrimaryRS.Recordset("ArquivoLicenca")
    '        CobreBemX.CodigoAgencia = VerificaNulo(datPrimaryRS.Recordset("AgenciaCedente"))
    '        CobreBemX.NumeroContaCorrente = VerificaNulo(datPrimaryRS.Recordset("ContaCorrenteCedente"))
    '        CobreBemX.CodigoCedente = VerificaNulo(datPrimaryRS.Recordset("CodigoCedente"))
    '        CobreBemX.InicioNossoNumero = VerificaNulo(datPrimaryRS.Recordset("InicioNossoNumero"))
    '        CobreBemX.FimNossoNumero = VerificaNulo(datPrimaryRS.Recordset("FimNossoNumero"))
    '        CobreBemX.ProximoNossoNumero = VerificaNulo(datPrimaryRS.Recordset("ProximoNossoNumero"))
    '        ' Término dos parâmetros obrigatórios da conta corrente

    '        ' Início da configuração dos dados do Cedente para envio de boletos por email
    '        CobreBemX.PadroesBoleto.PadroesBoletoEmail.SMTP.Servidor = "localhost" ' Trocar para apontar para o seu servidor SMTP
    '        CobreBemX.PadroesBoleto.PadroesBoletoEmail.SMTP.Porta = 25
    '        CobreBemX.PadroesBoleto.PadroesBoletoEmail.SMTP.Usuario = "cedente" 'utilizar esta propriedade para acesso a servidores SMTP seguros
    '        CobreBemX.PadroesBoleto.PadroesBoletoEmail.SMTP.Senha = "cedente" 'utilizar esta propriedade para acesso a servidores SMTP seguros
    '        CobreBemX.PadroesBoleto.PadroesBoletoEmail.URLImagensCodigoBarras = "http://www.bptob.com/imagenscbe/"
    '        CobreBemX.PadroesBoleto.PadroesBoletoEmail.URLLogotipo = "http://www.thisf.com.br/banners/BannerCBE.gif"
    '        CobreBemX.PadroesBoleto.PadroesBoletoEmail.PadroesEmail.Assunto = "Boleto de Cobrança"
    '        CobreBemX.PadroesBoleto.PadroesBoletoEmail.PadroesEmail.EmailFrom.Endereco = VerificaNulo(datPrimaryRS.Recordset("EnderecoEmailCedente"))
    '        CobreBemX.PadroesBoleto.PadroesBoletoEmail.PadroesEmail.EmailFrom.Nome = VerificaNulo(datPrimaryRS.Recordset("NomeCedente"))
    '        CobreBemX.PadroesBoleto.PadroesBoletoEmail.PadroesEmail.FormaEnvio = feeSMTPBoletoHTML
    '        ' Término da configuração dos dados do Cedente para envio de boletos por email

    '        ' A próxima linha só é necessária se for solicitada a impressão de boletos e
    '        ' se desejar colocar o logotipo do Cedente na parte superior do boleto
    '        CobreBemX.PadroesBoleto.PadroesBoletoImpresso.ArquivoLogotipo = VerificaNulo(datPrimaryRS.Recordset("CaminhoLogotipoBoletoImpr"))

    '        ' Início da configuração dos dados do Cedente para impressão de boletos

    '        ' A próxima linha só é necessária se for solicitada a impressão de boletos e
    '        ' se desejar colocar o logotipo do Cedente na parte superior do boleto

    '        CobreBemX.PadroesBoleto.PadroesBoletoImpresso.ArquivoLogotipo = CaminhoInstalacaoCBX & "Imagens\BannerCBX.gif"
    '        CobreBemX.PadroesBoleto.PadroesBoletoImpresso.CaminhoImagensCodigoBarras = CaminhoInstalacaoCBX & "Imagens\"

    '        ' Utilize o parâmetro abaixo para efetuar ajustes na impressão do boleto subindo ou descendo o mesmo na folha de papel
    '        '  Os valores devem ser informados em milímetros e quanto maior o valor mais para baixo será iniciado o boleto
    '        '  Se este parâmetro não for passado será assumido o valor 15 que é o indicado para a maioria das impressoras Jato de Tinta }

    '        CobreBemX.PadroesBoleto.PadroesBoletoImpresso.MargemSuperior = 3

    '        ' Término da configuração dos dados do Cedente para impressão de boletos

    '        ' A próxima linha é utilizada para exibir um texto do lado direito do logotipo nos boletos impressos ou
    '        ' enviados por email
    '        CobreBemX.PadroesBoleto.IdentificacaoCedente = VerificaNulo(datPrimaryRS.Recordset("IdentificacaoCedenteBolet"))

    '    End Sub

    '    Private Sub SalvaDadosContaCorrente()
    '        txtFields(1).Text = Left$(CobreBemX.NumeroBanco, 3)
    '        txtFields(2).Text = CobreBemX.CodigoAgencia
    '        txtFields(3).Text = CobreBemX.NumeroContaCorrente
    '        txtFields(4).Text = CobreBemX.CodigoCedente
    '        txtFields(5).Text = CobreBemX.NomeCedente
    '        txtFields(6).Text = CobreBemX.CnpjCpfCedente
    '        txtFields(8).Text = CobreBemX.FimNossoNumero
    '        If txtFields(7).Text <> CobreBemX.InicioNossoNumero Then
    '            txtFields(9).Text = CobreBemX.InicioNossoNumero
    '        End If
    '        txtFields(7).Text = CobreBemX.InicioNossoNumero
    '    End Sub

    '    Private Sub PassaDadosBoletosParaCobreBemX()
    '        Dim Boleto As Object
    '        Dim Email As Object
    '        Dim rs As ADODB.Recordset
    '        CobreBemX.DocumentosCobranca.Clear()
    '        rs = datPrimaryRS.Recordset.Fields("ChildCMD").Value
    '        rs.MoveFirst()
    '        While Not rs.EOF
    '            Boleto = CobreBemX.DocumentosCobranca.Add
    '            Boleto.NumeroDocumento = VerificaNulo(rs("ChaveBoleto"))
    '            Boleto.NomeSacado = VerificaNulo(rs("NomeSacado"))
    '            If Len(VerificaNulo(rs("CNPJCPFSacado"))) > 11 Then
    '                Boleto.CNPJSacado = VerificaNulo(rs("CNPJCPFSacado"))
    '            Else
    '                Boleto.CPFSacado = VerificaNulo(rs("CNPJCPFSacado"))
    '            End If
    '            Boleto.EnderecoSacado = VerificaNulo(rs("EnderecoSacado"))
    '            Boleto.BairroSacado = VerificaNulo(rs("BairroSacado"))
    '            Boleto.CidadeSacado = VerificaNulo(rs("CidadeSacado"))
    '            Boleto.EstadoSacado = VerificaNulo(rs("EstadoSacado"))
    '            Boleto.CepSacado = VerificaNulo(rs("CEPSacado"))
    '        Boleto.DataDocumento = Format$(Date, "dd/mm/yyyy")
    '            If Not IsNull(rs("DataVencimento")) Then
    '                Boleto.DataVencimento = rs("DataVencimento")
    '            End If
    '        Boleto.DataProcessamento = Format$(Date, "dd/mm/yyyy")
    '            Boleto.ValorDocumento = VerificaNulo(rs("ValorBoleto"))
    '            Boleto.PercentualJurosDiaAtraso = VerificaNulo(rs("PercentualJuros"))
    '            Boleto.PercentualMultaAtraso = VerificaNulo(rs("PercentualMulta"))
    '            Boleto.PercentualDesconto = VerificaNulo(rs("PercentualDesconto"))
    '            Boleto.ValorOutrosAcrescimos = VerificaNulo(rs("ValorOutrosAcrescimos"))
    '            Boleto.PadroesBoleto.Demonstrativo = VerificaNulo(rs("Demonstrativo"))
    '            Boleto.PadroesBoleto.InstrucoesCaixa = VerificaNulo(rs("InstrucoesCaixa"))
    '            Email = Boleto.EnderecosEmailSacado.Add
    '            Email.Nome = Boleto.NomeSacado
    '            Email.Endereco = VerificaNulo(rs("EnderecoEmailSacado"))
    '            Boleto.ControleProcessamentoDocumento.Imprime = scpExecutar
    '            Boleto.ControleProcessamentoDocumento.EnviaEmail = scpExecutar
    '            Boleto.ControleProcessamentoDocumento.GravaRemessa = scpExecutar
    '            If Not IsNull(rs("NossoNumero")) Then
    '                Boleto.NossoNumero = rs("NossoNumero")
    '                If Len(rs("NossoNumero")) < (CobreBemX.MascaraNossoNumero + 1) Then
    '                    Boleto.CalculaDacNossoNumero = True
    '                End If
    '            End If
    '            rs.MoveNext()
    '        End While
    '    End Sub

    '    Private Sub SalvaDadosBoletos()
    '        Dim i As Integer
    '        Dim rs As ADODB.Recordset
    '        rs = datPrimaryRS.Recordset.Fields("ChildCMD").Value
    '        For i = 0 To CobreBemX.DocumentosCobranca.Count - 1
    '            rs.Find("ChaveBoleto=" & CobreBemX.DocumentosCobranca(i).NumeroDocumento)
    '            If rs("ChaveBoleto") = CobreBemX.DocumentosCobranca(i).NumeroDocumento Then
    '                If VerificaNulo(rs("NossoNumero")) <> CobreBemX.DocumentosCobranca(i).NossoNumero Then
    '                    rs("NossoNumero") = CobreBemX.DocumentosCobranca(i).NossoNumero
    '                    rs.Update()
    '                End If
    '            End If
    '        Next i
    '        If txtFields(9).Text <> CobreBemX.ProximoNossoNumero Then
    '            txtFields(9).Text = CobreBemX.ProximoNossoNumero
    '            datPrimaryRS.Recordset.Update()
    '        End If
    '    End Sub

    '    Private Sub SalvaDadosOcorrenciasCobranca()
    '        Dim i As Integer
    '        Dim rs As ADODB.Recordset
    '        rs = datPrimaryRS.Recordset.Fields("ChildCMD").Value
    '        For i = 0 To CobreBemX.OcorrenciasCobranca.Count - 1
    '            rs.Find("NossoNumero='" & CobreBemX.OcorrenciasCobranca(i).NossoNumero & "'")
    '            If rs("NossoNumero") = CobreBemX.OcorrenciasCobranca(i).NossoNumero Then
    '                If CobreBemX.OcorrenciasCobranca(i).Pagamento Then
    '                    rs("DataPagamento") = CobreBemX.OcorrenciasCobranca(i).DataOcorrencia
    '                    rs("ValorPago") = CobreBemX.OcorrenciasCobranca(i).ValorPago
    '                    rs.Update()
    '                End If
    '            End If
    '        Next i
    '    End Sub

    '    Private Sub cmdCarregarArquivoRetorno_Click()
    '        PassaDadosContaCorrenteParaCobreBemX()
    '        CobreBemX.OcorrenciasCobranca.Clear()
    '        CobreBemX.CarregaArquivosRetorno()
    '        SalvaDadosOcorrenciasCobranca()
    '        MsgBox("Pagamentos Carregados")
    '    End Sub

    '    Private Sub cmdEnviarBoletosPorEmail_Click()
    '        PassaDadosContaCorrenteParaCobreBemX()
    '        PassaDadosBoletosParaCobreBemX()
    '        CobreBemX.EnviaBoletosPorEmail()
    '        SalvaDadosBoletos()
    '        MsgBox("Boletos Enviados por email")
    '    End Sub

    '    Private Sub cmdGerarArquivoRemessa_Click()
    '        PassaDadosContaCorrenteParaCobreBemX()
    '        PassaDadosBoletosParaCobreBemX()
    '        CobreBemX.GravaArquivoRemessa()
    '        SalvaDadosBoletos()
    '        MsgBox("Arquivo de Remessa gerado")
    '    End Sub

    '    Private Sub cmdImprimirBoletos_Click()
    '        PassaDadosContaCorrenteParaCobreBemX()
    '        PassaDadosBoletosParaCobreBemX()
    '        CobreBemX.ImprimeBoletos()
    '        SalvaDadosBoletos()
    '    End Sub

    '    Private Sub Form_Load()
    '        CobreBemX = New ContaCorrente
    '        grdDataGrid.DataSource = datPrimaryRS.Recordset("ChildCMD").UnderlyingValue
    '    End Sub

    '    Private Sub Form_Resize()
    '        On Error Resume Next
    '        'This will resize the grid when the form is resized
    '        grdDataGrid.Width = Me.ScaleWidth
    '        grdDataGrid.Height = Me.ScaleHeight - grdDataGrid.Top - datPrimaryRS.Height - 30 - picButtons.Height
    '    End Sub

    '    Private Sub Form_Unload(ByVal Cancel As Integer)
    '        Screen.MousePointer = vbDefault
    '        CobreBemX = Nothing
    '    End Sub

    '    Private Sub datPrimaryRS_Error(ByVal ErrorNumber As Long, ByVal Description As String, ByVal Scode As Long, ByVal Source As String, ByVal HelpFile As String, ByVal HelpContext As Long, ByVal fCancelDisplay As Boolean)
    '        'This is where you would put error handling code
    '        'If you want to ignore errors, comment out the next line
    '        'If you want to trap them, add code here to handle them
    '        MsgBox("Data error event hit err:" & Description)
    '    End Sub

    '    Private Sub datPrimaryRS_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, ByVal adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    '        'This will display the current record position for this recordset
    '        datPrimaryRS.Caption = "Record: " & CStr(datPrimaryRS.Recordset.AbsolutePosition)
    '    End Sub

    '    Private Sub datPrimaryRS_WillChangeRecord(ByVal adReason As ADODB.EventReasonEnum, ByVal cRecords As Long, ByVal adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    '        'This is where you put validation code
    '        'This event gets called when the following actions occur
    '        Dim bCancel As Boolean

    '        Select Case adReason
    '            Case adRsnAddNew
    '            Case adRsnClose
    '            Case adRsnDelete
    '            Case adRsnFirstChange
    '            Case adRsnMove
    '            Case adRsnRequery
    '            Case adRsnResynch
    '            Case adRsnUndoAddNew
    '            Case adRsnUndoDelete
    '            Case adRsnUndoUpdate
    '            Case adRsnUpdate
    '        End Select

    '        If bCancel Then adStatus = adStatusCancel
    '    End Sub

    '    Private Sub cmdAdd_Click()
    '        On Error GoTo AddErr
    '        datPrimaryRS.Recordset.AddNew()

    '        datPrimaryRS.Recordset("ArquivoLicenca") = CaminhoInstalacaoCBX & "Exemplos\Licencas\001-18.conf"
    '        PassaDadosContaCorrenteParaCobreBemX()
    '        CobreBemX.ConfiguraContaCorrente()
    '        SalvaDadosContaCorrente()

    '        Exit Sub
    'AddErr:
    '        MsgBox(Err.Description)
    '    End Sub

    '    Private Sub cmdDelete_Click()
    '        On Error GoTo DeleteErr
    '        With datPrimaryRS.Recordset
    '            .Delete()
    '            .MoveNext()
    '            If .EOF Then .MoveLast()
    '        End With
    '        Exit Sub
    'DeleteErr:
    '        MsgBox(Err.Description)
    '    End Sub

    '    Private Sub cmdRefresh_Click()
    '        'This is only needed for multi user apps
    '        On Error GoTo RefreshErr
    '        datPrimaryRS.Refresh()
    '        grdDataGrid.DataSource = datPrimaryRS.Recordset("ChildCMD").UnderlyingValue
    '        Exit Sub
    'RefreshErr:
    '        MsgBox(Err.Description)
    '    End Sub

    '    Private Sub cmdUpdate_Click()
    '        On Error GoTo UpdateErr

    '        datPrimaryRS.Recordset.UpdateBatch(adAffectAll)
    '        Exit Sub
    'UpdateErr:
    '        MsgBox(Err.Description)
    '    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Dim CobreBemX As CobreBemX.ContaCorrente
        Dim Boleto As Object

        CobreBemX = New CobreBemX.ContaCorrente

        CobreBemX.ArquivoLicenca = "C:\BoletoCobrebem\237-09.conf"
        CobreBemX.CodigoAgencia = "1234-5"
        CobreBemX.NumeroContaCorrente = "00000123-X"
        CobreBemX.CodigoCedente = "123456"
        CobreBemX.InicioNossoNumero = "00001"
        CobreBemX.FimNossoNumero = "99999"
        CobreBemX.ProximoNossoNumero = "00015"
        CobreBemX.PadroesBoleto.PadroesBoletoImpresso.ArquivoLogotipo = "C:\BoletoCobrebem\Imagens\logoEra2.png"
        CobreBemX.PadroesBoleto.PadroesBoletoImpresso.CaminhoImagensCodigoBarras = "C:\BoletoCobrebem\Imagens\"
        CobreBemX.PadroesBoleto.PadroesBoletoImpresso.LayoutBoleto = "Padrao"

        Boleto = CobreBemX.DocumentosCobranca.Add
        Boleto.NumeroDocumento = "12345"
        Boleto.NomeSacado = "Fulano de Tal"
        Boleto.CPFSacado = "111.111.111-11"
        Boleto.EnderecoSacado = "Rua do Sacado 123"
        Boleto.BairroSacado = "Bairro do Sacado"
        Boleto.CidadeSacado = "Cidade do Sacado"
        Boleto.EstadoSacado = "SP"
        Boleto.CepSacado = "01001-001"
        Boleto.DataDocumento = "01/09/2002"
        Boleto.DataVencimento = "15/09/2002"
        Boleto.ValorDocumento = 123.45
        Boleto.PadroesBoleto.Demonstrativo = "Referente a compras na WEB<br><b>O melhor site da Internet</b>"
        Boleto.PadroesBoleto.InstrucoesCaixa = "<br><br>Não dispensar juros e multa após o vencimento"

        Dim Boleto2 As Object = CobreBemX.DocumentosCobranca.Add
        Boleto2.NumeroDocumento = "12345"
        Boleto2.NomeSacado = "Fulano de Tal"
        Boleto2.CPFSacado = "111.111.111-11"
        Boleto2.EnderecoSacado = "Rua do Sacado 123"
        Boleto2.BairroSacado = "Bairro do Sacado"
        Boleto2.CidadeSacado = "Cidade do Sacado"
        Boleto2.EstadoSacado = "SP"
        Boleto2.CepSacado = "01001-001"
        Boleto2.DataDocumento = "01/09/2002"
        Boleto2.DataVencimento = "15/09/2002"
        Boleto2.ValorDocumento = 123.45
        Boleto2.PadroesBoleto.Demonstrativo = "Referente a compras na WEB<br><b>O melhor site da Internet</b>"
        Boleto2.PadroesBoleto.InstrucoesCaixa = "<br><br>Não dispensar juros e multa após o vencimento"

        CobreBemX.GravaArquivoRemessa()
        'CobreBemX.ImprimeBoletos()
        CobreBemX = Nothing
    End Sub
End Class