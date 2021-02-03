
Imports Nano.clsFuncoes
Imports Nano.clsDarBaixa
Public Class frmDescarte
    Dim bolAlterado As Boolean = False
    Dim intCodProd As Integer
    Dim dblCredito As Double
    Dim strUM As String
    Dim strFoco As String
    Dim strValCusto As String
    Dim intIndex As Integer
    Dim intQtdProd As Integer
    Dim bolNumerico As Boolean = False
    Dim dt As DataTable

    Private Sub frmDescarte_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "9")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmDescarte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub
        CarregarDadosLue("SELECT Nome, Codigo FROM Funcionario where Ativo ='True' and CodConfig =" & CodConfig, Me.lueFunc)
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)
        Me.lueFunc.Focus()
    End Sub
    Private Sub Alterar()
        bolAlterado = True
        Dim intIndex As Integer = Me.grd1.FocusedRowHandle
        With Me.grd1
            Me.txtTamanho.Text = .GetRowCellDisplayText(intIndex, Me.colTamanho)
            intCodProd = .GetRowCellDisplayText(intIndex, Me.colCodigo)
            Me.txtCodProd.Text = .GetRowCellDisplayText(intIndex, Me.colCodProdInterno)
            Me.txtProd.Text = .GetRowCellDisplayText(intIndex, Me.colProduto)
            Me.txtQtde.Text = .GetRowCellDisplayText(intIndex, Me.colQtde)
            Me.txtValor.Text = .GetRowCellDisplayText(intIndex, Me.colValorUni)
            Me.txtMotivo.Text = .GetRowCellDisplayText(intIndex, Me.colMotivo)
            If CDbl(Me.txtQtde.Text) > 0 Then
                strValCusto = CDbl(.GetRowCellDisplayText(intIndex, Me.colValorCusto)) / Me.txtQtde.Text
            Else
                strValCusto = .GetRowCellDisplayText(intIndex, Me.colValorCusto)
            End If


            strUM = .GetRowCellDisplayText(intIndex, Me.colUM)
        End With

        Me.txtValor.BackColor = Color.Bisque
        Me.txtQtde.BackColor = Color.Bisque
        Me.txtProd.BackColor = Color.Bisque
        Me.txtCodProd.BackColor = Color.Bisque
        Me.txtTamanho.BackColor = Color.Bisque

    End Sub
    Private Sub Limpar()
        Me.lueFunc.EditValue = DBNull.Value
        Me.txtMotivo.ResetText()
        Me.txtCodProd.ResetText()
        Me.txtProd.ResetText()
        Me.txtTamanho.ResetText()
        Me.txtQtde.ResetText()
        Me.txtValor.ResetText()
        Me.txtTotal.Text = ""
        Me.tbProd.Rows.Clear()
        Me.lueFunc.Focus()
        bolAlterado = False
    End Sub
    Private Sub Calcular()
        Dim I As Integer
        Dim dblVal, dblResul As Double
        For I = 0 To Me.tbProd.Rows.Count - 1
            dblVal = Me.grd1.GetRowCellDisplayText(I, Me.colValorTotal)
            dblResul += dblVal
        Next
        Me.txtTotal.Text = dblResul.ToString("###,###,###,##0.00")
    End Sub

    Private Sub BuscaProduto()
        CodigoDoProduto = 0
        Dim frm As New frmCadProduto
        frm.Tag = "DESCARTE"
        frm.ShowDialog()

        If CodigoDoProduto <> 0 Then
            bolNumerico = True
            Me.txtCodProd.Text = CodigoDoProduto
            InserirProduto(True)
        End If

    End Sub

    Private Sub txtCodProd_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodProd.ButtonClick
        BuscaProduto()
    End Sub
    Private Sub txtCodProd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodProd.Leave
        If bolNumerico = True Then bolNumerico = False : Exit Sub
        InserirProduto(False)
    End Sub


    Private Sub InserirProduto(ByVal parNumerico As Boolean)
        If Me.txtCodProd.Text = "" Then Exit Sub

        If parNumerico = False Then

            Dim vetCodProd As Array = Split(Me.txtCodProd.Text.Trim, "-")
            If vetCodProd.Length = 2 Then
                Me.chkTamanho.Checked = True
                Me.txtCodProd.Text = vetCodProd(0).ToString
                Me.txtTamanho.Text = vetCodProd(1).ToString
            End If

            If Existe("CodigoBarra", "Produto", "CodigoBarra", Me.txtCodProd.Text, False) = False Then
                If Existe("CodigoInterno", "Produto", "CodigoInterno", Me.txtCodProd.Text, False) = False Then
                    If Existe("CodigoBarra", "CodigoBarra", "CodigoBarra", Me.txtCodProd.Text, False) = False Then
                        MsgBox("Produto não cadastrado!", MsgBoxStyle.Information)
                        Me.txtCodProd.ResetText()
                        Me.txtProd.Focus()
                        Exit Sub
                    End If
                   
                End If

            End If
        End If

        If parNumerico = True Then
            dt = CarregarDataTable("SELECT Codigo, Nome, Valor, UnidadeMedida, ValorCusto, CodigoInterno FROM Produto where Codigo = " & Me.txtCodProd.Text.Trim)

        Else
            dt = CarregarDataTable("SELECT Codigo, Nome, Valor, UnidadeMedida, ValorCusto, CodigoInterno FROM Produto where CodigoInterno = '" & Me.txtCodProd.Text.Trim & "' or CodigoBarra = '" & Me.txtCodProd.Text.Trim & "'")
            If dt.Rows.Count = 0 Then
                Dim dtCodBarra As DataTable = CarregarDataTable("SELECT CodProd FROM CodigoBarra where CodigoBarra = '" & Me.txtCodProd.Text & "' and Produto = '' or CodigoBarra = '" & Me.txtCodProd.Text & "' and Produto is null")
                If dtCodBarra.Rows.Count > 0 Then
                    CodigoDoProduto = dtCodBarra.Rows.Item(0).Item("CodProd").ToString
                    dt = CarregarDataTable("Select  Codigo, Nome, Valor, UnidadeMedida, ValorCusto, CodigoInterno from Produto where Codigo=" & CodigoDoProduto)
                End If
            End If
        End If

        If dt.Rows.Count > 0 Then
            intCodProd = dt.Rows.Item(0).Item("Codigo").ToString
            Me.txtCodProd.Text = dt.Rows.Item(0).Item("CodigoInterno").ToString
            Me.txtProd.Text = dt.Rows.Item(0).Item("Nome").ToString
            Me.txtValor.Text = dt.Rows.Item(0).Item("Valor").ToString
            strUM = dt.Rows.Item(0).Item("UnidadeMedida").ToString
            strValCusto = dt.Rows.Item(0).Item("ValorCusto").ToString

            If Me.txtTamanho.Text.Trim = "" Then
                Dim dt2 As DataTable = CarregarDataTable("Select Tamanho from Qtde where CodProd =" & intCodProd & " and Tamanho <> 'U' and CodConfig =" & CodConfig)

                If dt2.Rows.Count = 0 Then
                    Me.chkTamanho.Checked = True
                Else
                    Me.chkTamanho.Checked = False
                End If
            End If
        Else
            Me.txtCodProd.ResetText()
            Me.txtCodProd.Focus()
        End If
    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click
        If Validar(Me.txtCodProd) = False Then Exit Sub
        If Validar(Me.txtProd) = False Then Exit Sub
        If Validar(Me.txtValor) = False Then Exit Sub
        If Validar(Me.lueFunc) = False Then Exit Sub

        Dim dblValorTotal, dblValorUni, dblValorCusto As Double
        Dim intQtde As Double
        dblValorUni = Me.txtValor.Text.Trim

        Dim dtProd As DataTable = CarregarDataTable("SELECT Codigo FROM Qtde where CodProd = " & intCodProd & " and Acabou ='False' and Tamanho = '" & Me.txtTamanho.Text.Trim & "' and CodConfig =" & CodConfig)
        If dtProd.Rows.Count > 0 Then

        Else
            MsgBox("Produto indisponível, verificar o tamanho!", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Me.txtQtde.Text.Trim = "" Then
            intQtde = 1
        Else
            intQtde = Me.txtQtde.Text.Trim
        End If

        dblValorTotal = intQtde * dblValorUni
        dblValorCusto = intQtde * strValCusto
        With Me.tbProd.Rows
            Select Case bolAlterado
                Case False
                    .Add()
                    .Item(.Count - 1).Item("Codigo") = intCodProd
                    .Item(.Count - 1).Item("CodProdInterno") = Me.txtCodProd.Text.Trim
                    .Item(.Count - 1).Item("Produto") = Me.txtProd.Text.Trim
                    .Item(.Count - 1).Item("Tamanho") = Me.txtTamanho.Text.Trim
                    .Item(.Count - 1).Item("Qtde") = intQtde.ToString("0.000")
                    .Item(.Count - 1).Item("ValorUni") = Me.txtValor.Text.Trim
                    .Item(.Count - 1).Item("ValorCusto") = dblValorCusto.ToString("0.00")
                    .Item(.Count - 1).Item("ValorTotal") = dblValorTotal.ToString("0.00")
                    .Item(.Count - 1).Item("Motivo") = Me.txtMotivo.Text.Trim
                    .Item(.Count - 1).Item("UM") = strUM
                Case True

                    .Item(intIndex).Item("Codigo") = intCodProd
                    .Item(intIndex).Item("CodProdInterno") = Me.txtCodProd.Text.Trim
                    .Item(intIndex).Item("Produto") = Me.txtProd.Text.Trim
                    .Item(intIndex).Item("Tamanho") = Me.txtTamanho.Text.Trim
                    .Item(intIndex).Item("Qtde") = intQtde
                    .Item(intIndex).Item("ValorUni") = Me.txtValor.Text.Trim
                    .Item(intIndex).Item("ValorCusto") = dblValorCusto.ToString("0.00")
                    .Item(intIndex).Item("ValorTotal") = dblValorTotal.ToString("0.00")
                    .Item(intIndex).Item("Motivo") = Me.txtMotivo.Text.Trim
                    .Item(intIndex).Item("UM") = strUM

                    Me.txtValor.BackColor = Color.White
                    Me.txtQtde.BackColor = Color.White
                    Me.txtProd.BackColor = Color.White
                    Me.txtCodProd.BackColor = Color.White
                    Me.txtTamanho.BackColor = Color.White
            End Select
        End With
        Calcular()

        bolAlterado = False
        Me.txtMotivo.ResetText()
        Me.txtValor.ResetText()
        Me.txtQtde.ResetText()
        Me.txtProd.ResetText()
        Me.txtCodProd.ResetText()
        Me.chkTamanho.Checked = False
        Me.txtMotivo.Focus()
    End Sub

 
    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        intIndex = Me.grd1.FocusedRowHandle
        Alterar()
    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick

        If TesteConexao() = False Then Exit Sub

        If Me.tbProd.Rows.Count <= 0 Then
            MsgBox("Não existem produtos a ser descartado!", MsgBoxStyle.Information)
            Exit Sub
        End If



        If Validar(Me.lueFunc) = False Then Exit Sub

        Dim I, intCodigo As Integer
        Dim strTamanho, strMotivo As String
        Dim dblValor, dblQtd As Double
        For I = 0 To Me.tbProd.Rows.Count - 1
            intCodigo = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)
            strTamanho = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho)
            dblValor = Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto)
            dblQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtde)
            strMotivo = Me.grd1.GetRowCellDisplayText(I, Me.colMotivo)
            strUM = Me.grd1.GetRowCellDisplayText(I, Me.colUM)
            Dim dblValorTotal As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValorTotal)
            Inserir("INSERT INTO Descarte (CodProd, Qtde, ValorUnitario, Motivo, Data, CodFunc, CodConfig, Tamanho, " & _
            "ValorTotal) VALUES (" & intCodigo & "," & Num(dblQtd) & "," & Num(dblValor) & ",'" & strMotivo & "'," & _
            "'" & Date.Today & "','" & Me.lueFunc.GetColumnValue("Codigo").ToString & "'," & CodConfig & "," & _
            "'" & strTamanho & "'," & Num(dblValorTotal) & ")")
            BaixarProduto(intCodigo, dblQtd, strTamanho, strUM, False, False)


            If EstoqueSomado = True Then
                dblQtd = dblQtd - (dblQtd + dblQtd)
                Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data, CodUser) VALUES (" & intCodigo & "," & Num(dblQtd) & "," & CodConfig & ",'DESCARTE','" & My.Computer.Clock.LocalTime & "'," & CodUser & ")")
            End If
        Next

        MsgBox("Descarte concluído com sucesso!", MsgBoxStyle.Information)
        Limpar()
    End Sub

    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        Select Case bolAlterado
            Case True
                MsgBox("Existe um item sendo alterado, conclua a alteração antes de excluir algum item!", MsgBoxStyle.Information)
                Exit Sub
            Case False
                If MsgBox("Deseja realmente excluir este produto?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    Me.grd1.DeleteRow(Me.grd1.FocusedRowHandle)
                    Calcular()
                End If
        End Select
    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If MsgBox("Tem certeza que deseja limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Limpar()
        End If
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub txtCodProd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodProd.KeyDown
        If e.KeyCode = Keys.F10 Then
            BuscaProduto()
        End If
    End Sub

    Private Sub txtQtde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQtde.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "-" And e.KeyChar <> "," Then
            e.Handled = True
        End If
        If e.KeyChar = "-" Then
            If Me.txtQtde.Text.Contains("-") Then
                If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
                    e.Handled = True
                End If
            Else
                If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "-" And e.KeyChar <> "," Then
                    e.Handled = True
                End If
            End If
        End If

        If e.KeyChar = "," Then
            If Me.txtQtde.Text.Contains(",") Then
                If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
                    e.Handled = True
                End If
            Else
                If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "-" And e.KeyChar <> "," Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub txtQtde_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtde.Leave
        'Select Case strUM
        '    Case "UN", "JG", "KIT"
        '        Me.txtQtde.CasasDecimais = 0
        '    Case "KG", "LT"
        '        Me.txtQtde.CasasDecimais = 3
        '    Case "MT"
        '        Me.txtQtde.CasasDecimais = 2
        'End Select
    End Sub

    Private Sub txtTamanho_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTamanho.Leave
        If Me.txtTamanho.Text.Trim = "" Then Exit Sub

        Dim dtTamanho As DataTable
        dtTamanho = CarregarDataTable("SELECT Qtd FROM Qtde where Tamanho = '" & Me.txtTamanho.Text.Trim & "' and CodProd = " & intCodProd & " and CodConfig = " & CodConfig)
        If dtTamanho.Rows.Count > 0 Then
            intQtdProd = dtTamanho.Rows.Item(0).Item("Qtd").ToString
        Else
            MsgBox("Não existe produto com este tamanho!", MsgBoxStyle.Information)

            Me.txtTamanho.ResetText()
            Me.txtTamanho.Focus()
        End If
    End Sub

    Private Sub chkTamanho_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTamanho.CheckedChanged
        Select Case Me.chkTamanho.Checked
            Case True
                Me.txtTamanho.Enabled = False
                Me.txtTamanho.Text = "U"
                Me.txtQtde.Focus()
            Case False
                Me.txtTamanho.Enabled = True
                Me.txtTamanho.Text = ""
                Me.txtTamanho.Focus()
        End Select
    End Sub

    Private Sub txtCodProd_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodProd.KeyPress
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
End Class