Imports Nano.clsFuncoes
Public Class frmInativarProduto
    Dim intPB As Integer
    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub
    Private Sub BarraProgresso()
        If pb1.Value < intPB Then
            pb1.Value = pb1.Value + 1
        End If
        Application.DoEvents()
        System.Threading.Thread.Sleep(40)
    End Sub
    Private Sub btnIniciar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnIniciar.ItemClick

        If MsgBox("Deseja realmente inativar Produto não utilizado a " & Me.seMeses.EditValue & " meses?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Dim dtProd As DataTable = CarregarDataTable("SELECT Codigo, Data, CodigoInterno FROM Produto where Inativo = 'False'")
        Dim A As Integer
        Dim I As Integer
        intPB = dtProd.Rows.Count
        pb1.Maximum = intPB
        pb1.Value = 0
        Dim intMes As Integer = Me.seMeses.EditValue
        Dim strCodInterno As String = ""
        For A = 0 To dtProd.Rows.Count - 1
            Dim strCodProd As String = dtProd.Rows.Item(A).Item("Codigo").ToString
            Dim strCodigoInterno As String = dtProd.Rows.Item(A).Item("CodigoInterno").ToString
            Dim dtData As Date = dtProd.Rows.Item(A).Item("Data").ToString
            Dim dtTotal As DataTable = Nothing
            Dim bolInativar As Boolean = False
            If Me.chkVendeu.Checked = True Then
                dtTotal = CarregarDataTable("SELECT Max(Data) as Data FROM Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and " & _
                "Total.CodConfig = PEdido.CodConfig where Pedido.CodProd = " & strCodProd)
                If dtTotal.Rows.Count > 0 Then
                    If dtTotal.Rows.Item(0).Item("Data").ToString <> "" Then
                        Dim dtDataTotal As Date = dtTotal.Rows.Item(0).Item("Data").ToString
                        If dtDataTotal < Date.Today.AddMonths(-intMes) Then
                            bolInativar = True
                        End If
                    Else
                        If Me.chkSemEstoque.Checked = True Then
                            If dtData < Date.Today.AddMonths(-intMes) Then
                                bolInativar = True
                            End If
                        Else
                            If Me.chkEntrou.Checked = False Then
                                bolInativar = True
                            End If
                        End If
                     
                    End If

                Else
                    If Me.chkSemEstoque.Checked = True Then
                        If dtData < Date.Today.AddMonths(-intMes) Then
                            bolInativar = True
                        End If
                    Else
                        If Me.chkEntrou.Checked = False Then
                            bolInativar = True
                        End If
                    End If
                End If
            End If
            Dim bolEntrada As Boolean = True

            If Me.chkEntrou.Checked = True Then
                If Me.chkVendeu.Checked = True Then
                    If bolInativar = True Then
                        bolInativar = False
                    Else
                        bolEntrada = False
                    End If

                Else
                    bolInativar = False
                End If
                If bolEntrada = True Then
                    dtTotal = CarregarDataTable("SELECT Max(Data) as Data FROM TotalEntradaNF left join EntradaNF on TotalEntradaNF.Codigo = EntradaNF.CodTotNF and " & _
                    "TotalEntradaNF.CodConfig = EntradaNF.CodConfig where EntradaNF.CodProd = " & strCodProd)
                    If dtTotal.Rows.Count > 0 Then
                        If dtTotal.Rows.Item(0).Item("Data").ToString <> "" Then
                            Dim dtDataTotal As Date = dtTotal.Rows.Item(0).Item("Data").ToString
                            If dtDataTotal < Date.Today.AddMonths(-intMes) Then
                                bolInativar = True
                            End If
                        Else
                            If Me.chkSemEstoque.Checked = True Then
                                If dtData < Date.Today.AddMonths(-intMes) Then
                                    bolInativar = True
                                End If
                            Else
                                bolInativar = True
                            End If
                        End If
                    End If
                End If
            End If
            BarraProgresso()

            If bolInativar = True Then



                Atualizar("UPDATE Produto set Inativo = 'True', Locacao2 = 'INATIVO2' where Codigo = " & strCodProd)

                If I > 50 Then
                    I = 0
                    Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                              "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Produto Ativo'," & _
                              "'Cód. Prod.: " & strCodInterno & " - INATIVO','INATIVO','PRODUTO','ALTERAÇÃO'," & CodConfig & ")")


                    strCodInterno = ""
                Else
                    strCodInterno &= strCodigoInterno & ","
                End If
                I += 1
          
            End If
        Next
        If strCodInterno <> "" Then
            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                                         "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Produto Ativo'," & _
                                         "'Cód. Prod.: " & strCodInterno & " - INATIVO','INATIVO','PRODUTO','ALTERAÇÃO'," & CodConfig & ")")
        End If

        MsgBox("OK", MsgBoxStyle.Information)
    End Sub

    Private Sub frmInativarProduto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnCarregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregar.Click
        Dim dtProd As DataTable = CarregarDataTable("SELECT Codigo, Data, CodigoInterno FROM Produto where Inativo = 'False'")
        Dim A As Integer
        Dim I As Integer
        intPB = dtProd.Rows.Count
        pb1.Maximum = intPB
        pb1.Value = 0
        Dim intMes As Integer = Me.seMeses.EditValue
        Dim strCodInterno As String = ""
        For A = 0 To dtProd.Rows.Count - 1
            Dim strCodProd As String = dtProd.Rows.Item(A).Item("Codigo").ToString
            Dim strCodigoInterno As String = dtProd.Rows.Item(A).Item("CodigoInterno").ToString
            Dim dtData As Date = dtProd.Rows.Item(A).Item("Data").ToString
            Dim dtTotal As DataTable = Nothing
            Dim bolInativar As Boolean = False
            If Me.chkVendeu.Checked = True Then
                dtTotal = CarregarDataTable("SELECT Max(Data) as Data FROM Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and " & _
                "Total.CodConfig = PEdido.CodConfig where Pedido.CodProd = " & strCodProd)
                If dtTotal.Rows.Count > 0 Then
                    If dtTotal.Rows.Item(0).Item("Data").ToString <> "" Then
                        Dim dtDataTotal As Date = dtTotal.Rows.Item(0).Item("Data").ToString
                        If dtDataTotal < Date.Today.AddMonths(-intMes) Then
                            bolInativar = True
                        End If
                    Else
                        If dtData < Date.Today.AddMonths(-intMes) Then
                            bolInativar = True
                        End If
                    End If


                Else
                    If dtData < Date.Today.AddMonths(-intMes) Then
                        bolInativar = True
                    End If
                End If
            End If
            Dim bolEntrada As Boolean = True
            If Me.chkEntrou.Checked = True Then
                If Me.chkVendeu.Checked = True Then
                    If bolInativar = True Then
                        bolInativar = False
                    Else
                        bolEntrada = False
                    End If

                Else
                    bolInativar = False
                End If
                If bolEntrada = True Then
                    dtTotal = CarregarDataTable("SELECT Max(Data) as Data FROM TotalEntradaNF left join EntradaNF on TotalEntradaNF.Codigo = EntradaNF.CodTotNF and " & _
                    "TotalEntradaNF.CodConfig = EntradaNF.CodConfig where EntradaNF.CodProd = " & strCodProd)
                    If dtTotal.Rows.Count > 0 Then
                        If dtTotal.Rows.Item(0).Item("Data").ToString <> "" Then
                            Dim dtDataTotal As Date = dtTotal.Rows.Item(0).Item("Data").ToString
                            If dtDataTotal < Date.Today.AddMonths(-intMes) Then
                                bolInativar = True
                            End If
                        Else
                            If dtData < Date.Today.AddMonths(-intMes) Then
                                bolInativar = True
                            End If
                        End If
                    End If
                End If
            End If

            Dim bolEstoque As Boolean = True
            If Me.chkSemEstoque.Checked = True Then
                If Me.chkEntrou.Checked = True Then
                    If bolInativar = True Then
                        bolInativar = False
                    Else
                        bolEstoque = False
                    End If

                Else
                    bolInativar = False
                End If
                If bolEstoque = True Then
                    dtTotal = CarregarDataTable("SELECT Produto.Codigo, (SELECT case when sum(EntradaNf.QtdProd) is null then 0 else sum(EntradaNf.QtdProd) end " & _
                       "FROM EntradaNf left join TotalEntradaNf on EntradaNf.CodTotNf = TotalEntradaNf.Codigo where " & _
                       "EntradaNf.CodProd = Produto. Codigo and EstoqueOk = 'True') - (SELECT case when sum(Pedido.Qtd) " & _
                       "is null then 0 else sum(Pedido.Qtd) end FROM Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and PEdido.CodConfig = Total.CodConfig where Pedido.CodProd = Produto.Codigo " & _
                       "and Pedido.Devolvido = 'False') + (SELECT case when sum(AjusteQtde.Qtd) is null then 0 else " & _
                       "sum(AjusteQtde.Qtd) end FROM AjusteQtde where AjusteQtde.CodProd = Produto.Codigo) as Qtd FROM Produto where Produto.codigo = " & strCodProd)
                    If dtTotal.Rows.Count > 0 Then
                        If dtTotal.Rows.Item(0).Item("Qtd").ToString <> "" Then
                            Dim dblEstoque As Boolean = dtTotal.Rows.Item(0).Item("Qtd").ToString
                            If dblEstoque <= 0 Then
                                bolInativar = True
                            End If
                        Else
                            bolInativar = True
                        End If
                    Else
                        bolInativar = True
                    End If
                End If
            End If
            BarraProgresso()
            If bolInativar = True Then



                Atualizar("UPDATE Produto set Inativo = 'True', Locacao2 = 'INATIVO' where Codigo = " & strCodProd)

                If I > 50 Then
                    I = 0
                    Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                              "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Produto Ativo'," & _
                              "'Cód. Prod.: " & strCodInterno & " - INATIVO','INATIVO','PRODUTO','ALTERAÇÃO'," & CodConfig & ")")


                    strCodInterno = ""
                Else
                    strCodInterno &= strCodigoInterno & ","
                End If
                I += 1

            End If
        Next
        If strCodInterno <> "" Then
            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                                         "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Produto Ativo'," & _
                                         "'Cód. Prod.: " & strCodInterno & " - INATIVO','INATIVO','PRODUTO','ALTERAÇÃO'," & CodConfig & ")")
        End If

        MsgBox("OK", MsgBoxStyle.Information)
    End Sub
End Class