Imports Nano.clsFuncoes
Public Class frmTamanhoProd
    Public dblQtdVenda As Double

    Private Sub frmTamanhoProd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmTamanhoProd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Tag = "QTDE" Then
            Me.cboQtd.Visible = True
            Me.lueTamanho.Visible = False
            Me.lblTamanho.Text = "Qtde a ser excluída"
            Me.lblSelecao.Text = "Selecione ou Digite a qtde e precione 'ENTER'"
            Me.Text = "Excluir Qtde"
            Me.cboQtd.SelectedIndex = 0
            Me.cboQtd.Text = dblQtdVenda

            Dim I As Integer
            Me.cboQtd.Properties.Items.Clear()
            Dim intQtd As Integer = dblQtdVenda

            For I = 0 To intQtd - 1
                Me.cboQtd.Properties.Items.Add(I + 1)
            Next

        ElseIf Me.Tag = "TABELA" Then

            Me.cboQtd.Visible = True
            Me.lueTamanho.Visible = False
            Me.lblTamanho.Text = "Selecione a tabela de preço"
            Me.lblSelecao.Text = "Selecione ou Digite a Tabela e precione 'ENTER'"
            Me.Text = "Tabela de Preço"
            Me.cboQtd.SelectedIndex = 0


            Dim I As Integer
            Me.cboQtd.Properties.Items.Clear()
            Dim dt As DataTable

            dt = CarregarDataTable("Select Nome From Grupo where Tipo = 'T'")

            Me.cboQtd.Properties.Items.Add("PADRÃO")

            For I = 0 To dt.Rows.Count - 1
                Me.cboQtd.Properties.Items.Add(dt.Rows.Item(I).Item("Nome"))
            Next

            Me.cboQtd.Text = frmVenda.lblTabela.Caption

        ElseIf Me.Tag = "COMANDA" Then

            Me.cboQtd.Visible = True
            Me.lueTamanho.Visible = False
            Me.lblTamanho.Text = "Qtde de Pessoas na mesa"
            Me.lblSelecao.Text = "Selecione ou Digite a qtde de pessoas na mesa e precione 'ENTER'"
            Me.Text = "Qtde de Pessoas na mesa"
            Me.cboQtd.SelectedIndex = 0
            Me.cboQtd.Text = dblQtdVenda

            Dim I As Integer
            Me.cboQtd.Properties.Items.Clear()
            Dim intQtd As Integer = dblQtdVenda

            For I = 0 To 30
                Me.cboQtd.Properties.Items.Add(I)
            Next
            If QtdePessoasMesa <> "0" And QtdePessoasMesa <> "" Then
                Me.cboQtd.Text = QtdePessoasMesa
            End If
        Else
            CarregarDadosLue(Me.Tag, Me.lueTamanho)
        End If

    End Sub


    Private Sub lueTamanho_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lueTamanho.KeyDown
        If Me.lueTamanho.Text.Trim = "" Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            TamanhoDoProduto = Me.lueTamanho.Text.Trim
            Me.Close()
        End If
    End Sub

    Private Sub cboQtd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboQtd.KeyDown

        If Me.Tag = "QTDE" Then
            If e.KeyCode = Keys.Enter Then
                Dim dblQtd As Double = Me.cboQtd.Text
                If dblQtd > dblQtdVenda Then
                    MsgBox("Não é possível informar esta qtd pois ela é maior que a qtd do item na venda!", MsgBoxStyle.Information)
                    Exit Sub
                End If
                QtdeExcluida = Me.cboQtd.Text
                Me.Close()
            End If
        End If

        If Me.Tag = "TABELA" Then
            If e.KeyCode = Keys.Enter Then
                frmVenda.lblTabela.Caption = Me.cboQtd.Text

                Dim dt As DataTable

                dt = CarregarDataTable("Select Codigo from Grupo where Nome = '" & Me.cboQtd.Text.Trim & "'")

                If dt.Rows.Count > 0 Then
                    frmVenda.intCodTabelaPreco = dt.Rows.Item(0).Item("Codigo")
                End If

                Me.Close()
            End If
        End If

        If Me.Tag = "COMANDA" Then
            If e.KeyCode = Keys.Enter Then
                If Me.cboQtd.Text <> "" Then
                    Dim dblQtd As Double = Me.cboQtd.Text
                    'If dblQtd > 30 Then
                    '    MsgBox("Não é possível informar esta qtd pois ela é maior que a qtd do item na venda!", MsgBoxStyle.Information)
                    '    Exit Sub
                    'End If
                    QtdePessoasMesa = Me.cboQtd.Text
                    Me.Close()
                End If
              
            End If
        End If
    End Sub

    Private Sub cboQtd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboQtd.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
End Class