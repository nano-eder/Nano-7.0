Imports Nano.clsFuncoes
Public Class frmAtivarProduto

    Private Sub CarregarGrid()
        CarregarDados("SELECT Codigo, CodigoInterno, CodigoBarra, Nome as Produto, Grupo, Produto.Fabricante as Fornecedor, case when Inativo = 'True' then 'False' else Inativo end as Inativo FROM Produto where Inativo = 'True'", Me.GridControl1)
        Me.txtQtdPro.Text = Me.grd1.RowCount
    End Sub

    Private Sub frmAtivarProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "81")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmAtivarProduto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarGrid()
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)
        Dim index As Integer = -999997
        grd1.FocusedRowHandle = index
        grd1.FocusedColumn = Me.colProduto
        grd1.ShowEditor()
    End Sub

    Private Sub btnAtivar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAtivar.ItemClick

        If MsgBox("Deseja realmente ativar os produtos selecionados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim index As Integer = -999997
            grd1.FocusedRowHandle = index
            grd1.FocusedColumn = Me.colProduto
            grd1.ShowEditor()
            grd1.ClearColumnsFilter()
            Dim I As Integer
            Dim bolAtivar As Boolean = False
            For I = 0 To Me.grd1.RowCount - 1

                If Me.grd1.GetRowCellValue(I, Me.colAtivar) = True Then
                    Dim strCodigo As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)
                    Dim strProduto As String = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                    bolAtivar = True

                    Atualizar("UPDATE Produto set Inativo = 'False' where Codigo = " & strCodigo)
                    If BaixaPorLote = True Then
                        Atualizar("Update Qtde Set Acabou = 'True', Qtd =0, EmFalta = '1' where CodProd = " & strCodigo)

                    Else

                        Atualizar("UPDATE Qtde Set Qtd = 0 Where CodProd = " & strCodigo)

                        If EstoqueSomado = True Then

                            Dim A As Integer
                            For A = 0 To QtdeLoja - 1



                                Dim strLoja As String = A + 1


                                Dim dblResul As Double = AjusteQtde(strLoja, strCodigo)


                                dblResul = dblResul - (dblResul + dblResul)
                                Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data, CodUser) VALUES (" & strCodigo & "," & Num(dblResul) & "," & strLoja & ",'ATIVAR PROD.','" & My.Computer.Clock.LocalTime & "'," & CodUser & ")")


                            Next

                        End If
                    End If
                    Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                    "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Produto Inativo'," & _
                    "'" & strProduto & " - ATIVO','INATIVO','PRODUTO','ALTERAÇÃO'," & CodConfig & ")")

                End If
            Next

            If bolAtivar = True Then
                MsgBox("Produtos ativos com sucesso!", MsgBoxStyle.Information)
            Else
                MsgBox("Nenhum produto selecionado!", MsgBoxStyle.Information)
            End If

            CarregarGrid()

        End If

    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relProduto

        rel.picLogo.Image = LogoTipo
        rel.lblTitulo.Text = "Relatório de Produtos Inativos"
        With rel.tbProd.Rows
            Dim I As Integer
            Dim A As Integer = 0

            For I = 0 To Me.grd1.RowCount - 1
                If Me.grd1.GetRowCellDisplayText(I, Me.colProduto) <> "" Then
                    .Add()
                    .Item(A).Item("CodigoInterno") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)
                    .Item(A).Item("CodigoBarra") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoBarra)
                    .Item(A).Item("Nome") = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                    .Item(A).Item("Grupo") = Me.grd1.GetRowCellDisplayText(I, Me.colGrupo)
                    A += 1
                End If
            Next
        End With
        rel.colQtd.Visible = False
        rel.colValorUnitario.Visible = False
        rel.ShowPreview()
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Me.txtQtdPro.Text = Me.grd1.RowCount
    End Sub
    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub
End Class