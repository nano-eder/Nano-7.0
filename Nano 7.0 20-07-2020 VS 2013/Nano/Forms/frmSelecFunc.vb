Imports Nano.clsFuncoes
Public Class frmSelecFunc
    Dim intCont As Integer = 0

    Private Sub frmSelecFunc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmSelecFunc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Tag = "VENDEDOR" Then
            If TipoNano = 2 Then
                CarregarDadosLue("Select Codigo, Nome from Funcionario where CodConfig =" & CodConfig & " and Ativo ='True' and Funcao <> 'MECÂNICO' order by Nome", Me.lueFunc)

            Else
                CarregarDadosLue("Select Codigo, Nome from Funcionario where CodConfig =" & CodConfig & " and Ativo ='True' order by Nome", Me.lueFunc)
            End If
        Else
            CarregarDadosLue("Select Codigo, Nome from Funcionario where CodConfig =" & CodConfig & " and Ativo ='True' and Funcao = 'MECÂNICO' order by Nome", Me.lueFunc)
        End If

        If TipoNano = 5 Then
            Me.Text = "Seleção de Mecânico(a)"
            LabelControl1.Text = "Mecânico(a)"
            LabelControl2.Text = "Selecione o mecânico(a) e pressione 'ENTER'."
        End If

    End Sub

    Private Sub lueFunc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lueFunc.KeyDown
        If Me.lueFunc.Text.Trim = "" Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            CodigoFuncionario = Me.lueFunc.EditValue
            NomeFuncionario = Me.lueFunc.Text
            Me.Close()
        End If
    End Sub
End Class