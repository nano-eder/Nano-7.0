Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Runtime.InteropServices

Public Class clsDarumaSatDLL

    ' Metodos utilitarios e DUAL
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eVerificarVersaoDLL_Daruma(ByVal strRet As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function eBuscarPortaVelocidade_DUAL_DarumaFramework() As Integer
    End Function
    'Metodos de emissao CFe
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function aCFAbrir_SAT_Daruma(ByVal strCPF As String, ByVal strNome As String, ByVal strEndereco As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function aCFVender_SAT_Daruma(ByVal strCargaTributaria As String, ByVal strQuantidade As String, ByVal strPrecoUnitario As String, ByVal strTipoDescAcresc As String, ByVal strValorDescAcresc As String, ByVal strCodigoItem As String, ByVal strUnidadeMedida As String, ByVal strDescricaoItem As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function aCFTotalizar_SAT_Daruma(ByVal strTipoDescAcresc As String, ByVal strValorDescAcresc As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function aCFEfetuarPagamento_SAT_Daruma(ByVal strFormaPgto As String, ByVal strValor As String, ByVal strInfoAdicional As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function tCFEncerrar_SAT_Daruma(ByVal strCupomAdicional As String, ByVal strInfoAdic As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function tCFeCancelar_SAT_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function tCFeCancelarParametrizado_SAT_Daruma(ByVal szCpfCnpjConsumidor As String, ByVal szChaveConsulta As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function aCFeCancelarItem_SAT_Daruma(ByVal iNumItem As Integer) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function aCFeCancelarFormaPagamento_SAT_Daruma(ByVal iNumFormaPagamento As Integer) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function aCFEstornarPagamento_SAT_Daruma(ByVal strFormaPgtoEstorno As String, ByVal strFormaPgtoEfetivado As String, ByVal strValor As String) As Integer
    End Function
    ' Metodos de consulta e retorno de informacao
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rVerificarComunicacao_SAT_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rConsultarStatus_SAT_Daruma(ByVal strRetornoSAT As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rConsultarStatusEspecifico_SAT_Daruma(ByVal strCampo As String, ByVal strRetornoSAT As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rConsultarArqCopSeguranca_SAT_Daruma(ByVal strArqCopSeg As StringBuilder) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function rInfoEstendida_SAT_Daruma(ByVal strIndice As String, ByVal strRetorno As StringBuilder) As Integer
    End Function
    ' Metodo de impressao
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function iReimprimirUltimoCFe_SAT_Daruma() As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
  Public Shared Function iCFImprimirParametrizado_NFCe_Daruma(ByVal pszPathXMLVenda As String, ByVal pszPathRetornoWS As String, ByVal pszLinkQrCode As String, ByVal iNumColunas As Integer, ByVal iTipoNF As Integer, ByVal pszParametros As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
  Public Shared Function iImprimirCFe_SAT_Daruma(ByVal strPathXmlSAT As String, ByVal strTipo As String) As Integer
    End Function
    ' Metodos de configuracao e XML
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function tCFeAssociarAssinatura_SAT_Daruma(ByVal strTagsSAT As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regAlterarValor_SAT_Daruma(ByVal strTagSAT As String, ByVal strValorTagSAT As String) As Integer
    End Function
    <DllImport("DarumaFrameWork.dll")> _
    Public Shared Function regRetornarValor_SAT_Daruma(ByVal strTagSAT As String, ByVal strValorRetTagSAT As StringBuilder) As Integer
    End Function

    Public Shared Function TrataRetorno(ByVal iRetMetodo As Integer) As String
        Select Case iRetMetodo
            Case 1
                Return "[1] - Comando executado com sucesso!"
            Case 0
                Return "[0] - M�todo n�o executado/ Tag inv�lida/ N�o foi poss�vel comunicar com impressora"
                'retorno 0, depende do m�todo que foi chamado tem significado diferente.
            Case -6
                Return "[-6] - TimeOut, erro de comunica��o com o SAT"
            Case -7
                Return "[-7] - Erro ao abrir comunica��o com o SAT"
            Case -40
                Return "[-40] - Tag XML inv�lida"
            Case -50
                Return "[-50] - Impressora off-Line"
            Case -51
                Return "[-51] - Impressora sem papel"
            Case -99
                Return "[-99] - Par�metro inv�lido ou ponteiro nulo de par�metro"
            Case -120
                Return "[-120] - Encontrada tag inv�lida"
            Case -121
                Return "[-121] - Estrutura Invalida"
            Case -122
                Return "[-122] - Tag obrigat�ria n�o foi informada"
            Case -123
                Return "[-123] - Tag obrigat�ria n�o tem valor preenchido"
            Case -130
                Return "[-130] - CFe j� aberto"
            Case -131
                Return "[-131] - CFe n�o aberto"
            Case -132
                Return "[-132] - CFe n�o em fase de venda"
            Case -133
                Return "[-133] - CFe n�o em fase de totaliza��o"
            Case -134
                Return "[-134] - CFe n�o em fase de pagamento"
            Case -135
                Return "[-135] - CFe n�o em fase de encerramento"
            Case -136
                Return "[-136] - CFe em estado inv�lido para opera��o"
            Case -140
                Return "[-140] - Biblioteca auxiliar SAT.dll n�o foi encontrada/carregada"
            Case -141
                Return "[-141] - Impressora inv�lida (modelo deve ser DR700 ou vers�o incompativel)"
            Case -142
                Return "[-142] - Resposta Incompleta do SAT"
                ''' Os c�digos de erro abaixo s�o retornados pelo SAT  para verificar mais retornos consulte a Especifica��o de Requisitos do SAT vigente.
            Case 1084
                Return "[1084] - Formato do Certificado Inv�lido"
            Case 1085
                Return "[1085] - Assinatura do Aplicativo Comercial n�o confere"
            Case 1218
                Return "[1218] - CF-e-SAT J� est� cancelado"
            Case 1412
                Return "[1412] - CFe de cancelamento n�o corresponde a um CFe emitido nos 30 minutos anteriores ao pedido de cancelamento"
            Case 1999
                Return "[1999] - Erro desconhecido"
            Case 6001
                Return "[6001] - C�digo de ativa��o inv�lido"
            Case 6002
                Return "[6002] - SAT ainda n�o ativado"
            Case 6003
                Return "[6003] - SAT n�o vinculado ao AC"
            Case 6004
                Return "[6004] - Vincula��o do AC n�o confere"
            Case 6005
                Return "[6005] - Tamanho do CFe superior a 1500KB"
            Case 6006
                Return "[6006] - SAT bloqueado pelo contribuinte"
            Case 6007
                Return "[6007] - SAT bloqueado pela SEFAZ"
            Case 6008
                Return "[6008] - SAT bloqueado por falta de comunica��o"
            Case 6009
                Return "[6009] - SAT bloqueado, c�digo de ativa��o incorreto"
            Case 6010
                Return "[6010] - Erro de valida��o do conte�do"
            Case 6098
                Return "[6098] - SAT em processamento. Tente novamente"
            Case 6099
                Return "[6099] - Erro desconhecido"
            Case 7001
                Return "[7001] - C�digo de ativa��o inv�lido"
            Case 7002
                Return "[7002] - Cupom Inv�lido"
            Case 7003
                Return "[7003] - SAT bloqueado pelo contribuinte"
            Case 7004
                Return "[7004] - SAT bloqueado pela SEFAZ"
            Case 7005
                Return "[7005] - SAT bloqueado por falta de comunica��o"
            Case 7006
                Return "[7006] - SAT bloqueado, c�digo de ativa��o incorreto"
            Case 7007
                Return "[7007] - Erro de valida��o do conte�do"
            Case 7098
                Return "[7098] - SAT em processamento. Tente novamente"
            Case 7099
                Return "[7099] - Erro desconhecido"
            Case 8098
                Return "[8098] - SAT em processamento. Tente novamente"
            Case 8099
                Return "[8099] - Erro desconhecido"
            Case 10001
                Return "[10001] - C�digo de ativa��o inv�lido"
            Case 10098
                Return "[10098] - SAT em processamento. Tente novamente"
            Case 10099
                Return "[10099] - Erro desconhecido"
            Case 13001
                Return "[13001] - C�digo de ativa��o inv�lido"
            Case 13002
                Return "[13002] - Erro de comunica��o com a SEFAZ"
            Case 13003
                Return "[13003] - Assinatura fora do padr�o informado"
            Case 13098
                Return "[13098] - SAT em processamento. Tente novamente"
            Case 13099
                Return "[13099] - Erro desconhecido"
            Case Else
                Return "[" & iRetMetodo.ToString() & "] - N�mero de Erro n�o identificado... Consulte a Especifica��o de Requisitos SAT vigente."
        End Select

    End Function

End Class


