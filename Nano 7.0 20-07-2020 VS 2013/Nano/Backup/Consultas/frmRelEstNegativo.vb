Imports Nano.clsFuncoes
Public Class frmRelEstNegativo
    Dim intCodConfig As Integer

    Private Sub frmRelEstNegativo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "77")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmRelEstNegativo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub

        'Me.ConfigTableAdapter.Fill(Me.DsNanoCommerce.Config)
        CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoj)

        intCodConfig = CodConfig
        If Master = False Then
            Me.lueLoja.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnFiltrar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Else
            Me.lueLoja.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnFiltrar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If

        'CarregarDados("select Qtde.CodProd, Produto.CodigoInterno as CodigoProduto, Produto.Nome as Produto, " & _
        '"min(DataFim) as Data, sum(Pedido.Qtd) as Qtd, Total.Data FROM ((Qtde left join Produto on Qtde.CodProd = " & _
        '"Produto.Codigo) left join Pedido on Qtde.CodProd = Pedido.CodProd and Qtde.CodConfig = Pedido.CodConfig) " & _
        '"left join Total on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig where " & _
        '"DataFim >'01/01/1910' and Qtde.CodConfig = " & CodConfig & " and Produto.Inativo = 'False' group by " & _
        '"Qtde.CodProd, Produto.CodigoInterno, Produto.Nome, Total.Data, DataFim, Total.Hora having " & _
        '"(Total.Data + Total.Hora >= Min(DataFim))", Me.GridControl1)

        If EstoqueSomado = True Then
            CarregarDados("SELECT Produto.Codigo as CodProd, Produto.Nome as Produto, Produto.CodigoInterno as CodigoProduto, " & _
            "(SELECT case when sum(EntradaNf.QtdProd) is null then 0 else sum(EntradaNf.QtdProd) end FROM EntradaNf left join " & _
            "TotalEntradaNf on EntradaNf.CodTotNf = TotalEntradaNf.Codigo where EntradaNf.CodProd = Produto.Codigo and " & _
            "EstoqueOk = 'True' and EntradaNf.CodConfig = " & CodConfig & ") - (SELECT case when sum(Pedido.Qtd) is null " & _
            "then 0 else sum(Pedido.Qtd) end FROM Pedido where Pedido.CodConfig = " & CodConfig & " and Pedido.CodProd = " & _
            "Produto.Codigo and Pedido.Devolvido = 'False') + (SELECT case when sum(AjusteQtde.Qtd) is null then 0 else " & _
            "sum(AjusteQtde.Qtd) end FROM AjusteQtde where AjusteQtde.CodConfig = " & CodConfig & " and AjusteQtde.CodProd = " & _
            "Produto.Codigo) as Qtd, convert(Varchar(10),max(DataFim),103) as Data FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where " & _
            "Produto.Inativo = 'False' and (SELECT case when sum(EntradaNf.QtdProd) is null then 0 else sum(EntradaNf.QtdProd) " & _
            "end FROM EntradaNf left join TotalEntradaNf on EntradaNf.CodTotNf = TotalEntradaNf.Codigo where EntradaNf.CodProd = " & _
            "Produto. Codigo and EstoqueOk = 'True' and EntradaNf.CodConfig = " & CodConfig & ") - (SELECT case when " & _
            "sum(Pedido.Qtd) is null then 0 else sum(Pedido.Qtd) end FROM Pedido where Pedido.CodConfig = " & CodConfig & " and " & _
            "Pedido.CodProd = Produto.Codigo and Pedido.Devolvido = 'False') + (SELECT case when sum(AjusteQtde.Qtd) is null " & _
            "then 0 else  sum(AjusteQtde.Qtd) end FROM AjusteQtde where AjusteQtde.CodConfig = " & CodConfig & " and " & _
            "AjusteQtde.CodProd = Produto.Codigo) < 0 group by Produto.Codigo, Produto.Nome, Produto.CodigoInterno", Me.GridControl1)
        Else
            CarregarDados("select Qtde.CodProd, Produto.CodigoInterno as CodigoProduto, Produto.Nome as Produto, " & _
            "convert(Varchar(10),max(DataFim),103) as Data, sum(Qtde.Qtd) as Qtd FROM Qtde left join Produto on Qtde.CodProd = " & _
            "Produto.Codigo where Qtde.CodConfig = " & CodConfig & " and Produto.Inativo = 'False' group by " & _
            "Qtde.CodProd, Produto.CodigoInterno, Produto.Nome having (sum(Qtde.Qtd)<0)", Me.GridControl1)
        End If
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub

    Private Sub btnVisu_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisu.ItemClick
        Dim I As Integer
        Dim A As Integer = 0

        Dim rel As New relEstNegativo

        rel.lblTitulo.Text = Me.Text
        rel.picLogo.Image = LogoTipo

        With rel.tbProd.Rows
            For I = 0 To Me.grd1.RowCount - 1
                If Me.grd1.GetRowCellDisplayText(I, Me.colProduto) <> "" Then
                    .Add()
                    .Item(A).Item("CodigoProduto") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto)
                    .Item(A).Item("Produto") = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                    .Item(A).Item("Qtd") = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                    .Item(A).Item("Data") = Me.grd1.GetRowCellDisplayText(I, Me.colData)
                    A += 1
                End If
            Next
        End With

        rel.ShowPreview()
    End Sub

    Private Sub btnFiltrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFiltrar.ItemClick

        If TesteConexao() = False Then Exit Sub

        'CarregarDados("select Qtde.CodProd, Produto.CodigoInterno as CodigoProduto, Produto.Nome as Produto, min(DataFim) as Data, sum(Pedido.Qtd) as Qtd, Total.Data FROM ((Qtde left join Produto on Qtde.CodProd = Produto.Codigo) left join Pedido on Qtde.CodProd = Pedido.CodProd and Qtde.CodConfig = Pedido.CodConfig) left join Total on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig where DataFim >'01/01/1910' and Qtde.CodConfig = " & intCodConfig & " and Produto.Inativo = 'False' group by Qtde.CodProd, Produto.CodigoInterno, Produto.Nome, Total.Data, DataFim, Total.Hora having (Total.Data + Total.Hora >= Min(DataFim))", Me.GridControl1)
        If EstoqueSomado = True Then
            CarregarDados("SELECT Produto.Codigo as CodProd, Produto.Nome as Produto, Produto.CodigoInterno as CodigoProduto, " & _
            "(SELECT case when sum(EntradaNf.QtdProd) is null then 0 else sum(EntradaNf.QtdProd) end FROM EntradaNf left join " & _
            "TotalEntradaNf on EntradaNf.CodTotNf = TotalEntradaNf.Codigo where EntradaNf.CodProd = Produto.Codigo and " & _
            "EstoqueOk = 'True' and EntradaNf.CodConfig = " & intCodConfig & ") - (SELECT case when sum(Pedido.Qtd) is null " & _
            "then 0 else sum(Pedido.Qtd) end FROM Pedido where Pedido.CodConfig = " & intCodConfig & " and Pedido.CodProd = " & _
            "Produto.Codigo and Pedido.Devolvido = 'False') + (SELECT case when sum(AjusteQtde.Qtd) is null then 0 else " & _
            "sum(AjusteQtde.Qtd) end FROM AjusteQtde where AjusteQtde.CodConfig = " & intCodConfig & " and AjusteQtde.CodProd = " & _
            "Produto.Codigo) as Qtd, convert(Varchar(10),max(DataFim),103) as Data FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where " & _
            "Produto.Inativo = 'False' and (SELECT case when sum(EntradaNf.QtdProd) is null then 0 else sum(EntradaNf.QtdProd) " & _
            "end FROM EntradaNf left join TotalEntradaNf on EntradaNf.CodTotNf = TotalEntradaNf.Codigo where EntradaNf.CodProd = " & _
            "Produto. Codigo and EstoqueOk = 'True' and EntradaNf.CodConfig = " & intCodConfig & ") - (SELECT case when " & _
            "sum(Pedido.Qtd) is null then 0 else sum(Pedido.Qtd) end FROM Pedido where Pedido.CodConfig = " & intCodConfig & " and " & _
            "Pedido.CodProd = Produto.Codigo and Pedido.Devolvido = 'False') + (SELECT case when sum(AjusteQtde.Qtd) is null " & _
            "then 0 else  sum(AjusteQtde.Qtd) end FROM AjusteQtde where AjusteQtde.CodConfig = " & intCodConfig & " and " & _
            "AjusteQtde.CodProd = Produto.Codigo) < 0 group by Produto.Codigo, Produto.Nome, Produto.CodigoInterno", Me.GridControl1)
        Else
            CarregarDados("select Qtde.CodProd, Produto.CodigoInterno as CodigoProduto, Produto.Nome as Produto, " & _
            "convert(Varchar(10),max(DataFim),103) as Data, sum(Qtde.Qtd) as Qtd FROM Qtde left join Produto on Qtde.CodProd = " & _
            "Produto.Codigo where Qtde.CodConfig = " & intCodConfig & " and Produto.Inativo = 'False' group by " & _
            "Qtde.CodProd, Produto.CodigoInterno, Produto.Nome having (sum(Qtde.Qtd)<0)", Me.GridControl1)
        End If
    End Sub

    Private Sub lueLoj_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueLoj.Leave
        If Me.lueLoja.EditValue <> Nothing Then
            intCodConfig = Me.lueLoja.EditValue
        End If
    End Sub

End Class