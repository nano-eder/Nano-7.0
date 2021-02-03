Imports Nano.clsFuncoes
Imports Nano.clsValidar

Public Class frmRecibo
    Dim intCodFunc As String

    Private Sub frmRecibo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdgDoc.SelectedIndex = 0
        Me.dtData.Text = Date.Today
        Me.txtCli.ResetText()
        Me.txtCPF.ResetText()
        Me.txtValor.ResetText()
        Me.txtValorExtenso.ResetText()

        If Me.Tag = "RECEBIMENTO" Then
            Me.LabelControl1.Visible = True
            Me.Text = "Recibo"
            Me.txtCli.Tag = "Cliente"
        ElseIf Me.Tag = "PAGAMENTO" Then
            'Me.txtCli.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            'Me.LabelControl2.Visible = True
            Me.RadioGroup1.Visible = True
            Me.RadioGroup1.SelectedIndex = 0
            Me.Text = "Recibo Pagamento"
            Me.txtCli.Tag = "Funcionário"
        End If
    End Sub

    Private Sub txtValor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "," And e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtValor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValor.Leave
        If Preco(txtValor) = False Then Exit Sub
        Dim dblValorTotal As Double = Me.txtValor.Text

        Dim strValorExt As String = dblValorTotal.ToString("0.00")
        Dim vetValor As Array
        vetValor = Split(strValorExt, ",")
        Dim strReais, strCentavos As String
        strReais = getInteger(vetValor(0))
        If vetValor(0) = "0" Then
            If vetValor(1) <> "00" Then
                strCentavos = getInteger(vetValor(1))
                strValorExt = strCentavos.ToUpper & " CENTAVOS"
            End If
        Else
            If vetValor(1) = "00" Then
                strValorExt = strReais.ToUpper & " REAIS"
            Else
                strCentavos = getInteger(vetValor(1))
                strValorExt = strReais.ToUpper & " REAIS E " & strCentavos.ToUpper & " CENTAVOS"
            End If
        End If
        Me.txtValorExtenso.Text = strValorExt

    End Sub
    Private Sub Limpar()
        Me.txtValor.ResetText()
        Me.txtValorExtenso.ResetText()
        Me.txtCli.ResetText()
        Me.txtCPF.ResetText()
        Me.txtReferente.ResetText()
        Me.dtData.ResetText()
        rdgDoc.SelectedIndex = 0
        Me.txtValor.Focus()
    End Sub
    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relReciboPag
        rel.picLogo.Image = LogoTipo
        If Me.Tag = "RECEBIMENTO" Then
           Dim dblValor As Double
            If Me.txtValor.Text <> "" Then
                dblValor = Me.txtValor.Text
            End If
            Dim I As Integer

            Dim strNomeEmpresa As String = NomeEmpresa
            If IO.File.Exists(My.Application.Info.DirectoryPath & "\RazaoSocial.txt") = True Then
                strNomeEmpresa = LerArquivo(My.Application.Info.DirectoryPath & "\RazaoSocial.txt", False).Trim
            End If
            With rel.tbRecibo.Rows
                For I = 0 To 1
                    .Add()
                    .Item(I).Item("Empresa") = strNomeEmpresa
                    If I = 0 Then

                        'rel.lblTitulo.Text = NomeEmpresa
                        .Item(I).Item("Empresa1") = strNomeEmpresa
                    Else
                        '.Item(I).Item("Empresa") = Me.txtCli.Text.Trim
                        .Item(I).Item("Empresa1") = Me.txtCli.Text.Trim
                    End If
                    .Item(I).Item("Endereco") = EnderecoEmpresa
                    .Item(I).Item("Telefone") = TelefoneEmpresa
                    '.Item(I).Item("Email") = vetTexto(4)
                    .Item(I).Item("Valor") = dblValor.ToString("###,###,###,##0.00")
                    .Item(I).Item("Via") = I + 1 & "ª VIA"
                    .Item(I).Item("ValorExtenso") = Me.txtValorExtenso.Text
                    .Item(I).Item("Cliente") = Me.txtCli.Text
                    .Item(I).Item("CPF") = Me.txtCPF.Text
                    .Item(I).Item("Referente") = Me.txtReferente.Text
                    .Item(I).Item("Data") = Me.dtData.Text

                Next
            End With
            rel.XrLabel1.Text = "RECIBO"

        ElseIf Me.Tag = "PAGAMENTO" Then
            If Validar(Me.txtCli) = False Then Exit Sub

            If Validar(Me.txtValor) = False Then Exit Sub

            If Validar(Me.dtData) = False Then
                Me.dtData.Focus()
                Exit Sub
            End If 
            If Validar(Me.txtReferente) = False Then Exit Sub

            Dim dblValor As Double
            If Me.txtValor.Text <> "" Then
                dblValor = Me.txtValor.Text
            End If

            'Inserir("INSERT INTO ReciboPagamento (CodFunc, NomeFunc, Valor, Data, Referente) VALUES (" & intCodFunc & ",'" & Me.txtCli.Text.Trim & "','" & Me.txtValor.Text.Trim & "','" & Me.dtData.Text & "','" & Me.txtReferente.Text.Trim & "')")
            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'','Cód. Func.: " & intCodFunc & " Valor R$ " & dblValor.ToString("###,###,###,##0.00") & " Data: " & Me.dtData.Text & "','FUNCIONÁRIO VALOR DATA','RECIBO PAGAMENTO','CADASTRO'," & CodConfig & ")")

            Dim strTipo As String

            If CNPJEmpresa > 14 Then
                strTipo = "J"
            Else
                strTipo = "F"
            End If

            Dim strNomeEmpresa As String = NomeEmpresa
            If IO.File.Exists(My.Application.Info.DirectoryPath & "\RazaoSocial.txt") = True Then
                strNomeEmpresa = LerArquivo(My.Application.Info.DirectoryPath & "\RazaoSocial.txt", False).Trim
            End If

            Dim I As Integer
            With rel.tbRecibo.Rows
                For I = 0 To 1
                    .Add()

                    .Item(I).Item("Empresa") = strNomeEmpresa
                    'rel.lblTitulo.Text = NomeEmpresa
                    .Item(I).Item("Empresa1") = Me.txtCli.Text
                    .Item(I).Item("Endereco") = EnderecoEmpresa
                    .Item(I).Item("Telefone") = TelefoneEmpresa
                    '.Item(I).Item("Email") = vetTexto(4)
                    .Item(I).Item("Valor") = dblValor.ToString("###,###,###,##0.00")
                    .Item(I).Item("Via") = I + 1 & "ª VIA"
                    .Item(I).Item("ValorExtenso") = Me.txtValorExtenso.Text
                    .Item(I).Item("Cliente") = strNomeEmpresa
                    .Item(I).Item("CPF") = AddPonto(CNPJEmpresa, strTipo)
                    .Item(I).Item("Referente") = Me.txtReferente.Text
                    .Item(I).Item("Data") = Me.dtData.Text

                Next
            End With
            rel.XrLabel2.Text = "Recebido de:"
            rel.XrLabel1.Text = "RECIBO PAGAMENTO"
            Limpar()
        End If
        rel.ShowPreview()

    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If MsgBox("Tem certeza que deseja limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Limpar()
        End If
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub txtCli_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCli.ButtonClick
        If Me.Tag = "RECEBIMENTO" Then
            frmCadCliente.Tag = "PESQUISA"
            CodigoDoCliente = 0
            frmCadCliente.ShowDialog()
            frmCadCliente.Tag = ""
            If CodigoDoCliente > 0 Then
                CarregarCliente(CodigoDoCliente)
                Me.dtData.Focus()
            End If
        ElseIf Me.Tag = "PAGAMENTO" Then
            If Me.RadioGroup1.SelectedIndex = 0 Then
                frmCadFuncionario.Tag = "PAGAMENTO"
                frmCadFuncionario.ShowDialog()
                frmCadFuncionario.Tag = ""

                CarregarFuncionario()
                Me.dtData.Focus()
            Else
                frmCadFornecedor.Tag = "PAGAMENTO"
                frmCadFornecedor.ShowDialog()
                frmCadFornecedor.Tag = ""

                CarregarFornecedor()
                Me.dtData.Focus()
            End If
        End If
    End Sub
    Private Sub CarregarCliente(ByVal parCPF As String)

        Dim dt As DataTable = CarregarDataTable("Select Nome, CPF from Cliente Where Codigo =" & parCPF)

        If dt.Rows.Count > 0 Then
            Me.txtCPF.Text = dt.Rows.Item(0).ItemArray(1).ToString
            Me.txtCli.Text = dt.Rows.Item(0).ItemArray(0).ToString
            If Me.txtCPF.Text.Length <= 14 Then
                Me.rdgDoc.SelectedIndex = 0
            Else
                Me.rdgDoc.SelectedIndex = 1
            End If
            'me.txtCPF.Text = parCPF
        Else
            Me.txtCPF.ResetText()
            Me.txtCli.ResetText()
            Me.txtCli.Focus()
        End If

    End Sub

    Private Sub CarregarFuncionario()
        intCodFunc = CodigoFuncionario

        Dim dtFunc As DataTable

        dtFunc = CarregarDataTable("Select Nome, CPF from Funcionario where Codigo = " & intCodFunc)

        If dtFunc.Rows.Count > 0 Then
            Me.txtCli.Text = dtFunc.Rows.Item(0).Item("Nome").ToString
            Me.txtCPF.Text = dtFunc.Rows.Item(0).Item("CPF").ToString
            If Me.txtCPF.Text.Length <= 14 Then
                Me.rdgDoc.SelectedIndex = 0
            Else
                Me.rdgDoc.SelectedIndex = 1
            End If
        Else
            Me.txtCPF.ResetText()
            Me.txtCli.ResetText()
            Me.txtCli.Focus()
        End If

    End Sub

    Private Sub CarregarFornecedor()
        Dim dtFor As DataTable = CarregarDataTable("Select Nome, CPF from Fornecedor where Codigo = " & CodigoDoFornecedor)

        If dtFor.Rows.Count > 0 Then
            Me.txtCli.Text = dtFor.Rows.Item(0).Item("Nome").ToString
            Me.txtCPF.Text = dtFor.Rows.Item(0).Item("CPF").ToString
            If Me.txtCPF.Text.Length <= 14 Then
                Me.rdgDoc.SelectedIndex = 0
            Else
                Me.rdgDoc.SelectedIndex = 1
            End If
        Else
            Me.txtCPF.ResetText()
            Me.txtCli.ResetText()
            Me.txtCli.Focus()
        End If
    End Sub

    Private Sub rdgDoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgDoc.SelectedIndexChanged
        Select Case Me.rdgDoc.SelectedIndex
            Case 0
                Me.txtCPF.ResetText()
                Me.txtCPF.Properties.MaxLength = 14
            Case 1
                Me.txtCPF.ResetText()
                Me.txtCPF.Properties.MaxLength = 18
        End Select
        Me.txtCPF.Focus()
    End Sub

    Private Sub txtCPF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCPF.KeyPress
        If Me.rdgDoc.SelectedIndex = 0 Then

            If IsNumeric(e.KeyChar) AndAlso txtCPF.Text.Length < txtCPF.Properties.MaxLength Then
                txtCPF.Text &= e.KeyChar
                txtCPF.SelectionStart = txtCPF.Text.Length
                formatacpf(txtCPF)
            End If
            e.Handled = True

        ElseIf Me.rdgDoc.SelectedIndex = 1 Then

            If IsNumeric(e.KeyChar) AndAlso txtCPF.Text.Length < txtCPF.Properties.MaxLength Then
                txtCPF.Text &= e.KeyChar
                txtCPF.SelectionStart = txtCPF.Text.Length
                Call formatacnpj(txtCPF)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub txtValor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValor.EditValueChanged

    End Sub
End Class