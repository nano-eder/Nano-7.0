Option Strict Off
Option Explicit On
Module SATFiscalDLL
    Public SatRetorno As String

    ' ''Public Declare Function EnviarDadosVenda Lib "dllsat.dll" (ByVal numeroSessao As Integer, ByVal codigoDeAtivacao As String, ByVal dadosVenda As String) As String
    ' ''Public Declare Function Base64ToAscii Lib "dllsat.dll" () As String
    ' ''Public Declare Function ConsultarNumeroSessao Lib "dllsat.dll" (ByVal numeroSessao As Integer, ByVal codigoDeAtivacao As String, ByVal cNumeroDeSessao As Integer) As String
    ' ''Public Declare Function CancelarUltimaVenda Lib "dllsat.dll" (ByVal numeroSessao As Integer, ByVal codigoDeAtivacao As String, ByVal chave As String, ByVal dadosCancelamento As String) As String


    'Public Declare Function ExtrairLogs Lib "dllsat.dll" (ByVal numeroSessao As Long, ByVal codigoDeAtivacao As String) As String



    ' ''Public Declare Function ConsultarSAT Lib "dllsat.dll" (ByVal NumeroSessao As Short) As String
    ' ''Public Declare Function ConsultarStatusOperacional Lib "dllsat.dll" (ByVal NumeroSessao As Short, ByVal codigoDeAtivacao As String) As String
    ' ''Public Declare Function ExtrairLogs Lib "dllsat.dll" (ByVal numeroSessaso As Short, ByVal codigoDeAtivacao As String) As String
    ' ''Public Declare Function BloquearSAT Lib "dllsat.dll" (ByVal NumeroSessao As Short, ByVal codigoDeAtivacao As String) As String
    ' ''Public Declare Function DesbloquearSAT Lib "dllsat.dll" (ByVal NumeroSessao As Short, ByVal codigoDeAtivacao As String) As String

    'Public Declare Function ConsultarNumeroSessao Lib "dllsat.dll" (ByVal NumeroSessao As Short, ByVal codigoDeAtivacao As String, ByVal cNumeroDeSessao As Short) As String

    ' ''Public Declare Function AtualizarSoftwareSAT Lib "dllsat.dll" (ByVal NumeroSessao As Short, ByVal codigoDeAtivacao As String, ByVal cNumeroDeSessao As Short) As String
    ' ''Public Declare Function AtivarSAT Lib "dllsat.dll" (ByVal NumeroSessao As Short, ByVal tipoCert As Short, ByVal codigoDeAtivacao As String, ByVal CNPJ As String, ByVal cUF As Short) As String
    ' ''Public Declare Function TrocarCodigoDeAtivacao Lib "dllsat.dll" (ByVal NumeroSessao As Short, ByVal codigoDeAtivacao As String, ByVal opcao As Short, ByVal novoCodigo As String, ByVal confNovoCodigo As String) As String
    ' ''Public Declare Function AssociarAssinaturaSignAC Lib "dllsat.dll" (ByVal NumeroSessao As Short, ByVal codigoDeAtivacao As String, ByVal CNPJcontribuinte As String, ByVal CNPJSoftwareHouse As String, ByVal assinaturaCNPJs As String) As String
    ' ''Public Declare Function ConfigurarInterfaceDeRede Lib "dllsat.dll" (ByVal NumeroSessao As Short, ByVal codigoDeAtivacao As String, ByVal xmlConfig As String) As String
    ' ''Public Declare Function TesteFimAFim Lib "dllsat.dll" (ByVal NumeroSessao As Short, ByVal codigoAtivacao As String, ByVal dadosVenda As String) As String



    'Public Declare Function EnviarDadosVenda Lib "dllsat.dll" (ByVal NumeroSessao As Short, ByVal codigoDeAtivacao As String, ByVal dadosVenda As String) As String
    'Public Declare Function CancelarUltimaVenda Lib "dllsat.dll" (ByVal NumeroSessao As Short, ByVal codigoAtivacao As String, ByVal chave As String, ByVal assinaturaCNPJs As String) As String

End Module
