Imports Nano.clsFuncoes
Public Class frmRelDescarte
    Dim strFiltro As String = ""

    Private Sub frmRelDescarte_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "51")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmRelDescarte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If TesteConexao() = False Then Exit Sub

        Me.colCodConfig.Visible = Master

        If Master = False Then
            strFiltro = "where Descarte.CodConfig =" & CodConfig
        End If
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)
        CarregarDados("SELECT Descarte.Codigo as CodDesc, Descarte.Data, Produto.Codigo as CodigoProduto, " & _
        "Produto.CodigoInterno as CodProd, Produto.Nome as Produto, Descarte.Tamanho, Descarte.Qtde as Qtd, " & _
        "Descarte.ValorUnitario as Custo, Descarte.Motivo, Descarte.Data, Descarte.CodConfig, Descarte.ValorTotal, " & _
        "Descarte.CodFunc, Funcionario.Nome as Funcionario FROM (Descarte left join Produto on " & _
        "Descarte.CodProd = Produto.Codigo) left join Funcionario on Descarte.CodFunc = Funcionario.Codigo " & strFiltro, Me.GridControl1)
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

        If Master = False Then
            strFiltro = " and Descarte.CodConfig =" & CodConfig
        End If
        CarregarDados("SELECT Descarte.Codigo as CodDesc, Descarte.Data, Produto.Codigo as CodigoProduto, " & _
        "Produto.CodigoInterno as CodProd, Produto.Nome as Produto, Descarte.Tamanho, Descarte.Qtde as Qtd, " & _
        "Descarte.ValorUnitario as Custo, Descarte.Motivo, Descarte.Data, Descarte.CodConfig, Descarte.ValorTotal, " & _
        "Descarte.CodFunc, Funcionario.Nome as Funcionario FROM (Descarte left join Produto on " & _
        "Descarte.CodProd = Produto.Codigo) left join Funcionario on Descarte.CodFunc = Funcionario.Codigo where " & String.Format("Descarte.Data >= '{0:dd/MM/yyyy}' AND Descarte.Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro, Me.GridControl1)

        Calcular()
    End Sub
    Private Sub Calcular()
        Me.txtTotPro.Text = Me.grd1.RowCount
        Dim I As Integer
        Dim dblValor As Double
        For I = 0 To Me.grd1.RowCount - 1
            If Me.grd1.GetRowCellDisplayText(I, Me.colValorTotal) <> "" Then
                dblValor += Me.grd1.GetRowCellDisplayText(I, Me.colValorTotal)
            End If

        Next
        Me.txtCustoTotal.Text = dblValor.ToString("###,###,##0.00")
    End Sub
    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Calcular()
    End Sub

    Private Sub btnRelDes_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelDes.ItemClick
        Dim rel As New relDescarte
        Dim I As Integer
        rel.picLogo.Image = LogoTipo
        Dim dblCusto As Double = 0
        With rel.tbDesc.Rows
            For I = 0 To Me.grd1.RowCount - 1
                .Add()
                .Item(I).Item("CodProd") = Me.grd1.GetRowCellDisplayText(I, Me.colCodProd)
                .Item(I).Item("Produto") = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                .Item(I).Item("Tamanho") = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho)
                .Item(I).Item("Qtd") = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                .Item(I).Item("Motivo") = Me.grd1.GetRowCellDisplayText(I, Me.colMotivo)
                .Item(I).Item("Data") = Me.grd1.GetRowCellDisplayText(I, Me.colData)
                .Item(I).Item("Custo") = Me.grd1.GetRowCellDisplayText(I, Me.colCusto)
                .Item(I).Item("ValorTotal") = Me.grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                .Item(I).Item("Funcionario") = Me.grd1.GetRowCellDisplayText(I, Me.colFuncionario)
                If Me.grd1.GetRowCellDisplayText(I, Me.colCusto) <> "" Then
                    dblCusto += Me.grd1.GetRowCellDisplayText(I, Me.colCusto)
                End If
            Next
        End With
        If Me.colCusto.Visible = False Then
            rel.colCusto.Visible = False
            rel.relLabelCusto.Visible = False
            rel.relTotalCusto.Visible = False
        End If
        If Me.colFuncionario.Visible = False Then
            rel.colFuncionario.Visible = False
        End If
        rel.relTotalCusto.Text = dblCusto.ToString("###,###,##0.00")
        rel.lblTotal.Text = Me.txtTotPro.Text
        rel.lblValorTotal.Text = Me.txtCustoTotal.Text
        rel.ShowPreview()
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub

    Private Sub btnEstornar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstornar.ItemClick
        If MsgBox("Deseja realmente estornar este descarte?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
            Dim I As Integer = Me.grd1.FocusedRowHandle
            Dim intDia, intMes, intAno, intHora, intMinuto As Integer
            Dim strLote As String

            intDia = Date.Today.Day
            intMes = Month(Now)
            intAno = Year(Now)
            intHora = Hour(Now)
            intMinuto = Minute(Now)

            strLote = intDia.ToString("00") & intMes.ToString("00") & intAno & "-" & intHora.ToString("00") & intMinuto.ToString("00")

            With grd1

                Dim strQtd As String = ""
                Dim strVal As String = ""
                Dim strTam As String = ""
                Dim intCodProd As Integer
                Dim dblQtd As Double
                Dim strCodigo = .GetRowCellDisplayText(I, Me.colCodDesc)
                Dim strCodConfig As String = ""
                dblQtd = .GetRowCellDisplayText(I, Me.colQtd)
                intCodProd = .GetRowCellDisplayText(I, Me.colCodigoProduto)
                strVal = .GetRowCellDisplayText(I, Me.colCusto)
                strTam = .GetRowCellDisplayText(I, Me.colTamanho)
                strCodConfig = .GetRowCellDisplayText(I, Me.colCodConfig)

                Dim dt As DataTable = CarregarDataTable("Select UnidadeMedida, convert(numeric(15,2),ValorCusto) as ValorCusto, convert(numeric(15,2),Valor) as Valor, CodigoInterno from Produto where Codigo =" & intCodProd)

                If dt.Rows.Count > 0 Then
                    strVal = dt.Rows.Item(0).Item("ValorCusto").ToString
                End If

                If BaixaPorLote = True Then

                    Atualizar("UPDATE Qtde SET DataFim = '01/01/1900' where CodProd = " & intCodProd & " and CodConfig = " & strCodConfig)

                    Inserir("Insert Into Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, EmFalta, " & _
                    "ValorCusto, CodConfig, Acabou, DataFim) Values(" & intCodProd & ",'" & strTam & "'," & _
                    "" & 0 & "," & Num(dblQtd) & ",'" & strLote & "','" & 0 & "'," & Num(strVal) & "," & _
                    "" & strCodConfig & ",'False','01/01/1900')")
                Else
                    If EstoqueSomado = True Then
                        Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data, CodUser) VALUES (" & _
                        "" & intCodProd & "," & Num(dblQtd) & "," & strCodConfig & ",'DESCARTE EST','" & My.Computer.Clock.LocalTime & "'," & CodUser & ")")

                    End If
                End If
                Atualizar("Update Qtde set EmFalta = '0' where Qtd > QtdMinima and CodProd = " & intCodProd)
                Excluir("DELETE FROM Descarte where Codigo = " & strCodigo)


            End With

            MsgBox("Descarte estornado com sucesso!", MsgBoxStyle.Information)

            If Master = False Then
                strFiltro = "where Descarte.CodConfig =" & CodConfig
            End If

            'CarregarDados("SELECT Descarte.Codigo as CodDesc, Descarte.Data, Produto.Codigo as CodigoProduto, " & _
            '"Produto.CodigoInterno as CodProd, Produto.Nome as Produto, Descarte.Tamanho, Descarte.Qtde as Qtd, " & _
            '"Descarte.ValorUnitario as Custo, Descarte.Motivo, Descarte.Data, Descarte.CodConfig FROM Descarte left join Produto on Descarte.CodProd = Produto.Codigo " & strFiltro, Me.GridControl1)
            CarregarDados("SELECT Descarte.Codigo as CodDesc, Descarte.Data, Produto.Codigo as CodigoProduto, " & _
                 "Produto.CodigoInterno as CodProd, Produto.Nome as Produto, Descarte.Tamanho, Descarte.Qtde as Qtd, " & _
                 "Descarte.ValorUnitario as Custo, Descarte.Motivo, Descarte.Data, Descarte.CodConfig, Descarte.ValorTotal, " & _
                 "Descarte.CodFunc, Funcionario.Nome as Funcionario FROM (Descarte left join Produto on " & _
                 "Descarte.CodProd = Produto.Codigo) left join Funcionario on Descarte.CodFunc = Funcionario.Codigo " & strFiltro, Me.GridControl1)

        End If
    End Sub
    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub

End Class