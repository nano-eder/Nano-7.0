Imports Nano.clsFuncoes
Imports Nano.clsDarBaixa
Public Class frmTransferencia
    Dim strStatus As String
    Dim intCodOrdem As Integer
    Dim bolAlterar As Boolean = False
    Dim IndexGrid As Integer
    Dim strItensDeletado As String

    Dim bolJaPassou As Boolean = False
    Dim strCodOrdem As String

    Private Sub frmTransferencia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "11")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmTransferencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub
        'Me.ConfigTableAdapter.Fill(Me.DsNanoCommerce.Config)
        CarregarDadosLue("Select Codigo, Descricao from Config", Me.lueLoja)
        If Me.Tag = "ALTERA" Then

            Me.txtCodPed.Focus()
        ElseIf Me.Tag = "CONSULTA" Then
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnEnviar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.txtCodProd.Enabled = False
            Me.txtProd.Enabled = False
            Me.txtQtde.Enabled = False
            Me.txtValor.Enabled = False
            Me.lueLoja.Enabled = False
            Me.btnAdicionar.Enabled = False

            Me.dtData.Enabled = False
            Me.txtCodPed.Focus()
            'ElseIf Me.Tag = "ENVIA" Then
            '    Me.txtCodProd.Enabled = False
            '    Me.txtProd.Enabled = False
            '    Me.txtQtde.Enabled = False
            '    Me.txtValor.Enabled = False
            '    Me.lueLoja.Enabled = False
            '    Me.btnAdicionar.Enabled = False

            '    Me.dtData.Enabled = False
            '    Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '    Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            '    Me.txtCodPed.Focus()
        Else
            Me.txtCodPed.Visible = False
            Me.btnConsulta.Visible = False
            Me.lblCodPed.Visible = False
            Me.dtData.Text = Date.Today
            Me.txtCodProd.Focus()
        End If


    End Sub

    Private Sub txtCodProd_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodProd.ButtonClick
        Dim frm As New frmCadProduto
        frm.Tag = "VENDA"
        CodigoDoProduto = -1
        frm.ShowDialog()
        If CodigoDoProduto = -1 Then Exit Sub
        InserirProduto(True)
    End Sub

    Private Sub txtCodProd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodProd.KeyDown
        If e.KeyCode = Keys.F10 Then
            Dim frm As New frmCadProduto
            frm.Tag = "VENDA"
            CodigoDoProduto = -1
            frm.ShowDialog()
            If CodigoDoProduto = -1 Then Exit Sub
            InserirProduto(True)
        End If
    End Sub

    Private Sub txtCodProd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodProd.Leave
        If Me.txtCodProd.Text = "" Then Exit Sub
        InserirProduto(False)
    End Sub
    Private Sub InserirProduto(ByVal parPesquisaPorNome As Boolean, Optional ByVal parTamanho As String = "")

        If bolJaPassou = True Then
            bolJaPassou = False
            Exit Sub

        End If
        Dim strTamanhoCod As String = ""
        Dim strCodProTam As String = ""

        Dim dtProd As DataTable

        If parPesquisaPorNome = False Then
            If Me.txtCodProd.Text.Trim = "" Then Exit Sub

            dtProd = CarregarDataTable("Select Codigo, Nome, UnidadeMedida, ValorCusto, Valor, Desconto, Inativo from Produto where CodigoInterno ='" & Me.txtCodProd.Text.Trim & "' or CodigoBarra ='" & Me.txtCodProd.Text.Trim & "'")
            If dtProd.Rows.Count = 0 Then
                Dim dtCodBarra As DataTable = CarregarDataTable("SELECT CodProd FROM CodigoBarra where CodigoBarra = '" & Me.txtCodProd.Text & "' and Produto = '' or CodigoBarra = '" & Me.txtCodProd.Text & "' and Produto is null")
                If dtCodBarra.Rows.Count > 0 Then
                    CodigoDoProduto = dtCodBarra.Rows.Item(0).Item("CodProd").ToString
                    dtProd = CarregarDataTable("Select Codigo, Nome, UnidadeMedida, ValorCusto, Valor, Desconto, Inativo from Produto where Codigo=" & CodigoDoProduto)
                End If
            End If
            If dtProd.Rows.Count > 0 Then
                If dtProd.Rows.Item(0).Item("Inativo") = True Then
                    MsgBox("Produto Inativo!", MsgBoxStyle.Information)
                    Me.txtCodProd.ResetText()
                    Exit Sub
                End If
            End If
        Else
            dtProd = CarregarDataTable("Select Codigo, Nome, UnidadeMedida, ValorCusto, Valor, CodigoInterno, Desconto, Inativo from Produto where Codigo=" & CodigoDoProduto)
            If dtProd.Rows.Count > 0 Then
                If dtProd.Rows.Item(0).Item("Inativo") = True Then
                    MsgBox("Produto Inativo!", MsgBoxStyle.Information)
                    Me.txtCodProd.ResetText()
                    Exit Sub
                End If

                Me.txtCodProd.Text = dtProd.Rows.Item(0).Item("CodigoInterno")
            End If
        End If

        If dtProd.Rows.Count > 0 Then

            With dtProd.Rows.Item(0)
                Dim intCodProdAut As Integer

                intCodProdAut = .Item(0).ToString

                If strTamanhoCod = "" Then
                    TamanhoDoProduto = "U"
                End If

                Dim strSql As String = "Select Tamanho, sum(Qtd) as Qtd from Qtde where CodProd =" & intCodProdAut & " and Acabou = 'False' and CodConfig =" & CodConfig & " group by Tamanho"

                Dim dtQtd As DataTable = CarregarDataTable(strSql)

                If PermiteEstoqueZerado = False Then
                    If dtQtd.Rows.Count = 0 Then
                        MsgBox("Não existem quantidades desse produto em estoque!", MsgBoxStyle.Information)
                        Me.txtCodProd.ResetText()
                        Exit Sub
                    End If

                End If

                If strTamanhoCod = "" Then
                    If dtQtd.Rows.Count > 1 Then
                        Dim frm As New frmTamanhoProd
                        frm.Tag = strSql
                        frm.ShowDialog()
                    Else
                        If dtQtd.Rows.Count > 0 Then
                            TamanhoDoProduto = dtQtd.Rows.Item(0).Item("Tamanho")
                        End If
                    End If
                Else
                    TamanhoDoProduto = strTamanhoCod
                End If
                If Me.chkAutoAdd.Checked = True Then
                    If Me.txtQtde.Text = "" Then
                        Me.txtQtde.Text = "1"
                    End If
                End If
                Me.txtCodProd.Tag = intCodProdAut
                Me.txtProd.Text = .Item(1).ToString
                Dim dblValProd As Double = .Item(3)
                Me.txtValor.Text = dblValProd.ToString("0.000")
                bolJaPassou = True
                Me.txtQtde.Focus()
            End With
        Else
            bolJaPassou = False
            Me.txtProd.Text = "INEXISTENTE"
            Me.txtCodProd.ResetText()
            Me.txtQtde.ResetText()
            Me.txtValor.ResetText()
            Me.txtCodProd.Focus()
            Exit Sub
        End If

        If parPesquisaPorNome = False Then
            If Me.chkAutoAdd.Checked = True Then
                Me.txtQtde.Focus()
                Adicinar()
            End If
        End If
    End Sub
    Private Sub Adicinar()
        If Validar(Me.txtCodProd) = False Then Exit Sub
        If Validar(Me.txtProd) = False Then Exit Sub
        If Validar(Me.txtQtde) = False Then Exit Sub
        'If Validar(Me.txtValor) = False Then Exit Sub
        If Validar(Me.lueLoja) = False Then Exit Sub
        Dim dblQtd As Double = Me.txtQtde.Text
        Dim dblCusto As Double = Me.txtValor.Text
        Dim dblCustoTotal As Double = dblQtd * dblCusto
        Dim dblQtdTotal As Double = Me.txtQtde.Text
        Dim I As Integer
        Me.grd1.ClearColumnsFilter()

        Dim dt As DataTable = CarregarDataTable("SELECT Qtd, Lote FROM Qtde where CodProd = " & Me.txtCodProd.Tag & " and CodConfig = " & CodConfig & " and Tamanho = '" & TamanhoDoProduto & "' and Acabou = 'False' order by Codigo")

        With Me.tbItens.Rows

            If bolAlterar = False Then
                If EstoqueSomado = False Then
                    For I = 0 To dt.Rows.Count - 1
                        Dim dblQtdProd As Double = dt.Rows.Item(I).Item("Qtd").ToString
                        If dblQtdProd > 0 Then
                            If dblQtd <= dblQtdProd Then
                                .Add()
                                .Item(.Count - 1).Item("CodProd") = Me.txtCodProd.Tag
                                .Item(.Count - 1).Item("CodigoInterno") = Me.txtCodProd.Text
                                .Item(.Count - 1).Item("Produto") = Me.txtProd.Text.Trim
                                .Item(.Count - 1).Item("Qtd") = dblQtd.ToString("0.00")
                                .Item(.Count - 1).Item("ValorCusto") = dblCusto.ToString("0.000")
                                .Item(.Count - 1).Item("CustoTotal") = dblCustoTotal.ToString("0.00")
                                .Item(.Count - 1).Item("Tamanho") = TamanhoDoProduto
                                .Item(.Count - 1).Item("Loja") = Me.lueLoja.Text
                                .Item(.Count - 1).Item("CodLoja") = Me.lueLoja.EditValue
                                .Item(.Count - 1).Item("Lote") = dt.Rows.Item(I).Item("Lote").ToString
                                Exit For
                            Else
                                dblQtd = dblQtdProd
                                dblCustoTotal = dblQtd * dblCusto
                                .Add()
                                .Item(.Count - 1).Item("CodProd") = Me.txtCodProd.Tag
                                .Item(.Count - 1).Item("CodigoInterno") = Me.txtCodProd.Text
                                .Item(.Count - 1).Item("Produto") = Me.txtProd.Text.Trim
                                .Item(.Count - 1).Item("Qtd") = dblQtd.ToString("0.00")
                                .Item(.Count - 1).Item("ValorCusto") = dblCusto.ToString("0.000")
                                .Item(.Count - 1).Item("CustoTotal") = dblCustoTotal.ToString("0.00")
                                .Item(.Count - 1).Item("Tamanho") = TamanhoDoProduto
                                .Item(.Count - 1).Item("Loja") = Me.lueLoja.Text
                                .Item(.Count - 1).Item("CodLoja") = Me.lueLoja.EditValue
                                .Item(.Count - 1).Item("Lote") = dt.Rows.Item(I).Item("Lote").ToString
                                dblQtd = dblQtdTotal - dblQtdProd
                                dblQtdTotal = dblQtd
                            End If
                        Else
                            MsgBox("Produto sem quantidade no estoque!", MsgBoxStyle.Information)
                        End If


                    Next
                Else
                    Dim dblResul As Double = AjusteQtde(CodConfig, Me.txtCodProd.Tag)

                    If dblResul > 0 Then
                        If dblQtd <= dblResul Then

                            If JaInserido(Me.txtCodProd.Tag, TamanhoDoProduto, dblQtd, Me.lueLoja.EditValue) = True Then
                                bolJaPassou = False
                                bolAlterar = False
                                Me.txtProd.ResetText()
                                Me.txtValor.ResetText()
                                If Me.chkAutoAdd.Checked = False Then
                                    Me.lueLoja.EditValue = DBNull.Value
                                    'Me.ConfigTableAdapter.Fill(Me.DsNanoCommerce.Config)
                                    CarregarDadosLue("Select Codigo, Descricao from Config", Me.lueLoja)
                                End If
                              
                                Me.txtCodProd.Tag = ""
                                Me.txtCodProd.ResetText()
                                Me.txtQtde.ResetText()
                                Me.txtCodProd.Focus()
                                Calcular()
                                Exit Sub
                            End If

                            .Add()
                            .Item(.Count - 1).Item("CodProd") = Me.txtCodProd.Tag
                            .Item(.Count - 1).Item("CodigoInterno") = Me.txtCodProd.Text
                            .Item(.Count - 1).Item("Produto") = Me.txtProd.Text.Trim
                            .Item(.Count - 1).Item("Qtd") = dblQtd.ToString("0.00")
                            .Item(.Count - 1).Item("ValorCusto") = dblCusto.ToString("0.000")
                            .Item(.Count - 1).Item("CustoTotal") = dblCustoTotal.ToString("0.00")
                            .Item(.Count - 1).Item("Tamanho") = TamanhoDoProduto
                            .Item(.Count - 1).Item("Loja") = Me.lueLoja.Text
                            .Item(.Count - 1).Item("CodLoja") = Me.lueLoja.EditValue
                            .Item(.Count - 1).Item("Lote") = dt.Rows.Item(I).Item("Lote").ToString
                        Else
                            dblQtd = dblResul
                            dblCustoTotal = dblQtd * dblCusto

                            If JaInserido(Me.txtCodProd.Tag, TamanhoDoProduto, dblQtd, Me.lueLoja.EditValue) = True Then
                                bolJaPassou = False
                                bolAlterar = False
                                Me.txtProd.ResetText()
                                Me.txtValor.ResetText()
                                If Me.chkAutoAdd.Checked = False Then
                                    Me.lueLoja.EditValue = DBNull.Value
                                    'Me.ConfigTableAdapter.Fill(Me.DsNanoCommerce.Config)
                                    CarregarDadosLue("Select Codigo, Descricao from Config", Me.lueLoja)
                                End If
                              
                                Me.txtCodProd.Tag = ""
                                Me.txtCodProd.ResetText()
                                Me.txtQtde.ResetText()
                                Me.txtCodProd.Focus()
                                Calcular()
                                Exit Sub
                            End If

                            .Add()
                            .Item(.Count - 1).Item("CodProd") = Me.txtCodProd.Tag
                            .Item(.Count - 1).Item("CodigoInterno") = Me.txtCodProd.Text
                            .Item(.Count - 1).Item("Produto") = Me.txtProd.Text.Trim
                            .Item(.Count - 1).Item("Qtd") = dblQtd.ToString("0.00")
                            .Item(.Count - 1).Item("ValorCusto") = dblCusto.ToString("0.000")
                            .Item(.Count - 1).Item("CustoTotal") = dblCustoTotal.ToString("0.00")
                            .Item(.Count - 1).Item("Tamanho") = TamanhoDoProduto
                            .Item(.Count - 1).Item("Loja") = Me.lueLoja.Text
                            .Item(.Count - 1).Item("CodLoja") = Me.lueLoja.EditValue
                            .Item(.Count - 1).Item("Lote") = dt.Rows.Item(I).Item("Lote").ToString
                            dblQtd = dblQtdTotal - dblResul
                            dblQtdTotal = dblQtd
                        End If
                    Else
                        MsgBox("Produto sem quantidade no estoque!", MsgBoxStyle.Information)
                    End If
                End If


            Else

                If EstoqueSomado = False Then
                    For I = 0 To dt.Rows.Count - 1
                        Dim dblQtdProd As Double = dt.Rows.Item(I).Item("Qtd").ToString
                        If dblQtdProd > 0 Then
                            If dblQtd <= dblQtdProd Then
                                grd1.SetRowCellValue(IndexGrid, Me.colProduto, Me.txtProd.Text.Trim.Replace("'", "").Replace("&", ""))
                                grd1.SetRowCellValue(IndexGrid, Me.colCodProd, Me.txtCodProd.Tag.ToString)
                                grd1.SetRowCellValue(IndexGrid, Me.colCodigoInterno, Me.txtCodProd.Text.Trim)
                                grd1.SetRowCellValue(IndexGrid, Me.colQtd, Me.txtQtde.Text.Trim)
                                grd1.SetRowCellValue(IndexGrid, Me.colValorCusto, dblCusto.ToString("0.000"))
                                grd1.SetRowCellValue(IndexGrid, Me.colLoja, Me.lueLoja.Text)
                                grd1.SetRowCellValue(IndexGrid, Me.colCodLoja, Me.lueLoja.EditValue)
                                grd1.SetRowCellValue(IndexGrid, Me.colCustoTotal, dblCustoTotal.ToString("0.00"))
                                grd1.SetRowCellValue(IndexGrid, Me.colTamanho, TamanhoDoProduto)
                                grd1.SetRowCellValue(IndexGrid, Me.colLote, dt.Rows.Item(I).Item("Lote").ToString)
                                Exit For
                            Else
                                dblQtd = dblQtdProd
                                dblCustoTotal = dblQtd * dblCusto
                                .Add()
                                .Item(.Count - 1).Item("CodProd") = Me.txtCodProd.Tag
                                .Item(.Count - 1).Item("CodigoInterno") = Me.txtCodProd.Text
                                .Item(.Count - 1).Item("Produto") = Me.txtProd.Text.Trim
                                .Item(.Count - 1).Item("Qtd") = dblQtd.ToString("0.00")
                                .Item(.Count - 1).Item("ValorCusto") = dblCusto.ToString("0.000")
                                .Item(.Count - 1).Item("CustoTotal") = dblCustoTotal.ToString("0.00")
                                .Item(.Count - 1).Item("Tamanho") = TamanhoDoProduto
                                .Item(.Count - 1).Item("Loja") = Me.lueLoja.Text
                                .Item(.Count - 1).Item("CodLoja") = Me.lueLoja.EditValue
                                .Item(.Count - 1).Item("Lote") = dt.Rows.Item(I).Item("Lote").ToString
                                dblQtd = dblQtdTotal - dblQtdProd
                                dblQtdTotal = dblQtd
                            End If
                        End If


                    Next
                Else
                    Dim dblResul As Double = AjusteQtde(CodConfig, Me.txtCodProd.Tag)
                    If dblResul > 0 Then
                        If dblQtd <= dblResul Then
                            grd1.SetRowCellValue(IndexGrid, Me.colProduto, Me.txtProd.Text.Trim.Replace("'", "").Replace("&", ""))
                            grd1.SetRowCellValue(IndexGrid, Me.colCodProd, Me.txtCodProd.Tag.ToString)
                            grd1.SetRowCellValue(IndexGrid, Me.colCodigoInterno, Me.txtCodProd.Text.Trim)
                            grd1.SetRowCellValue(IndexGrid, Me.colQtd, Me.txtQtde.Text.Trim)
                            grd1.SetRowCellValue(IndexGrid, Me.colValorCusto, dblCusto.ToString("0.000"))
                            grd1.SetRowCellValue(IndexGrid, Me.colLoja, Me.lueLoja.Text)
                            grd1.SetRowCellValue(IndexGrid, Me.colCodLoja, Me.lueLoja.EditValue)
                            grd1.SetRowCellValue(IndexGrid, Me.colCustoTotal, dblCustoTotal.ToString("0.00"))
                            grd1.SetRowCellValue(IndexGrid, Me.colTamanho, TamanhoDoProduto)
                            grd1.SetRowCellValue(IndexGrid, Me.colLote, dt.Rows.Item(I).Item("Lote").ToString)

                        Else
                            dblQtd = dblResul
                            dblCustoTotal = dblQtd * dblCusto
                            .Add()
                            .Item(.Count - 1).Item("CodProd") = Me.txtCodProd.Tag
                            .Item(.Count - 1).Item("CodigoInterno") = Me.txtCodProd.Text
                            .Item(.Count - 1).Item("Produto") = Me.txtProd.Text.Trim
                            .Item(.Count - 1).Item("Qtd") = dblQtd.ToString("0.00")
                            .Item(.Count - 1).Item("ValorCusto") = dblCusto.ToString("0.000")
                            .Item(.Count - 1).Item("CustoTotal") = dblCustoTotal.ToString("0.00")
                            .Item(.Count - 1).Item("Tamanho") = TamanhoDoProduto
                            .Item(.Count - 1).Item("Loja") = Me.lueLoja.Text
                            .Item(.Count - 1).Item("CodLoja") = Me.lueLoja.EditValue
                            .Item(.Count - 1).Item("Lote") = dt.Rows.Item(I).Item("Lote").ToString
                            dblQtd = dblQtdTotal - dblResul
                            dblQtdTotal = dblQtd
                        End If
                    End If
                End If



            End If
        End With
        bolJaPassou = False
        bolAlterar = False
        Me.txtProd.ResetText()
        Me.txtValor.ResetText()
        If Me.chkAutoAdd.Checked = False Then
            Me.lueLoja.EditValue = DBNull.Value
            CarregarDadosLue("Select Codigo, Descricao from Config", Me.lueLoja)
        End If

        'Me.ConfigTableAdapter.Fill(Me.DsNanoCommerce.Config)

        Me.txtCodProd.Tag = ""
        Me.txtCodProd.ResetText()
        Me.txtQtde.ResetText()
        Me.txtCodProd.Focus()
        Calcular()

    End Sub
    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click
        Adicinar()
    End Sub
    Private Sub Calcular()
        Dim I As Integer
        Dim dblCusto As Double
        For I = 0 To Me.grd1.RowCount - 1
            dblCusto += Me.grd1.GetRowCellDisplayText(I, Me.colCustoTotal)
        Next
    End Sub
    Private Sub Salvar(ByVal parEnviar As Boolean)
        Dim I As Integer
        If Me.Tag = "CADASTRA" Or Me.Tag = "ENVIA" Then

            intCodOrdem = GerarCodigo("OrdemTrans", "Codigo", CodConfig)
            strCodOrdem = intCodOrdem
            Inserir("INSERT INTO OrdemTrans (Codigo, CodConfig) VALUES (" & intCodOrdem & "," & CodConfig & ")")
            Me.txtCodPed.Text = intCodOrdem
            For I = 0 To Me.grd1.RowCount - 1
                Dim strCodProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodProd)
                Dim strTamanho As String = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho)
                Dim strQtd As String = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                Dim strloja As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodLoja)
                Dim strValorCusto As String = Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto)
                Dim strLote As String = Me.grd1.GetRowCellDisplayText(I, Me.colLote)
                Inserir("INSERT INTO Transferencia (CodOrdem, CodProd, Tamanho, Qtd, ValorCusto, CodLoja, CodConfig, CodUserSaida, Data, Status, EntSai, Lote) VALUES (" & intCodOrdem & "," & strCodProd & ",'" & strTamanho & "'," & Num(strQtd) & "," & Num(strValorCusto) & "," & strloja & "," & CodConfig & "," & CodUser & ",'" & Me.dtData.Text & "','Pendente','S','" & strLote & "')")
            Next

        Else
            Dim vetDelete As Array = Split(strItensDeletado, "|")

            For I = 0 To vetDelete.Length - 1
                If vetDelete(I) = "" Then Exit For
                Dim strDelete As String
                strDelete = "Delete From Transferencia where Codigo =" & vetDelete(I)
                Excluir(strDelete)
            Next
            strItensDeletado = ""
            vetDelete = Nothing
            For I = 0 To Me.grd1.RowCount - 1
                Dim strCodigo As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)
                Dim strCodProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodProd)
                Dim strTamanho As String = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho)
                Dim strQtd As String = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                Dim strloja As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodLoja)
                Dim strValorCusto As String = Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto)
                Dim strLote As String = Me.grd1.GetRowCellDisplayText(I, Me.colLote)
                If strCodigo = "" Then
                    Inserir("INSERT INTO Transferencia (CodOrdem, CodProd, Tamanho, Qtd, ValorCusto, CodLoja, CodConfig, CodUserSaida, Data, Status, EntSai, Lote) VALUES (" & Me.txtCodPed.Text & "," & strCodProd & ",'" & strTamanho & "'," & Num(strQtd) & "," & Num(strValorCusto) & "," & strloja & "," & CodConfig & "," & CodUser & ",'" & Me.dtData.Text & "','Pendente','S','" & strLote & "')")
                Else
                    Atualizar("UPDATE Transferencia SET CodProd = " & strCodProd & ", Tamanho = '" & strTamanho & "', Qtd = " & Num(strQtd) & ", ValorCusto = " & Num(strValorCusto) & ", CodLoja = " & strloja & ", CodUserSaida = " & CodUser & ", Lote = '" & strLote & "' where Codigo = " & strCodigo & " and CodConfig = " & CodConfig)
                End If
            Next
        End If

        CarregarForm()
    End Sub
    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick

        If TesteConexao() = False Then Exit Sub

        Salvar(False)
        MsgBox("Transferência " & strCodOrdem & " salva com sucesso!", MsgBoxStyle.Information)
        If Me.Tag = "CADASTRA" Then
            Me.Close()
        End If
    End Sub


    Private Sub txtCodPed_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPed.Leave
        If Me.txtCodPed.Text = "" Then Exit Sub
        CarregarForm()
    End Sub

    Private Sub CarregarForm()
        Dim dt As DataTable = CarregarDataTable("SELECT Transferencia.Codigo, CodProd, Transferencia.Tamanho, " & _
        "Convert(Numeric(15,2),Transferencia.Qtd) as Qtd, CodLoja, Convert(Varchar(10),Transferencia.Data,103) as Data, " & _
        "Transferencia.Status, Convert(Numeric(15,2),Transferencia.ValorCusto) as ValorCusto, " & _
        "Convert(Numeric(15,2),(Transferencia.Qtd * Transferencia.ValorCusto)) as CustoTotal, " & _
        "Produto.CodigoInterno, Produto.Nome as Produto, Config.Descricao as Loja, Transferencia.Lote " & _
        "FROM (Transferencia left join Produto on Transferencia.CodProd = Produto.Codigo) " & _
        "left join Config on Transferencia.CodLoja = Config.Codigo where CodOrdem = " & Me.txtCodPed.Text & " and " & _
        "Transferencia.CodConfig = " & CodConfig & " and EntSai = 'S'")
        If dt.Rows.Count = 0 Then
            MsgBox("Transferência não cadastrada!", MsgBoxStyle.Information)
            Me.txtCodPed.ResetText()
            Me.txtCodPed.Focus()
            Exit Sub
        End If

      
      
        Dim I As Integer
        Dim bolEnv As Boolean = False
        If Me.Tag <> "CONSULTA" Then

            For I = 0 To dt.Rows.Count - 1
                strStatus = dt.Rows.Item(I).Item("Status").ToString

                'If strStatus = "Enviado" Then
                '    MsgBox("Esta transferência já foi enviada não e possível altera-la nem envia-la novamente!", MsgBoxStyle.Information)
                '    Exit Sub
                'End If
                'If strStatus = "Atendido" Then
                '    MsgBox("Esta transferência já foi enviada e atendia não e possível altera-la nem envia-la novamente!", MsgBoxStyle.Information)
                '    Exit Sub
                'End If

                If strStatus = "Pendente" Then
                    bolEnv = True
                    Exit For
                End If

            Next
            If bolEnv = False Then
                MsgBox("Esta transferência já foi enviada e atendia não e possível altera-la nem envia-la novamente!", MsgBoxStyle.Information)
                Exit Sub
            End If
            strCodOrdem = Me.txtCodPed.Text
            Me.tbItens.Rows.Clear()
            With Me.tbItens.Rows
                For I = 0 To dt.Rows.Count - 1
                    If dt.Rows.Item(I).Item("Status").ToString = "Pendente" Then
                        .Add()
                        .Item(.Count - 1).Item("Codigo") = dt.Rows.Item(I).Item("Codigo").ToString
                        .Item(.Count - 1).Item("CodProd") = dt.Rows.Item(I).Item("CodProd").ToString
                        .Item(.Count - 1).Item("Tamanho") = dt.Rows.Item(I).Item("Tamanho").ToString
                        .Item(.Count - 1).Item("Qtd") = dt.Rows.Item(I).Item("Qtd").ToString
                        .Item(.Count - 1).Item("Loja") = dt.Rows.Item(I).Item("Loja").ToString
                        .Item(.Count - 1).Item("CodLoja") = dt.Rows.Item(I).Item("CodLoja").ToString
                        .Item(.Count - 1).Item("ValorCusto") = dt.Rows.Item(I).Item("ValorCusto").ToString
                        .Item(.Count - 1).Item("CustoTotal") = dt.Rows.Item(I).Item("CustoTotal").ToString
                        .Item(.Count - 1).Item("Lote") = dt.Rows.Item(I).Item("Lote").ToString
                        .Item(.Count - 1).Item("CodigoInterno") = dt.Rows.Item(I).Item("CodigoInterno").ToString
                        .Item(.Count - 1).Item("Produto") = dt.Rows.Item(I).Item("Produto").ToString
                    End If

                Next
            End With
        Else
            strCodOrdem = Me.txtCodPed.Text
            Me.tbItens.Rows.Clear()
            With Me.tbItens.Rows
                For I = 0 To dt.Rows.Count - 1

                    .Add()
                    .Item(.Count - 1).Item("Codigo") = dt.Rows.Item(I).Item("Codigo").ToString
                    .Item(.Count - 1).Item("CodProd") = dt.Rows.Item(I).Item("CodProd").ToString
                    .Item(.Count - 1).Item("Tamanho") = dt.Rows.Item(I).Item("Tamanho").ToString
                    .Item(.Count - 1).Item("Qtd") = dt.Rows.Item(I).Item("Qtd").ToString
                    .Item(.Count - 1).Item("Loja") = dt.Rows.Item(I).Item("Loja").ToString
                    .Item(.Count - 1).Item("CodLoja") = dt.Rows.Item(I).Item("CodLoja").ToString
                    .Item(.Count - 1).Item("ValorCusto") = dt.Rows.Item(I).Item("ValorCusto").ToString
                    .Item(.Count - 1).Item("CustoTotal") = dt.Rows.Item(I).Item("CustoTotal").ToString
                    .Item(.Count - 1).Item("Lote") = dt.Rows.Item(I).Item("Lote").ToString
                    .Item(.Count - 1).Item("CodigoInterno") = dt.Rows.Item(I).Item("CodigoInterno").ToString
                    .Item(.Count - 1).Item("Produto") = dt.Rows.Item(I).Item("Produto").ToString


                Next
            End With
        End If


        Me.dtData.Text = dt.Rows.Item(0).Item("Data").ToString
        Calcular()
        Me.txtCodProd.Focus()

    End Sub

    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click
        ConsultaPedido = ""
        Dim frm As New frmConPed
        frm.Tag = Me.Tag & "TRANS"
        frm.ShowDialog()

        If ConsultaPedido <> "" Then
            Me.txtCodPed.Text = ConsultaPedido
            CarregarForm()
        Else
            Me.txtCodPed.Text = ""
            Me.txtCodPed.Focus()
        End If
    End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        bolAlterar = True
        IndexGrid = Me.grd1.FocusedRowHandle
        Me.txtCodProd.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigoInterno)
        Me.txtCodProd.Tag = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodProd)
        Me.txtProd.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colProduto)
        Me.txtQtde.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colQtd)
        Me.txtValor.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colValorCusto)
        Me.lueLoja.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colLoja)
        Me.lueLoja.ClosePopup()
        TamanhoDoProduto = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colTamanho)

        Me.txtCodProd.Focus()
    End Sub

    Private Sub btnExcluir_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        If bolAlterar = True Then MsgBox("Existe um item sendo alterado, conclua a alteração antes de excluir algum item!", MsgBoxStyle.Information) : Exit Sub
        If grd1.RowCount = 0 Then Exit Sub
        If MsgBox("Deseja realmente excluir este item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodigo) <> "" Then
                strItensDeletado &= grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodigo) & "|"
            End If

            Me.grd1.DeleteRow(grd1.FocusedRowHandle)
        End If
        Calcular()
    End Sub

    Private Sub btnEnviar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEnviar.ItemClick
        If TesteConexao() = False Then Exit Sub

        Dim I As Integer

        'intCodOrdem = GerarCodigo("OrdemTrans", "Codigo", CodConfig)
        'Inserir("INSERT INTO OrdemTrans (Codigo, CodConfig) VALUES (" & intCodOrdem & "," & CodConfig & ")")
        'Me.txtCodPed.Text = intCodOrdem
        'For I = 0 To Me.grd1.RowCount - 1
        '    Dim strCodProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodProd)
        '    Dim strUM As String
        '    Dim dtUM As DataTable = CarregarDataTable("SELECT UnidadeMedida FROM Produto where Codigo = " & strCodProd)
        '    If dtUM.Rows.Count > 0 Then
        '        strUM = dtUM.Rows.Item(0).Item("UnidadeMedida").ToString
        '    Else
        '        strUM = "UN"
        '    End If
        '    Dim strTamanho As String = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho)
        '    Dim strQtd As String = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
        '    Dim strloja As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodLoja)
        '    Dim strValorCusto As String = Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto)
        '    Dim strLote As String = Me.grd1.GetRowCellDisplayText(I, Me.colLote)
        '    BaixarProduto(strCodProd, strQtd, strTamanho, strUM, False, False)

        '    If EstoqueSomado = True Then
        '        Dim dblQtd As Double = strQtd
        '        dblQtd = dblQtd - (dblQtd + dblQtd)
        '        Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data, CodUser) VALUES (" & strCodProd & "," & Num(dblQtd) & "," & CodConfig & ",'TRANS. ENVIADA','" & My.Computer.Clock.LocalTime & "'," & CodUser & ")")
        '    End If

        '    Inserir("INSERT INTO Transferencia (CodOrdem, CodProd, Tamanho, Qtd, ValorCusto, CodLoja, CodConfig, CodUserSaida, Data, Status, EntSai, Lote) VALUES (" & intCodOrdem & "," & strCodProd & ",'" & strTamanho & "'," & Num(strQtd) & "," & Num(strValorCusto) & "," & strloja & "," & CodConfig & "," & CodUser & ",'" & Me.dtData.Text & "','Enviado','S','" & strLote & "')")


        'Next
        Salvar(False)
        Dim strAuxiliar As String = ""
        Try
            strAuxiliar = NomeComputador.ToUpper & " Cód User:" & CodUser & " " & Format(My.Computer.Clock.LocalTime, "dd/MM/yyyy HH:mm:ss:fffff")
        Catch ex As Exception
            strAuxiliar = NomeComputador.ToUpper & " Cód User:" & CodUser & " " & Date.Today.Day & "/" & Date.Today.Month & "/" & Date.Today.Year & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now)
        End Try

        Dim dt As DataTable = CarregarDataTable("SELECT Codigo, CodProd, Qtd, Tamanho, Auxiliar FROM Transferencia where CodOrdem = " & strCodOrdem & " and CodConfig = " & CodConfig & " and Status = 'Pendente'")
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As String = dt.Rows.Item(I).Item("Codigo").ToString
            Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
            Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
            Dim strTamanho As String = dt.Rows.Item(I).Item("Tamanho").ToString

            Dim strAux As String = dt.Rows.Item(I).Item("Auxiliar").ToString
            If strAux = "" Then
                strAux = strAuxiliar
            Else
                strAux = strAux & "|" & strAuxiliar
            End If
            Dim strUM As String = ""
            Dim dtUM As DataTable = CarregarDataTable("SELECT UnidadeMedida FROM Produto where Codigo = " & strCodProd)
            If dtUM.Rows.Count > 0 Then
                strUM = dtUM.Rows.Item(0).Item("UnidadeMedida").ToString
            Else
                strUM = "UN"
            End If

            BaixarProduto(strCodProd, strQtd, strTamanho, strUM, False, False)
            If EstoqueSomado = True Then
                Dim dblQtd As Double = strQtd
                dblQtd = dblQtd - (dblQtd + dblQtd)
                Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data, " & _
                "CodUser) VALUES (" & strCodProd & "," & Num(dblQtd) & "," & CodConfig & "," & _
                "'TRANS. ENVIADA','" & My.Computer.Clock.LocalTime & "'," & CodUser & ")")
            End If

            Atualizar("UPDATE Transferencia set Status = 'Enviado', Auxiliar = '" & strAux & "' where Codigo = " & strCodigo)
        Next

   


        MsgBox("Transferência " & strCodOrdem & " enviada com sucesso!", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub txtCodProd_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodProd.KeyPress, txtProd.KeyPress, txtCodPed.KeyPress
        If e.KeyChar = "'" Or e.KeyChar = "&" Then
            e.Handled = True
        End If
    End Sub

    Private Sub dtData_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtData.EditValueChanged

    End Sub


    Private Function JaInserido(ByVal ParCodProdAut As Integer, ByVal parTamanho As String, ByVal parQtde As Double, ByVal parCodConfig As Integer) As Boolean
        If AgruparProdutoVenda = False Then Exit Function

        Dim Y As Integer

        Dim intCodProdGrid As Integer
        Dim strTamanhoGrid As String
        Dim bolInserido As Boolean = False


        For Y = 0 To Me.grd1.RowCount - 1


            intCodProdGrid = Me.grd1.GetRowCellValue(Y, Me.colCodProd)
            strTamanhoGrid = Me.grd1.GetRowCellValue(Y, Me.colTamanho)
            Dim intCodConfigGrid As Integer = Me.grd1.GetRowCellValue(Y, Me.colCodLoja)
            If ParCodProdAut = intCodProdGrid And parCodConfig = intCodConfigGrid Then
                If parTamanho = strTamanhoGrid Then
                    Dim dblQtdGrid As Double = Me.grd1.GetRowCellValue(Y, Me.colQtd)
                    dblQtdGrid += CDbl(parQtde)

                    If PermiteEstoqueZerado = False Then

                        If EstoqueSomado = False Then
                            Dim strSql As String = "Select sum(Qtd) as Qtd from Qtde where CodProd =" & ParCodProdAut & " and Tamanho ='" & parTamanho & "' and Acabou = 'False' and CodConfig =" & CodConfig

                            Dim dtQtd As DataTable = CarregarDataTable(strSql)
                            If dtQtd.Rows.Count = 0 Then
                                MsgBox("Não existem quantidades desse produto em estoque!", MsgBoxStyle.Information)
                                bolInserido = True
                                Return bolInserido
                            Else

                                Dim dblQtdTabQtde As Double = 0
                                If dtQtd.Rows(0).Item("Qtd").ToString <> "" Then
                                    dblQtdTabQtde = dtQtd.Rows(0).Item("Qtd").ToString
                                End If
                                If dblQtdGrid > dblQtdTabQtde Then
                                    MsgBox("Não existe a quantidade adicionada desse produto em estoque!", MsgBoxStyle.Information)
                                    bolInserido = True
                                    Return bolInserido
                                End If
                            End If
                        Else
                            Dim dblResul As Double = AjusteQtde(CodConfig, ParCodProdAut)

                            If dblResul <= 0 Then
                                MsgBox("Não existem quantidades desse produto em estoque!", MsgBoxStyle.Information)

                                bolInserido = True
                                Return bolInserido
                            Else

                                If dblQtdGrid > dblResul Then
                                    MsgBox("Não existe a quantidade adicionada desse produto em estoque!", MsgBoxStyle.Information)

                                    bolInserido = True
                                    Return bolInserido
                                End If
                            End If
                        End If

                    End If


                    Me.grd1.SetRowCellValue(Y, Me.colQtd, dblQtdGrid.ToString("0.000"))
                    bolInserido = True
                    Exit For
                End If
            End If

        Next

        Return bolInserido
    End Function

    Private Sub txtQtde_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtde.Leave
        If Me.txtCodProd.Text = "" Then
            Me.txtCodProd.Focus()
        End If
    End Sub
End Class