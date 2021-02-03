Imports Nano.clsFuncoes
Imports Nano.clsValidar
Public Class frmConfigBoleto
    Dim bolAlterar As Boolean = False
    Dim intCodigo As Integer
    Dim strCpfCnpj As String
    Private Sub AtualizarGrid()
        CarregarDados("SELECT Codigo, CodigoBanco, NomeBanco, ContaCorrente, Cedente, CPF, PerMulta, CodigoCarteira, CodigoOcorrencia, " & _
        "SeuNumero, Especie, TipoAceite, PrimeiraInstrucao, SegundaInstrucao, ValorMora, ValorIOF, DiasProtesto, Agencia, " & _
        "CodigoCedente, Padrao, DiasMora, CodigoTransmissao, Instrucao, Recibo, Instrucao2, TipoAmbiente, CaminhoArquivo, Nome as Descricao FROM Banco where CodConfig = " & CodConfig, Me.GridControl1)

        If UsaBoleto = True Then
            If CaminhoPastaBoleto <> "" Then
                If CobreBemNano = False Then
                    If Not IO.File.Exists(CaminhoPastaBoleto & "\Debug\NanoBoleto.exe") = True Then
                        UsaBoleto = False
                    End If
                End If
                Dim dtConfigBanco As DataTable = CarregarDataTable("SELECT Codigo, CodigoBanco, NomeBanco, Cedente, CPF, PerMulta, " & _
                "PrimeiraInstrucao, SegundaInstrucao, ValorMora, " & _
                "DiasProtesto, Agencia, CodigoCedente, DiasMora, ContaCorrente, Instrucao, " & _
                "Instrucao2, CaminhoArquivo FROM Banco where Padrao = 'True' and CodConfig = " & CodConfig)
                If dtConfigBanco.Rows.Count > 0 Then
                    CodigoBancoBoleto = dtConfigBanco.Rows.Item(0).Item("CodigoBanco").ToString
                    DemonstrativoBanco = dtConfigBanco.Rows.Item(0).Item("Instrucao").ToString
                    InstrucaoBanco = dtConfigBanco.Rows.Item(0).Item("Instrucao2").ToString
                    CodBanco = dtConfigBanco.Rows.Item(0).Item("Codigo").ToString
                    PerMultaBanco = dtConfigBanco.Rows.Item(0).Item("PerMulta").ToString
                    PrimeiraInstrucaoBanco = dtConfigBanco.Rows.Item(0).Item("PrimeiraInstrucao").ToString
                    SegundaInstrucaoBanco = dtConfigBanco.Rows.Item(0).Item("SegundaInstrucao").ToString
                    MoraBanco = dtConfigBanco.Rows.Item(0).Item("ValorMora").ToString
                    DiasProtestoBanco = dtConfigBanco.Rows.Item(0).Item("DiasProtesto").ToString
                    DiasMoraBanco = dtConfigBanco.Rows.Item(0).Item("DiasMora").ToString
                    CaminhoArquivoBoleto = dtConfigBanco.Rows.Item(0).Item("CaminhoArquivo").ToString
                    AgenciaBanco = dtConfigBanco.Rows.Item(0).Item("Agencia").ToString
                    ContaCorrenteBanco = dtConfigBanco.Rows.Item(0).Item("ContaCorrente").ToString
                    CodigoCedenteBanco = dtConfigBanco.Rows.Item(0).Item("CodigoCedente").ToString
                    CPFCedente = dtConfigBanco.Rows.Item(0).Item("CPF").ToString
                    NomeCedente = dtConfigBanco.Rows.Item(0).Item("Cedente").ToString
                Else
                    UsaBoleto = False
                End If
            Else
                UsaBoleto = False
            End If

        End If
    End Sub

    Private Sub frmConfigNfe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub
        Me.rdgDoc.SelectedIndex = 1
        AtualizarGrid()
        Limpar()

        If Me.Tag = "BOLETO" Then
            Me.btnAlterar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
    End Sub
    Private Sub Limpar()
        Me.txtDescricao.ResetText()
        Me.txtCaminhoArquivo.ResetText()
        Me.chkrecibo.Checked = False
        Me.txtInstrucao.ResetText()
        Me.txtInstrucao2.ResetText()
        Me.chkPadrao.Checked = False
        Me.txtCedente.ResetText()
        Me.txtCPF.ResetText()
        Me.cboNomeBanco.SelectedIndex = -1
        Me.txtCodBanco.ResetText()
        Me.txtContaCorrente.ResetText()
        Me.cboCarteira.SelectedIndex = -1
        Me.cboTipoOcorrencia.SelectedIndex = -1
        Me.txtSeuNumero.ResetText()
        Me.cboEspecie.SelectedIndex = -1
        Me.txtPerMulta.ResetText()
        Me.txtValorMora.ResetText()
        Me.txtTipoAceite.Text = "N"
        Me.txtValorIOF.ResetText()
        Me.cboPrimeriaInstrucao.SelectedIndex = -1
        Me.cboSegundaInstrucao.SelectedIndex = -1
        Me.txtDiasProtesto.ResetText()

        Me.rdgDoc.SelectedIndex = 1
        Me.txtDvCedente.ResetText()
        Me.txtDvAgencia.ResetText()
        Me.txtAgencia.ResetText()
        Me.txtCodCedente.ResetText()
        Me.txtDvContaCorrente.ResetText()
        Me.txtDiasMora.ResetText()
        Me.txtCodigoTransmissao.ResetText()
        Me.txtCedente.Focus()
        Me.cboTipoAmbiente.SelectedIndex = 0
        bolAlterar = False
    End Sub
    Private Sub Alterar()
        Dim intIndex As Integer = Me.grd1.FocusedRowHandle
        bolAlterar = True

        intCodigo = Me.grd1.GetRowCellValue(intIndex, Me.colCodigo)
        Me.txtCedente.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCedente)
        If Me.grd1.GetRowCellDisplayText(intIndex, Me.colCPF).Length <= 14 Then
            Me.rdgDoc.SelectedIndex = 0
        Else
            Me.rdgDoc.SelectedIndex = 1
        End If
        Me.txtCPF.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCPF)

        Me.cboNomeBanco.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colNomeBanco)
        Me.txtCodBanco.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCodigoBanco)

        Me.cboCarteira.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCodigoCarteira)
        Me.cboTipoOcorrencia.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCodigoOcorrencia)
        Me.txtSeuNumero.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colSeuNumero)
        Me.cboEspecie.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colEspecie)
        Me.txtPerMulta.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colPerMulta)
        Me.txtValorMora.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colValorMora)
        Me.txtDiasMora.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colDiasMora)
        Me.txtTipoAceite.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colTipoAceite)
        Me.txtValorIOF.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colValorIOF)
        Me.cboPrimeriaInstrucao.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colPrimeiraInstrucao)
        Me.cboSegundaInstrucao.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colSegundaInstrucao)
        Me.txtDiasProtesto.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colDiasProtesto)
        Me.chkPadrao.Checked = Me.grd1.GetRowCellValue(intIndex, Me.colPadrao)
        Me.chkrecibo.Checked = Me.grd1.GetRowCellValue(intIndex, Me.colRecibo)
        Me.txtInstrucao.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colInstrucao)
        Me.txtInstrucao2.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colInstrucao2)
        If Me.grd1.GetRowCellDisplayText(intIndex, Me.colAgencia).Contains("-") = True Then
            Dim vetAgencia As Array = Split(Me.grd1.GetRowCellDisplayText(intIndex, Me.colAgencia), "-")
            Me.txtAgencia.Text = vetAgencia(0)
            Me.txtDvAgencia.Text = vetAgencia(1)
        Else
            Me.txtAgencia.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colAgencia)
        End If

        If Me.grd1.GetRowCellDisplayText(intIndex, Me.colCodigoCedente).Contains("-") = True Then
            Dim vetCedente As Array = Split(Me.grd1.GetRowCellDisplayText(intIndex, Me.colCodigoCedente), "-")
            Me.txtCodCedente.Text = vetCedente(0)
            Me.txtDvCedente.Text = vetCedente(1)
        Else
            Me.txtCodCedente.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCodigoCedente)
        End If

        If Me.grd1.GetRowCellDisplayText(intIndex, Me.colContaCorrente).Contains("-") = True Then
            Dim vetCedente As Array = Split(Me.grd1.GetRowCellDisplayText(intIndex, Me.colContaCorrente), "-")
            Me.txtContaCorrente.Text = vetCedente(0)
            Me.txtDvContaCorrente.Text = vetCedente(1)
        Else
            Me.txtContaCorrente.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colContaCorrente)
        End If

        Me.txtDescricao.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colDescricao)
        Me.txtCaminhoArquivo.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCaminhoArquivo)
        Me.txtCodigoTransmissao.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCodigoTransmissao)
        Me.cboTipoAmbiente.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colTipoAmbiente)
        Me.txtCedente.Focus()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub


    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick

        If Validar(Me.txtCedente) = False Then Exit Sub
        If Validar(Me.txtCPF) = False Then Exit Sub
        If Validar(Me.cboNomeBanco) = False Then Exit Sub
        'If Validar(Me.cboTipoOcorrencia) = False Then Exit Sub
        'If Validar(Me.cboCarteira) = False Then Exit Sub
        If Validar(Me.txtCodBanco) = False Then Exit Sub
        'If Validar(Me.cboTipoAmbiente) = False Then Exit Sub

        If TesteConexao() = False Then Exit Sub

        Select Case Me.txtCodBanco.Text
            Case "033"
                If Me.txtAgencia.Text.Length <> 4 Then
                    MsgBox("Agência deve conter 4 caracteres!", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Case "104"
                If Me.txtAgencia.Text.Length <> 4 Then
                    MsgBox("Agência deve conter 4 caracteres!", MsgBoxStyle.Information)
                    Exit Sub
                End If
                'If Me.txtCodCedente.Text.Length <> 6 Then
                '    MsgBox("Código Cedente deve conter 6 caracteres!", MsgBoxStyle.Information)
                '    Exit Sub
                'End If
        End Select

        Dim strAgencia As String = Me.txtAgencia.Text
        If Me.txtDvAgencia.Text <> "" Then
            strAgencia = strAgencia & "-" & Me.txtDvAgencia.Text
        End If

        Dim strCodCedente As String = Me.txtCodCedente.Text
        If Me.txtDvCedente.Text <> "" Then
            strCodCedente = strCodCedente & "-" & Me.txtDvCedente.Text
        End If

        Dim strContaCorrente As String = Me.txtContaCorrente.Text
        If Me.txtDvContaCorrente.Text <> "" Then
            strContaCorrente = strContaCorrente & "-" & Me.txtDvContaCorrente.Text
        End If

        If Me.chkPadrao.Checked = True Then
            Atualizar("UPDATE Banco set Padrao = 'False' where CodConfig = " & CodConfig)
        End If
        If bolAlterar = False Then

            Inserir("INSERT INTO Banco (CodigoBanco, NomeBanco, ContaCorrente, Cedente, CPF, PerMulta, " & _
            "CodigoCarteira, CodigoOcorrencia, SeuNumero, Especie, TipoAceite, PrimeiraInstrucao, SegundaInstrucao, " & _
            "ValorMora, ValorIOF, DiasProtesto, Agencia, CodigoCedente, Padrao, DiasMora, CodigoTransmissao, " & _
            "CodConfig, Instrucao, Recibo, Instrucao2, TipoAmbiente, CaminhoArquivo, Nome) VALUES ('" & Me.txtCodBanco.Text & "','" & Me.cboNomeBanco.Text & "'," & _
            "'" & strContaCorrente & "','" & Me.txtCedente.Text & "','" & Me.txtCPF.Text & "'," & _
            "'" & Me.txtPerMulta.Text & "','" & Me.cboCarteira.Text & "','" & Me.cboTipoOcorrencia.Text & "'," & _
            "'" & Me.txtSeuNumero.Text & "','" & Me.cboEspecie.Text & "','" & Me.txtTipoAceite.Text & "'," & _
            "'" & Me.cboPrimeriaInstrucao.Text & "','" & Me.cboSegundaInstrucao.Text & "','" & Me.txtValorMora.Text & "'," & _
            "'" & Me.txtValorIOF.Text & "','" & Me.txtDiasProtesto.Text & "','" & strAgencia & "'," & _
            "'" & strCodCedente & "','" & Me.chkPadrao.Checked & "','" & Me.txtDiasMora.Text & "'," & _
            "'" & Me.txtCodigoTransmissao.Text & "'," & CodConfig & ",'" & Me.txtInstrucao.Text & "','" & Me.chkrecibo.Checked & "'," & _
            "'" & Me.txtInstrucao2.Text & "','" & Me.cboTipoAmbiente.Text & "','" & Me.txtCaminhoArquivo.Text & "','" & Me.txtDescricao.Text & "')")
        Else

            Atualizar("UPDATE Banco SET CodigoBanco = '" & Me.txtCodBanco.Text & "', NomeBanco = '" & Me.cboNomeBanco.Text & "', " & _
            "ContaCorrente = '" & strContaCorrente & "', Cedente = '" & Me.txtCedente.Text & "', CPF = '" & Me.txtCPF.Text & "', " & _
            "PerMulta = '" & Me.txtPerMulta.Text & "', CodigoCarteira = '" & Me.cboCarteira.Text & "', " & _
            "CodigoOcorrencia = '" & Me.cboTipoOcorrencia.Text & "', SeuNumero = '" & Me.txtSeuNumero.Text & "', " & _
            "Especie = '" & Me.cboEspecie.Text & "', TipoAceite = '" & Me.txtTipoAceite.Text & "', " & _
            "PrimeiraInstrucao = '" & Me.cboPrimeriaInstrucao.Text & "', SegundaInstrucao = '" & Me.cboSegundaInstrucao.Text & "', " & _
            "ValorMora = '" & Me.txtValorMora.Text & "', ValorIOF = '" & Me.txtValorIOF.Text & "', " & _
            "DiasProtesto = '" & Me.txtDiasProtesto.Text & "', Agencia = '" & strAgencia & "', CodigoCedente = '" & strCodCedente & "'," & _
            "Padrao = '" & Me.chkPadrao.Checked & "', DiasMora = '" & Me.txtDiasMora.Text & "', " & _
            "CodigoTransmissao = '" & Me.txtCodigoTransmissao.Text & "', Instrucao = '" & Me.txtInstrucao.Text & "', " & _
            "Recibo = '" & Me.chkrecibo.Checked & "', Instrucao2 = '" & Me.txtInstrucao2.Text & "', " & _
            "TipoAmbiente = '" & Me.cboTipoAmbiente.Text & "', CaminhoArquivo = '" & Me.txtCaminhoArquivo.Text & "', Nome = '" & Me.txtDescricao.Text & "' where Codigo = " & intCodigo)

        End If

        MsgBox("Dados salvos com sucesso!", MsgBoxStyle.Information)

        AtualizarGrid()
        Limpar()
    End Sub
    Private Sub rdgDoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgDoc.SelectedIndexChanged

        Select Case Me.rdgDoc.SelectedIndex
            Case 0
                strCpfCnpj = "Cpf"
            Case 1
                strCpfCnpj = "Cnpj"
        End Select
        Me.txtCPF.ResetText()
        Me.txtCPF.Focus()
    End Sub
    Private Sub txtCPF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCPF.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
        FormatarDocumento(Me.txtCPF, strCpfCnpj)
    End Sub

    Private Sub txtCPF_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCPF.Leave
        If Me.txtCPF.Text.Trim = "" Then Exit Sub
        'If PesquisarCliente(txtCPF) = False Then Exit Sub
        If ValidaCPF(Me.txtCPF.Text.Trim) = False Then
            Me.txtCPF.ResetText()
            Me.txtCPF.Focus()
        End If

        If Me.txtCPF.Text.Trim = "000.000.000-00" Or Me.txtCPF.Text.Trim = "00.000.000/0000-00" Then
            Me.txtCPF.ResetText()
        End If
    End Sub

    Private Sub btnAlterar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterar.ItemClick
        Alterar()
    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If MsgBox("Tem certeza que deseja limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Limpar()
        End If

    End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick

        If Me.Tag = "BOLETO" Then
            If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
            Dim strNomeBanco As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colNomeBanco)
            'If strNomeBanco <> "SANTANDER" Then
            '    MsgBox("Por enquanto o sistema só gera boletos santander!", MsgBoxStyle.Information)
            '    Exit Sub
            'End If
            'CodigoBanco = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)

            Me.Close()
            Exit Sub
        Else
            Alterar()
        End If

    End Sub

    Private Sub cboNomeBanco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNomeBanco.SelectedIndexChanged
        Select Case Me.cboNomeBanco.SelectedIndex
            Case 0
                BancoSantander()
            Case 1
                BancoItau()
            Case 2
                BancoCaixa()
            Case 3
                BancoBradesco()

            Case 4
                BancoBancoDoBrasil()
            Case 5
                BancoSantander()
                Me.txtCodBanco.Text = "756"
        End Select
    End Sub
    Private Sub BancoBancoDoBrasil()
        Me.txtCodBanco.Text = "001"
        'Me.cboCarteira.Properties.Items.Clear()
        'Me.cboCarteira.Properties.Items.Add("1 - ELETRÔNICA COM REGISTRO")
        'Me.cboCarteira.Properties.Items.Add("3 - CAUCIONADA ELETRÔNICA")
        'Me.cboCarteira.Properties.Items.Add("4 - COBRANÇA SEM REGISTRO")
        'Me.cboCarteira.Properties.Items.Add("5 - RÁPIDA COM REGISTRO")
        'Me.cboCarteira.Properties.Items.Add("6 - CAUCIONADA RÁPIDA")
        'Me.cboCarteira.Properties.Items.Add("7 - DESCONTADA ELETRÔNICA")

        Me.cboTipoOcorrencia.Properties.Items.Clear()
        Me.cboTipoOcorrencia.Properties.Items.Add("01 - ENTRADA DE TÍTULO")
        Me.cboTipoOcorrencia.Properties.Items.Add("02 - BAIXA DE TÍTULO")
        Me.cboTipoOcorrencia.Properties.Items.Add("04 - CONCESSÃO DE ABATIMENTO")
        Me.cboTipoOcorrencia.Properties.Items.Add("05 - CANCELAMENTO ABATIMENTO")
        Me.cboTipoOcorrencia.Properties.Items.Add("06 - PRORROGAÇÃO DE VENCIMENTO")
        Me.cboTipoOcorrencia.Properties.Items.Add("07 - ALT. NÚMERO CONT. CEDENTE")
        Me.cboTipoOcorrencia.Properties.Items.Add("08 - ALTERAÇÃO DO SEU NÚMERO")
        Me.cboTipoOcorrencia.Properties.Items.Add("09 - PROTESTAR")
        Me.cboTipoOcorrencia.Properties.Items.Add("18 - SUSTAR PROTESTO")


        Me.cboEspecie.Properties.Items.Clear()
        Me.cboEspecie.Properties.Items.Add("01 - DUPLICATA")
        Me.cboEspecie.Properties.Items.Add("02 - NOTA PROMISSÓRIA")
        Me.cboEspecie.Properties.Items.Add("03 - NOTA SEGURO")
        Me.cboEspecie.Properties.Items.Add("05 - RECIBO")
        Me.cboEspecie.Properties.Items.Add("08 - LETRA DE CAMBIO")


        Me.cboPrimeriaInstrucao.Properties.Items.Clear()
        Me.cboPrimeriaInstrucao.Properties.Items.Add("00 - NÃO HÁ INSTRUÇÕES")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("01 - COBRAR JUROS")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("03 - PROTESTAR 3º DIA UTIL APOS VENCIMENTO")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("04 - PROTESTAR 4º DIA UTIL APOS VENCIMENTO")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("05 - PROTESTAR 5º DIA UTIL APOS VENCIMENTO")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("06 - PROTESTAR")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("07 - NÃO PROTESTAR")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("10 - PROTESTAR 10º DIA CORRIDO APOS VENCIMENTO")

        Me.cboSegundaInstrucao.Properties.Items.Clear()
        Me.cboSegundaInstrucao.Properties.Items.Add("00 - NÃO HÁ INSTRUÇÕES")
        Me.cboSegundaInstrucao.Properties.Items.Add("01 - COBRAR JUROS")
        Me.cboSegundaInstrucao.Properties.Items.Add("03 - PROTESTAR 3º DIA UTIL APOS VENCIMENTO")
        Me.cboSegundaInstrucao.Properties.Items.Add("04 - PROTESTAR 4º DIA UTIL APOS VENCIMENTO")
        Me.cboSegundaInstrucao.Properties.Items.Add("05 - PROTESTAR 5º DIA UTIL APOS VENCIMENTO")
        Me.cboSegundaInstrucao.Properties.Items.Add("06 - PROTESTAR")
        Me.cboSegundaInstrucao.Properties.Items.Add("07 - NÃO PROTESTAR")
        Me.cboSegundaInstrucao.Properties.Items.Add("10 - PROTESTAR 10º DIA CORRIDO APOS VENCIMENTO")

        Me.txtDvAgencia.Enabled = True
        Me.txtDvCedente.Enabled = True

        Me.cboTipoOcorrencia.SelectedIndex = 0
        Me.cboTipoOcorrencia.Enabled = False
        Me.cboEspecie.SelectedIndex = 0
        Me.cboEspecie.Enabled = False
        Me.cboPrimeriaInstrucao.SelectedIndex = 0
        'Me.cboPrimeriaInstrucao.Enabled = False
        Me.cboSegundaInstrucao.SelectedIndex = 0
        'Me.cboSegundaInstrucao.Enabled = False
        Me.txtTipoAceite.Text = "N"
        Me.txtTipoAceite.Enabled = False
    End Sub
    Private Sub BancoSantander()
        Me.txtCodBanco.Text = "033"
        'Me.cboCarteira.Properties.Items.Clear()
        'Me.cboCarteira.Properties.Items.Add("1 - ELETRÔNICA COM REGISTRO")
        'Me.cboCarteira.Properties.Items.Add("3 - CAUCIONADA ELETRÔNICA")
        'Me.cboCarteira.Properties.Items.Add("4 - COBRANÇA SEM REGISTRO")
        'Me.cboCarteira.Properties.Items.Add("5 - RÁPIDA COM REGISTRO")
        'Me.cboCarteira.Properties.Items.Add("6 - CAUCIONADA RÁPIDA")
        'Me.cboCarteira.Properties.Items.Add("7 - DESCONTADA ELETRÔNICA")



        Me.cboTipoOcorrencia.Properties.Items.Clear()
        Me.cboTipoOcorrencia.Properties.Items.Add("01 - ENTRADA DE TÍTULO")
        Me.cboTipoOcorrencia.Properties.Items.Add("02 - BAIXA DE TÍTULO")
        Me.cboTipoOcorrencia.Properties.Items.Add("04 - CONCESSÃO DE ABATIMENTO")
        Me.cboTipoOcorrencia.Properties.Items.Add("05 - CANCELAMENTO ABATIMENTO")
        Me.cboTipoOcorrencia.Properties.Items.Add("06 - PRORROGAÇÃO DE VENCIMENTO")
        Me.cboTipoOcorrencia.Properties.Items.Add("07 - ALT. NÚMERO CONT. CEDENTE")
        Me.cboTipoOcorrencia.Properties.Items.Add("08 - ALTERAÇÃO DO SEU NÚMERO")
        Me.cboTipoOcorrencia.Properties.Items.Add("09 - PROTESTAR")
        Me.cboTipoOcorrencia.Properties.Items.Add("18 - SUSTAR PROTESTO")


        Me.cboEspecie.Properties.Items.Clear()
        Me.cboEspecie.Properties.Items.Add("01 - DUPLICATA")
        Me.cboEspecie.Properties.Items.Add("02 - NOTA PROMISSÓRIA")
        Me.cboEspecie.Properties.Items.Add("03 - APÓLICE/NOTA SEGURO")
        Me.cboEspecie.Properties.Items.Add("05 - RECIBO")
        Me.cboEspecie.Properties.Items.Add("06 - DUPLICATA DE SERVIÇO")
        Me.cboEspecie.Properties.Items.Add("07 - LETRA DE CAMBIO")


        Me.cboPrimeriaInstrucao.Properties.Items.Clear()
        Me.cboPrimeriaInstrucao.Properties.Items.Add("00 - NÃO HÁ INSTRUÇÕES")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("02 - BAIXAR APÓS QUINZE DIAS DO VENCIMENTO")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("03 - BAIXAR APÓS 30 DIAS DO VENCIMENTO")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("04 - NÃO BAIXAR")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("06 - PROTESTAR")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("07 - NÃO PROTESTAR")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("08 - NÃO COBRAR JUROS DE MORA")

        Me.cboSegundaInstrucao.Properties.Items.Clear()
        Me.cboSegundaInstrucao.Properties.Items.Add("00 - NÃO HÁ INSTRUÇÕES")
        Me.cboSegundaInstrucao.Properties.Items.Add("02 - BAIXAR APÓS QUINZE DIAS DO VENCIMENTO")
        Me.cboSegundaInstrucao.Properties.Items.Add("03 - BAIXAR APÓS 30 DIAS DO VENCIMENTO")
        Me.cboSegundaInstrucao.Properties.Items.Add("04 - NÃO BAIXAR")
        Me.cboSegundaInstrucao.Properties.Items.Add("06 - PROTESTAR")
        Me.cboSegundaInstrucao.Properties.Items.Add("07 - NÃO PROTESTAR")
        Me.cboSegundaInstrucao.Properties.Items.Add("08 - NÃO COBRAR JUROS DE MORA")

        Me.txtDvAgencia.Enabled = True
        Me.txtDvCedente.Enabled = True

        Me.cboTipoOcorrencia.SelectedIndex = 0
        Me.cboTipoOcorrencia.Enabled = False
        Me.cboEspecie.SelectedIndex = 0
        Me.cboEspecie.Enabled = False
        Me.cboPrimeriaInstrucao.SelectedIndex = 0
        'Me.cboPrimeriaInstrucao.Enabled = False
        Me.cboSegundaInstrucao.SelectedIndex = 0
        'Me.cboSegundaInstrucao.Enabled = False
        Me.txtTipoAceite.Text = "N"
        Me.txtTipoAceite.Enabled = False
    End Sub

    Private Sub BancoItau()
        Me.txtCodBanco.Text = "341"

        Me.cboPrimeriaInstrucao.Properties.Items.Clear()
        Me.cboPrimeriaInstrucao.Properties.Items.Add("")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("09 - PROTESTAR")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("10 - NÃO PROTESTAR")

        Me.cboSegundaInstrucao.SelectedIndex = 0
        Me.cboSegundaInstrucao.Enabled = False
    End Sub

    Private Sub BancoCaixa()
        Me.txtCodBanco.Text = "104"

        Me.cboPrimeriaInstrucao.Properties.Items.Clear()
        Me.cboPrimeriaInstrucao.Properties.Items.Add("01 - PROTESTAR DIAS CORRIDOS")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("02 - DEVOLVER (NÃO PROTESTAR)")

        Me.txtDvAgencia.Enabled = False
        Me.txtDvCedente.Enabled = False

        Me.txtCodigoTransmissao.Enabled = False
        Me.txtCodigoTransmissao.ResetText()
        Me.cboTipoOcorrencia.SelectedIndex = 0
        Me.cboTipoOcorrencia.Enabled = False
        Me.cboEspecie.SelectedIndex = 0
        Me.cboEspecie.Enabled = False
        Me.cboPrimeriaInstrucao.SelectedIndex = 1
        'Me.cboPrimeriaInstrucao.Enabled = False
        Me.cboSegundaInstrucao.SelectedIndex = 0
        Me.cboSegundaInstrucao.Enabled = False
        Me.txtTipoAceite.Text = "N"
        Me.txtTipoAceite.Enabled = False
        Me.txtDiasProtesto.Enabled = True
    End Sub


    Private Sub BancoBradesco()
        Me.txtCodBanco.Text = "237"

        Me.cboPrimeriaInstrucao.Properties.Items.Clear()
        Me.cboPrimeriaInstrucao.Properties.Items.Add("00 - NÃO INSTRUÇÕES")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("05 - PROTESTO FALIMENTAR")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("06 - PROTESTAR")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("08 - NÃO COBRAR JUROS DE MORA")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("09 - NÃO RECEBER APÓS O VENCIMENTO")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("10 - MULTAS DE 10% APÓS O 4º DIA DO VENCIMENTO")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("11 - NÃO RECEBER APÓS O 8º DIA DO VENCIMENTO")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("12 - COBRAR ENCARGOS APÓS O 5º DIA DO VENCIMENTO")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("13 - COBRAR ENCARGOS APÓS O 10º DIA DO VENCIMENTO")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("14 - COBRAR ENCARGOS APÓS O 15º DIA DO VENCIMENTO")
        Me.cboPrimeriaInstrucao.Properties.Items.Add("15 - CONCEDER DESCONTO MESMO SE PAGO APÓS O VENCIMENTO")



        Me.cboSegundaInstrucao.Properties.Items.Clear()
        Me.cboPrimeriaInstrucao.Properties.Items.Add("00 - NÃO INSTRUÇÕES")
        Me.cboSegundaInstrucao.Properties.Items.Add("05 - PROTESTO FALIMENTAR")
        Me.cboSegundaInstrucao.Properties.Items.Add("06 - PROTESTAR")
        Me.cboSegundaInstrucao.Properties.Items.Add("08 - NÃO COBRAR JUROS DE MORA")
        Me.cboSegundaInstrucao.Properties.Items.Add("09 - NÃO RECEBER APÓS O VENCIMENTO")
        Me.cboSegundaInstrucao.Properties.Items.Add("10 - MULTAS DE 10% APÓS O 4º DIA DO VENCIMENTO")
        Me.cboSegundaInstrucao.Properties.Items.Add("11 - NÃO RECEBER APÓS O 8º DIA DO VENCIMENTO")
        Me.cboSegundaInstrucao.Properties.Items.Add("12 - COBRAR ENCARGOS APÓS O 5º DIA DO VENCIMENTO")
        Me.cboSegundaInstrucao.Properties.Items.Add("13 - COBRAR ENCARGOS APÓS O 10º DIA DO VENCIMENTO")
        Me.cboSegundaInstrucao.Properties.Items.Add("14 - COBRAR ENCARGOS APÓS O 15º DIA DO VENCIMENTO")
        Me.cboSegundaInstrucao.Properties.Items.Add("15 - CONCEDER DESCONTO MESMO SE PAGO APÓS O VENCIMENTO")

        Me.txtDvAgencia.Enabled = True
        'Me.txtDvCedente.Enabled = False
        Me.txtCodigoTransmissao.Enabled = True
        Me.txtCodigoTransmissao.ResetText()
        Me.cboTipoOcorrencia.SelectedIndex = 0
        Me.cboTipoOcorrencia.Enabled = False
        Me.cboEspecie.SelectedIndex = 0
        Me.cboEspecie.Enabled = False
        Me.cboPrimeriaInstrucao.SelectedIndex = 0
        'Me.cboPrimeriaInstrucao.Enabled = False
        Me.cboSegundaInstrucao.SelectedIndex = 0
        Me.cboSegundaInstrucao.Enabled = True
        Me.txtTipoAceite.Text = "N"
        Me.txtTipoAceite.Enabled = False
        Me.txtDiasProtesto.Enabled = True
    End Sub
    Private Sub cboPrimeriaInstrucao_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPrimeriaInstrucao.Leave
        Select Case Me.cboNomeBanco.SelectedIndex
            Case 0
                If Me.cboPrimeriaInstrucao.SelectedIndex = 4 Then
                    Me.txtDiasProtesto.Enabled = True
                Else
                    If Me.cboSegundaInstrucao.SelectedIndex = 4 Then
                        Me.txtDiasProtesto.Enabled = True
                    Else
                        Me.txtDiasProtesto.ResetText()
                        Me.txtDiasProtesto.Enabled = False
                    End If
                End If
        End Select
    End Sub

    Private Sub cboSegundaInstrucao_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSegundaInstrucao.Leave
        Select Case Me.cboNomeBanco.SelectedIndex
            Case 0
                If Me.cboPrimeriaInstrucao.SelectedIndex = 4 Then
                    Me.txtDiasProtesto.Enabled = True
                Else
                    If Me.cboSegundaInstrucao.SelectedIndex = 4 Then
                        Me.txtDiasProtesto.Enabled = True
                    Else
                        Me.txtDiasProtesto.ResetText()
                        Me.txtDiasProtesto.Enabled = False
                    End If
                End If
        End Select
    End Sub

    Private Sub txtInstrucao_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInstrucao.KeyPress
        If e.KeyChar = "'" And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCaminhoArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCaminhoArquivo.Click
        Me.ofd.ShowDialog()
        Me.txtCaminhoArquivo.Text = Me.ofd.FileName
    End Sub
End Class