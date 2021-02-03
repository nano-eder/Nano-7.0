Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Xml
Imports System.Diagnostics
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Gallery
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils
Imports Nano.clsFuncoes
Imports Nano.clsGerarArqs
Imports JRO
Imports Nano.clsGerarArqsNfe
Imports System.IO.Compression
Imports System.Globalization
Imports DevExpress.XtraCharts
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Forms
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Persistent
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraScheduler.Localization
Imports System.Threading

Imports System.IO.Packaging
Imports System.Net.mail
Imports System.Net.Mime

Public Class MDI
    Dim frm As Form
    Dim intCont As Integer
    Dim intContControle As Integer
    Dim bolLeave As Boolean = False
    Dim bolTrocarUser As Boolean = False
    Dim bolTrocarUsuario As Boolean = False

    Dim strCodOrdemAgenda As Integer

    Dim bolDigitaCNPJ As Boolean = False

    Dim intType As Integer
    Dim strStartDate As String
    Dim strEndDate As String
    Dim bolAllDay As Boolean
    Dim strSubject As String
    Dim strLocation As String
    Dim strDescription As String
    Dim intStatus As Integer
    Dim intLabel As Integer
    Dim bolConta As Boolean
    Dim intContAgenda As Integer
    Dim strRemider As String
    Dim bolAlerte As Boolean
    Dim frmReminder As DevExpress.XtraScheduler.Forms.RemindersForm
    Private mThread As Thread
    Dim intNumSerie1 As Integer
    Dim intNumSerie2 As Integer
    Dim bolBloqueioAnalyzer As Boolean = False
    Dim bolMDIPedPendente As Boolean = False
    Dim intMDIPedPendente As Integer
    Dim strAviso As String = ""
    Dim bolBloqueioUsuario As Boolean = False
    Dim intEraCodFunc As Integer
    Dim bolRepresentanteOK As Boolean = False
    Dim strRepresentante As String = "CANAL ERA SYSTEMS"
    Dim strEmailRepresentante As String = "contato@erasystems.com.br"

    Private mThreadNfe As Thread
    Private mThreadSAT As Thread
    Private mThreadConsultoria As Thread
    Private Sub btnCliente_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCliente.ItemClick
        If PedidoAberto = True Then MsgBox("Para cadastrar Clientes é necessário fechar a janela de Pedido!", MsgBoxStyle.Exclamation) : Exit Sub
        frmCadCliente.Show()
    End Sub

    Private Sub btnFornecedor_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFornecedor.ItemClick
        frmCadFornecedor.Tag = "Fornecedor"
        frmCadFornecedor.Show()
    End Sub

    Private Sub btnReceber_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReceber.ItemClick
        frmReceber.Show()
    End Sub

    Private Sub btnPagar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPagar.ItemClick
        frmPagar.Show()
    End Sub

    Private Sub btnConCtRecT_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConCtRecT.ItemClick
        Dim frm As New frmReceber
        frm.Tag = "RECEBIDA"
        frm.btnSel.Visible = False
        frm.Show()
    End Sub

    Private Sub btnPagas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPagas.ItemClick
        Dim frm As New frmPagar
        frm.Tag = "PAGAS"
        frm.btnSel.Visible = False
        frm.Show()
    End Sub

    Private Sub btnTotais_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTotais.ItemClick
        frmConPedido.Show()
    End Sub
   
    Private Sub MDI_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'frmLogin.Close()
        If bolTrocarUser = True Then
            TrocaDeUsuario = True
            bolTrocarUser = False
        End If

    End Sub

    Private Sub MDI_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If SistemaBloqueado = True Then Exit Sub

        'If bolTrocarUser = False Then
        If MsgBox("Deseja realmente sair do sistema?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Dim I As Integer
            For I = 0 To My.Application.OpenForms.Count - 1
                If I = My.Application.OpenForms.Count Then Exit For
                My.Application.OpenForms.Item(I).Close()
                If I > 0 Then I = I - 1

            Next
        Else
            e.Cancel = True
        End If
        'Else
        'If MsgBox("Deseja realmente trocar de usuário?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
        '    'Dim I As Integer
        '    'For I = 0 To My.Application.OpenForms.Count - 1
        '    '    If I = My.Application.OpenForms.Count Then Exit For
        '    '    My.Application.OpenForms.Item(I).Close()
        '    '    If I > 0 Then I = I - 1

        '    'Next
        '    Dim I As Integer
        '    'For I = 0 To My.Application.OpenForms.Count - 1
        '    '    If I = My.Application.OpenForms.Count Then Exit For
        '    '    My.Application.OpenForms.Item(I).Close()
        '    '    If I > 0 Then I = I - 1

        '    'Next

        '    Dim intForm As Integer = My.Application.OpenForms.Count
        '    For I = 0 To My.Application.OpenForms.Count - 1

        '        Dim strNome As String = My.Application.OpenForms.Item(intForm - 1).Name
        '        If strNome <> "frmLogin" And strNome <> "MDI" Then
        '            If I = My.Application.OpenForms.Count Then Exit For

        '            My.Application.OpenForms.Item(intForm - 1).Close()
        '        End If
        '        intForm = intForm - 1
        '    Next
        '    'bolTrocarUsuario = True
        'Else
        '    bolTrocarUser = False
        '    e.Cancel = True
        'End If


        ' End If

    End Sub

    Private Sub MDI_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "64")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If

        If e.KeyCode = Keys.F5 Then
            Try
                If Me.NavBarControl3.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded Then
                    AtualizarGridPedido()
                Else
                    IniciaThread()
                    intContAgenda = 0
                End If
              
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub MDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CarregaConfiguracoes()

        'Dim strCpfCnpj As String = ""
        'If CNPJEmpresa.Length = 14 Then
        '    strCpfCnpj = AddPonto(CNPJEmpresa, "J")
        'Else
        '    strCpfCnpj = AddPonto(CNPJEmpresa, "F")
        'End If

        'Dim dt As DataTable = CarregarDataTableMySQL("SELECT ContaReceber.Id FROM ContaReceber left join Cliente " & _
        '"on ContaReceber.CodCli = Cliente.CodigoNano where Cliente.CPF = '" & strCpfCnpj & "' and Vencimento < CURDATE()")

        'If dt.Rows.Count > 0 Then
        '    If dt.Rows.Item(0).Item("Id").ToString <> "" Then
        '        If MsgBox("Você possui débitos com a Era Systems!" & vbCrLf & "Deseja imprimir o boleto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '            frmBoleto.strBoletoCpfCnpj = strCpfCnpj
        '            frmBoleto.ShowDialog()
        '        End If
        '    End If
        'End If
        If bolBloqueioAnalyzer = False Then

            Me.scData.Start = Date.Today


            IniciaThread()

            Me.scData.Start = My.Computer.Clock.LocalTime

            If Nivel = "USUÁRIO" Then
                Me.PanelControl4.Visible = False
            End If
        Else
            Me.pnlAnalitico.Visible = False
            Me.pnlPedido.Visible = False
        End If

        CarregarStatusPedido()

        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)
        
        Me.memHistorico.Text = HistoricoVersao
    End Sub

    Private Sub CarregarStatusPedido()
        Try
            cboStatus.Items.Clear()
            Dim dtSta As DataTable = CarregarDataTable("Select Nome From Grupo Where Tipo ='P' Group By Nome")
            If dtSta.Rows.Count > 0 Then
                cboStatus.Items.Add("")
                For I As Integer = 0 To dtSta.Rows.Count - 1
                    cboStatus.Items.Add(dtSta.Rows.Item(I).Item("Nome").ToString.Trim)
                Next
            End If
            bolStatusPedido = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CarregaConfiguracoes()

        If TesteConexao() = False Then Exit Sub

        Ribbon.Manager.UseF10KeyForMenu = False

        If Login = "ADM" And Senha = "SPFC" Then

            Me.btnConfig.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            'Me.btnGerArqsCF.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnConfigNfe.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.rpSistema.Visible = True
            Me.btnConfigECF.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnConfigTEF.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        ElseIf Login = "ADM" And Senha = "ed3223" Then
            Me.btnConfig.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            ' Me.btnGerArqsCF.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnConfigNfe.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.rpSistema.Visible = True
            Me.btnConfigECF.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnConfigTEF.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If

        Me.defaultLookAndFeel1.LookAndFeel.SkinName = SkinDoUsuario
        Me.lblVersao.Caption = "Versão " & VersaoDoSistemaProjeto
        Me.lblLoja.Caption = DescricaoEmpresa
        Me.lblPC.Caption = "-  Nome do Computador: " & My.Computer.Name.Trim

        Dim dtConf As DataTable = CarregarDataTable("Select * from Config")
        If dtConf.Rows.Count > 0 Then
            QtdeLoja = dtConf.Rows.Count
        End If

        dtConf = CarregarDataTable("Select * from Config where Codigo =" & CodConfig)
        If dtConf.Rows.Count > 0 Then
            NomeEmpresa = dtConf.Rows.Item(0).Item("Empresa").ToString

            TelefoneEmpresa = dtConf.Rows.Item(0).Item("Telefone").ToString
            EnderecoEmpresa = dtConf.Rows.Item(0).Item("Endereco").ToString
            CNPJEmpresa = dtConf.Rows.Item(0).Item("CNPJ").ToString

            If CNPJEmpresa.Trim = "00000000000" Then
                bolDigitaCNPJ = True
            End If
            UFEmpresa = dtConf.Rows.Item(0).Item("UF")
            TemImpressora = dtConf.Rows.Item(0).Item("TemImpressora")
            CidadeEmpresa = dtConf.Rows.Item(0).Item("Cidade").ToString
            ModeloCarne = dtConf.Rows.Item(0).Item("ModeloCarne").ToString
            TipoNano = dtConf.Rows.Item(0).Item("TipoNano").ToString
            PastaSincrinizacao = dtConf.Rows.Item(0).Item("PastaSinc").ToString
            GerarComissao = dtConf.Rows.Item(0).Item("GerarComissao")
            ValidarCPF = dtConf.Rows.Item(0).Item("ValidarCPF")
            TemGuilhotina = dtConf.Rows.Item(0).Item("TemGuilhotina")
            NomePCImpressora = dtConf.Rows.Item(0).Item("NomePCImpressora").ToString
            PermiteEstoqueZerado = dtConf.Rows.Item(0).Item("EstoqueZerado")
            BloquearParcelas = dtConf.Rows.Item(0).Item("AlterarParcelas")
            CarregarLogo(dtConf.Rows.Item(0).Item("Logo"))
            Impressora = dtConf.Rows.Item(0).Item("Impressora").ToString
            PortaImpressora = dtConf.Rows.Item(0).Item("Porta").ToString
            TemGaveta = dtConf.Rows.Item(0).Item("TemGaveta")
            DescontoMaximo = dtConf.Rows.Item(0).Item("DescontoMaximo").ToString
            Mensalista = dtConf.Rows.Item(0).Item("Mensalista")

            OrigemRelease = dtConf.Rows.Item(0).Item("OrigemRelease").ToString
            ComissaoProduto = dtConf.Rows.Item(0).Item("ComissaoProduto")
            PastaCliProdEmissor = dtConf.Rows.Item(0).Item("CaminhoPastaNfe").ToString

            ImpostoPorItem = dtConf.Rows.Item(0).Item("ImpostoPorItem").ToString

            PastaNotaNfe = dtConf.Rows.Item(0).Item("CaminhoPastaNotaNfe").ToString

            SimplesNacional = dtConf.Rows.Item(0).Item("SimplesNacional")

            UsaBoleto = dtConf.Rows.Item(0).Item("UsaBoleto").ToString
            CaminhoPastaBoleto = dtConf.Rows.Item(0).Item("CaminhoPastaBoleto").ToString

            AtuPreCusto = dtConf.Rows.Item(0).Item("AtuPreCusto")

            BuscaCpfCnpj = dtConf.Rows.Item(0).Item("BuscaCpfCnpj").ToString

            ObsProduto = dtConf.Rows.Item(0).Item("ObsProduto")

            ImprimeComanda = dtConf.Rows.Item(0).Item("ImprimeComanda")

            ValorMinimoGaxeta = dtConf.Rows.Item(0).Item("ValorMinimoGaxeta").ToString

            ManterPorcProd = dtConf.Rows.Item(0).Item("ManterPorcProd")

            ComandaPedido = dtConf.Rows.Item(0).Item("ComandaPedido")
            ObsPedidoVenda = dtConf.Rows.Item(0).Item("ImpObsPedidoVenda")

            CompararFornecedor = dtConf.Rows.Item(0).Item("CompararFornecedor")
            VisualizarCobranca = dtConf.Rows.Item(0).Item("VisualizarCobranca")

            ImprimeContaPagar = dtConf.Rows.Item(0).Item("ImprimeContaPagar")

            TabelaPreco = dtConf.Rows.Item(0).Item("TabelaPreco").ToString

            FiltroProdutoContem = dtConf.Rows.Item(0).Item("FiltroProdutoContem").ToString

            EmailConsultoria = dtConf.Rows.Item(0).Item("EmailConsultoria").ToString
            Try
                AlterarDataCaixa = dtConf.Rows.Item(0).Item("AlterarDataCaixa")

                AbrirFecharCaixa = dtConf.Rows.Item(0).Item("AbrirFecharCaixa")


                ImpressaoPadrao = dtConf.Rows.Item(0).Item("ImpressaoPadrao")
            Catch ex As Exception
            End Try



            Try
                VincularUser = dtConf.Rows.Item(0).Item("VincularUser")

                If VincularUser = True Then
                    Dim dtUser As DataTable = CarregarDataTable("SELECT Codigo, Nome From Funcionario Where CodUser =" & CodUser & " And CodConfig = " & CodConfig)

                    If dtUser.Rows.Count > 0 Then
                        'CodFuncUser = dtUser.Rows.Item(0).Item("Codigo").ToString
                        CodigoFuncionario = dtUser.Rows.Item(0).Item("Codigo").ToString
                        NomeFuncionario = dtUser.Rows.Item(0).Item("Nome").ToString
                    End If
                End If
            Catch ex As Exception
                VincularUser = False
            End Try

            Try
                EconomiaCupom = dtConf.Rows.Item(0).Item("TotalEconomizado")
            Catch ex As Exception
                EconomiaCupom = False
            End Try

            Try
                CalcularImpostoProduto = dtConf.Rows.Item(0).Item("CalcImpProd")
            Catch ex As Exception
                CalcularImpostoProduto = True
            End Try


            Try
                ManterMargemProd = dtConf.Rows.Item(0).Item("ManterMargemProd")
            Catch ex As Exception
                ManterMargemProd = False
            End Try

            If TipoNano = 5 Then
                Me.btnCadSevico.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                Me.btnConServico.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            End If

            If TipoNano = 1 Then
                Me.btnComandaTouch.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            End If

            FreteMinimo = dtConf.Rows.Item(0).Item("FreteMinimo")
            PorcentagemFrete = dtConf.Rows.Item(0).Item("PorcentagemFrete")

            ''''''''''COLOCAR NO CONFIG''''''''''
            If CNPJEmpresa = "02986617000153" Or CNPJEmpresa = "05614717000147" Or CNPJEmpresa = "05803686000172" Then
                'A ORGINAL
                DescontoImpressao = False
            Else
                DescontoImpressao = True
            End If
            ''''''''''******************'''''''''
            Try
                SenhaAdm = False
                SenhaAdm = dtConf.Rows.Item(0).Item("SenhaAdm")
            Catch ex As Exception

            End Try

            Try
                MontarKit = dtConf.Rows.Item(0).Item("MontarKit")

                'If MontarKit = True Then
                '    Me.bsiRec.Caption = "Kits"
                'End If
            Catch ex As Exception

            End Try

            MediaCusto = dtConf.Rows.Item(0).Item("MediaCusto")

            CobreBemNano = False
            If IO.File.Exists(My.Application.Info.DirectoryPath & "\CobreBemX.dll") = True Then
                CobreBemNano = True
            End If

            
            If UsaBoleto = False Then
                Me.btnBoleto.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Me.btnConfigBoleto.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Me.bsiBoleto.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Else
                If CaminhoPastaBoleto <> "" Then
                    If CobreBemNano = False Then
                        If Not IO.File.Exists(CaminhoPastaBoleto & "\Debug\NanoBoleto.exe") = True Then
                            Me.btnBoleto.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                            UsaBoleto = False
                        End If
                        Me.btnConfigBoleto.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                        Me.bsiBoleto.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Else
                        Me.btnBoleto.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If
                  

                    Dim dtConfigBanco As DataTable = CarregarDataTable("SELECT Codigo, CodigoBanco, NomeBanco, Cedente, CPF, PerMulta, " & _
                    "PrimeiraInstrucao, SegundaInstrucao, ValorMora, " & _
                    "DiasProtesto, Agencia, CodigoCedente, DiasMora, ContaCorrente, Instrucao, " & _
                    "Instrucao2, CaminhoArquivo FROM Banco where Padrao = 'True' and CodConfig = " & CodConfig)
                    If dtConfigBanco.Rows.Count > 0 Then
                        CodigoBancoBoleto = dtConfigBanco.Rows.Item(0).Item("CodigoBanco").ToString
                        DemonstrativoBanco = dtConfigBanco.Rows.Item(0).Item("Instrucao").ToString
                        InstrucaoBanco = dtConfigBanco.Rows.Item(0).Item("Instrucao2").ToString
                        CodBanco = dtConfigBanco.Rows.Item(0).Item("Codigo").ToString
                        PerMultaBanco = dtConfigBanco.Rows.Item(0).Item("PerMulta").ToString
                        PrimeiraInstrucaoBanco = dtConfigBanco.Rows.Item(0).Item("PrimeiraInstrucao").ToString
                        SegundaInstrucaoBanco = dtConfigBanco.Rows.Item(0).Item("SegundaInstrucao").ToString
                        MoraBanco = dtConfigBanco.Rows.Item(0).Item("ValorMora").ToString
                        DiasProtestoBanco = dtConfigBanco.Rows.Item(0).Item("DiasProtesto").ToString
                        DiasMoraBanco = dtConfigBanco.Rows.Item(0).Item("DiasMora").ToString
                        CaminhoArquivoBoleto = dtConfigBanco.Rows.Item(0).Item("CaminhoArquivo").ToString
                        AgenciaBanco = dtConfigBanco.Rows.Item(0).Item("Agencia").ToString
                        ContaCorrenteBanco = dtConfigBanco.Rows.Item(0).Item("ContaCorrente").ToString
                        CodigoCedenteBanco = dtConfigBanco.Rows.Item(0).Item("CodigoCedente").ToString
                        CPFCedente = dtConfigBanco.Rows.Item(0).Item("CPF").ToString
                        NomeCedente = dtConfigBanco.Rows.Item(0).Item("Cedente").ToString
                    Else
                        UsaBoleto = False
                    End If
                Else
                    Me.btnBoleto.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    UsaBoleto = False
                End If

            End If


            SegViaRecibo = dtConf.Rows.Item(0).Item("SegViaRecibo").ToString
            BaixaPorLote = dtConf.Rows.Item(0).Item("BaixaPorLote")
            If BaixaPorLote = False Then
                Me.btnConsultaTamanho.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            AlteraPrecoPedido = dtConf.Rows.Item(0).Item("AltPrecoPedido")
            ObsPedido = dtConf.Rows.Item(0).Item("DescricaoPedido").ToString
            DescricaoVenda = dtConf.Rows.Item(0).Item("DescricaoVenda").ToString
            AlteraNomePedido = dtConf.Rows.Item(0).Item("AltNomePedido")
            BalancaPor = dtConf.Rows.Item(0).Item("BalancaPor").ToString
            TipoBalanca = dtConf.Rows.Item(0).Item("TipoBalanca").ToString

            PafEcfNano = dtConf.Rows.Item(0).Item("PafEcfNano")
            TrocoCaixa = dtConf.Rows.Item(0).Item("TrocoCaixa")
            ImpressaoPedidoCompleto = dtConf.Rows.Item(0).Item("PedidoCompleto")
            'OcultarAutorizacao = dtConf.Rows.Item(0).Item("OcultarAutorizacao")
            EstoqueSomado = dtConf.Rows.Item(0).Item("EstoqueSomado")

            'If EstoqueSomado = True Then
            AgruparProdutoVenda = dtConf.Rows.Item(0).Item("AgruparProdutoVenda")
            'End If

            PorValorAproximado = dtConf.Rows.Item(0).Item("PorValorAproximado").ToString
            ImprimirDireto = dtConf.Rows.Item(0).Item("ImprimirDireto")
            CodigoBarraCupom = dtConf.Rows.Item(0).Item("CodigoBarraCupom")
            AutorizacaoPedido = dtConf.Rows.Item(0).Item("AutorizacaoPedido")
            DezPorcento = dtConf.Rows.Item(0).Item("DezPorcento")

            SepararEstoqueSetor = dtConf.Rows.Item(0).Item("SepararEstoqueSetor").ToString
            ''If ComissaoProduto = True Then
            ''    Me.btnDevolução.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            ''End If

            SATFiscal = dtConf.Rows.Item(0).Item("SATFiscal")
            ModeloSAT = dtConf.Rows.Item(0).Item("ModeloSAT").ToString

            NANONFCe = dtConf.Rows.Item(0).Item("NANONFCe")
            PastaRemessas = dtConf.Rows.Item(0).Item("CaminhoPastaNFCe").ToString
            UsaPDV = dtConf.Rows.Item(0).Item("PDV")

            Funilaria = dtConf.Rows.Item(0).Item("Funilaria")
            MotoPecas = dtConf.Rows.Item(0).Item("Moto")
            SemCarro = dtConf.Rows.Item(0).Item("SemCarro")
            CampoPedido = dtConf.Rows.Item(0).Item("CampoPedido")

            Dim bolFiscal As Boolean = False

            If MotoPecas = True Then
                Me.btnCadVeiculo.LargeGlyph = Nano.My.Resources.Resources.motorcycle
            End If

            If CNPJEmpresa = "15237457000191" Then
                If My.Computer.Name.ToUpper = "REUNIAO-PC" Then
                    PafEcfNano = False
                    SATFiscal = True
                End If
                If My.Computer.Name.ToUpper = "COMPRAS-PC" Then
                    PafEcfNano = False
                    SATFiscal = True
                End If
            End If
            If PafEcfNano = True Then
                Dim dtEcf As DataTable = CarregarDataTable("SELECT Codigo, ChavePublica, ChavePrivada, CNPJ, IE, Cliche, " & _
                "Tipo, Modelo, Marca, NumeroSerie, NumeroECF, VersaoSB, DataSB, MFAdicional, Impressora, " & _
                "Computador, CodigoEquipamento, MensImpCupomSAT, ModeloSAT FROM ConfigECF where Computador = '" & My.Computer.Name & "' and CodConfig = " & CodConfig)
                If dtEcf.Rows.Count > 0 Then



                    CodConfigECF = dtEcf.Rows.Item(0).Item("Codigo").ToString
                    ChavePublica = dtEcf.Rows.Item(0).Item("ChavePublica").ToString
                    ChavePrivada = dtEcf.Rows.Item(0).Item("ChavePrivada").ToString
                    CNPJECF = dtEcf.Rows.Item(0).Item("CNPJ").ToString
                    IEECF = dtEcf.Rows.Item(0).Item("IE").ToString
                    ClicheECF = dtEcf.Rows.Item(0).Item("Cliche").ToString
                    TipoECF = dtEcf.Rows.Item(0).Item("Tipo").ToString
                    ModeloECF = dtEcf.Rows.Item(0).Item("Modelo").ToString
                    MarcaECF = dtEcf.Rows.Item(0).Item("Marca").ToString
                    NumeroSerieECF = dtEcf.Rows.Item(0).Item("NumeroSerie").ToString
                    NumeroEcfECF = dtEcf.Rows.Item(0).Item("NumeroECF").ToString
                    VersaoSBECF = dtEcf.Rows.Item(0).Item("VersaoSB").ToString
                    DataSBECF = dtEcf.Rows.Item(0).Item("DataSB").ToString
                    MFAdicionalECF = dtEcf.Rows.Item(0).Item("MFAdicional").ToString
                    TipoImpressoraFiscal = dtEcf.Rows.Item(0).Item("Impressora").ToString
                    ComputadorECF = dtEcf.Rows.Item(0).Item("Computador").ToString
                    If dtEcf.Rows.Item(0).Item("CodigoEquipamento").ToString <> "" Then
                        CodigoEquipamento = dtEcf.Rows.Item(0).Item("CodigoEquipamento").ToString
                    End If
                    Me.btnMenuFiscal.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    MensImpCupomSAT = dtEcf.Rows.Item(0).Item("MensImpCupomSAT").ToString
                End If
            Else
                Me.btnConfigECF.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If


            If SATFiscal = True Then
                bolFiscal = True
                AbaSatFiscal = True
                Me.btnRelSAT.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                Me.btnSATFiscal.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                Me.btnConfigECF.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Dim dtEcf As DataTable = CarregarDataTable("SELECT CNPJ, IE, Codigo, NumeroECF, Assinatura, " & _
                "NumeroSerie, CodigoEquipamento, ModeloImpSAT, CaminhoPastaSAT, NomeImpSAT, ImpDiretoSAT, VersaoXmlSAT, ModeloSAT, Regime, MensImpCupomSAT FROM " & _
                "ConfigECF where Computador = '" & My.Computer.Name & "' and CodConfig = " & CodConfig)

                If dtEcf.Rows.Count > 0 Then
                    ModeloSAT = dtEcf.Rows.Item(0).Item("ModeloSAT").ToString
                    CodConfigECF = dtEcf.Rows.Item(0).Item("Codigo").ToString
                    AssinaturaAC = dtEcf.Rows.Item(0).Item("Assinatura").ToString
                    NumeroSerieECF = dtEcf.Rows.Item(0).Item("NumeroSerie").ToString
                    CodigoEquipamento = dtEcf.Rows.Item(0).Item("CodigoEquipamento").ToString

                    CNPJECF = dtEcf.Rows.Item(0).Item("CNPJ").ToString
                    IEECF = dtEcf.Rows.Item(0).Item("IE").ToString
                    NumeroEcfECF = dtEcf.Rows.Item(0).Item("NumeroECF").ToString


                    ModeloImpSAT = dtEcf.Rows.Item(0).Item("ModeloImpSAT").ToString
                    CaminhoPastaSAT = dtEcf.Rows.Item(0).Item("CaminhoPastaSAT").ToString
                    NomeImpSAT = dtEcf.Rows.Item(0).Item("NomeImpSAT").ToString
                    ImpDiretoSAT = dtEcf.Rows.Item(0).Item("ImpDiretoSAT").ToString
                    VersaoXmlSAT = dtEcf.Rows.Item(0).Item("VersaoXmlSAT").ToString

                    RegimeSAT = dtEcf.Rows.Item(0).Item("Regime").ToString
                    MensImpCupomSAT = dtEcf.Rows.Item(0).Item("MensImpCupomSAT").ToString
                    If VersaoXmlSAT = "" Then
                        VersaoXmlSAT = "0.06"
                    End If

                    Me.btnEmailArquivo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                    If ModeloImpSAT = "NORMAL" Or ModeloImpSAT = "TERMICA" Or ModeloImpSAT = "TERMICA MARGEM" Then
                        GerarSATCrystal = True
                    Else
                        GerarSATCrystal = False
                    End If

                Else
                    SATFiscal = False
                    dtEcf = CarregarDataTable("SELECT Regime FROM ConfigECF where CodConfig = " & CodConfig)
                    If dtEcf.Rows.Count > 0 Then
                        RegimeSAT = dtEcf.Rows.Item(0).Item("Regime").ToString
                    End If

                End If
                If RegimeSAT = "" Then
                    dtEcf = CarregarDataTable("SELECT Regime FROM ConfigECF where Regime <> ''")
                    If dtEcf.Rows.Count > 0 Then
                        RegimeSAT = dtEcf.Rows.Item(0).Item("Regime").ToString
                    End If
                End If


            End If


            If NANONFCe = True Then
                If SATFiscal = False Then
                    bolFiscal = True
                    Me.btnRelSAT.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Me.btnRelSAT.Caption = "NFC-e"
                    Me.btnConfigECF.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Me.btnConfigECF.Caption = "NFC-e"
                    Me.btnConfigECF.Description = "Abre o menu NFC-e"
                    If IO.File.Exists(My.Application.Info.DirectoryPath & "\PastaRemessas.txt") = True Then
                        PastaRemessas = LerArquivo(My.Application.Info.DirectoryPath & "\PastaRemessas.txt", True)
                    End If

                    clsNFCe.CarregarEmitente()
                End If
            End If

            If PafEcfNano = True Then
                CpfNaNota = True
            Else
                If SATFiscal = True Or NANONFCe = True Then
                    CpfNaNota = True
                Else
                    CpfNaNota = False
                End If
            End If

            DeOlhoNoImposto = dtConf.Rows.Item(0).Item("ValorAproximado")
            AcrescentarZeroCodProd = dtConf.Rows.Item(0).Item("ZeroCodProd")

            EmailArquivo = dtConf.Rows.Item(0).Item("EmailArquivo").ToString
            'TresCasasDecimais = dtConf.Rows.Item(0).Item("TresCasasDecimais")
            TresCasasDecimais = True
            CasaDecimal = dtConf.Rows.Item(0).Item("CasaDecimal")

            Try
                ObsClientePedido = dtConf.Rows.Item(0).Item("ObsClientePedido")

            Catch ex As Exception

            End Try

            Try
                TabelaPrecoPorItem = dtConf.Rows.Item(0).Item("TabelaPrecoItem")
            Catch ex As Exception

            End Try

            Try
                ValePresente = dtConf.Rows.Item(0).Item("ValePresente")
            Catch ex As Exception

            End Try

            If dtConf.Rows.Item(0).Item("Tolerancia").ToString <> "" Then
                Tolerancia = dtConf.Rows.Item(0).Item("Tolerancia")
            Else
                Tolerancia = 0
            End If

            Try
                TotalPendenciaImpressao = dtConf.Rows.Item(0).Item("TotalPendenciaImp")
            Catch ex As Exception

            End Try

            EmiteNFE = dtConf.Rows.Item(0).Item("NfeNano")
            If EmiteNFE = True Then

                bolFiscal = True
                If PastaNotaNfe.Length > 2 Then
                    If PastaNotaNfe.Substring(0, 2) = "\\" Then
                        Dim strPN As String = PastaNotaNfe.Substring(2, PastaNotaNfe.Length - 2)
                        Dim vetPN As Array = Split(strPN, "\")
                        Try
                            PastaNotaNfe = "C:\" & vetPN(1) & "\" & vetPN(2)
                        Catch ex As Exception
                            PastaNotaNfe = "C:\NANONFe\Remessas"
                        End Try

                    End If
                End If

                If SATFiscal = False Then
                    CarregarEmitenteNFe()
                End If

                Dim strPastaArq As String = PastaNotaNfe.Replace("Remessas", "Debug") & "\NanoNfe.exe"
                If Not IO.File.Exists(strPastaArq) = True Then
                    Me.btnNfeNano.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                End If
            Else
                Me.btnNfeNano.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                Me.btnNFE.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Me.btnLimparNfe.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                Me.btnConfigNfe.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Me.btnTransportadora.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If

            If AbaSatFiscal = True Then
                If EmiteNFE = True Then
                    TipoFiscal = "AMBOS"
                Else
                    TipoFiscal = "SAT"
                End If
            Else
                TipoFiscal = "NFE"
            End If

            NanoNFSe = dtConf.Rows.Item(0).Item("NfseNano")
            If NanoNFSe = True Then
                bolFiscal = True
                Me.btnNfseNano.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            End If

            If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\Relatórios") = False Then
                Me.RibbonPageGroup1.Visible = False
            End If
            If PortaImpressora.Trim = "" Then
                Dim vetConfigImp As Array
                vetConfigImp = Split(LerArquivo(My.Application.Info.DirectoryPath & "\Porta.txt", True), "|")
                PortaImpressora = vetConfigImp(0).ToString
                If vetConfigImp.Length > 1 Then
                    Impressora = vetConfigImp(1).ToString
                End If
            End If

            TipoDesconto = dtConf.Rows.Item(0).Item("TipoDesc").ToString

            PortaImpressoraCodigoBarra = dtConf.Rows.Item(0).Item("PortaImpCodBarra").ToString

            If PortaImpressoraCodigoBarra.Trim = "" Then
                PortaImpressoraCodigoBarra = LerArquivo(My.Application.Info.DirectoryPath & "\PortaBarra.txt", True)
            End If

            If dtConf.Rows.Item(0).Item("Juros").ToString <> "" Then
                PorcentualJuros = dtConf.Rows.Item(0).Item("Juros").ToString
            End If

            If dtConf.Rows.Item(0).Item("JurosParcela").ToString <> "" Then
                JurosPorParcela = dtConf.Rows.Item(0).Item("JurosParcela").ToString
            End If

            'ValidarCep = dtConf.Rows.Item(0).Item("ValidarCep")
            'corrigir no Commerce sql
            '##################################################################################################################
            NomeImpCodigoBarra = dtConf.Rows.Item(0).Item("ImpCodBarra").ToString
            '##################################################################################################################


            TEF = dtConf.Rows.Item(0).Item("TEF")
            If TEF = True Then
                CaixaTEF = "01"
                Me.btnConfigTEF.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                If CarregarDadosTEF() = False Then

                    TEF = False
                    If Login = "ADM" And Senha = "SPFC" Then
                        Me.btnConfigTEF.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        Me.btnConfigTEF.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If

                End If

            End If

            If Impressora = "DARUMA" Then
                If NomePCImpressora.Trim <> My.Computer.Name Then
                    TemImpressora = False
                End If
            End If
            If NomeEmpresa.ToUpper.Contains("CHOPP") Then
                Me.bsiBarril.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            End If
            If NomeEmpresa.Contains("RAISNER") Then
                Me.btnComissao.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            End If

            If NomeEmpresa.Contains("CRAVO CANELA") = True Then
                If Nivel = "USUÁRIO" Then
                    Me.bsiCravoCanela.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                End If
            Else
                Me.bsiCravoCanela.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If

            If NomeEmpresa.Trim.ToUpper.Contains("CHARME REPRESENTAÇÕES") = True Then
                Me.btnCadastrarComissao.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            End If
            Me.btnCredDeb.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnConsultarCredDeb.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            'VERIFICA SE O CLIENTE EMITE CUPOM FISCAL
            ''If dtConf.Rows.Item(0).Item("EmiteCupom").ToString = "1" Then
            ''    ImprimirCupomFiscal = True
            ''    'btnOPaf.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            ''    If dtConf.Rows.Item(0).Item("CNPJ").ToString.Trim = "" Then
            ''        MsgBox("O campo CNPJ do cliente Nano não foi informado!", MsgBoxStyle.Information) : Me.Close()
            ''    Else
            ''        CNPJdoCliente = dtConf.Rows.Item(0).Item("CNPJ").ToString
            ''    End If

            ''    If dtConf.Rows.Item(0).Item("UsaTEF").ToString = "1" Then
            ''        ClienteUsaTEF = True
            ''    End If

            ''    If dtConf.Rows.Item(0).Item("CaminhoDaPastaRemessa").ToString <> "" Then
            ''        CaminhoDaPastaMestra = dtConf.Rows.Item(0).Item("CaminhoDaPastaRemessa").ToString
            ''    Else
            ''        MsgBox("Caminho da pasta mestra não foi informado!", MsgBoxStyle.Information)
            ''        Me.Close()
            ''    End If

            ''End If


            If bolFiscal = True Then
                Dim dtTabelaIbpt As DataTable = CarregarDataTable("SELECT Versao FROM TabelaIbpt where UF ='" & UFEmpresa & "'")
                If dtTabelaIbpt.Rows.Count = 0 Then
                    frmAtualizarTabelas.Tag = "TabelaIBPT"
                    frmAtualizarTabelas.strUF = UFEmpresa
                    frmAtualizarTabelas.ShowDialog()
                Else
                    If dtTabelaIbpt.Rows.Item(0).Item("Versao").ToString <> "" Then
                        Dim intVersaoIBPT As Integer = dtTabelaIbpt.Rows.Item(0).Item("Versao").ToString.Replace(".", "")
                        If intVersaoIBPT < 201 Then
                            frmAtualizarTabelas.Tag = "TabelaIBPT"
                            frmAtualizarTabelas.strUF = UFEmpresa
                            frmAtualizarTabelas.ShowDialog()
                        End If
                    Else
                        frmAtualizarTabelas.Tag = "TabelaIBPT"
                        frmAtualizarTabelas.strUF = UFEmpresa
                        frmAtualizarTabelas.ShowDialog()
                    End If
                End If
            End If

            TemBalanca = dtConf.Rows.Item(0).Item("TemBalanca")
            If TemBalanca = True Then
                If TipoBalanca.Contains("TOLEDO") = True Then
                    PortaBalanca = "1"
                    BaudRateBalanca = "0"
                    DataBitsBalanca = 1
                    ParidadeBalanca = 0
                    Try
                        If IO.File.Exists(My.Application.Info.DirectoryPath & "\ConfigBalanca.txt") = True Then
                            Dim strConfigBalanca As String = LerArquivo(My.Application.Info.DirectoryPath & "\ConfigBalanca.txt", True)
                            Dim vetConfigBalanca As Array = Split(strConfigBalanca, "Paridade")
                            vetConfigBalanca = Split(vetConfigBalanca(1), "Legenda")
                            vetConfigBalanca = Split(vetConfigBalanca(0), "|")
                            PortaBalanca = vetConfigBalanca(0)
                            BaudRateBalanca = vetConfigBalanca(1)
                            DataBitsBalanca = vetConfigBalanca(2)
                            ParidadeBalanca = vetConfigBalanca(3)
                        End If
                    Catch ex As Exception

                    End Try
                Else
                    PortaBalanca = "COM1"
                    BaudRateBalanca = "2"
                    Try
                        If IO.File.Exists(My.Application.Info.DirectoryPath & "\ConfigBalanca.txt") = True Then
                            Dim strConfigBalanca As String = LerArquivo(My.Application.Info.DirectoryPath & "\ConfigBalanca.txt", True)
                            Dim vetConfigBalanca As Array = Split(strConfigBalanca, "|")
                            PortaBalanca = vetConfigBalanca(0)
                            BaudRateBalanca = vetConfigBalanca(1)
                        End If
                    Catch ex As Exception

                    End Try

                End If
            End If

            If TemGaveta = True Then
                If IO.File.Exists(My.Application.Info.DirectoryPath & "\PCGaveta.txt") = True Then
                    NomePCGaveta = LerArquivo(My.Application.Info.DirectoryPath & "\PCGaveta.txt", True)
                End If

                If IO.File.Exists(My.Application.Info.DirectoryPath & "\FMGaveta.txt") = True Then
                    FormaPagamentoGaveta = "|" & LerArquivo(My.Application.Info.DirectoryPath & "\FMGaveta.txt", True) & "|"
                End If
            End If


            SaldoCaixa = dtConf.Rows.Item(0).Item("SaldoCaixa")
        Else
            MsgBox("CONFIGURE A TABELA CONFIG DO BANCO DE DADOS!", MsgBoxStyle.Information)
            Me.Close()
            Exit Sub
        End If


        'CARREGAR INFORMAÇÕES DE AVISO NO MDI

        Me.Text = "Nano Commerce"

        Dim strData As String = "Day(Nascimento) ='" & Date.Today.Day & "' and Month(Nascimento) ='" & Date.Today.Month & "'"
        CarregarDadosLue("Select Nome, Telefone, Email from Cliente where " & strData, Me.lueAni)


        Dim dtAvisos As DataTable
        dtAvisos = CarregarDataTable("Select Nome, Telefone, Email from Cliente where " & strData)

        Me.txtNumAni.Text = dtAvisos.Rows.Count

        strData = String.Format("Vencimento= '{0:dd/MM/yyyy}'", Date.Today)
        dtAvisos = CarregarDataTable("Select ValorParcela from ContaReceber where " & strData & " and RecebidoOK = 'false' and CodConfig = " & CodConfig)
        Me.txtNumCR.Text = dtAvisos.Rows.Count

        dtAvisos = CarregarDataTable("Select sum(ValorParcela) from ContaReceber where " & strData & " and RecebidoOK = 'false' and CodConfig = " & CodConfig)

        Dim dblTotCR As Double = 0

        If dtAvisos.Rows.Count > 0 Then
            If dtAvisos.Rows.Item(0).Item(0).ToString <> "" Then
                dblTotCR = dtAvisos.Rows.Item(0).Item(0).ToString
            End If
        End If

        Me.txtTotCR.Text = dblTotCR.ToString("###,###,###,##0.00")


        strData = String.Format("Vencimento= '{0:dd/MM/yyyy}'", Date.Today)

        dtAvisos = CarregarDataTable("Select ValorParcela from ContaPagar where " & strData & " and PagoOK = 'False' and CodConfig = " & CodConfig)
        Me.txtNumCP.Text = dtAvisos.Rows.Count

        dtAvisos = CarregarDataTable("Select sum(ValorParcela) from ContaPagar where " & strData & " and PagoOK = 'False' and CodConfig = " & CodConfig)

        Dim dblTotCP As Double = 0

        If dtAvisos.Rows.Count > 0 Then
            If dtAvisos.Rows.Item(0).Item(0).ToString <> "" Then
                dblTotCP = dtAvisos.Rows.Item(0).Item(0).ToString
            End If
        End If

        Me.txtTotCP.Text = dblTotCP.ToString("###,###,###,##0.00")

        'BLOQUEAR POR USUÁRIOS


        If TipoNano = 0 Or TipoNano = 2 Or TipoNano = 3 Or TipoNano = 5 Then
            'Me.btnCadReceita.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'bsiRec.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnComanda.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnRelComanda.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'Me.bsiCotacao.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Else
            If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\ImagensComanda") = True Then
                If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/Mesa1.png") = True Then
                    Imagem1Comanda = frmCadProduto.converteimagem(System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "/ImagensComanda/Mesa1.png"))
                End If
                If IO.File.Exists(My.Application.Info.DirectoryPath & "/ImagensComanda/Mesa2.png") = True Then
                    Imagem2Comanda = frmCadProduto.converteimagem(System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "/ImagensComanda/Mesa2.png"))
                Else
                    Imagem2Comanda = frmCadProduto.converteimagem(System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "/ImagensComanda/Mesa.png"))
                End If
            End If
    
        End If
        If TipoNano <> 3 Then

            Me.btnRetorno.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.colAnimal.Visible = False
        End If
        If TipoNano = 3 Then
            Me.btnCadAnimal.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If
        If TipoNano <> 5 Then
            Me.colModelo.Visible = False
            Me.colPlaca.Visible = False
            Me.bsiRelVeiculo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnCadVeiculo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If



        Dim dt As DataTable
        Dim vetPrin, vetCon, vetRel As Array
        Dim I As Integer

        dt = CarregarDataTable("Select Principal, Consultas, Relatorios from Usuario where Login ='" & Login & "' and Senha ='" & Senha & "'")

        vetPrin = Split(dt.Rows.Item(0).Item(0).ToString, "|")
        vetCon = Split(dt.Rows.Item(0).Item(1).ToString, "|")
        vetRel = Split(dt.Rows.Item(0).Item(2).ToString, "|")

        For I = 0 To vetPrin.Length - 1
            Bloquear("Principal", vetPrin(I).ToString)

        Next
        BloquearGroup("Principal")
        For I = 0 To vetCon.Length - 1
            Bloquear("Consultas", vetCon(I).ToString)
        Next

        For I = 0 To vetRel.Length - 1
            Bloquear("Relatorios", vetRel(I).ToString)
        Next
        BloquearGroup("Relatorios")
        InitSkinGallery()
        lblUser.Caption = UserNano & "        "
        If Nivel = "ADMINISTRADOR" Or Nivel = "MASTER" Then
            Me.btnUsu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            If bolBloqueioUsuario = False Then
                Me.btnBloqUsu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            End If

            Me.rpgLog.Visible = True
        End If

        'If EmiteCupom = 1 Then
        '    Me.btnGerArqsCF.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'End If



        If UsaPDV = True Then

            Me.rpgPedComp.Visible = False
            Me.btnCadAnimal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'Me.bstFunc.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnCadDuplicata.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.bsiCampanha.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.bsiTransferencia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.bsiCheque.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'Me.btnTransportadora.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'Me.rpgNotas.Visible = False
            Me.bsiNF.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.rpgContas.Visible = False
            'Me.rpgCaixa.Visible = False
            Me.rpgBanco.Visible = False
            Me.btnComissao.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.bsiGraficos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnFluxo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.bsiCravoCanela.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.bsiRelPedidoCompra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.rpgRecebimentos.Visible = False
            Me.rpgContasOK.Visible = False
            Me.bsiRelNF.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'Me.rpgNotasOK.Visible = False
            'Me.rpgRelProd.Visible = False
            Me.rpgIndice.Visible = False
            Me.rpgVisao.Visible = False
            Me.rpgLog.Visible = True
            Me.btnBloqUsu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.rpDown.Visible = False

            Me.btnGiro.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.bsiRelCampanha.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.bsiRelTrans.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnConInventario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            Me.RibbonPageGroup4.Visible = False
            Me.BarSubItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

        PlanoFundo()

        'If Date.Today.Day < 5 Then
        '    Dim dtIni As DataTable = CarregarDataTable("SELECT Codigo FROM SaldoInicio where Mes = '" & Month(Now) & "' and CodConfig = " & CodConfig)
        '    If dtIni.Rows.Count = 0 Then
        '        Dim dtQtd As DataTable = CarregarDataTable("SELECT Produto.Codigo, (SELECT sum(Qtde.Qtd) FROM Qtde where Qtde.CodProd = Produto.Codigo and Qtde.CodConfig = " & CodConfig & ") as Qtd FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd group by Produto.Codigo order by Produto.Codigo")
        '        For I = 0 To dtQtd.Rows.Count - 1
        '            Dim strCodigo As String = dtQtd.Rows.Item(I).Item("Codigo").ToString
        '            Dim dblQtde As Double = 0
        '            If dtQtd.Rows.Item(I).Item("Qtd").ToString <> "" Then
        '                dblQtde = dtQtd.Rows.Item(I).Item("Qtd").ToString
        '            End If
        '            Inserir("INSERT INTO SaldoInicio (CodProd, Mes, Qtd, CodConfig) VALUES (" & strCodigo & ",'" & Month(Now) & "'," & Num(dblQtde) & "," & CodConfig & ")")
        '        Next
        '    End If
        'End If

        LogoTipo = picLogo.Image

        If SATFiscal = True Then
            If EmailArquivo <> "" Then
                IniciaThreadSAT()
            End If
        End If

        If EmiteNFE = True Then
            If EmailArquivo <> "" Then
                IniciaThreadNFe()

            End If
        End If
         If EmailConsultoria <> "" Then
            If IO.Directory.Exists("C:\NANO\Consultoria") = True Then
                Me.btnEmailConsultoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                IniciaThreadConsultoria()
            End If
        End If

        If Me.bsiNF.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.btnNfeNano.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then
            Me.rpgNotas.Visible = False
        End If
        If btnRelSAT.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.bsiRelNF.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then
            Me.rpgNotasOK.Visible = False
        End If
        If ExisteTabela("Cheque") = False Then
            Me.bsiCheque.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        Timer1.Start()
        Timer3.Start()
    End Sub

    Public Function converteimagem(ByVal Imagem As System.Drawing.Image) As Byte()

        'Declare uma variável do Tipo MemoryStream

        Dim ms As New System.IO.MemoryStream()

        'Carrega o memory Stream

        Imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

        'retorna um array de bytes

        Return ms.ToArray()

    End Function

    Private Sub CarregarLogo(ByVal parLogo As Object)
        Try
            Dim Imagem As Byte() = CType(parLogo, Byte())

            Dim memorybits As New MemoryStream(Imagem)

            Dim bitmap As New Bitmap(memorybits)

            Me.picLogo.Image = bitmap
        Catch ex As Exception

        End Try


    End Sub
    Private Sub PlanoFundo()
        Dim dtFundo As DataTable
        dtFundo = CarregarDataTable("SELECT FundoPadrao, Exibicao, PlanoFundo FROM Usuario where Login ='" & Login & "' and Senha ='" & Senha & "'")

        If dtFundo.Rows.Count > 0 Then

            If dtFundo.Rows.Item(0).Item("FundoPadrao") = True Then
                Me.pnlFundo.Visible = False
                Me.pnlLadoLado.Visible = False

                If TipoNano = 5 Or TipoNano = 2 Then
                    picImg.Visible = False
                    PictureEdit3.Visible = False
                    PictureEdit4.Visible = False

                    ClientPanel.ContentImage = Nano.My.Resources.Resources.NANOAutomotivo
                    Me.ClientPanel.ContentImageAlignement = ContentAlignment.MiddleCenter
                End If
            Else
                Dim strExibicao As String

                Dim Imagem As Byte() = CType(dtFundo.Rows.Item(0).Item("PlanoFundo"), Byte())

                Dim memorybits As New MemoryStream(Imagem)

                Dim bitmap As New Bitmap(memorybits)

                Me.picFundo.Image = bitmap

                strExibicao = dtFundo.Rows.Item(0).Item("Exibicao").ToString



                Select Case strExibicao
                    Case "0"

                        Me.pnlFundo.Dock = DockStyle.None
                        '  Me.picFundo.Location = New System.Drawing.Point(170, 60)
                        Me.picFundo.Dock = DockStyle.None
                        Me.picFundo.Anchor = AnchorStyles.Top
                        Me.pnlFundo.Dock = DockStyle.Fill
                        Me.pnlFundo.Visible = True
                        Me.pnlLadoLado.Visible = False

                    Case "1"
                        Me.pnlFundo.Dock = DockStyle.Fill
                        Me.picFundo.Dock = DockStyle.Fill
                        Me.pnlFundo.Visible = True
                        Me.pnlLadoLado.Visible = False


                    Case "2"
                        pic1.Image = Me.picFundo.Image
                        pic2.Image = pic1.Image
                        pic3.Image = pic1.Image
                        pic4.Image = pic1.Image
                        pic5.Image = pic1.Image
                        pic6.Image = pic1.Image
                        pic7.Image = pic1.Image
                        pic8.Image = pic1.Image
                        Me.pnlLadoLado.Dock = DockStyle.Fill
                        Me.pnlLadoLado.Visible = True
                        Me.pnlFundo.Visible = False



                End Select
            End If
        End If
    End Sub
    Private Sub Bloquear(ByVal parAba As String, ByVal parIndex As String)

        If parAba = "Principal" Then
            Select Case parIndex
                Case 0
                    Me.btnVenda.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Me.RibbonPageGroup18.Visible = False
                    BloquearVenda = True
                    Me.btnFatPedPendente.Visible = False
                Case 1
                    Me.btnCliente.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Me.btnCadVeiculo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 2
                    Me.btnFornecedor.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 3
                    Me.btnCadProd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Me.btnCadSevico.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    'corrigir no Commerce sql
                    '##################################################################################################################
                    bolEstoqueBloqueado = True
                Case 4
                    Me.btnCadFunc.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 5
                    mnuPagamento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 6
                    Me.bsiNF.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 7
                    btnReceber.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 8
                    btnPagar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 9
                    btnCaixa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Me.rpgCaixa.Visible = False
                Case 10
                    Me.btnDevolução.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                Case 11
                    Me.btnDescarte.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 12
                    SaldoAtualCaixa = True
                Case 13
                    Me.bsiPedidos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Me.RibbonPageGroup12.Visible = False
                Case 14
                    rpgBanco.Visible = False
                Case 15
                    Me.btnNFE.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Me.btnNfeNano.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 16
                    Me.btnTransportadora.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 17
                    Me.bsiCheque.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 18
                    Me.btnInventario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 19
                    Me.btnAtivarProduto.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 20
                    Me.btnAltVal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 21
                    Me.pnlAnalitico.Visible = False
                    Me.pnlPedido.Visible = False
                    bolBloqueioAnalyzer = True
                Case 22
                    Me.btnConProdu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Me.btnConsultaTamanho.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Me.btnConServico.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 23
                    Me.btnBoleto.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 24
                    SaldoAtualCaixaDinheiro = True
                Case 25
                    'Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    ExcluirVendas = False
                Case 26
                    Me.btnEstNeg.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                Case 27
                    Me.btnProdFalta.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 28
                    Me.bsiTransferencia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 29
                    Me.bsiPedidoCompra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Me.rpgPedComp.Visible = False
                Case 30
                    Me.bsiCampanha.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 31
                    BloquearDescontoPorItem = True
                Case 32
                    RelatorioVendaNaVenda = True
                Case 33
                    bolBloqueioUsuario = True
                Case 34
                    BloquearRelatoriosCaixa = True
                Case 35
                    Me.btnUsu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 36
                    Me.btnCadPedido.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 37
                    Me.btnAltPedido.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 38
                    Me.btnConPedido.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 39
                    Me.btnComanda.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Me.btnComandaTouch.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 40
                    BloquearAbreGaveta = True
                Case 41
                    Me.bsiRec.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 42
                    AlterarDataCaixa = False
                Case 43
                    DesfaturarPedidos = False
                Case 44
                    ExcluirPedido = False
                Case 45
                    Me.btnNfseNano.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 46
                    ExcluirLancamentoBancario = False
                Case 47
                    Me.btnMovBanco.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 48
                    BloqueioTransferenciaBancario = False
                Case 49
                    Me.btnCadastrarComissao.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Me.btnCredDeb.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Me.btnConsultarCredDeb.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Me.BarSubItem4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 50
                    BloquearEstoqueZeradoConfig = True
            End Select
        End If

        If parAba = "Relatorios" Then
            Select Case parIndex
                Case 0
                    btnTotais.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 1
                    btnRelLucro.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 2
                    Me.bsiGraficos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 3
                    bsiTotais.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 4
                    bsiCartoes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 5
                    btnConCtRecT.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 6
                    btnPagas.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 7
                    btnRelTotalNF.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 8
                    btnNFItens.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 9
                    Me.btnDev.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 10
                    btnConsumo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 11
                    btnRelVisao.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    rpgVisao.Visible = False
                Case 12
                    btnRelDescarte.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 13
                    Me.btnGiro.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 14
                    Me.rpgIndice.Visible = False
                Case 15
                    Me.btnRelSAT.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 16
                    Me.bsiRelTrans.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 17
                    Me.btnConInventario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 18
                    Me.btnFluxo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 19
                    Me.btnRelPedItens.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Me.relPedTotal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 20
                    Me.bsiRelPedidoCompra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 21
                    Me.bsiRelCampanha.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 22
                    Me.btnMedia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case 23
                    Me.RibbonPageGroup4.Visible = False
                Case 24
                    RibbonPageGroup1.Visible = False
                Case 25

                    Me.btnRelComanda.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End Select

        End If

    End Sub
    Private Sub BloquearGroup(ByVal parAba As String)
        If parAba = "Principal" Then
            If Me.btnCadProd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.btnConProdu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never _
            And Me.btnConsultaTamanho.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.btnDevolução.Visibility = DevExpress.XtraBars.BarItemVisibility.Never _
            And Me.btnDescarte.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.btnInventario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never _
            And Me.btnAtivarProduto.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.btnEstNeg.Visibility = DevExpress.XtraBars.BarItemVisibility.Never _
            And Me.btnProdFalta.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.bsiTransferencia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never _
            And Me.bsiCampanha.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.bsiRec.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then
                Me.mnuProduto.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If


            If Me.btnCliente.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.btnCadAnimal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never _
            And Me.btnFornecedor.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.mnuProduto.Visibility = DevExpress.XtraBars.BarItemVisibility.Never _
            And Me.bstFunc.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.mnuPagamento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never _
            And Me.btnTransportadora.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then
                Me.RibbonPageGroup3.Visible = False

            End If

            If Me.bsiNF.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.btnNfeNano.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.btnNfseNano.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then
                Me.rpgNotas.Visible = False
            End If

            If Me.btnReceber.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.btnPagar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then
                Me.bsiContas.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Me.rpgContas.Visible = False
            End If
            If ExcluirVendas = False And DesfaturarPedidos = False Then
                Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If




            If Me.btnCadFunc.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.btnCadastrarComissao.Visibility = DevExpress.XtraBars.BarItemVisibility.Never _
            And Me.btnCredDeb.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.btnConsultarCredDeb.Visibility = DevExpress.XtraBars.BarItemVisibility.Never _
             And Me.BarSubItem4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then
                Me.bstFunc.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
        End If



        If parAba = "Relatorios" Then
            If Me.btnTotais.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.btnRelLucro.Visibility = DevExpress.XtraBars.BarItemVisibility.Never _
            And Me.btnMedia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then
                Me.bsiRelVendas.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If Me.btnRelComanda.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.btnRelPedItens.Visibility = DevExpress.XtraBars.BarItemVisibility.Never _
            And Me.relPedTotal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then
                Me.bsiRelPedido.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If Me.bsiRelPedido.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.bsiRelPedidoCompra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then
                Me.bsiPedido.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If Me.bsiRelVendas.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.bsiRelVeiculo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never _
            And Me.btnComissao.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.bsiGraficos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never _
            And Me.btnFluxo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never _
            And Me.bsiPedido.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.bsiCravoCanela.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then
                Me.RibbonPageGroup10.Visible = False
            End If

            If Me.bsiTotais.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.bsiCartoes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then
                Me.rpgRecebimentos.Visible = False
            End If

            If Me.btnConCtRecT.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.btnPagas.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then
                Me.bsiConta.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Me.rpgContasOK.Visible = False
            End If

            If Me.btnRelTotalNF.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.btnNFItens.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then
                Me.bsiRelNF.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If Me.bsiRelNF.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.btnRelSAT.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then
                Me.rpgNotasOK.Visible = False
            End If

            If Me.btnGiro.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.btnRelDescarte.Visibility = DevExpress.XtraBars.BarItemVisibility.Never _
            And Me.btnDev.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.bsiRelTrans.Visibility = DevExpress.XtraBars.BarItemVisibility.Never _
            And Me.btnConInventario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.bsiRelCampanha.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then
                Me.bsiRelEstoque.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If

            If Me.btnConsumo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.bsiRelEstoque.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then
                Me.rpgRelProd.Visible = False
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblHora.Caption = My.Computer.Clock.LocalTime

        intContControle += 1
        intCont += 1

        intContAgenda += 1


        If bolMDIPedPendente = True Then
            intMDIPedPendente += 1
            If intMDIPedPendente = 5 Then
                bolMDIPedPendente = False
                intMDIPedPendente = 0
            End If
        End If


        If intContControle = 10 Then
            IniciaThreadControle()
            IniciaThreadBaixaCrystal()
            CarregaRepresentante()

            Try
                Dim service As ServiceProcess.ServiceController = New ServiceProcess.ServiceController("SQLSERVERAGENT")

                If ((service.Status.Equals(ServiceProcess.ServiceControllerStatus.Stopped)) Or (service.Status.Equals(ServiceProcess.ServiceControllerStatus.StopPending))) Then
                    service.Start()
                End If
            Catch ex As Exception

            End Try
        End If

        If intContControle = 60 Then
            If IO.File.Exists(My.Application.Info.DirectoryPath & "\SiteNano.txt") = False Then
                Timer4.Start()
            End If
            'IniciaThreadSiteNano()
        End If

        If intCont = 1800 Then
            IniciaThreadControle()
            intCont = 0
        End If


        

        If bolDigitaCNPJ = True Then
            bolDigitaCNPJ = False
            Try
                MsgBox("O seu sistema está bloqueado!" & vbCrLf & "Entre em contato com a Era Systems!", MsgBoxStyle.Critical)
                frmDigitaCnpj.ShowDialog()
                If frmDigitaCnpj.bolOK = False Then
                    SistemaBloqueado = True
                End If
            Catch ex As Exception

            End Try
        End If

        If SistemaBloqueado = True Then
            Me.Close()
        End If
        'If VisualizarCobranca = True Then
        If strAviso.Trim <> "" Then
            If strAviso.Contains("possui débitos com a Era Systems") = True Then
                Me.btnPagarAgora.Visible = True
            Else

            End If
            Me.txtAviso.Visible = True
            Me.btnFechaAviso.Visible = True
            Me.picAviso.Visible = True

            Me.txtAviso.Text = strAviso
            strAviso = ""
        End If
        Me.btnVerificaBoleto.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'Else
        'Me.btnVerificaBoleto.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'End If


        'If intContAgenda = 900 Then
        '    IniciaThread()
        '    intContAgenda = 0
        'End If



        'If bolTrocarUsuario = True Then
        '    Dim I As Integer
        '    'For I = 0 To My.Application.OpenForms.Count - 1
        '    '    If I = My.Application.OpenForms.Count Then Exit For
        '    '    My.Application.OpenForms.Item(I).Close()
        '    '    If I > 0 Then I = I - 1

        '    'Next

        '    Dim intForm As Integer = My.Application.OpenForms.Count
        '    For I = 0 To My.Application.OpenForms.Count - 1

        '        Dim strNome As String = My.Application.OpenForms.Item(intForm - 1).Name
        '        If strNome <> "frmLogin" Then
        '            If I = My.Application.OpenForms.Count Then Exit For

        '            My.Application.OpenForms.Item(intForm - 1).Close()
        '        End If
        '        intForm = intForm - 1
        '    Next
        '    bolTrocarUsuario = False
        'End If


    End Sub

    Private Sub CarregaRepresentante()

        If bolRepresentanteOK = True Then Exit Sub

        Dim dtEraFunc As DataTable

        Dim strCPFConfig As String
        Dim strTipDoc As String

        If CNPJEmpresa.Length = 11 Then
            strTipDoc = "Cpf"
        Else
            strTipDoc = "Cnpj"
        End If

        strCPFConfig = FormatarDocumentoString(CNPJEmpresa, strTipDoc)

        Dim bolConexao As Boolean = False

        Try
            My.Computer.Network.Ping("www.terra.com.br")
            bolConexao = True
        Catch ex As Exception
            bolConexao = False
        End Try

        If bolConexao = True Then
            Dim dt As DataTable = DataTableOnline("Select CodFunc from Cliente where CPF ='" & strCPFConfig & "'")

            If dt.Rows.Count > 0 Then
                intEraCodFunc = dt.Rows.Item(0).Item("CodFunc")
            End If


            dtEraFunc = DataTableOnline("Select Nome, Telefone, Celular, Email, Alergia, Bairro from Funcionario where Codigo =" & intEraCodFunc)

            If dtEraFunc.Rows.Count > 0 Then

                Dim strConteudo As String = "CANAL " & dtEraFunc.Rows.Item(0).Item("Nome").ToString.ToUpper & "|" & dtEraFunc.Rows.Item(0).Item("Telefone").ToString & "|" & dtEraFunc.Rows.Item(0).Item("Celular").ToString & "|" & dtEraFunc.Rows.Item(0).Item("Email").ToString.ToLower & "|" & dtEraFunc.Rows.Item(0).Item("Alergia").ToString.ToLower & "|" & dtEraFunc.Rows.Item(0).Item("Bairro").ToString.ToLower

                If dtEraFunc.Rows.Item(0).Item("Telefone").ToString <> "" And dtEraFunc.Rows.Item(0).Item("Email").ToString <> "" Then
                    clsFuncoes.EscreveArquivo(My.Application.Info.DirectoryPath & "\Representante.txt", strConteudo)
                    strRepresentante = "CANAL " & dtEraFunc.Rows.Item(0).Item("Nome").ToString.ToUpper
                    Me.nbcEraSystems.ActiveGroup.Caption = "CANAL " & dtEraFunc.Rows.Item(0).Item("Nome").ToString.ToUpper
                    Me.lblTel.Text = dtEraFunc.Rows.Item(0).Item("Telefone").ToString.ToUpper
                    If dtEraFunc.Rows.Item(0).Item("Celular").ToString <> "" Then
                        Me.lblTel.Text += " / " & dtEraFunc.Rows.Item(0).Item("Celular").ToString
                    End If
                    strEmailRepresentante = dtEraFunc.Rows.Item(0).Item("Email").ToString.ToUpper
                    Me.lblEmail.Text = dtEraFunc.Rows.Item(0).Item("Email").ToString.ToLower
                    Me.lblSkype.Text = dtEraFunc.Rows.Item(0).Item("Alergia").ToString.ToLower
                    Me.lblEraSystems.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Representante = True
                End If
            End If

        Else
            If System.IO.File.Exists(My.Application.Info.DirectoryPath & "\Representante.txt") = True Then

                Dim vetRep As Array = Split(LerArquivo(My.Application.Info.DirectoryPath & "\Representante.txt", False), "|")

                If vetRep.Length > 0 Then
                    strRepresentante = vetRep(0).ToString
                    Me.nbcEraSystems.ActiveGroup.Caption = vetRep(0).ToString
                    Me.lblTel.Text = vetRep(1).ToString
                    If vetRep(2).ToString <> "" Then
                        Me.lblTel.Text += " / " & vetRep(2).ToString
                    End If
                    strEmailRepresentante = vetRep(3).ToString.ToLower
                    Me.lblEmail.Text = vetRep(3).ToString.ToLower
                    Me.lblSkype.Text = vetRep(4).ToString.ToLower
                    Me.lblEraSystems.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Representante = True
                End If

            End If
        End If

        bolRepresentanteOK = True
    End Sub


    Private Sub InitSkinGallery()
        Dim imageButton As SimpleButton = New SimpleButton()
        For Each cnt As SkinContainer In SkinManager.Default.Skins
            imageButton.LookAndFeel.SetSkinStyle(cnt.SkinName)
            Dim gItem As GalleryItem = New GalleryItem()
            Dim groupIndex As Integer = 0
            If cnt.SkinName.IndexOf("Office") > -1 Then
                groupIndex = 1
            End If
            rgbiSkins.Gallery.Groups(groupIndex).Items.Add(gItem)
            gItem.Caption = cnt.SkinName

            gItem.Image = GetSkinImage(imageButton, 32, 17, 2)
            gItem.HoverImage = GetSkinImage(imageButton, 70, 36, 5)
            gItem.Caption = cnt.SkinName
            gItem.Hint = cnt.SkinName
            rgbiSkins.Gallery.Groups(1).Visible = False
        Next cnt
    End Sub

    Private Function GetSkinImage(ByVal button As SimpleButton, ByVal width As Integer, ByVal height As Integer, ByVal indent As Integer) As Bitmap
        Dim image As Bitmap = New Bitmap(width, height)
        Using g As Graphics = Graphics.FromImage(image)
            Dim info As StyleObjectInfoArgs = New StyleObjectInfoArgs(New GraphicsCache(g))
            info.Bounds = New Rectangle(0, 0, width, height)
            button.LookAndFeel.Painter.GroupPanel.DrawObject(info)
            button.LookAndFeel.Painter.Border.DrawObject(info)
            info.Bounds = New Rectangle(indent, indent, width - indent * 2, height - indent * 2)
            button.LookAndFeel.Painter.Button.DrawObject(info)
        End Using
        Return image
    End Function

    Private Sub RibbonGalleryBarItem2_Gallery_InitDropDownGallery(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.Ribbon.InplaceGalleryEventArgs) Handles rgbiSkins.Gallery.InitDropDownGallery
        e.PopupGallery.CreateFrom(rgbiSkins.Gallery)
        e.PopupGallery.AllowFilter = False
        e.PopupGallery.ShowItemText = True
        e.PopupGallery.ShowGroupCaption = True
        e.PopupGallery.AllowHoverImages = False
        For Each galleryGroup As GalleryItemGroup In e.PopupGallery.Groups
            For Each item As GalleryItem In galleryGroup.Items
                item.Image = item.HoverImage
            Next item
        Next galleryGroup
        e.PopupGallery.ColumnCount = 2
        e.PopupGallery.ImageSize = New Size(70, 36)

    End Sub

    Private Sub RibbonGalleryBarItem2_Gallery_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs) Handles rgbiSkins.Gallery.ItemClick
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(e.Item.Caption)
        SkinDoUsuario = e.Item.Caption
        Atualizar("Update Usuario set Skin ='" & e.Item.Caption & "' WHERE Login ='" & Login & "' and Senha ='" & Senha & "'")
    End Sub

    Private Sub BarButtonItem17_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        frmPagar.Show()
    End Sub

    Private Sub BarButtonItem20_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        Me.Close()
    End Sub

    Private Sub BtnSenha_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSenha.ItemClick
        frmSenha.ShowDialog()
    End Sub


    Private Sub btnUsu_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUsu.ItemClick
        frmUsuarios.Show()
    End Sub

    Private Sub btnNFItens_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNFItens.ItemClick
        frmConNF.Show()
    End Sub

    Private Sub btnRelLucro_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelLucro.ItemClick
        frmRelLucro.Show()
    End Sub

    Private Sub BarButtonItem26_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem26.ItemClick
       
        frmEntradaNF.Show()

    End Sub

    Private Sub BarButtonItem27_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem27.ItemClick
        frmEntradaNF.Tag = "ALTERA"
        frmEntradaNF.Show()

    End Sub

    Private Sub BarButtonItem28_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRel23.ItemClick
        Dim frm As New frmEntradaNF
        frm.Tag = "CONSULTA"
        frm.Show()
   
    End Sub

    Private Sub BarButtonItem25_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick
      
        Dim frm As New frmEntradaNF
        frm.Tag = "CANCELA"
        frm.Show()

    End Sub

    Private Sub btnCadFunc_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCadFunc.ItemClick
        frmCadFuncionario.Show()
    End Sub

    Private Sub btnCadProd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCadProd.ItemClick
        frmCadProduto.Tag = "CADASTRA"
        frmCadProduto.Show()
    End Sub

    Private Sub btnCadGrp_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCadGrp.ItemClick
        frmGrupo.Show()
    End Sub

    Private Sub btnBackUp_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBackUp.ItemClick
        frmBackUP.Show()
    End Sub

    Private Sub btnRest_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRest.ItemClick
        Dim frm As New frmBackUP
        frm.Tag = "DESCOMPACTAR"
        frm.Show()
    End Sub

    Private Sub btnCaixa_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCaixa.ItemClick
        frmCaixa.Show()
    End Sub

    Private Sub btnSacados_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSacados.ItemClick
        If Not IO.File.Exists("C:\NFP_Raisa.txt") Then
            IO.File.Create("C:\NFP_Raisa.txt").Close()
        End If
        If IO.File.Exists("C:\NFP_Raisa.txt") Then


            Dim strOTexto As String = ""
            Dim strCNPJEmitente, strDataInicial, strDataFinal As String

            strCNPJEmitente = "44546162000103"
            strDataInicial = "05/11/2010"
            strDataFinal = "05/11/2010"

            'REGISTRO TIPO 10
            strOTexto &= "10|1,00|" & strCNPJEmitente & "|" & strDataInicial & "|" & strDataFinal & vbCrLf


            'REGISTRO TIPO 20

            Dim strFuncaoRegistro, strJustificativa, strNatOP, strSerieNF, strNumNF, strDataEmis, strDataSai, strTipoNF, strCFOP, strIEST, strIM, strCPF, strNome, strEnd, strNum, strComp, strBai, strCid, strUF, strCEP, strPais, strTel, strIEDest As String

            strFuncaoRegistro = "I" ' I – Inclusão do registro da NF, R – Retificação do registro da NF, C – Cancelamento da NF
            strJustificativa = ""
            strNatOP = "Venda a Consumidor Final"
            strSerieNF = 0
            strNumNF = 1
            strDataEmis = "05/11/2010 11:02:21"
            strDataSai = "05/11/2010 11:02:21"
            strTipoNF = 1 '0-entrada / 1-saída
            strCFOP = 5102
            strIEST = ""
            strIM = ""
            strCPF = "34328799894"

            strNome = "Eder Araújo"
            strEnd = "Rua Laura Fachini Tomaseto"
            strNum = "95"
            strComp = ""
            strBai = "Jd. Morada do Sol"
            strCid = "Indaiatuba"
            strUF = "SP"
            strCEP = "13348560"
            strPais = ""
            strTel = "39352158"
            strIEDest = ""

            strOTexto &= "20|" & strFuncaoRegistro & "|" & strJustificativa & "|" & strNatOP & "|" & strSerieNF & "|" & strNumNF & "|" & strDataEmis & "|" & strDataSai & "|" & strTipoNF & "|" & strCFOP & "|" & strIEST & "|" & strIM & "|" & strCPF & "|" & strNome & "|" & strEnd & "|" & strNum & "|" & strComp & "|" & strBai & "|" & strCid & "|" & strUF & "|" & strCEP & "|" & strPais & "|" & strTel & "|" & strIEDest & vbCrLf


            'REGISTRO TIPO 30
            Dim strCodPro, strProd, strCodNCM, strUM, strQtd, strValUni, strValTot, strCST, strAliqICMS, strAliqIPI, strValIPI As String

            strCodPro = "01"
            strProd = "SABONETE LÍQUIDO"
            strCodNCM = ""
            strUM = "UN"
            strQtd = "1,0000"
            strValUni = "5,0000"
            strValTot = "5,00"
            strCST = "010"
            strAliqICMS = "18,00"
            strAliqIPI = "5,00"
            strValIPI = "10,00"

            strOTexto &= "30|" & strCodPro & "|" & strProd & "|" & strCodNCM & "|" & strUM & "|" & strQtd & "|" & strValUni & "|" & strValTot & "|" & strCST & "|" & strAliqICMS & "|" & strAliqIPI & "|" & strValIPI & vbCrLf

            'REGISTRO TIPO 40

            Dim vBC, vICMS, vBCST, vST, vProd, vFrete, vSeg, vDesc, vIPI, vOutro, vNF, vServ, pISS, vISS As String


            vBC = "18,00"
            vICMS = "0,00"
            vBCST = "0,00"
            vST = "0,00"
            vProd = "5,00"
            vFrete = "0,00"
            vSeg = "0,00"
            vDesc = "0,00"
            vIPI = "0,00"
            vOutro = "0,00"
            vNF = "5,00"
            vServ = "0,00"
            pISS = "0,00"
            vISS = "0,00"

            strOTexto &= "40|" & vBC & "|" & vICMS & "|" & vBCST & "|" & vST & "|" & vProd & "|" & vFrete & "|" & vSeg & "|" & vDesc & "|" & vIPI & "|" & vOutro & "|" & vNF & "|" & vServ & "|" & pISS & "|" & vISS & vbCrLf


            'REGISTRO TIPO 50

            Dim modFrete, CNPJTrans, xNome, IETrans, xEnder, xMun, UF, placa, UFPlaca, qVol, esp, marca, nVol, pesoL, pesoB As String

            modFrete = 1
            CNPJTrans = ""
            xNome = ""
            IETrans = ""
            xEnder = ""
            xMun = ""
            UF = ""
            placa = ""
            UFPlaca = ""
            qVol = ""
            esp = ""
            marca = ""
            nVol = ""
            pesoL = ""
            pesoB = ""

            strOTexto &= "50|" & modFrete & "|" & CNPJTrans & "|" & xNome & "|" & IETrans & "|" & xEnder & "|" & xMun & "|" & UF & "|" & placa & "|" & UFPlaca & "|" & qVol & "|" & esp & "|" & marca & "|" & nVol & "|" & pesoL & "|" & pesoB & vbCrLf



            'REGISTRO TIPO 60

            Dim Fatura, infAdFisco, infCpl As String

            Fatura = ""
            infAdFisco = ""
            infCpl = ""

            strOTexto &= "60|" & Fatura & "|" & infAdFisco & "|" & infCpl & vbCrLf


            'REGISTRO TIPO 90

            Dim strQtdReg20, strQtdReg30, strQtdReg40, strQtdReg50, strQtdReg60 As String

            strQtdReg20 = "00001"
            strQtdReg30 = "00001"
            strQtdReg40 = "00001"
            strQtdReg50 = "00001"
            strQtdReg60 = "00001"


            strOTexto &= "90|" & strQtdReg20 & "|" & strQtdReg30 & "|" & strQtdReg40 & "|" & strQtdReg50 & "|" & strQtdReg60


            IO.File.WriteAllText("C:\NFP_Raisa.txt", strOTexto)

        End If

    End Sub


    Private Sub btnConsumo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConsumo.ItemClick
        frmRelConsumo.Show()
    End Sub

    Private Sub btnSomadoTot_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSomadoTot.ItemClick
        Dim frm As New frmRelFormPag
        frm.Tag = "SOMADO"
        frm.Show()
    End Sub

    Private Sub btnSomadoCar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSomadoCar.ItemClick
        frmRelFuturo.Show()
    End Sub

    Private Sub btnDetalhadoTot_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDetalhadoTot.ItemClick
        Dim frm As New frmRelFormPag
        frm.Tag = "DETALHADO"
        frm.Show()
    End Sub

    Private Sub btnDetalhadoCar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDetalhadoCar.ItemClick
        frmRelRecFut.Show()
    End Sub

    Private Sub btnBloqUsu_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBloqUsu.ItemClick
        frmBloqueio.Show()
    End Sub

    Private Sub btnCadPagamento_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCadPagamento.ItemClick
        Dim frm As New frmPagamento
        frm.Show()
    End Sub

    Private Sub btnDevolução_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDevolução.ItemClick
        frmDevolucao.Show()
    End Sub

    Private Sub btnDev_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDev.ItemClick
        frmRelDevolucao.Show()
    End Sub

    Private Sub nbcAvisos_NavPaneStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nbcAvisos.NavPaneStateChanged
        If nbcAvisos.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed Then
            Me.nbgConRec.Caption = "Avisos Nano"
            Me.nbgConPag.Caption = "Avisos Nano"
            Me.nbgAniv.Caption = "Avisos Nano"

        Else
            Me.nbgConRec.Caption = "Contas a Receber Hoje"
            Me.nbgConPag.Caption = "Contas a Pagar Hoje"
            Me.nbgAniv.Caption = "Aniversariantes do Dia"

        End If
    End Sub

    'Private Sub btnOcu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOcu.Click
    '    Me.nbcEra.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
    '    Me.nbcEra.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
    'End Sub

    'Private Sub nbcEra_NavPaneStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nbcEra.NavPaneStateChanged
    '    If nbcEra.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed Then
    '        Me.nbcEra.OptionsNavPane.ShowOverflowPanel = False
    '        Me.nbgEra.Caption = "Suporte Nano"
    '        Me.nbcEra.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
    '        Me.btnOcu.Visible = False
    '    Else
    '        Me.nbgEra.Caption = "Era Systems"
    '        Me.nbcEra.OptionsNavPane.ShowOverflowPanel = True
    '        Me.nbcEra.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar
    '        Me.btnOcu.Visible = True
    '    End If
    'End Sub

    Private Sub ConfigBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ConfigBindingSource.EndEdit()
        Me.ConfigTableAdapter.Update(Me.DsNano.Config)
    End Sub

    Private Sub btnConfg_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConfig.ItemClick
        frmConfig.ShowDialog()
        CarregaConfiguracoes()
    End Sub

    Private Sub btnLog_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLog.ItemClick
        frmRelLog.Show()
    End Sub

    'Private Sub btnOPaf_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOPaf.ItemClick
    '    System.Diagnostics.Process.Start("C:\OPaf\OPaf.exe")
    '    System.Diagnostics.Process.Start("C:\Program Files\ID Brasil\OPaf\Integrador\Integrador.exe")

    'End Sub

    'Private Sub btnGerArqsCF_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGerArqsCF.ItemClick
    '    Dim intNumArqs As Integer

    '    intNumArqs = ArqUsuario("TUDO", False)

    '    intNumArqs += ArqCliente("TUDO", False)

    '    intNumArqs += ArqProduto("TUDO", False)

    '    intNumArqs += ArqPagamento("TUDO", False)

    '    EscreveArquivosCupom("TUDO", intNumArqs)
    '    MsgBox("Arquivos gerados com sucesso!", MsgBoxStyle.Information)

    'End Sub

    Private Sub btnCadBanco_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCadBanco.ItemClick
        BaixarCartoes()
        If CobreBemNano = False Then
            frmCadBanco.Show()
        Else
            frmConfigBoleto.Show()
        End If

    End Sub

    Private Sub btnMovBanco_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMovBanco.ItemClick
        BaixarCartoes()
        frmMovBancario.Tag = "MOVIMENTACAO"
        frmMovBancario.Show()
    End Sub

    Private Sub btnMovimentacao_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMovimentacao.ItemClick
        BaixarCartoes()
        frmRelMovBanco.Show()
    End Sub

    Private Sub btnTeam_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTeam.ItemClick
        Try
            If IO.File.Exists(My.Application.Info.DirectoryPath.Replace("Debug", "Suporte")) = False Then
                IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath.Replace("Debug", "Suporte"))
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath.Replace("Debug", "Suporte") & "\TeamViewerQS.exe") = False Then
                Dim wc As New System.Net.WebClient()
                wc.DownloadFile("https://sites.google.com/site/cotroles/suporte/TeamViewerQS.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath.Replace("Debug", "Suporte") & "\TeamViewerQS.gz")
                descompactaArquivo(My.Application.Info.DirectoryPath.Replace("Debug", "Suporte") & "\TeamViewerQS.gz", My.Application.Info.DirectoryPath.Replace("Debug", "Suporte") & "\TeamViewerQS.exe")
                System.IO.File.Delete(My.Application.Info.DirectoryPath.Replace("Debug", "Suporte") & "\TeamViewerQS.gz")
            End If
            Try
                System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath.Replace("Debug", "Suporte") & "\" & "TeamViewerQS.exe")

            Catch ex As Exception
                MsgBox("Ocorreu uma falha ao iniciar o teamviewer!", MsgBoxStyle.Information)
            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnShow_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnShow.ItemClick
        Try
            If IO.File.Exists(My.Application.Info.DirectoryPath.Replace("Debug", "Suporte")) = False Then
                IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath.Replace("Debug", "Suporte"))
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath.Replace("Debug", "Suporte") & "\AnyDesk.exe") = False Then
                Dim wc As New System.Net.WebClient()
                wc.DownloadFile("https://sites.google.com/site/cotroles/suporte/AnyDesk.gz?attredirects=0&d=1", My.Application.Info.DirectoryPath.Replace("Debug", "Suporte") & "\AnyDesk.gz")
                descompactaArquivo(My.Application.Info.DirectoryPath.Replace("Debug", "Suporte") & "\AnyDesk.gz", My.Application.Info.DirectoryPath.Replace("Debug", "Suporte") & "\AnyDesk.exe")
                System.IO.File.Delete(My.Application.Info.DirectoryPath.Replace("Debug", "Suporte") & "\AnyDesk.gz")

            End If
            Try
                System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath.Replace("Debug", "Suporte") & "\" & "AnyDesk.exe")

            Catch ex As Exception
                MsgBox("Ocorreu uma falha ao iniciar o anydesk!", MsgBoxStyle.Information)
            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnVenda_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVenda.ItemClick
        frmVenda.Show()
    End Sub

    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        If SenhaEstaOK() = False Then Exit Sub
        frmDesfaturar.ShowDialog()
    End Sub

    Private Sub btnDescarte_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDescarte.ItemClick
        frmDescarte.Show()
    End Sub

    Private Sub btnCadReceita_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCadReceita.ItemClick
        Dim frm As New frmReceita
        frm.Tag = "CADASTRA"
        frm.Show()
    End Sub

    Private Sub btnAltReceita_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAltReceita.ItemClick
        frmReceita.Tag = "ALTERA"
        frmReceita.Show()
    End Sub

    Private Sub btnConReceita_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConReceita.ItemClick
        frmReceita.Tag = "CONSULTA"
        frmReceita.Show()
    End Sub

    Private Sub btnPlanoFundo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPlanoFundo.ItemClick
        Dim frm As New frmPlanoFundo
        frm.ShowDialog()

        PlanoFundo()
    End Sub

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        Dim rel As New relAniversariantes
        rel.picLogo.Image = LogoTipo
        Dim strData As String = "Day(Nascimento) ='" & Date.Today.Day & "' and Month(Nascimento) ='" & Date.Today.Month & "'"

        Dim dt As DataTable = CarregarDataTable("Select Nome, Telefone , Celular, Nascimento, Email from Cliente where " & strData)
        If dt.Rows.Count > 0 Then
            Dim I As Integer
            For I = 0 To dt.Rows.Count - 1
                Dim dtA As Date = dt.Rows.Item(I).Item("Nascimento").ToString
                rel.tbAniv.Rows.Add()
                rel.tbAniv.Rows.Item(I).Item("Nome") = dt.Rows.Item(I).Item("Nome").ToString
                rel.tbAniv.Rows.Item(I).Item("Data") = String.Format("{0:dd/MM}", dtA)
                rel.tbAniv.Rows.Item(I).Item("Email") = dt.Rows.Item(I).Item("Email").ToString
                rel.tbAniv.Rows.Item(I).Item("Tel1") = dt.Rows.Item(I).Item("Telefone").ToString
                rel.tbAniv.Rows.Item(I).Item("Tel2") = dt.Rows.Item(I).Item("Celular").ToString

            Next
            rel.lblTotal.Text = dt.Rows.Count
            rel.ShowPreview()
        Else
            MsgBox("Nenhum cliente faz aniversário hoje!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnIndice_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnIndice.ItemClick

        Dim strFiltro As String = ""

        If Master = False Then
            strFiltro = " and CodConfig =" & CodConfig
        End If

        Dim strData As String = ""
        Dim dblTotal As Double = 0
        Dim dblTrinta, dblPorTrinta, dblTrintaPagar As Double
        Dim dblSessenta, dblPorSessenta, dblSessentaPagar As Double
        Dim dblNoventa, dblPorNoventa, dblNoventaPagar As Double
        Dim dblCem, dblPorCem, dblCemPagar As Double
        Dim dblCemMais, dblPorCemMais, dblCemMaisPagar As Double

        Dim dtData As Date = Date.Today.AddMonths(-1)
        Dim strDataMes As String = Month(dtData)
        Dim strDataAno As String = Year(dtData)
        Dim dt1 As DataTable = CarregarDataTable("SELECT Convert(Numeric(15,2),sum(ValorParcela)) FROM ContaReceber where month(Vencimento) = '" & strDataMes & "' and year(Vencimento) = '" & strDataAno & "'" & strFiltro)
        If dt1.Rows.Item(0).ItemArray(0).ToString <> "" Then
            dblTrinta = dt1.Rows.Item(0).ItemArray(0).ToString
        Else
            dblTrinta = 0
        End If

        Dim dt1Pagar As DataTable = CarregarDataTable("SELECT Convert(Numeric(15,2),sum(ValorParcela)) FROM ContaReceber where month(Vencimento) = '" & strDataMes & "' and year(Vencimento) = '" & strDataAno & "'" & strFiltro & " and RecebidoOK = 'False'")
        If dt1Pagar.Rows.Item(0).ItemArray(0).ToString <> "" Then
            dblTrintaPagar = dt1Pagar.Rows.Item(0).ItemArray(0).ToString
        Else
            dblTrintaPagar = 0
        End If

        dblPorTrinta = (dblTrintaPagar / dblTrinta) * 100
        Dim str As String = dblPorTrinta
        str = dblPorTrinta
        If str = "NaN (Não é um número)" Or str = "+Infinito" Then
            dblPorTrinta = 0
        End If


        dtData = Date.Today.AddMonths(-2)
        strDataMes = Month(dtData)
        strDataAno = Year(dtData)

        Dim dt2 As DataTable = CarregarDataTable("SELECT Convert(Numeric(15,2),sum(ValorParcela)) FROM ContaReceber where month(Vencimento) = '" & strDataMes & "' and year(Vencimento) = '" & strDataAno & "'" & strFiltro)
        If dt2.Rows.Item(0).ItemArray(0).ToString <> "" Then
            dblSessenta = dt2.Rows.Item(0).ItemArray(0).ToString
        Else
            dblSessenta = 0
        End If

        Dim dt2Pagar As DataTable = CarregarDataTable("SELECT Convert(Numeric(15,2),sum(ValorParcela)) FROM ContaReceber where month(Vencimento) = '" & strDataMes & "' and year(Vencimento) = '" & strDataAno & "'" & strFiltro & " and RecebidoOK = 'False'")
        If dt2Pagar.Rows.Item(0).ItemArray(0).ToString <> "" Then
            dblSessentaPagar = dt2Pagar.Rows.Item(0).ItemArray(0).ToString
        Else
            dblSessentaPagar = 0
        End If

        dblPorSessenta = (dblSessentaPagar / dblSessenta) * 100

        str = dblPorSessenta
        If str = "NaN (Não é um número)" Or str = "+Infinito" Then
            dblPorSessenta = 0
        End If

        dtData = Date.Today.AddMonths(-3)
        strDataMes = Month(dtData)
        strDataAno = Year(dtData)

        Dim dt3 As DataTable = CarregarDataTable("SELECT Convert(Numeric(15,2),sum(ValorParcela)) FROM ContaReceber where month(Vencimento) = '" & strDataMes & "' and year(Vencimento) = '" & strDataAno & "'" & strFiltro)

        If dt3.Rows.Item(0).ItemArray(0).ToString <> "" Then
            dblNoventa = dt3.Rows.Item(0).ItemArray(0).ToString
        Else
            dblNoventa = 0
        End If

        Dim dt3Pagar As DataTable = CarregarDataTable("SELECT Convert(Numeric(15,2),sum(ValorParcela)) FROM ContaReceber where month(Vencimento) = '" & strDataMes & "' and year(Vencimento) = '" & strDataAno & "'" & strFiltro & " and RecebidoOK = 'False'")
        If dt3Pagar.Rows.Item(0).ItemArray(0).ToString <> "" Then
            dblNoventaPagar = dt3Pagar.Rows.Item(0).ItemArray(0).ToString
        Else
            dblNoventaPagar = 0
        End If
        dblPorNoventa = (dblNoventaPagar / dblNoventa) * 100

        str = dblPorNoventa
        If str = "NaN (Não é um número)" Or str = "+Infinito" Then
            dblPorNoventa = 0
        End If

        dtData = Date.Today.AddMonths(-4)
        strDataMes = Month(dtData)
        strDataAno = Year(dtData)

        Dim dt4 As DataTable = CarregarDataTable("SELECT Convert(Numeric(15,2),sum(ValorParcela)) FROM ContaReceber where month(Vencimento) = '" & strDataMes & "' and year(Vencimento) = '" & strDataAno & "'" & strFiltro)
        If dt4.Rows.Item(0).ItemArray(0).ToString <> "" Then
            dblCem = dt4.Rows.Item(0).ItemArray(0).ToString
        Else
            dblCem = 0
        End If

        Dim dt4Pagar As DataTable = CarregarDataTable("SELECT Convert(Numeric(15,2),sum(ValorParcela)) FROM ContaReceber where month(Vencimento) = '" & strDataMes & "' and year(Vencimento) = '" & strDataAno & "'" & strFiltro & " and RecebidoOK = 'False'")
        If dt4Pagar.Rows.Item(0).ItemArray(0).ToString <> "" Then
            dblCemPagar = dt4Pagar.Rows.Item(0).ItemArray(0).ToString
        Else
            dblCemPagar = 0
        End If
        dblPorCem = (dblCemPagar / dblCem) * 100

        str = dblPorCem
        If str = "NaN (Não é um número)" Or str = "+Infinito" Then
            dblPorCem = 0
        End If

        dtData = Date.Today.AddMonths(-5)
        strDataMes = Month(dtData)
        strDataAno = Year(dtData)
        Dim strDia As String = Date.DaysInMonth(dtData.Year, dtData.Month)

        dtData = strDia & "/" & strDataMes & "/" & strDataAno

        Dim dt5 As DataTable = CarregarDataTable("SELECT Convert(Numeric(15,2),sum(ValorParcela)) FROM ContaReceber where Vencimento <= '" & dtData & "'" & strFiltro)
        'Dim dt5 As DataTable = CarregarDataTable("SELECT Convert(Numeric(15,2),sum(ValorParcela)) FROM ContaReceber where month(Vencimento) <= '" & strDataMes & "' and year(Vencimento) <= '" & strDataAno & "'" & strFiltro)

        If dt5.Rows.Item(0).ItemArray(0).ToString <> "" Then
            dblCemMais = dt5.Rows.Item(0).ItemArray(0).ToString
        Else
            dblCemMais = 0
        End If


        Dim dt5Pagar As DataTable = CarregarDataTable("SELECT Convert(Numeric(15,2),sum(ValorParcela)) FROM ContaReceber where Vencimento <= '" & dtData & "'" & strFiltro & " and RecebidoOK = 'False'")
        'Dim dt5Pagar As DataTable = CarregarDataTable("SELECT Convert(Numeric(15,2),sum(ValorParcela)) FROM ContaReceber where month(Vencimento) <= '" & strDataMes & "' and year(Vencimento) <= '" & strDataAno & "'" & strFiltro & " and RecebidoOK = 'False'")

        If dt5Pagar.Rows.Item(0).ItemArray(0).ToString <> "" Then
            dblCemMaisPagar = dt5Pagar.Rows.Item(0).ItemArray(0).ToString
        Else
            dblCemMaisPagar = 0
        End If
        dblPorCemMais = (dblCemMaisPagar / dblCemMais) * 100

        str = dblPorCemMais
        If str = "NaN (Não é um número)" Or str = "+Infinito" Then
            dblPorCemMais = 0
        End If

        Dim rel As New relIndiceInad
        rel.picLogo.Image = LogoTipo
        rel.lblTitulo2.Text = "Data Base - " & Date.Today

        rel.lblTrintaVendido.Text = dblTrinta.ToString("###,###,##0.00")
        rel.lblSessentaVendido.Text = dblSessenta.ToString("###,###,##0.00")
        rel.lblNoventaVendido.Text = dblNoventa.ToString("###,###,##0.00")
        rel.lblVinteVendido.Text = dblCem.ToString("###,###,##0.00")
        rel.lblAcimaVendido.Text = dblCemMais.ToString("###,###,##0.00")

        rel.lblTrintaAtraso.Text = dblTrintaPagar.ToString("###,###,##0.00")
        rel.lblSessentaAtraso.Text = dblSessentaPagar.ToString("###,###,##0.00")
        rel.lblNoventaAtraso.Text = dblNoventaPagar.ToString("###,###,##0.00")
        rel.lblVinteAtraso.Text = dblCemPagar.ToString("###,###,##0.00")
        rel.lblAcimaAtraso.Text = dblCemMaisPagar.ToString("###,###,##0.00")

        rel.lblTrintaIndice.Text = dblPorTrinta.ToString("###,###,##0.00")
        rel.lblSessentaIndice.Text = dblPorSessenta.ToString("###,###,##0.00")
        rel.lblNoventaIndice.Text = dblPorNoventa.ToString("###,###,##0.00")
        rel.lblVinteIndice.Text = dblPorCem.ToString("###,###,##0.00")
        rel.lblAcimaIndice.Text = dblPorCemMais.ToString("###,###,##0.00")

        Dim dblTotalVendido As Double = dblTrinta + dblSessenta + dblNoventa + dblCem + dblCemMais
        Dim dblTotalAtraso As Double = dblTrintaPagar + dblSessentaPagar + dblNoventaPagar + dblCemPagar + dblCemMaisPagar
        rel.lblTotalVendido.Text = dblTotalVendido.ToString("###,###,##0.00")
        rel.lblTotalAtraso.Text = dblTotalAtraso.ToString("###,###,##0.00")

        Dim dblTotalIndice As Double = (dblTotalAtraso / dblTotalVendido) * 100

        rel.lblTotalIndice.Text = dblTotalIndice.ToString("###,###,##0.00")
        Dim A As Integer
        Dim bolAno, bolAno2, bolAno3 As Boolean
        bolAno = False
        bolAno2 = False
        bolAno3 = False
        For A = 0 To 2


            Dim dblVenJan, dblVenFev, dblVenMar, dblVenAbr, dblVenMai, dblVenJun, dblVenJul, dblVenAgo, dblVenSet, dblVenOut, dblVenNov, dblVenDez As Double
            Dim dtRecebido As DataTable = CarregarDataTable("SELECT sum(ValorParcela) as Valor, month(Vencimento) as Mes FROM ContaReceber where year(Vencimento) = " & Year(Now) - 1 + A & strFiltro & " group by month(Vencimento) order by month(Vencimento)")
            Dim dtReceber As DataTable = CarregarDataTable("SELECT sum(ValorParcela) as Valor, month(Vencimento) as Mes FROM ContaReceber where year(Vencimento) = " & Year(Now) - 1 + A & strFiltro & " and RecebidoOk = 'False' group by month(Vencimento) order by month(Vencimento)")

            Dim I As Integer
            Select Case A
                Case 0
                    For I = 0 To dtRecebido.Rows.Count - 1
                        Dim strMes As String = dtRecebido.Rows.Item(I).Item("Mes").ToString
                        Dim dblValor As Double = dtRecebido.Rows.Item(I).Item("Valor").ToString

                        Select Case strMes
                            Case "1"
                                rel.lblVenJan.Text = dblValor.ToString("###,###,##0.00")
                                dblVenJan = dblValor.ToString("0.00")
                            Case "2"
                                rel.lblVenFev.Text = dblValor.ToString("###,###,##0.00")
                                dblVenFev = dblValor.ToString("0.00")
                            Case "3"
                                rel.lblVenMar.Text = dblValor.ToString("###,###,##0.00")
                                dblVenMar = dblValor.ToString("0.00")
                            Case "4"
                                rel.lblVenAbr.Text = dblValor.ToString("###,###,##0.00")
                                dblVenAbr = dblValor.ToString("0.00")
                            Case "5"
                                rel.lblVenMai.Text = dblValor.ToString("###,###,##0.00")
                                dblVenMai = dblValor.ToString("0.00")
                            Case "6"
                                rel.lblVenJun.Text = dblValor.ToString("###,###,##0.00")
                                dblVenJun = dblValor.ToString("0.00")
                            Case "7"
                                rel.lblVenJul.Text = dblValor.ToString("###,###,##0.00")
                                dblVenJul = dblValor.ToString("0.00")
                            Case "8"
                                rel.lblVenAgo.Text = dblValor.ToString("###,###,##0.00")
                                dblVenAgo = dblValor.ToString("0.00")
                            Case "9"
                                rel.lblVenSet.Text = dblValor.ToString("###,###,##0.00")
                                dblVenSet = dblValor.ToString("0.00")
                            Case "10"
                                rel.lblVenOut.Text = dblValor.ToString("###,###,##0.00")
                                dblVenOut = dblValor.ToString("0.00")
                            Case "11"
                                rel.lblVenNov.Text = dblValor.ToString("###,###,##0.00")
                                dblVenNov = dblValor.ToString("0.00")
                            Case "12"
                                rel.lblVenDez.Text = dblValor.ToString("###,###,##0.00")
                                dblVenDez = dblValor.ToString("0.00")
                        End Select
                    Next
                    For I = 0 To dtReceber.Rows.Count - 1
                        bolAno = True
                        Dim strMes As String = dtReceber.Rows.Item(I).Item("Mes").ToString
                        Dim dblValor As Double = dtReceber.Rows.Item(I).Item("Valor").ToString
                        Dim dblResul As Double
                        Select Case strMes
                            Case "1"
                                rel.lblRecJan.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenJan) * 100
                                rel.lblPerJan.Text = dblResul.ToString("###,###,##0.00")
                            Case "2"
                                rel.lblRecFev.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenFev) * 100
                                rel.lblPerFev.Text = dblResul.ToString("###,###,##0.00")
                            Case "3"
                                rel.lblRecMar.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenMar) * 100
                                rel.lblPerMar.Text = dblResul.ToString("###,###,##0.00")
                            Case "4"
                                rel.lblRecAbr.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenAbr) * 100
                                rel.lblPerAbr.Text = dblResul.ToString("###,###,##0.00")
                            Case "5"
                                rel.lblRecMai.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenMai) * 100
                                rel.lblPerMai.Text = dblResul.ToString("###,###,##0.00")
                            Case "6"
                                rel.lblRecJun.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenJun) * 100
                                rel.lblPerJun.Text = dblResul.ToString("###,###,##0.00")
                            Case "7"
                                rel.lblRecJul.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenJul) * 100
                                rel.lblPerJul.Text = dblResul.ToString("###,###,##0.00")
                            Case "8"
                                rel.lblRecAgo.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenAgo) * 100
                                rel.lblPerAgo.Text = dblResul.ToString("###,###,##0.00")
                            Case "9"
                                rel.lblRecSet.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenSet) * 100
                                rel.lblPerSet.Text = dblResul.ToString("###,###,##0.00")
                            Case "10"
                                rel.lblRecOut.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenOut) * 100
                                rel.lblPerOut.Text = dblResul.ToString("###,###,##0.00")
                            Case "11"
                                rel.lblRecNov.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenNov) * 100
                                rel.lblPerNov.Text = dblResul.ToString("###,###,##0.00")
                            Case "12"
                                rel.lblRecDez.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenDez) * 100
                                rel.lblPerDez.Text = dblResul.ToString("###,###,##0.00")
                        End Select
                    Next
                    rel.lblAno.Text = Year(Now) - 1 + A
                Case 1
                    For I = 0 To dtRecebido.Rows.Count - 1
                        Dim strMes As String = dtRecebido.Rows.Item(I).Item("Mes").ToString
                        Dim dblValor As Double = dtRecebido.Rows.Item(I).Item("Valor").ToString

                        Select Case strMes
                            Case "1"
                                rel.lblVenJan2.Text = dblValor.ToString("###,###,##0.00")
                                dblVenJan = dblValor.ToString("0.00")
                            Case "2"
                                rel.lblVenFev2.Text = dblValor.ToString("###,###,##0.00")
                                dblVenFev = dblValor.ToString("0.00")
                            Case "3"
                                rel.lblVenMar2.Text = dblValor.ToString("###,###,##0.00")
                                dblVenMar = dblValor.ToString("0.00")
                            Case "4"
                                rel.lblVenAbr2.Text = dblValor.ToString("###,###,##0.00")
                                dblVenAbr = dblValor.ToString("0.00")
                            Case "5"
                                rel.lblVenMai2.Text = dblValor.ToString("###,###,##0.00")
                                dblVenMai = dblValor.ToString("0.00")
                            Case "6"
                                rel.lblVenJun2.Text = dblValor.ToString("###,###,##0.00")
                                dblVenJun = dblValor.ToString("0.00")
                            Case "7"
                                rel.lblVenJul2.Text = dblValor.ToString("###,###,##0.00")
                                dblVenJul = dblValor.ToString("0.00")
                            Case "8"
                                rel.lblVenAgo2.Text = dblValor.ToString("###,###,##0.00")
                                dblVenAgo = dblValor.ToString("0.00")
                            Case "9"
                                rel.lblVenSet2.Text = dblValor.ToString("###,###,##0.00")
                                dblVenSet = dblValor.ToString("0.00")
                            Case "10"
                                rel.lblVenOut2.Text = dblValor.ToString("###,###,##0.00")
                                dblVenOut = dblValor.ToString("0.00")
                            Case "11"
                                rel.lblVenNov2.Text = dblValor.ToString("###,###,##0.00")
                                dblVenNov = dblValor.ToString("0.00")
                            Case "12"
                                rel.lblVenDez2.Text = dblValor.ToString("###,###,##0.00")
                                dblVenDez = dblValor.ToString("0.00")
                        End Select
                    Next
                    For I = 0 To dtReceber.Rows.Count - 1
                        bolAno2 = True
                        Dim strMes As String = dtReceber.Rows.Item(I).Item("Mes").ToString
                        Dim dblValor As Double = dtReceber.Rows.Item(I).Item("Valor").ToString
                        Dim dblResul As Double
                        Select Case strMes
                            Case "1"
                                rel.lblRecJan2.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenJan) * 100
                                rel.lblPerJan2.Text = dblResul.ToString("###,###,##0.00")
                            Case "2"
                                rel.lblRecFev2.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenFev) * 100
                                rel.lblPerFev2.Text = dblResul.ToString("###,###,##0.00")
                            Case "3"
                                rel.lblRecMar2.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenMar) * 100
                                rel.lblPerMar2.Text = dblResul.ToString("###,###,##0.00")
                            Case "4"
                                rel.lblRecAbr2.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenAbr) * 100
                                rel.lblPerAbr2.Text = dblResul.ToString("###,###,##0.00")
                            Case "5"
                                rel.lblRecMai2.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenMai) * 100
                                rel.lblPerMai2.Text = dblResul.ToString("###,###,##0.00")
                            Case "6"
                                rel.lblRecJun2.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenJun) * 100
                                rel.lblPerJun2.Text = dblResul.ToString("###,###,##0.00")
                            Case "7"
                                rel.lblRecJul2.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenJul) * 100
                                rel.lblPerJul2.Text = dblResul.ToString("###,###,##0.00")
                            Case "8"
                                rel.lblRecAgo2.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenAgo) * 100
                                rel.lblPerAgo2.Text = dblResul.ToString("###,###,##0.00")
                            Case "9"
                                rel.lblRecSet2.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenSet) * 100
                                rel.lblPerSet2.Text = dblResul.ToString("###,###,##0.00")
                            Case "10"
                                rel.lblRecOut2.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenOut) * 100
                                rel.lblPerOut2.Text = dblResul.ToString("###,###,##0.00")
                            Case "11"
                                rel.lblRecNov2.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenNov) * 100
                                rel.lblPerNov2.Text = dblResul.ToString("###,###,##0.00")
                            Case "12"
                                rel.lblRecDez2.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenDez) * 100
                                rel.lblPerDez2.Text = dblResul.ToString("###,###,##0.00")
                        End Select
                    Next
                    rel.lblAno2.Text = Year(Now) - 1 + A
                Case 2
                    For I = 0 To dtRecebido.Rows.Count - 1
                        Dim strMes As String = dtRecebido.Rows.Item(I).Item("Mes").ToString
                        Dim dblValor As Double = dtRecebido.Rows.Item(I).Item("Valor").ToString

                        Select Case strMes
                            Case "1"
                                rel.lblVenJan3.Text = dblValor.ToString("###,###,##0.00")
                                dblVenJan = dblValor.ToString("0.00")
                            Case "2"
                                rel.lblVenFev3.Text = dblValor.ToString("###,###,##0.00")
                                dblVenFev = dblValor.ToString("0.00")
                            Case "3"
                                rel.lblVenMar3.Text = dblValor.ToString("###,###,##0.00")
                                dblVenMar = dblValor.ToString("0.00")
                            Case "4"
                                rel.lblVenAbr3.Text = dblValor.ToString("###,###,##0.00")
                                dblVenAbr = dblValor.ToString("0.00")
                            Case "5"
                                rel.lblVenMai3.Text = dblValor.ToString("###,###,##0.00")
                                dblVenMai = dblValor.ToString("0.00")
                            Case "6"
                                rel.lblVenJun3.Text = dblValor.ToString("###,###,##0.00")
                                dblVenJun = dblValor.ToString("0.00")
                            Case "7"
                                rel.lblVenJul3.Text = dblValor.ToString("###,###,##0.00")
                                dblVenJul = dblValor.ToString("0.00")
                            Case "8"
                                rel.lblVenAgo3.Text = dblValor.ToString("###,###,##0.00")
                                dblVenAgo = dblValor.ToString("0.00")
                            Case "9"
                                rel.lblVenSet3.Text = dblValor.ToString("###,###,##0.00")
                                dblVenSet = dblValor.ToString("0.00")
                            Case "10"
                                rel.lblVenOut3.Text = dblValor.ToString("###,###,##0.00")
                                dblVenOut = dblValor.ToString("0.00")
                            Case "11"
                                rel.lblVenNov3.Text = dblValor.ToString("###,###,##0.00")
                                dblVenNov = dblValor.ToString("0.00")
                            Case "12"
                                rel.lblVenDez3.Text = dblValor.ToString("###,###,##0.00")
                                dblVenDez = dblValor.ToString("0.00")
                        End Select
                    Next
                    For I = 0 To dtReceber.Rows.Count - 1
                        bolAno3 = True
                        Dim strMes As String = dtReceber.Rows.Item(I).Item("Mes").ToString
                        Dim dblValor As Double = dtReceber.Rows.Item(I).Item("Valor").ToString
                        Dim dblResul As Double
                        Select Case strMes
                            Case "1"
                                rel.lblRecJan3.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenJan) * 100
                                rel.lblPerJan3.Text = dblResul.ToString("###,###,##0.00")
                            Case "2"
                                rel.lblRecFev3.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenFev) * 100
                                rel.lblPerFev3.Text = dblResul.ToString("###,###,##0.00")
                            Case "3"
                                rel.lblRecMar3.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenMar) * 100
                                rel.lblPerMar3.Text = dblResul.ToString("###,###,##0.00")
                            Case "4"
                                rel.lblRecAbr3.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenAbr) * 100
                                rel.lblPerAbr3.Text = dblResul.ToString("###,###,##0.00")
                            Case "5"
                                rel.lblRecMai3.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenMai) * 100
                                rel.lblPerMai3.Text = dblResul.ToString("###,###,##0.00")
                            Case "6"
                                rel.lblRecJun3.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenJun) * 100
                                rel.lblPerJun3.Text = dblResul.ToString("###,###,##0.00")
                            Case "7"
                                rel.lblRecJul3.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenJul) * 100
                                rel.lblPerJul3.Text = dblResul.ToString("###,###,##0.00")
                            Case "8"
                                rel.lblRecAgo3.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenAgo) * 100
                                rel.lblPerAgo3.Text = dblResul.ToString("###,###,##0.00")
                            Case "9"
                                rel.lblRecSet3.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenSet) * 100
                                rel.lblPerSet3.Text = dblResul.ToString("###,###,##0.00")
                            Case "10"
                                rel.lblRecOut3.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenOut) * 100
                                rel.lblPerOut3.Text = dblResul.ToString("###,###,##0.00")
                            Case "11"
                                rel.lblRecNov3.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenNov) * 100
                                rel.lblPerNov3.Text = dblResul.ToString("###,###,##0.00")
                            Case "12"
                                rel.lblRecDez3.Text = dblValor.ToString("###,###,##0.00")
                                dblResul = (dblValor / dblVenDez) * 100
                                rel.lblPerDez3.Text = dblResul.ToString("###,###,##0.00")
                        End Select
                    Next
                    rel.lblAno3.Text = Year(Now) - 1 + A
            End Select

        Next


        If bolAno3 = False Then
            rel.tabAno3.Visible = False
            If bolAno = False Then
                rel.tabAno.Visible = False
                rel.tabAno2.Location = New System.Drawing.Point(8, 208)
            Else
                rel.tabAno2.Location = New System.Drawing.Point(8, 316)
                rel.tabAno.Location = New System.Drawing.Point(8, 208)
            End If
        Else
            If bolAno = False Then
                rel.tabAno.Visible = False
                rel.tabAno2.Location = New System.Drawing.Point(8, 208)
                rel.tabAno3.Location = New System.Drawing.Point(8, 316)
            End If
        End If


        rel.ShowPreview()
    End Sub


    Private Sub btnComissao_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnComissao.ItemClick
        frmRelComissao.Show()
    End Sub

    Private Sub btnRelVisao_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelVisao.ItemClick
        frmRelVisao.Show()
    End Sub

    Private Sub btnMigracao_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMigracao.ItemClick
        frmMigracao.ShowDialog()
    End Sub

    Private Sub btnQuery_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuery.ItemClick
        frmPesquisaSql.Show()
    End Sub

    Private Sub btnRelDescarte_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelDescarte.ItemClick
        frmRelDescarte.Show()
    End Sub

    Private Sub txtComanda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "a" Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCadTrans_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCadTrans.ItemClick
        Dim frm As New frmTransferencia
        frm.Tag = "CADASTRA"
        frm.Show()
    End Sub

    Private Sub btnAltTrans_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAltTrans.ItemClick
        frmTransferencia.Tag = "ALTERA"
        frmTransferencia.Show()
    End Sub

    Private Sub btnConTrans_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConTrans.ItemClick
        frmTransferencia.Tag = "CONSULTA"
        frmTransferencia.Show()
    End Sub

    Private Sub btnEnvTrans_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEnvTrans.ItemClick
        frmTransferencia.Tag = "ENVIA"
        frmTransferencia.Show()
    End Sub

    Private Sub btnRTrans_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRTrans.ItemClick
        frmRecTrans.Show()
    End Sub

    Private Sub btnTranEnv_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTranEnv.ItemClick
        frmRelTrans.Tag = "ENVIADA"
        frmRelTrans.Show()
    End Sub

    Private Sub btnTranRec_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTranRec.ItemClick
        frmRelTrans.Tag = "RECEBIDA"
        frmRelTrans.Show()
    End Sub

    Private Sub btnGiro1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGiro1.ItemClick
        frmRelGiro.Show()

    End Sub

    Private Sub btnGiro2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGiro2.ItemClick
        frmRelGiroConsumo.Show()
    End Sub

    Private Sub btnRelGra_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelGra.ItemClick
        frmGrafico.Tag = ""
        frmGrafico.Show()
    End Sub

    Private Sub btnRelCon_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCon.ItemClick
        frmGraficoSetores.Tag = "Consumo"
        frmGraficoSetores.Show()
    End Sub

    Private Sub btnRelProd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelProd.ItemClick
        frmGraficoPorProduto.Tag = "Produto"
        frmGraficoPorProduto.Show()
    End Sub

    Private Sub btnMigracao2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMigracao2.ItemClick
        frmMigracao2.ShowDialog()
    End Sub

    Private Sub btnNfeCliente_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNfeCliente.ItemClick
        ArquivoNfeCliente("", True)
        MsgBox("Arquivos gerados com sucesso!", MsgBoxStyle.Information)
    End Sub

    Private Sub btnNfeProduto_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNfeProduto.ItemClick
        ArquivoNfeProduto("", True)
        MsgBox("Arquivos gerados com sucesso!", MsgBoxStyle.Information)
    End Sub

    Private Sub btnLimparNfe_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimparNfe.ItemClick
        If MsgBox("Tem certeza que deseja limpar todos os arquivos da pasta NFE?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Kill(PastaCliProdEmissor & "\*.*")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try


            MsgBox("Pasta limpa com sucesso!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnImpExcel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImpExcel.ItemClick
        frmImpExcel.Show()
    End Sub

    Private Sub btnConfigNfe_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConfigNfe.ItemClick
        frmConfigNfe.ShowDialog()
    End Sub

    Private Sub btnRelTotalNF_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelTotalNF.ItemClick
        frmConTotNF.Show()
    End Sub

    Private Sub btnEstNeg_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstNeg.ItemClick
        frmRelEstNegativo.Show()
    End Sub

    Private Sub btnGrpLoja_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGrpLoja.ItemClick
        frmCorrecaoEstoque.Text = "Agrupar Lote"
        frmCorrecaoEstoque.Tag = "AGRUPAR"
        frmCorrecaoEstoque.ShowDialog()

    End Sub

    Private Sub btnNovLoja_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNovLoja.ItemClick
        frmCorrecaoEstoque.Text = "Nova Loja"
        frmCorrecaoEstoque.Tag = "NOVA LOJA"
        frmCorrecaoEstoque.ShowDialog()

    End Sub

    Private Sub btnProdFalta_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnProdFalta.ItemClick
        frmConProdFaltante.Show()
    End Sub

    Private Sub btnEmail_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEmail.ItemClick
        frmEmail.Show()
    End Sub

    Private Sub btnAltVal_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAltVal.ItemClick
        Dim frm As New frmAlterarValores
        frm.ShowDialog()
    End Sub

    Private Sub btnFluxo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFluxo.ItemClick

        Dim frm As New frmRelFluxoCaixa
        frm.Show()

    End Sub


    Private Sub btnMenuFiscal_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMenuFiscal.ItemClick
        frmMenuFiscal.Show()
    End Sub

    Private Sub btnAddQtd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddQtd.ItemClick
        frmCorrecaoEstoque.Text = "Adicionar Qtd zerada"
        frmCorrecaoEstoque.Tag = "ADICIONAR"
        frmCorrecaoEstoque.ShowDialog()
    End Sub

    Private Sub btnCadPedido_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCadPedido.ItemClick
        If TipoNano = 3 Then
            Dim frm As New frmPedidoAnimal
            frm.Tag = "CADASTRA"
            frm.Show()
        Else
            If NomeEmpresa.ToUpper.Contains("LDN AUTO") = True Then
                frmPedido.Tag = "CADASTRA"
                frmPedido.Show()
            Else
                Dim frm As New frmPedido
                frm.Tag = "CADASTRA"
                frm.Show()
            End If
         
        End If
      
    End Sub

    Private Sub btnAltPedido_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAltPedido.ItemClick
        If TipoNano = 3 Then
            frmPedidoAnimal.Tag = "ALTERA"
            frmPedidoAnimal.Show()
        Else
            frmPedido.Tag = "ALTERA"
            frmPedido.Show()
        End If
      
    End Sub

    Private Sub btnConPedido_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConPedido.ItemClick
        If TipoNano = 3 Then
            frmPedidoAnimal.Tag = "CONSULTA"
            frmPedidoAnimal.Show()
        Else
            frmPedido.Tag = "CONSULTA"
            frmPedido.Show()
        End If
  
    End Sub

    Private Sub btnComanda_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnComanda.ItemClick
        frmComanda.Show()
    End Sub

    Private Sub btnConfigECF_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConfigECF.ItemClick
        If NANONFCe = True Then
            frmMenuNFCe.ShowDialog()
        Else
            frmConfigFiscal.ShowDialog()
        End If

    End Sub

    Private Sub btnExcluirTeste_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluirTeste.ItemClick
        If MsgBox("Deseja realmente excluir nf-e de teste?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If MsgBox("Tem certeza?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Excluir("DELETE FROM Ordens where Tabela = 'Nfe' and CodConfig = " & CodConfig)
                Excluir("DELETE FROM TotalNfe")
                Excluir("DELETE FROM ItensNfe")
                Excluir("DELETE FROM RefNfe")
                Excluir("DELETE FROM VolumeNfe")
                Excluir("DELETE FROM DuplicataNfe")
            End If

        End If
    End Sub

    Private Sub btnTrocaUser_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTrocaUser.ItemClick
        If MsgBox("Deseja realmente trocar de usuário?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            bolTrocarUser = True
            Me.Close()
        End If
    End Sub

    Private Sub btnAtivo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAtivo.ItemClick
        frmPedido.Tag = "ATIVO"
        frmPedido.Show()
    End Sub

    Private Sub btnBaixarAtivo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBaixarAtivo.ItemClick
        frmBaixarAtivo.Show()
    End Sub

    Private Sub btnConsultarAtivos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConsultarAtivos.ItemClick
        frmConAtivos.Show()
    End Sub

    Private Sub btnNanoDownloads_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNanoDownloads.ItemClick
        Try



            Dim strPastaDebug As String = My.Application.Info.DirectoryPath.Replace("Debug", "DebugDownloads")

            If IO.File.Exists(strPastaDebug & "\Nano.exe") = False Then

                If MsgBox("Nano Downloads não esta instalado, deseja instalar agora?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                System.IO.Directory.CreateDirectory(strPastaDebug)

                Me.Cursor = Cursors.WaitCursor


                Dim wc As New System.Net.WebClient()

                System.IO.File.Delete(strPastaDebug & "\Nano.exe.gz")
                wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos/nano-downloads/Nano.exe.gz?attredirects=0&d=1", strPastaDebug & "\Nano.exe.gz")

                System.IO.File.Delete(strPastaDebug & "\Nano.pdb.gz")
                wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos/nano-downloads/Nano.pdb.gz?attredirects=0&d=1", strPastaDebug & "\Nano.pdb.gz")

                'System.IO.File.Delete(strPastaDebug & "\Nano.vshost.exe.gz")
                'wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos/nano-downloads/Nano.vshost.exe.gz?attredirects=0&d=1", strPastaDebug & "\Nano.vshost.exe.gz")

                System.IO.File.Delete(strPastaDebug & "\Nano.xml.gz")
                wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos/nano-downloads/Nano.xml.gz?attredirects=0&d=1", strPastaDebug & "\Nano.xml.gz")

                System.IO.File.Delete(strPastaDebug & "\UpdateNano.exe.gz")
                wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos/nano-downloads/UpdateNano.exe.gz?attredirects=0&d=1", strPastaDebug & "\UpdateNano.exe.gz")

                System.IO.File.Delete(strPastaDebug & "\UpdateNano.pdb.gz")
                wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos/nano-downloads/UpdateNano.pdb.gz?attredirects=0&d=1", strPastaDebug & "\UpdateNano.pdb.gz")

                System.IO.File.Delete(strPastaDebug & "\UpdateNano.xml.gz")
                wc.DownloadFile("https://sites.google.com/site/cotroles/arquivos/nano-downloads/UpdateNano.xml.gz?attredirects=0&d=1", strPastaDebug & "\UpdateNano.xml.gz")

                descompactaArquivo(strPastaDebug & "\Nano.exe.gz", strPastaDebug & "\Nano.exe")
                descompactaArquivo(strPastaDebug & "\Nano.pdb.gz", strPastaDebug & "\Nano.pdb")
                ' descompactaArquivo(strPastaDebug & "\Nano.vshost.exe.gz", strPastaDebug & "\Nano.vshost.exe")
                descompactaArquivo(strPastaDebug & "\Nano.xml.gz", strPastaDebug & "\Nano.xml")
                descompactaArquivo(strPastaDebug & "\UpdateNano.exe.gz", strPastaDebug & "\UpdateNano.exe")
                descompactaArquivo(strPastaDebug & "\UpdateNano.pdb.gz", strPastaDebug & "\UpdateNano.pdb")
                descompactaArquivo(strPastaDebug & "\UpdateNano.xml.gz", strPastaDebug & "\UpdateNano.xml")


                System.IO.File.Delete(strPastaDebug & "\Nano.exe.gz")
                System.IO.File.Delete(strPastaDebug & "\Nano.pdb.gz")
                'System.IO.File.Delete(strPastaDebug & "\Nano.vshost.exe.gz")
                System.IO.File.Delete(strPastaDebug & "\Nano.xml.gz")
                System.IO.File.Delete(strPastaDebug & "\UpdateNano.exe.gz")
                System.IO.File.Delete(strPastaDebug & "\UpdateNano.pdb.gz")
                System.IO.File.Delete(strPastaDebug & "\UpdateNano.xml.gz")
            End If


            System.Diagnostics.Process.Start(strPastaDebug & "\Nano.exe")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        Me.Cursor = Cursors.Default

    End Sub
    Public Sub descompactaArquivo(ByVal arquivoOrigem As String, ByVal arquivoDestino As String)
        ' ----- Compacata o contéudo do arquivo e
        '       guarda o resultado em um novo arquivo
        Dim streamFonte As FileStream = Nothing
        Dim streamDestino As FileStream = Nothing
        Dim streamCompactado As GZipStream = Nothing
        Dim streamDescompactado As GZipStream = Nothing
        Try
            streamFonte = New FileStream(arquivoOrigem, FileMode.Open, FileAccess.Read)
            streamDestino = New FileStream(arquivoDestino, FileMode.Create, FileAccess.Write)

            ' ----- Os bytes serão processados através de um decompressor de stream
            streamDescompactado = New GZipStream(streamFonte, CompressionMode.Decompress, True)

            ' ----- Processa os bytes de um arquivo para outro
            Const tamanhoBloco As Integer = 4096
            Dim buffer(tamanhoBloco) As Byte
            Dim bytesLidos As Integer
            Do
                bytesLidos = streamDescompactado.Read(buffer, 0, tamanhoBloco)
                If (bytesLidos = 0) Then Exit Do
                streamDestino.Write(buffer, 0, bytesLidos)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ' ----- Fecha todos os arquivos
            streamFonte.Close()
            streamDescompactado.Close()
            streamDestino.Close()
        End Try
    End Sub

    Private Sub btnChequeRecebido_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnChequeRecebido.ItemClick
        frmCheque.Tag = ""
        frmCheque.Show()
    End Sub

    Private Sub btnChequeRepassado_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnChequeRepassado.ItemClick
        frmCheque.Tag = "RECEBIDOOK"
        frmCheque.Show()
    End Sub

    Private Sub btnInventario_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInventario.ItemClick
        frmInventario.Show()
    End Sub

    Private Sub btnConInventario_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConInventario.ItemClick
        frmConInventario.Show()
    End Sub

    Private Sub btnAtivarProduto_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAtivarProduto.ItemClick
        frmAtivarProduto.Show()
    End Sub

    Private Sub btnRelComanda_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelComanda.ItemClick
        frmRelComanda.Show()
    End Sub

    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        frmMigracao.Tag = "Casella"
        frmMigracao.ShowDialog()
    End Sub

   

    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        If MsgBox("Deseja realmente inserir as conta a receber?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Dim dt As DataTable = CarregarDataTableExcel("C:\NANO\", "CONTA")

        Dim I As Integer
        Dim A As Integer = 1
        Dim strOrdem As Integer = 0

        For I = 0 To dt.Rows.Count - 1
            Dim strNomeCliente As String = dt.Rows.Item(I).Item("NomeCliente").ToString
            Dim dtCliente As DataTable = CarregarDataTable("SELECT Codigo FROM Cliente where Nome = '" & strNomeCliente & "'")

            If dtCliente.Rows.Count > 0 Then
                Dim strCodCli As String = dtCliente.Rows.Item(0).Item("Codigo").ToString

                Dim strCodOrdem As Integer = dt.Rows.Item(I).Item("CodOrdem").ToString
                If strOrdem = strCodOrdem Then
                    A += 1
                Else
                    Dim dtConta As DataTable = CarregarDataTable("SELECT sum(ValorParcela) as ValorParcela, " & _
                    "count(Parcelas) as Parcelas FROM ContaReceber where CodOrdem = " & strOrdem & "000000")
                    If dtConta.Rows.Count > 0 Then
                        Dim strValorVenda As String = dtConta.Rows.Item(0).Item("ValorParcela").ToString
                        Dim strPar As String = dtConta.Rows.Item(0).Item("Parcelas").ToString
                        If strValorVenda <> "" Then
                            Atualizar("UPDATE ContaReceber SET Parcelas = Parcelas + '/" & strPar & "', " & _
                            "ValorVenda = " & Num(strValorVenda) & " where CodOrdem = " & strOrdem & "000000")
                        End If
                    End If
                    strOrdem = strCodOrdem
                    A = 1
                End If
                Dim strDataVenda As String = dt.Rows.Item(I).Item("DataVenda").ToString

                Dim strNumeroDocumento As String = dt.Rows.Item(I).Item("NumeroDocumento").ToString

                Dim strValorParcela As String = dt.Rows.Item(I).Item("ValorParcela").ToString

                Dim strVencimento As String = dt.Rows.Item(I).Item("Vencimento").ToString

                Inserir("INSERT INTO ContaReceber (CodOrdem, DataVenda, CodCli, Obs, FormaPagamento, " & _
                "Parcelas, ValorParcela, Vencimento, ValorVenda, ValorRecebido, RecebidoOK, Pagamento, " & _
                "NumeroDocumento, TipoCusto, Banco, CodConfig) VALUES (" & strCodOrdem & "000000," & _
                "'" & strDataVenda & "'," & strCodCli & ",'','','" & A & "'," & Num(strValorParcela) & "," & _
                "'" & strVencimento & "',0,0,'False','','" & strNumeroDocumento & "','V',''," & CodConfig & ")")

            End If
        Next


    End Sub

    Private Sub btnCorrecaoRep_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCorrecaoRep.ItemClick
        frmCorrecaoReplicacao.Show()
    End Sub

    Private Sub btnOrdemNfe_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOrdemNfe.ItemClick
        'frmNumeroSessao.Show()
    End Sub

    Private Sub btnEstoqueSomado_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstoqueSomado.ItemClick
        frmCorrecaoEstoque.Text = "Estoque Somado"
        frmCorrecaoEstoque.Tag = "SOMADO"
        frmCorrecaoEstoque.ShowDialog()
    End Sub

    Private Sub btnComissaoSomado_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnComissaoSomado.ItemClick

        If ProcuraForm("frmRelComissaoTotal") <> "frmRelComissaoTotal" Then
            Dim fm As New frmRelComissaoTotal
            fm.Tag = "Somado"
            fm.Size = New System.Drawing.Size(800, 550)
            fm.Show()
        End If

    End Sub

    Private Sub btnComissaoDet_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnComissaoDet.ItemClick
        frmRelComissaoTotal.Tag = "Detalhado"
        frmRelComissaoTotal.Show()
    End Sub


    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        
        'Dim dtTotal As DataTable = CarregarDataTable("SELECT Codigo, CodOrdem FROM Total where CodConfig = 5 order by Codigo")

        'Dim I As Integer

        'For I = 0 To dtTotal.Rows.Count - 1
        '    Dim strCodigo As Integer = dtTotal.Rows.Item(I).Item("Codigo").ToString
        '    Dim strCodOrdem As Integer = dtTotal.Rows.Item(I).Item("CodOrdem").ToString

        '    If strCodigo >= 74757 And strCodigo <= 74804 Then
        '        strCodOrdem += 22

        '        Atualizar("UPDATE Total set CodOrdem = " & strCodOrdem & " where Codigo = " & strCodigo)

        '    End If

        'Next

        'dtTotal = CarregarDataTable("SELECT Codigo, CodOrdem FROM Pedido where CodConfig = 5 order by Codigo")

        'Dim strCod As Integer

        'For I = 0 To dtTotal.Rows.Count - 1
        '    Dim strCodigo As Integer = dtTotal.Rows.Item(I).Item("Codigo").ToString
        '    Dim strCodOrdem As Integer = dtTotal.Rows.Item(I).Item("CodOrdem").ToString

        '    If strCodigo >= 113788 And strCodigo <= 113859 Then

        '        strCodOrdem += 22



        '        Atualizar("UPDATE Pedido set CodOrdem = " & strCodOrdem & " where Codigo = " & strCodigo)

        '    End If

        'Next

        'dtTotal = CarregarDataTable("SELECT Codigo, CodOrdem FROM Recebimento where CodConfig = 5 order by Codigo")

        'For I = 0 To dtTotal.Rows.Count - 1
        '    Dim strCodigo As Integer = dtTotal.Rows.Item(I).Item("Codigo").ToString
        '    Dim strCodOrdem As Integer = dtTotal.Rows.Item(I).Item("CodOrdem").ToString

        '    If strCodigo >= 75810 And strCodigo <= 75858 Then
        '        strCodOrdem += 22

        '        Atualizar("UPDATE Recebimento set CodOrdem = " & strCodOrdem & " where Codigo = " & strCodigo)

        '    End If

        'Next
        'dtTotal = CarregarDataTable("SELECT Codigo, CodOrdem FROM Futuro where CodConfig = 5 order by Codigo")

        'For I = 0 To dtTotal.Rows.Count - 1
        '    Dim strCodigo As Integer = dtTotal.Rows.Item(I).Item("Codigo").ToString
        '    Dim strCodOrdem As Integer = dtTotal.Rows.Item(I).Item("CodOrdem").ToString

        '    If strCodigo >= 65370 And strCodigo <= 65413 Then
        '        strCodOrdem += 22

        '        Atualizar("UPDATE Futuro set CodOrdem = " & strCodOrdem & " where Codigo = " & strCodigo)

        '    End If

        'Next


        'dtTotal = CarregarDataTable("SELECT Codigo, Motivo FROM Caixa where CodConfig = 5 and Motivo like '%Venda N%' order by Codigo")

        'For I = 0 To dtTotal.Rows.Count - 1
        '    Dim strCodigo As Integer = dtTotal.Rows.Item(I).Item("Codigo").ToString
        '    Dim strMotivo As String = dtTotal.Rows.Item(I).Item("Motivo").ToString

        '    If strCodigo >= 90598 And strCodigo <= 90657 Then
        '        If strMotivo.Contains("Troco") = True Then
        '            Dim vetMot As Array = Split(strMotivo, "Venda Nº ")
        '            Dim strCodOrdem As Integer = vetMot(1)
        '            strMotivo = "Troco Venda Nº " & strCodOrdem
        '        Else
        '            Dim strMot As String = ""
        '            Dim vetMot As Array = Split(strMotivo, "Venda Nº ")
        '            vetMot = Split(vetMot(1), ",")
        '            Dim strCodOrdem As Integer = vetMot(0)
        '            strCodOrdem += 22
        '            strMotivo = "Venda Nº " & strCodOrdem & ", " & vetMot(1)
        '        End If

        '        Atualizar("UPDATE caixa set Motivo = '" & strMotivo & "' where Codigo = " & strCodigo)

        '    End If

        'Next


        Dim dt As DataTable = CarregarDataTable("SELECT Produto.Codigo as CodProd, Ajuste1.Codigo, Qtd FROM Ajuste1 left join Produto on Ajuste1.codigo = PRoduto.CodigoInterno")
        Dim I As Integer
        Dim strCodInt As String = ""
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As String = dt.Rows.Item(I).Item("CodProd").ToString
            Dim strCod As String = dt.Rows.Item(I).Item("Codigo").ToString
            Dim dblQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
            If strCodigo <> "" Then
                Inserir("INSERT INTO AjusteQtde(CodProd,Qtd,Data,Tabela,CodConfig, CodUser) VALUES(" & strCodigo & "," & Num(dblQtd) & ",'" & My.Computer.Clock.LocalTime & "','MIG - INVENTARIO'," & CodConfig & ",1)")
            Else
                strCodInt = strCodInt & "," & strCod
            End If
    
        Next


        dt = CarregarDataTable("SELECT Produto.Codigo as CodProd, Ajuste2.Codigo, Qtd FROM Ajuste2 left join Produto on Ajuste2.codigo = PRoduto.CodigoBarra")
        strCodInt = strCodInt & vbCrLf & vbCrLf
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigo As String = dt.Rows.Item(I).Item("CodProd").ToString
            Dim strCod As String = dt.Rows.Item(I).Item("Codigo").ToString
            Dim dblQtd As String = dt.Rows.Item(I).Item("Qtd").ToString
            If strCodigo <> "" Then
                Inserir("INSERT INTO AjusteQtde(CodProd,Qtd,Data,Tabela,CodConfig, CodUser) VALUES(" & strCodigo & "," & Num(dblQtd) & ",'" & My.Computer.Clock.LocalTime & "','MIG - INVENTARIO'," & CodConfig & ",1)")
            Else
                Dim dt1 As DataTable = CarregarDataTable("SELECT CodigoBarra.CodProd, Ajuste2.Codigo, Qtd FROM Ajuste2 left join CodigoBarra on Ajuste2.codigo = CodigoBarra.CodigoBarra where Ajuste2.Codigo = '" & strCod & "'")
                If dt1.Rows.Count > 0 Then
                    If dt1.Rows.Item(0).Item("CodProd").ToString <> "" Then
                        Inserir("INSERT INTO AjusteQtde(CodProd,Qtd,Data,Tabela,CodConfig) VALUES(" & dt1.Rows.Item(0).Item("CodProd").ToString & "," & Num(dt1.Rows.Item(0).Item("Qtd").ToString) & ",'" & My.Computer.Clock.LocalTime & "','MIG - INVENTARIO'," & CodConfig & ")")
                    Else
                        strCodInt = strCodInt & "," & strCod
                    End If
                Else
                    strCodInt = strCodInt & "," & strCod
                End If

            End If

        Next


        Dim SW As New StreamWriter("C:\NANO\ProdutoNaoEncontrado.txt") ' Cria o arquivo de texto

        SW.WriteLine(strCodInt) ' Grava uma linha no arquivo de texto

        SW.Close() 'Fecha o arquivo de texto

        SW.Dispose() 'Libera a memória utilizada

        MsgBox("OK", MsgBoxStyle.Information)
    End Sub

    Private Sub btnNfeNano_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNfeNano.ItemClick

        Dim processo As Process() = Process.GetProcessesByName("NanoNfe")
        If processo.Length > 0 Then
            MsgBox("O sistema já esta aberto!", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim strVersao As String = ""


        If Mensalista = True Then

            Try
                'System.IO.File.Delete(My.Application.Info.DirectoryPath & "\Controle.era")
                System.IO.File.Delete(My.Application.Info.DirectoryPath & "\VersaoNfe.txt")


                Dim wc As New System.Net.WebClient()

                'wc.DownloadFile("https://sites.google.com/site/cotroles/inadimplencia/Controle.era?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\Controle.era")
                wc.DownloadFile("https://sites.google.com/site/cotroles/versao/VersaoNfe.txt?attredirects=0&d=1", PastaNotaNfe.Replace("Remessas", "Debug") & "\VersaoNfe.txt")


            Catch ex As Exception

            End Try

            strVersao = LerArquivo(PastaNotaNfe.Replace("Remessas", "Debug") & "\VersaoNfe.txt", True)
        End If

        Dim strLogin As String = LerArquivo(PastaNotaNfe.Replace("Remessas", "Arquivos") & "\Login.txt", True)
        Dim fluxoTexto As IO.StreamWriter
        fluxoTexto = New IO.StreamWriter(PastaNotaNfe.Replace("Remessas", "Arquivos") & "\Login.txt")

        fluxoTexto.Write("")
        fluxoTexto.Write(Login & "|" & Senha & "|" & strVersao)
        fluxoTexto.Close()

        System.Diagnostics.Process.Start(PastaNotaNfe.Replace("Remessas", "Debug") & "\NanoNfe.exe")
    End Sub

    Private Sub btnTransportadora_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTransportadora.ItemClick
        frmCadFornecedor.Tag = "Transportadora"
        frmCadFornecedor.Show()
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick

        'Dim dt As DataTable = CarregarDataTableExcel("C:\NANO\", "Cliente")

        'Dim I As Integer
        'Dim A As Integer = 1
        'For I = 0 To dt.Rows.Count - 1

        '    Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString.Replace("'", "´")
        '    Dim strRG As String = dt.Rows.Item(I).Item("RGIE").ToString.Replace("'", "´")
        '    Dim strCPF As String = dt.Rows.Item(I).Item("CPF").ToString.Replace("'", "´")
        '    If strCPF <> "" Then
        '        If strCPF.Length = 14 Then
        '            strCPF = AddPonto(strCPF, "J")
        '        ElseIf strCPF.Length = 11 Then
        '            strCPF = AddPonto(strCPF, "F")
        '        End If
        '    Else
        '        strCPF = A
        '        A += 1
        '    End If
        '    Dim dtCliente As DataTable = CarregarDataTable("SELECT Codigo FROM Cliente where CPF = '" & strCPF & "'")
        '    If dtCliente.Rows.Count = 0 Then
        '        Dim strEnd As String = dt.Rows.Item(I).Item("Endereco").ToString.Replace("'", "´")
        '        'Dim vetEnd As Array = Split(strEnd, ",")
        '        'If vetEnd.Length > 0 Then
        '        '    strEnd = vetEnd(0)
        '        'End If
        '        Dim strTel As String = dt.Rows.Item(I).Item("Telefone").ToString.Replace("'", "´")
        '        Dim strFax As String = dt.Rows.Item(I).Item("Fax").ToString.Replace("'", "´")
        '        Dim strCel As String = dt.Rows.Item(I).Item("Celular").ToString.Replace("'", "´")
        '        Dim strEmail As String = dt.Rows.Item(I).Item("Email").ToString.Replace("'", "´")
        '        Dim strData As String = Date.Today
        '        Dim strNum As String = dt.Rows.Item(I).Item("Numero").ToString.Replace("'", "´")
        '        Dim strComp As String = dt.Rows.Item(I).Item("Complemento").ToString.Replace("'", "´")
        '        'If vetEnd.Length > 1 Then
        '        '    strNum = vetEnd(1).ToString.Replace("(COOPERATIVA)", "")
        '        '    Dim vetNum As Array = Split(strNum.Trim, "-")
        '        '    strNum = vetNum(0)
        '        '    If vetNum.Length > 1 Then
        '        '        If strComp = "" Then
        '        '            strComp = vetNum(1)
        '        '        Else
        '        '            strComp = strComp & " " & vetNum(1)
        '        '        End If
        '        '    End If

        '        '    vetNum = Split(strNum.Trim, " ")
        '        '    strNum = vetNum(0)
        '        '    If vetNum.Length > 1 Then
        '        '        If strComp = "" Then
        '        '            strComp = vetNum(1)
        '        '        Else
        '        '            strComp = strComp & " " & vetNum(1)
        '        '        End If
        '        '    End If
        '        'End If

        '        Dim strBairro As String = dt.Rows.Item(I).Item("Bairro").ToString.Replace("'", "´")
        '        Dim strCep As String = dt.Rows.Item(I).Item("Cep").ToString.Replace("'", "´")
        '        Dim strCidade As String = dt.Rows.Item(I).Item("Cidade").ToString.Replace("'", "´")
        '        Dim strUF As String = dt.Rows.Item(I).Item("Estado").ToString.Replace("'", "´")
        '        Dim strFant As String = dt.Rows.Item(I).Item("Fantasia").ToString.Replace("'", "´")
        '        Dim bolIna As Boolean = False
        '        Dim strObs As String = dt.Rows.Item(I).Item("Observacao").ToString.Replace("'", "´")
        '        Dim strStatus As String = dt.Rows.Item(I).Item("Status").ToString.Replace("'", "´")
        '        Dim strNasc As String = dt.Rows.Item(I).Item("Nascimento").ToString.Replace("'", "´")

        '        Dim strSexo As String = dt.Rows.Item(I).Item("Sexo").ToString.Replace("'", "´")
        '        Dim strLimite As String = dt.Rows.Item(I).Item("Limite").ToString.Replace("'", "´")
        '        Dim strEmpresa As String = ""
        '        Dim strSalario As String = ""
        '        Dim strTelEmp As String = ""
        '        Dim strCredito As String = ""
        '        Dim strMarca As String = ""
        '        Dim strCodConfig As String = 1
        '        Dim strP1 As String = ""
        '        Dim strP2 As String = ""
        '        Dim strRG1 As String = ""
        '        Dim strRG2 As String = ""
        '        Dim bolInativo As Boolean = False

        '        Inserir("INSERT INTO Cliente (Nome, RGIE, CPF, Endereco, Telefone, Fax, Celular, Email, Data, Numero, Complemento, Bairro, Cep, Cidade, Estado, Fantasia, Inadimplente, Observacao, Status, Nascimento, Sexo, Limite, Empresa, TelEmpresa, Salario, Credito, Marcas, CodConfig, Pessoa1, Pessoa2, RG1, RG2, Inativo) VALUES ('" & strNome.Replace("'", "´") & "','" & strRG & "','" & strCPF & "','" & strEnd.Replace("'", "´") & "','" & strTel & "','" & strFax & "','" & strCel & "','" & strEmail & "','" & strData & "','" & strNum & "','" & strComp & "','" & strBairro.Replace("'", "´") & "','" & strCep & "','" & strCidade.Replace("'", "´") & "','" & strUF & "','" & strFant & "','" & bolIna & "','" & strObs.Replace("'", "´") & "','" & strStatus & "','" & strNasc & "','" & strSexo & "','" & strLimite & "','" & strEmpresa & "','" & strTelEmp & "','" & strSalario & "','" & strCredito & "','" & strMarca & "'," & strCodConfig & ",'" & strP1 & "','" & strP2 & "','" & strRG1 & "','" & strRG2 & "','" & bolInativo & "')")

        '    End If

        'Next





        'Dim dt As DataTable = CarregarDataTableExcel("C:\NANO\Custódio\", "Produto")

        'Dim I As Integer
        'For I = 0 To dt.Rows.Count - 1
        '    Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString.Replace("'", "´")
        '    Dim strUnidadeMedida As String = dt.Rows.Item(I).Item("UnidadeMedida").ToString.Replace("'", "´")
        '    Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString.Replace("'", "´")
        '    Dim strValorCusto As String = dt.Rows.Item(I).Item("ValorCusto").ToString.Replace("'", "´")
        '    Dim strLocacao As String = dt.Rows.Item(I).Item("Locacao").ToString.Replace("'", "´")
        '    Dim strCodigoInterno As String = dt.Rows.Item(I).Item("CodigoInterno").ToString.Replace("'", "´")
        '    Dim strPorcentagens As String = dt.Rows.Item(I).Item("Porcentagens").ToString.Replace("'", "´")
        '    Dim strFabricante As String = dt.Rows.Item(I).Item("Fabricante").ToString.Replace("'", "´")
        '    Dim strGrupo As String = dt.Rows.Item(I).Item("Grupo").ToString.Replace("'", "´")
        '    If strGrupo = "" Then
        '        strGrupo = "DIVERSOS"
        '    End If
        '    If strGrupo = "LANTERNALENTEFAROL" Then
        '        strGrupo = "LANTERNA LENTE FAROL"
        '    End If
        '    Dim strObs As String = dt.Rows.Item(I).Item("Obs").ToString.Replace("'", "´")
        '    If strObs.Length > 150 Then
        '        strObs = strObs.Substring(0, 150)
        '    End If
        '    Dim strData As String = Date.Today

        '    Dim strCodigoBarra As String = ""
        '    Dim strNivelComboCodCF As String = ""
        '    Dim strDesconto As String = 0


        '    Dim strSetor As String = ""
        '    Dim strTipo As String = "PEÇA"

        '    Inserir("INSERT INTO Produto (Nome, UnidadeMedida, Valor, ValorCusto, Locacao,  CodigoInterno, Porcentagens, Fabricante, Grupo, Obs, Data, CodigoBarra, NivelComboCodCF, Desconto, Setor, Tipo, Inativo) VALUES ('" & strNome.Replace("'", "´") & "','" & strUnidadeMedida & "'," & Num(strValor) & "," & Num(strValorCusto) & ",'" & strLocacao & "','" & strCodigoInterno & "','" & strPorcentagens & "','" & strFabricante.Replace("'", "´") & "','" & strGrupo & "','" & strObs.Replace("'", "´") & "','" & strData & "','" & strCodigoBarra & "','" & strNivelComboCodCF & "'," & Num(strDesconto) & ",'" & strSetor & "','" & strTipo & "','False')")

        'Next

        'Inserir("INSERT INTO GRUPO (Nome, Tipo) VALUES ('PET SHOP','S')")
        'Inserir("INSERT INTO GRUPO (Nome, Tipo) VALUES ('MEDICAMENTO','S')")
        'Inserir("INSERT INTO GRUPO (Nome, Tipo) VALUES ('SERVIÇOS','S')")
        'Inserir("INSERT INTO GRUPO (Nome, Tipo) VALUES ('ESTÉTICA','S')")
        'Inserir("INSERT INTO GRUPO (Nome, Tipo) VALUES ('VACINA','S')")
        'Inserir("INSERT INTO GRUPO (Nome, Tipo) VALUES ('DIVERSOS','G')")




        Dim dt As DataTable = CarregarDataTableExcel("C:\NANO\", "Produto")

        Dim I As Integer
        For I = 0 To dt.Rows.Count - 1

            Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString.Replace("'", "´")
            Dim strUnidadeMedida As String = "UN"
            Dim dblValCusto As Double = 0
            Dim dblPor As Double = 0
            Dim strValorCusto As String = dt.Rows.Item(I).Item("ValorCusto").ToString.Replace("'", "´")
            If strValorCusto <> "" Then
                dblValCusto = strValorCusto
            End If
            Dim strPorcentagem As String = dt.Rows.Item(I).Item("Porcentagem").ToString.Replace("'", "´")
            If strPorcentagem <> "" Then
                dblPor = strPorcentagem
            End If
            Dim strCodigoFabricante As String = dt.Rows.Item(I).Item("CodigoFabricante").ToString.Replace("'", "´")
            Dim strCodigoOriginal As String = dt.Rows.Item(I).Item("CodigoOriginal").ToString.Replace("'", "´")
            Dim strLocacao As String = ""

            If strCodigoFabricante <> strCodigoOriginal Then
                If strCodigoFabricante = "" Then
                    strLocacao = strCodigoOriginal
                Else
                    If strCodigoOriginal = "" Then
                        strLocacao = strCodigoFabricante
                    Else
                        strLocacao = strCodigoFabricante & "," & strCodigoOriginal
                    End If

                End If
            End If

            Dim strCodigoInterno As String = dt.Rows.Item(I).Item("CodigoInterno").ToString.Replace("'", "´")
            If strCodigoInterno <> "" Then
                Dim dtProd As DataTable = CarregarDataTable("SELECT Codigo FROM Produto where CodigoInterno = '" & strCodigoInterno & "'")
                If dtProd.Rows.Count > 0 Then
                    strCodigoInterno = ""
                End If
            End If
            If strCodigoInterno = "" Then
                Dim intCodOrdem As Integer = GerarCodigoOrdens("Produto", CodConfig)
                Dim bolOk As Boolean = False
                While bolOk = False
                    strCodigoInterno = intCodOrdem
                    strCodigoInterno = "000" & strCodigoInterno
                 
                    Dim dtProduto As DataTable = CarregarDataTable("SELECT Codigo FROM Produto where CodigoInterno = '" & strCodigoInterno & "'")
                    If dtProduto.Rows.Count > 0 Then
                        intCodOrdem += 1
                    Else
                        bolOk = True
                    End If

                End While

                Inserir("Insert into Ordens (Cod, Tabela, CodConfig) Values(" & strCodigoInterno & ",'Produto'" & "," & CodConfig & ")")
            End If

            Dim strFabricante As String = dt.Rows.Item(I).Item("Fornecedor").ToString.Replace("'", "´")
            Dim strGrupo As String = dt.Rows.Item(I).Item("Grupo").ToString.Replace("'", "´")
            If strGrupo = "" Then
                strGrupo = "DIVERSOS"
            End If
            Dim dtGrupo As DataTable = CarregarDataTable("SELECT Nome FROM Grupo where Nome = '" & strGrupo & "'")
            If dtGrupo.Rows.Count = 0 Then
                Inserir("INSERT INTO Grupo (Nome, Tipo) VALUES ('" & strGrupo.Replace("'", "´") & "','G')")
            End If

            Dim strObs As String = dt.Rows.Item(I).Item("Aplicacao").ToString.Replace("'", "´")

            Dim strData As String = dt.Rows.Item(I).Item("Data").ToString.Replace("'", "´")
            If strData = "" Then
                strData = Date.Today
            End If
            Dim strCodigoBarra As String = ""
            Dim strNivelComboCodCF As String = ""
            Dim strDesconto As String = 0


            Dim strSetor As String = ""
            Dim strTipo As String = "VENDA"

            Dim dblValVenda, dblLucro, dblMargem As Double

            If dblValCusto > 0 Then
                Dim dblValCus, dblResul As Double

                dblValCus = dblValCusto

                dblResul = (dblValCus * dblPor) / 100

                dblResul = dblValCus + dblResul

                dblValVenda = dblResul.ToString("0.00")
            Else
                dblValVenda = 0
            End If



            Inserir("INSERT INTO Produto (Nome, UnidadeMedida, Valor, ValorCusto, Locacao,  CodigoInterno, " & _
            "Porcentagens, Fabricante, Grupo, Obs, Data, CodigoBarra, NivelComboCodCF, Desconto, Setor, Tipo, " & _
            "Inativo, Validade) VALUES ('" & strNome & "','" & strUnidadeMedida & "'," & Num(dblValVenda) & "," & _
            "" & Num(dblValCusto) & ",'" & strLocacao & "','" & strCodigoInterno & "','" & strPorcentagem & "'," & _
            "'" & strFabricante.Replace("'", "´") & "','" & strGrupo & "','" & strObs.Replace("'", "´") & "','" & strData & "','" & strCodigoBarra & "','" & strNivelComboCodCF & "'," & Num(strDesconto) & ",'" & strSetor & "','" & strTipo & "','False','01/01/2050')")

            Dim dtP = CarregarDataTable("SELECT Codigo FROM Produto where Nome = '" & strNome & "' and " & _
            "CodigoInterno = '" & strCodigoInterno & "' and Grupo = '" & strGrupo & "' order by Codigo Desc")
            Dim intCodiProd As Integer
            If dtP.Rows.Count > 0 Then
                intCodiProd = dtP.Rows.Item(0).Item("Codigo").ToString
            End If

            Inserir("INSERT INTO Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, ValorCusto, EmFalta, " & _
            "CodConfig, Acabou, DataFim) VALUES (" & intCodiProd & ",'U',0,0," & _
            "'U'," & Num(dblValCusto) & ",'0',1,'False','01/01/1900')")

        Next


        dt = CarregarDataTableExcel("C:\NANO\", "Cliente")


        Dim A As Integer = 1
        For I = 0 To dt.Rows.Count - 1

            Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString.Replace("'", "´")
            If strNome <> "" Then


                Dim strRG As String = dt.Rows.Item(I).Item("IE").ToString.Replace("'", "´")
                Dim strCPF As String = dt.Rows.Item(I).Item("CNPJ").ToString.Replace("'", "´")

                strCPF = strCPF.Replace("_", "").Replace(".", "").Replace("-", "").Replace("/", "")
                strCPF = strCPF.Trim
                If strCPF = "" Then
                    strCPF = dt.Rows.Item(I).Item("CPF").ToString.Replace("'", "´")
                    strCPF = strCPF.Replace("_", "").Replace(".", "").Replace("-", "").Replace("/", "")
                    strCPF = strCPF.Trim
                    strRG = dt.Rows.Item(I).Item("RG").ToString.Replace("'", "´")
                    If strCPF <> "" Then
                        strCPF = AddPonto(strCPF, "F")
                    Else
                        strCPF = A
                        A += 1
                    End If

                Else
                    If strCPF.Length < 14 Then
                        strCPF = AddPonto(strCPF, "F")

                    Else
                        strCPF = AddPonto(strCPF, "J")
                    End If

                End If

                strRG = strRG.Replace("_", "")
                If strRG.Length > 15 Then
                    strRG = strRG.Substring(0, 15)
                End If
                If strRG = "..." Then
                    strRG = ""
                End If

                Dim dtCliente As DataTable = CarregarDataTable("SELECT Codigo FROM Cliente where CPF = '" & strCPF & "'")
                If dtCliente.Rows.Count = 0 Then
                    Dim strEnd As String = dt.Rows.Item(I).Item("Endereco").ToString.Replace("'", "´")
                    Dim strTel As String = dt.Rows.Item(I).Item("Telefone").ToString.Replace("'", "´")
                    Dim strFax As String = dt.Rows.Item(I).Item("Fax").ToString.Replace("'", "´")
                    Dim strCel As String = ""
                    Dim strEmail As String = dt.Rows.Item(I).Item("Email").ToString.Replace("'", "´")

                    Dim strData As String = dt.Rows.Item(I).Item("Data").ToString.Replace("'", "´")
                    If strData = "" Then
                        strData = Date.Today
                    End If
                    Dim strNum As String = ""
                    Dim strComp As String = ""

                    If strTel.Length > 18 Then
                        strTel = strTel.Substring(0, 18)
                    End If
                    If strFax.Length > 18 Then
                        strFax = strFax.Substring(0, 18)
                    End If
                    If strCel.Length > 18 Then
                        strCel = strCel.Substring(0, 18)
                    End If

                    Dim strBairro As String = dt.Rows.Item(I).Item("Bairro").ToString.Replace("'", "´")
                    Dim strCep As String = dt.Rows.Item(I).Item("Cep").ToString.Replace("'", "´")
                    If strCep = "_____-___" Then
                        strCep = ""
                    End If
                    Dim strCidade As String = dt.Rows.Item(I).Item("Cidade").ToString.Replace("'", "´")
                    Dim strUF As String = dt.Rows.Item(I).Item("UF").ToString.Replace("'", "´")
                    Dim strFant As String = dt.Rows.Item(I).Item("Fantasia").ToString.Replace("'", "´")
                    Dim bolIna As Boolean = False
                    Dim strObs As String = dt.Rows.Item(I).Item("Contato").ToString.Replace("'", "´")
                    Dim strStatus As String = ""
                    Dim strNasc As String = dt.Rows.Item(I).Item("Nascimento").ToString.Replace("'", "´").Replace("1899", "1989")

                    Dim strSexo As String = ""
                    Dim strLimite As String = ""
                    Dim strEmpresa As String = ""
                    Dim strSalario As String = ""
                    Dim strTelEmp As String = ""
                    Dim strCredito As String = ""
                    Dim strMarca As String = ""
                    Dim strCodConfig As String = 1
                    Dim strP1 As String = ""
                    Dim strP2 As String = ""
                    Dim strRG1 As String = ""
                    Dim strRG2 As String = ""
                    Dim bolInativo As Boolean = False
                    Dim strNomeConjuge As String = dt.Rows.Item(I).Item("NomeConjugue").ToString.Replace("'", "´")
                    Inserir("INSERT INTO Cliente (Nome, RGIE, CPF, Endereco, Telefone, Fax, Celular, Email, Data, " & _
                    "Numero, Complemento, Bairro, Cep, Cidade, Estado, Fantasia, Inadimplente, Observacao, Status, " & _
                    "Nascimento, Sexo, Limite, Empresa, TelEmpresa, Salario, Credito, Marcas, CodConfig, Pessoa1, " & _
                    "Pessoa2, RG1, RG2, Inativo, NomeConjuge) VALUES ('" & strNome.Replace("'", "´") & "'," & _
                    "'" & strRG & "','" & strCPF & "','" & strEnd.Replace("'", "´") & "','" & strTel & "'," & _
                    "'" & strFax & "','" & strCel & "','" & strEmail & "','" & strData & "','" & strNum & "'," & _
                    "'" & strComp & "','" & strBairro.Replace("'", "´") & "','" & strCep & "'," & _
                    "'" & strCidade.Replace("'", "´") & "','" & strUF & "','" & strFant & "','" & bolIna & "'," & _
                    "'" & strObs.Replace("'", "´") & "','" & strStatus & "','" & strNasc & "','" & strSexo & "'," & _
                    "'" & strLimite & "','" & strEmpresa & "','" & strTelEmp & "','" & strSalario & "'," & _
                    "'" & strCredito & "','" & strMarca & "'," & strCodConfig & ",'" & strP1 & "','" & strP2 & "'," & _
                    "'" & strRG1 & "','" & strRG2 & "','" & bolInativo & "','" & strNomeConjuge & "')")

                End If
            End If
        Next


        dt = CarregarDataTableExcel("C:\NANO\", "Fornecedor")


        For I = 0 To dt.Rows.Count - 1

            Dim strNome As String = dt.Rows.Item(I).Item("Razao").ToString.Replace("'", "").ToUpper
            If strNome = "" Then
                strNome = dt.Rows.Item(I).Item("Fantasia").ToString.Replace("'", "").ToUpper
            End If
            If strNome <> "" Then
                Dim strRG As String = dt.Rows.Item(I).Item("IE").ToString
                Dim strCPF As String = dt.Rows.Item(I).Item("CNPJ").ToString.Replace(".", "").Replace("-", "").Replace("/", "").Replace("_", "")
                Dim strEmail As String = dt.Rows.Item(I).Item("Email").ToString.ToUpper
                Dim strData As String = dt.Rows.Item(I).Item("Data").ToString
                If strData = "" Then
                    strData = Date.Today
                End If
                Dim strEnd As String = dt.Rows.Item(I).Item("Endereco").ToString.ToUpper
                Dim strNum As String = ""
                Dim strComplemento As String = ""
                Dim strBairro As String = dt.Rows.Item(I).Item("Bairro").ToString.ToUpper
                Dim strCep As String = dt.Rows.Item(I).Item("Cep").ToString.ToUpper
                Dim strCidade As String = dt.Rows.Item(I).Item("Cidade").ToString.ToUpper
                Dim strUF As String = dt.Rows.Item(I).Item("UF").ToString.ToUpper

                Dim strTel As String = dt.Rows.Item(I).Item("Telefone").ToString

                Dim strFax As String = dt.Rows.Item(I).Item("Telefone2").ToString
                Dim strCel As String = dt.Rows.Item(I).Item("Telefone3").ToString

                If strTel.Length > 18 Then
                    strTel = strTel.Substring(0, 18)
                End If
                If strFax.Length > 18 Then
                    strFax = strFax.Substring(0, 18)
                End If
                If strCel.Length > 18 Then
                    strCel = strCel.Substring(0, 18)
                End If
                Dim strIE As String = dt.Rows.Item(I).Item("IE").ToString
                Dim strFant As String = dt.Rows.Item(I).Item("Fantasia").ToString
                Dim bolIna As Boolean = "False"
                Dim strObs As String = ""
                Dim strStatus As String = ""
                Dim strNasc As String = ""
                Dim strSexo As String = ""
                Dim strLimite As String = ""
                Dim strSite As String = ""
                Dim strSenha As String = ""
                Dim strCorretor As String = ""
                Dim strTelefoneCorretor As String = ""
                Dim strComoChegou As String = ""
                Dim strQual As String = ""


                strRG = strRG.Replace("_", "")
                If strRG.Length > 15 Then
                    strRG = strRG.Substring(0, 15)
                End If
                If strRG = "..." Then
                    strRG = ""
                End If
                strCPF = strCPF.Replace("_", "")
                If strCPF.Trim = "../-" Then
                    strCPF = ""
                End If
                If strCPF.Trim = "..-" Then
                    strCPF = ""
                End If
                If strCPF.Length = 14 Then
                    strCPF = AddPonto(strCPF, "J")
                Else
                    strCPF = AddPonto(strCPF, "F")
                End If

                If strCep = "_____-___" Then
                    strCep = ""
                End If

                If strTel.Length > 18 Then
                    strTel = strTel.Substring(0, 18)
                End If
                If strFax.Length > 18 Then
                    strFax = strFax.Substring(0, 18)
                End If
                If strCel.Length > 18 Then
                    strCel = strCel.Substring(0, 18)
                End If

                If strCPF = "" Then
                    strCPF = "000" & GerarCodigo("Fornecedor", "Codigo", 0) & "0"
                End If
                Dim dtCliente As DataTable = CarregarDataTable("SELECT Codigo FROM Fornecedor where CPF = '" & strCPF & "'")
                If dtCliente.Rows.Count = 0 Then

                    Inserir("INSERT INTO Fornecedor (Nome, CPF, Endereco, Numero, Complemento, Bairro, Cep, Cidade, Estado, Telefone, Fax, Celular, Email, Data, IE, Contato, Site, Fantasia, Status, Obs, CodConfig, Tipo, Inativo) VALUES ('" & strNome & "','" & strCPF & "','" & strEnd & "','" & strNum & "','" & strComplemento & "','" & strBairro & "','" & strCep & "','" & strCidade & "','" & strUF & "','" & strTel & "','" & strFax & "','" & strCel & "','" & strEmail & "','" & strData & "','" & strRG & "','','" & strSite & "','" & strFant & "','" & strStatus & "','" & strObs & "',1,'F','False')")
                Else

                    strCPF = "000" & GerarCodigo("Fornecedor", "Codigo", 0) & "0"
                    Inserir("INSERT INTO Fornecedor (Nome, CPF, Endereco, Numero, Complemento, Bairro, Cep, Cidade, Estado, Telefone, Fax, Celular, Email, Data, IE, Contato, Site, Fantasia, Status, Obs, CodConfig, Tipo, Inativo) VALUES ('" & strNome & "','" & strCPF & "','" & strEnd & "','" & strNum & "','" & strComplemento & "','" & strBairro & "','" & strCep & "','" & strCidade & "','" & strUF & "','" & strTel & "','" & strFax & "','" & strCel & "','" & strEmail & "','" & strData & "','" & strRG & "','','" & strSite & "','" & strFant & "','" & strStatus & "','" & strObs & "',1,'F','False')")

                End If
            End If
            

        Next
        'Dim dt As DataTable = CarregarDataTableExcel("C:\NANO\", "CONTA")

        'Dim I As Integer
        'Dim A As Integer = 1
        'For I = 0 To dt.Rows.Count - 1

        '    Dim strAnimal As String = dt.Rows.Item(I).Item("NomeAnimal").ToString.Replace("'", "´")
        '    Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString.Replace("'", "´")

        '    If strNome.Contains(",") Then
        '        Dim vetNome As Array = Split(strNome, ",")

        '        strNome = vetNome(1).ToString.Trim & " " & vetNome(0).ToString.Trim
        '    End If
        '    strNome = strNome.ToUpper.Trim

        '    Dim strRG As String = ""
        '    If strRG.Length > 15 Then
        '        strRG = strRG.Substring(0, 15)
        '    End If
        '    Dim strCPF As String = GerarCodigo("Cliente", "Codigo", 1)
        '    'If strCPF <> "" Then
        '    '    If strCPF.Length = 14 Then
        '    '        strCPF = AddPonto(strCPF, "J")
        '    '    ElseIf strCPF.Length = 11 Then
        '    '        strCPF = AddPonto(strCPF, "F")
        '    '    End If
        '    'Else
        '    '    strCPF = A
        '    '    A += 1
        '    'End If
        '    Dim strCodigo As String = ""

        '    Dim dtCliente As DataTable = CarregarDataTable("SELECT Codigo FROM Cliente where Nome = '" & strNome & "'")
        '    If dtCliente.Rows.Count = 0 Then

        '        Dim strEnd As String = ""
        '        Dim strTel As String = dt.Rows.Item(I).Item("Telefone").ToString.Replace("'", "´")
        '        If strTel.Length > 18 Then
        '            strTel = strTel.Substring(0, 18)
        '        End If
        '        Dim strFax As String = ""
        '        If strFax.Length > 18 Then
        '            strFax = strFax.Substring(0, 18)
        '        End If
        '        Dim strCel As String = ""
        '        If strCel.Length > 18 Then
        '            strCel = strCel.Substring(0, 18)
        '        End If
        '        Dim strEmail As String = ""
        '        Dim strData As String = Date.Today
        '        'If dt.Rows.Item(I).Item("Data").ToString <> "" Then
        '        '    strData = dt.Rows.Item(I).Item("Data").ToString
        '        'End If
        '        Dim strNum As String = ""
        '        Dim strComp As String = ""
        '        Dim strBairro As String = ""
        '        Dim strCep As String = ""
        '        Dim strCidade As String = ""
        '        Dim strUF As String = ""
        '        Dim strFant As String = ""
        '        Dim bolIna As Boolean = False
        '        Dim strObs As String = ""
        '        Dim strStatus As String = ""
        '        Dim strNascCliente As String = ""

        '        Dim strSexoCliente As String = ""
        '        Dim strLimite As String = "1000"
        '        Dim strEmpresa As String = ""
        '        Dim strSalario As String = ""
        '        Dim strTelEmp As String = ""
        '        Dim strCredito As String = ""
        '        Dim strMarca As String = ""
        '        Dim strCodConfig As String = 1
        '        Dim strP1 As String = ""
        '        Dim strP2 As String = ""
        '        Dim strRG1 As String = ""
        '        Dim strRG2 As String = ""
        '        Dim bolInativo As Boolean = False

        '        Inserir("INSERT INTO Cliente (Nome, RGIE, CPF, Endereco, Telefone, Fax, Celular, Email, Data, " & _
        '        "Numero, Complemento, Bairro, Cep, Cidade, Estado, Fantasia, Inadimplente, Observacao, Status, " & _
        '        "Nascimento, Sexo, Limite, Empresa, TelEmpresa, Salario, Credito, Marcas, CodConfig, Pessoa1, " & _
        '        "Pessoa2, RG1, RG2, Inativo) VALUES ('" & strNome.Replace("'", "´") & "','" & strRG & "','" & strCPF & "'," & _
        '        "'" & strEnd.Replace("'", "´") & "','" & strTel & "','" & strFax & "','" & strCel & "','" & strEmail & "'," & _
        '        "'" & strData & "','" & strNum & "','" & strComp & "','" & strBairro.Replace("'", "´") & "','" & strCep & "'," & _
        '        "'" & strCidade.Replace("'", "´") & "','" & strUF & "','" & strFant & "','" & bolIna & "'," & _
        '        "'" & strObs.Replace("'", "´") & "','" & strStatus & "','" & strNascCliente & "','" & strSexoCliente & "'," & _
        '        "'" & strLimite & "','" & strEmpresa & "','" & strTelEmp & "','" & strSalario & "','" & strCredito & "'," & _
        '        "'" & strMarca & "'," & strCodConfig & ",'" & strP1 & "','" & strP2 & "','" & strRG1 & "','" & strRG2 & "','" & bolInativo & "')")

        '        strCodigo = GerarCodigo("Cliente", "Codigo", 1) - 1
        '    Else
        '        strCodigo = dtCliente.Rows.Item(0).Item("Codigo").ToString.Replace("'", "´")
        '    End If
        '    Dim strSaldo As String = dt.Rows.Item(I).Item("Saldo").ToString.Replace("'", "´")

        '    Inserir("INSERT INTO ContaReceber (CodOrdem, DataVenda, CodCli, Obs, FormaPagamento, Parcelas, " & _
        '     "ValorParcela, Vencimento, ValorVenda, ValorRecebido, RecebidoOK, Pagamento, NumeroDocumento, " & _
        '     "TipoCusto, Banco, CodConfig, Comissao) VALUES (1,'" & Date.Today & "'," & strCodigo & ",'','DINHEIRO'," & _
        '     "'1/1'," & Num(strSaldo) & ",'24/04/2015'," & Num(strSaldo) & ",0,'" & False & "','','','F','',1,0)")


        '    Dim dtAnimal As DataTable = CarregarDataTable("SELECT Codigo FROM Animal where CodCli = " & strCodigo & " and Nome = '" & strAnimal & "'")
        '    If dtAnimal.Rows.Count = 0 Then

        '        Dim strNasc As String = ""
        '        Dim strEspecie As String = dt.Rows.Item(I).Item("Especie").ToString.Replace("'", "´").Trim
        '        Dim strRaca As String = dt.Rows.Item(I).Item("Raca").ToString.Replace("'", "´").Trim
        '        Dim strSexo As String = ""
        '        If strSexo.Length > 1 Then
        '            strSexo = strSexo.Substring(0, 1)
        '        End If
        '        Dim strPelagem As String = ""
        '        Dim strFicha As String = ""
        '        Dim strVivo As Boolean = True
        '        Dim strUltimaVisita As String = "01/01/1900"

        '        Inserir("INSERT INTO Animal (Nome, CodEletronico, Especie, Sexo, Vivo, Raca, Pelagem, Nascimento, " & _
        '        "Data, Ficha, CodCli) VALUES ('" & strAnimal & "','','" & strEspecie & "'," & _
        '        "'" & strSexo & "','" & strVivo & "','" & strRaca & "','" & strPelagem & "','" & strNasc & "'," & _
        '        "'" & strUltimaVisita & "','" & strFicha & "'," & strCodigo & ")")


        '    End If



        'Next
    End Sub

    Private Sub btnTamanhoQtd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTamanhoQtd.ItemClick
        frmRelProdTamanho.Tag = "ESTOQUE"
        frmRelProdTamanho.Show()
    End Sub

    Private Sub btnInformativo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInformativo.ItemClick
        frmRelInformativo.Show()
    End Sub

    Private Sub btnCMV_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCMV.ItemClick
        frmRelCMV.Show()
    End Sub

    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCadastrarComissao.ItemClick
        frmRepresentacao.Show()
    End Sub

    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCredDeb.ItemClick
        frmGastosFunc.Tag = "CADASTRA"
        frmGastosFunc.Show()
    End Sub

    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConsultarCredDeb.ItemClick
        frmGastosFunc.Tag = "CONSULTA"
        frmGastosFunc.Show()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'If Me.rdgTipoGrafico.SelectedIndex = 0 Then
        '    GerarGraficoSemanal(Me.Grafico)
        'Else
        '    GerarGraficoDecimal(Me.Grafico)
        'End If

        'GerarGrafico2(Me.Grafico2)
        'Agenda()
        'Resumo()
        'Agenda()
        IniciaThread()

        Timer2.Stop()
    End Sub


    Private Sub rdgGrafico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgGrafico.SelectedIndexChanged
        If Me.rdgTipoGrafico.SelectedIndex = 0 Then
            GerarGraficoSemanal(Me.Grafico)
        Else
            GerarGraficoDecimal(Me.Grafico)
        End If
    End Sub

    Private Sub rdgGrafico2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgGrafico2.SelectedIndexChanged
        GerarGrafico2(Me.Grafico2)
    End Sub


    Private Sub btnVisuaGrafico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisuaGrafico.Click
        Dim rel As New relGrafico
        rel.picLogo.Image = LogoTipo
        If Me.rdgTipoGrafico.SelectedIndex = 0 Then
            rel.lblTitulo.Text = "Relatório de Vendas por Semana"
        Else
            rel.lblTitulo.Text = "Relatório de Vendas por 10 Dias"
        End If

        If Me.rdgTipoGrafico.SelectedIndex = 0 Then
            GerarGraficoSemanal(rel.GraficoPrincipal)
        Else
            GerarGraficoDecimal(rel.GraficoPrincipal)
        End If

        rel.GraficoPrincipal.PaletteName = "Padrao"
        rel.GraficoPrincipal.BackColor = Color.White
        If Me.rdgGrafico.SelectedIndex <= 1 Then
            If intNumSerie1 > 0 Then
                CType(rel.GraficoPrincipal.Diagram, XYDiagram).DefaultPane.BackColor = Color.White
            End If

        End If
        rel.ShowPreview()
    End Sub

    Private Sub btnVisuaGrafico2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisuaGrafico2.Click
        Dim rel As New relGrafico
        rel.picLogo.Image = LogoTipo

        rel.lblTitulo.Text = "Relatório de Vendas por Funcionário"

        GerarGrafico2(rel.GraficoPrincipal)

        rel.GraficoPrincipal.PaletteName = "Padrao"
        rel.GraficoPrincipal.BackColor = Color.White
        If Me.rdgGrafico2.SelectedIndex <= 1 Then
            If intNumSerie2 > 0 Then
                CType(rel.GraficoPrincipal.Diagram, XYDiagram).DefaultPane.BackColor = Color.White
            End If

        End If
        rel.ShowPreview()
    End Sub


    Private Sub DateNavigator1_EditDateModified(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateNavigator1.EditDateModified
        Agenda()
    End Sub


    Private Sub btnEnviarContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarContato.Click
        If Validar(Me.txtNomeContato) = False Then Exit Sub
        If Validar(Me.txtEmailContato) = False Then Exit Sub
        If Validar(Me.rtfContato) = False Then Exit Sub

        If Me.txtEmailContato.Text.Contains("@") = False Then
            MsgBox("Email inválido!", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Me.txtEmailContato.Text.Contains(".com") = False Then
            MsgBox("Email inválido!", MsgBoxStyle.Information)
            Exit Sub
        End If


        Dim strEmail As String = ""
       
        Dim strTipoContato As String = ""
        Select Case Me.rdgTipoContato.SelectedIndex
            Case 0
                strTipoContato = "ELOGIO"
            Case 1
                strTipoContato = "SUGESTÃO"
            Case 2
                strTipoContato = "RECLAMAÇÃO"
            Case 3
                strTipoContato = "SUPORTE"
        End Select


        Dim strTexto As String
        Dim vet As Array = Nothing

        Dim rel As New relMail
        Dim strTeste As String = "{\rtf1\ansi\ansicpg1252\deff0\deflang1046{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}\viewkind4\uc1\pard\f0\fs17 " & strTipoContato & "\par" & vbCrLf
        strTeste = strTeste & " \par" & vbCrLf
        strTeste = strTeste & "\viewkind4\uc1\pard\f0\fs17 Nome: " & Me.txtNomeContato.Text & "\par" & vbCrLf
        strTeste = strTeste & "\viewkind4\uc1\pard\f0\fs17 Email: " & Me.txtEmailContato.Text & "\par" & vbCrLf
        strTeste = strTeste & " \par" & vbCrLf
        strTeste = strTeste & Me.rtfContato.Rtf.Replace("{\rtf1\ansi\ansicpg1252\deff0\deflang1046{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}", "")
        Dim I As Integer
        Dim strChar As String

        For I = 0 To strTeste.Length
            strChar = strTeste.Substring(strTeste.Length - 1)
            strTeste = strTeste.Substring(0, strTeste.Length - 1)

            If strChar = "}" Then
                Exit For
            End If
        Next

        strTeste = strTeste & " \par" & vbCrLf & "\par" & vbCrLf & "\par" & vbCrLf & "\par" & vbCrLf


        strTeste = strTeste & "_______________________________________________________________________________________________________________ \par" & vbCrLf
        strTeste = strTeste & " \par" & vbCrLf
        strTeste = strTeste & NomeEmpresa & " \par" & vbCrLf
        strTeste = strTeste & TelefoneEmpresa & " \par" & vbCrLf
        strTeste = strTeste & EnderecoEmpresa & " \par" & vbCrLf
        strTeste = strTeste & " \par" & vbCrLf & "\par" & vbCrLf & "\par" & vbCrLf & "." & vbCrLf & "}"

        rel.rtMail.Rtf = strTeste

        rel.ExportToHtml("C:/NANO/Mail.html")
        strTexto = LerArquivoMail("C:/NANO/Mail.html")


        Dim strFrom As String = "erasyst@gmail.com"
        Dim strSenha As String = "spfc4*5*6*"
        Dim strServidorSaida As String = "smtp.gmail.com"
        Dim strPortaSaida As String = "587"
        Dim strServico As String = "Gmail"

        If enviaMensagemEmail(strFrom, strSenha, strEmailRepresentante, "", "", "Contato", strTexto, strServidorSaida, "0", False, "", strPortaSaida, strServico, Nothing) = True Then
            Me.txtEmailContato.ResetText()
            Me.txtNomeContato.ResetText()
            Me.rtfContato.ResetText()
            Me.rdgTipoContato.SelectedIndex = 0
        End If


    End Sub

    Private Sub NavBarControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbcEraSystems.Click
        Try
            If Me.nbcEraSystems.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed Then
                If Me.nbcEraSystems.NavPaneForm.ExpandedGroup.Expanded = True Then
                    ' Me.NavBarControl3.NavPaneForm.ExpandedGroup.Expanded = False
                    Me.nbcEraSystems.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub NavBarControl1_NavPaneStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbcEraSystems.NavPaneStateChanged
        If Me.nbcEraSystems.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded Then
            Me.btnOcultarCanal.Visible = True
            Me.nbgContato.Caption = "Fale Conosco"
            Me.nbgHistorico.Caption = "Histórico de Versões"
            Me.nbgSuporte.Caption = "Suporte"
            Me.nbcEraSystems.Size = New System.Drawing.Size(325, 564)
            Me.nbcEraSystems.PaintStyleName = "ExplorerBarView"

            Me.nbgContato.Appearance.BackColor = Color.White
            Me.nbgHistorico.Appearance.BackColor = Color.White
            Me.nbgSuporte.Appearance.BackColor = Color.White
            Me.nbgContato.GroupClientHeight = 320
            Me.nbgHistorico.GroupClientHeight = 320
            Me.nbgSuporte.GroupClientHeight = 120
            Me.nbgContato.Expanded = True
            Me.rdgTipoContato.SelectedIndex = 3
        Else
            Me.btnOcultarCanal.Visible = False
            Me.nbgSuporte.Caption = strRepresentante
            Me.nbgContato.Caption = strRepresentante
            Me.nbgHistorico.Caption = strRepresentante

        End If

        If Me.NavBarControl3.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded Then
            Dim intA As Integer = Me.pnlPedido.Size.Height
            Dim intL As Integer = Me.pnlPedido.Size.Width

            Dim intPed As Integer = (intA * 535) / 568

            Me.NavBarControl3.Size = New System.Drawing.Size(intL, intA)
            Me.NavBarControl3.OptionsNavPane.ExpandedWidth = intL
            Me.nbgPedido.GroupClientHeight = intPed
        End If
    End Sub

    Private Sub GridView1_CustomDrawGroupRow(ByVal sender As Object, ByVal e As RowObjectCustomDrawEventArgs) Handles GridView1.CustomDrawGroupRow
        Dim view As GridView = CType(sender, GridView)

        Dim groupRowInfo As GridGroupRowInfo = e.Info
        Dim groupRowBounds As Rectangle = groupRowInfo.DataBounds
        Dim expandButtonBounds As Rectangle = groupRowInfo.ButtonBounds
        Dim textBounds As Rectangle = e.Bounds
        textBounds.X = expandButtonBounds.Right + 4

        Dim brush As Brush = e.Cache.GetGradientBrush(groupRowBounds, Color.White, _
          Color.LemonChiffon, LinearGradientMode.Horizontal)

        Dim brushText As Brush = Brushes.Navy, brushTextShadow As Brush = Brushes.Navy
        e.Graphics.FillRectangle(brush, groupRowBounds)

        Dim strtt As StringFormat = New StringFormat(StringFormatFlags.NoWrap)
        Dim strFont As Font = New System.Drawing.Font("Tahoma", 10, FontStyle.Bold, GraphicsUnit.Point)
        Dim s As String = view.GetGroupRowDisplayText(e.RowHandle).Replace("Grupo: ", "")

        view.SetRowCellValue(e.RowHandle, "Grupo", s)
        e.Appearance.DrawString(e.Cache, s, New Rectangle(textBounds.X + 1, textBounds.Y + 1, _
        textBounds.Width, textBounds.Height), strFont, brushTextShadow, strtt)

        e.Handled = True
    End Sub
    Private Sub GridView1_GroupLevelStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GroupLevelStyleEventArgs) Handles GridView1.GroupLevelStyle
        If e.Level = 0 Then
            e.LevelAppearance.BackColor = Color.White
        Else
            e.LevelAppearance.BackColor = Color.White
        End If
    End Sub

    Private Sub nbgContato_ItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbgContato.ItemChanged
        If Me.nbgContato.Expanded = False Then
        Else
            Me.nbgHistorico.Expanded = False
        End If
    End Sub

    Private Sub nbgHistorico_ItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbgHistorico.ItemChanged
        If Me.nbgHistorico.Expanded = False Then
        Else
            Me.nbgContato.Expanded = False
        End If
    End Sub

    Private Sub btnOcultarCanal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOcultarCanal.Click
        Me.nbcEraSystems.PaintStyleName = "SkinNavigationPane"
        Me.nbcEraSystems.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
    End Sub

    Private Shared Function CalcularHora(ByVal parIni As String, ByVal parTer As String) As String

        Dim HoraIni, HoraFim As DateTime
        Dim tsTotal As TimeSpan

        Try
            HoraIni = parIni
            HoraFim = parTer

        Catch ex As Exception
            MsgBox("Os campos de Hora devem estar preenchidos e no formato correto!", MsgBoxStyle.Information)

        End Try

        tsTotal = HoraFim.Subtract(HoraIni)
        Dim strDuracao As String



        strDuracao = tsTotal.Hours.ToString("00").Replace("-", "") & ":" & tsTotal.Minutes.ToString("00").Replace("-", "")

        If HoraIni < HoraFim Then
            HoraFim = "23:59:59"
            strDuracao = HoraFim.Subtract(tsTotal)
            HoraFim = strDuracao
            strDuracao = HoraFim.AddSeconds(1)

        End If

        Dim strHoraIni(1) As String

        strHoraIni = strDuracao.Split(":"(0))


        If strHoraIni.Length = 1 Then
            MsgBox("Formato de Hora incorreto, favor informar a quantidade de horas no padrão 00:00!", MsgBoxStyle.Information)
            Return ""
            Exit Function
        End If


        Dim strHoras As String = strHoraIni(1)

        If strHoras = "" Or strHoras.Length = 1 Or strHoras.Length > 2 Then
            MsgBox("Formato de Hora incorreto, favor informar a quantidade de horas no padrão 00:00!", MsgBoxStyle.Information)
            Return ""
            Exit Function
        End If
        Return strDuracao
    End Function

    Private Sub SchedulerStorage1_ReminderAlert(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.ReminderEventArgs) Handles SchedulerStorage1.ReminderAlert
        bolAlerte = True
    End Sub

    Private Sub scData_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.AppointmentFormEventArgs) Handles scData.EditAppointmentFormShowing
        Dim apt As Appointment = e.Appointment

        ' Required to open the recurrence form via context menu.
        Dim openRecurrenceForm As Boolean = apt.IsRecurring AndAlso SchedulerStorage1.Appointments.IsNewAppointment(apt)

        ' Create a custom form.
        Dim myForm As New UI.AppointmentForm(CType(sender, SchedulerControl), apt, openRecurrenceForm)

        Try
            myForm.Controls(20).Visible = False
            myForm.LookAndFeel.ParentLookAndFeel = Me.scData.LookAndFeel
            e.DialogResult = myForm.ShowDialog()
            Me.scData.Refresh()
            e.Handled = True
        Finally
            myForm.Dispose()
        End Try
    End Sub

    Private Sub scData_RemindersFormShowing(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.RemindersFormEventArgs) Handles scData.RemindersFormShowing
        Dim control As SchedulerControl = TryCast(sender, SchedulerControl)
        Dim arg As ReminderEventArgs = New ReminderEventArgs(e.AlertNotifications)

        frmReminder = New DevExpress.XtraScheduler.Forms.RemindersForm(Me.SchedulerStorage1)

        frmReminder.OnReminderAlert(arg)
        frmReminder.Visible = False

        e.Handled = True
        frmReminder.ShowDialog()
        frmReminder.Dispose()

        Agenda()

        bolAlerte = False
    End Sub

    Private Sub rdgTipoGrafico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgTipoGrafico.SelectedIndexChanged
        If Me.rdgTipoGrafico.SelectedIndex = 0 Then
            GerarGraficoSemanal(Me.Grafico)
        Else
            GerarGraficoDecimal(Me.Grafico)
        End If
    End Sub

    Private Sub rdgTipoGrafico2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgTipoGrafico2.SelectedIndexChanged
        GerarGrafico2(Me.Grafico2)
    End Sub

    Private Sub SchedulerStorage1_AppointmentsChanged(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PersistentObjectsEventArgs) Handles SchedulerStorage1.AppointmentsChanged
        GerarGrafico2(Me.Grafico2)
    End Sub

    Private Sub Resumo()

        Me.tbResumo.Rows.Clear()

        Dim strData As String = "Day(Nascimento) ='" & Date.Today.Day & "' and Month(Nascimento) ='" & Date.Today.Month & "'"

        Dim dtAvisos As DataTable

        dtAvisos = CarregarDataTable("Select Codigo from Cliente where " & strData)

        Me.tbResumo.Rows.Add()
        Me.tbResumo.Rows.Item(Me.tbResumo.Rows.Count - 1).Item("Titulo") = "   Aniversariantes"
        Me.tbResumo.Rows.Item(Me.tbResumo.Rows.Count - 1).Item("Valor") = dtAvisos.Rows.Count
        Me.tbResumo.Rows.Item(Me.tbResumo.Rows.Count - 1).Item("Grupo") = "1-Cliente"

        Dim strFiltroMaster As String = ""
        If Master = False Then
            strFiltroMaster = " and CodConfig = " & CodConfig
        End If
        strData = String.Format("Vencimento= '{0:dd/MM/yyyy}'", Date.Today)

        dtAvisos = CarregarDataTable("Select sum(ValorParcela) from ContaReceber where " & strData & " and RecebidoOK = 'false'" & strFiltroMaster)

        Dim dblTotCR As Double = 0

        If dtAvisos.Rows.Count > 0 Then
            If dtAvisos.Rows.Item(0).Item(0).ToString <> "" Then
                dblTotCR = dtAvisos.Rows.Item(0).Item(0).ToString
            End If
        End If

        Me.tbResumo.Rows.Add()
        Me.tbResumo.Rows.Item(Me.tbResumo.Rows.Count - 1).Item("Titulo") = "   Total a Receber"
        Me.tbResumo.Rows.Item(Me.tbResumo.Rows.Count - 1).Item("Valor") = dblTotCR.ToString("###,###,###,##0.00")
        Me.tbResumo.Rows.Item(Me.tbResumo.Rows.Count - 1).Item("Grupo") = "2-Contas"

        strData = String.Format("Vencimento= '{0:dd/MM/yyyy}'", Date.Today)

        dtAvisos = CarregarDataTable("Select sum(ValorParcela) from ContaPagar where " & strData & " and PagoOK = 'False'" & strFiltroMaster)

        Dim dblTotCP As Double = 0

        If dtAvisos.Rows.Count > 0 Then
            If dtAvisos.Rows.Item(0).Item(0).ToString <> "" Then
                dblTotCP = dtAvisos.Rows.Item(0).Item(0).ToString
            End If
        End If

        Me.tbResumo.Rows.Add()
        Me.tbResumo.Rows.Item(Me.tbResumo.Rows.Count - 1).Item("Titulo") = "   Total a Pagar"
        Me.tbResumo.Rows.Item(Me.tbResumo.Rows.Count - 1).Item("Valor") = dblTotCP.ToString("###,###,###,##0.00")
        Me.tbResumo.Rows.Item(Me.tbResumo.Rows.Count - 1).Item("Grupo") = "2-Contas"

        strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Date.Today, Date.Today.AddDays(1))

        Dim G As Integer

        Dim dt As DataTable = CarregarDataTable("Select Pagamento, sum(Valor) from Caixa where " & strData & strFiltroMaster & " AND Credito = 'D' and Motivo like '%TROCO%' GROUP BY Pagamento")

        Dim dblTroco As Double

        For G = 0 To dt.Rows.Count - 1
            dblTroco += CDbl(dt.Rows.Item(G).ItemArray(1).ToString)
        Next

        'dt = CarregarDataTable("Select Pagamento, sum(Valor) from Caixa where " & strData & strFiltroMaster & " AND Credito = 'D' and Motivo not like '%TROCO%' and Pagamento = 'DINHEIRO' GROUP BY Pagamento")

        Dim dblDinheiro As Double

        'For G = 0 To dt.Rows.Count - 1
        '    dblDinheiro += CDbl(dt.Rows.Item(G).ItemArray(1).ToString)
        'Next

        'dt = CarregarDataTable("Select Pagamento, sum(Valor) from Caixa where " & strData & strFiltroMaster & "  AND Credito = 'C' GROUP BY Pagamento")

        'Dim dblCred As Double = 0

        'For G = 0 To dt.Rows.Count - 1
        '    Dim dblVal As Double = dt.Rows.Item(G).ItemArray(1).ToString
        '    If dt.Rows.Item(G).ItemArray(0).ToString = "DINHEIRO" Then
        '        dblVal = (dblVal - dblTroco) - dblDinheiro
        '    End If

        '    Dim strPag As String = dt.Rows.Item(G).ItemArray(0).ToString

        '    Me.tbResumo.Rows.Add()
        '    Me.tbResumo.Rows.Item(Me.tbResumo.Rows.Count - 1).Item("Titulo") = "   " & strPag.Substring(0, 1) & strPag.Substring(1, strPag.Length - 1).ToLower
        '    Me.tbResumo.Rows.Item(Me.tbResumo.Rows.Count - 1).Item("Valor") = dblVal.ToString("###,###,###,##0.00")
        '    Me.tbResumo.Rows.Item(Me.tbResumo.Rows.Count - 1).Item("Grupo") = "3-Caixa"
        '    dblCred += dblVal
        'Next

        'dt = CarregarDataTable("Select Pagamento, sum(Valor) from Caixa where " & strData & strFiltroMaster & " AND Credito = 'D' and Motivo not like '%TROCO%' GROUP BY Pagamento")

        'Dim dlbDeb As Double

        'For G = 0 To dt.Rows.Count - 1
        '    'If dt.Rows.Item(G).ItemArray(0).ToString <> "DINHEIRO" Then
        '    Dim dblVal As Double = dt.Rows.Item(G).ItemArray(1).ToString
        '    dlbDeb += dblVal
        '    'End If
        '    Dim strPag As String = dt.Rows.Item(G).ItemArray(0).ToString
        '    Dim dblVal2 As Double = dt.Rows.Item(G).ItemArray(1).ToString
        '    Me.tbResumo.Rows.Add()
        '    Me.tbResumo.Rows.Item(Me.tbResumo.Rows.Count - 1).Item("Titulo") = "   " & strPag.Substring(0, 1) & strPag.Substring(1, strPag.Length - 1).ToLower
        '    Me.tbResumo.Rows.Item(Me.tbResumo.Rows.Count - 1).Item("Valor") = "-" & dblVal2.ToString("###,###,###,##0.00")
        '    Me.tbResumo.Rows.Item(Me.tbResumo.Rows.Count - 1).Item("Grupo") = "3-Caixa"
        'Next

        'Dim dblResul As Double = dblCred - dlbDeb


        dt = CarregarDataTable("Select Pagamento, sum(Valor) from Caixa where " & strData & strFiltroMaster & "  AND Credito = 'C' GROUP BY Pagamento")

        Dim dblCred As Double = 0

        For G = 0 To dt.Rows.Count - 1
            Dim dblVal As Double = dt.Rows.Item(G).ItemArray(1).ToString
            Dim strPag As String = dt.Rows.Item(G).ItemArray(0).ToString

            Me.tbResumo.Rows.Add()
            Me.tbResumo.Rows.Item(Me.tbResumo.Rows.Count - 1).Item("Titulo") = "   " & strPag.Substring(0, 1) & strPag.Substring(1, strPag.Length - 1).ToLower
            Me.tbResumo.Rows.Item(Me.tbResumo.Rows.Count - 1).Item("Valor") = dblVal.ToString("###,###,###,##0.00")
            Me.tbResumo.Rows.Item(Me.tbResumo.Rows.Count - 1).Item("Grupo") = "3-Caixa"
            dblCred += dblVal
        Next

        dt = CarregarDataTable("Select Pagamento, sum(Valor) from Caixa where " & strData & strFiltroMaster & " AND Credito = 'D' GROUP BY Pagamento")

        Dim dlbDeb As Double
        Dim A As Integer = 0
        Dim bolDebito As Boolean = False
        For G = 0 To dt.Rows.Count - 1

            Dim dblVal As Double = dt.Rows.Item(G).ItemArray(1).ToString
            dlbDeb += dblVal
            Dim strPag As String = dt.Rows.Item(G).ItemArray(0).ToString
            For A = 0 To Me.tbResumo.Rows.Count - 1
                If Me.tbResumo.Rows.Item(A).Item("Grupo") = "3-Caixa" Then
                    Dim strPag2 As String = Me.tbResumo.Rows.Item(A).Item("Titulo")
                    Dim strPag3 As String = "   " & strPag.Substring(0, 1) & strPag.Substring(1, strPag.Length - 1).ToLower
                    If strPag2 = strPag3 Then
                        Dim dblVal2 As Double = Me.tbResumo.Rows.Item(A).Item("Valor")
                        dblVal2 = dblVal2 - dblVal
                        Me.tbResumo.Rows.Item(A).Item("Valor") = dblVal2.ToString("###,###,###,##0.00")
                        bolDebito = True
                        Exit For
                    End If
                End If
            Next
            If bolDebito = False Then
                Me.tbResumo.Rows.Add()
                Me.tbResumo.Rows.Item(Me.tbResumo.Rows.Count - 1).Item("Titulo") = "   " & strPag.Substring(0, 1) & strPag.Substring(1, strPag.Length - 1).ToLower
                Me.tbResumo.Rows.Item(Me.tbResumo.Rows.Count - 1).Item("Valor") = "-" & dblVal.ToString("###,###,###,##0.00")
                Me.tbResumo.Rows.Item(Me.tbResumo.Rows.Count - 1).Item("Grupo") = "3-Caixa"
            End If
            bolDebito = False
        Next

        Dim dblResul As Double = dblCred - dlbDeb


        Me.tbResumo.Rows.Add()
        Me.tbResumo.Rows.Item(Me.tbResumo.Rows.Count - 1).Item("Titulo") = "   Caixa Saldo"
        Me.tbResumo.Rows.Item(Me.tbResumo.Rows.Count - 1).Item("Valor") = dblResul.ToString("###,###,###,##0.00")
        Me.tbResumo.Rows.Item(Me.tbResumo.Rows.Count - 1).Item("Grupo") = "3-Caixa"

        Me.GridView1.ExpandAllGroups()
    End Sub
    Private Sub SchedulerStorage1_AppointmentInserting(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PersistentObjectCancelEventArgs) Handles SchedulerStorage1.AppointmentInserting

        If (CType(e.Object, Appointment)).CustomFields.Item("CodOrdem") Is Nothing Then
            strCodOrdemAgenda = 0
        Else
            strCodOrdemAgenda = (CType(e.Object, Appointment)).CustomFields.Item("CodOrdem")
        End If

        If (CType(e.Object, Appointment)).CustomFields.Item("Conta") Is Nothing Then
            bolConta = False
        Else
            Dim strConta As String = (CType(e.Object, Appointment)).CustomFields.Item("Conta").ToString
            If strConta <> "" Then
                bolConta = (CType(e.Object, Appointment)).CustomFields.Item("Conta")
            End If
        End If

        intType = 0

        If (CType(e.Object, Appointment)).Start.ToString Is Nothing Then
            strStartDate = ""
        Else
            strStartDate = (CType(e.Object, Appointment)).Start.ToString
        End If

        If (CType(e.Object, Appointment)).End.ToString Is Nothing Then
            strEndDate = ""
        Else
            strEndDate = (CType(e.Object, Appointment)).End.ToString
        End If

        If (CType(e.Object, Appointment)).AllDay.ToString Is Nothing Then
            bolAllDay = False
        Else
            bolAllDay = (CType(e.Object, Appointment)).AllDay
        End If

        If (CType(e.Object, Appointment)).Subject Is Nothing Then
            strSubject = ""
        Else
            strSubject = (CType(e.Object, Appointment)).Subject.ToString
        End If

        If (CType(e.Object, Appointment)).Location Is Nothing Then
            strLocation = ""
        Else
            strLocation = (CType(e.Object, Appointment)).Location
        End If

        If (CType(e.Object, Appointment)).Description Is Nothing Then
            strDescription = ""
        Else
            strDescription = (CType(e.Object, Appointment)).Description
        End If

        If (CType(e.Object, Appointment)).StatusId.ToString Is Nothing Then
            intStatus = 2
        Else
            intStatus = (CType(e.Object, Appointment)).StatusId
        End If

        If (CType(e.Object, Appointment)).LabelId.ToString Is Nothing Then
            intLabel = ""
        Else
            intLabel = (CType(e.Object, Appointment)).LabelId
        End If
        Dim bolReminder As Boolean = False
        If (CType(e.Object, Appointment)).HasReminder.ToString Is Nothing Then
            bolReminder = False
        Else
            bolReminder = (CType(e.Object, Appointment)).HasReminder
        End If

        If bolReminder = True Then

            If (CType(e.Object, Appointment)).Reminder.TimeBeforeStart.ToString Is Nothing Then
                strRemider = ""
            Else
                strRemider = (CType(e.Object, Appointment)).Reminder.TimeBeforeStart.ToString

                If strRemider.Contains(".") = True Then
                    Dim vetRemider As Array = Split(strRemider, ".")
                    Dim intDia As Integer = vetRemider(0)
                    Dim dtRemider As Date = strStartDate

                    strRemider = Format(dtRemider.AddDays(-intDia), "MM/dd/yyyy HH:mm:ss")


                    strRemider = "<Reminders><Reminder AlertTime=""" & strRemider & """ /></Reminders>"
                Else
                    Dim dtRemider As Date = strStartDate
                    Dim strHora1 As String = Format(dtRemider, "HH:mm:ss")
                    Dim strHora2 As String = strRemider

                    strRemider = CalcularHora(strHora1, strHora2)

                    Dim dtHora As Date = strRemider
                    Dim dtHoraIni As Date = strHora1



                    If dtHora > dtHoraIni Then
                        dtRemider = dtRemider.AddDays(-1)
                        strRemider = Format(dtRemider, "MM/dd/yyyy") & " " & strRemider
                    Else
                        strRemider = Format(dtRemider, "MM/dd/yyyy") & " " & strRemider
                    End If
                    strRemider = "<Reminders><Reminder AlertTime=""" & strRemider & """ /></Reminders>"

                End If
            End If
        End If

        strCodOrdemAgenda = GerarCodigo("Agenda", "CodOrdem", CodConfig)

        Inserir("INSERT INTO Agenda (CodOrdem, Type, StartDate, EndDate, AllDay, Subject, Location, Description, " & _
        "Status, Label, Conta, ReminderInfo, CodConfig) VALUES (" & strCodOrdemAgenda & "," & intType & ",'" & strStartDate & "','" & strEndDate & "'," & _
        "'" & bolAllDay & "','" & strSubject & "','" & strLocation & "','" & strDescription & "'," & intStatus & "," & intLabel & ",'False','" & strRemider & "'," & CodConfig & ")")

        LimparAgenda()
    End Sub
    Private Sub LimparAgenda()
        strCodOrdemAgenda = 0
        strRemider = ""
        intType = 0
        strStartDate = ""
        strEndDate = ""
        bolAllDay = False
        strSubject = ""
        strLocation = ""
        strDescription = ""
        intStatus = 0
        intLabel = 0
        bolConta = False
        Timer2.Start()
    End Sub

    Private Sub schedulerStorage1_AppointmentChanging(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PersistentObjectCancelEventArgs) Handles SchedulerStorage1.AppointmentChanging

        Dim intResulForm As Integer = Nothing

        If bolAlerte = True Then
            intResulForm = frmReminder.DialogResult
            If intResulForm = 2 Then Exit Sub
        End If

        If (CType(e.Object, Appointment)).CustomFields.Item("CodOrdem") Is Nothing Then
            strCodOrdemAgenda = 0
        Else
            strCodOrdemAgenda = (CType(e.Object, Appointment)).CustomFields.Item("CodOrdem")
        End If
        If (CType(e.Object, Appointment)).CustomFields.Item("Conta") Is Nothing Then
            bolConta = False
        Else
            Dim strConta As String = (CType(e.Object, Appointment)).CustomFields.Item("Conta").ToString
            If strConta <> "" Then
                bolConta = (CType(e.Object, Appointment)).CustomFields.Item("Conta")
            End If

        End If

        intType = 0


        If (CType(e.Object, Appointment)).Start.ToString Is Nothing Then
            strStartDate = ""
        Else
            strStartDate = (CType(e.Object, Appointment)).Start.ToString
        End If

        If (CType(e.Object, Appointment)).End.ToString Is Nothing Then
            strEndDate = ""
        Else
            strEndDate = (CType(e.Object, Appointment)).End.ToString
        End If

        If (CType(e.Object, Appointment)).AllDay.ToString Is Nothing Then
            bolAllDay = False
        Else
            bolAllDay = (CType(e.Object, Appointment)).AllDay
        End If

        If (CType(e.Object, Appointment)).Subject Is Nothing Then
            strSubject = ""
        Else
            strSubject = (CType(e.Object, Appointment)).Subject.ToString
        End If

        If (CType(e.Object, Appointment)).Location Is Nothing Then
            strLocation = ""
        Else
            strLocation = (CType(e.Object, Appointment)).Location
        End If

        If (CType(e.Object, Appointment)).Description Is Nothing Then
            strDescription = ""
        Else
            strDescription = (CType(e.Object, Appointment)).Description
        End If

        If (CType(e.Object, Appointment)).StatusId.ToString Is Nothing Then
            intStatus = 2
        Else
            intStatus = (CType(e.Object, Appointment)).StatusId
        End If

        If (CType(e.Object, Appointment)).LabelId.ToString Is Nothing Then
            intLabel = ""
        Else
            intLabel = (CType(e.Object, Appointment)).LabelId
        End If
        Dim bolReminder As Boolean = False

        If (CType(e.Object, Appointment)).HasReminder.ToString Is Nothing Then
            bolReminder = False
        Else
            bolReminder = (CType(e.Object, Appointment)).HasReminder
        End If
        If bolReminder = True Then

            If bolAlerte = False Then
                If (CType(e.Object, Appointment)).Reminder.TimeBeforeStart.ToString Is Nothing Then
                    strRemider = ""
                Else

                    strRemider = (CType(e.Object, Appointment)).Reminder.TimeBeforeStart.ToString

                End If
            Else

                strRemider = frmReminder.Controls.Item(4).Text
                Dim vetTempo As Array
                Dim dblTempo As Double
                If strRemider.ToUpper.Contains("MINUTO") Then
                    vetTempo = Split(strRemider.ToUpper, "MINUTO")

                    dblTempo = vetTempo(0)
                    strRemider = "00:" & Format(dblTempo, "00") & ":00"
                ElseIf strRemider.ToUpper.Contains("HORA") Then
                    vetTempo = Split(strRemider.ToUpper, "HORA")

                    dblTempo = vetTempo(0)
                    strRemider = Format(dblTempo, "00") & ":00:00"
                ElseIf strRemider.ToUpper.Contains("DIA") Then
                    vetTempo = Split(strRemider.ToUpper, "DIA")
                    If vetTempo(0).ToString.Contains(",") Then
                        dblTempo = vetTempo(0)
                        dblTempo = dblTempo * 24
                        strRemider = Format(dblTempo, "00") & ":00:00"
                    Else
                        dblTempo = vetTempo(0)
                        strRemider = Format(dblTempo, "00") & ".00:00:00"
                    End If

                ElseIf strRemider.ToUpper.Contains("SEMANA") Then
                    vetTempo = Split(strRemider.ToUpper, "DIA")

                    dblTempo = vetTempo(0)
                    dblTempo = dblTempo * 7
                    strRemider = Format(dblTempo, "00") & ".00:00:00"
                End If

            End If

            If strRemider <> "" Then
                If strRemider.Contains(".") = True Then
                    Dim vetRemider As Array = Split(strRemider, ".")
                    Dim intDia As Integer = vetRemider(0)
                    Dim dtRemider As Date = strStartDate

                    strRemider = Format(dtRemider.AddDays(-intDia), "MM/dd/yyyy HH:mm:ss")


                    strRemider = "<Reminders><Reminder AlertTime=""" & strRemider & """ /></Reminders>"
                Else
                    Dim dtRemider As Date = strStartDate
                    Dim strHora1 As String = Format(dtRemider, "HH:mm:ss")
                    Dim strHora2 As String = strRemider

                    strRemider = CalcularHora(strHora1, strHora2)

                    Dim dtHora As Date = strRemider
                    Dim dtHoraIni As Date = strHora1



                    If dtHora > dtHoraIni Then
                        dtRemider = dtRemider.AddDays(-1)
                        strRemider = Format(dtRemider, "MM/dd/yyyy") & " " & strRemider
                    Else
                        strRemider = Format(dtRemider, "MM/dd/yyyy") & " " & strRemider
                    End If
                    strRemider = "<Reminders><Reminder AlertTime=""" & strRemider & """ /></Reminders>"

                End If
            End If
        End If

        Atualizar("UPDATE Agenda SET Type = " & intType & ", StartDate = '" & strStartDate & "', " & _
              "EndDate = '" & strEndDate & "', AllDay = '" & bolAllDay & "', Subject = '" & strSubject & "', " & _
              "Location = '" & strLocation & "', Description = '" & strDescription & "', Status = " & intStatus & ", " & _
              "Label = " & intLabel & ", ReminderInfo = '" & strRemider & "' where CodOrdem = " & strCodOrdemAgenda & " and Codconfig = " & CodConfig)

        LimparAgenda()
    End Sub

    Private Sub SchedulerStorage1_AppointmentDeleting(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PersistentObjectCancelEventArgs) Handles SchedulerStorage1.AppointmentDeleting
        If (CType(e.Object, Appointment)).CustomFields.Item("CodOrdem") Is Nothing Then
            strCodOrdemAgenda = 0
        Else
            strCodOrdemAgenda = (CType(e.Object, Appointment)).CustomFields.Item("CodOrdem")
        End If
        If strCodOrdemAgenda > 0 Then
            Excluir("DELETE FROM Agenda where CodOrdem = " & strCodOrdemAgenda & " and Codconfig = " & CodConfig)
        End If

    End Sub
    Private Sub Agenda()

        Dim strDataInicial As Date = Me.DateNavigator1.SelectionStart
        Dim strDataFinal As Date = Me.DateNavigator1.SelectionEnd
        Dim i As Integer
        For i = 0 To My.Application.OpenForms.Count - 1
            Dim strForm As String = My.Application.OpenForms.Item(i).Name

            If strForm = "AppointmentForm" Or strForm = "RemindersForm" Then
                If My.Application.OpenForms.Item(i).Visible = False Then
                    Exit For
                End If
                Exit Sub
            End If
        Next

        If Me.btnReceber.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.btnPagar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then
            CarregarDadosAgenda("Declare @Result Varchar(Max) Set @Result = '' Select @Result = @Result + Nome + ', ' " & _
          "From Cliente Where (DAY(Nascimento) >= DAY('" & strDataInicial & "')) AND (DAY(Nascimento) <= DAY('" & strDataFinal & "')) " & _
          "AND (MONTH(Nascimento) >= MONTH('" & strDataInicial & "')) AND (MONTH(Nascimento) <= MONTH('" & strDataFinal & "')) " & _
          "If @Result <> '' Begin Set @Result = SUBSTRING(@Result, 1, len(@Result)-1) End " & _
          "SELECT CodOrdem, Type, StartDate, EndDate, AllDay, Subject, Location, Description, Status, Label, ResourceID, " & _
          "ResourceIDs, ReminderInfo, RecurrenceInfo, CustomField1, Conta FROM Agenda where CodConfig = " & CodConfig & " " & _
          "UNION ALL SELECT 0 AS CodOrdem, " & _
          "0 AS Type, CONVERT(varchar(2), DAY(Nascimento)) + '/' + CONVERT(varchar(2), MONTH(Nascimento)) + '/' + CONVERT(varchar(4), " & _
          "YEAR('" & strDataInicial & "')) + ' 00:00' AS StartDate, CONVERT(varchar(2), DAY(Nascimento)) + '/' + CONVERT(varchar(2), " & _
          "MONTH(Nascimento)) + '/' + CONVERT(varchar(4), YEAR('" & strDataInicial & "')) + ' 01:00' AS EndDate, " & _
          "'False' AS AllDay, 'ANIVERSARIANTES' AS Subject, 'Nº de Aniversariantes: ' + CONVERT(Varchar(10), COUNT(Codigo)) AS Location, " & _
          "(Select @Result as Pessoa) AS Description, 2 AS Status, 9 AS Label, NULL AS ResourceID, '' AS ResourceIDs, " & _
          "'' AS ReminderInfo, '' AS RecurrenceInfo, '' AS CustomField1, 'True' AS Conta FROM Cliente WHERE " & _
          "(DAY(Nascimento) >= DAY('" & strDataInicial & "')) AND (DAY(Nascimento) <= DAY('" & strDataFinal & "')) " & _
          "AND (MONTH(Nascimento) >= MONTH('" & strDataInicial & "')) AND (MONTH(Nascimento) <= MONTH('" & strDataFinal & "')) " & _
          "GROUP BY MONTH(Nascimento), DAY(Nascimento) HAVING(COUNT(Codigo) > 0)", Me.SchedulerStorage1)
        ElseIf Me.btnReceber.Visibility = DevExpress.XtraBars.BarItemVisibility.Never And Me.btnPagar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
            CarregarDadosAgenda("Declare @Result Varchar(Max) Set @Result = '' Select @Result = @Result + Nome + ', ' " & _
            "From Cliente Where (DAY(Nascimento) >= DAY('" & strDataInicial & "')) AND (DAY(Nascimento) <= DAY('" & strDataFinal & "')) " & _
            "AND (MONTH(Nascimento) >= MONTH('" & strDataInicial & "')) AND (MONTH(Nascimento) <= MONTH('" & strDataFinal & "')) " & _
            "If @Result <> '' Begin Set @Result = SUBSTRING(@Result, 1, len(@Result)-1) End " & _
            "SELECT CodOrdem, Type, StartDate, EndDate, AllDay, Subject, Location, Description, Status, Label, ResourceID, " & _
            "ResourceIDs, ReminderInfo, RecurrenceInfo, CustomField1, Conta FROM Agenda where CodConfig = " & CodConfig & " " & _
            "UNION ALL SELECT 0 AS CodOrdem, 0 AS Type, " & _
            "Vencimento + '00:00' AS StartDate, Vencimento + '01:00' AS EndDate, 'False' AS AllDay, 'CONTAS A PAGAR' AS Subject, " & _
            "'' AS Location, 'Nº de Contas: ' + CONVERT(Varchar(10), COUNT(Codigo)) + ' - Total a Pagar: ' + CONVERT(Varchar(15), " & _
            "REPLACE(CONVERT(Numeric(15, 2), SUM(ValorParcela)), '.', ',')) AS Description, 2 AS Status, 1 AS Label, " & _
            "NULL AS ResourceID, '' AS ResourceIDs, '' AS ReminderInfo, '' AS RecurrenceInfo, '' AS CustomField1, " & _
            "'True' AS Conta FROM ContaPagar WHERE (Vencimento >= '" & strDataInicial & "') AND (Vencimento <= '" & strDataFinal & "') " & _
            "AND PagoOk = 'False' AND CodConfig = " & CodConfig & " GROUP BY Vencimento UNION ALL SELECT 0 AS CodOrdem, " & _
            "0 AS Type, CONVERT(varchar(2), DAY(Nascimento)) + '/' + CONVERT(varchar(2), MONTH(Nascimento)) + '/' + CONVERT(varchar(4), " & _
            "YEAR('" & strDataInicial & "')) + ' 00:00' AS StartDate, CONVERT(varchar(2), DAY(Nascimento)) + '/' + CONVERT(varchar(2), " & _
            "MONTH(Nascimento)) + '/' + CONVERT(varchar(4), YEAR('" & strDataInicial & "')) + ' 01:00' AS EndDate, " & _
            "'False' AS AllDay, 'ANIVERSARIANTES' AS Subject, 'Nº de Aniversariantes: ' + CONVERT(Varchar(10), COUNT(Codigo)) AS Location, " & _
            "(Select @Result as Pessoa) AS Description, 2 AS Status, 9 AS Label, NULL AS ResourceID, '' AS ResourceIDs, " & _
            "'' AS ReminderInfo, '' AS RecurrenceInfo, '' AS CustomField1, 'True' AS Conta FROM Cliente WHERE " & _
            "(DAY(Nascimento) >= DAY('" & strDataInicial & "')) AND (DAY(Nascimento) <= DAY('" & strDataFinal & "')) " & _
            "AND (MONTH(Nascimento) >= MONTH('" & strDataInicial & "')) AND (MONTH(Nascimento) <= MONTH('" & strDataFinal & "')) " & _
            "GROUP BY MONTH(Nascimento), DAY(Nascimento) HAVING(COUNT(Codigo) > 0)", Me.SchedulerStorage1)
        ElseIf Me.btnReceber.Visibility = DevExpress.XtraBars.BarItemVisibility.Always And Me.btnPagar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then
            CarregarDadosAgenda("Declare @Result Varchar(Max) Set @Result = '' Select @Result = @Result + Nome + ', ' " & _
                  "From Cliente Where (DAY(Nascimento) >= DAY('" & strDataInicial & "')) AND (DAY(Nascimento) <= DAY('" & strDataFinal & "')) " & _
                  "AND (MONTH(Nascimento) >= MONTH('" & strDataInicial & "')) AND (MONTH(Nascimento) <= MONTH('" & strDataFinal & "')) " & _
                  "If @Result <> '' Begin Set @Result = SUBSTRING(@Result, 1, len(@Result)-1) End " & _
                  "SELECT CodOrdem, Type, StartDate, EndDate, AllDay, Subject, Location, Description, Status, Label, ResourceID, " & _
                  "ResourceIDs, ReminderInfo, RecurrenceInfo, CustomField1, Conta FROM Agenda where CodConfig = " & CodConfig & " " & _
                  "UNION ALL SELECT 0 AS CodOrdem, 0 AS Type, Vencimento + '00:00' AS StartDate, Vencimento + '01:00' AS EndDate, " & _
                  "'False' AS AllDay, 'CONTAS A RECEBER' AS Subject, '' AS Location, 'Nº de Contas: ' + CONVERT(Varchar(10), " & _
                  "COUNT(Codigo)) + ' - Total a Receber: ' + CONVERT(Varchar(15), REPLACE(CONVERT(Numeric(15, 2), " & _
                  "SUM(ValorParcela)), '.',',')) AS Description, 2 AS Status, 5 AS Label, NULL AS ResourceID, '' AS ResourceIDs, " & _
                  "'' AS ReminderInfo, '' AS RecurrenceInfo, '' AS CustomField1, 'True' AS Conta FROM ContaReceber " & _
                  "WHERE (Vencimento >= '" & strDataInicial & "') AND (Vencimento <= '" & strDataFinal & "') AND REcebidoOk = 'False' " & _
                  "AND CodConfig = " & CodConfig & " GROUP BY Vencimento UNION ALL SELECT 0 AS CodOrdem, " & _
                  "0 AS Type, CONVERT(varchar(2), DAY(Nascimento)) + '/' + CONVERT(varchar(2), MONTH(Nascimento)) + '/' + CONVERT(varchar(4), " & _
                  "YEAR('" & strDataInicial & "')) + ' 00:00' AS StartDate, CONVERT(varchar(2), DAY(Nascimento)) + '/' + CONVERT(varchar(2), " & _
                  "MONTH(Nascimento)) + '/' + CONVERT(varchar(4), YEAR('" & strDataInicial & "')) + ' 01:00' AS EndDate, " & _
                  "'False' AS AllDay, 'ANIVERSARIANTES' AS Subject, 'Nº de Aniversariantes: ' + CONVERT(Varchar(10), COUNT(Codigo)) AS Location, " & _
                  "(Select @Result as Pessoa) AS Description, 2 AS Status, 9 AS Label, NULL AS ResourceID, '' AS ResourceIDs, " & _
                  "'' AS ReminderInfo, '' AS RecurrenceInfo, '' AS CustomField1, 'True' AS Conta FROM Cliente WHERE " & _
                  "(DAY(Nascimento) >= DAY('" & strDataInicial & "')) AND (DAY(Nascimento) <= DAY('" & strDataFinal & "')) " & _
                  "AND (MONTH(Nascimento) >= MONTH('" & strDataInicial & "')) AND (MONTH(Nascimento) <= MONTH('" & strDataFinal & "')) " & _
                  "GROUP BY MONTH(Nascimento), DAY(Nascimento) HAVING(COUNT(Codigo) > 0)", Me.SchedulerStorage1)
        Else

            If TipoNano = 3 Then
                CarregarDadosAgenda("Declare @Result Varchar(Max) Set @Result = '' Select @Result = @Result + Nome + ', ' " & _
                            "From Cliente Where (DAY(Nascimento) >= DAY('" & strDataInicial & "')) AND (DAY(Nascimento) <= DAY('" & strDataFinal & "')) " & _
                            "AND (MONTH(Nascimento) >= MONTH('" & strDataInicial & "')) AND (MONTH(Nascimento) <= MONTH('" & strDataFinal & "')) " & _
                            "If @Result <> '' Begin Set @Result = SUBSTRING(@Result, 1, len(@Result)-1) End " & _
                            "SELECT CodOrdem, Type, StartDate, EndDate, AllDay, Subject, Location, Description, Status, Label, ResourceID, " & _
                            "ResourceIDs, ReminderInfo, RecurrenceInfo, CustomField1, Conta FROM Agenda where CodConfig = " & CodConfig & " " & _
                            "UNION ALL SELECT 0 AS CodOrdem, 0 AS Type, Vencimento + '00:00' AS StartDate, Vencimento + '01:00' AS EndDate, " & _
                            "'False' AS AllDay, 'CONTAS A RECEBER' AS Subject, '' AS Location, 'Nº de Contas: ' + CONVERT(Varchar(10), " & _
                            "COUNT(Codigo)) + ' - Total a Receber: ' + CONVERT(Varchar(15), REPLACE(CONVERT(Numeric(15, 2), " & _
                            "SUM(ValorParcela)), '.',',')) AS Description, 2 AS Status, 5 AS Label, NULL AS ResourceID, '' AS ResourceIDs, " & _
                            "'' AS ReminderInfo, '' AS RecurrenceInfo, '' AS CustomField1, 'True' AS Conta FROM ContaReceber " & _
                            "WHERE (Vencimento >= '" & strDataInicial & "') AND (Vencimento <= '" & strDataFinal & "') AND REcebidoOk = 'False' " & _
                            "AND CodConfig = " & CodConfig & " GROUP BY Vencimento UNION ALL SELECT 0 AS CodOrdem, 0 AS Type, " & _
                            "Vencimento + '00:00' AS StartDate, Vencimento + '01:00' AS EndDate, 'False' AS AllDay, 'CONTAS A PAGAR' AS Subject, " & _
                            "'' AS Location, 'Nº de Contas: ' + CONVERT(Varchar(10), COUNT(Codigo)) + ' - Total a Pagar: ' + CONVERT(Varchar(15), " & _
                            "REPLACE(CONVERT(Numeric(15, 2), SUM(ValorParcela)), '.', ',')) AS Description, 2 AS Status, 1 AS Label, " & _
                            "NULL AS ResourceID, '' AS ResourceIDs, '' AS ReminderInfo, '' AS RecurrenceInfo, '' AS CustomField1, " & _
                            "'True' AS Conta FROM ContaPagar WHERE (Vencimento >= '" & strDataInicial & "') AND (Vencimento <= '" & strDataFinal & "') " & _
                            "AND PagoOk = 'False' AND CodConfig = " & CodConfig & " GROUP BY Vencimento UNION ALL SELECT 0 AS CodOrdem, " & _
                            "0 AS Type, CONVERT(varchar(2), DAY(Nascimento)) + '/' + CONVERT(varchar(2), MONTH(Nascimento)) + '/' + CONVERT(varchar(4), " & _
                            "YEAR('" & strDataInicial & "')) + ' 00:00' AS StartDate, CONVERT(varchar(2), DAY(Nascimento)) + '/' + CONVERT(varchar(2), " & _
                            "MONTH(Nascimento)) + '/' + CONVERT(varchar(4), YEAR('" & strDataInicial & "')) + ' 01:00' AS EndDate, " & _
                            "'False' AS AllDay, 'ANIVERSARIANTES' AS Subject, 'Nº de Aniversariantes: ' + CONVERT(Varchar(10), COUNT(Codigo)) AS Location, " & _
                            "(Select @Result as Pessoa) AS Description, 2 AS Status, 9 AS Label, NULL AS ResourceID, '' AS ResourceIDs, " & _
                            "'' AS ReminderInfo, '' AS RecurrenceInfo, '' AS CustomField1, 'True' AS Conta FROM Cliente WHERE " & _
                            "(DAY(Nascimento) >= DAY('" & strDataInicial & "')) AND (DAY(Nascimento) <= DAY('" & strDataFinal & "')) " & _
                            "AND (MONTH(Nascimento) >= MONTH('" & strDataInicial & "')) AND (MONTH(Nascimento) <= MONTH('" & strDataFinal & "')) " & _
                            "GROUP BY MONTH(Nascimento), DAY(Nascimento) HAVING(COUNT(Codigo) > 0) " & _
                            "UNION ALL SELECT 0 AS CodOrdem, 0 AS Type, case when Retorno <>'' then " & _
                            "DATEADD(day,convert(integer,Retorno),TotalConsig.Data) else '01/01/1900' end + '00:00' AS StartDate, case when Retorno <>'' then " & _
                            "DATEADD(day,convert(integer,Retorno),TotalConsig.Data) else '01/01/1900' end + '01:00' AS EndDate, " & _
                            "'False' AS AllDay, 'RETORNO' AS Subject, '' AS Location, " & _
                            "'Nº Pedido: ' + convert(varchar(10),TotalConsig.CodOrdens) + ' - Cliente: ' +  Cliente.Nome + ' Animal: ' + Animal.Nome AS Description, " & _
                            "2 AS Status, 5 AS Label, NULL AS ResourceID, '' AS ResourceIDs, " & _
                            "'' AS ReminderInfo, '' AS RecurrenceInfo, '' AS CustomField1, 'True' AS Conta FROM ((ItensConsig left join TotalConsig on ItensConsig.CodOrdens = TotalConsig.CodOrdens and " & _
                            "ItensConsig.CodConfig = TotalConsig.CodConfig) left join Cliente on TotalConsig.CodCli = Cliente.Codigo) " & _
                            "left join Animal on TotalConsig.CodAnimal = Animal.Codigo where " & _
                            "DATEADD(day,convert(integer,Retorno),TotalConsig.Data) >= '" & strDataFinal & "' and Retorno <>''", Me.SchedulerStorage1)
            Else
                CarregarDadosAgenda("Declare @Result Varchar(Max) Set @Result = '' Select @Result = @Result + Nome + ', ' " & _
            "From Cliente Where (DAY(Nascimento) >= DAY('" & strDataInicial & "')) AND (DAY(Nascimento) <= DAY('" & strDataFinal & "')) " & _
            "AND (MONTH(Nascimento) >= MONTH('" & strDataInicial & "')) AND (MONTH(Nascimento) <= MONTH('" & strDataFinal & "')) " & _
            "If @Result <> '' Begin Set @Result = SUBSTRING(@Result, 1, len(@Result)-1) End " & _
            "SELECT CodOrdem, Type, StartDate, EndDate, AllDay, Subject, Location, Description, Status, Label, ResourceID, " & _
            "ResourceIDs, ReminderInfo, RecurrenceInfo, CustomField1, Conta FROM Agenda where CodConfig = " & CodConfig & " " & _
            "UNION ALL SELECT 0 AS CodOrdem, 0 AS Type, Vencimento + '00:00' AS StartDate, Vencimento + '01:00' AS EndDate, " & _
            "'False' AS AllDay, 'CONTAS A RECEBER' AS Subject, '' AS Location, 'Nº de Contas: ' + CONVERT(Varchar(10), " & _
            "COUNT(Codigo)) + ' - Total a Receber: ' + CONVERT(Varchar(15), REPLACE(CONVERT(Numeric(15, 2), " & _
            "SUM(ValorParcela)), '.',',')) AS Description, 2 AS Status, 5 AS Label, NULL AS ResourceID, '' AS ResourceIDs, " & _
            "'' AS ReminderInfo, '' AS RecurrenceInfo, '' AS CustomField1, 'True' AS Conta FROM ContaReceber " & _
            "WHERE (Vencimento >= '" & strDataInicial & "') AND (Vencimento <= '" & strDataFinal & "') AND REcebidoOk = 'False' " & _
            "AND CodConfig = " & CodConfig & " GROUP BY Vencimento UNION ALL SELECT 0 AS CodOrdem, 0 AS Type, " & _
            "Vencimento + '00:00' AS StartDate, Vencimento + '01:00' AS EndDate, 'False' AS AllDay, 'CONTAS A PAGAR' AS Subject, " & _
            "'' AS Location, 'Nº de Contas: ' + CONVERT(Varchar(10), COUNT(Codigo)) + ' - Total a Pagar: ' + CONVERT(Varchar(15), " & _
            "REPLACE(CONVERT(Numeric(15, 2), SUM(ValorParcela)), '.', ',')) AS Description, 2 AS Status, 1 AS Label, " & _
            "NULL AS ResourceID, '' AS ResourceIDs, '' AS ReminderInfo, '' AS RecurrenceInfo, '' AS CustomField1, " & _
            "'True' AS Conta FROM ContaPagar WHERE (Vencimento >= '" & strDataInicial & "') AND (Vencimento <= '" & strDataFinal & "') " & _
            "AND PagoOk = 'False' AND CodConfig = " & CodConfig & " GROUP BY Vencimento UNION ALL SELECT 0 AS CodOrdem, " & _
            "0 AS Type, CONVERT(varchar(2), DAY(Nascimento)) + '/' + CONVERT(varchar(2), MONTH(Nascimento)) + '/' + CONVERT(varchar(4), " & _
            "YEAR('" & strDataInicial & "')) + ' 00:00' AS StartDate, CONVERT(varchar(2), DAY(Nascimento)) + '/' + CONVERT(varchar(2), " & _
            "MONTH(Nascimento)) + '/' + CONVERT(varchar(4), YEAR('" & strDataInicial & "')) + ' 01:00' AS EndDate, " & _
            "'False' AS AllDay, 'ANIVERSARIANTES' AS Subject, 'Nº de Aniversariantes: ' + CONVERT(Varchar(10), COUNT(Codigo)) AS Location, " & _
            "(Select @Result as Pessoa) AS Description, 2 AS Status, 9 AS Label, NULL AS ResourceID, '' AS ResourceIDs, " & _
            "'' AS ReminderInfo, '' AS RecurrenceInfo, '' AS CustomField1, 'True' AS Conta FROM Cliente WHERE " & _
            "(DAY(Nascimento) >= DAY('" & strDataInicial & "')) AND (DAY(Nascimento) <= DAY('" & strDataFinal & "')) " & _
            "AND (MONTH(Nascimento) >= MONTH('" & strDataInicial & "')) AND (MONTH(Nascimento) <= MONTH('" & strDataFinal & "')) " & _
            "GROUP BY MONTH(Nascimento), DAY(Nascimento) HAVING(COUNT(Codigo) > 0)", Me.SchedulerStorage1)
            End If
            




        End If




 

    End Sub
    Private Sub GerarGraficoSemanal(ByVal parGrafico As Object)

        Dim dtData As Date = Date.Today
        Dim culture As New CultureInfo("pt-BR")
        Dim dtfi As DateTimeFormatInfo = culture.DateTimeFormat
        Dim diasemana As String = culture.TextInfo.ToTitleCase(dtfi.GetDayName(dtData.DayOfWeek))

        Dim dtIni As Date
        Dim dtFin As Date
        Select Case diasemana
            Case "Domingo"
                dtIni = dtData
                dtFin = dtData.AddDays(7)
            Case "Segunda-Feira"
                dtIni = dtData.AddDays(-1)
                dtFin = dtData.AddDays(6)
            Case "Terça-Feira"
                dtIni = dtData.AddDays(-2)
                dtFin = dtData.AddDays(5)
            Case "Quarta-Feira"
                dtIni = dtData.AddDays(-3)
                dtFin = dtData.AddDays(4)
            Case "Quinta-Feira"
                dtIni = dtData.AddDays(-4)
                dtFin = dtData.AddDays(3)
            Case "Sexta-Feira"
                dtIni = dtData.AddDays(-5)
                dtFin = dtData.AddDays(2)
            Case "Sábado"
                dtIni = dtData.AddDays(-6)
                dtFin = dtData.AddDays(1)
        End Select

        parGrafico.Series.Clear()

        Dim strData As String = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", dtIni, dtFin)

        Dim strColuna As String = ""
        Dim strSetor As String = ""
        Dim strValor As String = ""
        Dim dt1 As DataTable = Nothing

        strColuna = "sum(Pedido.ValorTotal)"

        Dim strTipo As String = Me.rdgGrafico.SelectedIndex

        Dim strTipo2 As String = "0"

        dt1 = CarregarDataTableGrafico("SELECT Day(Data), " & strColuna & ", Data FROM Total left join Pedido on " & _
        "Total.CodOrdem = Pedido.CodOrdem and Total.CodConfig = Pedido.CodConfig where Pedido.CodConfig = " & CodConfig & " and " & _
        "Devolvido = 'False' and Pedido.TipoItens <> 'CONSUMO' and " & strData & " group by Day(Data), Data order by Day(Data)")

        Dim I As Integer
        Dim A As Integer = 0
        Dim strDiaAnterior As String = "Domingo"
        intNumSerie1 = dt1.Rows.Count
        If dt1.Rows.Count = 0 Then Exit Sub

        For I = 0 To 7 - 1
            Dim dtDataVenda As Date = Nothing
            Dim strSemana As String = ""
            If A < dt1.Rows.Count Then
                dtDataVenda = dt1.Rows.Item(A).ItemArray(2)
                strSemana = culture.TextInfo.ToTitleCase(dtfi.GetDayName(dtDataVenda.DayOfWeek))
            End If

            strValor = "0"

            Select Case I
                Case 0
                    strDiaAnterior = "Domingo"
                Case 1
                    strDiaAnterior = "Segunda-Feira"
                Case 2
                    strDiaAnterior = "Terça-Feira"
                Case 3
                    strDiaAnterior = "Quarta-Feira"
                Case 4
                    strDiaAnterior = "Quinta-Feira"
                Case 5
                    strDiaAnterior = "Sexta-Feira"
                Case 6
                    strDiaAnterior = "Sábado"

            End Select

            If A < dt1.Rows.Count Then
                If strDiaAnterior = strSemana Then
                    strValor = dt1.Rows.Item(A).ItemArray(1).ToString
                    A += 1
                End If
            End If


            strDiaAnterior = strDiaAnterior.Substring(0, 3)


            Select Case strTipo
                Case "0"
                    parGrafico.Series.Add(New Series("Series", ViewType.Bar))
                    parGrafico.Series(I).Name = strDiaAnterior

                    parGrafico.Legend.Visible = True
                    parGrafico.Legend.MarkerSize = New Size(10, 10)
                    parGrafico.Legend.Font = New Font("Tahoma", 7, FontStyle.Regular)

                    If strTipo2 = "0" Then
                        parGrafico.Series(I).PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
                        parGrafico.Series(I).Points.Add(New SeriesPoint(strDiaAnterior, New Double() {strValor}))

                    Else
                        parGrafico.Series(I).PointOptions.ValueNumericOptions.Format = NumericFormat.Number
                        parGrafico.Series(I).Points.Add(New SeriesPoint(strDiaAnterior, New Double() {strValor}))
                    End If
                    'parGrafico.Legend.Visible = False

                    'parGrafico.Series(I).Label.OverlappingOption = True
                    'parGrafico.Series(I).Label.OverlappingOptions.Indent = 1

                    CType(parGrafico.Diagram, XYDiagram).DefaultPane.BackColor = Color.White
                Case 2
                    parGrafico.Series.Add(New Series("Series", ViewType.Pie))
                    parGrafico.Series(0).LegendPointOptions.PointView = PointView.Argument

                    CType(parGrafico.Series(0).PointOptions, PiePointOptions).PercentOptions.ValueAsPercent = False
                    If strTipo2 = "0" Then
                        parGrafico.Series(0).PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
                        parGrafico.Series(0).Points.Add(New SeriesPoint(strDiaAnterior, New Double() {strValor}))
                    Else
                        parGrafico.Series(0).PointOptions.ValueNumericOptions.Format = NumericFormat.Number
                        parGrafico.Series(0).Points.Add(New SeriesPoint(strDiaAnterior, New Double() {strValor}))
                    End If

                    parGrafico.Legend.Visible = True

                Case 1
                    parGrafico.Series.Add(New Series("Series", ViewType.Line))
                    parGrafico.Series(I).Name = strDiaAnterior

                    parGrafico.Legend.Visible = True
                    parGrafico.Legend.MarkerSize = New Size(10, 10)
                    parGrafico.Legend.Font = New Font("Tahoma", 7, FontStyle.Regular)

                    If strTipo2 = "0" Then
                        parGrafico.Series(I).PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
                        parGrafico.Series(I).Points.Add(New SeriesPoint(strDiaAnterior, New Double() {strValor}))

                    Else
                        parGrafico.Series(I).PointOptions.ValueNumericOptions.Format = NumericFormat.Number
                        parGrafico.Series(I).Points.Add(New SeriesPoint(strDiaAnterior, New Double() {strValor}))

                    End If
                    'parGrafico.Legend.Visible = False

                    CType(parGrafico.Diagram, XYDiagram).DefaultPane.BackColor = Color.White
            End Select

        Next

        'parGrafico.PaletteName = "Flow"
        parGrafico.PaletteName = "Padrao"
    End Sub
    Private Sub GerarGraficoDecimal(ByVal parGrafico As Object)

        Dim dtData As Date = Date.Today

        Dim dtUltimoDia As Date = UltimoDiaMes("01/" & Month(dtData) & "/" & Year(dtData))
        Dim strUltimoDia As String = dtUltimoDia.Day
        Dim dtIni As Date = "01/" & Month(dtData) & "/" & Year(dtData)
        Dim dtFin As Date = strUltimoDia & "/" & Month(dtData) & "/" & Year(dtData)

        parGrafico.Series.Clear()

        Dim strData As String = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", dtIni, dtFin)

        Dim strColuna As String = ""
        Dim strSetor As String = ""
        Dim strValor As String = ""
        Dim dt1 As DataTable = Nothing

        strColuna = "sum(Pedido.ValorTotal)"

        Dim strTipo As String = Me.rdgGrafico.SelectedIndex
        Dim strTipo2 As String = "0"

        dt1 = CarregarDataTableGrafico("SELECT Day(Data), " & strColuna & ", Data FROM Total left join Pedido on " & _
        "Total.CodOrdem = Pedido.CodOrdem and Total.CodConfig = Pedido.CodConfig where Pedido.CodConfig = " & CodConfig & " and " & _
        "Devolvido = 'False' and Pedido.TipoItens <> 'CONSUMO' and " & strData & " group by Day(Data), Data order by Day(Data)")
        intNumSerie1 = dt1.Rows.Count
        Dim vetDecimal(2) As String
        Dim I As Integer
        Dim dblValor As Double
        For I = 0 To dt1.Rows.Count - 1
            Dim intDia As Integer = dt1.Rows.Item(I).ItemArray(0)

            If intDia <= 10 Then
                If dt1.Rows.Item(I).ItemArray(1).ToString <> "" Then
                    dblValor = dt1.Rows.Item(I).ItemArray(1).ToString
                    vetDecimal(0) = vetDecimal(0) + dblValor
                End If

            ElseIf intDia > 10 And intDia <= 20 Then
                If dt1.Rows.Item(I).ItemArray(1).ToString <> "" Then
                    dblValor = dt1.Rows.Item(I).ItemArray(1).ToString
                    vetDecimal(1) = vetDecimal(1) + dblValor
                End If
            Else
                If dt1.Rows.Item(I).ItemArray(1).ToString <> "" Then
                    dblValor = dt1.Rows.Item(I).ItemArray(1).ToString
                    vetDecimal(2) = vetDecimal(2) + dblValor
                End If
            End If
        Next

        If vetDecimal(0) Is Nothing And vetDecimal(1) Is Nothing And vetDecimal(2) Is Nothing Then
            Exit Sub
        End If


        Dim A As Integer = 0
        Dim strDias As String = ""
        For I = 0 To 2

            Select Case I
                Case 0
                    strDias = "01-10"
                Case 1
                    strDias = "11-20"
                Case 2
                    strDias = "21-" & strUltimoDia
            End Select


            Select Case strTipo
                Case "0"
                    parGrafico.Series.Add(New Series("Series", ViewType.Bar))
                    parGrafico.Series(I).Name = strDias
                    parGrafico.Legend.Visible = True
                    parGrafico.Legend.MarkerSize = New Size(10, 10)
                    parGrafico.Legend.Font = New Font("Tahoma", 7, FontStyle.Regular)
                    If strTipo2 = "0" Then
                        parGrafico.Series(I).PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
                        parGrafico.Series(I).Points.Add(New SeriesPoint(strDias, New Double() {vetDecimal(I)}))

                    Else
                        parGrafico.Series(I).PointOptions.ValueNumericOptions.Format = NumericFormat.Number
                        parGrafico.Series(I).Points.Add(New SeriesPoint(strDias, New Double() {vetDecimal(I)}))
                    End If
                    'parGrafico.Legend.Visible = False
                    parGrafico.Series(I).Label.OverlappingOptions.ResolveOverlapping = True
                    parGrafico.Series(I).Label.OverlappingOptions.Indent = 1
                    CType(parGrafico.Diagram, XYDiagram).DefaultPane.BackColor = Color.White
                Case 2
                    parGrafico.Series.Add(New Series("Series", ViewType.Pie))
                    parGrafico.Series(0).LegendPointOptions.PointView = PointView.Argument
                    CType(parGrafico.Series(0).PointOptions, PiePointOptions).PercentOptions.ValueAsPercent = False
                    If strTipo2 = "0" Then
                        parGrafico.Series(0).PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
                        parGrafico.Series(0).Points.Add(New SeriesPoint(strDias, New Double() {vetDecimal(I)}))
                    Else
                        parGrafico.Series(0).PointOptions.ValueNumericOptions.Format = NumericFormat.Number
                        parGrafico.Series(0).Points.Add(New SeriesPoint(strDias, New Double() {vetDecimal(I)}))
                    End If

                    parGrafico.Legend.Visible = True

                Case 1
                    parGrafico.Series.Add(New Series("Series", ViewType.Line))
                    parGrafico.Series(I).Name = strDias
                    parGrafico.Legend.Visible = True
                    parGrafico.Legend.MarkerSize = New Size(10, 10)
                    parGrafico.Legend.Font = New Font("Tahoma", 7, FontStyle.Regular)
                    If strTipo2 = "0" Then
                        parGrafico.Series(I).PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
                        parGrafico.Series(I).Points.Add(New SeriesPoint(strDias, New Double() {vetDecimal(I)}))

                    Else
                        parGrafico.Series(I).PointOptions.ValueNumericOptions.Format = NumericFormat.Number
                        parGrafico.Series(I).Points.Add(New SeriesPoint(strDias, New Double() {vetDecimal(I)}))

                    End If
                    ' parGrafico.Legend.Visible = False

                    CType(parGrafico.Diagram, XYDiagram).DefaultPane.BackColor = Color.White
            End Select

        Next

        parGrafico.PaletteName = "Padrao"

    End Sub
    Private Sub GerarGrafico2(ByVal parGrafico As Object)

        Dim dtData As Date = Date.Today


        Dim dtIni As Date = dtData
        Dim dtFin As Date = dtData

        Dim strMeta As String = ""

        Select Case Me.rdgTipoGrafico2.SelectedIndex
            Case 0
                strMeta = ", case when Meta > 0 then Meta / 30 else 0 end as Meta"
            Case 1
                Dim culture As New CultureInfo("pt-BR")
                Dim dtfi As DateTimeFormatInfo = culture.DateTimeFormat
                Dim diasemana As String = culture.TextInfo.ToTitleCase(dtfi.GetDayName(dtData.DayOfWeek))
                Select Case diasemana
                    Case "Domingo"
                        dtIni = dtData
                        dtFin = dtData.AddDays(7)
                    Case "Segunda-Feira"
                        dtIni = dtData.AddDays(-1)
                        dtFin = dtData.AddDays(6)
                    Case "Terça-Feira"
                        dtIni = dtData.AddDays(-2)
                        dtFin = dtData.AddDays(5)
                    Case "Quarta-Feira"
                        dtIni = dtData.AddDays(-3)
                        dtFin = dtData.AddDays(4)
                    Case "Quinta-Feira"
                        dtIni = dtData.AddDays(-4)
                        dtFin = dtData.AddDays(3)
                    Case "Sexta-Feira"
                        dtIni = dtData.AddDays(-5)
                        dtFin = dtData.AddDays(2)
                    Case "Sábado"
                        dtIni = dtData.AddDays(-6)
                        dtFin = dtData.AddDays(1)
                End Select

                strMeta = ", case when Meta > 0 then Meta / 4 else 0 end as Meta"
            Case 2
                dtIni = "01/" & Month(dtIni) & "/" & Year(dtIni)
                Dim strMesFinal As String = Format(CInt(dtIni.Month), "00")
                Dim strAnoFinal As String = dtIni.Year
                Dim strUltimoDia As String = DateAdd("m", 1, DateSerial(strAnoFinal, strMesFinal, 1))
                strUltimoDia = DateAdd("d", -1, strUltimoDia)
                dtFin = strUltimoDia

                strMeta = ", case when Meta > 0 then Meta else 0 end as Meta"
        End Select
   



        parGrafico.Series.Clear()

        Dim strData As String = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", dtIni, dtFin)

        Dim strColuna As String = ""
        Dim strSetor As String = ""
        Dim strValor As String = ""
        Dim dt1 As DataTable = Nothing

        strColuna = "sum(Pedido.ValorTotal)"

        Dim strTipo As String = Me.rdgGrafico2.SelectedIndex
        Dim strTipo2 As String = "0"
        dt1 = CarregarDataTableGrafico("SELECT Pedido.CodFunc, " & strColuna & strMeta & " FROM (Total left join Pedido on " & _
        "Total.CodOrdem = Pedido.CodOrdem and Total.CodConfig = Pedido.CodConfig) left join Funcionario on Pedido.CodFunc = " & _
        "Funcionario.Codigo where Pedido.CodConfig = " & CodConfig & " and Devolvido = 'False' " & _
        "and Pedido.TipoItens <> 'CONSUMO' and " & strData & " group by  Pedido.CodFunc, Meta order by " & strColuna & " DESC")

        Dim I As Integer
        intNumSerie2 = dt1.Rows.Count
        If dt1.Rows.Count > 0 Then
            Select Case strTipo
                Case "0"
                    parGrafico.Series.Add(New Series("Series", ViewType.Bar))
                    parGrafico.Series(0).Name = "Venda"
                    parGrafico.Series(0).PointOptions.ValueNumericOptions.Format = NumericFormat.Currency

                    parGrafico.Series.Add(New Series("Series", ViewType.Bar))
                    parGrafico.Series(1).Name = "Meta"
                    parGrafico.Series(1).PointOptions.ValueNumericOptions.Format = NumericFormat.Currency

                    parGrafico.Legend.Visible = True
                    parGrafico.Legend.MarkerSize = New Size(10, 10)
                    parGrafico.Legend.Font = New Font("Tahoma", 7, FontStyle.Regular)

                Case "1"
                    parGrafico.Series.Add(New Series("Series", ViewType.Line))
                    parGrafico.Series(0).Name = "Venda"
                    parGrafico.Series(0).PointOptions.ValueNumericOptions.Format = NumericFormat.Currency

                    parGrafico.Series.Add(New Series("Series", ViewType.Line))
                    parGrafico.Series(1).Name = "Meta"
                    parGrafico.Series(1).PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
                    parGrafico.Legend.Visible = True
                    parGrafico.Legend.MarkerSize = New Size(10, 10)
                    parGrafico.Legend.Font = New Font("Tahoma", 7, FontStyle.Regular)

            End Select
        End If
  
       


        For I = 0 To dt1.Rows.Count - 1

            Dim strFunc As String = dt1.Rows.Item(I).ItemArray(0).ToString
            If strFunc = "" Then
                strFunc = "Sem Func."
            End If
            strValor = dt1.Rows.Item(I).ItemArray(1)
            Dim dblMeta As Double = dt1.Rows.Item(I).ItemArray(2)


            Select Case strTipo
                Case "0"
                    'parGrafico.Series.Add(New Series("Series", ViewType.Bar))
                    'parGrafico.Series(I).Name = strFunc
                    If strTipo2 = "0" Then
                        'parGrafico.Series(I).PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
                        parGrafico.Series(0).Points.Add(New SeriesPoint(strFunc, New Double() {strValor}))
                        'parGrafico.Series(0).Label.OverlappingOptions.ResolveOverlapping = True
                        'parGrafico.Series(0).Label.OverlappingOptions.Indent = 1
                        If dblMeta > 0 Then
                            parGrafico.Series(1).Points.Add(New SeriesPoint(strFunc, New Double() {dblMeta}))
                            ' parGrafico.Series(1).Label.OverlappingOptions.ResolveOverlapping = True
                            'parGrafico.Series(1).Label.OverlappingOptions.Indent = 1
                        End If
                    Else
                        parGrafico.Series(I).PointOptions.ValueNumericOptions.Format = NumericFormat.Number
                        parGrafico.Series(I).Points.Add(New SeriesPoint(strFunc, New Double() {strValor}))
                    End If
                    'parGrafico.Legend.Visible = False
                    CType(parGrafico.Diagram, XYDiagram).DefaultPane.BackColor = Color.White
                Case 2
                    parGrafico.Series.Add(New Series("Series", ViewType.Pie))
                    parGrafico.Series(0).LegendPointOptions.PointView = PointView.Argument

                    CType(parGrafico.Series(0).PointOptions, PiePointOptions).PercentOptions.ValueAsPercent = False
                    If strTipo2 = "0" Then
                        parGrafico.Series(0).PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
                        parGrafico.Series(0).Points.Add(New SeriesPoint(strFunc, New Double() {strValor}))
                    Else
                        parGrafico.Series(0).PointOptions.ValueNumericOptions.Format = NumericFormat.Number
                        parGrafico.Series(0).Points.Add(New SeriesPoint(strFunc, New Double() {strValor}))
                    End If

                    parGrafico.Legend.Visible = True

                Case 1
            
                    If strTipo2 = "0" Then
                        parGrafico.Series(0).Points.Add(New SeriesPoint(strFunc, New Double() {strValor}))
                        parGrafico.Series(0).Label.OverlappingOptions.ResolveOverlapping = True
                        parGrafico.Series(0).Label.OverlappingOptions.Indent = 1
                        If dblMeta > 0 Then
                            parGrafico.Series(1).Points.Add(New SeriesPoint(strFunc, New Double() {dblMeta}))
                            parGrafico.Series(1).Label.OverlappingOptions.ResolveOverlapping = True
                            parGrafico.Series(1).Label.OverlappingOptions.Indent = 1
                        End If

                    Else
                        parGrafico.Series(I).PointOptions.ValueNumericOptions.Format = NumericFormat.Number
                        parGrafico.Series(I).Points.Add(New SeriesPoint(strFunc, New Double() {strValor}))

                    End If

                    'parGrafico.Legend.Visible = False

                    'parGrafico.Series(I).Label.OverlappingOptions.ResolveOverlapping = True
                    'parGrafico.Series(I).Label.OverlappingOptions.Indent = 1
                    CType(parGrafico.Diagram, XYDiagram).DefaultPane.BackColor = Color.White
            End Select




        Next

       

        parGrafico.PaletteName = "Padrao"

    End Sub
    'Public Sub New()
    '    SchedulerLocalizer.Active = New MyLocalizer()

    '    InitializeComponent()
    'End Sub
    'Public Class MyLocalizer
    '    Inherits SchedulerLocalizer
    '    Public Overrides Function GetLocalizedString(ByVal id As SchedulerStringId) As String
    '        Select Case id
    '            Case SchedulerStringId.Caption_PrevAppointment
    '                Return "Compromisso Anterior"

    '            Case SchedulerStringId.Caption_NextAppointment
    '                Return "Próximo Compromisso"

    '        End Select
    '        Return MyBase.GetLocalizedString(id)
    '    End Function
    'End Class
    Private Sub Analitico()
        If Me.NavBarControl3.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded Then
            AtualizarGridPedido()
        End If
        Agenda()
        If Nivel = "ADMINISTRADOR" Or Nivel = "MASTER" Then
            If Me.rdgTipoGrafico.SelectedIndex = 0 Then
                GerarGraficoSemanal(Me.Grafico)
            Else
                GerarGraficoDecimal(Me.Grafico)
            End If
            GerarGrafico2(Me.Grafico2)
            Resumo()
        End If
    
    End Sub

    Public Shared Sub Main()
        Application.Run(New MDI())
    End Sub
    Private Sub IniciaThread()
        If bolBloqueioAnalyzer = False Then

            CarregaRepresentante()
            Analitico()
            Application.DoEvents()
            System.Threading.Thread.Sleep(40)
        End If
      
    End Sub

    Private mThreadBaixarCrystal As Thread
    Public Sub IniciaThreadBaixaCrystal()
        mThreadBaixarCrystal = New Threading.Thread(AddressOf BaixarCrystal)
        mThreadBaixarCrystal.Start()
    End Sub
    Private Sub BaixarCrystal()
        Try
            Dim strDebug As String = My.Application.Info.DirectoryPath
            If IO.File.Exists(My.Application.Info.DirectoryPath & "\BarcodeLib.dll") = False Then
                My.Computer.Network.DownloadFile("ftp://minhadns.dyndns.org/Arquivos/BarcodeLib.dll", strDebug & "\BarcodeLib.dll", "Administrador", "sPfc4*5*6*")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "\logo.png") = False Then
                My.Computer.Network.DownloadFile("ftp://minhadns.dyndns.org/Arquivos/logo.png", strDebug & "\logo.png", "Administrador", "sPfc4*5*6*")
            End If
            If IO.File.Exists(My.Application.Info.DirectoryPath & "\logosantander.jpg") = False Then
                My.Computer.Network.DownloadFile("ftp://minhadns.dyndns.org/Arquivos/logosantander.jpg", strDebug & "\logosantander.jpg", "Administrador", "sPfc4*5*6*")
            End If

            If IO.File.Exists(My.Application.Info.DirectoryPath & "\CRRedist2005_x86.msi") Then
                Exit Sub
            Else
                My.Computer.Network.DownloadFile("ftp://minhadns.dyndns.org/programas/CRRedist2005_x86.msi", strDebug & "\CRRedist2005_x86.msi", "Administrador", "sPfc4*5*6*")
                If IO.File.Exists(My.Application.Info.DirectoryPath & "\CRRedist2005_x86.msi") Then
                    System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\CRRedist2005_x86.msi")

                End If
            End If
        Catch ex As Exception

        End Try

        mThreadBaixarCrystal.Abort()
    End Sub
    Dim mThreadSiteNano As Thread
    Public Sub IniciaThreadSiteNano()
        mThreadSiteNano = New Threading.Thread(AddressOf AbrirSiteNano)
        'mThreadSiteNano.SetApartmentState(Threading.ApartmentState.STA)
        mThreadSiteNano.Start()
    End Sub


    Private Sub AbrirSiteNano()
        If IO.File.Exists(My.Application.Info.DirectoryPath & "\SiteNano.txt") = False Then
            IO.File.Create(My.Application.Info.DirectoryPath & "\SiteNano.txt")
        End If
        'frmSiteNano.ShowDialog()
        'Timer4.Start()
        strLinks(0) = "https://www.sistemasnano.com.br/"
        strLinks(1) = "https://www.sistemasnano.com.br/planos/"
        strLinks(2) = "https://www.sistemasnano.com.br/automotivo/"
        strLinks(3) = "https://www.sistemasnano.com.br/planos2/"
        strLinks(4) = "https://www.sistemasnano.com.br/revendas/"
        strLinks(5) = "https://www.sistemasnano.com.br/quem-somos/"
        strLinks(6) = "https://www.sistemasnano.com.br/contato/"

        Randomize()
        Dim value As Integer = CInt(Int((7 * Rnd()) + 1))
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Navigate(strLinks(value - 1), "_top", Nothing, "User-Agent: Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.130 Safari/537.36")
        'IO.File.Create(My.Application.Info.DirectoryPath & "\SiteNano" & intContWb & "-" & value & ".txt")
        'Randomize()
        'intContRdn = CInt(Int((120 * Rnd()) + 1))
        IO.File.Create(My.Application.Info.DirectoryPath & "\SiteNano" & intContWb & "-" & value & "-" & intContRdn & ".txt")
    End Sub

    Private mThreadControle As Thread
    Public Sub IniciaThreadControle()
        mThreadControle = New Threading.Thread(AddressOf Verificar)
        mThreadControle.Start()
    End Sub


    Private Sub Verificar()
        Try

            Dim strTipDoc As String
            Dim strCPFConfig As String

            If CNPJEmpresa.Length = 11 Then
                strTipDoc = "Cpf"
            Else
                strTipDoc = "Cnpj"
            End If

            strCPFConfig = FormatarDocumentoString(CNPJEmpresa, strTipDoc)

            Dim dt As DataTable = DataTableOnline("Select Codigo, CPF, Ativado, Mensalista, Inadimplente, Inativo, Versao, CodFunc, Cupom, Nfe, SatFiscal, NFCe, PDV, AvisoNano, VisualizarCobranca, TipoNano from Cliente where CPF ='" & strCPFConfig & "'")


            Dim strAvisoNano As String = ""
            Dim bolVisualizarCobranca As Boolean = True

            If ErroConexaoOnline = True Then Exit Sub

            Dim intCodCli As Integer

            If dt.Rows.Count > 0 Then


                Dim bolAtivado, bolMens, bolInadim, bolInat, bolEraCupom, bolEraNFe, BolEraSAT, bolEraNFCe, bolEraPDV As Boolean
                Dim strTipoNano As String
                intCodCli = dt.Rows.Item(0).Item("Codigo").ToString

                bolAtivado = dt.Rows.Item(0).Item("Ativado")
                bolMens = dt.Rows.Item(0).Item("Mensalista")
                bolInadim = dt.Rows.Item(0).Item("Inadimplente")
                bolInat = dt.Rows.Item(0).Item("Inativo")
                bolEraCupom = dt.Rows.Item(0).Item("Cupom")
                bolEraNFe = dt.Rows.Item(0).Item("Nfe")
                BolEraSAT = dt.Rows.Item(0).Item("SatFiscal")
                bolEraNFCe = dt.Rows.Item(0).Item("NFCe")
                bolEraPDV = dt.Rows.Item(0).Item("PDV")
                strAvisoNano = dt.Rows.Item(0).Item("AvisoNano")
                bolVisualizarCobranca = dt.Rows.Item(0).Item("VisualizarCobranca")
                strTipoNano = dt.Rows.Item(0).Item("TipoNano").ToString
                If bolInat = True Then
                    Atualizar("Update Config set CNPJ ='00000000000' where Codigo =" & CodConfig)
                    bolDigitaCNPJ = True
                    Exit Sub
                End If

                If bolInadim = True Then
                    'MsgBox("A " & NomeEmpresa & " possui débitos com a Era Systems!" & vbCrLf & "Favor entrar em contato!", MsgBoxStyle.Exclamation)
                End If

                If bolMens = False Then
                    If Mensalista = True Then
                        Atualizar("Update Config set Mensalista ='False' where Codigo =" & CodConfig)
                    End If
                Else
                    If Mensalista = False Then
                        Atualizar("Update Config set Mensalista ='True' where Codigo =" & CodConfig)
                    End If
                End If


                If CNPJEmpresa <> "15237457000191" Then
                    'VERIFICA SE O CLIENTE EMITE CUPOM FISCAL
                    If bolEraCupom = False Then
                        If PafEcfNano = True Then
                            Atualizar("Update Config set PafEcfNano ='False' where Codigo =" & CodConfig)
                        End If
                    Else
                        If PafEcfNano = False Then
                            Atualizar("Update Config set PafEcfNano ='True' where Codigo =" & CodConfig)
                        End If
                    End If

                    'VERIFICA SE O CLIENTE EMITE SAT
                    If BolEraSAT = False Then
                        If SATFiscal = True Then
                            Atualizar("Update Config set SATFiscal ='False' where Codigo =" & CodConfig)
                        End If
                    Else
                        If SATFiscal = False Then
                            Atualizar("Update Config set SATFiscal ='True' where Codigo =" & CodConfig)
                        End If
                    End If

                End If


                'VERIFICA SE O CLIENTE EMITE NFE
                If bolEraNFe = False Then
                    If EmiteNFE = True Then
                        Atualizar("Update Config set NfeNano ='False' where Codigo =" & CodConfig)
                    End If
                    'If EmiteNFE = True Then
                    '    Atualizar("Update Config set UsaNfe ='False' where Codigo =" & CodConfig)
                    'End If
                Else
                    If EmiteNFE = False Then
                        Atualizar("Update Config set NfeNano ='True' where Codigo =" & CodConfig)
                    End If
                    'If EmiteNFE = False Then
                    '    Atualizar("Update Config set UsaNfe ='True' where Codigo =" & CodConfig)
                    'End If
                End If



                'VERIFICA SE O CLIENTE EMITE NFCE
                If bolEraNFCe = False Then
                    If NANONFCe = True Then
                        Atualizar("Update Config set NANONFCe ='False' where Codigo =" & CodConfig)
                    End If
                Else
                    If NANONFCe = False Then
                        Atualizar("Update Config set NANONFCe ='True' where Codigo =" & CodConfig)
                    End If
                End If

                'VERIFICA SE O CLIENTE USA APENAS O PDV
                If bolEraPDV = False Then
                    If UsaPDV = True Then
                        Atualizar("Update Config set PDV ='False' where Codigo =" & CodConfig)
                    End If
                Else
                    If UsaPDV = False Then
                        Atualizar("Update Config set PDV ='True' where Codigo =" & CodConfig)
                    End If
                End If



                If bolAtivado = False Then
                    ExecCmdOnline("Update Cliente set Ativado = 'True' where Codigo =" & intCodCli)
                End If

                If Me.lblVersao.Caption.Trim.Replace("Versão ", "") <> dt.Rows.Item(0).Item("Versao").ToString.Trim Then
                    ExecCmdOnline("Update Cliente set Versao = '" & Me.lblVersao.Caption.Trim.Replace("Versão ", "") & "' where Codigo =" & dt.Rows.Item(0).Item("Codigo").ToString)
                End If

                If EmiteNFe = True Then
                    Dim dtNfe As DataTable = CarregarDataTable("SELECT VerProc, TipoAmb FROM ConfigNfe")
                    If dtNfe.Rows.Count > 0 Then
                        Dim strAmb As String = ""
                        If dtNfe.Rows.Item(0).Item("VerProc").ToString <> "" Then
                            Select Case dtNfe.Rows.Item(0).Item("TipoAmb").ToString
                                Case "1"
                                    strAmb = "PRODUÇÃO"
                                Case "2"
                                    strAmb = "HOMOLOGAÇÃO"
                            End Select
                            Dim strNfe As String = "Ambiente: " & strAmb & " Versão: " & dtNfe.Rows.Item(0).Item("VerProc").ToString
                            ExecCmdOnline("Update Cliente set NomeConjuge = '" & strNfe & "' where Codigo =" & dt.Rows.Item(0).Item("Codigo").ToString)
                        End If

                    End If

                End If

                If SATFiscal = True Then
                    Dim dtNfe As DataTable = CarregarDataTable("SELECT VersaoXMLSAT FROM ConfigECF where Computador = '" & My.Computer.Name & "'")
                    If dtNfe.Rows.Count > 0 Then

                        If dtNfe.Rows.Item(0).Item("VersaoXMLSAT").ToString <> "" Then
                            ExecCmdOnline("Update Cliente set TelConjuge = '" & dtNfe.Rows.Item(0).Item("VersaoXMLSAT").ToString & "' where Codigo =" & dt.Rows.Item(0).Item("Codigo").ToString)
                        End If

                    End If

                End If

                If strTipoNano <> TipoNano Then
                    ExecCmdOnline("Update Cliente set TipoNano = '" & TipoNano & "' where Codigo =" & dt.Rows.Item(0).Item("Codigo").ToString)
                End If
            Else
                bolDigitaCNPJ = True
            End If

            dt = DataTableOnline("Select Vencimento, ValorParcela from ContaReceber where CodCli =" & intCodCli & " and RecebidoOK = 'False' and Pagamento ='BOLETO' and Vencimento <'" & Date.Today.AddDays(-3) & "'")

            If dt.Rows.Count > 0 Then
                If bolVisualizarCobranca = True Then
                    strAviso = "Aviso Nano" & vbCrLf & vbCrLf
                    strAviso &= "A " & NomeEmpresa & " possui débitos com a Era Systems!" & vbCrLf & vbCrLf


                    Dim I As Integer
                    Dim dblVal As Double

                    For I = 0 To dt.Rows.Count - 1
                        dblVal = dt.Rows.Item(I).Item("ValorParcela").ToString
                        strAviso &= "R$ " & dblVal.ToString("0.00") & "  " & Format(dt.Rows.Item(I).Item("Vencimento"), "dd/MM/yyyy") & vbCrLf
                    Next
                End If

                If strAvisoNano <> "" Then
                    strAviso &= strAvisoNano & vbCrLf & vbCrLf
                    Me.txtAviso.Properties.ScrollBars = ScrollBars.Vertical
                Else
                    Me.txtAviso.Properties.ScrollBars = ScrollBars.None
                End If
            Else
                If strAvisoNano <> "" Then
                    strAviso = "Aviso Nano" & vbCrLf & vbCrLf
                    strAviso &= strAvisoNano & vbCrLf & vbCrLf
                    Me.txtAviso.Properties.ScrollBars = ScrollBars.Vertical
                Else
                    Me.txtAviso.Properties.ScrollBars = ScrollBars.None
                End If

            End If






        Catch ex As Exception

        End Try

        mThreadControle.Abort()
    End Sub


    Private Sub BarButtonGroup4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles lblEraSystems.ItemClick
        System.Diagnostics.Process.Start("www.erasystems.com.br")
    End Sub

    Private Sub btnConProdu_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConProdu.ItemClick
        Dim frm As New frmConProduto
        If ManterMargemProd = True Then
            frm.strTipoProduto = "P"
        End If
        frm.Tag = "CONSULTA"
        frm.Show()
    End Sub

    Private Sub btnGraficoReceber_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGraficoReceber.ItemClick
        Dim frm As New frmGrafico
        frm.Tag = "RECEBER"
        frm.Show()
    End Sub

    Private Sub btnGraficoPagar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGraficoPagar.ItemClick
        Dim frm As New frmGrafico
        frm.Tag = "PAGAR"
        frm.Show()
    End Sub


    Private Sub NavBarControl3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NavBarControl3.Click
        Try
            If Me.NavBarControl3.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed Then
                If Me.NavBarControl3.NavPaneForm.ExpandedGroup.Expanded = True Then
                    ' Me.NavBarControl3.NavPaneForm.ExpandedGroup.Expanded = False
                    Me.NavBarControl3.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub NavBarControl3_NavPaneStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NavBarControl3.NavPaneStateChanged
        bolMDIPedPendente = True
        If Me.NavBarControl3.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded Then
            Me.pnlAnalitico.Visible = False
            Me.nbgPedido.Caption = "Pedidos Pendentes"

            Me.pnlPedido.Dock = DockStyle.Fill
            Dim intA As Integer = Me.pnlPedido.Size.Height
            Dim intL As Integer = Me.pnlPedido.Size.Width

            Dim intPed As Integer = (intA * 537) / 568

            Me.NavBarControl3.Size = New System.Drawing.Size(intL, intA)
            Me.NavBarControl3.OptionsNavPane.ExpandedWidth = intL
            Me.NavBarControl3.PaintStyleName = "ExplorerBarView"


            Me.nbgPedido.Appearance.BackColor = Color.White
            Me.nbgPedido.GroupClientHeight = intPed
            Me.nbgPedido.Expanded = True

            AtualizarGridPedido()


            Dim index As Integer = -999997
            grd1.FocusedRowHandle = index

            If ComandaPedido = True Then
                Me.colComanda.VisibleIndex = 1
                Me.colComanda.Visible = True
                grd1.FocusedColumn = Me.colComanda

            Else
                grd1.FocusedColumn = Me.colCod

            End If
            grd1.ShowEditor()
        Else

            Me.nbgPedido.Caption = "PEDIDOS PENDENTES"

        End If

    End Sub

    Private Sub NavBarControl3_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NavBarControl3.SizeChanged
        If bolMDIPedPendente = True Then
            Dim intd As Integer = Me.NavBarControl3.Size.Width

            If intd > 40 Then
                Dim intA As Integer = Me.Size.Height
                Dim intL As Integer = Me.Size.Width

                intA = Me.pnlPedido.Size.Height
                intL = Me.pnlPedido.Size.Width
                Me.NavBarControl3.Size = New System.Drawing.Size(intL, intA)
                Me.NavBarControl3.OptionsNavPane.ExpandedWidth = intL
            End If
        End If
    End Sub
    Private Sub AtualizarGridPedido()
        Dim strCodFunc As String = ""
        If VincularUser = True Then
            Dim dtUser As DataTable = CarregarDataTable("SELECT Codigo FROM Funcionario where codUser = " & CodUser)

            If dtUser.Rows.Count > 0 Then
                If dtUser.Rows.Item(0).Item("Codigo").ToString <> "" Then
                    strCodFunc = " And TotalConsig.CodFunc =" & dtUser.Rows.Item(0).Item("Codigo").ToString
                End If
            End If
        End If
        Dim strValorCusto As String = ""
        If Nivel <> "USUÁRIO" Then
            strValorCusto = ", TotalConsig.Custo as ValorCusto"
        End If
        If TipoNano = 3 Then
            CarregarDadosPedidoMDI("Select CodOrdens as Cod, Funcionario.Nome as Vendedor, Cliente.Nome as Cliente, " & _
               "TotalConsig.Data, TotalConsig.Descricao, Convert(Numeric(15,2),TotalConsig.Total) as Total, " & _
               "TotalConsig.Status, TotalConsig.StatusPedido, Animal.Nome as Animal, TotalConsig.Comanda, " & _
               "DataRetirada, DataEntrega From ((TotalConsig left join Cliente on TotalConsig.CodCli = Cliente.Codigo) " & _
               "left join Funcionario on TotalConsig.CodFunc = Funcionario.Codigo) left join Animal on " & _
               "TotalConsig.CodAnimal = Animal.Codigo where TotalConsig.Status <> 'Faturado' and " & _
               "TotalConsig.Status <> 'Excluído' and TotalConsig.CodConfig = " & CodConfig & strCodFunc, Me.TotalGridControl)

        ElseIf TipoNano = 5 Then
            CarregarDadosPedidoMDI("Select CodOrdens as Cod, Cliente.Nome as Cliente, " & _
                    "TotalConsig.Data, TotalConsig.Descricao, Convert(Numeric(15,2),TotalConsig.Total) as Total, " & _
                    "TotalConsig.Status, TotalConsig.StatusPedido, TotalConsig.Comanda, DataRetirada, DataEntrega, " & _
                    "Placa, Modelo + ' ' + Cor as Modelo " & strValorCusto & ", TotalConsig.KMEntrada From TotalConsig left join Cliente on " & _
                    "TotalConsig.CodCli = Cliente.Codigo " & _
                    "where TotalConsig.Status <> 'Faturado' and TotalConsig.Status <> 'Excluído' and " & _
                    "TotalConsig.CodConfig = " & CodConfig, Me.TotalGridControl)
        Else


            CarregarDadosPedidoMDI("Select CodOrdens as Cod, Funcionario.Nome as Vendedor, Cliente.Nome as Cliente, " & _
               "TotalConsig.Data, TotalConsig.Descricao, Convert(Numeric(15,2),TotalConsig.Total) as Total, " & _
               "TotalConsig.Status, TotalConsig.StatusPedido, TotalConsig.Comanda, DataRetirada, DataEntrega, " & _
               "Placa, Modelo + ' ' + Cor as Modelo " & strValorCusto & " From (TotalConsig left join Cliente on " & _
               "TotalConsig.CodCli = Cliente.Codigo)left join Funcionario on TotalConsig.CodFunc = Funcionario.Codigo " & _
               "where TotalConsig.Status <> 'Faturado' and TotalConsig.Status <> 'Excluído' and " & _
               "TotalConsig.CodConfig = " & CodConfig & strCodFunc, Me.TotalGridControl)

            Me.colVenda.Visible = False
            Me.colVenda.VisibleIndex = -1
        End If

        'Dim index As Integer = -999997
        'grd1.FocusedRowHandle = index
        'grd1.FocusedColumn = Me.colCod
        'grd1.ShowEditor()
    End Sub

    Private Sub btnOcultarPedPendente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOcultarPedPendente.Click
        Me.NavBarControl3.PaintStyleName = "SkinNavigationPane"
        Me.NavBarControl3.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        Me.nbgPedido.GroupClientHeight = 80
        If bolBloqueioAnalyzer = False Then
            Me.pnlAnalitico.Visible = True
        End If

        Me.pnlPedido.Dock = DockStyle.Left
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

    Private Sub Visualizar()
        Dim strCod As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCod)


        'CARREGA OS DADOS DE PEDIDO
        If strCod.Trim = "" Then Exit Sub
        Dim dt As DataTable = CarregarDataTable("Select Data, CodCli, Total, Descricao, Desconto, Status, Custo, " & _
        "Entrega, CodFunc, Funcionario.Nome, Acrescimo, convert(Varchar(10), DataRetirada, 103) as DataRetirada, " & _
        "Convert(varchar(10),DataEntrega,103) as DataEntrega, StatusPedido from TotalConsig left join " & _
        "Funcionario on TotalConsig.CodFunc = Funcionario.Codigo where TotalConsig.CodOrdens = " & strCod.Trim & " and TotalConsig.CodConfig =" & CodConfig)

        Dim vetData() As String = dt.Rows.Item(0).Item("Data").ToString.Split(" ")
        Dim strData As String = vetData(0)
        Dim strStatus As String = dt.Rows.Item(0).Item("Status").ToString
        Dim strNomeFunc As String = dt.Rows.Item(0).Item("Nome").ToString
        Dim strDesc As String = dt.Rows.Item(0).Item("Descricao").ToString
        Dim strStatusPed As String = dt.Rows.Item(0).Item("StatusPedido").ToString


        'CARREGA OS DADOS DE CLIENTE
        Dim strCodCli = dt.Rows.Item(0).Item("CodCli").ToString
        If strCodCli.Trim = Nothing Then Exit Sub
        Dim dtCli As DataTable = CarregarDataTable("Select Nome, Telefone, Fax, Email, Observacao, Desconto from Cliente Where Codigo =" & strCodCli)

        Dim strCliente, strTelefone, strFax, strEmail As String
        If dtCli.Rows.Count > 0 Then
            NomeDoCliente = dtCli.Rows.Item(0).ItemArray(0).ToString
            strCliente = dtCli.Rows.Item(0).ItemArray(0).ToString
            strTelefone = dtCli.Rows.Item(0).ItemArray(1).ToString
            strFax = dtCli.Rows.Item(0).ItemArray(2).ToString
            strEmail = dtCli.Rows.Item(0).ItemArray(3).ToString
        End If


        Dim rel As New relPed
        rel.lblTitulo.Text = NomeEmpresa
        rel.lblEndereco.Text = EnderecoEmpresa
        rel.lblFones.Text = TelefoneEmpresa
        rel.picLogo.Image = LogoTipo


        'CARREGAR PRODUTOS DO PEDIDO
        Dim dtPed As DataTable = CarregarDataTable("Select Codigo, CodOrdens, Qtd, CodigoProduto, Produto, ValorUnitario, " & _
        "ValorTotal, CodigoInterno, Custo, UM, Tamanho, UniSemDesc, Promocao, Desconto, MedidaA, MedidaB, QtdMedida from ItensConsig where CodOrdens = " & strCod.Trim & " and CodConfig =" & CodConfig)

        For I As Integer = 0 To dtPed.Rows.Count - 1
            With rel.tbConsig.Rows
                .Add()
                .Item(I).Item("Produto") = dtPed.Rows.Item(I).Item("Produto").ToString
                .Item(I).Item("Qtd") = dtPed.Rows.Item(I).Item("Qtd").ToString
                .Item(I).Item("Estoque") = CarregarQtd(dtPed.Rows.Item(I).Item("CodigoProduto").ToString)
                .Item(I).Item("ValorUnitario") = Format(dtPed.Rows.Item(I).Item("ValorUnitario"), "0.00")
                .Item(I).Item("ValorTotal") = Format(dtPed.Rows.Item(I).Item("ValorTotal"), "0.00")
                .Item(I).Item("Tamanho") = dtPed.Rows.Item(I).Item("Tamanho").ToString
                .Item(I).Item("Codigo") = dtPed.Rows.Item(I).Item("CodigoInterno").ToString


                If TipoNano = 2 Then
                    Dim dtLoc As DataTable = CarregarDataTable("SELECT Locacao2 FROM Produto where Codigo = " & dtPed.Rows.Item(I).Item("CodigoProduto").ToString)
                    If dtLoc.Rows.Count > 0 Then
                        .Item(I).Item("Tamanho") = dtLoc.Rows.Item(0).Item("Locacao2").ToString
                    End If

                Else
                    Dim dtLoc As DataTable = CarregarDataTable("SELECT Locacao FROM Produto where Codigo = " & dtPed.Rows.Item(I).Item("CodigoProduto").ToString)
                    If dtLoc.Rows.Count > 0 Then
                        If dtLoc.Rows.Item(0).Item("Locacao").ToString <> "" Then
                            .Item(I).Item("Locacao") = dtLoc.Rows.Item(0).Item("Locacao").ToString
                        End If
                    End If
                    .Item(I).Item("Tamanho") = dtPed.Rows.Item(I).Item("Tamanho").ToString
                End If

                If NomeEmpresa.ToUpper.Contains("RILOM") = True Then
                    Dim CodigoBarra As String = dtPed.Rows.Item(I).Item("CodigoInterno").ToString
                    Dim dtCodBarra As DataTable = CarregarDataTable("Select CodigoInterno From Produto Where CodigoBarra ='" & CodigoBarra & "'")

                    If dtCodBarra.Rows.Count > 0 Then
                        .Item(I).Item("Codigo") = dtCodBarra.Rows.Item(0).Item("CodigoInterno").ToString
                    Else
                        .Item(I).Item("Codigo") = dtPed.Rows.Item(I).Item("CodigoInterno").ToString
                    End If
                Else
                    .Item(I).Item("Codigo") = dtPed.Rows.Item(I).Item("CodigoInterno").ToString
                End If

                '.Item(I).Item("UniSemDesc") = Me.grd1.GetRowCellDisplayText(I, Me.colUniSemDesc)
                .Item(I).Item("UM") = dtPed.Rows.Item(I).Item("UM")
            End With
        Next

        If TipoNano = 2 Then
            rel.colTamanho.Caption = "Loc."
            rel.colTamanho.Width = 80
            rel.colLocacao.Visible = False
        Else
            'If parValores = False Then
            rel.colLocacao.Visible = True
            rel.colLocacao.VisibleIndex = 8
            rel.colLocacao1.Visible = True
            rel.colLocacao1.VisibleIndex = 8
            'End If
        End If

        rel.colCodigo.Width = 70
        rel.colCodigo1.Width = 70

        rel.lblNome.Text = strCliente
        rel.lblTel1.Text = strTelefone
        rel.lblTel2.Text = strFax
        rel.lblWeb.Text = strEmail.ToLower
        rel.lblPed.Text = strCod.Trim
        rel.lblData.Text = strData.Trim
        rel.lblVend.Text = strNomeFunc.Trim
        Dim vetObs As Array = Split(strDesc, "|")
        rel.rtbObs.Text = vetObs(0)
        rel.lblStatus.Text = strStatusPed.Trim

        'If parValores = False Then
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
            rel.colEstoque.VisibleIndex = 6
        End If
        'End If

        rel.tabAtivo.Visible = False
        rel.linhaAtivo.Visible = False
        rel.lblAtivo.Visible = False
        rel.colValorUnitario.Visible = False
        rel.colValorTotal.Visible = False
        rel.colUniSemDesc.Visible = False
        rel.XrTable1.Visible = False
        rel.lblAutorizacao.Visible = False


        rel.ShowPreview()

    End Sub

    Private Sub btnVisPedPentente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisPedPentente.Click
        'Me.TotalGridControl.ShowPrintPreview()
        'If TipoNano = 5 Then
        '    If ImpressaoPedidoCompleto = False Then
        '        If ImpressaoPadrao = True Then
        '            ImprimirPadrao()
        '        Else
        '            VisualizarAutomotivo()
        '        End If

        '    Else
        '        VisualizarAutomotivoCompleto()
        '    End If

        'Else
        '    Visualizar()
        'End If


        If TipoNano = 5 Then
            If ImpressaoPedidoCompleto = False Then
                If ImpressaoPadrao = True Then
                    ImprimirPadrao()
                Else
                    VisualizarAutomotivo()
                End If

            Else
                VisualizarAutomotivoCompleto()
            End If
        Else
            If ImpressaoPadrao = True Then
                ImprimirPadrao()
            Else
                'If ImpressaoPedidoCompleto = False Then
                Visualizar()
                'Else
                '    VisualizarCompleto()
                'End If
            End If

            End If

    End Sub

    Private Sub btnFatPedPendente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFatPedPendente.Click
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub


        Dim strCod As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCod)

        Dim dt As DataTable = CarregarDataTable("SELECT * FROM TotalConsig where CodOrdens = " & strCod & " and Status = 'Faturado' and CodConfig = " & CodConfig)
        If dt.Rows.Count > 0 Then
            MsgBox("Pedido já faturado!", MsgBoxStyle.Information)
            Exit Sub
        End If

        If ProcuraForm("frmVenda") = "frmVenda" Then

            If frmVenda.grd1.RowCount > 0 Then
                MsgBox("Não é possivel realizar esse procedimento pois já existe uma venda sendo realizada!", MsgBoxStyle.Information)
                Exit Sub
            End If

            ConsultaPedido = strCod
            frmVenda.F11(True)
            frmVenda.WindowState = FormWindowState.Maximized
        Else
            frmVenda.bolPedido = True
            ConsultaPedido = strCod
            frmVenda.Show()
            frmVenda.F11(True)

        End If

    End Sub

    Private Sub btnAltPedPendente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAltPedPendente.Click
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub


        Dim strCod As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCod)

        Dim dt As DataTable = CarregarDataTable("SELECT * FROM TotalConsig where CodOrdens = " & strCod & " and Status = 'Faturado' and CodConfig = " & CodConfig)
        If dt.Rows.Count > 0 Then
            MsgBox("Pedido já faturado!", MsgBoxStyle.Information)
            Exit Sub
        End If
        If ProcuraForm("frmPedido") = "frmPedido" Then
            If frmPedido.Tag = "ALTERA" Or frmPedido.Tag = "CONSULTA" Then
                MsgBox("A tela de pedido já esta aberta!", MsgBoxStyle.Information)
            End If
        Else
            frmPedido.Tag = "ALTERA"
            frmPedido.txtCodPed.Text = strCod
            frmPedido.txtCli.Focus()
            frmPedido.Show()
        End If

        'Dim frm As New frmPedido
      
    End Sub

    Private Sub btnConPedPendente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConPedPendente.Click
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        Dim strCod As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCod)

        If ProcuraForm("frmPedido") = "frmPedido" Then
            If frmPedido.Tag = "ALTERA" Or frmPedido.Tag = "CONSULTA" Then
                MsgBox("A tela de pedido já esta aberta!", MsgBoxStyle.Information)
            End If
        Else
            frmPedido.Tag = "CONSULTA"
            frmPedido.txtCodPed.Text = strCod
            frmPedido.txtCli.Focus()
            frmPedido.Show()
        End If
        'Dim frm As New frmPedido
        'frm.Tag = "CONSULTA"
        'frm.txtCodPed.Text = strCod
        'frm.Show()
    End Sub

    Private Sub btnCadPedPendente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadPedPendente.Click
        Dim frm As New frmPedido
        frm.Tag = "CADASTRA"
        frm.Show()
    End Sub

    Private Sub btnAtuPedPendentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtuPedPendentes.Click
        AtualizarGridPedido()
        Dim index As Integer = -999997
        grd1.FocusedRowHandle = index
        grd1.FocusedColumn = Me.colCod
        grd1.ShowEditor()
    End Sub

    Private Sub btnBoleto_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBoleto.ItemClick
        Dim strVersao As String = ""



        Try
            'System.IO.File.Delete(My.Application.Info.DirectoryPath & "\Controle.era")
            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\VersaoBoleto.txt")


            Dim wc As New System.Net.WebClient()

            'wc.DownloadFile("https://sites.google.com/site/cotroles/inadimplencia/Controle.era?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\Controle.era")
            wc.DownloadFile("https://sites.google.com/site/cotroles/versao/VersaoBoleto.txt?attredirects=0&d=1", CaminhoPastaBoleto & "\Debug\VersaoBoleto.txt")


        Catch ex As Exception

        End Try

        strVersao = LerArquivo(CaminhoPastaBoleto & "\Debug\VersaoBoleto.txt", False)

        Dim fluxoTexto As IO.StreamWriter
        Dim strLogin As String = LerArquivo(CaminhoPastaBoleto & "\Arquivos\Login.txt", False)
        fluxoTexto = New IO.StreamWriter(CaminhoPastaBoleto & "\Arquivos\Login.txt")
        fluxoTexto.Write("")
        fluxoTexto.Write(Login & "|" & Senha & "|" & strVersao)
        fluxoTexto.Close()
        System.Diagnostics.Process.Start(CaminhoPastaBoleto & "\Debug\NanoBoleto.exe")
    End Sub



    Private Sub btnInserirZeros_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInserirZeros.ItemClick
        frmCorrecaoEstoque.Text = "Inserir Zeros"
        frmCorrecaoEstoque.Tag = "ZEROS"
        frmCorrecaoEstoque.ShowDialog()
    End Sub

    Private Sub btnCadAnimal_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCadAnimal.ItemClick
        frmCadAnimal.Show()
    End Sub

    Private Sub btnHelp_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHelp.ItemClick
        Try
            If VerificaHelp() = True Then
                Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "64")
            End If
        Catch ex As Exception
            MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub btnRetorno_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRetorno.ItemClick
        frmConRetorno.Show()
    End Sub

    Private Sub btnVerificaBoleto_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVerificaBoleto.ItemClick
        frmConBol.Show()
    End Sub

    Private Sub btnFechaAviso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechaAviso.Click
        Me.picAviso.Visible = False
        Me.txtAviso.Visible = False
        Me.btnPagarAgora.Visible = False
        Me.btnFechaAviso.Visible = False
    End Sub

    Private Sub btnPagarAgora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagarAgora.Click
        frmConBol.Show()
    End Sub

    Private Sub btnConsultaTamanho_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConsultaTamanho.ItemClick
        frmConProdTam.Show()
    End Sub

    Private Sub btnVerificaCaixa_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVerificaCaixa.ItemClick
        If MsgBox("Deseja realmente inserir as vendas no caixa?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Dim dt As DataTable = CarregarDataTable("SELECT Recebimento.CodOrdem, Recebimento.Data, " & _
        "Recebimento.Valor, Recebimento.Pagamento, Cliente.Nome FROM (Recebimento left join Total " & _
        "on Recebimento.CodOrdem = Total.CodOrdem and Recebimento.Codconfig = Total.CodConfig) " & _
        "left join Cliente on Total.CodCli = Cliente.Codigo where FormaPagamento = 'A VISTA'")

        Dim I As Integer

        For I = 0 To dt.Rows.Count - 1
            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
            Dim dtData As Date = dt.Rows.Item(I).Item("Data")
            Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
            Dim strPagamento As String = dt.Rows.Item(I).Item("Pagamento").ToString
            Dim strCliente As String = dt.Rows.Item(I).Item("Nome").ToString

            Dim dt2 As DataTable = CarregarDataTable("Select IrCaixa from Pagamento where Descricao ='" & strPagamento & "' and Prazo = 'False'")

            If dt2.Rows.Count > 0 Then
                If dt2.Rows.Item(0).Item("IrCaixa").ToString = "SIM" Then
                    Dim dtCaixa As DataTable = CarregarDataTable("SELECT Codigo FROM Caixa where Motivo = '" & "Venda Nº " & strCodOrdem & ", " & strCliente & "'")
                    If dtCaixa.Rows.Count = 0 Then
                        Inserir("Insert into Caixa (Motivo, Credito, Pagamento, Valor, Data, Caixa, CodConfig) Values('" & "Venda Nº " & strCodOrdem & ", " & strCliente & "','" & "C" & "','" & strPagamento & "'," & Num(strValor) & ",'" & dtData & "',''," & CodConfig & ")")
                    End If

                End If
            End If
        Next
        MsgBox("OK", MsgBoxStyle.Information)
    End Sub

    Private Sub btnSATFiscal_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSATFiscal.ItemClick
        frmMenuSAT.Show()
    End Sub


    Private Sub btnTamQtdVenda_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTamQtdVenda.ItemClick
        Dim frm As New frmRelProdTamanho
        frm.Tag = "VENDA"
        frm.Show()
    End Sub


    Private Sub btnRelPedItens_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelPedItens.ItemClick
        frmRelPedido.Show()
    End Sub

    Private Sub relPedTotal_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles relPedTotal.ItemClick
        frmRelPedTot.Show()
    End Sub

    Private Sub btnRelSAT_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelSAT.ItemClick
        If NANONFCe = True Then
            frmRelNFCe.Show()
        Else
            frmRelSAT.Show()
        End If

    End Sub

    Private Sub btnInativar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInativar.ItemClick
        Dim bolMinima As Boolean = False
        If MsgBox("Qtde zerada com a qtde minima tambem zerada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            bolMinima = True
        End If
        Dim dtProd As DataTable = CarregarDataTable("SELECT Produto.Codigo FROM Produto where Inativo = 'False' order by Codigo")

        Dim I As Integer
        Dim A As Integer
        For I = 0 To dtProd.Rows.Count - 1

            Dim strCod As String = dtProd.Rows.Item(I).Item("Codigo").ToString


            Dim bolInativar As Boolean = False

            Dim dblQtd As Double = 0

            'For A = 0 To QtdeLoja - 1
            '    If NomeEmpresa.Contains("TAUÁ") = True Then
            '        If A = 4 Then
            '            Exit For
            '        End If
            '    End If
            '    dblQtd += AjusteQtde(A + 1, strCod)

            'Next

            dblQtd = AjusteQtde(1, strCod)

            If dblQtd = 0 Then
                If bolMinima = True Then
                    Dim dt As DataTable = CarregarDataTable("SELECT QtdMinima FROM Qtde where CodProd = " & strCod & " and Codconfig = " & CodConfig)
                    Dim dblQtdMinima As Double = 0
                    If dt.Rows.Count > 0 Then
                        If dt.Rows.Item(0).Item("QtdMinima").ToString <> "" Then
                            dblQtdMinima = dt.Rows.Item(0).Item("QtdMinima").ToString
                        End If

                    End If

                    If dblQtdMinima < 0 Then
                        bolInativar = True
                    End If
                Else
                    bolInativar = True
                End If
            End If

            If bolInativar = True Then
                Atualizar("UPDATE Produto set Inativo = 'True' where Codigo = " & strCod)
            End If


        Next
        MsgBox("OK", MsgBoxStyle.Information)

    End Sub

    Private Sub BarButtonItem10_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick

        If MsgBox("Deseja excluir Qtde duplicada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then


            Dim dtProd As DataTable = CarregarDataTable("SELECT Produto.Codigo FROM Produto order by Codigo")

            Dim I As Integer
            Dim A As Integer
            For I = 0 To dtProd.Rows.Count - 1

                Dim strCod As String = dtProd.Rows.Item(I).Item("Codigo").ToString



                Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM Qtde where CodProd = " & strCod & " and Codconfig = 2 order by Codigo Desc")
                If dt.Rows.Count >= 2 Then
                    For A = 0 To dt.Rows.Count - 2
                        Dim strCodQtde As String = dt.Rows.Item(A).Item("Codigo").ToString

                        Excluir("DELETE FROM Qtde where Codigo = " & strCodQtde)

                    Next

                End If

            Next
        End If
        MsgBox("OK", MsgBoxStyle.Information)
    End Sub

    Private Sub btnCadCompra_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCadCompra.ItemClick
        Dim frm As New frmPedidoCompra
        frm.Tag = "CADASTRA"
        frm.Show()
    End Sub

    Private Sub btnAltCompra_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAltCompra.ItemClick
        frmPedidoCompra.Tag = "ALTERA"
        frmPedidoCompra.Show()
    End Sub

    Private Sub btnConCompra_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConCompra.ItemClick
        frmPedidoCompra.Tag = "CONSULTA"
        frmPedidoCompra.Show()
    End Sub

    Private Sub btnItensPedCompra_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnItensPedCompra.ItemClick
        frmRelPedCompra.Show()
    End Sub

    Private Sub btnTotalPedCompra_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTotalPedCompra.ItemClick
        frmRelTotCompra.Show()
    End Sub

    Private Sub txtRetorno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRetorno.KeyDown

        If Me.grd1.FocusedColumn.Name <> "colCod" And Me.grd1.FocusedColumn.Name <> "colComanda" Then
            If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        End If

        If e.KeyCode = Keys.Enter Then
            Dim strCod As String = ""
            If Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCod) <> "" Then
                strCod = Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCod)
            Else
                If Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colComanda) <> "" Then
                    Dim dtCom As DataTable = CarregarDataTable("SELECT CodOrdens FROM TotalConsig where Status <> 'Faturado' and Comanda = '" & Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colComanda) & "'")
                    If dtCom.Rows.Count > 0 Then
                        strCod = dtCom.Rows.Item(0).Item("CodOrdens").ToString
                    Else
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If
            End If
            Dim dt As DataTable = CarregarDataTable("SELECT * FROM TotalConsig where CodOrdens = " & strCod & " and Status = 'Faturado'")
            If dt.Rows.Count > 0 Then
                MsgBox("Pedido já faturado!")
                Exit Sub
            End If

            Dim frm As New frmPedido
            frm.Tag = "ALTERA"
            frm.txtCodPed.Text = strCod
            frm.Show()
        End If


    End Sub

    Private Sub btnCampanha_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCadCampanha.ItemClick
        frmCampanha.Tag = "CADASTRA"
        frmCampanha.Show()
    End Sub

    Private Sub btnConsultar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConCampanha.ItemClick
        Dim frm As New frmCampanha
        frm.Tag = "CONSULTA"
        frm.Show()
    End Sub

    Private Sub btnAltCampanha_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAltCampanha.ItemClick
        frmCampanha.Tag = "ALTERA"
        frmCampanha.Show()
    End Sub

    Private Sub btnRelItensCampanha_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelItensCampanha.ItemClick
        Dim frm As New frmConCampanha
        frm.Tag = "ITENS"
        frm.Show()
    End Sub

    Private Sub btnRelTotalCampanha_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelTotalCampanha.ItemClick
        Dim frm As New frmConCampanha
        frm.Size = New System.Drawing.Size(800, 550)

        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Tag = "TOTAL"
        frm.Show()
    End Sub

    Private Sub btnFinalizarCampanha_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFinalizarCampanha.ItemClick
        Dim frm As New frmCampanha
        frm.Tag = "FINALIZAR"
        frm.Show()

    End Sub

    Private Sub BarButtonItem17_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        'If MsgBox("Deseja atualizar custo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '    Dim strData As String = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Date.Today.AddMonths(-3), Date.Today.AddDays(1))


        '    Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM TotalEntradaNF where " & strData)

        '    Dim I As Integer
        '    Dim A As Integer
        '    For I = 0 To dt.Rows.Count - 1
        '        Dim strCodigo As String = dt.Rows.Item(I).Item("Codigo").ToString

        '        Dim dtEnt As DataTable = CarregarDataTable("SELECT CodProd, EntradaNF.ValorCusto, Produto.Valor FROM EntradaNF left join Produto on Entradanf.CodProd = Produto.Codigo Where CodTotNF = " & strCodigo)
        '        For A = 0 To dtEnt.Rows.Count - 1
        '            Dim strCodProd As String = dtEnt.Rows.Item(A).Item("CodProd").ToString
        '            Dim dblValorCusto As Double = dtEnt.Rows.Item(A).Item("ValorCusto").ToString
        '            Dim dblValVenda, dblLucro, dblMargem As Double

        '            dblValVenda = dtEnt.Rows.Item(A).Item("Valor").ToString


        '            dblLucro = dblValVenda - dblValorCusto

        '            dblMargem = (dblLucro * 100) / dblValorCusto
        '            Dim str As String = dblMargem
        '            Dim strPor As String = "0"
        '            If str <> "+Infinito" And str <> "NaN (Não é um número)" Then
        '                If TresCasasDecimais = True Then
        '                    strPor = dblMargem.ToString("0.000")
        '                Else
        '                    strPor = dblMargem.ToString("0.00")
        '                End If

        '            End If
        '            Atualizar("Update Produto set ValorCusto =" & Num(dblValorCusto) & ", Valor = " & Num(dblValVenda) & ", Porcentagens = '" & strPor & "' where Codigo =" & strCodProd)
        '            Atualizar("Update Qtde set ValorCusto =" & Num(dblValorCusto) & " where CodProd =" & strCodProd)
        '        Next

        '    Next

        '    MsgBox("OK", MsgBoxStyle.Information)
        'End If

        If MsgBox("Deseja atualizar custo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim I As Integer
            Dim strData As String = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Date.Today.AddMonths(-3), Date.Today.AddDays(1))

            Dim dtEnt As DataTable = CarregarDataTable("SELECT CodProd, sum(Qtd * ValorCusto) as ValorCusto, sum(Qtd) as Qtd " & _
            "FROM EntradaNF group by CodProd")
            Dim A As Integer
            For A = 0 To dtEnt.Rows.Count - 1
                Dim strCodProd As String = dtEnt.Rows.Item(A).Item("CodProd").ToString

                Dim dtProd As DataTable = CarregarDataTable("SELECT Valor, ValorCusto FROM Produto where Codigo = " & strCodProd)

                Dim dblValCusto As Double = dtProd.Rows.Item(0).Item("ValorCusto").ToString
                Dim dblValor As Double = dtProd.Rows.Item(0).Item("Valor").ToString

                Dim dblValorCusto As Double = dtEnt.Rows.Item(A).Item("ValorCusto").ToString
                Dim dblQtd As Double = dtEnt.Rows.Item(A).Item("Qtd").ToString
                Dim strVal As String
                Dim dblResul As Double = dblValorCusto / dblQtd

                Dim strResultado As String = dblResul.ToString("0.00")

                If strResultado.Contains("+Infinito") = False Or strResultado.Contains("NaN") = False Then
                    strVal = strResultado

                    Dim dblValVenda, dblLucro, dblMargem As Double

                    dblLucro = dblValor - strVal

                    dblMargem = (dblLucro * 100) / strVal

                    Dim str As String = dblMargem
                    Dim strPor As String = "0"
                    If str <> "+Infinito" And str <> "NaN (Não é um número)" Then
                        If TresCasasDecimais = True Then
                            strPor = dblMargem.ToString("0.000")
                        Else
                            strPor = dblMargem.ToString("0.00")
                        End If

                    End If

                    Atualizar("Update Produto set ValorCusto =" & Num(strVal) & ", Porcentagens = '" & strPor & "' where Codigo =" & strCodProd)
                    Atualizar("Update Qtde set ValorCusto =" & Num(strVal) & " where CodProd =" & strCodProd)


                    Dim dtPed As DataTable = CarregarDataTable("SELECT Pedido.Codigo, Qtd FROM Pedido left join Total " & _
                    "on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig where CodProd = " & strCodProd & " and " & strData)

                    For I = 0 To dtPed.Rows.Count - 1
                        Dim strCodigo As String = dtPed.Rows.Item(I).Item("Codigo").ToString
                        Dim dblQtdPed As Double = dtPed.Rows.Item(I).Item("Qtd").ToString

                        Dim dblValCustoPed As Double = dblQtdPed * strVal

                        Atualizar("UPDATE Pedido set Custo = " & Num(dblValCustoPed) & " where Codigo = " & strCodigo)
                    Next

                End If

            Next

            strData = String.Format("T.Data >= '{0:dd/MM/yyyy}' AND T.Data <= '{1:dd/MM/yyyy}'", Date.Today.AddMonths(-3), Date.Today.AddDays(1))

            Atualizar("Update T set T.Custo = (SELECT sum(P.Custo) FROM Pedido P where P.CodOrdem = T.CodOrdem and P.CodConfig = T.CodConfig) FROM Total T where " & strData)

            MsgBox("OK", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnImporCamp_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImporCamp.ItemClick
        frmCampanha.Tag = "EXCEL"
        frmCampanha.Show()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        IniciaThread()
        intContAgenda = 0
    End Sub
    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub

    Private Sub BarButtonItem18_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        ''If MsgBox("Deseja atualizar custo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

        ''    Dim I As Integer

        ''    Dim dtEnt As DataTable = CarregarDataTable("SELECT Max(Codigo) as Codigo, CodProd FROM EntradaNF group by CodProd")
        ''    Dim A As Integer
        ''    For A = 0 To dtEnt.Rows.Count - 1
        ''        Dim strCodProd As String = dtEnt.Rows.Item(A).Item("CodProd").ToString
        ''        Dim strCodEnt As String = dtEnt.Rows.Item(A).Item("Codigo").ToString
        ''        'Dim dtProd As DataTable = CarregarDataTable("SELECT EntradaNF.ValorCusto, Produto.Valor " & _
        ''        '             "FROM EntradaNF left join Produto on EntradaNF.CodProd = Produto.Codigo where EntradaNF.Codigo = " & strCodEnt & " and EntradaNF.CodProd = " & strCodProd)

        ''        Dim dtProd As DataTable = CarregarDataTable("SELECT EntradaNF.ValorUnitario as ValorCusto, Produto.Valor " & _
        ''        "FROM EntradaNF left join Produto on EntradaNF.CodProd = Produto.Codigo where EntradaNF.Codigo = " & strCodEnt & " and EntradaNF.CodProd = " & strCodProd)

        ''        Dim dblValCusto As Double = dtProd.Rows.Item(0).Item("ValorCusto").ToString
        ''        Dim dblValor As Double = dtProd.Rows.Item(0).Item("Valor").ToString

        ''        'Dim dblValorCusto As Double = dtEnt.Rows.Item(A).Item("ValorCusto").ToString
        ''        'Dim dblQtd As Double = dtEnt.Rows.Item(A).Item("Qtd").ToString

        ''        'Dim strVal As String
        ''        'Dim dblResul As Double = dblValorCusto / dblQtd

        ''        'Dim strResultado As String = dblResul.ToString("0.00")

        ''        ' If strResultado.Contains("+Infinito") = False Or strResultado.Contains("NaN") = False Then
        ''        ' strVal = strResultado

        ''        Dim dblValVenda, dblLucro, dblMargem As Double

        ''        dblLucro = dblValor - dblValCusto

        ''        dblMargem = (dblLucro * 100) / dblValCusto

        ''        Dim str As String = dblMargem
        ''        Dim strPor As String = "0"
        ''        If str <> "+Infinito" And str <> "NaN (Não é um número)" Then
        ''            If TresCasasDecimais = True Then
        ''                strPor = dblMargem.ToString("0.000")
        ''            Else
        ''                strPor = dblMargem.ToString("0.00")
        ''            End If

        ''        End If

        ''        Atualizar("Update Produto set ValorCusto =" & Num(dblValCusto) & ", Porcentagens = '" & strPor & "' where Codigo =" & strCodProd)
        ''        Atualizar("Update Qtde set ValorCusto =" & Num(dblValCusto) & " where CodProd =" & strCodProd)


        ''        'Dim dtPed As DataTable = CarregarDataTable("SELECT Pedido.Codigo, Qtd FROM Pedido left join Total " & _
        ''        '"on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig where CodProd = " & strCodProd & " and " & strData)

        ''        'For I = 0 To dtPed.Rows.Count - 1
        ''        '    Dim strCodigo As String = dtPed.Rows.Item(I).Item("Codigo").ToString
        ''        '    Dim dblQtdPed As Double = dtPed.Rows.Item(I).Item("Qtd").ToString

        ''        '    Dim dblValCustoPed As Double = dblQtdPed * strVal

        ''        '    Atualizar("UPDATE Pedido set Custo = " & Num(dblValCustoPed) & " where Codigo = " & strCodigo)
        ''        'Next

        ''        'End If

        ''    Next

        ''    'strData = String.Format("T.Data >= '{0:dd/MM/yyyy}' AND T.Data <= '{1:dd/MM/yyyy}'", Date.Today.AddMonths(-3), Date.Today.AddDays(1))

        ''    'Atualizar("Update T set T.Custo = (SELECT sum(P.Custo) FROM Pedido P where P.CodOrdem = T.CodOrdem and P.CodConfig = T.CodConfig) FROM Total T where " & strData)

        ''    MsgBox("OK", MsgBoxStyle.Information)
        ''End If


        'Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM Produto")
        'Dim I As Integer
        'For I = 0 To dt.Rows.Count - 1
        '    Dim strCodigo As String = dt.Rows.Item(I).Item("Codigo").ToString
        '    Dim strCodAut As String = ""
        '    Dim strCodigoBarra As String = ""
        '    Dim dtBarra As DataTable = CarregarDataTable("SELECT Codigo, CodigoBarra FROM CodigoBarra where CodProd = " & strCodigo & " and len(CodigoBarra) = 13 and substring(CodigoBarra,1,1)='7'")
        '    If dtBarra.Rows.Count > 0 Then
        '        strCodigoBarra = dtBarra.Rows.Item(0).Item("CodigoBarra").ToString
        '        strCodAut = dtBarra.Rows.Item(0).Item("Codigo").ToString
        '    Else
        '        dtBarra = CarregarDataTable("SELECT Codigo, CodigoBarra FROM CodigoBarra where CodProd = " & strCodigo)
        '        If dtBarra.Rows.Count > 0 Then
        '            strCodigoBarra = dtBarra.Rows.Item(0).Item("CodigoBarra").ToString
        '            strCodAut = dtBarra.Rows.Item(0).Item("Codigo").ToString
        '        End If
        '    End If

        '    If strCodAut <> "" Then
        '        Atualizar("UPDATE Produto set CodigoBarra = '" & strCodigoBarra & "' where Codigo = " & strCodigo)
        '        Excluir("DELETE FROM CodigoBarra WHERE Codigo = " & strCodAut)
        '    End If
        'Next

        If MsgBox("Deseja atualizar codigo funcionario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim I As Integer

            Dim dtEnt As DataTable = CarregarDataTable("SELECT CodOrdem, CodFunc, Produto FROM Pedido where CodConfig =1 and CodOrdem in(1300,1578,1738,2114,2137,3336,3355,4917,11854,26193,29993,32737,34972,38531,39272,44284,48076,1289,1439,1621,1697,4994,13680,22678,22745,23044,25824,30242,31198,32193,42757,43727,46764,48836,3843,7550,12057,12409,20016,22634,29155,30045,31320,34410,35464,39299,40341,41564,41706,45399,49922,50220,52609,53433,1624,1715,3336,3355,4827,16930,18646,23528,24642,25364,29948,30204,33084,37634,40431,42757,48013,52501,53249) order by codigo ")
            Dim A As Integer
            For A = 0 To dtEnt.Rows.Count - 1
                Dim strCodProd As String = dtEnt.Rows.Item(A).Item("CodOrdem").ToString
                Dim strCodEnt As String = dtEnt.Rows.Item(A).Item("CodFunc").ToString
                Dim strproduto As String = dtEnt.Rows.Item(A).Item("Produto").ToString
                Atualizar("UPDATE ItensConsig set CodigoFuncionario = " & strCodEnt & " where CodOrdens = " & strCodProd & " and Produto = '" & strproduto & "' and CodConfig = 1")
            Next

            dtEnt = CarregarDataTable("SELECT CodOrdem, CodFunc, Produto FROM Pedido where CodConfig =2 and CodOrdem in(43,47,82) order by codigo ")

            For A = 0 To dtEnt.Rows.Count - 1
                Dim strCodProd As String = dtEnt.Rows.Item(A).Item("CodOrdem").ToString
                Dim strCodEnt As String = dtEnt.Rows.Item(A).Item("CodFunc").ToString
                Dim strproduto As String = dtEnt.Rows.Item(A).Item("Produto").ToString
                Atualizar("UPDATE ItensConsig set CodigoFuncionario = " & strCodEnt & " where CodOrdens = " & strCodProd & " and Produto = '" & strproduto & "' and CodConfig = 2")
            Next

            MsgBox("OK", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnMedia_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMedia.ItemClick
        frmRelMediaVenda.Show()
    End Sub

    Private Sub BarButtonItem19_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        Dim dt As DataTable = CarregarDataTable("select count(codigo), codordem, codconfig FROM Total group by  codordem, codconfig having (count(codigo)>1)")

        Dim I As Integer
        Dim A As Integer
        For I = 0 To dt.Rows.Count - 1

            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
            Dim strLoja As String = dt.Rows.Item(I).Item("codconfig").ToString
            Dim dtPed As DataTable = CarregarDataTable("SELECT Produto.CodigoInterno FROM PEdido left join " & _
            "Produto on Pedido.CodProd = Produto.COdigo where CodOrdem = " & strCodOrdem & " and CodConfig = " & strLoja)

            For A = 0 To dtPed.Rows.Count - 1

                Dim strCod As String = dtPed.Rows.Item(A).Item("CodigoInterno").ToString
                Inserir("INSERT INTO Animal (Nome) VALUES('" & strCod & "')")

            Next

        Next
    End Sub

    Private Sub BarButtonItem21_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        'Dim dtCaixa As DataTable = CarregarDataTable("SELECT Codigo, Motivo FROM Caixa where CodConfig = 1 and codigo >649067 ")
        'Dim A As Integer

        'For A = 0 To dtCaixa.Rows.Count - 1
        '    Dim strCodCaixa As String = dtCaixa.Rows.Item(A).Item("Codigo").ToString
        '    Dim strMotivo As String = dtCaixa.Rows.Item(A).Item("Motivo").ToString
        '    Dim intCod As Integer
        '    If strMotivo.Contains("Venda Nº ") Then
        '        strMotivo = dtCaixa.Rows.Item(A).Item("Motivo").ToString.Replace("Venda Nº ", "")
        '        If strMotivo.Contains("Troco") Then
        '            strMotivo = strMotivo.Replace("Troco ", "")
        '            intCod = strMotivo
        '            intCod += 1340
        '            Atualizar("UPDATE Caixa set Motivo = 'Troco Venda Nº " & intCod & "' where Codigo = " & strCodCaixa & " and Codconfig = 1")
        '        Else
        '            Dim vetMot As Array = Split(strMotivo, ",")
        '            intCod = vetMot(0)
        '            intCod += 1340
        '            Atualizar("UPDATE Caixa set Motivo = 'Venda Nº " & intCod & ", " & vetMot(1) & "' where Codigo = " & strCodCaixa & " and Codconfig = 1")
        '        End If
        '    End If


        'Next


        If MsgBox("Deseja excluir tributacao duplicada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then



            Dim dt As DataTable = CarregarDataTable("SELECT Codigo, CodProd FROM NFE where Regime = 'SIMPLES NACIONAL' order by CodProd, Codigo")
            Dim I As Integer
            Dim strCodigoProduto As String = ""
            Dim strDelete As String = ""
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As String = dt.Rows.Item(I).Item("Codigo").ToString
                Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString

                If strCodigoProduto = strCodProd Then
                    'strDelete &= "DELETE FROM Nfe where Codigo = " & strCodigo & vbCrLf
                    Excluir("DELETE FROM Nfe where Codigo = " & strCodigo)

                Else
                    strCodigoProduto = strCodProd
                End If
            Next

            dt = CarregarDataTable("SELECT Codigo, CodProd FROM NFE where Regime = 'TRIBUTAÇÃO NORMAL' order by CodProd, Codigo")

            strCodigoProduto = ""
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As String = dt.Rows.Item(I).Item("Codigo").ToString
                Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString

                If strCodigoProduto = strCodProd Then

                    'strDelete &= "DELETE FROM Nfe where Codigo = " & strCodigo & vbCrLf
                    Excluir("DELETE FROM Nfe where Codigo = " & strCodigo)
                Else
                    strCodigoProduto = strCodProd
                End If
            Next


            dt = CarregarDataTable("SELECT Codigo, CodProd FROM TRIBUTOS where Regime = 'SIMPLES NACIONAL' order by CodProd, Codigo")

            strCodigoProduto = ""

            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As String = dt.Rows.Item(I).Item("Codigo").ToString
                Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString

                If strCodigoProduto = strCodProd Then
                    'strDelete &= "DELETE FROM tributos where Codigo = " & strCodigo & vbCrLf
                    Excluir("DELETE FROM tributos where Codigo = " & strCodigo)

                Else
                    strCodigoProduto = strCodProd
                End If
            Next

            dt = CarregarDataTable("SELECT Codigo, CodProd FROM TRIBUTOS where Regime = 'TRIBUTAÇÃO NORMAL' order by CodProd, Codigo")

            strCodigoProduto = ""
            For I = 0 To dt.Rows.Count - 1
                Dim strCodigo As String = dt.Rows.Item(I).Item("Codigo").ToString
                Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString

                If strCodigoProduto = strCodProd Then

                    'strDelete &= "DELETE FROM tributos where Codigo = " & strCodigo & vbCrLf
                    Excluir("DELETE FROM tributos where Codigo = " & strCodigo)
                Else
                    strCodigoProduto = strCodProd
                End If
            Next
            'Call SalvarArquivo(strDelete, "C:\NANO\DELETETRIBUTOS1.txt", False)


            Excluir("DELETE FROM Nfe where Regime = ''")
            Excluir("DELETE FROM Tributos where Regime = ''")
        End If


    End Sub

    Private Sub btnConfigTEF_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConfigTEF.ItemClick
        frmMenuTEF.ShowDialog()
    End Sub

    Private Sub btnGraficoVend_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGraficoVend.ItemClick
        frmGraficoPorProduto.Tag = "Vendedor"
        frmGraficoPorProduto.Show()
    End Sub

    Private Sub btnGraficoProdVend_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGraficoProdVend.ItemClick
        frmGraficoSetores.Tag = "Vendedor"
        frmGraficoSetores.Show()
    End Sub

    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        'If MsgBox("Deseja realmente inativar Produto não utilizado a 3 meses?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        'Dim strCodInterno As String = ""
        'Dim dtProd As DataTable = CarregarDataTable("SELECT Codigo, Data, CodigoInterno FROM Produto where Inativo = 'False'")
        'Dim A As Integer
        'Dim B As Integer = 0
        'For A = 0 To dtProd.Rows.Count - 1
        '    Dim strCodProd As String = dtProd.Rows.Item(A).Item("Codigo").ToString
        '    Dim dtData As Date = dtProd.Rows.Item(A).Item("Data").ToString
        '    Dim strCodigoInterno As String = dtProd.Rows.Item(A).Item("CodigoInterno").ToString
        '    Dim dtTotal As DataTable = CarregarDataTable("SELECT Max(Data) as Data FROM Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and " & _
        '    "Total.CodConfig = PEdido.CodConfig where Pedido.CodProd = " & strCodProd)
        '    Dim bolInativar As Boolean = False
        '    If dtTotal.Rows.Count > 0 Then
        '        If dtTotal.Rows.Item(0).Item("Data").ToString <> "" Then
        '            Dim dtDataTotal As Date = dtTotal.Rows.Item(0).Item("Data").ToString
        '            If dtDataTotal < Date.Today.AddMonths(-3) Then
        '                bolInativar = True
        '            End If
        '        Else
        '            If dtData < Date.Today.AddMonths(-3) Then
        '                bolInativar = True
        '            End If
        '        End If

        '    Else
        '        If dtData < Date.Today.AddMonths(-3) Then
        '            bolInativar = True
        '        End If
        '    End If
        '    If bolInativar = True Then
        '        Atualizar("UPDATE Produto set Inativo = 'True', Locacao2 = 'INATIVO' where Codigo = " & strCodProd)


        '        If B > 50 Then
        '            B = 0
        '            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
        '                      "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Produto Ativo'," & _
        '                      "'Cód. Prod.: " & strCodInterno & " - INATIVO','INATIVO 3 MESES','PRODUTO','ALTERAÇÃO'," & CodConfig & ")")


        '            strCodInterno = ""
        '        Else
        '            strCodInterno &= strCodigoInterno & ","
        '        End If

        '        B += 1
        '    End If
        'Next

        'If strCodInterno <> "" Then
        '    Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
        '                                 "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Produto Ativo'," & _
        '                                 "'Cód. Prod.: " & strCodInterno & " - INATIVO','INATIVO 3 MESES','PRODUTO','ALTERAÇÃO'," & CodConfig & ")")
        'End If

        'MsgBox("OK", MsgBoxStyle.Information)

        'If MsgBox("Deseja realmente inativar Produto não utilizado a 3 meses?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        'Dim strCodInterno As String = ""
        'Dim dtProd As DataTable = CarregarDataTable("SELECT Codigo, Data, CodigoInterno FROM Produto where Inativo = 'False'")
        'Dim A As Integer
        'Dim B As Integer = 0
        'For A = 0 To dtProd.Rows.Count - 1
        '    Dim strCodProd As String = dtProd.Rows.Item(A).Item("Codigo").ToString
        '    Dim dtData As Date = dtProd.Rows.Item(A).Item("Data").ToString
        '    Dim strCodigoInterno As String = dtProd.Rows.Item(A).Item("CodigoInterno").ToString
        '    Dim dtTotal As DataTable = CarregarDataTable("SELECT Max(Data) as Data FROM Total left join Pedido on Total.CodOrdem = Pedido.CodOrdem and " & _
        '    "Total.CodConfig = PEdido.CodConfig where Pedido.CodProd = " & strCodProd)
        '    Dim bolInativar As Boolean = False
        '    If dtTotal.Rows.Count > 0 Then
        '        If dtTotal.Rows.Item(0).Item("Data").ToString <> "" Then
        '            Dim dtDataTotal As Date = dtTotal.Rows.Item(0).Item("Data").ToString
        '            If dtDataTotal < Date.Today.AddMonths(-3) Then
        '                bolInativar = True
        '            End If
        '        Else
        '            If dtData < Date.Today.AddDays(-5) Then
        '                bolInativar = True
        '            End If
        '        End If

        '    Else
        '        If dtData < Date.Today.AddDays(-5) Then
        '            bolInativar = True
        '        End If
        '    End If
        '    If bolInativar = True Then
        '        Atualizar("UPDATE Produto set Inativo = 'True', Locacao2 = 'INATIVO' where Codigo = " & strCodProd)


        '        If B > 50 Then
        '            B = 0
        '            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
        '                      "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Produto Ativo'," & _
        '                      "'Cód. Prod.: " & strCodInterno & " - INATIVO','INATIVO 3 MESES','PRODUTO','ALTERAÇÃO'," & CodConfig & ")")


        '            strCodInterno = ""
        '        Else
        '            strCodInterno &= strCodigoInterno & ","
        '        End If

        '        B += 1
        '    End If
        'Next

        'If strCodInterno <> "" Then
        '    Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
        '                                 "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Produto Ativo'," & _
        '                                 "'Cód. Prod.: " & strCodInterno & " - INATIVO','INATIVO 3 MESES/5 DIAS','PRODUTO','ALTERAÇÃO'," & CodConfig & ")")
        'End If
        Dim I As Integer
        Dim strTeste As String = ""
        Dim dt As DataTable = CarregarDataTable("select count(Codprod),codprod, qtd from transferencia where codordem = 173 and codconfig = 9 and codloja = 3 group by codprod,qtd having count(codprod) =2 order by codprod")
        For I = 0 To dt.Rows.Count - 1
            Dim strCodProd As String = dt.Rows.Item(I).Item("codprod").ToString
            Dim dtT As DataTable = CarregarDataTable("select * FROM Transferencia where codordem = 173 and codconfig = 9 and codloja = 3 and codprod = " & strCodProd)
            If dtT.Rows.Count > 0 Then
                Dim strCodigo1 As String = dtT.Rows.Item(1).Item("Codigo").ToString
                'Dim strCodigo2 As String = dtT.Rows.Item(2).Item("Codigo").ToString
                Dim strqtd As Double = dtT.Rows.Item(1).Item("Qtd").ToString
                Excluir("DELETE FROM TRansferencia where Codigo = " & strCodigo1)
                'Excluir("DELETE FROM TRansferencia where Codigo = " & strCodigo2)

                strTeste &= "DELETE FROM TRansferencia where Codigo = " & strCodigo1 & vbCrLf
                'strTeste &= "DELETE FROM TRansferencia where Codigo = " & strCodigo2 & vbCrLf

                Dim dtA As DataTable = CarregarDataTable("select * FROM Ajusteqtde where codconfig = 9 and " & _
                "tabela = 'TRANS. ENVIADA' and day(data) = '12' and month(data)='03' and year(data)='2019' " & _
                "and Qtd = -" & Num(strqtd) & " and codprod = " & strCodProd)

                If dtA.Rows.Count > 0 Then
                    strCodigo1 = dtA.Rows.Item(1).Item("Codigo").ToString
                    'strCodigo2 = dtA.Rows.Item(2).Item("Codigo").ToString
                    Excluir("DELETE FROM ajusteqtde where Codigo = " & strCodigo1)
                    'Excluir("DELETE FROM ajusteqtde where Codigo = " & strCodigo2)

                    strTeste &= "DELETE FROM ajusteqtde where Codigo = " & strCodigo1 & vbCrLf
                    'strTeste &= "DELETE FROM ajusteqtde where Codigo = " & strCodigo2 & vbCrLf

                End If
            End If
        Next


        strTeste = strTeste
        MsgBox("OK", MsgBoxStyle.Information)
    End Sub

    Private Sub btnRelQuery_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelQuery.ItemClick
        frmRelQuery.Show()
    End Sub
    Public Sub IniciaThreadConsultoria()
        mThreadConsultoria = New Threading.Thread(AddressOf VerificarConsultoria)
        mThreadConsultoria.Start()
    End Sub
    Private Sub VerificarConsultoria()
        Dim I As Integer
        Try

         

            If IO.File.Exists("C:\NANO\Consultoria\ArquivoConsultoria.zip") = True Then
                File.Delete("C:\NANO\Consultoria\ArquivoConsultoria.zip")
            End If

            Dim strDataAtual As String = Format(CInt(Date.Today.Day), "00") & "-" & Format(CInt(Date.Today.Month), "00") & "-" & Format(CInt(Date.Today.Year), "0000")
            If IO.File.Exists("C:\NANO\Consultoria\" & strDataAtual & ".xls") = True Then Exit Sub

            Dim dt As DataTable
            Dim A As Integer = -1
            Do
                Dim dataFim, dataIni As Date
                dataIni = Date.Today.AddDays(A)
                dataFim = Date.Today.AddDays(A)

                Dim strData As String = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", dataIni, dataFim)

                dt = CarregarDataTable("SELECT Cliente.Nome as Cliente, Cliente.Telefone, Cliente.Nascimento, Cliente.Data as Cadastro, " & _
                "Cliente.Endereco, Cliente.Numero, Cliente.Cep, Cliente.CPF, Total.CodOrdem as Ordem, Total.Data, Total.Placa, " & _
                "Pedido.Produto, Produto.Tipo as TipoProduto, Pedido.Qtd, Pedido.ValorUnitario, Pedido.ValorTotal FROM ((Pedido left join Produto on Pedido.CodProd = Produto.Codigo) left join Total on " & _
                "Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig) left join Cliente on " & _
                "Total.CodCli = Cliente.Codigo where " & strData & " and Total.CodConfig = " & CodConfig)
                If dt.Rows.Count > 0 Then
                    Exit Do
                Else
                    A -= 1
                    If A = -10 Then
                        Exit Sub
                    End If
                End If
            Loop

            If dt.Rows.Count > 0 Then
                Dim rel As New relConsultoria
                With rel.tbCon.Rows
                    For I = 0 To dt.Rows.Count - 1
                        .Add()
                        .Item(I).Item("Cliente") = dt.Rows.Item(I).Item("Cliente").ToString
                        .Item(I).Item("Telefone") = dt.Rows.Item(I).Item("Telefone").ToString
                        .Item(I).Item("Nascimento") = dt.Rows.Item(I).Item("Nascimento").ToString
                        .Item(I).Item("Data") = dt.Rows.Item(I).Item("Data").ToString
                        .Item(I).Item("Placa") = dt.Rows.Item(I).Item("Placa").ToString
                        .Item(I).Item("Produto") = dt.Rows.Item(I).Item("Produto").ToString
                        .Item(I).Item("TipoProduto") = dt.Rows.Item(I).Item("TipoProduto").ToString
                        .Item(I).Item("Qtd") = dt.Rows.Item(I).Item("Qtd").ToString

                        .Item(I).Item("Cadastro") = dt.Rows.Item(I).Item("Cadastro").ToString
                        .Item(I).Item("Ordem") = dt.Rows.Item(I).Item("Ordem").ToString
                        .Item(I).Item("ValorUnitario") = dt.Rows.Item(I).Item("ValorUnitario").ToString
                        .Item(I).Item("ValorTotal") = dt.Rows.Item(I).Item("ValorTotal").ToString
                        .Item(I).Item("CPF") = dt.Rows.Item(I).Item("CPF").ToString
                        .Item(I).Item("Endereco") = dt.Rows.Item(I).Item("Endereco").ToString & ", " & dt.Rows.Item(I).Item("Numero").ToString
                        .Item(I).Item("Cep") = dt.Rows.Item(I).Item("Cep").ToString
                    Next
                    rel.ExportToXls("C:\NANO\Consultoria\" & strDataAtual & ".xls")
                End With
            End If


            Dim zipPath As String = "C:\NANO\Consultoria\ArquivoConsultoria.zip"

            If IO.File.Exists(zipPath) = True Then
                IO.File.Delete(zipPath)
            End If

            Dim zip As Package = ZipPackage.Open(zipPath, IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite)
            AddToArchive(zip, "C:\NANO\Consultoria\" & strDataAtual & ".xls")

            zip.Close()

            Dim strServidor As String = ""
            Dim strEmail As String = ""
            Dim strSenha As String = ""
            Dim strPorta As String = ""
            Dim strServico As String = ""
            Dim dtServ As DataTable = CarregarDataTable("SELECT Servidor, Email, Senha, Porta, Servico FROM Email")

            If dtServ.Rows.Count > 0 Then
                strServidor = dtServ.Rows.Item(0).Item("Servidor").ToString
                strEmail = dtServ.Rows.Item(0).Item("Email").ToString
                strSenha = dtServ.Rows.Item(0).Item("Senha").ToString
                strPorta = dtServ.Rows.Item(0).Item("Porta").ToString
                strServico = dtServ.Rows.Item(0).Item("Servico").ToString
                If strServidor = "Servidor" Then
                    Exit Sub
                End If
            End If

            Dim strTexto As String
            Dim vet As Array = Nothing
            Dim relMail As New relMail
            Dim strTeste As String = "{\rtf1\ansi\ansicpg1252\deff0\deflang1046{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}" & _
            "\viewkind4\uc1\pard\f0\fs17 Arquivo Consultoria\par" & _
            "}"

            Dim strChar As String
            For I = 0 To strTeste.Length
                strChar = strTeste.Substring(strTeste.Length - 1)
                strTeste = strTeste.Substring(0, strTeste.Length - 1)
                If strChar = "}" Then
                    Exit For
                End If
            Next

            strTeste = strTeste & " \par" & vbCrLf & "\par" & vbCrLf & "\par" & vbCrLf & "\par" & vbCrLf
            strTeste = strTeste & "Nome do Computador: " & My.Computer.Name & " \par" & vbCrLf
            strTeste = strTeste & "_______________________________________________________________________________________________________________ \par" & vbCrLf
            strTeste = strTeste & " \par" & vbCrLf
            strTeste = strTeste & NomeEmpresa & " \par" & vbCrLf
            strTeste = strTeste & TelefoneEmpresa & " \par" & vbCrLf
            strTeste = strTeste & EnderecoEmpresa & " \par" & vbCrLf
            strTeste = strTeste & " \par" & vbCrLf & "\par" & vbCrLf & "\par" & vbCrLf & "." & vbCrLf & "}"

            relMail.rtMail.Rtf = strTeste

            relMail.ExportToHtml("C:/NANO/Consultoria/MailConsultoria.html")
            strTexto = LerArquivoMail("C:/NANO/Consultoria/MailConsultoria.html")


            Dim vetAnexo(15) As String
            vetAnexo(0) = "C:\NANO\Consultoria\ArquivoConsultoria.zip"

            If enviaMensagemEmail(strEmail, strSenha, EmailConsultoria, "", "", "Consultoria " & Date.Today, strTexto, strServidor, "Normal", False, "ARQUIVO", strPorta, strServico, vetAnexo) = True Then

            End If
            Try
                For I = 0 To vetAnexo.Length - 1
                    Dim strArquivo As String = vetAnexo(I)
                    If strArquivo <> "" Then
                        File.Delete("C:\NANO\Consultoria\ArquivoConsultoria.zip")
                    End If

                Next
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try

        mThreadConsultoria.Abort()
    End Sub
    Public Sub IniciaThreadNFe()
        mThreadNfe = New Threading.Thread(AddressOf VerificaNFe)
        mThreadNfe.Start()
    End Sub
    Private Sub VerificaNFe()
        Dim I As Integer


        Try
            If IO.Directory.Exists(PastaNotaNfe) = False Then MsgBox("Pasta Sat não localizada!", MsgBoxStyle.Information) : Exit Sub

            Dim strComboMes As String = Format(CInt(Date.Today.AddMonths(-1).Month), "00")
            Dim strComboAno As String = Format(Date.Today, "yy")
            If strComboMes = "12" Then
                strComboAno = Format(Date.Today.AddYears(-1), "yy")
            End If

            If IO.File.Exists(PastaNotaNfe.Replace("Remessas", "") & strComboMes & "-" & strComboAno & ".txt") = True Then Exit Sub


            Dim strPastaAutorizadas As String = PastaNotaNfe.Replace("Remessas", "Autorizadas")
            Dim strPastaAutorizadasCanc As String = PastaNotaNfe.Replace("Remessas", "Autorizadas\Cancelamento")


            Dim strDestino As String = PastaNotaNfe.Replace("Remessas", "ArquivosContador")
            If IO.Directory.Exists(strDestino) = True Then
                IO.Directory.Delete(strDestino)
            Else
                IO.Directory.CreateDirectory(strDestino)
            End If

            Dim zipPath As String = PastaNotaNfe.Replace("Remessas", "") & "\ArquivosNFe.zip"

            If IO.File.Exists(zipPath) = True Then
                IO.File.Delete(zipPath)
            End If

            Dim zip As Package = ZipPackage.Open(zipPath, IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite)

            Dim bolOk As Boolean = False




            If IO.Directory.Exists(strPastaAutorizadas) = True Then

                Dim vetLista As Array = Directory.GetFiles(strPastaAutorizadas, "*.xml")

                For I = 0 To vetLista.Length - 1
                    Dim strArquivo As String = vetLista(I)
                    Dim strChave As String = strArquivo.Replace(strPastaAutorizadas & "\", "")
                    '35160714566555000100550010000008961000000604
                    'CFe35160561099008000141599000022500003801357661
                    Dim strAno As String = strChave.Substring(2, 2)
                    Dim strMes As String = strChave.Substring(4, 2)


                    If strComboMes = strMes And strComboAno = strAno Then
                        bolOk = True
                        File.Copy(strArquivo, strArquivo.Replace(strPastaAutorizadas, strDestino))
                        AddToArchive(zip, strArquivo.Replace(strPastaAutorizadas, strDestino))
                    End If


                Next
            End If

            If IO.Directory.Exists(strPastaAutorizadasCanc) = True Then

                Dim vetLista As Array = Directory.GetFiles(strPastaAutorizadasCanc, "*.xml")



                For I = 0 To vetLista.Length - 1
                    Dim strArquivo As String = vetLista(I)
                    Dim strChave As String = strArquivo.Replace(strPastaAutorizadasCanc & "\", "")

                    Dim strAno As String = strChave.Substring(2, 2)
                    Dim strMes As String = strChave.Substring(4, 2)


                    If strComboMes = strMes And strComboAno = strAno Then
                        bolOk = True
                        File.Copy(strArquivo, strArquivo.Replace(strPastaAutorizadasCanc, strDestino))
                        AddToArchive(zip, strArquivo.Replace(strPastaAutorizadasCanc, strDestino))
                    End If


                Next
            End If


            IO.Directory.Delete(strDestino, True)
            zip.Close()

            If bolOk = False Then
                Try
                    File.Delete(PastaNotaNfe.Replace("Remessas", "") & "\ArquivosNFe.zip")
                Catch ex As Exception

                End Try
                Exit Sub
            End If

            Dim vetListaSAT As Array = Directory.GetFiles(PastaNotaNfe.Replace("Remessas", ""), "*.zip")
            If vetListaSAT.Length > 0 Then
                Dim strServidor As String = ""
                Dim strEmail As String = ""
                Dim strSenha As String = ""
                Dim strPorta As String = ""
                Dim strServico As String = ""
                Dim dtServ As DataTable = CarregarDataTable("SELECT Servidor, Email, Senha, Porta, Servico FROM Email")

                If dtServ.Rows.Count > 0 Then
                    strServidor = dtServ.Rows.Item(0).Item("Servidor").ToString
                    strEmail = dtServ.Rows.Item(0).Item("Email").ToString
                    strSenha = dtServ.Rows.Item(0).Item("Senha").ToString
                    strPorta = dtServ.Rows.Item(0).Item("Porta").ToString
                    strServico = dtServ.Rows.Item(0).Item("Servico").ToString
                    If strServidor = "Servidor" Then
                        Exit Sub
                    End If

                End If



                Dim strTexto As String
                Dim vet As Array = Nothing
                Dim rel As New relMail
                Dim strTeste As String = "{\rtf1\ansi\ansicpg1252\deff0\deflang1046{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}" & _
                "\viewkind4\uc1\pard\f0\fs17 Arquivos SAT\par" & _
                "}"

                Dim strChar As String

                For I = 0 To strTeste.Length
                    strChar = strTeste.Substring(strTeste.Length - 1)
                    strTeste = strTeste.Substring(0, strTeste.Length - 1)

                    If strChar = "}" Then
                        Exit For
                    End If
                Next

                strTeste = strTeste & " \par" & vbCrLf & "\par" & vbCrLf & "\par" & vbCrLf & "\par" & vbCrLf
                strTeste = strTeste & "Nome do Computador: " & My.Computer.Name & " \par" & vbCrLf
                strTeste = strTeste & "_______________________________________________________________________________________________________________ \par" & vbCrLf
                strTeste = strTeste & " \par" & vbCrLf
                strTeste = strTeste & NomeEmpresa & " \par" & vbCrLf
                strTeste = strTeste & TelefoneEmpresa & " \par" & vbCrLf
                strTeste = strTeste & EnderecoEmpresa & " \par" & vbCrLf

                strTeste = strTeste & " \par" & vbCrLf & "\par" & vbCrLf & "\par" & vbCrLf & "." & vbCrLf & "}"

                rel.rtMail.Rtf = strTeste

                If IO.Directory.Exists("C:/NANO") = False Then
                    IO.Directory.CreateDirectory("C:/NANO")
                End If

                rel.ExportToHtml("C:/NANO/MailSAT.html")
                strTexto = LerArquivoMail("C:/NANO/MailSAT.html")


                Dim vetAnexo(15) As String



                For I = 0 To vetListaSAT.Length - 1
                    If I <= 15 Then
                        Dim strArquivo As String = vetListaSAT(I)
                        vetAnexo(I) = strArquivo
                    End If

                Next

                If enviaMensagemEmail(strEmail, strSenha, EmailArquivo, "", "", "NF-e " & strComboMes & "-" & strComboAno, strTexto, strServidor, "Normal", False, "ARQUIVO", strPorta, strServico, vetAnexo) = True Then
                    IO.File.Create(PastaNotaNfe.Replace("Remessas", "") & strComboMes & "-" & strComboAno & ".txt")

                End If
                Try
                    For I = 0 To vetAnexo.Length - 1
                        Dim strArquivo As String = vetAnexo(I)
                        If strArquivo <> "" Then
                            File.Delete(strArquivo)
                        End If

                    Next
                Catch ex As Exception

                End Try

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

        mThreadNfe.Abort()
    End Sub
    Public Sub IniciaThreadSAT()
        mThreadSAT = New Threading.Thread(AddressOf VerificarSat)
        mThreadSAT.Start()
    End Sub

    Private Sub VerificarSat()

        Dim I As Integer


        Try
            If IO.Directory.Exists(CaminhoPastaSAT) = False Then MsgBox("Pasta Sat não localizada!", MsgBoxStyle.Information) : Exit Sub

            Dim strComboMes As String = Format(CInt(Date.Today.AddMonths(-1).Month), "00")
            Dim strComboAno As String = Format(Date.Today, "yy")
            If strComboMes = "12" Then
                strComboAno = Format(Date.Today.AddYears(-1), "yy")
            End If

            If IO.File.Exists(CaminhoPastaSAT.Replace("Remessas", "") & strComboMes & "-" & strComboAno & ".txt") = True Then Exit Sub


            Dim PastaAutorizadas As String = CaminhoPastaSAT.Replace("Remessas", "Autorizadas")
            Dim PastaAutorizadasCanc As String = CaminhoPastaSAT.Replace("Remessas", "Autorizadas\Cancelamento")


            Dim strDestino As String = CaminhoPastaSAT.Replace("Remessas", "ArquivosContador")
            If IO.Directory.Exists(strDestino) = True Then
                IO.Directory.Delete(strDestino)
            Else
                IO.Directory.CreateDirectory(strDestino)
            End If

            Dim zipPath As String = CaminhoPastaSAT.Replace("Remessas", "") & "\ArquivosNFe.zip"

            If IO.File.Exists(zipPath) = True Then
                IO.File.Delete(zipPath)
            End If

            Dim zip As Package = ZipPackage.Open(zipPath, IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite)

            Dim bolOk As Boolean = False




            If IO.Directory.Exists(PastaAutorizadas) = True Then

                Dim vetLista As Array = Directory.GetFiles(PastaAutorizadas, "*.xml")

                For I = 0 To vetLista.Length - 1
                    Dim strArquivo As String = vetLista(I)
                    Dim strChave As String = strArquivo.Replace(PastaAutorizadas & "\CFe", "")
                    '35160714566555000100550010000008961000000604
                    'CFe35160561099008000141599000022500003801357661
                    Dim strAno As String = strChave.Substring(2, 2)
                    Dim strMes As String = strChave.Substring(4, 2)


                    If strComboMes = strMes And strComboAno = strAno Then
                        bolOk = True
                        File.Copy(strArquivo, strArquivo.Replace(PastaAutorizadas, strDestino))
                        AddToArchive(zip, strArquivo.Replace(PastaAutorizadas, strDestino))
                    End If


                Next
            End If

            If IO.Directory.Exists(PastaAutorizadasCanc) = True Then

                Dim vetLista As Array = Directory.GetFiles(PastaAutorizadasCanc, "*.xml")



                For I = 0 To vetLista.Length - 1
                    Dim strArquivo As String = vetLista(I)
                    Dim strChave As String = strArquivo.Replace(PastaAutorizadasCanc & "\CFeCanc", "")

                    Dim strAno As String = strChave.Substring(2, 2)
                    Dim strMes As String = strChave.Substring(4, 2)


                    If strComboMes = strMes And strComboAno = strAno Then
                        bolOk = True
                        File.Copy(strArquivo, strArquivo.Replace(PastaAutorizadasCanc, strDestino))
                        AddToArchive(zip, strArquivo.Replace(PastaAutorizadasCanc, strDestino))
                    End If


                Next
            End If


            IO.Directory.Delete(strDestino, True)
            zip.Close()

            If bolOk = False Then
                Try
                    File.Delete(CaminhoPastaSAT.Replace("Remessas", "") & "\ArquivosNFe.zip")
                Catch ex As Exception

                End Try
                Exit Sub
            End If

            Dim vetListaSAT As Array = Directory.GetFiles(CaminhoPastaSAT.Replace("Remessas", ""), "*.zip")
            If vetListaSAT.Length > 0 Then
                Dim strServidor As String = ""
                Dim strEmail As String = ""
                Dim strSenha As String = ""
                Dim strPorta As String = ""
                Dim strServico As String = ""
                Dim dtServ As DataTable = CarregarDataTable("SELECT Servidor, Email, Senha, Porta, Servico FROM Email")

                If dtServ.Rows.Count > 0 Then
                    strServidor = dtServ.Rows.Item(0).Item("Servidor").ToString
                    strEmail = dtServ.Rows.Item(0).Item("Email").ToString
                    strSenha = dtServ.Rows.Item(0).Item("Senha").ToString
                    strPorta = dtServ.Rows.Item(0).Item("Porta").ToString
                    strServico = dtServ.Rows.Item(0).Item("Servico").ToString
                    If strServidor = "Servidor" Then
                        Exit Sub
                    End If

                End If



                Dim strTexto As String
                Dim vet As Array = Nothing
                Dim rel As New relMail
                Dim strTeste As String = "{\rtf1\ansi\ansicpg1252\deff0\deflang1046{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}" & _
                "\viewkind4\uc1\pard\f0\fs17 Arquivos SAT\par" & _
                "}"

                Dim strChar As String

                For I = 0 To strTeste.Length
                    strChar = strTeste.Substring(strTeste.Length - 1)
                    strTeste = strTeste.Substring(0, strTeste.Length - 1)

                    If strChar = "}" Then
                        Exit For
                    End If
                Next

                strTeste = strTeste & " \par" & vbCrLf & "\par" & vbCrLf & "\par" & vbCrLf & "\par" & vbCrLf
                strTeste = strTeste & "Nome do Computador: " & My.Computer.Name & " \par" & vbCrLf
                strTeste = strTeste & "_______________________________________________________________________________________________________________ \par" & vbCrLf
                strTeste = strTeste & " \par" & vbCrLf
                strTeste = strTeste & NomeEmpresa & " \par" & vbCrLf
                strTeste = strTeste & TelefoneEmpresa & " \par" & vbCrLf
                strTeste = strTeste & EnderecoEmpresa & " \par" & vbCrLf

                strTeste = strTeste & " \par" & vbCrLf & "\par" & vbCrLf & "\par" & vbCrLf & "." & vbCrLf & "}"

                rel.rtMail.Rtf = strTeste

                If IO.Directory.Exists("C:/NANO") = False Then
                    IO.Directory.CreateDirectory("C:/NANO")
                End If

                rel.ExportToHtml("C:/NANO/MailSAT.html")
                strTexto = LerArquivoMail("C:/NANO/MailSAT.html")


                Dim vetAnexo(15) As String



                For I = 0 To vetListaSAT.Length - 1
                    If I <= 15 Then
                        Dim strArquivo As String = vetListaSAT(I)
                        vetAnexo(I) = strArquivo
                    End If

                Next

                If enviaMensagemEmail(strEmail, strSenha, EmailArquivo, "", "", "SAT " & strComboMes & "-" & strComboAno, strTexto, strServidor, "Normal", False, "ARQUIVO", strPorta, strServico, vetAnexo) = True Then
                    IO.File.Create(CaminhoPastaSAT.Replace("Remessas", "") & strComboMes & "-" & strComboAno & ".txt")

                End If
                Try
                    For I = 0 To vetAnexo.Length - 1
                        Dim strArquivo As String = vetAnexo(I)
                        If strArquivo <> "" Then
                            File.Delete(strArquivo)
                        End If

                    Next
                Catch ex As Exception

                End Try

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

        mThreadSAT.Abort()

    End Sub
    Private Sub AddToArchive(ByVal zip As Package, _
                     ByVal fileToAdd As String)

        'Replace spaces with an underscore (_) 
        Dim uriFileName As String = fileToAdd.Replace(" ", "_")

        'A Uri always starts with a forward slash "/" 
        Dim zipUri As String = String.Concat("/", _
                   IO.Path.GetFileName(uriFileName))

        Dim partUri As New Uri(zipUri, UriKind.Relative)
        Dim contentType As String = _
                   Net.Mime.MediaTypeNames.Application.Zip

        'The PackagePart contains the information: 
        ' Where to extract the file when it's extracted (partUri) 
        ' The type of content stream (MIME type):  (contentType) 
        ' The type of compression:  (CompressionOption.Normal)   
        Dim pkgPart As PackagePart = zip.CreatePart(partUri, _
                   contentType, CompressionOption.Normal)

        'Read all of the bytes from the file to add to the zip file 
        Dim bites As Byte() = File.ReadAllBytes(fileToAdd)

        'Compress and write the bytes to the zip file 
        pkgPart.GetStream().Write(bites, 0, bites.Length)

    End Sub

    Private Sub btnEmailArquivo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEmailArquivo.ItemClick
        frmEmailArquivo.ShowDialog()
    End Sub

    Private mThreadImp As Thread
    Public Sub IniciaThreadImp()
        mThreadImp = New Threading.Thread(AddressOf ImpApp)
        mThreadImp.Start()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Dim NomePC As String = System.Windows.Forms.SystemInformation.ComputerName.ToString.ToUpper.Trim()
        Dim NomePCImp As String = NomePCImpressora.ToUpper.Replace("\", "")

        If NomePCImp = NomePC Then
            IniciaThreadImp()
        End If
    End Sub

    Private Sub btnInativarProduto_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInativarProduto.ItemClick
        frmInativarProduto.Show()
    End Sub

    Private Sub btnCampAndamento_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCampAndamento.ItemClick
        frmCampanha.Tag = "ANDAMENTO"
        frmCampanha.Show()
    End Sub

    Private Sub BarButtonItem23_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        If MsgBox("Deseja atualizar custo pelo log?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim I As Integer

            Dim dtEnt As DataTable = CarregarDataTable("select novo FROM Log where Codigo >=19135 and  Tabela = 'PRODUTO' and Coluna = 'VALOR CUSTO' and novo like '% Cód. Prod.%'")
            Dim A As Integer
            For A = 0 To dtEnt.Rows.Count - 1
                Dim strNovo As String = dtEnt.Rows.Item(A).Item("Novo").ToString
                Dim vetNovo As Array = Split(strNovo, " Cód. Prod.:")

                Dim strCodProd As String = vetNovo(1)
                Dim dtProd As DataTable = CarregarDataTable("SELECT Codigo, Produto.Valor " & _
                "FROM Produto where CodigoInterno = '" & strCodProd & "'")

                Dim dblValCusto As Double = vetNovo(0)
                Dim dblValor As Double = dtProd.Rows.Item(0).Item("Valor").ToString
                Dim strCodigo As String = dtProd.Rows.Item(0).Item("Codigo").ToString
                'Dim dblValorCusto As Double = dtEnt.Rows.Item(A).Item("ValorCusto").ToString
                'Dim dblQtd As Double = dtEnt.Rows.Item(A).Item("Qtd").ToString

                'Dim strVal As String
                'Dim dblResul As Double = dblValorCusto / dblQtd

                'Dim strResultado As String = dblResul.ToString("0.00")

                ' If strResultado.Contains("+Infinito") = False Or strResultado.Contains("NaN") = False Then
                ' strVal = strResultado

                Dim dblValVenda, dblLucro, dblMargem As Double

                dblLucro = dblValor - dblValCusto

                dblMargem = (dblLucro * 100) / dblValCusto

                Dim str As String = dblMargem
                Dim strPor As String = "0"
                If str <> "+Infinito" And str <> "NaN (Não é um número)" Then
                    If TresCasasDecimais = True Then
                        strPor = dblMargem.ToString("0.000")
                    Else
                        strPor = dblMargem.ToString("0.00")
                    End If

                End If

                Atualizar("Update Produto set ValorCusto =" & Num(dblValCusto) & ", Porcentagens = '" & strPor & "' where Codigo =" & strCodigo)
                Atualizar("Update Qtde set ValorCusto =" & Num(dblValCusto) & " where CodProd =" & strCodigo)


                'Dim dtPed As DataTable = CarregarDataTable("SELECT Pedido.Codigo, Qtd FROM Pedido left join Total " & _
                '"on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig where CodProd = " & strCodProd & " and " & strData)

                'For I = 0 To dtPed.Rows.Count - 1
                '    Dim strCodigo As String = dtPed.Rows.Item(I).Item("Codigo").ToString
                '    Dim dblQtdPed As Double = dtPed.Rows.Item(I).Item("Qtd").ToString

                '    Dim dblValCustoPed As Double = dblQtdPed * strVal

                '    Atualizar("UPDATE Pedido set Custo = " & Num(dblValCustoPed) & " where Codigo = " & strCodigo)
                'Next

                'End If

            Next

            'strData = String.Format("T.Data >= '{0:dd/MM/yyyy}' AND T.Data <= '{1:dd/MM/yyyy}'", Date.Today.AddMonths(-3), Date.Today.AddDays(1))

            'Atualizar("Update T set T.Custo = (SELECT sum(P.Custo) FROM Pedido P where P.CodOrdem = T.CodOrdem and P.CodConfig = T.CodConfig) FROM Total T where " & strData)

            MsgBox("OK", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub BarButtonItem28_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem28.ItemClick

        If MsgBox("Juntar Estoque 1 e 2?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim dtProd As DataTable = CarregarDataTable("SET DATEFORMAT dmy SELECT Produto.Codigo, (SELECT case when sum(EntradaNf.QtdProd) is null then 0 else sum(EntradaNf.QtdProd) end FROM EntradaNf left join TotalEntradaNf on EntradaNf.CodTotNf = TotalEntradaNf.Codigo where EntradaNf.CodProd = Produto. Codigo and EstoqueOk = 'True' and EntradaNf.CodConfig = 2) - (SELECT case when sum(Pedido.Qtd) is null then 0 else sum(Pedido.Qtd) end FROM Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and PEdido.CodConfig = Total.CodConfig where Pedido.CodConfig = 2 and Pedido.CodProd = Produto.Codigo and Pedido.Devolvido = 'False') + (SELECT case when sum(AjusteQtde.Qtd) is null then 0 else  sum(AjusteQtde.Qtd) end FROM AjusteQtde where AjusteQtde.CodConfig = 2 and AjusteQtde.CodProd = Produto.Codigo) as Qtd FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where Produto.Inativo = 'False' and (SELECT case when sum(EntradaNf.QtdProd) is null then 0 else sum(EntradaNf.QtdProd) end FROM EntradaNf left join TotalEntradaNf on EntradaNf.CodTotNf = TotalEntradaNf.Codigo where EntradaNf.CodProd = Produto. Codigo and EstoqueOk = 'True' and EntradaNf.CodConfig = 2) - (SELECT case when sum(Pedido.Qtd) is null then 0 else sum(Pedido.Qtd) end FROM Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and PEdido.CodConfig = Total.CodConfig where Pedido.CodConfig = 2 and Pedido.CodProd = Produto.Codigo and Pedido.Devolvido = 'False') + (SELECT case when sum(AjusteQtde.Qtd) is null then 0 else  sum(AjusteQtde.Qtd) end FROM AjusteQtde where AjusteQtde.CodConfig = 2 and AjusteQtde.CodProd = Produto.Codigo)>0 group by Produto.Codigo")

            Dim I As Integer
            Dim A As Integer
            For I = 0 To dtProd.Rows.Count - 1

                Dim strCod As String = dtProd.Rows.Item(I).Item("Codigo").ToString


                Dim dblQtd1 As Double = 0
                Dim dblQtd2 As Double = 0


                dblQtd1 = AjusteQtde(1, strCod)
                dblQtd2 = AjusteQtde(2, strCod)



                If dblQtd1 >= 0 Then
                    If dblQtd2 > 0 Then
                        Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data, CodUser) VALUES (" & _
                        "" & strCod & "," & Num(dblQtd2) & ",1,'MIGRAÇÃO','" & My.Computer.Clock.LocalTime & "'," & CodUser & ")")
                    End If
                Else
                    If dblQtd2 > 0 Then
                        dblQtd1 = -dblQtd1
                        Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data, CodUser) VALUES (" & _
                                     "" & strCod & "," & Num(dblQtd1) & ",1,'MIGRAÇÃO','" & My.Computer.Clock.LocalTime & "'," & CodUser & ")")
                        Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data, CodUser) VALUES (" & _
                           "" & strCod & "," & Num(dblQtd2) & ",1,'MIGRAÇÃO','" & My.Computer.Clock.LocalTime & "'," & CodUser & ")")
                    End If
                End If
            Next
        End If


    End Sub

    Private Sub BarButtonItem29_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem29.ItemClick
        If MsgBox("Deseja realmente inativar clientes que não compram a 6 meses?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub



        Dim dtProd As DataTable = CarregarDataTable("SELECT Codigo,Data FROM Cliente where Inativo = 'False'")
        Dim A As Integer
        Dim strCodCli As String = ""
        For A = 0 To dtProd.Rows.Count - 1
            Dim strCodProd As String = dtProd.Rows.Item(A).Item("Codigo").ToString
            Dim dtData As Date = Date.Today

            If dtProd.Rows.Item(A).Item("Data").ToString <> "" Then
                dtData = dtProd.Rows.Item(A).Item("Data").ToString

            End If

            Dim dtTotal As DataTable = CarregarDataTable("SELECT Max(Data) as Data FROM Total  where CodCli = " & strCodProd)
            Dim bolInativar As Boolean = False
            If dtTotal.Rows.Count > 0 Then
                If dtTotal.Rows.Item(0).Item("Data").ToString <> "" Then
                    Dim dtDataTotal As Date = dtTotal.Rows.Item(0).Item("Data").ToString
                    If dtDataTotal < Date.Today.AddMonths(-6) Then
                        bolInativar = True
                    End If
                Else
                    If dtData < Date.Today.AddMonths(-6) Then
                        bolInativar = True
                    End If
                End If

            Else
                If dtData < Date.Today.AddMonths(-6) Then
                    bolInativar = True
                End If
            End If
            If bolInativar = True Then
                strCodCli &= strCodProd & " , " & vbCrLf
                Atualizar("UPDATE Cliente set Inativo = 'True' where Codigo = " & strCodProd)
            End If
        Next
        If strCodCli <> "" Then
            Dim fluxoTexto As IO.StreamWriter
            If Not System.IO.File.Exists(My.Application.Info.DirectoryPath & "\ClientesInativo" & Date.Today.Day & Date.Today.Month & Date.Today.Year & ".txt") Then
                System.IO.File.Create(My.Application.Info.DirectoryPath & "\ClientesInativo" & Date.Today.Day & Date.Today.Month & Date.Today.Year & ".txt").Dispose()

                fluxoTexto = New IO.StreamWriter(My.Application.Info.DirectoryPath & "\ClientesInativo" & Date.Today.Day & Date.Today.Month & Date.Today.Year & ".txt")
                fluxoTexto.Write("")
                fluxoTexto.Write(strCodCli)
                fluxoTexto.Close()
            End If
        End If

        MsgBox("OK", MsgBoxStyle.Information)
    End Sub

    Private Sub btnTeamViewer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTeamViewer.ItemClick
        Dim frm As New frmCadComp
        frm.ShowDialog()
    End Sub

    Private Sub cboStatus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboStatus.Click
        If bolStatusPedido = True Then
            CarregarStatusPedido()
        End If
    End Sub

    Private Sub cboStatus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboStatus.KeyPress
        If e.KeyChar = "'" Or e.KeyChar = "&" Then
            e.Handled = True
        End If

        If Char.IsNumber(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
        If Char.IsLetter(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub cboStatus_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboStatus.SelectedValueChanged
        Try
            Dim CodPed As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCod).Trim()
            Dim Status As String = ""

            Dim cboStatus1 As ComboBoxEdit = CType(sender, ComboBoxEdit)
            Status = cboStatus1.EditValue.ToString

            Atualizar("Update TotalConsig set StatusPedido = '" & Status.Trim & "' Where CodOrdens = " & CodPed)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AtualizarGridTodos()
        If TipoNano = 3 Then
            CarregarDadosPedidoMDI("Select CodOrdens as Cod, Funcionario.Nome as Vendedor, Cliente.Nome as Cliente, " & _
            "TotalConsig.Data, TotalConsig.Descricao, Convert(Numeric(15,2),TotalConsig.Total) as Total, " & _
            "TotalConsig.Status, TotalConsig.StatusPedido, Animal.Nome as Animal, TotalConsig.Comanda, DataRetirada, DataEntrega From ((TotalConsig left join Cliente on " & _
            "TotalConsig.CodCli = Cliente.Codigo)left join Funcionario on " & _
             "TotalConsig.CodFunc = Funcionario.Codigo) left join Animal on TotalConsig.CodAnimal = Animal.Codigo Where TotalConsig.Status <> 'Excluído' and TotalConsig.CodConfig = " & CodConfig, Me.TotalGridControl)

        Else
            CarregarDadosPedidoMDI("Select CodOrdens as Cod, Funcionario.Nome as Vendedor, Cliente.Nome as Cliente, " & _
            "TotalConsig.Data, TotalConsig.Descricao, Convert(Numeric(15,2),TotalConsig.Total) as Total, " & _
            "TotalConsig.Status, TotalConsig.StatusPedido, TotalConsig.Comanda, DataRetirada, DataEntrega, " & _
            "TotalConsig.Placa, TotalConsig.Modelo + ' ' + Cor as Modelo , TotalConsig.Custo as ValorCusto, " & _
            "Total.CodOrdem as Venda, TotalConsig.KMEntrada From ((TotalConsig left join Cliente on TotalConsig.CodCli = Cliente.Codigo)left join Funcionario on " & _
            "TotalConsig.CodFunc = Funcionario.Codigo) left join Total on Total.CodPedido=TotalConsig.CodOrdens " & _
            "And TotalConsig.CodConfig=Total.CodConfig Where TotalConsig.Status <> 'Excluído' and " & _
            "TotalConsig.CodConfig = " & CodConfig, Me.TotalGridControl)

            Me.colVenda.Visible = True
            Me.colVenda.VisibleIndex = 1
        End If
    End Sub

    Private Sub btnCarregarT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregarT.Click
        AtualizarGridTodos()
    End Sub

    Private Sub btnSomadoDRE_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSomadoDRE.ItemClick
        Dim frm As New frmRelDRE
        frm.Tag = "SOMADO"
        frm.Show()
    End Sub

    Private Sub btnDetalhadoDRE_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDetalhadoDRE.ItemClick
        Dim frm As New frmRelDRE
        frm.Tag = "DETALHADO"
        frm.Show()
    End Sub


    Private Sub btnCadCotacao_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCadCotacao.ItemClick
        Dim frm As New frmCotacao
        frm.Tag = "CADASTRAR"
        frm.Show()
    End Sub

    Private Sub btnAltCotacao_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAltCotacao.ItemClick
        frmCotacao.Tag = "ALTERAR"
        frmCotacao.Show()
    End Sub

    Private Sub btnConCotacao_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConCotacao.ItemClick
        frmCotacao.Tag = "CONSULTAR"
        frmCotacao.Show()
    End Sub

    Private Sub VisualizarAutomotivo()
        Dim strCod As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCod)

        If strCod.Trim = "" Then Exit Sub

        Dim rel As New relImpPedidos

        With rel


            Dim dt As DataTable = CarregarDataTable("Select Data, CodCli, convert(Numeric(15,2),Total) as Total, Descricao, Desconto, Status, Custo, " & _
            "Entrega, CodFunc, Funcionario.Nome, Acrescimo, convert(Varchar(10), DataRetirada, 103) as DataRetirada, " & _
            "Convert(varchar(10),DataEntrega,103) as DataEntrega, StatusPedido, Placa, Modelo, Cor, Ano, NivelCombustivel, Motor, KMEntrada, KMSaida from TotalConsig left join " & _
            "Funcionario on TotalConsig.CodFunc = Funcionario.Codigo where TotalConsig.CodOrdens = " & strCod.Trim & " and TotalConsig.CodConfig =" & CodConfig)

            Dim strCodCli As String = dt.Rows.Item(0).Item("CodCli").ToString
            If strCodCli.Trim = Nothing Then Exit Sub
            Dim dtCli As DataTable = CarregarDataTable("Select Nome, Telefone, Fax, Email, Observacao, Desconto from Cliente Where Codigo =" & strCodCli)

            Dim strCliente, strTelefone, strFax, strEmail As String
            If dtCli.Rows.Count > 0 Then
                strCliente = dtCli.Rows.Item(0).ItemArray(0).ToString
                strTelefone = dtCli.Rows.Item(0).ItemArray(1).ToString
                strFax = dtCli.Rows.Item(0).ItemArray(2).ToString
                strEmail = dtCli.Rows.Item(0).ItemArray(3).ToString
            End If
            If AutorizacaoPedido = False Then
                .lblAut.Visible = False
                .linha7.Visible = False
                .lblAssi.Visible = False
            Else
                .lblAssi.Text = strCliente
            End If

            If NomeEmpresa.Contains("MD NEGRO") Then
                .XrPanel1.BorderColor = Color.White
                .Margins.Top = 166
                .lblTitulo.Visible = False
                .lblFones.Visible = False
                .lblEndereco.Visible = False
                .picLogo.Visible = False
            End If

            .lblAtendente.Text = UserNano
            .Name = "Pedido N° " & strCod
            .lblTitulo.Text = NomeEmpresa
            .lblFones.Text = TelefoneEmpresa
            .lblEndereco.Text = EnderecoEmpresa
            .Nome.Text = strCliente
            .Telefone.Text = strTelefone
            .Fax.Text = strFax
            .Email.Text = strEmail

            .Placa.Text = dt.Rows.Item(0).Item("Placa").ToString
            .Modelo.Text = dt.Rows.Item(0).Item("Modelo").ToString
            .Cor.Text = dt.Rows.Item(0).Item("Cor").ToString
            .Ano.Text = dt.Rows.Item(0).Item("Ano").ToString
            .KM.Text = dt.Rows.Item(0).Item("KMEntrada").ToString
            .lblPrisma.Text = dt.Rows.Item(0).Item("Motor").ToString
            Dim strPlaca As String = dt.Rows.Item(0).Item("Placa").ToString
            Dim dtCar As DataTable = CarregarDataTable("Select Chassi, Motor, Combustivel from Carro where Placa = '" & strPlaca & "'")
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


            Dim dblPec, dblServ, dblResut, dblValSemDesc, dblQtd, dblTotal As Double





            Dim dtSta As DataTable = CarregarDataTable("Select Status from TotalConsig where CodOrdens ='" & strCod & "' and CodConfig = " & CodConfig)
            Dim strStatus As String = "Pendente"
            If dtSta.Rows.Count > 0 Then
                strStatus = dtSta.Rows.Item(0).Item("Status").ToString
            End If

            Select Case strStatus
                Case "Orçamento", ""
                    .lblPedido.Text = "Orçamento Nº: " & strCod

                Case "Pendente"
                    .lblPedido.Text = "Orçamento Nº: " & strCod

                Case "Faturado"
                    .lblPedido.Text = "O.S. Nº: " & strCod

            End Select

            If NomeEmpresa.Contains("DAKAR") = True Then
                .lblPedido.Text = "Ordem de Serviço Nº: " & strCod
            End If

            If NomeEmpresa.Trim.Contains("PINHO") Then
                .lblNivComb.Text = "Vendedor:"
            End If

            Dim strDescricao As String = dt.Rows.Item(0).Item("Descricao").ToString
            Dim vetDesc As Array = Split(strDescricao, "|")

            If vetDesc.Length > 1 Then
                .lblDefeitos.Text = vetDesc(1)
            Else
                .GroupFooter3.Visible = False
            End If

            If NomeEmpresa.Contains("MECÂNICA SÃO PAULO") Then
                .GroupFooter3.Visible = False
            End If
            'If BloquearObsPedido = False Then
            .lblDesc.Text = vetDesc(0)
            'End If

            .lblData.Text = dt.Rows.Item(0).Item("Data").ToString
            .lblEntrada.Text = dt.Rows.Item(0).Item("DataRetirada").ToString
            .lblSaida.Text = dt.Rows.Item(0).Item("DataEntrega").ToString
            .lblNivCom.Text = dt.Rows.Item(0).Item("NivelCombustivel").ToString
            .lblKMSaida.Text = dt.Rows.Item(0).Item("KMSaida").ToString

            Dim dtPed As DataTable = CarregarDataTable("SELECT CodigoProduto, ItensConsig.CodigoInterno, Produto, ValorUnitario, ValorTotal, Qtd, Produto.Tipo, " & _
            "CodigoFuncionario, Garantia, UM, Autorizado FROM ItensConsig left join Produto on ItensConsig.CodigoProduto = Produto.Codigo where CodOrdens = " & strCod & " and CodConfig =" & CodConfig)

            Dim I As Integer
            For I = 0 To dtPed.Rows.Count - 1
                If dtPed.Rows.Item(I).Item("Autorizado") = True Then


                    If dtPed.Rows.Item(I).Item("Tipo").ToString = "SERVIÇO" Then
                        .tbServ.Rows.Add()

                        If dtPed.Rows.Item(I).Item("Garantia").ToString <> "" Then
                            .lblGar.Visible = True
                            .lblGarantias.Visible = True
                            .linha7.Visible = True
                            .lblGar.Text &= dtPed.Rows.Item(I).Item("CodigoInterno").ToString & " " & dtPed.Rows.Item(I).Item("Garantia").ToString & ", "
                        End If

                        dblServ += dtPed.Rows.Item(I).Item("ValorTotal")

                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Código") = dtPed.Rows.Item(I).Item("CodigoInterno").ToString
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Qtde") = dtPed.Rows.Item(I).Item("Qtd").ToString
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Serviços") = dtPed.Rows.Item(I).Item("Produto").ToString
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("VlUnit") = CampoValor(dtPed.Rows.Item(I).Item("ValorUnitario").ToString)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("vlTot") = dtPed.Rows.Item(I).Item("ValorTotal").ToString
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("UMSER") = dtPed.Rows.Item(I).Item("UM").ToString
                        If dtPed.Rows.Item(I).Item("CodigoFuncionario").ToString <> "" Then
                            Dim dtFuc As DataTable = CarregarDataTable("Select Nome from Funcionario where Codigo =" & dtPed.Rows.Item(I).Item("CodigoFuncionario").ToString & " and CodConfig = " & CodConfig)
                            If dtFuc.Rows.Count > 0 Then
                                .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("FUNC") = dtFuc.Rows.Item(0).Item(0).ToString
                            End If
                        Else
                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbServ.Rows.Item(Index).Item("FUNC") = grd1.GetRowCellDisplayText(I, Me.colGarantia)
                            'End If
                        End If
                    Else
                        .tbPed.Rows.Add()
                        If dtPed.Rows.Item(I).Item("Garantia").ToString <> "" Then
                            .lblGar.Visible = True
                            .lblGarantias.Visible = True
                            .linha7.Visible = True
                            .lblGar.Text &= dtPed.Rows.Item(I).Item("CodigoInterno").ToString & " " & dtPed.Rows.Item(I).Item("Garantia").ToString & ", "
                        End If

                        dblPec += dtPed.Rows.Item(I).Item("ValorTotal")

                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("CodigoPeca") = dtPed.Rows.Item(I).Item("CodigoInterno").ToString
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Qtde") = dtPed.Rows.Item(I).Item("Qtd").ToString
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Descrição") = dtPed.Rows.Item(I).Item("Produto").ToString
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("ValorUnitR") = CampoValor(dtPed.Rows.Item(I).Item("ValorUnitario").ToString)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Total") = dtPed.Rows.Item(I).Item("ValorTotal").ToString
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("UM") = dtPed.Rows.Item(I).Item("UM").ToString
                        If dtPed.Rows.Item(I).Item("CodigoFuncionario").ToString <> "" Then
                            Dim dtFuc As DataTable = CarregarDataTable("Select Nome from Funcionario where Codigo =" & dtPed.Rows.Item(I).Item("CodigoFuncionario").ToString & " and CodConfig = " & CodConfig)

                            If dtFuc.Rows.Count > 0 Then
                                .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Func") = dtFuc.Rows.Item(0).Item(0).ToString
                            End If
                        Else
                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbPed.Rows.Item(Index).Item("Modelo") = grd1.GetRowCellDisplayText(I, Me.colGarantia)
                            'End If
                        End If

                    End If
                End If
            Next
            .Pecas.Text = dblPec.ToString("0.00")
            .Sevicos.Text = dblServ.ToString("0.00")
            dblTotal = dblPec + dblServ


            .Total.Text = dblTotal.ToString("0.00")
            .subTotal.Text = dt.Rows.Item(0).Item("Total").ToString
            Dim dblDesc As Double
            If dt.Rows.Item(0).Item("Desconto").ToString <> "" Then
                Dim vetDesconto As Array = Split(dt.Rows.Item(0).Item("Desconto").ToString, "|")
                If vetDesconto(0).ToString <> "" Then
                    dblDesc = vetDesconto(0)
                End If
            End If
            .Desconto.Text = dblDesc.ToString("0.00")

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
            .ShowPreview()

        End With
    End Sub

    Private Sub ImprimirPadrao()
        Dim strCod As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCod)

        If strCod.Trim = "" Then Exit Sub
        Dim rel As New relImpPedidos2
        With rel

            Dim dt As DataTable = CarregarDataTable("Select Data, CodCli, convert(Numeric(15,2),Total) as Total, Descricao, Desconto, Status, Custo, " & _
            "Entrega, CodFunc, Funcionario.Nome, Acrescimo, convert(Varchar(10), DataRetirada, 103) as DataRetirada, " & _
            "Convert(varchar(10),DataEntrega,103) as DataEntrega, StatusPedido, Placa, Modelo, Cor, Ano, NivelCombustivel, Motor, KMEntrada, KMSaida from TotalConsig left join " & _
            "Funcionario on TotalConsig.CodFunc = Funcionario.Codigo where TotalConsig.CodOrdens = " & strCod.Trim & " and TotalConsig.CodConfig =" & CodConfig)

            Dim strCodCli As String = dt.Rows.Item(0).Item("CodCli").ToString
            If strCodCli.Trim = Nothing Then Exit Sub
            Dim dtCli As DataTable = CarregarDataTable("Select Nome, Telefone, Fax, Email, Observacao, Desconto from Cliente Where Codigo =" & strCodCli)

            Dim strCliente, strTelefone, strFax, strEmail As String
            If dtCli.Rows.Count > 0 Then
                strCliente = dtCli.Rows.Item(0).ItemArray(0).ToString
                strTelefone = dtCli.Rows.Item(0).ItemArray(1).ToString
                strFax = dtCli.Rows.Item(0).ItemArray(2).ToString
                strEmail = dtCli.Rows.Item(0).ItemArray(3).ToString
            End If

            If AutorizacaoPedido = False Then
                .lblAut.Visible = False
                .linha7.Visible = False
                .lblAssi.Visible = False
            Else
                .lblAssi.Text = strCliente
            End If

            If NomeEmpresa.Contains("MD NEGRO") Then
                '.XrPanel1.BorderColor = Color.White
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

            '.lblAtendente.Text = Me.txtUsu.Text
            .Name = "Pedido N° " & strCod
            .lblTitulo.Text = NomeEmpresa
            .lblFones.Text = TelefoneEmpresa
            .lblEndereco.Text = EnderecoEmpresa
            '.Nome.Text = strCliente
            '.Telefone.Text = strTelefone

            '.lblTel2.Text &= Me.cboTel2.Text.Trim
            '.Fax.Text = strFax
            '.Email.Text = strEmail

            '.Placa.Text = dt.Rows.Item(0).Item("Placa").ToString
            '.Modelo.Text = dt.Rows.Item(0).Item("Modelo").ToString
            '.Cor.Text = dt.Rows.Item(0).Item("Cor").ToString
            '.Ano.Text = dt.Rows.Item(0).Item("Ano").ToString
            '.KM.Text = dt.Rows.Item(0).Item("KMEntrada").ToString

            Dim strPlaca As String = dt.Rows.Item(0).Item("Placa").ToString

            'Dim dtCar As DataTable = CarregarDataTable("Select Chassi, Motor, Combustivel from Carro where Placa = '" & strPlaca & "'")
            'If dtCar.Rows.Count > 0 Then
            '    .lblChassi.Text = dtCar.Rows.Item(0).Item(0).ToString.Trim
            '    '.lblMotor.Text = dtCar.Rows.Item(0).Item(1).ToString.Trim
            '    '.lblComb.Text = dtCar.Rows.Item(0).Item(2).ToString.Trim
            'End If

            .Nome.Text = strCliente
            .Telefone.Text = strTelefone
            .Fax.Text = strFax
            .Email.Text = strEmail

            If TipoNano = 5 Then
                '.lblAtendente.Text = Me.txtUsu.Text
                '.colFunc.Visible = True
                '.colFuncionario.Visible = True
                '.colFunc.VisibleIndex = 2
                '.colFuncionario.VisibleIndex = 2
                

                .Placa.Text = dt.Rows.Item(0).Item("Placa").ToString
                .Modelo.Text = dt.Rows.Item(0).Item("Modelo").ToString
                .Cor.Text = dt.Rows.Item(0).Item("Cor").ToString
                .Ano.Text = dt.Rows.Item(0).Item("Ano").ToString
                .KM.Text = dt.Rows.Item(0).Item("KMEntrada").ToString

                '.lblPrisma.Text = Me.txtPrisma.Text.Trim

                Dim dtCar As DataTable = CarregarDataTable("Select Chassi, Motor, Combustivel from Carro where Placa = '" & strPlaca & "'")
                If dtCar.Rows.Count > 0 Then
                    .lblChassi.Text = dtCar.Rows.Item(0).Item(0).ToString.Trim
                    '.lblMotor.Text = dtCar.Rows.Item(0).Item(1).ToString.Trim
                    '.lblComb.Text = dtCar.Rows.Item(0).Item(2).ToString.Trim
                End If
                .GroupHeader2.Visible = False
            Else
                .lblNome.Text = strCliente
                .lblTelefone.Text = strTelefone
                .lblFax.Text = strFax
                .lblEmail.Text = strEmail

                .lblLabelVendedor.Visible = True
                .lblVendedor.Visible = True
                .lblVendedor.Text = dt.Rows.Item(0).Item("Nome").ToString
                .XrLabel21.Visible = False
                .lblDefeitos.Visible = False
                .GroupHeader1.Visible = False


                dtCli = CarregarDataTable("SELECT Endereco, Numero, Bairro, Cidade, Cep, Estado, EnderecoEntrega, NumeroEntrega, BairroEntrega, CidadeEntrega, CepEntrega, EstadoEntrega FROM Cliente where Codigo = " & strCodCli)
                If dtCli.Rows.Count > 0 Then
                    If dtCli.Rows.Item(0).Item("EnderecoEntrega").ToString = "" Then
                        .lblEnd.Text = dtCli.Rows.Item(0).Item("Endereco").ToString
                        .lblNum.Text = dtCli.Rows.Item(0).Item("Numero").ToString
                        .lblBairro.Text = dtCli.Rows.Item(0).Item("Bairro").ToString
                        .lblCidade.Text = dtCli.Rows.Item(0).Item("Cidade").ToString
                        .lblCep.Text = dtCli.Rows.Item(0).Item("Cep").ToString
                        .lblUF.Text = dtCli.Rows.Item(0).Item("Estado").ToString
                    Else
                        .lblEnd.Text = dtCli.Rows.Item(0).Item("EnderecoEntrega").ToString
                        .lblNum.Text = dtCli.Rows.Item(0).Item("NumeroEntrega").ToString
                        .lblBairro.Text = dtCli.Rows.Item(0).Item("BairroEntrega").ToString
                        .lblCidade.Text = dtCli.Rows.Item(0).Item("CidadeEntrega").ToString
                        .lblCep.Text = dtCli.Rows.Item(0).Item("CepEntrega").ToString
                        .lblUF.Text = dtCli.Rows.Item(0).Item("EstadoEntrega").ToString
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
            .colFunc.Visible = False
            .colFuncServ.Visible = False
            'End If



            Dim dblPec, dblServ, dblResut, dblValSemDesc, dblQtd, dblTotal As Double



            Dim dtSta As DataTable = CarregarDataTable("Select Status, StatusPedido from TotalConsig where CodOrdens = " & strCod & " and CodConfig = " & CodConfig)
            Dim strStatus As String = "Pendente"
            Dim strNossoStatus As String = ""

            If dtSta.Rows.Count > 0 Then
                strStatus = dtSta.Rows.Item(0).Item("Status").ToString
                If dtSta.Rows.Item(0).Item("StatusPedido").ToString <> "" Then
                    strNossoStatus = vbCrLf & dtSta.Rows.Item(0).Item("StatusPedido").ToString
                End If
            End If
           

            Select Case strStatus
                Case "Orçamento", ""
                    .lblPedido.Text = "Nº " & strCod
                    .lblPed.Text = "Orçamento" & strNossoStatus
                    .colFornecedor.Visible = False
                    .colFornecedor2.Visible = False
                Case "Pendente"
                    .lblPedido.Text = "Nº " & strCod
                    .lblPed.Text = "Pedido - Pendente" & strNossoStatus

                Case "Faturado"
                    .lblPedido.Text = "Nº " & strCod
                    If TipoNano = 2 Or TipoNano = 5 Then
                        .lblPed.Text = "O.S." & strNossoStatus
                    Else
                        .lblPed.Text = "Pedido - Faturado" & strNossoStatus
                    End If

            End Select
            If NomeEmpresa.Contains("DAKAR") = True Then
                .lblPedido.Text = strCod
                .lblPed.Text = "Ordem de Serviço Nº"
            End If



            'If NomeEmpresa.Trim.Contains("PINHO") Then
            '    .lblNivComb.Text = "Vendedor:"


            'End If
            Dim strDescricao As String = dt.Rows.Item(0).Item("Descricao").ToString
            Dim vetDesc As Array = Split(strDescricao, "|")
            If vetDesc.Length > 1 Then
                .lblDefeitos.Text = vetDesc(1)
            End If
            'If Me.txtProbVeiculo.Text <> "" Then

            'Else
            '    .GroupFooter3.Visible = False
            'End If
            'If BloquearObsPedido = False Then
            .lblDesc.Text = vetDesc(0)

            'End If
            .lblData.Text = dt.Rows.Item(0).Item("Data").ToString
            .lblEntrada.Text = dt.Rows.Item(0).Item("DataRetirada").ToString
            .lblSaida.Text = dt.Rows.Item(0).Item("DataEntrega").ToString

            .lblKMSaida.Text = dt.Rows.Item(0).Item("KMSaida").ToString

            .lblAssi.Text = strCliente
            Dim dtPed As DataTable = CarregarDataTable("SELECT CodigoProduto, ItensConsig.CodigoInterno, Produto, Fabricante, ValorUnitario, ValorTotal, Qtd, Produto.Tipo, " & _
         "CodigoFuncionario, Garantia, UM, Autorizado FROM ItensConsig left join Produto on ItensConsig.CodigoProduto = Produto.Codigo where CodOrdens = " & strCod & " and CodConfig =" & CodConfig)

            Dim I As Integer
            For I = 0 To dtPed.Rows.Count - 1
                If dtPed.Rows.Item(I).Item("Autorizado") = True Then

                    If dtPed.Rows.Item(I).Item("Tipo").ToString = "SERVIÇO" Then
                        .tbServ.Rows.Add()
                        If dtPed.Rows.Item(I).Item("Garantia").ToString <> "" Then
                            .lblGar.Visible = True
                            .lblGarantias.Visible = True
                            .linha7.Visible = True
                            .lblGar.Text &= dtPed.Rows.Item(I).Item("CodigoInterno").ToString & " " & dtPed.Rows.Item(I).Item("Garantia").ToString & ", "
                        End If
                        If NomeEmpresa.Contains("MONDRIAN") = True Then
                            .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Fornecedor") = dtPed.Rows.Item(0).Item("Fabricante").ToString
                        End If
                        dblServ += dtPed.Rows.Item(I).Item("ValorTotal")

                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Código") = dtPed.Rows.Item(I).Item("CodigoInterno").ToString
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Qtde") = dtPed.Rows.Item(I).Item("Qtd").ToString
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Serviços") = dtPed.Rows.Item(I).Item("Produto").ToString
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("VlUnit") = CampoValor(dtPed.Rows.Item(I).Item("ValorUnitario").ToString)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("vlTot") = dtPed.Rows.Item(I).Item("ValorTotal").ToString
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("UMSER") = dtPed.Rows.Item(I).Item("UM").ToString
                        If dtPed.Rows.Item(I).Item("CodigoFuncionario").ToString <> "" Then
                            Dim dtFuc As DataTable = CarregarDataTable("Select Nome from Funcionario where Codigo =" & dtPed.Rows.Item(I).Item("CodigoFuncionario").ToString & " and CodConfig = " & CodConfig)
                            If dtFuc.Rows.Count > 0 Then
                                .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("FUNC") = dtFuc.Rows.Item(0).Item(0).ToString
                            End If

                        Else
                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbServ.Rows.Item(Index).Item("FUNC") = grd1.GetRowCellDisplayText(I, Me.colGarantia)
                            'End If
                        End If
                    Else
                        .tbPed.Rows.Add()
                        If dtPed.Rows.Item(I).Item("Garantia").ToString <> "" Then
                            .lblGar.Visible = True
                            .lblGarantias.Visible = True
                            .linha7.Visible = True
                            .lblGar.Text &= dtPed.Rows.Item(I).Item("CodigoInterno").ToString & " " & dtPed.Rows.Item(I).Item("Garantia").ToString & ", "
                        End If
                        If NomeEmpresa.Contains("MONDRIAN") = True Then
                            .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Fornecedor") = dtPed.Rows.Item(0).Item("Fabricante").ToString
                        End If
                        dblPec += dtPed.Rows.Item(I).Item("ValorTotal")

                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("CodigoPeca") = dtPed.Rows.Item(I).Item("CodigoInterno").ToString
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Qtde") = dtPed.Rows.Item(I).Item("Qtd").ToString
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Descrição") = dtPed.Rows.Item(I).Item("Produto").ToString
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("ValorUnitR") = CampoValor(dtPed.Rows.Item(I).Item("ValorUnitario").ToString)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Total") = dtPed.Rows.Item(I).Item("ValorTotal").ToString
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("UM") = dtPed.Rows.Item(I).Item("UM").ToString
                        If dtPed.Rows.Item(I).Item("CodigoFuncionario").ToString <> "" Then
                            Dim dtFuc As DataTable = CarregarDataTable("Select Nome from Funcionario where Codigo =" & dtPed.Rows.Item(I).Item("CodigoFuncionario").ToString & " and CodConfig = " & CodConfig)

                            If dtFuc.Rows.Count > 0 Then
                                .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Func") = dtFuc.Rows.Item(0).Item(0).ToString
                            End If
                        Else
                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbPed.Rows.Item(Index).Item("Modelo") = grd1.GetRowCellDisplayText(I, Me.colGarantia)
                            'End If
                        End If

                    End If
                End If
            Next

            dblTotal = dblPec + dblServ

            .Pecas.Text = dblPec.ToString("0.00")
            .Sevicos.Text = dblServ.ToString("0.00")

            .Total.Text = dblTotal.ToString("0.00")
            .subTotal.Text = dt.Rows.Item(0).Item("Total").ToString


            Dim dblDesc As Double
            If dt.Rows.Item(0).Item("Desconto").ToString <> "" Then
                Dim vetDesconto As Array = Split(dt.Rows.Item(0).Item("Desconto").ToString, "|")
                If vetDesconto(0).ToString <> "" Then
                    dblDesc = vetDesconto(0)
                End If
            End If
            .Desconto.Text = dblDesc.ToString("0.00")

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


            .ShowPreview()


        End With
    End Sub

    Private Sub VisualizarAutomotivoCompleto()
        Dim strCod As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCod)

        If strCod.Trim = "" Then Exit Sub
        Dim rel As New relOrcamento
        With rel
            Dim dt As DataTable = CarregarDataTable("Select Data, CodCli, convert(Numeric(15,2),Total) as Total, Descricao, Desconto, Status, Custo, " & _
              "Entrega, CodFunc, Funcionario.Nome, Acrescimo, convert(Varchar(10), DataRetirada, 103) as DataRetirada, " & _
              "Convert(varchar(10),DataEntrega,103) as DataEntrega, StatusPedido, Placa, Modelo, Cor, Ano, NivelCombustivel, Motor, KMEntrada, KMSaida from TotalConsig left join " & _
              "Funcionario on TotalConsig.CodFunc = Funcionario.Codigo where TotalConsig.CodOrdens = " & strCod.Trim & " and TotalConsig.CodConfig =" & CodConfig)

            Dim strCodCli As String = dt.Rows.Item(0).Item("CodCli").ToString

            Dim dtCli As DataTable = CarregarDataTable("SELECT Nome, Telefone, Fax, Email,CPF, RGIE, Endereco, Bairro, Numero, Cidade, Cep, " & _
            "convert(Varchar(10),Nascimento,103) as Nascimento, Complemento, Contato, Estado FROM Cliente where Codigo = " & strCodCli)
            Dim strCliente As String = ""
            If dtCli.Rows.Count > 0 Then
                strCliente = dtCli.Rows.Item(0).Item("Nome").ToString
                .Nome.Text = strCliente
                .Telefone.Text = dtCli.Rows.Item(0).Item("Telefone").ToString
                .Fax.Text = dtCli.Rows.Item(0).Item("Fax").ToString
                .Email.Text = dtCli.Rows.Item(0).Item("Email").ToString

                .Endereco.Text = dtCli.Rows.Item(0).Item("Endereco").ToString
                .Num.Text = dtCli.Rows.Item(0).Item("Numero").ToString
                .IE.Text = dtCli.Rows.Item(0).Item("RGIE").ToString
                .Bairro.Text = dtCli.Rows.Item(0).Item("Bairro").ToString
                .Cep.Text = dtCli.Rows.Item(0).Item("Cep").ToString
                .Cidade.Text = dtCli.Rows.Item(0).Item("Cidade").ToString
                .Estado.Text = dtCli.Rows.Item(0).Item("Estado").ToString

            End If

            If AutorizacaoPedido = False Then
                .lblAut.Visible = False
                .linha7.Visible = False
                .lblAssi.Visible = False
            Else
                .lblAssi.Text = strCliente
            End If


            If NomeEmpresa.Contains("MD NEGRO") Then
                .XrPanel1.BorderColor = Color.White
                .Margins.Top = 166
                .lblTitulo.Visible = False
                .lblFones.Visible = False
                .lblEndereco.Visible = False
                .picLogo.Visible = False
            End If

            .Name = "Pedido N° " & strCod
            .lblTitulo.Text = NomeEmpresa
            .lblFones.Text = TelefoneEmpresa
            .lblEndereco.Text = EnderecoEmpresa

            .lblPedido.Text = strCod
            .CPF.Text = CpfDoCliente
            .lblAtendente.Text = UserNano

            Dim dtConfig As DataTable = CarregarDataTable("SELECT DescricaoPedido FROM Config where Codigo = " & CodConfig)
            If dtConfig.Rows.Count > 0 Then
                If dtConfig.Rows.Item(0).Item("DescricaoPedido").ToString <> "" Then
                    .lblDescricaoPedido.Text = dtConfig.Rows.Item(0).Item("DescricaoPedido")
                End If
            End If

            .Placa.Text = dt.Rows.Item(0).Item("Placa").ToString
            .Modelo.Text = dt.Rows.Item(0).Item("Modelo").ToString
            .Cor.Text = dt.Rows.Item(0).Item("Cor").ToString
            .Ano.Text = dt.Rows.Item(0).Item("Ano").ToString
            .KM.Text = dt.Rows.Item(0).Item("KMEntrada").ToString
            .lblPrisma.Text = dt.Rows.Item(0).Item("Motor").ToString




            Dim dblPec, dblServ, dblResut, dblTotal As Double

            If NomeEmpresa.Trim.Contains("PINHO") Then
                .lblNivComb.Text = "Vendedor:"

            End If
            Dim strDescricao As String = dt.Rows.Item(0).Item("Descricao").ToString
            Dim vetDesc As Array = Split(strDescricao, "|")
            If vetDesc.Length > 1 Then
                .lblDefeitos.Text = vetDesc(1)
            Else
                .GroupFooter3.Visible = False
            End If

            If NomeEmpresa.Contains("MECÂNICA SÃO PAULO") Then
                .GroupFooter3.Visible = False
            End If
            'If BloquearObsPedido = False Then
            .lblDesc.Text = vetDesc(0)
            ' End If
            .lblData.Text = dt.Rows.Item(0).Item("Data").ToString
            .lblEntrada.Text = dt.Rows.Item(0).Item("DataRetirada").ToString
            .lblSaida.Text = dt.Rows.Item(0).Item("DataEntrega").ToString
            .lblNivCom.Text = dt.Rows.Item(0).Item("NivelCombustivel").ToString
            .lblKMSaida.Text = dt.Rows.Item(0).Item("KMSaida").ToString

            Dim strPlaca As String = dt.Rows.Item(0).Item("Placa").ToString
            Dim dtCar As DataTable = CarregarDataTable("Select Chassi, Motor, Combustivel from Carro where Placa = '" & strPlaca & "'")
            If dtCar.Rows.Count > 0 Then
                .lblChassi.Text = dtCar.Rows.Item(0).Item(0).ToString.Trim
                .lblMotor.Text = dtCar.Rows.Item(0).Item(1).ToString.Trim
                .lblComb.Text = dtCar.Rows.Item(0).Item(2).ToString.Trim
            End If

            Dim dtPed As DataTable = CarregarDataTable("SELECT CodigoProduto, ItensConsig.CodigoInterno, Produto, ValorUnitario, ValorTotal, Qtd, Produto.Tipo, " & _
            "CodigoFuncionario, Garantia, UM, Autorizado FROM ItensConsig left join Produto on ItensConsig.CodigoProduto = Produto.Codigo where CodOrdens = " & strCod & " and CodConfig =" & CodConfig)

            Dim I As Integer
            For I = 0 To dtPed.Rows.Count - 1
                If dtPed.Rows.Item(I).Item("Autorizado") = True Then


                    If dtPed.Rows.Item(I).Item("Tipo").ToString = "SERVIÇO" Then
                        .tbServ.Rows.Add()

                        If dtPed.Rows.Item(I).Item("Garantia").ToString <> "" Then
                            .lblGar.Visible = True
                            .lblGarantias.Visible = True
                            .linha7.Visible = True
                            .lblGar.Text &= dtPed.Rows.Item(I).Item("CodigoInterno").ToString & " " & dtPed.Rows.Item(I).Item("Garantia").ToString & ", "
                        End If

                        dblServ += dtPed.Rows.Item(I).Item("ValorTotal")

                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Código") = dtPed.Rows.Item(I).Item("CodigoInterno").ToString
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Qtde") = dtPed.Rows.Item(I).Item("Qtd").ToString
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("Serviços") = dtPed.Rows.Item(I).Item("Produto").ToString
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("VlUnit") = CampoValor(dtPed.Rows.Item(I).Item("ValorUnitario").ToString)
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("vlTot") = dtPed.Rows.Item(I).Item("ValorTotal").ToString
                        .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("UMSER") = dtPed.Rows.Item(I).Item("UM").ToString
                        If dtPed.Rows.Item(I).Item("CodigoFuncionario").ToString <> "" Then
                            Dim dtFuc As DataTable = CarregarDataTable("Select Nome from Funcionario where Codigo =" & dtPed.Rows.Item(I).Item("CodigoFuncionario").ToString & " and CodConfig = " & CodConfig)
                            If dtFuc.Rows.Count > 0 Then
                                .tbServ.Rows.Item(.tbServ.Rows.Count - 1).Item("FUNC") = dtFuc.Rows.Item(0).Item(0).ToString
                            End If
                        Else
                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbServ.Rows.Item(Index).Item("FUNC") = grd1.GetRowCellDisplayText(I, Me.colGarantia)
                            'End If
                        End If
                    Else
                        .tbPed.Rows.Add()
                        If dtPed.Rows.Item(I).Item("Garantia").ToString <> "" Then
                            .lblGar.Visible = True
                            .lblGarantias.Visible = True
                            .linha7.Visible = True
                            .lblGar.Text &= dtPed.Rows.Item(I).Item("CodigoInterno").ToString & " " & dtPed.Rows.Item(I).Item("Garantia").ToString & ", "
                        End If

                        dblPec += dtPed.Rows.Item(I).Item("ValorTotal")

                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("CodigoPeca") = dtPed.Rows.Item(I).Item("CodigoInterno").ToString
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Qtde") = dtPed.Rows.Item(I).Item("Qtd").ToString
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Descrição") = dtPed.Rows.Item(I).Item("Produto").ToString
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("ValorUnitR") = CampoValor(dtPed.Rows.Item(I).Item("ValorUnitario").ToString)
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Total") = dtPed.Rows.Item(I).Item("ValorTotal").ToString
                        .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("UM") = dtPed.Rows.Item(I).Item("UM").ToString
                        If dtPed.Rows.Item(I).Item("CodigoFuncionario").ToString <> "" Then
                            Dim dtFuc As DataTable = CarregarDataTable("Select Nome from Funcionario where Codigo =" & dtPed.Rows.Item(I).Item("CodigoFuncionario").ToString & " and CodConfig = " & CodConfig)

                            If dtFuc.Rows.Count > 0 Then
                                .tbPed.Rows.Item(.tbPed.Rows.Count - 1).Item("Func") = dtFuc.Rows.Item(0).Item(0).ToString
                            End If
                        Else
                            'If NomeEmpresa.Trim.Contains("ROD PNEUS") Then
                            '    .tbPed.Rows.Item(Index).Item("Modelo") = grd1.GetRowCellDisplayText(I, Me.colGarantia)
                            'End If
                        End If

                    End If
                End If
            Next
            .Pecas.Text = dblPec.ToString("0.00")
            .Sevicos.Text = dblServ.ToString("0.00")
            dblTotal = dblPec + dblServ


            .Total.Text = dblTotal.ToString("0.00")
            .subTotal.Text = dt.Rows.Item(0).Item("Total").ToString
            Dim dblDesc As Double
            If dt.Rows.Item(0).Item("Desconto").ToString <> "" Then
                Dim vetDesconto As Array = Split(dt.Rows.Item(0).Item("Desconto").ToString, "|")
                If vetDesconto(0).ToString <> "" Then
                    dblDesc = vetDesconto(0)
                End If
            End If
            .Desconto.Text = dblDesc.ToString("0.00")


            .picLogo.Image = LogoTipo



            If NomeEmpresa = "DAKAR AUTO ELÉTRICA E MECÂNICA" Then
                rel.lblGarantias.Visible = True
                rel.lblGar.Visible = True
                rel.lblGar.Text = "MÃO DE OBRA - 03 MESES, PEÇAS - 03 MESES"
            End If

            Dim dtSta As DataTable = CarregarDataTable("Select Status from TotalConsig where CodOrdens =" & strCod & " and CodConfig = " & CodConfig)
            Dim strStatus As String = "Pendente"
            If dtSta.Rows.Count > 0 Then
                strStatus = dtSta.Rows.Item(0).Item("Status").ToString
            End If

            Select Case strStatus
                Case "Orçamento"
                    rel.lblPedido.Text = "Orçamento Nº: " & strCod

                Case "Pendente"
                    rel.lblPedido.Text = "Orçamento Nº: " & strCod

                Case "Faturado"
                    rel.lblPedido.Text = "O.S. Nº: " & strCod

            End Select
            If NomeEmpresa.Contains("DAKAR") = True Then
                .lblPedido.Text = "Ordem de Serviço Nº: " & strCod
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


            .ShowPreview()


        End With
    End Sub

    Private Sub ImpApp()
        ImpComandaApp()
        ImpTotalComandaApp()
        ImpObsComandaApp()
    End Sub

    Private Sub btnRelRevisao_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelRevisao.ItemClick
        frmConfRelRevisao.Show()
    End Sub

    Private Sub btnCadVeiculo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCadVeiculo.ItemClick
        frmCadCliente.Tag = "CARRO"
        frmCadCliente.Show()
    End Sub

    Private Sub btnLimparPedidos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimparPedidos.ItemClick
        If MsgBox("Verifique se todas as telas de pedidos estão fechadas em todos os computadores." & vbCrLf & "Tem certeza que deseja desbloquear todos os pedidos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Atualizar("UPDATE TotalConsig set UsuarioAlt = '' where UsuarioAlt <> ''")
        End If
    End Sub


    Private Sub btnAjustarEmfalta_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAjustarEmfalta.ItemClick
        frmCorrecaoEstoque.Text = "Ajustar Em Falta"
        frmCorrecaoEstoque.Tag = "EMFALTA"
        frmCorrecaoEstoque.ShowDialog()
    End Sub

    Private Sub btnMigrarAuto_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMigrarAuto.ItemClick
        frmMigrarAutomotivo.ShowDialog()
    End Sub

    Private Sub btnConfigBoleto_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConfigBoleto.ItemClick
        frmConfigBoleto.ShowDialog()
    End Sub

    Private Sub btnReciboRec_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReciboRec.ItemClick

        frmRecibo.Tag = "RECEBIMENTO"
        frmRecibo.Show()
    End Sub

    Private Sub btnReciboPag_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReciboPag.ItemClick
        frmRecibo.Tag = "PAGAMENTO"
        frmRecibo.Show()
    End Sub

    Private Sub btnRemessa_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRemessa.ItemClick
        frmRemessa.Tag = "REMESSA"
        frmRemessa.Show()
    End Sub

    Private Sub btnConsBoleto_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConsBoleto.ItemClick
        frmRemessa.Tag = "CONSULTA"
        frmRemessa.Show()
    End Sub

    Private Sub btnArquivoRetorno_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnArquivoRetorno.ItemClick
        frmRetorno.Show()
    End Sub

    Private Sub BarButtonItem30_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem30.ItemClick
        If MsgBox("Deseja ajustar o estoque AutoMar?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub


        'Dim dt As DataTable = CarregarDataTable("SELECT * FROM Fabricante")

        'Dim I As Integer
        'Dim A As Integer = 1
        'Dim strCodigoProduto As String = ""
        'For I = 0 To dt.Rows.Count - 1
        '    Dim strCodProd As String = dt.Rows.Item(I).Item("CodProd").ToString
        '    Dim strFabricante As String = dt.Rows.Item(I).Item("Fabricante").ToString
        '    Dim strCodFabri As String = dt.Rows.Item(I).Item("CodVinculo").ToString

        '    Dim strQtd As String = dt.Rows.Item(I).Item("Qtd").ToString

        '    Dim strPor1 As String = "0"
        '    Dim strPor2 As String = "0"
        '    Dim strPor3 As String = "0"

        '    Dim strValorCusto As Double = 0
        '    If dt.Rows.Item(I).Item("Custo").ToString <> "" Then
        '        strValorCusto = dt.Rows.Item(I).Item("Custo").ToString
        '    End If
        '    Dim strValor As Double = 0
        '    If dt.Rows.Item(I).Item("Valor1").ToString <> "" Then
        '        strValor = dt.Rows.Item(I).Item("Valor1").ToString
        '        Dim dblLucro As Double = strValor - strValorCusto
        '        dblLucro = (dblLucro * 100) / strValorCusto
        '        Dim str As String = dblLucro
        '        If str <> "+Infinito" And str <> "NaN (Não é um número)" Then
        '            If TresCasasDecimais = True Then
        '                strPor1 = dblLucro.ToString("0.000")
        '            Else
        '                strPor1 = dblLucro.ToString("0.00")
        '            End If
        '        End If
        '    End If
        '    Dim strValor2 As Double = 0
        '    If dt.Rows.Item(I).Item("Valor2").ToString <> "" Then
        '        strValor2 = dt.Rows.Item(I).Item("Valor2").ToString
        '        Dim dblLucro As Double = strValor2 - strValorCusto
        '        dblLucro = (dblLucro * 100) / strValorCusto
        '        Dim str As String = dblLucro
        '        If str <> "+Infinito" And str <> "NaN (Não é um número)" Then
        '            If TresCasasDecimais = True Then
        '                strPor2 = dblLucro.ToString("0.000")
        '            Else
        '                strPor2 = dblLucro.ToString("0.00")
        '            End If
        '        End If
        '    End If
        '    Dim strValor3 As Double = 0
        '    If dt.Rows.Item(I).Item("Valor3").ToString <> "" Then
        '        strValor3 = dt.Rows.Item(I).Item("Valor3").ToString
        '        Dim dblLucro As Double = strValor3 - strValorCusto
        '        dblLucro = (dblLucro * 100) / strValorCusto
        '        Dim str As String = dblLucro
        '        If str <> "+Infinito" And str <> "NaN (Não é um número)" Then
        '            If TresCasasDecimais = True Then
        '                strPor3 = dblLucro.ToString("0.000")
        '            Else
        '                strPor3 = dblLucro.ToString("0.00")
        '            End If
        '        End If
        '    End If

        '    If strCodProd = strCodigoProduto Then

        '        Inserir("INSERT INTO Produto (Nome, UnidadeMedida, Valor, ValorCusto, Locacao, CodigoInterno, " & _
        '        "Porcentagens, Fabricante, Grupo, Obs, Data, CodigoBarra, NivelComboCodCF, Desconto, Setor, Tipo, " & _
        '        "Inativo, Validade, Comissao, Locacao2, Familia, CodProdFor, TributacaoPadrao, AlterarPreco, " & _
        '        "CodigoFabricante, Garantia, KM, Peso, PesoBruto) SELECT Nome  + ' - " & strFabricante & "' as Nome, " & _
        '        "UnidadeMedida, " & Num(strValor) & " as Valor, " & Num(strValorCusto) & " as ValorCusto, Locacao, " & _
        '        "CodigoInterno + '-" & A & "' as CodigoInterno, '" & strPor1 & "' as Porcentagens, Fabricante, " & _
        '        "Grupo, Obs, Data, '' as CodigoBarra, NivelComboCodCF, Desconto, '" & strFabricante & "' as Setor, Tipo, " & _
        '        "Inativo, Validade, Comissao, '" & I & "' as Locacao2, Familia, CodProdFor, TributacaoPadrao, AlterarPreco, " & _
        '        "'" & strCodFabri & "' as CodigoFabricante, Garantia, KM, Peso, PesoBruto FROM Produto where Codigo = " & strCodProd)

        '        Dim dtProd As DataTable = CarregarDataTable("SELECT Codigo FROM Produto where Locacao2 = '" & I & "'")
        '        If dtProd.Rows.Count > 0 Then
        '            Dim strCodProd2 As String = dtProd.Rows.Item(0).Item("Codigo").ToString
        '            Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, Data, Tabela, CodConfig, " & _
        '            "CodUser) VALUES (" & strCodProd2 & "," & Num(strQtd) & ",'" & Date.Today & "'," & _
        '            "'QTDE-MIG',1,1)")

        '            If strValor2 > 0 Then
        '                Inserir("INSERT INTO TabelaPreco (CodProd, CodTabela, Valor, Porcentagem) " & _
        '                "VALUES (" & strCodProd2 & ",60," & Num(strValor2) & "," & Num(strPor2) & ")")
        '            End If
        '            If strValor3 > 0 Then
        '                Inserir("INSERT INTO TabelaPreco (CodProd, CodTabela, Valor, Porcentagem) " & _
        '               "VALUES (" & strCodProd2 & ",61," & Num(strValor3) & "," & Num(strPor3) & ")")
        '            End If
        '        End If
        '        A += 1
        '    Else
        '        A = 1
        '        strCodigoProduto = strCodProd
        '        Atualizar("UPDATE Produto set Nome = Nome + ' - " & strFabricante & "', " & _
        '        "CodigoFabricante = '" & strCodFabri & "', Valor = " & Num(strValor) & ", " & _
        '        "ValorCusto = " & Num(strValorCusto) & ", Setor = '" & strFabricante & "', " & _
        '        "Porcentagens = '" & strPor1 & "' where Codigo = " & strCodProd)

        '        Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, Data, Tabela, CodConfig, " & _
        '        "CodUser) VALUES (" & strCodProd & "," & Num(strQtd) & ",'" & Date.Today & "'," & _
        '        "'QTDE-MIG',1,1)")
        '        If strValor2 > 0 Then
        '            Inserir("INSERT INTO TabelaPreco (CodProd, CodTabela, Valor, Porcentagem) " & _
        '            "VALUES (" & strCodProd & ",60," & Num(strValor2) & "," & Num(strPor2) & ")")
        '        End If

        '        If strValor3 > 0 Then
        '            Inserir("INSERT INTO TabelaPreco (CodProd, CodTabela, Valor, Porcentagem) " & _
        '           "VALUES (" & strCodProd & ",61," & Num(strValor3) & "," & Num(strPor3) & ")")
        '        End If

        '    End If
        'Next


        Dim dt As DataTable = CarregarDataTable("SELECT Fabricante from Fabricante group by Fabricante")
        Dim I As Integer
        For I = 0 To dt.Rows.Count - 1
            Dim strFabricante As String = dt.Rows.Item(I).Item("Fabricante").ToString
            Atualizar("UPDATE Produto set Nome = replace(Nome,' - " & strFabricante & " - ',' - ')")
        Next
    End Sub

    Private Sub BarButtonItem31_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem31.ItemClick
        If MsgBox("Deseja ajustar a comissao da kolok?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub


        'Dim dt As DataTable = CarregarDataTable("SELECT CodOrdem, ValorProduto, CodFunc from Comissao where CodOrdem >= 53597 and CodOrdem <= 54249 and CodConfig = 1")
        'Dim I As Integer
        'For I = 0 To dt.Rows.Count - 1

        '    Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
        '    Dim strValorProduto As String = dt.Rows.Item(I).Item("ValorProduto").ToString
        '    Dim strCodFunc As String = dt.Rows.Item(I).Item("CodFunc").ToString

        '    Atualizar("UPDATE Pedido set CodFunc = " & strCodFunc & " where CodOrdem = " & strCodOrdem & " and ValorUnitario = " & Num(strValorProduto) & " and CodConfig = 1")

        'Next


        'dt = CarregarDataTable("SELECT CodOrdem, ValorProduto, CodFunc from Comissao where CodOrdem >= 2954 and CodOrdem <= 3166 and CodConfig = 2")

        'For I = 0 To dt.Rows.Count - 1

        '    Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
        '    Dim strValorProduto As String = dt.Rows.Item(I).Item("ValorProduto").ToString
        '    Dim strCodFunc As String = dt.Rows.Item(I).Item("CodFunc").ToString

        '    Atualizar("UPDATE Pedido set CodFunc = " & strCodFunc & " where CodOrdem = " & strCodOrdem & " and ValorUnitario = " & Num(strValorProduto) & " and CodConfig = 2")

        'Next

        Dim A As Integer
        Dim B As Integer
        Dim dt As DataTable = CarregarDataTable("SELECT count(CodOrdem) as Qtd, ValorProduto, CodOrdem from Comissao where CodOrdem >= 53597 and CodConfig = 1 group by ValorProduto, CodOrdem")
        Dim I As Integer
        For I = 0 To dt.Rows.Count - 1
            Dim dblQtd As Double = dt.Rows.Item(I).Item("Qtd").ToString
            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
            Dim strValorProduto As String = dt.Rows.Item(I).Item("ValorProduto").ToString
            Dim dtCom As DataTable = CarregarDataTable("SELECT Codigo, CodFunc from comissao where  CodOrdem = " & strCodOrdem & " and ValorProduto = " & Num(strValorProduto) & " and CodConfig = 1 order by codigo")
            If dblQtd = 1 Then
                Dim strCodFunc As String = dtCom.Rows.Item(0).Item("CodFunc").ToString
                Atualizar("UPDATE Pedido set CodFunc = " & strCodFunc & " where CodOrdem = " & strCodOrdem & " and ValorTotal = " & Num(strValorProduto) & " and CodConfig = 1")
            Else
                For A = 0 To dtCom.Rows.Count - 1
                    Dim strCodFunc As String = dtCom.Rows.Item(A).Item("CodFunc").ToString
                    Dim dtPed As DataTable = CarregarDataTable("SELECT Codigo FROM PEdido where CodOrdem = " & strCodOrdem & " and ValorTotal = " & Num(strValorProduto) & " and CodConfig = 1 order by codigo")

                    For B = 0 To dtPed.Rows.Count - 1
                        If A = B Then
                            Dim strCodPed As String = dtPed.Rows.Item(B).Item("Codigo").ToString
                            Atualizar("UPDATE Pedido set CodFunc = " & strCodFunc & " where Codigo = " & strCodPed & " and CodConfig = 1")
                        End If
                    Next
                Next
            End If
        Next


        dt = CarregarDataTable("SELECT count(CodOrdem) as Qtd, ValorProduto, CodOrdem from Comissao where CodOrdem >= 2954 and CodConfig = 2 group by ValorProduto, CodOrdem")

        For I = 0 To dt.Rows.Count - 1
            Dim dblQtd As Double = dt.Rows.Item(I).Item("Qtd").ToString
            Dim strCodOrdem As String = dt.Rows.Item(I).Item("CodOrdem").ToString
            Dim strValorProduto As String = dt.Rows.Item(I).Item("ValorProduto").ToString
            Dim dtCom As DataTable = CarregarDataTable("SELECT Codigo, CodFunc from comissao where  CodOrdem = " & strCodOrdem & " and ValorProduto = " & Num(strValorProduto) & " and CodConfig = 2 order by codigo")
            If dblQtd = 1 Then
                Dim strCodFunc As String = dtCom.Rows.Item(0).Item("CodFunc").ToString
                Atualizar("UPDATE Pedido set CodFunc = " & strCodFunc & " where CodOrdem = " & strCodOrdem & " and ValorTotal = " & Num(strValorProduto) & " and CodConfig = 2")
            Else
                For A = 0 To dtCom.Rows.Count - 1
                    Dim strCodFunc As String = dtCom.Rows.Item(A).Item("CodFunc").ToString
                    Dim dtPed As DataTable = CarregarDataTable("SELECT Codigo FROM PEdido where CodOrdem = " & strCodOrdem & " and ValorTotal = " & Num(strValorProduto) & " and CodConfig = 2 order by codigo")

                    For B = 0 To dtPed.Rows.Count - 1
                        If A = B Then
                            Dim strCodPed As String = dtPed.Rows.Item(B).Item("Codigo").ToString
                            Atualizar("UPDATE Pedido set CodFunc = " & strCodFunc & " where Codigo = " & strCodPed & " and CodConfig = 2")
                        End If
                    Next
                Next
            End If
        Next

        MsgBox("Ok", MsgBoxStyle.Information)

    End Sub

    Private Sub BarButtonItem32_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem32.ItemClick
        If MsgBox("Transferencia Natura?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Dim intCodConfig As Integer = InputBox("Digite o código da nova loja:").Trim
        Dim I As Integer
        Dim dtProd As DataTable = CarregarDataTable("SELECT Produto.Codigo, Produto.ValorCusto, " & _
        "(SELECT case when sum(EntradaNf.QtdProd) is null then 0 else sum(EntradaNf.QtdProd) end " & _
        "FROM EntradaNf left join TotalEntradaNf on EntradaNf.CodTotNf = TotalEntradaNf.Codigo " & _
        "where EntradaNf.CodProd = Produto. Codigo and EstoqueOk = 'True' and " & _
        "EntradaNf.CodConfig = " & intCodConfig & ") - (SELECT case when sum(Pedido.Qtd) is null " & _
        "then 0 else sum(Pedido.Qtd) end FROM Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem " & _
        "and PEdido.CodConfig = Total.CodConfig where Pedido.CodConfig = " & intCodConfig & " " & _
        "and Pedido.CodProd = Produto.Codigo and Pedido.Devolvido = 'False') + (SELECT case " & _
        "when sum(AjusteQtde.Qtd) is null then 0 else sum(AjusteQtde.Qtd) end FROM AjusteQtde " & _
        "where AjusteQtde.CodConfig = " & intCodConfig & " and AjusteQtde.CodProd = Produto.Codigo) as Qtd " & _
        "FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where Produto.Inativo = 'False' " & _
        "and Produto.Grupo = 'PRODUTO NATURA' group by Produto.Codigo, Produto.ValorCusto")

        Dim intCodOrdem As Integer = GerarCodigo("OrdemTrans", "Codigo", intCodConfig)
        Inserir("INSERT INTO OrdemTrans (Codigo, CodConfig) VALUES (" & intCodOrdem & "," & intCodConfig & ")")

        For I = 0 To dtProd.Rows.Count - 1
            Dim strCodProd As String = dtProd.Rows.Item(I).Item("Codigo").ToString
            Dim strTamanho As String = "U"
            Dim strQtd As Double = dtProd.Rows.Item(I).Item("Qtd")
            If strQtd > 0 Then
                Dim strloja As String = "3"
                Dim strValorCusto As String = dtProd.Rows.Item(I).Item("ValorCusto").ToString
                Dim strLote As String = "U"

                Inserir("INSERT INTO Transferencia (CodOrdem, CodProd, Tamanho, Qtd, ValorCusto, CodLoja, " & _
                "CodConfig, CodUserSaida, Data, Status, EntSai, Lote) VALUES (" & intCodOrdem & "," & strCodProd & "," & _
                "'" & strTamanho & "'," & Num(strQtd) & "," & Num(strValorCusto) & "," & strloja & "," & intCodConfig & "," & _
                "" & CodUser & ",'" & Date.Today & "','Pendente','S','" & strLote & "')")
            End If

        Next

        MsgBox("ok", MsgBoxStyle.Information)
    End Sub

    Private Sub btnEmailConsultoria_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEmailConsultoria.ItemClick
        Dim frm As New frmRelDRE
        frm.Tag = "CONSULTORIA"
        frm.Show()
    End Sub

    Private Sub btnNfseNano_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNfseNano.ItemClick
        Dim processo As Process() = Process.GetProcessesByName("NanoNfse")
        If processo.Length > 0 Then
            MsgBox("O sistema já esta aberto!", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim strVersao As String = ""


        Try
            'System.IO.File.Delete(My.Application.Info.DirectoryPath & "\Controle.era")
            System.IO.File.Delete("C:\NANONFse\Debug\VersaoNfse.txt")


            Dim wc As New System.Net.WebClient()

            'wc.DownloadFile("https://sites.google.com/site/cotroles/inadimplencia/Controle.era?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\Controle.era")
            wc.DownloadFile("https://sites.google.com/site/cotroles/versao/VersaoNfse.txt?attredirects=0&d=1", "C:\NANONFse\Debug\VersaoNfse.txt")


        Catch ex As Exception

        End Try

        strVersao = LerArquivo("C:\NANONFse\Debug\VersaoNfse.txt", True)
        Dim strLogin As String = LerArquivo("C:\NANONFse\Debug\Login.txt", True)
        Dim fluxoTexto As IO.StreamWriter
        fluxoTexto = New IO.StreamWriter("C:\NANONFse\Debug\Login.txt")

        fluxoTexto.Write("")
        fluxoTexto.Write(Login & "|" & Senha & "|" & strVersao)
        fluxoTexto.Close()

        System.Diagnostics.Process.Start("C:\NANONFse\Debug\NanoNfse.exe")
    End Sub

    Private Sub btnCadSevico_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCadSevico.ItemClick
        frmCadProduto.Tag = "SERVICO"
        frmCadProduto.Show()
    End Sub

    Private Sub btnConServico_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConServico.ItemClick
        Dim frm As New frmConProduto
        frm.strTipoProduto = "S"
        frm.Tag = "SERVICO"
        frm.Show()
    End Sub

    Private Sub btnComandaTouch_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnComandaTouch.ItemClick

        MDIComanda.ShowDialog()
    End Sub

    Dim strLinks(6) As String
    Dim intContRdn As Integer
    Dim intContWb As Integer = 0
    Dim intContValue As Integer = 0
    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If intContWb = 0 Then
       
            'strLinks(0) = "https://www.sistemasnano.com.br/"
            'strLinks(1) = "https://www.sistemasnano.com.br/planos/"
            'strLinks(2) = "https://www.sistemasnano.com.br/automotivo/"
            'strLinks(3) = "https://www.sistemasnano.com.br/planos2/"
            'strLinks(4) = "https://www.sistemasnano.com.br/revendas/"
            'strLinks(5) = "https://www.sistemasnano.com.br/quem-somos/"
            'strLinks(6) = "https://www.sistemasnano.com.br/contato/"

            'Randomize()
            'Dim value As Integer = CInt(Int((7 * Rnd()) + 1))

            'Me.WebBrowser1.ScriptErrorsSuppressed = True
            'Me.WebBrowser1.Navigate(strLinks(value - 1), "_top", Nothing, "User-Agent: Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.130 Safari/537.36")
            IniciaThreadSiteNano()
            Randomize()
            intContRdn = CInt(Int((120 * Rnd()) + 1))
            intContValue = 0

            'IO.File.Create(My.Application.Info.DirectoryPath & "\SiteNano" & intContWb & "-" & value & "-" & intContRdn & ".txt")
        End If

        If intContValue >= intContRdn Then
            'Dim value As Integer = CInt(Int((7 * Rnd()) + 1))

            'Me.WebBrowser1.ScriptErrorsSuppressed = True
            'Me.WebBrowser1.Navigate(strLinks(value - 1), "_top", Nothing, "User-Agent: Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.130 Safari/537.36")
            IniciaThreadSiteNano()
            Randomize()
            intContRdn = CInt(Int((120 * Rnd()) + 1))
            intContValue = 0
            'IO.File.Create(My.Application.Info.DirectoryPath & "\SiteNano" & intContWb & "-" & value & "-" & intContRdn & ".txt")
        End If

     

        If intContWb >= 420 Then
            Me.WebBrowser1.Navigate("")
            Timer4.Stop()
        End If
        intContWb += 1
        intContValue += 1
    End Sub

 
End Class