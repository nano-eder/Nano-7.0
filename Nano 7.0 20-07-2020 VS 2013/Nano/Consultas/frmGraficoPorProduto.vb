Imports Nano.clsFuncoes
Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports DevExpress.XtraCharts

Public Class frmGraficoPorProduto

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


    Dim dblMedia As Double
    Dim dblValorMedia As Double
    Dim intQ As Integer
    Dim bolTitulo As Boolean = False
    Dim intCodConfig As Integer

    Private Sub Consultar(ByVal parColuna As String, ByVal parCodProd As String)
        If Me.cboAnoMes.SelectedIndex = 0 Then
            dt1 = CarregarDataTable("SELECT Month(Total.Data), " & parColuna & " FROM (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem) left join Produto on Pedido.CodProd = Produto.Codigo where " & parCodProd & " and Pedido.Devolvido = 'false' and year(Total.Data) = '" & intValAno & "' and Pedido.CodConfig = " & intCodConfig & " and Total.CodConfig = " & intCodConfig & " group by month(Total.Data) order by month(Total.Data)")
            For I = 0 To dt1.Rows.Count - 1
                dtMes = dt1.Rows.Item(I).ItemArray(0).ToString
                vetAno1(dtMes) = dt1.Rows.Item(I).ItemArray(1).ToString
            Next
            If intAno >= 1 Then
                dt2 = CarregarDataTable("SELECT Month(Total.Data), " & parColuna & "  FROM (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem) left join Produto on Pedido.CodProd = Produto.Codigo where " & parCodProd & " and Pedido.Devolvido = 'false' and year(Total.Data) = '" & intValAno - 1 & "' and Pedido.CodConfig = " & intCodConfig & " and Total.CodConfig = " & intCodConfig & " group by month(Total.Data) order by month(Total.Data)")
                For I = 0 To dt2.Rows.Count - 1
                    dtMes = dt2.Rows.Item(I).ItemArray(0).ToString
                    vetAno2(dtMes) = dt2.Rows.Item(I).ItemArray(1).ToString
                Next
            End If
            If intAno >= 2 Then
                dt3 = CarregarDataTable("SELECT Month(Total.Data), " & parColuna & " FROM (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem) left join Produto on Pedido.CodProd = Produto.Codigo where " & parCodProd & " and Pedido.Devolvido = 'false' and year(Total.Data) = '" & intValAno - 2 & "' and Pedido.CodConfig = " & intCodConfig & " and Total.CodConfig = " & intCodConfig & " group by month(Total.Data) order by month(Total.Data)")
                For I = 0 To dt3.Rows.Count - 1
                    dtMes = dt3.Rows.Item(I).ItemArray(0).ToString
                    vetAno3(dtMes) = dt3.Rows.Item(I).ItemArray(1).ToString
                Next
            End If
            If intAno >= 3 Then
                dt4 = CarregarDataTable("SELECT Month(Total.Data), " & parColuna & " FROM (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem) left join Produto on Pedido.CodProd = Produto.Codigo where " & parCodProd & " and Pedido.Devolvido = 'false' and year(Total.Data) = '" & intValAno - 3 & "' and Pedido.CodConfig = " & intCodConfig & " and Total.CodConfig = " & intCodConfig & " group by month(Total.Data) order by month(Total.Data)")
                For I = 0 To dt4.Rows.Count - 1
                    dtMes = dt4.Rows.Item(I).ItemArray(0).ToString
                    vetAno4(dtMes) = dt4.Rows.Item(I).ItemArray(1).ToString
                Next
            End If
            If intAno = 4 Then
                dt5 = CarregarDataTable("SELECT Month(Total.Data), " & parColuna & " FROM (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem) left join Produto on Pedido.CodProd = Produto.Codigo where " & parCodProd & " and Pedido.Devolvido = 'false' and year(Total.Data) = '" & intValAno - 4 & "' and Pedido.CodConfig = " & intCodConfig & " and Total.CodConfig = " & intCodConfig & " group by month(Total.Data) order by month(Total.Data)")
                For I = 0 To dt5.Rows.Count - 1
                    dtMes = dt5.Rows.Item(I).ItemArray(0).ToString
                    vetAno5(dtMes) = dt5.Rows.Item(I).ItemArray(1).ToString
                Next
            End If

        Else

            Dim dtData As String
            dt = CarregarDataTable("SELECT Day(Total.Data), " & parColuna & " FROM (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem) left join Produto on Pedido.CodProd = Produto.Codigo where " & parCodProd & " and Pedido.Devolvido = 'false' and year(Total.Data) = '" & intValAno & "' and Month(Total.Data)= '" & Me.cboMes.SelectedIndex + 1 & "' and Pedido.CodConfig = " & intCodConfig & " and Total.CodConfig = " & intCodConfig & " group by Day(Total.Data) order by Day(Total.Data)")
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
        Me.optAno.SelectedIndex = 0
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

    Private Sub frmGraficoPorProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "73")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub


    Private Sub frmGrafico_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If TesteConexao() = False Then Exit Sub

        If Master = True Then
            CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja)
            'Me.ConfigTableAdapter.Fill(Me.DsNanoCommerce.Config)
            Me.lueHosp.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            intCodConfig = Me.lueHosp.EditValue
        Else
            intCodConfig = CodConfig
        End If


        Me.cboAno1.Text = Year(Date.Today)
        Me.rgTipoGrafico.SelectedIndex = 0
        Me.cboAnoMes.Focus()

        strGrafico = "Barra"

        If Me.Tag = "Setor" Then
            CarregarDadosLue("SELECT Codigo, Nome FROM Grupo where Tipo = 'S'", Me.lueProduto)
            Me.Text = "Relatórios Gráfico por Setor"
            Me.lueProduto.Properties.Columns.Item(1).Caption = "Setor"
            Me.lblProd.Text = "Setor"
        ElseIf Me.Tag = "Grupo" Then
            CarregarDadosLue("SELECT Codigo, Nome FROM Grupo where Tipo = 'G'", Me.lueProduto)
            Me.Text = "Relatórios Gráfico por Vendedor"
            Me.lueProduto.Properties.Columns.Item(1).Caption = "Grupo"
            Me.lblProd.Text = "Vendedor"
            Me.lblProd.Location = New System.Drawing.Point(3, 15)
        ElseIf Me.Tag = "Vendedor" Then
            CarregarDadosLue("SELECT Codigo, Nome FROM Funcionario where codconfig = " & intCodConfig, Me.lueProduto)
            Me.Text = "Relatórios Gráfico por Vendedor"
            Me.lueProduto.Properties.Columns.Item(1).Caption = "Vendedor"
            Me.lblProd.Text = "Vendedor"

        Else
  

            'Me.lueProduto.Properties.DisplayMember = "Codigo"
            Me.lueProduto.Properties.ValueMember = "Codigo"
            CarregarDadosLue("SELECT CodigoInterno as Codigo, Nome FROM Produto", Me.lueProduto)
        End If
        If TipoNano = 5 Then
            Me.picFundo.EditValue = Global.Nano.My.Resources.Resources.NANOAutomotivo
        End If
        Me.lueProduto.Focus()
    End Sub

    Private Sub btnGerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerar.Click

        If TesteConexao() = False Then Exit Sub

        If Validar(Me.cboAnoMes) = False Then Exit Sub
        If Validar(Me.cboAno1) = False Then Exit Sub
        If Validar(Me.lueProduto) = False Then Exit Sub
        If Validar(Me.cboPor) = False Then Exit Sub
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

        'If intSerie = 1 Then
        '    Me.Grafico.Series.RemoveAt(0)
        'End If
        'If intSerie = 2 Then
        '    Me.Grafico.Series.RemoveAt(1)
        '    Me.Grafico.Series.RemoveAt(0)
        'End If
        'If intSerie = 3 Then
        '    Me.Grafico.Series.RemoveAt(2)
        '    Me.Grafico.Series.RemoveAt(1)
        '    Me.Grafico.Series.RemoveAt(0)
        'End If
        'If intSerie = 4 Then
        '    Me.Grafico.Series.RemoveAt(3)
        '    Me.Grafico.Series.RemoveAt(2)
        '    Me.Grafico.Series.RemoveAt(1)
        '    Me.Grafico.Series.RemoveAt(0)
        'End If
        'If intSerie = 5 Then
        '    Me.Grafico.Series.RemoveAt(4)
        '    Me.Grafico.Series.RemoveAt(3)
        '    Me.Grafico.Series.RemoveAt(2)
        '    Me.Grafico.Series.RemoveAt(1)
        '    Me.Grafico.Series.RemoveAt(0)
        'End If

        Me.Grafico.Series.Clear()
        intValAno = Me.cboAno1.Text
        If Master = True Then
            intCodConfig = Me.lueHosp.EditValue
        Else
            intCodConfig = CodConfig
        End If
        Select Case Me.cboPor.SelectedIndex
            Case 0
                If Me.Tag = "Setor" Then
                    Consultar("Convert(Numeric(15,2), sum(Pedido.ValorTotal))", " Setor = '" & Me.lueProduto.Text & "'")
                ElseIf Me.Tag = "Grupo" Then
                    Consultar("Convert(Numeric(15,2), sum(Pedido.ValorTotal))", " Grupo = '" & Me.lueProduto.Text & "'")
                ElseIf Me.Tag = "Vendedor" Then
                    Consultar("Convert(Numeric(15,2), sum(Pedido.ValorTotal))", " CodFunc = '" & Me.lueProduto.GetColumnValue("Codigo") & "'")
                Else
                    Consultar("Convert(Numeric(15,2), sum(Pedido.ValorTotal))", " Produto.CodigoInterno = '" & Me.lueProduto.GetColumnValue("Codigo") & "'")
                End If
            Case 1
                If Me.Tag = "Setor" Then
                    Consultar("Convert(Numeric(15,2), sum(Pedido.Custo))", " Setor = '" & Me.lueProduto.Text & "'")
                ElseIf Me.Tag = "Grupo" Then
                    Consultar("Convert(Numeric(15,2), sum(Pedido.Custo))", " Grupo = '" & Me.lueProduto.Text & "'")
                ElseIf Me.Tag = "Vendedor" Then
                    Consultar("Convert(Numeric(15,2), sum(Pedido.Custo))", " CodFunc = '" & Me.lueProduto.GetColumnValue("Codigo") & "'")
                Else
                    Consultar("Convert(Numeric(15,2), sum(Pedido.Custo))", " Produto.CodigoInterno = '" & Me.lueProduto.GetColumnValue("Codigo") & "'")
                End If

            Case 2
                If Me.Tag = "Setor" Then
                    Consultar("sum(Pedido.Qtd)", " Setor = '" & Me.lueProduto.Text & "'")
                ElseIf Me.Tag = "Grupo" Then
                    Consultar("sum(Pedido.Qtd)", " Grupo = '" & Me.lueProduto.Text & "'")
                ElseIf Me.Tag = "Vendedor" Then
                    Consultar("sum(Pedido.Qtd)", " CodFunc = '" & Me.lueProduto.GetColumnValue("Codigo") & "'")
                Else
                    Consultar("sum(Pedido.Qtd)", " Produto.CodigoInterno = '" & Me.lueProduto.GetColumnValue("Codigo") & "'")
                End If

           
        End Select


        Me.picFundo.Visible = False

        GerarGrafico(Me.Grafico, True)

        intSerie = Me.Grafico.Series.Count
        If intSerie > 0 Then
            Me.cboCorFundo.EditValue = Color.White
            Me.cboCorPainel.EditValue = Color.AntiqueWhite
            Me.cboPalete.EditValue = "Padrao"
        End If
    
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relGrafico
        rel.picLogo.Image = LogoTipo
        Dim strTitulo As String
        If Me.cboPor.SelectedIndex = 0 Then
            strTitulo = "Relatório de Venda"
        ElseIf Me.cboPor.SelectedIndex = 1 Then
            strTitulo = "Relatório de Custo"
        Else
            strTitulo = "Relatório de Qtd"
        End If
        If Me.Tag = "Setor" Then
            strTitulo = strTitulo & " por Setor"
        ElseIf Me.Tag = "Grupo" Then
            strTitulo = strTitulo & " por Grupo"
        ElseIf Me.Tag = "Vendedor" Then
            strTitulo = strTitulo & " por Vendedor"
        Else

            strTitulo = strTitulo & " por Produto"
        End If
        rel.lblTitulo.Text = strTitulo
        rel.lblTitulo2.Text = Me.lueProduto.EditValue

        GerarGrafico(rel.GraficoPrincipal, False)
        If Me.cboCorFundo.Caption = "" Then
            Me.cboCorFundo.EditValue = Color.White
        End If
        If Me.cboCorPainel.Caption = "" Then
            Me.cboCorPainel.EditValue = Color.AntiqueWhite
        End If
        If Me.cboPalete.Caption = "" Then
            Me.cboPalete.EditValue = "Padrao"
        End If
        If intSerie > 0 Then
            rel.GraficoPrincipal.PaletteName = Me.cboPalete.EditValue
            rel.GraficoPrincipal.BackColor = Me.cboCorFundo.EditValue
            If strGrafico <> "Pizza" Then
                CType(rel.GraficoPrincipal.Diagram, XYDiagram).DefaultPane.BackColor = Me.cboCorPainel.EditValue
            End If
        End If
     
        rel.ShowPreview()
    End Sub
    Private Sub GerarGrafico(ByVal parGrafico As Object, ByVal parTitulo As Boolean)
        Select Case Me.rgTipoGrafico.SelectedIndex
            Case 0
                For I = 0 To intAno
                    parGrafico.Series.Add(New Series("Series", ViewType.Bar))
                    parGrafico.Series(I).Name = Me.cboAno1.Text - I
                    If Me.cboPor.SelectedIndex = 0 Or Me.cboPor.SelectedIndex = 1 Then
                        parGrafico.Series(I).PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
                    Else
                        parGrafico.Series(I).PointOptions.ValueNumericOptions.Format = NumericFormat.Number
                    End If

                Next
                Select Case Me.cboAnoMes.SelectedIndex
                    Case 1
                        parGrafico.Series(0).Name = Me.cboMes.Text
                End Select
                Me.grpTipo.Text = "Gráfico de Barra"
            Case 2
                parGrafico.Series.Add(New Series("Series", ViewType.Pie))
                parGrafico.Series(0).LegendPointOptions.PointView = PointView.Argument
                parGrafico.Series(0).PointOptions.PointView = PointView.Argument
                CType(parGrafico.Series(0).PointOptions, PiePointOptions).PercentOptions.ValueAsPercent = False
                If Me.cboPor.SelectedIndex = 0 Or Me.cboPor.SelectedIndex = 1 Then
                    parGrafico.Series(0).PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
                Else
                    parGrafico.Series(0).PointOptions.ValueNumericOptions.Format = NumericFormat.Number
                End If
                Me.grpTipo.Text = "Gráfico de Pizza"
            Case 1
                For I = 0 To intAno
                    parGrafico.Series.Add(New Series("Series", ViewType.Line))
                    parGrafico.Series(I).Name = Me.cboAno1.Text - I
                    If Me.cboPor.SelectedIndex = 0 Or Me.cboPor.SelectedIndex = 1 Then
                        parGrafico.Series(I).PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
                    Else
                        parGrafico.Series(I).PointOptions.ValueNumericOptions.Format = NumericFormat.Number
                    End If
                Next
                Select Case Me.cboAnoMes.SelectedIndex
                    Case 1
                        parGrafico.Series(0).Name = Me.cboMes.Text
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
                    Select Case Me.rgTipoGrafico.SelectedIndex
                        Case 2
                            If vetAno1(I) <> Nothing Then
                                If Me.cboPor.SelectedIndex = 0 Or Me.cboPor.SelectedIndex = 1 Then
                                    parGrafico.Series(0).Points.Add(New SeriesPoint(strMes & " - R$ " & vetAno1(I), New Double() {vetAno1(I)}))
                                Else
                                    parGrafico.Series(0).Points.Add(New SeriesPoint(strMes & " - " & vetAno1(I), New Double() {vetAno1(I)}))
                                End If
                            End If
                          
                        Case Else
                            parGrafico.Series(0).Points.Add(New SeriesPoint(strMes, New Double() {vetAno1(I)}))
                    End Select

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
                Next
                If bolTitulo = True Then
                    parGrafico.Titles.RemoveAt(0)
                    bolTitulo = False
                End If
            Case 1
                If parTitulo = True Then
                    If bolTitulo = True Then
                        parGrafico.Titles.RemoveAt(0)
                    End If
                End If
                

                Dim chartTitle1 As New ChartTitle()

                dblValorMedia = 0
                intQ = 0
                For I = 1 To 31
                    Select Case strGrafico
                        Case "Pizza"
                            If vetMes(I) <> Nothing Then
                                'parGrafico.Series(0).Points.Add(New SeriesPoint(I, New Double() {vetMes(I)}))
                                If Me.cboPor.SelectedIndex = 0 Or Me.cboPor.SelectedIndex = 1 Then
                                    parGrafico.Series(0).Points.Add(New SeriesPoint(I & " - R$ " & vetMes(I), New Double() {vetMes(I)}))
                                Else
                                    parGrafico.Series(0).Points.Add(New SeriesPoint(I & " - " & vetMes(I), New Double() {vetMes(I)}))
                                End If
                            End If
                        Case Else
                            parGrafico.Series(0).Points.Add(New SeriesPoint(I, New Double() {vetMes(I)}))
                    End Select


                    If vetMes(I) <> Nothing Then
                        dblValorMedia += vetMes(I)
                        intQ += 1
                    End If
                Next
                dblMedia = dblValorMedia / intQ
                If Me.cboPor.SelectedIndex = 0 Then
                    chartTitle1.Text = "Valor Total de Venda do Período - R$ " & dblValorMedia.ToString("0.00")
                    chartTitle1.Text &= vbCrLf & "Média do Valor de Venda do Período - R$ " & dblMedia.ToString("0.00")
                ElseIf Me.cboPor.SelectedIndex = 1 Then
                    chartTitle1.Text = "Valor Total de Custo do Período - R$ " & dblValorMedia.ToString("0.00")
                    chartTitle1.Text &= vbCrLf & "Média do Valor de Custo do Período - R$ " & dblMedia.ToString("0.00")
                Else
                    chartTitle1.Text = "Qtde Total do Período - " & dblValorMedia.ToString("0.00")
                    chartTitle1.Text &= vbCrLf & "Média da Qtde do Período - " & dblMedia.ToString("0.00")
                End If

                parGrafico.Titles.Add(chartTitle1)
                bolTitulo = True
        End Select
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub


End Class