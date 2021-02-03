Module clsBematech

    Public Declare Function IniciaPorta Lib "MP2032.DLL" (ByVal Porta As String) As Integer
    Public Declare Function BematechTX Lib "MP2032.DLL" (ByVal comando As String) As Integer
    Public Declare Function ComandoTX Lib "MP2032.DLL" (ByVal BufTrans As String, ByVal Flag As Integer) As Integer
    Public Declare Function CaracterGrafico Lib "MP2032.DLL" (ByVal BufTrans As String, ByVal TamBufTrans As Integer) As Integer
    Public Declare Function Le_Status Lib "MP2032.DLL" () As Integer
    Public Declare Function AutenticaDoc Lib "MP2032.DLL" (ByVal texto As String, ByVal tempo As Integer) As Integer
    Public Declare Function DocumentInserted Lib "MP2032.DLL" () As Integer
    Public Declare Function FechaPorta Lib "MP2032.DLL" () As Integer
    Public Declare Function Le_Status_Gaveta Lib "MP2032.DLL" () As Integer
    Public Declare Function ConfiguraTamanhoExtrato Lib "MP2032.DLL" (ByVal NumeroLinhas As Integer) As Integer
    Public Declare Function HabilitaExtratoLongo Lib "MP2032.DLL" (ByVal Flag As Integer) As Integer
    Public Declare Function HabilitaEsperaImpressao Lib "MP2032.DLL" (ByVal Flag As Integer) As Integer
    Public Declare Function EsperaImpressao Lib "MP2032.DLL" () As Integer
    Public Declare Function ConfiguraModeloImpressora Lib "MP2032.DLL" (ByVal ModeloImpressora As Integer) As Integer
    Public Declare Function AcionaGuilhotina Lib "MP2032.DLL" (ByVal Modo As Integer) As Integer
    Public Declare Function FormataTX Lib "MP2032.DLL" (ByVal BufTrans As String, ByVal TpoLtra As Integer, ByVal Italic As Integer, ByVal Sublin As Integer, ByVal Expand As Integer, ByVal Enfat As Integer) As Integer
    Public Declare Function HabilitaPresenterRetratil Lib "MP2032.DLL" (ByVal iFlag As Integer) As Integer
    Public Declare Function ProgramaPresenterRetratil Lib "MP2032.DLL" (ByVal iTempo As Integer) As Integer
    Public Declare Function VerificaPapelPresenter Lib "MP2032.DLL" () As Integer
    Public Declare Function SelecionaQualidadeImpressao Lib "MP2032.DLL" (ByVal Flag As Integer) As Integer
    ' Função para Configuração dos Códigos de Barras



    Public Declare Function ConfiguraCodigoBarras Lib "MP2032.DLL" (ByVal Altura As Integer, ByVal Largura As Integer, ByVal PosicaoCaracteres As Integer, ByVal Fonte As Integer, ByVal Margem As Integer) As Integer

    ' Funções para impressão dos códigos de barras

    Public Declare Function ImprimeCodigoBarrasUPCA Lib "MP2032.DLL" (ByVal Codigo As String) As Integer
    Public Declare Function ImprimeCodigoBarrasUPCE Lib "MP2032.DLL" (ByVal Codigo As String) As Integer
    Public Declare Function ImprimeCodigoBarrasEAN13 Lib "MP2032.DLL" (ByVal Codigo As String) As Integer
    Public Declare Function ImprimeCodigoBarrasEAN8 Lib "MP2032.DLL" (ByVal Codigo As String) As Integer
    Public Declare Function ImprimeCodigoBarrasCODE39 Lib "MP2032.DLL" (ByVal Codigo As String) As Integer
    Public Declare Function ImprimeCodigoBarrasCODE93 Lib "MP2032.DLL" (ByVal Codigo As String) As Integer
    Public Declare Function ImprimeCodigoBarrasCODE128 Lib "MP2032.DLL" (ByVal Codigo As String) As Integer
    Public Declare Function ImprimeCodigoBarrasITF Lib "MP2032.DLL" (ByVal Codigo As String) As Integer
    Public Declare Function ImprimeCodigoBarrasCODABAR Lib "MP2032.DLL" (ByVal Codigo As String) As Integer
    Public Declare Function ImprimeCodigoBarrasISBN Lib "MP2032.DLL" (ByVal Codigo As String) As Integer
    Public Declare Function ImprimeCodigoBarrasMSI Lib "MP2032.DLL" (ByVal Codigo As String) As Integer
    Public Declare Function ImprimeCodigoBarrasPLESSEY Lib "MP2032.DLL" (ByVal Codigo As String) As Integer
    Public Declare Function ImprimeCodigoBarrasPDF417 Lib "MP2032.DLL" (ByVal NivelCorrecaoErros As Integer, ByVal Altura As Integer, ByVal Largura As Integer, ByVal Colunas As Integer, ByVal Codigo As String) As Integer


    Public Declare Function ImprimeCodigoQRCODE Lib "MP2032.DLL" (ByVal errorCorrectionLevel As Integer, ByVal moduleSize As Integer, ByVal codeType As Integer, ByVal QRCodeVersion As Integer, ByVal encodingModes As Integer, ByVal codeQr As String) As Integer
    ' Funções para impressão de BitMap

    Public Declare Function ImprimeBitmap Lib "MP2032.DLL" (ByVal Name As String, ByVal mode As Integer) As Integer
    Public Declare Function ImprimeBmpEspecial Lib "MP2032.DLL" (ByVal Name As String, ByVal xScale As Integer, ByVal yScale As Integer, ByVal angle As Integer) As Integer
    Public Declare Function AjustaLarguraPapel Lib "MP2032.DLL" (ByVal width As Integer) As Integer
    Public Declare Function SelectDithering Lib "MP2032.DLL" (ByVal type As Integer) As Integer

End Module
