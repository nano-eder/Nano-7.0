Imports Nano.clsFuncoes

Public Class frmConInventario

    Private Sub frmConInventario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "108")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmConInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnFiltrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFiltrar.ItemClick

        Dim data1 As String
        data1 = dtData.EditValue

        If data1 = "" Then MsgBox("Selecione a Data!", MsgBoxStyle.Information) : Exit Sub

        'If Master = True Then
        '    CarregarDados("SELECT Produto.Codigo as CodProd, Produto.Nome as Produto, Produto.CodigoInterno, " & _
        '    "Config.Descricao as CodConfig, (SELECT Inventario.Qtd FROM Inventario where Inventario.CodProd = Produto.Codigo " & _
        '    "and Inventario.CodConfig = Qtde.CodConfig and " & String.Format("Inventario.Data = '{0:dd/MM/yyyy}'", Me.dtData.EditValue) & ")" & _
        '    "as QtdInventario, (SELECT Inventario.QtdAntiga FROM Inventario where Inventario.CodProd = Produto.Codigo " & _
        '    "and Inventario.CodConfig = Qtde.CodConfig and " & String.Format("Inventario.Data = '{0:dd/MM/yyyy}'", Me.dtData.EditValue) & ")" & _
        '    "as QtdAntiga, (SELECT Inventario.Qtd - Inventario.QtdAntiga FROM Inventario where Inventario.CodProd = Produto.Codigo " & _
        '    "and Inventario.CodConfig = Qtde.CodConfig and " & String.Format("Inventario.Data = '{0:dd/MM/yyyy}'", Me.dtData.EditValue) & ")" & _
        '    "as Diferenca, " & String.Format("'{0:dd/MM/yyyy}'", Me.dtData.EditValue) & " as Data FROM (Produto left join Qtde on " & _
        '    "Produto.Codigo = Qtde.CodProd) left join Config on Qtde.CodConfig = Config.Codigo", Me.GridControl1)
        'Else
        '    CarregarDados("SELECT Produto.Codigo as CodProd, Produto.Nome as Produto, Produto.CodigoInterno, " & _
        '    "Config.Descricao as CodConfig, (SELECT Inventario.Qtd FROM Inventario where Inventario.CodProd = Produto.Codigo " & _
        '    "and Inventario.CodConfig = Qtde.CodConfig and " & String.Format("Inventario.Data = '{0:dd/MM/yyyy}'", Me.dtData.EditValue) & ")" & _
        '    "as QtdInventario, (SELECT Inventario.QtdAntiga FROM Inventario where Inventario.CodProd = Produto.Codigo " & _
        '    "and Inventario.CodConfig = Qtde.CodConfig and " & String.Format("Inventario.Data = '{0:dd/MM/yyyy}'", Me.dtData.EditValue) & ")" & _
        '    "as QtdAntiga, (SELECT Inventario.Qtd - Inventario.QtdAntiga FROM Inventario where Inventario.CodProd = Produto.Codigo " & _
        '    "and Inventario.CodConfig = Qtde.CodConfig and " & String.Format("Inventario.Data = '{0:dd/MM/yyyy}'", Me.dtData.EditValue) & ")" & _
        '    "as Diferenca, " & String.Format("'{0:dd/MM/yyyy}'", Me.dtData.EditValue) & " as Data FROM (Produto left join Qtde on " & _
        '    "Produto.Codigo = Qtde.CodProd) left join Config on Qtde.CodConfig = Config.Codigo where Qtde.CodConfig = " & CodConfig, Me.GridControl1)
        'End If


        If Master = True Then
            CarregarDados("SELECT Produto.Codigo as CodProd, Produto.Nome as Produto, Produto.CodigoInterno, " & _
            "Config.Descricao as CodConfig, Inventario.Qtd as QtdInventario, Inventario.QtdAntiga as QtdAntiga, " & _
            "Inventario.Qtd - Inventario.QtdAntiga as Diferenca," & String.Format("'{0:dd/MM/yyyy}'", Me.dtData.EditValue) & " as Data  " & _
            "FROM (Inventario left join Produto on Inventario.CodProd = Produto.Codigo) left join Config " & _
            "on Inventario.CodConfig = Config.Codigo where " & String.Format("Inventario.Data = '{0:dd/MM/yyyy}'", Me.dtData.EditValue), Me.GridControl1)


        Else
            CarregarDados("SELECT Produto.Codigo as CodProd, Produto.Nome as Produto, Produto.CodigoInterno, " & _
            "Config.Descricao as CodConfig, Inventario.Qtd as QtdInventario, Inventario.QtdAntiga as QtdAntiga, " & _
            "Inventario.Qtd - Inventario.QtdAntiga as Diferenca," & String.Format("'{0:dd/MM/yyyy}'", Me.dtData.EditValue) & " as Data  " & _
            "FROM (Inventario left join Produto on Inventario.CodProd = Produto.Codigo) left join Config " & _
            "on Inventario.CodConfig = Config.Codigo where Inventario.CodConfig = " & CodConfig & " and " & _
            "" & String.Format("Inventario.Data = '{0:dd/MM/yyyy}'", Me.dtData.EditValue), Me.GridControl1)

        End If
    End Sub

    Private Sub btnVisualiazar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualiazar.ItemClick
        Dim rel As New relInventario

        rel.picLogo.Image = LogoTipo
        rel.lblTitulo.Text = "Relatório de Inventário " & Me.dtData.EditValue
        Dim A As Integer = 0
        Dim I As Integer
        With rel.tbProd.Rows
            For I = 0 To Me.grd1.RowCount - 1
                If Me.grd1.GetRowCellDisplayText(I, Me.colProduto) <> "" Then
                    .Add()
                    .Item(A).Item("CodProd") = Me.grd1.GetRowCellDisplayText(I, Me.colCodProd)
                    .Item(A).Item("CodigoItem") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoItem)
                    .Item(A).Item("Produto") = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                    .Item(A).Item("Qtd") = Me.grd1.GetRowCellDisplayText(I, Me.colQtde)
                    .Item(A).Item("Tipo") = Me.grd1.GetRowCellDisplayText(I, Me.colTipo)
                    .Item(A).Item("QtdInventario") = Me.grd1.GetRowCellDisplayText(I, Me.colQtdInventario)
                    .Item(A).Item("Diferenca") = Me.grd1.GetRowCellDisplayText(I, Me.colDiferenca)
                    A += 1
                End If

            Next
        End With

        rel.ShowPreview()
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub
End Class