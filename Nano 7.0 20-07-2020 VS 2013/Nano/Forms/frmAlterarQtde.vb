Imports Nano.clsFuncoes
Public Class frmAlterarQtde
    Public strUM As Integer
    Public strLoja As String
    Public strCodProd As String
    Public strProd As String
    Public strCodigoInterno As String

    Private Sub frmAlterarQtde_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Calcular()

        Me.txtLoja.Text = strLoja
        Me.txtProduto.Text = strProd
        Me.txtCodInterno.Text = strCodigoInterno
        Me.Timer1.Start()
    End Sub

    Private Sub Limpar()
        Me.txtLoja.ResetText()
        Me.txtProduto.ResetText()
        Me.txtQtdNova.ResetText()
        Me.txtQtde.ResetText()

    End Sub
    Private Sub Calcular()

        Dim dblResul As Double = AjusteQtde(strLoja, strCodProd)

        Me.txtQtde.Text = dblResul

        Me.txtQtdNova.Text = dblResul
    End Sub
    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick

        If Validar(Me.txtQtdNova) = False Then Exit Sub

        If Me.txtQtde.Text = Me.txtQtdNova.Text Then Exit Sub


        Dim dblQtde As Double = Me.txtQtde.Text
        Dim dblQtdeNova As Double = Me.txtQtdNova.Text
        Dim dblResul As Double = dblQtdeNova - dblQtde

        Try
            Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data, CodUser) VALUES (" & strCodProd & "," & Num(dblResul) & "," & strLoja & ",'QTDE','" & My.Computer.Clock.LocalTime & "'," & CodUser & ")")

            Atualizar("Update Qtde set Qtd =" & Num(dblQtdeNova) & " where CodProd = " & strCodProd & " and CodConfig = " & strLoja)

            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) " & _
            "VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Qtd Antiga: " & Me.txtQtde.Text & "'," & _
            "'Qtd Nova: " & Me.txtQtdNova.Text & " Cód. Prod.: " & strCodigoInterno & " Loja.: " & strLoja & "'," & _
            "'QTDE','PRODUTO','ALTERAÇÃO'," & CodConfig & ")")

            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) " & _
            "VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Qtd Antiga: " & Me.txtQtde.Text & " Ajuste: " & dblResul & "'," & _
            "'Qtd Nova: " & Me.txtQtdNova.Text & " Cód. Prod.: " & strCodigoInterno & " Loja.: " & strLoja & "'," & _
            "'QTDE AJUSTE','PRODUTO','ALTERAÇÃO'," & CodConfig & ")")

            MsgBox("Ajuste salvo com sucesso!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Erro ao salvar dados, verifica a conexao com o banco e tente novamente!", MsgBoxStyle.Information)
        End Try
        Limpar()
        Me.Close()

    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub txtQtde_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtde.Enter
        Select Case strUM
            Case 0, 1, 2
                Me.txtQtde.CasasDecimais = 0
            Case 3, 4
                Me.txtQtde.CasasDecimais = 3
            Case 5
                Me.txtQtde.CasasDecimais = 2
        End Select
    End Sub

    Private Sub txtQtdNova_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtdNova.Enter

        Select Case strUM
            Case 0, 1, 2
                Me.txtQtdNova.CasasDecimais = 0
            Case 3, 4
                Me.txtQtdNova.CasasDecimais = 3
            Case 5
                Me.txtQtdNova.CasasDecimais = 2
        End Select
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.txtQtdNova.Focus()
        Me.Timer1.Stop()
    End Sub

   
    Private Sub txtQtdNova_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtdNova.Leave
        If Preco(Me.txtQtdNova) = False Then Exit Sub
    End Sub
End Class