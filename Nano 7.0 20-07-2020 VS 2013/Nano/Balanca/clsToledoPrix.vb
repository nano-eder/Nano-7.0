Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Runtime.InteropServices
Public Class clsToledoPrix
    <DllImport("P05.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function AbrePorta(ByVal Porta As Integer, ByVal BaudRate As Integer, ByVal DataBits As Integer, ByVal Paridade As Integer) As Integer
    End Function

    <DllImport("P05.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function FechaPorta() As Integer
    End Function

    <DllImport("P05.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function PegaPeso(ByVal OpcaoEscrita As Integer, ByVal DadosPeso As Byte(), ByVal Local As String) As Integer
    End Function
End Class
