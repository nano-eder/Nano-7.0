Imports System.Text
Imports System.Runtime.InteropServices
Public Class clsTancaSatDLL
    <DllImport("dllsattanca.dll", CallingConvention:=CallingConvention.Cdecl)> _
          Public Shared Function ConsultarSAT(ByVal nSessionRandom As Int32) As IntPtr
    End Function

    <DllImport("dllsattanca.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function EnviarDadosVenda(ByVal nSessionRandom As Int32, ByVal codigoDeAtivacao As String, ByVal dadosVenda As String) As IntPtr
    End Function

    '<DllImport("dllsattanca.dll", CallingConvention:=CallingConvention.Cdecl)> _
    'Public Shared Function Base64ToAscii() As IntPtr
    'End Function

    <DllImport("dllsattanca.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function ConsultarNumeroSessao(ByVal nSessionRandom As Int32, ByVal codigoDeAtivacao As String, ByVal cNumeroDeSessao As Integer) As IntPtr
    End Function

    <DllImport("dllsattanca.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function CancelarUltimaVenda(ByVal nSessionRandom As Int32, ByVal codigoDeAtivacao As String, ByVal chave As String, ByVal dadosCancelamento As String) As IntPtr
    End Function

    <DllImport("dllsattanca.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function ConsultarStatusOperacional(ByVal nSessionRandom As Int32, ByVal codigoDeAtivacao As String) As IntPtr
    End Function

    <DllImport("dllsattanca.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function ExtrairLogs(ByVal nSessionRandom As Int32, ByVal codigoDeAtivacao As String) As IntPtr
    End Function

    <DllImport("dllsattanca.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function ConfigurarInterfaceDeRede(ByVal nSessionRandom As Int32, ByVal codigoDeAtivacao As String, ByVal dadosVenda As String) As IntPtr
    End Function

    <DllImport("dllsattanca.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function AtivarSAT(ByVal nSessionRandom As Int32, ByVal SubComando As Integer, ByVal codigoDeAtivacao As String, ByVal CNPJ As String, ByVal cUF As Integer) As IntPtr
    End Function

    <DllImport("dllsattanca.dll", CallingConvention:=CallingConvention.Cdecl)> _
   Public Shared Function AssociarAssinatura(ByVal nSessionRandom As Int32, ByVal codigoDeAtivacao As String, ByVal CNPJValue As String, ByVal assinaturaCNPJs As String) As IntPtr
    End Function

    <DllImport("dllsattanca.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function TrocarCodigoDeAtivacao(ByVal nSessionRandom As Int32, ByVal codigoDeAtivacao As String, ByVal novoCodigo As String, ByVal confNovoCodigo As String) As IntPtr
    End Function

    <DllImport("dllsattanca.dll", CallingConvention:=CallingConvention.Cdecl)> _
   Public Shared Function AtualizarSoftwareSAT(ByVal nSessionRandom As Int32, ByVal codigoDeAtivacao As String) As IntPtr
    End Function
    Public Shared Function Base64ToAscii(ByVal parString As String, ByVal parNivel As Integer) As String
        Dim array As Array = Split(parString, "|")

        Dim base64Encoded As String = array(parNivel).ToString

        Dim base64Decoded As String

        Dim data() As Byte

        data = System.Convert.FromBase64String(base64Encoded)

        'base64Decoded = System.Text.ASCIIEncoding.ASCII.GetString(data)

        base64Decoded = Encoding.UTF8.GetString(data)

        Return base64Decoded
    End Function
End Class
