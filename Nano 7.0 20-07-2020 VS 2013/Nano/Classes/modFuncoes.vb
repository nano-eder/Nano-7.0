Imports Nano.clsFuncoes
Imports System.Security.Cryptography.xml
Imports System.Security.Cryptography.X509Certificates
Module modFuncoes

    Public VersaoDoSistemaProjeto As String = "4.5.3"

    Public TabelaPrecoPorItem As Boolean = True
    Public Imagem1Comanda As Byte()
    Public Imagem2Comanda As Byte()

    Public LocationMensagem As Integer = 0
    Public LocationTeclado As Integer
    Public RetornoMensagemComanda As Boolean
    Public RetornoNumeroComanda As Integer

    Public QtdeVaziaComanda As Boolean = False
    Public TecladoVirtual As Boolean = True
    Public CorImagemBarra As String = "Laranja"
    Public CorImagemBotao As String = "Laranja"
    Public CorBarra As System.Drawing.Color
    Public CorFonte As System.Drawing.Color
    Public CorGrupo As System.Drawing.Color
    Public CorProduto As System.Drawing.Color
    Public CorComanda As System.Drawing.Color
    Public CorBotoes As System.Drawing.Color
    Public CorFundo As System.Drawing.Color
    Public CorTeclado As System.Drawing.Color

    Public FormAberto As String
    Public mThreadTeclado As Threading.Thread
    Public mThreadTecladoNumerico As Threading.Thread

    Public strStatusPed As String 'Carrega o status do pedido para o frmConProduto usa na função VerificarQtde
    Public BloqueioTransferenciaBancario As Boolean = True
    Public ExcluirLancamentoBancario As Boolean = True
    Public NanoNFSe As Boolean = True
    Public ExcluirPedido As Boolean = True
    Public ExcluirVendas As Boolean = True
    Public DesfaturarPedidos As Boolean = True


    Public TotalPendenciaImpressao As Boolean = True
    Public BloquearEstoqueZeradoConfig As Boolean = False
    Public ValePresente As Boolean = False
    Public BloquearVenda As Boolean = False
    Public AbrirFecharCaixa As Boolean = False
    Public FreteMinimo As Double = 0
    Public PorcentagemFrete As Double = 0
    Public ManterMargemProd As Boolean
    Public CalcularImpostoProduto As Boolean
    Public SaldoCaixa As String
    Public EmailConsultoria As String
    Public TipoFiscal As String
    Public CodigoDoProdutoAgrupado As String
    Public BloquearAbreGaveta As Boolean = False
    Public NomeAd As String
    Public ImpressaoPadrao As Boolean
    Public CasaDecimal As String
    Public VersaoXml As String
    Public TLS12 As Boolean
    'Public CaixaTodosUsuarios As Boolean = False
    Public AlterarDataCaixa As Boolean = True
    Public TipoBalanca As String
    Public GerarSATCrystal As Boolean
    Public ObsClientePedido As Boolean = False
    Public QtdePessoasMesa As String

    Public ValorTotalCT As Double
    Public CobreBemNano As Boolean

    Public FormaPagamentoGaveta As String = ""
    Public NomePCGaveta As String = ""
    Public FiltroProdutoContem As Boolean

    Public TemBalanca As Boolean
    Public PortaBalanca As String
    Public BaudRateBalanca As String
    Public DataBitsBalanca As Integer
    Public ParidadeBalanca As Integer

    Public EmailArquivo As String
    Public DescontoImpressao As Boolean

    Public IP As String
    Public TEF As Boolean
    Public CaixaTEF As String
    Public TipoCartao As String
    Public NumTransacao As String
    Public ComprovanteTEF(2) As String
    Public CodigoTerminal As String

    Public TokenNFCe As Integer
    Public CodEmitente As Integer
    Public certificate As New X509Certificate2
    Public CertificadoDigital As String
    Public NANONFCe As Boolean
    Public PastaRemessas As String
    Public StatusEmitente As String
    Public PastaBackup As String
    Public VersaoXmlEvento As String
    Public VersaoXmlInutilizacao As String
    Public VersaoXmlConsulta As String
    Public VersaoXmlAutorizacao As String
    Public PastaAutorizadas As String
    Public PastaAssinadas As String
    Public PastaNotas As String
    Public PastaArquivos As String
    Public PastaWebServices As String
    Public URLNfe As String
    Public TipoAmbiente As String
    Public EstadoEmitente As String
    Public ChaveAcesso As String
    Public CaminhoNFCe As String
    Public CodigoNF As Integer
    Public ImpressoraNFCe As String
    Public PortaImpressoraNFCe As String
    Public ImpDiretoNFCe As Boolean
    Public MensImpCupomNFCe As Boolean
    Public TZD As String

    Public DataEmissao As String
    Public CSTEmitente As String
    Public TotalNFCe As String
    Public TotalICMS As String
    Public CPFDestinatario As String
    Public RetornoTEF As Integer

    Public SenhaAdm As Boolean
    Public ValorUnitComanda As Double
    Public TabelaPreco As String
    Public MediaCusto As Boolean = True
    Public MontarKit As Boolean = False
    Public SATExterno As Boolean = False
    Public Tabela As Integer
    Public UserNano As String
    Public CodUser As Integer
    Public Nivel As String
    Public Senha As String
    Public Login As String
    Public SkinDoUsuario As String = "Blue"
    Public Master As Boolean = False
    Public CodConfig As Integer
    Public DescricaoEmpresa As String
    Public PedidoAberto As Boolean
    Public MensagemDeErro As String
    Public StringSQLComErro As String
    Public MensagemEmailUsuario As String
    Public ResulNano As Integer
    Public RetornaProduto As String
    Public ConsultaPedido As String
    Public TipoProduto As String
    Public Troco As String
    Public Recebido As String
    Public NomeDoCliente As String
    Public CpfDoCliente As String
    Public CodigoDoCliente As Integer
    Public PlacaDoCarro As String
    Public ValorDoDesconto As String
    Public PorcentagemDoDesconto As String
    Public TotalComDesconto As String
    Public Seguradora As String
    Public CPFFornecedor As String
    Public NomeFornecedor As String
    Public CodigoDoFornecedor As Integer
    Public DataEmissaoDuplicata As String
    Public NumeroFatura As String
    Public OrdemDuplicata As String
    Public FaturarInvisivel As Boolean = False
    Public StringDeConexao As String
    Public StringOnline As String

    Public QtdeDoProduto As Double
    Public CodigoDoProduto As Integer
    Public TamanhoDoProduto As String
    Public LogoTipo As Image
    Public bolSenhaOK As Boolean = False
    Public CodigoDaVenda As Integer
    Public AtualizarComanda As Boolean = False
    Public LojasProntas As Boolean = False
    Public CodigoFuncionario As Integer
    Public NomeFuncionario As String
    Public GerarComissao As Boolean = False
    Public ValidarCPF As Boolean = False
    Public TemGuilhotina As Boolean = False
    Public TemGaveta As Boolean = False
    Public NomePCImpressora As String
    Public PermiteEstoqueZerado As Boolean = False
    Public BloquearParcelas As Boolean = False
    Public TipoDesconto As String
    Public ImpostoPorItem As Boolean = False
    Public ConsultaNFE As String
    Public ListaProduto As String
    Public ListaOpcoes As String
    Public PrecoProdutoOpcoes As Double
    Public CodigoProdutoOpcoes As Integer
    Public CodigoInternoProdutoOpcoes As String
    Public ObsOpcoes As String
    Public TrocaDeUsuario As Boolean = False
    Public CodigoAtivo As String
    Public QtdeLoja As Integer
    Public CodigoClienteEtiqueta As String
    Public EnviarEmail As String
    Public QtdeExcluida As Double
    Public EstoqueSomado As Boolean
    Public AgruparProdutoVenda As Boolean = True
    Public CodTabelaPreco As Integer
    'DADOS DO CLIENTE QUE O NANO ESTÁ INSTALADO
    Public UFEmpresa As String
    Public CNPJdoCliente As String
    Public NomeEmpresa As String
    Public EnderecoEmpresa As String
    Public TelefoneEmpresa As String
    Public CNPJEmpresa As String
    Public CidadeEmpresa As String
    Public TemImpressora As Boolean
    Public ModeloCarne As String
    Public TipoNano As String
    Public PastaSincrinizacao As String
    Public Impressora As String
    'Public EmiteCupom As String
    Public PortaImpressora As String
    Public CodigoProdutoEtiqueta As String
    Public Representante As Boolean = False
    Public TamanhoEtiqueta As String
    Public QtdeEtiqueta As String
    Public ValidarCep As Boolean = True
    Public NomeImpCodigoBarra As String
    Public bolEstoqueBloqueado As Boolean = False
    Public bolSalvo As Boolean
    Public SaldoAtualCaixa As Boolean = False
    Public SaldoAtualCaixaDinheiro As Boolean = False
    Public PortaImpressoraCodigoBarra As String
    Public JurosPorParcela As Integer
    Public PorcentualJuros As Double
    Public OrigemRelease As String
    Public Mensalista As Boolean
    Public intCodLojaDevolucao As Integer
    Public DescontoMaximo As String
    Public ComandoOK As Boolean = True
    Public NovoComandoSQL As String
    Public Tolerancia As Integer
    Public PafEcfNano As Boolean
    Public AcrescentarZeroCodProd As Boolean
    Public ImprimirDireto As Boolean
    Public CodigoBarraCupom As Boolean
    Public AutorizacaoPedido As Boolean
    Public DezPorcento As Boolean
    Public SistemaBloqueado As Boolean
    Public ErroConexaoOnline As Boolean
    Public ImpressaoPedidoCompleto As Boolean
    'Public OcultarAutorizacao As Boolean
    Public SegViaRecibo As Boolean
    Public BaixaPorLote As Boolean = True
    Public BalancaPor As String
    Public AlteraPrecoPedido As Boolean = False
    Public AlteraNomePedido As Boolean = False
    Public ObsPedido As String
    Public TrocoCaixa As Boolean = False
    Public AtuPreCusto As Boolean
    Public HistoricoVersao As String
    'Public ImportaCliProdEmissor As Boolean
    Public PastaCliProdEmissor As String

    Public EmiteNFE As Boolean
    Public PastaNotaNfe As String
    Public PorValorAproximado As String
    Public DeOlhoNoImposto As Boolean
    'Public PastaXML As String
    'Public PastaPDF As String
    'Public NanoNfe As Boolean
    Public SimplesNacional As Boolean
    Public UsaBoleto As Boolean
    Public CaminhoPastaBoleto As String
    Public ObsProduto As Boolean
    Public BuscaCpfCnpj As String
    Public ComissaoProduto As Boolean
    Public CodigoDoAnimal As Integer
    Public DescricaoVenda As String
    Public ObsPedidoVenda As Boolean
    Public CompararFornecedor As Boolean

    Public CodigoBancoBoleto As String
    Public DemonstrativoBanco As String
    Public InstrucaoBanco As String
    Public CodBanco As String
    Public PerMultaBanco As String
    Public PrimeiraInstrucaoBanco As String
    Public SegundaInstrucaoBanco As String
    Public MoraBanco As String
    Public DiasProtestoBanco As String
    Public DiasMoraBanco As String
    Public CaminhoArquivoBoleto As String
    Public AgenciaBanco As String
    Public ContaCorrenteBanco As String
    Public CodigoCedenteBanco As String
    Public CPFCedente As String
    Public NomeCedente As String

    Public BloquearDescontoPorItem As Boolean = False
    Public RelatorioVendaNaVenda As Boolean = False
    Public TresCasasDecimais As Boolean
    Public ComandaPedido As Boolean
    Public BloquearRelatoriosCaixa As Boolean = False

    Public VersaoXmlSAT As String
    Public AbaSatFiscal As Boolean = False
    Public SATFiscal As Boolean
    Public ModeloSAT As String
    Public ModeloImpSAT As String
    Public CaminhoPastaSAT As String
    Public NomeImpSAT As String
    Public ImpDiretoSAT As Boolean
    Public MensImpCupomSAT As Boolean
    Public CpfNaNota As Boolean
    Public ManterPorcProd As Boolean
    Public RegimeSAT As String

    Public DataCompromisso As Date
    Public DescricaoCompromisso As String
    Public LembreteCompromisso As String
    Public SepararEstoqueSetor As String
    Public RetornaEntradaNF As String
    Public ValorMinimoGaxeta As Double
    Public UsaPDV As Boolean = False

    Public VisualizarCobranca As Boolean

    Public ImprimeComanda As Boolean
    Public VendaComComanda As Boolean
    Public SalvarCrediario As Boolean

    Public LocalNFe As String
    Public ImprimeContaPagar As Boolean
    Public EconomiaCupom As Boolean
    Public CodigoVendedor As String
    Public VincularUser As Boolean
    'Public CodFuncUser As Integer
    Public bolStatusPedido As Boolean

    'QUANDO CONFIGURADO PARA AUTOMOTIVO
    Public Funilaria As Boolean
    Public MotoPecas As Boolean
    Public SemCarro As Boolean
    Public CampoPedido As String

    '************************************************************************************************************
    'PAREMETROS DO SISTEMA
    Public VersaoDoSistemaBanco As String

    Public SenhaRegistro As Boolean
    Public NomeDoBancoSql As String
    Public NomeComputador As String

    Public SatTeste As Boolean = False
    'ECF
    Public AssinaturaAC As String

    Public ChavePublica As String
    Public ChavePrivada As String
    Public CNPJECF As String
    Public IEECF As String
    Public ClicheECF As String
    Public TipoECF As String
    Public ModeloECF As String
    Public MarcaECF As String
    Public NumeroSerieECF As String
    Public NumeroEcfECF As String
    Public VersaoSBECF As String
    Public DataSBECF As String
    Public MFAdicionalECF As String
    Public ComputadorECF As String
    Public CodigoEquipamento As String = "032102"
    Public CodConfigECF As String

    Public CodigoMD5ECF As String

    Public EraSystemsCNPJ As String = "14.566.555/0001-00"
    Public EraSystemsIE As String = "ISENTO"
    Public EraSystemsIM As String = ""
    Public EraSystemsRazao As String = "ERASYST SOLUCOES EM INFORMATICA EPP"

    Public NomePAFECF As String = "Nano Caixa"
    Public VersaoPAFECF As String = "1.0.0"

    Public MeiosDePagamento As String
    Public TipoImpressoraFiscal As String

    'clsImprimir

    Public strTraco, strIgual, StringImpressao As String


End Module
