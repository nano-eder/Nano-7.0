Imports Nano.clsFuncoes
Public Class frmRelGiro

    Dim intCodConfig As Integer
    Dim strFiltroPed As String = ""
    Dim strFiltroEnt As String = ""

    Private Sub btnFiltrar_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFiltrar.ItemClick

        'Dim strMes As String = ""

        'Select Case Me.cboMes.EditValue

        '    Case "JANEIRO"
        '        strMes = "1"
        '    Case "FEVEREIRO"
        '        strMes = "2"
        '    Case "MARÇO"
        '        strMes = "3"
        '    Case "ABRIL"
        '        strMes = "4"
        '    Case "MAIO"
        '        strMes = "5"
        '    Case "JUNHO"
        '        strMes = "6"
        '    Case "JULHO"
        '        strMes = "7"
        '    Case "AGOSTO"
        '        strMes = "8"
        '    Case "SETEMBRO"
        '        strMes = "9"
        '    Case "OUTUBRO"
        '        strMes = "10"
        '    Case "NOVEMBRO"
        '        strMes = "11"
        '    Case "DEZEMBRO"
        '        strMes = "12"

        'End Select

        If TesteConexao() = False Then Exit Sub

        Dim strFiltroQtd As String = ""
        Dim strFiltroDev As String = ""
        Dim strFiltroDes As String = ""
        Dim strFiltroTrans As String = ""
        Dim strFiltroAjuste As String = ""
        If Master = False Then

            strFiltroPed = " and Pedido.CodConfig =" & intCodConfig
            strFiltroEnt = " and EntradaNF.CodConfig =" & intCodConfig

            strFiltroDev = " and Devolucao.CodConfig = " & intCodConfig
            strFiltroDes = " and Descarte.CodConfig = " & intCodConfig
            strFiltroTrans = " and Transferencia.Codconfig = " & intCodConfig
            strFiltroQtd = " and Qtde.CodConfig = " & intCodConfig
            strFiltroAjuste = " and AjusteQtde.CodConfig = " & intCodConfig
        Else

            If Me.lueLoja.EditValue <> Nothing Then
                strFiltroPed = " and Pedido.CodConfig =" & intCodConfig
                strFiltroEnt = " and EntradaNF.CodConfig =" & intCodConfig

                strFiltroDev = " and Devolucao.CodConfig = " & intCodConfig
                strFiltroDes = " and Descarte.CodConfig = " & intCodConfig
                strFiltroTrans = " and Transferencia.Codconfig = " & intCodConfig
                strFiltroQtd = " and Qtde.CodConfig = " & intCodConfig
                strFiltroAjuste = " and AjusteQtde.CodConfig = " & intCodConfig
            End If

        End If

        Dim data1, data2 As String
        data1 = dtInicial.EditValue
        data2 = dtFinal.EditValue

        If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Sub
        If data2 = "" Then MsgBox("Selecione a Data Final!", MsgBoxStyle.Information) : Exit Sub

        Dim dataFim, dataIni As Date
        dataIni = data1
        dataFim = data2

        If dataIni > dataFim Then MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information) : Exit Sub

        Dim strDataTotal, strDataTotalNF, strDataDevolucao, strDataTransferencia, strDataDescarte As String

        strDataTotal = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Date.Today)
        strDataTotalNF = String.Format("TotalEntradaNF.Data >= '{0:dd/MM/yyyy}' AND TotalEntradaNF.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Date.Today)
        strDataDevolucao = String.Format("Devolucao.Data >= '{0:dd/MM/yyyy}' AND Devolucao.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Date.Today)
        strDataTransferencia = String.Format("Transferencia.Data >= '{0:dd/MM/yyyy}' AND Transferencia.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Date.Today)
        strDataDescarte = String.Format("Descarte.Data >= '{0:dd/MM/yyyy}' AND Descarte.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Date.Today)

        'strDataProduto = String.Format("Convert(SmallDateTime, Produto.Data) >= '{0:dd/MM/yyyy}' AND Convert(SmallDateTime, Produto.Data) <= '{1:dd/MM/yyyy}'", "01/01/1990", Me.dtFinal.EditValue)

        Dim dtProd, dtPedInicio, dtEntInicio, dtPed, dtEnt As DataTable

        If EstoqueSomado = False Then
            dtProd = CarregarDataTable("SELECT Produto.Grupo, Produto.Valor, Produto.ValorCusto, Produto.Codigo, Produto.Data, CodigoInterno, Nome, Fabricante, case when sum(Qtde.Qtd) is null then 0 else sum(Qtde.Qtd) end as Qtd FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd " & strFiltroQtd & "   where Produto.Inativo = 'False' group by Produto.Grupo, Produto.Valor, Produto.ValorCusto, Produto.Codigo, Produto.Data, CodigoInterno, Nome, Fabricante order by Produto.Codigo")

        Else
            dtProd = CarregarDataTable("SELECT Produto.Grupo, Produto.Valor, Produto.ValorCusto, Produto.Codigo, Produto.Data, CodigoInterno, Nome, Fabricante, " & _
               "(SELECT case when sum(EntradaNf.QtdProd) is null then 0 else sum(EntradaNf.QtdProd) end FROM EntradaNf " & _
               "left join TotalEntradaNf on EntradaNf.CodTotNf = TotalEntradaNf.Codigo where EntradaNf.CodProd = Produto. Codigo " & _
               "and EstoqueOk = 'True' " & strFiltroEnt & ") - (SELECT case when sum(Pedido.Qtd) is null then 0 " & _
               "else sum(Pedido.Qtd) end FROM Pedido where Pedido.CodProd = Produto.Codigo " & _
               "and Pedido.Devolvido = 'False' " & strFiltroPed & ") + (SELECT case when sum(AjusteQtde.Qtd) is null then 0 else  sum(AjusteQtde.Qtd) end " & _
               "FROM AjusteQtde where AjusteQtde.CodProd = Produto.Codigo " & strFiltroAjuste & ") as Qtd " & _
               "FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd " & strFiltroQtd & "  where Produto.Inativo = 'False' group by Produto.Grupo, Produto.Valor, Produto.ValorCusto, Produto.Codigo, Produto.Data, " & _
               "CodigoInterno, Nome, Fabricante order by Produto.Codigo")

        End If
   
        dtEntInicio = CarregarDataTable("SELECT Produto.Codigo, Produto.Data, (Select case when Sum(QtdProd) is null then 0 else sum(QtdProd) end FROM EntradaNF left join TotalEntradaNF on EntradaNF.CodTotNF = TotalEntradaNF.Codigo where EntradaNF.CodProd = Produto.Codigo and " & strDataTotalNF & strFiltroEnt & ") + (Select case when sum(Qtde) is null then 0 else sum(Qtde) end from Devolucao where Devolucao.CodProd = Produto.Codigo " & strFiltroDev & " and " & strDataDevolucao & ") + (SELECT case when Sum(Qtd) is null then 0 else sum(Qtd) end FROM Transferencia where Transferencia.CodProd = Produto.Codigo and " & strDataTransferencia & strFiltroTrans & " and EntSai = 'E') as Entrada FROM Produto  where Produto.Inativo = 'False'  order by Produto.Codigo")

        dtPedInicio = CarregarDataTable("SELECT Produto.Codigo, Produto.Data, (Select case when Sum(Qtd) is null then 0 else sum(Qtd) end FROM Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem  and Pedido.CodConfig = Total.CodConfig where Pedido.CodProd = Produto.Codigo and " & strDataTotal & strFiltroPed & " and Devolvido = 'false') + (SELECT case when Sum(Qtde) is null then 0 else sum(Qtde) end FROM Descarte where Descarte.CodProd = Produto.Codigo and " & strDataDescarte & strFiltroDes & ") + (SELECT case when Sum(Qtd) is null then 0 else sum(Qtd) end  FROM Transferencia where Transferencia.CodProd = Produto.Codigo and " & strDataTransferencia & strFiltroTrans & " and EntSai = 'S') as Saida FROM Produto  where Produto.Inativo = 'False'  order by Produto.Codigo")


        strDataTotal = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue)
        strDataTotalNF = String.Format("TotalEntradaNF.Data >= '{0:dd/MM/yyyy}' AND TotalEntradaNF.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue)
        strDataDevolucao = String.Format("Devolucao.Data >= '{0:dd/MM/yyyy}' AND Devolucao.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue)
        strDataTransferencia = String.Format("Transferencia.Data >= '{0:dd/MM/yyyy}' AND Transferencia.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue)
        strDataDescarte = String.Format("Descarte.Data >= '{0:dd/MM/yyyy}' AND Descarte.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue)



        dtEnt = CarregarDataTable("SELECT Produto.Codigo, Produto.Data, (Select case when Sum(QtdProd) is null then 0 else sum(QtdProd) end FROM EntradaNF left join TotalEntradaNF on EntradaNF.CodTotNF = TotalEntradaNF.Codigo where EntradaNF.CodProd = Produto.Codigo and " & strDataTotalNF & strFiltroEnt & ") + (Select case when sum(Qtde) is null then 0 else sum(Qtde) end from Devolucao where Devolucao.CodProd = Produto.Codigo " & strFiltroDev & " and " & strDataDevolucao & ") + (SELECT case when Sum(Qtd) is null then 0 else sum(Qtd) end FROM Transferencia where Transferencia.CodProd = Produto.Codigo and " & strDataTransferencia & strFiltroTrans & " and EntSai = 'E') as Entrada FROM Produto  where Produto.Inativo = 'False'  order by Produto.Codigo")

        dtPed = CarregarDataTable("SELECT Produto.Codigo, Produto.Data, (Select case when Sum(Qtd) is null then 0 else sum(Qtd) end FROM Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem where Pedido.CodProd = Produto.Codigo and Pedido.CodConfig = Total.CodConfig and " & strDataTotal & strFiltroPed & " and Devolvido = 'false') as Saida, (SELECT case when Sum(Qtde) is null then 0 else sum(Qtde) end FROM Descarte where Descarte.CodProd = Produto.Codigo and " & strDataDescarte & strFiltroDes & ") + (SELECT case when Sum(Qtd) is null then 0 else sum(Qtd) end  FROM Transferencia where Transferencia.CodProd = Produto.Codigo and " & strDataTransferencia & strFiltroTrans & " and EntSai = 'S') as OutSaida FROM Produto  where Produto.Inativo = 'False'  order by Produto.Codigo")

        Dim I As Integer
        Dim J As Integer

        Me.tbGiro.Rows.Clear()

        For I = 0 To dtProd.Rows.Count - 1

            Dim dblInicio As Double = dtProd.Rows.Item(I).Item("Qtd").ToString
            Dim dblEntradaInicio As Double = dtEntInicio.Rows.Item(I).Item("Entrada").ToString
            Dim dblSaidaInicio As Double = dtPedInicio.Rows.Item(I).Item("Saida").ToString

            Dim dtDataProduto As Date = Date.Today
            If dtProd.Rows.Item(I).Item("Data").ToString <> "" Then
                dtDataProduto = dtProd.Rows.Item(I).Item("Data").ToString
            End If
            'If dtDataProduto <= dtFinal.EditValue Then

            dblInicio = dblInicio + dblSaidaInicio - dblEntradaInicio
            'If dblInicio < 0 Then
            '    dblInicio = 0
            'End If
            Dim dblEntrada As Double = dtEnt.Rows.Item(I).Item("Entrada").ToString

            Dim dblTotalEntrada As Double = dblInicio + dblEntrada

            Dim dblVenda As Double = dtPed.Rows.Item(I).Item("Saida").ToString

            Dim dblOutSaida As Double = dtPed.Rows.Item(I).Item("OutSaida").ToString


            Dim dblTotalSaida As Double = dblOutSaida + dblVenda


            Dim dblSaldo As Double = dblTotalEntrada - dblTotalSaida

            'If dblSaldo < 0 Then
            '    dblSaldo = 0
            'End If

            Dim dblGiro As Double
            dblGiro = (dblTotalSaida / dblTotalEntrada) * 100

            Dim strGiro As String = dblGiro
            If strGiro = "NaN (Não é um número)" Or strGiro = "+Infinito" Then
                dblGiro = 0
            End If


            Me.tbGiro.Rows.Add()
            Me.tbGiro.Rows.Item(J).Item("Codigo") = dtProd.Rows.Item(I).Item("CodigoInterno").ToString
            Me.tbGiro.Rows.Item(J).Item("Produto") = dtProd.Rows.Item(I).Item("Nome").ToString
            Me.tbGiro.Rows.Item(J).Item("Saida") = dblTotalSaida.ToString("0.000")

            Me.tbGiro.Rows.Item(J).Item("Entrada") = dblEntrada.ToString("0.000")

            Me.tbGiro.Rows.Item(J).Item("Saldo") = dblSaldo.ToString("0.000")

            Me.tbGiro.Rows.Item(J).Item("Venda") = dblVenda.ToString("0.000")
            Me.tbGiro.Rows.Item(J).Item("OutraSaida") = dblOutSaida.ToString("0.000")
            Me.tbGiro.Rows.Item(J).Item("SaldoInicio") = dblInicio.ToString("0.000")
            Me.tbGiro.Rows.Item(J).Item("TotalEntrada") = dblTotalEntrada.ToString("0.000")
            Me.tbGiro.Rows.Item(J).Item("Giro") = dblGiro.ToString("0.000")
            Me.tbGiro.Rows.Item(J).Item("Fornecedor") = dtProd.Rows.Item(I).Item("Fabricante").ToString


            Dim dblValor As Double = dtProd.Rows.Item(I).Item("Valor").ToString


            Dim dblValorCusto As Double = dtProd.Rows.Item(I).Item("ValorCusto").ToString

            Me.tbGiro.Rows.Item(J).Item("Valor") = dblValor.ToString("0.000")
            Me.tbGiro.Rows.Item(J).Item("ValorCusto") = dblValorCusto.ToString("0.000")
            Me.tbGiro.Rows.Item(J).Item("Grupo") = dtProd.Rows.Item(I).Item("Grupo").ToString

            J = J + 1

            ' End If
        Next
    End Sub

    Private Sub frmRelGiro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "48")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmRelGiro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub

        CarregarDadosLue3("Select Codigo, Descricao from Config", Me.lueLoja)
        intCodConfig = CodConfig

        If Master = False Then
            Me.lueLoja.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Else
            Me.lueLoja.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If

        Select Case Month(Now)
            Case "1"
                Me.cboMes.EditValue = "JANEIRO"
            Case "2"
                Me.cboMes.EditValue = "FEVEREIRO"
            Case "3"
                Me.cboMes.EditValue = "MARÇO"
            Case "4"
                Me.cboMes.EditValue = "ABRIL"
            Case "5"
                Me.cboMes.EditValue = "MAIO"
            Case "6"
                Me.cboMes.EditValue = "JUNHO"
            Case "7"
                Me.cboMes.EditValue = "JULHO"
            Case "8"
                Me.cboMes.EditValue = "AGOSTO"
            Case "9"
                Me.cboMes.EditValue = "SETEMBRO"
            Case "10"
                Me.cboMes.EditValue = "OUTUBRO"
            Case "11"
                Me.cboMes.EditValue = "NOVEMBRO"
            Case "12"
                Me.cboMes.EditValue = "DEZEMBRO"


        End Select
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)
        Me.FornecedorTableAdapter.Fill(Me.DsNanoCommerce.Fornecedor)
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub lueLoj_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueLoj.Leave
        If Me.lueLoja.EditValue <> Nothing Then
            intCodConfig = Me.lueLoja.EditValue
        End If
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim I As Integer

        Dim dblSalIni, dblTotEnt, dblVen, dblSai, dblSaldo, dblOutSai As Double

        With Me.grd1

            For I = 0 To .RowCount - 1

                dblSalIni += .GetRowCellDisplayText(I, Me.colSaldoInicio).Trim


                dblTotEnt += .GetRowCellDisplayText(I, Me.colTotalEntrada).Trim


                dblVen += .GetRowCellDisplayText(I, Me.colVenda).Trim


                dblSai += .GetRowCellDisplayText(I, Me.colSaida).Trim


                dblSaldo += .GetRowCellDisplayText(I, Me.colSaldo).Trim


                dblOutSai += .GetRowCellDisplayText(I, Me.colOutraSaida).Trim

            Next

            Me.txtSalIni.Text = dblSalIni.ToString("###,###,##0.000")
            Me.txtTotEnt.Text = dblTotEnt.ToString("###,###,##0.000")
            Me.txtTotVend.Text = dblVen.ToString("###,###,##0.000")
            Me.txtSai.Text = dblSai.ToString("###,###,##0.000")
            Me.txtSal.Text = dblSaldo.ToString("###,###,##0.000")
            Me.txtOutSai.Text = dblOutSai.ToString("###,###,##0.000")
            Dim dblTotalGiro As Double
            dblTotalGiro = (dblSai / dblTotEnt) * 100

            Dim strGiro As String = dblTotalGiro
            If strGiro = "NaN (Não é um número)" Or strGiro = "+Infinito" Then
                dblTotalGiro = 0
            End If

            Me.txtTotalGiro.Text = dblTotalGiro.ToString("###,###,##0.000")
        End With
    End Sub

 
    Private Sub btnRelGir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelGir.ItemClick
        Dim rel As New relGiro

        rel.picLogo.Image = LogoTipo
        rel.lblTitulo.Text = "Relatório de Giro do Mês de " & Me.cboMes.EditValue
        With rel.tbGiro.Rows
            Dim I As Integer
            For I = 0 To Me.grd1.RowCount - 1
                .Add()
                .Item(I).Item("Codigo") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)
                .Item(I).Item("Produto") = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                .Item(I).Item("Entrada") = Me.grd1.GetRowCellDisplayText(I, Me.colEntrada)
                .Item(I).Item("Saida") = Me.grd1.GetRowCellDisplayText(I, Me.colSaida)
                .Item(I).Item("Saldo") = Me.grd1.GetRowCellDisplayText(I, Me.colSaldo)
                .Item(I).Item("Giro") = Me.grd1.GetRowCellDisplayText(I, Me.colGiro)
                .Item(I).Item("Fornecedor") = Me.grd1.GetRowCellDisplayText(I, Me.colFornecedor)

                .Item(I).Item("SaldoInicio") = Me.grd1.GetRowCellDisplayText(I, Me.colSaldoInicio)
                .Item(I).Item("TotalEntrada") = Me.grd1.GetRowCellDisplayText(I, Me.colTotalEntrada)
                .Item(I).Item("Venda") = Me.grd1.GetRowCellDisplayText(I, Me.colVenda)
                .Item(I).Item("OutraSaida") = Me.grd1.GetRowCellDisplayText(I, Me.colOutraSaida)

            Next

        End With

        rel.celSalIni.Text = Me.txtSalIni.Text.Trim
        rel.celEnt.Text = Me.txtTotEnt.Text.Trim
        rel.celVend.Text = Me.txtTotVend.Text.Trim
        rel.celSai.Text = Me.txtSai.Text.Trim
        rel.celSaldo.Text = Me.txtSal.Text.Trim
        rel.lblOutSai.Text = Me.txtOutSai.Text
        rel.lblGiro.Text = Me.txtTotalGiro.Text

        rel.ShowPreview()
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub

   
    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub
End Class