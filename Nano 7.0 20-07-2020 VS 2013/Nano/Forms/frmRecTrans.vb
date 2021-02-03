Imports Nano.clsFuncoes
Public Class frmRecTrans

    Dim dtGrid As DataTable = Nothing

    Private Sub AtualizarGrid()
        CarregarDados("SELECT Transferencia.Codigo, Transferencia.CodOrdem, Transferencia.Data, CodProd, Convert(Numeric(15,2),Transferencia.Qtd) as Qtd, Transferencia.Tamanho, Convert(Numeric(15,2),Transferencia.ValorCusto) as ValorCusto, Transferencia.CodConfig as CodLoja, Transferencia.CodConfig, Transferencia.Status, CodUserSaida, CodigoInterno, Produto.Nome as Produto, Config.Descricao as Loja, convert(bit,case when EntSai = 'S' then 'False' end) as EntSai, Usuario.Nome as Usuario, Transferencia.Lote FROM ((Transferencia left join Produto on Transferencia.CodProd = Produto.Codigo) left join Config on TRansferencia.CodConfig = Config.Codigo) left join Usuario on Transferencia.CodUserSaida = Usuario.Codigo where CodLoja = " & CodConfig & " and Status = 'Enviado' order by Transferencia.Codigo", Me.GridControl1)
    End Sub

    Private Sub CarregarGrid()
        dtGrid = CarregarDataTable("SELECT Transferencia.Codigo, Transferencia.CodOrdem, Transferencia.Data, CodProd, Convert(Numeric(15,2),Transferencia.Qtd) as Qtd, Transferencia.Tamanho, Convert(Numeric(15,2),Transferencia.ValorCusto) as ValorCusto, Transferencia.CodConfig as CodLoja, Transferencia.CodConfig, Transferencia.Status, CodUserSaida, CodigoInterno, Produto.Nome as Produto, Config.Descricao as Loja, convert(bit,case when EntSai = 'S' then 'False' end) as EntSai, Usuario.Nome as Usuario, Transferencia.Lote FROM ((Transferencia left join Produto on Transferencia.CodProd = Produto.Codigo) left join Config on TRansferencia.CodConfig = Config.Codigo) left join Usuario on Transferencia.CodUserSaida = Usuario.Codigo where CodLoja = " & CodConfig & " and Status = 'Enviado' order by Transferencia.Codigo")
    End Sub

    Private Sub frmRecTrans_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "12")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub
    Private Sub frmRecTrans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub
        AtualizarGrid()
        CarregarGrid()

    End Sub

    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        If grd1.RowCount = 0 Then Exit Sub
        Dim Index As Integer = grd1.FocusedRowHandle
        If Index < 0 Then Exit Sub

        Dim intCod As Integer = grd1.GetRowCellDisplayText(Index, Me.colCodigo)

        If MsgBox("Deseja realmente excluir esse item dessa transferência?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If Excluir("Delete from Transferencia where Codigo = " & intCod) = True Then
                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & "" & "','EXCLUÍDO','NOME','CLIENTE','EXCLUSÃO'," & CodConfig & ")")
                MsgBox("Item da Transferência excluído com sucesso!", MsgBoxStyle.Information)
            End If

            AtualizarGrid()

        End If
    End Sub

    Private Sub btnOk_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOk.ItemClick

        If TesteConexao() = False Then Exit Sub

        Dim I As Integer
        Dim index As Integer = -999997
        grd1.FocusedRowHandle = index
        grd1.ShowEditor()
        grd1.ClearColumnsFilter()
        Me.grd1.ClearSorting()
        CarregarGrid()
        If grd1.RowCount <> dtGrid.Rows.Count Then
            AtualizarGrid()
            MsgBox("Produtos carregados na tabela foram alterados. A tabela sera atualizada!", MsgBoxStyle.Information)
            Exit Sub
        Else
            Try
                For A As Integer = 0 To Me.grd1.RowCount - 1
                    Dim strGrid As String = Me.grd1.GetRowCellDisplayText(A, Me.colCodigo)
                    Dim strDtGrid As String = dtGrid.Rows.Item(A).Item("Codigo").ToString

                    If strGrid <> strDtGrid Then
                        AtualizarGrid()
                        MsgBox("Produtos carregados na tabela foram alterados. A tabela sera atualizada!", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                Next
            Catch ex As Exception
                AtualizarGrid()
                MsgBox("Produtos carregados na tabela foram alterados. A tabela sera atualizada!", MsgBoxStyle.Information)
                Exit Sub
            End Try
        End If

        Dim strAuxiliar As String = ""
        Try
            strAuxiliar = NomeComputador.ToUpper & " Cód User:" & CodUser & " " & Format(My.Computer.Clock.LocalTime, "dd/MM/yyyy HH:mm:ss:fffff")
        Catch ex As Exception
            strAuxiliar = NomeComputador.ToUpper & " Cód User:" & CodUser & " " & Date.Today.Day & "/" & Date.Today.Month & "/" & Date.Today.Year & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now)
        End Try
        For I = 0 To Me.grd1.RowCount - 1
            Dim strCod As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)
            Dim strCodOrdem As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem)
            Dim strCodProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodProd)
            Dim strTamanho As String = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho)
            Dim strQtd As String = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
            Dim strloja As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodLoja)
            Dim strValorCusto As String = Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto)
            Dim strCodUserSaida As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodUserSaida)
            Dim bolStatus As Boolean = Me.grd1.GetRowCellValue(I, Me.colEntSai)
            Dim strLote As String = Me.grd1.GetRowCellDisplayText(I, Me.colLote)
            If bolStatus = True Then

                Atualizar("UPDATE Transferencia SET Status = 'Atendido' where Codigo = " & strCod)
                Inserir("INSERT INTO Transferencia (CodOrdem, CodProd, Tamanho, Qtd, ValorCusto, " & _
                "CodLoja, CodConfig, CodUserSaida, Data, Status, EntSai, CodUserEntrada, Lote, " & _
                "Auxiliar) VALUES (" & strCodOrdem & "," & strCodProd & ",'" & strTamanho & "'," & _
                "" & Num(strQtd) & "," & Num(strValorCusto) & "," & strloja & "," & CodConfig & "," & _
                "" & strCodUserSaida & ",'" & Date.Today & "','Atendido','E'," & CodUser & "," & _
                "'" & strLote & "','" & strAuxiliar & "')")

                Atualizar("UPDATE Qtde SET DataFim = '01/01/1900' where CodProd = " & strCodProd & " and CodConfig = " & CodConfig)

                If BaixaPorLote = True Then
                    Dim dt As DataTable = CarregarDataTable("SELECT Codigo, Qtd, QtdMinima FROM Qtde where Lote = '" & strLote & "' and Tamanho ='" & strTamanho & "' and CodConfig = " & CodConfig & " and CodProd = " & strCodProd)
                    If dt.Rows.Count > 0 Then
                        Dim dblQtd As Double = dt.Rows.Item(0).Item("Qtd").ToString
                        Dim dblQtdMin As Double = dt.Rows.Item(0).Item("QtdMinima").ToString
                        Dim dblResul As Double = dblQtd + Val(strQtd)
                        Dim intFalta As Integer

                        If dblResul <= dblQtdMin Then
                            intFalta = 1
                        Else
                            intFalta = 0
                        End If

                        Atualizar("UPDATE Qtde SET Qtd = " & Num(dblResul) & ", Acabou = 'False', EmFalta ='" & intFalta & "' where Codigo = " & dt.Rows.Item(0).Item("Codigo").ToString & " and CodConfig = " & CodConfig)
                    Else
                        Inserir("Insert Into Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, EmFalta, ValorCusto, CodConfig, Acabou, DataFim) Values(" & strCodProd & ",'" & strTamanho & "'," & 0 & "," & Num(strQtd) & ",'" & strLote & "','" & 0 & "'," & Num(strValorCusto) & "," & CodConfig & ",'False','01/01/1900')")

                    End If

                Else
                    Dim dt As DataTable = CarregarDataTable("SELECT Codigo, Qtd, QtdMinima FROM Qtde where CodConfig = " & CodConfig & " and CodProd = " & strCodProd)
                    Dim dblQtd As Double = 0
                    Dim intFalta As Integer

                    If dt.Rows.Count > 0 Then
                        dblQtd = dt.Rows.Item(0).Item("Qtd").ToString
                        Dim dblQtdMin As Double = dt.Rows.Item(0).Item("QtdMinima").ToString

                        Dim dblResul As Double = dblQtd + Val(strQtd)
                        If dblResul <= dblQtdMin Then
                            intFalta = 1
                        Else
                            intFalta = 0
                        End If
                        Atualizar("UPDATE Qtde SET Qtd = " & Num(dblResul) & ", Acabou = 'False', EmFalta ='" & intFalta & "'  where CodProd = " & strCodProd & " and CodConfig = " & CodConfig)

                    End If


                    If EstoqueSomado = True Then
                        dblQtd = strQtd
                        Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data, CodUser) VALUES (" & strCodProd & "," & Num(dblQtd) & "," & CodConfig & ",'TRANS. RECEBIDA','" & My.Computer.Clock.LocalTime & "'," & CodUser & ")")
                    End If
                End If


            End If

        Next

        MsgBox("Dados atendidos com sucesso!", MsgBoxStyle.Information)
        AtualizarGrid()
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relTrans

        rel.lblTitulo.Text = Me.Text
        rel.picLogo.Image = LogoTipo

        Dim I As Integer

        With rel.tbTrans.Rows
            For I = 0 To Me.grd1.RowCount - 1
                .Add()
                .Item(I).Item("CodOrdem") = Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem)
                .Item(I).Item("Data") = Me.grd1.GetRowCellDisplayText(I, Me.colData)
                .Item(I).Item("CodigoInterno") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)
                .Item(I).Item("Produto") = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                .Item(I).Item("Tamanho") = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho)
                .Item(I).Item("Qtd") = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                .Item(I).Item("Loja") = Me.grd1.GetRowCellDisplayText(I, Me.colLoja)
                .Item(I).Item("Usuario") = Me.grd1.GetRowCellDisplayText(I, Me.colUsuario)
                .Item(I).Item("ValorCusto") = Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto)
                .Item(I).Item("Lote") = Me.grd1.GetRowCellDisplayText(I, Me.colLote)
            Next
        End With

        rel.ShowPreview()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnCorrigir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCorrigir.ItemClick
        If TesteConexao() = False Then Exit Sub

        Dim I As Integer
        Dim index As Integer = -999997
        grd1.FocusedRowHandle = index
        grd1.ShowEditor()
        grd1.ClearColumnsFilter()
        Me.grd1.ClearSorting()
        CarregarGrid()
        If grd1.RowCount <> dtGrid.Rows.Count Then
            AtualizarGrid()
            MsgBox("Produtos carregados na tabela foram alterados. A tabela sera atualizada!", MsgBoxStyle.Information)
            Exit Sub
        Else
            Try
                For A As Integer = 0 To Me.grd1.RowCount - 1
                    Dim strGrid As String = Me.grd1.GetRowCellDisplayText(A, Me.colCodigo)
                    Dim strDtGrid As String = dtGrid.Rows.Item(A).Item("Codigo").ToString

                    If strGrid <> strDtGrid Then
                        AtualizarGrid()
                        MsgBox("Produtos carregados na tabela foram alterados. A tabela sera atualizada!", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                Next
            Catch ex As Exception
                AtualizarGrid()
                MsgBox("Produtos carregados na tabela foram alterados. A tabela sera atualizada!", MsgBoxStyle.Information)
                Exit Sub
            End Try
        End If


        For I = 0 To Me.grd1.RowCount - 1
            Dim strCod As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)
            Dim bolStatus As Boolean = Me.grd1.GetRowCellValue(I, Me.colEntSai)


            If bolStatus = True Then
                Atualizar("UPDATE Transferencia SET Status = 'Pendente' where Codigo = " & strCod)

                Dim strCodOrdem As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem)
                Dim strCodProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodProd)
                Dim strTamanho As String = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho)
                Dim strQtd As String = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                Dim strloja As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodLoja)
                Dim strValorCusto As String = Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto)
                Dim strCodUserSaida As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodUserSaida)

                Dim strLote As String = Me.grd1.GetRowCellDisplayText(I, Me.colLote)

                If BaixaPorLote = True Then
                    Dim dt As DataTable = CarregarDataTable("SELECT Codigo, Qtd, QtdMinima FROM Qtde where Lote = '" & strLote & "' and Tamanho ='" & strTamanho & "' and CodConfig = " & strloja & " and CodProd = " & strCodProd)
                    If dt.Rows.Count > 0 Then
                        Dim dblQtd As Double = dt.Rows.Item(0).Item("Qtd").ToString
                        Dim dblQtdMin As Double = dt.Rows.Item(0).Item("QtdMinima").ToString
                        Dim dblResul As Double = dblQtd - Val(strQtd)
                        Dim intFalta As Integer

                        If dblResul <= dblQtdMin Then
                            intFalta = 1
                        Else
                            intFalta = 0
                        End If

                        Atualizar("UPDATE Qtde SET Qtd = " & Num(dblResul) & ", Acabou = 'False', EmFalta ='" & intFalta & "' where Codigo = " & dt.Rows.Item(0).Item("Codigo").ToString & " and CodConfig = " & strloja)
                    Else
                        Inserir("Insert Into Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, EmFalta, ValorCusto, CodConfig, Acabou, DataFim) Values(" & strCodProd & ",'" & strTamanho & "'," & 0 & "," & Num(strQtd) & ",'" & strLote & "','" & 0 & "'," & Num(strValorCusto) & "," & strloja & ",'False','01/01/1900')")

                    End If

                Else
                    Dim dt As DataTable = CarregarDataTable("SELECT Codigo, Qtd, QtdMinima FROM Qtde where CodConfig = " & strloja & " and CodProd = " & strCodProd)
                    Dim dblQtd As Double = 0
                    Dim dblQtdMin As Double = 0
                    If dt.Rows.Count > 0 Then
                        dblQtd = dt.Rows.Item(0).Item("Qtd").ToString
                        dblQtdMin = dt.Rows.Item(0).Item("QtdMinima").ToString
                    End If


                    If EstoqueSomado = True Then
                        dblQtd = strQtd
                        Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data, CodUser) VALUES (" & strCodProd & "," & Num(dblQtd) & "," & strloja & ",'TRANS. CORRIGIR','" & My.Computer.Clock.LocalTime & "'," & CodUser & ")")

                        Dim dblResul As Double = AjusteQtde(strloja, strCodProd)

                        Dim intFalta As Integer

                        If dblResul <= dblQtdMin Then
                            intFalta = 1
                        Else
                            intFalta = 0
                        End If
                        Atualizar("UPDATE Qtde SET Qtd = " & Num(dblResul) & ", Acabou = 'False', EmFalta ='" & intFalta & "' where CodProd = " & strCodProd & " and CodConfig = " & strloja)

                    Else
                        Dim dblResul As Double = dblQtd - Val(strQtd)

                        Dim intFalta As Integer

                        If dblResul <= dblQtdMin Then
                            intFalta = 1
                        Else
                            intFalta = 0
                        End If
                        Atualizar("UPDATE Qtde SET Qtd = " & Num(dblResul) & ", Acabou = 'False', EmFalta ='" & intFalta & "' where CodProd = " & strCodProd & " and CodConfig = " & strloja)

                    End If
                End If
            End If

        Next
        MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information)
        AtualizarGrid()
    End Sub

    Private Sub chkSelecionarTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelecionarTodos.CheckedChanged
        Dim I As Integer
        Select Case Me.chkSelecionarTodos.Checked
            Case False
                For I = 0 To Me.grd1.RowCount - 1
                    Me.grd1.SetRowCellValue(I, Me.colEntSai, False)
                Next

            Case True
                For I = 0 To Me.grd1.RowCount - 1
                    Me.grd1.SetRowCellValue(I, Me.colEntSai, True)
                Next


        End Select
    End Sub
End Class