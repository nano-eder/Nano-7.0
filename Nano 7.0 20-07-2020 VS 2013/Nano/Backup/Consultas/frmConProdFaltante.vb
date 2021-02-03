
Imports Nano.clsFuncoes

Public Class frmConProdFaltante

    Private Sub frmConProdFaltante_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "78")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmConProdFaltante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConfigurarGrid(Me.GridView1, Me, True, Me.btnPadrao)
        'Me.ConfigTableAdapter.Fill(Me.DsNanoCommerce.Config)
        CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja)
        Dim strFiltro As String = ""
        Dim strFiltro1 As String = ""
        Dim strFiltro2 As String = ""
        Dim strFiltro3 As String = ""

        If Master = False Then
            strFiltro = " and CodConfig =" & CodConfig
            strFiltro1 = " and EntradaNf.CodConfig = " & CodConfig
            strFiltro2 = " and Pedido.CodConfig = " & CodConfig
            strFiltro3 = " and AjusteQtde.CodConfig = " & CodConfig
        End If

        If EstoqueSomado = True Then
            CarregarDados("SELECT Produto.Obs, Produto.Codigo as CodProd, Produto.Nome, Produto.CodigoInterno as CodInterno, QtdMinima as QtdMin, Tamanho, CodProdFor, Grupo, Setor, CodConfig, Fabricante, " & _
            "(SELECT case when sum(EntradaNf.QtdProd) is null then 0 else sum(EntradaNf.QtdProd) end FROM EntradaNf left join " & _
            "TotalEntradaNf on EntradaNf.CodTotNf = TotalEntradaNf.Codigo where EntradaNf.CodProd = Produto.Codigo and " & _
            "EstoqueOk = 'True' " & strFiltro1 & " and entradanf.codconfig = Qtde.codconfig ) - (SELECT case when sum(Pedido.Qtd) is null " & _
            "then 0 else sum(Pedido.Qtd) end FROM Pedido where Pedido.CodProd = " & _
            "Produto.Codigo and Pedido.Devolvido = 'False' " & strFiltro2 & " and Pedido.codconfig = Qtde.codconfig ) + (SELECT case when sum(AjusteQtde.Qtd) is null then 0 else " & _
            "sum(AjusteQtde.Qtd) end FROM AjusteQtde where AjusteQtde.CodProd = " & _
            "Produto.Codigo " & strFiltro3 & " and AjusteQtde.codconfig = Qtde.codconfig ) as Qtd FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where " & _
            "Produto.Inativo = 'False' and (SELECT case when sum(EntradaNf.QtdProd) is null then 0 else sum(EntradaNf.QtdProd) " & _
            "end FROM EntradaNf left join TotalEntradaNf on EntradaNf.CodTotNf = TotalEntradaNf.Codigo where EntradaNf.CodProd = " & _
            "Produto. Codigo and EstoqueOk = 'True' " & strFiltro1 & " and entradanf.codconfig = Qtde.codconfig ) - (SELECT case when " & _
            "sum(Pedido.Qtd) is null then 0 else sum(Pedido.Qtd) end FROM Pedido where " & _
            "Pedido.CodProd = Produto.Codigo and Pedido.Devolvido = 'False' " & strFiltro2 & " and pedido.codconfig = Qtde.codconfig ) + (SELECT case when sum(AjusteQtde.Qtd) is null " & _
            "then 0 else  sum(AjusteQtde.Qtd) end FROM AjusteQtde where " & _
            "AjusteQtde.CodProd = Produto.Codigo " & strFiltro3 & " and AjusteQtde.codconfig = Qtde.codconfig ) <= QtdMinima", Me.GridControl1)

        Else
            CarregarDados("Select Produto.Obs, CodProd, QtdMinima as QtdMin, Qtd, Tamanho, CodigoInterno as CodInterno, " & _
            "CodProdFor, Nome, Grupo, Setor, CodConfig, Fabricante from Qtde left Join Produto on " & _
            "Qtde.CodProd = Produto.Codigo where QtdMinima >= Qtd and Acabou ='False'" & strFiltro & " and Produto.Inativo = 'False' order by Produto.Codigo", Me.GridControl1)

        End If

        If TipoNano = 5 Or TipoNano = 2 Then
            Me.colObs.Caption = "Aplicação"
            Me.colObs.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End If
    End Sub

    Private Sub btnClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub

    Private Sub btnRelCus_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCus.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub

    Private Sub btnRel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRel.ItemClick
        Dim I As Integer

        Dim rel As New relProdFalta

        With rel.tbProd.Rows

            rel.colCodConfig.Visible = Master

            For I = 0 To Me.GridView1.RowCount - 1
                .Add()
                .Item(I).Item("CodInterno") = Me.GridView1.GetRowCellDisplayText(I, Me.colCodInterno)
                .Item(I).Item("Nome") = Me.GridView1.GetRowCellDisplayText(I, Me.colNome)
                .Item(I).Item("Qtd") = Me.GridView1.GetRowCellDisplayText(I, Me.colQtd)
                .Item(I).Item("QtdMin") = Me.GridView1.GetRowCellDisplayText(I, Me.colQtdMin)
                .Item(I).Item("Grupo") = Me.GridView1.GetRowCellDisplayText(I, Me.colGrupo)
                .Item(I).Item("Setor") = Me.GridView1.GetRowCellDisplayText(I, Me.colSetor)
                .Item(I).Item("Tamanho") = Me.GridView1.GetRowCellDisplayText(I, Me.colTamanho)
                .Item(I).Item("CodConfig") = Me.GridView1.GetRowCellDisplayText(I, Me.colCodConfig)
                .Item(I).Item("Fabricante") = Me.GridView1.GetRowCellDisplayText(I, Me.colFabricante)

                .Item(I).Item("CodProdFor") = Me.GridView1.GetRowCellDisplayText(I, Me.colCodProdFor)
            Next

            rel.picLogo.Image = LogoTipo
            rel.ShowPreview()
        End With
    End Sub
    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.GridView1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub
End Class