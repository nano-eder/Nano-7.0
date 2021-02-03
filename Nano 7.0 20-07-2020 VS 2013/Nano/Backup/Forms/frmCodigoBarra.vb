Imports Nano.clsFuncoes
Public Class frmCodigoBarra
    Public intCodProd As Integer
    Dim intCodigo As Integer
    Public bolAlterar As Boolean

    Private Sub frmCodigoBarra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.Tag <> "CADASTRO" Then
                If grd1.FocusedRowHandle < 0 Then Exit Sub

                CodigoDoProduto = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodProd)
                Me.Close()
                Exit Sub
            End If

        End If
       

    End Sub
    Private Sub frmCodigoBarra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    
        If TesteConexao() = False Then Exit Sub
        Me.Text = "Cadastro de Códigos de Barras"
        Me.grpCad.Text = "Códigos Cadastrados"
        Me.colCodigoBarra.Caption = "Código Barras"
        Me.colCodigoInterno.Caption = "Cód. Interno"
        Limpar()
        Me.grd1.ClearColumnsFilter()
        AtualizarGrid()
        bolAlterar = False
        If Me.Tag = "CADASTRO" Then
            Me.txtCodigoBarra.Focus()
            Me.grpCad.Dock = DockStyle.Bottom
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
          
        Else
            Me.grpCad.Dock = DockStyle.Fill
            Dim index As Integer = -999997
            grd1.FocusedRowHandle = index
            grd1.FocusedColumn = Me.colCodigoBarra
            grd1.ShowEditor()
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            If Me.Tag = "VINCULO" Then
                Me.Text = "Vinculo Produto"
                Me.grpCad.Text = "Produtos Vinculados"
            End If
        End If

    End Sub
    Private Sub AtualizarGrid()

        If Me.Tag = "CADASTRO" Then
            Me.colCodigoInterno.Visible = False
            Me.colProduto.Visible = False
            CarregarDados("SELECT * FROM CodigoBarra WHERE CodProd = " & intCodProd & " and Produto ='' or CodProd = " & intCodProd & " and Produto is null", Me.GrupoGridControl)
        ElseIf Me.Tag = "VINCULO" Then
            Me.colCodigoBarra.Caption = "Cód. Prod. Forn."
            Me.colCodigoInterno.Caption = "Fornecedor"
            CarregarDados("SELECT CodigoBarra, Fornecedor.Nome as CodigoInterno, Produto FROM CodigoBarra left join Fornecedor on CodigoBarra.CodFor = Fornecedor.Codigo WHERE CodProd = " & intCodProd & " and Produto <>''", Me.GrupoGridControl)
        Else
            Me.colCodigoInterno.Visible = True
            Me.colProduto.Visible = True
            Me.grpCad.Dock = DockStyle.Fill
         
            CarregarDados("SELECT Produto.Codigo, Produto.CodigoBarra, Produto.Nome as Produto, PRoduto.CodigoInterno, Produto.Codigo as CodProd FROM Produto where CodigoBarra <> '' UNION ALL SELECT CodigoBarra.Codigo, CodigoBarra.CodigoBarra, Produto.Nome as Produto, " & _
            "Produto.CodigoInterno, Produto.Codigo as CodProd FROM CodigoBarra left join Produto on CodigoBarra.CodProd = Produto.Codigo", Me.GrupoGridControl)
        End If
      

    End Sub
    Private Sub Limpar()
        Me.txtCodigoBarra.ResetText()
        bolAlterar = False
        Me.txtCodigoBarra.Focus()
    End Sub
    Private Sub Alterar()
        bolAlterar = True
        intCodigo = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)
        Me.txtCodigoBarra.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigoBarra)
    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick

        If TesteConexao() = False Then Exit Sub

        If Validar(Me.txtCodigoBarra) = False Then Exit Sub

        If bolAlterar = False Then
            If Existe("CodigoBarra", "Produto", "CodigoBarra", Me.txtCodigoBarra.Text.Trim, False) = True Then
                MsgBox("Já existe um produto cadastrado com esse código de barras!", MsgBoxStyle.Information)
                Me.txtCodigoBarra.ResetText()
                Exit Sub
            End If
            If Existe("CodigoBarra", "Produto", "CodigoInterno", Me.txtCodigoBarra.Text.Trim, False) = True Then
                MsgBox("Já existe um produto cadastrado com esse código de barras!", MsgBoxStyle.Information)
                Me.txtCodigoBarra.ResetText()
                Exit Sub
            End If
            If Existe("CodigoBarra", "CodigoBarra", "CodigoBarra", Me.txtCodigoBarra.Text.Trim, False) = True Then
                MsgBox("Já existe um produto cadastrado com esse código de barras!", MsgBoxStyle.Information)
                Me.txtCodigoBarra.ResetText()
                Exit Sub
            End If

            If Inserir("INSERT INTO CodigoBarra (CodProd, CodigoBarra) VALUES (" & intCodProd & ",'" & Me.txtCodigoBarra.Text.Trim & "')") = True Then
                MsgBox("Dados salvos com sucesso!", MsgBoxStyle.Information)
            Else
                MsgBox("Os dados não foram salvos!", MsgBoxStyle.Information)
                Exit Sub
            End If

        Else
            If Atualizar("UPDATE CodigoBarra SET CodigoBarra = '" & Me.txtCodigoBarra.Text.Trim & "' where Codigo = " & intCodigo) = True Then

                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information)

            Else
                MsgBox("Os dados não foram salvos!", MsgBoxStyle.Information)
            End If

        End If
        AtualizarGrid()
        Limpar()

    End Sub

    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        If grd1.FocusedRowHandle < 0 Then Exit Sub
        If grd1.RowCount = 0 Then Exit Sub
        Dim strNome As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigoBarra)

        If MsgBox("Deseja realmente excluir o código " & strNome & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Excluir("DELETE FROM CodigoBarra where Codigo = " & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo))
            MsgBox(strNome & " excluido com sucesso.", MsgBoxStyle.Information)
            AtualizarGrid()
            Limpar()
        End If

    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        If Me.Tag = "CADASTRO" Then
            Alterar()
        Else
            If grd1.FocusedRowHandle < 0 Then Exit Sub

            CodigoDoProduto = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodProd)
            Me.Close()
            Exit Sub

        End If

    End Sub

    Private Sub txtAlterar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlterar.KeyDown
        If Me.Tag = "CONSULTA" Then
            If e.KeyCode = Keys.Enter Then
                If grd1.FocusedRowHandle < 0 Then Exit Sub

                CodigoDoProduto = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodProd)
                Me.Close()
                Exit Sub
            End If
        End If
     
    End Sub

    Private Sub txtAlterar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAlterar.KeyPress
        'If grd1.FocusedRowHandle >= 0 Then
        '    Me.colNome.OptionsColumn.ReadOnly = True
        'Else
        '    Me.colNome.OptionsColumn.ReadOnly = False
        'End If
    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        Limpar()
    End Sub

    Private Sub btnAlterar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterar.ItemClick
        Alterar()
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Me.GrupoGridControl.ShowPrintPreview()
    End Sub
End Class