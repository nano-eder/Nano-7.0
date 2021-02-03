Imports Nano.clsFuncoes
Public Class frmMontaProduto

    Dim strCodInterno As String
    Dim strProduto As String = ""

    Private Sub btnCadOpc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadOpc.Click
        frmCadOpcoes.ShowDialog()
        CarregaTipoOpcoes()
    End Sub

    Private Sub txtCodProd_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodProd.KeyDown
        If e.KeyCode = Keys.F10 Then
            Dim frm As New frmConProduto
            frm.Tag = "VENDA"
            CodigoDoProduto = -1
            frm.ShowDialog()
            If CodigoDoProduto = -1 Then Exit Sub
            InserirProduto(True, False)

        End If
        If e.KeyCode = Keys.Enter Then

            InserirProduto(False, False)
        End If

    End Sub

    Private Sub InserirProduto(ByVal parPesquisaPorNome As Boolean, ByVal parConsignacao As Boolean, Optional ByVal parTamanho As String = "")

        Dim dtProd As DataTable
        Dim strTipo As String
        Dim dblValor As Double

        If parPesquisaPorNome = False Then
            If Me.txtCodProd.Text.Trim = "" Then Exit Sub
            dtProd = CarregarDataTable("Select Codigo, Nome, UnidadeMedida, ValorCusto, Valor, Desconto, Grupo, Tipo from Produto where Tipo <> 'CONSUMO' and CodigoInterno ='" & Me.txtCodProd.Text.Trim & "' or CodigoBarra ='" & Me.txtCodProd.Text.Trim & "'")
        Else
            dtProd = CarregarDataTable("Select Codigo, Nome, UnidadeMedida, ValorCusto, Valor, CodigoInterno, Desconto, Grupo, Tipo from Produto where Codigo=" & CodigoDoProduto & " and Tipo <> 'CONSUMO'")
            If dtProd.Rows.Count > 0 Then
                Me.txtCodProd.Text = dtProd.Rows.Item(0).Item("CodigoInterno")
            End If
        End If

        If dtProd.Rows.Count > 0 Then

            With dtProd.Rows.Item(0)
                Dim intCodProdAut As Integer

                intCodProdAut = .Item("Codigo").ToString

                Me.txtCodProd.Tag = intCodProdAut

                dblValor = .Item("Valor")
                strTipo = dtProd.Rows.Item(0).Item("Tipo").ToString


                'If strTipo.Trim <> "RECEITA" Then
                '    MsgBox("Produto não pode ser vendido de forma mista!", MsgBoxStyle.Information)
                '    Limpar()
                '    Exit Sub
                'End If

                Me.tbProd.Rows.Add()

                Me.tbProd.Rows.Item(tbProd.Rows.Count - 1).Item("CodProd") = .Item("Codigo").ToString
                Me.tbProd.Rows.Item(tbProd.Rows.Count - 1).Item("Codigo") = Me.txtCodProd.Text.Trim
                Me.tbProd.Rows.Item(tbProd.Rows.Count - 1).Item("Produto") = .Item("Nome").ToString
                Me.tbProd.Rows.Item(tbProd.Rows.Count - 1).Item("Valor") = dblValor.ToString("0.00")

                Limpar()
            End With
        Else

            Limpar()
            Exit Sub
        End If

    End Sub

    Private Sub Limpar()
        Me.txtCodProd.Tag = ""
        Me.txtCodProd.ResetText()
        Me.txtCodProd.Focus()
        Calcular()
    End Sub

    Private Sub frmMontaProduto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregaTipoOpcoes()
        If Nivel = "USUÁRIO" Then
            Me.btnCadOpc.Visible = False
        End If
    End Sub

    Private Sub CarregaTipoOpcoes()
        Me.lstOpc.Items.Clear()

        Dim dt As DataTable = CarregarDataTable("Select Sum(Codigo), Tipo from ProdOpc group by Tipo")

        Dim I As Integer

        For I = 0 To dt.Rows.Count - 1
            Me.lstOpc.Items.Add(dt.Rows.Item(I).Item("Tipo").ToString)
        Next
    End Sub

    Private Sub CarregaOpcionais(ByVal parTipo As String)
        CarregarDados("Select Produto as Descricao, Valor, 0 as Codigo  from ProdOpc where Tipo ='" & parTipo & "'", Me.GridOpc)
    End Sub

    Private Sub lstOpc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstOpc.SelectedIndexChanged
        CarregaOpcionais(Me.lstOpc.SelectedItem)
    End Sub

   
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Me.tbOpc.Rows.Add()
        strProduto = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colProduto)
        Me.tbOpc.Rows.Item(Me.tbOpc.Rows.Count - 1).Item("Descricao") = Me.lstOpc.SelectedItem & " - " & Me.grd3.GetRowCellDisplayText(Me.grd3.FocusedRowHandle, Me.colDescricao1) '& " (" & strProduto & ")"
        Me.tbOpc.Rows.Item(Me.tbOpc.Rows.Count - 1).Item("Valor") = Me.grd3.GetRowCellDisplayText(Me.grd3.FocusedRowHandle, Me.colValor2)
        Calcular()
    End Sub

    Private Sub btnRem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRem1.Click
        If Me.grd1.FocusedRowHandle >= 0 Then
            Me.tbProd.Rows.RemoveAt(Me.grd1.FocusedRowHandle)
        End If
        Calcular()
    End Sub

    Private Sub btnRem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRem2.Click
        If Me.grd2.FocusedRowHandle >= 0 Then
            Me.tbOpc.Rows.RemoveAt(Me.grd2.FocusedRowHandle)
        End If
        Calcular()
    End Sub

    Private Sub memObs_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles memObs.KeyPress
        If e.KeyChar = "'" Or e.KeyChar = "&" Then
            e.Handled = True
        End If
    End Sub

    Private Sub Calcular()
        Dim I As Integer

        Dim dblValor, dblValorMaior, dblResul As Double

        For I = 0 To grd1.RowCount - 1
            dblValor = Me.grd1.GetRowCellDisplayText(I, Me.colValor)

            If dblValor > dblValorMaior Then
                dblValorMaior = dblValor
                Me.txtValor.Tag = Me.grd1.GetRowCellDisplayText(I, Me.colCodProd)
                strCodInterno = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)
            End If
        Next

        For I = 0 To grd2.RowCount - 1
            If Me.grd2.GetRowCellDisplayText(I, Me.colValor1) <> "" Then
                dblResul += Me.grd2.GetRowCellDisplayText(I, Me.colValor1)
            End If

        Next

        dblResul += dblValorMaior

        Me.txtValor.Text = dblResul.ToString("0.00")


        If dblValorMaior = 0 Then
            strCodInterno = Me.grd1.GetRowCellDisplayText(0, Me.colCodigo)
        End If
    End Sub

    Private Sub btnConcluido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConcluido.Click

        If Me.grd1.RowCount = 0 Then MsgBox("Não há nenhum produto adicionado!", MsgBoxStyle.Information) : Exit Sub

        Dim I As Integer

        For I = 0 To Me.grd1.RowCount - 1
            ListaProduto &= Me.grd1.GetRowCellDisplayText(I, Me.colProduto) & "|"
        Next

        For I = 0 To Me.grd2.RowCount - 1
            ListaOpcoes &= Me.grd2.GetRowCellDisplayText(I, Me.colDescricao) & "|"
        Next

        PrecoProdutoOpcoes = Me.txtValor.Text.Trim
        CodigoProdutoOpcoes = Me.txtValor.Tag
        CodigoInternoProdutoOpcoes = strCodInterno
        ObsOpcoes = Me.memObs.Text.Replace("'", "").Replace("&", "")
        Me.Close()

    End Sub
End Class