Option Strict Off
Option Explicit On
Module DarumaFramework
    '================================DECLARACOES DARUMA FRAMEWORK ================================'
    '===========                         VARIAVEIS GLOBAIS                             ==========='

    Public iRetorno As Short

    '================================DECLARACOES DARUMA FRAMEWORK ================================'
    '===========                           IMPRESSORAS DUAL                            ==========='


    Public Declare Function iEnviarBMP_DUAL_DarumaFramework Lib "DarumaFramework.dll" (ByVal stArqOrigem As String) As Short
    Public Declare Function iAcionarGaveta_DUAL_DarumaFramework Lib "DarumaFramework.dll" () As Short
    Public Declare Function iImprimirArquivo_DUAL_DarumaFramework Lib "DarumaFramework.dll" (ByVal stPath As String) As Short
    Public Declare Function rStatusGaveta_DUAL_DarumaFramework Lib "DarumaFramework.dll" (ByRef iStatusGaveta As Short) As Short
    Public Declare Function rStatusDocumento_DUAL_DarumaFramework Lib "DarumaFramework.dll" () As Short
    Public Declare Function rStatusImpressora_DUAL_DarumaFramework Lib "DarumaFramework.dll" () As Short
    Public Declare Function regVelocidade_DUAL_DarumaFramework Lib "DarumaFramework.dll" (ByVal stParametro As String) As Short
    Public Declare Function regTermica_DUAL_DarumaFramework Lib "DarumaFramework.dll" (ByVal stParametro As String) As Short
    Public Declare Function regTabulacao_DUAL_DarumaFramework Lib "DarumaFramework.dll" (ByVal stParametro As String) As Short
    Public Declare Function regPortaComunicacao_DUAL_DarumaFramework Lib "DarumaFramework.dll" (ByVal stParametro As String) As Short
    Public Declare Function regModoGaveta_DUAL_DarumaFramework Lib "DarumaFramework.dll" (ByVal stParametro As String) As Short
    Public Declare Function regLinhasGuilhotina_DUAL_DarumaFramework Lib "DarumaFramework.dll" (ByVal stParametro As String) As Short
    Public Declare Function regEnterFinal_DUAL_DarumaFramework Lib "DarumaFramework.dll" (ByVal stParametro As String) As Short
    Public Declare Function regAguardarProcesso_DUAL_DarumaFramework Lib "DarumaFramework.dll" (ByVal stParametro As String) As Short
    Public Declare Function iImprimirTexto_DUAL_DarumaFramework Lib "DarumaFramework.dll" (ByVal stTexto As String, ByVal iTam As Short) As Short
    Public Declare Function iAutenticarDocumento_DUAL_DarumaFramework Lib "DarumaFramework.dll" (ByVal stTexto As String, ByVal stLocal As String, ByVal stTimeOut As String) As Short
    Public Declare Function regCodePageAutomatico_DUAL_DarumaFramework Lib "DarumaFramework.dll" (ByVal stParametro As String) As Short
    Public Declare Function regZeroCortado_DUAL_DarumaFramework Lib "DarumaFramework.dll" (ByVal stParametro As String) As Short



    '================================DECLARACOES DARUMA FRAMEWORK ================================'
    '===========                               TA2000                                  ==========='

    Public Declare Function iEnviarDadosFormatados_TA2000_Daruma Lib "DarumaFramework.dll" (ByVal szTexto As String, ByVal szRetorno As String) As Short
    Public Declare Function regPorta_TA2000_Daruma Lib "DarumaFramework.dll" (ByVal stParametro As String) As Short
    Public Declare Function regAuditoria_TA2000_Daruma Lib "DarumaFramework.dll" (ByVal stParametro As String) As Short
    Public Declare Function regMensagemBoasVindasLinha1_TA2000_Daruma Lib "DarumaFramework.dll" (ByVal stParametro As String) As Short
    Public Declare Function regMensagemBoasVindasLinha2_TA2000_Daruma Lib "DarumaFramework.dll" (ByVal stParametro As String) As Short
    Public Declare Function regMarcadorOpcao_TA2000_Daruma Lib "DarumaFramework.dll" (ByVal stParametro As String) As Short
    Public Declare Function regMascara_TA2000_Daruma Lib "DarumaFramework.dll" (ByVal stParametro As String) As Short
    Public Declare Function regMascaraLetra_TA2000_Daruma Lib "DarumaFramework.dll" (ByVal stParametro As String) As Short
    Public Declare Function regMascaraNumero_TA2000_Daruma Lib "DarumaFramework.dll" (ByVal stParametro As String) As Short
    Public Declare Function regMascaraEco_TA2000_Daruma Lib "DarumaFramework.dll" (ByVal stParametro As String) As Short

    '================================DECLARACOES DARUMA FRAMEWORK ================================'
    '===========                               MIN-200                                 ==========='

    Public Declare Function regLerApagar_MODEM_DarumaFramework Lib "DarumaFramework.dll" (ByVal sParametro As String) As Short
    Public Declare Function regPorta_MODEM_DarumaFramework Lib "DarumaFramework.dll" (ByVal sParametro As String) As Short
    Public Declare Function regThread_MODEM_DarumaFramework Lib "DarumaFramework.dll" (ByVal sParametro As String) As Short
    Public Declare Function regVelocidade_MODEM_DarumaFramework Lib "DarumaFramework.dll" (ByVal sParametro As String) As Short
    Public Declare Function regTempoAlertar_MODEM_DarumaFramework Lib "DarumaFramework.dll" (ByVal sParametro As String) As Short
    Public Declare Function regCaptionWinAPP_MODEM_DarumaFramework Lib "DarumaFramework.dll" (ByVal sParametro As String) As Short
    Public Declare Function regBandejaInicio_MODEM_DarumaFramework Lib "DarumaFramework.dll" (ByVal sParametro As String) As Short

    Public Declare Function eInicializar_MODEM_DarumaFramework Lib "DarumaFramework.dll" () As Short
    Public Declare Function eTrocarBandeja_MODEM_DarumaFramework Lib "DarumaFramework.dll" () As Short
    Public Declare Function eApagarSms_MODEM_DarumaFramework Lib "DarumaFramework.dll" (ByVal iNumeroSMS As Short) As Short

    Public Declare Function rListarSms_MODEM_DarumaFramework Lib "DarumaFramework.dll" () As Short
    Public Declare Function rNivelSinalRecebido_MODEM_DarumaFramework Lib "DarumaFramework.dll" () As Short
    Public Declare Function rReceberSms_MODEM_DarumaFramework Lib "DarumaFramework.dll" (ByVal sIndiceSMS As String, ByVal sNumFone As String, ByVal sData As String, ByVal sHora As String, ByVal sMsg As String) As Short
    Public Declare Function rRetornarImei_MODEM_DarumaFramework Lib "DarumaFramework.dll" (ByVal sIMEI As String) As Short
    Public Declare Function rRetornarOperadora_MODEM_DarumaFramework Lib "DarumaFramework.dll" (ByVal sOperadora As String) As Short
    Public Declare Function tEnviarSms_MODEM_DarumaFramework Lib "DarumaFramework.dll" (ByVal sNumeroTelefone As String, ByVal sMensagem As String) As Short

    Public Declare Function tEnviarDadosCsd_MODEM_DarumaFramework Lib "DarumaFramework.dll" (ByVal sParametro As String) As Short
    Public Declare Function rReceberDadosCsd_MODEM_DarumaFramework Lib "DarumaFramework.dll" (ByVal sParametro As String) As Short
    Public Declare Function eAtivarConexaoCsd_MODEM_DarumaFramework Lib "DarumaFramework.dll" () As Short
    Public Declare Function eFinalizarChamadaCsd_MODEM_DarumaFramework Lib "DarumaFramework.dll" () As Short
    Public Declare Function eRealizarChamadaCsd_MODEM_DarumaFramework Lib "DarumaFramework.dll" (ByVal sParametro As String) As Short



    '================================DECLARACOES DARUMA FRAMEWORK ================================'
    '===========                          DARUMAFRAMEWORK                              ==========='

    Public Declare Function eDefinirProduto_Daruma Lib "DarumaFramework.dll" (ByVal sProduto As String) As Short
    Public Declare Function regRetornaValorChave_DarumaFramework Lib "DarumaFramework.dll" (ByVal sProduto As String, ByRef sChave As String, ByVal sValor As String) As Short

    Public Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
End Module