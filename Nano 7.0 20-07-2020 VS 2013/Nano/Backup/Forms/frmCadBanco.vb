Imports Nano.clsFuncoes
Imports Nano.clsValidar
Public Class frmCadBanco
    Dim bolAlterar As Boolean = False
    Dim intCodigo As Integer
    Dim strCpfCnpj As String
    Dim strNome As String
    Private Sub AtualizarGrid()

        CarregarDados("SELECT Codigo, CodigoBanco, NomeBanco, ContaCorrente, Cedente, CPF, PerMulta, CodigoCarteira, CodigoOcorrencia, " & _
        "SeuNumero, Especie, TipoAceite, PrimeiraInstrucao, SegundaInstrucao, ValorMora, ValorIOF, DiasProtesto, Agencia, " & _
        "CodigoCedente, Padrao, DiasMora, CodigoTransmissao, Nome FROM Banco where CodConfig = " & CodConfig, Me.GridControl1)
    End Sub

    Private Sub frmCadBanco_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "23")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
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
        Me.txtDescricao.ResetText()
        Me.txtCedente.Focus()
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
        strNome = Me.grd1.GetRowCellDisplayText(intIndex, Me.colNome)
        Me.txtDescricao.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colNome)
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

        Me.txtCodigoTransmissao.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCodigoTransmissao)
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
        If Validar(Me.txtDescricao) = False Then Exit Sub

        If TesteConexao() = False Then Exit Sub


     



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

      
        If bolAlterar = False Then

            Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM Banco where Nome = '" & Me.txtDescricao.Text & "'")
            If dt.Rows.Count > 0 Then
                MsgBox("Descrição já cadatrada para outro banco!", MsgBoxStyle.Information)
                Me.txtDescricao.Focus()
                Exit Sub
            End If

            Inserir("INSERT INTO Banco (CodigoBanco, Nome, NomeBanco, ContaCorrente, Cedente, CPF, PerMulta, " & _
            "CodigoCarteira, CodigoOcorrencia, SeuNumero, Especie, TipoAceite, PrimeiraInstrucao, SegundaInstrucao, " & _
            "ValorMora, ValorIOF, DiasProtesto, Agencia, CodigoCedente, Padrao, DiasMora, CodigoTransmissao, CodConfig) VALUES ('" & Me.txtCodBanco.Text & "','" & Me.txtDescricao.Text & "'," & _
            "'" & Me.cboNomeBanco.Text & "','" & strContaCorrente & "','" & Me.txtCedente.Text & "','" & Me.txtCPF.Text & "'," & _
            "'" & Me.txtPerMulta.Text & "','" & Me.cboCarteira.Text & "'," & _
            "'" & Me.cboTipoOcorrencia.Text & "','" & Me.txtSeuNumero.Text & "','" & Me.cboEspecie.Text & "'," & _
            "'" & Me.txtTipoAceite.Text & "','" & Me.cboPrimeriaInstrucao.Text & "','" & Me.cboSegundaInstrucao.Text & "'," & _
            "'" & Me.txtValorMora.Text & "','" & Me.txtValorIOF.Text & "','" & Me.txtDiasProtesto.Text & "','" & strAgencia & "'," & _
            "'" & strCodCedente & "','" & Me.chkPadrao.Checked & "','" & Me.txtDiasMora.Text & "','" & Me.txtCodigoTransmissao.Text & "'," & CodConfig & ")")
        Else
            If Me.txtDescricao.Text.Trim <> strNome.Trim Then
                Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM Banco where Nome = '" & Me.txtDescricao.Text & "'")
                If dt.Rows.Count > 0 Then
                    MsgBox("Descrição já cadatrada para outro banco!", MsgBoxStyle.Information)
                    Me.txtDescricao.Focus()
                    Exit Sub
                End If
            End If
            Atualizar("UPDATE Banco SET CodigoBanco = '" & Me.txtCodBanco.Text & "', Nome = '" & Me.txtDescricao.Text & "', NomeBanco = '" & Me.cboNomeBanco.Text & "', " & _
            "ContaCorrente = '" & strContaCorrente & "', Cedente = '" & Me.txtCedente.Text & "', CPF = '" & Me.txtCPF.Text & "', " & _
            "PerMulta = '" & Me.txtPerMulta.Text & "', CodigoCarteira = '" & Me.cboCarteira.Text & "', " & _
            "CodigoOcorrencia = '" & Me.cboTipoOcorrencia.Text & "', SeuNumero = '" & Me.txtSeuNumero.Text & "', " & _
            "Especie = '" & Me.cboEspecie.Text & "', TipoAceite = '" & Me.txtTipoAceite.Text & "', " & _
            "PrimeiraInstrucao = '" & Me.cboPrimeriaInstrucao.Text & "', SegundaInstrucao = '" & Me.cboSegundaInstrucao.Text & "', " & _
            "ValorMora = '" & Me.txtValorMora.Text & "', ValorIOF = '" & Me.txtValorIOF.Text & "', " & _
            "DiasProtesto = '" & Me.txtDiasProtesto.Text & "', Agencia = '" & strAgencia & "', CodigoCedente = '" & strCodCedente & "'," & _
            "Padrao = '" & Me.chkPadrao.Checked & "', DiasMora = '" & Me.txtDiasMora.Text & "', CodigoTransmissao = '" & Me.txtCodigoTransmissao.Text & "' where Codigo = " & intCodigo)


            If Me.txtDescricao.Text.Trim <> strNome.Trim Then
                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strNome & "','" & Me.txtDescricao.Text.Trim & "','DESCRICÃO','BANCO','ALTERAÇÃO'," & CodConfig & ")")

                Atualizar("UPDATE ContaReceber set Banco = '" & Me.txtDescricao.Text & "' where Banco = '" & strNome.Trim & "'")
                Atualizar("UPDATE ContaPagar set Banco = '" & Me.txtDescricao.Text & "' where Banco = '" & strNome.Trim & "'")

            End If
        End If
        If Me.chkPadrao.Checked = True Then
            Atualizar("UPDATE Banco set Padrao = 'False'")
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

        Alterar()

    End Sub

    Private Sub cboNomeBanco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNomeBanco.SelectedIndexChanged
        Select Case Me.cboNomeBanco.SelectedIndex
            Case 0
                Me.txtCodBanco.Text = "033"
            Case 1
                Me.txtCodBanco.Text = "341"
            Case 2
                Me.txtCodBanco.Text = "104"
            Case 3
                Me.txtCodBanco.Text = "237"
            Case 4
                Me.txtCodBanco.Text = "001"
            Case 5
                Me.txtCodBanco.Text = "399"
            Case 6
                Me.txtCodBanco.Text = ""
            Case 7
                Me.txtCodBanco.Text = "756"
        End Select
    End Sub

    'Private Sub BancoSantander()
    'Me.txtCodBanco.Text = "033"
    'Me.cboCarteira.Properties.Items.Clear()
    'Me.cboCarteira.Properties.Items.Add("1 - ELETRÔNICA COM REGISTRO")
    'Me.cboCarteira.Properties.Items.Add("3 - CAUCIONADA ELETRÔNICA")
    'Me.cboCarteira.Properties.Items.Add("4 - COBRANÇA SEM REGISTRO")
    'Me.cboCarteira.Properties.Items.Add("5 - RÁPIDA COM REGISTRO")
    'Me.cboCarteira.Properties.Items.Add("6 - CAUCIONADA RÁPIDA")
    'Me.cboCarteira.Properties.Items.Add("7 - DESCONTADA ELETRÔNICA")


    'Me.cboTipoOcorrencia.Properties.Items.Clear()
    'Me.cboTipoOcorrencia.Properties.Items.Add("01 - ENTRADA DE TÍTULO")
    'Me.cboTipoOcorrencia.Properties.Items.Add("02 - BAIXA DE TÍTULO")
    'Me.cboTipoOcorrencia.Properties.Items.Add("04 - CONCESSÃO DE ABATIMENTO")
    'Me.cboTipoOcorrencia.Properties.Items.Add("05 - CANCELAMENTO ABATIMENTO")
    'Me.cboTipoOcorrencia.Properties.Items.Add("06 - PRORROGAÇÃO DE VENCIMENTO")
    'Me.cboTipoOcorrencia.Properties.Items.Add("07 - ALT. NÚMERO CONT. CEDENTE")
    'Me.cboTipoOcorrencia.Properties.Items.Add("08 - ALTERAÇÃO DO SEU NÚMERO")
    'Me.cboTipoOcorrencia.Properties.Items.Add("09 - PROTESTAR")
    'Me.cboTipoOcorrencia.Properties.Items.Add("18 - SUSTAR PROTESTO")


    'Me.cboEspecie.Properties.Items.Clear()
    'Me.cboEspecie.Properties.Items.Add("01 - DUPLICATA")
    'Me.cboEspecie.Properties.Items.Add("02 - NOTA PROMISSÓRIA")
    'Me.cboEspecie.Properties.Items.Add("03 - APÓLICE/NOTA SEGURO")
    'Me.cboEspecie.Properties.Items.Add("05 - RECIBO")
    'Me.cboEspecie.Properties.Items.Add("06 - DUPLICATA DE SERVIÇO")
    'Me.cboEspecie.Properties.Items.Add("07 - LETRA DE CAMBIO")


    'Me.cboPrimeriaInstrucao.Properties.Items.Clear()
    'Me.cboPrimeriaInstrucao.Properties.Items.Add("00 - NÃO HÁ INSTRUÇÕES")
    'Me.cboPrimeriaInstrucao.Properties.Items.Add("02 - BAIXAR APÓS QUINZE DIAS DO VENCIMENTO")
    'Me.cboPrimeriaInstrucao.Properties.Items.Add("03 - BAIXAR APÓS 30 DIAS DO VENCIMENTO")
    'Me.cboPrimeriaInstrucao.Properties.Items.Add("04 - NÃO BAIXAR")
    'Me.cboPrimeriaInstrucao.Properties.Items.Add("06 - PROTESTAR")
    'Me.cboPrimeriaInstrucao.Properties.Items.Add("07 - NÃO PROTESTAR")
    'Me.cboPrimeriaInstrucao.Properties.Items.Add("08 - NÃO COBRAR JUROS DE MORA")

    'Me.cboSegundaInstrucao.Properties.Items.Clear()
    'Me.cboSegundaInstrucao.Properties.Items.Add("00 - NÃO HÁ INSTRUÇÕES")
    'Me.cboSegundaInstrucao.Properties.Items.Add("02 - BAIXAR APÓS QUINZE DIAS DO VENCIMENTO")
    'Me.cboSegundaInstrucao.Properties.Items.Add("03 - BAIXAR APÓS 30 DIAS DO VENCIMENTO")
    'Me.cboSegundaInstrucao.Properties.Items.Add("04 - NÃO BAIXAR")
    'Me.cboSegundaInstrucao.Properties.Items.Add("06 - PROTESTAR")
    'Me.cboSegundaInstrucao.Properties.Items.Add("07 - NÃO PROTESTAR")
    'Me.cboSegundaInstrucao.Properties.Items.Add("08 - NÃO COBRAR JUROS DE MORA")
    'End Sub

    'Private Sub BancoItau()

    'End Sub
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


    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub
End Class