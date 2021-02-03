Imports Nano.clsFuncoes
Imports Nano.clsDarBaixa
Imports Nano.clsValidar
Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Diagnostics
Imports System.Globalization
Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Public Class frmPedidoCompra
    Dim I As Integer
    Dim strNomeForm As String
    Dim bolConsulta As Boolean = False
    Dim bolDecimais As Boolean = False
    Dim bolSalvar As Boolean = False
    Dim IndexGrid As Integer
    Dim CPF As String
    Dim Cliente As String
    Dim vetProd(8) As String
    Dim strTipoComissao As String
    Dim bolValida As Boolean = False
    Dim bolUsarTabela As Boolean = True
    Dim strItensDeletado As String
    Dim dblValorDeCusto, dblTotalDeCusto, dblPeso, dblTotalPeso As Double
    Dim strEstaComFocus As String
    Dim bolJaPassou As Boolean = False
    Dim dtDadosCliente As DataTable
    Dim bolJaSalvo As Boolean = False
    Dim bolAbriuProduto As Boolean = False
    Dim strOrigemDesconto As String
    Dim intVencDias As Integer
    Dim vet(19) As String
    Dim intCodFunc As Integer
    Dim leitor As StringReader
    Dim intCodFor As Integer
    Dim strCodigoAtivo As String
    Dim strCodigoPadrao As String
    Dim strCodigoPedidoAtivo As String
    Dim bolPromocao As Boolean = False
    Dim dblUniSemDesc As Double
    Dim dblUniSemDescOriginal As Double


    Dim dblTotalComDesconto As Double
    Dim dblTotalSemDesconto As Double

    Dim dtStartData As Date
    Dim strDescricao As String
    Dim strLembrete As String

    Dim bolTimer2 As Boolean
    Dim bolGaxeta As Boolean = False

    Dim strDescontoCliente As String = ""
    Dim strCodProdFor As String
    Private Sub frmPedido_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Me.Tag = "FATURA" Then
            If bolSalvar = False Then
                Dim str As String
                str = "delete from Recebimento where CodigoPedido = '" & Me.txtCodPed.Text.Trim & "'"
                Excluir(str)

                str = "delete from ContaReceber where Cod = '" & Me.txtCodPed.Text.Trim & "'"
                Excluir(str)
            End If
        End If

    End Sub

    Private Sub frmPedido_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.Tag = "CADASTRA" Or Me.Tag = "ALTERA" Then
            If grd1.RowCount > 0 Then
                If bolSalvar = False Then
                    If MsgBox("Deseja salvar os dados antes de fechar a janela?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Salvar(False)
                        If bolSalvar = False Then
                            e.Cancel = True
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub frmPedido_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    If Me.Tag = "CADASTRA" Then
                        Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "26")
                    ElseIf Me.Tag = "ALTERA" Then
                        Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "86")
                    Else
                        Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "85")
                    End If
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If

        If e.KeyCode = Keys.F6 Then
            Me.txtDesc.Focus()
            Salvar(False)
        End If

        If e.KeyCode = Keys.F10 Then

            If strEstaComFocus = "txtCodPed" Then
                ConsultarPedido()
            End If

            If Me.Tag = "FATURA" Or Me.Tag = "CONSULTA" Then Exit Sub
            Select Case strEstaComFocus
                Case "txtCli"
                    AbreFornecedor()
                Case "txtCodPro"
                    AbrirProdutos()
                Case "txtCodPro2"
                    RemoverProdutos()

            End Select

        End If
    End Sub

    Private Sub frmPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If CNPJEmpresa = "15042566000153" Then
            'ESSENCIAL
            Me.tbItens.Columns("CodigoInterno").DataType = System.Type.GetType("System.Int32")
            Me.colCodigoPeca.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        End If

        If TesteConexao() = False Then Exit Sub
        Me.txtCodPro.Tag = ""

        If NomeEmpresa.Trim.Contains("CHOPP") = True Then
            Me.btnAtivo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If

        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)

        Me.pnlProduto.Dock = DockStyle.Fill
        Me.tabAtivo.Visible = False

        Me.txtValor.Enabled = AlteraPrecoPedido
        CarregarDadosLue("SELECT Codigo, Nome FROM Funcionario where Ativo ='True' and CodConfig =" & CodConfig, Me.lueFunc)
        If Me.Tag = "ALTERA" Then

            txtCodPed.Enabled = True
            txtCodPed.Focus()
            Me.Text = "Alterar Pedido de Compra"
            PedidoGridControl.Dock = DockStyle.Fill
            Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Timer2.Start()
        ElseIf Me.Tag = "CONSULTA" Then
            bolConsulta = True
            txtCodPed.Enabled = True
            txtCodPed.Focus()
            dtData.Properties.ReadOnly = True
            dtRetirada.Properties.ReadOnly = True
            dtEntrega.Properties.ReadOnly = True
            ' grpProd.Enabled = False
            txtCli.Properties.ReadOnly = True
            Me.btnDelete.Visible = False
            btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.Text = "Consulta Pedido de Compra"

            txtDesc.Properties.ReadOnly = True
            txtDesconto.Properties.ReadOnly = True
            Me.txtValDesc.Properties.ReadOnly = True
            Me.txtEntrega.Properties.ReadOnly = True
            If TemImpressora = True Then
                Me.btnImprimir.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            End If
            Me.txtNomePro.Enabled = False
            Me.txtQtd.Enabled = False
            Me.txtValor.Enabled = False
            Me.btnAdd.Enabled = False
            Me.cboStatus.Properties.ReadOnly = True
            Me.tabProd.Enabled = False

            Timer2.Start()
        ElseIf Me.Tag = "FATURA" Then
            txtCodPed.Enabled = True
            dtData.Properties.ReadOnly = False
            dtRetirada.Properties.ReadOnly = True
            dtEntrega.Properties.ReadOnly = True
            tabProd.Enabled = False
            txtCli.Properties.ReadOnly = True
            Me.btnDelete.Visible = False
            btnSalvar.Caption = "&Faturar"
            Me.txtRec.Visible = True
            Me.txtTro.Visible = True
            Me.lblTro.Visible = True
            Me.lblRec.Visible = True
            pcLinha.Visible = True
            Me.Text = "Faturamento Pedido de Compra"
            Me.btnLimpar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.txtDesconto.Visible = False
            Me.lblDesc.Visible = False
            Me.lblValDesc.Visible = False
            Me.lblPor.Visible = False
            Me.txtValDesc.Visible = False
            Me.tabProd.Enabled = False

            txtCodPed.Focus()
            Timer2.Start()
        ElseIf Me.Tag = "CADASTRA" Then
            Me.btnMail.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.lueFunc.Location = New System.Drawing.Point(72, 11)
            Me.lblVenc.Location = New System.Drawing.Point(13, 14)
            Me.lueFunc.Size = New System.Drawing.Size(453, 20)
            Me.btnConsulta.Visible = False
            Me.txtCodPed.Visible = False
            Me.lblCodPed.Visible = False

            dtData.DateTime = Date.Today

            Me.Text = "Cadastro Pedido de Compra"
            Me.bsiVisualizar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            PedidoGridControl.Dock = DockStyle.Fill

            If NomeEmpresa.Trim.Contains("MASTER TOLDOS") = True Then
                Me.cboStatus.SelectedIndex = 1
            End If
            'CodigoDoCliente = 1
            'CarregarFornecedor(CodigoDoFornecedor)
        Else

            bolConsulta = True
            txtCodPed.Enabled = True
            dtData.Properties.ReadOnly = True
            tabProd.Enabled = False
            txtCli.Properties.ReadOnly = True
            Me.btnDelete.Visible = False
            Me.Text = "Alteração Pedido de Compra"
            txtDesc.Properties.ReadOnly = True
            txtDesconto.Properties.ReadOnly = True
            Me.txtValDesc.Properties.ReadOnly = True
            Me.txtEntrega.Properties.ReadOnly = True
            Me.PedidoGridControl.Enabled = False
            txtCodPed.Focus()

            Me.pnlProduto.Dock = DockStyle.None

            Me.tabAtivo.Visible = True
            Me.XtraTabPage1.Controls.Add(Me.pnlProduto)
            Me.pnlProduto.Dock = DockStyle.Fill
            Me.tabAtivo.Dock = DockStyle.Fill
        End If
        If AlteraNomePedido = False Then
            Me.txtNomePro.Properties.ReadOnly = True
        End If

        strNomeForm = Me.Text.Trim

        If NomeEmpresa.Trim.Contains("RAISNER") = True Then
            Me.colCodigoPeca.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        End If

        If Nivel = "USUÁRIO" Then
            Me.txtPerDesc.Properties.ReadOnly = True
        End If

    End Sub
    Private Sub TamanhoProd(ByVal parCodProd As String)
        TamanhoDoProduto = "U"

        Dim strSql As String = "Select Tamanho, sum(Qtd) as Qtd from Qtde Where Acabou = 'False' and CodProd =" & parCodProd & " and CodConfig =" & CodConfig & " group by Tamanho"

        Dim dtQtd As DataTable = CarregarDataTable(strSql)

        If dtQtd.Rows.Count > 1 Then
            Dim frm As New frmTamanhoProd
            frm.Tag = strSql
            frm.ShowDialog()
        Else
            If dtQtd.Rows.Count > 0 Then
                TamanhoDoProduto = dtQtd.Rows.Item(0).Item("Tamanho")
            End If
        End If

        Select Case tabProd.SelectedTabPageIndex
            Case 0
                Me.txtTamanho.Text = TamanhoDoProduto
            Case 1
                Me.txtTamanho2.Text = TamanhoDoProduto
        End Select

    End Sub
    Private Sub Limpar(ByVal bolFocus As Boolean)
        'Me.rdgDesc.SelectedIndex = 0
        dtStartData = Nothing
        strDescricao = ""
        Me.GroupControl2.Enabled = True
        Me.GroupControl3.Enabled = True
        Me.txtTamanho.ResetText()
        txtNomePro.ResetText()
        txtQtd.ResetText()
        txtValor.ResetText()
        Me.txtCodPro.Tag = ""
        Me.txtQtd.ToolTipTitle = ""
        Me.txtCodPro.ResetText()
        dblValorDeCusto = 0
        'Me.txtCodPro.Focus()
        Me.txtEntrega.ResetText()
        Me.txtQtd.ResetText()
        'Me.txtTotProd.Text = "0.00"
        'Me.txtTotPeso.Text = "0.00"
        Me.txtTotal.Text = "0.00"
        Me.txtTotItem.Text = "0"
        Me.txtRec.ResetText()
        Me.txtTro.ResetText()
        Me.txtDesc.ResetText()
        Me.txtDesconto.ResetText()
        Me.txtValDesc.ResetText()

        Me.txtCli.ResetText()

        frmRecebimento.tbRec.Rows.Clear()
        Me.tbItens.Rows.Clear()

        Me.txtTel.ResetText()
        Me.txtFax.ResetText()
        Me.lueFunc.EditValue = DBNull.Value
        CarregarDadosLue("SELECT Codigo, Nome FROM Funcionario where Ativo ='True'", Me.lueFunc)
        Me.txtEmail.ResetText()

        If bolFocus = True Then
            Me.lueFunc.Focus()
        End If
        dtRetirada.ResetText()
        dtEntrega.ResetText()

        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        Dim index As Integer = -999997
        grd1.FocusedRowHandle = index
        grd1.SetRowCellValue(index, Me.colProduto, "")
        grd1.SetRowCellValue(index, Me.colCodigoPeca, "")
        grd1.SetRowCellValue(index, Me.colUM, "")
        grd1.SetRowCellValue(index, Me.colTamanho, "")
        grd1.SetRowCellValue(index, Me.colQtd, "")
        grd1.SetRowCellValue(index, Me.colValorUnitario, "")
        grd1.SetRowCellValue(index, Me.colValorTotal, "")

        Gaxeta(0)

        If Me.Tag = "ATIVO" Then
            Me.tbAtivo.Rows.Clear()
            Me.grd2.OptionsView.ShowAutoFilterRow = True
            Me.grd2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            index = -999997
            grd2.FocusedRowHandle = index
            grd2.SetRowCellValue(index, Me.colCodPadrao, "")
            grd2.SetRowCellValue(index, Me.colNome, "")
            grd2.SetRowCellValue(index, Me.colValor, "")
            grd2.SetRowCellValue(index, Me.colExcluir2, Nothing)
            Me.tabAtivo.SelectedTabPageIndex = 0
        End If
        strDescontoCliente = ""
        Me.chkAlterado.Checked = False
        Me.picFundo.Visible = True
    End Sub

    Private Sub Calcular()

        Dim dblTotal, dblQtd As Double

        'For I = 0 To grd1.RowCount - 1

        '    'ESSA LINHA TEM QUE FICAR AQUI
        '    dblQtd = grd1.GetRowCellDisplayText(I, Me.colQtd)

        '    dblLinha = grd1.GetRowCellValue(I, Me.colValorTotal)
        '    dblTotal += dblLinha

        '    dblLinha = grd1.GetRowCellValue(I, Me.colCusto)
        '    dblTotCusto += dblLinha

        'Next

        'For I = 0 To Me.tbItens.Rows.Count - 1

        '    'ESSA LINHA TEM QUE FICAR AQUI
        '    dblQtd = Me.tbItens.Rows.Item(I).Item("Qtd")

        '    dblLinha = Me.tbItens.Rows.Item(I).Item("ValorTotal")
        '    dblTotal += dblLinha

        '    dblLinha = Me.tbItens.Rows.Item(I).Item("Custo")
        '    dblTotCusto += dblLinha

        'Next

        'Me.txtTotal.Text = dblTotal.ToString("0.00")
        'dblTotalDeCusto = dblTotCusto.ToString("0.00")
        'Me.txtDesconto.Tag = dblTotal.ToString("0.00")


        'Dim dblDesc, dblResul, dblResulTotal As Double
        'If parDesconto = "PORCENTAGEM" Then
        '    If Me.txtDesconto.Text <> "" And Me.txtDesconto.Text <> "0,00" Then
        '        dblDesc = Me.txtDesconto.Text
        '        Me.txtDesconto.Text = dblDesc.ToString("0.00")
        '        dblResul = (CDbl(dblTotal.ToString("0.00")) * CDbl(dblDesc.ToString("0.00"))) / 100
        '        Me.txtValDesc.Text = dblResul.ToString("0.00")
        '        dblResulTotal = CDbl(dblTotal.ToString("0.00")) - CDbl(dblResul.ToString("0.00"))
        '        Me.txtTotal.Text = dblResulTotal.ToString("0.00")

        '    End If
        'End If


        'Dim dblValDesc As Double
        'If parDesconto = "VALOR" Then
        '    If Me.txtValDesc.Text <> "" And Me.txtValDesc.Text <> "0,00" Then
        '        dblValDesc = Me.txtValDesc.Text
        '        Me.txtValDesc.Text = dblValDesc.ToString("0.00")
        '        dblResul = (100 * CDbl(dblValDesc.ToString("0.00"))) / CDbl(dblTotal.ToString("0.00"))
        '        Me.txtDesconto.Text = dblResul.ToString("0.00")
        '        dblResulTotal = CDbl(dblTotal.ToString("0.00")) - CDbl(dblValDesc.ToString("0.00"))
        '        Me.txtTotal.Text = dblResulTotal.ToString("0.00")
        '    End If
        'End If

        Dim dblValUni, dblPercent, dblCusto, dblResto, dblResul, dblTotSemDesc, dblItens, dblSomaDifDesc As Double

        Dim I As Integer
        For I = 0 To Me.tbItens.Rows.Count - 1

            If Me.txtDesconto.Text.Trim <> "" Then
                'If Me.grd1.GetRowCellValue(I, Me.colPromocao) = False Then
                '    Me.grd1.SetRowCellValue(I, Me.colDesconto, Me.txtDesconto.Text.Trim)
                'End If
                If Me.tbItens.Rows.Item(I).Item("Promocao") = False Then
                    Me.tbItens.Rows.Item(I).Item("Desconto") = Me.txtDesconto.Text.Trim
                End If
            End If

        Next
        'For I = 0 To grd1.RowCount - 1
        '    dblQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
        '    dblValUni = Me.grd1.GetRowCellDisplayText(I, Me.colValorUnitario)


        '    dblItens += dblQtd

        '    If TipoDesconto = "ITENS" Then
        '        If dblValUni > 0 Then

        '            dblValUni = Me.grd1.GetRowCellDisplayText(I, Me.colUniSemDesc)
        '            dblPercent = 0
        '            If Me.grd1.GetRowCellDisplayText(I, Me.colDesconto) <> "" Then
        '                dblPercent = Me.grd1.GetRowCellDisplayText(I, Me.colDesconto)

        '            End If

        '            dblResto = (dblValUni / 100) * dblPercent

        '            dblValUni = dblValUni - dblResto
        '            If Me.grd1.GetRowCellValue(I, Me.colPromocao) = False Then

        '                dblSomaDifDesc += dblValUni.ToString("0.00") * dblQtd

        '                If I = grd1.RowCount - 1 Then


        '                    If dblQtd = 1 Then
        '                        If Me.txtValDesc.Text <> "0,00" And Me.txtValDesc.Text.Trim <> "" Then
        '                            Dim strDifer As String

        '                            strDifer = (dblTotalSemDesconto - CDbl(dblSomaDifDesc).ToString("0.00")).ToString("0.00")

        '                            If strDifer <> Me.txtValDesc.Text Then
        '                                Dim dblDifer As Double

        '                                dblDifer = (CDbl(Me.txtValDesc.Text) - CDbl(strDifer)).ToString("0.00")

        '                                dblValUni = dblValUni - dblDifer

        '                            End If

        '                        End If
        '                    End If
        '                End If
        '            End If

        '            Me.grd1.SetRowCellValue(I, Me.colValorUnitario, dblValUni.ToString("0.00"))
        '        End If
        '    End If


        '    dblResul = dblValUni.ToString("0.00") * dblQtd

        '    Me.grd1.SetRowCellValue(I, Me.colValorTotal, dblResul.ToString("0.00"))

        '    dblTotal += dblResul.ToString("0.00")
        '    dblCusto += CDbl(Me.grd1.GetRowCellDisplayText(I, Me.colCusto)) * dblQtd

        '    If Me.grd1.GetRowCellValue(I, Me.colPromocao) = False Then
        '        dblTotSemDesc += CDbl(Me.grd1.GetRowCellDisplayText(I, Me.colUniSemDesc)) * dblQtd
        '    End If

        'Next

        Dim dblValSemDescCasaDecimal As Double
        Dim dblTotLucro As Double
        For I = 0 To Me.tbItens.Rows.Count - 1
            dblQtd = Me.tbItens.Rows.Item(I).Item("Qtd")
            dblValUni = Me.tbItens.Rows.Item(I).Item("ValorUnitario")


            dblItens += dblQtd

            If TipoDesconto = "ITENS" Then
                If dblValUni > 0 Then

                    dblValUni = Me.tbItens.Rows.Item(I).Item("UniSemDesc")
                    dblPercent = 0
                    If Me.tbItens.Rows.Item(I).Item("Desconto") <> "" Then
                        dblPercent = Me.tbItens.Rows.Item(I).Item("Desconto")

                    End If

                    dblResto = (dblValUni / 100) * dblPercent

                    dblValUni = dblValUni - dblResto
                    If Me.tbItens.Rows.Item(I).Item("Promocao") = False Then

                        dblSomaDifDesc += CampoValor(dblValUni) * dblQtd
                        If CasaDecimal = "2" Or CasaDecimal = "3" Then
                            If I = grd1.RowCount - 1 Then


                                If dblQtd = 1 Then
                                    If Me.txtValDesc.Text <> "0,00" And Me.txtValDesc.Text.Trim <> "" Then
                                        Dim strDifer As String

                                        strDifer = CampoValor((dblTotalSemDesconto - CDbl(CampoValor(dblSomaDifDesc))))

                                        If strDifer <> Me.txtValDesc.Text Then
                                            Dim dblDifer As Double

                                            dblDifer = CampoValor(CDbl(Me.txtValDesc.Text) - CDbl(strDifer))

                                            dblValUni = dblValUni - dblDifer

                                        End If

                                    End If
                                End If
                            End If
                        Else
                            Me.tbItens.Rows.Item(I).Item("ValorUnitario") = CampoValor(dblValUni)
                        End If
                        
                    End If
                    'Me.tbItens.Rows.Item(I).Item("ValorUnitario") = dblValUni.ToString("0.000")
                End If
            End If

            'dblResul = dblValUni.ToString("0.00") * dblQtd
            dblResul = CampoValor(dblValUni) * dblQtd
            Me.tbItens.Rows.Item(I).Item("ValorTotal") = dblResul.ToString("0.00")

            dblTotal += dblResul.ToString("0.00")
            dblCusto += CDbl(Me.tbItens.Rows.Item(I).Item("Custo")) * dblQtd

            'If Me.tbItens.Rows.Item(I).Item("Promocao") = False Then
            '    dblTotSemDesc += CDbl(Me.tbItens.Rows.Item(I).Item("UniSemDesc")) * dblQtd
            'End If
            Dim dblValSemDesc As Double = Me.tbItens.Rows.Item(I).Item("UniSemDesc")
            'dblTotSemDesc += CDbl(Me.grd1.GetRowCellDisplayText(I, Me.colValorSemDesconto)) * dblQtd
            dblValSemDesc = CampoValor(dblValSemDesc) * dblQtd
            If Me.grd1.GetRowCellValue(I, Me.colPromocao) = False Then
                'Dim dblValSemDesc As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValorSemDesconto)
                ''dblTotSemDesc += CDbl(Me.grd1.GetRowCellDisplayText(I, Me.colValorSemDesconto)) * dblQtd
                'dblValSemDesc = dblValSemDesc.ToString("0.00") * dblQtd
                dblTotSemDesc += CampoValor(dblValSemDesc)
            Else
                dblValSemDesc = CampoValor(dblValUni) * dblQtd
            End If
            dblValSemDescCasaDecimal += CampoValor(dblValSemDesc)

            Dim dblValCusto As Double = CDbl(Me.tbItens.Rows.Item(I).Item("Custo"))
            Dim dblLucro As Double = dblResul - dblValCusto

            dblTotLucro += dblLucro

            dblLucro = (dblLucro * 100) / dblValCusto
            Dim str As String = dblLucro
            If str = "+Infinito" Or str = "NaN (Não é um número)" Then
                dblLucro = 0
            End If



            Me.tbItens.Rows.Item(I).Item("Lucro") = dblLucro.ToString("0.00")


        Next

        Dim dblMargem As Double = (dblTotLucro * 100) / dblCusto

        Me.colLucro.SummaryItem.DisplayFormat = dblMargem.ToString("0.00")



        dblTotal = CorrigirCasaDecimal(dblTotal, dblValSemDescCasaDecimal)

        Me.txtTotal.Text = dblTotal.ToString("0.00")

        dblTotalComDesconto = dblTotal.ToString("0.00")

        dblTotalSemDesconto = dblTotSemDesc.ToString("0.00")

        dblTotalDeCusto = dblCusto

        Me.txtDesconto.Text = Me.txtDesconto.Text.Replace("-", "")
        Me.txtValDesc.Text = Me.txtValDesc.Text.Replace("-", "")
        Me.txtTotItem.Text = dblItens
        Dim dblEntrega, dblVal As Double
        If Me.txtEntrega.Text <> "" And Me.txtEntrega.Text <> "0,00" Then
            dblEntrega = Me.txtEntrega.Text
            Me.txtEntrega.Text = dblEntrega.ToString("0.00")
            dblTotal = Me.txtTotal.Text
            dblVal = dblEntrega + dblTotal
            Me.txtTotal.Text = dblVal.ToString("0.00")
        End If

    End Sub
    Private Function CorrigirCasaDecimal(ByVal parTotal As Double, ByVal parValSemDesc As Double) As Double

        If Me.txtValDesc.Text.Trim <> "" Then
            Dim dblValDesc As Double = Me.txtValDesc.Text.Trim
            If dblValDesc > 0 Then

                Dim bolOk As Boolean = False
                Dim intCount As Integer = 0
                Dim dblTotalTeste As Double = parValSemDesc - dblValDesc
                Dim dblDiferenca As Double = parTotal - dblTotalTeste
                dblDiferenca = dblDiferenca.ToString("0.00")

                While bolOk = False

                    If dblDiferenca = 0 Then Exit While

                    If dblDiferenca <> 0 Then
                        parTotal = 0


                        Dim I As Integer
                        For I = 0 To Me.tbItens.Rows.Count - 1

                            If Me.tbItens.Rows.Item(I).Item("Promocao") = False Then
                                If I = intCount Then
                                    Dim dblTot As Double = Me.tbItens.Rows.Item(I).Item("ValorTotal")
                                    dblTot = dblTot - dblDiferenca
                                    dblTot = dblTot.ToString("0.00")
                                    Dim dblQtd As Double = Me.tbItens.Rows.Item(I).Item("Qtd")

                                    Dim dblResul As Double = dblTot / dblQtd
                                    Me.tbItens.Rows.Item(I).Item("ValorUnitario") = CampoValor(dblResul)
                                    Me.tbItens.Rows.Item(I).Item("ValorTotal") = dblTot.ToString("0.00")


                                End If
                            End If


                            parTotal += Me.tbItens.Rows.Item(I).Item("ValorTotal")

                        Next

                        intCount += 1
                        dblTotalTeste = parValSemDesc - dblValDesc
                        dblDiferenca = parTotal - dblTotalTeste
                        dblDiferenca = dblDiferenca.ToString("0.00")

                        If dblDiferenca = 0 Then

                            bolOk = True

                        End If
                        If Me.grd1.RowCount > 1 Then
                            If intCount = Me.grd1.RowCount Then Exit While
                        Else
                            If intCount = 1 Then Exit While
                        End If
                    End If
                End While

            End If
        End If

        Return parTotal

    End Function
    Private Sub DescontoComPorcentagem()

        If Me.txtTotal.Text = "0,00" Then Exit Sub
        If Me.rdgDesc.SelectedIndex = 1 Then
            Me.txtDesconto.Text = "-" & Me.txtDesconto.Text
        End If
        If Me.txtDesconto.Text.Trim = "" Then
            txtDesconto.Text = "0,00"
            Me.txtValDesc.Text = "0,00"
            DescontoComValor(False)
            Exit Sub
        End If

        DescontoMaior()

        If Me.txtTotal.Text = "0,00" Then Exit Sub

        Dim dblTotal, dblPor, dblResul As Double

        If TipoDesconto = "ITENS" Then
            dblTotal = dblTotalSemDesconto
        Else
            dblTotal = dblTotalComDesconto
        End If
        dblPor = Me.txtDesconto.Text.Trim

        dblResul = (dblTotal * dblPor) / 100


        Me.txtValDesc.Text = dblResul.ToString("0.00")
        If Me.txtValDesc.Text = "0,00" Then
            Me.txtDesconto.Text = "0,00"
        End If

        If Me.txtValDesc.Text.ToUpper = "NAN (NÃO É UM NÚMERO)" Or Me.txtValDesc.Text.ToUpper = "+INFINITO" Then
            Me.txtDesconto.Text = "0,00"
            Me.txtValDesc.Text = "0,00"
        Else
            dblResul = dblTotal - dblResul

            txtTotal.Text = dblResul.ToString("0.00")

        End If

        If TipoDesconto = "ITENS" Then
            Calcular()
        End If
        Me.txtDesc.Focus()

    End Sub
    Private Sub DescontoComValor(ByVal parCarregaForm As Boolean)
        If txtValDesc.Text.Trim = "" Then txtValDesc.Text = "0,00"
        If Me.txtTotal.Text = "0,00" Then Exit Sub

        Dim dblTotal, dblValDesc, dblResul As Double

        If Me.rdgDesc.SelectedIndex = 1 Then
            Me.txtValDesc.Text = Me.txtValDesc.Text.Replace("-", "")
            Me.txtValDesc.Text = "-" & Me.txtValDesc.Text.Trim
        End If
        dblValDesc = Me.txtValDesc.Text.Trim

        If TipoDesconto = "ITENS" Then
            dblTotal = dblTotalSemDesconto
        Else
            dblTotal = dblTotalComDesconto
        End If


        dblResul = (dblTotal - dblValDesc)

        Me.txtTotal.Text = dblResul.ToString("0.00")



        If TipoDesconto = "ITENS" Then
            dblTotal = dblTotalSemDesconto
        Else
            dblTotal = dblTotalComDesconto
        End If

        dblValDesc = dblValDesc * 100

        dblResul = dblValDesc / dblTotal

        Me.txtDesconto.Text = CampoValor(dblResul)

        If Me.txtDesconto.Text.ToUpper = "NAN (NÃO É UM NÚMERO)" Or Me.txtDesconto.Text.ToUpper = "+INFINITO" Then
            Me.txtDesconto.Text = "0,00"
            Me.txtValDesc.Text = "0,00"
        End If

        DescontoMaior()

        If TipoDesconto = "ITENS" Then
            Calcular()
        End If

        If parCarregaForm = False Then
            Me.txtDesc.Focus()
        End If


    End Sub
    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If MsgBox("Deseja realmente limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Limpar(True)
        End If

    End Sub

    Private Sub Adicionar()

        If Validar(dtData) = False Then Exit Sub
        If Validar(Me.txtCodPro) = False Then Exit Sub
        If Validar(txtNomePro) = False Then Exit Sub
        If Validar(txtQtd) = False Then Exit Sub
        If Validar(txtValor) = False Then Exit Sub
        If Validar(txtTamanho) = False Then Exit Sub

        If bolGaxeta = True Then
            If Validar(Me.txtMedidaA) = False Then Exit Sub
            If Validar(Me.txtMedidaB) = False Then Exit Sub
        End If

        If txtQtd.Text = "0" Or txtQtd.Text = "0,000" Or txtQtd.Text = "0,00" Then MsgBox("Não é pertido adiconar a quantidade < " & txtQtd.Text & " > no pedido!", MsgBoxStyle.Exclamation) : txtQtd.Focus() : txtQtd.ResetText() : Exit Sub


        'If PermiteEstoqueZerado = False Then
        '    Dim dtPed As DataTable = CarregarDataTable("SELECT Sum(Qtd) as Qtde FROM ItensConsig left join TotalConsig " & _
        '    "on ItensConsig.CodOrdens = TotalConsig.CodOrdens and ItensConsig.CodConfig = totalConsig.CodConfig where " & _
        '    "CodigoProduto =" & Me.txtCodPro.Tag & " and ItensConsig.CodConfig = " & CodConfig & " and TotalConsig.Status = 'Pendente'")
        '    Dim dblQtdePed As Double = 0
        '    If dtPed.Rows.Count > 0 Then
        '        If dtPed.Rows.Item(0).Item("Qtde").ToString <> "" Then
        '            dblQtdePed = dtPed.Rows.Item(0).Item("Qtde").ToString()
        '        End If
        '    End If

        '    Dim strSql As String = "Select Tamanho, sum(Qtd) as Qtd from Qtde where CodProd =" & Me.txtCodPro.Tag & " and Acabou = 'False' and CodConfig =" & CodConfig & " group by Tamanho"
        '    Dim dtQtd As DataTable = CarregarDataTable(strSql)
        '    If EstoqueSomado = False Then
        '        If dtQtd.Rows.Count = 0 Then
        '            MsgBox("Não existem quantidades desse produto em estoque!", MsgBoxStyle.Information)
        '        Else
        '            Dim dtQtd2 As DataTable = CarregarDataTable("Select sum(Qtd) as Qtd from Qtde where CodProd =" & Me.txtCodPro.Tag & " and Tamanho ='" & TamanhoDoProduto & "' and Acabou = 'False' and CodConfig =" & CodConfig)

        '            Dim dblQtdAdd As Double

        '            If Me.txtQtd.Text = "" Then
        '                dblQtdAdd = 1
        '            Else
        '                dblQtdAdd = Me.txtQtd.Text.Trim
        '            End If

        '            Dim dblQtdTabQtde As Double = dtQtd2.Rows(0).Item("Qtd").ToString

        '            dblQtdTabQtde = dblQtdTabQtde - dblQtdePed
        '            If dblQtdTabQtde <= 0 Then
        '                MsgBox("Não existem quantidades desse produto em estoque!", MsgBoxStyle.Information)
        '            Else
        '                If dblQtdAdd > dblQtdTabQtde Then
        '                    MsgBox("Não existe a quantidade adicionada desse produto em estoque!", MsgBoxStyle.Information)
        '                End If
        '            End If


        '        End If
        '    Else

        '        Dim dblResul As Double = AjusteQtde(CodConfig, Me.txtCodPro.Tag)
        '        dblResul = dblResul - dblQtdePed
        '        If dblResul <= 0 Then
        '            MsgBox("Não existem quantidades desse produto em estoque!", MsgBoxStyle.Information)
        '        Else
        '            Dim dblQtdAdd As Double
        '            If Me.txtQtd.Text = "" Then
        '                dblQtdAdd = 1
        '            Else
        '                dblQtdAdd = Me.txtQtd.Text.Trim
        '            End If


        '            If dblQtdAdd > dblResul Then
        '                MsgBox("Não existe a quantidade adicionada desse produto em estoque!", MsgBoxStyle.Information)
        '            End If
        '        End If
        '    End If
        'End If


        Me.picFundo.Visible = False
        With Me.tbItens.Rows

            Dim dblResul, dblResulCusto, dblResulPeso As Double

            Dim dblUni As Double = Me.txtValor.Text

            Dim dblQtd As Double = Me.txtQtd.Text

            dblResul = dblQtd * dblUni
            dblResulCusto = dblValorDeCusto * dblQtd
            dblResulPeso = dblPeso * dblQtd

            Dim dblDesc As Double = 0
            If Me.txtPerDesc.Text <> "" Then
                dblDesc = Me.txtPerDesc.Text
            End If

            Me.txtValDesc.ResetText()
            Me.txtDesconto.ResetText()
            DescontoComValor(False)


            'Dim dblLucro As Double = dblResul - dblResulCusto
            'dblLucro = (dblLucro * 100) / dblResulCusto
            'Dim str As String = dblLucro
            'If str = "+Infinito" Or str = "NaN (Não é um número)" Then
            '    dblLucro = 0
            'End If
            Dim strProduto As String = Me.txtNomePro.Text
            If Me.txtMedidaA.Text <> "" Then
                If Me.txtMedidaA.Text <> "0,000" Then
                    strProduto = strProduto & " | " & Me.txtMedidaA.Text & " X " & Me.txtMedidaB.Text
                End If

            End If
            If Me.chkAlterado.Checked = False Then
                .Add()
                Dim Index As Integer = .Count - 1

                .Item(Index).Item("CodPedAut") = "Inserir"
                .Item(Index).Item("Qtd") = txtQtd.Text.Trim
                .Item(Index).Item("CodigoProduto") = Me.txtCodPro.Tag
                .Item(Index).Item("CodigoInterno") = Me.txtCodPro.Text
                .Item(Index).Item("Produto") = strProduto
                .Item(Index).Item("ValorUnitario") = CampoValor(dblUni)
                .Item(Index).Item("ValorTotal") = dblResul.ToString("0.00")
                .Item(Index).Item("Custo") = dblResulCusto.ToString("0.00")
                .Item(Index).Item("UM") = Me.txtQtd.ToolTipTitle
                .Item(Index).Item("Tamanho") = Me.txtTamanho.Text

                .Item(Index).Item("CodProdFor") = strCodProdFor

                .Item(Index).Item("Excluir") = False

                .Item(Index).Item("UniSemDesc") = CampoValor(dblUniSemDesc)
                .Item(Index).Item("Promocao") = bolPromocao

                .Item(Index).Item("Desconto") = CampoValor(dblDesc)


                .Item(Index).Item("MedidaA") = Me.txtMedidaA.Text
                .Item(Index).Item("MedidaB") = Me.txtMedidaB.Text
                .Item(Index).Item("QtdMedida") = Me.txtQtdMedida.Text


                '.Item(Index).Item("Lucro") = dblLucro.ToString("0.00")
            Else
                grd1.SetRowCellValue(IndexGrid, Me.colCodProdFor, strCodProdFor)
                grd1.SetRowCellValue(IndexGrid, Me.colProduto, strProduto)
                grd1.SetRowCellValue(IndexGrid, Me.colCodigoProduto, Me.txtCodPro.Tag.ToString)
                grd1.SetRowCellValue(IndexGrid, Me.colCodigoPeca, Me.txtCodPro.Text.Trim)
                grd1.SetRowCellValue(IndexGrid, Me.colQtd, Me.txtQtd.Text.Trim)
                grd1.SetRowCellValue(IndexGrid, Me.colValorUnitario, CampoValor(Me.txtValor.Text.Trim))
                grd1.SetRowCellValue(IndexGrid, Me.colValorTotal, dblResul.ToString("0.00"))
                grd1.SetRowCellValue(IndexGrid, Me.colCusto, dblResulCusto.ToString("0.00"))
                grd1.SetRowCellValue(IndexGrid, Me.colUM, Me.txtQtd.ToolTipTitle)
                grd1.SetRowCellValue(IndexGrid, Me.colTamanho, Me.txtTamanho.Text)


                grd1.SetRowCellValue(IndexGrid, Me.colUniSemDesc, CampoValor(dblUniSemDesc))
                grd1.SetRowCellValue(IndexGrid, Me.colPromocao, bolPromocao)
                grd1.SetRowCellValue(IndexGrid, Me.colDesconto, CampoValor(dblDesc))

                grd1.SetRowCellValue(IndexGrid, Me.colMedidaA, Me.txtMedidaA.Text)

                grd1.SetRowCellValue(IndexGrid, Me.colMedidaB, Me.txtMedidaB.Text)
                grd1.SetRowCellValue(IndexGrid, Me.colQtdMedida, Me.txtQtdMedida.Text)

                'grd1.SetRowCellValue(IndexGrid, Me.colLucro, dblLucro.ToString("0.00"))
            End If

            Me.chkAlterado.Checked = False
        End With
        Me.txtValDesc.ResetText()
        Me.txtDesconto.ResetText()

        If strDescontoCliente = "" Then
            Me.txtPerDesc.ResetText()
        Else
            Me.txtPerDesc.Text = strDescontoCliente
        End If
        strCodProdFor = ""
        Me.txtMedidaA.ResetText()
        Me.txtMedidaB.ResetText()
        Me.txtQtdMedida.ResetText()
        bolPromocao = False
        Me.txtTamanho.ResetText()
        txtNomePro.ResetText()
        txtQtd.ResetText()
        txtValor.ResetText()
        Me.txtCodPro.Tag = ""
        Me.txtQtd.ToolTipTitle = ""
        Me.txtCodPro.ResetText()
        dblValorDeCusto = 0
        Me.txtCodPro.Focus()
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        'Dim indexFilter As Integer = -999997
        'grd1.FocusedRowHandle = indexFilter
        'grd1.SetRowCellValue(indexFilter, Me.colProduto, "")
        'grd1.SetRowCellValue(indexFilter, Me.colCodigoPeca, "")
        'grd1.SetRowCellValue(indexFilter, Me.colUM, "")
        'grd1.SetRowCellValue(indexFilter, Me.colTamanho, "")
        'grd1.SetRowCellValue(indexFilter, Me.colQtd, "")
        'grd1.SetRowCellValue(indexFilter, Me.colValorUnitario, "")
        'grd1.SetRowCellValue(indexFilter, Me.colValorTotal, "")

        'grd1.ShowEditor()
        Gaxeta(0)
        Calcular()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Adicionar()
    End Sub

    Private Sub txtKm_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtCodPro.Focus()
    End Sub

    Private Sub txtKm_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub
    Private Sub Salvar(ByVal parEntrada As Boolean)
        If Me.Tag <> "ATIVO" Then
            If Validar(Me.lueFunc) = False Then Exit Sub
            If Validar(Me.txtCli) = False Then Exit Sub
            If Validar(Me.dtData) = False Then Exit Sub
            'If Validar(Me.txtTotPeso) = False Then Exit Sub

            If Me.chkAlterado.Checked = True Then MsgBox("Existe um item sendo alterado, conclua a alteração antes de salvar!", MsgBoxStyle.Information) : Exit Sub
            'If Me.txtLimite.Text.Trim <> "" Then
            '    If Val(Me.txtLimite.Text.Trim) < Val(Me.txtTotal.Text.Trim) Then
            '        If MsgBox("O valor do Pedido excede o limite de crédito do cliente, deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            '            Exit Sub
            '        End If
            '    End If
            'End If

            Dim strCli As String = ""
            strCli = Me.txtCli.Text.Trim

            txtCli.Focus()
            If grd1.RowCount = 0 Then MsgBox("Não existem itens no Pedido!", 64) : Exit Sub



            intCodFunc = Me.lueFunc.GetColumnValue("Codigo")


            Dim index As Integer = -999997
            grd1.FocusedRowHandle = index
            grd1.SetRowCellValue(index, Me.colProduto, "")
            grd1.SetRowCellValue(index, Me.colCodigoPeca, "")
            grd1.SetRowCellValue(index, Me.colUM, "")
            grd1.SetRowCellValue(index, Me.colTamanho, "")
            grd1.SetRowCellValue(index, Me.colQtd, "")
            grd1.SetRowCellValue(index, Me.colValorUnitario, "")
            grd1.SetRowCellValue(index, Me.colValorTotal, "")


            'If Me.txtDesconto.Text.Trim = "" Then
            '    Calcular()
            'End If
            Dim strValDes, strPorDesc, strValAcre, strPorAcre As String

            If Me.rdgDesc.SelectedIndex = 0 Then
                strValDes = Me.txtValDesc.Text.Trim
                strPorDesc = Me.txtDesconto.Text.Trim
                strValAcre = "0,00"
                strPorAcre = "0,00"
            Else
                strValAcre = Me.txtValDesc.Text.Trim
                strPorAcre = Me.txtDesconto.Text.Trim
                strValDes = "0,00"
                strPorDesc = "0,00"
            End If



            If Me.Tag = "CADASTRA" Then

                intCodFunc = Me.lueFunc.GetColumnValue("Codigo")

                Dim intCodConsig As Integer
                intCodConsig = GerarCodigoOrdens("TotalPedCompra", CodConfig)

                Inserir("Insert into Ordens (Tabela, Cod, CodConfig) values('TotalPedCompra'," & intCodConsig & "," & CodConfig & ")")


                Inserir("Insert into TotalPedCompra(Data, CodFor, CodFunc, Total, Descricao, Desconto, Status, " & _
                "Custo, Entrega, CodConfig, CodOrdens, Acrescimo, DataRetirada, DataEntrega) Values('" & Me.dtData.Text.Trim & "'," & intCodFor & "," & _
                "" & intCodFunc & "," & Num(Me.txtTotal.Text.Trim) & "," & _
                "'" & Me.txtDesc.Text.Trim.Replace("'", "").Replace("&", "") & "','" & strValDes & "|" & strPorDesc & "'," & _
                "'" & Me.cboStatus.Text.Trim & "'," & Num(dblTotalDeCusto) & ",'" & Me.txtEntrega.Text.Trim & "'," & _
                "" & CodConfig & "," & intCodConsig & ",'" & strValAcre & "|" & strPorAcre & "','" & Me.dtRetirada.Text & "','" & Me.dtEntrega.Text & "')")


                Me.txtCodPed.Text = intCodConsig

                For I = 0 To grd1.RowCount - 1
                    Dim strCodigo, strCodigoPeca, strProduto, strQtd, strUnit, strTotal, strTipoProduto, strCusto, strUM, strTamanho, strUniSemDesc, strDesconto, strMedA, strMedB, strQtdMed As String
                    strCodigo = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto)
                    strCodigoPeca = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoPeca)
                    strProduto = Me.grd1.GetRowCellDisplayText(I, Me.colProduto).Replace("'", "")
                    strQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                    strUnit = Me.grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                    strTotal = Me.grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                    strTipoProduto = Me.grd1.GetRowCellDisplayText(I, Me.colTabelaPreco)
                    strCusto = Me.grd1.GetRowCellDisplayText(I, Me.colCusto)
                    strUM = Me.grd1.GetRowCellDisplayText(I, Me.colUM)
                    strTamanho = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho)
                    Dim bolProm As Boolean = Me.grd1.GetRowCellValue(I, Me.colPromocao)
                    strUniSemDesc = Me.grd1.GetRowCellDisplayText(I, Me.colUniSemDesc)
                    strDesconto = Me.grd1.GetRowCellDisplayText(I, Me.colDesconto)
                    strMedA = Me.grd1.GetRowCellDisplayText(I, Me.colMedidaA)
                    strMedB = Me.grd1.GetRowCellDisplayText(I, Me.colMedidaB)
                    strQtdMed = Me.grd1.GetRowCellDisplayText(I, Me.colQtdMedida)

                    Inserir("Insert into PedCompra (CodOrdens, Qtd, CodigoProduto, Produto, ValorUnitario, " & _
                    "ValorTotal, CodigoInterno, Custo, UM, Tamanho, CodConfig, UniSemDesc, Promocao, Desconto, MedidaA, MedidaB, QtdMedida) Values(" & _
                    "" & intCodConsig & "," & Num(strQtd) & ",'" & strCodigo & "','" & strProduto & "'," & _
                    "" & Num(strUnit) & "," & Num(strTotal) & ",'" & strCodigoPeca & "'," & Num(strCusto) & "," & _
                    "'" & strUM & "','" & strTamanho & "'," & CodConfig & "," & Num(strUniSemDesc) & ",'" & bolProm & "'," & Num(strDesconto) & "," & Num(strMedA) & "," & Num(strMedB) & "," & Num(strQtdMed) & ")")
                Next

                If strDescricao <> "" Then
                    Dim strCodOrdemAgenda As Integer = GerarCodigo("Agenda", "CodOrdem", CodConfig)

                    Inserir("INSERT INTO Agenda (CodOrdem, Type, StartDate, EndDate, AllDay, Subject, Location, Description, " & _
                    "Status, Label, Conta, ReminderInfo, CodConfig) VALUES (" & strCodOrdemAgenda & ",0,'" & dtStartData & "','" & dtStartData.AddHours(1) & "'," & _
                    "'False','Nº Pedido " & Me.txtCodPed.Text & "','','" & strDescricao & "',2,0,'False','" & strLembrete & "'," & CodConfig & ")")

                End If
            Else

                Dim vetDelete As Array = Split(strItensDeletado, "|")

                For I = 0 To vetDelete.Length - 1
                    If vetDelete(I) <> "" And vetDelete(I).ToString.ToUpper <> "INSERIR" Then
                        Dim strDelete As String
                        strDelete = "Delete From PedCompra where Codigo =" & vetDelete(I)
                        Excluir(strDelete)
                    End If

                Next
                vetDelete = Nothing
                strItensDeletado = ""
                Dim strUpdate As String = ""

                For I = 0 To grd1.RowCount - 1
                    Dim strCodigo, strCodigoPeca, strProduto, strQtd, strUnit, strTotal, strTipoProduto, strCodPedAut, strCusto, strUM, strTamanho, strUniSemDesc, strDesconto, strMedA, strMedB, strQtdMed As String
                    strCodPedAut = grd1.GetRowCellDisplayText(I, Me.colCodPedAut)
                    strCodigo = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto)
                    strCodigoPeca = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoPeca)
                    strProduto = Me.grd1.GetRowCellDisplayText(I, Me.colProduto).Replace("'", "")
                    strQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                    strUnit = Me.grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                    strTotal = Me.grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                    strTipoProduto = Me.grd1.GetRowCellDisplayText(I, Me.colTabelaPreco)
                    strCusto = Me.grd1.GetRowCellDisplayText(I, Me.colCusto)
                    strUM = Me.grd1.GetRowCellDisplayText(I, Me.colUM)
                    strTamanho = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho)
                    Dim bolProm As Boolean = Me.grd1.GetRowCellValue(I, Me.colPromocao)
                    strUniSemDesc = Me.grd1.GetRowCellDisplayText(I, Me.colUniSemDesc)
                    strDesconto = Me.grd1.GetRowCellDisplayText(I, Me.colDesconto)
                    strMedA = Me.grd1.GetRowCellDisplayText(I, Me.colMedidaA)
                    strMedB = Me.grd1.GetRowCellDisplayText(I, Me.colMedidaB)
                    strQtdMed = Me.grd1.GetRowCellDisplayText(I, Me.colQtdMedida)
                    If strCodPedAut = "Inserir" Then
                        grd1.SetRowCellValue(I, Me.colCodPedAut, "OK")

                        Inserir("Insert into PedCompra (CodOrdens, Qtd, CodigoProduto, Produto, ValorUnitario, " & _
                        "ValorTotal, CodigoInterno, Custo, UM, Tamanho, CodConfig, UniSemDesc, Promocao, Desconto, MedidaA, MedidaB, QtdMedida) Values(" & _
                        "" & Me.txtCodPed.Text.Trim & "," & Num(strQtd) & ",'" & strCodigo & "','" & strProduto & "'," & _
                        "" & Num(strUnit) & "," & Num(strTotal) & ",'" & strCodigoPeca & "'," & Num(strCusto) & "," & _
                        "'" & strUM & "','" & strTamanho & "'," & CodConfig & "," & Num(strUniSemDesc) & ",'" & bolProm & "'," & Num(strDesconto) & "," & Num(strMedA) & "," & Num(strMedB) & "," & Num(strQtdMed) & ")")
                    Else
                        If strCodPedAut <> "OK" Then

                            Atualizar("Update PedCompra set CodigoProduto ='" & strCodigo & "', CodigoInterno ='" & strCodigoPeca & "', " & _
                            "Produto ='" & strProduto & "', Qtd =" & Num(strQtd) & ", ValorUnitario = " & Num(strUnit) & ", " & _
                            "ValorTotal =" & Num(strTotal) & ", Custo =" & Num(strCusto) & ", UM ='" & strUM & "', " & _
                            "Tamanho = '" & strTamanho & "', UniSemDesc = " & Num(strUniSemDesc) & ", Promocao = '" & bolProm & "', " & _
                            "Desconto = " & Num(strDesconto) & ", MedidaA =" & Num(strMedA) & ", MedidaB =" & Num(strMedB) & ", " & _
                            "QtdMedida =" & Num(strQtdMed) & " where Codigo = " & strCodPedAut.Trim & " And CodConfig = " & CodConfig)
                        End If

                    End If
                Next

                Atualizar("Update TotalPedCompra set Data ='" & Me.dtData.EditValue & "', CodFor =" & intCodFor & ", " & _
                "CodFunc = " & intCodFunc & ", Total =" & Num(Me.txtTotal.Text.Trim) & ", " & _
                "Descricao ='" & Me.txtDesc.Text.Trim.Replace("'", "").Replace("&", "E") & "', " & _
                "Desconto = '" & strValDes & "|" & strPorDesc & "', Custo =" & Num(dblTotalDeCusto) & ", " & _
                "Entrega = '" & Me.txtEntrega.Text.Trim & "', Status ='" & Me.cboStatus.Text.Trim & "', " & _
                "Acrescimo = '" & strValAcre & "|" & strPorAcre & "', DataRetirada = '" & Me.dtRetirada.Text & "', " & _
                "DataEntrega = '" & Me.dtEntrega.Text & "' where CodOrdens =" & Me.txtCodPed.Text.Trim & " and CodConfig =" & CodConfig)

            End If

            Try

                bolSalvar = True
                If parEntrada = True Then
                    frmRecebimento.txtTotal.Text = Me.txtTotal.Text.Trim
                    frmRecebimento.txtTotal.Tag = Me.txtTotal.Text.Trim
                    frmRecebimento.txtARec.Text = Me.txtTotal.Text.Trim


                    frmRecebimento.Tag = ""
                    frmRecebimento.strCodPed = Me.txtCodPed.Text.Trim
                    frmRecebimento.intCodCliente = intCodFor
                    NomeDoCliente = Me.txtCli.Text
                    frmRecebimento.ShowDialog()
                End If
                MsgBox("O Pedido " & txtCodPed.Text & " foi salvo com sucesso!", 64)

                If TemImpressora = True Then
                    If ImprimirDireto = False Then
                        If MsgBox("Deseja imprimir o pedido?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            Imprimir()
                        End If
                    Else
                        Imprimir()
                    End If

                Else
                    If MsgBox("Deseja imprimir os dados do pedido?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        If ImpressaoPedidoCompleto = False Then
                            Visualizar(True, False)
                        Else
                            VisualizarCompleto(True, False)
                        End If
                    End If
                End If


            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try

        Else

            If Me.chkAlterado.Checked = True Then MsgBox("Existe um item sendo alterado, conclua a alteração antes de salvar!", MsgBoxStyle.Information) : Exit Sub


            txtCli.Focus()
            If grd2.RowCount = 0 Then MsgBox("Não existem itens no Pedido!", 64) : Exit Sub

            Dim index As Integer = -999997
            grd2.FocusedRowHandle = index
            grd2.SetRowCellValue(index, Me.colCodAtivo, "")
            grd2.SetRowCellValue(index, Me.colCodPadrao, "")
            grd2.SetRowCellValue(index, Me.colNome, "")
            grd2.SetRowCellValue(index, Me.colValor, "")
            grd2.SetRowCellValue(index, Me.colExcluir2, "")

            If Me.Tag = "CADASTRA" Then

            Else

                Dim vetDelete As Array = Split(strItensDeletado, "|")

                For I = 0 To vetDelete.Length - 1
                    If vetDelete(I) <> "" And vetDelete(I).ToString.ToUpper <> "INSERIR" Then
                        Dim strDelete As String
                        strDelete = "Delete From AtivoConsig where Codigo =" & vetDelete(I)
                        Excluir(strDelete)
                    End If

                Next
                vetDelete = Nothing
                strItensDeletado = ""
                For I = 0 To grd2.RowCount - 1
                    If Me.grd2.GetRowCellDisplayText(I, Me.colCodPadrao) <> "" Then
                        Dim strCodigo, strCodAtivo, strCodPadrao, strNomeAtivo, strValorAtivo, strVencimento, strCodigoPedido As String
                        strCodigo = grd2.GetRowCellDisplayText(I, Me.colCodigo2)
                        strCodAtivo = Me.grd2.GetRowCellDisplayText(I, Me.colCodAtivo)
                        strCodPadrao = Me.grd2.GetRowCellDisplayText(I, Me.colCodPadrao)
                        strNomeAtivo = Me.grd2.GetRowCellDisplayText(I, Me.colNome).Replace("'", "")
                        strValorAtivo = Me.grd2.GetRowCellDisplayText(I, Me.colValor)

                        strVencimento = Me.grd2.GetRowCellDisplayText(I, Me.colVencimentoAtivo)
                        If strVencimento = "" Then
                            strVencimento = "01/01/0001"
                        End If
                        strCodigoPedido = Me.grd2.GetRowCellDisplayText(I, Me.colCodigoPedidoAtivo)

                        If strCodigo = "" Then
                            grd2.SetRowCellValue(I, Me.colCodigo2, "OK")

                            Inserir("Insert into AtivoConsig (CodOrdens, CodAtivo, CodPadrao, Nome, Valor, CodConfig, Vencimento, " & _
                            "CodPedAut, Status) Values(" & Me.txtCodPed.Text.Trim & "," & strCodAtivo & ",'" & strCodPadrao & "'," & _
                            "'" & strNomeAtivo & "'," & Num(strValorAtivo) & "," & CodConfig & ",'" & strVencimento & "'," & _
                            "" & strCodigoPedido & ",'Entregue')")
                        Else
                            If strCodigo <> "OK" Then
                                Atualizar("Update AtivoConsig set CodAtivo = " & strCodAtivo & ", CodPadrao = '" & strCodPadrao & "', " & _
                                "Nome = '" & strNomeAtivo & "', Valor =" & Num(strValorAtivo) & ", Vencimento = '" & strVencimento & "', " & _
                                "CodPedAut = " & strCodigoPedido & " where Codigo = " & strCodigo.Trim & " and CodConfig = " & CodConfig)
                            End If

                        End If
                    End If

                Next

            End If

            Try

                bolSalvar = True


                MsgBox("O Pedido " & txtCodPed.Text & " foi salvo com sucesso!", 64)

                'If TemImpressora = True Then
                '    Imprimir()
                'Else
                '    If MsgBox("Deseja imprimir os dados do pedido?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                '        Visualizar()
                '    End If
                'End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If


        Limpar(True)
        Me.Timer1.Start()
    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        If TesteConexao() = False Then Exit Sub
        Salvar(False)
    End Sub

    Private Sub txtCodPed_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPed.Leave
        CarregaForm()
        CarregaForm()

    End Sub

    Private Sub CarregaForm()
        If bolJaPassou = True Then bolJaPassou = False : Exit Sub

        If txtCodPed.Text.Trim = "" Then Exit Sub
        Limpar(False)
        strItensDeletado = ""
        Dim dt As DataTable = CarregarDataTable("Select Data, CodFor, Total, Descricao, Desconto, Status, Custo, " & _
        "Entrega, CodFunc, Funcionario.Nome, Acrescimo, convert(Varchar(10), DataRetirada, 103) as DataRetirada, " & _
        "Convert(varchar(10),DataEntrega,103) as DataEntrega from TotalPedCompra inner join " & _
        "Funcionario on TotalPedCompra.CodFunc = Funcionario.Codigo where TotalPedCompra.CodOrdens = " & Me.txtCodPed.Text.Trim & " and TotalPedCompra.CodConfig =" & CodConfig)

        If dt.Rows.Count = 0 Then MsgBox("Pedido não Cadastrado!", MsgBoxStyle.Information) : Me.txtCodPed.ResetText() : Me.txtCodPed.Focus() : Exit Sub

        If Me.Tag = "ALTERA" Then
            If dt.Rows.Item(0).Item("Status").ToString = "Faturado" Then MsgBox("Pedido já faturado, não é possivel alterá-lo!", MsgBoxStyle.Exclamation) : txtCodPed.Focus() : Exit Sub
        End If

        If dt.Rows.Item(0).Item("Status").ToString = "Excluído" Then
            MsgBox("Esse pedido foi excluído!", MsgBoxStyle.Exclamation) : txtCodPed.Focus() : Exit Sub
        End If


        Me.cboStatus.Text = dt.Rows.Item(0).Item("Status").ToString

        'CARREGA OS DADOS DO FORNECEDOR
        CarregarFornecedor(dt.Rows.Item(0).Item("CodFor").ToString)


        dtData.EditValue = Format(dt.Rows.Item(0).Item(0), "dd/MM/yyyy")
        intCodFunc = dt.Rows.Item(0).Item("CodFunc").ToString

        Try
            Me.lueFunc.Text = dt.Rows.Item(0).Item("Nome").ToString
            Me.lueFunc.ClosePopup()
        Catch ex As Exception

        End Try


        Me.txtTotal.Text = Format(dt.Rows.Item(0).Item("Total"), "0.00")
        Me.txtDesc.Text = dt.Rows.Item(0).Item("Descricao").ToString

        Dim vetDesconto As Array = Split(dt.Rows.Item(0).Item("Desconto").ToString, "|")
        Me.txtValDesc.Text = vetDesconto(0).ToString.Trim
        If vetDesconto.Length > 1 Then
            Me.txtDesconto.Text = vetDesconto(1).ToString.Trim
        End If


        Me.dtRetirada.Text = dt.Rows.Item(0).Item("DataRetirada").ToString
        Me.dtEntrega.Text = dt.Rows.Item(0).Item("DataEntrega").ToString

        If dt.Rows.Item(0).Item("Custo").ToString <> "" Then
            dblTotalDeCusto = dt.Rows.Item(0).Item("Custo").ToString
        End If
        Me.txtEntrega.Text = dt.Rows.Item(0).Item("Entrega").ToString
        'CARREGAR DADOS DE PEDIDO
        Dim dtPed As DataTable = CarregarDataTable("Select PedCompra.Codigo, PedCompra.CodOrdens, PedCompra.Qtd, " & _
        "PedCompra.CodigoProduto, PedCompra.Produto, PedCompra.ValorUnitario, PedCompra.ValorTotal, PedCompra.CodigoInterno, " & _
        "PedCompra.Custo, PedCompra.UM, PedCompra.Tamanho, PedCompra.UniSemDesc, PedCompra.Promocao, PedCompra.Desconto, " & _
        "PedCompra.MedidaA, PedCompra.MedidaB, PedCompra.QtdMedida, Produto.CodProdFor from PedCompra left join Produto " & _
        "on PedCompra.CodigoProduto = Produto.Codigo where PedCompra.CodOrdens = " & Me.txtCodPed.Text.Trim & " and PedCompra.CodConfig =" & CodConfig)

        Me.tbItens.Rows.Clear()
        Dim dblTotalSDesc As Double
        Dim dblTotalCDesc As Double
        Dim dblQtd As Double
        Dim dblItens As Double = 0
        For I = 0 To dtPed.Rows.Count - 1
            With Me.tbItens.Rows
                .Add()
                .Item(I).Item("CodPedAut") = dtPed.Rows.Item(I).Item(0).ToString
                .Item(I).Item("Qtd") = dtPed.Rows.Item(I).Item("Qtd").ToString
                dblQtd = dtPed.Rows.Item(I).Item("Qtd").ToString
                dblItens += dblQtd
                .Item(I).Item("CodigoProduto") = dtPed.Rows.Item(I).Item("CodigoProduto").ToString
                .Item(I).Item("Produto") = dtPed.Rows.Item(I).Item("Produto").ToString
                .Item(I).Item("ValorUnitario") = CampoValor(dtPed.Rows.Item(I).Item("ValorUnitario"))
                .Item(I).Item("ValorTotal") = Format(dtPed.Rows.Item(I).Item("ValorTotal"), "0.00")
                .Item(I).Item("CodigoInterno") = dtPed.Rows.Item(I).Item("CodigoInterno").ToString
                .Item(I).Item("Tamanho") = dtPed.Rows.Item(I).Item("Tamanho").ToString
                .Item(I).Item("MedidaA") = dtPed.Rows.Item(I).Item("MedidaA")
                .Item(I).Item("MedidaB") = dtPed.Rows.Item(I).Item("MedidaB")
                .Item(I).Item("QtdMedida") = dtPed.Rows.Item(I).Item("QtdMedida")

                .Item(I).Item("CodProdFor") = dtPed.Rows.Item(I).Item("CodProdFor")


                Dim dblCusto As Double = 0
                If dtPed.Rows.Item(I).Item("Custo").ToString <> "" Then
                    .Item(I).Item("Custo") = dtPed.Rows.Item(I).Item("Custo").ToString
                    dblCusto = dtPed.Rows.Item(I).Item("Custo").ToString
                Else
                    .Item(I).Item("Custo") = "0,00"
                End If

                .Item(I).Item("UM") = dtPed.Rows.Item(I).Item("UM").ToString

                .Item(I).Item("Excluir") = False
                If dtPed.Rows.Item(I).Item("UniSemDesc").ToString <> "" Then
                    .Item(I).Item("UniSemDesc") = CampoValor(dtPed.Rows.Item(I).Item("UniSemDesc").ToString)
                    dblTotalSDesc += dblQtd * CDbl(dtPed.Rows.Item(I).Item("UniSemDesc").ToString)
                Else
                    .Item(I).Item("UniSemDesc") = CampoValor(dtPed.Rows.Item(I).Item("ValorUnitario"))
                    dblTotalSDesc += dblQtd * CDbl(dtPed.Rows.Item(I).Item("ValorUnitario"))
                End If
                Dim dblResul As Double = dtPed.Rows.Item(I).Item("ValorTotal")
                dblTotalCDesc += Format(dtPed.Rows.Item(I).Item("ValorTotal"), "0.00")
                .Item(I).Item("Promocao") = dtPed.Rows.Item(I).Item("Promocao").ToString
                .Item(I).Item("Desconto") = dtPed.Rows.Item(I).Item("Desconto").ToString

                Dim dblLucro As Double = dblResul - dblCusto
                dblLucro = (dblLucro * 100) / dblCusto
                Dim str As String = dblLucro
                If str = "+Infinito" Or str = "NaN (Não é um número)" Then
                    dblLucro = 0
                End If
                .Item(I).Item("Lucro") = dblLucro.ToString("0.00")


            End With
        Next

        dblTotalComDesconto = dblTotalCDesc.ToString("0.00")

        dblTotalSemDesconto = dblTotalSDesc.ToString("0.00")
        Me.picFundo.Visible = False

        Me.txtTotItem.Text = dblItens

        If Me.txtValDesc.Text = "" Or Me.txtValDesc.Text = "0,00" Or Me.txtValDesc.Text = "0,000" Then
            Dim vetAcrescimo As Array = Split(dt.Rows.Item(0).Item("Acrescimo").ToString, "|")
            Me.txtValDesc.Text = vetAcrescimo(0).ToString.Trim
            If Me.txtValDesc.Text <> "" Then
                Dim dblAcres As Double = Me.txtValDesc.Text
                If dblAcres > 0 Then
                    Me.rdgDesc.SelectedIndex = 1
                End If
                Me.txtValDesc.Text = vetAcrescimo(0).ToString.Trim
                Me.txtValDesc.Text = vetAcrescimo(0).ToString.Trim
                If vetDesconto.Length > 1 Then
                    Me.txtDesconto.Text = vetAcrescimo(1).ToString.Trim
                End If
                If dblAcres > 0 Then
                    DescontoComValor(True)
                End If
            End If


        End If



        If Me.Tag = "ATIVO" Then
            'CARREGAR DADOS DE PEDIDO
            Dim dtAtivo As DataTable = CarregarDataTable("Select Codigo, CodAtivo, CodPadrao, Nome, Valor, " & _
            "convert(varchar(10),Vencimento,103) as Vencimento, CodPedAut from AtivoConsig where " & _
            "CodOrdens =" & Me.txtCodPed.Text.Trim & " and CodConfig =" & CodConfig)

            Me.tbAtivo.Rows.Clear()
            For I = 0 To dtAtivo.Rows.Count - 1
                With Me.tbAtivo.Rows
                    .Add()
                    .Item(I).Item("Codigo") = dtAtivo.Rows.Item(I).Item("Codigo").ToString
                    .Item(I).Item("CodAtivo") = dtAtivo.Rows.Item(I).Item("CodAtivo").ToString
                    .Item(I).Item("CodPadrao") = dtAtivo.Rows.Item(I).Item("CodPadrao").ToString
                    .Item(I).Item("Nome") = dtAtivo.Rows.Item(I).Item("Nome").ToString
                    .Item(I).Item("Valor") = Format(dtAtivo.Rows.Item(I).Item("Valor"), "0.00")
                    .Item(I).Item("Excluir") = False

                    Dim strVencimento As String = dtAtivo.Rows.Item(I).Item("Vencimento").ToString
                    If strVencimento = "01/01/0001" Then
                        strVencimento = ""
                    End If
                    .Item(I).Item("Vencimento") = strVencimento
                    .Item(I).Item("CodPedAut") = dtAtivo.Rows.Item(I).Item("CodPedAut").ToString

                    .Item(I).Item("Produto") = ""
                End With
            Next
            If dt.Rows.Item(0).Item("Status").ToString = "Faturado" Then
                Me.GroupControl2.Enabled = False
                Me.GroupControl3.Enabled = False
            End If

            AdicionarAmbos()
            CalcularAmbos()

            Me.grd2.ExpandAllGroups()

        End If

        Dim intCodPedido As Integer = Me.txtCodPed.Text.Trim

        If Me.Tag = "FATURA" Then
            bolJaPassou = True
            Me.txtRec.Focus()
        ElseIf Me.Tag = "ALTERA" Then
            bolJaPassou = True
            Me.txtCodPro.Focus()
        End If
    End Sub

    Private Sub btnCancelar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Me.chkAlterado.Checked = True Then MsgBox("Existe um item sendo alterado, conclua a alteração antes de excluir algum item!", MsgBoxStyle.Information) : Exit Sub
        If grd1.RowCount = 0 Then Exit Sub

        Dim I As Integer
        Dim bolExcluirVarios As Boolean = False
        For I = 0 To Me.grd1.RowCount - 1
            If I <= Me.grd1.RowCount - 1 Then
                If Me.grd1.GetRowCellValue(I, Me.colExcluir) = True Then
                    If bolExcluirVarios = False Then
                        If MsgBox("Deseja realmente excluir estes items?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            bolExcluirVarios = True
                            strItensDeletado &= grd1.GetRowCellDisplayText(I, Me.colCodPedAut) & "|"
                            Me.grd1.DeleteRow(I)
                            I = I - 1
                        Else
                            Exit Sub
                        End If

                    Else
                        strItensDeletado &= grd1.GetRowCellDisplayText(I, Me.colCodPedAut) & "|"
                        Me.grd1.DeleteRow(I)
                        I = I - 1
                    End If
                End If
            End If

        Next


        If bolExcluirVarios = False Then
            If MsgBox("Deseja realmente excluir este item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                strItensDeletado &= grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodPedAut) & "|"
                Me.grd1.DeleteRow(grd1.FocusedRowHandle)

            End If
        End If

        If Me.grd1.RowCount = 0 Then
            Me.picFundo.Visible = True
        End If
        Calcular()
    End Sub

    Private Sub txtQtd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "," And e.KeyChar <> "." Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtQtd_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        If txtQtd.Text.Trim = "" Then Exit Sub
        If txtQtd.ToolTipTitle = "HORA" Then
            Exit Sub
        End If
        Dim dblVal As Double
        Try
            dblVal = txtQtd.Text.Trim
        Catch ex As Exception
            MsgBox("Caracter digitado não é permitido para este campo!", MsgBoxStyle.Exclamation)
            txtQtd.ResetText()
            txtQtd.Focus()
        End Try

        txtQtd.Text = dblVal.ToString("0.000")

    End Sub

    Private Sub txtCodPed_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodPed.EditValueChanged
        If txtCodPed.Text = "" Then Limpar(False)
    End Sub

    Private Sub Imprimir()

        If Impressora.Contains("ESC/POS") = True Then
            If intCodFor = 0 Then Exit Sub
            clsImprimir.ImprimePedidoCompra(Me.txtCodPed.Text.Trim, intCodFor, Me.dtData.Text, Me.lueFunc.Text.Trim, Me.txtDesc.Text)
            Exit Sub
        End If

        If Impressora = "DARUMA" Then
            Dim strImpressao As String

            strImpressao = "<tc>#</tc>" & vbCrLf

            strImpressao &= "<b><ce>" & NomeEmpresa.ToString.Trim & "</ce></b>" & vbCrLf

            strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf

            strImpressao &= "<ce>" & TelefoneEmpresa & "</ce>" & vbCrLf
            strImpressao &= "<tc>#</tc>" & vbCrLf
            strImpressao &= "<ad><dt></dt></ad>" & vbCrLf
            strImpressao &= "<e><ce> Pedido Compra Nº " & Me.txtCodPed.Text.Trim & "</ce></e>" & vbCrLf
            strImpressao &= " CÓDIGO    DESCRIÇÃO                    " & vbCrLf
            strImpressao &= "<ad>UN.   TAM.   QTD.   VL UNIT R$        VL Total R$</ad>" & vbCrLf
            strImpressao &= "<tc>-</tc>" & vbCrLf

            Dim L As Integer
            Dim dblQtd As Double
            For L = 0 To Me.grd1.RowCount - 1
                Dim strCod, strProd, strUni, strQtd, strTot, strUM, strTam As String

                strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoPeca)
                strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
                strUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
                strQtd = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
                strTot = Me.grd1.GetRowCellDisplayText(L, Me.colValorTotal)
                strUM = Me.grd1.GetRowCellDisplayText(L, Me.colUM)
                dblQtd += Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
                strTam = Me.grd1.GetRowCellDisplayText(L, Me.colTamanho)
                strImpressao &= "<c><i>  " & strCod & "   " & strProd & "</i></c>" & vbCrLf
                Dim str As String
                str = " " & strUM & "   " & strTam & "   " & Dir(strQtd & " X " & strUni, 21) & Esq(strTot, 20)
                strImpressao &= str & vbCrLf
            Next


            strImpressao &= "<tc>-</tc>" & vbCrLf
            strImpressao &= "<ad><b>" & "N de Itens " & Esq(dblQtd, 9) & "</b></ad>" & vbCrLf
            strImpressao &= "<ad><b>" & "Total R$ " & Esq(Me.txtTotal.Text.Trim, 9) & "</b></ad>" & vbCrLf

            strImpressao &= "<l></l>" & vbCrLf

            strImpressao &= "<tc>-</tc>" & vbCrLf

            If GerarComissao = True Then
                strImpressao &= "<c>" & "Vend.: " & Me.lueFunc.Text & "</c>" & vbCrLf
            End If

            Dim dt As DataTable

            dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Fornecedor where Codigo =" & intCodFor)

            If dt.Rows.Count > 0 Then
                If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                    strImpressao &= "<c>" & dt.Rows.Item(0).Item("Nome").ToString & "</c>" & vbCrLf
                End If

                If dt.Rows.Item(0).Item("Endereco").ToString <> "" Then
                    strImpressao &= "<c>" & dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & " " & dt.Rows.Item(0).Item("Complemento").ToString & "</c>" & vbCrLf
                End If

                If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                    strImpressao &= "<c>" & dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & "</c>" & vbCrLf
                End If

                If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                    strImpressao &= "<c>" & dt.Rows.Item(0).Item("Telefone").ToString & "</c>" & vbCrLf
                End If
                strImpressao &= "<tc>-</tc>" & vbCrLf
            End If

            strImpressao &= "<ce>DOCUMENTO NÃO FISCAL" & "</ce>" & vbCrLf

            strImpressao &= "<l></l>" & vbCrLf
            strImpressao &= "<l></l>" & vbCrLf
            strImpressao &= "<l></l>" & vbCrLf

            If TemGuilhotina = True Then
                strImpressao &= "<gui></gui>" & vbCrLf
            End If

            If ImpressoraOK() = True Then
                iRetorno = (iImprimirTexto_DUAL_DarumaFramework(strImpressao, 0))

                If MsgBox("Deseja imprimir a segunda via?", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    iRetorno = (iImprimirTexto_DUAL_DarumaFramework(strImpressao, 0))
                End If

            End If
        ElseIf Impressora.Contains("BEMATECH") Or Impressora.Contains("ARQUIVO") Or Impressora.Contains("NANO PRINT") Then

            Dim strImpressao As String
            If Impressora.Contains("MP-4000") Then
                iRetorno = ConfiguraModeloImpressora(5)
                iRetorno = SelecionaQualidadeImpressao(3)
            Else
                If Impressora.Contains("BEMATECH") = True Then
                    iRetorno = ConfiguraModeloImpressora(1)
                Else
                    Try
                        iRetorno = ConfiguraModeloImpressora(1)
                    Catch ex As Exception

                    End Try
                End If
             

            End If
            If Impressora.Contains("BEMATECH") = True Then
                iRetorno = clsBematech.IniciaPorta(PortaImpressora)

            Else
                Try
                    iRetorno = clsBematech.IniciaPorta(PortaImpressora)

                Catch ex As Exception

                End Try
            End If
           

            Dim intTamEsp, intEsp1, intEsp2 As Integer
            Dim strEstrela, strTraço As String

            If Impressora.Contains("ARQUIVO") = True Then
                intTamEsp = 42
                strEstrela = "******************************************"
                strTraço = "------------------------------------------"
            Else
                intTamEsp = 60
                strEstrela = "************************************************************"
                strTraço = "------------------------------------------------------------"
            End If

            strImpressao = strEstrela & vbCrLf

            strImpressao &= Cent(NomeEmpresa.ToString.Trim, intTamEsp) & vbCrLf
            strImpressao &= Cent(EnderecoEmpresa.Trim, intTamEsp) & vbCrLf
            strImpressao &= Cent(TelefoneEmpresa, intTamEsp) & vbCrLf

            strImpressao &= strEstrela & vbCrLf
            strImpressao &= Esq(My.Computer.Clock.LocalTime, intTamEsp) & vbCrLf
            strImpressao &= Dir("PEDIDO COMPRA N - " & Me.txtCodPed.Text.Trim, intTamEsp) & vbCrLf
            strImpressao &= "CÓDIGO    DESCRIÇÃO                    " & vbCrLf
            If Impressora.Contains("ARQUIVO") = True Then
                strImpressao &= Dir("UN.   QTD.     VL UNIT R$", 31) & Esq("VL Total R$", 11) & vbCrLf
            Else
                strImpressao &= Dir("UN.   QTD.     VL UNIT R$", 49) & Esq("VL Total R$", 11) & vbCrLf
            End If

            strImpressao &= strTraço & vbCrLf

            If Impressora.Contains("ARQUIVO") = True Then
                intEsp1 = 32
                intEsp2 = 10
            Else
                intEsp1 = 40
                intEsp2 = 20
            End If

            Dim L As Integer
            Dim dblQtd As Double
            For L = 0 To Me.grd1.RowCount - 1
                Dim strCod, strProd, strUni, strQtd, strTot, strUM As String

                strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoPeca)
                strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
                strUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
                strQtd = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
                strTot = Me.grd1.GetRowCellDisplayText(L, Me.colValorTotal)
                strUM = Me.grd1.GetRowCellDisplayText(L, Me.colUM)
                dblQtd += Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
                strImpressao &= strCod & "   " & strProd & vbCrLf
                Dim str As String
                str = Dir(strUM & "    " & strQtd & "  X  " & strUni, intEsp1) & Esq(strTot, intEsp2)


                strImpressao &= str & vbCrLf
            Next


            strImpressao &= strTraço & vbCrLf
            strImpressao &= Esq("N de Itens......: ", intEsp1) & Esq(dblQtd, intEsp2) & vbCrLf
            strImpressao &= Esq("Total........: R$ ", intEsp1) & Esq(Me.txtTotal.Text.Trim, intEsp2) & vbCrLf

            strImpressao &= " " & vbCrLf

            strImpressao &= strTraço & vbCrLf

            If GerarComissao = True Then
                strImpressao &= "Vend.: " & Me.lueFunc.Text.Trim & vbCrLf
            End If

            Dim dt As DataTable

            dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Fornecedor where Codigo =" & intCodFor)

            If dt.Rows.Count > 0 Then
                If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                    strImpressao &= dt.Rows.Item(0).Item("Nome").ToString & vbCrLf
                End If

                If dt.Rows.Item(0).Item("Endereco").ToString <> "" Then
                    strImpressao &= dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & " " & dt.Rows.Item(0).Item("Complemento").ToString & vbCrLf
                End If

                If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                    strImpressao &= dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & vbCrLf
                End If

                If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                    strImpressao &= dt.Rows.Item(0).Item("Telefone").ToString & vbCrLf
                End If

            End If

            strImpressao &= " " & vbCrLf

            strImpressao &= Cent("DOCUMENTO NÃO FISCAL", intTamEsp) & vbCrLf

            strImpressao &= strTraço & vbCrLf
            strImpressao &= Cent(NomeEmpresa.ToString.Trim, intTamEsp) & vbCrLf

            strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")


            If Impressora = "ARQUIVO" Then
                ImprimiArquivo(strImpressao, PortaImpressora)
            ElseIf Impressora.Contains("NANO PRINT") = True Then
                If Impressora = "NANO PRINT ARQUIVO DIRETO" Then
                    ImprimeArquivo(My.Application.Info.DirectoryPath & "\Cupom.txt", strImpressao)
                Else
                    EscreveArquivo(PortaImpressora & "\Cupom.txt", strImpressao)
                End If

            Else
                iRetorno = clsBematech.FormataTX(strImpressao, 1, 0, 0, 0, 1)

                If TemGuilhotina = True Then
                    iRetorno = clsBematech.AcionaGuilhotina(0)
                End If
            End If
            If Impressora.Contains("BEMATECH") = True Then
                iRetorno = clsBematech.FechaPorta()
            Else
                Try
                    iRetorno = clsBematech.FechaPorta()
                Catch ex As Exception

                End Try
            End If

            SegundaVia(strImpressao)


        ElseIf Impressora = "EPSON" Then

            Dim strImpressao As String

            Dim strEstrela, strTraço As String

            strEstrela = clsImprimir.Comp("************************************************")
            strTraço = clsImprimir.Comp("------------------------------------------------")

            strImpressao = strEstrela & vbCrLf

            strImpressao &= "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf
            strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf
            strImpressao &= "<ce>" & TelefoneEmpresa & "</ce>" & vbCrLf

            strImpressao &= strEstrela & vbCrLf
            strImpressao &= Esq(My.Computer.Clock.LocalTime, 48) & vbCrLf
            strImpressao &= Dir("PEDIDO COMPRA N - " & Me.txtCodPed.Text.Trim, 48) & vbCrLf
            strImpressao &= "CÓDIGO    DESCRIÇÃO                    " & vbCrLf
            strImpressao &= Dir("UN.   QTD.     VL UNIT R$", 37) & Esq("VL Total R$", 11) & vbCrLf

            strImpressao &= strTraço & vbCrLf

            Dim L As Integer
            Dim dblQtd As Double
            For L = 0 To Me.grd1.RowCount - 1
                Dim strCod, strProd, strUni, strQtd, strTot, strUM As String

                strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoPeca)
                strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
                strUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
                strQtd = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
                strTot = Me.grd1.GetRowCellDisplayText(L, Me.colValorTotal)
                strUM = Me.grd1.GetRowCellDisplayText(L, Me.colUM)
                dblQtd += Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
                strImpressao &= strCod & "   " & strProd & vbCrLf
                Dim str As String
                str = Dir(strUM & "    " & strQtd & "  X  " & strUni, 37) & Esq(strTot, 11)


                strImpressao &= str & vbCrLf
            Next


            strImpressao &= strTraço & vbCrLf
            strImpressao &= Esq("N de Itens...:    ", 37) & Esq(dblQtd, 11) & vbCrLf
            strImpressao &= Esq("Total........: R$ ", 37) & Esq(Me.txtTotal.Text.Trim, 11) & vbCrLf

            strImpressao &= " " & vbCrLf

            strImpressao &= strTraço & vbCrLf

            If GerarComissao = True Then
                strImpressao &= "Vend.: " & Me.lueFunc.Text.Trim & vbCrLf
            End If

            Dim dt As DataTable

            dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Fornecedor where Codigo =" & intCodFor)

            If dt.Rows.Count > 0 Then
                If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                    strImpressao &= dt.Rows.Item(0).Item("Nome").ToString & vbCrLf
                End If

                If dt.Rows.Item(0).Item("Endereco").ToString <> "" Then
                    strImpressao &= dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & " " & dt.Rows.Item(0).Item("Complemento").ToString & vbCrLf
                End If

                If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                    strImpressao &= dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & vbCrLf
                End If

                If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                    strImpressao &= dt.Rows.Item(0).Item("Telefone").ToString & vbCrLf
                End If

            End If

            strImpressao &= " " & vbCrLf

            strImpressao &= "<ce>" & "DOCUMENTO NÃO FISCAL" & "</ce>" & vbCrLf

            strImpressao &= strTraço & vbCrLf
            strImpressao &= "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf

            strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")


            iRetorno = clsEpson.IniciaPorta(PortaImpressora)

            iRetorno = clsEpson.ImprimeTextoTag(strImpressao)

            If TemGuilhotina = True Then
                iRetorno = clsEpson.AcionaGuilhotina(1)
            End If

            iRetorno = clsEpson.FechaPorta()

            If SegViaRecibo = True Then
                If MsgBox("Deseja imprimir a segunda via?", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    iRetorno = clsEpson.IniciaPorta(PortaImpressora)

                    iRetorno = clsEpson.ImprimeTextoTag(strImpressao)

                    If TemGuilhotina = True Then
                        iRetorno = clsEpson.AcionaGuilhotina(1)
                    End If

                    iRetorno = clsEpson.FechaPorta()
                End If
            End If

        ElseIf Impressora.Contains("MATRICIAL") Then

            Dim intTamEsp As Integer
            Dim strEstrela, strTraço As String

            intTamEsp = 42
            strEstrela = "******************************************"
            strTraço = ".........................................."

            'iRetorno = IniciaPorta(PortaImpressora)

            Dim strTracoMenor As String = "...................................."


            Dim strFunc As String = Me.lueFunc.Text


            Dim strDt As String = Me.dtData.Text
            strDt = strDt.Substring(0, 10)
            Dim strHora As String = My.Computer.Clock.LocalTime

            If strHora.Length = 19 Then
                strHora = strHora.Substring(10, 9)
            End If


            'Dim dtClient As DataTable = CarregarDataTable("select nome,numero, fantasia, endereco, cidade, telefone, bairro from cliente left join total on cliente.codigo = total.codcli where total.codordem =" & intCodCli)
            'Dim strNome, strFant, strEnd, strCid, strTel, strBairro, strNum As String
            'strNome = dtClient.Rows(0).Item("nome").ToString
            'strFant = dtClient.Rows(0).Item("fantasia").ToString
            'strEnd = dtClient.Rows(0).Item("endereco").ToString
            'strCid = dtClient.Rows(0).Item("cidade").ToString
            'strTel = dtClient.Rows(0).Item("telefone").ToString
            'strBairro = dtClient.Rows(0).Item("bairro").ToString
            'strNum = dtClient.Rows(0).Item("numero").ToString


            Dim dtClient As DataTable = CarregarDataTable("select nome,numero, fantasia, endereco, cidade, telefone, bairro from Fornecedor where Codigo =" & intCodFor)
            Dim strNome, strFant, strEnd, strCid, strTel, strBairro, strNum As String
            If dtClient.Rows.Count > 0 Then

                strNome = dtClient.Rows(0).Item("nome").ToString
                strFant = dtClient.Rows(0).Item("fantasia").ToString
                strEnd = dtClient.Rows(0).Item("endereco").ToString
                strCid = dtClient.Rows(0).Item("cidade").ToString
                strTel = dtClient.Rows(0).Item("telefone").ToString
                strBairro = dtClient.Rows(0).Item("bairro").ToString
                strNum = dtClient.Rows(0).Item("numero").ToString

            End If


            Dim strImpressao As String = Cent(NomeEmpresa.ToString.Trim, 127) & vbCrLf
            strImpressao &= Cent(TelefoneEmpresa.Trim & " " & EnderecoEmpresa.Trim, 127) & vbCrLf
            strImpressao &= strTraço & strTraço & strTracoMenor & "......." & vbCrLf

            strImpressao &= DirCorte("VENDEDOR: " & strFunc, 40) & DirCorte("DATA: " & strDt & " COD.PEDIDO: " & Me.txtCodPed.Text, 49) & Dir("HORA: " & strHora, 11) & vbCrLf
            strImpressao &= DirCorte("CLIENTE: " & strNome, 64) & DirCorte("NOME FANTASIA: " & strFant, 64) & vbCrLf
            strImpressao &= DirCorte("ENDEREÇO: " & strEnd & " " & strNum, 50) & DirCorte("CIDADE: " & strCid, 32) & DirCorte("TEL: " & strTel, 15) & DirCorte("BAIRRO: " & strBairro, 31) & vbCrLf
            strImpressao &= DirCorte("SEGUNDA VIA IMPRESSA ." & strTraço & strTracoMenor & strTracoMenor, 127) & vbCrLf
            If NomeEmpresa.Contains("SKINA") Then
                strImpressao &= "Qtd  Descricao                                   Marca       Cod.Interno   Aplicacao                 Valor Unit.     Sub.Total" & vbCrLf
            Else
                strImpressao &= "Codigo       Descricao                                                                Qtde.         Valor Unit.       Sub.Total" & vbCrLf
            End If

            strImpressao &= "..............................................................................................................................." & vbCrLf
            Dim dblUni, dblQt As Double
            Dim dblTot As Double = 0.0
            Dim dblLiq As Double = 0.0
            Dim L As Integer
            If Me.grd1.RowCount < 13 Then
                For L = 0 To 12
                    If Me.grd1.RowCount - 1 >= L Then
                        Dim strCod, strProd, strUM, strFab, strObs, strCodProd As String
                        strCodProd = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoProduto)


                        strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoPeca)
                        strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
                        dblUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
                        dblQt = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
                        dblTot = Me.grd1.GetRowCellDisplayText(L, Me.colValorTotal)
                        strUM = Me.grd1.GetRowCellDisplayText(L, Me.colUM)
                        Dim dtProd As DataTable = CarregarDataTable("SELECT Setor, Obs FROM Produto where Codigo = " & strCodProd)

                        If dtProd.Rows.Count > 0 Then
                            strFab = dtProd.Rows.Item(0).Item("Setor").ToString
                            strObs = dtProd.Rows.Item(0).Item("Obs").ToString
                        End If

                        If strUM.Trim = "" Then
                            strUM = "UN"
                        End If

                        dblLiq = dblLiq + dblTot

                        If NomeEmpresa.Contains("SKINA") Then
                            strImpressao &= DirCorte(dblQt.ToString("N2"), 4) & DirCorte("  " & strProd, 44) & DirCorte("  " & strFab, 11) & DirCorte("   " & strCod, 13) & DirCorte("    " & strObs, 27) & Esq("     " & dblUni.ToString("C2"), 14) & Esq("      " & dblTot.ToString("C2"), 14) & vbCrLf
                        Else
                            strImpressao &= DirCorte(strCod, 11) & DirCorte("  " & strProd, 72) & Esq((dblQt.ToString("N3")), 12) & Esq(dblUni.ToString("C2"), 16) & Esq(dblTot.ToString("C2"), 16) & vbCrLf
                        End If

                    Else
                        strImpressao &= "." & vbCrLf
                    End If
                Next

            Else
                For L = 0 To Me.grd1.RowCount - 1
                    Dim strCod, strProd, strUM, strFab, strObs, strCodProd As String
                    strCodProd = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoProduto)


                    strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoPeca)
                    strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
                    dblUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
                    dblQt = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
                    dblTot = Me.grd1.GetRowCellDisplayText(L, Me.colValorTotal)
                    strUM = Me.grd1.GetRowCellDisplayText(L, Me.colUM)
                    Dim dtProd As DataTable = CarregarDataTable("SELECT Setor, Obs FROM Produto where Codigo = " & strCodProd)

                    If dtProd.Rows.Count > 0 Then
                        strFab = dtProd.Rows.Item(0).Item("Setor").ToString
                        strObs = dtProd.Rows.Item(0).Item("Obs").ToString
                    End If

                    If strUM.Trim = "" Then
                        strUM = "UN"
                    End If

                    dblLiq = dblLiq + dblTot

                    strImpressao &= DirCorte(dblQt.ToString("N2"), 4) & DirCorte("  " & strProd, 30) & DirCorte("  " & strFab, 11) & DirCorte("   " & strCod, 13) & DirCorte("    " & strObs, 27) & Esq("     " & dblUni.ToString("C2"), 14) & Esq("      " & dblTot.ToString("C2"), 14) & vbCrLf
                Next
            End If



            strImpressao &= vbCrLf & vbCrLf & vbCrLf & vbCrLf & Esq("TOTAL: " & dblLiq.ToString("C2"), 127) & vbCrLf
            strImpressao &= vbCrLf & vbCrLf & "ASS:_______________________________________________________ Veiculo: __________________________________________________________" & vbCrLf
            strImpressao &= Cent(ObsPedido, 128) & vbCrLf

            strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A")
            strImpressao = strImpressao.Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E")
            strImpressao = strImpressao.Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o")
            strImpressao = strImpressao.Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O")
            strImpressao = strImpressao.Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U")
            strImpressao = strImpressao.Replace("Ü", "U").Replace("ç", "c").Replace("Ç", "C")

            ImprimiArquivo(strImpressao, PortaImpressora)

            If SegViaRecibo = True Then
                If MsgBox("Deseja imprimir a segunda via?", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    ImprimiArquivo(strImpressao, PortaImpressora)
                End If
            End If


            'iRetorno = FechaPorta()
        End If

    End Sub

    Private Sub SegundaVia(ByVal parTexto As String)
        If MsgBox("Deseja imprimir a segunda via?", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If Impressora = "ARQUIVO" Then
                ImprimiArquivo(parTexto, PortaImpressora)
            ElseIf Impressora.Contains("NANO PRINT") = True Then
                If Impressora = "NANO PRINT ARQUIVO DIRETO" Then
                    ImprimeArquivo(My.Application.Info.DirectoryPath & "\Cupom.txt", parTexto)
                Else
                    EscreveArquivo(PortaImpressora & "\Cupom.txt", parTexto)
                End If
            Else
                iRetorno = clsBematech.IniciaPorta(PortaImpressora)
                iRetorno = clsBematech.FormataTX(parTexto, 1, 0, 0, 0, 1)
                If TemGuilhotina = True Then
                    iRetorno = clsBematech.AcionaGuilhotina(0)
                End If
                iRetorno = clsBematech.FechaPorta()
            End If
        End If


    End Sub

    Private Sub CarregarOCliente()
        dtDadosCliente = CarregarDataTable("Select Endereco, Numero, IE, Bairro, Cep, Cidade, Estado, Telefone, Fax, Celular, Email from Cliente where CPF ='" & CpfDoCliente & "'")
    End Sub

    Private Sub txtRec_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRec.Leave
        If txtRec.Text.Trim = "" Then txtTro.ResetText() : Exit Sub
        Preco(txtRec)

        Dim dblResul As Double

        dblResul = txtRec.Text - txtTotal.Text
        If dblResul > 0 Then
            txtTro.Text = dblResul.ToString("0.00")
        End If

    End Sub

    Private Sub txtTro_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTro.Leave
        Preco(txtTro)
    End Sub

    Private Sub chkAlterado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAlterado.CheckedChanged
        If Me.Tag = "ATIVO" Then
            Select Case chkAlterado.Checked
                Case True
                    Me.txtCodAtivo.BackColor = Color.Bisque
                    Me.txtNomeAtivo.BackColor = Color.Bisque
                    Me.dtVencimento.BackColor = Color.Bisque
                    Me.btnAddAtivo.Text = "Alterar"
                    Me.btnAddAtivo.Image = My.Resources.Alterar
                Case False
                    Me.txtCodAtivo.BackColor = Color.White
                    Me.txtNomeAtivo.BackColor = Color.White
                    Me.dtVencimento.BackColor = Color.White
                    Me.btnAddAtivo.Text = "Adicionar"
                    Me.btnAddAtivo.Image = My.Resources.edit_add
            End Select
        Else
            Select Case chkAlterado.Checked
                Case True
                    Me.txtTamanho.BackColor = Color.Bisque
                    Me.txtCodPro.BackColor = Color.Bisque
                    Me.txtNomePro.BackColor = Color.Bisque
                    Me.txtQtd.BackColor = Color.Bisque
                    Me.txtValor.BackColor = Color.Bisque
                    Me.txtPerDesc.BackColor = Color.Bisque

                    Me.txtQtdMedida.Properties.AppearanceReadOnly.BackColor = Color.Bisque

                    Me.txtNomePro.Properties.AppearanceReadOnly.BackColor = Color.Bisque
                    Me.txtValor.Properties.AppearanceDisabled.BackColor = Color.Bisque
                    Me.txtPerDesc.Properties.AppearanceDisabled.BackColor = Color.Bisque

                    Me.txtMedidaA.BackColor = Color.Bisque
                    Me.txtMedidaB.BackColor = Color.Bisque
                    Me.btnAdd.Text = "Alterar"
                    Me.btnAdd.Image = My.Resources.Alterar
                Case False
                    Me.txtQtdMedida.Properties.AppearanceReadOnly.BackColor = Color.White

                    Me.txtMedidaA.BackColor = Color.White
                    Me.txtMedidaB.BackColor = Color.White
                    Me.txtTamanho.BackColor = Color.White
                    Me.txtCodPro.BackColor = Color.White
                    Me.txtNomePro.BackColor = Color.White
                    Me.txtQtd.BackColor = Color.White
                    Me.txtValor.BackColor = Color.White
                    Me.txtPerDesc.BackColor = Color.White
                    Me.txtNomePro.Properties.AppearanceReadOnly.BackColor = Color.White
                    Me.txtValor.Properties.AppearanceDisabled.BackColor = Color.White
                    Me.txtPerDesc.Properties.AppearanceDisabled.BackColor = Color.White
                    Me.btnAdd.Text = "Adicionar"
                    Me.btnAdd.Image = My.Resources.edit_add
            End Select
        End If

    End Sub

    Private Sub txtDesconto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesconto.KeyPress, txtValDesc.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDesconto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesconto.Leave
        Me.txtValDesc.Text = ""
        'Calcular("PORCENTAGEM")

        'Dim dblDesc, dblResul, dblResulTotal, dblTotal As Double

        'dblTotal = Me.txtDesconto.Tag
        'If Me.txtDesconto.Text = "" Then
        '    Me.txtValDesc.Text = ""

        '    Exit Sub
        'End If

        'dblDesc = Me.txtDesconto.Text
        'Me.txtDesconto.Text = dblDesc.ToString("0.00")
        'dblResul = (dblTotal * dblDesc) / 100
        'Me.txtValDesc.Text = dblResul.ToString("0.00")
        'dblResulTotal = dblTotal - dblResul
        'Me.txtTotal.Text = dblResulTotal.ToString("0.00")

        DescontoComPorcentagem()
        If TipoDesconto = "TOTAL" Then
            DescontoComValor(False)
        End If

        Me.txtDesc.Focus()
    End Sub

    Private Sub DescontoMaior()
        If Nivel = "USUÁRIO" Then
            If DescontoMaximo <> "" Then
                If CDbl(Me.txtDesconto.Text.Trim) > CDbl(DescontoMaximo) Then
                    MsgBox("Desconto é maior do que o permitido, digite a senha de um usuário com nível de ADMINISTRADOR!", MsgBoxStyle.Information)
                    Dim frm As New frmSenhaExcluir
                    frm.Tag = "DESCONTO"
                    frm.ShowDialog()
                    If bolSenhaOK = False Then
                        Me.txtValDesc.Text = "0,00"
                        Me.txtDesconto.Text = "0,00"
                        DescontoComValor(False)
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub txtCodPro_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodPro.ButtonClick
        AbrirProdutos()
    End Sub

    Private Sub AbrirProdutos()
        RetornaProduto = ""

        Dim frm As New frmConProduto
        frm.Tag = "PEDIDO"
        CodigoDoProduto = 0
        frm.ShowDialog()
        Dim strCodProd As String = CodigoDoProduto
        Gaxeta(strCodProd)

        Dim dtProd As DataTable

        dtProd = CarregarDataTable("SELECT CodigoInterno, CodigoBarra, Nome, UnidadeMedida, ValorCusto, Desconto, Inativo, CodProdFor FROM Produto where Codigo = " & strCodProd)
        TamanhoProd(strCodProd)

        If dtProd.Rows.Count > 0 Then
            Dim bolInativo As Boolean = dtProd.Rows.Item(0).Item("Inativo")

            If bolInativo = True Then
                MsgBox("Produto inativo!", MsgBoxStyle.Information)
                strCodProdFor = ""
                bolPromocao = False
                Me.txtPerDesc.Enabled = True
                Me.txtValor.Enabled = True
                Me.txtCodPro.Tag = ""
                Me.txtCodPro.ResetText()
                Me.txtNomePro.ResetText()
                Me.txtValor.ResetText()
                txtQtd.ToolTipTitle = "QUALQUER"
                dblValorDeCusto = 0
                Me.txtCodPro.Focus()
                Me.txtTamanho.ResetText()
                Exit Sub
            End If

            Me.txtCodPro.Tag = strCodProd

            If NomeEmpresa.Replace("Ã", "A").Trim.Contains("CAVALAO") = True Then
                If dtProd.Rows.Item(0).Item("CodigoBarra").ToString <> "" Then
                    Me.txtCodPro.Text = dtProd.Rows.Item(0).Item("CodigoBarra").ToString
                Else
                    Me.txtCodPro.Text = dtProd.Rows.Item(0).Item("CodigoInterno").ToString
                End If

            Else
                Me.txtCodPro.Text = dtProd.Rows.Item(0).Item("CodigoInterno").ToString
            End If
            strCodProdFor = dtProd.Rows.Item(0).Item("CodProdFor").ToString
            Me.txtNomePro.Text = dtProd.Rows.Item(0).Item("Nome").ToString
            Me.txtValor.Text = CampoValor(dtProd.Rows.Item(0).Item("ValorCusto"))
            dblUniSemDesc = CampoValor(dtProd.Rows.Item(0).Item("ValorCusto"))
            dblUniSemDescOriginal = dblUniSemDesc
            If dtProd.Rows.Item(0).Item("Desconto").ToString <> "" And dtProd.Rows.Item(0).Item("Desconto").ToString <> "0" And dtProd.Rows.Item(0).Item("Desconto").ToString <> "0,000" And dtProd.Rows.Item(0).Item("Desconto").ToString <> "0,00" Then
                Dim dblPerDesc As Double = dtProd.Rows.Item(0).Item("Desconto").ToString
                Dim dblUni As Double = Me.txtValor.Text
                Dim dblResto As Double = (dblUni / 100) * dblPerDesc

                dblUni = dblUni - dblResto
                Me.txtValor.Text = CampoValor(dblUni)

                bolPromocao = True


                Me.txtPerDesc.Enabled = False


                Me.txtValor.Enabled = False
                Me.txtPerDesc.Text = dblPerDesc.ToString("0.00")
            Else
                bolPromocao = False
                If strDescontoCliente = "" Then
                    Me.txtPerDesc.ResetText()
                End If

                Me.txtPerDesc.Enabled = True
                Me.txtValor.Enabled = True
            End If


            txtQtd.ToolTipTitle = dtProd.Rows.Item(0).Item("UnidadeMedida").ToString
            dblValorDeCusto = dtProd.Rows.Item(0).Item("ValorCusto").ToString
            Me.txtTamanho.Text = TamanhoDoProduto

            bolDecimais = True
            bolAbriuProduto = True
            Me.txtQtd.Text = "1"


            If bolPromocao = False Then
                If Me.txtPerDesc.Text <> "" And Me.txtPerDesc.Text <> "0,00" Then
                    If Me.txtValor.Text = "" Then
                        Me.txtValor.Text = dblUniSemDesc
                    End If
                    If Me.txtValor.Text = "" Then Exit Sub

                    Dim dblUni As Double = dblUniSemDesc

                    If Me.txtPerDesc.Text.Trim <> "" And Me.txtPerDesc.Text.Trim <> "0,00" Then
                        Dim dblPerDesc As Double = Me.txtPerDesc.Text.Trim

                        Dim dblResto As Double = (dblUni / 100) * dblPerDesc

                        dblUni = dblUni - dblResto
                        Me.txtValor.Text = CampoValor(dblUni)
                        bolPromocao = True
                        If Nivel <> "USUÁRIO" Then
                            Me.txtPerDesc.Enabled = True
                        End If
                    End If

                End If
            End If




            Me.txtQtd.Focus()

        Else
            strCodProdFor = ""
            bolPromocao = False
            Me.txtPerDesc.Enabled = True
            Me.txtValor.Enabled = True
            Me.txtCodPro.Tag = ""
            Me.txtCodPro.ResetText()
            Me.txtNomePro.ResetText()
            Me.txtValor.ResetText()
            txtQtd.ToolTipTitle = "QUALQUER"
            dblValorDeCusto = 0
            Me.txtCodPro.Focus()
            Me.txtTamanho.ResetText()

        End If
    End Sub

    Private Sub RemoverProdutos()
        RetornaProduto = ""

        Dim frm As New frmConProduto
        frm.Tag = "PEDIDO"
        CodigoDoProduto = 0
        frm.ShowDialog()
        Dim strCodProd As String = CodigoDoProduto
        Dim dtProd As DataTable

        dtProd = CarregarDataTable("SELECT CodigoInterno, CodigoBarra, Nome, Valor, UnidadeMedida, ValorCusto, Desconto FROM Produto where Codigo = " & strCodProd)
        TamanhoProd(strCodProd)

        If dtProd.Rows.Count > 0 Then
            Me.txtCodPro2.Tag = strCodProd

            If NomeEmpresa.Replace("Ã", "A").Trim.Contains("CAVALAO") = True Then
                If dtProd.Rows.Item(0).Item("CodigoBarra").ToString <> "" Then
                    Me.txtCodPro2.Text = dtProd.Rows.Item(0).Item("CodigoBarra").ToString
                Else
                    Me.txtCodPro2.Text = dtProd.Rows.Item(0).Item("CodigoInterno").ToString
                End If

            Else
                Me.txtCodPro2.Text = dtProd.Rows.Item(0).Item("CodigoInterno").ToString
            End If

            Me.txtNomePro2.Text = dtProd.Rows.Item(0).Item("Nome").ToString


            txtQtd2.ToolTipTitle = dtProd.Rows.Item(0).Item("UnidadeMedida").ToString

            Me.txtTamanho2.Text = TamanhoDoProduto

            bolDecimais = True
            bolAbriuProduto = True
            Me.txtQtd2.Text = "1"
            Me.txtQtd2.Focus()

        Else

            Me.txtCodPro2.Tag = ""
            Me.txtCodPro2.ResetText()
            Me.txtNomePro2.ResetText()
            txtQtd2.ToolTipTitle = "QUALQUER"
            Me.txtCodPro2.Focus()
            Me.txtTamanho2.ResetText()
        End If
    End Sub

    Private Sub ConsultarPedido()

        ConsultaPedido = ""
        Dim frm As New frmConPed

        If Me.Tag = "CONSULTA" Then
            frm.Tag = "CONSULTACOMPRA"
        ElseIf Me.Tag = "ALTERA" Then
            frm.Tag = "ALTERACOMPRA"
        End If
        frm.ShowDialog()

        If ConsultaPedido <> "" Then
            Me.txtCodPed.Text = ConsultaPedido
            CarregaForm()
            CarregaForm()
        Else
            Me.txtCodPed.Text = ""
            Me.txtCodPed.Focus()
        End If
    End Sub

    Private Sub txtValor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor.KeyPress, txtTro.KeyPress, txtRec.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "," And e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtValor_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValor.Leave
        Preco(txtValor)
        If Me.txtValor.Text = "" Then Exit Sub
        Me.txtValDesc.ResetText()

        dblUniSemDesc = Me.txtValor.Text

        If DescontoMaximo <> "" Then
            Dim dblResult As Double

            dblResult = (dblUniSemDescOriginal / 100) * CDbl(DescontoMaximo)

            dblResult = dblUniSemDescOriginal - dblResult

            'If dblUniSemDesc < dblResult Then
            '    MsgBox("Desconto maior que o permitido!", MsgBoxStyle.Information)
            '    Me.txtValor.Text = dblUniSemDescOriginal.ToString("0.00")
            '    dblUniSemDesc = dblUniSemDescOriginal
            'End If

        End If

        If bolGaxeta = True Then
            If CDbl(Me.txtValor.Text.Trim) < ValorMinimoGaxeta Then
                Me.txtValor.Text = ValorMinimoGaxeta.ToString("0.00")
            End If
        End If


    End Sub

    Private Sub txtAlt_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlt.DoubleClick
        AlterarItens()
    End Sub

    Private Sub AlterarItens()
        If grd1.FocusedRowHandle < 0 Then Exit Sub

        If Me.Tag = "CONSULTA" Or Me.Tag = "FATURA" Then Exit Sub
        Me.chkAlterado.Checked = True
        IndexGrid = grd1.FocusedRowHandle
        Me.grd1.OptionsView.ShowAutoFilterRow = False
        Me.grd1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        With grd1


            Dim vetProduto As Array = Split(.GetRowCellDisplayText(IndexGrid, Me.colProduto), "|")

            Me.txtNomePro.Text = vetProduto(0)

            Gaxeta(.GetRowCellDisplayText(IndexGrid, Me.colCodigoProduto))
            strCodProdFor = .GetRowCellDisplayText(IndexGrid, Me.colCodProdFor)
            Me.txtMedidaA.Text = .GetRowCellDisplayText(IndexGrid, Me.colMedidaA)
            Me.txtMedidaB.Text = .GetRowCellDisplayText(IndexGrid, Me.colMedidaB)
            Me.txtQtdMedida.Text = .GetRowCellDisplayText(IndexGrid, Me.colQtdMedida)
            Me.txtCodPro.Tag = .GetRowCellDisplayText(IndexGrid, Me.colCodigoProduto)
            Me.txtCodPro.Text = .GetRowCellDisplayText(IndexGrid, Me.colCodigoPeca)
            Me.txtQtd.Text = .GetRowCellDisplayText(IndexGrid, Me.colQtd)
            Me.txtValor.Text = .GetRowCellDisplayText(IndexGrid, Me.colValorUnitario)

            If Me.txtValor.Text <> "" Then
                If Me.txtQtd.Text.Trim <> "" Then
                    If CDbl(Me.txtQtd.Text.Trim) = 1 Then
                        dblUniSemDescOriginal = Me.txtValor.Text
                    End If
                    If Me.txtQtdMedida.Visible = True Then
                        If Me.txtQtdMedida.Text.Trim <> "" Then
                            dblUniSemDescOriginal = CDbl(Me.txtValor.Text.Trim) / CDbl(Me.txtQtdMedida.Text.Trim)
                        End If
                    End If
                End If
            End If


            Me.txtTamanho.Text = .GetRowCellDisplayText(IndexGrid, Me.colTamanho)
            dblValorDeCusto = .GetRowCellDisplayText(IndexGrid, colCusto) / .GetRowCellDisplayText(IndexGrid, Me.colQtd)
            Me.txtQtd.ToolTipTitle = .GetRowCellDisplayText(IndexGrid, Me.colUM)
            If .GetRowCellDisplayText(IndexGrid, Me.colUniSemDesc).Trim = "" Or .GetRowCellDisplayText(IndexGrid, Me.colUniSemDesc).Trim = "0,00" Then
                dblUniSemDesc = .GetRowCellDisplayText(IndexGrid, Me.colValorUnitario)
            Else
                dblUniSemDesc = .GetRowCellDisplayText(IndexGrid, Me.colUniSemDesc)
            End If

            bolPromocao = .GetRowCellValue(IndexGrid, Me.colPromocao)




            If bolPromocao = True Then
                Me.txtPerDesc.Enabled = False
                Me.txtValor.Enabled = False


                'Dim dblValVenda, dblValCusto, dblLucro, dblMargem As Double

                'dblValVenda = dblUniSemDesc
                'dblValCusto = Me.txtValor.Text.Trim

                'dblLucro = dblValVenda - dblValCusto

                'dblMargem = (dblLucro * 100) / dblUniSemDesc
                'Dim str As String = dblMargem

                'If str <> "+Infinito" Then
                '    Me.txtPerDesc.Text = dblMargem.ToString("0.00")
                'End If

                Me.txtPerDesc.Text = .GetRowCellDisplayText(IndexGrid, Me.colDesconto)
            Else
                Me.txtPerDesc.Enabled = True
                Me.txtValor.Enabled = True
                Me.txtPerDesc.ResetText()
            End If
        End With
    End Sub

    Private Sub memAlt_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles memAlt.DoubleClick
        AlterarItens()
    End Sub
    Private Sub txtValDesc_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValDesc.Leave
        Me.txtDesconto.Text = ""
        'Calcular("VALOR")

        DescontoComValor(False)
        Me.txtDesc.Focus()
    End Sub

    Private Sub txtCodPro_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPro.Enter
        strEstaComFocus = "txtCodPro"
    End Sub

    Private Sub Gaxeta(ByVal parCodProd As Integer)

        bolGaxeta = False
        Me.txtMedidaA.ResetText()
        Me.txtMedidaB.ResetText()
        Me.txtQtdMedida.ResetText()

        Dim dt As DataTable
        dt = CarregarDataTable("Select Grupo from Produto Where Codigo = " & parCodProd)

        If dt.Rows.Count > 0 Then
            If dt.Rows(0).Item("Grupo").ToString = "GAXETA" Then
                bolGaxeta = True
            Else
                bolGaxeta = False
            End If
        End If

        Me.lblMedA.Visible = bolGaxeta
        Me.lblMedB.Visible = bolGaxeta
        Me.lblMedTot.Visible = bolGaxeta
        Me.txtMedidaA.Visible = bolGaxeta
        Me.txtMedidaB.Visible = bolGaxeta
        Me.txtQtdMedida.Visible = bolGaxeta
    End Sub
    Private Sub txtCodPro_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodPro.Leave

        If Me.txtCodPro.Text.Trim = "" Then Exit Sub

        If bolAbriuProduto = True Then bolAbriuProduto = False : Exit Sub

        Dim vetCod As Array = Split(Me.txtCodPro.Text.Trim, "-")
        Dim bolTamanhoNoCodigo As Boolean = False
        If vetCod.Length = 2 Then
            Me.txtCodPro.Text = vetCod(0).ToString
            Me.txtTamanho.Text = vetCod(1).ToString
            bolTamanhoNoCodigo = True
        End If

        Dim dt As DataTable
        If NomeEmpresa.Replace("Ã", "A").Trim.Contains("CAVALAO") = True Then
            dt = CarregarDataTable("Select Codigo, Nome, UnidadeMedida, ValorCusto, Desconto, Grupo, Inativo from Produto Where CodigoBarra ='" & Me.txtCodPro.Text.Trim & "'")

        Else
            dt = CarregarDataTable("Select Codigo, Nome, UnidadeMedida, ValorCusto, Desconto, Grupo, Inativo, CodProdFor from Produto Where CodigoInterno ='" & Me.txtCodPro.Text.Trim & "' or CodigoBarra ='" & Me.txtCodPro.Text.Trim & "'")
            
        End If
        If dt.Rows.Count > 0 Then
            Dim bolInativo As Boolean = dt.Rows.Item(0).Item("Inativo")

            If bolInativo = True Then
                strCodProdFor = ""
                MsgBox("Produto inativo!", MsgBoxStyle.Information)
                bolPromocao = False
                Me.txtPerDesc.Enabled = True
                Me.txtValor.Enabled = True
                Me.txtTamanho.ResetText()
                Me.txtCodPro.ResetText()
                Me.txtCodPro.Focus()
                Me.txtCodPro.Tag = ""
                Me.txtNomePro.ResetText()
                Me.txtValor.ResetText()
                Me.txtQtd.ToolTipTitle = "UNIDADE"
                dblValorDeCusto = 0
                Exit Sub
            End If
            If bolTamanhoNoCodigo = False Then
                TamanhoProd(dt.Rows(0).Item("Codigo").ToString)
            End If

            Gaxeta(dt.Rows(0).Item("Codigo").ToString)
            strCodProdFor = dt.Rows.Item(0).Item("CodProdFor").ToString
            Me.txtCodPro.Tag = dt.Rows(0).Item("Codigo").ToString
            Me.txtNomePro.Text = dt.Rows.Item(0).Item("Nome").ToString
            Me.txtValor.Text = CampoValor(dt.Rows.Item(0).Item("ValorCusto"))
            dblUniSemDesc = CampoValor(dt.Rows.Item(0).Item("ValorCusto"))
            dblUniSemDescOriginal = dblUniSemDesc

            If dt.Rows.Item(0).Item("Desconto").ToString <> "" And dt.Rows.Item(0).Item("Desconto").ToString <> "0" And dt.Rows.Item(0).Item("Desconto").ToString <> "0,000" And dt.Rows.Item(0).Item("Desconto").ToString <> "0,00" Then
                Dim dblPerDesc As Double = dt.Rows.Item(0).Item("Desconto").ToString
                Dim dblUni As Double = Me.txtValor.Text
                Dim dblResto As Double = (dblUni / 100) * dblPerDesc

                dblUni = dblUni - dblResto
                Me.txtValor.Text = CampoValor(dblUni)
                bolPromocao = True
                Me.txtPerDesc.Enabled = False
                Me.txtValor.Enabled = False
                Me.txtPerDesc.Text = dblPerDesc.ToString("0.00")

            Else
                bolPromocao = False
                If strDescontoCliente = "" Then
                    Me.txtPerDesc.ResetText()
                End If

                Me.txtPerDesc.Enabled = True
                Me.txtValor.Enabled = True

            End If
            Me.txtQtd.ToolTipTitle = dt.Rows.Item(0).Item("UnidadeMedida").ToString 'dt.Rows(0).ItemArray(3).ToString
            dblValorDeCusto = dt.Rows.Item(0).Item("ValorCusto").ToString
            bolAbriuProduto = True
            Me.txtQtd.Text = "1"


            If bolPromocao = False Then
                If Me.txtPerDesc.Text <> "" And Me.txtPerDesc.Text <> "0,00" Then
                    If Me.txtValor.Text = "" Then
                        Me.txtValor.Text = dblUniSemDesc
                    End If
                    If Me.txtValor.Text = "" Then Exit Sub

                    Dim dblUni As Double = dblUniSemDesc

                    If Me.txtPerDesc.Text.Trim <> "" And Me.txtPerDesc.Text.Trim <> "0,00" Then
                        Dim dblPerDesc As Double = Me.txtPerDesc.Text.Trim

                        Dim dblResto As Double = (dblUni / 100) * dblPerDesc

                        dblUni = dblUni - dblResto
                        Me.txtValor.Text = CampoValor(dblUni)
                        bolPromocao = True
                        If Nivel <> "USUÁRIO" Then
                            Me.txtPerDesc.Enabled = True
                        End If
                    End If

                End If
            End If

            Me.txtQtd.Focus()

        Else
            strCodProdFor = ""
            bolPromocao = False
            Me.txtPerDesc.Enabled = True
            Me.txtValor.Enabled = True
            Me.txtTamanho.ResetText()
            Me.txtCodPro.ResetText()
            Me.txtCodPro.Focus()
            Me.txtCodPro.Tag = ""
            Me.txtNomePro.ResetText()
            Me.txtValor.ResetText()
            Me.txtQtd.ToolTipTitle = "UNIDADE"
            dblValorDeCusto = 0
            Exit Sub
        End If

        If Me.chkAutoAdd.Checked = True Then
            Me.txtQtd.Focus()
            Me.txtDesc.Focus()
            Adicionar()
        End If

    End Sub

    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click
        ConsultarPedido()
    End Sub


    Private Sub txtCli_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCli.Enter
        strEstaComFocus = "txtCli"
    End Sub

    Private Sub txtCli_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCli.ButtonClick
        If Me.Tag = "CONSULTA" Or Me.Tag = "FATURA" Then Exit Sub
        AbreFornecedor()

    End Sub

    Private Sub AbreFornecedor()
        Dim frm As New frmCadFornecedor
        frm.Tag = "PESQUISA"
        frm.ShowDialog()
        frm.Tag = ""

        If CodigoDoFornecedor <> Nothing Then
            Me.txtCli.Text = NomeFornecedor
            CarregarFornecedor(CodigoDoFornecedor)
        End If

    End Sub

    Private Sub CarregarFornecedor(ByVal parCodFor As String)
        If parCodFor.Trim = Nothing Then Exit Sub
        Dim dt As DataTable = CarregarDataTable("Select Nome, Telefone, Fax, Email, Obs from Fornecedor Where Codigo =" & parCodFor)
        intVencDias = 0
        If dt.Rows.Count > 0 Then
            intCodFor = parCodFor
            NomeFornecedor = dt.Rows.Item(0).ItemArray(0).ToString
            Me.txtCli.Text = dt.Rows.Item(0).ItemArray(0).ToString
            Me.txtTel.Text = dt.Rows.Item(0).ItemArray(1).ToString
            Me.txtFax.Text = dt.Rows.Item(0).ItemArray(2).ToString
            Me.txtEmail.Text = dt.Rows.Item(0).ItemArray(3).ToString

            If Me.txtDesc.Text <> "" Then
                Me.txtDesc.Text = Me.txtDesc.Text & vbCrLf & dt.Rows.Item(0).Item("Obs").ToString
            Else
                Me.txtDesc.Text = dt.Rows.Item(0).Item("Obs").ToString
            End If

            'Me.txtPerDesc.Text = dt.Rows.Item(0).Item("Desconto").ToString
            If Me.txtPerDesc.Text <> "" And Me.txtPerDesc.Text <> "0,00" Then
                strDescontoCliente = Me.txtPerDesc.Text
            Else
                strDescontoCliente = ""
            End If
        End If
        Me.txtCodPro.Focus()
    End Sub

    Private Sub txtCodPed_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodPed.Enter
        strEstaComFocus = "txtCodPed"
    End Sub


    Private Sub txtCli_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCli.Leave
        Me.txtCodPro.Focus()
    End Sub

    Private Sub cboTab_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtCodPro.Tag = ""
        Me.txtCodPro.ResetText()
        Me.txtNomePro.ResetText()
        Me.txtQtd.ResetText()
        Me.txtValor.ResetText()
    End Sub
    Private Sub Visualizar(ByVal parValores As Boolean, ByVal parEnviarEmail As Boolean)
        Dim rel As New relPed

        rel.lblTitulo.Text = NomeEmpresa
        rel.lblEndereco.Text = EnderecoEmpresa
        rel.lblFones.Text = TelefoneEmpresa

        rel.picLogo.Image = LogoTipo
        rel.XrLabel10.Text = "Fornecedor"

        Dim I, intQtde, intQtdTotal As Integer
        Dim dblTotal, dblTotalGeral As Double
        For I = 0 To Me.grd1.RowCount - 1
            intQtde = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
            intQtdTotal += intQtde
            dblTotal = Me.grd1.GetRowCellDisplayText(I, Me.colValorTotal)
            dblTotalGeral += dblTotal
            With rel.tbConsig.Rows
                .Add()
                .Item(I).Item("Produto") = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                .Item(I).Item("Qtd") = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                .Item(I).Item("ValorUnitario") = Me.grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                .Item(I).Item("ValorTotal") = Me.grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                .Item(I).Item("Tamanho") = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho)
                .Item(I).Item("Codigo") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoPeca)
                .Item(I).Item("UniSemDesc") = Me.grd1.GetRowCellDisplayText(I, Me.colUniSemDesc)
                .Item(I).Item("UM") = Me.grd1.GetRowCellDisplayText(I, Me.colUM)
            End With
        Next
        If Me.rdgDesc.SelectedIndex = 1 Then
            rel.colUniSemDesc.Caption = "Sem Acres. R$"
            rel.XrTableCell7.Text = "Acréscimo R$"
        End If
        rel.lblNome.Text = Me.txtCli.Text
        rel.lblTel1.Text = Me.txtTel.Text
        rel.lblTel2.Text = Me.txtFax.Text
        rel.lblWeb.Text = Me.txtEmail.Text.ToLower

        If Me.cboStatus.Text = "Orçamento" Then
            rel.lblNomePed.Text = "Orçamento N°:"
        End If

        rel.lblPed.Text = Me.txtCodPed.Text
        rel.lblData.Text = Me.dtData.Text

        rel.tblQtd.Text = intQtdTotal
        rel.tblTotal.Text = Me.txtTotal.Text
        rel.tblDesc.Text = Me.txtValDesc.Text
        rel.lblVend.Text = Me.lueFunc.Text.Trim
        rel.rtbObs.Text = Me.txtDesc.Text

        rel.rtbConfigObs.Text = ObsPedido

        If Me.Tag = "ATIVO" Then
            For I = 0 To Me.tbAtivo.Rows.Count - 1
                Dim row As New XRTableRow
                Dim cell0 As New XRTableCell
                Dim cell1 As New XRTableCell
                Dim cell2 As New XRTableCell
                Dim cell3 As New XRTableCell
                cell0.Size = New System.Drawing.Size(126, 23)
                cell1.Size = New System.Drawing.Size(257, 23)
                cell2.Size = New System.Drawing.Size(233, 23)
                cell3.Size = New System.Drawing.Size(151, 23)
                cell0.Text = Me.tbAtivo.Rows.Item(I).Item("CodPadrao")
                cell1.Text = Me.tbAtivo.Rows.Item(I).Item("Nome")
                cell2.Text = Me.tbAtivo.Rows.Item(I).Item("Produto")
                cell3.Text = Me.tbAtivo.Rows.Item(I).Item("Vencimento")
                Dim sinSize As Single = 8.25
                cell0.Font = New Font("Tahoma", sinSize, FontStyle.Regular)
                cell1.Font = New Font("Tahoma", sinSize, FontStyle.Regular)
                cell2.Font = New Font("Tahoma", sinSize, FontStyle.Regular)
                cell3.Font = New Font("Tahoma", sinSize, FontStyle.Regular)
                cell0.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
                cell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
                cell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
                cell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
                row.Cells.Add(cell0)
                row.Cells.Add(cell1)
                row.Cells.Add(cell2)
                row.Cells.Add(cell3)
                rel.tabAtivo.Rows.Add(row)


            Next
        Else
            rel.tabAtivo.Visible = False
            rel.linhaAtivo.Visible = False
            rel.lblAtivo.Visible = False
        End If

        If parValores = False Then
            rel.colValorUnitario.Visible = False
            rel.colValorTotal.Visible = False
            rel.colUniSemDesc.Visible = False
            rel.XrTable1.Visible = False
        End If
        'OcultarAutorizacao
        If AutorizacaoPedido = False Then
            rel.lblAutorizacao.Visible = False
        Else
            rel.lblAutorizacao.Text = Me.txtCli.Text
        End If

        If parEnviarEmail = False Then
            rel.ShowPreview()
        Else
            rel.ExportToPdf("C:\NANO\Pedidos\Pedido Nº " & Me.txtCodPed.Text.Trim & ".pdf")
        End If

    End Sub

    Private Sub VisualizarCompleto(ByVal parValores As Boolean, ByVal parEnviarEmail As Boolean)
        Dim rel As New relPed2

        rel.lblTitulo.Text = NomeEmpresa
        rel.lblEndereco.Text = EnderecoEmpresa
        rel.lblFones.Text = TelefoneEmpresa
        If NomeEmpresa.Contains("HELENA DECOR") = False Then
            rel.lblRazao.Visible = False
            rel.lblSite.Visible = False
            rel.lblTitulo.Location = New System.Drawing.Point(167, 25)
            rel.lblEndereco.Location = New System.Drawing.Point(167, 50)
            rel.lblFones.Location = New System.Drawing.Point(167, 67)
        Else
            Dim strCnpj As String = AddPonto(CNPJEmpresa, "J")

            rel.lblRazao.Text = "Razão Social Priscila Arantes Ribeiro ME. CNPJ: " & strCnpj
            rel.lblSite.Text = "www.helenadecor.com.br"



            rel.lblPrazo.Visible = True



        End If

        rel.picLogo.Image = LogoTipo
        rel.XrLabel10.Text = "Fornecedor"

        Dim I, intQtde, intQtdTotal As Integer
        Dim dblTotal, dblTotalGeral As Double
        For I = 0 To Me.grd1.RowCount - 1
            intQtde = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
            intQtdTotal += intQtde
            dblTotal = Me.grd1.GetRowCellDisplayText(I, Me.colValorTotal)
            dblTotalGeral += dblTotal
            With rel.tbPed.Rows
                .Add()
                .Item(I).Item("Produto") = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                .Item(I).Item("Qtd") = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                .Item(I).Item("ValorUnitario") = Me.grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                .Item(I).Item("ValorTotal") = Me.grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                .Item(I).Item("Tamanho") = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho)
                .Item(I).Item("Codigo") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoPeca)
                .Item(I).Item("UniSemDesc") = Me.grd1.GetRowCellDisplayText(I, Me.colUniSemDesc)
                .Item(I).Item("UM") = Me.grd1.GetRowCellDisplayText(I, Me.colUM)
            End With
        Next
        Dim dtCli As DataTable = CarregarDataTable("SELECT CPF, IE, Endereco, Bairro, Numero, Cidade, Cep, " & _
        "convert(Varchar(10),Nascimento,103) as Nascimento, Complemento FROM Fornecedor where Codigo = " & intCodFor)
        If dtCli.Rows.Count > 0 Then
            rel.lblEnd.Text = dtCli.Rows.Item(0).Item("Endereco").ToString
            rel.lblBairro.Text = dtCli.Rows.Item(0).Item("Bairro").ToString
            rel.lblNum.Text = dtCli.Rows.Item(0).Item("Numero").ToString
            rel.lblCidade.Text = dtCli.Rows.Item(0).Item("Cidade").ToString
            rel.lblCep.Text = dtCli.Rows.Item(0).Item("Cep").ToString
            rel.lblCPF.Text = dtCli.Rows.Item(0).Item("CPF").ToString
            rel.lblRG.Text = dtCli.Rows.Item(0).Item("IE").ToString
            rel.lblNascimento.Text = dtCli.Rows.Item(0).Item("Complemento").ToString

        End If

        If Me.rdgDesc.SelectedIndex = 1 Then
            rel.colUniSemDesc.Caption = "Sem Acres. R$"
            rel.XrTableCell7.Text = "Acréscimo R$"
        End If
        rel.lblNome.Text = Me.txtCli.Text
        rel.lblTel1.Text = Me.txtTel.Text
        rel.lblTel2.Text = Me.txtFax.Text
        rel.lblWeb.Text = Me.txtEmail.Text.ToLower

        If Me.cboStatus.Text = "Orçamento" Then
            rel.lblNomePed.Text = "Orçamento N°:"

        End If

        rel.lblPed.Text = Me.txtCodPed.Text
        rel.lblData.Text = Me.dtData.Text

        rel.tblQtd.Text = intQtdTotal
        rel.tblTotal.Text = Me.txtTotal.Text
        rel.tblDesc.Text = Me.txtValDesc.Text
        rel.lblVend.Text = Me.lueFunc.Text.Trim
        rel.rtbObs.Text = Me.txtDesc.Text

        rel.rtbConfigObs.Text = ObsPedido

        If parValores = False Then
            rel.colValorUnitario.Visible = False
            rel.colValorTotal.Visible = False
            rel.XrTable1.Visible = False
            rel.colUniSemDesc.Visible = False
        End If

        'Dim dt As DataTable = CarregarDataTable("SELECT convert(varchar(10),DataVenda,103) as DataVenda FROM TotalConsig where CodOrdens = " & Me.txtCodPed.Text & " and CodConfig = " & CodConfig & " and Status = 'Faturado'")
        'If dt.Rows.Count > 0 Then
        '    If dt.Rows.Item(0).Item("DataVenda").ToString <> "" Then
        '        rel.lblVenda.Text = dt.Rows.Item(0).Item("DataVenda").ToString
        '        rel.lblVenda.Visible = True
        '        rel.lblLabelVenda.Visible = True
        '    End If
        'End If

        'OcultarAutorizacao
        If AutorizacaoPedido = False Then
            rel.lblAutorizacao.Visible = False
            rel.lblAutorizacaoEmpresa.Visible = False
        Else
            rel.lblAutorizacao.Text = Me.txtCli.Text
            rel.lblAutorizacaoEmpresa.Text = NomeEmpresa
        End If
        If parEnviarEmail = False Then
            rel.ShowPreview()
        Else
            rel.ExportToPdf("C:\NANO\Pedidos\Pedido Nº " & Me.txtCodPed.Text.Trim & ".pdf")
        End If

    End Sub


    Private Sub txtEntrega_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEntrega.Leave
        Calcular()
    End Sub

    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        If MsgBox("Tem certeza que deseja excluir o Pedido Nº " & Me.txtCodPed.Text.Trim & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            If SenhaEstaOK() = False Then Exit Sub

            'Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & "PEDIDO Nº " & Me.txtCodPed.Text.Trim & ", " & Me.txtCli.Text.Trim & "','EXCLUÍDO','PEDIDO','PEDIDO','EXCLUSÃO'," & CodConfig & ")")
            Excluir("Update TotalPedCompra set Status ='Excluído' where CodOrdens =" & Me.txtCodPed.Text.Trim & " AND CodConfig =" & CodConfig)
            MsgBox("Pedido excluído com sucesso!", MsgBoxStyle.Information)

            Limpar(True)
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Tag = "ALTERA" Then
            Me.txtCodPed.Focus()
        Else
            Me.lueFunc.Focus()
        End If


        Timer1.Stop()
    End Sub

    Private Sub txtDesc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesc.KeyPress, txtCodPro.KeyPress, txtCodPed.KeyPress
        If e.KeyChar = "'" Or e.KeyChar = "&" Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnPromissoria_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPromissoria.ItemClick
        Dim rel As New relPromissoria
        Dim culture As New CultureInfo("pt-BR")
        Dim dtfi As DateTimeFormatInfo = culture.DateTimeFormat
        Dim dia As Integer = DateTime.Now.Day
        Dim ano As Integer = DateTime.Now.Year
        Dim mes As String = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Month))
        Dim diasemana As String = culture.TextInfo.ToTitleCase(dtfi.GetDayName(DateTime.Now.DayOfWeek))
        Dim data As String = diasemana & ", " & dia & " de " & mes & " de " & ano
        Dim vetData As Array
        vetData = Split(Date.Today.AddDays(30), "/")
        Dim intMes, intDia, intAno As Integer
        intMes = vetData(1)
        intDia = vetData(0)
        intAno = vetData(2)
        Dim strMesVenc As String = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(intMes))
        Dim strDia As String = getInteger(intDia)
        Dim strAno As String = getInteger(intAno)
        Dim dt As DataTable
        dt = CarregarDataTable("SELECT Nome, Endereco, Numero, Bairro, Cidade , Estado, CPF FROM Fornecedor where Codigo = " & intCodFor)
        If dt.Rows.Count > 0 Then
            Dim strEndereco As String
            strEndereco = dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & "  " & dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & " - " & dt.Rows.Item(0).Item("Estado").ToString
            rel.lblPagavel.Text = CidadeEmpresa
            rel.lblCPF1.Text = CNPJEmpresa
            rel.lblCidade.Text = CidadeEmpresa & ","
            rel.lblDiaAtual.Text = Date.Today.Day
            rel.lblMesAtual.Text = mes.ToUpper
            rel.lblAnoAtual.Text = Date.Today.Year
            rel.lblDia.Text = intDia
            rel.lblMes.Text = strMesVenc.ToUpper
            rel.lblAno.Text = intAno
            rel.lblEmit.Text = Me.txtCli.Text.Trim
            rel.lblEnd.Text = strEndereco
            rel.lblCPF2.Text = dt.Rows.Item(0).Item("CPF").ToString
            rel.lblVia.Text = NomeEmpresa
            If dt.Rows.Item(0).Item("CPF").ToString <> "" Then
                If dt.Rows.Item(0).Item("CPF").ToString.Length > 13 Then
                    rel.lblPagar.Text = "EMOS"
                Else
                    rel.lblPagar.Text = "EI"
                End If
            Else
                rel.lblPagar.Text = "EI"
            End If
            Dim dblValorTotal As Double = Me.txtTotal.Text

            rel.lblNumero.Text = "01/01"
            rel.lblValor.Text = dblValorTotal.ToString("0.00")
            Dim strValorExt As String = dblValorTotal.ToString("0.00")
            Dim vetValor As Array
            vetValor = Split(strValorExt, ",")
            Dim strReais, strCentavos As String
            strReais = getInteger(vetValor(0))
            If vetValor(1) = "00" Then
                strValorExt = strReais.ToUpper & " REAIS"
            Else
                strCentavos = getInteger(vetValor(1))
                strValorExt = strReais.ToUpper & " REAIS E " & strCentavos.ToUpper & " CENTAVOS"
            End If
            rel.lblValorExt.Text = strValorExt
            rel.lblAos.Text = "DIA " & strDia.ToUpper & " DO MÊS DE " & strMesVenc.ToUpper & " DO ANO DE " & strAno.ToUpper
            rel.ShowPreviewDialog()
        Else
            MsgBox("Pedido sem cliente!", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub btnAtivo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAtivo.ItemClick
        frmCadAtivo.Show()
    End Sub
    Private Function AdicionarAmbos() As Boolean

        Dim I As Integer

        Me.tbAmbos.Rows.Clear()
        Dim A As Integer = 0

        For I = 0 To Me.grd1.RowCount - 1
            Dim strCodProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto)

            If strCodProd <> "" Then
                Dim dt As DataTable = CarregarDataTable("SELECT Tipo FROM Produto where Codigo = " & strCodProd)

                If dt.Rows.Count > 0 Then
                    Dim strTipo As String = dt.Rows.Item(0).Item("Tipo").ToString

                    If strTipo = "AMBOS" Then

                        Me.tbAmbos.Rows.Add()
                        Me.tbAmbos.Rows.Item(A).Item("CodigoProduto") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto)
                        Me.tbAmbos.Rows.Item(A).Item("CodigoInterno") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoPeca)
                        Me.tbAmbos.Rows.Item(A).Item("CodigoPedido") = Me.grd1.GetRowCellDisplayText(I, Me.colCodPedAut)
                        Me.tbAmbos.Rows.Item(A).Item("Produto") = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                        Me.tbAmbos.Rows.Item(A).Item("UM") = Me.grd1.GetRowCellDisplayText(I, Me.colUM)
                        Me.tbAmbos.Rows.Item(A).Item("Qtd") = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                        Me.tbAmbos.Rows.Item(A).Item("QtdAdd") = "0"
                        Me.tbAmbos.Rows.Item(A).Item("Focus") = ""

                        A += 1
                    End If
                End If
            End If
        Next

    End Function
    Private Sub CalcularAmbos()
        Dim I As Integer
        Dim A As Integer


        For I = 0 To Me.tbAmbos.Rows.Count - 1
            Dim strCodigoPedidoAmbos As String = Me.tbAmbos.Rows.Item(I).Item("CodigoPedido")
            Dim strProdutoAmbos As String = Me.tbAmbos.Rows.Item(I).Item("Produto")
            Dim dblQtdAmbos As Double = 0

            For A = 0 To Me.tbAtivo.Rows.Count - 1
                Dim strCodigoPedidoAtivo As String = Me.tbAtivo.Rows.Item(A).Item("CodPedAut")

                If strCodigoPedidoAmbos = strCodigoPedidoAtivo Then
                    dblQtdAmbos += 1
                    Me.tbAtivo.Rows.Item(A).Item("Produto") = strProdutoAmbos
                    'Me.grd2.SetRowCellValue(A, Me.colProdutoAtivo, strProdutoAmbos)
                End If
            Next
            Me.tbAmbos.Rows.Item(I).Item("QtdAdd") = dblQtdAmbos.ToString("0.000")
            Me.grd3.SetRowCellValue(I, Me.colQtdeAddAmbos, dblQtdAmbos.ToString("0.000"))



        Next


    End Sub
    Private Sub btnAddAtivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddAtivo.Click
        If Me.grd3.FocusedRowHandle < 0 Then
            MsgBox("Selecione um produto para poder adicionar!", MsgBoxStyle.Information)
            Exit Sub
        End If
        If Validar(Me.txtCodPed) = False Then Exit Sub
        If Validar(txtNomeAtivo) = False Then Exit Sub
        If Validar(txtValorAtivo) = False Then Exit Sub
        If Validar(txtCodAtivo) = False Then Exit Sub

        Dim I As Integer

        If Me.dtVencimento.Text = "01/01/0001" Then MsgBox("Vencimento incorreto!", MsgBoxStyle.Information) : Exit Sub
        With Me.tbAtivo.Rows
            If Me.chkAlterado.Checked = False Then

                If Me.grd3.GetRowCellDisplayText(Me.grd3.FocusedRowHandle, Me.colQtdAmbos) = Me.grd3.GetRowCellDisplayText(Me.grd3.FocusedRowHandle, Me.colQtdeAddAmbos) Then
                    MsgBox("Não é possível adicionar!", MsgBoxStyle.Information)
                    Exit Sub
                End If


                For I = 0 To Me.grd2.RowCount - 1
                    Dim strCodPadrao As String = Me.grd2.GetRowCellDisplayText(I, Me.colCodPadrao)
                    If Me.txtCodAtivo.Text.Trim = strCodPadrao Then
                        MsgBox("Barril/Chopeira já adicionado!", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                Next
                .Add()
                Dim Index As Integer = .Count - 1
                .Item(Index).Item("CodAtivo") = strCodigoAtivo
                .Item(Index).Item("CodPadrao") = Me.txtCodAtivo.Text
                .Item(Index).Item("Nome") = txtNomeAtivo.Text.Trim.Replace("'", "").Replace("&", "")
                .Item(Index).Item("Valor") = txtValorAtivo.Text.Trim
                .Item(Index).Item("Excluir") = False

                .Item(Index).Item("Vencimento") = Me.dtVencimento.Text
                .Item(Index).Item("CodPedAut") = Me.grd3.GetRowCellDisplayText(Me.grd3.FocusedRowHandle, Me.colCodigoPedidoAmbos)
                .Item(Index).Item("Produto") = Me.grd3.GetRowCellDisplayText(Me.grd3.FocusedRowHandle, Me.colProdutoAmbos)
            Else
                If Me.grd3.GetRowCellDisplayText(Me.grd3.FocusedRowHandle, Me.colCodigoPedidoAmbos) <> strCodigoPedidoAtivo Then
                    If Me.grd3.GetRowCellDisplayText(Me.grd3.FocusedRowHandle, Me.colQtdAmbos) = Me.grd3.GetRowCellDisplayText(Me.grd3.FocusedRowHandle, Me.colQtdeAddAmbos) Then
                        MsgBox("Não é possível adicionar!", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                End If

                If Me.txtCodAtivo.Text.Trim <> strCodigoPadrao Then
                    For I = 0 To Me.grd2.RowCount - 1
                        Dim strCodPadrao As String = Me.grd2.GetRowCellDisplayText(I, Me.colCodPadrao)
                        If Me.txtCodAtivo.Text.Trim = strCodPadrao Then
                            MsgBox("Barril/Chopeira já adicionado!", MsgBoxStyle.Information)
                            Exit Sub
                        End If
                    Next
                End If


                grd2.SetRowCellValue(IndexGrid, Me.colNome, Me.txtNomeAtivo.Text.Trim.Replace("'", "").Replace("&", ""))
                grd2.SetRowCellValue(IndexGrid, Me.colCodAtivo, strCodigoAtivo)
                grd2.SetRowCellValue(IndexGrid, Me.colCodPadrao, Me.txtCodAtivo.Text)
                grd2.SetRowCellValue(IndexGrid, Me.colValor, Me.txtValorAtivo.Text.Trim)

                grd2.SetRowCellValue(IndexGrid, Me.colVencimentoAtivo, Me.dtVencimento.Text)
                grd2.SetRowCellValue(IndexGrid, Me.colCodigoPedidoAtivo, Me.grd3.GetRowCellDisplayText(Me.grd3.FocusedRowHandle, Me.colCodigoPedidoAmbos))
                grd2.SetRowCellValue(IndexGrid, Me.colProdutoAtivo, Me.grd3.GetRowCellDisplayText(Me.grd3.FocusedRowHandle, Me.colProdutoAmbos))
            End If
            Me.chkAlterado.Checked = False
        End With
        Me.grd2.ExpandAllGroups()
        CalcularAmbos()
        strCodigoPedidoAtivo = ""
        strCodigoAtivo = ""
        txtNomeAtivo.ResetText()
        txtValorAtivo.ResetText()
        Me.txtCodAtivo.ResetText()
        Me.txtCodAtivo.Focus()
        ' Me.dtVencimento.ResetText()
        Me.grd2.OptionsView.ShowAutoFilterRow = True
        Me.grd2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default

    End Sub

    Private Sub btnExcluirAtivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExcluirAtivo.Click
        If Me.chkAlterado.Checked = True Then MsgBox("Existe um item sendo alterado, conclua a alteração antes de excluir algum item!", MsgBoxStyle.Information) : Exit Sub
        If grd2.RowCount = 0 Then Exit Sub

        Dim I As Integer
        Dim bolExcluirVarios As Boolean = False
        Dim strCodPadrao As String = ""
        For I = 0 To Me.grd2.RowCount - 1
            If grd2.GetRowCellDisplayText(I, Me.colCodPadrao) <> "" Then
                If I <= Me.grd2.RowCount - 1 Then
                    If Me.grd2.GetRowCellValue(I, Me.colExcluir2) = True Then
                        If bolExcluirVarios = False Then
                            If MsgBox("Deseja realmente excluir estes items?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                bolExcluirVarios = True
                                If grd2.GetRowCellDisplayText(I, Me.colCodigo2) <> "" Then
                                    strItensDeletado &= grd2.GetRowCellDisplayText(I, Me.colCodigo2) & "|"
                                    strCodPadrao &= grd2.GetRowCellDisplayText(I, Me.colCodPadrao) & "|"
                                End If
                                Me.grd2.DeleteRow(I)
                                I = I - 1
                            Else
                                Exit Sub
                            End If

                        Else
                            If grd2.GetRowCellDisplayText(I, Me.colCodigo2) <> "" Then
                                strItensDeletado &= grd2.GetRowCellDisplayText(I, Me.colCodigo2) & "|"
                                strCodPadrao &= grd2.GetRowCellDisplayText(I, Me.colCodPadrao) & "|"
                            End If
                            Me.grd2.DeleteRow(I)
                            I = I - 1
                        End If
                    End If
                End If
            End If


        Next


        If bolExcluirVarios = False Then

            If MsgBox("Deseja realmente excluir este item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If grd2.GetRowCellDisplayText(grd2.FocusedRowHandle, Me.colCodigo2) <> "" Then
                    strItensDeletado &= grd2.GetRowCellDisplayText(grd2.FocusedRowHandle, Me.colCodigo2) & "|"
                    strCodPadrao &= grd2.GetRowCellDisplayText(grd2.FocusedRowHandle, Me.colCodPadrao) & "|"
                End If
                Me.grd2.DeleteRow(grd2.FocusedRowHandle)

            End If
        End If

        Dim vetDelete As Array = Split(strCodPadrao, "|")
        Dim A As Integer
        For I = 0 To vetDelete.Length - 1
            If vetDelete(I) <> "" And vetDelete(I).ToString.ToUpper <> "INSERIR" Then
                For A = 0 To Me.tbAtivo.Rows.Count - 1
                    Dim strCP As String = Me.tbAtivo.Rows.Item(A).Item("CodPadrao").ToString
                    If strCP = vetDelete(I) Then
                        Me.tbAtivo.Rows.RemoveAt(A)
                        Exit For
                    End If
                Next
            End If
        Next
        CalcularAmbos()

    End Sub

    Private Sub AbrirAtivo(ByVal parCodigo As String)

        If parCodigo = "" Then Exit Sub
        Dim dtProd As DataTable

        parCodigo = parCodigo.Substring(0, 2)

        dtProd = CarregarDataTable("SELECT Codigo, CodPadrao, Nome, Valor FROM Ativo where CodPadrao = '" & parCodigo & "'")
        TamanhoProd(parCodigo)

        If dtProd.Rows.Count > 0 Then
            strCodigoAtivo = dtProd.Rows.Item(0).Item("Codigo").ToString
            Me.txtNomeAtivo.Text = dtProd.Rows.Item(0).Item("Nome").ToString
            Me.txtValorAtivo.Text = Format(dtProd.Rows.Item(0).Item("Valor"), "0.00")
            If Me.dtVencimento.Text = "" Then
                Me.dtVencimento.Focus()
            Else
                Me.btnAddAtivo.Focus()
            End If


        Else
            strCodigoAtivo = ""
            Me.txtCodAtivo.ResetText()
            Me.txtNomeAtivo.ResetText()
            Me.txtValorAtivo.ResetText()

            Me.txtCodAtivo.Focus()
        End If
    End Sub

    Private Sub txtCodAtivo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodAtivo.Leave
        If Me.txtCodAtivo.Text = "" Then Exit Sub
        AbrirAtivo(Me.txtCodAtivo.Text)
    End Sub

    Private Sub txtAlterar2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar2.DoubleClick
        If grd2.FocusedRowHandle < 0 Then Exit Sub

        If Me.Tag = "CONSULTA" Or Me.Tag = "FATURA" Then Exit Sub
        Me.chkAlterado.Checked = True
        IndexGrid = grd2.FocusedRowHandle
        Me.grd2.OptionsView.ShowAutoFilterRow = False
        Me.grd2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        With grd2

            Me.txtNomeAtivo.Text = .GetRowCellDisplayText(IndexGrid, Me.colNome)
            strCodigoPadrao = .GetRowCellDisplayText(IndexGrid, Me.colCodPadrao)
            Me.txtCodAtivo.Text = .GetRowCellDisplayText(IndexGrid, Me.colCodPadrao)
            strCodigoAtivo = .GetRowCellDisplayText(IndexGrid, Me.colCodAtivo)
            Me.txtValorAtivo.Text = .GetRowCellDisplayText(IndexGrid, Me.colValor)
            strCodigoPedidoAtivo = .GetRowCellDisplayText(IndexGrid, Me.colCodigoPedidoAtivo)
            Me.dtVencimento.Text = .GetRowCellDisplayText(IndexGrid, Me.colVencimentoAtivo)
            Dim I As Integer
            Dim intIndexAmbos As Integer
            For I = 0 To Me.grd3.RowCount - 1
                Me.grd3.SetRowCellValue(I, Me.colFocus, "")
                If strCodigoPedidoAtivo = Me.grd3.GetRowCellDisplayText(I, Me.colCodigoPedidoAmbos) Then
                    intIndexAmbos = I
                    'Exit For
                End If
            Next
            Me.grd3.FocusedRowHandle = intIndexAmbos
            Me.grd3.SetRowCellValue(Me.grd3.FocusedRowHandle, Me.colFocus, "1")
        End With
    End Sub

    Private Sub tabAtivo_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles tabAtivo.SelectedPageChanged
        If Me.tabAtivo.SelectedTabPageIndex = 1 Then
            For I = 0 To Me.grd3.RowCount - 1
                Me.grd3.SetRowCellValue(I, Me.colFocus, "")
            Next
            Me.grd3.FocusedRowHandle = 0
            Me.grd3.SetRowCellValue(Me.grd3.FocusedRowHandle, Me.colFocus, "1")
        End If
        Me.txtCodAtivo.Focus()
    End Sub

    Private Sub txtFocus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFocus.Click
        'Dim I As Integer
        'For I = 0 To Me.grd3.RowCount - 1
        '    Me.grd3.SetRowCellValue(I, Me.colFocus, "")
        'Next
        'Me.grd3.SetRowCellValue(Me.grd3.FocusedRowHandle, Me.colFocus, "1")
    End Sub

    Private Sub txtFocus_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtFocus.MouseDown
        Dim I As Integer
        For I = 0 To Me.grd3.RowCount - 1
            Me.grd3.SetRowCellValue(I, Me.colFocus, "")
        Next
        Me.grd3.SetRowCellValue(Me.grd3.FocusedRowHandle, Me.colFocus, "1")
    End Sub

    Private Sub grd3_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles grd3.RowCellStyle
        If e.Column.FieldName = "QtdAdd" Then

            Dim strQtd As String = Me.grd3.GetRowCellDisplayText(e.RowHandle, Me.colQtdAmbos)
            Dim strQtdAdd As String = Me.grd3.GetRowCellDisplayText(e.RowHandle, Me.colQtdeAddAmbos)
            If Me.grd3.GetRowCellDisplayText(e.RowHandle, Me.colQtdAmbos) = Me.grd3.GetRowCellDisplayText(e.RowHandle, Me.colQtdeAddAmbos) Then
                e.Appearance.BackColor = Color.LimeGreen
                e.Appearance.ForeColor = Color.Black
            Else
                e.Appearance.BackColor = Color.Orange
                e.Appearance.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub btnVisualizarComValores_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizarComValores.ItemClick
        EscolherImpressao(True, False)
    End Sub

    Private Sub EscolherImpressao(ByVal parComValor As Boolean, ByVal parEnviarEmail As Boolean)
        If ImpressaoPedidoCompleto = False Then
            Visualizar(parComValor, parEnviarEmail)
        Else
            VisualizarCompleto(parComValor, parEnviarEmail)
        End If
    End Sub

    Private Sub btnVisualizarSemValores_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizarSemValores.ItemClick
        EscolherImpressao(False, False)
    End Sub

    Private Sub txtPerDesc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPerDesc.Leave
        If Me.txtValor.Text = "" Then
            Me.txtValor.Text = dblUniSemDesc
        End If
        If Me.txtValor.Text = "" Then Exit Sub

        Dim dblUni As Double = dblUniSemDesc

        If Me.txtPerDesc.Text.Trim <> "" And Me.txtPerDesc.Text.Trim <> "0,00" Then
            Dim dblPerDesc As Double = Me.txtPerDesc.Text.Trim

            Dim dblResto As Double = (dblUni / 100) * dblPerDesc

            dblUni = dblUni - dblResto
            Me.txtValor.Text = dblUni.ToString("0.00")
            bolPromocao = True

        End If
        Me.btnAdd.Focus()
    End Sub

    Private Sub btnMail_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMail.ItemClick

        If IO.Directory.Exists("C:\NANO\Pedidos") = False Then
            IO.Directory.CreateDirectory("C:\NANO\Pedidos")
        End If

        EscolherImpressao(True, True)

        frmEmail.strCaminhoArquivo = "C:\NANO\Pedidos\Pedido Nº " & Me.txtCodPed.Text.Trim & ".pdf"
        frmEmail.strEmailCliente = Me.txtEmail.Text.Trim.ToLower
        frmEmail.Tag = "PEDIDO"

        frmEmail.Show()
    End Sub

    Private Sub btnImprimir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImprimir.ItemClick
        Imprimir()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        bolTimer2 = True
        If Me.txtCodPed.Text <> "" Then
            Me.txtCodPro.Focus()
        End If
        bolTimer2 = False
        Timer2.Stop()
    End Sub

    Private Sub btnLucro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLucro.CheckedChanged
        Select Case btnLucro.Checked

            Case True
                Me.colLucro.Visible = True
                Me.colLucro.VisibleIndex = 8
                Me.grd1.OptionsView.ShowFooter = True
            Case False
                Me.colLucro.Visible = False
                Me.grd1.OptionsView.ShowFooter = False
        End Select
    End Sub

    Private Sub btnCompromisso_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCompromisso.ItemClick
        If Me.Tag = "CADASTRA" Then
            DescricaoCompromisso = ""
            DataCompromisso = Nothing
            frmCompromisso.strCodPedido = ""
            frmCompromisso.dtData.EditValue = dtStartData
            frmCompromisso.memDescricao.Text = strDescricao
        Else
            frmCompromisso.strCodPedido = Me.txtCodPed.Text
        End If
        frmCompromisso.cboLembrete.SelectedIndex = -1
        frmCompromisso.Tag = Me.Tag
        frmCompromisso.ShowDialog()
        If Me.Tag = "CADASTRA" Then
            strDescricao = DescricaoCompromisso
            dtStartData = DataCompromisso
            strLembrete = LembreteCompromisso
        End If
    End Sub

    Private Sub btnEntrada_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEntrada.ItemClick
        If Me.Tag = "CADASTRA" Then
            If MsgBox("É necessario salvar o pedido antes. Deseja salvar agora?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Salvar(True)
            End If
        Else
            If Me.txtCodPed.Text = "" Then
                MsgBox("Pedido não selecionado!", MsgBoxStyle.Information)
                Exit Sub
            End If
            If Me.Tag = "CONSULTA" Then
                frmRecebimento.Tag = "CONSULTA"
            Else
                frmRecebimento.Tag = ""
            End If
            frmRecebimento.txtTotal.Text = Me.txtTotal.Text.Trim
            frmRecebimento.txtTotal.Tag = Me.txtTotal.Text.Trim
            frmRecebimento.txtARec.Text = Me.txtTotal.Text.Trim

            frmRecebimento.strCodPed = Me.txtCodPed.Text.Trim
            frmRecebimento.intCodCliente = intCodFor
            NomeDoCliente = Me.txtCli.Text
            frmRecebimento.ShowDialog()
        End If
    End Sub

    Private Sub btnVender_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVender.ItemClick
        If TesteConexao() = False Then Exit Sub

        If Me.Tag = "CADASTRA" Then
            Salvar(False)
        Else
            If Me.txtCodPed.Text = "" Then Exit Sub
        End If

        Dim strCod As String = Me.txtCodPed.Text

        Dim dt As DataTable = CarregarDataTable("SELECT * FROM TotalConsig where CodOrdens = " & strCod & " and Status = 'Faturado'")
        If dt.Rows.Count > 0 Then
            MsgBox("Pedido já faturado!")
            Exit Sub
        End If


        If ProcuraForm("frmVenda") = "frmVenda" Then

            If frmVenda.grd1.RowCount > 0 Then
                MsgBox("Não é possivel realizar esse procedimento pois já existe uma venda sendo realizada!", MsgBoxStyle.Information)
                Exit Sub
            End If
            If Me.Tag = "ALTERA" Then
                Salvar(False)
            End If
            ConsultaPedido = strCod
            frmVenda.F11(True)
            frmVenda.WindowState = FormWindowState.Maximized
            Me.Close()
        Else
            If Me.Tag = "ALTERA" Then
                Salvar(False)
            End If

            ConsultaPedido = strCod
            frmVenda.bolPedido = True
            frmVenda.Show()
            frmVenda.F11(True)
            Me.Close()
        End If

    End Sub

    Private Sub rdgDesc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgDesc.SelectedIndexChanged
        If bolTimer2 = False Then
            Me.txtDesconto.Text = "0,00"
            Me.txtValDesc.Text = "0,00"
            DescontoComValor(False)
        End If

    End Sub

    Private Sub txtCodPro2_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodPro2.ButtonClick
        RemoverProdutos()
    End Sub

    Private Sub txtCodPro2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodPro2.Enter
        strEstaComFocus = "txtCodPro2"
    End Sub

    Private Sub txtCodPro2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodPro2.Leave

        If Me.txtCodPro2.Text.Trim = "" Then Exit Sub

        If bolAbriuProduto = True Then bolAbriuProduto = False : Exit Sub

        Dim vetCod As Array = Split(Me.txtCodPro2.Text.Trim, "-")
        Dim bolTamanhoNoCodigo As Boolean = False
        If vetCod.Length = 2 Then
            Me.txtCodPro2.Text = vetCod(0).ToString
            Me.txtTamanho2.Text = vetCod(1).ToString
            bolTamanhoNoCodigo = True
        End If

        Dim dt As DataTable
        If NomeEmpresa.Replace("Ã", "A").Trim.Contains("CAVALAO") = True Then
            dt = CarregarDataTable("Select Codigo, Nome, Valor, UnidadeMedida, ValorCusto, Desconto, CodigoInterno from Produto Where CodigoBarra ='" & Me.txtCodPro2.Text.Trim & "'")

        Else
            dt = CarregarDataTable("Select Codigo, Nome, Valor, UnidadeMedida, ValorCusto, Desconto, CodigoInterno from Produto Where CodigoInterno ='" & Me.txtCodPro2.Text.Trim & "' or CodigoBarra ='" & Me.txtCodPro2.Text.Trim & "'")

        End If
        If dt.Rows.Count > 0 Then

            If bolTamanhoNoCodigo = False Then
                TamanhoProd(dt.Rows(0).Item("Codigo").ToString)
            End If
            Me.txtCodPro2.Tag = dt.Rows(0).Item("Codigo").ToString
            Me.txtNomePro2.Text = dt.Rows(0).ItemArray(1).ToString

            Me.txtQtd2.ToolTipTitle = dt.Rows(0).ItemArray(3).ToString

            Me.txtCodPro2.Text = dt.Rows(0).Item("CodigoInterno").ToString

            bolAbriuProduto = True
            Me.txtQtd2.Text = "1"
            Me.txtQtd2.Focus()
        Else

            Me.txtTamanho2.ResetText()
            Me.txtCodPro2.ResetText()
            Me.txtCodPro2.Focus()
            Me.txtCodPro2.Tag = ""
            Me.txtNomePro2.ResetText()
            Me.txtQtd2.ToolTipTitle = "UNIDADE"
            Exit Sub
        End If
    End Sub

    Private Sub btnRemover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemover.Click

        If Validar(Me.txtCodPro2) = False Then Exit Sub
        If Validar(txtNomePro2) = False Then Exit Sub
        If Validar(txtTamanho2) = False Then Exit Sub
        If Validar(txtQtd2) = False Then Exit Sub

        If txtQtd2.Text = "0" Or txtQtd2.Text = "0,000" Or txtQtd2.Text = "0,00" Then MsgBox("Não é pertido remover a quantidade < " & txtQtd2.Text & " > no pedido!", MsgBoxStyle.Exclamation) : txtQtd2.Focus() : txtQtd2.ResetText() : Exit Sub

        If grd1.RowCount = 0 Then MsgBox("O pedido não possui produtos adicionados!", MsgBoxStyle.Information) : Exit Sub

        Dim I As Integer

        Dim strProTam, strProTamLinha As String
        Dim dblQtd, dblQtdLinha As Double
        Dim bolTem As Boolean = False

        strProTam = Me.txtCodPro2.Text.Trim & "-" & Me.txtTamanho2.Text.Trim
        dblQtd = Me.txtQtd2.Text.Trim

        For I = 0 To grd1.RowCount - 1

            strProTamLinha = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoPeca).Trim & "-" & Me.grd1.GetRowCellDisplayText(I, Me.colTamanho).Trim

            If strProTamLinha = strProTam Then

                dblQtdLinha = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)

                If dblQtdLinha = dblQtd Then
                    bolTem = True
                    strItensDeletado &= grd1.GetRowCellDisplayText(I, Me.colCodPedAut) & "|"
                    Me.grd1.DeleteRow(I)
                    Exit For
                End If

                If dblQtdLinha < dblQtd Then
                    bolTem = True
                    MsgBox("Não existe essa quantidade do produto no pedido!", MsgBoxStyle.Information)
                    Exit For
                End If

                If dblQtdLinha > dblQtd Then
                    bolTem = True
                    dblQtdLinha = dblQtdLinha - dblQtd
                    Me.grd1.SetRowCellValue(I, colQtd, dblQtdLinha.ToString("0.000"))
                    Exit For
                End If

            End If
        Next

        Me.txtTamanho2.ResetText()
        txtNomePro2.ResetText()
        txtQtd2.ResetText()
        Me.txtCodPro2.Tag = ""
        Me.txtQtd2.ToolTipTitle = "UNIDADE"
        Me.txtCodPro2.ResetText()
        Me.txtCodPro2.Focus()

        If bolTem = False Then
            MsgBox("Produto não localizado no pedido!", MsgBoxStyle.Information)
        Else
            Calcular()
        End If

    End Sub

    Private Sub txtMedidaA_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMedidaA.Leave
        CalcularMedidas()
    End Sub

    Private Sub txtMedidaB_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMedidaB.Leave
        CalcularMedidas()
    End Sub
    Private Sub CalcularMedidas()

        If bolGaxeta = False Then Exit Sub

        If Me.txtMedidaA.Text = "" Then Exit Sub
        If Me.txtMedidaB.Text = "" Then Exit Sub
        If Me.txtQtd.Text = "" Then Exit Sub


        Dim dblMedidaA As Double = Me.txtMedidaA.Text
        Dim dblMedidaB As Double = Me.txtMedidaB.Text


        Dim dblResul As Double = dblMedidaA + dblMedidaB
        dblResul = dblResul * 2

        Me.txtQtdMedida.Text = dblResul.ToString("0.000")

        Me.txtValor.Text = (dblResul * dblUniSemDescOriginal).ToString("0.00")

        If CDbl(Me.txtValor.Text) < ValorMinimoGaxeta Then
            Me.txtValor.Text = ValorMinimoGaxeta.ToString("0.00")
        End If

    End Sub

    Private Sub txtQtd_Leave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtd.Leave
        CalcularMedidas()
    End Sub

    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub

End Class