Imports Nano.clsFuncoes
Imports Nano.clsFuncoesBematech
Imports System.Math

Public Class frmImpProd
    Dim I, J As Integer
    Dim strCod, strProd, strPreco, strTexto As String
    Public intCodProd As Integer
    Public strTipoEtiqueta As String
    Public intCodCli As Integer

    Public Sub CarregarProduto(ByVal ParCodProd As Integer, ByVal parQtde As String, ByVal parTamanho As String)

        Dim dt As DataTable = Nothing
        If EstoqueSomado = True Then
            dt = CarregarDataTable("Select (SELECT case when sum(EntradaNf.QtdProd) is null then 0 else sum(EntradaNf.QtdProd) end " & _
            "FROM EntradaNf left join TotalEntradaNf on EntradaNf.CodTotNf = TotalEntradaNf.Codigo where " & _
            "EntradaNf.CodProd = Produto. Codigo and EstoqueOk = 'True' and EntradaNf.CodConfig = " & CodConfig & ") - (SELECT case when " & _
            "sum(Pedido.Qtd) is null then 0 else sum(Pedido.Qtd) end FROM Pedido where Pedido.CodConfig = " & CodConfig & " and " & _
            "Pedido.CodProd = Produto.Codigo and Pedido.Devolvido = 'False') + (SELECT case when sum(AjusteQtde.Qtd) is null then 0 else  sum(AjusteQtde.Qtd) end " & _
            "FROM AjusteQtde where AjusteQtde.CodConfig = " & CodConfig & " and AjusteQtde.CodProd = Produto.Codigo) as Qtd, Nome, CodigoInterno, Valor, UnidadeMedida, Setor, Grupo, Locacao, CodigoBarra, Data, Validade, (Produto.Valor - ((Produto.Valor / 100) * Produto.Desconto)) as ValPromocao from Produto where Codigo =" & ParCodProd)

        Else
            dt = CarregarDataTable("Select Qtd, Tamanho, Nome, CodigoInterno, Valor, UnidadeMedida, Setor, Grupo, Locacao, " & _
            "CodigoBarra, Data, Validade, (Produto.Valor - ((Produto.Valor / 100) * Produto.Desconto)) as ValPromocao " & _
            "from Qtde Inner Join Produto on Qtde.CodProd = Produto.Codigo where CodProd =" & ParCodProd & " and Acabou = 'False' " & _
            "and CodConfig = " & CodConfig)

        End If

        For I = 0 To dt.Rows.Count - 1
            Me.tbProd.Rows.Add()
            If parQtde = "" Then
                Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Qtd") = Int(dt.Rows.Item(I).Item("Qtd").ToString)
            Else
                Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Qtd") = Int(parQtde)
            End If

            Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Produto") = dt.Rows.Item(I).Item("Nome").ToString
            Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Imprimir") = False
            Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("CodProd") = dt.Rows.Item(I).Item("CodigoInterno").ToString
            Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Valor") = dt.Rows.Item(I).Item("Valor").ToString
       

            Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("UnidadeMedida") = dt.Rows.Item(I).Item("UnidadeMedida").ToString
            Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Setor") = dt.Rows.Item(I).Item("Setor").ToString
            Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Grupo") = dt.Rows.Item(I).Item("Grupo").ToString
            Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Locacao") = dt.Rows.Item(I).Item("Locacao").ToString
            Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("CodigoBarra") = dt.Rows.Item(I).Item("CodigoBarra").ToString
            Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Validade") = dt.Rows.Item(I).Item("Validade").ToString
            Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Fabricacao") = dt.Rows.Item(I).Item("Data").ToString
            Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("ValPromocao") = dt.Rows.Item(I).Item("ValPromocao").ToString
            If parTamanho = "" Then
                If EstoqueSomado = False Then
                    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Tamanho") = dt.Rows.Item(I).Item("Tamanho").ToString
                End If
            Else
                Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Tamanho") = parTamanho
                Exit For
            End If
        Next

    End Sub

    Private Sub frmImpProd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim strTamanho As String = ""
        If Me.Tag = "Cliente" Then
            Me.colTamanho.Visible = False
            Me.colProduto.Caption = "Cliente"
            Dim vetEti As Array = Split(CodigoClienteEtiqueta, "|")
            Dim I, A As Integer
            For I = 0 To vetEti.Length - 1
                If vetEti(I) <> "" Then
                    Dim dt As DataTable = CarregarDataTable("Select Nome as Cliente, 'False' as Imprimir, Codigo from Cliente where Codigo =" & vetEti(I))
                    For A = 0 To dt.Rows.Count - 1
                        Me.tbProd.Rows.Add()
                      
                        Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Qtd") = 1
                        Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Produto") = dt.Rows.Item(A).Item("Cliente").ToString
                        Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Imprimir") = dt.Rows.Item(A).Item("Imprimir").ToString
                        Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("CodProd") = dt.Rows.Item(A).Item("Codigo").ToString

                    Next
                End If
            Next
        Else
            If NomeImpCodigoBarra = "ZEBRA TLP 2844" Then

                Dim vetEti As Array = Split(CodigoProdutoEtiqueta, "|")
                Dim vetQtd As Array = Split(QtdeEtiqueta, "|")
                Dim vetTam As Array = Split(TamanhoEtiqueta, "|")
                Dim I As Integer
                For I = 0 To vetEti.Length - 1
                    If vetEti(I) <> "" Then
                        If QtdeEtiqueta = "" Then
                            CarregarProduto(vetEti(I), "", "")
                        Else
                            If TamanhoEtiqueta = "" Then
                                CarregarProduto(vetEti(I), vetQtd(I), "")
                            Else
                                CarregarProduto(vetEti(I), vetQtd(I), vetTam(I))
                            End If
                        End If
                    End If
                Next
            ElseIf NomeImpCodigoBarra = "ARGOX OS-214 PLUS" Then
                If Me.Tag.ToString.Contains("TRIPLA MÉDIA ARGOX") = False Then
                    Me.colTamanho.Visible = False

                    Dim vetEti As Array = Split(CodigoProdutoEtiqueta, "|")
                    Dim vetQtd As Array = Split(QtdeEtiqueta, "|")
                    Dim I, A As Integer
                    For I = 0 To vetEti.Length - 1
                        If vetEti(I) <> "" Then
                            Dim dt As DataTable = CarregarDataTable("Select Nome as Produto, 'False' as Imprimir, CodigoInterno as CodProd, Valor from Produto where Codigo =" & vetEti(I))
                            For A = 0 To dt.Rows.Count - 1
                                Me.tbProd.Rows.Add()
                                If vetQtd.Length = vetEti.Length Then
                                    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Qtd") = vetQtd(I).ToString
                                Else
                                    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Qtd") = 1
                                End If

                                Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Produto") = dt.Rows.Item(A).Item("Produto").ToString
                                Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Imprimir") = dt.Rows.Item(A).Item("Imprimir").ToString
                                Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("CodProd") = dt.Rows.Item(A).Item("CodProd").ToString
                                Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Valor") = dt.Rows.Item(A).Item("Valor").ToString
                                Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Tamanho") = strTamanho
                            Next
                        End If
                    Next
                Else

                    Dim vetEti As Array = Split(CodigoProdutoEtiqueta, "|")
                    Dim vetQtd As Array = Split(QtdeEtiqueta, "|")
                    Dim vetTam As Array = Split(TamanhoEtiqueta, "|")
                    Dim I As Integer
                    For I = 0 To vetEti.Length - 1
                        If vetEti(I) <> "" Then
                            If QtdeEtiqueta = "" Then
                                CarregarProduto(vetEti(I), "", "")
                            Else
                                If TamanhoEtiqueta = "" Then
                                    CarregarProduto(vetEti(I), vetQtd(I), "")
                                Else
                                    CarregarProduto(vetEti(I), vetQtd(I), vetTam(I))
                                End If
                            End If
                        End If
                    Next

                End If
            Else

                Dim vetEti As Array = Split(CodigoProdutoEtiqueta, "|")
                Dim vetQtd As Array = Split(QtdeEtiqueta, "|")
                Dim vetTam As Array = Split(TamanhoEtiqueta, "|")
                Dim I As Integer
                For I = 0 To vetEti.Length - 1
                    If vetEti(I) <> "" Then
                        If QtdeEtiqueta = "" Then
                            CarregarProduto(vetEti(I), "", "")
                        Else
                            If TamanhoEtiqueta = "" Then
                                CarregarProduto(vetEti(I), vetQtd(I), "")
                            Else
                                CarregarProduto(vetEti(I), vetQtd(I), vetTam(I))
                            End If
                        End If
                    End If
                Next

            End If
        End If
        

        CodigoClienteEtiqueta = ""
        CodigoProdutoEtiqueta = ""
        Timer1.Start()
    End Sub

    Private Sub chkTudo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTudo.CheckedChanged

        Select Case Me.chkTudo.Checked

            Case True

                For I = 0 To Me.GridView1.RowCount - 1
                    Me.GridView1.SetRowCellValue(I, Me.colImprimir, True)
                    Me.colImprimir.OptionsColumn.ReadOnly = True
                Next


            Case False
                Me.colImprimir.OptionsColumn.ReadOnly = False

        End Select
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Tag = "Cliente" Then
            If CodigoClienteEtiqueta <> "" Then
                Dim dt As DataTable = CarregarDataTable("Select Nome as Cliente, 'False' as Imprimir, Codigo from Cliente where Codigo =" & CodigoClienteEtiqueta)

                Dim I As Integer
                For I = 0 To dt.Rows.Count - 1
                    Me.tbProd.Rows.Add()
                    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Qtd") = "1"
                    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Produto") = dt.Rows.Item(I).Item("Cliente").ToString
                    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Imprimir") = dt.Rows.Item(I).Item("Imprimir").ToString
                    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("CodProd") = dt.Rows.Item(I).Item("Codigo").ToString

                Next
            End If
            CodigoClienteEtiqueta = ""
        Else
            If CodigoProdutoEtiqueta <> "" Then
                'Dim dt As DataTable = CarregarDataTable("Select Nome as Produto,  CodigoInterno as CodProd, Tamanho, UnidadeMedida, Setor, Grupo, Locacao, CodigoBarra, Valor, sum(Qtd) from Produto left join Qtde on Produto.Codigo = Qtde.CodProd where Produto.Codigo =" & CodigoProdutoEtiqueta & " group by Nome,  CodigoInterno, Tamanho, UnidadeMedida, Setor, Grupo, Locacao, CodigoBarra, Valor")
                ''Dim dt As DataTable = CarregarDataTable("Select Qtd, Tamanho, Nome, CodigoInterno, Valor, UnidadeMedida, Setor, Grupo, Locacao, CodigoBarra from Qtde Inner Join Produto on Qtde.CodProd = Produto.Codigo where CodProd =" & ParCodProd & " and Acabou = 'False' and CodConfig = " & CodConfig)

                'Dim I As Integer
                'For I = 0 To dt.Rows.Count - 1
                '    Me.tbProd.Rows.Add()
                '    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Qtd") = "1"
                '    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Produto") = dt.Rows.Item(I).Item("Produto").ToString
                '    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Imprimir") = False
                '    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("CodProd") = dt.Rows.Item(I).Item("CodProd").ToString
                '    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Valor") = dt.Rows.Item(I).Item("Valor").ToString
                '    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Tamanho") = dt.Rows.Item(I).Item("Tamanho").ToString
                '    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("UnidadeMedida") = dt.Rows.Item(I).Item("UnidadeMedida").ToString
                '    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Setor") = dt.Rows.Item(I).Item("Setor").ToString
                '    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Grupo") = dt.Rows.Item(I).Item("Grupo").ToString
                '    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Locacao") = dt.Rows.Item(I).Item("Locacao").ToString
                '    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("CodigoBarra") = dt.Rows.Item(I).Item("CodigoBarra").ToString

                'Next


                Dim dt As DataTable = CarregarDataTable("Select Qtd, Tamanho, Nome, CodigoInterno, Valor, UnidadeMedida, Setor, Grupo, Locacao, CodigoBarra, (Produto.Valor - ((Produto.Valor / 100) * Produto.Desconto)) as ValPromocao  from Qtde Inner Join Produto on Qtde.CodProd = Produto.Codigo where CodProd =" & CodigoProdutoEtiqueta & " and Acabou = 'False' and CodConfig = " & CodConfig)

                For I = 0 To dt.Rows.Count - 1
                    Me.tbProd.Rows.Add()
                    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Qtd") = Int(dt.Rows.Item(I).Item("Qtd").ToString)
                    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Produto") = dt.Rows.Item(I).Item("Nome").ToString
                    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Imprimir") = False
                    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("CodProd") = dt.Rows.Item(I).Item("CodigoInterno").ToString
                    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Valor") = dt.Rows.Item(I).Item("Valor").ToString
                    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Tamanho") = dt.Rows.Item(I).Item("Tamanho").ToString
                    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("UnidadeMedida") = dt.Rows.Item(I).Item("UnidadeMedida").ToString
                    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Setor") = dt.Rows.Item(I).Item("Setor").ToString
                    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Grupo") = dt.Rows.Item(I).Item("Grupo").ToString
                    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("Locacao") = dt.Rows.Item(I).Item("Locacao").ToString
                    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("CodigoBarra") = dt.Rows.Item(I).Item("CodigoBarra").ToString
                    Me.tbProd.Rows.Item(Me.tbProd.Rows.Count - 1).Item("ValPromocao") = dt.Rows.Item(I).Item("ValPromocao").ToString

                Next
            End If
            CodigoProdutoEtiqueta = ""
        End If
        
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnOk_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOk.ItemClick
        If Me.Tag = "Cliente" Then
            If strTipoEtiqueta = "DUPLA" Then
                Dim rel As New relImp2

                Dim I As Integer

                For I = 0 To GridView1.RowCount - 1

                    Dim dtCli As DataTable = CarregarDataTable("SELECT Endereco, Numero, Bairro, Cep, Cidade, Estado, Complemento FROM Cliente where Codigo = " & Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).Trim)
                    If dtCli.Rows.Count > 0 Then
                        Dim intQtd As Integer = Me.GridView1.GetRowCellDisplayText(I, Me.colQtd)
                        Dim A As Integer = 0
                        For A = 0 To intQtd - 1
                            rel.DsMecanica1.Produto.Rows.Add()
                            rel.DsMecanica1.Produto.Rows.Item(rel.DsMecanica1.Produto.Rows.Count - 1).Item("Nome") = Me.GridView1.GetRowCellDisplayText(I, Me.colProduto).Trim
                            rel.DsMecanica1.Produto.Rows.Item(rel.DsMecanica1.Produto.Rows.Count - 1).Item("Grupo") = dtCli.Rows.Item(0).Item("Endereco").ToString.Trim & ", " & dtCli.Rows.Item(0).Item("Numero").ToString.Trim
                            rel.DsMecanica1.Produto.Rows.Item(rel.DsMecanica1.Produto.Rows.Count - 1).Item("Fabricante") = dtCli.Rows.Item(0).Item("Bairro").ToString.Trim & " - " & dtCli.Rows.Item(0).Item("Complemento").ToString.Trim
                            rel.DsMecanica1.Produto.Rows.Item(rel.DsMecanica1.Produto.Rows.Count - 1).Item("Obs") = dtCli.Rows.Item(0).Item("Cidade").ToString.Trim & " - " & dtCli.Rows.Item(0).Item("Cep").ToString.Replace(".", "").Trim & " - " & dtCli.Rows.Item(0).Item("Estado").ToString.Trim
                        Next
                    End If

                Next

                rel.ShowPreview()
            Else
                Dim rel As New relPimacoTripla

                Dim I As Integer

                For I = 0 To GridView1.RowCount - 1
                    Dim dtCli As DataTable = CarregarDataTable("SELECT Nome, Endereco, Numero, Bairro, Cep, Cidade, Estado, Complemento FROM Cliente where Codigo = " & Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).Trim)
                    If dtCli.Rows.Count > 0 Then
                        Dim intQtd As Integer = Me.GridView1.GetRowCellDisplayText(I, Me.colQtd)
                        Dim A As Integer = 0
                        For A = 0 To intQtd - 1
                            rel.tbProd.Rows.Add()
                            rel.tbProd.Rows.Item(rel.tbProd.Rows.Count - 1).Item("Nome") = dtCli.Rows.Item(0).Item("Nome").ToString.Trim
                            rel.tbProd.Rows.Item(rel.tbProd.Rows.Count - 1).Item("Rua") = dtCli.Rows.Item(0).Item("Endereco").ToString.Trim
                            rel.tbProd.Rows.Item(rel.tbProd.Rows.Count - 1).Item("Bairro") = dtCli.Rows.Item(0).Item("Bairro").ToString.Trim
                            rel.tbProd.Rows.Item(rel.tbProd.Rows.Count - 1).Item("Cidade") = dtCli.Rows.Item(0).Item("Cidade").ToString.Trim
                            rel.tbProd.Rows.Item(rel.tbProd.Rows.Count - 1).Item("Num") = dtCli.Rows.Item(0).Item("Numero").ToString.Trim
                            rel.tbProd.Rows.Item(rel.tbProd.Rows.Count - 1).Item("Cep") = dtCli.Rows.Item(0).Item("Cep").ToString.Trim
                            rel.tbProd.Rows.Item(rel.tbProd.Rows.Count - 1).Item("Complemento") = dtCli.Rows.Item(0).Item("Complemento").ToString.Trim

                        Next
                    End If
                Next

                rel.ShowPreview()

            End If



        Else

            Select Case NomeImpCodigoBarra


                Case "ARGOX OS-214 PLUS"

                    Select Case Me.Tag
                        Case "TRIPLA PEQUENA"

                            strTexto = LerArquivo("C:\TriplaPequena.prn", True)

                            If strTexto.Trim = "" Then Exit Sub

                            Dim intCont As Integer

                            For I = 0 To Me.GridView1.RowCount - 1

                                If Me.GridView1.GetRowCellValue(I, Me.colImprimir) = True Then

                                    Dim dblQtd As Double

                                    Dim strProd1 As String
                                    Dim dblPreco As Double

                                    strProd = Me.GridView1.GetRowCellDisplayText(I, Me.colProduto).Trim
                                    strCod = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).Trim
                                    dblPreco = Me.GridView1.GetRowCellDisplayText(I, Me.colValor).Trim
                                    strPreco = dblPreco.ToString("0.00")

                                    If Me.GridView1.GetRowCellDisplayText(I, Me.colQtd).ToString.Trim <> "" Then
                                        dblQtd = Me.GridView1.GetRowCellDisplayText(I, Me.colQtd)
                                    Else
                                        dblQtd = 0
                                    End If

                                    If strProd.Trim.Length > 29 Then
                                        strProd1 = Mid(strProd, 1, 29)
                                    Else
                                        strProd1 = strProd
                                    End If

                                    For J = 0 To dblQtd - 1

                                        intCont += 1

                                        Select Case intCont

                                            Case 1

                                                strTexto = strTexto.Replace("111100000620020PPPP", "111100000620020" & strProd1)
                                                strTexto = strTexto.Replace("1A4202500240020CCCCC", "1A4202500240020" & strCod)
                                                strTexto = strTexto.Replace("121100000070059VVVV", "121100000070059" & "R$ " & strPreco)

                                            Case 2
                                                strTexto = strTexto.Replace("111100000620158PPPP", "111100000620158" & strProd1)
                                                strTexto = strTexto.Replace("1A4202500240158CCCCC", "1A4202500240158" & strCod)
                                                strTexto = strTexto.Replace("121100000070197VVVV", "121100000070197" & "R$ " & strPreco)
                                            Case 3
                                                strTexto = strTexto.Replace("111100000620296PPPP", "111100000620296" & strProd1)
                                                strTexto = strTexto.Replace("1A4202500240296CCCCC", "1A4202500240296" & strCod)
                                                strTexto = strTexto.Replace("121100000070335VVVV", "121100000070335" & "R$ " & strPreco)
                                        End Select


                                        If intCont = 3 Then
                                            EscreveArquivo("C:\Etiqueta2.prn", strTexto)
                                            System.IO.File.Copy("C:\Etiqueta2.prn", PortaImpressoraCodigoBarra)
                                            System.IO.File.Delete("C:\Etiqueta2.prn")

                                            strTexto = LerArquivo("C:\TriplaPequena.prn", True)
                                            intCont = 0
                                        End If

                                    Next

                                End If
                            Next

                            If intCont > 0 Then
                                EscreveArquivo("C:\Etiqueta2.prn", strTexto)
                                System.IO.File.Copy("C:\Etiqueta2.prn", PortaImpressoraCodigoBarra)
                                System.IO.File.Delete("C:\Etiqueta2.prn")
                            End If
                        Case "TRIPLA MINI"

                            strTexto = LerArquivo("C:\TemplateMini.prn", True)

                            If strTexto.Trim = "" Then Exit Sub

                            Dim intCont As Integer

                            For I = 0 To Me.GridView1.RowCount - 1

                                If Me.GridView1.GetRowCellValue(I, Me.colImprimir) = True Then

                                    Dim dblQtd As Double

                                    Dim strProd1, strProd2 As String
                                    Dim dblPreco As Double

                                    strProd = Me.GridView1.GetRowCellDisplayText(I, Me.colProduto).Trim
                                    strCod = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).Trim
                                    dblPreco = Me.GridView1.GetRowCellDisplayText(I, Me.colValor).Trim
                                    strPreco = dblPreco.ToString("0.00")

                                    If Me.GridView1.GetRowCellDisplayText(I, Me.colQtd).ToString.Trim <> "" Then
                                        dblQtd = Me.GridView1.GetRowCellDisplayText(I, Me.colQtd)
                                    Else
                                        dblQtd = 0
                                    End If

                                    If strProd.Trim.Length > 19 Then
                                        strProd1 = Mid(strProd, 1, 19)
                                    Else
                                        strProd1 = strProd
                                    End If

                                    If strProd.Trim.Length > 19 Then
                                        strProd2 = Mid(strProd, 20, strProd.Length)
                                    Else
                                        strProd2 = ""
                                    End If

                                    For J = 0 To dblQtd - 1

                                        intCont += 1

                                        Select Case intCont

                                            Case 1
                                                strTexto = strTexto.Replace("1E2200800370009", "1E2200800370009C" & strCod)
                                                strTexto = strTexto.Replace("191100100250008", "191100100250008" & strProd1)
                                                strTexto = strTexto.Replace("191100100150008", "191100100150008" & strProd2)
                                                strTexto = strTexto.Replace("121100000030051", "121100000030051" & "R$ " & strPreco)

                                            Case 2
                                                strTexto = strTexto.Replace("1E2200800370131", "1E2200800370131C" & strCod)
                                                strTexto = strTexto.Replace("191100100250130", "191100100250130" & strProd1)
                                                strTexto = strTexto.Replace("191100100150130", "191100100150130" & strProd2)
                                                strTexto = strTexto.Replace("121100000030173", "121100000030173" & "R$ " & strPreco)
                                            Case 3
                                                strTexto = strTexto.Replace("1E2200800370253", "1E2200800370253C" & strCod)
                                                strTexto = strTexto.Replace("191100100250252", "191100100250252" & strProd1)
                                                strTexto = strTexto.Replace("191100100150252", "191100100150252" & strProd2)
                                                strTexto = strTexto.Replace("121100000030295", "121100000030295" & "R$ " & strPreco)
                                        End Select


                                        If intCont = 3 Then
                                            EscreveArquivo("C:\Etiqueta3.prn", strTexto)
                                            System.IO.File.Copy("C:\Etiqueta3.prn", PortaImpressoraCodigoBarra)
                                            System.IO.File.Delete("C:\Etiqueta3.prn")
                                            strTexto = LerArquivo("C:\TemplateMini.prn", True)
                                            intCont = 0
                                        End If

                                    Next

                                End If
                            Next

                            If intCont > 0 Then
                                EscreveArquivo("C:\Etiqueta3.prn", strTexto)
                                System.IO.File.Copy("C:\Etiqueta3.prn", PortaImpressoraCodigoBarra)
                                System.IO.File.Delete("C:\Etiqueta3.prn")
                            End If

                        Case "TRIPLA MÉDIA ARGOX"
                            Dim index As Integer = -999997
                            GridView1.FocusedRowHandle = index
                            GridView1.ShowEditor()

                            Dim rel As New relTriplaMArgox

                            With rel.tbProd.Rows
                                For I = 0 To Me.GridView1.RowCount - 1
                                    If Me.GridView1.GetRowCellValue(I, Me.colImprimir) = True Then
                                        Dim dblQtd As Integer
                                        If Me.GridView1.GetRowCellDisplayText(I, Me.colQtd).ToString.Trim <> "" Then
                                            dblQtd = Me.GridView1.GetRowCellDisplayText(I, Me.colQtd)
                                        Else
                                            dblQtd = 0
                                        End If
                                        For J = 0 To dblQtd - 1
                                            If Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) <> "" Then
                                                Dim imgImagem As New PictureBox

                                                imgImagem.Size = New System.Drawing.Size(300, 30)
                                                Dim intQtd As Integer
                                                Dim intLens As Integer = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).Length
                                                If intLens > 7 Then
                                                    intQtd = 160
                                                ElseIf intLens >= 6 And intLens <= 7 Then
                                                    intQtd = 140
                                                Else
                                                    intQtd = 120
                                                End If

                                                Dim imagem As Byte() = Nothing
                                                
                                                Dim Barcode As New BarcodeLib.Barcode(Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & "-" & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString, BarcodeLib.TYPE.CODE128)
                                                Try
                                                    imgImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE128, Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & "-" & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString, intQtd, 19)
                                                    imagem = converteimagem(imgImagem.Image)
                                                Catch ex As Exception
                                                    intQtd = 160
                                                    imgImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE128, Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & "-" & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString, intQtd, 19)
                                                    imagem = converteimagem(imgImagem.Image)
                                                End Try
                                            

                                                rel.picLogo.Image = LogoTipo

                                                .Add()
                                                .Item(.Count - 1).Item("Empresa") = NomeEmpresa
                                                .Item(.Count - 1).Item("Produto") = Me.GridView1.GetRowCellDisplayText(I, Me.colProduto)

                                                Dim dblValor As Double = Me.GridView1.GetRowCellDisplayText(I, Me.colValor)
                                                .Item(.Count - 1).Item("Valor") = "R$" & dblValor.ToString("0.00")

                                                If Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString <> "" Then
                                                    .Item(.Count - 1).Item("CodigoInterno") = "COD." & Space(3) & Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & "-" & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString
                                                Else
                                                    .Item(.Count - 1).Item("CodigoInterno") = "COD." & Space(3) & Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd)
                                                End If

                                                .Item(.Count - 1).Item("CodigoBarra") = imagem
                                            End If
                                        Next
                                    End If
                                Next
                            End With
                            rel.ShowPreview()

                        Case "DUPLA MÉDIA ARGOX"
                            Dim index As Integer = -999997
                            GridView1.FocusedRowHandle = index
                            GridView1.ShowEditor()

                            Dim rel As New relDuplaMArgox

                            With rel.tbProd.Rows
                                For I = 0 To Me.GridView1.RowCount - 1
                                    If Me.GridView1.GetRowCellValue(I, Me.colImprimir) = True Then
                                        Dim dblQtd As Integer
                                        If Me.GridView1.GetRowCellDisplayText(I, Me.colQtd).ToString.Trim <> "" Then
                                            dblQtd = Me.GridView1.GetRowCellDisplayText(I, Me.colQtd)
                                        Else
                                            dblQtd = 0
                                        End If
                                        For J = 0 To dblQtd - 1
                                            If Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) <> "" Then
                                                Dim imgImagem As New PictureBox
                                                imgImagem.Size = New System.Drawing.Size(300, 30)

                                                Dim intQtd As Integer
                                                Dim intLens As Integer = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).Length
                                                If intLens > 7 Then
                                                    intQtd = 160
                                                ElseIf intLens >= 6 And intLens <= 7 Then
                                                    intQtd = 140
                                                Else
                                                    intQtd = 120
                                                End If

                                                Dim bitImagem As Byte() = Nothing
                                                Dim Barcode As New BarcodeLib.Barcode(Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & "-" & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString, BarcodeLib.TYPE.CODE128)
                                                imgImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE128, Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & "-" & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString, intQtd, 19)
                                                imgImagem.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                                                bitImagem = converteimagem(imgImagem.Image)


                                                .Add()
                                                .Item(.Count - 1).Item("Vendedor") = "Vendedor:"
                                                .Item(.Count - 1).Item("Produto") = Me.GridView1.GetRowCellDisplayText(I, Me.colProduto)

                                                If Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString <> "" Then
                                                    .Item(.Count - 1).Item("CodigoInterno") = "Cód:" & Space(3) & Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & "-" & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString
                                                Else
                                                    .Item(.Count - 1).Item("CodigoInterno") = "Cód:" & Space(3) & Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd)
                                                End If

                                                .Item(.Count - 1).Item("CodigoBarra") = bitImagem
                                            End If
                                        Next
                                    End If
                                Next
                            End With
                            rel.ShowPreview()
                    End Select
                Case "ZEBRA ZT"
                    Select Case Me.Tag
                        Case "ZT 230 DUPLA"
                            Dim index As Integer = -999997
                            GridView1.FocusedRowHandle = index
                            GridView1.ShowEditor()

                            Dim rel As New relZT230Dupla

                            With rel.tbProd.Rows
                                For I = 0 To Me.GridView1.RowCount - 1
                                    If Me.GridView1.GetRowCellValue(I, Me.colImprimir) = True Then
                                        Dim dblQtd As Integer
                                        If Me.GridView1.GetRowCellDisplayText(I, Me.colQtd).ToString.Trim <> "" Then
                                            dblQtd = Me.GridView1.GetRowCellDisplayText(I, Me.colQtd)
                                        Else
                                            dblQtd = 0
                                        End If
                                        For J = 0 To dblQtd - 1
                                            If Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) <> "" Then
                                                Dim imgImagem As New PictureBox

                                                imgImagem.Size = New System.Drawing.Size(200, 20)
                                                Dim intQtd As Integer = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).Length
                                                If intQtd >= 4 Then
                                                    intQtd = 100
                                                ElseIf intQtd = 3 Then
                                                    intQtd = 120
                                                Else
                                                    intQtd = 120
                                                End If

                                                Dim Barcode As New BarcodeLib.Barcode(Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd), BarcodeLib.TYPE.CODE128)
                                                imgImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE128, Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd), intQtd, 19)
                                                Dim imagem As Byte() = converteimagem(imgImagem.Image)

                                                .Add()
                                               .Item(.Count - 1).Item("Produto") = Me.GridView1.GetRowCellDisplayText(I, Me.colProduto)
                                                Dim dblValor As Double = Me.GridView1.GetRowCellDisplayText(I, Me.colValor)
                                                .Item(.Count - 1).Item("Valor") = "R$" & dblValor.ToString("0.00")
                                                .Item(.Count - 1).Item("CodigoBarra") = imagem
                                                .Item(.Count - 1).Item("CodigoInterno") = Me.GridView1.GetRowCellDisplayText(I, Me.colCodigoBarra)

                                            End If
                                        Next
                                    End If
                                Next
                            End With
                            rel.PrintingSystem.ShowMarginsWarning = False
                            rel.Print(PortaImpressoraCodigoBarra)
                            'rel.ShowPreview()
                    End Select


                Case "ZEBRA TLP 2844"

                    Select Case Me.Tag
                        Case "TRIPLA PEQUENA"

                            strTexto = LerArquivo("C:\TriplaPequena.prn", True)

                            If strTexto.Trim = "" Then Exit Sub

                            Dim intCont As Integer

                            For I = 0 To Me.GridView1.RowCount - 1

                                If Me.GridView1.GetRowCellValue(I, Me.colImprimir) = True Then

                                    Dim dblQtd As Double

                                    Dim strProd1, strProd2, strTam As String
                                    Dim dblPreco As Double

                                    strTam = ""
                                    strProd = Me.GridView1.GetRowCellDisplayText(I, Me.colProduto).Trim

                                    strProd = Dir(strProd, 36)
                                    strProd = Mid(strProd, 1, 36)

                                    strCod = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).Trim
                                    dblPreco = Me.GridView1.GetRowCellDisplayText(I, Me.colValor).Trim

                                    If Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).Trim <> "" Then
                                        strTam = "-" & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).Trim
                                    End If

                                    strPreco = dblPreco.ToString("0.00")

                                    If Me.GridView1.GetRowCellDisplayText(I, Me.colQtd).ToString.Trim <> "" Then
                                        dblQtd = Me.GridView1.GetRowCellDisplayText(I, Me.colQtd)
                                    Else
                                        dblQtd = 0
                                    End If


                                    strProd1 = Mid(strProd, 1, 18)
                                    strProd2 = Mid(strProd, 19, 36)

                                    strProd1 = strProd1.Trim
                                    strProd2 = strProd2.Trim


                                    For J = 0 To dblQtd - 1

                                        intCont += 1

                                        Select Case intCont

                                            Case 1

                                                strTexto = strTexto.Replace("PPP1-1", strProd1)
                                                strTexto = strTexto.Replace("PPP1-2", strProd2)
                                                strTexto = strTexto.Replace("123456-1", strCod & strTam)
                                                strTexto = strTexto.Replace("VVV1", strPreco)

                                            Case 2
                                                strTexto = strTexto.Replace("PPP2-1", strProd1)
                                                strTexto = strTexto.Replace("PPP2-2", strProd2)
                                                strTexto = strTexto.Replace("123456-2", strCod & strTam)
                                                strTexto = strTexto.Replace("VVV2", strPreco)
                                            Case 3
                                                strTexto = strTexto.Replace("PPP3-1", strProd1)
                                                strTexto = strTexto.Replace("PPP3-2", strProd2)
                                                strTexto = strTexto.Replace("123456-3", strCod & strTam)
                                                strTexto = strTexto.Replace("VVV3", strPreco)
                                        End Select


                                        If intCont = 3 Then
                                            EscreveArquivo("C:\Etiqueta2.prn", strTexto)
                                            System.IO.File.Copy("C:\Etiqueta2.prn", PortaImpressoraCodigoBarra)
                                            System.IO.File.Delete("C:\Etiqueta2.prn")

                                            strTexto = LerArquivo("C:\TriplaPequena.prn", True)
                                            intCont = 0
                                        End If

                                    Next

                                End If
                            Next

                            If intCont > 0 Then
                                EscreveArquivo("C:\Etiqueta2.prn", strTexto)
                                System.IO.File.Copy("C:\Etiqueta2.prn", PortaImpressoraCodigoBarra)
                                System.IO.File.Delete("C:\Etiqueta2.prn")
                            End If


                        Case "GÔNDOLA"


                            strTexto = LerArquivo(My.Application.Info.DirectoryPath & "\EtiquetaGondola.prn", True)

                            If strTexto.Trim = "" Then Exit Sub

                            Dim intCont As Integer

                            For I = 0 To Me.GridView1.RowCount - 1

                                If Me.GridView1.GetRowCellValue(I, Me.colImprimir) = True Then

                                    Dim dblQtd As Double

                                    Dim strProd1, strProd2, strTam, strUM As String
                                    Dim dblPreco As Double

                                    strTam = ""
                                    strProd = Me.GridView1.GetRowCellDisplayText(I, Me.colProduto).Trim

                                    strProd = Dir(strProd, 56)
                                    strProd = Mid(strProd, 1, 56)

                                    strCod = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).Trim
                                    dblPreco = Me.GridView1.GetRowCellDisplayText(I, Me.colValor).Trim

                                    If Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).Trim <> "" Then
                                        strTam = "-" & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).Trim
                                    End If

                                    strPreco = dblPreco.ToString("0.00")

                                    If Me.GridView1.GetRowCellDisplayText(I, Me.colQtd).ToString.Trim <> "" Then
                                        dblQtd = Me.GridView1.GetRowCellDisplayText(I, Me.colQtd)
                                    Else
                                        dblQtd = 0
                                    End If

                                    strUM = Me.GridView1.GetRowCellDisplayText(I, Me.colUnidadeMedida).ToString.Trim


                                    strProd1 = Mid(strProd, 1, 28)
                                    strProd2 = Mid(strProd, 29, 56)

                                    strProd1 = strProd1.Trim
                                    strProd2 = strProd2.Trim


                                    For J = 0 To dblQtd - 1

                                        strTexto = strTexto.Replace("UNIDADE", strUM)
                                        strTexto = strTexto.Replace("PPPP2", strProd2)
                                        strTexto = strTexto.Replace("NOME DA LOJA", NomeEmpresa)
                                        strTexto = strTexto.Replace("PPPP1", strProd1)
                                        strTexto = strTexto.Replace("00,00", strPreco)
                                        strTexto = strTexto.Replace("123456-T", strCod & strTam)

                                        EscreveArquivo("C:\EtiquetaGondola.prn", strTexto)
                                        System.IO.File.Copy("C:\EtiquetaGondola.prn", PortaImpressoraCodigoBarra)
                                        System.IO.File.Delete("C:\EtiquetaGondola.prn")

                                        strTexto = LerArquivo(My.Application.Info.DirectoryPath & "\EtiquetaGondola.prn", True)
                                        intCont = 0

                                    Next

                                End If
                            Next

                            If intCont > 0 Then
                                EscreveArquivo("C:\Etiqueta2.prn", strTexto)
                                System.IO.File.Copy("C:\Etiqueta2.prn", PortaImpressoraCodigoBarra)
                                System.IO.File.Delete("C:\Etiqueta2.prn")
                            End If


                        Case "TRIPLA MINI"

                            strTexto = LerArquivo("C:\TemplateMini.prn", True)

                            If strTexto.Trim = "" Then Exit Sub

                            Dim intCont As Integer

                            For I = 0 To Me.GridView1.RowCount - 1

                                If Me.GridView1.GetRowCellValue(I, Me.colImprimir) = True Then

                                    Dim dblQtd As Double

                                    Dim strProd1, strProd2 As String
                                    Dim dblPreco As Double

                                    strProd = Me.GridView1.GetRowCellDisplayText(I, Me.colProduto).Trim
                                    strCod = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).Trim
                                    dblPreco = Me.GridView1.GetRowCellDisplayText(I, Me.colValor).Trim
                                    strPreco = dblPreco.ToString("0.00")

                                    If Me.GridView1.GetRowCellDisplayText(I, Me.colQtd).ToString.Trim <> "" Then
                                        dblQtd = Me.GridView1.GetRowCellDisplayText(I, Me.colQtd)
                                    Else
                                        dblQtd = 0
                                    End If

                                    If strProd.Trim.Length > 19 Then
                                        strProd1 = Mid(strProd, 1, 19)
                                    Else
                                        strProd1 = strProd
                                    End If

                                    If strProd.Trim.Length > 19 Then
                                        strProd2 = Mid(strProd, 20, strProd.Length)
                                    Else
                                        strProd2 = ""
                                    End If

                                    For J = 0 To dblQtd - 1

                                        intCont += 1

                                        Select Case intCont

                                            Case 1

                                                strTexto = strTexto.Replace("1E2200800370009", "1E2200800370009C" & strCod)
                                                strTexto = strTexto.Replace("191100100250008", "191100100250008" & strProd1)
                                                strTexto = strTexto.Replace("191100100150008", "191100100150008" & strProd2)
                                                strTexto = strTexto.Replace("121100000030051", "121100000030051" & "R$ " & strPreco)

                                            Case 2
                                                strTexto = strTexto.Replace("1E2200800370131", "1E2200800370131C" & strCod)
                                                strTexto = strTexto.Replace("191100100250130", "191100100250130" & strProd1)
                                                strTexto = strTexto.Replace("191100100150130", "191100100150130" & strProd2)
                                                strTexto = strTexto.Replace("121100000030173", "121100000030173" & "R$ " & strPreco)
                                            Case 3
                                                strTexto = strTexto.Replace("1E2200800370253", "1E2200800370253C" & strCod)
                                                strTexto = strTexto.Replace("191100100250252", "191100100250252" & strProd1)
                                                strTexto = strTexto.Replace("191100100150252", "191100100150252" & strProd2)
                                                strTexto = strTexto.Replace("121100000030295", "121100000030295" & "R$ " & strPreco)
                                        End Select


                                        If intCont = 3 Then
                                            EscreveArquivo("C:\Etiqueta3.prn", strTexto)
                                            System.IO.File.Copy("C:\Etiqueta3.prn", PortaImpressoraCodigoBarra)
                                            System.IO.File.Delete("C:\Etiqueta3.prn")
                                            strTexto = LerArquivo("C:\TemplateMini.prn", True)
                                            intCont = 0
                                        End If

                                    Next

                                End If
                            Next

                            If intCont > 0 Then
                                EscreveArquivo("C:\Etiqueta3.prn", strTexto)
                                System.IO.File.Copy("C:\Etiqueta3.prn", PortaImpressoraCodigoBarra)
                                System.IO.File.Delete("C:\Etiqueta3.prn")
                            End If
                    End Select

                Case "SMART LABEL PRINTER 440"
                    Dim index As Integer = -999997
                    GridView1.FocusedRowHandle = index
                    GridView1.ShowEditor()

                    Dim rel As New relLabel

                    With rel.tbProd.Rows
                        For I = 0 To Me.GridView1.RowCount - 1
                            If Me.GridView1.GetRowCellValue(I, Me.colImprimir) = True Then
                                Dim dblQtd As Integer
                                If Me.GridView1.GetRowCellDisplayText(I, Me.colQtd).ToString.Trim <> "" Then
                                    dblQtd = Me.GridView1.GetRowCellDisplayText(I, Me.colQtd)
                                Else
                                    dblQtd = 0
                                End If
                                For J = 0 To dblQtd - 1
                                    If Me.GridView1.GetRowCellDisplayText(I, Me.colCodigoBarra) <> "" Then
                                        Dim intImagem As New PictureBox

                                        intImagem.Size = New System.Drawing.Size(200, 20)
                                        Dim intQtd As Integer = Me.GridView1.GetRowCellDisplayText(I, Me.colCodigoBarra).Length
                                        If intQtd > 10 Then
                                            intQtd = 200
                                        Else
                                            intQtd = 100
                                        End If

                                        Dim Barcode As New BarcodeLib.Barcode(Me.GridView1.GetRowCellDisplayText(I, Me.colCodigoBarra), BarcodeLib.TYPE.CODE128)
                                        intImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE128, Me.GridView1.GetRowCellDisplayText(I, Me.colCodigoBarra), intQtd, 19)
                                        intImagem.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
                                        Dim imagem As Byte() = converteimagem(intImagem.Image)

                                        .Add()
                                        .Item(.Count - 1).Item("Empresa") = NomeEmpresa
                                        .Item(.Count - 1).Item("Produto") = Me.GridView1.GetRowCellDisplayText(I, Me.colProduto)
                                        .Item(.Count - 1).Item("Locacao") = Me.GridView1.GetRowCellDisplayText(I, Me.colLocacao)
                                        .Item(.Count - 1).Item("Grupo") = Me.GridView1.GetRowCellDisplayText(I, Me.colGrupo)
                                        .Item(.Count - 1).Item("Setor") = Me.GridView1.GetRowCellDisplayText(I, Me.colSetor)
                                        .Item(.Count - 1).Item("CodigoInterno") = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd)
                                        .Item(.Count - 1).Item("CodigoBarra") = imagem
                                    End If
                                Next
                            End If
                        Next
                    End With
                    rel.ShowPreview()

                Case "IMPRESSORA NORMAL"

                    Select Case Me.Tag
                        Case "PIMACO A4348"

                            Dim index As Integer = -999997
                            GridView1.FocusedRowHandle = index
                            GridView1.ShowEditor()


                            Dim frm As New frmPmc1
                            frm.intIndexLinha = 0
                            frm.strColuna = 0
                            frm.ShowDialog()

                            Dim intPula As Integer

                            If frm.intIndexLinha <> 0 Then
                                intPula = ((frm.intIndexLinha - 1) * 6) + Val(frm.strColuna) - 1
                            End If


                            Dim rel As New relPimacoBijuterias

                            With rel.tbProd.Rows
                                For I = 0 To Me.GridView1.RowCount - 1

                                    If Me.GridView1.GetRowCellValue(I, Me.colImprimir) = True Then
                                        Dim dblQtd As Integer
                                        If Me.GridView1.GetRowCellDisplayText(I, Me.colQtd).ToString.Trim <> "" Then
                                            dblQtd = Me.GridView1.GetRowCellDisplayText(I, Me.colQtd)
                                        Else
                                            dblQtd = 0
                                        End If


                                        dblQtd = dblQtd + intPula

                                        Dim strTam As String = ""
                                        If Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho) <> "" Then
                                            strTam = "-" & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho)
                                        End If
                                       

                                        For J = 0 To dblQtd - 1
                                            If Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) <> "" Then

                                                .Add()

                                                If J >= intPula Then

                                                    intPula = 0

                                                    Dim imgImagem As New PictureBox
                                                    imgImagem.Size = New System.Drawing.Size(200, 20)
                                                    Dim imagem As Byte()

                                                    Dim strCod As String = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).ToString & strTam
                                                    If strCod.Contains(".") Or strCod.Contains("-") Or strCod.Length >= 7 Then
                                                        Dim intQtd As Integer = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).Length
                                                        If intQtd > 10 Then
                                                            intQtd = 200
                                                        ElseIf intQtd >= 8 And intQtd <= 10 Then
                                                            intQtd = 170
                                                        Else
                                                            intQtd = 140
                                                        End If

                                                        Dim Barcode As New BarcodeLib.Barcode(Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & strTam, BarcodeLib.TYPE.CODE93)
                                                        imgImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE93, Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & strTam, intQtd, 19)
                                                        imagem = converteimagem(imgImagem.Image)

                                                    Else
                                                        Dim intQtd As Integer = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).Length
                                                        If intQtd > 10 Then
                                                            intQtd = 200
                                                        ElseIf intQtd >= 8 And intQtd <= 10 Then
                                                            intQtd = 140
                                                        Else
                                                            intQtd = 100
                                                        End If

                                                        Dim Barcode As New BarcodeLib.Barcode(Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & strTam, BarcodeLib.TYPE.CODE128)
                                                        imgImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE128, Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & strTam, intQtd, 19)
                                                        imagem = converteimagem(imgImagem.Image)

                                                    End If


                                                    Dim strProd As String = Me.GridView1.GetRowCellDisplayText(I, Me.colProduto)
                                                    If strProd.Length > 40 Then
                                                        strProd = Mid(strProd, 1, 40)
                                                    End If

                                                    'If strProd.Length < 10 Then
                                                    '    strProd = strProd & "                                                 ."
                                                    'ElseIf strProd.Length <= 20 Then
                                                    '    strProd = strProd & "                        ."
                                                    'End If

                                                    Dim dblVal As Double = Me.GridView1.GetRowCellDisplayText(I, Me.colValor)

                                                    .Item(.Count - 1).Item("Produto") = strProd & strTam
                                                    .Item(.Count - 1).Item("Valor") = "R$" & dblVal.ToString("0.00")
                                                    .Item(.Count - 1).Item("CodigoBarra") = imagem
                                                    .Item(.Count - 1).Item("CodigoInterno") = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & strTam
                                                Else
                                                    .Item(.Count - 1).Item("Valor") = " "
                                                    .Item(.Count - 1).Item("Produto") = "                                                                        "
                                                    .Item(.Count - 1).Item("CodigoInterno") = " "
                                                    'Dim imagem1 As Byte()
                                                    'imagem1 = converteimagem(Global.Nano.My.Resources.Resources.Filter)
                                                    '.Item(.Count - 1).Item("CodigoBarra") = imagem1
                                                End If

                                            End If
                                        Next
                                    End If
                                Next
                            End With

                            If NomeEmpresa.ToUpper.Contains("CAIROFRIO") = True Then
                                rel.XrLabel2.Visible = False
                            End If
                        
                            If NomeEmpresa.ToUpper.Contains("MIX") = True Then
                                rel.XrLabel2.Visible = False
                            End If

                           
                            rel.ShowPreview()

                        Case "PIMACO A4360"

                            Dim index As Integer = -999997
                            GridView1.FocusedRowHandle = index
                            GridView1.ShowEditor()


                            Dim frm As New frmPmc2
                            frm.intIndexLinha = 0
                            frm.strColuna = 0
                            frm.ShowDialog()

                            Dim intPula As Integer

                            If frm.intIndexLinha <> 0 Then
                                intPula = ((frm.intIndexLinha - 1) * 3) + Val(frm.strColuna) - 1
                            End If


                            Dim rel As New relPimacoRoupas

                            With rel.tbProd.Rows
                                For I = 0 To Me.GridView1.RowCount - 1

                                    If Me.GridView1.GetRowCellValue(I, Me.colImprimir) = True Then
                                        Dim dblQtd As Integer
                                        If Me.GridView1.GetRowCellDisplayText(I, Me.colQtd).ToString.Trim <> "" Then
                                            dblQtd = Me.GridView1.GetRowCellDisplayText(I, Me.colQtd)
                                        Else
                                            dblQtd = 0
                                        End If

                                        dblQtd = dblQtd + intPula

                                        Dim strTam As String
                                        strTam = Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho)

                                        For J = 0 To dblQtd - 1
                                            If Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) <> "" Then

                                                .Add()

                                                If J >= intPula Then

                                                    intPula = 0

                                                    Dim imgImagem As New PictureBox

                                                    imgImagem.Size = New System.Drawing.Size(300, 30)
                                                    Dim intQtd As Integer = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).Length
                                                    If intQtd > 10 Then
                                                        intQtd = 200
                                                    ElseIf intQtd >= 8 And intQtd <= 10 Then
                                                        intQtd = 170
                                                    Else
                                                        intQtd = 140
                                                    End If

                                                    Dim Barcode As New BarcodeLib.Barcode(Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & "-" & strTam, BarcodeLib.TYPE.CODE128)
                                                    imgImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE128, Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & "-" & strTam, 200, 29)

                                                    Dim imagem As Byte() = converteimagem(imgImagem.Image)



                                                    Dim strProd As String

                                                    strProd = Me.GridView1.GetRowCellDisplayText(I, Me.colProduto)

                                                    If strProd.Length > 60 Then
                                                        strProd = Mid(strProd, 1, 60)
                                                    End If

                                                    'If strProd.Length < 12 Then
                                                    '    strProd = strProd & "                                                            ."
                                                    'ElseIf strProd.Length <= 40 Then
                                                    '    strProd = strProd & "                                             ."
                                                    'End If

                                                    Dim dblVal As Double = Me.GridView1.GetRowCellDisplayText(I, Me.colValor)

                                                    .Item(.Count - 1).Item("NomeLoja") = NomeEmpresa
                                                    .Item(.Count - 1).Item("Produto") = strProd
                                                    .Item(.Count - 1).Item("Valor") = "R$" & dblVal.ToString("0.00")
                                                    .Item(.Count - 1).Item("CodigoBarra") = imagem
                                                    .Item(.Count - 1).Item("Tamanho") = "TAM: " & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho)
                                                    .Item(.Count - 1).Item("CodigoInterno") = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & "-" & strTam
                                                Else

                                                    .Item(.Count - 1).Item("Produto") = "                                                                                           "
                                                    .Item(.Count - 1).Item("CodigoInterno") = " "
                                                End If

                                            End If
                                        Next
                                    End If
                                Next
                            End With

                            If NomeEmpresa.ToUpper.Contains("CAIROFRIO") = True Then
                                rel.XrLabel4.Visible = False
                            End If
                            If NomeEmpresa.ToUpper.Contains("MIX") = True Then
                                rel.XrLabel4.Visible = False
                            End If

                            rel.ShowPreview()

                        Case "PIMACO A5Q1219"

                            Dim index As Integer = -999997
                            GridView1.FocusedRowHandle = index
                            GridView1.ShowEditor()


                            Dim frm As New frmPmc3
                            frm.intIndexLinha = 0
                            frm.strColuna = 0
                            frm.ShowDialog()

                            Dim intPula As Integer

                            If frm.intIndexLinha <> 0 Then
                                intPula = ((frm.intIndexLinha - 1) * 11) + Val(frm.strColuna) - 1
                            End If

                            If CNPJEmpresa = "42690914875" Then
                                Dim rel As New relPimacoBijuterias3


                                With rel.tbProd.Rows
                                    For I = 0 To Me.GridView1.RowCount - 1

                                        If Me.GridView1.GetRowCellValue(I, Me.colImprimir) = True Then
                                            Dim dblQtd As Integer
                                            If Me.GridView1.GetRowCellDisplayText(I, Me.colQtd).ToString.Trim <> "" Then
                                                dblQtd = Me.GridView1.GetRowCellDisplayText(I, Me.colQtd)
                                            Else
                                                dblQtd = 0
                                            End If


                                            dblQtd = dblQtd + intPula


                                            For J = 0 To dblQtd - 1
                                                If Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) <> "" Then

                                                    .Add()

                                                    If J >= intPula Then

                                                        intPula = 0

                                                        Dim imgImagem As New PictureBox
                                                        imgImagem.Size = New System.Drawing.Size(200, 20)
                                                        Dim imagem As Byte()

                                                        Dim strCod As String = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).ToString
                                                        If strCod.Contains(".") Or strCod.Contains("-") Or strCod.Length >= 7 Then
                                                            Dim intQtd As Integer = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).Length
                                                            If intQtd > 10 Then
                                                                intQtd = 200
                                                            ElseIf intQtd >= 8 And intQtd <= 10 Then
                                                                intQtd = 170
                                                            Else
                                                                intQtd = 140
                                                            End If

                                                            Dim Barcode As New BarcodeLib.Barcode(Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd), BarcodeLib.TYPE.CODE93)
                                                            imgImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE93, Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd), intQtd, 19)
                                                            imgImagem.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
                                                            imagem = converteimagem(imgImagem.Image)

                                                        Else
                                                            Dim intQtd As Integer = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).Length
                                                            If intQtd > 10 Then
                                                                intQtd = 200
                                                            ElseIf intQtd >= 8 And intQtd <= 10 Then
                                                                intQtd = 140
                                                            Else
                                                                intQtd = 100
                                                            End If

                                                            Dim Barcode As New BarcodeLib.Barcode(Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd), BarcodeLib.TYPE.CODE128)
                                                            imgImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE128, Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd), intQtd, 19)
                                                            imgImagem.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
                                                            imagem = converteimagem(imgImagem.Image)

                                                        End If


                                                        Dim strProd As String = Me.GridView1.GetRowCellDisplayText(I, Me.colProduto)
                                                        If strProd.Length > 40 Then
                                                            strProd = Mid(strProd, 1, 40)
                                                        End If

                                                        With rel
                                                            .Margins.Top = 51
                                                            .Margins.Bottom = 45
                                                            .Margins.Left = 51
                                                            .Margins.Right = 10
                                                        End With

                                                        Dim dblVal As Double = Me.GridView1.GetRowCellDisplayText(I, Me.colValor)

                                                        '.Item(.Count - 1).Item("Produto") = strProd
                                                        .Item(.Count - 1).Item("Valor") = "R$ " & dblVal.ToString("0.00")
                                                        .Item(.Count - 1).Item("CodigoBarra") = imagem
                                                        .Item(.Count - 1).Item("CodigoInterno") = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd)
                                                    Else
                                                        .Item(.Count - 1).Item("Produto") = "                                                                        "
                                                        .Item(.Count - 1).Item("CodigoInterno") = " "
                                                    End If
                                                End If
                                            Next
                                        End If
                                    Next
                                End With
                                rel.ShowPreview()
                            Else
                                Dim rel As New relPimacoBijuterias2


                                With rel.tbProd.Rows
                                    For I = 0 To Me.GridView1.RowCount - 1

                                        If Me.GridView1.GetRowCellValue(I, Me.colImprimir) = True Then
                                            Dim dblQtd As Integer
                                            If Me.GridView1.GetRowCellDisplayText(I, Me.colQtd).ToString.Trim <> "" Then
                                                dblQtd = Me.GridView1.GetRowCellDisplayText(I, Me.colQtd)
                                            Else
                                                dblQtd = 0
                                            End If


                                            dblQtd = dblQtd + intPula


                                            For J = 0 To dblQtd - 1
                                                If Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) <> "" Then

                                                    .Add()

                                                    If J >= intPula Then

                                                        intPula = 0

                                                        Dim imgImagem As New PictureBox
                                                        imgImagem.Size = New System.Drawing.Size(200, 20)
                                                        Dim imagem As Byte()

                                                        Dim strCod As String = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).ToString
                                                        If strCod.Contains(".") Or strCod.Contains("-") Or strCod.Length >= 7 Then
                                                            Dim intQtd As Integer = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).Length
                                                            If intQtd > 10 Then
                                                                intQtd = 200
                                                            ElseIf intQtd >= 8 And intQtd <= 10 Then
                                                                intQtd = 170
                                                            Else
                                                                intQtd = 140
                                                            End If

                                                            Dim Barcode As New BarcodeLib.Barcode(Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd), BarcodeLib.TYPE.CODE93)
                                                            imgImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE93, Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd), intQtd, 19)
                                                            imgImagem.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
                                                            imagem = converteimagem(imgImagem.Image)

                                                        Else
                                                            Dim intQtd As Integer = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).Length
                                                            If intQtd > 10 Then
                                                                intQtd = 200
                                                            ElseIf intQtd >= 8 And intQtd <= 10 Then
                                                                intQtd = 140
                                                            Else
                                                                intQtd = 100
                                                            End If

                                                            Dim Barcode As New BarcodeLib.Barcode(Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd), BarcodeLib.TYPE.CODE128)
                                                            imgImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE128, Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd), intQtd, 19)
                                                            imgImagem.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
                                                            imagem = converteimagem(imgImagem.Image)

                                                        End If


                                                        Dim strProd As String = Me.GridView1.GetRowCellDisplayText(I, Me.colProduto)
                                                        If strProd.Length > 40 Then
                                                            strProd = Mid(strProd, 1, 40)
                                                        End If


                                                        Dim dblVal As Double = Me.GridView1.GetRowCellDisplayText(I, Me.colValor)

                                                        '.Item(.Count - 1).Item("Produto") = strProd
                                                        .Item(.Count - 1).Item("Valor") = "R$ " & dblVal.ToString("0.00")
                                                        .Item(.Count - 1).Item("CodigoBarra") = imagem
                                                        '.Item(.Count - 1).Item("CodigoInterno") = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd)
                                                    Else
                                                        .Item(.Count - 1).Item("Produto") = "                                                                        "
                                                        .Item(.Count - 1).Item("CodigoInterno") = " "
                                                    End If
                                                End If
                                            Next
                                        End If
                                    Next
                                End With
                                rel.ShowPreview()
                            End If
                            

                        Case "ETIQUETA CAIXA"
                            Dim index As Integer = -999997
                            GridView1.FocusedRowHandle = index
                            GridView1.ShowEditor()

                            Dim rel As New relEtiquetaCaixa

                            With rel.tbProd.Rows
                                For I = 0 To Me.GridView1.RowCount - 1
                                    If Me.GridView1.GetRowCellValue(I, Me.colImprimir) = True Then
                                        Dim dblQtd As Integer
                                        If Me.GridView1.GetRowCellDisplayText(I, Me.colQtd).ToString.Trim <> "" Then
                                            dblQtd = Me.GridView1.GetRowCellDisplayText(I, Me.colQtd)
                                        Else
                                            dblQtd = 0
                                        End If

                                        For J = 0 To dblQtd - 1

                                            Dim CodigoInterno As String = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd)
                                            .Add()
                                            .Item(.Count - 1).Item("CodigoInterno") = "Cód. - " & CodigoInterno
                                            .Item(.Count - 1).Item("CodigoBarra") = "Ref. - " & Me.GridView1.GetRowCellDisplayText(I, Me.colCodigoBarra)
                                            .Item(.Count - 1).Item("Descricao") = Me.GridView1.GetRowCellDisplayText(I, Me.colProduto)

                                            Dim dt As DataTable = CarregarDataTable("Select Setor, Obs as Aplicacao From Produto Where CodigoInterno='" & CodigoInterno & "'")
                                            If dt.Rows.Count > 0 Then
                                                Dim strAplic, strFab As String
                                                strAplic = dt.Rows.Item(0).Item("Aplicacao").ToString().Trim
                                                strFab = "Fab. - " & dt.Rows.Item(0).Item("Setor").ToString().Trim

                                                .Item(.Count - 1).Item("Aplicacao") = strAplic
                                                .Item(.Count - 1).Item("Fabricante") = strFab
                                            End If

                                        Next
                                    End If
                                Next
                            End With
                            rel.ShowPreview()



                        Case "PROMOÇÃO"

                            Dim index As Integer = -999997
                            GridView1.FocusedRowHandle = index
                            GridView1.ShowEditor()


                            Dim frm As New frmPmc2
                            frm.intIndexLinha = 0
                            frm.strColuna = 0
                            frm.ShowDialog()

                            Dim intPula As Integer

                            If frm.intIndexLinha <> 0 Then
                                intPula = ((frm.intIndexLinha - 1) * 3) + Val(frm.strColuna) - 1
                            End If


                            Dim rel As New relNormal

                            With rel.tbProd.Rows
                                For I = 0 To Me.GridView1.RowCount - 1

                                    If Me.GridView1.GetRowCellValue(I, Me.colImprimir) = True Then
                                        Dim dblQtd As Integer
                                        If Me.GridView1.GetRowCellDisplayText(I, Me.colQtd).ToString.Trim <> "" Then
                                            dblQtd = Me.GridView1.GetRowCellDisplayText(I, Me.colQtd)
                                        Else
                                            dblQtd = 0
                                        End If

                                        dblQtd = dblQtd + intPula

                                        For J = 0 To dblQtd - 1
                                            If Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) <> "" Then

                                                .Add()

                                                If J >= intPula Then

                                                    intPula = 0

                                                    Dim strProd As String

                                                    strProd = Me.GridView1.GetRowCellDisplayText(I, Me.colProduto)

                                                    If strProd.Length > 60 Then
                                                        strProd = Mid(strProd, 1, 60)
                                                    End If

                                                    Dim dblVal As Double = Me.GridView1.GetRowCellDisplayText(I, Me.colValor)
                                                    Dim dblPromo As Double = dblVal
                                                    If Me.GridView1.GetRowCellDisplayText(I, Me.colValPromocao) <> "" Then
                                                        dblPromo = Me.GridView1.GetRowCellDisplayText(I, Me.colValPromocao)
                                                    End If

                                                    .Item(.Count - 1).Item("NomeLoja") = "CARISMA COSMETICOS"
                                                    .Item(.Count - 1).Item("Produto") = strProd
                                                    .Item(.Count - 1).Item("Valor") = "De: R$" & dblVal.ToString("0.00")
                                                    .Item(.Count - 1).Item("ValPromocao") = "PAGUE: R$" & dblPromo.ToString("0.00")

                                                End If
                                            End If
                                        Next
                                    End If
                                Next
                            End With

                            rel.ShowPreview()
                    End Select

                Case "BEMA LB-1000"

                    Select Case Me.Tag
                        Case "LB 1000 DUPLA"

                            Dim index As Integer = -999997
                            GridView1.FocusedRowHandle = index
                            GridView1.ShowEditor()

                            Dim rel As New relLB1000Dupla

                            With rel.tbProd.Rows
                                For I = 0 To Me.GridView1.RowCount - 1
                                    If Me.GridView1.GetRowCellValue(I, Me.colImprimir) = True Then
                                        Dim dblQtd As Integer
                                        If Me.GridView1.GetRowCellDisplayText(I, Me.colQtd).ToString.Trim <> "" Then
                                            dblQtd = Me.GridView1.GetRowCellDisplayText(I, Me.colQtd)
                                        Else
                                            dblQtd = 0
                                        End If
                                        For J = 0 To dblQtd - 1
                                            If Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) <> "" Then
                                                Dim imgImagem As New PictureBox

                                                imgImagem.Size = New System.Drawing.Size(300, 30)
                                                Dim intQtd As Integer = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).Length
                                                If intQtd > 10 Then
                                                    intQtd = 220
                                                ElseIf intQtd >= 8 And intQtd <= 10 Then
                                                    intQtd = 190
                                                Else
                                                    intQtd = 170
                                                End If

                                                Dim Barcode As New BarcodeLib.Barcode(Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & "-" & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString, BarcodeLib.TYPE.CODE128)
                                                imgImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE128, Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & "-" & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString, intQtd, 19)
                                                Dim imagem As Byte() = converteimagem(imgImagem.Image)

                                                .Add()
                                                .Item(.Count - 1).Item("Empresa") = NomeEmpresa
                                                .Item(.Count - 1).Item("Produto") = Me.GridView1.GetRowCellDisplayText(I, Me.colProduto)

                                                If NomeEmpresa.Contains("AUTO PARTES ORIGINAL") Then
                                                    .Item(.Count - 1).Item("Valor") = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & "-" & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString
                                                    .Item(.Count - 1).Item("CodigoInterno") = ""
                                                Else
                                                    Dim dblValor As Double = Me.GridView1.GetRowCellDisplayText(I, Me.colValor)
                                                    .Item(.Count - 1).Item("Valor") = "R$" & dblValor.ToString("0.00")
                                                    .Item(.Count - 1).Item("CodigoInterno") = "COD." & Space(3) & Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & "-" & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString
                                                End If
                                               

                                                Dim strVal As String = Me.GridView1.GetRowCellDisplayText(I, Me.colValidade)
                                                Dim Data() As String = strVal.Split(" ")
                                                strVal = Data(0)

                                                Dim strFab As String = Me.GridView1.GetRowCellDisplayText(I, Me.colFabricacao)
                                                Dim Validade As String = "Fab." & strFab & " Val." & strVal

                                                If strVal <> "01/01/2050" And strVal <> "" Then
                                                    .Item(.Count - 1).Item("Validade") = Validade
                                                End If

                                                .Item(.Count - 1).Item("CodigoBarra") = imagem

                                            End If
                                        Next
                                    End If
                                Next
                            End With
                            rel.ShowPreview()

                        Case "LB 1000 TRIPLA"

                            If NomeEmpresa.ToUpper.Contains("AGRO RURAL SOCORRO") = True Then
                                Dim index As Integer = -999997
                                GridView1.FocusedRowHandle = index
                                GridView1.ShowEditor()

                                Dim rel As New relElginL42Tripla

                                With rel.tbProd.Rows
                                    For I = 0 To Me.GridView1.RowCount - 1
                                        If Me.GridView1.GetRowCellValue(I, Me.colImprimir) = True Then
                                            Dim dblQtd As Integer
                                            If Me.GridView1.GetRowCellDisplayText(I, Me.colQtd).ToString.Trim <> "" Then
                                                dblQtd = Me.GridView1.GetRowCellDisplayText(I, Me.colQtd)
                                            Else
                                                dblQtd = 0
                                            End If
                                            For J = 0 To dblQtd - 1
                                                If Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) <> "" Then
                                                    Dim imgImagem As New PictureBox

                                                    imgImagem.Size = New System.Drawing.Size(300, 30)
                                                    Dim intQtd As Integer
                                                    Dim intLens As Integer = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).Length
                                                    If intLens > 7 Then
                                                        intQtd = 160
                                                    ElseIf intLens >= 6 And intLens <= 7 Then
                                                        intQtd = 140
                                                    Else
                                                        intQtd = 120
                                                    End If

                                                    Dim imagem As Byte() = Nothing
                                                    If intLens >= 7 Then
                                                        Dim Barcode As New BarcodeLib.Barcode(Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd), BarcodeLib.TYPE.CODE93)
                                                        imgImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE93, Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd), intQtd, 19)
                                                        imagem = converteimagem(imgImagem.Image)
                                                    Else
                                                        Dim Barcode As New BarcodeLib.Barcode(Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & "-" & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString, BarcodeLib.TYPE.CODE128)
                                                        imgImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE128, Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & "-" & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString, intQtd, 19)
                                                        imagem = converteimagem(imgImagem.Image)
                                                    End If

                                                    .Add()
                                                    .Item(.Count - 1).Item("Empresa") = NomeEmpresa
                                                    .Item(.Count - 1).Item("Produto") = Me.GridView1.GetRowCellDisplayText(I, Me.colProduto)

                                                    Dim dblValor As Double = Me.GridView1.GetRowCellDisplayText(I, Me.colValor)
                                                    .Item(.Count - 1).Item("Valor") = "R$" & dblValor.ToString("0.00")

                                                    If Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString <> "" Then
                                                        .Item(.Count - 1).Item("CodigoInterno") = "Cód:" & Space(3) & Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & "-" & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString
                                                    Else
                                                        .Item(.Count - 1).Item("CodigoInterno") = "Cód:" & Space(3) & Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd)
                                                    End If

                                                    .Item(.Count - 1).Item("CodigoBarra") = imagem

                                                End If
                                            Next
                                        End If
                                    Next
                                End With
                                rel.ShowPreview()

                            Else
                                Dim index As Integer = -999997
                                GridView1.FocusedRowHandle = index
                                GridView1.ShowEditor()

                                Dim rel As New relLB1000Tripla

                                With rel.tbProd.Rows
                                    For I = 0 To Me.GridView1.RowCount - 1
                                        If Me.GridView1.GetRowCellValue(I, Me.colImprimir) = True Then
                                            Dim dblQtd As Integer
                                            If Me.GridView1.GetRowCellDisplayText(I, Me.colQtd).ToString.Trim <> "" Then
                                                dblQtd = Me.GridView1.GetRowCellDisplayText(I, Me.colQtd)
                                            Else
                                                dblQtd = 0
                                            End If
                                            For J = 0 To dblQtd - 1
                                                If Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) <> "" Then
                                                    Dim imgImagem As New PictureBox

                                                    imgImagem.Size = New System.Drawing.Size(300, 30)
                                                    Dim intQtd As Integer
                                                    Dim intLens As Integer = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).Length
                                                    If intLens > 7 Then
                                                        intQtd = 160
                                                    ElseIf intLens >= 6 And intLens <= 7 Then
                                                        intQtd = 140
                                                    Else
                                                        intQtd = 120
                                                    End If

                                                    Dim imagem As Byte() = Nothing
                                                    If intLens >= 7 Then
                                                        Dim Barcode As New BarcodeLib.Barcode(Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd), BarcodeLib.TYPE.CODE93)
                                                        imgImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE93, Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd), intQtd, 19)
                                                        imagem = converteimagem(imgImagem.Image)
                                                    Else
                                                        Dim Barcode As New BarcodeLib.Barcode(Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & "-" & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString, BarcodeLib.TYPE.CODE128)
                                                        imgImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE128, Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & "-" & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString, intQtd, 19)
                                                        imagem = converteimagem(imgImagem.Image)
                                                    End If

                                                    .Add()
                                                    .Item(.Count - 1).Item("Empresa") = NomeEmpresa
                                                    .Item(.Count - 1).Item("Produto") = Me.GridView1.GetRowCellDisplayText(I, Me.colProduto)

                                                    If NomeEmpresa.Contains("AUTO PARTES ORIGINAL") = True Then
                                                        .Item(.Count - 1).Item("Valor") = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & "-" & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString
                                                        .Item(.Count - 1).Item("CodigoInterno") = ""
                                                    Else
                                                        Dim dblValor As Double = Me.GridView1.GetRowCellDisplayText(I, Me.colValor)
                                                        .Item(.Count - 1).Item("Valor") = "R$" & dblValor.ToString("0.00")
                                                        .Item(.Count - 1).Item("CodigoInterno") = "COD." & Space(3) & Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & "-" & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString
                                                    End If


                                                    Dim strVal As String = Me.GridView1.GetRowCellDisplayText(I, Me.colValidade)
                                                    Dim Data() As String = strVal.Split(" ")
                                                    strVal = Data(0)

                                                    Dim strFab As String = Me.GridView1.GetRowCellDisplayText(I, Me.colFabricacao)
                                                    Dim Validade As String = "Fab." & strFab & " Val." & strVal

                                                    If strVal <> "01/01/2050" And strVal <> "" Then
                                                        .Item(.Count - 1).Item("Validade") = Validade
                                                    End If

                                                    .Item(.Count - 1).Item("CodigoBarra") = imagem

                                                End If
                                            Next
                                        End If
                                    Next
                                End With
                                rel.ShowPreview()

                            End If

                        Case "LB 1000 PEQUENA"

                            Dim index As Integer = -999997
                            GridView1.FocusedRowHandle = index
                            GridView1.ShowEditor()

                            Dim rel As New relLB1000Pequena

                            With rel.tbProd.Rows
                                For I = 0 To Me.GridView1.RowCount - 1
                                    If Me.GridView1.GetRowCellValue(I, Me.colImprimir) = True Then
                                        Dim dblQtd As Integer
                                        If Me.GridView1.GetRowCellDisplayText(I, Me.colQtd).ToString.Trim <> "" Then
                                            dblQtd = Me.GridView1.GetRowCellDisplayText(I, Me.colQtd)
                                        Else
                                            dblQtd = 0
                                        End If
                                        For J = 0 To dblQtd - 1
                                            If Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) <> "" Then
                                                Dim imgImagem As New PictureBox

                                                imgImagem.Size = New System.Drawing.Size(300, 30)
                                                Dim intQtd As Integer
                                                Dim intLens As Integer = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).Length
                                                If intLens > 7 Then
                                                    intQtd = 160
                                                ElseIf intLens >= 6 And intLens <= 7 Then
                                                    intQtd = 140
                                                Else
                                                    intQtd = 120
                                                End If

                                                Dim imagem As Byte() = Nothing
                                                If intLens >= 7 Then
                                                    Dim Barcode As New BarcodeLib.Barcode(Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd), BarcodeLib.TYPE.CODE93)
                                                    imgImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE93, Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd), intQtd, 19)
                                                    imagem = converteimagem(imgImagem.Image)
                                                Else
                                                    Dim Barcode As New BarcodeLib.Barcode(Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & "-" & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString, BarcodeLib.TYPE.CODE128)
                                                    imgImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE128, Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & "-" & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString, intQtd, 19)
                                                    imagem = converteimagem(imgImagem.Image)
                                                End If

                                                .Add()
                                                '.Item(.Count - 1).Item("Empresa") = NomeEmpresa
                                                .Item(.Count - 1).Item("Produto") = Me.GridView1.GetRowCellDisplayText(I, Me.colProduto)

                                                Dim dblValor As Double = Me.GridView1.GetRowCellDisplayText(I, Me.colValor)
                                                .Item(.Count - 1).Item("Valor") = "R$" & dblValor.ToString("0.00")

                                                If Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString <> "" Then
                                                    .Item(.Count - 1).Item("CodigoInterno") = "Cód:" & Space(3) & Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) & "-" & Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho).ToString
                                                Else
                                                    .Item(.Count - 1).Item("CodigoInterno") = "Cód:" & Space(3) & Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd)
                                                End If

                                                .Item(.Count - 1).Item("CodigoBarra") = imagem

                                            End If
                                        Next
                                    End If
                                Next
                            End With
                            rel.ShowPreview()

                        Case "LB 1000 GÔNDOLA"

                            Dim index As Integer = -999997
                            GridView1.FocusedRowHandle = index
                            GridView1.ShowEditor()

                            Dim rel As New relLB1000Grande

                            With rel.tbProd.Rows
                                For I = 0 To Me.GridView1.RowCount - 1
                                    If Me.GridView1.GetRowCellValue(I, Me.colImprimir) = True Then
                                        Dim dblQtd As Integer
                                        If Me.GridView1.GetRowCellDisplayText(I, Me.colQtd).ToString.Trim <> "" Then
                                            dblQtd = Me.GridView1.GetRowCellDisplayText(I, Me.colQtd)
                                        Else
                                            dblQtd = 0
                                        End If
                                        For J = 0 To dblQtd - 1
                                            If Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd) <> "" Then
                                                Dim intImagem As New PictureBox

                                                intImagem.Size = New System.Drawing.Size(300, 50)
                                                Dim intQtd As Integer = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd).Length
                                                If intQtd > 10 Then
                                                    intQtd = 200
                                                ElseIf intQtd >= 8 And intQtd <= 10 Then
                                                    intQtd = 150
                                                Else
                                                    intQtd = 120
                                                End If

                                                Dim Barcode As New BarcodeLib.Barcode(Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd), BarcodeLib.TYPE.CODE128)
                                                intImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE128, Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd), intQtd, 19)
                                                Dim imagem As Byte() = converteimagem(intImagem.Image)

                                                .Add()
                                                .Item(.Count - 1).Item("Produto") = Me.GridView1.GetRowCellDisplayText(I, Me.colProduto)
                                                .Item(.Count - 1).Item("Locacao") = Me.GridView1.GetRowCellDisplayText(I, Me.colLocacao)

                                                Dim dblValor As Double = Me.GridView1.GetRowCellDisplayText(I, Me.colValor)
                                                .Item(.Count - 1).Item("Valor") = dblValor.ToString("0.00")

                                                .Item(.Count - 1).Item("Unidademedida") = Me.GridView1.GetRowCellDisplayText(I, Me.colUnidadeMedida)
                                                .Item(.Count - 1).Item("CodigoInterno") = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProd)
                                                .Item(.Count - 1).Item("CodigoBarra") = imagem
                                            End If
                                        Next
                                    End If
                                Next
                            End With

                            rel.ShowPreview()
                    End Select
            End Select
        End If
     
    End Sub
    Public Function converteimagem(ByVal Imagem As System.Drawing.Image) As Byte()

        'Declare uma variável do Tipo MemoryStream

        Dim ms As New System.IO.MemoryStream()

        'Carrega o memory Stream

        Imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

        'retorna um array de bytes

        Return ms.ToArray()

    End Function
    Private Sub txtQtd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQtd.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub
End Class