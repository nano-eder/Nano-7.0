Imports Nano.clsFuncoes
Public Class frmConProdTam

    Private Sub frmConProdTam_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmConProdTam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarDados("SELECT Nome as Produto, Qtde.Tamanho, sum(Qtde.Qtd) as Qtd, Locacao, CodigoInterno, " & _
        "CodigoBarra, Grupo, Setor, Valor, Qtde.ValorCusto, UnidadeMedida, CodProdFor, Fabricante as Fornecedor, " & _
        "Data, Tipo, Obs FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd " & _
        "where CodConfig = " & CodConfig & " and Produto.Inativo = 'False' group by Nome, Tamanho, Locacao, CodigoInterno, " & _
        "CodigoBarra, Grupo, Setor, Valor, Qtde.ValorCusto, UnidadeMedida, CodProdFor, " & _
        "Fabricante, Data, Tipo, Obs", Me.GridControl1)
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)

    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relProdTam
        rel.picLogo.Image = LogoTipo
        Dim I As Integer
        With rel.tbProd.Rows
            For I = 0 To grd1.RowCount - 1
                .Add()
                .Item(I).Item("Produto") = grd1.GetRowCellDisplayText(I, Me.colProduto)
                .Item(I).Item("Tamanho") = grd1.GetRowCellDisplayText(I, Me.colTamanho)
                .Item(I).Item("Qtd") = grd1.GetRowCellDisplayText(I, Me.colQtd)
                .Item(I).Item("Locacao") = grd1.GetRowCellDisplayText(I, Me.colLocacao)
                .Item(I).Item("CodigoInterno") = grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)
                .Item(I).Item("CodigoBarra") = grd1.GetRowCellDisplayText(I, Me.colCodigoBarra)
                .Item(I).Item("Grupo") = grd1.GetRowCellDisplayText(I, Me.colGrupo)

            Next

            If Me.colGrupo.Visible = False Then
                rel.colGrupo.Visible = False
            End If
            If Me.colCodigoBarra.Visible = False Then
                rel.colCodigoBarra.Visible = False
            End If
            rel.ShowPreview()

        End With
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub
End Class