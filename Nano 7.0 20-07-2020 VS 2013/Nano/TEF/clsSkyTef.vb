Module clsSkyTef
    Public Declare Function ConfiguraIntSiTefInterativo Lib "CliSitef32I.dll" (ByVal pEnderecoIP As String, ByVal pCodigoLoja As String, ByVal pNumeroTerminal As String, ByVal ConfiguraResultado As Integer) As Integer
    Public Declare Function IniciaFuncaoSiTefInterativo Lib "CliSitef32I.dll" (ByVal Funcao As Long, ByVal pValor As String, ByVal pCuponFiscal As String, ByVal pDataFiscal As String, ByVal pHorario As String, ByVal pOperador As String, ByVal pParamAdic As String) As Integer
    Public Declare Function FinalizaTransacaoSiTefInterativo Lib "CliSitef32I.dll" (ByVal Confirma As Integer, ByVal pNumeroCuponFiscal As String, ByVal pDataFiscal As String, ByVal pHorario As String) As Integer
    Public Declare Function ContinuaFuncaoSiTefInterativo Lib "CliSitef32I.dll" (ByRef pProximoComando As Long, ByRef pTipoCampo As Long, ByRef pTamanhoMinimo As Integer, ByRef pTamanhoMaximo As Integer, ByVal pBuffer As String, ByVal TamMaxBuffer As Long, ByVal ContinuaNavegacao As Long) As Integer

    Public ResultadoTEF As Long
End Module
