Imports Nano.clsFuncoes
Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports DevExpress.XtraCharts

Public Class frmGrafico

    Dim strQuery1, strQuery2, strQuery3, strQuery4, strQuery5 As String
    Dim vetAno1(12), vetAno2(12), vetAno3(12), vetAno4(12), vetAno5(12), vetMes(31) As String
    Dim dt, dt1, dt2, dt3, dt4, dt5 As DataTable
    Dim dtMes As Integer
    Dim intAno As Integer
    Dim intValAno As Integer
    Dim strGrafico As String
    Dim strMes As String
    Dim I As Integer
    Dim bolVisualizar As Boolean = False
    Dim intSerie As Integer
    Dim dblValorSql As Double
    Dim strFiltro As String = ""

    Dim intCodConfig As Integer

    Dim vetTotal As Array

    Private Sub Consultar(ByVal parColuna As String, ByVal parTabela As String, ByVal parData As String, ByVal parAdicional As String)

        Select Case Me.cboLoja.EditValue
            Case "SOMADO"
                strFiltro = ""
            Case Else
                Dim dtConfig As DataTable = CarregarDataTable("SELECT Codigo FROM Config where Descricao = '" & Me.cboLoja.EditValue & "'")
                If dtConfig.Rows.Count > 0 Then
                    intCodConfig = dtConfig.Rows.Item(0).Item("Codigo").ToString
                End If

                If Me.Tag = "" Then

                    Select Case Me.cboFatLuc.SelectedIndex
                        Case 0, 1
                            strFiltro = " and Total.CodConfig =" & intCodConfig
                        Case Else
                            If Me.cboFatLuc.Text = "SAT" Then
                                strFiltro = " and CodConfig =" & intCodConfig
                            Else
                                strFiltro = " and ItensConsig.CodConfig =" & intCodConfig
                            End If
                    End Select
                  


                Else
                    strFiltro = " and CodConfig =" & intCodConfig
                End If
        End Select

        If parTabela = "" Then
            parTabela = "Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and Total.CodConfig = Pedido.CodConfig"
        End If
        If Me.cboAnoMes.SelectedIndex = 0 Then
            dt1 = CarregarDataTable("SELECT Month(" & parData & "), " & parColuna & " FROM " & parTabela & " where " & parAdicional & " and  year(" & parData & ") = '" & intValAno & "'" & strFiltro & " group by month(" & parData & ") order by month(" & parData & ")")
            For I = 0 To dt1.Rows.Count - 1
                dtMes = dt1.Rows.Item(I).ItemArray(0).ToString
                If dt1.Rows.Item(I).ItemArray(1).ToString = "" Then
                    dblValorSql = Nothing
                Else
                    dblValorSql = dt1.Rows.Item(I).ItemArray(1).ToString
                End If
                vetAno1(dtMes) = dblValorSql
            Next
            If intAno >= 1 Then
                dt2 = CarregarDataTable("SELECT Month(" & parData & "), " & parColuna & " FROM " & parTabela & " where " & parAdicional & " and year(" & parData & ") = '" & intValAno - 1 & "'" & strFiltro & " group by month(" & parData & ") order by month(" & parData & ")")
                For I = 0 To dt2.Rows.Count - 1
                    dtMes = dt2.Rows.Item(I).ItemArray(0).ToString
                    If dt2.Rows.Item(I).ItemArray(1).ToString = "" Then
                        dblValorSql = Nothing
                    Else
                        dblValorSql = dt2.Rows.Item(I).ItemArray(1).ToString
                    End If
                    vetAno2(dtMes) = dblValorSql
                Next
            End If
            If intAno >= 2 Then
                dt3 = CarregarDataTable("SELECT Month(" & parData & "), " & parColuna & " FROM " & parTabela & " where " & parAdicional & " and year(" & parData & ") = '" & intValAno - 2 & "'" & strFiltro & " group by month(" & parData & ") order by month(" & parData & ")")
                For I = 0 To dt3.Rows.Count - 1
                    dtMes = dt3.Rows.Item(I).ItemArray(0).ToString
                    If dt3.Rows.Item(I).ItemArray(1).ToString = "" Then
                        dblValorSql = Nothing
                    Else
                        dblValorSql = dt3.Rows.Item(I).ItemArray(1).ToString
                    End If
                    vetAno3(dtMes) = dblValorSql
                Next
            End If
            If intAno >= 3 Then
                dt4 = CarregarDataTable("SELECT Month(" & parData & "), " & parColuna & " FROM " & parTabela & " where " & parAdicional & " and year(" & parData & ") = '" & intValAno - 3 & "'" & strFiltro & " group by month(" & parData & ") order by month(" & parData & ")")
                For I = 0 To dt4.Rows.Count - 1
                    dtMes = dt4.Rows.Item(I).ItemArray(0).ToString
                    If dt4.Rows.Item(I).ItemArray(1).ToString = "" Then
                        dblValorSql = Nothing
                    Else
                        dblValorSql = dt4.Rows.Item(I).ItemArray(1).ToString
                    End If
                    vetAno4(dtMes) = dblValorSql
                Next
            End If
            If intAno = 4 Then
                dt5 = CarregarDataTable("SELECT Month(" & parData & "), " & parColuna & " FROM " & parTabela & " where " & parAdicional & " and year(" & parData & ") = '" & intValAno - 4 & "'" & strFiltro & " group by month(" & parData & ") order by month(" & parData & ")")
                For I = 0 To dt5.Rows.Count - 1
                    dtMes = dt5.Rows.Item(I).ItemArray(0).ToString
                    If dt5.Rows.Item(I).ItemArray(1).ToString = "" Then
                        dblValorSql = Nothing
                    Else
                        dblValorSql = dt5.Rows.Item(I).ItemArray(1).ToString
                    End If
                    vetAno5(dtMes) = dblValorSql
                Next
            End If

        Else

            Dim dtData As String
            dt = CarregarDataTable("SELECT Day(" & parData & "), " & parColuna & " FROM " & parTabela & " where " & parAdicional & " and year(" & parData & ") = '" & intValAno & "' and Month(" & parData & ")= '" & Me.cboMes.SelectedIndex + 1 & "'" & strFiltro & " group by Day(" & parData & ") order by Day(" & parData & ")")
            If dt.Rows.Count > 0 Then
                For I = 0 To dt.Rows.Count - 1
                    dtData = dt.Rows.Item(I).ItemArray(0).ToString
                    If dt.Rows.Item(I).ItemArray(1).ToString <> "" Then
                        vetMes(dtData) = dt.Rows.Item(I).ItemArray(1).ToString
                    End If
                Next
            End If
        End If

    End Sub

    Private Sub ConsultarComparativo(ByVal parColuna As String, ByVal parTabela As String, ByVal parData As String, ByVal parAdicional As String)

   
        Dim dtConfig As DataTable = CarregarDataTable("SELECT Codigo FROM Config Order by Codigo")
        Dim I As Integer

        For I = 0 To dtConfig.Rows.Count - 1
            intCodConfig = dtConfig.Rows.Item(I).Item("Codigo").ToString
            If Me.Tag = "" Then
                If Me.cboFatLuc.SelectedIndex = 2 Then
                    strFiltro = " and CodConfig =" & intCodConfig
                Else
                    strFiltro = " and Total.CodConfig =" & intCodConfig
                End If


            Else
                strFiltro = " and CodConfig =" & intCodConfig
            End If
            If parTabela = "" Then
                parTabela = "Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and Total.CodConfig = Pedido.CodConfig"
            End If
            dt1 = CarregarDataTable("SELECT Month(" & parData & "), " & parColuna & " FROM " & parTabela & " where " & parAdicional & " and  year(" & parData & ") = '" & intValAno & "'" & strFiltro & " group by month(" & parData & ") order by month(" & parData & ")")
            Dim A As Integer

            For A = 0 To dt1.Rows.Count - 1
                dtMes = dt1.Rows.Item(A).ItemArray(0).ToString
                If dt1.Rows.Item(A).ItemArray(1).ToString = "" Then
                    dblValorSql = Nothing
                Else
                    dblValorSql = dt1.Rows.Item(A).ItemArray(1).ToString
                End If
                Select Case I
                    Case 0
                        vetAno1(dtMes) = dblValorSql
                    Case 1
                        vetAno2(dtMes) = dblValorSql
                    Case 2
                        vetAno3(dtMes) = dblValorSql
                    Case 3
                        vetAno4(dtMes) = dblValorSql
                    Case 4
                        vetAno5(dtMes) = dblValorSql
                End Select

            Next
        Next

    End Sub

    Private Sub rgTipoGrafico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgTipoGrafico.SelectedIndexChanged
        Select Case Me.rgTipoGrafico.SelectedIndex
            Case 0
                strGrafico = "Barra"
                Select Case Me.cboAnoMes.SelectedIndex
                    Case 0
                        Me.lblPesquisa.Enabled = True
                        Me.pnlPesquisa.Enabled = True
                    Case 1
                        Me.lblPesquisa.Enabled = False
                        Me.pnlPesquisa.Enabled = False
                End Select
            Case 1
                strGrafico = "Linha"
                Select Case Me.cboAnoMes.SelectedIndex
                    Case 0
                        Me.lblPesquisa.Enabled = True
                        Me.pnlPesquisa.Enabled = True
                    Case 1
                        Me.lblPesquisa.Enabled = False
                        Me.pnlPesquisa.Enabled = False
                End Select
            Case 2
                strGrafico = "Pizza"
                Me.lblPesquisa.Enabled = False
                Me.pnlPesquisa.Enabled = False
                intAno = 0
        End Select
    End Sub

    Private Sub optAno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAno.SelectedIndexChanged
        Select Case Me.optAno.SelectedIndex
            Case 0
                intAno = 0
            Case 1
                intAno = 1
            Case 2
                intAno = 2
            Case 3
                intAno = 3
            Case 4
                intAno = 4
        End Select
    End Sub

    Private Sub cboAnoMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnoMes.SelectedIndexChanged

        Select Case Me.cboAnoMes.SelectedIndex
            Case 0
                Select Case strGrafico
                    Case "Pizza"
                        Me.lblPesquisa.Enabled = False
                        Me.pnlPesquisa.Enabled = False
                    Case Else
                        Me.lblPesquisa.Enabled = True
                        Me.pnlPesquisa.Enabled = True
                End Select
                Me.lblMes.Enabled = False
                Me.cboMes.Enabled = False
                Me.cboMes.SelectedIndex = -1
            Case 1
                Me.lblMes.Enabled = True
                Me.cboMes.Enabled = True
                Me.lblPesquisa.Enabled = False
                Me.pnlPesquisa.Enabled = False
        End Select

        If Me.cboAnoMes.Text = "MÊS" Then
            Me.optAno.SelectedIndex = 0
        End If
    End Sub

    Private Sub cboPalete_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPalete.EditValueChanged
        If intSerie > 0 Then
            Me.Grafico.PaletteName = Me.cboPalete.EditValue
        End If

    End Sub

    Private Sub cboCorPainel_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCorPainel.EditValueChanged
        If intSerie > 0 And strGrafico <> "Pizza" Then
            CType(Me.Grafico.Diagram, XYDiagram).DefaultPane.BackColor = Me.cboCorPainel.EditValue
        End If

    End Sub

    Private Sub cboCorFundo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCorFundo.EditValueChanged
        If intSerie > 0 Then
            Me.Grafico.BackColor = Me.cboCorFundo.EditValue
        End If
    End Sub

    Private Sub frmGrafico_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    If Me.Tag = "RECEBER" Then
                        Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "100")
                    ElseIf Me.Tag = "PAGAR" Then
                        Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "101")
                    Else
                        Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "71")
                    End If
               End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub


    Private Sub frmGrafico_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Master = True Then
            Dim dt As DataTable = CarregarDataTable("SELECT Codigo, Descricao FROM Config")
            Dim strDesc As String = ""
            For I = 0 To dt.Rows.Count - 1
                Me.cboLojas.Items.Add(dt.Rows.Item(I).Item("Descricao").ToString)
                Dim intCod As Integer = dt.Rows.Item(I).Item("Codigo").ToString
                If intCod = CodConfig Then
                    strDesc = dt.Rows.Item(I).Item("Descricao").ToString
                End If
            Next
            Me.cboLojas.Items.Add("SOMADO")
            Me.cboLojas.Items.Add("COMPARATIVO")
            Me.cboLoja.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

            Me.cboLoja.EditValue = strDesc

        End If

        If TesteConexao() = False Then Exit Sub

        Me.cboAno1.Text = Year(Date.Today)
        Me.rgTipoGrafico.SelectedIndex = 0

        strGrafico = "Barra"

        Me.cboFatLuc.Properties.Items.Clear()
        Select Case Me.Tag
            Case ""
                Me.cboFatLuc.Properties.Items.Add("FATURAMENTO")
                Me.cboFatLuc.Properties.Items.Add("LUCRO")
                If AbaSatFiscal = True Then
                    Me.cboFatLuc.Properties.Items.Add("SAT")
                End If
                Me.cboFatLuc.Properties.Items.Add("PEDIDO")
            Case "RECEBER"
                Me.cboFatLuc.Properties.Items.Add("A RECEBER")
                Me.cboFatLuc.Properties.Items.Add("RECEBIDAS")
            Case "PAGAR"
                Me.cboFatLuc.Properties.Items.Add("A PAGAR")
                Me.cboFatLuc.Properties.Items.Add("PAGAS")
        End Select
        If TipoNano = 5 Then
            Me.picFundo.EditValue = Global.Nano.My.Resources.Resources.NANOAutomotivo
        End If
    End Sub

    Private Sub btnGerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerar.Click
        intCodConfig = CodConfig
        If TesteConexao() = False Then Exit Sub

        If Validar(Me.cboFatLuc) = False Then Exit Sub
        If Validar(Me.cboAnoMes) = False Then Exit Sub
        If Validar(Me.cboAno1) = False Then Exit Sub
        Select Case Me.cboAnoMes.SelectedIndex
            Case 1
                If Validar(Me.cboMes) = False Then Exit Sub
        End Select

        For I = 0 To 31
            vetMes(I) = Nothing
            If I <= 12 Then
                vetAno1(I) = Nothing
                vetAno2(I) = Nothing
                vetAno3(I) = Nothing
                vetAno4(I) = Nothing
                vetAno5(I) = Nothing
            End If
        Next
        Try
            If intSerie = 1 Then
                Me.Grafico.Series.RemoveAt(0)
            End If
            If intSerie = 2 Then
                Me.Grafico.Series.RemoveAt(1)
                Me.Grafico.Series.RemoveAt(0)
            End If
            If intSerie = 3 Then
                Me.Grafico.Series.RemoveAt(2)
                Me.Grafico.Series.RemoveAt(1)
                Me.Grafico.Series.RemoveAt(0)
            End If
            If intSerie = 4 Then
                Me.Grafico.Series.RemoveAt(3)
                Me.Grafico.Series.RemoveAt(2)
                Me.Grafico.Series.RemoveAt(1)
                Me.Grafico.Series.RemoveAt(0)
            End If
            If intSerie = 5 Then
                Me.Grafico.Series.RemoveAt(4)
                Me.Grafico.Series.RemoveAt(3)
                Me.Grafico.Series.RemoveAt(2)
                Me.Grafico.Series.RemoveAt(1)
                Me.Grafico.Series.RemoveAt(0)
            End If
        Catch ex As Exception

        End Try
      


        intValAno = Me.cboAno1.Text

        Select Case Me.cboLoja.EditValue
            Case "COMPARATIVO"
                Select Case Me.Tag
                    Case ""
                        Select Case Me.cboFatLuc.SelectedIndex
                            Case 0
                                ConsultarComparativo("Convert(Numeric(15,2),sum(Pedido.ValorTotal))", "", "Data", "Devolvido = 'False'")
                            Case 1
                                ConsultarComparativo("Convert(Numeric(15,2),(sum(Pedido.ValorTotal) - sum(Pedido.Custo)))", "", "Data", "Devolvido = 'False'")
                            Case Else
                                If Me.cboFatLuc.Text = "SAT" Then
                                    ConsultarComparativo("Convert(Numeric(15,2),sum(SatFiscal.ValorTotal))", "SatFiscal", "Data", "ChaveCancelamento Is Null And CodOrdem > 0")

                                Else
                                    ConsultarComparativo("Convert(Numeric(15,2),sum(ItensConsig.ValorTotal))", "(((ItensConsig left join Produto on ItensConsig.CodigoProduto = Produto.Codigo) " & _
        "left join TotalConsig on ItensConsig.CodOrdens = TotalConsig.CodOrdens and ItensConsig.CodConfig = TotalConsig.CodConfig) " & _
        "left Join Cliente On TotalConsig.CodCli = Cliente.Codigo) left join Total on TotalConsig.CodOrdens = Total.CodPedido", "TotalConsig.Data", "ItensConsig.CodOrdens > 0'")

                                End If
                             
                        End Select
                    Case "RECEBER"
                        Select Case Me.cboFatLuc.SelectedIndex
                            Case 0
                                ConsultarComparativo("Convert(Numeric(15,2),sum(ValorParcela))", "ContaReceber", "Vencimento", "RecebidoOK = 'False'")
                            Case 1
                                ConsultarComparativo("Convert(Numeric(15,2),sum(ValorRecebido))", "ContaReceber", "Recebimento", "RecebidoOK = 'True'")


                        End Select
                    Case "PAGAR"
                        Select Case Me.cboFatLuc.SelectedIndex
                            Case 0
                                ConsultarComparativo("Convert(Numeric(15,2),sum(ValorParcela))", "ContaPagar", "Vencimento", "PagoOK = 'False'")
                            Case 1
                                ConsultarComparativo("Convert(Numeric(15,2),sum(ValorPago))", "ContaPagar", "DataPagamento", "PagoOK = 'True'")

                        End Select
                End Select
            Case Else
                Select Case Me.Tag
                    Case ""
                        Select Case Me.cboFatLuc.SelectedIndex
                            Case 0
                                Consultar("Convert(Numeric(15,2),sum(Pedido.ValorTotal))", "", "Data", "Devolvido = 'False'")
                            Case 1
                                Consultar("Convert(Numeric(15,2),(sum(Pedido.ValorTotal) - sum(Pedido.Custo)))", "", "Data", "Devolvido = 'False'")
                            Case Else
                                If Me.cboFatLuc.Text = "SAT" Then
                                    Consultar("Convert(Numeric(15,2),sum(SatFiscal.ValorTotal))", "SatFiscal", "Data", "ChaveCancelamento Is Null And CodOrdem > 0")

                                Else
                                    'Consultar("Convert(Numeric(15,2),sum(ItensConsig.ValorTotal))", "ItensConsig left join TotalConsig on ItensConsig.CodOrdens = TotalConsig.CodOrdens and ItensConsig.CodConfig = TotalConsig.CodConfig", "Data", "ItensConsig.CodOrdens > 0")
                                    Consultar("Convert(Numeric(15,2),sum(ItensConsig.ValorTotal))", "(((ItensConsig left join Produto on ItensConsig.CodigoProduto = Produto.Codigo) " & _
        "left join TotalConsig on ItensConsig.CodOrdens = TotalConsig.CodOrdens and ItensConsig.CodConfig = TotalConsig.CodConfig) " & _
        "left Join Cliente On TotalConsig.CodCli = Cliente.Codigo) left join Total on TotalConsig.CodOrdens = Total.CodPedido", "TotalConsig.Data", "ItensConsig.CodOrdens > 0")

                                End If
                              
                        End Select
                    Case "RECEBER"
                        Select Case Me.cboFatLuc.SelectedIndex
                            Case 0
                                Consultar("Convert(Numeric(15,2),sum(ValorParcela))", "ContaReceber", "Vencimento", "RecebidoOK = 'False'")
                            Case 1
                                Consultar("Convert(Numeric(15,2),sum(ValorRecebido))", "ContaReceber", "Recebimento", "RecebidoOK = 'True'")


                        End Select
                    Case "PAGAR"
                        Select Case Me.cboFatLuc.SelectedIndex
                            Case 0
                                Consultar("Convert(Numeric(15,2),sum(ValorParcela))", "ContaPagar", "Vencimento", "PagoOK = 'False'")
                            Case 1
                                Consultar("Convert(Numeric(15,2),sum(ValorPago))", "ContaPagar", "DataPagamento", "PagoOK = 'True'")

                        End Select
                End Select
        End Select

        

        Me.picFundo.Visible = False

        GerarGrafico(Me.Grafico)

        intSerie = Me.Grafico.Series.Count

        Me.cboCorFundo.EditValue = Color.White
        Me.cboCorPainel.EditValue = Color.AntiqueWhite
        Me.cboPalete.EditValue = "Padrao"
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relGrafico
        ' rel.picLogo.Image = LogoTipo
        Select Case Me.Tag
            Case ""
                Select Case Me.cboFatLuc.SelectedIndex
                    Case 0
                        rel.lblTitulo.Text = "Relatório de Faturamento"
                    Case 1
                        rel.lblTitulo.Text = "Relatório de Lucro"
                End Select
            Case "RECEBER"
                Select Case Me.cboFatLuc.SelectedIndex
                    Case 0
                        rel.lblTitulo.Text = "Relatório de Contas a Receber"
                    Case 1
                        rel.lblTitulo.Text = "Relatório de Contas Recebidas"
                End Select
            Case "PAGAR"
                Select Case Me.cboFatLuc.SelectedIndex
                    Case 0
                        rel.lblTitulo.Text = "Relatório de Contas a Pagar"
                    Case 1
                        rel.lblTitulo.Text = "Relatório de Contas Pagas"
                End Select
        End Select
      
        GerarGrafico(rel.GraficoPrincipal)
        If Me.cboCorFundo.EditValue = Nothing Then
            Me.cboCorFundo.EditValue = Color.White
        End If
        If Me.cboCorPainel.EditValue = Nothing Then
            Me.cboCorPainel.EditValue = Color.AntiqueWhite
        End If
        If Me.cboPalete.EditValue = Nothing Then
            Me.cboPalete.EditValue = "Padrao"
        End If
        rel.GraficoPrincipal.PaletteName = Me.cboPalete.EditValue
        rel.GraficoPrincipal.BackColor = Me.cboCorFundo.EditValue

        rel.picLogo.Image = LogoTipo

        If strGrafico <> "Pizza" Then
            CType(rel.GraficoPrincipal.Diagram, XYDiagram).DefaultPane.BackColor = Me.cboCorPainel.EditValue
        End If
        rel.ShowPreview()
    End Sub

    Private Sub CalcularTotalAno()
        Dim dbl1 As Double = 0
        Dim dbl2 As Double = 0
        Dim dbl3 As Double = 0
        Dim dbl4 As Double = 0
        Dim dbl5 As Double = 0

        Dim I As Integer
        For I = 0 To vetAno1.Length
            Try
                Dim dbl As Double = vetAno1(I).ToString.Trim
                dbl1 = dbl1 + dbl
            Catch ex As Exception
            End Try
        Next

        I = 0
        For I = 0 To vetAno2.Length
            Try
                Dim dbl As Double = vetAno2(I).ToString.Trim
                dbl2 = dbl2 + dbl
            Catch ex As Exception
            End Try
        Next

        I = 0
        For I = 0 To vetAno3.Length
            Try
                Dim dbl As Double = vetAno3(I).ToString.Trim
                dbl3 = dbl3 + dbl
            Catch ex As Exception
            End Try
        Next

        I = 0
        For I = 0 To vetAno4.Length
            Try
                Dim dbl As Double = vetAno4(I).ToString.Trim
                dbl4 = dbl4 + dbl
            Catch ex As Exception
            End Try
        Next

        I = 0
        For I = 0 To vetAno5.Length
            Try
                Dim dbl As Double = vetAno5(I).ToString.Trim
                dbl5 = dbl5 + dbl
            Catch ex As Exception
            End Try
        Next

        Dim result As String = dbl1.ToString("###,###,##0.00") & "|" & dbl2.ToString("###,###,##0.00") & "|" & dbl3.ToString("###,###,##0.00") & "|" & dbl4.ToString("###,###,##0.00") & "|" & dbl5.ToString("###,###,##0.00")
        vetTotal = result.Split("|")
    End Sub
    Private Sub CalcularTotalMes()
        Dim dbl1 As Double = 0

        Dim I As Integer
        For I = 0 To vetMes.Length
            Try
                Dim dbl As Double = vetMes(I).ToString.Trim
                dbl1 = dbl1 + dbl
            Catch ex As Exception
            End Try
        Next

        Dim result As String = dbl1.ToString("###,###,##0.00")
        vetTotal = result.Split("|")
    End Sub

    Private Sub GerarGrafico(ByVal parGrafico As Object)
        Dim intLoja As Integer

        If Me.cboAnoMes.Text = "ANO" Then
            CalcularTotalAno()
        ElseIf Me.cboAnoMes.Text = "MÊS" Then
            CalcularTotalMes()
        End If
        Select Case Me.rgTipoGrafico.SelectedIndex
            Case 0
                Select Case Me.cboLoja.EditValue
                    Case "COMPARATIVO"
                        Dim dtConfig As DataTable = CarregarDataTable("SELECT Codigo, Descricao FROM Config")
                        Dim I As Integer
                        intLoja = dtConfig.Rows.Count
                        For I = 0 To dtConfig.Rows.Count - 1
                            intCodConfig = dtConfig.Rows.Item(I).Item("Codigo").ToString

                            parGrafico.Series.Add(New Series("Series", ViewType.Bar))
                            parGrafico.Series(I).Name = dtConfig.Rows.Item(I).Item("Descricao").ToString
                            parGrafico.Series(I).PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
                            parGrafico.Series(I).Label.OverlappingOptions.ResolveOverlapping = True
                            parGrafico.Series(I).Label.OverlappingOptions.Indent = 1
                        Next
                    Case Else
                        For I = 0 To intAno
                            parGrafico.Series.Add(New Series("Series", ViewType.Bar))
                            'parGrafico.Series(I).Name = Me.cboAno1.Text - I
                            parGrafico.Series(I).Name = Me.cboAno1.Text - I & " - R$ " & vetTotal(I).ToString.Trim
                            parGrafico.Series(I).PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
                            parGrafico.Series(I).Label.OverlappingOptions.ResolveOverlapping = True
                            parGrafico.Series(I).Label.OverlappingOptions.Indent = 1
                        Next
                        Select Case Me.cboAnoMes.SelectedIndex
                            Case 1
                                'parGrafico.Series(0).Name = Me.cboMes.Text
                                parGrafico.Series(0).Name = Me.cboMes.Text & " - R$ " & vetTotal(0).ToString.Trim
                        End Select
                End Select

                Me.grpTipo.Text = "Gráfico de Barra"
            Case 2
                Select Case Me.cboLoja.EditValue
                    Case "COMPARATIVO"
                        Exit Sub
                    Case Else
                        parGrafico.Series.Add(New Series("Series", ViewType.Pie))
                        parGrafico.Series(0).LegendPointOptions.PointView = PointView.Argument
                        parGrafico.Series(0).PointOptions.PointView = PointView.ArgumentAndValues
                        CType(parGrafico.Series(0).PointOptions, PiePointOptions).PercentOptions.ValueAsPercent = False
                        parGrafico.Series(0).PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
                End Select

                Me.grpTipo.Text = "Gráfico de Pizza"
            Case 1
                Select Case Me.cboLoja.EditValue
                    Case "COMPARATIVO"
                        Dim dtConfig As DataTable = CarregarDataTable("SELECT Codigo, Descricao FROM Config")
                        Dim I As Integer
                        intLoja = dtConfig.Rows.Count
                        For I = 0 To dtConfig.Rows.Count - 1
                            intCodConfig = dtConfig.Rows.Item(I).Item("Codigo").ToString

                            parGrafico.Series.Add(New Series("Series", ViewType.Line))
                            parGrafico.Series(I).Name = dtConfig.Rows.Item(I).Item("Descricao").ToString
                            parGrafico.Series(I).PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
                            parGrafico.Series(I).Label.OverlappingOptions.ResolveOverlapping = True
                            parGrafico.Series(I).Label.OverlappingOptions.Indent = 1
                        Next
                    Case Else
                        For I = 0 To intAno
                            parGrafico.Series.Add(New Series("Series", ViewType.Line))
                            'parGrafico.Series(I).Name = Me.cboAno1.Text - I
                            parGrafico.Series(I).Name = Me.cboAno1.Text - I & " - R$ " & vetTotal(I).ToString.Trim
                            parGrafico.Series(I).PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
                            parGrafico.Series(I).Label.OverlappingOptions.ResolveOverlapping = True
                            parGrafico.Series(I).Label.OverlappingOptions.Indent = 1
                        Next
                        Select Case Me.cboAnoMes.SelectedIndex
                            Case 1
                                'parGrafico.Series(0).Name = Me.cboMes.Text
                                parGrafico.Series(0).Name = Me.cboMes.Text & " - R$ " & vetTotal(0).ToString.Trim
                        End Select
                End Select

                Me.grpTipo.Text = "Gráfico de Linha"
        End Select
        Select Case Me.cboAnoMes.SelectedIndex
            Case 0
                For I = 1 To 12
                    Select Case I
                        Case 1
                            strMes = "Janeiro"
                        Case 2
                            strMes = "Fevereiro"
                        Case 3
                            strMes = "Março"
                        Case 4
                            strMes = "Abril"
                        Case 5
                            strMes = "Maio"
                        Case 6
                            strMes = "Junho"
                        Case 7
                            strMes = "Julho"
                        Case 8
                            strMes = "Agosto"
                        Case 9
                            strMes = "Setembro"
                        Case 10
                            strMes = "Outubro"
                        Case 11
                            strMes = "Novembro"
                        Case 12
                            strMes = "Dezembro"
                    End Select

                    Select Case Me.cboLoja.EditValue
                        Case "COMPARATIVO"
                            Dim A As Integer
                            For A = 0 To intLoja - 1
                                Select Case A
                                    Case 0
                                        parGrafico.Series(0).Points.Add(New SeriesPoint(strMes, New Double() {vetAno1(I)}))
                                    Case 1
                                        parGrafico.Series(1).Points.Add(New SeriesPoint(strMes, New Double() {vetAno2(I)}))
                                    Case 2
                                        parGrafico.Series(2).Points.Add(New SeriesPoint(strMes, New Double() {vetAno3(I)}))
                                    Case 3
                                        parGrafico.Series(3).Points.Add(New SeriesPoint(strMes, New Double() {vetAno4(I)}))
                                    Case 4
                                        parGrafico.Series(4).Points.Add(New SeriesPoint(strMes, New Double() {vetAno5(I)}))
                                End Select


                            Next

                        Case Else
                            parGrafico.Series(0).Points.Add(New SeriesPoint(strMes, New Double() {vetAno1(I)}))
                            If intAno > 0 Then
                                parGrafico.Series(1).Points.Add(New SeriesPoint(strMes, New Double() {vetAno2(I)}))
                            End If
                            If intAno > 1 Then
                                parGrafico.Series(2).Points.Add(New SeriesPoint(strMes, New Double() {vetAno3(I)}))
                            End If
                            If intAno > 2 Then
                                parGrafico.Series(3).Points.Add(New SeriesPoint(strMes, New Double() {vetAno4(I)}))
                            End If
                            If intAno > 3 Then
                                parGrafico.Series(4).Points.Add(New SeriesPoint(strMes, New Double() {vetAno5(I)}))
                            End If
                    End Select

                Next

            Case 1
                For I = 1 To 31
                    Select Case strGrafico
                        Case "Pizza"
                            If vetMes(I) <> Nothing Then
                                parGrafico.Series(0).Points.Add(New SeriesPoint(I, New Double() {vetMes(I)}))
                            End If
                        Case Else
                            parGrafico.Series(0).Points.Add(New SeriesPoint(I, New Double() {vetMes(I)}))
                    End Select
                Next
        End Select
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick

    End Sub

    Private Sub cboLoja_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLoja.EditValueChanged
        For I = 0 To 31
            vetMes(I) = Nothing
            If I <= 12 Then
                vetAno1(I) = Nothing
                vetAno2(I) = Nothing
                vetAno3(I) = Nothing
                vetAno4(I) = Nothing
                vetAno5(I) = Nothing
            End If
        Next
        Try
            If intSerie = 1 Then
                Me.Grafico.Series.RemoveAt(0)
            End If
            If intSerie = 2 Then
                Me.Grafico.Series.RemoveAt(1)
                Me.Grafico.Series.RemoveAt(0)
            End If
            If intSerie = 3 Then
                Me.Grafico.Series.RemoveAt(2)
                Me.Grafico.Series.RemoveAt(1)
                Me.Grafico.Series.RemoveAt(0)
            End If
            If intSerie = 4 Then
                Me.Grafico.Series.RemoveAt(3)
                Me.Grafico.Series.RemoveAt(2)
                Me.Grafico.Series.RemoveAt(1)
                Me.Grafico.Series.RemoveAt(0)
            End If
            If intSerie = 5 Then
                Me.Grafico.Series.RemoveAt(4)
                Me.Grafico.Series.RemoveAt(3)
                Me.Grafico.Series.RemoveAt(2)
                Me.Grafico.Series.RemoveAt(1)
                Me.Grafico.Series.RemoveAt(0)
            End If
        Catch ex As Exception

        End Try
        
        Me.cboMes.SelectedIndex = -1
        Me.cboAno1.SelectedIndex = -1
        Me.cboFatLuc.SelectedIndex = -1
        Me.cboMes.SelectedIndex = -1
        Me.cboAnoMes.SelectedIndex = -1

        Me.rgTipoGrafico.SelectedIndex = 0
        Me.optAno.Enabled = True
        Me.cboMes.Enabled = True
        Me.cboAnoMes.Properties.Items.Clear()
        Me.cboAno1.Text = Year(Date.Today)
        Select Case Me.cboLoja.EditValue
            Case "COMPARATIVO"
                Me.optAno.Enabled = False
                Me.cboAnoMes.Properties.Items.Add("ANO")
                Me.cboMes.Enabled = False
            Case Else
                Me.cboAnoMes.Properties.Items.Add("ANO")
                Me.cboAnoMes.Properties.Items.Add("MÊS")
        End Select
        Me.picFundo.Visible = True
        Me.cboAnoMes.Focus()
    End Sub
End Class