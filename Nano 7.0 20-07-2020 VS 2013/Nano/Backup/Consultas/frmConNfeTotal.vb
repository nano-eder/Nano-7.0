Imports Nano.clsFuncoes
Public Class frmConNfeTotal

    Private Sub frmConNfeTotal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "45")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmConNfeTotal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub

        CarregarDados("SELECT CodNF, Serie, NumNF, Chave, DEmi, CodCli, VICMS, VST, VProd, VIPI, VNF, NatOp, case when Cliente.Nome is null then Fornecedor.Nome else Cliente.Nome end  as Cliente, CodVenda FROM (TotalNfe left join Cliente on TotalNfe.CodCli = Cliente.Codigo) left join Fornecedor on TotalNfe.CodForn = Fornecedor.Codigo  Where TotalNfe.CodConfig = " & CodConfig, Me.TotalNfeGridControl)
        Calcular()
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


        Dim strData As String = String.Format("DEmi >= '{0:dd/MM/yyyy}' AND DEmi <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, Me.dtFinal.EditValue)

        CarregarDados("SELECT CodNF, Serie, NumNF, Chave, DEmi, CodCli, VICMS, VST, VProd, VIPI, VNF, NatOp, case when Cliente.Nome is null then Fornecedor.Nome else Cliente.Nome end  as Cliente, CodVenda FROM (TotalNfe left join Cliente on TotalNfe.CodCli = Cliente.Codigo) left join Fornecedor on TotalNfe.CodForn = Fornecedor.Codigo where " & strData & " and TotalNfe.CodConfig = " & CodConfig, Me.TotalNfeGridControl)

        Calcular()
    End Sub
    Private Sub Calcular()
        Me.txtTotGer.ResetText()
        Dim I As Integer
        With grd1
            Dim dblResTot As Double
            For I = 0 To .RowCount - 1
                Dim dblTot As Double


                dblTot = .GetRowCellDisplayText(I, Me.colVNF)
                dblResTot += dblTot


            Next
            Me.txtTotGer.Text = dblResTot.ToString("###,###,##0.00")
        End With
    End Sub
    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relNfetotal

        rel.lblTitulo.Text = "Relatório de Itens de Notas Fiscais de Saída"
        rel.picLogo.Image = LogoTipo

        Dim I As Integer
        Dim dblResulIcms, dblResulST, dblResulProd, dblResulIPI, dblResulNF As Double

        With rel.tbTotal.Rows
            For I = 0 To Me.grd1.RowCount - 1
                Dim dblIcms, dblST, dblProd, dblIPI, dblNF As Double

                .Add()
                .Item(I).Item("NumNF") = Me.grd1.GetRowCellDisplayText(I, Me.colNumNF)
                .Item(I).Item("DEmi") = Me.grd1.GetRowCellDisplayText(I, Me.colDEmi)
                .Item(I).Item("Chave") = Me.grd1.GetRowCellDisplayText(I, Me.colChave)
                .Item(I).Item("Cliente") = Me.grd1.GetRowCellDisplayText(I, Me.colCliente)
                .Item(I).Item("VICMS") = Me.grd1.GetRowCellDisplayText(I, Me.colVICMS)
                .Item(I).Item("VST") = Me.grd1.GetRowCellDisplayText(I, Me.colVST)
                .Item(I).Item("VProd") = Me.grd1.GetRowCellDisplayText(I, Me.colVProd)
                .Item(I).Item("VIPI") = Me.grd1.GetRowCellDisplayText(I, Me.colVIPI)
                .Item(I).Item("VNF") = Me.grd1.GetRowCellDisplayText(I, Me.colVNF)
                .Item(I).Item("NatOp") = Me.grd1.GetRowCellDisplayText(I, Me.colNatOp)

                .Item(I).Item("Serie") = Me.grd1.GetRowCellDisplayText(I, Me.colSerie)
                .Item(I).Item("CodNF") = Me.grd1.GetRowCellDisplayText(I, Me.colCodNF)
                .Item(I).Item("CodVenda") = Me.grd1.GetRowCellDisplayText(I, Me.colCodVenda)


                dblIcms = Me.grd1.GetRowCellDisplayText(I, Me.colVICMS)
                dblResulIcms += dblIcms


                dblST = Me.grd1.GetRowCellDisplayText(I, Me.colVST)
                dblResulST += dblST


                dblProd = Me.grd1.GetRowCellDisplayText(I, Me.colVProd)
                dblResulProd += dblProd


                dblIPI = Me.grd1.GetRowCellDisplayText(I, Me.colVIPI)
                dblResulIPI += dblIPI


                dblNF = Me.grd1.GetRowCellDisplayText(I, Me.colVNF)
                dblResulNF += dblNF


            Next
        End With



        rel.lblICMS.Text = dblResulIcms.ToString("###,###,##0.00")
        rel.lblST.Text = dblResulST.ToString("###,###,##0.00")
        rel.lblProd.Text = dblResulProd.ToString("###,###,##0.00")
        rel.lblIPI.Text = dblResulIPI.ToString("###,###,##0.00")
        rel.lblNF.Text = dblResulNF.ToString("###,###,##0.00")

        rel.ShowPreview()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Calcular()
    End Sub

    Private Sub grd1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grd1.FocusedRowChanged
        Me.lblChave.Visible = False
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        Me.lblChave.Visible = True
        Me.lblChave.Text = "Chave de Acesso:  " & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colChave)
    End Sub
End Class