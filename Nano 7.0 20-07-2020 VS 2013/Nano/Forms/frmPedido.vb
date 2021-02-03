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

Public Class frmPedido
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
    Dim dblUniSemDescOriginal As Double

    Dim dblTotalComDesconto As Double
    Dim dblTotalSemDesconto As Double

    Dim dtStartData As Date
    Dim strDescricao As String
    Dim strLembrete As String

    Dim bolTimer2 As Boolean
    Dim bolGaxeta As Boolean = False

    Dim strDescontoCliente As String = ""
    Dim strDescontoPromocao As String = ""

    Dim strTipoProduto As String = ""

    Dim strComanda As String = ""

    Dim bolMensagemDesconto As Boolean = False

    Dim bolDigQtd As Boolean = False
    Dim bolAutorizado As Boolean
    Dim strObsTemp As String
    Dim strDefeiTemp As String


    Dim strNomeClienteAlt As String
    Dim intQtdItensAlt As Integer
    Dim strObservacaoAlt As String

    Dim strCodOrdemAlt As String

    Dim bolVincularUser As Boolean = False

    Dim strVinculoCodFunc As String = ""
    Dim bolF4 As Boolean = False

    Dim strLocacao As String
    Dim dblQtdEmb As Double
    Dim frmPro As New frmConProduto
    Dim ConProdAberto As Boolean = False
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

        If Me.Tag = "ALTERA" Or Me.Tag = "FATURA" Then
            'If grd1.RowCount = 0 Then Exit Sub
            If strCodOrdemAlt <> "" Then
                Atualizar("UPDATE TotalConsig SET UsuarioAlt = '' where CodOrdens = " & strCodOrdemAlt & " and CodConfig = " & CodConfig)
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
                    Else
                        If strItensDeletado <> "" Then
                            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                                               "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & "," & _
                                               "'ITENS SELECIONADO PARA EXCLUIR, POREM NÃO SALVOU O PEDIDO','" & strItensDeletado & "','ITENS PEDIDO','PEDIDO'," & _
                                               "'ALTERAÇÃO NO PEDIDO " & Me.txtCodPed.Text.Trim & "'," & CodConfig & ")")
                        End If
                    End If

                End If
            End If
        End If
        If TemBalanca = True Then
            If PortaAberta = True Then
                clsToledoPrix.FechaPorta()
                PortaAberta = False
            End If
        End If

        strStatusPed = "Pendente"

        frmPro.Close()
        frmPro.Dispose()
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

        If e.KeyCode = Keys.F7 Then
            'If Me.Tag = "CONSULTA" Or Me.Tag = "FATURA" Then Exit Sub
            'AbreCliente("PESQUISA")
            Me.XtraTabControl1.SelectedTabPageIndex = 0
            Me.txtCli.Focus()
        End If
        If e.KeyCode = Keys.F2 Then
            'If Me.Tag = "CONSULTA" Or Me.Tag = "FATURA" Then Exit Sub
            'AbreCliente("PESQUISA")
            Me.XtraTabControl1.SelectedTabPageIndex = 1
            Me.txtCodPro.Focus()
        End If
        If e.KeyCode = Keys.F4 Then
            'If Me.Tag = "CONSULTA" Or Me.Tag = "FATURA" Then Exit Sub
            'AbreCliente("PESQUISA")
            If Me.XtraTabControl1.SelectedTabPageIndex <> 1 Then
                Me.XtraTabControl1.SelectedTabPageIndex = 1
                bolF4 = True
            Else
                bolF4 = False
            End If

            Me.txtNomePro.Focus()

        End If
        If e.KeyCode = Keys.F10 Then

            If strEstaComFocus = "txtCodPed" Then
                ConsultarPedido()
            End If

            If Me.Tag = "FATURA" Or Me.Tag = "CONSULTA" Then Exit Sub
            Select Case strEstaComFocus
                Case "txtCli"
                    AbreCliente("PESQUISA")
                Case "txtCodPro"
                    AbrirProdutos()
                Case "txtCodPro2"
                    RemoverProdutos()
                Case "txtPlaca"
                    AbreCliente("VEICULO")
                    If Me.txtPlaca.Text <> "" Then
                        Me.txtKm.Focus()
                    End If

            End Select

        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConProdAberto = False
        If NomeEmpresa.ToUpper.Contains("LDN AUTO") = True Then
            Limpar(True)
        End If
       
        If TipoNano <> 5 Then
            Me.grdDesc.Size = New System.Drawing.Size(796, 63)
            Me.grpVeiculo.Visible = False
            Me.txtPlaca.Visible = False
            Me.txtMod.Visible = False
            Me.txtAno.Visible = False
            Me.txtNivCom.Visible = False
            Me.txtMotor.Visible = False
            Me.txtCor.Visible = False
            Me.txtKm.Visible = False
            Me.txtKMSaida.Visible = False
            Me.btnCadCar.Visible = False
            Me.LabelControl5.Visible = False
            'Me.PanelControl3.Visible = False

            Me.lblPlaca.Visible = False
            Me.lblModelo.Visible = False
            Me.lblCor.Visible = False
            Me.lblAno.Visible = False
            Me.lblNivelComb.Visible = False
            Me.lblMotor.Visible = False
            Me.lblKMEntrada.Visible = False
            Me.lblKMSaida.Visible = False

            Me.luePlaca.Visible = False

            Me.LabelControl6.Visible = False
            Me.cboCodFunc.Visible = False

            Me.btnTermo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnProcesso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnChekList.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'Me.BarButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            Me.btnCadSeg.Visible = False
            Me.lblSeg.Visible = False
            Me.txtSeguradora.Visible = False
            Me.lblSin.Visible = False
            Me.txtSinistro.Visible = False

            Me.colAutorizado.Visible = False
            Me.colAutorizado1.Visible = False
            Me.colAutorizado2.Visible = False

            Me.rdgTipoProd.Visible = False
            CarregarDadosLue("SELECT Codigo, Nome FROM Funcionario where Ativo ='True' and CodConfig =" & CodConfig, Me.lueFunc)

        Else
            'Me.lblVenc.Visible = False
            'Me.lueFunc.Visible = False
            Me.picFundo.EditValue = Global.Nano.My.Resources.Resources.NANOAutomotivo
            Me.PictureEdit1.EditValue = Global.Nano.My.Resources.Resources.NANOAutomotivo
            Me.PictureEdit2.EditValue = Global.Nano.My.Resources.Resources.NANOAutomotivo
            Me.lblRetirada.Visible = False
            Me.lblEntrega.Visible = False
            Me.colAutorizado.OptionsColumn.ReadOnly = False
            If SemCarro = True Then
                Me.txtMod.Properties.ReadOnly = False
                Me.txtCor.Properties.ReadOnly = False
                Me.txtAno.Properties.ReadOnly = False
            End If

            Me.NanoCampo3.Visible = False
            Me.LabelControl14.Visible = False
            CarregarDadosLue("SELECT Codigo, Nome FROM Usuario where Inativo = 'False' and CodConfig =" & CodConfig, Me.lueFunc)
            Me.lueFunc.Text = UserNano
        End If

        If Funilaria = False Then

            Me.lblSeg.Visible = False
            Me.lblSin.Visible = False
            Me.txtSeguradora.Visible = False
            Me.txtSinistro.Visible = False
            Me.btnCadSeg.Visible = False
            Me.btnTermo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnProcesso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnChekList.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        End If

        Me.txtValor.CasasDecimais = CasaDecimal
        If TemBalanca = True Then
            Try
                clsToledoPrix.FechaPorta()
            Catch ex As Exception
            End Try
        End If
        If SkinDoUsuario = "Blue" Or SkinDoUsuario = "Money Twins" Then
            Me.cboTabela.BackColor = Color.AliceBlue

        Else
            Me.cboTabela.BackColor = Color.WhiteSmoke

        End If

        If CNPJEmpresa = "15042566000153" Then
            'ESSENCIAL
            Me.tbItens.Columns("CodigoInterno").DataType = System.Type.GetType("System.Int32")
            Me.colCodigoPeca.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        End If

        If ComandaPedido = True Then
            Me.lblComanda.Visible = True
            Me.txtComanda.Visible = True

        End If

        If TesteConexao() = False Then Exit Sub
        Me.txtCodPro.Tag = ""

        If NomeEmpresa.Trim.Contains("CHOPP") = True Then
            Me.btnAtivo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If

        If BaixaPorLote = False Then
            Me.colTamanho.Visible = False
            Me.txtTamanho.Visible = False
            Me.lblTamanho.Visible = False
            Me.txtTamanho2.Visible = False
            Me.lblTamanho2.Visible = False
            Me.txtNomePro.Size = New System.Drawing.Size(503, 20)
            Me.txtNomePro2.Size = New System.Drawing.Size(503, 20)
        End If

        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)

        Me.pnlProduto.Dock = DockStyle.Fill
        Me.tabAtivo.Visible = False

        Me.txtValor.Enabled = AlteraPrecoPedido

       
        CarregarDadosLue("Select Codigo as Cod, Nome from Funcionario where Ativo = 'True' and codconfig = " & CodConfig, Me.cboCodFunc)

        Me.NanoCampo1.CasasDecimais = CasaDecimal

        If Me.Tag = "ALTERA" Then
            If TipoNano = 5 Then
                Me.SimpleButton1.Visible = True
                Me.SimpleButton2.Visible = True
                Me.SimpleButton2.Location = New Point(287, 0)
            End If

            txtCodPed.Enabled = True
            txtCodPed.Focus()
            Me.Text = "Alteração de Pedido"
            'PedidoGridControl.Dock = DockStyle.Fill
            Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Timer2.Start()

            Me.cboTabela.Visible = True
            PreencherCombo2("Select Grupo.Nome From Grupo Inner Join TabelaPreco on Grupo.Codigo = TabelaPreco.CodTabela Where " & _
            "Grupo.Tipo ='T' Group by Grupo.Nome, Grupo.Codigo Order by Grupo.Codigo", Me.cboTabela, 0, "PADRÃO")

        ElseIf Me.Tag = "CONSULTA" Then
            If TipoNano = 5 Then
                Me.SimpleButton2.Visible = True
                Me.SimpleButton2.Location = New Point(85, 0)
            End If

            Me.txtComanda.Properties.ReadOnly = True
            bolConsulta = True
            txtCodPed.Enabled = True
            txtCodPed.Focus()
            dtData.Properties.ReadOnly = True
            dtRetirada.Properties.ReadOnly = True
            dtEntrega.Properties.ReadOnly = True
            ' grpProd.Enabled = False
            txtCli.Properties.ReadOnly = True
            ' Me.btnDelete.Visible = False
            Me.btnDelete.Enabled = False
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnVender.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.Text = "Consulta Pedido"

            txtDesc.Properties.ReadOnly = True
            Me.txtProbVeiculo.Properties.ReadOnly = True
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
            Me.cboGrp.Properties.ReadOnly = True
            Me.cboGrp.BackColor = Color.White
            Me.btnCadGrp.Enabled = False

            Me.txtPlaca.Properties.ReadOnly = True
            Me.txtMod.Properties.ReadOnly = True
            Me.txtAno.Properties.ReadOnly = True
            Me.txtNivCom.Properties.ReadOnly = True
            Me.txtMotor.Properties.ReadOnly = True
            Me.txtCor.Properties.ReadOnly = True
            Me.txtKm.Properties.ReadOnly = True
            Me.txtKMSaida.Properties.ReadOnly = True
            Me.txtSeguradora.Properties.ReadOnly = True
            Me.txtSinistro.Properties.ReadOnly = True
            Me.btnCadSeg.Enabled = False
            Me.rdgTipoProd.Enabled = False

            Me.txtValorFrete.Properties.ReadOnly = True
            Timer2.Start()
        ElseIf Me.Tag = "FATURA" Then
            Me.txtComanda.Properties.ReadOnly = True
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
            Me.Text = "Faturamento de Pedido"
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
            
            Me.txtValorFrete.Text = FreteMinimo.ToString("0.00")
            Me.btnMail.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.lueFunc.Location = New System.Drawing.Point(90, 12)
            Me.lblVenc.Location = New System.Drawing.Point(29, 15)
            Me.lueFunc.Size = New System.Drawing.Size(510, 20)
            Me.btnConsulta.Visible = False
            Me.txtCodPed.Visible = False
            Me.lblCodPed.Visible = False

            dtData.DateTime = Date.Today

            Me.Text = "Cadastro de Pedido"
            Me.bsiVisualizar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'PedidoGridControl.Dock = DockStyle.Fill

            If NomeEmpresa.Trim.Contains("MASTER TOLDOS") = True Then
                Me.cboStatus.SelectedIndex = 1
            End If
            CodigoDoCliente = 1
            CarregarCliente(CodigoDoCliente, False)

            Me.cboTabela.Visible = True
            PreencherCombo2("Select Grupo.Nome From Grupo Inner Join TabelaPreco on Grupo.Codigo = TabelaPreco.CodTabela Where " & _
            "Grupo.Tipo ='T' Group by Grupo.Nome, Grupo.Codigo Order by Grupo.Codigo", Me.cboTabela, 0, "PADRÃO")


            If TabelaPreco <> "" Then
                Dim dtTab As DataTable = CarregarDataTable("SELECT Codigo FROM Grupo where Tipo = 'T' and Nome = '" & TabelaPreco & "'")
                If dtTab.Rows.Count > 0 Then
                    Me.cboTabela.Text = TabelaPreco
                End If
            End If
        Else
            Me.txtComanda.Properties.ReadOnly = True
            bolConsulta = True
            txtCodPed.Enabled = True
            dtData.Properties.ReadOnly = True
            tabProd.Enabled = False
            txtCli.Properties.ReadOnly = True
            Me.btnDelete.Visible = False
            Me.Text = "Alteração Pedido"
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

            Me.cboGrp.Visible = False
            Me.btnCadGrp.Visible = False
            Me.LabelControl20.Visible = False
        End If
        If AlteraNomePedido = False Then
            Me.txtNomePro.Properties.ReadOnly = True
        End If

        strNomeForm = Me.Text.Trim

        If NomeEmpresa.Trim.Contains("RAISNER") = True Then
            Me.colCodigoPeca.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        End If

        'If Nivel = "USUÁRIO" Then
        '    Me.txtPerDesc.Properties.ReadOnly = True
        'End If
        If BloquearDescontoPorItem = True Then
            Me.txtPerDesc.Properties.ReadOnly = True
            Me.txtValDesconto.Properties.ReadOnly = True
        Else
            Me.txtPerDesc.Properties.ReadOnly = False
            Me.txtValDesconto.Properties.ReadOnly = False
        End If

        If VincularUser = True Then

            bolVincularUser = False
            Dim dtUser As DataTable = CarregarDataTable("SELECT Codigo FROM Funcionario where codUser = " & CodUser)

            If dtUser.Rows.Count > 0 Then
                If dtUser.Rows.Item(0).Item("Codigo").ToString <> "" Then
                    strVinculoCodFunc = " And TotalConsig.CodFunc =" & dtUser.Rows.Item(0).Item("Codigo").ToString

                    lueFunc.Properties.ReadOnly = False
                    lueFunc.Text = NomeFuncionario
                    Me.lueFunc.ClosePopup()
                    Me.txtCodPro.Focus()
                    lueFunc.Properties.ReadOnly = True
                    lueFunc.BackColor = Color.White
                    bolVincularUser = True
                End If
            End If

            
        End If

        Me.cboGrp.Properties.Items.Clear()
        PreencherGrupoSetorCusto("P", Me.cboGrp)

        Me.txtSeguradora.Properties.Items.Clear()
        PreencherGrupoSetorCusto("SEG", Me.txtSeguradora)

        If ExcluirPedido = False Then
            Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

        If CampoPedido <> "" Then
            Me.Label25.Text = CampoPedido
            Me.colCampoPedido.Caption = CampoPedido
            Me.colCampoPedido.Visible = True
            Me.Label25.Visible = True
            Me.NanoCampo2.Visible = True
        Else
            'CampoPedido = "Aplicação"
            'Me.Label25.Text = CampoPedido
            Me.colCampoPedido.Caption = CampoPedido
            Me.colCampoPedido.Visible = False
            Me.Label25.Visible = False
            Me.NanoCampo2.Visible = False
        End If

        strStatusPed = Me.cboStatus.Text.Trim

        If BloquearVenda = True Then
            Me.btnVender.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

        Me.lueTabelaPreco.Enabled = Me.txtValor.Enabled
        Timer1.Start()
        Timer3.Start()
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
                If dtQtd.Rows.Item(0).Item("Tamanho").ToString <> "" Then
                    TamanhoDoProduto = dtQtd.Rows.Item(0).Item("Tamanho").ToString
                Else
                    TamanhoDoProduto = "U"
                End If

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
       
        bolSalvar = False
        Me.txtValorFrete.ResetText()
        Me.txtProbVeiculo.ResetText()
        Me.chkCusto.Checked = False
        Me.txtCusto.ResetText()
        Me.txtValDesconto.ResetText()
        Me.txtEmEstoque.ResetText()
        Me.txtEmPedido.ResetText()
        Me.txtSaldoQtd.ResetText()
        Me.txtTotalGasto.ResetText()
        Me.txtDiasEmAtraso.ResetText()
        Me.txtNumCom.ResetText()
        Me.txtSalDev.ResetText()
        Me.txtUltVis.ResetText()
        Me.txtLimCli.ResetText()
        Me.txtLimiteCliente.ResetText()
        Me.txtCredito.ResetText()
        Me.txtdtCad.ResetText()
        'Me.rdgDesc.SelectedIndex = 0
        bolMensagemDesconto = False
        strComanda = ""
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
        'Me.txtTotPeso.Text = "0,00"
        Me.txtTotal.Text = "0,00"
        Me.txtTotItem.Text = "0"
        Me.txtRec.ResetText()
        Me.txtTro.ResetText()
        Me.txtDesc.ResetText()
        Me.txtDesconto.ResetText()
        Me.txtValDesc.ResetText()
        Me.txtComanda.ResetText()

        Me.NanoCampo1.ResetText()
        Me.NanoCampo1.Visible = False
        Me.LabelControl13.Visible = False
        dblQtdEmb = 0

        Me.txtCli.ResetText()
        Me.txtCPFCNPJ.ResetText()
        frmRecebimento.tbRec.Rows.Clear()
        Me.tbItens.Rows.Clear()

        Me.txtTel.ResetText()
        Me.txtFax.ResetText()

        Me.lueFunc.EditValue = DBNull.Value

        If TipoNano = 5 Then
            CarregarDadosLue("SELECT Codigo, Nome FROM Usuario where Inativo ='False' and CodConfig = " & CodConfig, Me.lueFunc)
            Me.lueFunc.Text = UserNano
        Else
            CarregarDadosLue("SELECT Codigo, Nome FROM Funcionario where Ativo ='True' and CodConfig = " & CodConfig, Me.lueFunc)
        End If
        Me.lueFunc.ClosePopup()

        Me.cboCodFunc.EditValue = DBNull.Value
        CarregarDadosLue("Select Codigo as Cod, Nome from Funcionario where Ativo = 'True' and codconfig = " & CodConfig, Me.cboCodFunc)
        Me.cboCodFunc.ClosePopup()
        Me.txtEmail.ResetText()

        If bolFocus = True Then
            If Me.Tag = "CADASTRA" Then
                Me.lueFunc.Focus()
            Else
                Me.txtCodPed.Focus()
            End If

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
        Campanha(0)
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
        Me.cboStatus.Text = "Pendente"
        Me.pnlTipoprod.Visible = False
        Me.lblTipoprod.Visible = False
        Me.lblTotalprod.Visible = False
        Me.lblTotalServ.Visible = False
        'Me.txtTotalprod.Visible = False
        'Me.txtTotalServ.Visible = False
        Me.txtTotalprod.Text = "0,00"
        Me.txtTotalServ.Text = "0,00"
        If Me.Tag = "CADASTRA" Then
            CodigoDoCliente = 1
            CarregarCliente(CodigoDoCliente, False)

        End If
        Me.cboGrp.ResetText()
        If TabelaPreco <> "" Then
            Dim dtTab As DataTable = CarregarDataTable("SELECT Codigo FROM Grupo where Tipo = 'T' and Nome = '" & TabelaPreco & "'")
            If dtTab.Rows.Count > 0 Then
                Me.cboTabela.Text = TabelaPreco
            Else
                Me.cboTabela.Text = "PADRÃO"
            End If
        Else
            Me.cboTabela.Text = "PADRÃO"
        End If
        Me.txtPlaca.ResetText()
        Me.txtMod.ResetText()
        Me.txtAno.ResetText()
        Me.txtCor.ResetText()
        Me.txtKm.ResetText()
        Me.txtMotor.ResetText()
        Me.txtNivCom.ResetText()
        Me.txtKMSaida.ResetText()

        Me.txtEntPedidos.ResetText()
        Me.txtSaiPedidos.ResetText()
        Me.txtKMPedidos.ResetText()
        Me.PictureEdit1.Visible = True
        Me.PictureEdit2.Visible = True
        If strCodOrdemAlt <> "" Then
            Atualizar("UPDATE TotalConsig SET UsuarioAlt = '' where CodOrdens = " & strCodOrdemAlt & " and CodConfig = " & CodConfig)
        End If
        Me.txtSeguradora.SelectedIndex = -1
        Me.txtSinistro.ResetText()

        Me.XtraTabControl1.SelectedTabPageIndex = 0
        Me.tabProd.SelectedTabPageIndex = 0
        Me.XtraTabControl2.SelectedTabPageIndex = 0
        If strItensDeletado <> "" Then
            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
            "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & "," & _
            "'ITENS SELECIONADO PARA EXCLUIR, POREM MUDOU PARA OUTRO PEDIDO','" & strItensDeletado & "','ITENS PEDIDO','PEDIDO'," & _
            "'ALTERAÇÃO NO PEDIDO " & strCodOrdemAlt & "'," & CodConfig & ")")
        End If
        strItensDeletado = ""
    End Sub

    Private Sub Calcular(ByVal parFrete As Boolean)
        '
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

        Dim dblTotalServico, dblTotalPeca As Double
        Dim bolTipoProduto As Boolean = False

        Dim I As Integer
        For I = 0 To Me.tbItens.Rows.Count - 1
            If Me.grd1.GetRowCellValue(I, Me.colAutorizado) = True Then

                If TipoDesconto = "ITENS" Then
                    If Me.txtDesconto.Text.Trim <> "" Then
                        Dim dblValDesconto As Double = Me.txtDesconto.Text
                        'If dblValDesconto >= 0 Then
                        If Me.tbItens.Rows.Item(I).Item("Promocao") = False Then
                            Me.tbItens.Rows.Item(I).Item("Desconto") = Me.txtDesconto.Text.Trim
                        End If
                        'End If
                        'If Me.grd1.GetRowCellValue(I, Me.colPromocao) = False Then
                        '    Me.grd1.SetRowCellValue(I, Me.colDesconto, Me.txtDesconto.Text.Trim)
                        'End If

                    End If
                End If



                'Dim Tipo As String = Me.tbItens.Rows.Item(I).Item("Tipo").ToString
                'If Tipo = "VENDA" Or Tipo = "AMBOS" Then
                '    dblTotalPeca = dblTotalPeca + CDbl(Me.tbItens.Rows.Item(I).Item("ValorTotal").ToString)
                'ElseIf Tipo = "SERVIÇO" Then
                '    dblTotalServico = dblTotalServico + CDbl(Me.tbItens.Rows.Item(I).Item("ValorTotal").ToString)
                '    bolTipoProduto = True
                'End If
            End If
        Next

        ''Me.txtTotalprod.Text = dblTotalPeca.ToString("0.00")
        ''Me.txtTotalServ.Text = dblTotalServico.ToString("0.00")

        'Me.txtValPec.Text = dblTotalPeca.ToString("0.00")
        'Me.txtMObra.Text = dblTotalServico.ToString("0.00")

        'If bolTipoProduto = True Then
        'Me.pnlTipoprod.Visible = True
        'Me.lblTipoprod.Visible = True
        'Me.lblTotalprod.Visible = True
        'Me.lblTotalServ.Visible = True
        Me.txtTotalprod.Visible = True
        Me.txtTotalServ.Visible = True
        'Else
        'Me.pnlTipoprod.Visible = False
        'Me.lblTipoprod.Visible = False
        'Me.lblTotalprod.Visible = False
        'Me.lblTotalServ.Visible = False
        'Me.txtTotalprod.Visible = False
        'Me.txtTotalServ.Visible = False
        'End If
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
        If Me.rdgDesc.SelectedIndex = 1 Then
            If Me.txtValDesc.Text <> "0,00" And Me.txtValDesc.Text.Trim <> "" Then
                If Me.txtValDesc.Text.Contains("-") = False Then
                    Me.txtValDesc.Text = "-" & Me.txtValDesc.Text
                End If
            End If
        End If
        Dim dblValSemDescCasaDecimal As Double
        Dim dblValSemDescCasaDecimalPeca As Double
        Dim dblValSemDescCasaDecimalServico As Double

        Dim dblTotLucro As Double
        For I = 0 To Me.tbItens.Rows.Count - 1
            If Me.grd1.GetRowCellValue(I, Me.colAutorizado) = True Then


                dblQtd = Me.tbItens.Rows.Item(I).Item("Qtd")
                dblValUni = Me.tbItens.Rows.Item(I).Item("ValorUnitario")


                dblItens += dblQtd

                If TipoDesconto = "ITENS" Then
                    If dblValUni > 0 Then

                        dblValUni = Me.tbItens.Rows.Item(I).Item("UniSemDesc")
                        dblPercent = 0
                        If Me.tbItens.Rows.Item(I).Item("Desconto") <> "" Then
                            If Me.rdgDesc.SelectedIndex = 1 Then
                                If Me.tbItens.Rows.Item(I).Item("Desconto").ToString.Contains("-") = False Then
                                    dblPercent = "-" & Me.tbItens.Rows.Item(I).Item("Desconto")
                                Else
                                    dblPercent = Me.tbItens.Rows.Item(I).Item("Desconto")
                                End If

                            Else
                                dblPercent = Me.tbItens.Rows.Item(I).Item("Desconto")
                            End If


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
                                If Me.rdgDesc.SelectedIndex = 1 Then
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
                                End If
                            End If

                        End If
                        Me.tbItens.Rows.Item(I).Item("ValorUnitario") = CampoValor(dblValUni)
                    End If
                End If

                'dblResul = dblValUni.ToString("0.00") * dblQtd
                dblResul = CampoValor(dblValUni) * dblQtd
                dblResul = dblResul.ToString("0.00")

                Me.tbItens.Rows.Item(I).Item("ValorTotal") = dblResul.ToString("0.00")

                dblTotal += dblResul.ToString("0.00")
                dblCusto += CDbl(Me.tbItens.Rows.Item(I).Item("Custo")) '* dblQtd

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

                Dim Tipo As String = Me.tbItens.Rows.Item(I).Item("Tipo").ToString
                If Tipo = "VENDA" Or Tipo = "AMBOS" Then
                    dblValSemDescCasaDecimalPeca += CampoValor(dblValSemDesc)
                    dblTotalPeca = dblTotalPeca + dblResul '.ToString("0.00") 'CDbl(Me.tbItens.Rows.Item(I).Item("ValorTotal").ToString)
                ElseIf Tipo = "SERVIÇO" Then
                    dblValSemDescCasaDecimalServico += CampoValor(dblValSemDesc)
                    dblTotalServico = dblTotalServico + dblResul '.ToString("0.00") 'CDbl(Me.tbItens.Rows.Item(I).Item("ValorTotal").ToString)
                    bolTipoProduto = True
                End If
            End If

        Next

        Dim dblMargem As Double = (dblTotLucro * 100) / dblCusto

        Me.colLucro.SummaryItem.DisplayFormat = dblMargem.ToString("0.00")
        ''dblTotalPeca = CorrigirCasaDecimal(dblTotalPeca, dblValSemDescCasaDecimalPeca)
        Me.txtTotalprod.Text = dblTotalPeca.ToString("0.00")
        ''dblTotalServico = CorrigirCasaDecimal(dblTotalServico, dblValSemDescCasaDecimalServico)
        Me.txtTotalServ.Text = dblTotalServico.ToString("0.00")

        dblTotal = CorrigirCasaDecimal(dblTotal, dblValSemDescCasaDecimal)
        Dim dblFrete As Double = 0
        If Me.txtValorFrete.Text <> "" Then
            dblFrete = Me.txtValorFrete.Text
        End If

        If parFrete = False Then
            If FreteMinimo > 0 Then
                dblFrete = FreteMinimo
                Me.txtValorFrete.Text = dblFrete.ToString("0.00")
                If PorcentagemFrete > 0 Then
                    Dim dblPorFrete As Double = (dblTotal * PorcentagemFrete) / 100
                    If dblPorFrete > FreteMinimo Then
                        dblFrete = dblPorFrete.ToString("0.00")
                        Me.txtValorFrete.Text = dblFrete
                    End If
                End If

            Else
                If PorcentagemFrete > 0 Then
                    Dim dblPorFrete As Double = (dblTotal * PorcentagemFrete) / 100
                    dblFrete = dblPorFrete.ToString("0.00")
                    Me.txtValorFrete.Text = dblFrete
                End If
            End If
        End If

        dblTotal += dblFrete
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


        If TipoDesconto = "TOTAL" Then
            Return parTotal
            Exit Function
        End If

        If Me.txtValDesc.Text.Trim <> "" Then
            If parValSemDesc <= 0 Then Exit Function
            Dim dblValDesc As Double = Me.txtValDesc.Text.Trim
            If dblValDesc > 0 Then

                Dim bolOk As Boolean = False
                Dim intCount As Integer = 0
                Dim dblTotalTeste As Double = parValSemDesc - dblValDesc
                Dim dblDiferenca As Double = parTotal - dblTotalTeste
                dblDiferenca = dblDiferenca.ToString("0.00")
                If TipoDesconto = "ITENS" Then


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
                Else
                    parTotal = dblTotalTeste
                End If
            End If
        End If
        Return parTotal

    End Function
    Private Sub DescontoComPorcentagem(ByVal parCarregaForm As Boolean)

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

        If parCarregaForm = False Then
            DescontoMaior()
        End If
     
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
            Calcular(True)
        End If
        Me.txtDesc.Focus()

    End Sub
    Private Sub DescontoComValor(ByVal parCarregaForm As Boolean)
        If txtValDesc.Text.Trim = "" Then
            txtValDesc.Text = "0,00"
        Else
            Dim dblVD As Double = txtValDesc.Text.Trim
            If dblVD = 0 Then
                txtValDesc.Text = "0,00"
            End If
            End If

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
        If TipoDesconto = "TOTAL" Then
            Me.txtDesconto.Text = dblResul.ToString("0.00000")
        Else
            Me.txtDesconto.Text = dblResul.ToString("0.0000")

        End If
      
            If Me.txtDesconto.Text.ToUpper = "NAN (NÃO É UM NÚMERO)" Or Me.txtDesconto.Text.ToUpper = "+INFINITO" Then
                Me.txtDesconto.Text = "0,00"
                Me.txtValDesc.Text = "0,00"
            End If

            DescontoMaior()

            If TipoDesconto = "ITENS" Then
            Calcular(True)
            Else
                Me.txtValDesc.Text = Me.txtValDesc.Text.Trim.Replace("-", "")
                Me.txtDesconto.Text = Me.txtDesconto.Text.Trim.Replace("-", "")
            End If

            If parCarregaForm = False Then
                Me.txtDesc.Focus()
            End If
    End Sub

    Private Sub RecalcularDesconto()

        Dim I As Integer
        Me.txtValDesc.ResetText()
        Me.txtDesconto.ResetText()
        For I = 0 To Me.grd1.RowCount - 1

            If Me.grd1.GetRowCellValue(I, Me.colAutorizado) = True Then


                Dim dblUni As Double = Me.grd1.GetRowCellDisplayText(I, Me.colUniSemDesc)
                Dim dblQtd As Double = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)

                If strDescontoCliente <> "" Then
                    Dim dblDesc As Double = strDescontoCliente

                    Dim dblResto As Double = (dblUni / 100) * dblDesc

                    dblUni = dblUni - dblResto
                    dblUni = dblUni.ToString("0.00")

                    Me.grd1.SetRowCellValue(I, Me.colPromocao, True)
                    Me.grd1.SetRowCellValue(I, Me.colDesconto, dblDesc)
                Else

                    Me.grd1.SetRowCellValue(I, Me.colPromocao, False)
                    Me.grd1.SetRowCellValue(I, Me.colDesconto, "")
                End If

                Dim dblResul As Double = dblQtd * dblUni

                Me.grd1.SetRowCellValue(I, Me.colValorUnitario, dblUni)
                Me.grd1.SetRowCellValue(I, Me.colValorTotal, dblResul)
            End If
        Next
        If TipoDesconto = "ITENS" Then
            Calcular(False)
        End If

    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If MsgBox("Deseja realmente limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Limpar(True)
        End If

    End Sub

    Dim bolAdd As Boolean = False
    Public Sub Adicinar()
        If Validar(dtData) = False Then Exit Sub
        If Validar(Me.txtCodPro) = False Then Exit Sub
        If Validar(txtNomePro) = False Then Exit Sub
        If Validar(txtQtd) = False Then Exit Sub
        If Validar(txtValor) = False Then Exit Sub
        If Validar(txtTamanho) = False Then Exit Sub

        If Me.NanoCampo1.Text <> "" Then
            Dim vetQtdEmb As String() = Me.NanoCampo1.Text.Split(",")
            If CInt(vetQtdEmb(1).ToString) > 0 Then
                MsgBox("Valor Qtd Emb. não pode ser fracionado!", MsgBoxStyle.Information)
                Me.NanoCampo1.Focus()
                Exit Sub
            End If
        End If

        bolAdd = True
        Me.txtValor.Focus()

        If bolGaxeta = True Then
            If Validar(Me.txtMedidaA) = False Then Exit Sub
            If Validar(Me.txtMedidaB) = False Then Exit Sub
        End If


        If TipoNano = 5 Then
            If SemCarro = False Then
                If Validar(txtPlaca) = False Then Exit Sub
            End If
            If GerarComissao = True And Me.cboCodFunc.Text.Trim = "" Then
                MsgBox("Selecione o Código do Mecânico!", MsgBoxStyle.Information) : Me.cboCodFunc.Focus() : Exit Sub
            End If
        End If

        If txtQtd.Text = "0" Or txtQtd.Text = "0,000" Or txtQtd.Text = "0,00" Then MsgBox("Não é permitido adiconar a quantidade < " & txtQtd.Text & " > no pedido!", MsgBoxStyle.Exclamation) : txtQtd.Focus() : txtQtd.ResetText() : Exit Sub


        If PermiteEstoqueZerado = False Then
            If strTipoProduto <> "SERVIÇO" And Me.cboStatus.Text = "Pendente" Then
                Dim dtPed As DataTable = CarregarDataTable("SELECT Sum(Qtd) as Qtde FROM ItensConsig left join TotalConsig " & _
                            "on ItensConsig.CodOrdens = TotalConsig.CodOrdens and ItensConsig.CodConfig = totalConsig.CodConfig where " & _
                            "CodigoProduto =" & Me.txtCodPro.Tag & " and Tamanho ='" & Me.txtTamanho.Text.Trim & "' and ItensConsig.CodConfig = " & CodConfig & " and TotalConsig.Status = 'Pendente'")
                Dim dblQtdePed As Double = 0
                If dtPed.Rows.Count > 0 Then
                    If dtPed.Rows.Item(0).Item("Qtde").ToString <> "" Then
                        dblQtdePed = dtPed.Rows.Item(0).Item("Qtde").ToString()
                    End If
                End If

                Dim strSql As String = "Select Tamanho, sum(Qtd) as Qtd from Qtde where CodProd =" & Me.txtCodPro.Tag & " and Acabou = 'False' and CodConfig =" & CodConfig & " group by Tamanho"
                Dim dtQtd As DataTable = CarregarDataTable(strSql)
                If EstoqueSomado = False Then
                    If dtQtd.Rows.Count = 0 Then
                        MsgBox("Não existem quantidades desse produto em estoque!", MsgBoxStyle.Information)
                    Else
                        Dim dtQtd2 As DataTable = CarregarDataTable("Select sum(Qtd) as Qtd from Qtde where CodProd =" & Me.txtCodPro.Tag & " and Tamanho ='" & Me.txtTamanho.Text.Trim & "' and Acabou = 'False' and CodConfig =" & CodConfig)

                        Dim dblQtdAdd As Double

                        If Me.txtQtd.Text = "" Then
                            dblQtdAdd = 1
                        Else
                            dblQtdAdd = Me.txtQtd.Text.Trim
                        End If

                        Dim dblQtdTabQtde As Double = 0

                        If dtQtd2.Rows(0).Item("Qtd").ToString() <> "" Then
                            dblQtdTabQtde = dtQtd2.Rows(0).Item("Qtd").ToString()
                        End If

                        dblQtdTabQtde = dblQtdTabQtde - dblQtdePed
                        If dblQtdTabQtde <= 0 Then
                            MsgBox("Não existem quantidades desse produto em estoque!", MsgBoxStyle.Information)
                        Else
                            If dblQtdAdd > dblQtdTabQtde Then
                                MsgBox("Não existe a quantidade adicionada desse produto em estoque!", MsgBoxStyle.Information)
                            End If
                        End If


                    End If
                Else

                    Dim dblResul As Double = AjusteQtde(CodConfig, Me.txtCodPro.Tag)
                    dblResul = dblResul - dblQtdePed
                    If dblResul <= 0 Then
                        MsgBox("Não existem quantidades desse produto em estoque!", MsgBoxStyle.Information)
                        Exit Sub
                    Else
                        Dim dblQtdAdd As Double
                        If Me.txtQtd.Text = "" Then
                            dblQtdAdd = 1
                        Else
                            dblQtdAdd = Me.txtQtd.Text.Trim
                        End If


                        If dblQtdAdd > dblResul Then
                            MsgBox("Não existe a quantidade adicionada desse produto em estoque!", MsgBoxStyle.Information)
                        End If
                    End If
                End If
            End If
        End If

        If Me.chkCusto.Checked = True Then
            If Me.txtCusto.Text <> "" Then
                dblValorDeCusto = Me.txtCusto.Text
            End If
        End If

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

            ''''''''verificar desconto
            If dblDesc > 0 And dblDesc > 0.0 Then
                bolPromocao = True
            ElseIf dblDesc < 0 And dblDesc < 0.0 Then
                bolPromocao = True
            Else
                bolPromocao = False
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
                .Item(Index).Item("Tipo") = strTipoProduto

                .Item(Index).Item("Excluir") = False

                .Item(Index).Item("UniSemDesc") = CampoValor(dblUniSemDesc)
                .Item(Index).Item("Promocao") = bolPromocao

                '.Item(Index).Item("Desconto") = dblDesc.ToString("0.00")
                .Item(Index).Item("Desconto") = CampoValor(dblDesc)


                .Item(Index).Item("MedidaA") = Me.txtMedidaA.Text

                If Me.lblMedB.Text = "P. Ant. R$" Then
                    .Item(Index).Item("ValorAnt") = Me.txtMedidaB.Text
                    .Item(Index).Item("ValorAntPorc") = Me.txtQtdMedida.Text
                Else
                    .Item(Index).Item("MedidaB") = Me.txtMedidaB.Text
                    .Item(Index).Item("QtdMedida") = Me.txtQtdMedida.Text
                End If
                .Item(Index).Item("DataAdd") = Format(Date.Today, "dd/MM/yyyy")
                .Item(Index).Item("Autorizado") = True
                .Item(Index).Item("CodigoFuncionario") = Me.cboCodFunc.Text
                '.Item(Index).Item("Lucro") = dblLucro.ToString("0.00")

                .Item(Index).Item("Locacao") = strLocacao
                .Item(Index).Item("CampoPedido") = NanoCampo2.Text

                .Item(Index).Item("TabelaPreco") = Me.cboTabela.Text
            Else

                grd1.SetRowCellValue(IndexGrid, Me.colProduto, strProduto)
                grd1.SetRowCellValue(IndexGrid, Me.colCodigoProduto, Me.txtCodPro.Tag.ToString)
                grd1.SetRowCellValue(IndexGrid, Me.colCodigoPeca, Me.txtCodPro.Text.Trim)
                grd1.SetRowCellValue(IndexGrid, Me.colQtd, Me.txtQtd.Text.Trim)
                grd1.SetRowCellValue(IndexGrid, Me.colValorUnitario, CampoValor(Me.txtValor.Text.Trim))
                grd1.SetRowCellValue(IndexGrid, Me.colValorTotal, dblResul.ToString("0.00"))
                grd1.SetRowCellValue(IndexGrid, Me.colCusto, dblResulCusto.ToString("0.00"))
                grd1.SetRowCellValue(IndexGrid, Me.colUM, Me.txtQtd.ToolTipTitle)
                grd1.SetRowCellValue(IndexGrid, Me.colTamanho, Me.txtTamanho.Text)
                grd1.SetRowCellValue(IndexGrid, Me.colTipo, strTipoProduto)

                grd1.SetRowCellValue(IndexGrid, Me.colUniSemDesc, CampoValor(dblUniSemDesc))
                grd1.SetRowCellValue(IndexGrid, Me.colPromocao, bolPromocao)
                grd1.SetRowCellValue(IndexGrid, Me.colDesconto, dblDesc.ToString("0.00"))

                grd1.SetRowCellValue(IndexGrid, Me.colMedidaA, Me.txtMedidaA.Text)
                If Me.lblMedB.Text = "P. Ant. R$" Then
                    grd1.SetRowCellValue(IndexGrid, Me.colValorAnt, Me.txtMedidaB.Text)
                    grd1.SetRowCellValue(IndexGrid, Me.colValorAntPorc, Me.txtQtdMedida.Text)
                Else
                    grd1.SetRowCellValue(IndexGrid, Me.colMedidaB, Me.txtMedidaB.Text)
                    grd1.SetRowCellValue(IndexGrid, Me.colQtdMedida, Me.txtQtdMedida.Text)
                End If
                grd1.SetRowCellValue(IndexGrid, Me.colAutorizado, bolAutorizado)
                grd1.SetRowCellValue(IndexGrid, Me.colCodigoFuncionario, Me.cboCodFunc.Text)
                'grd1.SetRowCellValue(IndexGrid, Me.colLucro, dblLucro.ToString("0.00"))

                grd1.SetRowCellValue(IndexGrid, Me.colLocacao, strLocacao)
                grd1.SetRowCellValue(IndexGrid, Me.colCampoPedido, NanoCampo2.Text)

                grd1.SetRowCellValue(IndexGrid, Me.colTabelaPreco, Me.cboTabela.Text)
            End If

            Me.chkAlterado.Checked = False
        End With

       
        strDescontoPromocao = ""
        bolMensagemDesconto = False
        Me.txtValDesc.ResetText()
        Me.txtDesconto.ResetText()

        If strDescontoCliente = "" Then
            Me.txtPerDesc.ResetText()
        Else
            Me.txtPerDesc.Text = strDescontoCliente
        End If
        Me.txtCusto.ResetText()
        Me.txtValDesconto.ResetText()
        Me.txtEmEstoque.ResetText()
        Me.txtEmPedido.ResetText()
        Me.txtSaldoQtd.ResetText()
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
        strTipoProduto = ""
        strLocacao = ""
        NanoCampo2.ResetText()
        Me.grd1.ClearColumnsFilter()
        'Dim indexFilter As Integer = -999997
        'grd1.FocusedRowHandle = indexFilter
        'grd1.SetRowCellValue(indexFilter, Me.colProduto, "")
        'grd1.SetRowCellValue(indexFilter, Me.colCodigoPeca, "")
        'grd1.SetRowCellValue(indexFilter, Me.colUM, "")
        'grd1.SetRowCellValue(indexFilter, Me.colTamanho, "")
        'grd1.SetRowCellValue(indexFilter, Me.colQtd, "")
        'grd1.SetRowCellValue(indexFilter, Me.colValorUnitario, "")
        'grd1.SetRowCellValue(indexFilter, Me.colValorTotal, "")
        bolDigQtd = False
        'grd1.ShowEditor()

        Me.NanoCampo1.ResetText()
        Me.NanoCampo1.Visible = False
        Me.LabelControl13.Visible = False
        Me.NanoCampo3.ResetText()
        Me.NanoCampo3.Visible = False
        Me.LabelControl14.Visible = False
        dblQtdEmb = 0

        Campanha(0)
        Gaxeta(0)
        Calcular(False)
        bolAdd = False

        Me.lueTabelaPreco.EditValue = DBNull.Value
        Me.lueTabelaPreco.ClosePopup()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Adicinar()

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
        If rdgDesc.SelectedIndex = 0 Then
            Calcular(True)
            If TipoDesconto = "TOTAL" Then
                DescontoComPorcentagem(True)
            End If
        End If


       
        Me.grd1.ClearColumnsFilter()
        If Me.Tag <> "ATIVO" Then
            If TipoNano <> 5 Then
                If Validar(Me.lueFunc) = False Then Exit Sub
            End If

            If Validar(Me.txtCli) = False Then Exit Sub
            If Validar(Me.dtData) = False Then Exit Sub
            'If Validar(Me.txtTotPeso) = False Then Exit Sub

            If TipoNano = 5 Then
                If SemCarro = False Then
                    If Validar(Me.txtPlaca) = False Then Exit Sub
                End If
            End If


            If Me.chkAlterado.Checked = True Then MsgBox("Existe um item sendo alterado, conclua a alteração antes de salvar!", MsgBoxStyle.Information) : Exit Sub
            If Me.txtLimite.Text.Trim <> "" Then
                If Val(Me.txtLimite.Text.Trim) < Val(Me.txtTotal.Text.Trim) Then
                    If MsgBox("O valor do Pedido excede o limite de crédito do cliente, deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        Exit Sub
                    End If
                End If
            End If

            If VerificarComanda() = False Then Exit Sub


            Dim strCli As String = ""

            strCli = Me.txtCli.Text.Trim


            txtCli.Focus()


            Dim strOperador As String = UserNano


            If TipoNano <> 5 Then
                If grd1.RowCount = 0 Then MsgBox("Não existem itens no Pedido!", 64) : Exit Sub

                intCodFunc = Me.lueFunc.GetColumnValue("Codigo")
                If bolVincularUser = True Then
                    intCodFunc = CodigoFuncionario
                End If
            Else
                strOperador = Me.lueFunc.Text
                intCodFunc = CodUser
            End If


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


            Dim strAuxiliar As String = ""
            Try
                strAuxiliar = NomeComputador.ToUpper & " Cod.User: " & CodUser & " " & Format(My.Computer.Clock.LocalTime, "dd/MM/yyyy HH:mm:ss:fffff")
            Catch ex As Exception
                strAuxiliar = NomeComputador.ToUpper & " Cod.User: " & CodUser & " " & Date.Today.Day & "/" & Date.Today.Month & "/" & Date.Today.Year & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now)
            End Try
            If Me.Tag = "CADASTRA" Then

                intCodFunc = Me.lueFunc.GetColumnValue("Codigo")
                If bolVincularUser = True Then
                    intCodFunc = CodigoFuncionario
                End If
              

                Dim intCodConsig As Integer
                'intCodConsig = GerarCodigoOrdens("TotalConsig", CodConfig)

                Inserir("Insert into Ordens (Tabela, Cod, CodConfig, Auxiliar) SELECT 'TotalConsig' as Tabela, Max(Cod) + 1, CodConfig, '" & strAuxiliar & "' as Auxiliar FROM Ordens where Tabela = 'TotalConsig' and CodConfig = " & CodConfig & " group by CodConfig")

                Dim dtOrdens As DataTable = CarregarDataTable("SELECT Cod FROM Ordens Where Tabela = 'TotalConsig' and Auxiliar = '" & strAuxiliar & "'")
                If dtOrdens.Rows.Count > 0 Then
                    intCodConsig = dtOrdens.Rows.Item(0).Item("Cod").ToString
                Else
                    MsgBox("Ocorreu um erro ao salvar o pedido!", MsgBoxStyle.Information)
                    Exit Sub
                End If
                Inserir("Insert into TotalConsig(Data, CodCli, CodFunc, Total, Descricao, Desconto, Status, " & _
                "Custo, Entrega, CodConfig, CodOrdens, Acrescimo, DataRetirada, DataEntrega, Comanda, StatusPedido, " & _
                "Placa, Modelo, Cor, Ano, Motor, NivelCombustivel, KMSaida, KMEntrada, Seguro, Sinistro, ValorFrete, AuxiliarPed, Operador) Values(" & _
                "'" & Me.dtData.Text.Trim & "'," & intCodCli & "," & intCodFunc & "," & Num(Me.txtTotal.Text.Trim) & "," & _
                "'" & Me.txtDesc.Text.Trim.Replace("'", "").Replace("&", "E").Replace("|", "") & "|" & Me.txtProbVeiculo.Text.Replace("|", "") & "','" & strValDes & "|" & strPorDesc & "'," & _
                "'" & Me.cboStatus.Text.Trim & "'," & Num(dblTotalDeCusto) & ",'" & Me.txtEntrega.Text.Trim & "'," & _
                "" & CodConfig & "," & intCodConsig & ",'" & strValAcre & "|" & strPorAcre & "','" & Me.dtRetirada.Text & "'," & _
                "'" & Me.dtEntrega.Text & "','" & Me.txtComanda.Text & "','" & Me.cboGrp.Text & "','" & Me.txtPlaca.Text.Trim & "'," & _
                "'" & Me.txtMod.Text.Trim & "','" & Me.txtCor.Text.Trim & "','" & Me.txtAno.Text.Trim & "','" & Me.txtMotor.Text.Trim & "'," & _
                "'" & Me.txtNivCom.Text.Trim & "','" & Me.txtKMSaida.Text.Trim & "','" & Me.txtKm.Text.Trim & "','" & Me.txtSeguradora.Text & "'," & _
                "'" & Me.txtSinistro.Text & "'," & Num(Me.txtValorFrete.Text) & ",'" & strAuxiliar & "','" & strOperador & "')")


                Me.txtCodPed.Text = intCodConsig

                For I = 0 To grd1.RowCount - 1
                    Dim strCodigo, strCodigoPeca, strProduto, strQtd, strUnit, strTotal, strTipoProduto, strCusto, strUM, strTamanho, strUniSemDesc, strDesconto, strMedA, strMedB, strQtdMed, strCampoPedido As String
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
                    Dim strDataAdd As String = Me.grd1.GetRowCellDisplayText(I, Me.colDataAdd)
                    Dim strCodigoFuncionario As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario)

                    Dim bolAut As Boolean = Me.grd1.GetRowCellValue(I, Me.colAutorizado)
                    strCampoPedido = Me.grd1.GetRowCellDisplayText(I, Me.colCampoPedido)

                    Dim strTabelaPreco As String = Me.cboTabela.Text
                    If TabelaPrecoPorItem = True Then
                        strTabelaPreco = Me.grd1.GetRowCellDisplayText(I, Me.colTabelaPreco)
                    End If
                    Inserir("Insert into ItensConsig (CodOrdens, Qtd, CodigoProduto, Produto, ValorUnitario, " & _
                    "ValorTotal, CodigoInterno, Custo, UM, Tamanho, CodConfig, UniSemDesc, Promocao, Desconto, " & _
                    "MedidaA, MedidaB, QtdMedida, DataAdd, CodigoFuncionario, Autorizado, CampoPedido, TabelaPreco, AuxiliarPed) Values(" & _
                    "" & intCodConsig & "," & Num(strQtd) & ",'" & strCodigo & "','" & strProduto & "'," & Num(strUnit) & "," & _
                    "" & Num(strTotal) & ",'" & strCodigoPeca & "'," & Num(strCusto) & ",'" & strUM & "','" & strTamanho & "'," & _
                    "" & CodConfig & "," & Num(strUniSemDesc) & ",'" & bolProm & "'," & Num(strDesconto) & "," & Num(strMedA) & "," & _
                    "" & Num(strMedB) & "," & Num(strQtdMed) & ",'" & strDataAdd & "','" & strCodigoFuncionario & "'," & _
                    "'" & bolAut & "','" & strCampoPedido & "','" & strTabelaPreco & "','" & strAuxiliar & "')")
                Next

                If strDescricao <> "" Then
                    Dim strCodOrdemAgenda As Integer = GerarCodigo("Agenda", "CodOrdem", CodConfig)

                    Inserir("INSERT INTO Agenda (CodOrdem, Type, StartDate, EndDate, AllDay, Subject, Location, Description, " & _
                    "Status, Label, Conta, ReminderInfo, CodConfig) VALUES (" & strCodOrdemAgenda & ",0,'" & dtStartData & "','" & dtStartData.AddHours(1) & "'," & _
                    "'False','Nº Pedido " & Me.txtCodPed.Text & "','','" & strDescricao & "',2,0,'False','" & strLembrete & "'," & CodConfig & ")")

                End If
            Else

                If Me.txtCodPed.Text = "" Then
                    MsgBox("Esta tela é para alteração de pedidos, para cadastrar feche a tela e clique no botão cadastrar!", MsgBoxStyle.Information)
                    Exit Sub
                End If


                Dim dtPedFat As DataTable = CarregarDataTable("SELECT Codigo FROM TotalConsig where CodOrdens = " & Me.txtCodPed.Text.Trim & " and CodConfig = " & CodConfig & " and Status = 'Faturado'")
                If dtPedFat.Rows.Count > 0 Then
                    If dtPedFat.Rows.Item(0).Item("Codigo").ToString <> "" Then
                        MsgBox("Pedido " & Me.txtCodPed.Text & " já faturado! Não é possivel alterar.", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                End If

                If strItensDeletado = "" Then
                    Dim strNumPedDel As String = ""
                    For I = 0 To Me.grd1.RowCount - 1
                        If I <= Me.grd1.RowCount - 1 Then
                            If Me.grd1.GetRowCellValue(I, Me.colExcluir) = True Then
                                strNumPedDel &= grd1.GetRowCellDisplayText(I, Me.colCodPedAut) & "|"
                            End If
                        End If
                    Next
                    If strNumPedDel <> "" Then
                        Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                        "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & "," & _
                        "'ITENS SELECIONADO PARA EXCLUIR, POREM NÃO CLICOU NO BOTÃO EXCLUIR','" & strNumPedDel & "','ITENS PEDIDO','PEDIDO'," & _
                        "'ALTERAÇÃO NO PEDIDO " & Me.txtCodPed.Text.Trim & "'," & CodConfig & ")")
                    End If
                End If

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
                Dim strUpdate As String = ""

                For I = 0 To grd1.RowCount - 1
                    Dim strCodigo, strCodigoPeca, strProduto, strQtd, strUnit, strTotal, strTipoProduto, strCodPedAut, strCusto, strUM, strTamanho, strUniSemDesc, strDesconto, strMedA, strMedB, strQtdMed, strTipo, strCampoPedido As String
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
                    strTipo = Me.grd1.GetRowCellDisplayText(I, Me.colTipo)
                    Dim bolProm As Boolean = Me.grd1.GetRowCellValue(I, Me.colPromocao)
                    strUniSemDesc = Me.grd1.GetRowCellDisplayText(I, Me.colUniSemDesc)
                    strDesconto = Me.grd1.GetRowCellDisplayText(I, Me.colDesconto)
                    strMedA = Me.grd1.GetRowCellDisplayText(I, Me.colMedidaA)
                    strMedB = Me.grd1.GetRowCellDisplayText(I, Me.colMedidaB)
                    strQtdMed = Me.grd1.GetRowCellDisplayText(I, Me.colQtdMedida)
                    Dim strDataAdd As String = Me.grd1.GetRowCellDisplayText(I, Me.colDataAdd)
                    Dim strCodigoFuncionario As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario)

                    Dim bolAut As Boolean = Me.grd1.GetRowCellValue(I, Me.colAutorizado)
                    strCampoPedido = Me.grd1.GetRowCellDisplayText(I, Me.colCampoPedido)

                    Dim strTabelaPreco As String = Me.cboTabela.Text
                    If TabelaPrecoPorItem = True Then
                        strTabelaPreco = Me.grd1.GetRowCellDisplayText(I, Me.colTabelaPreco)
                    End If

                    If strCodPedAut = "Inserir" Then
                        grd1.SetRowCellValue(I, Me.colCodPedAut, "OK")

                        Inserir("Insert into ItensConsig (CodOrdens, Qtd, CodigoProduto, Produto, ValorUnitario, " & _
                        "ValorTotal, CodigoInterno, Custo, UM, Tamanho, CodConfig, UniSemDesc, Promocao, Desconto, " & _
                        "MedidaA, MedidaB, QtdMedida, DataAdd, CodigoFuncionario, Autorizado, CampoPedido, TabelaPreco, AuxiliarPed) Values(" & _
                        "" & Me.txtCodPed.Text.Trim & "," & Num(strQtd) & ",'" & strCodigo & "','" & strProduto & "'," & Num(strUnit) & "," & _
                        "" & Num(strTotal) & ",'" & strCodigoPeca & "'," & Num(strCusto) & ",'" & strUM & "','" & strTamanho & "'," & _
                        "" & CodConfig & "," & Num(strUniSemDesc) & ",'" & bolProm & "'," & Num(strDesconto) & "," & _
                        "" & Num(strMedA) & "," & Num(strMedB) & "," & Num(strQtdMed) & ",'" & strDataAdd & "'," & _
                        "'" & strCodigoFuncionario & "','" & bolAut & "','" & strCampoPedido & "','" & strTabelaPreco & "','" & strAuxiliar & "')")
                    Else
                        If strCodPedAut <> "OK" Then

                            Atualizar("Update ItensConsig set CodigoProduto ='" & strCodigo & "', CodigoInterno ='" & strCodigoPeca & "', " & _
                            "Produto ='" & strProduto & "', Qtd =" & Num(strQtd) & ", ValorUnitario = " & Num(strUnit) & ", " & _
                            "ValorTotal =" & Num(strTotal) & ", Custo =" & Num(strCusto) & ", UM ='" & strUM & "', " & _
                            "Tamanho = '" & strTamanho & "', UniSemDesc = " & Num(strUniSemDesc) & ", Promocao = '" & bolProm & "', " & _
                            "Desconto = " & Num(strDesconto) & ", MedidaA =" & Num(strMedA) & ", MedidaB =" & Num(strMedB) & ", " & _
                            "QtdMedida =" & Num(strQtdMed) & ", DataAdd = '" & strDataAdd & "', " & _
                            "CodigoFuncionario = '" & strCodigoFuncionario & "', Autorizado = '" & bolAut & "', " & _
                            "CampoPedido='" & strCampoPedido & "', TabelaPreco = '" & strTabelaPreco & "' where Codigo = " & strCodPedAut.Trim & " And CodConfig = " & CodConfig)
                        End If

                    End If
                Next

                Atualizar("Update TotalConsig set Data ='" & Me.dtData.EditValue & "', CodCli =" & intCodCli & ", " & _
                "CodFunc = " & intCodFunc & ", Total =" & Num(Me.txtTotal.Text.Trim) & ", " & _
                "Descricao ='" & Me.txtDesc.Text.Trim.Replace("'", "").Replace("&", "E").Replace("|", "") & "|" & Me.txtProbVeiculo.Text.Replace("|", "") & "', " & _
                "Desconto = '" & strValDes & "|" & strPorDesc & "', Custo =" & Num(dblTotalDeCusto) & ", " & _
                "Entrega = '" & Me.txtEntrega.Text.Trim & "', Status ='" & Me.cboStatus.Text.Trim & "', " & _
                "Acrescimo = '" & strValAcre & "|" & strPorAcre & "', DataRetirada = '" & Me.dtRetirada.Text & "', " & _
                "DataEntrega = '" & Me.dtEntrega.Text & "', Comanda = '" & Me.txtComanda.Text & "', " & _
                "StatusPedido='" & Me.cboGrp.Text & "', Placa='" & Me.txtPlaca.Text.Trim & "', " & _
                "Modelo='" & Me.txtMod.Text.Trim & "', Cor='" & Me.txtCor.Text.Trim & "', " & _
                "Ano='" & Me.txtAno.Text.Trim & "', Motor='" & Me.txtMotor.Text & "', " & _
                "NivelCombustivel='" & Me.txtNivCom.Text.Trim & "', " & _
                "KMSaida='" & Me.txtKMSaida.Text.Trim & "', KMEntrada='" & Me.txtKm.Text.Trim & "', " & _
                "Seguro = '" & Me.txtSeguradora.Text & "', Sinistro = '" & Me.txtSinistro.Text & "', " & _
                "ValorFrete = " & Num(Me.txtValorFrete.Text) & " Where CodOrdens =" & Me.txtCodPed.Text.Trim & " And CodConfig =" & CodConfig)


                If strNomeClienteAlt <> Me.txtCli.Text Then
                    Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                    "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & "," & _
                    "'" & strNomeClienteAlt & "','" & Me.txtCli.Text & "','NOME CLIENTE','PEDIDO'," & _
                    "'ALTERAÇÃO NO PEDIDO " & Me.txtCodPed.Text.Trim & "'," & CodConfig & ")")
                End If
                If strObservacaoAlt <> Me.txtDesc.Text.Trim.Replace("'", "").Replace("&", "E").Replace("|", "") Then
                    Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                    "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & "," & _
                    "'" & strObservacaoAlt & "','" & Me.txtDesc.Text & "','OBSERVAÇÃO','PEDIDO'," & _
                    "'ALTERAÇÃO NO PEDIDO " & Me.txtCodPed.Text.Trim & "'," & CodConfig & ")")
                End If
                If grd1.RowCount > 0 Then
                    Dim intQtdItens As Integer = grd1.RowCount
                    If intQtdItensAlt <> intQtdItens Then
                        Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                        "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & "," & _
                        "'" & intQtdItensAlt & "','" & intQtdItens & "','Nº DE ITENS','PEDIDO'," & _
                        "'ALTERAÇÃO NO PEDIDO " & Me.txtCodPed.Text.Trim & "'," & CodConfig & ")")
                    End If
                End If

            End If

            Try

                bolSalvar = True
                If parEntrada = True Then
                    frmRecebimento.txtTotal.Text = Me.txtTotal.Text.Trim
                    frmRecebimento.txtTotal.Tag = Me.txtTotal.Text.Trim
                    frmRecebimento.txtARec.Text = Me.txtTotal.Text.Trim


                    frmRecebimento.Tag = ""
                    frmRecebimento.strCodPed = Me.txtCodPed.Text.Trim
                    frmRecebimento.intCodCliente = intCodCli
                    NomeDoCliente = Me.txtCli.Text
                    frmRecebimento.ShowDialog()
                End If
                MsgBox("O Pedido " & txtCodPed.Text & " foi salvo com sucesso!", 64)

                If TemImpressora = True Then
                    If ImprimirDireto = False Then
                        If MsgBox("Deseja imprimir o pedido?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            Imprimir()
                            If SegViaRecibo = True Then
                                If MsgBox("Deseja imprimir a segunda via?", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                    Imprimir()
                                End If
                            End If
                        End If
                    Else
                        Imprimir()
                        If SegViaRecibo = True Then
                            If MsgBox("Deseja imprimir a segunda via?", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                Imprimir()
                            End If
                        End If
                    End If

                Else
                    If MsgBox("Deseja imprimir os dados do pedido?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        EscolherImpressao(True, False)
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

        If Me.Tag = "ALTERA" Or Me.Tag = "FATURA" Then
            Atualizar("UPDATE TotalConsig SET UsuarioAlt = '' where CodOrdens = " & Me.txtCodPed.Text.Trim & " and CodConfig = " & CodConfig)
        End If
    
        Limpar(True)

        If Me.Tag = "CADASTRA" Then
            Me.Timer1.Start()

        End If
      
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

        Dim I, intCont As Integer
        Dim strNomeForm As String
        For I = 0 To My.Application.OpenForms.Count - 1
            If I = My.Application.OpenForms.Count Then Exit For
            strNomeForm = My.Application.OpenForms.Item(I).AccessibleName
            If strNomeForm = Me.txtCodPed.Text.Trim Then
                intCont += 1
            End If
        Next
        If intCont > 1 Then
            MsgBox("Esse pedido já está aberto nesse computador, verifique nas janelas abertas!", MsgBoxStyle.Information)
            Me.Close()
        End If

        Dim dt As DataTable
        'CarregarDataTable("Select Data, CodCli, Total, Descricao, Desconto, Status, Custo, " & _
        '"Entrega, CodFunc, Funcionario.Nome, Acrescimo, convert(Varchar(10), DataRetirada, 103) as DataRetirada, " & _
        '"Convert(varchar(10),DataEntrega,103) as DataEntrega, Comanda from TotalConsig inner join " & _
        '"Funcionario on TotalConsig.CodFunc = Funcionario.Codigo where TotalConsig.CodOrdens = " & Me.txtCodPed.Text.Trim & " and TotalConsig.CodConfig =" & CodConfig)
        If TipoNano = 5 Then
            dt = CarregarDataTable("Select Data, CodCli, Total, Descricao, Desconto, Status, Custo, " & _
            "Entrega, CodFunc, Acrescimo, convert(Varchar(10), DataRetirada, 103) as DataRetirada, " & _
            "Convert(varchar(10),DataEntrega,103) as DataEntrega, Comanda, StatusPedido, Placa, Modelo, Cor, Ano, " & _
            "Motor, NivelCombustivel, KMSaida, KMEntrada, Seguro, Sinistro, ValorFrete From TotalConsig where TotalConsig.CodOrdens = " & Me.txtCodPed.Text.Trim & " and TotalConsig.CodConfig =" & CodConfig)
        Else
            If bolVincularUser = True Then


                dt = CarregarDataTable("Select Data, CodCli, Total, Descricao, Desconto, Status, Custo, " & _
                "Entrega, CodFunc, Funcionario.Nome, Acrescimo, convert(Varchar(10), DataRetirada, 103) as DataRetirada, " & _
                "Convert(varchar(10),DataEntrega,103) as DataEntrega, Comanda, StatusPedido, Placa, Modelo, Cor, Ano, " & _
                "Motor, NivelCombustivel, KMSaida, KMEntrada, Seguro, Sinistro, ValorFrete From TotalConsig left Join " & _
                "Funcionario on TotalConsig.CodFunc = Funcionario.Codigo where TotalConsig.CodOrdens = " & Me.txtCodPed.Text.Trim & " and TotalConsig.CodConfig =" & CodConfig & strVinculoCodFunc)
            Else
                dt = CarregarDataTable("Select Data, CodCli, Total, Descricao, Desconto, Status, Custo, " & _
                "Entrega, CodFunc, Funcionario.Nome, Acrescimo, convert(Varchar(10), DataRetirada, 103) as DataRetirada, " & _
                "Convert(varchar(10),DataEntrega,103) as DataEntrega, Comanda, StatusPedido, Placa, Modelo, Cor, Ano, " & _
                "Motor, NivelCombustivel, KMSaida, KMEntrada, Seguro, Sinistro, ValorFrete From TotalConsig left Join " & _
                "Funcionario on TotalConsig.CodFunc = Funcionario.Codigo where TotalConsig.CodOrdens = " & Me.txtCodPed.Text.Trim & " and TotalConsig.CodConfig =" & CodConfig)
            End If
        End If

        Dim dtAlt As DataTable = CarregarDataTable("SELECT UsuarioAlt FROM TotalConsig where CodOrdens = " & Me.txtCodPed.Text.Trim & " and CodConfig = " & CodConfig)
        If dtAlt.Rows.Count > 0 Then
            If dtAlt.Rows.Item(0).Item("UsuarioAlt").ToString <> "" Then
                Dim vetUsuario As Array = Split(dtAlt.Rows.Item(0).Item("UsuarioAlt").ToString, "|")
                Dim strUsuario As String = vetUsuario(0)
                Dim strComp As String = vetUsuario(1)

                If strUsuario.ToUpper.Trim <> Login.ToUpper.Trim Then
                    MsgBox("Pedido já aberto para o  usuário " & strUsuario & " no computador " & strComp & "!", MsgBoxStyle.Information) : Me.txtCodPed.Focus() : Exit Sub
                Else
                    If strComp.ToUpper.Trim <> My.Computer.Name.ToUpper.Trim Then
                        MsgBox("Pedido já aberto para o  usuário " & strUsuario & " no computador " & strComp & "!", MsgBoxStyle.Information) : Me.txtCodPed.Focus() : Exit Sub
                    End If
                End If
            End If
        End If

        If dt.Rows.Count = 0 Then MsgBox("Pedido não Cadastrado!", MsgBoxStyle.Information) : Me.txtCodPed.ResetText() : Me.txtCodPed.Focus() : Exit Sub

        If Me.Tag = "ALTERA" Then
            If dt.Rows.Item(0).Item("Status").ToString = "Faturado" Then MsgBox("Pedido já faturado, não é possivel alterá-lo!", MsgBoxStyle.Exclamation) : txtCodPed.Focus() : Exit Sub
        End If

        If dt.Rows.Item(0).Item("Status").ToString = "Excluído" Then
            MsgBox("Esse pedido foi excluído!", MsgBoxStyle.Exclamation) : txtCodPed.Focus() : Exit Sub
        End If


        Me.cboStatus.Text = dt.Rows.Item(0).Item("Status").ToString

        'CARREGA OS DADOS DE CLIENTE

        CarregarCliente(dt.Rows.Item(0).Item("CodCli").ToString, False)
        HistoricoCliente(dt.Rows.Item(0).Item("CodCli").ToString)
        dtData.EditValue = Format(dt.Rows.Item(0).Item(0), "dd/MM/yyyy")
        intCodFunc = dt.Rows.Item(0).Item("CodFunc").ToString
        strNomeClienteAlt = Me.txtCli.Text
        Try
            If bolVincularUser = True Then
                lueFunc.Properties.ReadOnly = False
                Me.lueFunc.Text = dt.Rows.Item(0).Item("Nome").ToString
                Me.lueFunc.ClosePopup()
                lueFunc.Properties.ReadOnly = True
            Else
                Me.lueFunc.Text = dt.Rows.Item(0).Item("Nome").ToString
                Me.lueFunc.ClosePopup()
            End If
        Catch ex As Exception
        End Try

        Me.txtSeguradora.Text = dt.Rows.Item(0).Item("Seguro").ToString
        Me.txtSinistro.Text = dt.Rows.Item(0).Item("Sinistro").ToString
        Me.txtComanda.Text = dt.Rows.Item(0).Item("Comanda").ToString
        strComanda = dt.Rows.Item(0).Item("Comanda").ToString
        Me.txtTotal.Text = Format(dt.Rows.Item(0).Item("Total"), "0.00")
        If dt.Rows.Item(0).Item("ValorFrete").ToString <> "" Then
            Me.txtValorFrete.Text = Format(dt.Rows.Item(0).Item("ValorFrete"), "0.00")
        Else
            Me.txtValorFrete.Text = "0,00"
        End If

        If dt.Rows.Item(0).Item("Descricao").ToString <> "" Then
            Dim vetDesc As Array = Split(dt.Rows.Item(0).Item("Descricao").ToString, "|")

            Me.txtDesc.Text = vetDesc(0).ToString
            strObservacaoAlt = vetDesc(0).ToString

            If vetDesc.Length > 1 Then
                Me.txtProbVeiculo.Text = vetDesc(1).ToString
            End If
        End If

        Dim vetDesconto As Array = Split(dt.Rows.Item(0).Item("Desconto").ToString, "|")
        Me.txtValDesc.Text = vetDesconto(0).ToString.Trim
        If vetDesconto.Length > 1 Then
            Me.txtDesconto.Text = vetDesconto(1).ToString.Trim
        End If

        Me.cboGrp.Text = dt.Rows.Item(0).Item("StatusPedido").ToString

        'CARREGAR DADOS VEICULO
        Me.txtPlaca.Text = dt.Rows.Item(0).Item("Placa").ToString
        Me.txtMod.Text = dt.Rows.Item(0).Item("Modelo").ToString
        Me.txtAno.Text = dt.Rows.Item(0).Item("Ano").ToString
        Me.txtCor.Text = dt.Rows.Item(0).Item("Cor").ToString
        Me.txtKm.Text = dt.Rows.Item(0).Item("KMEntrada").ToString
        Me.txtMotor.Text = dt.Rows.Item(0).Item("Motor").ToString
        Me.txtNivCom.Text = dt.Rows.Item(0).Item("NivelCombustivel").ToString
        Me.txtKMSaida.Text = dt.Rows.Item(0).Item("KMSaida").ToString


        If dt.Rows.Item(0).Item("DataRetirada").ToString = "01/01/1900" Then
            Me.dtRetirada.Text = ""
        Else
            Me.dtRetirada.Text = dt.Rows.Item(0).Item("DataRetirada").ToString
        End If

        If dt.Rows.Item(0).Item("DataEntrega").ToString = "01/01/1900" Then
            Me.dtRetirada.Text = ""
        Else
            Me.dtEntrega.Text = dt.Rows.Item(0).Item("DataEntrega").ToString
        End If
      
        If dt.Rows.Item(0).Item("Custo").ToString <> "" Then
            dblTotalDeCusto = dt.Rows.Item(0).Item("Custo").ToString
        End If
        Me.txtEntrega.Text = dt.Rows.Item(0).Item("Entrega").ToString
        'CARREGAR DADOS DE PEDIDO

        Dim dtTabela As DataTable = CarregarDataTable("SELECT top 1 TabelaPreco from ItensConsig where " & _
        "CodOrdens = " & Me.txtCodPed.Text.Trim & " and CodConfig =" & CodConfig & " order by Codigo desc")
        If dtTabela.Rows.Count > 0 Then
            If dtTabela.Rows.Item(0).Item("TabelaPreco").ToString <> "" Then
                Me.cboTabela.Text = dtTabela.Rows.Item(0).Item("TabelaPreco").ToString
            End If
        End If

        Dim dtPed As DataTable = CarregarDataTable("Select Codigo, CodOrdens, Qtd, CodigoProduto, Produto, " & _
        "ValorUnitario, ValorTotal, CodigoInterno, Custo, UM, Tamanho, UniSemDesc, Promocao, Desconto, MedidaA, " & _
        "MedidaB, QtdMedida, convert(varchar(10),DataAdd,103) as DataAdd, CodigoFuncionario, Autorizado, " & _
        "CampoPedido from ItensConsig where CodOrdens = " & Me.txtCodPed.Text.Trim & " and CodConfig =" & CodConfig)
        intQtdItensAlt = dtPed.Rows.Count
        Me.tbItens.Rows.Clear()
        Dim dblTotalSDesc As Double
        Dim dblTotalCDesc As Double
        Dim dblQtd As Double
        For I = 0 To dtPed.Rows.Count - 1
            With Me.tbItens.Rows
                .Add()
                .Item(I).Item("CodPedAut") = dtPed.Rows.Item(I).Item(0).ToString
                .Item(I).Item("Qtd") = dtPed.Rows.Item(I).Item("Qtd").ToString
                dblQtd = dtPed.Rows.Item(I).Item("Qtd").ToString
                .Item(I).Item("CodigoProduto") = dtPed.Rows.Item(I).Item("CodigoProduto").ToString
                .Item(I).Item("Produto") = dtPed.Rows.Item(I).Item("Produto").ToString
                'If resCasasDecimais = True Then
                '    .Item(I).Item("ValorUnitario") = Format(dtPed.Rows.Item(I).Item("ValorUnitario"), "0.000")
                'Else
                .Item(I).Item("ValorUnitario") = CampoValor(dtPed.Rows.Item(I).Item("ValorUnitario"))
                'End If
                .Item(I).Item("ValorTotal") = Format(dtPed.Rows.Item(I).Item("ValorTotal"), "0.00")
                .Item(I).Item("CodigoInterno") = dtPed.Rows.Item(I).Item("CodigoInterno").ToString
                .Item(I).Item("Tamanho") = dtPed.Rows.Item(I).Item("Tamanho").ToString
                .Item(I).Item("MedidaA") = dtPed.Rows.Item(I).Item("MedidaA")
                .Item(I).Item("MedidaB") = dtPed.Rows.Item(I).Item("MedidaB")
                .Item(I).Item("QtdMedida") = dtPed.Rows.Item(I).Item("QtdMedida")

                Dim dtTipo As DataTable = CarregarDataTable("Select Tipo From Produto where Codigo = " & CInt(dtPed.Rows.Item(I).Item("CodigoProduto").ToString.Trim) & "")
                If dtTipo.Rows.Count > 0 Then
                    .Item(I).Item("Tipo") = dtTipo.Rows.Item(0).Item("Tipo").ToString

                End If

                Dim dtLoc As DataTable = CarregarDataTable("Select Locacao From Locacao where CodProd = " & CInt(dtPed.Rows.Item(I).Item("CodigoProduto").ToString.Trim) & " and CodConfig = " & CodConfig)
                If dtLoc.Rows.Count > 0 Then
                    .Item(I).Item("Locacao") = dtLoc.Rows.Item(0).Item("Locacao").ToString
                End If

                If dtPed.Rows.Item(I).Item("Autorizado").ToString <> "" Then
                    .Item(I).Item("Autorizado") = dtPed.Rows.Item(I).Item("Autorizado")
                Else
                    .Item(I).Item("Autorizado") = True
                End If

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
                .Item(I).Item("DataAdd") = dtPed.Rows.Item(I).Item("DataAdd").ToString

                .Item(I).Item("CodigoFuncionario") = dtPed.Rows.Item(I).Item("CodigoFuncionario").ToString
                .Item(I).Item("CampoPedido") = dtPed.Rows.Item(I).Item("CampoPedido").ToString

                Dim dblLucro As Double = dblResul - dblCusto
                dblLucro = (dblLucro * 100) / dblCusto
                Dim str As String = dblLucro
                If str = "+Infinito" Or str = "NaN (Não é um número)" Then
                    dblLucro = 0
                End If
                .Item(I).Item("Lucro") = dblLucro.ToString("0.00")


                Dim dtCampanha As DataTable = CarregarDataTable("Select ValorAnt from Campanha Where CodProd = " & dtPed.Rows.Item(I).Item("CodigoProduto").ToString & " and Status = 'Lancado'")

                If dtCampanha.Rows.Count > 0 Then
                    If dtCampanha.Rows.Item(0).Item("ValorAnt").ToString <> "" Then
                        Dim dblValorAnt As Double = dtCampanha.Rows.Item(0).Item("ValorAnt").ToString
                        If dtPed.Rows.Item(I).Item("ValorUnitario").ToString <> "" Then
                            Dim dblVal As Double = dtPed.Rows.Item(I).Item("ValorUnitario").ToString
                            If dblValorAnt > dblVal Then
                                Dim dblPorcAnt As Double = ((dblValorAnt - dblVal) * 100) / dblValorAnt
                                .Item(I).Item("ValorAnt") = dblValorAnt.ToString("0.00")
                                .Item(I).Item("ValorAntPorc") = dblPorcAnt.ToString("0.00")
                            End If
                        End If
                    End If
                End If

            End With
        Next

        dblTotalComDesconto = dblTotalCDesc.ToString("0.00")

        dblTotalSemDesconto = dblTotalSDesc.ToString("0.00")
        Me.picFundo.Visible = False


        Dim dblTotalServico, dblTotalPeca As Double
        Dim bolTipoProduto As Boolean = False
        For J As Integer = 0 To Me.tbItens.Rows.Count - 1
            Dim Tipo As String = Me.tbItens.Rows.Item(J).Item("Tipo").ToString
            If Tipo = "VENDA" Or Tipo = "AMBOS" Then
                dblTotalPeca = dblTotalPeca + CDbl(Me.tbItens.Rows.Item(J).Item("ValorTotal").ToString)
            ElseIf Tipo = "SERVIÇO" Then
                dblTotalServico = dblTotalServico + CDbl(Me.tbItens.Rows.Item(J).Item("ValorTotal").ToString)
                bolTipoProduto = True
            End If
        Next
        Me.txtTotalprod.Text = dblTotalPeca.ToString("0.00")
        Me.txtTotalServ.Text = dblTotalServico.ToString("0.00")

        'If bolTipoProduto = True Then
        '    Me.pnlTipoprod.Visible = True
        '    Me.lblTipoprod.Visible = True
        '    Me.lblTotalprod.Visible = True
        'Me.lblTotalServ.Visible = True
        Me.txtTotalprod.Visible = True
        Me.txtTotalServ.Visible = True
        'Else
        '    Me.pnlTipoprod.Visible = False
        '    Me.lblTipoprod.Visible = False
        '    Me.lblTotalprod.Visible = False
        '    Me.lblTotalServ.Visible = False
        '    Me.txtTotalprod.Visible = False
        '    Me.txtTotalServ.Visible = False
        'End If

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
                If vetAcrescimo.Length > 1 Then
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

        If Me.Tag <> "CONSULTA" Then
            Dim strUsuarioAlt As String = Login & "|" & My.Computer.Name.ToUpper
            Atualizar("UPDATE TotalConsig set UsuarioAlt = '" & strUsuarioAlt & "' where CodOrdens = " & Me.txtCodPed.Text.Trim & " and CodConfig = " & CodConfig)
            strCodOrdemAlt = Me.txtCodPed.Text.Trim
        End If

        Dim intCodPedido As Integer = Me.txtCodPed.Text.Trim
        bolMensagemDesconto = False
        If Me.Tag = "FATURA" Then
            bolJaPassou = True
            Me.txtRec.Focus()
        ElseIf Me.Tag = "ALTERA" Then
            bolJaPassou = True
            Me.txtCodPro.Focus()
        End If


        Calcular(True)
        If TipoDesconto = "TOTAL" Then
            DescontoComPorcentagem(True)
        End If
    End Sub

    Private Sub btnCancelar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Me.chkAlterado.Checked = True Then MsgBox("Existe um item sendo alterado, conclua a alteração antes de excluir algum item!", MsgBoxStyle.Information) : Exit Sub
        If grd1.RowCount = 0 Then Exit Sub
        Me.grd1.ClearColumnsFilter()
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

        Me.txtValDesc.ResetText()
        Me.txtDesconto.ResetText()
        DescontoComValor(False)

        Calcular(False)
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

    'Private Sub Imprimir()

    '    Calcular()

    '    If Impressora.Contains("ESC/POS") = True Then
    '        If intCodCli = 0 Then Exit Sub
    '        clsImprimir.ImprimePedido(Me.txtCodPed.Text.Trim, intCodCli, Me.dtData.Text, Me.lueFunc.Text.Trim, Me.txtDesc.Text)
    '        Exit Sub
    '    End If

    '    If Impressora = "DARUMA" Then
    '        Dim strImpressao As String

    '        strImpressao = "<tc>#</tc>" & vbCrLf

    '        strImpressao &= "<b><ce>" & NomeEmpresa.ToString.Trim & "</ce></b>" & vbCrLf

    '        strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf

    '        strImpressao &= "<ce>" & TelefoneEmpresa & "</ce>" & vbCrLf
    '        strImpressao &= "<tc>#</tc>" & vbCrLf
    '        strImpressao &= "<ad><dt></dt></ad>" & vbCrLf
    '        strImpressao &= "<e><ce> Pedido Nº " & Me.txtCodPed.Text.Trim & "</ce></e>" & vbCrLf
    '        strImpressao &= " CÓDIGO    DESCRIÇÃO                    " & vbCrLf
    '        strImpressao &= "<ad>UN.   TAM.   QTD.   VL UNIT R$        VL Total R$</ad>" & vbCrLf
    '        strImpressao &= "<tc>-</tc>" & vbCrLf

    '        Dim L As Integer
    '        Dim dblQtd As Double
    '        For L = 0 To Me.grd1.RowCount - 1
    '            Dim strCod, strProd, strUni, strQtd, strTot, strUM, strTam As String

    '            strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoPeca)
    '            strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
    '            strUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
    '            strQtd = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
    '            strTot = Me.grd1.GetRowCellDisplayText(L, Me.colValorTotal)
    '            strUM = Me.grd1.GetRowCellDisplayText(L, Me.colUM)
    '            dblQtd += Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
    '            strTam = Me.grd1.GetRowCellDisplayText(L, Me.colTamanho)
    '            strImpressao &= "<c><i>  " & strCod & "   " & strProd & "</i></c>" & vbCrLf
    '            Dim str As String
    '            str = " " & strUM & "   " & strTam & "   " & Dir(strQtd & " X " & strUni, 21) & Esq(strTot, 20)
    '            strImpressao &= str & vbCrLf
    '        Next


    '        strImpressao &= "<tc>-</tc>" & vbCrLf
    '        strImpressao &= "<ad><b>" & "N de Itens " & Esq(dblQtd, 9) & "</b></ad>" & vbCrLf
    '        strImpressao &= "<ad><b>" & "Total R$ " & Esq(Me.txtTotal.Text.Trim, 9) & "</b></ad>" & vbCrLf

    '        strImpressao &= "<l></l>" & vbCrLf

    '        strImpressao &= "<tc>-</tc>" & vbCrLf

    '        If GerarComissao = True Then
    '            strImpressao &= "<c>" & "Vend.: " & Me.lueFunc.Text & "</c>" & vbCrLf
    '        End If

    '        Dim dt As DataTable

    '        dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & intCodCli)

    '        If dt.Rows.Count > 0 Then
    '            If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
    '                strImpressao &= "<c>" & dt.Rows.Item(0).Item("Nome").ToString & "</c>" & vbCrLf
    '            End If

    '            If dt.Rows.Item(0).Item("Endereco").ToString <> "" Then
    '                strImpressao &= "<c>" & dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & " " & dt.Rows.Item(0).Item("Complemento").ToString & "</c>" & vbCrLf
    '            End If

    '            If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
    '                strImpressao &= "<c>" & dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & "</c>" & vbCrLf
    '            End If

    '            If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
    '                strImpressao &= "<c>" & dt.Rows.Item(0).Item("Telefone").ToString & "</c>" & vbCrLf
    '            End If
    '            strImpressao &= "<tc>-</tc>" & vbCrLf
    '        End If
    '        If Me.txtDesc.Text <> "" Then
    '            strImpressao &= "<c>" & "Observações: " & Me.txtDesc.Text.Trim & "</c>" & vbCrLf
    '            strImpressao &= "<tc>-</tc>" & vbCrLf
    '        End If
    '        strImpressao &= "<ce>DOCUMENTO NÃO FISCAL" & "</ce>" & vbCrLf

    '        strImpressao &= "<l></l>" & vbCrLf
    '        strImpressao &= "<l></l>" & vbCrLf
    '        strImpressao &= "<l></l>" & vbCrLf

    '        If TemGuilhotina = True Then
    '            strImpressao &= "<gui></gui>" & vbCrLf
    '        End If

    '        If ImpressoraOK() = True Then
    '            iRetorno = (iImprimirTexto_DUAL_DarumaFramework(strImpressao, 0))

    '            'If MsgBox("Deseja imprimir a segunda via?", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '            '    iRetorno = (iImprimirTexto_DUAL_DarumaFramework(strImpressao, 0))
    '            'End If

    '        End If
    '    ElseIf Impressora.Contains("BEMATECH") Or Impressora.Contains("ARQUIVO") Or Impressora.Contains("NANO PRINT") Then

    '        Dim strImpressao As String
    '        If Impressora.Contains("MP-4000") Then
    '            iRetorno = ConfiguraModeloImpressora(5)
    '            iRetorno = SelecionaQualidadeImpressao(3)
    '        Else
    '            If Impressora.Contains("BEMATECH") = True Then
    '                iRetorno = ConfiguraModeloImpressora(1)
    '            Else
    '                Try
    '                    iRetorno = ConfiguraModeloImpressora(1)
    '                Catch ex As Exception

    '                End Try
    '            End If

    '        End If
    '        If Impressora.Contains("BEMATECH") = True Then
    '            iRetorno = clsBematech.IniciaPorta(PortaImpressora)

    '        Else
    '            Try
    '                iRetorno = clsBematech.IniciaPorta(PortaImpressora)

    '            Catch ex As Exception

    '            End Try
    '        End If


    '        Dim intTamEsp, intEsp1, intEsp2 As Integer
    '        Dim strEstrela, strTraço As String

    '        If Impressora.Contains("ARQUIVO") = True Then
    '            intTamEsp = 42
    '            strEstrela = "******************************************"
    '            strTraço = "------------------------------------------"
    '        Else
    '            intTamEsp = 60
    '            strEstrela = "************************************************************"
    '            strTraço = "------------------------------------------------------------"
    '        End If

    '        strImpressao = strEstrela & vbCrLf

    '        strImpressao &= Cent(NomeEmpresa.ToString.Trim, intTamEsp) & vbCrLf
    '        strImpressao &= Cent(EnderecoEmpresa.Trim, intTamEsp) & vbCrLf
    '        strImpressao &= Cent(TelefoneEmpresa, intTamEsp) & vbCrLf

    '        strImpressao &= strEstrela & vbCrLf
    '        strImpressao &= Esq(My.Computer.Clock.LocalTime, intTamEsp) & vbCrLf
    '        strImpressao &= Dir("PEDIDO N - " & Me.txtCodPed.Text.Trim, intTamEsp) & vbCrLf
    '        strImpressao &= "CÓDIGO    DESCRIÇÃO                    " & vbCrLf
    '        If Impressora.Contains("ARQUIVO") = True Then
    '            strImpressao &= Dir("UN.   QTD.     VL UNIT R$", 31) & Esq("VL Total R$", 11) & vbCrLf
    '        Else
    '            strImpressao &= Dir("UN.   QTD.     VL UNIT R$", 49) & Esq("VL Total R$", 11) & vbCrLf
    '        End If

    '        strImpressao &= strTraço & vbCrLf

    '        If Impressora.Contains("ARQUIVO") = True Then
    '            intEsp1 = 32
    '            intEsp2 = 10
    '        Else
    '            intEsp1 = 40
    '            intEsp2 = 20
    '        End If

    '        Dim L As Integer
    '        Dim dblQtd As Double
    '        For L = 0 To Me.grd1.RowCount - 1
    '            Dim strCod, strProd, strUni, strQtd, strTot, strUM As String

    '            strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoPeca)
    '            strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
    '            strUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
    '            strQtd = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
    '            strTot = Me.grd1.GetRowCellDisplayText(L, Me.colValorTotal)
    '            strUM = Me.grd1.GetRowCellDisplayText(L, Me.colUM)
    '            dblQtd += Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
    '            strImpressao &= strCod & "   " & strProd & vbCrLf
    '            Dim str As String
    '            str = Dir(strUM & "    " & strQtd & "  X  " & strUni, intEsp1) & Esq(strTot, intEsp2)

    '            strImpressao &= str & vbCrLf
    '        Next


    '        strImpressao &= strTraço & vbCrLf
    '        strImpressao &= Esq("N de Itens......: ", intEsp1) & Esq(dblQtd, intEsp2) & vbCrLf
    '        strImpressao &= Esq("Total........: R$ ", intEsp1) & Esq(Me.txtTotal.Text.Trim, intEsp2) & vbCrLf

    '        strImpressao &= " " & vbCrLf

    '        strImpressao &= strTraço & vbCrLf

    '        If GerarComissao = True Then
    '            strImpressao &= "Vend.: " & Me.lueFunc.Text.Trim & vbCrLf
    '        End If

    '        Dim dt As DataTable

    '        dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & intCodCli)

    '        If dt.Rows.Count > 0 Then
    '            If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
    '                strImpressao &= dt.Rows.Item(0).Item("Nome").ToString & vbCrLf
    '            End If

    '            If dt.Rows.Item(0).Item("Endereco").ToString <> "" Then
    '                strImpressao &= dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & " " & dt.Rows.Item(0).Item("Complemento").ToString & vbCrLf
    '            End If

    '            If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
    '                strImpressao &= dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & vbCrLf
    '            End If

    '            If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
    '                strImpressao &= dt.Rows.Item(0).Item("Telefone").ToString & vbCrLf
    '            End If
    '        End If

    '        strImpressao &= " " & vbCrLf
    '        If Me.txtDesc.Text <> "" Then
    '            strImpressao &= "Observações: " & Me.txtDesc.Text.Trim & vbCrLf
    '            strImpressao &= " " & vbCrLf
    '        End If


    '        strImpressao &= Cent("DOCUMENTO NÃO FISCAL", intTamEsp) & vbCrLf

    '        strImpressao &= strTraço & vbCrLf
    '        strImpressao &= Cent(NomeEmpresa.ToString.Trim, intTamEsp) & vbCrLf

    '        strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")


    '        If Impressora = "ARQUIVO" Then
    '            ImprimiArquivo(strImpressao, PortaImpressora)
    '        ElseIf Impressora.Contains("NANO PRINT") = True Then
    '            If Impressora = "NANO PRINT ARQUIVO DIRETO" Then
    '                ImprimeArquivo(My.Application.Info.DirectoryPath & "\Cupom.txt", strImpressao)
    '            Else
    '                EscreveArquivo(PortaImpressora & "\Cupom.txt", strImpressao)
    '            End If

    '        Else
    '            iRetorno = clsBematech.FormataTX(strImpressao, 1, 0, 0, 0, 1)

    '            If TemGuilhotina = True Then
    '                iRetorno = clsBematech.AcionaGuilhotina(0)
    '            End If
    '        End If
    '        If Impressora.Contains("BEMATECH") = True Then
    '            iRetorno = clsBematech.FechaPorta()
    '        Else
    '            Try
    '                iRetorno = clsBematech.FechaPorta()
    '            Catch ex As Exception

    '            End Try
    '        End If

    '        'SegundaVia(strImpressao)
    '    ElseIf Impressora = "EPSON" Then

    '        Dim strImpressao As String

    '        Dim strEstrela, strTraço As String

    '        strEstrela = clsImprimir.Comp("************************************************")
    '        strTraço = clsImprimir.Comp("------------------------------------------------")

    '        strImpressao = strEstrela & vbCrLf

    '        strImpressao &= "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf
    '        strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf
    '        strImpressao &= "<ce>" & TelefoneEmpresa & "</ce>" & vbCrLf

    '        strImpressao &= strEstrela & vbCrLf
    '        strImpressao &= Esq(My.Computer.Clock.LocalTime, 48) & vbCrLf
    '        strImpressao &= Dir("PEDIDO N - " & Me.txtCodPed.Text.Trim, 48) & vbCrLf
    '        strImpressao &= "CÓDIGO    DESCRIÇÃO                    " & vbCrLf
    '        strImpressao &= Dir("UN.   QTD.     VL UNIT R$", 37) & Esq("VL Total R$", 11) & vbCrLf

    '        strImpressao &= strTraço & vbCrLf

    '        Dim L As Integer
    '        Dim dblQtd As Double
    '        For L = 0 To Me.grd1.RowCount - 1
    '            Dim strCod, strProd, strUni, strQtd, strTot, strUM As String

    '            strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoPeca)
    '            strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
    '            strUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
    '            strQtd = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
    '            strTot = Me.grd1.GetRowCellDisplayText(L, Me.colValorTotal)
    '            strUM = Me.grd1.GetRowCellDisplayText(L, Me.colUM)
    '            dblQtd += Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
    '            strImpressao &= strCod & "   " & strProd & vbCrLf
    '            Dim str As String
    '            str = Dir(strUM & "    " & strQtd & "  X  " & strUni, 37) & Esq(strTot, 11)


    '            strImpressao &= str & vbCrLf
    '        Next


    '        strImpressao &= strTraço & vbCrLf
    '        strImpressao &= Esq("N de Itens...:    ", 37) & Esq(dblQtd, 11) & vbCrLf
    '        strImpressao &= Esq("Total........: R$ ", 37) & Esq(Me.txtTotal.Text.Trim, 11) & vbCrLf

    '        strImpressao &= " " & vbCrLf

    '        strImpressao &= strTraço & vbCrLf

    '        If GerarComissao = True Then
    '            strImpressao &= "Vend.: " & Me.lueFunc.Text.Trim & vbCrLf
    '        End If

    '        Dim dt As DataTable

    '        dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & intCodCli)

    '        If dt.Rows.Count > 0 Then
    '            If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
    '                strImpressao &= dt.Rows.Item(0).Item("Nome").ToString & vbCrLf
    '            End If

    '            If dt.Rows.Item(0).Item("Endereco").ToString <> "" Then
    '                strImpressao &= dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & " " & dt.Rows.Item(0).Item("Complemento").ToString & vbCrLf
    '            End If

    '            If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
    '                strImpressao &= dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & vbCrLf
    '            End If

    '            If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
    '                strImpressao &= dt.Rows.Item(0).Item("Telefone").ToString & vbCrLf
    '            End If

    '        End If

    '        strImpressao &= " " & vbCrLf
    '        If Me.txtDesc.Text <> "" Then
    '            strImpressao &= "Observações: " & Me.txtDesc.Text.Trim & vbCrLf
    '            strImpressao &= " " & vbCrLf
    '        End If
    '        strImpressao &= "<ce>" & "DOCUMENTO NÃO FISCAL" & "</ce>" & vbCrLf

    '        strImpressao &= strTraço & vbCrLf
    '        strImpressao &= "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf

    '        strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")


    '        iRetorno = clsEpson.IniciaPorta(PortaImpressora)

    '        iRetorno = clsEpson.ImprimeTextoTag(strImpressao)

    '        If TemGuilhotina = True Then
    '            iRetorno = clsEpson.AcionaGuilhotina(1)
    '        End If

    '        iRetorno = clsEpson.FechaPorta()

    '        'If SegViaRecibo = True Then
    '        '    If MsgBox("Deseja imprimir a segunda via?", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '        '        iRetorno = clsEpson.IniciaPorta(PortaImpressora)

    '        '        iRetorno = clsEpson.ImprimeTextoTag(strImpressao)

    '        '        If TemGuilhotina = True Then
    '        '            iRetorno = clsEpson.AcionaGuilhotina(1)
    '        '        End If

    '        '        iRetorno = clsEpson.FechaPorta()
    '        '    End If
    '        'End If
    '    ElseIf Impressora = "MATRICIAL" Then
    '        If NomeEmpresa.ToString.ToUpper.Contains("BAREX") = True Then
    '            Dim intTamEsp As Integer
    '            Dim strEstrela, strTraço As String

    '            intTamEsp = 42
    '            strEstrela = "*****************************************************************************"
    '            'strTraço = "............................................................................." & vbCrLf

    '            'iRetorno = IniciaPorta(PortaImpressora)

    '            Dim strTracoMenor As String = "............................................................................." & vbCrLf

    '            Dim strFunc As String = Me.lueFunc.Text


    '            Dim strDt As String = Me.dtData.Text
    '            strDt = strDt.Substring(0, 10)
    '            Dim strHora As String = My.Computer.Clock.LocalTime

    '            If strHora.Length = 19 Then
    '                strHora = strHora.Substring(10, 9)
    '            End If


    '            'Dim dtClient As DataTable = CarregarDataTable("select nome,numero, fantasia, endereco, cidade, telefone, bairro from cliente left join total on cliente.codigo = total.codcli where total.codordem =" & intCodCli)
    '            'Dim strNome, strFant, strEnd, strCid, strTel, strBairro, strNum As String
    '            'strNome = dtClient.Rows(0).Item("nome").ToString
    '            'strFant = dtClient.Rows(0).Item("fantasia").ToString
    '            'strEnd = dtClient.Rows(0).Item("endereco").ToString
    '            'strCid = dtClient.Rows(0).Item("cidade").ToString
    '            'strTel = dtClient.Rows(0).Item("telefone").ToString
    '            'strBairro = dtClient.Rows(0).Item("bairro").ToString
    '            'strNum = dtClient.Rows(0).Item("numero").ToString


    '            Dim dtClient As DataTable = CarregarDataTable("select nome,numero, fantasia, endereco, cidade, telefone, bairro from cliente where Codigo =" & intCodCli)
    '            Dim strNome, strFant, strEnd, strCid, strTel, strBairro, strNum As String
    '            If dtClient.Rows.Count > 0 Then

    '                strNome = dtClient.Rows(0).Item("nome").ToString
    '                strFant = dtClient.Rows(0).Item("fantasia").ToString
    '                strEnd = dtClient.Rows(0).Item("endereco").ToString
    '                strCid = dtClient.Rows(0).Item("cidade").ToString
    '                strTel = dtClient.Rows(0).Item("telefone").ToString
    '                strBairro = dtClient.Rows(0).Item("bairro").ToString
    '                strNum = dtClient.Rows(0).Item("numero").ToString

    '            End If


    '            'Dim strImpressao As String = Cent(NomeEmpresa.ToString.Trim, 77) & vbCrLf
    '            'strImpressao &= Cent(TelefoneEmpresa.Trim & " " & EnderecoEmpresa.Trim, 77) & vbCrLf
    '            'strImpressao &= strTraço & strTraço & strTracoMenor & "." & vbCrLf '"......." & vbCrLf

    '            'strImpressao &= DirCorte("VEND: " & strFunc, 30) & DirCorte("PEDIDO: " & Me.txtCodPed.Text, 22) & Dir("DATA: " & strDt & "" & strHora, 11) & vbCrLf
    '            'strImpressao &= DirCorte("CLIENTE: " & strNome, 44) & DirCorte("FANTASIA: " & strFant, 44) & vbCrLf
    '            'strImpressao &= DirCorte("" & strEnd & " " & strNum, 33) & DirCorte(" " & strCid, 15) & DirCorte(" " & strBairro, 10) & DirCorte("TEL: " & strTel, 20) & vbCrLf
    '            'strImpressao &= DirCorte("SEGUNDA VIA IMPRESSA ." & strTraço & strTracoMenor & strTracoMenor, 77) & vbCrLf
    '            ''If NomeEmpresa.Contains("SKINA") Then
    '            ''    strImpressao &= "Qtd  Descricao                                   Marca       Cod.Interno   Aplicacao                 Valor Unit.     Sub.Total" & vbCrLf
    '            ''Else
    '            'strImpressao &= "Codigo  CodigoBarra  Descricao " & Space(15) & "Qtde. " & Space(5) & " Valor Unit.       Sub.Total" & vbCrLf
    '            ''End If

    '            'strImpressao &= strTraço

    '            Dim strImpressao As String = Cent(NomeEmpresa.ToString.Trim, 77) & vbCrLf
    '            strImpressao &= Cent(TelefoneEmpresa.Trim, 77) & vbCrLf
    '            strImpressao &= Cent(EnderecoEmpresa.Trim, 77) & vbCrLf
    '            strImpressao &= strTraço & strTraço & strTracoMenor & "." & vbCrLf '"......." & vbCrLf

    '            strImpressao &= DirCorte("VENDEDOR: " & strFunc, 30) & DirCorte("PEDIDO: " & Me.txtCodPed.Text, 22) & Dir("DATA:" & strDt & " " & strHora, 11) & vbCrLf
    '            strImpressao &= DirCorte("CLIENTE: " & strNome, 39) & DirCorte(" FANTASIA: " & strFant, 44) & vbCrLf
    '            strImpressao &= DirCorte("" & strEnd & " " & strNum, 33) & DirCorte(" " & strCid, 14) & DirCorte(" " & strBairro, 10) & DirCorte(" TEL: " & strTel.Trim, 20) & vbCrLf
    '            Dim strTraço2 As String = "............................................................................."
    '            strImpressao &= DirCorte("SEGUNDA VIA IMPRESSA ." & strTraço2 & strTracoMenor & strTracoMenor, 77) & vbCrLf

    '            strImpressao &= "Codigo  Cod. Origem  Descricao " & Space(15) & "Qtde. " & Space(2) & " Valor Unit.  Sub.Total" & vbCrLf


    '            strImpressao &= strTraço


    '            Dim dblUni, dblQt As Double
    '            Dim dblTot As Double = 0.0
    '            Dim dblLiq As Double = 0.0
    '            Dim L As Integer
    '            If Me.grd1.RowCount < 13 Then
    '                For L = 0 To 13
    '                    If Me.grd1.RowCount - 1 >= L Then
    '                        Dim strCod, strProd, strUM, strFab, strObs, strCodProd, strCodBarra As String
    '                        strCodProd = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoProduto)


    '                        strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoPeca)
    '                        strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
    '                        dblUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
    '                        dblQt = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
    '                        dblTot = Me.grd1.GetRowCellDisplayText(L, Me.colValorTotal)
    '                        strUM = Me.grd1.GetRowCellDisplayText(L, Me.colUM)
    '                        Dim dtProd As DataTable = CarregarDataTable("SELECT Setor, Obs, CodigoBarra FROM Produto where Codigo = " & strCodProd)

    '                        If dtProd.Rows.Count > 0 Then
    '                            strFab = dtProd.Rows.Item(0).Item("Setor").ToString
    '                            strObs = dtProd.Rows.Item(0).Item("Obs").ToString
    '                            strCodBarra = dtProd.Rows.Item(0).Item("CodigoBarra").ToString
    '                        End If

    '                        If strUM.Trim = "" Then
    '                            strUM = "UN"
    '                        End If

    '                        dblLiq = dblLiq + dblTot

    '                        strImpressao &= DirCorte(strCod, 8) & DirCorte(strCodBarra, 11) & DirCorte("  " & strProd, 25) & Esq((dblQt.ToString("N3")), 7) & Esq(dblUni.ToString("C2"), 13) & Esq(dblTot.ToString("C2"), 13) & vbCrLf

    '                    Else
    '                        strImpressao &= "." & vbCrLf
    '                    End If
    '                Next



    '            Else
    '                For L = 0 To Me.grd1.RowCount - 1
    '                    Dim strCod, strProd, strUM, strFab, strObs, strCodProd As String
    '                    strCodProd = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoProduto)


    '                    strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoPeca)
    '                    strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
    '                    dblUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
    '                    dblQt = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
    '                    dblTot = Me.grd1.GetRowCellDisplayText(L, Me.colValorTotal)
    '                    strUM = Me.grd1.GetRowCellDisplayText(L, Me.colUM)
    '                    Dim dtProd As DataTable = CarregarDataTable("SELECT Setor, Obs FROM Produto where Codigo = " & strCodProd)

    '                    If dtProd.Rows.Count > 0 Then
    '                        strFab = dtProd.Rows.Item(0).Item("Setor").ToString
    '                        strObs = dtProd.Rows.Item(0).Item("Obs").ToString
    '                    End If

    '                    If strUM.Trim = "" Then
    '                        strUM = "UN"
    '                    End If

    '                    dblLiq = dblLiq + dblTot

    '                    strImpressao &= DirCorte(dblQt.ToString("N2"), 4) & DirCorte("  " & strProd, 30) & DirCorte("  " & strFab, 11) & DirCorte("   " & strCod, 13) & DirCorte("    " & strObs, 27) & Esq("     " & dblUni.ToString("C2"), 14) & Esq("      " & dblTot.ToString("C2"), 14) & vbCrLf
    '                Next
    '            End If



    '            'strImpressao &= vbCrLf & vbCrLf & vbCrLf & vbCrLf & Esq("TOTAL: " & dblLiq.ToString("C2"), 127) & vbCrLf
    '            'strImpressao &= vbCrLf & vbCrLf & "ASS:_______________________________________________________ Veiculo: __________________________________________________________" & vbCrLf
    '            'strImpressao &= Cent(ObsPedido, 128) & vbCrLf

    '            If NomeEmpresa.ToString.ToUpper.Contains("BAREX") = True Then
    '                strImpressao &= Esq("TOTAL: " & dblLiq.ToString("C2"), 77) & vbCrLf
    '                strImpressao &= vbCrLf & Cent(ObsPedido, 77) & vbCrLf
    '                strImpressao = strImpressao & vbCrLf & vbCrLf
    '            Else
    '                strImpressao &= vbCrLf & vbCrLf & vbCrLf & vbCrLf & Esq("TOTAL: " & dblLiq.ToString("C2"), 127) & vbCrLf
    '                strImpressao &= vbCrLf & vbCrLf & "ASS:_______________________________________________________ Veiculo: __________________________________________________________" & vbCrLf
    '                strImpressao &= Cent(ObsPedido, 128) & vbCrLf
    '            End If


    '            strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A")
    '            strImpressao = strImpressao.Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E")
    '            strImpressao = strImpressao.Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o")
    '            strImpressao = strImpressao.Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O")
    '            strImpressao = strImpressao.Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U")
    '            strImpressao = strImpressao.Replace("Ü", "U").Replace("ç", "c").Replace("Ç", "C")
    '            ImprimiArquivo(strImpressao, PortaImpressora)

    '            'If SegViaRecibo = True Then
    '            '    If MsgBox("Deseja imprimir a segunda via?", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '            '        ImprimiArquivo(strImpressao, PortaImpressora)
    '            '    End If
    '            'End If


    '            'iRetorno = FechaPorta()
    '        Else

    '            Dim intTamEsp As Integer
    '            Dim strEstrela, strTraço As String

    '            intTamEsp = 42
    '            strEstrela = "*******************************************************************************************************************************"
    '            strTraço = "..............................................................................................................................." & vbCrLf
    '            'strEstrela = "******************************************"
    '            'strTraço = ".........................................."

    '            'iRetorno = IniciaPorta(PortaImpressora)

    '            'Dim strTracoMenor As String = "...................................."
    '            Dim strTracoMenor As String = "..............................................................................................................................." & vbCrLf


    '            Dim strFunc As String = Me.lueFunc.Text


    '            Dim strDt As String = Me.dtData.Text
    '            strDt = strDt.Substring(0, 10)
    '            Dim strHora As String = My.Computer.Clock.LocalTime

    '            If strHora.Length = 19 Then
    '                strHora = strHora.Substring(10, 9)
    '            End If


    '            'Dim dtClient As DataTable = CarregarDataTable("select nome,numero, fantasia, endereco, cidade, telefone, bairro from cliente left join total on cliente.codigo = total.codcli where total.codordem =" & intCodCli)
    '            'Dim strNome, strFant, strEnd, strCid, strTel, strBairro, strNum As String
    '            'strNome = dtClient.Rows(0).Item("nome").ToString
    '            'strFant = dtClient.Rows(0).Item("fantasia").ToString
    '            'strEnd = dtClient.Rows(0).Item("endereco").ToString
    '            'strCid = dtClient.Rows(0).Item("cidade").ToString
    '            'strTel = dtClient.Rows(0).Item("telefone").ToString
    '            'strBairro = dtClient.Rows(0).Item("bairro").ToString
    '            'strNum = dtClient.Rows(0).Item("numero").ToString


    '            Dim dtClient As DataTable = CarregarDataTable("select nome,numero, fantasia, endereco, cidade, telefone, bairro from cliente where Codigo =" & intCodCli)
    '            Dim strNome, strFant, strEnd, strCid, strTel, strBairro, strNum As String
    '            If dtClient.Rows.Count > 0 Then

    '                strNome = dtClient.Rows(0).Item("nome").ToString
    '                strFant = dtClient.Rows(0).Item("fantasia").ToString
    '                strEnd = dtClient.Rows(0).Item("endereco").ToString
    '                strCid = dtClient.Rows(0).Item("cidade").ToString
    '                strTel = dtClient.Rows(0).Item("telefone").ToString
    '                strBairro = dtClient.Rows(0).Item("bairro").ToString
    '                strNum = dtClient.Rows(0).Item("numero").ToString

    '            End If


    '            Dim strImpressao As String = Cent(NomeEmpresa.ToString.Trim, 127) & vbCrLf
    '            strImpressao &= Cent(TelefoneEmpresa.Trim & " " & EnderecoEmpresa.Trim, 127) & vbCrLf
    '            strImpressao &= strTraço & strTraço & strTracoMenor & "." & vbCrLf '"......." & vbCrLf

    '            strImpressao &= DirCorte("VENDEDOR: " & strFunc, 40) & DirCorte("DATA: " & strDt & " COD.PEDIDO: " & Me.txtCodPed.Text, 49) & Dir("HORA: " & strHora, 11) & vbCrLf
    '            strImpressao &= DirCorte("CLIENTE: " & strNome, 64) & DirCorte("NOME FANTASIA: " & strFant, 64) & vbCrLf
    '            strImpressao &= DirCorte("ENDEREÇO: " & strEnd & " " & strNum, 50) & DirCorte("CIDADE: " & strCid, 32) & DirCorte("TEL: " & strTel, 15) & DirCorte("BAIRRO: " & strBairro, 31) & vbCrLf
    '            strImpressao &= DirCorte("SEGUNDA VIA IMPRESSA ." & strTraço & strTracoMenor & strTracoMenor, 127) & vbCrLf
    '            If NomeEmpresa.Contains("SKINA") Then
    '                strImpressao &= "Qtd  Descricao                                   Marca       Cod.Interno   Aplicacao                 Valor Unit.     Sub.Total" & vbCrLf
    '            Else
    '                strImpressao &= "Codigo       Descricao                                                                Qtde.         Valor Unit.       Sub.Total" & vbCrLf
    '            End If

    '            strImpressao &= strTraço

    '            Dim dblUni, dblQt As Double
    '            Dim dblTot As Double = 0.0
    '            Dim dblLiq As Double = 0.0
    '            Dim L As Integer
    '            If Me.grd1.RowCount < 13 Then
    '                For L = 0 To 12
    '                    If Me.grd1.RowCount - 1 >= L Then
    '                        Dim strCod, strProd, strUM, strFab, strObs, strCodProd As String
    '                        strCodProd = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoProduto)


    '                        strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoPeca)
    '                        strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
    '                        dblUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
    '                        dblQt = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
    '                        dblTot = Me.grd1.GetRowCellDisplayText(L, Me.colValorTotal)
    '                        strUM = Me.grd1.GetRowCellDisplayText(L, Me.colUM)
    '                        Dim dtProd As DataTable = CarregarDataTable("SELECT Setor, Obs FROM Produto where Codigo = " & strCodProd)

    '                        If dtProd.Rows.Count > 0 Then
    '                            strFab = dtProd.Rows.Item(0).Item("Setor").ToString
    '                            strObs = dtProd.Rows.Item(0).Item("Obs").ToString
    '                        End If

    '                        If strUM.Trim = "" Then
    '                            strUM = "UN"
    '                        End If

    '                        dblLiq = dblLiq + dblTot

    '                        If NomeEmpresa.Contains("SKINA") Then
    '                            strImpressao &= DirCorte(dblQt.ToString("N2"), 4) & DirCorte("  " & strProd, 44) & DirCorte("  " & strFab, 11) & DirCorte("   " & strCod, 13) & DirCorte("    " & strObs, 27) & Esq("     " & dblUni.ToString("C2"), 14) & Esq("      " & dblTot.ToString("C2"), 14) & vbCrLf
    '                        Else
    '                            strImpressao &= DirCorte(strCod, 11) & DirCorte("  " & strProd, 72) & Esq((dblQt.ToString("N3")), 12) & Esq(dblUni.ToString("C2"), 16) & Esq(dblTot.ToString("C2"), 16) & vbCrLf
    '                        End If

    '                    Else
    '                        strImpressao &= "." & vbCrLf
    '                    End If
    '                Next

    '            Else
    '                For L = 0 To Me.grd1.RowCount - 1
    '                    Dim strCod, strProd, strUM, strFab, strObs, strCodProd As String
    '                    strCodProd = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoProduto)


    '                    strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoPeca)
    '                    strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
    '                    dblUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
    '                    dblQt = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
    '                    dblTot = Me.grd1.GetRowCellDisplayText(L, Me.colValorTotal)
    '                    strUM = Me.grd1.GetRowCellDisplayText(L, Me.colUM)
    '                    Dim dtProd As DataTable = CarregarDataTable("SELECT Setor, Obs FROM Produto where Codigo = " & strCodProd)

    '                    If dtProd.Rows.Count > 0 Then
    '                        strFab = dtProd.Rows.Item(0).Item("Setor").ToString
    '                        strObs = dtProd.Rows.Item(0).Item("Obs").ToString
    '                    End If

    '                    If strUM.Trim = "" Then
    '                        strUM = "UN"
    '                    End If

    '                    dblLiq = dblLiq + dblTot

    '                    strImpressao &= DirCorte(dblQt.ToString("N2"), 4) & DirCorte("  " & strProd, 30) & DirCorte("  " & strFab, 11) & DirCorte("   " & strCod, 13) & DirCorte("    " & strObs, 27) & Esq("     " & dblUni.ToString("C2"), 14) & Esq("      " & dblTot.ToString("C2"), 14) & vbCrLf
    '                Next
    '            End If



    '            strImpressao &= vbCrLf & vbCrLf & vbCrLf & vbCrLf & Esq("TOTAL: " & dblLiq.ToString("C2"), 127) & vbCrLf
    '            strImpressao &= vbCrLf & vbCrLf & "ASS:_______________________________________________________ Veiculo: __________________________________________________________" & vbCrLf
    '            strImpressao &= Cent(ObsPedido, 128) & vbCrLf

    '            strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A")
    '            strImpressao = strImpressao.Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E")
    '            strImpressao = strImpressao.Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o")
    '            strImpressao = strImpressao.Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O")
    '            strImpressao = strImpressao.Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U")
    '            strImpressao = strImpressao.Replace("Ü", "U").Replace("ç", "c").Replace("Ç", "C")
    '            ImprimiArquivo(strImpressao, PortaImpressora)

    '            'If SegViaRecibo = True Then
    '            '    If MsgBox("Deseja imprimir a segunda via?", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '            '        ImprimiArquivo(strImpressao, PortaImpressora)
    '            '    End If
    '            'End If


    '            'iRetorno = FechaPorta()
    '        End If
    '    End If

    '    If Impressora = "MATRICIAL 80" Then




    '        Dim strTracoMenor As String = "--------------------------------------------------------------------------------"

    '        Dim strFunc As String = Me.lueFunc.Text


    '        Dim strDt As String = Me.dtData.Text
    '        Dim strHora As String = My.Computer.Clock.LocalTime



    '        'Dim dtClient As DataTable = CarregarDataTable("select nome,numero, fantasia, endereco, cidade, telefone, bairro from cliente left join total on cliente.codigo = total.codcli where total.codordem =" & intCodCli)
    '        'Dim strNome, strFant, strEnd, strCid, strTel, strBairro, strNum As String
    '        'strNome = dtClient.Rows(0).Item("nome").ToString
    '        'strFant = dtClient.Rows(0).Item("fantasia").ToString
    '        'strEnd = dtClient.Rows(0).Item("endereco").ToString
    '        'strCid = dtClient.Rows(0).Item("cidade").ToString
    '        'strTel = dtClient.Rows(0).Item("telefone").ToString
    '        'strBairro = dtClient.Rows(0).Item("bairro").ToString
    '        'strNum = dtClient.Rows(0).Item("numero").ToString


    '        Dim dtClient As DataTable = CarregarDataTable("select nome,numero, fantasia, endereco, cidade, telefone, bairro, CPF, RGIE from cliente where Codigo =" & intCodCli)
    '        Dim strNome, strFant, strEnd, strCid, strTel, strBairro, strNum, strCPFCNPF, strRGIE As String
    '        If dtClient.Rows.Count > 0 Then


    '            strNome = dtClient.Rows(0).Item("nome").ToString
    '            strFant = dtClient.Rows(0).Item("fantasia").ToString
    '            strEnd = dtClient.Rows(0).Item("endereco").ToString
    '            strCid = dtClient.Rows(0).Item("cidade").ToString
    '            strTel = dtClient.Rows(0).Item("telefone").ToString
    '            strBairro = dtClient.Rows(0).Item("bairro").ToString
    '            strNum = dtClient.Rows(0).Item("numero").ToString
    '            strCPFCNPF = dtClient.Rows(0).Item("CPF").ToString
    '            strRGIE = dtClient.Rows(0).Item("RGIE").ToString


    '        End If


    '        Dim strImpressao As String = Cent(NomeEmpresa.ToString.Trim, 80) & vbCrLf
    '        strImpressao &= Cent(EnderecoEmpresa.Trim, 80) & vbCrLf
    '        strImpressao &= Cent(TelefoneEmpresa.Trim, 80) & vbCrLf
    '        strImpressao &= strTracoMenor & vbCrLf

    '        strImpressao &= DirCorte("VEND: " & strFunc, 33) & DirCorte("PEDIDO: " & Me.txtCodPed.Text, 22) & Dir("DATA: " & strHora, 11) & vbCrLf
    '        strImpressao &= strTracoMenor & vbCrLf
    '        strImpressao &= DirCorte("NOME: " & strNome, 55) & DirCorte("CNPJ: " & strCPFCNPF, 25) & vbCrLf
    '        strImpressao &= DirCorte("FANTASIA: " & strFant, 54) & DirCorte("RG/IE: " & strRGIE, 26) & vbCrLf
    '        strImpressao &= DirCorte("END: " & strEnd & " " & strNum, 35) & DirCorte(" " & strCid, 15) & DirCorte(" " & strBairro, 15) & DirCorte(" TEL: " & strTel, 15) & vbCrLf
    '        strImpressao &= strTracoMenor & vbCrLf
    '        strImpressao &= "CODIGO    DESCRICAO " & Space(30) & "QTDE   " & "VALOR UNIT. VALOR TOTAL" & vbCrLf
    '        strImpressao &= strTracoMenor & vbCrLf

    '        Dim dblUni, dblQt As Double
    '        Dim dblTot As Double = 0.0
    '        Dim dblLiq As Double = 0.0
    '        Dim L As Integer

    '        If Me.grd1.RowCount < 13 Then
    '            For L = 0 To 12
    '                If Me.grd1.RowCount - 1 >= L Then
    '                    Dim strCod, strProd, strUM, strFab, strObs, strCodProd, strCodBarra As String
    '                    strCodProd = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoProduto)

    '                    strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoPeca)
    '                    strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
    '                    dblUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
    '                    dblQt = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
    '                    dblTot = Me.grd1.GetRowCellDisplayText(L, Me.colValorTotal)
    '                    strUM = Me.grd1.GetRowCellDisplayText(L, Me.colUM)
    '                    Dim dtProd As DataTable = CarregarDataTable("SELECT Setor, Obs, CodigoBarra FROM Produto where Codigo = " & strCodProd)

    '                    If dtProd.Rows.Count > 0 Then
    '                        strFab = dtProd.Rows.Item(0).Item("Setor").ToString
    '                        strObs = dtProd.Rows.Item(0).Item("Obs").ToString
    '                        strCodBarra = dtProd.Rows.Item(0).Item("CodigoBarra").ToString
    '                    End If

    '                    If strUM.Trim = "" Then
    '                        strUM = "UN"
    '                    End If

    '                    dblLiq = dblLiq + dblTot

    '                    strImpressao &= DirCorte(strCod, 9) & DirCorte(" " & strProd, 40) & Esq((dblQt.ToString("N3")), 8) & Esq(dblUni.ToString("###,##0.00"), 11) & Esq(dblTot.ToString("###,##0.00"), 12) & vbCrLf

    '                Else
    '                    strImpressao &= " " & vbCrLf
    '                End If

    '            Next

    '        Else
    '            For L = 0 To Me.grd1.RowCount - 1
    '                Dim strCod, strProd, strUM, strFab, strObs, strCodProd, strCodBarra As String
    '                strCodProd = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoProduto)

    '                strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoPeca)
    '                strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
    '                dblUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
    '                dblQt = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
    '                dblTot = Me.grd1.GetRowCellDisplayText(L, Me.colValorTotal)
    '                strUM = Me.grd1.GetRowCellDisplayText(L, Me.colUM)
    '                Dim dtProd As DataTable = CarregarDataTable("SELECT Setor, Obs, CodigoBarra FROM Produto where Codigo = " & strCodProd)

    '                If dtProd.Rows.Count > 0 Then
    '                    strFab = dtProd.Rows.Item(0).Item("Setor").ToString
    '                    strObs = dtProd.Rows.Item(0).Item("Obs").ToString
    '                    strCodBarra = dtProd.Rows.Item(0).Item("CodigoBarra").ToString
    '                End If

    '                If strUM.Trim = "" Then
    '                    strUM = "UN"
    '                End If

    '                dblLiq = dblLiq + dblTot

    '                strImpressao &= DirCorte(strCod, 9) & DirCorte(" " & strProd, 40) & Esq((dblQt.ToString("N3")), 8) & Esq(dblUni.ToString("###,##0.00"), 11) & Esq(dblTot.ToString("###,##0.00"), 12) & vbCrLf
    '            Next

    '        End If


    '        strImpressao &= strTracoMenor & vbCrLf


    '        ObsPedido = Me.txtDesc.Text.Trim

    '        strImpressao &= vbCrLf & ObsPedido & vbCrLf

    '        strImpressao &= " " & vbCrLf

    '        strImpressao &= Esq("ASS:_____________________________________________             TOTAL " & dblLiq.ToString("C2"), 77) & vbCrLf
    '        strImpressao = strImpressao & vbCrLf & vbCrLf



    '        strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A")
    '        strImpressao = strImpressao.Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E")
    '        strImpressao = strImpressao.Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o")
    '        strImpressao = strImpressao.Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O")
    '        strImpressao = strImpressao.Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U")
    '        strImpressao = strImpressao.Replace("Ü", "U").Replace("ç", "c").Replace("Ç", "C")
    '        ImprimiArquivo(strImpressao, PortaImpressora)

    '        'If SegViaRecibo = True Then
    '        '    If MsgBox("Deseja imprimir a segunda via?", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '        '        ImprimiArquivo(strImpressao, PortaImpressora)
    '        '    End If
    '        'End If


    '    End If

    'End Sub
    Private Sub Imprimir()

        Calcular(True)

        If Impressora.Contains("ESC/POS") = True Then
            If intCodCli = 0 Then Exit Sub

            If TipoNano <> 5 Then
                clsImprimir.ImprimePedido(Me.txtCodPed.Text.Trim, intCodCli, Me.dtData.Text, Me.lueFunc.Text.Trim, Me.txtDesc.Text)
            Else
                clsImprimir.ImprimePedido(Me.txtCodPed.Text.Trim, intCodCli, Me.dtData.Text, UserNano, Me.txtDesc.Text)
            End If

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
            strImpressao &= "<ad>UN.   TAM.   QTD.   VL UNIT R$        VL Total R$</ad>" & vbCrLf
            strImpressao &= "<tc>-</tc>" & vbCrLf

            Dim L As Integer
            Dim dblQtd As Double
            For L = 0 To Me.grd1.RowCount - 1
                If Me.grd1.GetRowCellDisplayText(L, Me.colAutorizado) = True Then


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
                End If
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

            dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade, Fantasia from Cliente where Codigo =" & intCodCli)

            If dt.Rows.Count > 0 Then
                If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                    strImpressao &= "<c>" & dt.Rows.Item(0).Item("Nome").ToString & "</c>" & vbCrLf
                End If
                If dt.Rows.Item(0).Item("Fantasia").ToString.Trim <> "" And dt.Rows.Item(0).Item("Fantasia").ToString.Trim <> "CONSUMIDOR" Then
                    strImpressao &= "<c>" & dt.Rows.Item(0).Item("Fantasia").ToString & "</c>" & vbCrLf
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


            If Me.txtPlaca.Text <> "" Then
                strImpressao &= "<tc>-</tc>" & vbCrLf
                StringImpressao &= "<c>" & "Placa: " & Me.txtPlaca.Text & "</c>" & vbCrLf

                If Me.txtMod.Text <> "" Then
                    StringImpressao &= "<c>" & "Modelo: " & Me.txtMod.Text & " - " & Me.txtCor.Text & "</c>" & vbCrLf
                End If

                If Me.txtAno.Text <> "" Then
                    StringImpressao &= "<c>" & "Ano: " & Me.txtAno.Text & " - " & Me.txtMotor.Text & "</c>" & vbCrLf
                End If
                If Me.txtKm.Text <> "" Then
                    StringImpressao &= "<c>" & "KM Entrada: " & Me.txtKm.Text & "</c>" & vbCrLf
                End If
                If Me.txtKMSaida.Text <> "" Then
                    StringImpressao &= "<c>" & "KM Saída: " & Me.txtKMSaida.Text & "</c>" & vbCrLf
                End If
                strImpressao &= "<tc>-</tc>" & vbCrLf
            End If

            If Me.txtDesc.Text <> "" Then
                strImpressao &= "<c>" & "Observações: " & Me.txtDesc.Text.Trim & "</c>" & vbCrLf
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

                'If MsgBox("Deseja imprimir a segunda via?", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                '    iRetorno = (iImprimirTexto_DUAL_DarumaFramework(strImpressao, 0))
                'End If

            End If
        ElseIf Impressora.Contains("BEMATECH") Or Impressora.Contains("ARQUIVO") Or Impressora.Contains("NANO PRINT") Then

            Dim strImpressao As String
            If Impressora.Contains("MP-4000") Then
                iRetorno = ConfiguraModeloImpressora(5)
                iRetorno = SelecionaQualidadeImpressao(3)
            Else
                If Impressora.Contains("BEMATECH") = True Then
                    iRetorno = ConfiguraModeloImpressora(1)
                    'Else
                    '    Try
                    '        iRetorno = ConfiguraModeloImpressora(1)
                    '    Catch ex As Exception

                    '    End Try
                End If

            End If
            If Impressora.Contains("BEMATECH") = True Then
                iRetorno = clsBematech.IniciaPorta(PortaImpressora)

            ElseIf Impressora.Contains("MP-4000") = True Then
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
                If Me.grd1.GetRowCellValue(L, Me.colAutorizado) = True Then




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
                End If
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

            dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade, Fantasia from Cliente where Codigo =" & intCodCli)

            If dt.Rows.Count > 0 Then
                If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                    strImpressao &= dt.Rows.Item(0).Item("Nome").ToString & vbCrLf
                End If
                If dt.Rows.Item(0).Item("Fantasia").ToString.Trim <> "" And dt.Rows.Item(0).Item("Fantasia").ToString.Trim <> "CONSUMIDOR" Then
                    strImpressao &= dt.Rows.Item(0).Item("Fantasia").ToString & vbCrLf
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

         
            If Me.txtPlaca.Text <> "" Then
                strImpressao &= "Placa: " & Me.txtPlaca.Text & vbCrLf

                If Me.txtMod.Text <> "" Then
                    strImpressao &= "Modelo: " & Me.txtMod.Text & " - " & Me.txtCor.Text & vbCrLf
                End If

                If Me.txtAno.Text <> "" Then
                    strImpressao &= "Ano: " & Me.txtAno.Text & " - " & Me.txtMotor.Text & vbCrLf
                End If
                If Me.txtKm.Text <> "" Then
                    strImpressao &= "KM Entrada: " & Me.txtKm.Text & vbCrLf
                End If
                If Me.txtKMSaida.Text <> "" Then
                    strImpressao &= "KM Saída: " & Me.txtKMSaida.Text & vbCrLf
                End If

                strImpressao &= " " & vbCrLf
            End If


            If Me.txtDesc.Text <> "" Then
                strImpressao &= "Observações: " & Me.txtDesc.Text.Trim & vbCrLf
                strImpressao &= " " & vbCrLf
            End If


            strImpressao &= Cent("DOCUMENTO NÃO FISCAL", intTamEsp) & vbCrLf

            strImpressao &= strTraço & vbCrLf
            strImpressao &= Cent(NomeEmpresa.ToString.Trim, intTamEsp) & vbCrLf

            strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")

            If Impressora = "ARQUIVO" Then
                'If NomeEmpresa.Contains("CAVALAO") = True Then
                '    clsImprimir.SendStringToPrinter(PortaImpressora, strImpressao)
                'Else
                '    ImprimiArquivo(strImpressao, PortaImpressora)

                'End If
                clsImprimir.SendStringToPrinter(PortaImpressora, strImpressao)
                If TemGuilhotina = True Then
                    strImpressao = clsImprimir.Avanco() & vbCrLf
                    strImpressao &= clsImprimir.Corte()
                    clsImprimir.SendStringToPrinter(PortaImpressora, strImpressao)
                End If

                If TemGaveta = True Then
                    strImpressao = clsImprimir.AbreGaveta() & vbCrLf
                    clsImprimir.SendStringToPrinter(PortaImpressora, strImpressao)
                End If
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

                If Impressora.Contains("BEMATECH") = True Then
                    iRetorno = clsBematech.FechaPorta()
                Else
                    Try
                        iRetorno = clsBematech.FechaPorta()
                    Catch ex As Exception

                    End Try
                End If
            End If


            'SegundaVia(strImpressao)
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
                If Me.grd1.GetRowCellDisplayText(L, Me.colAutorizado) = True Then



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
                End If
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

            dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade, Fantasia from Cliente where Codigo =" & intCodCli)

            If dt.Rows.Count > 0 Then
                If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                    strImpressao &= dt.Rows.Item(0).Item("Nome").ToString & vbCrLf
                End If
                If dt.Rows.Item(0).Item("Fantasia").ToString.Trim <> "" And dt.Rows.Item(0).Item("Fantasia").ToString.Trim <> "CONSUMIDOR" Then
                    strImpressao &= dt.Rows.Item(0).Item("Fantasia").ToString & vbCrLf
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
            If Me.txtPlaca.Text <> "" Then

                strImpressao &= "Placa: " & Me.txtPlaca.Text & vbCrLf

                If Me.txtMod.Text <> "" Then
                    strImpressao &= "Modelo: " & Me.txtMod.Text & " - " & Me.txtCor.Text & vbCrLf
                End If

                If Me.txtAno.Text <> "" Then
                    strImpressao &= "Ano: " & Me.txtAno.Text & " - " & Me.txtMotor.Text & vbCrLf
                End If
                If Me.txtKm.Text <> "" Then
                    strImpressao &= "KM Entrada: " & Me.txtKm.Text & vbCrLf
                End If
                If Me.txtKMSaida.Text <> "" Then
                    strImpressao &= "KM Saída: " & Me.txtKMSaida.Text & vbCrLf
                End If

                strImpressao &= " " & vbCrLf
            End If
            If Me.txtDesc.Text <> "" Then
                strImpressao &= "Observações: " & Me.txtDesc.Text.Trim & vbCrLf
                strImpressao &= " " & vbCrLf
            End If
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

            'If SegViaRecibo = True Then
            '    If MsgBox("Deseja imprimir a segunda via?", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            '        iRetorno = clsEpson.IniciaPorta(PortaImpressora)

            '        iRetorno = clsEpson.ImprimeTextoTag(strImpressao)

            '        If TemGuilhotina = True Then
            '            iRetorno = clsEpson.AcionaGuilhotina(1)
            '        End If

            '        iRetorno = clsEpson.FechaPorta()
            '    End If
            'End If
        ElseIf Impressora = "MATRICIAL" Then
            If NomeEmpresa.ToString.ToUpper.Contains("BAREX") = True Then
                Dim intTamEsp As Integer
                Dim strEstrela, strTraço As String

                intTamEsp = 42
                strEstrela = "*****************************************************************************"
                'strTraço = "............................................................................." & vbCrLf

                'iRetorno = IniciaPorta(PortaImpressora)

                Dim strTracoMenor As String = "............................................................................." & vbCrLf

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


                Dim dtClient As DataTable = CarregarDataTable("select nome,numero, fantasia, endereco, cidade, telefone, bairro from cliente where Codigo =" & intCodCli)
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


                'Dim strImpressao As String = Cent(NomeEmpresa.ToString.Trim, 77) & vbCrLf
                'strImpressao &= Cent(TelefoneEmpresa.Trim & " " & EnderecoEmpresa.Trim, 77) & vbCrLf
                'strImpressao &= strTraço & strTraço & strTracoMenor & "." & vbCrLf '"......." & vbCrLf

                'strImpressao &= DirCorte("VEND: " & strFunc, 30) & DirCorte("PEDIDO: " & Me.txtCodPed.Text, 22) & Dir("DATA: " & strDt & "" & strHora, 11) & vbCrLf
                'strImpressao &= DirCorte("CLIENTE: " & strNome, 44) & DirCorte("FANTASIA: " & strFant, 44) & vbCrLf
                'strImpressao &= DirCorte("" & strEnd & " " & strNum, 33) & DirCorte(" " & strCid, 15) & DirCorte(" " & strBairro, 10) & DirCorte("TEL: " & strTel, 20) & vbCrLf
                'strImpressao &= DirCorte("SEGUNDA VIA IMPRESSA ." & strTraço & strTracoMenor & strTracoMenor, 77) & vbCrLf
                ''If NomeEmpresa.Contains("SKINA") Then
                ''    strImpressao &= "Qtd  Descricao                                   Marca       Cod.Interno   Aplicacao                 Valor Unit.     Sub.Total" & vbCrLf
                ''Else
                'strImpressao &= "Codigo  CodigoBarra  Descricao " & Space(15) & "Qtde. " & Space(5) & " Valor Unit.       Sub.Total" & vbCrLf
                ''End If

                'strImpressao &= strTraço

                Dim strImpressao As String = Cent(NomeEmpresa.ToString.Trim, 77) & vbCrLf
                strImpressao &= Cent(TelefoneEmpresa.Trim, 77) & vbCrLf
                strImpressao &= Cent(EnderecoEmpresa.Trim, 77) & vbCrLf
                strImpressao &= strTraço & strTraço & strTracoMenor & "." & vbCrLf '"......." & vbCrLf

                strImpressao &= DirCorte("VENDEDOR: " & strFunc, 30) & DirCorte("PEDIDO: " & Me.txtCodPed.Text, 22) & Dir("DATA:" & strDt & " " & strHora, 11) & vbCrLf
                strImpressao &= DirCorte("CLIENTE: " & strNome, 39) & DirCorte(" FANTASIA: " & strFant, 44) & vbCrLf
                strImpressao &= DirCorte("" & strEnd & " " & strNum, 33) & DirCorte(" " & strCid, 14) & DirCorte(" " & strBairro, 10) & DirCorte(" TEL: " & strTel.Trim, 20) & vbCrLf
                Dim strTraço2 As String = "............................................................................."
                strImpressao &= DirCorte("SEGUNDA VIA IMPRESSA ." & strTraço2 & strTracoMenor & strTracoMenor, 77) & vbCrLf

                strImpressao &= "Codigo  Cod. Origem  Descricao " & Space(15) & "Qtde. " & Space(2) & " Valor Unit.  Sub.Total" & vbCrLf


                strImpressao &= strTraço


                Dim dblUni, dblQt As Double
                Dim dblTot As Double = 0.0
                Dim dblLiq As Double = 0.0
                Dim L As Integer
                If Me.grd1.RowCount < 13 Then
                    For L = 0 To 13
                        If Me.grd1.RowCount - 1 >= L Then
                            Dim strCod, strProd, strUM, strFab, strObs, strCodProd, strCodBarra As String
                            strCodProd = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoProduto)


                            strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoPeca)
                            strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
                            dblUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
                            dblQt = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
                            dblTot = Me.grd1.GetRowCellDisplayText(L, Me.colValorTotal)
                            strUM = Me.grd1.GetRowCellDisplayText(L, Me.colUM)
                            Dim dtProd As DataTable = CarregarDataTable("SELECT Setor, Obs, CodigoBarra FROM Produto where Codigo = " & strCodProd)

                            If dtProd.Rows.Count > 0 Then
                                strFab = dtProd.Rows.Item(0).Item("Setor").ToString
                                strObs = dtProd.Rows.Item(0).Item("Obs").ToString
                                strCodBarra = dtProd.Rows.Item(0).Item("CodigoBarra").ToString
                            End If

                            If strUM.Trim = "" Then
                                strUM = "UN"
                            End If

                            dblLiq = dblLiq + dblTot

                            strImpressao &= DirCorte(strCod, 8) & DirCorte(strCodBarra, 11) & DirCorte("  " & strProd, 25) & Esq((dblQt.ToString("N3")), 7) & Esq(dblUni.ToString("C2"), 13) & Esq(dblTot.ToString("C2"), 13) & vbCrLf

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



                'strImpressao &= vbCrLf & vbCrLf & vbCrLf & vbCrLf & Esq("TOTAL: " & dblLiq.ToString("C2"), 127) & vbCrLf
                'strImpressao &= vbCrLf & vbCrLf & "ASS:_______________________________________________________ Veiculo: __________________________________________________________" & vbCrLf
                'strImpressao &= Cent(ObsPedido, 128) & vbCrLf

                If NomeEmpresa.ToString.ToUpper.Contains("BAREX") = True Then
                    strImpressao &= Esq("TOTAL: " & dblLiq.ToString("C2"), 77) & vbCrLf
                    strImpressao &= vbCrLf & Cent(ObsPedido, 77) & vbCrLf
                    strImpressao = strImpressao & vbCrLf & vbCrLf
                Else
                    strImpressao &= vbCrLf & vbCrLf & vbCrLf & vbCrLf & Esq("TOTAL: " & dblLiq.ToString("C2"), 127) & vbCrLf
                    strImpressao &= vbCrLf & vbCrLf & "ASS:_______________________________________________________ Veiculo: __________________________________________________________" & vbCrLf
                    strImpressao &= Cent(ObsPedido, 128) & vbCrLf
                End If


                strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A")
                strImpressao = strImpressao.Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E")
                strImpressao = strImpressao.Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o")
                strImpressao = strImpressao.Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O")
                strImpressao = strImpressao.Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U")
                strImpressao = strImpressao.Replace("Ü", "U").Replace("ç", "c").Replace("Ç", "C")
                ImprimiArquivo(strImpressao, PortaImpressora)

                'If SegViaRecibo = True Then
                '    If MsgBox("Deseja imprimir a segunda via?", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                '        ImprimiArquivo(strImpressao, PortaImpressora)
                '    End If
                'End If


                'iRetorno = FechaPorta()
            Else

                Dim intTamEsp As Integer
                Dim strEstrela, strTraço As String

                intTamEsp = 42
                strEstrela = "*******************************************************************************************************************************"
                strTraço = "..............................................................................................................................." & vbCrLf
                'strEstrela = "******************************************"
                'strTraço = ".........................................."

                'iRetorno = IniciaPorta(PortaImpressora)

                'Dim strTracoMenor As String = "...................................."
                Dim strTracoMenor As String = "..............................................................................................................................." & vbCrLf


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


                Dim dtClient As DataTable = CarregarDataTable("select nome,numero, fantasia, endereco, cidade, telefone, bairro from cliente where Codigo =" & intCodCli)
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
                strImpressao &= strTraço & strTraço & strTracoMenor & "." & vbCrLf '"......." & vbCrLf

                strImpressao &= DirCorte("VENDEDOR: " & strFunc, 40) & DirCorte("DATA: " & strDt & " COD.PEDIDO: " & Me.txtCodPed.Text, 49) & Dir("HORA: " & strHora, 11) & vbCrLf
                strImpressao &= DirCorte("CLIENTE: " & strNome, 64) & DirCorte("NOME FANTASIA: " & strFant, 64) & vbCrLf
                strImpressao &= DirCorte("ENDEREÇO: " & strEnd & " " & strNum, 50) & DirCorte("CIDADE: " & strCid, 32) & DirCorte("TEL: " & strTel, 15) & DirCorte("BAIRRO: " & strBairro, 31) & vbCrLf
                strImpressao &= DirCorte("SEGUNDA VIA IMPRESSA ." & strTraço & strTracoMenor & strTracoMenor, 127) & vbCrLf
                If NomeEmpresa.Contains("SKINA") Then
                    strImpressao &= "Qtd  Descricao                                   Marca       Cod.Interno   Aplicacao                 Valor Unit.     Sub.Total" & vbCrLf
                Else
                    strImpressao &= "Codigo       Descricao                                                                Qtde.         Valor Unit.       Sub.Total" & vbCrLf
                End If

                strImpressao &= strTraço

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

                'If SegViaRecibo = True Then
                '    If MsgBox("Deseja imprimir a segunda via?", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                '        ImprimiArquivo(strImpressao, PortaImpressora)
                '    End If
                'End If


                'iRetorno = FechaPorta()
            End If
        ElseIf Impressora = "MATRICIAL 80" Then




            Dim strTracoMenor As String = "--------------------------------------------------------------------------------"

            Dim strFunc As String = Me.lueFunc.Text


            Dim strDt As String = Me.dtData.Text
            Dim strHora As String = My.Computer.Clock.LocalTime



            'Dim dtClient As DataTable = CarregarDataTable("select nome,numero, fantasia, endereco, cidade, telefone, bairro from cliente left join total on cliente.codigo = total.codcli where total.codordem =" & intCodCli)
            'Dim strNome, strFant, strEnd, strCid, strTel, strBairro, strNum As String
            'strNome = dtClient.Rows(0).Item("nome").ToString
            'strFant = dtClient.Rows(0).Item("fantasia").ToString
            'strEnd = dtClient.Rows(0).Item("endereco").ToString
            'strCid = dtClient.Rows(0).Item("cidade").ToString
            'strTel = dtClient.Rows(0).Item("telefone").ToString
            'strBairro = dtClient.Rows(0).Item("bairro").ToString
            'strNum = dtClient.Rows(0).Item("numero").ToString


            Dim dtClient As DataTable = CarregarDataTable("select nome,numero, fantasia, endereco, cidade, telefone, bairro, CPF, RGIE from cliente where Codigo =" & intCodCli)
            Dim strNome, strFant, strEnd, strCid, strTel, strBairro, strNum, strCPFCNPF, strRGIE As String
            If dtClient.Rows.Count > 0 Then


                strNome = dtClient.Rows(0).Item("nome").ToString
                strFant = dtClient.Rows(0).Item("fantasia").ToString
                strEnd = dtClient.Rows(0).Item("endereco").ToString
                strCid = dtClient.Rows(0).Item("cidade").ToString
                strTel = dtClient.Rows(0).Item("telefone").ToString
                strBairro = dtClient.Rows(0).Item("bairro").ToString
                strNum = dtClient.Rows(0).Item("numero").ToString
                strCPFCNPF = dtClient.Rows(0).Item("CPF").ToString
                strRGIE = dtClient.Rows(0).Item("RGIE").ToString


            End If


            Dim strImpressao As String = Cent(NomeEmpresa.ToString.Trim, 80) & vbCrLf
            strImpressao &= Cent(EnderecoEmpresa.Trim, 80) & vbCrLf
            strImpressao &= Cent(TelefoneEmpresa.Trim, 80) & vbCrLf
            strImpressao &= strTracoMenor & vbCrLf

            strImpressao &= DirCorte("VEND: " & strFunc, 33) & DirCorte("PEDIDO: " & Me.txtCodPed.Text, 22) & Dir("DATA: " & strHora, 11) & vbCrLf
            strImpressao &= strTracoMenor & vbCrLf
            strImpressao &= DirCorte("NOME: " & strNome, 55) & DirCorte("CNPJ: " & strCPFCNPF, 25) & vbCrLf
            strImpressao &= DirCorte("FANTASIA: " & strFant, 54) & DirCorte("RG/IE: " & strRGIE, 26) & vbCrLf
            strImpressao &= DirCorte("END: " & strEnd & " " & strNum, 35) & DirCorte(" " & strCid, 15) & DirCorte(" " & strBairro, 15) & DirCorte(" TEL: " & strTel, 15) & vbCrLf
            strImpressao &= strTracoMenor & vbCrLf
            strImpressao &= "CODIGO    DESCRICAO " & Space(30) & "QTDE   " & "VALOR UNIT. VALOR TOTAL" & vbCrLf
            strImpressao &= strTracoMenor & vbCrLf

            Dim dblUni, dblQt As Double
            Dim dblTot As Double = 0.0
            Dim dblLiq As Double = 0.0
            Dim L As Integer

            ObsPedido = Me.txtDesc.Text.Trim


            Dim intContSplt As Integer

            intContSplt = Split(ObsPedido, CChar(vbCrLf)).Length

            intContSplt = 12 - intContSplt


            Dim intGrid As Integer = Me.grd1.RowCount

            If intContSplt < intGrid Then
                intContSplt = intGrid
            End If

            If Me.grd1.RowCount < 13 Then



                For L = 0 To intContSplt
                    If Me.grd1.RowCount - 1 >= L Then
                        Dim strCod, strProd, strUM, strFab, strObs, strCodProd, strCodBarra As String
                        strCodProd = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoProduto)

                        strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoPeca)
                        strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
                        dblUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
                        dblQt = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
                        dblTot = Me.grd1.GetRowCellDisplayText(L, Me.colValorTotal)
                        strUM = Me.grd1.GetRowCellDisplayText(L, Me.colUM)
                        Dim dtProd As DataTable = CarregarDataTable("SELECT Setor, Obs, CodigoBarra FROM Produto where Codigo = " & strCodProd)

                        If dtProd.Rows.Count > 0 Then
                            strFab = dtProd.Rows.Item(0).Item("Setor").ToString
                            strObs = dtProd.Rows.Item(0).Item("Obs").ToString
                            strCodBarra = dtProd.Rows.Item(0).Item("CodigoBarra").ToString
                        End If

                        If strUM.Trim = "" Then
                            strUM = "UN"
                        End If

                        dblLiq = dblLiq + dblTot

                        strImpressao &= DirCorte(strCod, 9) & DirCorte(" " & strProd, 40) & Esq((dblQt.ToString("N3")), 8) & Esq(dblUni.ToString("###,##0.00"), 11) & Esq(dblTot.ToString("###,##0.00"), 12) & vbCrLf

                    Else
                        strImpressao &= " " & vbCrLf
                    End If

                Next

            Else
                For L = 0 To Me.grd1.RowCount - 1
                    Dim strCod, strProd, strUM, strFab, strObs, strCodProd, strCodBarra As String
                    strCodProd = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoProduto)

                    strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodigoPeca)
                    strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
                    dblUni = Me.grd1.GetRowCellDisplayText(L, Me.colValorUnitario)
                    dblQt = Me.grd1.GetRowCellDisplayText(L, Me.colQtd)
                    dblTot = Me.grd1.GetRowCellDisplayText(L, Me.colValorTotal)
                    strUM = Me.grd1.GetRowCellDisplayText(L, Me.colUM)
                    Dim dtProd As DataTable = CarregarDataTable("SELECT Setor, Obs, CodigoBarra FROM Produto where Codigo = " & strCodProd)

                    If dtProd.Rows.Count > 0 Then
                        strFab = dtProd.Rows.Item(0).Item("Setor").ToString
                        strObs = dtProd.Rows.Item(0).Item("Obs").ToString
                        strCodBarra = dtProd.Rows.Item(0).Item("CodigoBarra").ToString
                    End If

                    If strUM.Trim = "" Then
                        strUM = "UN"
                    End If

                    dblLiq = dblLiq + dblTot

                    strImpressao &= DirCorte(strCod, 9) & DirCorte(" " & strProd, 40) & Esq((dblQt.ToString("N3")), 8) & Esq(dblUni.ToString("###,##0.00"), 11) & Esq(dblTot.ToString("###,##0.00"), 12) & vbCrLf
                Next

            End If


            strImpressao &= strTracoMenor & vbCrLf
            If txtValDesc.Text.Trim <> "" Then
                If Val(txtValDesc.Text) <> 0 Then
                    strImpressao &= Cent("** Desconto especial concedido! **", 80) & vbCrLf
                    'strImpressao &= Esq("DESCONTO R$ " & Me.txtValDesc.Text.Trim, 77) & vbCrLf
                Else
                    strImpressao &= " " & vbCrLf
                End If
            Else
                strImpressao &= " " & vbCrLf
            End If
            strImpressao &= vbCrLf & ObsPedido & vbCrLf

            strImpressao &= " " & vbCrLf

            '''antigo desconto

            strImpressao &= Esq("ASS:_____________________________________________             TOTAL " & dblLiq.ToString("C2"), 77) & vbCrLf
            strImpressao = strImpressao & vbCrLf & vbCrLf



            strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A")
            strImpressao = strImpressao.Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E")
            strImpressao = strImpressao.Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o")
            strImpressao = strImpressao.Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O")
            strImpressao = strImpressao.Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U")
            strImpressao = strImpressao.Replace("Ü", "U").Replace("ç", "c").Replace("Ç", "C")
            ImprimiArquivo(strImpressao, PortaImpressora)

            'If SegViaRecibo = True Then
            '    If MsgBox("Deseja imprimir a segunda via?", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            '        ImprimiArquivo(strImpressao, PortaImpressora)
            '    End If
            'End If


        Else
            'VisualizarCompleto(True, False)
            EscolherImpressao(True, False)
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
                    Me.txtValDesconto.BackColor = Color.Bisque
                    Me.txtQtdMedida.Properties.AppearanceReadOnly.BackColor = Color.Bisque

                    Me.txtNomePro.Properties.AppearanceReadOnly.BackColor = Color.Bisque
                    Me.txtValor.Properties.AppearanceDisabled.BackColor = Color.Bisque
                    Me.txtPerDesc.Properties.AppearanceDisabled.BackColor = Color.Bisque
                    Me.txtMedidaB.Properties.AppearanceReadOnly.BackColor = Color.Bisque
                    Me.txtValDesconto.Properties.AppearanceReadOnly.BackColor = Color.Bisque
                    Me.txtMedidaA.BackColor = Color.Bisque
                    Me.txtMedidaB.BackColor = Color.Bisque
                    Me.txtQtdMedida.BackColor = Color.Bisque
                    Me.btnAdd.Text = "Alterar"
                    Me.btnAdd.Image = My.Resources.Alterar
                Case False
                    Me.txtQtdMedida.Properties.AppearanceReadOnly.BackColor = Color.White
                    Me.txtMedidaB.Properties.AppearanceReadOnly.BackColor = Color.White
                    Me.txtMedidaA.BackColor = Color.White
                    Me.txtMedidaB.BackColor = Color.White
                    Me.txtQtdMedida.BackColor = Color.White
                    Me.txtTamanho.BackColor = Color.White
                    Me.txtCodPro.BackColor = Color.White
                    Me.txtNomePro.BackColor = Color.White
                    Me.txtQtd.BackColor = Color.White
                    Me.txtValor.BackColor = Color.White
                    Me.txtPerDesc.BackColor = Color.White
                    Me.txtValDesconto.BackColor = Color.White
                    Me.txtNomePro.Properties.AppearanceReadOnly.BackColor = Color.White
                    Me.txtValor.Properties.AppearanceDisabled.BackColor = Color.White
                    Me.txtPerDesc.Properties.AppearanceDisabled.BackColor = Color.White
                    Me.txtValDesconto.Properties.AppearanceReadOnly.BackColor = Color.White
                    Me.btnAdd.Text = "Adicionar"
                    Me.btnAdd.Image = My.Resources.edit_add
            End Select
        End If

    End Sub

    Private Sub txtDesconto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesconto.KeyPress, txtValDesc.KeyPress, txtKMSaida.KeyPress, txtKm.KeyPress
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

        DescontoComPorcentagem(False)
        If TipoDesconto = "TOTAL" Then
            DescontoComValor(False)
        End If

        Me.txtDesc.Focus()
    End Sub

    Private Sub DescontoMaior()
        If bolMensagemDesconto = False Then
            If Nivel = "USUÁRIO" Then
                If DescontoMaximo <> "" Then

                    If CDbl(Me.txtDesconto.Text.Trim.Replace("-", "")) > CDbl(DescontoMaximo) Then
                        MsgBox("Desconto é maior do que o permitido, digite a senha de um usuário com nível de ADMINISTRADOR!", MsgBoxStyle.Information)
                        Dim frm As New frmSenhaExcluir
                        frm.Tag = "DESCONTO"
                        frm.ShowDialog()
                        If bolSenhaOK = False Then
                            Me.txtValDesc.Text = "0,00"
                            Me.txtDesconto.Text = "0,00"
                            DescontoComValor(False)
                            bolMensagemDesconto = False
                        Else
                            bolMensagemDesconto = True
                        End If

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

        If NomeEmpresa.ToUpper.Contains("LDN AUTO") = True Then

            If ConProdAberto = False Then

                frmPro.Tag = "VENDA"
                frmPro.Show()
                frmPro.Visible = False
                ConProdAberto = True
            End If

            If TipoNano = 5 Then
                Select Case Me.rdgTipoProd.SelectedIndex
                    Case 0
                        frmPro.strTipoProduto = "P"
                        frmPro.grd1.ActiveFilter.NonColumnFilter = "[Tipo] <> 'SERVIÇO'"

                    Case 1
                        frmPro.strTipoProduto = "S"
                        frmPro.grd1.ActiveFilter.NonColumnFilter = "[Tipo] = 'SERVIÇO'"

                    Case 2
                        frmPro.strTipoProduto = "T"
                        frmPro.grd1.ActiveFilter.NonColumnFilter = "[Tipo] <> 'SERVIÇO'"

                End Select
               
            Else
                frmPro.strTipoProduto = ""
                ' frmPro.grd1.ActiveFilter.NonColumnFilter = "[Tipo] <> 'SERVIÇO'"

            End If
            'frm.strFiltroProduto = ""
            frmPro.Tag = "PEDIDO"
            frmPro.strTabPre = Me.cboTabela.Text
            CodigoDoProduto = 0
            QtdeDoProduto = 0
            CodigoDoProdutoAgrupado = ""
            frmPro.Visible = True
            frmPro.Timer1.Start()
            Exit Sub
        Else
            Dim frm As New frmConProduto
            If TipoNano = 5 Then
                Select Case Me.rdgTipoProd.SelectedIndex
                    Case 0
                        frm.strTipoProduto = "P"
                    Case 1
                        frm.strTipoProduto = "S"
                    Case 2
                        frm.strTipoProduto = "T"
                End Select
            Else
                frm.strTipoProduto = ""
            End If
            'frm.strFiltroProduto = ""
            frm.strTabPre = Me.cboTabela.Text
            frm.Tag = "PEDIDO"
            CodigoDoProduto = 0
            QtdeDoProduto = 0
            CodigoDoProdutoAgrupado = ""

            frm.ShowDialog()
        End If

        'If QtdeDoProduto > 0 Then
        '    Me.txtQtd.Text = QtdeDoProduto
        'End If
        'QtdeDoProduto = 0


        If CodigoDoProdutoAgrupado <> "" Then
            Dim I As Integer
            Dim vetProd As Array = Split(CodigoDoProdutoAgrupado, "|")
            If vetProd.Length = 1 Then
                Dim vetCodProd As Array = Split(vetProd(0), "%")
                CodigoDoProduto = vetCodProd(0)
                Me.txtQtd.Text = vetCodProd(1)
                QtdEmb(CodigoDoProduto)
                InserirProdutos()
                QtdeDoProduto = 0
                CodigoDoProduto = -1
            Else
                If TipoNano = 5 Then
                    If Me.cboCodFunc.Text = "" Then
                        InserirVendedor()
                        If Me.cboCodFunc.Text = "" Then
                            MsgBox("Nenhum funcionário selecionado!", MsgBoxStyle.Information)
                            CodigoDoProdutoAgrupado = ""
                            Exit Sub
                        End If
                    End If
                End If

                For I = 0 To vetProd.Length - 1
                    Dim vetCodProd As Array = Split(vetProd(I), "%")
                    CodigoDoProduto = vetCodProd(0)
                    Me.txtQtd.Text = vetCodProd(1)
                    InserirProdutos()
                    Adicinar()

                    QtdeDoProduto = 0
                    CodigoDoProduto = -1
                Next

            End If

        Else
            Me.txtCodPro.ResetText()
            Exit Sub
        End If

        'InserirProdutos()
    End Sub

    Public Sub QtdEmb(ByVal parCodProd)
        Dim dtQtdEmb As DataTable = CarregarDataTable("SELECT QtdEmb FROM Produto where Codigo = " & parCodProd)
        If dtQtdEmb.Rows.Count > 0 Then
            If dtQtdEmb.Rows.Item(0).Item("QtdEmb").ToString <> "" Then
                Dim dblQtdEmb2 As Double = dtQtdEmb.Rows.Item(0).Item("QtdEmb").ToString
                Dim strQtdEmb2 As String = dblQtdEmb2.ToString("0.000")

                If strQtdEmb2 <> "0,000" Then
                    Me.NanoCampo1.Visible = True
                    Me.LabelControl13.Visible = True
                    Me.NanoCampo3.Text = strQtdEmb2

                    If TipoNano <> 5 Then
                        Me.NanoCampo3.Visible = True
                        Me.LabelControl14.Visible = True
                    End If

                    dblQtdEmb = dtQtdEmb.Rows.Item(0).Item("QtdEmb").ToString
                    CalcularQtdEmb()
                Else
                    Me.NanoCampo1.Visible = False
                    Me.LabelControl13.Visible = False
                    Me.NanoCampo3.Visible = False
                    Me.LabelControl14.Visible = False
                    dblQtdEmb = 0
                End If
            Else
                Me.NanoCampo1.Visible = False
                Me.LabelControl13.Visible = False
                Me.NanoCampo3.Visible = False
                Me.LabelControl14.Visible = False
                dblQtdEmb = 0
            End If
            
        Else
            Me.NanoCampo1.Visible = False
            Me.LabelControl13.Visible = False
            Me.NanoCampo3.Visible = False
            Me.LabelControl14.Visible = False
            dblQtdEmb = 0
        End If
    End Sub

    Public Sub InserirVendedor()
        Dim frm As New frmSelecFunc
        frm.Tag = "VENDEDOR"
        CodigoFuncionario = 0
        NomeFuncionario = ""
        frm.ShowDialog()
        Me.cboCodFunc.EditValue = CodigoFuncionario
    End Sub
    Public Sub InserirProdutos()

        Me.txtValor.Enabled = AlteraPrecoPedido

        Dim dtProd As DataTable

        dtProd = CarregarDataTable("SELECT CodigoInterno, CodigoBarra, Nome, Valor, UnidadeMedida, ValorCusto, Desconto, Inativo, Tipo, AlterarPreco, Porcentagens FROM Produto where Codigo = " & CodigoDoProduto)

        TamanhoProd()

        If dtProd.Rows.Count > 0 Then
            Dim bolInativo As Boolean = dtProd.Rows.Item(0).Item("Inativo")

            If AlteraPrecoPedido = False Then
                Dim bolAlterarPreco As Boolean = dtProd.Rows.Item(0).Item("AlterarPreco")
                If bolAlterarPreco = True Then
                    Me.txtValor.Enabled = True
                End If

            End If

            If bolInativo = True Then
                MsgBox("Produto inativo!", MsgBoxStyle.Information)
                bolPromocao = False
                Me.txtPerDesc.Enabled = True
                Me.txtValDesconto.Enabled = True
                If AlteraPrecoPedido = True Then
                    Me.txtValor.Enabled = True
                End If
                Me.txtCodPro.Tag = ""
                Me.txtCodPro.ResetText()
                Me.txtNomePro.ResetText()
                Me.txtValor.ResetText()
                txtQtd.ToolTipTitle = "QUALQUER"
                dblValorDeCusto = 0
                Me.txtCodPro.Focus()
                Me.txtTamanho.ResetText()
                bolDigQtd = False
                Exit Sub
            End If

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
            Dim dblValProd As Double = CampoValor(dtProd.Rows.Item(0).Item("Valor"))
            Me.txtValor.Text = dblValProd

            If Campanha(CodigoDoProduto) = False Then
                Gaxeta(CodigoDoProduto)
            End If

            If Me.cboTabela.Text <> "PADRÃO" Then
                ValorTabela(CodigoDoProduto)
                dblUniSemDesc = CampoValor(txtValor.Text)
            Else
                If ManterMargemProd = True Then
                    Select Case Me.rdgTipoProd.SelectedIndex
                        Case 0
                            Dim dblValCus, dblResul As Double
                            If dtProd.Rows.Item(0).Item("Porcentagens").ToString <> "" Then
                                Dim dblPor As Double = dtProd.Rows.Item(0).Item("Porcentagens").ToString
                                dblValCus = dtProd.Rows.Item(0).Item("ValorCusto").ToString
                                dblResul = (dblValCus * dblPor) / 100
                                dblValProd = dblValCus + dblResul

                            End If
                    End Select


                End If

                Me.txtValor.Text = CampoValor(dblValProd)

                dblUniSemDesc = CampoValor(dblValProd)
            End If

            dblUniSemDescOriginal = dblUniSemDesc
            If dtProd.Rows.Item(0).Item("Desconto").ToString <> "" And dtProd.Rows.Item(0).Item("Desconto").ToString <> "0" And dtProd.Rows.Item(0).Item("Desconto").ToString <> "0,000" And dtProd.Rows.Item(0).Item("Desconto").ToString <> "0,00" Then
                Dim dblPerDesc As Double = dtProd.Rows.Item(0).Item("Desconto").ToString
                Dim dblUni As Double = Me.txtValor.Text
                Dim dblResto As Double = (dblUni / 100) * dblPerDesc

                dblUni = dblUni - dblResto
                Me.txtValor.Text = CampoValor(dblUni)

                bolPromocao = True

                If BloquearDescontoPorItem = True Then
                    Me.txtPerDesc.Enabled = False
                    Me.txtValDesconto.Enabled = False
                    Me.txtValor.Enabled = False
                End If

                Me.txtPerDesc.Text = dblPerDesc.ToString("0.00")
                strDescontoPromocao = dblPerDesc.ToString("0.00")
            Else
                strDescontoPromocao = ""
                bolPromocao = False
                If strDescontoCliente = "" Then
                    Me.txtPerDesc.ResetText()
                End If

                Me.txtPerDesc.Enabled = True
                Me.txtValDesconto.Enabled = True
                If AlteraPrecoPedido = True Then
                    Me.txtValor.Enabled = True
                End If
            End If

            Try
                Dim dblValD As Double = dblUniSemDescOriginal - Me.txtValor.Text
                Me.txtValDesconto.Text = dblValD.ToString("0.000")
            Catch ex As Exception
            End Try

            txtQtd.ToolTipTitle = dtProd.Rows.Item(0).Item("UnidadeMedida").ToString
            dblValorDeCusto = dtProd.Rows.Item(0).Item("ValorCusto").ToString
            strTipoProduto = dtProd.Rows.Item(0).Item("Tipo").ToString
            Me.txtTamanho.Text = TamanhoDoProduto
            strLocacao = ""
            Dim dtLoc As DataTable = CarregarDataTable("SELECT Locacao FROM Locacao where CodProd = " & CodigoDoProduto & " and CodConfig = " & CodConfig)
            If dtLoc.Rows.Count > 0 Then
                strLocacao = dtLoc.Rows.Item(0).Item("Locacao").ToString
            End If

            bolDecimais = True
            bolAbriuProduto = True
            If Me.txtQtd.Text = "" Then
                Me.txtQtd.Text = "1"
            End If


            If Nivel <> "USUÁRIO" Then
                If Me.chkCusto.Checked = True Then
                    Me.txtCusto.Text = dblValorDeCusto.ToString("0.00")
                End If
            End If

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
                        Me.txtValor.Text = dblUni.ToString("0.00")
                        bolPromocao = True
                        If Nivel <> "USUÁRIO" Then
                            Me.txtPerDesc.Enabled = True
                            Me.txtValDesconto.Enabled = True
                        End If
                    End If

                End If
            End If


            Me.lueTabelaPreco.EditValue = DBNull.Value
            CarregarDadosLue("Select 'PADRÃO' as Tabela, Valor FROM Produto where Codigo = " & CodigoDoProduto & " UNION ALL SELECT Grupo.Nome as Tabela, TabelaPreco.Valor From " & _
            "TabelaPreco left join Grupo on TabelaPreco.CodTabela = Grupo.Codigo Where CodProd = " & CodigoDoProduto, Me.lueTabelaPreco)
            Me.lueTabelaPreco.ClosePopup()

            HistoricoQtd(CodigoDoProduto)
            bolMensagemDesconto = False
            Me.txtQtd.Focus()
        Else
            bolPromocao = False
            Me.txtPerDesc.Enabled = True
            Me.txtValDesconto.Enabled = True
            If AlteraPrecoPedido = True Then
                Me.txtValor.Enabled = True
            End If
            Me.txtEmEstoque.ResetText()
            Me.txtEmPedido.ResetText()
            Me.txtSaldoQtd.ResetText()
            Me.txtCodPro.Tag = ""
            Me.txtCodPro.ResetText()
            Me.txtNomePro.ResetText()
            Me.txtValor.ResetText()
            txtQtd.ToolTipTitle = "QUALQUER"
            dblValorDeCusto = 0
            Me.txtCodPro.Focus()
            Me.txtTamanho.ResetText()
            bolDigQtd = False
        End If
    End Sub
    Private Sub HistoricoQtd(ByVal parCodigo As String)
        If parCodigo = "" Then
            Me.txtEmEstoque.ResetText()
            Me.txtEmPedido.ResetText()
            Me.txtSaldoQtd.ResetText()
            Exit Sub
        End If

        Dim dtProduto As DataTable = Nothing

        If EstoqueSomado = False Then
            dtProduto = CarregarDataTable("SELECT Produto.Codigo, (SELECT sum(Convert(Numeric(15,3), Qtde.Qtd)) FROM Qtde where " & _
            "Qtde.CodConfig = " & CodConfig & " and Produto.Codigo = Qtde.CodProd and Acabou = 'False') as Qtd, " & _
            "(SELECT Max(Total.Data) FROM Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem " & _
            "and Total.CodConfig = Pedido.CodConfig where Pedido.CodProd = Produto.Codigo and " & _
            "Pedido.CodConfig = " & CodConfig & ") as DataUltVenda FROM Produto left join Qtde on " & _
            "Produto.Codigo = Qtde.CodProd where Produto.Codigo = " & parCodigo & " group by Produto.Codigo")
        Else
            dtProduto = CarregarDataTable("SELECT Produto.Codigo, (SELECT case when sum(EntradaNf.QtdProd) is null then 0 " & _
            "else sum(EntradaNf.QtdProd) end FROM EntradaNf left join TotalEntradaNf on EntradaNf.CodTotNf = " & _
            "TotalEntradaNf.Codigo where EntradaNf.CodProd = Produto. Codigo and EstoqueOk = 'True' and " & _
            "EntradaNf.CodConfig = " & CodConfig & ") - (SELECT case when sum(Pedido.Qtd) is null then 0 else " & _
            "sum(Pedido.Qtd) end FROM Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and " & _
            "Pedido.CodConfig = Total.CodConfig where Pedido.CodConfig = " & CodConfig & " and Pedido.CodProd = " & _
            "Produto.Codigo and Pedido.Devolvido = 'False') + (SELECT case when sum(AjusteQtde.Qtd) is null then 0 " & _
            "else  sum(AjusteQtde.Qtd) end FROM AjusteQtde where AjusteQtde.CodConfig = " & CodConfig & " and " & _
            "AjusteQtde.CodProd = Produto.Codigo) as Qtd, (SELECT Max(Total.Data) FROM Total left join Pedido on " & _
            "Total.CodOrdem = Pedido.CodOrdem and Total.CodConfig = Pedido.CodConfig where Pedido.CodProd = Produto.Codigo " & _
            "and Pedido.CodConfig = " & CodConfig & ") as DataUltVenda FROM Produto left join Qtde on " & _
            "Produto.Codigo = Qtde.CodProd where Produto.Codigo = " & parCodigo & " group by Produto.Codigo")
        End If

        Dim dblEmEstoque As Double = 0
        If dtProduto.Rows.Count > 0 Then
            If dtProduto.Rows.Item(0).Item("Qtd").ToString <> "" Then
                dblEmEstoque = dtProduto.Rows.Item(0).Item("Qtd").ToString
            End If
        End If
        Me.txtEmEstoque.Text = dblEmEstoque.ToString("0.000")

        Dim dtCons As DataTable = CarregarDataTable("SELECT sum(Qtd) as Pendente FROM ItensConsig inner join TotalConsig on " & _
        "ItensConsig.CodOrdens = TotalConsig.CodOrdens and ItensConsig.CodConfig = TotalConsig.CodConfig where " & _
        "CodigoProduto = '" & parCodigo & "' and TotalConsig.Status = 'Pendente' and ItensConsig.CodConfig = " & CodConfig)

        Dim dblEmPedido As Double = 0
        If dtCons.Rows.Count > 0 Then
            If dtCons.Rows.Item(0).Item("Pendente").ToString <> "" Then
                dblEmPedido = dtCons.Rows.Item(0).Item("Pendente").ToString
            End If
        End If
        Me.txtEmPedido.Text = dblEmPedido.ToString("0.000")

        Dim dblSaldoQtd As Double = dblEmEstoque - dblEmPedido

        Me.txtSaldoQtd.Text = dblSaldoQtd.ToString("0.000")

    End Sub
    Private Sub RemoverProdutos()
        RetornaProduto = ""

        Dim frm As New frmConProduto
        frm.Tag = "PEDIDO"
        CodigoDoProduto = 0
        frm.ShowDialog()

        Dim dtProd As DataTable

        dtProd = CarregarDataTable("SELECT CodigoInterno, CodigoBarra, Nome, Valor, UnidadeMedida, ValorCusto, Desconto FROM Produto where Codigo = " & CodigoDoProduto)
        TamanhoProd()

        If dtProd.Rows.Count > 0 Then
            Me.txtCodPro2.Tag = CodigoDoProduto

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

    Private Sub txtValor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTro.KeyPress, txtRec.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "," And e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtValor_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValor.Leave
        Preco(txtValor)
        If Me.txtValor.Text = "" Then Exit Sub
        Me.txtValDesc.ResetText()
        If strDescontoCliente = "" Then
            If bolAdd = True Then
                If Me.txtPerDesc.Text <> "" Then
                    Dim dblDesc As Double = Me.txtPerDesc.Text
                    If dblDesc = 0 Then
                        dblUniSemDesc = Me.txtValor.Text
                    End If
                Else
                    dblUniSemDesc = Me.txtValor.Text
                End If

            Else
                dblUniSemDesc = Me.txtValor.Text
            End If

        Else
            If Me.txtPerDesc.Text <> strDescontoCliente Then
                dblUniSemDesc = Me.txtValor.Text
            End If
        End If
        If bolMensagemDesconto = False Then
            If DescontoMaximo <> "" Then
                Dim dblResult As Double

                dblResult = (dblUniSemDescOriginal / 100) * CDbl(DescontoMaximo)

                dblResult = dblUniSemDescOriginal - dblResult

                If dblUniSemDesc < dblResult Then
                    If Nivel = "USUÁRIO" Then
                        MsgBox("Desconto é maior do que o permitido, digite a senha de um usuário com nível de ADMINISTRADOR!", MsgBoxStyle.Information)
                        If SenhaEstaOK() = False Then
                            MsgBox("Desconto maior que o permitido!", MsgBoxStyle.Information)
                            Me.txtValor.Text = CampoValor(dblUniSemDescOriginal)
                            dblUniSemDesc = dblUniSemDescOriginal
                            bolMensagemDesconto = False
                        Else
                            If CNPJEmpresa = "96190897000132" Then
                                If Me.txtCodPed.Text = "" Then
                                    Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES (" & _
                                    "'" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Cód. Prod. " & Me.txtCodPro.Text & " Valor " & dblUniSemDescOriginal & "','Valor Novo " & dblUniSemDesc & "','VALOR','PEDIDO','CADASTRO'," & CodConfig & ")")

                                Else
                                    Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES (" & _
                                    "'" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Pedido " & Me.txtCodPed.Text & " Cód. Prod. " & Me.txtCodPro.Text & " Valor " & dblUniSemDescOriginal & "','Valor Novo " & dblUniSemDesc & "','VALOR','PEDIDO','ALTERAÇÃO'," & CodConfig & ")")
                                End If
                            End If
                            bolMensagemDesconto = True
                        End If
                    End If
                End If
            End If
        End If

        If bolGaxeta = True Then
            If CDbl(Me.txtValor.Text.Trim) < ValorMinimoGaxeta Then
                Me.txtValor.Text = CampoValor(ValorMinimoGaxeta)
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
            dblUniSemDescOriginal = 0
            Me.XtraTabControl1.SelectedTabPageIndex = 1
            strTipoProduto = .GetRowCellDisplayText(IndexGrid, Me.colTipo)
            If TipoNano = 5 Then
                If strTipoProduto = "SERVIÇO" Then
                    Me.rdgTipoProd.SelectedIndex = 1
                Else
                    Me.rdgTipoProd.SelectedIndex = 0
                End If
            End If
            Dim vetProduto As Array = Split(.GetRowCellDisplayText(IndexGrid, Me.colProduto), "|")

            Me.txtNomePro.Text = vetProduto(0)



            Me.txtCodPro.Tag = .GetRowCellDisplayText(IndexGrid, Me.colCodigoProduto)
            Me.txtCodPro.Text = .GetRowCellDisplayText(IndexGrid, Me.colCodigoPeca)
            Me.txtQtd.Text = .GetRowCellDisplayText(IndexGrid, Me.colQtd)
            Me.txtValor.Text = .GetRowCellDisplayText(IndexGrid, Me.colValorUnitario)
      
            If .GetRowCellDisplayText(IndexGrid, Me.colUniSemDesc).Trim = "" Or .GetRowCellDisplayText(IndexGrid, Me.colUniSemDesc).Trim = "0,00" Then
                dblUniSemDesc = .GetRowCellDisplayText(IndexGrid, Me.colValorUnitario)
            Else
                dblUniSemDesc = .GetRowCellDisplayText(IndexGrid, Me.colUniSemDesc)
            End If

            If Campanha(.GetRowCellDisplayText(IndexGrid, Me.colCodigoProduto)) = False Then
                'Gaxeta(.GetRowCellDisplayText(IndexGrid, Me.colCodigoProduto))
                Me.txtMedidaA.Text = .GetRowCellDisplayText(IndexGrid, Me.colMedidaA)
                Me.txtMedidaB.Text = .GetRowCellDisplayText(IndexGrid, Me.colMedidaB)
                Me.txtQtdMedida.Text = .GetRowCellDisplayText(IndexGrid, Me.colQtdMedida)
                If Me.txtValor.Text <> "" Then
                    If Me.txtQtd.Text.Trim <> "" Then
                        'If CDbl(Me.txtQtd.Text.Trim) = 1 Then
                        dblUniSemDescOriginal = Me.txtValor.Text
                        'End If
                        If Me.txtQtdMedida.Visible = True Then
                            If Me.txtQtdMedida.Text.Trim <> "" Then
                                dblUniSemDescOriginal = CDbl(Me.txtValor.Text.Trim) / CDbl(Me.txtQtdMedida.Text.Trim)
                            End If
                        End If
                    End If
                End If

            Else
                If Me.txtValor.Text <> "" Then
                    If Me.txtQtd.Text.Trim <> "" Then
                        'If CDbl(Me.txtQtd.Text.Trim) = 1 Then
                        dblUniSemDescOriginal = dblUniSemDesc
                        'End If
                    End If
            End If
            End If



            Me.txtTamanho.Text = .GetRowCellDisplayText(IndexGrid, Me.colTamanho)
            dblValorDeCusto = .GetRowCellDisplayText(IndexGrid, colCusto) / .GetRowCellDisplayText(IndexGrid, Me.colQtd)
            Me.txtCusto.Text = .GetRowCellDisplayText(IndexGrid, colCusto) / .GetRowCellDisplayText(IndexGrid, Me.colQtd)
            Me.txtQtd.ToolTipTitle = .GetRowCellDisplayText(IndexGrid, Me.colUM)

            Me.cboCodFunc.Text = .GetRowCellDisplayText(IndexGrid, Me.colCodigoFuncionario)
            Me.cboCodFunc.ClosePopup()
            bolPromocao = .GetRowCellValue(IndexGrid, Me.colPromocao)

            'VERIFICA SE O PRODUTO USAR QTD POR EMBALAGEM
            QtdEmb(Me.txtCodPro.Tag)

            bolAutorizado = .GetRowCellValue(IndexGrid, Me.colAutorizado)
            strLocacao = .GetRowCellDisplayText(IndexGrid, Me.colLocacao)
            Me.NanoCampo2.Text = .GetRowCellDisplayText(IndexGrid, Me.colCampoPedido)
            Dim dtProd As DataTable = CarregarDataTable("SELECT Desconto FROM Produto where Codigo = " & Me.txtCodPro.Tag)
            Dim bolPromo As Boolean = False
            If dtProd.Rows.Count > 0 Then
                If dtProd.Rows.Item(0).Item("Desconto").ToString <> "" And dtProd.Rows.Item(0).Item("Desconto").ToString <> "0" And dtProd.Rows.Item(0).Item("Desconto").ToString <> "0,000" And dtProd.Rows.Item(0).Item("Desconto").ToString <> "0,00" Then
                    bolPromo = True
                    Dim dblPerDesc As Double = dtProd.Rows.Item(0).Item("Desconto").ToString
                    strDescontoPromocao = dblPerDesc.ToString("0.00")
                Else
                    strDescontoPromocao = ""
                End If
            End If

            If Nivel <> "USUÁRIO" Then
                If Me.chkCusto.Checked = True Then
                    Me.txtCusto.Text = dblValorDeCusto.ToString("0.00")
                End If
            End If

            Me.lueTabelaPreco.EditValue = DBNull.Value
            CarregarDadosLue("Select 'PADRÃO' as Tabela, Valor FROM Produto where Codigo = " & Me.txtCodPro.Tag & " UNION ALL SELECT Grupo.Nome as Tabela, TabelaPreco.Valor From " & _
            "TabelaPreco left join Grupo on TabelaPreco.CodTabela = Grupo.Codigo Where CodProd = " & Me.txtCodPro.Tag, Me.lueTabelaPreco)
            Me.lueTabelaPreco.ClosePopup()

            If bolPromo = True Then
                If BloquearDescontoPorItem = True Then
                    Me.txtPerDesc.Enabled = False
                    Me.txtValDesconto.Enabled = False
                    Me.txtValor.Enabled = False
                End If
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
                Me.txtValDesconto.Enabled = True
                If AlteraPrecoPedido = True Then
                    Me.txtValor.Enabled = True
                End If
                Me.txtPerDesc.ResetText()
                Me.txtPerDesc.Text = .GetRowCellDisplayText(IndexGrid, Me.colDesconto)
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
    Private Function Campanha(ByVal parCodProd As Integer) As Boolean

        Dim dt As DataTable
        dt = CarregarDataTable("Select ValorAnt from Campanha Where CodProd = " & parCodProd & " and Status = 'Lancado'")
        Me.txtMedidaB.ResetText()
        Me.txtQtdMedida.ResetText()
        Dim bolCampanha As Boolean = False
        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item("ValorAnt").ToString <> "" Then
                Dim dblValorAnt As Double = dt.Rows.Item(0).Item("ValorAnt").ToString
                If Me.txtValor.Text <> "" Then
                    Dim dblVal As Double = Me.txtValor.Text
                    If dblValorAnt >= dblVal Then
                        Dim dblPorcAnt As Double = ((dblValorAnt - dblVal) * 100) / dblValorAnt

                        Me.txtMedidaB.Text = dblValorAnt.ToString("0.00")
                        Me.txtQtdMedida.Text = dblPorcAnt.ToString("0.00")
                        bolCampanha = True

                    End If

                End If

            End If
        End If
        If bolCampanha = True Then
            Me.lblMedB.Text = "P. Ant. R$"
            Me.lblMedTot.Text = "P.A.Desc.%"
            Me.lblMedB.Location = New System.Drawing.Point(198, 40)
            Me.lblMedTot.Location = New System.Drawing.Point(350, 40)
        Else
            Me.lblMedB.Text = "Medida B"
            Me.lblMedTot.Text = "Qtd Medida"
            Me.lblMedB.Location = New System.Drawing.Point(203, 40)
            Me.lblMedTot.Location = New System.Drawing.Point(358, 40)
        End If
        'Me.txtMedidaB.Properties.ReadOnly = bolCampanha
        'Me.txtQtdMedida.Properties.ReadOnly = bolCampanha
        'Me.txtMedidaB.Visible = bolCampanha
        'Me.txtQtdMedida.Visible = bolCampanha
        'Me.lblMedB.Visible = bolCampanha
        'Me.lblMedTot.Visible = bolCampanha

        Me.txtMedidaB.Properties.ReadOnly = bolCampanha
        Me.txtQtdMedida.Properties.ReadOnly = bolCampanha
        Me.txtMedidaB.Visible = False
        Me.txtQtdMedida.Visible = False
        Me.lblMedB.Visible = False
        Me.lblMedTot.Visible = False
        Return bolCampanha
    End Function
    Private Sub Gaxeta(ByVal parCodProd As Integer)

        bolGaxeta = False
        Me.txtMedidaA.ResetText()
        Me.txtMedidaB.ResetText()
        Me.txtQtdMedida.ResetText()

        Dim dt As DataTable
        dt = CarregarDataTable("Select Grupo from Produto Where Codigo = " & parCodProd)

        If dt.Rows.Count > 0 Then
            If dt.Rows(0).Item("Grupo").ToString = "GAXETA" Then
                Me.txtMedidaB.Properties.ReadOnly = False
                Me.txtQtdMedida.Properties.ReadOnly = False
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

    Private Sub ValorTabela(ByVal parCodProd As Integer)
        Dim dbValor As Double
        Dim dt As DataTable = CarregarDataTable("Select Codigo From Grupo Where Nome='" & Me.cboTabela.Text.Trim & "'")
        Dim Codigo As Integer = dt.Rows.Item(0).Item("Codigo").ToString

        Dim dtTabela As DataTable = CarregarDataTable("Select Valor From TabelaPreco Where CodTabela=" & Codigo & " And CodProd=" & parCodProd & "")
        If dtTabela.Rows.Count > 0 Then
            If dtTabela.Rows.Item(0).Item("Valor").ToString <> "" Then
                dbValor = dtTabela.Rows.Item(0).Item("Valor").ToString()
            Else
                dbValor = 0
            End If
        Else
            dbValor = 0
        End If
        Me.txtValor.Text = CampoValor(dbValor)

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
        Me.txtValor.Enabled = AlteraPrecoPedido
        Dim dt As DataTable
        Dim strTipoProd As String = ""
        If TipoNano = 5 Then
            Select Case Me.rdgTipoProd.SelectedIndex
                Case 0
                    strTipoProd = " and Tipo <> 'SERVIÇO' "
                Case 1
                    strTipoProd = " and Tipo = 'SERVIÇO' "
            End Select
        End If
        If NomeEmpresa.Replace("Ã", "A").Trim.Contains("CAVALAO") = True Then
            dt = CarregarDataTable("Select Codigo, Nome, Valor, UnidadeMedida, ValorCusto, Desconto, Grupo, Inativo, Tipo, AlterarPreco from Produto Where CodigoBarra ='" & Me.txtCodPro.Text.Trim & "'")

        Else
            dt = CarregarDataTable("Select Codigo, Nome, Valor, UnidadeMedida, ValorCusto, Desconto, Grupo, Inativo, Tipo, AlterarPreco from Produto Where CodigoInterno ='" & Me.txtCodPro.Text.Trim & "'  " & strTipoProd & " or CodigoBarra ='" & Me.txtCodPro.Text.Trim & "' " & strTipoProd)

        End If
        If dt.Rows.Count = 0 Then
            Dim dtCodBarra As DataTable = CarregarDataTable("SELECT CodProd FROM CodigoBarra where CodigoBarra = '" & Me.txtCodPro.Text & "' and Produto = '' or CodigoBarra = '" & Me.txtCodPro.Text & "' and Produto is null")
            If dtCodBarra.Rows.Count > 0 Then
                CodigoDoProduto = dtCodBarra.Rows.Item(0).Item("CodProd").ToString
                dt = CarregarDataTable("Select Codigo, Nome, Valor, UnidadeMedida, ValorCusto, Desconto, Grupo, Inativo, Tipo, AlterarPreco from Produto where Codigo=" & CodigoDoProduto & strTipoProd)
            End If
        End If

        If dt.Rows.Count > 0 Then
            Dim bolInativo As Boolean = dt.Rows.Item(0).Item("Inativo")
            If AlteraPrecoPedido = False Then
                Dim bolAlterarPreco As Boolean = dt.Rows.Item(0).Item("AlterarPreco")
                If bolAlterarPreco = True Then
                    Me.txtValor.Enabled = True
                End If

            End If
            If bolInativo = True Then
                MsgBox("Produto inativo!", MsgBoxStyle.Information)
                bolPromocao = False
                Me.txtPerDesc.Enabled = True
                Me.txtValDesconto.Enabled = True
                If AlteraPrecoPedido = True Then
                    Me.txtValor.Enabled = True
                End If
                Me.txtTamanho.ResetText()
                Me.txtCodPro.ResetText()
                Me.txtCodPro.Focus()
                Me.txtCodPro.Tag = ""
                Me.txtNomePro.ResetText()
                Me.txtValor.ResetText()
                Me.txtQtd.ToolTipTitle = "UNIDADE"
                dblValorDeCusto = 0
                bolDigQtd = False
                Exit Sub
            End If
            CodigoDoProduto = dt.Rows(0).Item("Codigo").ToString
            If bolTamanhoNoCodigo = False Then
                TamanhoProd()
            End If



            Me.txtCodPro.Tag = CodigoDoProduto
            Me.txtNomePro.Text = dt.Rows(0).ItemArray(1).ToString
            Me.txtValor.Text = CampoValor(dt.Rows(0).Item(2))
            If Campanha(CodigoDoProduto) = False Then
                Gaxeta(CodigoDoProduto)
            End If
            If Me.cboTabela.Text <> "PADRÃO" Then
                ValorTabela(CodigoDoProduto)
                dblUniSemDesc = CampoValor(txtValor.Text)
            Else
                dblUniSemDesc = CampoValor(dt.Rows.Item(0).Item("Valor"))
            End If


            dblUniSemDescOriginal = dblUniSemDesc
            strTipoProduto = dt.Rows.Item(0).Item("Tipo").ToString
            strLocacao = ""
            Dim dtLoc As DataTable = CarregarDataTable("SELECT Locacao FROM Locacao where CodProd = " & CodigoDoProduto & " and CodConfig = " & CodConfig)
            If dtLoc.Rows.Count > 0 Then
                strLocacao = dtLoc.Rows.Item(0).Item("Locacao").ToString
            End If
            If dt.Rows.Item(0).Item("Desconto").ToString <> "" And dt.Rows.Item(0).Item("Desconto").ToString <> "0" And dt.Rows.Item(0).Item("Desconto").ToString <> "0,000" And dt.Rows.Item(0).Item("Desconto").ToString <> "0,00" Then
                Dim dblPerDesc As Double = dt.Rows.Item(0).Item("Desconto").ToString
                Dim dblUni As Double = Me.txtValor.Text
                Dim dblResto As Double = (dblUni / 100) * dblPerDesc

                dblUni = dblUni - dblResto
                Me.txtValor.Text = CampoValor(dblUni)
                bolPromocao = True
                If BloquearDescontoPorItem = True Then
                    Me.txtValDesconto.Enabled = False
                    Me.txtPerDesc.Enabled = False
                    Me.txtValor.Enabled = False
                End If
                Me.txtPerDesc.Text = dblPerDesc.ToString("0.00")
                strDescontoPromocao = dblPerDesc.ToString("0.00")
            Else
                strDescontoPromocao = ""
                bolPromocao = False
                If strDescontoCliente = "" Then
                    Me.txtPerDesc.ResetText()
                End If
                Me.txtValDesconto.Enabled = True
                Me.txtPerDesc.Enabled = True
                If AlteraPrecoPedido = True Then
                    Me.txtValor.Enabled = True
                End If


            End If
            Me.txtQtd.ToolTipTitle = dt.Rows(0).ItemArray(3).ToString
            dblValorDeCusto = dt.Rows(0).ItemArray(4).ToString
            bolAbriuProduto = True
            If Me.txtQtd.Text = "" Then
                Me.txtQtd.Text = "1"
            End If

            'VERIFICA SE O PRODUTO USAR QTD POR EMBALAGEM
            QtdEmb(CodigoDoProduto)

            Try
                Dim dblValD As Double = dblUniSemDescOriginal - Me.txtValor.Text
                Me.txtValDesconto.Text = dblValD.ToString("0.000")
            Catch ex As Exception
            End Try

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
                            Me.txtValDesconto.Enabled = True
                            Me.txtPerDesc.Enabled = True
                        End If
                    End If

                End If
            End If

            If Nivel <> "USUÁRIO" Then
                If Me.chkCusto.Checked = True Then
                    Me.txtCusto.Text = dblValorDeCusto.ToString("0.00")
                End If
            End If

            Me.lueTabelaPreco.EditValue = DBNull.Value
            CarregarDadosLue("Select 'PADRÃO' as Tabela, Valor FROM Produto where Codigo = " & CodigoDoProduto & " UNION ALL SELECT Grupo.Nome as Tabela, TabelaPreco.Valor From " & _
            "TabelaPreco left join Grupo on TabelaPreco.CodTabela = Grupo.Codigo Where CodProd = " & CodigoDoProduto, Me.lueTabelaPreco)
            Me.lueTabelaPreco.ClosePopup()

            HistoricoQtd(CodigoDoProduto)
            bolMensagemDesconto = False
            Me.txtQtd.Focus()

        Else
            bolPromocao = False
            Me.txtValDesconto.Enabled = True
            Me.txtPerDesc.Enabled = True
            If AlteraPrecoPedido = True Then
                Me.txtValor.Enabled = True
            End If
            Me.txtTamanho.ResetText()
            Me.txtCodPro.ResetText()
            Me.txtCodPro.Focus()
            Me.txtCodPro.Tag = ""
            Me.txtNomePro.ResetText()
            Me.txtValor.ResetText()
            Me.txtQtd.ToolTipTitle = "UNIDADE"
            dblValorDeCusto = 0
            bolDigQtd = False
            QtdEmb(CodigoDoProduto)
            Exit Sub
        End If

        If Me.chkAutoAdd.Checked = True Then
            Me.txtQtd.Focus()
            Me.txtDesc.Focus()
            Adicinar()
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
        AbreCliente("PESQUISA")

    End Sub

    Private Sub AbreCliente(ByVal parTag As String)
        Me.XtraTabControl3.SelectedTabPageIndex = 0
        PlacaDoCarro = ""
        Dim frm As New frmCadCliente
        frm.Tag = parTag
        frm.ShowDialog()
        frm.Tag = ""

        If CodigoDoCliente <> Nothing Then
            Me.txtCli.Text = NomeDoCliente
            If PlacaDoCarro <> "" Then
                CarregarCarro(PlacaDoCarro, True)
            Else
                CarregarCliente(CodigoDoCliente, True)
            End If

            HistoricoCliente(CodigoDoCliente)
        End If

    End Sub

    Private Sub CarregarCliente(ByVal parCodCli As String, ByVal parRecalcularDesc As Boolean)
        If parCodCli.Trim = Nothing Then Exit Sub
        Dim dt As DataTable = CarregarDataTable("Select Nome, Telefone, Fax, Email, Observacao, Desconto, CPF, Limite, Credito, convert(varchar(10),Data,103) as Data, CodFunc From Cliente Where Codigo =" & parCodCli)
        intVencDias = 0
        If dt.Rows.Count > 0 Then
            intCodCli = parCodCli
            NomeDoCliente = dt.Rows.Item(0).ItemArray(0).ToString
            Me.txtCli.Text = dt.Rows.Item(0).ItemArray(0).ToString
            Me.txtTel.Text = dt.Rows.Item(0).ItemArray(1).ToString
            Me.txtFax.Text = dt.Rows.Item(0).ItemArray(2).ToString
            Me.txtEmail.Text = dt.Rows.Item(0).ItemArray(3).ToString

            Me.txtLimiteCliente.Text = dt.Rows.Item(0).Item("Limite").ToString
            Me.txtCredito.Text = dt.Rows.Item(0).Item("Credito").ToString
            Me.txtdtCad.Text = dt.Rows.Item(0).Item("Data").ToString
            If dt.Rows.Item(0).Item("CPF").ToString <> "000.000.000-00" Then
                Me.txtCPFCNPJ.Text = dt.Rows.Item(0).Item("CPF").ToString
            Else
                Me.txtCPFCNPJ.Text = ""
            End If

            If NomeEmpresa.ToUpper.Contains("DANNY") = True Or NomeEmpresa.ToUpper.Contains("CONGELADOS") = True Then
                Me.txtDesc.Text = dt.Rows.Item(0).Item("Observacao").ToString
            End If

            If ObsClientePedido = True Then
                Me.txtDesc.Text = dt.Rows.Item(0).Item("Observacao").ToString
            End If

            Me.txtPerDesc.Text = dt.Rows.Item(0).Item("Desconto").ToString
            If Me.txtPerDesc.Text <> "" And Me.txtPerDesc.Text <> "0,00" Then
                strDescontoCliente = Me.txtPerDesc.Text
            Else
                strDescontoCliente = ""
            End If
            If parRecalcularDesc = True Then
                RecalcularDesconto()
            End If

            Dim strCodFuncCli As String = dt.Rows.Item(0).Item("CodFunc").ToString

            If strCodFuncCli <> "" And strCodFuncCli <> "0" Then
                Dim dtFunc As DataTable = CarregarDataTable("SELECT Nome FROM Funcionario where Codigo = " & strCodFuncCli)
                If dtFunc.Rows.Count > 0 Then
                    Me.lueFunc.Text = dtFunc.Rows.Item(0).Item("Nome").ToString
                    Me.lueFunc.ClosePopup()
                End If
            End If

            CarregarDadosLue("Select Placa, Modelo, Cor, Ano, Cliente.Nome as NomeCliente from Carro left join Cliente on Carro.CodCli = Cliente.Codigo where CodCli = " & parCodCli, Me.luePlaca)

        End If
        Me.txtCodPro.Focus()
    End Sub

    Private Sub txtCodPed_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodPed.Enter
        strEstaComFocus = "txtCodPed"
    End Sub

    Private Sub cboTab_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtCodPro.Tag = ""
        Me.txtCodPro.ResetText()
        Me.txtNomePro.ResetText()
        Me.txtQtd.ResetText()
        Me.txtValor.ResetText()
    End Sub

    Private Function CarregarQtd(ByVal parCodProd As Integer) As String
        Dim str As String = "0,000"

        Try
            Dim dtQtd As DataTable = CarregarDataTable("Select (SELECT case when sum(EntradaNf.QtdProd) is null then 0 " & _
            "else sum(EntradaNf.QtdProd) end FROM EntradaNf left join TotalEntradaNf on EntradaNf.CodTotNf = " & _
            "TotalEntradaNf.Codigo where EntradaNf.CodProd = Produto. Codigo and EstoqueOk = 'True' and " & _
            "EntradaNf.CodConfig = " & CodConfig & ") - (SELECT case when sum(Pedido.Qtd) is null then 0 else " & _
            "sum(Pedido.Qtd) end FROM Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and " & _
            "Pedido.CodConfig = Total.CodConfig where Pedido.CodConfig = " & CodConfig & " and Pedido.CodProd = " & _
            "Produto.Codigo and Pedido.Devolvido = 'False') + (SELECT case when sum(AjusteQtde.Qtd) is null then 0 " & _
            "else  sum(AjusteQtde.Qtd) end FROM AjusteQtde where AjusteQtde.CodConfig = " & CodConfig & " and " & _
            "AjusteQtde.CodProd = Produto.Codigo) as Qtd From Produto Where Codigo = " & parCodProd & " Order by Codigo")


            If dtQtd.Rows.Count > 0 Then
                str = dtQtd.Rows.Item(0).Item("Qtd").ToString
            End If
        Catch ex As Exception
            str = "0,000"
        End Try

        Return str
    End Function

    Private Sub Visualizar(ByVal parValores As Boolean, ByVal parEnviarEmail As Boolean)
        If Me.txtCodPed.Text = "" Then Exit Sub
        Dim rel As New relPed

        rel.lblTitulo.Text = NomeEmpresa
        rel.lblEndereco.Text = EnderecoEmpresa
        rel.lblFones.Text = TelefoneEmpresa

        rel.picLogo.Image = LogoTipo

        rel.colCodigo.Width = 70
        rel.colCodigo1.Width = 70

        Dim I, intQtde, intQtdTotal As Integer
        Dim IndexProd, IndexServ As Integer
        Dim bolServico As Boolean = False
        Dim dblTotal, dblTotalGeral As Double
        Dim strTipo As String = Nothing

        For I = 0 To Me.grd1.RowCount - 1
            intQtde = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
            intQtdTotal += intQtde
            dblTotal = Me.grd1.GetRowCellDisplayText(I, Me.colValorTotal)
            dblTotalGeral += dblTotal

            strTipo = Me.grd1.GetRowCellDisplayText(I, Me.colTipo).ToString
            If strTipo = "SERVIÇO" Then
                With rel.tbServico.Rows
                    .Add()
                    .Item(IndexServ).Item("Produto") = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                    .Item(IndexServ).Item("Qtd") = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                    .Item(IndexServ).Item("ValorUnitario") = Me.grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                    .Item(IndexServ).Item("ValorTotal") = Me.grd1.GetRowCellDisplayText(I, Me.colValorTotal)

                    If TipoNano = 2 Then

                        Dim dtLoc As DataTable = CarregarDataTable("SELECT Locacao2 FROM Produto where Codigo = " & Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto))
                        If dtLoc.Rows.Count > 0 Then
                            .Item(IndexServ).Item("Tamanho") = dtLoc.Rows.Item(0).Item("Locacao2").ToString
                        End If

                    Else
                        Dim dtLoc As DataTable = CarregarDataTable("SELECT Locacao FROM Produto where Codigo = " & Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto))
                        If dtLoc.Rows.Count > 0 Then
                            If dtLoc.Rows.Item(0).Item("Locacao").ToString <> "" Then
                                .Item(IndexProd).Item("Locacao") = dtLoc.Rows.Item(0).Item("Locacao").ToString
                            End If
                        End If
                        .Item(IndexServ).Item("Tamanho") = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho)
                    End If



                    .Item(IndexServ).Item("Codigo") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoPeca)
                    .Item(IndexServ).Item("UniSemDesc") = Me.grd1.GetRowCellDisplayText(I, Me.colUniSemDesc)
                    .Item(IndexServ).Item("UM") = Me.grd1.GetRowCellDisplayText(I, Me.colUM)
                    bolServico = True
                    IndexServ = IndexServ + 1
                End With
            Else
                With rel.tbConsig.Rows
                    .Add()
                    .Item(IndexProd).Item("Produto") = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                    .Item(IndexProd).Item("Qtd") = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                    .Item(IndexProd).Item("Estoque") = CarregarQtd(Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto))
                    .Item(IndexProd).Item("ValorUnitario") = Me.grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                    .Item(IndexProd).Item("ValorTotal") = Me.grd1.GetRowCellDisplayText(I, Me.colValorTotal)

                    If TipoNano = 2 Then

                        Dim dtLoc As DataTable = CarregarDataTable("SELECT Locacao2 FROM Produto where Codigo = " & Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto))
                        If dtLoc.Rows.Count > 0 Then
                            .Item(IndexProd).Item("Tamanho") = dtLoc.Rows.Item(0).Item("Locacao2").ToString
                        End If

                    Else
                        Dim dtLoc As DataTable = CarregarDataTable("SELECT Locacao FROM Produto where Codigo = " & Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto))
                        If dtLoc.Rows.Count > 0 Then
                            If dtLoc.Rows.Item(0).Item("Locacao").ToString <> "" Then
                                .Item(IndexProd).Item("Locacao") = dtLoc.Rows.Item(0).Item("Locacao").ToString
                            End If
                        End If
                        .Item(IndexProd).Item("Tamanho") = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho)
                    End If

                    If NomeEmpresa.ToUpper.Contains("RILOM") = True Then
                        Dim CodigoBarra As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoPeca)
                        Dim dt As DataTable = CarregarDataTable("Select CodigoInterno From Produto Where CodigoBarra ='" & CodigoBarra & "'")

                        If dt.Rows.Count > 0 Then
                            .Item(IndexProd).Item("Codigo") = dt.Rows.Item(0).Item("CodigoInterno").ToString
                        Else
                            .Item(IndexProd).Item("Codigo") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoPeca)
                        End If
                    Else
                        .Item(IndexProd).Item("Codigo") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoPeca)
                    End If

                    .Item(IndexProd).Item("UniSemDesc") = Me.grd1.GetRowCellDisplayText(I, Me.colUniSemDesc)
                    .Item(IndexProd).Item("UM") = Me.grd1.GetRowCellDisplayText(I, Me.colUM)
                    IndexProd = IndexProd + 1
                End With
            End If
        Next
        If TipoNano = 2 Then
            rel.colTamanho.Caption = "Loc."
            rel.colTamanho.Width = 80
            rel.colLocacao.Visible = False
        Else
            If parValores = False Then
                rel.colLocacao.Visible = True
                rel.colLocacao.VisibleIndex = 8
                rel.colLocacao1.Visible = True
                rel.colLocacao1.VisibleIndex = 8
            End If
        End If

        If parValores = False Then
            If TipoNano = 2 Then
                rel.colProduto.Width = 340
                rel.colProduto1.Width = 340

                rel.colEstoque.Visible = True
                rel.colEstoque.Width = 60
                rel.colEstoque.VisibleIndex = 6
            Else
                rel.colProduto.Width = 300
                rel.colProduto1.Width = 300

                rel.colEstoque.Visible = True
                rel.colEstoque.Width = 60
                rel.colEstoque.VisibleIndex = 5
            End If
        End If

        If Me.rdgDesc.SelectedIndex = 1 Then
            rel.colUniSemDesc.Caption = "Sem Acres. R$"
            rel.XrTableCell7.Text = "Acréscimo R$"
        End If

        If CNPJEmpresa = "20252057000195" Then
            rel.XrTableRow4.Visible = False
        End If
        If DescontoImpressao = False Then
            rel.XrTableRow4.Visible = False
        End If

        rel.lblNome.Text = Me.txtCli.Text
        rel.lblTel1.Text = Me.txtTel.Text
        rel.lblTel2.Text = Me.txtFax.Text
        rel.lblWeb.Text = Me.txtEmail.Text.ToLower
        rel.lblStatus.Text = Me.cboGrp.Text


        Dim dtCli As DataTable = CarregarDataTable("SELECT CPF, RGIE, Endereco, Bairro, Numero, Cidade, Cep, " & _
        "convert(Varchar(10),Nascimento,103) as Nascimento, Complemento, Contato, Estado, EnderecoEntrega, " & _
        "NumeroEntrega, ComplementoEntrega, BairroEntrega, CepEntrega, CidadeEntrega, EstadoEntrega " & _
        "FROM Cliente where Codigo = " & intCodCli)

        If dtCli.Rows.Count > 0 Then
            If dtCli.Rows.Item(0).Item("EnderecoEntrega").ToString <> "" Then
                rel.XrRichText1.Text = "Endereço de Entrega:" & vbCrLf & dtCli.Rows.Item(0).Item("EnderecoEntrega").ToString & ", " & dtCli.Rows.Item(0).Item("NumeroEntrega").ToString & " - " & dtCli.Rows.Item(0).Item("BairroEntrega").ToString & " - " & dtCli.Rows.Item(0).Item("CidadeEntrega").ToString & ", " & dtCli.Rows.Item(0).Item("EstadoEntrega").ToString & " - CEP: " & dtCli.Rows.Item(0).Item("CepEntrega").ToString & " - " & dtCli.Rows.Item(0).Item("ComplementoEntrega").ToString
            Else
                rel.XrRichText1.Visible = False
            End If
        End If


        If Me.cboStatus.Text = "Orçamento" Then
            rel.lblNomePed.Text = "Orçamento N°:"
        End If

        rel.colUM.Visible = Me.colUM.Visible
        rel.colUM1.Visible = Me.colUM.Visible
        If parValores = True Then
            rel.colUniSemDesc.Visible = Me.colUniSemDesc.Visible
            rel.colUniSemDesc1.Visible = Me.colUniSemDesc.Visible
        End If

        rel.colTamanho.Visible = Me.colTamanho.Visible
        rel.colTamanho1.Visible = Me.colTamanho.Visible

        rel.lblPed.Text = Me.txtCodPed.Text
        rel.lblData.Text = Me.dtData.Text

        rel.tblQtd.Text = intQtdTotal
        rel.tblTotal.Text = Me.txtTotal.Text

        If bolServico = True Then
            rel.DetailReport.Visible = True
            rel.XrTableCell8.Visible = True
            rel.XrTableCell11.Visible = True
            rel.tblTotalprod.Visible = True
            rel.tblTotalserv.Visible = True
            rel.tblTotalprod.Text = Me.txtTotalprod.Text()
            rel.tblTotalserv.Text = Me.txtTotalServ.Text()
        End If

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

            rel.colValorUnitario1.Visible = False
            rel.colValorTotal1.Visible = False
            rel.colUniSemDesc1.Visible = False

            rel.XrLabel1.Visible = False
            rel.XrLine7.Visible = False
            rel.txtTexto.Visible = False



            rel.XrLine8.Visible = False
            rel.txtTexto2.Visible = False
            rel.XrLabel7.Visible = False
            rel.XrLabel6.Visible = False

        End If
        'OcultarAutorizacao
        If AutorizacaoPedido = False Then
            rel.lblAutorizacao.Visible = False
        Else
            rel.lblAutorizacao.Text = Me.txtCli.Text
        End If


        If Me.cboStatus.Text = "Faturado" Then
            Dim dtVenda As DataTable = CarregarDataTable("SELECT CodOrdem FROM Total where CodPedido = " & Me.txtCodPed.Text & " and CodConfig = " & CodConfig)
            Dim dblValor As Double = 0
            Dim dblTroco As Double = 0
            If dtVenda.Rows.Count > 0 Then
                Dim strCodOrdemVenda As String = dtVenda.Rows.Item(0).Item("CodOrdem").ToString
                If strCodOrdemVenda <> "" Then
                    rel.lblNVenda.Visible = True
                    rel.lblNumVenda.Visible = True
                    rel.lblNumVenda.Text = strCodOrdemVenda
                End If
                Dim bolTroco As Boolean = False
                Dim P As Integer
                Dim dtPag As DataTable = CarregarDataTable("SELECT Pagamento, Valor FROM Recebimento where CodOrdem = " & strCodOrdemVenda & " and CodConfig = " & CodConfig)
                If dtPag.Rows.Count > 0 Then

                    For P = 0 To dtPag.Rows.Count - 1
                        Dim strPag As String = dtPag.Rows.Item(P).Item("Pagamento").ToString
                        If dtPag.Rows.Item(P).Item("Valor").ToString <> "" Then
                            dblValor = dtPag.Rows.Item(P).Item("Valor").ToString
                        End If
                        If strPag = "DINHEIRO" Then
                            If bolTroco = False Then
                                If dblTroco > 0 Then
                                    dblValor = dblValor + dblTroco
                                    bolTroco = True
                                End If
                            End If
                        End If

                        rel.txtTexto.Text &= " " & Dir(strPag, 19) & " R$ " & Esq(dblValor.ToString("0.00"), 9) & vbCrLf
                    Next
                    If dblTroco > 0 Then
                        rel.txtTexto.Text &= " TROCO              " & "R$ " & Esq(dblTroco.ToString("0.00"), 9) & vbCrLf
                    End If

                    If parValores = True Then
                        rel.XrLabel1.Visible = True
                        rel.XrLine7.Visible = True
                        rel.txtTexto.Visible = True
                    End If


                    Dim dtConta As DataTable = CarregarDataTable("Select Parcelas, ValorParcela, Vencimento, RecebidoOK from ContaReceber where CodOrdem =" & strCodOrdemVenda & " and CodConfig =" & CodConfig)
                    If dtConta.Rows.Count > 0 Then
                        Dim J As Integer
                        Dim strVenc, strOK, strPar As String
                        Dim dblValPar As Double

                        For J = 0 To dtConta.Rows.Count - 1
                            strPar = dtConta.Rows.Item(J).Item("Parcelas").ToString
                            dblValPar = dtConta.Rows.Item(J).Item("ValorParcela").ToString
                            strVenc = Format(dtConta.Rows.Item(J).Item("Vencimento"), "dd/MM/yyyy")
                            strOK = "Sim"

                            If dtConta.Rows.Item(J).Item("RecebidoOK") = False Then
                                strOK = "Não"
                            End If

                            rel.txtTexto2.Text &= Cent(strPar, 5) & Esq(dblValPar.ToString("0.00"), 16) & Esq(strVenc, 14) & Esq(strOK, 10) & vbCrLf

                        Next
                        If parValores = True Then
                            rel.XrLabel6.Visible = True
                            rel.XrLabel7.Visible = True
                            rel.XrLine8.Visible = True
                            rel.txtTexto2.Visible = True
                        End If

                    End If

                End If



            End If

        Else

            If parValores = True Then
                Dim dtEntrada As DataTable = CarregarDataTable("Select Pagamento, Valor From Recebimento Where CodigoPedido = " & Me.txtCodPed.Text & " And CodConfig=" & CodConfig)

                If dtEntrada.Rows.Count > 0 Then
                    rel.XrLabel1.Visible = True
                    rel.XrLine7.Visible = True
                    rel.txtTexto.Visible = True

                    Dim J As Integer
                    rel.txtTexto.Text &= "ENTRADA" & vbCrLf
                    Dim strPag As String
                    Dim strValor As String
                    Dim dblValor As Double
                    For J = 0 To dtEntrada.Rows.Count - 1
                        strPag = dtEntrada.Rows.Item(J).Item("Pagamento").ToString
                        dblValor = dtEntrada.Rows.Item(J).Item("Valor").ToString
                        strValor = dblValor.ToString("####,##0.00")

                        rel.txtTexto.Text &= strPag & "   R$ " & strValor & vbCrLf
                    Next

                End If
            End If
        End If

        If parEnviarEmail = False Then
            rel.ShowPreview()
        Else
            rel.ExportToPdf("C:\NANO\Pedidos\Pedido Nº " & Me.txtCodPed.Text.Trim & ".pdf")
        End If

    End Sub

    Private Sub VisualizarCompleto(ByVal parValores As Boolean, ByVal parEnviarEmail As Boolean)
        If Me.txtCodPed.Text = "" Then Exit Sub
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

        rel.colCodigo.Width = 70
        rel.colCodigo1.Width = 70


        Dim I, intQtde, intQtdTotal As Integer
        Dim IndexProd, IndexServ As Integer
        Dim bolServico As Boolean = False
        Dim dblTotal, dblTotalGeral As Double
        Dim strTipo As String = Nothing

        For I = 0 To Me.grd1.RowCount - 1
            intQtde = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
            intQtdTotal += intQtde
            dblTotal = Me.grd1.GetRowCellDisplayText(I, Me.colValorTotal)
            dblTotalGeral += dblTotal

            strTipo = Me.grd1.GetRowCellDisplayText(I, Me.colTipo).ToString
            If strTipo = "SERVIÇO" Then
                With rel.tbServico.Rows
                    .Add()
                    .Item(IndexServ).Item("Produto") = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                    .Item(IndexServ).Item("Qtd") = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                    .Item(IndexServ).Item("ValorUnitario") = Me.grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                    .Item(IndexServ).Item("ValorTotal") = Me.grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                    If TipoNano = 2 Then

                        Dim dtLoc As DataTable = CarregarDataTable("SELECT Locacao2 FROM Produto where Codigo = " & Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto))
                        If dtLoc.Rows.Count > 0 Then
                            .Item(IndexServ).Item("Tamanho") = dtLoc.Rows.Item(0).Item("Locacao2").ToString
                        End If

                    Else
                        Dim dtLoc As DataTable = CarregarDataTable("SELECT Locacao FROM Produto where Codigo = " & Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto))
                        If dtLoc.Rows.Count > 0 Then
                            If dtLoc.Rows.Item(0).Item("Locacao").ToString <> "" Then
                                .Item(IndexProd).Item("Locacao") = dtLoc.Rows.Item(0).Item("Locacao").ToString
                            End If
                        End If

                        .Item(IndexServ).Item("Tamanho") = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho)
                    End If

                    .Item(IndexServ).Item("Codigo") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoPeca)
                    .Item(IndexServ).Item("UniSemDesc") = Me.grd1.GetRowCellDisplayText(I, Me.colUniSemDesc)
                    .Item(IndexServ).Item("UM") = Me.grd1.GetRowCellDisplayText(I, Me.colUM)
                    bolServico = True
                    IndexServ = IndexServ + 1
                End With
            Else
                With rel.tbPed.Rows
                    .Add()
                    .Item(IndexProd).Item("Produto") = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                    .Item(IndexProd).Item("Qtd") = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                    .Item(IndexProd).Item("Estoque") = CarregarQtd(Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto))
                    .Item(IndexProd).Item("ValorUnitario") = Me.grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                    .Item(IndexProd).Item("ValorTotal") = Me.grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                    If TipoNano = 2 Then

                        Dim dtLoc As DataTable = CarregarDataTable("SELECT Locacao2 FROM Produto where Codigo = " & Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto))
                        If dtLoc.Rows.Count > 0 Then
                            .Item(IndexProd).Item("Tamanho") = dtLoc.Rows.Item(0).Item("Locacao2").ToString
                        End If

                    Else
                        Dim dtLoc As DataTable = CarregarDataTable("SELECT Locacao FROM Produto where Codigo = " & Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto))
                        If dtLoc.Rows.Count > 0 Then
                            If dtLoc.Rows.Item(0).Item("Locacao").ToString <> "" Then
                                .Item(IndexProd).Item("Locacao") = dtLoc.Rows.Item(0).Item("Locacao").ToString
                            End If
                        End If

                        .Item(IndexProd).Item("Tamanho") = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho)
                    End If

                    If NomeEmpresa.ToUpper.Contains("RILOM") = True Then
                        Dim CodigoBarra As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoPeca)
                        Dim dtCodBarra As DataTable = CarregarDataTable("Select CodigoInterno From Produto Where CodigoBarra ='" & CodigoBarra & "'")

                        If dtCodBarra.Rows.Count > 0 Then
                            .Item(IndexProd).Item("Codigo") = dtCodBarra.Rows.Item(0).Item("CodigoInterno").ToString
                        Else
                            .Item(IndexProd).Item("Codigo") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoPeca)
                        End If
                    Else
                        .Item(IndexProd).Item("Codigo") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoPeca)
                    End If

                    .Item(IndexProd).Item("UniSemDesc") = Me.grd1.GetRowCellDisplayText(I, Me.colUniSemDesc)
                    .Item(IndexProd).Item("UM") = Me.grd1.GetRowCellDisplayText(I, Me.colUM)
                    IndexProd = IndexProd + 1
                End With
            End If
        Next

        If TipoNano = 2 Then
            rel.colTamanho.Caption = "Loc."
            rel.colTamanho.Width = 80
        Else
            If parValores = False Then
                rel.colLocacao.Visible = True
                rel.colLocacao.VisibleIndex = 8
                rel.colLocacao1.Visible = True
                rel.colLocacao1.VisibleIndex = 8
            End If
        End If

        If parValores = False Then
            If TipoNano = 2 Then
                rel.colProduto.Width = 340
                rel.colProduto1.Width = 340

                rel.colEstoque.Visible = True
                rel.colEstoque.Width = 60
                rel.colEstoque.VisibleIndex = 6
            Else
                rel.colProduto.Width = 300
                rel.colProduto1.Width = 300

                rel.colEstoque.Visible = True
                rel.colEstoque.Width = 60
                rel.colEstoque.VisibleIndex = 5
            End If
        End If

        Dim dtCli As DataTable = CarregarDataTable("SELECT CPF, RGIE, Endereco, Bairro, Numero, Cidade, Cep, " & _
        "convert(Varchar(10),Nascimento,103) as Nascimento, Complemento, Contato, Estado, EnderecoEntrega, " & _
        "NumeroEntrega, ComplementoEntrega, BairroEntrega, CepEntrega, CidadeEntrega, EstadoEntrega " & _
        "FROM Cliente where Codigo = " & intCodCli)

        If dtCli.Rows.Count > 0 Then
            rel.lblEnd.Text = dtCli.Rows.Item(0).Item("Endereco").ToString
            rel.lblBairro.Text = dtCli.Rows.Item(0).Item("Bairro").ToString
            rel.lblNum.Text = dtCli.Rows.Item(0).Item("Numero").ToString
            Dim strCidade As String
            strCidade = dtCli.Rows.Item(0).Item("Cidade").ToString
            'Dim dssdf As String = strCidade.Substring(0, strCidade.IndexOf("MONTE")).Length
            If strCidade.Length > 17 Then
                rel.lblCidade.Text = strCidade.Substring(0, 17)
            Else
                rel.lblCidade.Text = strCidade
            End If

            rel.lblCep.Text = dtCli.Rows.Item(0).Item("Cep").ToString
            rel.lblCPF.Text = dtCli.Rows.Item(0).Item("CPF").ToString
            rel.lblRG.Text = dtCli.Rows.Item(0).Item("RGIE").ToString
            rel.lblNascimento.Text = dtCli.Rows.Item(0).Item("Complemento").ToString
            rel.lblUF.Text = dtCli.Rows.Item(0).Item("Estado").ToString
            rel.lblContato.Text = dtCli.Rows.Item(0).Item("Contato").ToString


            If dtCli.Rows.Item(0).Item("EnderecoEntrega").ToString <> "" Then
                rel.XrRichText1.Text = "Endereço de Entrega:" & vbCrLf & dtCli.Rows.Item(0).Item("EnderecoEntrega").ToString & ", " & dtCli.Rows.Item(0).Item("NumeroEntrega").ToString & " - " & dtCli.Rows.Item(0).Item("BairroEntrega").ToString & " - " & dtCli.Rows.Item(0).Item("CidadeEntrega").ToString & ", " & dtCli.Rows.Item(0).Item("EstadoEntrega").ToString & " - CEP: " & dtCli.Rows.Item(0).Item("CepEntrega").ToString & " - " & dtCli.Rows.Item(0).Item("ComplementoEntrega").ToString
            Else
                rel.XrRichText1.Visible = False
            End If
        End If

        If Me.rdgDesc.SelectedIndex = 1 Then

            rel.colUniSemDesc.Caption = "Sem Acres. R$"
            rel.XrTableCell7.Text = "Acréscimo R$"
        End If

        If CNPJEmpresa = "20252057000195" Then
            rel.XrTableRow4.Visible = False
        End If
        If DescontoImpressao = False Then
            rel.XrTableRow4.Visible = False
        End If
        rel.colUM.Visible = Me.colUM.Visible
        rel.colUM1.Visible = Me.colUM.Visible
        If parValores = True Then
            rel.colUniSemDesc.Visible = Me.colUniSemDesc.Visible
            rel.colUniSemDesc1.Visible = Me.colUniSemDesc.Visible
        End If

        rel.colTamanho.Visible = Me.colTamanho.Visible
        rel.colTamanho1.Visible = Me.colTamanho.Visible

        Dim strTelef As String
        rel.lblNome.Text = Me.txtCli.Text
        strTelef = Me.txtTel.Text
        rel.lblTel1.Text = strTelef
        rel.lblTel2.Text = Me.txtFax.Text
        rel.lblWeb.Text = Me.txtEmail.Text.ToLower

        If Me.cboStatus.Text = "Orçamento" Then
            rel.lblNomePed.Text = "Orçamento N°:"

        End If

        rel.lblPed.Text = Me.txtCodPed.Text
        rel.lblData.Text = Me.dtData.Text

        rel.tblQtd.Text = intQtdTotal
        rel.tblTotal.Text = Me.txtTotal.Text


        If Me.dtRetirada.Text <> "" And Me.dtRetirada.Text <> "01/01/1900" Then
            rel.lblDataRetirada.Visible = True
            rel.lblDR.Visible = True
            rel.lblDataRetirada.Text = Me.dtRetirada.Text
        End If
        If Me.dtEntrega.Text <> "" And Me.dtEntrega.Text <> "01/01/1900" Then
            rel.lblDataEntrega.Visible = True
            rel.lblDE.Visible = True
            rel.lblDataEntrega.Text = Me.dtEntrega.Text
        End If
        If bolServico = True Then
            rel.DetailReport.Visible = True
            rel.XrTableCell5.Visible = True
            rel.XrTableCell2.Visible = True
            rel.tblTotalprod.Visible = True
            rel.tblTotalserv.Visible = True
            rel.tblTotalprod.Text = Me.txtTotalprod.Text()
            rel.tblTotalserv.Text = Me.txtTotalServ.Text()
        End If

        rel.tblDesc.Text = Me.txtValDesc.Text
        rel.lblVend.Text = Me.lueFunc.Text.Trim
        rel.rtbObs.Text = Me.txtDesc.Text

        rel.rtbConfigObs.Text = ObsPedido

        If parValores = False Then

            rel.colValorUnitario.Visible = False
            rel.colValorTotal.Visible = False
            rel.XrTable1.Visible = False
            rel.colUniSemDesc.Visible = False

            rel.colValorUnitario1.Visible = False
            rel.colValorTotal1.Visible = False
            rel.colUniSemDesc1.Visible = False

            rel.XrLabel1.Visible = False
            rel.XrLine7.Visible = False
            rel.txtTexto.Visible = False


            rel.XrLabel5.Visible = False
            rel.XrLine7.Visible = False
            rel.txtTexto.Visible = False
            rel.XrLabel6.Visible = False
            rel.XrLabel9.Visible = False
            rel.XrLine8.Visible = False
            rel.txtTexto2.Visible = False
        End If


        Dim dt As DataTable = CarregarDataTable("SELECT convert(varchar(10),DataVenda,103) as DataVenda FROM TotalConsig where CodOrdens = " & Me.txtCodPed.Text & " and CodConfig = " & CodConfig & " and Status = 'Faturado'")
        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item("DataVenda").ToString <> "" Then
                rel.lblVenda.Text = dt.Rows.Item(0).Item("DataVenda").ToString
                rel.lblVenda.Visible = True
                rel.lblLabelVenda.Visible = True
            End If
        End If

        'OcultarAutorizacao
        If AutorizacaoPedido = False Then
            rel.lblAutorizacao.Visible = False
            rel.lblAutorizacaoEmpresa.Visible = False
        Else
            rel.lblAutorizacao.Text = Me.txtCli.Text
            rel.lblAutorizacaoEmpresa.Text = NomeEmpresa
        End If



        If Me.cboStatus.Text = "Faturado" Then
            Dim dtVenda As DataTable = CarregarDataTable("SELECT CodOrdem FROM Total where CodPedido = " & Me.txtCodPed.Text & " and CodConfig = " & CodConfig)
            Dim dblValor As Double = 0
            Dim dblTroco As Double = 0
            If dtVenda.Rows.Count > 0 Then
                Dim strCodOrdemVenda As String = dtVenda.Rows.Item(0).Item("CodOrdem").ToString
                If strCodOrdemVenda <> "" Then
                    rel.lblNVenda.Visible = True
                    rel.lblNumVenda.Visible = True
                    rel.lblNumVenda.Text = strCodOrdemVenda
                End If
                Dim bolTroco As Boolean = False
                Dim P As Integer
                Dim dtPag As DataTable = CarregarDataTable("SELECT Pagamento, Valor FROM Recebimento where CodOrdem = " & strCodOrdemVenda & " and CodConfig = " & CodConfig)
                If dtPag.Rows.Count > 0 Then

                    For P = 0 To dtPag.Rows.Count - 1
                        Dim strPag As String = dtPag.Rows.Item(P).Item("Pagamento").ToString
                        If dtPag.Rows.Item(P).Item("Valor").ToString <> "" Then
                            dblValor = dtPag.Rows.Item(P).Item("Valor").ToString
                        End If
                        If strPag = "DINHEIRO" Then
                            If bolTroco = False Then
                                If dblTroco > 0 Then
                                    dblValor = dblValor + dblTroco
                                    bolTroco = True
                                End If
                            End If
                        End If

                        rel.txtTexto.Text &= " " & Dir(strPag, 19) & " R$ " & Esq(dblValor.ToString("0.00"), 9) & vbCrLf
                    Next
                    If dblTroco > 0 Then
                        rel.txtTexto.Text &= " TROCO              " & "R$ " & Esq(dblTroco.ToString("0.00"), 9) & vbCrLf
                    End If

                    If parValores = True Then
                        rel.XrLabel5.Visible = True
                        rel.XrLine7.Visible = True
                        rel.txtTexto.Visible = True

                    End If


                    Dim dtConta As DataTable = CarregarDataTable("Select Parcelas, ValorParcela, Vencimento, RecebidoOK from ContaReceber where CodOrdem =" & strCodOrdemVenda & " and CodConfig =" & CodConfig)
                    If dtConta.Rows.Count > 0 Then
                        Dim J As Integer
                        Dim strVenc, strOK, strPar As String
                        Dim dblValPar As Double

                        For J = 0 To dtConta.Rows.Count - 1
                            strPar = dtConta.Rows.Item(J).Item("Parcelas").ToString
                            dblValPar = dtConta.Rows.Item(J).Item("ValorParcela").ToString
                            strVenc = Format(dtConta.Rows.Item(J).Item("Vencimento"), "dd/MM/yyyy")
                            strOK = "Sim"

                            If dtConta.Rows.Item(J).Item("RecebidoOK") = False Then
                                strOK = "Não"
                            End If

                            rel.txtTexto2.Text &= Cent(strPar, 5) & Esq(dblValPar.ToString("0.00"), 16) & Esq(strVenc, 14) & Esq(strOK, 10) & vbCrLf

                        Next
                        If parValores = True Then
                            rel.XrLabel6.Visible = True
                            rel.XrLabel9.Visible = True
                            rel.XrLine8.Visible = True
                            rel.txtTexto2.Visible = True
                        End If

                    End If

                End If



            End If

        Else
            If parValores = True Then

                Dim dtEntrada As DataTable = CarregarDataTable("Select Pagamento, Valor From Recebimento Where CodigoPedido = " & Me.txtCodPed.Text & " And CodConfig=" & CodConfig)

                If dtEntrada.Rows.Count > 0 Then

                    rel.XrLabel5.Visible = True
                    rel.XrLine7.Visible = True
                    rel.txtTexto.Visible = True


                    rel.txtTexto.Text &= "ENTRADA" & vbCrLf
                    Dim strPag As String
                    Dim strValor As String
                    Dim dblValor As Double
                    Dim J As Integer
                    For J = 0 To dtEntrada.Rows.Count - 1
                        strPag = dtEntrada.Rows.Item(J).Item("Pagamento").ToString
                        dblValor = dtEntrada.Rows.Item(J).Item("Valor").ToString
                        strValor = dblValor.ToString("####,##0.00")

                        rel.txtTexto.Text &= strPag & "   R$ " & strValor & vbCrLf
                    Next

                End If
            End If
        End If

        rel.lblStatus.Text = Me.cboGrp.Text

        If parEnviarEmail = False Then
            rel.ShowPreview()
        Else
            rel.ExportToPdf("C:\NANO\Pedidos\Pedido Nº " & Me.txtCodPed.Text.Trim & ".pdf")
        End If

    End Sub


    Private Sub txtEntrega_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEntrega.Leave
        Calcular(False)
    End Sub

    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        If MsgBox("Tem certeza que deseja excluir o Pedido Nº " & Me.txtCodPed.Text.Trim & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            If SenhaEstaOK() = False Then Exit Sub

            Dim strMotivo As String = InputBox("Digite um motivo para excluir o pedido!")
            If strMotivo = "" Then
                MsgBox("É necessário informar um motivo para excluir o pedido!", MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                strMotivo = "EXCLUSÃO - " & strMotivo.ToUpper.Replace("'", "").Replace("&", "E").Trim

                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & "PEDIDO Nº " & Me.txtCodPed.Text.Trim & ", " & Me.txtCli.Text.Trim & "','EXCLUÍDO','PEDIDO','PEDIDO','" & strMotivo & "'," & CodConfig & ")")
                Excluir("Update TotalConsig set Status ='Excluído' where CodOrdens =" & Me.txtCodPed.Text.Trim & " AND CodConfig =" & CodConfig)
                MsgBox("Pedido excluído com sucesso!", MsgBoxStyle.Information)

                Limpar(True)
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If Me.XtraTabControl1.SelectedTabPageIndex = 1 Then
            If Me.chkAlterado.Checked = True Then
                Me.txtNomePro.Focus()
            Else
                Me.txtCodPro.Focus()
            End If
            If bolF4 = True Then
                Me.txtNomePro.Focus()
                bolF4 = False
            End If
            Timer1.Stop()
            Exit Sub
        End If
        If Me.Tag = "CADASTRA" Then
            If TipoNano = 5 Then
                Me.txtCli.Focus()
            Else
                Me.lueFunc.Focus()
            End If
        Else
            If Me.txtCodPed.Text = "" Then
                Me.txtCodPed.Focus()
            Else
                If TipoNano = 5 Then
                    Me.txtCli.Focus()
                Else
                    Me.lueFunc.Focus()
                End If
            End If

        End If


        Timer1.Stop()
    End Sub

    Private Sub txtDesc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesc.KeyPress, txtCodPro.KeyPress, txtCodPed.KeyPress
        If e.KeyChar = "'" Or e.KeyChar = "&" Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnPromissoria_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPromissoria.ItemClick
        If Me.txtTotal.Text = "" Then Exit Sub
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
            rel.lblEmit.Text = Me.txtCli.Text.Trim
            rel.lblEnd.Text = strEndereco
            rel.lblCPF2.Text = dt.Rows.Item(0).Item("CPF").ToString
            Dim strNomeEmpresa As String = NomeEmpresa
            If IO.File.Exists(My.Application.Info.DirectoryPath & "\RazaoSocial.txt") = True Then
                strNomeEmpresa = LerArquivo(My.Application.Info.DirectoryPath & "\RazaoSocial.txt", False).Trim
            End If

            rel.lblVia.Text = strNomeEmpresa
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
        TamanhoProd()

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
        If TipoNano = 5 Then
            If ImpressaoPedidoCompleto = False Then
                If ImpressaoPadrao = True Then
                    ImprimirPadrao(parComValor, parEnviarEmail)
                Else
                    VisualizarAutomotivo(parComValor, parEnviarEmail)
                End If

            Else
                VisualizarAutomotivoCompleto(parComValor, parEnviarEmail)
            End If
        Else
            If ImpressaoPadrao = True Then
                ImprimirPadrao(parComValor, parEnviarEmail)
            Else
                If ImpressaoPedidoCompleto = False Then
                    Visualizar(parComValor, parEnviarEmail)
                Else
                    VisualizarCompleto(parComValor, parEnviarEmail)
                End If
            End If
           
        End If

    End Sub

    Private Sub btnVisualizarSemValores_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizarSemValores.ItemClick
        EscolherImpressao(False, False)
    End Sub

    Private Sub txtPerDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPerDesc.KeyPress
        If e.KeyChar = "-" Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtPerDesc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPerDesc.Leave
        If Me.txtValor.Text = "" Then
            Me.txtValor.Text = CampoValor(dblUniSemDesc)
        End If
        If Me.txtValor.Text = "" Then Exit Sub

        Dim dblUni As Double = dblUniSemDesc

        If Me.txtPerDesc.Text.Trim <> "" And Me.txtPerDesc.Text.Trim <> "0,00" And Me.txtPerDesc.Text.Trim <> "0" Then


            Dim dblPerDesc As Double = Me.txtPerDesc.Text.Trim

            If strDescontoCliente <> "" Then
                Dim dblDescCli As Double = strDescontoCliente

                If dblPerDesc = dblDescCli Then
                    Me.btnAdd.Focus()
                    Exit Sub
                End If
            End If



            Dim dblResto As Double = (dblUni / 100) * dblPerDesc

            dblUni = dblUni - dblResto
            Me.txtValor.Text = CampoValor(dblUni)
            Try
                Dim dblValD As Double = dblUniSemDescOriginal - Me.txtValor.Text
                Me.txtValDesconto.Text = dblValD.ToString("0.000")
            Catch ex As Exception
            End Try

            bolPromocao = True
            If bolMensagemDesconto = False Then

                If strDescontoPromocao <> "" Then
                    Dim dblDescProm As Double = strDescontoPromocao
                    If dblPerDesc <> dblDescProm Then
                        If Nivel = "USUÁRIO" Then
                            MsgBox("Produto já em promoção, para alterar o desconto digite a senha de um usuário com nível de ADMINISTRADOR!", MsgBoxStyle.Information)
                            If SenhaEstaOK() = False Then
                                Me.txtValor.Text = CampoValor(dblUniSemDescOriginal)
                                dblUniSemDesc = dblUniSemDescOriginal
                                Me.txtPerDesc.Text = strDescontoPromocao
                                Try
                                    Dim dblValD As Double = dblUniSemDescOriginal - Me.txtValor.Text
                                    Me.txtValDesconto.Text = dblValD.ToString("0.000")
                                Catch ex As Exception
                                End Try
                                bolPromocao = True
                                bolMensagemDesconto = False
                                Me.btnAdd.Focus()
                                Exit Sub
                            Else
                                bolMensagemDesconto = True
                                Me.btnAdd.Focus()
                                Exit Sub
                            End If
                        End If
                    End If
                End If


                If DescontoMaximo <> "" Then
                    If dblPerDesc > CDbl(DescontoMaximo) Then
                        If Nivel = "USUÁRIO" Then
                            MsgBox("Desconto é maior do que o permitido, digite a senha de um usuário com nível de ADMINISTRADOR!", MsgBoxStyle.Information)
                            If SenhaEstaOK() = False Then
                                MsgBox("Desconto maior que o permitido!", MsgBoxStyle.Information)
                                Me.txtValor.Text = CampoValor(dblUniSemDescOriginal)
                                dblUniSemDesc = dblUniSemDescOriginal
                                Try
                                    Dim dblValD As Double = dblUniSemDescOriginal - Me.txtValor.Text
                                    Me.txtValDesconto.Text = dblValD.ToString("0.000")
                                Catch ex As Exception
                                End Try
                                Me.txtPerDesc.Text = ""
                                bolPromocao = False
                                bolMensagemDesconto = False
                            Else
                                bolMensagemDesconto = True
                            End If
                        End If
                    End If
                End If
            End If



        Else
            Me.txtValor.Text = CampoValor(dblUniSemDesc)
        End If

        If Me.cboCodFunc.Visible = True And Me.cboCodFunc.Text = "" Then
            Me.cboCodFunc.Focus()
        Else
            Me.btnAdd.Focus()
        End If

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
        If SegViaRecibo = True Then
            If MsgBox("Deseja imprimir a segunda via?", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Imprimir()
            End If
        End If
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
            frmRecebimento.intCodCliente = intCodCli
            NomeDoCliente = Me.txtCli.Text
            frmRecebimento.ShowDialog()
        End If
    End Sub

    Private Sub btnVender_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVender.ItemClick
        If TesteConexao() = False Then Exit Sub
        If TipoNano <> 5 Then
            If Validar(Me.lueFunc) = False Then Exit Sub
        End If

        If Validar(Me.txtCli) = False Then Exit Sub
        If Validar(Me.dtData) = False Then Exit Sub
        'If Validar(Me.txtTotPeso) = False Then Exit Sub

        If Me.Tag = "CADASTRA" Then
            Salvar(False)
        Else
            If Me.txtCodPed.Text = "" Then Exit Sub
        End If

        Dim strCod As String = Me.txtCodPed.Text

        Dim dt As DataTable = CarregarDataTable("SELECT * FROM TotalConsig where CodOrdens = " & strCod & " and Status = 'Faturado' and CodConfig = " & CodConfig)
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
        If dt.Rows.Count = 0 Then
            Dim dtCodBarra As DataTable = CarregarDataTable("SELECT CodProd FROM CodigoBarra where CodigoBarra = '" & Me.txtCodPro2.Text & "' and Produto = '' or CodigoBarra = '" & Me.txtCodPro2.Text & "' and Produto is null")
            If dtCodBarra.Rows.Count > 0 Then
                CodigoDoProduto = dtCodBarra.Rows.Item(0).Item("CodProd").ToString
                dt = CarregarDataTable("Select Codigo, Nome, Valor, UnidadeMedida, ValorCusto, Desconto, CodigoInterno from Produto where Codigo=" & CodigoDoProduto)
            End If
        End If
        If dt.Rows.Count > 0 Then
            CodigoDoProduto = dt.Rows(0).Item("Codigo").ToString
            If bolTamanhoNoCodigo = False Then
                TamanhoProd()
            End If
            Me.txtCodPro2.Tag = CodigoDoProduto
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

        If Me.chkAuto.Checked = True Then
            Remover()
        End If
    End Sub

    Private Sub btnRemover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemover.Click
        Remover()
    End Sub

    Private Sub Remover()

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
            Calcular(False)
        End If

    End Sub
   
    'Private Sub CalcularMedidas()

    '    If bolGaxeta = False Then Exit Sub

    '    If Me.txtMedidaA.Text = "" Then Exit Sub
    '    If Me.txtMedidaB.Text = "" Then Exit Sub
    '    If Me.txtQtd.Text = "" Then Exit Sub


    '    Dim dblMedidaA As Double = Me.txtMedidaA.Text
    '    Dim dblMedidaB As Double = Me.txtMedidaB.Text


    '    Dim dblResul As Double = dblMedidaA + dblMedidaB
    '    dblResul = dblResul * 2

    '    Me.txtQtdMedida.Text = dblResul.ToString("0.000")

    '    Me.txtValor.Text = (dblResul * dblUniSemDescOriginal).ToString("0.00")

    '    If CDbl(Me.txtValor.Text) < ValorMinimoGaxeta Then
    '        Me.txtValor.Text = ValorMinimoGaxeta.ToString("0.00")
    '    End If

    'End Sub

    Private Sub txtQtd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQtd.KeyDown
        If TemBalanca = True Then
            If e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9 Then
                bolDigQtd = True
            ElseIf e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9 Then
                bolDigQtd = True
            ElseIf e.KeyCode = Keys.Back Then
                If Me.txtQtd.Text.Trim <> "" Then
                    If CDbl(Me.txtQtd.Text.Trim) = 0 Then Me.txtQtd.ResetText()
                    bolDigQtd = True
                Else
                    bolDigQtd = False
                End If
            End If
        End If
    End Sub

    Private Sub txtQtd_Leave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtd.Leave
        'CalcularMedidas()
        If strDescontoCliente <> "" Then
            Me.btnAdd.Focus()
        Else
            'If Me.txtMedidaA.Visible = False Then
            If strDescontoPromocao <> "" Then
                ' If Me.txtValor.Enabled = False Then
                Me.btnAdd.Focus()
                'Else
                ' Me.txtValor.Focus()
                'End If
            Else
                Me.txtValor.Focus()
            End If
            'End If
        End If

        If Me.txtQtd.Text.Trim <> "" Then
            If CDbl(Me.txtQtd.Text.Trim) = 0 Then Me.txtQtd.ResetText()
            ''bolDigQtd = True
        Else
            bolDigQtd = False
        End If

        CalcularQtdEmb2()
        CalcularQtdEmb()
    End Sub

    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub

    Private Sub cboTabela_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTabela.EditValueChanged
        If TabelaPrecoPorItem = True Then
            If Me.txtCodPro.Text <> "" Then
                If Me.cboTabela.Text <> "PADRÃO" Then
                    Dim dtTab As DataTable = CarregarDataTable("Select Codigo From Grupo Where Nome='" & Me.cboTabela.Text.Trim & "'")
                    Dim Codigo As Integer = dtTab.Rows.Item(0).Item("Codigo").ToString

                    Dim CodProd As Integer = Me.txtCodPro.Tag
                    dtTab = CarregarDataTable("Select Valor From TabelaPreco Where CodTabela=" & Codigo & " And CodProd=" & CodProd & "")
                    If dtTab.Rows.Count > 0 Then
                        If dtTab.Rows.Item(0).Item("Valor").ToString <> "" Then
                            Me.txtValor.Text = CampoValor(dtTab.Rows.Item(0).Item("Valor").ToString())
                        End If
                    End If
                Else
                    Dim CodProd As Integer = Me.txtCodPro.Tag
                    Dim dtTab As DataTable = CarregarDataTable("Select Valor From Produto Where Codigo=" & CodProd & "")
                    If dtTab.Rows.Count > 0 Then
                        If dtTab.Rows.Item(0).Item("Valor").ToString <> "" Then
                            Me.txtValor.Text = CampoValor(dtTab.Rows.Item(0).Item("Valor").ToString())
                        End If
                    End If
                End If
               
            End If
            Exit Sub
        End If

        If Me.grd1.RowCount > 0 Then
            Me.txtValDesc.ResetText()
            Me.txtDesconto.ResetText()
            DescontoComValor(False)

            If Me.cboTabela.Text <> "PADRÃO" Then
                Dim I As Integer
                Dim dbValor As Double

                For I = 0 To Me.grd1.RowCount - 1
                    Dim dt As DataTable = CarregarDataTable("Select Codigo From Grupo Where Nome='" & Me.cboTabela.Text.Trim & "'")
                    Dim Codigo As Integer = dt.Rows.Item(0).Item("Codigo").ToString

                    Dim CodProd As Integer = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto)
                    Dim dtTabela As DataTable = CarregarDataTable("Select Valor From TabelaPreco Where CodTabela=" & Codigo & " And CodProd=" & CodProd & "")
                    If dtTabela.Rows.Count > 0 Then
                        If dtTabela.Rows.Item(0).Item("Valor").ToString <> "" Then
                            dbValor = dtTabela.Rows.Item(0).Item("Valor").ToString()
                        Else
                            dbValor = 0
                        End If
                    Else
                        dbValor = 0
                    End If

                    'If resCasasDecimais = True Then
                    '    Me.grd1.SetRowCellValue(I, Me.colValorUnitario, dbValor.ToString("0.000"))
                    '    Me.grd1.SetRowCellValue(I, Me.colValorTotal, dbValor.ToString("0.000"))
                    '    Me.grd1.SetRowCellValue(I, Me.colUniSemDesc, dbValor.ToString("0.00"))
                    'Else
                    Me.grd1.SetRowCellValue(I, Me.colValorUnitario, CampoValor(dbValor))
                    Me.grd1.SetRowCellValue(I, Me.colValorTotal, dbValor.ToString("0.00"))
                    Me.grd1.SetRowCellValue(I, Me.colUniSemDesc, CampoValor(dbValor))
                    Me.grd1.SetRowCellValue(I, Me.colTabelaPreco, Me.cboTabela.Text)
                    'End If
                Next
                Calcular(False)
                Me.txtValDesc.ResetText()
                Me.txtDesconto.ResetText()
                Me.txtCodPro.Focus()
            Else
                Dim I As Integer
                Dim dbValor As Double

                For I = 0 To Me.grd1.RowCount - 1
                    Dim CodProd As Integer = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto)
                    Dim dt As DataTable = CarregarDataTable("Select Valor From Produto Where Codigo=" & CodProd & "")
                    If dt.Rows.Count > 0 Then
                        If dt.Rows.Item(0).Item("Valor").ToString <> "" Then
                            dbValor = dt.Rows.Item(0).Item("Valor").ToString()
                        Else
                            dbValor = 0
                        End If
                    Else
                        dbValor = 0
                    End If

                    'If resCasasDecimais = True Then
                    '    Me.grd1.SetRowCellValue(I, Me.colValorUnitario, dbValor.ToString("0.000"))
                    '    Me.grd1.SetRowCellValue(I, Me.colValorTotal, dbValor.ToString("0.000"))
                    '    Me.grd1.SetRowCellValue(I, Me.colUniSemDesc, dbValor.ToString("0.00"))
                    'Else
                    Me.grd1.SetRowCellValue(I, Me.colValorUnitario, CampoValor(dbValor))
                    Me.grd1.SetRowCellValue(I, Me.colValorTotal, dbValor.ToString("0.00"))
                    Me.grd1.SetRowCellValue(I, Me.colUniSemDesc, CampoValor(dbValor))
                    Me.grd1.SetRowCellValue(I, Me.colTabelaPreco, Me.cboTabela.Text)
                    'End If
                Next
                Calcular(False)
                Me.txtValDesc.ResetText()
                Me.txtDesconto.ResetText()
                Me.txtCodPro.Focus()
            End If
        End If
    End Sub

    'Private Sub btnCadTabVal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadTabVal.Click
    '    If Me.grd1.RowCount > 0 Then
    '        Dim Index As Integer = grd1.FocusedRowHandle
    '        Try
    '            frmTabelaPreco.intCodProd = Me.grd1.GetRowCellDisplayText(Index, Me.colCodigoProduto)
    '            Dim dbValor As Double
    '            For I As Integer = 0 To Me.grd1.RowCount - 1
    '                Dim dt As DataTable = CarregarDataTable("Select ValorCusto From Produto Where Codigo=" & frmTabelaPreco.intCodProd & "")
    '                If dt.Rows.Count > 0 Then
    '                    If dt.Rows.Item(0).Item("ValorCusto").ToString <> "" Then
    '                        dbValor = dt.Rows.Item(0).Item("ValorCusto").ToString()
    '                    Else
    '                        dbValor = 0
    '                    End If
    '                Else
    '                    dbValor = 0
    '                End If
    '            Next

    '            If TresCasasDecimais = True Then
    '                frmTabelaPreco.strValorCusto = dbValor.ToString("0.000")
    '            Else
    '                frmTabelaPreco.strValorCusto = dbValor.ToString("0.00")
    '            End If
    '            frmTabelaPreco.ShowDialog()
    '        Catch ex As Exception
    '        End Try
    '    End If
    'End Sub

    Private Sub txtComanda_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtComanda.Leave
        VerificarComanda()

    End Sub


    Private Function VerificarComanda() As Boolean

        If Me.txtComanda.Text = "" Then
            Me.txtCodPro.Focus()
            Return True

            Exit Function
        End If

        If Me.txtComanda.Text = strComanda Then
            Me.txtCodPro.Focus()
            Return True

            Exit Function
        End If

        Dim dt As DataTable = CarregarDataTable("SELECT Comanda FROM TotalConsig where Status <> 'Faturado' and Status <> 'Excluído' and Comanda = '" & Me.txtComanda.Text & "' and CodConfig = " & CodConfig)

        If dt.Rows.Count > 0 Then

            MsgBox("Comanda já aberta!", MsgBoxStyle.Information)
            Me.txtComanda.ResetText()
            Me.txtComanda.Focus()
            Return False
            Exit Function

        End If

        Me.txtCodPro.Focus()
        Return True

    End Function

    Private Sub lueFunc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueFunc.Leave
        'If ComandaPedido = False Then
        '    Me.txtCodPro.Focus()
        'End If
        Me.txtCli.Focus()
    End Sub



    Private Sub GroupControl1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Public Shared Function ListaBytesParaString(ByVal lista As Byte()) As String
        Dim retornoChar As Char() = New Char(lista.Length - 1) {}
        For i As Integer = 0 To lista.Length - 1
            retornoChar(i) = ChrW(lista(i))
        Next
        Dim retorno As New String(retornoChar)
        Return retorno
    End Function
    Dim PortaAberta As Boolean = False

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If TemBalanca = True Then
            If PortaAberta = False Then
                If clsToledoPrix.AbrePorta(PortaBalanca, BaudRateBalanca, DataBitsBalanca, ParidadeBalanca) = 1 Then
                    PortaAberta = True
                End If
            End If
            If bolDigQtd = True Then Exit Sub

            Dim DadosPeso As Byte() = New Byte(5) {}  '5 bytes + nulo
            Dim Caminho As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)

            If clsToledoPrix.PegaPeso(0, DadosPeso, Caminho) = 1 Then
                Me.lblStatus.Text = ""
                Dim strPeso As String = ListaBytesParaString(DadosPeso)
                Dim strDec, strInt As String
                strInt = Mid(strPeso, 1, 2)
                strDec = Mid(strPeso, 3, 5)
                strPeso = strInt & "," & strDec

                Dim dblPeso As Double = strPeso

                If dblPeso > 0 Then
                    Me.txtQtd.Text = dblPeso.ToString("0.000")
                Else
                    If bolDigQtd = False Then
                        Me.txtQtd.ResetText()
                    End If
                End If

            Else
                Me.lblStatus.Text = "Lendo Balança..."
            End If
        End If
    End Sub

    Private Sub btnCadGrp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadGrp.Click
        Dim frm As New frmGrupo
        frmGrupo.Tag = "PEDIDO"
        frmGrupo.ShowDialog()

        Me.cboGrp.Properties.Items.Clear()
        PreencherGrupoSetorCusto("P", Me.cboGrp)
        Me.cboGrp.Focus()

        bolStatusPedido = True
    End Sub

    Private Sub luePlaca_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luePlaca.EditValueChanged
        If bolConsulta = True Then Exit Sub
        If luePlaca.Text.Trim = "" Then Exit Sub
        CarregarCarro(luePlaca.Text.Trim, False)
        If SemCarro = False Then
            txtKm.Focus()
        End If

    End Sub

    Private Sub txtPlaca_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPlaca.Enter
        strEstaComFocus = "txtPlaca"
    End Sub

    Private Sub txtPlaca_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPlaca.Leave
        CarregarCarro(Me.txtPlaca.Text.Trim, True)
    End Sub

    Private Sub CarregarCarro(ByVal parPlaca As String, ByVal parCarregaCliente As Boolean)
        If parPlaca = "" Then Exit Sub

        If parPlaca.Length < 7 Then
            txtPlaca.ResetText()
            MsgBox("Formato de Placa incorreto!", MsgBoxStyle.Critical)
            txtPlaca.Focus()
            Exit Sub
        End If

        Dim dt As DataTable
        dt = CarregarDataTable("Select Modelo, Cor, Ano, CodCli, Motor from Carro Where Placa ='" & parPlaca & "'")
        If dt.Rows.Count = 0 Then
            If SemCarro = False Then
                Me.txtPlaca.ResetText()
                MsgBox("Veículo ainda não cadastrado no sistema!", MsgBoxStyle.Exclamation)
                Me.txtPlaca.Focus()

            End If
            txtAno.ResetText()
            txtMod.ResetText()
            txtCor.ResetText()

        Else
            Me.txtPlaca.Text = parPlaca
            Me.txtMod.Text = dt.Rows.Item(0).ItemArray(0).ToString
            Me.txtCor.Text = dt.Rows.Item(0).ItemArray(1).ToString
            Me.txtAno.Text = dt.Rows.Item(0).ItemArray(2).ToString
            Me.txtMotor.Text = dt.Rows.Item(0).Item("Motor").ToString
            'If SemCarro = False Then
            'If parCarregaCliente = True Then
            'CarregarCliente(dt.Rows.Item(0).Item("CPFCliente").ToString, False, False)
            CodigoDoCliente = dt.Rows.Item(0).Item("CodCli").ToString
            CarregarCliente(dt.Rows.Item(0).Item("CodCli").ToString, False)
            'Dim dtCli As DataTable = CarregarDataTable("Select Cliente.Codigo From Cliente Left Join Carro on Carro.CPFCliente = Cliente.CPF Where Placa='" & parPlaca & "'")

            'If dtCli.Rows.Count > 0 Then

            'End If

            'If CodigoDoCliente <> Nothing Then
            'Me.txtCli.Text = NomeDoCliente
            'CarregarCliente(CodigoDoCliente)
            'End If
            'End If
            'End If
            'Me.txtKm.Focus()
        End If
    End Sub

    Private Sub txtValDesconto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValDesconto.KeyPress
        If e.KeyChar = "-" Then
            e.Handled = False
        End If
    End Sub

    Private Sub NanoCampo1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValDesconto.Leave
        Me.txtPerDesc.Text = ""
        'Calcular("VALOR")

        'DescontoComValor(False)
        DescontoProdValor()
        'Me.txtPerDesc.Focus()
    End Sub

    Private Sub DescontoProdValor()
        If Me.txtValor.Text = "" Then
            Me.txtValor.Text = dblUniSemDesc.ToString("0.00")
        End If
        If Me.txtValor.Text = "" Then Exit Sub

        Dim dblUni As Double = dblUniSemDesc

        If Me.txtValDesconto.Text.Trim <> "" And Me.txtValDesconto.Text.Trim <> "0,000" And Me.txtValDesconto.Text.Trim <> "0,00" And Me.txtValDesconto.Text.Trim <> "0" Then

            If txtValDesconto.Text.Trim = "" Then
                txtValDesconto.Text = "0,00"
            Else
                Dim dblVD As Double = txtValDesconto.Text.Trim
                'If dblVD <= 0 Then
                '    txtValDesconto.Text = "0,00"
                'End If
            End If

            'If Me.txtTota.Text = "0,00" Then Exit Sub

            Dim dblTotal, dblValDesc, dblResul As Double

            dblValDesc = Me.txtValDesconto.Text.Trim

            dblTotal = dblUni 'Me.txtValor.Text 'dblTotalSemDesconto
            ''If TipoDesconto = "ITENS" Then
            ''    dblTotal = dblTotalSemDesconto
            ''Else
            ''    dblTotal = dblTotalComDesconto
            ''End If


            dblResul = (dblTotal - dblValDesc)

            Me.txtValor.Text = CampoValor(dblResul)



            'If TipoDesconto = "ITENS" Then
            'dblTotal = Me.txtValor.Text 'dblTotalSemDesconto
            'Else
            'dblTotal = dblTotalComDesconto
            'End If

            dblValDesc = dblValDesc * 100

            dblResul = dblValDesc / dblTotal

            Me.txtPerDesc.Text = dblResul.ToString("0.000")

            If Me.txtPerDesc.Text.ToUpper = "NAN (NÃO É UM NÚMERO)" Or Me.txtDesconto.Text.ToUpper = "+INFINITO" Then
                Me.txtPerDesc.Text = "0,00"
                Me.txtValDesconto.Text = "0,00"
            End If

            'If NanoCampo1.Text = "" Or NanoCampo1.Text = "0,00" Or NanoCampo1.Text = "0,000" Or NanoCampo1.Text = "0" Then
            '    Me.txtPerDesc.Focus()
            '    Me.NanoCampo1.Focus()
            '    Me.txtPerDesc.Focus()
            'End If
            bolPromocao = True
            If bolMensagemDesconto = False Then

                If strDescontoPromocao <> "" Then
                    Dim dblDescProm As Double = strDescontoPromocao
                    If dblResul <> dblDescProm Then
                        If Nivel = "USUÁRIO" Then
                            MsgBox("Produto já em promoção, para alterar o desconto digite a senha de um usuário com nível de ADMINISTRADOR!", MsgBoxStyle.Information)
                            If SenhaEstaOK() = False Then
                                Me.txtValor.Text = CampoValor(dblUniSemDescOriginal)
                                dblUniSemDesc = dblUniSemDescOriginal
                                Me.txtPerDesc.Text = strDescontoPromocao
                                Try
                                    Dim dblValD As Double = dblUniSemDescOriginal - Me.txtValor.Text
                                    Me.txtValDesconto.Text = dblValD.ToString("0.000")
                                Catch ex As Exception
                                End Try
                                bolPromocao = True
                                bolMensagemDesconto = False
                                Me.btnAdd.Focus()
                                Exit Sub
                            Else
                                bolMensagemDesconto = True
                                Me.btnAdd.Focus()
                                Exit Sub
                            End If
                        End If
                    End If
                End If


                If DescontoMaximo <> "" Then
                    If dblResul > CDbl(DescontoMaximo) Then
                        If Nivel = "USUÁRIO" Then
                            MsgBox("Desconto é maior do que o permitido, digite a senha de um usuário com nível de ADMINISTRADOR!", MsgBoxStyle.Information)
                            If SenhaEstaOK() = False Then
                                MsgBox("Desconto maior que o permitido!", MsgBoxStyle.Information)
                                Me.txtValor.Text = CampoValor(dblUniSemDescOriginal)
                                dblUniSemDesc = dblUniSemDescOriginal
                                Try
                                    Dim dblValD As Double = dblUniSemDescOriginal - Me.txtValor.Text
                                    Me.txtValDesconto.Text = dblValD.ToString("0.000")
                                Catch ex As Exception
                                End Try
                                Me.txtPerDesc.Text = ""
                                bolPromocao = False
                                bolMensagemDesconto = False
                            Else
                                bolMensagemDesconto = True
                            End If
                        End If
                    End If
                End If
            End If

            'If TipoDesconto = "ITENS" Then
            'Calcular()
            'End If

            'If parCarregaForm = False Then
            'Me.txtDesc.Focus()
            'End If
            Me.btnAdd.Focus()
        Else
            Me.txtValor.Text = dblUniSemDesc.ToString("0.00")
            Me.txtPerDesc.Focus()
        End If

    End Sub

    Private Sub UltimoPedido()
        'If Me.txtCodPed.Text = "" Then Exit Sub
        'If strCpfCliente = "" Then Exit Sub
        'If Me.txtPlaca.Text = "" Then Exit Sub
        Dim dblQtd As Double = 0
        If Me.txtCli.Text = "" Then
            Me.tbItens2.Rows.Clear()
            Me.txtTotItem.Text = dblQtd.ToString
            Exit Sub
        End If

        Dim strCod As String = ""
        Dim strKMPedidos As String = ""


        Dim dt As DataTable '= CarregarDataTable("SELECT Top 1 Codigo FROM Total where Status = 'Faturado' and Placa = '" & Me.txtPlaca.Text & "' and Cod <> '" & Me.txtCodPed.Text & "' order by Codigo DESC")
        If TipoNano <> 5 Then
            dt = CarregarDataTable("Select Top 1 TotalConsig.CodOrdens From TotalConsig Left Join Cliente On TotalConsig.CodCli = Cliente.Codigo Where TotalConsig.Status='Faturado' And Cliente.Codigo='" & intCodCli & "' And TotalConsig.CodConfig=" & CodConfig & " Order By TotalConsig.CodOrdens Desc")
        Else
            If Me.txtPlaca.Text <> "" Then
                dt = CarregarDataTable("Select Top 1 TotalConsig.Codordens From TotalConsig Left Join Cliente On TotalConsig.CodCli = Cliente.Codigo Where TotalConsig.Status='Faturado' And TotalConsig.Placa = '" & Me.txtPlaca.Text.Trim & "' And TotalConsig.CodConfig=" & CodConfig & " Order By TotalConsig.CodOrdens Desc")
            Else
                dt = CarregarDataTable("Select Top 1 TotalConsig.CodOrdens From TotalConsig Left Join Cliente On TotalConsig.CodCli = Cliente.Codigo Where TotalConsig.Status='Faturado' And Cliente.Codigo='" & intCodCli & "' And TotalConsig.CodConfig=" & CodConfig & " Order By TotalConsig.CodOrdens Desc")
            End If
        End If

        If dt.Rows.Count > 0 Then
            strCod = dt.Rows.Item(0).Item("CodOrdens").ToString
            If strCod = "" Then Exit Sub
            'Dim dtPed2 As DataTable = CarregarDataTable("SELECT Codigo, Cod, Placa, Data, Cliente, CPF, Qtd, CodigoProduto, Produto, " & _
            '"convert(Numeric(15,2),ValorUnitario) as ValorUnitario, convert(Numeric(15,2),ValorTotal) as ValorTotal, KM, TipoProduto, CodigoPeca, Modelo, Status, CodigoFuncionario, Custo, " & _
            '"UM, Garantia, UniSemDesc, CodConfig, Autorizado FROM Pedido Where Cod = '" & strCod & "' and CodConfig = " & CodConfig)

            Dim dtPed2 As DataTable
            If TipoNano <> 5 Then
                'dtPed2 = CarregarDataTable("SELECT Codigo, Cod, Placa, Data, Cliente, CPF, Qtd, CodigoProduto, Produto, " & _
                '"convert(Numeric(15,2),ValorUnitario) as ValorUnitario, convert(Numeric(15,2),ValorTotal) as ValorTotal, KM, TipoProduto, CodigoPeca, Modelo, Status, CodigoFuncionario, Custo, " & _
                '"UM, Garantia, UniSemDesc, CodConfig, Autorizado FROM Pedido Where Cod = '" & strCod & "' and CodConfig = " & CodConfig)

                dtPed2 = CarregarDataTable("Select ItensConsig.CodOrdens As Cod, ItensConsig.Qtd, " & _
                "ItensConsig.CodigoProduto, ItensConsig.CodigoInterno, ItensConsig.Produto, " & _
                "ItensConsig.ValorUnitario, ItensConsig.ValorTotal, ItensConsig.UniSemDesc, ItensConsig.Custo, " & _
                "ItensConsig.UM, Produto.Tipo, Total.Data, Total.CodOrdem, TotalConsig.Descricao, TotalConsig.KMEntrada, Autorizado From (((ItensConsig Left Join TotalConsig " & _
                "On ItensConsig.CodOrdens = TotalConsig.CodOrdens) Left Join Produto on ItensConsig.CodigoProduto = " & _
                "Produto.Codigo) Left Join Cliente On TotalConsig.CodCli = Cliente.Codigo) Left Join Total on " & _
                "Total.CodPedido = TotalConsig.CodOrdens Where TotalConsig.Status='Faturado' And " & _
                "TotalConsig.CodOrdens='" & strCod & "' And TotalConsig.CodConfig = " & CodConfig)

            Else
                'dtPed2 = CarregarDataTable("SELECT Codigo, Cod, Placa, Data, Cliente, CPF, Qtd, CodigoProduto, Produto, " & _
                '"convert(Numeric(15,2),ValorUnitario) as ValorUnitario, convert(Numeric(15,2),ValorTotal) as ValorTotal, KM, TipoProduto, CodigoPeca, Modelo, Status, CodigoFuncionario, Custo, " & _
                '"UM, Garantia, UniSemDesc, CodConfig, Autorizado FROM Pedido Where Cod = '" & strCod & "' and CodConfig = " & CodConfig)

                dtPed2 = CarregarDataTable("Select ItensConsig.CodOrdens As Cod, ItensConsig.Qtd, " & _
                "ItensConsig.CodigoProduto, ItensConsig.CodigoInterno, ItensConsig.Produto, " & _
                "ItensConsig.ValorUnitario, ItensConsig.ValorTotal, ItensConsig.UniSemDesc, ItensConsig.Custo, " & _
                "ItensConsig.UM, Produto.Tipo, Total.Data, Total.CodOrdem, TotalConsig.Descricao, TotalConsig.KMEntrada, CodigoFuncionario, Autorizado From (((ItensConsig Left Join TotalConsig " & _
                "On ItensConsig.CodOrdens = TotalConsig.CodOrdens) Left Join Produto on ItensConsig.CodigoProduto = " & _
                "Produto.Codigo) Left Join Cliente On TotalConsig.CodCli = Cliente.Codigo) Left Join Total on " & _
                "Total.CodPedido = TotalConsig.CodOrdens Where TotalConsig.Status='Faturado' And " & _
                "TotalConsig.CodOrdens='" & strCod & "' And TotalConsig.CodConfig = " & CodConfig)
            End If

            Me.tbItens2.Rows.Clear()

            For I = 0 To dtPed2.Rows.Count - 1
                With Me.tbItens2.Rows
                    .Add()
                    .Item(I).Item("CodPedAut") = dtPed2.Rows.Item(I).Item("Cod").ToString
                    .Item(I).Item("CodigoProduto") = dtPed2.Rows.Item(I).Item("CodigoProduto").ToString
                    .Item(I).Item("Produto") = dtPed2.Rows.Item(I).Item("Produto").ToString
                    .Item(I).Item("Qtd") = dtPed2.Rows.Item(I).Item("Qtd").ToString
                    dblQtd = dblQtd + CDbl(dtPed2.Rows.Item(I).Item("Qtd").ToString)
                    .Item(I).Item("ValorUnitario") = CampoValor(dtPed2.Rows.Item(I).Item("ValorUnitario").ToString)
                    .Item(I).Item("ValorTotal") = CampoValor(dtPed2.Rows.Item(I).Item("ValorTotal").ToString)
                    .Item(I).Item("CodigoInterno") = dtPed2.Rows.Item(I).Item("CodigoInterno").ToString
                    .Item(I).Item("Tipo") = dtPed2.Rows.Item(I).Item("Tipo").ToString
                    '.Item(I).Item("CodPedAut") = dtPed2.Rows.Item(I).Item("Codigo").ToString
                    If TipoNano = 5 Then
                        .Item(I).Item("CodigoFuncionario") = dtPed2.Rows.Item(I).Item("CodigoFuncionario").ToString
                    End If

                    .Item(I).Item("UM") = dtPed2.Rows.Item(I).Item("UM").ToString
                    If dtPed2.Rows.Item(I).Item("Custo").ToString <> "" Then
                        .Item(I).Item("Custo") = CampoValor(dtPed2.Rows.Item(I).Item("Custo").ToString)
                    Else
                        .Item(I).Item("Custo") = "0,00"
                    End If
                    If dtPed2.Rows.Item(I).Item("Autorizado").ToString <> "" Then
                        .Item(I).Item("Autorizado") = dtPed2.Rows.Item(I).Item("Autorizado")
                    Else
                        .Item(I).Item("Autorizado") = True
                    End If
                    '.Item(I).Item("Garantia") = dtPed2.Rows.Item(I).Item("Garantia").ToString
                    If dtPed2.Rows.Item(I).Item("UniSemDesc").ToString <> "" And dtPed2.Rows.Item(I).Item("UniSemDesc").ToString <> "0,000" Then
                        .Item(I).Item("UniSemDesc") = CampoValor(dtPed2.Rows.Item(I).Item("UniSemDesc").ToString)
                    Else
                        .Item(I).Item("UniSemDesc") = CampoValor(dtPed2.Rows.Item(I).Item("ValorUnitario").ToString)
                    End If

                    'If dtPed2.Rows.Item(I).Item("Autorizado").ToString <> "" Then
                    'Dim bol As Boolean = dtPed2.Rows.Item(I).Item("Autorizado").ToString
                    '.Item(I).Item("Autorizado") = bol
                    'Else
                    '.Item(I).Item("Autorizado") = True
                    'End If
                    strKMPedidos = dtPed2.Rows.Item(I).Item("KMEntrada").ToString
                End With
            Next

            Dim vetObs As Array = Nothing
            If dtPed2.Rows(0).Item("Descricao").ToString.Contains("|") = True Then
                vetObs = dtPed2.Rows(0).Item("Descricao").ToString.Split("|")
                Me.txtDesc.Text = vetObs(0).ToString
            Else
                Me.txtDesc.Text = dtPed2.Rows(0).Item("Descricao").ToString
            End If
        Else
            Me.tbItens2.Rows.Clear()
            Me.txtTotItem.Text = dblQtd.ToString
        End If
        If strCod = "" Then Exit Sub

        'Dim dtEntradaSaida As DataTable = CarregarDataTable("Select EntradaSaida.Entrada, EntradaSaida.Saida, " & _
        '"Descricao from Total Left join EntradaSaida on Total.Codigo = EntradaSaida.CodigoPedido and " & _
        '"Total.CodConfig = EntradaSaida.CodConfig where CodigoPedido =" & strCod & " and Total.CodConfig = " & CodConfig)

        'If dtEntradaSaida.Rows.Count > 0 Then
        'Me.txtEntPedidos.Text = dtEntradaSaida.Rows(0).Item("Entrada").ToString
        'Me.txtSaiPedidos.Text = dtEntradaSaida.Rows(0).Item("Saida").ToString
        'Me.txtKMPedidos.Text = strKMPedidos
        'Me.txtDesc.Text = dtPed2.Rows(0).Item("Descricao").ToString
        'End If

        Dim dtEntradaSaida As DataTable = CarregarDataTable("Select TotalConsig.Data as Entrada, TotalConsig.DataVenda as Saida, Descricao, KMSaida, KMEntrada From " & _
            "TotalConsig Where CodOrdens=" & strCod & " And TotalConsig.CodConfig = " & CodConfig)

        If dtEntradaSaida.Rows.Count > 0 Then
            Me.txtEntPedidos.Text = dtEntradaSaida.Rows(0).Item("Entrada").ToString
            Me.txtSaiPedidos.Text = dtEntradaSaida.Rows(0).Item("Saida").ToString

            If dtEntradaSaida.Rows(0).Item("KMSaida").ToString = "0" Then
                Me.txtKMPedidos.Text = dtEntradaSaida.Rows(0).Item("KMEntrada").ToString
            Else
                Me.txtKMPedidos.Text = dtEntradaSaida.Rows(0).Item("KMSaida").ToString
            End If

            Dim vetObs As Array

            vetObs = Split(dtEntradaSaida.Rows(0).Item("Descricao").ToString, "|")

            If vetObs.Length > 0 Then
                Me.txtDesc.Text = vetObs(0).ToString
            End If

            If vetObs.Length > 1 Then
                Me.txtProbVeiculo.Text = vetObs(1).ToString
            End If
        End If

        Me.txtTotItem.Text = dblQtd.ToString
        Me.GridView1.OptionsView.ShowGroupPanel = True
        Me.GridView1.Columns.Item("CodPedAut").Group()
        Me.GridView1.ExpandAllGroups()

    End Sub

    Private Sub TodosPedidos()
        'If Me.txtCodPed.Text = "" Then Exit Sub
        Dim dblQtd As Double = 0
        If Me.txtCli.Text = "" Then
            Me.tbItens3.Rows.Clear()
            Me.txtTotItem.Text = dblQtd.ToString
            Exit Sub
        End If

        Dim dtPed3 As DataTable '= CarregarDataTable("SELECT Codigo, Cod, Placa, Data, Cliente, CPF, Qtd, CodigoProduto, Produto, " & _
        '  "convert(Numeric(15,2),ValorUnitario) as ValorUnitario, convert(Numeric(15,2),ValorTotal) as ValorTotal, KM, TipoProduto, CodigoPeca, Modelo, Status, CodigoFuncionario, Custo, " & _
        ' "UM, Garantia, UniSemDesc, CodConfig, Autorizado FROM Pedido Where Status = 'Faturado' and Placa = '" & Me.txtPlaca.Text & "' and CodConfig = " & CodConfig & " order by convert(integer,Cod) DESC")

        If TipoNano <> 5 Then
            dtPed3 = CarregarDataTable("Select ItensConsig.CodOrdens As Cod, ItensConsig.Qtd, " & _
            "ItensConsig.CodigoProduto, ItensConsig.CodigoInterno, ItensConsig.Produto, " & _
            "ItensConsig.ValorUnitario, ItensConsig.ValorTotal, ItensConsig.UniSemDesc, ItensConsig.Custo, " & _
            "ItensConsig.UM, Produto.Tipo, Total.Data, Total.CodOrdem, TotalConsig.Descricao, TotalConsig.KMEntrada, Autorizado From (((ItensConsig Left Join TotalConsig " & _
            "On ItensConsig.CodOrdens = TotalConsig.CodOrdens) Left Join Produto on ItensConsig.CodigoProduto = " & _
            "Produto.Codigo) Left Join Cliente On TotalConsig.CodCli = Cliente.Codigo) Left Join Total on " & _
            "Total.CodPedido = TotalConsig.CodOrdens Where TotalConsig.Status='Faturado' And " & _
            "TotalConsig.CodCli='" & intCodCli & "' And TotalConsig.CodConfig = " & CodConfig)

        Else
            If Me.txtPlaca.Text <> "" Then
                dtPed3 = CarregarDataTable("Select ItensConsig.CodOrdens As Cod, ItensConsig.Qtd, " & _
                "ItensConsig.CodigoProduto, ItensConsig.CodigoInterno, ItensConsig.Produto, " & _
                "ItensConsig.ValorUnitario, ItensConsig.ValorTotal, ItensConsig.UniSemDesc, ItensConsig.Custo, " & _
                "ItensConsig.UM, Produto.Tipo, Total.Data, Total.CodOrdem, TotalConsig.Descricao, TotalConsig.KMEntrada, CodigoFuncionario, Autorizado From (((ItensConsig Left Join TotalConsig " & _
                "On ItensConsig.CodOrdens = TotalConsig.CodOrdens) Left Join Produto on ItensConsig.CodigoProduto = " & _
                "Produto.Codigo) Left Join Cliente On TotalConsig.CodCli = Cliente.Codigo) Left Join Total on " & _
                "Total.CodPedido = TotalConsig.CodOrdens Where TotalConsig.Status='Faturado' And " & _
                "TotalConsig.Placa='" & Me.txtPlaca.Text & "' And TotalConsig.CodConfig = " & CodConfig)
            Else
                dtPed3 = CarregarDataTable("Select ItensConsig.CodOrdens As Cod, ItensConsig.Qtd, " & _
                "ItensConsig.CodigoProduto, ItensConsig.CodigoInterno, ItensConsig.Produto, " & _
                "ItensConsig.ValorUnitario, ItensConsig.ValorTotal, ItensConsig.UniSemDesc, ItensConsig.Custo, " & _
                "ItensConsig.UM, Produto.Tipo, Total.Data, Total.CodOrdem, TotalConsig.Descricao, TotalConsig.KMEntrada, CodigoFuncionario, Autorizado From (((ItensConsig Left Join TotalConsig " & _
                "On ItensConsig.CodOrdens = TotalConsig.CodOrdens) Left Join Produto on ItensConsig.CodigoProduto = " & _
                "Produto.Codigo) Left Join Cliente On TotalConsig.CodCli = Cliente.Codigo) Left Join Total on " & _
                "Total.CodPedido = TotalConsig.CodOrdens Where TotalConsig.Status='Faturado' And " & _
                "TotalConsig.CodCli='" & intCodCli & "' And TotalConsig.CodConfig = " & CodConfig)
            End If
        End If

        Me.tbItens3.Rows.Clear()

        For I = 0 To dtPed3.Rows.Count - 1
            With Me.tbItens3.Rows
                .Add()
                .Item(I).Item("CodPedAut") = dtPed3.Rows.Item(I).Item("Cod").ToString
                .Item(I).Item("CodigoProduto") = dtPed3.Rows.Item(I).Item("CodigoProduto").ToString
                .Item(I).Item("Produto") = dtPed3.Rows.Item(I).Item("Produto").ToString
                .Item(I).Item("Qtd") = dtPed3.Rows.Item(I).Item("Qtd").ToString
                dblQtd = dblQtd + CDbl(dtPed3.Rows.Item(I).Item("Qtd").ToString)
                .Item(I).Item("ValorUnitario") = CampoValor(dtPed3.Rows.Item(I).Item("ValorUnitario").ToString)
                .Item(I).Item("ValorTotal") = CampoValor(dtPed3.Rows.Item(I).Item("ValorTotal").ToString)
                .Item(I).Item("CodigoInterno") = dtPed3.Rows.Item(I).Item("CodigoInterno").ToString
                .Item(I).Item("Tipo") = dtPed3.Rows.Item(I).Item("Tipo").ToString
                '.Item(I).Item("CodPedAut") = dtPed3.Rows.Item(I).Item("Codigo").ToString
                If TipoNano = 5 Then
                    .Item(I).Item("CodigoFuncionario") = dtPed3.Rows.Item(I).Item("CodigoFuncionario").ToString
                End If
                .Item(I).Item("UM") = dtPed3.Rows.Item(I).Item("UM").ToString
                If dtPed3.Rows.Item(I).Item("Custo").ToString <> "" Then
                    .Item(I).Item("Custo") = CampoValor(dtPed3.Rows.Item(I).Item("Custo").ToString)
                Else
                    .Item(I).Item("Custo") = "0,00"
                End If
                If dtPed3.Rows.Item(I).Item("Autorizado").ToString <> "" Then
                    .Item(I).Item("Autorizado") = dtPed3.Rows.Item(I).Item("Autorizado")
                Else
                    .Item(I).Item("Autorizado") = True
                End If
                '.Item(I).Item("Garantia") = dtPed3.Rows.Item(I).Item("Garantia").ToString
                If dtPed3.Rows.Item(I).Item("UniSemDesc").ToString <> "" And dtPed3.Rows.Item(I).Item("UniSemDesc").ToString <> "0,000" Then
                    .Item(I).Item("UniSemDesc") = CampoValor(dtPed3.Rows.Item(I).Item("UniSemDesc").ToString)
                Else
                    .Item(I).Item("UniSemDesc") = CampoValor(dtPed3.Rows.Item(I).Item("ValorUnitario").ToString)
                End If

                'If dtPed3.Rows.Item(I).Item("Autorizado").ToString <> "" Then
                '    Dim bol As Boolean = dtPed3.Rows.Item(I).Item("Autorizado").ToString
                '    .Item(I).Item("Autorizado") = bol
                'Else
                '    .Item(I).Item("Autorizado") = True
                'End If

            End With
        Next
        Me.txtTotItem.Text = dblQtd.ToString
        Me.GridView2.OptionsView.ShowGroupPanel = True
        Me.GridView2.Columns.Item("CodPedAut").Group()
        Me.GridView2.ExpandAllGroups()
    End Sub

    Private Sub CalcularUltimoPedido()
        Dim dblTotal, dblLinha, dblMObra, dblMobraLinha, dblInt, dblIntTot, dblValCus, dblTotValCusto As Double
        For I = 0 To Me.GridView1.RowCount - 1
            ' If Me.GridView1.GetRowCellValue(I, Me.colExcluir2) = True Then
            If GridView1.GetRowCellDisplayText(I, Me.colTipo1) = "VENDA" Or GridView1.GetRowCellDisplayText(I, Me.colTipo1) = "" Then
                dblLinha = GridView1.GetRowCellValue(I, Me.colValorTotal1)
                dblTotal += dblLinha
            End If

            'Dim strTipo As String = GridView1.GetRowCellDisplayText(I, Me.colTipo1)
            If GridView1.GetRowCellDisplayText(I, Me.colTipo1) = "SERVIÇO" Or GridView1.GetRowCellDisplayText(I, Me.colTipo1) = "TERCEIRO" Then
                dblMobraLinha = GridView1.GetRowCellDisplayText(I, Me.colValorTotal1)
                dblMObra += dblMobraLinha
            End If

            'If grd2.GetRowCellDisplayText(I, Me.colTipoProduto2) = "INTERNO" Then
            '    dblInt = grd2.GetRowCellDisplayText(I, Me.colValorTotal2)
            '    dblIntTot += dblInt
            'End If

            'If grd2.GetRowCellDisplayText(I, Me.colTipoProduto2).Trim <> "INTERNO" Then
            '    dblValCus = grd2.GetRowCellDisplayText(I, Me.colCusto2)
            '    dblTotValCusto += dblValCus
            'End If
            'End If

            'calcula a margem de lucro dos itens

            Dim dblValUni, dblCusto, dblLucro, dblMargemLucro As Double

            If GridView1.GetRowCellDisplayText(I, Me.colValorUnitario1).Trim <> "" Then
                dblValUni = GridView1.GetRowCellDisplayText(I, Me.colValorUnitario1)
            End If

            If GridView1.GetRowCellDisplayText(I, Me.colCusto1) <> "" Then
                dblCusto = GridView1.GetRowCellDisplayText(I, Me.colCusto1)
            End If


            dblLucro = dblValUni - dblCusto


            dblMargemLucro = (dblLucro * 100) / dblCusto

            Dim str As String = dblMargemLucro
            If str <> "+Infinito" And str <> "NaN (Não é um número)" Then
                'Me.grd2.SetRowCellValue(I, Me.colMargemLucro2, dblMargemLucro.ToString("0.00"))
            Else
                'Me.grd2.SetRowCellValue(I, Me.colMargemLucro2, "100,00")
            End If
        Next
        'Me.txtValPec.Text = dblTotal.ToString("0.00")
        'Me.txtMObra.Text = dblMObra.ToString("0.00")
        Me.txtTotalprod.Text = dblTotal.ToString("0.00")
        Me.txtTotalServ.Text = dblMObra.ToString("0.00")

        dblTotal = dblTotal + dblMObra
        txtTotal.Text = dblTotal.ToString("0.00")
        'txtTotInt.Text = dblIntTot.ToString("0.00")
    End Sub

    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        'If Me.GridView1.FocusedRowHandle < 0 Then
        '    Me.txtEntPedidos.ResetText()
        '    Me.txtSaiPedidos.ResetText()
        '    Me.txtKMPedidos.ResetText()
        '    Exit Sub
        'End If
        'If Me.GridView1.GetRowCellDisplayText(Me.GridView1.FocusedRowHandle, Me.colCodPedAut1) <> "" Then
        '    Dim dtEntradaSaida As DataTable = CarregarDataTable("Select TotalConsig.Data as Entrada, TotalConsig.DataVenda as Saida, Descricao, KMSaida From " & _
        '    "TotalConsig Where CodOrdens=" & Me.GridView1.GetRowCellDisplayText(Me.GridView1.FocusedRowHandle, Me.colCodPedAut1) & " And TotalConsig.CodConfig = " & CodConfig)

        '    If dtEntradaSaida.Rows.Count > 0 Then
        '        Me.txtEntPedidos.Text = dtEntradaSaida.Rows(0).Item("Entrada").ToString
        '        Me.txtSaiPedidos.Text = dtEntradaSaida.Rows(0).Item("Saida").ToString
        '        Me.txtKMPedidos.Text = dtEntradaSaida.Rows(0).Item("KMSaida").ToString
        '        Me.txtDesc.Text = dtEntradaSaida.Rows(0).Item("Descricao").ToString
        '    End If
        'End If
    End Sub

    Private Sub CalcularTodosPedidos()
        Dim dblTotal, dblLinha, dblMObra, dblMobraLinha, dblInt, dblIntTot, dblValCus, dblTotValCusto As Double
        For I = 0 To GridView2.RowCount - 1
            'If Me.GridView2.GetRowCellValue(I, Me.colExcluir3) = True Then
            If GridView2.GetRowCellDisplayText(I, Me.colTipo2) = "VENDA" Or GridView2.GetRowCellDisplayText(I, Me.colTipo2) = "" Then
                dblLinha = GridView2.GetRowCellValue(I, Me.colValorTotal2)
                dblTotal += dblLinha
            End If
            If GridView2.GetRowCellDisplayText(I, Me.colTipo2) = "SERVIÇO" Or GridView2.GetRowCellDisplayText(I, Me.colTipo2) = "TERCEIRO" Then
                dblMobraLinha = GridView2.GetRowCellDisplayText(I, Me.colValorTotal2)
                dblMObra += dblMobraLinha
            End If

            'If grd3.GetRowCellDisplayText(I, Me.colTipoProduto3) = "INTERNO" Then
            '    dblInt = grd3.GetRowCellDisplayText(I, Me.colValorTotal3)
            '    dblIntTot += dblInt
            'End If

            'If grd3.GetRowCellDisplayText(I, Me.colTipoProduto3).Trim <> "INTERNO" Then
            '    dblValCus = grd3.GetRowCellDisplayText(I, Me.colCusto3)
            '    dblTotValCusto += dblValCus
            'End If
            'End If

            'calcula a margem de lucro dos itens

            Dim dblValUni, dblCusto, dblLucro, dblMargemLucro As Double

            If GridView2.GetRowCellDisplayText(I, Me.colValorUnitario2) <> "" Then
                dblValUni = GridView2.GetRowCellDisplayText(I, Me.colValorUnitario2)
            End If

            If GridView2.GetRowCellDisplayText(I, Me.colCusto2).Trim <> "" Then
                dblCusto = GridView2.GetRowCellDisplayText(I, Me.colCusto2)
            End If

            dblLucro = dblValUni - dblCusto


            dblMargemLucro = (dblLucro * 100) / dblCusto

            Dim str As String = dblMargemLucro
            If str <> "+Infinito" And str <> "NaN (Não é um número)" Then
                'Me.grd3.SetRowCellValue(I, Me.colMargemLucro3, dblMargemLucro.ToString("0.00"))
            Else
                'Me.grd3.SetRowCellValue(I, Me.colMargemLucro3, "100,00")
            End If

        Next

        'Me.txtValPec.Text = dblTotal.ToString("0.00")
        'Me.txtMObra.Text = dblMObra.ToString("0.00")
        Me.txtTotalprod.Text = dblTotal.ToString("0.00")
        Me.txtTotalServ.Text = dblMObra.ToString("0.00")

        dblTotal = dblTotal + dblMObra
        txtTotal.Text = dblTotal.ToString("0.00")
        'txtTotInt.Text = dblIntTot.ToString("0.00")
    End Sub

    Private Sub GridView2_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        If Me.GridView2.FocusedRowHandle < 0 Then
            Me.txtEntPedidos.ResetText()
            Me.txtSaiPedidos.ResetText()
            Me.txtKMPedidos.ResetText()
            Exit Sub
        End If
        If Me.GridView2.GetRowCellDisplayText(Me.GridView2.FocusedRowHandle, Me.colCodPedAut2) <> "" Then
            Dim dtEntradaSaida As DataTable = CarregarDataTable("Select TotalConsig.Data as Entrada, TotalConsig.DataVenda as Saida, Descricao, KMSaida, KMEntrada From " & _
            "TotalConsig Where CodOrdens=" & Me.GridView2.GetRowCellDisplayText(Me.GridView2.FocusedRowHandle, Me.colCodPedAut2) & " And TotalConsig.CodConfig = " & CodConfig)

            If dtEntradaSaida.Rows.Count > 0 Then
                Me.txtEntPedidos.Text = dtEntradaSaida.Rows(0).Item("Entrada").ToString
                Me.txtSaiPedidos.Text = dtEntradaSaida.Rows(0).Item("Saida").ToString

                If dtEntradaSaida.Rows(0).Item("KMSaida").ToString = "0" Then
                    Me.txtKMPedidos.Text = dtEntradaSaida.Rows(0).Item("KMEntrada").ToString
                Else
                    Me.txtKMPedidos.Text = dtEntradaSaida.Rows(0).Item("KMSaida").ToString
                End If

                Dim vetObs As Array

                vetObs = Split(dtEntradaSaida.Rows(0).Item("Descricao").ToString, "|")

                If vetObs.Length > 0 Then
                    Me.txtDesc.Text = vetObs(0).ToString
                End If

                If vetObs.Length > 1 Then
                    Me.txtProbVeiculo.Text = vetObs(1).ToString
                End If
            End If
        End If
    End Sub

    Private Sub HistoricoCliente(ByVal parCodigo As String)
        Me.txtTotalGasto.ResetText()
        Me.txtNumCom.ResetText()
        Me.txtSalDev.ResetText()
        Me.txtUltVis.ResetText()
        Me.txtLimCli.ResetText()

        Dim dblGasto As Double
        Dim dtTotal As DataTable
        dtTotal = CarregarDataTable("Select sum(Total)as Total from Total where CodCli =" & parCodigo)
        If dtTotal.Rows.Count > 0 Then
            If dtTotal.Rows.Item(0).Item("Total").ToString = "" Then
                dblGasto = "0,00"
            Else
                dblGasto = dtTotal.Rows.Item(0).Item("Total").ToString
            End If

            Me.txtTotalGasto.Text = dblGasto.ToString("0.00")
        End If

        dtTotal = CarregarDataTable("Select CodOrdem from Total where CodCli  =" & parCodigo)

        Me.txtNumCom.Text = dtTotal.Rows.Count

        dtTotal = CarregarDataTable("Select Sum(ValorParcela) as Valor from ContaReceber where CodCli  =" & parCodigo & " and RecebidoOK ='False'")

        If dtTotal.Rows.Count > 0 Then
            If dtTotal.Rows.Item(0).Item("Valor").ToString = "" Then
                dblGasto = "0,00"
            Else
                dblGasto = dtTotal.Rows.Item(0).Item("Valor").ToString
            End If
        Else
            dblGasto = "0,00"
        End If

        Me.txtSalDev.Text = dblGasto.ToString("0.00")

        dtTotal = CarregarDataTable("Select datediff(day,min(Vencimento),getdate()) as Vencimento from ContaReceber where CodCli  =" & parCodigo & " and RecebidoOK ='False'")
        If dtTotal.Rows.Count > 0 Then
            If dtTotal.Rows.Item(0).Item("Vencimento").ToString <> "" Then
                Dim intDias As Integer = dtTotal.Rows.Item(0).Item("Vencimento").ToString
                If intDias > 0 Then
                    Me.txtDiasEmAtraso.Text = dtTotal.Rows.Item(0).Item("Vencimento").ToString
                Else
                    Me.txtDiasEmAtraso.Text = "0"
                End If

            Else
                Me.txtDiasEmAtraso.Text = "0"
            End If
        End If

        If Me.txtLimiteCliente.Text.Trim <> "" Then
            Me.txtLimCli.Text = (CDbl(Me.txtLimiteCliente.Text) + CDbl(Me.txtSalDev.Text)).ToString("0.00")
        End If

        Me.lblTotalGasto.Visible = True
        Me.txtTotalGasto.Visible = True

        Dim dt As DataTable = CarregarDataTable("Select Top 1 Data from Total where CodCli =" & parCodigo & " order by Data desc")
        If dt.Rows.Count > 0 Then
            Dim vet As Array = Split(dt.Rows.Item(0).ItemArray(0).ToString, " ")
            Me.txtUltVis.Text = vet(0)
        Else
            Me.txtUltVis.ResetText()
        End If
    End Sub

    Private Sub btnRelVendas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelVendas.Click
        If Me.txtCli.Text = "" Or Me.txtCli.Text = "CONSUMIDOR" Then MsgBox("Selecione o cliente!", MsgBoxStyle.Information) : Exit Sub
        CodigoDoCliente = intCodCli
        NomeDoCliente = Me.txtCli.Text
        Dim rel As New frmConPedido
        rel.Tag = "CLIENTE"
        rel.Show()
    End Sub

    Private Sub btnConsumo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsumo.Click
        If Me.txtCli.Text = "" Or Me.txtCli.Text = "CONSUMIDOR" Then MsgBox("Selecione o cliente!", MsgBoxStyle.Information) : Exit Sub
        CodigoDoCliente = intCodCli
        NomeDoCliente = Me.txtCli.Text
        Dim rel As New frmRelConsumo
        rel.Tag = "CLIENTE"
        rel.Show()
    End Sub


    Private Sub chkCusto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCusto.CheckedChanged
        Me.txtCusto.ResetText()
        Select Case Me.chkCusto.Checked
            Case True
                If Nivel = "USUÁRIO" Then
                    MsgBox("Para habilitar o campo Custo R$, digite a senha de um usuário com nível de ADMINISTRADOR!", MsgBoxStyle.Information)
                    Dim frm As New frmSenhaExcluir
                    frm.Tag = "DESCONTO"
                    frm.ShowDialog()
                    If bolSenhaOK = False Then
                        Me.chkCusto.Checked = False
                        Exit Sub
                    End If
                End If
                If Nivel <> "USUÁRIO" Then
                    Me.txtCusto.Text = dblValorDeCusto.ToString("0.00")
                End If
                Me.txtCusto.Visible = True
                Me.lblCusto.Visible = True


            Case False
                Me.txtCusto.Visible = False
                Me.lblCusto.Visible = False
        End Select
    End Sub

    Private Sub txtSeguradora_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        If Me.Tag = "CONSULTA" Or Me.Tag = "FATURA" Then Exit Sub
        AbreSeguradora()
    End Sub

    Private Sub AbreSeguradora()
        Seguradora = ""
        'frmSeguradora.ShowDialog()
        'If Seguradora <> Nothing Then
        '    Me.txtSeguradora.Text = Seguradora
        'End If
        Dim frm As New frmGrupo
        frm.Tag = "SEGURADORA"
        frm.ShowDialog()

        Me.txtSeguradora.Text = Seguradora
    End Sub

    Private Sub XtraTabControl3_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl3.SelectedPageChanged
        Me.txtEntPedidos.ResetText()
        Me.txtSaiPedidos.ResetText()
        Me.txtKMPedidos.ResetText()
        Select Case Me.XtraTabControl3.SelectedTabPageIndex
            Case 0
                If Me.Tag <> "FATURA" Then
                    Me.txtDesconto.Visible = True
                    Me.lblDesc.Visible = True
                    Me.lblValDesc.Visible = True
                    Me.lblPor.Visible = True
                    Me.txtValDesc.Visible = True

                    PanelControl5.Visible = True
                    Me.lblValorFrete.Visible = True
                    Me.txtValorFrete.Visible = True
                    'Me.rdbT.Visible = True
                    'Me.rdbP.Visible = True
                    'Me.rdbS.Visible = True
                End If

                Me.txtDesc.Text = strObsTemp
                Me.txtProbVeiculo.Text = strDefeiTemp

                Calcular(False)
                Me.pnlPedidos.Visible = False
                rdgDesc.Visible = True

            Case 1
                UltimoPedido()
                Me.txtDesconto.Visible = False
                Me.lblDesc.Visible = False
                Me.lblValDesc.Visible = False
                Me.lblPor.Visible = False
                Me.txtValDesc.Visible = False

                PanelControl5.Visible = False
                Me.lblValorFrete.Visible = False
                Me.txtValorFrete.Visible = False
                'Me.rdbT.Visible = False
                'Me.rdbP.Visible = False
                'Me.rdbS.Visible = False
                CalcularUltimoPedido()

                If Me.GridView1.RowCount = 0 Then
                    PictureEdit1.Visible = True
                Else
                    PictureEdit1.Visible = False
                End If
                If TipoNano = 5 Then
                    Me.pnlPedidos.Visible = True
                End If
                rdgDesc.Visible = False

            Case 2
                TodosPedidos()
                Me.txtDesconto.Visible = False
                Me.lblDesc.Visible = False
                Me.lblValDesc.Visible = False
                Me.lblPor.Visible = False
                Me.txtValDesc.Visible = False

                PanelControl5.Visible = False
                Me.lblValorFrete.Visible = False
                Me.txtValorFrete.Visible = False
                'Me.rdbT.Visible = False
                'Me.rdbP.Visible = False
                'Me.rdbS.Visible = False
                CalcularTodosPedidos()

                If Me.GridView2.RowCount = 0 Then
                    PictureEdit2.Visible = True
                Else
                    PictureEdit2.Visible = False
                End If
                If TipoNano = 5 Then
                    Me.pnlPedidos.Visible = True
                End If

                rdgDesc.Visible = False
        End Select
    End Sub

    Public Function converteimagem(ByVal Imagem As System.Drawing.Image) As Byte()
        Dim ms As New System.IO.MemoryStream()
        Imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return ms.ToArray()
    End Function

    Public Shared Function ResizeImage(ByVal InputImage As Image, ByVal parWidth As Integer, ByVal parHeight As Integer) As Image
        Return New Bitmap(InputImage, New Size(parWidth, parHeight))
    End Function

    Private Sub VisualizarAutomotivoImg(ByVal parComValor As Boolean, ByVal parEnviarEmail As Boolean)
        If Me.txtCodPed.Text = "" Then Exit Sub
        Dim rel As New relImpPedImg
        With rel

            If AutorizacaoPedido = False Then
                .lblAut.Visible = False
                .linha7.Visible = False
                .lblAssi.Visible = False
            Else
                .lblAssi.Text = Me.txtCli.Text.Trim
            End If

            If NomeEmpresa.Contains("MD NEGRO") Then
                .XrPanel1.BorderColor = Color.White
                .Margins.Top = 166
                .lblTitulo.Visible = False
                .lblFones.Visible = False
                .lblEndereco.Visible = False
                .picLogo.Visible = False
            End If

            .colAplicacao.Caption = CampoPedido
            If CampoPedido = "" Then
                .colAplicacao.Visible = False
                .colAplicacaoServ.Visible = False
            Else
                .colAplicacao.Visible = True
                .colAplicacaoServ.Visible = True
            End If

            .lblAtendente.Text = UserNano
            .Name = "Pedido N° " & Me.txtCodPed.Text.Trim
            .lblTitulo.Text = NomeEmpresa
            .lblFones.Text = TelefoneEmpresa
            .lblEndereco.Text = EnderecoEmpresa
            .Nome.Text = Me.txtCli.Text.Trim
            .Telefone.Text = txtTel.Text
            .Fax.Text = txtFax.Text
            .Email.Text = txtEmail.Text
            .Placa.Text = txtPlaca.Text
            .Modelo.Text = txtMod.Text
            .Cor.Text = txtCor.Text
            .Ano.Text = txtAno.Text
            .KM.Text = txtKm.Text
            .lblPrisma.Text = Me.txtMotor.Text.Trim

            Dim dtCar As DataTable = CarregarDataTable("Select Chassi, Motor, Combustivel from Carro where Placa = '" & Me.txtPlaca.Text.Trim & "'")
            If dtCar.Rows.Count > 0 Then
                .lblChassi.Text = dtCar.Rows.Item(0).Item(0).ToString.Trim
                .lblComb.Text = dtCar.Rows.Item(0).Item(2).ToString.Trim
            End If
            Dim dtConfig As DataTable = CarregarDataTable("SELECT DescricaoPedido FROM Config where Codigo = " & CodConfig)
            If dtConfig.Rows.Count > 0 Then
                If dtConfig.Rows.Item(0).Item("DescricaoPedido").ToString <> "" Then
                    .lblDescricaoPedido.Text = dtConfig.Rows.Item(0).Item("DescricaoPedido")
                End If
            End If

            'If MostraNomeFuncionario.Trim = "NÃO" Then
            '    .colFunc.Visible = False
            '    .colFuncServ.Visible = False
            'End If

            .Pecas.Text = Me.txtTotalprod.Text
            .Sevicos.Text = Me.txtTotalServ.Text

            Dim dblPec, dblSev, dblResut, dblValSemDesc, dblQtd, dblTotal As Double

            If EmiteNFE = True Then
                Dim I As Integer
                For I = 0 To grd1.RowCount - 1
                    If Me.grd1.GetRowCellValue(I, Me.colAutorizado) = True Then
                        dblValSemDesc = Me.grd1.GetRowCellDisplayText(I, Me.colUniSemDesc)
                        If Me.grd1.GetRowCellDisplayText(I, Me.colDesconto) <> "" Then
                            Dim dblPorDesc As Double = Me.grd1.GetRowCellDisplayText(I, Me.colDesconto)
                            If dblPorDesc > 0 Then
                                dblValSemDesc = Me.grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                            End If
                        End If
                        If Me.grd1.GetRowCellDisplayText(I, Me.colUM) = "HR" Then
                            If Me.grd1.GetRowCellDisplayText(I, Me.colQtd).Contains(":") = True Then
                                Dim hora(1) As String
                                Dim strHora As String
                                hora = Me.grd1.GetRowCellDisplayText(I, Me.colQtd).Split(":"(0))
                                strHora = hora(1)

                                Dim ts As New TimeSpan(hora(0), hora(1), 0)

                                Dim dbl As Double
                                dbl = dblValSemDesc
                                dblResut = ts.TotalHours * dbl
                            Else
                                dblQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd).Replace(":", ",")
                                dblResut = dblQtd * dblValSemDesc
                            End If

                        Else
                            dblQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd).Replace(":", ",")
                            dblResut = dblQtd * dblValSemDesc
                        End If

                        'If grd1.GetRowCellDisplayText(I, Me.colTipoProduto) <> "CUSTO" Then
                        dblTotal += dblResut
                        'End If



                        If grd1.GetRowCellDisplayText(I, Me.colTipo) = "VENDA" Or grd1.GetRowCellDisplayText(I, Me.colTipo) = "" Then

                            dblPec += dblResut
                        End If
                        If grd1.GetRowCellDisplayText(I, Me.colTipo) = "SERVIÇO" Or grd1.GetRowCellDisplayText(I, Me.colTipo) = "TERCEIRO" Then

                            dblSev += dblResut
                        End If
                    End If


                Next

                .Pecas.Text = dblPec.ToString("0.00")
                .Sevicos.Text = dblSev.ToString("0.00")

            Else
                dblPec = Me.txtTotalprod.Text
                dblSev = Me.txtTotalServ.Text

                dblTotal = dblPec + dblSev

            End If

            .Total.Text = dblTotal.ToString("0.00")
            .subTotal.Text = txtTotal.Text

            Dim dtSta As DataTable = CarregarDataTable("Select Status from TotalConsig where CodOrdens ='" & Me.txtCodPed.Text.Trim & "' and CodConfig = " & CodConfig)
            Dim strStatus As String = "Pendente"
            If dtSta.Rows.Count > 0 Then
                strStatus = dtSta.Rows.Item(0).Item("Status").ToString
            End If

            Select Case strStatus
                Case "Orçamento", ""
                    .lblPedido.Text = "Orçamento Nº: " & Me.txtCodPed.Text.Trim

                Case "Pendente"
                    .lblPedido.Text = "Orçamento Nº: " & Me.txtCodPed.Text.Trim

                Case "Faturado"
                    .lblPedido.Text = "O.S. Nº: " & Me.txtCodPed.Text.Trim

            End Select

            If NomeEmpresa.Contains("DAKAR") = True Then
                .lblPedido.Text = "Ordem de Serviço Nº: " & Me.txtCodPed.Text.Trim
            End If

            If NomeEmpresa.Trim.Contains("PINHO") Then
                .lblNivComb.Text = "Vendedor:"


            End If

            If Me.txtProbVeiculo.Text <> "" Then
                .lblDefeitos.Text = Me.txtProbVeiculo.Text
            Else
                .GroupFooter3.Visible = False
            End If

            If NomeEmpresa.Contains("MECÂNICA SÃO PAULO") Then
                .GroupFooter3.Visible = False
            End If
            'If BloquearObsPedido = False Then
            .lblDesc.Text = Me.txtDesc.Text
            'End If

            .lblData.Text = Me.dtData.Text
            .lblEntrada.Text = Me.dtRetirada.Text.Trim
            .lblSaida.Text = Me.dtEntrega.Text
            .lblNivCom.Text = Me.txtNivCom.Text.Trim
            .lblKMSaida.Text = Me.txtKMSaida.Text.Trim


            For I = 0 To grd1.RowCount - 1
                If Me.grd1.GetRowCellValue(I, Me.colAutorizado) = True Then

                    If grd1.GetRowCellDisplayText(I, Me.colTipo) = "SERVIÇO" Then
                        .tbServ.Rows.Add()
                        Dim dtProd As DataTable = CarregarDataTable("Select Garantia from Produto where Codigo =" & Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto))
                        If dtProd.Rows.Count > 0 Then
                            If dtProd.Rows.Item(0).ItemArray(0).ToString <> Nothing Then
                                .lblGar.Visible = True
                                .lblGarantias.Visible = True
                                .linha7.Visible = True
                                .lblGar.Text &= grd1.GetRowCellDisplayText(I, Me.colProduto) & " " & dtProd.Rows.Item(0).ItemArray(0).ToString & ", "
                            End If
                        End If

                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Código") = grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Qtde") = grd1.GetRowCellDisplayText(I, Me.colQtd)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Serviços") = grd1.GetRowCellDisplayText(I, Me.colProduto)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("VlUnit") = grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("vlTot") = grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("UMSER") = grd1.GetRowCellDisplayText(I, Me.colUM)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Aplicacao") = grd1.GetRowCellDisplayText(I, Me.colCampoPedido)
                        If grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) <> "" Then
                            Dim dtFuc As DataTable = CarregarDataTable("Select Nome from Funcionario where Codigo =" & grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) & " and CodConfig = " & CodConfig)
                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbServ.Rows.Item(Index).Item("FUNC") = grd1.GetRowCellDisplayText(I, Me.colGarantia)

                            'Else
                            If dtFuc.Rows.Count > 0 Then
                                .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("FUNC") = dtFuc.Rows.Item(0).Item(0).ToString
                            End If

                            'End If
                        Else
                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbServ.Rows.Item(Index).Item("FUNC") = grd1.GetRowCellDisplayText(I, Me.colGarantia)

                            'End If
                        End If
                    Else
                        .tbPed.Rows.Add()
                        Dim dtProd As DataTable = CarregarDataTable("Select Garantia from Produto where Codigo =" & Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto))

                        If dtProd.Rows.Count > 0 Then
                            If dtProd.Rows.Item(0).ItemArray(0).ToString <> Nothing Then
                                .lblGar.Visible = True
                                .lblGarantias.Visible = True
                                .linha7.Visible = True
                                .lblGar.Text &= grd1.GetRowCellDisplayText(I, Me.colProduto) & " " & dtProd.Rows.Item(0).ItemArray(0).ToString & ", "
                            End If
                        End If

                        
                        

                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("CodigoPeca") = grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Qtde") = grd1.GetRowCellDisplayText(I, Me.colQtd)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Descrição") = grd1.GetRowCellDisplayText(I, Me.colProduto)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("ValorUnitR") = grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Total") = grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("UM") = grd1.GetRowCellDisplayText(I, Me.colUM)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Aplicacao") = grd1.GetRowCellDisplayText(I, Me.colCampoPedido)
                        If grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) <> "" Then
                            Dim dtFuc As DataTable = CarregarDataTable("Select Nome from Funcionario where Codigo =" & grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) & " and CodConfig = " & CodConfig)

                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbPed.Rows.Item(Index).Item("Func") = grd1.GetRowCellDisplayText(I, Me.colGarantia)

                            'Else
                            If dtFuc.Rows.Count > 0 Then
                                .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Func") = dtFuc.Rows.Item(0).Item(0).ToString
                            End If

                            'End If
                        Else
                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbPed.Rows.Item(Index).Item("Modelo") = grd1.GetRowCellDisplayText(I, Me.colGarantia)
                            'End If
                        End If
                        dtProd = CarregarDataTable("Select Imagem1 from Produto where Codigo =" & Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto) & " And Imagem1 is not Null")
                        If dtProd.Rows.Count > 0 Then
                            If dtProd.Rows.Item(0).ItemArray(0).ToString <> Nothing Then
                                Dim Img As Byte() = CType(dtProd.Rows.Item(0).Item("Imagem1"), Byte())

                                Dim memorybits As New MemoryStream(Img)
                                Dim bitmap As New Bitmap(memorybits)
                                
                                bitmap = ResizeImage(bitmap, 60, 60)
                                Dim imagem As Byte() = converteimagem(bitmap)

                                .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Imagem") = imagem
                            End If
                        Else
                            Dim bitmap As New Bitmap(Me.PictureEdit3.Image)
                            bitmap = ResizeImage(bitmap, 60, 60)
                            Dim imagem As Byte() = converteimagem(bitmap)
                            .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Imagem") = imagem
                        End If

                    End If
                End If
            Next
            If Me.cboStatus.Text = "Faturado" Then
                Dim dtVenda As DataTable = CarregarDataTable("SELECT CodOrdem FROM Total where CodPedido = " & Me.txtCodPed.Text & " and CodConfig = " & CodConfig)
                If dtVenda.Rows.Count > 0 Then
                    Dim strCodOrdem As String = dtVenda.Rows.Item(0).Item("CodOrdem").ToString

                    Dim vet1 As Array = RetRec("Select Pagamento, FormaPagamento, Valor from Recebimento Where CodOrdem =" & strCodOrdem & " and CodConfig = " & CodConfig)

                    For I = 0 To vet1.Length - 1
                        If vet1(I) = Nothing Then Exit For
                        .lblRec.Text &= vet1(I) & "   "
                    Next

                    Dim dtRec As DataTable = CarregarDataTable("Select Pagamento, Vencimento, ValorParcela from ContaReceber where CodOrdem =" & strCodOrdem & " and CodConfig =" & CodConfig)

                    If dtRec.Rows.Count > 0 Then

                        Dim dtVenc As Date
                        Dim dblPar As Double

                        .lblRec.Text &= " " & vbCrLf
                        .lblRec.Text &= " " & vbCrLf

                        Dim R As Integer

                        For R = 0 To dtRec.Rows.Count - 1

                            If R = 0 Then
                                .lblRec.Text &= dtRec.Rows.Item(R).Item("Pagamento").ToString & vbCrLf
                            End If

                            dtVenc = dtRec.Rows.Item(R).Item("Vencimento").ToString
                            dblPar = dtRec.Rows.Item(R).Item("ValorParcela").ToString
                            .lblRec.Text &= dtVenc & "   R$ " & dblPar.ToString("0.00") & vbCrLf

                        Next
                    End If


                    Dim dblJaRec, dblResTroco As Double
                    dblJaRec = Somar("Select sum(Valor) from Recebimento Where CodOrdem =" & strCodOrdem & " and CodConfig = " & CodConfig)

                    .Recebido.Text = dblJaRec.ToString("0.00")

                    dblResTroco = dblJaRec - Me.txtTotal.Text.Trim

                    If dblResTroco > 0 Then
                        .Troco.Text = dblResTroco.ToString("0.00")
                    End If
                End If


            Else
                If parComValor = True Then
                    Dim dtEntrada As DataTable = CarregarDataTable("Select Pagamento, Valor From Recebimento Where CodigoPedido = " & Me.txtCodPed.Text & " And CodConfig=" & CodConfig)

                    If dtEntrada.Rows.Count > 0 Then
                        .lblRec.Text &= " ENTRADA" & vbCrLf
                        Dim strPag As String
                        Dim strValor As String
                        Dim dblValor As Double
                        For I As Integer = 0 To dtEntrada.Rows.Count - 1
                            strPag = dtEntrada.Rows.Item(I).Item("Pagamento").ToString
                            dblValor = dtEntrada.Rows.Item(I).Item("Valor").ToString
                            strValor = dblValor.ToString("####,##0.00")

                            .lblRec.Text &= strPag & "   R$ " & strValor & vbCrLf
                        Next

                    End If
                End If
            End If

            If parComValor = False Then
                rel.c1.Visible = False
                rel.c2.Visible = False
                rel.c3.Visible = False
                rel.c4.Visible = False
                rel.c5.Visible = False
                rel.c6.Visible = False
                rel.c7.Visible = False
                rel.lblPaga.Visible = False
                rel.lblRec.Visible = False
                rel.colValorTotal.Visible = False
                rel.colValorUnitario.Visible = False
                rel.colvlTot.Visible = False
                rel.colVlUnit.Visible = False
            End If
            Dim dblDesc As Double
            If Me.txtValDesc.Text <> "" Then
                dblDesc = Me.txtValDesc.Text.Trim
            End If
            .Desconto.Text = dblDesc.ToString("0.00")

            .ExportOptions.Email.Subject = "Pedido Nº " & Me.txtCodPed.Text.Trim
            .ExportOptions.Email.RecipientAddress = Me.txtEmail.Text.Trim


            If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                .colFunc.Caption = "Garantia"
                .colFunc.Visible = True
                .colFuncServ.Caption = "Garantia"
                .colFuncServ.Visible = True
            End If
            If NomeEmpresa.Trim.Contains("PORTO PEÇAS") Then
                .colLocacao.Visible = True

                .colLocacaoServ.Visible = True

                'If MostraNomeFuncionario.Trim = "NÃO" Then
                '    .colLocacao.VisibleIndex = 2
                '    .colLocacaoServ.VisibleIndex = 2
                'Else
                '    .colLocacao.VisibleIndex = 3
                '    .colLocacaoServ.VisibleIndex = 3
                'End If
            End If


            .picLogo.Image = LogoTipo

            If parEnviarEmail = False Then
                .ShowPreview()
            Else
                .ExportToPdf("C:\NANO\Pedidos\Pedido Nº " & Me.txtCodPed.Text.Trim & ".pdf")
            End If

        End With
    End Sub

    Private Sub VisualizarCommerceImg(ByVal parComValor As Boolean, ByVal parEnviarEmail As Boolean)
        If Me.txtCodPed.Text = "" Then Exit Sub
        Dim rel As New relImpPedImg2
        With rel

            If AutorizacaoPedido = False Then
                .lblAut.Visible = False
                .linha7.Visible = False
                .lblAssi.Visible = False
            Else
                .lblAssi.Text = Me.txtCli.Text.Trim
            End If

            If NomeEmpresa.Contains("MD NEGRO") Then
                .XrPanel1.BorderColor = Color.White
                .Margins.Top = 166
                .lblTitulo.Visible = False
                .lblFones.Visible = False
                .lblEndereco.Visible = False
                .picLogo.Visible = False
            End If

            .colAplicacao.Caption = CampoPedido
            If CampoPedido = "" Then
                .colAplicacao.Visible = False
                .colAplicacaoServ.Visible = False
            Else
                .colAplicacao.Visible = True
                .colAplicacaoServ.Visible = True
            End If

            .lblAtendente.Text = UserNano
            .Name = "Pedido N° " & Me.txtCodPed.Text.Trim
            .lblTitulo.Text = NomeEmpresa
            .lblFones.Text = TelefoneEmpresa
            .lblEndereco.Text = EnderecoEmpresa
            .Nome.Text = Me.txtCli.Text.Trim
            .Telefone.Text = txtTel.Text
            .Fax.Text = txtFax.Text
            .Email.Text = txtEmail.Text
            '.Placa.Text = txtPlaca.Text
            '.Modelo.Text = txtMod.Text
            '.Cor.Text = txtCor.Text
            '.Ano.Text = txtAno.Text
            '.KM.Text = txtKm.Text
            '.lblPrisma.Text = Me.txtMotor.Text.Trim

            Dim dtCar As DataTable = CarregarDataTable("Select Chassi, Motor, Combustivel from Carro where Placa = '" & Me.txtPlaca.Text.Trim & "'")
            If dtCar.Rows.Count > 0 Then
                '.lblChassi.Text = dtCar.Rows.Item(0).Item(0).ToString.Trim
                '.lblComb.Text = dtCar.Rows.Item(0).Item(2).ToString.Trim
            End If
            Dim dtConfig As DataTable = CarregarDataTable("SELECT DescricaoPedido FROM Config where Codigo = " & CodConfig)
            If dtConfig.Rows.Count > 0 Then
                If dtConfig.Rows.Item(0).Item("DescricaoPedido").ToString <> "" Then
                    .lblDescricaoPedido.Text = dtConfig.Rows.Item(0).Item("DescricaoPedido")
                End If
            End If

            'If MostraNomeFuncionario.Trim = "NÃO" Then
            '    .colFunc.Visible = False
            '    .colFuncServ.Visible = False
            'End If

            .Pecas.Text = Me.txtTotalprod.Text
            .Sevicos.Text = Me.txtTotalServ.Text

            Dim dblPec, dblSev, dblResut, dblValSemDesc, dblQtd, dblTotal As Double

            If EmiteNFE = True Then
                Dim I As Integer
                For I = 0 To grd1.RowCount - 1
                    If Me.grd1.GetRowCellValue(I, Me.colAutorizado) = True Then
                        dblValSemDesc = Me.grd1.GetRowCellDisplayText(I, Me.colUniSemDesc)
                        If Me.grd1.GetRowCellDisplayText(I, Me.colDesconto) <> "" Then
                            Dim dblPorDesc As Double = Me.grd1.GetRowCellDisplayText(I, Me.colDesconto)
                            If dblPorDesc > 0 Then
                                dblValSemDesc = Me.grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                            End If
                        End If
                        If Me.grd1.GetRowCellDisplayText(I, Me.colUM) = "HR" Then
                            If Me.grd1.GetRowCellDisplayText(I, Me.colQtd).Contains(":") = True Then
                                Dim hora(1) As String
                                Dim strHora As String
                                hora = Me.grd1.GetRowCellDisplayText(I, Me.colQtd).Split(":"(0))
                                strHora = hora(1)

                                Dim ts As New TimeSpan(hora(0), hora(1), 0)

                                Dim dbl As Double
                                dbl = dblValSemDesc
                                dblResut = ts.TotalHours * dbl
                            Else
                                dblQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd).Replace(":", ",")
                                dblResut = dblQtd * dblValSemDesc
                            End If
                     
                        Else
                            dblQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd).Replace(":", ",")
                            dblResut = dblQtd * dblValSemDesc
                        End If

                        'If grd1.GetRowCellDisplayText(I, Me.colTipoProduto) <> "CUSTO" Then
                        dblTotal += dblResut
                        'End If



                        If grd1.GetRowCellDisplayText(I, Me.colTipo) = "VENDA" Or grd1.GetRowCellDisplayText(I, Me.colTipo) = "" Then

                            dblPec += dblResut
                        End If
                        If grd1.GetRowCellDisplayText(I, Me.colTipo) = "SERVIÇO" Or grd1.GetRowCellDisplayText(I, Me.colTipo) = "TERCEIRO" Then

                            dblSev += dblResut
                        End If
                    End If


                Next

                .Pecas.Text = dblPec.ToString("0.00")
                .Sevicos.Text = dblSev.ToString("0.00")

            Else
                dblPec = Me.txtTotalprod.Text
                dblSev = Me.txtTotalServ.Text

                dblTotal = dblPec + dblSev

            End If

            .Total.Text = dblTotal.ToString("0.00")
            .subTotal.Text = txtTotal.Text

            Dim dtSta As DataTable = CarregarDataTable("Select Status from TotalConsig where CodOrdens ='" & Me.txtCodPed.Text.Trim & "' and CodConfig = " & CodConfig)
            Dim strStatus As String = "Pendente"
            If dtSta.Rows.Count > 0 Then
                strStatus = dtSta.Rows.Item(0).Item("Status").ToString
            End If

            Select Case strStatus
                Case "Orçamento", ""
                    .lblPedido.Text = "Orçamento Nº: " & Me.txtCodPed.Text.Trim

                Case "Pendente"
                    .lblPedido.Text = "Orçamento Nº: " & Me.txtCodPed.Text.Trim

                Case "Faturado"
                    .lblPedido.Text = "O.S. Nº: " & Me.txtCodPed.Text.Trim

            End Select

            If NomeEmpresa.Contains("DAKAR") = True Then
                .lblPedido.Text = "Ordem de Serviço Nº: " & Me.txtCodPed.Text.Trim
            End If

            'If NomeEmpresa.Trim.Contains("PINHO") Then
            '    .lblNivComb.Text = "Vendedor:"
            'End If

            If Me.txtProbVeiculo.Text <> "" Then
                .lblDefeitos.Text = Me.txtProbVeiculo.Text
            Else
                .GroupFooter3.Visible = False
            End If

            If NomeEmpresa.Contains("MECÂNICA SÃO PAULO") Then
                .GroupFooter3.Visible = False
            End If
            'If BloquearObsPedido = False Then
            .lblDesc.Text = Me.txtDesc.Text
            'End If

            .lblData.Text = Me.dtData.Text
            '.lblEntrada.Text = Me.dtRetirada.Text.Trim
            '.lblSaida.Text = Me.dtEntrega.Text
            '.lblNivCom.Text = Me.txtNivCom.Text.Trim
            '.lblKMSaida.Text = Me.txtKMSaida.Text.Trim


            For I = 0 To grd1.RowCount - 1
                If Me.grd1.GetRowCellValue(I, Me.colAutorizado) = True Then

                    If grd1.GetRowCellDisplayText(I, Me.colTipo) = "SERVIÇO" Then
                        .tbServ.Rows.Add()
                        Dim dtProd As DataTable = CarregarDataTable("Select Garantia from Produto where Codigo =" & Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto))
                        If dtProd.Rows.Count > 0 Then
                            If dtProd.Rows.Item(0).ItemArray(0).ToString <> Nothing Then
                                .lblGar.Visible = True
                                .lblGarantias.Visible = True
                                .linha7.Visible = True
                                .lblGar.Text &= grd1.GetRowCellDisplayText(I, Me.colProduto) & " " & dtProd.Rows.Item(0).ItemArray(0).ToString & ", "
                            End If
                        End If

                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Código") = grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Qtde") = grd1.GetRowCellDisplayText(I, Me.colQtd)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Serviços") = grd1.GetRowCellDisplayText(I, Me.colProduto)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("VlUnit") = grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("vlTot") = grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("UMSER") = grd1.GetRowCellDisplayText(I, Me.colUM)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Aplicacao") = grd1.GetRowCellDisplayText(I, Me.colCampoPedido)
                        If grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) <> "" Then
                            Dim dtFuc As DataTable = CarregarDataTable("Select Nome from Funcionario where Codigo =" & grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) & " and CodConfig = " & CodConfig)
                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbServ.Rows.Item(Index).Item("FUNC") = grd1.GetRowCellDisplayText(I, Me.colGarantia)

                            'Else
                            If dtFuc.Rows.Count > 0 Then
                                .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("FUNC") = dtFuc.Rows.Item(0).Item(0).ToString
                            End If

                            'End If
                        Else
                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbServ.Rows.Item(Index).Item("FUNC") = grd1.GetRowCellDisplayText(I, Me.colGarantia)

                            'End If
                        End If
                    Else
                        .tbPed.Rows.Add()
                        Dim dtProd As DataTable = CarregarDataTable("Select Garantia from Produto where Codigo =" & Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto))

                        If dtProd.Rows.Count > 0 Then
                            If dtProd.Rows.Item(0).ItemArray(0).ToString <> Nothing Then
                                .lblGar.Visible = True
                                .lblGarantias.Visible = True
                                .linha7.Visible = True
                                .lblGar.Text &= grd1.GetRowCellDisplayText(I, Me.colProduto) & " " & dtProd.Rows.Item(0).ItemArray(0).ToString & ", "
                            End If
                        End If




                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("CodigoPeca") = grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Qtde") = grd1.GetRowCellDisplayText(I, Me.colQtd)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Descrição") = grd1.GetRowCellDisplayText(I, Me.colProduto)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("ValorUnitR") = grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Total") = grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("UM") = grd1.GetRowCellDisplayText(I, Me.colUM)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Aplicacao") = grd1.GetRowCellDisplayText(I, Me.colCampoPedido)
                        If grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) <> "" Then
                            Dim dtFuc As DataTable = CarregarDataTable("Select Nome from Funcionario where Codigo =" & grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) & " and CodConfig = " & CodConfig)

                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbPed.Rows.Item(Index).Item("Func") = grd1.GetRowCellDisplayText(I, Me.colGarantia)

                            'Else
                            If dtFuc.Rows.Count > 0 Then
                                .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Func") = dtFuc.Rows.Item(0).Item(0).ToString
                            End If

                            'End If
                        Else
                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbPed.Rows.Item(Index).Item("Modelo") = grd1.GetRowCellDisplayText(I, Me.colGarantia)
                            'End If
                        End If
                        dtProd = CarregarDataTable("Select Imagem1 from Produto where Codigo =" & Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto) & " And Imagem1 is not Null")
                        If dtProd.Rows.Count > 0 Then
                            If dtProd.Rows.Item(0).ItemArray(0).ToString <> Nothing Then
                                Dim Img As Byte() = CType(dtProd.Rows.Item(0).Item("Imagem1"), Byte())

                                Dim memorybits As New MemoryStream(Img)
                                Dim bitmap As New Bitmap(memorybits)

                                bitmap = ResizeImage(bitmap, 60, 60)
                                Dim imagem As Byte() = converteimagem(bitmap)

                                .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Imagem") = imagem
                            End If
                        Else
                            Dim bitmap As New Bitmap(Me.PictureEdit3.Image)
                            bitmap = ResizeImage(bitmap, 60, 60)
                            Dim imagem As Byte() = converteimagem(bitmap)
                            .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Imagem") = imagem
                        End If

                    End If
                End If
            Next
            If Me.cboStatus.Text = "Faturado" Then
                Dim dtVenda As DataTable = CarregarDataTable("SELECT CodOrdem FROM Total where CodPedido = " & Me.txtCodPed.Text & " and CodConfig = " & CodConfig)
                If dtVenda.Rows.Count > 0 Then
                    Dim strCodOrdem As String = dtVenda.Rows.Item(0).Item("CodOrdem").ToString

                    Dim vet1 As Array = RetRec("Select Pagamento, FormaPagamento, Valor from Recebimento Where CodOrdem =" & strCodOrdem & " and CodConfig = " & CodConfig)

                    For I = 0 To vet1.Length - 1
                        If vet1(I) = Nothing Then Exit For
                        .lblRec.Text &= vet1(I) & "   "
                    Next

                    Dim dtRec As DataTable = CarregarDataTable("Select Pagamento, Vencimento, ValorParcela from ContaReceber where CodOrdem =" & strCodOrdem & " and CodConfig =" & CodConfig)

                    If dtRec.Rows.Count > 0 Then

                        Dim dtVenc As Date
                        Dim dblPar As Double

                        .lblRec.Text &= " " & vbCrLf
                        .lblRec.Text &= " " & vbCrLf

                        Dim R As Integer

                        For R = 0 To dtRec.Rows.Count - 1

                            If R = 0 Then
                                .lblRec.Text &= dtRec.Rows.Item(R).Item("Pagamento").ToString & vbCrLf
                            End If

                            dtVenc = dtRec.Rows.Item(R).Item("Vencimento").ToString
                            dblPar = dtRec.Rows.Item(R).Item("ValorParcela").ToString
                            .lblRec.Text &= dtVenc & "   R$ " & dblPar.ToString("0.00") & vbCrLf

                        Next
                    End If


                    Dim dblJaRec, dblResTroco As Double
                    dblJaRec = Somar("Select sum(Valor) from Recebimento Where CodOrdem =" & strCodOrdem & " and CodConfig = " & CodConfig)

                    .Recebido.Text = dblJaRec.ToString("0.00")

                    dblResTroco = dblJaRec - Me.txtTotal.Text.Trim

                    If dblResTroco > 0 Then
                        .Troco.Text = dblResTroco.ToString("0.00")
                    End If
                End If


            Else
                If parComValor = True Then
                    Dim dtEntrada As DataTable = CarregarDataTable("Select Pagamento, Valor From Recebimento Where CodigoPedido = " & Me.txtCodPed.Text & " And CodConfig=" & CodConfig)

                    If dtEntrada.Rows.Count > 0 Then
                        .lblRec.Text &= " ENTRADA" & vbCrLf
                        Dim strPag As String
                        Dim strValor As String
                        Dim dblValor As Double
                        For I As Integer = 0 To dtEntrada.Rows.Count - 1
                            strPag = dtEntrada.Rows.Item(I).Item("Pagamento").ToString
                            dblValor = dtEntrada.Rows.Item(I).Item("Valor").ToString
                            strValor = dblValor.ToString("####,##0.00")

                            .lblRec.Text &= strPag & "   R$ " & strValor & vbCrLf
                        Next

                    End If
                End If
            End If

            If parComValor = False Then
                rel.c1.Visible = False
                rel.c2.Visible = False
                rel.c3.Visible = False
                rel.c4.Visible = False
                rel.c5.Visible = False
                rel.c6.Visible = False
                rel.c7.Visible = False
                rel.lblPaga.Visible = False
                rel.lblRec.Visible = False
                rel.colValorTotal.Visible = False
                rel.colValorUnitario.Visible = False
                rel.colvlTot.Visible = False
                rel.colVlUnit.Visible = False
            End If
            Dim dblDesc As Double
            If Me.txtValDesc.Text <> "" Then
                dblDesc = Me.txtValDesc.Text.Trim
            End If
            .Desconto.Text = dblDesc.ToString("0.00")

            .ExportOptions.Email.Subject = "Pedido Nº " & Me.txtCodPed.Text.Trim
            .ExportOptions.Email.RecipientAddress = Me.txtEmail.Text.Trim


            If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                .colFunc.Caption = "Garantia"
                .colFunc.Visible = True
                .colFuncServ.Caption = "Garantia"
                .colFuncServ.Visible = True
            End If
            If NomeEmpresa.Trim.Contains("PORTO PEÇAS") Then
                .colLocacao.Visible = True

                .colLocacaoServ.Visible = True

                'If MostraNomeFuncionario.Trim = "NÃO" Then
                '    .colLocacao.VisibleIndex = 2
                '    .colLocacaoServ.VisibleIndex = 2
                'Else
                '    .colLocacao.VisibleIndex = 3
                '    .colLocacaoServ.VisibleIndex = 3
                'End If
            End If


            .picLogo.Image = LogoTipo

            If parEnviarEmail = False Then
                .ShowPreview()
            Else
                .ExportToPdf("C:\NANO\Pedidos\Pedido Nº " & Me.txtCodPed.Text.Trim & ".pdf")
            End If

        End With
    End Sub


    Private Sub VisualizarAutomotivo(ByVal parComValor As Boolean, ByVal parEnviarEmail As Boolean)
        If Me.txtCodPed.Text = "" Then Exit Sub
        Dim rel As New relImpPedidos
        With rel

            If AutorizacaoPedido = False Then
                .lblAut.Visible = False
                .linha7.Visible = False
                .lblAssi.Visible = False
            Else
                .lblAssi.Text = Me.txtCli.Text.Trim
            End If

            If NomeEmpresa.Contains("MD NEGRO") Then
                .XrPanel1.BorderColor = Color.White
                .Margins.Top = 166
                .lblTitulo.Visible = False
                .lblFones.Visible = False
                .lblEndereco.Visible = False
                .picLogo.Visible = False
            End If

            .colCampoPedido.Caption = CampoPedido
            If CampoPedido = "" Then
                .colCampoPedido.Visible = False
            Else
                .colCampoPedido.Visible = True
            End If

            .lblAtendente.Text = UserNano
            .Name = "Pedido N° " & Me.txtCodPed.Text.Trim
            .lblTitulo.Text = NomeEmpresa
            .lblFones.Text = TelefoneEmpresa
            .lblEndereco.Text = EnderecoEmpresa
            .Nome.Text = Me.txtCli.Text.Trim
            .Telefone.Text = txtTel.Text
            .Fax.Text = txtFax.Text
            .Email.Text = txtEmail.Text
            .Placa.Text = txtPlaca.Text
            .Modelo.Text = txtMod.Text
            .Cor.Text = txtCor.Text
            .Ano.Text = txtAno.Text
            .KM.Text = txtKm.Text
            .lblPrisma.Text = Me.txtMotor.Text.Trim

            Dim dtCar As DataTable = CarregarDataTable("Select Chassi, Motor, Combustivel from Carro where Placa = '" & Me.txtPlaca.Text.Trim & "'")
            If dtCar.Rows.Count > 0 Then
                .lblChassi.Text = dtCar.Rows.Item(0).Item(0).ToString.Trim
                .lblComb.Text = dtCar.Rows.Item(0).Item(2).ToString.Trim
            End If
            Dim dtConfig As DataTable = CarregarDataTable("SELECT DescricaoPedido FROM Config where Codigo = " & CodConfig)
            If dtConfig.Rows.Count > 0 Then
                If dtConfig.Rows.Item(0).Item("DescricaoPedido").ToString <> "" Then
                    .lblDescricaoPedido.Text = dtConfig.Rows.Item(0).Item("DescricaoPedido")
                End If
            End If

            'If MostraNomeFuncionario.Trim = "NÃO" Then
            '    .colFunc.Visible = False
            '    .colFuncServ.Visible = False
            'End If

            .Pecas.Text = Me.txtTotalprod.Text
            .Sevicos.Text = Me.txtTotalServ.Text

            Dim dblPec, dblSev, dblResut, dblValSemDesc, dblQtd, dblTotal As Double

            If EmiteNFE = True Then
                Dim I As Integer
                For I = 0 To grd1.RowCount - 1
                    If Me.grd1.GetRowCellValue(I, Me.colAutorizado) = True Then
                        dblValSemDesc = Me.grd1.GetRowCellDisplayText(I, Me.colUniSemDesc)
                        If Me.grd1.GetRowCellDisplayText(I, Me.colDesconto) <> "" Then
                            Dim dblPorDesc As Double = Me.grd1.GetRowCellDisplayText(I, Me.colDesconto)
                            If dblPorDesc > 0 Then
                                dblValSemDesc = Me.grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                            End If
                        End If
                        If Me.grd1.GetRowCellDisplayText(I, Me.colUM) = "HR" Then
                            If Me.grd1.GetRowCellDisplayText(I, Me.colQtd).Contains(":") = True Then
                                Dim hora(1) As String
                                Dim strHora As String
                                hora = Me.grd1.GetRowCellDisplayText(I, Me.colQtd).Split(":"(0))
                                strHora = hora(1)

                                Dim ts As New TimeSpan(hora(0), hora(1), 0)

                                Dim dbl As Double
                                dbl = dblValSemDesc
                                dblResut = ts.TotalHours * dbl
                            Else
                                dblQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd).Replace(":", ",")
                                dblResut = dblQtd * dblValSemDesc
                            End If
                        Else
                            dblQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd).Replace(":", ",")
                            dblResut = dblQtd * dblValSemDesc
                        End If

                        'If grd1.GetRowCellDisplayText(I, Me.colTipoProduto) <> "CUSTO" Then
                        dblTotal += dblResut
                        'End If



                        If grd1.GetRowCellDisplayText(I, Me.colTipo) = "VENDA" Or grd1.GetRowCellDisplayText(I, Me.colTipo) = "" Then

                            dblPec += dblResut
                        End If
                        If grd1.GetRowCellDisplayText(I, Me.colTipo) = "SERVIÇO" Or grd1.GetRowCellDisplayText(I, Me.colTipo) = "TERCEIRO" Then

                            dblSev += dblResut
                        End If
                    End If


                Next

                .Pecas.Text = dblPec.ToString("0.00")
                .Sevicos.Text = dblSev.ToString("0.00")

            Else
                dblPec = Me.txtTotalprod.Text
                dblSev = Me.txtTotalServ.Text

                dblTotal = dblPec + dblSev

            End If

            .Total.Text = dblTotal.ToString("0.00")
            .subTotal.Text = txtTotal.Text

            Dim dtSta As DataTable = CarregarDataTable("Select Status from TotalConsig where CodOrdens ='" & Me.txtCodPed.Text.Trim & "' and CodConfig = " & CodConfig)
            Dim strStatus As String = "Pendente"
            If dtSta.Rows.Count > 0 Then
                strStatus = dtSta.Rows.Item(0).Item("Status").ToString
            End If


            Dim strNossoStatus As String = ""
            If Me.cboGrp.Text <> "" Then
                strNossoStatus = vbCrLf & Me.cboGrp.Text
            End If

            Select Case strStatus
                Case "Orçamento", ""
                    .lblPedido.Text = "Orçamento Nº: " & Me.txtCodPed.Text.Trim

                Case "Pendente"
                    .lblPedido.Text = "Orçamento Nº: " & Me.txtCodPed.Text.Trim

                Case "Faturado"

                    .lblPedido.Text = "O.S. Nº: " & Me.txtCodPed.Text.Trim

            End Select

            If NomeEmpresa.Contains("DAKAR") = True Then
                .lblPedido.Text = "Ordem de Serviço Nº: " & Me.txtCodPed.Text.Trim
            End If

            If NomeEmpresa.Trim.Contains("PINHO") Then
                .lblNivComb.Text = "Vendedor:"


            End If

            If Me.txtProbVeiculo.Text <> "" Then
                .lblDefeitos.Text = Me.txtProbVeiculo.Text
            Else
                .GroupFooter3.Visible = False
            End If

            If NomeEmpresa.Contains("MECÂNICA SÃO PAULO") Then
                .GroupFooter3.Visible = False
            End If
            'If BloquearObsPedido = False Then
            .lblDesc.Text = Me.txtDesc.Text
            'End If

            .lblData.Text = Me.dtData.Text
            .lblEntrada.Text = Me.dtRetirada.Text.Trim
            .lblSaida.Text = Me.dtEntrega.Text
            .lblNivCom.Text = Me.txtNivCom.Text.Trim
            .lblKMSaida.Text = Me.txtKMSaida.Text.Trim


            For I = 0 To grd1.RowCount - 1
                If Me.grd1.GetRowCellValue(I, Me.colAutorizado) = True Then

                    If grd1.GetRowCellDisplayText(I, Me.colTipo) = "SERVIÇO" Then
                        .tbServ.Rows.Add()
                        Dim dtProd As DataTable = CarregarDataTable("Select Garantia from Produto where Codigo =" & Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto))
                        If dtProd.Rows.Count > 0 Then
                            If dtProd.Rows.Item(0).ItemArray(0).ToString <> Nothing Then
                                .lblGar.Visible = True
                                .lblGarantias.Visible = True
                                .linha7.Visible = True
                                .lblGar.Text &= grd1.GetRowCellDisplayText(I, Me.colProduto) & " " & dtProd.Rows.Item(0).ItemArray(0).ToString & ", "
                            End If
                        End If

                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Código") = grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Qtde") = grd1.GetRowCellDisplayText(I, Me.colQtd)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Serviços") = grd1.GetRowCellDisplayText(I, Me.colProduto)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("VlUnit") = grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("vlTot") = grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("UMSER") = grd1.GetRowCellDisplayText(I, Me.colUM)
                        If grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) <> "" Then
                            Dim dtFuc As DataTable = CarregarDataTable("Select Nome from Funcionario where Codigo =" & grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) & " and CodConfig = " & CodConfig)
                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbServ.Rows.Item(Index).Item("FUNC") = grd1.GetRowCellDisplayText(I, Me.colGarantia)

                            'Else
                            If dtFuc.Rows.Count > 0 Then
                                .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("FUNC") = dtFuc.Rows.Item(0).Item(0).ToString
                            End If

                            'End If
                        Else
                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbServ.Rows.Item(Index).Item("FUNC") = grd1.GetRowCellDisplayText(I, Me.colGarantia)

                            'End If
                        End If
                    Else
                        .tbPed.Rows.Add()
                        Dim dtProd As DataTable = CarregarDataTable("Select Garantia from Produto where Codigo =" & Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto))

                        If dtProd.Rows.Count > 0 Then
                            If dtProd.Rows.Item(0).ItemArray(0).ToString <> Nothing Then
                                .lblGar.Visible = True
                                .lblGarantias.Visible = True
                                .linha7.Visible = True
                                .lblGar.Text &= grd1.GetRowCellDisplayText(I, Me.colProduto) & " " & dtProd.Rows.Item(0).ItemArray(0).ToString & ", "
                            End If
                        End If

                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("CodigoPeca") = grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Qtde") = grd1.GetRowCellDisplayText(I, Me.colQtd)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Descrição") = grd1.GetRowCellDisplayText(I, Me.colProduto)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("ValorUnitR") = grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Total") = grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("UM") = grd1.GetRowCellDisplayText(I, Me.colUM)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("CampoPedido") = grd1.GetRowCellDisplayText(I, Me.colCampoPedido)
                        If grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) <> "" Then
                            Dim dtFuc As DataTable = CarregarDataTable("Select Nome from Funcionario where Codigo =" & grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) & " and CodConfig = " & CodConfig)

                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbPed.Rows.Item(Index).Item("Func") = grd1.GetRowCellDisplayText(I, Me.colGarantia)

                            'Else
                            If dtFuc.Rows.Count > 0 Then
                                .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Func") = dtFuc.Rows.Item(0).Item(0).ToString
                            End If

                            'End If
                        Else
                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbPed.Rows.Item(Index).Item("Modelo") = grd1.GetRowCellDisplayText(I, Me.colGarantia)
                            'End If
                        End If

                    End If

                End If
            Next
            If Me.cboStatus.Text = "Faturado" Then
                Dim dtVenda As DataTable = CarregarDataTable("SELECT CodOrdem FROM Total where CodPedido = " & Me.txtCodPed.Text & " and CodConfig = " & CodConfig)
                If dtVenda.Rows.Count > 0 Then
                    Dim strCodOrdem As String = dtVenda.Rows.Item(0).Item("CodOrdem").ToString

                    Dim vet1 As Array = RetRec("Select Pagamento, FormaPagamento, Valor from Recebimento Where CodOrdem =" & strCodOrdem & " and CodConfig = " & CodConfig)

                    For I = 0 To vet1.Length - 1
                        If vet1(I) = Nothing Then Exit For
                        .lblRec.Text &= vet1(I) & "   "
                    Next

                    Dim dtRec As DataTable = CarregarDataTable("Select Pagamento, Vencimento, ValorParcela from ContaReceber where CodOrdem =" & strCodOrdem & " and CodConfig =" & CodConfig)

                    If dtRec.Rows.Count > 0 Then

                        Dim dtVenc As Date
                        Dim dblPar As Double

                        .lblRec.Text &= " " & vbCrLf
                        .lblRec.Text &= " " & vbCrLf

                        Dim R As Integer

                        For R = 0 To dtRec.Rows.Count - 1

                            If R = 0 Then
                                .lblRec.Text &= dtRec.Rows.Item(R).Item("Pagamento").ToString & vbCrLf
                            End If

                            dtVenc = dtRec.Rows.Item(R).Item("Vencimento").ToString
                            dblPar = dtRec.Rows.Item(R).Item("ValorParcela").ToString
                            .lblRec.Text &= dtVenc & "   R$ " & dblPar.ToString("0.00") & vbCrLf

                        Next
                    End If


                    Dim dblJaRec, dblResTroco As Double
                    dblJaRec = Somar("Select sum(Valor) from Recebimento Where CodOrdem =" & strCodOrdem & " and CodConfig = " & CodConfig)

                    .Recebido.Text = dblJaRec.ToString("0.00")

                    dblResTroco = dblJaRec - Me.txtTotal.Text.Trim

                    If dblResTroco > 0 Then
                        .Troco.Text = dblResTroco.ToString("0.00")
                    End If
                End If


            Else
                If parComValor = True Then
                    Dim dtEntrada As DataTable = CarregarDataTable("Select Pagamento, Valor From Recebimento Where CodigoPedido = " & Me.txtCodPed.Text & " And CodConfig=" & CodConfig)

                    If dtEntrada.Rows.Count > 0 Then
                        .lblRec.Text &= " ENTRADA" & vbCrLf
                        Dim strPag As String
                        Dim strValor As String
                        Dim dblValor As Double
                        For I As Integer = 0 To dtEntrada.Rows.Count - 1
                            strPag = dtEntrada.Rows.Item(I).Item("Pagamento").ToString
                            dblValor = dtEntrada.Rows.Item(I).Item("Valor").ToString
                            strValor = dblValor.ToString("####,##0.00")

                            .lblRec.Text &= strPag & "   R$ " & strValor & vbCrLf
                        Next

                    End If
                End If
            End If

            If parComValor = False Then
                rel.c1.Visible = False
                rel.c2.Visible = False
                rel.c3.Visible = False
                rel.c4.Visible = False
                rel.c5.Visible = False
                rel.c6.Visible = False
                rel.c7.Visible = False
                rel.lblPaga.Visible = False
                rel.lblRec.Visible = False
                rel.colValorTotal.Visible = False
                rel.colValorUnitario.Visible = False
                rel.colvlTot.Visible = False
                rel.colVlUnit.Visible = False
            End If
            Dim dblDesc As Double
            If Me.txtValDesc.Text <> "" Then
                dblDesc = Me.txtValDesc.Text.Trim
            End If
            .Desconto.Text = dblDesc.ToString("0.00")

            .ExportOptions.Email.Subject = "Pedido Nº " & Me.txtCodPed.Text.Trim
            .ExportOptions.Email.RecipientAddress = Me.txtEmail.Text.Trim


            If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                .colFunc.Caption = "Garantia"
                .colFunc.Visible = True
                .colFuncServ.Caption = "Garantia"
                .colFuncServ.Visible = True
            End If
            If NomeEmpresa.Trim.Contains("PORTO PEÇAS") Then
                .colLocacao.Visible = True

                .colLocacaoServ.Visible = True

                'If MostraNomeFuncionario.Trim = "NÃO" Then
                '    .colLocacao.VisibleIndex = 2
                '    .colLocacaoServ.VisibleIndex = 2
                'Else
                '    .colLocacao.VisibleIndex = 3
                '    .colLocacaoServ.VisibleIndex = 3
                'End If
            End If


            .picLogo.Image = LogoTipo

            If parEnviarEmail = False Then
                .ShowPreview()
            Else
                .ExportToPdf("C:\NANO\Pedidos\Pedido Nº " & Me.txtCodPed.Text.Trim & ".pdf")
            End If

        End With
    End Sub
    Private Sub ImprimirPadrao(ByVal parComValor As Boolean, ByVal parEnviarEmail As Boolean)
        If Me.txtCodPed.Text = "" Then Exit Sub

        Dim rel As New relImpPedidos2

        With rel

            If AutorizacaoPedido = False Then
                .lblAut.Visible = False
                .linha7.Visible = False
                .lblAssi.Visible = False
            Else
                .lblAssi.Text = Me.txtCli.Text.Trim
            End If

            If NomeEmpresa.Contains("MD NEGRO") Then
                .Margins.Top = 166
                .lblTitulo.Visible = False
                .lblFones.Visible = False
                .lblEndereco.Visible = False
                .picLogo.Visible = False
            End If
            
            If CampoPedido <> "" Then
                Dim strAplic As String = CampoPedido
                If CampoPedido.Length > 9 Then
                    strAplic = CampoPedido.Substring(0, 8)
                End If
                .colCampoPedidoServ.Caption = strAplic
                .colCampoPedido.Caption = strAplic
            Else
                .colCampoPedidoServ.Visible = False
                .colCampoPedido.Visible = False
            End If

            If NomeEmpresa.Contains("MONDRIAN") = False Then
                .colFornecedor.Visible = False
                .colFornecedor2.Visible = False
            End If

            .Name = "Pedido N° " & Me.txtCodPed.Text.Trim
            .lblTitulo.Text = NomeEmpresa
            .lblFones.Text = TelefoneEmpresa
            .lblEndereco.Text = EnderecoEmpresa

            If TipoNano = 5 Then
                '.lblAtendente.Text = Me.txtUsu.Text
                '.colFunc.Visible = True
                '.colFuncionario.Visible = True
                '.colFunc.VisibleIndex = 2
                '.colFuncionario.VisibleIndex = 2
                .Nome.Text = Me.txtCli.Text.Trim
                .Telefone.Text = txtTel.Text
                .Fax.Text = txtFax.Text
                .Email.Text = txtEmail.Text

                .Placa.Text = txtPlaca.Text
                .Modelo.Text = txtMod.Text
                .Cor.Text = txtCor.Text
                .Ano.Text = txtAno.Text
                .KM.Text = txtKm.Text
                '.lblPrisma.Text = Me.txtPrisma.Text.Trim

                Dim dtCar As DataTable = CarregarDataTable("Select Chassi, Motor, Combustivel from Carro where Placa = '" & Me.txtPlaca.Text.Trim & "'")
                If dtCar.Rows.Count > 0 Then
                    .lblChassi.Text = dtCar.Rows.Item(0).Item(0).ToString.Trim
                    '.lblMotor.Text = dtCar.Rows.Item(0).Item(1).ToString.Trim
                    '.lblComb.Text = dtCar.Rows.Item(0).Item(2).ToString.Trim
                End If
                .GroupHeader2.Visible = False
            Else
            
                .lblLabelVendedor.Visible = True
                .lblVendedor.Visible = True
                .lblVendedor.Text = Me.lueFunc.Text
                .XrLabel21.Visible = False
                .lblDefeitos.Visible = False
                .GroupHeader1.Visible = False
                .lblNome.Text = Me.txtCli.Text.Trim
                .lblTelefone.Text = txtTel.Text
                .lblFax.Text = txtFax.Text
                .lblEmail.Text = txtEmail.Text

                Dim dtCli As DataTable = CarregarDataTable("SELECT Endereco, Numero, Bairro, Cidade, Cep, Estado, Complemento, ComplementoEntrega, EnderecoEntrega, NumeroEntrega, BairroEntrega, CidadeEntrega, CepEntrega, EstadoEntrega FROM Cliente where Codigo = " & intCodCli)
                If dtCli.Rows.Count > 0 Then
                    If dtCli.Rows.Item(0).Item("EnderecoEntrega").ToString = "" Then
                        .lblEnd.Text = dtCli.Rows.Item(0).Item("Endereco").ToString
                        .lblNum.Text = dtCli.Rows.Item(0).Item("Numero").ToString
                        .lblBairro.Text = dtCli.Rows.Item(0).Item("Bairro").ToString
                        .lblCidade.Text = dtCli.Rows.Item(0).Item("Cidade").ToString
                        .lblCep.Text = dtCli.Rows.Item(0).Item("Cep").ToString
                        .lblUF.Text = dtCli.Rows.Item(0).Item("Estado").ToString
                        .lblComplemento.Text = dtCli.Rows.Item(0).Item("Complemento").ToString
                    Else
                        .lblEnd.Text = dtCli.Rows.Item(0).Item("EnderecoEntrega").ToString
                        .lblNum.Text = dtCli.Rows.Item(0).Item("NumeroEntrega").ToString
                        .lblBairro.Text = dtCli.Rows.Item(0).Item("BairroEntrega").ToString
                        .lblCidade.Text = dtCli.Rows.Item(0).Item("CidadeEntrega").ToString
                        .lblCep.Text = dtCli.Rows.Item(0).Item("CepEntrega").ToString
                        .lblUF.Text = dtCli.Rows.Item(0).Item("EstadoEntrega").ToString
                        .lblComplemento.Text = dtCli.Rows.Item(0).Item("ComplementoEntrega").ToString
                    End If
                End If
            End If



            Dim dtConfig As DataTable = CarregarDataTable("SELECT DescricaoPedido FROM Config where Codigo = " & CodConfig)
            If dtConfig.Rows.Count > 0 Then
                If dtConfig.Rows.Item(0).Item("DescricaoPedido").ToString <> "" Then
                    .lblDescricaoPedido.Text = dtConfig.Rows.Item(0).Item("DescricaoPedido")
                End If
            End If



            'If MostraNomeFuncionario.Trim = "NÃO" Then
            '.colFunc.Visible = False
            '.colFuncServ.Visible = False
            'End If

            .Pecas.Text = Me.txtTotalprod.Text
            .Sevicos.Text = Me.txtTotalServ.Text

            Dim dblPec, dblSev, dblResut, dblValSemDesc, dblQtd, dblTotal As Double

            Dim dblValorSemDesconto As Double = 0
            If EmiteNFE = True Then
                Dim I As Integer
                For I = 0 To grd1.RowCount - 1
                    If Me.grd1.GetRowCellValue(I, Me.colAutorizado) = True Then
                        dblValSemDesc = Me.grd1.GetRowCellDisplayText(I, Me.colUniSemDesc)
                        If Me.grd1.GetRowCellDisplayText(I, Me.colDesconto) <> "" Then
                            Dim dblPorDesc As Double = Me.grd1.GetRowCellDisplayText(I, Me.colDesconto)
                            If dblPorDesc > 0 Or dblPorDesc < 0 Then
                                dblValSemDesc = Me.grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                            End If
                        End If
                        If Me.grd1.GetRowCellDisplayText(I, Me.colUM) = "HR" Then
                            If Me.grd1.GetRowCellDisplayText(I, Me.colQtd).Contains(":") = True Then
                                Dim hora(1) As String
                                Dim strHora As String
                                hora = Me.grd1.GetRowCellDisplayText(I, Me.colQtd).Split(":"(0))
                                strHora = hora(1)

                                Dim ts As New TimeSpan(hora(0), hora(1), 0)

                                Dim dbl As Double
                                dbl = dblValSemDesc
                                dblResut = ts.TotalHours * dbl
                            Else
                                dblQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd).Replace(":", ",")
                                dblResut = dblQtd * dblValSemDesc
                            End If
                            
                        Else
                            dblQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd).Replace(":", ",")
                            dblResut = dblQtd * dblValSemDesc
                        End If
                        dblResut = dblResut.ToString("0.00")

                        'If grd1.GetRowCellDisplayText(I, Me.colTipoProduto) <> "CUSTO" Then
                        dblTotal += dblResut
                        'End If
                        dblValorSemDesconto += Me.grd1.GetRowCellDisplayText(I, Me.colUniSemDesc)

                        If grd1.GetRowCellDisplayText(I, Me.colTipo) = "SERVIÇO" Then

                            dblSev += dblResut
                        Else
                            dblPec += dblResut
                        End If
                    End If


                Next

                .Pecas.Text = dblPec.ToString("0.00")
                .Sevicos.Text = dblSev.ToString("0.00")

            Else
                dblPec = Me.txtTotalprod.Text
                dblSev = Me.txtTotalServ.Text

                dblTotal = dblPec + dblSev

            End If


            Dim dblDesc As Double
            If Me.txtValDesc.Text <> "" Then
                dblDesc = Me.txtValDesc.Text.Trim
            End If
            .Desconto.Text = dblDesc.ToString("0.00")
            If TipoDesconto = "ITENS" Then
                If EmiteNFE = True Then
                    Dim dblResulTotal As Double = dblTotal + dblDesc
                    If Me.rdgDesc.SelectedIndex = 1 Then

                        dblResulTotal = dblTotal - dblDesc

                    End If

                    .Total.Text = dblResulTotal.ToString("0.00")

                Else
                    .Total.Text = dblTotal.ToString("0.00")

                End If
            Else
                .Total.Text = dblTotal.ToString("0.00")

            End If
            

            Dim dblSubTotal As Double = Me.txtTotal.Text

            If Me.txtValorFrete.Text <> "" Then
                Dim dblValFrete As Double = Me.txtValorFrete.Text
                If dblValFrete > 0 Then
                    .XrTable1.Visible = True

                    .c5.Location = New System.Drawing.Point(617, 76)
                    .c7.Location = New System.Drawing.Point(617, 93)
                    .c6.Location = New System.Drawing.Point(617, 110)
                    .XrTable1.Location = New System.Drawing.Point(617, 59)

                    '.c5.Location = New System.Drawing.Point(958, 76)
                    '.c7.Location = New System.Drawing.Point(958, 93)
                    '.c6.Location = New System.Drawing.Point(958, 110)
                    '.XrTable1.Location = New System.Drawing.Point(958, 59)


                    .lblFrete.Text = dblValFrete.ToString("0.00")
                End If
            End If


            .subTotal.Text = Me.txtTotal.Text



            Dim dtSta As DataTable = CarregarDataTable("Select Status from TotalConsig where CodOrdens = " & Me.txtCodPed.Text.Trim & " and CodConfig = " & CodConfig)
            Dim strStatus As String = "Pendente"
            If dtSta.Rows.Count > 0 Then
                strStatus = dtSta.Rows.Item(0).Item("Status").ToString
            End If


            Dim strNossoStatus As String = ""
            If Me.cboGrp.Text <> "" Then
                strNossoStatus = vbCrLf & Me.cboGrp.Text
            End If


            Select Case strStatus
                Case "Orçamento", ""
                    .lblPedido.Text = "Nº " & Me.txtCodPed.Text.Trim
                    .lblPed.Text = "Orçamento" & strNossoStatus
                    .colFornecedor.Visible = False
                    .colFornecedor2.Visible = False
                Case "Pendente"
                    .lblPedido.Text = "Nº " & Me.txtCodPed.Text.Trim
                    .lblPed.Text = "Pedido - Pendente" & strNossoStatus

                Case "Faturado"
                    .lblPedido.Text = "Nº " & Me.txtCodPed.Text.Trim
                    If TipoNano = 2 Or TipoNano = 5 Then
                        .lblPed.Text = "O.S." & strNossoStatus
                    Else
                        .lblPed.Text = "Pedido - Faturado" & strNossoStatus
                    End If

            End Select

            If NomeEmpresa.Contains("DAKAR") = True Then
                .lblPedido.Text = Me.txtCodPed.Text.Trim
                .lblPed.Text = "Ordem de Serviço Nº"
            End If



            'If NomeEmpresa.Trim.Contains("PINHO") Then
            '    .lblNivComb.Text = "Vendedor:"


            'End If

            'If Me.txtProbVeiculo.Text <> "" Then
            .lblDefeitos.Text = Me.txtProbVeiculo.Text
            'Else
            '    .GroupFooter3.Visible = False
            'End If
            'If BloquearObsPedido = False Then
            .lblDesc.Text = Me.txtDesc.Text

            'End If

            .lblData.Text = Me.dtData.Text & " " & Format(Hour(My.Computer.Clock.LocalTime), "00") & ":" & Format(Minute(My.Computer.Clock.LocalTime), "00") & ":" & Format(Second(My.Computer.Clock.LocalTime), "00")
            If TipoNano = 5 Then
                .lblEntrada.Text = Me.dtRetirada.Text.Trim
                .lblSaida.Text = Me.dtEntrega.Text
            Else
                .lblEntrada2.Text = Me.dtRetirada.Text.Trim
                .lblSaida2.Text = Me.dtEntrega.Text
            End If

            '.lblNivCom.Text = Me.txtNivCom.Text.Trim
            .lblKMSaida.Text = Me.txtKMSaida.Text.Trim
            .lblAssi.Text = Me.txtCli.Text.Trim

            For I = 0 To grd1.RowCount - 1
                If Me.grd1.GetRowCellValue(I, Me.colAutorizado) = True Then

                    '(SELECT Top 1 Fornecedor.Fantasia FROM Fornecedor where Fornecedor.Nome = Produto.Fabricante) as
                    If grd1.GetRowCellDisplayText(I, Me.colTipo) = "SERVIÇO" Then
                        .tbServ.Rows.Add()
                        Dim dtProd As DataTable = CarregarDataTable("Select Garantia, Fabricante from Produto where Codigo =" & Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto))
                        If dtProd.Rows.Count > 0 Then
                            If dtProd.Rows.Item(0).ItemArray(0).ToString <> Nothing Then
                                .lblGar.Visible = True
                                .lblGarantias.Visible = True
                                .linha7.Visible = True
                                .lblGar.Text &= grd1.GetRowCellDisplayText(I, Me.colProduto) & " " & dtProd.Rows.Item(0).ItemArray(0).ToString & ", "
                            End If
                            If NomeEmpresa.Contains("MONDRIAN") = True Then
                                .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Fornecedor") = dtProd.Rows.Item(0).Item("Fabricante").ToString
                            End If
                        End If

                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Código") = grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Qtde") = grd1.GetRowCellDisplayText(I, Me.colQtd)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Serviços") = grd1.GetRowCellDisplayText(I, Me.colProduto)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("VlUnit") = grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("vlTot") = grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("UMSER") = grd1.GetRowCellDisplayText(I, Me.colUM)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("CampoPedido") = grd1.GetRowCellDisplayText(I, Me.colCampoPedido)
                        If grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) <> "" Then
                            Dim dtFuc As DataTable = CarregarDataTable("Select Nome from Funcionario where Codigo =" & grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) & " and CodConfig = " & CodConfig)
                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbServ.Rows.Item(Index).Item("FUNC") = grd1.GetRowCellDisplayText(I, Me.colGarantia)

                            'Else
                            If dtFuc.Rows.Count > 0 Then
                                .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("FUNC") = dtFuc.Rows.Item(0).Item(0).ToString
                            End If

                            'End If
                        Else
                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbServ.Rows.Item(Index).Item("FUNC") = grd1.GetRowCellDisplayText(I, Me.colGarantia)

                            'End If
                        End If
                    Else
                        .tbPed.Rows.Add()
                        Dim dtProd As DataTable = CarregarDataTable("Select Garantia, Fabricante from Produto where Codigo =" & Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto))

                        If dtProd.Rows.Count > 0 Then
                            If dtProd.Rows.Item(0).ItemArray(0).ToString <> Nothing Then
                                .lblGar.Visible = True
                                .lblGarantias.Visible = True
                                .linha7.Visible = True
                                .lblGar.Text &= grd1.GetRowCellDisplayText(I, Me.colProduto) & " " & dtProd.Rows.Item(0).ItemArray(0).ToString & ", "
                            End If
                            If NomeEmpresa.Contains("MONDRIAN") = True Then
                                .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Fornecedor") = dtProd.Rows.Item(0).Item("Fabricante").ToString
                            End If
                        End If

                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("CodigoPeca") = grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Qtde") = grd1.GetRowCellDisplayText(I, Me.colQtd)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Descrição") = grd1.GetRowCellDisplayText(I, Me.colProduto)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("ValorUnitR") = grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Total") = grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("UM") = grd1.GetRowCellDisplayText(I, Me.colUM)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("CampoPedido") = grd1.GetRowCellDisplayText(I, Me.colCampoPedido)
                        If grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) <> "" Then
                            Dim dtFuc As DataTable = CarregarDataTable("Select Nome from Funcionario where Codigo =" & grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) & " and CodConfig = " & CodConfig)

                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbPed.Rows.Item(Index).Item("Func") = grd1.GetRowCellDisplayText(I, Me.colGarantia)

                            'Else
                            If dtFuc.Rows.Count > 0 Then
                                .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Func") = dtFuc.Rows.Item(0).Item(0).ToString
                            End If

                            'End If
                        Else
                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbPed.Rows.Item(Index).Item("Modelo") = grd1.GetRowCellDisplayText(I, Me.colGarantia)
                            'End If
                        End If

                    End If
                End If
            Next

            If Me.cboStatus.Text = "Faturado" Then
                Dim dtVenda As DataTable = CarregarDataTable("SELECT CodOrdem FROM Total where CodPedido = " & Me.txtCodPed.Text & " and CodConfig = " & CodConfig)
                If dtVenda.Rows.Count > 0 Then
                    Dim strCodOrdem As String = dtVenda.Rows.Item(0).Item("CodOrdem").ToString

                    Dim vet1 As Array = RetRec("Select Pagamento, FormaPagamento, Valor from Recebimento Where CodOrdem =" & strCodOrdem & " and CodConfig = " & CodConfig)

                    For I = 0 To vet1.Length - 1
                        If vet1(I) = Nothing Then Exit For
                        .lblRec.Text &= vet1(I) & "   "
                    Next

                    Dim dtRec As DataTable = CarregarDataTable("Select Pagamento, Vencimento, ValorParcela from ContaReceber where CodOrdem =" & strCodOrdem & " and CodConfig =" & CodConfig)

                    If dtRec.Rows.Count > 0 Then

                        Dim dtVenc As Date
                        Dim dblPar As Double

                        .lblRec.Text &= " " & vbCrLf
                        .lblRec.Text &= " " & vbCrLf

                        Dim R As Integer

                        For R = 0 To dtRec.Rows.Count - 1

                            If R = 0 Then
                                .lblRec.Text &= dtRec.Rows.Item(R).Item("Pagamento").ToString & vbCrLf
                            End If

                            dtVenc = dtRec.Rows.Item(R).Item("Vencimento").ToString
                            dblPar = dtRec.Rows.Item(R).Item("ValorParcela").ToString
                            .lblRec.Text &= dtVenc & "   R$ " & dblPar.ToString("0.00") & vbCrLf

                        Next
                    End If


                    Dim dblJaRec, dblResTroco As Double
                    dblJaRec = Somar("Select sum(Valor) from Recebimento Where CodOrdem =" & strCodOrdem & " and CodConfig = " & CodConfig)

                    .Recebido.Text = dblJaRec.ToString("0.00")

                    dblResTroco = dblJaRec - Me.txtTotal.Text.Trim

                    If dblResTroco > 0 Then
                        .Troco.Text = dblResTroco.ToString("0.00")
                    End If
                End If
            Else

                If parComValor = True Then
                    Dim dtEntrada As DataTable = CarregarDataTable("Select Pagamento, Valor From Recebimento Where CodigoPedido = " & Me.txtCodPed.Text & " And CodConfig=" & CodConfig)
                    If dtEntrada.Rows.Count > 0 Then
                        .lblRec.Text &= " ENTRADA" & vbCrLf
                        Dim strPag As String
                        Dim strValor As String
                        Dim dblValor As Double
                        For I As Integer = 0 To dtEntrada.Rows.Count - 1
                            strPag = dtEntrada.Rows.Item(I).Item("Pagamento").ToString
                            dblValor = dtEntrada.Rows.Item(I).Item("Valor").ToString
                            strValor = dblValor.ToString("####,##0.00")

                            .lblRec.Text &= strPag & "   R$ " & strValor & vbCrLf
                        Next

                    End If
                End If



            End If


            .ExportOptions.Email.Subject = "Pedido Nº " & Me.txtCodPed.Text.Trim
            .ExportOptions.Email.RecipientAddress = Me.txtEmail.Text.Trim

            If parComValor = False Then
                rel.c1.Visible = False
                rel.c2.Visible = False
                rel.c3.Visible = False
                rel.c4.Visible = False
                rel.c5.Visible = False
                rel.c6.Visible = False
                rel.c7.Visible = False
                .XrTable1.Visible = False

                rel.lblRec.Visible = False
                rel.colValorTotal.Visible = False
                rel.colValorUnitario.Visible = False
                rel.colvlTot2.Visible = False
                rel.colVlUnit2.Visible = False
                'rel.XrLabel10.Text = "        Código                 Produto                                                                                                                                                                             Qtde"
                'rel.XrLabel20.Text = "        Código                 Serviço                                                                                                                                                                             Qtde"
                'rel.XrLabel47.Text = "        Código                 Produto                                                                                                                                                                             Qtde"

                'rel.XrLabel10.Text = "     Código            Produto                                                                                                            Qtde                      Vlr Unit. R$                 Vlr Total R$"
            End If
            If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                .colFunc.Caption = "Garantia"
                .colFunc.Visible = True
                .colFuncServ.Caption = "Garantia"
                .colFuncServ.Visible = True
            End If
            If NomeEmpresa.Trim.Contains("PORTO PEÇAS") Then
                .colLocacao.Visible = True

                .colLocacaoServ.Visible = True

                'If MostraNomeFuncionario.Trim = "NÃO" Then
                '    .colLocacao.VisibleIndex = 2
                '    .colLocacaoServ.VisibleIndex = 2
                'Else
                '    .colLocacao.VisibleIndex = 3
                '    .colLocacaoServ.VisibleIndex = 3
                'End If
            End If

            .picLogo.Image = LogoTipo
            '.CreateDocument()
            '.PrintingSystem.Document.AutoFitToPagesWidth = 1
            '.PrintingSystem.Document.ScaleFactor = 1

            If parEnviarEmail = False Then
                .ShowPreview()
            Else
                .ExportToPdf("C:\NANO\Pedidos\Pedido Nº " & Me.txtCodPed.Text.Trim & ".pdf")
            End If

        End With
    End Sub
    Private Sub ImprimirPadraoPaisagem(ByVal parComValor As Boolean, ByVal parEnviarEmail As Boolean)
        If Me.txtCodPed.Text = "" Then Exit Sub

        Dim rel As New relImpPedidos2Paisagem

        With rel

            If AutorizacaoPedido = False Then
                .lblAut.Visible = False
                .linha7.Visible = False
                .lblAssi.Visible = False
            Else
                .lblAssi.Text = Me.txtCli.Text.Trim
            End If

            If NomeEmpresa.Contains("MD NEGRO") Then
                .Margins.Top = 166
                .lblTitulo.Visible = False
                .lblFones.Visible = False
                .lblEndereco.Visible = False
                .picLogo.Visible = False
            End If

            If CampoPedido <> "" Then
                Dim strAplic As String = CampoPedido
                If CampoPedido.Length > 9 Then
                    strAplic = CampoPedido.Substring(0, 8)
                End If
                .colCampoPedidoServ.Caption = strAplic
                .colCampoPedido.Caption = strAplic
            Else
                .colCampoPedidoServ.Visible = False
                .colCampoPedido.Visible = False
            End If

            If NomeEmpresa.Contains("MONDRIAN") = False Then
                .colFornecedor.Visible = False
                .colFornecedor2.Visible = False
            End If
            .Name = "Pedido N° " & Me.txtCodPed.Text.Trim
            .lblTitulo.Text = NomeEmpresa
            .lblFones.Text = TelefoneEmpresa
            .lblEndereco.Text = EnderecoEmpresa
            .lblCPF.Text = Me.txtCPFCNPJ.Text
            If TipoNano = 5 Then
                '.lblAtendente.Text = Me.txtUsu.Text
                '.colFunc.Visible = True
                '.colFuncionario.Visible = True
                '.colFunc.VisibleIndex = 2
                '.colFuncionario.VisibleIndex = 2
                .Nome.Text = Me.txtCli.Text.Trim
                .Telefone.Text = txtTel.Text
                .Fax.Text = txtFax.Text
                .Email.Text = txtEmail.Text

                .Placa.Text = txtPlaca.Text
                .Modelo.Text = txtMod.Text
                .Cor.Text = txtCor.Text
                .Ano.Text = txtAno.Text
                .KM.Text = txtKm.Text
                '.lblPrisma.Text = Me.txtPrisma.Text.Trim

                Dim dtCar As DataTable = CarregarDataTable("Select Chassi, Motor, Combustivel from Carro where Placa = '" & Me.txtPlaca.Text.Trim & "'")
                If dtCar.Rows.Count > 0 Then
                    .lblChassi.Text = dtCar.Rows.Item(0).Item(0).ToString.Trim
                    '.lblMotor.Text = dtCar.Rows.Item(0).Item(1).ToString.Trim
                    '.lblComb.Text = dtCar.Rows.Item(0).Item(2).ToString.Trim
                End If
                .GroupHeader2.Visible = False
            Else
              
                .lblLabelVendedor.Visible = True
                .lblVendedor.Visible = True
                .lblVendedor.Text = Me.lueFunc.Text
                .XrLabel21.Visible = False
                .lblDefeitos.Visible = False
                .GroupHeader1.Visible = False
                .lblNome.Text = Me.txtCli.Text.Trim
                .lblTelefone.Text = txtTel.Text
                .lblFax.Text = txtFax.Text
                .lblEmail.Text = txtEmail.Text

                Dim dtCli As DataTable = CarregarDataTable("SELECT Endereco, Numero, Bairro, Cidade, Cep, Estado, Complemento, ComplementoEntrega, EnderecoEntrega, NumeroEntrega, BairroEntrega, CidadeEntrega, CepEntrega, EstadoEntrega FROM Cliente where Codigo = " & intCodCli)
                If dtCli.Rows.Count > 0 Then
                    If dtCli.Rows.Item(0).Item("EnderecoEntrega").ToString = "" Then
                        .lblEnd.Text = dtCli.Rows.Item(0).Item("Endereco").ToString
                        .lblNum.Text = dtCli.Rows.Item(0).Item("Numero").ToString
                        .lblBairro.Text = dtCli.Rows.Item(0).Item("Bairro").ToString
                        .lblCidade.Text = dtCli.Rows.Item(0).Item("Cidade").ToString
                        .lblCep.Text = dtCli.Rows.Item(0).Item("Cep").ToString
                        .lblUF.Text = dtCli.Rows.Item(0).Item("Estado").ToString
                        .lblComplemento.Text = dtCli.Rows.Item(0).Item("Complemento").ToString
                    Else
                        .lblEnd.Text = dtCli.Rows.Item(0).Item("EnderecoEntrega").ToString
                        .lblNum.Text = dtCli.Rows.Item(0).Item("NumeroEntrega").ToString
                        .lblBairro.Text = dtCli.Rows.Item(0).Item("BairroEntrega").ToString
                        .lblCidade.Text = dtCli.Rows.Item(0).Item("CidadeEntrega").ToString
                        .lblCep.Text = dtCli.Rows.Item(0).Item("CepEntrega").ToString
                        .lblUF.Text = dtCli.Rows.Item(0).Item("EstadoEntrega").ToString
                        .lblComplemento.Text = dtCli.Rows.Item(0).Item("ComplementoEntrega").ToString
                    End If
                End If
            End If



            Dim dtConfig As DataTable = CarregarDataTable("SELECT DescricaoPedido FROM Config where Codigo = " & CodConfig)
            If dtConfig.Rows.Count > 0 Then
                If dtConfig.Rows.Item(0).Item("DescricaoPedido").ToString <> "" Then
                    .lblDescricaoPedido.Text = dtConfig.Rows.Item(0).Item("DescricaoPedido")
                End If
            End If



            'If MostraNomeFuncionario.Trim = "NÃO" Then
            '.colFunc.Visible = False
            '.colFuncServ.Visible = False
            'End If

            .Pecas.Text = Me.txtTotalprod.Text
            .Sevicos.Text = Me.txtTotalServ.Text

            Dim dblPec, dblSev, dblResut, dblValSemDesc, dblQtd, dblTotal As Double


            If EmiteNFE = True Then
                Dim I As Integer
                For I = 0 To grd1.RowCount - 1
                    If Me.grd1.GetRowCellValue(I, Me.colAutorizado) = True Then
                        dblValSemDesc = Me.grd1.GetRowCellDisplayText(I, Me.colUniSemDesc)
                        If Me.grd1.GetRowCellDisplayText(I, Me.colDesconto) <> "" Then
                            Dim dblPorDesc As Double = Me.grd1.GetRowCellDisplayText(I, Me.colDesconto)
                            If dblPorDesc > 0 Or dblPorDesc < 0 Then
                                dblValSemDesc = Me.grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                            End If
                        End If
                        If Me.grd1.GetRowCellDisplayText(I, Me.colUM) = "HR" Then
                            If Me.grd1.GetRowCellDisplayText(I, Me.colQtd).Contains(":") = True Then
                                Dim hora(1) As String
                                Dim strHora As String
                                hora = Me.grd1.GetRowCellDisplayText(I, Me.colQtd).Split(":"(0))
                                strHora = hora(1)

                                Dim ts As New TimeSpan(hora(0), hora(1), 0)

                                Dim dbl As Double
                                dbl = dblValSemDesc
                                dblResut = ts.TotalHours * dbl
                            Else
                                dblQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd).Replace(":", ",")
                                dblResut = dblQtd * dblValSemDesc
                            End If
            
                        Else
                            dblQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd).Replace(":", ",")
                            dblResut = dblQtd * dblValSemDesc
                        End If
                        dblResut = dblResut.ToString("0.00")

                        'If grd1.GetRowCellDisplayText(I, Me.colTipoProduto) <> "CUSTO" Then
                        dblTotal += dblResut
                        'End If


                        If grd1.GetRowCellDisplayText(I, Me.colTipo) = "SERVIÇO" Then

                            dblSev += dblResut
                        Else
                            dblPec += dblResut
                        End If
                    End If


                Next

                .Pecas.Text = dblPec.ToString("0.00")
                .Sevicos.Text = dblSev.ToString("0.00")

            Else
                dblPec = Me.txtTotalprod.Text
                dblSev = Me.txtTotalServ.Text

                dblTotal = dblPec + dblSev

            End If

            Dim dblDesc As Double
            If Me.txtValDesc.Text <> "" Then
                dblDesc = Me.txtValDesc.Text.Trim
            End If
            .Desconto.Text = dblDesc.ToString("0.00")

            If TipoDesconto = "ITENS" Then
                If EmiteNFE = True Then
                    Dim dblResulTotal As Double = dblTotal + dblDesc
                    If Me.rdgDesc.SelectedIndex = 1 Then

                        dblResulTotal = dblTotal - dblDesc

                    End If

                    .Total.Text = dblResulTotal.ToString("0.00")

                Else
                    .Total.Text = dblTotal.ToString("0.00")

                End If
            Else
                .Total.Text = dblTotal.ToString("0.00")

            End If
           

            Dim dblSubTotal As Double = Me.txtTotal.Text

            If Me.txtValorFrete.Text <> "" Then
                Dim dblValFrete As Double = Me.txtValorFrete.Text
                If dblValFrete > 0 Then
                    .XrTable1.Visible = True

                    .c5.Location = New System.Drawing.Point(958, 76)
                    .c7.Location = New System.Drawing.Point(958, 93)
                    .c6.Location = New System.Drawing.Point(958, 110)
                    .XrTable1.Location = New System.Drawing.Point(958, 59)

                    .lblFrete.Text = dblValFrete.ToString("0.00")
                End If
            End If
            .subTotal.Text = Me.txtTotal.Text

            Dim dtSta As DataTable = CarregarDataTable("Select Status from TotalConsig where CodOrdens = " & Me.txtCodPed.Text.Trim & " and CodConfig = " & CodConfig)
            Dim strStatus As String = "Pendente"
            If dtSta.Rows.Count > 0 Then
                strStatus = dtSta.Rows.Item(0).Item("Status").ToString
            End If
            Dim strNossoStatus As String = ""
            If Me.cboGrp.Text <> "" Then
                strNossoStatus = vbCrLf & Me.cboGrp.Text
            End If


            Select Case strStatus
                Case "Orçamento", ""
                    .lblPedido.Text = "Nº " & Me.txtCodPed.Text.Trim
                    .lblPed.Text = "Orçamento" & strNossoStatus
                    .colFornecedor.Visible = False
                    .colFornecedor2.Visible = False
                Case "Pendente"
                    .lblPedido.Text = "Nº " & Me.txtCodPed.Text.Trim
                    .lblPed.Text = "Pedido - Pendente" & strNossoStatus

                Case "Faturado"
                    .lblPedido.Text = "Nº " & Me.txtCodPed.Text.Trim
                    If TipoNano = 2 Or TipoNano = 5 Then
                        .lblPed.Text = "O.S." & strNossoStatus
                    Else
                        .lblPed.Text = "Pedido - Faturado" & strNossoStatus
                    End If

            End Select

            If NomeEmpresa.Contains("DAKAR") = True Then
                .lblPedido.Text = Me.txtCodPed.Text.Trim
                .lblPed.Text = "Ordem de Serviço Nº"
            End If



            'If NomeEmpresa.Trim.Contains("PINHO") Then
            '    .lblNivComb.Text = "Vendedor:"


            'End If

            'If Me.txtProbVeiculo.Text <> "" Then
            .lblDefeitos.Text = Me.txtProbVeiculo.Text
            'Else
            '    .GroupFooter3.Visible = False
            'End If
            'If BloquearObsPedido = False Then
            .lblDesc.Text = Me.txtDesc.Text

            'End If

            .lblData.Text = Me.dtData.Text & " " & Format(Hour(My.Computer.Clock.LocalTime), "00") & ":" & Format(Minute(My.Computer.Clock.LocalTime), "00") & ":" & Format(Second(My.Computer.Clock.LocalTime), "00")
            If TipoNano = 5 Then
                .lblEntrada.Text = Me.dtRetirada.Text.Trim
                .lblSaida.Text = Me.dtEntrega.Text
            Else
                .lblEntrada2.Text = Me.dtRetirada.Text.Trim
                .lblSaida2.Text = Me.dtEntrega.Text
            End If

            '.lblNivCom.Text = Me.txtNivCom.Text.Trim
            .lblKMSaida.Text = Me.txtKMSaida.Text.Trim
            .lblAssi.Text = Me.txtCli.Text.Trim

            For I = 0 To grd1.RowCount - 1
                If Me.grd1.GetRowCellValue(I, Me.colAutorizado) = True Then


                    If grd1.GetRowCellDisplayText(I, Me.colTipo) = "SERVIÇO" Then
                        .tbServ.Rows.Add()
                        Dim dtProd As DataTable = CarregarDataTable("Select Garantia, Fabricante from Produto where Codigo =" & Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto))
                        If dtProd.Rows.Count > 0 Then
                            If dtProd.Rows.Item(0).ItemArray(0).ToString <> Nothing Then
                                .lblGar.Visible = True
                                .lblGarantias.Visible = True
                                .linha7.Visible = True
                                .lblGar.Text &= grd1.GetRowCellDisplayText(I, Me.colProduto) & " " & dtProd.Rows.Item(0).ItemArray(0).ToString & ", "
                            End If
                            If NomeEmpresa.Contains("MONDRIAN") = True Then
                                .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Fornecedor") = dtProd.Rows.Item(0).Item("Fabricante").ToString
                            End If
                        End If

                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Código") = grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Qtde") = grd1.GetRowCellDisplayText(I, Me.colQtd)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Serviços") = grd1.GetRowCellDisplayText(I, Me.colProduto)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("VlUnit") = grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("vlTot") = grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("UMSER") = grd1.GetRowCellDisplayText(I, Me.colUM)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("CampoPedido") = grd1.GetRowCellDisplayText(I, Me.colCampoPedido)
                        If grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) <> "" Then
                            Dim dtFuc As DataTable = CarregarDataTable("Select Nome from Funcionario where Codigo =" & grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) & " and CodConfig = " & CodConfig)
                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbServ.Rows.Item(Index).Item("FUNC") = grd1.GetRowCellDisplayText(I, Me.colGarantia)

                            'Else
                            If dtFuc.Rows.Count > 0 Then
                                .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("FUNC") = dtFuc.Rows.Item(0).Item(0).ToString
                            End If

                            'End If
                        Else
                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbServ.Rows.Item(Index).Item("FUNC") = grd1.GetRowCellDisplayText(I, Me.colGarantia)

                            'End If
                        End If
                    Else
                        .tbPed.Rows.Add()
                        Dim dtProd As DataTable = CarregarDataTable("Select Garantia, Fabricante from Produto where Codigo =" & Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto))

                        If dtProd.Rows.Count > 0 Then
                            If dtProd.Rows.Item(0).ItemArray(0).ToString <> Nothing Then
                                .lblGar.Visible = True
                                .lblGarantias.Visible = True
                                .linha7.Visible = True
                                .lblGar.Text &= grd1.GetRowCellDisplayText(I, Me.colProduto) & " " & dtProd.Rows.Item(0).ItemArray(0).ToString & ", "
                            End If
                            If NomeEmpresa.Contains("MONDRIAN") = True Then
                                .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Fornecedor") = dtProd.Rows.Item(0).Item("Fabricante").ToString
                            End If
                        End If

                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("CodigoPeca") = grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Qtde") = grd1.GetRowCellDisplayText(I, Me.colQtd)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Descrição") = grd1.GetRowCellDisplayText(I, Me.colProduto)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("ValorUnitR") = grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Total") = grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("UM") = grd1.GetRowCellDisplayText(I, Me.colUM)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("CampoPedido") = grd1.GetRowCellDisplayText(I, Me.colCampoPedido)
                        If grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) <> "" Then
                            Dim dtFuc As DataTable = CarregarDataTable("Select Nome from Funcionario where Codigo =" & grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) & " and CodConfig = " & CodConfig)

                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbPed.Rows.Item(Index).Item("Func") = grd1.GetRowCellDisplayText(I, Me.colGarantia)

                            'Else
                            If dtFuc.Rows.Count > 0 Then
                                .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Func") = dtFuc.Rows.Item(0).Item(0).ToString
                            End If

                            'End If
                        Else
                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbPed.Rows.Item(Index).Item("Modelo") = grd1.GetRowCellDisplayText(I, Me.colGarantia)
                            'End If
                        End If

                    End If
                End If
            Next

            If Me.cboStatus.Text = "Faturado" Then
                Dim dtVenda As DataTable = CarregarDataTable("SELECT CodOrdem FROM Total where CodPedido = " & Me.txtCodPed.Text & " and CodConfig = " & CodConfig)
                If dtVenda.Rows.Count > 0 Then
                    Dim strCodOrdem As String = dtVenda.Rows.Item(0).Item("CodOrdem").ToString

                    Dim vet1 As Array = RetRec("Select Pagamento, FormaPagamento, Valor from Recebimento Where CodOrdem =" & strCodOrdem & " and CodConfig = " & CodConfig)

                    For I = 0 To vet1.Length - 1
                        If vet1(I) = Nothing Then Exit For
                        .lblRec.Text &= vet1(I) & "   "
                    Next

                    Dim dtRec As DataTable = CarregarDataTable("Select Pagamento, Vencimento, ValorParcela from ContaReceber where CodOrdem =" & strCodOrdem & " and CodConfig =" & CodConfig)

                    If dtRec.Rows.Count > 0 Then

                        Dim dtVenc As Date
                        Dim dblPar As Double

                        .lblRec.Text &= " " & vbCrLf
                        .lblRec.Text &= " " & vbCrLf

                        Dim R As Integer

                        For R = 0 To dtRec.Rows.Count - 1

                            If R = 0 Then
                                .lblRec.Text &= dtRec.Rows.Item(R).Item("Pagamento").ToString & vbCrLf
                            End If

                            dtVenc = dtRec.Rows.Item(R).Item("Vencimento").ToString
                            dblPar = dtRec.Rows.Item(R).Item("ValorParcela").ToString
                            .lblRec.Text &= dtVenc & "   R$ " & dblPar.ToString("0.00") & vbCrLf

                        Next
                    End If


                    Dim dblJaRec, dblResTroco As Double
                    dblJaRec = Somar("Select sum(Valor) from Recebimento Where CodOrdem =" & strCodOrdem & " and CodConfig = " & CodConfig)

                    .Recebido.Text = dblJaRec.ToString("0.00")

                    dblResTroco = dblJaRec - Me.txtTotal.Text.Trim

                    If dblResTroco > 0 Then
                        .Troco.Text = dblResTroco.ToString("0.00")
                    End If
                End If
            Else

                If parComValor = True Then
                    Dim dtEntrada As DataTable = CarregarDataTable("Select Pagamento, Valor From Recebimento Where CodigoPedido = " & Me.txtCodPed.Text & " And CodConfig=" & CodConfig)
                    If dtEntrada.Rows.Count > 0 Then
                        .lblRec.Text &= " ENTRADA" & vbCrLf
                        Dim strPag As String
                        Dim strValor As String
                        Dim dblValor As Double
                        For I As Integer = 0 To dtEntrada.Rows.Count - 1
                            strPag = dtEntrada.Rows.Item(I).Item("Pagamento").ToString
                            dblValor = dtEntrada.Rows.Item(I).Item("Valor").ToString
                            strValor = dblValor.ToString("####,##0.00")

                            .lblRec.Text &= strPag & "   R$ " & strValor & vbCrLf
                        Next

                    End If
                End If



            End If

            'Dim dblDesc As Double
            'If Me.txtValDesc.Text <> "" Then
            '    dblDesc = Me.txtValDesc.Text.Trim
            'End If
            '.Desconto.Text = dblDesc.ToString("0.00")

            .ExportOptions.Email.Subject = "Pedido Nº " & Me.txtCodPed.Text.Trim
            .ExportOptions.Email.RecipientAddress = Me.txtEmail.Text.Trim

            If parComValor = False Then
                rel.c1.Visible = False
                rel.c2.Visible = False
                rel.c3.Visible = False
                rel.c4.Visible = False
                rel.c5.Visible = False
                rel.c6.Visible = False
                rel.c7.Visible = False
                .XrTable1.Visible = False

                rel.lblRec.Visible = False
                rel.colValorTotal.Visible = False
                rel.colValorUnitario.Visible = False
                rel.colvlTot2.Visible = False
                rel.colVlUnit2.Visible = False
                'rel.XrLabel10.Text = "        Código                 Produto                                                                                                                                                                             Qtde"
                'rel.XrLabel20.Text = "        Código                 Serviço                                                                                                                                                                             Qtde"
                'rel.XrLabel47.Text = "        Código                 Produto                                                                                                                                                                             Qtde"

                'rel.XrLabel10.Text = "     Código            Produto                                                                                                            Qtde                      Vlr Unit. R$                 Vlr Total R$"
            End If
            If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                .colFunc.Caption = "Garantia"
                .colFunc.Visible = True
                .colFuncServ.Caption = "Garantia"
                .colFuncServ.Visible = True
            End If
            If NomeEmpresa.Trim.Contains("PORTO PEÇAS") Then
                .colLocacao.Visible = True

                .colLocacaoServ.Visible = True

                'If MostraNomeFuncionario.Trim = "NÃO" Then
                '    .colLocacao.VisibleIndex = 2
                '    .colLocacaoServ.VisibleIndex = 2
                'Else
                '    .colLocacao.VisibleIndex = 3
                '    .colLocacaoServ.VisibleIndex = 3
                'End If
            End If

            .picLogo.Image = LogoTipo
            '.CreateDocument()
            '.PrintingSystem.Document.AutoFitToPagesWidth = 1
            '.PrintingSystem.Document.ScaleFactor = 1

            If parEnviarEmail = False Then
                .ShowPreview()
            Else
                .ExportToPdf("C:\NANO\Pedidos\Pedido Nº " & Me.txtCodPed.Text.Trim & ".pdf")
            End If

        End With
    End Sub
    Private Sub VisualizarAutomotivoCompleto(ByVal parComValor As Boolean, ByVal parEnviarEmail As Boolean)
        If Me.txtCodPed.Text = "" Then Exit Sub
        Dim rel As New relOrcamento
        With rel

            If AutorizacaoPedido = False Then
                .lblAut.Visible = False
                .linha7.Visible = False
                .lblAssi.Visible = False
            Else
                .lblAssi.Text = Me.txtCli.Text.Trim
            End If


            If NomeEmpresa.Contains("MD NEGRO") Then
                .XrPanel1.BorderColor = Color.White
                .Margins.Top = 166
                .lblTitulo.Visible = False
                .lblFones.Visible = False
                .lblEndereco.Visible = False
                .picLogo.Visible = False
            End If

            .Name = "Pedido N° " & Me.txtCodPed.Text.Trim
            .lblTitulo.Text = NomeEmpresa
            .lblFones.Text = TelefoneEmpresa
            .lblEndereco.Text = EnderecoEmpresa
            .Nome.Text = Me.txtCli.Text.Trim
            .lblPedido.Text = Me.txtCodPed.Text.Trim

            .lblAtendente.Text = UserNano

            Dim dtConfig As DataTable = CarregarDataTable("SELECT DescricaoPedido FROM Config where Codigo = " & CodConfig)
            If dtConfig.Rows.Count > 0 Then
                If dtConfig.Rows.Item(0).Item("DescricaoPedido").ToString <> "" Then
                    .lblDescricaoPedido.Text = dtConfig.Rows.Item(0).Item("DescricaoPedido")
                End If
            End If

            Dim dtCli As DataTable = CarregarDataTable("SELECT CPF, RGIE, Endereco, Bairro, Numero, Cidade, Cep, " & _
            "convert(Varchar(10),Nascimento,103) as Nascimento, Complemento, Contato, Estado, EnderecoEntrega, " & _
            "NumeroEntrega, ComplementoEntrega, BairroEntrega, CepEntrega, CidadeEntrega, EstadoEntrega " & _
            "FROM Cliente where Codigo = " & intCodCli)

            If dtCli.Rows.Count > 0 Then
                .Endereco.Text = dtCli.Rows.Item(0).Item("Endereco").ToString
                .Num.Text = dtCli.Rows.Item(0).Item("Numero").ToString
                .IE.Text = dtCli.Rows.Item(0).Item("RGIE").ToString
                .Bairro.Text = dtCli.Rows.Item(0).Item("Bairro").ToString
                .Cep.Text = dtCli.Rows.Item(0).Item("Cep").ToString
                .Cidade.Text = dtCli.Rows.Item(0).Item("Cidade").ToString
                .Estado.Text = dtCli.Rows.Item(0).Item("Estado").ToString
                .CPF.Text = dtCli.Rows.Item(0).Item("CPF").ToString

                If dtCli.Rows.Item(0).Item("EnderecoEntrega").ToString <> "" Then
                    .XrRichText1.Text = "Endereço de Entrega:" & vbCrLf & dtCli.Rows.Item(0).Item("EnderecoEntrega").ToString & ", " & dtCli.Rows.Item(0).Item("NumeroEntrega").ToString & " - " & dtCli.Rows.Item(0).Item("BairroEntrega").ToString & " - " & dtCli.Rows.Item(0).Item("CidadeEntrega").ToString & ", " & dtCli.Rows.Item(0).Item("EstadoEntrega").ToString & " - CEP: " & dtCli.Rows.Item(0).Item("CepEntrega").ToString & " - " & dtCli.Rows.Item(0).Item("ComplementoEntrega").ToString
                Else
                    .XrRichText1.Visible = False
                End If
            End If
            .Telefone.Text = txtTel.Text
            .Fax.Text = txtFax.Text
            .Email.Text = Me.txtEmail.Text.Trim

            .Placa.Text = txtPlaca.Text
            .Modelo.Text = txtMod.Text
            .Cor.Text = txtCor.Text
            .Ano.Text = txtAno.Text
            .KM.Text = txtKm.Text

            .Pecas.Text = Me.txtTotalprod.Text
            .Sevicos.Text = Me.txtTotalServ.Text
            .lblPrisma.Text = Me.txtMotor.Text.Trim

            Dim dblPec, dblSev, dblResut As Double

            dblPec = Me.txtTotalprod.Text
            dblSev = Me.txtTotalServ.Text

            dblResut = dblPec + dblSev

            .Total.Text = dblResut.ToString("0.00")
            .subTotal.Text = txtTotal.Text
            If NomeEmpresa.Trim.Contains("PINHO") Then
                .lblNivComb.Text = "Vendedor:"
            End If

            If Me.txtProbVeiculo.Text <> "" Then
                .lblDefeitos.Text = Me.txtProbVeiculo.Text
            Else
                .GroupFooter3.Visible = False
            End If

            If NomeEmpresa.Contains("MECÂNICA SÃO PAULO") Then
                .GroupFooter3.Visible = False
            End If
            'If BloquearObsPedido = False Then
            .lblDesc.Text = Me.txtDesc.Text
            ' End If

            .lblData.Text = Me.dtData.Text
            .lblEntrada.Text = Me.dtRetirada.Text.Trim
            .lblSaida.Text = Me.dtEntrega.Text
            .lblNivCom.Text = Me.txtNivCom.Text.Trim
            .lblKMSaida.Text = Me.txtKMSaida.Text.Trim




            Dim dtCar As DataTable = CarregarDataTable("Select Chassi, Motor, Combustivel from Carro where Placa = '" & Me.txtPlaca.Text.Trim & "'")
            If dtCar.Rows.Count > 0 Then
                .lblChassi.Text = dtCar.Rows.Item(0).Item(0).ToString.Trim
                .lblMotor.Text = dtCar.Rows.Item(0).Item(1).ToString.Trim
                .lblComb.Text = dtCar.Rows.Item(0).Item(2).ToString.Trim
            End If

            For I = 0 To grd1.RowCount - 1
                If Me.grd1.GetRowCellValue(I, Me.colAutorizado) = True Then


                    If grd1.GetRowCellDisplayText(I, Me.colTipo) = "SERVIÇO" Then
                        .tbServ.Rows.Add()
                        Dim dtProd As DataTable = CarregarDataTable("Select Garantia from Produto where Codigo =" & Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto))
                        If dtProd.Rows.Count > 0 Then
                            If dtProd.Rows.Item(0).ItemArray(0).ToString <> Nothing Then
                                .lblGar.Visible = True
                                .lblGarantias.Visible = True
                                .linha7.Visible = True
                                .lblGar.Text &= grd1.GetRowCellDisplayText(I, Me.colProduto) & " " & dtProd.Rows.Item(0).ItemArray(0).ToString & ", "
                            End If
                        End If

                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Código") = grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Qtde") = grd1.GetRowCellDisplayText(I, Me.colQtd)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Serviços") = grd1.GetRowCellDisplayText(I, Me.colProduto)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("VlUnit") = grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("vlTot") = grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("UMSER") = grd1.GetRowCellDisplayText(I, Me.colUM)
                        If grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) <> "" Then
                            Dim dtFuc As DataTable = CarregarDataTable("Select Nome from Funcionario where Codigo =" & grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) & " and CodConfig = " & CodConfig)
                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbServ.Rows.Item(Index).Item("FUNC") = grd1.GetRowCellDisplayText(I, Me.colGarantia)

                            'Else
                            If dtFuc.Rows.Count > 0 Then
                                .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("FUNC") = dtFuc.Rows.Item(0).Item(0).ToString
                            End If

                            'End If
                        Else
                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbServ.Rows.Item(Index).Item("FUNC") = grd1.GetRowCellDisplayText(I, Me.colGarantia)

                            'End If
                        End If
                    Else
                        .tbPed.Rows.Add()
                        Dim dtProd As DataTable = CarregarDataTable("Select Garantia from Produto where Codigo =" & Me.grd1.GetRowCellDisplayText(I, Me.colCodigoProduto))

                        If dtProd.Rows.Count > 0 Then
                            If dtProd.Rows.Item(0).ItemArray(0).ToString <> Nothing Then
                                .lblGar.Visible = True
                                .lblGarantias.Visible = True
                                .linha7.Visible = True
                                .lblGar.Text &= grd1.GetRowCellDisplayText(I, Me.colProduto) & " " & dtProd.Rows.Item(0).ItemArray(0).ToString & ", "
                            End If
                        End If

                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("CodigoPeca") = grd1.GetRowCellDisplayText(I, Me.colCodigoInterno)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Qtde") = grd1.GetRowCellDisplayText(I, Me.colQtd)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Descrição") = grd1.GetRowCellDisplayText(I, Me.colProduto)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("ValorUnitR") = grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Total") = grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("UM") = grd1.GetRowCellDisplayText(I, Me.colUM)
                        If grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) <> "" Then
                            Dim dtFuc As DataTable = CarregarDataTable("Select Nome from Funcionario where Codigo =" & grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) & " and CodConfig = " & CodConfig)

                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbPed.Rows.Item(Index).Item("Func") = grd1.GetRowCellDisplayText(I, Me.colGarantia)

                            'Else
                            If dtFuc.Rows.Count > 0 Then
                                .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Func") = dtFuc.Rows.Item(0).Item(0).ToString
                            End If

                            'End If
                        Else
                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbPed.Rows.Item(Index).Item("Modelo") = grd1.GetRowCellDisplayText(I, Me.colGarantia)
                            'End If
                        End If

                    End If
                End If
            Next



            If Me.cboStatus.Text = "Faturado" Then
                Dim dtVenda As DataTable = CarregarDataTable("SELECT CodOrdem FROM Total where CodPedido = " & Me.txtCodPed.Text & " and CodConfig = " & CodConfig)
                If dtVenda.Rows.Count > 0 Then
                    Dim strCodOrdem As String = dtVenda.Rows.Item(0).Item("CodOrdem").ToString

                    Dim vet1 As Array = RetRec("Select Pagamento, FormaPagamento, Valor from Recebimento Where CodOrdem =" & strCodOrdem & " and CodConfig = " & CodConfig)

                    For I = 0 To vet1.Length - 1
                        If vet1(I) = Nothing Then Exit For
                        .lblRec.Text &= vet1(I) & "   "
                    Next

                    Dim dtRec As DataTable = CarregarDataTable("Select Pagamento, Vencimento, ValorParcela from ContaReceber where CodOrdem =" & strCodOrdem & " and CodConfig =" & CodConfig)

                    If dtRec.Rows.Count > 0 Then

                        Dim dtVenc As Date
                        Dim dblPar As Double

                        .lblRec.Text &= " " & vbCrLf
                        .lblRec.Text &= " " & vbCrLf

                        Dim R As Integer

                        For R = 0 To dtRec.Rows.Count - 1

                            If R = 0 Then
                                .lblRec.Text &= dtRec.Rows.Item(R).Item("Pagamento").ToString & vbCrLf
                            End If

                            dtVenc = dtRec.Rows.Item(R).Item("Vencimento").ToString
                            dblPar = dtRec.Rows.Item(R).Item("ValorParcela").ToString
                            .lblRec.Text &= dtVenc & "   R$ " & dblPar.ToString("0.00") & vbCrLf

                        Next
                    End If


                    Dim dblJaRec, dblResTroco As Double
                    dblJaRec = Somar("Select sum(Valor) from Recebimento Where CodOrdem =" & strCodOrdem & " and CodConfig = " & CodConfig)

                    .Recebido.Text = dblJaRec.ToString("0.00")

                    dblResTroco = dblJaRec - Me.txtTotal.Text.Trim

                    If dblResTroco > 0 Then
                        .Troco.Text = dblResTroco.ToString("0.00")
                    End If
                End If
            Else
                If parComValor = True Then
                    Dim dtEntrada As DataTable = CarregarDataTable("Select Pagamento, Valor From Recebimento Where CodigoPedido = '" & Me.txtCodPed.Text & "' And CodConfig=" & CodConfig)

                    If dtEntrada.Rows.Count > 0 Then
                        .lblRec.Text &= " ENTRADA" & vbCrLf
                        Dim strPag As String
                        Dim strValor As String
                        Dim dblValor As Double
                        For I As Integer = 0 To dtEntrada.Rows.Count - 1
                            strPag = dtEntrada.Rows.Item(I).Item("Pagamento").ToString
                            dblValor = dtEntrada.Rows.Item(I).Item("Valor").ToString
                            strValor = dblValor.ToString("####,##0.00")

                            .lblRec.Text &= strPag & "   R$ " & strValor & vbCrLf
                        Next

                    End If
                End If

            End If

            Dim dblDesc As Double
            If Me.txtValDesc.Text <> "" Then
                dblDesc = Me.txtValDesc.Text.Trim
            End If
            .Desconto.Text = dblDesc.ToString("0.00")

            .ExportOptions.Email.Subject = "Pedido Nº " & Me.txtCodPed.Text.Trim
            .ExportOptions.Email.RecipientAddress = Me.txtEmail.Text.Trim

            .picLogo.Image = LogoTipo

            'If MostraNomeFuncionario.Trim = "NÃO" Then
            '.colFunc.Visible = False
            '.colFuncionario.Visible = False
            ' End If

            If parComValor = False Then
                rel.c1.Visible = False
                rel.c2.Visible = False
                rel.c3.Visible = False
                rel.c4.Visible = False
                rel.c5.Visible = False
                rel.c6.Visible = False
                rel.c7.Visible = False
                rel.lblPaga.Visible = False
                rel.lblRec.Visible = False
                rel.colValorTotal.Visible = False
                rel.colValorUnitario.Visible = False
                rel.colvlTot.Visible = False
                rel.colVlUnit.Visible = False
            End If

            If NomeEmpresa = "DAKAR AUTO ELÉTRICA E MECÂNICA" Then
                rel.lblGarantias.Visible = True
                rel.lblGar.Visible = True
                rel.lblGar.Text = "MÃO DE OBRA - 03 MESES, PEÇAS - 03 MESES"
            End If

            Dim dtSta As DataTable = CarregarDataTable("Select Status from TotalConsig where CodOrdens =" & Me.txtCodPed.Text.Trim & " and CodConfig = " & CodConfig)
            Dim strStatus As String = "Pendente"
            If dtSta.Rows.Count > 0 Then
                strStatus = dtSta.Rows.Item(0).Item("Status").ToString
            End If

            Select Case strStatus
                Case "Orçamento"
                    rel.lblPedido.Text = "Orçamento Nº: " & Me.txtCodPed.Text.Trim

                Case "Pendente"
                    rel.lblPedido.Text = "Orçamento Nº: " & Me.txtCodPed.Text.Trim

                Case "Faturado"
                    rel.lblPedido.Text = "O.S. Nº: " & Me.txtCodPed.Text.Trim

            End Select
            If NomeEmpresa.Contains("DAKAR") = True Then
                .lblPedido.Text = "Ordem de Serviço Nº: " & Me.txtCodPed.Text.Trim
            End If

            If NomeEmpresa.Trim.Contains("PORTO PEÇAS") Then
                .colLocacao.Visible = True

                .colLocacaoServ.Visible = True

                'If MostraNomeFuncionario.Trim = "NÃO" Then

                '.colLocacao.VisibleIndex = 3
                '.colLocacaoServ.VisibleIndex = 3

                'Else
                .colLocacao.VisibleIndex = 4
                .colLocacaoServ.VisibleIndex = 4
                'End If
                '.colLocacao.Width = 50
                '.colLocacaoServ.Width = 50
            End If


            If parEnviarEmail = False Then
                .ShowPreview()
            Else


                .ExportToPdf("C:\NANO\Pedidos\Pedido Nº " & Me.txtCodPed.Text.Trim & ".pdf")
            End If

        End With
    End Sub
    'Private Sub ImprimirOS()
    '    Dim rel As New relImpPedidos
    '    With rel
    '        If NomeEmpresa.Contains("MD NEGRO") Then
    '            .XrPanel1.BorderColor = Color.White
    '            .Margins.Top = 166
    '            .lblTitulo.Visible = False
    '            .lblFones.Visible = False
    '            .lblEndereco.Visible = False
    '            .picLogo.Visible = False
    '        End If
    '        .lblAtendente.Visible = False
    '        .lblTitulo.Text = NomeEmpresa
    '        .lblFones.Text = TelefoneEmpresa
    '        .lblEndereco.Text = EnderecoEmpresa
    '        .Nome.Text = Me.txtCli.Text.Trim
    '        .Telefone.Text = txtTel.Text
    '        .Fax.Text = txtFax.Text
    '        .Email.Text = txtEmail.Text
    '        .Placa.Text = txtPlaca.Text
    '        .Modelo.Text = txtMod.Text
    '        .Cor.Text = txtCor.Text
    '        .Ano.Text = txtAno.Text
    '        .KM.Text = txtKm.Text
    '        .Pecas.Text = Me.txtValPec.Text
    '        .Sevicos.Text = txtMObra.Text
    '        .Total.Text = txtTotal.Text
    '        .lblPedido.Text = "O.S. Nº " & Me.txtCodPed.Text.Trim
    '        If NomeEmpresa.Trim.Contains("PINHO") Then
    '            .lblNivComb.Text = "Vendedor:"

    '        End If

    '        If Me.txtProbVeiculo.Text <> "" Then
    '            .lblDefeitos.Text = Me.txtProbVeiculo.Text
    '        Else
    '            .GroupFooter3.Visible = False
    '        End If


    '        Dim dtCar As DataTable = CarregarDataTable("Select Chassi, Motor, Combustivel from Carro where Placa = '" & Me.txtPlaca.Text.Trim & "'")
    '        If dtCar.Rows.Count > 0 Then
    '            .lblChassi.Text = dtCar.Rows.Item(0).Item(0).ToString.Trim
    '            .lblMotor.Text = dtCar.Rows.Item(0).Item(1).ToString.Trim
    '            .lblComb.Text = dtCar.Rows.Item(0).Item(2).ToString.Trim
    '        End If
    '        .lblDesc.Text = Me.txtDesc.Text
    '        .lblData.Text = Me.dtData.Text
    '        .lblEntrada.Text = Me.txtEntrada.Text
    '        .lblSaida.Text = Me.txtSaida.Text.Trim
    '        .lblNivCom.Text = Me.txtNivCom.Text.Trim
    '        .lblKMSaida.Text = Me.txtKMSaida.Text.Trim
    '        .lblPrisma.Text = Me.txtPrisma.Text.Trim

    '        'OCULTAR PARA ORDEM DE SERVIÇO
    '        .colValorUnitario.Visible = False
    '        .colValorTotal.Visible = False
    '        .colVlUnit.Visible = False
    '        .colvlTot.Visible = False
    '        .XrLabel8.Visible = False

    '        .lblPaga.Visible = False
    '        .lblRec.Visible = False
    '        .lblAtendente.Visible = False
    '        .lblAte.Visible = False

    '        .c1.Visible = False
    '        .c2.Visible = False
    '        .c3.Visible = False
    '        .c4.Visible = False
    '        .c5.Visible = False
    '        .c6.Visible = False
    '        .c7.Visible = False

    '        .lblAssi.Visible = False
    '        .linha7.Visible = False
    '        .lblAut.Visible = False
    '        .picLogo.Image = LogoTipo
    '        If grd1.RowCount = 0 Then
    '            .colQtd.VisibleIndex = 2
    '            .colFunc.VisibleIndex = 3
    '            .colFunc.Caption = "Valor R$"
    '            .colQtde.VisibleIndex = 2
    '            .colFuncServ.VisibleIndex = 3
    '            .colFuncServ.Caption = "Valor R$"
    '            For I = 0 To 8
    '                .tbPed.Rows.Add()
    '                .tbServ.Rows.Add()
    '            Next
    '            .tbPed.Rows.Add()
    '            .tbPed.Rows.Add()
    '            .tbPed.Rows.Add()
    '            .tbPed.Rows.Add()
    '            .tbPed.Rows.Add()
    '            .tbPed.Rows.Add()
    '            .tbPed.Rows.Add()
    '            .tbPed.Rows.Add()
    '            '.tbPed.Rows.Add()
    '            .ShowPreview()
    '            Exit Sub
    '        End If

    '        For I = 0 To grd1.RowCount - 1
    '            If Me.grd1.GetRowCellValue(I, Me.colAutorizado) = True Then
    '                If grd1.GetRowCellDisplayText(I, Me.colTipoProduto) = "PEÇA" Then
    '                    .tbPed.Rows.Add()
    '                    Dim Index As Integer = .tbPed.Rows.Count - 1
    '                    .tbPed.Rows.Item(Index).Item("CodigoPeca") = grd1.GetRowCellDisplayText(I, Me.colCodigoPeca)
    '                    .tbPed.Rows.Item(Index).Item("Qtde") = grd1.GetRowCellDisplayText(I, Me.colQtd)
    '                    .tbPed.Rows.Item(Index).Item("Descrição") = grd1.GetRowCellDisplayText(I, Me.colProduto)
    '                    .tbPed.Rows.Item(Index).Item("ValorUnitR") = grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
    '                    .tbPed.Rows.Item(Index).Item("Total") = grd1.GetRowCellDisplayText(I, Me.colValorTotal)
    '                    .tbPed.Rows.Item(Index).Item("UM") = grd1.GetRowCellDisplayText(I, Me.colUM)

    '                    Dim dtFuc As DataTable = CarregarDataTable("Select Nome from Funcionario where Cod ='" & grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) & "' and CodConfig = " & CodConfig)
    '                    If dtFuc.Rows.Count > 0 Then
    '                        .tbPed.Rows.Item(Index).Item("Func") = dtFuc.Rows.Item(0).Item("Nome").ToString
    '                    End If
    '                    .tbPed.Rows.Item(Index).Item("Locacao") = grd1.GetRowCellDisplayText(I, Me.colLocacao)

    '                End If
    '            End If

    '        Next

    '        For I = 0 To grd1.RowCount - 1
    '            If Me.grd1.GetRowCellValue(I, Me.colAutorizado) = True Then
    '                If grd1.GetRowCellDisplayText(I, Me.colTipoProduto) = "SERVIÇO" Or grd1.GetRowCellDisplayText(I, Me.colTipoProduto) = "TERCEIRO" Then
    '                    .tbServ.Rows.Add()
    '                    Dim Index As Integer = .tbServ.Rows.Count - 1
    '                    .tbServ.Rows.Item(Index).Item("Código") = grd1.GetRowCellDisplayText(I, Me.colCodigoPeca)
    '                    .tbServ.Rows.Item(Index).Item("Qtde") = grd1.GetRowCellDisplayText(I, Me.colQtd)
    '                    .tbServ.Rows.Item(Index).Item("Serviços") = grd1.GetRowCellDisplayText(I, Me.colProduto)
    '                    .tbServ.Rows.Item(Index).Item("VlUnit") = grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
    '                    .tbServ.Rows.Item(Index).Item("vlTot") = grd1.GetRowCellDisplayText(I, Me.colValorTotal)
    '                    .tbServ.Rows.Item(Index).Item("UMSER") = grd1.GetRowCellDisplayText(I, Me.colUM)
    '                    Dim dtFuc As DataTable = CarregarDataTable("Select Nome from Funcionario where Cod ='" & grd1.GetRowCellDisplayText(I, Me.colCodigoFuncionario) & "' and CodConfig = " & CodConfig)
    '                    If dtFuc.Rows.Count > 0 Then
    '                        .tbServ.Rows.Item(Index).Item("Func") = dtFuc.Rows.Item(0).Item("Nome").ToString
    '                    End If
    '                    .tbServ.Rows.Item(Index).Item("Locacao") = grd1.GetRowCellDisplayText(I, Me.colLocacao)
    '                End If
    '            End If

    '        Next

    '        If .tbPed.Rows.Count = 0 And .tbServ.Rows.Count = 0 Then
    '            For I = 0 To grd1.RowCount - 1
    '                If Me.grd1.GetRowCellValue(I, Me.colAutorizado) = True Then
    '                    .tbPed.Rows.Add()
    '                    Dim Index As Integer = .tbPed.Rows.Count - 1
    '                    .tbPed.Rows.Item(Index).Item("CodigoPeca") = grd1.GetRowCellDisplayText(I, Me.colCodigoProduto)
    '                    .tbPed.Rows.Item(Index).Item("Qtde") = grd1.GetRowCellDisplayText(I, Me.colQtd)
    '                    .tbPed.Rows.Item(Index).Item("Descrição") = grd1.GetRowCellDisplayText(I, Me.colProduto)
    '                    .tbPed.Rows.Item(Index).Item("ValorUnitR") = grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
    '                    .tbPed.Rows.Item(Index).Item("Total") = grd1.GetRowCellDisplayText(I, Me.colValorTotal)
    '                    .tbPed.Rows.Item(Index).Item("UM") = grd1.GetRowCellDisplayText(I, Me.colUM)
    '                    .tbPed.Rows.Item(Index).Item("Locacao") = grd1.GetRowCellDisplayText(I, Me.colLocacao)
    '                End If

    '            Next

    '        End If

    '        If NomeEmpresa.Trim.Contains("PORTO PEÇAS") Then
    '            .colLocacao.Visible = True
    '            .colLocacaoServ.Visible = True

    '            .colLocacao.VisibleIndex = 3
    '            .colLocacaoServ.VisibleIndex = 3

    '        End If

    '        .ShowPreview()
    '        '.ExportToHtml("C:\Arq.html")
    '        'System.Diagnostics.Process.Start("C:\Arq.html")
    '    End With
    'End Sub

   

    Private Sub txtKm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKm.KeyDown
      
        If e.KeyCode = Keys.Enter Then
            Me.XtraTabControl1.SelectedTabPageIndex = 1
        End If

    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If Me.XtraTabControl1.SelectedTabPageIndex = 1 Then
            Timer1.Start()
        End If
    End Sub

    Private Sub chkAut_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAut.EditValueChanged
        If Me.grd1.GetRowCellValue(Me.grd1.FocusedRowHandle, Me.colAutorizado) = False Then
            Me.grd1.SetRowCellValue(Me.grd1.FocusedRowHandle, Me.colAutorizado, True)
        Else
            Me.grd1.SetRowCellValue(Me.grd1.FocusedRowHandle, Me.colAutorizado, False)
        End If
        Calcular(False)
    End Sub

    Private Sub btnCadSeg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCadSeg.Click
        Dim frm As New frmGrupo
        frmGrupo.Tag = "SEGURADORA"
        frmGrupo.ShowDialog()

        Me.txtSeguradora.Properties.Items.Clear()
        PreencherGrupoSetorCusto("SEG", Me.txtSeguradora)
        Me.txtSeguradora.Focus()
    End Sub

    Private Sub cboCodFunc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCodFunc.Leave
        If Me.txtValor.Enabled = False Then
            Me.btnAdd.Focus()
        Else
            If Me.txtValor.Text = "" Then
                Me.txtValor.Focus()
            Else
                Me.btnAdd.Focus()
            End If
        End If

    End Sub

    Private Sub btnTermo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTermo.ItemClick
        Dim strMes As String = ""

        Select Case Date.Now.Month
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

        Dim rel As New relTermo

        With rel
            .lblTitulo.Text = NomeEmpresa
            .lblFones.Text = TelefoneEmpresa
            .lblEndereco.Text = EnderecoEmpresa
            '.seguro.Text = Me.txtSeguradora.Text.Trim
            .placa.Text = Me.txtPlaca.Text.Trim
            .modelo.Text = Me.txtMod.Text.Trim
            .cor.Text = Me.txtCor.Text.Trim
            .ano.Text = Me.txtAno.Text.Trim
            .lblCid.Text = CidadeEmpresa & ","

            Dim dt As DataTable = CarregarDataTable("Select Fabricante, Chassi from Carro where Placa ='" & Me.txtPlaca.Text.Trim & "'")
            If dt.Rows.Count > 0 Then
                .marca.Text = dt.Rows.Item(0).ItemArray(0).ToString.Trim
                .chassi.Text = dt.Rows.Item(0).ItemArray(1).ToString.Trim
            End If
            .km.Text = Me.txtKm.Text.Trim
            '.sinistro.Text = Me.txtSinistro.Text.Trim
            .cliente.Text = Me.txtCli.Text.Trim
            .cliente1.Text = Me.txtCli.Text.Trim

            'dt = CarregarDataTable("Select Extra2 From Config")
            'If dt.Rows.Count > 0 Then
            '    If dt.Rows.Item(0).Item(0).ToString <> "" Then
            '        .lblCid.Text = dt.Rows.Item(0).Item(0).ToString & ","
            '    End If
            'End If

            .data.Text = Date.Now.Day & " de " & strMes & " de " & Date.Now.Year
            .picLogo.Image = LogoTipo
            .ShowPreview()
        End With
    End Sub

    Private Sub btnProcesso_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnProcesso.ItemClick
        Dim rel As New relProcesso

        With rel
            .Nome.Text = Me.txtCli.Text.Trim
            '.sinistro.Text = Me.txtSinistro.Text.Trim
            '.seguradora.Text = Me.txtSeguradora.Text.Trim
            .tel1.Text = Me.txtTel.Text.Trim
            .tel2.Text = Me.txtFax.Text.Trim

            'Dim dt As DataTable = CarregarDataTable("Select Endereco, Bairro, Cidade, Estado, Celular, Corretor, TelefoneCorretor from Cliente where Codigo ='" & intCodCli & "'")
            Dim dt As DataTable = CarregarDataTable("Select Endereco, Bairro, Cidade, Estado, Celular From Cliente where Codigo ='" & intCodCli & "'")

            If dt.Rows.Count > 0 Then

                .endereco.Text = dt.Rows.Item(0).ItemArray(0).ToString
                .bairro.Text = dt.Rows.Item(0).ItemArray(1).ToString
                .cidade.Text = dt.Rows.Item(0).ItemArray(2).ToString
                .estado.Text = dt.Rows.Item(0).ItemArray(3).ToString

                Dim vetTel1 As Array
                vetTel1 = Split(dt.Rows.Item(0).ItemArray(4).ToString, "|")

                If vetTel1.Length > 1 Then
                    .tel3.Text = vetTel1(1)
                Else
                    .tel3.Text = vetTel1(0)
                End If

                '.nomeCorretor.Text = dt.Rows.Item(0).ItemArray(5).ToString
                '.telCorretor.Text = dt.Rows.Item(0).ItemArray(6).ToString
            End If

            .placa.Text = Me.txtPlaca.Text.Trim
            .modelo.Text = Me.txtMod.Text.Trim
            .cor.Text = Me.txtCor.Text.Trim
            .ano.Text = Me.txtAno.Text.Trim

            Dim dt2 As DataTable = CarregarDataTable("Select Fabricante from carro where Placa='" & Me.txtPlaca.Text.Trim & "'")
            If dt2.Rows.Count > 0 Then
                .marca.Text = dt2.Rows.Item(0).ItemArray(0).ToString
            End If

            .ShowPreview()
        End With
    End Sub

    Private Sub btnChekList_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnChekList.ItemClick
        If NomeEmpresa.Contains("MAXX") = True Then
            Dim rel As New RelCheckListMaxx

            rel.lblCliente.Text = Me.txtCli.Text
            rel.lblCod.Text = Me.txtCodPed.Text
            rel.lblveiculo.Text = Me.txtMod.Text
            rel.lblPlaca.Text = Me.txtPlaca.Text
            rel.lblKm.Text = Me.txtKm.Text
            rel.picLogo.Image = LogoTipo
            rel.ShowPreview()

        Else
            Dim rel As New relCheckList
            rel.lblTitulo.Text = NomeEmpresa
            rel.lblFones.Text = TelefoneEmpresa
            rel.lblEndereco.Text = EnderecoEmpresa
            'rel.lblAtendente.Text = User


            rel.picLogo.Image = LogoTipo

            rel.Nome.Text = Me.txtCli.Text.Trim

            rel.Placa.Text = txtPlaca.Text
            rel.Modelo.Text = txtMod.Text
            rel.Cor.Text = txtCor.Text
            rel.Ano.Text = txtAno.Text

            'rel.Seguradora.Text = Me.txtSeguradora.Text
            'rel.Sinistro.Text = Me.txtSinistro.Text
            rel.CPF.Text = CpfDoCliente
            rel.lblLocal.Text = CidadeEmpresa & ",  " & My.Computer.Clock.LocalTime

            rel.ShowPreview()
        End If
    End Sub

    Private Sub txtDesc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc.TextChanged
        If Me.XtraTabControl3.SelectedTabPageIndex = 0 Then
            strObsTemp = Me.txtDesc.Text
        End If
    End Sub

    Private Sub txtProbVeiculo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProbVeiculo.TextChanged
        If Me.XtraTabControl3.SelectedTabPageIndex = 0 Then
            strDefeiTemp = Me.txtProbVeiculo.Text
        End If
    End Sub

    Private Sub txtPlaca_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlaca.KeyPress
        If txtPlaca.Text.Length <= 2 Then
            If Char.IsLetter(e.KeyChar) = False And e.KeyChar <> vbBack Then
                e.Handled = True
            End If
        ElseIf txtPlaca.Text.Length = 3 Then
            If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
                e.Handled = True
            End If

        ElseIf txtPlaca.Text.Length > 4 Then
            If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtCli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCli.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            If TipoNano <> 5 Then
                '    If Me.txtPlaca.Text = "" Then
                '        Me.txtPlaca.Focus()
                '    Else
                '        Me.txtKm.Focus()
                '    End If

                'Else
                Me.XtraTabControl1.SelectedTabPageIndex = 1
                'Me.txtCodPro.Focus()
            End If

        End If
    End Sub

    Private Sub btnCadCar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadCar.Click
        AbreCliente("VEICULO")
        If Me.txtPlaca.Text <> "" Then
            Me.txtKm.Focus()
        End If
    End Sub

    Private Sub txtCusto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCusto.Leave
        Me.btnAdd.Focus()
    End Sub
    
    Private Sub rdgTipoProd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgTipoProd.SelectedIndexChanged
        strDescontoPromocao = ""
        bolMensagemDesconto = False
        Me.txtValDesc.ResetText()
        Me.txtDesconto.ResetText()

        If strDescontoCliente = "" Then
            Me.txtPerDesc.ResetText()
        Else
            Me.txtPerDesc.Text = strDescontoCliente
        End If
        Me.txtCusto.ResetText()
        Me.txtValDesconto.ResetText()
        Me.txtEmEstoque.ResetText()
        Me.txtEmPedido.ResetText()
        Me.txtSaldoQtd.ResetText()
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
        strTipoProduto = ""
        Me.grd1.ClearColumnsFilter()
      
        bolDigQtd = False
        Campanha(0)
        Gaxeta(0)
        Calcular(False)
        bolAdd = False
    End Sub

    Private Sub txtNomePro_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNomePro.GotFocus
        If AlteraNomePedido = False Then
            If Me.txtCodPro.Text = "" Then
                Me.txtNomePro.Properties.ReadOnly = False
            End If
        End If
    End Sub
    Private Sub txtNomePro_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNomePro.LostFocus
        If AlteraNomePedido = False Then
            Me.txtNomePro.Properties.ReadOnly = True
        End If
    End Sub
    Private Sub txtNomePro_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNomePro.Leave
        If Me.txtCodPro.Text <> "" Then
            Me.txtQtd.Focus()
            Exit Sub
        End If

        If Me.txtNomePro.Text = "" Then Exit Sub

        If NomeEmpresa.ToUpper.Contains("LDN AUTO") = True Then
            If ConProdAberto = False Then

                frmPro.Tag = "VENDA"
                frmPro.Show()
                frmPro.Visible = False
                ConProdAberto = True
            End If
            If TipoNano = 5 Then
                Select Case Me.rdgTipoProd.SelectedIndex
                    Case 0
                        frmPro.strTipoProduto = "P"
                        frmPro.grd1.ActiveFilter.NonColumnFilter = "[Tipo] <> 'SERVIÇO'"

                    Case 1
                        frmPro.strTipoProduto = "S"
                        frmPro.grd1.ActiveFilter.NonColumnFilter = "[Tipo] = 'SERVIÇO'"

                    Case 2
                        frmPro.strTipoProduto = "T"
                        frmPro.grd1.ActiveFilter.NonColumnFilter = "[Tipo] <> 'SERVIÇO'"

                End Select
            Else
                frmPro.strTipoProduto = ""
            End If
            frmPro.Tag = "PEDIDO"
            frmPro.strFiltroProduto = Me.txtNomePro.Text
            frmPro.FiltroProduto()
            CodigoDoProduto = 0
            QtdeDoProduto = 0
            CodigoDoProdutoAgrupado = ""
            frmPro.Visible = True
            frmPro.Timer1.Start()
            Exit Sub
        Else
            Dim frm As New frmConProduto
            If TipoNano = 5 Then
                Select Case Me.rdgTipoProd.SelectedIndex
                    Case 0
                        frm.strTipoProduto = "P"
                    Case 1
                        frm.strTipoProduto = "S"
                    Case 2
                        frm.strTipoProduto = "T"
                End Select
            Else
                frm.strTipoProduto = ""
            End If
            frm.Tag = "PEDIDO"
            frm.strFiltroProduto = Me.txtNomePro.Text
            CodigoDoProduto = 0
            QtdeDoProduto = 0
            CodigoDoProdutoAgrupado = ""
            frm.ShowDialog()
        End If
      
        'If QtdeDoProduto > 0 Then
        '    Me.txtQtd.Text = QtdeDoProduto
        'End If
        'QtdeDoProduto = 0
        If CodigoDoProdutoAgrupado <> "" Then
            Dim I As Integer
            Dim vetProd As Array = Split(CodigoDoProdutoAgrupado, "|")
            If vetProd.Length = 1 Then
                Dim vetCodProd As Array = Split(vetProd(0), "%")
                CodigoDoProduto = vetCodProd(0)
                Me.txtQtd.Text = vetCodProd(1)
                InserirProdutos()
                QtdeDoProduto = 0
                CodigoDoProduto = -1
            Else
                If TipoNano = 5 Then
                    If Me.cboCodFunc.Text = "" Then
                        InserirVendedor()
                        If Me.cboCodFunc.Text = "" Then
                            MsgBox("Nenhum funcionário selecionado!", MsgBoxStyle.Information)
                            CodigoDoProdutoAgrupado = ""
                            Exit Sub
                        End If
                    End If
                End If
    
                For I = 0 To vetProd.Length - 1
                    Dim vetCodProd As Array = Split(vetProd(I), "%")
                    CodigoDoProduto = vetCodProd(0)
                    Me.txtQtd.Text = vetCodProd(1)
                    InserirProdutos()
                    Adicinar()

                    QtdeDoProduto = 0
                    CodigoDoProduto = -1
                Next

            End If

        Else
            Me.txtCodPro.ResetText()
            Exit Sub
        End If
        'InserirProdutos()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If Me.txtCodPed.Text = "" Then Exit Sub
        Dim frm As New frmPedidoCompra
        frm.Tag = "CADASTRA"
        frm.txtDesc.Text = "PEDIDO " & Me.txtCodPed.Text
        frm.Show()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If Me.txtCodPed.Text = "" Then Exit Sub

        Dim Index As Integer = -999997
        frmRelPedCompra.grd1.FocusedRowHandle = Index
        frmRelPedCompra.grd1.FocusedColumn = frmRelPedCompra.colObs
        frmRelPedCompra.grd1.SetRowCellValue(Index, frmRelPedCompra.colObs, "PEDIDO " & Me.txtCodPed.Text.Trim)
        frmRelPedCompra.grd1.ShowEditor()

        frmRelPedCompra.Show()
    End Sub

    Private Sub NanoCampo1_Leave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles NanoCampo1.Leave
        CalcularQtdEmb()
        Me.txtQtd.Focus()
    End Sub

    Private Sub CalcularQtdEmb()
        If dblQtdEmb <> 0.0 And Me.NanoCampo1.Text <> "" Then
            Dim dblQtdEmb1 As Double = Me.NanoCampo1.Text
            Dim dblQtd As Double = Me.txtQtd.Text
            Dim dblResult As Double = 0.0

            dblResult = dblQtdEmb1 * dblQtdEmb
            Me.txtQtd.Text = dblResult.ToString("0.00")
        End If
    End Sub

    Private Sub CalcularQtdEmb2()
        If dblQtdEmb <> 0.0 Then
            Dim dblQtd As Double = Me.txtQtd.Text
            Dim dblResult As Double = 0.0

            dblResult = dblQtd / dblQtdEmb
            Me.NanoCampo1.Text = CampoValor(ArredondarValorMais(dblResult))
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If TipoNano = 5 Then
            VisualizarAutomotivoImg(True, False)
        Else
            VisualizarCommerceImg(True, False)
        End If
    End Sub

    Private Sub cboStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStatus.SelectedIndexChanged
        strStatusPed = Me.cboStatus.Text.Trim
    End Sub


    Private Sub txtValorFrete_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorFrete.Leave

        'If Me.txtTotal.Text = "" Then Exit Sub
        If Me.txtValorFrete.Text <> "" Then
            Dim dblFrete As Double = Me.txtValorFrete.Text
            Me.txtValorFrete.Text = dblFrete.ToString("0.00")


        End If
        Calcular(True)

        If TipoDesconto = "TOTAL" Then
            DescontoComPorcentagem(False)
        End If
    End Sub

    Private Sub btnVisuaPaisagem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisuaPaisagem.ItemClick
        ImprimirPadraoPaisagem(True, False)
    End Sub

    Private Sub lueTabelaPreco_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueTabelaPreco.EditValueChanged
        If Me.lueTabelaPreco.Text = "" Then Exit Sub

        Me.txtValor.Text = Me.lueTabelaPreco.GetColumnValue("Valor").ToString
        Me.cboTabela.Text = Me.lueTabelaPreco.Text
        Me.txtValor.Focus()
    End Sub
End Class