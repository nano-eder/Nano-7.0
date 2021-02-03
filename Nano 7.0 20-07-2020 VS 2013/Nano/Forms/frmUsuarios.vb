Imports Nano.clsFuncoes
Imports Nano.clsGerarArqs

Public Class frmUsuarios

    Dim bolAlterado As Boolean = False
    Dim I As Integer
    Dim strCod As String
    Dim strNome As String
    Dim intCodConfig As Integer

    Dim bolInativo As Boolean
    Private Sub btnSalvar_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        Me.txtNome.Focus()
        If TesteConexao() = False Then Exit Sub

        If Validar(txtNome) = False Then Exit Sub
        If Validar(txtLogin) = False Then Exit Sub

        If Me.rdgNivel.SelectedIndex = -1 Then MsgBox("Selecione o nível do Usuário!", MsgBoxStyle.Information) : Me.rdgNivel.Focus() : Exit Sub
        If Validar(txtSenha) = False Then Exit Sub
        If Validar(txtConfSenha) = False Then Exit Sub
        If txtSenha.Text.Trim <> txtConfSenha.Text.Trim Then
            MsgBox("Conteúdo do campo 'Senha' está diferente do Campo 'Confirmar Senha'!", MsgBoxStyle.Information)
            txtSenha.ResetText()
            txtConfSenha.ResetText()
            txtSenha.Focus()
            Exit Sub
        End If

        If Me.lueLoja.Visible = True Then
            If Validar(Me.lueLoja) = False Then Exit Sub
        End If


        Dim strNivel As String = ""
        Select Case Me.rdgNivel.SelectedIndex
            Case 0
                strNivel = "USUÁRIO"
              
            Case 1
                strNivel = "ADMINISTRADOR"

            Case 2
                strNivel = "MASTER"

        End Select

        With Me.DsNanoCommerce.Usuario

            If bolAlterado = False Then
                '.Rows.Add()
                '.Rows.Item(.Rows.Count - 1).Item("Nome") = Me.txtNome.Text.Trim
                '.Rows.Item(.Rows.Count - 1).Item("Login") = Me.txtLogin.Text.Trim
                '.Rows.Item(.Rows.Count - 1).Item("Nivel") = strNivel
                '.Rows.Item(.Rows.Count - 1).Item("Senha") = Me.txtSenha.Text.Trim
                '.Rows.Item(.Rows.Count - 1).Item("FundoPadrao") = True
                '.Rows.Item(.Rows.Count - 1).Item("CodConfig") = intCodConfig

                Inserir("INSERT INTO Usuario (Nome, Login, Nivel, Senha, FundoPadrao, CodConfig, Inativo) VALUES (" & _
                "'" & Me.txtNome.Text.Trim & "','" & Me.txtLogin.Text.Trim & "','" & strNivel & "','" & Me.txtSenha.Text.Trim & "'," & _
                "'" & True & "'," & intCodConfig & ",'" & Me.chkInativar.Checked & "')")
            Else
                If Me.txtNome.Text.Trim <> strNome.Trim Then
                    Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strNome & "','" & Me.txtNome.Text.Trim & "','NOME','USUÁRIO','ALTERAÇÃO'," & CodConfig & ")")
                End If
                'For I = 0 To .Rows.Count - 1

                '    If .Rows.Item(I).Item("Codigo") = strCod Then

                '        .Rows.Item(I).Item("Nome") = Me.txtNome.Text.Trim
                '        .Rows.Item(I).Item("Login") = Me.txtLogin.Text.Trim
                '        .Rows.Item(I).Item("Nivel") = strNivel
                '        .Rows.Item(I).Item("Senha") = Me.txtSenha.Text.Trim
                '        .Rows.Item(I).Item("FundoPadrao") = True
                '        .Rows.Item(I).Item("CodConfig") = intCodConfig
                '    End If
                'Next

                Atualizar("UPDATE Usuario SET Nome = '" & Me.txtNome.Text.Trim & "', Login = '" & Me.txtLogin.Text.Trim & "', " & _
                "Nivel = '" & strNivel & "', Senha = '" & Me.txtSenha.Text.Trim & "', FundoPadrao = '" & True & "', " & _
                "CodConfig =" & Me.lueLoja.GetColumnValue("Codigo").ToString & ", Inativo = '" & Me.chkInativar.Checked & "' where Codigo = " & strCod)
            End If
        End With
        If bolInativo <> Me.chkInativar.Checked Then
            If Me.chkInativar.Checked = True Then
                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & Me.txtNome.Text.Trim & "','INATIVO','NOME','USUÁRIO','ALTERAÇÃO'," & CodConfig & ")")
            Else
                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & Me.txtNome.Text.Trim & "','ATIVO','NOME','USUÁRIO','ALTERAÇÃO'," & CodConfig & ")")

            End If
        End If
       

        Try
            'Me.Validate()
            'Me.UsuarioBindingSource.EndEdit()
            'Me.UsuarioTableAdapter.Update(Me.DsNanoCommerce.Usuario)
            If bolAlterado = False Then
                MsgBox("Usuário " & txtNome.Text & " cadastrado com sucesso!", MsgBoxStyle.Information)
            Else
                MsgBox("Usuário " & txtNome.Text & " alterado com sucesso!", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("Ocorreu um erro ao tentar salvar os dados, tente novamente!", MsgBoxStyle.Exclamation)
        End Try

        'Me.UsuarioTableAdapter.Fill(Me.DsNanoCommerce.Usuario)
        AtualizarGrid()
        Dim dt As DataTable = CarregarDataTable("Select Codigo from Usuario where Login ='" & Me.txtLogin.Text.Trim & "' and Senha ='" & Me.txtSenha.Text.Trim & "'")

        If dt.Rows.Count > 0 Then
            strCod = dt.Rows.Item(0).Item("Codigo")
        End If
        'If ImprimirCupomFiscal = True Then
        '    ArqUsuario("UNICO", False, strCod)
        'End If

        bolAlterado = False
        Limpar()

    End Sub

    Private Function VerificaCodUser() As String
        Dim strQuery As String = ""
        Try
            Dim dtCodUser As DataTable = CarregarDataTable("Select CodUser From Funcionario Where CodUser is not null Group by CodUser")

            Dim bolPassou As Boolean = False
            If dtCodUser.Rows.Count > 0 Then
                For I As Integer = 0 To dtCodUser.Rows.Count - 1
                    If bolPassou = False Then
                        strQuery = " And Codigo <> " & dtCodUser.Rows.Item(I).Item("CodUser").ToString

                        bolPassou = True
                    Else
                        strQuery = strQuery & " And Codigo <> " & dtCodUser.Rows.Item(I).Item("CodUser").ToString
                    End If
                Next
            End If
        Catch ex As Exception
            strQuery = ""
        End Try

        Return strQuery
    End Function

    Private Sub AtualizarGrid()
        If Me.Tag <> "FUNCIONARIO" Then
            If Master = True Then
                CarregarDados("SELECT * FROM Usuario", Me.UsuarioGridControl)
            Else
                CarregarDados("SELECT * FROM Usuario where CodConfig = " & CodConfig, Me.UsuarioGridControl)
            End If
        Else
            If Master = True Then
                Dim strQuery As String = VerificaCodUser()

                If strQuery <> "" Then
                    CarregarDados("SELECT * FROM Usuario Where Codigo <> 1 And Inativo = 'False'" & strQuery, Me.UsuarioGridControl)
                Else
                    CarregarDados("SELECT * FROM Usuario Where Codigo <> 1 And Inativo = 'False'", Me.UsuarioGridControl)
                End If

            Else
                Dim strQuery As String = VerificaCodUser()

                If strQuery <> "" Then
                    CarregarDados("SELECT * FROM Usuario Where CodConfig = " & CodConfig & " And Codigo <> 1 And Inativo = 'False'" & strQuery, Me.UsuarioGridControl)
                Else
                    CarregarDados("SELECT * FROM Usuario Where CodConfig = " & CodConfig & " And Codigo <> 1 And Inativo = 'False'", Me.UsuarioGridControl)
                End If

            End If
        End If
    End Sub
    Private Sub Limpar()

        chkAlt.Checked = False
        bolAlterado = False
        Me.txtNome.ResetText()
        chkAlt.Tag = ""
        Me.txtLogin.ResetText()
        Me.txtSenha.ResetText()
        Me.txtConfSenha.ResetText()
        Me.rdgNivel.SelectedIndex = -1
        txtLogin.Enabled = True
        chkAlt.Visible = False
        Me.lueLoja.EditValue = DBNull.Value
        Me.chkInativar.Checked = False
        txtNome.Focus()

    End Sub

    Private Sub Alterar()

        bolAlterado = True
        Dim Index As Integer = grd1.FocusedRowHandle
        Dim strNivel As String

        With grd1

            strCod = .GetRowCellValue(Index, Me.colCodigo)
            strNome = .GetRowCellValue(Index, Me.colNome)
            Me.txtNome.Text = .GetRowCellValue(Index, Me.colNome)
            Me.txtLogin.Text = .GetRowCellDisplayText(Index, Me.colLogin)

            Dim dtLogin As DataTable = CarregarDataTable("Select Senha from Usuario where Codigo = " & strCod)
            If dtLogin.Rows.Count > 0 Then
                Me.txtSenha.Text = dtLogin.Rows.Item(0).Item("Senha").ToString
                Me.txtConfSenha.Text = dtLogin.Rows.Item(0).Item("Senha").ToString
            End If
         

            strNivel = .GetRowCellDisplayText(Index, Me.colNivel)
            Me.chkInativar.Checked = .GetRowCellValue(Index, Me.colInativo)
            bolInativo = .GetRowCellValue(Index, Me.colInativo)
            Dim dt As DataTable = CarregarDataTable("Select Descricao from Config where Codigo =" & .GetRowCellDisplayText(Index, Me.colCodConfig))

            If dt.Rows.Count > 0 Then
                Me.lueLoja.Text = dt.Rows.Item(0).Item("Descricao").ToString
                Me.lueLoja.ClosePopup()
            End If
          

            Select Case strNivel

                Case "USUÁRIO"
                    Me.rdgNivel.SelectedIndex = 0

                Case "ADMINISTRADOR"
                    Me.rdgNivel.SelectedIndex = 1

                Case "MASTER"
                    Me.rdgNivel.SelectedIndex = 2

            End Select
            txtLogin.Enabled = False
            chkAlt.Visible = True
        End With
    End Sub

    Private Sub frmUsuarios_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "65")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub
        'Me.ConfigTableAdapter.Fill(Me.DsNanoCommerce.Config)
        CarregarDadosLue("Select Codigo, Descricao from Config", Me.lueLoja)
        intCodConfig = CodConfig

        'If Master = True Then
        '    Me.UsuarioBindingSource.Filter = "Nome <> 'ADMINISTRADOR'"

        'Else
        '    Me.UsuarioBindingSource.Filter = "Nome <> 'ADMINISTRADOR' AND CodConfig =" & CodConfig

        'End If
        AtualizarGrid()
        Me.lueLoja.Visible = Master
        Me.lblLoja.Visible = Master
        Me.colCodConfig.Visible = Master

        ' Me.UsuarioTableAdapter.Fill(Me.DsNanoCommerce.Usuario)

    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If MsgBox("Deseja realmente limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Limpar()
        End If
    End Sub

    Private Sub btnCancelar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick

        If grd1.RowCount = 0 Then Exit Sub
        Dim Index As Integer = grd1.FocusedRowHandle

        If grd1.FocusedRowHandle = 0 Then MsgBox("Não é possível excluir o usuário ADMINISTRADOR!", MsgBoxStyle.Information) : Exit Sub

        If Index < 0 Then Exit Sub

        Dim strLogin As String = grd1.GetRowCellDisplayText(Index, Me.colLogin).Trim
        Dim strNome As String = grd1.GetRowCellDisplayText(Index, Me.colNome).Trim


        If MsgBox("Deseja realmente excluir o Usuário " & strNome & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            If SenhaEstaOK() = False Then Exit Sub

            'If ImprimirCupomFiscal = True Then
            '    ArqUsuario("UNICO", True, grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodigo))
            'End If

            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strNome & "','EXCLUÍDO','USUÁRIO','USUÁRIO','EXCLUSÃO')")
            Deletar("Usuario", "Login", strLogin, grd1, Index)
            Me.UsuarioTableAdapter.Fill(Me.DsNanoCommerce.Usuario)
            AtualizarGrid()
        End If
    End Sub

    Private Sub btnAlterar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterar.ItemClick
        Alterar()
    End Sub

    Private Sub txtLogin_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLogin.Leave
        If txtLogin.Text.Trim = "" Then Exit Sub
        If bolAlterado = False Then
            PesquisarUsuario(txtLogin)
        Else
            If chkAlt.Checked = True Then
                PesquisarUsuario(txtLogin)
            End If
        End If

    End Sub

    Private Sub txtNome_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNome.KeyPress
        If Char.IsLetter(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> " " Then
            e.Handled = True
        End If

        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub chkAlt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAlt.CheckedChanged
        If chkAlt.Checked = True Then
            txtLogin.Enabled = True
            chkAlt.Tag = txtLogin.Text
        Else
            txtLogin.Enabled = False
            txtLogin.Text = chkAlt.Tag
        End If
    End Sub

    'Private Sub UsuarioGridControl_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles UsuarioGridControl.DoubleClick
    '    bolAlterado = True
    '    Dim Index As Integer = grd1.FocusedRowHandle
    '    Dim strNivel As String

    '    With grd1

    '        strCod = .GetRowCellValue(Index, Me.colCodigo)
    '        Me.txtNome.Text = .GetRowCellValue(Index, Me.colNome)
    '        Me.txtLogin.Text = .GetRowCellDisplayText(Index, Me.colLogin)
    '        Me.txtSenha.Text = .GetRowCellDisplayText(Index, Me.colSenha)
    '        Me.txtConfSenha.Text = .GetRowCellDisplayText(Index, Me.colSenha)
    '        strNivel = .GetRowCellDisplayText(Index, Me.colNivel)

    '        Select Case strNivel
    '            Case "ADMINISTRADOR"
    '                Me.rdgNivel.SelectedIndex = 0

    '            Case "USUÁRIO"
    '                Me.rdgNivel.SelectedIndex = 1

    '        End Select
    '        txtLogin.Enabled = False
    '        chkAlt.Visible = True
    '    End With
    'End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        If Me.Tag <> "FUNCIONARIO" Then
            Alterar()
        Else
            Dim Index As Integer = grd1.FocusedRowHandle
            Dim CodUser As Integer = grd1.GetRowCellDisplayText(Index, Me.colCodigo)
            My.Forms.frmCadFuncionario.NanoCampo1.Text = CodUser

            Me.Close()
        End If
    End Sub
   
    Private Sub lueLoja_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueLoja.TextChanged
        If Me.lueLoja.EditValue.ToString <> "" Then
            intCodConfig = Me.lueLoja.EditValue
        End If
    End Sub
   
End Class