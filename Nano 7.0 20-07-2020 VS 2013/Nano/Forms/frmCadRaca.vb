Imports Nano.clsFuncoes
Imports Nano.clsValidar
Public Class frmCadRaca
    Dim bolAlterado As Boolean = False
    Dim intCod As Integer

    Private Sub frmCadRaca_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmCadAnimal.cboRaca.Properties.Items.Clear()
        Dim i As Integer
        Dim dtRaca As DataTable
        dtRaca = CarregarDataTable("Select * from grupo where tipo = 'R'")
        For i = 0 To dtRaca.Rows.Count - 1
            frmCadAnimal.cboRaca.Properties.Items.Add(dtRaca.Rows.Item(i).Item("Nome"))
        Next
    End Sub

    Private Sub frmCadRaca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarDados("Select Nome,Codigo from grupo where tipo = 'R'", grid1)
    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        If txtNome.Text = Nothing Then
            MsgBox("O campo NOME é obrigatório!!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If bolAlterado = False Then

            If Existe("Nome", "Grupo", "Nome", Me.txtNome.Text.Trim, False) = True Then
                MsgBox("Já existe uma raça cadastrada com esse nome!", MsgBoxStyle.Information)
                Me.txtNome.ResetText()
                Exit Sub
            End If

            If Inserir("INSERT INTO Grupo (Nome, Tipo) VALUES ('" & Me.txtNome.Text.Trim & "','R')") = True Then
                MsgBox("Dados salvos com sucesso!", MsgBoxStyle.Information)
            Else
                MsgBox("Os dados não foram salvos!", MsgBoxStyle.Information)
                Exit Sub
            End If
        Else
            Atualizar("update grupo set Nome='" & txtNome.Text & "' where codigo=" & intCod)
            MsgBox("Raça alterado com sucesso!", MsgBoxStyle.Information)
        End If
        CarregarDados("Select Nome,Codigo from grupo where tipo = 'R'", grid1)
        limpar()
    End Sub
    Private Sub Alterar()
        If Me.GridView1.FocusedRowHandle < 0 Then Exit Sub
        intCod = Me.GridView1.GetRowCellDisplayText(Me.GridView1.FocusedRowHandle, colCodigo)
        bolAlterado = True
        Me.txtNome.Text = Me.GridView1.GetRowCellDisplayText(Me.GridView1.FocusedRowHandle, colNome)
    End Sub
    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        Alterar()
    End Sub

    Private Sub btnAlterar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterar.ItemClick
        Alterar()
    End Sub
    Private Sub Limpar()
        txtNome.ResetText()
        bolAlterado = False
    End Sub
    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick

        If MsgBox("Deseja limpar todos os campos?", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Limpar()
        End If
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        If MsgBox("Deseja excluir realmente a Raça?", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.Yes Then

            If Me.GridView1.FocusedRowHandle < 0 Then Exit Sub

            intcod = Me.GridView1.GetRowCellDisplayText(GridView1.FocusedRowHandle, colCodigo)
            Excluir("Delete grupo where codigo =" & intcod)
            MsgBox("Raça excluída com sucesso!", MsgBoxStyle.Information)
            CarregarDados("Select Nome,Codigo from grupo where tipo = 'R'", grid1)
            Limpar()

        End If

    End Sub
End Class