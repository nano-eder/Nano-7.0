Imports Nano.clsFuncoes
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing.Drawing2D

Imports System

Imports System.Drawing

Imports System.Collections

Imports System.Windows.Forms

Imports DevExpress.XtraEditors.Controls

Imports DevExpress.XtraEditors.Persistent

Imports DevExpress.XtraEditors.Repository

Imports DevExpress.XtraGrid.Columns

Imports System.Reflection
Public Class frmRelInformativo


    Private Sub frmRelInformativo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim I As Integer
        For I = 2000 To 2050
            Me.cboAno1.Items.Add(I)
        Next
        Me.cboAno.EditValue = Date.Today.Year

        GerarRelatorio(Me.cboAno.EditValue)
    End Sub
    Private Sub GerarRelatorio(ByVal parAno As String)
        Dim I As Integer

        Me.tbInf.Rows.Clear()

        Dim strMes As String = ""
      
        Dim A As Integer = 0
     
        Dim dtGrupo As DataTable = Nothing

        dtGrupo = CarregarDataTable("SELECT sum(Codigo), Grupo, Fabricante FROM Produto group by Grupo, Fabricante order by Grupo, Fabricante")
        Dim intTotalPorPeriodo As Integer = dtGrupo.Rows.Count + 5
        With Me.tbInf.Rows
            For A = 0 To 5
                Dim strPeriodo As String = ""
                Select Case A
                    Case 0
                        strPeriodo = "01 a 07"
                    Case 1
                        strPeriodo = "08 a 14"
                    Case 2
                        strPeriodo = "15 a 21"
                    Case 3
                        strPeriodo = "22 a 28"
                    Case 4
                        strPeriodo = "29 a 31"
                    Case 5
                        strPeriodo = "Total"
                End Select
                .Add()
                .Item(.Count - 1).Item("Nome") = "A: TOTAIS"
                .Item(.Count - 1).Item("Fornecedor") = "TOTAL VENDA"
                .Item(.Count - 1).Item("Periodo") = strPeriodo
                .Add()
                .Item(.Count - 1).Item("Nome") = "A: TOTAIS"
                .Item(.Count - 1).Item("Fornecedor") = "TOTAL PEÇAS VENDIDAS"
                .Item(.Count - 1).Item("Periodo") = strPeriodo
                .Add()
                .Item(.Count - 1).Item("Nome") = "A: TOTAIS"
                .Item(.Count - 1).Item("Fornecedor") = "FAT. SEMANA"
                .Item(.Count - 1).Item("Periodo") = strPeriodo

                Dim strNomeGrupo As String = ""
                For I = 0 To dtGrupo.Rows.Count - 1

                    .Add()
                    Dim strGrupo As String = dtGrupo.Rows.Item(I).Item("Grupo").ToString
                 
                    If strNomeGrupo <> strGrupo Then
                        If strNomeGrupo = "" Then
                            strNomeGrupo = strGrupo
                        Else
                            If A = 0 Then
                                intTotalPorPeriodo += 1
                            End If

                            .Item(.Count - 1).Item("Nome") = strNomeGrupo
                            .Item(.Count - 1).Item("Fornecedor") = "TOTAL"
                            .Item(.Count - 1).Item("Periodo") = strPeriodo
                            .Add()
                            strNomeGrupo = strGrupo
                        End If

                    End If
                    .Item(.Count - 1).Item("Nome") = dtGrupo.Rows.Item(I).Item("Grupo").ToString
                    .Item(.Count - 1).Item("Fornecedor") = dtGrupo.Rows.Item(I).Item("Fabricante").ToString
                    .Item(.Count - 1).Item("Periodo") = strPeriodo
                    If I = dtGrupo.Rows.Count - 1 Then
                        .Add()
                        .Item(.Count - 1).Item("Nome") = strNomeGrupo
                        .Item(.Count - 1).Item("Fornecedor") = "TOTAL"
                        .Item(.Count - 1).Item("Periodo") = strPeriodo
                        If A = 0 Then
                            intTotalPorPeriodo += 1
                        End If
                    End If
                Next

                .Add()
                .Item(.Count - 1).Item("Nome") = "Z: TOTAIS"
                .Item(.Count - 1).Item("Fornecedor") = "PA"
                .Item(.Count - 1).Item("Periodo") = strPeriodo
                .Add()
                .Item(.Count - 1).Item("Nome") = "Z: TOTAIS"
                .Item(.Count - 1).Item("Fornecedor") = "TICKET MÉDIO"
                .Item(.Count - 1).Item("Periodo") = strPeriodo
            Next


            Dim J As Integer = 0
            Dim M As Integer = 0
            For I = 0 To 11

                For M = 0 To 5

                    Dim strDataInicial As String = ""
                    Dim strDataFinal As String = ""

                    Dim strPeriodo As String = ""
                    J = intTotalPorPeriodo * M

                    Select Case M
                        Case 0

                            strPeriodo = "01 a 07"
                            strDataInicial = "01/" & I + 1 & "/" & parAno
                            strDataFinal = "07/" & I + 1 & "/" & parAno
                        Case 1

                            strPeriodo = "08 a 14"
                            strDataInicial = "08/" & I + 1 & "/" & parAno
                            strDataFinal = "14/" & I + 1 & "/" & parAno
                        Case 2

                            strPeriodo = "15 a 21"
                            strDataInicial = "15/" & I + 1 & "/" & parAno
                            strDataFinal = "21/" & I + 1 & "/" & parAno
                        Case 3

                            strPeriodo = "22 a 28"
                            strDataInicial = "22/" & I + 1 & "/" & parAno
                            strDataFinal = "28/" & I + 1 & "/" & parAno
                        Case 4

                            strPeriodo = "29 a 31"
                            Dim strUltimoDia As Date = UltimoDiaMes("01/" & I + 1 & "/" & parAno)
                            If strUltimoDia.Day > 28 Then
                                strDataInicial = "29/" & I + 1 & "/" & parAno
                                strDataFinal = strUltimoDia.Day & "/" & I + 1 & "/" & parAno
                            End If


                        Case 5

                            strPeriodo = "Total"
                            strDataInicial = "01/" & I + 1 & "/" & parAno

                            Dim strUltimoDia As Date = UltimoDiaMes("01/" & I + 1 & "/" & parAno)

                            strDataFinal = strUltimoDia.Day & "/" & I + 1 & "/" & parAno



                    End Select
                    If strDataInicial <> "" Then


                        'Dim strData As String = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", strDataInicial, strDataFinal)

                        'Dim dtVenda As DataTable = CarregarDataTable("SELECT Total.CodOrdem, (Total.Data + Total.Hora) as Data, " & _
                        '"Total.CodCli, Convert(Numeric(15,2),Troco) as Troco, Convert(Numeric(15,2),PorDesc) as PorDesc, " & _
                        '"Convert(Numeric(15,2),ValDesc) as ValDesc, Convert(Numeric(15,2),sum(Pedido.Custo)) as Custo, " & _
                        '"Convert(Numeric(15,2),sum(ValorTotal)) as Total, Convert(Numeric(15,2), " & _
                        '"sum(ValorTotal) - sum(Pedido.Custo)) as Lucro, Cliente.Nome, Total.CodConfig " & _
                        '"FROM (Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and " & _
                        '"Total.CodConfig = Pedido.CodConfig) left join Cliente on Total.CodCli = Cliente.Codigo " & _
                        '"where Pedido.Devolvido = 'False' and " & strData & " and total.CodConfig= " & CodConfig & " " & _
                        '"group by Total.CodOrdem, Total.Data, Total.CodCli, Total.Troco, Total.PorDesc, Total.ValDesc, Cliente.Nome, Total.CodConfig, Total.Hora")

                        Dim strData As String = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", strDataInicial, strDataFinal)

                        Dim dtVenda As DataTable = CarregarDataTable("SELECT Total.CodOrdem, (Total.Data + Total.Hora) as Data, " & _
                        "Total.CodCli, Convert(Numeric(15,2),Troco) as Troco, Convert(Numeric(15,2),PorDesc) as PorDesc, " & _
                        "Convert(Numeric(15,2),ValDesc) as ValDesc, Convert(Numeric(15,2),sum(Pedido.Custo)) as Custo, " & _
                        "Convert(Numeric(15,2),sum(ValorTotal)) as Total, Convert(Numeric(15,2), " & _
                        "sum(ValorTotal) - sum(Pedido.Custo)) as Lucro, Cliente.Nome, Total.CodConfig " & _
                        "FROM (Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and " & _
                        "Total.CodConfig = Pedido.CodConfig) left join Cliente on Total.CodCli = Cliente.Codigo " & _
                        "where Pedido.Devolvido = 'False' and " & strData & " and total.CodConfig= " & CodConfig & " " & _
                        "group by Total.CodOrdem, Total.Data, Total.CodCli, Total.Troco, Total.PorDesc, Total.ValDesc, Cliente.Nome, Total.CodConfig, Total.Hora")

                        If dtVenda.Rows.Count > 0 Then

                            Dim intQtdeVenda As Integer = dtVenda.Rows.Count

                            .Item(J).Item(I + 1) = intQtdeVenda
                            J += 1

                            dtVenda = CarregarDataTable("SELECT  sum(Qtd) as Qtd " & _
                            "FROM Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and Total.CodConfig = Pedido.CodConfig " & _
                            "where " & strData & " and Total.CodConfig = " & CodConfig & " and Devolvido = 'False'")

                            Dim dblQtdProduto As Double = dtVenda.Rows.Item(0).Item("Qtd").ToString

                            dtVenda = CarregarDataTable("SELECT sum(ValorProduto) as Total " & _
                            "FROM Total left join Comissao on Total.CodOrdem = Comissao.CodOrdem and Total.CodConfig = Comissao.CodConfig " & _
                            "where " & strData & " and Total.CodConfig = " & CodConfig)

                            Dim dblTotalProduto As Double = dtVenda.Rows.Item(0).Item("Total").ToString

                            .Item(J).Item(I + 1) = dblQtdProduto.ToString("0")
                            J += 1
                            .Item(J).Item(I + 1) = dblTotalProduto.ToString("###,##0.000")
                            J += 1


                            dtVenda = CarregarDataTable("SELECT  sum(ValorTotal) as Total, convert(Numeric(15),sum(Qtd)) as Qtd, " & _
                            "Produto.Grupo, Produto.Fabricante FROM (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem " & _
                            "and Pedido.CodConfig = Total.CodConfig) left join Produto on Pedido.CodProd = Produto.Codigo " & _
                            "where " & strData & " and Pedido.CodConfig = " & CodConfig & " and Devolvido = 'False' group by " & _
                            "Produto.Grupo, Produto.Fabricante order by Produto.Grupo, Produto.Fabricante")

                            Dim H As Integer = 0
                            Dim strGrupoComp As String = ""
                            Dim dblQtdSomada As Double = 0

                            For A = 0 To dtVenda.Rows.Count - 1
                                Dim strGrupoVenda As String = dtVenda.Rows.Item(A).Item("Grupo").ToString
                                Dim strFornecedor As String = dtVenda.Rows.Item(A).Item("Fabricante").ToString
                                Dim strQtdProduto As String = dtVenda.Rows.Item(A).Item("Qtd").ToString

                                For H = 0 To dtGrupo.Rows.Count
                                    Dim sddd As String = .Item(J).Item("Nome")
                                    If strGrupoVenda = .Item(J).Item("Nome") Then
                                        If strFornecedor = .Item(J).Item("Fornecedor") Then
                                            .Item(J).Item(I + 1) = strQtdProduto
                                            .Item(J).Item("Periodo") = strPeriodo

                                            Exit For

                                        End If

                                    End If
                                    J += 1
                                Next
                            Next

                            J = (intTotalPorPeriodo * (M + 1)) - 2
                            Dim dblPA As Double = dblQtdProduto / intQtdeVenda
                            Dim dblMedia As Double = dblTotalProduto / intQtdeVenda
                            .Item(J).Item(I + 1) = dblPA.ToString("###,##0.00")
                            J += 1
                            .Item(J).Item(I + 1) = dblMedia.ToString("###,##0.00")

                        End If
                    End If
                Next
            Next
        End With

        Me.GridView1.ExpandAllGroups()

        I = 0
   
        Dim dblJan, dblFev, dblMar, dblAbr, dblMai, dblJun, dblJul, dblAgo, dblSet, dblOut, dblNov, dblDez As Double

        For I = 0 To Me.GridView1.RowCount - 1
           
            If Me.GridView1.GetRowCellDisplayText(I, Me.colNome) <> "" Then
                If Me.GridView1.GetRowCellDisplayText(I, Me.colNome).Contains("TOTAIS") = False Then

                    If Me.GridView1.GetRowCellDisplayText(I, Me.colJan) <> "" Then
                        dblJan += Me.GridView1.GetRowCellDisplayText(I, Me.colJan)
                    End If

                    If Me.GridView1.GetRowCellDisplayText(I, Me.colFev) <> "" Then
                        dblFev += Me.GridView1.GetRowCellDisplayText(I, Me.colFev)
                    End If

                    If Me.GridView1.GetRowCellDisplayText(I, Me.colMar) <> "" Then
                        dblMar += Me.GridView1.GetRowCellDisplayText(I, Me.colMar)
                    End If

                    If Me.GridView1.GetRowCellDisplayText(I, Me.colAbr) <> "" Then
                        dblAbr += Me.GridView1.GetRowCellDisplayText(I, Me.colAbr)
                    End If

                    If Me.GridView1.GetRowCellDisplayText(I, Me.colMai) <> "" Then
                        dblMai += Me.GridView1.GetRowCellDisplayText(I, Me.colMai)
                    End If

                    If Me.GridView1.GetRowCellDisplayText(I, Me.colJun) <> "" Then
                        dblJun += Me.GridView1.GetRowCellDisplayText(I, Me.colJun)
                    End If

                    If Me.GridView1.GetRowCellDisplayText(I, Me.colJul) <> "" Then
                        dblJul += Me.GridView1.GetRowCellDisplayText(I, Me.colJul)
                    End If

                    If Me.GridView1.GetRowCellDisplayText(I, Me.colAgo) <> "" Then
                        dblAgo += Me.GridView1.GetRowCellDisplayText(I, Me.colAgo)
                    End If

                    If Me.GridView1.GetRowCellDisplayText(I, Me.colSet) <> "" Then
                        dblSet += Me.GridView1.GetRowCellDisplayText(I, Me.colSet)
                    End If

                    If Me.GridView1.GetRowCellDisplayText(I, Me.colOut) <> "" Then
                        dblOut += Me.GridView1.GetRowCellDisplayText(I, Me.colOut)
                    End If

                    If Me.GridView1.GetRowCellDisplayText(I, Me.colNov) <> "" Then
                        dblNov += Me.GridView1.GetRowCellDisplayText(I, Me.colNov)
                    End If

                    If Me.GridView1.GetRowCellDisplayText(I, Me.colDez) <> "" Then
                        dblDez += Me.GridView1.GetRowCellDisplayText(I, Me.colDez)
                    End If
                    Dim strff As String = Me.GridView1.GetRowCellDisplayText(I, Me.colFornecedor)
                    If Me.GridView1.GetRowCellDisplayText(I, Me.colFornecedor) = "TOTAL" Then
                        If dblJan > 0 Then
                            Me.GridView1.SetRowCellValue(I, Me.colJan, dblJan)
                        End If

                        If dblFev > 0 Then
                            Me.GridView1.SetRowCellValue(I, Me.colFev, dblFev)
                        End If
                        If dblMar > 0 Then
                            Me.GridView1.SetRowCellValue(I, Me.colMar, dblMar)
                        End If
                        If dblAbr > 0 Then
                            Me.GridView1.SetRowCellValue(I, Me.colAbr, dblAbr)
                        End If
                        If dblMai > 0 Then
                            Me.GridView1.SetRowCellValue(I, Me.colMai, dblMai)
                        End If
                        If dblJun > 0 Then
                            Me.GridView1.SetRowCellValue(I, Me.colJun, dblJun)
                        End If
                        If dblJul > 0 Then
                            Me.GridView1.SetRowCellValue(I, Me.colJul, dblJul)
                        End If
                        If dblAgo > 0 Then
                            Me.GridView1.SetRowCellValue(I, Me.colAgo, dblAgo)
                        End If
                        If dblSet > 0 Then
                            Me.GridView1.SetRowCellValue(I, Me.colSet, dblSet)
                        End If
                        If dblOut > 0 Then
                            Me.GridView1.SetRowCellValue(I, Me.colOut, dblOut)
                        End If

                        If dblNov > 0 Then
                            Me.GridView1.SetRowCellValue(I, Me.colNov, dblNov)
                        End If
                        If dblDez > 0 Then
                            Me.GridView1.SetRowCellValue(I, Me.colDez, dblDez)
                        End If

                        dblJan = 0
                        dblFev = 0
                        dblMar = 0
                        dblAbr = 0
                        dblMai = 0
                        dblJun = 0
                        dblJul = 0
                        dblAgo = 0
                        dblSet = 0
                        dblOut = 0
                        dblNov = 0
                        dblDez = 0
                    End If

                End If
            End If


        Next
        I = 0
        For A = 0 To Me.GridView1.RowCount - 1
            If Me.GridView1.GetRowCellDisplayText(I, Me.colNome) <> "" Then
                If Me.GridView1.GetRowCellDisplayText(I, colJan) = "" And Me.GridView1.GetRowCellDisplayText(I, Me.colFev) = "" And Me.GridView1.GetRowCellDisplayText(I, Me.colMar) = "" _
                 And Me.GridView1.GetRowCellDisplayText(I, Me.colAbr) = "" And Me.GridView1.GetRowCellDisplayText(I, Me.colMai) = "" And Me.GridView1.GetRowCellDisplayText(I, Me.colJul) = "" _
                  And Me.GridView1.GetRowCellDisplayText(I, Me.colJul) = "" And Me.GridView1.GetRowCellDisplayText(I, Me.colAgo) = "" And Me.GridView1.GetRowCellDisplayText(I, Me.colSet) = "" _
                   And Me.GridView1.GetRowCellDisplayText(I, Me.colOut) = "" And Me.GridView1.GetRowCellDisplayText(I, Me.colNov) = "" And Me.GridView1.GetRowCellDisplayText(I, Me.colDez) = "" Then
                    Me.GridView1.DeleteRow(I)
                Else
                    I += 1
                End If
            End If

        Next
    End Sub
    Public Function UltimoDiaMes(ByVal paramDataX As Date) As Date
        UltimoDiaMes = DateAdd("m", 1, DateSerial(Year(paramDataX), Month(paramDataX), 1))
        UltimoDiaMes = DateAdd("d", -1, UltimoDiaMes)
    End Function

    Private Sub btnFiltrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFiltrar.ItemClick
        If Me.cboAno.EditValue.ToString = "" Then Exit Sub

        GerarRelatorio(Me.cboAno.EditValue)

    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relInformativo
        rel.lblTitulo.Text = Me.Text
        rel.picLogo.Image = LogoTipo

        Dim I As Integer
        Dim A As Integer = 0
        With rel.tbInf.Rows
            For I = 0 To Me.GridView1.RowCount - 1
                If Me.GridView1.GetRowCellDisplayText(I, Me.colNome) <> "" Then
                    .Add()
                    .Item(A).Item("Nome") = Me.GridView1.GetRowCellDisplayText(I, Me.colNome)
                    .Item(A).Item("Periodo") = Me.GridView1.GetRowCellDisplayText(I, Me.colPeriodo)
                    .Item(A).Item("1") = Me.GridView1.GetRowCellDisplayText(I, Me.colJan)
                    .Item(A).Item("2") = Me.GridView1.GetRowCellDisplayText(I, Me.colFev)
                    .Item(A).Item("3") = Me.GridView1.GetRowCellDisplayText(I, Me.colMar)
                    .Item(A).Item("4") = Me.GridView1.GetRowCellDisplayText(I, Me.colAbr)
                    .Item(A).Item("5") = Me.GridView1.GetRowCellDisplayText(I, Me.colMai)
                    .Item(A).Item("6") = Me.GridView1.GetRowCellDisplayText(I, Me.colJun)
                    .Item(A).Item("7") = Me.GridView1.GetRowCellDisplayText(I, Me.colJul)
                    .Item(A).Item("8") = Me.GridView1.GetRowCellDisplayText(I, Me.colAgo)
                    .Item(A).Item("9") = Me.GridView1.GetRowCellDisplayText(I, Me.colSet)
                    .Item(A).Item("10") = Me.GridView1.GetRowCellDisplayText(I, Me.colOut)
                    .Item(A).Item("11") = Me.GridView1.GetRowCellDisplayText(I, Me.colNov)
                    .Item(A).Item("12") = Me.GridView1.GetRowCellDisplayText(I, Me.colDez)
                    .Item(A).Item("Fornecedor") = Me.GridView1.GetRowCellDisplayText(I, Me.colFornecedor)
                    A += 1

                End If
            Next
        End With
        rel.ShowPreview()
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    'Private Sub GridView1_CustomDrawGroupRow(ByVal sender As Object, ByVal e As RowObjectCustomDrawEventArgs) Handles GridView1.CustomDrawGroupRow
    '    Dim view As GridView = TryCast(sender, GridView)
    '    Dim info As GridGroupRowInfo = TryCast(e.Info, GridGroupRowInfo)
    '    If info.Column.Caption = "Período" Then
    '        info.GroupText = info.Column.Caption & ": <color=Blue>" & info.GroupText & "</color> "
    '        info.GroupText &= "<color=LightSteelBlue>" & view.GetGroupSummaryText(e.RowHandle) & "</color> "
    '    End If
    'End Sub
    Private Sub GridView1_CustomDrawGroupRow(ByVal sender As Object, ByVal e As RowObjectCustomDrawEventArgs) Handles GridView1.CustomDrawGroupRow
        Dim view As GridView = CType(sender, GridView)

        Dim groupRowInfo As GridGroupRowInfo = e.Info
        Dim groupRowBounds As Rectangle = groupRowInfo.DataBounds
        Dim expandButtonBounds As Rectangle = groupRowInfo.ButtonBounds
        Dim textBounds As Rectangle = e.Bounds
        textBounds.X = expandButtonBounds.Right + 4

        'A brush for the group row.
        Dim brush As Brush = e.Cache.GetGradientBrush(groupRowBounds, Color.LemonChiffon, _
          Color.Tan, LinearGradientMode.Horizontal)
        'A brush for the region containing the expand button.
        Dim brushImage As Brush = Brushes.LemonChiffon
        'Brushes to draw the text in the group row
        Dim brushText As Brush = Brushes.Black, brushTextShadow As Brush = Brushes.Black
        'If e.RowHandle = view.FocusedRowHandle Then
        '    brush = Brushes.DarkBlue
        '    brushTextShadow = Brushes.DarkBlue
        '    brushText = Brushes.White
        'End If
        Dim intdd As Integer = e.RowHandle
        Dim strStrr As String = view.GetGroupRowDisplayText(e.RowHandle, False)
        If view.GetGroupRowDisplayText(e.RowHandle, False).Contains("Período") = True Then
            brush = Brushes.PaleGreen
            brushTextShadow = Brushes.Black
            brushText = Brushes.Black

        End If
        'Fill the rectangle of the group row without the expand button
        e.Graphics.FillRectangle(brush, groupRowBounds)
        'Draw a custom expand button

        Dim iml As ImageList = Me.ImageList1
        e.Graphics.DrawImageUnscaled(iml.Images(IIf(view.GetRowExpanded(e.RowHandle), 1, 0)), _
          expandButtonBounds)

        'Draw the group row text
        Dim s As String = view.GetGroupRowDisplayText(e.RowHandle)
        e.Appearance.DrawString(e.Cache, s, New Rectangle(textBounds.X + 1, textBounds.Y + 1, _
        textBounds.Width, textBounds.Height), brushTextShadow)

        'e.Appearance.DrawString(e.Cache, s, textBounds, brushText)
        'Prevent default painting
        e.Handled = True
    End Sub

    Private Sub GridView1_CustomDrawRowFooter(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles GridView1.CustomDrawRowFooter
        'Dim brush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, _
        '   Color.FromArgb(209, 227, 241), Color.FromArgb(68, 121, 191), 90)
        'e.Graphics.FillRectangle(brush, e.Bounds)
        'ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.RaisedInner)

        'Dim view As GridView = CType(sender, GridView)
        'Dim strStrr As String = e.RowHandle

        'view.DeleteRow(e.RowHandle)

        ''Prevent default painting
        'e.Handled = True
    End Sub
    'Private Sub advBandedGridView1_GroupLevelStyle(ByVal sender As Object, ByVal e As GroupLevelStyleEventArgs) Handles advBandedGridView1.GroupLevelStyle
    '    ' Specify the back color for the group indent panel
    '    e.LevelAppearance.BackColor = Color.LemonChiffon
    'End Sub

    Private Sub GridView1_GroupLevelStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GroupLevelStyleEventArgs) Handles GridView1.GroupLevelStyle

        If e.Level = 0 Then
            e.LevelAppearance.BackColor = Color.PaleGreen
        Else
            e.LevelAppearance.BackColor = Color.LemonChiffon
        End If


    End Sub
End Class