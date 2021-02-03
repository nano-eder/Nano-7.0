Imports Nano.clsFuncoes
Public Class frmInventario

    Private Sub AtualizarGrid()
        CarregarDados("SELECT Inventario.Codigo, CodProd as CodProdAut, Inventario.ValorCusto, " & _
        "Inventario.CodConfig, sum(Inventario.Qtd) as Qtde, Inventario.QtdAntiga as QtdeAntiga, " & _
        "Inventario.Data, Inventario.Tamanho, Produto.CodigoInterno, Nome as Produto FROM " & _
        "Inventario left join Produto on Inventario.CodProd = Produto.Codigo " & _
        "where " & String.Format("Inventario.Data = '{0:dd/MM/yyyy}'", Me.dtData.EditValue) & " and " & _
        "CodConfig = " & CodConfig & " group by CodProd, CodigoInterno, CodConfig, Inventario.Data, " & _
        "Nome, QtdAntiga, Tamanho, Inventario.ValorCusto, Inventario.Codigo order by Inventario.Codigo", Me.GridControl1)

        Me.grd1.FocusedRowHandle = Me.grd1.RowCount - 1

        If EstoqueSomado = True Then
            CarregarDados("SELECT Produto.Fabricante as Fornecedor, Produto.Inativo, Produto.Codigo as CodProdAut, Produto.Nome as Produto, " & _
            "Produto.CodigoInterno, Qtde.CodConfig, (SELECT case when sum(EntradaNf.QtdProd) is null then 0 " & _
            "else sum(EntradaNf.QtdProd) end FROM EntradaNf left join TotalEntradaNf on EntradaNf.CodTotNf = " & _
            "TotalEntradaNf.Codigo where EntradaNf.CodProd = Produto. Codigo and EstoqueOk = 'True' and " & _
            "EntradaNf.CodConfig = " & CodConfig & ") - (SELECT case when sum(Pedido.Qtd) is null then 0 else " & _
            "sum(Pedido.Qtd) end FROM Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and PEdido.CodConfig = Total.CodConfig where Pedido.CodConfig = " & CodConfig & " and Pedido.CodProd = " & _
            "Produto.Codigo and Pedido.Devolvido = 'False') + (SELECT case when sum(AjusteQtde.Qtd) is null then 0 " & _
            "else  sum(AjusteQtde.Qtd) end FROM AjusteQtde where AjusteQtde.CodConfig = " & CodConfig & " and " & _
            "AjusteQtde.CodProd = Produto.Codigo) as Qtde, Produto.Grupo, Produto.Setor " & _
            "FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd and Produto.Inativo = 'False' and " & _
            "Qtde.Acabou = 'False' WHERE not exists (SELECT Inventario.CodProd, Inventario.CodConfig FROM " & _
            "Inventario where Inventario.CodProd = Produto.Codigo and Inventario.CodConfig = Qtde.CodConfig " & _
            "and " & String.Format("Inventario.Data = '{0:dd/MM/yyyy}'", Me.dtData.EditValue) & ") " & _
            "and Qtde.CodConfig = " & CodConfig & " Group by Produto.Inativo, Produto.Codigo, Produto.Nome, " & _
            "Produto.CodigoInterno, Qtde.CodConfig, Produto.Grupo, Produto.Setor, Produto.Fabricante", Me.GridControl2)
        Else
            CarregarDados("SELECT Produto.Fabricante as Fornecedor, Produto.Inativo, Produto.Codigo as CodProdAut, Produto.Nome as Produto, " & _
            "Produto.CodigoInterno, Qtde.CodConfig, sum(Qtde.Qtd) as Qtde, Produto.Grupo, Produto.Setor " & _
            "FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd and Produto.Inativo = 'False' and " & _
            "Qtde.Acabou = 'False' WHERE not exists (SELECT Inventario.CodProd, Inventario.CodConfig FROM " & _
            "Inventario where Inventario.CodProd = Produto.Codigo and Inventario.CodConfig = Qtde.CodConfig " & _
            "and " & String.Format("Inventario.Data = '{0:dd/MM/yyyy}'", Me.dtData.EditValue) & ") " & _
            "and Qtde.CodConfig = " & CodConfig & " Group by Produto.Inativo, Produto.Codigo, Produto.Nome, " & _
            "Produto.CodigoInterno, Qtde.CodConfig, Produto.Grupo, Produto.Setor, Produto.Fabricante", Me.GridControl2)
        End If

        Calcular()
        Fundo()
    End Sub

    Private Sub frmInventario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "80")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub Fundo()
        If Me.grd1.RowCount = 0 Then
            Me.picFundo.Visible = True
        Else
            Me.picFundo.Visible = False
        End If
    End Sub
    Private Sub Calcular()
        Dim dblItens As Double

        Dim I As Integer


        For I = 0 To grd1.RowCount - 1

            dblItens += Me.grd1.GetRowCellDisplayText(I, Me.colQtde)

        Next
        Me.grpItens.Text = "Nº Itens : " & grd1.RowCount & " "

        dblItens = 0
        For I = 0 To Me.grd2.RowCount - 1
            dblItens += Me.grd2.GetRowCellDisplayText(I, Me.colQtde2)
        Next
        Me.GroupControl1.Text = "Nº Itens : " & Me.grd2.RowCount & " "

    End Sub

    Private Sub txtCodPro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodPro.KeyDown
        If e.KeyCode = Keys.F10 Then
            Dim frm As New frmConProduto
            frm.Tag = "VENDA"
            CodigoDoProduto = -1
            frm.ShowDialog()
            If CodigoDoProduto = -1 Then Exit Sub
            InserirProduto(True)
        End If

        If e.KeyCode = Keys.Enter Then
            If Me.txtCodPro.Text.Trim = "" Then
                Me.txtQtd.Focus()
                Exit Sub
            End If

            InserirProduto(False)

        End If
    End Sub
   
    Private Sub InserirProduto(ByVal parPesquisaPorNome As Boolean)
        If Validar(Me.dtData) = False Then Exit Sub


        Dim strTamanhoCod As String = ""
        Dim strCodProTam As String = ""

        Dim dtStatus As DataTable = CarregarDataTable("SELECT Status FROM Inventario where CodConfig = " & CodConfig & "" & _
        " and " & String.Format("Data = '{0:dd/MM/yyyy}'", Me.dtData.EditValue))
        If dtStatus.Rows.Count > 0 Then
            Dim strStatus As String = dtStatus.Rows.Item(0).Item("Status").ToString
            If strStatus = "Atualizado" Then
                MsgBox("Inventário ja atualizado nesta data!", MsgBoxStyle.Information)
                Me.dtData.ResetText()
                Me.txtCodPro.ResetText()
                Me.txtQtd.ResetText()
                Me.dtData.Focus()
            End If
        End If


        Dim dtProd As DataTable
        If parPesquisaPorNome = False Then
            If Me.txtCodPro.Text = "" Then Exit Sub
            Dim vetCod As Array = Split(Me.txtCodPro.Text.Trim, "-")
            strCodProTam = vetCod(0).ToString
            Me.txtCodPro.Text = strCodProTam
            If vetCod.Length > 1 Then
                strTamanhoCod = vetCod(1).ToString
            End If

            dtProd = CarregarDataTable("Select Produto.Codigo, Produto.Nome, Produto.CodigoInterno, ValorCusto, Inativo from Produto where CodigoInterno ='" & Me.txtCodPro.Text.Trim & "' or CodigoBarra = '" & Me.txtCodPro.Text.Trim & "'")

            If dtProd.Rows.Count = 0 Then
                Dim dtCodBarra As DataTable = CarregarDataTable("SELECT CodProd FROM CodigoBarra where CodigoBarra = '" & Me.txtCodPro.Text & "' and Produto = '' or CodigoBarra = '" & Me.txtCodPro.Text & "' and Produto is null")
                If dtCodBarra.Rows.Count > 0 Then
                    CodigoDoProduto = dtCodBarra.Rows.Item(0).Item("CodProd").ToString
                    dtProd = CarregarDataTable("Select Produto.Codigo, Produto.Nome, Produto.CodigoInterno, ValorCusto, Inativo from Produto where Codigo=" & CodigoDoProduto)
                End If
            End If
        Else
            dtProd = CarregarDataTable("Select Produto.Codigo, Produto.Nome, Produto.CodigoInterno, ValorCusto, Inativo from Produto where Codigo=" & CodigoDoProduto)
            If dtProd.Rows.Count > 0 Then
                Me.txtCodPro.Text = dtProd.Rows.Item(0).Item("CodigoInterno")
            End If
        End If

       If dtProd.Rows.Count > 0 Then

            With dtProd.Rows.Item(0)
                If dtProd.Rows.Item(0).Item("Inativo") = True Then
                    MsgBox("Produto Inativo!", MsgBoxStyle.Information)
                    Me.txtCodPro.ResetText()
                    'Me.txtCodPro.Focus()
                    Exit Sub
                End If
                Dim intCodProdAut As Integer

                intCodProdAut = .Item(0).ToString
                Dim dblQtdAdd As Double

                If Me.txtQtd.Text = "" Then
                    dblQtdAdd = 1
                Else
                    dblQtdAdd = Me.txtQtd.Text.Trim
                End If

                If strTamanhoCod = "" Then
                    TamanhoDoProduto = "U"
                End If

                Dim strSql As String = "Select Tamanho, sum(Qtd) as Qtd from Qtde where CodProd =" & intCodProdAut & " and Acabou = 'False' and CodConfig =" & CodConfig & " group by Tamanho"

                Dim dtQtd As DataTable = CarregarDataTable(strSql)


                If strTamanhoCod = "" Then
                    If dtQtd.Rows.Count > 1 Then
                        frmTamanhoProd.Tag = strSql
                        frmTamanhoProd.ShowDialog()
                    Else
                        If dtQtd.Rows.Count > 0 Then
                            TamanhoDoProduto = dtQtd.Rows.Item(0).Item("Tamanho")
                        End If
                    End If
                Else
                    TamanhoDoProduto = strTamanhoCod
                End If
                Dim dblQtdAntiga As Double = 0

                If EstoqueSomado = True Then
                    dblQtdAntiga = AjusteQtde(CodConfig, intCodProdAut)
                Else
                    Dim dtQtd2 As DataTable = CarregarDataTable("Select Qtd from Qtde where CodProd =" & intCodProdAut & " and Tamanho ='" & TamanhoDoProduto & "' and Acabou = 'False'  and CodConfig = " & CodConfig)


                    If dtQtd2.Rows.Count > 0 Then
                        If dtQtd2.Rows.Item(0).Item("Qtd").ToString <> "" Then
                            dblQtdAntiga = dtQtd2.Rows.Item(0).Item("Qtd")
                        End If

                    End If
                End If
           
                'CodigoItem = .Item("CodigoItem").ToString
                'If dtProd.Rows.Count > 1 Then

                '    frmTamanhoProd.Tag = strSql
                '    frmTamanhoProd.ShowDialog()
                'End If

                Dim dblValorCusto As Double = 0
                If dtProd.Rows.Item(0).Item("ValorCusto").ToString <> "" Then
                    dblValorCusto = dtProd.Rows.Item(0).Item("ValorCusto")
                End If
                Me.txtCodPro.Tag = intCodProdAut

                Dim strCodigoInterno As String = .Item("CodigoInterno").ToString

                Dim dtInv As DataTable = CarregarDataTable("SELECT Codigo, Qtd FROM Inventario where CodProd = " & intCodProdAut & " and Tamanho ='" & TamanhoDoProduto & "' and CodConfig = " & CodConfig & "" & _
                " and " & String.Format("Data = '{0:dd/MM/yyyy}'", Me.dtData.EditValue))

                If dtInv.Rows.Count > 0 Then
                    JaAdicionado(dtInv.Rows.Item(0).Item("Codigo").ToString, dtInv.Rows.Item(0).Item("Qtd"), dblQtdAdd)
                    AtualizarGrid()
                    Me.txtCodPro.ResetText()
                    Me.txtQtd.ResetText()
                    'Me.txtCodPro.Focus()
                    Exit Sub
                End If

                Inserir("INSERT INTO Inventario (CodProd, CodConfig, Qtd, Data, QtdAntiga, Tamanho, ValorCusto, Status) VALUES (" & intCodProdAut & "," & _
                "'" & CodConfig & "'," & Num(dblQtdAdd) & ",'" & Me.dtData.EditValue & "'," & Num(dblQtdAntiga) & ",'" & TamanhoDoProduto & "'," & Num(dblValorCusto) & ",'Pendente')")

                AtualizarGrid()

                'MsgBox("Produto adicionado com sucesso!", MsgBoxStyle.Information)


                Me.txtCodPro.ResetText()
                Me.txtQtd.ResetText()
                ' Me.txtCodPro.Focus()
            End With
        Else
            Try

                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\aviso.wav")
                'PlaySound(My.Application.Info.DirectoryPath & "\aviso.mid")

            Catch ex As Exception

            End Try
            MsgBox("Produto não cadastrado!", MsgBoxStyle.Information)
            Me.txtCodPro.ResetText()
            Me.txtQtd.ResetText()
            ' Me.txtCodPro.Focus()
        End If
    End Sub
    Private Sub JaAdicionado(ByVal parCodigo As String, ByVal parQtd As Double, ByVal parQtdAdd As Double)

        Dim dblResul As Double = parQtd + parQtdAdd

        Atualizar("UPDATE Inventario SET Qtd = " & Num(dblResul) & " where Codigo = " & parCodigo)

    End Sub
    Private Sub txtQtd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtd.Leave

        'If Me.txtCodPro.Text.Trim = "" Then Exit Sub

        'Dim dtProd As DataTable = CarregarDataTable("Select Codigo, Nome, ValorCusto, Valor from Produto where CodigoInterno ='" & Me.txtCodPro.Text.Trim & "' or CodigoBarra = '" & Me.txtCodPro.Text.Trim & "'")

        'If dtProd.Rows.Count > 0 Then

        '    With dtProd.Rows.Item(0)
        '        Dim intCodProdAut As Integer

        '        intCodProdAut = .Item(0).ToString


        '        Inserir("INSERT INTO Inventario (CodProd, CodCondig, Qtd, Data) VALUES (" & intCodProdAut & "," & _
        '        "" & CodConfig & "," & Num(Me.txtQtd.Text) & ",'" & Me.dtData.EditValue & "')")

        '        AtualizarGrid()

        '        'MsgBox("Produto adicionado com sucesso!", MsgBoxStyle.Information)

        '        Me.txtCodPro.ResetText()
        '        Me.txtQtd.ResetText()
        '        Me.txtCodPro.Focus()
        '    End With
        'Else
        '    MsgBox("Produto não cadastrado!", MsgBoxStyle.Information)
        '    Me.txtCodPro.ResetText()
        '    Me.txtQtd.ResetText()
        '    Me.txtCodPro.Focus()
        '    Exit Sub
     
        Me.txtCodPro.Focus()


    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub dtData_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtData.Leave
        If dtData.Text = "" Then Exit Sub
        If NavBarGroup2.Expanded = False Then
            'Me.NavBarControl2.Size = New System.Drawing.Size(891, 280)
            'Me.NavBarControl2.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded
            NavBarGroup2.Expanded = True
            AtualizarGrid()

            'Me.NavBarControl2.Size = New System.Drawing.Size(891, 30)
            NavBarGroup2.Expanded = False
        Else
            AtualizarGrid()

        End If
  
    End Sub

    Private Sub NavBarGroup2_ItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NavBarGroup2.ItemChanged
        If NavBarGroup2.Expanded = True Then
            Me.NavBarControl2.Size = New System.Drawing.Size(891, 280)
        Else
            Me.NavBarControl2.Size = New System.Drawing.Size(891, 30)
        End If
    End Sub

    Private Sub btnAtualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAtualizar.ItemClick
       
        If MsgBox("Deseja realmente atualizar o estoque?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.grd1.ClearColumnsFilter()
            If Me.grd1.RowCount <= 0 Then MsgBox("Não existe item para ser atualizado!", MsgBoxStyle.Information) : Exit Sub
            Dim B As Integer = 0
            Dim I As Integer
            Dim strCodProduto As String = ""
            For I = 0 To Me.grd1.RowCount - 1
                Dim strCodigoInventario As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)
                Dim strCodProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodProdAut)
                Dim strCodItem As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoItem)
                Dim strTam As String = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho)
                Dim dblQtd As Double = 0
                Dim dblValCusto As Double = 0
                If Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto) <> "" Then
                    dblValCusto = Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto)
                End If
                If Me.grd1.GetRowCellDisplayText(I, Me.colQtde) <> "" Then
                    dblQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtde)
                End If


                If BaixaPorLote = True Then
                    If strCodProduto <> strCodProd Then
                        Atualizar("Update Qtde Set Acabou = 'True', Qtd =0, EmFalta = '1', DataFim = '" & My.Computer.Clock.LocalTime & "' where CodProd = " & strCodProd & " and CodConfig = " & CodConfig)
                        strCodProduto = strCodProd
                    End If
                    Dim intDia, intMes, intAno, intHora, intMinuto As Integer
                    Dim strLote As String

                    intDia = Date.Today.Day
                    intMes = Month(Now)
                    intAno = Year(Now)
                    intHora = Hour(Now)
                    intMinuto = Minute(Now)

                    strLote = intDia.ToString("00") & intMes.ToString("00") & intAno & "-" & intHora.ToString("00") & intMinuto.ToString("00")


                    Inserir("Insert Into Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, EmFalta, ValorCusto, " & _
                    "CodConfig, Acabou, DataFim) Values(" & strCodProd & ",'" & strTam & "'," & 1 & "," & _
                    "" & Num(dblQtd) & ",'" & strLote & "','" & 0 & "'," & Num(dblValCusto) & "," & CodConfig & ",'False','01/01/1900')")

                Else

                    Atualizar("UPDATE Qtde SET Qtd = " & Num(dblQtd) & ", EmFalta = '0' where CodProd = " & strCodProd & " and CodConfig = " & CodConfig)


                    If EstoqueSomado = True Then

                        Dim dblResul As Double = AjusteQtde(CodConfig, strCodProd)
                        'Dim dblResul As Double = AjusteQtdeData(CodConfig, strCodProd, "21/01/2019")
                        dblResul = dblQtd - dblResul
                        Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data, CodUser) VALUES (" & strCodProd & "," & Num(dblResul) & "," & CodConfig & ",'INVENTARIO','" & My.Computer.Clock.LocalTime & "'," & CodUser & ")")

                    End If

                End If
                Atualizar("UPDATE Inventario SET Status = 'Atualizado' WHERE Codigo = " & strCodigoInventario)

                'B = +1

                'If B = 500 Then
                '    Timer(20)
                '    B = 0
                'End If
            Next


            MsgBox("Produtos atualizados com sucesso!", MsgBoxStyle.Information)
        End If

        

    End Sub

    Private Sub btnInativar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInativar.ItemClick
        If MsgBox("Deseja realmente inativar os produtos não Adicionados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim index As Integer = -999997
            grd2.FocusedRowHandle = index
            grd2.FocusedColumn = Me.colProduto
            grd2.ShowEditor()
            Dim strCodInterno As String = ""
            Me.grd2.ClearColumnsFilter()
            Dim A As Integer = 0
            Dim I As Integer
            Dim B As Integer = 0
            Dim dtConfig As DataTable = CarregarDataTable("SELECT Codigo FROM Config")
            Dim intCofig As Integer = dtConfig.Rows.Count
            If intCofig = 1 Then
                For I = 0 To Me.grd2.RowCount - 1
                    If Me.grd2.GetRowCellValue(I, Me.colInativo) = True Then
                        Dim strCodigo As String = Me.grd2.GetRowCellDisplayText(I, Me.colCodProdAut2)
                        Atualizar("UPDATE Produto SET Inativo = 'True' where Codigo = " & strCodigo)
                        Dim strCodigoInterno As String = Me.grd2.GetRowCellDisplayText(I, Me.colCodigoInterno)


                        If A > 50 Then
                            A = 0
                            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                                      "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Produto Ativo'," & _
                                      "'Cód. Prod.: " & strCodInterno & " - INATIVO','INATIVO INV.','PRODUTO','ALTERAÇÃO'," & CodConfig & ")")


                            strCodInterno = ""
                        Else
                            strCodInterno &= strCodigoInterno & ","
                        End If

                        A += 1
                    End If


                Next

                If strCodInterno <> "" Then
                    Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                                                 "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Produto Ativo'," & _
                                                 "'Cód. Prod.: " & strCodInterno & " - INATIVO','INATIVO INV.','PRODUTO','ALTERAÇÃO'," & CodConfig & ")")
                End If
            ElseIf intCofig > 1 Then
                For I = 0 To Me.grd2.RowCount - 1
                    If Me.grd2.GetRowCellValue(I, Me.colInativo) = True Then
                        Dim strCodigoInterno As String = Me.grd2.GetRowCellDisplayText(I, Me.colCodigoInterno)

                        Dim strCodigo As String = Me.grd2.GetRowCellDisplayText(I, Me.colCodProdAut2)
                        If BaixaPorLote = True Then
                            Dim dblQtd As Double = 0
                            Dim dtQtd As DataTable = CarregarDataTable("SELECT sum(Qtd) as Qtd FROM Qtde where Acabou = 'False'")
                            If dtQtd.Rows.Count > 0 Then
                                If dtQtd.Rows.Item(0).Item("Qtd").ToString <> "" Then
                                    dblQtd = dtQtd.Rows.Item(0).Item("Qtd")
                                    If dblQtd = 0 Then
                                        Atualizar("UPDATE Produto SET Inativo = 'True' where Codigo = " & strCodigo)
                                    End If
                                End If
                            End If
                        Else
                            Dim dblQtd As Double = 0
                            Dim dtQtd As DataTable = CarregarDataTable("SELECT sum(Qtd) as Qtd FROM Qtde where CodProd = " & strCodigo)
                            If dtQtd.Rows.Count > 0 Then
                                If dtQtd.Rows.Item(0).Item("Qtd").ToString <> "" Then
                                    dblQtd = dtQtd.Rows.Item(0).Item("Qtd")
                                    If dblQtd <= 0 Then
                                        Atualizar("UPDATE Produto SET Inativo = 'True' where Codigo = " & strCodigo)
                                    End If
                                End If
                            End If
                        End If

                        If A > 50 Then
                            A = 0
                            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                                      "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Produto Ativo'," & _
                                      "'Cód. Prod.: " & strCodInterno & " - INATIVO','INATIVO INV.','PRODUTO','ALTERAÇÃO'," & CodConfig & ")")


                            strCodInterno = ""
                        Else
                            strCodInterno &= strCodigoInterno & ","
                        End If

                        A += 1

                    End If

                    'B = +1

                    'If B = 500 Then
                    '    Timer(20)
                    '    B = 0
                    'End If
                Next
                If strCodInterno <> "" Then
                    Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                                                 "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Produto Ativo'," & _
                                                 "'Cód. Prod.: " & strCodInterno & " - INATIVO','INATIVO INV.','PRODUTO','ALTERAÇÃO'," & CodConfig & ")")
                End If
            End If
            AtualizarGrid()

        End If
    End Sub

    Private Sub chkInativarTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInativarTodos.CheckedChanged
        Dim I As Integer
        Select Case Me.chkInativarTodos.Checked
            Case False
                Me.chkInativarTodos.Size = New System.Drawing.Size(194, 19)

                Me.chkInativarTodos.Text = "Inativar: Marcar Todos"
                For I = 0 To Me.grd2.RowCount - 1
                    Me.grd2.SetRowCellValue(I, Me.colInativo, False)
                Next
                
            Case True
                Me.chkInativarTodos.Size = New System.Drawing.Size(216, 19)

                Me.chkInativarTodos.Text = "Inativar: Desmarcar Todos"
                For I = 0 To Me.grd2.RowCount - 1
                    Me.grd2.SetRowCellValue(I, Me.colInativo, True)
                Next
              
              
        End Select
    End Sub

    
    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        Dim dtStatus As DataTable = CarregarDataTable("SELECT Status FROM Inventario where CodConfig = " & CodConfig & "" & _
        " and " & String.Format("Data = '{0:dd/MM/yyyy}'", Me.dtData.EditValue))
        If dtStatus.Rows.Count > 0 Then
            Dim strStatus As String = dtStatus.Rows.Item(0).Item("Status").ToString
            If strStatus = "Atualizado" Then
                MsgBox("Inventário ja atualizado nesta data!", MsgBoxStyle.Information)
                Me.dtData.ResetText()
                Me.txtCodPro.ResetText()
                Me.txtQtd.ResetText()
                Me.dtData.Focus()
                Exit Sub
            End If
        End If

        If Me.grd1.RowCount = 0 Then Exit Sub

        If MsgBox("Deseja realmente excluir o item selecionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim strCodigoInventario As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)
            Excluir("DELETE FROM Inventario where Codigo = " & strCodigoInventario)

            Me.grd1.DeleteRow(grd1.FocusedRowHandle)
            MsgBox("Item excluído com sucesso!", MsgBoxStyle.Information)
            AtualizarGrid()
            Me.txtCodPro.Focus()
        End If

    End Sub

    Private Sub btnZerar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnZerar.ItemClick

        If MsgBox("Deseja realmente zerar o estoque dos produtos não Adicionados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim index As Integer = -999997
            grd2.FocusedRowHandle = index
            grd2.FocusedColumn = Me.colProduto
            grd2.ShowEditor()

            Me.grd2.ClearColumnsFilter()
            Dim strCodInterno As String = ""
            Dim A As Integer = 0
            Dim I As Integer
            Dim B As Integer = 0
            For I = 0 To Me.grd2.RowCount - 1
                If Me.grd2.GetRowCellValue(I, Me.colInativo) = True Then
                    Dim strCodigo As String = Me.grd2.GetRowCellDisplayText(I, Me.colCodProdAut2)
                    Dim strCodigoInterno As String = Me.grd2.GetRowCellDisplayText(I, Me.colCodigoInterno)

                    Atualizar("UPDATE Qtde SET Qtd = 0, EmFalta = '1' where CodProd = " & strCodigo & " and CodConfig = " & CodConfig)
                  
                    If EstoqueSomado = True Then
                        Dim dblResul As Double = AjusteQtde(CodConfig, strCodigo)
                        dblResul = -dblResul
                        Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data, CodUser) VALUES (" & strCodigo & "," & Num(dblResul) & "," & CodConfig & ",'ZERAR PROD.','" & My.Computer.Clock.LocalTime & "'," & CodUser & ")")

                    End If


                    If A > 50 Then
                        A = 0
                        Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                                  "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Produto Zerado'," & _
                                  "'Cód. Prod.: " & strCodInterno & " - ZERADO','ZERAR INV.','PRODUTO','ALTERAÇÃO'," & CodConfig & ")")


                        strCodInterno = ""
                    Else
                        strCodInterno &= strCodigoInterno & ","
                    End If

                    A += 1
                End If

                'B = +1

                'If B = 500 Then
                '    Timer(20)
                '    B = 0
                'End If
            Next
            If strCodInterno <> "" Then
                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                                      "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Produto Zerado'," & _
                                      "'Cód. Prod.: " & strCodInterno & " - ZERADO','ZERAR INV.','PRODUTO','ALTERAÇÃO'," & CodConfig & ")")

            End If
            AtualizarGrid()
            MsgBox("Estoque dos produtos selecionados, zerados com sucesso!", MsgBoxStyle.Information)
        End If


        
    End Sub

    Private Sub btnVisuProd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisuProd.ItemClick
        Dim rel As New relInventarioProd

        rel.lblTitulo.Text = "Inventário Produtos Adicionados"
        rel.picLogo.Image = LogoTipo
        Dim I As Integer
        With rel.tbProd.Rows
            For I = 0 To Me.grd1.RowCount - 1
                .Add()
                .Item(I).Item("Codigo") = Me.grd1.GetRowCellDisplayText(I, Me.colCodProd)
                .Item(I).Item("Produto") = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                .Item(I).Item("Qtd") = Me.grd1.GetRowCellDisplayText(I, Me.colQtde)
                .Item(I).Item("Tamanho") = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho)
                .Item(I).Item("QtdAntiga") = Me.grd1.GetRowCellDisplayText(I, Me.colQtdeAntiga)
                .Item(I).Item("Data") = Me.grd1.GetRowCellDisplayText(I, Me.colData)
            Next
        End With

        rel.lblTotalItens.Text = Me.grd1.RowCount
        rel.ShowPreview()
    End Sub

    Private Sub btnVisuProdN_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisuProdN.ItemClick
        Dim rel As New relInventarioProd
        Dim index As Integer = -999997
        grd2.FocusedRowHandle = index
        grd2.FocusedColumn = Me.colCodigo

        grd2.ShowEditor()
        rel.lblTitulo.Text = "Inventário Produtos não Adicionados"
        rel.picLogo.Image = LogoTipo
        Dim I As Integer
        With rel.tbProd.Rows
            For I = 0 To Me.grd2.RowCount - 1
                .Add()
                .Item(I).Item("Codigo") = Me.grd2.GetRowCellDisplayText(I, Me.colCodigoInterno)
                .Item(I).Item("Produto") = Me.grd2.GetRowCellDisplayText(I, Me.colProduto2)
                .Item(I).Item("Qtd") = Me.grd2.GetRowCellDisplayText(I, Me.colQtde2)
                Dim strff As String = Me.grd2.GetRowCellValue(I, Me.colInativo)
                If Me.grd2.GetRowCellValue(I, Me.colInativo) <> "False" And Me.grd2.GetRowCellValue(I, Me.colInativo) <> "True" Then
                    .Item(I).Item("Zerar") = False
                Else
                    .Item(I).Item("Zerar") = Me.grd2.GetRowCellValue(I, Me.colInativo)
                End If

                .Item(I).Item("CodConfig") = Me.grd2.GetRowCellDisplayText(I, Me.colCodigoItem)
            Next
        End With
        rel.colZerar.Visible = True
        rel.colZerar.VisibleIndex = 3
        rel.colProduto.Width = 160
        rel.colCodProd.Width = 40
        rel.colQtde.Width = 40
        rel.colZerar.Width = 40
        rel.colCodConfig.Width = 40
        rel.colQtdeAntiga.Visible = False
        rel.colTamanho.Visible = False
        rel.colData.Visible = False
        If Master = True Then
            rel.colCodConfig.Visible = True

        End If
        rel.lblTotalItens.Text = Me.grd2.RowCount
        rel.ShowPreview()
    End Sub


    Private Sub frmInventario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If TipoNano = 5 Then
            Me.picFundo.EditValue = Global.Nano.My.Resources.Resources.NANOAutomotivo
        End If
    End Sub

    Private Sub Timer(ByVal parSegundos As Integer)
        Dim intSeg As Integer = Second(Now)
        intSeg += parSegundos

        If intSeg > 59 Then
            intSeg = intSeg - 59
        End If
        Dim bolOk As Boolean = False
        While bolOk = False
            Dim intSegundo As Integer = Second(Now)

            If intSeg = intSegundo Then
                bolOk = True
            End If

        End While
    End Sub
End Class