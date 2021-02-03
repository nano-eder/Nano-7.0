Imports Nano.clsFuncoes
Public Class frmCadAtivo

    Dim intCodigo As Integer
    Dim bolAlterar As Boolean = False
    Dim strCodPadrao As String

    Private Sub AtualizarGrid()
        CarregarDados("SELECT Codigo, Nome, Valor, CodPadrao FROM Ativo", Me.GridControl1)
    End Sub
    Private Sub frmCadAtivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AtualizarGrid()
    End Sub
    Private Sub Limpar()
        strCodPadrao = ""
        bolAlterar = False
        Me.txtCodPadrao.ResetText()
        Me.txtNome.ResetText()
        Me.txtValor.ResetText()
        Me.txtCodPadrao.Focus()
    End Sub
    Private Sub Alterar()
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        bolAlterar = True
        strCodPadrao = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodPadrao)
        intCodigo = Me.grd1.GetRowCellValue(Me.grd1.FocusedRowHandle, Me.colCodigo)
        Me.txtCodPadrao.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodPadrao)
        Me.txtNome.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colNome)
        Me.txtValor.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colValor)
    End Sub
    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        If Validar(Me.txtCodPadrao) = False Then Exit Sub
        If Validar(Me.txtNome) = False Then Exit Sub
        If Validar(Me.txtValor) = False Then Exit Sub

        Try
            If bolAlterar = False Then
                Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM Ativo where CodPadrao = '" & Me.txtCodPadrao.Text.Trim & "'")
                If dt.Rows.Count > 0 Then
                    MsgBox("Código já adicionado para outro Barril/Chopeira!", MsgBoxStyle.Information)
                    Exit Sub
                End If
                Inserir("INSERT INTO Ativo (CodPadrao, Nome, Valor) VALUES ('" & Me.txtCodPadrao.Text & "'," & _
                "'" & Me.txtNome.Text & "'," & Num(Me.txtValor.Text) & ")")

            Else
                If strCodPadrao <> Me.txtCodPadrao.Text.Trim Then
                    Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM Ativo where CodPadrao = '" & Me.txtCodPadrao.Text.Trim & "'")
                    If dt.Rows.Count > 0 Then
                        MsgBox("Código já adicionado para outro Barril/Chopeira!", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                End If
                Atualizar("UPDATE Ativo SET CodPadrao = '" & Me.txtCodPadrao.Text & "', Nome = '" & Me.txtNome.Text & "', " & _
                "Valor = " & Num(Me.txtValor.Text) & " where Codigo = " & intCodigo)
            End If

            MsgBox("Barril/Chopeira salvo com sucesso!", MsgBoxStyle.Information)
        Catch ex As Exception

        End Try
        
        AtualizarGrid()
        Limpar()
    End Sub

    Private Sub btnAlterar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterar.ItemClick
        Alterar()
    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If MsgBox("Tem certeza que deseja limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Limpar()
        End If
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        If grd1.RowCount = 0 Then Exit Sub
        Dim Index As Integer = grd1.FocusedRowHandle
        If Index < 0 Then Exit Sub

        Dim intCod As Integer = grd1.GetRowCellDisplayText(Index, Me.colCodigo)

        Dim strCliente As String = grd1.GetRowCellDisplayText(Index, Me.colNome)

        If MsgBox("Deseja realmente excluir o ativo " & strCliente & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If Excluir("Delete from Ativo where Codigo = " & intCod) = True Then
                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strCliente & "','EXCLUÍDO','NOME','ATIVO','EXCLUSÃO'," & CodConfig & ")")

                MsgBox("Barril/Chopeira excluído com sucesso!", MsgBoxStyle.Information)
            End If

            AtualizarGrid()

        End If
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        If Me.Tag = "VENDA" Then
            CodigoAtivo = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)
            Me.Close()
            Exit Sub
        Else
            Alterar()
        End If
    End Sub
End Class