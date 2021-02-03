Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Runtime.InteropServices
Public Class clsTEF
    '    <DllImport("CliSitef32I.dll", CallingConvention:=CallingConvention.Cdecl)> _
    '    Public Shared Function ConfiguraIntSiTefInterativo(ByVal pEnderecoIP As String, ByVal pCodigoLoja As String, ByVal pNumeroTerminal As String, ByVal ConfiguraResultado As Integer) As IntPtr
    '    End Function


    '   <DllImport("CliSitef32I.dll", CallingConvention:=CallingConvention.Cdecl)> _
    'Public Shared Function IniciaFuncaoSiTefInterativo(ByVal Funcao As Integer, ByVal pValor As String, ByVal pCuponFiscal As String, ByVal pDataFiscal As String, ByVal pHorario As String, ByVal pOperador As String, ByVal pParamAdic As String) As Integer
    '   End Function

    '    <DllImport("CliSitef32I.dll", CallingConvention:=CallingConvention.Cdecl)> _
    'Public Shared Function FinalizaTransacaoSiTefInterativo(ByVal Confirma As Integer, ByVal pNumeroCuponFiscal As String, ByVal pDataFiscal As String, ByVal pHorario As String) As IntPtr
    '    End Function

    '    <DllImport("CliSitef32I.dll", CallingConvention:=CallingConvention.Cdecl)> _
    'Public Shared Function ContinuaFuncaoSiTefInterativo(ByRef pProximoComando As Integer, ByRef pTipoCampo As Integer, ByRef pTamanhoMinimo As Short, ByRef pTamanhoMaximo As Short, ByVal pBuffer As Byte(), ByVal TamMaxBuffer As Long, ByVal ContinuaNavegacao As Long) As Integer
    '    End Function

    '    Public Shared Function Base64ToAscii(ByVal parString As String, ByVal parNivel As Integer) As String
    '        Dim array As Array = Split(parString, "|")

    '        Dim base64Encoded As String = array(parNivel).ToString

    '        Dim base64Decoded As String

    '        Dim data() As Byte

    '        data = System.Convert.FromBase64String(base64Encoded)

    '        'base64Decoded = System.Text.ASCIIEncoding.ASCII.GetString(data)

    '        base64Decoded = Encoding.UTF8.GetString(data)

    '        Return base64Decoded
    '    End Function

    <DllImport("CliSiTef32I.dll", EntryPoint:="ConfiguraIntSiTefInterativo", CharSet:=CharSet.Auto, SetLastError:=True)> _
   Public Shared Function ConfiguraIntSiTefInterativo(ByVal pEnderecoIP As Byte(), ByVal pCodigoLoja As Byte(), ByVal pNumeroTerminal As Byte(), ByVal ConfiguraResultado As Short) As Integer
    End Function

    <DllImport("CliSitef32I.dll", EntryPoint:="IniciaFuncaoSiTefInterativo", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function IniciaFuncaoSiTefInterativo(ByVal Funcao As Integer, ByVal pValor As Byte(), ByVal pCupomFiscal As Byte(), ByVal pDataFiscal As Byte(), ByVal pHorario As Byte(), ByVal pOperador As Byte(), _
    ByVal pRestricoes As Byte()) As Integer
    End Function

    <DllImport("CliSitef32I.dll", EntryPoint:="ContinuaFuncaoSiTefInterativo", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function ContinuaFuncaoSiTefInterativo(ByRef pComando As Integer, ByRef pTipoCampo As Integer, ByRef pTamMinimo As Short, ByRef pTamMaximo As Short, ByVal pBuffer As Byte(), ByVal TamBuffer As Integer, _
    ByVal Continua As Integer) As Integer
    End Function

    <DllImport("CliSiTef32I.dll", EntryPoint:="EnviaRecebeSiTefDireto", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function EnviaRecebeSiTefDireto(ByVal RedeDestino As Short, ByVal FuncaoSiTef As Short, ByVal OffsetCartao As Short, ByVal pDadosTx As Byte(), ByVal TamDadosTx As Short, ByVal pDadosRx As Byte(), _
    ByVal TamMaxDadosRx As Short, ByVal pCodigoResposta As Short(), ByVal TempoEsperaRx As Short, ByVal pNumeroCupon As Byte(), ByVal pDataFiscal As Byte(), ByVal pHorario As Byte(), _
    ByVal pOperador As Byte(), ByVal TipoTransacao As Short) As Integer
    End Function



    <DllImport("CliSitef32I.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function FinalizaTransacaoSiTefInterativo(ByVal Confirma As Integer, ByVal pNumeroCuponFiscal As String, ByVal pDataFiscal As String, ByVal pHorario As String) As IntPtr
    End Function

    <DllImport("CliSiTef32I.dll", EntryPoint:="LeSimNaoPinPad", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function LeSimNaoPinPad(ByVal pMsgDisplay As Byte()) As Integer
    End Function

    <DllImport("CliSiTef32I.dll", EntryPoint:="AbrePinPad", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function AbrePinPad() As Integer
    End Function

    <DllImport("CliSiTef32I.dll", EntryPoint:="FechaPinPad", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function FechaPinPad() As Integer
    End Function

    <DllImport("CliSiTef32I.dll", EntryPoint:="LeCartaoDireto", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function LeCartaoDireto(ByVal pMsgDisplay As Byte(), ByVal trilha1 As Byte(), ByVal trilha2 As Byte()) As Integer
    End Function
End Class
