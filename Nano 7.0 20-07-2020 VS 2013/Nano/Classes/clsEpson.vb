Module clsEpson

    Public Declare Function IniciaPorta Lib "InterfaceEpsonNF.DLL" (ByVal Porta As String) As Integer
    Public Declare Function ImprimeTexto Lib "InterfaceEpsonNF.DLL" (ByVal comando As String) As Integer
    'Public Declare Function ComandoTX Lib "InterfaceEpsonNF.DLL" (ByVal BufTrans As String, ByVal Flag As Integer) As Integer
    Public Declare Function ImprimeTextoTag Lib "InterfaceEpsonNF.DLL" (ByVal comando As String) As Integer
    'Public Declare Function Le_Status Lib "InterfaceEpsonNF.DLL" () As Integer
    'Public Declare Function AutenticaDoc Lib "InterfaceEpsonNF.DLL" (ByVal texto As String, ByVal tempo As Integer) As Integer
    'Public Declare Function DocumentInserted Lib "InterfaceEpsonNF.DLL" () As Integer
    Public Declare Function FechaPorta Lib "InterfaceEpsonNF.DLL" () As Integer
    'Public Declare Function Le_Status_Gaveta Lib "InterfaceEpsonNF.DLL" () As Integer
    'Public Declare Function ConfiguraTamanhoExtrato Lib "InterfaceEpsonNF.DLL" (ByVal NumeroLinhas As Integer) As Integer
    'Public Declare Function HabilitaExtratoLongo Lib "InterfaceEpsonNF.DLL" (ByVal Flag As Integer) As Integer
    'Public Declare Function HabilitaEsperaImpressao Lib "InterfaceEpsonNF.DLL" (ByVal Flag As Integer) As Integer
    'Public Declare Function EsperaImpressao Lib "InterfaceEpsonNF.DLL" () As Integer
    'Public Declare Function ConfiguraModeloImpressora Lib "InterfaceEpsonNF.DLL" (ByVal ModeloImpressora As Integer) As Integer
    Public Declare Function AcionaGuilhotina Lib "InterfaceEpsonNF.DLL" (ByVal Modo As Integer) As Integer
    Public Declare Function FormataTX Lib "InterfaceEpsonNF.DLL" (ByVal BufTrans As String, ByVal TpoLtra As Integer, ByVal Italic As Integer, ByVal Sublin As Integer, ByVal Expand As Integer, ByVal Enfat As Integer) As Integer
    'Public Declare Function HabilitaPresenterRetratil Lib "InterfaceEpsonNF.DLL" (ByVal iFlag As Integer) As Integer
    'Public Declare Function ProgramaPresenterRetratil Lib "InterfaceEpsonNF.DLL" (ByVal iTempo As Integer) As Integer
    'Public Declare Function VerificaPapelPresenter Lib "InterfaceEpsonNF.DLL" () As Integer
    'Public Declare Function SelecionaQualidadeImpressao Lib "InterfaceEpsonNF.DLL" (ByVal Flag As Integer) As Integer
    '' Função para Configuração dos Códigos de Barras



    Public Declare Function ConfiguraCodigoBarras Lib "InterfaceEpsonNF.DLL" (ByVal Altura As Integer, ByVal Largura As Integer, ByVal PosicaoCaracteres As Integer, ByVal Fonte As Integer, ByVal Margem As Integer) As Integer

    '' Funções para impressão dos códigos de barras

    'Public Declare Function ImprimeCodigoBarrasUPCA Lib "MP2032.DLL" (ByVal Codigo As String) As Integer
    'Public Declare Function ImprimeCodigoBarrasUPCE Lib "MP2032.DLL" (ByVal Codigo As String) As Integer
    'Public Declare Function ImprimeCodigoBarrasEAN13 Lib "MP2032.DLL" (ByVal Codigo As String) As Integer
    'Public Declare Function ImprimeCodigoBarrasEAN8 Lib "MP2032.DLL" (ByVal Codigo As String) As Integer
    'Public Declare Function ImprimeCodigoBarrasCODE39 Lib "MP2032.DLL" (ByVal Codigo As String) As Integer
    'Public Declare Function ImprimeCodigoBarrasCODE93 Lib "MP2032.DLL" (ByVal Codigo As String) As Integer
    Public Declare Function ImprimeCodigoBarrasCODE128 Lib "InterfaceEpsonNF.DLL" (ByVal Codigo As String) As Integer
    'Public Declare Function ImprimeCodigoBarrasITF Lib "MP2032.DLL" (ByVal Codigo As String) As Integer
    'Public Declare Function ImprimeCodigoBarrasCODABAR Lib "MP2032.DLL" (ByVal Codigo As String) As Integer
    'Public Declare Function ImprimeCodigoBarrasISBN Lib "MP2032.DLL" (ByVal Codigo As String) As Integer
    'Public Declare Function ImprimeCodigoBarrasMSI Lib "MP2032.DLL" (ByVal Codigo As String) As Integer
    'Public Declare Function ImprimeCodigoBarrasPLESSEY Lib "MP2032.DLL" (ByVal Codigo As String) As Integer
    'Public Declare Function ImprimeCodigoBarrasPDF417 Lib "MP2032.DLL" (ByVal NivelCorrecaoErros As Integer, ByVal Altura As Integer, ByVal Largura As Integer, ByVal Colunas As Integer, ByVal Codigo As String) As Integer


    Public Declare Function ImprimeCodigoQRCODE Lib "InterfaceEpsonNF.DLL" (ByVal errorCorrectionLevel As Integer, ByVal moduleSize As Integer, ByVal codeType As Integer, ByVal QRCodeVersion As Integer, ByVal encodingModes As Integer, ByVal codeQr As String) As Integer
    '' Funções para impressão de BitMap

    'Public Declare Function ImprimeBitmap Lib "MP2032.DLL" (ByVal Name As String, ByVal mode As Integer) As Integer
    'Public Declare Function ImprimeBmpEspecial Lib "MP2032.DLL" (ByVal Name As String, ByVal xScale As Integer, ByVal yScale As Integer, ByVal angle As Integer) As Integer
    'Public Declare Function AjustaLarguraPapel Lib "MP2032.DLL" (ByVal width As Integer) As Integer
    'Public Declare Function SelectDithering Lib "MP2032.DLL" (ByVal type As Integer) As Integer
End Module

