Imports Nano.clsFuncoes
Public Class frmPedido1
    Dim strBotao As String

    Private Sub frmPedido1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.picLogo.Image = LogoTipo
        Localizacao(Me.btnLanches, False, 46)

        Calcular()

    End Sub
    Private Sub Localizacao(ByVal parBotao As Object, ByVal parOk As Boolean, ByVal parLoc As Integer)
        Me.btnLanches.Location = New System.Drawing.Point(7, 46)
        Me.btnBebidas.Location = New System.Drawing.Point(7, 138)
        Me.btnSaladas.Location = New System.Drawing.Point(7, 228)
        Me.btnSobremesa.Location = New System.Drawing.Point(7, 316)

        If parOk = True Then
            parBotao.Location = New System.Drawing.Point(38, parLoc)
        End If

        Me.btnAgua.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.grpSabor.Visible = False
    End Sub

    Private Sub btnLanches_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLanches.Click
        LimparValores()
        Localizacao(Me.btnLanches, True, 46)

        Me.grpRecheio.Text = "RECHEIO"

        Me.tbProduto.Rows.Clear()

        With Me.tbProduto.Rows
            Dim I As Integer
            For I = 0 To 1
                .Add()
                .Item(I).Item("Ok") = False
            Next
            .Item(0).Item("Produto") = "Pão Sirio"
            .Item(1).Item("Produto") = "Integral"

        End With

        strBotao = "LANCHES"
        Me.grd3.FormatConditions.Item(0).Value1 = True

        AddLanche()
    End Sub

    Private Sub AddLanche()

        Me.grpSabor.Visible = False
        Me.grpRecheio.Visible = True
        Me.tbRecheio.Rows.Clear()
        Me.tbProd.Rows.Clear()
        Dim I As Integer
        For I = 0 To 8
            Me.tbRecheio.Rows.Add()
            Me.tbRecheio.Rows.Item(I).Item("Ok") = False
        Next

        Me.tbRecheio.Rows.Item(0).Item("Produto") = "Beringela"
        Me.tbRecheio.Rows.Item(1).Item("Produto") = "Mussarela"
        Me.tbRecheio.Rows.Item(2).Item("Produto") = "Queijo Branco"
        Me.tbRecheio.Rows.Item(3).Item("Produto") = "Patê Atum"
        Me.tbRecheio.Rows.Item(4).Item("Produto") = "Patê Frango"
        Me.tbRecheio.Rows.Item(5).Item("Produto") = "Patê Tomate Seco"
        Me.tbRecheio.Rows.Item(6).Item("Produto") = "Peito de Peru"
        Me.tbRecheio.Rows.Item(7).Item("Produto") = "Presunto"
        Me.tbRecheio.Rows.Item(8).Item("Produto") = "Patê de Ervas"

        For I = 0 To 9
            Me.tbProd.Rows.Add()
            Me.tbProd.Rows.Item(I).Item("Ok") = False
        Next

        Me.tbProd.Rows.Item(0).Item("Produto") = "Alface"
        Me.tbProd.Rows.Item(1).Item("Produto") = "Azeite"
        Me.tbProd.Rows.Item(2).Item("Produto") = "Beterraba"
        Me.tbProd.Rows.Item(3).Item("Produto") = "Batata Palha"
        Me.tbProd.Rows.Item(4).Item("Produto") = "Cenoura"
        Me.tbProd.Rows.Item(5).Item("Produto") = "Pepino Japonês"
        Me.tbProd.Rows.Item(6).Item("Produto") = "Tomate"
        Me.tbProd.Rows.Item(7).Item("Produto") = "Rúcula"
        Me.tbProd.Rows.Item(8).Item("Produto") = "Orégano"
        Me.tbProd.Rows.Item(9).Item("Produto") = "Milho"




        Dim dt As DataTable = CarregarDataTable("SELECT Convert(Numeric(15,2),Valor) as Valor FROM Produto where Setor = '" & strBotao & "'")

        If dt.Rows.Count > 0 Then
            Me.txtValor.Text = dt.Rows.Item(0).Item("Valor").ToString
        End If
        Calcular()
    End Sub

    Private Sub btnSaladas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaladas.Click
        LimparValores()
        Localizacao(Me.btnSaladas, True, 228)

        Me.tbProduto.Rows.Clear()
        With Me.tbProduto.Rows
            Dim I As Integer
            For I = 0 To 1
                .Add()
                .Item(I).Item("Ok") = False
            Next
            ' .Item(0).Item("Produto") = "Exótica"
            .Item(0).Item("Produto") = "Mais Sabor"
            .Item(1).Item("Produto") = "Tropical"
        End With


        strBotao = "SALADAS"

        Me.grd3.FormatConditions.Item(0).Value1 = False

        AddSalada("")
    End Sub

    Private Sub AddSalada(ByVal parSalada As String)

        Me.grpSabor.Visible = False
        Me.grpRecheio.Visible = False
        Me.tbProd.Rows.Clear()
        Dim I As Integer
        Select Case parSalada
            Case "Exótica"
                For I = 0 To 11
                    Me.tbProd.Rows.Add()
                    Me.tbProd.Rows.Item(I).Item("Ok") = True
                Next

                Me.tbProd.Rows.Item(0).Item("Produto") = "Alface"
                Me.tbProd.Rows.Item(1).Item("Produto") = "Azeite"
                Me.tbProd.Rows.Item(2).Item("Produto") = "Beterraba"
                Me.tbProd.Rows.Item(3).Item("Produto") = "Cenoura"
                Me.tbProd.Rows.Item(4).Item("Produto") = "Maçã"
                Me.tbProd.Rows.Item(5).Item("Produto") = "Melão"
                Me.tbProd.Rows.Item(6).Item("Produto") = "Mussarela"
                Me.tbProd.Rows.Item(7).Item("Produto") = "Pepino"
                Me.tbProd.Rows.Item(8).Item("Produto") = "Peru"
                Me.tbProd.Rows.Item(9).Item("Produto") = "Presunto"
                Me.tbProd.Rows.Item(10).Item("Produto") = "Rúcula"
                Me.tbProd.Rows.Item(11).Item("Produto") = "Tomate"


                

            Case "Mais Sabor"
                For I = 0 To 11
                    Me.tbProd.Rows.Add()
                    Me.tbProd.Rows.Item(I).Item("Ok") = True
                Next

                Me.tbProd.Rows.Item(0).Item("Produto") = "Alface"
                Me.tbProd.Rows.Item(1).Item("Produto") = "Azeite"
                Me.tbProd.Rows.Item(2).Item("Produto") = "Beterraba"
                Me.tbProd.Rows.Item(3).Item("Produto") = "Cenoura"
                Me.tbProd.Rows.Item(4).Item("Produto") = "Linhaça"
                Me.tbProd.Rows.Item(5).Item("Produto") = "Maçã"
                Me.tbProd.Rows.Item(6).Item("Produto") = "Manga"
                Me.tbProd.Rows.Item(7).Item("Produto") = "Mussarela"
                Me.tbProd.Rows.Item(8).Item("Produto") = "Pepino Japonês"
                Me.tbProd.Rows.Item(9).Item("Produto") = "Presunto"
                Me.tbProd.Rows.Item(10).Item("Produto") = "Rúcula"
                Me.tbProd.Rows.Item(11).Item("Produto") = "Tomate"

            Case "Tropical"
                For I = 0 To 12
                    Me.tbProd.Rows.Add()
                    Me.tbProd.Rows.Item(I).Item("Ok") = True
                Next

                Me.tbProd.Rows.Item(0).Item("Produto") = "Abacaxi"
                Me.tbProd.Rows.Item(1).Item("Produto") = "Alface"
                Me.tbProd.Rows.Item(2).Item("Produto") = "Azeite"
                Me.tbProd.Rows.Item(3).Item("Produto") = "Beterraba"
                Me.tbProd.Rows.Item(4).Item("Produto") = "Cenoura"
                Me.tbProd.Rows.Item(5).Item("Produto") = "Linhaça"
                Me.tbProd.Rows.Item(6).Item("Produto") = "Maçã"
                Me.tbProd.Rows.Item(7).Item("Produto") = "Mussarela"
                Me.tbProd.Rows.Item(8).Item("Produto") = "Pepino Japonês"
                Me.tbProd.Rows.Item(9).Item("Produto") = "Peito de Peru"
                Me.tbProd.Rows.Item(10).Item("Produto") = "Queijo Branco"
                Me.tbProd.Rows.Item(11).Item("Produto") = "Rúcula"
                Me.tbProd.Rows.Item(12).Item("Produto") = "Tomate"

        End Select
        If parSalada <> "" Then
            Dim dt As DataTable = CarregarDataTable("SELECT Convert(Numeric(15,2),Valor) as Valor FROM Produto where Setor = '" & strBotao & "' and Nome LIKE '%" & parSalada & "%'")

            If dt.Rows.Count > 0 Then
                Me.txtValor.Text = dt.Rows.Item(0).Item("Valor").ToString
            End If
            Calcular()
        End If
    
    End Sub

    Private Sub btnSobremesa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSobremesa.Click
        LimparValores()
        Localizacao(Me.btnSobremesa, True, 316)
        Me.grpRecheio.Text = "TAMANHO"
        Me.tbProduto.Rows.Clear()
        With Me.tbProduto.Rows
            Dim I As Integer
            For I = 0 To 1
                .Add()
                .Item(I).Item("Ok") = False
            Next
            .Item(0).Item("Produto") = "Açaí"
            .Item(1).Item("Produto") = "Salada de Frutas"

        End With

        strBotao = "SOBREMESAS"
        Me.grd3.FormatConditions.Item(0).Value1 = True
        AddSorvete("")
    End Sub

    Private Sub AddSorvete(ByVal parSorvete As String)

        Me.grpRecheio.Visible = True
        Me.tbRecheio.Rows.Clear()
        Me.tbProd.Rows.Clear()
        Me.tbSabor.Rows.Clear()
        Dim strTamanho As String = ""
        Dim I As Integer
        Select Case parSorvete
            Case "Açaí"
                Me.grpSabor.Visible = True


                For I = 0 To 1
                    Me.tbRecheio.Rows.Add()
                    Me.tbRecheio.Rows.Item(I).Item("Ok") = False
                Next

                Me.tbRecheio.Rows.Item(0).Item("Produto") = "250 ml"
                Me.tbRecheio.Rows.Item(1).Item("Produto") = "500 ml"

                For I = 0 To 2
                    Me.tbSabor.Rows.Add()
                    Me.tbSabor.Rows.Item(I).Item("Ok") = False
                Next

                Me.tbSabor.Rows.Item(0).Item("Produto") = "Banana"
                Me.tbSabor.Rows.Item(1).Item("Produto") = "Granola"
                Me.tbSabor.Rows.Item(2).Item("Produto") = "Morango"

            Case "Salada de Frutas"
                Me.grpSabor.Visible = False

                For I = 0 To 1
                    Me.tbRecheio.Rows.Add()
                    Me.tbRecheio.Rows.Item(I).Item("Ok") = False
                Next

                Me.tbRecheio.Rows.Item(0).Item("Produto") = "250 ml"
                Me.tbRecheio.Rows.Item(1).Item("Produto") = "500 ml"
              
            Case "Frutas com Chocolate"
                Me.grpSabor.Visible = False

                Me.tbRecheio.Rows.Add()
                Me.tbRecheio.Rows.Item(0).Item("Ok") = False
                Me.tbRecheio.Rows.Item(0).Item("Produto") = "250 ml"
                strTamanho = "250 ml"

            Case "Banana Split", "Abacaxi"
                Me.grpSabor.Visible = True

                For I = 0 To 4
                    Me.tbSabor.Rows.Add()
                    Me.tbSabor.Rows.Item(I).Item("Ok") = False
                Next

                Me.tbSabor.Rows.Item(0).Item("Produto") = "Chocolate"
                Me.tbSabor.Rows.Item(1).Item("Produto") = "Morango"
                Me.tbSabor.Rows.Item(2).Item("Produto") = "Creme"
                Me.tbSabor.Rows.Item(3).Item("Produto") = "Côco"
                Me.tbSabor.Rows.Item(4).Item("Produto") = "Abacaxi"

            Case "Sorvete com Frutas"
                Me.grpSabor.Visible = True

                For I = 0 To 1
                    Me.tbRecheio.Rows.Add()
                    Me.tbRecheio.Rows.Item(I).Item("Ok") = False
                Next

                Me.tbRecheio.Rows.Item(0).Item("Produto") = "250 ml"
                Me.tbRecheio.Rows.Item(1).Item("Produto") = "500 ml"

                For I = 0 To 4
                    Me.tbSabor.Rows.Add()
                    Me.tbSabor.Rows.Item(I).Item("Ok") = False
                Next

                Me.tbSabor.Rows.Item(0).Item("Produto") = "Chocolate"
                Me.tbSabor.Rows.Item(1).Item("Produto") = "Morango"
                Me.tbSabor.Rows.Item(2).Item("Produto") = "Creme"
                Me.tbSabor.Rows.Item(3).Item("Produto") = "Côco"
                Me.tbSabor.Rows.Item(4).Item("Produto") = "Abacaxi"

            Case "Milk Shake"
                Me.grpSabor.Visible = True

                For I = 0 To 1
                    Me.tbRecheio.Rows.Add()
                    Me.tbRecheio.Rows.Item(I).Item("Ok") = False
                Next
                Me.tbRecheio.Rows.Item(0).Item("Produto") = "300 ml"
                Me.tbRecheio.Rows.Item(1).Item("Produto") = "500 ml"
                ' Me.tbRecheio.Rows.Item(0).Item("Ok") = True
                For I = 0 To 2
                    Me.tbSabor.Rows.Add()
                    Me.tbSabor.Rows.Item(I).Item("Ok") = False
                Next

                Me.tbSabor.Rows.Item(0).Item("Produto") = "Côco"
                Me.tbSabor.Rows.Item(1).Item("Produto") = "Chocolate"
                Me.tbSabor.Rows.Item(2).Item("Produto") = "Morango"
                strTamanho = "300 ml"
            Case "Frost Fruta"
                Me.grpSabor.Visible = True

                For I = 0 To 0
                    Me.tbRecheio.Rows.Add()
                    Me.tbRecheio.Rows.Item(I).Item("Ok") = False
                Next


                Me.tbRecheio.Rows.Item(0).Item("Produto") = "500 ml"
                'Me.tbRecheio.Rows.Item(0).Item("Ok") = True
                For I = 0 To 3
                    Me.tbSabor.Rows.Add()
                    Me.tbSabor.Rows.Item(I).Item("Ok") = False
                Next

                Me.tbSabor.Rows.Item(0).Item("Produto") = "Chocolate"
                Me.tbSabor.Rows.Item(1).Item("Produto") = "Morango"
                Me.tbSabor.Rows.Item(2).Item("Produto") = "Pêssego"
                Me.tbSabor.Rows.Item(3).Item("Produto") = "Manga"
                strTamanho = "500 ml"
        End Select


        For I = 0 To 4
            Me.tbProd.Rows.Add()
            Me.tbProd.Rows.Item(I).Item("Ok") = False
        Next

        Me.tbProd.Rows.Item(0).Item("Produto") = "Leite Condensado"
        Me.tbProd.Rows.Item(1).Item("Produto") = "Leite em Pó"
        Me.tbProd.Rows.Item(2).Item("Produto") = "Mel"
        Me.tbProd.Rows.Item(3).Item("Produto") = "Paçoca"
        Me.tbProd.Rows.Item(4).Item("Produto") = "Pó de Guaraná"


        Select Case parSorvete
            Case "Açaí", "Salada de Frutas", "Frutas com Chocolate", "Sorvete com Frutas", "Milk Shake", "Frost Fruta"
                '    Dim dt As DataTable = CarregarDataTable("SELECT Convert(Numeric(15,2),Valor) as Valor FROM Produto where Setor = '" & strBotao & "' and Nome LIKE '%" & parSorvete & "%' and Nome LIKE '%" & strTamanho & "%'")

                '    If dt.Rows.Count > 0 Then
                '        Me.txtValor.Text = dt.Rows.Item(0).Item("Valor").ToString
                '    End If
            Case ""

            Case Else
                Dim dt As DataTable = CarregarDataTable("SELECT Convert(Numeric(15,2),Valor) as Valor FROM Produto where Setor = '" & strBotao & "' and Nome LIKE '%" & parSorvete & "%'")

                If dt.Rows.Count > 0 Then
                    Me.txtValor.Text = dt.Rows.Item(0).Item("Valor").ToString
                End If
        End Select
        Calcular()
      
    End Sub
    
    Private Sub btnSuco_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSuco.ItemClick
        LimparValores()
        Localizacao(Me.btnBebidas, True, 138)
        Me.grpRecheio.Text = "TAMANHO"
        addSucos("Sucos")
        Me.btnBebidas.Text = "Sucos"
        strBotao = "BEBIDAS"
        AddBebidas("Sucos")
        Me.grd3.FormatConditions.Item(0).Value1 = True
    End Sub

    Private Sub btnVitaminas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVitaminas.ItemClick
        LimparValores()
        Localizacao(Me.btnBebidas, True, 138)
        Me.grpRecheio.Text = "TAMANHO"
        addSucos("Vitaminas")
        Me.btnBebidas.Text = "Vitaminas"
        strBotao = "BEBIDAS"
        AddBebidas("Vitaminas")
        Me.grd3.FormatConditions.Item(0).Value1 = True
    End Sub

    Private Sub btnAgua_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAgua.ItemClick
        LimparValores()
        Localizacao(Me.btnBebidas, True, 138)
        Me.grpRecheio.Text = "TAMANHO"
        addSucos("Agua")
        Me.btnBebidas.Text = "Agua"
        strBotao = "BEBIDAS"
        AddBebidas("Agua")
        Me.grd3.FormatConditions.Item(0).Value1 = True
    End Sub

    Private Sub btnBebidas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBebidas.Click
        LimparValores()
        Me.grd3.FormatConditions.Item(0).Value1 = True
        Localizacao(Me.btnBebidas, True, 138)
        Me.grpRecheio.Text = "TAMANHO"
        strBotao = "BEBIDAS"
        If Me.btnBebidas.Text = "Bebidas" Then
            Me.btnBebidas.ShowDropDown()
        Else

            addSucos(Me.btnBebidas.Text)

            AddBebidas(Me.btnBebidas.Text)
        End If
    End Sub

    Private Sub AddBebidas(ByVal parBebidas As String)

        Me.grpSabor.Visible = False
        Me.grpRecheio.Visible = True
        Me.tbRecheio.Rows.Clear()
        Me.tbProd.Rows.Clear()
        Dim I As Integer
        Select Case parBebidas
            Case "Sucos", "Vitaminas"
                For I = 0 To 7
                    Me.tbProd.Rows.Add()
                    Me.tbProd.Rows.Item(I).Item("Ok") = False
                Next

                Me.tbProd.Rows.Item(0).Item("Produto") = "Couve"
                Me.tbProd.Rows.Item(1).Item("Produto") = "Gengibre"
                Me.tbProd.Rows.Item(2).Item("Produto") = "Hortelã"
                Me.tbProd.Rows.Item(3).Item("Produto") = "Leite Condensado"
                Me.tbProd.Rows.Item(4).Item("Produto") = "Linhaça"
                Me.tbProd.Rows.Item(5).Item("Produto") = "Mel"
                Me.tbProd.Rows.Item(6).Item("Produto") = "Pó de Guaraná"
                Me.tbProd.Rows.Item(7).Item("Produto") = "Aveia"
               


                For I = 0 To 1
                    Me.tbRecheio.Rows.Add()
                    Me.tbRecheio.Rows.Item(I).Item("Ok") = False
                Next

                Me.tbRecheio.Rows.Item(0).Item("Produto") = "500 ml"
                Me.tbRecheio.Rows.Item(1).Item("Produto") = "700 ml"
           
                'If parBebidas = "Sucos" Then
                '    parBebidas = "Suco"
                'Else
                '    parBebidas = "Vitamina"
                'End If
                'Dim dt As DataTable = CarregarDataTable("SELECT Convert(Numeric(15,2),Valor) as Valor FROM Produto where Setor = '" & strBotao & "' and Nome LIKE '%" & parBebidas & "%' and Nome LIKE '%300 ml%'")

                'If dt.Rows.Count > 0 Then
                '    Me.txtValor.Text = dt.Rows.Item(0).Item("Valor").ToString
                'End If

            Case "Agua"
                Dim intIndex As Integer = Me.grd1.FocusedRowHandle
                Dim strProduto As String = Me.grd1.GetRowCellDisplayText(intIndex, Me.colProduto2)

                Dim dt As DataTable = CarregarDataTable("SELECT Convert(Numeric(15,2),Valor) as Valor FROM Produto where Setor = '" & strBotao & "' and Nome LIKE '%" & parBebidas & "%' and Nome LIKE '%" & strProduto & "%'")

                If dt.Rows.Count > 0 Then
                    Me.txtValor.Text = dt.Rows.Item(0).Item("Valor").ToString


                   
                End If
        End Select
        Calcular()
    End Sub
    Private Sub addSucos(ByVal parBebida As String)

        Me.tbProduto.Rows.Clear()
        With Me.tbProduto.Rows
            Dim I As Integer

            Select Case parBebida
                Case "Agua"
                    For I = 0 To 1
                        .Add()
                        .Item(I).Item("Ok") = False
                    Next
                    .Item(0).Item("Produto") = "Com Gás"
                    .Item(1).Item("Produto") = "Sem Gás"

                    .Item(1).Item("Ok") = True

                Case "Vitaminas"
                    For I = 0 To 22
                        .Add()
                        .Item(I).Item("Ok") = False
                    Next
                    .Item(0).Item("Produto") = "Abacaxi"
                    .Item(1).Item("Produto") = "Açaí"
                    .Item(2).Item("Produto") = "Acerola"
                    .Item(3).Item("Produto") = "Amora"
                    .Item(4).Item("Produto") = "Banana"
                    .Item(5).Item("Produto") = "Beterraba"
                    .Item(6).Item("Produto") = "Cacau"
                    .Item(7).Item("Produto") = "Caju"
                    .Item(8).Item("Produto") = "Cenoura"
                    .Item(9).Item("Produto") = "Frutas Vermelhas"
                    .Item(10).Item("Produto") = "Goiaba"
                    .Item(11).Item("Produto") = "Laranja"
                    .Item(12).Item("Produto") = "Limão"
                    .Item(13).Item("Produto") = "Maçã"
                    .Item(14).Item("Produto") = "Manga"
                    .Item(15).Item("Produto") = "Mamão"
                    .Item(16).Item("Produto") = "Maracuja"
                    .Item(17).Item("Produto") = "Melão"
                    .Item(18).Item("Produto") = "Melancia"
                    .Item(19).Item("Produto") = "Morango"
                    .Item(20).Item("Produto") = "Pitanga"
                    .Item(21).Item("Produto") = "Tangerina"
                    .Item(22).Item("Produto") = "Uva"
                   
                Case Else
                    For I = 0 To 31
                        .Add()
                        .Item(I).Item("Ok") = False
                    Next
                    .Item(0).Item("Produto") = "Abacaxi"
                    .Item(1).Item("Produto") = "Açaí"
                    .Item(2).Item("Produto") = "Acerola"
                    .Item(3).Item("Produto") = "Amora"
                    .Item(4).Item("Produto") = "Banana"
                    .Item(5).Item("Produto") = "Beterraba"
                    .Item(6).Item("Produto") = "Cacau"
                    .Item(7).Item("Produto") = "Caju"
                    .Item(8).Item("Produto") = "Cenoura"
                    .Item(9).Item("Produto") = "Frutas Vermelhas"
                    .Item(10).Item("Produto") = "Goiaba"
                    .Item(11).Item("Produto") = "Laranja"
                    .Item(12).Item("Produto") = "Limão"
                    .Item(13).Item("Produto") = "Maçã"
                    .Item(14).Item("Produto") = "Manga"
                    .Item(15).Item("Produto") = "Mamão"
                    .Item(16).Item("Produto") = "Maracuja"
                    .Item(17).Item("Produto") = "Melão"
                    .Item(18).Item("Produto") = "Melancia"
                    .Item(19).Item("Produto") = "Morango"
                    .Item(20).Item("Produto") = "Pitanga"
                    .Item(21).Item("Produto") = "Tangerina"
                    .Item(22).Item("Produto") = "Uva"
                    .Item(23).Item("Produto") = "Função Cerebral"
                    .Item(24).Item("Produto") = "Energético"
                    .Item(25).Item("Produto") = "Anti-Stress"
                    .Item(26).Item("Produto") = "Gripe"
                    .Item(27).Item("Produto") = "Clorofila Detox"
                    .Item(28).Item("Produto") = "Digestivo"
                    .Item(29).Item("Produto") = "Anemia"
                    .Item(30).Item("Produto") = "Insônia"
                    .Item(31).Item("Produto") = "Anti-Depressivo"


            End Select

        End With

    End Sub
   
    
    Private Sub LimparProduto()
        If strBotao <> "BEBIDAS" Then
            Dim I As Integer
            For I = 0 To grd1.RowCount - 1
                Me.tbProduto.Rows.Item(I).Item("Ok") = False
            Next
        Else
            If Me.btnBebidas.Text = "Agua" Then
                Dim I As Integer
                For I = 0 To grd1.RowCount - 1
                    Me.tbProduto.Rows.Item(I).Item("Ok") = False
                Next
            End If
        End If
    End Sub

    Private Sub chkProduto_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkProduto.EditValueChanged
        LimparValores()
        Select Case strBotao
            Case "LANCHES"
                AddLanche()

            Case "SALADAS"

                Dim intIndex As Integer = Me.grd1.FocusedRowHandle
                Dim strProduto As String = Me.grd1.GetRowCellDisplayText(intIndex, Me.colProduto2)

                AddSalada(strProduto)

            Case "BEBIDAS"
                Dim intIndex As Integer = Me.grd1.FocusedRowHandle
                Dim index As Integer = -999997
                grd1.FocusedRowHandle = index
                grd1.ShowEditor()
                Dim strProduto As String = Me.grd1.GetRowCellDisplayText(intIndex, Me.colProduto2)

                Dim bolProd As Boolean = Me.grd1.GetRowCellValue(intIndex, Me.colOk2)
                'Dim dblAcres As Double
                'Dim I As Integer

                'Dim intQtd As Integer = 0
                'For I = 0 To Me.grd1.RowCount - 1
                '    If Me.grd1.GetRowCellValue(I, Me.colOk2) = True Then
                '        intQtd += 1
                '    End If
                'Next

                'If intQtd = 4 Then
                '    MsgBox("Só é permitido 3 tipos de complementos", MsgBoxStyle.Information)
                '    Me.grd1.SetRowCellValue(intIndex, Me.colOk2, False)
                '    Exit Sub
                'End If


                '''''ACRESCIMO


                'For I = 0 To Me.grd1.RowCount - 1
                '    If Me.grd1.GetRowCellValue(I, Me.colOk2) = True Then
                '        strProduto = Me.grd1.GetRowCellDisplayText(I, Me.colProduto2)
                '        Select Case strProduto
                '            Case "Açaí", "Amora", "Frutas Vermelhas"
                '                dblAcres = CDbl(Me.txtAcrescimo.Text) + 1.5
                '                If bolProd = True Then

                '                    'Else
                '                    '    dblAcres = CDbl(Me.txtAcrescimo.Text) - 1
                '                End If
                '                Me.txtAcrescimo.Text = dblAcres.ToString("0.00")
                '            Case "Framboesa", "Mirtilo"
                '                dblAcres = CDbl(Me.txtAcrescimo.Text) + 1.5
                '                If bolProd = True Then

                '                    'Else
                '                    '    dblAcres = CDbl(Me.txtAcrescimo.Text) - 1.5
                '                End If
                '                Me.txtAcrescimo.Text = dblAcres.ToString("0.00")
                '        End Select
                '    End If
                'Next

         


                'For I = 0 To Me.grd3.RowCount - 1
                '    If Me.grd3.GetRowCellValue(I, Me.colOk) = True Then

                '        If Me.grd3.GetRowCellDisplayText(I, Me.colProduto) = "Hortalã" Then
                '            dblAcres = CDbl(Me.txtAcrescimo.Text) - 0.5

                '        ElseIf Me.grd3.GetRowCellDisplayText(I, Me.colProduto) = "Massa de Açaí" Then
                '            dblAcres = CDbl(Me.txtAcrescimo.Text) - 2

                '        Else
                '            dblAcres = CDbl(Me.txtAcrescimo.Text) - 1.5

                '        End If
                '        Me.txtAcrescimo.Text = dblAcres.ToString("0.00")
                '    End If
                'Next

                AddBebidas(Me.btnBebidas.Text)


              
            Case "SOBREMESAS"
                Dim intIndex As Integer = Me.grd1.FocusedRowHandle
                Dim index As Integer = -999997
                grd1.FocusedRowHandle = index
                grd1.ShowEditor()
                
                Dim bolProd As Boolean = Me.grd1.GetRowCellValue(intIndex, Me.colOk2)
                'Dim dblAcres As Double
                'Dim I As Integer

                'Dim intQtd As Integer = 0
                'For I = 0 To Me.grd1.RowCount - 1
                '    If Me.grd1.GetRowCellValue(I, Me.colOk2) = True Then
                '        intQtd += 1
                '    End If
                'Next

                'If intQtd = 4 Then
                '    MsgBox("Só é permitido 3 tipos de complementos", MsgBoxStyle.Information)
                '    Me.grd1.SetRowCellValue(intIndex, Me.colOk2, False)
                '    Exit Sub
                'End If
                'For I = 0 To Me.grd3.RowCount - 1
                '    If Me.grd3.GetRowCellValue(I, Me.colOk) = True Then

                '        If Me.grd3.GetRowCellDisplayText(I, Me.colProduto) = "Hortalã" Then
                '            dblAcres = CDbl(Me.txtAcrescimo.Text) - 0.5

                '        ElseIf Me.grd3.GetRowCellDisplayText(I, Me.colProduto) = "Massa de Açaí" Then
                '            dblAcres = CDbl(Me.txtAcrescimo.Text) - 2

                '        Else
                '            dblAcres = CDbl(Me.txtAcrescimo.Text) - 1.5

                '        End If
                '        Me.txtAcrescimo.Text = dblAcres.ToString("0.00")
                '    End If
                'Next

                Dim strProduto As String = Me.grd1.GetRowCellDisplayText(intIndex, Me.colProduto2)

                AddSorvete(strProduto)
        End Select


    End Sub
    Private Sub LimparValores()
        Me.txtQtd.ResetText()
        Me.txtAcrescimo.ResetText()
        Me.txtValor.ResetText()
        Me.txtValorTotal.ResetText()
        Calcular()
    End Sub
    Private Sub btnCancelar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelar.ItemClick
        Localizacao(Me.btnLanches, False, 46)
        Me.grpRecheio.Visible = True
        Me.btnBebidas.Text = "Bebidas"
        Me.tbRecheio.Rows.Clear()
        Me.tbProd.Rows.Clear()
        Me.tbProduto.Rows.Clear()

        LimparValores()
    End Sub

    Private Sub btnOk_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOk.ItemClick
        If strBotao = "" Then Exit Sub
        Dim strProduto As String = ""
        Dim strRecheio As String = ""
        Dim strAcompanhamento As String = ""
        Dim strCodProd As String = ""
        Dim strUM As String = ""
        Dim strCodigoInterno As String = ""
        Dim strValorCusto As String = ""
        Dim dt As DataTable = Nothing

        Dim I As Integer
        Dim A As Integer

        Dim index As Integer = -999997
        grd1.FocusedRowHandle = index
        grd1.ShowEditor()
        grd2.FocusedRowHandle = index
        grd2.ShowEditor()
        grd3.FocusedRowHandle = index
        grd3.ShowEditor()

        dt = CarregarDataTable("SELECT Codigo, Nome, UnidadeMedida, ValorCusto, CodigoInterno FROM Produto where Setor = '" & strBotao & "'")

        If dt.Rows.Count = 0 Then Exit Sub

        Select Case strBotao
            Case "LANCHES"


              
              

                For I = 0 To Me.grd1.RowCount - 1
                    If Me.grd1.GetRowCellValue(I, Me.colOk2) = True Then
                        strProduto = " " & Me.grd1.GetRowCellDisplayText(I, Me.colProduto2)
                        Exit For
                    End If
                Next

                If strProduto = "" Then MsgBox("Produto não selecionado!", MsgBoxStyle.Information) : Exit Sub

                strCodProd = dt.Rows.Item(0).Item("Codigo").ToString
                strProduto = dt.Rows.Item(0).Item("Nome").ToString & " " & strProduto
                strUM = dt.Rows.Item(0).Item("UnidadeMedida").ToString
                strCodigoInterno = dt.Rows.Item(0).Item("CodigoInterno").ToString
                strValorCusto = dt.Rows.Item(0).Item("ValorCusto").ToString



                For I = 0 To Me.grd2.RowCount - 1
                    If Me.grd2.GetRowCellValue(I, Me.colOk1) = True Then
                        If strRecheio = "" Then
                            strRecheio = Me.grd2.GetRowCellDisplayText(I, Me.colProduto1)
                        Else
                            strRecheio &= "," & Me.grd2.GetRowCellDisplayText(I, Me.colProduto1)
                        End If
                    End If
                Next

                If strRecheio = "" Then MsgBox("Recheio não selecionado!", MsgBoxStyle.Information) : Exit Sub

                For I = 0 To Me.grd3.RowCount - 1
                    If Me.grd3.GetRowCellValue(I, Me.colOk) = True Then
                        If strAcompanhamento = "" Then
                            strAcompanhamento = Me.grd3.GetRowCellDisplayText(I, Me.colProduto)
                        Else
                            strAcompanhamento &= "," & Me.grd3.GetRowCellDisplayText(I, Me.colProduto)
                        End If
                    End If
                Next

                If strRecheio <> "" Then
                    strRecheio = "(" & strRecheio & ") "
                End If
                If strAcompanhamento <> "" Then
                    strAcompanhamento = "(" & strAcompanhamento & ")"
                End If

                strProduto = strProduto & " " & strRecheio & strAcompanhamento

            Case "SALADAS"

                
         

                For I = 0 To Me.grd1.RowCount - 1
                    If Me.grd1.GetRowCellValue(I, Me.colOk2) = True Then
                        strProduto &= " " & Me.grd1.GetRowCellDisplayText(I, Me.colProduto2)
                    End If
                Next

                If strProduto = "" Then MsgBox("Produto não selecionado!", MsgBoxStyle.Information) : Exit Sub

                For I = 0 To dt.Rows.Count - 1
                    If dt.Rows.Item(I).Item("Nome").ToString.Contains(strProduto.ToUpper) = True Then
                        If dt.Rows.Item(I).Item("Nome").ToString.Contains(strProduto.ToUpper) = True Then
                            strCodProd = dt.Rows.Item(I).Item("Codigo").ToString
                            strProduto = dt.Rows.Item(I).Item("Nome").ToString
                            strUM = dt.Rows.Item(I).Item("UnidadeMedida").ToString
                            strCodigoInterno = dt.Rows.Item(I).Item("CodigoInterno").ToString
                            strValorCusto = dt.Rows.Item(I).Item("ValorCusto").ToString
                            Exit For
                        End If
                    End If
                Next
                'strCodProd = dt.Rows.Item(0).Item("Codigo").ToString
                'strProduto = dt.Rows.Item(0).Item("Nome").ToString
                'strUM = dt.Rows.Item(0).Item("UnidadeMedida").ToString
                'strCodigoInterno = dt.Rows.Item(0).Item("CodigoInterno").ToString
                'strValorCusto = dt.Rows.Item(0).Item("ValorCusto").ToString

                For I = 0 To Me.grd3.RowCount - 1
                    If Me.grd3.GetRowCellValue(I, Me.colOk) = False Then
                        If strAcompanhamento = "" Then
                            strAcompanhamento = Me.grd3.GetRowCellDisplayText(I, Me.colProduto)
                        Else
                            strAcompanhamento &= "," & Me.grd3.GetRowCellDisplayText(I, Me.colProduto)
                        End If
                    End If
                Next

                If strAcompanhamento <> "" Then
                    strAcompanhamento = "(" & strAcompanhamento & ")"
                End If

                strProduto = strProduto & " " & strRecheio & strAcompanhamento

            Case "BEBIDAS"
                If Me.btnBebidas.Text = "Agua" Then
                    


                    For I = 0 To dt.Rows.Count - 1

                        If dt.Rows.Item(I).Item("Nome").ToString.Contains(Me.btnBebidas.Text) = True Then
                            strCodProd = dt.Rows.Item(I).Item("Codigo").ToString
                            strProduto = dt.Rows.Item(I).Item("Nome").ToString
                            strUM = dt.Rows.Item(I).Item("UnidadeMedida").ToString
                            strCodigoInterno = dt.Rows.Item(I).Item("CodigoInterno").ToString
                            strValorCusto = dt.Rows.Item(I).Item("ValorCusto").ToString
                            Exit For
                        End If

                    Next
                    For I = 0 To Me.grd1.RowCount - 1
                        If Me.grd1.GetRowCellValue(I, Me.colOk2) = True Then
                            strProduto &= " " & Me.grd1.GetRowCellDisplayText(I, Me.colProduto2)
                        End If
                    Next

                    If strProduto = "" Then Exit Sub


                Else



               
                    For A = 0 To Me.grd2.RowCount - 1
                        If Me.grd2.GetRowCellValue(A, Me.colOk1) = True Then
                            strProduto = Me.grd2.GetRowCellDisplayText(A, Me.colProduto1)
                            Exit For
                        End If
                    Next

                    If strProduto = "" Then MsgBox("Tamanho não selecionado!", MsgBoxStyle.Information) : Exit Sub


                    Dim strBebida As String
                    If Me.btnBebidas.Text = "Sucos" Then
                        strBebida = "Suco"
                    Else
                        strBebida = "Vitamina"
                    End If
                    For I = 0 To dt.Rows.Count - 1
                        If dt.Rows.Item(I).Item("Nome").ToString.Contains(strProduto.ToUpper) = True Then
                            If dt.Rows.Item(I).Item("Nome").ToString.Contains(strBebida.ToUpper) = True Then
                                strCodProd = dt.Rows.Item(I).Item("Codigo").ToString
                                strProduto = dt.Rows.Item(I).Item("Nome").ToString
                                strUM = dt.Rows.Item(I).Item("UnidadeMedida").ToString
                                strCodigoInterno = dt.Rows.Item(I).Item("CodigoInterno").ToString
                                strValorCusto = dt.Rows.Item(I).Item("ValorCusto").ToString
                                Exit For
                            End If
                        End If
                    Next

                    For I = 0 To Me.grd1.RowCount - 1
                        If Me.grd1.GetRowCellValue(I, Me.colOk2) = True Then
                            If strRecheio = "" Then
                                strRecheio = Me.grd1.GetRowCellDisplayText(I, Me.colProduto2)
                            Else
                                strRecheio &= "," & Me.grd1.GetRowCellDisplayText(I, Me.colProduto2)
                            End If
                        End If
                    Next
                    If strRecheio = "" Then MsgBox("Produto não selecionado!", MsgBoxStyle.Information) : Exit Sub


                    For A = 0 To Me.grd3.RowCount - 1
                        If Me.grd3.GetRowCellValue(A, Me.colOk) = True Then
                            If strAcompanhamento = "" Then
                                strAcompanhamento = Me.grd3.GetRowCellDisplayText(A, Me.colProduto)
                            Else
                                strAcompanhamento &= "," & Me.grd3.GetRowCellDisplayText(A, Me.colProduto)
                            End If
                        End If
                    Next

                    If strRecheio <> "" Then
                        strRecheio = "(" & strRecheio & ") "
                    End If
                    If strAcompanhamento <> "" Then
                        strAcompanhamento = "(" & strAcompanhamento & ")"
                    End If



                End If


                strProduto = strProduto & " " & strRecheio & strAcompanhamento



            Case "SOBREMESAS"

                Dim strSobremesa As String = ""
                For A = 0 To Me.grd1.RowCount - 1
                    If Me.grd1.GetRowCellValue(A, Me.colOk2) = True Then
                        strSobremesa = Me.grd1.GetRowCellDisplayText(A, Me.colProduto2)
                        Exit For
                    End If
                Next
                If strSobremesa = "" Then MsgBox("Produto não selecionado!", MsgBoxStyle.Information) : Exit Sub




                Dim strProd As String = ""
                Select Case strSobremesa
                    Case "Açaí", "Salada de Frutas", "Frutas com Chocolate", "Sorvete com Frutas", "Milk Shake", "Frost Fruta"

                        For A = 0 To Me.grd2.RowCount - 1
                            If Me.grd2.GetRowCellValue(A, Me.colOk1) = True Then
                                strProd = Me.grd2.GetRowCellDisplayText(A, Me.colProduto1)
                            End If
                        Next

                        If strProd = "" Then MsgBox("Tamanho não selecionado!", MsgBoxStyle.Information) : Exit Sub

                        For I = 0 To dt.Rows.Count - 1
                            If dt.Rows.Item(I).Item("Nome").ToString.Contains(strSobremesa.ToUpper) = True Then
                                If dt.Rows.Item(I).Item("Nome").ToString.Contains(strProd.ToUpper) = True Then
                                    strCodProd = dt.Rows.Item(I).Item("Codigo").ToString
                                    strProduto = dt.Rows.Item(I).Item("Nome").ToString
                                    strUM = dt.Rows.Item(I).Item("UnidadeMedida").ToString
                                    strCodigoInterno = dt.Rows.Item(I).Item("CodigoInterno").ToString
                                    strValorCusto = dt.Rows.Item(I).Item("ValorCusto").ToString
                                    Exit For
                                End If
                            End If
                        Next
                    Case Else

                        For I = 0 To dt.Rows.Count - 1

                            If dt.Rows.Item(I).Item("Nome").ToString.Contains(strSobremesa.ToUpper) = True Then
                                strCodProd = dt.Rows.Item(I).Item("Codigo").ToString
                                strProduto = dt.Rows.Item(I).Item("Nome").ToString
                                strUM = dt.Rows.Item(I).Item("UnidadeMedida").ToString
                                strCodigoInterno = dt.Rows.Item(I).Item("CodigoInterno").ToString
                                strValorCusto = dt.Rows.Item(I).Item("ValorCusto").ToString
                                Exit For
                            End If

                        Next
                End Select

                Dim strSabor As String = ""
                For A = 0 To Me.grd4.RowCount - 1
                    If Me.grd4.GetRowCellValue(A, Me.colOk) = True Then
                        If strSabor = "" Then
                            strSabor = Me.grd4.GetRowCellDisplayText(A, Me.colProduto3)
                        Else
                            strSabor &= "," & Me.grd4.GetRowCellDisplayText(A, Me.colProduto3)
                        End If
                    End If
                Next

                For A = 0 To Me.grd3.RowCount - 1
                    If Me.grd3.GetRowCellValue(A, Me.colOk) = True Then
                        If strAcompanhamento = "" Then
                            strAcompanhamento = Me.grd3.GetRowCellDisplayText(A, Me.colProduto)
                        Else
                            strAcompanhamento &= "," & Me.grd3.GetRowCellDisplayText(A, Me.colProduto)
                        End If
                    End If
                Next

                Select Case strSobremesa
                    Case "Banana Split", "Sorvete com Frutas", "Abacaxi", "Milk Shake", "Frost Fruta"
                        'If strAcompanhamento = "" Then MsgBox("Acompanhamento não selecionado!", MsgBoxStyle.Information) : Exit Sub
                        If strSabor = "" Then MsgBox("Sabor não selecionado!", MsgBoxStyle.Information) : Exit Sub

                End Select

                If strSabor <> "" Then
                    strSabor = "(" & strSabor & ")"
                End If
                If strAcompanhamento <> "" Then
                    strAcompanhamento = "(" & strAcompanhamento & ")"
                End If

                strProduto = strProduto & " " & strSabor & " " & strAcompanhamento


        End Select

        strProduto = strProduto.ToUpper


        Dim dblValor As Double = CDbl(Me.txtValor.Text) + CDbl(Me.txtAcrescimo.Text)


        With frmVenda.tbItens.Rows
            frmVenda.picFundo.Visible = False
            .Add()

            .Item(.Count - 1).Item("CodProdAut") = strCodProd
            .Item(.Count - 1).Item("CodProd") = strCodigoInterno
            .Item(.Count - 1).Item("Produto") = strProduto
            .Item(.Count - 1).Item("Qtde") = Me.txtQtd.Text
            .Item(.Count - 1).Item("Unitario") = dblValor.ToString("0.00")
            .Item(.Count - 1).Item("Total") = Me.txtValorTotal.Text
            .Item(.Count - 1).Item("Custo") = strValorCusto
            .Item(.Count - 1).Item("UM") = strUM
            .Item(.Count - 1).Item("CodFunc") = 0
            .Item(.Count - 1).Item("Tamanho") = "U"
            .Item(.Count - 1).Item("Desconto") = "0,00"
            .Item(.Count - 1).Item("Promocao") = False
            .Item(.Count - 1).Item("ValorSemDesconto") = dblValor.ToString("0.00")

        End With

        Localizacao(Me.btnLanches, False, 46)
        Me.btnBebidas.Text = "Bebidas"
        Me.grpRecheio.Visible = True
        Me.tbRecheio.Rows.Clear()
        Me.tbProd.Rows.Clear()
        Me.tbProduto.Rows.Clear()

        LimparValores()

    End Sub


    Private Sub Calcular()
        If Me.txtQtd.Text = "" Then
            Me.txtQtd.Text = "1"
        End If

        If Me.txtAcrescimo.Text = "" Then
            Me.txtAcrescimo.Text = "0,00"
        End If

        If Me.txtValor.Text = "" Then
            Me.txtValor.Text = "0,00"
        End If

        Dim dblValor As Double = CDbl(Me.txtValor.Text) + CDbl(Me.txtAcrescimo.Text)

        Dim dblValorTotal As Double = CDbl(Me.txtQtd.Text) * dblValor

        Me.txtValorTotal.Text = dblValorTotal.ToString("0.00")

    End Sub

    Private Sub chkAcompanhamento_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAcompanhamento.EditValueChanged
        Dim intIndex As Integer = Me.grd3.FocusedRowHandle
        Dim index As Integer = -999997
        grd3.FocusedRowHandle = index
        grd3.ShowEditor()
        Select Case strBotao
            Case "BEBIDAS", "SOBREMESAS"





                Dim strProduto As String = Me.grd3.GetRowCellDisplayText(intIndex, Me.colProduto)
                Dim bolAcom As Boolean = Me.grd3.GetRowCellValue(intIndex, Me.colOk)

                Dim bolAcresc As Double

                If strProduto = "Hortelã" Then
                    If bolAcom = True Then
                        bolAcresc = CDbl(Me.txtAcrescimo.Text) + 0.5

                    Else
                        bolAcresc = CDbl(Me.txtAcrescimo.Text) - 0.5


                    End If
                ElseIf strProduto = "Massa de Açaí" Then
                    If bolAcom = True Then
                        bolAcresc = CDbl(Me.txtAcrescimo.Text) + 2

                    Else
                        bolAcresc = CDbl(Me.txtAcrescimo.Text) - 2


                    End If
                Else
                    If bolAcom = True Then
                        bolAcresc = CDbl(Me.txtAcrescimo.Text) + 2

                    Else
                        bolAcresc = CDbl(Me.txtAcrescimo.Text) - 2


                    End If
                End If

                Me.txtAcrescimo.Text = bolAcresc.ToString("0.00")
                Calcular()
                'Case "LANCHES"
                '    Dim I As Integer
                '    Dim intQtd As Integer = 0
                '    For I = 0 To Me.grd3.RowCount - 1
                '        If Me.grd3.GetRowCellValue(I, Me.colOk) = True Then
                '            intQtd += 1
                '        End If
                '    Next

                '    If intQtd = 6 Then
                '        MsgBox("Só é permitido 5 tipos de acompanhamentos", MsgBoxStyle.Information)
                '        Me.grd3.SetRowCellValue(intIndex, Me.colOk, False)
                '    End If
        End Select
    End Sub

    Private Sub chkRecheio_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkRecheio.EditValueChanged


        Dim intIndex As Integer = Me.grd2.FocusedRowHandle
        Dim index As Integer = -999997
        grd2.FocusedRowHandle = index
        grd2.ShowEditor()
        Dim strProduto As String = Me.grd2.GetRowCellDisplayText(intIndex, Me.colProduto1)
        Dim bolTam As Boolean = Me.grd2.GetRowCellValue(intIndex, Me.colOk1)

        Select Case strBotao
            Case "BEBIDAS"


                If bolTam = True Then
                    Dim strBebida As String = ""
                    If Me.btnBebidas.Text = "Sucos" Then
                        strBebida = "SUCO"
                    Else
                        strBebida = "VITAMINA"
                    End If
                    Dim dt As DataTable = CarregarDataTable("SELECT Convert(Numeric(15,2),Valor) as Valor FROM Produto where Setor = '" & strBotao & "' and Nome LIKE '%" & strBebida & "%' and Nome LIKE '%" & strProduto & "%'")

                    If dt.Rows.Count > 0 Then

                        Me.txtValor.Text = dt.Rows.Item(0).Item("Valor").ToString
                        Dim I As Integer
                        Dim A As Integer
                        For I = 0 To Me.grd1.RowCount - 1
                            If Me.grd1.GetRowCellValue(I, Me.colOk2) = True Then
                                strProduto = Me.grd1.GetRowCellDisplayText(I, Me.colProduto2)
                                Select Case strProduto
                                    Case "Amora", "Frutas Vermelhas", "Framboesa", "Mirtilo", "Açaí", "Clorofila"
                                        For A = 0 To Me.grd2.RowCount - 1
                                            If Me.grd2.GetRowCellValue(A, Me.colOk1) = True Then
                                                Dim strTamanho As String = Me.grd2.GetRowCellDisplayText(A, Me.colProduto1)
                                                If strBebida = "SUCO" Then
                                                    Select Case strTamanho
                                                        Case "300 ml"
                                                            Me.txtValor.Text = "10,00"
                                                        Case "500 ml"
                                                            Me.txtValor.Text = "11,75"
                                                        Case "700 ml"
                                                            Me.txtValor.Text = "17,00"

                                                    End Select
                                                Else
                                                    Select Case strTamanho
                                                        Case "300 ml"
                                                            Me.txtValor.Text = "13,50"
                                                        Case "500 ml"
                                                            Me.txtValor.Text = "15,00"
                                                        Case "700 ml"
                                                            Me.txtValor.Text = "21,00"

                                                    End Select
                                                End If

                                            End If

                                        Next
                                    Case "Função Cerebral", "Energético", "Anti-Stress", "Gripe", "Clorofila Detox", "Anemia", "Digestivo", "Insônia", "Anti-Depressivo"
                                        For A = 0 To Me.grd2.RowCount - 1
                                            If Me.grd2.GetRowCellValue(A, Me.colOk1) = True Then
                                                Dim strTamanho As String = Me.grd2.GetRowCellDisplayText(A, Me.colProduto1)
                                                Select Case strTamanho
                                                    Case "300 ml"
                                                        Me.txtValor.Text = "9,75"
                                                    Case "500 ml"
                                                        Me.txtValor.Text = "15,00"
                                                    Case "700 ml"
                                                        Me.txtValor.Text = "20,00"

                                                End Select
                                            End If

                                        Next
                                End Select
                            End If
                        Next
                    End If
                Else
                    Me.txtValor.Text = "0,00"
                End If
            Case "SOBREMESAS"
                If bolTam = True Then
                    Dim I As Integer
                    Dim strSobremesa As String = ""
                    For I = 0 To Me.grd1.RowCount - 1
                        If Me.grd1.GetRowCellValue(I, Me.colOk2) = True Then
                            strSobremesa = Me.grd1.GetRowCellDisplayText(I, Me.colProduto2)
                            Exit For
                        End If
                    Next
                    Dim dt As DataTable = CarregarDataTable("SELECT Convert(Numeric(15,2),Valor) as Valor FROM Produto where Setor = '" & strBotao & "' and Nome LIKE '%" & strSobremesa & "%' and Nome LIKE '%" & strProduto & "%'")

                    If dt.Rows.Count > 0 Then
                        Me.txtValor.Text = dt.Rows.Item(0).Item("Valor").ToString
                    End If
                Else
                    Me.txtValor.Text = "0,00"
                End If

                'Case "LANCHES"
                '    Dim I As Integer
                '    Dim intQtd As Integer = 0
                '    For I = 0 To Me.grd2.RowCount - 1
                '        If Me.grd2.GetRowCellValue(I, Me.colOk1) = True Then
                '            intQtd += 1
                '        End If
                '    Next

                '    If intQtd = 3 Then
                '        MsgBox("Só é permitido 2 tipos de recheios", MsgBoxStyle.Information)
                '        Me.grd2.SetRowCellValue(intIndex, Me.colOk1, False)
                '    End If
        End Select

        Calcular()
       
    End Sub

    Private Sub chkRecheio_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles chkRecheio.EditValueChanging

        Limparrecheio()
    End Sub
    Private Sub Limparrecheio()
        Select Case strBotao
            Case "SOBREMESAS", "BEBIDAS"
                Dim I As Integer
                For I = 0 To grd2.RowCount - 1
                    Me.tbRecheio.Rows.Item(I).Item("Ok") = False
                Next
        End Select
    End Sub

    Private Sub txtQtd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtd.Leave
        If Preco(Me.txtQtd) = False Then
            Me.txtQtd.Text = "1"
        End If
        Calcular()
    End Sub

    Private Sub txtAcrescimo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAcrescimo.Leave
        If Preco(Me.txtAcrescimo) = False Then
            Me.txtAcrescimo.Text = "0,00"
        End If
        Calcular()
    End Sub

    Private Sub txtValor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValor.Leave
        If Preco(Me.txtValor) = False Then
            Me.txtValor.Text = "0,00"
        End If
        Calcular()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Localizacao(Me.btnLanches, False, 46)
        Me.btnBebidas.Text = "Bebidas"
        Me.grpRecheio.Visible = True
        Me.tbRecheio.Rows.Clear()
        Me.tbProd.Rows.Clear()
        Me.tbProduto.Rows.Clear()

        LimparValores()
        Me.Close()
    End Sub

    Private Sub txtProdutos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProdutos.Click
        Dim intIndex As Integer = Me.grd1.FocusedRowHandle
        Dim bolCheck As Boolean = Me.grd1.GetRowCellValue(intIndex, Me.colOk2)
        LimparProduto()
        If bolCheck = False Then
            Me.grd1.SetRowCellValue(intIndex, Me.colOk2, True)
        Else
            Me.grd1.SetRowCellValue(intIndex, Me.colOk2, False)
        End If

        Me.chkProduto_EditValueChanged(sender, e)
    End Sub


    Private Sub txtRecheios_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRecheios.Click
        Dim intIndex As Integer = Me.grd2.FocusedRowHandle
        Dim bolCheck As Boolean = Me.grd2.GetRowCellValue(intIndex, Me.colOk1)
        Limparrecheio()
        If bolCheck = False Then
            Me.grd2.SetRowCellValue(intIndex, Me.colOk1, True)
        Else
            Me.grd2.SetRowCellValue(intIndex, Me.colOk1, False)
        End If


        Me.chkRecheio_EditValueChanged(sender, e)
    End Sub

    Private Sub txtAcompanhamentos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAcompanhamentos.Click
        Dim intIndex As Integer = Me.grd3.FocusedRowHandle
        Dim bolCheck As Boolean = Me.grd3.GetRowCellValue(intIndex, Me.colOk)

        If bolCheck = False Then
            Me.grd3.SetRowCellValue(intIndex, Me.colOk, True)
        Else
            Me.grd3.SetRowCellValue(intIndex, Me.colOk, False)
        End If
        Me.chkAcompanhamento_EditValueChanged(sender, e)

    End Sub

    Private Sub chkProduto_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles chkProduto.EditValueChanging
        LimparProduto()
    End Sub

    Private Sub txtSabor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSabor.Click
        Dim intIndex As Integer = Me.grd4.FocusedRowHandle
        Dim bolCheck As Boolean = Me.grd4.GetRowCellValue(intIndex, Me.colOk3)

        If bolCheck = False Then
            Me.grd4.SetRowCellValue(intIndex, Me.colOk3, True)
        Else
            Me.grd4.SetRowCellValue(intIndex, Me.colOk3, False)
        End If

    End Sub

   
End Class