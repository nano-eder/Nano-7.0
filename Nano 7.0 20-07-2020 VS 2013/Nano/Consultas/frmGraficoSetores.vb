Imports Nano.clsFuncoes
Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports DevExpress.XtraCharts

Public Class frmGraficoSetores
    Dim strGrafico As String
    Dim I As Integer
    Dim bolVisualizar As Boolean = False
    Dim intSerie As Integer

    Dim dtI, dtF As Date

    Dim intNumSerie As Integer
    Dim intCodConfig As Integer
    Dim intQtd As Integer
    Private Sub rgTipoGrafico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgTipoGrafico.SelectedIndexChanged
        Select Case Me.rgTipoGrafico.SelectedIndex
            Case 0
                strGrafico = "Barra"
            Case 1
                strGrafico = "Linha"
            Case 2
                strGrafico = "Pizza"
        End Select
    End Sub

    Private Sub cboPalete_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPalete.EditValueChanged
        If intNumSerie > 0 Then
            Me.Grafico.PaletteName = Me.cboPalete.EditValue
        End If

    End Sub

    Private Sub cboCorPainel_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCorPainel.EditValueChanged
        If intNumSerie > 0 And strGrafico <> "Pizza" Then
            CType(Me.Grafico.Diagram, XYDiagram).DefaultPane.BackColor = Me.cboCorPainel.EditValue
        End If

    End Sub

    Private Sub cboCorFundo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCorFundo.EditValueChanged
        If intNumSerie > 0 Then
            Me.Grafico.BackColor = Me.cboCorFundo.EditValue
        End If
    End Sub

    Private Sub frmGraficoSetores_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "72")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub


    Private Sub frmGrafico_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       
        If TesteConexao() = False Then Exit Sub

        If Master = True Then
            Me.lueHosp.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            'Me.ConfigTableAdapter.Fill(Me.DsNanoCommerce.Config)
            CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja)
        End If

        If Me.Tag = "Vendedor" Then
            Me.LabelControl8.Visible = False
            Me.PanelControl1.Visible = False
            Me.LabelControl6.Text = "Produto"
            Me.cboTipoPes.Visible = False
            Me.lueProduto.Properties.ValueMember = "Codigo"
            CarregarDadosLue("SELECT Codigo, Nome, CodigoInterno FROM Produto", Me.lueProduto)
        Else
            Me.lueProduto.Visible = False
        End If
        If TipoNano = 5 Then
            Me.picFundo.EditValue = Global.Nano.My.Resources.Resources.NANOAutomotivo
        End If
        Me.rgTipoGrafico.SelectedIndex = 0
        Me.cboPor.Focus()
        strGrafico = "Barra"
    End Sub

    Private Sub btnGerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerar.Click

        If TesteConexao() = False Then Exit Sub

        If Validar(Me.cboPor) = False Then Exit Sub
        If Validar(Me.dtInicial) = False Then Exit Sub
        If Validar(Me.dtFinal) = False Then Exit Sub
        If Me.Tag <> "Vendedor" Then
            If Validar(Me.cboTipoPes) = False Then Exit Sub
        End If
     
        dtI = Me.dtInicial.Text
        dtF = Me.dtFinal.Text

        If dtF < dtI Then MsgBox("A data final não pode ser maior que a data inicial!", MsgBoxStyle.Information) : Exit Sub
 
        If Master = True Then
            intCodConfig = Me.lueHosp.EditValue
        Else
            intCodConfig = CodConfig
        End If
        Me.Grafico.Series.Clear()
        Me.picFundo.Visible = False


        GerarGrafico(Me.Grafico)

        If intNumSerie > 0 Then
            Me.cboCorFundo.EditValue = Color.White
            Me.cboCorPainel.EditValue = Color.AntiqueWhite
            Me.cboPalete.EditValue = "Padrao"
        End If
     
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relGrafico
        rel.picLogo.Image = LogoTipo
        If Me.Tag = "Vendedor" Then
            rel.lblTitulo.Text = "Relatório de Produto por Vendedor"
        Else
            Select Case Me.cboPor.SelectedIndex
                Case 0
                    rel.lblTitulo.Text = "Relatório de Consumo por Grupo"
                Case 1
                    rel.lblTitulo.Text = "Relatório de Consumo por Setor"
            End Select
        End If
      

        GerarGrafico(rel.GraficoPrincipal)
        If Me.cboCorFundo.Caption = "" Then
            Me.cboCorFundo.EditValue = Color.White
        End If
        If Me.cboCorPainel.Caption = "" Then
            Me.cboCorPainel.EditValue = Color.AntiqueWhite
        End If
        If Me.cboPalete.Caption = "" Then
            Me.cboPalete.EditValue = "Padrao"
        End If
        If intNumSerie > 0 Then
            rel.GraficoPrincipal.PaletteName = Me.cboPalete.EditValue
            rel.GraficoPrincipal.BackColor = Me.cboCorFundo.EditValue
            If strGrafico <> "Pizza" Then
                CType(rel.GraficoPrincipal.Diagram, XYDiagram).DefaultPane.BackColor = Me.cboCorPainel.EditValue
            End If
        End If
      
        rel.ShowPreview()
    End Sub
    Private Sub GerarGrafico(ByVal parGrafico As Object)
        If Me.Tag <> "Vendedor" Then
            If Me.cboTipoPes.SelectedIndex <> 3 Then
                'dtF = dtF.AddDays(1)
            End If
            If Me.cboTipoPes.SelectedIndex < 0 Then Exit Sub
        Else
            'dtF = dtF.AddDays(1)
        End If
   
        Dim strData As String = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", dtI, dtF)

        Dim strColuna As String = ""
        Dim strSetor As String = ""
        Dim strValor As String = ""
        Dim dt1 As DataTable = Nothing
        Select Case Me.cboPor.SelectedIndex
            Case 0
                strColuna = "sum(Pedido.ValorTotal)"
            Case 1
                strColuna = "sum(Pedido.Custo)"
            Case 2
                strColuna = "sum(Pedido.Qtd)"
        End Select

        Atualizar("UPDATE Produto set Setor = 'NULL' where Setor =''")

        If Me.Tag = "Vendedor" Then
            dt1 = CarregarDataTable("SELECT Convert(Numeric(15,2)," & strColuna & "), Funcionario.Nome FROM ((Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig)" & _
            "left join Produto on Pedido.CodProd = Produto.Codigo) Left join Funcionario on Pedido.CodFunc = Funcionario.Codigo where " & strData & " and " & _
            "Pedido.Devolvido = 'false' and Pedido.CodConfig = " & intCodConfig & " and Total.CodConfig = " & intCodConfig & " and Pedido.CodProd = " & Me.lueProduto.GetColumnValue("Codigo") & " group by Funcionario.Nome order by " & strColuna & " DESC")

        Else
            Select Case Me.cboTipoPes.SelectedIndex
                Case 0
                    dt1 = CarregarDataTable("SELECT Convert(Numeric(15,2)," & strColuna & "), Produto.Nome FROM (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig)left join Produto on Pedido.CodProd = Produto.Codigo where " & strData & " and Pedido.Devolvido = 'false' and Pedido.CodConfig = " & intCodConfig & " and Total.CodConfig = " & intCodConfig & " group by Produto.Nome order by " & strColuna & " DESC")

                Case 1
                    dt1 = CarregarDataTable("SELECT Convert(Numeric(15,2)," & strColuna & "), Produto.Grupo FROM (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig)left join Produto on Pedido.CodProd = Produto.Codigo where " & strData & " and Pedido.Devolvido = 'false' and Pedido.CodConfig = " & intCodConfig & " and Total.CodConfig = " & intCodConfig & " group by Produto.Grupo order by " & strColuna & " DESC")

                Case 2
                    dt1 = CarregarDataTable("SELECT Convert(Numeric(15,2)," & strColuna & "), Produto.Setor FROM (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig)left join Produto on Pedido.CodProd = Produto.Codigo where " & strData & " and Pedido.Devolvido = 'false' and Pedido.CodConfig = " & intCodConfig & " and Total.CodConfig = " & intCodConfig & " group by Produto.Setor order by " & strColuna & " DESC")

                Case 3
                    'dt1 = CarregarDataTable("SELECT Convert(Numeric(15,2)," & strColuna & "), Cliente.Nome  FROM ((Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem)left join Produto on Pedido.CodProd = Produto.Codigo)left join Cliente on Cliente.Codigo = Total.CodCli where " & strData & " and Pedido.Devolvido = 'false' and Pedido.CodConfig = " & intCodConfig & " and Total.CodConfig = " & intCodConfig & " group by Cliente.Nome order by " & strColuna & " DESC")
                    'dt1 = CarregarDataTable("SELECT Convert(Numeric(15,2)," & strColuna.Replace("Pedido", "ItensConsig") & "), Cliente.Nome from (((ItensConsig left join Produto on ItensConsig.CodigoProduto = Produto.Codigo) left join TotalConsig on ItensConsig.CodOrdens = TotalConsig.CodOrdens and ItensConsig.CodConfig = TotalConsig.CodConfig) left Join Cliente On TotalConsig.CodCli = Cliente.Codigo) left join Total on TotalConsig.CodOrdens = Total.CodPedido where " & strData.Replace("Total", "TotalConsig") & " and TotalConsig.Status <> 'Excluído' and ItensConsig.CodConfig = " & intCodConfig & " and TotalConsig.CodConfig = " & intCodConfig & " group by Cliente.Nome order by " & strColuna.Replace("Pedido", "ItensConsig") & " DESC")
                    dt1 = CarregarDataTable("SELECT Convert(Numeric(15,2)," & strColuna.Replace("Pedido", "ItensConsig") & "), Produto.Nome from (((ItensConsig left join Produto on ItensConsig.CodigoProduto = Produto.Codigo) left join TotalConsig on ItensConsig.CodOrdens = TotalConsig.CodOrdens and ItensConsig.CodConfig = TotalConsig.CodConfig) left Join Cliente On TotalConsig.CodCli = Cliente.Codigo) left join Total on TotalConsig.CodOrdens = Total.CodPedido where " & strData.Replace("Total", "TotalConsig") & " and TotalConsig.Status <> 'Excluído' and ItensConsig.CodConfig = " & intCodConfig & " and TotalConsig.CodConfig = " & intCodConfig & " group by Produto.Nome order by " & strColuna.Replace("Pedido", "ItensConsig") & " DESC")

            End Select
        End If


        intNumSerie = dt1.Rows.Count
        If intNumSerie = 0 Then Exit Sub
        Select Case cboQtd.SelectedIndex
            Case 0
                intQtd = 10
            Case 1
                intQtd = 15
            Case 2
                intQtd = 20
            Case 3
                intQtd = 30
            Case 4
                intQtd = 40
            Case 5
                intQtd = 50
            Case 6
                intQtd = dt1.Rows.Count
        End Select
        For I = 0 To intQtd - 1
            If dt1.Rows.Count <= I Then Exit For
            If dt1.Rows.Item(I).ItemArray(1).ToString = "NULL" Then
                Select Case Me.cboTipoPes.SelectedIndex
                    Case 0
                        strSetor = "SEM PRODUTO"
                    Case 1
                        strSetor = "SEM GRUPO"
                    Case 2
                        strSetor = "SEM SETOR"
                End Select

            ElseIf dt1.Rows.Item(I).ItemArray(1).ToString = "" Then

                strSetor = "EXCLUÍDO"

            Else

                strSetor = dt1.Rows.Item(I).ItemArray(1).ToString
            End If
            strValor = dt1.Rows.Item(I).ItemArray(0).ToString

            Select Case Me.rgTipoGrafico.SelectedIndex
                Case 0
                    parGrafico.Series.Add(New Series("Series", ViewType.Bar))
                    parGrafico.Series(I).Name = strSetor
                    If Me.cboPor.SelectedIndex = 0 Or Me.cboPor.SelectedIndex = 1 Then
                        parGrafico.Series(I).PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
                        parGrafico.Series(I).Points.Add(New SeriesPoint(strSetor, New Double() {strValor}))

                        ' parGrafico.Series(I).Label.Visible = False

                    Else
                        parGrafico.Series(I).PointOptions.ValueNumericOptions.Format = NumericFormat.Number
                        parGrafico.Series(I).Points.Add(New SeriesPoint(strSetor, New Double() {strValor}))
                        'parGrafico.Series(I).Label.Visible = False
                    End If
                    Me.grpTipo.Text = "Gráfico de Barra"




                    'CType(parGrafico.Diagram, XYDiagram).AxisX.Label.Antialiasing = True
                    'CType(parGrafico.Diagram, XYDiagram).AxisX.Label.Angle = 15
                    CType(parGrafico.Diagram, XYDiagram).AxisX.Label.Visible = False
                Case 2
                    parGrafico.Series.Add(New Series("Series", ViewType.Pie))
                    'parGrafico.Series(0).Name = strSetor
                    parGrafico.Series(0).LegendPointOptions.PointView = PointView.Argument
                    'parGrafico.Series(0).LegendPointOptions.PointView = PointView.ArgumentAndValues
                    'parGrafico.Series(0).PointOptions.PointView = PointView.Argument
                    CType(parGrafico.Series(0).PointOptions, PiePointOptions).PercentOptions.ValueAsPercent = False
                    If Me.cboPor.SelectedIndex = 0 Or Me.cboPor.SelectedIndex = 1 Then
                        parGrafico.Series(0).PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
                        parGrafico.Series(0).Points.Add(New SeriesPoint(strSetor & " - R$ " & strValor, New Double() {strValor}))
                    Else
                        parGrafico.Series(0).PointOptions.ValueNumericOptions.Format = NumericFormat.Number
                        parGrafico.Series(0).Points.Add(New SeriesPoint(strSetor & " - " & strValor, New Double() {strValor}))
                    End If
                    Me.grpTipo.Text = "Gráfico de Pizza"


                    ' CType(parGrafico.Series(0).Label, PieSeriesLabel).Position = PieSeriesLabelPosition.TwoColumns

                Case 1
                    parGrafico.Series.Add(New Series("Series", ViewType.Line))
                    parGrafico.Series(I).Name = strSetor
                    If Me.cboPor.SelectedIndex = 0 Or Me.cboPor.SelectedIndex = 1 Then
                        parGrafico.Series(I).PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
                        parGrafico.Series(I).Points.Add(New SeriesPoint(strSetor, New Double() {strValor}))

                    Else
                        parGrafico.Series(I).PointOptions.ValueNumericOptions.Format = NumericFormat.Number
                        parGrafico.Series(I).Points.Add(New SeriesPoint(strSetor, New Double() {strValor}))

                    End If
                    Me.grpTipo.Text = "Gráfico de Linha"

                    'CType(parGrafico.Diagram, XYDiagram).AxisX.Label.Antialiasing = True
                    'CType(parGrafico.Diagram, XYDiagram).AxisX.Label.Angle = 15
                    CType(parGrafico.Diagram, XYDiagram).AxisX.Label.Visible = False
            End Select

        Next
        'For I = 0 To intQtd - 1
        '    parGrafico.Series(I).Label.OverlappingOptions.ResolveOverlapping = True
        '    parGrafico.Series(I).Label.OverlappingOptions.Indent = 1
        'Next

    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub cboTipoPes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoPes.SelectedIndexChanged
        Me.cboQtd.Properties.Items.Clear()
        Select Case Me.cboTipoPes.SelectedIndex
            Case 0
                Me.cboQtd.Properties.Items.Add("10")
                Me.cboQtd.Properties.Items.Add("15")
                Me.cboQtd.Properties.Items.Add("20")
                Me.cboQtd.Properties.Items.Add("30")
                Me.cboQtd.Properties.Items.Add("40")
                Me.cboQtd.Properties.Items.Add("50")
            Case Else
                Me.cboQtd.Properties.Items.Add("10")
                Me.cboQtd.Properties.Items.Add("15")
                Me.cboQtd.Properties.Items.Add("20")
                Me.cboQtd.Properties.Items.Add("30")
                Me.cboQtd.Properties.Items.Add("40")
                Me.cboQtd.Properties.Items.Add("50")
                Me.cboQtd.Properties.Items.Add("TODOS")
        End Select
    End Sub

    Private Sub seAngulo_ItemPress(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles seAngulo.ItemPress

        Dim strAngulo As String = Me.seAngulo.EditValue
        If strAngulo = "" Then Exit Sub
        For I = 0 To intQtd - 1
            Me.Grafico.Series(I).Label.Antialiasing = True
            Me.Grafico.Series(I).Label.ResolveOverlappingMinIndent = Me.seAngulo.EditValue
        Next
    End Sub
End Class