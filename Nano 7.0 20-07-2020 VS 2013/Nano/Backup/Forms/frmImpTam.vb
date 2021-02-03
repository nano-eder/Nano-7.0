Imports Nano.clsFuncoes
Imports System.Math
Public Class frmImpTam
    Dim I, J As Integer
    Dim strCod, strProd, strMarca, strPreco, strTexto As String
    Public strTipoEtiqueta As String
    Private Sub chkTudo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTudo.CheckedChanged

        Select Case Me.chkTudo.Checked

            Case True

                For I = 0 To Me.grd1.RowCount - 1
                    Me.grd1.SetRowCellValue(I, Me.colImprimir, True)
                    Me.colImprimir.OptionsColumn.ReadOnly = True
                Next


            Case False
                Me.colImprimir.OptionsColumn.ReadOnly = False

        End Select
    End Sub

    Private Sub frmImpTam_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.tbEti.Rows.Clear()
    End Sub

    Private Sub frmImpTam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub CarregarProduto(ByVal ParCodProd As Integer)

        Dim dt As DataTable = CarregarDataTable("Select Qtd, Tamanho, Acabou as Imprimir, Nome, CodigoInterno, Fabricante, Valor from Qtde Inner Join Produto on Qtde.CodProd = Produto.Codigo where CodProd =" & ParCodProd & " and Acabou = 'False' and CodConfig = " & CodConfig)

        For I = 0 To dt.Rows.Count - 1
            Me.tbEti.Rows.Add()
            Me.tbEti.Rows.Item(tbEti.Rows.Count - 1).Item("Qtd") = dt.Rows.Item(I).Item("Qtd").ToString
            Me.tbEti.Rows.Item(tbEti.Rows.Count - 1).Item("Tamanho") = dt.Rows.Item(I).Item("Tamanho").ToString
            Me.tbEti.Rows.Item(tbEti.Rows.Count - 1).Item("Imprimir") = dt.Rows.Item(I).Item("Imprimir")
            Me.tbEti.Rows.Item(tbEti.Rows.Count - 1).Item("Nome") = dt.Rows.Item(I).Item("Nome").ToString
            Me.tbEti.Rows.Item(tbEti.Rows.Count - 1).Item("CodigoInterno") = dt.Rows.Item(I).Item("CodigoInterno").ToString
            Me.tbEti.Rows.Item(tbEti.Rows.Count - 1).Item("Fabricante") = dt.Rows.Item(I).Item("Fabricante").ToString
            Me.tbEti.Rows.Item(tbEti.Rows.Count - 1).Item("Valor") = dt.Rows.Item(I).Item("Valor").ToString
        Next

    End Sub

    Private Sub btnCancelar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick

        Dim strAspas As String = """"

        If NomeImpCodigoBarra = "ARGOX OS-214 PLUS" Then

            If strTipoEtiqueta = "DUPLA GRANDE" Then



                strTexto = LerArquivo("C:\DuplaGrande.prn", True)

                Dim intCont As Integer = 0
                Dim intArq As Integer = 0
                For I = 0 To Me.grd1.RowCount - 1
                    If Me.grd1.GetRowCellValue(I, Me.colImprimir) = True Then

                        Dim dblQtd As Double
                        Dim strTam As String
                        Dim strProd1, strProd2 As String

                        strProd = Me.grd1.GetRowCellDisplayText(I, Me.colNome).Trim
                        strCod = Me.grd1.GetRowCellDisplayText(I, Me.CodigoInterno).Trim

                        If strProd.Trim.Length > 29 Then
                            strProd1 = Mid(strProd, 1, 29)
                            strProd2 = Mid(strProd, 30, strProd.Trim.Length)
                        Else
                            strProd1 = strProd
                            strProd2 = ""
                        End If

                        dblQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                        strTam = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho).Trim
                        Dim dblPreco As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValor).Trim
                        strPreco = dblPreco.ToString("0.00")
                        strMarca = Me.grd1.GetRowCellDisplayText(I, Me.colFabricante).Trim

                        For J = 0 To dblQtd - 1
                            intCont += 1


                            If intCont = 1 Then
                                strTexto = strTexto.Replace("EEEE", NomeEmpresa)
                                strTexto = strTexto.Replace("PPP1", strProd1)
                                strTexto = strTexto.Replace("PPP2", strProd2)
                                strTexto = strTexto.Replace("MMM1", strMarca)
                                strTexto = strTexto.Replace("00000-1", strCod & "-" & strTam)
                                strTexto = strTexto.Replace("VVV1", "R$ " & strPreco)
                                strTexto = strTexto.Replace("TTT1", "Tam.: " & strTam)

                                strTexto = strTexto.Replace("CCCCC1", strCod & "-" & strTam)


                            Else

                                strTexto = strTexto.Replace("PPP3", strProd1)
                                strTexto = strTexto.Replace("PPP4", strProd2)
                                strTexto = strTexto.Replace("MMM2", strMarca)
                                strTexto = strTexto.Replace("VVV2", "R$ " & strPreco)
                                strTexto = strTexto.Replace("TTT2", "Tam.: " & strTam)
                                strTexto = strTexto.Replace("00000-2", strCod & "-" & strTam)

                                strTexto = strTexto.Replace("CCCCC2", strCod & "-" & strTam)

                            End If

                            If intCont = 2 Then
                                EscreveArquivo("C:\Etiqueta1.prn", strTexto)
                                'clsImprimir.SendFileToPrinter(PortaImpressoraCodigoBarra, "C:\Etiqueta1.prn")
                                System.IO.File.Copy("C:\Etiqueta1.prn", PortaImpressoraCodigoBarra, True)
                                System.IO.File.Delete("C:\Etiqueta1.prn")
                                strTexto = LerArquivo("C:\DuplaGrande.prn", True)
                                intCont = 0
                            End If

                        Next


                    End If
                Next

                If intCont = 1 Then
                    EscreveArquivo("C:\Etiqueta1.prn", strTexto)
                    System.IO.File.Copy("C:\Etiqueta1.prn", PortaImpressoraCodigoBarra, True)
                    System.IO.File.Delete("C:\Etiqueta1.prn")
                    strTexto = LerArquivo("C:\DuplaGrande.prn", True)
                    intCont = 0
                End If


            ElseIf strTipoEtiqueta = "DUPLA MÉDIA" Then


                strTexto = LerArquivo("C:\DuplaMedia.prn", True)

                Dim intCont As Integer = 0
                Dim intArq As Integer = 0
                For I = 0 To Me.grd1.RowCount - 1
                    If Me.grd1.GetRowCellValue(I, Me.colImprimir) = True Then

                        Dim dblQtd As Double
                        Dim strTam As String
                        Dim strProd1, strProd2 As String

                        strProd = Me.grd1.GetRowCellDisplayText(I, Me.colNome).Trim
                        strCod = Me.grd1.GetRowCellDisplayText(I, Me.CodigoInterno).Trim

                        If strProd.Trim.Length > 38 Then
                            strProd1 = Mid(strProd, 1, 38)
                            strProd2 = Mid(strProd, 39, strProd.Trim.Length)
                        Else
                            strProd1 = strProd
                            strProd2 = ""
                        End If

                        dblQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                        strTam = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho).Trim
                        Dim dblPreco As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValor).Trim
                        strPreco = dblPreco.ToString("0.00")
                        strMarca = Me.grd1.GetRowCellDisplayText(I, Me.colFabricante).Trim

                        For J = 0 To dblQtd - 1
                            intCont += 1

                            If intCont = 1 Then
                                strTexto = strTexto.Replace("NOMEDALOJA", NomeEmpresa)
                                strTexto = strTexto.Replace("PPPP", strProd1)
                                strTexto = strTexto.Replace("TTTT", strProd2)
                                strTexto = strTexto.Replace("CCCC", strCod & "-" & strTam)
                                strTexto = strTexto.Replace("VVVV", "R$ " & strPreco)

                            Else

                                strTexto = strTexto.Replace("PPP2", strProd1)
                                strTexto = strTexto.Replace("TTT2", strProd2)
                                strTexto = strTexto.Replace("CCC2", strCod & "-" & strTam)
                                strTexto = strTexto.Replace("VVV2", "R$ " & strPreco)

                            End If

                            If intCont = 2 Then
                                EscreveArquivo("C:\Etiqueta3.prn", strTexto)
                                System.IO.File.Copy("C:\Etiqueta3.prn", PortaImpressoraCodigoBarra, True)
                                System.IO.File.Delete("C:\Etiqueta3.prn")
                                strTexto = LerArquivo("C:\DuplaMedia.prn", True)
                                intCont = 0
                            End If

                        Next


                    End If
                Next

                If intCont = 1 Then
                    EscreveArquivo("C:\Etiqueta3.prn", strTexto)
                    System.IO.File.Copy("C:\Etiqueta3.prn", PortaImpressoraCodigoBarra, True)
                    System.IO.File.Delete("C:\Etiqueta3.prn")
                    strTexto = LerArquivo("C:\DuplaMedia.prn", True)
                    intCont = 0
                End If


            End If

        ElseIf NomeImpCodigoBarra = "ZEBRA TLP 2844" Then

            strTexto = LerArquivo("C:\TemplateZebra.prn", True)

            Dim intCont As Integer = 0
            Dim intArq As Integer = 0
            For I = 0 To Me.grd1.RowCount - 1
                If Me.grd1.GetRowCellValue(I, Me.colImprimir) = True Then

                    Dim dblQtd As Double
                    Dim strTam As String
                    Dim strProd1, strProd2 As String

                    strProd = Me.grd1.GetRowCellDisplayText(I, Me.colNome).Trim
                    strCod = Me.grd1.GetRowCellDisplayText(I, Me.CodigoInterno).Trim

                    If strProd.Trim.Length > 29 Then
                        strProd1 = Mid(strProd, 1, 23)
                        strProd2 = Mid(strProd, 24, strProd.Trim.Length)
                    Else
                        strProd1 = strProd
                        strProd2 = ""
                    End If

                    dblQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                    strTam = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho).Trim
                    Dim dblPreco As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValor).Trim
                    strPreco = dblPreco.ToString("0.00")

                    Dim strMes, strAno As String

                    strMes = Now.Month
                    strAno = Now.Year
                    strAno = Mid(strAno, 3, strAno.Length)

                    For J = 0 To dblQtd - 1
                        intCont += 1

                        If intCont = 1 Then
                            strTexto = strTexto.Replace("NOME DA LOJA", NomeEmpresa)
                            strTexto = strTexto.Replace("A331,342,2,3,1,1,N,'PPPP1'", "A331,342,2,3,1,1,N,'" & strProd1 & "'")
                            strTexto = strTexto.Replace("A331,321,2,3,1,1,N,'PPPP2'", "A331,321,2,3,1,1,N,'" & strProd2 & "'")
                            strTexto = strTexto.Replace("B330,285,2,1,3,9,75,B,'123456-T'", "B330,285,2,1,3,9,75,B,'" & strCod & "-" & strTam & "'")
                            strTexto = strTexto.Replace("A309,96,2,4,3,3,N,'00,00'", "A309,96,2,4,3,3,N,'" & strPreco & "'")
                            strTexto = strTexto.Replace("MAA", strMes & strAno)
                        Else
                            strTexto = strTexto.Replace("A699,342,2,3,1,1,N,'PPPP1'", "A699,342,2,3,1,1,N,'" & strProd1 & "'")
                            strTexto = strTexto.Replace("A699,321,2,3,1,1,N,'PPPP2'", "A699,321,2,3,1,1,N,'" & strProd2 & "'")
                            strTexto = strTexto.Replace("B698,285,2,1,3,9,75,B,'123456-T'", "B698,285,2,1,3,9,75,B,'" & strCod & "-" & strTam & "'")
                            strTexto = strTexto.Replace("A677,96,2,4,3,3,N,'00,00'", "A677,96,2,4,3,3,N,'" & strPreco & "'")

                        End If

                        If intCont = 2 Then
                            strTexto = strTexto.Replace("'", strAspas)
                            EscreveArquivo("C:\Etiqueta1.prn", strTexto)
                            System.IO.File.Copy("C:\Etiqueta1.prn", PortaImpressoraCodigoBarra, True)
                            System.IO.File.Delete("C:\Etiqueta1.prn")
                            strTexto = LerArquivo("C:\TemplateZebra.prn", True)
                            intCont = 0
                        End If

                    Next


                End If
            Next

            If intCont = 1 Then
                strTexto = strTexto.Replace("'", strAspas)
                EscreveArquivo("C:\Etiqueta1.prn", strTexto)
                System.IO.File.Copy("C:\Etiqueta1.prn", PortaImpressoraCodigoBarra, True)
                System.IO.File.Delete("C:\Etiqueta1.prn")
                strTexto = LerArquivo("C:\TemplateZebra.prn", True)
                intCont = 0
            End If



        End If
       
    End Sub

End Class