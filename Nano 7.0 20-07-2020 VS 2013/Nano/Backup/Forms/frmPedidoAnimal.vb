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
Public Class frmPedidoAnimal
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
    Dim intCodCli As Integer
    Dim strCodigoAtivo As String
    Dim strCodigoPadrao As String
    Dim strCodigoPedidoAtivo As String
    Dim bolPromocao As Boolean = False
    Dim dblUniSemDesc As Double
    Dim dblTotalComDesconto As Double
    Dim dblTotalSemDesconto As Double
    Dim bolNegrito As Boolean = False
    Dim bolItalico As Boolean = False
    Dim bolSublinhado As Boolean = False
    Dim nome_fonte As String
    Dim tamanho_fonte As Single
    Dim intCodAni As Integer


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
                        Salvar()
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
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "26")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If

        If e.KeyCode = Keys.F6 Then
            Me.txtDesc.Focus()
            Salvar()
        End If

        If e.KeyCode = Keys.F10 Then

            If strEstaComFocus = "txtCodPed" Then
                ConsultarPedido()
            End If

            If Me.Tag = "FATURA" Or Me.Tag = "CONSULTA" Then Exit Sub
            Select Case strEstaComFocus
                Case "txtCli"
                    AbreCliente()
                Case "txtCodPro"
                    AbrirProdutos()
                Case "txtNomeAnimal"
                    BuscaAnimal()
            End Select

        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If SkinDoUsuario = "Black" Then
            Me.lblFicha.AppearanceDisabled.ForeColor = Color.White
            Me.GroupControl1.AppearanceCaption.ForeColor = Color.White
            Me.GroupControl11.AppearanceCaption.ForeColor = Color.White
            Me.grpItens.AppearanceCaption.ForeColor = Color.White
            Me.grpVal.AppearanceCaption.ForeColor = Color.White
            Me.grdDesc.AppearanceCaption.ForeColor = Color.White
        End If
        If TesteConexao() = False Then Exit Sub
        Me.txtCodPro.Tag = ""

        If NomeEmpresa.Trim.Contains("CHOPP") = True Then
            Me.btnAtivo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If

        Me.txtValor.Enabled = AlteraPrecoPedido
        CarregarDadosLue("SELECT Codigo, Nome FROM Funcionario where Ativo ='True' and CodConfig =" & CodConfig, Me.lueFunc)
        If Me.Tag = "ALTERA" Then

            txtCodPed.Enabled = True
            txtCodPed.Focus()
            Me.Text = "Alteração de Pedido"
            PedidoGridControl.Dock = DockStyle.Fill
            Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Timer2.Start()
        ElseIf Me.Tag = "CONSULTA" Then
            bolConsulta = True
            txtCodPed.Enabled = True
            txtCodPed.Focus()
            dtData.Properties.ReadOnly = True
            Me.txtNomeAnimal.Enabled = False
            Me.txtNomeProp.Properties.ReadOnly = True
            Me.txtSexo.Properties.ReadOnly = True
            Me.txtNasc.Properties.ReadOnly = True
            Me.txtRaca.Properties.ReadOnly = True
            Me.txtID.Properties.ReadOnly = True
            Me.txtCodPro.Enabled = False
            Me.txtQtd.Properties.ReadOnly = True
            Me.txtPerDesc.Properties.ReadOnly = True
            Me.txtValor.Properties.ReadOnly = True
            Me.txtNomePro.Properties.ReadOnly = True
            Me.txtValDesc.Properties.ReadOnly = True
            Me.lueFunc.Enabled = False
            Me.txtDesconto.Properties.ReadOnly = True
            'Me.lueFunc.Properties.ReadOnly = True
            Me.rtbFicha.ReadOnly = True
            ' grpProd.Enabled = False
            Me.btnDelete.Visible = False
            btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.Text = "Consulta Pedido"

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

            Timer2.Start()
        ElseIf Me.Tag = "FATURA" Then
            txtCodPed.Enabled = True
            dtData.Properties.ReadOnly = False
            Me.btnDelete.Visible = False
            btnSalvar.Caption = "&Faturar"
            Me.txtRec.Visible = True
            Me.txtTro.Visible = True
            Me.lblTro.Visible = True
            Me.lblRec.Visible = True
            pcLinha.Visible = True
            Me.Text = "Faturamento de Pedido"
            Me.btnLimpar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.txtDesconto.Visible = False
            Me.lblDesc.Visible = False
            Me.lblValDesc.Visible = False
            Me.lblPor.Visible = False
            Me.txtValDesc.Visible = False


            txtCodPed.Focus()
            Timer2.Start()
        ElseIf Me.Tag = "CADASTRA" Then
            'Me.lueFunc.Location = New System.Drawing.Point(207, 21)
            'Me.lblVenc.Location = New System.Drawing.Point(209, 4)
            Me.lueFunc.Location = New System.Drawing.Point(68, 9)
            Me.lblVenc.Location = New System.Drawing.Point(16, 13)
            Me.lueFunc.Size = New System.Drawing.Size(374, 20)
            Me.btnConsulta.Visible = False
            Me.txtCodPed.Visible = False
            Me.lblCodPed.Visible = False

            dtData.DateTime = Date.Today

            Me.Text = "Cadastro de Pedido"
            Me.bsiVisualizar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            PedidoGridControl.Dock = DockStyle.Fill
        Else

            bolConsulta = True
            txtCodPed.Enabled = True
            dtData.Properties.ReadOnly = True

            Me.btnDelete.Visible = False
            Me.Text = "Alteração Pedido"
            txtDesc.Properties.ReadOnly = True
            txtDesconto.Properties.ReadOnly = True
            Me.txtValDesc.Properties.ReadOnly = True
            Me.txtEntrega.Properties.ReadOnly = True
            Me.PedidoGridControl.Enabled = False
            txtCodPed.Focus()

        End If
        If AlteraNomePedido = False Then
            Me.txtNomePro.Properties.ReadOnly = True
        End If

        strNomeForm = Me.Text.Trim


    
    End Sub
    Private Sub TamanhoProd()
        TamanhoDoProduto = "U"

        Dim strSql As String = "Select Tamanho, sum(Qtd) as Qtd from Qtde Where Acabou = 'False' and CodProd =" & CodigoDoProduto & " and CodConfig =" & CodConfig & " group by Tamanho"

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


    End Sub
    Private Sub Limpar(ByVal bolFocus As Boolean)
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
        Me.txtTotPeso.Text = "0.00"
        Me.txtTotal.Text = "0.00"
        ' Me.txtTotItem.Text = "0"
        Me.txtRec.ResetText()
        Me.txtTro.ResetText()
        Me.txtDesc.ResetText()
        Me.txtDesconto.ResetText()
        Me.txtValDesc.ResetText()
        Me.tbItens.Rows.Clear()
        Me.txtNomeAnimal.ResetText()
        Me.rtbFicha.ResetText()
        Me.txtRaca.ResetText()
        Me.txtSexo.ResetText()
        Me.txtNasc.ResetText()
        Me.txtID.ResetText()
        Me.txtNomeProp.ResetText()
        Me.lueFunc.EditValue = DBNull.Value
        CarregarDadosLue("SELECT Codigo, Nome FROM Funcionario where Ativo ='True' and CodConfig =" & CodConfig, Me.lueFunc)

        If bolFocus = True Then
            Me.lueFunc.Focus()
        End If

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

                        dblSomaDifDesc += dblValUni.ToString("0.00") * dblQtd

                        If I = grd1.RowCount - 1 Then


                            If dblQtd = 1 Then
                                If Me.txtValDesc.Text <> "0,00" And Me.txtValDesc.Text.Trim <> "" Then
                                    Dim strDifer As String

                                    strDifer = (dblTotalSemDesconto - CDbl(dblSomaDifDesc).ToString("0.00")).ToString("0.00")

                                    If strDifer <> Me.txtValDesc.Text Then
                                        Dim dblDifer As Double

                                        dblDifer = (CDbl(Me.txtValDesc.Text) - CDbl(strDifer)).ToString("0.00")

                                        dblValUni = dblValUni - dblDifer

                                    End If

                                End If
                            End If
                        End If
                    End If
                    Me.tbItens.Rows.Item(I).Item("ValorUnitario") = dblValUni.ToString("0.00")
                End If
            End If

            dblResul = dblValUni.ToString("0.00") * dblQtd

            Me.tbItens.Rows.Item(I).Item("ValorTotal") = dblResul.ToString("0.00")

            dblTotal += dblResul.ToString("0.00")
            dblCusto += CDbl(Me.tbItens.Rows.Item(I).Item("Custo")) * dblQtd

            If Me.tbItens.Rows.Item(I).Item("Promocao") = False Then
                dblTotSemDesc += CDbl(Me.tbItens.Rows.Item(I).Item("UniSemDesc")) * dblQtd
            End If

        Next
        Me.txtTotal.Text = dblTotal.ToString("0.00")

        dblTotalComDesconto = dblTotal.ToString("0.00")

        dblTotalSemDesconto = dblTotSemDesc.ToString("0.00")

        dblTotalDeCusto = dblCusto

        'Me.txtPorDesc.Text = Me.txtPorDesc.Text.Replace("-", "")
        'Me.txtValDesc.Text = Me.txtValDesc.Text.Replace("-", "")
        Me.txtTotPeso.Text = dblItens
        Dim dblEntrega, dblVal As Double
        If Me.txtEntrega.Text <> "" And Me.txtEntrega.Text <> "0,00" Then
            dblEntrega = Me.txtEntrega.Text
            Me.txtEntrega.Text = dblEntrega.ToString("0.00")
            dblTotal = Me.txtTotal.Text
            dblVal = dblEntrega + dblTotal
            Me.txtTotal.Text = dblVal.ToString("0.00")
        End If

    End Sub
    Private Sub DescontoComPorcentagem()

        If Me.txtTotal.Text = "0,00" Then Exit Sub

        If Me.txtDesconto.Text.Trim = "" Then
            txtDesconto.Text = "0,00"
            Me.txtValDesc.Text = "0,00"
            DescontoComValor()
            Exit Sub
        End If

        'DescontoMaior()

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
    Private Sub DescontoComValor()
        If txtValDesc.Text.Trim = "" Then txtValDesc.Text = "0,00"
        If Me.txtTotal.Text = "0,00" Then Exit Sub

        Dim dblTotal, dblValDesc, dblResul As Double

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

        Me.txtDesconto.Text = dblResul.ToString("0.00")

        If Me.txtDesconto.Text.ToUpper = "NAN (NÃO É UM NÚMERO)" Or Me.txtDesconto.Text.ToUpper = "+INFINITO" Then
            Me.txtDesconto.Text = "0,00"
            Me.txtValDesc.Text = "0,00"
        End If

        'DescontoMaior()


        If TipoDesconto = "ITENS" Then
            Calcular()
        End If


        Me.txtDesc.Focus()

    End Sub
    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If MsgBox("Deseja realmente limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Limpar(True)
        End If

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If Validar(dtData) = False Then Exit Sub
        If Validar(Me.txtCodPro) = False Then Exit Sub
        If Validar(txtNomePro) = False Then Exit Sub
        If Validar(txtQtd) = False Then Exit Sub
        If Validar(txtValor) = False Then Exit Sub

        If txtQtd.Text = "0" Or txtQtd.Text = "0,000" Or txtQtd.Text = "0,00" Then MsgBox("Não é pertido adiconar a quantidade < " & txtQtd.Text & " > no pedido!", MsgBoxStyle.Exclamation) : txtQtd.Focus() : txtQtd.ResetText() : Exit Sub

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
            DescontoComValor()


            If Me.chkAlterado.Checked = False Then
                .Add()
                Dim Index As Integer = .Count - 1

                .Item(Index).Item("CodPedAut") = "Inserir"
                .Item(Index).Item("Qtd") = txtQtd.Text.Trim
                .Item(Index).Item("CodigoProduto") = Me.txtCodPro.Tag
                .Item(Index).Item("CodigoInterno") = Me.txtCodPro.Text
                .Item(Index).Item("Produto") = txtNomePro.Text.Trim.Replace("'", "").Replace("&", "")
                .Item(Index).Item("ValorUnitario") = dblUni.ToString("0.00")
                .Item(Index).Item("ValorTotal") = dblResul.ToString("0.00")
                .Item(Index).Item("Custo") = dblResulCusto.ToString("0.00")
                .Item(Index).Item("UM") = Me.txtQtd.ToolTipTitle


                .Item(Index).Item("Excluir") = False

                .Item(Index).Item("UniSemDesc") = dblUniSemDesc.ToString("0.00")
                .Item(Index).Item("Promocao") = bolPromocao

                .Item(Index).Item("Desconto") = dblDesc.ToString("0.00")
                .Item(Index).Item("Retorno") = Me.txtRetorno.Text
            Else

                grd1.SetRowCellValue(IndexGrid, Me.colProduto, Me.txtNomePro.Text.Trim.Replace("'", "").Replace("&", ""))
                grd1.SetRowCellValue(IndexGrid, Me.colCodigoProduto, Me.txtCodPro.Tag.ToString)
                grd1.SetRowCellValue(IndexGrid, Me.colCodigoPeca, Me.txtCodPro.Text.Trim)
                grd1.SetRowCellValue(IndexGrid, Me.colQtd, Me.txtQtd.Text.Trim)
                grd1.SetRowCellValue(IndexGrid, Me.colValorUnitario, Me.txtValor.Text.Trim)
                grd1.SetRowCellValue(IndexGrid, Me.colValorTotal, dblResul.ToString("0.00"))
                grd1.SetRowCellValue(IndexGrid, Me.colCusto, dblResulCusto.ToString("0.00"))
                grd1.SetRowCellValue(IndexGrid, Me.colUM, Me.txtQtd.ToolTipTitle)


                grd1.SetRowCellValue(IndexGrid, Me.colUniSemDesc, dblUniSemDesc.ToString("0.00"))
                grd1.SetRowCellValue(IndexGrid, Me.colPromocao, bolPromocao)
                grd1.SetRowCellValue(IndexGrid, Me.colDesconto, dblDesc.ToString("0.00"))
                grd1.SetRowCellValue(IndexGrid, Me.colRetorno, Me.txtRetorno.Text)
            End If

            Me.chkAlterado.Checked = False
        End With
        Me.txtRetorno.ResetText()
        Me.txtValDesc.ResetText()
        Me.txtDesconto.ResetText()
        Me.txtPerDesc.ResetText()
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
        Calcular()
    End Sub

    Private Sub txtKm_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtCodPro.Focus()
    End Sub

    Private Sub txtKm_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub
    Private Sub Salvar()
        If Me.Tag <> "ATIVO" Then
            If Validar(Me.lueFunc) = False Then Exit Sub
            If Validar(Me.dtData) = False Then Exit Sub
            If Validar(Me.txtTotPeso) = False Then Exit Sub

            If Me.chkAlterado.Checked = True Then MsgBox("Existe um item sendo alterado, conclua a alteração antes de salvar!", MsgBoxStyle.Information) : Exit Sub

           
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


            If Me.Tag = "CADASTRA" Then
                Dim strInsert As String


                intCodFunc = Me.lueFunc.GetColumnValue("Codigo")

                Dim intCodConsig As Integer
                intCodConsig = GerarCodigoOrdens("TotalConsig", CodConfig)

                Inserir("Insert into Ordens (Tabela, Cod, CodConfig) values('TotalConsig'," & intCodConsig & "," & CodConfig & ")")

                strInsert = "Insert into TotalConsig(Data, CodCli, CodFunc, Total, Descricao, Desconto, Status, Custo, Entrega, CodConfig, CodOrdens, CodAnimal) Values('" & Me.dtData.Text.Trim & "'," & intCodCli & "," & intCodFunc & "," & Num(Me.txtTotal.Text.Trim) & ",'" & Me.txtDesc.Text.Trim.Replace("'", "").Replace("&", "") & "','" & Me.txtValDesc.Text.Trim & "|" & Me.txtDesconto.Text.Trim & "','Pendente'," & Num(dblTotalDeCusto) & ",'" & Me.txtEntrega.Text.Trim & "'," & CodConfig & "," & intCodConsig & "," & intCodAni & ")"
                Inserir(strInsert)

               Me.txtCodPed.Text = intCodConsig

                For I = 0 To grd1.RowCount - 1
                    Dim strCodigo, strCodigoPeca, strProduto, strQtd, strUnit, strTotal, strTipoProduto, strCusto, strUM, strTamanho, strUniSemDesc, strDesconto, strRetorno As String
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
                    strRetorno = Me.grd1.GetRowCellDisplayText(I, Me.colRetorno)
                    Inserir("Insert into ItensConsig (CodOrdens, Qtd, CodigoProduto, Produto, ValorUnitario, " & _
                    "ValorTotal, CodigoInterno, Custo, UM, Tamanho, CodConfig, UniSemDesc, Promocao, Desconto, Retorno, Autorizado) Values(" & _
                    "" & intCodConsig & "," & Num(strQtd) & ",'" & strCodigo & "','" & strProduto & "'," & _
                    "" & Num(strUnit) & "," & Num(strTotal) & ",'" & strCodigoPeca & "'," & Num(strCusto) & "," & _
                    "'" & strUM & "','" & strTamanho & "'," & CodConfig & "," & Num(strUniSemDesc) & ",'" & bolProm & "'," & Num(strDesconto) & ",'" & strRetorno & "','True')")
                Next


            Else

                Dim vetDelete As Array = Split(strItensDeletado, "|")

                For I = 0 To vetDelete.Length - 1
                    If vetDelete(I) <> "" And vetDelete(I).ToString.ToUpper <> "INSERIR" Then
                        Dim strDelete As String
                        strDelete = "Delete From ItensConsig where Codigo =" & vetDelete(I)
                        Excluir(strDelete)
                    End If

                Next
                vetDelete = Nothing
                strItensDeletado = ""
                Dim strUpdate As String

                For I = 0 To grd1.RowCount - 1
                    Dim strCodigo, strCodigoPeca, strProduto, strQtd, strUnit, strTotal, strTipoProduto, strCodPedAut, strCusto, strUM, strTamanho, strUniSemDesc, strDesconto, strRetorno As String
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
                    strRetorno = Me.grd1.GetRowCellDisplayText(I, Me.colRetorno)
                    If strCodPedAut = "Inserir" Then
                        grd1.SetRowCellValue(I, Me.colCodPedAut, "OK")


                        Inserir("Insert into ItensConsig (CodOrdens, Qtd, CodigoProduto, Produto, ValorUnitario, " & _
                        "ValorTotal, CodigoInterno, Custo, UM, Tamanho, CodConfig, UniSemDesc, Promocao, Desconto, Retorno, Autorizado) Values(" & _
                        "" & Me.txtCodPed.Text.Trim & "," & Num(strQtd) & ",'" & strCodigo & "','" & strProduto & "'," & _
                        "" & Num(strUnit) & "," & Num(strTotal) & ",'" & strCodigoPeca & "'," & Num(strCusto) & "," & _
                        "'" & strUM & "','" & strTamanho & "'," & CodConfig & "," & Num(strUniSemDesc) & ",'" & bolProm & "'," & Num(strDesconto) & ",'" & strRetorno & "','True')")
                    Else
                        If strCodPedAut <> "OK" Then

                            Atualizar("Update ItensConsig set CodigoProduto ='" & strCodigo & "', CodigoInterno ='" & strCodigoPeca & "', " & _
                            "Produto ='" & strProduto & "', Qtd =" & Num(strQtd) & ", ValorUnitario = " & Num(strUnit) & ", " & _
                            "ValorTotal =" & Num(strTotal) & ", Custo =" & Num(strCusto) & ", UM ='" & strUM & "', " & _
                            "Tamanho = '" & strTamanho & "', UniSemDesc = " & Num(strUniSemDesc) & ", Promocao = '" & bolProm & "', " & _
                            "Desconto = " & Num(strDesconto) & ", Retorno = '" & strRetorno & "' where Codigo = " & strCodPedAut.Trim & " And CodConfig = " & CodConfig)

                        End If

                    End If
                Next

                strUpdate = "Update TotalConsig set Data ='" & Me.dtData.EditValue & "', CodCli =" & intCodCli & ", CodFunc = " & intCodFunc & ", Total =" & Num(Me.txtTotal.Text.Trim) & ", Descricao ='" & Me.txtDesc.Text.Trim.Replace("'", "").Replace("&", "E") & "', Desconto = '" & Me.txtValDesc.Text.Trim & "|" & Me.txtDesconto.Text.Trim & "', Custo =" & Num(dblTotalDeCusto) & ", Entrega = '" & Me.txtEntrega.Text.Trim & "' where CodOrdens =" & Me.txtCodPed.Text.Trim & " and CodConfig =" & CodConfig
                Atualizar(strUpdate)

            End If

            Try

                bolSalvar = True

                Atualizar("Update animal set ficha ='" & rtbFicha.Rtf.Replace("'", "''").Replace("&", "") & "' where codigo =" & intCodAni)

                MsgBox("O Pedido " & txtCodPed.Text & " foi salvo com sucesso!", 64)

                If TemImpressora = True Then
                    If NomeEmpresa.Replace("Ã", "A").Trim.Contains("CAVALAO") = True Then
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
        Salvar()
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
        Dim dt As DataTable = CarregarDataTable("Select Data, CodCli, Total, Descricao, Desconto, Status, Custo, Entrega, CodFunc, Funcionario.Nome, CodAnimal from TotalConsig inner join Funcionario on TotalConsig.CodFunc = Funcionario.Codigo where TotalConsig.CodOrdens =" & Me.txtCodPed.Text.Trim & " and TotalConsig.CodConfig =" & CodConfig)

        If dt.Rows.Count = 0 Then MsgBox("Pedido não Cadastrado!", MsgBoxStyle.Information) : Me.txtCodPed.ResetText() : Me.txtCodPed.Focus() : Exit Sub

        If Me.Tag = "ALTERA" Then
            If dt.Rows.Item(0).Item("Status").ToString = "Faturado" Then MsgBox("Pedido já faturado, não é possivel alterá-lo!", MsgBoxStyle.Exclamation) : txtCodPed.Focus() : Exit Sub
        End If

        'CARREGA OS DADOS DE CLIENTE

        CarregarCliente(dt.Rows.Item(0).Item("CodCli").ToString)

        If dt.Rows.Item(0).Item("CodAnimal").ToString <> "" Then
            CodigoDoAnimal = dt.Rows.Item(0).Item("CodAnimal").ToString
            Dim dtAnimal As DataTable
            dtAnimal = CarregarDataTable("SELECT Nome, Codigo, Sexo, CodEletronico, convert(varchar(10),Nascimento,103) as Nascimento, Raca, CodCli, Ficha FROM Animal where Codigo = " & CodigoDoAnimal)
            If dtAnimal.Rows.Count > 0 Then
                intCodAni = CodigoDoAnimal

                Me.txtNomeAnimal.Text = dtAnimal.Rows.Item(0).Item("Nome").ToString
                Me.txtRaca.Text = dtAnimal.Rows.Item(0).Item("Raca").ToString
                Me.txtSexo.Text = dtAnimal.Rows.Item(0).Item("Sexo").ToString
                Me.txtID.Text = dtAnimal.Rows.Item(0).Item("CodEletronico").ToString
                Me.txtNasc.Text = dtAnimal.Rows.Item(0).Item("Nascimento").ToString
                Me.rtbFicha.Rtf = dtAnimal.Rows.Item(0).Item("Ficha")
                intCodAni = dtAnimal.Rows.Item(0).Item("Codigo").ToString
                intCodCli = dtAnimal.Rows.Item(0).Item("CodCLi").ToString

                Dim dtCli As DataTable
                dtCli = CarregarDataTable("SELECT Nome, Codigo FROM Cliente where Codigo = " & intCodCli)
                If dtCli.Rows.Count > 0 Then
                    Me.txtNomeProp.Text = dtCli.Rows.Item(0).Item("Nome").ToString

                End If
                Dim dtFunc As DataTable
                dtFunc = CarregarDataTable("select nome from funcionario left join totalconsig on funcionario.codigo = codfunc  where totalconsig.codigo ='" & Me.txtCodPed.Text.Trim & "' group by nome")
                If dtFunc.Rows.Count > 0 Then
                    Me.lueFunc.Text = dtFunc.Rows(0).Item("nome").ToString
                End If

            End If

        End If
       

        dtData.EditValue = Format(dt.Rows.Item(0).Item(0), "dd/MM/yyyy")
        intCodFunc = dt.Rows.Item(0).Item("CodFunc").ToString
        Me.lueFunc.Text = dt.Rows.Item(0).Item("Nome").ToString
        Me.lueFunc.ClosePopup()

        Me.txtTotal.Text = Format(dt.Rows.Item(0).Item("Total"), "0.00")
        Me.txtDesc.Text = dt.Rows.Item(0).Item("Descricao").ToString
        Dim vetDesconto As Array = Split(dt.Rows.Item(0).Item("Desconto").ToString, "|")
        Me.txtValDesc.Text = vetDesconto(0).ToString.Trim
        If vetDesconto.Length > 1 Then
            Me.txtDesconto.Text = vetDesconto(1).ToString.Trim
        End If
        If dt.Rows.Item(0).Item("Custo").ToString <> "" Then
            dblTotalDeCusto = dt.Rows.Item(0).Item("Custo").ToString
        End If
        Me.txtEntrega.Text = dt.Rows.Item(0).Item("Entrega").ToString
        'CARREGAR DADOS DE PEDIDO
        Dim dtPed As DataTable = CarregarDataTable("Select Codigo, CodOrdens, Qtd, CodigoProduto, Produto, ValorUnitario, " & _
        "ValorTotal, CodigoInterno, Custo, UM, Tamanho, UniSemDesc, Promocao, Desconto, Retorno from ItensConsig where CodOrdens = " & Me.txtCodPed.Text.Trim & " and CodConfig =" & CodConfig)

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
                .Item(I).Item("ValorUnitario") = Format(dtPed.Rows.Item(I).Item("ValorUnitario"), "0.00")
                .Item(I).Item("ValorTotal") = Format(dtPed.Rows.Item(I).Item("ValorTotal"), "0.00")
                .Item(I).Item("CodigoInterno") = dtPed.Rows.Item(I).Item("CodigoInterno").ToString
                .Item(I).Item("Tamanho") = dtPed.Rows.Item(I).Item("Tamanho").ToString
                .Item(I).Item("Retorno") = dtPed.Rows.Item(I).Item("Retorno").ToString
                If dtPed.Rows.Item(I).Item("Custo").ToString <> "" Then
                    .Item(I).Item("Custo") = dtPed.Rows.Item(I).Item("Custo").ToString
                Else
                    .Item(I).Item("Custo") = "0,00"
                End If
                .Item(I).Item("UM") = dtPed.Rows.Item(I).Item("UM").ToString

                .Item(I).Item("Excluir") = False
                If dtPed.Rows.Item(I).Item("UniSemDesc").ToString <> "" Then
                    .Item(I).Item("UniSemDesc") = dtPed.Rows.Item(I).Item("UniSemDesc").ToString
                    dblTotalSDesc += dblQtd * CDbl(dtPed.Rows.Item(I).Item("UniSemDesc").ToString)
                Else
                    .Item(I).Item("UniSemDesc") = Format(dtPed.Rows.Item(I).Item("ValorUnitario"), "0.00")
                    dblTotalSDesc += dblQtd * CDbl(dtPed.Rows.Item(I).Item("ValorUnitario"))
                End If
                dblTotalCDesc += Format(dtPed.Rows.Item(I).Item("ValorTotal"), "0.00")
                .Item(I).Item("Promocao") = dtPed.Rows.Item(I).Item("Promocao").ToString
                .Item(I).Item("Desconto") = dtPed.Rows.Item(I).Item("Desconto").ToString
            End With
        Next
        Me.txtTotPeso.Text = dblItens
        dblTotalComDesconto = dblTotalCDesc.ToString("0.00")

        dblTotalSemDesconto = dblTotalSDesc.ToString("0.00")
        Me.picFundo.Visible = False



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

            AdicionarAmbos()
            CalcularAmbos()



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
            If intCodCli = 0 Then Exit Sub
            clsImprimir.ImprimePedido(Me.txtCodPed.Text.Trim, intCodCli, Me.dtData.Text, Me.lueFunc.Text.Trim, Me.txtDesc.Text)
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
            strImpressao &= "<e><ce> Pedido Nº " & Me.txtCodPed.Text.Trim & "</ce></e>" & vbCrLf
            strImpressao &= " CÓDIGO    DESCRIÇÃO                    " & vbCrLf
            strImpressao &= "<ad>UN.    QTD.    VL UNIT R$           VL Total R$</ad>" & vbCrLf
            strImpressao &= "<tc>-</tc>" & vbCrLf

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
                strImpressao &= "<c><i>  " & strCod & "   " & strProd & "</i></c>" & vbCrLf
                Dim str As String
                str = " " & strUM & "    " & Dir(strQtd & "  X  " & strUni, 21) & Esq(strTot, 20)
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

            dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & intCodCli)

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
                iRetorno = ConfiguraModeloImpressora(1)
            End If

            iRetorno = clsBematech.IniciaPorta(PortaImpressora)


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
            strImpressao &= Dir("PEDIDO N - " & Me.txtCodPed.Text.Trim, intTamEsp) & vbCrLf
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

            dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & intCodCli)

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
            iRetorno = clsBematech.FechaPorta()
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
            strImpressao &= Dir("PEDIDO N - " & Me.txtCodPed.Text.Trim, 48) & vbCrLf
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

            dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & intCodCli)

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
              
            End Select
        Else
            Select Case chkAlterado.Checked
                Case True

                    Me.txtCodPro.BackColor = Color.Bisque
                    Me.txtNomePro.BackColor = Color.Bisque
                    Me.txtQtd.BackColor = Color.Bisque
                    Me.txtValor.BackColor = Color.Bisque
                    Me.txtPerDesc.BackColor = Color.Bisque
                    Me.txtRetorno.BackColor = Color.Bisque

                    Me.txtNomePro.Properties.AppearanceReadOnly.BackColor = Color.Bisque
                    Me.txtValor.Properties.AppearanceDisabled.BackColor = Color.Bisque
                    Me.txtPerDesc.Properties.AppearanceDisabled.BackColor = Color.Bisque


                    Me.btnAdd.Text = "Alterar"
                    Me.btnAdd.Image = My.Resources.Alterar
                Case False
                    Me.txtRetorno.BackColor = Color.White

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
            DescontoComValor()
        End If

        Me.txtDesc.Focus()
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

        Dim dtProd As DataTable

        dtProd = CarregarDataTable("SELECT CodigoInterno, CodigoBarra, Nome, Valor, UnidadeMedida, ValorCusto, Desconto FROM Produto where Codigo = " & CodigoDoProduto)
        TamanhoProd()

        If dtProd.Rows.Count > 0 Then
            Me.txtCodPro.Tag = CodigoDoProduto

            If NomeEmpresa.Replace("Ã", "A").Trim.Contains("CAVALAO") = True Then
                If dtProd.Rows.Item(0).Item("CodigoBarra").ToString <> "" Then
                    Me.txtCodPro.Text = dtProd.Rows.Item(0).Item("CodigoBarra").ToString
                Else
                    Me.txtCodPro.Text = dtProd.Rows.Item(0).Item("CodigoInterno").ToString
                End If

            Else
                Me.txtCodPro.Text = dtProd.Rows.Item(0).Item("CodigoInterno").ToString
            End If

            Me.txtNomePro.Text = dtProd.Rows.Item(0).Item("Nome").ToString
            Me.txtValor.Text = Format(dtProd.Rows.Item(0).Item("Valor"), "0.00")
            dblUniSemDesc = Format(dtProd.Rows.Item(0).Item("Valor"), "0.00")
            If dtProd.Rows.Item(0).Item("Desconto").ToString <> "" And dtProd.Rows.Item(0).Item("Desconto").ToString <> "0" And dtProd.Rows.Item(0).Item("Desconto").ToString <> "0,000" And dtProd.Rows.Item(0).Item("Desconto").ToString <> "0,00" Then
                Dim dblPerDesc As Double = dtProd.Rows.Item(0).Item("Desconto").ToString
                Dim dblUni As Double = Me.txtValor.Text
                Dim dblResto As Double = (dblUni / 100) * dblPerDesc

                dblUni = dblUni - dblResto
                Me.txtValor.Text = dblUni.ToString("0.00")

                bolPromocao = True
                Me.txtPerDesc.Enabled = False
                Me.txtValor.Enabled = False
                Me.txtPerDesc.Text = dblPerDesc.ToString("0.00")
            Else
                bolPromocao = False
                Me.txtPerDesc.ResetText()
                Me.txtPerDesc.Enabled = True
                Me.txtValor.Enabled = True
            End If


            txtQtd.ToolTipTitle = dtProd.Rows.Item(0).Item("UnidadeMedida").ToString
            dblValorDeCusto = dtProd.Rows.Item(0).Item("ValorCusto").ToString

            bolDecimais = True
            bolAbriuProduto = True
            Me.txtQtd.Text = "1"
            Me.txtQtd.Focus()

        Else
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
        
        End If
    End Sub

    Private Sub ConsultarPedido()

        ConsultaPedido = ""
        Dim frm As New frmConPed
        frm.Tag = Me.Tag
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
    End Sub

    Private Sub txtAlt_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlt.DoubleClick
        If grd1.FocusedRowHandle < 0 Then Exit Sub

        If Me.Tag = "CONSULTA" Or Me.Tag = "FATURA" Then Exit Sub
        Me.chkAlterado.Checked = True
        IndexGrid = grd1.FocusedRowHandle
        Me.grd1.OptionsView.ShowAutoFilterRow = False
        Me.grd1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        With grd1

            Me.txtNomePro.Text = .GetRowCellDisplayText(IndexGrid, Me.colProduto)
            Me.txtCodPro.Tag = .GetRowCellDisplayText(IndexGrid, Me.colCodigoProduto)
            Me.txtCodPro.Text = .GetRowCellDisplayText(IndexGrid, Me.colCodigoPeca)
            Me.txtQtd.Text = .GetRowCellDisplayText(IndexGrid, Me.colQtd)
            Me.txtValor.Text = .GetRowCellDisplayText(IndexGrid, Me.colValorUnitario)
            dblValorDeCusto = .GetRowCellDisplayText(IndexGrid, colCusto) / .GetRowCellDisplayText(IndexGrid, Me.colQtd)
            Me.txtQtd.ToolTipTitle = .GetRowCellDisplayText(IndexGrid, Me.colUM)
            If .GetRowCellDisplayText(IndexGrid, Me.colUniSemDesc).Trim = "" Or .GetRowCellDisplayText(IndexGrid, Me.colUniSemDesc).Trim = "0,00" Then
                dblUniSemDesc = .GetRowCellDisplayText(IndexGrid, Me.colValorUnitario)
            Else
                dblUniSemDesc = .GetRowCellDisplayText(IndexGrid, Me.colUniSemDesc)
            End If
            Me.txtRetorno.Text = .GetRowCellDisplayText(IndexGrid, Me.colRetorno)
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

    Private Sub txtValDesc_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValDesc.Leave
        Me.txtDesconto.Text = ""
        'Calcular("VALOR")

        DescontoComValor()
        Me.txtDesc.Focus()
    End Sub

    Private Sub txtCodPro_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPro.Enter
        strEstaComFocus = "txtCodPro"
    End Sub

    Private Sub txtCodPro_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodPro.Leave

        If Me.txtCodPro.Text.Trim = "" Then Exit Sub

        If bolAbriuProduto = True Then bolAbriuProduto = False : Exit Sub

        Dim vetCod As Array = Split(Me.txtCodPro.Text.Trim, "-")
        Dim bolTamanhoNoCodigo As Boolean = False
        If vetCod.Length = 2 Then
            Me.txtCodPro.Text = vetCod(0).ToString
            bolTamanhoNoCodigo = True
        End If

        Dim dt As DataTable
        If NomeEmpresa.Replace("Ã", "A").Trim.Contains("CAVALAO") = True Then
            dt = CarregarDataTable("Select Codigo, Nome, Valor, UnidadeMedida, ValorCusto, Desconto from Produto Where CodigoBarra ='" & Me.txtCodPro.Text.Trim & "'")

        Else
            dt = CarregarDataTable("Select Codigo, Nome, Valor, UnidadeMedida, ValorCusto, Desconto from Produto Where CodigoInterno ='" & Me.txtCodPro.Text.Trim & "' or CodigoBarra ='" & Me.txtCodPro.Text.Trim & "'")

        End If
        If dt.Rows.Count > 0 Then
            CodigoDoProduto = dt.Rows(0).Item("Codigo").ToString
            If bolTamanhoNoCodigo = False Then
                TamanhoProd()
            End If
            Me.txtCodPro.Tag = CodigoDoProduto
            Me.txtNomePro.Text = dt.Rows(0).ItemArray(1).ToString
            Me.txtValor.Text = Format(dt.Rows(0).Item(2), "0.00")
            dblUniSemDesc = Format(dt.Rows.Item(0).Item("Valor"), "0.00")
            If dt.Rows.Item(0).Item("Desconto").ToString <> "" And dt.Rows.Item(0).Item("Desconto").ToString <> "0" And dt.Rows.Item(0).Item("Desconto").ToString <> "0,000" And dt.Rows.Item(0).Item("Desconto").ToString <> "0,00" Then
                Dim dblPerDesc As Double = dt.Rows.Item(0).Item("Desconto").ToString
                Dim dblUni As Double = Me.txtValor.Text
                Dim dblResto As Double = (dblUni / 100) * dblPerDesc

                dblUni = dblUni - dblResto
                Me.txtValor.Text = dblUni.ToString("0.00")
                bolPromocao = True
                Me.txtPerDesc.Enabled = False
                Me.txtValor.Enabled = False
                Me.txtPerDesc.Text = dblPerDesc.ToString("0.00")

            Else
                bolPromocao = False
                Me.txtPerDesc.ResetText()
                Me.txtPerDesc.Enabled = True
                Me.txtValor.Enabled = True


            End If
            Me.txtQtd.ToolTipTitle = dt.Rows(0).ItemArray(3).ToString
            dblValorDeCusto = dt.Rows(0).ItemArray(4).ToString
            bolAbriuProduto = True
            Me.txtQtd.Text = "1"
            Me.txtQtd.Focus()
        Else
            bolPromocao = False
            Me.txtPerDesc.Enabled = True
            Me.txtValor.Enabled = True
            Me.txtCodPro.ResetText()
            Me.txtCodPro.Focus()
            Me.txtCodPro.Tag = ""
            Me.txtNomePro.ResetText()
            Me.txtValor.ResetText()
            Me.txtQtd.ToolTipTitle = "UNIDADE"
            dblValorDeCusto = 0
            Exit Sub
        End If

    End Sub

    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click
        ConsultarPedido()
    End Sub


    Private Sub txtCli_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        strEstaComFocus = "txtCli"
    End Sub

    Private Sub txtCli_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        If Me.Tag = "CONSULTA" Or Me.Tag = "FATURA" Then Exit Sub
        AbreCliente()

    End Sub

    Private Sub AbreCliente()
        Dim frm As New frmCadCliente
        frm.Tag = "PESQUISA"
        frm.ShowDialog()
        frm.Tag = ""

        If CodigoDoCliente <> Nothing Then
            CarregarCliente(CodigoDoCliente)
        End If

    End Sub

    Private Sub CarregarCliente(ByVal parCodCli As String)
        If parCodCli.Trim = Nothing Then Exit Sub
        Dim dt As DataTable = CarregarDataTable("Select Nome, Telefone, Fax, Email, Observacao from Cliente Where Codigo =" & parCodCli)
        intVencDias = 0
        If dt.Rows.Count > 0 Then
            intCodCli = parCodCli
            NomeDoCliente = dt.Rows.Item(0).ItemArray(0).ToString
            Me.txtDesc.Text = dt.Rows.Item(0).Item("Observacao").ToString
        End If
        Me.txtCodPro.Focus()
    End Sub

    Private Sub txtCodPed_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodPed.Enter
        strEstaComFocus = "txtCodPed"
    End Sub


    Private Sub txtCli_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        Dim rel As New relPedAnimal

        rel.lblTitulo.Text = NomeEmpresa
        rel.lblEndereco.Text = EnderecoEmpresa
        rel.lblFones.Text = TelefoneEmpresa

        rel.picLogo.Image = LogoTipo

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
            End With
        Next

        rel.lblNome.Text = Me.txtNomeAnimal.Text
        rel.lblRaca.Text = Me.txtRaca.Text
        rel.lblSexo.Text = Me.txtSexo.Text
        rel.lblDono.Text = Me.txtNomeProp.Text
        rel.lblCodEletronico.Text = Me.txtID.Text
        rel.lblNascimento.Text = Me.txtNasc.Text


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
            rel.colUniSemDesc.Visible = False
            rel.XrTable1.Visible = False
        End If

        If AutorizacaoPedido = True Then
            rel.lblAutorizacao.Visible = False
        Else
            rel.lblAutorizacao.Text = Me.txtNomeProp.Text
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
            End With
        Next
        Dim dtCli As DataTable = CarregarDataTable("SELECT CPF, RGIE, Endereco, Bairro, Numero, Cidade, Cep, " & _
        "convert(Varchar(10),Nascimento,103) as Nascimento FROM Cliente where Codigo = " & intCodCli)
        If dtCli.Rows.Count > 0 Then
            rel.lblEnd.Text = dtCli.Rows.Item(0).Item("Endereco").ToString
            rel.lblBairro.Text = dtCli.Rows.Item(0).Item("Bairro").ToString
            rel.lblNum.Text = dtCli.Rows.Item(0).Item("Numero").ToString
            rel.lblCidade.Text = dtCli.Rows.Item(0).Item("Cidade").ToString
            rel.lblCep.Text = dtCli.Rows.Item(0).Item("Cep").ToString
            rel.lblCPF.Text = dtCli.Rows.Item(0).Item("CPF").ToString
            rel.lblRG.Text = dtCli.Rows.Item(0).Item("RGIE").ToString
            rel.lblNascimento.Text = dtCli.Rows.Item(0).Item("Nascimento").ToString

        End If
        rel.lblNome.Text = Me.txtNomeProp.Text

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

        Dim dt As DataTable = CarregarDataTable("SELECT convert(varchar(10),DataVenda,103) as DataVenda FROM TotalConsig where CodOrdens = " & Me.txtCodPed.Text & " and CodConfig = " & CodConfig & " and Status = 'Faturado'")
        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item("DataVenda").ToString <> "" Then
                rel.lblVenda.Text = dt.Rows.Item(0).Item("DataVenda").ToString
                rel.lblVenda.Visible = True
                rel.lblLabelVenda.Visible = True
            End If
        End If
        If AutorizacaoPedido = True Then
            rel.lblAutorizacao.Visible = False
            rel.lblAutorizacaoEmpresa.Visible = False
        Else
            rel.lblAutorizacao.Text = Me.txtNomeProp.Text
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

            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & "PEDIDO Nº " & Me.txtCodPed.Text.Trim & ", " & Me.txtNomeProp.Text.Trim & "','EXCLUÍDO','PEDIDO','PEDIDO','EXCLUSÃO'," & CodConfig & ")")

            Excluir("Delete from ItensConsig where CodOrdens =" & Me.txtCodPed.Text.Trim & " AND CodConfig =" & CodConfig)
            Excluir("Delete from TotalConsig where CodOrdens =" & Me.txtCodPed.Text.Trim & " AND CodConfig =" & CodConfig)
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
        dt = CarregarDataTable("SELECT Nome, Endereco, Numero, Bairro, Cidade , Estado, CPF FROM Cliente where Codigo = " & intCodCli)
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
            rel.lblEmit.Text = Me.txtNomeProp.Text.Trim
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
        Next


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
        'frmEmail.strEmailCliente = Me.txtEmail.Text.Trim.ToLower
        frmEmail.Tag = "PEDIDO"

        frmEmail.Show()
    End Sub

    Private Sub btnImprimir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImprimir.ItemClick
        Imprimir()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Me.txtCodPed.Text <> "" Then
            Me.txtCodPro.Focus()
        End If
        Timer2.Stop()
    End Sub


    Private Sub txtNomeAnimal_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtNomeAnimal.ButtonClick
        BuscaAnimal()
    End Sub

    Private Sub BuscaAnimal()

        CodigoDoAnimal = 0

        Dim frm As New frmCadAnimal
        frm.Tag = "PESQUISA"
        frm.ShowDialog()
        Dim dt As DataTable
        dt = CarregarDataTable("SELECT Nome, Codigo, Sexo, CodEletronico, convert(varchar(10),Nascimento,103) as Nascimento, Raca, CodCli, Ficha FROM Animal where Codigo = " & CodigoDoAnimal)
        If dt.Rows.Count > 0 Then
            intCodAni = CodigoDoAnimal

            Me.txtNomeAnimal.Text = dt.Rows.Item(0).Item("Nome").ToString
            Me.txtRaca.Text = dt.Rows.Item(0).Item("Raca").ToString
            Me.txtSexo.Text = dt.Rows.Item(0).Item("Sexo").ToString
            Me.txtID.Text = dt.Rows.Item(0).Item("CodEletronico").ToString
            Me.txtNasc.Text = dt.Rows.Item(0).Item("Nascimento").ToString

            Try
                Me.rtbFicha.Rtf = dt.Rows.Item(0).Item("Ficha").ToString
            Catch ex As Exception
                Me.rtbFicha.Text = dt.Rows.Item(0).Item("Ficha").ToString
            End Try

            intCodAni = dt.Rows.Item(0).Item("Codigo").ToString
            intCodCli = dt.Rows.Item(0).Item("CodCLi").ToString

            Dim dtCli As DataTable
            dtCli = CarregarDataTable("SELECT Nome, Codigo FROM Cliente where Codigo = " & intCodCli)
            If dtCli.Rows.Count > 0 Then
                Me.txtNomeProp.Text = dtCli.Rows.Item(0).Item("Nome").ToString

            End If

            InserirLinhaData()

            Me.rtbFicha.Focus()
        End If
    End Sub

 

  
    Private Function rtPadFontStyle() As FontStyle
        Dim fs As FontStyle = New FontStyle()
        If Me.btnN.Down Then
            fs = fs Or FontStyle.Bold
        End If
        If Me.btnI.down Then
            fs = fs Or FontStyle.Italic
        End If
        If btnS.down = True Then
            fs = fs Or FontStyle.Underline
        End If
        Return fs
    End Function
    Dim strEstilo As String
    Private modified_Renamed As Boolean
    Private open_Renamed As Boolean

    Private docName_Renamed As String
    Private currentCursor As Cursor

    Protected Property DocName() As String
        Get
            Return docName_Renamed
        End Get
        Set(ByVal value As String)
            If value <> docName_Renamed Then
                docName_Renamed = value
            End If
        End Set
    End Property

    Protected Property Open() As Boolean
        Get
            Return open_Renamed
        End Get
        Set(ByVal value As Boolean)
            If value <> open_Renamed Then
                open_Renamed = value
                Me.rtbFicha.HideSelection = Not open_Renamed
            End If
        End Set
    End Property

    Protected Sub InitFormat()
        btnN.Down = SelectFont.Bold
        btnI.down = SelectFont.Italic
        btnS.down = SelectFont.Underline
        'Select Case rtbTexto.SelectionAlignment
        '    Case HorizontalAlignment.Left
        '        btnLe.Checked = True
        '    Case HorizontalAlignment.Center
        '        btnCe.Down = True
        '    Case HorizontalAlignment.Right
        '        btnRi.Down = True
        'End Select
    End Sub

    Protected Sub rtPadClear()
        RefreshForm(True)
        Me.rtbFicha.SelectionBullet = False
        Me.rtbFicha.SelectionProtected = False
        Me.rtbFicha.Clear()
        Me.rtbFicha.ClearUndo()
        Me.rtbFicha.Focus()
        RefreshForm(False)
    End Sub

    Protected ReadOnly Property SelectFont() As Font
        Get
            If Not Me.rtbFicha.SelectionFont Is Nothing Then
                Return Me.rtbFicha.SelectionFont
            End If
            Return Me.rtbFicha.Font
        End Get
    End Property
    Protected Sub RefreshForm(ByVal b As Boolean)
        If b Then
            currentCursor = Windows.Forms.Cursor.Current
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Refresh()
        Else
            Windows.Forms.Cursor.Current = currentCursor
        End If
    End Sub

    Private Sub btnN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub BarButtonItem25_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnN.ItemClick
        strEstilo = "N"
        Me.rtbFicha.SelectionFont = New Font(SelectFont.FontFamily.Name, SelectFont.Size, rtPadFontStyle())

    End Sub

    Private Sub btnI_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnI.ItemClick
        strEstilo = "I"
        rtbFicha.SelectionFont = New Font(SelectFont.FontFamily.Name, SelectFont.Size, rtPadFontStyle())
    End Sub

    Private Sub btnS_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnS.ItemClick
        strEstilo = "S"
        rtbFicha.SelectionFont = New Font(SelectFont.FontFamily.Name, SelectFont.Size, rtPadFontStyle())
    End Sub

    Private Sub txtNomeAnimal_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNomeAnimal.Enter
        strEstaComFocus = "txtNomeAnimal"
    End Sub

    Private Sub txtNomeAnimal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNomeAnimal.KeyPress, txtRaca.KeyPress, txtSexo.KeyPress, txtNasc.KeyPress, txtID.KeyPress, txtNomeProp.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtPerDesc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPerDesc.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            If Not e.KeyChar = Chr(Keys.Back) Then
                If Not e.KeyChar = "," Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub btnMax_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMax.ItemClick
        If Me.btnMax.Tag = "MAX" Then
            Me.btnMax.Tag = "MIN"

            Me.Controls.Add(Me.PanelControl3)
            Me.GroupControl1.Visible = False
            Me.btnMax.Glyph = Global.Nano.My.Resources.Resources.kwin18x18
            Me.PanelControl3.BringToFront()
            Me.PanelControl3.Dock = DockStyle.Top
            Me.PanelControl3.Size = New System.Drawing.Size(1001, 280)

            Dim sTooltip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim args As DevExpress.Utils.SuperToolTipSetupArgs = New DevExpress.Utils.SuperToolTipSetupArgs
            args.Contents.Text = "Restaurar Tamanho Original"
            args.Contents.Font = New System.Drawing.Font("Tahoma", 8.25, FontStyle.Bold, GraphicsUnit.Point)
            sTooltip2.Setup(args)
            Me.btnMax.SuperTip = sTooltip2
        Else
            Me.btnMax.Tag = "MAX"
            Me.btnMax.Glyph = Global.Nano.My.Resources.Resources.kpersonalizer18x18
            Me.GroupControl1.Controls.Add(Me.PanelControl3)

            Me.GroupControl1.Visible = True
            Me.PanelControl3.Dock = DockStyle.Bottom
            Me.PanelControl3.Size = New System.Drawing.Size(1001, 191)

            Dim sTooltip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim args As DevExpress.Utils.SuperToolTipSetupArgs = New DevExpress.Utils.SuperToolTipSetupArgs
            args.Contents.Text = "Maximizar"
            args.Contents.Font = New System.Drawing.Font("Tahoma", 8.25, FontStyle.Bold, GraphicsUnit.Point)
            sTooltip2.Setup(args)
            Me.btnMax.SuperTip = sTooltip2
        End If
    End Sub

    Private Sub btnLinha_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLinha.ItemClick
        Dim strLinha As String = "_____________________________________________________________________________________________________________________________\par" & vbCrLf
        strLinha &= "\par" & vbCrLf
        strLinha &= "}"
        Dim intLinhas As Integer = Me.rtbFicha.Lines.Length

        Dim strTeste As String = Me.rtbFicha.Rtf
        Dim I As Integer
        Dim strChar As String

        For I = 0 To strTeste.Length
            strChar = strTeste.Substring(strTeste.Length - 1)
            strTeste = strTeste.Substring(0, strTeste.Length - 1)

            If strChar = "}" Then
                Exit For
            End If
        Next

        'If intLinhas > 0 Then
        '    Dim strtt As String = Me.rtbFicha.Lines.GetValue(intLinhas - 1)

        '    If strtt = "" Then
        '        Me.rtbFicha.Text = Me.rtbFicha.Text & strLinha
        '    Else
        '        Me.rtbFicha.Text = Me.rtbFicha.Text & vbCrLf & strLinha
        '    End If
        'Else
        '    Me.rtbFicha.Text = Me.rtbFicha.Text & strLinha
        'End If
        Me.rtbFicha.Rtf = strTeste & strLinha
        Me.rtbFicha.SelectionStart = Me.rtbFicha.TextLength

    End Sub

    Private Sub InserirLinhaData()
        
        Dim culture As New CultureInfo("pt-BR")
        Dim dtfi As DateTimeFormatInfo = culture.DateTimeFormat
        Dim dia As Integer = Date.Today.Day
        Dim ano As Integer = Date.Today.Year
        Dim mes As String = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Month))
        Dim strData As String = dia & " de " & mes & " de " & ano & vbCrLf

        Dim strLinha As String = "_____________________________________________________________________________________________________________________________\par" & vbCrLf
        Dim strEspaço As String = "                                                                     "
        strLinha &= strEspaço & strEspaço & strEspaço & "  \b " & strData & "\b0\par" & vbCrLf
        strLinha &= "\par" & vbCrLf
        strLinha &= "}"
        Dim strTeste As String = Me.rtbFicha.Rtf
        Dim I As Integer
        Dim strChar As String

        '\b 9 de Mar\'e7o de 2015\b0\par

        For I = 0 To strTeste.Length
            strChar = strTeste.Substring(strTeste.Length - 1)
            strTeste = strTeste.Substring(0, strTeste.Length - 1)

            If strChar = "}" Then
                Exit For
            End If
        Next

        'Dim intLinhas As Integer = Me.rtbFicha.Lines.Length
        'If intLinhas > 0 Then
        '    Dim strtt As String = Me.rtbFicha.Lines.GetValue(intLinhas - 1)

        '    If strtt = "" Then
        '        Me.rtbFicha.Text = Me.rtbFicha.Text & strLinha
        '        Me.rtbFicha.Text = Me.rtbFicha.Text & strData
        '    Else
        '        Me.rtbFicha.Text = Me.rtbFicha.Text & vbCrLf & strLinha
        '        Me.rtbFicha.Text = Me.rtbFicha.Text & strData
        '    End If
        'Else
        '    Me.rtbFicha.Text = Me.rtbFicha.Text & strLinha
        '    Me.rtbFicha.Text = Me.rtbFicha.Text & strData
        'End If
        Me.rtbFicha.Rtf = strTeste & strLinha
        Me.rtbFicha.SelectionStart = Me.rtbFicha.TextLength
    End Sub

    Private Sub txtRetorno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRetorno.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

End Class