Imports System
Imports System.Data
Imports System.Data.OleDb
Imports Nano.clsFuncoes
Public Class clsDarBaixa

    Public Shared Function BaixarProduto(ByVal parCodProdAut As Integer, ByVal parQtd As Double, ByVal parTamanho As String, ByVal parUM As String, ByVal parReceita As Boolean, ByVal parVenda As Boolean) As String

        Dim dt As DataTable = CarregarDataTable("Select Codigo, Qtd, ValorCusto, Lote, QtdMinima from Qtde where CodProd = " & parCodProdAut & " and Tamanho ='" & parTamanho & "' and Acabou = 'False' and CodConfig =" & CodConfig & " order by Codigo")

        Dim dblQtdPCusto, dblQtdMin As Double

        dblQtdPCusto = parQtd

        Dim I, intCodQtd As Integer
        Dim dblQtdTab, dblSoma, dblCusto As Double
        Dim strLote As String = ""

        For I = 0 To dt.Rows.Count - 1

            dblCusto = 0
            intCodQtd = dt.Rows.Item(I).Item("Codigo").ToString

            dblQtdTab = dt.Rows.Item(I).Item("Qtd").ToString
            dblQtdMin = dt.Rows.Item(I).Item("QtdMinima").ToString

            If dt.Rows.Item(I).Item("ValorCusto").ToString <> "" Then
                dblCusto = dt.Rows.Item(I).Item("ValorCusto").ToString
            End If

            If EstoqueSomado = False Then
                If dblCusto > 0 Then
                    If parVenda = True Then
                        frmVenda.strCmdsSQL &= "Update Produto set ValorCusto =" & Num(dblCusto) & " where Codigo =" & parCodProdAut & vbCrLf & vbCrLf
                    Else
                        Atualizar("Update Produto set ValorCusto =" & Num(dblCusto) & " where Codigo =" & parCodProdAut)
                    End If

                End If
            End If
      

            If dblQtdTab >= parQtd Then
                'If parReceita = True Then
                '    If EstoqueSomado = True Then
                '        Dim dblResul As Double = AjusteQtde(CodConfig, parCodProdAut)
                '        dblQtdTab = dblResul
                '    End If
                'End If

                dblSoma = dblQtdTab - parQtd

                Dim strQtd As String = ""

                Select Case parUM
                    Case "UN", "JG", "KIT"
                        strQtd = dblSoma.ToString("0")

                    Case "MT"
                        strQtd = dblSoma.ToString("0.000")

                    Case "LT", "KG"
                        strQtd = dblSoma.ToString("0.000")

                    Case Else
                        strQtd = dblSoma.ToString("0.000")

                End Select

                If dblSoma = 0 Then
                    Dim dtQtd As DataTable = CarregarDataTable("SELECT count(Codigo) as Qtd FROM Qtde where CodProd = " & parCodProdAut & " and Acabou = 'False' and CodConfig =" & CodConfig)
                    Dim intQ As Integer
                    Dim strDataFim As String = ""
                    If dtQtd.Rows.Count > 0 Then
                        intQ = dtQtd.Rows.Item(0).Item("Qtd")
                        If intQ = 1 Then
                            strDataFim = ",DataFim = '" & My.Computer.Clock.LocalTime & "'"
                        End If
                    End If

                    If BaixaPorLote = True Then
                        If parVenda = True Then
                            frmVenda.strCmdsSQL &= "Update Qtde Set Acabou = 'True', Qtd =0, EmFalta = '1' " & strDataFim & " where Codigo = " & intCodQtd & vbCrLf & vbCrLf
                        Else
                            Atualizar("Update Qtde Set Acabou = 'True', Qtd =0, EmFalta = '1' " & strDataFim & " where Codigo = " & intCodQtd)
                        End If
                    Else
                        If parVenda = True Then


                            frmVenda.strCmdsSQL &= "Update Qtde Set Qtd =0, EmFalta = '1' where Codigo = " & intCodQtd & vbCrLf & vbCrLf



                        Else
                            Atualizar("Update Qtde set Qtd =0, EmFalta = '1' where Codigo = " & intCodQtd)
                        End If

                    End If

                Else

                    If dblQtdMin >= CDbl(strQtd) Then
                        If parVenda = True Then
                            frmVenda.strCmdsSQL &= "Update Qtde set EmFalta ='1' where Codigo =" & intCodQtd & vbCrLf & vbCrLf
                        Else
                            Atualizar("Update Qtde set EmFalta ='1' where Codigo =" & intCodQtd)
                        End If

                    End If

                    If parVenda = True Then
                        frmVenda.strCmdsSQL &= "Update Qtde set Qtd =" & Num(strQtd) & " where Codigo =" & intCodQtd & vbCrLf & vbCrLf
                        'If parReceita = True Then
                        '    If EstoqueSomado = True Then
                        '        Dim dblQtdEst As Double = -parQtd

                        '        frmVenda.strCmdsSQL &= "INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data, CodUser) VALUES (" & _
                        '                      "" & parCodProdAut & "," & Num(dblQtdEst) & "," & CodConfig & ",'QTDE','" & My.Computer.Clock.LocalTime & "'," & CodUser & ")" & vbCrLf & vbCrLf


                        '    End If
                        'End If


                    Else
                        Atualizar("Update Qtde set Qtd =" & Num(strQtd) & " where Codigo =" & intCodQtd)
                    End If

                End If

                strLote = dt.Rows.Item(I).Item("Lote").ToString

                Exit For

            Else
                If BaixaPorLote = True Then
                    dblSoma = parQtd - dblQtdTab
                Else
                    'If parReceita = True Then
                    '    If EstoqueSomado = True Then
                    '        Dim dblResul As Double = AjusteQtde(CodConfig, parCodProdAut)
                    '        dblQtdTab = dblResul
                    '    End If
                    'End If
                    dblSoma = dblQtdTab - parQtd
                End If


                Dim dtQtd As DataTable = CarregarDataTable("SELECT count(Codigo) as Qtd FROM Qtde where CodProd = " & parCodProdAut & " and Acabou = 'False' and CodConfig =" & CodConfig)
                Dim intQ As Integer
                Dim strDataFim As String = ""
                If dtQtd.Rows.Count > 0 Then
                    intQ = dtQtd.Rows.Item(0).Item("Qtd")
                    If intQ = 1 Then
                        strDataFim = ",DataFim = '" & My.Computer.Clock.LocalTime & "'"
                    End If
                End If


                Dim intEmFalta As Integer

                If dblSoma > dblQtdMin Then
                    intEmFalta = 0
                Else
                    intEmFalta = 1
                End If

                If BaixaPorLote = True Then
                    If parVenda = True Then
                        frmVenda.strCmdsSQL &= "Update Qtde Set Acabou = 'True', Qtd =0, EmFalta = '1' " & strDataFim & " where Codigo = " & intCodQtd & vbCrLf & vbCrLf
                    Else
                        Atualizar("Update Qtde Set Acabou = 'True', Qtd =0, EmFalta = '1' " & strDataFim & " where Codigo = " & intCodQtd)
                    End If
                Else
                    If parVenda = True Then
                        frmVenda.strCmdsSQL &= "Update Qtde set Qtd ='" & Num(dblSoma) & "', EmFalta = '" & intEmFalta & "' where Codigo = " & intCodQtd & vbCrLf & vbCrLf

                        'If parReceita = True Then
                        '    If EstoqueSomado = True Then
                        '        Dim dblQtdEst As Double = -parQtd

                        '        frmVenda.strCmdsSQL &= "INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data, CodUser) VALUES (" & _
                        '                      "" & parCodProdAut & "," & Num(dblQtdEst) & "," & CodConfig & ",'QTDE','" & My.Computer.Clock.LocalTime & "'," & CodUser & ")" & vbCrLf & vbCrLf


                        '    End If
                        'End If
                    Else
                        Atualizar("Update Qtde set Qtd ='" & Num(dblSoma) & "', EmFalta = '" & intEmFalta & "' where Codigo = " & intCodQtd)
                    End If


                    strLote = "U"
                End If


            End If

        Next

        If parReceita = False Then
            Return strLote
        Else

            dblCusto = dblCusto * dblQtdPCusto
            Return dblCusto
        End If

    End Function

    Public Shared Function AjustarEmFalta(ByVal parCodProdAut As Integer, ByVal parQtd As Double, ByVal parVenda As Boolean) As String
        Dim strQuery As String = ""
        Dim dt As DataTable = CarregarDataTable("Select Codigo, QtdMinima from Qtde where CodProd = " & parCodProdAut & " and CodConfig =" & CodConfig & " order by Codigo")

        Dim I As Integer
        Dim intEmFalta As Integer
        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(I).Item("QtdMinima").ToString <> "" Then
                Dim intCodQtd As Integer = dt.Rows.Item(I).Item("Codigo").ToString
                Dim dblQtdMin As Double = dt.Rows.Item(I).Item("QtdMinima").ToString

                Dim dblResul As Double = AjusteQtde(CodConfig, parCodProdAut)
                If dblResul > 0 Then
                    Dim dblResulQtd As Double = dblResul - parQtd

                    If dblResulQtd > dblQtdMin Then
                        intEmFalta = 0
                    Else
                        intEmFalta = 1
                    End If
                Else
                    intEmFalta = 1
                End If

                If parVenda = True Then
                    strQuery = "Update Qtde set EmFalta = '" & intEmFalta & "' where Codigo = " & intCodQtd & vbCrLf & vbCrLf
                Else
                    Atualizar("Update Qtde set EmFalta = '" & intEmFalta & "' where Codigo = " & intCodQtd)
                End If
            End If
        End If
        
        Return strQuery
    End Function
    Public Shared Function AlteraEstoque(ByVal parCodProd As Integer, ByVal parQtd As Double, ByVal parMaisMenos As String, ByVal parCodConfig As Integer) As Boolean
        Dim dt As DataTable = CarregarDataTable("Select Qtd, QtdMinima from Qtde where CodProd =" & parCodProd & " and CodConfig =" & parCodConfig)

        Dim dblQtdTab, dblQtdMinTab, dblResul As Double

        If dt.Rows.Count > 0 Then
            dblQtdTab = dt.Rows.Item(0).Item("Qtd").ToString
            dblQtdMinTab = dt.Rows.Item(0).Item("QtdMinima").ToString
            Dim intFalta As Integer = 0

            If parMaisMenos = "+" Then
                dblResul = dblQtdTab + parQtd
            ElseIf parMaisMenos = "-" Then
                dblResul = dblQtdTab - parQtd
            End If

            If dblQtdMinTab >= dblResul Then
                intFalta = 1
            End If

            Atualizar("Update Qtde set Qtd ='" & Num(dblResul) & "', EmFalta ='" & intFalta & "' where CodProd =" & parCodProd & " and CodConfig =" & parCodConfig)
        End If

        Return True

    End Function

End Class
