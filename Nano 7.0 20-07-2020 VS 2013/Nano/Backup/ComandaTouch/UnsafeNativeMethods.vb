Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Runtime.InteropServices

' agradecimientos a "cubika" de GitHub
' https://github.com/cubika/OneCode/blob/master/Visual%20Studio%202010/CSSoftKeyboard/NoActivate/UnsafeNativeMethods.cs
Public Class UnsafeNativeMethods

    ''' <summary>
    ''' Obtener un identificador de la ventana en primer plano.
    ''' http://msdn.microsoft.com/en-us/library/ms633505(VS.85).aspx
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function GetForegroundWindow() As IntPtr
    End Function

    ''' <summary>
    ''' El subproceso que creó la ventana especificada al hilo primer plano, y la ventana activa.
    ''' http://msdn.microsoft.com/en-us/library/ms633539(VS.85).aspx
    ''' </summary>
    ''' <param name="hWnd"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function SetForegroundWindow(ByVal hWnd As IntPtr) As Boolean
    End Function

    ''' <summary>
    ''' Determinar si el identificador de ventana especificado puede determinar una ventana existente.
    ''' http://msdn.microsoft.com/en-us/library/ms633528(VS.85).aspx
    ''' </summary>
    ''' <param name="hWnd"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function IsWindow(ByVal hWnd As IntPtr) As Boolean
    End Function

End Class
