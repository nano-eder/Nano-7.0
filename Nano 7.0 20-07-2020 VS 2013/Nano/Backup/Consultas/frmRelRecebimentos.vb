Imports Nano.clsFuncoes
Public Class frmRelRecebimentos
    Dim strSql, strData As String
    Dim strFiltro As String = ""

    Private Sub frmRelRecebimentos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "35")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub
    Private Sub frmRelRecebimentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub

        CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja)

        Me.colCodConfig.Visible = Master

        strFiltro = " and CodConfig =" & CodConfig

        strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Date.Today.AddDays(-30), Date.Today)
        strSql = "select  Pagamento, CodConfig, Convert(Numeric(15,2),sum(Valor)) as Valor from Recebimento  where " & strData & strFiltro & " group by Pagamento, CodConfig"

        CarregarDados(strSql, Grid1)
    End Sub

    Private Sub Calcular()
        Dim dblLinha, dblResul As Double

        Dim I As Integer

        For I = 0 To grd1.RowCount - 1
            dblLinha = Me.grd1.GetRowCellDisplayText(I, Me.colValor)
            dblResul += dblLinha
        Next

        Me.txtTotal.Text = dblResul.ToString("###,###,##0.00")

    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Calcular()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnFiltrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFiltrar.ItemClick
        Dim data1, data2 As String
        data1 = dtInicial.EditValue
        data2 = dtFinal.EditValue

        If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Sub
        If data2 = "" Then MsgBox("Selecione a Data Final!", MsgBoxStyle.Information) : Exit Sub

        Dim dataFim, dataIni As Date
        dataIni = data1
        dataFim = data2

        If dataIni > dataFim Then MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information) : Exit Sub

        If TesteConexao() = False Then Exit Sub

        Dim strData As String
        strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue)

        CarregarDados("SELECT  Pagamento, CodConfig, Convert(Numeric(15,2),sum(Valor)) as Valor from Recebimento  where " & strData & strFiltro & " group by Pagamento, CodConfig", Me.Grid1)
    End Sub

    Private Sub btnRelRec_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelRec.ItemClick
        Dim rel As New relRecebimento
        Dim I As Integer
        rel.lblTitulo.Text = Me.Text
        rel.picLogo.Image = LogoTipo
        With rel.DsNano.Recebimento.Rows
            For I = 0 To grd1.RowCount - 1
                .Add()
                .Item(I).Item("Pagamento") = grd1.GetRowCellDisplayText(I, Me.colPagamento)
                .Item(I).Item("Valor") = grd1.GetRowCellDisplayText(I, Me.colValor)
            Next


            rel.lblTotal.Text = Me.txtTotal.Text
            rel.ShowPreview()

        End With
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.Grid1.ShowPrintPreview()
    End Sub
End Class