Imports System.Collections.Generic
Imports System.Text
Imports System.Runtime.InteropServices
Public Class DarumaFiscal
    Public Retorno As Short
    Public Shared iRetorno As Integer
    Public Shared sBuffer As String = String.Empty
    Public Shared Str_LabelInputBox As String, Str_TextoInputBox As String, Str_Retorno_InputBox As String
    Public Shared Str_Aleatorio As String
    Public Shared iAleatorio As Integer
    Public Shared Sub TrataRetorno(ByVal intRetorno As Integer)
        Dim Str_Msg_Retorno_Metodo As New StringBuilder(" ", 300)
        Dim Str_Msg_NumErro As New StringBuilder(" ", 300)
        Dim Str_Msg_NumAviso As New StringBuilder(" ", 300)
        Str_Msg_Retorno_Metodo.Length = 300
        Str_Msg_NumErro.Length = 300
        Str_Msg_NumAviso.Length = 300

        eRetornarAvisoErroUltimoCMD_ECF_Daruma(Str_Msg_NumAviso, Str_Msg_NumErro)
        eInterpretarRetorno_ECF_Daruma(intRetorno, Str_Msg_Retorno_Metodo)

        Dim strTexto As String = Convert.ToString(Str_Msg_Retorno_Metodo)
        If strTexto <> "Operação realizada com sucesso" Then
            System.Windows.Forms.MessageBox.Show("Retorno do Metodo = " & Convert.ToString(Str_Msg_Retorno_Metodo) & vbCr & vbLf & "Num.Erro = " & Convert.ToString(Str_Msg_NumErro) & vbCr & vbLf & "Num.Aviso= " & Convert.ToString(Str_Msg_NumAviso), "Daruma Framework Retorno do Metodo")
        End If
    End Sub

    <DllImport("DarumaFrameWork.dll")> _
           Public Shared Function eInterpretarErro_ECF_Daruma(ByVal iErro As Integer, ByVal pszDescErro As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eInterpretarAviso_ECF_Daruma(ByVal iAviso As Integer, ByVal pszDescAviso As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eRetornarAvisoErroUltimoCMD_ECF_Daruma(ByVal sAviso As StringBuilder, ByVal sErro As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eInterpretarRetorno_ECF_Daruma(ByVal iRetorno As Integer, ByVal pszDescRet As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eAguardarRecepcao_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eAuditar_Daruma(ByVal cAuditoria As String, ByVal iFlag As Integer) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eAuditar(ByVal pszAuditoria As String, ByVal iFlag As Integer) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eCancelaComunicacao_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eDefinirProduto(ByVal pszProduto As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eDefinirModoRegistro_Daruma(ByVal intiTipo As Integer) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eVerificarVersaoDLL_Daruma(ByVal pszRet As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eVerificarVersaoDLL_Daruma(ByVal pszRet As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regLogin_Daruma(ByVal pszPDV As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regLogin(ByVal pszPDV As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regRetornaValorChave_DarumaFramework(ByVal pszProduto As String, ByVal pszChave As String, ByVal pszValor As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regRetornaValorChave(ByVal pszProduto As String, ByVal pszChave As String, ByVal pszValor As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regAlteraValorChave_DarumaFramework(ByVal pszProduto As String, ByVal pszChave As String, ByVal pszValor As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regAlteraValorChave(ByVal pszProduto As String, ByVal pszChave As String, ByVal pszValor As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regAlterarValor_Daruma(ByVal pszChave As String, ByVal pszValor As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regAtoCotepe_Daruma(ByVal pszChave As String, ByVal pszValor As String) As Integer
    End Function


    ' --- Especiais - Fim ---

    'Lei DE OLHO no Imposto
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rCFVrImposto_ECF_Daruma(ByVal pszNumItem As String, ByVal pszNCM As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function confCFNCM_ECF_Daruma(ByVal pszCodigoNCM As String, ByVal pszTipo As String) As Integer
    End Function

    'FUNCOES ECF 
    ' Abertura de cupom fiscal
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFAbrir_ECF_Daruma(ByVal pszCPF As String, ByVal pszNome As String, ByVal pszEndereco As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFAbrirPadrao_ECF_Daruma() As Integer
    End Function

    ' Registro de item
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFVender_ECF_Daruma(ByVal pszCargaTributaria As String, ByVal pszQuantidade As String, ByVal pszPrecoUnitario As String, ByVal pszTipoDescAcresc As String, ByVal pszValorDescAcresc As String, ByVal pszCodigoItem As String, _
     ByVal pszUnidadeMedida As String, ByVal pszDescricaoItem As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFVenderSemDesc_ECF_Daruma(ByVal pszCargaTributaria As String, ByVal pszQuantidade As String, ByVal pszPrecoUnitario As String, ByVal pszCodigoItem As String, ByVal pszUnidadeMedida As String, ByVal pszDescricaoItem As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFVenderResumido_ECF_Daruma(ByVal pszCargaTributaria As String, ByVal pszPrecoUnitario As String, ByVal pszCodigoItem As String, ByVal pszDescricaoItem As String) As Integer
    End Function

    ' Desconto ou acrescimo  em item de cupom fiscal
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function fnCFLancarDescAcrescItem_ECF_Daruma(ByVal pszNumItem As String, ByVal pszTipoDescAcresc As String, ByVal pszValorDescAcresc As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFLancarAcrescimoItem_ECF_Daruma(ByVal pszNumItem As String, ByVal pszTipoDescAcresc As String, ByVal pszValorDescAcresc As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFLancarDescontoItem_ECF_Daruma(ByVal pszNumItem As String, ByVal pszTipoDescAcresc As String, ByVal pszValorDescAcresc As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFLancarAcrescimoUltimoItem_ECF_Daruma(ByVal pszTipoDescAcresc As String, ByVal pszValorDescAcresc As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFLancarDescontoUltimoItem_ECF_Daruma(ByVal pszTipoDescAcresc As String, ByVal pszValorDescAcresc As String) As Integer
    End Function

    ' Cancelamento total de item em cupom fiscal
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFCancelarItem_ECF_Daruma(ByVal pszNumItem As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFCancelarUltimoItem_ECF_Daruma() As Integer
    End Function

    ' Cancelamento parcial de item em cupom fiscal
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFCancelarItemParcial_ECF_Daruma(ByVal pszNumItem As String, ByVal pszQuantidade As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFCancelarUltimoItemParcial_ECF_Daruma(ByVal pszQuantidade As String) As Integer
    End Function

    ' Cancelamento de desconto em item
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFCancelarDescontoItem_ECF_Daruma(ByVal pszNumItem As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFCancelarDescUltimoItem_ECF_Daruma() As Integer
    End Function

    ' Cancelamento de acrescimo em item
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFCancelarAcrescimoItem_ECF_Daruma(ByVal pszNumItem As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFCancelarAcrescimoUltimoItem_ECF_Daruma() As Integer
    End Function

    ' Totalizacao de cupom fiscal
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFTotalizarCupom_ECF_Daruma(ByVal pszTipoDescAcresc As String, ByVal pszValorDescAcresc As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFTotalizarCupomPadrao_ECF_Daruma() As Integer
    End Function

    'Cancelamento de desconto e acrescimo em subtotal de cupom fiscal
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFCancelarDescontoSubtotal_ECF_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFCancelarAcrescimoSubtotal_ECF_Daruma() As Integer
    End Function

    'Descricao do meios de pagamento de cupom fiscal
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFEfetuarPagamentoPadrao_ECF_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFEfetuarPagamentoFormatado_ECF_Daruma(ByVal pszFormaPgto As String, ByVal pszValor As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFEfetuarPagamento_ECF_Daruma(ByVal pszFormaPgto As String, ByVal pszValor As String, ByVal pszInfoAdicional As String) As Integer
    End Function

    'Saldo a Pagar
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rCFSaldoAPagar_ECF_Daruma(ByVal pszValor As StringBuilder) As Integer
    End Function

    'SubTotal
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rCFSubTotal_ECF_Daruma(ByVal pszValor As StringBuilder) As Integer
    End Function

    'Encerramento de cupom fiscal
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFEncerrarPadrao_ECF_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFEncerrarConfigMsg_ECF_Daruma(ByVal pszMensagem As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFEncerrar_ECF_Daruma(ByVal pszCupomAdicional As String, ByVal pszMensagem As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFEncerrarResumido_ECF_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFEmitirCupomAdicional_ECF_Daruma() As Integer
    End Function

    'Cancelamento de cupom fiscal
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFCancelar_ECF_Daruma() As Integer
    End Function

    'Status Cupom Fiscal
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rCFVerificarStatus_ECF_Daruma(ByVal cStatusCF As StringBuilder, ByRef piStatusCF As Integer) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rCFVerificarStatusInt_ECF_Daruma(ByRef iStatusCF As Integer) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rRGVerificarStatus_ECF_Daruma(ByVal sStatusRG As StringBuilder, ByVal iStatusRG As Integer) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
  Public Shared Function rCFVerificarStatusStr_ECF_Daruma(ByVal cStatusCF As StringBuilder) As Integer
    End Function

    'Identificar consumidor radape do Cupom fiscal
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFIdentificarConsumidor_ECF_Daruma(ByVal pszNome As String, ByVal pszEndereco As String, ByVal pszDoc As String) As Integer
    End Function

    'Cupom Mania
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rCMEfetuarCalculo_ECF_Daruma(ByVal pszISS As StringBuilder, ByVal pszICMS As StringBuilder) As Integer
    End Function

    'Bilhete Passagem
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFBPAbrir_ECF_Daruma(ByVal pszOrigem As String, ByVal pszDestino As String, ByVal pszUFDestino As String, ByVal pszPercurso As String, ByVal pszPrestadora As String, ByVal pszPlataforma As String, _
     ByVal pszPoltrona As String, ByVal pszModalidadetransp As String, ByVal pszCategoriaTransp As String, ByVal pszDataEmbarque As String, ByVal pszRGPassageiro As String, ByVal pszNomePassageiro As String, _
     ByVal pszEnderecoPassageiro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCFBPVender_ECF_Daruma(ByVal pszAliquota As String, ByVal pszValor As String, ByVal pszTipoDescAcresc As String, ByVal pszValorDescAcresc As String, ByVal pszDescricao As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function confCFBPProgramarUF_ECF_Daruma(ByVal pszUF As String) As Integer
    End Function

    'Download Memórias	
    'Espelho MFD 
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rEfetuarDownloadMFD_ECF_Daruma(ByVal pszTipo As String, ByVal pszInicial As String, ByVal pszFinal As String, ByVal pszNomeArquivo As String) As Integer
    End Function

    'Espelho MFD 
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rGerarEspelhoMFD_ECF_Daruma(ByVal pszTipo As String, ByVal pszInicial As String, ByVal pszFinal As String) As Integer
    End Function

    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rEfetuarDownloadMF_ECF_Daruma(ByVal pszNomeArquivo As String) As Integer
    End Function

    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rEfetuarDownloadTDM_ECF_Daruma(ByVal pszTipo As String, ByVal pszInicial As String, ByVal pszFinal As String, ByVal pszNomeArquivo As String) As Integer
    End Function

    ' Relatorios PAF-ECF
    'Relatório PAF-ECF ON-line	
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rGerarRelatorio_ECF_Daruma(ByVal pszRelatorio As String, ByVal pszTipo As String, ByVal pszInicial As String, ByVal pszFinal As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rGerarMapaResumo_ECF_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rGerarMF_ECF_Daruma(ByVal sTipo As String, ByVal pszInicial As String, ByVal pszFinal As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rGerarMFD_ECF_Daruma(ByVal pszTipo As String, ByVal pszInicial As String, ByVal pszFinal As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rGerarTDM_ECF_Daruma(ByVal pszTipo As String, ByVal pszInicial As String, ByVal pszFinal As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rGerarSPED_ECF_Daruma(ByVal pszTipo As String, ByVal pszInicial As String, ByVal pszFinal As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rGerarSINTEGRA_ECF_Daruma(ByVal pszTipo As String, ByVal pszInicial As String, ByVal pszFinal As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rGerarNFP_ECF_Daruma(ByVal pszTipo As String, ByVal pszInicial As String, ByVal pszFinal As String) As Integer
    End Function


    'Relatório PAF-ECF Off-line
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rGerarRelatorioOffline_ECF_Daruma(ByVal szRelatorio As String, ByVal szTipo As String, ByVal szInicial As String, ByVal szFinal As String, ByVal szArquivo_MF As String, ByVal szArquivo_MFD As String, _
     ByVal szArquivo_INF As String) As Integer
    End Function

    'Métodos PAF-ECF
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rAssinarRSA_ECF_Daruma(ByVal pszPathArquivo As String, ByVal pszChavePrivada As String, ByVal pszAssinaturaGerada As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rCalcularMD5_ECF_Daruma(ByVal pszPathArquivo As String, ByVal pszMD5GeradoHex As StringBuilder, ByVal pszMD5GeradoAscii As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rRetornarGTCodificado_ECF_Daruma(ByVal pszGTCodificado As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rVerificarGTCodificado_ECF_Daruma(ByVal pszGTCodificado As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eRSAAssinarArquivo_ECF_Daruma(ByVal arquivo As String, ByVal chave As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rRSAChavePublica_ECF_Daruma(ByVal sChavePrivada As String, ByVal sChavePublica As StringBuilder, ByVal szExpoente As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eMemoriaFiscal_ECF_Daruma(ByVal sInicial As String, ByVal sFinal As String, ByVal sCompleta As Boolean, ByVal sTipo As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function confModoPAF_ECF_Daruma(ByVal sAtivar As String, ByVal sChaveRSA As String, ByVal sArquivos As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function ePAFCadastrar_ECF_Daruma(ByVal sNomeArquivo As String, ByVal sChave As String, ByVal sNumSerieECF As String, ByVal sGT As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function ePAFAtualizarGT_ECF_Daruma(ByVal sNomeArquivo As String, ByVal sChave As String, ByVal sNumSerieECF As String, ByVal sGT As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rLerArqRegistroPAF_ECF_Daruma(ByVal sCaminho As String, ByVal sChave As String, ByVal sReturn As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function ePAFValidarDados_ECF_Daruma(ByVal sNomeArquivo As String, ByVal sChave As String, ByVal sNumSerieECF As String, ByVal sGT As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rCodigoModeloFiscal_ECF_Daruma(ByVal sValor As StringBuilder) As Integer
    End Function

    'Codigo de Barras
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iImprimirCodigoBarras_ECF_Daruma(ByVal pszTipo As String, ByVal pszLargura As String, ByVal pszAltura As String, ByVal pszImprTexto As String, ByVal pszCodigo As String, ByVal pszOrientacao As String, _
     ByVal pszTextoLivre As String) As Integer
    End Function

    ' --- ECF - Relatorio Gerencial - Inicio --- 
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iRGAbrir_ECF_Daruma(ByVal pszNomeRG As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iRGAbrirIndice_ECF_Daruma(ByVal iIndiceRG As Integer) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iRGAbrirPadrao_ECF_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iRGImprimirTexto_ECF_Daruma(ByVal pszTexto As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iRGImprimirArquivo_ECF_Daruma(ByVal pszCaminho As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iRGFechar_ECF_Daruma() As Integer
    End Function
    ' --- ECF - Relatorio Gerencial - Fim --- 

    ' --- ECF - Comprovante de CD - Inicio --- 
    ' Abertura de comprovante de credito e debito
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCCDAbrir_ECF_Daruma(ByVal pszFormaPgto As String, ByVal pszParcelas As String, ByVal pszDocOrigem As String, ByVal pszValor As String, ByVal pszCPF As String, ByVal pszNome As String, _
     ByVal pszEndereco As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCCDAbrirSimplificado_ECF_Daruma(ByVal pszFormaPgto As String, ByVal pszParcelas As String, ByVal pszDocOrigem As String, ByVal pszValor As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCCDAbrirPadrao_ECF_Daruma() As Integer
    End Function

    ' Impressao de texto no comprovante de credito e debito
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCCDImprimirTexto_ECF_Daruma(ByVal pszTexto As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCCDImprimirArquivo_ECF_Daruma(ByVal pszArqOrigem As String) As Integer
    End Function

    ' Fechamento de texto no comprovante de credito e debito
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCCDFechar_ECF_Daruma() As Integer
    End Function

    ' Estorno de comprovante de credito e debito
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCCDEstornarPadrao_ECF_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCCDEstornar_ECF_Daruma(ByVal pszCOO As String, ByVal pszCPF As String, ByVal pszNome As String, ByVal pszEndereco As String) As Integer
    End Function

    ' Segunda Via comprovante de credito e debito
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCCDSegundaVia_ECF_Daruma() As Integer
    End Function

    'Métodos para TEF
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iTEF_ImprimirResposta_ECF_Daruma(ByVal szArquivo As [String], ByVal bTravarTeclado As [Boolean]) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iTEF_ImprimirRespostaCartao_ECF_Daruma(ByVal szArquivo As String, ByVal bTravarTeclado As [Boolean], ByVal szForma As String, ByVal szValor As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iTEF_Fechar_ECF_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eTEF_EsperarArquivo_ECF_Daruma(ByVal szArquivo As [String], ByVal iTempo As Integer, ByVal bTravar As [Boolean]) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eTEF_TravarTeclado_ECF_Daruma(ByVal bTravar As [Boolean]) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eTEF_SetarFoco_ECF_Daruma(ByVal szNomeTela As [String]) As Integer
    End Function

    ' --- ECF - Leitura Memoria Fiscal - Inicio --- 
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iMFLerSerial_ECF_Daruma(ByVal pszInicial As String, ByVal pszFinal As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iMFLer_ECF_Daruma(ByVal pszInicial As String, ByVal pszFinal As String) As Integer
    End Function

    ' --- ECF - Comprovante não fiscal - Inicio --- 
    ' Abertura de comprovante nao fiscal
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCNFAbrir_ECF_Daruma(ByVal pszCPF As String, ByVal pszNome As String, ByVal pszEndereco As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCNFAbrirPadrao_ECF_Daruma() As Integer
    End Function

    ' Recebimento de itens
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCNFReceber_ECF_Daruma(ByVal pszIndice As String, ByVal pszValor As String, ByVal pszTipoDescAcresc As String, ByVal pszValorDescAcresc As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCNFReceberSemDesc_ECF_Daruma(ByVal pszIndice As String, ByVal pszValor As String) As Integer
    End Function

    'Cancelamento de item
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCNFCancelarItem_ECF_Daruma(ByVal pszNumItem As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCNFCancelarUltimoItem_ECF_Daruma() As Integer
    End Function

    'Cancelamento de acrescimo em item
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCNFCancelarAcrescimoItem_ECF_Daruma(ByVal pszNumItem As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCNFCancelarAcrescUltimoItem_ECF_Daruma() As Integer
    End Function

    ' Cancelamento de desconto em item
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCNFCancelarDescontoItem_ECF_Daruma(ByVal pszNumItem As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCNFCancelarDescUltimoItem_ECF_Daruma() As Integer
    End Function

    ' Totalizacao de CNF
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCNFTotalizarComprovante_ECF_Daruma(ByVal pszTipoDescAcresc As String, ByVal pszValorDescAcresc As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCNFTotalizarComprovantePadrao_ECF_Daruma() As Integer
    End Function

    ' Cancelamento de desconto e acrescimo em subtotal de CNF
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCNFCancelarAcrescimoSubtotal_ECF_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCNFCancelarDescontoSubtotal_ECF_Daruma() As Integer
    End Function


    ' Descricao do meios de pagamento de CNF
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCNFEfetuarPagamento_ECF_Daruma(ByVal pszFormaPgto As String, ByVal pszValor As String, ByVal pszInfoAdicional As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCNFEfetuarPagamentoFormatado_ECF_Daruma(ByVal pszFormaPgto As String, ByVal pszValor As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCNFEfetuarPagamentoPadrao_ECF_Daruma() As Integer
    End Function

    ' Encerramento de CNF
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCNFEncerrar_ECF_Daruma(ByVal pszMensagem As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCNFEncerrarPadrao_ECF_Daruma() As Integer
    End Function

    'Cancelamento de CNF
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iCNFCancelar_ECF_Daruma() As Integer
    End Function

    ' --- ECF - Comprovante não fiscal - Fim ---

    ' --- ECF - Funcoes Gerais - Inicio --- 
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iEjetarCheque_ECF_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iImprimir_CHEQUE_Daruma(ByVal pszNumeroBanco As String, ByVal pszCidade As String, ByVal pszData As String, ByVal pszNomeFavorecido As String, ByVal pszTextoFrente As String, ByVal pszValorCheque As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iImprimirVertical_CHEQUE_Daruma(ByVal pszNumeroBanco As String, ByVal pszCidade As String, ByVal pszData As String, ByVal pszNomeFavorecido As String, ByVal pszTextoFrente As String, ByVal pszValorCheque As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iImprimirVerso_CHEQUE_Daruma(ByVal pszTexto As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function confCorrigirGeometria_CHEQUE_Daruma(ByVal pszNumeroBanco As String, ByVal pszDistValorNumerico As String, ByVal pszColunaValorNumerico As String, ByVal pszDistPrimExtenso As String, ByVal pszColunaPrimExtenso As String, ByVal pszDistSegExtenso As String, ByVal pszColunaSegExtenso As String, ByVal pszDistFavorecido As String, ByVal pszColunaFavorecido As String, ByVal pszDistCidade As String, ByVal pszColunaCidade As String, ByVal pszColunaDia As String, ByVal pszColunaMes As String, ByVal pszColunaAno As String, ByVal pszLinhaAutenticacao As String, ByVal pszColunaAutenticacao As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
   Public Shared Function iAutenticar_CHEQUE_Daruma(ByVal pszPosicao As String, ByVal psztexto As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iAtributo_CHEQUE_Daruma(ByVal pszModo As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eEjetarCheque_ECF_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iEstornarPagamento_ECF_Daruma(ByVal pszFormaPgtoEstornado As String, ByVal pszFormaPgtoEfetivado As String, ByVal pszValor As String, ByVal pszInfoAdicional As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eAcionarGuilhotina_ECF_Daruma(ByVal pszTipoCorte As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eCarregarBitmapPromocional_ECF_Daruma(ByVal sPathLogotipo As String, ByVal NumBitmap As String, ByVal Orientacao As String) As Integer
    End Function

    ' Leitura X
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function fnLeituraX_ECF_Daruma(ByVal iTipo As Integer, ByVal pszCaminho As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iLeituraX_ECF_Daruma() As Integer
    End Function

    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rLeituraX_ECF_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rLeituraXCustomizada_ECF_Daruma(ByVal pszCaminho As String) As Integer
    End Function

    ' Sangria
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iSangriaPadrao_ECF_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iSangria_ECF_Daruma(ByVal pszValor As String, ByVal pszMensagem As String) As Integer
    End Function

    ' Suprimento
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iSuprimentoPadrao_ECF_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iSuprimento_ECF_Daruma(ByVal pszValor As String, ByVal pszMensagem As String) As Integer
    End Function

    ' Reducao Z
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iReducaoZ_ECF_Daruma(ByVal NamelessParameter1 As String, ByVal NamelessParameter2 As String) As Integer
    End Function

    ' Acionamento da Gaveta do ECF
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eAbrirGaveta_ECF_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rStatusGaveta_ECF_Daruma(ByRef iStatus As Integer) As Integer
    End Function

    ' Programação do ECF
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function confCadastrarPadrao_ECF_Daruma(ByVal pszCadastrar As String, ByVal pszValor As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function confCadastrar_ECF_Daruma(ByVal pszCadastrar As String, ByVal pszValor As String, ByVal pszSeparador As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function confHabilitarHorarioVerao_ECF_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function confDesabilitarHorarioVerao_ECF_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function confProgramarOperador_ECF_Daruma(ByVal pszValor As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function confProgramarIDLoja_ECF_Daruma(ByVal pszValor As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function confProgramarAvancoPapel_ECF_Daruma(ByVal pszSepEntreLinhas As String, ByVal pszSepEntreDoc As String, ByVal pszLinhasGuilhotina As String, ByVal pszGuilhotina As String, ByVal pszImpClicheAntecipada As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function confHabilitarModoPreVenda_ECF_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function confDesabilitarModoPreVenda_ECF_Daruma() As Integer
    End Function

    ' Funcoes - WebService
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eWsStatus_ECF_Daruma(ByRef iRespostaWS As Integer) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eWsEnviarCupom_ECF_Daruma(ByVal pszCPF As String, ByVal pszNomeFantasia As String, ByVal pszIndiceSegmento As String, ByVal pszCCF As String, ByVal szData As String, ByVal pszHora As String, ByVal pszValor As String, ByVal pszISS As String, ByVal pszICMS As String, ByVal pszReservado As String, ByVal iSyncAssync As Integer, ByRef iRespostaWS As Integer) As Integer
    End Function

    ' Funcoes - Retorno
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rLerAliquotas_ECF_Daruma(ByVal cAliquotas As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rLerMeiosPagto_ECF_Daruma(ByVal pszRelatorios As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rLerRG_ECF_Daruma(ByVal pszRelatorios As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rLerDecimais_ECF_Daruma(ByVal pszDecimalQtde As StringBuilder, ByVal pszDecimalValor As StringBuilder, ByRef piDecimalQtde As Integer, ByRef piDecimalValor As Integer) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rLerCNF_ECF_Daruma(ByVal pszDecimalQtde As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rLerDecimaisInt_ECF_Daruma(ByRef piDecimalQtde As Integer, ByRef piDecimalValor As Integer) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rLerDecimaisStr_ECF_Daruma(ByVal pszDecimalQtde As StringBuilder, ByVal pszDecimalValor As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rDataHoraImpressora_ECF_Daruma(ByVal pszData As StringBuilder, ByVal pszHora As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rVerificarImpressoraLigada_ECF_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rStatusImpressora_ECF_Daruma(ByVal pszStatus As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rStatusImpressoraStr_ECF_Daruma(ByVal pszStatus As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rStatusImpressoraInt_ECF_Daruma(ByRef piStatusEcf As Integer) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rInfoEstendida_ECF_Daruma(ByVal NamelessParameter1 As Integer, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef NamelessParameter2 As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rInfoEstentida1_ECF_Daruma(ByVal cInfoEx As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rInfoEstentida2_ECF_Daruma(ByVal cInfoEx As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rInfoEstentida3_ECF_Daruma(ByVal cInfoEx As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rInfoEstentida4_ECF_Daruma(ByVal cInfoEx As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rInfoEstentida5_ECF_Daruma(ByVal cInfoEx As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rVerificarReducaoZ_ECF_Daruma(ByVal zPendente As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rRetornarVendaBruta_ECF_Daruma(ByVal sRetorno As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rRetornarVendaLiquida_ECF_Daruma(ByVal sVendaLiquida As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rMinasLegal_ECF_Daruma(ByVal sRetorno As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rCompararDataHora_ECF_Daruma(ByRef iDiferenca As Integer) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rInfoCNF_ECF_Daruma(ByVal sRetorno As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rStatusUltimoCmd_ECF_Daruma(ByVal pszErro As StringBuilder, ByVal pszAviso As StringBuilder, ByRef piErro As Integer, ByRef piAviso As Integer) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rStatusUltimoCmdInt_ECF_Daruma(ByRef piErro As Integer, ByRef piAviso As Integer) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rUltimoCMDEnviado_ECF_Daruma(ByVal ultimoCMD As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rTipoUltimoDocumentoStr_ECF_Daruma(ByVal ultimoDOC As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rTipoUltimoDocumentoInt_ECF_Daruma(ByVal ultimoDOC As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iRelatorioConfiguracao_ECF_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rConsultaStatusImpressoraInt_ECF_Daruma(ByVal iIndice As Integer, ByRef IStatus As Integer) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rConsultaStatusImpressoraStr_ECF_Daruma(ByVal iIndice As Integer, ByVal StrStatus As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rStatusImpressoraBinario_ECF_Daruma(ByVal Status As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rRetornarInformacaoSeparador_ECF_Daruma(ByVal pszIndice As String, ByVal pszVSignificativo As String, ByVal pszRetornar As StringBuilder) As Integer
    End Function



    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rStatusUltimoCmdStr_ECF_Daruma(ByVal cErro As StringBuilder, ByVal cAviso As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rRetornarInformacao_ECF_Daruma(ByVal pszIndice As String, ByVal pszRetornar As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rRetornarNumeroSerieCodificado_ECF_Daruma(ByVal pszSerialCriptografado As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rVerificarNumeroSerieCodificado_ECF_Daruma(ByVal pszSerialCriptografado As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rCarregarNumeroSerie_ECF_Daruma(ByVal pszSerial As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rRetornarDadosReducaoZ_ECF_Daruma(ByVal pszDados As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rRegistrarNumeroSerie_ECF_Daruma() As Integer
    End Function



    ' --- ECF - Funcoes Gerais - Fim ---

    ' --- ECF - Especiais - Inicio --- 

    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eAguardarCompactacao_ECF_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eBuscarPortaVelocidade_ECF_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eEnviarComando_ECF_Daruma(ByVal cComando As String, ByVal iTamanhoComando As Integer, ByVal iType As Integer) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eRetornarAviso_ECF_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eRetornarErro_ECF_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eRetornarPortasCOM_ECF_Daruma(ByVal PortasCOM As StringBuilder) As Integer
    End Function


    ' --- ECF - Especiais - Fim --- 


    ' --- ECF - Registro - Inicio --- 
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regCCDDocOrigem_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regCCDFormaPgto_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regCCDLinhasTEF_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regCCDParcelas_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regCCDValor_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regCFFormaPgto_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regCFMensagemPromocional_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regCFQuantidade_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regCFTamanhoMinimoDescricao_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regCFTipoDescAcresc_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regCFUnidadeMedida_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regCFValorDescAcresc_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regCFCupomAdicional_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regCFCupomMania(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regCFCupomAdicionalDllConfig_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regCFCupomAdicionalDllTitulo_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regChequeXLinha1_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regChequeXLinha2_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regChequeXLinha3_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regChequeYLinha1_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regChequeYLinha2_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regChequeYLinha3_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regCompatStatusFuncao_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regMaxFechamentoAutomatico_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function

    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regECFAguardarImpressao_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regECFArquivoLeituraX_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regECFAuditoria_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regECFCaracterSeparador_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regECFMaxFechamentoAutomatico_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regECFReceberAvisoEmArquivo_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regECFReceberErroEmArquivo_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regECFReceberInfoEstendida_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regECFReceberInfoEstendidaEmArquivo_ECF_Daruma(ByVal pszParametro As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regAtocotepe_ECF_Daruma(ByVal pszParametro1 As String, ByVal pszParametro2 As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eDefinirModoRegistro_Daruma(ByVal pszParametro As String) As Integer
    End Function
End Class
