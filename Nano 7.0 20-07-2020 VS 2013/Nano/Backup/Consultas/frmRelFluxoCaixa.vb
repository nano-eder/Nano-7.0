Imports Nano.clsFuncoes

Public Class frmRelFluxoCaixa

    Dim strFiltro As String

    Private Sub cboMes_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.EditValueChanged
        CarregaGrid()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub frmRelFluxoCaixa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "102")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmRelFluxoCaixa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub
        CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLojas)
        'Me.ConfigTableAdapter.Fill(Me.DsNanoCommerce.Config)
        ' Me.BancoTableAdapter.Fill(Me.DsNanoCommerce.Banco)
        PreencherOrdenado("Banco", Me.cboBanco, 1, 1)

        If Master = True Then
            Me.lueLoja.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If

        strFiltro = " and CodConfig =" & CodConfig

        'If SaldoCaixa = True Then
        '    If SaldoAtualCaixa = True Then
        '        Me.LabelControl4.Visible = False
        '        Me.txtSaldoAtual.Visible = False
        '    End If
        'Else
        Me.LabelControl4.Visible = False
        Me.txtSaldoAtual.Visible = False
        'End If

        Me.cboAno.EditValue = Date.Today.Year
        BaixarCartoes()
        CalculaSaldoBancos()
        CalculaTudo()
    End Sub
    Private Sub CalculaTudo()
        Dim dtCredito, dtDebito As DataTable
        Dim dblCredito, dblDebito, dblResultado As Double
        Dim strSQL As String = ""



        strSQL = "SELECT sum(Valor) FROM Caixa where Credito = 'C'" & strFiltro


        dtCredito = CarregarDataTable(strSQL)
        If dtCredito.Rows.Item(0).ItemArray(0).ToString = "" Then
            dblCredito = "0,00"
        Else
            dblCredito = dtCredito.Rows.Item(0).ItemArray(0).ToString
        End If

        strSQL = "SELECT sum(Valor) FROM Caixa where Credito = 'D'" & strFiltro

        dtDebito = CarregarDataTable(strSQL)

        If dtDebito.Rows.Item(0).ItemArray(0).ToString = "" Then
            dblDebito = "0,00"
        Else
            dblDebito = dtDebito.Rows.Item(0).ItemArray(0).ToString
        End If

        dblResultado = dblCredito - dblDebito
        Me.txtSaldoAtual.Text = dblResultado.ToString("###,###,###,##0.00")

    End Sub
    Private Sub CalculaSaldoBancos()
        Dim dblCred, dblDeb, dblSaldo As Double

        Dim dtBanco As DataTable

        dtBanco = CarregarDataTable("Select sum(Valor) as Valor from MovimentoBancario where TipoMovimento ='CRÉDITO'" & strFiltro)

        If dtBanco.Rows.Count > 0 Then
            If dtBanco.Rows(0).Item("Valor").ToString <> "" Then
                dblCred = dtBanco.Rows(0).Item("Valor").ToString
            End If
        End If

        dtBanco = CarregarDataTable("Select sum(Valor) as Valor from MovimentoBancario where TipoMovimento ='DÉBITO'" & strFiltro)

        If dtBanco.Rows.Count > 0 Then
            If dtBanco.Rows(0).Item("Valor").ToString <> "" Then
                dblDeb = dtBanco.Rows(0).Item("Valor").ToString
            End If

        End If

        dblSaldo = dblCred - dblDeb

        Me.txtSaldos.Text = dblSaldo.ToString("###,###,###,##0.00")
    End Sub

    Private Sub btnCus_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCus.ItemClick
        Me.Grid1.ShowPrintPreview()
    End Sub

    'Private Sub CarregaGrid()

    '    Dim intMes As Integer

    '    Select Case Me.cboMes.EditValue
    '        Case "Janeiro"
    '            intMes = 1
    '        Case "Fevereiro"
    '            intMes = 2
    '        Case "Março"
    '            intMes = 3
    '        Case "Abril"
    '            intMes = 4
    '        Case "Maio"
    '            intMes = 5
    '        Case "Junho"
    '            intMes = 6
    '        Case "Julho"
    '            intMes = 7
    '        Case "Agosto"
    '            intMes = 8
    '        Case "Setembro"
    '            intMes = 9
    '        Case "Outubro"
    '            intMes = 10
    '        Case "Novembro"
    '            intMes = 11
    '        Case "Dezembro"
    '            intMes = 12
    '    End Select
    '    Dim I As Integer

    '    Me.tbFluxo.Rows.Clear()

    '    If intMes = 0 Then Exit Sub

    '    For I = 0 To Date.DaysInMonth(Me.cboAno.EditValue, intMes) - 1
    '        Me.tbFluxo.Rows.Add()
    '        Me.tbFluxo.Rows.Item(I).Item("Dia") = I + 1
    '    Next

    '    Dim dtCartao, dtReceber, dtPagar As DataTable

    '    dtCartao = CarregarDataTable("Select Data, Sum(TotalDesconto) as Valor From Futuro where Month(Data) ='" & intMes & "' and Year(Data) ='" & Me.cboAno.EditValue & "' and Recebido ='False'" & strFiltro & " Group By Data")
    '    dtReceber = CarregarDataTable("Select Vencimento, Sum(ValorParcela) as ValorParcela from ContaReceber where  Month(Vencimento) ='" & intMes & "' and Year(Vencimento) ='" & Me.cboAno.EditValue & "' and RecebidoOK ='False'" & strFiltro & " Group By Vencimento")
    '    dtPagar = CarregarDataTable("Select Vencimento, Sum(ValorParcela) as ValorParcela from ContaPagar where  Month(Vencimento) ='" & intMes & "' and Year(Vencimento) ='" & Me.cboAno.EditValue & "' and PagoOK ='False'" & strFiltro & " Group By Vencimento")

    '    Dim intIndex As Integer
    '    For I = 0 To Me.grd1.RowCount - 1

    '        Dim dtData As Date
    '        Dim dblValor As Double

    '        If I <= dtCartao.Rows.Count - 1 Then
    '            dtData = dtCartao.Rows.Item(I).Item("Data")
    '            dblValor = dtCartao.Rows.Item(I).Item("Valor")

    '            intIndex = dtData.Day - 1
    '            Me.grd1.SetRowCellValue(intIndex, Me.colCartao, dblValor.ToString("0.00"))
    '        End If



    '        Dim dblValorParCR As Double

    '        If I <= dtReceber.Rows.Count - 1 Then
    '            dtData = dtReceber.Rows.Item(I).Item("Vencimento")
    '            dblValorParCR = dtReceber.Rows.Item(I).Item("ValorParcela")

    '            intIndex = dtData.Day - 1
    '            Me.grd1.SetRowCellValue(intIndex, Me.colReceber, dblValorParCR.ToString("0.00"))

    '        End If


    '        Dim dblValorParCP As Double

    '        If I <= dtPagar.Rows.Count - 1 Then
    '            dtData = dtPagar.Rows.Item(I).Item("Vencimento")
    '            dblValorParCP = dtPagar.Rows.Item(I).Item("ValorParcela")

    '            intIndex = dtData.Day - 1
    '            Me.grd1.SetRowCellValue(intIndex, Me.colPagar, dblValorParCP.ToString("0.00"))
    '        End If

    '    Next

    '    For I = 0 To Me.grd1.RowCount - 1
    '        Dim dblCartao, dblReceber, dblPagar, dblSaldo As Double

    '        If Me.grd1.GetRowCellDisplayText(I, Me.colCartao).ToString <> "" Then
    '            dblCartao = Me.grd1.GetRowCellDisplayText(I, Me.colCartao).ToString
    '        Else
    '            Me.grd1.SetRowCellValue(I, Me.colCartao, "0,00")
    '            dblCartao = 0
    '        End If

    '        If Me.grd1.GetRowCellDisplayText(I, Me.colReceber).ToString <> "" Then
    '            dblReceber = Me.grd1.GetRowCellDisplayText(I, Me.colReceber).ToString
    '        Else
    '            Me.grd1.SetRowCellValue(I, Me.colReceber, "0,00")
    '            dblReceber = 0
    '        End If

    '        If Me.grd1.GetRowCellDisplayText(I, Me.colPagar).ToString <> "" Then
    '            dblPagar = Me.grd1.GetRowCellDisplayText(I, Me.colPagar).ToString
    '        Else
    '            Me.grd1.SetRowCellValue(I, Me.colPagar, "0,00")
    '            dblPagar = 0
    '        End If

    '        dblSaldo = dblCartao + dblReceber - dblPagar

    '        Me.grd1.SetRowCellValue(I, Me.colSaldo, dblSaldo.ToString("0.00"))

    '    Next

    'End Sub
    Private Sub CarregaGrid()

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

        Dim strData As String = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro


        Dim I As Integer

        Me.tbFluxo.Rows.Clear()

        Dim dtCartao, dtReceber, dtPagar As DataTable

        dtCartao = CarregarDataTable("Select Data, Sum(TotalDesconto) as Valor, 'C' as Tipo From Futuro where " & String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro & " and Recebido ='False' Group By Data " & _
        "UNION ALL Select Vencimento as Data, Sum(ValorParcela) as Valor, 'R' as Tipo from ContaReceber where  " & String.Format("Vencimento >= '{0:dd/MM/yyyy}' AND Vencimento <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro & " and RecebidoOK ='False' Group By Vencimento " & _
        "UNION ALL Select Vencimento as Data, Sum(ValorParcela) as Valor, 'P' as Tipo from ContaPagar where  " & String.Format("Vencimento >= '{0:dd/MM/yyyy}' AND Vencimento <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro & " and PagoOK ='False' Group By Vencimento order by Data")

        Dim dtData1 As Date
        Me.tbFluxo.Rows.Clear()
        Dim A As Integer = 0
        For I = 0 To dtCartao.Rows.Count - 1

            Dim dtData As Date
            Dim dblValor As Double
            dtData = dtCartao.Rows.Item(I).Item("Data")
            dblValor = dtCartao.Rows.Item(I).Item("Valor")
            If dtData1 <> dtData Then
                dtData1 = dtCartao.Rows.Item(I).Item("Data")
                If I > 0 Then
                    A += 1
                End If
                Me.tbFluxo.Rows.Add()
                Dim strTipo As String = dtCartao.Rows.Item(I).Item("Tipo")
                Select Case strTipo
                    Case "C"

                        Me.tbFluxo.Rows.Item(A).Item("Data") = Format(dtData, "dd/MM/yyyy")
                        Me.tbFluxo.Rows.Item(A).Item("Cartao") = dblValor

                    Case "R"

                        Me.tbFluxo.Rows.Item(A).Item("Data") = Format(dtData, "dd/MM/yyyy")
                        Me.tbFluxo.Rows.Item(A).Item("Receber") = dblValor

                    Case "P"

                        Me.tbFluxo.Rows.Item(A).Item("Data") = Format(dtData, "dd/MM/yyyy")
                        Me.tbFluxo.Rows.Item(A).Item("Pagar") = dblValor

                End Select
            Else
                Dim strTipo As String = dtCartao.Rows.Item(I).Item("Tipo")
                Select Case strTipo
                    Case "C"

                        Me.tbFluxo.Rows.Item(A).Item("Data") = Format(dtData, "dd/MM/yyyy")
                        Me.tbFluxo.Rows.Item(A).Item("Cartao") = dblValor

                    Case "R"

                        Me.tbFluxo.Rows.Item(A).Item("Data") = Format(dtData, "dd/MM/yyyy")
                        Me.tbFluxo.Rows.Item(A).Item("Receber") = dblValor

                    Case "P"

                        Me.tbFluxo.Rows.Item(A).Item("Data") = Format(dtData, "dd/MM/yyyy")
                        Me.tbFluxo.Rows.Item(A).Item("Pagar") = dblValor

                End Select

            End If


        Next



        For I = 0 To Me.grd1.RowCount - 1
            Dim dblCartao, dblReceber, dblPagar, dblSaldo As Double

            If Me.grd1.GetRowCellDisplayText(I, Me.colCartao).ToString <> "" Then
                dblCartao = Me.grd1.GetRowCellDisplayText(I, Me.colCartao).ToString
            Else
                Me.grd1.SetRowCellValue(I, Me.colCartao, "0,00")
                dblCartao = 0
            End If

            If Me.grd1.GetRowCellDisplayText(I, Me.colReceber).ToString <> "" Then
                dblReceber = Me.grd1.GetRowCellDisplayText(I, Me.colReceber).ToString
            Else
                Me.grd1.SetRowCellValue(I, Me.colReceber, "0,00")
                dblReceber = 0
            End If

            If Me.grd1.GetRowCellDisplayText(I, Me.colPagar).ToString <> "" Then
                dblPagar = Me.grd1.GetRowCellDisplayText(I, Me.colPagar).ToString
            Else
                Me.grd1.SetRowCellValue(I, Me.colPagar, "0,00")
                dblPagar = 0
            End If

            dblSaldo = dblCartao + dblReceber - dblPagar

            Me.grd1.SetRowCellValue(I, Me.colSaldo, dblSaldo.ToString("0.00"))

        Next

    End Sub
    Private Sub cboBanco_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBanco.EditValueChanged
        Dim strNome As String
        Dim dblCred, dblDeb, dblSaldo As Double
        Dim intCod As Integer

        strNome = Me.cboBanco.Text
        Dim dtBanco As DataTable
        dtBanco = CarregarDataTable("SELECT Codigo, Saldo FROM Banco where Nome = '" & strNome & "'")
        If dtBanco.Rows.Count > 0 Then
            intCod = dtBanco.Rows.Item(0).Item("Codigo").ToString
        End If

        dtBanco = CarregarDataTable("Select sum(Valor) as Valor from MovimentoBancario where TipoMovimento ='CRÉDITO' and CodBanco =" & intCod & strFiltro)

        If dtBanco.Rows.Count > 0 Then
            If dtBanco.Rows(0).Item("Valor").ToString <> "" Then
                dblCred = dtBanco.Rows(0).Item("Valor").ToString
            End If
        End If

        dtBanco = CarregarDataTable("Select sum(Valor) as Valor from MovimentoBancario where TipoMovimento ='DÉBITO' and CodBanco =" & intCod & strFiltro)

        If dtBanco.Rows.Count > 0 Then
            If dtBanco.Rows(0).Item("Valor").ToString <> "" Then
                dblDeb = dtBanco.Rows(0).Item("Valor").ToString
            End If

        End If

        dblSaldo = dblCred - dblDeb

        Me.txtSaldo.Text = dblSaldo.ToString("###,###,###,##0.00")
    End Sub

    Private Sub lueLoja_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueLoja.EditValueChanged
        strFiltro = " and CodConfig =" & Me.lueLoja.EditValue

        'Me.tbFluxo.Rows.Clear()
        CalculaSaldoBancos()

        Me.txtSaldo.ResetText()

        'CarregaGrid()

    End Sub

    Private Sub btnRelFluxo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelFluxo.ItemClick
        Dim rel As New relFluxoCaixa

        Dim I As Integer
        Dim dtDataInicial As Date
        Dim dtDataFinal As Date
        Dim dtDT As Date
        For I = 0 To Me.grd1.RowCount - 1
            rel.tbFluxo.Rows.Add()
            rel.tbFluxo.Rows.Item(I).Item("Data") = Me.grd1.GetRowCellDisplayText(I, Me.colData).ToString
            'rel.tbFluxo.Rows.Item(I).Item("Dia") = Me.grd1.GetRowCellDisplayText(I, Me.colDia).ToString
            rel.tbFluxo.Rows.Item(I).Item("Cartao") = Me.grd1.GetRowCellValue(I, Me.colCartao)
            rel.tbFluxo.Rows.Item(I).Item("Receber") = Me.grd1.GetRowCellValue(I, Me.colReceber).ToString
            rel.tbFluxo.Rows.Item(I).Item("Pagar") = Me.grd1.GetRowCellValue(I, Me.colPagar).ToString
            rel.tbFluxo.Rows.Item(I).Item("Saldo") = Me.grd1.GetRowCellValue(I, Me.colSaldo).ToString

            dtDT = grd1.GetRowCellDisplayText(I, Me.colData)
            If I = 0 Then
                dtDataInicial = dtDT
                dtDataFinal = dtDT
            End If
            If dtDT < dtDataInicial Then
                dtDataInicial = dtDT
            End If
            If dtDT > dtDataFinal Then
                dtDataFinal = dtDT
            End If
        Next

        rel.lblPeriodo.Text = "De " & Format(dtDataInicial, "dd/MM/yyyy") & " a " & Format(dtDataFinal, "dd/MM/yyyy")
        rel.celSado.Text = Me.txtSaldos.Text.Trim
        rel.celSaldoAtual.Text = Me.txtSaldoAtual.Text.Trim

        rel.picLogo.Image = LogoTipo

        rel.ShowPreview()

    End Sub

    Private Sub btnFiltrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFiltrar.ItemClick
        CarregaGrid()
        BaixarCartoes()
        CalculaSaldoBancos()
        CalculaTudo()
    End Sub
End Class