Imports Nano.clsFuncoes
Public Class frmMovBancario
    Dim intCod As Integer
    Dim dblSal As Double
    Dim intCodConfig As Integer
    Public intCodigoBanco As Integer
    Public strNomeBanco As String


    Private Sub frmMovBancario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Limpar()
    End Sub

    Private Sub frmMovBancario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "24")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub
    Private Sub frmMovBancario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If TesteConexao() = False Then Exit Sub

        CarregarDadosLue("Select Codigo, Descricao from Config", Me.lueLoja)

        intCodConfig = CodConfig

        Me.lblLoja.Visible = Master
        Me.lueLoja.Visible = Master
        Me.cboBanco.Properties.Items.Clear()
        PreencherOrdenado("Banco", Me.cboBanco, "1", "Nome")

        Me.cboTipoMov.Properties.Items.Clear()
        If Me.Tag = "MOVIMENTACAO" Then
            Me.cboTipoMov.Properties.Items.Add("DÉBITO")
            Me.cboTipoMov.Properties.Items.Add("CRÉDITO")
            Me.cboTipoMov.Properties.Items.Add("RECEITAS")
            Me.cboTipoMov.Properties.Items.Add("DESPESAS")
        ElseIf Me.Tag = "BANCO" Then
            Me.txtObs.Text = "TRANSFERÊNCIA BANCO " & strNomeBanco
            Me.Text = "Transferência Banco " & strNomeBanco
            PreencherOrdenado("Pagamento", Me.cboTipoMov, 1, "Descricao")
            Me.lblMovimento.Text = "Pagamento"

        Else
            Me.txtObs.Text = "TRANSFERÊNCIA CAIXA"
            Me.Text = "Transferência Caixa"
            PreencherOrdenado("Pagamento", Me.cboTipoMov, 1, "Descricao")
            Me.lblMovimento.Text = "Pagamento"

        End If
        BaixarCartoes()

        Me.dtData.Text = Date.Today
    End Sub
    Private Sub Limpar()

        strNomeBanco = ""
        intCodigoBanco = Nothing
        Me.cboBanco.SelectedIndex = -1
        Me.cboTipoMov.SelectedIndex = -1
        Me.txtValor.ResetText()
        Me.txtSaldo.ResetText()
        Me.txtObs.ResetText()
        Me.dtData.Text = Date.Today
        Me.cboBanco.Focus()
    End Sub

    Private Sub btnsalvar_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnsalvar.ItemClick

        If TesteConexao() = False Then Exit Sub

        If Validar(Me.cboBanco) = False Then Exit Sub
        If Validar(Me.cboTipoMov) = False Then Exit Sub
        If Validar(Me.txtValor) = False Then Exit Sub
        Me.txtObs.Focus()

        If Me.Tag = "MOVIMENTACAO" Then
            Inserir("INSERT INTO MovimentoBancario (CodBanco, TipoMovimento, Valor, Data, Observacao, CodConfig)VALUES(" & _
            "" & intCod & ",'" & Me.cboTipoMov.Text.Trim & "'," & Num(Me.txtValor.Text.Trim) & ",'" & Me.dtData.Text.Trim & "','" & Me.txtObs.Text.Replace("'", "") & "'," & intCodConfig & ")")

            Atualizar("UPDATE Banco SET Saldo = " & Num(dblSal) & " where Codigo = " & intCod)
            MsgBox("Movimentação salva com sucesso!", MsgBoxStyle.Information)
        ElseIf Me.Tag = "BANCO" Then
            Inserir("INSERT INTO MovimentoBancario (CodBanco, TipoMovimento, Valor, Data, Observacao, CodConfig)VALUES(" & intCod & ",'CRÉDITO'," & Num(Me.txtValor.Text.Trim) & ",'" & Me.dtData.Text.Trim & "','" & Me.txtObs.Text & "'," & intCodConfig & ")")
            Inserir("INSERT INTO MovimentoBancario (CodBanco, TipoMovimento, Valor, Data, Observacao, CodConfig)VALUES(" & intCodigoBanco & ",'DÉBITO'," & Num(Me.txtValor.Text.Trim) & ",'" & Me.dtData.Text.Trim & "','" & Me.txtObs.Text & "'," & intCodConfig & ")")

         
            Dim dblValSaldo As Double = SaldoBanco(intCodigoBanco) - CDbl(Me.txtValor.Text.Trim)

            Atualizar("UPDATE Banco SET Saldo = " & Num(dblSal) & " where Codigo = " & intCod)
            Atualizar("UPDATE Banco SET Saldo = " & Num(dblValSaldo) & " where Codigo = " & intCodigoBanco)
            Me.Close()
        Else
            Dim strMotivo As String = Me.txtObs.Text.Replace("TRANSFERÊNCIA CAIXA", "").Trim
            Inserir("INSERT INTO MovimentoBancario (CodBanco, TipoMovimento, Valor, Data, Observacao, CodConfig)VALUES(" & _
            "" & intCod & ",'CRÉDITO'," & Num(Me.txtValor.Text.Trim) & ",'" & Me.dtData.Text.Trim & "','TRANSFERÊNCIA CAIXA" & strMotivo & "'," & intCodConfig & ")")

            Dim strAuxiliar As String
            strAuxiliar = NomeComputador.ToUpper & " " & Format(My.Computer.Clock.LocalTime, "dd/MM/yyyy HH:mm:ss:fffff")

            Inserir("INSERT INTO Caixa (Motivo, Credito, Data, Pagamento, Valor, Caixa, CentroCusto, CodConfig, Auxiliar) VALUES ('" & _
            "TRANSFERÊNCIA CAIXA" & strMotivo & " - " & Me.cboBanco.Text & "','D','" & Me.dtData.Text.Trim & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now) & "','" & Me.cboTipoMov.Text & "'," & Num(Me.txtValor.Text.Trim) & "," & _
            "'" & UserNano & "',''," & CodConfig & ",'" & strAuxiliar & "')")

            Atualizar("UPDATE Banco SET Saldo = " & Num(dblSal) & " where Codigo = " & intCod)
            MsgBox("Transferência salva com sucesso!", MsgBoxStyle.Information)
            Me.Close()
        End If
   


        Limpar()
    End Sub

    Private Sub cboBanco_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBanco.Leave
        Dim strNome As String = Me.cboBanco.Text

        If Me.Tag = "BANCO" Then
            Me.txtObs.Text = "TRANSFERÊNCIA BANCO " & strNomeBanco & " PARA " & strNome
        End If

        Dim dtBanco As DataTable = CarregarDataTable("SELECT Codigo, Saldo FROM Banco where Nome = '" & strNome & "'")
        If dtBanco.Rows.Count > 0 Then
            intCod = dtBanco.Rows.Item(0).Item("Codigo").ToString
            Me.txtSaldo.Text = SaldoBanco(intCod).ToString("###,###,###,##0.00")
        End If
       
        Me.cboTipoMov.Focus()
    End Sub
    Private Shared Function SaldoBanco(ByVal parCodigo As String) As Double
        If parCodigo = "" Then Exit Function
        Dim dblCred, dblDeb As Double
        Dim dblSaldo As Double = 0
        Dim dtBanco As DataTable
        dtBanco = CarregarDataTable("Select sum(Valor) as Valor from MovimentoBancario where TipoMovimento ='CRÉDITO' and CodBanco =" & parCodigo)

        If dtBanco.Rows.Count > 0 Then
            If dtBanco.Rows(0).Item("Valor").ToString <> "" Then
                dblCred = dtBanco.Rows(0).Item("Valor").ToString
            End If
        End If

        dtBanco = CarregarDataTable("Select sum(Valor) as Valor from MovimentoBancario where TipoMovimento ='DÉBITO' and CodBanco =" & parCodigo)

        If dtBanco.Rows.Count > 0 Then
            If dtBanco.Rows(0).Item("Valor").ToString <> "" Then
                dblDeb = dtBanco.Rows(0).Item("Valor").ToString
            End If

        End If

        dblSaldo = dblCred - dblDeb


        Return dblSaldo


    End Function
    Private Sub txtValor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValor.Leave
        If Me.txtValor.Text = "" Then Exit Sub
        Dim dblSaldo, dblValor, dblSaldoAtual As Double
        dblSaldo = Me.txtSaldo.Text
        dblValor = Me.txtValor.Text
        If Me.Tag = "MOVIMENTACAO" Then
            Select Case Me.cboTipoMov.SelectedIndex
                Case 0
                    dblSaldoAtual = dblSaldo - dblValor
                Case 1
                    dblSaldoAtual = dblSaldo + dblValor
            End Select
        Else
            dblSaldoAtual = dblSaldo + dblValor
        End If
      
        dblSal = dblSaldoAtual.ToString("0.00")
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If MsgBox("Deseja realmente limpar todos os campos?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Limpar()
        End If
    End Sub

    Private Sub lueLoja_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueLoja.TextChanged
        If Me.lueLoja.EditValue.ToString <> "" Then
            intCodConfig = Me.lueLoja.EditValue
        End If
    End Sub

    Private Sub txtObs_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtObs.KeyPress
        If e.KeyChar = "'" Or e.KeyChar = "&" Then
            e.Handled = True
        End If
    End Sub
End Class