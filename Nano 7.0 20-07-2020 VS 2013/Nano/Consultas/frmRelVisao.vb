Imports Nano.clsFuncoes
Imports DevExpress.XtraReports.UI
Public Class frmRelVisao
    Dim strFiltro As String = ""

    Private Sub frmRelVisao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoAutomotivo.chm", HelpNavigator.TopicId, "140")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If

    End Sub

    Private Sub frmRelVisao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsNanoCommerce.Config' table. You can move, or remove it, as needed.
        'Me.ConfigTableAdapter.Fill(Me.DsNanoCommerce.Config)
        CarregarDadosLue("Select Codigo, Descricao from Config", Me.lueLoja)
        If Master = False Then
            Me.lblLoja.Visible = False
            Me.lueLoja.Visible = False
        End If
    End Sub
    Private Sub CriarLinha(ByVal parPagamento As String, ByVal parValor As String, ByVal parTab As System.Data.DataTable)
        ' ByVal parTab As DevExpress.XtraReports.UI.XRTable
        'Dim row As New XRTableRow
        'Dim cell0 As New XRTableCell
        'Dim cell1 As New XRTableCell

        'cell0.Size = New System.Drawing.Size(132, 20)
        'cell1.Size = New System.Drawing.Size(98, 20)

        'cell0.Text = parPagamento
        'cell1.Text = parValor

        ''If parPagamento = "TOTAL R$" Then
        ''    cell0.Borders = DevExpress.XtraPrinting.BorderSide.Bottom Or DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right
        ''    cell1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom Or DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right
        ''Else
        ''cell0.Borders = DevExpress.XtraPrinting.BorderSide.Left
        ''    cell1.Borders = DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right
        ''End If
        'If parPagamento = "TOTAL R$" Then

        '    cell0.Font = New System.Drawing.Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Point)
        '    cell1.Font = New System.Drawing.Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Point)
        'Else
        '    cell0.Font = New System.Drawing.Font("Arial", 9, FontStyle.Regular, GraphicsUnit.Point)
        '    cell1.Font = New System.Drawing.Font("Arial", 9, FontStyle.Regular, GraphicsUnit.Point)
        'End If
        'cell0.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        'cell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight

        'row.Cells.Add(cell0)
        'row.Cells.Add(cell1)

        'parTab.Rows.Add(row)
        parTab.Rows.Add()
        parTab.Rows.Item(parTab.Rows.Count - 1).Item("Pagamento") = parPagamento
        parTab.Rows.Item(parTab.Rows.Count - 1).Item("Valor") = parValor
    End Sub
    Private Sub VerificarLinhas(ByVal parLinha1 As Integer, ByVal parLinha2 As Integer, ByVal parLinha3 As Integer, _
    ByVal parVaTab1 As Double, ByVal parValTab2 As Double, ByVal parValTab3 As Double, ByVal parTab1 As System.Data.DataTable, _
    ByVal parTab2 As System.Data.DataTable, ByVal parTab3 As System.Data.DataTable, _
    ByVal parGrid1 As DevExpress.XtraGrid.GridControl, ByVal parGrid2 As DevExpress.XtraGrid.GridControl, _
     ByVal parGrid3 As DevExpress.XtraGrid.GridControl)
        Dim intTotalLinha As Integer
        If parLinha1 > parLinha2 Then
            If parLinha1 > parLinha3 Then
                intTotalLinha = parLinha1
            Else
                intTotalLinha = parLinha3
            End If
        Else
            If parLinha2 > parLinha3 Then
                intTotalLinha = parLinha2
            Else
                intTotalLinha = parLinha3
            End If
        End If
        Dim I As Integer
        Dim intDiferenca As Integer = intTotalLinha - parLinha1
        For I = 0 To intDiferenca - 1
            CriarLinha("", "", parTab1)
        Next
        ' CriarLinha("Total R$", parVaTab1.ToString("###,###,##0.00"), parTab1)
        intDiferenca = intTotalLinha - parLinha2
        For I = 0 To intDiferenca - 1
            CriarLinha("", "", parTab2)
        Next
        ' CriarLinha("Total R$", parValTab2.ToString("###,###,##0.00"), parTab2)
        intDiferenca = intTotalLinha - parLinha3

        For I = 0 To intDiferenca - 1
            CriarLinha("", "", parTab3)
        Next
        'CriarLinha("Total R$", parValTab3.ToString("###,###,##0.00"), parTab3)

        Dim intTam1 As Integer = intTotalLinha
        intTam1 = intTam1 * 19
        parGrid1.Size = New System.Drawing.Size(221, intTam1)
        parGrid2.Size = New System.Drawing.Size(221, intTam1)
        parGrid3.Size = New System.Drawing.Size(221, intTam1)
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If TesteConexao() = False Then Exit Sub
        Dim data1, data2 As String
        data1 = dtInicial.EditValue
        data2 = dtFinal.EditValue


        If Master = False Then
            strFiltro = " and CodConfig = " & CodConfig
        Else
            If Me.lueLoja.EditValue.ToString <> "" Then
                strFiltro = " and CodConfig = " & Me.lueLoja.EditValue
            Else
                strFiltro = " and CodConfig = " & CodConfig
            End If
        End If
        If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Sub
        If data2 = "" Then MsgBox("Selecione a Data Final!", MsgBoxStyle.Information) : Exit Sub

        Dim dataFim, dataIni As Date
        dataIni = data1
        dataFim = data2

        If dataIni > dataFim Then MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information) : Exit Sub


        Dim dt As DataTable
        Dim rel As New relVisao
        Dim strData As String

        Dim intLinha1, intLinha2, intLinha3 As Integer
        strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro

        dt = CarregarDataTable("SELECT Pagamento, sum(Convert(Numeric(15,2),Valor)) as Valor " & _
        "FROM Recebimento left join Pagamento on Recebimento.Pagamento = Pagamento.Descricao " & _
        "where Recebimento.FormaPagamento = 'A VISTA' and Prazo = 'False' and " & strData & " group by Pagamento")

        Dim I As Integer

        Dim dblTotal As Double = 0
        intLinha1 = dt.Rows.Count
        For I = 0 To dt.Rows.Count - 1
            dblTotal += dt.Rows.Item(I).Item("Valor").ToString
            rel.tbTab1.Rows.Add()
            rel.tbTab1.Rows.Item(I).Item("Pagamento") = dt.Rows.Item(I).Item("Pagamento").ToString & " R$"
            rel.tbTab1.Rows.Item(I).Item("Valor") = dt.Rows.Item(I).Item("Valor").ToString
        Next

        rel.tbTotal1.Rows.Add()
        rel.tbTotal1.Rows.Item(0).Item("Pagamento") = "Total R$"
        rel.tbTotal1.Rows.Item(0).Item("Valor") = dblTotal.ToString("###,###,##0.00")

        strData = String.Format("Recebimento >= '{0:dd/MM/yyyy}' AND Recebimento <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro

        dt = CarregarDataTable("SELECT Pagamento, sum(Convert(Numeric(15,2),ValorRecebido)) as Valor " & _
        "FROM ContaReceber where RecebidoOK = 'True' and " & strData & " group by Pagamento")

        Dim dblTotalCTRec As Double = 0
        intLinha2 = dt.Rows.Count
        For I = 0 To dt.Rows.Count - 1
            dblTotalCTRec += dt.Rows.Item(I).Item("Valor").ToString
            rel.tbTab2.Rows.Add()
            rel.tbTab2.Rows.Item(I).Item("Pagamento") = dt.Rows.Item(I).Item("Pagamento").ToString & " R$"
            rel.tbTab2.Rows.Item(I).Item("Valor") = dt.Rows.Item(I).Item("Valor").ToString
        Next

        rel.tbTotal2.Rows.Add()
        rel.tbTotal2.Rows.Item(0).Item("Pagamento") = "Total R$"
        rel.tbTotal2.Rows.Item(0).Item("Valor") = dblTotalCTRec.ToString("###,###,##0.00")

        strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro

        dt = CarregarDataTable("SELECT Pagamento, sum(Convert(Numeric(15,2),Futuro.TotalDesconto)) as Valor " & _
        "FROM Futuro where " & strData & " group by Pagamento")

        Dim dblTotalCartoes As Double = 0
        intLinha3 = dt.Rows.Count
        For I = 0 To dt.Rows.Count - 1
            dblTotalCartoes += dt.Rows.Item(I).Item("Valor").ToString
            rel.tbTab3.Rows.Add()
            rel.tbTab3.Rows.Item(I).Item("Pagamento") = dt.Rows.Item(I).Item("Pagamento").ToString & " R$"
            rel.tbTab3.Rows.Item(I).Item("Valor") = dt.Rows.Item(I).Item("Valor").ToString
        Next

        rel.tbTotal3.Rows.Add()
        rel.tbTotal3.Rows.Item(0).Item("Pagamento") = "Total R$"
        rel.tbTotal3.Rows.Item(0).Item("Valor") = dblTotalCartoes.ToString("###,###,##0.00")

        VerificarLinhas(intLinha1, intLinha2, intLinha3, dblTotal, dblTotalCTRec, dblTotalCartoes, _
        rel.tbTab1, rel.tbTab2, rel.tbTab3, rel.Grid1, rel.Grid2, rel.Grid3)

        Dim dblTotalRecebidos As Double = dblTotal + dblTotalCTRec + dblTotalCartoes

        rel.tbTotalRec.Rows.Add()
        rel.tbTotalRec.Rows.Item(0).Item("Pagamento") = "Total Recebido R$"
        rel.tbTotalRec.Rows.Item(0).Item("Valor") = dblTotalRecebidos.ToString("###,###,##0.00")




        strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro

        dt = CarregarDataTable("SELECT Motivo, sum(Convert(Numeric(15,2),ValorComissao)) as Valor " & _
        "FROM Comissao where Tipo = 'C' and " & strData & " group by Motivo")
        Dim dblTotalFolhaPag As Double = 0
        intLinha1 = dt.Rows.Count
        For I = 0 To dt.Rows.Count - 1
            dblTotalFolhaPag += dt.Rows.Item(I).Item("Valor").ToString
            rel.tbTab4.Rows.Add()
            rel.tbTab4.Rows.Item(I).Item("Pagamento") = "COMISSÃO R$"
            rel.tbTab4.Rows.Item(I).Item("Valor") = dt.Rows.Item(I).Item("Valor").ToString
        Next


        dt = CarregarDataTable("SELECT Motivo, sum(Convert(Numeric(15,2),Valor)) as Valor " & _
         "FROM GastosFunc where Tipo = 'C' and " & strData & " group by Motivo")
        intLinha1 = intLinha1 + dt.Rows.Count
        For I = 0 To dt.Rows.Count - 1
            dblTotalFolhaPag += dt.Rows.Item(I).Item("Valor").ToString
            rel.tbTab4.Rows.Add()
            rel.tbTab4.Rows.Item(rel.tbTab4.Rows.Count - 1).Item("Pagamento") = dt.Rows.Item(I).Item("Motivo").ToString & " R$"
            rel.tbTab4.Rows.Item(rel.tbTab4.Rows.Count - 1).Item("Valor") = dt.Rows.Item(I).Item("Valor").ToString
        Next

        rel.tbTotal4.Rows.Add()
        rel.tbTotal4.Rows.Item(0).Item("Pagamento") = "Total R$"
        rel.tbTotal4.Rows.Item(0).Item("Valor") = dblTotalFolhaPag.ToString("###,###,##0.00")

        strData = String.Format("DataPagamento >= '{0:dd/MM/yyyy}' AND DataPagamento <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro

        dt = CarregarDataTable("SELECT FormaPagamento as Pagamento, sum(Convert(Numeric(15,2),ValorPago)) as Valor " & _
        "FROM ContaPagar where PagoOK = 'True' and " & strData & " group by FormaPagamento")

        Dim dblTotalCTPag As Double = 0
        intLinha2 = dt.Rows.Count
       
        For I = 0 To dt.Rows.Count - 1
            'CriarLinha(dt.Rows.Item(I).Item("Pagamento").ToString & " R$", dt.Rows.Item(I).Item("Valor").ToString, rel.tab5)
            dblTotalCTPag += dt.Rows.Item(I).Item("Valor").ToString
            rel.tbTab5.Rows.Add()
            rel.tbTab5.Rows.Item(I).Item("Pagamento") = dt.Rows.Item(I).Item("Pagamento").ToString & " R$"
            rel.tbTab5.Rows.Item(I).Item("Valor") = dt.Rows.Item(I).Item("Valor").ToString
        Next
        rel.tbTotal5.Rows.Add()
        rel.tbTotal5.Rows.Item(0).Item("Pagamento") = "Total R$"
        rel.tbTotal5.Rows.Item(0).Item("Valor") = dblTotalCTPag.ToString("###,###,##0.00")
        strData = String.Format("DataPagamento >= '{0:dd/MM/yyyy}' AND DataPagamento <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro

        dt = CarregarDataTable("SELECT TipoConta, sum(Convert(Numeric(15,2),ValorPago)) as Valor " & _
        "FROM ContaPagar where PagoOK = 'True' and " & strData & " group by TipoConta")
        intLinha3 = dt.Rows.Count
        For I = 0 To dt.Rows.Count - 1
            'CriarLinha(dt.Rows.Item(I).Item("TipoConta").ToString & " R$", dt.Rows.Item(I).Item("Valor").ToString, rel.tab6)
            rel.tbTab6.Rows.Add()
            rel.tbTab6.Rows.Item(I).Item("Pagamento") = dt.Rows.Item(I).Item("TipoConta").ToString & " R$"
            rel.tbTab6.Rows.Item(I).Item("Valor") = dt.Rows.Item(I).Item("Valor").ToString
        Next
        rel.tbTotal6.Rows.Add()
        rel.tbTotal6.Rows.Item(0).Item("Pagamento") = "Total R$"
        rel.tbTotal6.Rows.Item(0).Item("Valor") = dblTotalCTPag.ToString("###,###,##0.00")
        VerificarLinhas(intLinha1, intLinha2, intLinha3, dblTotalFolhaPag, dblTotalCTPag, dblTotalCTPag, _
        rel.tbTab4, rel.tbTab5, rel.tbTab6, rel.Grid4, rel.Grid5, rel.Grid6)


        Dim dblTotalPago As Double = dblTotalFolhaPag + dblTotalCTPag


        rel.tbTotalPago.Rows.Add()
        rel.tbTotalPago.Rows.Item(0).Item("Pagamento") = "Total Pago R$"
        rel.tbTotalPago.Rows.Item(0).Item("Valor") = dblTotalPago.ToString("###,###,##0.00")


        Dim dblSaldoPeriodo As Double = dblTotalRecebidos - dblTotalPago


        rel.tbSaldo1.Rows.Add()
        rel.tbSaldo1.Rows.Item(0).Item("Pagamento") = "Saldo do Período R$"
        rel.tbSaldo1.Rows.Item(0).Item("Valor") = dblSaldoPeriodo.ToString("###,###,##0.00")


        strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Me.dtFinal.EditValue, Me.dtFinal.DateTime.AddDays(30)) & strFiltro

        dt = CarregarDataTable("SELECT Motivo, sum(Convert(Numeric(15,2),ValorComissao)) as Valor " & _
        "FROM Comissao where Tipo = 'C' and " & strData & " group by Motivo")
        Dim dblTotalFolhaPag2 As Double = 0
        intLinha1 = dt.Rows.Count
        For I = 0 To dt.Rows.Count - 1
            dblTotalFolhaPag2 += dt.Rows.Item(I).Item("Valor").ToString
            rel.tbTab7.Rows.Add()
            rel.tbTab7.Rows.Item(I).Item("Pagamento") = "COMISSÃO R$"
            rel.tbTab7.Rows.Item(I).Item("Valor") = dt.Rows.Item(I).Item("Valor").ToString
        Next

        dt = CarregarDataTable("SELECT Motivo, sum(Convert(Numeric(15,2),Valor)) as Valor " & _
        "FROM GastosFunc where Tipo = 'C' and " & strData & " group by Motivo")
        intLinha1 = intLinha1 + dt.Rows.Count
        For I = 0 To dt.Rows.Count - 1
            dblTotalFolhaPag2 += dt.Rows.Item(I).Item("Valor").ToString
            rel.tbTab7.Rows.Add()
            rel.tbTab7.Rows.Item(rel.tbTab7.Rows.Count - 1).Item("Pagamento") = dt.Rows.Item(I).Item("Motivo").ToString & " R$"
            rel.tbTab7.Rows.Item(rel.tbTab7.Rows.Count - 1).Item("Valor") = dt.Rows.Item(I).Item("Valor").ToString
        Next

        rel.tbTotal7.Rows.Add()
        rel.tbTotal7.Rows.Item(0).Item("Pagamento") = "Total R$"
        rel.tbTotal7.Rows.Item(0).Item("Valor") = dblTotalFolhaPag2.ToString("###,###,##0.00")
        strData = String.Format("Vencimento >= '{0:dd/MM/yyyy}' AND Vencimento <= '{1:dd/MM/yyyy}'", Me.dtFinal.EditValue, Me.dtFinal.DateTime.AddDays(30)) & strFiltro

        dt = CarregarDataTable("SELECT FormaPagamento as Pagamento, sum(Convert(Numeric(15,2),ValorParcela)) as Valor " & _
        "FROM ContaPagar where PagoOK = 'False' and " & strData & " group by FormaPagamento")

        Dim dblTotalCTPag2 As Double = 0
        intLinha2 = dt.Rows.Count

        For I = 0 To dt.Rows.Count - 1
            dblTotalCTPag2 += dt.Rows.Item(I).Item("Valor").ToString
            rel.tbTab8.Rows.Add()
            rel.tbTab8.Rows.Item(I).Item("Pagamento") = dt.Rows.Item(I).Item("Pagamento").ToString & " R$"
            rel.tbTab8.Rows.Item(I).Item("Valor") = dt.Rows.Item(I).Item("Valor").ToString
        Next

        rel.tbTotal8.Rows.Add()
        rel.tbTotal8.Rows.Item(0).Item("Pagamento") = "Total R$"
        rel.tbTotal8.Rows.Item(0).Item("Valor") = dblTotalCTPag2.ToString("###,###,##0.00")

        strData = String.Format("Vencimento >= '{0:dd/MM/yyyy}' AND Vencimento <= '{1:dd/MM/yyyy}'", Me.dtFinal.EditValue, Me.dtFinal.DateTime.AddDays(30)) & strFiltro

        dt = CarregarDataTable("SELECT Pagamento, sum(Convert(Numeric(15,2),ValorParcela)) as Valor " & _
        "FROM ContaReceber where RecebidoOK = 'False' and " & strData & " group by Pagamento")

        Dim dblTotalCTRec2 As Double = 0
        intLinha3 = dt.Rows.Count
        For I = 0 To dt.Rows.Count - 1
            dblTotalCTRec2 += dt.Rows.Item(I).Item("Valor").ToString
            rel.tbTab9.Rows.Add()
            rel.tbTab9.Rows.Item(I).Item("Pagamento") = dt.Rows.Item(I).Item("Pagamento").ToString & " R$"
            rel.tbTab9.Rows.Item(I).Item("Valor") = dt.Rows.Item(I).Item("Valor").ToString
        Next
       
        strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Me.dtFinal.EditValue, Me.dtFinal.DateTime.AddDays(30)) & strFiltro

        dt = CarregarDataTable("SELECT Pagamento, sum(Convert(Numeric(15,2),Futuro.TotalDesconto)) as Valor " & _
        "FROM Futuro where " & strData & " group by Pagamento")

        Dim dblTotalCartoes2 As Double = 0
        intLinha3 = dt.Rows.Count + intLinha3
        For I = 0 To dt.Rows.Count - 1
            dblTotalCartoes2 += dt.Rows.Item(I).Item("Valor").ToString
            rel.tbTab9.Rows.Add()
            rel.tbTab9.Rows.Item(rel.tbTab9.Rows.Count - 1).Item("Pagamento") = dt.Rows.Item(I).Item("Pagamento").ToString & " R$"
            rel.tbTab9.Rows.Item(rel.tbTab9.Rows.Count - 1).Item("Valor") = dt.Rows.Item(I).Item("Valor").ToString
        Next
        Dim dblAReceber As Double = dblTotalCTRec2 + dblTotalCartoes2

        rel.tbTotal9.Rows.Add()
        rel.tbTotal9.Rows.Item(0).Item("Pagamento") = "Total R$"
        rel.tbTotal9.Rows.Item(0).Item("Valor") = dblAReceber.ToString("###,###,##0.00")
        VerificarLinhas(intLinha1, intLinha2, intLinha3, dblTotalFolhaPag2, dblTotalCTPag2, dblAReceber, _
        rel.tbTab7, rel.tbTab8, rel.tbTab9, rel.Grid7, rel.Grid8, rel.Grid9)


        Dim dblSaldoPeriodo2 As Double = (dblAReceber - dblTotalFolhaPag2) - dblTotalCTPag2


        rel.tbSaldo2.Rows.Add()
        rel.tbSaldo2.Rows.Item(0).Item("Pagamento") = "Saldo do Período R$"
        rel.tbSaldo2.Rows.Item(0).Item("Valor") = dblSaldoPeriodo2.ToString("###,###,##0.00")

        rel.lblDataInicial.Text &= Me.dtInicial.Text
        rel.lblDataFinal.Text &= Me.dtFinal.Text

        rel.picLogo.Image = LogoTipo

        rel.ShowPreview()
        Me.Close()
    End Sub
End Class