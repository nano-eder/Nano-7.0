Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Runtime.InteropServices
Public Class clsDimepSatDLL

    <DllImport("dllsat.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function ConsultarSAT(ByVal nSessionRandom As Int32) As IntPtr
    End Function

    <DllImport("dllsat.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function EnviarDadosVenda(ByVal nSessionRandom As Int32, ByVal codigoDeAtivacao As String, ByVal dadosVenda As String) As IntPtr
    End Function

    <DllImport("dllsat.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function Base64ToAscii() As IntPtr
    End Function

    <DllImport("dllsat.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function ConsultarNumeroSessao(ByVal nSessionRandom As Int32, ByVal codigoDeAtivacao As String, ByVal cNumeroDeSessao As Integer) As IntPtr
    End Function

    <DllImport("dllsat.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function CancelarUltimaVenda(ByVal nSessionRandom As Int32, ByVal codigoDeAtivacao As String, ByVal chave As String, ByVal dadosCancelamento As String) As IntPtr
    End Function

    <DllImport("dllsat.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function ConsultarStatusOperacional(ByVal nSessionRandom As Int32, ByVal codigoDeAtivacao As String) As IntPtr
    End Function

    <DllImport("dllsat.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function ExtrairLogs(ByVal nSessionRandom As Int32, ByVal codigoDeAtivacao As String) As IntPtr
    End Function

    <DllImport("dllsat.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function ConfigurarInterfaceDeRede(ByVal nSessionRandom As Int32, ByVal codigoDeAtivacao As String, ByVal dadosVenda As String) As IntPtr
    End Function

    <DllImport("dllsat.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function AtivarSAT(ByVal nSessionRandom As Int32, ByVal SubComando As Integer, ByVal codigoDeAtivacao As String, ByVal CNPJ As String, ByVal cUF As Integer) As IntPtr
    End Function

    <DllImport("dllsat.dll", CallingConvention:=CallingConvention.Cdecl)> _
   Public Shared Function AssociarAssinatura(ByVal nSessionRandom As Int32, ByVal codigoDeAtivacao As String, ByVal CNPJValue As String, ByVal assinaturaCNPJs As String) As IntPtr
    End Function

    <DllImport("dllsat.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function TrocarCodigoDeAtivacao(ByVal nSessionRandom As Int32, ByVal codigoDeAtivacao As String, ByVal novoCodigo As String, ByVal confNovoCodigo As String) As IntPtr
    End Function

    <DllImport("dllsat.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function AtualizarSoftwareSAT(ByVal nSessionRandom As Int32, ByVal codigoDeAtivacao As String) As IntPtr
    End Function
End Class
