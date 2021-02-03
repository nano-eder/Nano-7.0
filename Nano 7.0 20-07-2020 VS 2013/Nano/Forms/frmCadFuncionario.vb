Imports Nano.clsFuncoes
imports Nano.clsValidar
Public Class frmCadFuncionario
    Dim bolAlterado As Boolean = False
    Dim cod As Integer
    Dim I As Integer
    Dim vet As Array
    Dim bolValida As Boolean = False
    Dim strNome As String
    Private Sub CarregarComboCidade(ByVal parUF As Object, ByVal parCidade As Object)
        Dim dt As DataTable
        Dim I As Integer
        dt = CarregarDataTable("SELECT Nome FROM Cidade where UF = '" & parUF.Text & "'")
        For I = 0 To dt.Rows.Count - 1
            parCidade.Properties.Items.Add(dt.Rows.Item(I).ItemArray(0))
        Next
    End Sub
    Private Sub AtualizarGrid()

        If Master = True Then
            CarregarDados("SELECT * FROM Funcionario", Me.FuncionarioGridControl)

        Else
            CarregarDados("SELECT * FROM Funcionario where CodConfig =" & CodConfig, Me.FuncionarioGridControl)

        End If
        Me.txtQtdFun.Text = Me.grd1.RowCount
    End Sub

    Private Sub frmCadFuncionario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "14")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmCadFuncionario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub
        'If TipoNano <> 5 Then
        '    Me.lblComServ.Visible = False
        '    Me.txtComServ.Visible = False
        'End If
        AtualizarGrid()
        CarregarComboCidade(Me.cboUF, Me.cboCidade)

      
        bolValida = True

        If QtdeLoja > 1 Then

            CarregarDadosLue("Select Codigo, Descricao from Config", Me.lueLoja)

            Me.colCodConfig.Visible = Master
            Me.lblLoja.Visible = Master
            Me.lueLoja.Visible = Master
        Else
            Me.colCodConfig.Visible = False
            Me.lblLoja.Visible = False
            Me.lueLoja.Visible = False

        End If

        
        Me.chkCPF.Visible = False
        Me.txtCpf.Enabled = True
        Me.txtNome.Focus()
        Me.cboUF.Text = UFEmpresa
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)
    End Sub

    Private Sub Limpar()
        Me.lueLoja.EditValue = DBNull.Value
        CarregarDadosLue("Select Codigo, Descricao from Config", Me.lueLoja)

        Me.txtComServ.ResetText()
        Me.txtNome.ResetText()
        Me.txtCpf.ResetText()
        Me.txtTel.ResetText()
        Me.txtRG.ResetText()
        Me.txtCel.ResetText()
        Me.txtEnd.ResetText()
        Me.txtBai.ResetText()

        Me.cboUF.Text = UFEmpresa
        Me.cboCidade.SelectedIndex = -1
        CarregarComboCidade(Me.cboUF, Me.cboCidade)

        Me.dtNasc.ResetText()
        Me.dtAdim.ResetText()
        Me.txtObs.ResetText()
        Me.txtComp.ResetText()
        Me.txtFun.ResetText()
        Me.txtNome.Focus()
        Me.txtComPec.ResetText()
        Me.txtEmail.ResetText()
        Me.rdgStatus.SelectedIndex = 0
        Me.dtDemis.ResetText()
        Me.txtTipSan.ResetText()
        Me.txtAler.ResetText()
        Me.chkCPF.Visible = False
        Me.txtCpf.Enabled = True
        Me.txtCep.ResetText()
        Me.txtNum.ResetText()

        Me.txtAgencia.ResetText()
        Me.txtContaCorrente.ResetText()
        Me.txtBanco.ResetText()
        Me.txtMeta.ResetText()
        Me.NanoCampo1.ResetText()

        bolAlterado = False
    End Sub
    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick

        If TesteConexao() = False Then Exit Sub

        If Validar(Me.txtNome) = False Then Exit Sub
        If Master = True Then
            If QtdeLoja > 1 Then
                If Validar(Me.lueLoja) = False Then Exit Sub
            End If

        End If
        If Validar(Me.txtComPec) = False Then Exit Sub
        Dim bolSta As Boolean

        If Me.rdgStatus.SelectedIndex = 0 Then
            bolSta = True
        Else
            bolSta = False
        End If

        Dim dtNascimento As String
        If Me.dtNasc.Text = "" Then
            dtNascimento = Date.Today
        Else
            dtNascimento = Me.dtNasc.Text
        End If
        Dim intCodConfig As Integer = CodConfig
        If Master = True Then
            If QtdeLoja > 1 Then
                If Me.lueLoja.EditValue.ToString <> "" Then
                    intCodConfig = Me.lueLoja.EditValue
                End If
            End If
        End If
        If Me.txtComServ.Text = "" Then
            Me.txtComServ.Text = "0"
        End If

        If bolAlterado = False Then

            Inserir("INSERT INTO Funcionario (Nome, CPF, RG, Telefone, Celular, Endereco, Bairro, Cidade, " & _
            "Nascimento, Obs, PorcComissao, Funcao, DataAdmissao, DataDemissao, Email, Ativo, Sangue, Alergia, " & _
            "CEP, UF, Complemento, Num, CodConfig, Banco, Agencia, ContaCorrente, Meta, CodUser, ComServ) VALUES (" & _
            "'" & Me.txtNome.Text.Trim & "','" & Me.txtCpf.Text.Trim & "','" & Me.txtRG.Text.Trim & "'," & _
            "'" & Me.txtTel.Text.Trim & "','" & Me.txtCel.Text.Trim & "','" & Me.txtEnd.Text.Trim & "'," & _
            "'" & Me.txtBai.Text.Trim & "','" & Me.cboCidade.Text.Trim & "','" & dtNascimento & "'," & _
            "'" & Me.txtObs.Text.Trim & "','" & Me.txtComPec.Text.Trim & "','" & Me.txtFun.Text.Trim & "'," & _
            "'" & Me.dtAdim.Text.Trim & "','" & Me.dtDemis.Text.Trim & "','" & Me.txtEmail.Text.Trim & "'," & _
            "'" & bolSta & "','" & Me.txtTipSan.Text.Trim & "','" & Me.txtAler.Text.Trim & "'," & _
            "'" & Me.txtCep.Text.Trim & "','" & Me.cboUF.Text.Trim & "','" & Me.txtComp.Text.Trim & "'," & _
            "'" & Me.txtNum.Text.Trim & "'," & intCodConfig & ",'" & Me.txtBanco.Text & "'," & _
            "'" & Me.txtAgencia.Text & "','" & Me.txtContaCorrente.Text & "'," & Num(Me.txtMeta.Text) & ", " & _
            "'" & Me.NanoCampo1.Text.Trim & "','" & Me.txtComServ.Text & "')")

            MsgBox("Funcionário " & txtNome.Text.Trim & " cadastrado com sucesso!", MsgBoxStyle.Information)

        Else
            If Me.txtNome.Text.Trim <> strNome.Trim Then
                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strNome & "','" & Me.txtNome.Text.Trim & "','NOME','FUNCIONÁRIO','ALTERAÇÃO'," & CodConfig & ")")
            End If
            Atualizar("UPDATE Funcionario SET Nome = '" & Me.txtNome.Text.Trim & "', " & _
            "CPF = '" & Me.txtCpf.Text.Trim & "', RG = '" & Me.txtRG.Text.Trim & "', " & _
            "Telefone = '" & Me.txtTel.Text.Trim & "', Celular = '" & Me.txtCel.Text.Trim & "', " & _
            "Endereco = '" & Me.txtEnd.Text.Trim & "', Bairro = '" & Me.txtBai.Text.Trim & "', " & _
            "Cidade = '" & Me.cboCidade.Text.Trim & "', Nascimento = '" & dtNascimento & "', " & _
            "Obs = '" & Me.txtObs.Text & "', PorcComissao = '" & Me.txtComPec.Text.Trim & "', " & _
            "Funcao = '" & Me.txtFun.Text.Trim & "', DataAdmissao = '" & Me.dtAdim.Text.Trim & "', " & _
            "DataDemissao = '" & Me.dtDemis.Text.Trim & "', Email = '" & Me.txtEmail.Text.Trim & "', " & _
            "Ativo = '" & bolSta & "', Sangue = '" & Me.txtTipSan.Text.Trim & "', " & _
            "Alergia = '" & Me.txtAler.Text.Trim & "', CEP = '" & Me.txtCep.Text.Trim & "', " & _
            "UF = '" & Me.cboUF.Text.Trim & "', Complemento = '" & Me.txtComp.Text.Trim & "', " & _
            "Num = '" & Me.txtNum.Text.Trim & "', Meta = " & Num(Me.txtMeta.Text) & ", " & _
            "Agencia = '" & Me.txtAgencia.Text & "', ContaCorrente = '" & Me.txtContaCorrente.Text & "', " & _
            "Banco = '" & Me.txtBanco.Text & "', CodConfig = " & intCodConfig & ", " & _
            "CodUser='" & Me.NanoCampo1.Text.Trim & "', ComServ = '" & Me.txtComServ.Text & "' where Codigo = " & cod)

            MsgBox("Funcionário " & txtNome.Text.Trim & " alterado com sucesso!", MsgBoxStyle.Information)
        End If

        AtualizarGrid()

        Limpar()

    End Sub

    Private Sub Alterar()

        Me.chkCPF.Visible = True
        Me.chkCPF.BackColor = Color.Transparent
        Me.txtCpf.Enabled = False

        If grd1.FocusedRowHandle < 0 Then Exit Sub
        If grd1.RowCount = 0 Then Exit Sub
        bolAlterado = True
        cod = grd1.GetRowCellValue(grd1.FocusedRowHandle, Me.colCodigo)

        With grd1
            strNome = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colNome)
            Me.txtNome.Text = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colNome)
            Me.txtCpf.Text = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCPF)
            Me.txtCpf.Tag = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCPF)
            Me.txtTel.Text = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colTelefone)
            Me.txtCep.Text = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCEP)
            Me.cboUF.Text = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colUF)
            Me.txtComp.Text = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colComplemento)
            Me.txtNum.Text = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colNum)
            Me.txtRG.Text = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colRG)
            Me.txtCel.Text = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCelular)
            Me.txtEnd.Text = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colEndereco)
            Me.txtBai.Text = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colBairro)
            Me.cboCidade.Text = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCidade)
            Me.dtNasc.EditValue = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colNascimento)
            Me.dtAdim.EditValue = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colDataAdmissao)
            Me.txtObs.Text = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colObservacao)
            Me.txtComServ.Text = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colComServ)

            Me.txtFun.Text = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colFuncao)
            Me.txtComPec.Text = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colPorcComissao)
            Me.txtEmail.Text = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colEmail)
            If .GetRowCellValue(grd1.FocusedRowHandle, Me.colAtivo) = True Then
                Me.rdgStatus.SelectedIndex = 0
            Else
                Me.rdgStatus.SelectedIndex = 1
            End If
            Me.dtDemis.EditValue = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colDataDemissao)
            Me.txtTipSan.Text = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colSangue)
            Me.txtAler.Text = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colAlergia)

            Me.txtAgencia.Text = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colAgencia)
            Me.txtContaCorrente.Text = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colContaCorrente)
            Me.txtBanco.Text = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colBanco)
            Me.txtMeta.Text = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colMeta)
            Me.NanoCampo1.Text = .GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodUser)
            If Master = True Then
                If .GetRowCellDisplayText(.FocusedRowHandle, Me.colCodConfig).Trim <> "" Then
                    Dim dt As DataTable = CarregarDataTable("Select Descricao from Config where Codigo =" & .GetRowCellDisplayText(.FocusedRowHandle, Me.colCodConfig))

                    If dt.Rows.Count > 0 Then
                        Me.lueLoja.Text = dt.Rows.Item(0).Item("Descricao").ToString
                        Me.lueLoja.ClosePopup()
                    End If
                End If
            End If
         
        End With

    End Sub

    Private Sub btnAlterar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterar.ItemClick
        Alterar()
    End Sub


    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If MsgBox("Tem certeza que desja limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Limpar()
        End If
    End Sub

    Private Sub btnCancelar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        Dim intCod As Integer = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)

        Dim dt As DataTable = CarregarDataTable("Select CodOrdem from Comissao where CodFunc =" & intCod)

        If dt.Rows.Count > 0 Then
            MsgBox("Não é possível excluir esse funcionário porque existem comissões geradas em seu nome!" & vbCrLf & vbCrLf & "1º - Se ele mudou de loja, entre em contato com a Era Systems." & vbCrLf & "2º - Se o funcionário não trabalha mais na empresa, marque-o como inativo.", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim strNome As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colNome)
        If MsgBox("Deseja realmente excluir o funcionario " & strNome & " ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            If Excluir("DELETE FROM Funcionario where Codigo = " & intCod) = True Then
                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strNome & "','EXCLUÍDO','NOME','FUNCIONÁRIO','EXCLUSÃO'," & CodConfig & ")")
                MsgBox("Funcionario " & strNome & " excluido co sucesso.", MsgBoxStyle.Information)
                AtualizarGrid()
                Limpar()
            End If

        End If
    End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        If Me.Tag = "PAGAMENTO" Then
            CodigoFuncionario = grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodigo)
            Me.Close()
            Exit Sub
        End If
        Alterar()
    End Sub

    Private Sub txtCep_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCep.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then
            e.Handled = False
            Exit Sub
        End If
        FormatarCep(Me.txtCep)


    End Sub

    Private Sub txtCep_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCep.Leave
        If ValidarCep = True Then
            Try
                If My.Computer.Network.IsAvailable = False Then Exit Sub
            Catch ex As Exception
                Exit Sub
            End Try


            Dim ht As Hashtable = BuscaCep3(Me.txtCep.Text.Trim)
            Dim strCidade, strEnd, strBairro As String
            If ht Is Nothing Then
                ht = BuscaCep2(Me.txtCep.Text.Trim)
            End If
            Try
                If ht.Count > 0 Then
                    strEnd = ht("tipologradouro") & " " & ht("logradouro").ToString.Replace("'", "´")
                    strBairro = ht("bairro")
                    strCidade = ht("cidade")
                    Me.txtEnd.Text = strEnd.ToUpper
                    Me.txtBai.Text = strBairro.ToUpper
                    Me.cboCidade.Text = strCidade.ToUpper.Replace("'", "´")
                    Me.cboUF.Text = ht("UF")
                    Me.txtNum.Focus()
                    Exit Sub
                End If
            Catch ex As Exception

            End Try

            Me.cboUF.Focus()
        End If
       
    End Sub

    Private Sub cboUF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUF.SelectedIndexChanged
        Me.cboCidade.Properties.Items.Clear()
        Me.cboCidade.SelectedIndex = -1
        CarregarComboCidade(Me.cboUF, Me.cboCidade)
    End Sub

    

    Private Sub txtCpf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCpf.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then
            e.Handled = False
            Exit Sub
        End If
        FormatarDocumento(Me.txtCpf, "Cpf")
    End Sub

    Private Sub chkCPF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCPF.CheckedChanged
        Select Case Me.chkCPF.Checked
            Case True
                Me.txtCpf.Enabled = True
                Me.chkCPF.BackColor = Color.White
            Case False
                Me.chkCPF.BackColor = Color.Transparent
                Me.txtCpf.Enabled = False
                Me.txtCpf.Text = Me.txtCpf.Tag
        End Select
    End Sub

    Private Sub txtCpf_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCpf.Leave
        If Me.txtCpf.Text.Trim = "" Then Exit Sub
        If PesquisarFuncionario(txtCpf) = True Then Exit Sub
        If bolValida = False Then Exit Sub

        Dim cpf1 As New clsValidar

        cpf1.cpf = Me.txtCpf.Text.Trim

        If cpf1.isCpfValido() Then
            Exit Sub
        Else

            MsgBox("CPF Inválido!", MsgBoxStyle.Information)
            Me.txtCpf.ResetText()
            Me.txtCpf.Focus()
        End If
    End Sub

    Private Sub txtObs_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtObs.KeyPress, cboCidade.KeyPress
        If e.KeyChar = "'" Or e.KeyChar = "&" Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim I, J As Integer
        Dim rel As New relFuncionario
        rel.picLogo.Image = LogoTipo
        J = 0
        rel.tbFunc.Clear()
        With rel.tbFunc.Rows
            For I = 0 To Me.grd1.RowCount - 1
                .Add()
                .Item(J).Item("Nome") = Me.grd1.GetRowCellDisplayText(I, Me.colNome)
                .Item(J).Item("CPF") = Me.grd1.GetRowCellDisplayText(I, Me.colCPF)
                .Item(J).Item("RG") = Me.grd1.GetRowCellDisplayText(I, Me.colRG)
                .Item(J).Item("Telefone") = Me.grd1.GetRowCellDisplayText(I, Me.colTelefone)
                .Item(J).Item("Celular") = Me.grd1.GetRowCellDisplayText(I, Me.colCelular)

                J = J + 1
            Next
        End With

        rel.ShowPreview()
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.FuncionarioGridControl.ShowPrintPreview()
    End Sub

    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click
        Dim frm As New frmUsuarios
        frm.GroupControl1.BringToFront()
        frm.GroupControl1.Dock = DockStyle.Fill
        frm.Tag = "FUNCIONARIO"
        frm.btnAlterar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        frm.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        frm.btnLimpar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        frm.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        frm.chkInativar.Visible = False
        frm.colCodigo.Visible = True
        frm.ShowDialog()

    End Sub

    Private Sub NanoCampo1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NanoCampo1.KeyPress
        If e.KeyChar = "'" Or e.KeyChar = "&" Then
            e.Handled = True
        End If

        If Char.IsNumber(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
        If Char.IsLetter(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub
End Class