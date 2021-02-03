Imports Nano.clsFuncoes
Imports Nano.clsGerarArqs
Imports Nano.clsFuncoesBematech
Public Class frmPagamento
    Public intCod As Integer
    Public bolAlterar As Boolean
    Dim bolCartao As Boolean = False
    Dim strIrCaixa As String = "SIM"
    Dim strDescricaoAntiga As String

    Private Sub Limpar()
        Me.rdgUsaTEF.SelectedIndex = 1
        Me.rdgUsaTEF.Enabled = False
        Me.txtDesconto.ResetText()
        Me.txtDescricao.ResetText()
        Me.txtNDias.ResetText()
        Me.txtDesconto.ResetText()
        Me.rdgCar.SelectedIndex = 0
        bolCartao = False
        Me.cboPag.SelectedIndex = -1
        strIrCaixa = "SIM"
        Me.rdgIr.SelectedIndex = 0
        bolAlterar = False
        Me.txtDescricao.Focus()
        Me.lueBanco.EditValue = DBNull.Value
        Me.lueBanco.ClosePopup()

        Me.seDias.Enabled = False
        Me.seDias.Text = "30"
    End Sub
    Private Sub Alterar()
        bolAlterar = True
        Dim intIndex As Integer = Me.grd1.FocusedRowHandle
        With Me.grd1
            intCod = .GetRowCellDisplayText(intIndex, Me.colCodigo)
            Me.txtDescricao.Text = .GetRowCellDisplayText(intIndex, Me.colDescricao)
            strDescricaoAntiga = .GetRowCellDisplayText(intIndex, Me.colDescricao)
            Me.txtDesconto.Text = .GetRowCellDisplayText(intIndex, Me.colDesconto)
            Me.txtNDias.Text = .GetRowCellDisplayText(intIndex, Me.colDias)
            Me.cboPag.Text = .GetRowCellDisplayText(intIndex, Me.colFormaPagamento)

            If Me.cboPag.Text = "A PRAZO" Then
                If .GetRowCellDisplayText(intIndex, Me.colNumDias) = "" Then
                    Me.seDias.Text = "30"
                Else
                    Me.seDias.Text = .GetRowCellDisplayText(intIndex, Me.colNumDias)
                End If

                Me.seDias.Enabled = True
            Else
                Me.seDias.Text = "30"
                Me.seDias.Enabled = False
            End If
            Me.lueBanco.EditValue = DBNull.Value
            Me.lueBanco.Text = .GetRowCellDisplayText(intIndex, Me.colBanco)
            Me.lueBanco.ClosePopup()

            If .GetRowCellValue(intIndex, Me.colCartao) = False Then
                Me.rdgCar.SelectedIndex = 0
                bolCartao = False
                Me.lueBanco.Enabled = False
                If Me.txtDescricao.Text.Contains("BOLETO") = True Then
                    Me.lueBanco.Enabled = True
                End If
            Else
                Me.seDias.Text = "30"
                Me.seDias.Enabled = False
                Me.rdgCar.SelectedIndex = 1
                bolCartao = True

                Me.lueBanco.Enabled = True
            End If

            If .GetRowCellDisplayText(intIndex, Me.colIrCaixa) = "SIM" Then
                Me.rdgIr.SelectedIndex = 0
                strIrCaixa = "SIM"
            Else
                Me.rdgIr.SelectedIndex = 1
                strIrCaixa = "NÃO"
            End If

            If .GetRowCellValue(intIndex, Me.colUsaTEF) = False Then
                Me.rdgUsaTEF.SelectedIndex = 1
            Else
                Me.rdgUsaTEF.SelectedIndex = 0
            End If
        End With
    End Sub

    Private Sub frmPagamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "91")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub


    Private Sub frmPagamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If TesteConexao() = False Then Exit Sub

        CarregarDadosLue("Select Codigo, Nome from Banco", Me.lueBanco)

        CarregarForm()

        bolAlterar = False
        Me.txtNDias.Enabled = False
        Me.txtDesconto.Enabled = False
        Me.rdgUsaTEF.SelectedIndex = 1
        Me.rdgUsaTEF.Enabled = False
    End Sub

    Private Sub CarregarForm()
        CarregarDados("SELECT Pagamento.Codigo, Descricao, Dias, Desconto, Prazo, FormaPagamento, IrCaixa, " & _
        "Nome, NumDias, UsaTEF FROM Pagamento Left Join Banco on Banco.Codigo = Pagamento.CodBanco", Me.PagamentoGridControl)
    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick

        If TesteConexao() = False Then Exit Sub

        If Validar(Me.txtDescricao) = False Then Exit Sub
        If Validar(Me.cboPag) = False Then Exit Sub
        If bolCartao = True Then
            If Me.txtNDias.Text.Trim = "" Then
                MsgBox("Favor preencha o campo 'Nº Dias' para a forma de pagamento " & Me.txtDescricao.Text, MsgBoxStyle.Information)
                Me.txtNDias.Focus()
                Exit Sub
            End If

            If Me.txtDesconto.Text.Trim = "" Then
                MsgBox("Favor preencha o campo '% Desc' para a forma de pagamento " & Me.txtDescricao.Text, MsgBoxStyle.Information)
                Me.txtDesconto.Focus()
                Exit Sub
            End If
        End If

        Dim intCodBanco As Integer = 0

        If Me.lueBanco.Text.Trim <> "" Then
            intCodBanco = Me.lueBanco.EditValue
        End If
        Dim strNumDias As String = Me.seDias.Text.Replace(",", "")

        If Me.cboPag.Text = "A VISTA" Then
            strNumDias = ""

        Else
            If bolCartao = False Then
                Dim dblDias As Double = strNumDias
                If dblDias < 0 Then
                    MsgBox("Favor informar o Nº Dias Venc.", MsgBoxStyle.Information)
                    Me.seDias.Focus()
                    Exit Sub
                End If
            End If
          
        End If

        Dim bolUsaTEF As Boolean = False
        If Me.rdgUsaTEF.SelectedIndex = 0 Then
            bolUsaTEF = True
        End If
        If bolAlterar = False Then
            If Existe("Descricao", "Pagamento", "Descricao", Me.txtDescricao.Text.Trim, False) = True Then
                MsgBox("Forma de Pagamento já cadastrada!", MsgBoxStyle.Information)
                Limpar()
                Exit Sub
            End If
            Inserir("INSERT INTO Pagamento(Descricao, Dias, Desconto, Prazo, FormaPagamento, IrCaixa, CodBanco, " & _
            "NumDias, UsaTEF) VALUES ('" & Me.txtDescricao.Text.Trim & "','" & Me.txtNDias.Text.Trim & "'," & _
            "'" & Me.txtDesconto.Text.Trim & "','" & bolCartao & "','" & Me.cboPag.Text & "','" & strIrCaixa & "'," & _
            "" & intCodBanco & ",'" & strNumDias & "','" & bolUsaTEF & "')")
            MsgBox("Formas de pagamento salvas com sucesso!", MsgBoxStyle.Information)
            intCod = Val(GerarCodigo("Pagamento", "Codigo", 0)) - 1
        Else
            Atualizar("UPDATE Pagamento SET Descricao = '" & Me.txtDescricao.Text.Trim & "', Dias = '" & Me.txtNDias.Text.Trim & "', " & _
            "Desconto = '" & Me.txtDesconto.Text.Trim & "', Prazo = '" & bolCartao & "', FormaPagamento = '" & Me.cboPag.Text & "', " & _
            "IrCaixa = '" & strIrCaixa & "', CodBanco =" & intCodBanco & ", NumDias = '" & strNumDias & "', UsaTEF = '" & bolUsaTEF & "' " & _
            "where Codigo = " & intCod)

            If strDescricaoAntiga <> Me.txtDescricao.Text.Trim Then
                Atualizar("UPDATE Futuro set Pagamento ='" & Me.txtDescricao.Text.Trim & "' where Pagamento ='" & strDescricaoAntiga & "'")
            End If

            MsgBox("Formas de pagamento alterada com sucesso!", MsgBoxStyle.Information)
        End If

        'If ImprimirCupomFiscal = True Then
        '    ArqPagamento("UNICO", False, intCod)
        If PafEcfNano = True Or SATFiscal = True Then
            CadastrarFormasPagamento(Me.txtDescricao.Text.Trim)

        End If

        'End If

        bolAlterar = False

        CarregarForm()

        Limpar()
    End Sub

    Private Sub btnCancelar_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        If grd1.FocusedRowHandle < 0 Then Exit Sub
        If MsgBox("Deseja realmente excluir essa Forma de Pagamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

          
            If Excluir("Delete from Pagamento where Codigo = " & grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodigo)) = True Then
                MsgBox("Forma de Pagamento excluída com sucesso!", MsgBoxStyle.Information)

                'If ImprimirCupomFiscal = True Then
                '    ArqPagamento("UNICO", True, grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodigo))
                'End If

                Me.grd1.DeleteRow(Me.grd1.FocusedRowHandle)
            End If
        End If


        Limpar()
    End Sub

    Private Sub txtNDias_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDesconto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "," And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        Alterar()
    End Sub

    Private Sub btnAlterar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterar.ItemClick
        Alterar()
    End Sub


    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        Limpar()
    End Sub

    Private Sub rdgCar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgCar.SelectedIndexChanged
        Select Case Me.rdgCar.SelectedIndex
            Case 0
                bolCartao = False
                Me.txtNDias.ResetText()
                Me.txtDesconto.ResetText()
                'Me.lueBanco.EditValue = DBNull.Value
                'Me.lueBanco.ClosePopup()
                Me.seDias.Enabled = True
                Me.rdgUsaTEF.SelectedIndex = 1
            Case 1
                bolCartao = True
                Me.seDias.Text = "30"
                Me.seDias.Enabled = False
        End Select
        
        Me.txtNDias.Enabled = bolCartao
        Me.txtDesconto.Enabled = bolCartao
        Me.rdgUsaTEF.Enabled = bolCartao
        If Me.txtDescricao.Text.Contains("BOLETO") = True Then
            Me.lueBanco.Enabled = True
        Else
            Me.lueBanco.Enabled = bolCartao
        End If


    End Sub

    Private Sub rdgIr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgIr.SelectedIndexChanged
        Select Case rdgIr.SelectedIndex

            Case 0
                strIrCaixa = "SIM"
            Case 1
                strIrCaixa = "NÃO"

        End Select
    End Sub

    Private Sub btnCadBanco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadBanco.Click
        frmCadBanco.ShowDialog()
        CarregarDadosLue("Select Codigo, Nome from Banco", Me.lueBanco)
    End Sub


    Private Sub txtDescricao_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescricao.Leave
        If Me.txtDescricao.Text.Contains("BOLETO") = True Then
            Me.lueBanco.Enabled = True
        End If
    End Sub

    Private Sub cboPag_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPag.SelectedIndexChanged
        If Me.cboPag.Text = "A PRAZO" Then
            Me.seDias.Enabled = True
        Else
            Me.seDias.Enabled = False
        End If
    End Sub
End Class