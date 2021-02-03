Imports Nano.clsFuncoes
Public Class frmCorrecaoEstoque
    Dim intPB As Integer

    Public Shared Sub Main()
        Application.Run(New frmMigracao2())
    End Sub
    Private Sub btnIniciar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnIniciar.ItemClick
        Select Case Me.Tag

            Case "AGRUPAR"
                If MsgBox("Esse processo irá agrupar todos os lotes de um produto para um único lote. Você tem certeza?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim dtConfig As DataTable = CarregarDataTable("Select Codigo From Config")
                    Dim dtQtd As DataTable
                    Dim dtProd As DataTable = CarregarDataTable("Select Codigo, ValorCusto From Produto")


                    Dim I, J As Integer
                    Dim intCodProd, intCodConfigTab As Integer
                    Dim dblQtd, dblValCusto As Double
                    intPB = dtProd.Rows.Count
                    pb1.Maximum = intPB
                    pb1.Value = 0

                    For I = 0 To dtProd.Rows.Count - 1
                        intCodProd = dtProd.Rows.Item(I).Item("Codigo").ToString
                        If intCodProd = 95 Then
                            intCodProd = 95
                        End If
                        dblValCusto = dtProd.Rows.Item(I).Item("ValorCusto").ToString
                        For J = 0 To dtConfig.Rows.Count - 1
                            intCodConfigTab = dtConfig.Rows.Item(J).Item("Codigo").ToString

                            dtQtd = CarregarDataTable("Select Sum(Qtd) as Qtd, Max(QtdMinima) as QtdMinima from Qtde where CodProd =" & intCodProd & " and Acabou ='False' and CodConfig =" & intCodConfigTab)

                            If dtQtd.Rows.Count > 0 Then

                                Dim dblQtdMinima As Double = 0
                                If dtQtd.Rows.Item(0).Item("QtdMinima").ToString <> "" Then
                                    dblQtdMinima = dtQtd.Rows.Item(0).Item("QtdMinima").ToString
                                End If
                                Excluir("DELETE FROM Qtde where CodProd = " & intCodProd & " and CodConfig = " & intCodConfigTab)

                                Dim intFalta As Integer = 0

                                If dtQtd.Rows.Item(0).Item("Qtd").ToString <> "" Then
                                    dblQtd = dtQtd.Rows.Item(0).Item("Qtd").ToString
                                    If dblQtdMinima >= dblQtd Then
                                        intFalta = 1
                                    End If
                                    Inserir("Insert Into Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, EmFalta, Acabou, CodConfig, DataFim) Values(" & intCodProd & ",'U'," & Num(dblQtdMinima) & "," & Num(dblQtd) & ",'U','" & intFalta & "','False'," & intCodConfigTab & ",'01/01/1900')")
                                Else
                                    Inserir("Insert Into Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, EmFalta, Acabou, CodConfig, DataFim) Values(" & intCodProd & ",'U','0','0','U','1','False'," & intCodConfigTab & ",'01/01/1900')")
                                End If

                            Else
                                Inserir("Insert Into Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, EmFalta, Acabou, CodConfig, DataFim) Values(" & intCodProd & ",'U','0','0','U','1','False'," & intCodConfigTab & ",'01/01/1900')")
                            End If
                        Next
                        BarraProgresso()
                        Atualizar("Update Qtde set ValorCusto ='" & Num(dblValCusto) & "' where CodProd =" & intCodProd)
                    Next
                End If


                Atualizar("Update Pedido set Lote ='U'")
                Excluir("Delete from Qtde where Lote <> 'U'")

                    MsgBox("OK", MsgBoxStyle.Information)
            Case "ADICIONAR"
                Dim dtConf As DataTable = CarregarDataTable("Select Codigo from Config Order by Codigo")
                Dim Y As Integer
                Dim I As Integer

                Dim dt As DataTable = CarregarDataTable("SELECT Produto.Codigo, Count(Qtde.Codigo) as Qtd FROM Produto left join Qtde " & _
                   "on Produto.Codigo = Qtde.CodProd group by Produto.Codigo having(Count(Qtde.Codigo) < " & dtConf.Rows.Count & ")")

                intPB = dt.Rows.Count
                pb1.Maximum = intPB
                pb1.Value = 0
                For I = 0 To dt.Rows.Count - 1
                    Dim strCodigo As String = dt.Rows.Item(I).Item("Codigo").ToString

                    Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString

                    Select Case strQtd
                        Case "0"
                            For Y = 0 To dtConf.Rows.Count - 1
                                Dim intCodConfigTabQtde As Integer

                                intCodConfigTabQtde = dtConf.Rows.Item(Y).Item("Codigo").ToString

                                Inserir("Insert Into Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, EmFalta, Acabou, CodConfig, DataFim) Values(" & strCodigo & ",'U','0','0','U','1','False'," & intCodConfigTabQtde & ",'01/01/1900')")
                            Next

                        Case Else

                       
                            For Y = 0 To dtConf.Rows.Count - 1
                                Dim intCodConfigTabQtde As Integer

                                intCodConfigTabQtde = dtConf.Rows.Item(Y).Item("Codigo").ToString

                             
                                Dim dtQtd As DataTable = CarregarDataTable("SELECT CodConfig FROM Qtde where CodProd = " & strCodigo & " and CodConfig = " & intCodConfigTabQtde)
                                'Dim strCodConfigQtde As Integer = dtQtd.Rows.Item(0).Item("CodConfig").ToString

                                If dtQtd.Rows.Count = 0 Then
                                    'If strCodConfigQtde.ToString <> intCodConfigTabQtde.ToString Then
                                    Inserir("Insert Into Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, EmFalta, Acabou, CodConfig, DataFim) Values(" & strCodigo & ",'U','0','0','U','1','False'," & intCodConfigTabQtde & ",'01/01/1900')")
                                    'End If
                                End If

                            Next

                    End Select
                    BarraProgresso()
                Next
                MsgBox("OK!", MsgBoxStyle.Information)

            Case "NOVA LOJA"
                If MsgBox("Só fazer isso se o cliente abriu uma nova loja e o estoque 'NÃO ESTÁ POR LOTE'!. Você tem certeza?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    Dim dtProd As DataTable = CarregarDataTable("Select Codigo, ValorCusto From Produto")
                    intPB = dtProd.Rows.Count
                    pb1.Maximum = intPB
                    pb1.Value = 0
                    Dim I As Integer
                    Dim intCodProd As Integer
                    Dim intCodConfig As Integer
                    Dim dblValCus As Double

                    intCodConfig = InputBox("Digite o código da nova loja:").Trim

                    For I = 0 To dtProd.Rows.Count - 1
                        intCodProd = dtProd.Rows.Item(I).Item("Codigo").ToString
                        dblValCus = dtProd.Rows.Item(I).Item("ValorCusto").ToString

                        Inserir("Insert Into Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, EmFalta, Acabou, CodConfig, DataFim) Values(" & intCodProd & ",'U','0','0','U','1','False'," & intCodConfig & ",'01/01/1900')")
                        Atualizar("Update Qtde set ValorCusto ='" & Num(dblValCus) & "' where CodProd =" & intCodProd)

                        BarraProgresso()

                    Next
                End If

                MsgBox("OK", MsgBoxStyle.Information)
            Case "SOMADO"
                If MsgBox("Deseja realmente ajustar a qtde?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then


                    Dim dtProd As DataTable = CarregarDataTable("SELECT Produto.Codigo FROM Produto order by Codigo")
                    intPB = dtProd.Rows.Count
                    pb1.Maximum = intPB
                    pb1.Value = 0
                    Dim I As Integer
                    Dim A As Integer
                    For I = 0 To dtProd.Rows.Count - 1

                        Dim strCod As String = dtProd.Rows.Item(I).Item("Codigo").ToString
                   
                        For A = 0 To QtdeLoja - 1
                            Dim strLoja As String = A + 1

                            Dim dblQtdEnt As Double = 0
                            Dim dblQtdSai As Double = 0
                            Dim dblQtd As Double = 0
                            Dim dtEnt As DataTable = CarregarDataTable("SELECT case when Sum(QtdProd) is null then 0 else sum(QtdProd) end as Entrada " & _
                            "FROM (Produto left join EntradaNf on Produto.Codigo = EntradaNf.CodProd) left join TotalEntradaNf on " & _
                            "EntradaNf.CodTotNf = TotalEntradaNf.Codigo where Produto.Codigo = " & strCod & " and " & _
                            "EstoqueOk = 'True' and EntradaNf.Codconfig = " & strLoja)

                            dblQtdEnt = dtEnt.Rows.Item(0).Item("Entrada").ToString

                            Dim dtPed As DataTable = CarregarDataTable("SELECT case when Sum(Qtd) is null then 0 else sum(Qtd) end as Saida " & _
                            "FROM Produto left join Pedido on Produto.Codigo = Pedido.CodProd where Produto.Codigo = " & strCod & " and " & _
                            "Pedido.Codconfig = " & strLoja & " and Pedido.Devolvido = 'False'")

                            dblQtdSai = dtPed.Rows.Item(0).Item("Saida").ToString

                            Dim dtQtd As DataTable = CarregarDataTable("SELECT case when Qtd is null then 0 else Qtd end as Qtd " & _
                            "FROM Qtde where CodProd = " & strCod & " and CodConfig = " & strLoja)

                            If dtQtd.Rows.Count > 0 Then
                                dblQtd = dtQtd.Rows.Item(0).Item("Qtd").ToString
                            Else
                                dblQtd = 0
                            End If


                            Dim dblResul As Double = dblQtdEnt - dblQtdSai

                            If dblQtd > dblResul Then

                                dblResul = dblQtd - dblResul


                            ElseIf dblQtd < dblResul Then
                                dblResul = dblQtd - dblResul
                            Else
                                dblResul = 0
                            End If


                            Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, Data, Tabela, Codconfig, CodUser) VALUES (" & strCod & "," & Num(dblResul) & ",'" & My.Computer.Clock.LocalTime & "','QTDE'," & strLoja & "," & CodUser & ")")

                            dblResul = (dblQtdEnt - dblQtdSai) + dblResul
                            Atualizar("Update Qtde set EmFalta = '0' where CodProd = " & strCod & " and CodConfig = " & strLoja)
                            If dblResul = 0 Then
                                Atualizar("Update Qtde set EmFalta = '1' where CodProd = " & strCod & " and CodConfig = " & strLoja)

                            Else
                                Dim dtQtde As DataTable = CarregarDataTable("SELECT QtdMinima FROM Qtde where CodProd = " & strCod & " and CodConfig = " & strLoja)
                                If dtQtde.Rows.Count > 0 Then
                                    Dim dblQtdMin As Double = dtQtde.Rows.Item(0).Item("QtdMinima").ToString
                                    If dblQtdMin >= dblResul Then
                                        Atualizar("Update Qtde set EmFalta = '1' where CodProd = " & strCod & " and CodConfig = " & strLoja)
                                    End If
                                End If

                            End If
                        Next
                        BarraProgresso()
                    Next
                    MsgBox("OK", MsgBoxStyle.Information)
                End If

            Case "ZEROS"


                If MsgBox("Esse processo irá inserir zeros nos codigos internos com quantidade de caracteres impares?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    Dim dtProd As DataTable = CarregarDataTable("Select CodigoInterno, Codigo From Produto")


                    Dim I As Integer
                    intPB = dtProd.Rows.Count
                    pb1.Maximum = intPB
                    pb1.Value = 0

                    For I = 0 To dtProd.Rows.Count - 1
                        Dim intCodProd As Integer = dtProd.Rows.Item(I).Item("Codigo").ToString

                        Dim strCodigoInterno As String = dtProd.Rows.Item(I).Item("CodigoInterno").ToString


                        Select Case strCodigoInterno.Length
                            Case 1
                                strCodigoInterno = "000" & strCodigoInterno
                            Case 2
                                strCodigoInterno = "00" & strCodigoInterno
                            Case 3
                                strCodigoInterno = "0" & strCodigoInterno
                            Case 4
                            Case Else
                                If Not strCodigoInterno.Length Mod 2 = 0 Then
                                    strCodigoInterno = "0" & strCodigoInterno
                                End If
                        End Select
                        BarraProgresso()
                        Atualizar("Update Produto set CodigoInterno ='" & strCodigoInterno & "' where Codigo =" & intCodProd)
                    Next
                End If

            Case "EMFALTA"
               

                If MsgBox("Esse processo irá ajustar os produtos que estao ou não em falta?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    If EstoqueSomado = True Then
                        Dim dtProd As DataTable = CarregarDataTable("Select Codigo From Produto")

                        Dim I As Integer
                        intPB = dtProd.Rows.Count
                        pb1.Maximum = intPB
                        pb1.Value = 0

                        For I = 0 To dtProd.Rows.Count - 1
                            Dim intCodProd As Integer = dtProd.Rows.Item(I).Item("Codigo").ToString
                            BarraProgresso()
                            Atualizar(clsDarBaixa.AjustarEmFalta(intCodProd, 0, True))
                        Next
                    End If
                End If
        End Select

        Me.Close()
    End Sub
    Private Sub BarraProgresso()
        If pb1.Value < intPB Then
            pb1.Value = pb1.Value + 1
        End If
        Application.DoEvents()
        System.Threading.Thread.Sleep(40)
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub
End Class