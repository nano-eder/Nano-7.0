Imports System.Net

Namespace ConsultaCNPJ
    Public Class CookieAwareWebClient
        Inherits WebClient
        Private _mContainer As CookieContainer

        Public Sub SetCookieContainer(ByVal container As CookieContainer)
            _mContainer = container
        End Sub

        Protected Overrides Function GetWebRequest(ByVal address As Uri) As WebRequest
            Dim request As WebRequest = MyBase.GetWebRequest(address)
            Dim webRequest = TryCast(request, HttpWebRequest)
            If webRequest IsNot Nothing Then
                webRequest.CookieContainer = _mContainer
                webRequest.KeepAlive = True
                webRequest.ProtocolVersion = HttpVersion.Version10
            End If
            Return request
        End Function
    End Class
End Namespace

