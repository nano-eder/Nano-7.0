Imports Nano.clsFuncoes
Public Class frmRelRevisao

    Private Sub frmRelRevisao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoAutomotivo.chm", HelpNavigator.TopicId, "106")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If

    End Sub

    Private Sub frmRelRevisao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsNano.Config' table. You can move, or remove it, as needed.
        'CarregarDadosLue2("SELECT * FROM Config", Me.lueLoja)

        'CarregarDados("SELECT * from Revisao", Me.RevisaoGridControl)

        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relRevisao

        Dim I As Integer

        rel.lblTitulo.Text = Me.Text
        rel.picLogo.Image = LogoTipo
        Dim A As Integer = 0
        With rel.tbRevisao.Rows
            For I = 0 To Me.grd1.RowCount - 1
                If Me.grd1.GetRowCellDisplayText(I, Me.colCodigoPedido) <> "" Then
                    .Add()
                    .Item(A).Item("Codigo") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)
                    .Item(A).Item("CodigoPedido") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoPedido)
                    .Item(A).Item("Placa") = Me.grd1.GetRowCellDisplayText(I, Me.colPlaca)
                    .Item(A).Item("Produto") = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                    .Item(A).Item("Revisao") = Me.grd1.GetRowCellDisplayText(I, Me.colRevisao)
                    .Item(A).Item("UltimoKM") = Me.grd1.GetRowCellDisplayText(I, Me.colUltimoKM)
                    .Item(A).Item("ProximoKM") = Me.grd1.GetRowCellDisplayText(I, Me.colProximoKM)
                    A += 1
                End If

            Next
        End With

        rel.ShowPreview()
    End Sub

    Private Sub btnDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        If MsgBox("Deseja realmente excluir a Revisão do Veículo '" & Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colPlaca) & "'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim strSql, strCod As String
            strCod = grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodigo)
            strSql = "Delete From Revisao where Codigo = " & strCod & " and CodConfig = " & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodConfig)
            Excluir(strSql)
            Me.grd1.DeleteRow(grd1.FocusedRowHandle)
        End If
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.RevisaoGridControl.ShowPrintPreview()
    End Sub
    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub
End Class