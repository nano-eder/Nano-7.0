Imports Nano.clsFuncoes
Imports System
Imports System.Drawing
Imports System.Data
Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Public Class frmAlterarValores
    Dim strFiltro As String = ""
    Dim intMax As Integer
    Dim intPB As Integer
    Dim bolSalvar As Boolean = False
    Public Shared Sub Main()
        Application.Run(New frmAlterarValores())

    End Sub

    Private Sub frmAlterarValores_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If bolSalvar = False Then
            MsgBox("Alteração de valores não foi realizada!", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub frmAlterarValores_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "79")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmAlterarValores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bolSalvar = False
    End Sub

    Private Sub btnOk_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOk.ItemClick
        If TesteConexao() = False Then Exit Sub

        If MsgBox("Deseja realmente alterar os valores dos produtos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Select Case Me.rdgAlt.SelectedIndex
            Case 0
                If Validar(Me.txtPor) = False Then Exit Sub
            Case 1
                If Validar(Me.txtValor) = False Then Exit Sub
        End Select
        If Validar(Me.cboCampo) = False Then Exit Sub
        If Validar(Me.cboAlterar) = False Then Exit Sub
        If Validar(Me.cboAumentar) = False Then Exit Sub
        Select Case Me.cboAlterar.SelectedIndex
            Case 1
                If Validar(Me.cboGrupo) = False Then Exit Sub
                strFiltro = " where Grupo = '" & Me.cboGrupo.Text & "'"
            Case 2
                If Validar(Me.cboGrupo) = False Then Exit Sub
                strFiltro = " where Setor = '" & Me.cboGrupo.Text & "'"
            Case 3
                If Validar(Me.cboGrupo) = False Then Exit Sub
                strFiltro = " where Fabricante = '" & Me.cboGrupo.Text & "'"

        End Select
        Try

            Select Case Me.rdgAlt.SelectedIndex
                Case 0
                    Alterar("PORCENTAGEM")
                Case 1
                    Alterar("VALOR")
            End Select

            bolSalvar = True
            MsgBox("Valores alterados com sucesso!", MsgBoxStyle.Information)
        Catch ex As Exception

        End Try

        Me.Close()
    

    End Sub
    Private Sub Alterar(ByVal parPorVal As String)
        Dim dtProd As DataTable = CarregarDataTable("SELECT Codigo, ValorCusto, Valor FROM Produto" & strFiltro)
        Dim I As Integer

        pb1.Value = 0
        intPB = dtProd.Rows.Count
        pb1.Maximum = intPB

        Dim dblVal As Double
        If Me.txtValor.Text.Trim <> "" Then
            dblVal = Me.txtValor.Text.Trim
        End If

        Dim dblPor As Double
        If Me.txtPor.Text.Trim <> "" Then
            dblPor = Me.txtPor.Text.Trim
        End If

        Dim dblValorAntigo As Double = 0
        Dim intCodProd As Integer = 0

        For I = 0 To dtProd.Rows.Count - 1
            Dim dblValorCusto As Double = 0
            Dim dblValor As Double = 0


            intCodProd = dtProd.Rows.Item(I).Item("Codigo").ToString

            Dim strPor1 As String = "0"

            Select Case Me.cboCampo.Text
                Case "VALOR VENDA"
                    If parPorVal = "PORCENTAGEM" Then
                        If dtProd.Rows.Item(I).Item("Valor").ToString <> "" Then
                            dblValor = dtProd.Rows.Item(I).Item("Valor")
                            dblValorAntigo = dblValor

                            Dim dblResul As Double

                            dblResul = (dblValor / 100) * dblPor

                            If Me.cboAumentar.Text = "AUMENTAR" Then
                                dblValor = dblValor + dblResul
                            Else
                                dblValor = dblValor - dblResul
                            End If
                        End If
                    Else
                        If dtProd.Rows.Item(I).Item("Valor").ToString <> "" Then
                            dblValor = dtProd.Rows.Item(I).Item("Valor")
                            dblValorAntigo = dblValor

                            If Me.cboAumentar.Text = "AUMENTAR" Then
                                dblValor = dblValor + dblVal
                            Else
                                dblValor = dblValor - dblVal
                            End If
                        End If
                    End If


                    If dtProd.Rows.Item(I).Item("ValorCusto").ToString <> "" Then
                        dblValorCusto = dtProd.Rows.Item(I).Item("ValorCusto")
                        Dim dblMargem As Double
                        strPor1 = ((dblValor - dblValorCusto) * 100) / dblValorCusto
                        If strPor1 <> "NaN (Não é um número)" Then
                            dblMargem = strPor1
                        Else
                            dblMargem = 0
                        End If

                        If strPor1 <> "+Infinito" Then
                            strPor1 = dblMargem.ToString("0.0")
                        Else
                            strPor1 = "0"
                        End If
                    End If

                    Dim strPorcentagens As String = strPor1

                    Atualizar("UPDATE Produto SET Valor = " & Num(dblValor) & ", Porcentagens = '" & strPorcentagens & "' where Codigo = " & intCodProd)
                Case "VALOR CUSTO"
                    If parPorVal = "PORCENTAGEM" Then
                        If dtProd.Rows.Item(I).Item("ValorCusto").ToString <> "" Then
                            dblValor = dtProd.Rows.Item(I).Item("ValorCusto")
                            dblValorAntigo = dblValor

                            Dim dblResul As Double

                            dblResul = (dblValor / 100) * dblPor

                            If Me.cboAumentar.Text = "AUMENTAR" Then
                                dblValor = dblValor + dblResul
                            Else
                                dblValor = dblValor - dblResul
                            End If
                        End If
                    Else
                        If dtProd.Rows.Item(I).Item("ValorCusto").ToString <> "" Then
                            dblValor = dtProd.Rows.Item(I).Item("ValorCusto")
                            dblValorAntigo = dblValor

                            If Me.cboAumentar.Text = "AUMENTAR" Then
                                dblValor = dblValor + dblVal
                            Else
                                dblValor = dblValor - dblVal
                            End If
                        End If
                    End If


                    If dtProd.Rows.Item(I).Item("Valor").ToString <> "" Then
                        dblValorCusto = dtProd.Rows.Item(I).Item("Valor")
                        Dim dblMargem As Double
                        strPor1 = ((dblValorCusto - dblValor) * 100) / dblValor
                        If strPor1 <> "NaN (Não é um número)" Then
                            dblMargem = strPor1
                        Else
                            dblMargem = 0
                        End If

                        If strPor1 <> "+Infinito" Then
                            strPor1 = dblMargem.ToString("0.0")
                        Else
                            strPor1 = "0"
                        End If
                    End If

                    Dim strPorcentagens As String = strPor1

                    Atualizar("UPDATE Produto SET ValorCusto = " & Num(dblValor) & ", Porcentagens = '" & strPorcentagens & "' where Codigo = " & intCodProd)
            End Select
            

            BarraProgresso2()
        Next
        If parPorVal = "PORCENTAGEM" Then
            dblVal = dblPor
        End If
        If dtProd.Rows.Count > 0 Then
            If Me.cboAumentar.Text = "AUMENTAR" Then
                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo) VALUES (" & _
                "'" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'','AUMENTAR POR " & Me.cboAlterar.Text & ": " & Me.cboGrupo.Text & " - " & dblVal.ToString("0.00") & " POR " & parPorVal.ToUpper & "' ,'" & Me.cboCampo.Text & "','PRODUTO','ALTERAÇÃO')")

            Else

                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo) VALUES (" & _
                            "'" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'','DIMINUIR POR " & Me.cboAlterar.Text & ": " & Me.cboGrupo.Text & " - " & dblVal.ToString("0.00") & " POR " & parPorVal.ToUpper & "' ,'" & Me.cboCampo.Text & "','PRODUTO','ALTERAÇÃO')")

            End If
        End If

    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub cboAlterar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlterar.SelectedIndexChanged
        Me.cboGrupo.Properties.Items.Clear()
        Me.cboGrupo.ResetText()

        Select Case Me.cboAlterar.SelectedIndex
            Case 0
                Me.cboGrupo.Enabled = False
            Case 1
                Me.cboGrupo.Visible = True
                Me.cboGrupo.Enabled = True
                Me.lblGruSet.Text = "Grupo"
                PreencherGrupoSetorCusto("G", Me.cboGrupo)
            Case 2
                Me.cboGrupo.Visible = True
                Me.cboGrupo.Enabled = True
                Me.lblGruSet.Text = "Setor"
                PreencherGrupoSetorCusto("S", Me.cboGrupo)

            Case 3
                Me.cboGrupo.Visible = True
                Me.cboGrupo.Enabled = True
                Me.lblGruSet.Text = "Forn."
                PreencherOrdenado("Fornecedor", Me.cboGrupo, 1, "Nome")
        End Select
    End Sub

    Private Sub txtValor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "," And e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtValor_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        If Preco(Me.txtValor) = False Then Exit Sub
    End Sub
    Private Sub BarraProgresso2()
        If pb1.Value < intPB Then
            pb1.Value = pb1.Value + 1
        End If
        Application.DoEvents()
        System.Threading.Thread.Sleep(40)
    End Sub

    Private Sub rdgAlt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgAlt.SelectedIndexChanged
        Select Case rdgAlt.SelectedIndex

            Case 0
                Me.txtValor.ResetText()
                Me.txtValor.Enabled = False
                Me.txtPor.ResetText()
                Me.txtPor.Enabled = True
            Case 1
                Me.txtPor.ResetText()
                Me.txtPor.Enabled = False
                Me.txtValor.ResetText()
                Me.txtValor.Enabled = True
        End Select

    End Sub

    Private Sub btnCarregar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCarregar.ItemClick
        Select Case Me.rdgAlt.SelectedIndex
            Case 0
                If Validar(Me.txtPor) = False Then Exit Sub
            Case 1
                If Validar(Me.txtValor) = False Then Exit Sub
        End Select
        If Validar(Me.cboCampo) = False Then Exit Sub
        If Validar(Me.cboAlterar) = False Then Exit Sub
        If Validar(Me.cboAumentar) = False Then Exit Sub
        Dim strPor As String = ""
        Select Case Me.cboAlterar.SelectedIndex
            Case 1
                If Validar(Me.cboGrupo) = False Then Exit Sub
                strPor = " where Grupo = '" & Me.cboGrupo.Text & "'"
            Case 2
                If Validar(Me.cboGrupo) = False Then Exit Sub
                strPor = " where Setor = '" & Me.cboGrupo.Text & "'"
            Case 3
                If Validar(Me.cboGrupo) = False Then Exit Sub
                strPor = " where Fabricante = '" & Me.cboGrupo.Text & "'"
        End Select
        Try

            Select Case Me.rdgAlt.SelectedIndex
                Case 0
                    Carregar("PORCENTAGEM", strPor)
                Case 1
                    Carregar("VALOR", strPor)
            End Select
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Carregar(ByVal parTipo As String, ByVal parPor As String)
        Dim dtProd As DataTable = CarregarDataTable("SELECT CodigoInterno, Nome, ValorCusto, Valor FROM Produto" & parPor)
        Me.tbProd.Rows.Clear()
        Dim I As Integer

        Dim dblVal As Double
        If Me.txtValor.Text.Trim <> "" Then
            dblVal = Me.txtValor.Text.Trim
        End If

        Dim dblPor As Double
        If Me.txtPor.Text.Trim <> "" Then
            dblPor = Me.txtPor.Text.Trim
        End If

        Dim dblValorAntigo As Double = 0
        Dim strCodigo As String

        For I = 0 To dtProd.Rows.Count - 1
            Dim dblValorCusto As Double = 0
            Dim dblValor As Double = dtProd.Rows.Item(I).Item("Valor")
            Dim dblValorAlterado As Double = 0
            strCodigo = dtProd.Rows.Item(I).Item("CodigoInterno").ToString
            Dim strProduto As String = dtProd.Rows.Item(I).Item("Nome").ToString
            Dim strPor1 As String = "0"
            Select Case Me.cboCampo.Text
                Case "VALOR VENDA"
                    If parTipo = "PORCENTAGEM" Then
                        If dtProd.Rows.Item(I).Item("Valor").ToString <> "" Then
                            dblValor = dtProd.Rows.Item(I).Item("Valor")
                            dblValorAntigo = dblValor

                            Dim dblResul As Double

                            dblResul = (dblValor / 100) * dblPor

                            If Me.cboAumentar.Text = "AUMENTAR" Then
                                dblValorAlterado = dblValor + dblResul
                            Else
                                dblValorAlterado = dblValor - dblResul
                            End If
                        End If
                    Else
                        If dtProd.Rows.Item(I).Item("Valor").ToString <> "" Then
                            dblValor = dtProd.Rows.Item(I).Item("Valor")
                            dblValorAntigo = dblValor

                            If Me.cboAumentar.Text = "AUMENTAR" Then
                                dblValorAlterado = dblValor + dblVal
                            Else
                                dblValorAlterado = dblValor - dblVal
                            End If
                        End If
                    End If


                    If dtProd.Rows.Item(I).Item("ValorCusto").ToString <> "" Then
                        dblValorCusto = dtProd.Rows.Item(I).Item("ValorCusto")
                        Dim dblMargem As Double
                        strPor1 = ((dblValorAlterado - dblValorCusto) * 100) / dblValorCusto
                        If strPor1 <> "NaN (Não é um número)" Then
                            dblMargem = strPor1
                        Else
                            dblMargem = 0
                        End If

                        If strPor1 <> "+Infinito" Then
                            strPor1 = dblMargem.ToString("0.0")
                        Else
                            strPor1 = "0"
                        End If
                    End If
                Case "VALOR CUSTO"
                    If parTipo = "PORCENTAGEM" Then
                        If dtProd.Rows.Item(I).Item("ValorCusto").ToString <> "" Then
                            dblValor = dtProd.Rows.Item(I).Item("ValorCusto")
                            dblValorAntigo = dblValor

                            Dim dblResul As Double

                            dblResul = (dblValor / 100) * dblPor

                            If Me.cboAumentar.Text = "AUMENTAR" Then
                                dblValorAlterado = dblValor + dblResul
                            Else
                                dblValorAlterado = dblValor - dblResul
                            End If
                        End If
                    Else
                        If dtProd.Rows.Item(I).Item("ValorCusto").ToString <> "" Then
                            dblValor = dtProd.Rows.Item(I).Item("ValorCusto")
                            dblValorAntigo = dblValor

                            If Me.cboAumentar.Text = "AUMENTAR" Then
                                dblValorAlterado = dblValor + dblVal
                            Else
                                dblValorAlterado = dblValor - dblVal
                            End If
                        End If
                    End If


                    If dtProd.Rows.Item(I).Item("Valor").ToString <> "" Then
                        dblValorCusto = dtProd.Rows.Item(I).Item("Valor")
                        Dim dblMargem As Double
                        strPor1 = ((dblValorCusto - dblValor) * 100) / dblValor
                        If strPor1 <> "NaN (Não é um número)" Then
                            dblMargem = strPor1
                        Else
                            dblMargem = 0
                        End If

                        If strPor1 <> "+Infinito" Then
                            strPor1 = dblMargem.ToString("0.0")
                        Else
                            strPor1 = "0"
                        End If
                    End If
            End Select

            

            Dim strPorcentagens As String = strPor1


            Me.tbProd.Rows.Add()
            Me.tbProd.Rows.Item(I).Item("Codigo") = strCodigo
            Me.tbProd.Rows.Item(I).Item("Produto") = strProduto
            Me.tbProd.Rows.Item(I).Item("Valor") = dblValor.ToString("0.00")
            Me.tbProd.Rows.Item(I).Item("ValorAlterado") = dblValorAlterado.ToString("0.00")
        Next

        If Me.cboCampo.Text = "VALOR CUSTO" Then
            Me.colValor.Caption = "Valor Custo R$"
        End If
    End Sub
End Class