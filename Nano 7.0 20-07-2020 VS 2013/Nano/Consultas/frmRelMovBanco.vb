Imports Nano.clsFuncoes
Public Class frmRelMovBanco
    Dim strFiltro As String
    Dim intCodBanco As Integer
    Dim intCodLoja As Integer

    Private Sub frmRelMovBanco_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "25")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub
    Private Sub frmRelMovBanco_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If TesteConexao() = False Then Exit Sub

        Me.lueLoja.Visible = Master
        Me.lblLoja.Visible = Master

        intCodLoja = CodConfig

        Me.dtInicial.EditValue = Date.Today.AddDays(-30)
        Me.dtFinal.EditValue = Date.Today


        Me.cboBanco.Text = "TODOS"

        ComboBanco()

        If ExcluirLancamentoBancario = False Then
            Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

        If BloqueioTransferenciaBancario = False Then
            Me.btnTranferencia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

        CarregarDadosLue("Select Codigo, Descricao from Config", Me.lueLoja)
    End Sub

    Private Sub CarregarExtrato()

        Dim strData As String = ""

        If Master = False Then
            strFiltro = " and MovimentoBancario.CodConfig =" & CodConfig
        Else
            If Me.lueLoja.Text.Trim <> "" Then
                strFiltro = " and MovimentoBancario.CodConfig =" & intCodLoja
            End If

        End If

        strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue)

        If intCodBanco <> 0 Then
            strFiltro &= " and CodBanco =" & intCodBanco
        End If

        Dim dtCredito, dtDebito As DataTable
        Dim dblCredito, dblDebito, dblResultado As Double
        Dim strSQL, strDataAnterior As String

        Dim dtDataSaldo As Date = Me.dtInicial.EditValue


        dtDataSaldo = dtDataSaldo.AddDays(-1)

        strDataAnterior = String.Format("Data <= '{0:dd/MM/yyyy}'", dtDataSaldo)

        'If Me.cboBanco.Text = "RECEITAS" Then
        '    strSQL = "SELECT sum(Valor) as Valor FROM MovimentoBancario where TipoMovimento = 'RECEITAS' and " & strDataAnterior & strFiltro
        'ElseIf Me.cboBanco.Text = "DESPESAS" Then
        '    strSQL = "SELECT sum(Valor) as Valor FROM MovimentoBancario where TipoMovimento = 'DESPESAS' and " & strDataAnterior & strFiltro
        'Else
        strSQL = "SELECT sum(Convert(Numeric(15,2), Valor)) as Valor FROM MovimentoBancario where TipoMovimento <> 'DÉBITO' and TipoMovimento <> 'DESPESAS' and " & strDataAnterior & strFiltro
        'End If


        dtCredito = CarregarDataTable(strSQL)
        If dtCredito.Rows.Item(0).ItemArray(0).ToString = "" Then
            dblCredito = "0,00"
        Else
            dblCredito = dtCredito.Rows.Item(0).Item("Valor").ToString
        End If

        'If Me.cboBanco.Text = "RECEITAS" Then
        '    strSQL = "SELECT sum(Valor) as Valor FROM MovimentoBancario where TipoMovimento = 'DESPESAS' and " & strDataAnterior & strFiltro
        'ElseIf Me.cboBanco.Text = "DESPESAS" Then
        '    strSQL = "SELECT sum(Valor) as Valor FROM MovimentoBancario where TipoMovimento = 'RECEITAS' and " & strDataAnterior & strFiltro
        'Else
        strSQL = "SELECT sum(Convert(Numeric(15,2), Valor)) as Valor FROM MovimentoBancario where TipoMovimento <> 'CRÉDITO' and TipoMovimento <> 'RECEITAS' and " & strDataAnterior & strFiltro
        'End If

        dtDebito = CarregarDataTable(strSQL)

        If dtDebito.Rows.Item(0).Item("Valor").ToString = "" Then
            dblDebito = "0,00"
        Else
            dblDebito = dtDebito.Rows.Item(0).Item("Valor").ToString
        End If

        dblResultado = dblCredito.ToString("0.00") - dblDebito.ToString("0.00")


        Dim dt As DataTable = CarregarDataTable("SELECT MovimentoBancario.Codigo, CodBanco, TipoMovimento, Convert(Numeric(15,2), Valor) as Valor, Data, Observacao,  Banco.Nome as Banco, MovimentoBancario.CodConfig as CodConfig FROM MovimentoBancario inner join Banco on MovimentoBancario.CodBanco = Banco.Codigo where " & strData & strFiltro & " order by MovimentoBancario.Data")


        strFiltro = ""

        Me.tbBanco.Rows.Clear()

        Dim I As Integer



        Dim strDataMov As String = ""

        strDataMov = dtDataSaldo
        Me.tbBanco.Rows.Add()
        Me.tbBanco.Rows.Item(0).Item("Data") = strDataMov
        Me.tbBanco.Rows.Item(0).Item("Banco") = Me.cboBanco.Text.Trim
        Me.tbBanco.Rows.Item(0).Item("Historico") = "SALDO ANTERIOR EM " & strDataMov
        Me.tbBanco.Rows.Item(0).Item("Movimento") = "S"
        Me.tbBanco.Rows.Item(0).Item("Valor") = dblResultado.ToString("###,###,###,##0.00")


        'Me.mExt.Text += Esq("SALDO EM " & dtDataSaldo.AddDays(-1) & " R$ " & dblResultado.ToString("###,###,###,##0.00"), 100) & vbCrLf


        Dim dtData1, dtData2 As Date
        Dim strValor, strTipoMov As String


        For I = 0 To dt.Rows.Count - 1


            If dt.Rows.Item(I).Item("TipoMovimento") = "CRÉDITO" Or dt.Rows.Item(I).Item("TipoMovimento") = "RECEITAS" Then
                strValor = dt.Rows.Item(I).Item("Valor").ToString
                strTipoMov = "C"
            Else
                strTipoMov = "D"
                If dt.Rows.Item(I).Item("Valor").ToString <> "0,00" Then
                    strValor = "-" & dt.Rows.Item(I).Item("Valor").ToString
                Else
                    strValor = dt.Rows.Item(I).Item("Valor").ToString
                End If
            End If



            dtData1 = dt.Rows.Item(I).Item("Data")

            strDataMov = dtData1

            dblResultado += CDbl(strValor).ToString("###,###,###,##0.00")

            strValor = CDbl(strValor).ToString("###,###,###,##0.00")


            'strString += Dir(dt.Rows.Item(I).Item("Observacao").ToString, 85) & Esq(strValor, 15) & vbCrLf
            Me.tbBanco.Rows.Add()
            Me.tbBanco.Rows.Item(Me.tbBanco.Rows.Count - 1).Item("Codigo") = dt.Rows.Item(I).Item("Codigo").ToString
            Me.tbBanco.Rows.Item(Me.tbBanco.Rows.Count - 1).Item("Data") = strDataMov
            Me.tbBanco.Rows.Item(Me.tbBanco.Rows.Count - 1).Item("CodBanco") = dt.Rows.Item(I).Item("CodBanco").ToString
            Me.tbBanco.Rows.Item(Me.tbBanco.Rows.Count - 1).Item("Banco") = dt.Rows.Item(I).Item("Banco").ToString
            Me.tbBanco.Rows.Item(Me.tbBanco.Rows.Count - 1).Item("Historico") = dt.Rows.Item(I).Item("Observacao").ToString
            Me.tbBanco.Rows.Item(Me.tbBanco.Rows.Count - 1).Item("Movimento") = strTipoMov
            Me.tbBanco.Rows.Item(Me.tbBanco.Rows.Count - 1).Item("Valor") = strValor

            Try

                If dt.Rows.Count - 1 <= I Then
                    strDataMov = dtData1
                    Me.tbBanco.Rows.Add()
                    Me.tbBanco.Rows.Item(Me.tbBanco.Rows.Count - 1).Item("Data") = strDataMov
                    Me.tbBanco.Rows.Item(Me.tbBanco.Rows.Count - 1).Item("Banco") = Me.cboBanco.Text.Trim
                    Me.tbBanco.Rows.Item(Me.tbBanco.Rows.Count - 1).Item("Historico") = "SALDO TOTAL EM " & strDataMov
                    Me.tbBanco.Rows.Item(Me.tbBanco.Rows.Count - 1).Item("Movimento") = "S"
                    Me.tbBanco.Rows.Item(Me.tbBanco.Rows.Count - 1).Item("Valor") = dblResultado.ToString("###,###,###,##0.00")
                Else
                    dtData2 = dt.Rows.Item(I + 1).Item("Data")

                    If dtData1 <> dtData2 Then

                        strDataMov = dtData1

                        Me.tbBanco.Rows.Add()
                        Me.tbBanco.Rows.Item(Me.tbBanco.Rows.Count - 1).Item("Data") = strDataMov
                        Me.tbBanco.Rows.Item(Me.tbBanco.Rows.Count - 1).Item("Banco") = Me.cboBanco.Text.Trim
                        Me.tbBanco.Rows.Item(Me.tbBanco.Rows.Count - 1).Item("Historico") = "SALDO EM " & strDataMov
                        Me.tbBanco.Rows.Item(Me.tbBanco.Rows.Count - 1).Item("Movimento") = "S"
                        Me.tbBanco.Rows.Item(Me.tbBanco.Rows.Count - 1).Item("Valor") = dblResultado.ToString("###,###,###,##0.00")
                    End If
                End If

            Catch ex As Exception

            End Try

        Next

    End Sub

    Private Sub ComboBanco()
        Me.cboBanco.Properties.Items.Clear()
        Me.cboBanco.Properties.Items.Add("TODOS")
        'PreencherCombo("Banco", Me.cboBanco, 1, "Nome")
        Dim dtBanco As DataTable = CarregarDataTable("Select Nome From Banco Order by Nome")
        If dtBanco.Rows.Count > 0 Then
            For I As Integer = 0 To dtBanco.Rows.Count - 1
                Dim Nome As String = dtBanco.Rows.Item(I).Item("Nome").ToString.Trim
                Me.cboBanco.Properties.Items.Add(Nome)
            Next
        End If

        'Me.cboBanco.Properties.Items.Add("RECEITAS")
        'Me.cboBanco.Properties.Items.Add("DESPESAS")
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

        CarregarExtrato()

    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        Dim index As Integer = Me.grd1.FocusedRowHandle
        Dim intCodigo, intCodBanco As Integer
        Dim strMovimento As String
        Dim dblValor, dblSaldo, dblResul As Double

        If Me.grd1.GetRowCellValue(index, Me.colCodigo).ToString = "" Then
            MsgBox("Não é possivel excluir saldo!", MsgBoxStyle.Information)
            Exit Sub
        End If

        If MsgBox("Deseja realmente excluir esta movimentação?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            intCodigo = Me.grd1.GetRowCellValue(index, Me.colCodigo)
            intCodBanco = Me.grd1.GetRowCellValue(index, Me.colCodBanco)
            strMovimento = Me.grd1.GetRowCellDisplayText(index, Me.colTipoMovimento)
            dblValor = Me.grd1.GetRowCellDisplayText(index, Me.colValor)
            Dim strMotivo As String = Me.grd1.GetRowCellDisplayText(index, Me.colObs)

            Dim dt As DataTable
            dt = CarregarDataTable("SELECT Saldo FROM Banco where Codigo = " & intCodBanco)
            If dt.Rows.Count > 0 Then
                If dt.Rows.Item(0).Item("Saldo").ToString <> "" Then
                    dblSaldo = dt.Rows.Item(0).Item("Saldo").ToString
                End If

                If strMovimento = "CRÉDITO" Then
                    dblResul = dblSaldo - dblValor
                Else
                    dblResul = dblSaldo + dblValor
                End If
                Atualizar("UPDATE Banco SET Saldo = " & Num(dblResul) & " where Codigo = " & intCodBanco)

                Excluir("DELETE FROM MovimentoBancario where Codigo = " & intCodigo & " and CodConfig = " & CodConfig)
                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) " & _
                "VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strMotivo & ", " & strMovimento & ", R$ " & dblValor & "'," & _
                "'EXCLUIDO','MOVIMENTO BANCÁRIO','MOVIMENTO BANCÁRIO','EXCLUSÃO'," & CodConfig & ")")

                MsgBox("Movimentação excluída com sucesso!", MsgBoxStyle.Information)
                CarregarExtrato()
            Else
                MsgBox("Não foi possível excluir esta movimentação!", MsgBoxStyle.Information)

            End If
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim index As Integer = -999997
        grd1.FocusedRowHandle = index
        grd1.FocusedColumn = Me.colBanco
        grd1.ShowEditor()
        Me.Timer1.Stop()
    End Sub

    Private Sub btnRelMov_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelMov.ItemClick
        Dim rel As New relMovBanco
        rel.picLogo.Image = LogoTipo
        rel.lblInfo.Text = "De " & Me.dtInicial.EditValue & " até " & Me.dtFinal.EditValue & " Banco: " & Me.cboBanco.Text.Trim
        Dim I As Integer
        With rel.tbBanco.Rows

            For I = 0 To Me.grd1.RowCount - 1
                .Add()
                .Item(I).Item("Banco") = Me.grd1.GetRowCellDisplayText(I, Me.colBanco)
                .Item(I).Item("Tipo") = Me.grd1.GetRowCellDisplayText(I, Me.colTipoMovimento)
                .Item(I).Item("Valor") = Me.grd1.GetRowCellDisplayText(I, Me.colValor)
                .Item(I).Item("Data") = Me.grd1.GetRowCellDisplayText(I, Me.colData)
                .Item(I).Item("Obs") = Me.grd1.GetRowCellDisplayText(I, Me.colObs)
            Next

        End With

        rel.ShowPreview()
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub

    Private Sub cboBanco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBanco.SelectedIndexChanged
        If Me.cboBanco.Text.Trim = "TODOS" Then intCodBanco = 0

        Dim dt As DataTable = CarregarDataTable("Select Codigo from Banco where Nome ='" & Me.cboBanco.Text.Trim & "'")

        If dt.Rows.Count > 0 Then
            intCodBanco = dt.Rows.Item(0).Item("Codigo")
        End If

        CarregarExtrato()
    End Sub

    Private Sub lueLoja_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueLoja.EditValueChanged
        If Me.lueLoja.Text.Trim <> "" Then
            intCodLoja = Me.lueLoja.GetColumnValue("Codigo")
        End If

        CarregarExtrato()

    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Calcular()
    End Sub

    Private Sub Calcular()
        Me.txtTotGer.ResetText()
        Dim I As Integer
        With grd1
            Dim dblResTot As Double
            For I = 0 To .RowCount - 1
                Dim dblTot As Double
                If .GetRowCellDisplayText(I, Me.colValor) <> "" Then
                    If .GetRowCellDisplayText(I, Me.colObs).Contains("SALDO EM") = False Then
                        If .GetRowCellDisplayText(I, Me.colObs).Contains("SALDO TOTAL") = False Then
                            dblTot = .GetRowCellDisplayText(I, Me.colValor)
                            dblResTot += dblTot
                        End If
                    End If
                End If
            Next
            Me.txtTotGer.Text = dblResTot.ToString("###,###,##0.00")
        End With
    End Sub

    Private Sub btnTranferencia_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTranferencia.ItemClick
        If Me.cboBanco.Text = "TODOS" Or Me.cboBanco.Text = "" Then MsgBox("Selecione um banco para a tranferência!", MsgBoxStyle.Information) : Exit Sub

        frmMovBancario.strNomeBanco = Me.cboBanco.Text
        frmMovBancario.intCodigoBanco = intCodBanco
        frmMovBancario.Tag = "BANCO"
        frmMovBancario.ShowDialog()

        CarregarExtrato()

    End Sub
End Class