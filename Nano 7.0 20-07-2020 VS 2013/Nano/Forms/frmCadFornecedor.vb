Imports Nano.clsFuncoes
Imports Nano.clsValidar
Public Class frmCadFornecedor
    Public bolAlterar, bolValida As Boolean
    Public intCodigo As Integer
    Public strCpfCnpj, strCpf As String
    Public strNome As String
    Dim strTipo As String
    Dim strCodMunicipio As String
    Dim strFantasiaLog As String

    Private Sub frmCadFornecedor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.grd1.ClearColumnsFilter()
    End Sub
    Private Sub frmCadFornecedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "5")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmFornecedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub
        If Me.Tag = "PESQUISA" Or Me.Tag = "Fornecedor" Or Me.Tag = "NFEFor" Or Me.Tag = "PAGAMENTO" Then
            strTipo = "F"
        Else
            strTipo = "T"
            Me.Text = "Cadastro de Transportadora"
            Me.lblFor.Text = "Dados da Transportadora"
            Me.GroupControl1.Text = "Transportadoras Cadastradas"
        End If


        If EmiteNFE = True Then
            Me.lblCodMun.Visible = True
            Me.txtCodMun.Visible = True
        Else

            Me.txtBairro.Size = New System.Drawing.Size(360, 20)

        End If

        AtualizarGrid()
        CarregarComboCidade(Me.cboUF, Me.cboCidade)
        bolAlterar = False

        Me.chkCPF.Visible = False
        Me.txtCPF.Enabled = True
        Me.rdgDoc.SelectedIndex = 1
        strCpfCnpj = "Cnpj"

        Timer1.Start()
        Me.cboUF.Text = UFEmpresa

        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)
    End Sub
    Private Sub AtualizarGrid()
        CarregarDados("SELECT * FROM Fornecedor where Tipo = '" & strTipo & "' Order By Codigo asc", Me.FornecedorGridControl)
        Me.txtQtdFor.Text = Me.grd1.RowCount
    End Sub
    Private Sub CarregarComboCidade(ByVal parUF As Object, ByVal parCidade As Object)
        Dim dt As DataTable
        Dim I As Integer
        dt = CarregarDataTable("SELECT Nome FROM Cidade where UF = '" & parUF.Text & "'")
        For I = 0 To dt.Rows.Count - 1
            parCidade.Properties.Items.Add(dt.Rows.Item(I).ItemArray(0))
        Next
    End Sub
    Private Sub Limpar()
        Me.dtNasc.ResetText()
        Me.txtNome.ResetText()
        Me.txtFantasia.ResetText()
        Me.txtCPF.ResetText()
        Me.txtIE.ResetText()
        Me.txtContato.ResetText()

        Me.txtCep.ResetText()
        Me.txtComp.ResetText()
        Me.txtEnd.ResetText()
        Me.txtBairro.ResetText()
        Me.txtNum.ResetText()
        Me.cboUF.Text = UFEmpresa
        Me.cboCidade.SelectedIndex = -1
        CarregarComboCidade(Me.cboUF, Me.cboCidade)

        Me.txtTel1.ResetText()
        Me.txtTel2.ResetText()
        Me.txtTel3.ResetText()
        Me.txtWeb1.ResetText()
        Me.txtWeb2.ResetText()
        Me.cboStatus.SelectedIndex = -1

        Me.txtNomeRep.ResetText()
        Me.txtTelRep1.ResetText()
        Me.txtTelRep2.ResetText()
        Me.txtWebRep.ResetText()

        Me.memObs.ResetText()
        strCpf = ""
        bolAlterar = False
        Me.chkCPF.Visible = False
        Me.txtCPF.Enabled = True
        Me.chkIsento.Checked = False
        Me.chkInativar.Checked = False

        Me.txtCodMun.ResetText()

        Me.txtNome.Focus()

        Me.abaFor.SelectedTabPageIndex = 0
        Me.chkIsento.BackColor = Color.White
    End Sub
    Private Sub Alterar()
        bolAlterar = True
        Me.chkCPF.Visible = True
        Me.chkCPF.BackColor = Color.Transparent
        Me.txtCPF.Enabled = False
        Me.chkIsento.Checked = False


        Dim intIndex As Integer = Me.grd1.FocusedRowHandle


        With Me.grd1
            intCodigo = .GetRowCellDisplayText(intIndex, Me.colCodigo)
            strNome = .GetRowCellDisplayText(intIndex, Me.colNome)
            strFantasiaLog = .GetRowCellDisplayText(intIndex, Me.colFantasia)
            Me.txtNome.Text = .GetRowCellDisplayText(intIndex, Me.colNome)
            Me.txtFantasia.Text = .GetRowCellDisplayText(intIndex, Me.colFantasia)
            Me.cboUF.Text = .GetRowCellDisplayText(intIndex, Me.colEstado)
            Me.txtCPF.Text = .GetRowCellDisplayText(intIndex, Me.colCPF)
            strCpf = .GetRowCellDisplayText(intIndex, Me.colCPF)
            Me.txtCPF.Tag = strCpf
            If .GetRowCellDisplayText(intIndex, Me.colCPF).Length <= 14 Then
                Me.rdgDoc.SelectedIndex = 0
            Else
                Me.rdgDoc.SelectedIndex = 1
            End If

            Me.txtIE.Text = .GetRowCellDisplayText(intIndex, Me.colIE)
            If .GetRowCellDisplayText(intIndex, Me.colIE) = "ISENTO" Then
                Me.chkIsento.Checked = True
            Else
                Me.txtIE.Text = .GetRowCellDisplayText(intIndex, Me.colIE)
            End If

            Me.txtContato.Text = .GetRowCellDisplayText(intIndex, Me.colContato)

            Me.txtCep.Text = .GetRowCellDisplayText(intIndex, Me.colCep)
            Me.txtComp.Text = .GetRowCellDisplayText(intIndex, Me.colComplemento)
            Me.txtEnd.Text = .GetRowCellDisplayText(intIndex, Me.colEndereco)
            Me.txtBairro.Text = .GetRowCellDisplayText(intIndex, Me.colBairro)
            Me.txtNum.Text = .GetRowCellDisplayText(intIndex, Me.colNumero)
            Me.cboCidade.Text = .GetRowCellDisplayText(intIndex, Me.colCidade)

            Me.txtTel1.Text = .GetRowCellDisplayText(intIndex, Me.colTelefone)
            Me.txtTel2.Text = .GetRowCellDisplayText(intIndex, Me.colFax)
            Me.txtTel3.Text = .GetRowCellDisplayText(intIndex, Me.colCelular)
            Me.txtWeb1.Text = .GetRowCellDisplayText(intIndex, Me.colEmail)
            Me.txtWeb2.Text = .GetRowCellDisplayText(intIndex, Me.colSite)
            Me.cboStatus.Text = .GetRowCellDisplayText(intIndex, Me.colStatus)
            If .GetRowCellValue(intIndex, Me.colInativo).ToString <> "" Then
                Me.chkInativar.Checked = .GetRowCellValue(intIndex, Me.colInativo)
            End If
            Me.dtNasc.Text = .GetRowCellDisplayText(intIndex, Me.colNascimento)
            Me.memObs.Text = .GetRowCellDisplayText(intIndex, Me.colObs)
            CodigoMunicipio(Me.cboCidade.Text, Me.cboUF.Text)
        End With

        Dim dt As DataTable
        dt = CarregarDataTable("SELECT Nome, Tel1, Tel2, Web FROM Representante where CodFor = " & intCodigo)

        If dt.Rows.Count > 0 Then
            Me.txtNomeRep.Text = dt.Rows.Item(0).Item("Nome").ToString
            Me.txtTelRep1.Text = dt.Rows.Item(0).Item("Tel1").ToString
            Me.txtTelRep2.Text = dt.Rows.Item(0).Item("Tel2").ToString
            Me.txtWebRep.Text = dt.Rows.Item(0).Item("Web").ToString
        End If


    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick

        If TesteConexao() = False Then Exit Sub

        If Validar(Me.txtNome) = False Then Exit Sub
        'If Validar(Me.txtEnd) = False Then Exit Sub
        'If Validar(Me.txtNum) = False Then Exit Sub


        If Me.txtCPF.Text.Trim <> Me.txtCPF.Tag.ToString.Trim Then
            If PesquisarFornecedor(txtCPF) = False Then Exit Sub
        End If

        If ValidaCPF(Me.txtCPF.Text) = False Then
            Me.txtCPF.ResetText()
            Me.txtCPF.Focus()
            Exit Sub
        End If

        If Me.txtCodMun.Text = "" Then
            CodigoMunicipio(Me.cboCidade.Text, Me.cboUF.Text)
        End If
        Dim strPais As String = "BRASIL"
        Dim strCodPais As String = "1058"


        If bolAlterar = False Then

            Dim strCodFor As String

            strCodFor = GerarCodigo("Fornecedor", "Codigo", CodConfig)

            'If Me.txtCPF.Text.Trim <> "" Then
            '    strNcpf = Me.txtCPF.Text.Trim
            'Else
            '    strNcpf = "000" & strCodFor.Trim
            '    Me.txtCPF.Text = strNcpf
            'End If

            Inserir("INSERT INTO Fornecedor (Nome, CPF, Endereco, Numero, Complemento, Bairro, Cep, Cidade, " & _
            "Estado, Telefone, Fax, Celular, Email, Data, IE, Contato, Site, Fantasia, Status, Obs, CodConfig, " & _
            "Tipo, CodMunicipio, CodPais, NomePais, Inativo, Nascimento) VALUES ('" & Me.txtNome.Text.Trim & "'," & _
            "'" & Me.txtCPF.Text.Trim & "','" & Me.txtEnd.Text.Trim.Replace("'", "`") & "'," & _
            "'" & Me.txtNum.Text.Trim & "','" & Me.txtComp.Text.Trim & "','" & Me.txtBairro.Text.Trim & "'," & _
            "'" & Me.txtCep.Text.Trim & "','" & Me.cboCidade.Text.Trim & "','" & Me.cboUF.Text.Trim & "'," & _
            "'" & Me.txtTel1.Text.Trim & "','" & Me.txtTel2.Text.Trim & "','" & Me.txtTel3.Text.Trim & "'," & _
            "'" & Me.txtWeb1.Text.Trim & "','" & Date.Today & "','" & Me.txtIE.Text.Trim & "'," & _
            "'" & Me.txtContato.Text.Trim & "','" & Me.txtWeb2.Text.Trim & "','" & Me.txtFantasia.Text.Trim & "'," & _
            "'" & Me.cboStatus.Text.Trim & "','" & Me.memObs.Text.Trim.Replace("'", "") & "'," & CodConfig & "," & _
            "'" & strTipo & "','" & Me.txtCodMun.Text & "','" & strCodPais & "','" & strPais & "'," & _
            "'" & Me.chkInativar.CheckState & "','" & Me.dtNasc.EditValue & "')")

            Inserir("INSERT INTO Representante (CodFor, Nome, Tel1, Tel2, Web) VALUES (" & strCodFor & ",'" & Me.txtNomeRep.Text.Trim & "','" & Me.txtTelRep1.Text.Trim & "','" & Me.txtTelRep2.Text.Trim & "','" & Me.txtWebRep.Text.Trim & "')")

            If strTipo = "F" Then
                MsgBox("Fornecedor cadastrado com sucesso!", MsgBoxStyle.Information)
            Else
                MsgBox("Transportadora cadastrada com sucesso!", MsgBoxStyle.Information)
            End If


            If Me.Tag = "NFETrans" Or Me.Tag = "NFEFor" Then
                Dim intCodigoFor As Integer = Val(GerarCodigo("Fornecedor", "Codigo", CodConfig)) - 1
                CodigoDoFornecedor = intCodigoFor
                Me.Close()
                Exit Sub
            End If

        Else
            If Me.txtNome.Text.Trim <> strNome.Trim Then
                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strNome & "','" & Me.txtNome.Text.Trim & "','NOME','FORNECEDOR','ALTERAÇÃO'," & CodConfig & ")")
            End If

            If Me.txtFantasia.Text.Trim <> strFantasiaLog.Trim Then
                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strFantasiaLog & "','" & Me.txtFantasia.Text.Trim & "','FANTASIA','FORNECEDOR','ALTERAÇÃO'," & CodConfig & ")")
            End If


            Atualizar("UPDATE Fornecedor SET Nome = '" & Me.txtNome.Text.Trim & "', CPF = '" & Me.txtCPF.Text.Trim & "', " & _
            "Endereco = '" & Me.txtEnd.Text.Trim.Replace("'", "`") & "', Numero = '" & Me.txtNum.Text.Trim & "', " & _
            "Complemento = '" & Me.txtComp.Text.Trim & "', Bairro = '" & Me.txtBairro.Text.Trim & "', " & _
            "Cep = '" & Me.txtCep.Text.Trim & "', Cidade = '" & Me.cboCidade.Text.Trim & "', " & _
            "Estado = '" & Me.cboUF.Text.Trim & "', Telefone = '" & Me.txtTel1.Text.Trim & "', " & _
            "Fax = '" & Me.txtTel2.Text.Trim & "', Celular = '" & Me.txtTel3.Text.Trim & "', " & _
            "Email = '" & Me.txtWeb1.Text.Trim & "', IE = '" & Me.txtIE.Text.Trim & "', " & _
            "Contato = '" & Me.txtContato.Text.Trim & "', Site = '" & Me.txtWeb2.Text.Trim & "', " & _
            "Fantasia = '" & Me.txtFantasia.Text.Trim & "', Status = '" & Me.cboStatus.Text.Trim & "', " & _
            "Obs = '" & Me.memObs.Text.Trim.Replace("'", "") & "', Tipo = '" & strTipo & "', " & _
            "CodMunicipio = '" & Me.txtCodMun.Text & "', CodPais = '" & strCodPais & "', NomePais = '" & strPais & "', " & _
            "Inativo ='" & Me.chkInativar.CheckState & "', Nascimento = '" & Me.dtNasc.EditValue & "' where Codigo = " & intCodigo)

            Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM Representante where CodFor = " & intCodigo)
            If dt.Rows.Count > 0 Then
                Atualizar("UPDATE Representante SET Nome = '" & Me.txtNomeRep.Text.Trim & "', Tel1 = '" & Me.txtTelRep1.Text.Trim & "', Tel2 = '" & Me.txtTelRep2.Text.Trim & "', Web = '" & Me.txtWebRep.Text.Trim & "' where CodFor = " & intCodigo)

            Else
                Inserir("INSERT INTO Representante (CodFor, Nome, Tel1, Tel2, Web) VALUES (" & intCodigo & ",'" & Me.txtNomeRep.Text.Trim & "','" & Me.txtTelRep1.Text.Trim & "','" & Me.txtTelRep2.Text.Trim & "','" & Me.txtWebRep.Text.Trim & "')")
            End If
          
            Atualizar("UPDATE Produto SET Fabricante = '" & Me.txtNome.Text.Trim & "' where Fabricante = '" & strNome & "'")

            If strTipo = "F" Then
                MsgBox("Fornecedor alterado com sucesso!", MsgBoxStyle.Information)
            Else
                MsgBox("Transportadora alterada com sucesso!", MsgBoxStyle.Information)
            End If

        End If

        AtualizarGrid()
        bolAlterar = False
        Limpar()

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
                    strEnd = ht("tipologradouro") & " " & ht("logradouro")
                    strBairro = ht("bairro")
                    strCidade = ht("localidade")
                    Me.txtEnd.Text = strEnd.ToUpper.Replace("'", "´")
                    Me.txtBairro.Text = strBairro.ToUpper.Replace("'", "´")
                    Me.cboCidade.Text = strCidade.ToUpper.Replace("'", "´")
                    Me.cboUF.Text = ht("UF")
                    Me.txtNum.Focus()
                    CodigoMunicipio(Me.cboCidade.Text, Me.cboUF.Text)
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
        If Me.txtIE.Text = "ISENTO" Or Me.txtIE.Text = "" Then Exit Sub
        Me.txtIE.ResetText()
        Me.txtIE.Focus()
    End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        RetornaPesquisa()
    End Sub

    Private Sub RetornaPesquisa()
        If Me.Tag = "PESQUISA" Then
            If Me.grd1.GetRowCellValue(Me.grd1.FocusedRowHandle, Me.colInativo) = True Then
                MsgBox("Cadastro Inativo!", MsgBoxStyle.Information)
                Exit Sub
            End If
            CodigoDoFornecedor = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)
            Me.Close()
            Exit Sub
        ElseIf Me.Tag = "NFETrans" Or Me.Tag = "NFEFor" Then
            If Me.grd1.GetRowCellValue(Me.grd1.FocusedRowHandle, Me.colInativo) = True Then
                MsgBox("Cadastro Inativo!", MsgBoxStyle.Information)
                Exit Sub
            End If

            CodigoDoFornecedor = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)
            Me.Close()
            Exit Sub
        ElseIf Me.Tag = "PAGAMENTO" Then
            CodigoDoFornecedor = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)
            Me.Close()
            Exit Sub
        End If
        Alterar()
        Alterar()
    End Sub

    Private Sub btnAlterar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterar.ItemClick
        Alterar()
        Alterar()
    End Sub

    Private Sub chkCPF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCPF.CheckedChanged
        Select Case Me.chkCPF.Checked
            Case True
                Me.txtCPF.Enabled = True
                Me.chkCPF.BackColor = Color.White
            Case False
                Me.chkCPF.BackColor = Color.Transparent
                Me.txtCPF.Enabled = False
                Me.txtCPF.Text = Me.txtCPF.Tag
        End Select
    End Sub

    Private Sub chkIsento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIsento.CheckedChanged
        If Me.chkIsento.Checked = True Then
            Me.chkIsento.BackColor = Color.Transparent
            Me.txtIE.ResetText()
            Me.txtIE.Text = "ISENTO"
            Me.txtIE.Properties.ReadOnly = True
        Else
            Me.chkIsento.BackColor = Color.White
            Me.txtIE.ResetText()
            Me.txtIE.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub rdgDoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgDoc.SelectedIndexChanged
        Select Case Me.rdgDoc.SelectedIndex
            Case 0
                strCpfCnpj = "Cpf"
                Me.chkIsento.Visible = False
                Me.chkIsento.Checked = False
            Case 1
                strCpfCnpj = "Cnpj"
                Me.chkIsento.Visible = True
        End Select
        Me.txtCPF.ResetText()
        Me.txtCPF.Focus()
    End Sub

    Private Sub txtCPF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCPF.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then
            e.Handled = False
            Exit Sub
        End If
        FormatarDocumento(Me.txtCPF, strCpfCnpj)
    End Sub


    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        Dim intCod As Integer = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)

        Dim dtVerifica As DataTable = CarregarDataTable("Select Data from TotalEntradaNF where CodFor = " & intCod)

        If dtVerifica.Rows.Count > 0 Then
            MsgBox("Não é possivel excluir esse Fornecedor pois existem Notas de Entrada cadastradas em seu nome!", MsgBoxStyle.Information)
            Exit Sub
        End If


        Dim strNome As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colNome)
        If MsgBox("Deseja realmente excluir o fornecedor " & strNome & " ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            If Excluir("DELETE FROM Fornecedor where Codigo = " & intCod) = True Then
                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strNome & "','EXCLUÍDO','NOME','FORNECEDOR','EXCLUSÃO'," & CodConfig & ")")
                MsgBox("Fornecedor " & strNome & " excluido co sucesso.", MsgBoxStyle.Information)
                AtualizarGrid()
                Limpar()
            End If

          
        End If

    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If MsgBox("Deseja realmente limpar todos os campos?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Limpar()
        End If
    End Sub

    Private Sub txtIE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIE.KeyPress
        If strCpfCnpj = "Cnpj" Then
            Select Case Me.cboUF.Text
                Case "AC"    ' Acre
                    Me.txtIE.Properties.MaxLength = 17
                Case "AL", "AP", "BA", "ES", "MA", "MS", "PI"   ' Alagoas
                    Me.txtIE.Properties.MaxLength = 9
                Case "AM", "RN", "MT", "GO" ' Amazonas
                    Me.txtIE.Properties.MaxLength = 12
                Case "CE", "PB", "RR" ' Ceara
                    Me.txtIE.Properties.MaxLength = 10
                Case "DF"    ' Distrito Federal
                    Me.txtIE.Properties.MaxLength = 14
                Case "MG"    ' Minas Gerais
                    Me.txtIE.Properties.MaxLength = 16
                Case "PA", "PR", "RJ", "RO", "RS", "SC", "SE", "TO"  ' Para
                    Me.txtIE.Properties.MaxLength = 11
                Case "PE"    ' Pernambuco
                    'Me.txtIE.Properties.MaxLength = 18
                Case "SP"    ' São Paulo
                    Me.txtIE.Properties.MaxLength = 15
            End Select
            If IsNumeric(e.KeyChar) AndAlso Me.txtIE.Text.Length < Me.txtIE.Properties.MaxLength Then
                Me.txtIE.Text &= e.KeyChar
                Me.txtIE.SelectionStart = Me.txtIE.Text.Length
                formataIE(Me.txtIE, Me.cboUF.Text)
            End If
            If e.KeyChar = vbBack Then Exit Sub
            e.Handled = True
        End If
    End Sub

    Private Sub txtIE_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIE.Leave
        If strCpfCnpj = "Cnpj" Then
            If Me.txtIE.Text = "" Then Exit Sub
            If ChecaInscrE(Me.cboUF.Text, Me.txtIE.Text) = False Then
                MsgBox("Inscrição Estadual informada não é valida, insira todos os ponto e verifique se a UF selecionada é a UF do fornecedor.", MsgBoxStyle.Information)
                Me.txtIE.ResetText()
                Me.txtIE.Focus()
            End If
        End If
    End Sub

    Private Sub txtAlterar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlterar.KeyDown
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            RetornaPesquisa()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Tag = "PESQUISA" Then
            Dim index As Integer = -999997
            grd1.FocusedRowHandle = index
            grd1.FocusedColumn = Me.colNome
            grd1.ShowEditor()
            If Me.Tag = "" Then
                Me.txtNome.Focus()
            End If
        End If

        Timer1.Stop()
    End Sub

    Private Sub txtCPF_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCPF.Leave
        If Me.txtCPF.Text.Trim = "" Then Exit Sub

        If Me.chkCPF.Tag = Nothing Then
            Me.chkCPF.Tag = ""
        End If

        If PesquisarFornecedor(txtCPF) = False Then Exit Sub

        If ValidaCPF(Me.txtCPF.Text) = False Then
            Me.txtCPF.ResetText()
            Me.txtCPF.Focus()
        End If

        'If My.Computer.Network.IsAvailable = False Then
        '    Exit Sub
        'End If

        'If My.Computer.Network.Ping("www.terra.com.br") = False Then
        '    Exit Sub
        'End If

        If Me.rdgDoc.SelectedIndex = 1 Then
            If BuscaCpfCnpj.Contains("CNPJ") = True Then
                BuscaCNPJ(Me.cboUF.Text, Me.txtCPF.Text, Me.Name, "01/01/1900")
            End If

        Else
            If BuscaCpfCnpj.Contains("CPF") = True Then
                If Me.dtNasc.Text <> "" Then
                    BuscaCNPJ("CPF", Me.txtCPF.Text, Me.Name, Me.dtNasc.EditValue)
                End If

            End If

        End If
    End Sub

    Private Sub btnDados_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDados.ItemClick
        Dim I As Integer
        Dim rel As New relDadosFornecedor
        rel.picLogo.Image = LogoTipo
        With rel.tbFor.Rows
            For I = 0 To Me.grd1.RowCount - 1
                .Add()
                .Item(I).Item("Fornecedor") = Me.grd1.GetRowCellDisplayText(I, Me.colNome)
                .Item(I).Item("CPF") = Me.grd1.GetRowCellDisplayText(I, Me.colCPF)
                .Item(I).Item("RG") = Me.grd1.GetRowCellDisplayText(I, Me.colIE)
                .Item(I).Item("Tel1") = Me.grd1.GetRowCellDisplayText(I, Me.colTelefone)
                .Item(I).Item("Tel2") = Me.grd1.GetRowCellDisplayText(I, Me.colCelular)
                .Item(I).Item("Email") = Me.grd1.GetRowCellDisplayText(I, Me.colEmail)
                .Item(I).Item("Contato") = Me.grd1.GetRowCellDisplayText(I, Me.colContato)
            Next
        End With
        rel.ShowPreview()
    End Sub

    Private Sub btnDetalhado_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDetalhado.ItemClick
        Dim I As Integer
        Dim rel As New relDadosForDetal

        With rel.DsNanoCommerce.Fornecedor.Rows
            For I = 0 To Me.grd1.RowCount - 1

                .Add()
                .Item(I).Item("Nome") = Me.grd1.GetRowCellDisplayText(I, Me.colNome)
                .Item(I).Item("CPF") = Me.grd1.GetRowCellDisplayText(I, Me.colCPF)
                .Item(I).Item("IE") = Me.grd1.GetRowCellDisplayText(I, Me.colIE)
                .Item(I).Item("Contato") = Me.grd1.GetRowCellDisplayText(I, Me.colContato)
                .Item(I).Item("Fantasia") = Me.grd1.GetRowCellDisplayText(I, Me.colFantasia)
                .Item(I).Item("Endereco") = Me.grd1.GetRowCellDisplayText(I, Me.colEndereco)
                .Item(I).Item("Numero") = Me.grd1.GetRowCellDisplayText(I, Me.colNumero)
                .Item(I).Item("Bairro") = Me.grd1.GetRowCellDisplayText(I, Me.colBairro)
                .Item(I).Item("Cidade") = Me.grd1.GetRowCellDisplayText(I, Me.colCidade)
                .Item(I).Item("Cep") = Me.grd1.GetRowCellDisplayText(I, Me.colCep)
                .Item(I).Item("Estado") = Me.grd1.GetRowCellDisplayText(I, Me.colEstado)
                .Item(I).Item("Telefone") = Me.grd1.GetRowCellDisplayText(I, Me.colTelefone)
                .Item(I).Item("Celular") = Me.grd1.GetRowCellDisplayText(I, Me.colCelular)
                .Item(I).Item("Fax") = Me.grd1.GetRowCellDisplayText(I, Me.colFax)
                .Item(I).Item("Email") = Me.grd1.GetRowCellDisplayText(I, Me.colEmail)
                If Me.grd1.GetRowCellDisplayText(I, Me.colData) <> "" Then
                    .Item(I).Item("Data") = Me.grd1.GetRowCellDisplayText(I, Me.colData)
                End If

            Next
        End With

        rel.ShowPreview()
    End Sub

    Private Sub btnCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCust.ItemClick
        Me.FornecedorGridControl.ShowPrintPreview()
    End Sub

    Private Sub memObs_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles memObs.KeyPress, cboCidade.KeyPress
        If e.KeyChar = "'" Or e.KeyChar = "&" Then
            e.Handled = True
        End If
    End Sub

    Private Sub CodigoMunicipio(ByVal parCidade As String, ByVal parUF As String)
        If parCidade <> "" Then
            Dim dt As DataTable = CarregarDataTable("SELECT CodIBGE FROM Cidade where Nome = '" & parCidade.Replace("'", "´") & "' and UF = '" & parUF & "'")
            If dt.Rows.Count > 0 Then
                Me.txtCodMun.Text = dt.Rows.Item(0).Item("CodIBGE").ToString
            End If
        End If
    End Sub

    Private Sub cboCidade_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCidade.Leave
        CodigoMunicipio(Me.cboCidade.Text, Me.cboUF.Text)
    End Sub
    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub

    Private Sub btnConCPF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConCPF.Click
        If Me.txtCPF.Text.Trim = "" Then
            MsgBox("CPF/CNPJ é obrigatório!", MsgBoxStyle.Information)
            Exit Sub
        End If

        'If My.Computer.Network.IsAvailable = False Then
        '    MsgBox("erifique a conexão com a internet!", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'If My.Computer.Network.Ping("www.terra.com.br") = False Then
        '    MsgBox("erifique a conexão com a internet!", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        If Me.rdgDoc.SelectedIndex = 1 Then
            'If BuscaCpfCnpj.Contains("CNPJ") = True Then
            BuscaCNPJ(Me.cboUF.Text, Me.txtCPF.Text, Me.Name, "01/01/1900")
            'End If

        Else
            'If BuscaCpfCnpj.Contains("CPF") = True Then
            If Me.dtNasc.Text <> "" Then
                BuscaCNPJ("CPF", Me.txtCPF.Text, Me.Name, Me.dtNasc.EditValue)
            Else
                MsgBox("Nascimento é obrigatório!", MsgBoxStyle.Information)
            End If

            'End If

        End If
    End Sub
End Class