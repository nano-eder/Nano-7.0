Imports Nano.clsFuncoes
Imports Nano.clsDarBaixa
Imports Nano.clsGerarArqs
Imports System.Globalization
Imports System
Imports System.IO
Imports System.Math
Imports Nano.clsFuncoesBematech
Imports Nano.clsSAT
Public Class frmVenda
    Dim intCodTEF As Integer

    Public bolCrediarioOK As Boolean = False
    Public bolCredOK As Boolean = False
    Dim bolConsultaPreco As Boolean = False
    Dim intCont As Integer
    Dim dblTotalDeCusto As Double
    Dim dblTotalSemDesconto As Double
    Dim dblTotalRecebido As Double
    Dim intCodCliente As Integer = 1
    Dim intContCrediario As Integer = 0
    Dim strCpfCnpj As String
    Dim bolMSGCliente As Boolean = False

    Dim dtProduto As DataTable
    Dim CodigoConsigComanda As Integer
    Dim dblTotalComDesconto As Double
    Dim intCodFunc As Integer
    Dim dblCreditoVenda As Double
    Dim intCodPedido As Integer
    'Dim intCodComanda As Long
    Public strCmdsSQL As String = ""
    Public strCmdsPagamento As String = ""
    Public intOrdem As Integer
    Public intCodOrdemVenda As Integer = 0
    Public intCodConfigVenda As Integer = 0
    Dim strValorPresente As String = ""
    Dim intCodMecanico As Integer
    Dim strCabecalho As String
    Dim strMeioCupom As String
    Dim strTotalCupom As String
    Dim strFimCupom As String

    Public bolPedido As Boolean = False
    Dim bolFoto As Boolean = False
    Dim intContFoto As Integer

    Dim strDescontoCliente As String = ""
    Dim dtProdutoEnter As DataTable
    Dim intContDiversos As Integer = 1
    Public intCodTabelaPreco As Integer
    Dim strAuxiliar As String
    Dim intContPagamento As Integer
    Dim VendaFinalizada As Boolean = False

    Public strArquivoProcessado As String
    Public strStatus As String

    Dim dblSemDezPorcento As Double

    Dim strComprovanteTEF(20) As String

    Dim bolDigQtd As Boolean = False

    Public dblValorEconomia As Double

    Dim bolAltPreco As Boolean = False

    Dim strKMMes As String
    Dim strKM As String = ""
    Dim strPlaca As String = ""
    Dim strModelo As String = ""

    Dim bolDuploEnter As Boolean = False


    Dim frmPro As New frmConProduto
    Dim ConProdAberto As Boolean = False


    Dim strCodComanda As String = ""
    Dim strOperador As String
    Private Sub frmVenda_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Me.tbItens.Rows.Count > 0 Then
            If MsgBox("Deseja finalizar a venda antes de fechar a janela?", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                e.Cancel = True
            Else
                If NomeEmpresa.ToUpper.Trim.Contains("JÉSSICA COSMÉTICOS") = True Then
                    If SenhaEstaOK() = False Then
                        e.Cancel = True
                    End If
                Else
                    If SenhaAdm = True Then
                        If Nivel = "USUÁRIO" Then
                            If SenhaEstaOK() = False Then
                                e.Cancel = True
                            End If
                        End If
                    End If
                End If
                FinalizarTEF(0)
                Excluir("Delete from Ordem where Codigo = " & intOrdem & " AND CodConfig =" & CodConfig)


                If VendaComComanda = True Then
                    VendaComComanda = False
                    Try
                        If FormAberto = "frmComandaItens" Or FormAberto = "frmComandaItensCONSULTAR" Then
                            frmComandaItens.Close()
                            frmComandaPrincipal.MdiParent = MDIComanda
                            frmComandaPrincipal.Show()
                            frmComandaPrincipal.Dock = DockStyle.Fill
                        ElseIf FormAberto = "frmComandaPrincipal" Then
                            frmComandaPrincipal.Close()
                            frmComandaPrincipal.MdiParent = MDIComanda
                            frmComandaPrincipal.Show()
                            frmComandaPrincipal.Dock = DockStyle.Fill
                        End If
                    Catch ex As Exception
                    End Try
                End If
            End If
        Else
            Excluir("Delete from Ordem where Codigo = " & intOrdem & " AND CodConfig =" & CodConfig)
        End If



        If TemBalanca = True Then
            If PortaAberta = True Then
                clsToledoPrix.FechaPorta()
                PortaAberta = False
            End If
        End If

        frmPro.Close()
        frmPro.Dispose()
    End Sub
 
    Private Sub frmVenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nbcVenda.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        ConProdAberto = False
        If TipoNano = 2 Then
            Me.btnMecanico.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.lblLabelMecanico.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.lblMecanico.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            'InserirMecanico()
        ElseIf TipoNano = 5 Then
            Me.picFundo.EditValue = Global.Nano.My.Resources.Resources.NANOAutomotivo
            Me.rdgTipoProd.Visible = True
        End If

        If TesteConexao() = False Then Exit Sub
        If TemBalanca = True Then
            Try
                clsToledoPrix.FechaPorta()
            Catch ex As Exception
            End Try
        End If
        If Representante = True Then
            Me.lblEraSystems.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

        If RelatorioVendaNaVenda = True Then
            Me.btnRelVend.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)

        If PafEcfNano = False Then
            If NANONFCe = False Then

                Me.btnDav.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                'Me.chkNFP.Visible = False

                If SATFiscal = True Then
                    'Me.chkNFP.Visible = True

                    Me.btnDav.Visibility = DevExpress.XtraBars.BarItemVisibility.Always


                    If IO.File.Exists(My.Application.Info.DirectoryPath & "\SatFiscal.txt") = True Then
                        Me.btnDav.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If

                    If ModeloSAT = "BEMATECH" Then
                        If VerificarFechamentoSAT() = False Then
                            Me.Close()
                            Exit Sub
                        End If

                    End If

                End If
            Else
                If ImpDiretoNFCe = True Then
                    Me.btnDav.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Else
                    Me.btnDav.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                End If

            End If

        Else

            If My.Computer.Name = ComputadorECF Then
                Me.btnDav.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Else
                Me.btnDav.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
        End If
        If CpfNaNota = True Then
            Me.chkNFP.Visible = True
        Else
            Me.chkNFP.Visible = False
        End If

        If NomeEmpresa.ToUpper.Trim.Contains("TAUÁ") Then
            Select Case CodConfig
                Case 5
                    Me.PagamentoBindingSource.Filter = "Descricao <> 'CREDIÁRIO'"
                Case Else

            End Select
        End If

        Me.PagamentoTableAdapter.Fill(Me.DsNanoCommerce.Pagamento)

        If NomeEmpresa = "SABOR DA FRUTA" Then
            Me.colTamanho.Visible = False
            Me.btnPedido.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.lblAviso.Visible = False
        End If
        If NomeEmpresa.ToUpper.Trim.Contains("JÉSSICA COSMÉTICOS") Then
            Me.LabelControl6.Visible = False
            Me.txtSubTotal.Visible = False

            Me.txtPerDesc.Enabled = False
        End If
        Dim bolGaveta As Boolean = True
        If NomePCGaveta <> "" Then
            If NomePCGaveta.ToUpper <> My.Computer.Name.ToUpper Then
                bolGaveta = False
            End If
        End If

        If TemGaveta = True Then
            If bolGaveta = True Then
                Me.btnGaveta.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            End If

        End If

        Me.lblOper.Caption = Dir(UserNano, 30)

        Me.picLogo.Image = LogoTipo

        Timer1.Start()

        intOrdem = 999999999


        If GerarComissao = False Then
            btnVendedor.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            lblVend1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            lblVend2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If



        If TemImpressora = False Then
            Me.btnImprimir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

        If NomeEmpresa.Contains("CASTELO KIDS") = False Then
            If NomeEmpresa.Contains("SABOR DA FRUTA") = False Then

                If bolPedido = False Then
                    InserirVendedor()

                End If
                bolPedido = False

            End If
        End If

        If TabelaPreco <> "" Then
            Dim dtTab As DataTable = CarregarDataTable("SELECT Codigo FROM Grupo where Tipo = 'T' and Nome = '" & TabelaPreco & "'")
            If dtTab.Rows.Count > 0 Then
                intCodTabelaPreco = dtTab.Rows.Item(0).Item("Codigo")
                Me.lblTabela.Caption = TabelaPreco
            End If
        End If

        'If ManterMargemProd = True Then
        '    Me.rdgTipoProd.Visible = True
        'End If

       
        CodigoDoCliente = 1
        TrazCliente()

        intCodTEF = 0

        If TEF = True Then
            frmTEF.Tag = ""
            frmTEF.Conectar(IP, CaixaTEF)
            VerificarTEFPendente()
        End If


        If AbrirFecharCaixa = True Then
            If VerificarCaixa("") = False Then
                Me.Close()
                Exit Sub
            End If
        End If
    End Sub
    Private Sub VerificarTEFPendente()
        'Dim dtTef As DataTable = CarregarDataTable("SELECT top 1 Cod, StatusEmitente FROM Ordens where Tabela = 'TEF' and Codconfig = " & CodConfig & " and Auxiliar = '" & My.Computer.Name.ToUpper & "' order by Cod desc")
        'If dtTef.Rows.Count > 0 Then
        '    Dim strStatusTef As String = dtTef.Rows.Item(0).Item("StatusEmitente").ToString
        '    Dim strCodTef As String = dtTef.Rows.Item(0).Item("Cod").ToString
        '    If strStatusTef = "Pendente" Then
        '        MsgBox("Última transação TEF não foi efetuada, favor reter o cupom!", MsgBoxStyle.Information)
        '        Dim dataFiscal As String = Format(Date.Today, "yyyyMMdd")
        '        Dim horario As String = Format(My.Computer.Clock.LocalTime, "HHmmss")
        '        clsTEF.FinalizaTransacaoSiTefInterativo(0, strCodTef, dataFiscal, horario)
        '        If RetornoTEF = 0 Then
        '            Atualizar("UPDATE Ordens set StatusEmitente = 'OK' where Cod = '" & strCodTef & "' and Tabela = 'TEF' and Codconfig = " & CodConfig & " and Auxiliar = '" & My.Computer.Name.ToUpper & "'")
        '        End If
        '    End If
        'End If

        Dim dtTef As DataTable = CarregarDataTable("SELECT top 1 Cod, StatusEmitente FROM Ordens where Tabela = 'TEF' and Codconfig = " & CodConfig & " and Auxiliar = '" & My.Computer.Name.ToUpper & "' order by Cod desc")
        If dtTef.Rows.Count > 0 Then
            Dim strStatusTef As String = dtTef.Rows.Item(0).Item("StatusEmitente").ToString
            Dim strCodTef As String = dtTef.Rows.Item(0).Item("Cod").ToString
            If strStatusTef = "Pendente" Then
                Dim dtTotal As DataTable = CarregarDataTable("SELECT Codigo FROM Total where CodOrdensTEF = '" & strCodTef & "' and CodConfig = " & CodConfig & " and Auxiliar like '%" & My.Computer.Name.ToUpper & "%'")
                If dtTotal.Rows.Count = 0 Then
                    MsgBox("Última transação TEF não foi efetuada, favor reter o cupom!", MsgBoxStyle.Information)
                    Dim dataFiscal As String = Format(Date.Today, "yyyyMMdd")
                    Dim horario As String = Format(My.Computer.Clock.LocalTime, "HHmmss")
                    clsTEF.FinalizaTransacaoSiTefInterativo(0, strCodTef, dataFiscal, horario)
                    If RetornoTEF = 0 Then
                        Atualizar("UPDATE Ordens set StatusEmitente = 'OK' where Cod = '" & strCodTef & "' and Tabela = 'TEF' and Codconfig = " & CodConfig & " and Auxiliar = '" & My.Computer.Name.ToUpper & "'")
                    End If
                Else
                    Atualizar("UPDATE Ordens set StatusEmitente = 'OK' where Cod = '" & strCodTef & "' and Tabela = 'TEF' and Codconfig = " & CodConfig & " and Auxiliar = '" & My.Computer.Name.ToUpper & "'")
                End If

            End If
        End If
    End Sub
    Private Sub GerarNumeroTEF()
        intCodTEF = GerarCodigoOrdens("TEF", CodConfig)
        Inserir("Insert into Ordens (Tabela, Cod, CodConfig, StatusEmitente, Auxiliar) values('TEF'," & intCodTEF & "," & CodConfig & ",'Pendente','" & My.Computer.Name.ToUpper & "')")
    End Sub
    Private Sub frmVenda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Shift AndAlso (e.KeyCode = Keys.NumPad4) Then
            CodigoDoCliente = 1
        End If

        If e.Control AndAlso (e.KeyCode = Keys.F) Then
            ConsultaPreco()
        End If

        If e.Control AndAlso (e.KeyCode = Keys.D) Then
            ConsultaProduto()
        End If

        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "27")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If

        If e.KeyCode = Keys.F2 Then
            Me.txtCodPro.Focus()
        End If


        If e.KeyCode = Keys.F3 Then
            Finalizar()
        End If

        If e.KeyCode = Keys.F4 Then
            Dim frm As New frmTamanhoProd
            frm.Tag = "TABELA"
            frm.ShowDialog()
            AtualizarTabelaPreco()
        End If

        If e.KeyCode = Keys.F5 Then
            nbcVenda.ActiveGroup = Me.nbgPag
            nbcVenda.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded

            Me.btnPor.Down = False
            Me.btnCli.Down = False
            Me.btnPag.Down = True

            Me.cboPag.Focus()

        End If

        If e.KeyCode = Keys.F6 Then
            nbcVenda.ActiveGroup = Me.nbgDesc
            nbcVenda.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded

            Me.btnPor.Down = True
            Me.btnCli.Down = False
            Me.btnPag.Down = False
            Me.txtPorDesc.Focus()

        End If

        If e.KeyCode = Keys.F7 Then
            nbcVenda.ActiveGroup = Me.nbgCli
            nbcVenda.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded

            Me.btnPor.Down = False
            Me.btnCli.Down = True
            Me.btnPag.Down = False
            Me.txtCPF.Focus()

        End If
        If e.KeyCode = Keys.F8 Then
            InserirMecanico()
        End If
        If e.KeyCode = Keys.F9 Then
            Me.txtCodPro.Focus()
            InserirVendedor()
        End If

        'If e.KeyCode = Keys.F12 Then
        '    AbreGaveta()
        'End If

        If NomeEmpresa = "SABOR DA FRUTA" Then
            If e.KeyCode = Keys.F11 Then
                frmPedido1.ShowDialog()
                Calcular()
            End If
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        'If e.KeyCode = Keys.Enter Then
        '    If Me.txtValor.Properties.ReadOnly = False Then
        '        If Me.txtCodPro.Text = "1" Then
        '            If Me.txtValor.Text = "" Then
        '                MessageBox.Show("Digite o valor do produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '                Me.txtValor.Properties.ReadOnly = True
        '                Me.txtCodPro.Focus()
        '            Else
        '                'InserirProdEnter(False, dtProdutoEnter, False)
        '                'Me.txtCodPro.Focus()
        '            End If
        '        End If
        '    End If

        'End If

    End Sub
    Private Sub InserirMecanico()
        If TipoNano = 2 Then
            Dim frm As New frmSelecFunc
            frm.LabelControl1.Text = frm.LabelControl1.Text.Replace("Vendedor", "Mecânico")
            frm.LabelControl2.Text = frm.LabelControl2.Text.Replace("vendedor", "mecânico")
            frm.Text = frm.Text.Replace("Vendedor", "Mecânico")
            frm.Tag = "MECANICO"
            CodigoFuncionario = 0
            NomeFuncionario = ""
            frm.ShowDialog()
            intCodMecanico = CodigoFuncionario
            Me.lblMecanico.Caption = Dir(NomeFuncionario, 40)
        End If
    End Sub
    Private Sub InserirVendedor()

        If GerarComissao = True Then
            Dim frm As New frmSelecFunc
            frm.Tag = "VENDEDOR"
            CodigoFuncionario = 0
            NomeFuncionario = ""
            frm.ShowDialog()
            intCodFunc = CodigoFuncionario
            Me.lblVend2.Caption = Dir(NomeFuncionario, 30)
        End If

    End Sub

    Private Sub InserirProdEnter(ByVal parPesquisaPorNome As Boolean, ByVal dtProd As DataTable, ByVal parConsignacao As Boolean, Optional ByVal parTamanho As String = "", Optional ByVal parComanda As Boolean = False, Optional ByVal parPreco As Double = 0, Optional ByVal parNomeProduto As String = "", Optional ByVal parPromocao As Boolean = False, Optional ByVal parUniSemDesc As Double = 0, Optional ByVal parDesconto As Double = 0, Optional ByVal parQtdMedida As Double = 0)

        Dim strTamanhoCod As String = ""
        Dim strCodProTam As String = ""


        'If dtProd.Rows.Count > 0 Then

        '    If NomeEmpresa.Replace("Ã", "A").Trim.Contains("CAVALAO") = True Then
        '        If dtProd.Rows.Item(0).Item("CodigoBarra").ToString <> "" Then
        '            Me.txtCodPro.Text = dtProd.Rows.Item(0).Item("CodigoBarra")
        '        Else
        '            Me.txtCodPro.Text = dtProd.Rows.Item(0).Item("CodigoInterno")
        '        End If

        '    Else
        '        Me.txtCodPro.Text = dtProd.Rows.Item(0).Item("CodigoInterno")
        '    End If
        Dim strUniMed As String = ""
        If dtProd.Rows.Count > 0 Then
            If parConsignacao = False Then
                Me.txtPorDesc.Text = "0,00"
                Me.txtValDesc.Text = "0,00"
            End If

            With dtProd.Rows.Item(0)
                Dim intCodProdAut As Integer


                Dim bolInativo As Boolean = dtProd.Rows.Item(0).Item("Inativo")

                If bolInativo = True Then
                    MsgBox("Produto inativo!", MsgBoxStyle.Information)
                    Me.txtCodPro.ResetText()
                    Me.txtQtd.ResetText()
                    Exit Sub
                End If


                intCodProdAut = .Item(0).ToString
                strUniMed = .Item("UnidadeMedida").ToString



                If VerificaImposto(intCodProdAut) = False Then Exit Sub

                If strTamanhoCod = "" Then
                    TamanhoDoProduto = "U"
                End If


                Dim strNomeProduto As String = .Item(1).ToString '& " " & intContDiversos
                If AlteraNomePedido = True Then
                    If parNomeProduto <> "" Then
                        strNomeProduto = parNomeProduto '& " " & intContDiversos
                    End If
                End If

                Dim strSql As String = "Select Tamanho, sum(Qtd) as Qtd from Qtde where CodProd =" & intCodProdAut & " and Acabou = 'False' and CodConfig =" & CodConfig & " group by Tamanho"

                Dim dtQtd As DataTable = CarregarDataTable(strSql)



                If parConsignacao = False Then
                    If parComanda = True Then
                        TamanhoDoProduto = strTamanhoCod
                    Else
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
                    End If
                Else
                    TamanhoDoProduto = parTamanho
                End If

                If PermiteEstoqueZerado = False Then

                    If EstoqueSomado = False Then
                        If dtQtd.Rows.Count = 0 Then
                            MsgBox("Não existem quantidades desse produto em estoque!", MsgBoxStyle.Information)
                            Me.txtCodPro.ResetText()
                            Me.txtQtd.ResetText()
                            Exit Sub
                        Else

                            Dim dtQtd2 As DataTable = CarregarDataTable("Select sum(Qtd) as Qtd from Qtde where CodProd =" & intCodProdAut & " and Tamanho ='" & TamanhoDoProduto & "' and Acabou = 'False' and CodConfig =" & CodConfig)

                            Dim dblQtdAdd As Double

                            If Me.txtQtd.Text = "" Then
                                dblQtdAdd = 1
                            Else
                                dblQtdAdd = Me.txtQtd.Text.Trim
                            End If

                            Dim dblQtdTabQtde As Double = dtQtd2.Rows(0).Item("Qtd").ToString

                            If dblQtdAdd > dblQtdTabQtde Then
                                MsgBox("Não existe a quantidade adicionada desse produto em estoque!", MsgBoxStyle.Information)
                                Me.txtCodPro.ResetText()
                                Me.txtQtd.ResetText()
                                Exit Sub
                            End If

                        End If
                    Else

                        Dim dblResul As Double = AjusteQtde(CodConfig, intCodProdAut)

                        If dblResul <= 0 Then
                            MsgBox("Não existem quantidades desse produto em estoque!", MsgBoxStyle.Information)
                            Me.txtCodPro.ResetText()
                            Me.txtQtd.ResetText()
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
                                Me.txtCodPro.ResetText()
                                Me.txtQtd.ResetText()
                                Exit Sub
                            End If
                        End If


                    End If


                End If

                Me.txtCodPro.Tag = intCodProdAut


                If parComanda = False Then

                    Me.txtProd.Text = strNomeProduto
                End If

                If parConsignacao = True Then
                    If AlteraPrecoPedido = True Then

                        Me.txtProd.Text = strNomeProduto '& " " & intContDiversos
                    End If
                End If
            End With
        Else
            Try

                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\aviso.wav")
                'PlaySound(My.Application.Info.DirectoryPath & "\aviso.mid")

            Catch ex As Exception

            End Try

            Me.txtProd.Text = "INEXISTENTE"
            Me.txtCodPro.ResetText()
            Me.txtQtd.ResetText()
            Me.txtPerDesc.ResetText()
            Me.txtValor.ResetText()
            MsgBox("Produto inexistente!", MsgBoxStyle.Information)
            Exit Sub
        End If



        'CALCULOS ANTES DE ADICIONAR

        Dim dblQtd, dblUni, dblCusto, dblTot, dblTotCus As Double

        If Me.txtQtd.Text.Trim <> "" Then
            dblQtd = Me.txtQtd.Text.Trim
        Else
            Me.txtQtd.Text = 1
            dblQtd = 1
        End If


        'If parComanda = False Then
        '    If JaInserido(Me.txtCodPro.Tag, TamanhoDoProduto) = True Then
        '        Me.txtCodPro.Tag = ""
        '        Me.txtCodPro.ResetText()
        '        Me.txtQtd.ResetText()

        '        intCont = 0

        '        Calcular()
        '        Exit Sub
        '    End If
        'End If

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


        Dim dt As DataTable = CarregarDataTable("Select Codigo, Qtd, ValorCusto from Qtde where CodProd = " & Me.txtCodPro.Tag & " and Tamanho ='" & TamanhoDoProduto & "' and CodConfig =" & CodConfig & " order by Codigo asc")

        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item("ValorCusto").ToString <> "" Then
                dblCusto = dt.Rows.Item(0).Item("ValorCusto").ToString
            Else
                dblCusto = dtProd.Rows.Item(0).Item(3).ToString
            End If

        Else
            dblCusto = dtProd.Rows.Item(0).Item(3).ToString
        End If


        dblUni = Me.txtValor.Text.Trim

        Dim dblPerDesc, dblResto As Double
        Dim bolPromocao As Boolean = False
        If parConsignacao = False Then
            If dtProd.Rows.Item(0).Item("Desconto").ToString <> "" And dtProd.Rows.Item(0).Item("Desconto").ToString <> "0" And dtProd.Rows.Item(0).Item("Desconto").ToString <> "0,000" And dtProd.Rows.Item(0).Item("Desconto").ToString <> "0,00" Then
                dblPerDesc = dtProd.Rows.Item(0).Item("Desconto").ToString

                dblResto = (dblUni / 100) * dblPerDesc

                dblUni = dblUni - dblResto
                Me.txtValor.Text = dblUni.ToString("0.000")
                bolPromocao = True

            Else

                If Me.txtPerDesc.Text.Trim <> "" And Me.txtPerDesc.Text.Trim <> "0,00" Then
                    dblPerDesc = Me.txtPerDesc.Text.Trim

                    dblResto = (dblUni / 100) * dblPerDesc

                    dblUni = dblUni - dblResto
                    Me.txtValor.Text = dblUni.ToString("0.000")
                    bolPromocao = True
                End If

            End If
        Else
            bolPromocao = parPromocao

        End If



        dblTot = dblQtd * dblUni
        dblTotCus = dblCusto

        Me.picFundo.Visible = False

        With Me.tbItens.Rows
            CarregarImagemProduto(Me.txtCodPro.Tag)
            .Add()

            .Item(.Count - 1).Item("CodProdAut") = Me.txtCodPro.Tag
            .Item(.Count - 1).Item("CodProd") = Me.txtCodPro.Text.Trim
            .Item(.Count - 1).Item("Produto") = Me.txtProd.Text.Trim
            .Item(.Count - 1).Item("Qtde") = dblQtd.ToString("0.000")
            .Item(.Count - 1).Item("Unitario") = dblUni.ToString("0.000")
            .Item(.Count - 1).Item("Total") = dblTot.ToString("0.00")
            .Item(.Count - 1).Item("Custo") = dblTotCus.ToString("0.00")
            .Item(.Count - 1).Item("UM") = strUniMed
            .Item(.Count - 1).Item("CodFunc") = intCodFunc
            .Item(.Count - 1).Item("CodMecanico") = intCodMecanico
            .Item(.Count - 1).Item("Tamanho") = TamanhoDoProduto
            If parConsignacao = False Then
                .Item(.Count - 1).Item("Desconto") = dblPerDesc.ToString("0.00")
            Else
                .Item(.Count - 1).Item("Desconto") = parDesconto
            End If
            .Item(.Count - 1).Item("TipoProduto") = dtProd.Rows.Item(0).Item("Tipo").ToString

            .Item(.Count - 1).Item("Promocao") = bolPromocao
            'If parComanda = False Then

            'Else
            '    .Item(.Count - 1).Item("ValorSemDesconto") = dblUni.ToString("0.00")
            'End If

            If parConsignacao = False Then
                If parComanda = False Then
                    .Item(.Count - 1).Item("ValorSemDesconto") = dblUni.ToString("0.00")
                    Dim sasad As Double = dblTot.ToString("0.00")
                Else
                    .Item(.Count - 1).Item("ValorSemDesconto") = dblUni.ToString("0.00")
                End If
            Else
                .Item(.Count - 1).Item("ValorSemDesconto") = parUniSemDesc
            End If
            'Else
            '.Item(.Count - 1).Item("ValorSemDesconto") = parUniSemDesc
            'End If

            .Item(.Count - 1).Item("ComissaoProduto") = dtProd.Rows.Item(0).Item("Comissao").ToString
            .Item(.Count - 1).Item("QtdMedida") = parQtdMedida

            .Item(.Count - 1).Item("CodigoBarra") = dtProd.Rows.Item(0).Item("CodigoBarra").ToString
            .Item(.Count - 1).Item("CodigoInterno") = dtProd.Rows.Item(0).Item("CodigoInterno").ToString
        End With
        strUniMed = ""
        Me.txtCodPro.Tag = ""
        Me.txtCodPro.ResetText()
        Me.txtQtd.ResetText()
        Me.txtValor.Properties.ReadOnly = True

        intCont = 0
        'intContDiversos = intContDiversos + 1
        Calcular()
        EntradaPedido()
        'Me.txtCodPro.Focus()


    End Sub
    Public Sub InserirProduto(ByVal parPesquisaPorNome As Boolean, ByVal parConsignacao As Boolean, _
    ByVal parCodigoFuncionario As String, ByVal parTabelaPreco As String, Optional ByVal parTamanho As String = "", Optional ByVal parComanda As Boolean = False, _
    Optional ByVal parPreco As Double = 0, Optional ByVal parNomeProduto As String = "", Optional ByVal parPromocao As Boolean = False, _
    Optional ByVal parUniSemDesc As Double = 0, Optional ByVal parDesconto As Double = 0, Optional ByVal parQtdMedida As Double = 0, _
    Optional ByVal parValorCusto As Double = 0, Optional ByVal parCodigoInterno As String = "")

        'If TipoNano <> 5 Then

        If lblVend2.Caption.Trim = "" Then
            If parCodigoFuncionario = "" Then
                InserirVendedor()
            End If
        End If
        'End If
        parCodigoFuncionario = intCodFunc

        Dim strTamanhoCod As String = ""
        Dim strCodProTam As String = ""
        If Me.txtRec.Text.Trim <> "" Then
            CancelarPagamento(False)
            EntradaPedido()
        End If

        Dim dtProd As DataTable

        Dim strUniMed As String = ""
        Dim dblValProd As Double


        If parPesquisaPorNome = False Then

            If Me.txtCodPro.Text.Trim = "" Then Exit Sub
            Dim strTipoProd As String = ""
            If TipoNano = 5 Then
                Select Case Me.rdgTipoProd.SelectedIndex
                    Case 0
                        strTipoProd = " and Tipo <> 'SERVIÇO' "
                    Case 1
                        strTipoProd = " and Tipo = 'SERVIÇO' "
                End Select
            End If
            Dim vetCod As Array = Split(Me.txtCodPro.Text.Trim, "-")
            strCodProTam = vetCod(0).ToString
            Me.txtCodPro.Text = strCodProTam
            If vetCod.Length > 1 Then
                strTamanhoCod = vetCod(1).ToString
            End If

            If NomeEmpresa.Replace("Ã", "A").Trim.Contains("CAVALAO") = True Then
                dtProd = CarregarDataTable("Select Codigo, Nome, UnidadeMedida, ValorCusto, Valor, Desconto, Comissao, Inativo, Grupo, AlterarPreco, Tipo, CodigoBarra, CodigoInterno, Porcentagens from Produto where CodigoBarra ='" & Me.txtCodPro.Text.Trim & "'" & strTipoProd)
            Else
                If ManterMargemProd = True Then
                    dtProd = CarregarDataTable("Select Codigo, Nome, UnidadeMedida, ValorCusto, Valor, Desconto, Comissao, Inativo, Grupo, AlterarPreco, Tipo, CodigoBarra, CodigoInterno, Porcentagens from Produto where CodigoInterno ='" & Me.txtCodPro.Text.Trim & "' " & strTipoProd & " or CodigoBarra ='" & Me.txtCodPro.Text.Trim & "'" & strTipoProd)
                Else
                    dtProd = CarregarDataTable("Select Codigo, Nome, UnidadeMedida, ValorCusto, Valor, Desconto, Comissao, Inativo, Grupo, AlterarPreco, Tipo, CodigoBarra, CodigoInterno, Porcentagens from Produto where Tipo <> 'CONSUMO' and CodigoInterno ='" & Me.txtCodPro.Text.Trim & "' or CodigoBarra ='" & Me.txtCodPro.Text.Trim & "' and Tipo <> 'CONSUMO'")

                End If
            End If

            If dtProd.Rows.Count = 0 Then
                If InserirProdutoBalanca(Me.txtCodPro.Text) = True Then
                    Exit Sub
                End If
            End If

            If dtProd.Rows.Count = 0 Then
                Dim dtCodBarra As DataTable = CarregarDataTable("SELECT CodProd FROM CodigoBarra where CodigoBarra = '" & Me.txtCodPro.Text & "' and Produto = '' or CodigoBarra = '" & Me.txtCodPro.Text & "' and Produto is null")
                If dtCodBarra.Rows.Count > 0 Then
                    CodigoDoProduto = dtCodBarra.Rows.Item(0).Item("CodProd").ToString
                    dtProd = CarregarDataTable("Select Codigo, Nome, UnidadeMedida, ValorCusto, Valor, CodigoInterno, Desconto, CodigoBarra, Comissao, Inativo, Grupo, AlterarPreco, Tipo, Porcentagens from Produto where Codigo=" & CodigoDoProduto & strTipoProd)
                End If
            End If
        Else
            dtProd = CarregarDataTable("Select Codigo, Nome, UnidadeMedida, ValorCusto, Valor, CodigoInterno, Desconto, CodigoBarra, Comissao, Inativo, Grupo, AlterarPreco, Tipo, Porcentagens from Produto where Codigo=" & CodigoDoProduto)
            If dtProd.Rows.Count > 0 Then

                If NomeEmpresa.Replace("Ã", "A").Trim.Contains("CAVALAO") = True Then
                    If dtProd.Rows.Item(0).Item("CodigoBarra").ToString <> "" Then
                        Me.txtCodPro.Text = dtProd.Rows.Item(0).Item("CodigoBarra")
                    Else
                        Me.txtCodPro.Text = dtProd.Rows.Item(0).Item("CodigoInterno")
                    End If

                Else
                    Me.txtCodPro.Text = dtProd.Rows.Item(0).Item("CodigoInterno")
                End If

            End If
        End If

        If dtProd.Rows.Count > 0 Then


            If parConsignacao = False Then
                Me.txtPorDesc.Text = "0,00"
                Me.txtValDesc.Text = "0,00"
            End If

            With dtProd.Rows.Item(0)
                Dim intCodProdAut As Integer


                Dim bolInativo As Boolean = dtProd.Rows.Item(0).Item("Inativo")

                If bolInativo = True Then
                    MsgBox("Produto inativo!", MsgBoxStyle.Information)
                    Me.txtCodPro.ResetText()
                    Me.txtQtd.ResetText()
                    bolDigQtd = False
                    Exit Sub
                End If


                intCodProdAut = .Item(0).ToString
                strUniMed = .Item("UnidadeMedida").ToString

                Try
                    bolAltPreco = dtProd.Rows.Item(0).Item("AlterarPreco").ToString
                Catch ex As Exception
                    bolAltPreco = False
                End Try

                If dtProd.Rows.Item(0).Item("Tipo").ToString <> "SERVIÇO" Then
                    If VerificaImposto(intCodProdAut) = False Then Exit Sub
                End If


                If strTamanhoCod = "" Then
                    TamanhoDoProduto = "U"
                End If


                Dim strNomeProduto As String = .Item(1).ToString
                If AlteraNomePedido = True Then
                    If parNomeProduto <> "" Then
                        strNomeProduto = parNomeProduto
                    End If
                End If

           

                Dim strSql As String = "Select Tamanho, sum(Qtd) as Qtd from Qtde where CodProd =" & intCodProdAut & " and Acabou = 'False' and CodConfig =" & CodConfig & " group by Tamanho"

                Dim dtQtd As DataTable = CarregarDataTable(strSql)



                If parConsignacao = False Then
                    If parComanda = True Then
                        TamanhoDoProduto = strTamanhoCod
                    Else
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
                    End If
                Else
                    TamanhoDoProduto = parTamanho
                End If

                If PermiteEstoqueZerado = False Then

                    If BloquearEstoqueZeradoConfig = False Then

                        If dtProd.Rows.Item(0).Item("Tipo").ToString <> "SERVIÇO" Then
                            If EstoqueSomado = False Then
                                If dtQtd.Rows.Count = 0 Then
                                    MsgBox("Não existem quantidades desse produto em estoque!", MsgBoxStyle.Information)
                                    Me.txtCodPro.ResetText()
                                    Me.txtQtd.ResetText()
                                    bolDigQtd = False
                                    Exit Sub
                                Else

                                    Dim dtQtd2 As DataTable = CarregarDataTable("Select sum(Qtd) as Qtd from Qtde where CodProd =" & intCodProdAut & " and Tamanho ='" & TamanhoDoProduto & "' and Acabou = 'False' and CodConfig =" & CodConfig)

                                    Dim dblQtdAdd As Double

                                    If Me.txtQtd.Text = "" Then
                                        dblQtdAdd = 1
                                    Else
                                        dblQtdAdd = Me.txtQtd.Text.Trim
                                    End If

                                    Dim dblQtdTabQtde As Double = 0

                                    If dtQtd2.Rows(0).Item("Qtd").ToString <> "" Then
                                        dblQtdTabQtde = dtQtd2.Rows(0).Item("Qtd").ToString
                                    End If

                                    If dblQtdAdd > dblQtdTabQtde Then
                                        MsgBox("Não existe a quantidade adicionada desse produto em estoque!", MsgBoxStyle.Information)
                                        Me.txtCodPro.ResetText()
                                        Me.txtQtd.ResetText()
                                        bolDigQtd = False
                                        Exit Sub
                                    End If

                                End If
                            Else

                                Dim dblResul As Double = AjusteQtde(CodConfig, intCodProdAut)


                                If dblResul <= 0 Then

                                    MsgBox("Não existem quantidades desse produto em estoque!", MsgBoxStyle.Information)
                                    Me.txtCodPro.ResetText()
                                    Me.txtQtd.ResetText()
                                    bolDigQtd = False
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
                                        Me.txtCodPro.ResetText()
                                        Me.txtQtd.ResetText()
                                        bolDigQtd = False
                                        Exit Sub
                                    End If
                                End If


                            End If
                        End If
                    End If

                    

                End If

                Me.txtCodPro.Tag = intCodProdAut


                If parComanda = False Then
                    dblValProd = CampoValor(.Item(4))

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
                    Me.txtProd.Text = strNomeProduto
                End If


                If parTabelaPreco <> "PADRÃO" Then
                    Dim dt As DataTable = CarregarDataTable("Select Codigo From Grupo Where Nome='" & parTabelaPreco & "'")
                    intCodTabelaPreco = dt.Rows.Item(0).Item("Codigo").ToString
                    Dim dtTabPrec As DataTable = CarregarDataTable("Select Valor From TabelaPreco where CodProd =" & intCodProdAut & " and CodTabela =" & intCodTabelaPreco)

                    If dtTabPrec.Rows.Count > 0 Then
                        dblValProd = CampoValor(dtTabPrec.Rows.Item(0).Item("Valor"))
                        Me.txtValor.Text = CampoValor(dblValProd)
                    Else
                        Me.txtValor.Text = "0,00"
                    End If

                End If

                If parConsignacao = True Then
                    If AlteraPrecoPedido = True Then
                        dblValProd = CampoValor(parPreco)
                        Me.txtValor.Text = CampoValor(dblValProd)
                        Me.txtProd.Text = strNomeProduto
                    Else
                        If bolAltPreco = True Then
                            dblValProd = CampoValor(parPreco)
                            Me.txtValor.Text = CampoValor(dblValProd)
                            Me.txtProd.Text = strNomeProduto
                        End If
                    End If
                End If
            End With
        Else
            Try

                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\aviso.wav")
                'PlaySound(My.Application.Info.DirectoryPath & "\aviso.mid")

            Catch ex As Exception

            End Try

            Me.txtProd.Text = "INEXISTENTE"
            Me.txtCodPro.ResetText()
            Me.txtQtd.ResetText()
            Me.txtPerDesc.ResetText()
            Me.txtValor.ResetText()
            MsgBox("Produto inexistente!", MsgBoxStyle.Information)
            bolDigQtd = False
            Exit Sub
        End If

        If bolConsultaPreco = True Then
            Me.txtCodPro.ResetText()
            intCont = 0
            CarregarImagemProduto(Me.txtCodPro.Tag)
            Exit Sub
        End If


        If Me.txtProd.Text = "DIVERSOS" And Me.txtCodPro.Text = "1" And parConsignacao = False Then
            Me.txtValor.ResetText()
            Me.txtValor.Properties.ReadOnly = False
            Me.txtValor.Focus()
            dtProdutoEnter = dtProd

        ElseIf bolAltPreco = True And parConsignacao = False And parComanda = False Then
            'If TipoNano <> "5" Then
            '    Me.txtValor.ResetText()
            'End If
            Me.txtValor.Properties.ReadOnly = False
            Me.txtValor.Focus()
            dtProdutoEnter = dtProd
        Else

            'CALCULOS ANTES DE ADICIONAR

            Dim dblQtd, dblUni, dblCusto, dblTot, dblTotCus As Double

            If Me.txtQtd.Text.Trim <> "" Then
                dblQtd = Me.txtQtd.Text.Trim
            Else
                Me.txtQtd.Text = 1
                dblQtd = 1
            End If


            'If parComanda = False Then
            If JaInserido(Me.txtCodPro.Tag, TamanhoDoProduto) = True Then
                Me.txtCodPro.Tag = ""
                Me.txtCodPro.ResetText()
                Me.txtQtd.ResetText()
                If strDescontoCliente = "" Then
                    Me.txtPerDesc.ResetText()
                Else
                    Me.txtPerDesc.Text = strDescontoCliente
                End If
                intCont = 0

                Calcular()
                EntradaPedido()
                bolDigQtd = False
                Exit Sub
            End If
            'End If

            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            If EstoqueSomado = False Then
                Dim dt As DataTable = CarregarDataTable("Select Codigo, Qtd, ValorCusto from Qtde where CodProd = " & Me.txtCodPro.Tag & " and Tamanho ='" & TamanhoDoProduto & "' and CodConfig =" & CodConfig & " order by Codigo asc")

                If dt.Rows.Count > 0 Then
                    If dt.Rows.Item(0).Item("ValorCusto").ToString <> "" Then
                        dblCusto = dt.Rows.Item(0).Item("ValorCusto").ToString
                    Else
                        dblCusto = dtProd.Rows.Item(0).Item(3).ToString
                    End If

                Else
                    dblCusto = dtProd.Rows.Item(0).Item(3).ToString
                End If

            Else
                dblCusto = dtProd.Rows.Item(0).Item(3).ToString
                If parConsignacao = True Then
                    If AlteraPrecoPedido = True Then
                        If parValorCusto >= 0 Then
                            dblCusto = parValorCusto
                        End If
                    Else
                        If bolAltPreco = True Then
                            If parValorCusto >= 0 Then
                                dblCusto = parValorCusto
                            End If

                        End If
                    End If
                End If
            End If



            dblUni = Me.txtValor.Text.Trim

            Dim dblPerDesc, dblResto As Double
            Dim bolPromocao As Boolean = False
            If parConsignacao = False Then
                If dtProd.Rows.Item(0).Item("Desconto").ToString <> "" And dtProd.Rows.Item(0).Item("Desconto").ToString <> "0" And dtProd.Rows.Item(0).Item("Desconto").ToString <> "0,000" And dtProd.Rows.Item(0).Item("Desconto").ToString <> "0,00" Then
                    If CNPJEmpresa = "26338033000130" Then
                        If Me.txtCli.Text <> "CONSUMIDOR" Then

                            dblPerDesc = dtProd.Rows.Item(0).Item("Desconto").ToString

                            dblResto = (dblUni / 100) * dblPerDesc

                            dblUni = dblUni - dblResto
                            Me.txtValor.Text = CampoValor(dblUni)
                            bolPromocao = True
                        End If

                    Else
                        dblPerDesc = dtProd.Rows.Item(0).Item("Desconto").ToString

                        dblResto = (dblUni / 100) * dblPerDesc

                        dblUni = dblUni - dblResto
                        Me.txtValor.Text = CampoValor(dblUni)
                        bolPromocao = True

                    End If

                Else
                    If Me.lblDesc.Text = "Desc. %" Then
                        If Me.txtPerDesc.Text.Trim <> "" And Me.txtPerDesc.Text.Trim <> "0,00" Then
                            dblPerDesc = Me.txtPerDesc.Text.Trim

                            dblResto = (dblUni / 100) * dblPerDesc

                            dblUni = dblUni - dblResto
                            Me.txtValor.Text = CampoValor(dblUni)
                            bolPromocao = True
                        End If
                    Else
                        If Me.txtPerDesc.Text.Trim <> "" And Me.txtPerDesc.Text.Trim <> "0,00" Then
                            dblPerDesc = Me.txtPerDesc.Text.Trim

                            Dim dblResulVal As Double = (dblUni - dblPerDesc)
                            Dim strNomeProd As String = Me.txtProd.Text

                            dblPerDesc = dblPerDesc * 100

                            dblPerDesc = dblPerDesc / dblUni
                            dblPerDesc = dblPerDesc.ToString("0.0000")
                            Me.txtPerDesc.Text = dblPerDesc

                            If DescontoMaximo <> "" Then
                                If Nivel = "USUÁRIO" Then
                                    If CDbl(txtPerDesc.Text) > CDbl(DescontoMaximo) Then
                                        MsgBox("Desconto é maior do que o permitido, digite a senha de um usuário com nível de ADMINISTRADOR!", MsgBoxStyle.Information)
                                        If SenhaEstaOK() = False Then
                                            MsgBox("Desconto maior que o permitido!", MsgBoxStyle.Information)
                                            Me.txtPerDesc.ResetText()
                                            Me.txtCodPro.ResetText()
                                            Me.txtQtd.ResetText()
                                            bolDigQtd = False
                                            Exit Sub
                                        End If

                                    End If
                                End If

                            End If
                            Me.txtProd.Text = strNomeProd
                            If CasaDecimal = "2" Or CasaDecimal = "3" Then
                                dblUni = dblResulVal.ToString("0.00")
                                Me.txtValor.Text = dblUni.ToString("0.000")
                            Else

                                Me.txtValor.Text = CampoValor(dblResulVal)
                            End If

                            bolPromocao = True

                        End If



                    End If


                End If
            Else
                ''''''''verificar
                'If parDesconto.ToString <> "" And parDesconto.ToString <> "0" And parDesconto.ToString <> "0,000" And parDesconto.ToString <> "0,00" Then
                '    dblPerDesc = parDesconto

                '    dblResto = (dblUni / 100) * dblPerDesc

                '    dblUni = dblUni - dblResto
                '    Me.txtValor.Text = dblUni.ToString("0.000")
                '    bolPromocao = True
                'Else
                '    bolPromocao = parPromocao
                'End If
                bolPromocao = parPromocao
            End If

            If parCodigoInterno <> "" Then
                Me.txtCodPro.Text = parCodigoInterno
            End If

            dblTot = dblQtd * dblUni
            dblTotCus = dblCusto

            Me.picFundo.Visible = False

            With Me.tbItens.Rows
                CarregarImagemProduto(Me.txtCodPro.Tag)
                .Add()

                .Item(.Count - 1).Item("CodProdAut") = Me.txtCodPro.Tag
                .Item(.Count - 1).Item("CodProd") = Me.txtCodPro.Text.Trim
                .Item(.Count - 1).Item("Produto") = Me.txtProd.Text.Trim
                .Item(.Count - 1).Item("Qtde") = dblQtd.ToString("0.000")
                .Item(.Count - 1).Item("Unitario") = CampoValor(dblUni)
                .Item(.Count - 1).Item("Total") = dblTot.ToString("0.00")
                .Item(.Count - 1).Item("Custo") = dblTotCus.ToString("0.00")
                .Item(.Count - 1).Item("UM") = strUniMed
                .Item(.Count - 1).Item("CodFunc") = parCodigoFuncionario
                .Item(.Count - 1).Item("CodMecanico") = intCodMecanico
                .Item(.Count - 1).Item("Tamanho") = TamanhoDoProduto
                .Item(.Count - 1).Item("TipoProduto") = dtProd.Rows.Item(0).Item("Tipo").ToString

                .Item(.Count - 1).Item("CodigoInterno") = dtProd.Rows.Item(0).Item("CodigoInterno").ToString
                .Item(.Count - 1).Item("CodigoBarra") = dtProd.Rows.Item(0).Item("CodigoBarra").ToString

                If parConsignacao = False Then
                    .Item(.Count - 1).Item("Desconto") = dblPerDesc.ToString("0.0000")
                Else
                    .Item(.Count - 1).Item("Desconto") = parDesconto
                End If

                If bolPromocao = True Then
                    bolPromocao = bolPromocao
                End If

                .Item(.Count - 1).Item("Promocao") = bolPromocao
                'If parComanda = False Then

                'Else
                '    .Item(.Count - 1).Item("ValorSemDesconto") = dblUni.ToString("0.00")
                'End If

                If parConsignacao = False Then
                    If parComanda = False Then
                        If Me.lblTabela.Caption.Trim = "PADRÃO" Then
                            .Item(.Count - 1).Item("ValorSemDesconto") = CampoValor(dtProd.Rows.Item(0).Item("Valor").ToString)
                        Else
                            .Item(.Count - 1).Item("ValorSemDesconto") = CampoValor(dblUni)
                        End If
                    Else
                        .Item(.Count - 1).Item("ValorSemDesconto") = CampoValor(dblUni)
                    End If
                Else
                    .Item(.Count - 1).Item("ValorSemDesconto") = CampoValor(parUniSemDesc)
                End If
                'Else
                '.Item(.Count - 1).Item("ValorSemDesconto") = parUniSemDesc
                'End If

                .Item(.Count - 1).Item("ComissaoProduto") = dtProd.Rows.Item(0).Item("Comissao").ToString
                .Item(.Count - 1).Item("QtdMedida") = parQtdMedida

                .Item(.Count - 1).Item("Grupo") = dtProd.Rows.Item(0).Item("Grupo").ToString

                Dim dtCampanha As DataTable = CarregarDataTable("Select ValorAnt from Campanha Where CodProd = " & Me.txtCodPro.Tag & " and Status = 'Lancado'")

                If dtCampanha.Rows.Count > 0 Then
                    If dtCampanha.Rows.Item(0).Item("ValorAnt").ToString <> "" Then
                        Dim dblValorAnt As Double = dtCampanha.Rows.Item(0).Item("ValorAnt").ToString
                        'If dtPed.Rows.Item(I).Item("ValorUnitario").ToString <> "" Then
                        Dim dblVal As Double = CampoValor(dblUni)
                        If dblValorAnt > dblVal Then
                            Dim dblPorcAnt As Double = ((dblValorAnt - dblVal) * 100) / dblValorAnt
                            .Item(.Count - 1).Item("ValorAnt") = CampoValor(dblValorAnt)
                            .Item(.Count - 1).Item("ValorAntPorc") = dblPorcAnt.ToString("0.00")
                        End If
                        'End If
                    End If
                End If

                Dim dtLoc As DataTable = CarregarDataTable("Select Locacao from Locacao Where CodProd = " & Me.txtCodPro.Tag & " and CodConfig = " & CodConfig)
                If dtLoc.Rows.Count > 0 Then
                    .Item(.Count - 1).Item("Locacao") = dtLoc.Rows.Item(0).Item("Locacao").ToString
                End If
                .Item(.Count - 1).Item("ValorFrete") = "0,00"
                .Item(.Count - 1).Item("TabelaPreco") = parTabelaPreco
            End With

            Me.txtCodPro.Tag = ""
            Me.txtCodPro.ResetText()
            Me.txtQtd.ResetText()
            If strDescontoCliente = "" Then
                Me.txtPerDesc.ResetText()
            Else
                Me.txtPerDesc.Text = strDescontoCliente
            End If
            Me.txtValor.Properties.ReadOnly = True

            intCont = 0

            Calcular()
            EntradaPedido()
        End If

        bolDigQtd = False
    End Sub


    Private Function VerificaImposto(ByVal parCodigo As String) As Boolean
        If PafEcfNano = True Then
            Dim dtImp As DataTable = CarregarDataTable("SELECT ICMS, Tributacao, NCM, OrigemICMS FROM ImpostoProduto where CodProd = " & parCodigo)
            If dtImp.Rows.Count > 0 Then
                Dim strTrib As String = dtImp.Rows.Item(0).Item("Tributacao").ToString
                Dim dblICMS As Double = dtImp.Rows.Item(0).Item("ICMS")
                Dim strICMS As String = dblICMS.ToString("0.00")
                Dim strNCM As String = dtImp.Rows.Item(0).Item("NCM").ToString
                If Me.txtCodPro.Text = "" Then
                    MsgBox("Produto sem código!", MsgBoxStyle.Information)
                    Return False
                End If
                If strTrib = "" Then
                    MsgBox("Produto sem tributação!", MsgBoxStyle.Information)
                    Return False
                End If
                If strICMS = "" Then
                    MsgBox("Produto sem alíquota!", MsgBoxStyle.Information)
                    Return False
                End If
                If DeOlhoNoImposto = True Then
                    If strNCM = "" Then
                        MsgBox("Produto sem NCM!", MsgBoxStyle.Information)
                        Return False
                    End If
                End If

            Else
                MsgBox("Produto sem imposto cadastrado!", MsgBoxStyle.Information)
                Return False
            End If

            Return True
        End If


        If SATFiscal = True Then
            Dim dtProd As DataTable = CarregarDataTable("SELECT Codigo FROM Produto where TributacaoPadrao = 'True'")
            If dtProd.Rows.Count > 0 Then
                If dtProd.Rows.Item(0).Item("Codigo").ToString <> "" Then
                    Return True
                    Exit Function
                End If
            End If
            Dim dtNfe As DataTable = CarregarDataTable("SELECT CST, CFOP, NCM, Origem, NFe.Regime, " & _
            "ICMS, CSTPIS, CSTCOFINS FROM NFe left join Tributos on Nfe.CodProd = Tributos.CodProd and Nfe.Regime = Tributos.Regime " & _
            "where Nfe.CodProd = " & parCodigo & " and Nfe.Regime = '" & RegimeSAT & "' or  Nfe.CodProd = " & parCodigo & " and Nfe.Regime = '" & RegimeSAT & " SAT'")

            If dtNfe.Rows.Count > 0 Then
                Dim strCST As String = dtNfe.Rows.Item(0).Item("CST").ToString
                Dim strCFOP As String = dtNfe.Rows.Item(0).Item("CFOP").ToString
                Dim Origem As String = dtNfe.Rows.Item(0).Item("Origem").ToString
                Dim strNCM As String = dtNfe.Rows.Item(0).Item("NCM").ToString
                Dim strRegime As String = dtNfe.Rows.Item(0).Item("Regime").ToString
                Dim strAliquotaICMS As String = dtNfe.Rows.Item(0).Item("ICMS").ToString
                Dim strCSTPIS As String = dtNfe.Rows.Item(0).Item("CSTPIS").ToString
                Dim strCSTCOFINS As String = dtNfe.Rows.Item(0).Item("CSTCOFINS").ToString

                If Me.txtCodPro.Text = "" Then
                    MsgBox("Produto sem código!", MsgBoxStyle.Information)
                    Return False
                End If
                If strCST = "" Then
                    MsgBox("Produto sem tributação!", MsgBoxStyle.Information)
                    Return False
                End If
                If strCFOP = "" Then
                    MsgBox("Produto sem CFOP!", MsgBoxStyle.Information)
                    Return False
                End If
                If strNCM = "" Then
                    MsgBox("Produto sem NCM!", MsgBoxStyle.Information)
                    Return False
                End If
                If Origem = "" Then
                    MsgBox("Produto sem Origem!", MsgBoxStyle.Information)
                    Return False
                End If
                If strRegime = "" Then
                    MsgBox("Produto sem Regime!", MsgBoxStyle.Information)
                    Return False
                End If
                If strCST = "00" Or strCST = "20" Or strCST = "90" Or strCST = "900" Then
                    If strAliquotaICMS = "" Then
                        MsgBox("Produto sem Alíquota ICMS!", MsgBoxStyle.Information)
                        Return False
                    End If
                End If

                If strCSTPIS = "" Then
                    MsgBox("Produto sem CST PIS!", MsgBoxStyle.Information)
                    Return False
                End If
                If strCSTCOFINS = "" Then
                    MsgBox("Produto sem CST COFINS!", MsgBoxStyle.Information)
                    Return False
                End If


            Else
                MsgBox("Produto sem a parte fiscal cadastrada!", MsgBoxStyle.Information)
                Return False
            End If
        End If

        Return True
    End Function
    Private Function InserirProdutoBalanca(ByVal parCodBarra As String) As Boolean
        If parCodBarra.Length = 13 Then
            If parCodBarra.Substring(0, 1) = 2 Then
                Dim intCodProduto As Integer = parCodBarra.Substring(1, 6)
                If TipoBalanca.Contains("COM UM") = True Then
                    intCodProduto = parCodBarra.Substring(1, 5)
                ElseIf TipoBalanca.Contains("COM DOIS") = True Then
                    intCodProduto = parCodBarra.Substring(1, 4)
                End If

                Dim strCodigo As String = intCodProduto
                If AcrescentarZeroCodProd = True Then
                    Select Case strCodigo.Length
                        Case 1
                            strCodigo = "000" & strCodigo
                        Case 2
                            strCodigo = "00" & strCodigo
                        Case 3
                            strCodigo = "0" & strCodigo
                        Case 4
                        Case Else
                            If Not strCodigo.Length Mod 2 = 0 Then
                                strCodigo = "0" & strCodigo
                            End If
                    End Select
                End If

                Dim strTamanhoCod As String = ""
                Dim strCodProTam As String = ""

                Dim vetCod As Array = Split(strCodigo, "-")
                strCodProTam = vetCod(0).ToString
                Me.txtCodPro.Text = strCodProTam
                If vetCod.Length > 1 Then
                    strTamanhoCod = vetCod(1).ToString
                End If


                Dim dblQtd As Double
                Dim dtProd As DataTable = CarregarDataTable("Select Codigo, Nome, UnidadeMedida, ValorCusto, Valor, Desconto, Tipo, CodigoInterno, CodigoBarra from Produto where CodigoInterno ='" & strCodigo & "'")

                If dtProd.Rows.Count > 0 Then

                    With dtProd.Rows.Item(0)
                        Dim intCodProdAut As Integer

                        intCodProdAut = .Item(0).ToString

                        If VerificaImposto(intCodProdAut) = False Then Exit Function

                        Dim strUnidadeMedida As String = .Item("UnidadeMedida").ToString
                        Dim dblValProd As Double = .Item(4)
                        If BalancaPor = "VALOR" Then
                            Select Case strUnidadeMedida
                                Case "KG"
                                    Dim strQtdKg As String = parCodBarra.Substring(7, 5)
                                    Dim strQ As String = strQtdKg.Substring(0, 3)
                                    strQ = strQ & "," & strQtdKg.Substring(3, 2)
                                    dblQtd = strQ

                                    dblQtd = dblQtd / dblValProd
                                Case "UN"
                                    Dim strQtdKg As String = parCodBarra.Substring(7, 5)
                                    'dblQtd = parCodBarra.Substring(7, 5)
                                    Dim strQ As String = strQtdKg.Substring(0, 3)
                                    strQ = strQ & "," & strQtdKg.Substring(3, 2)
                                    dblQtd = strQ
                                    dblQtd = dblQtd / dblValProd
                            End Select
                        Else
                            Select Case strUnidadeMedida
                                Case "KG"
                                    Dim strQtdKg As String = parCodBarra.Substring(7, 5)
                                    Dim strQ As String = strQtdKg.Substring(0, 2)
                                    strQ = strQ & "," & strQtdKg.Substring(2, 3)
                                    dblQtd = strQ
                                Case "UN"
                                    dblQtd = parCodBarra.Substring(7, 5)
                            End Select

                        End If


                        Me.txtQtd.Text = dblQtd
                        TamanhoDoProduto = "U"

                        Dim strSql As String = "Select Tamanho, sum(Qtd) as Qtd from Qtde where CodProd =" & intCodProdAut & " and Acabou = 'False' and CodConfig =" & CodConfig & " group by Tamanho"

                        Dim dtQtd As DataTable = CarregarDataTable(strSql)

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



                        If PermiteEstoqueZerado = False Then
                            If dtQtd.Rows.Count = 0 Then
                                MsgBox("Não existem quantidades desse produto em estoque!", MsgBoxStyle.Information)
                                Me.txtCodPro.ResetText()
                                Me.txtQtd.ResetText()
                                Exit Function
                            Else

                                Dim dtQtd2 As DataTable = CarregarDataTable("Select sum(Qtd) as Qtd from Qtde where CodProd =" & intCodProdAut & " and Tamanho ='" & TamanhoDoProduto & "' and Acabou = 'False' and CodConfig =" & CodConfig)

                                Dim dblQtdAdd As Double


                                dblQtdAdd = dblQtd

                                Dim dblQtdTabQtde As Double = dtQtd2.Rows(0).Item("Qtd").ToString

                                If dblQtdAdd > dblQtdTabQtde Then
                                    MsgBox("Não existe a quantidade adicionada desse produto em estoque!", MsgBoxStyle.Information)
                                    Me.txtCodPro.ResetText()
                                    Me.txtQtd.ResetText()
                                    Exit Function
                                End If

                            End If

                        End If

                        Me.txtCodPro.Tag = intCodProdAut
                        Me.txtProd.Text = .Item(1).ToString
                        'Me.txtPerDesc.Text = .Item(2).ToString

                        Me.txtValor.Text = dblValProd.ToString("0.00")
                    End With
                Else
                    Me.txtProd.Text = "INEXISTENTE"
                    Me.txtCodPro.ResetText()
                    Me.txtQtd.ResetText()
                    Me.txtPerDesc.ResetText()
                    Me.txtValor.ResetText()
                    Exit Function
                End If

                'CALCULOS ANTES DE ADICIONAR

                Dim dblUni, dblCusto, dblTot, dblTotCus As Double


                If JaInserido(Me.txtCodPro.Tag, TamanhoDoProduto) = True Then
                    Me.txtCodPro.Tag = ""
                    Me.txtCodPro.ResetText()
                    Me.txtQtd.ResetText()

                    intCont = 0

                    Calcular()
                    EntradaPedido()
                    Return True
                    Exit Function
                End If

                Dim dt As DataTable = CarregarDataTable("Select Codigo, Qtd, ValorCusto from Qtde where CodProd = " & Me.txtCodPro.Tag & " and Tamanho ='" & TamanhoDoProduto & "' and CodConfig =" & CodConfig & " order by Codigo asc")

                If dt.Rows.Count > 0 Then
                    If dt.Rows.Item(0).Item("ValorCusto").ToString <> "" Then
                        dblCusto = dt.Rows.Item(0).Item("ValorCusto").ToString
                    Else
                        dblCusto = dtProd.Rows.Item(0).Item(3).ToString
                    End If

                Else
                    dblCusto = dtProd.Rows.Item(0).Item(3).ToString
                End If


                dblUni = Me.txtValor.Text.Trim

                Dim dblPerDesc, dblResto As Double
                Dim bolPromocao As Boolean = False

                If dtProd.Rows.Item(0).Item("Desconto").ToString <> "" And dtProd.Rows.Item(0).Item("Desconto").ToString <> "0" And dtProd.Rows.Item(0).Item("Desconto").ToString <> "0,000" And dtProd.Rows.Item(0).Item("Desconto").ToString <> "0,00" Then
                    dblPerDesc = dtProd.Rows.Item(0).Item("Desconto").ToString

                    dblResto = (dblUni / 100) * dblPerDesc

                    dblUni = dblUni - dblResto
                    Me.txtValor.Text = dblUni.ToString("0.00")
                    bolPromocao = True

                Else

                    If Me.txtPerDesc.Text.Trim <> "" And Me.txtPerDesc.Text.Trim <> "0,00" Then
                        dblPerDesc = Me.txtPerDesc.Text.Trim

                        dblResto = (dblUni / 100) * dblPerDesc

                        dblUni = dblUni - dblResto
                        Me.txtValor.Text = dblUni.ToString("0.00")
                        bolPromocao = True
                    End If

                End If


                dblTot = dblQtd * dblUni
                dblTotCus = dblCusto

                Me.picFundo.Visible = False
                With Me.tbItens.Rows
                    .Add()

                    .Item(.Count - 1).Item("CodProdAut") = Me.txtCodPro.Tag
                    .Item(.Count - 1).Item("CodProd") = Me.txtCodPro.Text.Trim
                    .Item(.Count - 1).Item("Produto") = Me.txtProd.Text.Trim
                    .Item(.Count - 1).Item("Qtde") = dblQtd.ToString("0.000")
                    .Item(.Count - 1).Item("Unitario") = dblUni.ToString("0.00")
                    .Item(.Count - 1).Item("Total") = dblTot.ToString("0.00")
                    .Item(.Count - 1).Item("Custo") = dblTotCus.ToString("0.00")
                    .Item(.Count - 1).Item("UM") = Me.txtPerDesc.Text.Trim
                    .Item(.Count - 1).Item("CodFunc") = intCodFunc
                    .Item(.Count - 1).Item("CodMecanico") = intCodMecanico
                    .Item(.Count - 1).Item("Tamanho") = TamanhoDoProduto
                    .Item(.Count - 1).Item("Desconto") = dblPerDesc.ToString("0.00")
                    .Item(.Count - 1).Item("Promocao") = bolPromocao
                    .Item(.Count - 1).Item("ValorSemDesconto") = dtProd.Rows.Item(0).Item("Valor").ToString
                    .Item(.Count - 1).Item("TipoProduto") = dtProd.Rows.Item(0).Item("Tipo").ToString
                    Dim dtLoc As DataTable = CarregarDataTable("Select Locacao from Locacao Where CodProd = " & Me.txtCodPro.Tag & " and CodConfig = " & CodConfig)
                    If dtLoc.Rows.Count > 0 Then
                        .Item(.Count - 1).Item("Locacao") = dtLoc.Rows.Item(0).Item("Locacao").ToString
                    End If

                    .Item(.Count - 1).Item("CodigoBarra") = dtProd.Rows.Item(0).Item("CodigoBarra").ToString
                    .Item(.Count - 1).Item("CodigoInterno") = dtProd.Rows.Item(0).Item("CodigoInterno").ToString
                End With

                Me.txtCodPro.Tag = ""
                Me.txtCodPro.ResetText()
                Me.txtQtd.ResetText()

                intCont = 0

                Calcular()
                EntradaPedido()
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If


    End Function
    Private Sub InserirDevolucao()

        Dim dt As DataTable

        dt = CarregarDataTable("SELECT Pedido.CodOrdem, Pedido.CodProd, Pedido.CodProdInterno, Pedido.Produto as Nome, " & _
        "Pedido.ValorUnitario, Pedido.UM, Pedido.Custo, Pedido.Tamanho, Pedido.Qtd, Produto.Comissao FROM Pedido left join " & _
        "Produto on Pedido.CodProd = Produto.Codigo where Pedido.Codigo = " & CodigoDaVenda)

        If dt.Rows.Count > 0 Then
            With Me.tbItens.Rows
                If lblVend2.Caption.Trim = "" Then

                    InserirVendedor()

                End If
        Dim dblQtde As Double

        If Me.txtQtd.Text <> "" Then
            dblQtde = Me.txtQtd.Text
        Else
            dblQtde = 1
        End If


        If dblQtde > CDbl(dt.Rows.Item(0).Item("Qtd")) Then
            MsgBox("A quantidade devolvida é maior que a quantidade vendida!", MsgBoxStyle.Information)
            Exit Sub
        End If

        If JaInseridoDevolucao(dt.Rows.Item(0).Item("CodProd").ToString, dt.Rows.Item(0).Item("Tamanho").ToString, dblQtde, dt.Rows.Item(0).Item("Qtd"), dt.Rows.Item(0).Item("CodOrdem")) = True Then
            Me.txtCodPro.Tag = ""
            Me.txtCodPro.ResetText()
            Me.txtQtd.ResetText()
                    Calcular()
                    EntradaPedido()
            Exit Sub
        End If


        Dim strCusto As String = CDbl(dt.Rows.Item(0).Item("Custo")) / CDbl(dt.Rows.Item(0).Item("Qtd"))

        Me.picFundo.Visible = False

        .Add()
        .Item(.Count - 1).Item("CodProdAut") = dt.Rows.Item(0).Item("CodProd").ToString
        .Item(.Count - 1).Item("CodProd") = dt.Rows.Item(0).Item("CodProdInterno").ToString
        .Item(.Count - 1).Item("Produto") = dt.Rows.Item(0).Item("Nome").ToString
        .Item(.Count - 1).Item("Qtde") = dblQtde.ToString("0.000")
        .Item(.Count - 1).Item("Unitario") = "-" & dt.Rows.Item(0).Item("ValorUnitario").ToString
        .Item(.Count - 1).Item("Total") = "-" & dt.Rows.Item(0).Item("ValorUnitario").ToString("0.00")
        .Item(.Count - 1).Item("Custo") = "-" & strCusto
        .Item(.Count - 1).Item("UM") = ""
        .Item(.Count - 1).Item("CodFunc") = intCodFunc
        .Item(.Count - 1).Item("CodMecanico") = intCodMecanico
        .Item(.Count - 1).Item("Tamanho") = dt.Rows.Item(0).Item("Tamanho").ToString
        .Item(.Count - 1).Item("Desconto") = 0
        .Item(.Count - 1).Item("Promocao") = True
        .Item(.Count - 1).Item("ValorSemDesconto") = "-" & dt.Rows.Item(0).Item("ValorUnitario").ToString
        .Item(.Count - 1).Item("CodVendaDev") = CodigoDaVenda
        .Item(.Count - 1).Item("ComissaoProduto") = dt.Rows.Item(0).Item("Comissao").ToString

            End With

            Me.txtCodPro.Tag = ""
            Me.txtCodPro.ResetText()
            Me.txtQtd.ResetText()

            intCont = 0
            Calcular()
            If Me.txtRec.Text.Trim <> "" Then
                CancelarPagamento(False)
            End If
        End If

    End Sub

    Private Sub FinalizarDevolucao(ByVal CodVendaDev As Integer, ByVal parIndex As Integer)

        Dim strCmd As String

        Dim dt As DataTable = CarregarDataTable("Select CodOrdem, Qtd, Custo, CodConfig from Pedido where Codigo =" & CodVendaDev)

        If dt.Rows.Count = 0 Then Exit Sub

        Dim intCodi, intCodProd, intCodLoja As Integer
        Dim dblValor, dblQtd, dblQtdDev, dblResul, dblResulValor, dblValorTotal, dblCustoTotal, dblCusPed As Double
        Dim strTamanho As String

        intCodi = dt.Rows.Item(0).Item("CodOrdem")
        intCodLoja = dt.Rows.Item(0).Item("CodConfig")
        intCodProd = Me.grd1.GetRowCellDisplayText(parIndex, Me.colCodProdAut)
        strTamanho = Me.grd1.GetRowCellDisplayText(parIndex, Me.colTamanho)
        dblValorTotal = Me.grd1.GetRowCellDisplayText(parIndex, Me.colTotal).Replace("-", "")
        dblValor = Me.grd1.GetRowCellDisplayText(parIndex, Me.colUnitario).Replace("-", "")
        dblQtd = dt.Rows.Item(0).Item("Qtd").ToString
        dblQtdDev = Me.grd1.GetRowCellDisplayText(parIndex, Me.colQtde)
        dblCustoTotal = CDbl(dt.Rows.Item(0).Item("Custo")) / dblQtd

        dblCusPed = dblCustoTotal * (dblQtd - dblQtdDev)

        If dblCusPed = 0 Then
            dblCusPed = dblCustoTotal
        End If

        If dblQtd > dblQtdDev Then
            dblResul = dblQtd - dblQtdDev
            dblResulValor = dblResul * dblValor
            'strCmd = "UPDATE Pedido SET Qtd = " & Num(dblResul) & ", ValorTotal = " & Num(dblResulValor) & ", Custo =" & Num(dblCusPed) & " where Codigo = " & CodVendaDev
            'Me.strCmdsSQL &= strCmd & vbCrLf & vbCrLf

        ElseIf dblQtd = dblQtdDev Then
            Dim bolDevol As Boolean
            bolDevol = True
            'strCmd = "UPDATE Pedido SET Devolvido = '" & bolDevol & "' where Codigo = " & CodVendaDev
            'Me.strCmdsSQL &= strCmd & vbCrLf & vbCrLf
        End If


        strCmd = "INSERT INTO Devolucao (CodProd, Qtde, CodCli, Data, CodFunc, Motivo, Tamanho, Valor, CodConfig) VALUES (" & intCodProd & "," & Num(dblQtdDev.ToString("0.000")) & ",'" & intCodCliente & "','" & Date.Today & "','" & intCodFunc & "','" & "DEVOLVIDO DA VENDA Nº " & intCodi & ", NA VENDA Nº " & intOrdem & ", CÓDIGO AUTOMÁTICO Nº " & CodVendaDev & "','" & strTamanho & "'," & Num(dblValor.ToString("0.00")) & "," & CodConfig & ")"
        Me.strCmdsSQL &= strCmd & vbCrLf & vbCrLf

        Dim dtPro As DataTable = CarregarDataTable("Select Nome from Produto where Codigo =" & intCodProd)

        If dtPro.Rows.Count > 0 Then
            If BaixaPorLote = True Then
                strCmd = "INSERT INTO Qtde (CodProd, Tamanho, Qtd, QtdMinima, Lote, EmFalta, ValorCusto, CodConfig, Acabou) VALUES (" & intCodProd & ",'" & strTamanho & "'," & Num(dblQtdDev.ToString("0.000")) & "," & "0" & ",'" & "DEVOLUÇÃO" & "','" & "0" & "'," & Num(dblCusPed.ToString("0.000")) & "," & CodConfig & ",'False')"
                Me.strCmdsSQL &= strCmd & vbCrLf & vbCrLf
            Else
                AlteraEstoque(intCodProd, dblQtdDev, "+", CodConfig)

                'If EstoqueSomado = True Then
                '    Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data) VALUES (" & intCodProd & "," & Num(dblQtdDev) & "," & CodConfig & ",'TROCA','" & My.Computer.Clock.LocalTime & "')")
                'End If
            End If

        Else
            MsgBox("O produto devolvido não está mais cadastrado, cadastre-o novamente e insira a Qtd no estoque manualmente!", MsgBoxStyle.Information)
        End If

    End Sub


    Private Function JaInserido(ByVal ParCodProdAut As Integer, ByVal parTamanho As String) As Boolean
        If AgruparProdutoVenda = False Then Exit Function

        Dim Y As Integer

        Dim intCodProdGrid As Integer
        Dim strTamanhoGrid As String
        Dim bolInserido As Boolean = False

        'If EstoqueSomado = True Then
        '    If intCodPedido <> 0 Then
        '        Return False
        '    End If
        'End If

        For Y = 0 To Me.grd1.RowCount - 1

            If Me.grd1.GetRowCellValue(Y, Me.colCodVendaDev).ToString = "" Then
                intCodProdGrid = Me.grd1.GetRowCellValue(Y, Me.colCodProdAut)
                strTamanhoGrid = Me.grd1.GetRowCellValue(Y, Me.colTamanho)

                If ParCodProdAut = intCodProdGrid Then
                    If parTamanho = strTamanhoGrid Then
                        Dim dblQtdGrid As Double = Me.grd1.GetRowCellValue(Y, Me.colQtde)
                        dblQtdGrid += CDbl(Me.txtQtd.Text.Trim)

                        If PermiteEstoqueZerado = False Then

                            If EstoqueSomado = False Then
                                Dim strSql As String = "Select sum(Qtd) as Qtd from Qtde where CodProd =" & ParCodProdAut & " and Tamanho ='" & parTamanho & "' and Acabou = 'False' and CodConfig =" & CodConfig

                                Dim dtQtd As DataTable = CarregarDataTable(strSql)
                                If dtQtd.Rows.Count = 0 Then
                                    MsgBox("Não existem quantidades desse produto em estoque!", MsgBoxStyle.Information)
                                    Me.txtCodPro.ResetText()
                                    bolInserido = True
                                    Return bolInserido
                                Else

                                    Dim dblQtdTabQtde As Double = 0
                                    If dtQtd.Rows(0).Item("Qtd").ToString <> "" Then
                                        dblQtdTabQtde = dtQtd.Rows(0).Item("Qtd").ToString
                                    End If
                                    If dblQtdGrid > dblQtdTabQtde Then
                                        MsgBox("Não existe a quantidade adicionada desse produto em estoque!", MsgBoxStyle.Information)
                                        Me.txtCodPro.ResetText()
                                        bolInserido = True
                                        Return bolInserido
                                    End If
                                End If
                            Else
                                Dim dblResul As Double = AjusteQtde(CodConfig, ParCodProdAut)

                                If dblResul <= 0 Then
                                    MsgBox("Não existem quantidades desse produto em estoque!", MsgBoxStyle.Information)
                                    Me.txtCodPro.ResetText()
                                    bolInserido = True
                                    Return bolInserido
                                Else

                                    If dblQtdGrid > dblResul Then
                                        MsgBox("Não existe a quantidade adicionada desse produto em estoque!", MsgBoxStyle.Information)
                                        Me.txtCodPro.ResetText()
                                        bolInserido = True
                                        Return bolInserido
                                    End If
                                End If
                            End If

                        End If


                        Me.grd1.SetRowCellValue(Y, Me.colQtde, dblQtdGrid.ToString("0.000"))
                        bolInserido = True
                        Exit For
                    End If
                End If
            End If
        Next

        Return bolInserido
    End Function

    Private Function JaInseridoDevolucao(ByVal ParCodProdAut As Integer, ByVal parTamanho As String, ByVal parQtd As Double, ByVal parQtdVendida As Double, ByVal parCodOrdem As String) As Boolean

        Dim Y As Integer

        Dim intCodProdGrid As Integer
        Dim strTamanhoGrid As String
        Dim bolInserido As Boolean = False
        Dim strCodigoOrdem As String
        For Y = 0 To Me.grd1.RowCount - 1

            If Me.grd1.GetRowCellValue(Y, Me.colCodVendaDev).ToString <> "" Then
                intCodProdGrid = Me.grd1.GetRowCellValue(Y, Me.colCodProdAut)
                strTamanhoGrid = Me.grd1.GetRowCellValue(Y, Me.colTamanho)
                strCodigoOrdem = Me.grd1.GetRowCellDisplayText(Y, Me.colCodVendaDev)
                Dim dtDev As DataTable = CarregarDataTable("SELECT CodOrdem FROM Pedido where Codigo =" & strCodigoOrdem)
                If dtDev.Rows.Count > 0 Then
                    strCodigoOrdem = dtDev.Rows.Item(0).Item("CodOrdem").ToString
                End If

                If parCodOrdem = strCodigoOrdem Then
                    If ParCodProdAut = intCodProdGrid Then
                        If parTamanho = strTamanhoGrid Then
                            Dim dblQtdGrid As Double = Me.grd1.GetRowCellValue(Y, Me.colQtde)
                            dblQtdGrid += parQtd

                            If dblQtdGrid > parQtdVendida Then
                                MsgBox("A quantidade devolvida é maior que a quantidade vendida!", MsgBoxStyle.Information)
                                bolInserido = True
                                Exit For
                            End If
                            Me.grd1.SetRowCellValue(Y, Me.colQtde, dblQtdGrid.ToString("0.000"))
                            bolInserido = True
                            Exit For
                        End If
                    End If
                End If

            End If
        Next

        Return bolInserido
    End Function

    'Private Sub Calcular()

    '    Dim dblTotal, dblValUni, dblQtd, dblPercent, dblCusto, dblResto, dblResul, dblTotSemDesc, dblItens, dblSomaDifDesc As Double

    '    Dim I As Integer

    '    For I = 0 To grd1.RowCount - 1

    '        If Me.txtPorDesc.Text.Trim <> "" Then
    '            If Me.grd1.GetRowCellValue(I, Me.colPromocao) = False Then
    '                Me.grd1.SetRowCellValue(I, Me.colDesconto, Me.txtPorDesc.Text.Trim)
    '            End If
    '        End If

    '    Next

    '    For I = 0 To grd1.RowCount - 1
    '        dblQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtde)
    '        dblValUni = Me.grd1.GetRowCellDisplayText(I, Me.colUnitario)

    '        dblItens += dblQtd

    '        If TipoDesconto = "ITENS" Then
    '            If dblValUni > 0 Then


    '                dblValUni = Me.grd1.GetRowCellDisplayText(I, Me.colValorSemDesconto)

    '                dblPercent = Me.grd1.GetRowCellDisplayText(I, Me.colDesconto)

    '                dblResto = (dblValUni / 100) * dblPercent

    '                dblValUni = dblValUni - dblResto
    '                If Me.grd1.GetRowCellValue(I, Me.colPromocao) = False Then

    '                    dblSomaDifDesc += dblValUni.ToString("0.00") * dblQtd

    '                    If I = grd1.RowCount - 1 Then


    '                        If dblQtd = 1 Then
    '                            If Me.txtValDesc.Text <> "0,00" And Me.txtValDesc.Text.Trim <> "" Then
    '                                Dim strDifer As String

    '                                strDifer = (dblTotalSemDesconto - CDbl(dblSomaDifDesc).ToString("0.00")).ToString("0.00")

    '                                If strDifer <> Me.txtValDesc.Text Then
    '                                    Dim dblDifer As Double

    '                                    dblDifer = (CDbl(Me.txtValDesc.Text) - CDbl(strDifer)).ToString("0.00")

    '                                    dblValUni = dblValUni - dblDifer

    '                                End If

    '                            End If
    '                        End If
    '                    End If
    '                End If

    '                Me.grd1.SetRowCellValue(I, Me.colUnitario, dblValUni.ToString("0.00"))
    '            End If
    '        End If


    '        dblResul = dblValUni.ToString("0.00") * dblQtd

    '        Me.grd1.SetRowCellValue(I, Me.colTotal, dblResul.ToString("0.00"))

    '        dblTotal += dblResul.ToString("0.00")
    '        dblCusto += CDbl(Me.grd1.GetRowCellDisplayText(I, Me.colCusto)) * dblQtd

    '        If Me.grd1.GetRowCellValue(I, Me.colPromocao) = False Then
    '            dblTotSemDesc += CDbl(Me.grd1.GetRowCellDisplayText(I, Me.colValorSemDesconto)) * dblQtd
    '        End If

    '    Next

    '    Me.txtTotal.Text = dblTotal.ToString("0.00")
    '    Me.txtSubTotal.Text = dblTotal.ToString("0.00")
    '    dblTotalComDesconto = dblTotal.ToString("0.00")

    '    dblTotalSemDesconto = dblTotSemDesc.ToString("0.00")
    '    Me.grpItens.Text = "Nº Itens : " & dblItens & " "

    '    dblTotalDeCusto = dblCusto

    '    Me.txtPorDesc.Text = Me.txtPorDesc.Text.Replace("-", "")
    '    Me.txtValDesc.Text = Me.txtValDesc.Text.Replace("-", "")

    'End Sub
    Private Sub Calcular()

        Dim dblTotal, dblValUni, dblQtd, dblPercent, dblCusto, dblResto, dblResul, dblTotSemDesc, dblItens, dblSomaDifDesc As Double

        Dim I As Integer

        For I = 0 To grd1.RowCount - 1

            If Me.txtPorDesc.Text.Trim <> "" Then
                If Me.grd1.GetRowCellValue(I, Me.colPromocao) = False Then
                    Me.grd1.SetRowCellValue(I, Me.colDesconto, Me.txtPorDesc.Text.Trim)
                End If
            End If

        Next

        Dim dblValFrete As Double = 0
        Dim dblValorFrete As Double = 0
        If Me.txtValorFrete.Text <> "" Then
            dblValFrete = Me.txtValorFrete.Text
            dblValFrete = dblValFrete / grd1.RowCount
            dblValFrete = dblValFrete.ToString("0.00")
        End If

        Dim dblValSemDescCasaDecimal As Double
        dblSemDezPorcento = 0
        For I = 0 To grd1.RowCount - 1
            dblResto = 0
            dblQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtde)
            dblValUni = Me.grd1.GetRowCellDisplayText(I, Me.colUnitario)

            dblItens += dblQtd

            If TipoDesconto = "ITENS" Then
                'If dblValUni > 0 Then


                dblValUni = Me.grd1.GetRowCellDisplayText(I, Me.colValorSemDesconto)
                If strCodComanda <> "0" And strCodComanda <> "" Then ' If intCodComanda > 0 Then
                    If DezPorcento = True Then
                        If Me.grd1.GetRowCellDisplayText(I, Me.colGrupo) <> "SEM DEZ PORCENTO" Then
                            dblPercent = Me.grd1.GetRowCellDisplayText(I, Me.colDesconto)
                            dblResto = (dblValUni / 100) * dblPercent
                        Else
                            dblSemDezPorcento += dblQtd * CampoValor(dblValUni)
                        End If
                    Else
                        dblPercent = Me.grd1.GetRowCellDisplayText(I, Me.colDesconto)
                        dblResto = (dblValUni / 100) * dblPercent
                    End If
                Else
                    dblPercent = Me.grd1.GetRowCellDisplayText(I, Me.colDesconto)
                    dblResto = (dblValUni / 100) * dblPercent
                End If




                dblValUni = dblValUni - dblResto
                If Me.grd1.GetRowCellValue(I, Me.colPromocao) = False Then

                    dblSomaDifDesc += CampoValor(dblValUni) * dblQtd

                    If I = grd1.RowCount - 1 Then

                        If CasaDecimal = "2" Or CasaDecimal = "3" Then
                            If dblQtd = 1 Then
                                If Me.txtValDesc.Text <> "0,00" And Me.txtValDesc.Text.Trim <> "" Then
                                    Dim strDifer As String

                                    strDifer = CampoValor(dblTotalSemDesconto - CDbl(CampoValor(dblSomaDifDesc)))

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

                If NomeEmpresa.ToUpper.Contains("CHEIRO") = True Then
                    dblValUni = dblValUni.ToString("0.000")
                Else
                    dblValUni = CampoValor(dblValUni)
                End If

                If TipoDesconto = "ITENS" Then
                    If dblValFrete > 0 Then
                        dblValorFrete += dblValFrete

                        dblValUni += dblValFrete / dblQtd

                        If I = grd1.RowCount - 1 Then

                            Dim dblDiferFrete As Double = dblValorFrete - CDbl(Me.txtValorFrete.Text)
                            dblDiferFrete = dblDiferFrete.ToString("0.00")
                            dblDiferFrete = (dblDiferFrete / dblQtd)

                            If dblDiferFrete > 0 Then
                                dblValUni = dblValUni - dblDiferFrete
                                dblValFrete = dblValFrete - dblDiferFrete
                            ElseIf dblDiferFrete < 0 Then
                                dblValUni = dblValUni - dblDiferFrete
                                dblValFrete = dblValFrete + dblDiferFrete
                            End If

                        End If

                        Me.grd1.SetRowCellValue(I, Me.colValorFrete, dblValFrete.ToString("0.00"))
                    End If
                End If
                


                Me.grd1.SetRowCellValue(I, Me.colUnitario, CampoValor(dblValUni))
                'End If

            Else
                If Me.grd1.GetRowCellValue(I, Me.colPromocao) = True Then
                    dblPercent = Me.grd1.GetRowCellDisplayText(I, Me.colDesconto)
                    dblResto = (dblValUni / 100) * dblPercent
                    dblValUni = dblValUni - dblResto
                    dblValUni = CampoValor(dblValUni)
                End If
             
            End If

            If NomeEmpresa.ToUpper.Contains("CHEIRO") = True Then
                dblResul = dblValUni.ToString("0.000") * dblQtd
            Else
                dblResul = CampoValor(dblValUni) * dblQtd
            End If




            Me.grd1.SetRowCellValue(I, Me.colTotal, dblResul.ToString("0.00"))

            dblTotal += dblResul.ToString("0.00")
            dblCusto += CDbl(Me.grd1.GetRowCellDisplayText(I, Me.colCusto)) * dblQtd
            Dim dblValSemDesc As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValorSemDesconto)
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
        Next
        If TipoDesconto = "TOTAL" Then
            If Me.txtValorFrete.Text <> "" Then
                dblTotal += CDbl(Me.txtValorFrete.Text)
            End If

        End If
        'If SATFiscal = False Then
        dblTotal = CorrigirCasaDecimal(dblTotal, dblValSemDescCasaDecimal)
        'End If


        Me.txtTotal.Text = dblTotal.ToString("0.00")
        Me.txtSubTotal.Text = dblTotal.ToString("0.00")
        dblTotalComDesconto = dblTotal.ToString("0.00")


        dblTotalSemDesconto = dblTotSemDesc.ToString("0.00")
        Me.grpItens.Text = "Nº Itens: " & dblItens & " | Total Sem Desconto R$ " & CalcularSemDesc()

        dblTotalDeCusto = dblCusto

        Me.txtPorDesc.Text = Me.txtPorDesc.Text.Replace("-", "")
        Me.txtValDesc.Text = Me.txtValDesc.Text.Replace("-", "")

    End Sub
    Private Function CalcularSemDesc() As String
        Dim strTotal As String = ""
        Dim dblTotSDesc As Double = 0
        Dim dblTotQtd As Double = 0

        Try
            Dim I As Integer = 0
            For I = 0 To Me.grd1.RowCount - 1
                Dim dbl As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValorSemDesconto)
                dblTotQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtde)
                dblTotSDesc = dblTotSDesc + dbl * dblTotQtd
            Next

            strTotal = dblTotSDesc.ToString("0.00")
        Catch ex As Exception
            dblTotSDesc = 0
            strTotal = dblTotSDesc.ToString("0.00")
        End Try
        Return strTotal
    End Function
    Private Function CorrigirCasaDecimal(ByVal parTotal As Double, ByVal parValSemDesc As Double) As Double
        If TipoDesconto = "TOTAL" Then
            Return parTotal
            Exit Function
        End If

        If Me.txtValDesc.Text.Trim <> "" Then
            Dim dblValDesc As Double = Me.txtValDesc.Text.Trim
            If dblValDesc > 0 Then

                Dim bolOk As Boolean = False
                Dim intCount As Integer = 0
                Dim dblTotalTeste As Double = parValSemDesc - dblValDesc
                Dim dblDiferenca As Double = parTotal - dblTotalTeste
                dblDiferenca = dblDiferenca.ToString("0.00")
                If Me.txtValorFrete.Text <> "" Then
                    dblDiferenca = dblDiferenca - CDbl(Me.txtValorFrete.Text)
                End If
                While bolOk = False

                    If dblDiferenca = 0 Then Exit While

                    If dblDiferenca <> 0 Then
                        parTotal = 0


                        Dim I As Integer
                        For I = 0 To Me.grd1.RowCount - 1

                            If Me.grd1.GetRowCellValue(I, Me.colPromocao) = False Then
                                If I = intCount Then
                                    Dim dblTot As Double = Me.grd1.GetRowCellDisplayText(I, Me.colTotal)
                                    dblTot = dblTot - dblDiferenca
                                    dblTot = dblTot.ToString("0.00")
                                    Dim dblQtd As Double = Me.grd1.GetRowCellDisplayText(I, Me.colQtde)

                                    Dim dblResul As Double = dblTot / dblQtd
                                    Me.grd1.SetRowCellValue(I, Me.colUnitario, CampoValor(dblResul))
                                    Me.grd1.SetRowCellValue(I, Me.colTotal, dblTot.ToString("0.00"))


                                End If
                            End If


                            parTotal += Me.grd1.GetRowCellDisplayText(I, Me.colTotal)

                        Next

                        intCount += 1
                        dblTotalTeste = parValSemDesc - dblValDesc
                        dblDiferenca = parTotal - dblTotalTeste
                        dblDiferenca = dblDiferenca.ToString("0.00")
                        If Me.txtValorFrete.Text <> "" Then
                            dblDiferenca = dblDiferenca - CDbl(Me.txtValorFrete.Text)
                        End If
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
    Private Sub nbcVenda_ActiveGroupChanged(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarGroupEventArgs) Handles nbcVenda.ActiveGroupChanged

        If Me.nbcVenda.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded Then
            Select Case Me.nbcVenda.ActiveGroup.Name
                Case "nbgPag"
                    Me.btnPag.Down = True
                    Me.btnPor.Down = False
                    Me.btnCli.Down = False
                    Me.cboPag.Focus()

                Case "nbgCli"
                    Me.btnCli.Down = True
                    Me.btnPag.Down = False
                    Me.btnPor.Down = False
                    Me.txtCli.Focus()

                Case "nbgDesc"
                    Me.btnPor.Down = True
                    Me.btnCli.Down = False
                    Me.btnPag.Down = False

            End Select

        End If

    End Sub

    Private Sub nbcVenda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbcVenda.Click
        Try
            If Me.nbcVenda.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed Then
                If Me.nbcVenda.NavPaneForm.ExpandedGroup.Expanded = True Then
                    'Dim inte As Integer = Me.txtValRec.Size.Width
                    'inte = Me.cboPag.Size.Width
                    'Me.cboPag.Size = New System.Drawing.Size(250, 28)
                    'Me.txtValRec.Size = New System.Drawing.Size(159, 28)
                    'Me.txtRec.Size = New System.Drawing.Size(250, 34)
                    'Me.txtTroco.Size = New System.Drawing.Size(250, 34)

                    Me.nbcVenda.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded



                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub nbcVenda_NavPaneStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbcVenda.NavPaneStateChanged
        If nbcVenda.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed Then

            Me.pnlSplit.SplitterPosition = 40
            Me.btnPag.Down = False
            Me.btnPor.Down = False
            Me.btnCli.Down = False
        Else

            Me.pnlSplit.SplitterPosition = 280

            Select Case Me.nbcVenda.ActiveGroup.Name
                Case "nbgPag"
                    Me.btnPag.Down = True
                    Me.btnPor.Down = False
                    Me.btnCli.Down = False

                Case "nbgCli"
                    Me.btnCli.Down = True
                    Me.btnPag.Down = False
                    Me.btnPor.Down = False

                Case "nbgDesc"
                    Me.btnPor.Down = True
                    Me.btnCli.Down = False
                    Me.btnPag.Down = False

            End Select

        End If
    End Sub

    Private Sub btnPag_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPag.ItemClick
        If Me.btnPag.Down = True Then
            nbcVenda.ActiveGroup = Me.nbgPag
            Me.nbcVenda.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded
            Me.btnCli.Down = False
            Me.btnPor.Down = False
            Me.cboPag.Focus()
        End If

    End Sub

    Private Sub btnCli_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCli.ItemClick
        If Me.btnCli.Down = True Then
            nbcVenda.ActiveGroup = Me.nbgCli
            Me.nbcVenda.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded
            Me.btnPag.Down = False
            Me.btnPor.Down = False
            Me.txtCPF.Focus()
        End If
    End Sub

    Private Sub btnPor_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPor.ItemClick

        If Me.btnPor.Down = True Then
            nbcVenda.ActiveGroup = Me.nbgDesc
            Me.nbcVenda.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded
            Me.btnCli.Down = False
            Me.btnPag.Down = False

            If intCodPedido = 0 Then
                Me.txtPorDesc.Focus()
            End If

        End If

    End Sub

    'Private Sub frmVenda_ClientSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ClientSizeChanged
    '    nbcVenda.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
    'End Sub
    Public Shared Function ListaBytesParaString(ByVal lista As Byte()) As String
        Dim retornoChar As Char() = New Char(lista.Length - 1) {}
        For i As Integer = 0 To lista.Length - 1
            retornoChar(i) = ChrW(lista(i))
        Next
        Dim retorno As New String(retornoChar)
        Return retorno
    End Function
    Dim PortaAberta As Boolean = False
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        bolDuploEnter = False

        If intCont = 10 Then
            If Me.txtValor.Properties.ReadOnly = True Then
                Me.picLogo.Image = LogoTipo
            End If

            If Me.txtValor.Properties.ReadOnly = True Then
                Me.txtProd.ResetText()
            End If
            If Me.txtValor.Properties.ReadOnly = True Then
                If strDescontoCliente = "" Then
                    If Me.txtProd.Text <> "" Then
                        Me.txtPerDesc.ResetText()
                    End If

                Else

                    Me.txtPerDesc.Text = strDescontoCliente
                End If
                bolJaPassouDesc = False
            End If
            If Me.txtValor.Properties.ReadOnly = True Then
                Me.txtValor.ResetText()
            End If
        End If

        If bolFoto = True Then
            If intContFoto = 5 Then
                bolFoto = False
                Me.picLogo.Image = LogoTipo
                intContFoto = 0
            Else
                intContFoto += 1
            End If
        End If

        intCont += 1
        Me.lblHora.Caption = My.Computer.Clock.LocalTime


        If TemBalanca = True Then

            If TipoBalanca.Contains("TOLEDO") = True Then
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
                    If CNPJEmpresa = "01049235000130" Or CNPJEmpresa = "31218113000191" Or CNPJEmpresa = "35600561000106" Then
                        Try
                            Dim dblPeso As Double = strPeso

                            If dblPeso > 0 Then
                                Me.txtQtd.Text = dblPeso.ToString("0.000")
                            Else
                                If bolDigQtd = False Then
                                    Me.txtQtd.ResetText()
                                End If
                            End If
                        Catch ex As Exception

                        End Try
                    Else
                        Dim dblPeso As Double = strPeso

                        If dblPeso > 0 Then
                            Me.txtQtd.Text = dblPeso.ToString("0.000")
                        Else
                            If bolDigQtd = False Then
                                Me.txtQtd.ResetText()
                            End If
                        End If
                    End If


                Else
                    Me.lblStatus.Text = "Lendo Balança..."
                End If
            Else



                Dim strPorta, strPeso, strValor, strTotal As String

                strPorta = "COM1"

                strPeso = Space(7)
                strValor = Space(7)
                strTotal = Space(7)

                'Me.txtQtd.ResetText()
                If bolDigQtd = True Then Exit Sub

                Dim intRetorno As Integer
          
                intRetorno = Bematech_FI_InfoBalanca(PortaBalanca, BaudRateBalanca, strPeso, strValor, strTotal)

                Select Case intRetorno

                    Case -35
                        Me.lblStatus.Text = "-35 Peso excedido."

                    Case -34
                        Me.lblStatus.Text = "34 Peso instável."

                    Case -33
                        Me.lblStatus.Text = "33 Condição de alívio de prato."

                    Case -2
                        Me.lblStatus.Text = "Erro de parametros."

                    Case -1
                        Me.lblStatus.Text = "Erro de execução."

                    Case 0

                        If intCont > 20 Then Exit Sub
                        Me.lblStatus.Text = "Erro de comunicação." & intCont

                    Case 1

                        Dim strDec, strInt As String
                        Try
                            strInt = Mid(strPeso, 1, 3)
                            strDec = Mid(strPeso, 4, 6)
                            strPeso = strInt & "," & strDec

                            Dim dblPeso As Double = strPeso
                            Me.lblStatus.Text = ""

                            If dblPeso > 0 Then
                                Me.txtQtd.Text = dblPeso.ToString("0.000")
                            Else
                                If bolDigQtd = False Then
                                    Me.txtQtd.ResetText()
                                End If
                            End If


                            

                        Catch ex As Exception
                            MsgBox(ex.Message, MsgBoxStyle.Information)
                        End Try


                End Select
            End If
            
        End If
    End Sub



    Public Sub F8(ByVal parLocal As Boolean)
        If grd1.RowCount > 0 Then
            MsgBox("Não é possivel realizar esse procedimento pois já existe uma venda sendo realizada!", MsgBoxStyle.Information)
            Exit Sub
        End If


        If parLocal = True Then
            ConsultaPedido = 0
            'intCodComanda = 0
            strCodComanda = ""
            Select Case TipoNano
                Case 1
                    Dim frm As New frmComandas
                    frm.ShowDialog()
                    'intCodComanda = ConsultaPedido
                    strCodComanda = ConsultaPedido
                Case Else
                    Exit Sub
            End Select
        Else
            'intCodComanda = ConsultaPedido
            strCodComanda = ConsultaPedido
        End If


        If strCodComanda <> "" And strCodComanda <> "0" Then

            Dim vetComanda As Array = Split(strCodComanda, ",")

            Dim A As Integer

            Dim dtItens As DataTable
            Dim dblFrete As Double = 0
            Dim strCodigoOrdem As String
            For A = 0 To vetComanda.Length - 1

                Dim strCodCom As String = vetComanda(A).ToString.Trim

                dtItens = CarregarDataTable("Select CodProd, Qtd, ValorUnitario, Produto, Status, Tipo, CodCli, CodFunc, " & _
                "CodOrdens, TabelaPreco from Comanda where Status <> 'Faturado' and CodComanda ='" & strCodCom & "' and CodConfig =" & CodConfig)

                If dtItens.Rows.Count > 0 Then
                    intCodFunc = dtItens.Rows.Item(0).Item("CodFunc").ToString

                    Dim dtFun As DataTable = CarregarDataTable("Select Nome from Funcionario where Codigo =" & intCodFunc)

                    If dtFun.Rows.Count > 0 Then
                        Me.lblVend2.Caption = Dir(dtFun.Rows.Item(0).Item("Nome").ToString, 30)

                    End If
                    strCodigoOrdem = dtItens.Rows.Item(0).Item("CodOrdens").ToString

                    Dim dtCom As DataTable = CarregarDataTable("SELECT ValorEstorno as ValorFrete FROM R7 where CodUser = " & strCodigoOrdem & " and CodConfig = " & CodConfig)
                    If dtCom.Rows.Count > 0 Then
                        If dtCom.Rows.Item(0).Item("ValorFrete").ToString <> "" Then
                            Dim dblValFrete As Double = dtCom.Rows.Item(0).Item("ValorFrete").ToString

                            dblFrete += dblValFrete

                        End If

                    End If

                End If
                Dim I As Integer



                For I = 0 To dtItens.Rows.Count - 1

                    Me.txtQtd.Text = dtItens.Rows.Item(I).Item("Qtd").ToString
                    CodigoDoProduto = dtItens.Rows.Item(I).Item("CodProd").ToString
                    Dim dblVal1 As Double = dtItens.Rows.Item(I).Item("ValorUnitario").ToString
                    Me.txtValor.Text = dblVal1.ToString("0.00")
                    Me.txtProd.Text = dtItens.Rows.Item(I).Item("Produto").ToString
                    Dim strTabela As String = Me.lblTabela.Caption
                    If dtItens.Rows.Item(I).Item("TabelaPreco").ToString <> "" Then
                        strTabela = dtItens.Rows.Item(I).Item("TabelaPreco").ToString
                    End If
                    InserirProduto(True, False, "", strTabela, "U", True, Me.txtValor.Text.Trim)
                Next

            Next


            Dim dtTabela As DataTable = CarregarDataTable("SELECT top 1 TabelaPreco from Comanda where " & _
            "CodOrdens = " & strCodigoOrdem & " and CodConfig =" & CodConfig & " order by Codigo desc")
            If dtTabela.Rows.Count > 0 Then
                If dtTabela.Rows.Item(0).Item("TabelaPreco").ToString <> "" Then
                    Me.lblTabela.Caption = dtTabela.Rows.Item(0).Item("TabelaPreco").ToString
                End If
            End If

            'Status ='Fechado' and
            If dblFrete > 0 Then
                Me.txtValorFrete.Text = dblFrete.ToString("0.00")
                Calcular()
            End If
           
            If dtItens.Rows.Count > 0 Then

                If DezPorcento = True Then
                    If dtItens.Rows.Item(0).Item("Tipo") = "COMANDA" Then

                        Me.rdgDesc.SelectedIndex = 1
                        Me.txtPorDesc.Text = "10,00"
                        DescontoComPorcentagem(True)

                    End If
                End If

                CodigoDoCliente = dtItens.Rows.Item(0).Item("CodCli")
                TrazCliente()
            End If

        End If

        Me.txtCodPro.Focus()
    End Sub

    Private Sub F10()

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
            frmPro.strTabPre = Me.lblTabela.Caption
            frmPro.Tag = "VENDA"
            CodigoDoProduto = -1
            CodigoDoProdutoAgrupado = ""
            QtdeDoProduto = 0
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
            frm.strTabPre = Me.lblTabela.Caption
            frm.Tag = "VENDA"
            CodigoDoProduto = -1
            CodigoDoProdutoAgrupado = ""
            QtdeDoProduto = 0
            frm.ShowDialog()
        End If

        'If CodigoDoProduto = -1 Then Exit Sub
        'If QtdeDoProduto > 0 Then
        '    Me.txtQtd.Text = QtdeDoProduto
        'End If
        If CodigoDoProdutoAgrupado <> "" Then
            Dim I As Integer
            Dim vetProd As Array = Split(CodigoDoProdutoAgrupado, "|")

            For I = 0 To vetProd.Length - 1
                Dim vetCodProd As Array = Split(vetProd(I), "%")
                CodigoDoProduto = vetCodProd(0)
                If Me.txtQtd.Text = "" Then
                    Me.txtQtd.Text = vetCodProd(1)
                End If

                InserirProduto(True, False, "", Me.lblTabela.Caption)

                QtdeDoProduto = 0
                CodigoDoProduto = -1
            Next
        Else
            Me.txtCodPro.ResetText()
            Exit Sub
        End If

        'InserirProduto(True, False, "")
        QtdeDoProduto = 0
        Me.txtCodPro.Focus()
    End Sub
   


    Public Sub F11(ByVal parMDI As Boolean)
        If grd1.RowCount > 0 Then
            MsgBox("Não é possivel realizar esse procedimento pois já existe uma venda sendo realizada!", MsgBoxStyle.Information)
            Exit Sub
        End If
        If parMDI = False Then
            ConsultaPedido = 0
            intCodPedido = 0

            Dim frm As New frmConPed
            frm.Tag = "FATURA"
            frm.ShowDialog()
        End If

        If ConsultaPedido = "" Then Exit Sub

        intCodPedido = ConsultaPedido

        If intCodPedido <> 0 Then
            Dim dt As DataTable
            Dim dtItens As DataTable

            dt = CarregarDataTable("Select CodCli, Desconto, CodFunc, Acrescimo, Placa, KMEntrada, Modelo, ValorFrete, Operador from TotalConsig where CodOrdens =" & intCodPedido & " and CodConfig =" & CodConfig)

            If dt.Rows.Count = 0 Then Exit Sub

            If dt.Rows.Count > 0 Then
                CodigoDoCliente = dt.Rows.Item(0).Item("CodCli")
                TrazCliente()
                If TipoNano <> 5 Then
                    intCodFunc = dt.Rows.Item(0).Item("CodFunc").ToString

                    Dim dtFun As DataTable = CarregarDataTable("Select Nome from Funcionario where Codigo =" & intCodFunc)

                    If dtFun.Rows.Count > 0 Then
                        Me.lblVend2.Caption = Dir(dtFun.Rows.Item(0).Item("Nome").ToString, 30)

                    End If
                Else
                    strOperador = dt.Rows.Item(0).Item("Operador").ToString
                    strPlaca = dt.Rows.Item(0).Item("Placa").ToString
                    strModelo = dt.Rows.Item(0).Item("Modelo").ToString
                    If strPlaca <> "" Then
                        Dim dtKMMes As DataTable = CarregarDataTable("Select KMMes from Carro where Placa = '" & strPlaca & "'")
                        If dtKMMes.Rows.Count > 0 Then
                            strKMMes = dtKMMes.Rows.Item(0).Item("KMMes").ToString
                        End If
                        strKM = dt.Rows.Item(0).Item("KMEntrada").ToString
                    End If
                End If

                Me.txtValorFrete.Text = dt.Rows.Item(0).Item("ValorFrete").ToString

            End If

            dtItens = CarregarDataTable("Select Qtd, CodigoProduto, Tamanho, ValorUnitario, Produto, UniSemDesc, " & _
            "Promocao, Desconto, QtdMedida, CodigoFuncionario, Autorizado, Custo, TabelaPreco, CodigoInterno from ItensConsig where " & _
            "CodOrdens =" & intCodPedido & " and CodConfig =" & CodConfig)

            Dim I As Integer

            For I = 0 To dtItens.Rows.Count - 1
                If dtItens.Rows.Item(I).Item("Autorizado") = True Then
                    Dim dblCustoPed As Double = 0
                    If dtItens.Rows.Item(I).Item("Custo").ToString <> "" Then
                        dblCustoPed = dtItens.Rows.Item(I).Item("Custo").ToString
                    End If
                    Me.txtQtd.Text = dtItens.Rows.Item(I).Item("Qtd").ToString

                    If dblCustoPed > 0 Then
                        dblCustoPed = dblCustoPed / CDbl(dtItens.Rows.Item(I).Item("Qtd").ToString)

                    End If

                    CodigoDoProduto = dtItens.Rows.Item(I).Item("CodigoProduto")
                    Dim strUniSemDesc As String
                    If dtItens.Rows.Item(I).Item("UniSemDesc").ToString <> "" Then
                        strUniSemDesc = dtItens.Rows.Item(I).Item("UniSemDesc").ToString
                    Else
                        strUniSemDesc = dtItens.Rows.Item(I).Item("ValorUnitario").ToString
                    End If

                    Dim strDesconto As String = "0"
                    If dtItens.Rows.Item(I).Item("Desconto").ToString <> "" Then
                        strDesconto = dtItens.Rows.Item(I).Item("Desconto").ToString
                    End If

                    Dim dblQtdMedida As Double = 0
                    If dtItens.Rows.Item(I).Item("QtdMedida").ToString <> "" Then
                        dblQtdMedida = dtItens.Rows.Item(I).Item("QtdMedida").ToString
                    End If
                    If TipoNano = 5 Then
                        intCodFunc = 0
                        Dim strCodigoFuncionario As String = dtItens.Rows.Item(I).Item("CodigoFuncionario").ToString
                        If strCodigoFuncionario <> "" Then
                            intCodFunc = strCodigoFuncionario
                        End If
                    End If
                    Dim strTabela As String = Me.lblTabela.Caption
                    If dtItens.Rows.Item(I).Item("TabelaPreco").ToString <> "" Then
                        strTabela = dtItens.Rows.Item(I).Item("TabelaPreco").ToString
                    End If
                    InserirProduto(True, True, intCodFunc, strTabela, dtItens.Rows.Item(I).Item("Tamanho").ToString, AlteraPrecoPedido, dtItens.Rows.Item(I).Item("ValorUnitario").ToString, dtItens.Rows.Item(I).Item("Produto").ToString, dtItens.Rows.Item(I).Item("Promocao"), strUniSemDesc, strDesconto, dblQtdMedida, dblCustoPed, dtItens.Rows.Item(I).Item("CodigoInterno").ToString)

                End If

            Next


            Dim dtTabela As DataTable = CarregarDataTable("SELECT top 1 TabelaPreco from ItensConsig where " & _
            "CodOrdens = " & intCodPedido & " and CodConfig =" & CodConfig & " order by Codigo desc")
            If dtTabela.Rows.Count > 0 Then
                If dtTabela.Rows.Item(0).Item("TabelaPreco").ToString <> "" Then
                    Me.lblTabela.Caption = dtTabela.Rows.Item(0).Item("TabelaPreco").ToString
                End If
            End If


            Me.rdgDesc.SelectedIndex = 0

            Dim vetDesc As Array

            Dim strDescAcres As String = dt.Rows.Item(0).Item("Desconto").ToString
            vetDesc = Split(strDescAcres, "|")
            strDescAcres = vetDesc(1).ToString

            If strDescAcres <> "" Then
                If strDescAcres = "" Or strDescAcres = "0,00" Or strDescAcres = "0,000" Then
                    strDescAcres = dt.Rows.Item(0).Item("Acrescimo").ToString
                    vetDesc = Split(strDescAcres, "|")
                    If vetDesc.Length > 1 Then
                        strDescAcres = vetDesc(1).ToString
                    End If

                    If strDescAcres <> "" Then
                        Dim dblAcres As Double = strDescAcres
                        If dblAcres > 0 Then
                            Me.rdgDesc.SelectedIndex = 1

                        End If
                    End If
                End If
            End If


            If vetDesc.Length > 1 Then
                Me.txtPorDesc.Text = vetDesc(1).ToString
            End If

            DescontoComPorcentagem(True)

            EntradaPedido()


        End If
    End Sub
    Private Sub EntradaPedido()
        dblTotalRecebido = 0
        If intCodPedido <= 0 Then Exit Sub


        Dim dtRecebimento As DataTable = CarregarDataTable("SELECT sum(Convert(Numeric(15,2),Valor)) as Valor FROM Recebimento where CodigoPedido = '" & intCodPedido & "' and CodConfig = " & CodConfig)
        If dtRecebimento.Rows.Count > 0 Then
            If dtRecebimento.Rows.Item(0).Item("Valor").ToString <> "" Then
                Dim dblValRec As Double = dtRecebimento.Rows.Item(0).Item("Valor").ToString

                dblTotalRecebido += dblValRec

                Me.txtRec.Text = dblTotalRecebido.ToString("0.00")
                Dim dblTotal As Double = Me.txtTotal.Text.Trim
                Dim dblTroco As Double = dblTotal - dblTotalRecebido

                If dblTroco < 0 Then
                    Me.txtSubTotal.Text = "0,00"

                    'If strForPag = "CRÉDITO CLIENTE" Then
                    '    Me.txtCredito.Text = dblTroco.ToString("0.00").Replace("-", "")
                    'Else
                    Me.txtTroco.Text = dblTroco.ToString("0.00").Replace("-", "")
                    ' End If

                Else
                    Me.txtSubTotal.Text = dblTroco.ToString("0.00")
                    Me.txtTroco.Text = "0,00"
                End If


                Me.txtValDesc.Enabled = False
                Me.txtPorDesc.Enabled = False
                Me.rdgDesc.Enabled = False

                Me.txtValRec.ResetText()
                Me.txtVez.ResetText()
                Me.cboPag.EditValue = DBNull.Value
                Me.cboPag.Focus()

                If Me.txtSubTotal.Text.Trim = "0,00" Then
                    Me.cboPag.Enabled = False
                    Me.btnCred.Enabled = False
                    Me.txtVez.Enabled = False
                    Me.txtValRec.Enabled = False
                Else
                    Me.cboPag.Enabled = True
                    Me.btnCred.Enabled = True
                    Me.txtVez.Enabled = True
                    Me.txtValRec.Enabled = True
                End If

                Me.txtCli.Enabled = False
                Me.rdgDoc.Enabled = False
                Me.txtCPF.Enabled = False
            Else
                Me.txtCodPro.Focus()
            End If
        Else
            Me.txtCodPro.Focus()
        End If
    End Sub
    Private Sub F12()
        CodigoDaVenda = 0

        Dim frm As New frmConPedido
        frm.Tag = "DEVOLUÇÃO"
        frm.ShowDialog()
        InserirDevolucao()
        Me.txtCodPro.Focus()
    End Sub


    Private Sub txtCodPro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodPro.KeyDown
        If e.KeyCode = Keys.F10 Then
            F10()
        End If
        If e.KeyCode = Keys.Space Then
            If Me.txtCodPro.Text = "" Then
                ConsultaProduto()
                Timer2.Start()
            End If

        End If
        If e.KeyCode = Keys.Enter Then
            If bolConsultaProduto = False Then
                If Me.txtCodPro.Text.Trim = "" Then

                    If CNPJEmpresa.Contains("33150857000147") = True Then
                        If bolDuploEnter = False Then
                            Me.txtQtd.Focus()
                        End If
                    Else
                        Me.txtQtd.Focus()
                    End If

                    bolDuploEnter = False
                    Exit Sub
                End If

                InserirProduto(False, False, "", Me.lblTabela.Caption)
                bolDuploEnter = True
            Else
                If NomeEmpresa.ToUpper.Contains("LDN AUTO") = True Then

                    If ConProdAberto = False Then
                        frmPro.strTabPre = Me.lblTabela.Caption
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
                    frmPro.strTabPre = Me.lblTabela.Caption
                    frmPro.Tag = "VENDA"
                    frmPro.strFiltroProduto = Me.txtCodPro.Text
                    frmPro.FiltroProduto()
                    CodigoDoProduto = -1
                    CodigoDoProdutoAgrupado = ""
                    QtdeDoProduto = 0
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
                    frm.strTabPre = Me.lblTabela.Caption
                    frm.strFiltroProduto = Me.txtCodPro.Text
                    frm.Tag = "VENDA"
                    QtdeDoProduto = 0
                    CodigoDoProduto = -1
                    CodigoDoProdutoAgrupado = ""
                    frm.ShowDialog()
                End If


              
                'If CodigoDoProduto = -1 Then
                '    Me.txtCodPro.ResetText()
                '    Exit Sub
                'End If

                'If QtdeDoProduto > 0 Then
                '    Me.txtQtd.Text = QtdeDoProduto
                'End If

                If CodigoDoProdutoAgrupado <> "" Then
                    Dim I As Integer
                    Dim vetProd As Array = Split(CodigoDoProdutoAgrupado, "|")

                    For I = 0 To vetProd.Length - 1
                        Dim vetCodProd As Array = Split(vetProd(I), "%")
                        CodigoDoProduto = vetCodProd(0)
                        If Me.txtQtd.Text = "" Then
                            Me.txtQtd.Text = vetCodProd(1)
                        End If

                        InserirProduto(True, False, "", Me.lblTabela.Caption)
                        QtdeDoProduto = 0
                        CodigoDoProduto = -1
                    Next
                Else
                    Me.txtCodPro.ResetText()
                    Exit Sub
                End If

                'InserirProduto(True, False, "")
                ConsultaProduto()
                bolConsultaProduto = False
                QtdeDoProduto = 0
                Me.txtCodPro.Focus()
            End If


        End If

        If NomeEmpresa <> "SABOR DA FRUTA" Then
            If e.KeyCode = Keys.F11 Then
                F11(False)
            End If
        End If


        If e.KeyCode = Keys.F8 Then
            F8(True)
        End If


        If e.KeyCode = Keys.F12 Then
            F12()
        End If

    End Sub
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

        If e.KeyCode = Keys.Enter Then
            bolQtdEnter = True
        End If

    End Sub

    Dim bolQtdEnter As Boolean = False
    Private Sub txtQtd_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQtd.Leave
        If Me.txtQtd.Text.Trim <> "" Then
            If CDbl(Me.txtQtd.Text.Trim) = 0 Then Me.txtQtd.ResetText()
            ''bolDigQtd = True
            If bolQtdEnter = True Then
                Me.txtCodPro.Focus()
            End If
        Else
            bolDigQtd = False
            Me.txtPerDesc.Focus()
        End If
    End Sub

    Private Sub txtValDesc_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtValDesc.Validating
        DescontoComValor()
    End Sub

    Private Sub DescontoMaior()
        If Nivel = "USUÁRIO" Then
            If DescontoMaximo <> "" Then
                If CDbl(Me.txtPorDesc.Text.Trim) > CDbl(DescontoMaximo) Then
                    MsgBox("Desconto é maior do que o permitido, digite a senha de um usuário com nível de ADMINISTRADOR!", MsgBoxStyle.Information)
                    Dim frm As New frmSenhaExcluir
                    frm.Tag = "DESCONTO"
                    frm.ShowDialog()
                    If bolSenhaOK = False Then
                        Me.txtValDesc.Text = "0,00"
                        Me.txtPorDesc.Text = "0,00"
                        DescontoComValor()
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub DescontoComValor()
        If txtValDesc.Text.Trim = "" Then txtValDesc.Text = "0,00"
        If Me.txtTotal.Text = "0,00" Then Exit Sub

        Dim dblTotal, dblValDesc, dblResul As Double


        If Me.rdgDesc.SelectedIndex = 1 Then
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
        Me.txtSubTotal.Text = dblResul.ToString("0.00")


        If TipoDesconto = "ITENS" Then
            dblTotal = dblTotalSemDesconto
        Else
            dblTotal = dblTotalComDesconto
        End If

        dblValDesc = dblValDesc * 100

        dblResul = dblValDesc / dblTotal
        If TipoDesconto = "TOTAL" Then
            Me.txtPorDesc.Text = dblResul.ToString("0.00000")

        Else
            Me.txtPorDesc.Text = dblResul.ToString("0.0000")

        End If
        
        If Me.txtPorDesc.Text.ToUpper = "NAN (NÃO É UM NÚMERO)" Or Me.txtPorDesc.Text.ToUpper = "+INFINITO" Or Me.txtPorDesc.Text.ToUpper = "-INFINITO" Then
            Me.txtPorDesc.Text = "0,00"
            Me.txtValDesc.Text = "0,00"
        End If

        DescontoMaior()

        Me.txtPorAcre.Text = "0,00"
        Me.txtValAcre.Text = "0,00"
        If TipoDesconto = "ITENS" Then
            Calcular()
        Else
            Me.txtValDesc.Text = Me.txtValDesc.Text.Trim.Replace("-", "")
            Me.txtPorDesc.Text = Me.txtPorDesc.Text.Replace("-", "")
        End If


        Me.picLogo.Focus()

    End Sub

    Private Sub DescontoComPorcentagem(ByVal parPedido As Boolean)

        If Me.txtTotal.Text = "0,00" Then Exit Sub

        If txtPorDesc.Text.Trim = "" Then
            txtPorDesc.Text = "0,00"
            Me.txtValDesc.Text = "0,00"
            DescontoComValor()
            Exit Sub
        End If

        If parPedido = False Then
            DescontoMaior()
        End If
      
        If Me.rdgDesc.SelectedIndex = 1 Then
            Me.txtPorDesc.Text = "-" & Me.txtPorDesc.Text
        End If

        If Me.txtTotal.Text = "0,00" Then Exit Sub

        Dim dblTotal, dblResul As Double
        Dim dblPor As Double

        If TipoDesconto = "ITENS" Then
            dblTotal = dblTotalSemDesconto
        Else
            dblTotal = dblTotalComDesconto
            'dblTotal = dblTotalSemDesconto
        End If

        dblPor = Me.txtPorDesc.Text.Trim
        'If intCodComanda = 0 Then
        '    dblSemDezPorcento = 0
        'End If

        If strCodComanda = "0" Or strCodComanda = "" Then
            dblSemDezPorcento = 0
        End If

        dblResul = ((dblTotal - dblSemDezPorcento) * dblPor) / 100


        Me.txtValDesc.Text = dblResul.ToString("0.00")


        If Me.txtValDesc.Text.ToUpper = "NAN (NÃO É UM NÚMERO)" Or Me.txtValDesc.Text.ToUpper = "+INFINITO" Or Me.txtValDesc.Text.ToUpper = "-INFINITO" Then
            Me.txtPorDesc.Text = "0,00"
            Me.txtValDesc.Text = "0,00"
        Else
            If dblResul = 0 Then
                Me.txtPorDesc.Text = "0,00"
                Me.txtValDesc.Text = "0,00"
            Else

                dblResul = dblTotal - dblResul

                txtTotal.Text = dblResul.ToString("0.00")

                Me.txtSubTotal.Text = dblResul.ToString("0.00")
            End If


        End If


        Me.txtPorAcre.Text = "0,00"
        Me.txtValAcre.Text = "0,00"
        If TipoDesconto = "ITENS" Then
            Calcular()
        Else
            Me.txtValDesc.Text = Me.txtValDesc.Text.Trim.Replace("-", "")
            Me.txtPorDesc.Text = Me.txtPorDesc.Text.Replace("-", "")
        End If

        If Me.txtPorDesc.Text = "0,000" Or Me.txtPorDesc.Text = "" Or Me.txtPorDesc.Text = "0,00" Or Me.txtPorDesc.Text = "0,0000" Then
            Me.txtValDesc.Focus()
        Else
            Me.picLogo.Focus()
        End If


    End Sub

    'Private Sub txtPorDesc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPorDesc.Leave
    '    If Me.txtPorDesc.Text = "0,000" Or Me.txtPorDesc.Text = "" Or Me.txtPorDesc.Text = "0,00" Or Me.txtPorDesc.Text = "0,0000" Then
    '        Me.txtValDesc.Focus()
    '    End If
    'End Sub

    Private Sub txtPorDesc_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPorDesc.Validating
        DescontoComPorcentagem(False)
        If TipoDesconto = "TOTAL" Then
            DescontoComValor()
        End If
    End Sub

    Private Sub txtPorAcre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPorAcre.Validating
        If txtPorAcre.Text.Trim = "" Then txtPorAcre.Text = 0
        If Me.txtTotal.Text = "0,00" Then Exit Sub

        Dim dblTotal, dblPor, dblResul As Double

        dblTotal = dblTotalSemDesconto
        dblPor = Me.txtPorAcre.Text.Trim

        dblResul = (dblTotal * dblPor) / 100

        Me.txtValAcre.Text = dblResul.ToString("0.00")

        dblResul = dblTotal + dblResul

        txtTotal.Text = dblResul.ToString("0.00")
        Me.txtSubTotal.Text = dblResul.ToString("0.00")

        Me.txtPorDesc.Text = "0,00"
        Me.txtValDesc.Text = "0,00"

        Me.picLogo.Focus()

    End Sub

    Private Sub txtValAcre_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtValAcre.Validating

        If txtValAcre.Text.Trim = "" Then txtValAcre.Text = "0,00"
        If Me.txtTotal.Text = "0,00" Then Exit Sub

        Dim dblTotal, dblValAcre, dblResul As Double

        dblValAcre = Me.txtValAcre.Text.Trim
        dblTotal = dblTotalSemDesconto


        dblResul = (dblTotal + dblValAcre)
        Me.txtTotal.Text = dblResul.ToString("0.00")
        Me.txtSubTotal.Text = dblResul.ToString("0.00")


        dblTotal = dblTotalSemDesconto

        dblValAcre = dblValAcre * 100

        dblResul = dblValAcre / dblTotal

        Me.txtPorAcre.Text = dblResul.ToString("0.00")

        Me.txtPorDesc.Text = "0,00"
        Me.txtValDesc.Text = "0,00"

        Me.picLogo.Focus()

    End Sub

    Private Sub txtCli_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCli.ButtonClick
        AbreCliente()

    End Sub

    Private Sub AbreCliente()
        Dim frm As New frmCadCliente
        frm.Tag = "PESQUISAVENDA"

        intCodCliente = 1
        CodigoDoCliente = 1

        bolMSGCliente = False

        frm.ShowDialog()
        TrazCliente()

        bolMSGCliente = True

    End Sub

    Private Sub TrazCliente()

        If bolMSGCliente = True Then bolMSGCliente = False : Exit Sub

        Dim dt As DataTable = CarregarDataTable("Select Nome, CPF, Credito, Limite, Inadimplente, Inativo, Imagem, Desconto from Cliente where Codigo =" & CodigoDoCliente)
        Me.chkNFP.Checked = False
        Dim dblSalDev, dblLimite As Double

        If dt.Rows.Count > 0 Then

            If dt.Rows.Item(0).Item("Inativo") = True Then
                MsgBox("O Cliente está inativo!", MsgBoxStyle.Information)
                CodigoDoCliente = 0
                Me.txtCPF.ResetText()
                Me.txtCPF.Focus()
                Exit Sub
            End If

            If dt.Rows.Item(0).Item("Inadimplente") = True Then
                If NomeEmpresa.Contains("PREMIER") = False Then
                    If NomeEmpresa.Contains("TAUÁ") = False Then
                        If ComSenha() = False Then
                            CodigoDoCliente = 0
                            Me.txtCPF.ResetText()
                            Me.txtCPF.Focus()
                            Exit Sub
                        End If
                    Else
                        If dt.Rows.Item(0).Item("Credito").ToString = "" Or dt.Rows.Item(0).Item("Credito").ToString = "0,00" Then
                            MsgBox("O Cliente possui débitos!", MsgBoxStyle.Information)
                            CodigoDoCliente = 0
                            Me.txtCPF.ResetText()
                            Me.txtCPF.Focus()
                            Exit Sub
                        End If
                    End If

                End If

            Else
                Dim dt2 As DataTable = CarregarDataTable("Select Codigo from ContaReceber where RecebidoOK ='False' and Vencimento <'" & Date.Today.AddDays(-Tolerancia) & "' and CodCli =" & CodigoDoCliente)
                If dt2.Rows.Count > 0 Then
                    Atualizar("Update Cliente set Inadimplente ='True' where Codigo =" & CodigoDoCliente)

                    If NomeEmpresa.Contains("TAUÁ") = False Then
                        If ComSenha() = False Then
                            CodigoDoCliente = 0
                            Me.txtCPF.ResetText()
                            Me.txtCPF.Focus()
                            Exit Sub
                        End If
                    Else
                        MsgBox("O Cliente possui débitos!", MsgBoxStyle.Information)
                        CodigoDoCliente = 0
                        Me.txtCPF.ResetText()
                        Me.txtCPF.Focus()
                        Exit Sub
                    End If


                End If
            End If

            'If PafEcfNano = True Then
            '    If dt.Rows.Item(0).Item("CPF").ToString = "" Then
            '        MsgBox("CPF/CNPJ do cliente é inválido! Não é possível emitir cupom fiscal!", MsgBoxStyle.Information)
            '        CodigoDoCliente = 0
            '        Exit Sub
            '    End If

            '    If ValidaCPF(dt.Rows.Item(0).Item("CPF").ToString) = False Then
            '        MsgBox("CPF/CNPJ do cliente é inválido! Não é possível emitir cupom fiscal!", MsgBoxStyle.Information)
            '        CodigoDoCliente = 0
            '        Exit Sub
            '    End If


            'End If

            intCodCliente = CodigoDoCliente
            Me.txtCli.Text = dt.Rows.Item(0).Item("Nome").ToString
            Me.txtCPF.Text = dt.Rows.Item(0).Item("CPF").ToString
            Me.txtCredito.Text = dt.Rows.Item(0).Item("Credito").ToString
            If dt.Rows.Item(0).Item("Limite").ToString <> "" Then
                dblLimite = dt.Rows.Item(0).Item("Limite").ToString
            Else
                dblLimite = "0,00"
            End If
            Me.txtLimite.Text = dblLimite.ToString("0.00")


            Me.txtPerDesc.Text = dt.Rows.Item(0).Item("Desconto").ToString
            If Me.txtPerDesc.Text <> "" And Me.txtPerDesc.Text <> "0,00" Then
                strDescontoCliente = Me.txtPerDesc.Text
            Else
                Me.txtPerDesc.Text = ""
                strDescontoCliente = ""
            End If



            If PafEcfNano = True Then
                If Me.txtCli.Text = "CONSUMIDOR" Then
                    Me.chkNFP.Checked = False
                Else
                    Dim bolNFP As Boolean = True
                    If dt.Rows.Item(0).Item("CPF").ToString = "" Then
                        bolNFP = False
                    End If

                    If ValidaCPF(dt.Rows.Item(0).Item("CPF").ToString) = False Then
                        bolNFP = False
                    End If


                    If bolNFP = True Then
                        If NomeEmpresa.ToUpper.Contains("RAISNER") = True Then
                            If MsgBox("Cliente deseja Nota Fiscal Paulista?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + vbDefaultButton2) = MsgBoxResult.Yes Then
                                Me.chkNFP.Checked = True
                            Else
                                Me.chkNFP.Checked = False
                            End If
                        Else
                            If MsgBox("Cliente deseja Nota Fiscal Paulista?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                Me.chkNFP.Checked = True
                            Else
                                Me.chkNFP.Checked = False
                            End If
                        End If

                    End If


                End If
            End If

            CarregarImagem(intCodCliente)

        End If

        dt = CarregarDataTable("Select Sum(ValorParcela) as Valor from ContaReceber where CodCli  =" & intCodCliente & " and RecebidoOK ='False'")

        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item("Valor").ToString = "" Then
                dblSalDev = "0,00"
            Else
                dblSalDev = dt.Rows.Item(0).Item("Valor").ToString
            End If
        Else
            dblSalDev = "0,00"
        End If

        Me.txtSalDev.Text = dblSalDev.ToString("###,###,###,##0.00")

        Me.txtCli.Enabled = True
        Me.rdgDoc.Enabled = True
        Me.txtCPF.Enabled = True


    End Sub

    Private Sub CarregarImagem(ByVal parCodigo As String)
        If parCodigo = "" Then Exit Sub
        Dim dt As DataTable = CarregarDataTable("SELECT Imagem FROM Cliente where Codigo = " & parCodigo)
        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item("Imagem").ToString <> "" Then
                Dim Imagem As Byte() = CType(dt.Rows.Item(0).Item("Imagem"), Byte())

                Dim memorybits As New MemoryStream(Imagem)

                Dim bitmap As New Bitmap(memorybits)
                Me.picLogo.Image = bitmap
                bolFoto = True
            End If
        End If
    End Sub
    Private Sub CarregarImagemProduto(ByVal parCodigo As String)
        If parCodigo = "" Then Exit Sub
        Dim dt As DataTable = CarregarDataTable("SELECT Imagem1 FROM Produto where Codigo = " & parCodigo)
        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item("Imagem1").ToString <> "" Then
                Dim Imagem As Byte() = CType(dt.Rows.Item(0).Item("Imagem1"), Byte())

                Dim memorybits As New MemoryStream(Imagem)

                Dim bitmap As New Bitmap(memorybits)
                Me.picLogo.Image = bitmap
            End If
        End If
    End Sub
    Private Sub InserirPagamento(ByVal parCrediario As Boolean)

        If Me.grd1.RowCount = 0 Then Exit Sub
        If Validar(Me.cboPag) = False Then Exit Sub
        If Me.txtTotal.Text.Trim = "0,00" Then
            MsgBox("Não é possível inserir a forma de pagamento com o valor a receber zerado!", MsgBoxStyle.Information)
            Exit Sub
        End If


        If CDbl(Me.txtValRec.Text.Trim) < 0 Then
            MsgBox("Valor inválido!", MsgBoxStyle.Information)
            Exit Sub
        End If

        If CDbl(Me.txtSubTotal.Text.Trim) < 0 Then
            MsgBox("Não é possível inserir a forma de pagamento com o valor a receber negativo!", MsgBoxStyle.Information)
            Exit Sub
        End If

        If CDbl(Me.txtSubTotal.Text.Trim) = 0 Then
            MsgBox("Não é possível inserir a forma de pagamento com o valor a receber zerado!", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim strInsert As String

        Dim strForPag As String = ""
        Dim strVisPra As String = ""

        Dim dblCred As Double


        Dim dblValRec, dblTotal, dblTroco As Double

        dblTotal = Me.txtTotal.Text.Trim

        Dim bolCredito As Boolean = False

        If Me.txtTotal.Text.Trim <> "0,00" Then

            If Me.txtCredito.Text.Trim <> "" And Me.txtCredito.Text.Trim <> "0,00" And Me.txtCredito.Text.Trim <> "0.00" And Me.txtCredito.Text.Trim <> "0,000" Then

                If MsgBox("O cliente possui créditos, deseja utilizá-los?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    strForPag = "CRÉDITO CLIENTE"
                    strVisPra = "A VISTA"
                    dblCred = Me.txtCredito.Text.Trim
                    dblCreditoVenda = Me.txtCredito.Text.Trim
                    'novo
                    bolCredito = True

                    If dblTotal > dblCred Then
                        Me.txtValRec.Text = dblCred.ToString("0.00")
                        Me.txtCredito.Text = "0,00"

                    Else

                        dblCred = dblCred - dblTotal

                        Me.txtCredito.Text = dblCred.ToString("0.00")
                        Me.txtValRec.Text = dblTotal.ToString("0.00")

                    End If

                End If
            End If
        End If


        If parCrediario = True Then
            If bolCredito = False Then
                If intCodCliente = 1 Then
                    MsgBox("Selecione o cliente antes de fazer o parcelamento!", MsgBoxStyle.Information)

                    nbcVenda.ActiveGroup = Me.nbgCli
                    Me.txtCPF.Focus()
                    Exit Sub
                End If
                If DentroLimiteCredito(Me.txtSubTotal.Text.Trim) = False Then Exit Sub

                If Validar(Me.txtVez) = False Then Exit Sub


                Dim dtPag As DataTable = CarregarDataTable("SELECT NumDias FROM Pagamento where Descricao = '" & Me.cboPag.Text & "'")
                Dim strNumDias As String = "30"
                If dtPag.Rows.Count > 0 Then
                    If dtPag.Rows.Item(0).Item("NumDias").ToString <> "" Then
                        strNumDias = dtPag.Rows.Item(0).Item("NumDias").ToString
                    End If
                End If

                Select Case intContCrediario
                    Case 0
                        bolCrediarioOK = False
                        frmCrediario1.intOrdem = intOrdem
                        frmCrediario1.intCodCliente = intCodCliente
                        frmCrediario1.dblValorCrediario = Me.txtValRec.Text.Trim
                        frmCrediario1.strPagamento = Me.cboPag.Text.Trim
                        frmCrediario1.txtValCred.Text = Me.txtValRec.Text.Trim
                        If strNumDias <> "30" Then
                            frmCrediario1.dtVen.EditValue = Date.Today.AddDays(strNumDias)
                        Else
                            frmCrediario1.dtVen.EditValue = Date.Today.AddMonths(1)
                        End If

                        frmCrediario1.seParcela.Text = Me.txtVez.Text.Trim
                        frmCrediario1.strCliente = Me.txtCli.Text
                        frmCrediario1.dblValorTotal = Me.txtValRec.Text.Trim
                        frmCrediario1.txtDias.Text = strNumDias
                        frmCrediario1.ShowDialog()
                    Case 1
                        bolCrediarioOK = False
                        frmCrediario2.intOrdem = intOrdem
                        frmCrediario2.intCodCliente = intCodCliente
                        frmCrediario2.dblValorCrediario = Me.txtValRec.Text.Trim
                        frmCrediario2.strPagamento = Me.cboPag.Text.Trim
                        frmCrediario2.txtValCred.Text = Me.txtValRec.Text.Trim
                        If strNumDias <> "30" Then
                            frmCrediario2.dtVen.EditValue = Date.Today.AddDays(strNumDias)
                        Else
                            frmCrediario2.dtVen.EditValue = Date.Today.AddMonths(1)
                        End If
                        frmCrediario2.seParcela.Text = Me.txtVez.Text.Trim
                        frmCrediario2.strCliente = Me.txtCli.Text
                        frmCrediario2.dblValorTotal = Me.txtValRec.Text.Trim
                        frmCrediario2.txtDias.Text = strNumDias
                        frmCrediario2.ShowDialog()
                    Case 2
                        bolCrediarioOK = False
                        frmCrediario3.intOrdem = intOrdem
                        frmCrediario3.intCodCliente = intCodCliente
                        frmCrediario3.dblValorCrediario = Me.txtValRec.Text.Trim
                        frmCrediario3.strPagamento = Me.cboPag.Text.Trim
                        frmCrediario3.txtValCred.Text = Me.txtValRec.Text.Trim
                        If strNumDias <> "30" Then
                            frmCrediario3.dtVen.EditValue = Date.Today.AddDays(strNumDias)
                        Else
                            frmCrediario3.dtVen.EditValue = Date.Today.AddMonths(1)
                        End If
                        frmCrediario3.seParcela.Text = Me.txtVez.Text.Trim
                        frmCrediario3.strCliente = Me.txtCli.Text
                        frmCrediario3.dblValorTotal = Me.txtValRec.Text.Trim
                        frmCrediario3.txtDias.Text = strNumDias
                        frmCrediario3.ShowDialog()
                End Select


                If bolCrediarioOK = True Then
                    intContCrediario += 1
                    bolCredOK = True
                Else
                    Exit Sub
                End If

            End If
        Else
            If Me.cboPag.Text.Contains("CHEQUE") Then
                If ExisteTabela("Cheque") = True Then
                    strInsert = "INSERT INTO Cheque (CodPed, Cliente, Vencimento, Valor, Banco, Data, Quem, RecebidoOk, " & _
                                "CodConfig, CodigoPedido) VALUES ('" & intOrdem & "','" & Me.txtCli.Text & "','" & Date.Today & "'," & Num(Me.txtValRec.Text.Trim) & "," & _
                                "'" & "" & "','" & Date.Today & "','" & "" & "','False'," & CodConfig & ",'')"
                    strCmdsPagamento &= strInsert & vbCrLf & vbCrLf
                End If

            End If
        End If

        If strForPag = "" Then
            If Validar(Me.cboPag) = False Then Exit Sub
            strForPag = Me.cboPag.Text.Trim
            strVisPra = Me.cboPag.GetColumnValue("FormaPagamento").ToString
        End If


        If Validar(Me.txtValRec) = False Then Exit Sub
        TipoCartao = ""

        If strForPag <> "CRÉDITO CLIENTE" Then


            If Me.cboPag.GetColumnValue("Prazo") = True Then


                If Validar(Me.txtVez) = False Then Exit Sub

                Dim intDias, I As Integer

                Dim dblTot, dblDes, dblTotDes, dblResul As Double

                dblTot = Me.txtValRec.Text.Trim / Val(Me.txtVez.Text.Trim)
                dblDes = Me.cboPag.GetColumnValue("Desconto")

                dblTotDes = (dblTot / 100) * dblDes
                dblResul = dblTot - dblTotDes

                intDias = Me.cboPag.GetColumnValue("Dias")

                Dim dtData As Date = Date.Today

                NumTransacao = ""

                If TEF = True Then
                    Dim dtPagamento As DataTable = CarregarDataTable("SELECT UsaTEF FROM Pagamento where Descricao = '" & Me.cboPag.Text.Trim & "'")
                    Dim bolUsaTEF As Boolean = dtPagamento.Rows.Item(0).Item("UsaTEF")
                    If bolUsaTEF = True Then
                        Dim dblValCartao As Double = Me.txtValRec.Text.Trim
                        Dim dblValCartaoARec As Double = Me.txtSubTotal.Text
                        If dblValCartao > dblValCartaoARec Then
                            MsgBox("O valor da operação não pode ser maior que o valor a receber!", MsgBoxStyle.Information)
                            Me.txtValRec.Focus()
                            Exit Sub
                        End If

                        If intCodTEF = 0 Then
                            GerarNumeroTEF()
                        End If

                        frmTEF.strValor = Me.txtValRec.Text.Trim
                        frmTEF.intVezes = Val(Me.txtVez.Text.Trim)

                        Dim strCredDeb As String = Me.cboPag.GetColumnValue("FormaPagamento").ToString
                        If strCredDeb = "A VISTA" Then
                            If Me.cboPag.Text.Trim.Contains("CRED") = True Or Me.cboPag.Text.Trim.Contains("CRÉD") = True _
                            Or Me.cboPag.Text.Trim.Contains("PARC") = True Then
                                frmTEF.intCredDeb = 3
                            Else
                                frmTEF.intCredDeb = 2
                            End If

                        Else
                            frmTEF.intCredDeb = 3
                        End If
                        ComprovanteTEF(0) = ""
                        ComprovanteTEF(1) = ""
                        frmTEF.Tag = ""
                        RetornoTEF = -1
                        frmTEF.strNumTransacao = ""
                        frmTEF.cupomFiscal = intCodTEF
                        frmTEF.ShowDialog()
                        If RetornoTEF <> 0 Then

                            'FinalizarTEF(0)
                            CancelarPagamento(True)
                            Exit Sub
                        Else
                            Dim A As Integer
                            Dim B As Integer = 0
                            For A = 0 To strComprovanteTEF.Length - 1
                                If B = 2 Then Exit For
                                If strComprovanteTEF(A) = "" Then
                                    strComprovanteTEF(A) = ComprovanteTEF(B)
                                    B += 1
                                End If
                            Next

                        End If
                    End If
                Else
                    Dim dtPagamento As DataTable = CarregarDataTable("SELECT UsaTEF FROM Pagamento where Descricao = '" & Me.cboPag.Text.Trim & "'")
                    Dim bolUsaTEF As Boolean = dtPagamento.Rows.Item(0).Item("UsaTEF")
                    If bolUsaTEF = True Then
                        MsgBox("Este computador não esta habilitado a operação de TEF!", MsgBoxStyle.Information)
                        Me.txtValRec.ResetText()
                        Me.cboPag.Focus()
                        Exit Sub
                    End If
                End If

                For I = 0 To Val(Me.txtVez.Text.Trim) - 1
                    dtData = dtData.AddDays(intDias)

                    intContPagamento += 1
                    strInsert = "If not exists(Select CodOrdem from Total where CodOrdem = 999999999 and CodConfig =" & CodConfig & ") " & _
                    "Insert into Futuro (Data, CodOrdem, Pagamento, Total, TotalDesconto, CodConfig, Recebido, CodigoPedido, Auxiliar, " & _
                    "Bandeira, NumTransacao) Values('" & dtData & "'," & intOrdem & ",'" & Me.cboPag.Text.Trim & "'," & Num(dblTot) & "," & _
                    "" & Num(dblResul) & "," & CodConfig & ",'False','','" & "AUXILIARPAGAMENTO" & intContPagamento & "'," & _
                    "'" & TipoCartao.ToUpper & "','" & NumTransacao & "')"
                    'Inserir(strInsert)
                    strCmdsPagamento &= strInsert & vbCrLf & vbCrLf


                Next
            End If
        End If

        With Me.tbPagamento.Rows
            .Add()
            .Item(.Count - 1).Item("Pagamento") = strForPag
            .Item(.Count - 1).Item("Valor") = Me.txtValRec.Text.Trim
            .Item(.Count - 1).Item("Bandeira") = TipoCartao.ToUpper
        End With

        Dim dblValor As Double = Me.txtValRec.Text.Trim


        If Me.cboPag.Text.Trim.ToUpper.Contains("DINHEIRO") Then
            Dim dblValorRec As Double = Me.txtSubTotal.Text
            If dblValor > dblValorRec Then
                dblValor = dblValorRec
            End If
        End If

        intContPagamento += 1

        strInsert = "If not exists(Select CodOrdem from Total where CodOrdem = 999999999 and CodConfig =" & CodConfig & ") Insert into Recebimento (CodOrdem, FormaPagamento, Pagamento, Valor, Documento, Data, CodConfig, CodigoPedido, Auxiliar, Bandeira) Values(" & intOrdem & ",'" & strVisPra & "','" & strForPag & "'," & Num(dblValor) & ",'" & "" & "','" & Date.Today & "'," & CodConfig & ",'','" & "AUXILIARPAGAMENTO" & intContPagamento & "','" & TipoCartao.ToUpper & "')"
        'Inserir(strInsert)


        strCmdsPagamento &= strInsert & vbCrLf & vbCrLf


        dblValRec = Me.txtValRec.Text.Trim

        dblTotalRecebido += dblValRec

        Me.txtRec.Text = dblTotalRecebido.ToString("0.00")

        dblTroco = dblTotal - dblTotalRecebido

        If dblTroco < 0 Then
            Me.txtSubTotal.Text = "0,00"

            If strForPag = "CRÉDITO CLIENTE" Then
                Me.txtCredito.Text = dblTroco.ToString("0.00").Replace("-", "")
            Else
                Me.txtTroco.Text = dblTroco.ToString("0.00").Replace("-", "")
            End If

        Else
            Me.txtSubTotal.Text = dblTroco.ToString("0.00")
            Me.txtTroco.Text = "0,00"
        End If


        Me.txtValDesc.Enabled = False
        Me.txtPorDesc.Enabled = False

        Me.txtValRec.ResetText()
        Me.txtVez.ResetText()
        Me.cboPag.EditValue = DBNull.Value
        Me.cboPag.Focus()

        If Me.txtSubTotal.Text.Trim = "0,00" Then
            Me.cboPag.Enabled = False
            Me.btnCred.Enabled = False
            Me.txtVez.Enabled = False
            Me.txtValRec.Enabled = False

            If TEF = True And intCodTEF > 0 Then
                Finalizar()
                Exit Sub
            Else
                If MsgBox("Deseja finalizar a venda?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    Finalizar()
                    Exit Sub
                End If
            End If

        End If

        Me.txtCli.Enabled = False
        Me.rdgDoc.Enabled = False
        Me.txtCPF.Enabled = False
    End Sub

    Private Sub cboPag_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPag.EditValueChanged
        If cboPag.GetColumnValue("FormaPagamento") = "A VISTA" Then
            Me.txtVez.Text = 1
            Me.txtVez.Enabled = False
            Me.btnCred.Enabled = False
            Me.btnOK.Enabled = True
        Else
            'Me.txtVez.ResetText()
            Me.txtVez.Text = 1
            Me.txtVez.Enabled = True

            If cboPag.GetColumnValue("Prazo") = False Then
                Me.btnCred.Enabled = True
                Me.btnOK.Enabled = False
            Else
                Me.btnOK.Enabled = True
                Me.btnCred.Enabled = False
            End If

        End If

    End Sub

    Private Sub cboPag_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPag.Leave
        Me.txtValRec.Text = Me.txtSubTotal.Text
    End Sub

    Private Sub btnCanPag_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCanPag.ItemClick
        If Me.grd1.RowCount = 0 Then Exit Sub

        If MsgBox("Deseja realmente excluir as formas de pagamento dessa venda?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            CancelarPagamento(True)
            Calcular()
            EntradaPedido()
            MsgBox("Formas de pagamento excluídas com sucesso!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub CancelarPagamento(ByVal parCliente As Boolean)

        Me.txtValRec.ResetText()
        Me.txtRec.ResetText()
        Me.txtTroco.ResetText()

        Me.txtValDesc.Enabled = True
        Me.txtPorDesc.Enabled = True
        Me.rdgDesc.Enabled = True
        Me.txtValDesc.ResetText()
        Me.txtPorDesc.ResetText()

        DescontoComPorcentagem(False)


        Me.cboPag.Enabled = True
        Me.txtVez.Enabled = True
        Me.txtValRec.Enabled = True

        dblTotalRecebido = 0

        strCmdsPagamento = ""
        Me.tbPagamento.Rows.Clear()
        frmCrediario1.tdCred.Rows.Clear()
        frmCrediario2.tdCred.Rows.Clear()
        frmCrediario3.tdCred.Rows.Clear()
        intContCrediario = 0
        bolCredOK = False
        bolCrediarioOK = False
        intContPagamento = 0

        'Excluir("Delete from Recebimento where CodOrdem =" & intOrdem & " and CodConfig =" & CodConfig)
        'Excluir("Delete from Futuro where CodOrdem =" & intOrdem & " and CodConfig =" & CodConfig)
        'Excluir("Delete from ContaReceber where CodOrdem =" & intOrdem & " and CodConfig =" & CodConfig)


        If parCliente = True Then
            FinalizarTEF(0)
            TrazCliente()
        End If


        'Dim dt As DataTable = CarregarDataTable("Select Nome, CPF, Credito from Cliente where Codigo =" & intCodCliente)

        'If dt.Rows.Count > 0 Then
        '    Me.txtCli.Text = dt.Rows.Item(0).Item("Nome").ToString
        '    Me.txtCPF.Text = dt.Rows.Item(0).Item("CPF").ToString
        '    Me.txtCredito.Text = dt.Rows.Item(0).Item("Credito").ToString
        'End If

    End Sub

    Private Sub btnDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        If Me.grd1.RowCount = 0 Then Exit Sub

        If MsgBox("Deseja realmente excluir o item selecionado?" & vbCrLf & "Obs: Ao excluir um item, a forma de pagamento também será excluída!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            If NomeEmpresa.ToUpper.Trim.Contains("JÉSSICA COSMÉTICOS") = True Then
                If SenhaEstaOK() = False Then Exit Sub
            Else
                If SenhaAdm = True Then
                    If Nivel = "USUÁRIO" Then
                        If SenhaEstaOK() = False Then Exit Sub
                    End If
                End If
              
            End If


            Dim dblQtd As Double = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colQtde)
            Dim strCodProduto As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodProd)
            Dim strProduto As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colProduto)

            If dblQtd > 1 Then
                QtdeExcluida = 0
                Dim frm As New frmTamanhoProd
                frm.Tag = "QTDE"
                frm.dblQtdVenda = dblQtd
                frm.ShowDialog()
                If QtdeExcluida > 0 Then
                    dblQtd = dblQtd - QtdeExcluida
                    If dblQtd = 0 Then
                        Me.grd1.DeleteRow(grd1.FocusedRowHandle)
                    Else
                        Me.grd1.SetRowCellValue(Me.grd1.FocusedRowHandle, Me.colQtde, dblQtd.ToString("0.000"))
                    End If

                    CancelarPagamento(False)
                    Calcular()
                    EntradaPedido()
                End If

            Else
                Me.grd1.DeleteRow(grd1.FocusedRowHandle)
                CancelarPagamento(False)
                Calcular()
                EntradaPedido()
            End If

            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
            "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strProduto & "'," & _
            "'Cód. Prod.: " & strCodProduto & " Qtde: " & dblQtd & "','ITENS VENDA','ITENS VENDA','EXCLUSÃO'," & CodConfig & ")")

        End If

        If Me.grd1.RowCount = 0 Then
            intCodPedido = 0
            Me.picFundo.Visible = True
        End If
        Me.txtCodPro.Focus()
    End Sub

    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        If grd1.RowCount = 0 Then Exit Sub
        If MsgBox("Deseja realmente CANCELAR a venda atual?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If MsgBox("Você tem certeza?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If NomeEmpresa.ToUpper.Trim.Contains("JÉSSICA COSMÉTICOS") = True Then
                    If SenhaEstaOK() = False Then Exit Sub
                Else
                    If SenhaAdm = True Then
                        If Nivel = "USUÁRIO" Then
                            If SenhaEstaOK() = False Then Exit Sub
                        End If
                    End If
                
                End If

                Dim I As Integer
                For I = 0 To Me.grd1.RowCount - 1

                    Dim dblQtd As Double = Me.grd1.GetRowCellDisplayText(I, Me.colQtde)
                    Dim strCodProduto As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodProd)
                    Dim strProduto As String = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)

                    Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                    "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strProduto & "'," & _
                    "'Cód. Prod.: " & strCodProduto & " Qtde: " & dblQtd & "','ITENS VENDA','VENDA','EXCLUSÃO'," & CodConfig & ")")

                Next
                CancelarPagamento(True)
                Limpar()
            End If
        End If
    End Sub

    Private Sub Limpar()
        Me.rdgTipoProd.SelectedIndex = 0
        intCodTEF = 0
        Me.picFundo.Visible = True
        Me.chkNFP.Checked = False
        Me.rdgDoc.SelectedIndex = -1
        intCont = 0
        dblTotalDeCusto = 0
        dblTotalSemDesconto = 0
        bolCrediarioOK = False
        CodigoFuncionario = 0
        intCodFunc = 0
        intCodMecanico = 0
        NomeFuncionario = ""
        Me.lblVend2.Caption = "                            "

        dblTotalRecebido = 0
        intCodCliente = 1

        intCodPedido = 0
        'intCodComanda = 0
        strCodComanda = ""

        bolMSGCliente = False

        CodigoDoCliente = 1

        TrazCliente()

        Me.txtCodPro.ResetText()
        Me.txtPerDesc.ResetText()
        Me.txtQtd.ResetText()
        Me.txtProd.ResetText()
        Me.txtValor.ResetText()

        Me.tbItens.Rows.Clear()

        Me.rdgDesc.SelectedIndex = 0

        Me.txtPorDesc.ResetText()
        Me.txtValDesc.ResetText()
        Me.txtPorAcre.ResetText()
        Me.txtValAcre.ResetText()

        Me.cboPag.EditValue = DBNull.Value
        Me.txtVez.ResetText()
        Me.txtVez.Enabled = True
        Me.txtValRec.ResetText()
        Me.txtRec.ResetText()
        Me.txtTroco.ResetText()
        Me.txtLimite.ResetText()
        Me.grpItens.Text = "Nº de Itens: 0 "

        Me.txtSubTotal.Text = "0,00"
        Me.txtTotal.Text = "0,00"

        Me.cboPag.Enabled = True
        Me.btnCred.Enabled = True
        Me.txtVez.Enabled = True
        Me.txtValRec.Enabled = True

        Me.txtCli.Enabled = True
        Me.rdgDoc.Enabled = True
        Me.txtCPF.Enabled = True

        Me.nbcVenda.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        Me.strCmdsSQL = ""
        Me.strCmdsPagamento = ""
        Me.tbPagamento.Rows.Clear()
        frmCrediario1.tdCred.Rows.Clear()
        frmCrediario2.tdCred.Rows.Clear()
        frmCrediario3.tdCred.Rows.Clear()
        intContCrediario = 0

        Me.txtCodPro.Focus()

        If TabelaPreco <> "" Then
            Dim dtTab As DataTable = CarregarDataTable("SELECT Codigo FROM Grupo where Tipo = 'T' and Nome = '" & TabelaPreco & "'")
            If dtTab.Rows.Count > 0 Then
                Me.lblTabela.Caption = TabelaPreco
            Else
                Me.lblTabela.Caption = "PADRÃO"
            End If
        Else
            Me.lblTabela.Caption = "PADRÃO"
        End If

        strPlaca = ""
        strKM = ""
        strModelo = ""

    End Sub

    Private Sub txtCli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCli.KeyDown, txtCPF.KeyDown
        If e.KeyCode = Keys.F10 Then
            AbreCliente()
        End If
    End Sub

    Private Sub btnFinalizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFinalizar.ItemClick

        If TesteConexao() = False Then Exit Sub

        Finalizar()
    End Sub
    Private Sub BuscaProduto(ByVal parCodigo As Integer)
        dtProduto = CarregarDataTable("SELECT * FROM Produto where Codigo = " & parCodigo)
    End Sub
    Private Sub Finalizar()

        If Me.tbItens.Rows.Count = 0 Then Exit Sub
        If VendaFinalizada = True Then Exit Sub

        Try
            strAuxiliar = NomeComputador.ToUpper & " " & Format(My.Computer.Clock.LocalTime, "dd/MM/yyyy HH:mm:ss:fffff")
        Catch ex As Exception
            strAuxiliar = NomeComputador.ToUpper & " " & Date.Today.Day & "/" & Date.Today.Month & "/" & Date.Today.Year & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now)
        End Try



        If PafEcfNano = True Then
            If Me.chkNFP.Checked = True Then
                If Me.txtCPF.Text = "" Then
                    MsgBox("CPF/CNPJ do cliente é inválido! Não é possível emitir cupom fiscal!" & vbCrLf & "Informe CPF/CNPJ válido ou desabilite a opção CPF na nota.", MsgBoxStyle.Information)
                    Me.txtCPF.Focus()
                    Exit Sub
                End If
                If ValidaCPF(Me.txtCPF.Text) = False Then
                    MsgBox("CPF/CNPJ do cliente é inválido! Não é possível emitir cupom fiscal!" & vbCrLf & "Informe CPF/CNPJ válido ou desabilite a opção CPF na nota.", MsgBoxStyle.Information)
                    Me.txtCPF.Focus()
                    Exit Sub
                End If
            End If

        End If

        If frmCrediario1.tdCred.Rows.Count > 0 Then
            If Me.txtCli.Text = "CONSUMIDOR" Then
                MsgBox("Não é possível fazer venda a prazo para o cliente 'CONSUMIDOR'!", MsgBoxStyle.Information)
                Exit Sub
            End If
        End If


        If GerarComissao = True Then
            If intCodFunc = Nothing Or intCodFunc = 0 Then
                MsgBox("Informe o vendedor!", MsgBoxStyle.Information)
                Exit Sub
            End If
        End If


        If NomeEmpresa.Contains("PASTELARIA") = False Then

            If CDbl(Me.txtSubTotal.Text.Trim) < 0 Then
                MsgBox("A venda não pode ser finalizada com o Total Geral negativo!", MsgBoxStyle.Information)
                Exit Sub
            End If

            If Me.txtTotal.Text.Trim <> "0,00" Then
                If Me.txtRec.Text.Trim = "" Then MsgBox("Informe a Forma de Pagamento da Venda!", MsgBoxStyle.Information) : Exit Sub
            End If


            If Me.txtSubTotal.Text <> "0,00" Then
                MsgBox("Faltam R$ " & Me.txtSubTotal.Text.Trim & " a receber, informe o valor restante!", MsgBoxStyle.Information)
                Exit Sub
            End If
        Else
            Me.txtTroco.Text = "0,00"
        End If


        Dim I As Integer

        Dim bolDevolvi As Boolean = False
        Dim bolSoServico As Boolean = True
        With grd1

            For I = 0 To .RowCount - 1

                'If .GetRowCellDisplayText(I, Me.colCodVendaDev) = "" Then

                bolDevolvi = False

                Try
                    If .GetRowCellDisplayText(I, Me.colCodVendaDev) <> "" Then
                        bolDevolvi = True
                    End If
                Catch ex As Exception
                End Try


                Dim strUniSemDesc, strQtd, strCodProdAut, strProd, strUni, strTot, strCodProdInt, strCodFunc, strCusto, strUm, strTamanho, strLote, strQtdMed, strDesconto, strValorFrete As String

                strQtd = .GetRowCellDisplayText(I, Me.colQtde)

                strCodProdAut = .GetRowCellDisplayText(I, Me.colCodProdAut)
                strProd = .GetRowCellDisplayText(I, Me.colProduto)
                strUni = .GetRowCellDisplayText(I, Me.colUnitario)
                strTot = .GetRowCellDisplayText(I, Me.colTotal)
                strCodProdInt = .GetRowCellDisplayText(I, Me.colCodProd)
                strCodFunc = .GetRowCellDisplayText(I, Me.colCodFunc)
                strCusto = (CDbl(.GetRowCellDisplayText(I, Me.colCusto)) * CDbl(strQtd)).ToString("0.00")
                strUm = .GetRowCellDisplayText(I, Me.colUM)
                strTamanho = .GetRowCellDisplayText(I, Me.colTamanho)
                strQtdMed = .GetRowCellDisplayText(I, Me.colQtdMedida)
                strDesconto = .GetRowCellDisplayText(I, Me.colDesconto)
                strUniSemDesc = .GetRowCellDisplayText(I, Me.colValorSemDesconto)
                strValorFrete = .GetRowCellDisplayText(I, Me.colValorFrete)

                Dim strTabPreco As String = .GetRowCellDisplayText(I, Me.colTabelaPreco)
                Dim J As Integer = 0

                If MontarKit = False Then
                    Dim dtReceita As DataTable

                    dtReceita = CarregarDataTable("Select CodProd, Qtd, TipoValor from ItensReceita where CodigoInterno ='" & strCodProdInt & "'")

                    Dim dblVaCusto, dblSomaCusto As Double
                    Dim bolAlterarPreco As Boolean = True

                    For J = 0 To dtReceita.Rows.Count - 1
                        Dim dblQtdReceita As Double = dtReceita.Rows.Item(J).Item("Qtd").ToString * strQtd
                        If bolDevolvi = False Then

                            Dim dtUM As DataTable = CarregarDataTable("SELECT UnidadeMedida FROM Produto where Codigo = " & dtReceita.Rows.Item(J).Item("CodProd").ToString)
                            Dim strUMReceita As String = "UN"
                            If dtUM.Rows.Count > 0 Then
                                strUMReceita = dtUM.Rows.Item(0).Item("UnidadeMedida").ToString
                            End If

                            If EstoqueSomado = True Then
                                Me.strCmdsSQL &= AjustarEmFalta(dtReceita.Rows.Item(J).Item("CodProd").ToString, dblQtdReceita, True)
                                dblVaCusto = 1
                            Else
                                dblVaCusto = BaixarProduto(dtReceita.Rows.Item(J).Item("CodProd").ToString, dblQtdReceita, strTamanho, strUMReceita, True, True)
                            End If
                        End If

                        If dblVaCusto = 0 Then
                            bolAlterarPreco = False
                        Else
                            BuscaProduto(dtReceita.Rows.Item(J).Item("CodProd").ToString)
                            Dim dblCusto, dblCustoTotal, dblValor, dblValorTotal As Double
                            dblCusto = dtProduto.Rows.Item(0).Item("ValorCusto").ToString
                            dblCustoTotal = dblCusto * dtReceita.Rows.Item(J).Item("Qtd").ToString * strQtd
                            dblValor = dtProduto.Rows.Item(0).Item("Valor").ToString
                            dblValorTotal = dblValor * dtReceita.Rows.Item(J).Item("Qtd").ToString * strQtd

                            'Inserir("Insert into Pedido (CodOrdem, CodProd, Qtd, Produto, ValorUnitario, ValorTotal, CodProdInterno, Custo, UM, TipoItens, CodConfig, CodFunc, Devolvido) Values(" & intOrdem & "," & dtReceita.Rows.Item(J).Item("CodProd").ToString & "," & Num(dtReceita.Rows.Item(J).Item("Qtd").ToString) & ",'" & dtProduto.Rows.Item(0).Item("Nome").ToString & "'," & Num(dblValor) & "," & Num(dblValorTotal) & ",'" & dtProduto.Rows.Item(0).Item("CodigoInterno").ToString & "'," & Num(dblCustoTotal) & ",'" & dtProduto.Rows.Item(0).Item("UnidadeMedida").ToString & "','" & "RECEITA" & "'," & CodConfig & "," & intCodFunc & ",'False')")
                            Me.strCmdsSQL &= "If not exists(Select CodOrdem from Total where CodOrdem = 999999999 and CodConfig =" & CodConfig & ") Insert into Pedido(CodOrdem, CodProd, Qtd, Produto, ValorUnitario, ValorTotal, " & _
                            "CodProdInterno, Custo, UM, TipoItens, CodConfig, CodFunc, Devolvido, CodMecanico, Desconto, " & _
                            "UniSemDesc, Auxiliar, TabelaPreco) Values(" & intOrdem & "," & dtReceita.Rows.Item(J).Item("CodProd").ToString & "," & _
                            "" & Num(dblQtdReceita) & ",'" & dtProduto.Rows.Item(0).Item("Nome").ToString & "'," & Num(dblValor) & "," & _
                            "" & Num(dblValorTotal) & ",'" & dtProduto.Rows.Item(0).Item("CodigoInterno").ToString & "'," & _
                            "" & Num(dblCustoTotal) & ",'" & dtProduto.Rows.Item(0).Item("UnidadeMedida").ToString & "'," & _
                            "'" & "CONSUMO" & "'," & CodConfig & "," & intCodFunc & ",'False'," & intCodMecanico & "," & _
                            "" & Num(strDesconto) & "," & Num(strUniSemDesc) & ",'" & strAuxiliar & J & "','" & strTabPreco & "')" & vbCrLf & vbCrLf

                        End If

                        dblSomaCusto += dblVaCusto

                        If EstoqueSomado = False Then
                            If dtReceita.Rows.Count - 1 = J Then
                                If bolAlterarPreco = True Then
                                    'Atualizar("Update Produto set ValorCusto =" & Num(dblSomaCusto) & " where CodigoInterno ='" & strCodProdInt & "'")
                                    Me.strCmdsSQL &= "Update Produto set ValorCusto =" & Num(dblSomaCusto) & " where CodigoInterno ='" & strCodProdInt & "'"

                                End If
                            End If
                        End If

                    Next
                End If

                strLote = ""

                Dim strQtdTemp As String = ""

                If strQtdMed <> "0" And strQtdMed <> "" Then
                    strQtdTemp = strQtd
                    strQtd = strQtdMed
                End If

                If bolDevolvi = False Then
                    If EstoqueSomado = True Then
                        Me.strCmdsSQL &= AjustarEmFalta(strCodProdAut, strQtd, True)
                    Else
                        strLote = BaixarProduto(strCodProdAut, strQtd, strTamanho, strUm, False, True)
                    End If

                End If

                If strQtdTemp <> "" Then
                    strQtd = strQtdTemp
                End If


                If strLote.Trim = "" Then
                    strLote = "ACABOU"
                End If

                If bolDevolvi = True Then
                    strQtd = "-" & strQtd
                End If

                If EstoqueSomado = False Then
                    If strLote <> "" Then
                        Dim dtCusto As DataTable = CarregarDataTable("Select ValorCusto From Qtde Where " & _
                        "Lote='" & strLote & "' And CodProd='" & strCodProdAut & "'")

                        Dim strCustoLote As String = ""
                        Dim dlCustoLote As Double = 0
                        If dtCusto.Rows.Count > 0 Then
                            strCustoLote = dtCusto.Rows.Item(0).Item("ValorCusto").ToString
                        End If

                        If strCustoLote <> "" Then
                            dlCustoLote = CDbl(strCustoLote).ToString("0.000") * CDbl(strQtd).ToString("0.000")
                            strCusto = dlCustoLote.ToString("0.000")
                        End If
                    End If
                End If

                Dim strTipoProduto As String = Me.grd1.GetRowCellDisplayText(I, Me.colTipoProduto)
                Dim strTipoItens As String = "VENDA"
                If strTipoProduto = "SERVIÇO" Then
                    strTipoItens = "SERVIÇO"
                Else
                    bolSoServico = False
                End If

                Dim intComissao As Double = 0
                Dim strCodFuncionario As String = intCodFunc

                If TipoNano = 5 Then
                    strCodFuncionario = Me.grd1.GetRowCellDisplayText(I, Me.colCodFunc)
                End If
                If GerarComissao = True Then
                    Dim dtFunc As DataTable = Nothing

                    If ComissaoProduto = False Then
                        If strTipoProduto = "SERVIÇO" Then
                            dtFunc = CarregarDataTable("SELECT ComServ FROM Funcionario where Codigo = " & strCodFuncionario)
                        Else
                            strTipoProduto = "PRODUTO"
                            dtFunc = CarregarDataTable("SELECT PorcComissao FROM Funcionario where Codigo = " & strCodFuncionario)
                        End If
                        If dtFunc.Rows.Count > 0 Then
                            If dtFunc.Rows.Item(0).ItemArray(0).ToString <> "" Then
                                intComissao = dtFunc.Rows.Item(0).ItemArray(0)
                            End If
                        End If
                    Else
                        If strTipoProduto <> "SERVIÇO" Then
                            strTipoProduto = "PRODUTO"
                        End If
                        intComissao = Me.grd1.GetRowCellDisplayText(I, Me.colComissaoProduto)
                    End If
                End If


                'Inserir("Insert into Pedido (CodOrdem, Qtd, CodProd, Produto, ValorUnitario, ValorTotal, CodProdInterno, CodFunc, Custo, Um, Tamanho, Lote, TipoItens, CodConfig, Devolvido) Values(" & intOrdem & "," & Num(strQtd) & "," & strCodProdAut & ",'" & strProd & "'," & Num(strUni) & "," & Num(strTot) & ",'" & strCodProdInt & "'," & strCodFunc & "," & Num(strCusto) & ",'" & strUm & "','" & strTamanho & "','" & strLote & "','VENDA'," & CodConfig & ",'False')")
                Me.strCmdsSQL &= "If not exists(Select CodOrdem from Total where CodOrdem = 999999999 and CodConfig =" & CodConfig & ") Insert into Pedido (CodOrdem, Qtd, CodProd, Produto, ValorUnitario, ValorTotal, " & _
                "CodProdInterno, CodFunc, Custo, Um, Tamanho, Lote, TipoItens, CodConfig, Devolvido, CodMecanico, " & _
                "Desconto, UniSemDesc, Auxiliar, PorcComissao, ValorFrete, TabelaPreco) Values(" & intOrdem & "," & Num(strQtd) & "," & strCodProdAut & ",'" & strProd & "'," & _
                "" & Num(strUni) & "," & Num(strTot) & ",'" & strCodProdInt & "'," & strCodFuncionario & "," & Num(strCusto) & "," & _
                "'" & strUm & "','" & strTamanho & "','" & strLote & "','" & strTipoItens & "'," & CodConfig & ",'False'," & intCodMecanico & "," & _
                "" & Num(strDesconto) & "," & Num(strUniSemDesc) & ",'" & strAuxiliar & I & "P" & "'," & Num(intComissao) & "," & Num(strValorFrete) & ",'" & strTabPreco & "')" & vbCrLf & vbCrLf

                If strQtdMed <> "0" And strQtdMed <> "" Then

                    If CDbl(strQtdMed) > CDbl(strQtd) Then
                        strQtd = strQtdMed - strQtd
                    End If

                    If CDbl(strQtd) > CDbl(strQtdMed) Then
                        strQtd = strQtd - strQtdMed
                    End If

                    If strQtd <> 0 Then
                        Me.strCmdsSQL &= "If not exists(Select CodOrdem from Total where CodOrdem = 999999999 and CodConfig =" & CodConfig & ") Insert into Pedido (CodOrdem, Qtd, CodProd, Produto, ValorUnitario, ValorTotal, " & _
                        "CodProdInterno, CodFunc, Custo, Um, Tamanho, Lote, TipoItens, CodConfig, Devolvido, CodMecanico, " & _
                        "Desconto, UniSemDesc, Auxiliar, TabelaPreco) Values(" & intOrdem & "," & Num(strQtd) & "," & strCodProdAut & ",'" & strProd & "'," & _
                        "" & Num(strUni) & "," & Num(strTot) & ",'" & strCodProdInt & "'," & strCodFuncionario & "," & Num(strCusto) & "," & _
                        "'" & strUm & "','" & strTamanho & "','" & strLote & "','CONSUMO'," & CodConfig & ",'False'," & intCodMecanico & "," & _
                        "" & Num(strDesconto) & "," & Num(strUniSemDesc) & ",'" & strAuxiliar & J & "','" & strTabPreco & "')" & vbCrLf & vbCrLf
                    End If

                End If

                If bolDevolvi = True Then
                    FinalizarDevolucao(.GetRowCellDisplayText(I, Me.colCodVendaDev), I)
                End If
                'Else


                'End If

                'If TipoNano = 2 Then
                '    strCodFuncionario = Me.grd1.GetRowCellDisplayText(I, Me.colCodMecanico)
                'End If


                Dim dblTotProd As Double = strTot
                intComissao = 0
                If GerarComissao = True Then
                    If dblCreditoVenda = Nothing Or dblCreditoVenda = 0 Then

                        'If dblTotProd > 0 Then
                        Dim dtFunc As DataTable = Nothing


                        If ComissaoProduto = False Then
                            If strTipoProduto = "SERVIÇO" Then
                                dtFunc = CarregarDataTable("SELECT ComServ FROM Funcionario where Codigo = " & strCodFuncionario)
                            Else
                                strTipoProduto = "PRODUTO"
                                dtFunc = CarregarDataTable("SELECT PorcComissao FROM Funcionario where Codigo = " & strCodFuncionario)
                            End If
                            If dtFunc.Rows.Count > 0 Then
                                If dtFunc.Rows.Item(0).ItemArray(0).ToString <> "" Then
                                    intComissao = dtFunc.Rows.Item(0).ItemArray(0)
                                End If
                            End If
                        Else
                            If strTipoProduto <> "SERVIÇO" Then
                                strTipoProduto = "PRODUTO"
                            End If
                            intComissao = Me.grd1.GetRowCellDisplayText(I, Me.colComissaoProduto)
                        End If

                        If TipoDesconto = "TOTAL" Then
                            If Me.txtPorDesc.Text <> "" And Me.txtPorDesc.Text <> "0,000" Then
                                Select Case strTipoProduto
                                    Case "PRODUTO"

                                        Dim dblPorc As Double
                                        dblPorc = (dblTotProd / 100) * Me.txtPorDesc.Text
                                        dblTotProd = dblTotProd - dblPorc
                                    Case "SERVIÇO"
                                        Dim dblPorc As Double
                                        dblPorc = (dblTotProd / 100) * Me.txtPorDesc.Text
                                        dblTotProd = dblTotProd - dblPorc
                                End Select
                            End If
                            
                        End If

                        Dim dblResul As Double = (dblTotProd / 100) * intComissao
                        Dim strCmdInsert As String = "If not exists(Select CodOrdem from Total where CodOrdem = 999999999 and " & _
                        "CodConfig =" & CodConfig & ") Insert into Comissao(CodOrdem, CodFunc, ValorProduto, Porcentagem, ValorComissao, " & _
                        "Data, Tipo, CodConfig, Pago, Auxiliar, TipoProduto)Values(" & intOrdem & "," & strCodFuncionario & "," & Num(dblTotProd) & "," & _
                        "" & Num(intComissao) & "," & Num(dblResul) & ",'" & Date.Today & "','" & "C" & "'," & CodConfig & ",'False'," & _
                        "'" & strAuxiliar & "','" & strTipoProduto & "' )"
                        Me.strCmdsSQL &= strCmdInsert & vbCrLf & vbCrLf
                        'End If
                    End If
                End If


                If TipoNano = 5 Then
                    Try
                        Dim dtRevisao As DataTable = CarregarDataTable("Select KM from Produto where Codigo = " & strCodProdAut)

                        Dim intMes, intKm, intKmMes As Integer
                        intMes = 0
                        intKm = 0
                        intKmMes = 0
                        If dtRevisao.Rows.Count > 0 Then
                            If strKMMes <> "" Then
                                If Not dtRevisao.Rows(0).ItemArray(0).ToString.Trim = Nothing Then
                                    intKm = dtRevisao.Rows(0).ItemArray(0).ToString.Trim
                                End If
                                intKmMes = strKMMes

                                Dim dblKmMes As Double
                                dblKmMes = intKm / intKmMes
                                Try
                                    intMes = dblKmMes
                                Catch ex As Exception
                                    intMes = 0
                                End Try

                                If intMes > 0 Then
                                    Dim strInsert As String
                                    Dim dtData As Date
                                    Dim intNovoKm As Integer

                                    intNovoKm = Val(strKM) + intKm
                                    dtData = Date.Today
                                    dtData = dtData.AddMonths(intMes)
                                    strInsert = "Insert into Revisao (CodOrdem, Placa, Produto, Revisao, UltimoKM, ProximoKM, CodConfig) Values(" & intOrdem & ",'" & strPlaca & "','" & strProd & "','" & dtData & "','" & strKM & "','" & intNovoKm & "'," & CodConfig & ")"
                                    Me.strCmdsSQL &= strInsert & vbCrLf & vbCrLf
                                End If
                            End If
                        End If
                    Catch ex As Exception

                    End Try

                End If
            Next

        End With

        If dblCreditoVenda <> Nothing And dblCreditoVenda <> 0 Then
            Dim dblCredVend As Double = dblCreditoVenda

            If GerarComissao = True Then

                Dim dblTotalProduto As Double = Me.txtTotal.Text.Trim
                Dim dblResulCred As Double = dblTotalProduto - dblCreditoVenda

                For I = 0 To Me.grd1.RowCount - 1
                    If dblResulCred > 0 Then
                        Dim dtFunc As DataTable = Nothing
                        Dim strTipoProduto As String = Me.grd1.GetRowCellDisplayText(I, Me.colTipoProduto)
                        Dim strTipoItens As String = "VENDA"
                        If strTipoProduto = "SERVIÇO" Then
                            strTipoItens = "SERVIÇO"
                        End If
                        Dim intComissao As Double = 0
                        Dim strCodFuncionario As String = intCodFunc
                        If TipoNano = 5 Then
                            strCodFuncionario = Me.grd1.GetRowCellDisplayText(I, Me.colCodFunc)
                        End If
                        If ComissaoProduto = False Then
                            If strTipoProduto = "SERVIÇO" Then
                                dtFunc = CarregarDataTable("SELECT ComServ FROM Funcionario where Codigo = " & strCodFuncionario)
                            Else
                                strTipoProduto = "PRODUTO"
                                dtFunc = CarregarDataTable("SELECT PorcComissao FROM Funcionario where Codigo = " & strCodFuncionario)
                            End If
                            If dtFunc.Rows.Count > 0 Then
                                If dtFunc.Rows.Item(0).ItemArray(0).ToString <> "" Then
                                    intComissao = dtFunc.Rows.Item(0).ItemArray(0)
                                End If
                            End If
                        Else
                            If strTipoProduto <> "SERVIÇO" Then
                                strTipoProduto = "PRODUTO"
                            End If
                            intComissao = Me.grd1.GetRowCellDisplayText(I, Me.colComissaoProduto)
                        End If

                        Dim dblTotProd As Double = Me.grd1.GetRowCellDisplayText(I, Me.colTotal)
                        Dim dblResulCredito As Double = dblResulCred - dblTotProd
                        If dblResulCredito <= 0 Then
                            dblTotProd = dblResulCred
                            dblResulCred = 0
                        Else
                            dblResulCred = dblResulCredito
                        End If

                        Dim dblResul As Double = (dblTotProd / 100) * intComissao
                        Dim strCmdInsert As String = "If not exists(Select CodOrdem from Total where CodOrdem = 999999999 and " & _
                        "CodConfig =" & CodConfig & ") Insert into Comissao(CodOrdem, CodFunc, ValorProduto, Porcentagem, ValorComissao, " & _
                        "Data, Tipo, CodConfig, Pago, Auxiliar, TipoProduto)Values(" & intOrdem & "," & strCodFuncionario & "," & Num(dblTotProd) & "," & _
                        "" & Num(intComissao) & "," & Num(dblResul) & ",'" & Date.Today & "','" & "C" & "'," & CodConfig & ",'False'," & _
                        "'" & strAuxiliar & "','" & strTipoProduto & "' )"
                        Me.strCmdsSQL &= strCmdInsert & vbCrLf & vbCrLf
                        'End If
                    End If
                Next




            End If
        End If

        Dim strHora As String = Format(Hour(Now), "00") & ":" & Format(Minute(Now), "00")


        Dim bolNFP As Boolean = False

        If CpfNaNota = True Then
            bolNFP = Me.chkNFP.Checked
        End If

        Dim strValDes, strPorDesc, strValAcre, strPorAcre As String

        If Me.rdgDesc.SelectedIndex = 0 Then
            strValDes = Me.txtValDesc.Text.Trim
            strPorDesc = Me.txtPorDesc.Text.Trim
            strValAcre = "0,00"
            strPorAcre = "0,00"
        Else
            strValAcre = Me.txtValDesc.Text.Trim
            strPorAcre = Me.txtPorDesc.Text.Trim
            strValDes = "0,00"
            strPorDesc = "0,00"
        End If


        ''''COMISSÃO''''


        'If intCodFunc > 0 And intCodFunc <> Nothing Then
        '   
        '    If ComissaoProduto = False Then
        '        Dim dblTotProd As Double
        '        dblTotProd = Me.txtTotal.Text.Trim
        '        If dblCreditoVenda <> Nothing And dblCreditoVenda <> 0 Then
        '            dblTotProd = dblTotProd - dblCreditoVenda
        '        End If

        '        If dblTotProd > 0 Then
        '            Dim vetFunc As Array = Split(RetornaFunc(intCodFunc), "|")

        '            Dim dblResul As Double

        '            Dim intComPec As Double

        '            intComPec = vetFunc(1)



        '            Dim A As Integer
        '            Dim dblValPresente As Double = 0
        '            For A = 0 To Me.tbPagamento.Rows.Count - 1
        '                Dim strPagPresente As String = Me.tbPagamento.Rows.Item(A).Item("Pagamento").ToString
        '                If strPagPresente = "VALE PRESENTE" Then
        '                    dblValPresente += Me.tbPagamento.Rows.Item(A).Item("Valor").ToString
        '                End If
        '            Next


        '            Dim dblReselComissao As Double = dblTotProd - dblValPresente
        '            dblResul = (dblReselComissao / 100) * intComPec
        '            strCmdInsert = "If not exists(Select CodOrdem from Total where CodOrdem = 999999999 and CodConfig =" & CodConfig & ") Insert into Comissao(CodOrdem, CodFunc, ValorProduto, Porcentagem, ValorComissao, Data, Tipo, CodConfig, Pago, Auxiliar) Values(" & intOrdem & "," & intCodFunc & "," & Num(dblReselComissao) & "," & Num(intComPec) & "," & Num(dblResul) & ",'" & Date.Today & "','" & "C" & "'," & CodConfig & ",'False','" & strAuxiliar & "')"
        '            'Atualizar(strCmdInsert)
        '            Me.strCmdsSQL &= strCmdInsert & vbCrLf & vbCrLf
        '        End If
        '    Else
        '        Dim dblReselComissao As Double
        '        For I = 0 To Me.grd1.RowCount - 1
        '            Dim dblValor As Double = Me.grd1.GetRowCellDisplayText(I, Me.colTotal)
        '            Dim dblComissao As Double = Me.grd1.GetRowCellDisplayText(I, Me.colComissaoProduto)

        '            Dim dblResul As Double = (dblValor / 100) * dblComissao
        '            dblReselComissao += dblResul
        '        Next
        '        strCmdInsert = "If not exists(Select CodOrdem from Total where CodOrdem = 999999999 and CodConfig =" & CodConfig & ") Insert into Comissao(CodOrdem, CodFunc, ValorProduto, Porcentagem, ValorComissao, Data, Tipo, CodConfig, Pago, Auxiliar) Values(" & intOrdem & "," & intCodFunc & "," & Num(Me.txtTotal.Text.Trim) & "," & Num("0") & "," & Num(dblReselComissao) & ",'" & Date.Today & "','" & "C" & "'," & CodConfig & ",'False','" & strAuxiliar & "')"
        '        'Atualizar(strCmdInsert)
        '        Me.strCmdsSQL &= strCmdInsert & vbCrLf & vbCrLf

        '    End If

        'End If


        If intCodMecanico > 0 And intCodMecanico <> Nothing Then
            Dim dblTotProd As Double
            dblTotProd = Me.txtTotal.Text.Trim
            If dblCreditoVenda <> Nothing And dblCreditoVenda <> 0 Then
                dblTotProd = dblTotProd - dblCreditoVenda
            End If

            If dblTotProd > 0 Then
                Dim vetFunc As Array = Split(RetornaFunc(intCodMecanico), "|")

                Dim dblResul As Double

                Dim intComPec As Double

                intComPec = vetFunc(1)

                Dim strCmdInsert As String = ""

                Dim A As Integer
                Dim dblValPresente As Double = 0
                For A = 0 To Me.tbPagamento.Rows.Count - 1
                    Dim strPagPresente As String = Me.tbPagamento.Rows.Item(A).Item("Pagamento").ToString
                    If strPagPresente = "VALE PRESENTE" Then
                        dblValPresente += Me.tbPagamento.Rows.Item(A).Item("Valor").ToString
                    End If
                Next


                Dim dblReselComissao As Double = dblTotProd - dblValPresente
                dblResul = (dblReselComissao / 100) * intComPec
                strCmdInsert = "If not exists(Select CodOrdem from Total where CodOrdem = 999999999 and CodConfig =" & CodConfig & ") Insert into Comissao(CodOrdem, CodFunc, ValorProduto, Porcentagem, ValorComissao, Data, Tipo, CodConfig, Pago, Auxiliar) Values(" & intOrdem & "," & intCodMecanico & "," & Num(dblReselComissao) & "," & Num(intComPec) & "," & Num(dblResul) & ",'" & Date.Today & "','" & "C" & "'," & CodConfig & ",'False','" & strAuxiliar & "')"
                'Atualizar(strCmdInsert)
                Me.strCmdsSQL &= strCmdInsert & vbCrLf & vbCrLf
            End If
        End If



        ''''''''''''''''''''''''''

        Dim bolBoleto As Boolean = False

        For I = 0 To Me.tbPagamento.Rows.Count - 1

            Dim strPag, strValor As String

            strPag = tbPagamento.Rows.Item(I).Item("Pagamento").ToString
            If strPag.Contains("BOLETO") = True Then
                bolBoleto = True
            End If
            strValor = tbPagamento.Rows.Item(I).Item("Valor").ToString
            Dim dt2 As DataTable = CarregarDataTable("Select IrCaixa from Pagamento where Descricao ='" & strPag & "'")

            Dim strBandeira As String = tbPagamento.Rows.Item(I).Item("Bandeira").ToString
            If dt2.Rows.Count > 0 Then
                If dt2.Rows.Item(0).Item("IrCaixa").ToString = "SIM" Then
                    'Inserir("Insert into Caixa (Motivo, Credito, Pagamento, Valor, Data, Caixa, CodConfig) Values('" & "Venda Nº " & intOrdem & ", " & Me.txtCli.Text.Trim & "','" & "C" & "','" & strPag & "'," & Num(strValor) & ",'" & Date.Today & "','" & Me.lblOper.Caption.Trim & "'," & CodConfig & ")")
                    Me.strCmdsSQL &= "If not exists(Select CodOrdem from Total where CodOrdem = 999999999 and CodConfig =" & CodConfig & ") Insert into Caixa (Motivo, Credito, Pagamento, Valor, Data, Caixa, CodConfig, Auxiliar, Bandeira) Values('" & "Venda Nº " & intOrdem & ", " & Me.txtCli.Text.Trim & "','" & "C" & "','" & strPag & "'," & Num(strValor) & ",'" & My.Computer.Clock.LocalTime & "','" & Me.lblOper.Caption.Trim & "'," & CodConfig & ",'" & strAuxiliar & I & "','" & strBandeira & "')" & vbCrLf & vbCrLf

                End If
            End If

        Next
        If Me.tbPagamento.Rows.Count > 0 Then
            If Me.txtTroco.Text.Trim <> "" Then
                If CDbl(Me.txtTroco.Text.Trim) > 0 Then
                    Dim strMotCaixa As String = "Troco Venda Nº " & intOrdem & "','" & "D" & "','" & "DINHEIRO"
                    'Inserir("Insert into Caixa (Motivo, Credito, Pagamento, Valor, Data, Caixa, CodConfig) Values('" & "Troco Venda Nº " & intOrdem & "','" & "D" & "','" & "DINHEIRO" & "'," & Num(Me.txtTroco.Text.Trim) & ",'" & Date.Today & "','" & Me.lblOper.Caption.Trim & "'," & CodConfig & ")")
                    Me.strCmdsSQL &= "If not exists(Select CodOrdem from Total where CodOrdem = 999999999 and CodConfig =" & CodConfig & ") Insert into Caixa (Motivo, Credito, Pagamento, Valor, Data, Caixa, CodConfig, Auxiliar) Values('" & strMotCaixa & "'," & Num(Me.txtTroco.Text.Trim) & ",'" & My.Computer.Clock.LocalTime & "','" & Me.lblOper.Caption.Trim & "'," & CodConfig & ",'" & strAuxiliar & "')" & vbCrLf & vbCrLf
                End If
            End If
        End If


        'Atualizar("Update Cliente set Credito ='" & Me.txtCredito.Text.Trim & "', Limite ='" & Me.txtLimite.Text.Trim & "' where Codigo =" & intCodCliente)
        Me.strCmdsSQL &= "Update Cliente set Credito ='" & Me.txtCredito.Text.Trim & "', Limite ='" & Me.txtLimite.Text.Trim & "' where Codigo =" & intCodCliente & vbCrLf & vbCrLf

        Try
            If intCodPedido <> 0 Then
                'Atualizar("Update TotalConsig set Status ='Faturado' where CodOrdens =" & intCodPedido & " and CodConfig =" & CodConfig)
                Me.strCmdsSQL &= "Update TotalConsig set Status ='Faturado', DataVenda = '" & Date.Today & "' where CodOrdens =" & intCodPedido & " and CodConfig =" & CodConfig & vbCrLf

                Me.strCmdsSQL &= "Update Recebimento set CodOrdem =" & intOrdem & " where CodigoPedido ='" & intCodPedido & "' and CodConfig =" & CodConfig & vbCrLf
                Me.strCmdsSQL &= "Update Futuro set CodOrdem =" & intOrdem & " where CodigoPedido ='" & intCodPedido & "' and CodConfig =" & CodConfig & vbCrLf
                Me.strCmdsSQL &= "Update ContaReceber set CodOrdem =" & intOrdem & " where CodigoPedido ='" & intCodPedido & "' and CodConfig =" & CodConfig & vbCrLf
                Me.strCmdsSQL &= "Update Cheque set CodPed ='" & intOrdem & "' where CodigoPedido ='" & intCodPedido & "' and CodConfig =" & CodConfig & vbCrLf

            End If

            'If intCodComanda <> 0 Then
            '    'Atualizar("Update Comanda set Status ='Faturado' where CodComanda ='" & intCodPedido & "' and CodConfig =" & CodConfig)
            '    Me.strCmdsSQL &= "Update Comanda set Status ='Faturado' where CodComanda ='" & intCodComanda & "' and CodConfig =" & CodConfig & vbCrLf
            'End If

            If strCodComanda <> "0" And strCodComanda <> "" Then
                'Atualizar("Update Comanda set Status ='Faturado' where CodComanda ='" & intCodPedido & "' and CodConfig =" & CodConfig)
                Dim vetComanda As Array = Split(strCodComanda, ",")
                Dim A As Integer

                For A = 0 To vetComanda.Length - 1
                    Dim strCodCom As String = vetComanda(A).ToString.Trim
                    Me.strCmdsSQL &= "Update Comanda set Status ='Faturado' where CodComanda ='" & strCodCom & "' and CodConfig =" & CodConfig & vbCrLf

                Next


            End If
        Catch ex As Exception

        End Try

        SalvaCrediario1()
        SalvaCrediario2()
        SalvaCrediario3()


        Me.strCmdsSQL &= strCmdsPagamento.Replace("AUXILIARPAGAMENTO", strAuxiliar)


        '#################################################################
        'A TABELA TOTAL SEMPRE DEVERÁ SER A ULTIMA A SER INSERIDA
        '#################################################################
        If intCodPedido = 0 Then
            strOperador = UserNano
        End If

        Me.strCmdsSQL &= "If not exists(Select CodOrdem from Total where CodOrdem = 999999999 and CodConfig =" & CodConfig & ") Insert Into Total (CodOrdem, Data, CodCli, Total, Recebido, Troco, Custo, PorDesc, ValDesc, " & _
        "PorAcre, ValAcre, CodConfig, Hora, NFP, CPFCliente, CodPedido, Auxiliar, CodOrdensTEF, Placa, Modelo, KM, TotalFrete, Operador) Values(" & intOrdem & ",'" & Date.Today & "'," & intCodCliente & ", " & _
        "" & Num(Me.txtTotal.Text.Trim) & "," & Num(Me.txtRec.Text.Trim) & "," & Num(Me.txtTroco.Text.Trim) & ", " & _
        "" & Num(dblTotalDeCusto) & "," & Num(strPorDesc) & "," & Num(strValDes) & ", " & _
        "" & Num(strPorAcre) & "," & Num(strValAcre) & "," & CodConfig & ",'" & strHora & "'," & _
        "'" & bolNFP & "','" & Me.txtCPF.Text.Trim & "'," & intCodPedido & ",'" & strAuxiliar & "','" & intCodTEF & "','" & strPlaca & "','" & strModelo & "','" & strKM & "'," & Num(Me.txtValorFrete.Text) & ",'" & strOperador & "')" & vbCrLf & vbCrLf


        Dim intCodVenda As Integer

        'Dim dtConVen As DataTable
        'intCodVenda = GerarCodigo("Ordem", "Codigo", CodConfig)
        'dtConVen = CarregarDataTable("Selec Cod from Ordem where Cod = " & intCodVenda & " and CodConfig = " & CodConfig)
        'If dtConVen.Rows.Count = 0 Then
        '    Inserir("Insert into Ordem (Codigo, CodConfig) Values(" & intCodVenda & "," & CodConfig & ")")
        'Else
        '    intCodVenda = GerarCodigo("Ordem", "Codigo", CodConfig)
        'End If
        'Inserir("Insert into Ordem (Codigo, CodConfig) Values(" & intCodVenda & "," & CodConfig & ")")

        If NomeEmpresa.Trim.ToUpper.Contains("O REI DOS") = True Or NomeEmpresa.Trim.ToUpper.Contains("TEM DESCONTO") = True Then
            Inserir("insert into OrdemVenda (Codigo, CodConfig, Auxiliar) SELECT Max(Codigo) + 1, CodConfig, '" & strAuxiliar & "' as Auxiliar FROM OrdemVenda where Codconfig = " & CodConfig & " group by CodConfig")
        Else
            Inserir("insert into Ordem (Codigo, CodConfig, Auxiliar) SELECT Max(Codigo) + 1, CodConfig, '" & strAuxiliar & "' as Auxiliar FROM Ordem where Codconfig = " & CodConfig & " group by CodConfig")
        End If

        Dim dtOrdem As DataTable

        If NomeEmpresa.Trim.ToUpper.Contains("O REI DOS") = True Or NomeEmpresa.Trim.ToUpper.Contains("TEM DESCONTO") = True Then
            dtOrdem = CarregarDataTable("SELECT Codigo FROM OrdemVenda where Auxiliar = '" & strAuxiliar & "' and CodConfig = " & CodConfig)
        Else
            dtOrdem = CarregarDataTable("SELECT Codigo FROM Ordem where Auxiliar = '" & strAuxiliar & "' and CodConfig = " & CodConfig)
        End If


        If dtOrdem.Rows.Count > 0 Then
            intCodVenda = dtOrdem.Rows.Item(0).Item("Codigo")
        Else
            intOrdem = 999999999
            strCmdsSQL = ""
            Me.strCmdsPagamento = ""
            intContPagamento = 0
            'MsgBox("Erro ao concluir a venda, conclua novamente!", MsgBoxStyle.Information)
            Finalizar()
            Exit Sub

        End If

        intOrdem = intCodVenda

        Me.strCmdsSQL = Me.strCmdsSQL.Replace("999999999", intCodVenda)

        Dim bolImp As Boolean = True

        If Inserir(Me.strCmdsSQL) = True Then

            VendaFinalizada = True

            If SATFiscal = True Then

                If ModeloSAT = "BEMATECH" Then
                    If ImpDiretoSAT = True Then
                        If ImprimirCupomSAT(intCodVenda) = False Then
                            ExcluirVendaPedido(intCodVenda, "VENDA EXCLUÍDA POR MOTIVO DE ERRO NA HORA DE GERAR O SAT-CF-e!", "VENDA", False, True)
                            CancelarPagamento(True)
                            Calcular()
                            EntradaPedido()
                            intOrdem = 999999999
                            Excluir("Delete from Ordem where Codigo =" & intCodVenda & " and CodConfig =" & CodConfig)
                            VendaFinalizada = False
                            strCmdsSQL = ""
                            Me.strCmdsPagamento = ""
                            intContPagamento = 0
                            Exit Sub
                        End If
                        bolImp = False
                    End If
                ElseIf ModeloSAT = "BEMATECHDLL" Then
                    If ImpDiretoSAT = True Then
                        If ImprimirCupomSatDll(intCodVenda) = False Then
                            If bolSoServico = False Then
                                ExcluirVendaPedido(intCodVenda, "VENDA EXCLUÍDA POR MOTIVO DE ERRO NA HORA DE GERAR O SAT-CF-e!", "VENDA", False, True)
                                CancelarPagamento(True)
                                Calcular()
                                intOrdem = 999999999
                                Excluir("Delete from Ordem where Codigo =" & intCodVenda & " and CodConfig =" & CodConfig)
                                VendaFinalizada = False
                                EntradaPedido()
                                strCmdsSQL = ""
                                Me.strCmdsPagamento = ""
                                intContPagamento = 0
                                Exit Sub
                            End If
                        End If
                        bolImp = False
                    End If
                Else
                    If ImpDiretoSAT = True Then
                        If ImprimirCupomSatDll(intCodVenda) = False Then
                            If bolSoServico = False Then
                                ExcluirVendaPedido(intCodVenda, "VENDA EXCLUÍDA POR MOTIVO DE ERRO NA HORA DE GERAR O SAT-CF-e!", "VENDA", False, True)
                                CancelarPagamento(True)
                                Calcular()
                                intOrdem = 999999999
                                Excluir("Delete from Ordem where Codigo =" & intCodVenda & " and CodConfig =" & CodConfig)
                                VendaFinalizada = False
                                EntradaPedido()
                                strCmdsSQL = ""
                                Me.strCmdsPagamento = ""
                                intContPagamento = 0
                                Exit Sub
                            End If
                      
                        End If
                        bolImp = False
                    End If
                End If


            Else

                If NANONFCe = True Then
                    If ImpDiretoNFCe = True Then

                        Dim intCod As Integer = 0
                        If clsNFCe.ImprimirCupomNFCe(intCodVenda, intCod) = False Then
                            If bolSoServico = False Then
                                If intCod > 0 Then
                                    Excluir("DELETE FROM Ordens where Cod = " & intCod & " and Tabela = 'NFCe' and CodConfig = " & CodConfig & " and CodEmitente = " & CodEmitente & " and StatusEmitente = '" & StatusEmitente & "'")

                                End If
                                Excluir("DELETE FROM NFCe where CodOrdem = " & intCodVenda)
                                ExcluirVendaPedido(intCodVenda, "VENDA EXCLUÍDA POR MOTIVO DE ERRO NA HORA DE GERAR O SAT-CF-e!", "VENDA", False, True)
                                CancelarPagamento(True)
                                Calcular()
                                intOrdem = 999999999
                                Excluir("Delete from Ordem where Codigo =" & intCodVenda & " and CodConfig =" & CodConfig)

                                EntradaPedido()
                                strCmdsSQL = ""
                                Me.strCmdsPagamento = ""
                                intContPagamento = 0
                                Exit Sub
                            End If
                        Else

                            frmProcesNfe.strStatus = strStatus
                            frmProcesNfe.strChaveAcesso = ChaveAcesso
                            frmProcesNfe.Tag = "NFe"
                            frmProcesNfe.strUF = EstadoEmitente
                            frmProcesNfe.strTipoAmb = TipoAmbiente
                            frmProcesNfe.strCaminhoNfe = CaminhoNFCe
                            frmProcesNfe.strDataEmissao = DataEmissao
                            frmProcesNfe.ShowDialog()

                            If strArquivoProcessado = "OK" Then
                                Atualizar("UPDATE NFCe set Status = 'OK' where CodOrdem = " & intCodVenda)
                                strStatus = ""
                            ElseIf strArquivoProcessado = "NOK" Then
                                If intCod > 0 Then
                                    Excluir("DELETE FROM Ordens where Cod = " & intCod & " and Tabela = 'NFce' and CodConfig = " & CodConfig & " and CodEmitente = " & CodEmitente & " and StatusEmitente = '" & StatusEmitente & "'")

                                End If
                                ExcluirVendaPedido(intCodVenda, "VENDA EXCLUÍDA POR MOTIVO DE ERRO NA HORA DE GERAR O SAT-CF-e!", "VENDA", False, True)
                                CancelarPagamento(True)
                                Calcular()
                                intOrdem = 999999999
                                Excluir("Delete from Ordem where Codigo =" & intCodVenda & " and CodConfig =" & CodConfig)

                                EntradaPedido()
                                strCmdsSQL = ""
                                Me.strCmdsPagamento = ""
                                intContPagamento = 0
                                Exit Sub
                                strStatus = ""

                            ElseIf strArquivoProcessado = "AGUARDANDO" Then
                                Atualizar("UPDATE NFCe set Status = 'AGUARDANDO' where CodOrdem = " & intCodVenda)
                                strStatus = "AGUARDANDO"
                            End If
                        End If
                        bolImp = False
                    End If
                End If
            End If

            FinalizarTEF(1)

            MsgBox("Venda Finalizada com sucesso!", MsgBoxStyle.Information)
            strCmdsSQL = ""
            Me.strCmdsPagamento = ""
            intContPagamento = 0
        Else
            MsgBox("Erro ao inserir os dados, nenhuma informação dessa venda foi salva!")
            strCmdsSQL = ""
            Me.strCmdsPagamento = ""
            intContPagamento = 0
            ExcluirVendaPedido(intOrdem, "VENDA EXCLUÍDA POR MOTIVO DE ERRO NA HORA DE SALVAR OS DADOS!", "VENDA", False, False)
            CancelarPagamento(True)
            intOrdem = 999999999
            Exit Sub
        End If

        If bolImp = True Then
            If ImprimirDireto = False Then
                If TemImpressora = True Then

                    If MsgBox("Deseja imprimir o cupom?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                        Imprimir(intOrdem, True)
                        If SegViaRecibo = True Then
                            If MsgBox("Deseja imprimir a 2ª via?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                Imprimir(intOrdem, True)
                            End If
                        End If
                    End If
                End If
            Else
                If TemImpressora = True Then

                    Imprimir(intOrdem, True)
                    If SegViaRecibo = True Then
                        If MsgBox("Deseja imprimir a 2ª via?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            Imprimir(intOrdem, True)
                        End If
                    End If
                End If
            End If
        End If

        If bolImp = True Then
            ImprimeDevolucao(intOrdem)
        End If


        If ModeloCarne <> "0" Then
            If bolCredOK = True Then
                If Impressora.Contains("ESC/POS") = False Then
                    Dim Y As Integer

                    For Y = 0 To intContCrediario - 1
                        Select Case Y
                            Case 0
                                ImprimeCrediario1()
                            Case 1
                                ImprimeCrediario2()
                            Case 2
                                ImprimeCrediario3()

                        End Select
                    Next
                End If

            End If
        End If

        If UsaBoleto = True Then
            If bolBoleto = True Then
                Dim dtRec As DataTable = CarregarDataTable("SELECT Codigo, CodCli, Parcelas, " & _
                "ValorParcela, Vencimento FROM ContaReceber where Pagamento like '%BOLETO%' and CodOrdem = " & intOrdem & " and CodConfig = " & CodConfig)
                If dtRec.Rows.Count > 0 Then

                    If MsgBox("Deseja imprimir o boleto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Dim strCodCli As String = dtRec.Rows.Item(0).Item("CodCli").ToString
                        Dim strParcelas As String = dtRec.Rows.Item(0).Item("Parcelas").ToString
                        Dim dblValorTotal As Double

                        If CobreBemNano = False Then
                            Dim strCodigos As String = ""
                            For I = 0 To dtRec.Rows.Count - 1
                                Dim dblValor As Double = dtRec.Rows.Item(I).Item("ValorParcela").ToString
                                dblValorTotal += dblValor

                                If I = 0 Then
                                    strCodigos = dtRec.Rows.Item(I).Item("Codigo").ToString
                                Else
                                    strCodigos &= "," & dtRec.Rows.Item(I).Item("Codigo").ToString
                                End If
                            Next
                            '4244|CLIENTE|406|2|100,00
                            Dim fluxoTexto As IO.StreamWriter
                            If Not System.IO.File.Exists(CaminhoPastaBoleto & "\Boleto\" & intOrdem & ".txt") Then
                                System.IO.File.Create(CaminhoPastaBoleto & "\Boleto\" & intOrdem & ".txt").Dispose()

                                fluxoTexto = New IO.StreamWriter(CaminhoPastaBoleto & "\Boleto\" & intOrdem & ".txt")

                                fluxoTexto.Write("")
                                fluxoTexto.Write(strCodigos & "|CLIENTE|" & strCodCli & "|" & strParcelas & "|" & dblValorTotal & "|VENDA|DETALHADO")
                                fluxoTexto.Close()
                            End If
                            Dim strLogin As String = LerArquivo(CaminhoPastaBoleto & "\Arquivos\Login.txt", True)

                            fluxoTexto = New IO.StreamWriter(CaminhoPastaBoleto & "\Arquivos\Login.txt")

                            fluxoTexto.Write("")
                            fluxoTexto.Write(Login & "|" & Senha & "|000")
                            fluxoTexto.Close()
                            System.Diagnostics.Process.Start(CaminhoPastaBoleto & "\Debug\NanoBoleto.exe")
                        Else
                            Dim strCodigoContaReceber As String = ""
                            For I = 0 To dtRec.Rows.Count - 1
                                'Dim dblValor As Double = dtRec.Rows.Item(I).Item("ValorParcela").ToString
                                'Dim strVencimento As Date = dtRec.Rows.Item(I).Item("Vencimento").ToString
                                Dim strCodigoConta As String = dtRec.Rows.Item(I).Item("Codigo").ToString

                                'Inserir("INSERT INTO Boleto (CodOrdem, CodBanco, CodCli, PerMulta, " & _
                                '"PrimeiraInstrucao, SegundaInstrucao, ValorMora, Vencimento, Valor, DataEmissao, DiasProtesto, " & _
                                '"NumeroDocumento, Status, DiasMora, CodConfig, CodigoConta, Instrucao, Instrucao2) VALUES (" & _
                                '"" & intOrdem & "," & CodBanco & "," & strCodCli & ",'" & PerMultaBanco & "'," & _
                                '"'" & PrimeiraInstrucaoBanco & "','" & SegundaInstrucaoBanco & "','" & MoraBanco & "'," & _
                                '"'" & strVencimento & "'," & Num(dblValor) & ",'" & Date.Today & "'," & _
                                '"'" & DiasProtestoBanco & "','" & strCodigoConta & "','Pendente','" & DiasMoraBanco & "'," & _
                                '"" & CodConfig & ",'" & strCodigoConta & "','" & DemonstrativoBanco & "','" & InstrucaoBanco & "')")
                                If I = 0 Then
                                    strCodigoContaReceber = strCodigoConta
                                Else
                                    strCodigoContaReceber &= "," & strCodigoConta
                                End If

                            Next

                            BoletoCobreBem.CobreBem(strCodigoContaReceber, False)
                        End If
                    End If
                End If

            End If
        End If

        Limpar()
        Dim strCodOrdemDav As String = intOrdem


        intOrdem = 999999999

        AtualizarComanda = True

        Me.txtValDesc.Enabled = True
        Me.txtPorDesc.Enabled = True
        Me.rdgDesc.Enabled = True
        dblCreditoVenda = Nothing

        If PafEcfNano = True Then
            Dim intDav As Integer = GerarCodigoDav("Total", CodConfig)
            Atualizar("UPDATE Total set NumDav = '" & intDav & "', StatusDAV = 'Pendente' where CodOrdem = " & strCodOrdemDav)
        End If

        'End If
        'End If

        If VendaComComanda = True Then
            VendaComComanda = False
            Try
                If FormAberto = "frmComandaItens" Or FormAberto = "frmComandaItensCONSULTAR" Then
                    frmComandaItens.Close()
                    frmComandaPrincipal.MdiParent = MDIComanda
                    frmComandaPrincipal.Show()
                    frmComandaPrincipal.Dock = DockStyle.Fill
                ElseIf FormAberto = "frmComandaPrincipal" Then
                    frmComandaPrincipal.Close()
                    frmComandaPrincipal.MdiParent = MDIComanda
                    frmComandaPrincipal.Show()
                    frmComandaPrincipal.Dock = DockStyle.Fill
                End If
            Catch ex As Exception

            End Try
            Me.Close()
            Exit Sub
        End If

        If NomeEmpresa.Contains("CASTELO KIDS") = False Then
            InserirVendedor()
        End If

        If NomeEmpresa = "SABOR DA FRUTA" Then
            frmPedido1.ShowDialog()
            Calcular()
        End If

        VendaFinalizada = False
    End Sub

    Private Sub ImprimeDevolucao(ByVal parCodOrdem As Integer)
        Dim strImpressao As String = ""

        
        If TemImpressora = False Then Exit Sub

        Dim dtCliente As DataTable = CarregarDataTable("Select Cliente.Codigo, Cliente.Credito From Total Left Join Cliente On Total.CodCli = Cliente.Codigo Where Total.CodOrdem=" & parCodOrdem)

        Dim dblCredito As Double = 0
        Dim strCredito As String = ""

        If dtCliente.Rows.Count > 0 Then
            If dtCliente.Rows.Item(0).Item("Credito").ToString <> "" Then
                dblCredito = dtCliente.Rows.Item(0).Item("Credito").ToString
            End If

        End If
        strCredito = dblCredito.ToString("0.00")

        If dblCredito = 0 Then Exit Sub

        If dblCredito > 0 Then
            If MsgBox("Cliente possui crédito restante. Deseja imprimir o comprovante?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                If Impressora.Contains("BEMATECH MP-4000") Or Impressora.Contains("ARQUIVO") Or Impressora.Contains("NANO PRINT") Then
                    iRetorno = clsBematech.IniciaPorta(PortaImpressora)

                    strImpressao &= Cent(NomeEmpresa.ToString.Trim, 42) & vbCrLf
                    strImpressao &= Cent(EnderecoEmpresa.Trim, 42) & vbCrLf
                    strImpressao &= Cent(TelefoneEmpresa.Trim, 42) & vbCrLf

                    strImpressao &= "******************************************" & vbCrLf
                    strImpressao &= Esq(Date.Today, 42) & vbCrLf


                    strImpressao &= " VENDA N:" & vbCrLf
                    strImpressao &= "------------------------------------------" & vbCrLf
                    strImpressao &= " " & parCodOrdem & vbCrLf


                    strImpressao &= "------------------------------------------" & vbCrLf
                    strImpressao &= " Crédito R$ " & Esq(strCredito.Trim, 9) & vbCrLf
                    strImpressao &= " " & vbCrLf

                    strImpressao &= "------------------------------------------" & vbCrLf


                    Dim dt As DataTable
                    dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade From Total Left Join Cliente On Total.CodCli = Cliente.Codigo Where Total.CodOrdem=" & parCodOrdem)

                    If dt.Rows.Count > 0 Then
                        If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                            strImpressao &= " " & dt.Rows.Item(0).Item("Nome").ToString & vbCrLf
                        End If

                        If dt.Rows.Item(0).Item("Endereco").ToString <> "" Then
                            strImpressao &= " " & dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & " " & dt.Rows.Item(0).Item("Complemento").ToString & vbCrLf
                        End If

                        'If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                        '    strImpressao &= " " & dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & vbCrLf
                        'End If

                        'If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                        '    strImpressao &= " " & dt.Rows.Item(0).Item("Telefone").ToString & vbCrLf
                        'End If
                    End If

                    strImpressao &= " " & vbCrLf
                    strImpressao &= Cent("NÃO PERDER ESSE COMPROVANTE!", 42) & vbCrLf
                    'strImpressao &= Cent("É NECESSÁRIO A APRESENTAÇÃO DESTE NA TROCA.", 42) & vbCrLf
                    strImpressao &= " " & vbCrLf

                    strImpressao &= "------------------------------------------" & vbCrLf
                    strImpressao &= Cent("DOCUMENTO NÃO FISCAL", 42) & vbCrLf
                    strImpressao &= " " & vbCrLf

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
                        If Impressora.Contains("MP-4000") Then
                            iRetorno = ConfiguraModeloImpressora(5)
                            iRetorno = SelecionaQualidadeImpressao(3)
                        Else
                            iRetorno = ConfiguraModeloImpressora(1)
                        End If
                        iRetorno = clsBematech.IniciaPorta(PortaImpressora)


                        iRetorno = clsBematech.FormataTX(strImpressao, 1, 0, 0, 0, 1)

                        If TemGuilhotina = True Then
                            iRetorno = clsBematech.AcionaGuilhotina(0)
                        End If
                    End If
                End If


                If Impressora.Contains("ESC/POS") = True Then

                    strImpressao = clsImprimir.Cabecalho()
                    strImpressao &= Esq(Date.Today, 55) & vbCrLf

                    strImpressao &= Dir("VENDA N:", 55) & vbCrLf
                    strImpressao &= strTraco & vbCrLf
                    strImpressao &= Dir(parCodOrdem, 55) & vbCrLf


                    strImpressao &= strTraco & vbCrLf
                    strImpressao &= clsImprimir.DupLin("CREDITO R$ " & strCredito) & vbCrLf
                    strImpressao &= strTraco & vbCrLf


                    Dim dt As DataTable
                    dt = CarregarDataTable("Select Nome, CPF, Numero, Complemento, Bairro, Telefone, Cidade From Total Left Join Cliente On Total.CodCli = Cliente.Codigo Where Total.CodOrdem=" & parCodOrdem)

                    If dt.Rows.Count > 0 Then
                        If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                            strImpressao &= Dir(dt.Rows.Item(0).Item("Nome").ToString, 55) & vbCrLf
                        End If

                        If dt.Rows.Item(0).Item("CPF").ToString <> "" Then
                            strImpressao &= Dir(dt.Rows.Item(0).Item("CPF").ToString, 55) & vbCrLf
                        End If

                        'If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                        '    strImpressao &= "<c>" & dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & "</c>" & vbCrLf
                        'End If

                        'If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                        '    strImpressao &= "<c>" & dt.Rows.Item(0).Item("Telefone").ToString & "</c>" & vbCrLf
                        'End If
                    End If

                    strImpressao &= vbCrLf

                    strImpressao &= clsImprimir.Centralizar("NÃO PERDER ESSE COMPROVANTE!") & vbCrLf
                    'strImpressao &= clsImprimir.Centralizar("É NECESSÁRIO A APRESENTAÇÃO DESTE NA TROCA.") & vbCrLf
                    strImpressao &= vbCrLf

                    clsImprimir.Rodape(True, strImpressao)
                End If

            End If
        End If
    End Sub

    Private Sub FinalizarTEF(ByVal parConfirma As Integer)
        If TEF = True Then
            If intCodTEF > 0 Then
                Dim dataFiscal As String = Format(Date.Today, "yyyyMMdd")
                Dim horario As String = Format(My.Computer.Clock.LocalTime, "HHmmss")
                clsTEF.FinalizaTransacaoSiTefInterativo(parConfirma, intCodTEF, dataFiscal, horario)

                If parConfirma = 1 Then
                    Try
                        Dim A As Integer
                        For A = 0 To strComprovanteTEF.Length - 1
                            If Impressora.Contains("ESC/POS") = True Then
                                If strComprovanteTEF(A) <> "" Then
                                    clsImprimir.ImprimeCupomTEF(strComprovanteTEF(A))
                                End If

                            End If
                            strComprovanteTEF(A) = ""
                        Next
                    Catch ex As Exception
                        MsgBox("Ocorreu um erro na impressão, tente reimprimir pelo menu!", MsgBoxStyle.Information)
                    End Try
                Else
                    Try
                        Dim A As Integer
                        For A = 0 To strComprovanteTEF.Length - 1
                            strComprovanteTEF(A) = ""
                        Next
                    Catch ex As Exception
                    End Try
                End If
                intCodTEF = 0
                Atualizar("UPDATE Futuro set Status = 'OK' where CodOrdem = " & intOrdem & " and CodConfig = " & CodConfig)
                Atualizar("UPDATE Ordens set StatusEmitente = 'OK' where Cod = " & intCodTEF & " and Tabela = 'TEF' and CodConfig = " & CodConfig & " and Auxiliar = '" & My.Computer.Name.ToUpper & "'")
            End If
        End If
    End Sub
    Private Sub ImprimirContrato(ByVal parCodOrdem As String)
        Dim rel As New relPed2

        rel.lblTitulo.Text = NomeEmpresa
        rel.lblEndereco.Text = EnderecoEmpresa
        rel.lblFones.Text = TelefoneEmpresa

        Dim strCnpj As String = AddPonto(CNPJEmpresa, "J")

        rel.lblRazao.Text = "Razão Social Priscila Arantes Ribeiro ME. CNPJ: " & strCnpj
        rel.lblSite.Text = "www.helenadecor.com.br"


        rel.picLogo.Image = LogoTipo

        Dim I, intQtde, intQtdTotal As Integer
        Dim dblTotal, dblTotalGeral As Double
        For I = 0 To Me.grd1.RowCount - 1
            intQtde = Me.grd1.GetRowCellDisplayText(I, Me.colQtde)
            intQtdTotal += intQtde
            dblTotal = Me.grd1.GetRowCellDisplayText(I, Me.colTotal)
            dblTotalGeral += dblTotal
            With rel.tbPed.Rows
                .Add()
                .Item(I).Item("Produto") = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                .Item(I).Item("Qtd") = Me.grd1.GetRowCellDisplayText(I, Me.colQtde)
                .Item(I).Item("ValorUnitario") = Me.grd1.GetRowCellDisplayText(I, Me.colUnitario)
                .Item(I).Item("ValorTotal") = Me.grd1.GetRowCellDisplayText(I, Me.colTotal)
                .Item(I).Item("Tamanho") = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho)
                .Item(I).Item("Codigo") = Me.grd1.GetRowCellDisplayText(I, Me.colCodProd)
            End With
        Next
        Dim dtCli As DataTable = CarregarDataTable("SELECT CPF, RGIE, Endereco, Bairro, Numero, Cidade, Cep, " & _
        "convert(Varchar(10),Nascimento,103) as Nascimento, Telefone, Celular, Email, Complemento FROM Cliente where Codigo = " & intCodCliente)
        If dtCli.Rows.Count > 0 Then
            rel.lblEnd.Text = dtCli.Rows.Item(0).Item("Endereco").ToString
            rel.lblBairro.Text = dtCli.Rows.Item(0).Item("Bairro").ToString
            rel.lblNum.Text = dtCli.Rows.Item(0).Item("Numero").ToString
            rel.lblCidade.Text = dtCli.Rows.Item(0).Item("Cidade").ToString
            rel.lblCep.Text = dtCli.Rows.Item(0).Item("Cep").ToString
            rel.lblCPF.Text = dtCli.Rows.Item(0).Item("CPF").ToString
            rel.lblRG.Text = dtCli.Rows.Item(0).Item("RGIE").ToString
            rel.lblNascimento.Text = dtCli.Rows.Item(0).Item("Complemento").ToString
            rel.lblNome.Text = Me.txtCli.Text
            rel.lblTel1.Text = dtCli.Rows.Item(0).Item("Telefone").ToString
            rel.lblTel2.Text = dtCli.Rows.Item(0).Item("Celular").ToString
            rel.lblWeb.Text = dtCli.Rows.Item(0).Item("Email").ToString
        End If

        If intCodPedido <> 0 Then
            rel.lblPed.Text = intCodPedido & "/" & parCodOrdem
        Else
            rel.lblPed.Text = "0/" & parCodOrdem
        End If

        rel.lblData.Text = Date.Today

        rel.tblQtd.Text = intQtdTotal
        rel.tblTotal.Text = Me.txtTotal.Text
        rel.tblDesc.Text = Me.txtValDesc.Text
        rel.lblVend.Text = Me.lblVend2.Caption

        rel.lblObservacao.Text = "Formas de Pagamento"

        Dim dtRecebimento As DataTable = CarregarDataTable("SELECT FormaPagamento, Pagamento, Valor FROM Recebimento where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)


        Dim strRecebimento As String = Dir("Pagamento", 20) & Dir("Vencimento", 20) & Dir("Valor", 10) & vbCrLf

        For I = 0 To dtRecebimento.Rows.Count - 1
            Dim strFormaPag As String = dtRecebimento.Rows.Item(I).Item("FormaPagamento").ToString
            Dim strPagamento As String = dtRecebimento.Rows.Item(I).Item("Pagamento").ToString
            Dim strValor As String = dtRecebimento.Rows.Item(I).Item("Valor").ToString

            Dim dtPag As DataTable = CarregarDataTable("SELECT Prazo FROM Pagamento where Descricao = '" & strPagamento & "'")

            If dtPag.Rows.Count > 0 Then
                If dtPag.Rows.Item(0).Item("Prazo").ToString = False Then
                    If strFormaPag = "A PRAZO" Then
                        Dim dtReceber As DataTable = CarregarDataTable("SELECT ValorParcela, convert(VARCHAR(10),Vencimento,103) as Vencimento FROM ContaReceber where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)
                        Dim A As Integer
                        For A = 0 To dtReceber.Rows.Count - 1
                            Dim strValorParcela As String = dtReceber.Rows.Item(A).Item("ValorParcela").ToString
                            Dim strVenc As String = dtReceber.Rows.Item(A).Item("Vencimento").ToString

                            strRecebimento &= Dir(strPagamento, 20) & Dir(strVenc, 20) & Esq(strValorParcela, 10) & vbCrLf

                        Next
                    Else
                        strRecebimento &= Dir(strPagamento, 20) & Dir("", 19) & Esq(strValor, 10) & vbCrLf

                    End If
                Else
                    Dim dtFut As DataTable = CarregarDataTable("Select Total, convert(VARCHAR(10),Data,103) as Data from Futuro Where CodOrdem =" & parCodOrdem & " and CodConfig = " & CodConfig)
                    Dim A As Integer
                    For A = 0 To dtFut.Rows.Count - 1
                        Dim strVal As String = dtFut.Rows.Item(A).Item("Total").ToString
                        Dim strData As String = dtFut.Rows.Item(A).Item("Data").ToString
                        strRecebimento &= Dir(strPagamento, 20) & Dir(strData, 20) & Esq(strVal, 10) & vbCrLf

                    Next
                End If
            End If
        Next

        rel.rtbObs.Text = strRecebimento

        rel.rtbConfigObs.Text = ObsPedido

        'OcultarAutorizacao
        If AutorizacaoPedido = False Then
            rel.lblAutorizacao.Visible = False
            rel.lblAutorizacaoEmpresa.Visible = False
        Else
            rel.lblAutorizacao.Text = Me.txtCli.Text
            rel.lblAutorizacaoEmpresa.Text = NomeEmpresa
        End If
        rel.ShowPreviewDialog()
    End Sub
    Private Sub SalvaCrediario1()
        Dim I As Integer
        Dim strValPar, strVenc, strNumDoc, strPag As String

        With frmCrediario1
            strVenc = ""
            For I = 0 To .tdCred.Rows.Count - 1

                strValPar = .tdCred.Rows.Item(I).Item("Valor").ToString
                strVenc = .tdCred.Rows.Item(I).Item("Vencimento")
                strNumDoc = .tdCred.Rows.Item(I).Item("Documento").ToString
                strPag = .tdCred.Rows.Item(I).Item("Pagamento").ToString

                Dim strBanco As String = ""
                Dim dtPag As DataTable = CarregarDataTable("SELECT Banco.Nome FROM Pagamento left join Banco on Pagamento.CodBanco = Banco.Codigo where Descricao = '" & strPag & "'")
                If dtPag.Rows.Count > 0 Then
                    strBanco = dtPag.Rows.Item(0).Item(0).ToString
                End If

                intContPagamento += 1
                'Inserir("Insert into ContaReceber (CodOrdem, DataVenda, CodCli, FormaPagamento, Parcelas, ValorParcela, Vencimento, ValorVenda, Pagamento, NumeroDocumento, TipoCusto, CodConfig, RecebidoOK) Values(" & intOrdem & ",'" & Date.Today & "'," & intCodCliente & ",'" & "A PRAZO" & "','" & I + 1 & "/" & Me.tdCred.Rows.Count & "'," & Num(strValPar) & ",'" & strVenc & "'," & Num(Me.txtValCred.Text.Trim) & ",'" & strPagamento & "','" & strNumDoc & "','" & "V" & "'," & CodConfig & ",'False')")
                strCmdsPagamento &= "If not exists(Select CodOrdem from Total where CodOrdem = 999999999 and CodConfig =" & CodConfig & ") Insert into ContaReceber (CodOrdem, DataVenda, CodCli, FormaPagamento, Parcelas, ValorParcela, Vencimento, ValorVenda, Pagamento, NumeroDocumento, TipoCusto, CodConfig, RecebidoOK, Banco, CodigoPedido, Auxiliar, ValorRecebido) Values(" & intOrdem & ",'" & Date.Today & "'," & intCodCliente & ",'" & "A PRAZO" & "','" & I + 1 & "/" & .tdCred.Rows.Count & "'," & Num(strValPar) & ",'" & strVenc & "'," & Num(.txtValCred.Text.Trim) & ",'" & strPag & "','" & strNumDoc & "','" & "V" & "'," & CodConfig & ",'False','" & strBanco & "','','" & strAuxiliar & intContPagamento & "','0.00')" & vbCrLf & vbCrLf

                If strPag.Contains("CHEQUE") Then
                    'Inserir("INSERT INTO Cheque (CodPed, Cliente, Vencimento, Valor, Documento, Banco, Data, Quem, RecebidoOk, CodConfig) VALUES ('" & intOrdem & "','" & strCliente & "','" & strVenc & "'," & Num(strValPar) & ",'" & strNumDoc & "','" & "" & "','" & Date.Today & "','" & "" & "','False'," & CodConfig & ")")
                    If ExisteTabela("Cheque") = True Then
                        strCmdsPagamento &= "INSERT INTO Cheque (CodPed, Cliente, Vencimento, Valor, Documento, " & _
                        "Banco, Data, Quem, RecebidoOk, CodConfig, CodigoPedido) VALUES ('" & intOrdem & "','" & Me.txtCli.Text & "','" & strVenc & "'," & Num(strValPar) & ",'" & strNumDoc & "','" & "" & "','" & Date.Today & "','" & "" & "','False'," & CodConfig & ",'')" & vbCrLf & vbCrLf

                    End If
                End If

            Next
        End With
    End Sub

    Private Sub SalvaCrediario2()
        Dim I As Integer
        Dim strValPar, strVenc, strNumDoc, strPag As String

        With frmCrediario2
            strVenc = ""
            For I = 0 To .tdCred.Rows.Count - 1

                strValPar = .tdCred.Rows.Item(I).Item("Valor").ToString
                strVenc = .tdCred.Rows.Item(I).Item("Vencimento")
                strNumDoc = .tdCred.Rows.Item(I).Item("Documento").ToString
                strPag = .tdCred.Rows.Item(I).Item("Pagamento").ToString
                Dim strBanco As String = ""
                Dim dtPag As DataTable = CarregarDataTable("SELECT Banco.Nome FROM Pagamento left join Banco on Pagamento.CodBanco = Banco.Codigo where Descricao = '" & strPag & "'")
                If dtPag.Rows.Count > 0 Then
                    strBanco = dtPag.Rows.Item(0).Item(0).ToString
                End If

                intContPagamento += 1
                'Inserir("Insert into ContaReceber (CodOrdem, DataVenda, CodCli, FormaPagamento, Parcelas, ValorParcela, Vencimento, ValorVenda, Pagamento, NumeroDocumento, TipoCusto, CodConfig, RecebidoOK) Values(" & intOrdem & ",'" & Date.Today & "'," & intCodCliente & ",'" & "A PRAZO" & "','" & I + 1 & "/" & Me.tdCred.Rows.Count & "'," & Num(strValPar) & ",'" & strVenc & "'," & Num(Me.txtValCred.Text.Trim) & ",'" & strPagamento & "','" & strNumDoc & "','" & "V" & "'," & CodConfig & ",'False')")
                strCmdsPagamento &= "If not exists(Select CodOrdem from Total where CodOrdem = 999999999 and CodConfig =" & CodConfig & ") Insert into ContaReceber (CodOrdem, DataVenda, CodCli, FormaPagamento, Parcelas, ValorParcela, Vencimento, ValorVenda, Pagamento, NumeroDocumento, TipoCusto, CodConfig, RecebidoOK, Banco, CodigoPedido, Auxiliar, ValorRecebido) Values(" & intOrdem & ",'" & Date.Today & "'," & intCodCliente & ",'" & "A PRAZO" & "','" & I + 1 & "/" & .tdCred.Rows.Count & "'," & Num(strValPar) & ",'" & strVenc & "'," & Num(.txtValCred.Text.Trim) & ",'" & strPag & "','" & strNumDoc & "','" & "V" & "'," & CodConfig & ",'False','" & strBanco & "','','" & strAuxiliar & intContPagamento & "','0.00')" & vbCrLf & vbCrLf
                If strPag.Contains("CHEQUE") Then
                    'Inserir("INSERT INTO Cheque (CodPed, Cliente, Vencimento, Valor, Documento, Banco, Data, Quem, RecebidoOk, CodConfig) VALUES ('" & intOrdem & "','" & strCliente & "','" & strVenc & "'," & Num(strValPar) & ",'" & strNumDoc & "','" & "" & "','" & Date.Today & "','" & "" & "','False'," & CodConfig & ")")
                    If ExisteTabela("Cheque") = True Then
                        strCmdsPagamento &= "INSERT INTO Cheque (CodPed, Cliente, Vencimento, Valor, Documento, " & _
                        "Banco, Data, Quem, RecebidoOk, CodConfig, CodigoPedido) VALUES ('" & intOrdem & "','" & Me.txtCli.Text & "','" & strVenc & "'," & Num(strValPar) & ",'" & strNumDoc & "','" & "" & "','" & Date.Today & "','" & "" & "','False'," & CodConfig & ",'')" & vbCrLf & vbCrLf

                    End If
                End If
            Next
        End With
    End Sub

    Private Sub SalvaCrediario3()
        Dim I As Integer
        Dim strValPar, strVenc, strNumDoc, strPag As String

        With frmCrediario3
            strVenc = ""
            For I = 0 To .tdCred.Rows.Count - 1

                strValPar = .tdCred.Rows.Item(I).Item("Valor").ToString
                strVenc = .tdCred.Rows.Item(I).Item("Vencimento")
                strNumDoc = .tdCred.Rows.Item(I).Item("Documento").ToString
                strPag = .tdCred.Rows.Item(I).Item("Pagamento").ToString
                Dim strBanco As String = ""
                Dim dtPag As DataTable = CarregarDataTable("SELECT Banco.Nome FROM Pagamento left join Banco on Pagamento.CodBanco = Banco.Codigo where Descricao = '" & strPag & "'")
                If dtPag.Rows.Count > 0 Then
                    strBanco = dtPag.Rows.Item(0).Item(0).ToString
                End If

                intContPagamento += 1
                'Inserir("Insert into ContaReceber (CodOrdem, DataVenda, CodCli, FormaPagamento, Parcelas, ValorParcela, Vencimento, ValorVenda, Pagamento, NumeroDocumento, TipoCusto, CodConfig, RecebidoOK) Values(" & intOrdem & ",'" & Date.Today & "'," & intCodCliente & ",'" & "A PRAZO" & "','" & I + 1 & "/" & Me.tdCred.Rows.Count & "'," & Num(strValPar) & ",'" & strVenc & "'," & Num(Me.txtValCred.Text.Trim) & ",'" & strPagamento & "','" & strNumDoc & "','" & "V" & "'," & CodConfig & ",'False')")
                strCmdsPagamento &= "If not exists(Select CodOrdem from Total where CodOrdem = 999999999 and CodConfig =" & CodConfig & ") Insert into ContaReceber (CodOrdem, DataVenda, CodCli, FormaPagamento, Parcelas, ValorParcela, Vencimento, ValorVenda, Pagamento, NumeroDocumento, TipoCusto, CodConfig, RecebidoOK, Banco, CodigoPedido, Auxiliar, ValorRecebido) Values(" & intOrdem & ",'" & Date.Today & "'," & intCodCliente & ",'" & "A PRAZO" & "','" & I + 1 & "/" & .tdCred.Rows.Count & "'," & Num(strValPar) & ",'" & strVenc & "'," & Num(.txtValCred.Text.Trim) & ",'" & strPag & "','" & strNumDoc & "','" & "V" & "'," & CodConfig & ",'False','" & strBanco & "','','" & strAuxiliar & intContPagamento & "','0.00')" & vbCrLf & vbCrLf
                If strPag.Contains("CHEQUE") Then
                    'Inserir("INSERT INTO Cheque (CodPed, Cliente, Vencimento, Valor, Documento, Banco, Data, Quem, RecebidoOk, CodConfig) VALUES ('" & intOrdem & "','" & strCliente & "','" & strVenc & "'," & Num(strValPar) & ",'" & strNumDoc & "','" & "" & "','" & Date.Today & "','" & "" & "','False'," & CodConfig & ")")
                    If ExisteTabela("Cheque") = True Then
                        strCmdsPagamento &= "INSERT INTO Cheque (CodPed, Cliente, Vencimento, Valor, Documento, " & _
                        "Banco, Data, Quem, RecebidoOk, CodConfig, CodigoPedido) VALUES ('" & intOrdem & "','" & Me.txtCli.Text & "','" & strVenc & "'," & Num(strValPar) & ",'" & strNumDoc & "','" & "" & "','" & Date.Today & "','" & "" & "','False'," & CodConfig & ",'')" & vbCrLf & vbCrLf

                    End If

                End If

            Next
        End With
    End Sub

    Private Sub ImprimeCrediario1()

        With frmCrediario1
            Dim strVenc As String = ""
            If MsgBox("Deseja imprimir o carnê?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Dim I As Integer
                If ModeloCarne.Trim = "1" Or ModeloCarne.Trim = "" Then

                    Dim rel As New relCred
                    rel.picLogo.Image = LogoTipo
                    For I = 0 To .grd1.RowCount - 1
                        rel.tbCred.Rows.Add()
                        rel.tbCred.Rows.Item(I).Item("Vencimento") = .grd1.GetRowCellDisplayText(I, .colVencimento)
                        strVenc = .grd1.GetRowCellDisplayText(I, .colVencimento)
                        rel.tbCred.Rows.Item(I).Item("Valor") = .grd1.GetRowCellDisplayText(I, .colValor)
                        rel.tbCred.Rows.Item(I).Item("CodVenda") = intOrdem
                        rel.tbCred.Rows.Item(I).Item("Prest") = .grd1.GetRowCellDisplayText(I, .colParcela) & "/" & .grd1.RowCount

                        rel.tbCred.Rows.Item(I).Item("Cliente") = Me.txtCli.Text.Trim

                        rel.tbCred.Rows.Item(I).Item("Empresa") = NomeEmpresa
                        rel.tbCred.Rows.Item(I).Item("Endereco") = EnderecoEmpresa
                        rel.tbCred.Rows.Item(I).Item("Telefone") = TelefoneEmpresa
                        rel.tbCred.Rows.Item(I).Item("Data") = Format(Date.Today, "dd/MM/yyyy")
                    Next

                    rel.ShowPreviewDialog()


                ElseIf ModeloCarne.Trim = "2" Then
                  
                    If Impressora = "DARUMA" Then
                        If TemImpressora = False Then Exit Sub

                        Dim strImpressao As String

                        strImpressao = "<tc>#</tc>" & vbCrLf

                        strImpressao &= "<b><ce>" & NomeEmpresa.ToString.Trim & "</ce></b>" & vbCrLf

                        strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf

                        strImpressao &= "<ce>" & TelefoneEmpresa & "</ce>" & vbCrLf
                        strImpressao &= "<tc>#</tc>" & vbCrLf

                        strImpressao &= "<e><ce>CREDIÁRIO" & "</ce></e>" & vbCrLf

                        strImpressao &= "<tc>-</tc>" & vbCrLf

                        Dim dt As DataTable

                        dt = CarregarDataTable("Select Nome, CPF, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & intCodCliente)

                        If dt.Rows.Count > 0 Then
                            If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                                strImpressao &= "<b><c>" & dt.Rows.Item(0).Item("Nome").ToString & "</c></b>" & vbCrLf
                            End If

                            If dt.Rows.Item(0).Item("CPF").ToString <> "" Then
                                strImpressao &= "<c>" & dt.Rows.Item(0).Item("CPF").ToString & "</c>" & vbCrLf
                            End If

                            'If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                            '    strImpressao &= "<c>" & dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & "</c>" & vbCrLf
                            'End If

                            'If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                            '    strImpressao &= "<c>" & dt.Rows.Item(0).Item("Telefone").ToString & "</c>" & vbCrLf
                            'End If

                        End If

                        strImpressao &= "<tc>-</tc>" & vbCrLf

                        strImpressao &= "<b><e><ce>" & "Venda Nº " & intOrdem & "</ce></e></b>" & vbCrLf

                        For I = 0 To .grd1.RowCount - 1
                            strImpressao &= "<c>Nº Parcela: " & .grd1.GetRowCellDisplayText(I, .colParcela).Trim & "/" & .grd1.RowCount & "</c>" & vbCrLf
                            strImpressao &= "<c>Vencimento: " & .grd1.GetRowCellDisplayText(I, .colVencimento).Trim & "</c>" & vbCrLf
                            strVenc = .grd1.GetRowCellDisplayText(I, .colVencimento)
                            strImpressao &= "<c><b>Valor Parc: R$ " & .grd1.GetRowCellDisplayText(I, .colValor).Trim & "   Data Pagamento:____/____/________</b></c>" & vbCrLf
                            strImpressao &= "<l></l>" & vbCrLf
                            strImpressao &= "<c>Autenticação:_______________________________________</c>" & vbCrLf
                            strImpressao &= "<tc>-</tc>" & vbCrLf

                        Next

                        strImpressao &= "<l></l>" & vbCrLf

                        strImpressao &= "<c><b>Total Crediário: R$ " & .txtValCred.Text.Trim & "</b></c>" & vbCrLf

                        strImpressao &= "<l></l>" & vbCrLf

                        strImpressao &= "<b><ce>A Parcela será considerada paga</ce></b>" & vbCrLf
                        strImpressao &= "<b><ce>quando conter O RECIBO DE PAGAMENTO.</ce></b>" & vbCrLf

                        strImpressao &= "<l></l>" & vbCrLf

                        If NomeEmpresa.Replace("Á", "A").Contains("TAUA") = True Then
                            strImpressao &= "<ce>Pague em dia e aumento seu Limite.</ce>" & vbCrLf
                            strImpressao &= "<ce>O seu nome é seu maior patrimônio!</ce>" & vbCrLf
                        End If
                        strImpressao &= "<tc>-</tc>" & vbCrLf

                        strImpressao &= "<ce>DOCUMENTO NÃO FISCAL" & "</ce>" & vbCrLf

                        strImpressao &= "<l></l>" & vbCrLf
                        strImpressao &= "<l></l>" & vbCrLf
                        strImpressao &= "<l></l>" & vbCrLf

                        If TemGuilhotina = True Then
                            strImpressao &= "<gui></gui>" & vbCrLf
                        End If

                        If ImpressoraOK() = True Then
                            iRetorno = (iImprimirTexto_DUAL_DarumaFramework(strImpressao, 0))
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

                        Dim intTamEsp As Integer
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

                        strImpressao &= Cent("CREDIÁRIO", intTamEsp) & vbCrLf

                        strImpressao &= strTraço & vbCrLf

                        Dim dt As DataTable

                        dt = CarregarDataTable("Select Nome, CPF, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & intCodCliente)

                        If dt.Rows.Count > 0 Then
                            If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                                strImpressao &= dt.Rows.Item(0).Item("Nome").ToString & vbCrLf
                            End If

                            If dt.Rows.Item(0).Item("CPF").ToString <> "" Then
                                strImpressao &= dt.Rows.Item(0).Item("CPF").ToString & vbCrLf
                            End If

                            'If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                            '    strImpressao &= dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & vbCrLf
                            'End If

                            'If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                            '    strImpressao &= dt.Rows.Item(0).Item("Telefone").ToString & vbCrLf
                            'End If

                        End If

                        strImpressao &= strTraço & vbCrLf

                        strImpressao &= Dir("Venda N: " & intOrdem, intTamEsp) & vbCrLf

                        For I = 0 To .grd1.RowCount - 1
                            strImpressao &= "N. Parcela: " & .grd1.GetRowCellDisplayText(I, .colParcela).Trim & "/" & .grd1.RowCount & vbCrLf
                            strImpressao &= "Vencimento: " & .grd1.GetRowCellDisplayText(I, .colVencimento).Trim & vbCrLf
                            strVenc = .grd1.GetRowCellDisplayText(I, .colVencimento)
                            strImpressao &= "Vlr Parc: R$ " & .grd1.GetRowCellDisplayText(I, .colValor).Trim & "  Dt Pag:___/___/______" & vbCrLf
                            strImpressao &= " " & vbCrLf
                            strImpressao &= "Autenticação:______________________________" & vbCrLf
                            strImpressao &= strTraço & vbCrLf

                        Next

                        strImpressao &= " " & vbCrLf

                        strImpressao &= "Total Crediário: R$ " & .txtValCred.Text.Trim & vbCrLf & vbCrLf

                        strImpressao &= Cent("A Parcela será considerada paga", intTamEsp) & vbCrLf
                        strImpressao &= Cent("quando conter o RECIBO DE PAGAMENTO.", intTamEsp) & vbCrLf

                        If NomeEmpresa.Replace("Á", "A").Contains("TAUA") = True Then
                            strImpressao &= vbCrLf
                            strImpressao &= Cent("Pague em dia e aumento seu Limite.", intTamEsp) & vbCrLf
                            strImpressao &= Cent("O seu nome é seu maior patrimônio!", intTamEsp) & vbCrLf
                        End If
                        strImpressao &= strTraço & vbCrLf

                        strImpressao &= Cent("DOCUMENTO NÃO FISCAL", intTamEsp) & vbCrLf

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

                        strImpressao &= "<ce>" & "CREDIÁRIO" & "</ce>" & vbCrLf

                        strImpressao &= strTraço & vbCrLf

                        Dim dt As DataTable

                        dt = CarregarDataTable("Select Nome, CPF, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & intCodCliente)

                        If dt.Rows.Count > 0 Then
                            If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                                strImpressao &= dt.Rows.Item(0).Item("Nome").ToString & vbCrLf
                            End If

                            If dt.Rows.Item(0).Item("CPF").ToString <> "" Then
                                strImpressao &= dt.Rows.Item(0).Item("CPF").ToString & vbCrLf
                            End If

                            'If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                            '    strImpressao &= dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & vbCrLf
                            'End If

                            'If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                            '    strImpressao &= dt.Rows.Item(0).Item("Telefone").ToString & vbCrLf
                            'End If

                        End If

                        strImpressao &= strTraço & vbCrLf

                        strImpressao &= "Venda N: " & intOrdem & vbCrLf

                        For I = 0 To .grd1.RowCount - 1
                            strImpressao &= "N. Parcela: " & .grd1.GetRowCellDisplayText(I, .colParcela).Trim & "/" & .grd1.RowCount & vbCrLf
                            strImpressao &= "Vencimento: " & .grd1.GetRowCellDisplayText(I, .colVencimento).Trim & vbCrLf
                            strVenc = .grd1.GetRowCellDisplayText(I, .colVencimento)
                            strImpressao &= "Vlr Parc: R$ " & .grd1.GetRowCellDisplayText(I, .colValor).Trim & "  Dt Pag:___/___/______" & vbCrLf
                            strImpressao &= " " & vbCrLf
                            strImpressao &= "Autenticação:______________________________" & vbCrLf
                            strImpressao &= strTraço & vbCrLf

                        Next

                        strImpressao &= " " & vbCrLf

                        strImpressao &= "Total Crediário: R$ " & .txtValCred.Text.Trim & vbCrLf & vbCrLf

                        strImpressao &= "<ce>" & "A Parcela será considerada paga" & "</ce>" & vbCrLf
                        strImpressao &= "<ce>" & "quando conter o RECIBO DE PAGAMENTO." & "</ce>" & vbCrLf

                        If NomeEmpresa.Replace("Á", "A").Contains("TAUA") = True Then
                            strImpressao &= vbCrLf
                            strImpressao &= "<ce>" & "Pague em dia e aumento seu Limite." & "</ce>" & vbCrLf
                            strImpressao &= "<ce>" & "O seu nome é seu maior patrimônio!" & "</ce>" & vbCrLf
                        End If
                        strImpressao &= strTraço & vbCrLf

                        strImpressao &= "<ce>" & "DOCUMENTO NÃO FISCAL" & "</ce>" & vbCrLf

                        iRetorno = clsEpson.IniciaPorta(PortaImpressora)

                        iRetorno = clsEpson.ImprimeTextoTag(strImpressao)

                        If TemGuilhotina = True Then
                            iRetorno = clsEpson.AcionaGuilhotina(1)
                        End If
                        iRetorno = clsEpson.FechaPorta()
                    End If



                End If

                'ATÉ AQUI
                '###################################################################################################################
            End If

            If NomeEmpresa.Contains("TAUÁ") = False Then

                If MsgBox("Deseja imprimir a NOTA PROMISSÓRIA?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    If strVenc = "" Then
                        MsgBox("Só é possível imprimir a NOTA PROMISSÓRIA quando o Carne foi impresso!", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                    Dim rel As New relPromissoria
                    Dim culture As New CultureInfo("pt-BR")
                    Dim dtfi As DateTimeFormatInfo = culture.DateTimeFormat
                    Dim dia As Integer = DateTime.Now.Day
                    Dim ano As Integer = DateTime.Now.Year
                    Dim mes As String = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Month))

                    Dim diasemana As String = culture.TextInfo.ToTitleCase(dtfi.GetDayName(DateTime.Now.DayOfWeek))

                    Dim data As String = diasemana & ", " & dia & " de " & mes & " de " & ano
                    Dim vetData As Array
                    vetData = Split(strVenc, "/")
                    Dim intMes, intDia, intAno As Integer
                    intMes = vetData(1)
                    intDia = vetData(0)
                    intAno = vetData(2)
                    Dim strMesVenc As String = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(intMes))
                    Dim strDia As String = getInteger(intDia)
                    Dim strAno As String = getInteger(intAno)
                    Dim dt As DataTable
                    dt = CarregarDataTable("SELECT Nome, Endereco, Numero, Bairro, Cidade , Estado, CPF FROM Cliente where Codigo = " & intCodCliente)
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


                    rel.lblNumero.Text = "01/01"
                    rel.lblValor.Text = .dblValorTotal.ToString("0.00")
                    Dim strValorExt As String = .dblValorTotal.ToString("0.00")
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
                End If

            End If
        End With

    End Sub

    Private Sub ImprimeCrediario2()

        With frmCrediario2
            Dim strVenc As String = ""
            If MsgBox("Deseja imprimir o carnê?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Dim I As Integer
                If ModeloCarne.Trim = "1" Or ModeloCarne.Trim = "" Then

                    Dim rel As New relCred
                    rel.picLogo.Image = LogoTipo
                    For I = 0 To .grd1.RowCount - 1
                        rel.tbCred.Rows.Add()
                        rel.tbCred.Rows.Item(I).Item("Vencimento") = .grd1.GetRowCellDisplayText(I, .colVencimento)
                        strVenc = .grd1.GetRowCellDisplayText(I, .colVencimento)
                        rel.tbCred.Rows.Item(I).Item("Valor") = .grd1.GetRowCellDisplayText(I, .colValor)
                        rel.tbCred.Rows.Item(I).Item("CodVenda") = intOrdem
                        rel.tbCred.Rows.Item(I).Item("Prest") = .grd1.GetRowCellDisplayText(I, .colParcela) & "/" & .grd1.RowCount

                        rel.tbCred.Rows.Item(I).Item("Cliente") = Me.txtCli.Text.Trim

                        rel.tbCred.Rows.Item(I).Item("Empresa") = NomeEmpresa
                        rel.tbCred.Rows.Item(I).Item("Endereco") = EnderecoEmpresa
                        rel.tbCred.Rows.Item(I).Item("Telefone") = TelefoneEmpresa
                        rel.tbCred.Rows.Item(I).Item("Data") = Format(Date.Today, "dd/MM/yyyy")
                    Next

                    rel.ShowPreviewDialog()


                ElseIf ModeloCarne.Trim = "2" Then

                    If Impressora = "DARUMA" Then
                        If TemImpressora = False Then Exit Sub

                        Dim strImpressao As String

                        strImpressao = "<tc>#</tc>" & vbCrLf

                        strImpressao &= "<b><e><ce>" & NomeEmpresa.ToString.Trim & "</ce></e></b>" & vbCrLf

                        strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf

                        strImpressao &= "<ce>" & TelefoneEmpresa & "</ce>" & vbCrLf
                        strImpressao &= "<tc>#</tc>" & vbCrLf

                        strImpressao &= "<e><ce>CREDIÁRIO" & "</ce></e>" & vbCrLf

                        strImpressao &= "<tc>-</tc>" & vbCrLf

                        Dim dt As DataTable

                        dt = CarregarDataTable("Select Nome, CPF, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & intCodCliente)

                        If dt.Rows.Count > 0 Then
                            If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                                strImpressao &= "<b><e><c>" & dt.Rows.Item(0).Item("Nome").ToString & "</c></e></b>" & vbCrLf
                            End If

                            If dt.Rows.Item(0).Item("CPF").ToString <> "" Then
                                strImpressao &= "<c>" & dt.Rows.Item(0).Item("CPF").ToString & "</c>" & vbCrLf
                            End If

                            'If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                            '    strImpressao &= "<c>" & dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & "</c>" & vbCrLf
                            'End If

                            'If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                            '    strImpressao &= "<c>" & dt.Rows.Item(0).Item("Telefone").ToString & "</c>" & vbCrLf
                            'End If

                        End If

                        strImpressao &= "<tc>-</tc>" & vbCrLf

                        strImpressao &= "<b><e><c>" & "Venda Nº " & intOrdem & "</c></e></b>" & vbCrLf

                        For I = 0 To .grd1.RowCount - 1
                            strImpressao &= "<c>Nº Parcela: " & .grd1.GetRowCellDisplayText(I, .colParcela).Trim & "/" & .grd1.RowCount & "</c>" & vbCrLf
                            strImpressao &= "<c>Vencimento: " & .grd1.GetRowCellDisplayText(I, .colVencimento).Trim & "</c>" & vbCrLf
                            strVenc = .grd1.GetRowCellDisplayText(I, .colVencimento)
                            strImpressao &= "<c><b>Valor Parc: R$ " & .grd1.GetRowCellDisplayText(I, .colValor).Trim & "    Data Pagamento:____/____/________</b></c>" & vbCrLf
                            strImpressao &= "<l></l>" & vbCrLf
                            strImpressao &= "<c>Autenticação:_______________________________________</c>" & vbCrLf
                            strImpressao &= "<tc>-</tc>" & vbCrLf

                        Next

                        strImpressao &= "<l></l>" & vbCrLf

                        strImpressao &= "<c><b>Total Crediário: R$ " & .txtValCred.Text.Trim & "</b></c>" & vbCrLf

                        strImpressao &= "<l></l>" & vbCrLf

                        strImpressao &= "<c><b>A Parcela será considerada paga</b></c>" & vbCrLf
                        strImpressao &= "<c><b>quando conter O RECIBO DE PAGAMENTO.</b></c>" & vbCrLf

                        strImpressao &= "<l></l>" & vbCrLf

                        If NomeEmpresa.Replace("Á", "A").Contains("TAUA") = True Then
                            strImpressao &= "<c>Pague em dia e aumento seu Limite.</c>" & vbCrLf
                            strImpressao &= "<c>O seu nome é seu maior patrimônio!</c>" & vbCrLf
                        End If
                        strImpressao &= "<tc>-</tc>" & vbCrLf

                        strImpressao &= "<e><ce>DOCUMENTO NÃO FISCAL" & "</ce></e>" & vbCrLf

                        strImpressao &= "<l></l>" & vbCrLf
                        strImpressao &= "<l></l>" & vbCrLf
                        strImpressao &= "<l></l>" & vbCrLf

                        If TemGuilhotina = True Then
                            strImpressao &= "<gui></gui>" & vbCrLf
                        End If

                        If ImpressoraOK() = True Then
                            iRetorno = (iImprimirTexto_DUAL_DarumaFramework(strImpressao, 0))
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


                        Dim intTamEsp As Integer
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

                        strImpressao &= Cent("CREDIÁRIO", intTamEsp) & vbCrLf

                        strImpressao &= strTraço & vbCrLf

                        Dim dt As DataTable

                        dt = CarregarDataTable("Select Nome, CPF, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & intCodCliente)

                        If dt.Rows.Count > 0 Then
                            If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                                strImpressao &= dt.Rows.Item(0).Item("Nome").ToString & vbCrLf
                            End If

                            If dt.Rows.Item(0).Item("CPF").ToString <> "" Then
                                strImpressao &= dt.Rows.Item(0).Item("CPF").ToString & vbCrLf
                            End If

                            'If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                            '    strImpressao &= dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & vbCrLf
                            'End If

                            'If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                            '    strImpressao &= dt.Rows.Item(0).Item("Telefone").ToString & vbCrLf
                            'End If

                        End If

                        strImpressao &= strTraço & vbCrLf

                        strImpressao &= Dir("Venda N: " & intOrdem, intTamEsp) & vbCrLf

                        For I = 0 To .grd1.RowCount - 1
                            strImpressao &= "N. Parcela: " & .grd1.GetRowCellDisplayText(I, .colParcela).Trim & "/" & .grd1.RowCount & vbCrLf
                            strImpressao &= "Vencimento: " & .grd1.GetRowCellDisplayText(I, .colVencimento).Trim & vbCrLf
                            strVenc = .grd1.GetRowCellDisplayText(I, .colVencimento)
                            strImpressao &= "Vlr Parc: R$ " & .grd1.GetRowCellDisplayText(I, .colValor).Trim & "  Dt Pag:___/___/______" & vbCrLf
                            strImpressao &= " " & vbCrLf
                            strImpressao &= "Autenticação:______________________________" & vbCrLf
                            strImpressao &= strTraço & vbCrLf

                        Next

                        strImpressao &= " " & vbCrLf

                        strImpressao &= "Total Crediário: R$ " & .txtValCred.Text.Trim & vbCrLf & vbCrLf

                        strImpressao &= Cent("A Parcela será considerada paga", intTamEsp) & vbCrLf
                        strImpressao &= Cent("quando conter o RECIBO DE PAGAMENTO.", intTamEsp) & vbCrLf

                        If NomeEmpresa.Replace("Á", "A").Contains("TAUA") = True Then
                            strImpressao &= vbCrLf
                            strImpressao &= Cent("Pague em dia e aumento seu Limite.", intTamEsp) & vbCrLf
                            strImpressao &= Cent("O seu nome é seu maior patrimônio!", intTamEsp) & vbCrLf
                        End If
                        strImpressao &= strTraço & vbCrLf

                        strImpressao &= Cent("DOCUMENTO NÃO FISCAL", intTamEsp) & vbCrLf

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

                        strImpressao &= "<ce>" & "CREDIÁRIO" & "</ce>" & vbCrLf

                        strImpressao &= strTraço & vbCrLf

                        Dim dt As DataTable

                        dt = CarregarDataTable("Select Nome, CPF, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & intCodCliente)

                        If dt.Rows.Count > 0 Then
                            If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                                strImpressao &= dt.Rows.Item(0).Item("Nome").ToString & vbCrLf
                            End If

                            If dt.Rows.Item(0).Item("CPF").ToString <> "" Then
                                strImpressao &= dt.Rows.Item(0).Item("CPF").ToString & vbCrLf
                            End If

                            'If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                            '    strImpressao &= dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & vbCrLf
                            'End If

                            'If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                            '    strImpressao &= dt.Rows.Item(0).Item("Telefone").ToString & vbCrLf
                            'End If

                        End If

                        strImpressao &= strTraço & vbCrLf

                        strImpressao &= "Venda N: " & intOrdem & vbCrLf

                        For I = 0 To .grd1.RowCount - 1
                            strImpressao &= "N. Parcela: " & .grd1.GetRowCellDisplayText(I, .colParcela).Trim & "/" & .grd1.RowCount & vbCrLf
                            strImpressao &= "Vencimento: " & .grd1.GetRowCellDisplayText(I, .colVencimento).Trim & vbCrLf
                            strVenc = .grd1.GetRowCellDisplayText(I, .colVencimento)
                            strImpressao &= "Vlr Parc: R$ " & .grd1.GetRowCellDisplayText(I, .colValor).Trim & "  Dt Pag:___/___/______" & vbCrLf
                            strImpressao &= " " & vbCrLf
                            strImpressao &= "Autenticação:______________________________" & vbCrLf
                            strImpressao &= strTraço & vbCrLf

                        Next

                        strImpressao &= " " & vbCrLf

                        strImpressao &= "Total Crediário: R$ " & .txtValCred.Text.Trim & vbCrLf & vbCrLf

                        strImpressao &= "<ce>" & "A Parcela será considerada paga" & "</ce>" & vbCrLf
                        strImpressao &= "<ce>" & "quando conter o RECIBO DE PAGAMENTO." & "</ce>" & vbCrLf

                        If NomeEmpresa.Replace("Á", "A").Contains("TAUA") = True Then
                            strImpressao &= vbCrLf
                            strImpressao &= "<ce>" & "Pague em dia e aumento seu Limite." & "</ce>" & vbCrLf
                            strImpressao &= "<ce>" & "O seu nome é seu maior patrimônio!" & "</ce>" & vbCrLf
                        End If
                        strImpressao &= strTraço & vbCrLf

                        strImpressao &= "<ce>" & "DOCUMENTO NÃO FISCAL" & "</ce>" & vbCrLf

                        iRetorno = clsEpson.IniciaPorta(PortaImpressora)

                        iRetorno = clsEpson.ImprimeTextoTag(strImpressao)

                        If TemGuilhotina = True Then
                            iRetorno = clsEpson.AcionaGuilhotina(1)
                        End If
                        iRetorno = clsEpson.FechaPorta()
                    End If

                End If

                'ATÉ AQUI
                '###################################################################################################################
            End If

            If NomeEmpresa.Contains("TAUÁ") = False Then

                If MsgBox("Deseja imprimir a NOTA PROMISSÓRIA?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    If strVenc = "" Then
                        MsgBox("Só é possível imprimir a NOTA PROMISSÓRIA quando o Carne foi impresso!", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                    Dim rel As New relPromissoria
                    Dim culture As New CultureInfo("pt-BR")
                    Dim dtfi As DateTimeFormatInfo = culture.DateTimeFormat
                    Dim dia As Integer = DateTime.Now.Day
                    Dim ano As Integer = DateTime.Now.Year
                    Dim mes As String = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Month))
                    Dim diasemana As String = culture.TextInfo.ToTitleCase(dtfi.GetDayName(DateTime.Now.DayOfWeek))
                    Dim data As String = diasemana & ", " & dia & " de " & mes & " de " & ano
                    Dim vetData As Array
                    vetData = Split(strVenc, "/")
                    Dim intMes, intDia, intAno As Integer
                    intMes = vetData(1)
                    intDia = vetData(0)
                    intAno = vetData(2)
                    Dim strMesVenc As String = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(intMes))
                    Dim strDia As String = getInteger(intDia)
                    Dim strAno As String = getInteger(intAno)
                    Dim dt As DataTable
                    dt = CarregarDataTable("SELECT Nome, Endereco, Numero, Bairro, Cidade , Estado, CPF FROM Cliente where Codigo = " & intCodCliente)
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


                    rel.lblNumero.Text = "01/01"
                    rel.lblValor.Text = .dblValorTotal.ToString("0.00")
                    Dim strValorExt As String = .dblValorTotal.ToString("0.00")
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
                End If

            End If
        End With

    End Sub

    Private Sub ImprimeCrediario3()

        With frmCrediario3
            Dim strVenc As String = ""
            If MsgBox("Deseja imprimir o carnê?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Dim I As Integer
                If ModeloCarne.Trim = "1" Or ModeloCarne.Trim = "" Then

                    Dim rel As New relCred
                    rel.picLogo.Image = LogoTipo
                    For I = 0 To .grd1.RowCount - 1
                        rel.tbCred.Rows.Add()
                        rel.tbCred.Rows.Item(I).Item("Vencimento") = .grd1.GetRowCellDisplayText(I, .colVencimento)
                        strVenc = .grd1.GetRowCellDisplayText(I, .colVencimento)
                        rel.tbCred.Rows.Item(I).Item("Valor") = .grd1.GetRowCellDisplayText(I, .colValor)
                        rel.tbCred.Rows.Item(I).Item("CodVenda") = intOrdem
                        rel.tbCred.Rows.Item(I).Item("Prest") = .grd1.GetRowCellDisplayText(I, .colParcela) & "/" & .grd1.RowCount

                        rel.tbCred.Rows.Item(I).Item("Cliente") = Me.txtCli.Text.Trim

                        rel.tbCred.Rows.Item(I).Item("Empresa") = NomeEmpresa
                        rel.tbCred.Rows.Item(I).Item("Endereco") = EnderecoEmpresa
                        rel.tbCred.Rows.Item(I).Item("Telefone") = TelefoneEmpresa
                        rel.tbCred.Rows.Item(I).Item("Data") = Format(Date.Today, "dd/MM/yyyy")
                    Next

                    rel.ShowPreviewDialog()


                ElseIf ModeloCarne.Trim = "2" Then

                    If Impressora = "DARUMA" Then
                        If TemImpressora = False Then Exit Sub

                        Dim strImpressao As String

                        strImpressao = "<tc>#</tc>" & vbCrLf

                        strImpressao &= "<b><e><ce>" & NomeEmpresa.ToString.Trim & "</ce></e></b>" & vbCrLf

                        strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf

                        strImpressao &= "<ce>" & TelefoneEmpresa & "</ce>" & vbCrLf
                        strImpressao &= "<tc>#</tc>" & vbCrLf

                        strImpressao &= "<e><ce>CREDIÁRIO" & "</ce></e>" & vbCrLf

                        strImpressao &= "<tc>-</tc>" & vbCrLf

                        Dim dt As DataTable

                        dt = CarregarDataTable("Select Nome, CPF, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & intCodCliente)

                        If dt.Rows.Count > 0 Then
                            If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                                strImpressao &= "<b><e><c>" & dt.Rows.Item(0).Item("Nome").ToString & "</c></e></b>" & vbCrLf
                            End If

                            If dt.Rows.Item(0).Item("CPF").ToString <> "" Then
                                strImpressao &= "<c>" & dt.Rows.Item(0).Item("CPF").ToString & "</c>" & vbCrLf
                            End If

                            'If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                            '    strImpressao &= "<c>" & dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & "</c>" & vbCrLf
                            'End If

                            'If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                            '    strImpressao &= "<c>" & dt.Rows.Item(0).Item("Telefone").ToString & "</c>" & vbCrLf
                            'End If

                        End If

                        strImpressao &= "<tc>-</tc>" & vbCrLf

                        strImpressao &= "<b><e><c>" & "Venda Nº " & intOrdem & "</c></e></b>" & vbCrLf

                        For I = 0 To .grd1.RowCount - 1
                            strImpressao &= "<c>Nº Parcela: " & .grd1.GetRowCellDisplayText(I, .colParcela).Trim & "/" & .grd1.RowCount & "</c>" & vbCrLf
                            strImpressao &= "<c>Vencimento: " & .grd1.GetRowCellDisplayText(I, .colVencimento).Trim & "</c>" & vbCrLf
                            strVenc = .grd1.GetRowCellDisplayText(I, .colVencimento)
                            strImpressao &= "<c><b>Valor Parc: R$ " & .grd1.GetRowCellDisplayText(I, .colValor).Trim & "    Data Pagamento:____/____/________</b></c>" & vbCrLf
                            strImpressao &= "<l></l>" & vbCrLf
                            strImpressao &= "<c>Autenticação:_______________________________________</c>" & vbCrLf
                            strImpressao &= "<tc>-</tc>" & vbCrLf

                        Next

                        strImpressao &= "<l></l>" & vbCrLf

                        strImpressao &= "<c><b>Total Crediário: R$ " & .txtValCred.Text.Trim & "</b></c>" & vbCrLf

                        strImpressao &= "<l></l>" & vbCrLf

                        strImpressao &= "<c><b>A Parcela será considerada paga</b></c>" & vbCrLf
                        strImpressao &= "<c><b>quando conter O RECIBO DE PAGAMENTO.</b></c>" & vbCrLf

                        strImpressao &= "<l></l>" & vbCrLf

                        If NomeEmpresa.Replace("Á", "A").Contains("TAUA") = True Then
                            strImpressao &= "<c>Pague em dia e aumento seu Limite.</c>" & vbCrLf
                            strImpressao &= "<c>O seu nome é seu maior patrimônio!</c>" & vbCrLf
                        End If
                        strImpressao &= "<tc>-</tc>" & vbCrLf

                        strImpressao &= "<e><ce>DOCUMENTO NÃO FISCAL" & "</ce></e>" & vbCrLf

                        strImpressao &= "<l></l>" & vbCrLf
                        strImpressao &= "<l></l>" & vbCrLf
                        strImpressao &= "<l></l>" & vbCrLf

                        If TemGuilhotina = True Then
                            strImpressao &= "<gui></gui>" & vbCrLf
                        End If

                        If ImpressoraOK() = True Then
                            iRetorno = (iImprimirTexto_DUAL_DarumaFramework(strImpressao, 0))
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

                        Dim intTamEsp As Integer
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

                        strImpressao &= Cent("CREDIÁRIO", intTamEsp) & vbCrLf

                        strImpressao &= strTraço & vbCrLf

                        Dim dt As DataTable

                        dt = CarregarDataTable("Select Nome, CPF, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & intCodCliente)

                        If dt.Rows.Count > 0 Then
                            If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                                strImpressao &= dt.Rows.Item(0).Item("Nome").ToString & vbCrLf
                            End If

                            If dt.Rows.Item(0).Item("CPF").ToString <> "" Then
                                strImpressao &= dt.Rows.Item(0).Item("CPF").ToString & vbCrLf
                            End If

                            'If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                            '    strImpressao &= dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & vbCrLf
                            'End If

                            'If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                            '    strImpressao &= dt.Rows.Item(0).Item("Telefone").ToString & vbCrLf
                            'End If

                        End If

                        strImpressao &= strTraço & vbCrLf

                        strImpressao &= Dir("Venda N: " & intOrdem, intTamEsp) & vbCrLf

                        For I = 0 To .grd1.RowCount - 1
                            strImpressao &= "N. Parcela: " & .grd1.GetRowCellDisplayText(I, .colParcela).Trim & "/" & .grd1.RowCount & vbCrLf
                            strImpressao &= "Vencimento: " & .grd1.GetRowCellDisplayText(I, .colVencimento).Trim & vbCrLf
                            strVenc = .grd1.GetRowCellDisplayText(I, .colVencimento)
                            strImpressao &= "Vlr Parc: R$ " & .grd1.GetRowCellDisplayText(I, .colValor).Trim & "  Dt Pag:___/___/______" & vbCrLf
                            strImpressao &= " " & vbCrLf
                            strImpressao &= "Autenticação:______________________________" & vbCrLf
                            strImpressao &= strTraço & vbCrLf

                        Next

                        strImpressao &= " " & vbCrLf

                        strImpressao &= "Total Crediário: R$ " & .txtValCred.Text.Trim & vbCrLf & vbCrLf

                        strImpressao &= Cent("A Parcela será considerada paga", intTamEsp) & vbCrLf
                        strImpressao &= Cent("quando conter o RECIBO DE PAGAMENTO.", intTamEsp) & vbCrLf

                        If NomeEmpresa.Replace("Á", "A").Contains("TAUA") = True Then
                            strImpressao &= vbCrLf
                            strImpressao &= Cent("Pague em dia e aumento seu Limite.", intTamEsp) & vbCrLf
                            strImpressao &= Cent("O seu nome é seu maior patrimônio!", intTamEsp) & vbCrLf
                        End If
                        strImpressao &= strTraço & vbCrLf

                        strImpressao &= Cent("DOCUMENTO NÃO FISCAL", intTamEsp) & vbCrLf

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

                        strImpressao &= "<ce>" & "CREDIÁRIO" & "</ce>" & vbCrLf

                        strImpressao &= strTraço & vbCrLf

                        Dim dt As DataTable

                        dt = CarregarDataTable("Select Nome, CPF, Endereco, Numero, Complemento, Bairro, Telefone, Cidade from Cliente where Codigo =" & intCodCliente)

                        If dt.Rows.Count > 0 Then
                            If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                                strImpressao &= dt.Rows.Item(0).Item("Nome").ToString & vbCrLf
                            End If

                            If dt.Rows.Item(0).Item("CPF").ToString <> "" Then
                                strImpressao &= dt.Rows.Item(0).Item("CPF").ToString & vbCrLf
                            End If

                            'If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                            '    strImpressao &= dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & vbCrLf
                            'End If

                            'If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                            '    strImpressao &= dt.Rows.Item(0).Item("Telefone").ToString & vbCrLf
                            'End If

                        End If

                        strImpressao &= strTraço & vbCrLf

                        strImpressao &= "Venda N: " & intOrdem & vbCrLf

                        For I = 0 To .grd1.RowCount - 1
                            strImpressao &= "N. Parcela: " & .grd1.GetRowCellDisplayText(I, .colParcela).Trim & "/" & .grd1.RowCount & vbCrLf
                            strImpressao &= "Vencimento: " & .grd1.GetRowCellDisplayText(I, .colVencimento).Trim & vbCrLf
                            strVenc = .grd1.GetRowCellDisplayText(I, .colVencimento)
                            strImpressao &= "Vlr Parc: R$ " & .grd1.GetRowCellDisplayText(I, .colValor).Trim & "  Dt Pag:___/___/______" & vbCrLf
                            strImpressao &= " " & vbCrLf
                            strImpressao &= "Autenticação:______________________________" & vbCrLf
                            strImpressao &= strTraço & vbCrLf

                        Next

                        strImpressao &= " " & vbCrLf

                        strImpressao &= "Total Crediário: R$ " & .txtValCred.Text.Trim & vbCrLf & vbCrLf

                        strImpressao &= "<ce>" & "A Parcela será considerada paga" & "</ce>" & vbCrLf
                        strImpressao &= "<ce>" & "quando conter o RECIBO DE PAGAMENTO." & "</ce>" & vbCrLf

                        If NomeEmpresa.Replace("Á", "A").Contains("TAUA") = True Then
                            strImpressao &= vbCrLf
                            strImpressao &= "<ce>" & "Pague em dia e aumento seu Limite." & "</ce>" & vbCrLf
                            strImpressao &= "<ce>" & "O seu nome é seu maior patrimônio!" & "</ce>" & vbCrLf
                        End If
                        strImpressao &= strTraço & vbCrLf

                        strImpressao &= "<ce>" & "DOCUMENTO NÃO FISCAL" & "</ce>" & vbCrLf

                        iRetorno = clsEpson.IniciaPorta(PortaImpressora)

                        iRetorno = clsEpson.ImprimeTextoTag(strImpressao)

                        If TemGuilhotina = True Then
                            iRetorno = clsEpson.AcionaGuilhotina(1)
                        End If
                        iRetorno = clsEpson.FechaPorta()
                    End If

                End If

                'ATÉ AQUI
                '###################################################################################################################
            End If

            If NomeEmpresa.Contains("TAUÁ") = False Then

                If MsgBox("Deseja imprimir a NOTA PROMISSÓRIA?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    If strVenc = "" Then
                        MsgBox("Só é possível imprimir a NOTA PROMISSÓRIA quando o Carne foi impresso!", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                    Dim rel As New relPromissoria
                    Dim culture As New CultureInfo("pt-BR")
                    Dim dtfi As DateTimeFormatInfo = culture.DateTimeFormat
                    Dim dia As Integer = DateTime.Now.Day
                    Dim ano As Integer = DateTime.Now.Year
                    Dim mes As String = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Month))
                    Dim diasemana As String = culture.TextInfo.ToTitleCase(dtfi.GetDayName(DateTime.Now.DayOfWeek))
                    Dim data As String = diasemana & ", " & dia & " de " & mes & " de " & ano
                    Dim vetData As Array
                    vetData = Split(strVenc, "/")
                    Dim intMes, intDia, intAno As Integer
                    intMes = vetData(1)
                    intDia = vetData(0)
                    intAno = vetData(2)
                    Dim strMesVenc As String = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(intMes))
                    Dim strDia As String = getInteger(intDia)
                    Dim strAno As String = getInteger(intAno)
                    Dim dt As DataTable
                    dt = CarregarDataTable("SELECT Nome, Endereco, Numero, Bairro, Cidade , Estado, CPF FROM Cliente where Codigo = " & intCodCliente)
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


                    rel.lblNumero.Text = "01/01"
                    rel.lblValor.Text = .dblValorTotal.ToString("0.00")
                    Dim strValorExt As String = .dblValorTotal.ToString("0.00")
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
                End If

            End If
        End With

    End Sub

    Private Sub btnCred_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCred.Click
        'If intCodCliente = 1 Then
        '    MsgBox("Selecione o cliente antes de fazer o parcelamento!", MsgBoxStyle.Information)
        '    Exit Sub
        'End If
        'If DentroLimiteCredito(Me.txtSubTotal.Text.Trim) = False Then Exit Sub

        'If Validar(Me.txtVez) = False Then Exit Sub

        'Dim frm As New frmCrediario

        'frm.intOrdem = intOrdem
        'frm.intCodCliente = intCodCliente
        'frm.dblValorCrediario = Me.txtSubTotal.Text.Trim
        'frm.strPagamento = Me.cboPag.Text.Trim
        'frm.txtValCred.Text = Me.txtSubTotal.Text.Trim
        'frm.dtVen.EditValue = Date.Today.AddMonths(1)
        'frm.seParcela.Text = Me.txtVez.Text.Trim

        'frm.strCliente = Me.txtCli.Text
        'frm.strDataVenda = Date.Today
        'frm.dblValorTotal = Me.txtTotal.Text
        'frm.ShowDialog()

        'If bolCrediarioOK = True Then
        '    InserirPagamento()
        'End If

        InserirPagamento(True)
    End Sub

    Private Function DentroLimiteCredito(ByVal parValorVenda As String) As Boolean

        If Me.txtLimite.Text.Trim <> "" Then
            If CDbl(parValorVenda) > CDbl(Me.txtLimite.Text.Trim) Then
                MsgBox("O valor da compra é maior que o limite de crédito do cliente!", MsgBoxStyle.Information)
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        'If DentroLimiteCredito(Me.txtTotal.Text.Trim) = False Then Exit Sub

        InserirPagamento(False)


    End Sub

    Private Sub txtQtd_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQtd.Enter
        Select Case Me.txtPerDesc.Text.Trim
            Case "UN", "JG", "KIT"
                Me.txtQtd.CasasDecimais = 0
            Case "KG", "LT"
                Me.txtQtd.CasasDecimais = 3
            Case "MT"
                Me.txtQtd.CasasDecimais = 2
        End Select
    End Sub

    Private Function TotalEconomizado() As Double
        Dim Resultado As Double = 0
        Dim intQtd As Integer = 0
        Dim dblEconomia As Double = 0
        Dim bolPassou As Boolean = False

        If Me.grd1.RowCount > 0 Then
            For I As Integer = 0 To Me.grd1.RowCount - 1
                intQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtde)

                If Me.grd1.GetRowCellDisplayText(I, Me.colValorAnt) <> "" Then
                    dblEconomia = Me.grd1.GetRowCellDisplayText(I, Me.colValorAnt)
                Else
                    dblEconomia = Me.grd1.GetRowCellDisplayText(I, Me.colValorSemDesconto)
                End If

                If bolPassou = False Then
                    Resultado = dblEconomia * intQtd
                    bolPassou = True
                Else
                    Resultado = Resultado + dblEconomia * intQtd
                End If
            Next
        End If

        Return Resultado
    End Function

    Private Sub Imprimir(ByVal parCodOrdem As Integer, ByVal parGaveta As Boolean)
        'TOTAL ECONOMIZADO 
        If EconomiaCupom = True Then
            dblValorEconomia = TotalEconomizado()
        End If

        If Impressora.Contains("ESC/POS") = True Then
            clsImprimir.ImprimeCupom(parCodOrdem, intCodPedido, parGaveta)
            Exit Sub
        End If

        Dim dtPed As DataTable = CarregarDataTable("SELECT Pedido.CodProdInterno, Pedido.Produto, " & _
        "Pedido.ValorUnitario, Pedido.Qtd, Pedido.ValorTotal, Produto.UnidadeMedida as UM, Total.CodCli, " & _
        "Total.CodConfig, Total.Total, Total.Troco, Total.Recebido, Total.ValDesc, Total.Data, " & _
        "Pedido.CodFunc, Pedido.CodProd, Total.Hora, Devolvido, CodPedido " & _
        "FROM (Pedido left join Produto on Pedido.CodProd = Produto.Codigo) left join Total on Pedido.CodOrdem = Total.CodOrdem where " & _
        "Pedido.CodOrdem = " & parCodOrdem & " and Pedido.TipoItens <> 'CONSUMO' and " & _
        "Pedido.CodConfig =" & CodConfig & " and Total.CodConfig =" & CodConfig)

        Dim bolGaveta As Boolean = True
        If NomePCGaveta <> "" Then
            If NomePCGaveta.ToUpper <> My.Computer.Name.ToUpper Then
                bolGaveta = False
            End If
        End If

        Dim dblValDesTot As Double

        If dtPed.Rows.Count > 0 Then
            If dtPed.Rows.Item(0).Item("CodPedido").ToString <> "" Then
                intCodPedido = dtPed.Rows.Item(0).Item("CodPedido")
            End If

            Dim dtObsPed As DataTable = CarregarDataTable("Select Descricao from TotalConsig where CodOrdens =" & intCodPedido & " and CodConfig =" & CodConfig)

            Dim strObsPedido As String = ""

            If dtObsPed.Rows.Count > 0 Then
                strObsPedido = dtObsPed.Rows.Item(0).Item("Descricao").ToString
            End If
            If Impressora = "DARUMA" Then
                Dim strImpressao As String

                strImpressao = "<tc>#</tc>" & vbCrLf

                strImpressao &= "<b><ce>" & NomeEmpresa.ToString.Trim & "</ce></b>" & vbCrLf

                strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf

                strImpressao &= "<ce>" & TelefoneEmpresa & "</ce>" & vbCrLf
                strImpressao &= "<tc>#</tc>" & vbCrLf
                strImpressao &= "<ad><dt></dt></ad>" & vbCrLf
                strImpressao &= "<e><ce> Venda Nº " & parCodOrdem & "</ce></e>" & vbCrLf
                strImpressao &= "<ad>CÓDIGO    DESCRIÇÃO                            </ad>" & vbCrLf
                strImpressao &= "<ad>UN.    QTD.    VL UNIT R$           VL Total R$</ad>" & vbCrLf
                strImpressao &= "<tc>-</tc>" & vbCrLf

                Dim L As Integer
                Dim dblQtd As Double
                Dim dblValor As Double
                For L = 0 To dtPed.Rows.Count - 1
                    Dim strCod, strProd, strQtd, strUM As String
                    Dim dblUni, dblTot As Double

                    strCod = dtPed.Rows.Item(L).Item("CodProdInterno").ToString
                    strProd = dtPed.Rows.Item(L).Item("Produto").ToString
                    dblUni = dtPed.Rows.Item(L).Item("ValorUnitario").ToString
                    strQtd = dtPed.Rows.Item(L).Item("Qtd").ToString
                    dblTot = dtPed.Rows.Item(L).Item("ValorTotal").ToString
                    dblValDesTot = dtPed.Rows.Item(L).Item("ValDesc").ToString
                    strUM = dtPed.Rows.Item(L).Item("UM").ToString
                    If strUM.Trim = "" Then
                        strUM = "UN"
                    End If
                    dblQtd += dtPed.Rows.Item(L).Item("Qtd").ToString
                    strImpressao &= "<c><i>  " & strCod & "   " & strProd & "</i></c>" & vbCrLf
                    Dim str As String
                    str = " " & strUM & "    " & Dir(strQtd & "  X  " & dblUni.ToString("###,##0.000"), 21) & Esq(dblTot.ToString("###,##0.00"), 20)
                    strImpressao &= str & vbCrLf
                Next
                dblValor = dtPed.Rows.Item(0).Item("Total").ToString

                strImpressao &= "<tc>-</tc>" & vbCrLf
                strImpressao &= "<ad><b>" & "N de Itens " & Esq(dblQtd, 9) & "</b></ad>" & vbCrLf
                strImpressao &= "<ad><b>" & "Total R$ " & Esq(dblValor.ToString("0.00"), 9) & "</b></ad>" & vbCrLf
                Dim dblTroco As Double = 0
                If dtPed.Rows.Item(0).Item("Troco").ToString <> "" Then
                    dblTroco = dtPed.Rows.Item(0).Item("Troco").ToString
                End If
                Dim bolTroco As Boolean = False
                Dim P As Integer
                Dim dtPag As DataTable = CarregarDataTable("SELECT Pagamento, Valor FROM Recebimento where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)
                If dtPag.Rows.Count > 0 Then

                    For P = 0 To dtPag.Rows.Count - 1
                        Dim strPag As String = dtPag.Rows.Item(P).Item("Pagamento").ToString
                        If dtPag.Rows.Item(P).Item("Valor").ToString <> "" Then
                            dblValor = dtPag.Rows.Item(P).Item("Valor").ToString
                        End If
                        If strPag.ToUpper.Contains("DINHEIRO") Then
                            If bolTroco = False Then
                                If dblTroco > 0 Then
                                    dblValor = dblValor + dblTroco
                                    bolTroco = True
                                End If
                            End If
                        End If
                        strImpressao &= "<ad><b>" & strPag & " R$ " & Esq(dblValor.ToString("0.00"), 9) & "</b></ad>" & vbCrLf
                    Next
                End If



                strImpressao &= "<ad><b>" & "Troco R$ " & Esq(dblTroco.ToString("0.00"), 9) & "</b></ad>" & vbCrLf

                strImpressao &= "<tc>-</tc>" & vbCrLf

                If GerarComissao = True Then
                    Dim dtFunc As DataTable = CarregarDataTable("SELECT Nome FROM Funcionario left join Pedido on Funcionario.Codigo = Pedido.CodFunc where Pedido.CodOrdem = " & parCodOrdem & " and Pedido.CodConfig =" & CodConfig)
                    If dtFunc.Rows.Count > 0 Then
                        strImpressao &= "<c>" & "Vend.: " & dtFunc.Rows.Item(0).Item("Nome").ToString & "</c>" & vbCrLf
                    End If
                End If

                Dim dtCaixa As DataTable = CarregarDataTable("SELECT Caixa FROM Caixa where Motivo like '%Venda Nº " & parCodOrdem & ",%' and CodConfig = " & CodConfig)
                If dtCaixa.Rows.Count > 0 Then
                    If dtCaixa.Rows.Item(0).Item("Caixa").ToString <> "" Then
                        StringImpressao &= "<c>" & "Vend.: " & dtCaixa.Rows.Item(0).Item("Caixa").ToString & "</c>" & vbCrLf
                    End If
                End If


                Dim dtFut As DataTable = CarregarDataTable("Select Pagamento, convert(Numeric(15,2),Total) as Total, Count(Codigo) as Qtd from Futuro " & _
                "where CodOrdem =" & parCodOrdem & " and CodConfig =" & CodConfig & " group by Pagamento, convert(Numeric(15,2),Total)")

                If dtFut.Rows.Count > 0 Then

                    StringImpressao &= " " & vbCrLf

                    Dim R As Integer

                    For R = 0 To dtFut.Rows.Count - 1


                        StringImpressao &= "<c>" & dtFut.Rows.Item(R).Item("Pagamento").ToString & "</c>" & vbCrLf
                        StringImpressao &= "<c>" & dtFut.Rows.Item(R).Item("Qtd").ToString & " x " & dtFut.Rows.Item(R).Item("Total").ToString & "</c>" & vbCrLf
                        If R <> dtFut.Rows.Count - 1 Then
                            StringImpressao &= " " & vbCrLf
                        End If
                    Next
                End If



                If TotalPendenciaImpressao = True Then
                    Dim dtRec As DataTable = CarregarDataTable("Select sum(convert(numeric(15,2),ValorParcela)) as Valor from ContaReceber where CodCli =" & dtPed.Rows.Item(0).Item("CodCli").ToString & " and CodConfig =" & CodConfig & " and RecebidoOk = 'False'")
                    If dtRec.Rows.Count > 0 Then
                        If dtRec.Rows.Item(0).Item("Valor").ToString <> "" Then
                            StringImpressao &= " " & vbCrLf
                            StringImpressao &= "<c>" & "Total Pendência: R$" & dtRec.Rows.Item(0).Item("Valor").ToString & "</c>" & vbCrLf
                        End If
                    End If
                End If


                Dim dt As DataTable

                dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade, Fantasia from Cliente where Codigo =" & dtPed.Rows.Item(0).Item("CodCli").ToString)

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

                End If


                Dim bol2Via As Boolean = False


                If ModeloCarne <> "1" Then
                    dt = CarregarDataTable("Select Codigo from ContaReceber where CodOrdem =" & parCodOrdem & " and CodConfig =" & CodConfig)

                    If dt.Rows.Count > 0 Then

                        bol2Via = True

                        strImpressao &= "<l></l>" & vbCrLf

                        strImpressao &= "<ce>Reconheco que pagarei a dívida acima</ce>" & vbCrLf
                        strImpressao &= "<ce>apresentada conforme ""Contrato"" assinado</ce>" & vbCrLf
                        strImpressao &= "<ce>em separado.</ce>" & vbCrLf
                        strImpressao &= "<l></l>" & vbCrLf
                        strImpressao &= "<ce>____________________________</ce>" & vbCrLf

                        strImpressao &= "<l></l>" & vbCrLf

                        strImpressao &= "<tc>-</tc>" & vbCrLf

                    End If
                End If



                If ObsPedidoVenda = True Then
                    If Not strObsPedido = "" Then
                        strImpressao &= "<c>Observações do Pedido:</c>" & vbCrLf
                        strImpressao &= "<c>" & strObsPedido & "</c>" & vbCrLf
                        strImpressao &= "<l></l>" & vbCrLf
                    End If
                End If


                If DescricaoVenda <> "" Then
                    strImpressao &= "<c>" & DescricaoVenda & "</c>" & vbCrLf
                    strImpressao &= "<l></l>" & vbCrLf
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
                    'If bol2Via = True Then
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
                If Impressora.Contains("BEMATECH") = True Then
                    iRetorno = clsBematech.IniciaPorta(PortaImpressora)

                ElseIf Impressora.Contains("MP-4000") = True Then
                    Try
                        iRetorno = clsBematech.IniciaPorta(PortaImpressora)

                    Catch ex As Exception

                    End Try
                End If



                strImpressao = strEstrela & vbCrLf

                strImpressao &= Cent(NomeEmpresa.ToString.Trim, intTamEsp) & vbCrLf
                strImpressao &= Cent(EnderecoEmpresa.Trim, intTamEsp) & vbCrLf
                strImpressao &= Cent(TelefoneEmpresa, intTamEsp) & vbCrLf
                strImpressao &= strEstrela & vbCrLf

                strImpressao &= Esq(Format(dtPed.Rows.Item(0).Item("Data"), "dd/MM/yyyy") & " " & dtPed.Rows.Item(0).Item("Hora"), intTamEsp) & vbCrLf
                strImpressao &= Dir("Venda N: " & parCodOrdem, intTamEsp) & vbCrLf
                strImpressao &= "Codigo Descricao                    " & vbCrLf

                If Impressora.Contains("ARQUIVO") = True Then
                    intEsp1 = 31
                Else
                    intEsp1 = 49
                End If

                strImpressao &= Dir("UM   Qtd     Vl Unit R$", intEsp1) & Esq("VL Total R$", 11) & vbCrLf
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
                For L = 0 To dtPed.Rows.Count - 1
                    Dim strCod, strProd, strQtd, strUM As String
                    Dim dblUni, dblTot As Double

                    strCod = dtPed.Rows.Item(L).Item("CodProdInterno").ToString
                    strProd = dtPed.Rows.Item(L).Item("Produto").ToString
                    dblUni = dtPed.Rows.Item(L).Item("ValorUnitario").ToString
                    strQtd = dtPed.Rows.Item(L).Item("Qtd").ToString
                    dblTot = dtPed.Rows.Item(L).Item("ValorTotal").ToString
                    dblValDesTot = dtPed.Rows.Item(L).Item("ValDesc").ToString
                    strUM = dtPed.Rows.Item(L).Item("UM").ToString
                    If strUM.Trim = "" Then
                        strUM = "UN"
                    End If
                    dblQtd += dtPed.Rows.Item(L).Item("Qtd").ToString
                    strImpressao &= strCod & " " & strProd & vbCrLf
                    Dim str As String
                    str = Dir(strUM & "    " & strQtd & "  X  " & dblUni.ToString("####,##0.000"), intEsp1) & Esq(dblTot.ToString("####,##0.00"), intEsp2)
                    strImpressao &= str & vbCrLf
                Next

                If Impressora.Contains("ARQUIVO") = True Then
                    intEsp1 = 32
                Else
                    intEsp1 = 50
                End If


                Dim dblValor As Double
                dblValor = dtPed.Rows.Item(0).Item("Total").ToString
                strImpressao &= strTraço & vbCrLf
                strImpressao &= Esq("N de Itens.....: ", intEsp1) & Esq(dblQtd, 10) & vbCrLf

                If dblValDesTot > 0 Then
                    strImpressao &= Esq("Desconto....: R$ ", intEsp1) & Esq(dblValDesTot.ToString("0.00"), 10) & vbCrLf
                End If

                strImpressao &= Esq("Total.......: R$ ", intEsp1) & Esq(dblValor.ToString("####,##0.00"), 10) & vbCrLf
                Dim P As Integer
                Dim dblTro As Double = 0
                dblTro = dtPed.Rows.Item(0).Item("Troco").ToString

                Dim bolTroco As Boolean = False

                Dim dtPag As DataTable = CarregarDataTable("SELECT Pagamento, Valor FROM Recebimento where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)
                If dtPag.Rows.Count > 0 Then

                    For P = 0 To dtPag.Rows.Count - 1
                        Dim strPag As String = dtPag.Rows.Item(P).Item("Pagamento").ToString
                        If dtPag.Rows.Item(P).Item("Valor").ToString <> "" Then
                            dblValor = dtPag.Rows.Item(P).Item("Valor").ToString
                        End If
                        If strPag.ToUpper.Contains("DINHEIRO") Then
                            If bolTroco = False Then
                                If dblTro > 0 Then
                                    dblValor = dblValor + dblTro
                                    bolTroco = True
                                End If
                            End If
                        End If
                        Dim strComPonto As String = InserirPonto(strPag)
                        strImpressao &= Esq(strComPonto & "R$ ", intEsp1) & Esq(dblValor.ToString("####,##0.00"), 10) & vbCrLf
                    Next
                End If

                strImpressao &= Esq("Troco......: R$ ", intEsp1) & Esq(dblTro.ToString("####,##0.00"), 10) & vbCrLf


                strImpressao &= strTraço & vbCrLf
                If GerarComissao = True Then
                    Dim dtFunc As DataTable = CarregarDataTable("SELECT Nome FROM Funcionario left join Pedido on Funcionario.Codigo = Pedido.CodFunc where Pedido.CodOrdem = " & parCodOrdem & " and Pedido.CodConfig =" & CodConfig)
                    If dtFunc.Rows.Count > 0 Then
                        strImpressao &= Dir("Vend.: " & dtFunc.Rows.Item(0).Item("Nome").ToString, intTamEsp) & vbCrLf
                    End If

                End If
                Dim dtCaixa As DataTable = CarregarDataTable("SELECT Caixa FROM Caixa where Motivo like '%Venda Nº " & parCodOrdem & ",%' and CodConfig = " & CodConfig)
                If dtCaixa.Rows.Count > 0 Then
                    If dtCaixa.Rows.Item(0).Item("Caixa").ToString <> "" Then
                        StringImpressao &= Dir("Oper.: " & dtCaixa.Rows.Item(0).Item("Caixa").ToString, 55) & vbCrLf
                    End If
                End If

                If NomeEmpresa.Replace("Ã", "A").Trim.Contains("CAVALAO") = False Then
                    Dim dtRec As DataTable = CarregarDataTable("Select Pagamento, Vencimento, ValorParcela from ContaReceber where CodOrdem =" & parCodOrdem & " and CodConfig =" & CodConfig)

                    If dtRec.Rows.Count > 0 Then

                        Dim dtVenc As Date
                        Dim dblPar As Double

                        strImpressao &= " " & vbCrLf

                        Dim R As Integer

                        For R = 0 To dtRec.Rows.Count - 1

                            If R = 0 Then
                                strImpressao &= dtRec.Rows.Item(R).Item("Pagamento").ToString & vbCrLf
                            End If

                            dtVenc = dtRec.Rows.Item(R).Item("Vencimento").ToString
                            dblPar = dtRec.Rows.Item(R).Item("ValorParcela").ToString
                            strImpressao &= dtVenc & "   R$ " & dblPar.ToString("0.00") & vbCrLf
                        Next
                    End If
                End If


               

                Dim dtFut As DataTable = CarregarDataTable("Select Pagamento, convert(Numeric(15,2),Total) as Total, Count(Codigo) as Qtd from Futuro " & _
 "where CodOrdem =" & parCodOrdem & " and CodConfig =" & CodConfig & " group by Pagamento, convert(Numeric(15,2),Total)")

                If dtFut.Rows.Count > 0 Then

                    StringImpressao &= " " & vbCrLf

                    Dim R As Integer

                    For R = 0 To dtFut.Rows.Count - 1


                        StringImpressao &= Dir(dtFut.Rows.Item(R).Item("Pagamento").ToString, 55) & vbCrLf
                        StringImpressao &= Dir(dtFut.Rows.Item(R).Item("Qtd").ToString & " x " & dtFut.Rows.Item(R).Item("Total").ToString, 55) & vbCrLf
                        If R <> dtFut.Rows.Count - 1 Then
                            StringImpressao &= " " & vbCrLf
                        End If
                    Next
                Else
                    strImpressao &= " " & vbCrLf

                End If

                If TotalPendenciaImpressao = True Then
                    Dim dtRec As DataTable = CarregarDataTable("Select sum(convert(numeric(15,2),ValorParcela)) as Valor from ContaReceber where CodCli =" & dtPed.Rows.Item(0).Item("CodCli").ToString & " and CodConfig =" & CodConfig & " and RecebidoOk = 'False'")
                    If dtRec.Rows.Count > 0 Then
                        If dtRec.Rows.Item(0).Item("Valor").ToString <> "" Then
                            StringImpressao &= " " & vbCrLf
                            StringImpressao &= Dir("Total Pendência: R$" & dtRec.Rows.Item(0).Item("Valor").ToString, 55) & vbCrLf

                        End If
                    End If
                End If

                Dim dt As DataTable

                dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade, Fantasia from Cliente where Codigo =" & dtPed.Rows.Item(0).Item("CodCli").ToString)

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


                If TipoNano = 5 Then
                    dt = CarregarDataTable("Select Total.Placa, Total.Modelo, Carro.Cor, Carro.Ano From Total left join Carro on Total.Placa=Carro.Placa Where Total.CodOrdem=" & parCodOrdem & " And Total.CodConfig=" & CodConfig)

                    If dt.Rows.Count > 0 Then
                        If dt.Rows.Item(0).Item("Placa").ToString.Trim <> "" Then
                            strImpressao &= " " & vbCrLf
                            strImpressao &= "Placa: " & dt.Rows.Item(0).Item("Placa").ToString & vbCrLf
                        End If
                        If dt.Rows.Item(0).Item("Modelo").ToString.Trim <> "" Then
                            strImpressao &= "Modelo: " & dt.Rows.Item(0).Item("Modelo").ToString & " - " & dt.Rows.Item(0).Item("Cor").ToString & vbCrLf
                        End If
                        If dt.Rows.Item(0).Item("Ano").ToString <> "" Then
                            strImpressao &= "Ano: " & dt.Rows.Item(0).Item("Ano").ToString & vbCrLf
                        End If
                    End If
                End If


                Dim bol2Via As Boolean = False
                If NomeEmpresa.Replace("Ã", "A").Trim.Contains("CAVALAO") = False Then
                    If ModeloCarne <> "0" Then
                        dt = CarregarDataTable("Select Codigo from ContaReceber where CodOrdem =" & parCodOrdem & " and CodConfig =" & dtPed.Rows.Item(0).Item("CodConfig").ToString)

                        If dt.Rows.Count > 0 Then

                            bol2Via = True

                            strImpressao &= " " & vbCrLf
                            strImpressao &= " " & vbCrLf

                            strImpressao &= Cent("Reconheco que pagarei a dívida acima", intTamEsp) & vbCrLf
                            strImpressao &= Cent("apresentada conforme Contrato assinado", intTamEsp) & vbCrLf
                            strImpressao &= Cent("em separado.", intTamEsp) & vbCrLf
                            strImpressao &= " " & vbCrLf
                            strImpressao &= Cent("_____________________________", intTamEsp) & vbCrLf

                        End If
                    End If
                End If


                strImpressao &= " " & vbCrLf

                If ObsPedidoVenda = True Then
                    If Not strObsPedido = "" Then
                        strImpressao &= "Observacoes do Pedido:" & vbCrLf
                        strImpressao &= strObsPedido & vbCrLf
                        strImpressao &= " " & vbCrLf
                    End If
                End If

                If DescricaoVenda <> "" Then
                    strImpressao &= DescricaoVenda & vbCrLf
                    strImpressao &= " " & vbCrLf
                End If

                strImpressao &= Cent("DOCUMENTO NÃO FISCAL", intTamEsp) & vbCrLf

                If NomeEmpresa.Replace("Ã", "A").Trim.Contains("CAVALAO") = True Then
                    strImpressao &= " " & vbCrLf
                    strImpressao &= " " & vbCrLf
                    strImpressao &= " " & vbCrLf
                    strImpressao &= "." & vbCrLf
                End If

                strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")

                If Impressora = "ARQUIVO" Then
                    If NomeEmpresa.Contains("CAVALAO") = True Then
                        clsImprimir.SendStringToPrinter(PortaImpressora, strImpressao)
                    Else
                        'ImprimiArquivo(strImpressao, PortaImpressora)
                        clsImprimir.SendStringToPrinter(PortaImpressora, strImpressao)
                        If TemGuilhotina = True Then
                            strImpressao = clsImprimir.Avanco() & vbCrLf
                            strImpressao &= clsImprimir.Corte()
                            clsImprimir.SendStringToPrinter(PortaImpressora, strImpressao)
                        End If

                        If TemGaveta = True Then
                       
                            If bolGaveta = True Then
                                strImpressao = clsImprimir.AbreGaveta() & vbCrLf
                                clsImprimir.SendStringToPrinter(PortaImpressora, strImpressao)
                            End If
                         
                        End If
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

                    'If bol2Via = True Then
                    '    iRetorno = FormataTX(strImpressao, 1, 0, 0, 0, 1)
                    '    If TemGuilhotina = True Then
                    '        iRetorno = AcionaGuilhotina(0)
                    '    End If
                    'End If
                    If Impressora.Contains("BEMATECH") = True Then
                        iRetorno = clsBematech.FechaPorta()

                    Else
                        Try
                            iRetorno = clsBematech.FechaPorta()

                        Catch ex As Exception

                        End Try
                    End If
                End If


            ElseIf Impressora = "EPSON" Then
                Dim strImpressao As String
                Dim strEstrela As String

                strEstrela = clsImprimir.Comp("************************************************")
                strTraco = clsImprimir.Comp("------------------------------------------------")


                strImpressao = strEstrela & vbCrLf

                strImpressao &= "<ce>" & NomeEmpresa.ToString.Trim & "</ce>" & vbCrLf
                strImpressao &= "<ce>" & EnderecoEmpresa.Trim & "</ce>" & vbCrLf
                strImpressao &= "<ce>" & TelefoneEmpresa & "</ce>" & vbCrLf


                strImpressao &= strEstrela & vbCrLf




                strImpressao &= "<ad>" & Format(dtPed.Rows.Item(0).Item("Data"), "dd/MM/yyyy") & " " & dtPed.Rows.Item(0).Item("Hora") & "</ad>" & vbCrLf
                strImpressao &= "<n>" & "Venda N: " & parCodOrdem & "</n>" & vbCrLf


                strImpressao &= "<n>" & "Codigo Descricao                    " & "</n>" & vbCrLf
                strImpressao &= "<n>" & Dir("UM   Qtd     Vl Unit R$", 37) & "</n>" & "<ad>" & "VL Total R$" & "</ad>" & vbCrLf
                strImpressao &= strTraco & vbCrLf

                'iRetorno = clsEpson.ImprimeTextoTag(strImpressao)

                Dim L As Integer
                Dim dblQtd As Double
                For L = 0 To dtPed.Rows.Count - 1
                    Dim strCod, strProd, strQtd, strUM As String
                    Dim dblUni, dblTot As Double

                    strCod = dtPed.Rows.Item(L).Item("CodProdInterno").ToString
                    strProd = dtPed.Rows.Item(L).Item("Produto").ToString
                    dblUni = dtPed.Rows.Item(L).Item("ValorUnitario").ToString
                    strQtd = dtPed.Rows.Item(L).Item("Qtd").ToString
                    dblTot = dtPed.Rows.Item(L).Item("ValorTotal").ToString
                    dblValDesTot = dtPed.Rows.Item(L).Item("ValDesc").ToString
                    strUM = dtPed.Rows.Item(L).Item("UM").ToString
                    If strUM.Trim = "" Then
                        strUM = "UN"
                    End If
                    dblQtd += dtPed.Rows.Item(L).Item("Qtd").ToString
                    strImpressao &= "<n>" & strCod & " " & strProd & "</n>" & vbCrLf
                    Dim str As String
                    str = "<n>" & Dir(strUM & "    " & strQtd & "  X  " & dblUni.ToString("####,##0.000"), 37) & "</n>" & "<ad>" & Esq(dblTot.ToString("####,##0.00"), 11) & "</ad>"
                    strImpressao &= str & vbCrLf
                Next


                Dim dblValor As Double
                dblValor = dtPed.Rows.Item(0).Item("Total").ToString
                strImpressao &= strTraco & vbCrLf


                strImpressao &= "<n>" & Esq("N de Itens..:    ", 38) & Esq(dblQtd, 10) & "</n>" & vbCrLf

                If dblValDesTot > 0 Then
                    strImpressao &= "<n>" & Esq("Desconto....: R$ ", 38) & Esq(dblValDesTot.ToString("0.00"), 10) & "</n>" & vbCrLf
                End If

                strImpressao &= "<n>" & Esq("Total.......: R$ ", 38) & Esq(dblValor.ToString("####,##0.00"), 10) & "</n>" & vbCrLf
                Dim P As Integer
                Dim dblTro As Double = 0
                dblTro = dtPed.Rows.Item(0).Item("Troco").ToString

                Dim bolTroco As Boolean = False

                Dim dtPag As DataTable = CarregarDataTable("SELECT Pagamento, Valor FROM Recebimento where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)
                If dtPag.Rows.Count > 0 Then

                    For P = 0 To dtPag.Rows.Count - 1
                        Dim strPag As String = dtPag.Rows.Item(P).Item("Pagamento").ToString
                        If dtPag.Rows.Item(P).Item("Valor").ToString <> "" Then
                            dblValor = dtPag.Rows.Item(P).Item("Valor").ToString
                        End If
                        If strPag = "DINHEIRO" Then
                            If bolTroco = False Then
                                If dblTro > 0 Then
                                    dblValor = dblValor + dblTro
                                    bolTroco = True
                                End If
                            End If
                        End If
                        Dim strComPonto As String = InserirPonto(strPag)
                        strImpressao &= "<n>" & Esq(strComPonto & "R$ ", 38) & Esq(dblValor.ToString("####,##0.00"), 10) & "</n>" & vbCrLf
                    Next
                End If

                strImpressao &= "<n>" & Esq("Troco......: R$ ", 38) & Esq(dblTro.ToString("####,##0.00"), 10) & "</n>" & vbCrLf


                strImpressao &= strTraco & vbCrLf


                If GerarComissao = True Then
                    Dim dtFunc As DataTable = CarregarDataTable("SELECT Nome FROM Funcionario left join Pedido on Funcionario.Codigo = Pedido.CodFunc where Pedido.CodOrdem = " & parCodOrdem & " and Pedido.CodConfig =" & CodConfig)
                    If dtFunc.Rows.Count > 0 Then
                        strImpressao &= "<n>" & Dir("Vend.: " & dtFunc.Rows.Item(0).Item("Nome").ToString, 48) & "</n>" & vbCrLf
                    End If

                End If
                Dim dtCaixa As DataTable = CarregarDataTable("SELECT Caixa FROM Caixa where Motivo like '%Venda Nº " & parCodOrdem & ",%' and CodConfig = " & CodConfig)
                If dtCaixa.Rows.Count > 0 Then
                    If dtCaixa.Rows.Item(0).Item("Caixa").ToString <> "" Then
                        strImpressao &= "<n>" & Dir("Oper.: " & dtCaixa.Rows.Item(0).Item("Caixa").ToString, 48) & "</n>" & vbCrLf
                    End If
                End If

                If NomeEmpresa.Replace("Ã", "A").Trim.Contains("CAVALAO") = False Then
                    Dim dtRec As DataTable = CarregarDataTable("Select Pagamento, Vencimento, ValorParcela from ContaReceber where CodOrdem =" & parCodOrdem & " and CodConfig =" & CodConfig)

                    If dtRec.Rows.Count > 0 Then

                        Dim dtVenc As Date
                        Dim dblPar As Double

                        strImpressao &= " " & vbCrLf

                        Dim R As Integer

                        For R = 0 To dtRec.Rows.Count - 1

                            If R = 0 Then
                                strImpressao &= dtRec.Rows.Item(R).Item("Pagamento").ToString & vbCrLf
                            End If

                            dtVenc = dtRec.Rows.Item(R).Item("Vencimento").ToString
                            dblPar = dtRec.Rows.Item(R).Item("ValorParcela").ToString
                            strImpressao &= "<n>" & dtVenc & "   R$ " & dblPar.ToString("0.00") & "</n>" & vbCrLf
                        Next
                    End If
                End If


                Dim dtFut As DataTable = CarregarDataTable("Select Pagamento, convert(Numeric(15,2),Total) as Total, Count(Codigo) as Qtd from Futuro " & _
"where CodOrdem =" & parCodOrdem & " and CodConfig =" & CodConfig & " group by Pagamento, convert(Numeric(15,2),Total)")

                If dtFut.Rows.Count > 0 Then

                    StringImpressao &= " " & vbCrLf

                    Dim R As Integer

                    For R = 0 To dtFut.Rows.Count - 1


                        StringImpressao &= "<n>" & Dir(dtFut.Rows.Item(R).Item("Pagamento").ToString, 55) & "</n>" & vbCrLf
                        StringImpressao &= "<n>" & Dir(dtFut.Rows.Item(R).Item("Qtd").ToString & " x " & dtFut.Rows.Item(R).Item("Total").ToString, 55) & "</n>" & vbCrLf
                        If R <> dtFut.Rows.Count - 1 Then
                            StringImpressao &= " " & vbCrLf
                        End If
                    Next
                Else
                    strImpressao &= " " & vbCrLf

                End If

                If TotalPendenciaImpressao = True Then
                    Dim dtRec As DataTable = CarregarDataTable("Select sum(convert(numeric(15,2),ValorParcela)) as Valor from ContaReceber where CodCli =" & dtPed.Rows.Item(0).Item("CodCli").ToString & " and CodConfig =" & CodConfig & " and RecebidoOk = 'False'")
                    If dtRec.Rows.Count > 0 Then
                        If dtRec.Rows.Item(0).Item("Valor").ToString <> "" Then
                            StringImpressao &= " " & vbCrLf
                            StringImpressao &= "<n>" & Dir("Total Pendência: R$" & dtRec.Rows.Item(0).Item("Valor").ToString, 55) & "</n>" & vbCrLf
                        End If
                    End If
                End If

                Dim dt As DataTable

                dt = CarregarDataTable("Select Nome, Endereco, Numero, Complemento, Bairro, Telefone, Cidade, Fantasia from Cliente where Codigo =" & dtPed.Rows.Item(0).Item("CodCli").ToString)

                If dt.Rows.Count > 0 Then
                    If dt.Rows.Item(0).Item("Nome").ToString.Trim <> "" And dt.Rows.Item(0).Item("Nome").ToString.Trim <> "CONSUMIDOR" Then
                        strImpressao &= "<n>" & dt.Rows.Item(0).Item("Nome").ToString & "</n>" & vbCrLf
                    End If
                    If dt.Rows.Item(0).Item("Fantasia").ToString.Trim <> "" And dt.Rows.Item(0).Item("Fantasia").ToString.Trim <> "CONSUMIDOR" Then
                        strImpressao &= "<n>" & dt.Rows.Item(0).Item("Fantasia").ToString & "</n>" & vbCrLf
                    End If
                    If dt.Rows.Item(0).Item("Endereco").ToString <> "" Then
                        strImpressao &= "<n>" & dt.Rows.Item(0).Item("Endereco").ToString & ", " & dt.Rows.Item(0).Item("Numero").ToString & " " & dt.Rows.Item(0).Item("Complemento").ToString & "</n>" & vbCrLf
                    End If

                    If dt.Rows.Item(0).Item("Bairro").ToString <> "" Then
                        strImpressao &= "<n>" & dt.Rows.Item(0).Item("Bairro").ToString & " - " & dt.Rows.Item(0).Item("Cidade").ToString & "</n>" & vbCrLf
                    End If

                    If dt.Rows.Item(0).Item("Telefone").ToString <> "" Then
                        strImpressao &= "<n>" & dt.Rows.Item(0).Item("Telefone").ToString & "</n>" & vbCrLf
                    End If

                End If

                Dim bol2Via As Boolean = False
                If NomeEmpresa.Replace("Ã", "A").Trim.Contains("CAVALAO") = False Then
                    If ModeloCarne <> "0" Then
                        dt = CarregarDataTable("Select Codigo from ContaReceber where CodOrdem =" & parCodOrdem & " and CodConfig =" & dtPed.Rows.Item(0).Item("CodConfig").ToString)

                        If dt.Rows.Count > 0 Then

                            bol2Via = True

                            strImpressao &= " " & vbCrLf
                            strImpressao &= " " & vbCrLf

                            strImpressao &= "<ce>" & "Reconheco que pagarei a dívida acima" & "</ce>" & vbCrLf
                            strImpressao &= "<ce>" & "apresentada conforme Contrato assinado" & "</ce>" & vbCrLf
                            strImpressao &= "<ce>" & "em separado." & "</ce>" & vbCrLf
                            strImpressao &= " " & vbCrLf
                            strImpressao &= "<ce>" & "_____________________________" & "</ce>" & vbCrLf

                        End If
                    End If
                End If


                strImpressao &= " " & vbCrLf

                If ObsPedidoVenda = True Then
                    If Not strObsPedido = "" Then
                        strImpressao &= "<n>" & "Observacoes do Pedido:" & "</n>" & vbCrLf
                        strImpressao &= "<n>" & strObsPedido & "</n>" & vbCrLf
                        strImpressao &= " " & vbCrLf
                    End If
                End If
                If DescricaoVenda <> "" Then
                    strImpressao &= "<n>" & DescricaoVenda & "</n>" & vbCrLf
                    strImpressao &= " " & vbCrLf
                End If

                strImpressao &= "<ce>" & "DOCUMENTO NÃO FISCAL" & "</ce>" & vbCrLf

                If NomeEmpresa.Replace("Ã", "A").Trim.Contains("CAVALAO") = True Then
                    strImpressao &= " " & vbCrLf
                    strImpressao &= " " & vbCrLf
                    strImpressao &= " " & vbCrLf
                    strImpressao &= "." & vbCrLf
                End If

                strImpressao = strImpressao.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("é", "e").Replace("è", "e").Replace("É", "E").Replace("È", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U")

                iRetorno = clsEpson.IniciaPorta(PortaImpressora)

                iRetorno = clsEpson.ImprimeTextoTag(strImpressao)
                If TemGuilhotina = True Then
                    iRetorno = clsEpson.AcionaGuilhotina(1)
                End If

                'If bol2Via = True Then
                '    iRetorno = FormataTX(strImpressao, 1, 0, 0, 0, 1)
                '    If TemGuilhotina = True Then
                '        iRetorno = AcionaGuilhotina(0)
                '    End If
                'End If

                iRetorno = clsEpson.FechaPorta()
            ElseIf Impressora.Contains("MATRICIAL") Then
                If NomeEmpresa.ToString.ToUpper.Contains("BAREX") = True Then
                    Dim intTamEsp As Integer
                    Dim strEstrela, strTraço As String

                    intTamEsp = 42
                    strEstrela = "*****************************************************************************"
                    'strTraço = "............................................................................." & vbCrLf

                    'iRetorno = IniciaPorta(PortaImpressora)

                    Dim strTracoMenor As String = "............................................................................." & vbCrLf
                    Dim dtFunc As DataTable = CarregarDataTable("SELECT Nome FROM Funcionario left join Pedido on Funcionario.Codigo = Pedido.CodFunc where Pedido.CodOrdem = " & parCodOrdem & " and Pedido.CodConfig =" & CodConfig)
                    Dim strFunc As String = ""

                    If dtFunc.Rows.Count > 0 Then
                        strFunc = dtFunc.Rows.Item(0).Item("Nome").ToString

                    End If


                    Dim strDt As String = Format(dtPed.Rows.Item(0).Item("Data"), "dd/MM/yyyy")
                    strDt = strDt.Substring(0, 10)
                    Dim strHora As String = dtPed.Rows(0).Item("Hora").ToString

                    If strHora.Length = 19 Then
                        strHora = strHora.Substring(10, 9)
                    End If

                    Dim dtClient As DataTable = CarregarDataTable("select nome,numero, fantasia, endereco, cidade, telefone, bairro from cliente left join total on cliente.codigo = total.codcli where total.codordem =" & parCodOrdem)
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


                    Dim strImpressao As String = Cent(NomeEmpresa.ToString.Trim, 77) & vbCrLf
                    strImpressao &= Cent(TelefoneEmpresa.Trim, 77) & vbCrLf
                    strImpressao &= Cent(EnderecoEmpresa.Trim, 77) & vbCrLf
                    strImpressao &= strTraço & strTraço & strTracoMenor & "." & vbCrLf '"......." & vbCrLf

                    strImpressao &= DirCorte("VENDEDOR: " & strFunc, 30) & DirCorte("VENDA: " & parCodOrdem, 26) & Dir("DATA:" & strDt & " " & strHora, 11) & vbCrLf
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

                    If dtPed.Rows.Count < 13 Then
                        For L = 0 To 13
                            If dtPed.Rows.Count - 1 >= L Then
                                Dim strCod, strProd, strUM, strFab, strObs, strCodProd As String
                                Dim strCodBarra As String = ""
                                Dim bolDevolvido As Boolean = dtPed.Rows.Item(L).Item("Devolvido")
                                dblUni = dtPed.Rows.Item(L).Item("ValorUnitario").ToString
                                Dim bolOk As Boolean = True
                                If bolDevolvido = True Then
                                    If dblUni > 0 Then
                                        bolOk = False
                                    End If
                                End If
                                If bolOk = True Then
                                    strCodProd = dtPed.Rows.Item(L).Item("CodProd").ToString
                                    strCod = dtPed.Rows.Item(L).Item("CodProdInterno").ToString
                                    strProd = dtPed.Rows.Item(L).Item("Produto").ToString

                                    dblQt = dtPed.Rows.Item(L).Item("Qtd").ToString
                                    dblTot = dtPed.Rows.Item(L).Item("ValorTotal").ToString
                                    dblValDesTot = dtPed.Rows.Item(L).Item("ValDesc").ToString
                                    strUM = dtPed.Rows.Item(L).Item("UM").ToString
                                    Dim dtProd As DataTable = CarregarDataTable("SELECT Setor, Obs, CodigoBarra FROM Produto where Codigo = " & strCodProd)

                                    If dtProd.Rows.Count > 0 Then
                                        strFab = dtProd.Rows.Item(0).Item("Setor").ToString
                                        strObs = dtProd.Rows.Item(0).Item("Obs").ToString
                                        strCodBarra = dtProd.Rows.Item(0).Item("CodigoBarra").ToString
                                        If strCodBarra = "" Then
                                            strCodBarra = " "
                                        End If
                                    End If

                                    If strUM.Trim = "" Then
                                        strUM = "UN"
                                    End If

                                    dblLiq = dblLiq + dblTot

                                    strImpressao &= DirCorte(strCod, 8) & DirCorte(strCodBarra, 11) & DirCorte("  " & strProd, 25) & Esq((dblQt.ToString("N3")), 7) & Esq(dblUni.ToString("C2"), 13) & Esq(dblTot.ToString("C2"), 13) & vbCrLf

                                End If
                            Else
                                strImpressao &= "." & vbCrLf
                            End If
                        Next

                    Else
                        For L = 0 To dtPed.Rows.Count - 1
                            Dim strCod, strProd, strUM, strFab, strObs, strCodProd, strCodBarra As String
                            Dim bolDevolvido As Boolean = dtPed.Rows.Item(L).Item("Devolvido")
                            dblUni = dtPed.Rows.Item(L).Item("ValorUnitario").ToString
                            Dim bolOk As Boolean = True
                            If bolDevolvido = True Then
                                If dblUni > 0 Then
                                    bolOk = False
                                End If
                            End If
                            If bolOk = True Then
                                strCodProd = dtPed.Rows.Item(L).Item("CodProd").ToString
                                strCod = dtPed.Rows.Item(L).Item("CodProdInterno").ToString
                                strProd = dtPed.Rows.Item(L).Item("Produto").ToString
                                dblQt = dtPed.Rows.Item(L).Item("Qtd").ToString
                                dblTot = dtPed.Rows.Item(L).Item("ValorTotal").ToString
                                dblValDesTot = dtPed.Rows.Item(L).Item("ValDesc").ToString
                                strUM = dtPed.Rows.Item(L).Item("UM").ToString
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

                                'strImpressao &= DirCorte(dblQt.ToString("N2"), 4) & DirCorte("  " & strProd, 30) & DirCorte("  " & strFab, 11) & DirCorte("   " & strCod, 13) & DirCorte("    " & strObs, 27) & Esq("     " & dblUni.ToString("C2"), 14) & Esq("      " & dblTot.ToString("C2"), 14) & vbCrLf


                                strImpressao &= DirCorte(dblQt.ToString("N2"), 4) & DirCorte("  " & strProd, 30) & DirCorte("  " & strFab, 11) & DirCorte("   " & strCod, 13) & DirCorte("    " & strObs, 27) & Esq("     " & dblUni.ToString("C2"), 14) & Esq("      " & dblTot.ToString("C2"), 14) & vbCrLf

                            End If

                        Next

                    End If

                    'If Me.grd1.RowCount < 13 Then
                    '    For L = 0 To 2
                    '        If Me.grd1.RowCount - 1 >= L Then
                    '            Dim strCod, strProd, strUM, strFab, strObs, strCodProd, strCodBarra As String
                    '            strCodProd = Me.grd1.GetRowCellDisplayText(L, Me.colCodProdAut)


                    '            strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodProd)
                    '            strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
                    '            dblUni = Me.grd1.GetRowCellDisplayText(L, Me.colUnitario)
                    '            dblQt = Me.grd1.GetRowCellDisplayText(L, Me.colQtde)
                    '            dblTot = Me.grd1.GetRowCellDisplayText(L, Me.colTotal)
                    '            strUM = Me.grd1.GetRowCellDisplayText(L, Me.colUM)
                    '            Dim dtProd As DataTable = CarregarDataTable("SELECT Setor, Obs, CodigoBarra FROM Produto where Codigo = " & strCodProd)

                    '            If dtProd.Rows.Count > 0 Then
                    '                strFab = dtProd.Rows.Item(0).Item("Setor").ToString
                    '                strObs = dtProd.Rows.Item(0).Item("Obs").ToString
                    '                strCodBarra = dtProd.Rows.Item(0).Item("CodigoBarra").ToString
                    '            End If

                    '            If strUM.Trim = "" Then
                    '                strUM = "UN"
                    '            End If

                    '            dblLiq = dblLiq + dblTot

                    '            'If NomeEmpresa.Contains("SKINA") Then
                    '            '    strImpressao &= DirCorte(dblQt.ToString("N2"), 4) & DirCorte("  " & strProd, 44) & DirCorte("  " & strFab, 11) & DirCorte("   " & strCod, 13) & DirCorte("    " & strObs, 27) & Esq("     " & dblUni.ToString("C2"), 14) & Esq("      " & dblTot.ToString("C2"), 14) & vbCrLf
                    '            'Else
                    '            strImpressao &= DirCorte(strCod, 5) & DirCorte(strCodBarra, 5) & DirCorte("  " & strProd, 22) & Esq((dblQt.ToString("N3")), 12) & Esq(dblUni.ToString("C2"), 16) & Esq(dblTot.ToString("C2"), 16) & vbCrLf
                    '            'End If

                    '        Else
                    '            strImpressao &= "." & vbCrLf
                    '        End If
                    '    Next

                    'Else
                    '    For L = 0 To Me.grd1.RowCount - 1
                    '        Dim strCod, strProd, strUM, strFab, strObs, strCodProd As String
                    '        strCodProd = Me.grd1.GetRowCellDisplayText(L, Me.colCodProdAut)


                    '        strCod = Me.grd1.GetRowCellDisplayText(L, Me.colCodProd)
                    '        strProd = Me.grd1.GetRowCellDisplayText(L, Me.colProduto)
                    '        dblUni = Me.grd1.GetRowCellDisplayText(L, Me.colUnitario)
                    '        dblQt = Me.grd1.GetRowCellDisplayText(L, Me.colQtde)
                    '        dblTot = Me.grd1.GetRowCellDisplayText(L, Me.colTotal)
                    '        strUM = Me.grd1.GetRowCellDisplayText(L, Me.colUM)
                    '        Dim dtProd As DataTable = CarregarDataTable("SELECT Setor, Obs FROM Produto where Codigo = " & strCodProd)

                    '        If dtProd.Rows.Count > 0 Then
                    '            strFab = dtProd.Rows.Item(0).Item("Setor").ToString
                    '            strObs = dtProd.Rows.Item(0).Item("Obs").ToString
                    '        End If

                    '        If strUM.Trim = "" Then
                    '            strUM = "UN"
                    '        End If

                    '        dblLiq = dblLiq + dblTot

                    '        strImpressao &= DirCorte(dblQt.ToString("N2"), 4) & DirCorte("  " & strProd, 30) & DirCorte("  " & strFab, 11) & DirCorte("   " & strCod, 13) & DirCorte("    " & strObs, 27) & Esq("     " & dblUni.ToString("C2"), 14) & Esq("      " & dblTot.ToString("C2"), 14) & vbCrLf
                    '    Next
                    'End If

                    If NomeEmpresa.ToString.ToUpper.Contains("BAREX") = True Then
                        strImpressao &= Esq("TOTAL: " & dblLiq.ToString("C2"), 77) & vbCrLf & vbCrLf
                        strImpressao &= vbCrLf & Cent(ObsPedido, 77) & vbCrLf
                        strImpressao = strImpressao & vbCrLf & vbCrLf & vbCrLf
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

                Else
                    Dim intTamEsp As Integer
                    Dim strEstrela, strTraço As String

                    intTamEsp = 42
                    strEstrela = "******************************************"
                    strTraço = ".........................................."

                    'iRetorno = IniciaPorta(PortaImpressora)

                    Dim strTracoMenor As String = "...................................."
                    Dim strCodFunc As String = dtPed.Rows.Item(0).Item("CodFunc").ToString
                    Dim strFunc As String = ""
                    If strCodFunc <> "" Then
                        Dim dtFunc As DataTable = CarregarDataTable("SELECT Nome FROM Funcionario where Codigo = " & strCodFunc)
                        If dtFunc.Rows.Count > 0 Then
                            strFunc = dtFunc.Rows.Item(0).Item("Nome").ToString
                        End If

                    End If
                    Dim strDt As String = dtPed.Rows(0).Item("Data").ToString
                    strDt = strDt.Substring(0, 10)
                    Dim strHora As String = dtPed.Rows(0).Item("Hora").ToString


                    'Dim dtClient As DataTable = CarregarDataTable("select nome,numero, fantasia, endereco, cidade, telefone, bairro from cliente left join total on cliente.codigo = total.codcli where total.codordem =" & intCodCli)
                    'Dim strNome, strFant, strEnd, strCid, strTel, strBairro, strNum As String
                    'strNome = dtClient.Rows(0).Item("nome").ToString
                    'strFant = dtClient.Rows(0).Item("fantasia").ToString
                    'strEnd = dtClient.Rows(0).Item("endereco").ToString
                    'strCid = dtClient.Rows(0).Item("cidade").ToString
                    'strTel = dtClient.Rows(0).Item("telefone").ToString
                    'strBairro = dtClient.Rows(0).Item("bairro").ToString
                    'strNum = dtClient.Rows(0).Item("numero").ToString


                    Dim dtClient As DataTable = CarregarDataTable("select nome,numero, fantasia, endereco, cidade, telefone, bairro from cliente left join total on cliente.codigo = total.codcli where total.codordem =" & parCodOrdem)
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

                    strImpressao &= DirCorte("VENDEDOR: " & strFunc, 40) & DirCorte("DATA: " & strDt & " COD.PEDIDO: " & parCodOrdem, 49) & Dir("HORA: " & strHora, 11) & vbCrLf
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
                    If dtPed.Rows.Count < 13 Then
                        For L = 0 To 12
                            If dtPed.Rows.Count - 1 >= L Then
                                Dim strCod, strProd, strUM, strFab, strObs, strCodProd As String
                                Dim bolDevolvido As Boolean = dtPed.Rows.Item(L).Item("Devolvido")
                                dblUni = dtPed.Rows.Item(L).Item("ValorUnitario").ToString
                                Dim bolOk As Boolean = True
                                If bolDevolvido = True Then
                                    If dblUni > 0 Then
                                        bolOk = False
                                    End If
                                End If
                                If bolOk = True Then
                                    strCodProd = dtPed.Rows.Item(L).Item("CodProd").ToString
                                    strCod = dtPed.Rows.Item(L).Item("CodProdInterno").ToString
                                    strProd = dtPed.Rows.Item(L).Item("Produto").ToString

                                    dblQt = dtPed.Rows.Item(L).Item("Qtd").ToString
                                    dblTot = dtPed.Rows.Item(L).Item("ValorTotal").ToString
                                    dblValDesTot = dtPed.Rows.Item(L).Item("ValDesc").ToString
                                    strUM = dtPed.Rows.Item(L).Item("UM").ToString
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
                                End If
                            Else
                                strImpressao &= "." & vbCrLf
                            End If
                        Next

                    Else
                        For L = 0 To dtPed.Rows.Count - 1
                            Dim strCod, strProd, strUM, strFab, strObs, strCodProd As String
                            Dim bolDevolvido As Boolean = dtPed.Rows.Item(L).Item("Devolvido")
                            dblUni = dtPed.Rows.Item(L).Item("ValorUnitario").ToString
                            Dim bolOk As Boolean = True
                            If bolDevolvido = True Then
                                If dblUni > 0 Then
                                    bolOk = False
                                End If
                            End If
                            If bolOk = True Then
                                strCodProd = dtPed.Rows.Item(L).Item("CodProd").ToString
                                strCod = dtPed.Rows.Item(L).Item("CodProdInterno").ToString
                                strProd = dtPed.Rows.Item(L).Item("Produto").ToString
                                dblQt = dtPed.Rows.Item(L).Item("Qtd").ToString
                                dblTot = dtPed.Rows.Item(L).Item("ValorTotal").ToString
                                dblValDesTot = dtPed.Rows.Item(L).Item("ValDesc").ToString
                                strUM = dtPed.Rows.Item(L).Item("UM").ToString
                                Dim dtProd As DataTable = CarregarDataTable("SELECT Setor, Obs FROM Produto where Codigo = " & strCodProd)

                                If dtProd.Rows.Count > 0 Then
                                    strFab = dtProd.Rows.Item(0).Item("Setor").ToString
                                    strObs = dtProd.Rows.Item(0).Item("Obs").ToString
                                End If

                                If strUM.Trim = "" Then
                                    strUM = "UN"
                                End If

                                dblLiq = dblLiq + dblTot

                                'strImpressao &= DirCorte(dblQt.ToString("N2"), 4) & DirCorte("  " & strProd, 30) & DirCorte("  " & strFab, 11) & DirCorte("   " & strCod, 13) & DirCorte("    " & strObs, 27) & Esq("     " & dblUni.ToString("C2"), 14) & Esq("      " & dblTot.ToString("C2"), 14) & vbCrLf


                                If NomeEmpresa.Contains("SKINA") Then
                                    strImpressao &= DirCorte(dblQt.ToString("N2"), 4) & DirCorte("  " & strProd, 44) & DirCorte("  " & strFab, 11) & DirCorte("   " & strCod, 13) & DirCorte("    " & strObs, 27) & Esq("     " & dblUni.ToString("C2"), 14) & Esq("      " & dblTot.ToString("C2"), 14) & vbCrLf
                                Else
                                    strImpressao &= DirCorte(strCod, 11) & DirCorte("  " & strProd, 72) & Esq((dblQt.ToString("N3")), 12) & Esq(dblUni.ToString("C2"), 16) & Esq(dblTot.ToString("C2"), 16) & vbCrLf
                                End If
                            End If

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

                    iRetorno = clsBematech.FechaPorta()
                End If





            Else


                ImprimirVendaNormal(parCodOrdem, CodConfig)


            End If
        End If
        If bolGaveta = True Then
            AbreGaveta()
        End If
       
    End Sub


    Private Sub btnVendedor_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVendedor.ItemClick
        InserirVendedor()
    End Sub

    'corrigir no Commerce sql (O CONTÉUDO DO btnImprmir INTEIRO)
    '##################################################################################################################

    Private Sub btnImprimir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImprimir.ItemClick
    

        frmImpVenda.txtCodOrdem.Text = ""
        frmImpVenda.ShowDialog()

        If frmImpVenda.txtCodOrdem.Text.Trim <> "" Then
            Dim bolGaveta As Boolean = True
            If BloquearAbreGaveta = True Then
                MsgBox("Digite a senha de um usuário com nível de ADMINISTRADOR para abrir a gaveta!", MsgBoxStyle.Information)
                Dim frm As New frmSenhaExcluir
                frm.Tag = "DESCONTO"
                frm.ShowDialog()
                If bolSenhaOK = False Then
                    bolGaveta = False
                End If
            End If

            Imprimir(frmImpVenda.txtCodOrdem.Text.Trim, bolGaveta)
            If SegViaRecibo = True Then
                If MsgBox("Deseja imprimir a 2ª via?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Imprimir(frmImpVenda.txtCodOrdem.Text.Trim, bolGaveta)
                End If
            End If
        End If

    End Sub

    Dim bolJaPassouDesc As Boolean = False
    Private Sub txtPerDesc_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPerDesc.Leave
        If txtPerDesc.Text <> "" Then
            If Nivel = "USUÁRIO" Then
                If DescontoMaximo <> "" Then
                    If Me.lblDesc.Text = "Desc. %" Then
                        If CDbl(txtPerDesc.Text) > CDbl(DescontoMaximo) Then
                            If bolJaPassouDesc = True Then bolJaPassouDesc = False : Exit Sub
                            bolJaPassouDesc = True
                            MsgBox("Desconto é maior do que o permitido, digite a senha de um usuário com nível de ADMINISTRADOR!", MsgBoxStyle.Information)
                            If SenhaEstaOK() = False Then
                                MsgBox("Desconto maior que o permitido!", MsgBoxStyle.Information)
                                intCont = 0
                                Me.txtPerDesc.ResetText()
                                bolJaPassouDesc = False
                            End If
                        End If
                    End If
                End If
            End If
            
        End If
        bolQtdEnter = False
        Me.txtCodPro.Focus()

    End Sub

    Private Sub btnGaveta_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGaveta.ItemClick
        If BloquearAbreGaveta = True Then
            MsgBox("Digite a senha de um usuário com nível de ADMINISTRADOR para abrir a gaveta!", MsgBoxStyle.Information)
            Dim frm As New frmSenhaExcluir
            frm.Tag = "DESCONTO"
            frm.ShowDialog()
            If bolSenhaOK = False Then
                Exit Sub
            End If
        End If
        clsFuncoes.AbreGaveta()
    End Sub

    Private Sub btnPedido_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPedido.ItemClick
        frmPedido1.ShowDialog()
        Calcular()
    End Sub

    Private Sub txtCPF_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCPF.GotFocus

        If Me.txtCPF.Text.Trim = "000.000.000-00" Then
            If Me.rdgDoc.SelectedIndex = -1 Then
                Me.rdgDoc.SelectedIndex = 0
            End If
        End If

    End Sub

    Private Sub txtCPF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCPF.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
        FormatarDocumento(Me.txtCPF, strCpfCnpj)
    End Sub

    Private Sub txtCPF_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCPF.Leave

        Me.rdgDoc.SelectedIndex = -1

        If Me.txtCPF.Text.Trim = "" Then
            'CodigoDoCliente = 1
            'TrazCliente()
            Exit Sub
        End If

        If ValidaCPF(Me.txtCPF.Text.Trim) = False Then
            CodigoDoCliente = 1
            TrazCliente()
            Exit Sub
        End If

        ClientePorCPF()

    End Sub

    Private Sub ClientePorCPF()
        Dim dtCPF As DataTable = CarregarDataTable("Select Codigo From Cliente where CPF ='" & Me.txtCPF.Text.Trim & "'")

        If dtCPF.Rows.Count > 0 Then
            CodigoDoCliente = dtCPF.Rows.Item(0).Item("Codigo")
            TrazCliente()

        Else
            If CpfNaNota = True Then
                Me.chkNFP.Checked = True
            Else
                MsgBox("Cliente não cadastrado no sistema!", MsgBoxStyle.Information)
                CodigoDoCliente = 1
                TrazCliente()
            End If
            'If PafEcfNano = True Or SATFiscal = True Then
            'If PafEcfNano = False Then
            '    Atualizar("Update Cliente set CPF ='" & Me.txtCPF.Text.Trim & "' where Nome ='CUPOM FISCAL'")
            '    Dim dtCPF2 As DataTable = CarregarDataTable("Select Codigo From Cliente where CPF ='" & Me.txtCPF.Text.Trim & "'")

            '    If dtCPF2.Rows.Count > 0 Then
            '        CodigoDoCliente = dtCPF2.Rows.Item(0).Item("Codigo")
            '        TrazCliente()
            '    End If
            '    ArqCliente("UNICO", False, CodigoDoCliente)
            'Else


            'End If

            'Else
            ' MsgBox("Cliente não cadastrado no sistema!", MsgBoxStyle.Information)
            'CodigoDoCliente = 1
            ' TrazCliente()
            'End If

        End If
    End Sub

    Private Sub rdgDoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgDoc.SelectedIndexChanged
        Select Case Me.rdgDoc.SelectedIndex
            Case 0
                strCpfCnpj = "Cpf"
                Me.txtCPF.ResetText()
                Me.txtCPF.Focus()

            Case 1
                strCpfCnpj = "Cnpj"
                Me.txtCPF.ResetText()
                Me.txtCPF.Focus()
        End Select

    End Sub

    Private Sub btnRelVend_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelVend.ItemClick
        intCodOrdemVenda = 0
        intCodConfigVenda = 0

        frmConVenda.ShowDialog()

        If intCodOrdemVenda = 0 Then Exit Sub

        ImprimirVendaNormal(intCodOrdemVenda, intCodConfigVenda)
    End Sub

    Private Sub btnDav_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDav.ItemClick
        frmDav.Tag = "Fatura"
        frmDav.ShowDialog()
    End Sub

    Private Sub rdgDesc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgDesc.SelectedIndexChanged
        txtPorDesc.Text = "0,00"
        Me.txtValDesc.Text = "0,00"
        DescontoComValor()
    End Sub


    Private Sub btnMecanico_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMecanico.ItemClick
        InserirMecanico()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage



        Dim LinhasPorPagina As Single = 0
        Dim PosicaoDaLinha As Single = 0
        Dim LinhaAtual As Integer = 0

        'Variaveis das margens

        Dim MargemEsquerda As Single = 0
        Dim MargemDireita As Single = 0

        'Variaveis das fontes

        Dim FonteNegrito As Font
        Dim FonteNormal As Font


        'define efeitos em fontes

        FonteNegrito = New Font("Lucida Console", 8, FontStyle.Bold)

        FonteNormal = New Font("Lucida Console", 8)

        LinhaAtual = 0

        'Imagem

        'e.Graphics.DrawImage(Image.FromFile("C:\teste\" & "maco10.gif"), 100, 68)

        LinhasPorPagina = CInt(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9)


        'inicia a impressao

        PosicaoDaLinha = (LinhaAtual * FonteNegrito.GetHeight(e.Graphics))
        e.Graphics.DrawString(Cent(strCabecalho, 41), FonteNegrito, Brushes.Black, MargemEsquerda, PosicaoDaLinha, New StringFormat())
        LinhaAtual += 1

        PosicaoDaLinha = (LinhaAtual * FonteNormal.GetHeight(e.Graphics))
        e.Graphics.DrawString(strMeioCupom, FonteNormal, Brushes.Black, MargemEsquerda, PosicaoDaLinha, New StringFormat())
        LinhaAtual += 29

        PosicaoDaLinha = (LinhaAtual * FonteNegrito.GetHeight(e.Graphics))
        e.Graphics.DrawString(strTotalCupom, FonteNegrito, Brushes.Black, MargemEsquerda, PosicaoDaLinha, New StringFormat())
        LinhaAtual += 1

        PosicaoDaLinha = (LinhaAtual * FonteNormal.GetHeight(e.Graphics))
        e.Graphics.DrawString(strFimCupom, FonteNormal, Brushes.Black, MargemEsquerda, PosicaoDaLinha, New StringFormat())
        LinhaAtual += 29


        If (LinhaAtual > LinhasPorPagina) Then

            e.HasMorePages = True

        Else

            e.HasMorePages = False

        End If

    End Sub

    Private Sub btnF10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF10.Click
        F10()
    End Sub

    Private Sub btnF11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF11.Click
        F11(False)
    End Sub

    Private Sub btnF12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF12.Click
        F12()
    End Sub

    Private Sub btnF8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF8.Click
        F8(True)
    End Sub

    Private Sub picLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picLogo.Click
        intCont = 0
        CarregarImagem(intCodCliente)

    End Sub

    Private Sub grd1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grd1.FocusedRowChanged
        If Me.grd1.FocusedRowHandle < 0 Then
            Me.picLogo.Image = LogoTipo
        End If
        Dim strCodProd As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodProdAut)
        CarregarImagemProduto(strCodProd)
        intCont = 0
        'Me.txtProd.ResetText()
        'Me.txtPerDesc.ResetText()
        'Me.txtValor.ResetText()
        intContFoto = 0
        bolFoto = False
    End Sub

    Private Sub txtValor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtValor.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtValor.Properties.ReadOnly = False Then
                If Me.txtCodPro.Text = "1" Then
                    If Me.txtValor.Text = "" Then
                        MessageBox.Show("Digite o valor do produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Me.txtValor.Properties.ReadOnly = True
                        Me.txtCodPro.Focus()
                    Else
                        InserirProdEnter(False, dtProdutoEnter, False)

                    End If

                    Me.txtQtd.Focus()
                    Me.txtCodPro.Focus()

                ElseIf bolAltPreco = True Then


                    If Me.txtValor.Text = "" Then
                        MessageBox.Show("Digite o valor do produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Me.txtValor.Properties.ReadOnly = True
                        Me.txtCodPro.Focus()
                    Else
                        If Me.txtCodPro.Text = "" Then
                            MessageBox.Show("Digite o código do produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Me.txtCodPro.Focus()
                        Else
                            InserirProdEnter(False, dtProdutoEnter, False)

                        End If
                        
                    End If

                    Me.txtQtd.Focus()
                    Me.txtCodPro.Focus()
                End If
            End If

        End If

    End Sub

    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub

    Private Sub lblEraSystems_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles lblEraSystems.ItemClick
        System.Diagnostics.Process.Start("http://www.erasystems.com.br")
    End Sub


    Private Sub btnTipoDesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTipoDesc.Click
        TipoDesc()
    End Sub
    Private Sub TipoDesc()
        Me.txtPerDesc.Focus()
        If Me.btnTipoDesc.Text = "%" Then
            Me.btnTipoDesc.Text = "R$"
            Me.btnTipoDesc.ToolTip = "Clique para alterar o desconto para Valor R$"
            Me.lblDesc.Text = "Desc. %"
        Else
            Me.btnTipoDesc.Text = "%"
            Me.btnTipoDesc.ToolTip = "Clique para alterar o desconto para Porcentagem %"
            Me.lblDesc.Text = "Desc. R$"
        End If
    End Sub
    Private Sub frmVenda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = "$" Then
            Me.btnTipoDesc.Text = "$"
            TipoDesc()
            Timer2.Start()
        End If

        If e.KeyChar = "%" Then
            Me.btnTipoDesc.Text = "%"
            TipoDesc()
            Timer2.Start()
        End If

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Me.txtCodPro.Text = "$" Or Me.txtCodPro.Text = "%" Or Me.txtCodPro.Text = " " Then
            Me.txtCodPro.ResetText()
        End If
        Timer2.Stop()
    End Sub

    Private Sub txtPerDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPerDesc.KeyPress
        If e.KeyChar = "-" Then
            e.Handled = False
        End If
    End Sub

    Private Sub btnConPreco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConPreco.Click
        ConsultaPreco()
    End Sub

    Private Sub ConsultaPreco()
        bolConsultaProduto = False
        If bolConsultaPreco = True Then
            bolConsultaPreco = False
            Me.txtProd.Properties.AppearanceReadOnly.BackColor = Color.RoyalBlue
            Me.txtValor.Properties.AppearanceReadOnly.BackColor = Color.RoyalBlue
        Else
            bolConsultaPreco = True
            Me.txtProd.Text = "INFORME O CÓDIGO DO PRODUTO PARA FAZER A CONSULTA"
            Me.txtProd.Properties.AppearanceReadOnly.BackColor = Color.DarkOrange
            Me.txtValor.Properties.AppearanceReadOnly.BackColor = Color.DarkOrange
        End If
    End Sub


    Dim bolConsultaProduto As Boolean = False
    Private Sub ConsultaProduto()
        bolConsultaPreco = False
        If bolConsultaProduto = True Then
            bolConsultaProduto = False
            Me.txtProd.Properties.AppearanceReadOnly.BackColor = Color.RoyalBlue
            Me.txtValor.Properties.AppearanceReadOnly.BackColor = Color.RoyalBlue
        Else
            bolConsultaProduto = True
            Me.txtProd.Text = "DIGITE SUA BUSCA"
            Me.txtProd.Properties.AppearanceReadOnly.BackColor = Color.DarkGreen
            Me.txtValor.Properties.AppearanceReadOnly.BackColor = Color.DarkGreen
        End If
    End Sub

    Private Sub txtCodPro_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPro.Leave
        bolQtdEnter = False
    End Sub

    Private Sub rdgTipoProd_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdgTipoProd.SelectedIndexChanged
        Me.txtCodPro.Focus()
    End Sub

    Private Sub txtValorFrete_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorFrete.Leave
        If Me.txtValorFrete.Text = "" Then Exit Sub

        Calcular()
        If TipoDesconto = "TOTAL" Then
            DescontoComPorcentagem(False)

        End If
        EntradaPedido()
    End Sub

    Private Sub AtualizarTabelaPreco()
        If TabelaPrecoPorItem = True Then Exit Sub

        If Me.lblTabela.Caption <> "PADRÃO" Then
            Dim I As Integer
            Dim dbValor As Double

            For I = 0 To Me.grd1.RowCount - 1
                Dim dt As DataTable = CarregarDataTable("Select Codigo From Grupo Where Nome='" & Me.lblTabela.Caption & "'")
                Dim Codigo As Integer = dt.Rows.Item(0).Item("Codigo").ToString

                Dim CodProd As Integer = Me.grd1.GetRowCellDisplayText(I, Me.colCodProd)
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

                Me.grd1.SetRowCellValue(I, Me.colUnitario, CampoValor(dbValor))
                Me.grd1.SetRowCellValue(I, Me.colValorSemDesconto, CampoValor(dbValor))
                Me.grd1.SetRowCellValue(I, Me.colTabelaPreco, Me.lblTabela.Caption)

            Next

            If Me.txtRec.Text.Trim <> "" Then
                CancelarPagamento(False)
                EntradaPedido()
            End If
            If strDescontoCliente = "" Then
                Me.txtPerDesc.ResetText()
            Else
                Me.txtPerDesc.Text = strDescontoCliente
            End If
            Calcular()
            Me.txtCodPro.Focus()
        Else
            Dim I As Integer
            Dim dbValor As Double

            For I = 0 To Me.grd1.RowCount - 1
                Dim CodProd As Integer = Me.grd1.GetRowCellDisplayText(I, Me.colCodProd)
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
                Me.grd1.SetRowCellValue(I, Me.colUnitario, CampoValor(dbValor))
                Me.grd1.SetRowCellValue(I, Me.colValorSemDesconto, CampoValor(dbValor))
                Me.grd1.SetRowCellValue(I, Me.colTabelaPreco, Me.lblTabela.Caption)

                'End If
            Next
            If Me.txtRec.Text.Trim <> "" Then
                CancelarPagamento(False)
                EntradaPedido()
            End If
            If strDescontoCliente = "" Then
                Me.txtPerDesc.ResetText()
            Else
                Me.txtPerDesc.Text = strDescontoCliente
            End If
            Calcular()
            Me.txtCodPro.Focus()
            Me.txtCodPro.Focus()
        End If
    End Sub
End Class