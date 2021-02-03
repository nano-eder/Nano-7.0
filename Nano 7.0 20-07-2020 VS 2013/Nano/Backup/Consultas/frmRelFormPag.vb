Imports Nano.clsFuncoes
Public Class frmRelFormPag
    Dim strFiltro As String = ""
    Dim strFiltro2 As String = ""
    Dim strFiltro3 As String = ""

    Dim dtDataInicial As Date
    Dim dtDataFinal As Date
    Private Sub frmRelFormPag_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoAutomotivo.chm", HelpNavigator.TopicId, "90")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If

    End Sub

    Private Sub frmRelFormPag_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.ConfigTableAdapter.Fill(Me.DsNanoCommerce.Config)
        CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja)
        Me.cboData.EditValue = "DATA VENDA"

        If TesteConexao() = False Then Exit Sub
        BaixarCartoes()
        Me.colCodConfig.Visible = Master
   
        If Master = False Then
            strFiltro = " and Recebimento.Codconfig = " & CodConfig
            strFiltro2 = " and ContaReceber.Codconfig = " & CodConfig
            strFiltro3 = " and Futuro.Codconfig = " & CodConfig
        End If
        Dim strData As String = String.Format("Recebimento.Data >= '{0:dd/MM/yyyy}' AND Recebimento.Data <= '{1:dd/MM/yyyy}'", Date.Today.AddMonths(-1), Date.Today) & strFiltro
        Dim strData1 As String = String.Format("Vencimento >= '{0:dd/MM/yyyy}' AND Vencimento <= '{1:dd/MM/yyyy}'", Date.Today.AddMonths(-1), Date.Today) & strFiltro2
        Dim strData2 As String = String.Format("Recebimento >= '{0:dd/MM/yyyy}' AND Recebimento <= '{1:dd/MM/yyyy}'", Date.Today.AddMonths(-1), Date.Today) & strFiltro2
        Dim strData3 As String = String.Format("Futuro.Data >= '{0:dd/MM/yyyy}' AND Futuro.Data <= '{1:dd/MM/yyyy}'", Date.Today.AddMonths(-1), Date.Today) & strFiltro3

        Dim strDataTotal As String = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", Date.Today.AddMonths(-1), Date.Today)

        dtDataInicial = Date.Today.AddMonths(-1)
        dtDataFinal = Date.Today


        If Me.Tag = "DETALHADO" Then
            Me.Text = "Relatório de Recebimento Detalhado"
      
            'CarregarDados("(SELECT convert(integer,CodOrdem) as CodigoPedido, Pagamento, " & _
            '"Convert(Numeric(15,2),Valor) as ValorVenda, Convert(Numeric(15,2),Valor) as Valor, " & _
            '"Recebimento.Data, Recebimento.CodConfig, convert(bit,'True') as RecebidoOK " & _
            '"FROM Recebimento left join Pagamento on Recebimento.Pagamento = Pagamento.Descricao " & _
            '"where Recebimento.FormaPagamento = 'A VISTA' and Prazo = 'False' and " & strData & ")" & _
            '"UNION ALL (SELECT convert(integer,ContaReceber.CodOrdem) as CodigoPedido, Pagamento, " & _
            '"Convert(Numeric(15,2),ValorParcela) as ValorVenda, Convert(Numeric(15,2),ValorParcela) as Valor, " & _
            '"Vencimento as Data, ContaReceber.CodConfig, RecebidoOK FROM ContaReceber where RecebidoOK = 'False' and " & strData1 & ")" & _
            '"UNION ALL (SELECT convert(integer,ContaReceber.CodOrdem) as CodigoPedido, Pagamento, " & _
            '"Convert(Numeric(15,2),ValorParcela) as ValorVenda, Convert(Numeric(15,2),ValorRecebido) as Valor, " & _
            '"Recebimento as Data, ContaReceber.CodConfig, RecebidoOK FROM ContaReceber where RecebidoOK = 'True' and " & strData2 & ")" & _
            '"UNION ALL (SELECT convert(integer,CodOrdem) as CodigoPedido, Pagamento, Convert(Numeric(15,2),Futuro.Total) as ValorVenda, " & _
            '"Convert(Numeric(15,2),Futuro.TotalDesconto) as Valor, Futuro.Data, Futuro.CodConfig, " & _
            '"Futuro.Recebido as RecebidoOK FROM Futuro where " & strData3 & ")", Me.Grid1)

            CarregarDados("(SELECT convert(integer,Recebimento.CodOrdem) as CodigoPedido, Pagamento, " & _
            "Convert(Numeric(15,2),Recebimento.Valor) as ValorVenda, Convert(Numeric(15,2),Recebimento.Valor) as Valor, " & _
            "Recebimento.Data, Recebimento.CodConfig, convert(bit,'True') as RecebidoOK, Recebimento.Data as DataVenda " & _
            "FROM Recebimento left join Pagamento on Recebimento.Pagamento = Pagamento.Descricao " & _
            "where Recebimento.FormaPagamento = 'A VISTA' and Prazo = 'False' and " & strData & ")" & _
            "UNION ALL (SELECT convert(integer,ContaReceber.CodOrdem) as CodigoPedido, Pagamento, " & _
            "Convert(Numeric(15,2),ValorParcela) as ValorVenda, Convert(Numeric(15,2),ValorParcela) as Valor, " & _
            "Vencimento as Data, ContaReceber.CodConfig, RecebidoOK, Total.Data as DataVenda FROM " & _
            "ContaReceber left join Total on ContaReceber.CodOrdem = Total.CodOrdem and ContaReceber.CodConfig = " & _
            "Total.CodConfig where RecebidoOK = 'False' and " & strDataTotal & strFiltro2 & ")" & _
            "UNION ALL (SELECT convert(integer,ContaReceber.CodOrdem) as CodigoPedido, Pagamento, " & _
            "Convert(Numeric(15,2),ValorParcela) as ValorVenda, Convert(Numeric(15,2),ValorRecebido) as Valor, " & _
            "Recebimento as Data, ContaReceber.CodConfig, RecebidoOK, Total.Data as DataVenda FROM " & _
            "(ContaReceber left join Total on ContaReceber.CodOrdem = Total.CodOrdem and ContaReceber.CodConfig = " & _
            "Total.CodConfig) left join Pagamento on ContaReceber.Pagamento = Pagamento.Descricao where Pagamento.Prazo = 'False' and RecebidoOK = 'True' and " & strDataTotal & strFiltro2 & ")" & _
            "UNION ALL (SELECT convert(integer,Futuro.CodOrdem) as CodigoPedido, Pagamento, Convert(Numeric(15,2),Futuro.Total) as ValorVenda, " & _
            "Convert(Numeric(15,2),Futuro.TotalDesconto) as Valor, Futuro.Data, Futuro.CodConfig, " & _
            "Futuro.Recebido as RecebidoOK, Total.Data as DataVenda FROM Futuro left join Total on Futuro.CodOrdem = " & _
            "Total.CodOrdem and Futuro.CodConfig = Total.CodConfig where " & strDataTotal & strFiltro3 & ")", Me.Grid1)
        Else
            Me.Text = "Relatório de Recebimento Somado"
            Me.colCodigoPedido.Visible = False
            Me.colCodigoPedido.SortOrder = DevExpress.Data.ColumnSortOrder.None
            Me.colPagamento.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            Me.colData.Visible = False
            Me.colDataVenda.Visible = False
            'CarregarDados("(SELECT Pagamento, " & _
            '"sum(Convert(Numeric(15,2),Valor)) as ValorVenda, sum(Convert(Numeric(15,2),Valor)) as Valor, " & _
            '"Recebimento.CodConfig, convert(bit,'True') as RecebidoOK " & _
            '"FROM Recebimento left join Pagamento on Recebimento.Pagamento = Pagamento.Descricao " & _
            '"where Recebimento.FormaPagamento = 'A VISTA' and Prazo = 'False' and " & strData & " group by Pagamento, CodConfig)" & _
            '"UNION ALL (SELECT Pagamento, " & _
            '"sum(Convert(Numeric(15,2),ValorParcela)) as ValorVenda, " & _
            '"sum(Convert(Numeric(15,2),ValorParcela)) as Valor, " & _
            '"ContaReceber.CodConfig, RecebidoOK FROM ContaReceber where RecebidoOK = 'False' and " & strData1 & " group by Pagamento, CodConfig, RecebidoOK)" & _
            '"UNION ALL (SELECT Pagamento, " & _
            '"sum(Convert(Numeric(15,2),ValorParcela)) as ValorVenda, sum(Convert(Numeric(15,2),ValorRecebido)) as Valor, " & _
            '"ContaReceber.CodConfig, RecebidoOK FROM ContaReceber where RecebidoOK = 'True' and " & strData2 & " group by Pagamento, CodConfig, RecebidoOK)" & _
            '"UNION ALL (SELECT Pagamento, sum(Convert(Numeric(15,2),Futuro.Total)) as ValorVenda, " & _
            '"sum(Convert(Numeric(15,2),Futuro.TotalDesconto)) as Valor, Futuro.CodConfig, " & _
            '"Futuro.Recebido as RecebidoOK FROM Futuro where " & strData3 & " group by Pagamento, CodConfig, Recebido)", Me.Grid1)


            CarregarDados("(SELECT Pagamento, " & _
            "sum(Convert(Numeric(15,2),Valor)) as ValorVenda, sum(Convert(Numeric(15,2),Valor)) as Valor, " & _
            "Recebimento.CodConfig, convert(bit,'True') as RecebidoOK " & _
            "FROM Recebimento left join Pagamento on Recebimento.Pagamento = Pagamento.Descricao " & _
            "where Recebimento.FormaPagamento = 'A VISTA' and Prazo = 'False' and " & strData & " group by Pagamento, CodConfig)" & _
            "UNION ALL (SELECT Pagamento, " & _
            "sum(Convert(Numeric(15,2),ValorParcela)) as ValorVenda, " & _
            "sum(Convert(Numeric(15,2),ValorParcela)) as Valor, " & _
            "ContaReceber.CodConfig, RecebidoOK FROM ContaReceber left join Total on ContaReceber.CodOrdem = Total.CodOrdem and ContaReceber.CodConfig = Total.CodConfig where RecebidoOK = 'False' and " & strDataTotal & strFiltro2 & " group by Pagamento, ContaReceber.CodConfig, ContaReceber.RecebidoOK)" & _
            "UNION ALL (SELECT Pagamento, " & _
            "sum(Convert(Numeric(15,2),ValorParcela)) as ValorVenda, sum(Convert(Numeric(15,2),ValorRecebido)) as Valor, " & _
            "ContaReceber.CodConfig, RecebidoOK FROM (ContaReceber left join Total on ContaReceber.CodOrdem = Total.CodOrdem and ContaReceber.CodConfig = " & _
            "Total.CodConfig) left join Pagamento on ContaReceber.Pagamento = Pagamento.Descricao where Pagamento.Prazo = 'False' and RecebidoOK = 'True' and " & strDataTotal & strFiltro2 & " group by Pagamento, ContaReceber.CodConfig, ContaReceber.RecebidoOK)" & _
            "UNION ALL (SELECT Pagamento, sum(Convert(Numeric(15,2),Futuro.Total)) as ValorVenda, " & _
            "sum(Convert(Numeric(15,2),Futuro.TotalDesconto)) as Valor, Futuro.CodConfig, " & _
            "Futuro.Recebido as RecebidoOK FROM Futuro left join Total on Futuro.CodOrdem = Total.CodOrdem and Futuro.CodConfig = Total.CodConfig where " & strDataTotal & strFiltro3 & " group by Pagamento, Futuro.CodConfig, Futuro.Recebido)", Me.Grid1)
        End If
        Calcular()
    End Sub

    Private Sub btnVisu_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisu.ItemClick
        Dim rel As New relFormPag

        rel.lblTitulo.Text = Me.Text
        rel.picLogo.Image = LogoTipo
        Dim A As Integer = 0
        With rel.tbForm.Rows

            Dim I As Integer
            Dim dtDT As Date
            For I = 0 To Me.GridView1.RowCount - 1
                If Me.GridView1.GetRowCellDisplayText(I, Me.colValor) <> "" Then
                    .Add()
                    .Item(A).Item("CodPed") = Me.GridView1.GetRowCellDisplayText(I, Me.colCodigoPedido)
                    .Item(A).Item("Data") = Me.GridView1.GetRowCellDisplayText(I, Me.colData)
                    .Item(A).Item("FormPag") = Me.GridView1.GetRowCellDisplayText(I, Me.colFormaPagamento)
                    .Item(A).Item("Pagamento") = Me.GridView1.GetRowCellDisplayText(I, Me.colPagamento)
                    .Item(A).Item("ValorVenda") = Me.GridView1.GetRowCellDisplayText(I, Me.colValorVenda)
                    .Item(A).Item("Valor") = Me.GridView1.GetRowCellDisplayText(I, Me.colValor)
                    .Item(A).Item("RecebidoOK") = Me.GridView1.GetRowCellValue(I, Me.colRecebidoOK)
                    .Item(A).Item("DataVenda") = Me.GridView1.GetRowCellValue(I, Me.colDataVenda)
                    .Item(A).Item("CodConfig") = Me.GridView1.GetRowCellValue(I, Me.colCodConfig)
                    If Me.cboData.EditValue = "DATA VENDA" Then
                        dtDT = Me.GridView1.GetRowCellValue(I, Me.colDataVenda)
                    Else
                        dtDT = Me.GridView1.GetRowCellValue(I, Me.colData)
                    End If

                    If Me.Tag = "DETALHADO" Then
                        If A = 0 Then
                            dtDataInicial = dtDT
                            dtDataFinal = dtDT
                        End If
                        If dtDT < dtDataInicial Then
                            dtDataInicial = dtDT
                        End If
                        If dtDT > dtDataFinal Then
                            dtDataFinal = dtDT
                        End If
                    End If

                    A += 1
                End If
               
            Next
        End With
        rel.colCodConfig.Visible = Me.colCodConfig.Visible
        If Me.Tag = "SOMADO" Then
            rel.colCodPed.Visible = False
            rel.colData.Visible = False
            rel.colDataVenda.Visible = False
        End If
        rel.lblVendido.Text = Me.txtTotalVendido.Text
        rel.lblRecebido.Text = Me.txtTotalRecebido.Text
        rel.lblSaldo.Text = Me.txtTotal.Text
        If Me.cboData.EditValue = "DATA VENDA" Then
            rel.lblPeriodo.Text = "Data venda - de " & Format(dtDataInicial, "dd/MM/yyyy") & " a " & Format(dtDataFinal, "dd/MM/yyyy")

        Else
            rel.lblPeriodo.Text = "Data - de " & Format(dtDataInicial, "dd/MM/yyyy") & " a " & Format(dtDataFinal, "dd/MM/yyyy")

        End If
       rel.ShowPreview()
    End Sub

    'Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
    '    Me.Validate()
    '    Me.RecebimentoBindingSource.EndEdit()
    '    Me.RecebimentoTableAdapter.Update(Me.DsNano.Recebimento)
    '    MsgBox("Observações salvas com sucesso!", MsgBoxStyle.Information)
    'End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnFilter_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilter.ItemClick
        If TesteConexao() = False Then Exit Sub
        Dim data1, data2 As String
        data1 = dtInicial.EditValue
        data2 = dtFinal.EditValue

        If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Sub
        If data2 = "" Then MsgBox("Selecione a Data Final!", MsgBoxStyle.Information) : Exit Sub

        Dim dataFim, dataIni As Date
        dataIni = data1
        dataFim = data2

        If dataIni > dataFim Then MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information) : Exit Sub
        If Master = False Then
            strFiltro = " and Recebimento.Codconfig = " & CodConfig
            strFiltro2 = " and ContaReceber.Codconfig = " & CodConfig
            strFiltro3 = " and Futuro.Codconfig = " & CodConfig
        End If
        Dim strData As String = String.Format("Recebimento.Data >= '{0:dd/MM/yyyy}' AND Recebimento.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro
        Dim strData1 As String = String.Format("Vencimento >= '{0:dd/MM/yyyy}' AND Vencimento <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro2
        Dim strData2 As String = String.Format("Recebimento >= '{0:dd/MM/yyyy}' AND Recebimento <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro2
        Dim strData3 As String = String.Format("Futuro.Data >= '{0:dd/MM/yyyy}' AND Futuro.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue)

        If Me.cboData.EditValue = "DATA VENDA" Then
            strData1 = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro2
            strData2 = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro2
            strData3 = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue)
        End If

        dtDataInicial = Me.dtInicial.EditValue
        dtDataFinal = Me.dtFinal.EditValue

        If Me.Tag = "DETALHADO" Then


            CarregarDados("(SELECT convert(integer,Recebimento.CodOrdem) as CodigoPedido, Pagamento, " & _
            "Convert(Numeric(15,2),Recebimento.Valor) as ValorVenda, Convert(Numeric(15,2),Recebimento.Valor) as Valor, " & _
            "Recebimento.Data, Recebimento.CodConfig, convert(bit,'True') as RecebidoOK, Recebimento.Data as DataVenda " & _
            "FROM Recebimento left join Pagamento on Recebimento.Pagamento = Pagamento.Descricao " & _
            "where Recebimento.FormaPagamento = 'A VISTA' and Prazo = 'False' and " & strData & ")" & _
            "UNION ALL (SELECT convert(integer,ContaReceber.CodOrdem) as CodigoPedido, Pagamento, " & _
            "Convert(Numeric(15,2),ValorParcela) as ValorVenda, Convert(Numeric(15,2),ValorParcela) as Valor, " & _
            "Vencimento as Data, ContaReceber.CodConfig, RecebidoOK, Total.Data as DataVenda FROM " & _
            "ContaReceber left join Total on ContaReceber.CodOrdem = Total.CodOrdem and ContaReceber.CodConfig = " & _
            "Total.CodConfig where RecebidoOK = 'False' and " & strData1 & strFiltro2 & ")" & _
            "UNION ALL (SELECT convert(integer,ContaReceber.CodOrdem) as CodigoPedido, Pagamento, " & _
            "Convert(Numeric(15,2),ValorParcela) as ValorVenda, Convert(Numeric(15,2),ValorRecebido) as Valor, " & _
            "Recebimento as Data, ContaReceber.CodConfig, RecebidoOK, Total.Data as DataVenda FROM " & _
            "(ContaReceber left join Total on ContaReceber.CodOrdem = Total.CodOrdem and ContaReceber.CodConfig = " & _
            "Total.CodConfig) left join Pagamento on ContaReceber.Pagamento = Pagamento.Descricao where Pagamento.Prazo = 'False' and RecebidoOK = 'True' and " & strData2 & strFiltro2 & ")" & _
            "UNION ALL (SELECT convert(integer,Futuro.CodOrdem) as CodigoPedido, Pagamento, Convert(Numeric(15,2),Futuro.Total) as ValorVenda, " & _
            "Convert(Numeric(15,2),Futuro.TotalDesconto) as Valor, Futuro.Data, Futuro.CodConfig, " & _
            "Futuro.Recebido as RecebidoOK, Total.Data as DataVenda FROM Futuro left join Total on Futuro.CodOrdem = " & _
            "Total.CodOrdem and Futuro.CodConfig = Total.CodConfig where " & strData3 & strFiltro3 & ")", Me.Grid1)
        Else



            'CarregarDados("(SELECT Pagamento, " & _
            '"sum(Convert(Numeric(15,2),Valor)) as ValorVenda, sum(Convert(Numeric(15,2),Valor)) as Valor, " & _
            '"Recebimento.CodConfig, convert(bit,'True') as RecebidoOK " & _
            '"FROM Recebimento left join Pagamento on Recebimento.Pagamento = Pagamento.Descricao " & _
            '"where Recebimento.FormaPagamento = 'A VISTA' and Prazo = 'False' and " & strData & " group by Pagamento, CodConfig)" & _
            '"UNION ALL (SELECT Pagamento, " & _
            '"sum(Convert(Numeric(15,2),ValorParcela)) as ValorVenda, " & _
            '"sum(Convert(Numeric(15,2),ValorParcela)) as Valor, " & _
            '"ContaReceber.CodConfig, RecebidoOK FROM ContaReceber where RecebidoOK = 'False' and " & strData1 & " group by Pagamento, CodConfig, RecebidoOK)" & _
            '"UNION ALL (SELECT Pagamento, " & _
            '"sum(Convert(Numeric(15,2),ValorParcela)) as ValorVenda, sum(Convert(Numeric(15,2),ValorRecebido)) as Valor, " & _
            '"ContaReceber.CodConfig, RecebidoOK FROM ContaReceber where RecebidoOK = 'True' and " & strData2 & " group by Pagamento, CodConfig, RecebidoOK)" & _
            '"UNION ALL (SELECT Pagamento, sum(Convert(Numeric(15,2),Futuro.Total)) as ValorVenda, " & _
            '"sum(Convert(Numeric(15,2),Futuro.TotalDesconto)) as Valor, Futuro.CodConfig, " & _
            '"Futuro.Recebido as RecebidoOK FROM Futuro where " & strData3 & " group by Pagamento, CodConfig, Recebido)", Me.Grid1)
            CarregarDados("(SELECT Pagamento, " & _
           "sum(Convert(Numeric(15,2),Valor)) as ValorVenda, sum(Convert(Numeric(15,2),Valor)) as Valor, " & _
           "Recebimento.CodConfig, convert(bit,'True') as RecebidoOK " & _
           "FROM Recebimento left join Pagamento on Recebimento.Pagamento = Pagamento.Descricao " & _
           "where Recebimento.FormaPagamento = 'A VISTA' and Prazo = 'False' and " & strData & " group by Pagamento, CodConfig)" & _
           "UNION ALL (SELECT Pagamento, " & _
           "sum(Convert(Numeric(15,2),ValorParcela)) as ValorVenda, " & _
           "sum(Convert(Numeric(15,2),ValorParcela)) as Valor, " & _
           "ContaReceber.CodConfig, RecebidoOK FROM ContaReceber left join Total on ContaReceber.CodOrdem = Total.CodOrdem and ContaReceber.CodConfig = Total.CodConfig where RecebidoOK = 'False' and " & strData1 & strFiltro2 & " group by Pagamento, ContaReceber.CodConfig, ContaReceber.RecebidoOK)" & _
           "UNION ALL (SELECT Pagamento, " & _
           "sum(Convert(Numeric(15,2),ValorParcela)) as ValorVenda, sum(Convert(Numeric(15,2),ValorRecebido)) as Valor, " & _
           "ContaReceber.CodConfig, RecebidoOK FROM (ContaReceber left join Total on ContaReceber.CodOrdem = Total.CodOrdem and ContaReceber.CodConfig = " & _
            "Total.CodConfig) left join Pagamento on ContaReceber.Pagamento = Pagamento.Descricao  where Pagamento.Prazo = 'False' and RecebidoOK = 'True' and " & strData2 & strFiltro2 & " group by Pagamento, ContaReceber.CodConfig, ContaReceber.RecebidoOK)" & _
           "UNION ALL (SELECT Pagamento, sum(Convert(Numeric(15,2),Futuro.Total)) as ValorVenda, " & _
           "sum(Convert(Numeric(15,2),Futuro.TotalDesconto)) as Valor, Futuro.CodConfig, " & _
           "Futuro.Recebido as RecebidoOK FROM Futuro left join Total on Futuro.CodOrdem = Total.CodOrdem and Futuro.CodConfig = Total.CodConfig where " & strData3 & strFiltro3 & " group by Pagamento, Futuro.CodConfig, Futuro.Recebido)", Me.Grid1)

        End If
        Calcular()
    End Sub
    Private Sub Calcular()
        Dim dblLinha, dblResul, dblTotalRecebido, dblSaldo As Double

        Dim I As Integer

        For I = 0 To Me.GridView1.RowCount - 1
            If Me.GridView1.GetRowCellDisplayText(I, Me.colValor) <> "" Then
                dblLinha = Me.GridView1.GetRowCellDisplayText(I, Me.colValorVenda)
                dblResul += dblLinha
            End If
            Dim strRecebidoOk As String = Me.GridView1.GetRowCellValue(I, Me.colRecebidoOK).ToString
            If strRecebidoOk <> "" Then
                If Me.GridView1.GetRowCellValue(I, Me.colRecebidoOK) = True Then
                    dblLinha = Me.GridView1.GetRowCellDisplayText(I, Me.colValor)
                    dblTotalRecebido += dblLinha
                End If
            End If
          
        Next

        Me.txtTotalVendido.Text = dblResul.ToString("###,###,##0.00")
        Me.txtTotalRecebido.Text = dblTotalRecebido.ToString("###,###,##0.00")
        dblSaldo = dblResul - dblTotalRecebido
        Me.txtTotal.Text = dblSaldo.ToString("###,###,##0.00")
    End Sub
    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Calcular()
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.Grid1.ShowPrintPreview()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
 
        Timer1.Stop()
    End Sub


End Class